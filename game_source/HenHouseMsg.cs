using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class HenHouseMsg : PlaceableMsg
{
	[JsonProperty("1")]
	public byte constructionPhase;

	[JsonProperty("2")]
	public byte daysUntilImprovement;

	[JsonProperty("3")]
	public byte level;

	[JsonProperty("4")]
	public byte waterQuantity;

	[JsonProperty("5")]
	public byte style;

	[JsonProperty("6")]
	public byte eggs;

	[JsonProperty("7")]
	public SlotsMessage slots;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineHenHouse { henHouse: var henHouse })
		{
			henHouse.EONJGMONIOM = level;
			henHouse.SetStyle(CharacterSpritesDBAccessor.GetHenHouseStyle(style));
			henHouse.SetConstructionPhase(constructionPhase);
			henHouse.eggsAmount = eggs;
			henHouse.SetImproving(daysUntilImprovement);
			((Component)henHouse.foodFeeder).gameObject.SetActive(true);
			((Component)henHouse.waterFeeders[0]).gameObject.SetActive(true);
			slots.MPHCPPPEBCF(ref henHouse.foodFeeder.container.slots);
			(henHouse.waterFeeders[0] as AnimalFeederWaterHenHouse).LoadWaterFeeder(level, waterQuantity);
		}
		return onlineObject;
	}

	public HenHouseMsg(OnlineHenHouse LKACBMNBOHC)
		: base(LKACBMNBOHC)
	{
		HenHouse henHouse = LKACBMNBOHC.henHouse;
		level = (byte)henHouse.EONJGMONIOM;
		style = (byte)henHouse.style.id;
		constructionPhase = (byte)henHouse.DPDMICLMEOD;
		daysUntilImprovement = (byte)henHouse.KAPKMMGKEPJ;
		slots = SlotsMessage.MENBNCJDCEO(henHouse.foodFeeder.container.slots);
		waterQuantity = (byte)henHouse.waterFeeders[0].GetCurrentAmount();
		eggs = (byte)henHouse.eggsAmount;
	}
}
