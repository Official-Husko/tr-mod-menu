using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Bird")]
public class Bird : Item
{
	public BirdType birdType;

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new BirdInstance((BirdInstance)DNLMCHDOMOK);
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new BirdInstance(this);
	}
}
