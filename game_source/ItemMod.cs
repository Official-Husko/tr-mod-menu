using System;

[Serializable]
public struct ItemMod
{
	public Item item;

	public Item mod;

	public ItemMod(Item MEMGMDOCBOJ)
	{
		this = default(ItemMod);
		item = MEMGMDOCBOJ;
	}
}
