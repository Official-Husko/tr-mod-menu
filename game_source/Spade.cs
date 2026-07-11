using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Spade")]
public class Spade : Tool
{
	public CharacterMaterial groundSpadeMaterial;

	public CharacterMaterial snowSpadeMaterial;

	public Item RocksItem;

	public override ItemInstance JMDALJBNFML()
	{
		return new SpadeInstance(this);
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new SpadeInstance((SpadeInstance)DNLMCHDOMOK);
	}
}
