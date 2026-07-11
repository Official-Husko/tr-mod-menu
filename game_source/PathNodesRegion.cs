using System;
using System.Collections.Generic;
using UnityEngine;

public class PathNodesRegion : MonoBehaviour
{
	public TilemapScene tilemapScene;

	public List<Vector2> pathNodes;

	public void OnDrawGizmosSelected()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 0.05f);
		}
	}

	public void AIAOPGGJANA()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.DEHAEGBNDLK(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).KGNIEGOBNLD();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.IAMBLEDHGDM().floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.BNMLDAPCNKF(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 1; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -86) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void MKPLEIIIPBN()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.DEHAEGBNDLK(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).OGCGOLDBINN();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.BNMLDAPCNKF(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.EMHLLEFBBCO(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -117) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void IGNKOMGJBFH()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 105f);
		}
	}

	public void GGJCOLOBAAP()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 995f);
		}
	}

	public void IKPOMGCNGEM()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CDIAPLHDNMN(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).CCIIDGGKLJH();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.OEMIKEDPIKP().floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.EMHLLEFBBCO(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -103) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void KMPHCDIDOMK()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1500f);
		}
	}

	public void NILMNAMNMEC()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.DAHNICOIBFM(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).NHNNCCOCDAO();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.OEMIKEDPIKP(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.GetTilemaps().floorLowerTilemap).CellToWorld(current));
				for (int i = 1; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 68) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void BDFGOKODMNK()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.FAGOELIBOPF(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).ELACKEEINFN();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.IAMBLEDHGDM(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.FGKDPLDANOA(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 48) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void NPCJEOMKLDJ()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1713f);
		}
	}

	public void FLKDBLADAAB()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1881f);
		}
	}

	public void KOHJHIHKAHM()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CDIAPLHDNMN(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).FDOBHNJBBAB();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.GetTilemaps().floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.BNMLDAPCNKF(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -77) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void MLNKGLDMPFB()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CDIAPLHDNMN(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).MCHBJMPPLJL();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.KIMMMFKFCEK().floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.EMHLLEFBBCO(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 1; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 72) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void GAMNBIOJAPL()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.GetPathNodesData(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).OKPIDPELELJ();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.EMHLLEFBBCO(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.OEMIKEDPIKP(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -32) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void KLECGNJABCN()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 193f);
		}
	}

	public void PKPLIGMIODE()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.FAGOELIBOPF(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).FMDKPMMILGC();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.IAMBLEDHGDM(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.EMHLLEFBBCO().floorLowerTilemap).CellToWorld(current));
				for (int i = 1; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -56) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void EABMDPHLJDE()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.DEHAEGBNDLK(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).NHNNCCOCDAO();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.FGKDPLDANOA(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.KIMMMFKFCEK(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 1; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 6) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void JIIFJJFHBBN()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1638f);
		}
	}

	public void GetPathNodesRegions()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.GetPathNodesData(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).OEJJGDMKIDN();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.GetTilemaps().floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.GetTilemaps().floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void CGAGHPAAFHC()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1920f);
		}
	}

	public void FCFHPOIGLNK()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1272f);
		}
	}

	public void PNJDCGMOGHB()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 731f);
		}
	}

	public void JOBDOKMNOBF()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1355f);
		}
	}

	public void JGENHBNDMMB()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.DEHAEGBNDLK(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).JJNDBDDGCLM();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.FGKDPLDANOA(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.EMHLLEFBBCO().floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -42) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void CJPEOMOMFHL()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 185f);
		}
	}

	public void FOLMJKLMEHM()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.FAGOELIBOPF(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).NHNNCCOCDAO();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.OEMIKEDPIKP(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.BNMLDAPCNKF().floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i++)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 114) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void EAPPNBLCDLC()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CDIAPLHDNMN(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).OKMMAAELKHB();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.GetTilemaps().floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.KIMMMFKFCEK().floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 121) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void AGKPBDMEHKC()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1806f);
		}
	}

	public void MGLFLPAMIAA()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 459f);
		}
	}

	public void AGKHELBOLHL()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1075f);
		}
	}

	public void OBIHPDCLAHJ()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.GetPathNodesData(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).OEJJGDMKIDN();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.EMHLLEFBBCO(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.GetTilemaps(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 15) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void HJBBDNJKPNL()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1052f);
		}
	}

	public void HLKGJPGIJPD()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.DEHAEGBNDLK(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).BOGEAHCDGAJ();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.EMHLLEFBBCO(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.KIMMMFKFCEK(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 1; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -53) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void EILPKBNFCIF()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 1863f);
		}
	}

	public void BMGIOJBFICG()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (pathNodes == null)
		{
			return;
		}
		foreach (Vector2 pathNode in pathNodes)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(Vector2.op_Implicit(pathNode), 151f);
		}
	}

	public void PLEEKKLNEHB()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.DAHNICOIBFM(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).MCCMPKPGKJE();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.EMHLLEFBBCO(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.FGKDPLDANOA(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 1; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 79) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void AFGFFBANNFD()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.FAGOELIBOPF(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).JKMOILEBMOG();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.OEMIKEDPIKP(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.EMHLLEFBBCO(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 72) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void MGCKMILMFJJ()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.FAGOELIBOPF(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).HPMAICHFHCG();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.IAMBLEDHGDM(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.FGKDPLDANOA(Season.Summer).floorLowerTilemap).CellToWorld(current));
				for (int i = 1; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), -119) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public void HONKHKJNPGP()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		PathNodesManager.CDIAPLHDNMN(tilemapScene.location, (tilemapScene is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1)).HPMAICHFHCG();
		pathNodes = new List<Vector2>();
		BoundsInt cellBounds = tilemapScene.KIMMMFKFCEK(Season.Summer).floorLowerTilemap.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				Vector3 val = Utils.MJEACANINDN(((GridLayout)tilemapScene.IAMBLEDHGDM().floorLowerTilemap).CellToWorld(current));
				for (int i = 0; i < WorldGrid.allMovementNodesInTile.Length; i += 0)
				{
					if (PathNodesManager.pathNodes.ContainsKey(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])) && (Object)(object)Utils.KJOMDMEIAEJ<PathNodesRegion>(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]), 115) == (Object)(object)this && !pathNodes.Contains(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i])))
					{
						pathNodes.Add(Vector2.op_Implicit(val + WorldGrid.allMovementNodesInTile[i]));
					}
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}
}
