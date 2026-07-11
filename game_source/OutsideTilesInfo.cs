using System;
using UnityEngine;
using UnityEngine.Tilemaps;

[Serializable]
public class OutsideTilesInfo
{
	public OutsideTileType tileType;

	public Transform transform;

	public int numTilesX;

	public int numTilesY;

	public Tilemap tilemap;
}
