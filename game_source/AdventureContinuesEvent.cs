using System;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class AdventureContinuesEvent : GameEvent
{
	public static AdventureContinuesEvent instance;

	private void IDDPAIMLEBO(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(MGODBGOGLGK));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void KJOJLHCDFPP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LBPGLJOGDMK));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(FNCBGPDGPII));
	}

	private void Start()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(BGPGIOMKKAO));
	}

	private void LEMFPNELAGM(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(PILBALGIGAI));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void HCEDMLJNOBL()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BLOCJJJBDDD));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(BGPGIOMKKAO));
	}

	private void ILJPINCGGFG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OPIHPIJFDOP));
		Result variable = DialogueLua.GetVariable("");
		Debug.Log((object)("mForMins" + ((Result)(ref variable)).asInt));
		if (TavernReputation.GetMilestone() >= 4)
		{
			variable = DialogueLua.GetVariable("Chest");
			if (((Result)(ref variable)).asInt == 4)
			{
				goto IL_0074;
			}
		}
		if (!EventsManager.CGPHKBKPCJF((EventsManager.EventType)4))
		{
			return;
		}
		goto IL_0074;
		IL_0074:
		DialogueLua.SetVariable("UI2", (object)5);
		ActivateEvent();
	}

	private void DLJOOGOELAA(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(GDGDHJHDLHA));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void CEIIFHIBIFI()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(FNCBGPDGPII));
	}

	private void MGODBGOGLGK(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(EOBMIIBILDJ));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void BGPGIOMKKAO()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		Result variable = DialogueLua.GetVariable("MainProgress");
		Debug.Log((object)("AdventureContinuesEvent OnWorldLoaded " + ((Result)(ref variable)).asInt));
		if (TavernReputation.GetMilestone() >= 6)
		{
			variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt == 5)
			{
				goto IL_0074;
			}
		}
		if (!EventsManager.IsActive(EventsManager.EventType.AdventureContinues))
		{
			return;
		}
		goto IL_0074;
		IL_0074:
		DialogueLua.SetVariable("MainProgress", (object)6);
		ActivateEvent();
	}

	private void KBANIBEKODE(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(KBANIBEKODE));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void KDBJHCAEGCM()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BLOCJJJBDDD));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ILJPINCGGFG));
	}

	private void PPBJAMHJBBK(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(LEMFPNELAGM));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void GDGDHJHDLHA(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(PILBALGIGAI));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void PLHEHGHFCJI()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OPIHPIJFDOP));
	}

	private void OPIHPIJFDOP()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OPIHPIJFDOP));
		Result variable = DialogueLua.GetVariable("Target frame rate (");
		Debug.Log((object)("MineState" + ((Result)(ref variable)).asInt));
		if (TavernReputation.MHGADJPMHFI() >= 6)
		{
			variable = DialogueLua.GetVariable("ReceiveNewPosition");
			if (((Result)(ref variable)).asInt == 7)
			{
				goto IL_0074;
			}
		}
		if (!EventsManager.IOLMGKKGLMD(EventsManager.EventType.KyrohWaterfall))
		{
			return;
		}
		goto IL_0074;
		IL_0074:
		DialogueLua.SetVariable(" UpdateState().", (object)3);
		ActivateEvent();
	}

	private void ADFMHFLPNOF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BLOCJJJBDDD));
		Result variable = DialogueLua.GetVariable("ReceiveGetUp");
		Debug.Log((object)("Items/item_name_684" + ((Result)(ref variable)).asInt));
		if (TavernReputation.GetMilestone() >= 4)
		{
			variable = DialogueLua.GetVariable(": ");
			if (((Result)(ref variable)).asInt == 2)
			{
				goto IL_0074;
			}
		}
		if (!EventsManager.BBMAEAFHEFK(EventsManager.EventType.KlaynTavern))
		{
			return;
		}
		goto IL_0074;
		IL_0074:
		DialogueLua.SetVariable("OpenStats", (object)7);
		ActivateEvent();
	}

	private void BLOCJJJBDDD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FNCBGPDGPII));
		Result variable = DialogueLua.GetVariable("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.");
		Debug.Log((object)("BuzzProgress" + ((Result)(ref variable)).asInt));
		if (TavernReputation.GetMilestone() >= 5)
		{
			variable = DialogueLua.GetVariable("\n");
			if (((Result)(ref variable)).asInt == 4)
			{
				goto IL_0074;
			}
		}
		if (!EventsManager.GIJNJBNBMJK(EventsManager.EventType.CastleForm))
		{
			return;
		}
		goto IL_0074;
		IL_0074:
		DialogueLua.SetVariable(" OnCharacterStateChanged", (object)5);
		ActivateEvent();
	}

	private void FNCBGPDGPII()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FNCBGPDGPII));
		Result variable = DialogueLua.GetVariable("Bug report POST failed: ");
		Debug.Log((object)(" " + ((Result)(ref variable)).asInt));
		if (TavernReputation.GetMilestone() >= 2)
		{
			variable = DialogueLua.GetVariable("Walk");
			if (((Result)(ref variable)).asInt == 8)
			{
				goto IL_0074;
			}
		}
		if (!EventsManager.IOLMGKKGLMD(EventsManager.EventType.Scolding))
		{
			return;
		}
		goto IL_0074;
		IL_0074:
		DialogueLua.SetVariable(":<color=#3a0603> +", (object)6);
		ActivateEvent();
	}

	private void EOBMIIBILDJ(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(KICABBGBPGI));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void IDPHKHGHJGN()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FNCBGPDGPII));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(BGPGIOMKKAO));
	}

	private void AEGDGMGGJAJ(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(DLJOOGOELAA));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private void HBMDEHPHAPF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(INHHGMPOFBF));
	}

	private void PILBALGIGAI(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(PILBALGIGAI));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(KBANIBEKODE));
		if (!BFLCJPHHDJM && OnlineManager.PlayingOnline() && !MainUI.IsAnyUIOpen() && Utils.AHMPFOEGJHF(Location.Tavern) && Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 20f))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
			((MonoBehaviour)this).StartCoroutine(MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBar(1f);
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(KBANIBEKODE));
		MaiNPC maiNPC2 = MaiNPC.GGFJGHHHEJC;
		maiNPC2.ConversationStarted = (Action<bool>)Delegate.Combine(maiNPC2.ConversationStarted, new Action<bool>(KBANIBEKODE));
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void KCICKLONDFG(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(KICABBGBPGI));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void JPOLFKMLHNH()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BLOCJJJBDDD));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OPIHPIJFDOP));
	}

	public override void EndEvent(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
		if (Utils.AHMPFOEGJHF(Location.Tavern))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		MaiNPC.GGFJGHHHEJC.DisappearMai();
		MissionsManager.instance.StartMission(323, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		DialogueLua.SetVariable("MainProgress", (object)7);
		ThroneRoomEvent.instance.ActivateEvent();
	}

	private void LBPGLJOGDMK()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ILJPINCGGFG));
		Result variable = DialogueLua.GetVariable("Key Altar puzzle: assigning key fragments. Available destructibles: {0}, available holes: {1}, available fishing spots: {2}");
		Debug.Log((object)("LE_21" + ((Result)(ref variable)).asInt));
		if (TavernReputation.GetMilestone() >= 2)
		{
			variable = DialogueLua.GetVariable("ReceiveTavernEventsLoad");
			if (((Result)(ref variable)).asInt == 0)
			{
				goto IL_0074;
			}
		}
		if (!EventsManager.IKCEIJMLNOP(EventsManager.EventType.AdventureContinues))
		{
			return;
		}
		goto IL_0074;
		IL_0074:
		DialogueLua.SetVariable("Error_SmallRoom", (object)2);
		ActivateEvent();
	}

	private void INHHGMPOFBF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LBPGLJOGDMK));
		Result variable = DialogueLua.GetVariable("TermasInterior/Zuzzu/Stand");
		Debug.Log((object)("/" + ((Result)(ref variable)).asInt));
		if (TavernReputation.GetMilestone() >= 1)
		{
			variable = DialogueLua.GetVariable("City/Amos/Bark/Stand");
			if (((Result)(ref variable)).asInt == 6)
			{
				goto IL_0074;
			}
		}
		if (!EventsManager.BBMAEAFHEFK(EventsManager.EventType.KujakuShop))
		{
			return;
		}
		goto IL_0074;
		IL_0074:
		DialogueLua.SetVariable("Direction", (object)5);
		ActivateEvent();
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private void KICABBGBPGI(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(KBANIBEKODE));
		if (BFLCJPHHDJM)
		{
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}
}
