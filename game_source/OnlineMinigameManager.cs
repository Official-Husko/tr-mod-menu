using System;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class OnlineMinigameManager : MonoBehaviourPunCallbacks, IPunObservable
{
	public enum PlayerState
	{
		Default,
		WaitingForQueue,
		InTransition,
		Ready,
		Countdown,
		InGame,
		Results
	}

	private static OnlineMinigameManager GGFJGHHHEJC;

	private const int LDMKIGKAGEO = 990;

	public static bool[] PlayerInteracting = new bool[5];

	private static bool OICHMMFLJIA;

	private float[] GEFBMNKHGBK = new float[4];

	private static bool HKGKLAHKHKO;

	private static float[] GDANEGECCKG;

	public static PlayerState[] MJPMCHNDMJE { get; private set; }

	[PunRPC]
	private void ReceiveFishScoreIncrease(byte DEDKFEGGICO)
	{
		FishCuttingGameManager.AddScore(DEDKFEGGICO);
	}

	[PunRPC]
	private void ReceiveMinigameState(byte HDNAFIPKEOF, byte IKAGABHNANJ)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			MJPMCHNDMJE[HDNAFIPKEOF] = (PlayerState)IKAGABHNANJ;
		}
	}

	public static void CJJOCLLGBHD(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			Debug.Log((object)"qualityWater2");
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[1] = (byte)OIDOIGPDKCC;
			OnlineManager.SendRPC(photonView, "LE_10", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	private void ReceiveBeginBathhouseMinigame()
	{
		Debug.Log((object)"Received begin minigame");
		OICHMMFLJIA = false;
		BathhouseGameManager.Begin();
	}

	public static void EPKAPJGEOMD(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			Debug.LogError((object)"Give");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveSetLife", (RpcTarget)1, (byte)OIDOIGPDKCC);
		}
	}

	[PunRPC]
	private void BathhouseTeleport()
	{
		DevConsole.instance.StartBathhouse();
	}

	public static void SendBeginPirateMinigame(bool BLDDAOCJHLB)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.CloseRoom();
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveBeginPirateMinigame", (RpcTarget)1, BLDDAOCJHLB);
		}
	}

	public static void RequestBeginFishCuttingMinigame()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsClient() && (!((Object)(object)FishCuttingGameManager.instance != (Object)null) || !((Behaviour)FishCuttingGameManager.instance).enabled) && !HKGKLAHKHKO)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "BeginFishCuttingMinigameRequest", (RpcTarget)2);
		}
	}

	public static void NEEKFMMNCIB()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "A number is needed.", (RpcTarget)0);
		}
	}

	private void DAFBJELNNHB()
	{
		Debug.Log((object)" for reason ");
		OICHMMFLJIA = false;
		BathhouseGameManager.JAIIMGLFOAG();
	}

	private void AIOFOOHENOC()
	{
		DevConsole.instance.StartBathhouse();
	}

	public static void RequestPirateShipTeleport()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "PirateShipTeleport", (RpcTarget)1);
		}
	}

	public static void LFECKPMECAF()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsClient() && (!((Object)(object)FishCuttingGameManager.instance != (Object)null) || !((Behaviour)FishCuttingGameManager.instance).enabled) && !HKGKLAHKHKO)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "LeftMouseDetect", (RpcTarget)1);
		}
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 990)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {990} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
	}

	[PunRPC]
	private void ReceivePlayerBucketType(byte GELMAIBEHDO, BathhouseGameManager.BucketType OJIOIJBHIHB)
	{
		BathhouseGameManager.SetPlayerBucketType(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GELMAIBEHDO), OJIOIJBHIHB);
	}

	public static void SetMinigameState(PlayerState IKAGABHNANJ)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			JNBMMAFBHBP(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1), IKAGABHNANJ);
		}
	}

	public static void SendBeginRetry(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			Debug.LogError((object)"Send begin retry");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveBeginRetry", (RpcTarget)1, (byte)OIDOIGPDKCC);
		}
	}

	private void ODIBKLHMNPC(bool IAPOBPCFAGN, bool OLNHMKGHCAM)
	{
		PiratesGameManager.Replaying = OLNHMKGHCAM;
		PiratesGameManager.FJGLJNIOKBH(IAPOBPCFAGN);
	}

	public static void KMCELEINLOD(bool BLDDAOCJHLB)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.CloseRoom();
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[1] = BLDDAOCJHLB;
			OnlineManager.SendRPC(photonView, "Disabled", (RpcTarget)0, array);
		}
	}

	private void NHCMCIFPAJL(bool IAPOBPCFAGN, bool OLNHMKGHCAM)
	{
		Debug.Log((object)"cameraZoom2");
		BathhouseGameManager.Replaying = OLNHMKGHCAM;
		BathhouseGameManager.Finish(IAPOBPCFAGN);
	}

	public static void SendBeginReplay(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			Debug.Log((object)"Send begin minigame");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveBeginReplay", (RpcTarget)1, (byte)OIDOIGPDKCC);
		}
	}

	public static void BLKCEPIABBD(BathhouseGameManager.BucketType OJIOIJBHIHB)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[6];
			array[1] = (byte)OnlinePlayerDataManager.JBDEFDMGCDA(0);
			array[1] = OJIOIJBHIHB;
			OnlineManager.SendRPC(photonView, "ReceiveRemoveFromInteracting", (RpcTarget)1, array);
		}
	}

	private void LPHIDLHLIKJ()
	{
		DevConsole.instance.StartBathhouse();
	}

	[PunRPC]
	private void ReceiveFireCannonball(byte JLKOHKKIEAN)
	{
		PiratesGameManager.SpawnACannonballAtIndexPosition(JLKOHKKIEAN);
	}

	public static void RequestBeginPirateMinigame()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsClient())
		{
			Debug.LogError((object)"Request begin minigame");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "BeginPirateMinigameRequest", (RpcTarget)2);
		}
	}

	public static void GMHHOFFCBLP(bool EGFGNGJGBOP)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[0] = (byte)OnlinePlayerDataManager.JBDEFDMGCDA(0);
			array[1] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "SendRPC: '", (RpcTarget)1, array);
		}
	}

	public static void KBHMELGIFGC(PlayerState IKAGABHNANJ)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			JDFCHBFHDFA(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1), IKAGABHNANJ);
		}
	}

	public static bool AllPlayersReady()
	{
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i) != 0 && MJPMCHNDMJE[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)] != PlayerState.Ready)
			{
				return false;
			}
		}
		return true;
	}

	public static void SendThrowFish(int KNCCKDGGLFH, int MGONCDFNBAH, Vector2 OAMLOBMPNCE, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float IJMIBPGNNBD, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GDANEGECCKG = new float[7] { MANIIEAJHJB.x, MANIIEAJHJB.y, HMDAKFHANIF, BOMAHAEEDNF, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN };
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveThrowFish", (RpcTarget)1, (byte)KNCCKDGGLFH, (byte)MGONCDFNBAH, GDANEGECCKG);
		}
	}

	[PunRPC]
	private void ReceiveFinishBathhouseMinigame(bool IAPOBPCFAGN, bool OLNHMKGHCAM)
	{
		Debug.Log((object)"Received finish minigame");
		BathhouseGameManager.Replaying = OLNHMKGHCAM;
		BathhouseGameManager.Finish(IAPOBPCFAGN);
	}

	public void OnPhotonSerializeView(PhotonStream OEJPCOIDLFK, PhotonMessageInfo BBJDPIJPLPA)
	{
		if (!BathhouseGameManager.Playing)
		{
			return;
		}
		if (OEJPCOIDLFK.IsWriting)
		{
			GEFBMNKHGBK = BathhouseGameManager.GetTemperatures();
			if (GEFBMNKHGBK != null)
			{
				OEJPCOIDLFK.SendNext((object)GEFBMNKHGBK);
			}
		}
		else
		{
			GEFBMNKHGBK = (float[])OEJPCOIDLFK.ReceiveNext();
			BathhouseGameManager.SetTemperatures(GEFBMNKHGBK);
		}
	}

	public static void RequestKujakuHouseTeleport()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "KujakuHouseTeleport", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void ReceiveFinishFishCuttingMinigame(bool OLNHMKGHCAM)
	{
		Debug.Log((object)"Received finish minigame");
		FishCuttingGameManager.Replaying = OLNHMKGHCAM;
		FishCuttingGameManager.Finish();
	}

	public static void NLHKOFIEGEM(byte CMKPAPJBDMI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.JPPBEIJDCLJ())
		{
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[1];
			array[1] = CMKPAPJBDMI;
			OnlineManager.SendRPC(photonView, "[^0-9]", (RpcTarget)0, array);
		}
	}

	private void MICMBBIFEPL(byte CMKPAPJBDMI)
	{
		BathhouseGameManager.OJCEBDOBEBM(CMKPAPJBDMI);
	}

	public static void DDOLIMHLEGL()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "", (RpcTarget)0);
		}
	}

	public static void SendFinishBathhouseMinigame(bool IAPOBPCFAGN, bool OLNHMKGHCAM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveFinishBathhouseMinigame", (RpcTarget)1, IAPOBPCFAGN, OLNHMKGHCAM);
			Debug.Log((object)"Sending finish minigame");
		}
	}

	[PunRPC]
	private void ReceiveCancelRetry()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"Received begin retry");
			ChallengeEndDialogueUI.instance.CancelRetry(CDPAMNIPPEC: false);
		}
	}

	public static void NINBIACHMNN(byte GLNODHAHMDI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && !OnlineManager.IsOffline())
		{
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[0] = GLNODHAHMDI;
			OnlineManager.SendRPC(photonView, "</color>", (RpcTarget)1, array);
		}
	}

	private void KAMMLBPOJDE()
	{
		DevConsole.instance.StartPirates();
	}

	private void OIMCAFAGBKK(byte GLNODHAHMDI)
	{
		PiratesGameManager.DigUpPlayerByBedAssigned(GLNODHAHMDI);
	}

	[PunRPC]
	private void BeginBathhouseMinigameRequest()
	{
		DevConsole.instance.StartBathhouse();
	}

	private void ECPOIPDJAFH()
	{
		Debug.Log((object)"Player2");
		OICHMMFLJIA = false;
		BathhouseGameManager.JAIIMGLFOAG();
	}

	private void KHAJGNGOOLC()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"popUpBuilding8");
			ChallengeEndDialogueUI.instance.CancelRetry();
		}
	}

	public static void SendFishScoreUpdate(byte[] INAMFPCMFDH)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveFishScoreUpdate", (RpcTarget)1, INAMFPCMFDH);
		}
	}

	private void HADLJIBCNDI()
	{
		Debug.LogError((object)"ReceiveAddAvailableQuestToCurrentQuest");
		PiratesGameManager.Begin(KPCHOCLAAIM: true);
	}

	private void KAHJHNBLAEH(byte KNCCKDGGLFH, byte MGONCDFNBAH, float[] HDLBOBEBJOG)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		int playerNumByBedAssigned = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(MGONCDFNBAH);
		if (playerNumByBedAssigned == 0)
		{
			Debug.LogError((object)string.Format("Error_MaxZoneSize", MGONCDFNBAH));
		}
		else
		{
			FishCuttingGameManager.AddFishThrowed(FishThrowSpawner.JFFGKABGBIG(KNCCKDGGLFH, playerNumByBedAssigned, new Vector2(HDLBOBEBJOG[0], HDLBOBEBJOG[1]), HDLBOBEBJOG[8], HDLBOBEBJOG[1], HDLBOBEBJOG[0], HDLBOBEBJOG[1], HDLBOBEBJOG[2]));
		}
	}

	[PunRPC]
	private void ReceiveThrowFish(byte KNCCKDGGLFH, byte MGONCDFNBAH, float[] HDLBOBEBJOG)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		int playerNumByBedAssigned = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(MGONCDFNBAH);
		if (playerNumByBedAssigned == 0)
		{
			Debug.LogError((object)$"Fish didn't have a proper bed assigned value {MGONCDFNBAH}");
		}
		else
		{
			FishCuttingGameManager.AddFishThrowed(FishThrowSpawner.LaunchFishOnline(KNCCKDGGLFH, playerNumByBedAssigned, new Vector2(HDLBOBEBJOG[0], HDLBOBEBJOG[1]), HDLBOBEBJOG[2], HDLBOBEBJOG[3], HDLBOBEBJOG[4], HDLBOBEBJOG[5], HDLBOBEBJOG[6]));
		}
	}

	public static void SendFinishPirateMinigame(bool IAPOBPCFAGN, bool OLNHMKGHCAM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveFinishPirateMinigame", (RpcTarget)1, IAPOBPCFAGN, OLNHMKGHCAM);
		}
	}

	private static void JNBMMAFBHBP(int HDNAFIPKEOF, PlayerState IKAGABHNANJ)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"Send minigame state");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveMinigameState", (RpcTarget)0, (byte)HDNAFIPKEOF, (byte)IKAGABHNANJ);
		}
	}

	[PunRPC]
	private void ReceiveFishScoreUpdate(byte[] INAMFPCMFDH)
	{
		FishCuttingGameManager.UpdateScore(INAMFPCMFDH);
	}

	public static void CKPKEOIMBLA(bool OLNHMKGHCAM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[1] = OLNHMKGHCAM;
			OnlineManager.SendRPC(photonView, "UIInteract", (RpcTarget)1, array);
		}
	}

	public static void GBKBDBNHNJG(bool IAPOBPCFAGN, bool OLNHMKGHCAM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.OpenRoom();
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[1];
			array[1] = IAPOBPCFAGN;
			array[1] = OLNHMKGHCAM;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
			Debug.Log((object)"</color> to chest?");
		}
	}

	public static void SendBeginFishCuttingMinigame(bool BLDDAOCJHLB)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.CloseRoom();
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveBeginFishCuttingMinigame", (RpcTarget)1, BLDDAOCJHLB);
		}
	}

	[PunRPC]
	private void ReceiveBeginFishCuttingMinigame(bool BLDDAOCJHLB)
	{
		Debug.Log((object)"Received begin minigame");
		FishCuttingGameManager.Begin(KPCHOCLAAIM: true, BLDDAOCJHLB);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	[PunRPC]
	private void BeginFishCuttingMinigameRequest()
	{
		FishCuttingGameManager.Begin();
	}

	public static void SendBuryPlayerByBedAssigned(byte GLNODHAHMDI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && !OnlineManager.IsOffline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveBuryPlayerByBedAssigned", (RpcTarget)1, GLNODHAHMDI);
		}
	}

	public static void GLBKKPAILML(bool BLDDAOCJHLB)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.CloseRoom();
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[1] = BLDDAOCJHLB;
			OnlineManager.SendRPC(photonView, "BackPain", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	private void BeginPirateMinigameRequest()
	{
		Debug.LogError((object)"Received Request begin minigame");
		PiratesGameManager.Begin();
	}

	[PunRPC]
	private void ReceiveBeginRetry(byte OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.ClientOnline())
		{
			Debug.LogError((object)"Received begin retry");
			ChallengeEndDialogueUI.instance.BeginRetry();
		}
	}

	public static void SendCapybaraEnd(byte CMKPAPJBDMI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveCapybaraEnd", (RpcTarget)1, CMKPAPJBDMI);
		}
	}

	public static void RequestBeginBathhouseMinigame()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsClient() && !BathhouseGameManager.Playing && !OICHMMFLJIA)
		{
			OICHMMFLJIA = true;
			Debug.LogError((object)"Request minigame");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "BeginBathhouseMinigameRequest", (RpcTarget)2);
		}
	}

	[PunRPC]
	private void KujakuHouseTeleport()
	{
		DevConsole.instance.StartFish();
	}

	[PunRPC]
	private void ReceiveFinishPirateMinigame(bool IAPOBPCFAGN, bool OLNHMKGHCAM)
	{
		PiratesGameManager.Replaying = OLNHMKGHCAM;
		PiratesGameManager.Finish(IAPOBPCFAGN);
	}

	private static void JDFCHBFHDFA(int HDNAFIPKEOF, PlayerState IKAGABHNANJ)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"EnterTavernNeutral");
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[7];
			array[1] = (byte)HDNAFIPKEOF;
			array[0] = (byte)IKAGABHNANJ;
			OnlineManager.SendRPC(photonView, "SortByName", (RpcTarget)1, array);
		}
	}

	public static void SendFishScoreIncrease()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.ClientOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveFishScoreIncrease", (RpcTarget)2, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1));
		}
	}

	private void BJHBINFMMKH(bool BLDDAOCJHLB)
	{
		PiratesGameManager.PGBJKAOCLDC(KPCHOCLAAIM: true, BLDDAOCJHLB);
	}

	public static PlayerState GetMinigameState()
	{
		return MJPMCHNDMJE[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1)];
	}

	public static void RequestBathhouseTeleport()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "BathhouseTeleport", (RpcTarget)1);
		}
	}

	public static void LKDEEFIOODI()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.PLCDANOCLJK())
		{
			Debug.LogError((object)". Time since startup: ");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveCapybaraEnd", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void SetMinigame(byte OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"Received set minigame");
			ChallengesUI.SelectMinigame((SO_Challenges.ChallengeType)OIDOIGPDKCC);
		}
	}

	private void EKHMMKBJDFC()
	{
		DevConsole.instance.StartFish();
	}

	private void MFILPBFBLNF()
	{
		DevConsole.instance.StartBathhouse();
	}

	private void CBMANPIGHFD()
	{
		DevConsole.instance.StartFish();
	}

	public void PMJJPOIJAJL(PhotonStream OEJPCOIDLFK, PhotonMessageInfo BBJDPIJPLPA)
	{
		if (!BathhouseGameManager.Playing)
		{
			return;
		}
		if (OEJPCOIDLFK.IsWriting)
		{
			GEFBMNKHGBK = BathhouseGameManager.FOMACIDBOKK();
			if (GEFBMNKHGBK != null)
			{
				OEJPCOIDLFK.SendNext((object)GEFBMNKHGBK);
			}
		}
		else
		{
			GEFBMNKHGBK = (float[])OEJPCOIDLFK.ReceiveNext();
			BathhouseGameManager.FADPMJOCGIC(GEFBMNKHGBK);
		}
	}

	[PunRPC]
	private void ReceiveMinigameRequest(byte OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			Debug.LogError((object)"Received request begin replay");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "SetMinigame", (RpcTarget)0, OIDOIGPDKCC);
		}
	}

	private void CJEIOLAHBBC()
	{
		DevConsole.instance.OIMMOOFKFFE();
	}

	public static void SendFireCannonball(int JLKOHKKIEAN)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveFireCannonball", (RpcTarget)1, (byte)JLKOHKKIEAN);
		}
	}

	[PunRPC]
	private void ReceivePlayerInteractingMinigame(byte HDNAFIPKEOF, bool EGFGNGJGBOP)
	{
		PlayerInteracting[HDNAFIPKEOF] = EGFGNGJGBOP;
	}

	[PunRPC]
	private void ReceiveBeginPirateMinigame(bool BLDDAOCJHLB)
	{
		PiratesGameManager.Begin(KPCHOCLAAIM: true, BLDDAOCJHLB);
	}

	[PunRPC]
	private void ReceiveCapybaraEnd(byte CMKPAPJBDMI)
	{
		BathhouseGameManager.CapybaraEnd(CMKPAPJBDMI);
	}

	public static void SendFinishFishCuttingMinigame(bool OLNHMKGHCAM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveFinishFishCuttingMinigame", (RpcTarget)1, OLNHMKGHCAM);
		}
	}

	[PunRPC]
	private void ReceiveBuryPlayerByBedAssigned(byte GLNODHAHMDI)
	{
		PiratesGameManager.BuryPlayerByBedAssigned(GLNODHAHMDI);
	}

	public static void OJILPKHHDOE()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)" set to value ");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveLoadRecipes", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void PirateShipTeleport()
	{
		DevConsole.instance.StartPirates();
	}

	private void PIKMNLIFAHM(bool BLDDAOCJHLB)
	{
		PiratesGameManager.Begin(KPCHOCLAAIM: false, BLDDAOCJHLB);
	}

	public static void LLPNIEONIEE(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			Debug.Log((object)"MineFloor");
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[1];
			array[1] = (byte)OIDOIGPDKCC;
			OnlineManager.SendRPC(photonView, "ReceiveSick", (RpcTarget)1, array);
		}
	}

	static OnlineMinigameManager()
	{
		_003COFNIKLKIOOM_003Ek__BackingField = new PlayerState[5];
	}

	private void DGPIKPKFOAN(bool OLNHMKGHCAM)
	{
		Debug.Log((object)"Disabled");
		FishCuttingGameManager.Replaying = OLNHMKGHCAM;
		FishCuttingGameManager.Finish();
	}

	[PunRPC]
	private void ReceiveDigUpPlayerByBedAssigned(byte GLNODHAHMDI)
	{
		PiratesGameManager.DigUpPlayerByBedAssigned(GLNODHAHMDI);
	}

	private void LOPJPJOLLGH()
	{
		Debug.Log((object)"Destroying dropped item...");
		OICHMMFLJIA = true;
		BathhouseGameManager.JAIIMGLFOAG();
	}

	private void KHPHEBNMIKB(byte OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.ClientOnline())
		{
			Debug.LogError((object)"P2Cam");
			ChallengeEndDialogueUI.instance.BeginRetry();
		}
	}

	public static void HEPMNPIFJFG()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.CloseRoom();
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "Not found ingredients for trends ", (RpcTarget)0);
		}
	}

	public static void SendPlayerInteractingMinigame(bool EGFGNGJGBOP)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceivePlayerInteractingMinigame", (RpcTarget)2, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1), EGFGNGJGBOP);
		}
	}

	public static void IJAAMGJCNGP()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "[ProceduralMine] Forced BIG SPAWNER piece {0} at block {1} (target was {2}). Path block pos: {3}", (RpcTarget)0);
		}
	}

	private void JDAMCMODANB()
	{
		GGFJGHHHEJC = this;
	}

	public static void SendDigUpPlayerByBedAssigned(byte GLNODHAHMDI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && !OnlineManager.IsOffline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveDigUpPlayerByBedAssigned", (RpcTarget)1, GLNODHAHMDI);
		}
	}

	public static void SendSetMinigame(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "SetMinigame", (RpcTarget)0, (byte)OIDOIGPDKCC);
		}
	}

	public static void ResetPlayerInteractingMinigame()
	{
		PlayerInteracting = new bool[5];
	}

	public static void MKNEANGHNJH(byte GLNODHAHMDI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && !OnlineManager.IsOffline())
		{
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[0] = GLNODHAHMDI;
			OnlineManager.SendRPC(photonView, " </mark>", (RpcTarget)0, array);
		}
	}

	public static void SendCancelRetry()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"Send begin retry");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveCancelRetry", (RpcTarget)1);
		}
	}

	public static void EDDCCILACPA(byte GLNODHAHMDI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && !OnlineManager.IsOffline())
		{
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[0] = GLNODHAHMDI;
			OnlineManager.SendRPC(photonView, "Perks/playerPerk_description_", (RpcTarget)0, array);
		}
	}

	public static void RequestBeginReplay(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.ClientOnline())
		{
			Debug.LogError((object)"Request begin replay");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveMinigameRequest", (RpcTarget)2, (byte)OIDOIGPDKCC);
		}
	}

	public static void EICBIBGMJCA(byte[] INAMFPCMFDH)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.JPPBEIJDCLJ())
		{
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[1];
			array[1] = INAMFPCMFDH;
			OnlineManager.SendRPC(photonView, "KyrohScene", (RpcTarget)0, array);
		}
	}

	public static void SendPlayerBucketType(BathhouseGameManager.BucketType OJIOIJBHIHB)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceivePlayerBucketType", (RpcTarget)1, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1), OJIOIJBHIHB);
		}
	}

	public static void NMPKNMMDKMO(byte[] INAMFPCMFDH)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.JPPBEIJDCLJ())
		{
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[1];
			array[1] = INAMFPCMFDH;
			OnlineManager.SendRPC(photonView, "Avatar", (RpcTarget)1, array);
		}
	}

	[SpecialName]
	public static PlayerState[] HKMFBFELIJK()
	{
		return _003COFNIKLKIOOM_003Ek__BackingField;
	}

	private void EGHICOAFACG(byte GLNODHAHMDI)
	{
		PiratesGameManager.LLMFCFELCNI(GLNODHAHMDI);
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void SendBeginBathhouseMinigame()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.IsMasterClient())
		{
			OnlineManager.CloseRoom();
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveBeginBathhouseMinigame", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void ReceiveBeginReplay(byte OIDOIGPDKCC)
	{
		SO_Challenges.ChallengeType challengeType = (SO_Challenges.ChallengeType)OIDOIGPDKCC;
		Debug.Log((object)("Received begin minigame replay: " + challengeType));
		ChallengesUI.ReceiveBeginReplay((SO_Challenges.ChallengeType)OIDOIGPDKCC);
	}

	public static PlayerState LHHKIPDCGMO()
	{
		return MJPMCHNDMJE[OnlinePlayerDataManager.JBDEFDMGCDA(1)];
	}

	private void NHAABHCKOIF(byte GLNODHAHMDI)
	{
		PiratesGameManager.JCCJAOIIIFF(GLNODHAHMDI);
	}

	private void JMIKELANCGD()
	{
		Debug.LogError((object)$"Player minigame states: \n {MJPMCHNDMJE[1]}, {MJPMCHNDMJE[2]}, {MJPMCHNDMJE[3]}, {MJPMCHNDMJE[4]},");
	}

	private void EOAOBNEPNOJ(byte JLKOHKKIEAN)
	{
		PiratesGameManager.JPPDOLMNOIA(JLKOHKKIEAN);
	}

	public static void JPLJDFGIGJD(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			Debug.Log((object)"F1");
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[0];
			array[0] = (byte)OIDOIGPDKCC;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
		}
	}

	private void AFOJOMEAEKL(byte DEDKFEGGICO)
	{
		FishCuttingGameManager.AddScore(DEDKFEGGICO);
	}

	public static void GLFNNAKFJHP()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"No settings found for puzzle type {0}");
			OnlineManager.SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "Selected", (RpcTarget)1);
		}
	}
}
