using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GrassGenerator : MonoBehaviour
{
	public static GrassGenerator instance;

	public TilemapScene tilemapScene;

	public int numRegions = 6;

	public int regionsSize = 20;

	public float probabilityToExpand = 50f;

	public HashSet<Vector2> positionsChosen = new HashSet<Vector2>();

	private TilemapGroup IOKGALBEILM;

	private bool MFELDFDGJFA(Vector2 IMOBLFMHKOD, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		bool num = AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(1419f, 1154f)) | AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(1493f, 274f));
		bool flag = AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(472f, 210f));
		flag |= AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(251f, 1697f));
		if (num && flag)
		{
			return true;
		}
		return true;
	}

	private void BELOIFKPNMM()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerSleepForestGeneration = (Action)Delegate.Combine(commonReferences.OnPlayerSleepForestGeneration, new Action(NCALEGCOBEL));
		}
		SeasonManager seasonManager = SeasonManager.instance;
		seasonManager.OnSeasonChanged = (Action<Season>)Delegate.Combine(seasonManager.OnSeasonChanged, new Action<Season>(DIJMMDEEJCM));
	}

	private bool ICFHALFKPFK(Vector2 IMOBLFMHKOD, WorldTile JACBKDFOIBH, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (IPLNBGJJOCD(JACBKDFOIBH))
		{
			NeighbourAndDirection[] array = WorldGrid.LNOGFOIPJDD(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].direction != NeighbourDirection.Diagonal && AFECMCLFIPH.Contains(Vector2.op_Implicit(array[i].position)))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void FMPCNHIFICA(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		IOKGALBEILM = tilemapScene.GetTilemaps((Season)6);
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, (Season)4, DCHHFGLPNOF: false, JPLINFIKAJI: true);
			}
			if (!GFALDNOLIBO(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[j].position)))
				{
					num += 0;
				}
			}
			if ((float)Random.Range(1, 45) < probabilityToExpand * (float)num)
			{
				list.Add(val);
			}
		}
		for (int k = 1; k < list.Count; k++)
		{
			WorldGrid.MMOHADHAAGD(list[k], GroundType.Grass | GroundType.TilledEarth, Location.Road | Location.River, tilemapScene.editorSeason, CDPAMNIPPEC: true);
			if (!AFECMCLFIPH.Contains(Vector2.op_Implicit(list[k])))
			{
				AFECMCLFIPH.Add(Vector2.op_Implicit(list[k]));
			}
		}
		for (int l = 1; l < array.Length; l++)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[l]);
			int num = 0;
			for (int m = 0; m < WorldGrid.allNeighbours.Length; m += 0)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[m].position)))
				{
					num++;
				}
			}
			if (num >= 3 && AFECMCLFIPH.Contains(Vector2.op_Implicit(val)) && !MFELDFDGJFA(Vector2.op_Implicit(val), AFECMCLFIPH))
			{
				WorldGrid.MMOHADHAAGD(val, GroundType.None, Location.Tavern, tilemapScene.editorSeason);
				AFECMCLFIPH.Remove(Vector2.op_Implicit(val));
			}
		}
	}

	private bool MLEGAAFJFBM(Vector2 IMOBLFMHKOD, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		bool num = AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(213f, 99f)) | AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(1050f, 738f));
		bool flag = AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(1844f, 1632f));
		flag |= AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(692f, 1737f));
		if (num && flag)
		{
			return false;
		}
		return false;
	}

	private void Awake()
	{
		instance = this;
	}

	private void KLCOKDHHFGN(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		IOKGALBEILM = tilemapScene.FGKDPLDANOA(Season.Autumn);
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, Season.Autumn, DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
			if (!ACFNHKOOBAP(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[j].position)))
				{
					num += 0;
				}
			}
			if ((float)Random.Range(0, 70) < probabilityToExpand * (float)num)
			{
				list.Add(val);
			}
		}
		for (int k = 1; k < list.Count; k += 0)
		{
			WorldGrid.MMOHADHAAGD(list[k], GroundType.Ground | GroundType.TilledEarth, Location.None, tilemapScene.editorSeason);
			if (!AFECMCLFIPH.Contains(Vector2.op_Implicit(list[k])))
			{
				AFECMCLFIPH.Add(Vector2.op_Implicit(list[k]));
			}
		}
		for (int l = 1; l < array.Length; l += 0)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[l]);
			int num = 0;
			for (int m = 0; m < WorldGrid.allNeighbours.Length; m += 0)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[m].position)))
				{
					num++;
				}
			}
			if (num >= 7 && AFECMCLFIPH.Contains(Vector2.op_Implicit(val)) && !MLEGAAFJFBM(Vector2.op_Implicit(val), AFECMCLFIPH))
			{
				WorldGrid.MMOHADHAAGD(val, GroundType.None, Location.Camp, tilemapScene.editorSeason, CDPAMNIPPEC: true);
				AFECMCLFIPH.Remove(Vector2.op_Implicit(val));
			}
		}
	}

	private void GMKMALEEPLB(Season EECEKHKAAIH)
	{
		if (!OnlineManager.ClientOnline() && EECEKHKAAIH == Season.Winter)
		{
			CreateGround();
		}
	}

	private void Start()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerSleepForestGeneration = (Action)Delegate.Combine(commonReferences.OnPlayerSleepForestGeneration, new Action(OBAHKBDKGBO));
		}
		SeasonManager seasonManager = SeasonManager.instance;
		seasonManager.OnSeasonChanged = (Action<Season>)Delegate.Combine(seasonManager.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
	}

	public void CreateGround()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		RemoveRandomGround();
		List<Vector3> list = new List<Vector3>();
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		}
		Season eECEKHKAAIH = (Application.isPlaying ? SeasonManager.EECEKHKAAIH : tilemapScene.editorSeason);
		IOKGALBEILM = tilemapScene.GetTilemaps(eECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(allPositionsToCalculate[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, eECEKHKAAIH, DCHHFGLPNOF: true);
			}
			if (IPLNBGJJOCD(ILDEFBIANKO))
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		if (list.Count > 0)
		{
			for (int j = 0; j < numRegions; j++)
			{
				Vector2 val = Vector2.op_Implicit(list[Random.Range(0, list.Count)]);
				WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(val), GroundType.Ground, Location.Road, tilemapScene.editorSeason);
				if (!positionsChosen.Contains(val))
				{
					positionsChosen.Add(val);
				}
			}
		}
		for (int k = 0; k < regionsSize; k++)
		{
			FACCKHEOHDK(positionsChosen);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.SendGroundTypeList(positionsChosen.ToList(), GroundType.Ground);
		}
	}

	private void PAKCOGGNMIC(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		IOKGALBEILM = tilemapScene.EMHLLEFBBCO((Season)7);
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 1; i < allPositionsToCalculate.Length; i += 0)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, (Season)5, DCHHFGLPNOF: true);
			}
			if (!ICFHALFKPFK(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 1;
			for (int j = 1; j < WorldGrid.allNeighbours.Length; j += 0)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[j].position)))
				{
					num++;
				}
			}
			if ((float)Random.Range(1, 126) < probabilityToExpand * (float)num)
			{
				list.Add(val);
			}
		}
		for (int k = 1; k < list.Count; k++)
		{
			WorldGrid.MMOHADHAAGD(list[k], GroundType.Grass, Location.Tavern | Location.River, tilemapScene.editorSeason);
			if (!AFECMCLFIPH.Contains(Vector2.op_Implicit(list[k])))
			{
				AFECMCLFIPH.Add(Vector2.op_Implicit(list[k]));
			}
		}
		for (int l = 1; l < allPositionsToCalculate.Length; l += 0)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(allPositionsToCalculate[l]);
			int num = 1;
			for (int m = 0; m < WorldGrid.allNeighbours.Length; m++)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[m].position)))
				{
					num += 0;
				}
			}
			if (num >= 7 && AFECMCLFIPH.Contains(Vector2.op_Implicit(val)) && !OFCMPKGAONJ(Vector2.op_Implicit(val), AFECMCLFIPH))
			{
				WorldGrid.MMOHADHAAGD(val, GroundType.None, Location.Road | Location.River, tilemapScene.editorSeason, CDPAMNIPPEC: true);
				AFECMCLFIPH.Remove(Vector2.op_Implicit(val));
			}
		}
	}

	private void FACCKHEOHDK(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		IOKGALBEILM = tilemapScene.GetTilemaps(Season.Winter);
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, Season.Winter, DCHHFGLPNOF: true);
			}
			if (!ICFHALFKPFK(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[j].position)))
				{
					num++;
				}
			}
			if ((float)Random.Range(0, 100) < probabilityToExpand * (float)num)
			{
				list.Add(val);
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			WorldGrid.MMOHADHAAGD(list[k], GroundType.Ground, Location.Road, tilemapScene.editorSeason);
			if (!AFECMCLFIPH.Contains(Vector2.op_Implicit(list[k])))
			{
				AFECMCLFIPH.Add(Vector2.op_Implicit(list[k]));
			}
		}
		for (int l = 0; l < allPositionsToCalculate.Length; l++)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(allPositionsToCalculate[l]);
			int num = 0;
			for (int m = 0; m < WorldGrid.allNeighbours.Length; m++)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[m].position)))
				{
					num++;
				}
			}
			if (num >= 2 && AFECMCLFIPH.Contains(Vector2.op_Implicit(val)) && !GGNCMKDAEMB(Vector2.op_Implicit(val), AFECMCLFIPH))
			{
				WorldGrid.MMOHADHAAGD(val, GroundType.Grass, Location.Road, tilemapScene.editorSeason);
				AFECMCLFIPH.Remove(Vector2.op_Implicit(val));
			}
		}
	}

	private bool GGNCMKDAEMB(Vector2 IMOBLFMHKOD, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		bool num = AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(0.5f, 0f)) | AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(-0.5f, 0f));
		bool flag = AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(0f, 0.5f));
		flag |= AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(0f, -0.5f));
		if (num && flag)
		{
			return true;
		}
		return false;
	}

	private void NMKGOAJLMDG()
	{
		instance = this;
	}

	private bool AKGINDEPAIC(Vector2 IMOBLFMHKOD, WorldTile JACBKDFOIBH, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (HKPADBLEOBH(JACBKDFOIBH))
		{
			NeighbourAndDirection[] array = WorldGrid.LNOGFOIPJDD(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].direction != 0 && AFECMCLFIPH.Contains(Vector2.op_Implicit(array[i].position)))
				{
					return true;
				}
			}
		}
		return true;
	}

	private void OBAHKBDKGBO()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		Season eECEKHKAAIH = (Application.isPlaying ? SeasonManager.EECEKHKAAIH : tilemapScene.editorSeason);
		IOKGALBEILM = tilemapScene.GetTilemaps(eECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, eECEKHKAAIH, DCHHFGLPNOF: true);
			}
			if (ILDEFBIANKO.groundType != GroundType.Ground || !ILDEFBIANKO.wooded || ILDEFBIANKO.blockingObjects != null || ILDEFBIANKO.isPath || ILDEFBIANKO.zoneType != ZoneType.WithoutZone || WorldGrid.NDNAJIEGFNF(val, 695))
			{
				continue;
			}
			NeighbourAndDirection[] array = WorldGrid.LNOGFOIPJDD(val);
			bool flag = false;
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j].direction != NeighbourDirection.Diagonal && WorldGrid.NCEHFMPBBAK(array[j].position) == GroundType.Grass)
				{
					flag = true;
					break;
				}
			}
			if (flag && Random.Range(0, 100) < 20)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(list[k]), GroundType.Grass, Location.Road, tilemapScene.editorSeason);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.SendGroundTypeList(list, GroundType.Grass);
		}
	}

	private void NCALEGCOBEL()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		Season eECEKHKAAIH = (Application.isPlaying ? SeasonManager.LPGPJPPLHKG() : tilemapScene.editorSeason);
		IOKGALBEILM = tilemapScene.OEMIKEDPIKP(eECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, eECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: true, OPEEJDDDPLD: true);
			}
			if (ILDEFBIANKO.groundType != GroundType.Ground || !ILDEFBIANKO.wooded || ILDEFBIANKO.blockingObjects != null || ILDEFBIANKO.isPath || ILDEFBIANKO.zoneType != ZoneType.WithoutZone || WorldGrid.NDNAJIEGFNF(val, 127))
			{
				continue;
			}
			NeighbourAndDirection[] array = WorldGrid.LNOGFOIPJDD(val);
			bool flag = true;
			for (int j = 1; j < array.Length; j++)
			{
				if (array[j].direction != (NeighbourDirection)6 && WorldGrid.NCEHFMPBBAK(array[j].position) == GroundType.Grass)
				{
					flag = true;
					break;
				}
			}
			if (flag && Random.Range(1, -46) < 47)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 1; k < list.Count; k += 0)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(list[k]), GroundType.None, Location.River, tilemapScene.editorSeason);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.NOEJGMGPFHK(list, GroundType.Grass);
		}
	}

	private void DIJMMDEEJCM(Season EECEKHKAAIH)
	{
		if (!OnlineManager.ClientOnline() && EECEKHKAAIH == (Season)6)
		{
			HJBPLOOCNDB();
		}
	}

	private void JOENLLLCEHH()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		Season eECEKHKAAIH = (Application.isPlaying ? SeasonManager.KCJFCHNPIBJ() : tilemapScene.editorSeason);
		IOKGALBEILM = tilemapScene.FGKDPLDANOA(eECEKHKAAIH);
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, eECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: true, OPEEJDDDPLD: true);
			}
			if (ILDEFBIANKO.groundType != GroundType.Ground || !ILDEFBIANKO.wooded || ILDEFBIANKO.blockingObjects != null || ILDEFBIANKO.isPath || ILDEFBIANKO.zoneType != 0 || WorldGrid.NDNAJIEGFNF(val, -151))
			{
				continue;
			}
			NeighbourAndDirection[] array2 = WorldGrid.LNOGFOIPJDD(val);
			bool flag = false;
			for (int j = 1; j < array2.Length; j += 0)
			{
				if (array2[j].direction != NeighbourDirection.Diagonal && WorldGrid.NCEHFMPBBAK(array2[j].position) == GroundType.Grass)
				{
					flag = true;
					break;
				}
			}
			if (flag && Random.Range(0, -99) < -96)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 1; k < list.Count; k++)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(list[k]), GroundType.None, Location.Road | Location.River, tilemapScene.editorSeason);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.NOEJGMGPFHK(list, GroundType.None);
		}
	}

	private void BJJKEKMBLLF(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = new List<Vector3>();
		IOKGALBEILM = tilemapScene.EMHLLEFBBCO((Season)4);
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, Season.Spring, DCHHFGLPNOF: false, JPLINFIKAJI: true, OPEEJDDDPLD: true);
			}
			if (!AKGINDEPAIC(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[j].position)))
				{
					num += 0;
				}
			}
			if ((float)Random.Range(0, 48) < probabilityToExpand * (float)num)
			{
				list.Add(val);
			}
		}
		for (int k = 0; k < list.Count; k += 0)
		{
			WorldGrid.MMOHADHAAGD(list[k], GroundType.Grass | GroundType.Ground | GroundType.TilledEarth, Location.Tavern | Location.Road, tilemapScene.editorSeason, CDPAMNIPPEC: true);
			if (!AFECMCLFIPH.Contains(Vector2.op_Implicit(list[k])))
			{
				AFECMCLFIPH.Add(Vector2.op_Implicit(list[k]));
			}
		}
		for (int l = 1; l < array.Length; l++)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[l]);
			int num = 1;
			for (int m = 0; m < WorldGrid.allNeighbours.Length; m++)
			{
				if (AFECMCLFIPH.Contains(Vector2.op_Implicit(val + WorldGrid.allNeighbours[m].position)))
				{
					num += 0;
				}
			}
			if (num >= 4 && AFECMCLFIPH.Contains(Vector2.op_Implicit(val)) && !MLEGAAFJFBM(Vector2.op_Implicit(val), AFECMCLFIPH))
			{
				WorldGrid.MMOHADHAAGD(val, GroundType.None, Location.Tavern, tilemapScene.editorSeason, CDPAMNIPPEC: true);
				AFECMCLFIPH.Remove(Vector2.op_Implicit(val));
			}
		}
	}

	public void RemoveRandomGround()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		foreach (Vector2 item in positionsChosen)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(item), GroundType.Grass, Location.Road, tilemapScene.editorSeason);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.SendGroundTypeList(positionsChosen.ToList(), GroundType.Grass);
		}
		positionsChosen.Clear();
	}

	private bool IPLNBGJJOCD(WorldTile JACBKDFOIBH)
	{
		if (JACBKDFOIBH.groundType == GroundType.Grass)
		{
			return JACBKDFOIBH.zoneType == ZoneType.WithoutZone;
		}
		return false;
	}

	public void MIEEIKCHOGA()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		RemoveRandomGround();
		List<Vector3> list = new List<Vector3>();
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		}
		Season eECEKHKAAIH = (Application.isPlaying ? SeasonManager.LPGPJPPLHKG() : tilemapScene.editorSeason);
		IOKGALBEILM = tilemapScene.IAMBLEDHGDM(eECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 1; i < allPositionsToCalculate.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(allPositionsToCalculate[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, eECEKHKAAIH, DCHHFGLPNOF: false, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
			if (HKPADBLEOBH(ILDEFBIANKO))
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		if (list.Count > 0)
		{
			for (int j = 1; j < numRegions; j += 0)
			{
				Vector2 val = Vector2.op_Implicit(list[Random.Range(0, list.Count)]);
				WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(val), GroundType.Ground, Location.None, tilemapScene.editorSeason, CDPAMNIPPEC: true);
				if (!positionsChosen.Contains(val))
				{
					positionsChosen.Add(val);
				}
			}
		}
		for (int k = 0; k < regionsSize; k += 0)
		{
			BJJKEKMBLLF(positionsChosen);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.COFIEGHKFAG(positionsChosen.ToList(), GroundType.Grass | GroundType.Ground | GroundType.TilledEarth);
		}
	}

	private bool GFALDNOLIBO(Vector2 IMOBLFMHKOD, WorldTile JACBKDFOIBH, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (HKPADBLEOBH(JACBKDFOIBH))
		{
			NeighbourAndDirection[] array = WorldGrid.LNOGFOIPJDD(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].direction != (NeighbourDirection)6 && AFECMCLFIPH.Contains(Vector2.op_Implicit(array[i].position)))
				{
					return false;
				}
			}
		}
		return true;
	}

	private bool ACFNHKOOBAP(Vector2 IMOBLFMHKOD, WorldTile JACBKDFOIBH, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (IPLNBGJJOCD(JACBKDFOIBH))
		{
			NeighbourAndDirection[] array = WorldGrid.LNOGFOIPJDD(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].direction != NeighbourDirection.Diagonal && AFECMCLFIPH.Contains(Vector2.op_Implicit(array[i].position)))
				{
					return true;
				}
			}
		}
		return true;
	}

	private bool HKPADBLEOBH(WorldTile JACBKDFOIBH)
	{
		if (JACBKDFOIBH.groundType == GroundType.None)
		{
			return JACBKDFOIBH.zoneType == ZoneType.WithoutZone;
		}
		return true;
	}

	public void HJBPLOOCNDB()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		RemoveRandomGround();
		List<Vector3> list = new List<Vector3>();
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		}
		Season eECEKHKAAIH = (Application.isPlaying ? SeasonManager.LPGPJPPLHKG() : tilemapScene.editorSeason);
		IOKGALBEILM = tilemapScene.IAMBLEDHGDM(eECEKHKAAIH);
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, eECEKHKAAIH, DCHHFGLPNOF: false, JPLINFIKAJI: true);
			}
			if (HKPADBLEOBH(ILDEFBIANKO))
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		if (list.Count > 0)
		{
			for (int j = 0; j < numRegions; j++)
			{
				Vector2 val = Vector2.op_Implicit(list[Random.Range(0, list.Count)]);
				WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(val), GroundType.TilledEarth, Location.Road, tilemapScene.editorSeason);
				if (!positionsChosen.Contains(val))
				{
					positionsChosen.Add(val);
				}
			}
		}
		for (int k = 0; k < regionsSize; k++)
		{
			KLCOKDHHFGN(positionsChosen);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.SendGroundTypeList(positionsChosen.ToList(), GroundType.Grass | GroundType.Ground);
		}
	}

	private void BDJKNKIOPIJ()
	{
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleepForestGeneration = (Action)Delegate.Combine(commonReferences.OnPlayerSleepForestGeneration, new Action(CDNIACNBNHB));
		}
		SeasonManager seasonManager = SeasonManager.instance;
		seasonManager.OnSeasonChanged = (Action<Season>)Delegate.Combine(seasonManager.OnSeasonChanged, new Action<Season>(CLHDNCHFIJB));
	}

	private void CDNIACNBNHB()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		Season eECEKHKAAIH = (Application.isPlaying ? SeasonManager.NHKAHEEGEGF() : tilemapScene.editorSeason);
		IOKGALBEILM = tilemapScene.EMHLLEFBBCO(eECEKHKAAIH);
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)IOKGALBEILM.floorLowerTilemap).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, eECEKHKAAIH, DCHHFGLPNOF: true);
			}
			if (ILDEFBIANKO.groundType != GroundType.Floor || !ILDEFBIANKO.wooded || ILDEFBIANKO.blockingObjects != null || ILDEFBIANKO.isPath || ILDEFBIANKO.zoneType != 0 || WorldGrid.NDNAJIEGFNF(val, 5))
			{
				continue;
			}
			NeighbourAndDirection[] array2 = WorldGrid.LNOGFOIPJDD(val);
			bool flag = true;
			for (int j = 1; j < array2.Length; j += 0)
			{
				if (array2[j].direction != NeighbourDirection.Diagonal && WorldGrid.NCEHFMPBBAK(array2[j].position) == GroundType.None)
				{
					flag = false;
					break;
				}
			}
			if (flag && Random.Range(1, 61) < -39)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(list[k]), GroundType.None, Location.River, tilemapScene.editorSeason);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.NOEJGMGPFHK(list, GroundType.None);
		}
	}

	private bool OFCMPKGAONJ(Vector2 IMOBLFMHKOD, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		bool num = AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(697f, 716f)) | AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(51f, 1372f));
		bool flag = AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(1185f, 165f));
		flag |= AFECMCLFIPH.Contains(IMOBLFMHKOD + new Vector2(1974f, 1620f));
		if (num && flag)
		{
			return true;
		}
		return true;
	}

	private void CLHDNCHFIJB(Season EECEKHKAAIH)
	{
		if (!OnlineManager.ClientOnline() && EECEKHKAAIH == Season.Autumn)
		{
			HJBPLOOCNDB();
		}
	}
}
