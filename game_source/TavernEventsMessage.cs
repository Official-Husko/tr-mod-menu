using System;
using System.Collections.Generic;

[Serializable]
public class TavernEventsMessage : LoadMessageBase
{
	public OnlineTavernEvent[] onlineTavernEvents;

	public override void OEJJGDMKIDN()
	{
		if (onlineTavernEvents != null)
		{
			TavernEventManager.tavernEvents = new List<TavernEvent>();
			for (int i = 0; i < onlineTavernEvents.Length; i++)
			{
				TavernEventManager.tavernEvents.Add(new TavernEvent((TREventType)onlineTavernEvents[i].eventType, onlineTavernEvents[i].eventDate.JBJLBDHAECK(), "A very important guest is visiting!"));
			}
		}
	}

	public TavernEventsMessage(List<TavernEvent> OIGLBHPPAPN)
	{
		if (OIGLBHPPAPN != null)
		{
			onlineTavernEvents = new OnlineTavernEvent[OIGLBHPPAPN.Count];
			for (int i = 0; i < OIGLBHPPAPN.Count; i++)
			{
				onlineTavernEvents[i] = new OnlineTavernEvent((byte)OIGLBHPPAPN[i].eventType, new GameDateMessage(OIGLBHPPAPN[i].eventDate));
			}
		}
	}
}
