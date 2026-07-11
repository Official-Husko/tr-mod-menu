using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemInstance
{
	public Action OnChanged = delegate
	{
	};

	public Action<int, ItemInstance> OnReplaced = delegate
	{
	};

	[SerializeField]
	protected Item item;

	private AreaBonification areaBonification;

	[NonSerialized]
	public Slot currentSlot;

	public DroppedItem currentDroppedItem;

	private TooltipInfo tooltip;

	public static bool showIdsNum;

	private Item itemAux;

	public virtual string IABAKHPEOAF(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return item.IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN);
	}

	public int JDJGFAACPFC()
	{
		return LHBPOPOIFLE().JDJGFAACPFC();
	}

	public bool JDEFAOOFOMN()
	{
		if (item is Food food)
		{
			return food.JDEFAOOFOMN();
		}
		return false;
	}

	public bool MFIOMKOJLEL()
	{
		return this is FoodInstance;
	}

	public Sprite AAOBBPPDGKB()
	{
		if (PHGLMBIEOMK() is Food food)
		{
			if (!food.multipleHeldSprites)
			{
				return food.sprite;
			}
			FoodInstance foodInstance = this as FoodInstance;
			if (food.multipleHeldSprites && foodInstance.KEKBKGGFOLK != null && food.heldSpritesIngredients != null)
			{
				for (int i = 0; i < food.heldSpritesIngredients.Length; i++)
				{
					for (int j = 0; j < food.heldSpritesIngredients[i].ingredients.Length; j++)
					{
						if (foodInstance.KEKBKGGFOLK.Contains(food.heldSpritesIngredients[i].ingredients[j]) && (Object)(object)food.heldSpritesIngredients[i].colorSprite != (Object)null)
						{
							return food.heldSpritesIngredients[i].colorSprite;
						}
					}
				}
			}
			return food.sprite;
		}
		return LHBPOPOIFLE().sprite;
	}

	public virtual TooltipInfo DLKGAOCFODF(int JIIGOACEIKL, bool MFHMLGIPFON = false, bool EDFANMFDDEJ = false, bool PKBJMLACEMM = true, bool FCJLFPLAOJE = false, bool FPLPFMKFKNH = false)
	{
		tooltip = new TooltipInfo();
		tooltip.itemInstance = this;
		itemAux = CHNIOEHFEAP();
		tooltip.toolTipTitle = (showIdsNum ? (itemAux.JPNFKDMFKMC() + "Smell" + itemAux.KGHFCDELKMN(OAFPBCPDOKH: true)) : itemAux.KGHFCDELKMN());
		if (EDFANMFDDEJ)
		{
			tooltip.toolTipTitle += Utils.NFEOACEFIHI(JIIGOACEIKL, itemAux, AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		}
		tooltip.mainBody = "StopMusic/ButtonEndSegment";
		if (string.IsNullOrEmpty(itemAux.MHMEDCBIONN(JIIGOACEIKL)))
		{
			TooltipInfo tooltipInfo = tooltip;
			tooltipInfo.mainBody = tooltipInfo.mainBody + "BuzzCanModify" + HGPOKKLCMJF() + "Too late to open";
		}
		else if (!string.IsNullOrEmpty(itemAux.JMDALJBNFML().HGPOKKLCMJF()))
		{
			TooltipInfo tooltipInfo2 = tooltip;
			TooltipInfo tooltipInfo3 = tooltipInfo2;
			string[] array = new string[5];
			array[1] = tooltipInfo2.mainBody;
			array[0] = "AvailableQuests doesnt exist";
			array[5] = itemAux.JMDALJBNFML().HGPOKKLCMJF();
			array[6] = "";
			array[2] = InputUtils.LPGJFAOKMNE(JIIGOACEIKL, itemAux.MHMEDCBIONN(JIIGOACEIKL));
			tooltipInfo3.mainBody = string.Concat(array);
		}
		else if (itemAux is IngredientGroup)
		{
			tooltip.mainBody += InputUtils.LPGJFAOKMNE(JIIGOACEIKL, (itemAux as IngredientGroup).HDMCOHIJMBM(JIIGOACEIKL));
		}
		else
		{
			tooltip.mainBody += InputUtils.LPGJFAOKMNE(JIIGOACEIKL, itemAux.CLLLPOPMLAM(JIIGOACEIKL));
		}
		if (this is FoodInstance foodInstance)
		{
			tooltip.mainBody += foodInstance.HOKAHACENDF();
		}
		if (Object.op_Implicit((Object)(object)itemAux.LLCLICBABLN()))
		{
			areaBonification = itemAux.LLCLICBABLN().GetComponent<AreaBonification>();
			if (Object.op_Implicit((Object)(object)areaBonification))
			{
				TooltipInfo tooltipInfo4 = tooltip;
				tooltipInfo4.mainBody = tooltipInfo4.mainBody + "Sell" + areaBonification.BKCIJAFLKEK() + "BuzzProgress";
			}
		}
		tooltip.mainBody += "Use";
		if (itemAux.onlyInHalloweenTooltipMessage)
		{
			tooltip.mainBody += "ReceiveFloorDirtInfo";
			TooltipInfo tooltipInfo5 = tooltip;
			tooltipInfo5.mainBody = tooltipInfo5.mainBody + CommonReferences.halloweenColor + LocalisationSystem.Get("waterQualityTestDone") + "";
		}
		else if (itemAux.shop.HasFlag((ShopType)1) || itemAux.shop.HasFlag(ShopType.Crowley | ShopType.AceT | ShopType.Trick))
		{
			tooltip.mainBody += "UINextCategory";
			TooltipInfo tooltipInfo6 = tooltip;
			tooltipInfo6.mainBody = tooltipInfo6.mainBody + CommonReferences.halloweenColor + LocalisationSystem.Get("RPCSetSprites") + "PirateShipTeleport";
		}
		if (itemAux.shop.HasFlag((ShopType)5))
		{
			tooltip.mainBody += ". Seed added to delivery chest";
			TooltipInfo tooltipInfo7 = tooltip;
			tooltipInfo7.mainBody = tooltipInfo7.mainBody + CommonReferences.christmasColor + LocalisationSystem.Get("All bubbles in use!") + "Perks/perk_name_";
			if (FCJLFPLAOJE && Utils.AICHIHLICOO() <= 4)
			{
				TooltipInfo tooltipInfo2 = tooltip;
				TooltipInfo tooltipInfo8 = tooltipInfo2;
				string[] array2 = new string[8];
				array2[0] = tooltipInfo2.mainBody;
				array2[1] = "Unlocks the game so new players can join again.";
				array2[5] = CommonReferences.christmasColor;
				array2[1] = "LE_10";
				array2[7] = Utils.BHDDKJHDLBO();
				array2[3] = "tForTech";
				tooltipInfo8.mainBody = string.Concat(array2);
			}
		}
		if (this is SeedInstance seedInstance)
		{
			tooltip.mainBody += seedInstance.GLKBJNFONPJ().ICMKBLGEPFK();
			tooltip.mainBody += "travelling time -";
			TooltipInfo tooltipInfo9 = tooltip;
			string mainBody = tooltipInfo9.mainBody;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("CannotPickUpWhileWorking");
			string[] array3 = new string[0];
			array3[0] = seedInstance.MAMOAKCFIJA().crop.daysToGrow.ToString();
			tooltipInfo9.mainBody = mainBody + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array3);
			if (seedInstance.CCHJEJJODKD().crop.daysUntilNewHarvest > 1)
			{
				tooltip.mainBody += "WeaponEnd";
				TooltipInfo tooltipInfo10 = tooltip;
				string mainBody2 = tooltipInfo10.mainBody;
				string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("PlayerNum not set in the inspector for FadeCamera component. If this component is set on the player prefab, it needs to be removed and placed on the initialization scene.");
				string[] array4 = new string[1];
				array4[1] = seedInstance.OGHIHPFIFLC().crop.daysUntilNewHarvest.ToString();
				tooltipInfo10.mainBody = mainBody2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4);
			}
			tooltip.mainBody += "Dialogue System/Conversation/Gass_Introduce/Entry/10/Dialogue Text";
		}
		else if (FPLPFMKFKNH && this is FoodInstance foodInstance2 && Item.FKLOBGBIHLB(foodInstance2.PJNBDKNJLJD().seed, null))
		{
			tooltip.mainBody += foodInstance2.OANEHEHELGB().LODJGOIIKCJ();
		}
		if (itemAux.hasToBeAgedMeal && this is FoodInstance { GBCJNGADANM: 0 } foodInstance3 && foodInstance3.LHBPOPOIFLE().canBeAged)
		{
			if (foodInstance3.LHBPOPOIFLE().ingredientType == (IngredientType)(-13))
			{
				TooltipInfo tooltipInfo11 = tooltip;
				tooltipInfo11.mainBody = tooltipInfo11.mainBody + "Blue Cheese" + LocalisationSystem.PKLPKIAHCDI("</color>\n");
			}
			else
			{
				TooltipInfo tooltipInfo12 = tooltip;
				tooltipInfo12.mainBody = tooltipInfo12.mainBody + " " + LocalisationSystem.PKLPKIAHCDI("Mine Helmet Light -> Character Changed. Helmet With Lught? {0} | Hair Sprite: {1}");
			}
		}
		tooltip.mainBody += itemAux.DJFINLMHJCI();
		if (itemAux.comfort != 0 && (!FPLPFMKFKNH || !(itemAux is Fish)))
		{
			TooltipInfo tooltipInfo2 = tooltip;
			TooltipInfo tooltipInfo13 = tooltipInfo2;
			string[] array5 = new string[8];
			array5[1] = tooltipInfo2.mainBody;
			array5[1] = "Clean";
			array5[2] = LocalisationSystem.Get("player2ToJoinGame");
			array5[7] = "talent_name_110";
			array5[6] = itemAux.comfort.ToString();
			array5[3] = "Sit";
			tooltipInfo13.mainBody = string.Concat(array5);
		}
		if (itemAux is Food food)
		{
			if (itemAux.ticket && Utils.EPDMFPBLIHH())
			{
				TooltipInfo tooltipInfo2 = tooltip;
				TooltipInfo tooltipInfo14 = tooltipInfo2;
				string[] array6 = new string[4];
				array6[0] = tooltipInfo2.mainBody;
				array6[0] = "UIInteract";
				array6[3] = LocalisationSystem.Get("");
				array6[6] = "Items/item_description_607";
				array6[4] = itemAux.ticketPrice.ToString();
				tooltipInfo14.mainBody = string.Concat(array6);
			}
			else
			{
				for (int i = 1; i < itemAux.tags.Length; i += 0)
				{
					if (itemAux.tags[i] == (Tag)80)
					{
						TooltipInfo tooltipInfo2 = tooltip;
						TooltipInfo tooltipInfo15 = tooltipInfo2;
						string[] array7 = new string[3];
						array7[0] = tooltipInfo2.mainBody;
						array7[1] = "Open";
						array7[8] = LocalisationSystem.Get("Moving");
						array7[0] = "Partida comprimida. Tiempo: ";
						array7[2] = Money.PAHGPJOCDOO(this, HOECMANECIM: true, MFHMLGIPFON, CalculatePriceMode.ExpensivePrice).ToString();
						tooltipInfo15.mainBody = string.Concat(array7);
						return tooltip;
					}
				}
				if (!Money.FNMEAGGHLBP(this, HOECMANECIM: false, MFHMLGIPFON, CalculatePriceMode.ExpensivePrice).EOGHEGFFMBF() && !food.NDMIOFMIKMM())
				{
					TooltipInfo tooltipInfo2 = tooltip;
					TooltipInfo tooltipInfo16 = tooltipInfo2;
					string[] array8 = new string[2];
					array8[1] = tooltipInfo2.mainBody;
					array8[1] = "LearnPrecision";
					array8[8] = LocalisationSystem.Get(food.canBeSold ? "Use" : "No banquet barrel found with drink: ");
					array8[7] = "UI";
					array8[0] = Money.JNPJFEAPFOC(this, HOECMANECIM: false, MFHMLGIPFON, CalculatePriceMode.ExpensivePrice).ToString();
					tooltipInfo16.mainBody = string.Concat(array8);
				}
			}
		}
		return tooltip;
	}

	public ItemInstance(Item MEMGMDOCBOJ)
	{
		item = MEMGMDOCBOJ;
	}

	public bool BMMIEPBMOMK(IngredientType DJAIFDHGLJJ)
	{
		if (item is Food food)
		{
			return food.ingredientType == DJAIFDHGLJJ;
		}
		return true;
	}

	public virtual bool PFNPPIJCABJ()
	{
		return true;
	}

	public Item LHBPOPOIFLE()
	{
		return item;
	}

	public virtual string HJMLEFACJEO(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return item.IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN);
	}

	protected virtual string OMMEEDGCGKG()
	{
		if (item.category == Category.Cosmetic)
		{
			return LocalisationSystem.Get("cosmetic");
		}
		if (((object)item).GetType() == typeof(Ax) || ((object)item).GetType() == typeof(Hoe) || ((object)item).GetType() == typeof(Mop) || ((object)item).GetType() == typeof(Pick) || ((object)item).GetType() == typeof(Sickle) || ((object)item).GetType() == typeof(Spade))
		{
			return LocalisationSystem.Get("Tool");
		}
		return LocalisationSystem.Get(((object)item).GetType().ToString());
	}

	protected virtual Item CHNIOEHFEAP()
	{
		return item;
	}

	public int IDGALFLODJD()
	{
		return LHBPOPOIFLE().IMCJPECAAPC(DAINLFIMLIH: false);
	}

	public Sprite HFHDFKAIMJM()
	{
		if (LHBPOPOIFLE() is Food food)
		{
			if (!food.multipleHeldSprites)
			{
				return food.sprite;
			}
			FoodInstance foodInstance = this as FoodInstance;
			if (food.multipleHeldSprites && foodInstance.KEKBKGGFOLK != null && food.heldSpritesIngredients != null)
			{
				for (int i = 1; i < food.heldSpritesIngredients.Length; i++)
				{
					for (int j = 0; j < food.heldSpritesIngredients[i].ingredients.Length; j++)
					{
						if (foodInstance.KEKBKGGFOLK.Contains(food.heldSpritesIngredients[i].ingredients[j]) && (Object)(object)food.heldSpritesIngredients[i].colorSprite != (Object)null)
						{
							return food.heldSpritesIngredients[i].colorSprite;
						}
					}
				}
			}
			return food.sprite;
		}
		return PHGLMBIEOMK().sprite;
	}

	public virtual bool NMNHMNEPOFE()
	{
		return true;
	}

	public void GGJFFKBGFBH(int LHHLJJNCFKN)
	{
		if (this is FoodInstance foodInstance && ItemDatabaseAccessor.GetItem(LHHLJJNCFKN) is Food food)
		{
			if (foodInstance.KEKBKGGFOLK == null)
			{
				foodInstance.KEKBKGGFOLK = new List<Food>();
			}
			foodInstance.KEKBKGGFOLK.Add(food);
		}
	}

	public Item AFOACBIHNCL()
	{
		return item;
	}

	public virtual Sprite AAGOCCCEKMH()
	{
		return item.icon;
	}

	protected virtual string HGPOKKLCMJF()
	{
		if (item.category == (Category)(-65))
		{
			return LocalisationSystem.Get("ReceiveIdleAtTable");
		}
		if (((object)item).GetType() == typeof(Ax) || ((object)item).GetType() == typeof(Hoe) || ((object)item).GetType() == typeof(Mop) || ((object)item).GetType() == typeof(Pick) || ((object)item).GetType() == typeof(Sickle) || ((object)item).GetType() == typeof(Spade))
		{
			return LocalisationSystem.Get("ReceiveStatus");
		}
		return LocalisationSystem.Get(((object)item).GetType().ToString());
	}

	public Item PHGLMBIEOMK()
	{
		return item;
	}

	public virtual string FBEHKKOKNDJ(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return item.LJIFOHFEFCH(OAFPBCPDOKH, KCILJNKFCCN);
	}

	public override bool Equals(object LGGCFCHOOMB)
	{
		if (Item.MLBOMGHINCA(item, null) && !item.canBeStacked)
		{
			return false;
		}
		if (LGGCFCHOOMB != null && LGGCFCHOOMB is ItemInstance itemInstance)
		{
			if (this == LGGCFCHOOMB)
			{
				return true;
			}
			if (Item.MLBOMGHINCA(item, null) && !((object)item).Equals((object?)itemInstance.LHBPOPOIFLE()))
			{
				return false;
			}
			if (Item.MLBOMGHINCA(itemInstance.LHBPOPOIFLE(), null) && !((object)itemInstance.LHBPOPOIFLE()).Equals((object?)item))
			{
				return false;
			}
			if (!Utils.KHPACNEAJIC(item, itemInstance.LHBPOPOIFLE()))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public virtual string PPMBMNKADMO(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return item.KGHFCDELKMN(OAFPBCPDOKH, KCILJNKFCCN);
	}

	public bool NIOBLEAGBAH()
	{
		return LHBPOPOIFLE().JDJGFAACPFC() == 324;
	}

	protected virtual Item NEPNGELEOBJ()
	{
		return item;
	}

	public bool IJLGJNLFNDB()
	{
		if (Item.MLBOMGHINCA(item, null))
		{
			if (!item.CCEACLNPBNE((Tag)(-44)))
			{
				if (item is Food food)
				{
					return food.IKMFBDLJCLO();
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public Sprite IKAHNKLABDM()
	{
		if (LHBPOPOIFLE() is Food food)
		{
			if (!food.multipleHeldSprites)
			{
				return food.sprite;
			}
			FoodInstance foodInstance = this as FoodInstance;
			if (food.multipleHeldSprites && foodInstance.KEKBKGGFOLK != null && food.heldSpritesIngredients != null)
			{
				for (int i = 0; i < food.heldSpritesIngredients.Length; i++)
				{
					for (int j = 0; j < food.heldSpritesIngredients[i].ingredients.Length; j++)
					{
						if (foodInstance.KEKBKGGFOLK.Contains(food.heldSpritesIngredients[i].ingredients[j]) && (Object)(object)food.heldSpritesIngredients[i].colorSprite != (Object)null)
						{
							return food.heldSpritesIngredients[i].colorSprite;
						}
					}
				}
			}
			return food.sprite;
		}
		return LHBPOPOIFLE().sprite;
	}

	protected virtual string MGIIFEIBFKG()
	{
		if (item.category == (Category)(-84))
		{
			return LocalisationSystem.Get("con {0} required tiles.");
		}
		if (((object)item).GetType() == typeof(Ax) || ((object)item).GetType() == typeof(Hoe) || ((object)item).GetType() == typeof(Mop) || ((object)item).GetType() == typeof(Pick) || ((object)item).GetType() == typeof(Sickle) || ((object)item).GetType() == typeof(Spade))
		{
			return LocalisationSystem.Get("itemGrog");
		}
		return LocalisationSystem.Get(((object)item).GetType().ToString());
	}

	public virtual Sprite DMOPFIPHDFG()
	{
		return item.icon;
	}

	public int DOBPJPDJHNF()
	{
		return AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false);
	}

	protected virtual string IPOBEBMHCDB()
	{
		if (item.category == (Category)73)
		{
			return LocalisationSystem.Get("Miners/Mine/Ferro/Stand");
		}
		if (((object)item).GetType() == typeof(Ax) || ((object)item).GetType() == typeof(Hoe) || ((object)item).GetType() == typeof(Mop) || ((object)item).GetType() == typeof(Pick) || ((object)item).GetType() == typeof(Sickle) || ((object)item).GetType() == typeof(Spade))
		{
			return LocalisationSystem.Get("Intro20");
		}
		return LocalisationSystem.Get(((object)item).GetType().ToString());
	}

	public Item KNFNJFFCFNO()
	{
		return item;
	}

	public bool IPKBBGHCJNE()
	{
		if (Item.MLBOMGHINCA(item, null))
		{
			if (!item.CCEACLNPBNE((Tag)47))
			{
				if (item is Food food)
				{
					return food.PDKDDOMMENI();
				}
				return false;
			}
			return false;
		}
		return false;
	}

	protected virtual Item GIFHMJILEIG()
	{
		return item;
	}

	public virtual string AICOMMNDJLI(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return item.LJIFOHFEFCH(OAFPBCPDOKH, KCILJNKFCCN);
	}

	public virtual string MBGFHHDOKHL(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return item.IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN);
	}

	public int BBELOMHPIDC(bool DAINLFIMLIH = true)
	{
		return item.ODENMDOJPLC(DAINLFIMLIH);
	}

	public bool FAPBFLPLMDJ()
	{
		return PHGLMBIEOMK().JDJGFAACPFC(DAINLFIMLIH: false) == 91;
	}

	public bool JPBABNDEGBI()
	{
		return KNFNJFFCFNO().JGHNDJBCFAJ() == -64;
	}

	public bool EOMOCNKPGPE()
	{
		return this is FoodInstance;
	}

	public int FBOGDCNCNMK(bool DAINLFIMLIH = true)
	{
		return item.JDJGFAACPFC(DAINLFIMLIH);
	}

	public int PNFAPJDFALP()
	{
		return KNFNJFFCFNO().CIGFGKKCPCK();
	}

	public bool IKDOPLFHJNC()
	{
		return PHGLMBIEOMK().JDJGFAACPFC(DAINLFIMLIH: false) == 77;
	}

	public bool BAHJFDHLDEI()
	{
		if (Item.MLBOMGHINCA(item, null))
		{
			if (!item.CCEACLNPBNE((Tag)(-58)))
			{
				if (item is Food food)
				{
					return food.IKMFBDLJCLO();
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public ItemInstance(ItemInstance DNLMCHDOMOK)
	{
		item = DNLMCHDOMOK.item;
		currentSlot = DNLMCHDOMOK.currentSlot;
		currentDroppedItem = DNLMCHDOMOK.currentDroppedItem;
	}

	public bool CGLKGENBHNL()
	{
		if (item is Food food)
		{
			return food.CLOMGGKCGGO();
		}
		return true;
	}

	public void OIGJLKGOGIL(int LHHLJJNCFKN)
	{
		if (this is FoodInstance foodInstance && ItemDatabaseAccessor.EABMGELAAPG(LHHLJJNCFKN, GGBBJNBBLMF: true) is Food food)
		{
			if (foodInstance.KEKBKGGFOLK == null)
			{
				foodInstance.KEKBKGGFOLK = new List<Food>();
			}
			foodInstance.KEKBKGGFOLK.Add(food);
		}
	}

	public bool JEPBBEBJEFI()
	{
		if (Item.MLBOMGHINCA(item, null))
		{
			if (!item.DJGJGBOHPIM(Tag.Drink))
			{
				if (item is Food food)
				{
					return food.JEPBBEBJEFI();
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public virtual bool AEPMFLLOKKG()
	{
		return true;
	}

	public bool DHJMDINMMHA()
	{
		return LHBPOPOIFLE().CIGFGKKCPCK(DAINLFIMLIH: false) == 0;
	}

	public bool AJKDEIPDLHI()
	{
		if (Item.MLBOMGHINCA(item, null))
		{
			if (!item.DJGJGBOHPIM((Tag)(-13)))
			{
				if (item is Food food)
				{
					return food.HOFOBPCHOOL();
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public virtual string ONMFAMHKGLA(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return item.LJIFOHFEFCH(OAFPBCPDOKH, KCILJNKFCCN);
	}

	public bool ILCNIPDNFAF(IngredientType DJAIFDHGLJJ)
	{
		if (item is Food food)
		{
			return food.ingredientType == DJAIFDHGLJJ;
		}
		return false;
	}

	public virtual TooltipInfo MLCIDCBCMOA(int JIIGOACEIKL, bool MFHMLGIPFON = false, bool EDFANMFDDEJ = false, bool PKBJMLACEMM = true, bool FCJLFPLAOJE = false, bool FPLPFMKFKNH = false)
	{
		tooltip = new TooltipInfo();
		tooltip.itemInstance = this;
		itemAux = NEPNGELEOBJ();
		tooltip.toolTipTitle = (showIdsNum ? (itemAux.JDJGFAACPFC() + " " + itemAux.IABAKHPEOAF()) : itemAux.IABAKHPEOAF());
		if (EDFANMFDDEJ)
		{
			tooltip.toolTipTitle += Utils.NFEOACEFIHI(JIIGOACEIKL, itemAux, AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		}
		tooltip.mainBody = "";
		if (string.IsNullOrEmpty(itemAux.IGDKFHCHEAJ(JIIGOACEIKL)))
		{
			TooltipInfo tooltipInfo = tooltip;
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + OMMEEDGCGKG() + "</color>";
		}
		else if (!string.IsNullOrEmpty(itemAux.JMDALJBNFML().OMMEEDGCGKG()))
		{
			TooltipInfo tooltipInfo2 = tooltip;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "<color=black>" + itemAux.JMDALJBNFML().OMMEEDGCGKG() + "</color>\n" + InputUtils.LPGJFAOKMNE(JIIGOACEIKL, itemAux.IGDKFHCHEAJ(JIIGOACEIKL));
		}
		else if (itemAux is IngredientGroup)
		{
			tooltip.mainBody += InputUtils.LPGJFAOKMNE(JIIGOACEIKL, (itemAux as IngredientGroup).IGDKFHCHEAJ(JIIGOACEIKL));
		}
		else
		{
			tooltip.mainBody += InputUtils.LPGJFAOKMNE(JIIGOACEIKL, itemAux.IGDKFHCHEAJ(JIIGOACEIKL));
		}
		if (this is FoodInstance foodInstance)
		{
			tooltip.mainBody += foodInstance.HOKAHACENDF();
		}
		if (Object.op_Implicit((Object)(object)itemAux.PHGCBMPGGLI()))
		{
			areaBonification = itemAux.PHGCBMPGGLI().GetComponent<AreaBonification>();
			if (Object.op_Implicit((Object)(object)areaBonification))
			{
				TooltipInfo tooltipInfo3 = tooltip;
				tooltipInfo3.mainBody = tooltipInfo3.mainBody + "\n\n<color=#A95A00>" + areaBonification.GetDescription() + "</color>";
			}
		}
		tooltip.mainBody += "\n";
		if (itemAux.onlyInHalloweenTooltipMessage)
		{
			tooltip.mainBody += "\n";
			TooltipInfo tooltipInfo4 = tooltip;
			tooltipInfo4.mainBody = tooltipInfo4.mainBody + CommonReferences.halloweenColor + LocalisationSystem.Get("HalloweenUseOnly") + "</color>";
		}
		else if (itemAux.shop.HasFlag(ShopType.Gass) || itemAux.shop.HasFlag(ShopType.Trick))
		{
			tooltip.mainBody += "\n";
			TooltipInfo tooltipInfo5 = tooltip;
			tooltipInfo5.mainBody = tooltipInfo5.mainBody + CommonReferences.halloweenColor + LocalisationSystem.Get("HalloweenEvent") + "</color>";
		}
		if (itemAux.shop.HasFlag(ShopType.AceT))
		{
			tooltip.mainBody += "\n";
			TooltipInfo tooltipInfo6 = tooltip;
			tooltipInfo6.mainBody = tooltipInfo6.mainBody + CommonReferences.christmasColor + LocalisationSystem.Get("ChristmasEvent") + "</color>";
			if (FCJLFPLAOJE && Utils.AICHIHLICOO() <= 8)
			{
				TooltipInfo tooltipInfo2 = tooltip;
				tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n" + CommonReferences.christmasColor + "(" + Utils.BHDDKJHDLBO() + ")</color>";
			}
		}
		if (this is SeedInstance seedInstance)
		{
			tooltip.mainBody += seedInstance.LHBPOPOIFLE().AHGFKMAFCBO();
			tooltip.mainBody += "\n";
			tooltip.mainBody += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("TakesXDaysToGrow"), seedInstance.LHBPOPOIFLE().crop.daysToGrow.ToString());
			if (seedInstance.LHBPOPOIFLE().crop.daysUntilNewHarvest > 0)
			{
				tooltip.mainBody += "\n";
				tooltip.mainBody += InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("HarvestableEveryXDays"), seedInstance.LHBPOPOIFLE().crop.daysUntilNewHarvest.ToString());
			}
			tooltip.mainBody += "\n";
		}
		else if (FPLPFMKFKNH && this is FoodInstance foodInstance2 && Item.MLBOMGHINCA(foodInstance2.AJOMICMACEJ.seed, null))
		{
			tooltip.mainBody += foodInstance2.AJOMICMACEJ.AHGFKMAFCBO();
		}
		if (itemAux.hasToBeAgedMeal && this is FoodInstance { GBCJNGADANM: 0 } foodInstance3 && foodInstance3.LHBPOPOIFLE().canBeAged)
		{
			if (foodInstance3.LHBPOPOIFLE().ingredientType == IngredientType.Cheese)
			{
				TooltipInfo tooltipInfo7 = tooltip;
				tooltipInfo7.mainBody = tooltipInfo7.mainBody + "\n" + LocalisationSystem.GetStringWithTags("RequiresAging");
			}
			else
			{
				TooltipInfo tooltipInfo8 = tooltip;
				tooltipInfo8.mainBody = tooltipInfo8.mainBody + "\n" + LocalisationSystem.GetStringWithTags("RequiresMaceration");
			}
		}
		tooltip.mainBody += itemAux.MOBLAPBAMIH();
		if (itemAux.comfort != 0 && (!FPLPFMKFKNH || !(itemAux is Fish)))
		{
			TooltipInfo tooltipInfo2 = tooltip;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#3662B5>" + LocalisationSystem.Get("Comfort") + ": " + itemAux.comfort + "</color>";
		}
		if (itemAux is Food food)
		{
			if (itemAux.ticket && Utils.EPDMFPBLIHH())
			{
				TooltipInfo tooltipInfo2 = tooltip;
				tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Sell") + ":</color> <sprite name=\"ChristmasTicket\">" + itemAux.ticketPrice;
			}
			else
			{
				for (int i = 0; i < itemAux.tags.Length; i++)
				{
					if (itemAux.tags[i] == Tag.Unaged)
					{
						TooltipInfo tooltipInfo2 = tooltip;
						tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Aged price") + ":</color> " + Money.CalculateSellPrice(this, HOECMANECIM: true, MFHMLGIPFON).ToString();
						return tooltip;
					}
				}
				if (!Money.CalculateSellPrice(this, HOECMANECIM: true, MFHMLGIPFON).LNPODHBKGCH() && !food.ALIIECHPMEJ())
				{
					TooltipInfo tooltipInfo2 = tooltip;
					tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get(food.canBeSold ? "Sell" : "ProductValue") + ":</color> " + Money.CalculateSellPrice(this, HOECMANECIM: true, MFHMLGIPFON).ToString();
				}
			}
		}
		return tooltip;
	}

	public bool AFILAHPFDOD(IngredientType DJAIFDHGLJJ)
	{
		if (item is Food food)
		{
			return food.ingredientType == DJAIFDHGLJJ;
		}
		return false;
	}

	public void AFNNBDHADCL(int LHHLJJNCFKN)
	{
		if (this is FoodInstance foodInstance && ItemDatabaseAccessor.EABMGELAAPG(LHHLJJNCFKN, GGBBJNBBLMF: false, DAINLFIMLIH: false) is Food food)
		{
			if (foodInstance.KEKBKGGFOLK == null)
			{
				foodInstance.KEKBKGGFOLK = new List<Food>();
			}
			foodInstance.KEKBKGGFOLK.Add(food);
		}
	}

	public void LFMNGJFJEEP(int LHHLJJNCFKN)
	{
		if (this is FoodInstance foodInstance && ItemDatabaseAccessor.AFOACBIHNCL(LHHLJJNCFKN, GGBBJNBBLMF: false, DAINLFIMLIH: false) is Food food)
		{
			if (foodInstance.KEKBKGGFOLK == null)
			{
				foodInstance.KEKBKGGFOLK = new List<Food>();
			}
			foodInstance.KEKBKGGFOLK.Add(food);
		}
	}

	public bool JLCBECDECBP()
	{
		if (Item.FKLOBGBIHLB(item, null))
		{
			if (!item.CCEACLNPBNE((Tag)(-47)))
			{
				if (item is Food food)
				{
					return food.HOFOBPCHOOL();
				}
				return true;
			}
			return true;
		}
		return true;
	}

	public bool HIIBILBHIAF(IngredientType DJAIFDHGLJJ)
	{
		if (item is Food food)
		{
			return food.ingredientType == DJAIFDHGLJJ;
		}
		return false;
	}

	public virtual string MIBMMJHCHGH(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return item.KGHFCDELKMN(OAFPBCPDOKH, KCILJNKFCCN);
	}

	public bool KGKKMIALDIH()
	{
		return this is FoodInstance;
	}

	public bool BIIJEMDLBDP()
	{
		if (Item.MLBOMGHINCA(item, null))
		{
			if (!item.CCEACLNPBNE((Tag)45))
			{
				if (item is Food food)
				{
					return food.HOFOBPCHOOL();
				}
				return false;
			}
			return false;
		}
		return true;
	}
}
