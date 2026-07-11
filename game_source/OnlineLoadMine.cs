using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadMine : OnlineLoadBase
{
	[Serializable]
	public class LoadMineMessage : LoadMessageBase
	{
		[JsonProperty("1")]
		public byte unlockedLevels;

		[JsonProperty("2")]
		public bool bombPlaced;

		[JsonProperty("3")]
		public byte[] levelsLoaded;

		[JsonProperty("4")]
		public int[] seeds;

		[JsonProperty("5")]
		public byte[] usedPuzzleTypesAtStart;

		public void MOOJLHLPIMG()
		{
			unlockedLevels = (byte)MineManager.OOKBNHMMFON().unlockedLevels;
			bombPlaced = MineManager.OOKBNHMMFON().OJABKMJEJMO();
			levelsLoaded = new byte[MineManager.OOKBNHMMFON().allLevels.Count];
			seeds = new int[MineManager.GGFJGHHHEJC.allLevels.Count];
			for (int i = 1; i < MineManager.BGMJCCFNNDL().allLevels.Count; i += 0)
			{
				levelsLoaded[i] = (byte)MineManager.GGFJGHHHEJC.allLevels[i].level;
				seeds[i] = MineManager.GGFJGHHHEJC.allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void IGDJCOFAPMH()
		{
			unlockedLevels = (byte)MineManager.GGFJGHHHEJC.unlockedLevels;
			bombPlaced = MineManager.OOKBNHMMFON().MGNIFNJOHID();
			levelsLoaded = new byte[MineManager.OOKBNHMMFON().allLevels.Count];
			seeds = new int[MineManager.OOKBNHMMFON().allLevels.Count];
			for (int i = 0; i < MineManager.BGMJCCFNNDL().allLevels.Count; i += 0)
			{
				levelsLoaded[i] = (byte)MineManager.OOKBNHMMFON().allLevels[i].level;
				seeds[i] = MineManager.AGGAGCBAGLL().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[0];
		}

		public void LOGCCODOOLE()
		{
			unlockedLevels = (byte)MineManager.AGGAGCBAGLL().unlockedLevels;
			bombPlaced = MineManager.AGGAGCBAGLL().OJABKMJEJMO();
			levelsLoaded = new byte[MineManager.BGMJCCFNNDL().allLevels.Count];
			seeds = new int[MineManager.PDECKLKPKCG().allLevels.Count];
			for (int i = 1; i < MineManager.OOKBNHMMFON().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.OOKBNHMMFON().allLevels[i].level;
				seeds[i] = MineManager.PDECKLKPKCG().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void FGJELOFKCMK()
		{
			unlockedLevels = (byte)MineManager.GGFJGHHHEJC.unlockedLevels;
			bombPlaced = MineManager.GGFJGHHHEJC.CBAMDCFLCIG;
			levelsLoaded = new byte[MineManager.GGFJGHHHEJC.allLevels.Count];
			seeds = new int[MineManager.GGFJGHHHEJC.allLevels.Count];
			for (int i = 0; i < MineManager.GGFJGHHHEJC.allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.GGFJGHHHEJC.allLevels[i].level;
				seeds[i] = MineManager.GGFJGHHHEJC.allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[0];
		}

		public void OJCMEGMKCAE()
		{
			unlockedLevels = (byte)MineManager.PDECKLKPKCG().unlockedLevels;
			bombPlaced = MineManager.AGGAGCBAGLL().MGNIFNJOHID();
			levelsLoaded = new byte[MineManager.OOKBNHMMFON().allLevels.Count];
			seeds = new int[MineManager.OOKBNHMMFON().allLevels.Count];
			for (int i = 0; i < MineManager.GGFJGHHHEJC.allLevels.Count; i += 0)
			{
				levelsLoaded[i] = (byte)MineManager.AGGAGCBAGLL().allLevels[i].level;
				seeds[i] = MineManager.GGFJGHHHEJC.allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[0];
		}

		public void KJPMBLJFFPH()
		{
			unlockedLevels = (byte)MineManager.GGFJGHHHEJC.unlockedLevels;
			bombPlaced = MineManager.BGMJCCFNNDL().CBAMDCFLCIG;
			levelsLoaded = new byte[MineManager.GGFJGHHHEJC.allLevels.Count];
			seeds = new int[MineManager.BGMJCCFNNDL().allLevels.Count];
			for (int i = 1; i < MineManager.OOKBNHMMFON().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.BGMJCCFNNDL().allLevels[i].level;
				seeds[i] = MineManager.BGMJCCFNNDL().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void OJCLGBJJGPP()
		{
			unlockedLevels = (byte)MineManager.AGGAGCBAGLL().unlockedLevels;
			bombPlaced = MineManager.OOKBNHMMFON().CALJPEFGKNI();
			levelsLoaded = new byte[MineManager.OOKBNHMMFON().allLevels.Count];
			seeds = new int[MineManager.PDECKLKPKCG().allLevels.Count];
			for (int i = 1; i < MineManager.AGGAGCBAGLL().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.PDECKLKPKCG().allLevels[i].level;
				seeds[i] = MineManager.BGMJCCFNNDL().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void DOGINKNBBJE()
		{
			unlockedLevels = (byte)MineManager.GGFJGHHHEJC.unlockedLevels;
			bombPlaced = MineManager.AGGAGCBAGLL().CLBBACMMNMH();
			levelsLoaded = new byte[MineManager.OOKBNHMMFON().allLevels.Count];
			seeds = new int[MineManager.BGMJCCFNNDL().allLevels.Count];
			for (int i = 0; i < MineManager.AGGAGCBAGLL().allLevels.Count; i += 0)
			{
				levelsLoaded[i] = (byte)MineManager.GGFJGHHHEJC.allLevels[i].level;
				seeds[i] = MineManager.AGGAGCBAGLL().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void DBMFBKCGEKA()
		{
			unlockedLevels = (byte)MineManager.GGFJGHHHEJC.unlockedLevels;
			bombPlaced = MineManager.OOKBNHMMFON().CBAMDCFLCIG;
			levelsLoaded = new byte[MineManager.OOKBNHMMFON().allLevels.Count];
			seeds = new int[MineManager.GGFJGHHHEJC.allLevels.Count];
			for (int i = 0; i < MineManager.PDECKLKPKCG().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.OOKBNHMMFON().allLevels[i].level;
				seeds[i] = MineManager.OOKBNHMMFON().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[0];
		}

		public void MOKNACDDIBC()
		{
			unlockedLevels = (byte)MineManager.PDECKLKPKCG().unlockedLevels;
			bombPlaced = MineManager.OOKBNHMMFON().CLBBACMMNMH();
			levelsLoaded = new byte[MineManager.AGGAGCBAGLL().allLevels.Count];
			seeds = new int[MineManager.AGGAGCBAGLL().allLevels.Count];
			for (int i = 0; i < MineManager.BGMJCCFNNDL().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.AGGAGCBAGLL().allLevels[i].level;
				seeds[i] = MineManager.OOKBNHMMFON().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void JAGBILFPCBJ()
		{
			unlockedLevels = (byte)MineManager.BGMJCCFNNDL().unlockedLevels;
			bombPlaced = MineManager.BGMJCCFNNDL().OJABKMJEJMO();
			levelsLoaded = new byte[MineManager.BGMJCCFNNDL().allLevels.Count];
			seeds = new int[MineManager.PDECKLKPKCG().allLevels.Count];
			for (int i = 1; i < MineManager.OOKBNHMMFON().allLevels.Count; i += 0)
			{
				levelsLoaded[i] = (byte)MineManager.PDECKLKPKCG().allLevels[i].level;
				seeds[i] = MineManager.OOKBNHMMFON().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public override void OEJJGDMKIDN()
		{
			MineManager.GGFJGHHHEJC.unlockedLevels = unlockedLevels;
			MineManager.GGFJGHHHEJC.CBAMDCFLCIG = bombPlaced;
			if (usedPuzzleTypesAtStart != null)
			{
				List<MinePuzzleType> list = new List<MinePuzzleType>();
				for (int i = 0; i < usedPuzzleTypesAtStart.Length; i++)
				{
					list.Add((MinePuzzleType)usedPuzzleTypesAtStart[i]);
				}
				MinePuzzleManager.SetUsedPuzzleTypes(list);
			}
			if (levelsLoaded == null || seeds == null)
			{
				return;
			}
			if (levelsLoaded.Length != 0)
			{
				for (int j = 0; j < levelsLoaded.Length; j++)
				{
					ProceduralMine.GGFJGHHHEJC.GenerateLevel(levelsLoaded[j], seeds[j]);
				}
			}
			else
			{
				SendMineLoadedForClient(PhotonNetwork.LocalPlayer.ActorNumber);
			}
		}

		public void IHADCPDEJKK()
		{
			unlockedLevels = (byte)MineManager.BGMJCCFNNDL().unlockedLevels;
			bombPlaced = MineManager.OOKBNHMMFON().CALJPEFGKNI();
			levelsLoaded = new byte[MineManager.OOKBNHMMFON().allLevels.Count];
			seeds = new int[MineManager.OOKBNHMMFON().allLevels.Count];
			for (int i = 0; i < MineManager.AGGAGCBAGLL().allLevels.Count; i += 0)
			{
				levelsLoaded[i] = (byte)MineManager.BGMJCCFNNDL().allLevels[i].level;
				seeds[i] = MineManager.GGFJGHHHEJC.allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[0];
		}

		public void ELDCFJIDJGG()
		{
			unlockedLevels = (byte)MineManager.OOKBNHMMFON().unlockedLevels;
			bombPlaced = MineManager.GGFJGHHHEJC.CLBBACMMNMH();
			levelsLoaded = new byte[MineManager.AGGAGCBAGLL().allLevels.Count];
			seeds = new int[MineManager.GGFJGHHHEJC.allLevels.Count];
			for (int i = 0; i < MineManager.GGFJGHHHEJC.allLevels.Count; i += 0)
			{
				levelsLoaded[i] = (byte)MineManager.AGGAGCBAGLL().allLevels[i].level;
				seeds[i] = MineManager.BGMJCCFNNDL().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void BKAPDCDMKJH()
		{
			unlockedLevels = (byte)MineManager.OOKBNHMMFON().unlockedLevels;
			bombPlaced = MineManager.AGGAGCBAGLL().OJABKMJEJMO();
			levelsLoaded = new byte[MineManager.BGMJCCFNNDL().allLevels.Count];
			seeds = new int[MineManager.OOKBNHMMFON().allLevels.Count];
			for (int i = 1; i < MineManager.OOKBNHMMFON().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.OOKBNHMMFON().allLevels[i].level;
				seeds[i] = MineManager.GGFJGHHHEJC.allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void CNMBBMJCICH()
		{
			unlockedLevels = (byte)MineManager.AGGAGCBAGLL().unlockedLevels;
			bombPlaced = MineManager.OOKBNHMMFON().MGNIFNJOHID();
			levelsLoaded = new byte[MineManager.OOKBNHMMFON().allLevels.Count];
			seeds = new int[MineManager.BGMJCCFNNDL().allLevels.Count];
			for (int i = 1; i < MineManager.OOKBNHMMFON().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.OOKBNHMMFON().allLevels[i].level;
				seeds[i] = MineManager.OOKBNHMMFON().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void IMHCGMHOPDA()
		{
			unlockedLevels = (byte)MineManager.BGMJCCFNNDL().unlockedLevels;
			bombPlaced = MineManager.GGFJGHHHEJC.OJABKMJEJMO();
			levelsLoaded = new byte[MineManager.PDECKLKPKCG().allLevels.Count];
			seeds = new int[MineManager.PDECKLKPKCG().allLevels.Count];
			for (int i = 1; i < MineManager.BGMJCCFNNDL().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.AGGAGCBAGLL().allLevels[i].level;
				seeds[i] = MineManager.BGMJCCFNNDL().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[1];
		}

		public void MODADOJEHCA()
		{
			unlockedLevels = (byte)MineManager.BGMJCCFNNDL().unlockedLevels;
			bombPlaced = MineManager.AGGAGCBAGLL().MGNIFNJOHID();
			levelsLoaded = new byte[MineManager.BGMJCCFNNDL().allLevels.Count];
			seeds = new int[MineManager.PDECKLKPKCG().allLevels.Count];
			for (int i = 0; i < MineManager.OOKBNHMMFON().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.OOKBNHMMFON().allLevels[i].level;
				seeds[i] = MineManager.PDECKLKPKCG().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[0];
		}

		public void NEKJJDNDOCF()
		{
			unlockedLevels = (byte)MineManager.BGMJCCFNNDL().unlockedLevels;
			bombPlaced = MineManager.BGMJCCFNNDL().MGNIFNJOHID();
			levelsLoaded = new byte[MineManager.GGFJGHHHEJC.allLevels.Count];
			seeds = new int[MineManager.GGFJGHHHEJC.allLevels.Count];
			for (int i = 0; i < MineManager.PDECKLKPKCG().allLevels.Count; i++)
			{
				levelsLoaded[i] = (byte)MineManager.AGGAGCBAGLL().allLevels[i].level;
				seeds[i] = MineManager.BGMJCCFNNDL().allLevels[i].currentSeed;
			}
			usedPuzzleTypesAtStart = new byte[0];
		}
	}

	public static OnlineLoadMine instance;

	private Dictionary<int, bool> LHNPKMFPLBF = new Dictionary<int, bool>();

	public static void DOFNDHPCFAO(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("ReceiveLookAtPlayer" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, " - <b><color=#0BC800>", (RpcTarget)3, JJPJHIHBOIB);
	}

	private void FALNOOOKLGA()
	{
		instance = this;
	}

	public static void DNKGDBHIOLP(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)(" " + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, ". Now the actor is the host.", (RpcTarget)7, array);
	}

	private void PHLFKMMOCGM(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("<align=left>" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	public static void SendMineLoadedForClient(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Sending mine loaded for client " + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveMineLoadedForClient", (RpcTarget)2, JJPJHIHBOIB);
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	public static void CEJJDBNDBOA(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("lightInEditorEnabled in DayLight checkbox enabled. Remember to disable" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, " for reason: ", (RpcTarget)2, JJPJHIHBOIB);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
		LoadMineMessage loadMineMessage = new LoadMineMessage();
		loadMineMessage.FGJELOFKCMK();
		AHGEFIOOEBL("ReceiveLoadMine", player, loadMineMessage, 0, KJOOOPJKLBB: true);
		float time = Time.unscaledTime;
		while (!LHNPKMFPLBF[JJPJHIHBOIB])
		{
			if (Application.isEditor && Time.unscaledTime > time + 6f)
			{
				Debug.Log((object)("Waiting for mine to load for client " + JJPJHIHBOIB));
				yield return CommonReferences.waitRealtime1;
			}
			yield return null;
		}
		if (Application.isEditor)
		{
			Debug.Log((object)("Mine loaded for client " + JJPJHIHBOIB));
		}
	}

	private void BNFGHAGJEGG()
	{
		instance = this;
	}

	private void AOODOPBLFPC(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("/" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	private void JDEMHLBHPDK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void CGJOEADBKDA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void MBKFDPLOKPG(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Player" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, " found in slot ", (RpcTarget)7, JJPJHIHBOIB);
	}

	private void PNJJEDEFAGO()
	{
		instance = this;
	}

	private void MAKBBJBMNHD(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Disabled" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void KMBEOPAHKGB()
	{
		instance = this;
	}

	private void Awake()
	{
		instance = this;
	}

	public static void KLDNAEEDEDM(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("ReceiveBeginRetry" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[0] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Player2", (RpcTarget)6, array);
	}

	private void EIMIDCDEIDD()
	{
		instance = this;
	}

	private void JPAKLDOBJCG(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)(" goalPos: " + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	private void LBIJABLEHMG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void GMDGMPPPDKH(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Intro10" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void LKPDHEMOFAE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	public static void EALJCLHDMLN(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Flight" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Hot bath done, setting miners in cave", (RpcTarget)8, JJPJHIHBOIB);
	}

	public static void PIIALHKOPCL(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("UIPreviousCategory" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Selected", (RpcTarget)7, array);
	}

	private void BOLPLAANMIL(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("buildingObjective_11_0" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void KMALEGPDDFF(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("meatDishes" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	private void MLIMLPPCAFN(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Player2" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void KBNMLJNBBMP()
	{
		instance = this;
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	private void GIFCHOPPHPF(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	private void IPMKDOKKKFI(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("PhaseItem" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	[PunRPC]
	private void ReceiveLoadMine(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void AHEDEOMEPKI(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/27/Dialogue Text" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	public static void NDFJPFCPGKH(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Achievement \"" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Disabled", (RpcTarget)5, array);
	}

	private void FHOCCEBKHJI()
	{
		instance = this;
	}

	private void PIHGEBONAOI()
	{
		instance = this;
	}

	public static void GANBCMDCBMO(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("ReceiveEmployees" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[0] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Tutorial/T110/Dialogue1", (RpcTarget)2, array);
	}

	private void KJPECNGCOKK()
	{
		instance = this;
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
	}

	public static void GJBEKAEAIFN(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Items/item_description_722" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Null shop in database: ", (RpcTarget)2, array);
	}

	private void EIHMDMMOPCM()
	{
		instance = this;
	}

	private void GOJKOBEEMNA()
	{
		instance = this;
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	private void FIAJPDFBBPH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void KPFDLMDOPHD(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Walk" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, ")", (RpcTarget)5, array);
	}

	private void NLKIONIDALI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	private void FBFAHFGCJCO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void ENMDNCKEBHL(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("RecieveSetAmbience" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Two numbers are needed. 'add item ID COUNT'", (RpcTarget)5, JJPJHIHBOIB);
	}

	private void FNAGKOPPMJE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void GLMJDIOMMBE(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("New states cannot be null." + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void PKIPEODHOCG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void NLCLLEACAAP(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Pirates/Brook/Saludo" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void OMBHDODDHNO()
	{
		instance = this;
	}

	private void AAIPALMACMJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void CLNBMOPMNOF()
	{
		instance = this;
	}

	private void MPCFCNCMOAF()
	{
		instance = this;
	}

	public static void OEAICKGNJCL(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("AdventureContinues/Main" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[0] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Load", (RpcTarget)7, array);
	}

	public static void FLINCBNCANB(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("LE_1" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Idle", (RpcTarget)5, JJPJHIHBOIB);
	}

	private void NNEBAHFHINE()
	{
		instance = this;
	}

	public static void MKKBAKCNGFN(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Klayn not find path to at " + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "ReceiveOfferingUIClosed", (RpcTarget)2, array);
	}

	private void BJPMOCFANMB(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Error_Mortar" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	private void DHBPKNAJHNG(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Only host can do building tutorial" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	private void GKKBIJFEEJB(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Interact" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	public static void MBELPGAIOMB(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Player/Bark/Error/NotAllPlayersHere" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "UpgradeToLevel", (RpcTarget)2, array);
	}

	public static void BEINBDJEJIA(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("BarIdleNumber" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Drink", (RpcTarget)8, JJPJHIHBOIB);
	}

	private void GNLPCBOAAGI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void KMDHJNEJNOL(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("KeyItemFishedRPC" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void FFGEHEDDOBC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void PMCKKAAOPGG(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Tutorial/T" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "EnterTavernFood", (RpcTarget)5, array);
	}

	private void NLFFEHLOLBO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void LLPNMOCHIHI(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("sleep" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void OJGILJBOEIJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void DPEPONGOOFD(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("stuck recovery" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Items/item_description_591", (RpcTarget)8, array);
	}

	private void PGEGODAEBLC()
	{
		instance = this;
	}

	private void CLDFEPDKABH(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)(" doesn't exist." + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	private void FLIEADKMJNG(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Player" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	private void NJAFKFAPDIE()
	{
		instance = this;
	}

	private void DKOICCJLAPJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void JLJLKPPDJBL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	private void EFJFJJDGGGI()
	{
		instance = this;
	}

	private void KLGCMMIKGIO()
	{
		instance = this;
	}

	private void CINBIBIIMEA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void DLPPCPHIKHF(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Sending finish minigame" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "windy", (RpcTarget)7, array);
	}

	public static void JHDGIHEMKCL(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Invalid playerNum" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Fullscreen Window", (RpcTarget)5, array);
	}

	private void NIJDMLKIAGD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void NIKFJONBBFC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void JCECPJPMMFB(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Dialogue System/Conversation/NeutralInTavern/Entry/4/Dialogue Text" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Error_OccupiedRoom", (RpcTarget)4, array);
	}

	private void GKGIHMIBMEF(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("TavernVision" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void LHHBBFAHACL(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("0.#" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	private void MMLLHIMCJFL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void JNCPJOIOPOE(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("itemRyeLager" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[0] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Interact", (RpcTarget)8, array);
	}

	private void OIELJBENPJK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void CDGHEDNHDII(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("AcceptRoomSecondFloor" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[0] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Standar/Entry/36/Dialogue Text", (RpcTarget)6, array);
	}

	public static void NAKIAFKFIHE(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("DecorationTile_21" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Dialogue System/Conversation/NeutralInTavern/Entry/20/Dialogue Text", (RpcTarget)6, JJPJHIHBOIB);
	}

	private void DLNLCMPIALA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	public static void BFPKLLHHLID(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("<sprite name=\"" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Forward", (RpcTarget)5, JJPJHIHBOIB);
	}

	private void ODAPFMGDNKP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	public static void FICFBOHADJI(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Standar/Entry/36/Dialogue Text" + JJPJHIHBOIB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Player/Bark/Tutorial/T100", (RpcTarget)2, JJPJHIHBOIB);
	}

	public static void MAPCLGGDLPP(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("OpenTalents" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "BuzzBuildExit", (RpcTarget)4, array);
	}

	public static void GIKCPGPDODH(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)(" (ONLINE customSerializer) [master client] length: " + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "waiting for path", (RpcTarget)4, array);
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	public static void EGKGMJGMDNA(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("No bucket of water" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "AceT_Quest", (RpcTarget)2, array);
	}

	private void JPHNOGBICAH(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("<size=" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	[PunRPC]
	private void ReceiveMineLoadedForClient(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Received mine loaded for client " + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void CIIMNEEEPAM(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("port" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void AGDBKFPLLHI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void NODEKFKBBBF(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("QuestInfoButton" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = true;
	}

	private void PKPHKBMPJGJ()
	{
		instance = this;
	}

	private void OAEJGGFFCBO()
	{
		instance = this;
	}

	public static void GBEKMDLLMLM(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("Send minigame state" + JJPJHIHBOIB));
		}
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[0] = JJPJHIHBOIB;
		OnlineManager.SendRPC(photonView, "[PipeConnectionPuzzleUI] No hay puzzles para {0}x{1} ", (RpcTarget)0, array);
	}

	private void GPFOLIHAMJA(int JJPJHIHBOIB)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("autoRunP2" + JJPJHIHBOIB));
		}
		LHNPKMFPLBF[JJPJHIHBOIB] = false;
	}

	private void FFLLCOBFIPE()
	{
		instance = this;
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	private void PCNNLJHJLDF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}

	private void HNNIGFFFFII(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMineMessage>(OINICMNOLPK);
	}
}
