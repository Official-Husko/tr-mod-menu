using UnityEngine;

public class KyrohAnimatorController : MonoBehaviour
{
	public void PGMGAILALNH(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.River | Location.BarnInterior), 0))
		{
			KyrohNPC.JFNOOMJMHCB().inSpecialEvent = true;
			KyrohNPC.KFGKCKCDMLG().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void HBILPLGDPPH(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.River | Location.Camp | Location.BarnInterior)))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = false;
			KyrohNPC.GGFJGHHHEJC.StartConversation(0, ACMJBEGLONB);
		}
	}

	public void ADIDEDADNFH(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.River | Location.Farm | Location.FarmShop)))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = false;
			KyrohNPC.AGGAGCBAGLL().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void EDFEEEDEOKC(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.FarmShop)))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = true;
			KyrohNPC.KFGKCKCDMLG().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void HPGAHAJNHLA(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.River | Location.Camp | Location.Quarry | Location.FarmShop))
		{
			KyrohNPC.JFNOOMJMHCB().inSpecialEvent = true;
			KyrohNPC.OAPOJCODNCO().StartConversation(1, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void PJMGAIOCBNP(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = false;
			KyrohNPC.JFNOOMJMHCB().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void CPHJCPONFFF(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.River)))
		{
			KyrohNPC.JFNOOMJMHCB().inSpecialEvent = true;
			KyrohNPC.AGGAGCBAGLL().StartConversation(0, ACMJBEGLONB);
		}
	}

	public void NANDJDGEMDN(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.Camp)))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = true;
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, ACMJBEGLONB);
		}
	}

	public void HINGMIMDKLM(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = false;
			KyrohNPC.JLNBMNKJCHE().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void ALAJEKHOFEA(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.River | Location.Farm | Location.BarnInterior, 0))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = true;
			KyrohNPC.KFGKCKCDMLG().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void NMDKDBAOLNI(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior), 0))
		{
			KyrohNPC.JLNBMNKJCHE().inSpecialEvent = false;
			KyrohNPC.KADHMEPDIKM().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void GGKGCNINPFC(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop), 0))
		{
			KyrohNPC.KFGKCKCDMLG().inSpecialEvent = false;
			KyrohNPC.JLNBMNKJCHE().StartConversation(1, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void IOCHAICGNEF(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Road | Location.River | Location.FarmShop, 0))
		{
			KyrohNPC.JFNOOMJMHCB().inSpecialEvent = true;
			KyrohNPC.KADHMEPDIKM().StartConversation(1, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void GHBHMNCPABE(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.FarmShop), 0))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = false;
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, ACMJBEGLONB);
		}
	}

	public void IAJAAEAMKEA(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Quarry, 0))
		{
			KyrohNPC.JLNBMNKJCHE().inSpecialEvent = false;
			KyrohNPC.JLNBMNKJCHE().StartConversation(0, ACMJBEGLONB);
		}
	}

	public void JOFGPJAPONP(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.BarnInterior), 0))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = false;
			KyrohNPC.KADHMEPDIKM().StartConversation(1, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void PPOOEFNNGJH(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm), 0))
		{
			KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
			KyrohNPC.OAPOJCODNCO().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void FHCFPDNOHFL(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.River | Location.Farm | Location.FarmShop)))
		{
			KyrohNPC.AGGAGCBAGLL().inSpecialEvent = false;
			KyrohNPC.JFNOOMJMHCB().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void PJMGKMBBHDE(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior))
		{
			KyrohNPC.KFGKCKCDMLG().inSpecialEvent = true;
			KyrohNPC.KADHMEPDIKM().StartConversation(1, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void BJEIOOMHMHI(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Road | Location.River | Location.Camp | Location.BarnInterior, 0))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = true;
			KyrohNPC.AGGAGCBAGLL().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void ONADJEDPJHF(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.River | Location.Farm | Location.BarnInterior))
		{
			KyrohNPC.AGGAGCBAGLL().inSpecialEvent = false;
			KyrohNPC.KFGKCKCDMLG().StartConversation(0, ACMJBEGLONB);
		}
	}

	public void KECLMLIGOFA(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Farm | Location.FarmShop, 0))
		{
			KyrohNPC.KADHMEPDIKM().inSpecialEvent = false;
			KyrohNPC.KADHMEPDIKM().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void AFIBJOKIIJH(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.River | Location.Farm), 0))
		{
			KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
			KyrohNPC.JLNBMNKJCHE().StartConversation(0, ACMJBEGLONB);
		}
	}

	public void AMAPJPMLLEL(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Road | Location.Quarry | Location.BarnInterior))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = true;
			KyrohNPC.PBJDFFEFMKM().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void JBNPBMMDFKJ(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Tavern | Location.Road | Location.Farm | Location.BarnInterior, 0))
		{
			KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
			KyrohNPC.KADHMEPDIKM().StartConversation(1, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void EKAAALAOIJK(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Camp | Location.Farm | Location.BarnInterior, 0))
		{
			KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
			KyrohNPC.JLNBMNKJCHE().StartConversation(0, ACMJBEGLONB);
		}
	}

	public void IGKPJJGLCMM(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Road | Location.River | Location.Quarry, 0))
		{
			KyrohNPC.KFGKCKCDMLG().inSpecialEvent = true;
			KyrohNPC.AGGAGCBAGLL().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void MPFNCMKOCLN(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Road | Location.Camp | Location.Farm | Location.FarmShop), 0))
		{
			KyrohNPC.KFGKCKCDMLG().inSpecialEvent = false;
			KyrohNPC.PBJDFFEFMKM().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void HGBHMBCOPII(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.River | Location.BarnInterior), 0))
		{
			KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
			KyrohNPC.AGGAGCBAGLL().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void BIFNABGMIGM(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.River | Location.Camp | Location.Quarry | Location.BarnInterior, 0))
		{
			KyrohNPC.JLNBMNKJCHE().inSpecialEvent = false;
			KyrohNPC.OAPOJCODNCO().StartConversation(0, ACMJBEGLONB);
		}
	}

	public void LMOOGKJOADE(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Camp | Location.Farm | Location.BarnInterior)))
		{
			KyrohNPC.JFNOOMJMHCB().inSpecialEvent = true;
			KyrohNPC.PBJDFFEFMKM().StartConversation(0, ACMJBEGLONB);
		}
	}

	public void StartDialogue(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Forest))
		{
			KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, ACMJBEGLONB);
		}
	}

	public void BAPDHKDIKKM(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm, 0))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = false;
			KyrohNPC.JLNBMNKJCHE().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void GEJGNINJDEN(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = false;
			KyrohNPC.PBJDFFEFMKM().StartConversation(0, ACMJBEGLONB);
		}
	}

	public void NGAAOMIGMCM(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior), 0))
		{
			KyrohNPC.AGGAGCBAGLL().inSpecialEvent = false;
			KyrohNPC.KFGKCKCDMLG().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void ICEGADECOPO(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.River | Location.Farm))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = true;
			KyrohNPC.JFNOOMJMHCB().StartConversation(1, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void NOEBNLJCIFM(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Tavern | Location.Road | Location.Camp | Location.BarnInterior, 0))
		{
			KyrohNPC.KADHMEPDIKM().inSpecialEvent = true;
			KyrohNPC.OAPOJCODNCO().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void BJFGKDCKCCP(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.River | Location.Farm | Location.FarmShop), 0))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = true;
			KyrohNPC.JLNBMNKJCHE().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void OGEPOODELKH(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Quarry | Location.FarmShop), 0))
		{
			KyrohNPC.JLNBMNKJCHE().inSpecialEvent = false;
			KyrohNPC.PBJDFFEFMKM().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void HLCFAPOABMM(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Road | Location.River | Location.Camp | Location.Quarry)))
		{
			KyrohNPC.PBJDFFEFMKM().inSpecialEvent = false;
			KyrohNPC.KADHMEPDIKM().StartConversation(1, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void MBONDLAAAFM(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Road | Location.Camp | Location.Quarry | Location.Farm), 0))
		{
			KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
			KyrohNPC.KFGKCKCDMLG().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void MOJPHOHIEOC(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Camp | Location.Quarry | Location.FarmShop)))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = false;
			KyrohNPC.JLNBMNKJCHE().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void MOOPDOONLBE(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.FarmShop)))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = true;
			KyrohNPC.KFGKCKCDMLG().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void LEJCDGHLJAK(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.FarmShop, 0))
		{
			KyrohNPC.JLNBMNKJCHE().inSpecialEvent = true;
			KyrohNPC.JLNBMNKJCHE().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void AIDNEGAKNFK(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Camp), 0))
		{
			KyrohNPC.OAPOJCODNCO().inSpecialEvent = false;
			KyrohNPC.JFNOOMJMHCB().StartConversation(0, ACMJBEGLONB, FLHBPHPKIML: true);
		}
	}

	public void IBAPLJJDKLA(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			KyrohNPC.KADHMEPDIKM().inSpecialEvent = true;
			KyrohNPC.KFGKCKCDMLG().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void DOJJPBBLIHN(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior), 0))
		{
			KyrohNPC.JFNOOMJMHCB().inSpecialEvent = false;
			KyrohNPC.KADHMEPDIKM().StartConversation(1, ACMJBEGLONB);
		}
	}

	public void PEOGKGHFJIL(string ACMJBEGLONB)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Tavern | Location.River | Location.Farm | Location.BarnInterior), 0))
		{
			KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
			KyrohNPC.KFGKCKCDMLG().StartConversation(0, ACMJBEGLONB);
		}
	}
}
