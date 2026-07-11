using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class ItemContainerMsg : PlaceableMsg
{
	[JsonProperty("1")]
	public SlotsMessage slots;

	[JsonProperty("2")]
	public short drinkColorId;

	[JsonProperty("3")]
	public byte containerColorId;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineItemContainer onlineItemContainer)
		{
			if (slots != null)
			{
				onlineItemContainer.itemContainer.createInstances = false;
				slots.MPHCPPPEBCF(ref onlineItemContainer.itemContainer.slots);
				if ((Object)(object)onlineItemContainer.itemContainer != (Object)null && !CraftingInventory.ContainsItem(onlineItemContainer.itemContainer))
				{
					CraftingInventory.AddItem(onlineItemContainer.itemContainer);
				}
				onlineItemContainer.itemContainer.containerColor = containerColorId;
			}
		}
		else
		{
			Debug.LogError((object)("Received PlaceableMsg of another type not ContainerMsg to " + ((Object)((Component)onlineObject).gameObject).name));
		}
		return onlineObject;
	}

	public ItemContainerMsg(OnlineItemContainer AMGDALMNHHB)
		: base(AMGDALMNHHB)
	{
		slots = SlotsMessage.MENBNCJDCEO(AMGDALMNHHB.itemContainer.slots);
		containerColorId = (byte)AMGDALMNHHB.itemContainer.containerColor;
	}
}
