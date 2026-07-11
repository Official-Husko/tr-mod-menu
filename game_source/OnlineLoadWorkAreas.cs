using System;
using System.Collections;
using System.Linq;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;

public class OnlineLoadWorkAreas : OnlineLoadBase
{
	[Serializable]
	public class LoadWorkAreaMessage : LoadMessageBase
	{
		[JsonProperty("aS")]
		public int[] areaSpaces;

		public LoadWorkAreaMessage(WorkArea PJIAPEDEBEP)
		{
			if (PJIAPEDEBEP.areaSpaces != null)
			{
				areaSpaces = PJIAPEDEBEP.areaSpaces.Select((AreaSpace x) => x.placeable.onlinePlaceable.uniqueId).ToArray();
			}
			else
			{
				areaSpaces = new int[0];
			}
		}

		public override void OEJJGDMKIDN()
		{
			WorkArea workArea = WorkAreasManager.GGFJGHHHEJC.CreateNewWorkArea();
			if (areaSpaces == null || areaSpaces.Length == 0)
			{
				return;
			}
			for (int i = 0; i < areaSpaces.Length; i++)
			{
				if (OnlineObjectsManager.instance.GetOnlinePlaceable(areaSpaces[i]) is OnlineAreaSpace onlineAreaSpace)
				{
					workArea.FLGONEPAKIL(onlineAreaSpace.areaSpace);
				}
			}
		}
	}

	private void OKGMFFDKPAC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void MAMMOGDMMJK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		int numMessages = 0;
		if (WorkAreasManager.GGFJGHHHEJC.workAreas != null && WorkAreasManager.GGFJGHHHEJC.workAreas.Count > 0)
		{
			for (int i = 0; i < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; i++)
			{
				AHGEFIOOEBL("ReceiveWorkArea", targetPlayer, new LoadWorkAreaMessage(WorkAreasManager.GGFJGHHHEJC.workAreas[i]), numMessages++, i == WorkAreasManager.GGFJGHHHEJC.workAreas.Count - 1);
				yield return null;
			}
		}
		else
		{
			WorkArea workArea = new WorkArea();
			workArea.areaSpaces = null;
			AHGEFIOOEBL("ReceiveWorkArea", targetPlayer, new LoadWorkAreaMessage(workArea), numMessages, KJOOOPJKLBB: true);
		}
	}

	private void DCIGCGLHCJP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void IAIHJKAIHAF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void DJLGAEAOBFJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void MMMEIBHOHIB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void NOBCNOPCMCL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void NEHFNGBDHKL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void CBKPELBJHAL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void KOIBCEPPNJN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void KAFGLLLCFLC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void AHBNAJIJGIF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void MFHCPEOEMOK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void DJBBNFEOLMF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void HOCKKJAJJGJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void BAHJALIPOOC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveWorkArea(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void BDFDBPEFGEO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void PHEKGIOFBGK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void ABHHELLCAFI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void DIKIIPDEECE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void LOHHFKFEEMH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void AHGFBIPIDHH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void LIPJKBELKPD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void BEBDIODLFNM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void BKKEIADBKHH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void HNPNKECDKKA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void CABGDPACLHP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void ODFECGDLODP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void EIFNKKNPHMK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void MFIJADNLELA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void PPBCMBAMDGK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}

	private void BBCHEGDKNME(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadWorkAreaMessage>(OINICMNOLPK);
	}
}
