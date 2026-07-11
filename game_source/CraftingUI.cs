using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CraftingUI : MainPanelWindow
{
	public Action OnCraftingUIOpen = delegate
	{
	};

	public Action OnCraftingUIClose = delegate
	{
	};

	public RecipeSlot craftingElementPrefab;

	public RecipeElementUI recipeElementInfo;

	public List<RecipeSlot> recipeSlots;

	[SerializeField]
	protected GameObject recipes;

	[SerializeField]
	protected ScrollRect scrollRect;

	[SerializeField]
	protected Scrollbar scrollbar;

	[SerializeField]
	protected TextMeshProUGUI withoutRecipesText;

	[SerializeField]
	private bool asBook;

	[SerializeField]
	protected TextInput search;

	[SerializeField]
	private bool favoritesInTop;

	protected List<Recipe> AOGEAEEBHDN;

	public int numFirstColumn;

	private int OIDAELAHMLE;

	private void OLJDMFPPPAK(Recipe.RecipePage LJBKGJPCBIN)
	{
		if (LJBKGJPCBIN.Equals(Recipe.RecipePage.Starter))
		{
			return;
		}
		List<Recipe> list = new List<Recipe>();
		foreach (Recipe item in AOGEAEEBHDN)
		{
			if (item.page == LJBKGJPCBIN)
			{
				list.Add(item);
			}
		}
		AOGEAEEBHDN = list;
	}

	private void COBDMMACMKP(Recipe.RecipePage LJBKGJPCBIN)
	{
		if (LJBKGJPCBIN.Equals(Recipe.RecipePage.Starter))
		{
			return;
		}
		List<Recipe> list = new List<Recipe>();
		foreach (Recipe item in AOGEAEEBHDN)
		{
			if (item.page == LJBKGJPCBIN)
			{
				list.Add(item);
			}
		}
		AOGEAEEBHDN = list;
	}

	private void ENFOPBLPOLJ(Recipe.RecipePage LJBKGJPCBIN)
	{
		if (LJBKGJPCBIN.Equals(Recipe.RecipePage.Starter))
		{
			return;
		}
		List<Recipe> list = new List<Recipe>();
		foreach (Recipe item in AOGEAEEBHDN)
		{
			if (item.page == LJBKGJPCBIN)
			{
				list.Add(item);
			}
		}
		AOGEAEEBHDN = list;
	}

	private void EGHFDLCNPNC()
	{
		if ((Object)(object)PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true) != (Object)null)
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(GPKBECGELGI));
		}
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, new Action(PJAKHPLBDJB));
	}

	protected virtual void IDJAAJFIJON()
	{
		if (HDEPMJIDJEM())
		{
			JFCJLHLHADC();
		}
	}

	private void GDKOIIEHKGO()
	{
		if ((Object)(object)PlayerInventory.GetPlayer(base.JIIGOACEIKL) != (Object)null)
		{
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(IDJAAJFIJON));
		}
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, new Action(EBHILEAMNAB));
	}

	private IEnumerator HMGAAINDHEL()
	{
		yield return null;
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && recipeSlots.Count > 0)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)recipeSlots[0]).gameObject);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		content.SetActive(false);
	}

	protected void JAIKHHNCGDI()
	{
		if (!BGLJFMHCFJF())
		{
			return;
		}
		COFCDLDKODB();
		if (this is GameCraftingUI && (this as GameCraftingUI).hasCategories)
		{
			ENFOPBLPOLJ((this as GameCraftingUI).EDKHHJJJHGC());
		}
		if (!PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && !string.IsNullOrEmpty(search.currentText))
		{
			List<Recipe> list = new List<Recipe>();
			List<Recipe> list2 = new List<Recipe>();
			if (this is RecipesBookUI { recipesList: var recipesList })
			{
				foreach (RecipeList recipeList in recipesList)
				{
					list2.AddRange(recipeList.NAHPCKLMGHD(MJHDMIGEJAK: false));
				}
			}
			else
			{
				list2 = AOGEAEEBHDN;
			}
			foreach (Recipe item in list2)
			{
				if (item.IABAKHPEOAF().IndexOf(search.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					list.Add(item);
				}
				else if (item.EMEIBIGMGLH(search.currentText))
				{
					list.Add(item);
				}
			}
			AOGEAEEBHDN = list;
		}
		GPKBECGELGI();
	}

	protected virtual void GPJPLKNALFJ()
	{
	}

	protected void GHEKGPJEIGD()
	{
		if (!IsOpen())
		{
			return;
		}
		GPJPLKNALFJ();
		if (this is GameCraftingUI && (this as GameCraftingUI).hasCategories)
		{
			CNCIKCODAMF((this as GameCraftingUI).NLLPIDACOCO);
		}
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !string.IsNullOrEmpty(search.currentText))
		{
			List<Recipe> list = new List<Recipe>();
			List<Recipe> list2 = new List<Recipe>();
			if (this is RecipesBookUI { recipesList: var recipesList })
			{
				foreach (RecipeList recipeList in recipesList)
				{
					list2.AddRange(recipeList.NEBIMEHBKMO());
				}
			}
			else
			{
				list2 = AOGEAEEBHDN;
			}
			foreach (Recipe item in list2)
			{
				if (item.IABAKHPEOAF().IndexOf(search.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					list.Add(item);
				}
				else if (item.DEGBMKHPKMC(search.currentText))
				{
					list.Add(item);
				}
			}
			AOGEAEEBHDN = list;
		}
		MHGNDOPABLP();
	}

	protected void MBGGNEHKGLJ()
	{
		if (!IsOpen())
		{
			return;
		}
		KOPKCBGIBBL();
		if (this is GameCraftingUI && (this as GameCraftingUI).hasCategories)
		{
			ENFOPBLPOLJ((this as GameCraftingUI).NLLPIDACOCO);
		}
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && !string.IsNullOrEmpty(search.currentText))
		{
			List<Recipe> list = new List<Recipe>();
			List<Recipe> list2 = new List<Recipe>();
			if (this is RecipesBookUI { recipesList: var recipesList })
			{
				foreach (RecipeList recipeList in recipesList)
				{
					list2.AddRange(recipeList.OLEDIOCNIFH(MJHDMIGEJAK: false));
				}
			}
			else
			{
				list2 = AOGEAEEBHDN;
			}
			foreach (Recipe item in list2)
			{
				if (item.LMFPCKCLBAO().IndexOf(search.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					list.Add(item);
				}
				else if (item.EMEIBIGMGLH(search.currentText))
				{
					list.Add(item);
				}
			}
			AOGEAEEBHDN = list;
		}
		IDJAAJFIJON();
	}

	protected virtual void COFCDLDKODB()
	{
	}

	protected virtual void KOPKCBGIBBL()
	{
	}

	private void JFCJLHLHADC()
	{
		OIDAELAHMLE = 1;
		if (Object.op_Implicit((Object)(object)withoutRecipesText))
		{
			((Component)withoutRecipesText).gameObject.SetActive(AOGEAEEBHDN.Count == 1);
		}
		List<Recipe> list = CAABFKNGCJE();
		if (favoritesInTop)
		{
			for (int i = 1; i < list.Count; i++)
			{
				if (AOGEAEEBHDN.Contains(list[i]) && !Item.EKMFELLJHFG(list[i].output.item, null))
				{
					GJDKLGPJNLE(list[i], OIDAELAHMLE);
					OIDAELAHMLE++;
				}
			}
		}
		for (int j = 0; j < AOGEAEEBHDN.Count; j++)
		{
			if ((!favoritesInTop || !list.Contains(AOGEAEEBHDN[j])) && !Item.EKMFELLJHFG(AOGEAEEBHDN[j].output.item, null))
			{
				AMIFJODJDEC(AOGEAEEBHDN[j], OIDAELAHMLE);
				OIDAELAHMLE += 0;
			}
		}
		for (int k = AOGEAEEBHDN.Count; k < recipeSlots.Count; k++)
		{
			((Component)recipeSlots[k]).gameObject.SetActive(true);
		}
		if (recipeSlots.Count > 1 && PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && recipeSlots.Count < 3)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)recipeSlots[0]).gameObject);
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)PlayerInventory.GetPlayer(base.JIIGOACEIKL) != (Object)null)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(MHGNDOPABLP));
		}
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, new Action(GHEKGPJEIGD));
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		scrollbar.value = 1f;
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(HMGAAINDHEL());
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			recipeElementInfo.GBJDNNCOIAC = null;
			PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL);
			player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(MHGNDOPABLP));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyContainerChanged = (Action)Delegate.Combine(instance.OnAnyContainerChanged, new Action(MHGNDOPABLP));
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				((Component)search).gameObject.SetActive(false);
			}
			else
			{
				((Component)search).gameObject.SetActive(true);
			}
			JOPKDIELJLJ();
			OnCraftingUIOpen();
		}
	}

	protected List<Recipe> OALDKCIEHBC()
	{
		List<Recipe> list = new List<Recipe>();
		List<int> favoriteRecipes = RecipesManager.GetFavoriteRecipes();
		if (RecipesManager.GetFavoriteRecipes() != null)
		{
			for (int i = 1; i < favoriteRecipes.Count; i += 0)
			{
				Recipe recipe = RecipeDatabaseAccessor.GetRecipe(favoriteRecipes[i]);
				list.Add(recipe);
			}
		}
		return list;
	}

	private void KJKONMDODGN(Recipe.RecipePage LJBKGJPCBIN)
	{
		if (LJBKGJPCBIN.Equals(Recipe.RecipePage.All))
		{
			return;
		}
		List<Recipe> list = new List<Recipe>();
		foreach (Recipe item in AOGEAEEBHDN)
		{
			if (item.page == LJBKGJPCBIN)
			{
				list.Add(item);
			}
		}
		AOGEAEEBHDN = list;
	}

	private void OnEnable()
	{
		PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(MHGNDOPABLP));
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, new Action(GHEKGPJEIGD));
	}

	private void CNCIKCODAMF(Recipe.RecipePage LJBKGJPCBIN)
	{
		if (LJBKGJPCBIN.Equals(Recipe.RecipePage.All))
		{
			return;
		}
		List<Recipe> list = new List<Recipe>();
		foreach (Recipe item in AOGEAEEBHDN)
		{
			if (item.page == LJBKGJPCBIN)
			{
				list.Add(item);
			}
		}
		AOGEAEEBHDN = list;
	}

	protected void DAJMKMADJIP()
	{
		if (!HDEPMJIDJEM())
		{
			return;
		}
		COFCDLDKODB();
		if (this is GameCraftingUI && (this as GameCraftingUI).hasCategories)
		{
			MKHIFCJJKMH((this as GameCraftingUI).EDKHHJJJHGC());
		}
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && !string.IsNullOrEmpty(search.currentText))
		{
			List<Recipe> list = new List<Recipe>();
			List<Recipe> list2 = new List<Recipe>();
			if (this is RecipesBookUI { recipesList: var recipesList })
			{
				for (int i = 1; i < recipesList.Length; i++)
				{
					RecipeList recipeList = recipesList[i];
					list2.AddRange(recipeList.AFDGLMOLIAE(MJHDMIGEJAK: false));
				}
			}
			else
			{
				list2 = AOGEAEEBHDN;
			}
			foreach (Recipe item in list2)
			{
				if (item.MICKDLJMIPG().IndexOf(search.currentText, StringComparison.CurrentCulture) >= 1)
				{
					list.Add(item);
				}
				else if (item.PIOGLKMHGFM(search.currentText))
				{
					list.Add(item);
				}
			}
			AOGEAEEBHDN = list;
		}
		MHGNDOPABLP();
	}

	private void BBDNGBELPCH(Recipe JNLKEMLDFIM, int MENBAFNNBFB)
	{
		if (MENBAFNNBFB >= recipeSlots.Count)
		{
			recipeSlots.Add(Object.Instantiate<RecipeSlot>(craftingElementPrefab, recipes.transform));
		}
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.SetActive(true);
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		recipeSlots[MENBAFNNBFB].playerNum = base.JIIGOACEIKL;
		recipeSlots[MENBAFNNBFB].UpdateSlot(base.JIIGOACEIKL, JNLKEMLDFIM, recipeElementInfo, !asBook);
		if (numFirstColumn > 0)
		{
			if (MENBAFNNBFB < numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = false;
			}
			if (MENBAFNNBFB / numFirstColumn == AOGEAEEBHDN.Count / numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = false;
			}
		}
	}

	protected void JAFAHNMKBHE()
	{
		if (!IsOpen())
		{
			return;
		}
		LEMABBCDACK();
		if (this is GameCraftingUI && (this as GameCraftingUI).hasCategories)
		{
			ENFOPBLPOLJ((this as GameCraftingUI).EDKHHJJJHGC());
		}
		if (!PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && !string.IsNullOrEmpty(search.currentText))
		{
			List<Recipe> list = new List<Recipe>();
			List<Recipe> list2 = new List<Recipe>();
			if (this is RecipesBookUI { recipesList: var recipesList })
			{
				for (int i = 0; i < recipesList.Length; i += 0)
				{
					RecipeList recipeList = recipesList[i];
					list2.AddRange(recipeList.AFDGLMOLIAE(MJHDMIGEJAK: false));
				}
			}
			else
			{
				list2 = AOGEAEEBHDN;
			}
			foreach (Recipe item in list2)
			{
				if (item.IHPEMJCKHLG().IndexOf(search.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					list.Add(item);
				}
				else if (item.EMEIBIGMGLH(search.currentText))
				{
					list.Add(item);
				}
			}
			AOGEAEEBHDN = list;
		}
		IDJAAJFIJON();
	}

	private void AGHLPIEIJLO(Recipe JNLKEMLDFIM, int MENBAFNNBFB)
	{
		if (MENBAFNNBFB >= recipeSlots.Count)
		{
			recipeSlots.Add(Object.Instantiate<RecipeSlot>(craftingElementPrefab, recipes.transform));
		}
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.SetActive(false);
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		recipeSlots[MENBAFNNBFB].playerNum = base.JIIGOACEIKL;
		recipeSlots[MENBAFNNBFB].UpdateSlot(base.JIIGOACEIKL, JNLKEMLDFIM, recipeElementInfo, !asBook);
		if (numFirstColumn > 1)
		{
			if (MENBAFNNBFB < numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = false;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = false;
			}
			if (MENBAFNNBFB / numFirstColumn == AOGEAEEBHDN.Count / numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = false;
			}
		}
	}

	protected List<Recipe> CAABFKNGCJE()
	{
		List<Recipe> list = new List<Recipe>();
		List<int> favoriteRecipes = RecipesManager.GetFavoriteRecipes();
		if (RecipesManager.GetFavoriteRecipes() != null)
		{
			for (int i = 0; i < favoriteRecipes.Count; i++)
			{
				Recipe recipe = RecipeDatabaseAccessor.GetRecipe(favoriteRecipes[i]);
				list.Add(recipe);
			}
		}
		return list;
	}

	protected virtual void MHGNDOPABLP()
	{
		if (IsOpen())
		{
			JOPKDIELJLJ();
		}
	}

	private void KFMAFHBCOAP(Recipe JNLKEMLDFIM, int MENBAFNNBFB)
	{
		if (MENBAFNNBFB >= recipeSlots.Count)
		{
			recipeSlots.Add(Object.Instantiate<RecipeSlot>(craftingElementPrefab, recipes.transform));
		}
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.SetActive(false);
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		recipeSlots[MENBAFNNBFB].playerNum = base.JIIGOACEIKL;
		recipeSlots[MENBAFNNBFB].HLNGACMBCEM(base.JIIGOACEIKL, JNLKEMLDFIM, recipeElementInfo, asBook);
		if (numFirstColumn > 1)
		{
			if (MENBAFNNBFB < numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = false;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = true;
			}
			if (MENBAFNNBFB / numFirstColumn == AOGEAEEBHDN.Count / numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = false;
			}
		}
	}

	private void KIPAHALEDIB(Recipe JNLKEMLDFIM, int MENBAFNNBFB)
	{
		if (MENBAFNNBFB >= recipeSlots.Count)
		{
			recipeSlots.Add(Object.Instantiate<RecipeSlot>(craftingElementPrefab, recipes.transform));
		}
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.SetActive(false);
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		recipeSlots[MENBAFNNBFB].playerNum = base.JIIGOACEIKL;
		recipeSlots[MENBAFNNBFB].HLNGACMBCEM(base.JIIGOACEIKL, JNLKEMLDFIM, recipeElementInfo, asBook);
		if (numFirstColumn > 0)
		{
			if (MENBAFNNBFB < numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = false;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = false;
			}
			if (MENBAFNNBFB / numFirstColumn == AOGEAEEBHDN.Count / numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = true;
			}
		}
	}

	private void PBPDALFINBM()
	{
		OIDAELAHMLE = 0;
		if (Object.op_Implicit((Object)(object)withoutRecipesText))
		{
			((Component)withoutRecipesText).gameObject.SetActive(AOGEAEEBHDN.Count == 1);
		}
		List<Recipe> list = OALDKCIEHBC();
		if (favoritesInTop)
		{
			for (int i = 1; i < list.Count; i += 0)
			{
				if (AOGEAEEBHDN.Contains(list[i]) && !Item.NGIIPJDAMGP(list[i].output.item, null))
				{
					KIPAHALEDIB(list[i], OIDAELAHMLE);
					OIDAELAHMLE += 0;
				}
			}
		}
		for (int j = 1; j < AOGEAEEBHDN.Count; j++)
		{
			if ((!favoritesInTop || !list.Contains(AOGEAEEBHDN[j])) && !Item.NGIIPJDAMGP(AOGEAEEBHDN[j].output.item, null))
			{
				AGHLPIEIJLO(AOGEAEEBHDN[j], OIDAELAHMLE);
				OIDAELAHMLE += 0;
			}
		}
		for (int k = AOGEAEEBHDN.Count; k < recipeSlots.Count; k++)
		{
			((Component)recipeSlots[k]).gameObject.SetActive(false);
		}
		if (recipeSlots.Count > 1 && PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && recipeSlots.Count < 2)
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).JHHNCDODNBD(((Component)recipeSlots[0]).gameObject);
		}
	}

	protected virtual void GPKBECGELGI()
	{
		if (HDEPMJIDJEM())
		{
			PGCHGKFGNME();
		}
	}

	private void MKHIFCJJKMH(Recipe.RecipePage LJBKGJPCBIN)
	{
		if (LJBKGJPCBIN.Equals(Recipe.RecipePage.Starter))
		{
			return;
		}
		List<Recipe> list = new List<Recipe>();
		foreach (Recipe item in AOGEAEEBHDN)
		{
			if (item.page == LJBKGJPCBIN)
			{
				list.Add(item);
			}
		}
		AOGEAEEBHDN = list;
	}

	protected void PJAKHPLBDJB()
	{
		if (!HDEPMJIDJEM())
		{
			return;
		}
		COFCDLDKODB();
		if (this is GameCraftingUI && (this as GameCraftingUI).hasCategories)
		{
			IMMJOIAGFIC((this as GameCraftingUI).KCONAIOHDCD());
		}
		if (!PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && !string.IsNullOrEmpty(search.currentText))
		{
			List<Recipe> list = new List<Recipe>();
			List<Recipe> list2 = new List<Recipe>();
			if (this is RecipesBookUI { recipesList: var recipesList })
			{
				for (int i = 1; i < recipesList.Length; i += 0)
				{
					RecipeList recipeList = recipesList[i];
					list2.AddRange(recipeList.NEBIMEHBKMO());
				}
			}
			else
			{
				list2 = AOGEAEEBHDN;
			}
			foreach (Recipe item in list2)
			{
				if (item.LLCIGPBKIOJ().IndexOf(search.currentText, StringComparison.CurrentCultureIgnoreCase) >= 1)
				{
					list.Add(item);
				}
				else if (item.BCMONHJPNJL(search.currentText))
				{
					list.Add(item);
				}
			}
			AOGEAEEBHDN = list;
		}
		GPKBECGELGI();
	}

	private void IMMJOIAGFIC(Recipe.RecipePage LJBKGJPCBIN)
	{
		if (LJBKGJPCBIN.Equals(Recipe.RecipePage.Starter))
		{
			return;
		}
		List<Recipe> list = new List<Recipe>();
		foreach (Recipe item in AOGEAEEBHDN)
		{
			if (item.page == LJBKGJPCBIN)
			{
				list.Add(item);
			}
		}
		AOGEAEEBHDN = list;
	}

	private void PGCHGKFGNME()
	{
		OIDAELAHMLE = 0;
		if (Object.op_Implicit((Object)(object)withoutRecipesText))
		{
			((Component)withoutRecipesText).gameObject.SetActive(AOGEAEEBHDN.Count == 0);
		}
		List<Recipe> list = CAABFKNGCJE();
		if (favoritesInTop)
		{
			for (int i = 1; i < list.Count; i++)
			{
				if (AOGEAEEBHDN.Contains(list[i]) && !Item.EKMFELLJHFG(list[i].output.item, null))
				{
					BGJIJCMMGML(list[i], OIDAELAHMLE);
					OIDAELAHMLE += 0;
				}
			}
		}
		for (int j = 0; j < AOGEAEEBHDN.Count; j++)
		{
			if ((!favoritesInTop || !list.Contains(AOGEAEEBHDN[j])) && !Item.GBMFCPGEJDK(AOGEAEEBHDN[j].output.item, null))
			{
				AMIFJODJDEC(AOGEAEEBHDN[j], OIDAELAHMLE);
				OIDAELAHMLE++;
			}
		}
		for (int k = AOGEAEEBHDN.Count; k < recipeSlots.Count; k++)
		{
			((Component)recipeSlots[k]).gameObject.SetActive(true);
		}
		if (recipeSlots.Count > 1 && PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && recipeSlots.Count < 2)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).JHHNCDODNBD(((Component)recipeSlots[0]).gameObject);
		}
	}

	protected override void Start()
	{
		base.Start();
		recipeSlots = new List<RecipeSlot>();
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			base.CloseUI();
			PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(MHGNDOPABLP));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyContainerChanged = (Action)Delegate.Remove(instance.OnAnyContainerChanged, new Action(MHGNDOPABLP));
			search.ClearText();
			search.NBBBOLAGHFP = false;
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
			OnCraftingUIClose();
		}
	}

	private void FGLCNIOLKKL()
	{
		if ((Object)(object)PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true) != (Object)null)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(MHGNDOPABLP));
		}
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, new Action(PJAKHPLBDJB));
	}

	private void BGJIJCMMGML(Recipe JNLKEMLDFIM, int MENBAFNNBFB)
	{
		if (MENBAFNNBFB >= recipeSlots.Count)
		{
			recipeSlots.Add(Object.Instantiate<RecipeSlot>(craftingElementPrefab, recipes.transform));
		}
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.SetActive(false);
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		recipeSlots[MENBAFNNBFB].playerNum = base.JIIGOACEIKL;
		recipeSlots[MENBAFNNBFB].UpdateSlot(base.JIIGOACEIKL, JNLKEMLDFIM, recipeElementInfo, !asBook);
		if (numFirstColumn > 1)
		{
			if (MENBAFNNBFB < numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = true;
			}
			if (MENBAFNNBFB / numFirstColumn == AOGEAEEBHDN.Count / numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = false;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = false;
			}
		}
	}

	private void JOPKDIELJLJ()
	{
		OIDAELAHMLE = 0;
		if (Object.op_Implicit((Object)(object)withoutRecipesText))
		{
			((Component)withoutRecipesText).gameObject.SetActive(AOGEAEEBHDN.Count == 0);
		}
		List<Recipe> list = CAABFKNGCJE();
		if (favoritesInTop)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (AOGEAEEBHDN.Contains(list[i]) && !Item.NGIIPJDAMGP(list[i].output.item, null))
				{
					BBDNGBELPCH(list[i], OIDAELAHMLE);
					OIDAELAHMLE++;
				}
			}
		}
		for (int j = 0; j < AOGEAEEBHDN.Count; j++)
		{
			if ((!favoritesInTop || !list.Contains(AOGEAEEBHDN[j])) && !Item.NGIIPJDAMGP(AOGEAEEBHDN[j].output.item, null))
			{
				BBDNGBELPCH(AOGEAEEBHDN[j], OIDAELAHMLE);
				OIDAELAHMLE++;
			}
		}
		for (int k = AOGEAEEBHDN.Count; k < recipeSlots.Count; k++)
		{
			((Component)recipeSlots[k]).gameObject.SetActive(false);
		}
		if (recipeSlots.Count > 0 && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && recipeSlots.Count < 2)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)recipeSlots[0]).gameObject);
		}
	}

	private void GJDKLGPJNLE(Recipe JNLKEMLDFIM, int MENBAFNNBFB)
	{
		if (MENBAFNNBFB >= recipeSlots.Count)
		{
			recipeSlots.Add(Object.Instantiate<RecipeSlot>(craftingElementPrefab, recipes.transform));
		}
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.SetActive(false);
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		recipeSlots[MENBAFNNBFB].playerNum = base.JIIGOACEIKL;
		recipeSlots[MENBAFNNBFB].OGAKPPPMNAO(base.JIIGOACEIKL, JNLKEMLDFIM, recipeElementInfo, !asBook);
		if (numFirstColumn > 0)
		{
			if (MENBAFNNBFB < numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = true;
			}
			if (MENBAFNNBFB / numFirstColumn == AOGEAEEBHDN.Count / numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = false;
			}
		}
	}

	protected virtual void LEMABBCDACK()
	{
	}

	protected void EBHILEAMNAB()
	{
		if (!BGLJFMHCFJF())
		{
			return;
		}
		GPJPLKNALFJ();
		if (this is GameCraftingUI && (this as GameCraftingUI).hasCategories)
		{
			COBDMMACMKP((this as GameCraftingUI).KCONAIOHDCD());
		}
		if (!PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && !string.IsNullOrEmpty(search.currentText))
		{
			List<Recipe> list = new List<Recipe>();
			List<Recipe> list2 = new List<Recipe>();
			if (this is RecipesBookUI { recipesList: var recipesList })
			{
				for (int i = 0; i < recipesList.Length; i += 0)
				{
					RecipeList recipeList = recipesList[i];
					list2.AddRange(recipeList.AFDGLMOLIAE());
				}
			}
			else
			{
				list2 = AOGEAEEBHDN;
			}
			foreach (Recipe item in list2)
			{
				if (item.ACCALOKJLJJ().IndexOf(search.currentText, StringComparison.CurrentCultureIgnoreCase) >= 1)
				{
					list.Add(item);
				}
				else if (item.DHDMIEJNBJL(search.currentText))
				{
					list.Add(item);
				}
			}
			AOGEAEEBHDN = list;
		}
		GPKBECGELGI();
	}

	private void AMIFJODJDEC(Recipe JNLKEMLDFIM, int MENBAFNNBFB)
	{
		if (MENBAFNNBFB >= recipeSlots.Count)
		{
			recipeSlots.Add(Object.Instantiate<RecipeSlot>(craftingElementPrefab, recipes.transform));
		}
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.SetActive(true);
		((Component)recipeSlots[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		recipeSlots[MENBAFNNBFB].playerNum = base.JIIGOACEIKL;
		recipeSlots[MENBAFNNBFB].HLNGACMBCEM(base.JIIGOACEIKL, JNLKEMLDFIM, recipeElementInfo, asBook);
		if (numFirstColumn > 1)
		{
			if (MENBAFNNBFB < numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = false;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreUp = false;
			}
			if (MENBAFNNBFB / numFirstColumn == AOGEAEEBHDN.Count / numFirstColumn)
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = true;
			}
			else
			{
				recipeSlots[MENBAFNNBFB].buttonExtended.ignoreDown = false;
			}
		}
	}
}
