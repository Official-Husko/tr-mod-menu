using System;
using Newtonsoft.Json;

[Serializable]
public class IrrigatorMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public int waterAmount;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineIrrigator onlineIrrigator)
		{
			onlineIrrigator.irrigator.currentAmount = waterAmount;
			onlineIrrigator.irrigator.UpdateSprite();
		}
		return onlineObject;
	}

	public IrrigatorMessage(OnlineIrrigator DPHMBALEFIL)
		: base(DPHMBALEFIL)
	{
		waterAmount = DPHMBALEFIL.irrigator.currentAmount;
	}
}
