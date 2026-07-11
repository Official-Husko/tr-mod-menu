using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

public class RecipesManager : SerializedMonoBehaviour, ISingleton
{
	private static RecipesManager IADEMLIIDPC;

	public static int recipeFragments;

	public static int recipeFragmentsUsed;

	private List<int> PKEBDMOHCGF = new List<int>();

	[SerializeField]
	private HashSet<int> unlockedRecipes = new HashSet<int>();

	[SerializeField]
	private HashSet<int> unlockedRecipesMaster = new HashSet<int>();

	public Action<Recipe> OnAnyRecipeUnlocked = delegate
	{
	};

	public static RecipesManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<RecipesManager>();
			}
			return IADEMLIIDPC;
		}
	}

	private static IEnumerator FPAMPLGFCCK(bool EAANKCNNNJK)
	{
		yield return CommonReferences.wait1;
		while (NewTutorialManager.instance.open || TutorialManager.GGFJGHHHEJC.FGFFCFBJJBG)
		{
			yield return CommonReferences.wait1;
		}
		Recipe[] allRecipes = RecipeDatabaseAccessor.GetAllRecipes();
		for (int i = 0; i < allRecipes.Length; i++)
		{
			if (allRecipes[i].id != 540 && (allRecipes[i].unlock == Recipe.RecipeUnlock.FromBeginning || allRecipes[i].unlock == Recipe.RecipeUnlock.Tutorial))
			{
				UnlockRecipe(allRecipes[i], EAANKCNNNJK);
			}
		}
	}

	private static void DOHMKEAAFBK()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(FJOJCDAPAJO));
	}

	private static bool FJHHLHBLKIK(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI)
	{
		if (JNLKEMLDFIM.unlock != Recipe.RecipeUnlock.FromBeginning && JNLKEMLDFIM.unlock != Recipe.RecipeUnlock.Talent && JNLKEMLDFIM.unlock != Recipe.RecipeUnlock.CollectingItems)
		{
			return UnlockRecipe(JNLKEMLDFIM, IBHGAMNNOHI);
		}
		return false;
	}

	public static bool IsRecipeUnlocked(int GBOJANFONBF, bool MJHDMIGEJAK = true)
	{
		if (MJHDMIGEJAK && OnlineManager.ClientOnline() && GGFJGHHHEJC.unlockedRecipesMaster.Contains(GBOJANFONBF))
		{
			return true;
		}
		return GGFJGHHHEJC.unlockedRecipes.Contains(GBOJANFONBF);
	}

	private static IEnumerator CEBAKFEHACG(Recipe JNLKEMLDFIM, float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		UnlockRecipe(JNLKEMLDFIM);
	}

	public static bool IsFavoriteRecipe(Recipe JNLKEMLDFIM)
	{
		return GGFJGHHHEJC.PKEBDMOHCGF.Contains(JNLKEMLDFIM.id);
	}

	private static bool HHBLBHCNDKL(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI)
	{
		bool flag = true;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (JNLKEMLDFIM.ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, JNLKEMLDFIM, BMMBDCBJNAK: true);
				for (int j = 1; j < list.Count; j += 0)
				{
					if ((Object)(object)list[j].item.recipe != (Object)null && list[j].item.recipe.unlock == Recipe.RecipeUnlock.Shop)
					{
						flag |= UnlockRecipe(list[j].item.recipe, IBHGAMNNOHI);
					}
				}
			}
			else if ((Object)(object)JNLKEMLDFIM.ingredientsNeeded[i].item.recipe != (Object)null)
			{
				flag |= FJHHLHBLKIK(JNLKEMLDFIM.ingredientsNeeded[i].item.recipe, IBHGAMNNOHI);
			}
		}
		return flag;
	}

	public static bool UnlockRecipe(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI = true, bool OEBNHGNJEJL = false)
	{
		if ((Object)(object)JNLKEMLDFIM == (Object)null)
		{
			return false;
		}
		bool flag = false;
		if (CanUnlockRecipe(JNLKEMLDFIM.id))
		{
			GGFJGHHHEJC.unlockedRecipes.Add(JNLKEMLDFIM.id);
			if (IBHGAMNNOHI)
			{
				ItemsCollectedUI.QueueRecipeUnlocked(1, JNLKEMLDFIM.output.item.JMDALJBNFML());
			}
			if ((Object)(object)JNLKEMLDFIM.newRecipe != (Object)null)
			{
				UnlockRecipe(JNLKEMLDFIM.newRecipe, IBHGAMNNOHI);
			}
			flag = true;
			if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && GGFJGHHHEJC.OnAnyRecipeUnlocked != null)
			{
				GGFJGHHHEJC.OnAnyRecipeUnlocked(JNLKEMLDFIM);
			}
			PGEEIBNHDJA();
		}
		return flag | PEFPIOKMMHI(JNLKEMLDFIM, IBHGAMNNOHI);
	}

	public static int RemoveAllRecipesWithHigherReputationRequired()
	{
		HashSet<int> hashSet = new HashSet<int>(GGFJGHHHEJC.unlockedRecipes);
		int num = 0;
		foreach (int item in hashSet)
		{
			Recipe recipe = RecipeDatabaseAccessor.GetRecipe(item);
			if ((Object)(object)recipe != (Object)null && recipe.unlock == Recipe.RecipeUnlock.Temple && recipe.reputationRequired.repNumber > TavernReputation.GetMilestone())
			{
				LockRecipe(item);
				Debug.Log((object)("Recipe " + recipe.IABAKHPEOAF() + " locked due to reputation level required is " + recipe.reputationRequired.repNumber));
				num++;
			}
		}
		return num;
	}

	public static void LockRecipe(int DCFNIMCMFEM)
	{
		GGFJGHHHEJC.unlockedRecipes.Remove(DCFNIMCMFEM);
	}

	private static void NGMODLKBBON()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FJOJCDAPAJO));
	}

	public static HashSet<int> GetUnlockedRecipes()
	{
		return GGFJGHHHEJC.unlockedRecipes;
	}

	private void HEANIGJJDGL(bool DAEMAAOLHMG)
	{
		if (!DAEMAAOLHMG)
		{
			GiveAllRecipesAvailable(EAANKCNNNJK: false);
		}
	}

	private static IEnumerator KBAFAALDECP(bool EAANKCNNNJK)
	{
		yield return CommonReferences.wait1;
		while (NewTutorialManager.instance.open || TutorialManager.GGFJGHHHEJC.FGFFCFBJJBG)
		{
			yield return CommonReferences.wait1;
		}
		Recipe[] allRecipes = RecipeDatabaseAccessor.GetAllRecipes();
		for (int i = 0; i < allRecipes.Length; i++)
		{
			if (allRecipes[i].id != 540 && (allRecipes[i].unlock == Recipe.RecipeUnlock.FromBeginning || allRecipes[i].unlock == Recipe.RecipeUnlock.Tutorial))
			{
				UnlockRecipe(allRecipes[i], EAANKCNNNJK);
			}
		}
	}

	private void BNIKICAEIND()
	{
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.OnTutorialActivate = (Action<bool>)Delegate.Combine(instance.OnTutorialActivate, new Action<bool>(HEANIGJJDGL));
	}

	public static bool FCKGMKGNGDC(Recipe JNLKEMLDFIM)
	{
		return MPFJOKOJIOO().PKEBDMOHCGF.Contains(JNLKEMLDFIM.id);
	}

	public static bool HAEPHAHCGPK(Recipe JNLKEMLDFIM)
	{
		return GGFJGHHHEJC.PKEBDMOHCGF.Contains(JNLKEMLDFIM.id);
	}

	public static void LockRecipe(Recipe JNLKEMLDFIM)
	{
		GGFJGHHHEJC.unlockedRecipes.Remove(JNLKEMLDFIM.id);
	}

	public static void UnlockRecipeWithDelay(int GBOJANFONBF, float FLHBPHPKIML)
	{
		UnlockRecipeWithDelay(RecipeDatabaseAccessor.GetRecipe(GBOJANFONBF), FLHBPHPKIML);
	}

	public static void UnlockRecipeWithDelay(Recipe JNLKEMLDFIM, float FLHBPHPKIML)
	{
		if (Object.op_Implicit((Object)(object)JNLKEMLDFIM))
		{
			if (CanUnlockRecipe(JNLKEMLDFIM.id))
			{
				((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(CEBAKFEHACG(JNLKEMLDFIM, FLHBPHPKIML));
			}
		}
		else
		{
			Debug.LogError((object)("Recipe not found with ID " + JNLKEMLDFIM.id));
		}
	}

	public static void HPLCKPMALPD(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI = true, bool CDPAMNIPPEC = true)
	{
		UnlockRecipeMaster(JNLKEMLDFIM.id, IBHGAMNNOHI, CDPAMNIPPEC);
	}

	private void CAIJLMJBMLA()
	{
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.OnTutorialActivate = (Action<bool>)Delegate.Combine(instance.OnTutorialActivate, new Action<bool>(HEANIGJJDGL));
	}

	public static void CJHKKILOHDA(Item MEMGMDOCBOJ)
	{
		Recipe[] array = RecipeDatabaseAccessor.MGJNODHOOMG(MEMGMDOCBOJ);
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				HPLCKPMALPD(array[i], IBHGAMNNOHI: false, CDPAMNIPPEC: false);
			}
		}
	}

	private static void PHPBHDOIIFF()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(FJOJCDAPAJO));
	}

	public static bool CanUnlockRecipe(int GBOJANFONBF)
	{
		return !GGFJGHHHEJC.unlockedRecipes.Contains(GBOJANFONBF);
	}

	[SpecialName]
	public static RecipesManager MPFJOKOJIOO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RecipesManager>();
		}
		return IADEMLIIDPC;
	}

	public static bool FHHBGOADHHJ(int GBOJANFONBF)
	{
		if (OnlineManager.ClientOnline())
		{
			return MPFJOKOJIOO().unlockedRecipesMaster.Contains(GBOJANFONBF);
		}
		return GGFJGHHHEJC.unlockedRecipes.Contains(GBOJANFONBF);
	}

	public static void EGEAPNOMMFG(int GBOJANFONBF, bool IBHGAMNNOHI = false)
	{
		UnlockRecipe(RecipeDatabaseAccessor.AJFFBGIOGOG(GBOJANFONBF), IBHGAMNNOHI, OEBNHGNJEJL: true);
	}

	private static bool JLAAHBJJLOK(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI)
	{
		if (JNLKEMLDFIM.unlock != Recipe.RecipeUnlock.BuyingItem && JNLKEMLDFIM.unlock != (Recipe.RecipeUnlock)107 && JNLKEMLDFIM.unlock != (Recipe.RecipeUnlock)98)
		{
			return UnlockRecipe(JNLKEMLDFIM, IBHGAMNNOHI, OEBNHGNJEJL: true);
		}
		return false;
	}

	public static bool NIEHLJAJBIJ(int GBOJANFONBF)
	{
		if (OnlineManager.ClientOnline())
		{
			return GGFJGHHHEJC.unlockedRecipesMaster.Contains(GBOJANFONBF);
		}
		return GGFJGHHHEJC.unlockedRecipes.Contains(GBOJANFONBF);
	}

	public static void IBBMDKAEHHE(int GBOJANFONBF)
	{
		MPFJOKOJIOO().PKEBDMOHCGF.Remove(GBOJANFONBF);
	}

	public static void RemoveFavoriteRecipe(int GBOJANFONBF)
	{
		GGFJGHHHEJC.PKEBDMOHCGF.Remove(GBOJANFONBF);
	}

	public static bool ONMNODMHHLG(int GBOJANFONBF)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return GGFJGHHHEJC.unlockedRecipesMaster.Contains(GBOJANFONBF);
		}
		return GGFJGHHHEJC.unlockedRecipes.Contains(GBOJANFONBF);
	}

	public static void UnlockAllChristmasRecipes()
	{
		Recipe[] allRecipes = RecipeDatabaseAccessor.GetAllRecipes();
		for (int i = 0; i < allRecipes.Length; i++)
		{
			if (allRecipes[i].unlock == Recipe.RecipeUnlock.Christmas)
			{
				UnlockRecipe(allRecipes[i].id, IBHGAMNNOHI: true);
			}
		}
	}

	private void DMFMNEMDFNP()
	{
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.OnTutorialActivate = (Action<bool>)Delegate.Combine(instance.OnTutorialActivate, new Action<bool>(HEANIGJJDGL));
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
			{
				IADEMLIIDPC = null;
			}
			if (Object.op_Implicit((Object)(object)NewTutorialManager.instance))
			{
				NewTutorialManager instance = NewTutorialManager.instance;
				instance.OnTutorialActivate = (Action<bool>)Delegate.Remove(instance.OnTutorialActivate, new Action<bool>(HEANIGJJDGL));
			}
		}
	}

	public static void GiveAllRecipesAvailable(bool EAANKCNNNJK)
	{
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			DOHMKEAAFBK();
		}
		else
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(FPAMPLGFCCK(EAANKCNNNJK));
		}
	}

	private static void FJOJCDAPAJO()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(FJOJCDAPAJO));
		GiveAllRecipesAvailable(EAANKCNNNJK: true);
	}

	public static bool IsRecipeUnlockedByMaster(int GBOJANFONBF)
	{
		if (OnlineManager.ClientOnline())
		{
			return GGFJGHHHEJC.unlockedRecipesMaster.Contains(GBOJANFONBF);
		}
		return GGFJGHHHEJC.unlockedRecipes.Contains(GBOJANFONBF);
	}

	public static void PBCNCMPFLDB(bool EAANKCNNNJK)
	{
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			DOHMKEAAFBK();
		}
		else
		{
			((MonoBehaviour)MPFJOKOJIOO()).StartCoroutine(FPAMPLGFCCK(EAANKCNNNJK));
		}
	}

	public static void KOCMJKCJBCP(Item MEMGMDOCBOJ)
	{
		Recipe[] array = RecipeDatabaseAccessor.JPNHHMHCKJL(MEMGMDOCBOJ);
		if (array != null)
		{
			for (int i = 0; i < array.Length; i += 0)
			{
				UnlockRecipeMaster(array[i], IBHGAMNNOHI: false, CDPAMNIPPEC: false);
			}
		}
	}

	public void ResetSingleton()
	{
		recipeFragments = 0;
	}

	public static void AddFavoriteRecipe(int GBOJANFONBF)
	{
		if (!GGFJGHHHEJC.PKEBDMOHCGF.Contains(GBOJANFONBF) && (Object)(object)RecipeDatabaseAccessor.GetRecipe(GBOJANFONBF) != (Object)null && !RecipeDatabaseAccessor.GetRecipe(GBOJANFONBF).replacedRecipe)
		{
			GGFJGHHHEJC.PKEBDMOHCGF.Add(GBOJANFONBF);
		}
	}

	public static void UnlockRecipe(int GBOJANFONBF, bool IBHGAMNNOHI = false)
	{
		UnlockRecipe(RecipeDatabaseAccessor.GetRecipe(GBOJANFONBF), IBHGAMNNOHI);
	}

	private static void PGEEIBNHDJA()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && GGFJGHHHEJC.unlockedRecipes.Contains(601) && GGFJGHHHEJC.unlockedRecipes.Contains(602) && GGFJGHHHEJC.unlockedRecipes.Contains(603) && GGFJGHHHEJC.unlockedRecipes.Contains(604))
		{
			Utils.DLIIAHACOJB(50);
		}
	}

	private void JDMMNLKLMAA()
	{
		IADEMLIIDPC = this;
		ResetSingleton();
	}

	public static void UnlockRecipeMaster(int GBOJANFONBF, bool IBHGAMNNOHI = false, bool CDPAMNIPPEC = true)
	{
		if (OnlineManager.MasterOrOffline())
		{
			UnlockRecipe(GBOJANFONBF, IBHGAMNNOHI);
		}
		else
		{
			if (GGFJGHHHEJC.unlockedRecipesMaster.Contains(GBOJANFONBF))
			{
				return;
			}
			GGFJGHHHEJC.unlockedRecipesMaster.Add(GBOJANFONBF);
			if (IBHGAMNNOHI)
			{
				ItemsCollectedUI.QueueRecipeUnlocked(1, RecipeDatabaseAccessor.GetRecipe(GBOJANFONBF).output.item.JMDALJBNFML());
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineRecipesManager.instance.SendUnlockedRecipeMaster(GBOJANFONBF);
		}
	}

	private static bool DOIFDKDNLMN(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI)
	{
		bool flag = true;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (JNLKEMLDFIM.ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, JNLKEMLDFIM, BMMBDCBJNAK: true);
				for (int j = 1; j < list.Count; j += 0)
				{
					if ((Object)(object)list[j].item.recipe != (Object)null && list[j].item.recipe.unlock == Recipe.RecipeUnlock.None)
					{
						flag |= UnlockRecipe(list[j].item.recipe, IBHGAMNNOHI);
					}
				}
			}
			else if ((Object)(object)JNLKEMLDFIM.ingredientsNeeded[i].item.recipe != (Object)null)
			{
				flag |= JLAAHBJJLOK(JNLKEMLDFIM.ingredientsNeeded[i].item.recipe, IBHGAMNNOHI);
			}
		}
		return flag;
	}

	public static int JODHLAAFFOG()
	{
		HashSet<int> hashSet = new HashSet<int>(MPFJOKOJIOO().unlockedRecipes);
		int num = 1;
		foreach (int item in hashSet)
		{
			Recipe recipe = RecipeDatabaseAccessor.IFAAHCALEPD(item);
			if ((Object)(object)recipe != (Object)null && recipe.unlock == Recipe.RecipeUnlock.Temple && recipe.reputationRequired.repNumber > TavernReputation.MHGADJPMHFI())
			{
				LockRecipe(item);
				Debug.Log((object)("textName InstanceId: {0}  {1}  {2}  {3}" + recipe.ICEAIIBMELM() + "buildingObjective_25_0" + recipe.reputationRequired.repNumber));
				num++;
			}
		}
		return num;
	}

	public static void UnlockRecipeMaster(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI = true, bool CDPAMNIPPEC = true)
	{
		UnlockRecipeMaster(JNLKEMLDFIM.id, IBHGAMNNOHI, CDPAMNIPPEC);
	}

	private static bool PEFPIOKMMHI(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI)
	{
		bool flag = false;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (JNLKEMLDFIM.ingredientsNeeded[i].item is IngredientGroup ingredientGroup)
			{
				List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, JNLKEMLDFIM);
				for (int j = 0; j < list.Count; j++)
				{
					if ((Object)(object)list[j].item.recipe != (Object)null && list[j].item.recipe.unlock == Recipe.RecipeUnlock.WithAnotherRecipe)
					{
						flag |= UnlockRecipe(list[j].item.recipe, IBHGAMNNOHI, OEBNHGNJEJL: true);
					}
				}
			}
			else if ((Object)(object)JNLKEMLDFIM.ingredientsNeeded[i].item.recipe != (Object)null)
			{
				flag |= FJHHLHBLKIK(JNLKEMLDFIM.ingredientsNeeded[i].item.recipe, IBHGAMNNOHI);
			}
		}
		return flag;
	}

	public static void CheckEventUnlockedRecipes()
	{
		if (EventsManager.IsDone(EventsManager.EventType.NinjaChallengeEvent))
		{
			UnlockRecipeMaster(514, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
			UnlockRecipeMaster(645, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (EventsManager.IsDone(EventsManager.EventType.OathFeast))
		{
			UnlockRecipeMaster(643, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
			UnlockRecipeMaster(644, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if ((Object)(object)MissionsManager.instance != (Object)null && MissionsManager.instance.IsMissionComplete(317))
		{
			UnlockRecipeMaster(642, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
	}

	public static void CalculateCurrentRecipeFragments(int KDIABIFNDKM)
	{
		int num = TavernReputation.GetRecipeFragmentsObtainedAccumulated(KDIABIFNDKM);
		Recipe[] allRecipes = RecipeDatabaseAccessor.GetAllRecipes();
		for (int i = 0; i < allRecipes.Length; i++)
		{
			if (allRecipes[i].unlock == Recipe.RecipeUnlock.Temple && IsRecipeUnlocked(allRecipes[i].id, MJHDMIGEJAK: false))
			{
				Debug.Log((object)("Already have recipe " + allRecipes[i].IABAKHPEOAF() + " (-" + allRecipes[i].recipeFragments + " recipeFragments) (versionOfCityAndTutorial)"));
				num -= allRecipes[i].recipeFragments;
			}
		}
		Debug.Log((object)("Final recipe fragments: " + num + " (versionOfCityAndTutorial)"));
		recipeFragments = num;
	}

	public static void UnlockRecipesCollectingItem(Item MEMGMDOCBOJ)
	{
		Recipe[] recipesUnlockedCollectingAnItem = RecipeDatabaseAccessor.GetRecipesUnlockedCollectingAnItem(MEMGMDOCBOJ);
		if (recipesUnlockedCollectingAnItem != null)
		{
			for (int i = 0; i < recipesUnlockedCollectingAnItem.Length; i++)
			{
				UnlockRecipeMaster(recipesUnlockedCollectingAnItem[i]);
			}
		}
	}

	public static bool OECEJEDHHNK(int GBOJANFONBF)
	{
		return !GGFJGHHHEJC.unlockedRecipes.Contains(GBOJANFONBF);
	}

	public static List<int> GetFavoriteRecipes()
	{
		return GGFJGHHHEJC.PKEBDMOHCGF;
	}

	public static int AFCDINGIMEI()
	{
		HashSet<int> hashSet = new HashSet<int>(MPFJOKOJIOO().unlockedRecipes);
		int num = 0;
		foreach (int item in hashSet)
		{
			Recipe recipe = RecipeDatabaseAccessor.IFAAHCALEPD(item);
			if ((Object)(object)recipe != (Object)null && recipe.unlock == Recipe.RecipeUnlock.None && recipe.reputationRequired.repNumber > TavernReputation.MHGADJPMHFI())
			{
				LockRecipe(item);
				Debug.Log((object)(":</color> " + recipe.LMFPCKCLBAO() + "Items/item_description_1143" + recipe.reputationRequired.repNumber));
				num++;
			}
		}
		return num;
	}

	public static void ADGLIOGEDAH(int GBOJANFONBF, float FLHBPHPKIML)
	{
		UnlockRecipeWithDelay(RecipeDatabaseAccessor.GetRecipe(GBOJANFONBF), FLHBPHPKIML);
	}

	public static HashSet<int> ADPNAHDBPPI()
	{
		return GGFJGHHHEJC.unlockedRecipes;
	}

	private void Start()
	{
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.OnTutorialActivate = (Action<bool>)Delegate.Combine(instance.OnTutorialActivate, new Action<bool>(HEANIGJJDGL));
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
		ResetSingleton();
	}

	public static void MCIDEIPNNAK(Recipe JNLKEMLDFIM, bool IBHGAMNNOHI = true, bool CDPAMNIPPEC = true)
	{
		UnlockRecipeMaster(JNLKEMLDFIM.id, IBHGAMNNOHI, CDPAMNIPPEC);
	}

	public static List<int> FKPEMKHEFMC()
	{
		return MPFJOKOJIOO().PKEBDMOHCGF;
	}
}
