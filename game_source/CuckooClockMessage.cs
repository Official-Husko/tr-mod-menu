using System;
using Newtonsoft.Json;

[Serializable]
public class CuckooClockMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public int hour;

	[JsonProperty("2")]
	public int minute;

	[JsonProperty("3")]
	public bool alarm;

	public CuckooClockMessage(OnlineCuckooClock IBABCAKODKK)
		: base(IBABCAKODKK)
	{
		hour = IBABCAKODKK.cuckooClock.hour;
		minute = IBABCAKODKK.cuckooClock.minute;
		alarm = IBABCAKODKK.cuckooClock.alarm;
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineCuckooClock onlineCuckooClock)
		{
			onlineCuckooClock.cuckooClock.hour = hour;
			onlineCuckooClock.cuckooClock.minute = minute;
			onlineCuckooClock.cuckooClock.alarm = alarm;
		}
		return onlineObject;
	}
}
