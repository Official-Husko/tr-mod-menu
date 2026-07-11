using System;
using Newtonsoft.Json;

[Serializable]
public class FishTrapMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public byte remainingUses;

	[JsonProperty("2")]
	public bool captured;

	[JsonProperty("3")]
	public short itemID;

	public FishTrapMessage(OnlineFishTrap PKIGACPKJBJ)
		: base(PKIGACPKJBJ)
	{
		remainingUses = (byte)PKIGACPKJBJ.fishTrap.remainingUses;
		captured = PKIGACPKJBJ.fishTrap.PJMAKGONJOM;
		if (Item.MLBOMGHINCA(PKIGACPKJBJ.fishTrap.itemChosen, null))
		{
			itemID = (short)PKIGACPKJBJ.fishTrap.itemChosen.JDJGFAACPFC();
		}
		else
		{
			itemID = 0;
		}
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineFishTrap onlineFishTrap)
		{
			onlineFishTrap.fishTrap.remainingUses = remainingUses;
			if (itemID != 0)
			{
				onlineFishTrap.fishTrap.itemChosen = ItemDatabaseAccessor.GetItem(itemID);
			}
			else
			{
				onlineFishTrap.fishTrap.itemChosen = null;
			}
			onlineFishTrap.fishTrap.SetObjectCaptured(captured);
		}
		return onlineObject;
	}
}
