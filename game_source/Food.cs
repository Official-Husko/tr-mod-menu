using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Food")]
public class Food : Item
{
	[Serializable]
	public struct HeldSpriteByIngredient
	{
		public CharacterSprite characterSprite;

		public Sprite colorSprite;

		public Food[] ingredients;
	}

	[Serializable]
	public struct IconIngredients
	{
		public Sprite icon;

		public Food[] ingredients;
	}

	public string mealText = "MEAL";

	public string canBeSoldText2 = "INGREDIENT";

	public bool canBeSold;

	public bool saveMainIngredient;

	public Sprite dirtySprite;

	public Sprite variantIcon;

	public Sprite requestIcon;

	public Sprite ingredientIcon;

	public bool halloweenFood;

	public bool held;

	public bool multipleHeldSprites;

	public CharacterSprite heldSprite;

	public HeldSpriteByIngredient[] heldSpritesIngredients;

	[Space(20f)]
	public IngredientModifier[] modifiers;

	public IngredientType ingredientType;

	public bool canBeUsedAsModifier = true;

	public Seed seed;

	public List<Food> ingredientsMod;

	public FoodType foodType = FoodType.Food;

	public bool canBeAged = true;

	public bool containsAlcohol;

	public IconIngredients[] iconIngredients;

	private static Price priceAux;

	private static Price finalPriceAux;

	public bool CAAPHNEBJFL()
	{
		if (ingredientType != IngredientType.Honey && ingredientType != IngredientType.Meat)
		{
			return ingredientType == (IngredientType)(-30);
		}
		return true;
	}

	public bool HFPJOINMAAF()
	{
		if (ingredientType != 0 && ingredientType != IngredientType.WhiteFish)
		{
			return ingredientType == IngredientType.None;
		}
		return true;
	}

	public bool LGOKPBPJOKE()
	{
		if (ingredientType != IngredientType.Veg && ingredientType != IngredientType.Fruit)
		{
			return ingredientType == IngredientType.Berries;
		}
		return true;
	}

	public bool GJPPNMNEHNC()
	{
		return ingredientType == (IngredientType)81;
	}

