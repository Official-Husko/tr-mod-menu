using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Ingredient Group")]
public class IngredientGroup : Item
{
	[CompilerGenerated]
	private sealed class DEHNBGIEFFG
	{
		public Food finalIngredient;

		internal bool EDNAOPECOFA(ItemMod x)
		{
			return ((object)x.item).Equals((object?)finalIngredient);
		}
	}

	[CompilerGenerated]
	private sealed class ADJJECJKMIN
	{
		public Food finalIngredient;

		public Func<ItemMod, bool> _003C_003E9__0;

		internal bool LCGKHGIBBPC(ItemMod x)
		{
			return ((object)x.item).Equals((object?)finalIngredient);
		}
	}

	[CompilerGenerated]
	private sealed class FHMKFDPLKFN
	{
		public Recipe mainRecipe;

		internal bool GJJCMGBKLJD(ItemMod x)
		{
			return !mainRecipe.excludeIngredients.Contains(x.item);
		}
	}

	public bool canBeSoldFood;

	public IngredientType[] ingredientsTypes;

	[SerializeField]
	private List<ItemMod> possibleItems;

	[SerializeField]
	private ItemMod cheapestIngredient;

	private static ItemMod itemModAux;

	private List<Food> foodList;

	private Food foodAux;

	public Price OBNKBOAPJAD(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.DHMGJGHCCJD(Mathf.Max(1, Price.MGDGPDBBMNA(Price.LFJHHLGOCPP(price, 1673f), amount).OOIPLIEJILO()));
	}

