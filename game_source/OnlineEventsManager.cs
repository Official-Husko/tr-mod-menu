using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineEventsManager : MonoBehaviourPunCallbacks
{
	public static OnlineEventsManager instance;

	private GameEvent CHCEBDOKCNC;

	private void EBGHHKDBPJF()
	{
		OldMansDuelEvent.instance.EndLaughAndMove();
	}

	[PunRPC]
	private void ReceiveBathhouseEntranceEventMoveToPlayer()
	{
		BathhouseEntraceEvent.instance.MoveToPlayerEvent();
	}

	private void LPBKJNPKKJF(short APLLBBEPAHN)
	{
		if (APLLBBEPAHN == 0 || !DialogueNPCBase.allNPCs.ContainsKey((CharacterName)APLLBBEPAHN))
		{
			CharacterName characterName = (CharacterName)APLLBBEPAHN;
			Debug.LogError((object)("talentPaleAdv." + characterName.ToString() + "GENERIC STATE - NAME UNDEFINED"));
		}
		else
		{
			DialogueNPCBase dialogueNPCBase = DialogueNPCBase.allNPCs[(CharacterName)APLLBBEPAHN];
			((MonoBehaviour)this).StartCoroutine(dialogueNPCBase.StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public static void SendMaiEventStart()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveMaiEventStart", (RpcTarget)1);
		}
	}

	public static void KDDBKGJLHNJ()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, " (", (RpcTarget)0);
		}
	}

	public static void SendFishCuttingEventThrowScene()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveFishCuttingEventThrowScene", (RpcTarget)1);
		}
	}

	public static void SendEventActorToMasterClient(EventsManager.EventType AKADPCABHIB)
	{
		if (!((Object)(object)instance == (Object)null) && OnlineManager.ClientOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveEventActor", (RpcTarget)2, (int)AKADPCABHIB, PhotonNetwork.LocalPlayer.ActorNumber);
		}
	}

	public static void SendBathhouseEntranceEventLeftBathhouse()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveBathhouseEntranceEventLeftBathhouse", (RpcTarget)1);
		}
	}

	public void OnFinishedOnlineLoad()
	{
		if (!((Object)(object)EventsManager.instance == (Object)null) && EventsManager.IsActive(EventsManager.EventType.KlaynTavern))
		{
			((MonoBehaviour)this).StartCoroutine(KlaynTavernEvent.instance.ExecuteAllCoroutines());
		}
	}

	[PunRPC]
	private void RecieveMothersRecipeEventCof()
	{
		MothersRecipeEvent.instance.CofEvent();
	}

	public static void SendFishCuttingEventReturnToHouse()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveFishCuttingEventReturnToHouse", (RpcTarget)1);
		}
	}

	private void HMFIDMKAPHA()
	{
		CastleFormEvent.instance.DPPHGHIPFAN();
	}

	[PunRPC]
	private void RecieveOldMansDuelZuzzuWeaponAnimation()
	{
		OldMansDuelEvent.instance.ZuzzuWeaponAnim();
	}

	public static void OCFEADODOND(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = GJDMLMEMKMD;
			OnlineManager.SendRPC(photonView, "No content to disable in this NPC!", (RpcTarget)1, array);
		}
	}

	public void SendRequestChallengeRestart(EventsManager.EventType AKADPCABHIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRequestChallengeRestart", (RpcTarget)1, (short)AKADPCABHIB);
	}

	[PunRPC]
	private void RecieveMaiInBar()
	{
		MaiNPC.GGFJGHHHEJC.SetBarParent(CDPAMNIPPEC: false);
	}

	[PunRPC]
	private void RecieveStartObserveDialogue(short APLLBBEPAHN)
	{
		if (APLLBBEPAHN == 0 || !DialogueNPCBase.allNPCs.ContainsKey((CharacterName)APLLBBEPAHN))
		{
			CharacterName characterName = (CharacterName)APLLBBEPAHN;
			Debug.LogError((object)("DialogueNPC of character " + characterName.ToString() + " not found in OnlineEventsManager. Cannot start observe dialogue"));
		}
		else
		{
			DialogueNPCBase dialogueNPCBase = DialogueNPCBase.allNPCs[(CharacterName)APLLBBEPAHN];
			((MonoBehaviour)this).StartCoroutine(dialogueNPCBase.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	[PunRPC]
	private void ReceiveSetTableParent(byte GJDMLMEMKMD)
	{
		PrecisionEvent.instance.SetTableParent(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD), sendOnline: false);
	}

	public static void LLELHCDICBC(EventsManager.EventType AKADPCABHIB)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = (short)AKADPCABHIB;
			OnlineManager.SendRPC(photonView, ", ", (RpcTarget)1, array);
		}
	}

	private void LICCHHNIDAI()
	{
		NinjaChallengeEvent.instance.KOIPNJNNIBB();
	}

	public static void INIDHCFKFNI()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "DecorationTile_19", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void RecieveActivateEvent(short AKADPCABHIB)
	{
		GameEvent gameEvent = EventsManager.GetGameEvent((EventsManager.EventType)AKADPCABHIB);
		if ((Object)(object)gameEvent != (Object)null)
		{
			gameEvent.ActivateEvent();
			return;
		}
		EventsManager.EventType eventType = (EventsManager.EventType)AKADPCABHIB;
		Debug.LogError((object)("GameEvent of type " + eventType.ToString() + " not found in OnlineEventsManager."));
	}

	private void OOFCOOPPIGD()
	{
		BathhouseEntraceEvent.instance.PCNPIKFHPGE();
	}

	public static void SendCastleFormEndLucenEvent()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveCastleFormEndLucenEvent", (RpcTarget)1);
		}
	}

	public static void SendOldMansDuelZuzzuWeaponAnimation()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveOldMansDuelZuzzuWeaponAnimation", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void RecieveStartSleep(byte FLHBPHPKIML)
	{
		MusicController.instance.TriggerCurrentBasicMood();
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget(FLHBPHPKIML);
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	[PunRPC]
	private void ReceiveAwakeBob()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
	}

	public static void SendActivateEvent(EventsManager.EventType AKADPCABHIB)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveActivateEvent", (RpcTarget)1, (short)AKADPCABHIB);
		}
	}

	public static void SendAwakeBob()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveAwakeBob", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void RecieveEndEvent(short AKADPCABHIB)
	{
		GameEvent gameEvent = EventsManager.GetGameEvent((EventsManager.EventType)AKADPCABHIB);
		if ((Object)(object)gameEvent != (Object)null)
		{
			gameEvent.EndEvent(BGKCHMNJBLJ: false);
			return;
		}
		EventsManager.EventType eventType = (EventsManager.EventType)AKADPCABHIB;
		Debug.LogError((object)("GameEvent of type " + eventType.ToString() + " not found in OnlineEventsManager."));
	}

	public static void SendMaiInBar()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveMaiInBar", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void ReceiveCastleFormEndLucenEvent()
	{
		CastleFormEvent.instance.EndLucenCastleEvent();
	}

	public static void SendStartObserveDialogue(CharacterName CFGDHKLLKHB)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveStartObserveDialogue", (RpcTarget)1, (short)CFGDHKLLKHB);
		}
	}

	private void NNMHMLOLLMB(bool DMBFKFLDDLH)
	{
		EventsManager.instance.easyDifficultyMode = DMBFKFLDDLH;
	}

	public static void SendCastleFormStartLucenDialogue()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveCastleFormStartLucenDialogue", (RpcTarget)1);
		}
	}

	public static void SendCastleFormStartKlaynDialogue()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveCastleFormStartKlaynDialogue", (RpcTarget)1);
		}
	}

	private void PINPPGOFEDG(short AKADPCABHIB)
	{
		GameEvent gameEvent = EventsManager.GOPFIHBJBAE((EventsManager.EventType)AKADPCABHIB);
		if ((Object)(object)gameEvent != (Object)null)
		{
			gameEvent.StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
			return;
		}
		EventsManager.EventType eventType = (EventsManager.EventType)AKADPCABHIB;
		Debug.LogError((object)("Sour" + eventType.ToString() + "Left"));
	}

	[PunRPC]
	public void ReceiveStopPlayingChallenge(short AKADPCABHIB)
	{
		CHCEBDOKCNC = EventsManager.GetGameEvent((EventsManager.EventType)AKADPCABHIB);
		CHCEBDOKCNC.StopPlayingChallenge();
	}

	[PunRPC]
	private void ReceiveBathhouseEntranceEventLeftBathhouse()
	{
		BathhouseEntraceEvent.instance.LeftBathhouseEvent();
	}

	public void ICNNAGDHPBK(short AKADPCABHIB)
	{
		CHCEBDOKCNC = EventsManager.GOPFIHBJBAE((EventsManager.EventType)AKADPCABHIB);
		CHCEBDOKCNC.RestartChallenge();
	}

	[PunRPC]
	public void ReceiveRequestChallengeRestart(short AKADPCABHIB)
	{
		CHCEBDOKCNC = EventsManager.GetGameEvent((EventsManager.EventType)AKADPCABHIB);
		CHCEBDOKCNC.RequestChallengeRestart();
	}

	public static void SendNinjaChallengeEventFadeOut()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveNinjaChallengeEventFadeOut", (RpcTarget)1);
		}
	}

	public static void PFAILBGMCCL()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "cursorSensitivity", (RpcTarget)1);
		}
	}

	public void AJOHGHAJBKA(EventsManager.EventType AKADPCABHIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)AKADPCABHIB;
		OnlineManager.SendRPC(photonView, "Items/item_description_731", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveEasyDifficulty(bool DMBFKFLDDLH)
	{
		EventsManager.instance.easyDifficultyMode = DMBFKFLDDLH;
	}

	public void IAJJLHHIAIB(short AKADPCABHIB)
	{
		CHCEBDOKCNC = EventsManager.GOPFIHBJBAE((EventsManager.EventType)AKADPCABHIB);
		CHCEBDOKCNC.RestartChallenge();
	}

	private void Start()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(OnFinishedOnlineLoad));
	}

	[PunRPC]
	private void ReceiveCastleFormStartLucenEvent()
	{
		CastleFormEvent.instance.StartLucenCastleEvent();
	}

	public void CGNKBPFILJL(byte PEHGODFBPBH, short IMDIJIDFJCA, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		ChallengePointsSystem.HACJFOGKBPO(PEHGODFBPBH, IMDIJIDFJCA, FDMHEDDIGPJ, IMOBLFMHKOD);
	}

	public static void SendBathhouseEntranceEventMoveToPlayer()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveBathhouseEntranceEventMoveToPlayer", (RpcTarget)1);
		}
	}

	public override void OnPlayerLeftRoom(Player OKAOHBANICM)
	{
		((MonoBehaviourPunCallbacks)this).OnPlayerLeftRoom(OKAOHBANICM);
		if (!OnlineManager.IsMasterClient())
		{
			return;
		}
		for (int i = 0; i < EventsManager.instance.allGameEvents.Count; i++)
		{
			if (EventsManager.instance.allGameEvents[i].isStarted)
			{
				EventsManager.instance.allGameEvents[i].OnOtherPlayerDisconnected(OKAOHBANICM.ActorNumber);
			}
		}
	}

	private void NDIOOLAOHAL(byte GJDMLMEMKMD)
	{
		PrecisionEvent.instance.IEMOGJADCBD(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD), sendOnline: true);
	}

	public static void SendCastleFormStartLucenEvent()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveCastleFormStartLucenEvent", (RpcTarget)1);
		}
	}

	public static void SendSimpleEvent(EventsManager.EventType AKADPCABHIB, short KLFCMPKLOFA)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveSimpleEvent", (RpcTarget)1, (int)AKADPCABHIB, KLFCMPKLOFA);
		}
	}

	public static void LEDFHLOEHGO()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "/Male/", (RpcTarget)1);
		}
	}

	public static void SendMothersRecipeEventCof()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveMothersRecipeEventCof", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void ReceiveFishCuttingEventThrowScene()
	{
		FishCuttingEvent.instance.ThrowScene();
	}

	public static void SendStartEvent(EventsManager.EventType AKADPCABHIB)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveStartEvent", (RpcTarget)1, (short)AKADPCABHIB);
		}
	}

	[PunRPC]
	private void ReceiveFishCuttingEventReturnToHouse()
	{
		FishCuttingEvent.instance.ReturnToHouse();
	}

	private void OGMLKBEBBBK()
	{
		IntroNinjaChallengeEvent.instance.NPJNFPJHBCJ();
	}

	[PunRPC]
	private void ReceiveJumpFerro2()
	{
		HotBathEvent.instance.FerroJump2();
	}

	public static void OKBPEHEHECD(EventsManager.EventType AKADPCABHIB)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[1];
			array[1] = (short)AKADPCABHIB;
			OnlineManager.SendRPC(photonView, "Moving", (RpcTarget)0, array);
		}
	}

	public static void NNFNBLDEAOJ(int FLHBPHPKIML)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = (byte)FLHBPHPKIML;
			OnlineManager.SendRPC(photonView, " ", (RpcTarget)0, array);
		}
	}

	public void PENMIMPIDIK(short AKADPCABHIB)
	{
		CHCEBDOKCNC = EventsManager.CJHIGMENDPK((EventsManager.EventType)AKADPCABHIB);
		CHCEBDOKCNC.StopPlayingChallenge();
	}

	public static void SendEasyDifficulty(bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveEasyDifficulty", (RpcTarget)1, DMBFKFLDDLH);
		}
	}

	[PunRPC]
	private void ReceivePourWater()
	{
		HotBathEvent.instance.PourWaterOnline();
	}

	private void KBLLPJNOLFK(byte GJDMLMEMKMD)
	{
		PrecisionEvent.instance.IEMOGJADCBD(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD), sendOnline: false);
	}

	public static void SendNinjaChallengeEventIntroJudge()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveNinjaChallengeEventIntroJudge", (RpcTarget)1);
		}
	}

	public static void SendEndEvent(EventsManager.EventType AKADPCABHIB)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveEndEvent", (RpcTarget)1, (short)AKADPCABHIB);
		}
	}

	private void BBKFCKJANHL()
	{
		NinjaChallengeEvent.instance.BKPGMMNBLFF();
	}

	private void GAKFACJLCMB()
	{
		NinjaChallengeEvent.instance.KOIPNJNNIBB();
	}

	private void GAMLAJMHDGG()
	{
		BathhouseEntraceEvent.instance.MoveToPlayerEvent();
	}

	[PunRPC]
	private void ReceiveSimpleEvent(int AKADPCABHIB, short KLFCMPKLOFA)
	{
		EventsManager.GetGameEvent((EventsManager.EventType)AKADPCABHIB).OnSimpleEvent(KLFCMPKLOFA);
	}

	[PunRPC]
	public void ReceiveRestartChallenge(short AKADPCABHIB)
	{
		CHCEBDOKCNC = EventsManager.GetGameEvent((EventsManager.EventType)AKADPCABHIB);
		CHCEBDOKCNC.RestartChallenge();
	}

	[PunRPC]
	private void ReceiveFishCuttingWinEvent()
	{
		FishCuttingEvent.instance.WinEvent();
	}

	public static void EAOBJJDKPKO()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Near", (RpcTarget)1);
		}
	}

	public static void SendFishCuttingWinEvent()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveFishCuttingWinEvent", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void RecieveEndMaiEvent()
	{
		OathFeastEvent.instance.EndMaiEventClientOnline();
	}

	[PunRPC]
	private void ReceiveEventActor(int AKADPCABHIB, int JJPJHIHBOIB)
	{
		CHCEBDOKCNC = EventsManager.GetGameEvent((EventsManager.EventType)AKADPCABHIB);
		if (Object.op_Implicit((Object)(object)CHCEBDOKCNC))
		{
			CHCEBDOKCNC.actorNumber = JJPJHIHBOIB;
		}
		else
		{
			Debug.LogError((object)("GameEvent with eventType: " + AKADPCABHIB + " not found in OnlineEventsManager."));
		}
	}

	public static void DOFFLLCJNPG(CharacterName CFGDHKLLKHB)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveDrinkDispenserMessage", (RpcTarget)1, (short)CFGDHKLLKHB);
		}
	}

	[PunRPC]
	private void ReceiveCastleFormStartKlaynDialogue()
	{
		CastleFormEvent.instance.StartKlaynDialogue();
	}

	private void HCEMPDDPDDG()
	{
		MothersRecipeEvent.instance.DIFKLAICAAE();
	}

	private void AAKGEMDLKHN(short AKADPCABHIB)
	{
		GameEvent gameEvent = EventsManager.AGKFBCAAADA((EventsManager.EventType)AKADPCABHIB);
		if ((Object)(object)gameEvent != (Object)null)
		{
			gameEvent.StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
			return;
		}
		EventsManager.EventType eventType = (EventsManager.EventType)AKADPCABHIB;
		Debug.LogError((object)("ReceiveRemoveZone" + eventType.ToString() + "itemCucumber"));
	}

	public void NLAMOAHMAPI(int JJPJHIHBOIB, short IMDIJIDFJCA, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		ChallengePointsSystem.OCBEBEDGKEN(IMDIJIDFJCA, IMOBLFMHKOD);
	}

	[PunRPC]
	private void ReceiveJumpFerro()
	{
		HotBathEvent.instance.FerroJump();
	}

	public static void CPDEKHLPFKI()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "MopDown", (RpcTarget)0);
		}
	}

	private void FLOJFMDLODP()
	{
		NinjaChallengeEvent.instance.BLOIGAMJLAH();
	}

	private void Awake()
	{
		instance = this;
	}

	public void GFKBCDBGPOH(EventsManager.EventType AKADPCABHIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)AKADPCABHIB;
		OnlineManager.SendRPC(photonView, "FailStart", (RpcTarget)1, array);
	}

	[PunRPC]
	public void ReceiveUpdatePoints(int JJPJHIHBOIB, short IMDIJIDFJCA, Vector2 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		ChallengePointsSystem.AddOpponentPoints(IMDIJIDFJCA, IMOBLFMHKOD);
	}

	private void POMBGOIJMIO()
	{
		OldMansDuelEvent.instance.CLHMDLEAHLP();
	}

	public static void SendNinjaChallengeEventMovePlayer()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveNinjaChallengeEventMovePlayer", (RpcTarget)1);
		}
	}

	private void NNPHBOIDHMB()
	{
		HotBathEvent.instance.GIBLFNNJNEL();
	}

	public static void OLBBLGOBIGA(bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Disappear", (RpcTarget)1, DMBFKFLDDLH);
		}
	}

	[PunRPC]
	private void ReceiveNinjaChallengeEventFadeOut()
	{
		NinjaChallengeEvent.instance.FadeOut();
	}

	public static void SendJumpFerro()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveJumpFerro", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void RecieveStartEvent(short AKADPCABHIB)
	{
		GameEvent gameEvent = EventsManager.GetGameEvent((EventsManager.EventType)AKADPCABHIB);
		if ((Object)(object)gameEvent != (Object)null)
		{
			gameEvent.StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
			return;
		}
		EventsManager.EventType eventType = (EventsManager.EventType)AKADPCABHIB;
		Debug.LogError((object)("GameEvent of type " + eventType.ToString() + " not found in OnlineEventsManager."));
	}

	public void SendStopPlayingChallenge(EventsManager.EventType AKADPCABHIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStopPlayingChallenge", (RpcTarget)1, (short)AKADPCABHIB);
	}

	public static void SendJumpFerro2()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveJumpFerro2", (RpcTarget)1);
		}
	}

	public static void SendIntroNinjaChallengeEventMoveZuzzu()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveIntroNinjaChallengeEventMoveZuzzu", (RpcTarget)1);
		}
	}

	private void KIBAGILAPLN()
	{
		CastleFormEvent.instance.OEPJDKGENDP();
	}

	public static void SendSimpleEventToMaster(EventsManager.EventType AKADPCABHIB, short KLFCMPKLOFA)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveSimpleEvent", (RpcTarget)2, (int)AKADPCABHIB, KLFCMPKLOFA);
		}
	}

	public static void SendNinjaChallengeEventStartMinigame()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveNinjaChallengeEventStartMinigame", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void ReceiveNinjaChallengeEventMovePlayer()
	{
		NinjaChallengeEvent.instance.MovePlayerAndKyroh();
	}

	public static void PBBHMONLDFM()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "itemCaramelWort", (RpcTarget)0);
		}
	}

	public static void SendStartSleep(int FLHBPHPKIML)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveStartSleep", (RpcTarget)1, (byte)FLHBPHPKIML);
		}
	}

	public static void LMONNMEDHBH(EventsManager.EventType AKADPCABHIB)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = (short)AKADPCABHIB;
			OnlineManager.SendRPC(photonView, "OnFloor", (RpcTarget)0, array);
		}
	}

	public static void OCJGNABGOJC(EventsManager.EventType AKADPCABHIB, short KLFCMPKLOFA)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[4];
			array[1] = (int)AKADPCABHIB;
			array[1] = KLFCMPKLOFA;
			OnlineManager.SendRPC(photonView, "Mod 1", (RpcTarget)7, array);
		}
	}

	[PunRPC]
	private void ReceiveMaiEventStart()
	{
		MaiSleepEvent.instance.StartMaiEvent();
	}

	public void SendRestartChallenge(EventsManager.EventType AKADPCABHIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRestartChallenge", (RpcTarget)1, (short)AKADPCABHIB);
	}

	private void PMGKJBADFPD()
	{
		NinjaChallengeEvent.instance.HLNBBJJJDMM();
	}

	private void AHEPDLDMIFC()
	{
		FishCuttingEvent.instance.FHMDDOFJAGL();
	}

	public static void AGHIGOKDCCL()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "", (RpcTarget)0);
		}
	}

	[PunRPC]
	private void ReceiveNinjaChallengeEventStartMinigame()
	{
		NinjaChallengeEvent.instance.StartMinigame();
	}

	private void OLLMNPFFCAH(short AKADPCABHIB)
	{
		GameEvent gameEvent = EventsManager.HJHEGHKGFGN((EventsManager.EventType)AKADPCABHIB);
		if ((Object)(object)gameEvent != (Object)null)
		{
			gameEvent.StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
			return;
		}
		EventsManager.EventType eventType = (EventsManager.EventType)AKADPCABHIB;
		Debug.LogError((object)("\n" + eventType.ToString() + "quest_reward_"));
	}

	[PunRPC]
	public void ReceiveAddPlayerPoints(byte PEHGODFBPBH, short IMDIJIDFJCA, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		ChallengePointsSystem.AddPlayerPoints(PEHGODFBPBH, IMDIJIDFJCA, FDMHEDDIGPJ, IMOBLFMHKOD);
	}

	[PunRPC]
	private void ReceiveCastleFormStartLucenDialogue()
	{
		CastleFormEvent.instance.StartLucenDialogue();
	}

	[PunRPC]
	private void ReceiveIntroNinjaChallengeEventMoveZuzzu()
	{
		IntroNinjaChallengeEvent.instance.MoveZuzzu();
	}

	public static void OFBOFLGMFLL(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = GJDMLMEMKMD;
			OnlineManager.SendRPC(photonView, "Year", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	private void RecieveOldMansDuelEndLaughAndMove()
	{
		OldMansDuelEvent.instance.EndLaughAndMove();
	}

	public static void JELFEKMGPNM()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "", (RpcTarget)1);
		}
	}

	public static void SendSetTableParent(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveSetTableParent", (RpcTarget)1, GJDMLMEMKMD);
		}
	}

	public void SendUpdatePoints(int IMDIJIDFJCA, Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUpdatePoints", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber, (short)IMDIJIDFJCA, IMOBLFMHKOD);
	}

	public static void SendOldMansDuelEndLaughAndMove()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveOldMansDuelEndLaughAndMove", (RpcTarget)1);
		}
	}

	public static void SendEndMaiEvent()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "RecieveEndMaiEvent", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void ReceiveNinjaChallengeEventIntroJudge()
	{
		NinjaChallengeEvent.instance.IntroJudge();
	}

	private void LNOAPCBHBIO(short AKADPCABHIB)
	{
		GameEvent gameEvent = EventsManager.MIMIMACHGKN((EventsManager.EventType)AKADPCABHIB);
		if ((Object)(object)gameEvent != (Object)null)
		{
			gameEvent.EndEvent(BGKCHMNJBLJ: false);
			return;
		}
		EventsManager.EventType eventType = (EventsManager.EventType)AKADPCABHIB;
		Debug.LogError((object)("Hurt" + eventType.ToString() + " totalMsgs: "));
	}

	public void SendAddPlayerPoints(int PEHGODFBPBH, int IMDIJIDFJCA, bool FDMHEDDIGPJ, Vector2 IMOBLFMHKOD)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddPlayerPoints", (RpcTarget)1, (byte)PEHGODFBPBH, (short)IMDIJIDFJCA, FDMHEDDIGPJ, IMOBLFMHKOD);
	}

	public void CGMEHHLICNO(short AKADPCABHIB)
	{
		CHCEBDOKCNC = EventsManager.MIMIMACHGKN((EventsManager.EventType)AKADPCABHIB);
		CHCEBDOKCNC.RestartChallenge();
	}

	public static void SendPourWater()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceivePourWater", (RpcTarget)1);
		}
	}
}
