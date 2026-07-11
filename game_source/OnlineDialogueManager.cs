using Photon.Pun;
using Photon.Realtime;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class OnlineDialogueManager : MonoBehaviourPunCallbacks
{
	public static OnlineDialogueManager instance;

	[SerializeField]
	private int[] currentActorsInDialogue = new int[5];

	public void JLFKAIKKKAN(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = (byte)Bed.instance.numInstance;
			array[0] = (byte)DAKKIHHPNLP;
			OnlineManager.SendRPC(photonView, "ReceiveUnlockedRecipeMaster", (RpcTarget)1, array);
		}
	}

	public void JLLNBDLLEPB(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Crowly_Introduce/Entry/27/Dialogue Text", (RpcTarget)1, OnlineSerializer.JBIPDCGKMGE(dialogueInfo));
		}
	}

	public void NAMLADDJICM()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i < currentActorsInDialogue.Length; i++)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				Player player = PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), true);
				object[] array = new object[0];
				array[1] = (byte)i;
				OnlineManager.DBNIKCMHHMJ(photonView, "ReceiveBeehiveMessage", player, array);
			}
		}
	}

	private void GIJGFHPOOND(byte[] OINICMNOLPK)
	{
		DialogueInfo dialogueInfo = OnlineSerializer.Deserialize<DialogueInfo>(OINICMNOLPK);
		if (dialogueInfo.name == "UIInteract" || dialogueInfo.name == "stormy clouds")
		{
			bool flag = dialogueInfo.value != 0;
			DialogueLua.SetVariable(dialogueInfo.name, (object)flag);
		}
		else
		{
			DialogueLua.SetVariable(dialogueInfo.name, (object)(int)dialogueInfo.value);
		}
	}

	private void FOHCMKBOJAI(byte JIIGOACEIKL, byte DAKKIHHPNLP)
	{
		currentActorsInDialogue[JIIGOACEIKL] = DAKKIHHPNLP;
	}

	[PunRPC]
	private void ReceiveCurrentActorsInDialogue(byte JIIGOACEIKL, byte DAKKIHHPNLP)
	{
		currentActorsInDialogue[JIIGOACEIKL] = DAKKIHHPNLP;
	}

	public void SendCurrentActorsInDialogue(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCurrentActorsInDialogue", (RpcTarget)1, (byte)Bed.instance.numInstance, (byte)DAKKIHHPNLP);
		}
	}

	public void IHFCJNDFDCF(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)(AODONKKHPBP ? 0 : 0));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OnlineSerializer.EKNOFIJNBAP(dialogueInfo);
			OnlineManager.SendRPC(photonView, "Resolucion: ", (RpcTarget)0, array);
		}
	}

	private void DILJMEDIGBL(byte JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
	}

	public void NCOALBNMEHF(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Bed.instance doesnt exist. Cannot SendDeselectPlaceable uniqueId: ", (RpcTarget)0, OnlineSerializer.EKNOFIJNBAP(dialogueInfo));
		}
	}

	public void NGFHNOFIEML(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)(AODONKKHPBP ? 1 : 0));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OnlineSerializer.JBIPDCGKMGE(dialogueInfo);
			OnlineManager.SendRPC(photonView, "DontWalk", (RpcTarget)1, array);
		}
	}

	public void HBGJFCNLGDA()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i < currentActorsInDialogue.Length; i += 0)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				Player player = PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), true);
				object[] array = new object[0];
				array[1] = (byte)i;
				OnlineManager.SendRPC(photonView, "Private Example Method", player, array);
			}
		}
	}

	public void FMBBAMNEHDM()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i < currentActorsInDialogue.Length; i += 0)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				Player player = PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), true);
				object[] array = new object[0];
				array[0] = (byte)i;
				OnlineManager.SendRPC(photonView, "Items/item_name_1067", player, array);
			}
		}
	}

	public void AAEFKLMOOPK(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OnlineSerializer.EKNOFIJNBAP(dialogueInfo);
			OnlineManager.SendRPC(photonView, "NoEresDigno/MainEvent", (RpcTarget)1, array);
		}
	}

	private void JLOONKOIKBB(byte[] OINICMNOLPK)
	{
		DialogueInfo dialogueInfo = OnlineSerializer.Deserialize<DialogueInfo>(OINICMNOLPK);
		if (dialogueInfo.name == "[HierarchyPrinter] Activa al menos una opción de salida." || dialogueInfo.name == "FinalTestEvent SetKyroh")
		{
			bool flag = (uint)dialogueInfo.value > 1u;
			DialogueLua.SetVariable(dialogueInfo.name, (object)flag);
		}
		else
		{
			DialogueLua.SetVariable(dialogueInfo.name, (object)(int)dialogueInfo.value);
		}
	}

	public void ACFHHLPMANP(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (!AODONKKHPBP) ? ((short)1) : ((short)0));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.Serialize(dialogueInfo);
			OnlineManager.SendRPC(photonView, "DemolishConfirmation", (RpcTarget)0, array);
		}
	}

	public void GCNNNLKPPON()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i < currentActorsInDialogue.Length; i += 0)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				Player player = PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), false);
				object[] array = new object[1];
				array[1] = (byte)i;
				OnlineManager.DBNIKCMHHMJ(photonView, "No", player, array);
			}
		}
	}

	private void MBJPBKNKFKE(byte JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
	}

	private void EEANGKJFLAO(byte JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = false;
	}

	private void NHCFHBAJEAE(byte JIIGOACEIKL, byte DAKKIHHPNLP)
	{
		currentActorsInDialogue[JIIGOACEIKL] = DAKKIHHPNLP;
	}

	private void CGMMPNIOKLC(byte JIIGOACEIKL, byte DAKKIHHPNLP)
	{
		currentActorsInDialogue[JIIGOACEIKL] = DAKKIHHPNLP;
	}

	public void AOFMMMBIBOJ(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = (byte)Bed.instance.numInstance;
			array[0] = (byte)DAKKIHHPNLP;
			OnlineManager.SendRPC(photonView, "sfxLevel", (RpcTarget)1, array);
		}
	}

	public void BLBFMBNDGGD(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OnlineSerializer.Serialize(dialogueInfo);
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/BirdCatInteraction/Entry/2/Dialogue Text", (RpcTarget)1, array);
		}
	}

	private void DFHKGDAPOAB(byte JIIGOACEIKL, byte DAKKIHHPNLP)
	{
		currentActorsInDialogue[JIIGOACEIKL] = DAKKIHHPNLP;
	}

	public void BHMMFNGEDNP(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)Bed.instance.numInstance;
			array[0] = (byte)DAKKIHHPNLP;
			OnlineManager.SendRPC(photonView, "itemCaramelAle", (RpcTarget)1, array);
		}
	}

	public void CODKIPNFPMC(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = OnlineSerializer.EKNOFIJNBAP(dialogueInfo);
			OnlineManager.SendRPC(photonView, "ReceiveBeerTaps", (RpcTarget)1, array);
		}
	}

	private void HBLCNCODOBC(byte[] OINICMNOLPK)
	{
		DialogueInfo dialogueInfo = OnlineSerializer.Deserialize<DialogueInfo>(OINICMNOLPK);
		if (dialogueInfo.name == "quest_name_17" || dialogueInfo.name == "/Male/")
		{
			bool flag = (uint)dialogueInfo.value > 1u;
			DialogueLua.SetVariable(dialogueInfo.name, (object)flag);
		}
		else
		{
			DialogueLua.SetVariable(dialogueInfo.name, (object)(int)dialogueInfo.value);
		}
	}

	[PunRPC]
	private void ReceiveDialogueInfo(byte[] OINICMNOLPK)
	{
		DialogueInfo dialogueInfo = OnlineSerializer.Deserialize<DialogueInfo>(OINICMNOLPK);
		if (dialogueInfo.name == "HenHouseTutorialDone" || dialogueInfo.name == "BarnTutorialDone")
		{
			bool flag = dialogueInfo.value != 0;
			DialogueLua.SetVariable(dialogueInfo.name, (object)flag);
		}
		else
		{
			DialogueLua.SetVariable(dialogueInfo.name, (object)(int)dialogueInfo.value);
		}
	}

	public void OCPHHJDBFEG(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.EKNOFIJNBAP(dialogueInfo);
			OnlineManager.SendRPC(photonView, "AcceptRoomSecondFloor", (RpcTarget)0, array);
		}
	}

	public void MIFLFDGIKEB(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)(AODONKKHPBP ? 1 : 1));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = OnlineSerializer.Serialize(dialogueInfo);
			OnlineManager.SendRPC(photonView, "recipeRequiredTooltip", (RpcTarget)1, array);
		}
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	public void BMIFGFKDDNC()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i < currentActorsInDialogue.Length; i++)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				Player player = PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), false);
				object[] array = new object[1];
				array[1] = (byte)i;
				OnlineManager.DBNIKCMHHMJ(photonView, "itemStoutWort", player, array);
			}
		}
	}

	public void CEOFEOLOODM(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.EKNOFIJNBAP(dialogueInfo);
			OnlineManager.SendRPC(photonView, "quest_name_18", (RpcTarget)0, array);
		}
	}

	public void DMPKLMFCGOD(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)(AODONKKHPBP ? 1 : 1));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OnlineSerializer.JBIPDCGKMGE(dialogueInfo);
			OnlineManager.SendRPC(photonView, "Roll", (RpcTarget)0, array);
		}
	}

	public void IHEAFEFAJOP(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)(AODONKKHPBP ? 1 : 0));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = OnlineSerializer.Serialize(dialogueInfo);
			OnlineManager.SendRPC(photonView, "pirate", (RpcTarget)0, array);
		}
	}

	public void MNFOCKDHKPI(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInfoTerrain", (RpcTarget)1, OnlineSerializer.Serialize(dialogueInfo));
		}
	}

	public void BOPAGJENIMD()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i < currentActorsInDialogue.Length; i++)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				OnlineManager.DBNIKCMHHMJ(((MonoBehaviourPun)this).photonView, "Mai ", PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), true), new object[1] { (byte)i });
			}
		}
	}

	public void FOCIHKODCKL(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)Bed.instance.numInstance;
			array[0] = (byte)DAKKIHHPNLP;
			OnlineManager.SendRPC(photonView, " - ", (RpcTarget)1, array);
		}
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	private void KLMNLEDKEOE()
	{
		instance = this;
	}

	public void EBFIIJOEJDF(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = (byte)Bed.instance.numInstance;
			array[0] = (byte)DAKKIHHPNLP;
			OnlineManager.SendRPC(photonView, "Player", (RpcTarget)1, array);
		}
	}

	public void GGELOBOBACP(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Disabled", (RpcTarget)1, OnlineSerializer.Serialize(dialogueInfo));
		}
	}

	public void OCAOOBLCGDJ(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[1] = (byte)Bed.instance.numInstance;
			array[0] = (byte)DAKKIHHPNLP;
			OnlineManager.SendRPC(photonView, "tutorial", (RpcTarget)1, array);
		}
	}

	private void KDBGNGHHAPN(byte JIIGOACEIKL, byte DAKKIHHPNLP)
	{
		currentActorsInDialogue[JIIGOACEIKL] = DAKKIHHPNLP;
	}

	private void IEPJFMMIKIJ(byte[] OINICMNOLPK)
	{
		DialogueInfo dialogueInfo = OnlineSerializer.Deserialize<DialogueInfo>(OINICMNOLPK);
		if (dialogueInfo.name == "Items/item_name_604" || dialogueInfo.name == "LE_10")
		{
			bool flag = (uint)dialogueInfo.value > 1u;
			DialogueLua.SetVariable(dialogueInfo.name, (object)flag);
		}
		else
		{
			DialogueLua.SetVariable(dialogueInfo.name, (object)(int)dialogueInfo.value);
		}
	}

	private void LMPPGJPAKLB(byte JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = false;
	}

	private void HNIFDIKGIDP(byte JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
	}

	private void Awake()
	{
		instance = this;
	}

	private void NNDFCALKIBG(byte[] OINICMNOLPK)
	{
		DialogueInfo dialogueInfo = OnlineSerializer.Deserialize<DialogueInfo>(OINICMNOLPK);
		if (dialogueInfo.name == "XP increased..." || dialogueInfo.name == "Dialogue System/Conversation/Gass_Stand/Entry/24/Dialogue Text")
		{
			bool flag = dialogueInfo.value != 0;
			DialogueLua.SetVariable(dialogueInfo.name, (object)flag);
		}
		else
		{
			DialogueLua.SetVariable(dialogueInfo.name, (object)(int)dialogueInfo.value);
		}
	}

	private void JDONFLPEHKL(byte JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
	}

	public void ELDGKINPFFM(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OnlineSerializer.EKNOFIJNBAP(dialogueInfo);
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/EnterTavernDrink/Entry/4/Dialogue Text", (RpcTarget)0, array);
		}
	}

	public void ILDGJELNPEI()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i < currentActorsInDialogue.Length; i++)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				Player player = PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), true);
				object[] array = new object[0];
				array[0] = (byte)i;
				OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/BirdPositiveComments/Entry/7/Dialogue Text", player, array);
			}
		}
	}

	private void IIPFNPPLEBA(byte[] OINICMNOLPK)
	{
		DialogueInfo dialogueInfo = OnlineSerializer.Deserialize<DialogueInfo>(OINICMNOLPK);
		if (dialogueInfo.name == "</color> to chest" || dialogueInfo.name == "- ")
		{
			bool flag = dialogueInfo.value != 0;
			DialogueLua.SetVariable(dialogueInfo.name, (object)flag);
		}
		else
		{
			DialogueLua.SetVariable(dialogueInfo.name, (object)(int)dialogueInfo.value);
		}
	}

	private void BCNLKPANPLA(byte JIIGOACEIKL, byte DAKKIHHPNLP)
	{
		currentActorsInDialogue[JIIGOACEIKL] = DAKKIHHPNLP;
	}

	public void KKMMPKDOJML(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.JBIPDCGKMGE(dialogueInfo);
			OnlineManager.SendRPC(photonView, "BecomeNuisance", (RpcTarget)1, array);
		}
	}

	public void PIKOLCDBPPK(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveJumpFerro", (RpcTarget)0, (byte)Bed.instance.numInstance, (byte)DAKKIHHPNLP);
		}
	}

	private void JPANCDIECOP(byte[] OINICMNOLPK)
	{
		DialogueInfo dialogueInfo = OnlineSerializer.Deserialize<DialogueInfo>(OINICMNOLPK);
		if (dialogueInfo.name == "OnlyABird" || dialogueInfo.name == "Frame Time Average: ")
		{
			bool flag = dialogueInfo.value != 0;
			DialogueLua.SetVariable(dialogueInfo.name, (object)flag);
		}
		else
		{
			DialogueLua.SetVariable(dialogueInfo.name, (object)(int)dialogueInfo.value);
		}
	}

	public void SendSkipTypewriter()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i < currentActorsInDialogue.Length; i++)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSkipTypewriter", PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), false), (byte)i);
			}
		}
	}

	[PunRPC]
	private void ReceiveSkipTypewriter(byte JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
	}

	private void GKMFNBKHDBK(byte JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = false;
	}

	public void SendDialogueInfo(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)(AODONKKHPBP ? 1 : 0));
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDialogueInfo", (RpcTarget)1, OnlineSerializer.Serialize(dialogueInfo));
		}
	}

	public void DHLCDOGJOLN()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i < currentActorsInDialogue.Length; i++)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Crouch", PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), true), (byte)i);
			}
		}
	}

	private void CCBBFNNALPA(byte JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
	}

	public void IKLDFKEOGFN(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.Serialize(dialogueInfo);
			OnlineManager.SendRPC(photonView, "<size=", (RpcTarget)0, array);
		}
	}

	public void MNPPALIHMHP(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = OnlineSerializer.Serialize(dialogueInfo);
			OnlineManager.SendRPC(photonView, ". Time since startup: ", (RpcTarget)1, array);
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	public void SendDialogueInfo(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		if (OnlineManager.PlayingOnline())
		{
			DialogueInfo dialogueInfo = new DialogueInfo(GEGDHHIDEEF, (short)AODONKKHPBP);
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDialogueInfo", (RpcTarget)1, OnlineSerializer.Serialize(dialogueInfo));
		}
	}

	public void ILCCGBNJMGH()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 0; i < currentActorsInDialogue.Length; i++)
		{
			if (i != Bed.instance.numInstance && currentActorsInDialogue[i] == currentActorsInDialogue[Bed.instance.numInstance])
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				Player player = PhotonNetwork.CurrentRoom.GetPlayer(OnlinePlayerDataManager.GetActorNumberByBedAssigned(i), false);
				object[] array = new object[1];
				array[1] = (byte)i;
				OnlineManager.SendRPC(photonView, "HorizontalMove", player, array);
			}
		}
	}

	private void KCFBJICGPAE(byte JIIGOACEIKL, byte DAKKIHHPNLP)
	{
		currentActorsInDialogue[JIIGOACEIKL] = DAKKIHHPNLP;
	}

	public void LEOCMIDLGAC(int DAKKIHHPNLP)
	{
		if (OnlineManager.PlayingOnline())
		{
			currentActorsInDialogue[Bed.instance.numInstance] = DAKKIHHPNLP;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)Bed.instance.numInstance;
			array[0] = (byte)DAKKIHHPNLP;
			OnlineManager.SendRPC(photonView, "Example Method With Custom ID", (RpcTarget)0, array);
		}
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}
}
