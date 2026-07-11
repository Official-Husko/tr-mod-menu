using System;
using Newtonsoft.Json;

[Serializable]
public class ItemInstanceAmountOnline<T> where T : ItemInstanceMessage, new()
{
	[JsonProperty("in")]
	public short index;

	[JsonProperty("it")]
	public T itemInstanceOnline;

	[JsonProperty("am")]
	public short amount;

	public ItemInstanceAmountOnline()
	{
	}

	public ItemInstanceAmountOnline(int MOFKEDGAOEE, ItemInstanceAmount IAIHNNNGNKH)
	{
		index = (short)MOFKEDGAOEE;
		itemInstanceOnline = new T();
		itemInstanceOnline.CPFDLKMCBCB(IAIHNNNGNKH.itemInstance);
		amount = (short)IAIHNNNGNKH.amount;
	}
}
