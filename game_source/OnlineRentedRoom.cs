using UnityEngine;

public class OnlineRentedRoom : OnlineDoor
{
	public RentedRoom rentedRoom;

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		rentedRoom = ((Component)((Component)this).transform).GetComponentInChildren<RentedRoom>();
	}

	public override PlaceableMsg CreateMsg()
	{
		return new RentedRoomMessage(this);
	}
}
