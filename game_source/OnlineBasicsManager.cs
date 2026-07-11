using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineBasicsManager : MonoBehaviourPunCallbacks
{
	public static OnlineBasicsManager instance;

	private void AAMEFJCJLNI(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<BedOccupantsMessage>(OINICMNOLPK).FHAJDOOPLLL();
	}

	[PunRPC]
	private void ReceiveNewAchievement(byte OOKAPOABDJK)
	{
		Utils.DLIIAHACOJB(OOKAPOABDJK);
	}

	public void BJDOENHJKPI(Weather.WeatherType CFDMNANCHEO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)0, (short)CFDMNANCHEO);
	}

	[PunRPC]
	private void ReceiveAssignedBedInfo(byte LBPEIOEHKHD)
	{
		OnlineBedroomsManager.instance.SetAssignedBed(LBPEIOEHKHD);
	}

	[PunRPC]
	private void ReceivePlayerLeftBed(byte[] OINICMNOLPK)
	{
		PlayerDisconnectedMessage playerDisconnectedMessage = OnlineSerializer.Deserialize<PlayerDisconnectedMessage>(OINICMNOLPK);
		OnlineBedroomsManager.instance.bedOccupants[playerDisconnectedMessage.bedIndex].waitingInBed = false;
		playerDisconnectedMessage.GGHCKINHDPF(OnlineManager.PlayerState.leftBed);
	}

	private void AFMDONPAHLB(byte DNLKDNOEEML)
	{
		if (Object.op_Implicit((Object)(object)OnlineBedroomsManager.instance) && OnlineBedroomsManager.instance.bedOccupants != null && OnlineBedroomsManager.instance.bedOccupants.Length == OnlineBedroomsManager.instance.IIBABANGHEM())
		{
			OnlineBedroomsManager.instance.bedOccupants[DNLKDNOEEML].waitingInBed = true;
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, OnlinePlayerDataManager.GetPlayerName(OnlineBedroomsManager.instance.bedOccupants[DNLKDNOEEML].actorNumber), OnlinePlayerDataManager.GGPPENHHFAD(OnlineBedroomsManager.instance.bedOccupants[DNLKDNOEEML].actorNumber));
			if (OnlineManager.JPPBEIJDCLJ() && OnlineBedroomsManager.instance.host.waitingInBed && OnlineBedroomsManager.instance.CFMLHHKHECK())
			{
				Bed.instance.JOCNMKDKDKI();
			}
		}
	}

	private void GPKEHDIFMCG(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<PlayerDisconnectedMessage>(OINICMNOLPK).ENFJMPHKLFF(OnlineManager.PlayerState.loggedIn);
	}

	[PunRPC]
	private void ReceivePlayerConnected(short JJPJHIHBOIB)
	{
		OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedIn, OnlinePlayerDataManager.GetPlayerName(JJPJHIHBOIB), OnlinePlayerDataManager.GetPlayerGender(JJPJHIHBOIB));
	}

	public void GBLBMJFDNMB(Weather.WeatherType CFDMNANCHEO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)CFDMNANCHEO;
		OnlineManager.SendRPC(photonView, "ReceiveTavernAction", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceivePlayerDisconnected(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<PlayerDisconnectedMessage>(OINICMNOLPK).GGHCKINHDPF(OnlineManager.PlayerState.loggedOut);
	}

	private void FLIKCMGJFHE(short JJPJHIHBOIB)
	{
		OnlineBedroomsManager.instance.KLNKDHNBPBJ(OnlinePlayerDataManager.NBKABKMHGNP(JJPJHIHBOIB), JJPJHIHBOIB, OnlinePlayerDataManager.GetPlayerName(JJPJHIHBOIB), OnlinePlayerDataManager.GGPPENHHFAD(JJPJHIHBOIB));
		OnlineLoadInventories.instance.PJOCFMKKPHJ(JJPJHIHBOIB, OnlineBedroomsManager.instance.toolsAlreadyGiven[OnlinePlayerDataManager.AKLPADOCHDP(JJPJHIHBOIB)]);
		OnlineBedroomsManager.instance.toolsAlreadyGiven[OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB)] = true;
	}

	public void KKEIGAJJIDA(OnlineBedroomsManager.BedOccupant[] GIOLANGMFMH, OnlineBedroomsManager.BedOccupant AFLCJDHHKNK)
	{
		BedOccupantsMessage mOBFJEDPIPM = new BedOccupantsMessage(GIOLANGMFMH, AFLCJDHHKNK);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "[MinePuzzleManager] Failed to select a puzzle type. This should never happen if weights are configured correctly.", (RpcTarget)1, array);
	}

	public void NEIOLLOIPOJ(Weather.WeatherType CFDMNANCHEO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Open", (RpcTarget)0, (short)CFDMNANCHEO);
	}

	[PunRPC]
	private void ReceivePassOutActions()
	{
		Bed.instance.PassOutActions(CDPAMNIPPEC: false);
	}

	public void SendNewAchievement(int FPKBGBMOGHL)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNewAchievement", (RpcTarget)1, (byte)FPKBGBMOGHL);
	}

	public void EAEGNPHHDAP(short CFDMNANCHEO)
	{
		Weather.instance.TurnOffAllWeather();
		Weather.currentWeather = (Weather.WeatherType)CFDMNANCHEO;
		Weather.FJCOKGGBBNG();
		Weather.instance.OnWeatherDetermined();
	}

	public void OJJBNIMNPGB(int GEEEJPJIGBB, bool LNAMHBCMLOC, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (LNAMHBCMLOC)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)(GEEEJPJIGBB - 8);
			OnlineManager.SendRPC(photonView, "Region check failed", (RpcTarget)0, array);
		}
		else
		{
			PlayerDisconnectedMessage mOBFJEDPIPM = new PlayerDisconnectedMessage(GEEEJPJIGBB - 3, HNLNENELPKI, HBILFLLKHGP);
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LE_14", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
		}
	}

	public void SendHostBed(bool LNAMHBCMLOC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHostBedInfo", (RpcTarget)1, LNAMHBCMLOC);
	}

	private void BMPMENHIKNL(byte[] OINICMNOLPK)
	{
		PlayerDisconnectedMessage playerDisconnectedMessage = OnlineSerializer.Deserialize<PlayerDisconnectedMessage>(OINICMNOLPK);
		OnlineBedroomsManager.instance.bedOccupants[playerDisconnectedMessage.bedIndex].waitingInBed = true;
		playerDisconnectedMessage.PPDKFBPLPKB((OnlineManager.PlayerState)8);
	}

	public void JLIODAPJGHB(byte DNLKDNOEEML, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		PlayerDisconnectedMessage mOBFJEDPIPM = new PlayerDisconnectedMessage(DNLKDNOEEML, HNLNENELPKI, HBILFLLKHGP);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "itemSage", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveBedOccupantsInfo(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<BedOccupantsMessage>(OINICMNOLPK).NEBOMGGJOPD();
	}

	public void GNGNPGNFLID(Weather.WeatherType CFDMNANCHEO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)CFDMNANCHEO;
		OnlineManager.SendRPC(photonView, "Minigame", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveWeatherInfo(short CFDMNANCHEO)
	{
		Weather.instance.TurnOffAllWeather();
		Weather.currentWeather = (Weather.WeatherType)CFDMNANCHEO;
		Weather.CheckAllWeather();
		Weather.instance.OnWeatherDetermined();
	}

	public void IDEGDEKKDHM(short CFDMNANCHEO)
	{
		Weather.instance.TurnOffAllWeather();
		Weather.currentWeather = (Weather.WeatherType)CFDMNANCHEO;
		Weather.FLNMLNHOLND();
		Weather.instance.OnWeatherDetermined();
	}

	private void LLPJLKEOAIG(short JJPJHIHBOIB)
	{
		OnlineBedroomsManager.instance.MOIHDOGFOPM(OnlinePlayerDataManager.GetPlayerPlatformID(JJPJHIHBOIB), JJPJHIHBOIB, OnlinePlayerDataManager.GetPlayerName(JJPJHIHBOIB), OnlinePlayerDataManager.GGPPENHHFAD(JJPJHIHBOIB));
		OnlineLoadInventories.instance.IGCDIPFBLON(JJPJHIHBOIB, OnlineBedroomsManager.instance.toolsAlreadyGiven[OnlinePlayerDataManager.AKLPADOCHDP(JJPJHIHBOIB)]);
		OnlineBedroomsManager.instance.toolsAlreadyGiven[OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB)] = false;
	}

	[PunRPC]
	private void ReceiveSleepStart()
	{
		Bed.instance.StartSleep();
	}

	public void GILNOOHPEGC(int LBPEIOEHKHD, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		object[] array = new object[1];
		array[1] = (byte)LBPEIOEHKHD;
		OnlineManager.SendRPC(photonView, "Small room ", player, array);
		KKEIGAJJIDA(OnlineBedroomsManager.instance.bedOccupants, OnlineBedroomsManager.instance.host);
	}

	public void CDNFKMEILDH(bool LNAMHBCMLOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = LNAMHBCMLOC;
		OnlineManager.SendRPC(photonView, "ReceiveLoadSlots", (RpcTarget)0, array);
	}

	public void AskHostForRoomToJoin(int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAskHostForRoomToJoin", (RpcTarget)2, (short)JJPJHIHBOIB);
	}

	private void BEMIDDNFHHL(byte[] OINICMNOLPK)
	{
		PlayerDisconnectedMessage playerDisconnectedMessage = OnlineSerializer.Deserialize<PlayerDisconnectedMessage>(OINICMNOLPK);
		OnlineBedroomsManager.instance.bedOccupants[playerDisconnectedMessage.bedIndex].waitingInBed = true;
		playerDisconnectedMessage.DNEBHJJGAJO(OnlineManager.PlayerState.loggedIn);
	}

	public void SendSleepStart()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSleepStart", (RpcTarget)1);
	}

	public void SendWeatherInfo(Weather.WeatherType CFDMNANCHEO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveWeatherInfo", (RpcTarget)1, (short)CFDMNANCHEO);
	}

	public void SendBedInfoToClient(int LBPEIOEHKHD, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAssignedBedInfo", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), (byte)LBPEIOEHKHD);
		SendBedOccupantsInfo(OnlineBedroomsManager.instance.bedOccupants, OnlineBedroomsManager.instance.host);
	}

	public void SendPlayerState(int GEEEJPJIGBB, bool LNAMHBCMLOC, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (LNAMHBCMLOC)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlayerInBed", (RpcTarget)1, (byte)(GEEEJPJIGBB - 2));
		}
		else
		{
			PlayerDisconnectedMessage mOBFJEDPIPM = new PlayerDisconnectedMessage(GEEEJPJIGBB - 2, HNLNENELPKI, HBILFLLKHGP);
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlayerLeftBed", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
		}
	}

	[PunRPC]
	private void ReceiveHostBedInfo(bool LNAMHBCMLOC)
	{
		if (Object.op_Implicit((Object)(object)OnlineBedroomsManager.instance))
		{
			OnlineBedroomsManager.instance.host.waitingInBed = LNAMHBCMLOC;
			OnlineManager.ShowPlayerAnnouncement(LNAMHBCMLOC ? OnlineManager.PlayerState.inBed : OnlineManager.PlayerState.leftBed, OnlinePlayerDataManager.GetPlayerName(1), OnlinePlayerDataManager.GetPlayerGender(1));
		}
	}

	public void SendBedOccupantsInfo(OnlineBedroomsManager.BedOccupant[] GIOLANGMFMH, OnlineBedroomsManager.BedOccupant AFLCJDHHKNK)
	{
		BedOccupantsMessage mOBFJEDPIPM = new BedOccupantsMessage(GIOLANGMFMH, AFLCJDHHKNK);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBedOccupantsInfo", (RpcTarget)0, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public void SendPassOutActions()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePassOutActions", (RpcTarget)1);
	}

	public void SendPlayerDisconnected(byte DNLKDNOEEML, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		PlayerDisconnectedMessage mOBFJEDPIPM = new PlayerDisconnectedMessage(DNLKDNOEEML, HNLNENELPKI, HBILFLLKHGP);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlayerDisconnected", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	[PunRPC]
	private void ReceivePlayerInBed(byte DNLKDNOEEML)
	{
		if (Object.op_Implicit((Object)(object)OnlineBedroomsManager.instance) && OnlineBedroomsManager.instance.bedOccupants != null && OnlineBedroomsManager.instance.bedOccupants.Length == OnlineBedroomsManager.instance.GetMaxClientsNumber())
		{
			OnlineBedroomsManager.instance.bedOccupants[DNLKDNOEEML].waitingInBed = true;
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.inBed, OnlinePlayerDataManager.GetPlayerName(OnlineBedroomsManager.instance.bedOccupants[DNLKDNOEEML].actorNumber), OnlinePlayerDataManager.GetPlayerGender(OnlineBedroomsManager.instance.bedOccupants[DNLKDNOEEML].actorNumber));
			if (OnlineManager.IsMasterClient() && OnlineBedroomsManager.instance.host.waitingInBed && OnlineBedroomsManager.instance.AllClientsInBed())
			{
				Bed.instance.StartSleep();
			}
		}
	}

	public void FPDOLILCCEN(byte DNLKDNOEEML, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		PlayerDisconnectedMessage mOBFJEDPIPM = new PlayerDisconnectedMessage(DNLKDNOEEML, HNLNENELPKI, HBILFLLKHGP);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Items/item_name_1092", (RpcTarget)1, array);
	}

	private void KBHDIDAKNDL()
	{
		Bed.instance.StartSleep();
	}

	private void GFELGNHLJGJ(bool LNAMHBCMLOC)
	{
		if (Object.op_Implicit((Object)(object)OnlineBedroomsManager.instance))
		{
			OnlineBedroomsManager.instance.host.waitingInBed = LNAMHBCMLOC;
			OnlineManager.ShowPlayerAnnouncement(LNAMHBCMLOC ? OnlineManager.PlayerState.waitingMinigame : OnlineManager.PlayerState.waitingMinigame, OnlinePlayerDataManager.GetPlayerName(0), OnlinePlayerDataManager.GGPPENHHFAD(0));
		}
	}

	public void PIDKLACMGGP(short CFDMNANCHEO)
	{
		Weather.instance.TurnOffAllWeather();
		Weather.currentWeather = (Weather.WeatherType)CFDMNANCHEO;
		Weather.FJCOKGGBBNG();
		Weather.instance.OnWeatherDetermined();
	}

	public void SendPlayerConnected(int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlayerConnected", (RpcTarget)1, (short)JJPJHIHBOIB);
	}

	private void MPDJHLMJIJN(short JJPJHIHBOIB)
	{
		OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, OnlinePlayerDataManager.OIMEFCJGACI(JJPJHIHBOIB), OnlinePlayerDataManager.GGPPENHHFAD(JJPJHIHBOIB));
	}

	[PunRPC]
	private void ReceiveAskHostForRoomToJoin(short JJPJHIHBOIB)
	{
		OnlineBedroomsManager.instance.AssignRoomToClient(OnlinePlayerDataManager.GetPlayerPlatformID(JJPJHIHBOIB), JJPJHIHBOIB, OnlinePlayerDataManager.GetPlayerName(JJPJHIHBOIB), OnlinePlayerDataManager.GetPlayerGender(JJPJHIHBOIB));
		OnlineLoadInventories.instance.SendInventoryToChest(JJPJHIHBOIB, OnlineBedroomsManager.instance.toolsAlreadyGiven[OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB)]);
		OnlineBedroomsManager.instance.toolsAlreadyGiven[OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB)] = true;
	}

	public void OMEJPBEEILO(byte DNLKDNOEEML, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		PlayerDisconnectedMessage mOBFJEDPIPM = new PlayerDisconnectedMessage(DNLKDNOEEML, HNLNENELPKI, HBILFLLKHGP);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Talent", (RpcTarget)0, OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM));
	}

	private void Awake()
	{
		instance = this;
	}
}
