using UnityEngine;
using UnityEngine.Tilemaps;

public class ZoneTile : Tile
{
	public Sprite tileSprite;

	public ZoneType zoneType;

	public int id;

	public override void GetTileData(Vector3Int BAIMHDBJPDK, ITilemap OKKHNHELKJB, ref TileData GMKBGCFCGFL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Tile)this).GetTileData(BAIMHDBJPDK, OKKHNHELKJB, ref GMKBGCFCGFL);
		((TileData)(ref GMKBGCFCGFL)).sprite = tileSprite;
		((TileData)(ref GMKBGCFCGFL)).colliderType = (ColliderType)1;
	}
}
