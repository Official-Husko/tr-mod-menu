using UnityEngine;

public class OnlineFireplace : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		On
	}

	public Fireplace fireplace;

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		fireplace = ((Component)((Component)this).transform).GetComponentInChildren<Fireplace>();
	}

	public override PlaceableMsg CreateMsg()
	{
		if ((Object)(object)fireplace == (Object)null)
		{
			Debug.LogError((object)("Fireplace not attached on OnlineFireplace of placeable " + ((Object)((Component)this).gameObject).name));
		}
		return new FireplaceMsg(this);
	}
}
