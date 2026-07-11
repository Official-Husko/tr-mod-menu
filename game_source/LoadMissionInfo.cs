using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class LoadMissionInfo : LoadMessageBase
{
	[JsonProperty("1")]
	public ActiveMissionInfo[] activeMissions;

	[JsonProperty("2")]
	public short[] completedMissions;

	public override void OEJJGDMKIDN()
	{
		for (int i = 0; i < completedMissions.Length; i++)
		{
			MissionsManager.instance.AddCompletedMission(completedMissions[i], CDPAMNIPPEC: false);
		}
		for (int j = 0; j < activeMissions.Length; j++)
		{
			MissionBase mission = MissionsDatabaseAccessor.GetMission(activeMissions[j].missionId);
			if (!Object.op_Implicit((Object)(object)mission))
			{
				continue;
			}
			ActiveMission activeMission = MissionsManager.instance.StartMission(mission, EPJLPKAGHDM: false, CDPAMNIPPEC: false);
			if (activeMission == null)
			{
				continue;
			}
			activeMission.completedObjectives = new List<bool>(activeMissions[j].completedObjectives);
			if (activeMission != MissionsManager.instance.mainActiveMission)
			{
				continue;
			}
			for (int k = 0; k < activeMissions[j].completedObjectives.Length; k++)
			{
				if (activeMissions[j].completedObjectives[k])
				{
					MissionsManager.instance.ObjectiveCompleted(k, activeMission, BLJPGJKOLNF: false);
				}
			}
		}
	}

	public LoadMissionInfo()
	{
		List<ActiveMissionInfo> list = new List<ActiveMissionInfo>();
		for (int i = 0; i < MissionsManager.instance.activeMissions.Count; i++)
		{
			list.Add(new ActiveMissionInfo
			{
				missionId = (short)MissionsManager.instance.activeMissions[i].mission.id,
				completedObjectives = MissionsManager.instance.activeMissions[i].completedObjectives.ToArray()
			});
		}
		activeMissions = list.ToArray();
		completedMissions = MissionsManager.instance.completedMissions.Select((MissionBase aq) => (short)aq.id).ToArray();
	}
}
