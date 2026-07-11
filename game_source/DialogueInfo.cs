using Newtonsoft.Json;

public struct DialogueInfo : IOnlineSerializable
{
	[JsonProperty("1")]
	public string name;

	[JsonProperty("2")]
	public short value;

	public DialogueInfo(string LNHBAFGPGBJ, short EGFGNGJGBOP)
	{
		name = LNHBAFGPGBJ;
		value = EGFGNGJGBOP;
	}
}
