using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mine/Mine Blocker Config")]
public sealed class MineBlockerConfig : ScriptableObject
{
	[SerializeField]
	public int level;

	public List<BlockerChance> chances;
}
