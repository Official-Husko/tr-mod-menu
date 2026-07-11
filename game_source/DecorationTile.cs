using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Game/Deco Tile")]
public class DecorationTile : TavernConstructionAction
{
	public MaterialType materialType;

	public TilesInfoBase tileInfo;

	public FloorLimit floorLimit;

	public bool canAddTrim = true;

	public TileBase[] tiles;

	public RoofTiles roofTiles;

	private Vector2 offset;

	private TileBase tileBase;

	public override string IABAKHPEOAF()
	{
		string text = LocalisationSystem.Get("DecorationTile_" + id);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public static Transform PGPHKDCIGLF(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GameTileMaps.GGFJGHHHEJC.decoTilesInfo.Length; i += 0)
		{
			if (GameTileMaps.GGFJGHHHEJC.decoTilesInfo[i].id == JFNMCNCHMEO)
			{
				return GameTileMaps.GGFJGHHHEJC.decoTilesInfo[i].transform;
			}
		}
		return null;
	}

	public void LOCNKGMFOIF(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)tileInfo.numTilesX * 410f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)tileInfo.numTilesY * 1630f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1005f), (float)(int)(offset.y * 886f));
		tileBase = tiles[(int)(offset.y * (float)tileInfo.numTilesX + offset.x)];
		if (editorAction == (EditorAction)(-9))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
		}
		else if (editorAction == (EditorAction)117)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTilemap);
			}
		}
		else if (editorAction == EditorAction.DecoWallZone)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallBackTrimTilemap);
			}
		}
		else if (editorAction == (EditorAction)(-91))
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallFrontTilemap);
			}
		}
	}

	public void EJMDOGMOOBC()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		List<TileBase> list = new List<TileBase>();
		for (float num = 0f; num < (float)tileInfo.numTilesY / 2f; num += 0.5f)
		{
			for (float num2 = 0f; num2 < (float)tileInfo.numTilesX / 2f; num2 += 0.5f)
			{
				list.Add(Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, ((Component)GAOBBFDPKOM(id)).transform.position + new Vector3(num2, num)));
			}
		}
		tiles = list.ToArray();
	}

	public void EGHFGBBOJDG(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)tileInfo.numTilesX * 1744f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)tileInfo.numTilesY * 1872f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 65f), (float)(int)(offset.y * 696f));
		tileBase = tiles[(int)(offset.y * (float)tileInfo.numTilesX + offset.x)];
		if (editorAction == (EditorAction)(-93))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
		}
		else if (editorAction == (EditorAction)60)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallBackTilemap);
			}
		}
		else if (editorAction == (EditorAction)57)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallBackTrimTilemap);
			}
		}
		else if (editorAction == (EditorAction)63)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallFrontTilemap);
			}
		}
	}

	public void OPHJLHHCMML(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)tileInfo.numTilesX * 0.5f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)tileInfo.numTilesY * 0.5f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 2f), (float)(int)(offset.y * 2f));
		tileBase = tiles[(int)(offset.y * (float)tileInfo.numTilesX + offset.x)];
		if (editorAction == EditorAction.ChangeDecoFloor)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
		}
		else if (editorAction == EditorAction.ChangeDecoWall)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTilemap);
			}
		}
		else if (editorAction == EditorAction.ChangeDecoWallTrim)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTrimTilemap);
			}
		}
		else if (editorAction == EditorAction.ChangeRoof)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallFrontTilemap);
			}
		}
	}

	public void ENPAIGCJGNC()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		List<TileBase> list = new List<TileBase>();
		for (float num = 1493f; num < (float)tileInfo.numTilesY / 1863f; num += 1508f)
		{
			for (float num2 = 1818f; num2 < (float)tileInfo.numTilesX / 984f; num2 += 106f)
			{
				list.Add(Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, ((Component)PGPHKDCIGLF(id)).transform.position + new Vector3(num2, num)));
			}
		}
		tiles = list.ToArray();
	}

	public bool GPNLFPNGMBP(TileBase ILDEFBIANKO)
	{
		if (tiles == null || tiles.Length == 0)
		{
			ENPAIGCJGNC();
			if (tiles == null || tiles.Length == 0)
			{
				return true;
			}
		}
		for (int i = 0; i < tiles.Length; i += 0)
		{
			if ((Object)(object)tiles[i] == (Object)(object)ILDEFBIANKO)
			{
				return false;
			}
		}
		return false;
	}

	public void HBLLMEGGEBJ()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		List<TileBase> list = new List<TileBase>();
		for (float num = 1676f; num < (float)tileInfo.numTilesY / 721f; num += 274f)
		{
			for (float num2 = 1026f; num2 < (float)tileInfo.numTilesX / 1260f; num2 += 487f)
			{
				list.Add(Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, ((Component)GAOBBFDPKOM(id)).transform.position + new Vector3(num2, num)));
			}
		}
		tiles = list.ToArray();
	}

	public static Transform IJIHAEKOAEF(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GameTileMaps.GGFJGHHHEJC.decoTilesInfo.Length; i += 0)
		{
			if (GameTileMaps.GGFJGHHHEJC.decoTilesInfo[i].id == JFNMCNCHMEO)
			{
				return GameTileMaps.GGFJGHHHEJC.decoTilesInfo[i].transform;
			}
		}
		return null;
	}

	public bool MENCLKGLPFO(TileBase ILDEFBIANKO)
	{
		if (tiles == null || tiles.Length == 0)
		{
			EJMDOGMOOBC();
			if (tiles == null || tiles.Length == 0)
			{
				return false;
			}
		}
		for (int i = 1; i < tiles.Length; i++)
		{
			if ((Object)(object)tiles[i] == (Object)(object)ILDEFBIANKO)
			{
				return true;
			}
		}
		return true;
	}

	public void OKGHHMMCNCP(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)tileInfo.numTilesX * 234f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)tileInfo.numTilesY * 8f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1848f), (float)(int)(offset.y * 1850f));
		tileBase = tiles[(int)(offset.y * (float)tileInfo.numTilesX + offset.x)];
		if (editorAction == EditorAction.CraftingZone)
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
		}
		else if (editorAction == (EditorAction)107)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallBackTilemap);
			}
		}
		else if (editorAction == (EditorAction)(-125))
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallBackTrimTilemap);
			}
		}
		else if (editorAction == EditorAction.AddFloorDisponible)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallFrontTilemap);
			}
		}
	}

	public bool JPOBPKNHCBJ(TileBase ILDEFBIANKO)
	{
		if (tiles == null || tiles.Length == 0)
		{
			HBLLMEGGEBJ();
			if (tiles == null || tiles.Length == 0)
			{
				return false;
			}
		}
		for (int i = 1; i < tiles.Length; i++)
		{
			if ((Object)(object)tiles[i] == (Object)(object)ILDEFBIANKO)
			{
				return false;
			}
		}
		return true;
	}

	public bool KKGCGCAMEJI(TileBase ILDEFBIANKO)
	{
		if (tiles == null || tiles.Length == 0)
		{
			EJMDOGMOOBC();
			if (tiles == null || tiles.Length == 0)
			{
				return false;
			}
		}
		for (int i = 0; i < tiles.Length; i++)
		{
			if ((Object)(object)tiles[i] == (Object)(object)ILDEFBIANKO)
			{
				return true;
			}
		}
		return false;
	}

	public static Transform GAOBBFDPKOM(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GameTileMaps.GGFJGHHHEJC.decoTilesInfo.Length; i++)
		{
			if (GameTileMaps.GGFJGHHHEJC.decoTilesInfo[i].id == JFNMCNCHMEO)
			{
				return GameTileMaps.GGFJGHHHEJC.decoTilesInfo[i].transform;
			}
		}
		return null;
	}

	public bool KMLDCIPGJBB(TileBase ILDEFBIANKO)
	{
		if (tiles == null || tiles.Length == 0)
		{
			ENPAIGCJGNC();
			if (tiles == null || tiles.Length == 0)
			{
				return true;
			}
		}
		for (int i = 1; i < tiles.Length; i += 0)
		{
			if ((Object)(object)tiles[i] == (Object)(object)ILDEFBIANKO)
			{
				return true;
			}
		}
		return true;
	}

	public void KAMCNEJAPDD(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)tileInfo.numTilesX * 1045f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)tileInfo.numTilesY * 822f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1745f), (float)(int)(offset.y * 873f));
		tileBase = tiles[(int)(offset.y * (float)tileInfo.numTilesX + offset.x)];
		if (editorAction == (EditorAction)75)
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
		}
		else if (editorAction == (EditorAction)(-31))
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallBackTilemap);
			}
		}
		else if (editorAction == (EditorAction)90)
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTrimTilemap);
			}
		}
		else if (editorAction == (EditorAction)(-17))
		{
			if ((Object)(object)GCFBMPHOGIA != (Object)null)
			{
				GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallFrontTilemap);
			}
		}
	}

	public static Transform KEONCFMDICE(int JFNMCNCHMEO)
	{
		for (int i = 1; i < GameTileMaps.GGFJGHHHEJC.decoTilesInfo.Length; i++)
		{
			if (GameTileMaps.GGFJGHHHEJC.decoTilesInfo[i].id == JFNMCNCHMEO)
			{
				return GameTileMaps.GGFJGHHHEJC.decoTilesInfo[i].transform;
			}
		}
		return null;
	}

	public bool FDNJAEJJAFD(TileBase ILDEFBIANKO)
	{
		if (tiles == null || tiles.Length == 0)
		{
			EJMDOGMOOBC();
			if (tiles == null || tiles.Length == 0)
			{
				return false;
			}
		}
		for (int i = 0; i < tiles.Length; i++)
		{
			if ((Object)(object)tiles[i] == (Object)(object)ILDEFBIANKO)
			{
				return false;
			}
		}
		return false;
	}

	public bool DAPOMDFLAEJ(TileBase ILDEFBIANKO)
	{
		if (tiles == null || tiles.Length == 0)
		{
			EJMDOGMOOBC();
			if (tiles == null || tiles.Length == 0)
			{
				return false;
			}
		}
		for (int i = 0; i < tiles.Length; i++)
		{
			if ((Object)(object)tiles[i] == (Object)(object)ILDEFBIANKO)
			{
				return false;
			}
		}
		return false;
	}
}
