using UnityEngine;

public class OnlinePetBowl : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		Fill,
		UnfillFood,
		UnfillWater
	}

	public PetBowl petBowl;

	public void GNPGAOAJDGK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7);
	}

	public void GOJHOCHDIPC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void GGFIJEBKJHP(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void KEMFPKGGHME(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[0] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void CNJBGPHCNII(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, BNPDMNCBJHL, AJOMICMACEJ, null);
	}

	public void GLPAOFIMMFF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4);
	}

	public void ABBNMOHKHEN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5);
	}

	public void NJOJFHGPPPB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4);
	}

	public void MGIPFIOMKHN(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BNPDMNCBJHL, AJOMICMACEJ, null, null, null, null, null, null);
	}

	public void HELFOFNALFL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4);
	}

	public void KEFBIABPACF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EHCIDEFODMJ(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BNPDMNCBJHL, AJOMICMACEJ, null, null, null);
	}

	public void DHIMCHJIKCH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 3);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		petBowl = ((Component)((Component)this).transform).GetComponent<PetBowl>();
		petBowl.onlinePetBowl = this;
	}

	public void GHAOBEFBFCP(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void JFHMJCPOEPN(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.Fill:
			petBowl.SetFilled((bool)GEMFIOKGIMC[0], (bool)GEMFIOKGIMC[1]);
			break;
		case JDBLOKANBMI.UnfillFood:
			petBowl.UnfillFood(CDPAMNIPPEC: false);
			break;
		case JDBLOKANBMI.UnfillWater:
			petBowl.UnfillWater(CDPAMNIPPEC: false);
			break;
		}
	}

	public void OCONGKDBOGI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void FMIKILGGCHA(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FCMMGBIAIBD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void HKBAFIPIOPL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void IPKNMKCGBHJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void AHDGOEPDOHM(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[0] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void LNDJLHNFMBH(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BNPDMNCBJHL, AJOMICMACEJ, null, null, null, null);
	}

	public void OGFIHJHCBCF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5);
	}

	public void NKGCGIGHEFM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void OLFKLLDFHIN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void BMGBPFNCNMA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 6);
	}

	public void BABPENJCAIM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void IOGJICFIEGG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CFECHPNKAID()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void NKOFMIGBNHJ(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, BNPDMNCBJHL, AJOMICMACEJ, null, null, null, null, null);
	}

	public void PKBMHAAMEKI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void BFALPBKFOPD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7);
	}

	public void GIMBFELCOMI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MILMGCJIBDB(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void MBCAHOBAAHN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4);
	}

	public void HFBIFDGOIDA(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void AKHAICIKDGJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void LIPBGOBFHKC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void CHEHLDKIPAC(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FNJECKKCJCM(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IHGMNCODOEJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JPLKMKNEKNI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void APECONDAIIJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MDLGEIANAOK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7);
	}

	public void HDALJGJPIOM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void FPPGHIGOLDD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void FGKBLCFGEFD(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[0] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FMDMFCKEINF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OBMLFCLHBGB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4);
	}

	public void KFHFNLIOIPO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5);
	}

	public void FADCMFLLBDH(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FLECMJNDIBJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void LNIHAFMCKDD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void LFOKKGOBPBG(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void UnfillWater()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void PPGBOMMLHON()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PMJOAKHNCDI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void NLNPPLNJMCP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void HAIBDKEHKKP(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void KCBDEHJLOGF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OFCCDCAAKCH(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[0] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void GGIMBDMAJHN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void IFPOLNLHAJF(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[0] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void JGACCGLMJBE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void GOEKLCOODEK(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IDINKMHJFAJ(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void EAECAANOKMP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void ELEMAIKDFAB(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, BNPDMNCBJHL, AJOMICMACEJ);
	}

	public void MAGMAHBEJJE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MHIHGIPMBLO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GEFJGEPHJFE(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BNPDMNCBJHL, AJOMICMACEJ);
	}

	public void KCHGIEJOJNK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void PHFOGKFKOPD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void AEKKFDBADLP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void GAHBJAKPOOD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void ALDADAEBHBG(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void MOMCCKONIAH(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[0] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void KIFACOBDDEG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void PMBLCJBNANK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void HICEDCHIBJN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void KPFCAMFGGFK(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[0] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LPKECEPPJOI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void ACFBCIHEJDJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 3);
	}

	public void MJEKEKJAADN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void LHIINAGBMBM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void IDBBCMNNJJC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void JGAFMCAPMFL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void Fill(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, BNPDMNCBJHL, AJOMICMACEJ);
	}

	public void OFEJOBHOGDN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void FONJBOEAMEP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 8);
	}

	public void GHPJOFPHGCP(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IDOCLKKDAFL(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[0] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BIAKBOKOBKB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5);
	}

	public void DAGANHFAAMI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JEOCMOMCIDF(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void GBNCJHLOMPI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void NPKAMBJHKNG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MACCOGGNNLL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 3);
	}

	public void GAPFLAFGDOD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void PJIHMGKKPBP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7);
	}

	public void LOMAENOFNOE(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void COFMNKBDOOI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void NLDJLPHMJAN(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new PetBowlMessage(this);
	}

	public void CDBKEDMACOC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void DDPOMJNMPBN(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JCAPFGLDBDL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7);
	}

	public void MPEKFGADLMM(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BNPDMNCBJHL;
		array[1] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void LGIBPODENAG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BIPDCHBNIEE(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void UnfillFood()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MOINKOOAJPD(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = BNPDMNCBJHL;
		array[0] = AJOMICMACEJ;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void LBAHHNIDEOB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}
}
