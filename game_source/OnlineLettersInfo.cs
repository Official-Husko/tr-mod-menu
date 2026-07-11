using System;
using Newtonsoft.Json;

[Serializable]
public struct OnlineLettersInfo : IOnlineSerializable
{
	[JsonProperty("1")]
	public short letterID;

	[JsonProperty("2")]
	public bool read;

	[JsonProperty("3")]
	public GameDateMessage receivedDate;

	public OnlineLettersInfo(short DNNMJAGMDPA, bool LKAALEJKLPA, GameDateMessage PABKJKLPPOP)
	{
		letterID = DNNMJAGMDPA;
		read = LKAALEJKLPA;
		receivedDate = PABKJKLPPOP;
	}
}
