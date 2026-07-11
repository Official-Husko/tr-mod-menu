using System;

[Serializable]
public struct DrinkAgingRelationships
{
	public Item item;

	public Food food;

	public DrinkAgingRelationships(Item MEMGMDOCBOJ, Food AJOMICMACEJ)
	{
		item = MEMGMDOCBOJ;
		food = AJOMICMACEJ;
	}
}
