using UnityEngine;
using UnityEngine.Tilemaps;

public class FunctionalTile : Tile
{
	public Sprite tileSprite;

	public bool buildable;

	public bool canPlaceObjects;

	public bool wall;

	public int layer;

	public bool isPath;

	public bool isHorsePath;

	public bool wooded;

	public bool farmable;

	public override void GetTileData(Vector3Int BAIMHDBJPDK, ITilemap OKKHNHELKJB, ref TileData GMKBGCFCGFL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Tile)this).GetTileData(BAIMHDBJPDK, OKKHNHELKJB, ref GMKBGCFCGFL);
		((TileData)(ref GMKBGCFCGFL)).sprite = tileSprite;
		((TileData)(ref GMKBGCFCGFL)).colliderType = (ColliderType)1;
	}
}
