using System;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class LoadQuestInfo : LoadMessageBase
{
	[JsonProperty("1")]
	public short[] questDone;

	[JsonProperty("2")]
	public short[] questActiveId;

	[JsonProperty("2")]
	public short[] questActiveProgress;

	public LoadQuestInfo()
	{
		questDone = (from x in QuestManager.GGFJGHHHEJC.GetQuestsDone()
			select (short)x).ToArray();
		questActiveId = (from aq in QuestManager.GGFJGHHHEJC.MADOFDHLKKN
			where aq != null && (Object)(object)aq.quest != (Object)null && aq.quest.id != 0
			select (short)aq.quest.id).ToArray();
		questActiveProgress = (from aq in QuestManager.GGFJGHHHEJC.MADOFDHLKKN
			where aq != null && (Object)(object)aq.quest != (Object)null && aq.quest.id != 0
			select (short)aq.currentAmount).ToArray();
	}

	public override void OEJJGDMKIDN()
	{
		for (int i = 0; i < questDone.Length; i++)
		{
			QuestManager.GGFJGHHHEJC.AddQuestDone(questDone[i]);
		}
		for (int j = 0; j < questActiveId.Length; j++)
		{
			Quest quest = QuestDatabaseAccessor.GetQuest(questActiveId[j]);
			if (quest.active)
			{
				QuestManager.GGFJGHHHEJC.AddQuest(quest, questActiveProgress[j], FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			}
		}
	}
}
