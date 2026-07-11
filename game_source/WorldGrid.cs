using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public static class WorldGrid
{
	public struct Movement
	{
		public Vector3 position;

		public Direction direction;

		public Movement(Vector3 IMOBLFMHKOD, Direction FCGBJEIIMBC)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			position = IMOBLFMHKOD;
			direction = FCGBJEIIMBC;
		}
	}

	public struct TableNeighbours
	{
		public List<Vector3> surrounded;

		public List<Vector3> expanded;

		public TableNeighbours(List<Vector3> BFPHJGGIECM, List<Vector3> NBEMBCKMBIK)
		{
			surrounded = BFPHJGGIECM;
			expanded = NBEMBCKMBIK;
		}
	}

	public static readonly Movement[] allMovementNeighbours = new Movement[8]
	{
		new Movement(new Vector3(0.25f, 0f, 0f), Direction.Right),
		new Movement(new Vector3(-0.25f, 0f, 0f), Direction.Left),
		new Movement(new Vector3(0f, 0.25f, 0f), Direction.Up),
		new Movement(new Vector3(0f, -0.25f, 0f), Direction.Down),
		new Movement(new Vector3(0.25f, -0.25f), Direction.Diagonal),
		new Movement(new Vector3(0.25f, 0.25f), Direction.Diagonal),
		new Movement(new Vector3(-0.25f, -0.25f), Direction.Diagonal),
		new Movement(new Vector3(-0.25f, 0.25f), Direction.Diagonal)
	};

	public static readonly Movement[] allNeighbours = new Movement[8]
	{
		new Movement(new Vector3(0.5f, 0f, 0f), Direction.Right),
		new Movement(new Vector3(-0.5f, 0f, 0f), Direction.Left),
		new Movement(new Vector3(0f, 0.5f, 0f), Direction.Up),
		new Movement(new Vector3(0f, -0.5f, 0f), Direction.Down),
		new Movement(new Vector3(0.5f, -0.5f), Direction.Diagonal),
		new Movement(new Vector3(0.5f, 0.5f), Direction.Diagonal),
		new Movement(new Vector3(-0.5f, -0.5f), Direction.Diagonal),
		new Movement(new Vector3(-0.5f, 0.5f), Direction.Diagonal)
	};

	public static readonly Vector3[] allNeighboursDistance2 = (Vector3[])(object)new Vector3[16]
	{
		new Vector3(1f, 0f, 0f),
		new Vector3(-1f, 0f, 0f),
		new Vector3(0f, 1f, 0f),
		new Vector3(0f, -1f, 0f),
		new Vector3(1f, -1f),
		new Vector3(1f, 1f),
		new Vector3(-1f, -1f),
		new Vector3(-1f, 1f),
		new Vector3(1f, -0.5f),
		new Vector3(1f, 0.5f),
		new Vector3(-1f, -0.5f),
		new Vector3(-1f, 0.5f),
		new Vector3(0.5f, -1f),
		new Vector3(0.5f, 1f),
		new Vector3(-0.5f, -1f),
		new Vector3(-0.5f, 1f)
	};

	public static readonly Vector3[] FiveSquaresWide = (Vector3[])(object)new Vector3[25]
	{
		new Vector3(0f, 0f, 0f),
		new Vector3(0f, -0.5f, 0f),
		new Vector3(0f, 0.5f, 0f),
		new Vector3(0f, -1f, 0f),
		new Vector3(0f, 1f, 0f),
		new Vector3(0.5f, 0f),
		new Vector3(0.5f, -0.5f),
		new Vector3(0.5f, 0.5f),
		new Vector3(0.5f, -1f),
		new Vector3(0.5f, 1f),
		new Vector3(-0.5f, 0f),
		new Vector3(-0.5f, -0.5f),
		new Vector3(-0.5f, 0.5f),
		new Vector3(-0.5f, -1f),
		new Vector3(-0.5f, 1f),
		new Vector3(1f, 0f),
		new Vector3(1f, -0.5f),
		new Vector3(1f, 0.5f),
		new Vector3(-1f, 0f),
		new Vector3(-1f, -0.5f),
		new Vector3(-1f, 0.5f),
		new Vector3(1f, -1f),
		new Vector3(1f, 1f),
		new Vector3(-1f, -1f),
		new Vector3(-1f, 1f)
	};

	public static readonly NeighbourAndDirection[] allNeighbourAndDirections = new NeighbourAndDirection[8]
	{
		new NeighbourAndDirection(new Vector2(0.5f, 0f), NeighbourDirection.Right),
		new NeighbourAndDirection(new Vector2(-0.5f, 0f), NeighbourDirection.Left),
		new NeighbourAndDirection(new Vector2(0f, 0.5f), NeighbourDirection.Up),
		new NeighbourAndDirection(new Vector2(0f, -0.5f), NeighbourDirection.Down),
		new NeighbourAndDirection(new Vector2(0.5f, -0.5f), NeighbourDirection.Diagonal),
		new NeighbourAndDirection(new Vector2(0.5f, 0.5f), NeighbourDirection.Diagonal),
		new NeighbourAndDirection(new Vector2(-0.5f, -0.5f), NeighbourDirection.Diagonal),
		new NeighbourAndDirection(new Vector2(-0.5f, 0.5f), NeighbourDirection.Diagonal)
	};

	public static readonly Vector3[] allMovementNodesInTile = (Vector3[])(object)new Vector3[9]
	{
		new Vector3(0f, 0f, 0f),
		new Vector3(0.5f, 0f, 0f),
		new Vector3(0.5f, 0.5f, 0f),
		new Vector3(0f, 0.5f, 0f),
		new Vector3(0f, 0.25f, 0f),
		new Vector3(0.25f, 0.25f, 0f),
		new Vector3(0.25f, 0f, 0f),
		new Vector3(0.25f, 0.5f, 0f),
		new Vector3(0.5f, 0.25f, 0f)
	};

	private static readonly NeighbourAndDirection[] FHHMDAEFDIM = new NeighbourAndDirection[8]
	{
		new NeighbourAndDirection(new Vector2(-0.5f, 0f), NeighbourDirection.Left),
		new NeighbourAndDirection(new Vector2(0.5f, 0f), NeighbourDirection.Right),
		new NeighbourAndDirection(new Vector2(0f, -0.5f), NeighbourDirection.Down),
		new NeighbourAndDirection(new Vector2(0f, 0.5f), NeighbourDirection.Up),
		new NeighbourAndDirection(new Vector2(-0.5f, -0.5f), NeighbourDirection.Diagonal),
		new NeighbourAndDirection(new Vector2(-0.5f, 0.5f), NeighbourDirection.Diagonal),
		new NeighbourAndDirection(new Vector2(0.5f, -0.5f), NeighbourDirection.Diagonal),
		new NeighbourAndDirection(new Vector2(0.5f, 0.5f), NeighbourDirection.Diagonal)
	};

	public static readonly Vector3[] movementNodeDiagonals = (Vector3[])(object)new Vector3[4]
	{
		new Vector3(0.25f, 0.25f),
		new Vector3(0.25f, -0.25f),
		new Vector3(-0.25f, 0.25f),
		new Vector3(-0.25f, -0.25f)
	};

	public static readonly Vector3[] allGridPositionsSurroundingNode = (Vector3[])(object)new Vector3[4]
	{
		new Vector3(0f, 0f),
		new Vector3(-0.5f, 0f),
		new Vector3(0f, -0.5f),
		new Vector3(-0.5f, -0.5f)
	};

	private static string OOIIMEJMHPK;

	private static bool FLDDFKCAIGD;

	private static bool DLDMMAHGLHB;

	private static bool IALHJANIGBN;

	private static bool CMJMHHIAACM;

	private static bool GHHLMAGAGOF;

	private static bool AKLNMKGKBPE;

	private static bool EFEABAPKBBP;

	private static bool KLGNJFKEPKK;

	private static bool GIOOPOKIEOP;

	private static bool LJCEFANKHBK;

	private static bool DCAODGJFCLF;

	private static DecorationTile MIMAGPFCMKH;

	private static DecorationTile IGDJMAEMCLK;

	private static bool AIJDIJKOEDE;

	private static bool IBCAAJIJPOB;

	private static Door GBNOFPBPHDC;

	private static Location LFLLIMPGPGF;

	private static TilemapScene GFOHLCCLIAM;

	private static WorldTile EIEGDCACDAL;

	private static Dictionary<Location, Coroutine> PKOHNPPGCEA = new Dictionary<Location, Coroutine>();

	private static Vector3 AAFJOAPNNBA;

	private static TileBase OBPOFPDBFFD;

	private static WorldTile FDILHKBNLGC;

	private static WorldTile BKJGMAIMMKD;

	private static WorldTile GDNAJLJNMDB;

	private static WorldTile FNPLODPLEMC;

	private static WorldTile CEPGPKAHGPK;

	private static SpecificType EKKIMEKAPHB;

	private static List<Placeable> EDBDDLMNNAC;

	private static WorldTile FLNFKNEGBOB;

	private static CommonTilemaps MINKCADCPBP;

	private static TilemapGroup JDPIMJBKFOB;

	private static Coroutine ILPCCJHHPKF = null;

	private static HashSet<Vector3> CPAECKJKLIP = new HashSet<Vector3>();

	private static PathNode AGKAMKDOPCG;

	private static Vector2 IAEOEEAEAKE;

	private static Vector2 LNLPPNLFODB;

	private static Placeable[] KCJIMDFEBBL;

	private static List<Collider2D> JGJLNAPPKDJ;

	private static WorldTile DMIAKBIBBPD;

	private static WorldTile LHGMAFHGAMK;

	private static Vector2 AHPIAIHJJMJ;

	private static bool OLADKFEBMPH;

	private static float BDKCDBALPJH;

	private static float ACMOGJCLELA;

	private static Vector2 NOLFMLNLJJG;

	private static Vector2 AJLJHLHGGBD;

	private static List<Vector2> OCOCKJEJDNM = new List<Vector2>();

	private static TileBase ILDEFBIANKO;

	private static bool AHMDLJCHABI;

	private static Matrix4x4 JFPMJHHLHCI;

	private static WorldTile DFDLNIHFKPA;

	public static TableNeighbours JOJDBJAIJMA(Placeable EAPCLAODGAE)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		List<NeighbourAndDirection> list = HAGAEBPFJBG(EAPCLAODGAE.itemSpace.buildSquares.Select((BuildSquare bs) => bs.GetCentrePosition()));
		HashSet<Vector3> hashSet = new HashSet<Vector3>();
		HashSet<Vector3> hashSet2 = new HashSet<Vector3>();
		foreach (NeighbourAndDirection item in list)
		{
			if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(item.position), out var value) && value.isFree)
			{
				hashSet.Add(item.position);
			}
			Vector3 val = Vector3.zero;
			Vector3 val2 = Vector3.zero;
			if (item.direction == NeighbourDirection.Right)
			{
				val = item.position + new Vector3(0.25f, 0.25f);
				val2 = item.position + new Vector3(0.25f, -0.25f);
			}
			else if (item.direction == NeighbourDirection.Left)
			{
				val = item.position + new Vector3(-0.25f, 0.25f);
				val2 = item.position + new Vector3(-0.25f, -0.25f);
			}
			else if (item.direction == NeighbourDirection.Up)
			{
				val = item.position + new Vector3(0.25f, 0.25f);
				val2 = item.position + new Vector3(-0.25f, 0.25f);
			}
			else if (item.direction == NeighbourDirection.Down)
			{
				val = item.position + new Vector3(-0.25f, -0.25f);
				val2 = item.position + new Vector3(0.25f, -0.25f);
			}
			if (item.direction != NeighbourDirection.Diagonal && PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(val), out value) && value.isFree)
			{
				hashSet2.Add(val);
			}
			if (item.direction != NeighbourDirection.Diagonal && PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(val2), out value) && value.isFree)
			{
				hashSet2.Add(val2);
			}
		}
		return new TableNeighbours(hashSet.ToList(), hashSet2.ToList());
	}

	public static void CPDBMDJIHGG(TilemapScene PBLLKEKGLPK, Vector3Int[] GEIFPPHMBFI = null)
	{
		if (!((Object)(object)GameplayUI.GGFJGHHHEJC == (Object)null) && !PKOHNPPGCEA.ContainsKey(PBLLKEKGLPK.location))
		{
			PKOHNPPGCEA.Add(PBLLKEKGLPK.location, ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(PJBJDJKJJMH(PBLLKEKGLPK, GEIFPPHMBFI)));
		}
	}

	public static void DKEHENLDNAG()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		if ((Object)(object)tilemapScene == (Object)null)
		{
			return;
		}
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (NCEHFMPBBAK(val) == GroundType.Floor)
			{
				MJDKNJPJILH(val, (Vector3[])(object)new Vector3[1]
				{
					new Vector3(0.25f, 0.25f)
				});
				bool flag = EJCEAEPNJCA(val + new Vector3(-0.5f, 0f));
				bool flag2 = EJCEAEPNJCA(val + new Vector3(0f, -0.5f));
				bool flag3 = EJCEAEPNJCA(val + new Vector3(-0.5f, -0.5f));
				if (flag2 && flag && flag3)
				{
					MJDKNJPJILH(val);
				}
				if (flag)
				{
					MJDKNJPJILH(val, (Vector3[])(object)new Vector3[1]
					{
						new Vector3(0f, 0.25f)
					});
				}
				if (flag2)
				{
					MJDKNJPJILH(val, (Vector3[])(object)new Vector3[1]
					{
						new Vector3(0.25f, 0f)
					});
				}
			}
		}
	}

	private static void KGJOKDAJFMN(Vector3 IMOBLFMHKOD, WorldTile PLIBNCCNNBK)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		for (int num = PLIBNCCNNBK.placeables.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)PLIBNCCNNBK.placeables[num] == (Object)null)
			{
				PLIBNCCNNBK.placeables.RemoveAt(num);
			}
		}
		if (PLIBNCCNNBK.placeables.Count == 0)
		{
			PLIBNCCNNBK.placeables = null;
			KILADDNLCOM(PLIBNCCNNBK, IMOBLFMHKOD);
		}
	}

	public static Door IPNJBJEMDKF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.door is Door)
			{
				return ILDEFBIANKO.door as Door;
			}
			return null;
		}
		return null;
	}

	public static CliffTilesInfo DMDBDKKNHDN(CliffTileType FPFLJNACICI)
	{
		for (int i = 0; i < GameTileMaps.GGFJGHHHEJC.waterTilesInfo.Length; i++)
		{
			if (GameTileMaps.GGFJGHHHEJC.waterTilesInfo[i].tileType == FPFLJNACICI)
			{
				return GameTileMaps.GGFJGHHHEJC.waterTilesInfo[i];
			}
		}
		return null;
	}

	public static bool KFAJFPKAOOK(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
			{
				return ILDEFBIANKO.showDarkSnow;
			}
			return false;
		}
		return (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.snowTilemaps.darkSnowTilemap, IMOBLFMHKOD) != (Object)null;
	}

	public static bool CPKKNEMJGIB(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			GroundType groundType = NCEHFMPBBAK(IMOBLFMHKOD);
			if (groundType == GroundType.Ground || groundType == GroundType.Grass)
			{
				TilemapGroup tilemaps = ILDEFBIANKO.PBLLKEKGLPK.GetTilemaps(SeasonManager.EECEKHKAAIH);
				switch (groundType)
				{
				case GroundType.Ground:
					return (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.darkGroundTilemap, IMOBLFMHKOD) != (Object)null;
				case GroundType.Grass:
					if (!((Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.darkGrassTilemap, IMOBLFMHKOD) != (Object)null))
					{
						return (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.darkGrass2Tilemap, IMOBLFMHKOD) != (Object)null;
					}
					return true;
				}
			}
		}
		return false;
	}

	public static CliffTilesInfo OFBGFPJLIGC(CliffTileType FPFLJNACICI)
	{
		for (int i = 0; i < GameTileMaps.GGFJGHHHEJC.waterTilesInfo.Length; i++)
		{
			if (GameTileMaps.GGFJGHHHEJC.waterCliffsTilesInfo[i].tileType == FPFLJNACICI)
			{
				return GameTileMaps.GGFJGHHHEJC.waterCliffsTilesInfo[i];
			}
		}
		return null;
	}

	public static bool LLCOKBFJJLJ(Vector3 IMOBLFMHKOD, bool JGDOHPCLJPM = false)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			if (GJHHDIJOILG(IMOBLFMHKOD + allNeighbours[i].position, JGDOHPCLJPM))
			{
				return true;
			}
		}
		return false;
	}

	public static Sitable HPDNKENHLNM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out BKJGMAIMMKD) && BKJGMAIMMKD.placeables != null && BKJGMAIMMKD.placeables.Count > 0)
		{
			for (int i = 0; i < BKJGMAIMMKD.placeables.Count; i++)
			{
				if (BKJGMAIMMKD.placeables[i].onlinePlaceable is OnlineSitable onlineSitable)
				{
					return onlineSitable.sitable;
				}
			}
		}
		return null;
	}

	public static void ANGGDPPNGKH(TilemapScene PBLLKEKGLPK, Vector3Int[] GEIFPPHMBFI)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (GEIFPPHMBFI == null)
		{
			GEIFPPHMBFI = PBLLKEKGLPK.GetAllPositionsToCalculate();
		}
		foreach (Vector3Int val in GEIFPPHMBFI)
		{
			if (PBLLKEKGLPK.wallTilemaps.wallBackTilemap.HasTile(val) && GCGNCHFNEBJ(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTilemap).CellToWorld(val), out var ILDEFBIANKO))
			{
				ILDEFBIANKO.wall = false;
				if (ILDEFBIANKO.groundType != GroundType.Floor)
				{
					ILDEFBIANKO.canPlaceObjects = false;
				}
			}
		}
		for (int j = 0; j < PBLLKEKGLPK.wallTilemaps.buildingTileMaps.Length; j++)
		{
			PBLLKEKGLPK.wallTilemaps.buildingTileMaps[j].ClearAllTiles();
		}
		if (Application.isPlaying)
		{
			RentedRoomsManager.UpdateAllRoomVisibilities();
		}
	}

	public static void PMLHOCINDCF(Vector3 IMOBLFMHKOD, IrrigatorType KNMNIKPHKCF)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.irrigator = KNMNIKPHKCF;
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		}
	}

	public static void PDBCPANBFDK()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (NCEHFMPBBAK(val) == GroundType.Floor)
			{
				for (int j = 0; j < allMovementNodesInTile.Length; j++)
				{
					HJOINEHJAHO(val + allMovementNodesInTile[j]);
				}
			}
		}
	}

	public static void GDJFGIPMBAH(List<Vector2> HAEIAGKNEPC, bool CIGOMGBFJGF = true, bool IAPJDPFPNOA = true)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		HKCBAGIACCJ(HAEIAGKNEPC);
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			TavernZonesManager.GGFJGHHHEJC.RemoveTileFromZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			if (IAPJDPFPNOA)
			{
				AIHNKKFLMCM(Vector2.op_Implicit(HAEIAGKNEPC[i]), LHLHJCDKNHA: false, CIGOMGBFJGF);
			}
			NDPILMNDCDK(Vector2.op_Implicit(HAEIAGKNEPC[i]), ZoneType.WithoutZone);
			MMOHADHAAGD(Vector2.op_Implicit(HAEIAGKNEPC[i]), GroundType.None, Location.Tavern);
			FADHHLHFGGL(Vector2.op_Implicit(HAEIAGKNEPC[i]), allMovementNodesInTile);
			FloorLimitsManager.UpdateFloorLimits(Vector2.op_Implicit(HAEIAGKNEPC[i]), Utils.JGEPCPFJANP(Location.Tavern));
		}
	}

	public static bool NGDDNLHKAPM(Vector3 IMOBLFMHKOD)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM != null)
		{
			IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
			return GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.ContainsKey(IMOBLFMHKOD);
		}
		return false;
	}

	public static void AAFPODGPJMP(Vector3 IMOBLFMHKOD, bool DNMKMKDAENO, bool BBHMAKKPFKB = true, bool CDPAMNIPPEC = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out DMIAKBIBBPD))
		{
			DMIAKBIBBPD.hasSnow = DNMKMKDAENO;
			KILADDNLCOM(DMIAKBIBBPD, IMOBLFMHKOD);
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineWorldTilesManager.instance.SendHasSnow(Vector2.op_Implicit(IMOBLFMHKOD), DNMKMKDAENO);
			}
			if (BBHMAKKPFKB)
			{
				ONHDGOJOHAH(DMIAKBIBBPD, IMOBLFMHKOD, DMIAKBIBBPD.PBLLKEKGLPK, DMIAKBIBBPD.PBLLKEKGLPK.snowTilemaps.snowTilemaps);
				IDGJPDBGHPB(DMIAKBIBBPD, IMOBLFMHKOD);
			}
		}
	}

	public static void EBCPKHKLPCC(TilemapGroup IOKGALBEILM, Vector3 IMOBLFMHKOD)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (IOKGALBEILM.cliffsTilemap.HasTile(((GridLayout)IOKGALBEILM.cliffsTilemap).WorldToCell(IMOBLFMHKOD)) && Object.op_Implicit((Object)(object)IOKGALBEILM.grassAbove))
		{
			Tile val = new Tile();
			TileBase val2 = Utils.GCGNCHFNEBJ<TileBase>(IOKGALBEILM.floorUpperTilemap, IMOBLFMHKOD);
			RuleTile val3 = (RuleTile)(object)((val2 is RuleTile) ? val2 : null);
			if (val3 != null)
			{
				val.sprite = val3.GetCurrentSprite(IOKGALBEILM.floorUpperTilemap, ((GridLayout)IOKGALBEILM.floorUpperTilemap).WorldToCell(IMOBLFMHKOD));
			}
			else
			{
				val = (Tile)(object)((val2 is Tile) ? val2 : null);
			}
			IOKGALBEILM.grassAbove.SetTile(((GridLayout)IOKGALBEILM.cliffsTilemap).WorldToCell(IMOBLFMHKOD), (TileBase)(object)val);
		}
	}

	private static void IDGJPDBGHPB(WorldTile ILDEFBIANKO, Vector3 IMOBLFMHKOD)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)ILDEFBIANKO.PBLLKEKGLPK == (Object)null || (Object)(object)ILDEFBIANKO.PBLLKEKGLPK.snowTilemaps.darkSnowTilemap == (Object)null || !Application.isPlaying)
		{
			return;
		}
		if (ILDEFBIANKO.hasSnow && ILDEFBIANKO.showDarkSnow)
		{
			APEFAENFMML(IMOBLFMHKOD, ILDEFBIANKO.PBLLKEKGLPK);
		}
		else
		{
			GameTileMaps.GGFJGHHHEJC.RemoveTileAtPosition(IMOBLFMHKOD, ILDEFBIANKO.PBLLKEKGLPK.snowTilemaps.darkSnowTilemap);
		}
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			if (OINMGKCIGEJ(IMOBLFMHKOD + allNeighbours[i].position, ILDEFBIANKO.PBLLKEKGLPK.snowTilemaps.snowTilemaps) && KFAJFPKAOOK(IMOBLFMHKOD + allNeighbours[i].position, ILDEFBIANKO.PBLLKEKGLPK))
			{
				APEFAENFMML(IMOBLFMHKOD + allNeighbours[i].position, ILDEFBIANKO.PBLLKEKGLPK);
			}
		}
		for (int j = 0; j < allNeighboursDistance2.Length; j++)
		{
			if (OINMGKCIGEJ(IMOBLFMHKOD + allNeighboursDistance2[j], ILDEFBIANKO.PBLLKEKGLPK.snowTilemaps.snowTilemaps) && KFAJFPKAOOK(IMOBLFMHKOD + allNeighboursDistance2[j], ILDEFBIANKO.PBLLKEKGLPK))
			{
				APEFAENFMML(IMOBLFMHKOD + allNeighboursDistance2[j], ILDEFBIANKO.PBLLKEKGLPK);
			}
		}
	}

	public static GroundType NCEHFMPBBAK(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.groundType;
		}
		return GroundType.None;
	}

	public static void NGKOCCACPKF(Vector3 IMOBLFMHKOD, TileBase LLDKNGNEIDD, DecorationTile BGCOHNIBBMB, Tilemap GCFBMPHOGIA, bool OHJMLAFFLII, bool PDJMAMPNCKP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		JDIBBOGBLEJ(IMOBLFMHKOD, LLDKNGNEIDD, BGCOHNIBBMB, GCFBMPHOGIA, PDJMAMPNCKP);
		if (OHJMLAFFLII)
		{
			for (int i = 0; i < allNeighbours.Length; i++)
			{
				if (allNeighbours[i].direction != Direction.Diagonal)
				{
					OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD + allNeighbours[i].position);
					if ((Object)(object)OBPOFPDBFFD != (Object)null)
					{
						GameTileMaps.GGFJGHHHEJC.RemoveTileAtPosition(IMOBLFMHKOD + allNeighbours[i].position, GCFBMPHOGIA);
						NGKOCCACPKF(IMOBLFMHKOD + allNeighbours[i].position, LLDKNGNEIDD, BGCOHNIBBMB, GCFBMPHOGIA, OHJMLAFFLII: false, PDJMAMPNCKP: true);
					}
				}
			}
			for (int j = 0; j < allNeighbours.Length; j++)
			{
				if (allNeighbours[j].direction == Direction.Diagonal)
				{
					JDIBBOGBLEJ(IMOBLFMHKOD + allNeighbours[j].position, LLDKNGNEIDD, BGCOHNIBBMB, GCFBMPHOGIA, PDJMAMPNCKP);
				}
			}
		}
		else
		{
			for (int k = 0; k < allNeighbours.Length; k++)
			{
				JDIBBOGBLEJ(IMOBLFMHKOD + allNeighbours[k].position, LLDKNGNEIDD, BGCOHNIBBMB, GCFBMPHOGIA, PDJMAMPNCKP);
			}
		}
	}

	private static void CDEMLICOFOH(Vector3 IMOBLFMHKOD, Season EECEKHKAAIH, TilemapScene PBLLKEKGLPK, bool DBCGKFOBNPP = true)
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap == (Object)null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			for (int i = 0; i < allNeighbours.Length; i++)
			{
				if (NCEHFMPBBAK(IMOBLFMHKOD + allNeighbours[i].position) != GroundType.Ground && NCEHFMPBBAK(IMOBLFMHKOD + allNeighbours[i].position) != GroundType.Grass && ((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap == (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap, IMOBLFMHKOD + allNeighbours[i].position) == (Object)null))
				{
					OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap, IMOBLFMHKOD);
					if ((Object)(object)OBPOFPDBFFD != (Object)null)
					{
						OOIIMEJMHPK = ((Object)OBPOFPDBFFD).name;
					}
					else
					{
						OOIIMEJMHPK = "";
					}
					GameTileMaps.GGFJGHHHEJC.SetGroundTileAtPosition(IMOBLFMHKOD, PBLLKEKGLPK, EECEKHKAAIH, (Object)(object)OBPOFPDBFFD != (Object)null && OOIIMEJMHPK.Contains("Cliffs"));
					if (DBCGKFOBNPP)
					{
						GameTileMaps.GGFJGHHHEJC.RemoveDetailAtPosition(IMOBLFMHKOD, GroundType.Ground, EECEKHKAAIH);
					}
					CKDDIGCJANA(IMOBLFMHKOD);
					return;
				}
			}
		}
		else
		{
			for (int j = 0; j < allNeighbours.Length; j++)
			{
				TileBase val = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap, IMOBLFMHKOD + allNeighbours[j].position);
				if ((Object)(object)val != (Object)null)
				{
					OOIIMEJMHPK = ((Object)val).name;
				}
				else
				{
					OOIIMEJMHPK = "";
				}
				if ((Object)(object)val == (Object)null || !OOIIMEJMHPK.Contains("Ground"))
				{
					if ((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap != (Object)null)
					{
						val = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap, IMOBLFMHKOD + allNeighbours[j].position);
					}
					if ((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap == (Object)null || (Object)(object)val == (Object)null)
					{
						val = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap, IMOBLFMHKOD);
						GameTileMaps.GGFJGHHHEJC.SetGroundTileAtPosition(IMOBLFMHKOD, PBLLKEKGLPK, EECEKHKAAIH, !((Object)(object)val == (Object)null) && ((Object)val).name.ToLower().Contains("cliffs"));
						return;
					}
				}
			}
		}
		OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap, IMOBLFMHKOD);
		if (TilemapsInfo.ELHHFNFJIAD(PBLLKEKGLPK.location) == InteriorType.Cave)
		{
			GameTileMaps.GGFJGHHHEJC.caveTiles.groundFilled.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap);
		}
		else if ((Object)(object)OBPOFPDBFFD == (Object)null)
		{
			GameTileMaps.GGFJGHHHEJC.GetSeasonTiles(EECEKHKAAIH).groundFilled.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap);
		}
		else
		{
			OOIIMEJMHPK = ((Object)OBPOFPDBFFD).name;
			if (OOIIMEJMHPK.Contains("GroundCliffs"))
			{
				GameTileMaps.GGFJGHHHEJC.GetSeasonTiles(EECEKHKAAIH).groundCliffsFilled.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.GetSeasonTiles(EECEKHKAAIH).groundFilled.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap);
			}
		}
		if (DBCGKFOBNPP)
		{
			GameTileMaps.GGFJGHHHEJC.SetDetailAtPosition(IMOBLFMHKOD, GroundType.Ground, EECEKHKAAIH);
		}
	}

	public static void DLFFCGLGDLL(Vector3 OFIIBHBOPJI, ref Neighbour[] FIFABPOJMAF, bool GLNLCLJJJEG)
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		PathNode value;
		if (GLNLCLJJJEG)
		{
			if (FIFABPOJMAF.Length < allMovementNeighbours.Length)
			{
				Debug.LogError((object)("Neighbours smaller!: " + FIFABPOJMAF.Length + ". AllMovement: " + allMovementNeighbours.Length));
			}
			for (int i = 0; i < allMovementNeighbours.Length; i++)
			{
				Vector3 val = OFIIBHBOPJI + allMovementNeighbours[i].position;
				if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(val), out value))
				{
					if (Object.op_Implicit((Object)(object)value.animalNPC))
					{
						FIFABPOJMAF[i].free = true;
						FIFABPOJMAF[i].cost = 1.3f;
					}
					else
					{
						FIFABPOJMAF[i].free = value.isFree;
						FIFABPOJMAF[i].cost = value.cost;
					}
					FIFABPOJMAF[i].position = Vector2.op_Implicit(val);
				}
				else
				{
					FIFABPOJMAF[i].free = false;
					FIFABPOJMAF[i].cost = 1f;
				}
				FIFABPOJMAF[i].direction = allMovementNeighbours[i].direction;
			}
		}
		else
		{
			int num = 0;
			for (int j = 0; j < allMovementNeighbours.Length; j++)
			{
				if (allMovementNeighbours[j].direction == Direction.Diagonal)
				{
					continue;
				}
				Vector3 val = OFIIBHBOPJI + allMovementNeighbours[j].position;
				if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(val), out value))
				{
					if (Object.op_Implicit((Object)(object)value.animalNPC))
					{
						FIFABPOJMAF[num].free = true;
						FIFABPOJMAF[num].cost = 1.3f;
					}
					else
					{
						FIFABPOJMAF[num].free = value.isFree;
						FIFABPOJMAF[num].cost = value.cost;
					}
					FIFABPOJMAF[num].position = Vector2.op_Implicit(val);
				}
				else
				{
					FIFABPOJMAF[num].free = false;
					FIFABPOJMAF[num].cost = 1f;
				}
				FIFABPOJMAF[num].direction = allMovementNeighbours[j].direction;
				num++;
			}
		}
		FIFABPOJMAF[FIFABPOJMAF.Length - 1].free = false;
		if (!Object.op_Implicit((Object)(object)TravelZonesManager.GGFJGHHHEJC))
		{
			return;
		}
		TravelZone travelZoneAtPosition = TravelZonesManager.GGFJGHHHEJC.GetTravelZoneAtPosition(OFIIBHBOPJI);
		if (Object.op_Implicit((Object)(object)travelZoneAtPosition))
		{
			travelZoneAtPosition = travelZoneAtPosition.GetTravelZoneTo();
			if (Object.op_Implicit((Object)(object)travelZoneAtPosition))
			{
				FIFABPOJMAF[FIFABPOJMAF.Length - 1].position = travelZoneAtPosition.GetPositionOnPathRequest();
				FIFABPOJMAF[FIFABPOJMAF.Length - 1].free = true;
			}
		}
	}

	public static void HLFPMCOJDHP(Vector3 IMOBLFMHKOD, bool IDKPELIFMBN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.isPath = IDKPELIFMBN;
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		}
	}

	public static void AKIFIOKDEJL(Herb GIOOHFKPHPF)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(((Component)GIOOHFKPHPF).transform.position, out var ILDEFBIANKO) && ILDEFBIANKO.herbs != null)
		{
			ILDEFBIANKO.herbs.Remove(GIOOHFKPHPF);
			if (ILDEFBIANKO.herbs.Count == 0)
			{
				ILDEFBIANKO.herbs = null;
				KILADDNLCOM(ILDEFBIANKO, ((Component)GIOOHFKPHPF).transform.position);
			}
		}
	}

	public static bool ECOFAPGIGMO(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.isPath;
		}
		return false;
	}

	public static bool IDLKDLFJDHJ(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (Utils.IELGICCBCHO(KELFJIPHBFP(IMOBLFMHKOD)) && !Utils.IELGICCBCHO(KELFJIPHBFP(IMOBLFMHKOD + new Vector3(0f, 0.5f))))
			{
				return false;
			}
			if (ILDEFBIANKO.groundType == GroundType.Floor)
			{
				return EditorGrid.ENFKMBHBBEM(IMOBLFMHKOD);
			}
			return false;
		}
		if (Application.isPlaying)
		{
			return false;
		}
		if ((Object)(object)PBLLKEKGLPK != (Object)null)
		{
			ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD, PBLLKEKGLPK, Season.Spring);
			if (Utils.IELGICCBCHO(KELFJIPHBFP(IMOBLFMHKOD)) && !Utils.IELGICCBCHO(KELFJIPHBFP(IMOBLFMHKOD + new Vector3(0f, 0.5f))))
			{
				return false;
			}
			if (ILDEFBIANKO.groundType == GroundType.Floor)
			{
				return EditorGrid.ENFKMBHBBEM(IMOBLFMHKOD);
			}
			return false;
		}
		return false;
	}

	public static void IAJCOLMDGGG(TileType FPFLJNACICI, List<Vector2> CHCFCJHIKPN)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < CHCFCJHIKPN.Count; i++)
		{
			if (NCEHFMPBBAK(Vector2.op_Implicit(CHCFCJHIKPN[i])) == GroundType.Floor && HJPCBBGHPDA(Vector2.op_Implicit(CHCFCJHIKPN[i])) == Location.Tavern)
			{
				GAGNJJDLOOB(Vector2.op_Implicit(CHCFCJHIKPN[i]), FPFLJNACICI, Utils.JGEPCPFJANP(Location.Tavern));
			}
		}
	}

	public static void FNLFHAKMKBA(Vector3 IMOBLFMHKOD, bool MOKJMAMEOAB, Direction FCGBJEIIMBC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(Utils.NKGANMEKDAL(IMOBLFMHKOD), out var ILDEFBIANKO))
		{
			ILDEFBIANKO.canPlaceSeat = MOKJMAMEOAB;
			ILDEFBIANKO.canPlaceSeatDirection = FCGBJEIIMBC;
			KILADDNLCOM(ILDEFBIANKO, Utils.NKGANMEKDAL(IMOBLFMHKOD));
		}
	}

	public static bool IFHBJCLHCFG(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.tucked;
		}
		return false;
	}

	public static bool LBKKDAMMKIE(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return (Object)(object)ILDEFBIANKO.door != (Object)null;
		}
		return false;
	}

	public static bool PBLONGKCHDB(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out LHGMAFHGAMK))
		{
			if (LHGMAFHGAMK.placeables != null && LHGMAFHGAMK.placeables.Count > 0)
			{
				return false;
			}
			return LHGMAFHGAMK.canFishSeasons.HasFlag(SeasonManager.ACNAHALFEBG);
		}
		return false;
	}

	public static void GDBBPKCJMJI(Vector3 IMOBLFMHKOD, Tilemap GCFBMPHOGIA, Season EECEKHKAAIH)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		bool num = (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD + Vector3.right * 0.5f) != (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD + Vector3.left * 0.5f) != (Object)null;
		bool flag = (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD + Vector3.up * 0.5f) != (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD + Vector3.down * 0.5f) != (Object)null;
		if (num && flag)
		{
			return;
		}
		GameTileMaps.GGFJGHHHEJC.RemoveTileAtPosition(IMOBLFMHKOD, GCFBMPHOGIA);
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD + allNeighbours[i].position);
			if ((Object)(object)OBPOFPDBFFD != (Object)null)
			{
				GDBBPKCJMJI(IMOBLFMHKOD + allNeighbours[i].position, GCFBMPHOGIA, EECEKHKAAIH);
			}
		}
	}

	public static bool EJCEAEPNJCA(Vector3 IMOBLFMHKOD, TilemapGroup IOKGALBEILM = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.groundType == GroundType.Floor;
		}
		if (IOKGALBEILM != null)
		{
			return IOKGALBEILM.floorLowerTilemap.HasTile(((GridLayout)IOKGALBEILM.floorLowerTilemap).WorldToCell(IMOBLFMHKOD));
		}
		return false;
	}

	public static void JOPBHFLAIGC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) || ILDEFBIANKO.placeables == null)
		{
			return;
		}
		for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
		{
			if (!((Object)(object)ILDEFBIANKO.placeables[i] == (Object)null))
			{
				ILDEFBIANKO.placeables[i].CalculateCurrentZone();
			}
		}
	}

	public static void JJEOOJEIIFM(Vector3 IMOBLFMHKOD, GameObject IOBENGJDEHK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(Utils.NKGANMEKDAL(IMOBLFMHKOD), out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.blockingObjects == null)
			{
				ILDEFBIANKO.blockingObjects = new List<GameObject>();
			}
			if (!ILDEFBIANKO.blockingObjects.Contains(IOBENGJDEHK))
			{
				ILDEFBIANKO.blockingObjects.Add(IOBENGJDEHK);
			}
			KILADDNLCOM(ILDEFBIANKO, Utils.NKGANMEKDAL(IMOBLFMHKOD));
		}
	}

	public static bool NDNAJIEGFNF(Vector3 IMOBLFMHKOD, Placeable EAPCLAODGAE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.placeables != null)
		{
			for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
			{
				if ((Object)(object)ILDEFBIANKO.placeables[i] == (Object)(object)EAPCLAODGAE)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void MDJDAKIMMJA(Vector2 IMOBLFMHKOD, Vector2Int KKANDELPDKP, ref Vector2[] NHINLEILOJO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Utils.MJEACANINDN(IMOBLFMHKOD) - Vector2Int.op_Implicit(KKANDELPDKP / 2) * 0.25f;
		Vector2 val2 = val;
		int num = 0;
		for (int i = 0; i < ((Vector2Int)(ref KKANDELPDKP)).x; i++)
		{
			for (int j = 0; j < ((Vector2Int)(ref KKANDELPDKP)).y; j++)
			{
				val2.x = val.x + (float)i * 0.25f;
				val2.y = val.y + (float)j * 0.25f;
				NHINLEILOJO[num] = val2;
				num++;
			}
		}
	}

	public static void AAPAHBCLANN(Vector3 IMOBLFMHKOD, bool JBNJGMKBKCB)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)GameTileMaps.GGFJGHHHEJC).StartCoroutine(GHOMJHCJCON(IMOBLFMHKOD, JBNJGMKBKCB));
	}

	public static bool NGDHDMAMGPI(WorldTile FEIBMGPEJLE, bool GCDEDGFDKBL = true)
	{
		if (FEIBMGPEJLE.canPlaceObjects)
		{
			if (GCDEDGFDKBL)
			{
				return FEIBMGPEJLE.blockingObjects == null;
			}
			return true;
		}
		return false;
	}

	public static bool FKLIGHHGCOP(Vector2 GNGKHMCIFNN, out WorldTile ILDEFBIANKO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		GNGKHMCIFNN = GNGKHMCIFNN * 0.5f + Vector2.one * 0.25f;
		GNGKHMCIFNN = Utils.NKGANMEKDAL(GNGKHMCIFNN);
		return GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(Vector2.op_Implicit(GNGKHMCIFNN), out ILDEFBIANKO);
	}

	public static void MJDKNJPJILH(Vector3 NOLFMLNLJJG, Vector3[] EMBAIAOPIAD = null)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (EMBAIAOPIAD == null)
		{
			if (!PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(Utils.MJEACANINDN(NOLFMLNLJJG))))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(Vector2.op_Implicit(Utils.MJEACANINDN(NOLFMLNLJJG)), value);
			}
			return;
		}
		for (int i = 0; i < EMBAIAOPIAD.Length; i++)
		{
			if (!PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(Utils.NKGANMEKDAL(NOLFMLNLJJG) + EMBAIAOPIAD[i])))
			{
				PathNode value2 = default(PathNode);
				value2.isFree = true;
				value2.cost = 1f;
				value2.animalNPC = null;
				PathNodesManager.pathNodes.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(NOLFMLNLJJG) + EMBAIAOPIAD[i]), value2);
			}
		}
	}

	public static bool HENDJJEEOHE(Vector3 IMOBLFMHKOD)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			for (int i = 0; i < allNeighbours.Length; i++)
			{
				if (KCJGJHNIPGP(IMOBLFMHKOD + allNeighbours[i].position))
				{
					return true;
				}
			}
			return false;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			return false;
		}
	}

	public static bool NGDDILJAHEK(Vector2[] CCLGJDEKNNI, int FNKDGEGPJFE, HashSet<Vector2> PKLLINPBCBD = null)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (PKLLINPBCBD != null)
		{
			for (int i = 0; i < FNKDGEGPJFE; i++)
			{
				if (!PKLLINPBCBD.Contains(CCLGJDEKNNI[i]) && !APKPGNDDJHC(Vector2.op_Implicit(CCLGJDEKNNI[i])))
				{
					return false;
				}
			}
		}
		else
		{
			for (int j = 0; j < FNKDGEGPJFE; j++)
			{
				if (!APKPGNDDJHC(Vector2.op_Implicit(CCLGJDEKNNI[j])))
				{
					return false;
				}
			}
		}
		return true;
	}

	public static void GAGNJJDLOOB(Vector3 IMOBLFMHKOD, TileType FPFLJNACICI, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out EIEGDCACDAL))
		{
			EIEGDCACDAL = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD, PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
		}
		if (EIEGDCACDAL.groundType == GroundType.Floor)
		{
			ALAOFNEOEMP(EIEGDCACDAL, IMOBLFMHKOD, FPFLJNACICI);
		}
	}

	public static void FADHHLHFGGL(Vector3 NOLFMLNLJJG, Vector3[] EMBAIAOPIAD = null)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (EMBAIAOPIAD == null)
		{
			PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(Utils.MJEACANINDN(NOLFMLNLJJG)));
			return;
		}
		for (int i = 0; i < EMBAIAOPIAD.Length; i++)
		{
			PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(Utils.MJEACANINDN(NOLFMLNLJJG) + EMBAIAOPIAD[i]));
		}
	}

	public static NeighbourAndDirection[] LNOGFOIPJDD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		NeighbourAndDirection[] array = new NeighbourAndDirection[FHHMDAEFDIM.Length];
		Array.Copy(FHHMDAEFDIM, array, FHHMDAEFDIM.Length);
		for (int i = 0; i < array.Length; i++)
		{
			ref Vector3 position = ref array[i].position;
			position += IMOBLFMHKOD;
		}
		return array;
	}

	private static void APEFAENFMML(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		if (!OEMMBCOIBCK(IMOBLFMHKOD, PBLLKEKGLPK.snowTilemaps.snowTilemaps))
		{
			GameTileMaps.GGFJGHHHEJC.RemoveTileAtPosition(IMOBLFMHKOD, PBLLKEKGLPK.snowTilemaps.darkSnowTilemap);
			for (int i = 0; i < allNeighbours.Length; i++)
			{
				if (OINMGKCIGEJ(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK.snowTilemaps.snowTilemaps) && KFAJFPKAOOK(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK) && OEMMBCOIBCK(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK.snowTilemaps.snowTilemaps))
				{
					LCOADNHMHJI(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK);
				}
			}
		}
		else
		{
			LCOADNHMHJI(IMOBLFMHKOD, PBLLKEKGLPK);
		}
	}

	private static void JDIBBOGBLEJ(Vector3 IMOBLFMHKOD, TileBase LLDKNGNEIDD, DecorationTile BGCOHNIBBMB, Tilemap GCFBMPHOGIA, bool PDJMAMPNCKP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD) == (Object)null)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			if (allNeighbours[i].direction != Direction.Diagonal && (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD + allNeighbours[i].position) != (Object)null)
			{
				flag = true;
				break;
			}
		}
		if (PDJMAMPNCKP && !flag)
		{
			GameTileMaps.GGFJGHHHEJC.RemoveTileAtPosition(IMOBLFMHKOD, GCFBMPHOGIA);
			return;
		}
		for (int j = 0; j < allNeighbours.Length; j++)
		{
			if ((Object)(object)Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, IMOBLFMHKOD + allNeighbours[j].position) == (Object)null)
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, LLDKNGNEIDD, GCFBMPHOGIA);
				return;
			}
		}
		BGCOHNIBBMB.OPHJLHHCMML(IMOBLFMHKOD, GCFBMPHOGIA);
	}

	public static void JDNOFFABHDI(Vector3 IMOBLFMHKOD, float HMCGEJFIKPM)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		GJGEFHFEALF(IMOBLFMHKOD);
		if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(Utils.MJEACANINDN(IMOBLFMHKOD))))
		{
			PathNode value = PathNodesManager.pathNodes[Vector2.op_Implicit(Utils.MJEACANINDN(IMOBLFMHKOD))];
			value.cost = HMCGEJFIKPM;
			value.animalNPC = null;
			PathNodesManager.pathNodes[Vector2.op_Implicit(Utils.MJEACANINDN(IMOBLFMHKOD))] = value;
		}
	}

	public static void JEEPIKKPBFI(Vector3 IMOBLFMHKOD, bool NKFPJPCFBJI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return;
		}
		KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		if (ILDEFBIANKO.groundType == GroundType.Grass)
		{
			if (NKFPJPCFBJI)
			{
				GameTileMaps.GGFJGHHHEJC.SetDetailAtPosition(IMOBLFMHKOD, ILDEFBIANKO.groundType, SeasonManager.EECEKHKAAIH, ILDEFBIANKO);
			}
			else
			{
				GameTileMaps.GGFJGHHHEJC.RemoveDetailAtPosition(IMOBLFMHKOD, ILDEFBIANKO.groundType, SeasonManager.EECEKHKAAIH);
			}
		}
	}

	public static void PBOIFLICMKG(Vector3 IMOBLFMHKOD, MonoBehaviour NCLKJEPJGCL)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD, Utils.JGEPCPFJANP(Location.Tavern), SeasonManager.EECEKHKAAIH);
		}
		ILDEFBIANKO.door = NCLKJEPJGCL;
		KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
	}

	public static TilemapScene JGEPCPFJANP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out CEPGPKAHGPK))
		{
			return CEPGPKAHGPK.PBLLKEKGLPK;
		}
		return null;
	}

	public static void AFCDNKANLFB(Vector3 IMOBLFMHKOD, bool GCIDAMFPDPD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD, Utils.JGEPCPFJANP(Location.Tavern), SeasonManager.EECEKHKAAIH);
		}
		ILDEFBIANKO.buildable = GCIDAMFPDPD;
		KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
	}

	public static bool[] OJKOLKNAHDB(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		List<bool> list = new List<bool>();
		NeighbourAndDirection[] array = LNOGFOIPJDD(IMOBLFMHKOD);
		for (int i = 0; i < array.Length; i++)
		{
			list.Add(!NGDHDMAMGPI(array[i].position) && !IFHBJCLHCFG(array[i].position));
		}
		return list.ToArray();
	}

	public static void GJGEFHFEALF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		if (EJCEAEPNJCA(IMOBLFMHKOD))
		{
			MJDKNJPJILH(IMOBLFMHKOD, (Vector3[])(object)new Vector3[1]
			{
				new Vector3(0.25f, 0.25f)
			});
			bool flag = EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(-0.5f, 0f));
			bool flag2 = EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(0f, -0.5f));
			bool flag3 = EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(-0.5f, -0.5f));
			if (flag2 && flag && flag3)
			{
				MJDKNJPJILH(IMOBLFMHKOD);
			}
			if (flag)
			{
				MJDKNJPJILH(IMOBLFMHKOD, (Vector3[])(object)new Vector3[1]
				{
					new Vector3(0f, 0.25f)
				});
			}
			if (flag2)
			{
				MJDKNJPJILH(IMOBLFMHKOD, (Vector3[])(object)new Vector3[1]
				{
					new Vector3(0.25f, 0f)
				});
			}
		}
	}

	public static bool KHJJCAGIJAP(Vector3 IMOBLFMHKOD, out float KHEBKHFHMDB)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		KHEBKHFHMDB = -1f;
		for (float num = 0.5f; num <= 2f; num += 0.5f)
		{
			if (DNDMDGOHDJD(IMOBLFMHKOD + Vector3.down * num))
			{
				KHEBKHFHMDB = IMOBLFMHKOD.y - num;
				return true;
			}
		}
		return false;
	}

	public static GameObject MMOHADHAAGD(Vector3 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Location BAIMHDBJPDK, Season FONLCEPCGEL = Season.Spring, bool CDPAMNIPPEC = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD, Utils.JGEPCPFJANP(BAIMHDBJPDK), Application.isPlaying ? SeasonManager.EECEKHKAAIH : FONLCEPCGEL);
		}
		else if (ILDEFBIANKO.groundType == GroundType.TilledEarth)
		{
			if (Object.op_Implicit((Object)(object)MMIIIKBJKBA<FertileSoil>(IMOBLFMHKOD)))
			{
				Utils.BLPDAEHPOBA(((Component)MMIIIKBJKBA<FertileSoil>(IMOBLFMHKOD)).gameObject);
			}
			else
			{
				Vector3 val = IMOBLFMHKOD;
				Debug.LogError((object)("Fertile soil object not found at " + ((object)(Vector3)(ref val)).ToString()));
			}
		}
		ILDEFBIANKO.groundType = GBKMNAPGIOM;
		if (GBKMNAPGIOM != 0)
		{
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.SendGroundType(Vector2.op_Implicit(IMOBLFMHKOD), GBKMNAPGIOM, BAIMHDBJPDK);
		}
		MBDKGAIDBDD(ILDEFBIANKO, IMOBLFMHKOD, ILDEFBIANKO.PBLLKEKGLPK, Application.isPlaying ? SeasonManager.EECEKHKAAIH : FONLCEPCGEL);
		if (GBKMNAPGIOM == GroundType.None)
		{
			GKOGJNPNAJE(IMOBLFMHKOD);
		}
		if (GBKMNAPGIOM == GroundType.TilledEarth)
		{
			return Utils.JCNFPEHGGKP(CommonReferences.GGFJGHHHEJC.tilledEarthPrefab, IMOBLFMHKOD, Quaternion.identity);
		}
		return null;
	}

	public static bool NGDDILJAHEK(Vector2[] CCLGJDEKNNI, HashSet<Vector2> PKLLINPBCBD = null)
	{
		return NGDDILJAHEK(CCLGJDEKNNI, CCLGJDEKNNI.Length, PKLLINPBCBD);
	}

	public static bool APKPGNDDJHC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.MJEACANINDN(IMOBLFMHKOD);
		if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(IMOBLFMHKOD), out var value))
		{
			return value.isFree;
		}
		return false;
	}

	public static bool DBPDHKFAMPC<T>(Vector3 IMOBLFMHKOD, out T AHKIHKCNBMP) where T : Component
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.placeables != null)
		{
			for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
			{
				if ((Object)(object)ILDEFBIANKO.placeables[i] != (Object)null)
				{
					AHKIHKCNBMP = ((Component)ILDEFBIANKO.placeables[i]).GetComponent<T>();
					if ((Object)(object)AHKIHKCNBMP != (Object)null)
					{
						return true;
					}
				}
			}
		}
		AHKIHKCNBMP = default(T);
		return false;
	}

	public static void PNANPLFPBNP(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, bool MDIKPGGBNLI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, MDIKPGGBNLI ? null : GameTileMaps.GGFJGHHHEJC.blackTile, PBLLKEKGLPK.wallTilemaps.wallFrontNoColliders);
	}

	public static void MKLAFNJLOJN(TilemapScene PBLLKEKGLPK, Vector3Int[] GEIFPPHMBFI = null)
	{
		ANGGDPPNGKH(PBLLKEKGLPK, GEIFPPHMBFI);
		FBLEBPPKHDA(TileType.WallBack, PBLLKEKGLPK, GEIFPPHMBFI);
		FBLEBPPKHDA(TileType.Roof, PBLLKEKGLPK, GEIFPPHMBFI);
	}

	private static bool LPKJCKACCHN(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if (EJCEAEPNJCA(IMOBLFMHKOD) || ALNFLFCLIEP(IMOBLFMHKOD) || EJCEAEPNJCA(IMOBLFMHKOD + Vector3.down * 0.5f) || EJCEAEPNJCA(IMOBLFMHKOD + Vector3.left * 0.5f) || EJCEAEPNJCA(IMOBLFMHKOD + Vector3.right * 0.5f) || ALNFLFCLIEP(IMOBLFMHKOD + Vector3.down * 0.5f) || ALNFLFCLIEP(IMOBLFMHKOD + Vector3.left * 0.5f) || ALNFLFCLIEP(IMOBLFMHKOD + Vector3.right * 0.5f) || ALNFLFCLIEP(IMOBLFMHKOD + new Vector3(0.5f, -0.5f)) || ALNFLFCLIEP(IMOBLFMHKOD + new Vector3(-0.5f, -0.5f)))
		{
			return false;
		}
		PNANPLFPBNP(IMOBLFMHKOD, PBLLKEKGLPK, MDIKPGGBNLI: false);
		return true;
	}

	public static AnimalNPC AGIJJFBMIIA(Vector2[] CCLGJDEKNNI, int ALMEEDGLGEO, HashSet<Vector2> PKLLINPBCBD = null)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (PKLLINPBCBD != null)
		{
			for (int i = 0; i < ALMEEDGLGEO; i++)
			{
				if (!PKLLINPBCBD.Contains(CCLGJDEKNNI[i]) && Object.op_Implicit((Object)(object)BHKALCKEJPO(Vector2.op_Implicit(CCLGJDEKNNI[i]))))
				{
					return BHKALCKEJPO(Vector2.op_Implicit(CCLGJDEKNNI[i]));
				}
			}
		}
		else
		{
			for (int j = 0; j < ALMEEDGLGEO; j++)
			{
				if (Object.op_Implicit((Object)(object)BHKALCKEJPO(Vector2.op_Implicit(CCLGJDEKNNI[j]))))
				{
					return BHKALCKEJPO(Vector2.op_Implicit(CCLGJDEKNNI[j]));
				}
			}
		}
		return null;
	}

	public static void BBHDDBDMKHD(Vector3 IMOBLFMHKOD, bool PMONOIGDAAC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.tucked = PMONOIGDAAC;
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		}
	}

	public static void OENGJCPDBKH(Season EECEKHKAAIH)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)Utils.JGEPCPFJANP(Location.Tavern).GetTilemaps(EECEKHKAAIH).floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (GCGNCHFNEBJ(iMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.groundType == GroundType.Floor)
			{
				MBDKGAIDBDD(ILDEFBIANKO, iMOBLFMHKOD, ILDEFBIANKO.PBLLKEKGLPK, EECEKHKAAIH);
			}
		}
	}

	public static bool GJHHDIJOILG(Vector3 IMOBLFMHKOD, bool JGDOHPCLJPM = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.placeables != null && ILDEFBIANKO.placeables.Count > 0)
		{
			if (!JGDOHPCLJPM)
			{
				return true;
			}
			for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
			{
				if ((Object)(object)ILDEFBIANKO.placeables[i].itemSpace != (Object)null)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static bool LFNIJJPBPEL(Vector3 IMOBLFMHKOD, out bool OAFDNOGHMDD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(Utils.MJEACANINDN(IMOBLFMHKOD)), out var value))
		{
			OAFDNOGHMDD = value.isFree;
		}
		else
		{
			OAFDNOGHMDD = false;
		}
		return OAFDNOGHMDD;
	}

	public static List<Vector3> EHJLDGOIILF(Vector3 OFIIBHBOPJI, int DFFGLLDDEPN)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			Vector3 iMOBLFMHKOD = OFIIBHBOPJI + allNeighbours[i].position * (float)DFFGLLDDEPN;
			iMOBLFMHKOD = Utils.MJEACANINDN(iMOBLFMHKOD);
			if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(iMOBLFMHKOD), out var value) && value.isFree)
			{
				list.Add(iMOBLFMHKOD);
			}
		}
		return list;
	}

	private static void GKFIJMIMNPO(Vector3 IMOBLFMHKOD, Transform CHGOBPEDDBJ, Tilemap GCFBMPHOGIA, DetailTileType GIDPJKPNFGK)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		DetailTilesInfo detailTilesInfo = NDPNPAMAEPC(GIDPJKPNFGK);
		AAFJOAPNNBA.x = (float)detailTilesInfo.offsetX * 0.5f;
		AAFJOAPNNBA.y = (float)detailTilesInfo.offsetY * 0.5f;
		OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, CHGOBPEDDBJ.position + AAFJOAPNNBA);
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, OBPOFPDBFFD, GCFBMPHOGIA);
	}

	public static void FPHAMKKBNMC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		if (!CPAECKJKLIP.Contains(IMOBLFMHKOD))
		{
			CPAECKJKLIP.Add(IMOBLFMHKOD);
		}
		if (ILPCCJHHPKF == null)
		{
			ILPCCJHHPKF = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(ANNECNINAAM());
		}
	}

	public static T NGFBJDEKJCB<T>(int JIIGOACEIKL) where T : MonoBehaviour
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		InputByProximity currentFocusedInputElement = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
		if ((Object)(object)currentFocusedInputElement != (Object)null)
		{
			return MMIIIKBJKBA<T>(LOJBKLKMINM(((Component)currentFocusedInputElement).transform.position));
		}
		return default(T);
	}

	public static void OIIPHEICEAN(Vector3 IMOBLFMHKOD, bool GIDOELBFLJH)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.wooded = GIDOELBFLJH;
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		}
	}

	private static void KJPGMGCFCHG(Vector3 IMOBLFMHKOD, Season EECEKHKAAIH, TilemapScene PBLLKEKGLPK, bool DBCGKFOBNPP = true)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			for (int i = 0; i < allNeighbours.Length; i++)
			{
				if (NCEHFMPBBAK(IMOBLFMHKOD + allNeighbours[i].position) != GroundType.Grass && ((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap == (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap, IMOBLFMHKOD + allNeighbours[i].position) == (Object)null))
				{
					OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap, IMOBLFMHKOD);
					if ((Object)(object)OBPOFPDBFFD != (Object)null)
					{
						OOIIMEJMHPK = ((Object)OBPOFPDBFFD).name;
					}
					else
					{
						OOIIMEJMHPK = "";
					}
					GameTileMaps.GGFJGHHHEJC.SetGrassTileAtPosition(IMOBLFMHKOD, PBLLKEKGLPK, EECEKHKAAIH, (Object)(object)OBPOFPDBFFD != (Object)null && OOIIMEJMHPK.Contains("Cliffs"));
					if (DBCGKFOBNPP)
					{
						GameTileMaps.GGFJGHHHEJC.RemoveDetailAtPosition(IMOBLFMHKOD, GroundType.Grass, EECEKHKAAIH);
					}
					CKDDIGCJANA(IMOBLFMHKOD);
					return;
				}
			}
		}
		else
		{
			for (int j = 0; j < allNeighbours.Length; j++)
			{
				OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap, IMOBLFMHKOD + allNeighbours[j].position);
				if ((Object)(object)OBPOFPDBFFD != (Object)null)
				{
					OOIIMEJMHPK = ((Object)OBPOFPDBFFD).name;
				}
				else
				{
					OOIIMEJMHPK = "";
				}
				if (!((Object)(object)OBPOFPDBFFD == (Object)null) && OOIIMEJMHPK.Contains("Grass"))
				{
					continue;
				}
				if (EECEKHKAAIH == Season.Spring)
				{
					if ((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap != (Object)null)
					{
						OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap, IMOBLFMHKOD + allNeighbours[j].position);
					}
					if ((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).waterCliffsTilemap != (Object)null && (Object)(object)OBPOFPDBFFD != (Object)null)
					{
						continue;
					}
				}
				OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap, IMOBLFMHKOD);
				GameTileMaps.GGFJGHHHEJC.SetGrassTileAtPosition(IMOBLFMHKOD, PBLLKEKGLPK, EECEKHKAAIH, (Object)(object)OBPOFPDBFFD != (Object)null && ((Object)OBPOFPDBFFD).name.ToLower().Contains("cliffs"));
				return;
			}
		}
		OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap, IMOBLFMHKOD);
		GameTileMaps.TerrainTiles terrainTiles = ((TilemapsInfo.ELHHFNFJIAD(PBLLKEKGLPK.location) != InteriorType.Cave) ? GameTileMaps.GGFJGHHHEJC.GetSeasonTiles(EECEKHKAAIH) : GameTileMaps.GGFJGHHHEJC.caveTiles);
		if (Object.op_Implicit((Object)(object)OBPOFPDBFFD) && ((Object)OBPOFPDBFFD).name.ToLower().Contains("grasscliffs"))
		{
			terrainTiles.grassCliffsFilled.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap);
		}
		else
		{
			terrainTiles.grassFilled.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap);
		}
		if (DBCGKFOBNPP)
		{
			GameTileMaps.GGFJGHHHEJC.SetDetailAtPosition(IMOBLFMHKOD, GroundType.Grass, EECEKHKAAIH);
		}
	}

	private static void LCOADNHMHJI(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			if (!OINMGKCIGEJ(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK.snowTilemaps.snowTilemaps) || !KFAJFPKAOOK(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK) || !OEMMBCOIBCK(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK.snowTilemaps.snowTilemaps))
			{
				GameTileMaps.GGFJGHHHEJC.SetDarkSnowTileAtPosition(IMOBLFMHKOD, PBLLKEKGLPK);
				return;
			}
		}
		GameTileMaps.GGFJGHHHEJC.GetSeasonTiles(Season.Winter).darkGrassFilled.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.snowTilemaps.darkSnowTilemap);
	}

	public static void CKDDIGCJANA(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) || ILDEFBIANKO.herbs == null)
		{
			return;
		}
		for (int i = 0; i < ILDEFBIANKO.herbs.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)ILDEFBIANKO.herbs[i].GetGenerator()))
			{
				ILDEFBIANKO.herbs[i].GetGenerator().RemoveForestElement(ILDEFBIANKO.herbs[i]);
			}
			Utils.BLPDAEHPOBA(((Component)ILDEFBIANKO.herbs[i]).gameObject);
		}
		ILDEFBIANKO.herbs = null;
		KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
	}

	private static IEnumerator GHOMJHCJCON(Vector3 IMOBLFMHKOD, bool JBNJGMKBKCB)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		yield return null;
		CFAHJNLAJNK(IMOBLFMHKOD, JBNJGMKBKCB);
	}

	public static IrrigatorType BKKHDHJEPMK(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.irrigator;
		}
		return IrrigatorType.None;
	}

	public static void PIBHFFJJAFB(Vector3 FCMMFDIGFMB, int CPDKKODHCJM)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(FCMMFDIGFMB, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.decoWallId = CPDKKODHCJM;
			KILADDNLCOM(ILDEFBIANKO, FCMMFDIGFMB);
			MBDKGAIDBDD(ILDEFBIANKO, FCMMFDIGFMB, ILDEFBIANKO.PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
		}
		if (GCGNCHFNEBJ(FCMMFDIGFMB + new Vector3(0f, -0.5f), out ILDEFBIANKO))
		{
			ILDEFBIANKO.decoWallId = CPDKKODHCJM;
			KILADDNLCOM(ILDEFBIANKO, FCMMFDIGFMB + new Vector3(0f, -0.5f));
			MBDKGAIDBDD(ILDEFBIANKO, FCMMFDIGFMB + new Vector3(0f, -0.5f), ILDEFBIANKO.PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
		}
	}

	public static Placeable CBPIPKCCFAC(Vector3 IMOBLFMHKOD, int MNBNGGHHMBB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.placeables != null)
		{
			for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
			{
				if ((Object)(object)ILDEFBIANKO.placeables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(ILDEFBIANKO.placeables[i].itemSetup.item, null) && ILDEFBIANKO.placeables[i].itemSetup.item.JDJGFAACPFC() == MNBNGGHHMBB)
				{
					return ILDEFBIANKO.placeables[i];
				}
			}
		}
		return null;
	}

	public static bool NGDHDMAMGPI(Vector3 IMOBLFMHKOD, bool GCDEDGFDKBL = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.canPlaceObjects)
			{
				if (GCDEDGFDKBL)
				{
					return ILDEFBIANKO.blockingObjects == null;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static T MMIIIKBJKBA<T>(Vector3 MJGMEBDNKKI) where T : MonoBehaviour
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Collider2D[] array = Physics2D.OverlapPointAll(Vector2.op_Implicit(MJGMEBDNKKI));
		for (int i = 0; i < array.Length; i++)
		{
			T component = ((Component)array[i]).gameObject.GetComponent<T>();
			if ((Object)(object)component != (Object)null)
			{
				return component;
			}
		}
		return default(T);
	}

	public static void LOMFGJMEGOG(TilemapScene PBLLKEKGLPK, Vector3Int[] HAKPCIKJLNM)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		for (int i = 0; i < HAKPCIKJLNM.Length; i++)
		{
			Vector3 val = ((GridLayout)PBLLKEKGLPK.GetTilemaps(SeasonManager.EECEKHKAAIH).floorUpperTilemap).CellToWorld(HAKPCIKJLNM[i]);
			if (!GCGNCHFNEBJ(val, out var ILDEFBIANKO) || (ILDEFBIANKO.groundType != GroundType.Floor && !ILDEFBIANKO.wall))
			{
				continue;
			}
			for (float num2 = 1f; num2 < (float)(1 + num) && LPKJCKACCHN(val + new Vector3(num2, 0f), PBLLKEKGLPK); num2 += 0.5f)
			{
			}
			for (float num3 = 1f; num3 < (float)(1 + num) && LPKJCKACCHN(val + new Vector3(0f - num3, 0f), PBLLKEKGLPK); num3 += 0.5f)
			{
			}
			for (float num4 = -1f; num4 <= 1f; num4 += 0.5f)
			{
				for (float num5 = 0.5f; num5 < 0.5f + (float)num && LPKJCKACCHN(val + new Vector3(num4, 0f - num5), PBLLKEKGLPK); num5 += 0.5f)
				{
				}
			}
			if (!ILDEFBIANKO.wall)
			{
				continue;
			}
			for (float num6 = -1f; num6 <= 1f; num6 += 0.5f)
			{
				for (float num7 = 1f; num7 < 1f + (float)num && LPKJCKACCHN(val + new Vector3(num6, num7), PBLLKEKGLPK); num7 += 0.5f)
				{
				}
			}
		}
	}

	public static AnimalNPC BHKALCKEJPO(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.MJEACANINDN(IMOBLFMHKOD);
		if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(IMOBLFMHKOD), out var value))
		{
			return value.animalNPC;
		}
		return null;
	}

	private static bool OEMMBCOIBCK(Vector3 IMOBLFMHKOD, Tilemap[] MHNHDHILPGI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			if (!OINMGKCIGEJ(IMOBLFMHKOD + allNeighbours[i].position, MHNHDHILPGI))
			{
				return false;
			}
		}
		return true;
	}

	public static List<NeighbourAndDirection> HAGAEBPFJBG(IEnumerable<Vector3> AOIAKLJDNDL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		HashSet<Vector3> hashSet = new HashSet<Vector3>();
		List<NeighbourAndDirection> list = new List<NeighbourAndDirection>();
		for (int i = 0; i < allNeighbourAndDirections.Length; i++)
		{
			foreach (Vector3 item in AOIAKLJDNDL)
			{
				Vector3 val = Vector2.op_Implicit(Vector2.op_Implicit(item)) + allNeighbourAndDirections[i].position;
				if (!hashSet.Contains(val))
				{
					hashSet.Add(val);
					list.Add(new NeighbourAndDirection(Vector2.op_Implicit(val), allNeighbourAndDirections[i].direction));
				}
			}
		}
		return list;
	}

	public static bool IFLBFJBNPKP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.placeables != null)
			{
				for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
				{
					if ((Object)(object)ILDEFBIANKO.placeables[i].areaSpace != (Object)null)
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static void IFKKOPKHBHJ(Vector3 IMOBLFMHKOD, int NDKJEODFOCA, int CPDKKODHCJM, int GLBPIAAKDCP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		OCNNHIIJLPD(IMOBLFMHKOD, Utils.JGEPCPFJANP(Location.Tavern), NDKJEODFOCA, CPDKKODHCJM, GLBPIAAKDCP);
		GJGEFHFEALF(IMOBLFMHKOD);
		CFAHJNLAJNK(IMOBLFMHKOD, JBNJGMKBKCB: true);
		if (Utils.BLIAFMGPONN(IMOBLFMHKOD))
		{
			NDPILMNDCDK(IMOBLFMHKOD, ZoneType.Cellar);
		}
	}

	public static bool OINMGKCIGEJ(Vector3 IMOBLFMHKOD, Tilemap[] MHNHDHILPGI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
			{
				return ILDEFBIANKO.hasSnow;
			}
			return false;
		}
		for (int i = 0; i < MHNHDHILPGI.Length; i++)
		{
			if ((Object)(object)Utils.GCGNCHFNEBJ<TileBase>(MHNHDHILPGI[i], IMOBLFMHKOD) != (Object)null)
			{
				return true;
			}
		}
		return false;
	}

	private static void KILADDNLCOM(WorldTile ILDEFBIANKO, Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		GameTileMaps.GGFJGHHHEJC.SetWorldTiles(Utils.NKGANMEKDAL(IMOBLFMHKOD), ILDEFBIANKO);
	}

	public static ZoneType AGKGGAFFFGM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.zoneType;
		}
		return ZoneType.WithoutZone;
	}

	public static int IKCDANOHPJE(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
			{
				return ILDEFBIANKO.decoWallId;
			}
			return 0;
		}
		return EditorActionsDBAccessor.GetDecoWallId(IMOBLFMHKOD, PBLLKEKGLPK);
	}

	public static void MMOHADHAAGD(Vector3 IMOBLFMHKOD, GroundType GBKMNAPGIOM, TilemapScene PBLLKEKGLPK, Season FONLCEPCGEL = Season.Spring)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD, PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
		}
		ILDEFBIANKO.groundType = GBKMNAPGIOM;
		if (GBKMNAPGIOM != 0)
		{
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		}
		MBDKGAIDBDD(ILDEFBIANKO, IMOBLFMHKOD, PBLLKEKGLPK, Application.isPlaying ? SeasonManager.EECEKHKAAIH : FONLCEPCGEL);
		if (GBKMNAPGIOM == GroundType.None)
		{
			GKOGJNPNAJE(IMOBLFMHKOD);
		}
	}

	private static bool IJLKHCIGGEA(Vector2 IMOBLFMHKOD, List<Vector2> FNEHIAGFAOF)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (!AOPAJANIPDB(Vector2.op_Implicit(AHPIAIHJJMJ), JKCGPNFINFP: false))
		{
			FNEHIAGFAOF.Add(IMOBLFMHKOD);
			FNEHIAGFAOF.Add(IMOBLFMHKOD + new Vector2(0.5f, 0f));
			FNEHIAGFAOF.Add(IMOBLFMHKOD + new Vector2(0f, 0.5f));
			FNEHIAGFAOF.Add(IMOBLFMHKOD + new Vector2(0.5f, 0.5f));
			return true;
		}
		return false;
	}

	public static Vector3[] JKDLPFDEKJA(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		Vector3[] array = (Vector3[])(object)new Vector3[FHHMDAEFDIM.Length];
		Array.Copy(FHHMDAEFDIM, array, FHHMDAEFDIM.Length);
		for (int i = 0; i < array.Length; i++)
		{
			ref Vector3 reference = ref array[i];
			reference += IMOBLFMHKOD + new Vector3(0.25f, 0.25f);
		}
		return array;
	}

	public static void FBLEBPPKHDA(TileType FPFLJNACICI, TilemapScene PBLLKEKGLPK, Vector3Int[] GEIFPPHMBFI = null)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (GEIFPPHMBFI == null)
		{
			GEIFPPHMBFI = PBLLKEKGLPK.GetAllPositionsToCalculate();
		}
		TilemapGroup tilemaps = PBLLKEKGLPK.GetTilemaps(SeasonManager.EECEKHKAAIH);
		for (int i = 0; i < GEIFPPHMBFI.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(GEIFPPHMBFI[i]);
			if (Application.isPlaying)
			{
				if (NCEHFMPBBAK(iMOBLFMHKOD) == GroundType.Floor)
				{
					GAGNJJDLOOB(iMOBLFMHKOD, FPFLJNACICI, PBLLKEKGLPK);
				}
			}
			else if (tilemaps.floorLowerTilemap.HasTile(GEIFPPHMBFI[i]))
			{
				GAGNJJDLOOB(iMOBLFMHKOD, FPFLJNACICI, PBLLKEKGLPK);
			}
		}
	}

	public static bool NBIOOGJJLCE(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.wooded;
		}
		return false;
	}

	public static bool GCGNCHFNEBJ(Vector3 IMOBLFMHKOD, out WorldTile ILDEFBIANKO)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC != (Object)null && GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM != null)
		{
			IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
			return GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(IMOBLFMHKOD, out ILDEFBIANKO);
		}
		ILDEFBIANKO = default(WorldTile);
		return false;
	}

	public static bool HLGNIMNEKAL(Vector3 IMOBLFMHKOD, Direction FCGBJEIIMBC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.canPlaceSeat)
			{
				return ILDEFBIANKO.canPlaceSeatDirection == FCGBJEIIMBC;
			}
			return false;
		}
		return false;
	}

	public static void OCMBMAPHGDC(HashSet<Vector2> HAEIAGKNEPC, bool GAKNPAMHAFB, AnimalNPC GGJLNHNAKCF = null)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		foreach (Vector2 item in HAEIAGKNEPC)
		{
			LMMELLKNMCF(Vector2.op_Implicit(item), GAKNPAMHAFB, GGJLNHNAKCF);
		}
	}

	public static void PCGNGKPHKLC(Vector3 IMOBLFMHKOD, Placeable EAPCLAODGAE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out FDILHKBNLGC))
		{
			if (FDILHKBNLGC.placeables == null)
			{
				FDILHKBNLGC.placeables = new List<Placeable>();
				FDILHKBNLGC.placeables.Add(EAPCLAODGAE);
				KILADDNLCOM(FDILHKBNLGC, IMOBLFMHKOD);
			}
			else if (!FDILHKBNLGC.placeables.Contains(EAPCLAODGAE))
			{
				FDILHKBNLGC.placeables.Add(EAPCLAODGAE);
			}
		}
		if (Application.isPlaying)
		{
			EAPCLAODGAE.CalculateCurrentZone();
		}
	}

	public static Vector2 GCHANLMNJGJ(Vector2 GNGKHMCIFNN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		GNGKHMCIFNN = GNGKHMCIFNN * 0.5f + Vector2.one * 0.25f;
		return Utils.NKGANMEKDAL(GNGKHMCIFNN);
	}

	public static bool EACFFPAOFLP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.buildable;
		}
		return false;
	}

	public static void MKLAFNJLOJN(List<Vector2> CHCFCJHIKPN)
	{
		IAJCOLMDGGG(TileType.WallBack, CHCFCJHIKPN);
		IAJCOLMDGGG(TileType.Roof, CHCFCJHIKPN);
	}

	private static bool HCKJMIBJLME(Vector2 KLINKLCGCME, float AAFJOAPNNBA, List<Vector2> HJAMJLPKACF)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		OLADKFEBMPH = false;
		BDKCDBALPJH = KLINKLCGCME.x + AAFJOAPNNBA * 0.5f;
		ACMOGJCLELA = KLINKLCGCME.y + AAFJOAPNNBA * 0.5f;
		AHPIAIHJJMJ = new Vector2(BDKCDBALPJH, KLINKLCGCME.y);
		if (IJLKHCIGGEA(AHPIAIHJJMJ, HJAMJLPKACF))
		{
			OLADKFEBMPH = true;
		}
		AHPIAIHJJMJ = new Vector2(BDKCDBALPJH, AJLJHLHGGBD.y);
		if (IJLKHCIGGEA(AHPIAIHJJMJ, HJAMJLPKACF))
		{
			OLADKFEBMPH = true;
		}
		AHPIAIHJJMJ = new Vector2(KLINKLCGCME.x, ACMOGJCLELA);
		if (IJLKHCIGGEA(AHPIAIHJJMJ, HJAMJLPKACF))
		{
			OLADKFEBMPH = true;
		}
		AHPIAIHJJMJ = new Vector2(AJLJHLHGGBD.x, ACMOGJCLELA);
		if (IJLKHCIGGEA(AHPIAIHJJMJ, HJAMJLPKACF))
		{
			OLADKFEBMPH = true;
		}
		return OLADKFEBMPH;
	}

	public static void PDLFLKBJGOE(Vector3 IMOBLFMHKOD, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) || ILDEFBIANKO.placeables == null)
		{
			return;
		}
		for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
		{
			if (!((Object)(object)ILDEFBIANKO.placeables[i] == (Object)null))
			{
				ILDEFBIANKO.placeables[i].SetCurrentZone(GIBJPCAFCJB, LMJDICEAONP);
			}
		}
	}

	public static int EIHIPOEOBCO(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
			{
				return ILDEFBIANKO.decoFloorId;
			}
			return 0;
		}
		return EditorActionsDBAccessor.GetDecoFloorId(IMOBLFMHKOD, PBLLKEKGLPK);
	}

	private static void HLCLEKBJNDE(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, Tilemap[] MHNHDHILPGI, bool DBCGKFOBNPP = true)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < MHNHDHILPGI.Length; i++)
		{
			if (Application.isPlaying)
			{
				for (int j = 0; j < allNeighbours.Length; j++)
				{
					if (!OINMGKCIGEJ(IMOBLFMHKOD + allNeighbours[j].position, MHNHDHILPGI))
					{
						GameTileMaps.GGFJGHHHEJC.SetSnowTileAtPosition(IMOBLFMHKOD, MHNHDHILPGI[i]);
						GameTileMaps.GGFJGHHHEJC.RemoveSnowDetailAtPosition(IMOBLFMHKOD, PBLLKEKGLPK.snowTilemaps.snowDetailTilemap);
						return;
					}
				}
			}
			else
			{
				if ((Object)(object)PBLLKEKGLPK.snowTilemaps.snowTilemaps[i].GetTile(((GridLayout)MHNHDHILPGI[i]).WorldToCell(IMOBLFMHKOD)) == (Object)null && HJPCBBGHPDA(IMOBLFMHKOD) != Location.Road)
				{
					continue;
				}
				for (int k = 0; k < allNeighbours.Length; k++)
				{
					OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(MHNHDHILPGI[i], IMOBLFMHKOD + allNeighbours[k].position);
					if ((Object)(object)OBPOFPDBFFD != (Object)null)
					{
						OOIIMEJMHPK = ((Object)OBPOFPDBFFD).name;
					}
					else
					{
						OOIIMEJMHPK = "";
					}
					if ((Object)(object)OBPOFPDBFFD == (Object)null || !OOIIMEJMHPK.Contains("Snow"))
					{
						GameTileMaps.GGFJGHHHEJC.SetSnowTileAtPosition(IMOBLFMHKOD, MHNHDHILPGI[i]);
						return;
					}
				}
			}
			GameTileMaps.GGFJGHHHEJC.snowFilled.OPHJLHHCMML(IMOBLFMHKOD, MHNHDHILPGI[i]);
			if (DBCGKFOBNPP)
			{
				GameTileMaps.GGFJGHHHEJC.SetSnowDetailAtPosition(IMOBLFMHKOD);
			}
		}
	}

	private static void GKOGJNPNAJE(Vector3 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.Remove(Utils.NKGANMEKDAL(IMOBLFMHKOD));
	}

	public static void ONHDGOJOHAH(WorldTile ILDEFBIANKO, Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, Tilemap[] MHNHDHILPGI, bool DBCGKFOBNPP = true)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		if (MHNHDHILPGI == null)
		{
			return;
		}
		if (ILDEFBIANKO.hasSnow)
		{
			HLCLEKBJNDE(IMOBLFMHKOD, PBLLKEKGLPK, MHNHDHILPGI, DBCGKFOBNPP);
		}
		else if (ILDEFBIANKO.snowProbability > 0f)
		{
			GameTileMaps.GGFJGHHHEJC.RemoveSnowAtPosition(IMOBLFMHKOD, PBLLKEKGLPK, DBCGKFOBNPP);
		}
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			if (OINMGKCIGEJ(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK.snowTilemaps.snowTilemaps))
			{
				HLCLEKBJNDE(IMOBLFMHKOD + allNeighbours[i].position, PBLLKEKGLPK, MHNHDHILPGI, DBCGKFOBNPP);
			}
		}
	}

	public static bool GIDMFDGGBLK(Vector3 IMOBLFMHKOD, Direction FCGBJEIIMBC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (AOPAJANIPDB(IMOBLFMHKOD + Utils.NGFODNCHPHB(FCGBJEIIMBC) * 1.5f))
		{
			return true;
		}
		return false;
	}

	public static bool ODEDHIBPMMO(Vector2 DEACEMMGPHA)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (float num = -0.5f; num < 0.6f; num += 0.5f)
		{
			for (float num2 = -0.5f; num2 < 0.6f; num2 += 0.5f)
			{
				if (!OINMGKCIGEJ(Vector2.op_Implicit(DEACEMMGPHA + new Vector2(num, num2)), null))
				{
					return false;
				}
			}
		}
		return true;
	}

	private static void FBLJHPDFNHI(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, int LEHFPICHDFP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		if (!EditorGrid.ENFKMBHBBEM(IMOBLFMHKOD))
		{
			return;
		}
		FLDDFKCAIGD = BGAKHCBGFIO(IMOBLFMHKOD + Vector3.left * 0.5f, PBLLKEKGLPK);
		DLDMMAHGLHB = BGAKHCBGFIO(IMOBLFMHKOD + Vector3.right * 0.5f, PBLLKEKGLPK);
		IALHJANIGBN = IDLKDLFJDHJ(IMOBLFMHKOD + Vector3.up * 0.5f, PBLLKEKGLPK);
		CMJMHHIAACM = BGAKHCBGFIO(IMOBLFMHKOD + Vector3.down * 0.5f, PBLLKEKGLPK);
		GHHLMAGAGOF = BGAKHCBGFIO(IMOBLFMHKOD + Vector3.down, PBLLKEKGLPK);
		AKLNMKGKBPE = IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0.5f, 0.5f), PBLLKEKGLPK);
		EFEABAPKBBP = IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f), PBLLKEKGLPK);
		KLGNJFKEPKK = BGAKHCBGFIO(IMOBLFMHKOD + new Vector3(0.5f, -0.5f), PBLLKEKGLPK);
		GIOOPOKIEOP = BGAKHCBGFIO(IMOBLFMHKOD + new Vector3(-0.5f, -0.5f), PBLLKEKGLPK);
		LJCEFANKHBK = BGAKHCBGFIO(IMOBLFMHKOD + new Vector3(0.5f, -1f), PBLLKEKGLPK);
		DCAODGJFCLF = BGAKHCBGFIO(IMOBLFMHKOD + new Vector3(-0.5f, -1f), PBLLKEKGLPK);
		bool flag = EACFFPAOFLP(IMOBLFMHKOD + Vector3.down * 0.5f);
		if (!EditorActionsDBAccessor.IsValid())
		{
			return;
		}
		int jFNMCNCHMEO = EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		DecorationTile decoTile = EditorActionsDBAccessor.GetDecoTile(LEHFPICHDFP);
		MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(jFNMCNCHMEO);
		Tilemap gCFBMPHOGIA;
		Transform cHGOBPEDDBJ;
		if ((Object)(object)MIMAGPFCMKH != (Object)null && MIMAGPFCMKH.materialType == MaterialType.Stone)
		{
			cHGOBPEDDBJ = GameTileMaps.GGFJGHHHEJC.stoneDetailsPos;
			gCFBMPHOGIA = PBLLKEKGLPK.wallTilemaps.wallBackDetail;
		}
		else
		{
			cHGOBPEDDBJ = GameTileMaps.GGFJGHHHEJC.woodDetailsPos;
			gCFBMPHOGIA = PBLLKEKGLPK.wallTilemaps.floorUpperDetail;
		}
		if (!CMJMHHIAACM && KLGNJFKEPKK)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.RightUp);
		}
		else if (!CMJMHHIAACM && GIOOPOKIEOP)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.LeftUp);
		}
		else if (CMJMHHIAACM && !GHHLMAGAGOF && !IALHJANIGBN)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.UpDown);
		}
		else if (CMJMHHIAACM && !GHHLMAGAGOF && !FLDDFKCAIGD && flag)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.LeftDown);
		}
		else if (CMJMHHIAACM && !GHHLMAGAGOF && !DLDMMAHGLHB && flag)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.RightDown);
		}
		else if (!LJCEFANKHBK && CMJMHHIAACM && GHHLMAGAGOF && DLDMMAHGLHB && !IALHJANIGBN)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.UpCornerRightDown);
		}
		else if (!DCAODGJFCLF && CMJMHHIAACM && GHHLMAGAGOF && FLDDFKCAIGD && !IALHJANIGBN)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.UpCornerLeftDown);
		}
		else if (!AKLNMKGKBPE && IALHJANIGBN && DLDMMAHGLHB && CMJMHHIAACM && !GHHLMAGAGOF && flag)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.DownCornerRightUp);
		}
		else if (!EFEABAPKBBP && IALHJANIGBN && FLDDFKCAIGD && CMJMHHIAACM && !GHHLMAGAGOF && flag)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.DownCornerLeftUp);
		}
		else if (!AKLNMKGKBPE && IALHJANIGBN && DLDMMAHGLHB)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.CornerRightUp);
		}
		else if (!EFEABAPKBBP && IALHJANIGBN && FLDDFKCAIGD)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.CornerLeftUp);
		}
		else if ((KLGNJFKEPKK && !LJCEFANKHBK && CMJMHHIAACM && GHHLMAGAGOF && DLDMMAHGLHB) || (!flag && KLGNJFKEPKK && EACFFPAOFLP(IMOBLFMHKOD + new Vector3(0.5f, -0.5f))))
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.CornerRightDown);
		}
		else if ((GIOOPOKIEOP && !DCAODGJFCLF && CMJMHHIAACM && GHHLMAGAGOF && FLDDFKCAIGD) || (!flag && GIOOPOKIEOP && EACFFPAOFLP(IMOBLFMHKOD + new Vector3(-0.5f, -0.5f))))
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.CornerLeftDown);
		}
		else if (!FLDDFKCAIGD && !IALHJANIGBN)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.LeftUp);
		}
		else if (!DLDMMAHGLHB && !IALHJANIGBN)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.RightUp);
		}
		else if (!IALHJANIGBN)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.Up);
		}
		else if (CMJMHHIAACM && !GHHLMAGAGOF && flag)
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.Down);
		}
		else if (!DLDMMAHGLHB || (!KLGNJFKEPKK && EACFFPAOFLP(IMOBLFMHKOD)) || (DLDMMAHGLHB && !EACFFPAOFLP(IMOBLFMHKOD) && EACFFPAOFLP(IMOBLFMHKOD + new Vector3(0.5f, 0f))))
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.Right);
		}
		else if (!FLDDFKCAIGD || (!GIOOPOKIEOP && EACFFPAOFLP(IMOBLFMHKOD)) || (FLDDFKCAIGD && !EACFFPAOFLP(IMOBLFMHKOD) && EACFFPAOFLP(IMOBLFMHKOD + new Vector3(-0.5f, 0f))))
		{
			GKFIJMIMNPO(IMOBLFMHKOD, cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.Left);
		}
		cHGOBPEDDBJ = GameTileMaps.GGFJGHHHEJC.stoneDetailsPos;
		if (!IALHJANIGBN && AKLNMKGKBPE)
		{
			for (float num = 0.5f; num <= 1.5f; num += 0.5f)
			{
				GKFIJMIMNPO(IMOBLFMHKOD + new Vector3(0f, num), cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.Right);
			}
		}
		else if (!IALHJANIGBN && EFEABAPKBBP)
		{
			for (float num2 = 0.5f; num2 <= 1.5f; num2 += 0.5f)
			{
				GKFIJMIMNPO(IMOBLFMHKOD + new Vector3(0f, num2), cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.Left);
			}
		}
		else if (!IALHJANIGBN && !DLDMMAHGLHB)
		{
			for (float num3 = 0.5f; num3 <= 1f; num3 += 0.5f)
			{
				GKFIJMIMNPO(IMOBLFMHKOD + new Vector3(0f, num3), cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.Right);
			}
		}
		else if (!IALHJANIGBN && !FLDDFKCAIGD)
		{
			for (float num4 = 0.5f; num4 <= 1f; num4 += 0.5f)
			{
				GKFIJMIMNPO(IMOBLFMHKOD + new Vector3(0f, num4), cHGOBPEDDBJ, gCFBMPHOGIA, DetailTileType.Left);
			}
		}
		if (!LBKKDAMMKIE(IMOBLFMHKOD + Vector3.down * 1.5f) && !LBKKDAMMKIE(IMOBLFMHKOD + Vector3.down * 1f) && !LBKKDAMMKIE(IMOBLFMHKOD + Vector3.down * 0.5f) && !LBKKDAMMKIE(IMOBLFMHKOD))
		{
			if (!BGAKHCBGFIO(IMOBLFMHKOD + Vector3.right * 0.5f, PBLLKEKGLPK))
			{
				for (float num5 = 0.5f; num5 <= 2f; num5 += 0.5f)
				{
					if (!BGAKHCBGFIO(IMOBLFMHKOD + new Vector3(0.5f, num5), PBLLKEKGLPK) && !ALNFLFCLIEP(IMOBLFMHKOD + new Vector3(0.5f, num5)) && !ALNFLFCLIEP(IMOBLFMHKOD + new Vector3(0.5f, num5 - 0.5f)))
					{
						decoTile.roofTiles.L.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap, 0.5f, num5);
					}
				}
			}
			if (!BGAKHCBGFIO(IMOBLFMHKOD + Vector3.left * 0.5f, PBLLKEKGLPK))
			{
				for (float num6 = 0.5f; num6 <= 2f; num6 += 0.5f)
				{
					if (!BGAKHCBGFIO(IMOBLFMHKOD + new Vector3(-0.5f, num6), PBLLKEKGLPK) && !ALNFLFCLIEP(IMOBLFMHKOD + new Vector3(-0.5f, num6)) && !ALNFLFCLIEP(IMOBLFMHKOD + new Vector3(-0.5f, num6 - 0.5f)))
					{
						decoTile.roofTiles.R.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap, -0.5f, num6);
					}
				}
			}
		}
		if (BGAKHCBGFIO(IMOBLFMHKOD + Vector3.down * 0.5f, PBLLKEKGLPK) || DNDMDGOHDJD(IMOBLFMHKOD + new Vector3(0f, -2.5f), PBLLKEKGLPK) || DNDMDGOHDJD(IMOBLFMHKOD + new Vector3(-0.5f, -2.5f), PBLLKEKGLPK) || DNDMDGOHDJD(IMOBLFMHKOD + new Vector3(0.5f, -2.5f), PBLLKEKGLPK))
		{
			return;
		}
		if (BGAKHCBGFIO(IMOBLFMHKOD + new Vector3(-0.5f, -0.5f), PBLLKEKGLPK))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, decoTile.roofTiles.LU, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
		}
		else if (BGAKHCBGFIO(IMOBLFMHKOD + new Vector3(0.5f, -0.5f), PBLLKEKGLPK))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, decoTile.roofTiles.RU, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
		}
		else if (!BGAKHCBGFIO(IMOBLFMHKOD + Vector3.down * 2.5f, PBLLKEKGLPK))
		{
			if (EACFFPAOFLP(IMOBLFMHKOD) || KELFJIPHBFP(IMOBLFMHKOD).HasFlag(SpecificType.StairsDown))
			{
				decoTile.roofTiles.U.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			if (!BGAKHCBGFIO(IMOBLFMHKOD + Vector3.left * 0.5f, PBLLKEKGLPK) && !ALNFLFCLIEP(IMOBLFMHKOD + Vector3.left * 0.5f))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(-0.5f, 0f), decoTile.roofTiles.PRU, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else if (!BGAKHCBGFIO(IMOBLFMHKOD + Vector3.right * 0.5f, PBLLKEKGLPK) && !ALNFLFCLIEP(IMOBLFMHKOD + Vector3.right * 0.5f))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0.5f, 0f), decoTile.roofTiles.PLU, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
		}
	}

	private static void ALAOFNEOEMP(WorldTile PLIBNCCNNBK, Vector3 IMOBLFMHKOD, TileType FPFLJNACICI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		switch (FPFLJNACICI)
		{
		case TileType.Floor:
			CGFDNGCAGFL(PLIBNCCNNBK, IMOBLFMHKOD);
			break;
		case TileType.WallBack:
			EMJFNGOHBBF(IMOBLFMHKOD, PLIBNCCNNBK.PBLLKEKGLPK, Utils.FJNKHMPEEKL());
			break;
		case TileType.Roof:
			FBLJHPDFNHI(IMOBLFMHKOD, PLIBNCCNNBK.PBLLKEKGLPK, Utils.FJNKHMPEEKL());
			break;
		}
	}

	public static void EMBBOIKGPDA(Herb GIOOHFKPHPF)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(((Component)GIOOHFKPHPF).transform.position, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.herbs == null)
			{
				ILDEFBIANKO.herbs = new List<Herb>();
			}
			if (!ILDEFBIANKO.herbs.Contains(GIOOHFKPHPF))
			{
				ILDEFBIANKO.herbs.Add(GIOOHFKPHPF);
				KILADDNLCOM(ILDEFBIANKO, ((Component)GIOOHFKPHPF).transform.position);
				MMOHADHAAGD(((Component)GIOOHFKPHPF).transform.position, GroundType.Grass, Location.Road);
			}
		}
	}

	public static List<Vector3> HALEJLJFMLJ(Placeable EAPCLAODGAE, int DFFGLLDDEPN)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<Vector3> enumerable = new HashSet<Vector3>();
		foreach (Vector3 item in EAPCLAODGAE.itemSpace.buildSquares.Select((BuildSquare bs) => bs.GetCentrePosition()))
		{
			enumerable = enumerable.Concat(EHJLDGOIILF(item, DFFGLLDDEPN));
		}
		return enumerable.ToList();
	}

	private static IEnumerator FMNMPGNANJE(TilemapScene PBLLKEKGLPK, Vector3Int[] HAKPCIKJLNM)
	{
		yield return null;
		LOMFGJMEGOG(PBLLKEKGLPK, HAKPCIKJLNM);
	}

	public static Vector3 LOJBKLKMINM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		((Vector3)(ref val)).Set(val.x + 0.25f, val.y + 0.25f, 0f);
		return val;
	}

	private static void OPHJLHHCMML(Vector3Int AIJOOOIJEDC, TileBase ILDEFBIANKO, Tilemap GCFBMPHOGIA, bool AHMDLJCHABI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		GameTileMaps.SetTileAtPosition(AIJOOOIJEDC, ILDEFBIANKO, GCFBMPHOGIA);
		if (AHMDLJCHABI)
		{
			JFPMJHHLHCI = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, 0f), new Vector3(-1f, 1f, 1f));
			GCFBMPHOGIA.SetTransformMatrix(AIJOOOIJEDC, JFPMJHHLHCI);
		}
	}

	public static void NLIPDGCAIEF(Vector3 IMOBLFMHKOD, int NDKJEODFOCA, bool BBHMAKKPFKB = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.decoFloorId = NDKJEODFOCA;
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
			MBDKGAIDBDD(ILDEFBIANKO, IMOBLFMHKOD, ILDEFBIANKO.PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
		}
	}

	private static void GAIJPKBFMHE(WorldTile ILDEFBIANKO, Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, Season EECEKHKAAIH, bool DBCGKFOBNPP = true)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK == (Object)null)
		{
			return;
		}
		if (ILDEFBIANKO.groundType == GroundType.Grass || ILDEFBIANKO.groundType == GroundType.Ground)
		{
			CDEMLICOFOH(IMOBLFMHKOD, EECEKHKAAIH, PBLLKEKGLPK, DBCGKFOBNPP);
		}
		else
		{
			GameTileMaps.GGFJGHHHEJC.RemoveFloorLowerAtPosition(IMOBLFMHKOD, EECEKHKAAIH, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap, DBCGKFOBNPP);
			GameTileMaps.GGFJGHHHEJC.RemoveFloorLowerAtPosition(IMOBLFMHKOD, EECEKHKAAIH, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).darkGroundTilemap, DBCGKFOBNPP);
		}
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			if (GCGNCHFNEBJ(IMOBLFMHKOD + allNeighbours[i].position, out var ILDEFBIANKO2) && (ILDEFBIANKO2.groundType == GroundType.Ground || ILDEFBIANKO2.groundType == GroundType.Grass))
			{
				CDEMLICOFOH(IMOBLFMHKOD + allNeighbours[i].position, EECEKHKAAIH, PBLLKEKGLPK, DBCGKFOBNPP);
			}
		}
	}

	public static List<Placeable> OPLHBJGKKAD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.placeables;
		}
		return null;
	}

	private static void EMJFNGOHBBF(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, int LEHFPICHDFP)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		if ((Application.isPlaying && !EditorGrid.ENFKMBHBBEM(IMOBLFMHKOD)) || PBLLKEKGLPK.location == Location.RoomsMultiplayer || IDLKDLFJDHJ(IMOBLFMHKOD + Vector3.up * 0.5f, PBLLKEKGLPK))
		{
			return;
		}
		IGDJMAEMCLK = EditorActionsDBAccessor.GetDecoTile(LEHFPICHDFP);
		JHPFHCBNIIM(IMOBLFMHKOD, FBOKGEPKBPO: true, LEHFPICHDFP);
		if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f), PBLLKEKGLPK))
		{
			for (float num = 0f; num <= 1.5f; num += 0.5f)
			{
				OPHJLHHCMML(IMOBLFMHKOD + Vector3.up * 0.5f, GameTileMaps.GGFJGHHHEJC.leftEdgesTransform, PBLLKEKGLPK.wallTilemaps.wallBackEdges, 0f, num);
			}
		}
		if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0.5f, 0.5f), PBLLKEKGLPK))
		{
			for (float num2 = 0f; num2 <= 1.5f; num2 += 0.5f)
			{
				OPHJLHHCMML(IMOBLFMHKOD + Vector3.up * 0.5f, GameTileMaps.GGFJGHHHEJC.rightEdgesTransform, PBLLKEKGLPK.wallTilemaps.wallBackEdges, 0f, num2);
			}
		}
		if (!LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(0f, 0.5f)))
		{
			if (LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f)) && IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), PBLLKEKGLPK) && !IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.LD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else if (LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(0.5f, 0.5f)) && IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), PBLLKEKGLPK) && !IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.RD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), PBLLKEKGLPK) && !IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK) && !IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f), PBLLKEKGLPK))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.DPLU, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), PBLLKEKGLPK) && !IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK) && !IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0.5f, 0.5f), PBLLKEKGLPK))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.DPRU, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK) && EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f), PBLLKEKGLPK.GetTilemaps()))
			{
				if (LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f)))
				{
					GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.DoorLUD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
				}
				else
				{
					GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.LUD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
				}
			}
			else if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK) && EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(0.5f, 0.5f), PBLLKEKGLPK.GetTilemaps()))
			{
				if (LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(0.5f, 0.5f)))
				{
					GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.DoorRUD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
				}
				else
				{
					GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.RUD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
				}
			}
			else if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK))
			{
				IGDJMAEMCLK.roofTiles.UD.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap, 0f, 2.5f);
			}
			else if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f), PBLLKEKGLPK))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.LD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else if (IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0.5f, 0.5f), PBLLKEKGLPK))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0f, 2.5f), IGDJMAEMCLK.roofTiles.RD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else
			{
				IGDJMAEMCLK.roofTiles.D.OPHJLHHCMML(IMOBLFMHKOD, PBLLKEKGLPK.wallTilemaps.wallBackTilemap, 0f, 2.5f);
			}
		}
		if (!IDLKDLFJDHJ(IMOBLFMHKOD + Vector3.right * 0.5f, PBLLKEKGLPK) && IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK) && !IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), PBLLKEKGLPK))
		{
			if (LBKKDAMMKIE(IMOBLFMHKOD + Vector3.up * 0.5f))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), IGDJMAEMCLK.roofTiles.DoorL, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), IGDJMAEMCLK.roofTiles.PLUPLD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
		}
		else if (!IDLKDLFJDHJ(IMOBLFMHKOD + Vector3.right * 0.5f, PBLLKEKGLPK) && IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), PBLLKEKGLPK))
		{
			if (LBKKDAMMKIE(IMOBLFMHKOD + Vector3.up * 0.5f))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), IGDJMAEMCLK.roofTiles.DoorLU, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), IGDJMAEMCLK.roofTiles.UPLD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
		}
		else if (!IDLKDLFJDHJ(IMOBLFMHKOD + Vector3.right * 0.5f, PBLLKEKGLPK))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(0.5f, 2.5f), IGDJMAEMCLK.roofTiles.PLD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
		}
		if (!IDLKDLFJDHJ(IMOBLFMHKOD + Vector3.left * 0.5f, PBLLKEKGLPK) && IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), PBLLKEKGLPK) && !IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), PBLLKEKGLPK))
		{
			if (LBKKDAMMKIE(IMOBLFMHKOD + Vector3.up * 0.5f))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), IGDJMAEMCLK.roofTiles.DoorR, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), IGDJMAEMCLK.roofTiles.PRUPRD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
		}
		else if (!IDLKDLFJDHJ(IMOBLFMHKOD + Vector3.left * 0.5f, PBLLKEKGLPK) && IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), PBLLKEKGLPK))
		{
			if (LBKKDAMMKIE(IMOBLFMHKOD + Vector3.up * 0.5f))
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), IGDJMAEMCLK.roofTiles.DoorRU, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
			else
			{
				GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), IGDJMAEMCLK.roofTiles.UPRD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
			}
		}
		else if (!IDLKDLFJDHJ(IMOBLFMHKOD + Vector3.left * 0.5f, PBLLKEKGLPK))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(-0.5f, 2.5f), IGDJMAEMCLK.roofTiles.PRD, PBLLKEKGLPK.wallTilemaps.wallFrontTilemap);
		}
	}

	public static bool ALNFLFCLIEP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.wall;
		}
		return false;
	}

	public static void JHPFHCBNIIM(Vector3 IMOBLFMHKOD, bool FBOKGEPKBPO, int LEHFPICHDFP)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			num = ILDEFBIANKO.decoWallId;
			num2 = ILDEFBIANKO.decoTrimId;
		}
		if (num == 0)
		{
			num = Utils.BCLCKLKGFCL(IMOBLFMHKOD);
		}
		if (Application.isPlaying && !EditorActionsDBAccessor.IsValid())
		{
			return;
		}
		MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(num);
		if (!Application.isPlaying || MIMAGPFCMKH.canAddTrim)
		{
			if (num2 == 0)
			{
				num2 = Utils.BIKIBFJONAO();
			}
			if (num2 > 0 && FBOKGEPKBPO)
			{
				MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(num2);
				for (float num3 = 0f; num3 < (float)MIMAGPFCMKH.tileInfo.numTilesY / 2f; num3 += 0.5f)
				{
					MIMAGPFCMKH.OPHJLHHCMML(IMOBLFMHKOD + Vector3.up * 0.5f, ILDEFBIANKO.PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap, 0f, num3, CHLOMIOHKOI: true, ACENKKNAOMM: false);
				}
			}
		}
		else
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + Vector3.up * 0.5f, null, ILDEFBIANKO.PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap);
		}
		MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(num);
		AIJDIJKOEDE = LBKKDAMMKIE(IMOBLFMHKOD + Vector3.up * 0.5f);
		IBCAAJIJPOB = KELFJIPHBFP(IMOBLFMHKOD) == SpecificType.StairsUp;
		if (AIJDIJKOEDE)
		{
			GBNOFPBPHDC = IPNJBJEMDKF(IMOBLFMHKOD + Vector3.up * 0.5f);
		}
		GFOHLCCLIAM = ILDEFBIANKO.PBLLKEKGLPK;
		for (float num4 = 0f; num4 <= 1.5f; num4 += 0.5f)
		{
			if (!GCGNCHFNEBJ(IMOBLFMHKOD + Vector3.up * (0.5f + num4), out ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD + Vector3.up * (0.5f + num4), GFOHLCCLIAM, SeasonManager.EECEKHKAAIH);
			}
			if (FBOKGEPKBPO)
			{
				if (IBCAAJIJPOB)
				{
					GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + Vector3.up * 0.5f + Vector3.up * num4, null, ILDEFBIANKO.PBLLKEKGLPK.wallTilemaps.wallBackTilemap);
				}
				else if (AIJDIJKOEDE)
				{
					if (num4 < 1.5f)
					{
						GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + Vector3.up * 0.5f + Vector3.up * num4, null, ILDEFBIANKO.PBLLKEKGLPK.wallTilemaps.wallBackTilemap);
					}
					else if (GBNOFPBPHDC is RentedRoomDoor rentedRoomDoor && rentedRoomDoor.rentedRoom.BAKBJEOMLHN && !rentedRoomDoor.rentedRoom.ShouldBeVisible())
					{
						GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + Vector3.up * 2f, GameTileMaps.GGFJGHHHEJC.blackTile, ILDEFBIANKO.PBLLKEKGLPK.wallTilemaps.wallFrontNoColliders);
					}
					else
					{
						MIMAGPFCMKH.OPHJLHHCMML(IMOBLFMHKOD + Vector3.up * 0.5f, ILDEFBIANKO.PBLLKEKGLPK.wallTilemaps.wallFrontNoColliders, 0f, num4, CHLOMIOHKOI: true, ACENKKNAOMM: false);
					}
				}
				else
				{
					MIMAGPFCMKH.OPHJLHHCMML(IMOBLFMHKOD + Vector3.up * 0.5f, ILDEFBIANKO.PBLLKEKGLPK.wallTilemaps.wallBackTilemap, 0f, num4, CHLOMIOHKOI: true, ACENKKNAOMM: false);
				}
				ILDEFBIANKO.wall = true;
			}
			else
			{
				ILDEFBIANKO.wall = false;
			}
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD + Vector3.up * (0.5f + num4));
		}
		if (!AIJDIJKOEDE)
		{
			return;
		}
		Door door = IPNJBJEMDKF(IMOBLFMHKOD + Vector3.up * 0.5f);
		DecorationTile decoTile = EditorActionsDBAccessor.GetDecoTile(LEHFPICHDFP);
		if (door is RentedRoomDoor rentedRoomDoor2)
		{
			if (!rentedRoomDoor2.rentedRoom.ShouldBeVisible() && !rentedRoomDoor2.rentedRoom.BAKBJEOMLHN)
			{
				if (FBOKGEPKBPO)
				{
					decoTile.roofTiles.DBlack.OPHJLHHCMML(IMOBLFMHKOD, GFOHLCCLIAM.wallTilemaps.wallFrontNoColliders, 0f, 2.5f);
				}
			}
			else if (FBOKGEPKBPO)
			{
				decoTile.roofTiles.D.OPHJLHHCMML(IMOBLFMHKOD, GFOHLCCLIAM.wallTilemaps.wallFrontNoColliders, 0f, 2.5f);
			}
		}
		else if (FBOKGEPKBPO)
		{
			decoTile.roofTiles.D.OPHJLHHCMML(IMOBLFMHKOD, GFOHLCCLIAM.wallTilemaps.wallFrontNoColliders, 0f, 2.5f);
		}
		if (!FBOKGEPKBPO && Object.op_Implicit((Object)(object)GFOHLCCLIAM))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + Vector3.up * 2.5f, null, GFOHLCCLIAM.wallTilemaps.wallFrontNoColliders);
		}
	}

	public static bool LNFJICKJDPH(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			TilemapGroup tilemaps = ILDEFBIANKO.PBLLKEKGLPK.GetTilemaps(SeasonManager.EECEKHKAAIH);
			if ((Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.rockGroundTilemap, IMOBLFMHKOD) == (Object)null)
			{
				return false;
			}
			if ((Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.grassAbove, IMOBLFMHKOD) != (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.floorUpperTilemap, IMOBLFMHKOD) != (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.floorLowerTilemap, IMOBLFMHKOD) != (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.darkGrassTilemap, IMOBLFMHKOD) != (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.darkGroundTilemap, IMOBLFMHKOD) != (Object)null || (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(tilemaps.sandTilemap, IMOBLFMHKOD) != (Object)null)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public static int FDELHDADCEN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.herbs != null)
			{
				return ILDEFBIANKO.herbs.Count;
			}
			return 0;
		}
		return 0;
	}

	public static void EBDOCLONJGH(Vector2 IMOBLFMHKOD, Vector2Int KKANDELPDKP, ref HashSet<Vector2> NHINLEILOJO)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		NHINLEILOJO.Clear();
		IAEOEEAEAKE = Utils.MJEACANINDN(IMOBLFMHKOD) - Vector2Int.op_Implicit(KKANDELPDKP / 2) * 0.25f;
		LNLPPNLFODB = IAEOEEAEAKE;
		for (int i = 0; i < ((Vector2Int)(ref KKANDELPDKP)).x; i++)
		{
			for (int j = 0; j < ((Vector2Int)(ref KKANDELPDKP)).y; j++)
			{
				LNLPPNLFODB.x = IAEOEEAEAKE.x + (float)i * 0.25f;
				LNLPPNLFODB.y = IAEOEEAEAKE.y + (float)j * 0.25f;
				NHINLEILOJO.Add(LNLPPNLFODB);
			}
		}
	}

	public static void AKLCFEPBONI(Vector3 IMOBLFMHKOD, Placeable EAPCLAODGAE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out FDILHKBNLGC) && FDILHKBNLGC.placeables != null)
		{
			FDILHKBNLGC.placeables.Remove(EAPCLAODGAE);
		}
		if (Application.isPlaying)
		{
			EAPCLAODGAE.SetCurrentZone(ZoneType.WithoutZone, -1);
		}
	}

	private static void HKCBAGIACCJ(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			if (DNDMDGOHDJD(Vector2.op_Implicit(HAEIAGKNEPC[i])))
			{
				for (float num = 0.5f; num <= 2f; num += 0.5f)
				{
					if (!EJCEAEPNJCA(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(0f, num))))
					{
						MMOHADHAAGD(Vector2.op_Implicit(HAEIAGKNEPC[i] + new Vector2(0f, num)), GroundType.None, Location.Tavern);
					}
				}
			}
			GMPHMEFAIGE(Vector2.op_Implicit(HAEIAGKNEPC[i]), PHPMEOKHAOH: false);
			CFAHJNLAJNK(Vector2.op_Implicit(HAEIAGKNEPC[i]), JBNJGMKBKCB: false);
			GameTileMaps.SetTileAtPosition(Vector2.op_Implicit(HAEIAGKNEPC[i]), null, GameTileMaps.GGFJGHHHEJC.canPlaceObjectsTilemap);
		}
	}

	public static Vector2 FBOAKDONDJD(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2((float)Mathf.FloorToInt(IMOBLFMHKOD.x * 2f), (float)Mathf.FloorToInt(IMOBLFMHKOD.y * 2f));
	}

	public static bool KCJGJHNIPGP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (GCGNCHFNEBJ(IMOBLFMHKOD, out DFDLNIHFKPA))
			{
				return DFDLNIHFKPA.herbs != null;
			}
			return false;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			return false;
		}
	}

	public static float FEBPMEBPFHN(Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(Utils.MJEACANINDN(IMOBLFMHKOD)), out var value))
		{
			return value.cost;
		}
		return 0f;
	}

	public static bool LKBLKCFOEPA(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.farmable;
		}
		return false;
	}

	public static void AIHNKKFLMCM(Vector3 IMOBLFMHKOD, bool LHLHJCDKNHA = false, bool IBCOKMGFPKB = true, bool PIKKACMNOBM = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) || ILDEFBIANKO.placeables == null)
		{
			return;
		}
		List<Placeable> list = new List<Placeable>(ILDEFBIANKO.placeables);
		for (int i = 0; i < list.Count; i++)
		{
			if (!((Object)(object)list[i] == (Object)null) && !((Object)(object)list[i].itemSetup == (Object)null) && list[i].itemSetup.item.savedAsAPlaceable)
			{
				list[i].PickUp(IMOBLFMHKOD, LHLHJCDKNHA, IBCOKMGFPKB, PIKKACMNOBM);
			}
		}
		KGJOKDAJFMN(IMOBLFMHKOD, ILDEFBIANKO);
	}

	private static DetailTilesInfo NDPNPAMAEPC(DetailTileType GIDPJKPNFGK)
	{
		for (int i = 0; i < GameTileMaps.GGFJGHHHEJC.detailTilesInfo.Length; i++)
		{
			if (GameTileMaps.GGFJGHHHEJC.detailTilesInfo[i].detailTileType == GIDPJKPNFGK)
			{
				return GameTileMaps.GGFJGHHHEJC.detailTilesInfo[i];
			}
		}
		return null;
	}

	public static void CGNOAFNBEAO(Tilemap GCFBMPHOGIA, Vector3Int AIJOOOIJEDC, Season EECEKHKAAIH, Season FONLCEPCGEL = Season.Spring)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		ILDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, AIJOOOIJEDC);
		if (!((Object)(object)ILDEFBIANKO == (Object)null))
		{
			if (((Object)ILDEFBIANKO).name.Equals("GrassOLD"))
			{
				GCFBMPHOGIA.SetTile(AIJOOOIJEDC, GameTileMaps.GGFJGHHHEJC.GetSeasonTiles(EECEKHKAAIH).grassTile);
				ILDEFBIANKO = Utils.GCGNCHFNEBJ<TileBase>(GCFBMPHOGIA, AIJOOOIJEDC);
			}
			if (CommonReferences.GGFJGHHHEJC.seasonTilesInfo.seasonTiles.ContainsKey(((Object)ILDEFBIANKO).name))
			{
				Matrix4x4 transformMatrix = GCFBMPHOGIA.GetTransformMatrix(AIJOOOIJEDC);
				AHMDLJCHABI = ((Matrix4x4)(ref transformMatrix)).lossyScale.x == -1f;
				OPHJLHHCMML(AIJOOOIJEDC, CommonReferences.GGFJGHHHEJC.seasonTilesInfo.BGBAACHNHAD(((Object)ILDEFBIANKO).name, Application.isPlaying ? EECEKHKAAIH : FONLCEPCGEL), GCFBMPHOGIA, AHMDLJCHABI);
			}
		}
	}

	public static void NINFDANGANH(Vector3 IMOBLFMHKOD, int NDKJEODFOCA, int CPDKKODHCJM, int GLBPIAAKDCP, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		MMOHADHAAGD(IMOBLFMHKOD, GroundType.Floor, PBLLKEKGLPK);
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out FNPLODPLEMC))
		{
			FNPLODPLEMC.decoFloorId = NDKJEODFOCA;
			FNPLODPLEMC.decoWallId = CPDKKODHCJM;
			FNPLODPLEMC.decoTrimId = GLBPIAAKDCP;
			KILADDNLCOM(FNPLODPLEMC, IMOBLFMHKOD);
			MBDKGAIDBDD(FNPLODPLEMC, IMOBLFMHKOD, PBLLKEKGLPK, Season.Spring);
		}
	}

	public static SpecificType KELFJIPHBFP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		EDBDDLMNNAC = OPLHBJGKKAD(IMOBLFMHKOD);
		if (EDBDDLMNNAC != null)
		{
			EKKIMEKAPHB = SpecificType.None;
			for (int i = 0; i < EDBDDLMNNAC.Count; i++)
			{
				EKKIMEKAPHB |= EDBDDLMNNAC[i].specificRules;
			}
			return EKKIMEKAPHB;
		}
		return SpecificType.None;
	}

	private static void CGFDNGCAGFL(WorldTile PLIBNCCNNBK, Vector3 IMOBLFMHKOD)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)PLIBNCCNNBK.PBLLKEKGLPK == (Object)null))
		{
			if (PLIBNCCNNBK.decoFloorId > 0)
			{
				MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(PLIBNCCNNBK.decoFloorId);
				MIMAGPFCMKH.OPHJLHHCMML(IMOBLFMHKOD, PLIBNCCNNBK.PBLLKEKGLPK.GetTilemaps().floorLowerTilemap);
			}
			PLIBNCCNNBK.groundType = GroundType.Floor;
			PLIBNCCNNBK.wall = false;
			KILADDNLCOM(PLIBNCCNNBK, IMOBLFMHKOD);
			FloorLimitsManager.UpdateFloorLimits(IMOBLFMHKOD, PLIBNCCNNBK.PBLLKEKGLPK);
		}
	}

	public static MaterialType GKAGNKMAJOE(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.decoFloorId > 0)
			{
				MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(ILDEFBIANKO.decoFloorId);
				if ((Object)(object)MIMAGPFCMKH != (Object)null)
				{
					return MIMAGPFCMKH.materialType;
				}
			}
			return ILDEFBIANKO.materialType;
		}
		return MaterialType.None;
	}

	private static IEnumerator PJBJDJKJJMH(TilemapScene PBLLKEKGLPK, Vector3Int[] GEIFPPHMBFI = null)
	{
		yield return null;
		MKLAFNJLOJN(PBLLKEKGLPK, GEIFPPHMBFI);
		PKOHNPPGCEA.Remove(PBLLKEKGLPK.location);
	}

	public static bool NDNAJIEGFNF(Vector3 IMOBLFMHKOD, int MNBNGGHHMBB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) && ILDEFBIANKO.placeables != null)
		{
			for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
			{
				if ((Object)(object)ILDEFBIANKO.placeables[i].itemSetup != (Object)null && Item.MLBOMGHINCA(ILDEFBIANKO.placeables[i].itemSetup.item, null) && ILDEFBIANKO.placeables[i].itemSetup.item.JDJGFAACPFC() == MNBNGGHHMBB)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static bool DNDMDGOHDJD(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		if (!EJCEAEPNJCA(IMOBLFMHKOD, ((Object)(object)PBLLKEKGLPK != (Object)null) ? PBLLKEKGLPK.GetTilemaps() : null))
		{
			return false;
		}
		if (!ALNFLFCLIEP(IMOBLFMHKOD) && ALNFLFCLIEP(IMOBLFMHKOD + new Vector3(0f, 0.5f)))
		{
			return ALNFLFCLIEP(IMOBLFMHKOD + new Vector3(0f, 1f));
		}
		return false;
	}

	public static void BGNCMCKLCOL(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && (Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		Vector2 val = CHCFCJHIKPN[0];
		val.y += 2.5f;
		Vector2 val2 = CHCFCJHIKPN[CHCFCJHIKPN.Count - 1];
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < CHCFCJHIKPN.Count; i++)
		{
			if (tilemapScene.wallTilemaps.wallBackTilemap.HasTile(GMKCOKIDBAH[i]) && GCGNCHFNEBJ(Vector2.op_Implicit(CHCFCJHIKPN[i]), out var ILDEFBIANKO))
			{
				ILDEFBIANKO.wall = false;
				if (ILDEFBIANKO.groundType != GroundType.Floor)
				{
					ILDEFBIANKO.canPlaceObjects = false;
				}
			}
		}
		for (int j = 0; j < Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.buildingTileMaps.Length; j++)
		{
			for (int k = 0; k < CHCFCJHIKPN.Count; k++)
			{
				if (CHCFCJHIKPN[k].y > val.y && CHCFCJHIKPN[k].x > val.x && CHCFCJHIKPN[k].x < val2.x)
				{
					GameTileMaps.SetTileAtPosition(Vector2.op_Implicit(CHCFCJHIKPN[k]), null, Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.buildingTileMaps[j]);
				}
			}
		}
		RentedRoomsManager.UpdateAllRoomVisibilities();
	}

	public static Vector2 PCMIIFEGMHJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		if (!AOPAJANIPDB(IMOBLFMHKOD))
		{
			return Vector2.op_Implicit(IMOBLFMHKOD);
		}
		OLADKFEBMPH = false;
		OCOCKJEJDNM.Clear();
		for (int i = 1; i < 11; i++)
		{
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD - Vector3.one * 0.5f * (float)i));
			AJLJHLHGGBD = Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD + Vector3.one * 0.5f * (float)i));
			for (int j = 0; j <= i * 2; j++)
			{
				OLADKFEBMPH = HCKJMIBJLME(NOLFMLNLJJG, j, OCOCKJEJDNM);
			}
			if (OLADKFEBMPH)
			{
				return Utils.JOJPOKBFANL(OCOCKJEJDNM, Vector2.op_Implicit(IMOBLFMHKOD));
			}
		}
		return Vector2.op_Implicit(IMOBLFMHKOD);
	}

	public static void APIEPIGNINO(Vector3 IMOBLFMHKOD, bool LHLHJCDKNHA = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO) || ILDEFBIANKO.placeables == null)
		{
			return;
		}
		ZoneType zoneType = AGKGGAFFFGM(IMOBLFMHKOD);
		for (int i = 0; i < ILDEFBIANKO.placeables.Count; i++)
		{
			if ((Object)(object)ILDEFBIANKO.placeables[i] != (Object)null && !ILDEFBIANKO.placeables[i].zoneTypeNeeded.HasFlag(zoneType))
			{
				ILDEFBIANKO.placeables[i].PickUp(IMOBLFMHKOD, LHLHJCDKNHA);
			}
		}
		KGJOKDAJFMN(IMOBLFMHKOD, ILDEFBIANKO);
	}

	public static void ODHKJKNHKGB()
	{
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(LPKDBMKFKEA());
	}

	public static void HJOINEHJAHO(Vector3 IMOBLFMHKOD, int FCPJIPBPGFK = 1048576)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.MJEACANINDN(IMOBLFMHKOD);
		KCJIMDFEBBL = Utils.HKOOAGHDKNO<Placeable>(Vector2.op_Implicit(IMOBLFMHKOD), new Vector2(GameTileMaps.GGFJGHHHEJC.nodesColliderX, GameTileMaps.GGFJGHHHEJC.nodesColliderY), (CapsuleDirection2D)1, 0f, 2097152);
		bool flag = true;
		if (LBKKDAMMKIE(IMOBLFMHKOD) && IMOBLFMHKOD.x * 2f % 1f != 0f)
		{
			flag = false;
		}
		else
		{
			for (int i = 0; i < KCJIMDFEBBL.Length; i++)
			{
				if (!KCJIMDFEBBL[i].FHEMHCEAICB && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].itemSpace.manageNodesCost)
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			JGJLNAPPKDJ = Utils.LPONJPMNLLJ(Vector2.op_Implicit(IMOBLFMHKOD), new Vector2(0.3f, 0.2f), (CapsuleDirection2D)1, 0f, FCPJIPBPGFK);
			flag = JGJLNAPPKDJ.Count == 0;
		}
		LMMELLKNMCF(IMOBLFMHKOD, flag);
	}

	public static bool LKBLKCFOEPA(WorldTile JACBKDFOIBH)
	{
		return JACBKDFOIBH.farmable;
	}

	public static bool PIOMBKLPIKB(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.groundType == GroundType.Floor && ILDEFBIANKO.location == Location.Tavern)
			{
				return !ILDEFBIANKO.wall;
			}
			return false;
		}
		return false;
	}

	public static bool PHDPODOGIEB(Vector3 IMOBLFMHKOD)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		JDPIMJBKFOB = FLNFKNEGBOB.PBLLKEKGLPK.GetTilemaps(SeasonManager.EECEKHKAAIH);
		if ((Object)(object)JDPIMJBKFOB.embarcaderoTilemap != (Object)null)
		{
			return Object.op_Implicit((Object)(object)JDPIMJBKFOB.embarcaderoTilemap.GetTile(((GridLayout)JDPIMJBKFOB.embarcaderoTilemap).WorldToCell(IMOBLFMHKOD)));
		}
		return false;
	}

	public static Location HJPCBBGHPDA(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.location;
		}
		return Location.None;
	}

	public static void CLEOLJFAOCP(TilemapScene PBLLKEKGLPK, Vector3Int[] HAKPCIKJLNM)
	{
		if (Object.op_Implicit((Object)(object)GameTileMaps.GGFJGHHHEJC))
		{
			((MonoBehaviour)GameTileMaps.GGFJGHHHEJC).StartCoroutine(FMNMPGNANJE(PBLLKEKGLPK, HAKPCIKJLNM));
		}
	}

	public static void LMMELLKNMCF(Vector3 IMOBLFMHKOD, bool GAKNPAMHAFB, AnimalNPC GGJLNHNAKCF = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Utils.MJEACANINDN(IMOBLFMHKOD);
		if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val)))
		{
			AGKAMKDOPCG = PathNodesManager.pathNodes[Vector2.op_Implicit(val)];
			AGKAMKDOPCG.isFree = GAKNPAMHAFB;
			AGKAMKDOPCG.animalNPC = GGJLNHNAKCF;
			PathNodesManager.pathNodes[Vector2.op_Implicit(val)] = AGKAMKDOPCG;
		}
	}

	public static void MBDKGAIDBDD(WorldTile ILDEFBIANKO, Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, Season EECEKHKAAIH, bool DBCGKFOBNPP = true)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		if (ILDEFBIANKO.groundType == GroundType.Floor && TilemapsInfo.ELHHFNFJIAD(ILDEFBIANKO.location) == InteriorType.Building)
		{
			GAGNJJDLOOB(IMOBLFMHKOD, TileType.Floor, PBLLKEKGLPK);
		}
		else if (ILDEFBIANKO.groundType == GroundType.Grass || ILDEFBIANKO.groundType == GroundType.Ground || ILDEFBIANKO.groundType == GroundType.TilledEarth)
		{
			if (ILDEFBIANKO.groundType == GroundType.Ground)
			{
				GAIJPKBFMHE(ILDEFBIANKO, IMOBLFMHKOD, PBLLKEKGLPK, EECEKHKAAIH, DBCGKFOBNPP);
			}
			else if (ILDEFBIANKO.location == Location.Road)
			{
				GAIJPKBFMHE(ILDEFBIANKO, IMOBLFMHKOD, PBLLKEKGLPK, EECEKHKAAIH, DBCGKFOBNPP);
			}
			CPHOMIBIHNH(ILDEFBIANKO, IMOBLFMHKOD, PBLLKEKGLPK, EECEKHKAAIH, DBCGKFOBNPP);
			NGKOCCACPKF(IMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.GetDarkTile(GroundType.Ground, EECEKHKAAIH, PBLLKEKGLPK), GameTileMaps.GGFJGHHHEJC.GetDarkFilledTile(GroundType.Ground, EECEKHKAAIH, PBLLKEKGLPK), PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).darkGroundTilemap, ILDEFBIANKO.groundType == GroundType.TilledEarth, PDJMAMPNCKP: true);
			NGKOCCACPKF(IMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.GetDarkTile(GroundType.Grass, EECEKHKAAIH, PBLLKEKGLPK), GameTileMaps.GGFJGHHHEJC.GetDarkFilledTile(GroundType.Grass, EECEKHKAAIH, PBLLKEKGLPK), PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).darkGrassTilemap, ILDEFBIANKO.groundType != GroundType.Grass, PDJMAMPNCKP: true);
			if (Object.op_Implicit((Object)(object)PBLLKEKGLPK))
			{
				NGKOCCACPKF(IMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.GetSeasonTiles(EECEKHKAAIH).darkGrass2Tile, GameTileMaps.GGFJGHHHEJC.GetSeasonTiles(EECEKHKAAIH).darkGrass2Filled, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).darkGrass2Tilemap, ILDEFBIANKO.groundType != GroundType.Grass, PDJMAMPNCKP: true);
			}
		}
		else if (ILDEFBIANKO.groundType == GroundType.Stone)
		{
			if (Object.op_Implicit((Object)(object)PBLLKEKGLPK))
			{
				GameTileMaps.GGFJGHHHEJC.RemoveFloorUpperAtPosition(IMOBLFMHKOD, EECEKHKAAIH, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap, DBCGKFOBNPP);
			}
			CKDDIGCJANA(IMOBLFMHKOD);
		}
		else if (ILDEFBIANKO.groundType == GroundType.None)
		{
			if (Object.op_Implicit((Object)(object)ILDEFBIANKO.PBLLKEKGLPK))
			{
				GameTileMaps.GGFJGHHHEJC.RemoveFloorLowerAtPosition(IMOBLFMHKOD, SeasonManager.EECEKHKAAIH, ILDEFBIANKO.PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorLowerTilemap, DBCGKFOBNPP);
				GameTileMaps.GGFJGHHHEJC.RemoveFloorUpperAtPosition(IMOBLFMHKOD, SeasonManager.EECEKHKAAIH, ILDEFBIANKO.PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap, DBCGKFOBNPP);
			}
			if (!ALNFLFCLIEP(IMOBLFMHKOD))
			{
				FADHHLHFGGL(IMOBLFMHKOD, allMovementNodesInTile);
			}
		}
		if (ILDEFBIANKO.groundType == GroundType.Ground || ILDEFBIANKO.groundType == GroundType.TilledEarth)
		{
			CKDDIGCJANA(IMOBLFMHKOD);
		}
		if (ILDEFBIANKO.groundType == GroundType.TilledEarth)
		{
			ILDEFBIANKO.hasSnow = false;
		}
		if (EECEKHKAAIH == Season.Winter)
		{
			if (Object.op_Implicit((Object)(object)PBLLKEKGLPK))
			{
				ONHDGOJOHAH(ILDEFBIANKO, IMOBLFMHKOD, PBLLKEKGLPK, PBLLKEKGLPK.snowTilemaps.snowTilemaps, DBCGKFOBNPP);
			}
			IDGJPDBGHPB(ILDEFBIANKO, IMOBLFMHKOD);
		}
		else if (Object.op_Implicit((Object)(object)PBLLKEKGLPK))
		{
			if (Object.op_Implicit((Object)(object)PBLLKEKGLPK.snowTilemaps.snowDetailTilemap))
			{
				GameTileMaps.GGFJGHHHEJC.RemoveTileAtPosition(IMOBLFMHKOD, PBLLKEKGLPK.snowTilemaps.snowDetailTilemap);
			}
			if (Object.op_Implicit((Object)(object)PBLLKEKGLPK.snowTilemaps.darkSnowTilemap))
			{
				GameTileMaps.GGFJGHHHEJC.RemoveTileAtPosition(IMOBLFMHKOD, PBLLKEKGLPK.snowTilemaps.darkSnowTilemap);
			}
		}
	}

	public static float PCJLCPOEKHM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return PCJLCPOEKHM(IMOBLFMHKOD, OCOCKJEJDNM);
	}

	public static void OPHJLHHCMML(Vector3 IMOBLFMHKOD, Transform CHGOBPEDDBJ, Tilemap GCFBMPHOGIA, float MENBAFNNBFB = 0f, float KPKNCIJFOGM = 0f)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		AAFJOAPNNBA.x = MENBAFNNBFB;
		AAFJOAPNNBA.y = KPKNCIJFOGM;
		OBPOFPDBFFD = Utils.GCGNCHFNEBJ<TileBase>(GameTileMaps.GGFJGHHHEJC.floorBaseTilemap, CHGOBPEDDBJ.position + AAFJOAPNNBA);
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD + new Vector3(MENBAFNNBFB, KPKNCIJFOGM), OBPOFPDBFFD, GCFBMPHOGIA);
	}

	public static void NBMCMFAGPNE(Vector3 IMOBLFMHKOD, GameObject IOBENGJDEHK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(Utils.NKGANMEKDAL(IMOBLFMHKOD), out var ILDEFBIANKO) || ILDEFBIANKO.blockingObjects == null)
		{
			return;
		}
		if (ILDEFBIANKO.blockingObjects.Contains(IOBENGJDEHK))
		{
			ILDEFBIANKO.blockingObjects.Remove(IOBENGJDEHK);
			if (ILDEFBIANKO.blockingObjects.Count == 0)
			{
				ILDEFBIANKO.blockingObjects = null;
			}
		}
		KILADDNLCOM(ILDEFBIANKO, Utils.NKGANMEKDAL(IMOBLFMHKOD));
	}

	public static bool OEMLDFEGIGP(Vector2 DEACEMMGPHA)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (float num = -0.5f; num < 0.6f; num += 0.5f)
		{
			for (float num2 = -0.5f; num2 < 0.6f; num2 += 0.5f)
			{
				if (NCEHFMPBBAK(Vector2.op_Implicit(DEACEMMGPHA + new Vector2(num, num2))) != GroundType.Sand)
				{
					return false;
				}
			}
		}
		return true;
	}

	public static IEnumerator LPKDBMKFKEA()
	{
		yield return null;
		DKEHENLDNAG();
		yield return null;
		yield return null;
		yield return null;
		PDBCPANBFDK();
	}

	public static bool NALIAAMAKAL(Vector3 IMOBLFMHKOD, TilemapGroup IOKGALBEILM)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return (Object)(object)Utils.GCGNCHFNEBJ<TileBase>(IOKGALBEILM.cliffsTilemap, IMOBLFMHKOD) != (Object)null;
	}

	public static float PCJLCPOEKHM(Vector3 IMOBLFMHKOD, List<Vector2> HJAMJLPKACF)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (!AOPAJANIPDB(IMOBLFMHKOD))
		{
			return 0f;
		}
		OLADKFEBMPH = false;
		HJAMJLPKACF.Clear();
		for (int i = 1; i < 11; i++)
		{
			NOLFMLNLJJG = Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD - Vector3.one * 0.5f * (float)i));
			AJLJHLHGGBD = Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD + Vector3.one * 0.5f * (float)i));
			for (int j = 0; j <= i * 2; j++)
			{
				OLADKFEBMPH = HCKJMIBJLME(NOLFMLNLJJG, j, HJAMJLPKACF);
			}
			if (OLADKFEBMPH)
			{
				return Utils.GNFLPFFNALP(HJAMJLPKACF, IMOBLFMHKOD);
			}
		}
		return 10f;
	}

	public static int APJABAKKKGD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			return ILDEFBIANKO.zoneIndex;
		}
		return -1;
	}

	public static T NCDIFOGHKJL<T>(Vector3 IMOBLFMHKOD) where T : MonoBehaviour
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out BKJGMAIMMKD) && BKJGMAIMMKD.placeables != null && BKJGMAIMMKD.placeables.Count > 0)
		{
			for (int i = 0; i < BKJGMAIMMKD.placeables.Count; i++)
			{
				T component = ((Component)BKJGMAIMMKD.placeables[i]).GetComponent<T>();
				if ((Object)(object)component != (Object)null)
				{
					return component;
				}
			}
		}
		return default(T);
	}

	public static bool BGAKHCBGFIO(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.groundType == GroundType.Floor)
			{
				return EditorGrid.ENFKMBHBBEM(IMOBLFMHKOD);
			}
			return false;
		}
		if ((Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.location != Location.Tavern)
		{
			ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD, PBLLKEKGLPK, Season.Spring);
			if (Utils.IELGICCBCHO(KELFJIPHBFP(IMOBLFMHKOD)) && !Utils.IELGICCBCHO(KELFJIPHBFP(IMOBLFMHKOD + new Vector3(0f, 0.5f))))
			{
				return false;
			}
			if (ILDEFBIANKO.groundType == GroundType.Floor)
			{
				return EditorGrid.ENFKMBHBBEM(IMOBLFMHKOD);
			}
			return false;
		}
		return false;
	}

	private static void CPHOMIBIHNH(WorldTile ILDEFBIANKO, Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, Season EECEKHKAAIH, bool DBCGKFOBNPP = true)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK == (Object)null)
		{
			return;
		}
		if (ILDEFBIANKO.groundType == GroundType.Grass)
		{
			KJPGMGCFCHG(IMOBLFMHKOD, EECEKHKAAIH, PBLLKEKGLPK, DBCGKFOBNPP);
		}
		else
		{
			GameTileMaps.GGFJGHHHEJC.RemoveFloorUpperAtPosition(IMOBLFMHKOD, EECEKHKAAIH, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).floorUpperTilemap, DBCGKFOBNPP);
			if (Object.op_Implicit((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).darkGrassTilemap))
			{
				GameTileMaps.GGFJGHHHEJC.RemoveFloorUpperAtPosition(IMOBLFMHKOD, EECEKHKAAIH, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).darkGrassTilemap, DBCGKFOBNPP);
			}
			if (Object.op_Implicit((Object)(object)PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).darkGrass2Tilemap))
			{
				GameTileMaps.GGFJGHHHEJC.RemoveFloorUpperAtPosition(IMOBLFMHKOD, EECEKHKAAIH, PBLLKEKGLPK.GetTilemaps(EECEKHKAAIH).darkGrass2Tilemap, DBCGKFOBNPP);
			}
		}
		for (int i = 0; i < allNeighbours.Length; i++)
		{
			if (NCEHFMPBBAK(IMOBLFMHKOD + allNeighbours[i].position) == GroundType.Grass)
			{
				KJPGMGCFCHG(IMOBLFMHKOD + allNeighbours[i].position, EECEKHKAAIH, PBLLKEKGLPK, DBCGKFOBNPP);
			}
		}
	}

	public static void GMPHMEFAIGE(Vector3 IMOBLFMHKOD, bool PHPMEOKHAOH)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.wall = PHPMEOKHAOH;
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		}
	}

	public static bool DJLHADMPGBK(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.MJEACANINDN(IMOBLFMHKOD);
		if (PathNodesManager.pathNodes.TryGetValue(Vector2.op_Implicit(IMOBLFMHKOD), out var value))
		{
			if (!value.isFree)
			{
				return Object.op_Implicit((Object)(object)value.animalNPC);
			}
			return true;
		}
		return false;
	}

	public static void NDPILMNDCDK(Vector3 IMOBLFMHKOD, ZoneType GIBJPCAFCJB, int LMJDICEAONP = -1, bool EIPNNOCMLFN = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.zoneType = GIBJPCAFCJB;
			ILDEFBIANKO.zoneIndex = LMJDICEAONP;
			GameTileMaps.GGFJGHHHEJC.UpdateZonesVisual(IMOBLFMHKOD, ILDEFBIANKO, Object.op_Implicit((Object)(object)ILDEFBIANKO.PBLLKEKGLPK) ? ILDEFBIANKO.PBLLKEKGLPK.commonTilemaps : null);
			KILADDNLCOM(ILDEFBIANKO, IMOBLFMHKOD);
		}
	}

	public static void OCNNHIIJLPD(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK, int NDKJEODFOCA, int CPDKKODHCJM, int GLBPIAAKDCP, bool OEBNHGNJEJL = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out GDNAJLJNMDB))
		{
			GDNAJLJNMDB = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(IMOBLFMHKOD, PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
		}
		Vector3 val;
		if (OEBNHGNJEJL)
		{
			val = IMOBLFMHKOD;
			Debug.Log((object)("Tavern Floor at " + ((object)(Vector3)(ref val)).ToString() + " " + NDKJEODFOCA));
		}
		GDNAJLJNMDB.groundType = GroundType.Floor;
		GDNAJLJNMDB.decoFloorId = NDKJEODFOCA;
		GDNAJLJNMDB.decoWallId = CPDKKODHCJM;
		GDNAJLJNMDB.decoTrimId = GLBPIAAKDCP;
		if (OEBNHGNJEJL)
		{
			string[] obj = new string[6]
			{
				"Set ground type: ",
				GDNAJLJNMDB.groundType.ToString(),
				" at ",
				null,
				null,
				null
			};
			val = IMOBLFMHKOD;
			obj[3] = ((object)(Vector3)(ref val)).ToString();
			obj[4] = " decoFloorId: ";
			obj[5] = NDKJEODFOCA.ToString();
			Debug.Log((object)string.Concat(obj));
		}
		KILADDNLCOM(GDNAJLJNMDB, IMOBLFMHKOD);
		MBDKGAIDBDD(GDNAJLJNMDB, IMOBLFMHKOD, PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
	}

	public static int PNKHEBBCGMG(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying)
		{
			if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
			{
				return ILDEFBIANKO.decoTrimId;
			}
			return 0;
		}
		return EditorActionsDBAccessor.GetDecoTrimId(IMOBLFMHKOD, PBLLKEKGLPK);
	}

	public static void CFAHJNLAJNK(Vector3 IMOBLFMHKOD, bool JBNJGMKBKCB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(Utils.NKGANMEKDAL(IMOBLFMHKOD), out var ILDEFBIANKO))
		{
			ILDEFBIANKO.canPlaceObjects = JBNJGMKBKCB;
			KILADDNLCOM(ILDEFBIANKO, Utils.NKGANMEKDAL(IMOBLFMHKOD));
		}
	}

	public static JapaneseDoor AHINHLBFBDE(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out var ILDEFBIANKO))
		{
			if (ILDEFBIANKO.door is JapaneseDoor)
			{
				return ILDEFBIANKO.door as JapaneseDoor;
			}
			return null;
		}
		return null;
	}

	private static IEnumerator ANNECNINAAM()
	{
		yield return null;
		yield return null;
		TimerHelper timer = new TimerHelper();
		while (CPAECKJKLIP.Count > 0)
		{
			for (int i = 0; i < allMovementNodesInTile.Length; i++)
			{
				HJOINEHJAHO(CPAECKJKLIP.First() + allMovementNodesInTile[i]);
			}
			CPAECKJKLIP.Remove(CPAECKJKLIP.First());
			if (timer.GetMillisecs() > 50f)
			{
				timer.Reset();
				yield return null;
			}
		}
		ILPCCJHHPKF = null;
	}

	public static void IGFNOCNEHCO(Vector3 FCMMFDIGFMB, int GLBPIAAKDCP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(FCMMFDIGFMB, out var ILDEFBIANKO))
		{
			ILDEFBIANKO.decoTrimId = GLBPIAAKDCP;
			KILADDNLCOM(ILDEFBIANKO, FCMMFDIGFMB);
			MBDKGAIDBDD(ILDEFBIANKO, FCMMFDIGFMB, ILDEFBIANKO.PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
		}
		if (GCGNCHFNEBJ(FCMMFDIGFMB + new Vector3(0f, -0.5f), out ILDEFBIANKO))
		{
			ILDEFBIANKO.decoTrimId = GLBPIAAKDCP;
			KILADDNLCOM(ILDEFBIANKO, FCMMFDIGFMB + new Vector3(0f, -0.5f));
			MBDKGAIDBDD(ILDEFBIANKO, FCMMFDIGFMB + new Vector3(0f, -0.5f), ILDEFBIANKO.PBLLKEKGLPK, SeasonManager.EECEKHKAAIH);
		}
	}

	public static bool AOPAJANIPDB(Vector3 IMOBLFMHKOD, bool JKCGPNFINFP = true)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out FLNFKNEGBOB) && (Object)(object)FLNFKNEGBOB.PBLLKEKGLPK != (Object)null)
		{
			MINKCADCPBP = FLNFKNEGBOB.PBLLKEKGLPK.commonTilemaps;
			JDPIMJBKFOB = FLNFKNEGBOB.PBLLKEKGLPK.GetTilemaps(SeasonManager.EECEKHKAAIH);
			if (MINKCADCPBP.anyWaterTilemap != null && MINKCADCPBP.anyWaterTilemap.Length != 0)
			{
				for (int i = 0; i < MINKCADCPBP.anyWaterTilemap.Length; i++)
				{
					if ((Object)(object)MINKCADCPBP.anyWaterTilemap[i] != (Object)null && !((Object)(object)MINKCADCPBP.anyWaterTilemap[i].GetTile(((GridLayout)MINKCADCPBP.anyWaterTilemap[i]).WorldToCell(IMOBLFMHKOD)) == (Object)null) && (!JKCGPNFINFP || !PHDPODOGIEB(IMOBLFMHKOD)))
					{
						return true;
					}
				}
				return false;
			}
			if ((Object)(object)JDPIMJBKFOB.waterUpTilemap != (Object)null)
			{
				if (JKCGPNFINFP && PHDPODOGIEB(IMOBLFMHKOD))
				{
					return false;
				}
				return (Object)(object)JDPIMJBKFOB.waterUpTilemap.GetTile(((GridLayout)JDPIMJBKFOB.waterUpTilemap).WorldToCell(IMOBLFMHKOD)) != (Object)null;
			}
			return false;
		}
		return false;
	}
}
