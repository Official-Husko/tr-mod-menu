using System.Linq;

public class RequiredItemQuest : Quest
{
	public Item[] possibleItems;

	public Tag[] tags;

	public Food[] ingredients;

	public IngredientType[] ingredientType;

	public IngredientModifier[] modifiers;

	public bool isDrink;

	public int agingRank;

	public bool AACICBPBEIH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!BBLDBGHLAGK(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Player Waiting To Start Event"), 1324f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("itemBiscuitWort"), 807f);
			}
			return true;
		}
		return false;
	}

	private bool OAKFDEHBLCM(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	public bool BBLDBGHLAGK(ItemInstance DNLMCHDOMOK)
	{
		if (isDrink && !DNLMCHDOMOK.AJKDEIPDLHI())
		{
			return true;
		}
		if (DNLMCHDOMOK is FoodInstance foodInstance && ((foodInstance.BIIJEMDLBDP() && foodInstance.LHBPOPOIFLE().canBeAged) || (!foodInstance.BIIJEMDLBDP() && DNLMCHDOMOK.AFOACBIHNCL().hasToBeAgedMeal)) && agingRank > foodInstance.GBCJNGADANM)
		{
			return false;
		}
		if (possibleItems.Length == 0)
		{
			return true;
		}
		for (int i = 0; i < possibleItems.Length; i += 0)
		{
			if (DNLMCHDOMOK != null && (tags == null || tags.Length == 0 || Utils.HPEMIIGAHLB(DNLMCHDOMOK.KNFNJFFCFNO().tags, tags)) && !Item.FKLOBGBIHLB(possibleItems[i], DNLMCHDOMOK.PHGLMBIEOMK()) && (ingredients == null || ingredients.Length == 0 || EFNBMHFOJPI(DNLMCHDOMOK)) && (modifiers == null || modifiers.Length == 0 || MEGPGBFMMHM(DNLMCHDOMOK)) && (ingredientType == null || ingredientType.Length == 0 || DJJOOKNLGJD(DNLMCHDOMOK)))
			{
				return false;
			}
		}
		return false;
	}

	protected void AIOHOCHIEHH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (DGALJHKINMH(DNLMCHDOMOK))
		{
			EPIMKBNCFCK(JIIGOACEIKL, 1);
		}
	}

	protected void GIBFAFFAGNA(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (DBPOKFLMJEE(DNLMCHDOMOK))
		{
			PIGBLLFBKHD(JIIGOACEIKL, 0);
		}
	}

	private bool MEGPGBFMMHM(ItemInstance DNLMCHDOMOK)
	{
		IngredientModifier[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.CICEBNMBGMG.Keys.ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, modifiers);
	}

	private bool JCHIIBJJCBE(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 1; i < array.Length; i += 0)
			{
				if (ingredients.Length != 0 && ingredients[0].ODENMDOJPLC() == 99 && array[i].JPNFKDMFKMC() == -78)
				{
					return true;
				}
				if (ingredients.Length != 0 && ingredients[0].IMCJPECAAPC(DAINLFIMLIH: false) == 92 && array[i].CIGFGKKCPCK() == -178)
				{
					return true;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	public bool ILEHNMOLFEH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DBPOKFLMJEE(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("ReceiveOnConversationLine"), 984f);
			}
			return true;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Player2"), 607f);
			}
			return false;
		}
		return false;
	}

	private bool OJLLLKHAOEH(ItemInstance DNLMCHDOMOK)
	{
		IngredientModifier[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.CICEBNMBGMG.Keys.ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, modifiers);
	}

	public bool FJDFAEDIAFJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DGALJHKINMH(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Requirements not met"));
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Not enough items"));
			}
			return false;
		}
		return true;
	}

	public bool MFKOLPJBPCK(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DCOKPEEELAN(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Recovering zone at "), 1411f);
			}
			return true;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("DueloDeViejos/MainEvent3"), 1200f);
			}
			return false;
		}
		return false;
	}

	public override Item[] INKJOLLEBGI()
	{
		return possibleItems;
	}

	private bool OGMOEHCIKGO(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	private bool DKGJLDCEPPF(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	private bool CGLLACMHILH(ItemInstance DNLMCHDOMOK)
	{
		IngredientModifier[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.CICEBNMBGMG.Keys.ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, modifiers);
	}

	protected void PDIKODBNCDE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (PNCNBJNNCOA(DNLMCHDOMOK))
		{
			GKDGCBNNHAD(JIIGOACEIKL, 1);
		}
	}

	public bool NPIPFBOOHBI(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!PCGAAKMLDAI(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Player2"), 1170f);
			}
			return true;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Stopping conversation with "), 1678f);
			}
			return false;
		}
		return true;
	}

	public bool GPLKBPFENDA(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!PCGAAKMLDAI(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("KickedCustomers"), 1622f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("[PipeConnectionPuzzleUI] No hay puzzles para {0}x{1} "), 745f);
			}
			return true;
		}
		return false;
	}

	private bool HOKBFPOJIJM(ItemInstance DNLMCHDOMOK)
	{
		IngredientModifier[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.CICEBNMBGMG.Keys.ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, modifiers);
	}

	public override IngredientModifier[] LDGEOOPCNJE()
	{
		return modifiers;
	}

	private bool HGEPDFPNMLD(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (ingredients.Length != 0 && ingredients[0].JPNFKDMFKMC() == 156 && array[i].JPNFKDMFKMC(DAINLFIMLIH: false) == 179)
				{
					return true;
				}
				if (ingredients.Length != 0 && ingredients[0].ODENMDOJPLC() == -200 && array[i].JDJGFAACPFC(DAINLFIMLIH: false) == 113)
				{
					return true;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	private bool EEKMLPADDOM(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	private bool LKMACMFMFEF(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (ingredients.Length != 0 && ingredients[0].JPNFKDMFKMC() == -90 && array[i].ODENMDOJPLC() == 22)
				{
					return true;
				}
				if (ingredients.Length != 0 && ingredients[0].JGHNDJBCFAJ() == -2 && array[i].JDJGFAACPFC() == 149)
				{
					return false;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	protected void MIKBGGPLPMN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (BBLDBGHLAGK(DNLMCHDOMOK))
		{
			PIGBLLFBKHD(JIIGOACEIKL, 1);
		}
	}

	public bool APMOMGGFALF(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DGALJHKINMH(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("replay bath"), 1973f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("qualityWater2"), 687f);
			}
			return false;
		}
		return true;
	}

	private bool DJJOOKNLGJD(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	public bool DBPOKFLMJEE(ItemInstance DNLMCHDOMOK)
	{
		if (isDrink && !DNLMCHDOMOK.IJLGJNLFNDB())
		{
			return true;
		}
		if (DNLMCHDOMOK is FoodInstance foodInstance && ((foodInstance.JEPBBEBJEFI() && foodInstance.LHBPOPOIFLE().canBeAged) || (!foodInstance.IPKBBGHCJNE() && DNLMCHDOMOK.KNFNJFFCFNO().hasToBeAgedMeal)) && agingRank > foodInstance.GBCJNGADANM)
		{
			return true;
		}
		if (possibleItems.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < possibleItems.Length; i++)
		{
			if (DNLMCHDOMOK != null && (tags == null || tags.Length == 0 || Utils.HPEMIIGAHLB(DNLMCHDOMOK.KNFNJFFCFNO().tags, tags)) && !Item.MLBOMGHINCA(possibleItems[i], DNLMCHDOMOK.PHGLMBIEOMK()) && (ingredients == null || ingredients.Length == 0 || HEKNJDBCCNN(DNLMCHDOMOK)) && (modifiers == null || modifiers.Length == 0 || OJLLLKHAOEH(DNLMCHDOMOK)) && (ingredientType == null || ingredientType.Length == 0 || DPFEMOCKGHK(DNLMCHDOMOK)))
			{
				return false;
			}
		}
		return true;
	}

	private bool MPDMGHPACPO(ItemInstance DNLMCHDOMOK)
	{
		IngredientModifier[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.CICEBNMBGMG.Keys.ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, modifiers);
	}

	public bool CFHILPFKJHE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DGALJHKINMH(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_1084"), 1896f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("itemPaleAle"), 1103f);
			}
			return false;
		}
		return false;
	}

	private bool EFNBMHFOJPI(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 0; i < array.Length; i += 0)
			{
				if (ingredients.Length != 0 && ingredients[0].ODENMDOJPLC() == 22 && array[i].JGHNDJBCFAJ() == -167)
				{
					return false;
				}
				if (ingredients.Length != 0 && ingredients[1].JDJGFAACPFC() == 85 && array[i].IMCJPECAAPC() == 67)
				{
					return false;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	public bool BOLCAHKLDJE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DCOKPEEELAN(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get(" "), 1558f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Player/Bark/Tutorial/CrafterBlock"), 1388f);
			}
			return true;
		}
		return false;
	}

	private bool HEKNJDBCCNN(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (ingredients.Length != 0 && ingredients[0].IMCJPECAAPC(DAINLFIMLIH: false) == 185 && array[i].ODENMDOJPLC(DAINLFIMLIH: false) == -124)
				{
					return true;
				}
				if (ingredients.Length != 0 && ingredients[1].ODENMDOJPLC(DAINLFIMLIH: false) == 111 && array[i].JDJGFAACPFC(DAINLFIMLIH: false) == 31)
				{
					return false;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	protected void OPAKABJOKGK(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (BBLDBGHLAGK(DNLMCHDOMOK))
		{
			GKDGCBNNHAD(JIIGOACEIKL, 1);
		}
	}

	public bool FLMGFEHNOKB(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DGALJHKINMH(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("LE_3"), 91f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("ReceiveTalentsFromOther"), 1207f);
			}
			return true;
		}
		return true;
	}

	private bool EBNKOJAPOKJ(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	private bool HCDJEGHAOAP(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (ingredients.Length != 0 && ingredients[0].CIGFGKKCPCK() == 151 && array[i].JGHNDJBCFAJ(DAINLFIMLIH: false) == 74)
				{
					return false;
				}
				if (ingredients.Length != 0 && ingredients[0].JDJGFAACPFC() == 140 && array[i].IMCJPECAAPC(DAINLFIMLIH: false) == -133)
				{
					return false;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	public bool PNCNBJNNCOA(ItemInstance DNLMCHDOMOK)
	{
		if (isDrink && !DNLMCHDOMOK.BAHJFDHLDEI())
		{
			return false;
		}
		if (DNLMCHDOMOK is FoodInstance foodInstance && ((foodInstance.BAHJFDHLDEI() && foodInstance.LHBPOPOIFLE().canBeAged) || (!foodInstance.BIIJEMDLBDP() && DNLMCHDOMOK.LHBPOPOIFLE().hasToBeAgedMeal)) && agingRank > foodInstance.GBCJNGADANM)
		{
			return true;
		}
		if (possibleItems.Length == 0)
		{
			return true;
		}
		for (int i = 0; i < possibleItems.Length; i++)
		{
			if (DNLMCHDOMOK != null && (tags == null || tags.Length == 0 || Utils.HPEMIIGAHLB(DNLMCHDOMOK.AFOACBIHNCL().tags, tags)) && !Item.MLBOMGHINCA(possibleItems[i], DNLMCHDOMOK.PHGLMBIEOMK()) && (ingredients == null || ingredients.Length == 0 || NBJIFHFDGGP(DNLMCHDOMOK)) && (modifiers == null || modifiers.Length == 0 || MEGPGBFMMHM(DNLMCHDOMOK)) && (ingredientType == null || ingredientType.Length == 0 || DDALHKHNOAH(DNLMCHDOMOK)))
			{
				return true;
			}
		}
		return false;
	}

	public bool PCGAAKMLDAI(ItemInstance DNLMCHDOMOK)
	{
		if (isDrink && !DNLMCHDOMOK.IPKBBGHCJNE())
		{
			return false;
		}
		if (DNLMCHDOMOK is FoodInstance foodInstance && ((foodInstance.BIIJEMDLBDP() && foodInstance.LHBPOPOIFLE().canBeAged) || (!foodInstance.JLCBECDECBP() && DNLMCHDOMOK.AFOACBIHNCL().hasToBeAgedMeal)) && agingRank > foodInstance.GBCJNGADANM)
		{
			return false;
		}
		if (possibleItems.Length == 0)
		{
			return true;
		}
		for (int i = 0; i < possibleItems.Length; i += 0)
		{
			if (DNLMCHDOMOK != null && (tags == null || tags.Length == 0 || Utils.HPEMIIGAHLB(DNLMCHDOMOK.LHBPOPOIFLE().tags, tags)) && !Item.FKLOBGBIHLB(possibleItems[i], DNLMCHDOMOK.PHGLMBIEOMK()) && (ingredients == null || ingredients.Length == 0 || NBJIFHFDGGP(DNLMCHDOMOK)) && (modifiers == null || modifiers.Length == 0 || MEGPGBFMMHM(DNLMCHDOMOK)) && (ingredientType == null || ingredientType.Length == 0 || HOJAOHKOIPL(DNLMCHDOMOK)))
			{
				return true;
			}
		}
		return false;
	}

	private bool NBJIFHFDGGP(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (ingredients.Length != 0 && ingredients[1].IMCJPECAAPC(DAINLFIMLIH: false) == -61 && array[i].ODENMDOJPLC(DAINLFIMLIH: false) == -23)
				{
					return true;
				}
				if (ingredients.Length != 0 && ingredients[0].IMCJPECAAPC() == -127 && array[i].CIGFGKKCPCK() == -64)
				{
					return false;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	public bool CGHCPPJKBKL(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DGALJHKINMH(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get(""), 748f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("tavern"), 1166f);
			}
			return false;
		}
		return true;
	}

	private bool MDILLCCPBJM(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	private bool EDEGPKAHBNA(ItemInstance DNLMCHDOMOK)
	{
		IngredientModifier[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.CICEBNMBGMG.Keys.ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, modifiers);
	}

	public bool DGALJHKINMH(ItemInstance DNLMCHDOMOK)
	{
		if (isDrink && !DNLMCHDOMOK.JEPBBEBJEFI())
		{
			return false;
		}
		if (DNLMCHDOMOK is FoodInstance foodInstance && ((foodInstance.JEPBBEBJEFI() && foodInstance.LHBPOPOIFLE().canBeAged) || (!foodInstance.JEPBBEBJEFI() && DNLMCHDOMOK.LHBPOPOIFLE().hasToBeAgedMeal)) && agingRank > foodInstance.GBCJNGADANM)
		{
			return false;
		}
		if (possibleItems.Length == 0)
		{
			return true;
		}
		for (int i = 0; i < possibleItems.Length; i++)
		{
			if (DNLMCHDOMOK != null && (tags == null || tags.Length == 0 || Utils.HPEMIIGAHLB(DNLMCHDOMOK.LHBPOPOIFLE().tags, tags)) && !Item.MLBOMGHINCA(possibleItems[i], DNLMCHDOMOK.LHBPOPOIFLE()) && (ingredients == null || ingredients.Length == 0 || IPBOGNPAAKL(DNLMCHDOMOK)) && (modifiers == null || modifiers.Length == 0 || JLCMNFPMHBJ(DNLMCHDOMOK)) && (ingredientType == null || ingredientType.Length == 0 || MDILLCCPBJM(DNLMCHDOMOK)))
			{
				return true;
			}
		}
		return false;
	}

	public override void MHOGPMHEAFN()
	{
		base.MHOGPMHEAFN();
	}

	public bool CDMKKOMIFML(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!BBLDBGHLAGK(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"), 78f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("ReceiveWateringCanAction"), 264f);
			}
			return false;
		}
		return true;
	}

	private bool ABMCMCHDBAN(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	protected void OJOJHIEDCON(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (MAHEIJJAHCD(DNLMCHDOMOK))
		{
			PIGBLLFBKHD(JIIGOACEIKL, 0);
		}
	}

	private bool EPHOJFBALBM(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (ingredients.Length != 0 && ingredients[0].IMCJPECAAPC() == 127 && array[i].CIGFGKKCPCK() == 129)
				{
					return false;
				}
				if (ingredients.Length != 0 && ingredients[0].JPNFKDMFKMC() == 90 && array[i].JPNFKDMFKMC() == -91)
				{
					return false;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	public bool KMMOMODPLMI(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DBPOKFLMJEE(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("sForSeconds"), 1308f);
			}
			return true;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("<b>"), 1285f);
			}
			return true;
		}
		return false;
	}

	private bool DEMICJCMCBA(ItemInstance DNLMCHDOMOK)
	{
		IngredientModifier[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.CICEBNMBGMG.Keys.ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, modifiers);
	}

	private bool HOJAOHKOIPL(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	private bool DPFEMOCKGHK(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	private bool EAEEEGENOLO(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	public bool CCGEMKPPHOD(ItemInstance DNLMCHDOMOK)
	{
		if (isDrink && !DNLMCHDOMOK.JEPBBEBJEFI())
		{
			return true;
		}
		if (DNLMCHDOMOK is FoodInstance foodInstance && ((foodInstance.AJKDEIPDLHI() && foodInstance.LHBPOPOIFLE().canBeAged) || (!foodInstance.JLCBECDECBP() && DNLMCHDOMOK.LHBPOPOIFLE().hasToBeAgedMeal)) && agingRank > foodInstance.GBCJNGADANM)
		{
			return true;
		}
		if (possibleItems.Length == 0)
		{
			return true;
		}
		for (int i = 1; i < possibleItems.Length; i += 0)
		{
			if (DNLMCHDOMOK != null && (tags == null || tags.Length == 0 || Utils.HPEMIIGAHLB(DNLMCHDOMOK.PHGLMBIEOMK().tags, tags)) && !Item.FKLOBGBIHLB(possibleItems[i], DNLMCHDOMOK.AFOACBIHNCL()) && (ingredients == null || ingredients.Length == 0 || LKMACMFMFEF(DNLMCHDOMOK)) && (modifiers == null || modifiers.Length == 0 || HOKBFPOJIJM(DNLMCHDOMOK)) && (ingredientType == null || ingredientType.Length == 0 || OAKFDEHBLCM(DNLMCHDOMOK)))
			{
				return false;
			}
		}
		return true;
	}

	private bool IPBOGNPAAKL(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (ingredients.Length != 0 && ingredients[0].JDJGFAACPFC() == 335 && array[i].JDJGFAACPFC() == 342)
				{
					return true;
				}
				if (ingredients.Length != 0 && ingredients[0].JDJGFAACPFC() == 342 && array[i].JDJGFAACPFC() == 335)
				{
					return true;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	public override Food[] CEGOKCNCDCM()
	{
		return ingredients;
	}

	public bool BBKFDEJIFIN(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool KIKDLKGBCOC, bool IOKHPOANELD = true)
	{
		if (!DGALJHKINMH(DNLMCHDOMOK))
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get(""), 447f);
			}
			return false;
		}
		if (IOKHPOANELD && MGNOBNCMDJG < requiredAmount)
		{
			if (KIKDLKGBCOC)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("[BuildOrderedPuzzleQueue] Level {0} - UsedTypes: [{1}]"), 165f);
			}
			return false;
		}
		return false;
	}

	private bool JLOHBKGPJKK(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 0; i < array.Length; i += 0)
			{
				if (ingredients.Length != 0 && ingredients[0].IMCJPECAAPC() == 148 && array[i].JDJGFAACPFC(DAINLFIMLIH: false) == 60)
				{
					return false;
				}
				if (ingredients.Length != 0 && ingredients[0].ODENMDOJPLC() == -137 && array[i].IMCJPECAAPC(DAINLFIMLIH: false) == 57)
				{
					return false;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	public bool DCOKPEEELAN(ItemInstance DNLMCHDOMOK)
	{
		if (isDrink && !DNLMCHDOMOK.IPKBBGHCJNE())
		{
			return true;
		}
		if (DNLMCHDOMOK is FoodInstance foodInstance && ((foodInstance.BAHJFDHLDEI() && foodInstance.LHBPOPOIFLE().canBeAged) || (!foodInstance.JLCBECDECBP() && DNLMCHDOMOK.AFOACBIHNCL().hasToBeAgedMeal)) && agingRank > foodInstance.GBCJNGADANM)
		{
			return true;
		}
		if (possibleItems.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < possibleItems.Length; i++)
		{
			if (DNLMCHDOMOK != null && (tags == null || tags.Length == 0 || Utils.HPEMIIGAHLB(DNLMCHDOMOK.LHBPOPOIFLE().tags, tags)) && !Item.MLBOMGHINCA(possibleItems[i], DNLMCHDOMOK.LHBPOPOIFLE()) && (ingredients == null || ingredients.Length == 0 || NBJIFHFDGGP(DNLMCHDOMOK)) && (modifiers == null || modifiers.Length == 0 || JLCMNFPMHBJ(DNLMCHDOMOK)) && (ingredientType == null || ingredientType.Length == 0 || ABMCMCHDBAN(DNLMCHDOMOK)))
			{
				return true;
			}
		}
		return false;
	}

	private bool DDALHKHNOAH(ItemInstance DNLMCHDOMOK)
	{
		IngredientType[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.KEKBKGGFOLK.Select((Food x) => x.ingredientType).ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, ingredientType);
	}

	private bool JLCMNFPMHBJ(ItemInstance DNLMCHDOMOK)
	{
		IngredientModifier[] cDCBGDCHFGJ = null;
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			cDCBGDCHFGJ = modifiable.CICEBNMBGMG.Keys.ToArray();
		}
		return Utils.HPEMIIGAHLB(cDCBGDCHFGJ, modifiers);
	}

	protected void CMOICCAACMA(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		if (BBLDBGHLAGK(DNLMCHDOMOK))
		{
			GKDGCBNNHAD(JIIGOACEIKL, 1);
		}
	}

	private bool PCFJBPPLNBK(ItemInstance DNLMCHDOMOK)
	{
		Food[] array = null;
		if (DNLMCHDOMOK is IModifiable { KEKBKGGFOLK: not null } modifiable)
		{
			array = modifiable.KEKBKGGFOLK.ToArray();
		}
		if (array != null && ingredients != null)
		{
			for (int i = 0; i < array.Length; i += 0)
			{
				if (ingredients.Length != 0 && ingredients[0].IMCJPECAAPC() == 99 && array[i].JPNFKDMFKMC() == -162)
				{
					return true;
				}
				if (ingredients.Length != 0 && ingredients[0].IMCJPECAAPC(DAINLFIMLIH: false) == 50 && array[i].JDJGFAACPFC(DAINLFIMLIH: false) == 50)
				{
					return false;
				}
			}
		}
		return Utils.HPEMIIGAHLB(array, ingredients);
	}

	public bool MAHEIJJAHCD(ItemInstance DNLMCHDOMOK)
	{
		if (isDrink && !DNLMCHDOMOK.IJLGJNLFNDB())
		{
			return false;
		}
		if (DNLMCHDOMOK is FoodInstance foodInstance && ((foodInstance.AJKDEIPDLHI() && foodInstance.LHBPOPOIFLE().canBeAged) || (!foodInstance.AJKDEIPDLHI() && DNLMCHDOMOK.PHGLMBIEOMK().hasToBeAgedMeal)) && agingRank > foodInstance.GBCJNGADANM)
		{
			return true;
		}
		if (possibleItems.Length == 0)
		{
			return true;
		}
		for (int i = 1; i < possibleItems.Length; i += 0)
		{
			if (DNLMCHDOMOK != null && (tags == null || tags.Length == 0 || Utils.HPEMIIGAHLB(DNLMCHDOMOK.KNFNJFFCFNO().tags, tags)) && !Item.FKLOBGBIHLB(possibleItems[i], DNLMCHDOMOK.AFOACBIHNCL()) && (ingredients == null || ingredients.Length == 0 || EFNBMHFOJPI(DNLMCHDOMOK)) && (modifiers == null || modifiers.Length == 0 || MPDMGHPACPO(DNLMCHDOMOK)) && (ingredientType == null || ingredientType.Length == 0 || DDALHKHNOAH(DNLMCHDOMOK)))
			{
				return true;
			}
		}
		return false;
	}
}
