using System;
using Newtonsoft.Json;

[Serializable]
public class BedMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public bool bedMade;

	public BedMessage(OnlineBed HILBPCLAIOK)
		: base(HILBPCLAIOK)
	{
		bedMade = HILBPCLAIOK.nPCBed.IDHLOLDLLOE;
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineBed onlineBed)
		{
			onlineBed.nPCBed.SetBedMade(bedMade, CDPAMNIPPEC: false);
		}
		return onlineObject;
	}
}
