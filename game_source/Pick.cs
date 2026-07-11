using AlmenaraGames;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Pick")]
public class Pick : Tool
{
	public float workDonePerHit = 1f;

	public AudioObject pickFailSound;

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new PickInstance((PickInstance)DNLMCHDOMOK);
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new PickInstance(this);
	}
}
