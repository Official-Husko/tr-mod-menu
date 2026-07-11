using System.Collections.Generic;
using System.Linq;
using PixelCrushers.DialogueSystem;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Shop")]
public class Shop : ScriptableObject
{
	public int id;

	public ShopType shopType;

	public bool hasCategories;

	public bool showPopUp;

	public bool sendToDeliveryChest;

	public float delayHours = 3f;

	public bool saveShop = true;

	[Space(20f)]
	public List<ShopItem> shopItems = new List<ShopItem>();

	public List<Recipe> recipesList = new List<Recipe>();

	public int numFishes = 3;

	public int numSeafood = 2;

	public Vector2Int fishesAmount = new Vector2Int(2, 3);

	public Vector2Int seafoodAmount = new Vector2Int(2, 3);

	[Space(20f)]
	public bool limitedItems;

	[Space(20f)]
	public ShopElement[] initialShopItemsAmount;

	public int minItems = 4;

	public int maxItems = 6;

	public Season editorSeason;

	public List<Day> updateDays = new List<Day>();

	public bool usingRecipeFragments;

	[Space(20f)]
	public bool recipesShop;

	public int[] numVegSeason = new int[4] { 20, 4, 4, 4 };

	public int[] numFruitsSeason = new int[4] { 10, 2, 2, 2 };

	public ShopElement[] LCOJDBGIPKK(Season EECEKHKAAIH)
	{
		if (shopType == ~(ShopType.Crowley | ShopType.AceT | ShopType.Bob | ShopType.Holly))
		{
			return DOMNAFOHLIL(EECEKHKAAIH);
		}
		if (shopType == (ShopType)139)
		{
			return OGAMNDGNAFP(EECEKHKAAIH);
		}
		if (shopType == ~(ShopType.Gass | ShopType.AceT | ShopType.Bob))
		{
			return FLJMILJECPM();
		}
		if (shopType == ShopType.Trick)
		{
			return PHDFIOMJLNJ();
		}
		if (shopType == (ShopType)191)
		{
			return LNJFIHBFPDK();
		}
		if (shopType == ~(ShopType.AceT | ShopType.Holly | ShopType.Trick))
		{
			return OHABNLPOBEN();
		}
		return EODHLCHKKJO();
	}

