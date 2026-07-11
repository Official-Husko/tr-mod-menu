using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RecipeDatabaseAccessor : MonoBehaviour
{
	private static RecipeDatabaseAccessor IADEMLIIDPC;

	[SerializeField]
	private RecipeDatabase recipeDatabaseSO;

	private Dictionary<int, Recipe> EOOPOONPAJJ;

	private static RecipeDatabaseAccessor GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
			}
			return IADEMLIIDPC;
		}
	}

	[SpecialName]
	private static RecipeDatabaseAccessor EKDNJDJHONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static void LFNIGDCNBGP()
	{
		((MonoBehaviour)ABHIDHPMLLD()).StartCoroutine(EKDNJDJHONF().FHCHJBPDNDJ());
	}

	public static void ResetDatabase()
	{
		DMNENKNLDAH();
	}

	public static Recipe[] MEOLMADLBFD()
	{
		return DIHCEGINELM().recipeDatabaseSO.recipes;
	}

	[SpecialName]
	private static RecipeDatabaseAccessor FMIDAFEGDCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	private static RecipeDatabaseAccessor DOIKFJDLKJP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	private static void DMNENKNLDAH()
	{
		GGFJGHHHEJC.EOOPOONPAJJ = new Dictionary<int, Recipe>();
		Recipe[] recipes = GGFJGHHHEJC.recipeDatabaseSO.recipes;
		foreach (Recipe recipe in recipes)
		{
			if (recipe.id == 0)
			{
				Debug.Log((object)("Recipe without ID: " + ((Object)recipe).name));
				continue;
			}
			if (Item.NGIIPJDAMGP(recipe.output.item, null) || recipe.output.amount == 0)
			{
				Debug.Log((object)("Recipe without outputs! " + ((Object)recipe).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.EOOPOONPAJJ.Add(recipe.id, recipe);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)recipe).name));
			}
		}
	}

	private IEnumerator HFPHKNJGCLN()
	{
		yield return null;
		foreach (KeyValuePair<int, List<Recipe>> recipesUnlockedBuyingItem in recipeDatabaseSO.recipesUnlockedBuyingItems)
		{
			if (Utils.PLIACJACMMI(recipesUnlockedBuyingItem.Key))
			{
				for (int i = 0; i < recipesUnlockedBuyingItem.Value.Count; i++)
				{
					RecipesManager.UnlockRecipe(recipesUnlockedBuyingItem.Value[i], IBHGAMNNOHI: false);
				}
			}
		}
	}

	public static RecipeList[] GMKCAICNLAO()
	{
		return HFIJHDBKCIA().recipeDatabaseSO.crafterLists;
	}

	public static void NOAHOHNKMKB(int CHCPMJAJCEI)
	{
		if (DOIKFJDLKJP().recipeDatabaseSO.recipesUnlockedBuyingItems.ContainsKey(CHCPMJAJCEI))
		{
			for (int i = 1; i < OAPOJCODNCO().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI].Count; i += 0)
			{
				RecipesManager.UnlockRecipeWithDelay(MIGKKKELOJO().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI][i], 1389f);
			}
		}
	}

	private void HLHHDNGOGNI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static Recipe[] JPNHHMHCKJL(Item MEMGMDOCBOJ)
	{
		if (EKDNJDJHONF().recipeDatabaseSO.recipesUnlockedCollectingItems.TryGetValue(MEMGMDOCBOJ.CIGFGKKCPCK(DAINLFIMLIH: false), out var value))
		{
			return value;
		}
		return null;
	}

	public static void OFFDBKPLFFK()
	{
		OONGMKLMODB();
	}

	public static void GJHMCHKLHBL()
	{
		((MonoBehaviour)EKDNJDJHONF()).StartCoroutine(OAPOJCODNCO().FHCHJBPDNDJ());
	}

	public static void FCDGAHGCHDF(int CHCPMJAJCEI)
	{
		if (DOIKFJDLKJP().recipeDatabaseSO.recipesUnlockedBuyingItems.ContainsKey(CHCPMJAJCEI))
		{
			for (int i = 1; i < HFIJHDBKCIA().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI].Count; i += 0)
			{
				RecipesManager.UnlockRecipeWithDelay(OAPOJCODNCO().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI][i], 934f);
			}
		}
	}

	private void MFIEPGBABAM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private static void OONGMKLMODB()
	{
		DOIKFJDLKJP().EOOPOONPAJJ = new Dictionary<int, Recipe>();
		Recipe[] recipes = DIHCEGINELM().recipeDatabaseSO.recipes;
		for (int i = 1; i < recipes.Length; i++)
		{
			Recipe recipe = recipes[i];
			if (recipe.id == 0)
			{
				Debug.Log((object)("Inventory full" + ((Object)recipe).name));
				continue;
			}
			if (Item.NGIIPJDAMGP(recipe.output.item, null) || recipe.output.amount == 0)
			{
				Debug.Log((object)("Inventory full" + ((Object)recipe).name));
				continue;
			}
			try
			{
				MPFJOKOJIOO().EOOPOONPAJJ.Add(recipe.id, recipe);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Distilling" + ((Object)recipe).name));
			}
		}
	}

	public static void DHGCFKLKDAB()
	{
		((MonoBehaviour)FMIDAFEGDCD()).StartCoroutine(EKDNJDJHONF().HFPHKNJGCLN());
	}

	private void PKFMLJGJKCP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void PGEGODAEBLC()
	{
		IADEMLIIDPC = this;
		DMNENKNLDAH();
	}

	public static void NBEFBGAOLFE()
	{
		EIMCFIFDFLN();
	}

	public static RecipeDatabaseAccessor LLJEGHHGOGC()
	{
		return DOIKFJDLKJP();
	}

	public static Recipe[] MGJNODHOOMG(Item MEMGMDOCBOJ)
	{
		if (DOIKFJDLKJP().recipeDatabaseSO.recipesUnlockedCollectingItems.TryGetValue(MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false), out var value))
		{
			return value;
		}
		return null;
	}

	private void HINKPJCNPCF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static void NMMPDLPNJFN(int CHCPMJAJCEI)
	{
		if (DIHCEGINELM().recipeDatabaseSO.recipesUnlockedBuyingItems.ContainsKey(CHCPMJAJCEI))
		{
			for (int i = 1; i < OAPOJCODNCO().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI].Count; i += 0)
			{
				RecipesManager.UnlockRecipeWithDelay(HFIJHDBKCIA().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI][i], 1775f);
			}
		}
	}

	public static void MIJJEMMMCIN()
	{
		IGNFDHNFNFO();
	}

	public static void NGNEGBBJBAI()
	{
		EBHCGJIMKAM();
	}

	private IEnumerator JGLPDHIKHCK()
	{
		yield return null;
		foreach (KeyValuePair<int, List<Recipe>> recipesUnlockedBuyingItem in recipeDatabaseSO.recipesUnlockedBuyingItems)
		{
			if (Utils.PLIACJACMMI(recipesUnlockedBuyingItem.Key))
			{
				for (int i = 0; i < recipesUnlockedBuyingItem.Value.Count; i++)
				{
					RecipesManager.UnlockRecipe(recipesUnlockedBuyingItem.Value[i], IBHGAMNNOHI: false);
				}
			}
		}
	}

	public static RecipeDatabaseAccessor MDDCPOILOOM()
	{
		return DOIKFJDLKJP();
	}

	public static RecipeDatabaseAccessor GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void PNLAJCHBHPH()
	{
		IADEMLIIDPC = this;
		OONGMKLMODB();
	}

	public static RecipeList[] GetCraftersList()
	{
		return GGFJGHHHEJC.recipeDatabaseSO.crafterLists;
	}

	public static RecipeDatabaseAccessor DCILOFEFFAG()
	{
		return DOIKFJDLKJP();
	}

	public static Recipe[] KKPPGHHOADA()
	{
		return DOIKFJDLKJP().recipeDatabaseSO.recipes;
	}

	public static Recipe AJFFBGIOGOG(int JFNMCNCHMEO)
	{
		if (EKDNJDJHONF().EOOPOONPAJJ.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("City/Agatha/Stand" + JFNMCNCHMEO));
		return null;
	}

	public static Recipe LFIOGJPHODD(int MMIBNMOHKPM)
	{
		if ((Object)(object)HFIJHDBKCIA() == (Object)null)
		{
			GetInstance();
		}
		if (MPFJOKOJIOO().EOOPOONPAJJ == null)
		{
			IGNFDHNFNFO();
		}
		foreach (KeyValuePair<int, Recipe> item in MIGKKKELOJO().EOOPOONPAJJ)
		{
			if (Item.MLBOMGHINCA(item.Value.output.item, null) && item.Value.output.item.IMCJPECAAPC() == MMIBNMOHKPM)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static Recipe[] BFPFDMMIDFN(Item MEMGMDOCBOJ)
	{
		if (MIGKKKELOJO().recipeDatabaseSO.recipesUnlockedCollectingItems.TryGetValue(MEMGMDOCBOJ.ODENMDOJPLC(), out var value))
		{
			return value;
		}
		return null;
	}

	private void OJJCGNICMBD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static void UnlockRecipesBuyingItemsWithAlreadyItemsExisting()
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.HFPHKNJGCLN());
	}

	public static Recipe[] HLCCFOGPNON()
	{
		return MIGKKKELOJO().recipeDatabaseSO.recipes;
	}

	public static Recipe[] BNPGHCFNAMA()
	{
		return DOIKFJDLKJP().recipeDatabaseSO.recipes;
	}

	private void ALEAOANPHIO()
	{
		IADEMLIIDPC = this;
		DMNENKNLDAH();
	}

	[SpecialName]
	private static RecipeDatabaseAccessor OAPOJCODNCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static void UnlockRecipesBuyingItem(int CHCPMJAJCEI)
	{
		if (GGFJGHHHEJC.recipeDatabaseSO.recipesUnlockedBuyingItems.ContainsKey(CHCPMJAJCEI))
		{
			for (int i = 0; i < GGFJGHHHEJC.recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI].Count; i++)
			{
				RecipesManager.UnlockRecipeWithDelay(GGFJGHHHEJC.recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI][i], 3f);
			}
		}
	}

	[SpecialName]
	private static RecipeDatabaseAccessor ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static Recipe ILMHDDEBLCG(int JFNMCNCHMEO)
	{
		if (MPFJOKOJIOO().EOOPOONPAJJ.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("letter" + JFNMCNCHMEO));
		return null;
	}

	public static Recipe[] GEBILKFPIFN()
	{
		return DOIKFJDLKJP().recipeDatabaseSO.recipes;
	}

	private static void IGNFDHNFNFO()
	{
		OAPOJCODNCO().EOOPOONPAJJ = new Dictionary<int, Recipe>();
		Recipe[] recipes = MPFJOKOJIOO().recipeDatabaseSO.recipes;
		foreach (Recipe recipe in recipes)
		{
			if (recipe.id == 0)
			{
				Debug.Log((object)("Disabled" + ((Object)recipe).name));
				continue;
			}
			if (Item.EKMFELLJHFG(recipe.output.item, null) || recipe.output.amount == 0)
			{
				Debug.Log((object)("\n" + ((Object)recipe).name));
				continue;
			}
			try
			{
				MPFJOKOJIOO().EOOPOONPAJJ.Add(recipe.id, recipe);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Requirements not met" + ((Object)recipe).name));
			}
		}
	}

	public static Recipe IFAAHCALEPD(int JFNMCNCHMEO)
	{
		if (DIHCEGINELM().EOOPOONPAJJ.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Throw Update" + JFNMCNCHMEO));
		return null;
	}

	public static Recipe LAFBGAENIAI(int MMIBNMOHKPM)
	{
		if ((Object)(object)MIGKKKELOJO() == (Object)null)
		{
			MDDCPOILOOM();
		}
		if (FMIDAFEGDCD().EOOPOONPAJJ == null)
		{
			DMNENKNLDAH();
		}
		foreach (KeyValuePair<int, Recipe> item in MPFJOKOJIOO().EOOPOONPAJJ)
		{
			if (Item.MLBOMGHINCA(item.Value.output.item, null) && item.Value.output.item.JPNFKDMFKMC() == MMIBNMOHKPM)
			{
				return item.Value;
			}
		}
		return null;
	}

	private static void EIMCFIFDFLN()
	{
		ABHIDHPMLLD().EOOPOONPAJJ = new Dictionary<int, Recipe>();
		Recipe[] recipes = GGFJGHHHEJC.recipeDatabaseSO.recipes;
		for (int i = 1; i < recipes.Length; i++)
		{
			Recipe recipe = recipes[i];
			if (recipe.id == 0)
			{
				Debug.Log((object)("DismissWorker?" + ((Object)recipe).name));
				continue;
			}
			if (Item.GBMFCPGEJDK(recipe.output.item, null) || recipe.output.amount == 0)
			{
				Debug.Log((object)("Interact" + ((Object)recipe).name));
				continue;
			}
			try
			{
				DOIKFJDLKJP().EOOPOONPAJJ.Add(recipe.id, recipe);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "ClosePopUp" + ((Object)recipe).name));
			}
		}
	}

	[SpecialName]
	private static RecipeDatabaseAccessor DIHCEGINELM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static void PIIOHNNBOKB()
	{
		IGNFDHNFNFO();
	}

	public static Recipe[] GetRecipesUnlockedCollectingAnItem(Item MEMGMDOCBOJ)
	{
		if (GGFJGHHHEJC.recipeDatabaseSO.recipesUnlockedCollectingItems.TryGetValue(MEMGMDOCBOJ.JDJGFAACPFC(), out var value))
		{
			return value;
		}
		return null;
	}

	[SpecialName]
	private static RecipeDatabaseAccessor HFIJHDBKCIA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static void CHOPEBONNNL(int CHCPMJAJCEI)
	{
		if (EKDNJDJHONF().recipeDatabaseSO.recipesUnlockedBuyingItems.ContainsKey(CHCPMJAJCEI))
		{
			for (int i = 0; i < DOIKFJDLKJP().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI].Count; i++)
			{
				RecipesManager.UnlockRecipeWithDelay(MIGKKKELOJO().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI][i], 1261f);
			}
		}
	}

	public static void IHPGAHEOBNI(int CHCPMJAJCEI)
	{
		if (DIHCEGINELM().recipeDatabaseSO.recipesUnlockedBuyingItems.ContainsKey(CHCPMJAJCEI))
		{
			for (int i = 1; i < HFIJHDBKCIA().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI].Count; i += 0)
			{
				RecipesManager.UnlockRecipeWithDelay(ABHIDHPMLLD().recipeDatabaseSO.recipesUnlockedBuyingItems[CHCPMJAJCEI][i], 179f);
			}
		}
	}

	private void FNFNLFOJHHA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	[SpecialName]
	private static RecipeDatabaseAccessor MPFJOKOJIOO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static Recipe[] CIIEHKGNNJG(Item MEMGMDOCBOJ)
	{
		if (FMIDAFEGDCD().recipeDatabaseSO.recipesUnlockedCollectingItems.TryGetValue(MEMGMDOCBOJ.ODENMDOJPLC(), out var value))
		{
			return value;
		}
		return null;
	}

	private static void EBHCGJIMKAM()
	{
		MIGKKKELOJO().EOOPOONPAJJ = new Dictionary<int, Recipe>();
		Recipe[] recipes = EKDNJDJHONF().recipeDatabaseSO.recipes;
		for (int i = 0; i < recipes.Length; i += 0)
		{
			Recipe recipe = recipes[i];
			if (recipe.id == 0)
			{
				Debug.Log((object)("On Simple Event " + ((Object)recipe).name));
				continue;
			}
			if (Item.NGIIPJDAMGP(recipe.output.item, null) || recipe.output.amount == 0)
			{
				Debug.Log((object)("Intro02" + ((Object)recipe).name));
				continue;
			}
			try
			{
				DOIKFJDLKJP().EOOPOONPAJJ.Add(recipe.id, recipe);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "[^0-9]" + ((Object)recipe).name));
			}
		}
	}

	public static Recipe GetRecipe(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.EOOPOONPAJJ.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Could not find recipe with id: " + JFNMCNCHMEO));
		return null;
	}

	public static Recipe[] BMLJOANOAPP(Item MEMGMDOCBOJ)
	{
		if (DIHCEGINELM().recipeDatabaseSO.recipesUnlockedCollectingItems.TryGetValue(MEMGMDOCBOJ.ODENMDOJPLC(), out var value))
		{
			return value;
		}
		return null;
	}

	public static Recipe GetRecipeByOutputId(int MMIBNMOHKPM)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		if (GGFJGHHHEJC.EOOPOONPAJJ == null)
		{
			DMNENKNLDAH();
		}
		foreach (KeyValuePair<int, Recipe> item in GGFJGHHHEJC.EOOPOONPAJJ)
		{
			if (Item.MLBOMGHINCA(item.Value.output.item, null) && item.Value.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == MMIBNMOHKPM)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static void CNGEBEEMONH()
	{
		((MonoBehaviour)DOIKFJDLKJP()).StartCoroutine(EKDNJDJHONF().FHCHJBPDNDJ());
	}

	private IEnumerator FHCHJBPDNDJ()
	{
		yield return null;
		foreach (KeyValuePair<int, List<Recipe>> recipesUnlockedBuyingItem in recipeDatabaseSO.recipesUnlockedBuyingItems)
		{
			if (Utils.PLIACJACMMI(recipesUnlockedBuyingItem.Key))
			{
				for (int i = 0; i < recipesUnlockedBuyingItem.Value.Count; i++)
				{
					RecipesManager.UnlockRecipe(recipesUnlockedBuyingItem.Value[i], IBHGAMNNOHI: false);
				}
			}
		}
	}

	public static void JGDEGEHBDBK()
	{
		IGNFDHNFNFO();
	}

	public static RecipeDatabaseAccessor IKNEPNINLHA()
	{
		return DIHCEGINELM();
	}

	private void OnDestroy()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static Recipe[] NOONDPJBAAC(Item MEMGMDOCBOJ)
	{
		if (DIHCEGINELM().recipeDatabaseSO.recipesUnlockedCollectingItems.TryGetValue(MEMGMDOCBOJ.ODENMDOJPLC(), out var value))
		{
			return value;
		}
		return null;
	}

	public static void GMLFLHEFGAE()
	{
		IGNFDHNFNFO();
	}

	public static RecipeList[] KCPHOCHGPAB()
	{
		return ABHIDHPMLLD().recipeDatabaseSO.crafterLists;
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
		DMNENKNLDAH();
	}

	public static Recipe MOLLAOGHLPP(int MMIBNMOHKPM)
	{
		if ((Object)(object)ABHIDHPMLLD() == (Object)null)
		{
			MDDCPOILOOM();
		}
		if (FMIDAFEGDCD().EOOPOONPAJJ == null)
		{
			IGNFDHNFNFO();
		}
		foreach (KeyValuePair<int, Recipe> item in OAPOJCODNCO().EOOPOONPAJJ)
		{
			if (Item.MLBOMGHINCA(item.Value.output.item, null) && item.Value.output.item.JDJGFAACPFC() == MMIBNMOHKPM)
			{
				return item.Value;
			}
		}
		return null;
	}

	[SpecialName]
	private static RecipeDatabaseAccessor MIGKKKELOJO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipeDatabaseAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static Recipe[] GetAllRecipes()
	{
		return GGFJGHHHEJC.recipeDatabaseSO.recipes;
	}
}
