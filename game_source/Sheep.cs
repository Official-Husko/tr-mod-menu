using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Animals/Sheep")]
public class Sheep : Animal
{
	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new SheepInstance((SheepInstance)DNLMCHDOMOK);
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new SheepInstance(this);
	}
}
