using System;
using Newtonsoft.Json;

[Serializable]
public struct VariationGroup
{
	[JsonProperty("1")]
	public int[] idsActivated;
}
