using System;
using Newtonsoft.Json;

[Serializable]
public class DoorMessage : PlaceableMsg
{
	[JsonProperty("op")]
	public bool open;

	public DoorMessage(OnlineDoor EDEPIKEPLGL)
		: base(EDEPIKEPLGL)
	{
		open = EDEPIKEPLGL.door.ECMGCJGPKNO;
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineDoor onlineDoor)
		{
			onlineDoor.door.ForceOpen(open);
		}
		return onlineObject;
	}
}
