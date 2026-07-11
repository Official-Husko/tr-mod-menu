public struct IngredientUsedInfo
{
	public ItemInstanceAmount itemInstanceAmount;

	public bool isModifierIngredient;

	public Slot sourceSlot;

	public IngredientUsedInfo(ItemInstanceAmount DHIPBDLIMMB, bool DAJBIIKMEOD, Slot DGFPLODEDAA)
	{
		itemInstanceAmount = DHIPBDLIMMB;
		isModifierIngredient = DAJBIIKMEOD;
		sourceSlot = DGFPLODEDAA;
	}

	public IngredientUsedInfo(ItemInstance HPHELAPHAHN, bool DAJBIIKMEOD, Slot DGFPLODEDAA)
	{
		itemInstanceAmount = new ItemInstanceAmount(HPHELAPHAHN, 1);
		isModifierIngredient = DAJBIIKMEOD;
		sourceSlot = DGFPLODEDAA;
	}
}
