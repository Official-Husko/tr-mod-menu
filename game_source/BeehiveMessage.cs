using System;
using Newtonsoft.Json;

[Serializable]
public class BeehiveMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public int days;

	[JsonProperty("2")]
	public bool honey;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineBeehive onlineBeehive)
		{
			onlineBeehive.beehive.days = days;
			onlineBeehive.beehive.honey = honey;
		}
		return onlineObject;
	}

	public BeehiveMessage(OnlineBeehive AMADOJIGLAI)
		: base(AMADOJIGLAI)
	{
		days = AMADOJIGLAI.beehive.days;
		honey = AMADOJIGLAI.beehive.honey;
	}
}
