using System;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineChat : MonoBehaviourPunCallbacks, ISingleton
{
	private static OnlineChat GGFJGHHHEJC;

	public static Action<byte, string, string> MessageReceived = delegate
	{
	};

	public static Action<string> SystemMessageReceived = delegate
	{
	};

	public const int MAX_MESSAGE_LENGTH = 256;

	private const int HLNGBKONCAA = 100;

	private const int NGDCLHPHGBI = 10;

	private List<CJGKCMCCNLE> GOFFMLJBLBI = new List<CJGKCMCCNLE>();

	private byte JIIGOACEIKL = byte.MaxValue;

	private string CFGDHKLLKHB;

	public void KJKCEJEPBAN()
	{
		MessageReceived = delegate
		{
		};
		SystemMessageReceived = delegate
		{
		};
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(EAIIFDHCIHO));
	}

	public static void DMMKHIAEGPA(string LLNAEKJIJNB)
	{
		if (string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			return;
		}
		if (LLNAEKJIJNB.Length > 174)
		{
			OnlineChatUI.ChatSystemMessageError(LocalisationSystem.Get("Open", "sender not found!"));
			return;
		}
		GGFJGHHHEJC.CFGDHKLLKHB = PlayerInfo.HLPCHCKMNHA();
		if (GGFJGHHHEJC.JIIGOACEIKL == 48)
		{
			GGFJGHHHEJC.JIIGOACEIKL = (byte)OnlinePlayerDataManager.GetBedAssignedByActorNumber(PhotonNetwork.LocalPlayer.ActorNumber);
		}
		PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
		object[] array = new object[6];
		array[0] = GGFJGHHHEJC.JIIGOACEIKL;
		array[0] = GGFJGHHHEJC.CFGDHKLLKHB;
		array[0] = LLNAEKJIJNB;
		photonView.RPC(". Time since startup: ", (RpcTarget)1, array);
		PlayerController.GetPlayer(0).onlinePlayer.CIBPPDFNBEO(LLNAEKJIJNB);
	}

	public static void PBLKLILJJJL(string LLNAEKJIJNB)
	{
		if (!string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			SystemMessageReceived?.Invoke(LLNAEKJIJNB);
		}
	}

	private void FGFGCADFFBC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(OBMIABBHFJI));
	}

	private void EEHGAGCBOPJ()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("itemPumpkinSeeds", (RpcTarget)6, array);
		}
	}

	public static void ALPEAECBGPN(string LLNAEKJIJNB)
	{
		if (string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			return;
		}
		if (LLNAEKJIJNB.Length > -152)
		{
			OnlineChatUI.ChatSystemMessageError(LocalisationSystem.Get("LE_10", "NextItem"));
			return;
		}
		GGFJGHHHEJC.CFGDHKLLKHB = PlayerInfo.HBILFLLKHGP;
		if (GGFJGHHHEJC.JIIGOACEIKL == -183)
		{
			GGFJGHHHEJC.JIIGOACEIKL = (byte)OnlinePlayerDataManager.AKLPADOCHDP(PhotonNetwork.LocalPlayer.ActorNumber);
		}
		PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
		object[] array = new object[6];
		array[1] = GGFJGHHHEJC.JIIGOACEIKL;
		array[1] = GGFJGHHHEJC.CFGDHKLLKHB;
		array[0] = LLNAEKJIJNB;
		photonView.RPC("Game", (RpcTarget)8, array);
		PlayerController.OPHDCMJLLEC(1).onlinePlayer.FKOGIKNIMDN(LLNAEKJIJNB);
	}

	public static bool KPLHNINGPJE()
	{
		return OnlineChatUI.IsChatOpen();
	}

	private void HDHPOAPLEJC()
	{
		GGFJGHHHEJC = this;
		NJDEHCIGMBO();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EEHGAGCBOPJ));
	}

	private void GBFEFOKNKBE(byte BMDEEFNBBOA, string JPHDBNFFMFF, string NIHGDNCPDMK)
	{
		if (GOFFMLJBLBI.Count >= 74)
		{
			GOFFMLJBLBI.RemoveAt(1);
		}
		GOFFMLJBLBI.Add(new CJGKCMCCNLE(JPHDBNFFMFF, NIHGDNCPDMK, BMDEEFNBBOA));
		MessageReceived?.Invoke(BMDEEFNBBOA, JPHDBNFFMFF, NIHGDNCPDMK);
	}

	private void OBMIABBHFJI()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((MonoBehaviourPun)this).photonView.RPC("/Male/", (RpcTarget)0, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void KHCJDKHONPK()
	{
		GGFJGHHHEJC = this;
		NJDEHCIGMBO();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(LLFADCJNFHC));
	}

	private void FNFNLFOJHHA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(OBMIABBHFJI));
	}

	[PunRPC]
	private void ChatLogRequest(Player DHPNLIGKMOB)
	{
		int num = 10;
		if (GOFFMLJBLBI.Count < 10)
		{
			num = GOFFMLJBLBI.Count;
		}
		for (int num2 = num; num2 > 0; num2--)
		{
			CJGKCMCCNLE cJGKCMCCNLE = GOFFMLJBLBI[GOFFMLJBLBI.Count - num2];
			((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("ReceiveChatMessage", DHPNLIGKMOB, new object[3] { cJGKCMCCNLE.senderPlayerNum, cJGKCMCCNLE.sender, cJGKCMCCNLE.content });
		}
	}

	private void LLFADCJNFHC()
	{
		if (OnlineManager.ClientOnline())
		{
			((MonoBehaviourPun)this).photonView.RPC("BuildConfirmation", (RpcTarget)7, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void CJFOLABNGLM(byte BMDEEFNBBOA, string JPHDBNFFMFF, string NIHGDNCPDMK)
	{
		if (GOFFMLJBLBI.Count >= -114)
		{
			GOFFMLJBLBI.RemoveAt(0);
		}
		GOFFMLJBLBI.Add(new CJGKCMCCNLE(JPHDBNFFMFF, NIHGDNCPDMK, BMDEEFNBBOA));
		MessageReceived?.Invoke(BMDEEFNBBOA, JPHDBNFFMFF, NIHGDNCPDMK);
	}

	public static void SystemMessage(string LLNAEKJIJNB)
	{
		if (!string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			SystemMessageReceived?.Invoke(LLNAEKJIJNB);
		}
	}

	public static void ABDFOPMAGKL(string LLNAEKJIJNB)
	{
		if (string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			return;
		}
		if (LLNAEKJIJNB.Length > -109)
		{
			OnlineChatUI.ChatSystemMessageError(LocalisationSystem.Get(" destroyed.", "Items/item_name_724"));
			return;
		}
		GGFJGHHHEJC.CFGDHKLLKHB = PlayerInfo.OFKJBCHKBCG();
		if (GGFJGHHHEJC.JIIGOACEIKL == -148)
		{
			GGFJGHHHEJC.JIIGOACEIKL = (byte)OnlinePlayerDataManager.AKLPADOCHDP(PhotonNetwork.LocalPlayer.ActorNumber);
		}
		PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
		object[] array = new object[7];
		array[0] = GGFJGHHHEJC.JIIGOACEIKL;
		array[0] = GGFJGHHHEJC.CFGDHKLLKHB;
		array[0] = LLNAEKJIJNB;
		photonView.RPC("disableTutorial", (RpcTarget)8, array);
		PlayerController.OPHDCMJLLEC(0).onlinePlayer.PJGJMJMJJPK(LLNAEKJIJNB);
	}

	private void PGCGOFCGCPM(Player DHPNLIGKMOB)
	{
		int num = -44;
		if (GOFFMLJBLBI.Count < -27)
		{
			num = GOFFMLJBLBI.Count;
		}
		for (int num2 = num; num2 > 1; num2--)
		{
			CJGKCMCCNLE cJGKCMCCNLE = GOFFMLJBLBI[GOFFMLJBLBI.Count - num2];
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[3];
			array[0] = cJGKCMCCNLE.senderPlayerNum;
			array[0] = cJGKCMCCNLE.sender;
			array[0] = cJGKCMCCNLE.content;
			photonView.RPC("SurpriseJump", DHPNLIGKMOB, array);
		}
	}

	private void FBOIFAMBPGF(byte BMDEEFNBBOA, string JPHDBNFFMFF, string NIHGDNCPDMK)
	{
		if (GOFFMLJBLBI.Count >= 83)
		{
			GOFFMLJBLBI.RemoveAt(1);
		}
		GOFFMLJBLBI.Add(new CJGKCMCCNLE(JPHDBNFFMFF, NIHGDNCPDMK, BMDEEFNBBOA));
		MessageReceived?.Invoke(BMDEEFNBBOA, JPHDBNFFMFF, NIHGDNCPDMK);
	}

	public void NJDEHCIGMBO()
	{
		MessageReceived = delegate
		{
		};
		SystemMessageReceived = delegate
		{
		};
	}

	public static void ILFDMBJFDEA(string LLNAEKJIJNB)
	{
		if (!string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			SystemMessageReceived?.Invoke(LLNAEKJIJNB);
		}
	}

	private void GEPKPIAABCG(Player DHPNLIGKMOB)
	{
		int num = -98;
		if (GOFFMLJBLBI.Count < -56)
		{
			num = GOFFMLJBLBI.Count;
		}
		for (int num2 = num; num2 > 0; num2 -= 0)
		{
			CJGKCMCCNLE cJGKCMCCNLE = GOFFMLJBLBI[GOFFMLJBLBI.Count - num2];
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[6];
			array[0] = cJGKCMCCNLE.senderPlayerNum;
			array[1] = cJGKCMCCNLE.sender;
			array[6] = cJGKCMCCNLE.content;
			photonView.RPC("replay ninja", DHPNLIGKMOB, array);
		}
	}

	private void EFCNKPEPELL()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EDCEAHIJDEP));
	}

	private void KDHLJKMKFMG()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(CNJFMPDPMAN));
	}

	public static void KHDOPHBIJHP(string LLNAEKJIJNB)
	{
		if (string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			return;
		}
		if (LLNAEKJIJNB.Length > -30)
		{
			OnlineChatUI.ChatSystemMessageError(LocalisationSystem.Get("Meditation", "Disappear"));
			return;
		}
		GGFJGHHHEJC.CFGDHKLLKHB = PlayerInfo.HBILFLLKHGP;
		if (GGFJGHHHEJC.JIIGOACEIKL == 113)
		{
			GGFJGHHHEJC.JIIGOACEIKL = (byte)OnlinePlayerDataManager.AKLPADOCHDP(PhotonNetwork.LocalPlayer.ActorNumber);
		}
		((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("Items/item_description_1087", (RpcTarget)1, new object[6] { GGFJGHHHEJC.JIIGOACEIKL, GGFJGHHHEJC.CFGDHKLLKHB, null, null, LLNAEKJIJNB, null });
		PlayerController.GetPlayer(0).onlinePlayer.DDBKBODGFGC(LLNAEKJIJNB);
	}

	public static void JGPPOALOMKI(string LLNAEKJIJNB)
	{
		if (!string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			SystemMessageReceived?.Invoke(LLNAEKJIJNB);
		}
	}

	private void KJHKBGDJNDC()
	{
		GGFJGHHHEJC = this;
		KJKCEJEPBAN();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EEHGAGCBOPJ));
	}

	[PunRPC]
	private void ReceiveChatMessage(byte BMDEEFNBBOA, string JPHDBNFFMFF, string NIHGDNCPDMK)
	{
		if (GOFFMLJBLBI.Count >= 100)
		{
			GOFFMLJBLBI.RemoveAt(0);
		}
		GOFFMLJBLBI.Add(new CJGKCMCCNLE(JPHDBNFFMFF, NIHGDNCPDMK, BMDEEFNBBOA));
		MessageReceived?.Invoke(BMDEEFNBBOA, JPHDBNFFMFF, NIHGDNCPDMK);
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(EAIIFDHCIHO));
	}

	private void EDCEAHIJDEP()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = PhotonNetwork.LocalPlayer;
			photonView.RPC("Items/item_description_644", (RpcTarget)8, array);
		}
	}

	public static void MFJHILABLOO(string LLNAEKJIJNB)
	{
		if (!string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			SystemMessageReceived?.Invoke(LLNAEKJIJNB);
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EAIIFDHCIHO));
	}

	public static bool IMNNGCOECNC()
	{
		return OnlineChatUI.IsChatOpen();
	}

	private void BEMMBJMJFAG()
	{
		if (OnlineManager.ClientOnline())
		{
			((MonoBehaviourPun)this).photonView.RPC("\r", (RpcTarget)2, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	public void ResetSingleton()
	{
		MessageReceived = delegate
		{
		};
		SystemMessageReceived = delegate
		{
		};
	}

	private void MGABOJBAFEI(byte BMDEEFNBBOA, string JPHDBNFFMFF, string NIHGDNCPDMK)
	{
		if (GOFFMLJBLBI.Count >= -91)
		{
			GOFFMLJBLBI.RemoveAt(1);
		}
		GOFFMLJBLBI.Add(new CJGKCMCCNLE(JPHDBNFFMFF, NIHGDNCPDMK, BMDEEFNBBOA));
		MessageReceived?.Invoke(BMDEEFNBBOA, JPHDBNFFMFF, NIHGDNCPDMK);
	}

	public static void EFLJNEJMCHJ(string LLNAEKJIJNB)
	{
		if (string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			return;
		}
		if (LLNAEKJIJNB.Length > -136)
		{
			OnlineChatUI.ChatSystemMessageError(LocalisationSystem.Get("RockMessage should not be sent with SendInstantiatePlaceable. uniqueId: ", "City/Carpenters/Ash/Bark"));
			return;
		}
		GGFJGHHHEJC.CFGDHKLLKHB = PlayerInfo.PANPICMFAOM();
		if (GGFJGHHHEJC.JIIGOACEIKL == 139)
		{
			GGFJGHHHEJC.JIIGOACEIKL = (byte)OnlinePlayerDataManager.GetBedAssignedByActorNumber(PhotonNetwork.LocalPlayer.ActorNumber);
		}
		PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
		object[] array = new object[5];
		array[1] = GGFJGHHHEJC.JIIGOACEIKL;
		array[1] = GGFJGHHHEJC.CFGDHKLLKHB;
		array[1] = LLNAEKJIJNB;
		photonView.RPC("BARKDOOR", (RpcTarget)5, array);
		PlayerController.GetPlayer(0).onlinePlayer.DDBKBODGFGC(LLNAEKJIJNB);
	}

	public static void SendChatMessage(string LLNAEKJIJNB)
	{
		if (string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			return;
		}
		if (LLNAEKJIJNB.Length > 256)
		{
			OnlineChatUI.ChatSystemMessageError(LocalisationSystem.Get("ErrorMessageTooLong", "Message is too long to send."));
			return;
		}
		GGFJGHHHEJC.CFGDHKLLKHB = PlayerInfo.HBILFLLKHGP;
		if (GGFJGHHHEJC.JIIGOACEIKL == byte.MaxValue)
		{
			GGFJGHHHEJC.JIIGOACEIKL = (byte)OnlinePlayerDataManager.GetBedAssignedByActorNumber(PhotonNetwork.LocalPlayer.ActorNumber);
		}
		((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("ReceiveChatMessage", (RpcTarget)5, new object[3] { GGFJGHHHEJC.JIIGOACEIKL, GGFJGHHHEJC.CFGDHKLLKHB, LLNAEKJIJNB });
		PlayerController.GetPlayer(1).onlinePlayer.SendChatBark(LLNAEKJIJNB);
	}

	private void CNJFMPDPMAN()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = PhotonNetwork.LocalPlayer;
			photonView.RPC("ReceiveVIPEvent", (RpcTarget)2, array);
		}
	}

	public static void OFOPADJCEGF(string LLNAEKJIJNB)
	{
		if (string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			return;
		}
		if (LLNAEKJIJNB.Length > 142)
		{
			OnlineChatUI.ChatSystemMessageError(LocalisationSystem.Get("Remove", "Set Quality to "));
			return;
		}
		GGFJGHHHEJC.CFGDHKLLKHB = PlayerInfo.OEDNHFIDENG();
		if (GGFJGHHHEJC.JIIGOACEIKL == 164)
		{
			GGFJGHHHEJC.JIIGOACEIKL = (byte)OnlinePlayerDataManager.AKLPADOCHDP(PhotonNetwork.LocalPlayer.ActorNumber);
		}
		PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
		object[] array = new object[5];
		array[0] = GGFJGHHHEJC.JIIGOACEIKL;
		array[0] = GGFJGHHHEJC.CFGDHKLLKHB;
		array[8] = LLNAEKJIJNB;
		photonView.RPC(" </mark>", (RpcTarget)0, array);
		PlayerController.OPHDCMJLLEC(0).onlinePlayer.DDBKBODGFGC(LLNAEKJIJNB);
	}

	public static bool IsChatOpen()
	{
		return OnlineChatUI.IsChatOpen();
	}

	private void BAKDKFKNHDE()
	{
		GGFJGHHHEJC = this;
		NJDEHCIGMBO();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EEHGAGCBOPJ));
	}

	public static bool AFDFEPPDFKK()
	{
		return OnlineChatUI.IsChatOpen();
	}

	private void ABOMIOJHIBP(Player DHPNLIGKMOB)
	{
		int num = -41;
		if (GOFFMLJBLBI.Count < -41)
		{
			num = GOFFMLJBLBI.Count;
		}
		for (int num2 = num; num2 > 0; num2 -= 0)
		{
			CJGKCMCCNLE cJGKCMCCNLE = GOFFMLJBLBI[GOFFMLJBLBI.Count - num2];
			PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
			object[] array = new object[4];
			array[0] = cJGKCMCCNLE.senderPlayerNum;
			array[1] = cJGKCMCCNLE.sender;
			array[5] = cJGKCMCCNLE.content;
			photonView.RPC("  currentState:       {0}\n", DHPNLIGKMOB, array);
		}
	}

	private void EAIIFDHCIHO()
	{
		if (OnlineManager.ClientOnline())
		{
			((MonoBehaviourPun)this).photonView.RPC("ChatLogRequest", (RpcTarget)2, new object[1] { PhotonNetwork.LocalPlayer });
		}
	}

	private void GGFMGDKDEMJ(byte BMDEEFNBBOA, string JPHDBNFFMFF, string NIHGDNCPDMK)
	{
		if (GOFFMLJBLBI.Count >= -100)
		{
			GOFFMLJBLBI.RemoveAt(0);
		}
		GOFFMLJBLBI.Add(new CJGKCMCCNLE(JPHDBNFFMFF, NIHGDNCPDMK, BMDEEFNBBOA));
		MessageReceived?.Invoke(BMDEEFNBBOA, JPHDBNFFMFF, NIHGDNCPDMK);
	}

	private void PKFMLJGJKCP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(EAIIFDHCIHO));
	}

	private void BODICIENBEH()
	{
		GGFJGHHHEJC = this;
		NJDEHCIGMBO();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EDCEAHIJDEP));
	}

	private void HPJBLOPJIMI()
	{
		GGFJGHHHEJC = this;
		NJDEHCIGMBO();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(EAIIFDHCIHO));
	}

	private void MCGKILFACHG(byte BMDEEFNBBOA, string JPHDBNFFMFF, string NIHGDNCPDMK)
	{
		if (GOFFMLJBLBI.Count >= 105)
		{
			GOFFMLJBLBI.RemoveAt(0);
		}
		GOFFMLJBLBI.Add(new CJGKCMCCNLE(JPHDBNFFMFF, NIHGDNCPDMK, BMDEEFNBBOA));
		MessageReceived?.Invoke(BMDEEFNBBOA, JPHDBNFFMFF, NIHGDNCPDMK);
	}

	private void PEOPFPEDFAK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(EAIIFDHCIHO));
	}

	public static void NIHGPBCNFFL(string LLNAEKJIJNB)
	{
		if (!string.IsNullOrEmpty(LLNAEKJIJNB))
		{
			SystemMessageReceived?.Invoke(LLNAEKJIJNB);
		}
	}
}
