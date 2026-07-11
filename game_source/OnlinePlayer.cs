using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlinePlayer : OnlineBaseCharacter, IPunInstantiateMagicCallback
{
	public static Action<Player, int> OnlinePlayerInitialized = delegate
	{
	};

	public static Action<PhotonView> OnlinePlayerSpawned = delegate
	{
	};

	public static Action<Player> OnlinePlayerDestroyed = delegate
	{
	};

	public static Action<int, string> OnlinePlayerNameChanged = delegate
	{
	};

	public static Action<int, Gender> OnlinePlayerGenderChanged = delegate
	{
	};

	public static Action<int, string, PlatformOS> OnlinePlayerPlatformID = delegate
	{
	};

	public PhotonTransformView transformView;

	private PlayerController JOOBIKDBBKE;

	private HumanInfo DKDFNAGAFNL;

	public SpriteRenderer playerArrow;

	public void IOKEGONNDLB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "cliffs", (RpcTarget)0);
	}

	[PunRPC]
	private void ReceiveStartTeleport(float NCPGNLOJGAF, float JLMAILGJNCE)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		((Behaviour)transformView).enabled = false;
		((Component)JOOBIKDBBKE).transform.position = new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 0f);
	}

	private void IBLBOLNBODC(Location BAIMHDBJPDK)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (int)BAIMHDBJPDK;
			OnlineManager.SendRPC(photonView, "Items/item_description_1083", (RpcTarget)0, array);
		}
	}

	private void JDNGDHDJGGI(int BAIMHDBJPDK)
	{
		JOOBIKDBBKE.SetOnlineLocation((Location)BAIMHDBJPDK);
	}

	protected void MECGNLDLBGE()
	{
		try
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(JFCHGEPCAGF));
			if ((!((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null) || !((Object)(object)((Component)((MonoBehaviourPun)this).photonView).gameObject != (Object)null) || !((MonoBehaviourPun)this).photonView.IsMine) && !OnlineManager.IsMasterClient())
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Back", (RpcTarget)5, PhotonNetwork.LocalPlayer);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	protected override void MKFDEDDJMBG()
	{
		PPHIMGHODKK = "Player";
	}

	public void DBPJPNHEPKE(Player DHPNLIGKMOB)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = ((Component)this).transform.position.x;
		array[0] = ((Component)this).transform.position.y;
		OnlineManager.DBNIKCMHHMJ(photonView, "\n...", DHPNLIGKMOB, array);
	}

	public void DNJIHOPAPED(Vector3 LAEGBHAKCPB)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Veg", (RpcTarget)1, LAEGBHAKCPB.x, LAEGBHAKCPB.y, null, null);
	}

	public void AABNKIGGHLK(Player DHPNLIGKMOB)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = ((Component)this).transform.position.x;
		array[1] = ((Component)this).transform.position.y;
		OnlineManager.DBNIKCMHHMJ(photonView, "Top", DHPNLIGKMOB, array);
	}

	public void KHNJCLFDDHL(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		JOOBIKDBBKE.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 88f));
	}

	public void ONANAICAMED(Player DHPNLIGKMOB)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = ((Component)this).transform.position.x;
		array[0] = ((Component)this).transform.position.y;
		OnlineManager.DBNIKCMHHMJ(photonView, "", DHPNLIGKMOB, array);
	}

	private void HOBPDPADKJM()
	{
		((Behaviour)transformView).enabled = true;
	}

	public void HFBCLCLAKKJ(Vector3 LAEGBHAKCPB)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = LAEGBHAKCPB.x;
		array[0] = LAEGBHAKCPB.y;
		OnlineManager.SendRPC(photonView, "SetMinigame", (RpcTarget)1, array);
	}

	private void IGIKNCOLCKL()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerSpawned?.Invoke(((MonoBehaviourPun)this).photonView);
			OnlinePlayerDataManager instance = OnlinePlayerDataManager.instance;
			instance.OnActorBedAssigned = (Action)Delegate.Combine(instance.OnActorBedAssigned, new Action(GGMCPCMCDAB));
			if (((MonoBehaviourPun)this).photonView.Controller.IsMasterClient && OnlineManager.JPPBEIJDCLJ())
			{
				KEIBPPOJJCP();
			}
			GJABGBAIKHG();
		}
	}

	private void NKHCNMAOGCF(string LNHBAFGPGBJ)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[0] = LNHBAFGPGBJ;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)5, array);
		}
	}

	public void KOIMPHIOHFL(HitDetection NOCOHCGPMFF)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NOCOHCGPMFF != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[0] = ((Component)KlaynNPC.instance).transform.position.x;
			array[0] = ((Component)KlaynNPC.instance).transform.position.y;
			OnlineManager.SendRPC(photonView, "Floor", (RpcTarget)0, array);
		}
	}

	protected override void ENENANMBLDB()
	{
		if (OnlineManager.PlayingOnline())
		{
			((Object)((Component)this).gameObject).name = $"Player (Local: {JOOBIKDBBKE.playerNum}) (NetworkID: {OnlineManager.GetRemoteNetworkID(JOOBIKDBBKE.playerNum)})";
			OnlinePlayerInitialized?.Invoke(((MonoBehaviourPun)this).photonView.Controller, JOOBIKDBBKE.playerNum);
		}
	}

	private void MPNHOLLEOLH()
	{
		if (DKDFNAGAFNL != characterCreator.humanInfo)
		{
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(HHAKBAOAOAE));
			DKDFNAGAFNL = characterCreator.humanInfo;
			HumanInfo dKDFNAGAFNL2 = DKDFNAGAFNL;
			dKDFNAGAFNL2.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL2.CharacterGenderChanged, new Action<Gender>(CDJALGNGDPM));
			HHAKBAOAOAE(characterCreator.humanInfo.gender);
		}
	}

	public void CGLJLLAGHHI(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		JOOBIKDBBKE.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 1677f));
	}

	public void JOLLBJEBEKL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error_MaxZones", (RpcTarget)0);
	}

	public void GKJDCAOFMOE()
	{
		int num = ((((MonoBehaviourPun)this).photonView.Controller.ActorNumber != 1) ? OnlinePlayerDataManager.GetBedAssignedByActorNumber(((MonoBehaviourPun)this).photonView.Controller.ActorNumber) : 0);
		if (num > 0)
		{
			((Component)playerArrow).gameObject.SetActive(true);
			Debug.Log((object)(")" + num));
			if (num > 0)
			{
				playerArrow.sprite = CommonReferences.GGFJGHHHEJC.playerArrowsColor[num - 0];
			}
		}
	}

	private void MHPIKCOAACO(Vector2 IMOBLFMHKOD)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		TravelZonesManager.OMFKNGDCJFN().GJFPJJICGHI(JOOBIKDBBKE.playerNum, IMOBLFMHKOD);
	}

	[PunRPC]
	private void ReceiveLastTravelPosition(Vector2 IMOBLFMHKOD)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		TravelZonesManager.GGFJGHHHEJC.SetLastTravelZonePosition(JOOBIKDBBKE.playerNum, IMOBLFMHKOD, CDPAMNIPPEC: false);
	}

	public void JAJJJKICLCK(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		JOOBIKDBBKE.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 1383f));
	}

	private void EFFKCAGLKJE(string LLNAEKJIJNB)
	{
		OnlineChatUI.ChatBark(LLNAEKJIJNB, ((Component)this).transform);
	}

	private void NHONEJHCMGP(float NCPGNLOJGAF, float JLMAILGJNCE)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		((Behaviour)transformView).enabled = true;
		((Component)JOOBIKDBBKE).transform.position = new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 1161f);
	}

	private void JICOBHADOLK(Vector2 IMOBLFMHKOD)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		TravelZonesManager.GGFJGHHHEJC.SetLastTravelZonePosition(JOOBIKDBBKE.playerNum, IMOBLFMHKOD);
	}

	private void BGFCHEIOKOG()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerSpawned?.Invoke(((MonoBehaviourPun)this).photonView);
			OnlinePlayerDataManager instance = OnlinePlayerDataManager.instance;
			instance.OnActorBedAssigned = (Action)Delegate.Combine(instance.OnActorBedAssigned, new Action(ShowPlayerArrow));
			if (((MonoBehaviourPun)this).photonView.Controller.IsMasterClient && OnlineManager.JPPBEIJDCLJ())
			{
				KEIBPPOJJCP();
			}
			GJMHODKAIBG();
		}
	}

	private void NHGPMMBFACL(string LLNAEKJIJNB)
	{
		OnlineChatUI.ChatBark(LLNAEKJIJNB, ((Component)this).transform);
	}

	public void CIBPPDFNBEO(string LLNAEKJIJNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "None", (RpcTarget)0, LLNAEKJIJNB);
	}

	private void OLCODFHLGGG(int MPMECNEJOMB, string LNHBAFGPGBJ)
	{
		OnlinePlayerNameChanged?.Invoke(MPMECNEJOMB, LNHBAFGPGBJ);
	}

	[PunRPC]
	public void ReceiveKick(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		JOOBIKDBBKE.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 0f));
	}

	public void CJCOICDOPLL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_description_630", (RpcTarget)0);
	}

	[PunRPC]
	public void ReceiveInitialPosition(float AIANGPHHEHI, float JAMLBMCDGOL)
	{
		SetPosition(AIANGPHHEHI, JAMLBMCDGOL);
	}

	[PunRPC]
	private void PlayerCharacterGenderChangeRPC(int MPMECNEJOMB, byte OHMAEGCHIOC)
	{
		OnlinePlayerGenderChanged?.Invoke(MPMECNEJOMB, (Gender)OHMAEGCHIOC);
	}

	private void EJCJOHGLJGE(string LNHBAFGPGBJ)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "MainProgress", (RpcTarget)1, ((MonoBehaviourPun)this).photonView.Controller.ActorNumber, LNHBAFGPGBJ, null);
		}
	}

	public void GCIKEDDIGFI(Player DHPNLIGKMOB)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = ((Component)this).transform.position.x;
		array[1] = ((Component)this).transform.position.y;
		OnlineManager.SendRPC(photonView, "Items/item_description_1111", DHPNLIGKMOB, array);
	}

	public void HNDCGCHGDDI(float AIANGPHHEHI, float JAMLBMCDGOL)
	{
		SetPosition(AIANGPHHEHI, JAMLBMCDGOL);
	}

	public void CBEHBNDFMIE(Vector2 IMOBLFMHKOD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = IMOBLFMHKOD;
			OnlineManager.SendRPC(photonView, "Trying to add player but player list is full.", (RpcTarget)1, array);
		}
	}

	public void AIHEKPNFHFE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "hForHours", (RpcTarget)1);
	}

	private void KMOOMGBJGFK()
	{
		if (DKDFNAGAFNL != characterCreator.humanInfo)
		{
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(DAACJONKHCA));
			DKDFNAGAFNL = characterCreator.humanInfo;
			HumanInfo dKDFNAGAFNL2 = DKDFNAGAFNL;
			dKDFNAGAFNL2.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL2.CharacterGenderChanged, new Action<Gender>(HHAKBAOAOAE));
			JFMMBEABJPB(characterCreator.humanInfo.gender);
		}
	}

	public void KEIBPPOJJCP()
	{
		int num = ((((MonoBehaviourPun)this).photonView.Controller.ActorNumber == 1) ? 1 : OnlinePlayerDataManager.AKLPADOCHDP(((MonoBehaviourPun)this).photonView.Controller.ActorNumber));
		if (num > 0)
		{
			((Component)playerArrow).gameObject.SetActive(false);
			Debug.Log((object)("Player2" + num));
			if (num > 0)
			{
				playerArrow.sprite = CommonReferences.GGFJGHHHEJC.playerArrowsColor[num - 1];
			}
		}
	}

	public void NGOKMFBHEIO(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		JOOBIKDBBKE.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 794f));
	}

	private void MKLAJOMDNOG(float NCPGNLOJGAF, float JLMAILGJNCE)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		((Behaviour)transformView).enabled = false;
		((Component)JOOBIKDBBKE).transform.position = new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 1183f);
	}

	private void FOGCLONKPBD(Vector2 IMOBLFMHKOD)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		TravelZonesManager.GFMBEDCANNI().DAIPNJHLOPJ(JOOBIKDBBKE.playerNum, IMOBLFMHKOD, CDPAMNIPPEC: false);
	}

	public void JBJILBJOGHE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UIPreviousPage", (RpcTarget)1);
	}

	public void KGLIGEFFIAH(Player DHPNLIGKMOB)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = ((Component)this).transform.position.x;
		array[0] = ((Component)this).transform.position.y;
		OnlineManager.DBNIKCMHHMJ(photonView, "Wood", DHPNLIGKMOB, array);
	}

	public void MEEPFLMHFAB(HitDetection NOCOHCGPMFF)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NOCOHCGPMFF != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[0] = ((Component)KlaynNPC.instance).transform.position.x;
			array[0] = ((Component)KlaynNPC.instance).transform.position.y;
			OnlineManager.SendRPC(photonView, "Current crafting:", (RpcTarget)0, array);
		}
	}

	public void FKOGIKNIMDN(string LLNAEKJIJNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = LLNAEKJIJNB;
		OnlineManager.SendRPC(photonView, "itemStrawberry", (RpcTarget)1, array);
	}

	private void MGDLLHBJCFP(int MPMECNEJOMB, string CHOGDNALKPA, byte DJBHINLJOBO)
	{
		OnlinePlayerPlatformID?.Invoke(MPMECNEJOMB, CHOGDNALKPA, (PlatformOS)DJBHINLJOBO);
	}

	private void OPPKGHJLGGP()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			Debug.Log((object)string.Format("Content", Utils.LBEJKMLHMIP(), Utils.ILLKGGBHMLF()));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[0] = Utils.LBEJKMLHMIP();
			array[1] = (byte)Utils.ILLKGGBHMLF();
			OnlineManager.SendRPC(photonView, "Loop", (RpcTarget)3, array);
		}
	}

	private void DFEBKLEGOID()
	{
		((Behaviour)transformView).enabled = true;
	}

	[PunRPC]
	private void PlayerPlatformIDRPC(int MPMECNEJOMB, string CHOGDNALKPA, byte DJBHINLJOBO)
	{
		OnlinePlayerPlatformID?.Invoke(MPMECNEJOMB, CHOGDNALKPA, (PlatformOS)DJBHINLJOBO);
	}

	private void KPGEOFGDMHN()
	{
		if (DKDFNAGAFNL != characterCreator.humanInfo)
		{
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(IHMLBPEGABH));
			DKDFNAGAFNL = characterCreator.humanInfo;
			HumanInfo dKDFNAGAFNL2 = DKDFNAGAFNL;
			dKDFNAGAFNL2.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL2.CharacterGenderChanged, new Action<Gender>(IHMLBPEGABH));
			IMHBCHCBICH(characterCreator.humanInfo.gender);
		}
	}

	private void HBJHAFPPMNI(int BAIMHDBJPDK)
	{
		JOOBIKDBBKE.SetOnlineLocation((Location)BAIMHDBJPDK);
	}

	private void FEJIOKMPDLN()
	{
		if (DKDFNAGAFNL != characterCreator.humanInfo)
		{
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(HHAKBAOAOAE));
			DKDFNAGAFNL = characterCreator.humanInfo;
			HumanInfo dKDFNAGAFNL2 = DKDFNAGAFNL;
			dKDFNAGAFNL2.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL2.CharacterGenderChanged, new Action<Gender>(IHMLBPEGABH));
			DAACJONKHCA(characterCreator.humanInfo.gender);
		}
	}

	protected void FJJFHPIFBID()
	{
		try
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(GDEMPBPNFNN));
			if ((!((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null) || !((Object)(object)((Component)((MonoBehaviourPun)this).photonView).gameObject != (Object)null) || !((MonoBehaviourPun)this).photonView.IsMine) && !OnlineManager.IsMasterClient())
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Duplicate instance of singleton on gameobject ", (RpcTarget)4, PhotonNetwork.LocalPlayer);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void FOIFDMLJHHF(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		JOOBIKDBBKE.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 1184f));
	}

	[PunRPC]
	private void ReceiveFinishTeleport()
	{
		((Behaviour)transformView).enabled = true;
	}

	public void DGLMGLCDPFM(Vector3 LAEGBHAKCPB)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = LAEGBHAKCPB.x;
		array[0] = LAEGBHAKCPB.y;
		OnlineManager.SendRPC(photonView, "<align=left>", (RpcTarget)0, array);
	}

	private void BPLMPBIADKP(string LLNAEKJIJNB)
	{
		OnlineChatUI.ChatBark(LLNAEKJIJNB, ((Component)this).transform);
	}

	private void INEKLJKKGBJ(Vector2 IMOBLFMHKOD)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		TravelZonesManager.OACNNJCLEDE().IFLIOAHBODG(JOOBIKDBBKE.playerNum, IMOBLFMHKOD, CDPAMNIPPEC: false);
	}

	private void OFJNHGJIACN(string LLNAEKJIJNB)
	{
		OnlineChatUI.ChatBark(LLNAEKJIJNB, ((Component)this).transform);
	}

	public void MOGPIPCAOFE(string LLNAEKJIJNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = LLNAEKJIJNB;
		OnlineManager.SendRPC(photonView, "HotBath/Main 3", (RpcTarget)0, array);
	}

	private void EFHCLMHHCIO(string LLNAEKJIJNB)
	{
		OnlineChatUI.ChatBark(LLNAEKJIJNB, ((Component)this).transform);
	}

	public void SendEnableTrigger(bool BJFHJCFOEHG)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEnableTrigger", (RpcTarget)1, BJFHJCFOEHG);
	}

	private void DNFIFOPGOND(int MPMECNEJOMB, string CHOGDNALKPA, byte DJBHINLJOBO)
	{
		OnlinePlayerPlatformID?.Invoke(MPMECNEJOMB, CHOGDNALKPA, (PlatformOS)DJBHINLJOBO);
	}

	private void EBAMAMOKHKF()
	{
		((Behaviour)transformView).enabled = false;
	}

	[PunRPC]
	private void PlayerCharacterNameChangeRPC(int MPMECNEJOMB, string LNHBAFGPGBJ)
	{
		OnlinePlayerNameChanged?.Invoke(MPMECNEJOMB, LNHBAFGPGBJ);
	}

	private void CJMDJAAOBOD(int MPMECNEJOMB, string LNHBAFGPGBJ)
	{
		OnlinePlayerNameChanged?.Invoke(MPMECNEJOMB, LNHBAFGPGBJ);
	}

	public void GGMCPCMCDAB()
	{
		int num = ((((MonoBehaviourPun)this).photonView.Controller.ActorNumber != 0) ? OnlinePlayerDataManager.AKLPADOCHDP(((MonoBehaviourPun)this).photonView.Controller.ActorNumber) : 0);
		if (num > 1)
		{
			((Component)playerArrow).gameObject.SetActive(false);
			Debug.Log((object)("City/Lia/Bark/Stand" + num));
			if (num > 0)
			{
				playerArrow.sprite = CommonReferences.MNFMOEKMJKN().playerArrowsColor[num - 0];
			}
		}
	}

	public void KPGJABHENCP(string LLNAEKJIJNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_1091", (RpcTarget)1, LLNAEKJIJNB);
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerSpawned?.Invoke(((MonoBehaviourPun)this).photonView);
			OnlinePlayerDataManager instance = OnlinePlayerDataManager.instance;
			instance.OnActorBedAssigned = (Action)Delegate.Combine(instance.OnActorBedAssigned, new Action(ShowPlayerArrow));
			if (((MonoBehaviourPun)this).photonView.Controller.IsMasterClient && OnlineManager.IsMasterClient())
			{
				ShowPlayerArrow();
			}
			GJABGBAIKHG();
		}
	}

	private void MHGLCKEBCGC(Vector2 IMOBLFMHKOD)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		TravelZonesManager.DGCNCEDIFOF().BIMONHGKNED(JOOBIKDBBKE.playerNum, IMOBLFMHKOD, CDPAMNIPPEC: false);
	}

	public void SendKick(HitDetection NOCOHCGPMFF)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NOCOHCGPMFF != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveKick", (RpcTarget)1, ((Component)KlaynNPC.instance).transform.position.x, ((Component)KlaynNPC.instance).transform.position.y);
		}
	}

	private void HCKAPMCDPPI()
	{
		if (DKDFNAGAFNL != characterCreator.humanInfo)
		{
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(DAACJONKHCA));
			DKDFNAGAFNL = characterCreator.humanInfo;
			HumanInfo dKDFNAGAFNL2 = DKDFNAGAFNL;
			dKDFNAGAFNL2.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL2.CharacterGenderChanged, new Action<Gender>(DAACJONKHCA));
			DAACJONKHCA(characterCreator.humanInfo.gender);
		}
	}

	private void IAIDKPJKLIC()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerSpawned?.Invoke(((MonoBehaviourPun)this).photonView);
			OnlinePlayerDataManager instance = OnlinePlayerDataManager.instance;
			instance.OnActorBedAssigned = (Action)Delegate.Combine(instance.OnActorBedAssigned, new Action(GKJDCAOFMOE));
			if (((MonoBehaviourPun)this).photonView.Controller.IsMasterClient && OnlineManager.JPPBEIJDCLJ())
			{
				GKJDCAOFMOE();
			}
			OPPKGHJLGGP();
		}
	}

	private void LKPGOKAHHJF(string LNHBAFGPGBJ)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error in CommonReferences.OnPlayerSleepAction: ", (RpcTarget)0, ((MonoBehaviourPun)this).photonView.Controller.ActorNumber, LNHBAFGPGBJ, null, null, null);
		}
	}

	private void OJNDBFDPEAH(int MPMECNEJOMB, string LNHBAFGPGBJ)
	{
		OnlinePlayerNameChanged?.Invoke(MPMECNEJOMB, LNHBAFGPGBJ);
	}

	private void JNFCEDIBLGG(string LNHBAFGPGBJ)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Piso {0}: Punto de aparición '{1}' seleccionado para spawn. Quedan {2} puntos disponibles.", (RpcTarget)8, ((MonoBehaviourPun)this).photonView.Controller.ActorNumber, LNHBAFGPGBJ, null, null, null, null, null);
		}
	}

	public void SendChatBark(string LLNAEKJIJNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ChatBarkRPC", (RpcTarget)0, LLNAEKJIJNB);
	}

	private void IMHBCHCBICH(Gender OHMAEGCHIOC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[3];
			array[1] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[1] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "00", (RpcTarget)3, array);
		}
	}

	public void KJGNDDGKHNH(HitDetection NOCOHCGPMFF)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NOCOHCGPMFF != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = ((Component)KlaynNPC.instance).transform.position.x;
			array[1] = ((Component)KlaynNPC.instance).transform.position.y;
			OnlineManager.SendRPC(photonView, " (", (RpcTarget)1, array);
		}
	}

	private void HLNANGPGCFH(Location BAIMHDBJPDK)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (int)BAIMHDBJPDK;
			OnlineManager.SendRPC(photonView, "Trying to get friend ", (RpcTarget)0, array);
		}
	}

	private void DHAEFJBICDA(float NCPGNLOJGAF, float JLMAILGJNCE)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		((Behaviour)transformView).enabled = false;
		((Component)JOOBIKDBBKE).transform.position = new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 840f);
	}

	public void OPBNKILDKBB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "NinjaChallengeEvent/Main", (RpcTarget)1);
	}

	private void AJBNPBGHKHG()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			Debug.Log((object)string.Format("DualShock", Utils.LBEJKMLHMIP(), Utils.ILLKGGBHMLF()));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[1] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[1] = Utils.LBEJKMLHMIP();
			array[4] = (byte)Utils.ILLKGGBHMLF();
			OnlineManager.SendRPC(photonView, "Color picker requires image material with UI/ColorPicker shader.", (RpcTarget)5, array);
		}
	}

	public void HCLPALNBAEO(bool BJFHJCFOEHG)
	{
		JOOBIKDBBKE.playerCollider.isTrigger = BJFHJCFOEHG;
	}

	public void PHELBIHMFHC(bool BJFHJCFOEHG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BJFHJCFOEHG;
		OnlineManager.SendRPC(photonView, "Disabled", (RpcTarget)0, array);
	}

	public void OJGIMHMIBGH(HitDetection NOCOHCGPMFF)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NOCOHCGPMFF != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[5];
			array[1] = ((Component)KlaynNPC.instance).transform.position.x;
			array[1] = ((Component)KlaynNPC.instance).transform.position.y;
			OnlineManager.SendRPC(photonView, "Hurt", (RpcTarget)0, array);
		}
	}

	private void DAACJONKHCA(Gender OHMAEGCHIOC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "PlayerCharacterGenderChangeRPC", (RpcTarget)3, ((MonoBehaviourPun)this).photonView.Controller.ActorNumber, (byte)OHMAEGCHIOC);
		}
	}

	private void JIHJBDBAIGA(string LNHBAFGPGBJ)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[1] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[0] = LNHBAFGPGBJ;
			OnlineManager.SendRPC(photonView, "CliveProgress", (RpcTarget)6, array);
		}
	}

	public void EBGIGLIACLC()
	{
		int num = ((((MonoBehaviourPun)this).photonView.Controller.ActorNumber == 1) ? 1 : OnlinePlayerDataManager.GetBedAssignedByActorNumber(((MonoBehaviourPun)this).photonView.Controller.ActorNumber));
		if (num > 1)
		{
			((Component)playerArrow).gameObject.SetActive(true);
			Debug.Log((object)("GetOnlineObject() not found any uniqueId " + num));
			if (num > 0)
			{
				playerArrow.sprite = CommonReferences.GGFJGHHHEJC.playerArrowsColor[num - 1];
			}
		}
	}

	public void CAEJPCIGMHM(Player DHPNLIGKMOB)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = ((Component)this).transform.position.x;
		array[0] = ((Component)this).transform.position.y;
		OnlineManager.SendRPC(photonView, "itemBitterHopsSeeds", DHPNLIGKMOB, array);
	}

	public void JCHLABOMNJF(Vector3 LAEGBHAKCPB)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = LAEGBHAKCPB.x;
		array[1] = LAEGBHAKCPB.y;
		OnlineManager.SendRPC(photonView, "SkillPoints", (RpcTarget)0, array);
	}

	private void LLPMGHEMMGB()
	{
		if (DKDFNAGAFNL != characterCreator.humanInfo)
		{
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(IHMLBPEGABH));
			DKDFNAGAFNL = characterCreator.humanInfo;
			HumanInfo dKDFNAGAFNL2 = DKDFNAGAFNL;
			dKDFNAGAFNL2.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL2.CharacterGenderChanged, new Action<Gender>(IHMLBPEGABH));
			HHAKBAOAOAE(characterCreator.humanInfo.gender);
		}
	}

	protected override void Awake()
	{
		MKFDEDDJMBG();
		PlayerInfo.PlayerNameChanged = (Action<string>)Delegate.Combine(PlayerInfo.PlayerNameChanged, new Action<string>(JLNEFDAPAHL));
		if (!OnlineManager.PlayingOnline())
		{
			OPDBPCGDBPH();
			return;
		}
		base.Awake();
		DKDFNAGAFNL = characterCreator.humanInfo;
		HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
		dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(DAACJONKHCA));
		characterCreator.BDJENIOPJKC += HCKAPMCDPPI;
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(GDEMPBPNFNN));
		JOOBIKDBBKE = ((Component)this).GetComponent<PlayerController>();
		JOOBIKDBBKE.onlinePlayer = this;
		PlayerController jOOBIKDBBKE = JOOBIKDBBKE;
		jOOBIKDBBKE.OnChangeLocation = (Action<Location>)Delegate.Combine(jOOBIKDBBKE.OnChangeLocation, new Action<Location>(NOEOPMGOHAD));
		Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
	}

	[PunRPC]
	private void ChatBarkRPC(string LLNAEKJIJNB)
	{
		OnlineChatUI.ChatBark(LLNAEKJIJNB, ((Component)this).transform);
	}

	[PunRPC]
	private void ChangeLocationRPC(int BAIMHDBJPDK)
	{
		JOOBIKDBBKE.SetOnlineLocation((Location)BAIMHDBJPDK);
	}

	private void JBAOMOJABIL(Location BAIMHDBJPDK)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Generated INT CODE: ", (RpcTarget)1, (int)BAIMHDBJPDK);
		}
	}

	private void KBCMHAGEOFN()
	{
		((Behaviour)transformView).enabled = true;
	}

	public void IOJEDFHJKAN(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		JOOBIKDBBKE.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 1287f));
	}

	public void GKMKKGCNGAP(HitDetection NOCOHCGPMFF)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NOCOHCGPMFF != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ((Component)KlaynNPC.instance).transform.position.x;
			array[0] = ((Component)KlaynNPC.instance).transform.position.y;
			OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
		}
	}

	protected override void KLAPDFKAJCK()
	{
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog("NetworkSync " + PPHIMGHODKK + " OnCharacterAppearanceChanged", (Object)(object)((Component)this).gameObject);
		}
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			HHFCMOHBAIM();
		}
	}

	protected void JFCHGEPCAGF()
	{
		try
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(JFCHGEPCAGF));
			if ((!((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null) || !((Object)(object)((Component)((MonoBehaviourPun)this).photonView).gameObject != (Object)null) || !((MonoBehaviourPun)this).photonView.IsMine) && !OnlineManager.JPPBEIJDCLJ())
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "<color=#19FF00>", (RpcTarget)1, PhotonNetwork.LocalPlayer);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	protected void GDEMPBPNFNN()
	{
		try
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(GDEMPBPNFNN));
			if ((!((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null) || !((Object)(object)((Component)((MonoBehaviourPun)this).photonView).gameObject != (Object)null) || !((MonoBehaviourPun)this).photonView.IsMine) && !OnlineManager.IsMasterClient())
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SendInitialPosition", (RpcTarget)2, PhotonNetwork.LocalPlayer);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void NOEOPMGOHAD(Location BAIMHDBJPDK)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ChangeLocationRPC", (RpcTarget)1, (int)BAIMHDBJPDK);
		}
	}

	private void HHAKBAOAOAE(Gender OHMAEGCHIOC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[1] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[1] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "//", (RpcTarget)7, array);
		}
	}

	public void SendStartTeleport(Vector3 LAEGBHAKCPB)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartTeleport", (RpcTarget)1, LAEGBHAKCPB.x, LAEGBHAKCPB.y);
	}

	public void CCHFOCHAFMC()
	{
		int num = ((((MonoBehaviourPun)this).photonView.Controller.ActorNumber == 1) ? 1 : OnlinePlayerDataManager.GetBedAssignedByActorNumber(((MonoBehaviourPun)this).photonView.Controller.ActorNumber));
		if (num > 1)
		{
			((Component)playerArrow).gameObject.SetActive(false);
			Debug.Log((object)("waterQualityTestDone" + num));
			if (num > 1)
			{
				playerArrow.sprite = CommonReferences.GGFJGHHHEJC.playerArrowsColor[num - 1];
			}
		}
	}

	public void PJGJMJMJJPK(string LLNAEKJIJNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = LLNAEKJIJNB;
		OnlineManager.SendRPC(photonView, "New FadeCamera added for player ", (RpcTarget)0, array);
	}

	public void CIMBNOJMCEL(Vector2 IMOBLFMHKOD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = IMOBLFMHKOD;
			OnlineManager.SendRPC(photonView, "No bucket of water", (RpcTarget)1, array);
		}
	}

	public void ShowPlayerArrow()
	{
		int num = ((((MonoBehaviourPun)this).photonView.Controller.ActorNumber == 1) ? 1 : OnlinePlayerDataManager.GetBedAssignedByActorNumber(((MonoBehaviourPun)this).photonView.Controller.ActorNumber));
		if (num > 0)
		{
			((Component)playerArrow).gameObject.SetActive(true);
			Debug.Log((object)("bedAssigned " + num));
			if (num > 1)
			{
				playerArrow.sprite = CommonReferences.GGFJGHHHEJC.playerArrowsColor[num - 1];
			}
		}
	}

	public void DDBKBODGFGC(string LLNAEKJIJNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LoadGameplaySceneOnline masterClient", (RpcTarget)1, LLNAEKJIJNB);
	}

	private void JLNEFDAPAHL(string LNHBAFGPGBJ)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "PlayerCharacterNameChangeRPC", (RpcTarget)3, ((MonoBehaviourPun)this).photonView.Controller.ActorNumber, LNHBAFGPGBJ);
		}
	}

	private void GJABGBAIKHG()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			Debug.Log((object)$"Sending platform data. PlayerID: {Utils.LBEJKMLHMIP()}, Platform: {Utils.ILLKGGBHMLF()}");
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "PlayerPlatformIDRPC", (RpcTarget)3, ((MonoBehaviourPun)this).photonView.Controller.ActorNumber, Utils.LBEJKMLHMIP(), (byte)Utils.ILLKGGBHMLF());
		}
	}

	private void JFFKEACFJKP()
	{
		if (DKDFNAGAFNL != characterCreator.humanInfo)
		{
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(HHAKBAOAOAE));
			DKDFNAGAFNL = characterCreator.humanInfo;
			HumanInfo dKDFNAGAFNL2 = DKDFNAGAFNL;
			dKDFNAGAFNL2.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL2.CharacterGenderChanged, new Action<Gender>(CDJALGNGDPM));
			CDJALGNGDPM(characterCreator.humanInfo.gender);
		}
	}

	public void SendLastTravelPosition(Vector2 IMOBLFMHKOD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveLastTravelPosition", (RpcTarget)1, IMOBLFMHKOD);
		}
	}

	private void BMNDEMJPOFE(int MPMECNEJOMB, string CHOGDNALKPA, byte DJBHINLJOBO)
	{
		OnlinePlayerPlatformID?.Invoke(MPMECNEJOMB, CHOGDNALKPA, (PlatformOS)DJBHINLJOBO);
	}

	private void AGBIAAIFAOO(Vector2 IMOBLFMHKOD)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		TravelZonesManager.GFMBEDCANNI().GJFPJJICGHI(JOOBIKDBBKE.playerNum, IMOBLFMHKOD);
	}

	[PunRPC]
	public void SendInitialPosition(Player DHPNLIGKMOB)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInitialPosition", DHPNLIGKMOB, ((Component)this).transform.position.x, ((Component)this).transform.position.y);
	}

	protected override void OnDestroy()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		PlayerInfo.PlayerNameChanged = (Action<string>)Delegate.Remove(PlayerInfo.PlayerNameChanged, new Action<string>(JLNEFDAPAHL));
		if (OnlineManager.PlayingOnline())
		{
			OnlinePlayerDestroyed?.Invoke(((MonoBehaviourPun)this).photonView.Controller);
			base.OnDestroy();
			if (Object.op_Implicit((Object)(object)OnlinePlayerDataManager.instance))
			{
				OnlinePlayerDataManager instance = OnlinePlayerDataManager.instance;
				instance.OnActorBedAssigned = (Action)Delegate.Remove(instance.OnActorBedAssigned, new Action(ShowPlayerArrow));
			}
			characterCreator.BDJENIOPJKC -= HCKAPMCDPPI;
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(DAACJONKHCA));
			PlayerController jOOBIKDBBKE = JOOBIKDBBKE;
			jOOBIKDBBKE.OnChangeLocation = (Action<Location>)Delegate.Remove(jOOBIKDBBKE.OnChangeLocation, new Action<Location>(NOEOPMGOHAD));
			if (((MonoBehaviourPun)this).photonView.IsMine)
			{
				PhotonNetwork.Destroy(((MonoBehaviourPun)this).photonView);
			}
		}
	}

	public void SendFinishTeleport()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFinishTeleport", (RpcTarget)1);
	}

	private void CJDIFOEHBFD(int MPMECNEJOMB, byte OHMAEGCHIOC)
	{
		OnlinePlayerGenderChanged?.Invoke(MPMECNEJOMB, (Gender)OHMAEGCHIOC);
	}

	public void CCCPHIJODBA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ChangeAnim", (RpcTarget)0);
	}

	private void CDJALGNGDPM(Gender OHMAEGCHIOC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[1] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[1] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "bomb materials", (RpcTarget)0, array);
		}
	}

	private void HCMLNFLCHAE(int MPMECNEJOMB, string LNHBAFGPGBJ)
	{
		OnlinePlayerNameChanged?.Invoke(MPMECNEJOMB, LNHBAFGPGBJ);
	}

	private void IHMLBPEGABH(Gender OHMAEGCHIOC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "tablesCleaned", (RpcTarget)8, array);
		}
	}

	private void DHMLOEILJIA(int MPMECNEJOMB, byte OHMAEGCHIOC)
	{
		OnlinePlayerGenderChanged?.Invoke(MPMECNEJOMB, (Gender)OHMAEGCHIOC);
	}

	[PunRPC]
	public void ReceiveEnableTrigger(bool BJFHJCFOEHG)
	{
		JOOBIKDBBKE.playerCollider.isTrigger = BJFHJCFOEHG;
	}

	private void GJMHODKAIBG()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			Debug.Log((object)string.Format("buildingObjective_38_0", Utils.LBEJKMLHMIP(), Utils.ILLKGGBHMLF()));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[0] = ((MonoBehaviourPun)this).photonView.Controller.ActorNumber;
			array[0] = Utils.LBEJKMLHMIP();
			array[5] = (byte)Utils.ILLKGGBHMLF();
			OnlineManager.SendRPC(photonView, "Disabled", (RpcTarget)2, array);
		}
	}

	private void NGFIBNGIPAJ(int MPMECNEJOMB, string LNHBAFGPGBJ)
	{
		OnlinePlayerNameChanged?.Invoke(MPMECNEJOMB, LNHBAFGPGBJ);
	}

	private void JFMMBEABJPB(Gender OHMAEGCHIOC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player", (RpcTarget)3, ((MonoBehaviourPun)this).photonView.Controller.ActorNumber, (byte)OHMAEGCHIOC, null, null, null, null);
		}
	}

	public void JLDBDJKKIAH(Vector2 IMOBLFMHKOD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = IMOBLFMHKOD;
			OnlineManager.SendRPC(photonView, "[GetFallbackCandidates] Added inactive spawner {0} from piece {1}", (RpcTarget)1, array);
		}
	}

	public void HMFFAHJOHFC(float AIANGPHHEHI, float JAMLBMCDGOL)
	{
		SetPosition(AIANGPHHEHI, JAMLBMCDGOL);
	}

	private void BAEMOEIOJLJ()
	{
		((Behaviour)transformView).enabled = true;
	}

	private void IOLJMBMIOBP()
	{
		if (DKDFNAGAFNL != characterCreator.humanInfo)
		{
			HumanInfo dKDFNAGAFNL = DKDFNAGAFNL;
			dKDFNAGAFNL.CharacterGenderChanged = (Action<Gender>)Delegate.Remove(dKDFNAGAFNL.CharacterGenderChanged, new Action<Gender>(HHAKBAOAOAE));
			DKDFNAGAFNL = characterCreator.humanInfo;
			HumanInfo dKDFNAGAFNL2 = DKDFNAGAFNL;
			dKDFNAGAFNL2.CharacterGenderChanged = (Action<Gender>)Delegate.Combine(dKDFNAGAFNL2.CharacterGenderChanged, new Action<Gender>(CDJALGNGDPM));
			CDJALGNGDPM(characterCreator.humanInfo.gender);
		}
	}

	public void GEABEPLGKEP(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		JOOBIKDBBKE.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 876f));
	}
}
