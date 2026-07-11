using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class KujakuShopEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class CEBAOHFABKK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KujakuShopEvent _003C_003E4__this;

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
		public CEBAOHFABKK(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			KujakuShopEvent kujakuShopEvent = _003C_003E4__this;
			Result variable;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				goto IL_0042;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0042;
			case 2:
				{
					_003C_003E1__state = -1;
					KujakuNPC instance = KujakuNPC.GGFJGHHHEJC;
					instance.ConversationStarted = (Action<bool>)Delegate.Combine(instance.ConversationStarted, new Action<bool>(kujakuShopEvent.AEEHFGIDCMJ));
					KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: true, HALNIEBONKH: true);
					kujakuShopEvent.NCCAFLDCLCL = null;
					return false;
				}
				IL_0042:
				variable = DialogueLua.GetVariable("LE_14");
				if (((Result)(ref variable)).asInt < 1)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait02;
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
	private sealed class EFJFGLLPIDN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KujakuShopEvent _003C_003E4__this;

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
		public EFJFGLLPIDN(int _003C_003E1__state)
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
			KujakuShopEvent kujakuShopEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				DialogueLua.SetVariable("MainProgress", (object)10);
				MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
				GoToHotSPringsEvent.instance.ActivateEvent();
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (Utils.NGLLIJPOBEC(Location.City))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
			if (OnlineManager.MasterOrOffline())
			{
				instance.kujakuRoutine.routines[4].info.priority = false;
				instance.kujakuRoutine.routines[4].info.constant = false;
				instance.kujakuRoutine.StopRoutine();
				kujakuShopEvent.awningManager.OnPlayerAwake();
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

	public static KujakuShopEvent instance;

	public NPCRoutine kujakuRoutine;

	public AwningManager awningManager;

	private Coroutine NCCAFLDCLCL;

	private void IAPAKPNFAJF()
	{
		if (EventsManager.CGPHKBKPCJF(EventsManager.EventType.ThroneRoom))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PGDGNNGEJFH));
	}

	private IEnumerator FECCGCOIEDJ()
	{
		return new EFJFGLLPIDN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GILGKPKLDPD()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void EENKHDJONDD(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.LANAINBEMCM();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(POGDBEKIDGI));
		Debug.Log((object)("Press {0} to continue" + BFLCJPHHDJM));
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.MAAAKALBBEE().animationBase.SetBool("HotBath/Bark", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			kujakuRoutine.StopRoutine();
			kujakuRoutine.routines[4].info.priority = true;
			kujakuRoutine.routines[4].info.constant = true;
			awningManager.awningControllers.OpenAwning();
		}
		if (NCCAFLDCLCL == null)
		{
			NCCAFLDCLCL = ((MonoBehaviour)this).StartCoroutine(KJPEOPBKBAJ());
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		CommonReferences commonReferences2 = CommonReferences.GGFJGHHHEJC;
		commonReferences2.OnPlayerAwake = (Action)Delegate.Combine(commonReferences2.OnPlayerAwake, new Action(ALGOBMNPLIB));
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	private IEnumerator AHJHIPCOLIM()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void HNIMEMKOGHP()
	{
		if (EventsManager.FFELMGLBAMH(EventsManager.EventType.OathFeast))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(MNCDAHNHNMJ));
	}

	private void LKPMOFDDDKO()
	{
		if (EventsManager.IKCEIJMLNOP(EventsManager.EventType.Scolding))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(BEKHKKNPKNC));
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private IEnumerator HLBDBEHBJKH()
	{
		while (true)
		{
			Result variable = DialogueLua.GetVariable("LE_14");
			if (((Result)(ref variable)).asInt >= 1)
			{
				break;
			}
			yield return null;
		}
		yield return CommonReferences.wait02;
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: true, HALNIEBONKH: true);
		NCCAFLDCLCL = null;
	}

	private void GAGMDCHBNLA()
	{
		if (EventsManager.CJMECHEOFOF(EventsManager.EventType.KujakuShop))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PGDGNNGEJFH));
	}

	private void NKKNBDMHMAI()
	{
		if (EventsManager.KEGDEHKPKMP(EventsManager.EventType.KlaynTavern))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALDJGOCMPPO));
	}

	private void POGDBEKIDGI(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.NEFIEJALANL();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(HFLHGODBFBE));
		Debug.Log((object)("LE_2" + BFLCJPHHDJM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.MAAAKALBBEE().animationBase.SetBool("", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	private void FPKPKKDEKPO(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.BADFKMEJOKE();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(BLIJAFHDDCJ));
		Debug.Log((object)("---> Chosen: " + BFLCJPHHDJM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("Null ingredient!", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	private void OAOMALLBGAM()
	{
		if (EventsManager.IsActive(EventsManager.EventType.OathFeast))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IAPAKPNFAJF));
	}

	private IEnumerator NPFLHLGAOAD()
	{
		return new CEBAOHFABKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NMGKALMGBGE()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void JBFFNMCKOEM()
	{
		if (EventsManager.CJMECHEOFOF(EventsManager.EventType.OathFeast))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(FNJIMIFMJGO));
	}

	private void DHPGIFIKGEK(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.BADFKMEJOKE();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		Debug.Log((object)("UIVertical" + BFLCJPHHDJM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.EKDNJDJHONF().animationBase.SetBool("DrinkVerb", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
	}

	private IEnumerator BGDIHEFHAFI()
	{
		return new CEBAOHFABKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LGLHJPONCFL()
	{
		return new EFJFGLLPIDN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ALGOBMNPLIB()
	{
		if (EventsManager.IsActive(EventsManager.EventType.KujakuShop))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
	}

	private void PGDGNNGEJFH()
	{
		if (EventsManager.CGPHKBKPCJF((EventsManager.EventType)4))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HNEKMALGJPO));
	}

	private void MALOBJGECEM(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.EKDNJDJHONF();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(POGDBEKIDGI));
		Debug.Log((object)("Dialogue System/Conversation/TooDark/Entry/2/Dialogue Text" + BFLCJPHHDJM));
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.LANAINBEMCM().animationBase.CGEADHOLHCH("NotMyChest", EGFGNGJGBOP: true);
		}
	}

	private IEnumerator FPOMNPHLHKD()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void POEAHKDOOFH()
	{
		if (EventsManager.JAGPJPGBHDK(EventsManager.EventType.CastleForm))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(POEAHKDOOFH));
	}

	private IEnumerator DEAHFPCAPJJ()
	{
		while (true)
		{
			Result variable = DialogueLua.GetVariable("LE_14");
			if (((Result)(ref variable)).asInt >= 1)
			{
				break;
			}
			yield return null;
		}
		yield return CommonReferences.wait02;
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: true, HALNIEBONKH: true);
		NCCAFLDCLCL = null;
	}

	private IEnumerator CJEPIHLGMLD()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private IEnumerator ONMAPKIHHEP()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void BONHDKBLOMP()
	{
		if (EventsManager.FFELMGLBAMH(EventsManager.EventType.KlaynTavern))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IAPAKPNFAJF));
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private void ABDFDBCHOJI()
	{
		if (EventsManager.IOLMGKKGLMD(EventsManager.EventType.CastleForm))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GAGMDCHBNLA));
	}

	private void ALDJGOCMPPO()
	{
		if (EventsManager.KEGDEHKPKMP(EventsManager.EventType.Scolding))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(BEKHKKNPKNC));
	}

	private IEnumerator JGCEJKPLGMA()
	{
		return new EFJFGLLPIDN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AKGNKJEGONO()
	{
		return new CEBAOHFABKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EKHAJBLHFJD()
	{
		return new CEBAOHFABKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DCPGBMIDPLA()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void KHCKJAFHHII()
	{
		if (EventsManager.BBMAEAFHEFK(EventsManager.EventType.KlaynTavern))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CKHDGFBDOGB));
	}

	private void EHEGADAIHMH()
	{
		if (EventsManager.NJBACCBIHID(EventsManager.EventType.AdventureContinues))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IAPAKPNFAJF));
	}

	private void JEPFLPOFAKE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.BADFKMEJOKE();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(DAHNMGPDLJK));
		Debug.Log((object)("Customer Pool instance NULL!" + BFLCJPHHDJM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("Pick up", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	private void CKOHHFFMHGN(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.DEGPIHEEFHJ();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(MOJOHBIGMLJ));
		Debug.Log((object)("Staff" + BFLCJPHHDJM));
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("NormalLeftExterior", EGFGNGJGBOP: false);
		}
	}

	private void AINKBCHNIGA(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.EKDNJDJHONF();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(CKOHHFFMHGN));
		Debug.Log((object)("SFX" + BFLCJPHHDJM));
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("DoYouWantToRepairIt", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	private IEnumerator LOLGHLDAJMG()
	{
		while (true)
		{
			Result variable = DialogueLua.GetVariable("LE_14");
			if (((Result)(ref variable)).asInt >= 1)
			{
				break;
			}
			yield return null;
		}
		yield return CommonReferences.wait02;
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: true, HALNIEBONKH: true);
		NCCAFLDCLCL = null;
	}

	private void MOJOHBIGMLJ(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(KHPEANFFJBI));
		Debug.Log((object)("Items/item_description_594" + BFLCJPHHDJM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Trying to get an invalid Other player with playerNum: ", EGFGNGJGBOP: true);
		}
	}

	private void KANEHEJILNM()
	{
		if (EventsManager.FFELMGLBAMH(EventsManager.EventType.KujakuShop))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(EHEGADAIHMH));
	}

	private IEnumerator ENEDKDCENCG()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void DAHNMGPDLJK(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.LANAINBEMCM();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(MALOBJGECEM));
		Debug.Log((object)("ReceiveRoomRequest" + BFLCJPHHDJM));
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.NEFIEJALANL().animationBase.SetBool("ZoneFirewood", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
	}

	private void HNEKMALGJPO()
	{
		if (EventsManager.FFELMGLBAMH(EventsManager.EventType.OathFeast))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KHCKJAFHHII));
	}

	private void BEKHKKNPKNC()
	{
		if (EventsManager.NJBACCBIHID(EventsManager.EventType.AdventureContinues))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(POEAHKDOOFH));
	}

	private IEnumerator HNOKIPLHOPL()
	{
		return new CEBAOHFABKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KACLGOMIPOK()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void CKHDGFBDOGB()
	{
		if (EventsManager.BBMAEAFHEFK(EventsManager.EventType.KujakuShop))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KANEHEJILNM));
	}

	private IEnumerator GHEGCHIHLNK()
	{
		return new CEBAOHFABKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LJABJLDHLCB()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void MNCDAHNHNMJ()
	{
		if (EventsManager.IKCEIJMLNOP(EventsManager.EventType.KlaynTavern))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CKHDGFBDOGB));
	}

	private IEnumerator ALJNBKAPCLN()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void FNJIMIFMJGO()
	{
		if (EventsManager.NJBACCBIHID(EventsManager.EventType.KyrohWaterfall))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KHCKJAFHHII));
	}

	private IEnumerator HJEMGEILJBL()
	{
		return new CEBAOHFABKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NICLDHAAHMB()
	{
		return new EFJFGLLPIDN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KJPEOPBKBAJ()
	{
		while (true)
		{
			Result variable = DialogueLua.GetVariable("LE_14");
			if (((Result)(ref variable)).asInt >= 1)
			{
				break;
			}
			yield return null;
		}
		yield return CommonReferences.wait02;
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: true, HALNIEBONKH: true);
		NCCAFLDCLCL = null;
	}

	private IEnumerator LAIGOPJBLPJ()
	{
		while (true)
		{
			Result variable = DialogueLua.GetVariable("LE_14");
			if (((Result)(ref variable)).asInt >= 1)
			{
				break;
			}
			yield return null;
		}
		yield return CommonReferences.wait02;
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: true, HALNIEBONKH: true);
		NCCAFLDCLCL = null;
	}

	private void HFLHGODBFBE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.NEFIEJALANL();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		Debug.Log((object)("Crop with ID " + BFLCJPHHDJM));
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Dialogue System/Conversation/TooDark/Entry/10/Dialogue Text", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
	}

	private IEnumerator LBCKNFKEEPB()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private IEnumerator OKPNIPLAADN()
	{
		return new EFJFGLLPIDN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GPDEMBOGLDC()
	{
		return new EFJFGLLPIDN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AEEHFGIDCMJ(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		Debug.Log((object)("KujakuShopEvent: Conversation started, isActor = " + BFLCJPHHDJM));
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false);
		}
	}

	private void KHPEANFFJBI(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.DEGPIHEEFHJ();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(KHPEANFFJBI));
		Debug.Log((object)("Close" + BFLCJPHHDJM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.DEGPIHEEFHJ().animationBase.SetBool("Sit", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
	}

	private IEnumerator KCJMAECGPLN()
	{
		DialogueLua.SetVariable("MainProgress", (object)10);
		MissionsManager.instance.StartMission(311, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		GoToHotSPringsEvent.instance.ActivateEvent();
		while (Utils.NGLLIJPOBEC(Location.City))
		{
			yield return null;
		}
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Sleepy", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			instance.kujakuRoutine.routines[4].info.priority = false;
			instance.kujakuRoutine.routines[4].info.constant = false;
			instance.kujakuRoutine.StopRoutine();
			awningManager.OnPlayerAwake();
		}
	}

	private void DCHDJABABLE()
	{
		if (EventsManager.NJBACCBIHID(EventsManager.EventType.KujakuShop))
		{
			ActivateEvent();
			return;
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void BLIJAFHDDCJ(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		KujakuNPC kujakuNPC = KujakuNPC.LANAINBEMCM();
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(JEPFLPOFAKE));
		Debug.Log((object)("Game" + BFLCJPHHDJM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.NEFIEJALANL().animationBase.SetBool("Reputation Reward {0}", EGFGNGJGBOP: true);
		}
	}
}
