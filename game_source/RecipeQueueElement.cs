using System;
using System.Collections.Generic;

[Serializable]
public class RecipeQueueElement
{
	public Recipe recipe;

	public ItemInstanceAmount output;

	public List<IngredientUsedInfo> ingredientsUsed = new List<IngredientUsedInfo>();

	public int fuelUsed;

	public string customName;

	public RecipeQueueElement()
	{
	}

	public RecipeQueueElement(Recipe GDBMELMKBMA, ItemInstanceAmount DDFBCNLOCCN, string AFFIIFAMGMM = null)
	{
		recipe = GDBMELMKBMA;
		output = DDFBCNLOCCN;
		customName = AFFIIFAMGMM;
	}
}
