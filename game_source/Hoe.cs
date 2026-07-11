using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Hoe")]
public class Hoe : Tool
{
	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new HoeInstance((HoeInstance)DNLMCHDOMOK);
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new HoeInstance(this);
	}
}
