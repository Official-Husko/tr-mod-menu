using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Item")]
public class Item : ScriptableObject
{
	[SerializeField]
	protected int id;

	public bool translationByID;

	public string nameId;

	[SerializeField]
	protected string description;

	[Space(10f)]
	[SerializeField]
	private GameObject prefab;

	public GameObject rotatedPrefab;

	public GameObject winterPrefab;

	public GameObject winterRotatedPrefab;

	public bool excludedFromTrends;

	public bool excludedFromShops;

	public int comfort;

	public bool hasToBeAgedMeal;

	public bool appearsInOrders = true;

	public bool canPickUp = true;

	public bool savedAsAPlaceable = true;

	[Space(10f)]
	public Sprite icon;

	public Sprite spriteNotAged;

	public Sprite spriteAged;

	public Sprite sprite;

	[Space(10f)]
	public Sprite[] alternatives;

	[Space(10f)]
	public bool canBeStacked = true;

	public int amountStack = 99;

	[Space(10f)]
	public Quest requiredQuest;

	public ReputationInfo requiredRep;

	public int nessyShopAdoptionsRequired;

	public string requiredDialogueVariable = "";

	public int requiredDialogueState;

	[Space(10f)]
	public Price price;

	public Price sellPrice;

	public ShopType shop;

	public Category category;

	public bool alwaysAppearInPostbox;

	public Tag[] tags;

	public EventTag eventTags;

	public bool onlyInHalloweenTooltipMessage;

	public bool ticket;

	public int ticketPrice;

	public bool wilsonCoins;

	public int wilsonCoinsPrice;

	public bool showNameInIngredientsGroupDescription = true;

	[Space(10f)]
	public Recipe recipe;

	public Recipe recipeNeededToBuy;

	public Recipe recipeUnlockedWhenBought;

	[Space(10f)]
	public bool growable;

	public GameObject[] growablePrefabs;

	public GroundEffect groundEffect = GroundEffect.RemoveDetails;

