using System.Collections;
using System.Linq;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadBar : OnlineLoadBase
{
	public class LoadDrinkDispenser : LoadMessageBase
	{
		[JsonProperty("d")]
		public DrinkDispenserMessage[] drinkDispensersMessage;

		public LoadDrinkDispenser(DrinkDispenser[] HBHINBIAEHD)
		{
			drinkDispensersMessage = HBHINBIAEHD.Select((DrinkDispenser x) => new DrinkDispenserMessage(x.placeable.onlinePlaceable as OnlineDrinkDispenser)).ToArray();
		}

		public override void OEJJGDMKIDN()
		{
			for (int i = 0; i < drinkDispensersMessage.Length; i++)
			{
				OnlineDrinkDispenser onlineDrinkDispenser = OnlineObjectsManager.instance.onlineObjects[drinkDispensersMessage[i].uniqueId] as OnlineDrinkDispenser;
				if (Object.op_Implicit((Object)(object)onlineDrinkDispenser))
				{
					drinkDispensersMessage[i].KONEAIKLOMO(onlineDrinkDispenser.drinkDispenser);
				}
			}
		}
	}

	public class LoadPlaceablesInsideBarMessage : LoadMessageBase
	{
		public int[] list;

		public override void OEJJGDMKIDN()
		{
			for (int i = 0; i < list.Length; i++)
			{
				OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(list[i]);
				Bar.instance.placeablesInside.AAPJLEFMGJP(onlinePlaceable.placeable);
			}
		}
	}

	[PunRPC]
	private void ReceivePlaceablesInsideBar(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void HACIHNBAMIO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void DMBCDCJCNEH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void CAAEOCPJNGK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void ANFFCEGALHF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void EPLDDLGCIKI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void OEGIDACMNEO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void PNOHMDGMPGN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void JNAPPBBLCEF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void GAOKMGMCFHD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void GPDPAONNAID(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void PEFPPIJDJPM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void IMBGHFAMJFP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void BFGBKBMOIBC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void IJPIFAELLNO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void JFIEEONBPGK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void LABHKCHMFPA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void FNFHHGDMBOO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void AKODGPODPJM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void HFEBECCCOJJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void HNJINKDPIMF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void IOHOANPDAPB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void PNOIHHGAAHE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void IABIENNLJJN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void GPICAMBJABK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveBeerTaps(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void BNEFIEMDEBF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void IAJEGEGIFON(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void CBPIDJCAAFL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void IDJGECNDNKH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void LHBHGHOIHMI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void AINFCDCKCBK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void EHKODKJHJLF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void JGBGENPDOHC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void BKPHOKLPGIE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void CIKOFFEEHFL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void BPGPADFHLFP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void NFDJMNAOHDJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void IKLOMJPNAFJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void PABMAFJLLPJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void GPKFHFLHNCD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void JAOLBBGLOAP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void NAHPCPMPMAL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void BHALHHJNEAN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void GFPILOAECOC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void OPFNIPAEADB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LoadDrinkDispenser oKCOIHJLGCM = new LoadDrinkDispenser(Bar.instance.beerTaps.Select((BeerTap x) => x.drinkDispenser).ToArray());
		AHGEFIOOEBL("ReceiveBeerTaps", targetPlayer, oKCOIHJLGCM, 0);
		yield return null;
		LoadPlaceablesInsideBarMessage loadPlaceablesInsideBarMessage = new LoadPlaceablesInsideBarMessage();
		loadPlaceablesInsideBarMessage.list = Bar.instance.placeablesInside.allPlaceables.Select((PlaceablesInside.PlaceableInside x) => x.placeable.onlinePlaceable.uniqueId).ToArray();
		AHGEFIOOEBL("ReceivePlaceablesInsideBar", targetPlayer, loadPlaceablesInsideBarMessage, 1, KJOOOPJKLBB: true);
		yield return null;
	}

	private void PEHHBGCIOGN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void HOABCNMKEKC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void OCJHAFJLOMF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void FLJHLOLMEFN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void NFKKEHNAABH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void IDFJBICEPOP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void BEKIKPNGENC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void MNEABHBLGJO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void BIPMOPNBPOP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void LBDJHMJMJNK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadPlaceablesInsideBarMessage>(OINICMNOLPK);
	}

	private void FHKDHBDNILA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void AEKEKMDLCLB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}

	private void HMNCADEEJNO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDrinkDispenser>(OINICMNOLPK);
	}
}
