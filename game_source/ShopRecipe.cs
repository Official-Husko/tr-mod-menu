using System;

[Serializable]
public class ShopRecipe
{
	public Recipe recipe;

	public Recipe.RecipePage page;

	public ShopRecipe(Recipe JNLKEMLDFIM)
	{
		recipe = JNLKEMLDFIM;
		page = JNLKEMLDFIM.page;
	}
}
