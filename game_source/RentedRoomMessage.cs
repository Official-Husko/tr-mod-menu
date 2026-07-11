using System;
using Newtonsoft.Json;

[Serializable]
public class RentedRoomMessage : DoorMessage
{
	[JsonProperty("oc")]
	public bool occupied;

	[JsonProperty("cI")]
	public bool customerInside;

	[JsonProperty("rTL")]
	public bool readyToLeave;

	[JsonProperty("req")]
	public bool requestingItem;

	[JsonProperty("rD")]
	public int remainingDays;

	[JsonProperty("syI")]
	public short symbolID;

	[JsonProperty("rI")]
	public ItemInstanceWrapperMessage requestItem;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.symbolID = RentedRoomsManager.AssignSymbolID(symbolID);
			if (occupied)
			{
				HumanInfo dKDFNAGAFNL = new HumanInfo();
				onlineRentedRoom.rentedRoom.SetNewCustomerInRoom(dKDFNAGAFNL, remainingDays);
				onlineRentedRoom.rentedRoom.ReadyToLeave();
				onlineRentedRoom.rentedRoom.readyToLeave = readyToLeave;
				if (requestingItem)
				{
					onlineRentedRoom.rentedRoom.customerOrder.UpdateRequestRoomOrder(requestItem.ANMBPDJLNFN());
				}
			}
		}
		return onlineObject;
	}

	public RentedRoomMessage(OnlineRentedRoom BBJBCDNEKFG)
		: base(BBJBCDNEKFG)
	{
		occupied = BBJBCDNEKFG.rentedRoom.occupied;
		customerInside = BBJBCDNEKFG.rentedRoom.customerInside;
		requestingItem = BBJBCDNEKFG.rentedRoom.customerOrder.requesting;
		if (requestingItem)
		{
			requestItem = new ItemInstanceWrapperMessage(BBJBCDNEKFG.rentedRoom.customerOrder.roomItemRequest);
		}
		else
		{
			requestItem = null;
		}
		symbolID = (short)BBJBCDNEKFG.rentedRoom.symbolID;
		remainingDays = BBJBCDNEKFG.rentedRoom.remainingDays;
		readyToLeave = BBJBCDNEKFG.rentedRoom.readyToLeave;
	}
}
