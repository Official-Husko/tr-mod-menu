using UnityEngine;

public class OnlineAgingBarrel : OnlinePlaceable
{
	public AgingBarrel agingBarrel;

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		agingBarrel = ((Component)((Component)this).transform).GetComponentInChildren<AgingBarrel>();
	}

	protected override void Awake()
	{
		base.Awake();
		for (int i = 0; i < agingBarrel.inputSlot.Length; i++)
		{
			agingBarrel.inputSlot[i].id = (short)i;
			agingBarrel.inputSlot[i].onlineObject = this;
			agingBarrel.inputSlot[i].inventoryType = ContainerType.AgingBarrel;
		}
	}

	public override PlaceableMsg CreateMsg()
	{
		return new AgingBarrelMessage(this);
	}
}
