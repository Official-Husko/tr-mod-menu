using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class FireplaceMsg : PlaceableMsg
{
	[JsonProperty("1")]
	public bool on;

	[JsonProperty("2")]
	public SlotMessage<ItemInstanceMessage> slotOnline;

	[JsonProperty("3")]
	public ItemInstanceMessage currentFuelInstance;

	[JsonProperty("4")]
	public float currentFuelLevel;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineFireplace { fireplace: var fireplace })
		{
			fireplace.currentFuel = currentFuelLevel;
			if (slotOnline != null && slotOnline.stack != 0)
			{
				slotOnline.LFFAOPJACAF(fireplace.IOLCGKLFPEO);
			}
			fireplace.SetOn(on, CDPAMNIPPEC: false);
			if (currentFuelInstance != null)
			{
				fireplace.currentFuelInstance = currentFuelInstance.ANMBPDJLNFN() as FuelInstance;
				return onlineObject;
			}
			fireplace.InitializeFireplace();
		}
		return onlineObject;
	}

	public FireplaceMsg(OnlineFireplace DNLENKBLIJN)
		: base(DNLENKBLIJN)
	{
		Fireplace fireplace = DNLENKBLIJN.fireplace;
		on = fireplace.MAJLJNMJKON;
		if (fireplace.IOLCGKLFPEO != null && fireplace.IOLCGKLFPEO.itemInstance != null)
		{
			slotOnline = SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(fireplace.IOLCGKLFPEO);
		}
		else if (fireplace.IOLCGKLFPEO == null)
		{
			Debug.LogError((object)("Fuel slot empty on " + ((Object)fireplace).name));
		}
		else if (fireplace.IOLCGKLFPEO.itemInstance == null)
		{
			Debug.LogError((object)("Fuel slot Item Instance empty on " + ((Object)fireplace).name));
		}
		currentFuelLevel = fireplace.currentFuel;
		currentFuelInstance = ItemInstanceMessage.MENBNCJDCEO(fireplace.currentFuelInstance);
	}
}