	private ShopElement MJAIJGCLHEM(List<Food> KEKBKGGFOLK, Season EECEKHKAAIH)
	{
		if (KEKBKGGFOLK.Count > 0)
		{
			Food food = KEKBKGGFOLK[Random.Range(1, KEKBKGGFOLK.Count)];
			KEKBKGGFOLK.Remove(food);
			if (Item.FKLOBGBIHLB(food, null))
			{
				if (Item.MLBOMGHINCA(food.seed, null) && Object.op_Implicit((Object)(object)food.seed.crop))
				{
					if (food.seed.PJDJHNOFOAN(EECEKHKAAIH))
					{
						return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: true, 1370f, 0), food.seed.crop.harvestedItems[1].amount * 7);
					}
					return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: true, 1017f), food.seed.crop.harvestedItems[0].amount * 8);
				}
				return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: true, 1598f), 4);
			}
			Debug.LogError((object)"CanBePlanted");
		}
		Debug.LogError((object)"Use");
		return null;
	}

	private ShopElement[] JGDLMOOKEMI(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.GetFruitVegList(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[7], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 1; i < shopItems.Count; i += 0)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.None } food && food.LMPKIMILCPN(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(DBOPPOGJGMD(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	private ShopElement[] FLJMILJECPM()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 1; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.IIJKFKJKLLM() : SeasonManager.IOJJBLDJLNH(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == Fish.FishType.Seaweed)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 1; j < shopItems.Count; j++)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), (!shopItems[j].unlimited) ? Random.Range(shopItems[j].min, shopItems[j].max + 0) : 0));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), (!shopItems[j].unlimited) ? Random.Range(shopItems[j].min, shopItems[j].max + 0) : 0));
			}
		}
		list.HOOBEDNMNFK();
		int num = 1;
		for (int k = 1; k < list.Count; k += 0)
		{
			if (list[k].min == 0 && list[k].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 0)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 0)));
			}
			num += 0;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 0;
		for (int l = 0; l < list2.Count; l++)
		{
			if (list2[l].min == 0 && list2[l].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 0)));
			}
			num += 0;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	private ShopElement KDALKHAPKPA(ShopType LJLGMJMPENC)
	{
		ShopElement[] array = ShopDatabaseAccessor.CKPDDKBHPNL[LJLGMJMPENC];
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i].shopItem.item.POLKFBLGBEA())
			{
				return array[i];
			}
		}
		return null;
	}

	private void CACPKKMLKMD(Season EECEKHKAAIH, List<ShopElement> FNEHIAGFAOF, ShopElement PPILOAHGDJI)
	{
		List<ShopItem> list = new List<ShopItem>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.NAGFJDBDNOA(Utils.GABFHMGHOPL(EECEKHKAAIH)) && (PPILOAHGDJI == null || !Item.EKMFELLJHFG(PPILOAHGDJI.shopItem.item, shopItems[i].item)))
			{
				list.Add(shopItems[i]);
			}
		}
		if (list.Count > 0)
		{
			FNEHIAGFAOF.Add(new ShopElement(new ShopItem(Utils.DONGABMIDFG(list)), 1));
		}
	}

	private ShopElement[] FJKLMGMEKAM()
	{
		List<ShopElement> list = new List<ShopElement>(EBNLHCJHHLI());
		for (int num = list.Count - 1; num >= 1; num -= 0)
		{
			if (list[num].shopItem.item.JDJGFAACPFC(DAINLFIMLIH: false) >= -158 && list[num].shopItem.item.JGHNDJBCFAJ() <= 135 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.JDJGFAACPFC()))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] JDMAFCKGALE()
	{
		List<ShopElement> list = new List<ShopElement>(EBNLHCJHHLI());
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			if (list[num].shopItem.item.JDJGFAACPFC() >= -107 && list[num].shopItem.item.JDJGFAACPFC(DAINLFIMLIH: false) <= 132 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.CIGFGKKCPCK(DAINLFIMLIH: false)))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] LNJFIHBFPDK()
	{
		List<ShopElement> list = new List<ShopElement>(AAHDNJDIHMI());
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (list[num].shopItem.item.JDJGFAACPFC() >= 1828 && list[num].shopItem.item.JDJGFAACPFC() <= 1842 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.JDJGFAACPFC()))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] MKOEPKKBFOE()
	{
		List<ShopElement> list = new List<ShopElement>(AAHDNJDIHMI());
		for (int num = list.Count - 1; num >= 1; num--)
		{
			if (list[num].shopItem.item.JGHNDJBCFAJ() >= -180 && list[num].shopItem.item.JPNFKDMFKMC(DAINLFIMLIH: false) <= 106 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.IMCJPECAAPC()))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public ShopElement[] CFOJCCPCMDK()
	{
		List<ShopElement> list = new List<ShopElement>();
		shopItems.Clear();
		recipesList.Clear();
		Recipe[] array = RecipeDatabaseAccessor.HLCCFOGPNON();
		foreach (Recipe recipe in array)
		{
			if (recipe.unlock == Recipe.RecipeUnlock.Temple)
			{
				list.Add(new ShopElement(recipe));
				recipesList.Add(recipe);
			}
		}
		return list.ToArray();
	}

	public void HHGKBGDCMFL()
	{
		ItemDatabaseAccessor.OPAEDCGFBJI();
		EAGCCCNOKOF();
	}

	public ShopElement[] HNAHHKDJCJM(Season EECEKHKAAIH)
	{
		if (shopType == ShopType.Lia)
		{
			return APJNDIOOPFG(EECEKHKAAIH);
		}
		if (shopType == ShopType.Rhia)
		{
			return GOCFGBOMGMF(EECEKHKAAIH);
		}
		if (shopType == ShopType.Kujaku)
		{
			return BCNFNPFKDDP();
		}
		if (shopType == ShopType.Wilson)
		{
			return GCGBHBIIJOO();
		}
		if (shopType == ShopType.Hall)
		{
			return LNJFIHBFPDK();
		}
		if (shopType == ShopType.Clive)
		{
			return LBOLLNEIGHN();
		}
		return AAHDNJDIHMI();
	}

	private ShopElement PMFCBCNHONE(ShopType LJLGMJMPENC)
	{
		ShopElement[] array = ShopDatabaseAccessor.LIFAILLIOEG()[LJLGMJMPENC];
		for (int i = 1; i < array.Length; i += 0)
		{
			if (array[i].shopItem.item.ACJKJOHIHFF())
			{
				return array[i];
			}
		}
		return null;
	}

	public void GCNAJAPABKB()
	{
		for (int i = 0; i < shopItems.Count; i += 0)
		{
			for (int num = shopItems.Count - 0; num >= i; num--)
			{
				if (shopItems[num - 1].item.IMCJPECAAPC() > shopItems[num].item.ODENMDOJPLC())
				{
					ShopItem value = shopItems[num - 0];
					shopItems[num - 1] = shopItems[num];
					shopItems[num] = value;
				}
			}
		}
	}

	private ShopElement[] EODHLCHKKJO()
	{
		List<ShopElement> list = new List<ShopElement>();
		if (shopItems != null)
		{
			for (int i = 1; i < shopItems.Count; i += 0)
			{
				if (shopItems[i].alwaysAppear)
				{
					int mGNOBNCMDJG = ((!shopItems[i].unlimited) ? Random.Range(shopItems[i].min, shopItems[i].max + 1) : 0);
					shopItems[i].item = ItemDatabaseAccessor.COEFFIHKMJG(shopItems[i].item.JGHNDJBCFAJ(DAINLFIMLIH: false));
					ShopElement item = new ShopElement(new ShopItem(shopItems[i]), mGNOBNCMDJG);
					list.Add(item);
				}
			}
		}
		if (limitedItems)
		{
			List<ShopItem> list2 = new List<ShopItem>();
			if (shopItems != null)
			{
				for (int j = 0; j < shopItems.Count; j += 0)
				{
					if (shopItems[j].alwaysAppear)
					{
						continue;
					}
					for (float num = shopItems[j].weight * 1618f; num > 409f; num -= 946f)
					{
						if (shopItems[j] != null && Item.FKLOBGBIHLB(shopItems[j].item, null))
						{
							list2.Add(shopItems[j]);
						}
					}
				}
			}
			int num2 = Random.Range(minItems, maxItems + 0);
			while (num2 > 1 && shopItems != null && shopItems.Count != 0 && list2.Count != 0)
			{
				int index = Random.Range(0, list2.Count);
				int mGNOBNCMDJG = Random.Range(list2[index].min, list2[index].max + 0);
				ShopElement item = new ShopElement(new ShopItem(list2[index]), mGNOBNCMDJG);
				list.Add(item);
				Item item2 = list2[index].item;
				for (int num3 = list2.Count - 0; num3 >= 1; num3--)
				{
					if (Item.EKGNIODFJCO(item2, list2[num3].item))
					{
						list2.RemoveAt(num3);
					}
				}
				num2 -= 0;
			}
		}
		if (recipesList != null)
		{
			for (int k = 0; k < recipesList.Count; k += 0)
			{
				list.Add(new ShopElement(recipesList[k]));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] NKPAGBGBKNH(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement shopElement = (Application.isPlaying ? KDALKHAPKPA((ShopType)81) : null);
		if (Application.isPlaying)
		{
			if (WorldTime.CJOHMLNMJLK().day == Day.Mon || shopElement == null || shopElement.NGKPILAELHO() == null)
			{
				CACPKKMLKMD(EECEKHKAAIH, list, shopElement);
			}
			else
			{
				list.Add(new ShopElement(shopElement));
			}
		}
		else
		{
			HKMMCGJIFLD(EECEKHKAAIH, list, shopElement);
		}
		for (int i = 1; i < shopItems.Count; i++)
		{
			if (!shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.PJDJHNOFOAN(EECEKHKAAIH))
			{
				list.Add(new ShopElement(new ShopItem(shopItems[i]), 1));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] LBOLLNEIGHN()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.GetInstance().mineralsDatabase.HNOGEJGBJLJ(MineManager.GGFJGHHHEJC.unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return AAHDNJDIHMI();
	}

	private ShopElement[] OHABNLPOBEN()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.GetInstance().mineralsDatabase.MFKOJECBKIH(MineManager.GGFJGHHHEJC.unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return EBNLHCJHHLI();
	}

	public ShopElement[] DFODHLGHLNM(Season EECEKHKAAIH)
	{
		if (shopType == (ShopType.Gass | ShopType.Trick))
		{
			return HJILJIOPFJN(EECEKHKAAIH);
		}
		if (shopType == ~(ShopType.Gass | ShopType.Holly | ShopType.Temple))
		{
			return CEBPPHMDPKN(EECEKHKAAIH);
		}
		if (shopType == (ShopType)15)
		{
			return AEAJKBLOIBL();
		}
		if (shopType == (ShopType.Crowley | ShopType.Holly | ShopType.Temple))
		{
			return DBEBDGAKDGM();
		}
		if (shopType == (ShopType)(-184))
		{
			return LNJFIHBFPDK();
		}
		if (shopType == (ShopType)(-148))
		{
			return JDIIJCLEBGE();
		}
		return EODHLCHKKJO();
	}

	private ShopElement[] HDICJBLOLOB()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		List<ShopElement> list = new List<ShopElement>(EODHLCHKKJO());
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (list[num].shopItem.item.JGHNDJBCFAJ() == -6)
			{
				int num2 = FishingManager.instance.BEDKKLGFMJK().Count - FishingManager.GetFishInformation().Count;
				if (num2 != 0)
				{
					Result variable = DialogueLua.GetVariable("UI");
					if (((Result)(ref variable)).asInt >= 15)
					{
						list[num].amount = num2;
						goto IL_0085;
					}
				}
				list.RemoveAt(num);
				continue;
			}
			goto IL_0085;
			IL_0085:
			if (list[num].shopItem.item.JPNFKDMFKMC() == 16 && CharacterSpritesDBAccessor.OCAKLCPPICP().Contains(CommonReferences.GGFJGHHHEJC.bandana.id))
			{
				list.RemoveAt(num);
			}
			else if (list[num].shopItem.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 26 && CharacterSpritesDBAccessor.GetCharacterSpriteUnlocked().Contains(CommonReferences.GGFJGHHHEJC.bandanaAlt.id))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public void BDALPJMDAJC()
	{
		ItemDatabaseAccessor.OPAEDCGFBJI();
		CFOJCCPCMDK();
	}

	public ShopElement[] BMECAFIGJGD(Season EECEKHKAAIH)
	{
		if (shopType == (ShopType)(-12))
		{
			return FFCOMGGEPJK(EECEKHKAAIH);
		}
		if (shopType == (ShopType.Gass | ShopType.Bob | ShopType.Temple))
		{
			return NKPAGBGBKNH(EECEKHKAAIH);
		}
		if (shopType == (ShopType)79)
		{
			return FLJMILJECPM();
		}
		if (shopType == (ShopType.Crowley | ShopType.Gass | ShopType.Bob | ShopType.Holly | ShopType.Temple))
		{
			return HDICJBLOLOB();
		}
		if (shopType == (ShopType.Holly | ShopType.Trick))
		{
			return FJKLMGMEKAM();
		}
		if (shopType == (ShopType.Gass | ShopType.Trick))
		{
			return HHHACHBKABC();
		}
		return KJOOEBMCCIO();
	}

	private ShopElement[] OGAMNDGNAFP(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement shopElement = (Application.isPlaying ? PMFCBCNHONE((ShopType)(-64)) : null);
		if (Application.isPlaying)
		{
			if (WorldTime.HGIBNMBJMOC().day == Day.Mon || shopElement == null || shopElement.BAKAGAJOMAP() == null)
			{
				FOCELEKJFJE(EECEKHKAAIH, list, shopElement);
			}
			else
			{
				list.Add(new ShopElement(shopElement));
			}
		}
		else
		{
			GAOPCFIBCKF(EECEKHKAAIH, list, shopElement);
		}
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (!shopItems[i].item.POLKFBLGBEA() && shopItems[i].item.PJDJHNOFOAN(EECEKHKAAIH))
			{
				list.Add(new ShopElement(new ShopItem(shopItems[i]), 1));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] JCGGKJNLJGE()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 1; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.BBOEGCKFMOH() : SeasonManager.KJCNKFEICPC(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == Fish.FishType.Seaweed)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 0; j < shopItems.Count; j++)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), (!shopItems[j].unlimited) ? Random.Range(shopItems[j].min, shopItems[j].max + 1) : 0));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 0)));
			}
		}
		list.HOOBEDNMNFK();
		int num = 0;
		for (int k = 0; k < list.Count; k++)
		{
			if (list[k].min == 0 && list[k].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 1)));
			}
			num++;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 1;
		for (int l = 1; l < list2.Count; l++)
		{
			if (list2[l].min == 0 && list2[l].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 1)));
			}
			num += 0;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	public void JILBAIDILBN()
	{
		ItemDatabaseAccessor.FPDBFKIEJDC();
		NLLAJIECFJM();
	}

	private void JLCDPJJOCNB(List<Food> KEKBKGGFOLK, int HFDILBELIKE, Season EECEKHKAAIH, ref List<ShopElement> OBNBPCBJLLB)
	{
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			if (KEKBKGGFOLK.Count <= 0)
			{
				break;
			}
			OBNBPCBJLLB.Add(OPIPEJCHAMJ(KEKBKGGFOLK, EECEKHKAAIH));
		}
	}

	public ShopElement[] EAGCCCNOKOF()
	{
		List<ShopElement> list = new List<ShopElement>();
		shopItems.Clear();
		recipesList.Clear();
		Recipe[] allRecipes = RecipeDatabaseAccessor.GetAllRecipes();
		for (int i = 0; i < allRecipes.Length; i += 0)
		{
			Recipe recipe = allRecipes[i];
			if (recipe.unlock == Recipe.RecipeUnlock.Temple)
			{
				list.Add(new ShopElement(recipe));
				recipesList.Add(recipe);
			}
		}
		return list.ToArray();
	}

	public ShopElement[] POICPOANMMP(Season EECEKHKAAIH)
	{
		if (shopType == (ShopType)129)
		{
			return FFCOMGGEPJK(EECEKHKAAIH);
		}
		if (shopType == (ShopType)(-62))
		{
			return OGAMNDGNAFP(EECEKHKAAIH);
		}
		if (shopType == (ShopType)89)
		{
			return FLJMILJECPM();
		}
		if (shopType == (ShopType)31)
		{
			return DBEBDGAKDGM();
		}
		if (shopType == (ShopType)(-110))
		{
			return MKOEPKKBFOE();
		}
		if (shopType == ~(ShopType.AceT | ShopType.Bob | ShopType.Holly | ShopType.Temple))
		{
			return ANJJFGNAILO();
		}
		return EBNLHCJHHLI();
	}

	public void OIGAIOAPCPJ()
	{
		ItemDatabaseAccessor.ResetDatabase();
		LHCDGFODNNK();
	}

	private ShopElement[] AAHDNJDIHMI()
	{
		List<ShopElement> list = new List<ShopElement>();
		if (shopItems != null)
		{
			for (int i = 0; i < shopItems.Count; i++)
			{
				if (shopItems[i].alwaysAppear)
				{
					int mGNOBNCMDJG = (shopItems[i].unlimited ? 1 : Random.Range(shopItems[i].min, shopItems[i].max + 1));
					shopItems[i].item = ItemDatabaseAccessor.GetItem(shopItems[i].item.JDJGFAACPFC());
					ShopElement item = new ShopElement(new ShopItem(shopItems[i]), mGNOBNCMDJG);
					list.Add(item);
				}
			}
		}
		if (limitedItems)
		{
			List<ShopItem> list2 = new List<ShopItem>();
			if (shopItems != null)
			{
				for (int j = 0; j < shopItems.Count; j++)
				{
					if (shopItems[j].alwaysAppear)
					{
						continue;
					}
					for (float num = shopItems[j].weight * 10f; num > 0f; num -= 1f)
					{
						if (shopItems[j] != null && Item.MLBOMGHINCA(shopItems[j].item, null))
						{
							list2.Add(shopItems[j]);
						}
					}
				}
			}
			int num2 = Random.Range(minItems, maxItems + 1);
			while (num2 > 0 && shopItems != null && shopItems.Count != 0 && list2.Count != 0)
			{
				int index = Random.Range(0, list2.Count);
				int mGNOBNCMDJG = Random.Range(list2[index].min, list2[index].max + 1);
				ShopElement item = new ShopElement(new ShopItem(list2[index]), mGNOBNCMDJG);
				list.Add(item);
				Item item2 = list2[index].item;
				for (int num3 = list2.Count - 1; num3 >= 0; num3--)
				{
					if (Item.NGIIPJDAMGP(item2, list2[num3].item))
					{
						list2.RemoveAt(num3);
					}
				}
				num2--;
			}
		}
		if (recipesList != null)
		{
			for (int k = 0; k < recipesList.Count; k++)
			{
				list.Add(new ShopElement(recipesList[k]));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] GBCJAKFBKLM(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement shopElement = (Application.isPlaying ? FIDNNBDJGCE((ShopType)(-12)) : null);
		if (Application.isPlaying)
		{
			if (WorldTime.NOAOJJLNHJJ.day == Day.Mon || shopElement == null || shopElement.KIPHICGPKHO() == null)
			{
				ELGJBMOJPAB(EECEKHKAAIH, list, shopElement);
			}
			else
			{
				list.Add(new ShopElement(shopElement));
			}
		}
		else
		{
			HKMMCGJIFLD(EECEKHKAAIH, list, shopElement);
		}
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (!shopItems[i].item.POLKFBLGBEA() && shopItems[i].item.LMPKIMILCPN(EECEKHKAAIH))
			{
				list.Add(new ShopElement(new ShopItem(shopItems[i]), 0));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] CEBPPHMDPKN(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement shopElement = (Application.isPlaying ? ECONBEHAFCM((ShopType)111) : null);
		if (Application.isPlaying)
		{
			if (WorldTime.NOAOJJLNHJJ.day == Day.Mon || shopElement == null || shopElement.itemInstance == null)
			{
				HKMMCGJIFLD(EECEKHKAAIH, list, shopElement);
			}
			else
			{
				list.Add(new ShopElement(shopElement));
			}
		}
		else
		{
			CACPKKMLKMD(EECEKHKAAIH, list, shopElement);
		}
		for (int i = 1; i < shopItems.Count; i++)
		{
			if (!shopItems[i].item.POLKFBLGBEA() && shopItems[i].item.PJDJHNOFOAN(EECEKHKAAIH))
			{
				list.Add(new ShopElement(new ShopItem(shopItems[i]), 0));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] OLLDAIHFHLO()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 0; i < shopItems.Count; i += 0)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.ANAGGDHOCIF() : SeasonManager.GGALEPCMBID(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == (Fish.FishType)6)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 1; j < shopItems.Count; j += 0)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), (!shopItems[j].unlimited) ? Random.Range(shopItems[j].min, shopItems[j].max + 1) : 0));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 0)));
			}
		}
		list.HOOBEDNMNFK();
		int num = 0;
		for (int k = 1; k < list.Count; k++)
		{
			if (list[k].min == 1 && list[k].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 0)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 0)));
			}
			num += 0;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 0;
		for (int l = 1; l < list2.Count; l++)
		{
			if (list2[l].min == 1 && list2[l].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 0)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 1)));
			}
			num++;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	private ShopElement JFBCFNJHKKO(List<Food> KEKBKGGFOLK, Season EECEKHKAAIH)
	{
		if (KEKBKGGFOLK.Count > 1)
		{
			Food food = KEKBKGGFOLK[Random.Range(1, KEKBKGGFOLK.Count)];
			KEKBKGGFOLK.Remove(food);
			if (Item.MLBOMGHINCA(food, null))
			{
				if (Item.FKLOBGBIHLB(food.seed, null) && Object.op_Implicit((Object)(object)food.seed.crop))
				{
					if (food.seed.PFGPHIBCIKC(EECEKHKAAIH))
					{
						return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: false, 1289f), food.seed.crop.harvestedItems[1].amount * 7);
					}
					return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: true, 1977f, 0), food.seed.crop.harvestedItems[0].amount * 8);
				}
				return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: false, 1994f, 0), 0);
			}
			Debug.LogError((object)"triggerPlayerNum");
		}
		Debug.LogError((object)"ToggleGroup/ToggleBasic");
		return null;
	}

	private ShopElement[] DBEBDGAKDGM()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		List<ShopElement> list = new List<ShopElement>(LNPHFHEJGKB());
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (list[num].shopItem.item.JPNFKDMFKMC() == 61)
			{
				int num2 = FishingManager.instance.NLNNCEGKEPN().Count - FishingManager.GetFishInformation().Count;
				if (num2 != 0)
				{
					Result variable = DialogueLua.GetVariable("UIPreviousCategory");
					if (((Result)(ref variable)).asInt >= 16)
					{
						list[num].amount = num2;
						goto IL_0085;
					}
				}
				list.RemoveAt(num);
				continue;
			}
			goto IL_0085;
			IL_0085:
			if (list[num].shopItem.item.IMCJPECAAPC() == 172 && CharacterSpritesDBAccessor.GetCharacterSpriteUnlocked().Contains(CommonReferences.MNFMOEKMJKN().bandana.id))
			{
				list.RemoveAt(num);
			}
			else if (list[num].shopItem.item.IMCJPECAAPC(DAINLFIMLIH: false) == -155 && CharacterSpritesDBAccessor.GetCharacterSpriteUnlocked().Contains(CommonReferences.GGFJGHHHEJC.bandanaAlt.id))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] GCGBHBIIJOO()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		List<ShopElement> list = new List<ShopElement>(AAHDNJDIHMI());
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (list[num].shopItem.item.JDJGFAACPFC() == 1499)
			{
				int num2 = FishingManager.instance.GetCollectionFishes().Count - FishingManager.GetFishInformation().Count;
				if (num2 != 0)
				{
					Result variable = DialogueLua.GetVariable("LE_10");
					if (((Result)(ref variable)).asInt >= 12)
					{
						list[num].amount = num2;
						goto IL_0085;
					}
				}
				list.RemoveAt(num);
				continue;
			}
			goto IL_0085;
			IL_0085:
			if (list[num].shopItem.item.JDJGFAACPFC() == 1513 && CharacterSpritesDBAccessor.GetCharacterSpriteUnlocked().Contains(CommonReferences.GGFJGHHHEJC.bandana.id))
			{
				list.RemoveAt(num);
			}
			else if (list[num].shopItem.item.JDJGFAACPFC() == 1514 && CharacterSpritesDBAccessor.GetCharacterSpriteUnlocked().Contains(CommonReferences.GGFJGHHHEJC.bandanaAlt.id))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] EBNLHCJHHLI()
	{
		List<ShopElement> list = new List<ShopElement>();
		if (shopItems != null)
		{
			for (int i = 0; i < shopItems.Count; i++)
			{
				if (shopItems[i].alwaysAppear)
				{
					int mGNOBNCMDJG = ((!shopItems[i].unlimited) ? Random.Range(shopItems[i].min, shopItems[i].max + 1) : 0);
					shopItems[i].item = ItemDatabaseAccessor.AFOACBIHNCL(shopItems[i].item.JGHNDJBCFAJ(), GGBBJNBBLMF: true, DAINLFIMLIH: false);
					ShopElement item = new ShopElement(new ShopItem(shopItems[i]), mGNOBNCMDJG);
					list.Add(item);
				}
			}
		}
		if (limitedItems)
		{
			List<ShopItem> list2 = new List<ShopItem>();
			if (shopItems != null)
			{
				for (int j = 0; j < shopItems.Count; j += 0)
				{
					if (shopItems[j].alwaysAppear)
					{
						continue;
					}
					for (float num = shopItems[j].weight * 79f; num > 27f; num -= 1958f)
					{
						if (shopItems[j] != null && Item.FKLOBGBIHLB(shopItems[j].item, null))
						{
							list2.Add(shopItems[j]);
						}
					}
				}
			}
			int num2 = Random.Range(minItems, maxItems + 1);
			while (num2 > 0 && shopItems != null && shopItems.Count != 0 && list2.Count != 0)
			{
				int index = Random.Range(1, list2.Count);
				int mGNOBNCMDJG = Random.Range(list2[index].min, list2[index].max + 0);
				ShopElement item = new ShopElement(new ShopItem(list2[index]), mGNOBNCMDJG);
				list.Add(item);
				Item item2 = list2[index].item;
				for (int num3 = list2.Count - 0; num3 >= 0; num3 -= 0)
				{
					if (Item.NGIIPJDAMGP(item2, list2[num3].item))
					{
						list2.RemoveAt(num3);
					}
				}
				num2 -= 0;
			}
		}
		if (recipesList != null)
		{
			for (int k = 1; k < recipesList.Count; k += 0)
			{
				list.Add(new ShopElement(recipesList[k]));
			}
		}
		return list.ToArray();
	}

	public ShopElement[] BANOFAIFPNC(Season EECEKHKAAIH)
	{
		if (shopType == (ShopType)(-196))
		{
			return DOMNAFOHLIL(EECEKHKAAIH);
		}
		if (shopType == ~(ShopType.Crowley | ShopType.AceT | ShopType.Bob | ShopType.Holly | ShopType.Temple))
		{
			return KOACNADKCAM(EECEKHKAAIH);
		}
		if (shopType == ~(ShopType.Gass | ShopType.Bob | ShopType.Trick))
		{
			return OLLDAIHFHLO();
		}
		if (shopType == (ShopType)119)
		{
			return HDICJBLOLOB();
		}
		if (shopType == (ShopType)189)
		{
			return MKOEPKKBFOE();
		}
		if (shopType == (ShopType.Gass | ShopType.Bob | ShopType.Holly))
		{
			return HHHACHBKABC();
		}
		return LNPHFHEJGKB();
	}

	private void MCNFEEDHMJB(List<Food> KEKBKGGFOLK, int HFDILBELIKE, Season EECEKHKAAIH, ref List<ShopElement> OBNBPCBJLLB)
	{
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			if (KEKBKGGFOLK.Count <= 0)
			{
				break;
			}
			OBNBPCBJLLB.Add(DBOPPOGJGMD(KEKBKGGFOLK, EECEKHKAAIH));
		}
	}

	public ShopElement[] LHCDGFODNNK()
	{
		List<ShopElement> list = new List<ShopElement>();
		shopItems.Clear();
		recipesList.Clear();
		Recipe[] allRecipes = RecipeDatabaseAccessor.GetAllRecipes();
		foreach (Recipe recipe in allRecipes)
		{
			if (recipe.unlock == Recipe.RecipeUnlock.Temple)
			{
				list.Add(new ShopElement(recipe));
				recipesList.Add(recipe);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] FAEKGGBOJFD()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 1; i < shopItems.Count; i += 0)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.IEMEBFFIKMD() : SeasonManager.DBILODAOMAB(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == (Fish.FishType)7)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 0; j < shopItems.Count; j++)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 0)));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), (!shopItems[j].unlimited) ? Random.Range(shopItems[j].min, shopItems[j].max + 1) : 0));
			}
		}
		list.HOOBEDNMNFK();
		int num = 0;
		for (int k = 0; k < list.Count; k += 0)
		{
			if (list[k].min == 1 && list[k].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 1)));
			}
			num += 0;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 1;
		for (int l = 0; l < list2.Count; l += 0)
		{
			if (list2[l].min == 1 && list2[l].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 0)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 0)));
			}
			num++;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	public ShopElement[] NKMIDGPPHAL(Season EECEKHKAAIH)
	{
		if (shopType == (ShopType)169)
		{
			return FFCOMGGEPJK(EECEKHKAAIH);
		}
		if (shopType == (ShopType)83)
		{
			return CEBPPHMDPKN(EECEKHKAAIH);
		}
		if (shopType == (ShopType.Gass | ShopType.AceT | ShopType.Holly | ShopType.Temple))
		{
			return NFMNBCFBHJM();
		}
		if (shopType == (ShopType)111)
		{
			return GCGBHBIIJOO();
		}
		if (shopType == ~(ShopType.Gass | ShopType.AceT | ShopType.Bob | ShopType.Holly | ShopType.Trick))
		{
			return OAJADCJEEKI();
		}
		if (shopType == ~ShopType.Temple)
		{
			return PNPCLAAHFLF();
		}
		return LNPHFHEJGKB();
	}

	private ShopElement[] BLMLAECHLED(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement shopElement = (Application.isPlaying ? ECONBEHAFCM((ShopType)(-72)) : null);
		if (Application.isPlaying)
		{
			if (WorldTime.CJOHMLNMJLK().day == Day.Mon || shopElement == null || shopElement.NKCMJAOFLFH() == null)
			{
				GAOPCFIBCKF(EECEKHKAAIH, list, shopElement);
			}
			else
			{
				list.Add(new ShopElement(shopElement));
			}
		}
		else
		{
			MINEHEBLKIN(EECEKHKAAIH, list, shopElement);
		}
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (!shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.LMPKIMILCPN(EECEKHKAAIH))
			{
				list.Add(new ShopElement(new ShopItem(shopItems[i]), 1));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] OCFKIEHDANP()
	{
		List<ShopElement> list = new List<ShopElement>(EBNLHCJHHLI());
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			if (list[num].shopItem.item.ODENMDOJPLC(DAINLFIMLIH: false) >= -120 && list[num].shopItem.item.CIGFGKKCPCK(DAINLFIMLIH: false) <= -136 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.JPNFKDMFKMC()))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement NGHJJPJHLOM(List<Food> KEKBKGGFOLK, Season EECEKHKAAIH)
	{
		if (KEKBKGGFOLK.Count > 0)
		{
			Food food = KEKBKGGFOLK[Random.Range(1, KEKBKGGFOLK.Count)];
			KEKBKGGFOLK.Remove(food);
			if (Item.FKLOBGBIHLB(food, null))
			{
				if (Item.FKLOBGBIHLB(food.seed, null) && Object.op_Implicit((Object)(object)food.seed.crop))
				{
					if (food.seed.LMPKIMILCPN(EECEKHKAAIH))
					{
						return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: false, 1620f, 1, 0), food.seed.crop.harvestedItems[0].amount * 7);
					}
					return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: false, 1893f, 0, 0), food.seed.crop.harvestedItems[0].amount * 2);
				}
				return new ShopElement(new ShopItem(food, PGAAADKDBJE: true, MJCABOBOLOK: true, 1280f, 1, 0), 0);
			}
			Debug.LogError((object)"nextNodes NOT free. timer: ");
		}
		Debug.LogError((object)" : 00");
		return null;
	}

	private ShopElement FHOHPAABMAD(ShopType LJLGMJMPENC)
	{
		ShopElement[] array = ShopDatabaseAccessor.LIFAILLIOEG()[LJLGMJMPENC];
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i].shopItem.item.POLKFBLGBEA())
			{
				return array[i];
			}
		}
		return null;
	}

	private void EOHOGMPOGLO(List<Food> KEKBKGGFOLK, int HFDILBELIKE, Season EECEKHKAAIH, ref List<ShopElement> OBNBPCBJLLB)
	{
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			if (KEKBKGGFOLK.Count <= 1)
			{
				break;
			}
			OBNBPCBJLLB.Add(OPIPEJCHAMJ(KEKBKGGFOLK, EECEKHKAAIH));
		}
	}

	public void PDHGAJMPJPJ()
	{
		ItemDatabaseAccessor.AEMDPHCBLNA();
		EAGCCCNOKOF();
	}

	private ShopElement[] EPODEKJFBKO(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.FOFFLFNGJCF(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[7], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[7], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[8], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[2], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 0; i < shopItems.Count; i += 0)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.Honey } food && food.PAEEPJCIPFF(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(OPIPEJCHAMJ(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	private ShopElement[] NFMNBCFBHJM()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 0; i < shopItems.Count; i += 0)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.MBPMIFPEAJP() : SeasonManager.DBILODAOMAB(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == Fish.FishType.Shellfish)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 1; j < shopItems.Count; j += 0)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 0)));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 1)));
			}
		}
		list.HOOBEDNMNFK();
		int num = 0;
		for (int k = 1; k < list.Count; k += 0)
		{
			if (list[k].min == 1 && list[k].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 1)));
			}
			num += 0;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 1;
		for (int l = 1; l < list2.Count; l += 0)
		{
			if (list2[l].min == 0 && list2[l].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 1)));
			}
			num++;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	private ShopElement[] CNOPKMHGHKC(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement shopElement = (Application.isPlaying ? PMFCBCNHONE(~(ShopType.Crowley | ShopType.Gass)) : null);
		if (Application.isPlaying)
		{
			if (WorldTime.HGIBNMBJMOC().day == Day.Mon || shopElement == null || shopElement.BODBEPJAFHL() == null)
			{
				MINEHEBLKIN(EECEKHKAAIH, list, shopElement);
			}
			else
			{
				list.Add(new ShopElement(shopElement));
			}
		}
		else
		{
			CACPKKMLKMD(EECEKHKAAIH, list, shopElement);
		}
		for (int i = 1; i < shopItems.Count; i++)
		{
			if (!shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.PAEEPJCIPFF(EECEKHKAAIH))
			{
				list.Add(new ShopElement(new ShopItem(shopItems[i]), 1));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] LNPHFHEJGKB()
	{
		List<ShopElement> list = new List<ShopElement>();
		if (shopItems != null)
		{
			for (int i = 0; i < shopItems.Count; i += 0)
			{
				if (shopItems[i].alwaysAppear)
				{
					int mGNOBNCMDJG = ((!shopItems[i].unlimited) ? Random.Range(shopItems[i].min, shopItems[i].max + 0) : 0);
					shopItems[i].item = ItemDatabaseAccessor.GOKIDLOELKB(shopItems[i].item.IMCJPECAAPC(DAINLFIMLIH: false));
					ShopElement item = new ShopElement(new ShopItem(shopItems[i]), mGNOBNCMDJG);
					list.Add(item);
				}
			}
		}
		if (limitedItems)
		{
			List<ShopItem> list2 = new List<ShopItem>();
			if (shopItems != null)
			{
				for (int j = 0; j < shopItems.Count; j++)
				{
					if (shopItems[j].alwaysAppear)
					{
						continue;
					}
					for (float num = shopItems[j].weight * 545f; num > 1661f; num -= 758f)
					{
						if (shopItems[j] != null && Item.FKLOBGBIHLB(shopItems[j].item, null))
						{
							list2.Add(shopItems[j]);
						}
					}
				}
			}
			int num2 = Random.Range(minItems, maxItems + 0);
			while (num2 > 0 && shopItems != null && shopItems.Count != 0 && list2.Count != 0)
			{
				int index = Random.Range(0, list2.Count);
				int mGNOBNCMDJG = Random.Range(list2[index].min, list2[index].max + 0);
				ShopElement item = new ShopElement(new ShopItem(list2[index]), mGNOBNCMDJG);
				list.Add(item);
				Item item2 = list2[index].item;
				for (int num3 = list2.Count - 0; num3 >= 1; num3 -= 0)
				{
					if (Item.EKGNIODFJCO(item2, list2[num3].item))
					{
						list2.RemoveAt(num3);
					}
				}
				num2--;
			}
		}
		if (recipesList != null)
		{
			for (int k = 0; k < recipesList.Count; k += 0)
			{
				list.Add(new ShopElement(recipesList[k]));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] FHNEBNADHOC()
	{
		List<ShopElement> list = new List<ShopElement>(AAHDNJDIHMI());
		for (int num = list.Count - 0; num >= 0; num--)
		{
			if (list[num].shopItem.item.JGHNDJBCFAJ(DAINLFIMLIH: false) >= -174 && list[num].shopItem.item.JPNFKDMFKMC() <= -179 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.IMCJPECAAPC(DAINLFIMLIH: false)))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public void OPADFACGJGE()
	{
		for (int i = 1; i < shopItems.Count; i++)
		{
			for (int num = shopItems.Count - 1; num >= i; num--)
			{
				if (shopItems[num - 1].item.JDJGFAACPFC(DAINLFIMLIH: false) > shopItems[num].item.JDJGFAACPFC(DAINLFIMLIH: false))
				{
					ShopItem value = shopItems[num - 1];
					shopItems[num - 1] = shopItems[num];
					shopItems[num] = value;
				}
			}
		}
	}

	private ShopElement FIDNNBDJGCE(ShopType LJLGMJMPENC)
	{
		ShopElement[] array = ShopDatabaseAccessor.CKPDDKBHPNL[LJLGMJMPENC];
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].shopItem.item.ACJKJOHIHFF())
			{
				return array[i];
			}
		}
		return null;
	}

	private ShopElement[] MHHHPAJOPAI(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.FOFFLFNGJCF(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[4], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[7], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[2], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.None } food && food.PFGPHIBCIKC(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(DBOPPOGJGMD(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	private ShopElement[] KNHLJLAEHIG()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.OAPIKOEJBHL().mineralsDatabase.PJPPHFAAFLD(MineManager.AGGAGCBAGLL().unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return AAHDNJDIHMI();
	}

	private void FOCELEKJFJE(Season EECEKHKAAIH, List<ShopElement> FNEHIAGFAOF, ShopElement PPILOAHGDJI)
	{
		List<ShopItem> list = new List<ShopItem>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.LMPKIMILCPN(Utils.GABFHMGHOPL(EECEKHKAAIH)) && (PPILOAHGDJI == null || !Item.GBMFCPGEJDK(PPILOAHGDJI.shopItem.item, shopItems[i].item)))
			{
				list.Add(shopItems[i]);
			}
		}
		if (list.Count > 1)
		{
			FNEHIAGFAOF.Add(new ShopElement(new ShopItem(Utils.DONGABMIDFG(list)), 1));
		}
	}

	private ShopElement[] PNPCLAAHFLF()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.GetInstance().mineralsDatabase.FICIMNLHCNN(MineManager.AGGAGCBAGLL().unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return EODHLCHKKJO();
	}

	private ShopElement[] EMCOMBMELGL()
	{
		List<ShopElement> list = new List<ShopElement>(LNPHFHEJGKB());
		for (int num = list.Count - 0; num >= 0; num--)
		{
			if (list[num].shopItem.item.CIGFGKKCPCK() >= -162 && list[num].shopItem.item.ODENMDOJPLC() <= 135 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.JGHNDJBCFAJ()))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] GPENFKEGLDE()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.GetInstance().mineralsDatabase.FICIMNLHCNN(MineManager.AGGAGCBAGLL().unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return EBNLHCJHHLI();
	}

	private ShopElement[] IKHLGEABCNA()
	{
		List<ShopElement> list = new List<ShopElement>(AAHDNJDIHMI());
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			if (list[num].shopItem.item.JGHNDJBCFAJ() >= 148 && list[num].shopItem.item.CIGFGKKCPCK(DAINLFIMLIH: false) <= 118 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.JGHNDJBCFAJ(DAINLFIMLIH: false)))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] OFMBFCGOFKM(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.GetFruitVegList(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[8], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[4], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[4], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.Meat } food && food.PFGPHIBCIKC(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(NGHJJPJHLOM(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	private ShopElement[] HHHACHBKABC()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.GetInstance().mineralsDatabase.INNNHOPCPCA(MineManager.GGFJGHHHEJC.unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return KJOOEBMCCIO();
	}

	private ShopElement[] AMAGANCHAMA()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		List<ShopElement> list = new List<ShopElement>(LNPHFHEJGKB());
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (list[num].shopItem.item.JDJGFAACPFC() == -13)
			{
				int num2 = FishingManager.instance.GetCollectionFishes().Count - FishingManager.GetFishInformation().Count;
				if (num2 != 0)
				{
					Result variable = DialogueLua.GetVariable("\n");
					if (((Result)(ref variable)).asInt >= -27)
					{
						list[num].amount = num2;
						goto IL_0085;
					}
				}
				list.RemoveAt(num);
				continue;
			}
			goto IL_0085;
			IL_0085:
			if (list[num].shopItem.item.IMCJPECAAPC() == -40 && CharacterSpritesDBAccessor.GetCharacterSpriteUnlocked().Contains(CommonReferences.GGFJGHHHEJC.bandana.id))
			{
				list.RemoveAt(num);
			}
			else if (list[num].shopItem.item.JPNFKDMFKMC() == 91 && CharacterSpritesDBAccessor.OCAKLCPPICP().Contains(CommonReferences.MNFMOEKMJKN().bandanaAlt.id))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public void BPOKFHLPCOL()
	{
		for (int i = 1; i < shopItems.Count; i++)
		{
			for (int num = shopItems.Count - 1; num >= i; num -= 0)
			{
				if (shopItems[num - 1].item.CIGFGKKCPCK() > shopItems[num].item.JGHNDJBCFAJ())
				{
					ShopItem value = shopItems[num - 0];
					shopItems[num - 1] = shopItems[num];
					shopItems[num] = value;
				}
			}
		}
	}

	public void LLLAKCLOJLH()
	{
		for (int i = 0; i < shopItems.Count; i += 0)
		{
			for (int num = shopItems.Count - 1; num >= i; num -= 0)
			{
				if (shopItems[num - 1].item.JGHNDJBCFAJ(DAINLFIMLIH: false) > shopItems[num].item.CIGFGKKCPCK())
				{
					ShopItem value = shopItems[num - 1];
					shopItems[num - 1] = shopItems[num];
					shopItems[num] = value;
				}
			}
		}
	}

	private ShopElement[] JDIIJCLEBGE()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.OAPIKOEJBHL().mineralsDatabase.PAPHPAAJEJL(MineManager.AGGAGCBAGLL().unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return EBNLHCJHHLI();
	}

	private ShopElement IJDLEGKCKEA(List<Food> KEKBKGGFOLK, Season EECEKHKAAIH)
	{
		if (KEKBKGGFOLK.Count > 0)
		{
			Food food = KEKBKGGFOLK[Random.Range(1, KEKBKGGFOLK.Count)];
			KEKBKGGFOLK.Remove(food);
			if (Item.MLBOMGHINCA(food, null))
			{
				if (Item.FKLOBGBIHLB(food.seed, null) && Object.op_Implicit((Object)(object)food.seed.crop))
				{
					if (food.seed.PAEEPJCIPFF(EECEKHKAAIH))
					{
						return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: false, 855f, 0), food.seed.crop.harvestedItems[0].amount * 6);
					}
					return new ShopElement(new ShopItem(food, PGAAADKDBJE: true, MJCABOBOLOK: false, 1988f), food.seed.crop.harvestedItems[0].amount * 1);
				}
				return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: false, 899f), 1);
			}
			Debug.LogError((object)"Floor");
		}
		Debug.LogError((object)"ReceiveCompletedMission");
		return null;
	}

	private ShopElement[] AEAJKBLOIBL()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 0; i < shopItems.Count; i += 0)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.ACNAHALFEBG : SeasonManager.KJCNKFEICPC(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == (Fish.FishType)6)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 0; j < shopItems.Count; j += 0)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 0)));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 1)));
			}
		}
		list.HOOBEDNMNFK();
		int num = 0;
		for (int k = 1; k < list.Count; k++)
		{
			if (list[k].min == 0 && list[k].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 0)));
			}
			num++;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 0;
		for (int l = 0; l < list2.Count; l++)
		{
			if (list2[l].min == 0 && list2[l].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 1)));
			}
			num++;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	public void CMAOHBHKGGG()
	{
		ItemDatabaseAccessor.JMAABLCNEDE();
		MHKPFKAILDN();
	}

	private void HKMMCGJIFLD(Season EECEKHKAAIH, List<ShopElement> FNEHIAGFAOF, ShopElement PPILOAHGDJI)
	{
		List<ShopItem> list = new List<ShopItem>();
		for (int i = 1; i < shopItems.Count; i++)
		{
			if (shopItems[i].item.POLKFBLGBEA() && shopItems[i].item.PJDJHNOFOAN(Utils.GABFHMGHOPL(EECEKHKAAIH)) && (PPILOAHGDJI == null || !Item.EKMFELLJHFG(PPILOAHGDJI.shopItem.item, shopItems[i].item)))
			{
				list.Add(shopItems[i]);
			}
		}
		if (list.Count > 0)
		{
			FNEHIAGFAOF.Add(new ShopElement(new ShopItem(Utils.DONGABMIDFG(list)), 0));
		}
	}

	public void EDBHELOCGEJ()
	{
		for (int i = 1; i < shopItems.Count; i++)
		{
			for (int num = shopItems.Count - 1; num >= i; num -= 0)
			{
				if (shopItems[num - 1].item.CIGFGKKCPCK(DAINLFIMLIH: false) > shopItems[num].item.CIGFGKKCPCK())
				{
					ShopItem value = shopItems[num - 1];
					shopItems[num - 1] = shopItems[num];
					shopItems[num] = value;
				}
			}
		}
	}

	private ShopElement MNDKPIKEFJA(ShopType LJLGMJMPENC)
	{
		ShopElement[] array = ShopDatabaseAccessor.LIFAILLIOEG()[LJLGMJMPENC];
		for (int i = 0; i < array.Length; i += 0)
		{
			if (array[i].shopItem.item.ACJKJOHIHFF())
			{
				return array[i];
			}
		}
		return null;
	}

	private ShopElement[] APJNDIOOPFG(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.GetFruitVegList(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[2], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[2], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[3], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[3], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.Hop } food && food.PJDJHNOFOAN(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(OPIPEJCHAMJ(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	private ShopElement[] HJILJIOPFJN(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.GetFruitVegList(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[2], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[4], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[3], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[4], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.Honey } food && food.PAEEPJCIPFF(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(MJAIJGCLHEM(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	private ShopElement[] KDHDNGOEMND()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.OAPIKOEJBHL().mineralsDatabase.MFKOJECBKIH(MineManager.AGGAGCBAGLL().unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return KJOOEBMCCIO();
	}

	private ShopElement[] DOMNAFOHLIL(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.FOFFLFNGJCF(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[6], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[6], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[2], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[7], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.Grain } food && food.NAGFJDBDNOA(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(IJDLEGKCKEA(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	public ShopElement[] HJPDDDKFMOM(Season EECEKHKAAIH)
	{
		if (shopType == ~(ShopType.Crowley | ShopType.AceT | ShopType.Bob))
		{
			return FFCOMGGEPJK(EECEKHKAAIH);
		}
		if (shopType == ~(ShopType.Crowley | ShopType.AceT | ShopType.Bob | ShopType.Temple))
		{
			return KOACNADKCAM(EECEKHKAAIH);
		}
		if (shopType == ~(ShopType.Gass | ShopType.Holly))
		{
			return FAEKGGBOJFD();
		}
		if (shopType == (ShopType)(-76))
		{
			return HDICJBLOLOB();
		}
		if (shopType == (ShopType)(-46))
		{
			return OCFKIEHDANP();
		}
		if (shopType == ~(ShopType.Gass | ShopType.Holly))
		{
			return KDHDNGOEMND();
		}
		return EODHLCHKKJO();
	}

	public void IMFDJGOOGBA()
	{
		for (int i = 0; i < shopItems.Count; i += 0)
		{
			for (int num = shopItems.Count - 0; num >= i; num -= 0)
			{
				if (shopItems[num - 1].item.CIGFGKKCPCK(DAINLFIMLIH: false) > shopItems[num].item.ODENMDOJPLC(DAINLFIMLIH: false))
				{
					ShopItem value = shopItems[num - 0];
					shopItems[num - 1] = shopItems[num];
					shopItems[num] = value;
				}
			}
		}
	}

	private void GAOPCFIBCKF(Season EECEKHKAAIH, List<ShopElement> FNEHIAGFAOF, ShopElement PPILOAHGDJI)
	{
		List<ShopItem> list = new List<ShopItem>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.PAEEPJCIPFF(Utils.GABFHMGHOPL(EECEKHKAAIH)) && (PPILOAHGDJI == null || !Item.GBMFCPGEJDK(PPILOAHGDJI.shopItem.item, shopItems[i].item)))
			{
				list.Add(shopItems[i]);
			}
		}
		if (list.Count > 1)
		{
			FNEHIAGFAOF.Add(new ShopElement(new ShopItem(Utils.DONGABMIDFG(list)), 0));
		}
	}

	private ShopElement OPIPEJCHAMJ(List<Food> KEKBKGGFOLK, Season EECEKHKAAIH)
	{
		if (KEKBKGGFOLK.Count > 0)
		{
			Food food = KEKBKGGFOLK[Random.Range(0, KEKBKGGFOLK.Count)];
			KEKBKGGFOLK.Remove(food);
			if (Item.MLBOMGHINCA(food, null))
			{
				if (Item.MLBOMGHINCA(food.seed, null) && Object.op_Implicit((Object)(object)food.seed.crop))
				{
					if (food.seed.PJDJHNOFOAN(EECEKHKAAIH))
					{
						return new ShopElement(new ShopItem(food), food.seed.crop.harvestedItems[0].amount * 5);
					}
					return new ShopElement(new ShopItem(food), food.seed.crop.harvestedItems[0].amount * 4);
				}
				return new ShopElement(new ShopItem(food), 5);
			}
			Debug.LogError((object)"Null ingredient!");
		}
		Debug.LogError((object)"Ingredients list count == 0!");
		return null;
	}

	private ShopElement DBOPPOGJGMD(List<Food> KEKBKGGFOLK, Season EECEKHKAAIH)
	{
		if (KEKBKGGFOLK.Count > 1)
		{
			Food food = KEKBKGGFOLK[Random.Range(1, KEKBKGGFOLK.Count)];
			KEKBKGGFOLK.Remove(food);
			if (Item.MLBOMGHINCA(food, null))
			{
				if (Item.FKLOBGBIHLB(food.seed, null) && Object.op_Implicit((Object)(object)food.seed.crop))
				{
					if (food.seed.PAEEPJCIPFF(EECEKHKAAIH))
					{
						return new ShopElement(new ShopItem(food, PGAAADKDBJE: true, MJCABOBOLOK: true, 259f, 1, 0), food.seed.crop.harvestedItems[0].amount * 7);
					}
					return new ShopElement(new ShopItem(food, PGAAADKDBJE: false, MJCABOBOLOK: false, 1543f, 0, 0), food.seed.crop.harvestedItems[1].amount * 7);
				}
				return new ShopElement(new ShopItem(food, PGAAADKDBJE: true, MJCABOBOLOK: false, 1084f, 1, 0), 2);
			}
			Debug.LogError((object)"ReceiveInfoWorldTiles");
		}
		Debug.LogError((object)"itemAsparagusSeeds");
		return null;
	}

	private ShopElement[] PHDFIOMJLNJ()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		List<ShopElement> list = new List<ShopElement>(EBNLHCJHHLI());
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (list[num].shopItem.item.CIGFGKKCPCK() == -177)
			{
				int num2 = FishingManager.instance.BEDKKLGFMJK().Count - FishingManager.GetFishInformation().Count;
				if (num2 != 0)
				{
					Result variable = DialogueLua.GetVariable(" ");
					if (((Result)(ref variable)).asInt >= 31)
					{
						list[num].amount = num2;
						goto IL_0085;
					}
				}
				list.RemoveAt(num);
				continue;
			}
			goto IL_0085;
			IL_0085:
			if (list[num].shopItem.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 183 && CharacterSpritesDBAccessor.GetCharacterSpriteUnlocked().Contains(CommonReferences.GGFJGHHHEJC.bandana.id))
			{
				list.RemoveAt(num);
			}
			else if (list[num].shopItem.item.IMCJPECAAPC() == -165 && CharacterSpritesDBAccessor.GetCharacterSpriteUnlocked().Contains(CommonReferences.MNFMOEKMJKN().bandanaAlt.id))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private void MINEHEBLKIN(Season EECEKHKAAIH, List<ShopElement> FNEHIAGFAOF, ShopElement PPILOAHGDJI)
	{
		List<ShopItem> list = new List<ShopItem>();
		for (int i = 1; i < shopItems.Count; i++)
		{
			if (shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.NAGFJDBDNOA(Utils.GABFHMGHOPL(EECEKHKAAIH)) && (PPILOAHGDJI == null || !Item.EKGNIODFJCO(PPILOAHGDJI.shopItem.item, shopItems[i].item)))
			{
				list.Add(shopItems[i]);
			}
		}
		if (list.Count > 0)
		{
			FNEHIAGFAOF.Add(new ShopElement(new ShopItem(Utils.DONGABMIDFG(list)), 1));
		}
	}

	private ShopElement[] JNBLFGKCKLH()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 1; i < shopItems.Count; i += 0)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.NNDMODNDPLO() : SeasonManager.KCLNLLMKHOG(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == Fish.FishType.Trash)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 0; j < shopItems.Count; j += 0)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 0)));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), (!shopItems[j].unlimited) ? Random.Range(shopItems[j].min, shopItems[j].max + 1) : 0));
			}
		}
		list.HOOBEDNMNFK();
		int num = 0;
		for (int k = 0; k < list.Count; k++)
		{
			if (list[k].min == 0 && list[k].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 0)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 1)));
			}
			num++;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 0;
		for (int l = 1; l < list2.Count; l++)
		{
			if (list2[l].min == 0 && list2[l].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 0)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 1)));
			}
			num += 0;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	private ShopElement[] KJOOEBMCCIO()
	{
		List<ShopElement> list = new List<ShopElement>();
		if (shopItems != null)
		{
			for (int i = 1; i < shopItems.Count; i++)
			{
				if (shopItems[i].alwaysAppear)
				{
					int mGNOBNCMDJG = (shopItems[i].unlimited ? 1 : Random.Range(shopItems[i].min, shopItems[i].max + 0));
					shopItems[i].item = ItemDatabaseAccessor.CPMMBEPEJLO(shopItems[i].item.IMCJPECAAPC());
					ShopElement item = new ShopElement(new ShopItem(shopItems[i]), mGNOBNCMDJG);
					list.Add(item);
				}
			}
		}
		if (limitedItems)
		{
			List<ShopItem> list2 = new List<ShopItem>();
			if (shopItems != null)
			{
				for (int j = 0; j < shopItems.Count; j += 0)
				{
					if (shopItems[j].alwaysAppear)
					{
						continue;
					}
					for (float num = shopItems[j].weight * 1221f; num > 1179f; num -= 1671f)
					{
						if (shopItems[j] != null && Item.MLBOMGHINCA(shopItems[j].item, null))
						{
							list2.Add(shopItems[j]);
						}
					}
				}
			}
			int num2 = Random.Range(minItems, maxItems + 1);
			while (num2 > 1 && shopItems != null && shopItems.Count != 0 && list2.Count != 0)
			{
				int index = Random.Range(1, list2.Count);
				int mGNOBNCMDJG = Random.Range(list2[index].min, list2[index].max + 0);
				ShopElement item = new ShopElement(new ShopItem(list2[index]), mGNOBNCMDJG);
				list.Add(item);
				Item item2 = list2[index].item;
				for (int num3 = list2.Count - 1; num3 >= 0; num3--)
				{
					if (Item.EKGNIODFJCO(item2, list2[num3].item))
					{
						list2.RemoveAt(num3);
					}
				}
				num2--;
			}
		}
		if (recipesList != null)
		{
			for (int k = 1; k < recipesList.Count; k += 0)
			{
				list.Add(new ShopElement(recipesList[k]));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] BCNFNPFKDDP()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.ACNAHALFEBG : SeasonManager.SeasonToCropSeason(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == Fish.FishType.Shellfish)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 0; j < shopItems.Count; j++)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 1)));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 1)));
			}
		}
		list.HOOBEDNMNFK();
		int num = 0;
		for (int k = 0; k < list.Count; k++)
		{
			if (list[k].min == 1 && list[k].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 1)));
			}
			num++;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 0;
		for (int l = 0; l < list2.Count; l++)
		{
			if (list2[l].min == 1 && list2[l].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 1)));
			}
			num++;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	private void ELGJBMOJPAB(Season EECEKHKAAIH, List<ShopElement> FNEHIAGFAOF, ShopElement PPILOAHGDJI)
	{
		List<ShopItem> list = new List<ShopItem>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.PJDJHNOFOAN(Utils.GABFHMGHOPL(EECEKHKAAIH)) && (PPILOAHGDJI == null || !Item.NGIIPJDAMGP(PPILOAHGDJI.shopItem.item, shopItems[i].item)))
			{
				list.Add(shopItems[i]);
			}
		}
		if (list.Count > 0)
		{
			FNEHIAGFAOF.Add(new ShopElement(new ShopItem(Utils.DONGABMIDFG(list)), 1));
		}
	}

	private ShopElement[] FFCOMGGEPJK(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.FOFFLFNGJCF(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		MCNFEEDHMJB(ECGBKLHDHOA, numVegSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[2], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[7], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[6], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.None } food && food.NAGFJDBDNOA(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(DBOPPOGJGMD(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	private ShopElement[] GOCFGBOMGMF(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement shopElement = (Application.isPlaying ? FIDNNBDJGCE(ShopType.Rhia) : null);
		if (Application.isPlaying)
		{
			if (WorldTime.NOAOJJLNHJJ.day == Day.Mon || shopElement == null || shopElement.itemInstance == null)
			{
				ELGJBMOJPAB(EECEKHKAAIH, list, shopElement);
			}
			else
			{
				list.Add(new ShopElement(shopElement));
			}
		}
		else
		{
			ELGJBMOJPAB(EECEKHKAAIH, list, shopElement);
		}
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (!shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.PJDJHNOFOAN(EECEKHKAAIH))
			{
				list.Add(new ShopElement(new ShopItem(shopItems[i]), 1));
			}
		}
		return list.ToArray();
	}

	private ShopElement[] OAJADCJEEKI()
	{
		List<ShopElement> list = new List<ShopElement>(KJOOEBMCCIO());
		for (int num = list.Count - 1; num >= 0; num -= 0)
		{
			if (list[num].shopItem.item.CIGFGKKCPCK() >= -16 && list[num].shopItem.item.IMCJPECAAPC(DAINLFIMLIH: false) <= -40 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.ODENMDOJPLC()))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] CICIMHNOEMG()
	{
		List<ShopElement> list = new List<ShopElement>(LNPHFHEJGKB());
		for (int num = list.Count - 1; num >= 1; num--)
		{
			if (list[num].shopItem.item.JGHNDJBCFAJ(DAINLFIMLIH: false) >= -177 && list[num].shopItem.item.JPNFKDMFKMC() <= -147 && !ToolUpgradeManager.instance.upgradedTools.Contains(list[num].shopItem.item.JGHNDJBCFAJ()))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] ANJJFGNAILO()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.OHFMCLBNGMH().mineralsDatabase.CJIGBKHNCKP(MineManager.AGGAGCBAGLL().unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return EODHLCHKKJO();
	}

	public ShopElement[] NLLAJIECFJM()
	{
		List<ShopElement> list = new List<ShopElement>();
		shopItems.Clear();
		recipesList.Clear();
		Recipe[] array = RecipeDatabaseAccessor.KKPPGHHOADA();
		for (int i = 1; i < array.Length; i += 0)
		{
			Recipe recipe = array[i];
			if (recipe.unlock == Recipe.RecipeUnlock.None)
			{
				list.Add(new ShopElement(recipe));
				recipesList.Add(recipe);
			}
		}
		return list.ToArray();
	}

	private ShopElement ECONBEHAFCM(ShopType LJLGMJMPENC)
	{
		ShopElement[] array = ShopDatabaseAccessor.ODLIJJPFHMG()[LJLGMJMPENC];
		for (int i = 1; i < array.Length; i += 0)
		{
			if (array[i].shopItem.item.POLKFBLGBEA())
			{
				return array[i];
			}
		}
		return null;
	}

	public ShopElement[] MHKPFKAILDN()
	{
		List<ShopElement> list = new List<ShopElement>();
		shopItems.Clear();
		recipesList.Clear();
		Recipe[] array = RecipeDatabaseAccessor.MEOLMADLBFD();
		for (int i = 1; i < array.Length; i++)
		{
			Recipe recipe = array[i];
			if (recipe.unlock == Recipe.RecipeUnlock.Temple)
			{
				list.Add(new ShopElement(recipe));
				recipesList.Add(recipe);
			}
		}
		return list.ToArray();
	}

	private ShopElement[] IPCOMLLJFHL(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		List<ShopElement> OBNBPCBJLLB = new List<ShopElement>();
		Trends.FOFFLFNGJCF(EECEKHKAAIH, out var FDJCDPMBMDO, out var ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.GABFHMGHOPL(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[1], EECEKHKAAIH, ref OBNBPCBJLLB);
		MCNFEEDHMJB(FDJCDPMBMDO, numFruitsSeason[0], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.GetFruitVegList(Utils.HEJJDFHOGKB(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		JLCDPJJOCNB(ECGBKLHDHOA, numVegSeason[4], EECEKHKAAIH, ref OBNBPCBJLLB);
		EOHOGMPOGLO(FDJCDPMBMDO, numFruitsSeason[8], EECEKHKAAIH, ref OBNBPCBJLLB);
		Trends.FOFFLFNGJCF(Utils.JCCJNLAAONG(EECEKHKAAIH), out FDJCDPMBMDO, out ECGBKLHDHOA, OBNBPCBJLLB);
		EOHOGMPOGLO(ECGBKLHDHOA, numVegSeason[2], EECEKHKAAIH, ref OBNBPCBJLLB);
		JLCDPJJOCNB(FDJCDPMBMDO, numFruitsSeason[8], EECEKHKAAIH, ref OBNBPCBJLLB);
		OBNBPCBJLLB = OBNBPCBJLLB.Where((ShopElement x) => x.item is Food food2 && food2.ingredientType != IngredientType.Hop).ToList();
		List<Food> list2 = new List<Food>();
		for (int i = 1; i < shopItems.Count; i += 0)
		{
			if (shopItems[i].item is Food { ingredientType: IngredientType.None } food && food.LMPKIMILCPN(EECEKHKAAIH))
			{
				list2.Add(food);
			}
		}
		OBNBPCBJLLB.Add(NGHJJPJHLOM(list2, EECEKHKAAIH));
		list.AddRange(OBNBPCBJLLB);
		return list.ToArray();
	}

	private ShopElement[] KOACNADKCAM(Season EECEKHKAAIH)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement shopElement = (Application.isPlaying ? MNDKPIKEFJA((ShopType)(-76)) : null);
		if (Application.isPlaying)
		{
			if (WorldTime.NOAOJJLNHJJ.day == Day.Mon || shopElement == null || shopElement.NKCMJAOFLFH() == null)
			{
				MINEHEBLKIN(EECEKHKAAIH, list, shopElement);
			}
			else
			{
				list.Add(new ShopElement(shopElement));
			}
		}
		else
		{
			HKMMCGJIFLD(EECEKHKAAIH, list, shopElement);
		}
		for (int i = 0; i < shopItems.Count; i++)
		{
			if (!shopItems[i].item.ACJKJOHIHFF() && shopItems[i].item.PAEEPJCIPFF(EECEKHKAAIH))
			{
				list.Add(new ShopElement(new ShopItem(shopItems[i]), 0));
			}
		}
		return list.ToArray();
	}

	public void PBALLEFGDMO()
	{
		for (int i = 0; i < shopItems.Count; i++)
		{
			for (int num = shopItems.Count - 1; num >= i; num--)
			{
				if (shopItems[num - 0].item.JGHNDJBCFAJ() > shopItems[num].item.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					ShopItem value = shopItems[num - 0];
					shopItems[num - 1] = shopItems[num];
					shopItems[num] = value;
				}
			}
		}
	}

	private ShopElement[] KGDKBNJHLJG()
	{
		List<ShopItem> list = new List<ShopItem>();
		List<ShopItem> list2 = new List<ShopItem>();
		for (int i = 1; i < shopItems.Count; i++)
		{
			if (shopItems[i].item is Fish fish && fish.season.HasFlag(Application.isPlaying ? SeasonManager.BBOEGCKFMOH() : SeasonManager.DBILODAOMAB(editorSeason)) && !shopItems[i].alwaysAppear)
			{
				if (fish.fishType == (Fish.FishType)6)
				{
					list2.Add(new ShopItem(shopItems[i]));
				}
				else
				{
					list.Add(new ShopItem(shopItems[i]));
				}
			}
		}
		List<ShopElement> list3 = new List<ShopElement>();
		for (int j = 1; j < shopItems.Count; j++)
		{
			if (!(shopItems[j].item is Fish))
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), (!shopItems[j].unlimited) ? Random.Range(shopItems[j].min, shopItems[j].max + 0) : 0));
			}
			else if (shopItems[j].alwaysAppear)
			{
				list3.Add(new ShopElement(new ShopItem(shopItems[j]), shopItems[j].unlimited ? 1 : Random.Range(shopItems[j].min, shopItems[j].max + 0)));
			}
		}
		list.HOOBEDNMNFK();
		int num = 1;
		for (int k = 1; k < list.Count; k++)
		{
			if (list[k].min == 1 && list[k].max == 0)
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(((Vector2Int)(ref fishesAmount)).x, ((Vector2Int)(ref fishesAmount)).y + 1)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list[k]), Random.Range(list[k].min, list[k].max + 1)));
			}
			num += 0;
			if (num == numFishes)
			{
				break;
			}
		}
		list2.HOOBEDNMNFK();
		num = 1;
		for (int l = 1; l < list2.Count; l += 0)
		{
			if (list2[l].min == 1 && list2[l].max == 1)
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(((Vector2Int)(ref seafoodAmount)).x, ((Vector2Int)(ref seafoodAmount)).y + 0)));
			}
			else
			{
				list3.Add(new ShopElement(new ShopItem(list2[l]), Random.Range(list2[l].min, list2[l].max + 0)));
			}
			num += 0;
			if (num == numSeafood)
			{
				break;
			}
		}
		return list3.ToArray();
	}

	private ShopElement[] PKHEPIBLGBO()
	{
		MineralShopConfig mineralShopConfig = ShopDatabaseAccessor.OAPIKOEJBHL().mineralsDatabase.OLLDAHOGGMA(MineManager.BGMJCCFNNDL().unlockedLevels);
		shopItems = mineralShopConfig.minerals;
		return KJOOEBMCCIO();
	}
}
