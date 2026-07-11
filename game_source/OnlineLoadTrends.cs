using System;
using System.Collections;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadTrends : OnlineLoadBase
{
	[Serializable]
	public class LoadTrendsMessage : LoadMessageBase
	{
		[JsonProperty("aT")]
		public TrendSetMessage[] allTrends;

		public override void OEJJGDMKIDN()
		{
			try
			{
				for (int i = 0; i < allTrends.Length; i++)
				{
					allTrends[i].OEJJGDMKIDN(Trends.GGFJGHHHEJC.allTrends[i]);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError((object)ex);
			}
		}

		public LoadTrendsMessage()
		{
			allTrends = new TrendSetMessage[Trends.GGFJGHHHEJC.allTrends.Length];
			for (int i = 0; i < Trends.GGFJGHHHEJC.allTrends.Length; i++)
			{
				allTrends[i] = new TrendSetMessage(Trends.GGFJGHHHEJC.allTrends[i]);
			}
		}
	}

	[PunRPC]
	private void ReceiveTrends(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void IKIAEDDMBCA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		try
		{
			Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
			AHGEFIOOEBL("ReceiveTrends", player, new LoadTrendsMessage(), 0, KJOOOPJKLBB: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
		yield return null;
	}

	private void AAFGLPLLDNJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void CFIPDPCKOFH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void DMJOKPPFLAH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void GDIIBONMEJM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void PBIKLPJLABD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void BONBIOLOOAO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void AJNHDKICHNC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void IKGKIJPLGAO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void PAJBIGFCMKL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}

	private void FEGFOMGKNOM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTrendsMessage>(OINICMNOLPK);
	}
}