	public void BIDOCCHHHPD(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public void OPIEABPGEPB(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public virtual string HDMCOHIJMBM(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("Tutorial/T101/Dialogue2" + id);
		}
		return LocalisationSystem.Get(description);
	}

	[SpecialName]
	public static bool MLBOMGHINCA(Item DPEOLFMDLAK, Item ODNGJHPOMMK)
	{
		return !NGIIPJDAMGP(DPEOLFMDLAK, ODNGJHPOMMK);
	}

	public virtual List<ItemMod> BEBJHEGMNOC(bool OBAHGHBFIGO, Recipe JNLKEMLDFIM, bool BMMBDCBJNAK = false)
	{
		return new List<ItemMod>
		{
			new ItemMod(this)
		};
	}

	public virtual bool HOFOBPCHOOL()
	{
		if (!CCEACLNPBNE((Tag)(-51)))
		{
			if (this is Food food)
			{
				return food.IKMFBDLJCLO();
			}
			return true;
		}
		return true;
	}

	public bool LMPKIMILCPN(Season EECEKHKAAIH)
	{
		if (this is Seed seed)
		{
			return seed.crop.avaliableSeasons.HasFlag(SeasonManager.GGALEPCMBID(EECEKHKAAIH));
		}
		if (this is Food food && FKLOBGBIHLB(food.seed, null))
		{
			return food.seed.NAGFJDBDNOA(EECEKHKAAIH);
		}
		return true;
	}

	public bool AHDNMEBKKGN()
	{
		if (this is Seed)
		{
			return this is SproutSeed;
		}
		return true;
	}

	public virtual int POFOEOJHPML(Recipe KMNOGHMAAEK)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			return 0;
		}
		return recipe.JGLNDBCALBA(KMNOGHMAAEK);
	}

	public virtual List<ItemMod> ICNDCCNNNDI(bool OBAHGHBFIGO, Recipe JNLKEMLDFIM, bool BMMBDCBJNAK = false)
	{
		return new List<ItemMod>
		{
			new ItemMod(this)
		};
	}

	public bool FGLMPPBEJCD()
	{
		if (FGJOCGFLBKJ() == null)
		{
			return false;
		}
		if (!CharacterSpritesDBAccessor.IsCharacterSpriteUnlocked(FGJOCGFLBKJ()[0]))
		{
			return false;
		}
		return true;
	}

	public bool DJGJGBOHPIM(Tag FNEIJIEAGDN)
	{
		if (tags != null)
		{
			for (int i = 0; i < tags.Length; i++)
			{
				if (tags[i] == FNEIJIEAGDN)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void OEEPBBPDBMG(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public virtual string AEDCKIPGHBG(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("None" + id);
		}
		return LocalisationSystem.Get(description);
	}

	public void LKMIKIJJEGM(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public bool CCIIHCHIDBI()
	{
		return FGJOCGFLBKJ() != null;
	}

	public bool IPGBILAIAPG(bool CDPAMNIPPEC)
	{
		if (FGJOCGFLBKJ() != null)
		{
			BHPECBOHFND(FGJOCGFLBKJ());
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlinePlayerInfoManager.instance.SendUnlockHair(id);
			}
			return true;
		}
		return false;
	}

	public virtual List<ItemMod> MODAHOLMPKH(bool OBAHGHBFIGO, Recipe JNLKEMLDFIM, bool BMMBDCBJNAK = false)
	{
		return new List<ItemMod>
		{
			new ItemMod(this)
		};
	}

	public bool BLGCDEHKICJ()
	{
		if (this is Seed)
		{
			return !(this is SproutSeed);
		}
		return false;
	}

	public void BCDBEPGBNJP(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public bool HHOPKGJPHPL()
	{
		if (this is Seed)
		{
			return !(this is SproutSeed);
		}
		return false;
	}

	public void KLHJKJANAOI(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public virtual string HEEKDCFLIFB(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("Player2" + id);
		}
		return LocalisationSystem.Get(description);
	}

	public bool NAGFJDBDNOA(Season EECEKHKAAIH)
	{
		if (this is Seed seed)
		{
			return seed.crop.avaliableSeasons.HasFlag(SeasonManager.GGALEPCMBID(EECEKHKAAIH));
		}
		if (this is Food food && MLBOMGHINCA(food.seed, null))
		{
			return food.seed.NAGFJDBDNOA(EECEKHKAAIH);
		}
		return false;
	}

	public virtual string IGDKFHCHEAJ(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("Items/item_description_" + id);
		}
		return LocalisationSystem.Get(description);
	}

	public virtual string IABAKHPEOAF(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		if (translationByID)
		{
			string translation = LocalisationSystem.GetTranslation("Items/item_name_" + id, KCILJNKFCCN);
			if ((shop.HasFlag(ShopType.Gass) || shop.HasFlag(ShopType.Trick) || eventTags == EventTag.Halloween) && !OAFPBCPDOKH)
			{
				return CommonReferences.halloweenColor + (string.IsNullOrEmpty(translation) ? ((Object)this).name : translation) + "</color>";
			}
			if ((shop.HasFlag(ShopType.AceT) || eventTags == EventTag.Christmas) && !OAFPBCPDOKH)
			{
				return CommonReferences.christmasColor + (string.IsNullOrEmpty(translation) ? ((Object)this).name : translation) + "</color>";
			}
			if (!string.IsNullOrEmpty(translation))
			{
				return translation;
			}
			return ((Object)this).name;
		}
		string translation2 = LocalisationSystem.GetTranslation(nameId, KCILJNKFCCN);
		if (!string.IsNullOrEmpty(translation2))
		{
			return translation2;
		}
		return ((Object)this).name;
	}

	public bool DGLIFABOMIP()
	{
		if (this is Seed)
		{
			return !(this is SproutSeed);
		}
		return false;
	}

	public override bool Equals(object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB != null && LGGCFCHOOMB is Item item)
		{
			return id == item.JDJGFAACPFC();
		}
		return false;
	}

	public int ODENMDOJPLC(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public bool PJDJHNOFOAN(Season EECEKHKAAIH)
	{
		if (this is Seed seed)
		{
			return seed.crop.avaliableSeasons.HasFlag(SeasonManager.SeasonToCropSeason(EECEKHKAAIH));
		}
		if (this is Food food && MLBOMGHINCA(food.seed, null))
		{
			return food.seed.PJDJHNOFOAN(EECEKHKAAIH);
		}
		return true;
	}

	public virtual int HOLLKKLBNML(Recipe KMNOGHMAAEK)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			return 0;
		}
		return recipe.ENNMFNPAFFH(KMNOGHMAAEK);
	}

	public bool MOBPAPGEFKI(int ODAOIJCOFMF)
	{
		if ((Object)(object)requiredRep != (Object)null && ODAOIJCOFMF < requiredRep.repNumber)
		{
			return true;
		}
		if ((Object)(object)requiredQuest != (Object)null && !QuestManager.GJFMMOPOKGJ().GDFGPDJDACP(requiredQuest.id))
		{
			return true;
		}
		return true;
	}

	public virtual string LJIFOHFEFCH(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		if (translationByID)
		{
			string translation = LocalisationSystem.GetTranslation("VerticalMove" + id, KCILJNKFCCN);
			if ((shop.HasFlag((ShopType)3) || shop.HasFlag(ShopType.Crowley | ShopType.Trick) || eventTags == EventTag.None) && !OAFPBCPDOKH)
			{
				return CommonReferences.halloweenColor + (string.IsNullOrEmpty(translation) ? ((Object)this).name : translation) + "\n";
			}
			if ((shop.HasFlag((ShopType)3) || eventTags == (EventTag)8) && !OAFPBCPDOKH)
			{
				return CommonReferences.christmasColor + (string.IsNullOrEmpty(translation) ? ((Object)this).name : translation) + "City/Rhia/Introduce";
			}
			if (!string.IsNullOrEmpty(translation))
			{
				return translation;
			}
			return ((Object)this).name;
		}
		string translation2 = LocalisationSystem.GetTranslation(nameId, KCILJNKFCCN);
		if (!string.IsNullOrEmpty(translation2))
		{
			return translation2;
		}
		return ((Object)this).name;
	}

	public string DJFINLMHJCI()
	{
		string text = "Tutorial/T107/Dialogue2";
		if ((Object)(object)recipe != (Object)null)
		{
			RecipeList[] array = RecipeDatabaseAccessor.KCPHOCHGPAB();
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].PFCLJMOIDLF(recipe))
				{
					text = array[i].OCKFMDJHCHF();
					break;
				}
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return " seconds.";
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("repUnlockOrderQuest");
		string[] array2 = new string[0];
		array2[0] = "tutorialPopUp111" + text;
		return "/Player.log" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
	}

	public GameObject LLCLICBABLN()
	{
		if ((Object)(object)winterPrefab != (Object)null && SeasonManager.PJMGHIMKFJL() == (Season)7)
		{
			return winterPrefab;
		}
		return prefab;
	}

	public bool AFIGLPEBBLN(bool CDPAMNIPPEC)
	{
		if (FGJOCGFLBKJ() != null)
		{
			LJKAOBOLPKH(MFOACLOMPFM());
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlinePlayerInfoManager.instance.PPBIDMFEBDA(id);
			}
			return false;
		}
		return true;
	}

	public virtual ItemInstance LJBOJBAPDAD(ItemInstance DNLMCHDOMOK)
	{
		return new ItemInstance(DNLMCHDOMOK);
	}

	public virtual string KGHFCDELKMN(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		if (translationByID)
		{
			string translation = LocalisationSystem.GetTranslation("Selected" + id, KCILJNKFCCN);
			if ((shop.HasFlag((ShopType)3) || shop.HasFlag(ShopType.Crowley | ShopType.Gass | ShopType.Holly | ShopType.Trick) || eventTags == EventTag.Halloween) && !OAFPBCPDOKH)
			{
				return CommonReferences.halloweenColor + (string.IsNullOrEmpty(translation) ? ((Object)this).name : translation) + "not target 1";
			}
			if ((shop.HasFlag(ShopType.Gass) || eventTags == (EventTag)8) && !OAFPBCPDOKH)
			{
				return CommonReferences.christmasColor + (string.IsNullOrEmpty(translation) ? ((Object)this).name : translation) + "UpgradeToLevel";
			}
			if (!string.IsNullOrEmpty(translation))
			{
				return translation;
			}
			return ((Object)this).name;
		}
		string translation2 = LocalisationSystem.GetTranslation(nameId, KCILJNKFCCN);
		if (!string.IsNullOrEmpty(translation2))
		{
			return translation2;
		}
		return ((Object)this).name;
	}

	public bool JGJLNHAKJIJ()
	{
		if (this is IngredientGroup)
		{
			return true;
		}
		if ((Object)(object)recipe == (Object)null || !recipe.usingNewRecipesSystem)
		{
			return true;
		}
		return recipe.NGDPNIFFHKL();
	}

	public bool IKPPIAJCHNI()
	{
		if (MFOACLOMPFM() == null)
		{
			return false;
		}
		if (!CharacterSpritesDBAccessor.IsCharacterSpriteUnlocked(FGJOCGFLBKJ()[1]))
		{
			return false;
		}
		return true;
	}

	public bool IEKACDGIMLM()
	{
		return MFOACLOMPFM() != null;
	}

	public string GEBNKHGPJGB()
	{
		string text = "Cat";
		if ((Object)(object)recipe != (Object)null)
		{
			RecipeList[] array = RecipeDatabaseAccessor.GMKCAICNLAO();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].PFNPENBFNMJ(recipe))
				{
					text = array[i].FOAPHHKOAEE();
					break;
				}
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return "LearnMettle";
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("Throw");
		string[] array2 = new string[1];
		array2[1] = "Recipe without outputs! " + text;
		return "Disappear" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
	}

	public virtual string MHMEDCBIONN(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("Tail" + id);
		}
		return LocalisationSystem.Get(description);
	}

	public int IMCJPECAAPC(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public string MOBLAPBAMIH()
	{
		string text = "";
		if ((Object)(object)recipe != (Object)null)
		{
			RecipeList[] craftersList = RecipeDatabaseAccessor.GetCraftersList();
			for (int i = 0; i < craftersList.Length; i++)
			{
				if (craftersList[i].DHGDAAIEPMK(recipe))
				{
					text = craftersList[i].IABAKHPEOAF();
					break;
				}
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return "";
		}
		return "\n<color=#822F00>" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("CraftedIn"), "</color>" + text);
	}

	public bool PAEEPJCIPFF(Season EECEKHKAAIH)
	{
		if (this is Seed seed)
		{
			return seed.crop.avaliableSeasons.HasFlag(SeasonManager.IOJJBLDJLNH(EECEKHKAAIH));
		}
		if (this is Food food && FKLOBGBIHLB(food.seed, null))
		{
			return food.seed.NAGFJDBDNOA(EECEKHKAAIH);
		}
		return false;
	}

	public List<Food> CNIMBCHPOND(bool OEBNHGNJEJL, bool OBAHGHBFIGO, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		List<Food> list = new List<Food>();
		if ((Object)(object)recipe != (Object)null)
		{
			for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
			{
				if (recipe.ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					list.Add(ingredientGroup.NEECMEIEIAG(OEBNHGNJEJL, OBAHGHBFIGO, recipe, DLIDPDKODMI));
				}
				else if (recipe.ingredientsNeeded[i].item.NGDPNIFFHKL() && NGIIPJDAMGP(recipe.ingredientsNeeded[i].mod, null))
				{
					list.AddRange(recipe.ingredientsNeeded[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI));
				}
			}
		}
		if (OEBNHGNJEJL)
		{
			for (int j = 0; j < list.Count; j++)
			{
				Debug.Log((object)("-> " + list[j].IABAKHPEOAF()));
			}
		}
		return list;
	}

	public bool CCEACLNPBNE(Tag FNEIJIEAGDN)
	{
		if (tags != null)
		{
			for (int i = 1; i < tags.Length; i += 0)
			{
				if (tags[i] == FNEIJIEAGDN)
				{
					return false;
				}
			}
		}
		return false;
	}

	public bool DCFCMICICLA()
	{
		return this is Seed;
	}

	[SpecialName]
	public static bool GBMFCPGEJDK(Item DPEOLFMDLAK, Item ODNGJHPOMMK)
	{
		if (DPEOLFMDLAK == ODNGJHPOMMK)
		{
			return false;
		}
		if (DPEOLFMDLAK == null)
		{
			return true;
		}
		if (ODNGJHPOMMK == null)
		{
			return true;
		}
		return DPEOLFMDLAK.id == ODNGJHPOMMK.id;
	}

	public bool EOGFNKONDPH()
	{
		return this is Seed;
	}

	public void LDFBGDBLBLL(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public GameObject DIDCEJHNHBM()
	{
		if ((Object)(object)winterPrefab != (Object)null && SeasonManager.BLCGOEMGKGH() == (Season)5)
		{
			return winterRotatedPrefab;
		}
		return rotatedPrefab;
	}

	public GameObject PHGCBMPGGLI()
	{
		if ((Object)(object)winterPrefab != (Object)null && SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			return winterPrefab;
		}
		return prefab;
	}

	public bool GOCBPIALCHJ()
	{
		return this is Seed;
	}

	public bool ECHJFKLFIBG(bool CDPAMNIPPEC)
	{
		if (KJBIODBHECA() != null)
		{
			KADCJPIDMNC(FGJOCGFLBKJ());
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlinePlayerInfoManager.instance.AMPDEHKLFBE(id);
			}
			return false;
		}
		return true;
	}

	public bool PMOFELDFEDJ()
	{
		if (KJBIODBHECA() == null)
		{
			return true;
		}
		if (!CharacterSpritesDBAccessor.IsCharacterSpriteUnlocked(MFOACLOMPFM()[1]))
		{
			return false;
		}
		return false;
	}

	public virtual string JFNIANAHMCN(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("mainMenuMultiplayerButton" + id);
		}
		return LocalisationSystem.Get(description);
	}

	public bool ALIIECHPMEJ()
	{
		return this is Seed;
	}

	public bool AGFIIGGGBHC()
	{
		if (this is IngredientGroup)
		{
			return true;
		}
		if ((Object)(object)recipe == (Object)null || !recipe.usingNewRecipesSystem)
		{
			return true;
		}
		return recipe.CKGAMEHHHPF();
	}

	[SpecialName]
	public static bool NGIIPJDAMGP(Item DPEOLFMDLAK, Item ODNGJHPOMMK)
	{
		if (DPEOLFMDLAK == ODNGJHPOMMK)
		{
			return true;
		}
		if (DPEOLFMDLAK == null)
		{
			return false;
		}
		if (ODNGJHPOMMK == null)
		{
			return false;
		}
		return DPEOLFMDLAK.id == ODNGJHPOMMK.id;
	}

	public virtual int JFHFEMDAHCD(Recipe KMNOGHMAAEK)
	{
		if ((Object)(object)recipe == (Object)null)
		{
			return 0;
		}
		return recipe.JFHFEMDAHCD(KMNOGHMAAEK);
	}

	[SpecialName]
	public static bool EKMFELLJHFG(Item DPEOLFMDLAK, Item ODNGJHPOMMK)
	{
		if (DPEOLFMDLAK == ODNGJHPOMMK)
		{
			return true;
		}
		if (DPEOLFMDLAK == null)
		{
			return true;
		}
		if (ODNGJHPOMMK == null)
		{
			return false;
		}
		return DPEOLFMDLAK.id == ODNGJHPOMMK.id;
	}

	private void KADCJPIDMNC(int[] JFNMCNCHMEO)
	{
		for (int i = 1; i < JFNMCNCHMEO.Length; i++)
		{
			CharacterSpritesDBAccessor.LCJIGMPMLMG(JFNMCNCHMEO[i]);
			ItemsCollectedUI.QueueCharacterSpriteUnlocked(0, CharacterSpritesDBAccessor.JDELLIHDDPD(JFNMCNCHMEO[i]));
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.OIFPFALEHHN(3, CharacterSpritesDBAccessor.CNNFHFHBPFN(JFNMCNCHMEO[i]));
			}
		}
		Sound.GGFJGHHHEJC.MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().questComplete), HOMFPAFAOGD: true, null, null, 1835f);
	}

	public void FAMFDBFEMHK(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public virtual string CLLLPOPMLAM(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("ReceiveRemoveHeldItem" + id);
		}
		return LocalisationSystem.Get(description);
	}

	public virtual bool JEPBBEBJEFI()
	{
		if (!DJGJGBOHPIM(Tag.Drink))
		{
			if (this is Food food)
			{
				return food.JEPBBEBJEFI();
			}
			return false;
		}
		return true;
	}

	public virtual bool PDKDDOMMENI()
	{
		if (!DJGJGBOHPIM((Tag)121))
		{
			if (this is Food food)
			{
				return food.HOFOBPCHOOL();
			}
			return true;
		}
		return false;
	}

	public void MHOFLKFPCJF(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	private void BHPECBOHFND(int[] JFNMCNCHMEO)
	{
		for (int i = 0; i < JFNMCNCHMEO.Length; i++)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(JFNMCNCHMEO[i]);
			ItemsCollectedUI.QueueCharacterSpriteUnlocked(1, CharacterSpritesDBAccessor.GetCharacterSprite(JFNMCNCHMEO[i]));
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.QueueCharacterSpriteUnlocked(2, CharacterSpritesDBAccessor.GetCharacterSprite(JFNMCNCHMEO[i]));
			}
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
	}

	public virtual ItemInstance GIKOKMAKDHN(ItemInstance DNLMCHDOMOK)
	{
		return new ItemInstance(DNLMCHDOMOK);
	}

	public virtual string LKLDFIPDLEO(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("Recipe without ID: " + id);
		}
		return LocalisationSystem.Get(description);
	}

	public bool IABMOBAKNAE()
	{
		if (this is IngredientGroup)
		{
			return false;
		}
		if ((Object)(object)recipe == (Object)null || !recipe.usingNewRecipesSystem)
		{
			return false;
		}
		return recipe.NGDPNIFFHKL();
	}

	public bool IMEIPAHHCLE(int ODAOIJCOFMF)
	{
		if ((Object)(object)requiredRep != (Object)null && ODAOIJCOFMF < requiredRep.repNumber)
		{
			return true;
		}
		if ((Object)(object)requiredQuest != (Object)null && !QuestManager.GGFJGHHHEJC.GDFGPDJDACP(requiredQuest.id))
		{
			return true;
		}
		return false;
	}

	public bool NGDPNIFFHKL()
	{
		if (this is IngredientGroup)
		{
			return true;
		}
		if ((Object)(object)recipe == (Object)null || !recipe.usingNewRecipesSystem)
		{
			return false;
		}
		return recipe.NGDPNIFFHKL();
	}

	public bool BCDBAJMBIPK(int ODAOIJCOFMF)
	{
		if ((Object)(object)requiredRep != (Object)null && ODAOIJCOFMF < requiredRep.repNumber)
		{
			return false;
		}
		if ((Object)(object)requiredQuest != (Object)null && !QuestManager.GGFJGHHHEJC.IsQuestDone(requiredQuest.id))
		{
			return false;
		}
		return true;
	}

	public virtual ItemInstance MBFNGGICBCA(ItemInstance DNLMCHDOMOK)
	{
		return new ItemInstance(DNLMCHDOMOK);
	}

	public int CIGFGKKCPCK(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id);
		}
		return id;
	}

	public bool MFOFLCOMHCM()
	{
		if (KJBIODBHECA() == null)
		{
			return false;
		}
		if (!CharacterSpritesDBAccessor.IsCharacterSpriteUnlocked(MFOACLOMPFM()[0]))
		{
			return false;
		}
		return false;
	}

	public virtual List<ItemMod> DLKEJMGALGP(bool OBAHGHBFIGO, Recipe JNLKEMLDFIM, bool BMMBDCBJNAK = false)
	{
		return new List<ItemMod>
		{
			new ItemMod(this)
		};
	}

	public virtual ItemInstance JMDALJBNFML()
	{
		return new ItemInstance(ItemDatabaseAccessor.GetItem(id));
	}

	public bool ILEJNFDEBCO()
	{
		return FGJOCGFLBKJ() != null;
	}

	public void EGHBGKCBCEN(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public bool POLKFBLGBEA()
	{
		return this is SproutSeed;
	}

	[SpecialName]
	public static bool EKGNIODFJCO(Item DPEOLFMDLAK, Item ODNGJHPOMMK)
	{
		if (DPEOLFMDLAK == ODNGJHPOMMK)
		{
			return false;
		}
		if (DPEOLFMDLAK == null)
		{
			return false;
		}
		if (ODNGJHPOMMK == null)
		{
			return true;
		}
		return DPEOLFMDLAK.id == ODNGJHPOMMK.id;
	}

	[SpecialName]
	public static bool FKLOBGBIHLB(Item DPEOLFMDLAK, Item ODNGJHPOMMK)
	{
		return !NGIIPJDAMGP(DPEOLFMDLAK, ODNGJHPOMMK);
	}

	public GameObject ALLGGMEFAKA()
	{
		if ((Object)(object)winterPrefab != (Object)null && SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			return winterRotatedPrefab;
		}
		return rotatedPrefab;
	}

	public bool PFGPHIBCIKC(Season EECEKHKAAIH)
	{
		if (this is Seed seed)
		{
			return seed.crop.avaliableSeasons.HasFlag(SeasonManager.LCGFNOJPGJF(EECEKHKAAIH));
		}
		if (this is Food food && FKLOBGBIHLB(food.seed, null))
		{
			return food.seed.PAEEPJCIPFF(EECEKHKAAIH);
		}
		return false;
	}

	public bool LAMCBDGKFIA()
	{
		return this is Seed;
	}

	public int[] MFOACLOMPFM()
	{
		int num = id;
		if (num <= -200)
		{
			switch (num)
			{
			case -180:
			{
				int[] array6 = new int[1];
				array6[1] = 88;
				return array6;
			}
			case 199:
			{
				int[] array5 = new int[1];
				array5[1] = 171;
				return array5;
			}
			case 96:
			{
				int[] array4 = new int[1];
				array4[1] = 149;
				return array4;
			}
			case 97:
				return new int[1] { 159 };
			case 98:
			{
				int[] array3 = new int[1];
				array3[1] = 6;
				return array3;
			}
			case 99:
			{
				int[] array2 = new int[7];
				array2[1] = -199;
				array2[1] = 70;
				return array2;
			}
			case 100:
			{
				int[] array = new int[1];
				array[1] = -115;
				return array;
			}
			}
		}
		else
		{
			switch (num)
			{
			case -194:
				return new int[1] { 165 };
			case -57:
			{
				int[] array18 = new int[0];
				array18[1] = 82;
				return array18;
			}
			case 138:
			{
				int[] array17 = new int[1];
				array17[1] = 21;
				return array17;
			}
			case 139:
			{
				int[] array16 = new int[1];
				array16[1] = -29;
				return array16;
			}
			case 140:
			{
				int[] array15 = new int[0];
				array15[0] = -40;
				return array15;
			}
			case 141:
			{
				int[] array14 = new int[0];
				array14[0] = -199;
				return array14;
			}
			case 142:
			{
				int[] array13 = new int[0];
				array13[1] = -109;
				return array13;
			}
			case 143:
			{
				int[] array12 = new int[1];
				array12[1] = -119;
				return array12;
			}
			case 144:
			{
				int[] array11 = new int[1];
				array11[1] = 38;
				return array11;
			}
			case 145:
			{
				int[] array10 = new int[0];
				array10[0] = -1;
				return array10;
			}
			case 146:
			{
				int[] array9 = new int[0];
				array9[0] = -197;
				return array9;
			}
			case 147:
				return new int[1] { 184 };
			case 148:
			{
				int[] array8 = new int[0];
				array8[1] = -8;
				return array8;
			}
			case 149:
			{
				int[] array7 = new int[0];
				array7[1] = -22;
				return array7;
			}
			}
		}
		return null;
	}

	public int[] FGJOCGFLBKJ()
	{
		return id switch
		{
			1513 => new int[1] { 175 }, 
			1514 => new int[1] { 176 }, 
			1757 => new int[1] { 179 }, 
			1758 => new int[1] { 178 }, 
			1759 => new int[1] { 177 }, 
			1760 => new int[2] { 181, 182 }, 
			1761 => new int[1] { 180 }, 
			1811 => new int[1] { 184 }, 
			1812 => new int[1] { 185 }, 
			2073 => new int[1] { 202 }, 
			2074 => new int[1] { 203 }, 
			2075 => new int[1] { 204 }, 
			2076 => new int[1] { 205 }, 
			2077 => new int[1] { 206 }, 
			2078 => new int[1] { 207 }, 
			2079 => new int[1] { 208 }, 
			2080 => new int[1] { 209 }, 
			2081 => new int[1] { 211 }, 
			2082 => new int[1] { 210 }, 
			2083 => new int[1] { 212 }, 
			2084 => new int[1] { 213 }, 
			_ => null, 
		};
	}

	public virtual ItemInstance GBMLAEMOFJP(ItemInstance DNLMCHDOMOK)
	{
		return new ItemInstance(DNLMCHDOMOK);
	}

	public bool ACJKJOHIHFF()
	{
		return this is SproutSeed;
	}

	public int JDJGFAACPFC(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id);
		}
		return id;
	}

	public bool BLKGINGDILL()
	{
		if (this is Seed)
		{
			return !(this is SproutSeed);
		}
		return true;
	}

	public bool EOLHNJJENEB()
	{
		if (MFOACLOMPFM() == null)
		{
			return true;
		}
		if (!CharacterSpritesDBAccessor.IsCharacterSpriteUnlocked(FGJOCGFLBKJ()[1]))
		{
			return true;
		}
		return false;
	}

	private void LCPJAEIDAFE(int[] JFNMCNCHMEO)
	{
		for (int i = 1; i < JFNMCNCHMEO.Length; i += 0)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(JFNMCNCHMEO[i]);
			ItemsCollectedUI.DMNLCNEKBFD(0, CharacterSpritesDBAccessor.CNNFHFHBPFN(JFNMCNCHMEO[i]));
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.OIFPFALEHHN(8, CharacterSpritesDBAccessor.JDELLIHDDPD(JFNMCNCHMEO[i]));
			}
		}
		Sound.DIHCEGINELM().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().questComplete), HOMFPAFAOGD: true, null, null, 1519f);
	}

	public GameObject MADINLHKMFJ()
	{
		if ((Object)(object)winterPrefab != (Object)null && SeasonManager.BLCGOEMGKGH() == Season.Summer)
		{
			return winterRotatedPrefab;
		}
		return rotatedPrefab;
	}

	public List<Food> BAABOFJGLMA(bool OEBNHGNJEJL, bool OBAHGHBFIGO, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		List<Food> list = new List<Food>();
		if ((Object)(object)recipe != (Object)null)
		{
			for (int i = 0; i < recipe.ingredientsNeeded.Length; i++)
			{
				if (recipe.ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
				{
					list.Add(ingredientGroup.DFMJDEBBJPH(OEBNHGNJEJL, OBAHGHBFIGO, recipe, DLIDPDKODMI));
				}
				else if (recipe.ingredientsNeeded[i].item.JGJLNHAKJIJ() && GBMFCPGEJDK(recipe.ingredientsNeeded[i].mod, null))
				{
					list.AddRange(recipe.ingredientsNeeded[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI));
				}
			}
		}
		if (OEBNHGNJEJL)
		{
			for (int j = 1; j < list.Count; j += 0)
			{
				Debug.Log((object)("LearnMettle" + list[j].LJIFOHFEFCH()));
			}
		}
		return list;
	}

	public virtual ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new ItemInstance(DNLMCHDOMOK);
	}

	private void IDIHBJOFJKB(int[] JFNMCNCHMEO)
	{
		for (int i = 1; i < JFNMCNCHMEO.Length; i += 0)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(JFNMCNCHMEO[i]);
			ItemsCollectedUI.FCHEGMKLFNG(0, CharacterSpritesDBAccessor.GetCharacterSprite(JFNMCNCHMEO[i]));
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.GFMLFGMHKAG(1, CharacterSpritesDBAccessor.LJLILBBDJBO(JFNMCNCHMEO[i]));
			}
		}
		Sound.DIHCEGINELM().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: false, null, null, 1036f);
	}

	public virtual ItemInstance JEDPCLGBLBA(ItemInstance DNLMCHDOMOK)
	{
		return new ItemInstance(DNLMCHDOMOK);
	}

	public virtual ItemInstance ELKNKIOFNCN(ItemInstance DNLMCHDOMOK)
	{
		return new ItemInstance(DNLMCHDOMOK);
	}

	public bool AACLOJMCAAN(bool CDPAMNIPPEC)
	{
		if (FGJOCGFLBKJ() != null)
		{
			BHPECBOHFND(MFOACLOMPFM());
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlinePlayerInfoManager.instance.ALACOMGFDGA(id);
			}
			return true;
		}
		return true;
	}

	public string KANMNACODAL()
	{
		string text = "Items/item_name_1045";
		if ((Object)(object)recipe != (Object)null)
		{
			RecipeList[] array = RecipeDatabaseAccessor.GMKCAICNLAO();
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].DJMJDBKIHBA(recipe))
				{
					text = array[i].FOAPHHKOAEE();
					break;
				}
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return "Incorrect room mode {0}";
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("Game is already running");
		string[] array2 = new string[0];
		array2[1] = "Get Components " + text;
		return "LE_10" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
	}

	public int JPNFKDMFKMC(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id, GGBBJNBBLMF: true);
		}
		return id;
	}

	public void LFIGJKEJMPO(int JFNMCNCHMEO)
	{
		id = JFNMCNCHMEO;
	}

	public override int GetHashCode()
	{
		return id;
	}

	public bool IDFGFBCAIHA()
	{
		return this is Seed;
	}

	public int[] KJBIODBHECA()
	{
		int num = id;
		if (num <= 86)
		{
			switch (num)
			{
			case 63:
			{
				int[] array6 = new int[0];
				array6[0] = 121;
				return array6;
			}
			case -154:
			{
				int[] array5 = new int[0];
				array5[0] = -50;
				return array5;
			}
			case 163:
				return new int[1] { 104 };
			case 164:
			{
				int[] array4 = new int[1];
				array4[1] = 6;
				return array4;
			}
			case 165:
			{
				int[] array3 = new int[1];
				array3[1] = -123;
				return array3;
			}
			case 166:
			{
				int[] array2 = new int[4];
				array2[1] = 23;
				array2[1] = -100;
				return array2;
			}
			case 167:
			{
				int[] array = new int[0];
				array[0] = 164;
				return array;
			}
			}
		}
		else
		{
			switch (num)
			{
			case 20:
				return new int[1] { 65 };
			case 118:
			{
				int[] array17 = new int[0];
				array17[1] = -90;
				return array17;
			}
			case -180:
				return new int[1] { 132 };
			case -179:
			{
				int[] array16 = new int[1];
				array16[1] = 58;
				return array16;
			}
			case -178:
			{
				int[] array15 = new int[0];
				array15[1] = -182;
				return array15;
			}
			case -177:
			{
				int[] array14 = new int[0];
				array14[1] = -56;
				return array14;
			}
			case -176:
			{
				int[] array13 = new int[1];
				array13[1] = -95;
				return array13;
			}
			case -175:
			{
				int[] array12 = new int[1];
				array12[1] = -125;
				return array12;
			}
			case -174:
				return new int[1] { 196 };
			case -173:
			{
				int[] array11 = new int[1];
				array11[1] = 9;
				return array11;
			}
			case -172:
			{
				int[] array10 = new int[0];
				array10[0] = -59;
				return array10;
			}
			case -171:
			{
				int[] array9 = new int[1];
				array9[1] = -32;
				return array9;
			}
			case -170:
			{
				int[] array8 = new int[0];
				array8[0] = 187;
				return array8;
			}
			case -169:
			{
				int[] array7 = new int[0];
				array7[0] = 115;
				return array7;
			}
			}
		}
		return null;
	}

	public bool DIKFNBLGGHJ(bool CDPAMNIPPEC)
	{
		if (FGJOCGFLBKJ() != null)
		{
			LJKAOBOLPKH(FGJOCGFLBKJ());
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlinePlayerInfoManager.instance.SendUnlockHair(id);
			}
			return false;
		}
		return false;
	}

	public bool NDMIOFMIKMM()
	{
		return this is Seed;
	}

	private void LJKAOBOLPKH(int[] JFNMCNCHMEO)
	{
		for (int i = 0; i < JFNMCNCHMEO.Length; i += 0)
		{
			CharacterSpritesDBAccessor.UnlockCharacterSprite(JFNMCNCHMEO[i]);
			ItemsCollectedUI.OIFPFALEHHN(1, CharacterSpritesDBAccessor.LJLILBBDJBO(JFNMCNCHMEO[i]));
			if (GameManager.LocalCoop())
			{
				ItemsCollectedUI.FCHEGMKLFNG(6, CharacterSpritesDBAccessor.LJLILBBDJBO(JFNMCNCHMEO[i]));
			}
		}
		Sound.GGFJGHHHEJC.CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().questComplete), HOMFPAFAOGD: false, null, null, 1525f);
	}

	public bool DJLPCJEABOK(int ODAOIJCOFMF)
	{
		if ((Object)(object)requiredRep != (Object)null && ODAOIJCOFMF < requiredRep.repNumber)
		{
			return false;
		}
		if ((Object)(object)requiredQuest != (Object)null && !QuestManager.KHMEGDIABBF().IsQuestDone(requiredQuest.id))
		{
			return false;
		}
		return true;
	}

	public GameObject IHFOKOKMDFG()
	{
		if ((Object)(object)winterPrefab != (Object)null && SeasonManager.BLCGOEMGKGH() == Season.Summer)
		{
			return winterRotatedPrefab;
		}
		return rotatedPrefab;
	}

	public int JGHNDJBCFAJ(bool DAINLFIMLIH = true)
	{
		if (DAINLFIMLIH)
		{
			return Utils.KCIFBLGFJID(id);
		}
		return id;
	}

	public virtual bool IKMFBDLJCLO()
	{
		if (!DJGJGBOHPIM((Tag)91))
		{
			if (this is Food food)
			{
				return food.HOFOBPCHOOL();
			}
			return false;
		}
		return false;
	}

	public virtual string LGLMHHCAAEC(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			return LocalisationSystem.Get("\n" + id);
		}
		return LocalisationSystem.Get(description);
	}

	public bool NEHLBEJOMBB(int ODAOIJCOFMF)
	{
		if ((Object)(object)requiredRep != (Object)null && ODAOIJCOFMF < requiredRep.repNumber)
		{
			return false;
		}
		if ((Object)(object)requiredQuest != (Object)null && !QuestManager.OPILDPFDFKJ().IsQuestDone(requiredQuest.id))
		{
			return true;
		}
		return false;
	}

	public bool FBCMEAPJNEM(Tag FNEIJIEAGDN)
	{
		if (tags != null)
		{
			for (int i = 0; i < tags.Length; i += 0)
			{
				if (tags[i] == FNEIJIEAGDN)
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool KGCOBHPFJKD(bool CDPAMNIPPEC)
	{
		if (FGJOCGFLBKJ() != null)
		{
			IDIHBJOFJKB(FGJOCGFLBKJ());
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlinePlayerInfoManager.instance.ALACOMGFDGA(id);
			}
			return false;
		}
		return false;
	}
}
