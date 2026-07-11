using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "New Terrain Rule Tile", menuName = "Tiles/Terrain Rule Tile")]
public class TerrainRuleTile : RuleTile
{
	public bool generateCliffs;
}
