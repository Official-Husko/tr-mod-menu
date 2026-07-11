using System.Collections;
using Photon.Pun;
using Photon.Realtime;

public class OnlineLoadQuest : OnlineLoadBase
{
	private void BGDDGPCKKDF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void FFMNCKDFIMP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void DKGKLPFGJLA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void AGEAEDCKEED(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void OIKNKKNPDIJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveQuestInfoLoad(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void JPEKMNGDKKF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void AHMOPOHJJFA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void MFOIGFJDEFE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void FHPLNMIOBGD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void NIBMMHEHIPO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	private void HEAHEBBGDGD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadQuestInfo>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LoadQuestInfo oKCOIHJLGCM = new LoadQuestInfo();
		AHGEFIOOEBL("ReceiveQuestInfoLoad", player, oKCOIHJLGCM, 0, KJOOOPJKLBB: true);
		yield return null;
	}
}
