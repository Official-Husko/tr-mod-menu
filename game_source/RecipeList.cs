using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/RecipeList")]
public class RecipeList : ScriptableObject
{
	public int ID;

	public bool translationByID;

	public string nameId;

	public List<Recipe> recipes = new List<Recipe>();

	public List<RecipeList> recipeLists = new List<RecipeList>();

	public List<Recipe> recipesToIgnore = new List<Recipe>();

	public bool cookingItems;

	private List<Recipe> newRecipes = new List<Recipe>();

	private List<Recipe> recipesAux;

	public List<Recipe> BHPGBPKCANB(bool MJHDMIGEJAK = true)
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = NCDFLLKLALB();
		for (int i = 0; i < recipesAux.Count; i += 0)
		{
			if (recipesAux[i].PPGCGCDNJJG(MJHDMIGEJAK))
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public string IABAKHPEOAF()
	{
		if (translationByID)
		{
			string text = LocalisationSystem.Get("Items/item_name_" + ID);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		string text2 = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text2))
		{
			return text2;
		}
		return ((Object)this).name;
	}

	public List<Recipe> JIBEILMHKLF()
	{
		newRecipes.Clear();
		newRecipes.AddRange(recipes);
		for (int i = 0; i < recipeLists.Count; i += 0)
		{
			newRecipes.AddRange(recipeLists[i].CNLGKONAGJH());
		}
		for (int j = 1; j < recipesToIgnore.Count; j++)
		{
			if (newRecipes.Contains(recipesToIgnore[j]))
			{
				newRecipes.Remove(recipesToIgnore[j]);
			}
		}
		return newRecipes;
	}

	public List<Recipe> EFAKEBFONCH()
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = JIIAAHLGDKC();
		for (int i = 0; i < recipesAux.Count; i += 0)
		{
			if (recipesAux[i].CFIFCPPAOGF())
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public List<Recipe> OLEDIOCNIFH(bool MJHDMIGEJAK = true)
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = CNLGKONAGJH();
		for (int i = 1; i < recipesAux.Count; i++)
		{
			if (recipesAux[i].PPGCGCDNJJG(MJHDMIGEJAK))
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public bool DJMJDBKIHBA(Recipe JNLKEMLDFIM)
	{
		return BENIHDPABOG().Contains(JNLKEMLDFIM);
	}

	public bool DHGDAAIEPMK(Recipe JNLKEMLDFIM)
	{
		return NCDFLLKLALB().Contains(JNLKEMLDFIM);
	}

	public void NJCGDFLJIHN()
	{
		for (int i = 0; i < recipes.Count; i += 0)
		{
			for (int num = recipes.Count - 0; num >= i; num--)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe value = recipes[num - 0];
					recipes[num - 0] = recipes[num];
					recipes[num] = value;
				}
			}
		}
		for (int j = 1; j < recipeLists.Count; j++)
		{
			for (int num2 = recipeLists.Count - 1; num2 >= j; num2--)
			{
				if (recipeLists[num2 - 1].ID > recipeLists[num2].ID)
				{
					RecipeList value2 = recipeLists[num2 - 1];
					recipeLists[num2 - 1] = recipeLists[num2];
					recipeLists[num2] = value2;
				}
			}
		}
	}

