using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class BarnMsg : PlaceableMsg
{
	[JsonProperty("1")]
	public byte constructionPhase;

	[JsonProperty("2")]
	public byte daysUntilImprovement;

	[JsonProperty("3")]
	public byte level;

	[JsonProperty("4")]
	public byte style;

	[JsonProperty("5")]
	public bool buzzThere;

	[JsonProperty("6")]
	public FeederInfo[] feeders;

	[JsonProperty("7")]
	public WaterFeederInfo[] waterFeeders;

	[JsonProperty("8")]
	public bool open;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineBarn { barn: var barn })
		{
			barn.EONJGMONIOM = level;
			barn.buzzThere = buzzThere;
			barn.SetStyle(CharacterSpritesDBAccessor.GetBarnMaterial(style));
			barn.SetConstructionPhase(constructionPhase);
			barn.SetImproving(daysUntilImprovement);
			barn.Initialize();
			if (open)
			{
				barn.barnBell.ToggleSign();
			}
			for (int i = 0; i < barn.animalSpaces.Length; i++)
			{
				barn.animalSpaces[i].foodFeeder.LoadAnimalFeeder(feeders[i].level, feeders[i].style);
				feeders[i].slots.MPHCPPPEBCF(ref barn.animalSpaces[i].foodFeeder.container.slots);
			}
			for (int j = 0; j < barn.waterFeeders.Length; j++)
			{
				(barn.waterFeeders[j] as AnimalFeederWater).LoadWaterFeeder(waterFeeders[j].level, waterFeeders[j].style, waterFeeders[j].quantity);
			}
			for (int k = 0; k < barn.animalSpaces.Length; k++)
			{
				barn.animalSpaces[k].foodFeeder.SetLevel(feeders[k].level);
				feeders[k].slots.MPHCPPPEBCF(ref barn.animalSpaces[k].foodFeeder.container.slots);
			}
		}
		return onlineObject;
	}

	public BarnMsg(OnlineBarn KBNFPCBNMGK)
		: base(KBNFPCBNMGK)
	{
		Barn barn = KBNFPCBNMGK.barn;
		constructionPhase = (byte)barn.DPDMICLMEOD;
		daysUntilImprovement = (byte)barn.KAPKMMGKEPJ;
		level = (byte)barn.EONJGMONIOM;
		style = (byte)barn.style.id;
		buzzThere = barn.buzzThere;
		open = barn.IsOpen();
		List<FeederInfo> list = new List<FeederInfo>();
		for (int i = 0; i < barn.animalSpaces.Length; i++)
		{
			list.Add(new FeederInfo
			{
				level = (byte)barn.animalSpaces[i].foodFeeder.EONJGMONIOM,
				style = (byte)barn.animalSpaces[i].foodFeeder.style.id,
				slots = SlotsMessage.MENBNCJDCEO(barn.animalSpaces[i].foodFeeder.container.slots)
			});
		}
		feeders = list.ToArray();
		List<WaterFeederInfo> list2 = new List<WaterFeederInfo>();
		for (int j = 0; j < barn.waterFeeders.Length; j++)
		{
			WaterFeederInfo item = default(WaterFeederInfo);
			if (barn.waterFeeders[j] is AnimalFeederWater animalFeederWater)
			{
				item.level = (byte)animalFeederWater.EONJGMONIOM;
				item.quantity = (byte)animalFeederWater.GetCurrentAmount();
				item.style = (byte)animalFeederWater.style.id;
			}
			list2.Add(item);
		}
		waterFeeders = list2.ToArray();
	}
}
