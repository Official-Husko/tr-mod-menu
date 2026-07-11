using UnityEngine;

public class OnlineAreaSpace : OnlineCrafter
{
	public AreaSpace areaSpace;

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		areaSpace = ((Component)((Component)this).transform).GetComponentInChildren<AreaSpace>();
	}

	public override PlaceableMsg CreateMsg()
	{
		if ((Object)(object)areaSpace == (Object)null)
		{
			Debug.LogError((object)("AreaSpace not attached on OnlineAreaSpace of placeable " + ((Object)((Component)this).gameObject).name));
		}
		return new AreaSpaceMessage(this);
	}
}
