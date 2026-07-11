using System;
using Newtonsoft.Json;

[Serializable]
public class RockMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public float workDone;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineRock { rockLoaded: false } onlineRock)
		{
			if (onlineRock.rock.work.AddWorkDone(1, workDone, CDPAMNIPPEC: false))
			{
				onlineRock.rock.WorkFinished(CDPAMNIPPEC: false);
			}
			onlineRock.rock.CheckSnowPhase();
			onlineRock.rockLoaded = true;
		}
		return onlineObject;
	}

	public RockMessage(OnlineRock HICBJDGPMDM)
		: base(HICBJDGPMDM)
	{
		workDone = HICBJDGPMDM.rock.work.OJLICLKJJOF;
	}
}
