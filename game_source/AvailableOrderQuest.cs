using System;

[Serializable]
public class AvailableOrderQuest
{
	public CraftItemTypeQuest quest;

	public bool addedToCurrent;

	public AvailableOrderQuest(CraftItemTypeQuest AINAHCLIAFF, bool HCDLPFENIND = false)
	{
		quest = AINAHCLIAFF;
		addedToCurrent = HCDLPFENIND;
	}
}
