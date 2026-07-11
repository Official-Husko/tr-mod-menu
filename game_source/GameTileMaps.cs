using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameTileMaps : SerializedMonoBehaviour
{
	[Serializable]
	public struct TerrainTiles
	{
		public TileBase grassTile;

		public TileBase darkGrassTile;

		public TileBase darkGrass2Tile;

		public TileBase grassCliffsTile;

		public TileBase groundTile;

		public TileBase darkGroundTile;

		public TileBase groundCliffsTile;

		public DecorationTile grassFilled;

		public DecorationTile grassCliffsFilled;

		public DecorationTile darkGrassFilled;

		public DecorationTile darkGrass2Filled;

		public DecorationTile groundFilled;

		public DecorationTile darkGroundFilled;

		public DecorationTile groundCliffsFilled;
	}

	private static GameTileMaps IADEMLIIDPC;

	[Space(10f)]
	public float nodesColliderX = 0.14f;

	[Space(10f)]
	public float nodesColliderY = 0.07f;

	[Space(10f)]
	public DetailTilesInfo[] detailTilesInfo;

	[Space(10f)]
	public DecoTilesSprites[] decoTilesInfo;

	[Space(10f)]
	public CliffTilesInfo[] waterCliffsTilesInfo;

	[Space(10f)]
	public CliffTilesInfo[] waterTilesInfo;

	[Space(10f)]
	public SeasonTilesInfo[] seasonTilesInfo;

	public Tilemap floorBaseTilemap;

	public Tilemap dampSoilTileMap;

	public Tilemap grassDetailTilemap;

	public Tilemap grassSnowyDetailTilemap;

	public Tilemap groundDetailTilemap;

	public Tilemap groundSnowyDetailTilemap;

	public Tilemap canPlaceObjectsTilemap;

	public Tilemap barnConstructionPositionsTilemap;

	public Tilemap henHouseConstructionPositionsTilemap;

	public TileBase canPlaceObjectTile;

	public TileBase canPlaceObjectTile2;

	public TileBase notCanPlaceObjectTile;

	public TileBase canPlaceSeatTile;

	public TileBase blackTile;

	public TerrainTiles springTiles;

	public TerrainTiles summerTiles;

	public TerrainTiles autumnTiles;

	public TerrainTiles winterTiles;

	public TerrainTiles caveTiles;

	public TileBase snowTile;

	public TileBase dampSoilTile;

	public TileBase waterTile;

	public TileBase iceTile;

	public DecorationTile snowFilled;

	public TileBase diningZoneTile;

	public TileBase craftingZoneTile;

	public TileBase roomZoneTile;

	public TileBase cellarZoneTile;

	public TileBase woodWSTile;

	public TileBase stoneWSTile;

	public TileBase metalWSTile;

	public TileBase diningZoneFillTile;

	public TileBase craftingZoneFillTile;

	public TileBase roomZoneFillTile;

	public TileBase cellarZoneFillTile;

	public TileBase diningZoneIconTile;

	public TileBase rentedRoomZoneIconTile;

	public TileBase craftingZoneIconTile;

	public TileBase cellarZoneIconTile;

	public TileBase woodWSZoneIconTile;

	public TileBase stoneWSZoneIconTile;

	public TileBase metalWSZoneIconTile;

	public TileBase[] zoneIndexSprites;

	public Transform stoneDetailsPos;

	public Transform woodDetailsPos;

	public Transform leftEdgesTransform;

	public Transform rightEdgesTransform;

	private List<WorldTile> LCCIHCPJFKH = new List<WorldTile>();

	private List<Vector3> HAOAKBNJANI = new List<Vector3>();

	public HashSet<Vector3> placeablesAlreadyLoadedWorldTiles;

	public Location locationToDraw;

	public DrawGizmosType drawType;

	private WorldTile EPPFOLKFHEJ;

	private int DHOOKDCNBLL;

	private Vector3 ECJLMIPAFGP;

	private Dictionary<Vector3, int> OMGMIJHMADM;

	private static FunctionalTile GGBDADGGDMI;

	private static MaterialTile GCPEEOBHCGA;

	private static LocationTile PDNAABOOANN;

	private static Tile GJGONGLLJMH;

	private static Tile MFHOCCKPBGM;

	private static SnowInfluenceTile MBAFPLODKJD;

	private TileBase JGMPNMALELC;

	private string OOIIMEJMHPK;

	public static GameTileMaps GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<GameTileMaps>();
			}
			return IADEMLIIDPC;
		}
	}

	public Dictionary<Vector3, WorldTile> AAPNNPFLODM { get; private set; }

	private void MJAPJPNPPEM(Vector3 IMOBLFMHKOD, Direction FCGBJEIIMBC)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < 3; i++)
		{
			ECJLMIPAFGP = IMOBLFMHKOD + Utils.NGFODNCHPHB(FCGBJEIIMBC) * 339f * (float)i;
			if (!WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP) || WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				break;
			}
			if (i == 0 || i == 1)
			{
				if (OMGMIJHMADM.TryGetValue(ECJLMIPAFGP, out DHOOKDCNBLL))
				{
					OMGMIJHMADM[ECJLMIPAFGP] = DHOOKDCNBLL++;
					SetTileAtPosition(ECJLMIPAFGP, canPlaceObjectTile2, canPlaceObjectsTilemap);
				}
				else
				{
					OMGMIJHMADM.Add(ECJLMIPAFGP, 0);
					PPPFKJPOBOH(ECJLMIPAFGP, canPlaceObjectTile, canPlaceObjectsTilemap);
				}
			}
		}
	}

	public void SetDarkGrassTileAtPosition(Vector3 IMOBLFMHKOD, TilemapGroup IOKGALBEILM, Season EECEKHKAAIH, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != GroundType.Grass)
		{
			return;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.allNeighbours[i].direction != Direction.Diagonal && WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position) != GroundType.Grass)
			{
				return;
			}
		}
		SetTileAtPosition(IMOBLFMHKOD, null, IOKGALBEILM.darkGrassTilemap);
		SetTileAtPosition(IMOBLFMHKOD, GetDarkTile(GroundType.Grass, EECEKHKAAIH, PBLLKEKGLPK), IOKGALBEILM.darkGrassTilemap);
		WorldGrid.NGKOCCACPKF(IMOBLFMHKOD, GetDarkTile(GroundType.Grass, EECEKHKAAIH, PBLLKEKGLPK), GetDarkFilledTile(GroundType.Grass, EECEKHKAAIH, PBLLKEKGLPK), IOKGALBEILM.darkGrassTilemap, OHJMLAFFLII: false, PDJMAMPNCKP: false);
	}

	public void SetDetailAtPosition(Vector3 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GetDetailTilemap(GBKMNAPGIOM, EECEKHKAAIH) == (Object)null) && WorldGrid.GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			Tilemap detailTilemap = GGFJGHHHEJC.GetDetailTilemap(GBKMNAPGIOM, EECEKHKAAIH);
			detailTilemap.SetTile(((GridLayout)detailTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO.NPOMFJPAPGA(GBKMNAPGIOM, EECEKHKAAIH));
			WorldGrid.CGNOAFNBEAO(detailTilemap, ((GridLayout)detailTilemap).WorldToCell(IMOBLFMHKOD), EECEKHKAAIH);
		}
	}

	public void CDFHOPEAIPD(Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		RemoveTileAtPosition(IMOBLFMHKOD, dampSoilTileMap);
	}

	public void SetDampSoilTileAtPosition(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		SetTileAtPosition(IMOBLFMHKOD, null, dampSoilTileMap);
		SetTileAtPosition(IMOBLFMHKOD, dampSoilTile, dampSoilTileMap);
	}

	public void SetGrassTileAtPosition(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, Season EECEKHKAAIH, bool KJNDCDMJEAB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap);
		SetTileAtPosition(IMOBLFMHKOD, GetTile(GroundType.Grass, EECEKHKAAIH, KJNDCDMJEAB, PBLLKEKGLPK), PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap);
	}

	public TileBase DIGKBEHOECH(Vector3 IMOBLFMHKOD)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return floorBaseTilemap.GetTile(((GridLayout)floorBaseTilemap).WorldToCell(IMOBLFMHKOD));
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		for (int num = (int)drawType; num > 1; num /= 2)
		{
			if (num % 2 == 1)
			{
				return;
			}
		}
		if (locationToDraw != 0 && drawType != 0)
		{
			Utils.OACPIEGCCCO(drawType, locationToDraw);
		}
		if (drawType != DrawGizmosType.AlreadyCreatedWorldTiles)
		{
			return;
		}
		foreach (Vector3 placeablesAlreadyLoadedWorldTile in placeablesAlreadyLoadedWorldTiles)
		{
			Gizmos.color = new Color(1f, 0f, 1f, 0.6f);
			Gizmos.DrawSphere(placeablesAlreadyLoadedWorldTile + new Vector3(0.25f, 0.25f), 0.1f);
		}
	}

	public bool CheckIfThereIsSnow(Vector3 IMOBLFMHKOD, Tilemap[] MHNHDHILPGI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < MHNHDHILPGI.Length; i++)
		{
			TileBase val = Utils.GCGNCHFNEBJ<TileBase>(MHNHDHILPGI[i], IMOBLFMHKOD);
			if ((Object)(object)val != (Object)null)
			{
				OOIIMEJMHPK = ((Object)val).name;
			}
			else
			{
				OOIIMEJMHPK = "";
			}
			if ((Object)(object)val != (Object)null && OOIIMEJMHPK.Contains("Snow"))
			{
				return true;
			}
		}
		return false;
	}

	public void SetDetailAtPosition(Vector3 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Season EECEKHKAAIH, WorldTile PLIBNCCNNBK)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGFJGHHHEJC.GetDetailTilemap(GBKMNAPGIOM, EECEKHKAAIH) == (Object)null))
		{
			Tilemap detailTilemap = GGFJGHHHEJC.GetDetailTilemap(GBKMNAPGIOM, EECEKHKAAIH);
			detailTilemap.SetTile(((GridLayout)detailTilemap).WorldToCell(IMOBLFMHKOD), PLIBNCCNNBK.NPOMFJPAPGA(GBKMNAPGIOM, EECEKHKAAIH));
			WorldGrid.CGNOAFNBEAO(detailTilemap, ((GridLayout)detailTilemap).WorldToCell(IMOBLFMHKOD), EECEKHKAAIH);
		}
	}

	public void ICGKJHDMODN(Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		RemoveTileAtPosition(IMOBLFMHKOD, dampSoilTileMap);
	}

	public void KADEKKLDCME(Vector3 IMOBLFMHKOD, Season EECEKHKAAIH, Tilemap PNCGHGCOCPE, bool DBCGKFOBNPP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		SetTileAtPosition(IMOBLFMHKOD, null, PNCGHGCOCPE);
		PNCGHGCOCPE.SetTile(((GridLayout)PNCGHGCOCPE).WorldToCell(IMOBLFMHKOD), (TileBase)null);
		if (DBCGKFOBNPP)
		{
			RemoveDetailAtPosition(IMOBLFMHKOD, GroundType.Grass | GroundType.Ground | GroundType.TilledEarth, EECEKHKAAIH);
		}
	}

	public WorldTile CreateWorldTile(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, Season EECEKHKAAIH, bool DCHHFGLPNOF = false, bool JPLINFIKAJI = false, bool OPEEJDDDPLD = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return CreateWorldTile(IMOBLFMHKOD, ((Object)(object)PBLLKEKGLPK != (Object)null) ? PBLLKEKGLPK.location : Utils.HJPCBBGHPDA(Vector2.op_Implicit(IMOBLFMHKOD)), PBLLKEKGLPK?.commonTilemaps, PBLLKEKGLPK?.GetTilemaps(EECEKHKAAIH), PBLLKEKGLPK?.snowTilemaps, EECEKHKAAIH, DCHHFGLPNOF, JPLINFIKAJI, OPEEJDDDPLD);
	}

	public void SetSnowTileAtPosition(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		SetTileAtPosition(IMOBLFMHKOD, null, GCFBMPHOGIA);
		SetTileAtPosition(IMOBLFMHKOD, snowTile, GCFBMPHOGIA);
	}

	public void SetDarkSnowTileAtPosition(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.snowTilemaps.darkSnowTilemap);
		SetTileAtPosition(IMOBLFMHKOD, GetSeasonTiles(Season.Winter).darkGrassTile, PBLLKEKGLPK.snowTilemaps.darkSnowTilemap);
	}

	public void SetWorldTiles(Vector3 IMOBLFMHKOD, WorldTile PLIBNCCNNBK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (AAPNNPFLODM.ContainsKey(IMOBLFMHKOD))
		{
			AAPNNPFLODM[IMOBLFMHKOD] = PLIBNCCNNBK;
		}
		else
		{
			AAPNNPFLODM.Add(IMOBLFMHKOD, PLIBNCCNNBK);
		}
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		SeasonManager instance2 = SeasonManager.instance;
		instance2.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance2.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
		LoadPathNodes();
	}

	public static void SetTileAtPosition(Vector3 IMOBLFMHKOD, TileBase ILDEFBIANKO, Tilemap GCFBMPHOGIA)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		GCFBMPHOGIA.SetTile(((GridLayout)GCFBMPHOGIA).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
	}

	public void UpdateZonesVisual(Vector3 IMOBLFMHKOD, WorldTile PLIBNCCNNBK, CommonTilemaps HBJGFCEOLEB)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (HBJGFCEOLEB == null || (Object)(object)HBJGFCEOLEB.zonesTilemap == (Object)null)
		{
			return;
		}
		if (Utils.EJPFCKFEMJF(IMOBLFMHKOD))
		{
			if (PLIBNCCNNBK.location == Location.Tavern)
			{
				if (PLIBNCCNNBK.zoneType == ZoneType.DiningRoom)
				{
					SetTileAtPosition(IMOBLFMHKOD, diningZoneTile, HBJGFCEOLEB.zonesTilemap);
				}
				else if (PLIBNCCNNBK.zoneType == ZoneType.CraftingRoom)
				{
					SetTileAtPosition(IMOBLFMHKOD, craftingZoneTile, HBJGFCEOLEB.zonesTilemap);
				}
				else if (PLIBNCCNNBK.zoneType == ZoneType.RentedRoom)
				{
					SetTileAtPosition(IMOBLFMHKOD, roomZoneTile, HBJGFCEOLEB.zonesTilemap);
				}
				else if (PLIBNCCNNBK.zoneType == ZoneType.Cellar)
				{
					SetTileAtPosition(IMOBLFMHKOD, cellarZoneTile, HBJGFCEOLEB.zonesTilemap);
				}
				else if (PLIBNCCNNBK.zoneType == ZoneType.WithoutZone)
				{
					SetTileAtPosition(IMOBLFMHKOD, null, HBJGFCEOLEB.zonesTilemap);
				}
			}
			else if (PLIBNCCNNBK.zoneType == ZoneType.DiningRoom)
			{
				SetTileAtPosition(IMOBLFMHKOD, diningZoneFillTile, HBJGFCEOLEB.zonesTilemap);
			}
			else if (PLIBNCCNNBK.zoneType == ZoneType.CraftingRoom)
			{
				SetTileAtPosition(IMOBLFMHKOD, craftingZoneFillTile, HBJGFCEOLEB.zonesTilemap);
			}
			else if (PLIBNCCNNBK.zoneType == ZoneType.RentedRoom)
			{
				SetTileAtPosition(IMOBLFMHKOD, roomZoneFillTile, HBJGFCEOLEB.zonesTilemap);
			}
			else if (PLIBNCCNNBK.zoneType == ZoneType.Cellar)
			{
				SetTileAtPosition(IMOBLFMHKOD, cellarZoneFillTile, HBJGFCEOLEB.zonesTilemap);
			}
			else if (PLIBNCCNNBK.zoneType == ZoneType.WithoutZone)
			{
				SetTileAtPosition(IMOBLFMHKOD, null, HBJGFCEOLEB.zonesTilemap);
			}
		}
		else if (PLIBNCCNNBK.zoneType == ZoneType.WoodWorkshop)
		{
			SetTileAtPosition(IMOBLFMHKOD, woodWSTile, HBJGFCEOLEB.zonesTilemap);
		}
		else if (PLIBNCCNNBK.zoneType == ZoneType.StoneWorkshop)
		{
			SetTileAtPosition(IMOBLFMHKOD, stoneWSTile, HBJGFCEOLEB.zonesTilemap);
		}
		else if (PLIBNCCNNBK.zoneType == ZoneType.MetalWorkshop)
		{
			SetTileAtPosition(IMOBLFMHKOD, metalWSTile, HBJGFCEOLEB.zonesTilemap);
		}
		else if (PLIBNCCNNBK.zoneType == ZoneType.WithoutZone)
		{
			SetTileAtPosition(IMOBLFMHKOD, null, HBJGFCEOLEB.zonesTilemap);
		}
		if (!((Object)(object)HBJGFCEOLEB.zonesIndexTilemap == (Object)null))
		{
			if (PLIBNCCNNBK.zoneIndex >= 0)
			{
				SetTileAtPosition(IMOBLFMHKOD, zoneIndexSprites[PLIBNCCNNBK.zoneIndex % zoneIndexSprites.Length], HBJGFCEOLEB.zonesIndexTilemap);
			}
			else
			{
				SetTileAtPosition(IMOBLFMHKOD, null, HBJGFCEOLEB.zonesIndexTilemap);
			}
		}
	}

	public TerrainTiles GetSeasonTiles(Season EECEKHKAAIH)
	{
		return EECEKHKAAIH switch
		{
			Season.Spring => springTiles, 
			Season.Summer => summerTiles, 
			Season.Autumn => autumnTiles, 
			_ => winterTiles, 
		};
	}

	public void RemoveDampSoilTileAtPosition(Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		RemoveTileAtPosition(IMOBLFMHKOD, dampSoilTileMap);
	}

	public Tilemap GetDetailTilemap(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Winter)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return grassSnowyDetailTilemap;
			case GroundType.Ground:
				return groundSnowyDetailTilemap;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return grassDetailTilemap;
			case GroundType.Ground:
				return groundDetailTilemap;
			}
		}
		return null;
	}

	public void IBEFMAHMGNM(Vector3 IMOBLFMHKOD, TilemapGroup IOKGALBEILM, Season EECEKHKAAIH, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != 0)
		{
			return;
		}
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.allNeighbours[i].direction != Direction.Left && WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position) != GroundType.Grass)
			{
				return;
			}
		}
		PPPFKJPOBOH(IMOBLFMHKOD, null, IOKGALBEILM.darkGrassTilemap);
		SetTileAtPosition(IMOBLFMHKOD, GetDarkTile(GroundType.Grass, EECEKHKAAIH, PBLLKEKGLPK), IOKGALBEILM.darkGrassTilemap);
		WorldGrid.NGKOCCACPKF(IMOBLFMHKOD, GetDarkTile(GroundType.None, EECEKHKAAIH, PBLLKEKGLPK), GetDarkFilledTile(GroundType.None, EECEKHKAAIH, PBLLKEKGLPK), IOKGALBEILM.darkGrassTilemap, OHJMLAFFLII: false, PDJMAMPNCKP: false);
	}

	private void BKGNBKEIALB(Vector3 IMOBLFMHKOD, Direction FCGBJEIIMBC)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < 6; i++)
		{
			ECJLMIPAFGP = IMOBLFMHKOD + Utils.NGFODNCHPHB(FCGBJEIIMBC) * 0.5f * (float)i;
			if (!WorldGrid.NGDHDMAMGPI(ECJLMIPAFGP) || WorldGrid.HENDJJEEOHE(ECJLMIPAFGP))
			{
				break;
			}
			if (i == 3 || i == 5)
			{
				if (OMGMIJHMADM.TryGetValue(ECJLMIPAFGP, out DHOOKDCNBLL))
				{
					OMGMIJHMADM[ECJLMIPAFGP] = DHOOKDCNBLL++;
					SetTileAtPosition(ECJLMIPAFGP, canPlaceObjectTile2, canPlaceObjectsTilemap);
				}
				else
				{
					OMGMIJHMADM.Add(ECJLMIPAFGP, 1);
					SetTileAtPosition(ECJLMIPAFGP, canPlaceObjectTile, canPlaceObjectsTilemap);
				}
			}
		}
	}

	public void JIAJFDKNJME()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			((Component)barnConstructionPositionsTilemap).gameObject.SetActive(true);
			((Component)henHouseConstructionPositionsTilemap).gameObject.SetActive(false);
		}
	}

	public static void PPPFKJPOBOH(Vector3 IMOBLFMHKOD, TileBase ILDEFBIANKO, Tilemap GCFBMPHOGIA)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		GCFBMPHOGIA.SetTile(((GridLayout)GCFBMPHOGIA).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
	}

	public GameTileMaps()
	{
		_003CKDCNIGDIJJO_003Ek__BackingField = new Dictionary<Vector3, WorldTile>();
		placeablesAlreadyLoadedWorldTiles = new HashSet<Vector3>();
		OMGMIJHMADM = new Dictionary<Vector3, int>();
		((SerializedMonoBehaviour)this)._002Ector();
	}

	public void RemoveSnowDetailAtPosition(Vector3 IMOBLFMHKOD, Tilemap NNAILHIHAIB)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NNAILHIHAIB))
		{
			NNAILHIHAIB.SetTile(((GridLayout)NNAILHIHAIB).WorldToCell(IMOBLFMHKOD), (TileBase)null);
		}
	}

	public void SetSnowDetailAtPosition(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.hasSnow && (Object)(object)ILDEFBIANKO.PBLLKEKGLPK.snowTilemaps.snowDetailTilemap != (Object)null)
		{
			ILDEFBIANKO.PBLLKEKGLPK.snowTilemaps.snowDetailTilemap.SetTile(((GridLayout)ILDEFBIANKO.PBLLKEKGLPK.snowTilemaps.snowDetailTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO.NPAOBLGKCEE());
		}
	}

	public DecorationTile GetDarkFilledTile(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TilemapScene PBLLKEKGLPK)
	{
		if (TilemapsInfo.ELHHFNFJIAD(PBLLKEKGLPK.location) == InteriorType.Cave)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return caveTiles.darkGrassFilled;
			case GroundType.Ground:
				return caveTiles.darkGroundFilled;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return GetSeasonTiles(EECEKHKAAIH).darkGrassFilled;
			case GroundType.Ground:
				return GetSeasonTiles(EECEKHKAAIH).darkGroundFilled;
			}
		}
		return null;
	}

	public void ResetWorldTiles()
	{
		if (AAPNNPFLODM != null)
		{
			AAPNNPFLODM.Clear();
		}
		else
		{
			AAPNNPFLODM = new Dictionary<Vector3, WorldTile>();
		}
	}

	public void RemoveSnowAtPosition(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, bool DBCGKFOBNPP)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < PBLLKEKGLPK.snowTilemaps.snowTilemaps.Length; i++)
		{
			SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.snowTilemaps.snowTilemaps[i]);
		}
		if (Object.op_Implicit((Object)(object)Footsteps.instance))
		{
			Footsteps.instance.RemoveAllFootstepsWithinAWorldTile(IMOBLFMHKOD);
		}
		if (DBCGKFOBNPP && Application.isPlaying)
		{
			RemoveSnowDetailAtPosition(IMOBLFMHKOD, PBLLKEKGLPK.snowTilemaps.snowDetailTilemap);
		}
	}

	private void BFFMPJBPMPA()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		Vector3[] array = AAPNNPFLODM.Keys.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (WorldGrid.OINMGKCIGEJ(array[i], null))
			{
				WorldGrid.AAFPODGPJMP(array[i], DNMKMKDAENO: false, BBHMAKKPFKB: false);
			}
		}
	}

	private GroundType HLMEKIIADML(Location BAIMHDBJPDK, TilemapGroup IOKGALBEILM, Vector3 IMOBLFMHKOD)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		if (TilemapsInfo.ELHHFNFJIAD(BAIMHDBJPDK) == InteriorType.Building)
		{
			if (IOKGALBEILM != null)
			{
				JGMPNMALELC = Utils.GCGNCHFNEBJ<TileBase>(IOKGALBEILM.floorLowerTilemap, IMOBLFMHKOD);
				if ((Object)(object)JGMPNMALELC != (Object)null)
				{
					return GroundType.Floor;
				}
				return GroundType.None;
			}
			return GroundType.None;
		}
		JGMPNMALELC = null;
		if (IOKGALBEILM != null)
		{
			JGMPNMALELC = Utils.GCGNCHFNEBJ<TileBase>(IOKGALBEILM.floorUpperTilemap, IMOBLFMHKOD);
		}
		if ((Object)(object)JGMPNMALELC != (Object)null)
		{
			OOIIMEJMHPK = ((Object)JGMPNMALELC).name;
		}
		else
		{
			OOIIMEJMHPK = "";
		}
		if ((Object)(object)JGMPNMALELC != (Object)null && (OOIIMEJMHPK.Contains("Grass") || TilemapsInfo.ELHHFNFJIAD(BAIMHDBJPDK) == InteriorType.Cave))
		{
			return GroundType.Grass;
		}
		JGMPNMALELC = null;
		if (IOKGALBEILM != null)
		{
			JGMPNMALELC = Utils.GCGNCHFNEBJ<TileBase>(IOKGALBEILM.floorLowerTilemap, IMOBLFMHKOD);
		}
		if ((Object)(object)JGMPNMALELC != (Object)null)
		{
			OOIIMEJMHPK = ((Object)JGMPNMALELC).name;
			if (OOIIMEJMHPK.Contains("Ground") || TilemapsInfo.ELHHFNFJIAD(BAIMHDBJPDK) == InteriorType.Cave)
			{
				return GroundType.Ground;
			}
			return GroundType.Stone;
		}
		if (IOKGALBEILM != null && (Object)(object)IOKGALBEILM.sandTilemap != (Object)null)
		{
			JGMPNMALELC = Utils.GCGNCHFNEBJ<TileBase>(IOKGALBEILM.sandTilemap, IMOBLFMHKOD);
			if ((Object)(object)JGMPNMALELC != (Object)null)
			{
				return GroundType.Sand;
			}
		}
		return GroundType.None;
	}

	public void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			((Component)barnConstructionPositionsTilemap).gameObject.SetActive(false);
			((Component)henHouseConstructionPositionsTilemap).gameObject.SetActive(false);
		}
	}

	public TileBase GetFloorBaseAtPosition(Vector3 IMOBLFMHKOD)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return floorBaseTilemap.GetTile(((GridLayout)floorBaseTilemap).WorldToCell(IMOBLFMHKOD));
	}

	public void RemoveTileAtPosition(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		GCFBMPHOGIA.SetTile(((GridLayout)GCFBMPHOGIA).WorldToCell(IMOBLFMHKOD), (TileBase)null);
	}

	private void BGPGIOMKKAO()
	{
		if (!OnlineManager.ClientOnline())
		{
			WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
			WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
			WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate());
		}
	}

	private void NDJOMNNBHCP()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<Vector3, WorldTile> item in new Dictionary<Vector3, WorldTile>(AAPNNPFLODM))
		{
			if (!Utils.BKFNPIFHBDH(item.Value.location))
			{
				continue;
			}
			if (item.Value.placeables != null && item.Value.placeables.Count > 0)
			{
				if (!placeablesAlreadyLoadedWorldTiles.Contains(item.Key))
				{
					placeablesAlreadyLoadedWorldTiles.Add(item.Key);
				}
			}
			else
			{
				AAPNNPFLODM.Remove(item.Key);
			}
		}
	}

	public void RemoveDetailAtPosition(Vector3 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GetDetailTilemap(GBKMNAPGIOM, EECEKHKAAIH) == (Object)null))
		{
			Tilemap detailTilemap = GetDetailTilemap(GBKMNAPGIOM, EECEKHKAAIH);
			detailTilemap.SetTile(((GridLayout)detailTilemap).WorldToCell(IMOBLFMHKOD), (TileBase)null);
		}
	}

	public void SetDarkGroundTileAtPosition(Vector3 IMOBLFMHKOD, TilemapGroup IOKGALBEILM, Season EECEKHKAAIH, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != GroundType.Grass && WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) != GroundType.Ground)
		{
			return;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.allNeighbours[i].direction != Direction.Diagonal && WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position) == GroundType.TilledEarth)
			{
				return;
			}
		}
		SetTileAtPosition(IMOBLFMHKOD, null, IOKGALBEILM.darkGroundTilemap);
		SetTileAtPosition(IMOBLFMHKOD, GetDarkTile(GroundType.Ground, EECEKHKAAIH, PBLLKEKGLPK), IOKGALBEILM.darkGroundTilemap);
		WorldGrid.NGKOCCACPKF(IMOBLFMHKOD, GetDarkTile(GroundType.Ground, EECEKHKAAIH, PBLLKEKGLPK), GetDarkFilledTile(GroundType.Ground, EECEKHKAAIH, PBLLKEKGLPK), IOKGALBEILM.darkGroundTilemap, OHJMLAFFLII: false, PDJMAMPNCKP: false);
	}

	public TileBase GetTileZone(ZoneType GIBJPCAFCJB)
	{
		return (TileBase)(GIBJPCAFCJB switch
		{
			ZoneType.WoodWorkshop => woodWSTile, 
			ZoneType.StoneWorkshop => stoneWSTile, 
			ZoneType.MetalWorkshop => metalWSTile, 
			_ => null, 
		});
	}

	private void GMKMALEEPLB(Season EECEKHKAAIH)
	{
		if (Application.isEditor)
		{
			Debug.Log((object)("OnSeasonChanged to " + EECEKHKAAIH));
		}
		if (EECEKHKAAIH != Season.Winter)
		{
			BFFMPJBPMPA();
		}
		NDJOMNNBHCP();
	}

	private void OIBDBLCLACB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PCMJOOALNFC));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
		LoadPathNodes();
	}

	public void RemoveFloorLowerAtPosition(Vector3 IMOBLFMHKOD, Season EECEKHKAAIH, Tilemap PNCGHGCOCPE, bool DBCGKFOBNPP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		SetTileAtPosition(IMOBLFMHKOD, null, PNCGHGCOCPE);
		PNCGHGCOCPE.SetTile(((GridLayout)PNCGHGCOCPE).WorldToCell(IMOBLFMHKOD), (TileBase)null);
		if (DBCGKFOBNPP)
		{
			RemoveDetailAtPosition(IMOBLFMHKOD, GroundType.Ground, EECEKHKAAIH);
		}
	}

	public TileBase GetTile(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, bool KJNDCDMJEAB, TilemapScene PBLLKEKGLPK)
	{
		if (TilemapsInfo.ELHHFNFJIAD(PBLLKEKGLPK.location) == InteriorType.Cave)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return caveTiles.grassTile;
			case GroundType.Ground:
				return caveTiles.groundTile;
			}
		}
		else
		{
			TerrainTiles seasonTiles = GetSeasonTiles(EECEKHKAAIH);
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				if (KJNDCDMJEAB)
				{
					return seasonTiles.grassCliffsTile;
				}
				return seasonTiles.grassTile;
			case GroundType.Ground:
				if (KJNDCDMJEAB)
				{
					return seasonTiles.groundCliffsTile;
				}
				return seasonTiles.groundTile;
			}
		}
		return null;
	}

	public TileBase GetDarkTile(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TilemapScene PBLLKEKGLPK)
	{
		if ((Object)(object)PBLLKEKGLPK != (Object)null && TilemapsInfo.ELHHFNFJIAD(PBLLKEKGLPK.location) == InteriorType.Cave)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return caveTiles.darkGrassTile;
			case GroundType.Ground:
				return caveTiles.darkGroundTile;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return GetSeasonTiles(EECEKHKAAIH).darkGrassTile;
			case GroundType.Ground:
				return GetSeasonTiles(EECEKHKAAIH).darkGroundTile;
			}
		}
		return null;
	}

	public WorldTile CreateWorldTile(Vector3 IMOBLFMHKOD, Location BAIMHDBJPDK, CommonTilemaps HBJGFCEOLEB, TilemapGroup IOKGALBEILM, SnowTilemaps MHNHDHILPGI, Season EECEKHKAAIH, bool DCHHFGLPNOF = false, bool JPLINFIKAJI = false, bool OPEEJDDDPLD = false, GroundType OBEEGHMMBEC = GroundType.None)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		WorldTile worldTile = default(WorldTile);
		Vector3 val = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		if (OPEEJDDDPLD)
		{
			placeablesAlreadyLoadedWorldTiles.Remove(val);
		}
		if (HBJGFCEOLEB != null)
		{
			worldTile.location = BAIMHDBJPDK;
			GGBDADGGDMI = (DCHHFGLPNOF ? Utils.GCGNCHFNEBJ<FunctionalTile>(HBJGFCEOLEB.functionalTilemap, IMOBLFMHKOD) : null);
			GCPEEOBHCGA = (DCHHFGLPNOF ? Utils.GCGNCHFNEBJ<MaterialTile>(HBJGFCEOLEB.materialTilemap, IMOBLFMHKOD) : null);
			PDNAABOOANN = (DCHHFGLPNOF ? Utils.GCGNCHFNEBJ<LocationTile>(HBJGFCEOLEB.locationTilemap, IMOBLFMHKOD) : null);
			GJGONGLLJMH = (DCHHFGLPNOF ? Utils.GCGNCHFNEBJ<Tile>(HBJGFCEOLEB.fishingTilemap, IMOBLFMHKOD) : null);
			MFHOCCKPBGM = (DCHHFGLPNOF ? Utils.GCGNCHFNEBJ<Tile>(HBJGFCEOLEB.fishingWinterTilemap, IMOBLFMHKOD) : null);
		}
		else
		{
			worldTile.location = Utils.HJPCBBGHPDA(Vector2.op_Implicit(IMOBLFMHKOD));
			GGBDADGGDMI = null;
			GCPEEOBHCGA = null;
			PDNAABOOANN = null;
			GJGONGLLJMH = null;
			MFHOCCKPBGM = null;
		}
		if (MHNHDHILPGI != null && (Object)(object)MHNHDHILPGI.snowInfluenceTilemap != (Object)null)
		{
			MBAFPLODKJD = (DCHHFGLPNOF ? Utils.GCGNCHFNEBJ<SnowInfluenceTile>(MHNHDHILPGI.snowInfluenceTilemap, IMOBLFMHKOD) : null);
			if ((Object)(object)MBAFPLODKJD != (Object)null)
			{
				worldTile.snowProbability = MBAFPLODKJD.probability;
			}
			else
			{
				worldTile.snowProbability = 0.5f;
			}
		}
		else
		{
			worldTile.snowProbability = 0.5f;
		}
		if (MHNHDHILPGI != null)
		{
			worldTile.showDarkSnow = (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(MHNHDHILPGI.darkSnowTilemap, IMOBLFMHKOD) != (Object)null;
			worldTile.EOADIFCOMAM(Utils.GCGNCHFNEBJ<TileBase>(MHNHDHILPGI.snowDetailTilemap, IMOBLFMHKOD));
		}
		if (Object.op_Implicit((Object)(object)grassDetailTilemap))
		{
			worldTile.EMEOLBDJLMC(GroundType.Grass, Season.Spring, Utils.GCGNCHFNEBJ<TileBase>(grassDetailTilemap, IMOBLFMHKOD));
		}
		if (Object.op_Implicit((Object)(object)grassSnowyDetailTilemap))
		{
			worldTile.EMEOLBDJLMC(GroundType.Grass, Season.Winter, Utils.GCGNCHFNEBJ<TileBase>(grassSnowyDetailTilemap, IMOBLFMHKOD));
		}
		if (Object.op_Implicit((Object)(object)groundDetailTilemap))
		{
			worldTile.EMEOLBDJLMC(GroundType.Ground, Season.Spring, Utils.GCGNCHFNEBJ<TileBase>(groundDetailTilemap, IMOBLFMHKOD));
		}
		if (Object.op_Implicit((Object)(object)groundSnowyDetailTilemap))
		{
			worldTile.EMEOLBDJLMC(GroundType.Ground, Season.Winter, Utils.GCGNCHFNEBJ<TileBase>(groundSnowyDetailTilemap, IMOBLFMHKOD));
		}
		bool flag = JPLINFIKAJI && AAPNNPFLODM.ContainsKey(val);
		if (flag)
		{
			worldTile.canPlaceObjects = AAPNNPFLODM[val].canPlaceObjects;
			worldTile.blockingObjects = AAPNNPFLODM[val].blockingObjects;
			worldTile.canPlaceSeat = AAPNNPFLODM[val].canPlaceSeat;
			worldTile.tucked = AAPNNPFLODM[val].tucked;
			worldTile.placeables = AAPNNPFLODM[val].placeables;
			worldTile.herbs = AAPNNPFLODM[val].herbs;
			worldTile.decoFloorId = AAPNNPFLODM[val].decoFloorId;
			worldTile.decoWallId = AAPNNPFLODM[val].decoWallId;
			worldTile.decoTrimId = AAPNNPFLODM[val].decoTrimId;
			worldTile.door = AAPNNPFLODM[val].door;
		}
		else
		{
			if (OPEEJDDDPLD)
			{
				worldTile.placeables = AAPNNPFLODM[val].placeables;
				worldTile.canPlaceObjects = AAPNNPFLODM[val].canPlaceObjects;
			}
			else
			{
				worldTile.blockingObjects = null;
				worldTile.tucked = false;
				worldTile.placeables = null;
				worldTile.herbs = null;
				worldTile.door = null;
			}
			if ((Object)(object)GCPEEOBHCGA != (Object)null)
			{
				if ((Object)(object)PDNAABOOANN != (Object)null && PDNAABOOANN.location == Location.Tavern)
				{
					worldTile.materialType = GCPEEOBHCGA.materialType;
					worldTile.decoFloorId = GCPEEOBHCGA.FDNIGJBNNMF();
					worldTile.decoWallId = GCPEEOBHCGA.BCLCKLKGFCL();
					worldTile.decoTrimId = GCPEEOBHCGA.BIKIBFJONAO();
				}
				else
				{
					worldTile.materialType = GCPEEOBHCGA.materialType;
					worldTile.decoFloorId = Utils.FDNIGJBNNMF(IMOBLFMHKOD);
					worldTile.decoWallId = Utils.BCLCKLKGFCL(IMOBLFMHKOD);
					worldTile.decoTrimId = Utils.BIKIBFJONAO();
				}
			}
			else
			{
				worldTile.decoFloorId = Utils.FDNIGJBNNMF(IMOBLFMHKOD);
				worldTile.decoWallId = Utils.BCLCKLKGFCL(IMOBLFMHKOD);
				worldTile.decoTrimId = Utils.BIKIBFJONAO();
			}
		}
		if ((Object)(object)GGBDADGGDMI != (Object)null)
		{
			worldTile.isPath = GGBDADGGDMI.isPath;
			worldTile.isHorsePath = GGBDADGGDMI.isHorsePath;
			worldTile.buildable = GGBDADGGDMI.buildable;
			worldTile.wooded = GGBDADGGDMI.wooded;
			worldTile.farmable = GGBDADGGDMI.farmable;
			worldTile.wall = GGBDADGGDMI.wall;
			if (!flag && !OPEEJDDDPLD)
			{
				worldTile.canPlaceObjects = GGBDADGGDMI.canPlaceObjects;
			}
		}
		else if (!OPEEJDDDPLD)
		{
			worldTile.isPath = false;
			worldTile.isHorsePath = false;
			worldTile.buildable = true;
			worldTile.wooded = false;
			worldTile.farmable = false;
			worldTile.wall = false;
			worldTile.canPlaceObjects = true;
		}
		worldTile.canFishSeasons = CropSeason.None;
		if (Object.op_Implicit((Object)(object)GJGONGLLJMH))
		{
			worldTile.canFishSeasons |= CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn;
		}
		if (Object.op_Implicit((Object)(object)MFHOCCKPBGM))
		{
			worldTile.canFishSeasons |= CropSeason.Winter;
		}
		worldTile.canPlaceSeat = false;
		if ((Object)(object)GCPEEOBHCGA != (Object)null)
		{
			worldTile.groundType = GCPEEOBHCGA.groundType;
			worldTile.materialType = GCPEEOBHCGA.materialType;
		}
		else if (OBEEGHMMBEC != 0)
		{
			worldTile.groundType = OBEEGHMMBEC;
		}
		else
		{
			worldTile.groundType = HLMEKIIADML(BAIMHDBJPDK, IOKGALBEILM, IMOBLFMHKOD);
		}
		if (EECEKHKAAIH == Season.Winter && MHNHDHILPGI != null)
		{
			worldTile.hasSnow = CheckIfThereIsSnow(IMOBLFMHKOD, MHNHDHILPGI.snowTilemaps);
		}
		else
		{
			worldTile.hasSnow = false;
		}
		if ((Object)(object)PDNAABOOANN != (Object)null)
		{
			worldTile.zoneType = ZoneType.WithoutZone;
			worldTile.zoneIndex = -1;
			if (Application.isPlaying && (PDNAABOOANN.location == Location.Tavern || PDNAABOOANN.location == Location.RoomsMultiplayer) && worldTile.groundType == GroundType.Floor)
			{
				if (PDNAABOOANN.zoneType == ZoneType.DiningRoom || PDNAABOOANN.zoneType == ZoneType.CraftingRoom)
				{
					if (RoomUpgrader.GGFJGHHHEJC.upgrades[PDNAABOOANN.zoneType] == PDNAABOOANN.activationIndex)
					{
						TavernZone tavernZone = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(PDNAABOOANN.zoneIndex);
						if (tavernZone == null)
						{
							tavernZone = TavernZonesManager.GGFJGHHHEJC.CreateTavernZone(PDNAABOOANN.zoneType, PDNAABOOANN.zoneIndex);
						}
						TavernZonesManager.GGFJGHHHEJC.AddTileToExistingZone(IMOBLFMHKOD, PDNAABOOANN.zoneIndex);
						worldTile.zoneType = tavernZone.zoneType;
						worldTile.zoneIndex = tavernZone.id;
					}
				}
				else
				{
					worldTile.zoneType = PDNAABOOANN.zoneType;
				}
			}
		}
		else
		{
			worldTile.zoneType = ZoneType.WithoutZone;
			worldTile.zoneIndex = -1;
		}
		if (Application.isPlaying && HBJGFCEOLEB != null)
		{
			UpdateZonesVisual(IMOBLFMHKOD, worldTile, HBJGFCEOLEB);
		}
		if (worldTile.location == Location.Tavern && !PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val)) && (Object)(object)GGBDADGGDMI != (Object)null && !worldTile.wall)
		{
			FunctionalTile functionalTile = Utils.GCGNCHFNEBJ<FunctionalTile>(HBJGFCEOLEB.functionalTilemap, IMOBLFMHKOD - new Vector3(0.5f, 0f, 0f));
			bool num = (Object)(object)functionalTile != (Object)null && !functionalTile.wall;
			functionalTile = Utils.GCGNCHFNEBJ<FunctionalTile>(HBJGFCEOLEB.functionalTilemap, IMOBLFMHKOD - new Vector3(0f, 0.5f, 0f));
			bool flag2 = (Object)(object)functionalTile != (Object)null && !functionalTile.wall;
			functionalTile = Utils.GCGNCHFNEBJ<FunctionalTile>(HBJGFCEOLEB.functionalTilemap, IMOBLFMHKOD - new Vector3(0.5f, 0.5f, 0f));
			bool flag3 = (Object)(object)functionalTile != (Object)null && !functionalTile.wall;
			if (num && flag2 && flag3)
			{
				WorldGrid.MJDKNJPJILH(val);
			}
			Vector3 val2 = val + new Vector3(0.25f, 0.25f, 0f);
			if (!PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val2)))
			{
				WorldGrid.MJDKNJPJILH(val2);
			}
			if (flag2 && !PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + new Vector3(0.25f, 0f, 0f))))
			{
				WorldGrid.MJDKNJPJILH(val + new Vector3(0.25f, 0f, 0f));
			}
			if (num && !PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + new Vector3(0f, 0.25f, 0f))))
			{
				WorldGrid.MJDKNJPJILH(val + new Vector3(0f, 0.25f, 0f));
			}
		}
		AAPNNPFLODM[val] = worldTile;
		return worldTile;
	}

	public void ShowCanPlaceObjects(int JIIGOACEIKL, bool HGNKFFMDOOL, Placeable EAPCLAODGAE, bool DPAGEJGMCKD = false)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)canPlaceObjectsTilemap).gameObject.activeSelf != HGNKFFMDOOL)
		{
			((Component)canPlaceObjectsTilemap).gameObject.SetActive(HGNKFFMDOOL);
		}
		if (!HGNKFFMDOOL)
		{
			return;
		}
		LCCIHCPJFKH.Clear();
		HAOAKBNJANI.Clear();
		for (float num = (GameManager.LocalCoop() ? (-9) : (-15)); num < (float)(GameManager.LocalCoop() ? 9 : 15); num += 0.5f)
		{
			for (float num2 = -9f; num2 < 9f; num2 += 0.5f)
			{
				WorldGrid.GCGNCHFNEBJ(((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL)).transform.position + new Vector3(num, num2, 0f), out EPPFOLKFHEJ);
				LCCIHCPJFKH.Add(EPPFOLKFHEJ);
				HAOAKBNJANI.Add(Utils.NKGANMEKDAL(((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL)).transform.position + new Vector3(num, num2, 0f)));
			}
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Road || FarmConstructionUI.GGFJGHHHEJC.IsOpen())
		{
			for (int i = 0; i < LCCIHCPJFKH.Count; i++)
			{
				if ((!DPAGEJGMCKD && (LCCIHCPJFKH[i].groundType == GroundType.Floor || LCCIHCPJFKH[i].groundType == GroundType.Grass || LCCIHCPJFKH[i].groundType == GroundType.Ground || LCCIHCPJFKH[i].groundType == GroundType.Stone)) || (DPAGEJGMCKD && LCCIHCPJFKH[i].groundType != GroundType.TilledEarth))
				{
					if ((Object)(object)EAPCLAODGAE != (Object)null && EAPCLAODGAE.specificRules.HasFlag(SpecificType.Seat) && LCCIHCPJFKH[i].canPlaceSeat)
					{
						SetTileAtPosition(HAOAKBNJANI[i], canPlaceSeatTile, canPlaceObjectsTilemap);
					}
					else if (!LCCIHCPJFKH[i].canPlaceObjects || LCCIHCPJFKH[i].blockingObjects != null)
					{
						SetTileAtPosition(HAOAKBNJANI[i], notCanPlaceObjectTile, canPlaceObjectsTilemap);
					}
					else
					{
						SetTileAtPosition(HAOAKBNJANI[i], null, canPlaceObjectsTilemap);
					}
				}
				else
				{
					SetTileAtPosition(HAOAKBNJANI[i], null, canPlaceObjectsTilemap);
				}
			}
		}
		OMGMIJHMADM.Clear();
		if (!((Object)(object)EAPCLAODGAE != (Object)null))
		{
			return;
		}
		if ((EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1313 || EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1887 || EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1888) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern)
		{
			for (int j = 0; j < LCCIHCPJFKH.Count; j++)
			{
				if (WorldGrid.KELFJIPHBFP(HAOAKBNJANI[j]).HasFlag(SpecificType.Bar) && WorldGrid.ALNFLFCLIEP(HAOAKBNJANI[j] + new Vector3(0f, 0.5f)) && WorldGrid.KELFJIPHBFP(HAOAKBNJANI[j] + new Vector3(-1f, 0f)).HasFlag(SpecificType.Bar) && WorldGrid.KELFJIPHBFP(HAOAKBNJANI[j] + new Vector3(0.5f, 0f)).HasFlag(SpecificType.Bar) && !WorldGrid.KELFJIPHBFP(HAOAKBNJANI[j]).HasFlag(SpecificType.ServiceBarrel))
				{
					SetTileAtPosition(HAOAKBNJANI[j], canPlaceSeatTile, canPlaceObjectsTilemap);
				}
			}
		}
		else if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 660 && (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Road))
		{
			Vector3[] array = (Vector3[])(object)new Vector3[4]
			{
				Vector3.right * 0.5f,
				Vector3.left * 0.5f,
				Vector3.up * 0.5f,
				Vector3.down * 0.5f
			};
			for (int k = 0; k < LCCIHCPJFKH.Count; k++)
			{
				if (WorldGrid.OPLHBJGKKAD(HAOAKBNJANI[k]) == null)
				{
					continue;
				}
				for (int l = 0; l < WorldGrid.OPLHBJGKKAD(HAOAKBNJANI[k]).Count; l++)
				{
					if (WorldGrid.OPLHBJGKKAD(HAOAKBNJANI[k])[l].specificRules != SpecificType.Table)
					{
						continue;
					}
					Table component = ((Component)WorldGrid.OPLHBJGKKAD(HAOAKBNJANI[k])[l]).GetComponent<Table>();
					for (int m = 0; m < component.placeable.itemSpace.buildSquares.Length; m++)
					{
						for (int n = 0; n < array.Length; n++)
						{
							Vector3 iMOBLFMHKOD = component.placeable.itemSpace.buildSquares[m].GetCentrePosition() + array[n];
							if (WorldGrid.NGDHDMAMGPI(iMOBLFMHKOD))
							{
								if (n < 2 && (component.placeable.direction == Direction.Left || component.placeable.direction == Direction.Right))
								{
									SetTileAtPosition(iMOBLFMHKOD, canPlaceSeatTile, canPlaceObjectsTilemap);
								}
								else if (n >= 2 && (component.placeable.direction == Direction.Up || component.placeable.direction == Direction.Down))
								{
									SetTileAtPosition(iMOBLFMHKOD, canPlaceSeatTile, canPlaceObjectsTilemap);
								}
								else
								{
									SetTileAtPosition(iMOBLFMHKOD, notCanPlaceObjectTile, canPlaceObjectsTilemap);
								}
							}
						}
					}
				}
			}
		}
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 1175 && EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 1176 && EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != 1967)
		{
			return;
		}
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int num3 = 0; num3 < currentPlaceables.Count; num3++)
		{
			if (currentPlaceables[num3].CCIKENEGHCA)
			{
				if (currentPlaceables[num3].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1175 || currentPlaceables[num3].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1967)
				{
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[0].GetCentrePosition(), Direction.Up);
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[0].GetCentrePosition(), Direction.Down);
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[0].GetCentrePosition(), Direction.Left);
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[0].GetCentrePosition(), Direction.Right);
				}
				if (currentPlaceables[num3].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1176)
				{
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[0].GetCentrePosition(), Direction.Up);
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[0].GetCentrePosition(), Direction.Down);
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[0].GetCentrePosition(), Direction.Left);
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[currentPlaceables[num3].itemSpace.buildSquares.Length - 1].GetCentrePosition(), Direction.Up);
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[currentPlaceables[num3].itemSpace.buildSquares.Length - 1].GetCentrePosition(), Direction.Down);
					BKGNBKEIALB(currentPlaceables[num3].itemSpace.buildSquares[currentPlaceables[num3].itemSpace.buildSquares.Length - 1].GetCentrePosition(), Direction.Right);
				}
			}
		}
	}

	public void SetGroundTileAtPosition(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, Season EECEKHKAAIH, bool KJNDCDMJEAB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap);
		SetTileAtPosition(IMOBLFMHKOD, GetTile(GroundType.Ground, EECEKHKAAIH, KJNDCDMJEAB, PBLLKEKGLPK), PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap);
	}

	private void BEAFKILJENJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		Vector3[] array = AAPNNPFLODM.Keys.ToArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			if (WorldGrid.OINMGKCIGEJ(array[i], null))
			{
				WorldGrid.AAFPODGPJMP(array[i], DNMKMKDAENO: false, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
	}

	public static void LoadPathNodes()
	{
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			if (value != Location.Tavern && value != Location.Anywhere && value != 0 && value != Location.BarnInterior)
			{
				PathNodesScriptableObject pathNodesData = PathNodesManager.GetPathNodesData(value);
				if ((Object)(object)pathNodesData != (Object)null)
				{
					pathNodesData.OEJJGDMKIDN();
				}
			}
		}
		for (int i = 0; i < 3; i++)
		{
			PathNodesScriptableObject pathNodesData = PathNodesManager.GetPathNodesData(Location.BarnInterior, i);
			if ((Object)(object)pathNodesData != (Object)null)
			{
				pathNodesData.OEJJGDMKIDN();
			}
		}
	}

	private void PCMJOOALNFC()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.Tavern));
			WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
			WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.None), Utils.JGEPCPFJANP(Location.None).CIOLICLDNLA());
		}
	}

	public void ShowZones(bool NKFPJPCFBJI)
	{
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.GGFJGHHHEJC.allTilemapsScenes)
		{
			if (!((Object)(object)allTilemapsScene.Value.commonTilemaps.zonesTilemap == (Object)null) && ((Component)allTilemapsScene.Value.commonTilemaps.zonesTilemap).gameObject.activeSelf != NKFPJPCFBJI)
			{
				((Component)allTilemapsScene.Value.commonTilemaps.zonesTilemap).gameObject.SetActive(NKFPJPCFBJI);
			}
		}
	}

	public static void SetTileAtPosition(Vector3Int AIJOOOIJEDC, TileBase ILDEFBIANKO, Tilemap GCFBMPHOGIA)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		GCFBMPHOGIA.SetTile(AIJOOOIJEDC, ILDEFBIANKO);
	}

	public void RemoveFloorUpperAtPosition(Vector3 IMOBLFMHKOD, Season EECEKHKAAIH, Tilemap IAEFMAMJAEJ, bool DBCGKFOBNPP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		SetTileAtPosition(IMOBLFMHKOD, null, IAEFMAMJAEJ);
		if (DBCGKFOBNPP)
		{
			RemoveDetailAtPosition(IMOBLFMHKOD, GroundType.Grass, EECEKHKAAIH);
		}
	}
}
