using System;
using Newtonsoft.Json;

[Serializable]
public class NewRecipeQueueElementMessage : IOnlineSerializable
{
	[JsonProperty("rQE")]
	public RecipeQueueElementMessage recipeQueueElementMessage;

	[JsonProperty("dF")]
	public GameDateMessage dateFinished;

	public NewRecipeQueueElementMessage(RecipeQueueElement FGLCCLGBGAL, GameDate LHBHOPKNBHM)
	{
		recipeQueueElementMessage = new RecipeQueueElementMessage(FGLCCLGBGAL);
		dateFinished = new GameDateMessage(LHBHOPKNBHM);
	}
}
