using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using psai.net;

public class BathhouseGameEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		ResetEvent
	}

	[CompilerGenerated]
	private sealed class ICCJHFPPOAG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public BathhouseGameEvent _003C_003E4__this;

		public bool enable;

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
		public ICCJHFPPOAG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			int num = _003C_003E1__state;
			BathhouseGameEvent bathhouseGameEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (time == 5f)
				{
					_003C_003E2__current = CommonReferences.wait5;
					_003C_003E1__state = 1;
					return true;
				}
				if (time == 10f)
				{
					_003C_003E2__current = CommonReferences.wait10;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = (object)new WaitForSeconds(time);
				_003C_003E1__state = 3;
				return true;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			case 3:
				_003C_003E1__state = -1;
				break;
			}
			bathhouseGameEvent.EnableNPCs(enable);
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
	private sealed class HBDFGEPMIPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BathhouseGameEvent _003C_003E4__this;

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
		public HBDFGEPMIPM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			BathhouseGameEvent bathhouseGameEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
				if (OnlineManager.PlayingOnline())
				{
					if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
					{
						((Component)PlayerController.GetPlayer(1)).transform.position = bathhouseGameEvent.zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
						PlayerController.GetPlayer(1).SetDirection(Direction.Right);
					}
					for (int i = 1; i < 5; i++)
					{
						if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
						{
							PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
						}
					}
				}
				else
				{
					for (int j = 1; j < 3; j++)
					{
						if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
						{
							((Component)PlayerController.GetPlayer(j)).transform.position = bathhouseGameEvent.zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
							PlayerController.GetPlayer(j).SetDirection(Direction.Right);
							PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
						}
					}
				}
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
					ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
				}
				((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
				ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
				((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = bathhouseGameEvent.zuzzuPosition.position;
				ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
				ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
					ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
					((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
					ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
				}
				KentaNPC.GGFJGHHHEJC.content.SetActive(false);
				RinNPC.GGFJGHHHEJC.content.SetActive(false);
				PsaiCore.Instance.StopMusic(immediately: false);
				MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
				instance.EnableNPCs(OEDBPACCOGH: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
				FadeCamera.FadeInAllPlayers();
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
	private sealed class DLOMBCNFCFG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool endEvent;

		public BathhouseGameEvent _003C_003E4__this;

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
		public DLOMBCNFCFG(int _003C_003E1__state)
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
			BathhouseGameEvent bathhouseGameEvent = _003C_003E4__this;
			switch (num)
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
			if (Utils.NGLLIJPOBEC(Location.BathhouseInterior))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (endEvent)
			{
				((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
				ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
				KentaNPC.GGFJGHHHEJC.content.SetActive(true);
				RinNPC.GGFJGHHHEJC.content.SetActive(true);
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
					ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
					((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
					KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
					((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
					RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				}
			}
			else
			{
				bathhouseGameEvent.GJBNMNBAJIP();
			}
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
			bathhouseGameEvent.EnableNPCs(OEDBPACCOGH: true);
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
	private sealed class KEFDIEMOIGE : IEnumerator<object>, IEnumerator, IDisposable
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
		public KEFDIEMOIGE(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				BathhouseGameManager.Restart();
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

	public static BathhouseGameEvent instance;

	public Transform zuzzuPosition;

	public GameObject bucketPilar;

	public GameObject[] NPCsToDisable;

	private Coroutine ANMAFLKPILP;

	private IEnumerator IMABNNLFIAO()
	{
		return new HBDFGEPMIPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LCOAFEGGNPA()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)ZuzzuNPC.AHBBHCKPIIJ().routine).enabled = true;
			ZuzzuNPC.ELGNEJNLBNO().routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.OAPOJCODNCO().routine.noDisableOnReset = true;
			((Behaviour)RinNPC.POAGAIBEFBF().routine).enabled = true;
			ZuzzuNPC.KNLLFEJAMNN().routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.CHPEMJMLDCN()).transform.parent = null;
		ZuzzuNPC.DICHPHEOINO().animationBase.CGEADHOLHCH("end dialogue", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.JFJOKGAOPHA().content.SetActive(false);
		ZuzzuNPC.OAPOJCODNCO().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.POAGAIBEFBF().content.SetActive(true);
	}

	private IEnumerator IHDNGDHCMJA()
	{
		return new HBDFGEPMIPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AIGPCLDGAHL(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.DPHKIFBGOPK());
	}

	public void JBHGNJFKJGG()
	{
		FadeCamera.FadeOutAllPlayers(1121f);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(instance.NIHJICNGOFG));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void MBGFDDJDAOK(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			ActivateEvent();
			return;
		}
		EventsManager.PMJAHPMMPJH((EventsManager.EventType)162, DMBFKFLDDLH: false);
		Debug.Log((object)"Items/item_description_1152");
	}

	public void JKFGFHMDOKB()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.KNLLFEJAMNN().StartConversation(1, "Collect water", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.JFJOKGAOPHA().StartObserverDialogueWhenItIsPossible(0));
		}
		Utils.DLIIAHACOJB(18);
	}

	public void KCHAKBMIFAI(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			AHEGLLPBOGG();
			return;
		}
		EventsManager.PMJAHPMMPJH((EventsManager.EventType)175, DMBFKFLDDLH: true);
		Debug.Log((object)"Disabled");
	}

	private IEnumerator LGACPHHONEL(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	private IEnumerator JFNINIPLKHJ()
	{
		((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(1)).transform.position = zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
				PlayerController.GetPlayer(1).SetDirection(Direction.Right);
			}
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				}
			}
		}
		else
		{
			for (int j = 1; j < 3; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
				{
					((Component)PlayerController.GetPlayer(j)).transform.position = zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
					PlayerController.GetPlayer(j).SetDirection(Direction.Right);
					PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		instance.EnableNPCs(OEDBPACCOGH: true);
		yield return CommonReferences.wait2;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		FadeCamera.FadeInAllPlayers();
	}

	public void IGCMEGNIEGD()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(OMAKINCGPAJ());
	}

	public void LDDBPPLGCGH(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 1535f)
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(AAFCIDLGBBK(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i += 0)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	private IEnumerator NPFEKBAKGHE(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	private IEnumerator JNALIHNBPEN(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	private IEnumerator GPMOOOOILCA()
	{
		((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(1)).transform.position = zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
				PlayerController.GetPlayer(1).SetDirection(Direction.Right);
			}
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				}
			}
		}
		else
		{
			for (int j = 1; j < 3; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
				{
					((Component)PlayerController.GetPlayer(j)).transform.position = zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
					PlayerController.GetPlayer(j).SetDirection(Direction.Right);
					PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		instance.EnableNPCs(OEDBPACCOGH: true);
		yield return CommonReferences.wait2;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		FadeCamera.FadeInAllPlayers();
	}

	private IEnumerator AAFCIDLGBBK(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		if (LGLDPMAABLA == 5f)
		{
			yield return CommonReferences.wait5;
		}
		else if (LGLDPMAABLA == 10f)
		{
			yield return CommonReferences.wait10;
		}
		else
		{
			yield return (object)new WaitForSeconds(LGLDPMAABLA);
		}
		EnableNPCs(OEDBPACCOGH);
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private void LIIABIMBFID()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.CHKMFEFOFKJ().routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.FJAMHCAAEAM().routine.noDisableOnReset = true;
			((Behaviour)RinNPC.KNLLFEJAMNN().routine).enabled = false;
			ZuzzuNPC.DICHPHEOINO().routine.noDisableOnReset = false;
		}
		((Component)ZuzzuNPC.CHPEMJMLDCN()).transform.parent = null;
		ZuzzuNPC.LFPEPJBNCBF().animationBase.SetBool("LE_21", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.JFJOKGAOPHA()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.DFJGHOHPPEL().content.SetActive(false);
		ZuzzuNPC.EBAIHKJHCCA().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.BNBMNOMFFBE().content.SetActive(true);
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void DANNDOILNOD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.JFNOOMJMHCB().StartConversation(1, "Items/item_description_1108");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.JFJOKGAOPHA().StartObserverDialogueWhenItIsPossible(1));
		}
		Utils.DLIIAHACOJB(-128);
	}

	private IEnumerator DLGFBLKGMOL()
	{
		yield return CommonReferences.wait1;
		BathhouseGameManager.Restart();
	}

	public void DDNPHOCBKKP(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 462f)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(JNALIHNBPEN(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i += 0)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	public void CKLENDEPOLJ(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 415f)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(JKCOECGACDL(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i += 0)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	public void PHFCPPGBJEN(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 476f)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(CGJIHEEKNIM(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i += 0)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	public void JCMGOOIGKPC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.JHMAMLIPBNN().StartConversation(0, "Interact");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.ELGNEJNLBNO().StartObserverDialogueWhenItIsPossible(0));
		}
		Utils.DLIIAHACOJB(-51, CDPAMNIPPEC: true);
	}

	private void DDLPECDGGMD(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.HDOELJOFKNJ());
	}

	public void WinEvent()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(1, "BathhouseGame/Win");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		Utils.DLIIAHACOJB(43);
	}

	private IEnumerator FIBONNPONHD()
	{
		return new HBDFGEPMIPM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ODABAHJJGKG(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			MBGFDDJDAOK();
			return;
		}
		EventsManager.BBLFJJEENML((EventsManager.EventType)25, DMBFKFLDDLH: false);
		Debug.Log((object)"Dialogue System/Conversation/Gass_Quest/Entry/17/Dialogue Text");
	}

	private void GJLBJDICOKO()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.KNLLFEJAMNN().routine).enabled = true;
			ZuzzuNPC.ELGNEJNLBNO().routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.AHBBHCKPIIJ().routine.noDisableOnReset = false;
			((Behaviour)RinNPC.OJJDNLEFNPJ().routine).enabled = false;
			ZuzzuNPC.DFJGHOHPPEL().routine.noDisableOnReset = false;
		}
		((Component)ZuzzuNPC.JFJOKGAOPHA()).transform.parent = null;
		ZuzzuNPC.CHPEMJMLDCN().animationBase.SetBool("Hot bath done, setting miners in cave", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((Component)ZuzzuNPC.OAPOJCODNCO()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.DICHPHEOINO().content.SetActive(false);
		ZuzzuNPC.OPDKAPNDBJE().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.AFFGPMFKEFH().content.SetActive(true);
	}

	private IEnumerator JICFPPEELCC()
	{
		yield return CommonReferences.wait1;
		BathhouseGameManager.Restart();
	}

	private IEnumerator DPGDIPBALAK()
	{
		return new KEFDIEMOIGE(1);
	}

	private IEnumerator FCMDDDOAEEF(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		if (LGLDPMAABLA == 5f)
		{
			yield return CommonReferences.wait5;
		}
		else if (LGLDPMAABLA == 10f)
		{
			yield return CommonReferences.wait10;
		}
		else
		{
			yield return (object)new WaitForSeconds(LGLDPMAABLA);
		}
		EnableNPCs(OEDBPACCOGH);
	}

	private IEnumerator EDDLLOLBAII(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	public void MDDMFJGBELP()
	{
		DialogueLua.SetVariable("Trying to get friend ", (object)0);
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.DICHPHEOINO().StartConversation(1, "UIAddRemove", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.AHBBHCKPIIJ().StartObserverDialogueWhenItIsPossible(0));
		}
		BathhouseGameManager.instance.DKJOAGEDDNN();
		if (ANMAFLKPILP == null && OnlineManager.PGAGDFAEEFB())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(EDFMCNPOAGF(HAGJFLMJHFG: false));
		}
	}

	public void CJNGBCJDBKL()
	{
		DialogueLua.SetVariable("Not enough money", (object)1);
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.JFJOKGAOPHA().StartConversation(0, "Fortitude/MainEvent 1", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.DICHPHEOINO().StartObserverDialogueWhenItIsPossible(0));
		}
		BathhouseGameManager.instance.FKJNBJMNPEJ();
		if (ANMAFLKPILP == null && OnlineManager.MasterOrOffline())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(GFGAOKCGDIE(HAGJFLMJHFG: true));
		}
	}

	public void GJAEIIFPFKC()
	{
		DialogueLua.SetVariable("nodes not free 2", (object)0);
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.KNLLFEJAMNN().StartConversation(0, "[Awning:{0}] OpenAwning called. isOpen={1} animatorBool={2}");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.DICHPHEOINO().StartObserverDialogueWhenItIsPossible(1));
		}
		BathhouseGameManager.instance.StopSounds();
		if (ANMAFLKPILP == null && OnlineManager.MasterOrOffline())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(GFGAOKCGDIE(HAGJFLMJHFG: false));
		}
	}

	private void GJBNMNBAJIP()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false, HALNIEBONKH: true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	public void EINHGPDGHMK(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 1096f)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(BGEAPPHNECA(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i++)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	private IEnumerator NMPKDBDJFAF()
	{
		return new HBDFGEPMIPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AFFLJIHIJAC(bool HAGJFLMJHFG)
	{
		while (Utils.NGLLIJPOBEC(Location.BathhouseInterior))
		{
			yield return null;
		}
		if (HAGJFLMJHFG)
		{
			((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
			ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
			KentaNPC.GGFJGHHHEJC.content.SetActive(true);
			RinNPC.GGFJGHHHEJC.content.SetActive(true);
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
				ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
				KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
				RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			}
		}
		else
		{
			GJBNMNBAJIP();
		}
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		EnableNPCs(OEDBPACCOGH: true);
	}

	private IEnumerator PBDJDOHNGBP()
	{
		yield return CommonReferences.wait1;
		BathhouseGameManager.Restart();
	}

	private IEnumerator JMOGHGLFHCO()
	{
		return new KEFDIEMOIGE(1);
	}

	private void FMGBPIGOGBG(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(instance.IMABNNLFIAO());
	}

	private IEnumerator DEMEHMNPMJE()
	{
		((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(1)).transform.position = zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
				PlayerController.GetPlayer(1).SetDirection(Direction.Right);
			}
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				}
			}
		}
		else
		{
			for (int j = 1; j < 3; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
				{
					((Component)PlayerController.GetPlayer(j)).transform.position = zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
					PlayerController.GetPlayer(j).SetDirection(Direction.Right);
					PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		instance.EnableNPCs(OEDBPACCOGH: true);
		yield return CommonReferences.wait2;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		FadeCamera.FadeInAllPlayers();
	}

	public void AJCBKGFAOHP()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(ODINFFKEKHN());
	}

	private void NIHJICNGOFG(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.IMABNNLFIAO());
	}

	private IEnumerator GFGAOKCGDIE(bool HAGJFLMJHFG)
	{
		while (Utils.NGLLIJPOBEC(Location.BathhouseInterior))
		{
			yield return null;
		}
		if (HAGJFLMJHFG)
		{
			((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
			ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
			KentaNPC.GGFJGHHHEJC.content.SetActive(true);
			RinNPC.GGFJGHHHEJC.content.SetActive(true);
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
				ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
				KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
				RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			}
		}
		else
		{
			GJBNMNBAJIP();
		}
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		EnableNPCs(OEDBPACCOGH: true);
	}

	private IEnumerator ODINFFKEKHN()
	{
		yield return CommonReferences.wait1;
		BathhouseGameManager.Restart();
	}

	public void PDMPFBCDCBO()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(OMAKINCGPAJ());
	}

	private void JLIAJHDOIBP(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.DPHKIFBGOPK());
	}

	private void OFIEGKMACFE()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.DICHPHEOINO().routine).enabled = true;
			ZuzzuNPC.DFJGHOHPPEL().routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.DCAEBALADIM().routine.noDisableOnReset = true;
			((Behaviour)RinNPC.OJJDNLEFNPJ().routine).enabled = true;
			ZuzzuNPC.KNLLFEJAMNN().routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.FJAMHCAAEAM()).transform.parent = null;
		ZuzzuNPC.DFJGHOHPPEL().animationBase.CGEADHOLHCH("questDescBoiling", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.AHBBHCKPIIJ()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.AHBBHCKPIIJ().content.SetActive(false);
		ZuzzuNPC.EBAIHKJHCCA().animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.POAGAIBEFBF().content.SetActive(false);
	}

	public void ResetEvent()
	{
		FadeCamera.FadeOutAllPlayers();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator KJCIBBFFCDO(bool HAGJFLMJHFG)
	{
		while (Utils.NGLLIJPOBEC(Location.BathhouseInterior))
		{
			yield return null;
		}
		if (HAGJFLMJHFG)
		{
			((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
			ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
			KentaNPC.GGFJGHHHEJC.content.SetActive(true);
			RinNPC.GGFJGHHHEJC.content.SetActive(true);
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
				ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
				KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
				RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			}
		}
		else
		{
			GJBNMNBAJIP();
		}
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		EnableNPCs(OEDBPACCOGH: true);
	}

	private void JOEEGBHKGBO()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)ZuzzuNPC.DFJGHOHPPEL().routine).enabled = false;
			ZuzzuNPC.LFPEPJBNCBF().routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.AHBBHCKPIIJ().routine.noDisableOnReset = false;
			((Behaviour)RinNPC.OPILDPFDFKJ().routine).enabled = false;
			ZuzzuNPC.JFNOOMJMHCB().routine.noDisableOnReset = false;
		}
		((Component)ZuzzuNPC.DFJGHOHPPEL()).transform.parent = null;
		ZuzzuNPC.FJAMHCAAEAM().animationBase.CGEADHOLHCH("Initializing MinePiece Pool...", EGFGNGJGBOP: true);
		((Component)ZuzzuNPC.EBAIHKJHCCA()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(false);
		ZuzzuNPC.OPDKAPNDBJE().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.OPILDPFDFKJ().content.SetActive(true);
	}

	private void JBDPLLHOJEH()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.LFPEPJBNCBF().routine).enabled = true;
			ZuzzuNPC.CHKMFEFOFKJ().routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.JFNOOMJMHCB().routine.noDisableOnReset = true;
			((Behaviour)RinNPC.KNLLFEJAMNN().routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.EBAIHKJHCCA()).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("Error_BarIsBlocking", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((Component)ZuzzuNPC.CHKMFEFOFKJ()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.DFJGHOHPPEL().content.SetActive(true);
		ZuzzuNPC.KNLLFEJAMNN().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.EBAIHKJHCCA().content.SetActive(false);
	}

	private void BAOPEEFKMOC()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)ZuzzuNPC.AHBBHCKPIIJ().routine).enabled = false;
			ZuzzuNPC.EBAIHKJHCCA().routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.EBAIHKJHCCA().routine.noDisableOnReset = false;
			((Behaviour)RinNPC.AFFGPMFKEFH().routine).enabled = false;
			ZuzzuNPC.JHMAMLIPBNN().routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.KNLLFEJAMNN()).transform.parent = null;
		ZuzzuNPC.EBAIHKJHCCA().animationBase.SetBool("/BarkMai", EGFGNGJGBOP: true);
		((Component)ZuzzuNPC.JFNOOMJMHCB()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.AHBBHCKPIIJ().content.SetActive(true);
		ZuzzuNPC.LFPEPJBNCBF().animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.POAGAIBEFBF().content.SetActive(false);
	}

	private IEnumerator BFOBJHBDJGK()
	{
		((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(1)).transform.position = zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
				PlayerController.GetPlayer(1).SetDirection(Direction.Right);
			}
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				}
			}
		}
		else
		{
			for (int j = 1; j < 3; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
				{
					((Component)PlayerController.GetPlayer(j)).transform.position = zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
					PlayerController.GetPlayer(j).SetDirection(Direction.Right);
					PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		instance.EnableNPCs(OEDBPACCOGH: true);
		yield return CommonReferences.wait2;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		FadeCamera.FadeInAllPlayers();
	}

	public void GJJKKCEGEJL(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			LOOMOCOMPBE(IANKECBCNPM: false);
			return;
		}
		EventsManager.SetActive((EventsManager.EventType)192, DMBFKFLDDLH: false);
		Debug.Log((object)"UIInteract");
	}

	public void BCDOKMFLNHC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.JHMAMLIPBNN().StartConversation(0, " is not food");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.DCAEBALADIM().StartObserverDialogueWhenItIsPossible(1));
		}
		Utils.DLIIAHACOJB(-83);
	}

	public void GDDHEIKKFFJ()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(JICFPPEELCC());
	}

	public void RestartMiniGame()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(PBDJDOHNGBP());
	}

	public void CCFPGNMIHLD(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			GCJILDLJOJD();
			return;
		}
		EventsManager.MMIFHDJECOG((EventsManager.EventType)69, DMBFKFLDDLH: false);
		Debug.Log((object)"NightStart not attached to prefab ");
	}

	public void DPLPEBGGGOB()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(NGPCKOIOMJM());
	}

	public void OIEFKFBABEC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.DICHPHEOINO().StartConversation(0, "Blocking collider not atttached to ");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.CHPEMJMLDCN().StartObserverDialogueWhenItIsPossible(1));
		}
		Utils.DLIIAHACOJB(-37, CDPAMNIPPEC: true);
	}

	public void JFBKNBAFGFC()
	{
		DialogueLua.SetVariable("Interact", (object)0);
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.JFJOKGAOPHA().StartConversation(1, "IdleCamp", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.ELGNEJNLBNO().StartObserverDialogueWhenItIsPossible(1));
		}
		BathhouseGameManager.instance.StopSounds();
		if (ANMAFLKPILP == null && OnlineManager.MasterOrOffline())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(KJCIBBFFCDO(HAGJFLMJHFG: true));
		}
	}

	public void BEOIOKBKLJK(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 242f)
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(FCMDDDOAEEF(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i += 0)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	public void DJPLBFDHEEH(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 1405f)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(GAMAJICJPGB(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i++)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		GJBNMNBAJIP();
	}

	public void MBANMHPBDNC()
	{
		FadeCamera.FadeOutAllPlayers(443f);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(instance.AIGPCLDGAHL));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator DPHKIFBGOPK()
	{
		((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(1)).transform.position = zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
				PlayerController.GetPlayer(1).SetDirection(Direction.Right);
			}
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				}
			}
		}
		else
		{
			for (int j = 1; j < 3; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
				{
					((Component)PlayerController.GetPlayer(j)).transform.position = zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
					PlayerController.GetPlayer(j).SetDirection(Direction.Right);
					PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		instance.EnableNPCs(OEDBPACCOGH: true);
		yield return CommonReferences.wait2;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		FadeCamera.FadeInAllPlayers();
	}

	private void BIGBBNAPAJL(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.DEMEHMNPMJE());
	}

	private IEnumerator IIPNFPFNOBH(bool HAGJFLMJHFG)
	{
		return new DLOMBCNFCFG(1)
		{
			_003C_003E4__this = this,
			endEvent = HAGJFLMJHFG
		};
	}

	public void LOOMOCOMPBE(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			CCFPGNMIHLD();
			return;
		}
		EventsManager.KGJIGNKBENF((EventsManager.EventType)(-11), DMBFKFLDDLH: false);
		Debug.Log((object)")");
	}

	private IEnumerator FLEKLHMLPMK()
	{
		return new HBDFGEPMIPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PMCKMDKMCCH()
	{
		((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(1)).transform.position = zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
				PlayerController.GetPlayer(1).SetDirection(Direction.Right);
			}
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				}
			}
		}
		else
		{
			for (int j = 1; j < 3; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
				{
					((Component)PlayerController.GetPlayer(j)).transform.position = zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
					PlayerController.GetPlayer(j).SetDirection(Direction.Right);
					PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		instance.EnableNPCs(OEDBPACCOGH: true);
		yield return CommonReferences.wait2;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		FadeCamera.FadeInAllPlayers();
	}

	public void HDKGKLDBPIE()
	{
		FadeCamera.FadeOutAllPlayers(828f);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(instance.NIHJICNGOFG));
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void GCJILDLJOJD(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			CCFPGNMIHLD(IANKECBCNPM: false);
			return;
		}
		EventsManager.DIFPOBMAOLL((EventsManager.EventType)(-191), DMBFKFLDDLH: false);
		Debug.Log((object)"\n");
	}

	private void ICLPNDICOML(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(instance.APLKLOMONPA());
	}

	public void BIAPEDOAIML()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(OMAKINCGPAJ());
	}

	private IEnumerator IGDLIEKDEKC()
	{
		yield return CommonReferences.wait1;
		BathhouseGameManager.Restart();
	}

	public void LGNOGIHJOBM()
	{
		FadeCamera.AONDJPKLMDK(1683f);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(instance.BIGBBNAPAJL));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void AHEGLLPBOGG(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			GJJKKCEGEJL();
			return;
		}
		EventsManager.NEHAHKDCPPA(EventsManager.EventType.OldMansDuel, DMBFKFLDDLH: true);
		Debug.Log((object)"Wide screen ratio");
	}

	public void CMOKEBALAOE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.PNHHCHJCDNM().StartConversation(1, "Max", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.OPDKAPNDBJE().StartObserverDialogueWhenItIsPossible(0));
		}
		Utils.DLIIAHACOJB(125);
	}

	private IEnumerator MBKHOGOEEAH(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	private void LOAFDMNCJHE()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.PNHHCHJCDNM().routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.OPDKAPNDBJE().routine.noDisableOnReset = false;
			((Behaviour)RinNPC.POAGAIBEFBF().routine).enabled = false;
			ZuzzuNPC.PNHHCHJCDNM().routine.noDisableOnReset = false;
		}
		((Component)ZuzzuNPC.OAPOJCODNCO()).transform.parent = null;
		ZuzzuNPC.LFPEPJBNCBF().animationBase.CGEADHOLHCH(" cannot be unloaded at this time. Either it's already unloaded or it's in the process of unloading.", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.DCAEBALADIM()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.OAPOJCODNCO().content.SetActive(true);
		ZuzzuNPC.JFJOKGAOPHA().animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.OJJDNLEFNPJ().content.SetActive(false);
	}

	public void HLFPOFCHDHA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.KNLLFEJAMNN().StartConversation(1, "Player/Bark/Tutorial/T100");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.DCAEBALADIM().StartObserverDialogueWhenItIsPossible(0));
		}
		Utils.DLIIAHACOJB(91, CDPAMNIPPEC: true);
	}

	private IEnumerator NOAMMOOGBMN(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	private IEnumerator APLKLOMONPA()
	{
		return new HBDFGEPMIPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JKCOECGACDL(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	private IEnumerator JPEJHDDPFIP()
	{
		yield return CommonReferences.wait1;
		BathhouseGameManager.Restart();
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		DialogueLua.SetVariable("LearnBalance", (object)2);
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Balance);
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1746).JMDALJBNFML(), HMPDLIPFBGD: true);
		}
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		if (instance.ANMAFLKPILP == null && OnlineManager.MasterOrOffline())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(AFFLJIHIJAC(HAGJFLMJHFG: true));
		}
	}

	public void CDOJNPKJPHD()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(OMAKINCGPAJ());
	}

	private void BKGCAFMNFPI(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.JFNINIPLKHJ());
	}

	public void PECLCEOAKEK()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(JMOGHGLFHCO());
	}

	private void AKEGEGDFGGE(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.NMPKDBDJFAF());
	}

	public void CDKOCGNMLMJ()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(IGDLIEKDEKC());
	}

	private IEnumerator BGEAPPHNECA(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	private void FNKEJMMMIOE()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.JFJOKGAOPHA().routine).enabled = true;
			ZuzzuNPC.OAPOJCODNCO().routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.DCAEBALADIM().routine.noDisableOnReset = true;
			((Behaviour)RinNPC.ABHIDHPMLLD().routine).enabled = false;
			ZuzzuNPC.JHMAMLIPBNN().routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.JFNOOMJMHCB()).transform.parent = null;
		ZuzzuNPC.OPDKAPNDBJE().animationBase.CGEADHOLHCH("times played: ", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.OPDKAPNDBJE()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.AHBBHCKPIIJ().content.SetActive(true);
		ZuzzuNPC.AHBBHCKPIIJ().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.KNLLFEJAMNN().content.SetActive(false);
	}

	private IEnumerator OMAKINCGPAJ()
	{
		yield return CommonReferences.wait1;
		BathhouseGameManager.Restart();
	}

	private IEnumerator HDOELJOFKNJ()
	{
		((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(1)).transform.position = zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
				PlayerController.GetPlayer(1).SetDirection(Direction.Right);
			}
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				}
			}
		}
		else
		{
			for (int j = 1; j < 3; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
				{
					((Component)PlayerController.GetPlayer(j)).transform.position = zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
					PlayerController.GetPlayer(j).SetDirection(Direction.Right);
					PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		instance.EnableNPCs(OEDBPACCOGH: true);
		yield return CommonReferences.wait2;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		FadeCamera.FadeInAllPlayers();
	}

	public void OKCJBCCDNGM(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			FNGJLKMGCMH(IANKECBCNPM: false);
			return;
		}
		EventsManager.DIFPOBMAOLL((EventsManager.EventType)(-87), DMBFKFLDDLH: false);
		Debug.Log((object)"UIPreviousCategory");
	}

	public void BDBPJKIIHDF(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 1748f)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(EDDLLOLBAII(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i += 0)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	private IEnumerator NGPCKOIOMJM()
	{
		return new KEFDIEMOIGE(1);
	}

	public void OBGNPDKELIK(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 543f)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NPFEKBAKGHE(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i += 0)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	private IEnumerator GAMAJICJPGB(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		if (LGLDPMAABLA == 5f)
		{
			yield return CommonReferences.wait5;
		}
		else if (LGLDPMAABLA == 10f)
		{
			yield return CommonReferences.wait10;
		}
		else
		{
			yield return (object)new WaitForSeconds(LGLDPMAABLA);
		}
		EnableNPCs(OEDBPACCOGH);
	}

	private IEnumerator OGKNMNHHAKB()
	{
		yield return CommonReferences.wait1;
		BathhouseGameManager.Restart();
	}

	private IEnumerator GNCJHJNJIIA(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		return new ICCJHFPPOAG(1)
		{
			_003C_003E4__this = this,
			enable = OEDBPACCOGH,
			time = LGLDPMAABLA
		};
	}

	public void PAIDNJIHEBE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.FJAMHCAAEAM().StartConversation(1, "Player");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.JFJOKGAOPHA().StartObserverDialogueWhenItIsPossible(1));
		}
		Utils.DLIIAHACOJB(-36, CDPAMNIPPEC: true);
	}

	public void CNMHBGOAOPF()
	{
		if (instance.ANMAFLKPILP != null)
		{
			((MonoBehaviour)this).StopCoroutine(instance.ANMAFLKPILP);
			instance.ANMAFLKPILP = null;
		}
		((MonoBehaviour)instance).StartCoroutine(DPGDIPBALAK());
	}

	public void OPILACJLCFO()
	{
		FadeCamera.FadeOutAllPlayers(1387f);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(instance.AKEGEGDFGGE));
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void NCKJOIMFOFF()
	{
		DialogueLua.SetVariable("<br/>Maximum Texture Size: ", (object)0);
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.JFJOKGAOPHA().StartConversation(0, "Player");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.DFJGHOHPPEL().StartObserverDialogueWhenItIsPossible(1));
		}
		BathhouseGameManager.instance.FKJNBJMNPEJ();
		if (ANMAFLKPILP == null && OnlineManager.PGAGDFAEEFB())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(KJCIBBFFCDO(HAGJFLMJHFG: true));
		}
	}

	private void CLBIEDOONJI()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.LFPEPJBNCBF().routine).enabled = true;
			ZuzzuNPC.DFJGHOHPPEL().routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.ELGNEJNLBNO().routine.noDisableOnReset = true;
			((Behaviour)RinNPC.ABHIDHPMLLD().routine).enabled = false;
			ZuzzuNPC.AHBBHCKPIIJ().routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.JFNOOMJMHCB()).transform.parent = null;
		ZuzzuNPC.JFJOKGAOPHA().animationBase.CGEADHOLHCH("Accept", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((Component)ZuzzuNPC.FJAMHCAAEAM()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.JFNOOMJMHCB().content.SetActive(true);
		ZuzzuNPC.EBAIHKJHCCA().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	public void FNGJLKMGCMH(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			ODABAHJJGKG(IANKECBCNPM: false);
			return;
		}
		EventsManager.DIBGPIPPDFD((EventsManager.EventType)183, DMBFKFLDDLH: true);
		Debug.Log((object)"Cat");
	}

	public void MHAFNCMEGIA()
	{
		DialogueLua.SetVariable("Idle", (object)0);
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.PNHHCHJCDNM().StartConversation(1, "Unlocked at Tavern Reputation {0}", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.JHMAMLIPBNN().StartObserverDialogueWhenItIsPossible(0));
		}
		BathhouseGameManager.instance.StopSounds();
		if (ANMAFLKPILP == null && OnlineManager.MasterOrOffline())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(AFFLJIHIJAC(HAGJFLMJHFG: true));
		}
	}

	public void EnableNPCs(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 0f)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(CGJIHEEKNIM(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i++)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	private IEnumerator CGJIHEEKNIM(bool OEDBPACCOGH, float LGLDPMAABLA)
	{
		if (LGLDPMAABLA == 5f)
		{
			yield return CommonReferences.wait5;
		}
		else if (LGLDPMAABLA == 10f)
		{
			yield return CommonReferences.wait10;
		}
		else
		{
			yield return (object)new WaitForSeconds(LGLDPMAABLA);
		}
		EnableNPCs(OEDBPACCOGH);
	}

	private void DBNNEOKJKIN()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)ZuzzuNPC.CHPEMJMLDCN().routine).enabled = true;
			ZuzzuNPC.ELGNEJNLBNO().routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.JFNOOMJMHCB().routine.noDisableOnReset = true;
			((Behaviour)RinNPC.OJJDNLEFNPJ().routine).enabled = true;
			ZuzzuNPC.EBAIHKJHCCA().routine.noDisableOnReset = false;
		}
		((Component)ZuzzuNPC.DCAEBALADIM()).transform.parent = null;
		ZuzzuNPC.JHMAMLIPBNN().animationBase.CGEADHOLHCH("Sharp", EGFGNGJGBOP: false, HALNIEBONKH: true);
		((Component)ZuzzuNPC.CHPEMJMLDCN()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.CHKMFEFOFKJ().content.SetActive(true);
		ZuzzuNPC.CHPEMJMLDCN().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.KNLLFEJAMNN().content.SetActive(true);
	}

	public void LoseEvent()
	{
		DialogueLua.SetVariable("LearnBalance", (object)1);
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(1, "BathhouseGame/Lose");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		BathhouseGameManager.instance.StopSounds();
		if (ANMAFLKPILP == null && OnlineManager.MasterOrOffline())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(AFFLJIHIJAC(HAGJFLMJHFG: false));
		}
	}

	public void DOMOLONONCD()
	{
		DialogueLua.SetVariable("Sending ", (object)0);
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.EBAIHKJHCCA().StartConversation(0, "itemSageSeeds", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.DFJGHOHPPEL().StartObserverDialogueWhenItIsPossible(1));
		}
		BathhouseGameManager.instance.StopSounds();
		if (ANMAFLKPILP == null && OnlineManager.PGAGDFAEEFB())
		{
			instance.ANMAFLKPILP = ((MonoBehaviour)instance).StartCoroutine(KJCIBBFFCDO(HAGJFLMJHFG: true));
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
			ResetEvent();
		}
	}

	public void ActivateEvent(bool IANKECBCNPM = true)
	{
		if (IANKECBCNPM)
		{
			ActivateEvent();
			return;
		}
		EventsManager.SetActive(EventsManager.EventType.BathhouseGame, DMBFKFLDDLH: true);
		Debug.Log((object)"Event BathhouseGame activated");
	}

	public void MEDLCCBICJE(bool OEDBPACCOGH, float LGLDPMAABLA = 0f)
	{
		if (LGLDPMAABLA > 386f)
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(FCMDDDOAEEF(OEDBPACCOGH, LGLDPMAABLA));
			return;
		}
		for (int i = 0; i < NPCsToDisable.Length; i++)
		{
			instance.NPCsToDisable[i].SetActive(OEDBPACCOGH);
		}
	}

	private IEnumerator EAHGMALIMAH()
	{
		return new HBDFGEPMIPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CBKOBCDLDAH(bool HAGJFLMJHFG)
	{
		while (Utils.NGLLIJPOBEC(Location.BathhouseInterior))
		{
			yield return null;
		}
		if (HAGJFLMJHFG)
		{
			((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
			ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
			KentaNPC.GGFJGHHHEJC.content.SetActive(true);
			RinNPC.GGFJGHHHEJC.content.SetActive(true);
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
				ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
				KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
				RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			}
		}
		else
		{
			GJBNMNBAJIP();
		}
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		EnableNPCs(OEDBPACCOGH: true);
	}

	private IEnumerator EDFMCNPOAGF(bool HAGJFLMJHFG)
	{
		return new DLOMBCNFCFG(1)
		{
			_003C_003E4__this = this,
			endEvent = HAGJFLMJHFG
		};
	}

	private void NOOLMIBACCP(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.JFNINIPLKHJ());
	}

	private IEnumerator CGMOPNBGEDJ()
	{
		((Component)BathhouseGameManager.instance).gameObject.SetActive(false);
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(1)).transform.position = zuzzuPosition.position + new Vector3((float)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) * -0.5f, 0f, 0f);
				PlayerController.GetPlayer(1).SetDirection(Direction.Right);
			}
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
				{
					PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				}
			}
		}
		else
		{
			for (int j = 1; j < 3; j++)
			{
				if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
				{
					((Component)PlayerController.GetPlayer(j)).transform.position = zuzzuPosition.position + new Vector3((float)j * -0.5f, 0f, 0f);
					PlayerController.GetPlayer(j).SetDirection(Direction.Right);
					PlayerController.GetPlayer(j).characterCreator.BathhouseExit();
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Minigame", EGFGNGJGBOP: false);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
		}
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait10, Location.BathhouseInterior);
		instance.EnableNPCs(OEDBPACCOGH: true);
		yield return CommonReferences.wait2;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(instance.NOOLMIBACCP));
		FadeCamera.FadeInAllPlayers();
	}
}
