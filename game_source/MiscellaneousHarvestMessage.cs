using System;
using UnityEngine;

[Serializable]
public class MiscellaneousHarvestMessage : ObjectMessage
{
	public short prefabIndex;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineMiscellaneousHarvest onlineMiscellaneousHarvest)
		{
			onlineMiscellaneousHarvest.prefabIndex = prefabIndex;
		}
		return onlineObject;
	}

	public MiscellaneousHarvestMessage(OnlineMiscellaneousHarvest IOBFOLBAJNM)
		: base(IOBFOLBAJNM)
	{
		prefabIndex = (short)IOBFOLBAJNM.prefabIndex;
	}

	protected override OnlineObject JCNFPEHGGKP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.spawnersPrefabs[prefabIndex], Vector2.op_Implicit(position.DMBNLBPEELL()), Quaternion.identity).GetComponent<OnlineObject>();
	}
}
