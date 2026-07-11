using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;

public class RecipeDatabase : SerializedScriptableObject
{
	public class RecipesUnlockedBuyingRecipe
	{
		public int itemToBuy;

		public List<Recipe> recipes = new List<Recipe>();
	}

	[Serializable]
	public class RecipeLine
	{
		public int ID;

		public int resultID;

		public string name;

		public int crafterID;

		public string crafterName;

		public int quantity;

		public string page;

		public string unlock;

		public int recipeFragments;

		public int reputation;

		public int fuel;

		public int minutes;

		public int physical;

		public int mental;

		public int nature;

		public List<int> ingredientID = new List<int>();

		public List<int> ingredientQuantity = new List<int>();

		public List<int> modID = new List<int>();
	}

	public Recipe[] recipes;

	public RecipeList[] crafterLists;

	public RecipeList[] recipesBook;

	public Dictionary<int, List<Recipe>> recipesUnlockedBuyingItems = new Dictionary<int, List<Recipe>>();

	public Dictionary<int, Recipe[]> recipesUnlockedCollectingItems = new Dictionary<int, Recipe[]>();

	public ItemDatabase itemDB;

	public TalentDatabase talentDB;

	public List<RecipeLine> recipeFile = new List<RecipeLine>();

	public void PBADCMNNGHG()
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 1; num >= i; num--)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void JALHHGFGMHE()
	{
		for (int i = 1; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 0; num >= i; num -= 0)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	private Recipe MKFJPICCHAO(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void JHGCBBPLOAF(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public int IDFPMEENKAN(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public int AMMOOHFBNHH(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public void AKFBDHOKDFP()
	{
		for (int i = 1; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 0; num >= i; num--)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 1] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void JGNEFPMCKOP()
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 0; num >= i; num--)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void KAPANHOGBJL(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void IADBDLHAEHN(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void HACHPEOPCEC()
	{
		for (int i = 1; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 0; num >= i; num -= 0)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	private Recipe BKLCHDHHLOO(int JFNMCNCHMEO)
	{
		for (int i = 1; i < recipes.Length; i += 0)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void KMGEFGMCABD(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	private Recipe FIBHLBKNIHM(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void GCNAJAPABKB()
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 1; num >= i; num--)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void IEEDHHPPJAH()
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			for (int num = recipes.Length - 0; num >= i; num -= 0)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 1] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void BPOKFHLPCOL()
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			for (int num = recipes.Length - 1; num >= i; num -= 0)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void JKPBGEGKMFE()
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			for (int num = recipes.Length - 1; num >= i; num--)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	private Recipe MJAHDKEMJKF(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public int KIPAHALEDIB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	private Recipe FMIHLHLHMJP(int JFNMCNCHMEO)
	{
		for (int i = 1; i < recipes.Length; i++)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void LDAHNAAJLEA(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void PFKBCLPFIMC(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public int BBDNGBELPCH(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public void DNLDCCNLLLL(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	private Recipe IKJNKAGFFEH(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void GHKEEBENDCN(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void HCHPAJCLFHA()
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 0; num >= i; num--)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 1] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void NCECFBHEGJN()
	{
		for (int i = 1; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 0; num >= i; num--)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public int OJOJDCPJJPC(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	private Recipe CLKIHMNCPDM(int JFNMCNCHMEO)
	{
		for (int i = 1; i < recipes.Length; i++)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	private Recipe JGHALBDNIIF(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void LOMGIBEEMPC(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void EDJOPNNHOPB()
	{
		for (int i = 1; i < recipes.Length; i += 0)
		{
			for (int num = recipes.Length - 1; num >= i; num -= 0)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 1] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public int DAPOINOJGPG(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public int ILIEKKGOLCA(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public int JHIADAFPBHO(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public void GOCAGADEMBD()
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			for (int num = recipes.Length - 0; num >= i; num -= 0)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 1] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void HBCIPJFOPNN()
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 1; num >= i; num -= 0)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 1] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	private Recipe ICMJBGDKMPE(int JFNMCNCHMEO)
	{
		for (int i = 1; i < recipes.Length; i += 0)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void JKCNCFHFCOC()
	{
		for (int i = 1; i < recipes.Length; i += 0)
		{
			for (int num = recipes.Length - 0; num >= i; num -= 0)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void FHIEMMNCILO(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void FENDGIOBEKD()
	{
		for (int i = 1; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 1; num >= i; num--)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void KEFNNJJAGLN(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	private Recipe HABPMHBNIFD(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void IEKHBEOADAM(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void NENMEIBPCAC(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	private Recipe KJGPMJLGJBN(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void FICFKGMOABP(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	private Recipe DPEMMPJOAIJ(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	private Recipe EBOHMMANHMM(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public void PNKILAFGBMG(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void OPADFACGJGE()
	{
		for (int i = 1; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 1; num >= i; num--)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 1] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	private Recipe PHJMAAMPLLJ(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i += 0)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public int BJOICAJPPGM(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public void AOJKDNHGIME(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void AJLHANMPCAA(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void DOCFEDKHCPO(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void FOGMDEKEHJM(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void KJEAIIIKDNB(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void ODGKBBKIALI(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public int JCKKLEFCMBG(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public void BCHJFFCHDBH(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void GHMBNKLNKMD(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 0; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	public void FNGMFHIHHLO(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i++)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	private Recipe CEOPIDBLLEO(int JFNMCNCHMEO)
	{
		for (int i = 1; i < recipes.Length; i += 0)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}

	public int LGGAJBCNDLD(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Add(JNLKEMLDFIM);
		recipes = list.ToArray();
		return JNLKEMLDFIM.id;
	}

	public void PHABECJJCOI()
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 1; num >= i; num -= 0)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 0];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void EJNPGLIIOIL()
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			for (int num = recipes.Length - 1; num >= i; num -= 0)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe recipe = recipes[num - 1];
					recipes[num - 0] = recipes[num];
					recipes[num] = recipe;
				}
			}
		}
	}

	public void FOGDDDGDKAK(int EOACENDMJDI, Recipe JNLKEMLDFIM)
	{
		for (int i = 1; i < crafterLists.Length; i += 0)
		{
			if (crafterLists[i].ID == EOACENDMJDI)
			{
				if (!crafterLists[i].recipes.Contains(JNLKEMLDFIM))
				{
					crafterLists[i].recipes.Add(JNLKEMLDFIM);
				}
			}
			else if (crafterLists[i].recipes.Contains(JNLKEMLDFIM))
			{
				crafterLists[i].recipes.Remove(JNLKEMLDFIM);
			}
		}
	}

	private Recipe MKHACKEMBNP(int JFNMCNCHMEO)
	{
		for (int i = 0; i < recipes.Length; i++)
		{
			if (recipes[i].id == JFNMCNCHMEO)
			{
				return recipes[i];
			}
		}
		return null;
	}
}
