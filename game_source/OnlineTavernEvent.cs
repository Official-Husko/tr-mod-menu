using System;
using Newtonsoft.Json;

[Serializable]
public struct OnlineTavernEvent : IOnlineSerializable
{
	[JsonProperty("1")]
	public byte eventType;

	[JsonProperty("2")]
	public GameDateMessage eventDate;

	public OnlineTavernEvent(byte AKADPCABHIB, GameDateMessage FGKEOMNEPEE)
	{
		eventType = AKADPCABHIB;
		eventDate = FGKEOMNEPEE;
	}
}
