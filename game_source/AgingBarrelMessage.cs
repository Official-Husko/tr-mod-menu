using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class AgingBarrelMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public SlotsMessage inputSlots;

	[JsonProperty("2")]
	public int[] dateStartedMin;

	[JsonProperty("3")]
	public GameDateMessage[] dateFinished;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineAgingBarrel onlineAgingBarrel)
		{
			inputSlots.MPHCPPPEBCF(ref onlineAgingBarrel.agingBarrel.inputSlot);
			for (int i = 0; i < dateStartedMin.Length; i++)
			{
				if (!onlineAgingBarrel.agingBarrel.inputSlot[i].KPINNBKMOMO())
				{
					onlineAgingBarrel.agingBarrel.timer[i].SetUpTimer(dateFinished[i].JBJLBDHAECK(), (ulong)dateStartedMin[i]);
				}
			}
			for (int j = 0; j < onlineAgingBarrel.agingBarrel.timer.Length; j++)
			{
				if ((Object)(object)onlineAgingBarrel.agingBarrel.timer[j] != (Object)null && onlineAgingBarrel.agingBarrel.inputSlot[j].itemInstance is FoodInstance foodInstance)
				{
					onlineAgingBarrel.agingBarrel.SetProgressBarColour(onlineAgingBarrel.agingBarrel.timer[j].progressor, foodInstance.GBCJNGADANM);
				}
			}
		}
		return onlineObject;
	}

	public AgingBarrelMessage(OnlineAgingBarrel OMLOGKDCGPK)
		: base(OMLOGKDCGPK)
	{
		inputSlots = SlotsMessage.MENBNCJDCEO(OMLOGKDCGPK.agingBarrel.inputSlot);
		dateStartedMin = new int[OMLOGKDCGPK.agingBarrel.timer.Length];
		dateFinished = new GameDateMessage[OMLOGKDCGPK.agingBarrel.timer.Length];
		for (int i = 0; i < OMLOGKDCGPK.agingBarrel.timer.Length; i++)
		{
			if (!OMLOGKDCGPK.agingBarrel.inputSlot[i].KPINNBKMOMO())
			{
				dateStartedMin[i] = (int)OMLOGKDCGPK.agingBarrel.timer[i].dateStartedMin;
				dateFinished[i] = new GameDateMessage(OMLOGKDCGPK.agingBarrel.timer[i].DGFFOHBELPL);
			}
		}
	}
}
