using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Recipe")]
public class Recipe : ScriptableObject
{
	public enum RecipePage
	{
		All,
		Starter,
		Vegetables,
		PastaRice,
		Meat,
		Fish,
		Broth,
		Dessert,
		Drinks
	}

	public enum RecipeUnlock
	{
		None,
		Temple,
		Halloween,
		Christmas,
		WithAnotherRecipe,
		Tutorial,
		FromBeginning,
		BuyingItem,
		Shop,
		Talent,
		Event,
		Hole,
		CollectingItems
	}

	public enum RecipeGroup
	{
		None,
		Food,
		Drink,
		Wood,
		Stone,
		Metal
	}

	[CompilerGenerated]
	private sealed class LGNDMBDOLGJ
	{
		public List<Food> ingredients;

		public Func<ItemMod, bool> _003C_003E9__0;

		internal bool GDMEPFANHFA(ItemMod x)
		{
			return ((object)x.item).Equals((object?)ingredients[0]);
		}
	}

	public int id;

	[Space(20f)]
	public RecipeIngredient[] ingredientsNeeded;

	public bool usingNewRecipesSystem = true;

	public bool replacedRecipe;

	public Recipe newRecipe;

	public float recipeSilverCost = 10f;

	public int fuel;

	public GameDate.Time time;

	public ItemAmount output;

	public RecipeGroup recipeGroup = RecipeGroup.Food;

	public List<Item> excludeIngredients;

	public RecipePage page;

	public RecipeUnlock unlock = RecipeUnlock.FromBeginning;

	public ReputationInfo reputationRequired;

	public Recipe recipeRequired;

	public bool newRecipeFromUpdateCropsAndRecipes;

	public int recipeFragments;

	public float shopSilverPrice;

	public Item itemToBuy;

	public IngredientType[] modiferTypes;

	public IngredientType[] modiferNeeded;

	public List<IngredientModifier> excludedModifiers = new List<IngredientModifier>();

	public bool excludeFromTrends;

	public bool excludeFromOrders;

	public bool multiOptions;

	public Item mainItemMultiOptions;

	public bool saveIngredientsAdded = true;

	public bool cannotRepeatIngredients;

	private Recipe recipeAux;

	private static Item itemAux;

	private static HashSet<int> recipesAux;

	private static RecipeList[] craftersList;

