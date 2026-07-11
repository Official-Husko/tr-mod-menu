using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class MusselMessage : MiscellaneousHarvestMessage
{
	[JsonProperty("1")]
	public int parentUniqueID;

	public MusselMessage(OnlineMusselHarvest AIIJPLLBHDO)
		: base(AIIJPLLBHDO)
	{
		parentUniqueID = AIIJPLLBHDO.parentUniqueID;
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineMusselHarvest onlineMusselHarvest)
		{
			onlineMusselHarvest.parentUniqueID = parentUniqueID;
		}
		return onlineObject;
	}

	protected override OnlineObject JCNFPEHGGKP()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(parentUniqueID, out var value))
		{
			return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.spawnersPrefabs[prefabIndex], Vector2.op_Implicit(position.DMBNLBPEELL()), Quaternion.identity, ((Component)value).transform).GetComponent<OnlineObject>();
		}
		Debug.LogError((object)("Mussel parent not found!!. Parent unique ID: " + parentUniqueID));
		return null;
	}
}
