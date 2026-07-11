using System;
using Newtonsoft.Json;

[Serializable]
public struct FeederInfo
{
	[JsonProperty("1")]
	public byte level;

	[JsonProperty("2")]
	public SlotsMessage slots;

	[JsonProperty("3")]
	public byte style;
}
