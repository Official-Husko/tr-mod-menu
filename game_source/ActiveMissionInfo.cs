using System;
using Newtonsoft.Json;

[Serializable]
public class ActiveMissionInfo
{
	[JsonProperty("1")]
	public short missionId;

	[JsonProperty("2")]
	public bool[] completedObjectives;
}
