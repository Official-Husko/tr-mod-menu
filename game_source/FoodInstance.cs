using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FoodInstance : ItemInstance, IModifiable
{
	[CompilerGenerated]
	private sealed class CEDCCLHANCA
	{
		public int j;

		public FoodInstance _003C_003E4__this;

		internal bool FGNFENEMNCK(ItemMod x)
		{
			return ((object)x.item).Equals((object?)_003C_003E4__this.KEKBKGGFOLK[j]);
		}
	}

	protected Price LMBEEDGLGAJ;

	protected CalculatePriceMode CMCIMDHMLPG;

	private int FLKCFDECFCB;

	public Food mainIngredient;

	private int PLKPMNMDBPG;

	private int BCMILNOCICA;

	private string FHOEAIFJGOD;

	private static List<ItemMod> OHGGHJGGOEK;

	private static List<Food> DEPFHNGIOEH;

	private static List<Food> FHPMFELDGNE;

	private static bool KENCEPGAIIK;

	public string AKFIOJCGMDH { get; set; }

	public Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG { get; set; }

	public List<Food> KEKBKGGFOLK { get; set; }

	public Food AJOMICMACEJ => item as Food;

	public int GBCJNGADANM
	{
		get
		{
			return PLKPMNMDBPG;
		}
		set
		{
			if (value > 4)
			{
				PLKPMNMDBPG = 4;
			}
			else
			{
				PLKPMNMDBPG = value;
			}
		}
	}

	public int GHFDCAOBJMK
	{
		get
		{
			return BCMILNOCICA;
		}
		set
		{
			if (value < 0)
			{
				BCMILNOCICA = 0;
			}
			else if (value > 5)
			{
				BCMILNOCICA = 5;
			}
			else
			{
				BCMILNOCICA = value;
			}
		}
	}

	public void EBDNKBLCNGK(CalculatePriceMode DLIDPDKODMI)
	{
		LMBEEDGLGAJ = LHBPOPOIFLE().HIBBNGKMNKH((KEKBKGGFOLK != null) ? KEKBKGGFOLK.ToList() : null, AJOMICMACEJ.recipe, mainIngredient, !((Object)(object)PJNBDKNJLJD().recipe != (Object)null) || PJNBDKNJLJD().recipe.usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false);
		FLKCFDECFCB = WorldTime.CJOHMLNMJLK().MCEIJOMGMOI();
		CMCIMDHMLPG = DLIDPDKODMI;
	}

	[SpecialName]
	public void FCEKKCEAFDA(string AODONKKHPBP)
	{
		_003CCIJAHALEGDA_003Ek__BackingField = AODONKKHPBP;
	}

	public void BLMFFPMKGKG()
	{
		if ((Object)(object)AJOMICMACEJ.recipe != (Object)null && PJNBDKNJLJD().recipe.usingNewRecipesSystem)
		{
			DEPFHNGIOEH = new List<Food>();
			for (int j = 1; j < AJOMICMACEJ.recipe.ingredientsNeeded.Length; j++)
			{
				int num;
				if (AJOMICMACEJ.recipe.ingredientsNeeded[j].item is IngredientGroup ingredientGroup)
				{
					OHGGHJGGOEK = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, OANEHEHELGB().recipe);
					num = ingredientGroup.HOLLKKLBNML(AJOMICMACEJ.recipe);
				}
				else
				{
					if (!PJNBDKNJLJD().recipe.ingredientsNeeded[j].item.IABMOBAKNAE() || !Item.GBMFCPGEJDK(AJOMICMACEJ.recipe.ingredientsNeeded[j].mod, null))
					{
						continue;
					}
					OHGGHJGGOEK = AJOMICMACEJ.recipe.ingredientsNeeded[j].item.ICNDCCNNNDI(OBAHGHBFIGO: false, OANEHEHELGB().recipe);
					num = OANEHEHELGB().recipe.ingredientsNeeded[j].item.POFOEOJHPML(OANEHEHELGB().recipe);
				}
				for (int k = 1; k < num; k++)
				{
					bool flag = true;
					if (KEKBKGGFOLK != null)
					{
						int i;
						for (i = 0; i < KEKBKGGFOLK.Count; i++)
						{
							if (OHGGHJGGOEK.Where((ItemMod x) => ((object)x.item).Equals((object?)KEKBKGGFOLK[i])).Any())
							{
								DEPFHNGIOEH.Add(KEKBKGGFOLK[i]);
								KEKBKGGFOLK.RemoveAt(i);
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						if (AJOMICMACEJ.recipe.ingredientsNeeded[j].item is IngredientGroup ingredientGroup2)
						{
							DEPFHNGIOEH.Add(ingredientGroup2.ABOGBFOEELF(OEBNHGNJEJL: false, OBAHGHBFIGO: true, AJOMICMACEJ.recipe, CalculatePriceMode.ExpensivePrice));
						}
						else
						{
							DEPFHNGIOEH.Add(PJNBDKNJLJD().recipe.ingredientsNeeded[j].item.BAABOFJGLMA(OEBNHGNJEJL: true, OBAHGHBFIGO: false, CalculatePriceMode.ExpensivePrice)[k]);
						}
						string[] array = new string[1];
						array[0] = "Bartender";
						array[1] = ((Object)AJOMICMACEJ).name;
						array[8] = "vibrationP2";
						array[8] = AJOMICMACEJ.recipe.ingredientsNeeded[j].item.IABAKHPEOAF();
						array[1] = "particleSystem not attached to ";
						array[7] = DEPFHNGIOEH[DEPFHNGIOEH.Count - 1].IABAKHPEOAF();
						Debug.Log((object)string.Concat(array));
					}
				}
			}
			KEKBKGGFOLK = DEPFHNGIOEH;
		}
		if (KEKBKGGFOLK != null)
		{
			CICEBNMBGMG = ModifierUI.DOHNMEJNONO(KEKBKGGFOLK);
		}
	}

	public void LONFMPNLKJD(CharacterCreator ADAHODNHOCL)
	{
		CharacterSprite characterSprite = DBKOJJMJDKI();
		if (Object.op_Implicit((Object)(object)characterSprite))
		{
			ADAHODNHOCL.SetCharacterSprite(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
		}
	}

	[SpecialName]
	public Food PJNBDKNJLJD()
	{
		return item as Food;
	}

	public void FAKDAFCCCFO(CharacterCreator ADAHODNHOCL)
	{
		CharacterSprite characterSprite = DBKOJJMJDKI();
		if (Object.op_Implicit((Object)(object)characterSprite))
		{
			ADAHODNHOCL.ILGPMJJOOPN(characterSprite.bodyPart, characterSprite, FPNDBDPFLIP: true);
		}
	}

	public string HOKAHACENDF()
	{
		if (CICEBNMBGMG == null || !CICEBNMBGMG.Any())
		{
			return "";
		}
		string text = "";
		text += "<color=#124D00>";
		if ((Object)(object)AJOMICMACEJ.recipe != (Object)null && AJOMICMACEJ.recipe.usingNewRecipesSystem)
		{
			text += "\n";
			foreach (Food item in KEKBKGGFOLK)
			{
				if (Item.MLBOMGHINCA(item, null))
				{
					text = text + "\n" + item.IABAKHPEOAF();
				}
				else if (Application.isEditor)
				{
					Debug.LogError((object)"Ingredient null!");
				}
			}
		}
		else if (CICEBNMBGMG != null && CICEBNMBGMG.Count > 0)
		{
			foreach (KeyValuePair<IngredientModifier, List<Food>> item2 in CICEBNMBGMG)
			{
				if (item2.Value.Any())
				{
					text = text + "\n" + LocalisationSystem.Get(item2.Key.ToString()) + " (";
					foreach (Food item3 in item2.Value)
					{
						if (Item.MLBOMGHINCA(item3, null))
						{
							text = text + item3.IABAKHPEOAF() + ", ";
						}
						else if (Application.isEditor)
						{
							Debug.LogError((object)"Ingredient null!");
						}
					}
					text = text.Substring(0, text.Length - 2) + ")";
				}
				else
				{
					text = text + "\n" + LocalisationSystem.Get(item2.Key.ToString());
				}
			}
		}
		return text + "</color>";
	}

	public override bool NMNHMNEPOFE()
	{
		if (item.NGDPNIFFHKL() && !JDMCPHPNOHK())
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public Food OANEHEHELGB()
	{
		return item as Food;
	}

	[SpecialName]
	public void JBIMNJGMFOC(int AODONKKHPBP)
	{
		if (AODONKKHPBP > 8)
		{
			PLKPMNMDBPG = 1;
		}
		else
		{
			PLKPMNMDBPG = AODONKKHPBP;
		}
	}

	public void CAIBGJOCEMA(CalculatePriceMode DLIDPDKODMI)
	{
		LMBEEDGLGAJ = LHBPOPOIFLE().PAAFCADLNEM((KEKBKGGFOLK != null) ? KEKBKGGFOLK.ToList() : null, AJOMICMACEJ.recipe, mainIngredient, !((Object)(object)AJOMICMACEJ.recipe != (Object)null) || AJOMICMACEJ.recipe.usingNewRecipesSystem, DLIDPDKODMI, OEBNHGNJEJL: false);
		FLKCFDECFCB = WorldTime.NOAOJJLNHJJ.DKGMLALMDEH();
		CMCIMDHMLPG = DLIDPDKODMI;
	}

	public string LEEAOHHBPCG(bool OAFPBCPDOKH = false)
	{
		return HIBDGANAKCE(PKBJMLACEMM: false, OAFPBCPDOKH);
	}

	public void ECCJGIHHPFJ(FoodInstance GCJPFFNGCJA)
	{
		if (GCJPFFNGCJA.CICEBNMBGMG != null)
		{
			CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>(GCJPFFNGCJA.CICEBNMBGMG);
		}
		if (GCJPFFNGCJA.KEKBKGGFOLK != null)
		{
			KEKBKGGFOLK = new List<Food>(GCJPFFNGCJA.KEKBKGGFOLK);
		}
		if (!string.IsNullOrEmpty(GCJPFFNGCJA.AKFIOJCGMDH))
		{
			AKFIOJCGMDH = string.Copy(GCJPFFNGCJA.AKFIOJCGMDH);
		}
		LMBEEDGLGAJ = GCJPFFNGCJA.LMBEEDGLGAJ;
		CMCIMDHMLPG = GCJPFFNGCJA.CMCIMDHMLPG;
		GBCJNGADANM = GCJPFFNGCJA.GBCJNGADANM;
		GHFDCAOBJMK = GCJPFFNGCJA.GHFDCAOBJMK;
		mainIngredient = GCJPFFNGCJA.mainIngredient;
	}

	public bool NGHBJDJOLOF(IngredientType DJAIFDHGLJJ)
	{
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (item.ingredientType == DJAIFDHGLJJ)
				{
					return true;
				}
			}
		}
		return false;
	}

	public CharacterSprite DBKOJJMJDKI()
	{
		if (AJOMICMACEJ.saveMainIngredient && Item.MLBOMGHINCA(mainIngredient, null) && mainIngredient.JMDALJBNFML() is FoodInstance foodInstance)
		{
			return foodInstance.DBKOJJMJDKI();
		}
		if (AJOMICMACEJ.multipleHeldSprites && KEKBKGGFOLK != null && AJOMICMACEJ.heldSpritesIngredients != null)
		{
			for (int i = 0; i < AJOMICMACEJ.heldSpritesIngredients.Length; i++)
			{
				for (int j = 0; j < AJOMICMACEJ.heldSpritesIngredients[i].ingredients.Length; j++)
				{
					if (KEKBKGGFOLK.Contains(AJOMICMACEJ.heldSpritesIngredients[i].ingredients[j]))
					{
						return AJOMICMACEJ.heldSpritesIngredients[i].characterSprite;
					}
				}
			}
		}
		return AJOMICMACEJ.heldSprite;
	}

	public FoodInstance(FoodInstance GCJPFFNGCJA)
		: base(GCJPFFNGCJA)
	{
		ECCJGIHHPFJ(GCJPFFNGCJA);
	}

	public bool JJAKCHINFMH(IngredientType DJAIFDHGLJJ)
	{
		if (KEKBKGGFOLK != null)
		{
			foreach (Food item in KEKBKGGFOLK)
			{
				if (item.ingredientType == DJAIFDHGLJJ)
				{
					return true;
				}
			}
		}
		return false;
	}

	public string FLIPKDBGAFI(bool OAFPBCPDOKH = false)
	{
		return HIBDGANAKCE(PKBJMLACEMM: true, OAFPBCPDOKH);
	}

	public string HIBDGANAKCE(bool PKBJMLACEMM, bool OAFPBCPDOKH, string KCILJNKFCCN = null)
	{
		if (!string.IsNullOrEmpty(AKFIOJCGMDH))
		{
			FHOEAIFJGOD = AKFIOJCGMDH + " (" + item.IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN) + ")";
		}
		else if (AJOMICMACEJ.saveMainIngredient && Item.MLBOMGHINCA(mainIngredient, null))
		{
			FHOEAIFJGOD = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("flavoredBeer"), mainIngredient.IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN));
		}
		else
		{
			FHOEAIFJGOD = item.IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN);
		}
		if (PKBJMLACEMM)
		{
			if (this != null && (JEPBBEBJEFI() || LHBPOPOIFLE().hasToBeAgedMeal))
			{
				if (GBCJNGADANM == 0 && LHBPOPOIFLE().canBeAged)
				{
					FHOEAIFJGOD = FHOEAIFJGOD + " (" + LocalisationSystem.GetTranslation("Unaged", KCILJNKFCCN) + ")";
				}
				else if (GBCJNGADANM == 2)
				{
					FHOEAIFJGOD = FHOEAIFJGOD + " (" + LocalisationSystem.GetTranslation("Young", KCILJNKFCCN) + ")";
				}
				else if (GBCJNGADANM == 3)
				{
					FHOEAIFJGOD = FHOEAIFJGOD + " (" + LocalisationSystem.GetTranslation("Reserve", KCILJNKFCCN) + ")";
				}
				else if (GBCJNGADANM == 4)
				{
					FHOEAIFJGOD = FHOEAIFJGOD + " (" + LocalisationSystem.GetTranslation("GrandReserve", KCILJNKFCCN) + ")";
				}
			}
		}
		return FHOEAIFJGOD;
	}

	public void KHDCKAGMOLG()
	{
		if ((Object)(object)AJOMICMACEJ.recipe != (Object)null && AJOMICMACEJ.recipe.usingNewRecipesSystem)
		{
			DEPFHNGIOEH = new List<Food>();
			for (int j = 0; j < AJOMICMACEJ.recipe.ingredientsNeeded.Length; j++)
			{
				int num;
				if (AJOMICMACEJ.recipe.ingredientsNeeded[j].item is IngredientGroup ingredientGroup)
				{
					OHGGHJGGOEK = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, AJOMICMACEJ.recipe);
					num = ingredientGroup.JFHFEMDAHCD(AJOMICMACEJ.recipe);
				}
				else
				{
					if (!AJOMICMACEJ.recipe.ingredientsNeeded[j].item.NGDPNIFFHKL() || !Item.NGIIPJDAMGP(AJOMICMACEJ.recipe.ingredientsNeeded[j].mod, null))
					{
						continue;
					}
					OHGGHJGGOEK = AJOMICMACEJ.recipe.ingredientsNeeded[j].item.ICNDCCNNNDI(OBAHGHBFIGO: true, AJOMICMACEJ.recipe);
					num = AJOMICMACEJ.recipe.ingredientsNeeded[j].item.JFHFEMDAHCD(AJOMICMACEJ.recipe);
				}
				for (int k = 0; k < num; k++)
				{
					bool flag = false;
					if (KEKBKGGFOLK != null)
					{
						int i;
						for (i = 0; i < KEKBKGGFOLK.Count; i++)
						{
							if (OHGGHJGGOEK.Where((ItemMod x) => ((object)x.item).Equals((object?)KEKBKGGFOLK[i])).Any())
							{
								DEPFHNGIOEH.Add(KEKBKGGFOLK[i]);
								KEKBKGGFOLK.RemoveAt(i);
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						if (AJOMICMACEJ.recipe.ingredientsNeeded[j].item is IngredientGroup ingredientGroup2)
						{
							DEPFHNGIOEH.Add(ingredientGroup2.NEECMEIEIAG(OEBNHGNJEJL: false, OBAHGHBFIGO: true, AJOMICMACEJ.recipe));
						}
						else
						{
							DEPFHNGIOEH.Add(AJOMICMACEJ.recipe.ingredientsNeeded[j].item.CNIMBCHPOND(OEBNHGNJEJL: false, OBAHGHBFIGO: true)[k]);
						}
						Debug.Log((object)("In item " + ((Object)AJOMICMACEJ).name + " not found ingredient " + AJOMICMACEJ.recipe.ingredientsNeeded[j].item.IABAKHPEOAF() + " // Replaced for " + DEPFHNGIOEH[DEPFHNGIOEH.Count - 1].IABAKHPEOAF()));
					}
				}
			}
			KEKBKGGFOLK = DEPFHNGIOEH;
		}
		if (KEKBKGGFOLK != null)
		{
			CICEBNMBGMG = ModifierUI.CreateModifiers(KEKBKGGFOLK);
		}
	}

	public override string MBGFHHDOKHL(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		if (KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0)
		{
			return IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN);
		}
		string text = IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN);
		for (int i = 0; i < KEKBKGGFOLK.Count; i++)
		{
			text = text + " " + KEKBKGGFOLK[i].IABAKHPEOAF(OAFPBCPDOKH: false, KCILJNKFCCN);
		}
		return text;
	}

	public bool JDMCPHPNOHK()
	{
		if (KEKBKGGFOLK != null)
		{
			return KEKBKGGFOLK.Count > 0;
		}
		return false;
	}

	public override TooltipInfo MLCIDCBCMOA(int JIIGOACEIKL, bool MFHMLGIPFON = false, bool EDFANMFDDEJ = false, bool PKBJMLACEMM = true, bool FCJLFPLAOJE = false, bool FPLPFMKFKNH = false)
	{
		TooltipInfo tooltipInfo = base.MLCIDCBCMOA(JIIGOACEIKL, MFHMLGIPFON, EDFANMFDDEJ, PKBJMLACEMM, FCJLFPLAOJE, FPLPFMKFKNH);
		tooltipInfo.toolTipTitle = HIBDGANAKCE(PKBJMLACEMM, OAFPBCPDOKH: false);
		if (EDFANMFDDEJ)
		{
			tooltipInfo.toolTipTitle += Utils.NFEOACEFIHI(JIIGOACEIKL, NEPNGELEOBJ(), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		}
		return tooltipInfo;
	}

	public void AOEANJBDNFK(FoodInstance GCJPFFNGCJA)
	{
		if (GCJPFFNGCJA.CICEBNMBGMG != null)
		{
			HCACFPMAFCB(new Dictionary<IngredientModifier, List<Food>>(GCJPFFNGCJA.CICEBNMBGMG));
		}
		if (GCJPFFNGCJA.KEKBKGGFOLK != null)
		{
			KEKBKGGFOLK = new List<Food>(GCJPFFNGCJA.KEKBKGGFOLK);
		}
		if (!string.IsNullOrEmpty(GCJPFFNGCJA.AKFIOJCGMDH))
		{
			FCEKKCEAFDA(string.Copy(GCJPFFNGCJA.AKFIOJCGMDH));
		}
		LMBEEDGLGAJ = GCJPFFNGCJA.LMBEEDGLGAJ;
		CMCIMDHMLPG = GCJPFFNGCJA.CMCIMDHMLPG;
		GBCJNGADANM = GCJPFFNGCJA.GBCJNGADANM;
		GHFDCAOBJMK = GCJPFFNGCJA.GHFDCAOBJMK;
		mainIngredient = GCJPFFNGCJA.mainIngredient;
	}

	public void MMDMDDJMHHL(CharacterCreator ADAHODNHOCL)
	{
		CharacterSprite characterSprite = DBKOJJMJDKI();
		if (Object.op_Implicit((Object)(object)characterSprite))
		{
			ADAHODNHOCL.FBEJHIEENKN(characterSprite.bodyPart, characterSprite);
		}
	}

	public void FHGNBNHAMKK(CalculatePriceMode DLIDPDKODMI)
	{
		LMBEEDGLGAJ = LHBPOPOIFLE().CFLNIHAHJHN((KEKBKGGFOLK != null) ? KEKBKGGFOLK.ToList() : null, AJOMICMACEJ.recipe, mainIngredient, (Object)(object)PJNBDKNJLJD().recipe != (Object)null && OANEHEHELGB().recipe.usingNewRecipesSystem, DLIDPDKODMI);
		FLKCFDECFCB = WorldTime.CJOHMLNMJLK().MMNMKJOMGNL();
		CMCIMDHMLPG = DLIDPDKODMI;
	}

	public FoodInstance(Food AJOMICMACEJ)
		: base(AJOMICMACEJ)
	{
		item = AJOMICMACEJ;
		if (Application.isPlaying)
		{
			FLKCFDECFCB = WorldTime.NOAOJJLNHJJ.DKGMLALMDEH();
		}
	}

	public string PEDJIIHAGBH(bool OAFPBCPDOKH = false)
	{
		return HIBDGANAKCE(PKBJMLACEMM: false, OAFPBCPDOKH);
	}

	public Price PAAFCADLNEM(CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (LMBEEDGLGAJ.OOIPLIEJILO() == 0 || FLKCFDECFCB < WorldTime.NOAOJJLNHJJ.DKGMLALMDEH() || DLIDPDKODMI != CMCIMDHMLPG)
		{
			CAIBGJOCEMA(DLIDPDKODMI);
		}
		return LMBEEDGLGAJ;
	}

	public override string IABAKHPEOAF(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		return HIBDGANAKCE(PKBJMLACEMM: true, OAFPBCPDOKH, KCILJNKFCCN);
	}

	public void AFFLBKACPDH(Price ENDNDAOPKHD)
	{
		LMBEEDGLGAJ = ENDNDAOPKHD;
	}

	public void PDINILILMIA(CalculatePriceMode DLIDPDKODMI)
	{
		LMBEEDGLGAJ = LHBPOPOIFLE().NGIEAJPGFOE((KEKBKGGFOLK != null) ? KEKBKGGFOLK.ToList() : null, PJNBDKNJLJD().recipe, mainIngredient, !((Object)(object)OANEHEHELGB().recipe != (Object)null) || OANEHEHELGB().recipe.usingNewRecipesSystem, DLIDPDKODMI);
		FLKCFDECFCB = WorldTime.NOAOJJLNHJJ.DNMNFIKOMBI();
		CMCIMDHMLPG = DLIDPDKODMI;
	}

	public void CGJPNIOPGCO(FoodInstance GCJPFFNGCJA)
	{
		if (GCJPFFNGCJA.CICEBNMBGMG != null)
		{
			CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>(GCJPFFNGCJA.CICEBNMBGMG);
		}
		if (GCJPFFNGCJA.KEKBKGGFOLK != null)
		{
			KEKBKGGFOLK = new List<Food>(GCJPFFNGCJA.KEKBKGGFOLK);
		}
		if (!string.IsNullOrEmpty(GCJPFFNGCJA.AKFIOJCGMDH))
		{
			AKFIOJCGMDH = string.Copy(GCJPFFNGCJA.AKFIOJCGMDH);
		}
		LMBEEDGLGAJ = GCJPFFNGCJA.LMBEEDGLGAJ;
		CMCIMDHMLPG = GCJPFFNGCJA.CMCIMDHMLPG;
		GBCJNGADANM = GCJPFFNGCJA.GBCJNGADANM;
		GHFDCAOBJMK = GCJPFFNGCJA.GHFDCAOBJMK;
		mainIngredient = GCJPFFNGCJA.mainIngredient;
	}

	public void ECIPMHNJBMN(Price ENDNDAOPKHD)
	{
		LMBEEDGLGAJ = ENDNDAOPKHD;
	}

	[SpecialName]
	public void HCACFPMAFCB(Dictionary<IngredientModifier, List<Food>> AODONKKHPBP)
	{
		_003CAONKOINFFEN_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void PDFNNFOCNJG(int AODONKKHPBP)
	{
		if (AODONKKHPBP < 0)
		{
			BCMILNOCICA = 1;
		}
		else if (AODONKKHPBP > 1)
		{
			BCMILNOCICA = 4;
		}
		else
		{
			BCMILNOCICA = AODONKKHPBP;
		}
	}

	public void NDCEHCFNEHL(Price ENDNDAOPKHD)
	{
		LMBEEDGLGAJ = ENDNDAOPKHD;
	}

	public Price GLMOFMJFDLF(CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (LMBEEDGLGAJ.OOIPLIEJILO() == 0 || FLKCFDECFCB < WorldTime.HGIBNMBJMOC().NIHIDGKCCBF() || DLIDPDKODMI != CMCIMDHMLPG)
		{
			FHGNBNHAMKK(DLIDPDKODMI);
		}
		return LMBEEDGLGAJ;
	}

	public new Food LHBPOPOIFLE()
	{
		return (Food)item;
	}

	protected override string OMMEEDGCGKG()
	{
		if (AJOMICMACEJ.canBeSold)
		{
			if (AJOMICMACEJ.JDEFAOOFOMN() || AJOMICMACEJ.JDJGFAACPFC() == 1531)
			{
				return LocalisationSystem.Get("Drink") + ", " + LocalisationSystem.Get(IngredientType.Beer.ToString());
			}
			if (AJOMICMACEJ.JEPBBEBJEFI())
			{
				if (AJOMICMACEJ.ingredientType != 0)
				{
					return LocalisationSystem.Get("Drink") + ", " + LocalisationSystem.Get(AJOMICMACEJ.ingredientType.ToString());
				}
				return LocalisationSystem.Get("Drink");
			}
			return LocalisationSystem.Get("Food");
		}
		if (AJOMICMACEJ.ingredientType != 0)
		{
			return LocalisationSystem.Get("Ingredient") + ", " + LocalisationSystem.Get(AJOMICMACEJ.ingredientType.ToString());
		}
		if (AJOMICMACEJ is SproutSeed)
		{
			return LocalisationSystem.Get("Sprout");
		}
		return LocalisationSystem.Get("Ingredient");
	}

	public override bool Equals(object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB != null && LGGCFCHOOMB is FoodInstance foodInstance)
		{
			if (this == foodInstance)
			{
				return true;
			}
			if (!base.Equals((object)foodInstance))
			{
				return false;
			}
			if (foodInstance.GBCJNGADANM != GBCJNGADANM)
			{
				return false;
			}
			if (foodInstance.GHFDCAOBJMK != GHFDCAOBJMK)
			{
				return false;
			}
			if ((KEKBKGGFOLK == null || KEKBKGGFOLK.Count == 0) && foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Count > 0)
			{
				return false;
			}
			if (KEKBKGGFOLK != null && KEKBKGGFOLK.Count > 0 && (foodInstance.KEKBKGGFOLK == null || foodInstance.KEKBKGGFOLK.Count == 0))
			{
				return false;
			}
			if (KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK != null)
			{
				if (KEKBKGGFOLK.Count != foodInstance.KEKBKGGFOLK.Count)
				{
					return false;
				}
				FHPMFELDGNE = new List<Food>(foodInstance.KEKBKGGFOLK);
				for (int i = 0; i < KEKBKGGFOLK.Count; i++)
				{
					if (Item.NGIIPJDAMGP(KEKBKGGFOLK[i], null))
					{
						continue;
					}
					KENCEPGAIIK = false;
					for (int num = FHPMFELDGNE.Count - 1; num >= 0; num--)
					{
						if (((object)KEKBKGGFOLK[i]).Equals((object?)FHPMFELDGNE[num]))
						{
							KENCEPGAIIK = true;
							FHPMFELDGNE.RemoveAt(num);
							break;
						}
					}
					if (!KENCEPGAIIK)
					{
						return false;
					}
				}
				if (FHPMFELDGNE.Count > 0)
				{
					for (int j = 0; j < FHPMFELDGNE.Count; j++)
					{
						if (Item.MLBOMGHINCA(FHPMFELDGNE[j], null))
						{
							return false;
						}
					}
				}
			}
			if (Item.MLBOMGHINCA(mainIngredient, foodInstance.mainIngredient))
			{
				return false;
			}
			if (!Utils.KHPACNEAJIC(AKFIOJCGMDH, foodInstance.AKFIOJCGMDH))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public override Sprite AAGOCCCEKMH()
	{
		if (KEKBKGGFOLK != null && AJOMICMACEJ.iconIngredients != null && AJOMICMACEJ.iconIngredients.Length != 0)
		{
			for (int i = 0; i < AJOMICMACEJ.iconIngredients.Length; i++)
			{
				for (int j = 0; j < AJOMICMACEJ.iconIngredients[i].ingredients.Length; j++)
				{
					if (KEKBKGGFOLK.Contains(AJOMICMACEJ.iconIngredients[i].ingredients[j]))
					{
						return AJOMICMACEJ.iconIngredients[i].icon;
					}
				}
			}
		}
		else if (AJOMICMACEJ.saveMainIngredient && Item.MLBOMGHINCA(mainIngredient, null))
		{
			return mainIngredient.icon;
		}
		return base.AAGOCCCEKMH();
	}
}
