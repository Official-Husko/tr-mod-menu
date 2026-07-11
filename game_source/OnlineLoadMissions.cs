using System.Collections;
using Photon.Pun;
using Photon.Realtime;

public class OnlineLoadMissions : OnlineLoadBase
{
	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LoadMissionInfo oKCOIHJLGCM = new LoadMissionInfo();
		AHGEFIOOEBL("ReceiveMissionInfoLoad", player, oKCOIHJLGCM, 0, KJOOOPJKLBB: true);
		yield return null;
	}

	private void LOJFOIJMLIH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void CNAJMIJCCEM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void GPPKHLCNGDL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void JKKCBNLOCIK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void BJJMNODOEFM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void DFIMAGHHLKJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void PHPICACCGDL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void PJKJGLADLJA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void AOHHJDBINNP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void DLOCDCBKPGK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveMissionInfoLoad(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}

	private void FHCHIDMMGGD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadMissionInfo>(OINICMNOLPK);
	}
}
