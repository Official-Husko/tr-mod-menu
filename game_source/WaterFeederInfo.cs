using System;
using Newtonsoft.Json;

[Serializable]
public struct WaterFeederInfo
{
	[JsonProperty("1")]
	public byte level;

	[JsonProperty("2")]
	public byte quantity;

	[JsonProperty("3")]
	public byte style;
}
