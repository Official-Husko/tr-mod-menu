using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class FloorDirtMessage : ObjectMessage
{
	[JsonProperty("1")]
	public short skin;

	[JsonProperty("2")]
	public bool flipX;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineFloorDirt onlineFloorDirt)
		{
			onlineFloorDirt.floorDirt.randomise = false;
			onlineFloorDirt.floorDirt.spriteIndex = skin;
			onlineFloorDirt.floorDirt.spriteRenderer.flipX = flipX;
		}
		return onlineObject;
	}

	protected override OnlineObject JCNFPEHGGKP()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.dirtPrefab, Vector2.op_Implicit(Utils.BPKGAMFNAGC(position)), Quaternion.identity).GetComponent<OnlineFloorDirt>();
	}

	public FloorDirtMessage(OnlineFloorDirt EAFBGFKFBFC)
		: base(EAFBGFKFBFC)
	{
		skin = (short)EAFBGFKFBFC.floorDirt.spriteIndex;
		flipX = EAFBGFKFBFC.floorDirt.spriteRenderer.flipX;
	}
}
