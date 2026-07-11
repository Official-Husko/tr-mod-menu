using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class HoleInGroundMessage : ObjectMessage
{
	[JsonProperty("1")]
	public short prefabIndex;

	[JsonProperty("2")]
	public bool found;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineHoleInGround onlineHoleInGround)
		{
			onlineHoleInGround.prefabIndex = prefabIndex;
			onlineHoleInGround.found = found;
			if (found)
			{
				onlineHoleInGround.holeInGround.harvested = true;
				onlineHoleInGround.holeInGround.UpdateSprite(SeasonManager.ACNAHALFEBG);
			}
		}
		return onlineObject;
	}

	public HoleInGroundMessage(OnlineHoleInGround OIOGDDFLBHM)
		: base(OIOGDDFLBHM)
	{
		prefabIndex = (short)OIOGDDFLBHM.prefabIndex;
		found = OIOGDDFLBHM.found;
	}

	protected override OnlineObject JCNFPEHGGKP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.spawnersPrefabs[prefabIndex], Vector2.op_Implicit(position.DMBNLBPEELL()), Quaternion.identity).GetComponent<OnlineHoleInGround>();
	}
}
