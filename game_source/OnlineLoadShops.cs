using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;

public class OnlineLoadShops : OnlineLoadBase
{
	[Serializable]
	public class LoadShopMessage : LoadMessageBase
	{
		[JsonProperty("1")]
		public ShopMsg shopMessage;

		public override void OEJJGDMKIDN()
		{
			shopMessage.OEJJGDMKIDN();
		}

		public LoadShopMessage()
		{
			shopMessage = new ShopMsg();
		}

		public LoadShopMessage(Shop OJKANJDPKNE)
		{
			shopMessage = new ShopMsg(OJKANJDPKNE);
		}
	}

	private void OMADNMAEOLN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void GAFBCFLJDBF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void OACIGGPLGIM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void FOIJAEFNKJD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void AMOOANCOFLC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void JLDHKOAOMAI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void JAMEPGKKHJP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveShopInfoLoad(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void CMFGPOBKKHN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void LGAJMKNOGKN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void LJBALBJJIFD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void GHCDPPGIBDH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void GGIFMOHHKLN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void OPBFKEDKKFO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		List<Shop> shops = ShopDatabaseAccessor.GetAllShops();
		int numMessages = 0;
		for (int i = 0; i < shops.Count; i++)
		{
			if (shops[i].saveShop && shops[i].limitedItems)
			{
				LoadShopMessage oKCOIHJLGCM = new LoadShopMessage(shops[i]);
				AHGEFIOOEBL("ReceiveShopInfoLoad", targetPlayer, oKCOIHJLGCM, numMessages++);
				yield return null;
			}
		}
		AHGEFIOOEBL("ReceiveShopInfoLoad", targetPlayer, new LoadShopMessage(), numMessages, KJOOOPJKLBB: true);
	}

	private void AEOCOMPFAPN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void FPNIABECMLI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void NPFBOJMMOJL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void ILANPLHGFKG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void DNMMBIFJMPN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void BAIACOCLIIA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void POPPMOFHMNL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void LEFKCNONHFB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void AGIKIFNKOMH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void JLAMNIGDCLF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void DJPCJGEILJC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void EKHPLJHBMFK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void PPLFFLCAFFG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void CBGJBOJFPMC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void HGJDFHDDGEO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void FJOGKPICAJB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void DJFCNNNEFHN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void NMEJMBGNOON(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void HNHBMPDCJDO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void KEFHJNKCNNA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void OGFDCPKKKDM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void CFDMJENMEGK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void KKAOHHOLOPL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void OHKDABNKMEG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void LFDDBKBDPLD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void OELOPECOJFA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void GJLKFFNPLHN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void DADAFDECECA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void HOJCFOJOFAL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void BPLNEFDLGCN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void GBNDJCCDGJE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void ODLNKIJBJAH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void GCOGJICKBHN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void GEDCPALJJPG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}

	private void EMLHCNDJNHJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadShopMessage>(OINICMNOLPK);
	}
}
