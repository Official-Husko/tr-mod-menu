public struct QuestTooltipInfo
{
	public string questName;

	public string questDescription;

	public Item[] items;

	public int requiredAmount;

	public ActiveQuest activeQuest;

	public Quest[] linkedQuests;

	public Reward reward;

	public IngredientModifier[] modifiers;

	public int playerNum;
}
