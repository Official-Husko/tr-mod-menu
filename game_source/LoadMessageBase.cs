using System;
using Newtonsoft.Json;

[Serializable]
public abstract class LoadMessageBase : IOnlineSerializable
{
	[JsonProperty("mID")]
	public short msgID;

	[JsonProperty("lm")]
	public bool lastMsg;

	public abstract void OEJJGDMKIDN();
}
