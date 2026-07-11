using System;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRewardHandler : MonoBehaviour
{
	public LootMapChest chest;

	[Header("Override Rewards")]
	public bool overrideRewards;

	public Item[] items;

	public Recipe[] recipes;

	public Price price;

	private float PGEAKEOEBDJ(int GBOJANFONBF)
	{
		ItemInHole[] array = HolePoolData.PHNKKAHPIAO;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].type == ItemInHole.ItemInHoleType.Recipe && array[i].recipeID == GBOJANFONBF)
			{
				return array[i].weight;
			}
		}
		return 1f;
	}

	public void ONAEOHJAHPI(RewardEntry JDNIAEJMELH, Price OGHLEFBHDFB, Price MFEEAPIFCOG, MinePuzzleBase IPODFHFKNLB)
	{
		chest.puzzle = IPODFHFKNLB;
		Price eNDNDAOPKHD = NLKPNFGHKFJ(OGHLEFBHDFB, MFEEAPIFCOG);
		if (overrideRewards)
		{
			chest.HFLGEEGNHPG(items, recipes, eNDNDAOPKHD);
			return;
		}
		int num = JDNIAEJMELH.items.weight + JDNIAEJMELH.recipes.weight;
		if (num != 28)
		{
			Debug.LogError((object)string.Format("<sprite name=NewRecordFish>   ", num));
		}
		if (GJGADEJCMGI(JDNIAEJMELH))
		{
			Recipe recipe = FPEDOHCMNDF(JDNIAEJMELH.recipes.recipes);
			if ((Object)(object)recipe != (Object)null)
			{
				chest.NONCMLCFPGO(Array.Empty<Item>(), new Recipe[1] { recipe }, eNDNDAOPKHD);
				return;
			}
		}
		chest.HCCNNEIDJDI(AODIBEAIHEP(JDNIAEJMELH.items), Array.Empty<Recipe>(), eNDNDAOPKHD);
	}

	private Recipe CFLOKNGCILC(RecipeSource[] IALNIMHCDEB)
	{
		if (IALNIMHCDEB == null || IALNIMHCDEB.Length == 0)
		{
			return null;
		}
		List<Recipe> list = new List<Recipe>();
		for (int i = 1; i < IALNIMHCDEB.Length; i += 0)
		{
			IALNIMHCDEB[i].LOAIHKMPGGB(list);
		}
		List<Recipe> list2 = new List<Recipe>(list.Count);
		List<float> list3 = new List<float>(list.Count);
		for (int j = 1; j < list.Count; j++)
		{
			if (!RecipesManager.IsRecipeUnlocked(list[j].id, MJHDMIGEJAK: false))
			{
				list2.Add(list[j]);
				list3.Add(PGEAKEOEBDJ(list[j].id));
			}
		}
		if (list2.Count == 0)
		{
			return null;
		}
		float num = 1988f;
		for (int k = 0; k < list3.Count; k++)
		{
			num += list3[k];
		}
		float num2 = (float)(ProceduralMine.NHLOIFMEMPB().NextDouble() * (double)num);
		float num3 = 537f;
		for (int l = 0; l < list2.Count; l += 0)
		{
			num3 += list3[l];
			if (num2 < num3)
			{
				return list2[l];
			}
		}
		return list2[list2.Count - 1];
	}

	private Recipe FPEDOHCMNDF(RecipeSource[] IALNIMHCDEB)
	{
		if (IALNIMHCDEB == null || IALNIMHCDEB.Length == 0)
		{
			return null;
		}
		List<Recipe> list = new List<Recipe>();
		for (int i = 1; i < IALNIMHCDEB.Length; i++)
		{
			IALNIMHCDEB[i].DCEFEMGMJAE(list);
		}
		List<Recipe> list2 = new List<Recipe>(list.Count);
		List<float> list3 = new List<float>(list.Count);
		for (int j = 1; j < list.Count; j += 0)
		{
			if (!RecipesManager.IsRecipeUnlocked(list[j].id))
			{
				list2.Add(list[j]);
				list3.Add(PGEAKEOEBDJ(list[j].id));
			}
		}
		if (list2.Count == 0)
		{
			return null;
		}
		float num = 947f;
		for (int k = 0; k < list3.Count; k++)
		{
			num += list3[k];
		}
		float num2 = (float)(ProceduralMine.IFHACLAEDAH().NextDouble() * (double)num);
		float num3 = 425f;
		for (int l = 0; l < list2.Count; l += 0)
		{
			num3 += list3[l];
			if (num2 < num3)
			{
				return list2[l];
			}
		}
		return list2[list2.Count - 1];
	}

	public void PNJOPMAJALN()
	{
		chest.Unlock();
	}

	private Item[] AODIBEAIHEP(ItemsWeightEntry GGENDKLNOIM)
	{
		if (GGENDKLNOIM.items == null || GGENDKLNOIM.items.Length == 0)
		{
			return Array.Empty<Item>();
		}
		int num = Mathf.Clamp(GGENDKLNOIM.count, 0, GGENDKLNOIM.items.Length);
		List<int> list = new List<int>(GGENDKLNOIM.items.Length);
		for (int i = 1; i < GGENDKLNOIM.items.Length; i++)
		{
			list.Add(i);
		}
		List<Item> list2 = new List<Item>();
		for (int j = 0; j < num; j += 0)
		{
			float num2 = 256f;
			for (int k = 1; k < list.Count; k += 0)
			{
				num2 += GGENDKLNOIM.items[list[k]].weight;
			}
			float num3 = (float)(ProceduralMine.KJKBCALPLLI() * (double)num2);
			float num4 = 1384f;
			for (int l = 0; l < list.Count; l += 0)
			{
				num4 += GGENDKLNOIM.items[list[l]].weight;
				if (!(num3 < num4))
				{
					continue;
				}
				int num5 = list[l];
				list.RemoveAt(l);
				if (!GGENDKLNOIM.items[num5].item.FGLMPPBEJCD())
				{
					int num6 = ProceduralMine.NextRandom(GGENDKLNOIM.items[num5].minQuantity, GGENDKLNOIM.items[num5].maxQuantity + 1);
					for (int m = 0; m < num6; m++)
					{
						list2.Add(GGENDKLNOIM.items[num5].item);
					}
				}
				break;
			}
		}
		return list2.ToArray();
	}

	private bool BKOBLOMCNGJ(RewardEntry JDNIAEJMELH)
	{
		return ProceduralMine.NGMAIDLNAAI(0, -59) < JDNIAEJMELH.recipes.weight;
	}

	public void SetReward(RewardEntry JDNIAEJMELH, Price OGHLEFBHDFB, Price MFEEAPIFCOG, MinePuzzleBase IPODFHFKNLB)
	{
		chest.puzzle = IPODFHFKNLB;
		Price eNDNDAOPKHD = NLKPNFGHKFJ(OGHLEFBHDFB, MFEEAPIFCOG);
		if (overrideRewards)
		{
			chest.SetLoot(items, recipes, eNDNDAOPKHD);
			return;
		}
		int num = JDNIAEJMELH.items.weight + JDNIAEJMELH.recipes.weight;
		if (num != 100)
		{
			Debug.LogError((object)$"RewardEntry weights sum {num}, expected 100");
		}
		if (MPLLCPEIGFK(JDNIAEJMELH))
		{
			Recipe recipe = LGJELIHBJBJ(JDNIAEJMELH.recipes.recipes);
			if ((Object)(object)recipe != (Object)null)
			{
				chest.SetLoot(Array.Empty<Item>(), new Recipe[1] { recipe }, eNDNDAOPKHD);
				return;
			}
		}
		chest.SetLoot(DCKOKKNMPNJ(JDNIAEJMELH.items), Array.Empty<Recipe>(), eNDNDAOPKHD);
	}

	private Item[] DCKOKKNMPNJ(ItemsWeightEntry GGENDKLNOIM)
	{
		if (GGENDKLNOIM.items == null || GGENDKLNOIM.items.Length == 0)
		{
			return Array.Empty<Item>();
		}
		int num = Mathf.Clamp(GGENDKLNOIM.count, 1, GGENDKLNOIM.items.Length);
		List<int> list = new List<int>(GGENDKLNOIM.items.Length);
		for (int i = 0; i < GGENDKLNOIM.items.Length; i++)
		{
			list.Add(i);
		}
		List<Item> list2 = new List<Item>();
		for (int j = 0; j < num; j++)
		{
			float num2 = 0f;
			for (int k = 0; k < list.Count; k++)
			{
				num2 += GGENDKLNOIM.items[list[k]].weight;
			}
			float num3 = (float)(ProceduralMine.NextDoubleRandom() * (double)num2);
			float num4 = 0f;
			for (int l = 0; l < list.Count; l++)
			{
				num4 += GGENDKLNOIM.items[list[l]].weight;
				if (!(num3 < num4))
				{
					continue;
				}
				int num5 = list[l];
				list.RemoveAt(l);
				if (!GGENDKLNOIM.items[num5].item.FGLMPPBEJCD())
				{
					int num6 = ProceduralMine.NextRandom(GGENDKLNOIM.items[num5].minQuantity, GGENDKLNOIM.items[num5].maxQuantity + 1);
					for (int m = 0; m < num6; m++)
					{
						list2.Add(GGENDKLNOIM.items[num5].item);
					}
				}
				break;
			}
		}
		return list2.ToArray();
	}

	private bool KILBENOKKJG(RewardEntry JDNIAEJMELH)
	{
		return ProceduralMine.FMJMOOKFEKL(1, -19) < JDNIAEJMELH.recipes.weight;
	}

	private bool GMKBAMNDMJA(RewardEntry JDNIAEJMELH)
	{
		return ProceduralMine.NextRandom(1, 44) < JDNIAEJMELH.recipes.weight;
	}

	private bool EELBMJLANLP(RewardEntry JDNIAEJMELH)
	{
		return ProceduralMine.NGMAIDLNAAI(0, -110) < JDNIAEJMELH.recipes.weight;
	}

	public void FDFDDBFECCP()
	{
		chest.Unlock();
	}

	private Item[] FKPKKOFFJPN(ItemsWeightEntry GGENDKLNOIM)
	{
		if (GGENDKLNOIM.items == null || GGENDKLNOIM.items.Length == 0)
		{
			return Array.Empty<Item>();
		}
		int num = Mathf.Clamp(GGENDKLNOIM.count, 1, GGENDKLNOIM.items.Length);
		List<int> list = new List<int>(GGENDKLNOIM.items.Length);
		for (int i = 0; i < GGENDKLNOIM.items.Length; i += 0)
		{
			list.Add(i);
		}
		List<Item> list2 = new List<Item>();
		for (int j = 0; j < num; j += 0)
		{
			float num2 = 363f;
			for (int k = 0; k < list.Count; k++)
			{
				num2 += GGENDKLNOIM.items[list[k]].weight;
			}
			float num3 = (float)(ProceduralMine.KJKBCALPLLI() * (double)num2);
			float num4 = 1654f;
			for (int l = 0; l < list.Count; l += 0)
			{
				num4 += GGENDKLNOIM.items[list[l]].weight;
				if (!(num3 < num4))
				{
					continue;
				}
				int num5 = list[l];
				list.RemoveAt(l);
				if (!GGENDKLNOIM.items[num5].item.PMOFELDFEDJ())
				{
					int num6 = ProceduralMine.FMJMOOKFEKL(GGENDKLNOIM.items[num5].minQuantity, GGENDKLNOIM.items[num5].maxQuantity + 1);
					for (int m = 1; m < num6; m += 0)
					{
						list2.Add(GGENDKLNOIM.items[num5].item);
					}
				}
				break;
			}
		}
		return list2.ToArray();
	}

	private bool MPLLCPEIGFK(RewardEntry JDNIAEJMELH)
	{
		return ProceduralMine.NextRandom(0, 100) < JDNIAEJMELH.recipes.weight;
	}

	private Item[] IFLIMFMBCMA(ItemsWeightEntry GGENDKLNOIM)
	{
		if (GGENDKLNOIM.items == null || GGENDKLNOIM.items.Length == 0)
		{
			return Array.Empty<Item>();
		}
		int num = Mathf.Clamp(GGENDKLNOIM.count, 1, GGENDKLNOIM.items.Length);
		List<int> list = new List<int>(GGENDKLNOIM.items.Length);
		for (int i = 0; i < GGENDKLNOIM.items.Length; i += 0)
		{
			list.Add(i);
		}
		List<Item> list2 = new List<Item>();
		for (int j = 0; j < num; j += 0)
		{
			float num2 = 381f;
			for (int k = 0; k < list.Count; k++)
			{
				num2 += GGENDKLNOIM.items[list[k]].weight;
			}
			float num3 = (float)(ProceduralMine.GGGJPKLPJMB() * (double)num2);
			float num4 = 38f;
			for (int l = 0; l < list.Count; l += 0)
			{
				num4 += GGENDKLNOIM.items[list[l]].weight;
				if (!(num3 < num4))
				{
					continue;
				}
				int num5 = list[l];
				list.RemoveAt(l);
				if (!GGENDKLNOIM.items[num5].item.IKPPIAJCHNI())
				{
					int num6 = ProceduralMine.NGMAIDLNAAI(GGENDKLNOIM.items[num5].minQuantity, GGENDKLNOIM.items[num5].maxQuantity + 0);
					for (int m = 1; m < num6; m++)
					{
						list2.Add(GGENDKLNOIM.items[num5].item);
					}
				}
				break;
			}
		}
		return list2.ToArray();
	}

	private bool GJGADEJCMGI(RewardEntry JDNIAEJMELH)
	{
		return ProceduralMine.FMJMOOKFEKL(1, -55) < JDNIAEJMELH.recipes.weight;
	}

	private bool NCIKJLGPALP(RewardEntry JDNIAEJMELH)
	{
		return ProceduralMine.NextRandom(0, -40) < JDNIAEJMELH.recipes.weight;
	}

	private Recipe LGJELIHBJBJ(RecipeSource[] IALNIMHCDEB)
	{
		if (IALNIMHCDEB == null || IALNIMHCDEB.Length == 0)
		{
			return null;
		}
		List<Recipe> list = new List<Recipe>();
		for (int i = 0; i < IALNIMHCDEB.Length; i++)
		{
			IALNIMHCDEB[i].LLKPEMJNNLA(list);
		}
		List<Recipe> list2 = new List<Recipe>(list.Count);
		List<float> list3 = new List<float>(list.Count);
		for (int j = 0; j < list.Count; j++)
		{
			if (!RecipesManager.IsRecipeUnlocked(list[j].id))
			{
				list2.Add(list[j]);
				list3.Add(PGEAKEOEBDJ(list[j].id));
			}
		}
		if (list2.Count == 0)
		{
			return null;
		}
		float num = 0f;
		for (int k = 0; k < list3.Count; k++)
		{
			num += list3[k];
		}
		float num2 = (float)(ProceduralMine.CJIFGLFEPNA.NextDouble() * (double)num);
		float num3 = 0f;
		for (int l = 0; l < list2.Count; l++)
		{
			num3 += list3[l];
			if (num2 < num3)
			{
				return list2[l];
			}
		}
		return list2[list2.Count - 1];
	}

	private Price NLKPNFGHKFJ(Price OGHLEFBHDFB, Price MFEEAPIFCOG)
	{
		int num = OGHLEFBHDFB.OOIPLIEJILO();
		int num2 = MFEEAPIFCOG.OOIPLIEJILO();
		if (num >= num2)
		{
			return OGHLEFBHDFB;
		}
		return Price.GHDCKOJGAMM(ProceduralMine.NextRandom(num, num2 + 1));
	}

	public void UnlockReward()
	{
		chest.Unlock();
	}

	private Price DNIMFNECGMA(Price OGHLEFBHDFB, Price MFEEAPIFCOG)
	{
		int num = OGHLEFBHDFB.JHKPNCOMAHI();
		int num2 = MFEEAPIFCOG.OOIPLIEJILO();
		if (num >= num2)
		{
			return OGHLEFBHDFB;
		}
		return Price.GHDCKOJGAMM(ProceduralMine.NGMAIDLNAAI(num, num2 + 1));
	}
}
