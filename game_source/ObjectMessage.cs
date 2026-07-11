using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public abstract class ObjectMessage : IOnlineSerializable
{
	[JsonProperty("uId")]
	public int uniqueId;

	[JsonProperty("po")]
	public Vector2Online position;

	public virtual OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = OnlineObjectsManager.instance.GetOnlineObject(uniqueId, OEBNHGNJEJL: false);
		if (this is RockMessage && (Object)(object)onlineObject == (Object)null)
		{
			Debug.LogError((object)("Online rock with unique ID " + uniqueId + " not found when loading RockMessage."));
			return null;
		}
		if ((Object)(object)onlineObject == (Object)null)
		{
			onlineObject = JCNFPEHGGKP();
			if (Object.op_Implicit((Object)(object)onlineObject))
			{
				onlineObject.AssignUniqueId(uniqueId);
			}
		}
		return onlineObject;
	}

	protected abstract OnlineObject JCNFPEHGGKP();

	public ObjectMessage(OnlineObject DCLFIGENEIF)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCLFIGENEIF == (Object)null)
		{
			Debug.LogError((object)"Online object doesn't exist loading ObjectMessage");
			return;
		}
		uniqueId = DCLFIGENEIF.uniqueId;
		position = new Vector2Online(Vector2.op_Implicit(((Component)DCLFIGENEIF).transform.position));
	}
}
