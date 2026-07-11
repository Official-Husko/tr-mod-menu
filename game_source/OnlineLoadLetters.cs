using System.Collections;
using Photon.Pun;
using Photon.Realtime;

public class OnlineLoadLetters : OnlineLoadBase
{
	private void HJCKDDECBDB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void OIOCHPJKNIC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void EJPECKCNCNJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void JEJMMIOKIIG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LettersMessage oKCOIHJLGCM = ((LettersManager.instance.lettersSaved == null) ? new LettersMessage(null) : new LettersMessage(LettersManager.instance.lettersSaved.ToArray()));
		AHGEFIOOEBL("ReceiveLettersLoad", player, oKCOIHJLGCM, 0, KJOOOPJKLBB: true);
		yield return null;
	}

	private void GIFJDODCPNH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void PIKNCAPJKJM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void POJJBBOIENP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void JCOELFPCJHE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void HBOJEPPCDPC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void CPKAMEPJIEM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	private void DFPHLEDDPMO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveLettersLoad(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LettersMessage>(OINICMNOLPK);
	}
}
