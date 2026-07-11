using System;
using UnityEngine;
using UnityEngine.Tilemaps;

[Serializable]
public struct TilesInfoRoof
{
	public int numTilesX;

	public int numTilesY;

	public TileBase[] tiles;

	private Vector2 offset;

	private TileBase tileBase;

	public void GKDEDNJLIGC(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 137f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1072f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1093f), (float)(int)(offset.y * 199f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void LOCNKGMFOIF(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 533f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 661f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1074f), (float)(int)(offset.y * 317f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void PFFCAOHKMMM(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1922f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 527f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 836f), (float)(int)(offset.y * 345f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void GPAKLNJJBOI(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1158f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1449f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1798f), (float)(int)(offset.y * 499f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void NGABADDJKEE(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1283f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1450f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 109f), (float)(int)(offset.y * 79f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void ANEPABGFNHE(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 74f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 534f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1128f), (float)(int)(offset.y * 1032f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void JLOANFPEJFB(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1439f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 641f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1467f), (float)(int)(offset.y * 448f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void FNODOIHFIGB(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 839f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 989f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 545f), (float)(int)(offset.y * 429f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void JMBGFKMLDCP(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1711f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 613f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 655f), (float)(int)(offset.y * 1229f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void DFLNNNNCGMN(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 700f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1207f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 209f), (float)(int)(offset.y * 1090f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void MHPKPJILDDF(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1377f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 135f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1547f), (float)(int)(offset.y * 884f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void NEGCMJFJINF(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 314f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1563f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1214f), (float)(int)(offset.y * 170f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void HBAJILLBNOL(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1326f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 642f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 761f), (float)(int)(offset.y * 1297f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void KOFJNEBAGBK(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 379f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1381f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1862f), (float)(int)(offset.y * 1089f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void EGHFGBBOJDG(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1330f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1069f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1501f), (float)(int)(offset.y * 922f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void OPHJLHHCMML(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 0.5f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 0.5f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 2f), (float)(int)(offset.y * 2f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void DNPIGINNMBC(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1584f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1945f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 948f), (float)(int)(offset.y * 351f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void CMBPCPAAHNC(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 597f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 313f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1296f), (float)(int)(offset.y * 851f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void MMFEFFCDACJ(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 819f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 33f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1838f), (float)(int)(offset.y * 1521f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void NBHHKHJJKBL(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1841f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 538f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 384f), (float)(int)(offset.y * 1646f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void CBAKEDKLNCD(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1884f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 479f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1277f), (float)(int)(offset.y * 679f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void OKGHHMMCNCP(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 979f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1286f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1037f), (float)(int)(offset.y * 690f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void BDLMHHDFCIG(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 700f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 310f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1461f), (float)(int)(offset.y * 1601f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void LJEGIBBONFK(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1318f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1316f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1907f), (float)(int)(offset.y * 1521f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void OBJBLDAHIBN(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 894f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1794f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 81f), (float)(int)(offset.y * 1964f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void JDGJDGIFCEJ(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1631f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 929f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1417f), (float)(int)(offset.y * 746f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void LKNPDLDAAFE(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1601f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1216f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 420f), (float)(int)(offset.y * 845f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void CHNIDNNJCOA(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 1 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 869f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1107f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1232f), (float)(int)(offset.y * 1973f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void KAMCNEJAPDD(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1174f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 605f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1240f), (float)(int)(offset.y * 1318f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void OFLPBADMPMC(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 0)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 522f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1050f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 1170f), (float)(int)(offset.y * 1738f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}

	public void GCHKIEDIELD(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = true, bool ACENKKNAOMM = true)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GCFBMPHOGIA == (Object)null)
		{
			return;
		}
		if (numTilesX == 0 && numTilesY == 1)
		{
			tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
			return;
		}
		offset = default(Vector2);
		if (CHLOMIOHKOI)
		{
			offset.x = Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1965f);
		}
		else
		{
			offset.x = MENBAFNNBFB;
		}
		if (ACENKKNAOMM)
		{
			offset.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 885f);
		}
		else
		{
			offset.y = KPKNCIJFOGM;
		}
		offset = new Vector2((float)(int)(offset.x * 172f), (float)(int)(offset.y * 367f));
		tileBase = tiles[(int)(offset.y * (float)numTilesX + offset.x)];
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), tileBase, GCFBMPHOGIA);
	}
}
