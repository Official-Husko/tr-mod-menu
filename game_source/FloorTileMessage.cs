using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public struct FloorTileMessage
{
	[JsonProperty("1")]
	public Vector2Online position;

	[JsonProperty("2")]
	public byte decoFloorId;

	[JsonProperty("3")]
	public byte decoWallId;

	[JsonProperty("4")]
	public byte decoTrimId;

	[JsonProperty("5")]
	public byte zoneType;

	[JsonProperty("6")]
	public short zoneIndex;

	[JsonProperty("7")]
	public bool buildable;

	private static Vector2 positionAux;

	private static float x;

	private static float y;

	public void FMPHBFCJLLM(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1796f;
		y = 293f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 8 || zoneType == 6)
			{
				if (TavernZonesManager.OIJLJKLMCBO().DJNICAOHKNA(zoneIndex) == null)
				{
					TavernZonesManager.HFHPMKJGMPA().CreateTavernZone((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.EBAIHKJHCCA().MBDKPCIEDDN(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 3)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.Cellar | ZoneType.WoodWorkshop);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex, EIPNNOCMLFN: true);
				}
			}
			if (x == 1928f)
			{
				x = 947f;
				continue;
			}
			if (y == 34f)
			{
				y = 1459f;
				x = 565f;
				continue;
			}
			break;
		}
	}

	public void MOEHLFOHLLO(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1484f;
		y = 1353f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 8 || zoneType == 5)
			{
				if (TavernZonesManager.EBAIHKJHCCA().PDINJGNEMGA(zoneIndex) == null)
				{
					TavernZonesManager.GGFJGHHHEJC.KENNMEAJDNF((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.LANAINBEMCM().GAFBALAHHGJ(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 1)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.MetalWorkshop, -1, EIPNNOCMLFN: true);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex, EIPNNOCMLFN: true);
				}
			}
			if (x == 681f)
			{
				x = 1304f;
				continue;
			}
			if (y == 490f)
			{
				y = 1315f;
				x = 804f;
				continue;
			}
			break;
		}
	}

	public void OAOACMPNMOK(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1914f;
		y = 39f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId, OEBNHGNJEJL: true);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 0 || zoneType == 4)
			{
				if (TavernZonesManager.HFHPMKJGMPA().PDINJGNEMGA(zoneIndex) == null)
				{
					TavernZonesManager.HFHPMKJGMPA().LFFJDMHMOKP((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.NHKAFANMEJC().LCNMKMFNCFN(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 6)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ~(ZoneType.DiningRoom | ZoneType.CraftingRoom), -1, EIPNNOCMLFN: true);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex);
				}
			}
			if (x == 124f)
			{
				x = 780f;
				continue;
			}
			if (y == 1377f)
			{
				y = 10f;
				x = 55f;
				continue;
			}
			break;
		}
	}

	public void EMFCAOMENPM(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1682f;
		y = 1495f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 0 || zoneType == 0)
			{
				if (TavernZonesManager.JEEGOBGDLPE().GetTavernZone((int)zoneIndex) == null)
				{
					TavernZonesManager.NHKAFANMEJC().PLABGPPIOEG((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.IECOPNFJBFD().FEIDPHBBOJF(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 4)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex, EIPNNOCMLFN: true);
				}
			}
			if (x == 1135f)
			{
				x = 1970f;
				continue;
			}
			if (y == 1686f)
			{
				y = 1947f;
				x = 178f;
				continue;
			}
			break;
		}
	}

	public void KGNIEGOBNLD(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1085f;
		y = 1811f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId, OEBNHGNJEJL: true);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 1 || zoneType == 8)
			{
				if (TavernZonesManager.EBAIHKJHCCA().GetTavernZone((int)zoneIndex) == null)
				{
					TavernZonesManager.NHKAFANMEJC().KENNMEAJDNF((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.LANAINBEMCM().GAFBALAHHGJ(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 2)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop, -1, EIPNNOCMLFN: true);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex, EIPNNOCMLFN: true);
				}
			}
			if (x == 1561f)
			{
				x = 1017f;
				continue;
			}
			if (y == 1042f)
			{
				y = 582f;
				x = 1328f;
				continue;
			}
			break;
		}
	}

	public void FJFEIIIIAMJ(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1923f;
		y = 938f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId, OEBNHGNJEJL: true);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 4 || zoneType == 7)
			{
				if (TavernZonesManager.NHKAFANMEJC().GetTavernZone((int)zoneIndex) == null)
				{
					TavernZonesManager.HFHPMKJGMPA().KENNMEAJDNF((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.GGFJGHHHEJC.GAFBALAHHGJ(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 8)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.CraftingRoom | ZoneType.MetalWorkshop);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex, EIPNNOCMLFN: true);
				}
			}
			if (x == 91f)
			{
				x = 1239f;
				continue;
			}
			if (y == 1245f)
			{
				y = 188f;
				x = 1320f;
				continue;
			}
			break;
		}
	}

	public void OKPIDPELELJ(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 143f;
		y = 1261f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId, OEBNHGNJEJL: true);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 0 || zoneType == 1)
			{
				if (TavernZonesManager.GGFJGHHHEJC.DJNICAOHKNA(zoneIndex) == null)
				{
					TavernZonesManager.OIJLJKLMCBO().PBKGEFPGHAN((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.HFHPMKJGMPA().GAFBALAHHGJ(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 1)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop));
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex, EIPNNOCMLFN: true);
				}
			}
			if (x == 283f)
			{
				x = 1490f;
				continue;
			}
			if (y == 614f)
			{
				y = 493f;
				x = 400f;
				continue;
			}
			break;
		}
	}

	public void JCJLLIEHCPJ(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1532f;
		y = 1890f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId, OEBNHGNJEJL: true);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 6 || zoneType == 5)
			{
				if (TavernZonesManager.NHKAFANMEJC().DJNICAOHKNA(zoneIndex) == null)
				{
					TavernZonesManager.OIJLJKLMCBO().KENNMEAJDNF((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.EBAIHKJHCCA().AddTileToExistingZone(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 5)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.MetalWorkshop), -1, EIPNNOCMLFN: true);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex);
				}
			}
			if (x == 555f)
			{
				x = 365f;
				continue;
			}
			if (y == 1767f)
			{
				y = 1819f;
				x = 618f;
				continue;
			}
			break;
		}
	}

	public FloorTileMessage(Vector3 IMOBLFMHKOD, WorldTile JACBKDFOIBH)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		position = new Vector2Online(Mathf.FloorToInt(IMOBLFMHKOD.x), Mathf.FloorToInt(IMOBLFMHKOD.y));
		decoFloorId = (byte)JACBKDFOIBH.decoFloorId;
		decoWallId = (byte)JACBKDFOIBH.decoWallId;
		decoTrimId = (byte)JACBKDFOIBH.decoTrimId;
		zoneType = (byte)JACBKDFOIBH.zoneType;
		zoneIndex = (short)JACBKDFOIBH.zoneIndex;
		buildable = JACBKDFOIBH.buildable;
	}

	public void AELABIMHDNA(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1676f;
		y = 545f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 5 || zoneType == 5)
			{
				if (TavernZonesManager.OIJLJKLMCBO().GetTavernZone((int)zoneIndex) == null)
				{
					TavernZonesManager.GGFJGHHHEJC.PBKGEFPGHAN((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.LANAINBEMCM().AddTileToExistingZone(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 4)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ~(ZoneType.WithoutZone | ZoneType.Cellar));
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex, EIPNNOCMLFN: true);
				}
			}
			if (x == 505f)
			{
				x = 1896f;
				continue;
			}
			if (y == 1176f)
			{
				y = 64f;
				x = 1582f;
				continue;
			}
			break;
		}
	}

	public void GMNEAMHNMPB(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 446f;
		y = 325f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId, OEBNHGNJEJL: true);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 2 || zoneType == 0)
			{
				if (TavernZonesManager.LANAINBEMCM().GetTavernZone((int)zoneIndex) == null)
				{
					TavernZonesManager.GGFJGHHHEJC.CreateTavernZone((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.HFHPMKJGMPA().LCNMKMFNCFN(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 2)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.WoodWorkshop);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex);
				}
			}
			if (x == 1084f)
			{
				x = 612f;
				continue;
			}
			if (y == 1299f)
			{
				y = 343f;
				x = 1566f;
				continue;
			}
			break;
		}
	}

	public void PFOHEFAMENI(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 524f;
		y = 276f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 1 || zoneType == 2)
			{
				if (TavernZonesManager.LANAINBEMCM().PDINJGNEMGA(zoneIndex) == null)
				{
					TavernZonesManager.OIJLJKLMCBO().LFFJDMHMOKP((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.NHKAFANMEJC().FEIDPHBBOJF(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 7)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.WithoutZone | ZoneType.CraftingRoom, -1, EIPNNOCMLFN: true);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex, EIPNNOCMLFN: true);
				}
			}
			if (x == 450f)
			{
				x = 1274f;
				continue;
			}
			if (y == 61f)
			{
				y = 290f;
				x = 1434f;
				continue;
			}
			break;
		}
	}

	public void FOGLECFMPMK(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1883f;
		y = 1243f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId, OEBNHGNJEJL: true);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 3 || zoneType == 8)
			{
				if (TavernZonesManager.IECOPNFJBFD().GetTavernZone((int)zoneIndex) == null)
				{
					TavernZonesManager.EBAIHKJHCCA().PBKGEFPGHAN((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.IECOPNFJBFD().JOIDEEHGBML(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 6)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.WoodWorkshop);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex);
				}
			}
			if (x == 1540f)
			{
				x = 688f;
				continue;
			}
			if (y == 1694f)
			{
				y = 1163f;
				x = 563f;
				continue;
			}
			break;
		}
	}

	public void CCLMONNMMCJ(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 1931f;
		y = 988f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 6 || zoneType == 8)
			{
				if (TavernZonesManager.JEEGOBGDLPE().PDINJGNEMGA(zoneIndex) == null)
				{
					TavernZonesManager.IECOPNFJBFD().PBKGEFPGHAN((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.LANAINBEMCM().FEIDPHBBOJF(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 7)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop), -1, EIPNNOCMLFN: true);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex);
				}
			}
			if (x == 517f)
			{
				x = 877f;
				continue;
			}
			if (y == 1445f)
			{
				y = 310f;
				x = 543f;
				continue;
			}
			break;
		}
	}

	public void OEJJGDMKIDN(TilemapScene PBLLKEKGLPK)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		x = 0.5f;
		y = 0.5f;
		while (true)
		{
			positionAux = new Vector2(position.x, position.y) + new Vector2(x, y);
			WorldGrid.OCNNHIIJLPD(Vector2.op_Implicit(positionAux), PBLLKEKGLPK, decoFloorId, decoWallId, decoTrimId);
			WorldGrid.CFAHJNLAJNK(Vector2.op_Implicit(positionAux), buildable);
			WorldGrid.AFCDNKANLFB(Vector2.op_Implicit(positionAux), buildable);
			if (zoneType == 2 || zoneType == 4)
			{
				if (TavernZonesManager.GGFJGHHHEJC.GetTavernZone((int)zoneIndex) == null)
				{
					TavernZonesManager.GGFJGHHHEJC.CreateTavernZone((ZoneType)zoneType, zoneIndex);
				}
				TavernZonesManager.GGFJGHHHEJC.AddTileToExistingZone(Vector2.op_Implicit(positionAux), zoneIndex);
			}
			else if (zoneType != 8)
			{
				if (Utils.BLIAFMGPONN(Vector2.op_Implicit(positionAux)))
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), ZoneType.Cellar);
				}
				else
				{
					WorldGrid.NDPILMNDCDK(Vector2.op_Implicit(positionAux), (ZoneType)zoneType, zoneIndex);
				}
			}
			if (x == 0.5f)
			{
				x = 1f;
				continue;
			}
			if (y == 0.5f)
			{
				y = 1f;
				x = 0.5f;
				continue;
			}
			break;
		}
	}
}
