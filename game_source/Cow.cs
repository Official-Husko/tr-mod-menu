using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Animals/Cow")]
public class Cow : Animal
{
	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new CowInstance((CowInstance)DNLMCHDOMOK);
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new CowInstance(this);
	}
}
