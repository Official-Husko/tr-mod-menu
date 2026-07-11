using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;

public class OnlineLoadTalents : OnlineLoadBase
{
	[Serializable]
	public class LoadTalentsMessage : LoadMessageBase
	{
		[JsonProperty("1")]
		public short actorNumber;

		[JsonProperty("2")]
		public short[] perksIds;

		[JsonProperty("3")]
		public byte[] perksLevels;

		public override void OEJJGDMKIDN()
		{
			if (perksIds != null)
			{
				for (int i = 0; i < perksIds.Length; i++)
				{
					PerksDatabaseAccessor.SetPlayerPerk(actorNumber, perksIds[i], perksLevels[i]);
				}
			}
		}
	}

	private void KCJBGDNOHOB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void JONOJLDIKIM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void MKAHBLPABGG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void MKKNEPNMICK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void GDGAKFFELJO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void BNEEEDAPEFP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		int numMessages = 0;
		Dictionary<int, PerksLevelPair> actorPerksLevels = PerksDatabaseAccessor.GetActorPerksLevels();
		if (actorPerksLevels != null && actorPerksLevels.Count > 0)
		{
			foreach (KeyValuePair<int, PerksLevelPair> item in actorPerksLevels)
			{
				LoadTalentsMessage loadTalentsMessage = new LoadTalentsMessage();
				loadTalentsMessage.actorNumber = (short)item.Key;
				loadTalentsMessage.perksIds = item.Value.perksLevels.Keys.Select((int x) => (short)x).ToArray();
				loadTalentsMessage.perksLevels = item.Value.perksLevels.Values.Select((int x) => (byte)x).ToArray();
				AHGEFIOOEBL("ReceiveTalentsLoad", targetPlayer, loadTalentsMessage, numMessages++, numMessages == actorPerksLevels.Count);
				yield return null;
			}
		}
		else
		{
			LoadTalentsMessage loadTalentsMessage = new LoadTalentsMessage();
			AHGEFIOOEBL("ReceiveTalentsLoad", targetPlayer, loadTalentsMessage, numMessages, KJOOOPJKLBB: true);
		}
	}

	private void KIODELPFDBI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void BELJOMEBEIO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void HLPOENDMJJE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void COLIFNBDCGP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void EACGNKKCFJF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveTalentsLoad(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void DDIFBMEMIOB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void AFNFHLBNBIO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void MOCKFGCPLPD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void DIFNBKIKDKE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void HPMGKFHDNIA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}

	private void IBLBJMLILBF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTalentsMessage>(OINICMNOLPK);
	}
}
