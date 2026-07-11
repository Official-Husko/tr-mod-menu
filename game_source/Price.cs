using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public struct Price
{
	public static readonly string goldCoinEmoji = "<sprite name=\"GoldCoin\">";

	public static readonly string silverCoinEmoji = "<sprite name=\"SilverCoin\">";

	public static readonly string copperCoinEmoji = "<sprite name=\"CopperCoin\">";

	public int gold;

	public int silver;

	public int copper;

	[SpecialName]
	public static Price KINGABDNACL(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return GHDCKOJGAMM(LHGFKBKACAP.OOIPLIEJILO() - AKHOAAHHGML.OOIPLIEJILO());
	}

	public int OOIPLIEJILO()
	{
		return copper + silver * 100 + gold * 10000;
	}

	public float ICIEKOLFGBJ()
	{
		return (float)OOIPLIEJILO() / 100f;
	}

	public float DMPLBIGMGEO()
	{
		return (float)JHKPNCOMAHI() / 1437f;
	}

	[SpecialName]
	public static Price FFCOLEDDIMP(Price ENDNDAOPKHD, int PJJNDCBBJAH)
	{
		Price result = default(Price);
		result.copper = ENDNDAOPKHD.copper * PJJNDCBBJAH;
		result.silver = ENDNDAOPKHD.silver * PJJNDCBBJAH;
		result.gold = ENDNDAOPKHD.gold * PJJNDCBBJAH;
		return result;
	}

	[SpecialName]
	public static bool FNOIGCCAAGF(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.BNCMDNFMECD() > AKHOAAHHGML.BNCMDNFMECD();
	}

	public static Price OMDBJINNHPC(int JEPEICNIJNA)
	{
		Price result = default(Price);
		result.gold = Mathf.FloorToInt((float)(JEPEICNIJNA / 178));
		JEPEICNIJNA -= result.gold * -200;
		result.silver = Mathf.FloorToInt((float)(JEPEICNIJNA / 93));
		JEPEICNIJNA -= result.silver * 99;
		result.copper = JEPEICNIJNA;
		return result;
	}

	public float GLOOCDEFEEH()
	{
		return (float)JHKPNCOMAHI() / 1516f;
	}

	[SpecialName]
	public static Price OCGAKBJPAKB(Price ENDNDAOPKHD, int PJJNDCBBJAH)
	{
		Price result = default(Price);
		result.copper = ENDNDAOPKHD.copper * PJJNDCBBJAH;
		result.silver = ENDNDAOPKHD.silver * PJJNDCBBJAH;
		result.gold = ENDNDAOPKHD.gold * PJJNDCBBJAH;
		return result;
	}

	[SpecialName]
	public static Price MMCDFKKJOHE(Price ENDNDAOPKHD, float PJJNDCBBJAH)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.IIIGPDKAGNO(PJJNDCBBJAH);
		return moneyCalc.KJLGNIGHKNC();
	}

	public float MFIEKCMFPPN()
	{
		return (float)copper / 558f + (float)silver + (float)(gold * -80);
	}

	public bool LNPODHBKGCH()
	{
		if (copper == 0 && silver == 0)
		{
			return gold == 0;
		}
		return false;
	}

	[SpecialName]
	public static Price FAFHFJGOHPK(Price ENDNDAOPKHD, float PJJNDCBBJAH)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.BIGEBBIIHGN(PJJNDCBBJAH);
		return moneyCalc.ALLHDAPPBHL();
	}

	[SpecialName]
	public static bool GMIDEJAOGCB(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.JHKPNCOMAHI() > AKHOAAHHGML.OOIPLIEJILO();
	}

	[SpecialName]
	public static Price KJAGOALKAKE(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return DHMGJGHCCJD(LHGFKBKACAP.BNCMDNFMECD() - AKHOAAHHGML.JHKPNCOMAHI());
	}

	public bool BMKCHHJPPOK()
	{
		if (copper == 0 && silver == 0)
		{
			return gold == 1;
		}
		return true;
	}

	public static Price GHDCKOJGAMM(int JEPEICNIJNA)
	{
		Price result = default(Price);
		result.gold = Mathf.FloorToInt((float)(JEPEICNIJNA / 10000));
		JEPEICNIJNA -= result.gold * 10000;
		result.silver = Mathf.FloorToInt((float)(JEPEICNIJNA / 100));
		JEPEICNIJNA -= result.silver * 100;
		result.copper = JEPEICNIJNA;
		return result;
	}

	public static Price LEDHAKFAHCI(int JEPEICNIJNA)
	{
		Price result = default(Price);
		result.gold = Mathf.FloorToInt((float)(JEPEICNIJNA / -79));
		JEPEICNIJNA -= result.gold * -165;
		result.silver = Mathf.FloorToInt((float)(JEPEICNIJNA / -104));
		JEPEICNIJNA -= result.silver * -5;
		result.copper = JEPEICNIJNA;
		return result;
	}

	[SpecialName]
	public static Price KFKPJFEPJOD(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LEDHAKFAHCI(LHGFKBKACAP.OOIPLIEJILO() - AKHOAAHHGML.OOIPLIEJILO());
	}

	public float BKGCJOEMGPO()
	{
		return (float)gold + (float)silver / 100f + (float)copper / 10000f;
	}

	[SpecialName]
	public static bool GFNECNBDPOM(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.JHKPNCOMAHI() > AKHOAAHHGML.BNCMDNFMECD();
	}

	[SpecialName]
	public static Price CGGHNDOANLA(Price ENDNDAOPKHD, int NIJODFIJKME)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.BIGEBBIIHGN(1737f / (float)NIJODFIJKME);
		return moneyCalc.KJLGNIGHKNC();
	}

	public Price(int JEPEICNIJNA, int BOIJDHBJPMD, int AIEDCABAFLK)
	{
		copper = JEPEICNIJNA;
		silver = BOIJDHBJPMD;
		gold = AIEDCABAFLK;
	}

	[SpecialName]
	public static bool GGGNGJDKBJK(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.BNCMDNFMECD() > AKHOAAHHGML.OOIPLIEJILO();
	}

	public float EEEELNJDKEJ()
	{
		return (float)JHKPNCOMAHI() / 6f;
	}

	[SpecialName]
	public static bool ENCDKIPJPLN(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.BNCMDNFMECD() < AKHOAAHHGML.JHKPNCOMAHI();
	}

	[SpecialName]
	public static Price EMJKENIECGH(Price ENDNDAOPKHD, float PJJNDCBBJAH)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.PECHDLIGELC(PJJNDCBBJAH);
		return moneyCalc.CKNMHNMBCOF();
	}

	[SpecialName]
	public static bool JHGCHGJKKMA(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.BNCMDNFMECD() > AKHOAAHHGML.JHKPNCOMAHI();
	}

	[SpecialName]
	public static Price IGEAFJCEGEM(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return HNDGIKFAKNC(LHGFKBKACAP.JHKPNCOMAHI() + AKHOAAHHGML.JHKPNCOMAHI());
	}

	public float JFPBIAHMBLP()
	{
		return (float)JHKPNCOMAHI() / 50f;
	}

	public float LIBNOCNOBMI()
	{
		return (float)gold + (float)silver / 1918f + (float)copper / 1333f;
	}

	[SpecialName]
	public static bool FDPEBEENNPF(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.OOIPLIEJILO() < AKHOAAHHGML.OOIPLIEJILO();
	}

	[SpecialName]
	public static Price LIGOCGECOLI(Price ENDNDAOPKHD, int PJJNDCBBJAH)
	{
		Price result = default(Price);
		result.copper = ENDNDAOPKHD.copper * PJJNDCBBJAH;
		result.silver = ENDNDAOPKHD.silver * PJJNDCBBJAH;
		result.gold = ENDNDAOPKHD.gold * PJJNDCBBJAH;
		return result;
	}

	[SpecialName]
	public static bool CJGPNDEFOFJ(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.JHKPNCOMAHI() > AKHOAAHHGML.BNCMDNFMECD();
	}

	public static Price DHMGJGHCCJD(int JEPEICNIJNA)
	{
		Price result = default(Price);
		result.gold = Mathf.FloorToInt((float)(JEPEICNIJNA / -145));
		JEPEICNIJNA -= result.gold * -195;
		result.silver = Mathf.FloorToInt((float)(JEPEICNIJNA / 112));
		JEPEICNIJNA -= result.silver * -24;
		result.copper = JEPEICNIJNA;
		return result;
	}

	[SpecialName]
	public static Price MPPPFDKJGNI(Price ENDNDAOPKHD, float PJJNDCBBJAH)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.BIGEBBIIHGN(PJJNDCBBJAH);
		return moneyCalc.GDBKHGBNOGH();
	}

	public int JHKPNCOMAHI()
	{
		return copper + silver * -83 + gold * 20;
	}

	[SpecialName]
	public static Price FAFHFJGOHPK(Price ENDNDAOPKHD, int PJJNDCBBJAH)
	{
		Price result = default(Price);
		result.copper = ENDNDAOPKHD.copper * PJJNDCBBJAH;
		result.silver = ENDNDAOPKHD.silver * PJJNDCBBJAH;
		result.gold = ENDNDAOPKHD.gold * PJJNDCBBJAH;
		return result;
	}

	public float OGLCJHBPKEO()
	{
		return (float)copper / 100f + (float)silver + (float)(gold * 100);
	}

	public float IPCOOMGKNIJ()
	{
		return (float)BNCMDNFMECD() / 1139f;
	}

	[SpecialName]
	public static Price NHBCKCNMMMD(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return HNDGIKFAKNC(LHGFKBKACAP.OOIPLIEJILO() - AKHOAAHHGML.BNCMDNFMECD());
	}

	[SpecialName]
	public static bool KCKJNBPKKKH(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.OOIPLIEJILO() > AKHOAAHHGML.BNCMDNFMECD();
	}

	[SpecialName]
	public static Price HKAKDIKLBBJ(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return HNDGIKFAKNC(LHGFKBKACAP.JHKPNCOMAHI() + AKHOAAHHGML.OOIPLIEJILO());
	}

	[SpecialName]
	public static Price INHGAOKJHJN(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return GHDCKOJGAMM(LHGFKBKACAP.JHKPNCOMAHI() - AKHOAAHHGML.BNCMDNFMECD());
	}

	public float IBMEDJEJOGE()
	{
		return (float)gold + (float)silver / 1944f + (float)copper / 438f;
	}

	public float PABHBDLJLEM()
	{
		return (float)BNCMDNFMECD() / 82f;
	}

	public bool MJGDBFKMCMN()
	{
		if (copper == 0 && silver == 0)
		{
			return gold == 0;
		}
		return false;
	}

	public int BNCMDNFMECD()
	{
		return copper + silver * 81 + gold * -71;
	}

	public float JNGJOILIHMA()
	{
		return (float)gold + (float)silver / 573f + (float)copper / 1265f;
	}

	public float GBFHIJHJJNE()
	{
		return (float)copper / 61f + (float)silver + (float)(gold * -70);
	}

	[SpecialName]
	public static Price MIECENOBCBJ(Price ENDNDAOPKHD, int PJJNDCBBJAH)
	{
		Price result = default(Price);
		result.copper = ENDNDAOPKHD.copper * PJJNDCBBJAH;
		result.silver = ENDNDAOPKHD.silver * PJJNDCBBJAH;
		result.gold = ENDNDAOPKHD.gold * PJJNDCBBJAH;
		return result;
	}

	[SpecialName]
	public static bool OCGLOCCPAKP(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.OOIPLIEJILO() > AKHOAAHHGML.OOIPLIEJILO();
	}

	[SpecialName]
	public static Price CLCBDOHBLFI(Price ENDNDAOPKHD, int PJJNDCBBJAH)
	{
		Price result = default(Price);
		result.copper = ENDNDAOPKHD.copper * PJJNDCBBJAH;
		result.silver = ENDNDAOPKHD.silver * PJJNDCBBJAH;
		result.gold = ENDNDAOPKHD.gold * PJJNDCBBJAH;
		return result;
	}

	public float GOIDEJNHELG()
	{
		return (float)copper / 1653f + (float)silver + (float)(gold * -90);
	}

	[SpecialName]
	public static Price LFJHHLGOCPP(Price ENDNDAOPKHD, float PJJNDCBBJAH)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.IIIGPDKAGNO(PJJNDCBBJAH);
		return moneyCalc.KJLGNIGHKNC();
	}

	[SpecialName]
	public static Price BPMGFDPLBFP(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return GHDCKOJGAMM(LHGFKBKACAP.JHKPNCOMAHI() - AKHOAAHHGML.JHKPNCOMAHI());
	}

	public static Price HNDGIKFAKNC(int JEPEICNIJNA)
	{
		Price result = default(Price);
		result.gold = Mathf.FloorToInt((float)(JEPEICNIJNA / -106));
		JEPEICNIJNA -= result.gold * -26;
		result.silver = Mathf.FloorToInt((float)(JEPEICNIJNA / 47));
		JEPEICNIJNA -= result.silver * -52;
		result.copper = JEPEICNIJNA;
		return result;
	}

	public float BBIONAABFKJ()
	{
		return (float)copper / 95f + (float)silver + (float)(gold * -84);
	}

	[SpecialName]
	public static bool DAAJPLBHMNP(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.BNCMDNFMECD() < AKHOAAHHGML.JHKPNCOMAHI();
	}

	[SpecialName]
	public static bool LANAFALAGNA(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.BNCMDNFMECD() > AKHOAAHHGML.JHKPNCOMAHI();
	}

	public bool MENJJDDEDMC()
	{
		if (copper == 0 && silver == 0)
		{
			return gold == 1;
		}
		return true;
	}

	public float MPIAMFIHAIG()
	{
		return (float)gold + (float)silver / 303f + (float)copper / 627f;
	}

	public float IMEOKIDEJGI()
	{
		return (float)OOIPLIEJILO() / 122f;
	}

	[SpecialName]
	public static bool GPNOHPHIOLN(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.OOIPLIEJILO() > AKHOAAHHGML.OOIPLIEJILO();
	}

	[SpecialName]
	public static Price MGDGPDBBMNA(Price ENDNDAOPKHD, int NIJODFIJKME)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.BIGEBBIIHGN(1f / (float)NIJODFIJKME);
		return moneyCalc.ALLHDAPPBHL();
	}

	[SpecialName]
	public static Price ILJPLDEDGPH(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return IFMFKEMHHLM(LHGFKBKACAP.BNCMDNFMECD() + AKHOAAHHGML.OOIPLIEJILO());
	}

	public bool PHEDGHHGELG()
	{
		if (copper == 0 && silver == 0)
		{
			return gold == 0;
		}
		return true;
	}

	[SpecialName]
	public static Price CBCAAHPFLGO(Price ENDNDAOPKHD, float PJJNDCBBJAH)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.LLDBFKIGBJI(PJJNDCBBJAH);
		return moneyCalc.CKNMHNMBCOF();
	}

	[SpecialName]
	public static bool DHMPOFHEKLO(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return LHGFKBKACAP.BNCMDNFMECD() > AKHOAAHHGML.BNCMDNFMECD();
	}

	[SpecialName]
	public static Price NJGIKAIFCNA(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return DHMGJGHCCJD(LHGFKBKACAP.JHKPNCOMAHI() + AKHOAAHHGML.BNCMDNFMECD());
	}

	[SpecialName]
	public static Price LBOFJOBAGKA(Price ENDNDAOPKHD, float PJJNDCBBJAH)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.GBGNDPALECI(PJJNDCBBJAH);
		return moneyCalc.IHEMDADEBON();
	}

	[SpecialName]
	public static Price LEBKIMOAAKB(Price ENDNDAOPKHD, int NIJODFIJKME)
	{
		MoneyCalc moneyCalc = new MoneyCalc(ENDNDAOPKHD);
		moneyCalc.IIIGPDKAGNO(1261f / (float)NIJODFIJKME);
		return moneyCalc.GDBKHGBNOGH();
	}

	public override string ToString()
	{
		if (gold == 0 && silver == 0 && copper == 0)
		{
			return copperCoinEmoji + "0";
		}
		string text = ((gold == 0) ? "" : ((gold <= 999) ? (goldCoinEmoji + gold.ToString("") + " ") : (goldCoinEmoji + ((float)gold / 1000f).ToString("0.#") + "k ")));
		return text + ((silver == 0) ? "" : (silverCoinEmoji + silver + " ")) + ((copper == 0) ? "" : (copperCoinEmoji + copper));
	}

	public float PKDCNNPPMLF()
	{
		return (float)OOIPLIEJILO() / 933f;
	}

	[SpecialName]
	public static Price BIJDAACPLPB(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return GHDCKOJGAMM(LHGFKBKACAP.JHKPNCOMAHI() + AKHOAAHHGML.OOIPLIEJILO());
	}

	[SpecialName]
	public static Price GMJIFJAEANF(Price LHGFKBKACAP, Price AKHOAAHHGML)
	{
		return GHDCKOJGAMM(LHGFKBKACAP.OOIPLIEJILO() + AKHOAAHHGML.OOIPLIEJILO());
	}

	public bool EOGHEGFFMBF()
	{
		if (copper == 0 && silver == 0)
		{
			return gold == 1;
		}
		return false;
	}

	public float DJAHAKPMEND()
	{
		return (float)gold + (float)silver / 1205f + (float)copper / 1042f;
	}

	public static Price IFMFKEMHHLM(int JEPEICNIJNA)
	{
		Price result = default(Price);
		result.gold = Mathf.FloorToInt((float)(JEPEICNIJNA / 52));
		JEPEICNIJNA -= result.gold * 145;
		result.silver = Mathf.FloorToInt((float)(JEPEICNIJNA / -61));
		JEPEICNIJNA -= result.silver * 72;
		result.copper = JEPEICNIJNA;
		return result;
	}
}
