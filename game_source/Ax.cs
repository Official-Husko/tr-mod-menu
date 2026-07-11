using AlmenaraGames;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Ax")]
public class Ax : Tool
{
	public float workDonePerHit = 1f;

	public AudioObject axeFailSound;

	[Space(10f)]
	public DroppedItems[] additionalItemsAdultTree;

	[Space(10f)]
	public DroppedItems[] additionalItemsAncientTree;

	public override ItemInstance JMDALJBNFML()
	{
		return new AxInstance(this);
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new AxInstance((AxInstance)DNLMCHDOMOK);
	}
}
