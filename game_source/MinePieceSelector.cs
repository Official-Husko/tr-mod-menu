using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class MinePieceSelector
{
	public static Dictionary<Vector2Int, MineBlock> BLJKCCPDBFI => ProceduralMine.GGFJGHHHEJC.allBlocks;

	public static Vector2Int PCLPCLNLJPG => ProceduralMine.GGFJGHHHEJC.blockSize;

	public static List<OpenedPath> AOIFNIBEGJD => ProceduralMine.GGFJGHHHEJC.openedPaths;

	public static MinePiece MFECIFINPPH(OpenedPath AEFGHKEGDDG, MinePiece[] LINDLHCADGA, bool NKEMALMMOBL)
	{
		Direction fCGBJEIIMBC = Utils.ABNPPDOGEPM(AEFGHKEGDDG.direction);
		for (int i = 0; i < LINDLHCADGA.Length; i++)
		{
			for (int j = 0; j < LINDLHCADGA[i].blocks.Length; j++)
			{
				if (LINDLHCADGA[i].blocks[j].PCMGMMMGKOH(fCGBJEIIMBC) && NNPPGEBNLNB(LINDLHCADGA[i], j, AEFGHKEGDDG, NKEMALMMOBL))
				{
					return LINDLHCADGA[i];
				}
			}
		}
		return null;
	}

	public static MinePiece OGGPMJDMBPB(OpenedPath AEFGHKEGDDG, List<MinePiece> LINDLHCADGA, bool NKEMALMMOBL)
	{
		List<MinePiece> list = GODFDLAEEJD(AEFGHKEGDDG, LINDLHCADGA, NKEMALMMOBL);
		if (list.Count > 0)
		{
			int index = ProceduralMine.NextRandom(0, list.Count);
			return list[index];
		}
		return MFECIFINPPH(AEFGHKEGDDG, LINDLHCADGA.ToArray(), NKEMALMMOBL);
	}

	private static List<MinePiece> GODFDLAEEJD(OpenedPath AEFGHKEGDDG, List<MinePiece> LINDLHCADGA, bool NKEMALMMOBL)
	{
		Direction fCGBJEIIMBC = Utils.ABNPPDOGEPM(AEFGHKEGDDG.direction);
		List<MinePiece> list = new List<MinePiece>();
		for (int i = 0; i < LINDLHCADGA.Count; i++)
		{
			if ((ProceduralMine.MaximumBlocksReached() && !ProceduralMine.MinimumClosedRoomsReached() && !NKEMALMMOBL && (LINDLHCADGA[i].GetNumberOfOpenedPaths() < 3 || ((Vector2Int)(ref LINDLHCADGA[i].pieceSize)).x > 1 || ((Vector2Int)(ref LINDLHCADGA[i].pieceSize)).y > 1)) || (!NKEMALMMOBL && AOIFNIBEGJD.Count + LINDLHCADGA[i].GetNumberOfOpenedPaths() - 2 > ((Vector2Int)(ref ProceduralMine.GGFJGHHHEJC.closedRoomsNumber)).y))
			{
				continue;
			}
			for (int j = 0; j < LINDLHCADGA[i].blocks.Length; j++)
			{
				if (LINDLHCADGA[i].blocks[j].PCMGMMMGKOH(fCGBJEIIMBC) && NNPPGEBNLNB(LINDLHCADGA[i], j, AEFGHKEGDDG, NKEMALMMOBL))
				{
					list.Add(LINDLHCADGA[i]);
				}
			}
		}
		return list;
	}

	private static bool EEBHLPNKKPL(MineBlock OKMHACFGCPG, Vector2Int IMOBLFMHKOD, Direction FCGBJEIIMBC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Vector2Int key = IMOBLFMHKOD + Utils.NLFDOFAOJHP(FCGBJEIIMBC) * PCLPCLNLJPG;
		if (BLJKCCPDBFI.ContainsKey(key) && !OKMHACFGCPG.PCMGMMMGKOH(FCGBJEIIMBC) && BLJKCCPDBFI[key].PCMGMMMGKOH(Utils.ABNPPDOGEPM(FCGBJEIIMBC)))
		{
			return false;
		}
		return true;
	}

	public static MinePiece IGFKEFKNPEN(OpenedPath AEFGHKEGDDG, bool ANCMKNOJCHI, bool LKJAEPHJFCL, bool CCOKPOELAMA)
	{
		List<MinePiece> list = null;
		if (!ANCMKNOJCHI)
		{
			list = GODFDLAEEJD(AEFGHKEGDDG, ProceduralMine.GGFJGHHHEJC.notClosingPiecesPrefabs, NKEMALMMOBL: false);
		}
		if (list == null || list.Count == 0)
		{
			list = GODFDLAEEJD(AEFGHKEGDDG, ProceduralMine.GGFJGHHHEJC.closingPiecesPrefabs, NKEMALMMOBL: true);
		}
		list = list?.Where((MinePiece p) => !p.uniquePiece || !ProceduralMine.GGFJGHHHEJC.GGLMNONGICJ.Contains(p.JBCFIHPKMLF)).ToList();
		return NDNMCCKEEFP(list, LKJAEPHJFCL);
	}

	private static MinePiece NDNMCCKEEFP(List<MinePiece> PEELOJCFGIE, bool LKJAEPHJFCL)
	{
		if (PEELOJCFGIE != null && PEELOJCFGIE.Count > 0)
		{
			if (!LKJAEPHJFCL)
			{
				return PEELOJCFGIE[ProceduralMine.NextRandom(0, PEELOJCFGIE.Count)];
			}
			int num = 0;
			for (int i = 0; i < PEELOJCFGIE.Count; i++)
			{
				num += PEELOJCFGIE[i].rarity;
			}
			int num2 = ProceduralMine.NextRandom(0, num);
			num = 0;
			for (int j = 0; j < PEELOJCFGIE.Count; j++)
			{
				num += PEELOJCFGIE[j].rarity;
				if (num2 < num)
				{
					return PEELOJCFGIE[j];
				}
			}
		}
		return null;
	}

	public static bool NNPPGEBNLNB(MinePiece AAHMGBKHKBI, int OOCEAJBHDLH, OpenedPath AEFGHKEGDDG, bool NKEMALMMOBL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		Vector2Int val = AEFGHKEGDDG.block.CJGAMLEMBNL() + Utils.NLFDOFAOJHP(AEFGHKEGDDG.direction) * PCLPCLNLJPG;
		Vector2Int val2 = val - AAHMGBKHKBI.blocks[OOCEAJBHDLH].position * PCLPCLNLJPG;
		int num = 0;
		for (int i = 0; i < AAHMGBKHKBI.blocks.Length; i++)
		{
			val = val2 + AAHMGBKHKBI.blocks[i].position * PCLPCLNLJPG;
			if (BLJKCCPDBFI.ContainsKey(val))
			{
				return false;
			}
			for (int j = 0; j < AAHMGBKHKBI.blocks[i].openedPaths.Length; j++)
			{
				Vector2Int key = val + Utils.NLFDOFAOJHP(AAHMGBKHKBI.blocks[i].openedPaths[j].direction) * PCLPCLNLJPG;
				if (BLJKCCPDBFI.ContainsKey(key))
				{
					if (!BLJKCCPDBFI[key].PCMGMMMGKOH(Utils.ABNPPDOGEPM(AAHMGBKHKBI.blocks[i].openedPaths[j].direction)))
					{
						return false;
					}
					num++;
				}
			}
			if (IDIPOKDIHML(AAHMGBKHKBI, AAHMGBKHKBI.blocks[i], val))
			{
				return false;
			}
		}
		if (!NKEMALMMOBL && AOIFNIBEGJD.Count + 2 - num <= 0)
		{
			return false;
		}
		return true;
	}

	private static bool IDIPOKDIHML(MinePiece AAHMGBKHKBI, MineBlock OKMHACFGCPG, Vector2Int KEPHPMFIDDD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if (((Vector2Int)(ref OKMHACFGCPG.position)).x == 0 && !EEBHLPNKKPL(OKMHACFGCPG, KEPHPMFIDDD, Direction.Left))
		{
			return true;
		}
		if (((Vector2Int)(ref OKMHACFGCPG.position)).x == ((Vector2Int)(ref AAHMGBKHKBI.pieceSize)).x - 1 && !EEBHLPNKKPL(OKMHACFGCPG, KEPHPMFIDDD, Direction.Right))
		{
			return true;
		}
		if (((Vector2Int)(ref OKMHACFGCPG.position)).y == 0 && !EEBHLPNKKPL(OKMHACFGCPG, KEPHPMFIDDD, Direction.Down))
		{
			return true;
		}
		if (((Vector2Int)(ref OKMHACFGCPG.position)).y == ((Vector2Int)(ref AAHMGBKHKBI.pieceSize)).y - 1 && !EEBHLPNKKPL(OKMHACFGCPG, KEPHPMFIDDD, Direction.Up))
		{
			return true;
		}
		return false;
	}
}
