using System;
using UnityEngine.Tilemaps;

[Serializable]
public class WallTilemaps
{
	public Tilemap wallBackTilemap;

	public Tilemap wallFrontTilemap;

	public Tilemap wallFrontNoColliders;

	public Tilemap blackTilesTilemap;

	public Tilemap wallBackTrimTilemap;

	public Tilemap wallBackEdges;

	public Tilemap wallBackDetail;

	public Tilemap floorUpperDetail;

	public Tilemap[] buildingTileMaps;
}
