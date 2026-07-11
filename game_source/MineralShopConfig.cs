using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mine/Shop/Mine Level Config")]
public class MineralShopConfig : ScriptableObject
{
	public int mineLevel;

	public List<ShopItem> minerals;
}
