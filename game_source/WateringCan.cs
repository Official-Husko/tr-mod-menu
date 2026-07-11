using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/WateringCan")]
public class WateringCan : Tool
{
	public override ItemInstance JMDALJBNFML()
	{
		return new WateringCanInstance(this);
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new WateringCanInstance((WateringCanInstance)DNLMCHDOMOK);
	}
}
