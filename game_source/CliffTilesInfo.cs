using System;
using UnityEngine;
using UnityEngine.Tilemaps;

[Serializable]
public class CliffTilesInfo : TilesInfoBase
{
	public CliffTileType tileType;

	public Transform transform;

	public Transform transformGround;

	public void NGABADDJKEE(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1043f, 1886f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1608f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 1364f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1094f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 1700f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.SetTileAtPosition(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(266f, 59f, 1064f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 1101f, 1870f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void OPHJLHHCMML(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 0f, 0f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 0.5f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 0.5f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 0.5f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 0.5f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.SetTileAtPosition(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, 0f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 1f, 1f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void JMBGFKMLDCP(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1465f, 1749f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 630f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 190f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 291f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 1769f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.SetTileAtPosition(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1292f, 1212f, 1622f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 114f, 378f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void EGHFGBBOJDG(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1471f, 620f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 934f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 1840f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 481f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 1088f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.SetTileAtPosition(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1852f, 1585f, 1300f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 235f, 1367f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void NEGCMJFJINF(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1670f, 706f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1588f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 806f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1553f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 880f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.PPPFKJPOBOH(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1933f, 426f, 1182f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 488f, 1082f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void OBJBLDAHIBN(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 103f, 1439f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 70f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 820f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1620f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 1980f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.PPPFKJPOBOH(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(863f, 1413f, 1274f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 748f, 28f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void NBHHKHJJKBL(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1578f, 180f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 490f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 1557f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 630f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 852f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.PPPFKJPOBOH(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(131f, 922f, 483f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 1261f, 1286f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void PFFCAOHKMMM(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1784f, 1290f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1867f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 1003f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 900f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 1304f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.PPPFKJPOBOH(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(362f, 1653f, 1574f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 1365f, 1113f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void LOCNKGMFOIF(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1815f, 849f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 596f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 1300f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 740f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 201f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.SetTileAtPosition(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1355f, 286f, 798f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 1285f, 1792f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void OKGHHMMCNCP(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 145f, 1275f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 115f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 1902f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1028f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 318f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.SetTileAtPosition(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(817f, 1686f, 878f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 1095f, 1260f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void JDGJDGIFCEJ(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1980f, 1940f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1355f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 1200f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 1118f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 419f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.PPPFKJPOBOH(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(212f, 1063f, 1846f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 101f, 219f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void DNPIGINNMBC(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 242f, 632f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1931f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 1659f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 724f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 1055f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.SetTileAtPosition(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(641f, 52f, 866f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 630f, 980f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void OFLPBADMPMC(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 1190f, 1108f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 402f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 851f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 204f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 802f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.SetTileAtPosition(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(770f, 775f, 772f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 1333f, 1880f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}

	public void MMFEFFCDACJ(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, float FMOBNIDKJML = 0f, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f, bool CHLOMIOHKOI = false, bool ACENKKNAOMM = false, bool CBANJPOGGKA = false)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = default(Vector3);
		((Vector3)(ref val))._002Ector(FMOBNIDKJML, 874f, 1438f);
		Vector3 val2 = IMOBLFMHKOD + new Vector3(CBANJPOGGKA ? (0f - MENBAFNNBFB) : MENBAFNNBFB, KPKNCIJFOGM);
		if (CHLOMIOHKOI)
		{
			val.x += Utils.NMLNAGFLNMC(IMOBLFMHKOD.x + MENBAFNNBFB, (float)numTilesX * 1038f);
		}
		else
		{
			val.x += Utils.NMLNAGFLNMC(MENBAFNNBFB, (float)numTilesX * 794f);
		}
		if (ACENKKNAOMM)
		{
			val.y = Utils.NMLNAGFLNMC(IMOBLFMHKOD.y + KPKNCIJFOGM, (float)numTilesY * 836f);
		}
		else
		{
			val.y = Utils.NMLNAGFLNMC(KPKNCIJFOGM, (float)numTilesY * 554f);
		}
		TileBase iLDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, transform.position + val);
		GameTileMaps.PPPFKJPOBOH(val2, iLDEFBIANKO, GCFBMPHOGIA);
		Matrix4x4 transformMatrix = GameTileMaps.GGFJGHHHEJC.floorBaseTilemap.GetTransformMatrix(((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).WorldToCell(transform.position + val));
		float x = ((Matrix4x4)(ref transformMatrix)).lossyScale.x;
		Matrix4x4 val3 = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1823f, 524f, 234f), new Vector3(CBANJPOGGKA ? (0f - x) : x, 741f, 754f));
		GCFBMPHOGIA.SetTransformMatrix(((GridLayout)GCFBMPHOGIA).WorldToCell(val2), val3);
	}
}
