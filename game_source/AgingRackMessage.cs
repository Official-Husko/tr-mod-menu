using System;
using Newtonsoft.Json;

[Serializable]
public class AgingRackMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public SlotMessage<FoodInstanceMessage> inputSlot1;

	[JsonProperty("2")]
	public SlotMessage<FoodInstanceMessage> inputSlot2;

	[JsonProperty("3")]
	public SlotMessage<FoodInstanceMessage> outputSlot1;

	[JsonProperty("4")]
	public SlotMessage<FoodInstanceMessage> outputSlot2;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineAgingRack onlineAgingRack)
		{
			if (inputSlot1 != null)
			{
				inputSlot1.LFFAOPJACAF(onlineAgingRack.agingRack.inputSlot1);
			}
			if (inputSlot2 != null)
			{
				inputSlot2.LFFAOPJACAF(onlineAgingRack.agingRack.inputSlot2);
			}
			if (outputSlot1 != null)
			{
				outputSlot1.LFFAOPJACAF(onlineAgingRack.agingRack.outputSlot1);
			}
			if (outputSlot2 != null)
			{
				outputSlot2.LFFAOPJACAF(onlineAgingRack.agingRack.outputSlot2);
			}
		}
		return onlineObject;
	}

	public AgingRackMessage(OnlineAgingRack FNOHECDGHII)
		: base(FNOHECDGHII)
	{
		inputSlot1 = (FNOHECDGHII.agingRack.inputSlot1.KPINNBKMOMO() ? null : SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(FNOHECDGHII.agingRack.inputSlot1));
		inputSlot2 = (FNOHECDGHII.agingRack.inputSlot2.KPINNBKMOMO() ? null : SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(FNOHECDGHII.agingRack.inputSlot2));
		outputSlot1 = (FNOHECDGHII.agingRack.outputSlot1.KPINNBKMOMO() ? null : SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(FNOHECDGHII.agingRack.outputSlot1));
		outputSlot2 = (FNOHECDGHII.agingRack.outputSlot2.KPINNBKMOMO() ? null : SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(FNOHECDGHII.agingRack.outputSlot2));
	}
}
