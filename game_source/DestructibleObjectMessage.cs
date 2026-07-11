using System;
using Newtonsoft.Json;

[Serializable]
public class DestructibleObjectMessage : ObjectMessage
{
	[JsonProperty("1")]
	public bool isDestroyed;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineDestructibleObject onlineDestructibleObject && isDestroyed)
		{
			onlineDestructibleObject.destructibleObject.SetDestroyed(BOCMNPIGJHM: true);
		}
		return onlineObject;
	}

	public DestructibleObjectMessage(OnlineDestructibleObject HJGJFILLPHD)
		: base(HJGJFILLPHD)
	{
		isDestroyed = HJGJFILLPHD.destructibleObject.isDestroyed;
	}

	protected override OnlineObject JCNFPEHGGKP()
	{
		return null;
	}
}
