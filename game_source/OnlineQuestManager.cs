using Photon.Pun;
using UnityEngine;

public class OnlineQuestManager : MonoBehaviourPunCallbacks
{
	public static OnlineQuestManager instance;

	public void BJCFHEJGIAF(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = DAEMAAOLHMG;
		OnlineManager.SendRPC(photonView, "Received finish minigame", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveAddQuestInfo(byte HJCKGNINDMA)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.AddQuest(quest, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
			QuestHighlightUI.ShowNewQuestAvailable(quest, LFBJCGLGEIN: false);
		}
	}

	public void OICHOJEOCMK(byte AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "Items/item_name_1039", (RpcTarget)1, array);
	}

	private void BELKPPPOIND(short HJCKGNINDMA, byte IALMLONEDJN)
	{
		Quest quest = QuestDatabaseAccessor.MIPBDJIJLLK(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			quest.ANFDBPFECCH(0, IALMLONEDJN);
		}
		else
		{
			Debug.LogError((object)("Player" + HJCKGNINDMA + "tilled earth" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
	}

	public void HBBEBBMEFEG(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = DAEMAAOLHMG;
		OnlineManager.SendRPC(photonView, "KyrohTakingFood: Other player has advantage, going to WaitingToServe.", (RpcTarget)1, array);
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	private void HOHHMGGPMOO(byte JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		SceneReferences.instance.interactableForms[JFNMCNCHMEO].DIGICKCCMON(DAEMAAOLHMG, CDPAMNIPPEC: true);
	}

	public void SendFormQuestInfo(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFormQuestInfo", (RpcTarget)1, (byte)JFNMCNCHMEO, DAEMAAOLHMG);
	}

	public void BJNJMJCMBJN(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = DAEMAAOLHMG;
		OnlineManager.SendRPC(photonView, "Error unlocking achievements. This is most likely because we are not signed in to Steam or GOG.", (RpcTarget)0, array);
	}

	public void EIPKPNIJMHF(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOnConversationResponseMenu", (RpcTarget)0, (byte)JFNMCNCHMEO, DAEMAAOLHMG, null, null, null, null, null, null);
	}

	private void OGBLLJPHBGO(byte HJCKGNINDMA)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GJFMMOPOKGJ().JOAHBCAAFMC(quest, 0, FFJBIGFADBJ: true);
			QuestHighlightUI.CHMAEKMIBDJ(quest, LFBJCGLGEIN: false);
		}
	}

	public void DDAOAKAGBJL(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = DAEMAAOLHMG;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
	}

	private void EHBMONGBJFI()
	{
		instance = this;
	}

	public void MPEHMCJCPPB(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ClosePopUp", (RpcTarget)1, (byte)JFNMCNCHMEO, DAEMAAOLHMG, null, null, null, null, null);
	}

	public void LHNNGOBJCLI(byte AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Trying to add player but player list is full.", (RpcTarget)1, AODONKKHPBP);
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	[PunRPC]
	private void ReceiveFormQuestInfo(byte JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		SceneReferences.instance.interactableForms[JFNMCNCHMEO].SetFormMade(DAEMAAOLHMG, CDPAMNIPPEC: false);
	}

	public void PPEIMMANMPN(byte AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "UI2", (RpcTarget)1, array);
	}

	private void NEOICNJNKNL()
	{
		instance = this;
	}

	private void FECBHCAKPAM(byte JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		SceneReferences.instance.interactableForms[JFNMCNCHMEO].SetFormMade(DAEMAAOLHMG, CDPAMNIPPEC: false);
	}

	private void GLDHGCLHJPK(byte HJCKGNINDMA)
	{
		Quest quest = QuestDatabaseAccessor.BBGBOLLAGKN(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GJFMMOPOKGJ().JOAHBCAAFMC(quest, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
			QuestHighlightUI.CHMAEKMIBDJ(quest, LFBJCGLGEIN: false);
		}
	}

	[PunRPC]
	private void ReceiveProgressQuestInfo(short HJCKGNINDMA, byte IALMLONEDJN)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			quest.ANFDBPFECCH(1, IALMLONEDJN);
		}
		else
		{
			Debug.LogError((object)("Quest not found in database with id: " + HJCKGNINDMA + " to actorNumber " + PhotonNetwork.LocalPlayer.ActorNumber));
		}
	}

	private void KAJOGMBIINN(short HJCKGNINDMA, byte IALMLONEDJN)
	{
		Quest quest = QuestDatabaseAccessor.MIPBDJIJLLK(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			quest.ANFDBPFECCH(1, IALMLONEDJN);
		}
		else
		{
			Debug.LogError((object)("NormalLeft" + HJCKGNINDMA + "LE_10" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
	}

	public void NJADMPNBGPJ(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = DAEMAAOLHMG;
		OnlineManager.SendRPC(photonView, "ReceiveCollectItemsMaster", (RpcTarget)1, array);
	}

	public void HLCJBFNDBMD(byte AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_1137", (RpcTarget)0, AODONKKHPBP);
	}

	private void LKENBACBDIJ(byte HJCKGNINDMA)
	{
		Quest quest = QuestDatabaseAccessor.JHOAPLEPKKK(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.KHMEGDIABBF().AddQuest(quest, 0, FFJBIGFADBJ: true);
			QuestHighlightUI.HBBMGMKDAIM(quest, LFBJCGLGEIN: false);
		}
	}

	private void OBIFGNGDONG(byte HJCKGNINDMA)
	{
		Quest quest = QuestDatabaseAccessor.DIBHHGJNNFH(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.OPILDPFDFKJ().JOAHBCAAFMC(quest, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
			QuestHighlightUI.NDABOMBDJFH(quest, LFBJCGLGEIN: false);
		}
	}

	private void FHOCCEBKHJI()
	{
		instance = this;
	}

	private void BKDNCPJDECC(short HJCKGNINDMA, byte IALMLONEDJN)
	{
		Quest quest = QuestDatabaseAccessor.BBGBOLLAGKN(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			quest.EMOCCNGBHII(0, IALMLONEDJN);
		}
		else
		{
			Debug.LogError((object)("ReceiveUnlockPerkLevel" + HJCKGNINDMA + "UI" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
	}

	public void BBDHBKNGLIO(int HJCKGNINDMA, int IALMLONEDJN)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "add item ", (RpcTarget)1, (short)HJCKGNINDMA, (byte)IALMLONEDJN);
	}

	public void OGMMKMOIENB(byte AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "Miners/Mine/Ferro/Bomb", (RpcTarget)0, array);
	}

	private void KPMPPNMBOCO(byte JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		SceneReferences.instance.interactableForms[JFNMCNCHMEO].JIADLKOLEEP(DAEMAAOLHMG, CDPAMNIPPEC: false);
	}

	public void SendProgressQuestInfo(int HJCKGNINDMA, int IALMLONEDJN)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveProgressQuestInfo", (RpcTarget)1, (short)HJCKGNINDMA, (byte)IALMLONEDJN);
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	public void DHDKFDOBPML(int HJCKGNINDMA, int IALMLONEDJN)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (short)HJCKGNINDMA;
		array[0] = (byte)IALMLONEDJN;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)0, array);
	}

	public void SendAddQuestInfo(byte AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddQuestInfo", (RpcTarget)1, AODONKKHPBP);
	}

	public void NNGLDINHGLM(int JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = DAEMAAOLHMG;
		OnlineManager.SendRPC(photonView, "d2", (RpcTarget)0, array);
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	public void LCLCFFIPBLJ(byte AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "Occupied Positions", (RpcTarget)1, array);
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	private void Awake()
	{
		instance = this;
	}

	public void DEDAOIDFCOC(int HJCKGNINDMA, int IALMLONEDJN)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Beta ", (RpcTarget)1, (short)HJCKGNINDMA, (byte)IALMLONEDJN, null, null, null, null, null, null);
	}

	private void MKNHIIPOHCF(short HJCKGNINDMA, byte IALMLONEDJN)
	{
		Quest quest = QuestDatabaseAccessor.HHKKPIHIEJL(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			quest.GPGEIBPIIKC(0, IALMLONEDJN);
		}
		else
		{
			Debug.LogError((object)("tutorialPopUp80" + HJCKGNINDMA + "pirate" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
	}

	public void NCAMIJJMDBH(byte AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "SendHome", (RpcTarget)0, array);
	}

	private void CMFHJOBEKHO(byte JFNMCNCHMEO, bool DAEMAAOLHMG)
	{
		SceneReferences.instance.interactableForms[JFNMCNCHMEO].BDAJHOCGPAN(DAEMAAOLHMG, CDPAMNIPPEC: true);
	}

	private void KLOPFBECGLG(short HJCKGNINDMA, byte IALMLONEDJN)
	{
		Quest quest = QuestDatabaseAccessor.DJMDLPHMPEL(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest))
		{
			quest.PHNONHAOPMF(1, IALMLONEDJN);
		}
		else
		{
			Debug.LogError((object)("IntroFerroCoroutine started" + HJCKGNINDMA + "OnFaceActivationRPC" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
	}
}
