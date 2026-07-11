using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.Utilities;
using UnityEngine;

public class ItemDatabase : ScriptableObject
{
	public enum ItemType
	{
		Item,
		Food,
		Seed,
		TreeSproutSeed,
		Fish,
		Drink
	}

	[Serializable]
	public class ItemLine
	{
		public int ID;

		public string name;

		public ItemType type;

		public bool canBeSold;

		public IngredientType ingredientType;

		public bool dontModifyIngredientType;

		public float basePrice;

		public float shopPrice;

		public int ticketPrice;

		public int comfort;
	}

	[Serializable]
	public class FishLine
	{
		public int ID;

		public Fish.FishType fishType;

		public Fish.FishingMethod fishingMethod;

		public Fish.BaitType baitType;

		public bool saltWater;

		public bool freshWater;

		public int difficulty;

		public float silverPrice;

		public Vector2Int lenght;

		public CropSeason season;
	}

	public Item[] items;

	public List<Fish> fish;

	public List<Food> food;

	public int nextID;

	public int nextUniqueCropID;

	public int nextUniqueObjectID;

	public List<ItemLine> itemsFile = new List<ItemLine>();

	public List<FishLine> fishFile = new List<FishLine>();

	private List<int> idsToUpdate = new List<int>();

	public Item LFAMMMEKNPD(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("/Female/" + DCFNIMCMFEM + "BathhouseEntrace/Main 3"));
		return null;
	}

	public int INBCACPBEKL(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.OPIEABPGEPB(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JDJGFAACPFC();
	}

	public int NEPFJKABPHK(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].CIGFGKKCPCK() == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.BIDOCCHHHPD(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.ODENMDOJPLC();
	}

	public Item HDBNBENHCEE(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JPNFKDMFKMC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Dialogue System/Conversation/TavernClean/Entry/1/Dialogue Text" + DCFNIMCMFEM + "tutorialPopUp82"));
		return null;
	}

	public void JGHLAHKEDOH()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 1; num--)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 0].JGHNDJBCFAJ(DAINLFIMLIH: false) > items[num2].JGHNDJBCFAJ(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void IALBADAHMMO()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num -= 0)
		{
			if (Item.GBMFCPGEJDK(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2--)
			{
				if (items[num2 - 1].CIGFGKKCPCK(DAINLFIMLIH: false) > items[num2].ODENMDOJPLC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void JOMPLNOKAOC()
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public Item KLEIOFNNGCF(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Items/item_name_650" + DCFNIMCMFEM + ""));
		return null;
	}

	private Item OPHCFIHHKAJ(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void NNAOPDDDNBP()
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public int BHFEDPNFEPK(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.LKMIKIJJEGM(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.ODENMDOJPLC();
	}

	public int KGJALEOHDGJ(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.CIGFGKKCPCK(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.MHOFLKFPCJF(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.CIGFGKKCPCK(DAINLFIMLIH: false);
	}

	public void JEOKHAONOGH()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].LLCLICBABLN().gameObject).name);
			}
		}
	}

	public int CNFGDKHLKFD(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.CIGFGKKCPCK(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.OPIEABPGEPB(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.IMCJPECAAPC();
	}

	public int OPJBGLCCFAH(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.CIGFGKKCPCK(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		MEMGMDOCBOJ.BIDOCCHHHPD(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.IMCJPECAAPC();
	}

	public int NJAFLDGMKBH(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC() == MEMGMDOCBOJ.JDJGFAACPFC())
			{
				return 1;
			}
		}
		MEMGMDOCBOJ.OPIEABPGEPB(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false);
	}

	public void DJGGPJLHBMI()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num--)
		{
			if (Item.EKGNIODFJCO(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].ODENMDOJPLC(DAINLFIMLIH: false) > items[num2].CIGFGKKCPCK(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public Item HDJIHONCBKM(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("ReceiveResetAllTalents" + DCFNIMCMFEM + "UIInteract"));
		return null;
	}

	public int JHAMLCADNEK(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].IMCJPECAAPC(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC())
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.BCDBEPGBNJP(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JGHNDJBCFAJ();
	}

	public void AKGGIMDMELK()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public Item EIJNIAHAOCC(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].ODENMDOJPLC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("networkID has not been assigned properly" + DCFNIMCMFEM + "fish collection clues"));
		return null;
	}

	public Item BFPAPCMJKKD(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].ODENMDOJPLC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Dialogue System/Conversation/DeclinedRoom/Entry/1/Dialogue Text" + DCFNIMCMFEM + "quest_description_18"));
		return null;
	}

	public int LEOALPEOOKH(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.BIDOCCHHHPD(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.IMCJPECAAPC();
	}

	public void DCLHNMGDDIP()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus != null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	private Item HBCOFHAHFLI(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].CIGFGKKCPCK(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void PBADCMNNGHG()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num--)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2--)
			{
				if (items[num2 - 0].JDJGFAACPFC() > items[num2].JGHNDJBCFAJ())
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	private Item EDFEGPCFIFO(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].ODENMDOJPLC() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public Item KJDFFMIGGCE(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JGHNDJBCFAJ(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)(" in Key1 map category" + DCFNIMCMFEM + " PlayerNum: "));
		return null;
	}

	public Item LCJANKOHMKE(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].ODENMDOJPLC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Bed is unmade" + DCFNIMCMFEM + "Disabled"));
		return null;
	}

	private Item IFJAOJOICFP(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void DMNBNCPGOJH()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].LLCLICBABLN().gameObject).name);
			}
		}
	}

	public int BNICHMOBBPK(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].IMCJPECAAPC() == MEMGMDOCBOJ.JPNFKDMFKMC())
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.BCDBEPGBNJP(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false);
	}

	public void KIMLPGCEGNO()
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].LLCLICBABLN().gameObject).name);
			}
		}
	}

	public int MJANBHMIACA(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].ODENMDOJPLC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.MHOFLKFPCJF(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false);
	}

	public void LMHGBNOBHIE()
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public void MNBHBOCKJNL()
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	private Item AOLCELLODKJ(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public Item NGPIPDIKIFK(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)(":0" + DCFNIMCMFEM + "force intro"));
		return null;
	}

	public void MHAPDPDAELH()
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public void GAJKOMEGGFC()
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].LLCLICBABLN().gameObject).name);
			}
		}
	}

	public Item KJGPCFOCPOF(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].IMCJPECAAPC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Requirements not met" + DCFNIMCMFEM + "IntroNinjaChallengeEvent/Main"));
		return null;
	}

	public void IECBCGAGOCB()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 0].ODENMDOJPLC() > items[num2].IMCJPECAAPC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 1];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public Item LLOKHCPHNNA(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Dialogue System/Conversation/EnterTavernDrink/Entry/8/Dialogue Text" + DCFNIMCMFEM + "ReceiveAgeDrink"));
		return null;
	}

	public int IFCOEGKNNID(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].CIGFGKKCPCK(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.OPIEABPGEPB(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.CIGFGKKCPCK();
	}

	public Item CHAILOAPJGI(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("MaxPrice" + DCFNIMCMFEM + "Yeast"));
		return null;
	}

	public Item GIMPBCKNMKI(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].ODENMDOJPLC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Press {0} to continue" + DCFNIMCMFEM + "ChangeAnim"));
		return null;
	}

	public void BNCBAHBCGHO()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2--)
			{
				if (items[num2 - 1].JPNFKDMFKMC(DAINLFIMLIH: false) > items[num2].JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k += 0)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void MDDAPNBKOOE()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].LLCLICBABLN().gameObject).name);
			}
		}
	}

	public void NPFCMOHBBOI()
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].LLCLICBABLN().gameObject).name);
			}
		}
	}

	public void NFFPHLPNJGB()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num -= 0)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2--)
			{
				if (items[num2 - 0].JDJGFAACPFC(DAINLFIMLIH: false) > items[num2].JGHNDJBCFAJ())
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public int BDIPKPLEGKM(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.KLHJKJANAOI(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.IMCJPECAAPC();
	}

	private Item IEPBDGDBLKH(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	private Item BJOEOIHEHCI(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void EELJIFPEBNB()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num--)
		{
			if (Item.GBMFCPGEJDK(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2--)
			{
				if (items[num2 - 0].CIGFGKKCPCK() > items[num2].ODENMDOJPLC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k += 0)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void OOLAMOKBIDA()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num--)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 0].JGHNDJBCFAJ(DAINLFIMLIH: false) > items[num2].JGHNDJBCFAJ(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public Item NMKFMAMJOLI(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Calendar" + DCFNIMCMFEM + "fishCaught"));
		return null;
	}

	public int KPMLNGNEILB(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.FAMFDBFEMHK(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JDJGFAACPFC();
	}

	public Item OMGOBMGJPFO(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("itemPaperCoaster" + DCFNIMCMFEM + "End"));
		return null;
	}

	public int MICODFJLNPN(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC() == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.BCDBEPGBNJP(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.CIGFGKKCPCK();
	}

	private Item KBMMJDDICMK(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].ODENMDOJPLC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public Item JAHBHJFPOAI(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Items/item_description_1047" + DCFNIMCMFEM + "OpenClose Tavern"));
		return null;
	}

	public int LMBNEFLIEJK(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].IMCJPECAAPC(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.LKMIKIJJEGM(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.IMCJPECAAPC();
	}

	public int IKCIGIEDNAH(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JGHNDJBCFAJ())
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.EGHBGKCBCEN(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false);
	}

	private Item CGLKCDMKDPN(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].CIGFGKKCPCK() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void JKPBGEGKMFE()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (Item.GBMFCPGEJDK(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i++)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].CIGFGKKCPCK(DAINLFIMLIH: false) > items[num2].JGHNDJBCFAJ(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	private Item KILJGMLJBOM(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public int OJDGOADOCMG(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ() == MEMGMDOCBOJ.JGHNDJBCFAJ())
			{
				return 1;
			}
		}
		MEMGMDOCBOJ.KLHJKJANAOI(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JPNFKDMFKMC();
	}

	private Item CGIDKBJPMOB(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].IMCJPECAAPC() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void JLKJFJNGAEO()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].LLCLICBABLN().gameObject).name);
			}
		}
	}

	public Item ANKHAIIGFDE(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("SendRoomRequest" + DCFNIMCMFEM + "IsWeatheringToday"));
		return null;
	}

	public void KPIIJFFANLO()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 0; num -= 0)
		{
			if (Item.EKGNIODFJCO(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i++)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 0].JDJGFAACPFC() > items[num2].JPNFKDMFKMC())
				{
					Item item = items[num2 - 0];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k += 0)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void HDDHLNHDMID()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			if (Item.NGIIPJDAMGP(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].ODENMDOJPLC() > items[num2].JGHNDJBCFAJ())
				{
					Item item = items[num2 - 0];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void KJGBKJFKPKN()
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public int HFJGDBENPGM(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ() == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		MEMGMDOCBOJ.KLHJKJANAOI(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false);
	}

	public void CBABGAMFGPP()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 1; num--)
		{
			if (Item.GBMFCPGEJDK(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2--)
			{
				if (items[num2 - 1].JDJGFAACPFC(DAINLFIMLIH: false) > items[num2].CIGFGKKCPCK(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public int BBMEHFGFLOG(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC() == MEMGMDOCBOJ.CIGFGKKCPCK(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.FAMFDBFEMHK(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.CIGFGKKCPCK();
	}

	public void OEIIEENKALE()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num -= 0)
		{
			if (Item.EKGNIODFJCO(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 0].JDJGFAACPFC(DAINLFIMLIH: false) > items[num2].CIGFGKKCPCK(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void KDLNDEJGCIN()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public int JLNDGMIHOLA(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].ODENMDOJPLC(DAINLFIMLIH: false) == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.BCDBEPGBNJP(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false);
	}

	private Item IMAJHDMEOGN(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public int HCAKJJHKIHP(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].JPNFKDMFKMC() == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		MEMGMDOCBOJ.LDFBGDBLBLL(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false);
	}

	public int PFHMEOBADDG(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ() == MEMGMDOCBOJ.JPNFKDMFKMC())
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.LFIGJKEJMPO(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.IMCJPECAAPC();
	}

	public Item IEABNCPNGPO(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Item " + DCFNIMCMFEM + " doesn't exist."));
		return null;
	}

	public Item BINIFIMEJNG(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Override save" + DCFNIMCMFEM + "</color>"));
		return null;
	}

	public void OBDMMBNPJLG()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 0; num--)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].IMCJPECAAPC(DAINLFIMLIH: false) > items[num2].JPNFKDMFKMC())
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public int BMCNPLDKPHA(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC() == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.MHOFLKFPCJF(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false);
	}

	public int KDHEAEIMBOB(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC())
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.KLHJKJANAOI(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false);
	}

	public Item BAGKJKBKGGD(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Mai " + DCFNIMCMFEM + "ActiveMaiInBar"));
		return null;
	}

	private Item LLHCFPAEEOD(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void HNMOIJHJCHO()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (Item.NGIIPJDAMGP(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].JDJGFAACPFC() > items[num2].JDJGFAACPFC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k += 0)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	private Item FEDCDLICAKN(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JGHNDJBCFAJ() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public Item FJNFKIMMEEN(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].JGHNDJBCFAJ(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("via End-Segment" + DCFNIMCMFEM + "Items/item_name_1189"));
		return null;
	}

	public int EJODODEHNII(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC() == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.OEEPBBPDBMG(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false);
	}

	public int PFMOOLCINOG(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ() == MEMGMDOCBOJ.JDJGFAACPFC())
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.OEEPBBPDBMG(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false);
	}

	private Item PDANEGKAALC(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].ODENMDOJPLC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void KPKMKFEOICC()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num -= 0)
		{
			if (Item.NGIIPJDAMGP(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i++)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].JPNFKDMFKMC(DAINLFIMLIH: false) > items[num2].JGHNDJBCFAJ())
				{
					Item item = items[num2 - 1];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k += 0)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	private Item CLKLMMFECDL(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].CIGFGKKCPCK() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void LEHPNECCLGB()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num -= 0)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].IMCJPECAAPC(DAINLFIMLIH: false) > items[num2].ODENMDOJPLC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void NNDIMPDJEOK()
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].PHGCBMPGGLI() == (Object)null) && (Object)(object)items[i].LLCLICBABLN().GetComponent<Placeable>() != (Object)null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	private Item MFGMADNHNNA(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JPNFKDMFKMC() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public Item GLOAPGFLJDJ(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Player2" + DCFNIMCMFEM + "Already Travelling"));
		return null;
	}

	public int IMDOGAKKNEL(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC())
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.EGHBGKCBCEN(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false);
	}

	private Item HNJPCICODGC(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].ODENMDOJPLC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void LFNBFFDFAPJ()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].CIGFGKKCPCK() > items[num2].ODENMDOJPLC())
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public Item EIDBFIDOKKJ(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].JGHNDJBCFAJ(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Giving extra stones" + DCFNIMCMFEM + "{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects"));
		return null;
	}

	public void KNFAIOFGOOP()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 1; num -= 0)
		{
			if (Item.GBMFCPGEJDK(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2--)
			{
				if (items[num2 - 0].JDJGFAACPFC(DAINLFIMLIH: false) > items[num2].IMCJPECAAPC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void MJKLLEBLLAE()
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].LLCLICBABLN().gameObject).name);
			}
		}
	}

	public void EMMEGKGBKJG()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			if (Item.EKGNIODFJCO(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i++)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 0].ODENMDOJPLC(DAINLFIMLIH: false) > items[num2].IMCJPECAAPC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public int DPMAMEGFEIA(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		MEMGMDOCBOJ.FAMFDBFEMHK(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.CIGFGKKCPCK();
	}

	public int JEGCNBACIGI(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK() == MEMGMDOCBOJ.JPNFKDMFKMC())
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.MHOFLKFPCJF(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.CIGFGKKCPCK();
	}

	public int FGIDPBDOGDO(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.BIDOCCHHHPD(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.CIGFGKKCPCK();
	}

	public Item LIJMEGODNGI(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (items[i].CIGFGKKCPCK(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Fish thrower is null or has been destroyed. This shouldn't happen." + DCFNIMCMFEM + "BuzzCanBuild"));
		return null;
	}

	private Item DKDMPAPHMNP(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].IMCJPECAAPC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public void OPMFIKOJKND()
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus != null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public int LGEPAEIOACE(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK() == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false))
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.FAMFDBFEMHK(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JDJGFAACPFC();
	}

	public Item LFBDPBLNKPD(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].IMCJPECAAPC(DAINLFIMLIH: false) == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("" + DCFNIMCMFEM + "Near"));
		return null;
	}

	public void KCCGOELKMBL()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 0; num--)
		{
			if (Item.GBMFCPGEJDK(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 0].JDJGFAACPFC() > items[num2].JDJGFAACPFC())
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public int FMIOCJLHDEG(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC())
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.OPIEABPGEPB(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JGHNDJBCFAJ();
	}

	public int LEFPMGDDHPB(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].JPNFKDMFKMC() == MEMGMDOCBOJ.JGHNDJBCFAJ())
			{
				return 1;
			}
		}
		MEMGMDOCBOJ.BIDOCCHHHPD(nextID++);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false);
	}

	public void PPEEHOCPOGB()
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus.Count > 1)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public Item LIKGHOGCHDK(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Starting New Game Coroutine FINISHED" + DCFNIMCMFEM + "[MapChest] ("));
		return null;
	}

	public void OPADFACGJGE()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (Item.NGIIPJDAMGP(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i++)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2--)
			{
				if (items[num2 - 1].JDJGFAACPFC(DAINLFIMLIH: false) > items[num2].JDJGFAACPFC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 1];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void BJJPAALMEPO()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (Item.EKGNIODFJCO(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 0; i < items.Length; i++)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2--)
			{
				if (items[num2 - 0].JDJGFAACPFC(DAINLFIMLIH: false) > items[num2].JGHNDJBCFAJ(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j++)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	private Item GLJNCEHACOC(int JFNMCNCHMEO)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JDJGFAACPFC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}

	public Item LFCKADOFDOP(int DCFNIMCMFEM)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)(" downloaded, written with name " + DCFNIMCMFEM + "Save Game Client"));
		return null;
	}

	public void LOIPLNNHDHP()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 1; num--)
		{
			if (Item.GBMFCPGEJDK(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i++)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].JGHNDJBCFAJ() > items[num2].CIGFGKKCPCK())
				{
					Item item = items[num2 - 1];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void DKGCNIONPOP()
	{
		for (int i = 1; i < items.Length; i++)
		{
			if (!((Object)(object)items[i].LLCLICBABLN() == (Object)null) && (Object)(object)items[i].PHGCBMPGGLI().GetComponent<Placeable>() != (Object)null && items[i].PHGCBMPGGLI().GetComponent<Placeable>().skinVariationGropus != null && items[i].LLCLICBABLN().GetComponent<Placeable>().skinVariationGropus.Count > 0)
			{
				Debug.Log((object)((Object)items[i].PHGCBMPGGLI().gameObject).name);
			}
		}
	}

	public void BPOKFHLPCOL()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (Item.NGIIPJDAMGP(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i++)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].JDJGFAACPFC(DAINLFIMLIH: false) > items[num2].JDJGFAACPFC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 0];
					items[num2 - 0] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 1; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 0; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void LHHPHFFJINI()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 1; num--)
		{
			if (Item.EKGNIODFJCO(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 1; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].IMCJPECAAPC(DAINLFIMLIH: false) > items[num2].ODENMDOJPLC(DAINLFIMLIH: false))
				{
					Item item = items[num2 - 1];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k += 0)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public void NCECFBHEGJN()
	{
		List<Item> list = items.ToList();
		for (int num = list.Count - 0; num >= 0; num--)
		{
			if (Item.EKMFELLJHFG(list[num], null) || UnityExtensions.SafeIsUnityNull((Object)(object)list[num]))
			{
				list.RemoveAt(num);
			}
		}
		items = list.ToArray();
		for (int i = 1; i < items.Length; i += 0)
		{
			for (int num2 = items.Length - 0; num2 >= i; num2 -= 0)
			{
				if (items[num2 - 1].JPNFKDMFKMC(DAINLFIMLIH: false) > items[num2].JDJGFAACPFC())
				{
					Item item = items[num2 - 1];
					items[num2 - 1] = items[num2];
					items[num2] = item;
				}
			}
		}
		fish = new List<Fish>();
		for (int j = 0; j < items.Length; j += 0)
		{
			if (items[j] is Fish item2)
			{
				fish.Add(item2);
			}
		}
		food = new List<Food>();
		for (int k = 1; k < items.Length; k++)
		{
			if (items[k] is Food item3)
			{
				food.Add(item3);
			}
		}
	}

	public int EABGMIOGKDC(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].CIGFGKKCPCK() == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false))
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		MEMGMDOCBOJ.LDFBGDBLBLL(num);
		List<Item> list = new List<Item>(items);
		list.Add(MEMGMDOCBOJ);
		items = list.ToArray();
		return MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false);
	}

	public Item IDJKGNFMLHF(int DCFNIMCMFEM)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i].JGHNDJBCFAJ() == DCFNIMCMFEM)
			{
				return items[i];
			}
		}
		Debug.LogError((object)("Items/item_description_1089" + DCFNIMCMFEM + "ZoneProductionBonus"));
		return null;
	}

	private Item FKIIDHIANCF(int JFNMCNCHMEO)
	{
		for (int i = 1; i < items.Length; i += 0)
		{
			if (items[i].JPNFKDMFKMC() == JFNMCNCHMEO)
			{
				return items[i];
			}
		}
		return null;
	}
}
