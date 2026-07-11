using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using PixelCrushers.DialogueSystem;

[Serializable]
public class LoadFishInfo : LoadMessageBase
{
	[JsonProperty("1")]
	public short[] fishingRecordsKey;

	[JsonProperty("1")]
	public short[] fishingRecordsValue;

	[JsonProperty("2")]
	public short[] fishInformation;

	public LoadFishInfo()
	{
		fishingRecordsKey = FishingManager.GetRecordsList().Keys.Select((int x) => (short)x).ToArray();
		fishingRecordsValue = FishingManager.GetRecordsList().Values.Select((int x) => (short)x).ToArray();
		fishInformation = (from x in FishingManager.GetFishInformation()
			select (short)x).ToArray();
	}

	public override void OEJJGDMKIDN()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		FishingManager.SetFishInformation(new List<int>(((IEnumerable<short>)fishInformation).Select((Func<short, int>)((short x) => x))));
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < fishingRecordsKey.Length; i++)
		{
			dictionary.Add(fishingRecordsKey[i], fishingRecordsValue[i]);
		}
		FishingManager.SetRecordsList(dictionary);
		if (FishingManager.GetFishInformation().Count > 0)
		{
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt < 12)
			{
				DialogueLua.SetVariable("LE_10", (object)12);
			}
		}
	}
}