	public Price NMNEOIPJNDA(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.KMBGJEKCJFJ(JGHNDJBCFAJ(DAINLFIMLIH: false)) is Food food)
			{
				priceAux = food.MELMOIKFCLP(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.GetInstance().applyPriceModifiers)
				{
					if (Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.HNNFOOBOOGC(this))
					{
						finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)(-121))
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(4) / 668f));
					}
					if (ingredientType == IngredientType.Fruit || id == 165 || id == 163 || id == -39)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(46, 0, LDNMDAHFBGG: true) / 1759f));
					}
					if (BDAMOPBDELO())
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(94) / 1969f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.KCPCKGKKMBG((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().APOFALNJNEF(this))
			{
				finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(8, 0, LDNMDAHFBGG: true) / 491f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.KEIBNIIBKDH(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.BMDNOGNAPJJ().applyPriceModifiers && (Object)(object)Trends.FMIDAFEGDCD() != (Object)null && Trends.IJEFFMAHMCG() && Trends.KNOKBLFFNLM().APOFALNJNEF(this))
		{
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.EMJKENIECGH(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
			finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(89, 1) / 98f));
		}
		return finalPriceAux;
	}

	public bool HEPOIECBMII()
	{
		if (ingredientType != IngredientType.Hop)
		{
			return ingredientType == (IngredientType)121;
		}
		return true;
	}

	public bool FCEIJHAGKEB()
	{
		if (canBeAged)
		{
			return HOFOBPCHOOL();
		}
		return false;
	}

	public bool DOHCLLAJINJ()
	{
		if (ingredientType != IngredientType.Meat)
		{
			return ingredientType == (IngredientType)34;
		}
		return false;
	}

	public virtual Price PNKLJHHODFF(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.HMNLCFAENIH(Price.LFJHHLGOCPP(price, 777f / Money.KOJHKCGIINL().newFoodPriceBalance));
	}

	public bool NANDHLHCLNB()
	{
		if (ingredientType != IngredientType.Fruit && ingredientType != IngredientType.Grain)
		{
			return ingredientType == (IngredientType)(-117);
		}
		return false;
	}

	public bool CLOMGGKCGGO()
	{
		return ingredientType == (IngredientType)114;
	}

	public bool LJLBHCPLBML()
	{
		return ingredientType == (IngredientType)89;
	}

	public virtual Price KKNDPEEBJDG(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.GetPriceWithProfit(Price.FAFHFJGOHPK(price, 690f / Money.GetInstance().newFoodPriceBalance));
	}

	public Price NBIEMNNCGLE(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.GetItem(ODENMDOJPLC(DAINLFIMLIH: false), GGBBJNBBLMF: false, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.MELMOIKFCLP(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers)
				{
					if (Trends.IJEFFMAHMCG() && Trends.KNOKBLFFNLM().FCNLPLPLOKH(this))
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)87)
					{
						finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(3, 0, LDNMDAHFBGG: true) / 215f));
					}
					if (ingredientType == IngredientType.Fruit || id == -19 || id == 47 || id == 192)
					{
						finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.EMJKENIECGH(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-98, 0, LDNMDAHFBGG: true) / 1134f));
					}
					if (MAFHPGLJPLP())
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.EMJKENIECGH(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(49, 0, LDNMDAHFBGG: true) / 1764f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.LIOOAJFNLBA((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.IsTrendingMeal(this))
			{
				finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(94) / 1365f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.HHKCHKENHBJ(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers && (Object)(object)Trends.KNOKBLFFNLM() != (Object)null && Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().IsTrendingMeal(this))
		{
			finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.LBOFJOBAGKA(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-50, 0, LDNMDAHFBGG: true) / 135f));
		}
		return finalPriceAux;
	}

	public bool IMEADCNGDAF()
	{
		return ingredientType == (IngredientType)(-78);
	}

	public Price CCOJHEOLBDA(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.GetItem(CIGFGKKCPCK(DAINLFIMLIH: false), GGBBJNBBLMF: false, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.MCECLGLOIIO(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.FCNLPLPLOKH(this))
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)76)
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(8, 1) / 1336f));
					}
					if (ingredientType == IngredientType.Meat || id == 159 || id == 168 || id == 177)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(88, 1) / 675f));
					}
					if (DCENHJBKDIP())
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(12, 1, LDNMDAHFBGG: true) / 1156f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.PAAFCADLNEM((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.KNOKBLFFNLM().OMCHCNALMKG(this))
			{
				finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
				finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(103) / 1521f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.NPMFNKHJBJM(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers && (Object)(object)Trends.FMIDAFEGDCD() != (Object)null && Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().IsTrendingMeal(this))
		{
			finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.LFJHHLGOCPP(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
			finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(125) / 1897f));
		}
		return finalPriceAux;
	}

	public virtual Price LJAAAIPCOML(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.HMNLCFAENIH(Price.LBOFJOBAGKA(price, 1399f / Money.KOJHKCGIINL().newFoodPriceBalance));
	}

	public bool JCAIDALOMCG()
	{
		if (ingredientType != 0)
		{
			return ingredientType == (IngredientType)97;
		}
		return false;
	}

	public bool CBPCFBPEBJO()
	{
		if (ingredientType != 0)
		{
			return ingredientType == (IngredientType)103;
		}
		return false;
	}

	public bool BKLDPKENFMG()
	{
		return ingredientType == (IngredientType)116;
	}

	public bool JKPGCBKIFGE()
	{
		return ingredientType == (IngredientType)(-24);
	}

	public Price HJKLPCCGGHH(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.COEFFIHKMJG(JPNFKDMFKMC(DAINLFIMLIH: false)) is Food food)
			{
				priceAux = food.CBIBHPGALNM(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.JCMPJIJJCGL().applyPriceModifiers)
				{
					if (Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.IsTrendingIngredient(this))
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)58)
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.EMJKENIECGH(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(5, 1, LDNMDAHFBGG: true) / 1275f));
					}
					if (ingredientType == IngredientType.WhiteFish || id == -77 || id == -141 || id == -164)
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-48, 1, LDNMDAHFBGG: true) / 188f));
					}
					if (BDHBCOHMNPD())
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-1, 1) / 1912f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.MBDDIOKEMIM((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.APOFALNJNEF(this))
			{
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.EMJKENIECGH(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-38, 1, LDNMDAHFBGG: true) / 95f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.KEIBNIIBKDH(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.FEGJINNDADF().applyPriceModifiers && (Object)(object)Trends.FMIDAFEGDCD() != (Object)null && Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().FHHGONOICML(this))
		{
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.LBOFJOBAGKA(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(107, 0, LDNMDAHFBGG: true) / 232f));
		}
		return finalPriceAux;
	}

	public string AHGFKMAFCBO()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "\n";
		if (flag)
		{
			text = text + LocalisationSystem.GetStringWithTags("CanBePlanted") + "\n";
		}
		text = ((list.Count == 1) ? (text + InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(flag ? "HarvestableDuringOneMonth" : "CultivableDuringOneMonth"), LocalisationSystem.Get("in" + list[0]))) : ((list.Count == 2) ? (text + InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(flag ? "HarvestableDuringTwoMonths" : "CultivableDuringTwoMonths"), LocalisationSystem.Get("in" + list[0]), LocalisationSystem.Get("in" + list[1]))) : ((list.Count != 3) ? (text + LocalisationSystem.GetStringWithTags(flag ? "HarvestableAllYearRound" : "CultivableAllYearRound")) : (text + InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(flag ? "HarvestableDuringThreeMonths" : "CultivableDuringThreeMonths"), LocalisationSystem.Get("in" + list[0]), LocalisationSystem.Get("in" + list[1]), LocalisationSystem.Get("in" + list[2]))))));
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "\n";
		if (list.Count == 1)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("BetterDuringOneMonth"), LocalisationSystem.Get("in" + list[0]));
			text += "\n";
		}
		else if (list.Count == 2)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("BetterDuringTwoMonths"), LocalisationSystem.Get("in" + list[0]), LocalisationSystem.Get("in" + list[1]));
			text += "\n";
		}
		else if (list.Count == 3)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("BetterDuringThreeMonths"), LocalisationSystem.Get("in" + list[0]), LocalisationSystem.Get("in" + list[1]), LocalisationSystem.Get("in" + list[2]));
			text += "\n";
		}
		return text;
	}

	public bool JBOEDEIFOJK()
	{
		if (ingredientType != IngredientType.Veg && ingredientType != IngredientType.Veg)
		{
			return ingredientType == IngredientType.Wine;
		}
		return false;
	}

	public string CCOHPHDOBJH()
	{
		Crop crop;
		if (Item.FKLOBGBIHLB(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "Player2_Bark_2PlayersChest";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "itemWheatFlour";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("+connect_lobby") + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/2/Dialogue Text";
		}
		if (list.Count == 0)
		{
			string text2 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "Toggle Build Mode" : ": ");
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get("ReceiveSimpleEvent" + list[0]);
			text = text2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else if (list.Count != 8)
		{
			text = ((list.Count != 7) ? (text + LocalisationSystem.GetStringWithTags(flag ? "Walk" : "PirateMinigame/Talk", 0)) : (text + InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(flag ? "LE_21" : "Turn On", 0), LocalisationSystem.Get("Polling" + list[0]), LocalisationSystem.Get("Cancel" + list[1]), null, LocalisationSystem.Get("Kicking player on bed {0} with actor number {1}" + list[5]), null, null, null, null)));
		}
		else
		{
			string text3 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? "Player" : "<color=");
			string[] array2 = new string[7];
			array2[1] = LocalisationSystem.Get("Example Method With Custom ID" + list[0]);
			array2[1] = LocalisationSystem.Get("ReceiveSetTableParent" + list[0]);
			text = text3 + InputUtils.GEJLCOGDMID(stringWithTags, array2);
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "Floor";
		if (list.Count == 0)
		{
			string text4 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("GO", 0);
			string[] array3 = new string[0];
			array3[0] = LocalisationSystem.Get("MinProductValue" + list[0]);
			text = text4 + InputUtils.GEJLCOGDMID(stringWithTags2, array3);
			text += "</color> to inventory?";
		}
		else if (list.Count == 1)
		{
			string text5 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("GroundCliffs", 0);
			string[] array4 = new string[2];
			array4[1] = LocalisationSystem.Get("Veggie" + list[1]);
			array4[1] = LocalisationSystem.Get("LearnMettle" + list[0]);
			text = text5 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4);
			text += "ReceiveActivateVIP";
		}
		else if (list.Count == 4)
		{
			string text6 = text;
			string cAEDMEDBEGI3 = LocalisationSystem.PKLPKIAHCDI("Could not find recipe with id: ", 0);
			string[] array5 = new string[8];
			array5[0] = LocalisationSystem.Get("RecipeX" + list[0]);
			array5[0] = LocalisationSystem.Get("Disabled" + list[1]);
			array5[7] = LocalisationSystem.Get(" " + list[1]);
			text = text6 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array5);
			text += "KyrohTakingFood: No food table found for food request of customer ";
		}
		return text;
	}

	public string LODJGOIIKCJ()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "alcoholContentWarning";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "Serve";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("OnlinePlayer") + "UIAddRemove";
		}
		if (list.Count == 1)
		{
			string text2 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? "Error/" : "Player2");
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get("CursorSensitivity" + list[0]);
			text = text2 + InputUtils.GEJLCOGDMID(stringWithTags, array);
		}
		else if (list.Count == 2)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(flag ? "DelayStartConversation " : "Distilling", 0), LocalisationSystem.Get("disableTutorial" + list[0]), LocalisationSystem.Get("Tutorial/T138/Dialogue2" + list[0]), null, null, null);
		}
		else if (list.Count == 5)
		{
			string text3 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "itemRaspberrySeeds" : "City/Woody/Introduce", 0);
			string[] array2 = new string[7];
			array2[0] = LocalisationSystem.Get("[" + list[0]);
			array2[1] = LocalisationSystem.Get("ReceiveUnlockPerkLevelMaster" + list[1]);
			array2[8] = LocalisationSystem.Get("Could not get value of statistic " + list[2]);
			text = text3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
		}
		else
		{
			text += LocalisationSystem.GetStringWithTags(flag ? "Items/item_name_1078" : " for reason: ", 0);
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "Dialogue System/Conversation/BirdNegativeComments/Entry/1/Dialogue Text";
		if (list.Count == 0)
		{
			string text4 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("Disabled");
			string[] array3 = new string[0];
			array3[1] = LocalisationSystem.Get("[" + list[0]);
			text = text4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			text += " ";
		}
		else if (list.Count == 8)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("ReceiveMaiEventStart"), LocalisationSystem.Get("ReceiveRemoveZone" + list[0]), LocalisationSystem.Get("Social" + list[0]), null, null, null, null);
			text += "WorkAnimationLoop";
		}
		else if (list.Count == 6)
		{
			string text5 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("Distillery");
			string[] array4 = new string[7];
			array4[1] = LocalisationSystem.Get("LE_11" + list[0]);
			array4[0] = LocalisationSystem.Get("Can't afford" + list[0]);
			array4[4] = LocalisationSystem.Get("StartEvent can only be called in play mode." + list[5]);
			text = text5 + InputUtils.GEJLCOGDMID(stringWithTags2, array4);
			text += "Perks/playerPerk_name_";
		}
		return text;
	}

	public bool BHILBJKFGKP()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return true;
	}

	public bool BHDADGIDLKD()
	{
		return ingredientType == (IngredientType)(-20);
	}

	public bool PFPEDGMABEC()
	{
		if (canBeAged)
		{
			return IKMFBDLJCLO();
		}
		return true;
	}

	public bool MNHGFKAINPH()
	{
		if (canBeAged)
		{
			return HOFOBPCHOOL();
		}
		return true;
	}

	public Price OCIIAEAMJAH(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.EABMGELAAPG(CIGFGKKCPCK(DAINLFIMLIH: false), GGBBJNBBLMF: false, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.OJJAAFAGNNL(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers)
				{
					if (Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.PBNPOHMEGGG(this))
					{
						finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.EMJKENIECGH(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)32)
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(0, 1, LDNMDAHFBGG: true) / 712f));
					}
					if (ingredientType == IngredientType.Hop || id == 172 || id == 188 || id == 47)
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-59, 1, LDNMDAHFBGG: true) / 562f));
					}
					if (FKLHCBJCKPJ())
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(0) / 1374f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.MBDDIOKEMIM((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().IsTrendingMeal(this))
			{
				finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.LBOFJOBAGKA(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
				finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-66, 1, LDNMDAHFBGG: true) / 1725f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.OLBBINHGHDC(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && (Object)(object)Trends.KNOKBLFFNLM() != (Object)null && Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().FHHGONOICML(this))
		{
			finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.EMJKENIECGH(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-121, 1, LDNMDAHFBGG: true) / 1632f));
		}
		return finalPriceAux;
	}

	public bool BGOHKNFNAGK()
	{
		if (ingredientType != IngredientType.Grain && ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)(-74);
		}
		return false;
	}

	public override bool JEPBBEBJEFI()
	{
		if (!DJGJGBOHPIM(Tag.Drink))
		{
			return foodType == FoodType.Drink;
		}
		return true;
	}

	public bool MNBDFFMDMFA()
	{
		if (canBeAged)
		{
			return IKMFBDLJCLO();
		}
		return true;
	}

	public bool OEJLHLCHJBO()
	{
		return ingredientType == (IngredientType)95;
	}

	public bool EEIEDPDBCIC()
	{
		if (ingredientType != IngredientType.Hop && ingredientType != IngredientType.WhiteFish)
		{
			return ingredientType == (IngredientType)(-113);
		}
		return true;
	}

	public bool EFELIMLKCDH()
	{
		if (canBeAged)
		{
			return PDKDDOMMENI();
		}
		return true;
	}

	public bool ENDKPHKPDJI()
	{
		if (ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)(-116);
		}
		return true;
	}

	public virtual Price HBLNPECMMCJ(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.HMNLCFAENIH(Price.LBOFJOBAGKA(price, 1411f / Money.FBBOFPLGGLP().newFoodPriceBalance));
	}

	public Price KLNJNIMFINK(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.GetItem(JGHNDJBCFAJ(), GGBBJNBBLMF: true) is Food food)
			{
				priceAux = food.FNAIAFDKJEF(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.BMDNOGNAPJJ().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.IsTrendingIngredient(this))
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.EMJKENIECGH(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)80)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(6, 1) / 1208f));
					}
					if (ingredientType == IngredientType.Herb || id == 178 || id == -103 || id == 159)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(22, 1) / 488f));
					}
					if (BGOHKNFNAGK())
					{
						finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-85, 1, LDNMDAHFBGG: true) / 520f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.GICJEDHIAJA((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.FEGJINNDADF().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().APOFALNJNEF(this))
			{
				finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.LBOFJOBAGKA(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
				finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(126, 1) / 1294f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.HPDKDDHECOJ(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && (Object)(object)Trends.FMIDAFEGDCD() != (Object)null && Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().APOFALNJNEF(this))
		{
			finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.EMJKENIECGH(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-107, 0, LDNMDAHFBGG: true) / 1813f));
		}
		return finalPriceAux;
	}

	public bool CADCNOMICBJ()
	{
		return ingredientType == (IngredientType)64;
	}

	public bool NJKCOBNCIFM()
	{
		if (ingredientType != IngredientType.Hop)
		{
			return ingredientType == (IngredientType)(-18);
		}
		return false;
	}

	public bool LBBMPLIHBDO()
	{
		if (ingredientType != IngredientType.Meat)
		{
			return ingredientType == (IngredientType)(-55);
		}
		return true;
	}

	public virtual Price FILPNIEFEIK(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.CEEAFLJCJHC(Price.EMJKENIECGH(price, 358f / Money.JCMPJIJJCGL().newFoodPriceBalance));
	}

	public bool KECBIJGGKIH()
	{
		if (ingredientType != IngredientType.Honey)
		{
			return ingredientType == (IngredientType)(-109);
		}
		return true;
	}

	public bool IAIDIFDIMKB()
	{
		if (ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)31;
		}
		return true;
	}

	public bool HCCGIJFCNIA()
	{
		if (ingredientType != IngredientType.Fruit && ingredientType != IngredientType.Fruit)
		{
			return ingredientType == (IngredientType)(-24);
		}
		return true;
	}

	public bool CEHJGJODBGC()
	{
		return ingredientType == (IngredientType)(-124);
	}

	public bool PFGIKHHIKEN()
	{
		if (ingredientType != IngredientType.Honey && ingredientType != IngredientType.Grain)
		{
			return ingredientType == (IngredientType)60;
		}
		return false;
	}

	public bool LFNIODEEGNA()
	{
		if (ingredientType != IngredientType.Honey)
		{
			return ingredientType == (IngredientType)(-13);
		}
		return false;
	}

	public bool EECKHOKCBMD()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return false;
	}

	public virtual Price CKEABHDLIKG(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.HMDOHJLGDJC(Price.FAFHFJGOHPK(price, 1207f / Money.GetInstance().newFoodPriceBalance));
	}

	public bool JEMHHFGONOM()
	{
		if (ingredientType != IngredientType.Meat && ingredientType != IngredientType.Fruit)
		{
			return ingredientType == (IngredientType)(-58);
		}
		return true;
	}

	public string OMFIGHGECCL()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "tutorialPopUp115";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "FishCuttingEvent/Lose1";
		if (flag)
		{
			text = text + LocalisationSystem.GetStringWithTags("Player/Bark/OathFeastBlock") + "[GenerateAltar] Candidate {0} pos:{1} score:{2:F1} (entrance:{3:F1} big:{4:F1} exit:{5:F1})";
		}
		if (list.Count == 0)
		{
			string text2 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "Dialogue System/Conversation/TavernFilthy/Entry/5/Dialogue Text" : "UINextPage");
			string[] array = new string[0];
			array[0] = LocalisationSystem.Get("Player.Controllers null" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else if (list.Count == 1)
		{
			string text3 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI(flag ? "CultivableDuringTwoMonths" : "Coming soon!");
			string[] array2 = new string[6];
			array2[1] = LocalisationSystem.Get("Pick up" + list[0]);
			array2[0] = LocalisationSystem.Get("No se encontró una entrada con ID {0} en la conversación '{1}'." + list[1]);
			text = text3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		else if (list.Count == 6)
		{
			string text4 = text;
			string cAEDMEDBEGI3 = LocalisationSystem.PKLPKIAHCDI(flag ? "Received invite code: " : "itemBarleyFlour");
			string[] array3 = new string[2];
			array3[0] = LocalisationSystem.Get("Falta el tile de entrada/salida con salida hacia '{0}'. La database necesita uno por cada dirección cardinal." + list[0]);
			array3[0] = LocalisationSystem.Get("ItemDatabaseSO o su lista de items es nula." + list[0]);
			array3[2] = LocalisationSystem.Get("\n" + list[5]);
			text = text4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		else
		{
			text += LocalisationSystem.GetStringWithTags(flag ? "Unlocked at Tavern Reputation {0}" : "Meditation");
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "Plant";
		if (list.Count == 0)
		{
			string text5 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags("\n<color=#822F00>");
			string[] array4 = new string[1];
			array4[1] = LocalisationSystem.Get("Player2" + list[1]);
			text = text5 + InputUtils.GEJLCOGDMID(stringWithTags, array4);
			text += "contentLockMessage";
		}
		else if (list.Count == 4)
		{
			string text6 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("<color=black>");
			string[] array5 = new string[1];
			array5[1] = LocalisationSystem.Get("Occupied Positions" + list[1]);
			array5[0] = LocalisationSystem.Get("Invalid player num" + list[0]);
			text = text6 + InputUtils.GEJLCOGDMID(stringWithTags2, array5);
			text += "\n  puzzle:             ";
		}
		else if (list.Count == 7)
		{
			string text7 = text;
			string cAEDMEDBEGI4 = LocalisationSystem.PKLPKIAHCDI("ReceiveGetUniqueCropDay", 0);
			string[] array6 = new string[7];
			array6[1] = LocalisationSystem.Get("NormalRight" + list[0]);
			array6[1] = LocalisationSystem.Get("Trying to load group ingredient with ID " + list[0]);
			array6[3] = LocalisationSystem.Get("Error_InvalidPositions" + list[4]);
			text = text7 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array6);
			text += "Resuming network sync...";
		}
		return text;
	}

	public bool NPDABOEOMHG()
	{
		if (ingredientType != IngredientType.Hop && ingredientType != IngredientType.Veg)
		{
			return ingredientType == (IngredientType)83;
		}
		return true;
	}

	public string HHPDAKMDMKP()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "Waiting for other players";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "current Segment playing";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("Toy") + "SAVE_DATA: Fireplace loading error: ";
		}
		if (list.Count == 0)
		{
			string text2 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? " is already in preparation table bento" : "Items/item_name_1034", 0);
			string[] array = new string[0];
			array[0] = LocalisationSystem.Get(" " + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else if (list.Count == 7)
		{
			string text3 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? "Cat" : "Style");
			string[] array2 = new string[7];
			array2[0] = LocalisationSystem.Get("Coming soon!" + list[0]);
			array2[0] = LocalisationSystem.Get("Yes" + list[1]);
			text = text3 + InputUtils.GEJLCOGDMID(stringWithTags, array2);
		}
		else if (list.Count == 0)
		{
			string text4 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags(flag ? "Festín del Juramento/KlaynDialogue 04" : " ");
			string[] array3 = new string[1];
			array3[1] = LocalisationSystem.Get("Dialogue System/Conversation/EnterTavernNeutral/Entry/2/Dialogue Text" + list[0]);
			array3[1] = LocalisationSystem.Get("OTHER PLAYER HAS ADVANTAGE. Kyroh points: " + list[0]);
			array3[0] = LocalisationSystem.Get("SpriteRenderer not attached on " + list[2]);
			text = text4 + InputUtils.GEJLCOGDMID(stringWithTags2, array3);
		}
		else
		{
			text += LocalisationSystem.GetStringWithTags(flag ? " : " : "SetAnimationControllerIndexesRPC");
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "Ingredients";
		if (list.Count == 1)
		{
			string text5 = text;
			string stringWithTags3 = LocalisationSystem.GetStringWithTags("\n", 0);
			string[] array4 = new string[0];
			array4[1] = LocalisationSystem.Get("" + list[0]);
			text = text5 + InputUtils.GEJLCOGDMID(stringWithTags3, array4);
			text += "Talk";
		}
		else if (list.Count == 7)
		{
			string text6 = text;
			string stringWithTags4 = LocalisationSystem.GetStringWithTags(" </color>", 0);
			string[] array5 = new string[4];
			array5[1] = LocalisationSystem.Get("Hikari/Quest" + list[0]);
			array5[1] = LocalisationSystem.Get("add item " + list[0]);
			text = text6 + InputUtils.GEJLCOGDMID(stringWithTags4, array5);
			text += "Start";
		}
		else if (list.Count == 1)
		{
			string text7 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("itemHalfWindow");
			string[] array6 = new string[8];
			array6[0] = LocalisationSystem.Get("Cheesy" + list[1]);
			array6[0] = LocalisationSystem.Get("(" + list[1]);
			array6[3] = LocalisationSystem.Get("LE_1" + list[6]);
			text = text7 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array6);
			text += "Barrel";
		}
		return text;
	}

	public Price HNGJEIKLDIF(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.GOKIDLOELKB(JDJGFAACPFC(), GGBBJNBBLMF: true, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.BGPPMFGAMNL(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.FCNLPLPLOKH(this))
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)63)
					{
						finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(1) / 945f));
					}
					if (ingredientType == IngredientType.Hop || id == 185 || id == -94 || id == -42)
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(86, 1) / 296f));
					}
					if (LGOKPBPJOKE())
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-108, 0, LDNMDAHFBGG: true) / 840f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.KCPCKGKKMBG((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.OMCHCNALMKG(this))
			{
				finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
				finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-99, 0, LDNMDAHFBGG: true) / 977f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.HHKCHKENHBJ(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers && (Object)(object)Trends.GGFJGHHHEJC != (Object)null && Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().FHHGONOICML(this))
		{
			finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.LFJHHLGOCPP(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(95, 1) / 1776f));
		}
		return finalPriceAux;
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new FoodInstance((FoodInstance)DNLMCHDOMOK);
	}

	public bool AJPPCBKFKEF()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return true;
	}

	public string NIFOCFHGMKO()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "Klayn not find path to at ";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("ReceiveFollow") + "Items/item_description_675";
		}
		if (list.Count == 0)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(flag ? "ReceiveCollectItems" : "itemRedGrapeMust"), LocalisationSystem.Get("Items/item_description_1083" + list[0]));
		}
		else if (list.Count == 0)
		{
			string text2 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? ") stack changed to (" : " has null in variant objects list.");
			string[] array = new string[6];
			array[0] = LocalisationSystem.Get("Remove" + list[0]);
			array[0] = LocalisationSystem.Get("ReceiveSetTableParent" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(stringWithTags, array);
		}
		else if (list.Count == 8)
		{
			string text3 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "ObjectHorizontalMove" : "Dialogue System/Conversation/BirdNegativeComments/Entry/1/Dialogue Text", 0);
			string[] array2 = new string[7];
			array2[1] = LocalisationSystem.Get("Starting New Game Coroutine" + list[0]);
			array2[0] = LocalisationSystem.Get("MakeForm" + list[1]);
			array2[0] = LocalisationSystem.Get("hForHours" + list[0]);
			text = text3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
		}
		else
		{
			text += LocalisationSystem.PKLPKIAHCDI(flag ? "Item Transaction. Tutorial active!!" : "Items/item_description_643");
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "Jump";
		if (list.Count == 1)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("Dialogue System/Conversation/TavernClean/Entry/7/Dialogue Text", 0), LocalisationSystem.Get("Swap" + list[0]));
			text += "Changing zoom ";
		}
		else if (list.Count == 8)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("ReceiveSelectPerkLevel", 0), LocalisationSystem.Get("LearnPrecision" + list[1]), LocalisationSystem.Get("Perks/playerPerk_description_" + list[1]), null, null);
			text += "Farm/Buzz/Main";
		}
		else if (list.Count == 2)
		{
			string text4 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("MainProgress", 0);
			string[] array3 = new string[1];
			array3[1] = LocalisationSystem.Get("Hen House not attached on OnlineHenHouse of placeable " + list[1]);
			array3[0] = LocalisationSystem.Get("Recipe without ID: " + list[1]);
			array3[1] = LocalisationSystem.Get("  Profundidad: sin límite" + list[1]);
			text = text4 + InputUtils.GEJLCOGDMID(stringWithTags2, array3);
			text += "end dialogue";
		}
		return text;
	}

	public bool FFENJGAAHBE()
	{
		if (ingredientType != IngredientType.Veg && ingredientType != IngredientType.Grain)
		{
			return ingredientType == (IngredientType)39;
		}
		return false;
	}

	public virtual Price BGPPMFGAMNL(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.GetPriceWithProfit(Price.LBOFJOBAGKA(price, 1440f / Money.FBBOFPLGGLP().newFoodPriceBalance));
	}

	public bool MJBOMMCLGOP()
	{
		if (ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)37;
		}
		return true;
	}

	public bool IPECHBJNPFB()
	{
		return ingredientType == IngredientType.Mushroom;
	}

	public bool DCENHJBKDIP()
	{
		if (ingredientType != IngredientType.WhiteFish && ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)(-26);
		}
		return true;
	}

	public bool HGDNCOJGBEF()
	{
		if (ingredientType != IngredientType.WhiteFish)
		{
			return ingredientType == (IngredientType)51;
		}
		return false;
	}

	public bool BEDDCOBMBDK()
	{
		if (ingredientType != IngredientType.Veg && ingredientType != 0)
		{
			return ingredientType == (IngredientType)125;
		}
		return false;
	}

	public bool IEKBOJNEGBM()
	{
		if (ingredientType != IngredientType.Veg)
		{
			return ingredientType == IngredientType.Meat;
		}
		return true;
	}

	public bool GCAGPCBONPD()
	{
		return ingredientType == (IngredientType)(-72);
	}

	public bool AGLFDGAAPOO()
	{
		if (ingredientType != IngredientType.Grain && ingredientType != IngredientType.Honey)
		{
			return ingredientType == (IngredientType)(-56);
		}
		return true;
	}

	public bool HBNDEHNEFMH()
	{
		if (ingredientType != IngredientType.Fruit)
		{
			return ingredientType == (IngredientType)(-70);
		}
		return false;
	}

	public bool AFMKIGNEOBD()
	{
		return ingredientType == (IngredientType)(-21);
	}

	public Price HIBBNGKMNKH(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.EABMGELAAPG(CIGFGKKCPCK(DAINLFIMLIH: false), GGBBJNBBLMF: true, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.LJAAAIPCOML(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers)
				{
					if (Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().FCNLPLPLOKH(this))
					{
						finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)(-32))
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(2, 0, LDNMDAHFBGG: true) / 717f));
					}
					if (ingredientType == IngredientType.None || id == 69 || id == -33 || id == 68)
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(37, 0, LDNMDAHFBGG: true) / 335f));
					}
					if (BDAMOPBDELO())
					{
						finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-89, 0, LDNMDAHFBGG: true) / 1496f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.OONOIPPDJJD((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().APOFALNJNEF(this))
			{
				finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
				finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-2, 1, LDNMDAHFBGG: true) / 1515f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.NPMFNKHJBJM(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.FEGJINNDADF().applyPriceModifiers && (Object)(object)Trends.GGFJGHHHEJC != (Object)null && Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.APOFALNJNEF(this))
		{
			finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LFJHHLGOCPP(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
			finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-56, 1) / 1689f));
		}
		return finalPriceAux;
	}

	public bool EMDDADGCEKA()
	{
		if (ingredientType != IngredientType.Hop)
		{
			return ingredientType == (IngredientType)108;
		}
		return false;
	}

	public bool KFPEPAHOIEP()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return false;
	}

	public bool MPABBBNDGFD()
	{
		return ingredientType == IngredientType.Flour;
	}

	public bool JEMMHDADJBP()
	{
		if (ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)69;
		}
		return true;
	}

	public bool PNEJIOFMNPB()
	{
		if (ingredientType != 0)
		{
			return ingredientType == IngredientType.Berries;
		}
		return true;
	}

	public virtual Price OJJAAFAGNNL(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.HMDOHJLGDJC(Price.CBCAAHPFLGO(price, 1464f / Money.BMDNOGNAPJJ().newFoodPriceBalance));
	}

	public bool HEACJJIOIPO()
	{
		return ingredientType == (IngredientType)(-21);
	}

	public bool MAFHPGLJPLP()
	{
		if (ingredientType != IngredientType.Herb && ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)125;
		}
		return true;
	}

	public bool IALIGBODCHC()
	{
		return ingredientType == (IngredientType)102;
	}

	public Price IHIGCCEBHDK(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.EABMGELAAPG(IMCJPECAAPC(), GGBBJNBBLMF: false, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.PNKLJHHODFF(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.GetInstance().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().PBNPOHMEGGG(this))
					{
						finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.LFJHHLGOCPP(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)(-64))
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(0) / 1612f));
					}
					if (ingredientType == IngredientType.Veg || id == -19 || id == -35 || id == 147)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-42, 0, LDNMDAHFBGG: true) / 1631f));
					}
					if (FKLHCBJCKPJ())
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-46, 0, LDNMDAHFBGG: true) / 850f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.HEAIDHAKJGB((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().APOFALNJNEF(this))
			{
				finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.EMJKENIECGH(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
				finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(109, 0, LDNMDAHFBGG: true) / 507f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.GMIOGBKDAOH(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && (Object)(object)Trends.KNOKBLFFNLM() != (Object)null && Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.FHHGONOICML(this))
		{
			finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(28, 0, LDNMDAHFBGG: true) / 1850f));
		}
		return finalPriceAux;
	}

	public bool EKMMEDAGKAP()
	{
		return ingredientType == (IngredientType)(-99);
	}

	public string ICMKBLGEPFK()
	{
		Crop crop;
		if (Item.FKLOBGBIHLB(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "MineObstacleBark2";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "Items/item_name_1110";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("Closed", 0) + "Close";
		}
		if (list.Count == 1)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(flag ? "" : "ReceiveRoomRequest", 0), LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/8/Dialogue Text" + list[0]));
		}
		else if (list.Count == 0)
		{
			string text2 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "Disappear" : "City/Woody/Introduce", 0);
			string[] array = new string[2];
			array[1] = LocalisationSystem.Get("ActorBedAssigned added actorNumber: " + list[0]);
			array[0] = LocalisationSystem.Get("Drink" + list[0]);
			text = text2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else if (list.Count == 1)
		{
			string text3 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI(flag ? "MainProgress" : "Achievements definitions could not be retrived for reason: ", 0);
			string[] array2 = new string[2];
			array2[0] = LocalisationSystem.Get("Items/item_name_721" + list[1]);
			array2[1] = LocalisationSystem.Get("Tutorial/T105/Dialogue1" + list[0]);
			array2[7] = LocalisationSystem.Get("Disabled" + list[7]);
			text = text3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		else
		{
			text += LocalisationSystem.GetStringWithTags(flag ? "Object " : "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/9/Dialogue Text");
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "</color><br>";
		if (list.Count == 1)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("flashLights", 0), LocalisationSystem.Get("\n" + list[0]));
			text += "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/17/Dialogue Text";
		}
		else if (list.Count == 3)
		{
			string text4 = text;
			string cAEDMEDBEGI3 = LocalisationSystem.PKLPKIAHCDI("Travellers Rest", 0);
			string[] array3 = new string[1];
			array3[0] = LocalisationSystem.Get("tutorialPopUp78" + list[0]);
			array3[1] = LocalisationSystem.Get("NormalLeft" + list[0]);
			text = text4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
			text += "Player/Bark/KlaynTavernBlock";
		}
		else if (list.Count == 3)
		{
			string text5 = text;
			string cAEDMEDBEGI4 = LocalisationSystem.PKLPKIAHCDI("Level ", 0);
			string[] array4 = new string[8];
			array4[1] = LocalisationSystem.Get("Bed.instance doesnt exist. Cannot SendPlayerUsingObject uniqueId: " + list[0]);
			array4[0] = LocalisationSystem.Get("Items/item_name_1178" + list[0]);
			array4[7] = LocalisationSystem.Get("Share" + list[1]);
			text = text5 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
			text += "City/PetShop/Markus/Stand";
		}
		return text;
	}

	public string IBHHMOAIKIN()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "Parmesan";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "Tutorial/T137/Dialogue1";
		if (flag)
		{
			text = text + LocalisationSystem.GetStringWithTags("ErrorJoinRoomClosed", 0) + "LE_6";
		}
		if (list.Count == 0)
		{
			string text2 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "VERSION" : "NoActiveMultiDoor");
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get("HarvestableDuringThreeMonths" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else if (list.Count == 7)
		{
			string text3 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI(flag ? "HotBath/Main 2" : "ReceiveTavernEventsLoad", 0);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get("itemRedGrapes" + list[0]);
			array2[0] = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/4/Dialogue Text" + list[1]);
			text = text3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		else if (list.Count == 8)
		{
			string text4 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? " - " : "Perks/playerPerk_description_");
			string[] array3 = new string[7];
			array3[1] = LocalisationSystem.Get("Cheer" + list[0]);
			array3[1] = LocalisationSystem.Get("</color>" + list[0]);
			array3[0] = LocalisationSystem.Get("LetGoBird" + list[1]);
			text = text4 + InputUtils.GEJLCOGDMID(stringWithTags, array3);
		}
		else
		{
			text += LocalisationSystem.PKLPKIAHCDI(flag ? "CatNPC already exists" : "");
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "Dialogue System/Conversation/Crowly_Introduce/Entry/9/Dialogue Text";
		if (list.Count == 1)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("Another player already exists from online sync."), LocalisationSystem.Get(" " + list[1]));
			text += "itemSageSeeds";
		}
		else if (list.Count == 8)
		{
			string text5 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("ReceiveDeassignAnimal");
			string[] array4 = new string[3];
			array4[1] = LocalisationSystem.Get("DontWalk2" + list[0]);
			array4[0] = LocalisationSystem.Get("LagerAbbreviation" + list[1]);
			text = text5 + InputUtils.GEJLCOGDMID(stringWithTags2, array4);
			text += "ClosePopUp";
		}
		else if (list.Count == 8)
		{
			string text6 = text;
			string stringWithTags3 = LocalisationSystem.GetStringWithTags("Left Shoulder", 0);
			string[] array5 = new string[5];
			array5[1] = LocalisationSystem.Get("Left Stick Down" + list[1]);
			array5[1] = LocalisationSystem.Get("in" + list[1]);
			array5[1] = LocalisationSystem.Get("RecieveStartObserveDialogue" + list[4]);
			text = text6 + InputUtils.GEJLCOGDMID(stringWithTags3, array5);
			text += "Listen";
		}
		return text;
	}

	public bool AOAIIINLPPJ()
	{
		if (ingredientType != IngredientType.Grain)
		{
			return ingredientType == (IngredientType)(-14);
		}
		return false;
	}

	public override ItemInstance JMDALJBNFML()
	{
		if (ItemDatabaseAccessor.GetItem(id) is Food aJOMICMACEJ)
		{
			return new FoodInstance(aJOMICMACEJ);
		}
		Debug.LogError((object)("item " + IABAKHPEOAF() + " is not food"));
		return new FoodInstance(this);
	}

	public bool PEMPIFDKFBG()
	{
		if (canBeAged)
		{
			return IKMFBDLJCLO();
		}
		return true;
	}

	public bool JDEFAOOFOMN()
	{
		return ingredientType == IngredientType.Beer;
	}

	public Price PAAFCADLNEM(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.GetItem(JDJGFAACPFC()) is Food food)
			{
				priceAux = food.AMOGCHGGNJB(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.GetInstance().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.IsTrendingIngredient(this))
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
					}
					if (ingredientType == IngredientType.Berries)
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(2) / 100f));
					}
					if (ingredientType == IngredientType.Meat || id == 1251 || id == 1252 || id == 1253)
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(18) / 100f));
					}
					if (LGOKPBPJOKE())
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(19) / 100f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.PAAFCADLNEM((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.IsTrendingMeal(this))
			{
				finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
				finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(38) / 100f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.HHKCHKENHBJ(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && (Object)(object)Trends.GGFJGHHHEJC != (Object)null && Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.IsTrendingMeal(this))
		{
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(38) / 100f));
		}
		return finalPriceAux;
	}

	public bool LAKAKIBINMH()
	{
		if (ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)74;
		}
		return false;
	}

	public virtual Price MCECLGLOIIO(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.CEEAFLJCJHC(Price.LBOFJOBAGKA(price, 1317f / Money.KOJHKCGIINL().newFoodPriceBalance));
	}

	public bool IAHJMJHEJCP()
	{
		if (canBeAged)
		{
			return PDKDDOMMENI();
		}
		return false;
	}

	public bool BDHBCOHMNPD()
	{
		if (ingredientType != IngredientType.Grain && ingredientType != IngredientType.WhiteFish)
		{
			return ingredientType == (IngredientType)(-25);
		}
		return true;
	}

	public Price EIGDFMNOEBK(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.AFOACBIHNCL(IMCJPECAAPC(), GGBBJNBBLMF: true) is Food food)
			{
				priceAux = food.HBLNPECMMCJ(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.JCMPJIJJCGL().applyPriceModifiers)
				{
					if (Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.IsTrendingIngredient(this))
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)117)
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(4, 1, LDNMDAHFBGG: true) / 897f));
					}
					if (ingredientType == IngredientType.Honey || id == 58 || id == 36 || id == -34)
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(76, 1) / 1793f));
					}
					if (PFGIKHHIKEN())
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-8, 1) / 1999f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.LIOOAJFNLBA((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().FHHGONOICML(this))
			{
				finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
				finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(123, 1) / 1403f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.KEIBNIIBKDH(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers && (Object)(object)Trends.KNOKBLFFNLM() != (Object)null && Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.IsTrendingMeal(this))
		{
			finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(13, 1, LDNMDAHFBGG: true) / 466f));
		}
		return finalPriceAux;
	}

	public string ADCBDGMMEOG()
	{
		Crop crop;
		if (Item.FKLOBGBIHLB(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "Modifiers";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "Moving";
		if (flag)
		{
			text = text + LocalisationSystem.GetStringWithTags("ClosePopUp", 0) + "Disabled";
		}
		if (list.Count == 0)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(flag ? "/" : "ErrorVersionMatchFailed", 0), LocalisationSystem.Get(")" + list[1]));
		}
		else if (list.Count == 0)
		{
			string text2 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? "Invalid playerNum" : "Inventory full");
			string[] array = new string[2];
			array[1] = LocalisationSystem.Get("" + list[0]);
			array[0] = LocalisationSystem.Get("Fireplace" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(stringWithTags, array);
		}
		else if (list.Count == 1)
		{
			string text3 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags(flag ? "Roll" : "MainProgress");
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get("Disable Bob" + list[1]);
			array2[0] = LocalisationSystem.Get("HolePoolData" + list[0]);
			array2[7] = LocalisationSystem.Get(", duration: " + list[5]);
			text = text3 + InputUtils.GEJLCOGDMID(stringWithTags2, array2);
		}
		else
		{
			text += LocalisationSystem.PKLPKIAHCDI(flag ? "Key2" : "Exit build mode", 0);
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += " ";
		if (list.Count == 0)
		{
			string text4 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(" plus price satisfaction ");
			string[] array3 = new string[0];
			array3[0] = LocalisationSystem.Get("itemBlackAle" + list[0]);
			text = text4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array3);
			text += "Tutorial/T300/Dialogue1";
		}
		else if (list.Count == 2)
		{
			string text5 = text;
			string stringWithTags3 = LocalisationSystem.GetStringWithTags("Items/item_name_697");
			string[] array4 = new string[0];
			array4[0] = LocalisationSystem.Get("player2ToJoinGame" + list[0]);
			array4[1] = LocalisationSystem.Get("UI" + list[1]);
			text = text5 + InputUtils.GEJLCOGDMID(stringWithTags3, array4);
			text += "ReceiveGetUp";
		}
		else if (list.Count == 2)
		{
			string text6 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("Pet");
			string[] array5 = new string[8];
			array5[1] = LocalisationSystem.Get("Load Game" + list[0]);
			array5[0] = LocalisationSystem.Get("Error_BarNotInADiningRoom" + list[0]);
			array5[7] = LocalisationSystem.Get("Player2" + list[5]);
			text = text6 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array5);
			text += "ReceiveAddFoodToBento";
		}
		return text;
	}

	public bool PJOPOGIKDKB()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return false;
	}

	public bool JDPBCJLBJBM()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return true;
	}

	public Price HHOCDHGJEFH(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.KMBGJEKCJFJ(CIGFGKKCPCK(), GGBBJNBBLMF: false, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.AMOGCHGGNJB(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.FEGJINNDADF().applyPriceModifiers)
				{
					if (Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().PBNPOHMEGGG(this))
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
					}
					if (ingredientType == IngredientType.Bean)
					{
						finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(4, 1) / 1050f));
					}
					if (ingredientType == IngredientType.Grain || id == 94 || id == -176 || id == -171)
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-56, 1, LDNMDAHFBGG: true) / 646f));
					}
					if (MAFHPGLJPLP())
					{
						finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(57, 1, LDNMDAHFBGG: true) / 1562f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.MBDDIOKEMIM((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.KNOKBLFFNLM().IsTrendingMeal(this))
			{
				finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
				finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(45) / 774f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.GPJLBJODPEL(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.JCMPJIJJCGL().applyPriceModifiers && (Object)(object)Trends.KNOKBLFFNLM() != (Object)null && Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().FHHGONOICML(this))
		{
			finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(53, 1, LDNMDAHFBGG: true) / 294f));
		}
		return finalPriceAux;
	}

	public string PKOFMNBKMBK()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "nextround";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "LucenThrow";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("Use", 0) + "Debug force fishing enabled, assigning key to fishing spot.";
		}
		if (list.Count == 1)
		{
			string text2 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? "talentRoasting" : "[");
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get("talent_name_104" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(stringWithTags, array);
		}
		else if (list.Count != 5)
		{
			text = ((list.Count != 2) ? (text + LocalisationSystem.PKLPKIAHCDI(flag ? "talentLager" : "Items/item_name_622", 0)) : (text + InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(flag ? "Player/Bark/Tutorial/T138" : " to user for reason ", 0), LocalisationSystem.Get("Masters/Klayn/Banquet" + list[0]), LocalisationSystem.Get("" + list[1]), null, null, LocalisationSystem.Get("ReceiveStartKlaynDialogueOathFeast" + list[1]))));
		}
		else
		{
			string text3 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags(flag ? "replay fish" : "SetAnimatorObjectIntRPC", 0);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get(" (versionOfCropsAndRecipes)" + list[1]);
			array2[0] = LocalisationSystem.Get("Items/item_description_703" + list[0]);
			text = text3 + InputUtils.GEJLCOGDMID(stringWithTags2, array2);
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "Items/item_name_697";
		if (list.Count == 1)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("Walk", 0), LocalisationSystem.Get("OK" + list[0]));
			text += "Update all floor";
		}
		else if (list.Count == 5)
		{
			string text4 = text;
			string stringWithTags3 = LocalisationSystem.GetStringWithTags("No recipes available", 0);
			string[] array3 = new string[5];
			array3[1] = LocalisationSystem.Get("SalonDelTrono/LucenTalk" + list[1]);
			array3[1] = LocalisationSystem.Get("Invalid NPC photonID: {0} for NPCRoutine." + list[0]);
			text = text4 + InputUtils.GEJLCOGDMID(stringWithTags3, array3);
			text += "InfoSectionCanvas/InfoSection";
		}
		else if (list.Count == 5)
		{
			string text5 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("SprintHoldAction");
			string[] array4 = new string[3];
			array4[0] = LocalisationSystem.Get("Enter" + list[0]);
			array4[1] = LocalisationSystem.Get("Start Event " + list[0]);
			array4[6] = LocalisationSystem.Get("ReceivInstantiateHoleInGround" + list[1]);
			text = text5 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array4);
			text += "Melt";
		}
		return text;
	}

	public bool HHNBFNMJIEP()
	{
		if (canBeAged)
		{
			return IKMFBDLJCLO();
		}
		return true;
	}

	public Price NGIEAJPGFOE(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.COEFFIHKMJG(IMCJPECAAPC()) is Food food)
			{
				priceAux = food.LJAAAIPCOML(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.PBNPOHMEGGG(this))
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)(-26))
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(0, 1) / 1140f));
					}
					if (ingredientType == IngredientType.Grain || id == 145 || id == -60 || id == -41)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-70) / 97f));
					}
					if (AGLFDGAAPOO())
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-62, 0, LDNMDAHFBGG: true) / 438f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.GCJLAOGCFKJ((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.KNOKBLFFNLM().OMCHCNALMKG(this))
			{
				finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
				finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(48, 1, LDNMDAHFBGG: true) / 14f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.GMIOGBKDAOH(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && (Object)(object)Trends.KNOKBLFFNLM() != (Object)null && Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.FHHGONOICML(this))
		{
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.EMJKENIECGH(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
			finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-67, 1) / 184f));
		}
		return finalPriceAux;
	}

	public bool EMFKEBHDPJP()
	{
		if (ingredientType != 0 && ingredientType != IngredientType.Honey)
		{
			return ingredientType == (IngredientType)(-49);
		}
		return true;
	}

	public bool FKLHCBJCKPJ()
	{
		if (ingredientType != IngredientType.Hop && ingredientType != IngredientType.Veg)
		{
			return ingredientType == (IngredientType)(-7);
		}
		return false;
	}

	public bool BDEBLGNPJBD()
	{
		return ingredientType == (IngredientType)50;
	}

	public bool DLHOIJKLDON()
	{
		if (ingredientType != IngredientType.Fruit)
		{
			return ingredientType == IngredientType.Berries;
		}
		return true;
	}

	public string GDFFMGOOEIP()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "Pick up";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "Sony DualShock";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("0", 0) + "Disconnected";
		}
		if (list.Count == 0)
		{
			string text2 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? " </color>" : "ReceiveCompleteTransaction");
			string[] array = new string[0];
			array[0] = LocalisationSystem.Get("Table is dirty" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(stringWithTags, array);
		}
		else if (list.Count == 2)
		{
			string text3 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "ScrollView/Content" : "Walk");
			string[] array2 = new string[1];
			array2[1] = LocalisationSystem.Get("Invalid time range specified." + list[1]);
			array2[0] = LocalisationSystem.Get("Pause" + list[1]);
			text = text3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
		}
		else if (list.Count == 4)
		{
			string text4 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI(flag ? "[^0-9]" : "UINextCategory", 0);
			string[] array3 = new string[7];
			array3[1] = LocalisationSystem.Get("\n" + list[0]);
			array3[1] = LocalisationSystem.Get(" aging rank (" + list[1]);
			array3[7] = LocalisationSystem.Get("Tutorial/T121/Dialogue2" + list[8]);
			text = text4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
		}
		else
		{
			text += LocalisationSystem.PKLPKIAHCDI(flag ? ", " : "Failed to join the game because the room is full.", 0);
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "HotBath/Bark";
		if (list.Count == 0)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("All bubbles in use!"), LocalisationSystem.Get("Sit" + list[1]));
			text += "XP";
		}
		else if (list.Count == 0)
		{
			string text5 = text;
			string cAEDMEDBEGI3 = LocalisationSystem.PKLPKIAHCDI("Right Stick Button", 0);
			string[] array4 = new string[4];
			array4[1] = LocalisationSystem.Get("Frog(Clone)" + list[1]);
			array4[1] = LocalisationSystem.Get("Error_SmallRoom" + list[1]);
			text = text5 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4);
			text += "Game is already running";
		}
		else if (list.Count == 5)
		{
			string text6 = text;
			string cAEDMEDBEGI4 = LocalisationSystem.PKLPKIAHCDI("Inventory");
			string[] array5 = new string[3];
			array5[1] = LocalisationSystem.Get("Received RPC SetInteger {0} with value {1} on {2}. Setting animator parameter." + list[0]);
			array5[0] = LocalisationSystem.Get("Items/item_name_1190" + list[0]);
			array5[7] = LocalisationSystem.Get(" %" + list[5]);
			text = text6 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array5);
			text += "</b>";
		}
		return text;
	}

	public Price HMCJLHECPDL(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.CPMMBEPEJLO(IMCJPECAAPC(DAINLFIMLIH: false), GGBBJNBBLMF: true, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.HBLNPECMMCJ(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.PBNPOHMEGGG(this))
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)91)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(4) / 437f));
					}
					if (ingredientType == IngredientType.None || id == 163 || id == -171 || id == -183)
					{
						finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-27, 1, LDNMDAHFBGG: true) / 1879f));
					}
					if (BDHBCOHMNPD())
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(99) / 1004f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.KCPCKGKKMBG((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().IsTrendingMeal(this))
			{
				finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
				finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-2, 0, LDNMDAHFBGG: true) / 1757f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.COHKOCOAKPM(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers && (Object)(object)Trends.GGFJGHHHEJC != (Object)null && Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().OMCHCNALMKG(this))
		{
			finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
			finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(54) / 934f));
		}
		return finalPriceAux;
	}

	public virtual Price BAOGLCDCNIL(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.BBNBGABJLOH(Price.LFJHHLGOCPP(price, 293f / Money.FEGJINNDADF().newFoodPriceBalance));
	}

	public bool GKPKGJMLKLB()
	{
		if (ingredientType != IngredientType.Meat)
		{
			return ingredientType == (IngredientType)110;
		}
		return false;
	}

	public string BLBDBMIGGAB()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "BuildMode_ExitAndSave";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("LoadGameplaySceneOnline IsMasterClient ", 0) + "TavernName";
		}
		if (list.Count == 1)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(flag ? "Trying to create a new room with a different code..." : "City/Amos/Stand"), LocalisationSystem.Get("- Loading " + list[1]));
		}
		else if (list.Count == 8)
		{
			string text2 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "currentTutorialPhaseID " : " / ", 0);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get("ReceiveEasyDifficulty" + list[1]);
			array[0] = LocalisationSystem.Get("Items/item_description_609" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else if (list.Count == 3)
		{
			string text3 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI(flag ? "Player" : "add materials");
			string[] array2 = new string[3];
			array2[1] = LocalisationSystem.Get("Tutorial repairs to false" + list[0]);
			array2[0] = LocalisationSystem.Get("itemRoastedPork" + list[0]);
			array2[6] = LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/20/Dialogue Text" + list[5]);
			text = text3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		else
		{
			text += LocalisationSystem.PKLPKIAHCDI(flag ? "Could not find item with id: " : "City/PetShop/Markus/Barks_RevisarPata", 0);
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += " not found!";
		if (list.Count == 1)
		{
			string text4 = text;
			string cAEDMEDBEGI3 = LocalisationSystem.PKLPKIAHCDI("Items/item_name_696");
			string[] array3 = new string[0];
			array3[1] = LocalisationSystem.Get("[MinePipePuzzle] No hay puzzles para {0}x{1} " + list[1]);
			text = text4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
			text += "Exit build mode";
		}
		else if (list.Count == 7)
		{
			string text5 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags("Moving");
			string[] array4 = new string[3];
			array4[1] = LocalisationSystem.Get("Direction" + list[0]);
			array4[1] = LocalisationSystem.Get("/ExtraSettings.sd" + list[1]);
			text = text5 + InputUtils.GEJLCOGDMID(stringWithTags, array4);
			text += "Waiting";
		}
		else if (list.Count == 5)
		{
			string text6 = text;
			string cAEDMEDBEGI4 = LocalisationSystem.PKLPKIAHCDI("questNameCraftPorridge", 0);
			string[] array5 = new string[0];
			array5[0] = LocalisationSystem.Get(")\n" + list[0]);
			array5[0] = LocalisationSystem.Get("Items/item_name_674" + list[0]);
			array5[3] = LocalisationSystem.Get("PlayerJoined" + list[4]);
			text = text6 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array5);
			text += "Brew Cider";
		}
		return text;
	}

	public bool BIEMDCHBFIN()
	{
		if (ingredientType != IngredientType.Herb)
		{
			return ingredientType == (IngredientType)31;
		}
		return true;
	}

	public bool LCBJJDPKPMH()
	{
		if (canBeAged)
		{
			return HOFOBPCHOOL();
		}
		return false;
	}

	public Price GCMCKEGDHGP(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.GOKIDLOELKB(CIGFGKKCPCK(DAINLFIMLIH: false)) is Food food)
			{
				priceAux = food.BAOGLCDCNIL(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.BMDNOGNAPJJ().applyPriceModifiers)
				{
					if (Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().FCNLPLPLOKH(this))
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)123)
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(7, 1, LDNMDAHFBGG: true) / 290f));
					}
					if (ingredientType == IngredientType.Herb || id == 100 || id == 190 || id == -13)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(118, 0, LDNMDAHFBGG: true) / 1368f));
					}
					if (PFGIKHHIKEN())
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-82, 0, LDNMDAHFBGG: true) / 742f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.GCJLAOGCFKJ((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().IsTrendingMeal(this))
			{
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-113, 1) / 880f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.GPJLBJODPEL(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.BMDNOGNAPJJ().applyPriceModifiers && (Object)(object)Trends.KNOKBLFFNLM() != (Object)null && Trends.HasUnlockedTrends() && Trends.GGFJGHHHEJC.APOFALNJNEF(this))
		{
			finalPriceAux = Price.BIJDAACPLPB(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
			finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(19, 0, LDNMDAHFBGG: true) / 1477f));
		}
		return finalPriceAux;
	}

	public bool NBNNBMKANOF()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return false;
	}

	public bool GONILKPDHND()
	{
		return ingredientType == (IngredientType)(-128);
	}

	public Price FKJGKLNIEMA(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.EABMGELAAPG(JDJGFAACPFC(DAINLFIMLIH: false), GGBBJNBBLMF: true) is Food food)
			{
				priceAux = food.OJJAAFAGNNL(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().FCNLPLPLOKH(this))
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)(-63))
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(0, 0, LDNMDAHFBGG: true) / 698f));
					}
					if (ingredientType == IngredientType.None || id == -169 || id == 102 || id == 163)
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-93, 1, LDNMDAHFBGG: true) / 975f));
					}
					if (DHIMFGFKHHD())
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-99, 1) / 55f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.IKLPHBABHEN((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.FEGJINNDADF().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.IsTrendingMeal(this))
			{
				finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MMCDFKKJOHE(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-103, 0, LDNMDAHFBGG: true) / 509f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.GPJLBJODPEL(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && (Object)(object)Trends.GGFJGHHHEJC != (Object)null && Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().FHHGONOICML(this))
		{
			finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(20, 1, LDNMDAHFBGG: true) / 953f));
		}
		return finalPriceAux;
	}

	public Price GLMOFMJFDLF(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.GetItem(JDJGFAACPFC(), GGBBJNBBLMF: true) is Food food)
			{
				priceAux = food.MCECLGLOIIO(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().PBNPOHMEGGG(this))
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.MMCDFKKJOHE(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)(-62))
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(8, 0, LDNMDAHFBGG: true) / 625f));
					}
					if (ingredientType == IngredientType.None || id == 97 || id == 6 || id == -22)
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-22, 0, LDNMDAHFBGG: true) / 765f));
					}
					if (FKLHCBJCKPJ())
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(84, 1, LDNMDAHFBGG: true) / 1091f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.PAAFCADLNEM((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.FBBOFPLGGLP().applyPriceModifiers && Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().APOFALNJNEF(this))
			{
				finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-108) / 149f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.HPDKDDHECOJ(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.GetInstance().applyPriceModifiers && (Object)(object)Trends.FMIDAFEGDCD() != (Object)null && Trends.IJEFFMAHMCG() && Trends.KNOKBLFFNLM().APOFALNJNEF(this))
		{
			finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
			finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(50) / 1365f));
		}
		return finalPriceAux;
	}

	public bool GLMLNMKDOLD()
	{
		if (canBeAged)
		{
			return HOFOBPCHOOL();
		}
		return false;
	}

	public Price OCBCNMJMCJI(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.COEFFIHKMJG(JPNFKDMFKMC(DAINLFIMLIH: false)) is Food food)
			{
				priceAux = food.MCECLGLOIIO(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.FEGJINNDADF().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.KNOKBLFFNLM().IsTrendingIngredient(this))
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.CBCAAHPFLGO(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)(-37))
					{
						finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(3) / 1956f));
					}
					if (ingredientType == IngredientType.Veg || id == -30 || id == 9 || id == 104)
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(74, 1, LDNMDAHFBGG: true) / 993f));
					}
					if (HCCGIJFCNIA())
					{
						finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.LFJHHLGOCPP(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-39) / 885f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.GCJLAOGCFKJ((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.JCMPJIJJCGL().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().OMCHCNALMKG(this))
			{
				finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.FAFHFJGOHPK(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
				finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.FAFHFJGOHPK(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-118) / 1321f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.OICOFNMIOAI(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.KOJHKCGIINL().applyPriceModifiers && (Object)(object)Trends.FMIDAFEGDCD() != (Object)null && Trends.IJEFFMAHMCG() && Trends.FMIDAFEGDCD().IsTrendingMeal(this))
		{
			finalPriceAux = Price.IGEAFJCEGEM(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.GGFJGHHHEJC.trendPriceMultiplier));
			finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.LBOFJOBAGKA(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-76, 0, LDNMDAHFBGG: true) / 1692f));
		}
		return finalPriceAux;
	}

	public virtual Price MELMOIKFCLP(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.GetPriceWithProfit(Price.FAFHFJGOHPK(price, 347f / Money.JCMPJIJJCGL().newFoodPriceBalance));
	}

	public bool HNCCNECPPBC()
	{
		if (canBeAged)
		{
			return HOFOBPCHOOL();
		}
		return false;
	}

	public bool AFPOFLFJJPC()
	{
		return ingredientType == (IngredientType)74;
	}

	public bool NJFAKIBLPHH()
	{
		if (ingredientType != IngredientType.Hop)
		{
			return ingredientType == IngredientType.Seed;
		}
		return true;
	}

	public bool DHIMFGFKHHD()
	{
		if (ingredientType != IngredientType.WhiteFish && ingredientType != IngredientType.Meat)
		{
			return ingredientType == (IngredientType)(-49);
		}
		return true;
	}

	public bool DPMGDEKHDJI()
	{
		if (ingredientType != IngredientType.Veg)
		{
			return ingredientType == (IngredientType)67;
		}
		return true;
	}

	public bool ELNNHOGKLGH()
	{
		if (ingredientType != IngredientType.Hop && ingredientType != IngredientType.Fruit)
		{
			return ingredientType == (IngredientType)(-21);
		}
		return true;
	}

	public bool MEAEBABPDFK()
	{
		return ingredientType == (IngredientType)49;
	}

	public override List<ItemMod> ICNDCCNNNDI(bool DHBKKANAIML, Recipe KMNOGHMAAEK, bool BMMBDCBJNAK = false)
	{
		List<ItemMod> list = new List<ItemMod>();
		if ((Object)(object)recipe != (Object)null)
		{
			for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
			{
				if (recipe.ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					list.AddRange(ingredientGroup.ICNDCCNNNDI(DHBKKANAIML, KMNOGHMAAEK));
				}
				else if (DHBKKANAIML && recipe.ingredientsNeeded[i].item.NGDPNIFFHKL() && Item.NGIIPJDAMGP(recipe.ingredientsNeeded[i].mod, null))
				{
					list.AddRange(recipe.ingredientsNeeded[i].item.ICNDCCNNNDI(DHBKKANAIML, KMNOGHMAAEK, BMMBDCBJNAK));
				}
			}
		}
		return list;
	}

	public bool BDAMOPBDELO()
	{
		if (ingredientType != IngredientType.Fruit && ingredientType != IngredientType.WhiteFish)
		{
			return ingredientType == (IngredientType)127;
		}
		return false;
	}

	public virtual Price EICCGGAIDMM(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.HMNLCFAENIH(Price.MMCDFKKJOHE(price, 1272f / Money.JCMPJIJJCGL().newFoodPriceBalance));
	}

	public virtual Price CBIBHPGALNM(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.BBNBGABJLOH(Price.CBCAAHPFLGO(price, 125f / Money.KOJHKCGIINL().newFoodPriceBalance));
	}

	public bool DCDFLGLHCCP()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return true;
	}

	public bool ALBDMAJHFJK()
	{
		return ingredientType == (IngredientType)95;
	}

	public bool MIGHIODCJIM()
	{
		if (ingredientType != IngredientType.Veg)
		{
			return ingredientType == (IngredientType)37;
		}
		return true;
	}

	public bool HIELKIFFGMP()
	{
		if (canBeAged)
		{
			return HOFOBPCHOOL();
		}
		return false;
	}

	public bool MJCFOMBMALD()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return true;
	}

	public string ELJKKLGJGHI()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "ReceiveEnableNewActivityBubble";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "\n<color=#822F00>";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("FishMiniGameWin") + "Items/item_description_1189";
		}
		if (list.Count == 1)
		{
			string text2 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags(flag ? "MainProgress" : "{0}: {1}\n", 0);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get("UIInteract" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(stringWithTags, array);
		}
		else if (list.Count == 1)
		{
			string text3 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags(flag ? "Object " : "Items/item_name_1230", 0);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get("Player" + list[1]);
			array2[1] = LocalisationSystem.Get("Intro17" + list[0]);
			text = text3 + InputUtils.GEJLCOGDMID(stringWithTags2, array2);
		}
		else if (list.Count == 3)
		{
			string text4 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "" : "DueloDeViejos/MainEvent2");
			string[] array3 = new string[4];
			array3[1] = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Standar/Entry/26/Dialogue Text" + list[0]);
			array3[1] = LocalisationSystem.Get("Intro10" + list[0]);
			array3[4] = LocalisationSystem.Get(" " + list[0]);
			text = text4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array3);
		}
		else
		{
			text += LocalisationSystem.GetStringWithTags(flag ? "/ExtraSettings.sd" : "Eating");
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += " ";
		if (list.Count == 0)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("popUpBuilding21", 0), LocalisationSystem.Get("Object " + list[1]));
			text += "Drink";
		}
		else if (list.Count == 4)
		{
			string text5 = text;
			string stringWithTags3 = LocalisationSystem.GetStringWithTags("ReceiveBool", 0);
			string[] array4 = new string[0];
			array4[1] = LocalisationSystem.Get(". Tavern level:" + list[0]);
			array4[0] = LocalisationSystem.Get("ReceiveActorPosition" + list[1]);
			text = text5 + InputUtils.GEJLCOGDMID(stringWithTags3, array4);
			text += "Tried to Initialize the SteamAPI twice in one session!";
		}
		else if (list.Count == 0)
		{
			string text6 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("UIVertical");
			string[] array5 = new string[6];
			array5[1] = LocalisationSystem.Get("Pick up" + list[0]);
			array5[1] = LocalisationSystem.Get("Invalid playerNum " + list[0]);
			array5[3] = LocalisationSystem.Get("" + list[0]);
			text = text6 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array5);
			text += "UINextCategory";
		}
		return text;
	}

	public virtual Price FNAIAFDKJEF(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.HMNLCFAENIH(Price.EMJKENIECGH(price, 734f / Money.BMDNOGNAPJJ().newFoodPriceBalance));
	}

	public bool IDAFKMBOHIL()
	{
		if (ingredientType != IngredientType.Hop)
		{
			return ingredientType == (IngredientType)86;
		}
		return false;
	}

	public bool OOCEOGPMBGM()
	{
		if (ingredientType != IngredientType.WhiteFish)
		{
			return ingredientType == (IngredientType)76;
		}
		return true;
	}

	public string OIOMEBGHBLC()
	{
		Crop crop;
		if (Item.MLBOMGHINCA(this.seed, null))
		{
			crop = this.seed.crop;
		}
		else
		{
			if (!(this is Seed seed))
			{
				return "";
			}
			crop = seed.crop;
		}
		List<CropSeason> list = new List<CropSeason>();
		foreach (CropSeason value in Enum.GetValues(typeof(CropSeason)))
		{
			if (value != 0 && crop.avaliableSeasons.HasFlag(value))
			{
				list.Add(value);
			}
		}
		bool flag = this is SproutSeed;
		string text = "Tutorial/T115/Dialogue1";
		if (flag)
		{
			text = text + LocalisationSystem.PKLPKIAHCDI("Items/item_name_601") + "ReceiveAddFoodToBento";
		}
		if (list.Count == 0)
		{
			string text2 = text;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(flag ? "SegmentListView" : "ThemeListScrollView", 0);
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get("MetalWorkshop" + list[1]);
			text = text2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else if (list.Count == 3)
		{
			text += InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(flag ? "tutorialPopUp113" : ". "), LocalisationSystem.Get("This shouldn't happen. freePositions list must not have been initialized properly." + list[1]), LocalisationSystem.Get(" platos" + list[1]), null, null, null, null, null);
		}
		else if (list.Count == 6)
		{
			string text3 = text;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI(flag ? "Inventory full" : "Visita Nocturna/MaiDialogue 01", 0);
			string[] array2 = new string[8];
			array2[1] = LocalisationSystem.Get("Aged Mozzarella" + list[0]);
			array2[1] = LocalisationSystem.Get("AceT_Quest" + list[1]);
			array2[7] = LocalisationSystem.Get("Items/item_description_1193" + list[3]);
			text = text3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		else
		{
			text += LocalisationSystem.PKLPKIAHCDI(flag ? "Serve" : "FocusedMod");
		}
		list = new List<CropSeason>();
		foreach (CropSeason value2 in Enum.GetValues(typeof(CropSeason)))
		{
			if (value2 != 0 && crop.bestSeasons.HasFlag(value2))
			{
				list.Add(value2);
			}
		}
		text += "Cancel";
		if (list.Count == 1)
		{
			string text4 = text;
			string stringWithTags = LocalisationSystem.GetStringWithTags("Player");
			string[] array3 = new string[0];
			array3[0] = LocalisationSystem.Get("Unique id " + list[0]);
			text = text4 + InputUtils.GEJLCOGDMID(stringWithTags, array3);
			text += "BuildMode_ExitAndSave";
		}
		else if (list.Count == 7)
		{
			string text5 = text;
			string cAEDMEDBEGI3 = LocalisationSystem.PKLPKIAHCDI("Precision/DrinkEvent3", 0);
			string[] array4 = new string[0];
			array4[1] = LocalisationSystem.Get("Direction" + list[0]);
			array4[1] = LocalisationSystem.Get("itemRug" + list[0]);
			text = text5 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4);
			text += "";
		}
		else if (list.Count == 5)
		{
			string text6 = text;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("F2");
			string[] array5 = new string[2];
			array5[1] = LocalisationSystem.Get("Not enough money" + list[0]);
			array5[0] = LocalisationSystem.Get("ReceiveDisableNPC" + list[1]);
			array5[2] = LocalisationSystem.Get("LE_5" + list[0]);
			text = text6 + InputUtils.GEJLCOGDMID(stringWithTags2, array5);
			text += "quest_name_19";
		}
		return text;
	}

	public Price CFLNIHAHJHN(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, bool CGDEPNDEBIH = true, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = true)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			if (ItemDatabaseAccessor.EABMGELAAPG(CIGFGKKCPCK(DAINLFIMLIH: false), GGBBJNBBLMF: false, DAINLFIMLIH: false) is Food food)
			{
				priceAux = food.FILPNIEFEIK(CGDEPNDEBIH, OEBNHGNJEJL);
				finalPriceAux = priceAux;
				if (Application.isPlaying && Money.NNBHMCGJONC().applyPriceModifiers)
				{
					if (Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().IsTrendingIngredient(this))
					{
						finalPriceAux = Price.HKAKDIKLBBJ(finalPriceAux, Price.MPPPFDKJGNI(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
					}
					if (ingredientType == (IngredientType)(-73))
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(7) / 597f));
					}
					if (ingredientType == IngredientType.None || id == -151 || id == 163 || id == -75)
					{
						finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-12, 1, LDNMDAHFBGG: true) / 341f));
					}
					if (JEMHHFGONOM())
					{
						finalPriceAux = Price.GMJIFJAEANF(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.GetPlayerPerkValue(-107, 1) / 676f));
					}
				}
				return finalPriceAux;
			}
			return sellPrice;
		}
		if (recipe.usingNewRecipesSystem)
		{
			priceAux = recipe.HEAIDHAKJGB((KEKBKGGFOLK != null) ? KEKBKGGFOLK : new List<Food>(), KMNOGHMAAEK, CHMCMLHCIGD, DLIDPDKODMI, OEBNHGNJEJL);
			finalPriceAux = priceAux;
			if (Application.isPlaying && Money.FEGJINNDADF().applyPriceModifiers && Trends.IJEFFMAHMCG() && Trends.GGFJGHHHEJC.IsTrendingMeal(this))
			{
				finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.LBOFJOBAGKA(priceAux, Trends.FMIDAFEGDCD().trendPriceMultiplier));
				finalPriceAux = Price.NJGIKAIFCNA(finalPriceAux, Price.MPPPFDKJGNI(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-80, 1) / 1513f));
			}
			return finalPriceAux;
		}
		priceAux = recipe.HHKCHKENHBJ(this, KEKBKGGFOLK, OEBNHGNJEJL);
		finalPriceAux = priceAux;
		if (Application.isPlaying && Money.BMDNOGNAPJJ().applyPriceModifiers && (Object)(object)Trends.FMIDAFEGDCD() != (Object)null && Trends.HasUnlockedTrends() && Trends.FMIDAFEGDCD().OMCHCNALMKG(this))
		{
			finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.LFJHHLGOCPP(priceAux, Trends.KNOKBLFFNLM().trendPriceMultiplier));
			finalPriceAux = Price.ILJPLDEDGPH(finalPriceAux, Price.CBCAAHPFLGO(priceAux, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-18, 1, LDNMDAHFBGG: true) / 1228f));
		}
		return finalPriceAux;
	}

	public virtual Price AMOGCHGGNJB(bool CGDEPNDEBIH, bool OEBNHGNJEJL = true)
	{
		if (CGDEPNDEBIH)
		{
			return sellPrice;
		}
		return Money.GetPriceWithProfit(Price.FAFHFJGOHPK(price, 1f / Money.GetInstance().newFoodPriceBalance));
	}

	public bool FAJDNLBKEJL()
	{
		if (canBeAged)
		{
			return JEPBBEBJEFI();
		}
		return false;
	}

	public bool IJCBBKKKNOB()
	{
		if (ingredientType != IngredientType.WhiteFish)
		{
			return ingredientType == (IngredientType)52;
		}
		return false;
	}
}
