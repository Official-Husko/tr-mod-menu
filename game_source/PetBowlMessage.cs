using System;
using Newtonsoft.Json;

[Serializable]
public class PetBowlMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public bool water;

	[JsonProperty("2")]
	public bool food;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlinePetBowl onlinePetBowl)
		{
			onlinePetBowl.petBowl.SetFilled(water, food);
		}
		return onlineObject;
	}

	public PetBowlMessage(OnlinePetBowl MIJBENEGFHK)
		: base(MIJBENEGFHK)
	{
		water = MIJBENEGFHK.petBowl.withWater;
		food = MIJBENEGFHK.petBowl.withFood;
	}
}