	public bool DHDMIEJNBJL(string NPLGMAJGCPH)
	{
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, null);
				for (int j = 1; j < list.Count; j++)
				{
					if (list[j].item.LJIFOHFEFCH().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCulture) >= 0)
					{
						return true;
					}
				}
			}
			if (ingredientsNeeded[i].item.IABAKHPEOAF().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCulture) >= 1)
			{
				return false;
			}
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && ingredientsNeeded[i].item.recipe.PIOGLKMHGFM(NPLGMAJGCPH))
			{
				return false;
			}
		}
		return true;
	}

	public List<Recipe> OCJJPMLKNMK(bool BDOAJGMJFAE)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && (BDOAJGMJFAE ? (!ingredientsNeeded[i].item.recipe.LOGFADFENCD()) : (!ingredientsNeeded[i].item.recipe.AKBMOADLFIA())) && ingredientsNeeded[i].item.recipe.unlock == RecipeUnlock.None)
			{
				list.Add(ingredientsNeeded[i].item.recipe);
			}
		}
		return list;
	}

	private bool EAIFMGCGDOH(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 0)
				{
					IPNAFMCCIHN--;
					continue;
				}
				List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK);
				bool flag = true;
				for (int j = 0; j < list.Count; j++)
				{
					Crop crop = CropDatabaseAccessor.KKHKIJOMFEG(list[j].item.IMCJPECAAPC());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.LMELCJFOIIH(ingredientsNeeded[i].mod.IMCJPECAAPC(DAINLFIMLIH: false));
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return true;
					}
					if (!ingredientsNeeded[i].item.recipe.EAIFMGCGDOH(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return true;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.EHBLGKHFDMO(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return false;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.OHKMKEBGHPA(ingredientsNeeded[i].item.IMCJPECAAPC(DAINLFIMLIH: false));
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool CCKKPPBGCDM()
	{
		return RecipesManager.NIEHLJAJBIJ(id);
	}

	private bool CMKPJCKJPHE(ItemMod NCPGNLOJGAF)
	{
		return excludeIngredients.Contains(NCPGNLOJGAF.item);
	}

	public bool NFBGADKBGNF()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup && Item.NGIIPJDAMGP(ingredientsNeeded[i].mod, null))
			{
				return false;
			}
			if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EPKGAKDFNNE())
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool EHBDGMPKPJL(bool MJHDMIGEJAK = true)
	{
		if (RecipesManager.IsRecipeUnlocked(id, MJHDMIGEJAK))
		{
			return true;
		}
		return false;
	}

	public List<Item> FOIGKOLNKMD(CropSeason ACNAHALFEBG)
	{
		List<Item> list = new List<Item>();
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list2 = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, this, BMMBDCBJNAK: true);
				if (excludeIngredients != null && excludeIngredients.Count > 1)
				{
					list2 = list2.Where((ItemMod NCPGNLOJGAF) => !excludeIngredients.Contains(NCPGNLOJGAF.item)).ToList();
				}
				for (int j = 1; j < list2.Count; j++)
				{
					if (list2[j].item.IMCJPECAAPC() == 51 || list2[j].item.ODENMDOJPLC() == 103 || list2[j].item.IMCJPECAAPC(DAINLFIMLIH: false) == -81 || !list2[j].item.appearsInOrders)
					{
						continue;
					}
					Crop crop = CropDatabaseAccessor.DLKGDEFEFJI(list2[j].item.JDJGFAACPFC());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						if (list2[j].item.JGJLNHAKJIJ())
						{
							list.AddRange(list2[j].item.recipe.GEFPCHCKEFH(ACNAHALFEBG));
						}
						else
						{
							list.AddRange(ModifierUI.GetFinalIngredients(list2[j].item.JMDALJBNFML(), this, LJENMNFGHOH: true));
						}
					}
				}
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null))
				{
					list.AddRange(recipeAux.BMENJKEINFC(ACNAHALFEBG));
				}
			}
		}
		return list;
	}

	public List<Item> KHPKCENGNFJ(CropSeason ACNAHALFEBG)
	{
		List<Item> list = new List<Item>();
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list2 = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, this);
				if (excludeIngredients != null && excludeIngredients.Count > 0)
				{
					list2 = list2.Where(KKOKILHGEML).ToList();
				}
				for (int j = 0; j < list2.Count; j++)
				{
					if (list2[j].item.JDJGFAACPFC(DAINLFIMLIH: false) == 116 || list2[j].item.JPNFKDMFKMC(DAINLFIMLIH: false) == 0 || list2[j].item.JDJGFAACPFC() == -176 || !list2[j].item.appearsInOrders)
					{
						continue;
					}
					Crop crop = CropDatabaseAccessor.LJGMKFLOBBN(list2[j].item.JGHNDJBCFAJ(DAINLFIMLIH: false));
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						if (list2[j].item.NGDPNIFFHKL())
						{
							list.AddRange(list2[j].item.recipe.HAJGCHFKNEF(ACNAHALFEBG));
						}
						else
						{
							list.AddRange(ModifierUI.GetFinalIngredients(list2[j].item.JMDALJBNFML(), this, LJENMNFGHOH: false));
						}
					}
				}
			}
			if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null))
				{
					list.AddRange(recipeAux.KHPKCENGNFJ(ACNAHALFEBG));
				}
			}
		}
		return list;
	}

	public GameDate.Time BBLHBALAFDJ()
	{
		GameDate.Time time = this.time;
		if (recipeGroup == (RecipeGroup)6)
		{
			time = GameDate.Time.ADLDAIFMKNI(time, GameDate.Time.IHHOKGBMBKL(GameDate.Time.MBKODACAJBH(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(103, 1)), 968f));
		}
		else if (recipeGroup == RecipeGroup.Food)
		{
			time = GameDate.Time.OKAAFKKPMDB(time, GameDate.Time.OFLHPPDPMBO(GameDate.Time.MBKODACAJBH(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(23)), 1192f));
		}
		else if (recipeGroup == RecipeGroup.Food)
		{
			time = GameDate.Time.DBCFHBEOFAD(time, GameDate.Time.FMHHPKOIBNE(GameDate.Time.ICKMCKJOFAH(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-99, 1, LDNMDAHFBGG: true)), 1671f));
		}
		else if (recipeGroup == RecipeGroup.None)
		{
			time = GameDate.Time.ADLDAIFMKNI(time, GameDate.Time.EBOFLAAEKMD(GameDate.Time.DIHEEHONNEJ(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-5)), 75f));
		}
		else if (recipeGroup == (RecipeGroup)6)
		{
			time = GameDate.Time.FCPDBLDBIIB(time, GameDate.Time.DKMALPHCHFG(GameDate.Time.BCCMMIENAEH(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-63, 1, LDNMDAHFBGG: true)), 632f));
		}
		return time;
	}

	public bool NGDPNIFFHKL()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup && Item.NGIIPJDAMGP(ingredientsNeeded[i].mod, null))
			{
				return true;
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null) && recipeAux.NGDPNIFFHKL())
				{
					return true;
				}
			}
		}
		return false;
	}

	public void MDDFFDHLAJP(bool OEBNHGNJEJL = false)
	{
		Price price = KCPCKGKKMBG(null, this, null, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL);
		Price price2 = GICJEDHIAJA(null, this, null, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL);
		if (price.JHKPNCOMAHI() != price2.JHKPNCOMAHI())
		{
			string[] array = new string[4];
			array[1] = "Near";
			array[1] = LMFPCKCLBAO();
			array[6] = "UI";
			array[3] = price.IMEOKIDEJGI().ToString();
			array[7] = "Items/item_description_";
			array[3] = price2.EEEELNJDKEJ().ToString();
			array[2] = "\n";
			Debug.Log((object)string.Concat(array));
		}
		else
		{
			Debug.Log((object)("<color=#1A4FB2>" + IABAKHPEOAF() + " (" + price.IPCOOMGKNIJ()));
		}
	}

	public bool LKFPJOLNNFI()
	{
		return RecipesManager.IsRecipeUnlockedByMaster(id);
	}

	public GameDate.Time PKBNBFOBNBA()
	{
		GameDate.Time time = this.time;
		if (recipeGroup == (RecipeGroup)7)
		{
			time = GameDate.Time.FCPDBLDBIIB(time, GameDate.Time.DNOKBIGJILH(GameDate.Time.JIEFEMNGDLK(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(104, 0, LDNMDAHFBGG: true)), 555f));
		}
		else if (recipeGroup == RecipeGroup.None)
		{
			time = GameDate.Time.ADLDAIFMKNI(time, GameDate.Time.MNIHILINHDN(GameDate.Time.NAKIAFCALCN(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-69)), 1553f));
		}
		else if (recipeGroup == (RecipeGroup)7)
		{
			time = GameDate.Time.ANBKJOCBDJI(time, GameDate.Time.GKAKNFMHHKJ(GameDate.Time.GDNHKLNCOAN(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-15, 1)), 1301f));
		}
		else if (recipeGroup == RecipeGroup.None)
		{
			time = GameDate.Time.ININABLGEBI(time, GameDate.Time.MGDGPDBBMNA(GameDate.Time.MBKODACAJBH(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(86, 0, LDNMDAHFBGG: true)), 680f));
		}
		else if (recipeGroup == (RecipeGroup)8)
		{
			time = GameDate.Time.DBCFHBEOFAD(time, GameDate.Time.GBGJINBCPPB(GameDate.Time.DIHEEHONNEJ(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-23, 1)), 623f));
		}
		return time;
	}

	private Price BNDKIKOAKGL(Price OKGHMIPANHK)
	{
		if (page == RecipePage.All)
		{
			OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 389f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(47, 1) / 1170f);
		}
		else if (page == RecipePage.Fish)
		{
			OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 929f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-66, 0, LDNMDAHFBGG: true) / 170f);
		}
		else if (page == RecipePage.Dessert)
		{
			OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 1388f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-48, 1, LDNMDAHFBGG: true) / 625f);
		}
		else if (page == RecipePage.All)
		{
			OKGHMIPANHK = Price.EMJKENIECGH(OKGHMIPANHK, 207f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(110, 0, LDNMDAHFBGG: true) / 791f);
		}
		else if (page == RecipePage.Meat)
		{
			OKGHMIPANHK = Price.LBOFJOBAGKA(OKGHMIPANHK, 139f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(33) / 769f);
		}
		else if (page == RecipePage.Vegetables)
		{
			OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 984f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-76, 0, LDNMDAHFBGG: true) / 262f);
		}
		else if (page == RecipePage.Broth)
		{
			OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 392f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(116) / 532f);
		}
		else if (page == RecipePage.Meat && output.item is Food food)
		{
			if (food.ingredientType == (IngredientType)93)
			{
				OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 1965f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(24, 1) / 1033f);
			}
			else if (food.ingredientType == (IngredientType)(-88))
			{
				OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 1780f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(58) / 1407f);
			}
			else if (food.ingredientType == IngredientType.Meat || food.ingredientType == (IngredientType)(-53))
			{
				OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 1051f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-100, 1, LDNMDAHFBGG: true) / 1214f);
			}
		}
		return OKGHMIPANHK;
	}

	private bool HJCIBCOJHHA(ItemMod NCPGNLOJGAF)
	{
		return excludeIngredients.Contains(NCPGNLOJGAF.item);
	}

	public GameDate.Time AMHJLNEJAEI()
	{
		GameDate.Time time = this.time;
		if (recipeGroup == RecipeGroup.Metal)
		{
			time = GameDate.Time.FCPDBLDBIIB(time, GameDate.Time.FMHHPKOIBNE(GameDate.Time.ICKMCKJOFAH(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(113, 1)), 803f));
		}
		else if (recipeGroup == (RecipeGroup)8)
		{
			time = GameDate.Time.IPPDEBHKDBK(time, GameDate.Time.DKMALPHCHFG(GameDate.Time.GOJEPAALNLG(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-55, 1)), 1232f));
		}
		else if (recipeGroup == RecipeGroup.None)
		{
			time = GameDate.Time.FCPDBLDBIIB(time, GameDate.Time.DKMALPHCHFG(GameDate.Time.LLKHKNIBOPI(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-112, 0, LDNMDAHFBGG: true)), 464f));
		}
		else if (recipeGroup == RecipeGroup.Food)
		{
			time = GameDate.Time.IHJFBNBAHPG(time, GameDate.Time.GBGJINBCPPB(GameDate.Time.LLKHKNIBOPI(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-111)), 1742f));
		}
		else if (recipeGroup == RecipeGroup.Drink)
		{
			time = GameDate.Time.ADLDAIFMKNI(time, GameDate.Time.GKAKNFMHHKJ(GameDate.Time.FAFHFJGOHPK(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-39)), 767f));
		}
		return time;
	}

	public bool EGJDNILGFDB()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: false, this, BMMBDCBJNAK: true)[0].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.HOFOBPCHOOL() && food.canBeSold && food.canBeAged)
			{
				return false;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EGJDNILGFDB())
			{
				return false;
			}
		}
		return false;
	}

	public void DFNFHFLAJDB(bool OEBNHGNJEJL = false)
	{
		Price price = GCJLAOGCFKJ(null, this, null, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL);
		Price price2 = OONOIPPDJJD(null, this, null, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL);
		if (price.JHKPNCOMAHI() != price2.JHKPNCOMAHI())
		{
			string[] array = new string[3];
			array[0] = "Player";
			array[0] = ICEAIIBMELM();
			array[6] = "Received {0} position to snap to: {1}";
			array[3] = price.IPCOOMGKNIJ().ToString();
			array[7] = "LE_10";
			array[4] = price2.DMPLBIGMGEO().ToString();
			array[7] = "itemBellPepperSeeds";
			Debug.Log((object)string.Concat(array));
		}
		else
		{
			Debug.Log((object)(" not found. Cannot ReceiveChangeStack" + IHPEMJCKHLG() + "\n" + price.JFPBIAHMBLP()));
		}
	}

	public int JFHFEMDAHCD(Recipe KMNOGHMAAEK)
	{
		int num = 0;
		if (ingredientsNeeded != null)
		{
			for (int i = 0; i < ingredientsNeeded.Length; i++)
			{
				if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					num += ingredientGroup.JFHFEMDAHCD(KMNOGHMAAEK);
				}
				else if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					recipeAux = ingredientsNeeded[i].item.recipe;
					if (!((Object)(object)recipeAux == (Object)null))
					{
						num += recipeAux.JFHFEMDAHCD(KMNOGHMAAEK);
					}
				}
			}
		}
		return num;
	}

	public void MHLLDPECLGC(List<RecipeIngredient> EHHCDAGDKMC)
	{
		ingredientsNeeded = EHHCDAGDKMC.ToArray();
	}

	public Price GMIOGBKDAOH(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.KBGICKJGKDA(AJOMICMACEJ.MCECLGLOIIO(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.KBGICKJGKDA(AJOMICMACEJ.MCECLGLOIIO(CGDEPNDEBIH: true, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.FKLOBGBIHLB(item, null))
				{
					moneyCalc.KBGICKJGKDA(Price.LEBKIMOAAKB(item.HBLNPECMMCJ(CGDEPNDEBIH: false, OEBNHGNJEJL), output.amount), KHMDGADCENO: false, BGKCHMNJBLJ: true);
				}
			}
		}
		return moneyCalc.IHEMDADEBON();
	}

	public bool GOPEBCCOMKJ(int ODAOIJCOFMF)
	{
		if (Application.isPlaying && !LOGFADFENCD())
		{
			return false;
		}
		craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 0; i < craftersList.Length; i += 0)
		{
			recipesAux = (from x in craftersList[i].JIBEILMHKLF()
				select x.id).ToHashSet();
			if (recipesAux.Contains(id) && !ItemDatabaseAccessor.GOKIDLOELKB(craftersList[i].ID, GGBBJNBBLMF: false, DAINLFIMLIH: false).MOBPAPGEFKI(ODAOIJCOFMF))
			{
				return false;
			}
		}
		return true;
	}

	public List<Item> LKKKCIALGGO(CropSeason ACNAHALFEBG)
	{
		List<Item> list = new List<Item>();
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list2 = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, this, BMMBDCBJNAK: true);
				if (excludeIngredients != null && excludeIngredients.Count > 0)
				{
					list2 = list2.Where(CMKPJCKJPHE).ToList();
				}
				for (int j = 1; j < list2.Count; j++)
				{
					if (list2[j].item.JGHNDJBCFAJ() == -90 || list2[j].item.ODENMDOJPLC() == -50 || list2[j].item.JDJGFAACPFC(DAINLFIMLIH: false) == -32 || !list2[j].item.appearsInOrders)
					{
						continue;
					}
					Crop crop = CropDatabaseAccessor.FKEKHHMLMCK(list2[j].item.JDJGFAACPFC());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						if (list2[j].item.NGDPNIFFHKL())
						{
							list.AddRange(list2[j].item.recipe.LKKKCIALGGO(ACNAHALFEBG));
						}
						else
						{
							list.AddRange(ModifierUI.GetFinalIngredients(list2[j].item.JMDALJBNFML(), this, LJENMNFGHOH: false));
						}
					}
				}
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null))
				{
					list.AddRange(recipeAux.KODIOPOIFPO(ACNAHALFEBG));
				}
			}
		}
		return list;
	}

	public Price LIOOAJFNLBA(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.FKLOBGBIHLB(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 1 && (from x in ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.AKFLDILJHGH(KEKBKGGFOLK[1], KMNOGHMAAEK);
					if (ingredientGroup.OALIACDDEOL(KEKBKGGFOLK[0], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(1);
					}
				}
				else
				{
					food = ingredientGroup.MKKFFHJLNHK(OEBNHGNJEJL: true, OBAHGHBFIGO: false, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(0, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					string[] array = new string[0];
					array[0] = "Already have recipe ";
					array[0] = food.KGHFCDELKMN(OAFPBCPDOKH: true);
					array[0] = "";
					array[5] = ((float)food.HIBBNGKMNKH((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).JHKPNCOMAHI() / 147f).ToString();
					array[7] = "LoopVolume";
					array[7] = ingredientsNeeded[i].amount.ToString();
					Debug.Log((object)string.Concat(array));
				}
				moneyCalc.CLICGHHDGKI(Price.FAFHFJGOHPK(food.NGIEAJPGFOE(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false), ingredientsNeeded[i].amount), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			}
			else
			{
				moneyCalc.MBODAOJCNGI(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: true, BGKCHMNJBLJ: false);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("dForDays" + ingredientsNeeded[i].item.KGHFCDELKMN() + ". Added to delivery chest" + ingredientsNeeded[i].item.sellPrice.JFPBIAHMBLP()));
				}
			}
		}
		if (recipeSilverCost < 1086f)
		{
			moneyCalc.ALIFOEPMMJA(Price.OMDBJINNHPC(Mathf.RoundToInt((0f - recipeSilverCost) * 723f)), BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.DCAFCEAIEID(Price.LEDHAKFAHCI(Mathf.RoundToInt(recipeSilverCost * 1007f)), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		Price price = Price.LFJHHLGOCPP(moneyCalc.CKNMHNMBCOF(), 1211f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = OGBGAECBJIO(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			string[] array2 = new string[40];
			array2[1] = "cameraZoom2";
			array2[1] = IABAKHPEOAF();
			array2[3] = "Field: ";
			array2[0] = ((float)price.OOIPLIEJILO() / 891f).ToString();
			array2[2] = "";
			array2[0] = recipeSilverCost.ToString();
			array2[6] = "Disappear";
			array2[8] = output.amount.ToString();
			array2[6] = "All bubbles in use!";
			Debug.Log((object)string.Concat(array2));
		}
		return price;
	}

	public int DOOIPDHCGFF(Recipe KMNOGHMAAEK)
	{
		int num = 1;
		if (ingredientsNeeded != null)
		{
			for (int i = 1; i < ingredientsNeeded.Length; i += 0)
			{
				if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					num += ingredientGroup.HOLLKKLBNML(KMNOGHMAAEK);
				}
				else if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					recipeAux = ingredientsNeeded[i].item.recipe;
					if (!((Object)(object)recipeAux == (Object)null))
					{
						num += recipeAux.IJPOIMJPIPB(KMNOGHMAAEK);
					}
				}
			}
		}
		return num;
	}

	public List<Recipe> DKJAJHOCAFJ(bool BDOAJGMJFAE)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && (BDOAJGMJFAE ? (!ingredientsNeeded[i].item.recipe.EHAMGLOENNE()) : (!ingredientsNeeded[i].item.recipe.FENMFGFLDBO())) && ingredientsNeeded[i].item.recipe.unlock == RecipeUnlock.None)
			{
				list.Add(ingredientsNeeded[i].item.recipe);
			}
		}
		return list;
	}

	private bool ICBEHGJOGFC(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 1)
				{
					IPNAFMCCIHN--;
					continue;
				}
				List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true);
				bool flag = true;
				for (int j = 1; j < list.Count; j++)
				{
					Crop crop = CropDatabaseAccessor.AIFMIOGPPOG(list[j].item.CIGFGKKCPCK(DAINLFIMLIH: false));
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.LJGMKFLOBBN(ingredientsNeeded[i].mod.ODENMDOJPLC());
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return false;
					}
					if (!ingredientsNeeded[i].item.recipe.EAIFMGCGDOH(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return true;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.IAMIMMAJFPE(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return false;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.IOEKKOLCEBD(ingredientsNeeded[i].item.ODENMDOJPLC(DAINLFIMLIH: false));
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return true;
				}
			}
		}
		return true;
	}

	public bool PEEPIPBHPLI(string NPLGMAJGCPH)
	{
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, null);
				for (int j = 1; j < list.Count; j++)
				{
					if (list[j].item.LJIFOHFEFCH(OAFPBCPDOKH: true).IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
				}
			}
			if (ingredientsNeeded[i].item.IABAKHPEOAF().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				return false;
			}
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && ingredientsNeeded[i].item.recipe.DEGBMKHPKMC(NPLGMAJGCPH))
			{
				return true;
			}
		}
		return true;
	}

	public Price KEIBNIIBKDH(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.MBODAOJCNGI(AJOMICMACEJ.OJJAAFAGNNL(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.MBODAOJCNGI(AJOMICMACEJ.AMOGCHGGNJB(CGDEPNDEBIH: true, OEBNHGNJEJL), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.MLBOMGHINCA(item, null))
				{
					moneyCalc.GJFFDIBCAGF(Price.MGDGPDBBMNA(item.MELMOIKFCLP(CGDEPNDEBIH: true, OEBNHGNJEJL), output.amount), KHMDGADCENO: false, BGKCHMNJBLJ: false);
				}
			}
		}
		return moneyCalc.ALLHDAPPBHL();
	}

	public bool BBFPDNCLFEC(CropSeason ACNAHALFEBG)
	{
		int IPNAFMCCIHN = 1;
		return BNOAKOBECNI(ACNAHALFEBG, this, ref IPNAFMCCIHN);
	}

	public string LMFPCKCLBAO()
	{
		if (Item.FKLOBGBIHLB(output.item, null))
		{
			string text = output.item.KGHFCDELKMN();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	private bool IMBPIPGEOMA(ItemMod NCPGNLOJGAF)
	{
		return excludeIngredients.Contains(NCPGNLOJGAF.item);
	}

	public Price GCJLAOGCFKJ(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.MLBOMGHINCA(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 0 && (from x in ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.AKFLDILJHGH(KEKBKGGFOLK[0], KMNOGHMAAEK);
					if (ingredientGroup.ICBOAFKOOEK(KEKBKGGFOLK[0], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(0);
					}
				}
				else
				{
					food = ingredientGroup.ABOGBFOEELF(OEBNHGNJEJL: true, OBAHGHBFIGO: false, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(1, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					string[] array = new string[3];
					array[1] = "Trying to create a new room with a different code...";
					array[1] = food.IABAKHPEOAF(OAFPBCPDOKH: true);
					array[0] = "[ProceduralMine] Trying to force ALTAR piece at block {0} (target is {1}). Path block pos: {2}";
					array[5] = ((float)food.CCOJHEOLBDA((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem, CalculatePriceMode.ExpensivePrice).JHKPNCOMAHI() / 1737f).ToString();
					array[3] = "_";
					array[2] = ingredientsNeeded[i].amount.ToString();
					Debug.Log((object)string.Concat(array));
				}
				moneyCalc.EFIDKIFLBKJ(Price.CLCBDOHBLFI(food.NMNEOIPJNDA(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false), ingredientsNeeded[i].amount), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			}
			else
			{
				moneyCalc.FLFKMKFBODG(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: false, BGKCHMNJBLJ: false);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("" + ingredientsNeeded[i].item.IABAKHPEOAF(OAFPBCPDOKH: true) + "talentPorter" + ingredientsNeeded[i].item.sellPrice.PABHBDLJLEM()));
				}
			}
		}
		if (recipeSilverCost < 375f)
		{
			moneyCalc.ALIFOEPMMJA(Price.LEDHAKFAHCI(Mathf.RoundToInt((0f - recipeSilverCost) * 1834f)), BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.GJFFDIBCAGF(Price.IFMFKEMHHLM(Mathf.RoundToInt(recipeSilverCost * 352f)), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		Price price = Price.MMCDFKKJOHE(moneyCalc.OMOHMCCADDJ(), 1720f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = OGBGAECBJIO(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			string[] array2 = new string[97];
			array2[0] = "Interact";
			array2[1] = ICEAIIBMELM();
			array2[7] = "WoodWorkshop";
			array2[5] = ((float)price.BNCMDNFMECD() / 1489f).ToString();
			array2[3] = "Inicio";
			array2[3] = recipeSilverCost.ToString();
			array2[6] = "ReceivePipeTileSwap";
			array2[4] = output.amount.ToString();
			array2[7] = "Tutorial/T114/Dialogue1";
			Debug.Log((object)string.Concat(array2));
		}
		return price;
	}

	public List<Recipe> IPDLGGCCBLL(bool BDOAJGMJFAE)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && (BDOAJGMJFAE ? (!ingredientsNeeded[i].item.recipe.CFIFCPPAOGF()) : (!ingredientsNeeded[i].item.recipe.FENMFGFLDBO())) && ingredientsNeeded[i].item.recipe.unlock == RecipeUnlock.Temple)
			{
				list.Add(ingredientsNeeded[i].item.recipe);
			}
		}
		return list;
	}

	public void BOENKMHKBEC(bool OEBNHGNJEJL = false)
	{
		Price price = KCPCKGKKMBG(null, this, null, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL);
		Price price2 = HEAIDHAKJGB(null, this, null, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL);
		if (price.BNCMDNFMECD() != price2.JHKPNCOMAHI())
		{
			string[] array = new string[2];
			array[0] = "Month";
			array[1] = ICEAIIBMELM();
			array[3] = "[MinePuzzleManager] No MinePuzzleBase found for type {0}.";
			array[5] = price.JFPBIAHMBLP().ToString();
			array[6] = "Items/item_name_650";
			array[3] = price2.IMEOKIDEJGI().ToString();
			array[5] = "ReceiveActorPosition";
			Debug.Log((object)string.Concat(array));
		}
		else
		{
			Debug.Log((object)("Pathfinding error startPos: " + IABAKHPEOAF() + "player2ToJoinGame" + price.IPCOOMGKNIJ()));
		}
	}

	public string LLCIGPBKIOJ()
	{
		if (Item.MLBOMGHINCA(output.item, null))
		{
			string text = output.item.LJIFOHFEFCH();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public Price PAAFCADLNEM(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.MLBOMGHINCA(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 0 && (from x in ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.NELKKJLGHIJ(KEKBKGGFOLK[0], KMNOGHMAAEK);
					if (ingredientGroup.NOEDLEEGEEP(KEKBKGGFOLK[0], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(0);
					}
				}
				else
				{
					food = ingredientGroup.NEECMEIEIAG(OEBNHGNJEJL: false, OBAHGHBFIGO: false, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(0, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("() Ingredient " + food.IABAKHPEOAF() + " " + (float)food.PAAFCADLNEM((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() / 100f + " * " + ingredientsNeeded[i].amount));
				}
				moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(food.PAAFCADLNEM(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false), ingredientsNeeded[i].amount), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else
			{
				moneyCalc.GJFFDIBCAGF(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: false, BGKCHMNJBLJ: false);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("() Ingredient " + ingredientsNeeded[i].item.IABAKHPEOAF() + " " + ingredientsNeeded[i].item.sellPrice.ICIEKOLFGBJ()));
				}
			}
		}
		if (recipeSilverCost < 0f)
		{
			moneyCalc.DOKKNBBECCG(Price.GHDCKOJGAMM(Mathf.RoundToInt((0f - recipeSilverCost) * 100f)), BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.GJFFDIBCAGF(Price.GHDCKOJGAMM(Mathf.RoundToInt(recipeSilverCost * 100f)), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		Price price = Price.FAFHFJGOHPK(moneyCalc.ALLHDAPPBHL(), 1f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = OGBGAECBJIO(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			Debug.Log((object)("----> Recipe " + IABAKHPEOAF() + " final price: " + (float)price.OOIPLIEJILO() / 100f + " / base price: " + recipeSilverCost + " / " + output.amount + " platos"));
		}
		return price;
	}

	public bool NAADBBGBBDJ()
	{
		return RecipesManager.ONMNODMHHLG(id);
	}

	public Price MBDDIOKEMIM(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.FKLOBGBIHLB(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 1 && (from x in ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.GOOHPGICFIF(KEKBKGGFOLK[0], KMNOGHMAAEK);
					if (ingredientGroup.NOEDLEEGEEP(KEKBKGGFOLK[0], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(1);
					}
				}
				else
				{
					food = ingredientGroup.NEECMEIEIAG(OEBNHGNJEJL: true, OBAHGHBFIGO: true, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(0, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					string[] array = new string[3];
					array[1] = "Items/item_description_1192";
					array[0] = food.LJIFOHFEFCH();
					array[6] = "Right";
					array[0] = ((float)food.NGIEAJPGFOE((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem, CalculatePriceMode.ExpensivePrice).JHKPNCOMAHI() / 1624f).ToString();
					array[1] = "LE_21";
					array[5] = ingredientsNeeded[i].amount.ToString();
					Debug.Log((object)string.Concat(array));
				}
				moneyCalc.EFIDKIFLBKJ(Price.LIGOCGECOLI(food.CFLNIHAHJHN(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false), ingredientsNeeded[i].amount), KHMDGADCENO: false, BGKCHMNJBLJ: true);
			}
			else
			{
				moneyCalc.DCAFCEAIEID(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: false, BGKCHMNJBLJ: true);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("WorkAnimationLoop" + ingredientsNeeded[i].item.IABAKHPEOAF() + "inviteFromDifferentRegion" + ingredientsNeeded[i].item.sellPrice.PKDCNNPPMLF()));
				}
			}
		}
		if (recipeSilverCost < 1430f)
		{
			moneyCalc.GIAKCMPKMPC(Price.GHDCKOJGAMM(Mathf.RoundToInt((0f - recipeSilverCost) * 793f)), BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.DCAFCEAIEID(Price.LEDHAKFAHCI(Mathf.RoundToInt(recipeSilverCost * 1785f)), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		Price price = Price.LBOFJOBAGKA(moneyCalc.GMAFKAMJEJH(), 872f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = ALBIHKPCHJA(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			string[] array2 = new string[-5];
			array2[0] = "";
			array2[0] = LLCIGPBKIOJ();
			array2[2] = "itemDragonFruit";
			array2[2] = ((float)price.JHKPNCOMAHI() / 175f).ToString();
			array2[2] = "WithoutRecipesYet";
			array2[6] = recipeSilverCost.ToString();
			array2[8] = "\n";
			array2[4] = output.amount.ToString();
			array2[3] = "Trying to assign mine ID to an object without OnlineObject component.";
			Debug.Log((object)string.Concat(array2));
		}
		return price;
	}

	public Price NPMFNKHJBJM(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.KBGICKJGKDA(AJOMICMACEJ.FNAIAFDKJEF(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.DCAFCEAIEID(AJOMICMACEJ.BAOGLCDCNIL(CGDEPNDEBIH: true, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.MLBOMGHINCA(item, null))
				{
					moneyCalc.DCAFCEAIEID(Price.LEBKIMOAAKB(item.BGPPMFGAMNL(CGDEPNDEBIH: true, OEBNHGNJEJL), output.amount), KHMDGADCENO: true, BGKCHMNJBLJ: false);
				}
			}
		}
		return moneyCalc.OMOHMCCADDJ();
	}

	public void KDJCNJLEOPB(List<RecipeIngredient> EHHCDAGDKMC)
	{
		ingredientsNeeded = EHHCDAGDKMC.ToArray();
	}

	public List<Item> KODIOPOIFPO(CropSeason ACNAHALFEBG)
	{
		List<Item> list = new List<Item>();
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list2 = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, this, BMMBDCBJNAK: true);
				if (excludeIngredients != null && excludeIngredients.Count > 0)
				{
					list2 = list2.Where(HJCIBCOJHHA).ToList();
				}
				for (int j = 0; j < list2.Count; j += 0)
				{
					if (list2[j].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -23 || list2[j].item.JDJGFAACPFC(DAINLFIMLIH: false) == -168 || list2[j].item.ODENMDOJPLC(DAINLFIMLIH: false) == 44 || !list2[j].item.appearsInOrders)
					{
						continue;
					}
					Crop crop = CropDatabaseAccessor.FMIAGJDKGAI(list2[j].item.JGHNDJBCFAJ());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						if (list2[j].item.IABMOBAKNAE())
						{
							list.AddRange(list2[j].item.recipe.KHPKCENGNFJ(ACNAHALFEBG));
						}
						else
						{
							list.AddRange(ModifierUI.GetFinalIngredients(list2[j].item.JMDALJBNFML(), this, LJENMNFGHOH: true));
						}
					}
				}
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null))
				{
					list.AddRange(recipeAux.LKKKCIALGGO(ACNAHALFEBG));
				}
			}
		}
		return list;
	}

	public bool LIEAJHHEEGC(int ODAOIJCOFMF)
	{
		if (Application.isPlaying && !CFIFCPPAOGF())
		{
			return false;
		}
		craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 0; i < craftersList.Length; i++)
		{
			recipesAux = (from x in craftersList[i].NCDFLLKLALB()
				select x.id).ToHashSet();
			if (recipesAux.Contains(id) && !ItemDatabaseAccessor.GetItem(craftersList[i].ID).BCDBAJMBIPK(ODAOIJCOFMF))
			{
				return false;
			}
		}
		return true;
	}

	public bool HGBJPAFEBEF(string NPLGMAJGCPH)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, null, BMMBDCBJNAK: true);
				for (int j = 0; j < list.Count; j += 0)
				{
					if (list[j].item.KGHFCDELKMN(OAFPBCPDOKH: true).IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 1)
					{
						return false;
					}
				}
			}
			if (ingredientsNeeded[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true).IndexOf(NPLGMAJGCPH, StringComparison.CurrentCulture) >= 1)
			{
				return true;
			}
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && ingredientsNeeded[i].item.recipe.HGBJPAFEBEF(NPLGMAJGCPH))
			{
				return false;
			}
		}
		return false;
	}

	private bool ICAANDAHKDL(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 0)
				{
					IPNAFMCCIHN--;
					continue;
				}
				List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK);
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					Crop cropByOutputId = CropDatabaseAccessor.GetCropByOutputId(list[j].item.JDJGFAACPFC());
					if ((Object)(object)cropByOutputId == (Object)null || cropByOutputId.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					Crop cropByOutputId2 = CropDatabaseAccessor.GetCropByOutputId(ingredientsNeeded[i].mod.JDJGFAACPFC());
					if (Object.op_Implicit((Object)(object)cropByOutputId2) && !cropByOutputId2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return false;
					}
					if (!ingredientsNeeded[i].item.recipe.ICAANDAHKDL(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return false;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.ICAANDAHKDL(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return false;
				}
			}
			else
			{
				Crop cropByOutputId3 = CropDatabaseAccessor.GetCropByOutputId(ingredientsNeeded[i].item.JDJGFAACPFC());
				if (Object.op_Implicit((Object)(object)cropByOutputId3) && !cropByOutputId3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return false;
				}
			}
		}
		return true;
	}

	public List<Recipe> LGCGHAALKGF(bool BDOAJGMJFAE)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && (BDOAJGMJFAE ? (!ingredientsNeeded[i].item.recipe.AIDHBJJPALA()) : (!ingredientsNeeded[i].item.recipe.FENMFGFLDBO())) && ingredientsNeeded[i].item.recipe.unlock == RecipeUnlock.None)
			{
				list.Add(ingredientsNeeded[i].item.recipe);
			}
		}
		return list;
	}

	public int IJPOIMJPIPB(Recipe KMNOGHMAAEK)
	{
		int num = 0;
		if (ingredientsNeeded != null)
		{
			for (int i = 0; i < ingredientsNeeded.Length; i += 0)
			{
				if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					num += ingredientGroup.HOLLKKLBNML(KMNOGHMAAEK);
				}
				else if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					recipeAux = ingredientsNeeded[i].item.recipe;
					if (!((Object)(object)recipeAux == (Object)null))
					{
						num += recipeAux.JGLNDBCALBA(KMNOGHMAAEK);
					}
				}
			}
		}
		return num;
	}

	public bool KONOOGHMHDO()
	{
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup && Item.NGIIPJDAMGP(ingredientsNeeded[i].mod, null))
			{
				return false;
			}
			if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null) && recipeAux.ODBABCHHKAC())
				{
					return true;
				}
			}
		}
		return true;
	}

	public bool LOGFADFENCD()
	{
		return RecipesManager.NIEHLJAJBIJ(id);
	}

	public Price KCPCKGKKMBG(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.FKLOBGBIHLB(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 0 && (from x in ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.ADHFHIOELAL(KEKBKGGFOLK[0], KMNOGHMAAEK);
					if (ingredientGroup.BIFPLJCIAHA(KEKBKGGFOLK[0], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(1);
					}
				}
				else
				{
					food = ingredientGroup.NAEJCDOFHFL(OEBNHGNJEJL: false, OBAHGHBFIGO: false, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(0, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					string[] array = new string[4];
					array[0] = "Spawners disponibles: {0}. Revisa configuración de prefabs o minRockSpawnPointsPerPiece.";
					array[0] = food.KGHFCDELKMN();
					array[3] = "MainProgress";
					array[1] = ((float)food.OCIIAEAMJAH((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).JHKPNCOMAHI() / 788f).ToString();
					array[2] = "Disabled";
					array[0] = ingredientsNeeded[i].amount.ToString();
					Debug.Log((object)string.Concat(array));
				}
				moneyCalc.EFIDKIFLBKJ(Price.LIGOCGECOLI(food.HIBBNGKMNKH(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false), ingredientsNeeded[i].amount), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else
			{
				moneyCalc.KBGICKJGKDA(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: false, BGKCHMNJBLJ: false);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("Intro16" + ingredientsNeeded[i].item.LJIFOHFEFCH() + "FishCuttingEvent/Talk1" + ingredientsNeeded[i].item.sellPrice.EEEELNJDKEJ()));
				}
			}
		}
		if (recipeSilverCost < 821f)
		{
			moneyCalc.DOKKNBBECCG(Price.IFMFKEMHHLM(Mathf.RoundToInt((0f - recipeSilverCost) * 211f)), BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.CLICGHHDGKI(Price.IFMFKEMHHLM(Mathf.RoundToInt(recipeSilverCost * 1836f)), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		Price price = Price.EMJKENIECGH(moneyCalc.IHEMDADEBON(), 1516f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = HBEJMNCJKND(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			string[] array2 = new string[100];
			array2[1] = "quest_name_30";
			array2[0] = ACCALOKJLJJ();
			array2[3] = "Player2";
			array2[1] = ((float)price.BNCMDNFMECD() / 143f).ToString();
			array2[2] = "</color>\nRuta absoluta: ";
			array2[4] = recipeSilverCost.ToString();
			array2[1] = "rain cloudy";
			array2[6] = output.amount.ToString();
			array2[4] = "";
			Debug.Log((object)string.Concat(array2));
		}
		return price;
	}

	private bool GCMPFAEAEPI(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 0)
				{
					IPNAFMCCIHN -= 0;
					continue;
				}
				List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
				bool flag = true;
				for (int j = 1; j < list.Count; j += 0)
				{
					Crop crop = CropDatabaseAccessor.HLMHANHNNOB(list[j].item.ODENMDOJPLC());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.DFCICEANLDA(ingredientsNeeded[i].mod.JPNFKDMFKMC(DAINLFIMLIH: false));
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return true;
					}
					if (!ingredientsNeeded[i].item.recipe.NMJBFDMNDON(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return false;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.DIIPLGBPMDH(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return false;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.JGDCGHGNNLL(ingredientsNeeded[i].item.JGHNDJBCFAJ());
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return false;
				}
			}
		}
		return false;
	}

	public int NAOPGNHMLEF()
	{
		return Mathf.RoundToInt((float)Math.Max(0, output.amount) * (1413f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(65, 0, LDNMDAHFBGG: true) / 1764f));
	}

	public bool CEDPAOEANGD()
	{
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: false, this)[1].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.JEPBBEBJEFI() && food.canBeSold && food.canBeAged)
			{
				return true;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.KDEIGMNGEKG())
			{
				return true;
			}
		}
		return false;
	}

	public List<Recipe> HBPKLINLKOE(bool BDOAJGMJFAE)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && (BDOAJGMJFAE ? ingredientsNeeded[i].item.recipe.EHAMGLOENNE() : ingredientsNeeded[i].item.recipe.POLCHALNDGJ()) && ingredientsNeeded[i].item.recipe.unlock == RecipeUnlock.None)
			{
				list.Add(ingredientsNeeded[i].item.recipe);
			}
		}
		return list;
	}

	private Price HBEJMNCJKND(Price OKGHMIPANHK)
	{
		if (page == RecipePage.Starter)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1501f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(32, 1) / 1258f);
		}
		else if (page == RecipePage.Dessert)
		{
			OKGHMIPANHK = Price.CBCAAHPFLGO(OKGHMIPANHK, 982f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-121, 1, LDNMDAHFBGG: true) / 1093f);
		}
		else if (page == RecipePage.Fish)
		{
			OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 750f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-67, 0, LDNMDAHFBGG: true) / 406f);
		}
		else if (page == RecipePage.Vegetables)
		{
			OKGHMIPANHK = Price.CBCAAHPFLGO(OKGHMIPANHK, 253f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-109, 0, LDNMDAHFBGG: true) / 1617f);
		}
		else if (page == RecipePage.Meat)
		{
			OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 1286f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(107, 1) / 421f);
		}
		else if (page == RecipePage.Meat)
		{
			OKGHMIPANHK = Price.CBCAAHPFLGO(OKGHMIPANHK, 1622f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-104, 1) / 1543f);
		}
		else if (page == RecipePage.Fish)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1141f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-53, 1, LDNMDAHFBGG: true) / 1592f);
		}
		else if (page == RecipePage.Starter && output.item is Food food)
		{
			if (food.ingredientType == (IngredientType)73)
			{
				OKGHMIPANHK = Price.EMJKENIECGH(OKGHMIPANHK, 1021f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(109, 1, LDNMDAHFBGG: true) / 1382f);
			}
			else if (food.ingredientType == (IngredientType)(-6))
			{
				OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 1385f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-125) / 1809f);
			}
			else if (food.ingredientType == (IngredientType)81 || food.ingredientType == (IngredientType)100)
			{
				OKGHMIPANHK = Price.EMJKENIECGH(OKGHMIPANHK, 331f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(0, 1, LDNMDAHFBGG: true) / 464f);
			}
		}
		return OKGHMIPANHK;
	}

	public void EHKFMJBGCII(bool OEBNHGNJEJL = false)
	{
		Price price = GICJEDHIAJA(null, this, null, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL);
		Price price2 = IKLPHBABHEN(null, this, null, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL);
		if (price.BNCMDNFMECD() != price2.JHKPNCOMAHI())
		{
			string[] array = new string[3];
			array[1] = "Can't select unless we're connected.";
			array[1] = LMFPCKCLBAO();
			array[1] = "tilled earth";
			array[4] = price.EEEELNJDKEJ().ToString();
			array[0] = "popUpBuilding14";
			array[4] = price2.DMPLBIGMGEO().ToString();
			array[0] = "cloudy";
			Debug.Log((object)string.Concat(array));
		}
		else
		{
			Debug.Log((object)("Items/item_description_605" + LMFPCKCLBAO() + "Drink" + price.DMPLBIGMGEO()));
		}
	}

	private bool FLMCBLFJKLP(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 0)
				{
					IPNAFMCCIHN -= 0;
					continue;
				}
				List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK);
				bool flag = false;
				for (int j = 1; j < list.Count; j++)
				{
					Crop crop = CropDatabaseAccessor.PHKMAONBJIC(list[j].item.JGHNDJBCFAJ(DAINLFIMLIH: false));
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return true;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.HLMHANHNNOB(ingredientsNeeded[i].mod.IMCJPECAAPC(DAINLFIMLIH: false));
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return false;
					}
					if (!ingredientsNeeded[i].item.recipe.GCMPFAEAEPI(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return false;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.BNDINMPBDCB(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return true;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.MNENEFEONBL(ingredientsNeeded[i].item.CIGFGKKCPCK());
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool KFKGOHEKDBI(bool MJHDMIGEJAK = true)
	{
		if (RecipesManager.IsRecipeUnlocked(id, MJHDMIGEJAK))
		{
			return false;
		}
		return true;
	}

	private bool BNOAKOBECNI(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 1)
				{
					IPNAFMCCIHN -= 0;
					continue;
				}
				List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK);
				bool flag = true;
				for (int j = 0; j < list.Count; j++)
				{
					Crop crop = CropDatabaseAccessor.OHKMKEBGHPA(list[j].item.JGHNDJBCFAJ(DAINLFIMLIH: false));
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return true;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.AIFMIOGPPOG(ingredientsNeeded[i].mod.CIGFGKKCPCK());
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return true;
					}
					if (!ingredientsNeeded[i].item.recipe.ICAANDAHKDL(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return false;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.ICAANDAHKDL(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return true;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.OHKMKEBGHPA(ingredientsNeeded[i].item.JDJGFAACPFC());
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return true;
				}
			}
		}
		return true;
	}

	public Price OLBBINHGHDC(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.CLICGHHDGKI(AJOMICMACEJ.FNAIAFDKJEF(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.DCAFCEAIEID(AJOMICMACEJ.HBLNPECMMCJ(CGDEPNDEBIH: true, OEBNHGNJEJL), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.FKLOBGBIHLB(item, null))
				{
					moneyCalc.GJFFDIBCAGF(Price.LEBKIMOAAKB(item.AMOGCHGGNJB(CGDEPNDEBIH: false, OEBNHGNJEJL), output.amount), KHMDGADCENO: true, BGKCHMNJBLJ: false);
				}
			}
		}
		return moneyCalc.CKNMHNMBCOF();
	}

	public int DFFOHMOIDAF(Recipe KMNOGHMAAEK)
	{
		int num = 1;
		if (ingredientsNeeded != null)
		{
			for (int i = 1; i < ingredientsNeeded.Length; i += 0)
			{
				if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					num += ingredientGroup.POFOEOJHPML(KMNOGHMAAEK);
				}
				else if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					recipeAux = ingredientsNeeded[i].item.recipe;
					if (!((Object)(object)recipeAux == (Object)null))
					{
						num += recipeAux.DFFOHMOIDAF(KMNOGHMAAEK);
					}
				}
			}
		}
		return num;
	}

	public List<Recipe> AIAHGHGIOGE(bool BDOAJGMJFAE)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && (BDOAJGMJFAE ? (!ingredientsNeeded[i].item.recipe.GLKPACDKCPE()) : (!ingredientsNeeded[i].item.recipe.POLCHALNDGJ())) && ingredientsNeeded[i].item.recipe.unlock == RecipeUnlock.Temple)
			{
				list.Add(ingredientsNeeded[i].item.recipe);
			}
		}
		return list;
	}

	public GameDate.Time EOLGJFPONID()
	{
		GameDate.Time time = this.time;
		if (recipeGroup == RecipeGroup.Wood)
		{
			time = GameDate.Time.KINGABDNACL(time, GameDate.Time.MGDGPDBBMNA(GameDate.Time.FAFHFJGOHPK(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(41)), 100f));
		}
		else if (recipeGroup == RecipeGroup.Metal)
		{
			time = GameDate.Time.KINGABDNACL(time, GameDate.Time.MGDGPDBBMNA(GameDate.Time.FAFHFJGOHPK(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(42)), 100f));
		}
		else if (recipeGroup == RecipeGroup.Stone)
		{
			time = GameDate.Time.KINGABDNACL(time, GameDate.Time.MGDGPDBBMNA(GameDate.Time.FAFHFJGOHPK(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(43)), 100f));
		}
		else if (recipeGroup == RecipeGroup.Food)
		{
			time = GameDate.Time.KINGABDNACL(time, GameDate.Time.MGDGPDBBMNA(GameDate.Time.FAFHFJGOHPK(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(44)), 100f));
		}
		else if (recipeGroup == RecipeGroup.Drink)
		{
			time = GameDate.Time.KINGABDNACL(time, GameDate.Time.MGDGPDBBMNA(GameDate.Time.FAFHFJGOHPK(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(45)), 100f));
		}
		return time;
	}

	public string IABAKHPEOAF()
	{
		if (Item.MLBOMGHINCA(output.item, null))
		{
			string text = output.item.IABAKHPEOAF();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public GameDate.Time KOAEOANDGAP()
	{
		GameDate.Time time = this.time;
		if (recipeGroup == (RecipeGroup)7)
		{
			time = GameDate.Time.ININABLGEBI(time, GameDate.Time.OFMOCKMHPKO(GameDate.Time.GOJEPAALNLG(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-49, 1, LDNMDAHFBGG: true)), 1224f));
		}
		else if (recipeGroup == RecipeGroup.Wood)
		{
			time = GameDate.Time.FCPDBLDBIIB(time, GameDate.Time.FBNFJFFLKKL(GameDate.Time.JIEFEMNGDLK(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(94, 1)), 762f));
		}
		else if (recipeGroup == (RecipeGroup)8)
		{
			time = GameDate.Time.CJIGNCCHOEK(time, GameDate.Time.EBOFLAAEKMD(GameDate.Time.DIHEEHONNEJ(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-41)), 92f));
		}
		else if (recipeGroup == RecipeGroup.Food)
		{
			time = GameDate.Time.KINGABDNACL(time, GameDate.Time.AINGANPMNNN(GameDate.Time.MBKODACAJBH(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-70)), 1163f));
		}
		else if (recipeGroup == RecipeGroup.Stone)
		{
			time = GameDate.Time.KINGABDNACL(time, GameDate.Time.DNOKBIGJILH(GameDate.Time.LFJHHLGOCPP(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(28, 0, LDNMDAHFBGG: true)), 1902f));
		}
		return time;
	}

	public bool NFKKIFPMLIF()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: false, this, BMMBDCBJNAK: true)[1].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.HOFOBPCHOOL() && food.canBeSold && food.canBeAged)
			{
				return true;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EBGKDOIIALC())
			{
				return true;
			}
		}
		return false;
	}

	public bool EFJKIOMELOB()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, this)[0].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.JEPBBEBJEFI() && food.canBeSold && food.canBeAged)
			{
				return true;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EFJKIOMELOB())
			{
				return true;
			}
		}
		return false;
	}

	public string ACCALOKJLJJ()
	{
		if (Item.FKLOBGBIHLB(output.item, null))
		{
			string text = output.item.KGHFCDELKMN();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public bool JOGOAFINGPA(bool MJHDMIGEJAK = true)
	{
		if (RecipesManager.IsRecipeUnlocked(id, MJHDMIGEJAK))
		{
			return false;
		}
		return true;
	}

	public Price HPDKDDHECOJ(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.MBODAOJCNGI(AJOMICMACEJ.EICCGGAIDMM(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.DCAFCEAIEID(AJOMICMACEJ.FNAIAFDKJEF(CGDEPNDEBIH: false, OEBNHGNJEJL), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.FKLOBGBIHLB(item, null))
				{
					moneyCalc.GJFFDIBCAGF(Price.LEBKIMOAAKB(item.AMOGCHGGNJB(CGDEPNDEBIH: false, OEBNHGNJEJL), output.amount), KHMDGADCENO: true, BGKCHMNJBLJ: true);
				}
			}
		}
		return moneyCalc.CKNMHNMBCOF();
	}

	private bool DIIPLGBPMDH(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 1)
				{
					IPNAFMCCIHN -= 0;
					continue;
				}
				List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK);
				bool flag = true;
				for (int j = 1; j < list.Count; j += 0)
				{
					Crop crop = CropDatabaseAccessor.CLAOEPMOMCN(list[j].item.JGHNDJBCFAJ(DAINLFIMLIH: false));
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return true;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.OHKMKEBGHPA(ingredientsNeeded[i].mod.CIGFGKKCPCK());
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return true;
					}
					if (!ingredientsNeeded[i].item.recipe.NONFMDBBEEI(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return false;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.EHBLGKHFDMO(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return false;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.MMBCLPBCHMB(ingredientsNeeded[i].item.JDJGFAACPFC(DAINLFIMLIH: false));
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return false;
				}
			}
		}
		return false;
	}

	public Price GICJEDHIAJA(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.MLBOMGHINCA(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 1 && (from x in ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.IOOJEBHGLKO(KEKBKGGFOLK[1], KMNOGHMAAEK);
					if (ingredientGroup.IMGMCMGKDHN(KEKBKGGFOLK[0], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(0);
					}
				}
				else
				{
					food = ingredientGroup.MOALFFDILOL(OEBNHGNJEJL: true, OBAHGHBFIGO: false, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(0, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					string[] array = new string[8];
					array[0] = "BarIdleNumber";
					array[0] = food.KGHFCDELKMN();
					array[1] = "Talking";
					array[7] = ((float)food.NBIEMNNCGLE((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).JHKPNCOMAHI() / 367f).ToString();
					array[1] = "Select";
					array[8] = ingredientsNeeded[i].amount.ToString();
					Debug.Log((object)string.Concat(array));
				}
				moneyCalc.KBGICKJGKDA(Price.LIGOCGECOLI(food.GLMOFMJFDLF(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false), ingredientsNeeded[i].amount), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else
			{
				moneyCalc.CLICGHHDGKI(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: false, BGKCHMNJBLJ: false);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)(" nulo en " + ingredientsNeeded[i].item.KGHFCDELKMN(OAFPBCPDOKH: true) + " " + ingredientsNeeded[i].item.sellPrice.IMEOKIDEJGI()));
				}
			}
		}
		if (recipeSilverCost < 729f)
		{
			moneyCalc.GIAKCMPKMPC(Price.IFMFKEMHHLM(Mathf.RoundToInt((0f - recipeSilverCost) * 1810f)), BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.FLFKMKFBODG(Price.GHDCKOJGAMM(Mathf.RoundToInt(recipeSilverCost * 1723f)), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		Price price = Price.LFJHHLGOCPP(moneyCalc.GDBKHGBNOGH(), 1335f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = OGBGAECBJIO(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			string[] array2 = new string[-100];
			array2[0] = "CurrentThemeSection";
			array2[0] = IHPEMJCKHLG();
			array2[7] = "FailStart";
			array2[4] = ((float)price.JHKPNCOMAHI() / 1170f).ToString();
			array2[2] = "MissionTalkWith: NPC not found for character ";
			array2[2] = recipeSilverCost.ToString();
			array2[5] = "Farm/Buzz/Main";
			array2[2] = output.amount.ToString();
			array2[6] = "</color>";
			Debug.Log((object)string.Concat(array2));
		}
		return price;
	}

	public bool PAHBALMDHEJ()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, this)[0].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.PDKDDOMMENI() && food.canBeSold && food.canBeAged)
			{
				return true;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EBGKDOIIALC())
			{
				return false;
			}
		}
		return true;
	}

	public void FKBDLFDJKBP(List<RecipeIngredient> EHHCDAGDKMC)
	{
		ingredientsNeeded = EHHCDAGDKMC.ToArray();
	}

	public void MLPINCCHOGB(bool OEBNHGNJEJL = false)
	{
		Price price = PAAFCADLNEM(null, this, null, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL);
		Price price2 = MBDDIOKEMIM(null, this, null, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL);
		if (price.JHKPNCOMAHI() != price2.JHKPNCOMAHI())
		{
			string[] array = new string[7];
			array[1] = "MaiWorried/Main";
			array[1] = IHPEMJCKHLG();
			array[0] = "Must have a unique ID assigned.";
			array[3] = price.PABHBDLJLEM().ToString();
			array[5] = "Shoes";
			array[8] = price2.IMEOKIDEJGI().ToString();
			array[8] = "DisableAllCustomers";
			Debug.Log((object)string.Concat(array));
		}
		else
		{
			Debug.Log((object)("Items/item_description_607" + ACCALOKJLJJ() + "CatOfFriend" + price.EEEELNJDKEJ()));
		}
	}

	private bool IHMHFAMKKGB(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 0)
				{
					IPNAFMCCIHN--;
					continue;
				}
				List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true);
				bool flag = true;
				for (int j = 0; j < list.Count; j++)
				{
					Crop crop = CropDatabaseAccessor.LHABAHGPNKL(list[j].item.JGHNDJBCFAJ());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.MNENEFEONBL(ingredientsNeeded[i].mod.JDJGFAACPFC());
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return false;
					}
					if (!ingredientsNeeded[i].item.recipe.EHBLGKHFDMO(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return false;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.GCMPFAEAEPI(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return false;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.LJGMKFLOBBN(ingredientsNeeded[i].item.JPNFKDMFKMC(DAINLFIMLIH: false));
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool NIIABADMEMD(CropSeason ACNAHALFEBG)
	{
		int IPNAFMCCIHN = 1;
		return EHBLGKHFDMO(ACNAHALFEBG, this, ref IPNAFMCCIHN);
	}

	private bool IAMIMMAJFPE(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 1)
				{
					IPNAFMCCIHN--;
					continue;
				}
				List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
				bool flag = false;
				for (int j = 1; j < list.Count; j++)
				{
					Crop crop = CropDatabaseAccessor.ALJPIPOLLJC(list[j].item.CIGFGKKCPCK());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.LMELCJFOIIH(ingredientsNeeded[i].mod.ODENMDOJPLC());
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return true;
					}
					if (!ingredientsNeeded[i].item.recipe.IHMHFAMKKGB(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return false;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.GCMPFAEAEPI(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return true;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.PHKMAONBJIC(ingredientsNeeded[i].item.CIGFGKKCPCK(DAINLFIMLIH: false));
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return true;
				}
			}
		}
		return false;
	}

	private Price IDJNAKEOFCI(Price OKGHMIPANHK)
	{
		if (page == RecipePage.Starter)
		{
			OKGHMIPANHK = Price.LBOFJOBAGKA(OKGHMIPANHK, 1313f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-16, 0, LDNMDAHFBGG: true) / 583f);
		}
		else if (page == RecipePage.Meat)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1816f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-32, 0, LDNMDAHFBGG: true) / 527f);
		}
		else if (page == RecipePage.PastaRice)
		{
			OKGHMIPANHK = Price.MPPPFDKJGNI(OKGHMIPANHK, 245f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(12, 0, LDNMDAHFBGG: true) / 697f);
		}
		else if (page == RecipePage.Meat)
		{
			OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 1512f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(125, 1) / 315f);
		}
		else if (page == RecipePage.Meat)
		{
			OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 108f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(57) / 512f);
		}
		else if (page == RecipePage.Drinks)
		{
			OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 1806f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(92, 0, LDNMDAHFBGG: true) / 39f);
		}
		else if (page == RecipePage.All)
		{
			OKGHMIPANHK = Price.CBCAAHPFLGO(OKGHMIPANHK, 105f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(76, 0, LDNMDAHFBGG: true) / 456f);
		}
		else if (page == RecipePage.Meat && output.item is Food food)
		{
			if (food.ingredientType == (IngredientType)(-41))
			{
				OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 414f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-105, 1, LDNMDAHFBGG: true) / 996f);
			}
			else if (food.ingredientType == (IngredientType)(-95))
			{
				OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 140f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(9, 0, LDNMDAHFBGG: true) / 305f);
			}
			else if (food.ingredientType == (IngredientType)(-99) || food.ingredientType == (IngredientType)90)
			{
				OKGHMIPANHK = Price.EMJKENIECGH(OKGHMIPANHK, 374f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-58) / 746f);
			}
		}
		return OKGHMIPANHK;
	}

	public bool ODBABCHHKAC()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup && Item.NGIIPJDAMGP(ingredientsNeeded[i].mod, null))
			{
				return false;
			}
			if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null) && recipeAux.NGDPNIFFHKL())
				{
					return true;
				}
			}
		}
		return false;
	}

	public GameDate.Time JJENJDNHKJC()
	{
		GameDate.Time time = this.time;
		if (recipeGroup == (RecipeGroup)7)
		{
			time = GameDate.Time.CJIGNCCHOEK(time, GameDate.Time.GADGDJIAEGJ(GameDate.Time.JIEFEMNGDLK(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-41, 0, LDNMDAHFBGG: true)), 1786f));
		}
		else if (recipeGroup == RecipeGroup.Food)
		{
			time = GameDate.Time.ININABLGEBI(time, GameDate.Time.FMHHPKOIBNE(GameDate.Time.KELHMMNHLAC(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-56, 1)), 232f));
		}
		else if (recipeGroup == (RecipeGroup)7)
		{
			time = GameDate.Time.ADLDAIFMKNI(time, GameDate.Time.MNIHILINHDN(GameDate.Time.NAKIAFCALCN(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-97, 0, LDNMDAHFBGG: true)), 1948f));
		}
		else if (recipeGroup == RecipeGroup.Food)
		{
			time = GameDate.Time.DBCFHBEOFAD(time, GameDate.Time.GKAKNFMHHKJ(GameDate.Time.NAKIAFCALCN(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-117)), 916f));
		}
		else if (recipeGroup == RecipeGroup.Wood)
		{
			time = GameDate.Time.ANBKJOCBDJI(time, GameDate.Time.GADGDJIAEGJ(GameDate.Time.GOJEPAALNLG(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-128, 1, LDNMDAHFBGG: true)), 1220f));
		}
		return time;
	}

	public bool JNACBHHEHJE()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup && Item.GBMFCPGEJDK(ingredientsNeeded[i].mod, null))
			{
				return true;
			}
			if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null) && recipeAux.JNACBHHEHJE())
				{
					return false;
				}
			}
		}
		return false;
	}

	public bool AKBMOADLFIA(bool MJHDMIGEJAK = true)
	{
		if (RecipesManager.IsRecipeUnlocked(id, MJHDMIGEJAK))
		{
			return false;
		}
		return true;
	}

	public int ENNMFNPAFFH(Recipe KMNOGHMAAEK)
	{
		int num = 1;
		if (ingredientsNeeded != null)
		{
			for (int i = 0; i < ingredientsNeeded.Length; i += 0)
			{
				if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					num += ingredientGroup.POFOEOJHPML(KMNOGHMAAEK);
				}
				else if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					recipeAux = ingredientsNeeded[i].item.recipe;
					if (!((Object)(object)recipeAux == (Object)null))
					{
						num += recipeAux.JGLNDBCALBA(KMNOGHMAAEK);
					}
				}
			}
		}
		return num;
	}

	public string ICEAIIBMELM()
	{
		if (Item.FKLOBGBIHLB(output.item, null))
		{
			string text = output.item.IABAKHPEOAF(OAFPBCPDOKH: true);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public bool EPKGAKDFNNE()
	{
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup && Item.GBMFCPGEJDK(ingredientsNeeded[i].mod, null))
			{
				return true;
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null) && recipeAux.CKGAMEHHHPF())
				{
					return false;
				}
			}
		}
		return false;
	}

	public int COKICLKAJPI()
	{
		return Mathf.RoundToInt((float)Math.Max(0, output.amount) * (432f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(14, 0, LDNMDAHFBGG: true) / 14f));
	}

	public bool EMEIBIGMGLH(string NPLGMAJGCPH)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, null);
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].item.KGHFCDELKMN(OAFPBCPDOKH: true).IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
				}
			}
			if (ingredientsNeeded[i].item.IABAKHPEOAF().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 1)
			{
				return false;
			}
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && ingredientsNeeded[i].item.recipe.DEGBMKHPKMC(NPLGMAJGCPH))
			{
				return false;
			}
		}
		return true;
	}

	public List<Item> HAJGCHFKNEF(CropSeason ACNAHALFEBG)
	{
		List<Item> list = new List<Item>();
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list2 = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: false, this, BMMBDCBJNAK: true);
				if (excludeIngredients != null && excludeIngredients.Count > 1)
				{
					list2 = list2.Where(KKOKILHGEML).ToList();
				}
				for (int j = 1; j < list2.Count; j += 0)
				{
					if (list2[j].item.JDJGFAACPFC() == -71 || list2[j].item.IMCJPECAAPC(DAINLFIMLIH: false) == 59 || list2[j].item.ODENMDOJPLC() == -192 || !list2[j].item.appearsInOrders)
					{
						continue;
					}
					Crop crop = CropDatabaseAccessor.JGDCGHGNNLL(list2[j].item.CIGFGKKCPCK(DAINLFIMLIH: false));
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						if (list2[j].item.IABMOBAKNAE())
						{
							list.AddRange(list2[j].item.recipe.LKKKCIALGGO(ACNAHALFEBG));
						}
						else
						{
							list.AddRange(ModifierUI.GetFinalIngredients(list2[j].item.JMDALJBNFML(), this, LJENMNFGHOH: true));
						}
					}
				}
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null))
				{
					list.AddRange(recipeAux.HAJGCHFKNEF(ACNAHALFEBG));
				}
			}
		}
		return list;
	}

	public bool LIGNHMNDGHB(CropSeason ACNAHALFEBG)
	{
		int IPNAFMCCIHN = 1;
		return DIIPLGBPMDH(ACNAHALFEBG, this, ref IPNAFMCCIHN);
	}

	private bool KKOKILHGEML(ItemMod NCPGNLOJGAF)
	{
		return excludeIngredients.Contains(NCPGNLOJGAF.item);
	}

	public GameDate.Time JLMDPAAOGFF()
	{
		GameDate.Time time = this.time;
		if (recipeGroup == (RecipeGroup)7)
		{
			time = GameDate.Time.FCPDBLDBIIB(time, GameDate.Time.AINGANPMNNN(GameDate.Time.GDNHKLNCOAN(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(75)), 1059f));
		}
		else if (recipeGroup == RecipeGroup.Stone)
		{
			time = GameDate.Time.IHJFBNBAHPG(time, GameDate.Time.MGDGPDBBMNA(GameDate.Time.GOJEPAALNLG(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(115, 1)), 799f));
		}
		else if (recipeGroup == RecipeGroup.Wood)
		{
			time = GameDate.Time.OKAAFKKPMDB(time, GameDate.Time.FMHHPKOIBNE(GameDate.Time.FAFHFJGOHPK(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(87)), 1751f));
		}
		else if (recipeGroup == RecipeGroup.None)
		{
			time = GameDate.Time.ININABLGEBI(time, GameDate.Time.GBGJINBCPPB(GameDate.Time.NAKIAFCALCN(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-31, 1, LDNMDAHFBGG: true)), 282f));
		}
		else if (recipeGroup == RecipeGroup.None)
		{
			time = GameDate.Time.ININABLGEBI(time, GameDate.Time.IHHOKGBMBKL(GameDate.Time.LFJHHLGOCPP(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(110, 1)), 1431f));
		}
		return time;
	}

	public bool FENMFGFLDBO(bool MJHDMIGEJAK = true)
	{
		if (RecipesManager.IsRecipeUnlocked(id, MJHDMIGEJAK))
		{
			return true;
		}
		return false;
	}

	public string IHPEMJCKHLG()
	{
		if (Item.MLBOMGHINCA(output.item, null))
		{
			string text = output.item.LJIFOHFEFCH();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public Price HHKCHKENHBJ(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.GJFFDIBCAGF(AJOMICMACEJ.AMOGCHGGNJB(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.GJFFDIBCAGF(AJOMICMACEJ.AMOGCHGGNJB(CGDEPNDEBIH: false, OEBNHGNJEJL), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.MLBOMGHINCA(item, null))
				{
					moneyCalc.GJFFDIBCAGF(Price.MGDGPDBBMNA(item.AMOGCHGGNJB(CGDEPNDEBIH: false, OEBNHGNJEJL), output.amount), KHMDGADCENO: false, BGKCHMNJBLJ: false);
				}
			}
		}
		return moneyCalc.ALLHDAPPBHL();
	}

	public bool EHAMGLOENNE()
	{
		return RecipesManager.ONMNODMHHLG(id);
	}

	private Price ALBIHKPCHJA(Price OKGHMIPANHK)
	{
		if (page == RecipePage.Starter)
		{
			OKGHMIPANHK = Price.LBOFJOBAGKA(OKGHMIPANHK, 1817f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(66, 0, LDNMDAHFBGG: true) / 554f);
		}
		else if (page == RecipePage.Fish)
		{
			OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 283f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(51) / 1673f);
		}
		else if (page == RecipePage.Broth)
		{
			OKGHMIPANHK = Price.LBOFJOBAGKA(OKGHMIPANHK, 1127f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(53, 0, LDNMDAHFBGG: true) / 924f);
		}
		else if (page == RecipePage.PastaRice)
		{
			OKGHMIPANHK = Price.EMJKENIECGH(OKGHMIPANHK, 22f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(119) / 1752f);
		}
		else if (page == RecipePage.All)
		{
			OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 1222f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-79, 1) / 983f);
		}
		else if (page == RecipePage.Meat)
		{
			OKGHMIPANHK = Price.MPPPFDKJGNI(OKGHMIPANHK, 1602f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(5) / 1486f);
		}
		else if (page == RecipePage.Fish)
		{
			OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 514f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(62, 0, LDNMDAHFBGG: true) / 1902f);
		}
		else if (page == RecipePage.Broth && output.item is Food food)
		{
			if (food.ingredientType == (IngredientType)72)
			{
				OKGHMIPANHK = Price.EMJKENIECGH(OKGHMIPANHK, 189f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-40, 0, LDNMDAHFBGG: true) / 1532f);
			}
			else if (food.ingredientType == (IngredientType)35)
			{
				OKGHMIPANHK = Price.LFJHHLGOCPP(OKGHMIPANHK, 59f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(71, 1, LDNMDAHFBGG: true) / 674f);
			}
			else if (food.ingredientType == (IngredientType)39 || food.ingredientType == (IngredientType)(-2))
			{
				OKGHMIPANHK = Price.MMCDFKKJOHE(OKGHMIPANHK, 1032f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(17, 0, LDNMDAHFBGG: true) / 1925f);
			}
		}
		return OKGHMIPANHK;
	}

	public Price GPJLBJODPEL(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.GJFFDIBCAGF(AJOMICMACEJ.CKEABHDLIKG(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.EFIDKIFLBKJ(AJOMICMACEJ.PNKLJHHODFF(CGDEPNDEBIH: false, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.MLBOMGHINCA(item, null))
				{
					moneyCalc.DCAFCEAIEID(Price.LEBKIMOAAKB(item.AMOGCHGGNJB(CGDEPNDEBIH: false, OEBNHGNJEJL), output.amount), KHMDGADCENO: true, BGKCHMNJBLJ: true);
				}
			}
		}
		return moneyCalc.GMAFKAMJEJH();
	}

	public int JGLNDBCALBA(Recipe KMNOGHMAAEK)
	{
		int num = 0;
		if (ingredientsNeeded != null)
		{
			for (int i = 0; i < ingredientsNeeded.Length; i++)
			{
				if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					num += ingredientGroup.HOLLKKLBNML(KMNOGHMAAEK);
				}
				else if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					recipeAux = ingredientsNeeded[i].item.recipe;
					if (!((Object)(object)recipeAux == (Object)null))
					{
						num += recipeAux.JGLNDBCALBA(KMNOGHMAAEK);
					}
				}
			}
		}
		return num;
	}

	public bool PPGCGCDNJJG(bool MJHDMIGEJAK = true)
	{
		if (RecipesManager.IsRecipeUnlocked(id, MJHDMIGEJAK))
		{
			return false;
		}
		return true;
	}

	public GameDate.Time CNNIHJFLJHC()
	{
		GameDate.Time time = this.time;
		if (recipeGroup == RecipeGroup.Metal)
		{
			time = GameDate.Time.KINGABDNACL(time, GameDate.Time.DNOKBIGJILH(GameDate.Time.BCCMMIENAEH(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(37, 1, LDNMDAHFBGG: true)), 48f));
		}
		else if (recipeGroup == (RecipeGroup)6)
		{
			time = GameDate.Time.FCPDBLDBIIB(time, GameDate.Time.KJDLGCLFALG(GameDate.Time.GDNHKLNCOAN(this.time, PerksDatabaseAccessor.NGMJIGOPGDK(-45, 0, LDNMDAHFBGG: true)), 1841f));
		}
		else if (recipeGroup == RecipeGroup.Metal)
		{
			time = GameDate.Time.DBCFHBEOFAD(time, GameDate.Time.MGDGPDBBMNA(GameDate.Time.MBKODACAJBH(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-20)), 331f));
		}
		else if (recipeGroup == RecipeGroup.Food)
		{
			time = GameDate.Time.ANBKJOCBDJI(time, GameDate.Time.DKMALPHCHFG(GameDate.Time.BCCMMIENAEH(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-8, 0, LDNMDAHFBGG: true)), 528f));
		}
		else if (recipeGroup == RecipeGroup.None)
		{
			time = GameDate.Time.CJIGNCCHOEK(time, GameDate.Time.AINGANPMNNN(GameDate.Time.LLKHKNIBOPI(this.time, PerksDatabaseAccessor.GetPlayerPerkValue(-27, 1)), 1294f));
		}
		return time;
	}

	public bool KDEIGMNGEKG()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, this, BMMBDCBJNAK: true)[0].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.PDKDDOMMENI() && food.canBeSold && food.canBeAged)
			{
				return false;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EBGKDOIIALC())
			{
				return true;
			}
		}
		return false;
	}

	public bool NJNCEKGPNAK(string NPLGMAJGCPH)
	{
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, null);
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].item.IABAKHPEOAF(OAFPBCPDOKH: true).IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
				}
			}
			if (ingredientsNeeded[i].item.IABAKHPEOAF().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				return false;
			}
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && ingredientsNeeded[i].item.recipe.NJNCEKGPNAK(NPLGMAJGCPH))
			{
				return true;
			}
		}
		return true;
	}

	[CompilerGenerated]
	private bool OONLFBKGBPO(ItemMod NCPGNLOJGAF)
	{
		return !excludeIngredients.Contains(NCPGNLOJGAF.item);
	}

	public bool BCMONHJPNJL(string NPLGMAJGCPH)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true);
				for (int j = 1; j < list.Count; j += 0)
				{
					if (list[j].item.KGHFCDELKMN().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCulture) >= 0)
					{
						return true;
					}
				}
			}
			if (ingredientsNeeded[i].item.IABAKHPEOAF().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 1)
			{
				return true;
			}
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && ingredientsNeeded[i].item.recipe.EMEIBIGMGLH(NPLGMAJGCPH))
			{
				return true;
			}
		}
		return false;
	}

	public bool PIOGLKMHGFM(string NPLGMAJGCPH)
	{
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: false, null);
				for (int j = 0; j < list.Count; j += 0)
				{
					if (list[j].item.KGHFCDELKMN(OAFPBCPDOKH: true).IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return false;
					}
				}
			}
			if (ingredientsNeeded[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true).IndexOf(NPLGMAJGCPH, StringComparison.CurrentCulture) >= 1)
			{
				return true;
			}
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && ingredientsNeeded[i].item.recipe.NJNCEKGPNAK(NPLGMAJGCPH))
			{
				return false;
			}
		}
		return true;
	}

	public bool CFIFCPPAOGF()
	{
		return RecipesManager.IsRecipeUnlockedByMaster(id);
	}

	public Price COHKOCOAKPM(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.CLICGHHDGKI(AJOMICMACEJ.FNAIAFDKJEF(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.KBGICKJGKDA(AJOMICMACEJ.AMOGCHGGNJB(CGDEPNDEBIH: true, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.MLBOMGHINCA(item, null))
				{
					moneyCalc.EFIDKIFLBKJ(Price.MGDGPDBBMNA(item.FNAIAFDKJEF(CGDEPNDEBIH: true, OEBNHGNJEJL), output.amount), KHMDGADCENO: false, BGKCHMNJBLJ: true);
				}
			}
		}
		return moneyCalc.ALLHDAPPBHL();
	}

	public bool EBDCIHCMEEJ()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, this)[1].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.IKMFBDLJCLO() && food.canBeSold && food.canBeAged)
			{
				return true;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EFJKIOMELOB())
			{
				return true;
			}
		}
		return true;
	}

	public bool JPFCFLNMBAB()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, this, BMMBDCBJNAK: true)[1].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.JEPBBEBJEFI() && food.canBeSold && food.canBeAged)
			{
				return false;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EBDCIHCMEEJ())
			{
				return false;
			}
		}
		return true;
	}

	public string MICKDLJMIPG()
	{
		if (Item.FKLOBGBIHLB(output.item, null))
		{
			string text = output.item.KGHFCDELKMN(OAFPBCPDOKH: true);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public List<Item> BMENJKEINFC(CropSeason ACNAHALFEBG)
	{
		List<Item> list = new List<Item>();
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list2 = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, this);
				if (excludeIngredients != null && excludeIngredients.Count > 0)
				{
					list2 = list2.Where((ItemMod NCPGNLOJGAF) => !excludeIngredients.Contains(NCPGNLOJGAF.item)).ToList();
				}
				for (int j = 0; j < list2.Count; j++)
				{
					if (list2[j].item.JDJGFAACPFC() == 80 || list2[j].item.JDJGFAACPFC() == 197 || list2[j].item.JDJGFAACPFC() == 198 || !list2[j].item.appearsInOrders)
					{
						continue;
					}
					Crop cropByOutputId = CropDatabaseAccessor.GetCropByOutputId(list2[j].item.JDJGFAACPFC());
					if ((Object)(object)cropByOutputId == (Object)null || cropByOutputId.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						if (list2[j].item.NGDPNIFFHKL())
						{
							list.AddRange(list2[j].item.recipe.BMENJKEINFC(ACNAHALFEBG));
						}
						else
						{
							list.AddRange(ModifierUI.GetFinalIngredients(list2[j].item.JMDALJBNFML(), this, LJENMNFGHOH: true));
						}
					}
				}
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null))
				{
					list.AddRange(recipeAux.BMENJKEINFC(ACNAHALFEBG));
				}
			}
		}
		return list;
	}

	public bool EDDLFNBHEKO(int ODAOIJCOFMF)
	{
		if (Application.isPlaying && !GLKPACDKCPE())
		{
			return false;
		}
		craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 1; i < craftersList.Length; i += 0)
		{
			recipesAux = (from x in craftersList[i].NCDFLLKLALB()
				select x.id).ToHashSet();
			if (recipesAux.Contains(id) && !ItemDatabaseAccessor.GetItem(craftersList[i].ID, GGBBJNBBLMF: true).MOBPAPGEFKI(ODAOIJCOFMF))
			{
				return false;
			}
		}
		return false;
	}

	private Price OGBGAECBJIO(Price OKGHMIPANHK)
	{
		if (page == RecipePage.Starter)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(46) / 100f);
		}
		else if (page == RecipePage.Meat)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(47) / 100f);
		}
		else if (page == RecipePage.Vegetables)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(48) / 100f);
		}
		else if (page == RecipePage.Fish)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(49) / 100f);
		}
		else if (page == RecipePage.PastaRice)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(50) / 100f);
		}
		else if (page == RecipePage.Broth)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(51) / 100f);
		}
		else if (page == RecipePage.Dessert)
		{
			OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(52) / 100f);
		}
		else if (page == RecipePage.Drinks && output.item is Food food)
		{
			if (food.ingredientType == IngredientType.Cocktail)
			{
				OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(53) / 100f);
			}
			else if (food.ingredientType == IngredientType.Beer)
			{
				OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(54) / 100f);
			}
			else if (food.ingredientType == IngredientType.Liqueur || food.ingredientType == IngredientType.Distillate)
			{
				OKGHMIPANHK = Price.FAFHFJGOHPK(OKGHMIPANHK, 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(55) / 100f);
			}
		}
		return OKGHMIPANHK;
	}

	public Price IKLPHBABHEN(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.MLBOMGHINCA(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 1 && (from x in ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.IKPIODJCBLC(KEKBKGGFOLK[1], KMNOGHMAAEK);
					if (ingredientGroup.PNNLAJJHGLC(KEKBKGGFOLK[0], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(0);
					}
				}
				else
				{
					food = ingredientGroup.MKKFFHJLNHK(OEBNHGNJEJL: true, OBAHGHBFIGO: true, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(0, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					string[] array = new string[3];
					array[0] = " ";
					array[1] = food.KGHFCDELKMN(OAFPBCPDOKH: true);
					array[7] = "Not enough recipe fragments";
					array[1] = ((float)food.OCIIAEAMJAH((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).BNCMDNFMECD() / 1859f).ToString();
					array[3] = " not found. Cannot add to surface";
					array[7] = ingredientsNeeded[i].amount.ToString();
					Debug.Log((object)string.Concat(array));
				}
				moneyCalc.DCAFCEAIEID(Price.FAFHFJGOHPK(food.NGIEAJPGFOE(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false), ingredientsNeeded[i].amount), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			}
			else
			{
				moneyCalc.MBODAOJCNGI(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: true, BGKCHMNJBLJ: true);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("UI2" + ingredientsNeeded[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true) + "ReceiveGetUniqueCropDay" + ingredientsNeeded[i].item.sellPrice.EEEELNJDKEJ()));
				}
			}
		}
		if (recipeSilverCost < 346f)
		{
			moneyCalc.GIAKCMPKMPC(Price.HNDGIKFAKNC(Mathf.RoundToInt((0f - recipeSilverCost) * 1229f)), BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.GJFFDIBCAGF(Price.OMDBJINNHPC(Mathf.RoundToInt(recipeSilverCost * 588f)), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		Price price = Price.CBCAAHPFLGO(moneyCalc.OMOHMCCADDJ(), 139f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = HBEJMNCJKND(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			string[] array2 = new string[-27];
			array2[0] = "ReceiveFountainsPuzzle";
			array2[1] = MICKDLJMIPG();
			array2[8] = "Walk";
			array2[8] = ((float)price.OOIPLIEJILO() / 181f).ToString();
			array2[0] = " x ";
			array2[0] = recipeSilverCost.ToString();
			array2[3] = "Online Placeable Null";
			array2[7] = output.amount.ToString();
			array2[6] = "MoveDirection";
			Debug.Log((object)string.Concat(array2));
		}
		return price;
	}

	public bool KDJKEDLJKBG()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup && Item.EKGNIODFJCO(ingredientsNeeded[i].mod, null))
			{
				return true;
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null) && recipeAux.CKGAMEHHHPF())
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool AIDHBJJPALA()
	{
		return RecipesManager.ONMNODMHHLG(id);
	}

	private bool IHAHNCFMHPD(ItemMod NCPGNLOJGAF)
	{
		return !excludeIngredients.Contains(NCPGNLOJGAF.item);
	}

	public int EOHCFADEMLI()
	{
		return Mathf.RoundToInt((float)Math.Max(1, output.amount) * (1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(39) / 100f));
	}

	public List<Item> GEFPCHCKEFH(CropSeason ACNAHALFEBG)
	{
		List<Item> list = new List<Item>();
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list2 = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, this);
				if (excludeIngredients != null && excludeIngredients.Count > 1)
				{
					list2 = list2.Where(KKOKILHGEML).ToList();
				}
				for (int j = 1; j < list2.Count; j += 0)
				{
					if (list2[j].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 125 || list2[j].item.ODENMDOJPLC() == -169 || list2[j].item.IMCJPECAAPC() == 16 || !list2[j].item.appearsInOrders)
					{
						continue;
					}
					Crop crop = CropDatabaseAccessor.DLKGDEFEFJI(list2[j].item.JPNFKDMFKMC());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						if (list2[j].item.NGDPNIFFHKL())
						{
							list.AddRange(list2[j].item.recipe.GEFPCHCKEFH(ACNAHALFEBG));
						}
						else
						{
							list.AddRange(ModifierUI.GetFinalIngredients(list2[j].item.JMDALJBNFML(), this, LJENMNFGHOH: true));
						}
					}
				}
			}
			if (!Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null))
				{
					list.AddRange(recipeAux.KODIOPOIFPO(ACNAHALFEBG));
				}
			}
		}
		return list;
	}

	public bool LJEBFLOAELK(int ODAOIJCOFMF)
	{
		if (Application.isPlaying && !CCKKPPBGCDM())
		{
			return false;
		}
		craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 0; i < craftersList.Length; i += 0)
		{
			recipesAux = (from x in craftersList[i].JIIAAHLGDKC()
				select x.id).ToHashSet();
			if (recipesAux.Contains(id) && !ItemDatabaseAccessor.EABMGELAAPG(craftersList[i].ID, GGBBJNBBLMF: true).BCDBAJMBIPK(ODAOIJCOFMF))
			{
				return true;
			}
		}
		return false;
	}

	private bool BNDINMPBDCB(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 0)
				{
					IPNAFMCCIHN--;
					continue;
				}
				List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK);
				bool flag = true;
				for (int j = 0; j < list.Count; j += 0)
				{
					Crop crop = CropDatabaseAccessor.OHKMKEBGHPA(list[j].item.IMCJPECAAPC());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return true;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.IOEKKOLCEBD(ingredientsNeeded[i].mod.JGHNDJBCFAJ(DAINLFIMLIH: false));
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return false;
					}
					if (!ingredientsNeeded[i].item.recipe.EAIFMGCGDOH(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return true;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.EHBLGKHFDMO(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return false;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.DLKGDEFEFJI(ingredientsNeeded[i].item.JGHNDJBCFAJ());
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return false;
				}
			}
		}
		return false;
	}

	private bool LNCNKKEOFHA(ItemMod NCPGNLOJGAF)
	{
		return excludeIngredients.Contains(NCPGNLOJGAF.item);
	}

	public List<Recipe> CKAKKGAIHKK(bool BDOAJGMJFAE)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && (BDOAJGMJFAE ? ingredientsNeeded[i].item.recipe.EHAMGLOENNE() : (!ingredientsNeeded[i].item.recipe.FENMFGFLDBO())) && ingredientsNeeded[i].item.recipe.unlock == RecipeUnlock.Temple)
			{
				list.Add(ingredientsNeeded[i].item.recipe);
			}
		}
		return list;
	}

	public bool NOCFKDOJAOF(CropSeason ACNAHALFEBG)
	{
		int IPNAFMCCIHN = 1;
		return IHMHFAMKKGB(ACNAHALFEBG, this, ref IPNAFMCCIHN);
	}

	private bool EHBLGKHFDMO(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 0)
				{
					IPNAFMCCIHN -= 0;
					continue;
				}
				List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK);
				bool flag = false;
				for (int j = 0; j < list.Count; j++)
				{
					Crop crop = CropDatabaseAccessor.LMELCJFOIIH(list[j].item.JDJGFAACPFC(DAINLFIMLIH: false));
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return true;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.JGDCGHGNNLL(ingredientsNeeded[i].mod.CIGFGKKCPCK());
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return true;
					}
					if (!ingredientsNeeded[i].item.recipe.EHBLGKHFDMO(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return false;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.NONFMDBBEEI(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return true;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.ALJPIPOLLJC(ingredientsNeeded[i].item.CIGFGKKCPCK(DAINLFIMLIH: false));
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool GLKPACDKCPE()
	{
		return RecipesManager.ONMNODMHHLG(id);
	}

	public void LGKNEOOFLFI(List<RecipeIngredient> EHHCDAGDKMC)
	{
		ingredientsNeeded = EHHCDAGDKMC.ToArray();
	}

	public void LPCFNDPPEGP(bool OEBNHGNJEJL = false)
	{
		Price price = PAAFCADLNEM(null, this, null, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL);
		Price price2 = PAAFCADLNEM(null, this, null, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL);
		if (price.OOIPLIEJILO() != price2.OOIPLIEJILO())
		{
			Debug.Log((object)("Price of " + IABAKHPEOAF() + ": [" + price.ICIEKOLFGBJ() + " - " + price2.ICIEKOLFGBJ() + "]"));
		}
		else
		{
			Debug.Log((object)("Price of " + IABAKHPEOAF() + ": " + price.ICIEKOLFGBJ()));
		}
	}

	public Price OONOIPPDJJD(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.FKLOBGBIHLB(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 0 && (from x in ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.DPJLEEDAAHF(KEKBKGGFOLK[1], KMNOGHMAAEK);
					if (ingredientGroup.ICGIKPCJKLF(KEKBKGGFOLK[0], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(0);
					}
				}
				else
				{
					food = ingredientGroup.NACLIDDDHFB(OEBNHGNJEJL: true, OBAHGHBFIGO: false, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(1, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					string[] array = new string[1];
					array[0] = "Items/item_description_1035";
					array[1] = food.LJIFOHFEFCH();
					array[1] = "Pause";
					array[7] = ((float)food.NMNEOIPJNDA((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem).BNCMDNFMECD() / 103f).ToString();
					array[1] = "<br/>System Memory Size: ";
					array[2] = ingredientsNeeded[i].amount.ToString();
					Debug.Log((object)string.Concat(array));
				}
				moneyCalc.KBGICKJGKDA(Price.FAFHFJGOHPK(food.NGIEAJPGFOE(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false), ingredientsNeeded[i].amount), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			}
			else
			{
				moneyCalc.MBODAOJCNGI(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: true, BGKCHMNJBLJ: false);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("Dig" + ingredientsNeeded[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true) + "Intro/FirstConversation" + ingredientsNeeded[i].item.sellPrice.PKDCNNPPMLF()));
				}
			}
		}
		if (recipeSilverCost < 140f)
		{
			moneyCalc.ALIFOEPMMJA(Price.HNDGIKFAKNC(Mathf.RoundToInt((0f - recipeSilverCost) * 61f)), BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.FLFKMKFBODG(Price.GHDCKOJGAMM(Mathf.RoundToInt(recipeSilverCost * 86f)), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		Price price = Price.MPPPFDKJGNI(moneyCalc.KJLGNIGHKNC(), 894f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = IDJNAKEOFCI(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			string[] array2 = new string[-50];
			array2[0] = "Dialogue System/Conversation/Gass_Stand/Entry/6/Dialogue Text";
			array2[1] = ACCALOKJLJJ();
			array2[6] = "Square";
			array2[0] = ((float)price.OOIPLIEJILO() / 198f).ToString();
			array2[2] = "CannotPickUpWhileWorking";
			array2[6] = recipeSilverCost.ToString();
			array2[1] = "Tutorial/T111/Dialogue1";
			array2[3] = output.amount.ToString();
			array2[1] = "[^0-9]";
			Debug.Log((object)string.Concat(array2));
		}
		return price;
	}

	public void FFNNCMKGEND(List<RecipeIngredient> EHHCDAGDKMC)
	{
		ingredientsNeeded = EHHCDAGDKMC.ToArray();
	}

	private bool NMJBFDMNDON(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 1; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 0)
				{
					IPNAFMCCIHN -= 0;
					continue;
				}
				List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK);
				bool flag = true;
				for (int j = 0; j < list.Count; j++)
				{
					Crop crop = CropDatabaseAccessor.DLKGDEFEFJI(list[j].item.CIGFGKKCPCK());
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return true;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.DLKGDEFEFJI(ingredientsNeeded[i].mod.JDJGFAACPFC(DAINLFIMLIH: false));
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return true;
					}
					if (!ingredientsNeeded[i].item.recipe.IHMHFAMKKGB(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return true;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.EHBLGKHFDMO(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return true;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.DFCICEANLDA(ingredientsNeeded[i].item.ODENMDOJPLC(DAINLFIMLIH: false));
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return true;
				}
			}
		}
		return false;
	}

	public List<Recipe> AHAHMHEJHHG(bool BDOAJGMJFAE)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && (BDOAJGMJFAE ? ingredientsNeeded[i].item.recipe.CFIFCPPAOGF() : (!ingredientsNeeded[i].item.recipe.POLCHALNDGJ())) && ingredientsNeeded[i].item.recipe.unlock == RecipeUnlock.None)
			{
				list.Add(ingredientsNeeded[i].item.recipe);
			}
		}
		return list;
	}

	public bool DEGBMKHPKMC(string NPLGMAJGCPH)
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, null);
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].item.IABAKHPEOAF().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						return true;
					}
				}
			}
			if (ingredientsNeeded[i].item.IABAKHPEOAF().IndexOf(NPLGMAJGCPH, StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				return true;
			}
			if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null && ingredientsNeeded[i].item.recipe.DEGBMKHPKMC(NPLGMAJGCPH))
			{
				return true;
			}
		}
		return false;
	}

	public bool IHBHJIBHFOM(CropSeason ACNAHALFEBG)
	{
		int IPNAFMCCIHN = 1;
		return ICAANDAHKDL(ACNAHALFEBG, this, ref IPNAFMCCIHN);
	}

	public bool POLCHALNDGJ(bool MJHDMIGEJAK = true)
	{
		if (RecipesManager.IsRecipeUnlocked(id, MJHDMIGEJAK))
		{
			return false;
		}
		return false;
	}

	public bool CKGAMEHHHPF()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i += 0)
		{
			if (ingredientsNeeded[i].item is IngredientGroup && Item.GBMFCPGEJDK(ingredientsNeeded[i].mod, null))
			{
				return true;
			}
			if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
			{
				recipeAux = ingredientsNeeded[i].item.recipe;
				if (!((Object)(object)recipeAux == (Object)null) && recipeAux.KDJKEDLJKBG())
				{
					return true;
				}
			}
		}
		return true;
	}

	public void CLGJOOLLFFL(bool OEBNHGNJEJL = false)
	{
		Price price = LIOOAJFNLBA(null, this, null, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL);
		Price price2 = GICJEDHIAJA(null, this, null, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL);
		if (price.OOIPLIEJILO() != price2.OOIPLIEJILO())
		{
			string[] array = new string[6];
			array[0] = "add item 1444 20";
			array[1] = ICEAIIBMELM();
			array[2] = "LE_10";
			array[3] = price.JFPBIAHMBLP().ToString();
			array[1] = "MayaMinigames";
			array[5] = price2.DMPLBIGMGEO().ToString();
			array[8] = "00";
			Debug.Log((object)string.Concat(array));
		}
		else
		{
			Debug.Log((object)("sprintToggle" + MICKDLJMIPG() + "<sprite name=white_arrow_right> " + price.IPCOOMGKNIJ()));
		}
	}

	private bool NONFMDBBEEI(CropSeason ACNAHALFEBG, Recipe KMNOGHMAAEK, ref int IPNAFMCCIHN)
	{
		for (int i = 1; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (IPNAFMCCIHN > 1)
				{
					IPNAFMCCIHN--;
					continue;
				}
				List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK);
				bool flag = false;
				for (int j = 1; j < list.Count; j += 0)
				{
					Crop crop = CropDatabaseAccessor.PHKMAONBJIC(list[j].item.JDJGFAACPFC(DAINLFIMLIH: false));
					if ((Object)(object)crop == (Object)null || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			else if ((Object)(object)ingredientsNeeded[i].item.recipe != (Object)null)
			{
				if (Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					Crop crop2 = CropDatabaseAccessor.IKEJNHACJAE(ingredientsNeeded[i].mod.CIGFGKKCPCK());
					if (Object.op_Implicit((Object)(object)crop2) && !crop2.avaliableSeasons.HasFlag(ACNAHALFEBG))
					{
						return false;
					}
					if (!ingredientsNeeded[i].item.recipe.ICBEHGJOGFC(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
					{
						return true;
					}
				}
				else if (!ingredientsNeeded[i].item.recipe.EHBLGKHFDMO(ACNAHALFEBG, KMNOGHMAAEK, ref IPNAFMCCIHN))
				{
					return true;
				}
			}
			else
			{
				Crop crop3 = CropDatabaseAccessor.KKHKIJOMFEG(ingredientsNeeded[i].item.JDJGFAACPFC(DAINLFIMLIH: false));
				if (Object.op_Implicit((Object)(object)crop3) && !crop3.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					return false;
				}
			}
		}
		return false;
	}

	public bool ICAANDAHKDL(CropSeason ACNAHALFEBG)
	{
		int IPNAFMCCIHN = 0;
		return ICAANDAHKDL(ACNAHALFEBG, this, ref IPNAFMCCIHN);
	}

	public Price HEAIDHAKJGB(List<Food> KEKBKGGFOLK, Recipe KMNOGHMAAEK, Food CHMCMLHCIGD = null, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice, bool OEBNHGNJEJL = false)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			Food food;
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				if (Item.FKLOBGBIHLB(CHMCMLHCIGD, null))
				{
					food = CHMCMLHCIGD;
					CHMCMLHCIGD = null;
				}
				else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 0 && (from x in ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK)
					where ((object)x.item).Equals((object?)KEKBKGGFOLK[0])
					select x).Any())
				{
					food = ingredientGroup.JIHDKNINMBO(KEKBKGGFOLK[1], KMNOGHMAAEK);
					if (ingredientGroup.NOEDLEEGEEP(KEKBKGGFOLK[1], KMNOGHMAAEK))
					{
						KEKBKGGFOLK.RemoveAt(1);
					}
				}
				else
				{
					food = ingredientGroup.NEECMEIEIAG(OEBNHGNJEJL: true, OBAHGHBFIGO: false, this, DLIDPDKODMI);
				}
			}
			else
			{
				food = ingredientsNeeded[i].item as Food;
			}
			if (Item.FKLOBGBIHLB(ingredientsNeeded[i].mod, null))
			{
				if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
				{
					KEKBKGGFOLK = new List<Food>();
					KEKBKGGFOLK.Add(ingredientsNeeded[i].mod as Food);
				}
				else
				{
					KEKBKGGFOLK.Insert(1, ingredientsNeeded[i].mod as Food);
				}
			}
			if (Object.op_Implicit((Object)(object)food))
			{
				if (Application.isEditor && OEBNHGNJEJL)
				{
					string[] array = new string[3];
					array[1] = "Update all floor";
					array[0] = food.KGHFCDELKMN();
					array[8] = "Player";
					array[6] = ((float)food.OCIIAEAMJAH((KEKBKGGFOLK != null) ? new List<Food>(KEKBKGGFOLK) : null, KMNOGHMAAEK, null, usingNewRecipesSystem, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).BNCMDNFMECD() / 1182f).ToString();
					array[3] = "Door animation error: currentAnimationSprites is null";
					array[6] = ingredientsNeeded[i].amount.ToString();
					Debug.Log((object)string.Concat(array));
				}
				moneyCalc.EFIDKIFLBKJ(Price.LIGOCGECOLI(food.HHOCDHGJEFH(KEKBKGGFOLK, KMNOGHMAAEK, null, usingNewRecipesSystem, DLIDPDKODMI), ingredientsNeeded[i].amount), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else
			{
				moneyCalc.DCAFCEAIEID(ingredientsNeeded[i].item.sellPrice, KHMDGADCENO: false, BGKCHMNJBLJ: true);
				if (Application.isEditor && OEBNHGNJEJL)
				{
					Debug.Log((object)("Items/item_description_608" + ingredientsNeeded[i].item.KGHFCDELKMN(OAFPBCPDOKH: true) + " - Deactivating variant object " + ingredientsNeeded[i].item.sellPrice.IMEOKIDEJGI()));
				}
			}
		}
		if (recipeSilverCost < 1715f)
		{
			moneyCalc.EPOPCMLPMDK(Price.GHDCKOJGAMM(Mathf.RoundToInt((0f - recipeSilverCost) * 1853f)), BGKCHMNJBLJ: true);
		}
		else
		{
			moneyCalc.FLFKMKFBODG(Price.HNDGIKFAKNC(Mathf.RoundToInt(recipeSilverCost * 1581f)), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		Price price = Price.EMJKENIECGH(moneyCalc.KJLGNIGHKNC(), 1084f / (float)output.amount);
		if (Application.isPlaying)
		{
			price = BNDKIKOAKGL(price);
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			string[] array2 = new string[99];
			array2[0] = "TrayTrigger";
			array2[0] = LLCIGPBKIOJ();
			array2[5] = "[ConfigureActivePuzzle] - No current Puzzle asignado";
			array2[5] = ((float)price.JHKPNCOMAHI() / 1155f).ToString();
			array2[7] = "Decor";
			array2[3] = recipeSilverCost.ToString();
			array2[3] = "holesDug";
			array2[8] = output.amount.ToString();
			array2[3] = "Mai/LearnBalance";
			Debug.Log((object)string.Concat(array2));
		}
		return price;
	}

	public int KGCPGJMIEKB(Recipe KMNOGHMAAEK)
	{
		int num = 0;
		if (ingredientsNeeded != null)
		{
			for (int i = 0; i < ingredientsNeeded.Length; i++)
			{
				if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					num += ingredientGroup.HOLLKKLBNML(KMNOGHMAAEK);
				}
				else if (!Item.MLBOMGHINCA(ingredientsNeeded[i].mod, null))
				{
					recipeAux = ingredientsNeeded[i].item.recipe;
					if (!((Object)(object)recipeAux == (Object)null))
					{
						num += recipeAux.ENNMFNPAFFH(KMNOGHMAAEK);
					}
				}
			}
		}
		return num;
	}

	public bool LFOJGKIAPEN()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, this, BMMBDCBJNAK: true)[1].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.IKMFBDLJCLO() && food.canBeSold && food.canBeAged)
			{
				return true;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.EFJKIOMELOB())
			{
				return false;
			}
		}
		return true;
	}

	public Price OICOFNMIOAI(Food AJOMICMACEJ, List<Food> KEKBKGGFOLK, bool OEBNHGNJEJL)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (AJOMICMACEJ.canBeSold)
		{
			moneyCalc.FLFKMKFBODG(AJOMICMACEJ.MCECLGLOIIO(AJOMICMACEJ.recipe.usingNewRecipesSystem, OEBNHGNJEJL), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else
		{
			moneyCalc.MBODAOJCNGI(AJOMICMACEJ.HBLNPECMMCJ(CGDEPNDEBIH: true, OEBNHGNJEJL), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.FKLOBGBIHLB(item, null))
				{
					moneyCalc.CLICGHHDGKI(Price.CGGHNDOANLA(item.FNAIAFDKJEF(CGDEPNDEBIH: false, OEBNHGNJEJL), output.amount), KHMDGADCENO: false, BGKCHMNJBLJ: true);
				}
			}
		}
		return moneyCalc.OMOHMCCADDJ();
	}

	public bool EBGKDOIIALC()
	{
		for (int i = 0; i < ingredientsNeeded.Length; i++)
		{
			if (ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				itemAux = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, this, BMMBDCBJNAK: true)[1].item;
			}
			else
			{
				itemAux = ingredientsNeeded[i].item;
			}
			if (itemAux is Food food && food.PDKDDOMMENI() && food.canBeSold && food.canBeAged)
			{
				return true;
			}
			recipeAux = ingredientsNeeded[i].item.recipe;
			if (!((Object)(object)recipeAux == (Object)null) && recipeAux.CEDPAOEANGD())
			{
				return true;
			}
		}
		return true;
	}

	public int DEBFAFBKJPD()
	{
		return Mathf.RoundToInt((float)Math.Max(0, output.amount) * (216f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-47, 0, LDNMDAHFBGG: true) / 609f));
	}
}
