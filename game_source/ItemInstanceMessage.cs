using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class ItemInstanceMessage : IOnlineSerializable
{
	[JsonProperty("id")]
	public short itemID;

	public virtual void DABKCONDNGF(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void BNBJFAHIMNH(ItemInstance DNLMCHDOMOK)
	{
	}

	public static ItemInstanceMessage MENBNCJDCEO(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public ItemInstanceMessage(ItemInstance DNLMCHDOMOK)
	{
		CPFDLKMCBCB(DNLMCHDOMOK);
	}

	public virtual void IHLACOEGANH(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.AFOACBIHNCL(), null))
		{
			itemID = (short)DNLMCHDOMOK.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false);
		}
		else
		{
			itemID = 0;
		}
	}

	public virtual void CPFDLKMCBCB(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.MLBOMGHINCA(DNLMCHDOMOK.LHBPOPOIFLE(), null))
		{
			itemID = (short)DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC();
		}
		else
		{
			itemID = 0;
		}
	}

	public ItemInstance IHHPKOPGNNO()
	{
		Item item = ItemDatabaseAccessor.KMBGJEKCJFJ(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)("0" + itemID + "Ach_"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		HAIGBPBFLPB(itemInstance);
		return itemInstance;
	}

	public virtual void FKCHCFGJFML(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void JDOIPENIFLC(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void AIFIBNNAMEC(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.KNFNJFFCFNO(), null))
		{
			itemID = (short)DNLMCHDOMOK.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false);
		}
		else
		{
			itemID = 1;
		}
	}

	public virtual void NJABALNECMH(ItemInstance DNLMCHDOMOK)
	{
	}

	public ItemInstance JAEJCIJCCBN()
	{
		Item item = ItemDatabaseAccessor.INJBNHPGCIJ(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		if (Item.EKGNIODFJCO(item, null))
		{
			Debug.Log((object)("Drink" + itemID + "Item "));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		CCNAFGIHKDH(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage PDFKCKNHMDJ(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public ItemInstance LEIKEJOAAKF()
	{
		Item item = ItemDatabaseAccessor.GetItem(itemID);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)(" " + itemID + "\n"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		HAIGBPBFLPB(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage JKBFIGGBMNC(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public virtual void LIIIBHPMFKK(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.MLBOMGHINCA(DNLMCHDOMOK.AFOACBIHNCL(), null))
		{
			itemID = (short)DNLMCHDOMOK.AFOACBIHNCL().CIGFGKKCPCK();
		}
		else
		{
			itemID = 0;
		}
	}

	public virtual void GGBNIFDMHIK(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.KNFNJFFCFNO(), null))
		{
			itemID = (short)DNLMCHDOMOK.LHBPOPOIFLE().ODENMDOJPLC(DAINLFIMLIH: false);
		}
		else
		{
			itemID = 0;
		}
	}

	public virtual void OKNDDCMEDKP(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.MLBOMGHINCA(DNLMCHDOMOK.PHGLMBIEOMK(), null))
		{
			itemID = (short)DNLMCHDOMOK.PHGLMBIEOMK().CIGFGKKCPCK();
		}
		else
		{
			itemID = 1;
		}
	}

	public virtual void IPFPANJBHLI(ItemInstance DNLMCHDOMOK)
	{
	}

	public static ItemInstanceMessage FLMKECCNFJL(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public ItemInstance IHBKMGFGGNE()
	{
		Item item = ItemDatabaseAccessor.COEFFIHKMJG(itemID, GGBBJNBBLMF: true);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)("LE_19" + itemID + ""));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		DABKCONDNGF(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage GMEFIIOCLEC(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public ItemInstance AMOEODNHNCB()
	{
		Item item = ItemDatabaseAccessor.CPMMBEPEJLO(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)("<br/>System Memory Size: " + itemID + "Quarry"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		CLKJIIEBJHP(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage CDIJCFCJPBO(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public static ItemInstanceMessage MLLIDFOGGMA(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public virtual void JCGFNDPNECL(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void BHHFOCMADCB(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void ADCEHKCCGGA(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void NCDINEHBMLN(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.PHGLMBIEOMK(), null))
		{
			itemID = (short)DNLMCHDOMOK.KNFNJFFCFNO().IMCJPECAAPC();
		}
		else
		{
			itemID = 0;
		}
	}

	public virtual void GANHKNLABHO(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.MLBOMGHINCA(DNLMCHDOMOK.AFOACBIHNCL(), null))
		{
			itemID = (short)DNLMCHDOMOK.PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false);
		}
		else
		{
			itemID = 0;
		}
	}

	public virtual void CLKJIIEBJHP(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void FHNMEAPAPMB(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.AFOACBIHNCL(), null))
		{
			itemID = (short)DNLMCHDOMOK.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false);
		}
		else
		{
			itemID = 0;
		}
	}

	public ItemInstance ANMBPDJLNFN()
	{
		Item item = ItemDatabaseAccessor.GetItem(itemID);
		if (Item.NGIIPJDAMGP(item, null))
		{
			Debug.Log((object)("Could not find item with id: " + itemID + " in the database!"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		BNBJFAHIMNH(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage IOIKGLFJPMO(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public virtual void PIMGHEIFHAB(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void MCJHPNFCFPE(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.AFOACBIHNCL(), null))
		{
			itemID = (short)DNLMCHDOMOK.PHGLMBIEOMK().CIGFGKKCPCK();
		}
		else
		{
			itemID = 0;
		}
	}

	public virtual void GOJHJAKECGG(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.PHGLMBIEOMK(), null))
		{
			itemID = (short)DNLMCHDOMOK.LHBPOPOIFLE().JGHNDJBCFAJ(DAINLFIMLIH: false);
		}
		else
		{
			itemID = 0;
		}
	}

	public virtual void GBDMCNEMPAD(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void HAIGBPBFLPB(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void IJBBCBKBNAN(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.KNFNJFFCFNO(), null))
		{
			itemID = (short)DNLMCHDOMOK.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false);
		}
		else
		{
			itemID = 0;
		}
	}

	public ItemInstance JBOIMLBMHFE()
	{
		Item item = ItemDatabaseAccessor.AFOACBIHNCL(itemID);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)("Items/item_name_702" + itemID + "OnlinePlayer"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		DCPKDNONFHF(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage IBFCLBLFNMF(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public ItemInstance ENBNOJPJHHL()
	{
		Item item = ItemDatabaseAccessor.CPMMBEPEJLO(itemID);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)("Profit" + itemID + "DisableNPC"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		CCNAFGIHKDH(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage KBCDOPMGOAM(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public virtual void IPEEHGAKHPP(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.PHGLMBIEOMK(), null))
		{
			itemID = (short)DNLMCHDOMOK.KNFNJFFCFNO().JDJGFAACPFC();
		}
		else
		{
			itemID = 0;
		}
	}

	public virtual void PLCNECPFJJC(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void CDJNABNFFCA(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void FOHHKGJFJAE(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.MLBOMGHINCA(DNLMCHDOMOK.PHGLMBIEOMK(), null))
		{
			itemID = (short)DNLMCHDOMOK.KNFNJFFCFNO().CIGFGKKCPCK();
		}
		else
		{
			itemID = 0;
		}
	}

	public ItemInstance NMELFMAKGDK()
	{
		Item item = ItemDatabaseAccessor.GetItem(itemID);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)("Cat" + itemID + "ReceiveStartTeleport"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		BIMNEHPIONK(itemInstance);
		return itemInstance;
	}

	public ItemInstance BFKEPBIDNBM()
	{
		Item item = ItemDatabaseAccessor.EABMGELAAPG(itemID);
		if (Item.EKMFELLJHFG(item, null))
		{
			Debug.Log((object)(" " + itemID + " not found in OnlineEventsManager."));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		BNBJFAHIMNH(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage IFJDHKMBDBJ(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public virtual void MFOMFFPIKHG(ItemInstance DNLMCHDOMOK)
	{
	}

	public virtual void CCNAFGIHKDH(ItemInstance DNLMCHDOMOK)
	{
	}

	public ItemInstance NDDHBKAJNMA()
	{
		Item item = ItemDatabaseAccessor.AFOACBIHNCL(itemID);
		if (Item.EKMFELLJHFG(item, null))
		{
			Debug.Log((object)("talentRye" + itemID + "Welcome to {0}!"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		CCNAFGIHKDH(itemInstance);
		return itemInstance;
	}

	public ItemInstance OJJNMENBHNI()
	{
		Item item = ItemDatabaseAccessor.CPMMBEPEJLO(itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		if (Item.EKGNIODFJCO(item, null))
		{
			Debug.Log((object)("/lock: " + itemID + ""));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		MFOMFFPIKHG(itemInstance);
		return itemInstance;
	}

	public virtual void DCPKDNONFHF(ItemInstance DNLMCHDOMOK)
	{
	}

	public ItemInstance JJFKOPICIHJ()
	{
		Item item = ItemDatabaseAccessor.COEFFIHKMJG(itemID, GGBBJNBBLMF: true);
		if (Item.EKGNIODFJCO(item, null))
		{
			Debug.Log((object)("UISelectGamepad" + itemID + ""));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		JCGFNDPNECL(itemInstance);
		return itemInstance;
	}

	public virtual void ONIOCPCJHNO(ItemInstance DNLMCHDOMOK)
	{
	}

	public ItemInstance BBELGEBEBCD()
	{
		Item item = ItemDatabaseAccessor.INJBNHPGCIJ(itemID);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)("ExampleScripted" + itemID + ")"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		PIMGHEIFHAB(itemInstance);
		return itemInstance;
	}

	public ItemInstance OCNJKFGMFFK()
	{
		Item item = ItemDatabaseAccessor.COEFFIHKMJG(itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.Log((object)("Hiding Keyboard " + itemID + ""));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		CLKJIIEBJHP(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage JFAMENPEDBK(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public virtual void CPGKEDLBPGM(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.MLBOMGHINCA(DNLMCHDOMOK.KNFNJFFCFNO(), null))
		{
			itemID = (short)DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC();
		}
		else
		{
			itemID = 1;
		}
	}

	public virtual void KCKJBCAIIGH(ItemInstance DNLMCHDOMOK)
	{
	}

	public static ItemInstanceMessage PILFFIHLILC(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public static ItemInstanceMessage DMMOPDLFLOP(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public ItemInstance LDFNHFAOHLB()
	{
		Item item = ItemDatabaseAccessor.INJBNHPGCIJ(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		if (Item.EKGNIODFJCO(item, null))
		{
			Debug.Log((object)("quest_description_" + itemID + "ReceivePipePuzzle"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		CCNAFGIHKDH(itemInstance);
		return itemInstance;
	}

	public ItemInstance MJINGJBMAIE()
	{
		Item item = ItemDatabaseAccessor.EABMGELAAPG(itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		if (Item.EKGNIODFJCO(item, null))
		{
			Debug.Log((object)("Items/item_name_1116" + itemID + "Dialogue System/Conversation/NeutralInTavern/Entry/4/Dialogue Text"));
			return null;
		}
		ItemInstance itemInstance = item.JMDALJBNFML();
		PLCNECPFJJC(itemInstance);
		return itemInstance;
	}

	public static ItemInstanceMessage EEGBOHMJMEI(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public static ItemInstanceMessage KNINCKODMEM(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance gCJPFFNGCJA)
		{
			return new FoodInstanceMessage(gCJPFFNGCJA);
		}
		if (DNLMCHDOMOK is BirdInstance cCDEPALBABD)
		{
			return new BirdInstanceMessage(cCDEPALBABD);
		}
		if (DNLMCHDOMOK is PhaseItemInstance lGFLFFGGBDK)
		{
			return new PhaseItemInstanceMessage(lGFLFFGGBDK);
		}
		if (DNLMCHDOMOK is AnimalInstance eCMCBNFLHCI)
		{
			return new AnimalInstanceMessage(eCMCBNFLHCI);
		}
		return new ItemInstanceMessage(DNLMCHDOMOK);
	}

	public virtual void NIMBNNHAMHA(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.FKLOBGBIHLB(DNLMCHDOMOK.PHGLMBIEOMK(), null))
		{
			itemID = (short)DNLMCHDOMOK.LHBPOPOIFLE().JPNFKDMFKMC();
		}
		else
		{
			itemID = 1;
		}
	}

	public ItemInstanceMessage()
	{
	}

	public virtual void BIMNEHPIONK(ItemInstance DNLMCHDOMOK)
	{
	}
}
