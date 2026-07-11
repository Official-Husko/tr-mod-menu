using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using UnityEngine;

public class OnlineLoadEvents : OnlineLoadBase
{
	[Serializable]
	public struct EventInfo
	{
		[JsonProperty("1")]
		public int eventType;

		[JsonProperty("2")]
		public bool isActive;

		[JsonProperty("3")]
		public bool isDone;

		public void OKGKOBNNNGC(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public EventInfo(GameEvent CHCEBDOKCNC)
		{
			eventType = (int)CHCEBDOKCNC.eventType;
			isActive = CHCEBDOKCNC.isActive;
			isDone = CHCEBDOKCNC.isDone;
		}

		public void LDMJMOGMFAC(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void KDMCPJNFLEL(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void LILBGKGCGAI(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void IMEDONKCJDA(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void HLNPJKLNFLB(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void PJFOGEIGLKC(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void JGICJJLCCEC(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void PBGLLGDBMLA(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void GADMKHGADKG(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void CIPNIDCFNJO(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void ELABCBDAMDM(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void KOBPEKDDFLM(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void MLAGCCNDODM(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void FHMOKMELJDN(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void ODNDPEHHFKH(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void NPEHNBLIFFC(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void BDEIBKHBPCD(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void NNDOJFHIHMN(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void CEMLNDJNPJE(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void AOKLGJHOHIJ(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void AHCDEMOPOLJ(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void LNECJFMMMGD(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void DBGNABGCONI(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void EPLODFKIOHO(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void GDJLKEFCNME(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void CAAKJCLAJOL(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void HLKMEFPGAGK(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void BADCCEADMBF(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}

		public void BBILEBONHMI(GameEvent CHCEBDOKCNC)
		{
			CHCEBDOKCNC.LoadGameEvent(isActive, isDone);
		}
	}

	public class LoadEventsInfo : LoadMessageBase
	{
		[JsonProperty("1")]
		public EventInfo[] eventsInfo;

		[JsonProperty("2")]
		public bool easyDifficulty;

		[JsonProperty("3")]
		public float[] challengeRecords;

		public LoadEventsInfo()
		{
			List<EventInfo> list = new List<EventInfo>();
			for (int i = 0; i < EventsManager.instance.allGameEvents.Count; i++)
			{
				list.Add(new EventInfo(EventsManager.instance.allGameEvents[i]));
			}
			eventsInfo = list.ToArray();
			easyDifficulty = EventsManager.instance.easyDifficultyMode;
			if (EventsManager.GetRecords() != null)
			{
				challengeRecords = EventsManager.GetRecords();
			}
		}

		public override void OEJJGDMKIDN()
		{
			for (int i = 0; i < eventsInfo.Length; i++)
			{
				GameEvent gameEvent = EventsManager.GetGameEvent((EventsManager.EventType)eventsInfo[i].eventType);
				if (Object.op_Implicit((Object)(object)gameEvent))
				{
					eventsInfo[i].CEMLNDJNPJE(gameEvent);
				}
			}
			EventsManager.instance.easyDifficultyMode = easyDifficulty;
			if (challengeRecords != null)
			{
				EventsManager.SetRecords(challengeRecords);
			}
		}
	}

	private void EPNDBDKCDGJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void CNEOHHCJJPG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void GOLANHIHPHG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void PIFFPCJMAMG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void EPIINGLOKJD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void MJNLDIENPJI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void AEFJOPFKFCM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void CCADFKAPFJI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void HCEPEOJPBJI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		LoadEventsInfo oKCOIHJLGCM = new LoadEventsInfo();
		AHGEFIOOEBL("ReceiveLoadEvents", JJPJHIHBOIB, oKCOIHJLGCM, 0, KJOOOPJKLBB: true);
		yield return null;
	}

	private void ODFGNPKFFHH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void ENKNKNMFCEC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void LEDDHLJLHHP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void DGFHANKKMCH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void IIEONLEBBJM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void JCKNDPBEPBP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void EPPCJBOGCIL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void HPBNHKFLNAL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void HMKGGHCMBNK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void PKEJPMIGBMJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void JGFMLIGGCLM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void CCKCCMKCCCO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void DAOGGHBMMAN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveLoadEvents(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void POOCEGACMLK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void IDOLAIEJNBF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void LBBHNBMKFDN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void AIHIDMAAPAE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void GGLNLEKHJJE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void GHIDAGMPEOG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void NFIJKLJEPCI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void HHAFPOJLKNC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void FAPKJCAILEG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void OKIBGNLBJKF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}

	private void GBFIMNLILHC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadEventsInfo>(OINICMNOLPK);
	}
}
