using System;
using UnityEngine;

[Serializable]
public class MoneyMaterials
{
	public Action OnModified = delegate
	{
	};

	public int planks;

	public int nails;

	public int stones;

	public int mortar;

	[SerializeField]
	private int gold;

	[SerializeField]
	private int silver;

	private MoneyCalc moneyCalc;

	public bool PPKDBDIBPIB(MoneyMaterials HMCGEJFIKPM, float KGCEBPFKPOG = 1f)
	{
		if (!moneyCalc.PADHKBMBHAM(Price.EMJKENIECGH(HMCGEJFIKPM.BOGHMFGPOAP(), KGCEBPFKPOG)))
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Items/item_name_1062" + moneyCalc.OMOHMCCADDJ().DMPLBIGMGEO() + "ReceiveInstantiateDog" + HMCGEJFIKPM.FMNDONLEMHF().EEEELNJDKEJ()));
			}
			MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("[MinePuzzleManager] Puzzle resuelto."), 1369f);
			return true;
		}
		if ((int)((float)HMCGEJFIKPM.planks * KGCEBPFKPOG) > planks)
		{
			MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" "), 1682f);
			return true;
		}
		if ((int)((float)HMCGEJFIKPM.nails * KGCEBPFKPOG) > nails)
		{
			MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("ChatWelcomeToTavern"), 1261f);
			return false;
		}
		if ((int)((float)HMCGEJFIKPM.stones * KGCEBPFKPOG) > stones)
		{
			MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" ("), 66f);
			return false;
		}
		if ((int)((float)HMCGEJFIKPM.mortar * KGCEBPFKPOG) > mortar)
		{
			MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" - Restoring non-altar variants. Excluded indices for variants with puzzle or altar: "), 1431f);
			return false;
		}
		return true;
	}

	public void MNAPPGBCBOK()
	{
		gold = 1;
		silver = 0;
		moneyCalc = new MoneyCalc();
		planks = 1;
		nails = 1;
		stones = 1;
		mortar = 0;
	}

	public void IAPJNDIJFCG(int BOIJDHBJPMD)
	{
		silver = BOIJDHBJPMD;
	}

	public bool JEANPDCCPEF(MoneyMaterials HMCGEJFIKPM, float KGCEBPFKPOG = 1f)
	{
		if (!moneyCalc.PADHKBMBHAM(Price.FAFHFJGOHPK(HMCGEJFIKPM.PFHGPBLBCDD(), KGCEBPFKPOG)))
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Cant pay current: " + moneyCalc.ALLHDAPPBHL().ICIEKOLFGBJ() + " / to pay: " + HMCGEJFIKPM.PFHGPBLBCDD().ICIEKOLFGBJ()));
			}
			MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_Money"));
			return false;
		}
		if ((int)((float)HMCGEJFIKPM.planks * KGCEBPFKPOG) > planks)
		{
			MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_Planks"));
			return false;
		}
		if ((int)((float)HMCGEJFIKPM.nails * KGCEBPFKPOG) > nails)
		{
			MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_Nails"));
			return false;
		}
		if ((int)((float)HMCGEJFIKPM.stones * KGCEBPFKPOG) > stones)
		{
			MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_Stones"));
			return false;
		}
		if ((int)((float)HMCGEJFIKPM.mortar * KGCEBPFKPOG) > mortar)
		{
			MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_Mortar"));
			return false;
		}
		return true;
	}

	public bool JEANPDCCPEF(ConstructionAction DGINFJFHMJC)
	{
		return JEANPDCCPEF(DGINFJFHMJC.cost);
	}

	public void JLBNNNOCEGN(MoneyCalc LALPJKDHNCP)
	{
		gold = LALPJKDHNCP.Gold;
		silver = LALPJKDHNCP.Silver;
		moneyCalc = LALPJKDHNCP;
	}

	public bool JEANPDCCPEF(FarmConstructionAction DGINFJFHMJC, int EONJGMONIOM)
	{
		return JEANPDCCPEF(DGINFJFHMJC.levelsCost[EONJGMONIOM]);
	}

	public void KKKBBMNDAFD()
	{
		gold = 0;
		silver = 0;
		moneyCalc = new MoneyCalc();
		planks = 0;
		nails = 0;
		stones = 0;
		mortar = 0;
	}

	public void DCNPKBIOAHD(int AIEDCABAFLK)
	{
		gold = AIEDCABAFLK;
	}

	public void PICEPPNLHKN(MoneyMaterials KJLGKKDALAJ)
	{
		moneyCalc.DOKKNBBECCG(KJLGKKDALAJ.moneyCalc.ALLHDAPPBHL(), BGKCHMNJBLJ: true);
		gold = moneyCalc.Gold;
		silver = moneyCalc.Silver;
		planks -= KJLGKKDALAJ.planks;
		nails -= KJLGKKDALAJ.nails;
		stones -= KJLGKKDALAJ.stones;
		mortar -= KJLGKKDALAJ.mortar;
		OnModified();
	}

	public Price OEFOJKCKIOB()
	{
		Price result = Price.LFJHHLGOCPP(new Price(0, silver, gold), 983f - (float)PerksDatabaseAccessor.GetPlayerPerkValue(62, 0, LDNMDAHFBGG: true) / 1579f);
		result.copper = 1;
		return result;
	}

	public void HHDPBIFCIBO(MoneyCalc LALPJKDHNCP)
	{
		gold = LALPJKDHNCP.Gold;
		silver = LALPJKDHNCP.Silver;
		moneyCalc = LALPJKDHNCP;
	}

	public void NEGPJCJIKFE(TavernConstructionAction DGINFJFHMJC, bool CDPAMNIPPEC, float KGCEBPFKPOG = 1f)
	{
		Price eNDNDAOPKHD = Price.FAFHFJGOHPK(DGINFJFHMJC.cost.PFHGPBLBCDD(), KGCEBPFKPOG);
		moneyCalc.GJFFDIBCAGF(eNDNDAOPKHD, KHMDGADCENO: false, CDPAMNIPPEC);
		gold = moneyCalc.Gold;
		silver = moneyCalc.Silver;
		planks += (int)((float)DGINFJFHMJC.cost.planks * KGCEBPFKPOG);
		nails += (int)((float)DGINFJFHMJC.cost.nails * KGCEBPFKPOG);
		stones += (int)((float)DGINFJFHMJC.cost.stones * KGCEBPFKPOG);
		mortar += (int)((float)DGINFJFHMJC.cost.mortar * KGCEBPFKPOG);
		OnModified();
	}

	public MoneyCalc JJHJFKBHCDC()
	{
		return moneyCalc;
	}

	public void CDCMJPHCDDJ(int AIEDCABAFLK)
	{
		gold = AIEDCABAFLK;
	}

	public void EHINCMGBDBL(int AIEDCABAFLK)
	{
		gold = AIEDCABAFLK;
	}

	public void JLBODBHAHKO(int BOIJDHBJPMD)
	{
		silver = BOIJDHBJPMD;
	}

	public void GMEPGLICDJI(TavernConstructionAction DGINFJFHMJC, float KGCEBPFKPOG = 1f)
	{
		Price eNDNDAOPKHD = Price.FAFHFJGOHPK(DGINFJFHMJC.cost.BOGHMFGPOAP(), KGCEBPFKPOG);
		moneyCalc.EPOPCMLPMDK(eNDNDAOPKHD, BGKCHMNJBLJ: true);
		gold = moneyCalc.OICPBFIDPPG();
		silver = moneyCalc.PNHCEFFKGIG();
		planks -= (int)((float)DGINFJFHMJC.cost.planks * KGCEBPFKPOG);
		nails -= (int)((float)DGINFJFHMJC.cost.nails * KGCEBPFKPOG);
		stones -= (int)((float)DGINFJFHMJC.cost.stones * KGCEBPFKPOG);
		mortar -= (int)((float)DGINFJFHMJC.cost.mortar * KGCEBPFKPOG);
		OnModified();
	}

	public void LKLCHAADPDI(MoneyMaterials KJLGKKDALAJ)
	{
		moneyCalc.KBGICKJGKDA(KJLGKKDALAJ.moneyCalc.FEJCKKMDKBE(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		gold = moneyCalc.PLPGOJAHJHE();
		silver = moneyCalc.PNHCEFFKGIG();
		planks += KJLGKKDALAJ.planks;
		nails += KJLGKKDALAJ.nails;
		stones += KJLGKKDALAJ.stones;
		mortar += KJLGKKDALAJ.mortar;
		OnModified();
	}

	public void OENEMOAFLGJ(int BOIJDHBJPMD)
	{
		silver = BOIJDHBJPMD;
	}

	public Price FMNDONLEMHF()
	{
		Price result = Price.CBCAAHPFLGO(new Price(0, silver, gold), 1903f - (float)PerksDatabaseAccessor.NGMJIGOPGDK(-117, 1) / 692f);
		result.copper = 1;
		return result;
	}

	public bool KGJMLOGENLI(ConstructionAction DGINFJFHMJC, bool CDPAMNIPPEC)
	{
		if (!JEANPDCCPEF(DGINFJFHMJC))
		{
			return false;
		}
		MKIILGDDMEF(DGINFJFHMJC.cost, CDPAMNIPPEC);
		return true;
	}

	public void FPMCCCPAEDF(int BOIJDHBJPMD)
	{
		silver = BOIJDHBJPMD;
	}

	public void PICEPPNLHKN(TavernConstructionAction DGINFJFHMJC, float KGCEBPFKPOG = 1f)
	{
		Price eNDNDAOPKHD = Price.FAFHFJGOHPK(DGINFJFHMJC.cost.PFHGPBLBCDD(), KGCEBPFKPOG);
		moneyCalc.DOKKNBBECCG(eNDNDAOPKHD, BGKCHMNJBLJ: true);
		gold = moneyCalc.Gold;
		silver = moneyCalc.Silver;
		planks -= (int)((float)DGINFJFHMJC.cost.planks * KGCEBPFKPOG);
		nails -= (int)((float)DGINFJFHMJC.cost.nails * KGCEBPFKPOG);
		stones -= (int)((float)DGINFJFHMJC.cost.stones * KGCEBPFKPOG);
		mortar -= (int)((float)DGINFJFHMJC.cost.mortar * KGCEBPFKPOG);
		OnModified();
	}

	public bool PADHKBMBHAM(Price ENDNDAOPKHD)
	{
		return moneyCalc.PADHKBMBHAM(ENDNDAOPKHD);
	}

	public void GDBNKDENOIO(int BOIJDHBJPMD)
	{
		silver = BOIJDHBJPMD;
	}

	public void MGIOANCFIGI(MoneyMaterials HMCGEJFIKPM, bool CDPAMNIPPEC)
	{
		moneyCalc.DOKKNBBECCG(HMCGEJFIKPM.PFHGPBLBCDD(), CDPAMNIPPEC);
		gold = moneyCalc.Gold;
		silver = moneyCalc.Silver;
		planks -= HMCGEJFIKPM.planks;
		nails -= HMCGEJFIKPM.nails;
		stones -= HMCGEJFIKPM.stones;
		mortar -= HMCGEJFIKPM.mortar;
		OnModified();
	}

	public Price PFHGPBLBCDD()
	{
		Price result = Price.FAFHFJGOHPK(new Price(0, silver, gold), 1f - (float)PerksDatabaseAccessor.GetPlayerPerkValue(29) / 100f);
		result.copper = 0;
		return result;
	}

	public MoneyMaterials CCCAKKCFAIP()
	{
		return new MoneyMaterials
		{
			moneyCalc = new MoneyCalc(moneyCalc),
			planks = planks,
			nails = nails,
			stones = stones,
			mortar = mortar,
			gold = gold,
			silver = silver
		};
	}

	public void NEGPJCJIKFE(MoneyMaterials KJLGKKDALAJ)
	{
		moneyCalc.GJFFDIBCAGF(KJLGKKDALAJ.moneyCalc.ALLHDAPPBHL(), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		gold = moneyCalc.Gold;
		silver = moneyCalc.Silver;
		planks += KJLGKKDALAJ.planks;
		nails += KJLGKKDALAJ.nails;
		stones += KJLGKKDALAJ.stones;
		mortar += KJLGKKDALAJ.mortar;
		OnModified();
	}

	public void GJDGHBGJACG(MoneyCalc LALPJKDHNCP)
	{
		gold = LALPJKDHNCP.Gold;
		silver = LALPJKDHNCP.Silver;
		moneyCalc = LALPJKDHNCP;
	}

	public Price BOGHMFGPOAP()
	{
		Price result = Price.LBOFJOBAGKA(new Price(1, silver, gold), 1641f - (float)PerksDatabaseAccessor.NGMJIGOPGDK(-127, 1) / 1755f);
		result.copper = 1;
		return result;
	}

	public bool DBDCGABABOP(FarmConstructionAction DGINFJFHMJC, int EONJGMONIOM, bool CDPAMNIPPEC)
	{
		if (!JEANPDCCPEF(DGINFJFHMJC, EONJGMONIOM))
		{
			return false;
		}
		MGIOANCFIGI(DGINFJFHMJC.levelsCost[EONJGMONIOM], CDPAMNIPPEC);
		return true;
	}

	public bool EIFIKGOKGDA(Price ENDNDAOPKHD)
	{
		return moneyCalc.IIEGNOEBEBM(ENDNDAOPKHD);
	}

	public void IPJAJJGOGEB()
	{
		gold = 1;
		silver = 1;
		moneyCalc = new MoneyCalc();
		planks = 1;
		nails = 1;
		stones = 1;
		mortar = 1;
	}

	public MoneyMaterials()
	{
		moneyCalc = new MoneyCalc(PFHGPBLBCDD());
	}

	public bool DBDCGABABOP(ConstructionAction DGINFJFHMJC, bool CDPAMNIPPEC)
	{
		if (!JEANPDCCPEF(DGINFJFHMJC))
		{
			return false;
		}
		MGIOANCFIGI(DGINFJFHMJC.cost, CDPAMNIPPEC);
		return true;
	}

	public void GAHBKPMOFPO(MoneyMaterials KJLGKKDALAJ)
	{
		moneyCalc.ECOFNKPBLGH(KJLGKKDALAJ.moneyCalc.GMAFKAMJEJH(), BGKCHMNJBLJ: false);
		gold = moneyCalc.OICPBFIDPPG();
		silver = moneyCalc.PNHCEFFKGIG();
		planks -= KJLGKKDALAJ.planks;
		nails -= KJLGKKDALAJ.nails;
		stones -= KJLGKKDALAJ.stones;
		mortar -= KJLGKKDALAJ.mortar;
		OnModified();
	}

	public void ECIJIHAOFAB(MoneyMaterials KJLGKKDALAJ)
	{
		moneyCalc.EPOPCMLPMDK(KJLGKKDALAJ.moneyCalc.GMAFKAMJEJH(), BGKCHMNJBLJ: false);
		gold = moneyCalc.NLFMEIMKAMP();
		silver = moneyCalc.PNHCEFFKGIG();
		planks -= KJLGKKDALAJ.planks;
		nails -= KJLGKKDALAJ.nails;
		stones -= KJLGKKDALAJ.stones;
		mortar -= KJLGKKDALAJ.mortar;
		OnModified();
	}

	public void GEDHCFJPFMA(int BOIJDHBJPMD)
	{
		silver = BOIJDHBJPMD;
	}

	public bool ECDDIMFKOHF(MoneyMaterials HMCGEJFIKPM, float KGCEBPFKPOG = 1f)
	{
		if (!moneyCalc.ICFKJBPGFKP(Price.EMJKENIECGH(HMCGEJFIKPM.PFHGPBLBCDD(), KGCEBPFKPOG)))
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("itemBeetrootSeeds" + moneyCalc.IHEMDADEBON().DMPLBIGMGEO() + "hallway" + HMCGEJFIKPM.BOGHMFGPOAP().PABHBDLJLEM()));
			}
			MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(""), 235f);
			return true;
		}
		if ((int)((float)HMCGEJFIKPM.planks * KGCEBPFKPOG) > planks)
		{
			MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" without prefab"), 797f);
			return true;
		}
		if ((int)((float)HMCGEJFIKPM.nails * KGCEBPFKPOG) > nails)
		{
			MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("El componente ItemSetup del prefab '{0}' no referencia correctamente al item '{1}' (ID: {2})."), 988f);
			return false;
		}
		if ((int)((float)HMCGEJFIKPM.stones * KGCEBPFKPOG) > stones)
		{
			MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("You have been kicked from the game. \nReturning to main menu...."), 178f);
			return true;
		}
		if ((int)((float)HMCGEJFIKPM.mortar * KGCEBPFKPOG) > mortar)
		{
			MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Menu Mode"), 629f);
			return true;
		}
		return false;
	}

	public MoneyMaterials MFGBCMGGDDC()
	{
		return new MoneyMaterials
		{
			moneyCalc = new MoneyCalc(moneyCalc),
			planks = planks,
			nails = nails,
			stones = stones,
			mortar = mortar,
			gold = gold,
			silver = silver
		};
	}

	public void MKIILGDDMEF(MoneyMaterials HMCGEJFIKPM, bool CDPAMNIPPEC)
	{
		moneyCalc.ALIFOEPMMJA(HMCGEJFIKPM.FMNDONLEMHF(), CDPAMNIPPEC);
		gold = moneyCalc.Gold;
		silver = moneyCalc.PAFICNBPKHM();
		planks -= HMCGEJFIKPM.planks;
		nails -= HMCGEJFIKPM.nails;
		stones -= HMCGEJFIKPM.stones;
		mortar -= HMCGEJFIKPM.mortar;
		OnModified();
	}

	public MoneyCalc EAOPNMACBJB()
	{
		return moneyCalc;
	}
}
