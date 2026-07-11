using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Animals/Chicken")]
public class Chicken : Animal
{
	public override ItemInstance JMDALJBNFML()
	{
		return new ChickenInstance(this);
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new ChickenInstance((ChickenInstance)DNLMCHDOMOK);
	}
}