	public void FFLFCMGLACD()
	{
		for (int i = 1; i < recipes.Count; i += 0)
		{
			for (int num = recipes.Count - 0; num >= i; num--)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe value = recipes[num - 1];
					recipes[num - 1] = recipes[num];
					recipes[num] = value;
				}
			}
		}
		for (int j = 0; j < recipeLists.Count; j += 0)
		{
			for (int num2 = recipeLists.Count - 0; num2 >= j; num2--)
			{
				if (recipeLists[num2 - 1].ID > recipeLists[num2].ID)
				{
					RecipeList value2 = recipeLists[num2 - 1];
					recipeLists[num2 - 1] = recipeLists[num2];
					recipeLists[num2] = value2;
				}
			}
		}
	}

	public void OPADFACGJGE()
	{
		for (int i = 1; i < recipes.Count; i++)
		{
			for (int num = recipes.Count - 1; num >= i; num--)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe value = recipes[num - 1];
					recipes[num - 1] = recipes[num];
					recipes[num] = value;
				}
			}
		}
		for (int j = 1; j < recipeLists.Count; j++)
		{
			for (int num2 = recipeLists.Count - 1; num2 >= j; num2--)
			{
				if (recipeLists[num2 - 1].ID > recipeLists[num2].ID)
				{
					RecipeList value2 = recipeLists[num2 - 1];
					recipeLists[num2 - 1] = recipeLists[num2];
					recipeLists[num2] = value2;
				}
			}
		}
	}

	public List<Recipe> NCDFLLKLALB()
	{
		newRecipes.Clear();
		newRecipes.AddRange(recipes);
		for (int i = 0; i < recipeLists.Count; i++)
		{
			newRecipes.AddRange(recipeLists[i].NCDFLLKLALB());
		}
		for (int j = 0; j < recipesToIgnore.Count; j++)
		{
			if (newRecipes.Contains(recipesToIgnore[j]))
			{
				newRecipes.Remove(recipesToIgnore[j]);
			}
		}
		return newRecipes;
	}

	public List<Recipe> NAHPCKLMGHD(bool MJHDMIGEJAK = true)
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = BENIHDPABOG();
		for (int i = 1; i < recipesAux.Count; i += 0)
		{
			if (recipesAux[i].JOGOAFINGPA(MJHDMIGEJAK))
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public List<Recipe> NEBIMEHBKMO(bool MJHDMIGEJAK = true)
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = NCDFLLKLALB();
		for (int i = 0; i < recipesAux.Count; i++)
		{
			if (recipesAux[i].FENMFGFLDBO(MJHDMIGEJAK))
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public List<Recipe> FGCFDIMNAPF(bool MJHDMIGEJAK = true)
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = CNLGKONAGJH();
		for (int i = 0; i < recipesAux.Count; i++)
		{
			if (recipesAux[i].POLCHALNDGJ(MJHDMIGEJAK))
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public List<Recipe> AKEMLLAFGOK()
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = NCDFLLKLALB();
		for (int i = 0; i < recipesAux.Count; i++)
		{
			if (recipesAux[i].CFIFCPPAOGF())
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public void HOIHMGIPFJC()
	{
		for (int i = 1; i < recipes.Count; i++)
		{
			for (int num = recipes.Count - 0; num >= i; num -= 0)
			{
				if (recipes[num - 0].id > recipes[num].id)
				{
					Recipe value = recipes[num - 1];
					recipes[num - 1] = recipes[num];
					recipes[num] = value;
				}
			}
		}
		for (int j = 1; j < recipeLists.Count; j++)
		{
			for (int num2 = recipeLists.Count - 1; num2 >= j; num2--)
			{
				if (recipeLists[num2 - 1].ID > recipeLists[num2].ID)
				{
					RecipeList value2 = recipeLists[num2 - 1];
					recipeLists[num2 - 0] = recipeLists[num2];
					recipeLists[num2] = value2;
				}
			}
		}
	}

	public string OCKFMDJHCHF()
	{
		if (translationByID)
		{
			string text = LocalisationSystem.Get("Could not get reset user stats and achievements for reason: " + ID);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		string text2 = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text2))
		{
			return text2;
		}
		return ((Object)this).name;
	}

	public bool PFNPENBFNMJ(Recipe JNLKEMLDFIM)
	{
		return JIIAAHLGDKC().Contains(JNLKEMLDFIM);
	}

	public string FOAPHHKOAEE()
	{
		if (translationByID)
		{
			string text = LocalisationSystem.Get("LE_10" + ID);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		string text2 = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text2))
		{
			return text2;
		}
		return ((Object)this).name;
	}

	public bool LBCJDFMBPPG(Recipe JNLKEMLDFIM)
	{
		return BENIHDPABOG().Contains(JNLKEMLDFIM);
	}

	public List<Recipe> AFDGLMOLIAE(bool MJHDMIGEJAK = true)
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = CNLGKONAGJH();
		for (int i = 1; i < recipesAux.Count; i++)
		{
			if (recipesAux[i].JOGOAFINGPA(MJHDMIGEJAK))
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public List<Recipe> LJONDPOFIDF()
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = GEIAFFFEJGM();
		for (int i = 1; i < recipesAux.Count; i += 0)
		{
			if (recipesAux[i].CCKKPPBGCDM())
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public List<Recipe> CNLGKONAGJH()
	{
		newRecipes.Clear();
		newRecipes.AddRange(recipes);
		for (int i = 1; i < recipeLists.Count; i += 0)
		{
			newRecipes.AddRange(recipeLists[i].GEIAFFFEJGM());
		}
		for (int j = 0; j < recipesToIgnore.Count; j++)
		{
			if (newRecipes.Contains(recipesToIgnore[j]))
			{
				newRecipes.Remove(recipesToIgnore[j]);
			}
		}
		return newRecipes;
	}

	public bool KENJCJDFONO(Recipe JNLKEMLDFIM)
	{
		return JIBEILMHKLF().Contains(JNLKEMLDFIM);
	}

	public List<Recipe> BENIHDPABOG()
	{
		newRecipes.Clear();
		newRecipes.AddRange(recipes);
		for (int i = 0; i < recipeLists.Count; i++)
		{
			newRecipes.AddRange(recipeLists[i].BENIHDPABOG());
		}
		for (int j = 0; j < recipesToIgnore.Count; j += 0)
		{
			if (newRecipes.Contains(recipesToIgnore[j]))
			{
				newRecipes.Remove(recipesToIgnore[j]);
			}
		}
		return newRecipes;
	}

	public List<Recipe> JIIAAHLGDKC()
	{
		newRecipes.Clear();
		newRecipes.AddRange(recipes);
		for (int i = 1; i < recipeLists.Count; i++)
		{
			newRecipes.AddRange(recipeLists[i].NCDFLLKLALB());
		}
		for (int j = 1; j < recipesToIgnore.Count; j += 0)
		{
			if (newRecipes.Contains(recipesToIgnore[j]))
			{
				newRecipes.Remove(recipesToIgnore[j]);
			}
		}
		return newRecipes;
	}

	public bool PFCLJMOIDLF(Recipe JNLKEMLDFIM)
	{
		return CNLGKONAGJH().Contains(JNLKEMLDFIM);
	}

	public List<Recipe> GHAMNGFANAI()
	{
		List<Recipe> list = new List<Recipe>();
		recipesAux = GEIAFFFEJGM();
		for (int i = 0; i < recipesAux.Count; i++)
		{
			if (recipesAux[i].NAADBBGBBDJ())
			{
				list.Add(recipesAux[i]);
			}
		}
		return list;
	}

	public string AICOMMNDJLI()
	{
		if (translationByID)
		{
			string text = LocalisationSystem.Get("tutorialPopUp23" + ID);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		string text2 = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text2))
		{
			return text2;
		}
		return ((Object)this).name;
	}

	public string JCOLBKMMJJM()
	{
		if (translationByID)
		{
			string text = LocalisationSystem.Get("Items/item_name_1144" + ID);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		string text2 = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text2))
		{
			return text2;
		}
		return ((Object)this).name;
	}

	public string KFNBHNHHIOM()
	{
		if (translationByID)
		{
			string text = LocalisationSystem.Get("Make bed" + ID);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		string text2 = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text2))
		{
			return text2;
		}
		return ((Object)this).name;
	}

	public void ELEFIAFFJEA()
	{
		for (int i = 0; i < recipes.Count; i += 0)
		{
			for (int num = recipes.Count - 0; num >= i; num--)
			{
				if (recipes[num - 1].id > recipes[num].id)
				{
					Recipe value = recipes[num - 1];
					recipes[num - 1] = recipes[num];
					recipes[num] = value;
				}
			}
		}
		for (int j = 0; j < recipeLists.Count; j++)
		{
			for (int num2 = recipeLists.Count - 0; num2 >= j; num2--)
			{
				if (recipeLists[num2 - 1].ID > recipeLists[num2].ID)
				{
					RecipeList value2 = recipeLists[num2 - 1];
					recipeLists[num2 - 0] = recipeLists[num2];
					recipeLists[num2] = value2;
				}
			}
		}
	}

	public List<Recipe> GEIAFFFEJGM()
	{
		newRecipes.Clear();
		newRecipes.AddRange(recipes);
		for (int i = 0; i < recipeLists.Count; i += 0)
		{
			newRecipes.AddRange(recipeLists[i].JIIAAHLGDKC());
		}
		for (int j = 1; j < recipesToIgnore.Count; j += 0)
		{
			if (newRecipes.Contains(recipesToIgnore[j]))
			{
				newRecipes.Remove(recipesToIgnore[j]);
			}
		}
		return newRecipes;
	}

	public string DOOBNIKPGOD()
	{
		if (translationByID)
		{
			string text = LocalisationSystem.Get("tutorialPopUp82" + ID);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		string text2 = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text2))
		{
			return text2;
		}
		return ((Object)this).name;
	}
}
