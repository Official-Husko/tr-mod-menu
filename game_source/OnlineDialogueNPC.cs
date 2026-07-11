using System;
using System.Collections;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class OnlineDialogueNPC : MonoBehaviourPunCallbacks
{
	public enum BarkObject
	{
		BuzzDoor
	}

	public DialogueNPCBase npc;

	public OnlineObject onlinePlaceable;

	[PunRPC]
	private void ReceiveBarkInfoLuaString(string NAIOOBEPNDO, byte BMCMHPALMPN, string PCFDMAMCBIL, string CALDOACFNFI)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		npc.Bark(NAIOOBEPNDO, PCFDMAMCBIL, CALDOACFNFI, CDPAMNIPPEC: false);
	}

	public void SendResetDialogueUIPetShop()
	{
		((MonoBehaviourPun)this).photonView.RPC("ReciveResetDialogueUPetShop", (RpcTarget)1, Array.Empty<object>());
	}

	[PunRPC]
	public void ReciveStopConversation(byte NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case 0:
			npc.StopConversation(BGKCHMNJBLJ: false);
			break;
		case 1:
			PetraNPC.GGFJGHHHEJC.StopOtherDialogues();
			break;
		case 2:
			PetraNPC.GGFJGHHHEJC.StopAllDialogues();
			break;
		case 3:
			WoodyNPC.GGFJGHHHEJC.StopOtherDialogues();
			break;
		case 4:
			WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
			break;
		case 5:
			AmosNPC.GGFJGHHHEJC.StopOtherDialogues();
			break;
		case 6:
			AmosNPC.GGFJGHHHEJC.StopAllDialogues();
			break;
		case 7:
			RhiaNPC.GGFJGHHHEJC.StopConversation();
			break;
		case 8:
			LiaNPC.GGFJGHHHEJC.StopConversation();
			break;
		case 9:
			NessyNPC.GGFJGHHHEJC.StopOtherDialogues();
			break;
		case 10:
			NessyNPC.GGFJGHHHEJC.StopAllDialogues();
			break;
		}
	}

	public void SendLookAtPlayer(int JIIGOACEIKL)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveLookAtPlayer", (RpcTarget)2, (byte)JIIGOACEIKL);
	}

	public void OnConversationLineStart(string NMMGHIJNPJG, int IKLJPLMIFDN, bool HPPJPALKJPK)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "ReceiveOnConversationLine", (RpcTarget)1, onlinePlaceable.uniqueId, NMMGHIJNPJG, (short)IKLJPLMIFDN, HPPJPALKJPK);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "OnConversationLineRPC", (RpcTarget)1, NMMGHIJNPJG, (short)IKLJPLMIFDN, HPPJPALKJPK);
		}
		if (IKLJPLMIFDN != 0)
		{
			npc.onlineBarkDialogue = false;
		}
	}

	public void NNEJJEAACGH(int[] LBCMNNKCNGJ)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)OnlineObjectsManager.instance).photonView;
			object[] array = new object[0];
			array[0] = onlinePlaceable.uniqueId;
			array[1] = LBCMNNKCNGJ;
			OnlineManager.SendRPC(photonView, "ReceiveEnable", (RpcTarget)1, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[0];
			array2[1] = LBCMNNKCNGJ;
			OnlineManager.SendRPC(photonView2, "Interact", (RpcTarget)0, array2);
		}
	}

	public void SendBarkInfo(string OLDICOEMFHI, string PCFDMAMCBIL, string CALDOACFNFI)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBarkInfoLuaString", (RpcTarget)1, OLDICOEMFHI, (byte)PluginsGameData.randomBark, PCFDMAMCBIL, CALDOACFNFI);
	}

	public void MOKOFJEIPLC(bool ODEOLADGJNE = true)
	{
		((MonoBehaviour)this).StartCoroutine(OJLPJNEBMJH(ODEOLADGJNE));
	}

	public void MKPBMJAHHCN()
	{
		((MonoBehaviourPun)this).photonView.RPC(":0", (RpcTarget)0, Array.Empty<object>());
	}

	[PunRPC]
	private void ReciveSimpleDialogueStart(bool GAGJHPKONIC)
	{
		(npc as SimpleDialogueNPC).StartBark(CDPAMNIPPEC: false, GAGJHPKONIC);
	}

	public void MJMBKNPGEIH(int FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)FCGBJEIIMBC;
		photonView.RPC("Running", (RpcTarget)7, array);
	}

	public void SendBarkInfo(string OLDICOEMFHI)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBarkInfo", (RpcTarget)1, OLDICOEMFHI, (byte)PluginsGameData.randomBark);
	}

	private IEnumerator OJLPJNEBMJH(bool ODEOLADGJNE)
	{
		yield return null;
		yield return null;
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartObserverDialogue", (RpcTarget)1, ODEOLADGJNE);
	}

	[PunRPC]
	public void ReceiveDisableContent()
	{
		npc.content.SetActive(false);
	}

	private void OLOPFIBBCFP()
	{
		NessyNPC.HFIJHDBKCIA().barkDialogue = true;
		NessyNPC.MPLODJJFKAM().SelectDialogueUI();
		MarcusNPC.DCAEBALADIM().barkDialogue = true;
		MarcusNPC.LADDMEMMJFP().SelectDialogueUI();
	}

	public void SendStartObserverDialogueNextFrame(bool ODEOLADGJNE = true)
	{
		((MonoBehaviour)this).StartCoroutine(OJLPJNEBMJH(ODEOLADGJNE));
	}

	public void SendBarkInfo(string OLDICOEMFHI, BarkObject ICJMCPNLBHJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBarkInfoWithObject", (RpcTarget)1, OLDICOEMFHI, (byte)PluginsGameData.randomBark, (byte)ICJMCPNLBHJ);
	}

	public void KLEHMFNDKPH()
	{
		((MonoBehaviourPun)this).photonView.RPC("Running", (RpcTarget)0, Array.Empty<object>());
	}

	public void FAMAKBIHDJH(bool PIHIAKCIJLM)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)OnlineObjectsManager.instance).photonView;
			object[] array = new object[5];
			array[0] = onlinePlaceable.uniqueId;
			array[0] = PIHIAKCIJLM;
			OnlineManager.SendRPC(photonView, "UI2", (RpcTarget)1, array);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBeehiveMessage", (RpcTarget)0, PIHIAKCIJLM);
		}
	}

	public void CCOCIAPOPMP(string NMMGHIJNPJG, int IKLJPLMIFDN, bool HPPJPALKJPK)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)OnlineObjectsManager.instance).photonView;
			object[] array = new object[6];
			array[1] = onlinePlaceable.uniqueId;
			array[0] = NMMGHIJNPJG;
			array[2] = (short)IKLJPLMIFDN;
			array[5] = HPPJPALKJPK;
			OnlineManager.SendRPC(photonView, "ReceiveTalentFromOther", (RpcTarget)1, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[6];
			array2[0] = NMMGHIJNPJG;
			array2[1] = (short)IKLJPLMIFDN;
			array2[7] = HPPJPALKJPK;
			OnlineManager.SendRPC(photonView2, "Items/item_description_609", (RpcTarget)1, array2);
		}
		if (IKLJPLMIFDN != 0)
		{
			npc.onlineBarkDialogue = true;
		}
	}

	public void GAPAENFPLKE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ThemeTriggerSection", (RpcTarget)0);
	}

	public void SendResetDialogueUIBlacksmith()
	{
		((MonoBehaviourPun)this).photonView.RPC("ReciveResetDialogueUIBlacksmith", (RpcTarget)1, Array.Empty<object>());
	}

	public void FEHIOCLHMLO(int[] JCLMJGDIFCI)
	{
		Response[] array = (Response[])(object)new Response[JCLMJGDIFCI.Length];
		npc.inResponse = true;
		npc.responsesId = JCLMJGDIFCI;
		for (int i = 1; i < JCLMJGDIFCI.Length; i += 0)
		{
			array[i] = npc.GetResponseFromDatabase(JCLMJGDIFCI[i]);
		}
		if (npc.inUse && (Object)(object)npc.dialogueUiInUse != (Object)null && !npc.main)
		{
			((AbstractDialogueUI)npc.dialogueUiInUse).HideResponses();
			((AbstractDialogueUI)npc.dialogueUiInUse).ShowResponses(npc.GetSubtitleFromDatabase(npc.conversationTitle, npc.entryId), array, 333f);
		}
	}

	public void IIBEOLFDLGE(byte FCGBJEIIMBC)
	{
		npc.animationBase.LookDirection((Direction)FCGBJEIIMBC);
	}

	[PunRPC]
	private void ReceiveBarkInfoLuaInt(string NAIOOBEPNDO, byte BMCMHPALMPN, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		npc.Bark(NAIOOBEPNDO, PCFDMAMCBIL, CALDOACFNFI, CDPAMNIPPEC: false);
	}

	public void SendStopConversation(int NCMDEGABGCH = 0)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "ReciveStopConversationOnlineObjects", (RpcTarget)1, onlinePlaceable.uniqueId, (byte)NCMDEGABGCH);
		}
		else
		{
			((MonoBehaviourPun)this).photonView.RPC("ReciveStopConversation", (RpcTarget)1, new object[1] { (byte)NCMDEGABGCH });
		}
	}

	[PunRPC]
	private void ReceiveBarkBuzzDoorInfoLuaInt(string NAIOOBEPNDO, byte BMCMHPALMPN, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		npc.BarkBuzzDoor(NAIOOBEPNDO, PCFDMAMCBIL, CALDOACFNFI, ((Component)BuzzNPC.GGFJGHHHEJC.door).transform, CDPAMNIPPEC: false);
	}

	[PunRPC]
	private void ReceiveStartObserverDialogue(bool ODEOLADGJNE)
	{
		if (ODEOLADGJNE)
		{
			DialogueManager.StopAllConversations();
		}
		npc.StartObserverDialogue(1, MCJHGHLBBGL: true);
	}

	[PunRPC]
	public void ReceiveLookAtDirection(byte FCGBJEIIMBC)
	{
		npc.animationBase.LookDirection((Direction)FCGBJEIIMBC);
	}

	private void ICLDKBCHCLJ(bool GAGJHPKONIC)
	{
		(npc as SimpleDialogueNPC).HMEKFPHDAML(CDPAMNIPPEC: true, GAGJHPKONIC);
	}

	[PunRPC]
	public void ReceiveLookAtPlayer(byte JIIGOACEIKL)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		npc.animationBase.LookAt(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlineBedroomsManager.instance.GetPlayerBed(JIIGOACEIKL))).transform.position));
	}

	private void OnDestroy()
	{
		if (OnlineManager.PlayingOnline())
		{
			_ = (Object)(object)npc == (Object)null;
		}
	}

	public void SendBarkBuzzDoorInfo(string OLDICOEMFHI, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBarkBuzzDoorInfoLuaInt", (RpcTarget)1, OLDICOEMFHI, (byte)PluginsGameData.randomBark, PCFDMAMCBIL, CALDOACFNFI);
	}

	public void FOBINBCMLDK(string OLDICOEMFHI, BarkObject ICJMCPNLBHJ, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OLDICOEMFHI;
		array[0] = (byte)PluginsGameData.randomBark;
		array[3] = (byte)ICJMCPNLBHJ;
		array[4] = PCFDMAMCBIL;
		array[8] = CALDOACFNFI;
		OnlineManager.SendRPC(photonView, "ReceiveSetUniqueCropDay", (RpcTarget)1, array);
	}

	[PunRPC]
	public void DialogueEndRPC(bool PIHIAKCIJLM)
	{
		npc.inInteractiveDialogue = false;
		npc.playerShopping = PIHIAKCIJLM;
		npc.EnableDialogue();
	}

	public void SendDisableContent()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDisableContent", (RpcTarget)1);
	}

	public void MONNBBOPHLN(bool ODEOLADGJNE = true)
	{
		((MonoBehaviour)this).StartCoroutine(OJLPJNEBMJH(ODEOLADGJNE));
	}

	public void GCDNIGNNIGP(int FCGBJEIIMBC)
	{
		((MonoBehaviourPun)this).photonView.RPC("Room missing required items", (RpcTarget)8, new object[1] { (byte)FCGBJEIIMBC });
	}

	public void MJGGHFOONDJ(string OLDICOEMFHI, BarkObject ICJMCPNLBHJ, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OLDICOEMFHI;
		array[0] = (byte)PluginsGameData.randomBark;
		array[2] = (byte)ICJMCPNLBHJ;
		array[5] = PCFDMAMCBIL;
		array[3] = CALDOACFNFI;
		OnlineManager.SendRPC(photonView, "Could not find shop with shopType: ", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveResetBombVariable()
	{
		CommonReferences.GGFJGHHHEJC.eventNum[5] = 0;
	}

	public void CCBENPEMMLF(int FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)FCGBJEIIMBC;
		photonView.RPC("ChristmasPresentsError", (RpcTarget)8, array);
	}

	public void KGBNAPOEOOM(string NMMGHIJNPJG, int IKLJPLMIFDN, bool HPPJPALKJPK)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)OnlineObjectsManager.instance).photonView;
			object[] array = new object[2];
			array[0] = onlinePlaceable.uniqueId;
			array[0] = NMMGHIJNPJG;
			array[2] = (short)IKLJPLMIFDN;
			array[5] = HPPJPALKJPK;
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/NeutralInTavern/Entry/13/Dialogue Text", (RpcTarget)0, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[2];
			array2[1] = NMMGHIJNPJG;
			array2[1] = (short)IKLJPLMIFDN;
			array2[4] = HPPJPALKJPK;
			OnlineManager.SendRPC(photonView2, "Player/Bark/Tutorial/CantDoYet", (RpcTarget)0, array2);
		}
		if (IKLJPLMIFDN != 0)
		{
			npc.onlineBarkDialogue = false;
		}
	}

	public void PJCCHNFDANF(string PFNFAPCMEPI)
	{
		npc.TriggerAnimation(PFNFAPCMEPI);
	}

	public void OJOHDIEEPGN(string OLDICOEMFHI, string PCFDMAMCBIL, string CALDOACFNFI)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = OLDICOEMFHI;
		array[0] = (byte)PluginsGameData.randomBark;
		array[5] = PCFDMAMCBIL;
		array[2] = CALDOACFNFI;
		OnlineManager.SendRPC(photonView, "UpgradeConfirmation", (RpcTarget)1, array);
	}

	[PunRPC]
	public void OnConversationResponseMenuRPC(int[] JCLMJGDIFCI)
	{
		Response[] array = (Response[])(object)new Response[JCLMJGDIFCI.Length];
		npc.inResponse = true;
		npc.responsesId = JCLMJGDIFCI;
		for (int i = 0; i < JCLMJGDIFCI.Length; i++)
		{
			array[i] = npc.GetResponseFromDatabase(JCLMJGDIFCI[i]);
		}
		if (npc.inUse && (Object)(object)npc.dialogueUiInUse != (Object)null && !npc.main)
		{
			((AbstractDialogueUI)npc.dialogueUiInUse).HideResponses();
			((AbstractDialogueUI)npc.dialogueUiInUse).ShowResponses(npc.GetSubtitleFromDatabase(npc.conversationTitle, npc.entryId), array, 0f);
		}
	}

	public void GCBLMDBJBPI(bool PIHIAKCIJLM)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "Cancel Crafting", (RpcTarget)0, onlinePlaceable.uniqueId, PIHIAKCIJLM, null, null);
		}
		else
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = PIHIAKCIJLM;
			OnlineManager.SendRPC(photonView, "Error_MaxZoneSize", (RpcTarget)0, array);
		}
	}

	public void JAKEPOALIOH(string OLDICOEMFHI, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = OLDICOEMFHI;
		array[0] = (byte)PluginsGameData.randomBark;
		array[5] = PCFDMAMCBIL;
		array[5] = CALDOACFNFI;
		OnlineManager.SendRPC(photonView, "LE_11", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveBarkInfo(string NAIOOBEPNDO, byte BMCMHPALMPN)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		npc.Bark(NAIOOBEPNDO, CDPAMNIPPEC: false);
	}

	[PunRPC]
	private void ReceiveEnableNewActivityBubble(bool OEDBPACCOGH)
	{
		npc.CheckIfNewActivity(OEDBPACCOGH, CDPAMNIPPEC: false);
	}

	[PunRPC]
	public void ReciveInUse(bool DJGKNDPGIGB)
	{
		npc.inUse = DJGKNDPGIGB;
	}

	private void Start()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponentInChildren<DialogueNPCBase>();
		}
		if (OnlineManager.PlayingOnline())
		{
			npc.onlineDialogue = this;
		}
	}

	public void OnDialogueEnd(bool PIHIAKCIJLM)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "ReceiveDialogueEnd", (RpcTarget)1, onlinePlaceable.uniqueId, PIHIAKCIJLM);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DialogueEndRPC", (RpcTarget)1, PIHIAKCIJLM);
		}
	}

	public void SendLookAtDirection(int FCGBJEIIMBC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveLookAtDirection", (RpcTarget)2, (byte)FCGBJEIIMBC);
	}

	public void SendTriggerAnimation(string PFNFAPCMEPI)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTriggerAnimation", (RpcTarget)2, PFNFAPCMEPI);
	}

	public void SendResetBombVariable()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveResetBombVariable", (RpcTarget)1);
	}

	public void OnConversationResponseMenuStart(int[] LBCMNNKCNGJ)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "ReceiveOnConversationResponseMenu", (RpcTarget)1, onlinePlaceable.uniqueId, LBCMNNKCNGJ);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "OnConversationResponseMenuRPC", (RpcTarget)1, LBCMNNKCNGJ);
		}
	}

	[PunRPC]
	private void ReceiveBarkInfoWithObject(string NAIOOBEPNDO, byte BMCMHPALMPN, byte ICJMCPNLBHJ)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		if (ICJMCPNLBHJ == 0)
		{
			DialogueManager.Bark(NAIOOBEPNDO, ((Component)BuzzNPC.GGFJGHHHEJC.door).transform);
		}
	}

	public void SendSimpleDialogueStart(bool GAGJHPKONIC = true)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReciveSimpleDialogueStart", (RpcTarget)1, GAGJHPKONIC);
	}

	[PunRPC]
	private void ReciveResetDialogueUISawmill()
	{
		WoodyNPC.GGFJGHHHEJC.barkDialogue = true;
		WoodyNPC.GGFJGHHHEJC.SelectDialogueUI();
		OakNPC.GGFJGHHHEJC.barkDialogue = true;
		OakNPC.GGFJGHHHEJC.SelectDialogueUI();
		AshNPC.GGFJGHHHEJC.barkDialogue = true;
		AshNPC.GGFJGHHHEJC.SelectDialogueUI();
		WillowNPC.GGFJGHHHEJC.barkDialogue = true;
		WillowNPC.GGFJGHHHEJC.SelectDialogueUI();
	}

	public void OnDialogueStart(bool OMFIGAJAOCJ = false)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "ReceiveDialogueStart", (RpcTarget)1, onlinePlaceable.uniqueId, OMFIGAJAOCJ);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DialogueStartRPC", (RpcTarget)1, OMFIGAJAOCJ);
		}
	}

	public void ANADNGCLNHJ(string PFNFAPCMEPI)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = PFNFAPCMEPI;
		OnlineManager.SendRPC(photonView, "Idle", (RpcTarget)4, array);
	}

	[PunRPC]
	private void ReciveHollyPositionForTutorial(Vector3 AIJOOOIJEDC)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Component)HollyNPC.GGFJGHHHEJC).transform.position = AIJOOOIJEDC;
	}

	public void HGMENMPDDJN(int NCMDEGABGCH = 0)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "Dialogue System/Conversation/Gass_Quest/Entry/38/Dialogue Text", (RpcTarget)0, onlinePlaceable.uniqueId, (byte)NCMDEGABGCH);
		}
		else
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)NCMDEGABGCH;
			photonView.RPC("BanquetOrdersManager is not initialized.", (RpcTarget)1, array);
		}
	}

	public void SendHollyDirectionForTutorial(int FCGBJEIIMBC)
	{
		((MonoBehaviourPun)this).photonView.RPC("ReciveHollyDirectionForTutorial", (RpcTarget)2, new object[1] { (byte)FCGBJEIIMBC });
	}

	[PunRPC]
	private void ReciveActiveorDisableColliderHikari(byte ABAIKKGKDGD)
	{
		HikariNPC.GGFJGHHHEJC.ActiveorDisableColliderOnline(ABAIKKGKDGD);
	}

	public void FNDGFCPMGAM(int FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "OnFloor", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReciveResetDialogueUPetShop()
	{
		NessyNPC.GGFJGHHHEJC.barkDialogue = true;
		NessyNPC.GGFJGHHHEJC.SelectDialogueUI();
		MarcusNPC.GGFJGHHHEJC.barkDialogue = true;
		MarcusNPC.GGFJGHHHEJC.SelectDialogueUI();
	}

	public void SendInUse(bool DJGKNDPGIGB)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "ReciveInUseOnlineObjects", (RpcTarget)1, onlinePlaceable.uniqueId, DJGKNDPGIGB);
		}
		else
		{
			((MonoBehaviourPun)this).photonView.RPC("ReciveInUse", (RpcTarget)1, new object[1] { DJGKNDPGIGB });
		}
	}

	[PunRPC]
	private void ReciveResetDialogueULiaRhia()
	{
		LiaNPC.GGFJGHHHEJC.barkDialogue = true;
		LiaNPC.GGFJGHHHEJC.SelectDialogueUI();
		RhiaNPC.GGFJGHHHEJC.barkDialogue = true;
		RhiaNPC.GGFJGHHHEJC.SelectDialogueUI();
	}

	private void NANNJNOECBM(byte ABAIKKGKDGD)
	{
		HikariNPC.EFPJLFMBPLL().HCDCOLONBKI(ABAIKKGKDGD);
	}

	public void SendEnableNewActivityBubble(bool OEDBPACCOGH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEnableNewActivityBubble", (RpcTarget)1, OEDBPACCOGH);
	}

	public void SendHollyPositionForTutorial(Vector3 AIJOOOIJEDC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviourPun)this).photonView.RPC("ReciveHollyPositionForTutorial", (RpcTarget)2, new object[1] { AIJOOOIJEDC });
	}

	public void PCBOEBKIFAM()
	{
		((MonoBehaviourPun)this).photonView.RPC("Items/item_name_684", (RpcTarget)1, Array.Empty<object>());
	}

	private void HHDLODGHLOC()
	{
		PetraNPC.MAAAKALBBEE().barkDialogue = false;
		PetraNPC.GGFJGHHHEJC.SelectDialogueUI();
		BruceNPC.BNDMEINJPAN().barkDialogue = false;
		BruceNPC.NBKKEINELDN().SelectDialogueUI(1);
		KeenNPC.AJIGOHGPFPP().barkDialogue = true;
		KeenNPC.OOKBNHMMFON().SelectDialogueUI(1);
	}

	[PunRPC]
	private void ReciveHollyDirectionForTutorial(byte FCGBJEIIMBC)
	{
		switch (FCGBJEIIMBC)
		{
		case 0:
			HollyNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
			break;
		case 1:
			HollyNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Down;
			break;
		}
	}

	public void SendBarkInfo(string OLDICOEMFHI, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBarkInfoLuaInt", (RpcTarget)1, OLDICOEMFHI, (byte)PluginsGameData.randomBark, PCFDMAMCBIL, CALDOACFNFI);
	}

	[PunRPC]
	public void ReceiveTriggerAnimation(string PFNFAPCMEPI)
	{
		npc.TriggerAnimation(PFNFAPCMEPI);
	}

	public void SendBarkInfo(string OLDICOEMFHI, BarkObject ICJMCPNLBHJ, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBarkInfoWithObjectAndLuaInt", (RpcTarget)1, OLDICOEMFHI, (byte)PluginsGameData.randomBark, (byte)ICJMCPNLBHJ, PCFDMAMCBIL, CALDOACFNFI);
	}

	[PunRPC]
	private void ReceiveBarkInfoWithObjectAndLuaInt(string NAIOOBEPNDO, byte BMCMHPALMPN, byte ICJMCPNLBHJ, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		DialogueLua.SetVariable(PCFDMAMCBIL, (object)CALDOACFNFI);
		ReceiveBarkInfoWithObject(NAIOOBEPNDO, BMCMHPALMPN, ICJMCPNLBHJ);
	}

	private void LOODHJCCBLK(Vector3 AIJOOOIJEDC)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Component)HollyNPC.JFJOKGAOPHA()).transform.position = AIJOOOIJEDC;
	}

	public void LENIHLOHCGB(string OLDICOEMFHI, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = OLDICOEMFHI;
		array[1] = (byte)PluginsGameData.randomBark;
		array[8] = PCFDMAMCBIL;
		array[5] = CALDOACFNFI;
		OnlineManager.SendRPC(photonView, "ReceiveEmployeeTask", (RpcTarget)0, array);
	}

	public void APGJMNHJNHN()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Gass_Stand/Entry/8/Dialogue Text", (RpcTarget)0);
	}

	public void SendResetDialogueUISawmill()
	{
		((MonoBehaviourPun)this).photonView.RPC("ReciveResetDialogueUISawmill", (RpcTarget)1, Array.Empty<object>());
	}

	public void NOLNEHKPAGG()
	{
		CommonReferences.GGFJGHHHEJC.eventNum[1] = 1;
	}

	[PunRPC]
	public void OnConversationLineRPC(string NMMGHIJNPJG, short NIGNPMLFECM, bool HPPJPALKJPK)
	{
		if (npc.GetSubtitleFromDatabase(NMMGHIJNPJG, NIGNPMLFECM).dialogueEntry.ActorID != 1)
		{
			if (npc.inUse && (Object)(object)npc.dialogueUiInUse != (Object)null && !HPPJPALKJPK)
			{
				((AbstractDialogueUI)npc.dialogueUiInUse).HideSubtitle(npc.GetSubtitleFromDatabase(NMMGHIJNPJG, NIGNPMLFECM));
				((AbstractDialogueUI)npc.dialogueUiInUse).ShowSubtitle(npc.GetSubtitleFromDatabase(NMMGHIJNPJG, NIGNPMLFECM));
				Actor actor = DialogueManager.MasterDatabase.GetActor(npc.GetSubtitleFromDatabase(NMMGHIJNPJG, NIGNPMLFECM).dialogueEntry.ActorID);
				npc.dialogueUiInUse.conversationUIElements.subtitlePanels[0].portraitName.text = ((Asset)actor).Name;
				((AbstractDialogueUI)npc.dialogueUiInUse).SetActorPortraitSprite(((Asset)actor).Name, actor.GetPortraitSprite());
			}
			npc.inResponse = false;
			npc.entryId = NIGNPMLFECM;
			npc.conversationTitle = NMMGHIJNPJG;
		}
		if (HPPJPALKJPK && NIGNPMLFECM != 0)
		{
			npc.StartDialogueById();
		}
	}

	public void AHNNEFNHABD(string OLDICOEMFHI, string PCFDMAMCBIL, int CALDOACFNFI)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = OLDICOEMFHI;
		array[1] = (byte)PluginsGameData.randomBark;
		array[6] = PCFDMAMCBIL;
		array[4] = CALDOACFNFI;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
	}

	public void PJLFBMIBCNN(bool DJGKNDPGIGB)
	{
		if ((Object)(object)onlinePlaceable != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)OnlineObjectsManager.instance).photonView, "LearnBalance", (RpcTarget)0, onlinePlaceable.uniqueId, DJGKNDPGIGB, null, null, null, null, null, null);
		}
		else
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = DJGKNDPGIGB;
			photonView.RPC("PLAYERNAME ", (RpcTarget)0, array);
		}
	}

	public void SendActiveorDisableColliderHikari(int ABAIKKGKDGD)
	{
		((MonoBehaviourPun)this).photonView.RPC("ReciveActiveorDisableColliderHikari", (RpcTarget)1, new object[1] { (byte)ABAIKKGKDGD });
	}

	[PunRPC]
	private void ReciveResetDialogueUIBlacksmith()
	{
		PetraNPC.GGFJGHHHEJC.barkDialogue = true;
		PetraNPC.GGFJGHHHEJC.SelectDialogueUI();
		BruceNPC.GGFJGHHHEJC.barkDialogue = true;
		BruceNPC.GGFJGHHHEJC.SelectDialogueUI();
		KeenNPC.GGFJGHHHEJC.barkDialogue = true;
		KeenNPC.GGFJGHHHEJC.SelectDialogueUI();
	}

	public void SendResetDialogueUILiaRhia()
	{
		((MonoBehaviourPun)this).photonView.RPC("ReciveResetDialogueULiaRhia", (RpcTarget)1, Array.Empty<object>());
	}

	public void Configuration()
	{
		npc = ((Component)this).GetComponentInChildren<DialogueNPCBase>();
	}

	[PunRPC]
	public void DialogueStartRPC(bool OMFIGAJAOCJ)
	{
		npc.inInteractiveDialogue = OMFIGAJAOCJ;
		npc.DisableDialogue(CKJIHLIFPMF: true);
		npc.ConversationStarted(obj: false);
	}

	public void OMKDGMFPIEB(bool OMFIGAJAOCJ)
	{
		npc.inInteractiveDialogue = OMFIGAJAOCJ;
		npc.DisableDialogue();
		npc.ConversationStarted(obj: false);
	}
}