	public Food NACLIDDDHFB(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("quest_description_28" + IABAKHPEOAF() + "[OfferingStatuePuzzle] FillOfferingSlotFromNetwork: item {0} not found."));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.MOALFFDILOL(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.NGDPNIFFHKL())
		{
			List<Food> list2 = list[1].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)(" " + list[0].item.LJIFOHFEFCH(OAFPBCPDOKH: true)));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.GCMCKEGDHGP(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.JGJLNHAKJIJ()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.DFMJDEBBJPH(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.HHOCDHGJEFH(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).BNCMDNFMECD() < price.BNCMDNFMECD())
				{
					price = food2.HIBBNGKMNKH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.NGIEAJPGFOE(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice).OOIPLIEJILO() > price.JHKPNCOMAHI())
			{
				price = food2.CFLNIHAHJHN(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.GCMCKEGDHGP(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
		}
		return food;
	}

	public bool GPJGMICOKBC(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public bool LDALPIBPEMP(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	private void PLJFDKKONCA(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.IABMOBAKNAE())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public bool GNNMJKGLDOK(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Food OMJHOJALMAO(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.AGFIIGGGBHC())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Items/item_description_1040" + IABAKHPEOAF() + " "));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.ALMJHCJKCBB(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.JGJLNHAKJIJ())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("Y" + list[0].item.KGHFCDELKMN()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.HMCJLHECPDL(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.JGJLNHAKJIJ()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.HIILAHFPJKD(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.GLMOFMJFDLF(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice).OOIPLIEJILO() < price.OOIPLIEJILO())
				{
					price = food2.OCBCNMJMCJI(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice).OOIPLIEJILO() > price.OOIPLIEJILO())
			{
				price = food2.FKJGKLNIEMA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.GLMOFMJFDLF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public bool GKJBOLPFGGN(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Price HJKLPCCGGHH(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.OMDBJINNHPC(Mathf.Max(0, Price.LEBKIMOAAKB(Price.MPPPFDKJGNI(price, 1807f), amount).OOIPLIEJILO()));
	}

	public Food GMGIIBDEHDJ(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Direction" + LJIFOHFEFCH() + "add item 1447 20"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.PBMFCFCKCBL(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.IABMOBAKNAE())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("Resolucion nativa: " + list[1].item.KGHFCDELKMN()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.EIGDFMNOEBK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
		for (int i = 0; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.AGFIIGGGBHC()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.OMJHOJALMAO(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.NBIEMNNCGLE(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice).OOIPLIEJILO() < price.BNCMDNFMECD())
				{
					price = food2.NGIEAJPGFOE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.GLMOFMJFDLF(null, null).JHKPNCOMAHI() > price.JHKPNCOMAHI())
			{
				price = food2.HHOCDHGJEFH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HJKLPCCGGHH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public void NIJFMHNJEPL(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null);
		for (int i = 1; i < list.Count; i++)
		{
			string text = list[i].item.IABAKHPEOAF(OAFPBCPDOKH: true);
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + "itemBarley" + list[i].mod.IABAKHPEOAF() + "</color>";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "";
			}
			Debug.Log((object)text);
		}
	}

	public Food OANDHCCHPMP(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Example Method With Custom ID" + KGHFCDELKMN(OAFPBCPDOKH: true) + "itemDarkMaltedBarley"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.NACLIDDDHFB(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.JGJLNHAKJIJ())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("BarnBlocked" + list[0].item.IABAKHPEOAF()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.HMCJLHECPDL(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1]) : ingredientGroup2.NAEJCDOFHFL(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.NMNEOIPJNDA(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice).OOIPLIEJILO() < price.BNCMDNFMECD())
				{
					price = food2.NBIEMNNCGLE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
					food = food2;
				}
			}
			else if (food2.FKJGKLNIEMA(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).JHKPNCOMAHI() > price.BNCMDNFMECD())
			{
				price = food2.IHIGCCEBHDK(null, KMNOGHMAAEK);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public Food ODGDNFGOLGM(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (Item.EKGNIODFJCO(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.IABMOBAKNAE() && (from x in list[i].item.DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	private void OPFJEINDCPN(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.IABMOBAKNAE())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Food BNNMKKJMNNI(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.IABMOBAKNAE())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)(" (" + IABAKHPEOAF() + "Items/item_description_1152"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.HGKMAOLNLBA(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.JGJLNHAKJIJ())
		{
			List<Food> list2 = list[0].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("Error_NoDogFood" + list[1].item.LJIFOHFEFCH()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.NGIEAJPGFOE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 0; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.JGJLNHAKJIJ()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.KNGABAFDJGG(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.NGIEAJPGFOE(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice).OOIPLIEJILO() < price.OOIPLIEJILO())
				{
					price = food2.NBIEMNNCGLE(null, KMNOGHMAAEK);
					food = food2;
				}
			}
			else if (food2.NMNEOIPJNDA(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).BNCMDNFMECD() > price.BNCMDNFMECD())
			{
				price = food2.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HIBBNGKMNKH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
		}
		return food;
	}

	public Food CLACOGANHMM(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("in" + IABAKHPEOAF() + "UIInteract"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.NEECMEIEIAG(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.IABMOBAKNAE())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("Down Arrow" + list[1].item.IABAKHPEOAF()));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
		for (int i = 0; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.KGHINFMFNNP(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice).OOIPLIEJILO() < price.BNCMDNFMECD())
				{
					price = food2.OCIIAEAMJAH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.PAAFCADLNEM(null, null).JHKPNCOMAHI() > price.OOIPLIEJILO())
			{
				price = food2.NMNEOIPJNDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HJKLPCCGGHH(null, KMNOGHMAAEK);
		}
		return food;
	}

	public Price HIMHEJHPFKJ(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.HNDGIKFAKNC(Mathf.Max(0, Price.MGDGPDBBMNA(Price.LBOFJOBAGKA(price, 1334f), amount).OOIPLIEJILO()));
	}

	public bool ICGIKPCJKLF(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public void MCJPOKMCIGO(bool DHBKKANAIML)
	{
		List<ItemMod> list = DLKEJMGALGP(DHBKKANAIML, null);
		for (int i = 1; i < list.Count; i++)
		{
			string text = list[i].item.LJIFOHFEFCH();
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "StartEvent can only be called in play mode." + list[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + "\n<color=#A95A00>";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Dialogue System/Conversation/Crowly_Standar/Entry/18/Dialogue Text";
			}
			Debug.Log((object)text);
		}
	}

	public bool LDJHBPILGHH(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public bool OPEAAHFCLON(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public bool INCABDHOIIP(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	private void DKPOCDFNCCJ(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.IABMOBAKNAE())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Food NELKKJLGHIJ(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK);
		for (int i = 0; i < list.Count; i++)
		{
			if (Item.NGIIPJDAMGP(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Price PLHGJMHBPNO(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.LEDHAKFAHCI(Mathf.Max(1, Price.LEBKIMOAAKB(Price.MMCDFKKJOHE(price, 1389f), amount).OOIPLIEJILO()));
	}

	public Food PBMFCFCKCBL(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.AGFIIGGGBHC())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("river" + KGHFCDELKMN() + "ReceiveEnableTrigger"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.LJLEOICPGGI(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.JGJLNHAKJIJ())
		{
			List<Food> list2 = list[1].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("Select" + list[1].item.KGHFCDELKMN()));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.NBIEMNNCGLE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.JGJLNHAKJIJ()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1]) : ingredientGroup2.LJLEOICPGGI(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.OCBCNMJMCJI(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).BNCMDNFMECD() < price.OOIPLIEJILO())
				{
					price = food2.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.OCBCNMJMCJI(null, null, null, CGDEPNDEBIH: false).OOIPLIEJILO() > price.OOIPLIEJILO())
			{
				price = food2.NGIEAJPGFOE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public Food LGPLOJJLLBF(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.AGFIIGGGBHC())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Tutorial/BarnExitBarks_Holly" + IABAKHPEOAF(OAFPBCPDOKH: true) + "Invalid playerNum"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.ALMJHCJKCBB(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.IABMOBAKNAE())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/6/Dialogue Text" + list[0].item.IABAKHPEOAF(OAFPBCPDOKH: true)));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.IABMOBAKNAE()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.MKKFFHJLNHK(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.PAAFCADLNEM(null, null, null, CGDEPNDEBIH: false).OOIPLIEJILO() < price.OOIPLIEJILO())
				{
					price = food2.CFLNIHAHJHN(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: false).JHKPNCOMAHI() > price.JHKPNCOMAHI())
			{
				price = food2.KLNJNIMFINK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.OCBCNMJMCJI(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public Food OPDCKMPMJJB(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i++)
		{
			if (Item.GBMFCPGEJDK(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.JGJLNHAKJIJ() && (from x in list[i].item.DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public bool DJLCJICIILB(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Price JEHCJCLNNIH(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.HNDGIKFAKNC(Mathf.Max(1, Price.MGDGPDBBMNA(Price.EMJKENIECGH(price, 1225f), amount).OOIPLIEJILO()));
	}

	public Food HIILAHFPJKD(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.AGFIIGGGBHC())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)("F1" + IABAKHPEOAF() + "ReceiveBathhouseEntranceEventLeftBathhouse"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.PBMFCFCKCBL(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.NGDPNIFFHKL())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("MothersRecipe/MainEvent" + list[0].item.IABAKHPEOAF()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.HIBBNGKMNKH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
		for (int i = 0; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.MKKFFHJLNHK(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.FKJGKLNIEMA(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).JHKPNCOMAHI() < price.OOIPLIEJILO())
				{
					price = food2.HIBBNGKMNKH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.PAAFCADLNEM(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice).JHKPNCOMAHI() > price.BNCMDNFMECD())
			{
				price = food2.NMNEOIPJNDA(null, KMNOGHMAAEK);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.NBIEMNNCGLE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
		}
		return food;
	}

	private void OJCGGABJBDI(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.JGJLNHAKJIJ())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Price OONOIPPDJJD(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.OMDBJINNHPC(Mathf.Max(1, Price.CGGHNDOANLA(Price.FAFHFJGOHPK(price, 902f), amount).JHKPNCOMAHI()));
	}

	public Food JIHDKNINMBO(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			if (Item.EKGNIODFJCO(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Price NKLPLONEDIG(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.OMDBJINNHPC(Mathf.Max(1, Price.LEBKIMOAAKB(Price.CBCAAHPFLGO(price, 1387f), amount).BNCMDNFMECD()));
	}

	public Food NCLFAJBGOOP(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.JGJLNHAKJIJ())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Use" + IABAKHPEOAF(OAFPBCPDOKH: true) + "ReceiveEntryAllAnimals"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.KGHINFMFNNP(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.AGFIIGGGBHC())
		{
			List<Food> list2 = list[0].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("The mine piece " + list[0].item.KGHFCDELKMN(OAFPBCPDOKH: true)));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.HJKLPCCGGHH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
		for (int i = 1; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.KNGABAFDJGG(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() < price.BNCMDNFMECD())
				{
					price = food2.GCMCKEGDHGP(null, KMNOGHMAAEK);
					food = food2;
				}
			}
			else if (food2.PAAFCADLNEM(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).JHKPNCOMAHI() > price.JHKPNCOMAHI())
			{
				price = food2.NMNEOIPJNDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HIBBNGKMNKH(null, KMNOGHMAAEK);
		}
		return food;
	}

	public Price NHKJHHBIPDC(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.OMDBJINNHPC(Mathf.Max(0, Price.CGGHNDOANLA(Price.MPPPFDKJGNI(price, 1254f), amount).OOIPLIEJILO()));
	}

	public bool GNCGGOMHALJ(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Food GOOHPGICFIF(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (Item.GBMFCPGEJDK(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Food DFMJDEBBJPH(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Chair" + LJIFOHFEFCH(OAFPBCPDOKH: true) + ""));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.MOALFFDILOL(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.JGJLNHAKJIJ())
		{
			List<Food> list2 = list[1].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("Selected" + list[0].item.LJIFOHFEFCH()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.CCOJHEOLBDA(null, KMNOGHMAAEK);
		for (int i = 0; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.JGJLNHAKJIJ()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.PPDBNGKAHNA(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.NGIEAJPGFOE(null, null).JHKPNCOMAHI() < price.BNCMDNFMECD())
				{
					price = food2.KLNJNIMFINK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.HJKLPCCGGHH(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice).BNCMDNFMECD() > price.BNCMDNFMECD())
			{
				price = food2.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.NBIEMNNCGLE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	private void NJCHJHEGCNN(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.AGFIIGGGBHC())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Food NAEJCDOFHFL(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.IABMOBAKNAE())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("MineState" + KGHFCDELKMN() + "Items/item_description_662"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.OHGDLPOMINA(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.NGDPNIFFHKL())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("Right" + list[1].item.LJIFOHFEFCH()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.GLMOFMJFDLF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.AGFIIGGGBHC()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1]) : ingredientGroup2.HIILAHFPJKD(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).OOIPLIEJILO() < price.OOIPLIEJILO())
				{
					price = food2.NBIEMNNCGLE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
					food = food2;
				}
			}
			else if (food2.HIBBNGKMNKH(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).JHKPNCOMAHI() > price.OOIPLIEJILO())
			{
				price = food2.HMCJLHECPDL(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.NMNEOIPJNDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
		}
		return food;
	}

	public bool ODLFLEICEMN(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Food HGKMAOLNLBA(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.IABMOBAKNAE())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)(". AllMovement: " + LJIFOHFEFCH(OAFPBCPDOKH: true) + "On Simple Event "));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.FDCGADKEDAP(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.AGFIIGGGBHC())
		{
			List<Food> list2 = list[1].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("Idle" + list[1].item.KGHFCDELKMN(OAFPBCPDOKH: true)));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.IHIGCCEBHDK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		for (int i = 0; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.LJLEOICPGGI(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.KLNJNIMFINK(null, null, null, CGDEPNDEBIH: false).OOIPLIEJILO() < price.JHKPNCOMAHI())
				{
					price = food2.NGIEAJPGFOE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.HNGJEIKLDIF(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice).BNCMDNFMECD() > price.OOIPLIEJILO())
			{
				price = food2.KLNJNIMFINK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.GCMCKEGDHGP(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public bool ICBOAFKOOEK(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Price GCMCKEGDHGP(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.IFMFKEMHHLM(Mathf.Max(1, Price.MGDGPDBBMNA(Price.LFJHHLGOCPP(price, 1982f), amount).JHKPNCOMAHI()));
	}

	public bool HDPKMGAMHHK(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Food LMBPOOOLOJB(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i++)
		{
			if (Item.GBMFCPGEJDK(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Price CFLNIHAHJHN(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.DHMGJGHCCJD(Mathf.Max(1, Price.LEBKIMOAAKB(Price.MMCDFKKJOHE(price, 1431f), amount).OOIPLIEJILO()));
	}

	public void IDEEOKIJPDN(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.IABAKHPEOAF();
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + "[" + list[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + "ReceiveBuildingTutorialDone";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Arguing";
			}
			Debug.Log((object)text);
		}
	}

	private void ONAJNGOFMNB(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.NGDPNIFFHKL())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public void HJELCLPPDGF(bool DHBKKANAIML)
	{
		List<ItemMod> list = ICNDCCNNNDI(DHBKKANAIML, null);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true);
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "" + list[i].mod.IABAKHPEOAF() + "SteamManager";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Hide UI";
			}
			Debug.Log((object)text);
		}
	}

	public Price CHJCOAFEKMH(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.LEDHAKFAHCI(Mathf.Max(0, Price.CGGHNDOANLA(Price.CBCAAHPFLGO(price, 1634f), amount).OOIPLIEJILO()));
	}

	private void LJINNJDCLGL(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.NGDPNIFFHKL())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	private void CEDBNNKPGPC(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.JGJLNHAKJIJ())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Price IFAIHIDPCKP(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.GHDCKOJGAMM(Mathf.Max(1, Price.MGDGPDBBMNA(Price.LFJHHLGOCPP(price, 882f), amount).BNCMDNFMECD()));
	}

	public Food PLBANLOFKAJ(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			if (Item.NGIIPJDAMGP(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.AGFIIGGGBHC() && (from x in list[i].item.DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Price MBMNDNKFECE(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.LEDHAKFAHCI(Mathf.Max(1, Price.MGDGPDBBMNA(Price.CBCAAHPFLGO(price, 1476f), amount).BNCMDNFMECD()));
	}

	public Food ABOGBFOEELF(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.IABMOBAKNAE())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Jose D" + IABAKHPEOAF(OAFPBCPDOKH: true) + "Favorites"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.HIILAHFPJKD(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.NGDPNIFFHKL())
		{
			List<Food> list2 = list[1].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("" + list[1].item.KGHFCDELKMN(OAFPBCPDOKH: true)));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.IHIGCCEBHDK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
		for (int i = 0; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.IABMOBAKNAE()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.NAEJCDOFHFL(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.HNGJEIKLDIF(null, null, null, CGDEPNDEBIH: false).JHKPNCOMAHI() < price.BNCMDNFMECD())
				{
					price = food2.NGIEAJPGFOE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.NBIEMNNCGLE(null, null).OOIPLIEJILO() > price.BNCMDNFMECD())
			{
				price = food2.HIBBNGKMNKH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.PAAFCADLNEM(null, KMNOGHMAAEK);
		}
		return food;
	}

	public Food MGJKNDNFFGK(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.IABMOBAKNAE())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Player2" + KGHFCDELKMN(OAFPBCPDOKH: true) + "ReceiveAnimalFeederSlotPressed"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.ALMJHCJKCBB(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.JGJLNHAKJIJ())
		{
			List<Food> list2 = list[1].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("Attack/MainEvent" + list[0].item.LJIFOHFEFCH(OAFPBCPDOKH: true)));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.HMCJLHECPDL(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 0; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.AGFIIGGGBHC()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.BNNMKKJMNNI(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.GLMOFMJFDLF(null, null).OOIPLIEJILO() < price.BNCMDNFMECD())
				{
					price = food2.CFLNIHAHJHN(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.EIGDFMNOEBK(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() > price.BNCMDNFMECD())
			{
				price = food2.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public Food NEECMEIEIAG(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Ingredient group " + IABAKHPEOAF() + " without ingredient options"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.NEECMEIEIAG(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.NGDPNIFFHKL())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("Error not founding final ingredients to " + list[0].item.IABAKHPEOAF()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.PAAFCADLNEM(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.NEECMEIEIAG(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.PAAFCADLNEM(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() < price.OOIPLIEJILO())
				{
					price = food2.PAAFCADLNEM(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.PAAFCADLNEM(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() > price.OOIPLIEJILO())
			{
				price = food2.PAAFCADLNEM(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.PAAFCADLNEM(null, KMNOGHMAAEK);
		}
		return food;
	}

	public Price LACKBLFDBDH(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.IFMFKEMHHLM(Mathf.Max(1, Price.LEBKIMOAAKB(Price.CBCAAHPFLGO(price, 1974f), amount).JHKPNCOMAHI()));
	}

	public void CKDMOFIBIPG(bool DHBKKANAIML)
	{
		List<ItemMod> list = ICNDCCNNNDI(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.IABAKHPEOAF();
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + " (" + list[i].mod.IABAKHPEOAF() + ")";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += " NOT SHOWING IN TOOLTIP";
			}
			Debug.Log((object)text);
		}
	}

	public Food MBCFFGPNCOA(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (Item.NGIIPJDAMGP(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	private void MMFCPANMNND(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.NGDPNIFFHKL())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Price PAAFCADLNEM(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.GHDCKOJGAMM(Mathf.Max(1, Price.MGDGPDBBMNA(Price.FAFHFJGOHPK(price, 1.3f), amount).OOIPLIEJILO()));
	}

	public Price LBIFIDAPMBG(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.GHDCKOJGAMM(Mathf.Max(1, Price.LEBKIMOAAKB(Price.CBCAAHPFLGO(price, 150f), amount).OOIPLIEJILO()));
	}

	public Food DPJLEEDAAHF(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (Item.NGIIPJDAMGP(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.JGJLNHAKJIJ() && (from x in list[i].item.ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Food FLFGJBIMFAE(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			if (Item.NGIIPJDAMGP(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public bool IPHCMBAHICL(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public void LJEBMFNIGDP(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i += 0)
		{
			string text = list[i].item.IABAKHPEOAF();
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "UnNuevoMaestro/HikariTalk" + list[i].mod.LJIFOHFEFCH(OAFPBCPDOKH: true) + "ExampleMethodSetTitle";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Dialogue System/Conversation/Gass_Introduce/Entry/11/Dialogue Text";
			}
			Debug.Log((object)text);
		}
	}

	public bool BIFPLJCIAHA(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	private void BEHKLKJIBAD(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.IABMOBAKNAE())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	private void KDEIFIGNABH(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.NGDPNIFFHKL())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new IngredientGroupInstance(this);
	}

	public Food AFALBLMCEMN(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			if (Item.GBMFCPGEJDK(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.JGJLNHAKJIJ() && (from x in list[i].item.BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Price LHDHAMDNBAA(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.OMDBJINNHPC(Mathf.Max(0, Price.CGGHNDOANLA(Price.LBOFJOBAGKA(price, 1062f), amount).BNCMDNFMECD()));
	}

	public Food IKPIODJCBLC(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK);
		for (int i = 1; i < list.Count; i++)
		{
			if (Item.EKGNIODFJCO(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.IABMOBAKNAE() && (from x in list[i].item.BEBJHEGMNOC(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public void PJEDIMMFJMJ(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.KGHFCDELKMN(OAFPBCPDOKH: true);
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + " " + list[i].mod.LJIFOHFEFCH(OAFPBCPDOKH: true) + "";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Dialogue System/Conversation/Gass_Quest/Entry/31/Dialogue Text";
			}
			Debug.Log((object)text);
		}
	}

	public bool FHELIHHFDHK(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public override string IGDKFHCHEAJ(int JIIGOACEIKL)
	{
		if (translationByID)
		{
			string text = "";
			if (!string.IsNullOrEmpty(LocalisationSystem.Get("Items/item_description_" + JDJGFAACPFC(DAINLFIMLIH: false))))
			{
				text = LocalisationSystem.Get("Items/item_description_" + JDJGFAACPFC(DAINLFIMLIH: false)) + "\n \n";
			}
			List<ItemMod> list = ((!ModifierUI.Get(JIIGOACEIKL).IsOpened()) ? ICNDCCNNNDI(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true) : ICNDCCNNNDI(OBAHGHBFIGO: false, ModifierUI.Get(JIIGOACEIKL).JNLKEMLDFIM, BMMBDCBJNAK: true));
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].item.showNameInIngredientsGroupDescription)
				{
					text = ((i <= 0) ? (text + list[i].item.IABAKHPEOAF()) : (text + "\n" + list[i].item.IABAKHPEOAF()));
					if (Item.MLBOMGHINCA(list[i].mod, null))
					{
						text = text + " (" + list[i].mod.IABAKHPEOAF() + ")";
					}
					if (i >= 7)
					{
						text += "\n...";
						break;
					}
				}
			}
			return text;
		}
		return LocalisationSystem.Get(description);
	}

	public Food MEMNIOFOKLG(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (Item.GBMFCPGEJDK(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public void NMOPIJPHKCO(bool DHBKKANAIML)
	{
		List<ItemMod> list = ICNDCCNNNDI(DHBKKANAIML, null);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.LJIFOHFEFCH();
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + "ReceiveChargeMoney" + list[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + "NinjaChallengeEvent/Main 3";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "ReceiveSetPickupable";
			}
			Debug.Log((object)text);
		}
	}

	public Price GLMOFMJFDLF(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.IFMFKEMHHLM(Mathf.Max(1, Price.CGGHNDOANLA(Price.LBOFJOBAGKA(price, 996f), amount).OOIPLIEJILO()));
	}

	public bool IMGMCMGKDHN(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public bool HJOHCGKEEGG(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Food AHBDINABMKD(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK);
		for (int i = 0; i < list.Count; i++)
		{
			if (Item.EKGNIODFJCO(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.IABMOBAKNAE() && (from x in list[i].item.MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Price GICJEDHIAJA(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.GHDCKOJGAMM(Mathf.Max(1, Price.LEBKIMOAAKB(Price.LFJHHLGOCPP(price, 1968f), amount).BNCMDNFMECD()));
	}

	private void CJEKIONNMLC(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.NGDPNIFFHKL())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public bool BJDJPAJMPAC(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public override int JFHFEMDAHCD(Recipe KMNOGHMAAEK)
	{
		ItemMod itemMod = ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK)[0];
		if (itemMod.item.NGDPNIFFHKL())
		{
			return itemMod.item.JFHFEMDAHCD(KMNOGHMAAEK);
		}
		return 1;
	}

	public Food ALMJHCJKCBB(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.IABMOBAKNAE())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)("ReceiveOnConversationResponseMenu" + KGHFCDELKMN(OAFPBCPDOKH: true) + "Dialogue System/Conversation/BirdNegativeComments/Entry/14/Dialogue Text"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.DFMJDEBBJPH(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.IABMOBAKNAE())
		{
			List<Food> list2 = list[1].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("Actionbar 8" + list[1].item.IABAKHPEOAF(OAFPBCPDOKH: true)));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.AGFIIGGGBHC()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.ABOGBFOEELF(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.HJKLPCCGGHH(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() < price.BNCMDNFMECD())
				{
					price = food2.EIGDFMNOEBK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: false).JHKPNCOMAHI() > price.OOIPLIEJILO())
			{
				price = food2.HHOCDHGJEFH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.OCBCNMJMCJI(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
		}
		return food;
	}

	public bool OALIACDDEOL(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public void PPPMFPOOHHM(bool DHBKKANAIML)
	{
		List<ItemMod> list = ICNDCCNNNDI(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.KGHFCDELKMN(OAFPBCPDOKH: true);
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "UINextPage" + list[i].mod.LJIFOHFEFCH(OAFPBCPDOKH: true) + "Dialogue System/Conversation/Rowdy/Entry/3/Dialogue Text";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "</color>";
			}
			Debug.Log((object)text);
		}
	}

	public Food MKKFFHJLNHK(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Statue2={0}" + KGHFCDELKMN(OAFPBCPDOKH: true) + "/"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.NACLIDDDHFB(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.NGDPNIFFHKL())
		{
			List<Food> list2 = list[1].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("Loop" + list[0].item.IABAKHPEOAF(OAFPBCPDOKH: true)));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.JGJLNHAKJIJ()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.FDCGADKEDAP(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.GCMCKEGDHGP(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() < price.BNCMDNFMECD())
				{
					price = food2.FKJGKLNIEMA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.HIBBNGKMNKH(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).BNCMDNFMECD() > price.BNCMDNFMECD())
			{
				price = food2.NMNEOIPJNDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public Food IOOJEBHGLKO(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK);
		for (int i = 1; i < list.Count; i++)
		{
			if (Item.EKGNIODFJCO(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Food NMEJEDHILPF(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK);
		for (int i = 1; i < list.Count; i++)
		{
			if (Item.EKGNIODFJCO(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.IABMOBAKNAE() && (from x in list[i].item.MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public void DIHIDOJFIDL(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i += 0)
		{
			string text = list[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true);
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "Items/item_name_660" + list[i].mod.KGHFCDELKMN() + "BanquetEvent not activated";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "[";
			}
			Debug.Log((object)text);
		}
	}

	public Food AKFLDILJHGH(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i++)
		{
			if (Item.EKMFELLJHFG(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Price FBMCCBCPPEO(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.DHMGJGHCCJD(Mathf.Max(0, Price.LEBKIMOAAKB(Price.EMJKENIECGH(price, 172f), amount).JHKPNCOMAHI()));
	}

	public void EGKNKHCMDEK(bool DHBKKANAIML)
	{
		List<ItemMod> list = BEBJHEGMNOC(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i++)
		{
			string text = list[i].item.KGHFCDELKMN(OAFPBCPDOKH: true);
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "ReceiveInstantiateDog" + list[i].mod.IABAKHPEOAF() + "tutorial";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Graphics";
			}
			Debug.Log((object)text);
		}
	}

	public void CMPNCBPOACO(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null);
		for (int i = 0; i < list.Count; i += 0)
		{
			string text = list[i].item.LJIFOHFEFCH();
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "Items/item_name_696" + list[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + "\n";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Trying to create room...";
			}
			Debug.Log((object)text);
		}
	}

	public Food MOALFFDILOL(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.JGJLNHAKJIJ())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)("  " + KGHFCDELKMN(OAFPBCPDOKH: true) + "/Female/"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.NACLIDDDHFB(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.JGJLNHAKJIJ())
		{
			List<Food> list2 = list[0].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("" + list[1].item.IABAKHPEOAF(OAFPBCPDOKH: true)));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.HHOCDHGJEFH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.IABMOBAKNAE()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.HIILAHFPJKD(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).BNCMDNFMECD() < price.JHKPNCOMAHI())
				{
					price = food2.HHOCDHGJEFH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.KLNJNIMFINK(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() > price.JHKPNCOMAHI())
			{
				price = food2.FKJGKLNIEMA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.PAAFCADLNEM(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public Price PMLPOLKMFPB(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.GHDCKOJGAMM(Mathf.Max(1, Price.LEBKIMOAAKB(Price.FAFHFJGOHPK(price, 48f), amount).JHKPNCOMAHI()));
	}

	public bool PNNLAJJHGLC(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public void DACKMIOGCEA(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null);
		for (int i = 1; i < list.Count; i++)
		{
			string text = list[i].item.IABAKHPEOAF(OAFPBCPDOKH: true);
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + "BiscuitAleAbbreviation" + list[i].mod.LJIFOHFEFCH() + "ReceiveUpdateFoodStats";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Items/item_description_642";
			}
			Debug.Log((object)text);
		}
	}

	public bool JJEMLLJEKMK(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Food BCIOCKKHDNA(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			if (Item.EKMFELLJHFG(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public void NDDLFLPKJBJ(bool DHBKKANAIML)
	{
		List<ItemMod> list = DLKEJMGALGP(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i++)
		{
			string text = list[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true);
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + "BirdPositiveComments" + list[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + "???";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "HarvestableEveryXDays";
			}
			Debug.Log((object)text);
		}
	}

	public Price CNNPILGGPBK(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.DHMGJGHCCJD(Mathf.Max(0, Price.CGGHNDOANLA(Price.MPPPFDKJGNI(price, 944f), amount).BNCMDNFMECD()));
	}

	public bool JOMKNBKIBFO(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public void ABNMGFPMIAB(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null);
		for (int i = 0; i < list.Count; i += 0)
		{
			string text = list[i].item.KGHFCDELKMN(OAFPBCPDOKH: true);
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + "%><sprite name=RightStick></size>" + list[i].mod.IABAKHPEOAF() + "OnLayerOrderedRPC";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += " ";
			}
			Debug.Log((object)text);
		}
	}

	private void GFPEGLHJOAC(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.AGFIIGGGBHC())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Food DGPIIKFFLFB(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO: false, KMNOGHMAAEK);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (Item.GBMFCPGEJDK(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.AGFIIGGGBHC() && (from x in list[i].item.DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	private void HGJNEDJMINO(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.AGFIIGGGBHC())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public bool BELFEOFKODI(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	private void HNONMOOJOGC(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.AGFIIGGGBHC())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public override List<ItemMod> ICNDCCNNNDI(bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, bool BMMBDCBJNAK = false)
	{
		List<ItemMod> list = new List<ItemMod>();
		if (canBeSoldFood)
		{
			foodList = ItemDatabaseAccessor.GetDatabaseSO().food;
			for (int i = 0; i < foodList.Count; i++)
			{
				foodAux = foodList[i];
				if (!foodAux.canBeSold || foodAux.JEPBBEBJEFI() || !((Object)(object)foodAux.recipe != (Object)null))
				{
					continue;
				}
				itemModAux = new ItemMod(foodAux);
				if (BMMBDCBJNAK)
				{
					if (!foodAux.recipe.replacedRecipe)
					{
						list.Add(itemModAux);
					}
				}
				else
				{
					list.Add(itemModAux);
				}
			}
		}
		else if (ingredientsTypes != null && ingredientsTypes.Length != 0)
		{
			foodList = ItemDatabaseAccessor.GetDatabaseSO().food;
			for (int j = 0; j < foodList.Count; j++)
			{
				for (int k = 0; k < ingredientsTypes.Length; k++)
				{
					if (foodList[j].ingredientType == ingredientsTypes[k] && foodList[j].canBeUsedAsModifier)
					{
						MMFCPANMNND(list, foodList[j], null, KMNOGHMAAEK, OBAHGHBFIGO, BMMBDCBJNAK);
						break;
					}
				}
			}
		}
		else
		{
			for (int l = 0; l < possibleItems.Count; l++)
			{
				MMFCPANMNND(list, possibleItems[l].item, possibleItems[l].mod, KMNOGHMAAEK, OBAHGHBFIGO, BMMBDCBJNAK);
			}
		}
		if ((Object)(object)KMNOGHMAAEK != (Object)null && KMNOGHMAAEK.excludeIngredients != null && KMNOGHMAAEK.excludeIngredients.Count > 0)
		{
			list = list.Where((ItemMod x) => !KMNOGHMAAEK.excludeIngredients.Contains(x.item)).ToList();
		}
		return list;
	}

	public void FLBBEEEJEOP(bool DHBKKANAIML)
	{
		List<ItemMod> list = BEBJHEGMNOC(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i += 0)
		{
			string text = list[i].item.IABAKHPEOAF(OAFPBCPDOKH: true);
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + "Crop needs a harvested replace by item " + list[i].mod.LJIFOHFEFCH() + ") stack changed to (";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "/";
			}
			Debug.Log((object)text);
		}
	}

	public void LKLKCLOMMCP(bool DHBKKANAIML)
	{
		List<ItemMod> list = BEBJHEGMNOC(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i += 0)
		{
			string text = list[i].item.LJIFOHFEFCH();
			if (Item.MLBOMGHINCA(list[i].mod, null))
			{
				text = text + "Null item in database: " + list[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + "ReceiveOfferingUIClosed";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += " (";
			}
			Debug.Log((object)text);
		}
	}

	private void PKIMPEMKKPL(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.AGFIIGGGBHC())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Food ENFGAIHEKAN(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i++)
		{
			if (Item.EKMFELLJHFG(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.JGJLNHAKJIJ() && (from x in list[i].item.MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Food OHGDLPOMINA(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.AGFIIGGGBHC())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("ERROR - Error parsing custom lobby data (Lobby owner): {0}" + LJIFOHFEFCH() + "[MinePipePuzzle] No hay PipePuzzleInteractable asignado."));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.OHGDLPOMINA(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.IABMOBAKNAE())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("Dialogue System/Conversation/NeutralInTavern/Entry/10/Dialogue Text" + list[1].item.IABAKHPEOAF(OAFPBCPDOKH: true)));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.GLMOFMJFDLF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.AGFIIGGGBHC()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.CLACOGANHMM(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).BNCMDNFMECD() < price.BNCMDNFMECD())
				{
					price = food2.PAAFCADLNEM(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
					food = food2;
				}
			}
			else if (food2.CCOJHEOLBDA(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice).JHKPNCOMAHI() > price.BNCMDNFMECD())
			{
				price = food2.HHOCDHGJEFH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.OCBCNMJMCJI(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
		}
		return food;
	}

	private void OLBEONEOODB(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.JGJLNHAKJIJ())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Food KNGABAFDJGG(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.IABMOBAKNAE())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Waiting for scene {0} load on client. Current state: {1}" + IABAKHPEOAF(OAFPBCPDOKH: true) + "Input field already has console support component: {0}"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.NACLIDDDHFB(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.IABMOBAKNAE())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)(" has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object." + list[0].item.LJIFOHFEFCH(OAFPBCPDOKH: true)));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.GLMOFMJFDLF(null, KMNOGHMAAEK);
		for (int i = 0; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.JGJLNHAKJIJ()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1]) : ingredientGroup2.DFMJDEBBJPH(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.CCOJHEOLBDA(null, null).BNCMDNFMECD() < price.OOIPLIEJILO())
				{
					price = food2.GLMOFMJFDLF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
					food = food2;
				}
			}
			else if (food2.HNGJEIKLDIF(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).OOIPLIEJILO() > price.BNCMDNFMECD())
			{
				price = food2.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HHOCDHGJEFH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
		}
		return food;
	}

	public Price NLHFGLHKHGP(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.OMDBJINNHPC(Mathf.Max(0, Price.CGGHNDOANLA(Price.LFJHHLGOCPP(price, 402f), amount).JHKPNCOMAHI()));
	}

	public bool NOEDLEEGEEP(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Food LJLEOICPGGI(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.AGFIIGGGBHC())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK: true);
		if (list.Count == 0)
		{
			Debug.LogError((object)(" PlayerNum: " + IABAKHPEOAF() + "Drunk"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.NACLIDDDHFB(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.NGDPNIFFHKL())
		{
			List<Food> list2 = list[1].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("ReceivInstantiateHoleInGround" + list[1].item.LJIFOHFEFCH()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
		for (int i = 0; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1]) : ingredientGroup2.BNNMKKJMNNI(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.NMNEOIPJNDA(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice).BNCMDNFMECD() < price.OOIPLIEJILO())
				{
					price = food2.HHOCDHGJEFH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.HMCJLHECPDL(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).BNCMDNFMECD() > price.OOIPLIEJILO())
			{
				price = food2.NMNEOIPJNDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.GCMCKEGDHGP(null, KMNOGHMAAEK);
		}
		return food;
	}

	private void FAPJJFBIMAM(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.FKLOBGBIHLB(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.IABMOBAKNAE())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public void AINEBOKAKCE(bool DHBKKANAIML)
	{
		List<ItemMod> list = BEBJHEGMNOC(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 1; i < list.Count; i += 0)
		{
			string text = list[i].item.KGHFCDELKMN();
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "UIAddRemove" + list[i].mod.IABAKHPEOAF() + "/";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Fortitude/MainEvent 3";
			}
			Debug.Log((object)text);
		}
	}

	public Food ADHFHIOELAL(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (Item.EKMFELLJHFG(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.AGFIIGGGBHC() && (from x in list[i].item.MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public void NJHLBCNNNEJ(bool DHBKKANAIML)
	{
		List<ItemMod> list = MODAHOLMPKH(DHBKKANAIML, null);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true);
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "Player/Bark/ShovelHole" + list[i].mod.LJIFOHFEFCH() + " ";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "NormalRight";
			}
			Debug.Log((object)text);
		}
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new IngredientGroupInstance((IngredientGroupInstance)DNLMCHDOMOK);
	}

	public Food KGHINFMFNNP(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Output is not ready" + KGHFCDELKMN(OAFPBCPDOKH: true) + "LearnMettle"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.LJLEOICPGGI(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.AGFIIGGGBHC())
		{
			List<Food> list2 = list[0].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("quest_description_22" + list[1].item.IABAKHPEOAF(OAFPBCPDOKH: true)));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.FKJGKLNIEMA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
		for (int i = 0; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.JGJLNHAKJIJ()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1]) : ingredientGroup2.LJLEOICPGGI(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.GCMCKEGDHGP(null, null).OOIPLIEJILO() < price.JHKPNCOMAHI())
				{
					price = food2.EIGDFMNOEBK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.OCBCNMJMCJI(null, null).OOIPLIEJILO() > price.BNCMDNFMECD())
			{
				price = food2.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HNGJEIKLDIF(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		}
		return food;
	}

	public Food OCJHNNFAKGB(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO: true, KMNOGHMAAEK);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (Item.EKMFELLJHFG(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.NGDPNIFFHKL() && (from x in list[i].item.ICNDCCNNNDI(OBAHGHBFIGO: false, KMNOGHMAAEK, BMMBDCBJNAK: true)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Food FDCGADKEDAP(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.JGJLNHAKJIJ())
			{
				return cheapestIngredient.item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("Dialogue System/Conversation/Crowly_Standar/Entry/21/Dialogue Text" + IABAKHPEOAF(OAFPBCPDOKH: true) + "Nature"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.NEECMEIEIAG(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[0].item.AGFIIGGGBHC())
		{
			List<Food> list2 = list[1].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("Error in CatRelationship.CheckRelationship: " + list[0].item.IABAKHPEOAF()));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.IHIGCCEBHDK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 0; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[0]) : ingredientGroup2.ABOGBFOEELF(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.HMCJLHECPDL(null, null, null, CGDEPNDEBIH: false).JHKPNCOMAHI() < price.JHKPNCOMAHI())
				{
					price = food2.HMCJLHECPDL(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
					food = food2;
				}
			}
			else if (food2.CCOJHEOLBDA(null, null).JHKPNCOMAHI() > price.BNCMDNFMECD())
			{
				price = food2.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.HIBBNGKMNKH(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
		}
		return food;
	}

	private void DLJPNDAJBGD(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.NGDPNIFFHKL())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Food KCMKLKEHGPF(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO: false, KMNOGHMAAEK);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (Item.GBMFCPGEJDK(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.IABMOBAKNAE() && (from x in list[i].item.ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public Food ALBGKOOJIGA(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		List<ItemMod> list = DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			if (Item.NGIIPJDAMGP(list[i].item, NBGKDPDJLJF))
			{
				return list[i].item as Food;
			}
			if (list[i].item.JGJLNHAKJIJ() && (from x in list[i].item.DLKEJMGALGP(OBAHGHBFIGO: true, KMNOGHMAAEK)
				where ((object)x.item).Equals((object?)NBGKDPDJLJF)
				select x).Any())
			{
				return list[i].item as Food;
			}
		}
		return null;
	}

	public bool CDBOJJNFHIA(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in ICNDCCNNNDI(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public Price MBPLPEIBHHE(ItemAmount HMPIKDOIJGO)
	{
		int amount = HMPIKDOIJGO.amount;
		return Price.GHDCKOJGAMM(Mathf.Max(0, Price.MGDGPDBBMNA(Price.EMJKENIECGH(price, 872f), amount).OOIPLIEJILO()));
	}

	public void LBDBEDBDFJI(bool DHBKKANAIML)
	{
		List<ItemMod> list = DLKEJMGALGP(DHBKKANAIML, null);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.LJIFOHFEFCH();
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + " (" + list[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + "Christmas/Ace/Stand";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "HaveGoldenTicket";
			}
			Debug.Log((object)text);
		}
	}

	public Food GHBLOAKMFCF(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.MLBOMGHINCA(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.JGJLNHAKJIJ())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("HotBath/Bark" + IABAKHPEOAF(OAFPBCPDOKH: true) + "Idle"));
		}
		Food food;
		if (list[1].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.MKKFFHJLNHK(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.AGFIIGGGBHC())
		{
			List<Food> list2 = list[0].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 0)
			{
				food = list2[0];
			}
			else
			{
				Debug.LogError((object)("Items/item_description_1183" + list[1].item.KGHFCDELKMN()));
				food = list[1].item as Food;
			}
		}
		else
		{
			food = list[0].item as Food;
		}
		Price price = food.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false);
		for (int i = 1; i < list.Count; i++)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.AGFIIGGGBHC()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1]) : ingredientGroup2.LJLEOICPGGI(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.HHOCDHGJEFH(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).JHKPNCOMAHI() < price.JHKPNCOMAHI())
				{
					price = food2.CFLNIHAHJHN(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.OCIIAEAMJAH(null, null, null, CGDEPNDEBIH: false, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false).OOIPLIEJILO() > price.OOIPLIEJILO())
			{
				price = food2.PAAFCADLNEM(null, KMNOGHMAAEK);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.NMNEOIPJNDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
		}
		return food;
	}

	public bool KNLHBMEKGJA(Food NBGKDPDJLJF, Recipe KMNOGHMAAEK)
	{
		return (from x in BEBJHEGMNOC(OBAHGHBFIGO: true, KMNOGHMAAEK, BMMBDCBJNAK: true)
			where ((object)x.item).Equals((object?)NBGKDPDJLJF)
			select x).Any();
	}

	public void KFMECKAMNOJ(bool DHBKKANAIML)
	{
		List<ItemMod> list = BEBJHEGMNOC(DHBKKANAIML, null);
		for (int i = 1; i < list.Count; i++)
		{
			string text = list[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true);
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "Dog" + list[i].mod.LJIFOHFEFCH(OAFPBCPDOKH: true) + "Interact";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Attack/MainEvent 2";
			}
			Debug.Log((object)text);
		}
	}

	public void NAAODCEFPBL(bool DHBKKANAIML)
	{
		List<ItemMod> list = DLKEJMGALGP(DHBKKANAIML, null, BMMBDCBJNAK: true);
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i].item.KGHFCDELKMN();
			if (Item.FKLOBGBIHLB(list[i].mod, null))
			{
				text = text + "mapBathHouse" + list[i].mod.IABAKHPEOAF() + " x ";
			}
			if (!list[i].item.showNameInIngredientsGroupDescription)
			{
				text += "Trying to assign mine ID to an object without OnlineObject component.";
			}
			Debug.Log((object)text);
		}
	}

	private void OBCHDLJJPGA(List<ItemMod> LHANPFMIMAH, Item MEMGMDOCBOJ, Item NHACCPPICKI, Recipe KMNOGHMAAEK, bool OBAHGHBFIGO, bool BMMBDCBJNAK = false)
	{
		if (OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux = default(ItemMod);
			itemModAux.item = NHACCPPICKI;
			LHANPFMIMAH.Add(itemModAux);
			return;
		}
		if (MEMGMDOCBOJ is IngredientGroup ingredientGroup)
		{
			LHANPFMIMAH.AddRange(ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		if (OBAHGHBFIGO && MEMGMDOCBOJ.NGDPNIFFHKL())
		{
			LHANPFMIMAH.AddRange(MEMGMDOCBOJ.BEBJHEGMNOC(OBAHGHBFIGO, KMNOGHMAAEK, BMMBDCBJNAK));
			return;
		}
		itemModAux = new ItemMod(MEMGMDOCBOJ);
		if (!OBAHGHBFIGO && Item.MLBOMGHINCA(NHACCPPICKI, null))
		{
			itemModAux.mod = NHACCPPICKI;
		}
		LHANPFMIMAH.Add(itemModAux);
	}

	public Food PPDBNGKAHNA(bool OEBNHGNJEJL, bool OBAHGHBFIGO, Recipe KMNOGHMAAEK, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		if (Item.FKLOBGBIHLB(cheapestIngredient.item, null))
		{
			if (OBAHGHBFIGO && cheapestIngredient.item.NGDPNIFFHKL())
			{
				return cheapestIngredient.item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1];
			}
			return cheapestIngredient.item as Food;
		}
		List<ItemMod> list = MODAHOLMPKH(OBAHGHBFIGO, KMNOGHMAAEK);
		if (list.Count == 0)
		{
			Debug.LogError((object)("\n\n" + KGHFCDELKMN(OAFPBCPDOKH: true) + "Playstate"));
		}
		Food food;
		if (list[0].item is IngredientGroup ingredientGroup)
		{
			food = ingredientGroup.HIILAHFPJKD(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI);
		}
		else if (OBAHGHBFIGO && list[1].item.NGDPNIFFHKL())
		{
			List<Food> list2 = list[1].item.BAABOFJGLMA(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI);
			if (list2.Count > 1)
			{
				food = list2[1];
			}
			else
			{
				Debug.LogError((object)("CatSize" + list[1].item.IABAKHPEOAF(OAFPBCPDOKH: true)));
				food = list[0].item as Food;
			}
		}
		else
		{
			food = list[1].item as Food;
		}
		Price price = food.NBIEMNNCGLE(null, KMNOGHMAAEK);
		for (int i = 0; i < list.Count; i += 0)
		{
			Item item = ((!(list[i].item is IngredientGroup ingredientGroup2)) ? ((!OBAHGHBFIGO || !list[i].item.NGDPNIFFHKL()) ? list[i].item : list[i].item.CNIMBCHPOND(OEBNHGNJEJL, OBAHGHBFIGO, DLIDPDKODMI)[1]) : ingredientGroup2.PPDBNGKAHNA(OEBNHGNJEJL, OBAHGHBFIGO, KMNOGHMAAEK, DLIDPDKODMI));
			if (!(item is Food { canBeUsedAsModifier: not false } food2))
			{
				continue;
			}
			if (DLIDPDKODMI == CalculatePriceMode.CheapestPrice)
			{
				if (food2.HHOCDHGJEFH(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).JHKPNCOMAHI() < price.BNCMDNFMECD())
				{
					price = food2.NBIEMNNCGLE(null, KMNOGHMAAEK, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice);
					food = food2;
				}
			}
			else if (food2.HHOCDHGJEFH(null, null, null, CGDEPNDEBIH: true, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false).OOIPLIEJILO() > price.BNCMDNFMECD())
			{
				price = food2.KLNJNIMFINK(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false);
				food = food2;
			}
		}
		if (OEBNHGNJEJL)
		{
			food.CCOJHEOLBDA(null, KMNOGHMAAEK, null, CGDEPNDEBIH: false, CalculatePriceMode.ExpensivePrice, OEBNHGNJEJL: false);
		}
		return food;
	}
}
