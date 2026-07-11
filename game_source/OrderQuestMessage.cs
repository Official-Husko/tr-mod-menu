using System;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public struct OrderQuestMessage
{
	[JsonProperty("0")]
	public byte index;

	[JsonProperty("1")]
	public string name;

	[JsonProperty("2")]
	public RewardMessage rewardSave;

	[JsonProperty("3")]
	public short requiredAmount;

	[JsonProperty("4")]
	public short itemID;

	[JsonProperty("5")]
	public IngredientType[] ingredientType;

	[JsonProperty("6")]
	public short[] ingredientIDs;

	[JsonProperty("7")]
	public IngredientModifier[] modifiers;

	[JsonProperty("8")]
	public bool addedToCurrent;

	public CraftItemTypeQuest EANOMBFACLD()
	{
		return RandomOrderQuestsManager.JFNOOMJMHCB().FJCJCJNDLFE(NAENGKFCLKG());
	}

	public CraftItemTypeQuest CDNHCHMKFAJ()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(DEILIBAKCOC());
	}

	public CraftItemTypeQuest EGCFADCHAOG()
	{
		return RandomOrderQuestsManager.JFNOOMJMHCB().FJCJCJNDLFE(CEGIBJOGHAK());
	}

	public RandomOrderQuestInfo ODJFODMAOJM()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.CFCGHBCKJHN();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.GOKIDLOELKB(itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)40)
		{
			result.ingredientType = new IngredientType[1];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GNMEPLKINOJ(result.item.LJIFOHFEFCH(OAFPBCPDOKH: true), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo BNLLMEOINIO()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.GDCCDNODOJO();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.AFOACBIHNCL(itemID);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)(-104))
		{
			result.ingredientType = new IngredientType[1];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GenerateDescription(result.item.IABAKHPEOAF(OAFPBCPDOKH: true), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo KJHJAJNDCHP()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.OBLIAKJPNIA();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.AFOACBIHNCL(itemID, GGBBJNBBLMF: true);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)(-88))
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GenerateDescription(result.item.IABAKHPEOAF(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo MMFCIOBIPEL()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.KLDKIDJOJDK();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.AFOACBIHNCL(itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[1] == (IngredientType)53)
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.OOLBOLOJBHF(result.item.LJIFOHFEFCH(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo IHFALELKCOC()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.BCCEDFCMDKA();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.EABMGELAAPG(itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)(-30))
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GNMEPLKINOJ(result.item.KGHFCDELKMN(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo CGPHHLJKLHG()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.NDCNMPKKLCH();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.CPMMBEPEJLO(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[1] == (IngredientType)(-87))
		{
			result.ingredientType = new IngredientType[1];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GenerateDescription(result.item.LJIFOHFEFCH(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest HJMKANPFOPG()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.OLNGDECHDPF(IHFALELKCOC());
	}

	public RandomOrderQuestInfo MILHGJIOOOG()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.CLDMLCMPCON();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.INJBNHPGCIJ(itemID, GGBBJNBBLMF: true);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[1] == (IngredientType)93)
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GNMEPLKINOJ(result.item.LJIFOHFEFCH(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest JMKKEGLAOAP()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.CreateQuest(KJHJAJNDCHP());
	}

	public OrderQuestMessage(CraftItemTypeQuest FJGAOGLLGGH, int MOFKEDGAOEE, bool HCDLPFENIND = false)
	{
		index = (byte)MOFKEDGAOEE;
		name = ((Object)FJGAOGLLGGH).name;
		rewardSave = new RewardMessage(FJGAOGLLGGH.reward);
		requiredAmount = (short)FJGAOGLLGGH.requiredAmount;
		if (FJGAOGLLGGH.possibleItems.Length != 0 && Item.MLBOMGHINCA(FJGAOGLLGGH.possibleItems[0], null))
		{
			itemID = (short)FJGAOGLLGGH.possibleItems[0].JDJGFAACPFC();
		}
		else
		{
			itemID = 0;
		}
		ingredientType = FJGAOGLLGGH.ingredientType;
		if (FJGAOGLLGGH.ingredients != null)
		{
			ingredientIDs = (from i in FJGAOGLLGGH.ingredients
				where i.JDJGFAACPFC() != 0
				select (short)i.JDJGFAACPFC()).ToArray();
		}
		else
		{
			ingredientIDs = new short[0];
		}
		modifiers = FJGAOGLLGGH.modifiers;
		addedToCurrent = HCDLPFENIND;
	}

	public CraftItemTypeQuest JCDMNNIBONB()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.CreateQuest(OOEIHHDECME());
	}

	public RandomOrderQuestInfo FDLIGEAKOCO()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.JJPFOOFKKGF();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.GOKIDLOELKB(itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)(-98))
		{
			result.ingredientType = new IngredientType[1];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GNMEPLKINOJ(result.item.LJIFOHFEFCH(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest NLEMMJGOEIG()
	{
		return RandomOrderQuestsManager.HLMGBEGEAPC().CreateQuest(EHMINNPBJEI());
	}

	public RandomOrderQuestInfo DPMHOPIHKCF()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.GDCCDNODOJO();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.AFOACBIHNCL(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[1] == (IngredientType)(-24))
		{
			result.ingredientType = new IngredientType[1];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.OOLBOLOJBHF(result.item.LJIFOHFEFCH(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest ADAFGAIMKNN()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(FDLIGEAKOCO());
	}

	public CraftItemTypeQuest JBHAJFMBKPN()
	{
		return RandomOrderQuestsManager.HLMGBEGEAPC().CreateQuest(IHFALELKCOC());
	}

	public CraftItemTypeQuest PJNCPFLAFIC()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(HDKOCKMIIBI());
	}

	public RandomOrderQuestInfo OOEIHHDECME()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.PHKNGJCGAKH();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.GetItem(itemID);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == IngredientType.Wort)
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GenerateDescription(result.item.IABAKHPEOAF(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo CEGIBJOGHAK()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.KLDKIDJOJDK();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.CPMMBEPEJLO(itemID, GGBBJNBBLMF: true);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == IngredientType.Berries)
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.OOLBOLOJBHF(result.item.KGHFCDELKMN(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest HPDHBMKLKLM()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(MMFCIOBIPEL());
	}

	public CraftItemTypeQuest PFOAGMMJGMJ()
	{
		return RandomOrderQuestsManager.JFNOOMJMHCB().FJCJCJNDLFE(EHMINNPBJEI());
	}

	public CraftItemTypeQuest JBMEJAKEAMG()
	{
		return RandomOrderQuestsManager.JFNOOMJMHCB().FJCJCJNDLFE(OOEIHHDECME());
	}

	public RandomOrderQuestInfo CNCCPAGCDDO()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.PHKNGJCGAKH();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.INJBNHPGCIJ(itemID);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)(-33))
		{
			result.ingredientType = new IngredientType[1];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.OOLBOLOJBHF(result.item.LJIFOHFEFCH(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo DBAMAFLNKDG()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.IKDGNAEKAPP();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.AFOACBIHNCL(itemID);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[1] == (IngredientType)91)
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GenerateDescription(result.item.IABAKHPEOAF(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo BCBNGAJNGFM()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.OLBLCJKNCDE();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.GOKIDLOELKB(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[1] == IngredientType.Beer)
		{
			result.ingredientType = new IngredientType[1];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.OOLBOLOJBHF(result.item.KGHFCDELKMN(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest EFGFKDMABPA()
	{
		return RandomOrderQuestsManager.HLMGBEGEAPC().OLNGDECHDPF(KJHJAJNDCHP());
	}

	public CraftItemTypeQuest LIPDIOJJDPL()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(DBAMAFLNKDG());
	}

	public CraftItemTypeQuest FAOFIIAAGBE()
	{
		return RandomOrderQuestsManager.HLMGBEGEAPC().OLNGDECHDPF(ODJFODMAOJM());
	}

	public RandomOrderQuestInfo HDKOCKMIIBI()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.IKDGNAEKAPP();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.GOKIDLOELKB(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[1] == (IngredientType)48)
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.OOLBOLOJBHF(result.item.IABAKHPEOAF(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest FGMOEALBHKO()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(NAENGKFCLKG());
	}

	public RandomOrderQuestInfo HIIFGGNGCOF()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.CADJOCDJPEC();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.GOKIDLOELKB(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)(-47))
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GNMEPLKINOJ(result.item.KGHFCDELKMN(OAFPBCPDOKH: true), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest AODOCDIELPK()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(CGPHHLJKLHG());
	}

	public CraftItemTypeQuest BHGOHJCODJG()
	{
		return RandomOrderQuestsManager.HLMGBEGEAPC().FJCJCJNDLFE(OOEIHHDECME());
	}

	public RandomOrderQuestInfo NAENGKFCLKG()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.JJPFOOFKKGF();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.INJBNHPGCIJ(itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)(-35))
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GNMEPLKINOJ(result.item.IABAKHPEOAF(OAFPBCPDOKH: true), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest FPAPEHIPNID()
	{
		return RandomOrderQuestsManager.HLMGBEGEAPC().CreateQuest(KJHJAJNDCHP());
	}

	public RandomOrderQuestInfo HPDFGPNMOCO()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.GDCCDNODOJO();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.KMBGJEKCJFJ(itemID, GGBBJNBBLMF: true);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[1] == (IngredientType)(-112))
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GenerateDescription(result.item.KGHFCDELKMN(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public RandomOrderQuestInfo EHMINNPBJEI()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.DELHMMHJJGC();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.EABMGELAAPG(itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)89)
		{
			result.ingredientType = new IngredientType[1];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GenerateDescription(result.item.KGHFCDELKMN(), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest BEDEGNCMEIO()
	{
		return RandomOrderQuestsManager.JFNOOMJMHCB().OLNGDECHDPF(EHMINNPBJEI());
	}

	public CraftItemTypeQuest BHEAJPDEHCK()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(HDKOCKMIIBI());
	}

	public CraftItemTypeQuest GNJCPFPABHG()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.FJCJCJNDLFE(CEGIBJOGHAK());
	}

	public CraftItemTypeQuest HICANMGGNJG()
	{
		return RandomOrderQuestsManager.JFNOOMJMHCB().FJCJCJNDLFE(OOEIHHDECME());
	}

	public RandomOrderQuestInfo DEILIBAKCOC()
	{
		RandomOrderQuestInfo result = default(RandomOrderQuestInfo);
		result.name = name;
		result.reward = rewardSave.CADJOCDJPEC();
		if (itemID != 0)
		{
			result.item = ItemDatabaseAccessor.CPMMBEPEJLO(itemID);
		}
		result.requiredAmount = requiredAmount;
		if (ingredientType != null && ingredientType.Length != 0 && ingredientType[0] == (IngredientType)124)
		{
			result.ingredientType = new IngredientType[0];
		}
		else
		{
			result.ingredientType = ingredientType;
		}
		if (ingredientIDs != null)
		{
			result.ingredients = (from id in ingredientIDs
				where id != 0
				select ItemDatabaseAccessor.GetItem(id)).OfType<Food>().ToArray();
		}
		result.modifiers = modifiers;
		result.description = RandomOrderQuestsManager.GenerateDescription(result.item.LJIFOHFEFCH(OAFPBCPDOKH: true), result.ingredientType, result.ingredients, result.modifiers, result.item.recipe);
		return result;
	}

	public CraftItemTypeQuest DEBLMGPNLKH()
	{
		return RandomOrderQuestsManager.GGFJGHHHEJC.OLNGDECHDPF(DEILIBAKCOC());
	}

	public CraftItemTypeQuest EKOKLCDJKKF()
	{
		return RandomOrderQuestsManager.JFNOOMJMHCB().OLNGDECHDPF(KJHJAJNDCHP());
	}
}
