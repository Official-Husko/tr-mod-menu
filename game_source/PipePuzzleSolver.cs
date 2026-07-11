using System.Collections.Generic;
using UnityEngine;

public static class PipePuzzleSolver
{
	private static readonly PipeExits[] MLGDEGPDEGL = new PipeExits[4]
	{
		PipeExits.North,
		PipeExits.East,
		PipeExits.South,
		PipeExits.West
	};

	public static List<PipeExits> KPLCIAOABGL(int MOFKEDGAOEE, int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		List<PipeExits> list = new List<PipeExits>();
		int num = MOFKEDGAOEE % ICEFODMHMJL;
		int num2 = MOFKEDGAOEE / ICEFODMHMJL;
		if (num2 == 0)
		{
			list.Add(PipeExits.North);
		}
		if (num2 == OBJJDEOCAGF - 1)
		{
			list.Add(PipeExits.South);
		}
		if (num == 0)
		{
			list.Add(PipeExits.West);
		}
		if (num == ICEFODMHMJL - 1)
		{
			list.Add(PipeExits.East);
		}
		return list;
	}

	public static bool GMMPFJEIMLJ(int MOFKEDGAOEE, int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		int num = MOFKEDGAOEE % ICEFODMHMJL;
		int num2 = MOFKEDGAOEE / ICEFODMHMJL;
		if (num != 0 && num != ICEFODMHMJL - 1 && num2 != 0)
		{
			return num2 == OBJJDEOCAGF - 1;
		}
		return true;
	}

	public static int BFLMOOKAFCL(int MOFKEDGAOEE, PipeExits FCGBJEIIMBC, int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		int num = MOFKEDGAOEE % ICEFODMHMJL;
		int num2 = MOFKEDGAOEE / ICEFODMHMJL;
		int num3 = num;
		int num4 = num2;
		switch (FCGBJEIIMBC)
		{
		case PipeExits.North:
			num4--;
			break;
		case PipeExits.South:
			num4++;
			break;
		case PipeExits.East:
			num3++;
			break;
		case PipeExits.West:
			num3--;
			break;
		}
		if (num3 < 0 || num3 >= ICEFODMHMJL || num4 < 0 || num4 >= OBJJDEOCAGF)
		{
			return -1;
		}
		return num4 * ICEFODMHMJL + num3;
	}

	public static int PHDGBDIKIPD(PipeTileInstance[] PACELDKFOLH, PipeTileInstance[] OPBJJDKJPKF)
	{
		if (PACELDKFOLH == null || OPBJJDKJPKF == null || PACELDKFOLH.Length != OPBJJDKJPKF.Length)
		{
			return 0;
		}
		int num = OPBJJDKJPKF.Length;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < num; i++)
		{
			if (OPBJJDKJPKF[i] != null)
			{
				dictionary[OPBJJDKJPKF[i].instanceId] = i;
			}
		}
		int[] array = new int[num];
		for (int j = 0; j < num; j++)
		{
			if (PACELDKFOLH[j] != null && dictionary.TryGetValue(PACELDKFOLH[j].instanceId, out var value))
			{
				array[j] = value;
			}
			else
			{
				array[j] = j;
			}
		}
		int num2 = 0;
		for (int k = 0; k < num - 1; k++)
		{
			for (int l = k + 1; l < num; l++)
			{
				if (array[k] > array[l])
				{
					num2++;
				}
			}
		}
		return num2;
	}

	public static bool FODOIPLNAGI(PipeTileInstance[] DIOHHJIJBBF, int ICEFODMHMJL, int OBJJDEOCAGF, int IPPCBFDIFFM, PipeExits MAMACMHPCHD, int GLNFJLJAAGJ, PipeExits FIHKPNFOPPN)
	{
		if (DIOHHJIJBBF == null)
		{
			return false;
		}
		if (DIOHHJIJBBF[GLNFJLJAAGJ] == null || (Object)(object)DIOHHJIJBBF[GLNFJLJAAGJ].tile == (Object)null || !DIOHHJIJBBF[GLNFJLJAAGJ].tile.BIIHOAPHDFM(FIHKPNFOPPN))
		{
			return false;
		}
		return OJEEGNIKKOD(DIOHHJIJBBF, ICEFODMHMJL, OBJJDEOCAGF, IPPCBFDIFFM, MAMACMHPCHD).Contains(GLNFJLJAAGJ);
	}

	public static Dictionary<int, PipeExits> BNHAMGEJGNK(PipeTileInstance[] DIOHHJIJBBF, PipePuzzleData IKJGJONMALC)
	{
		Dictionary<int, PipeExits> dictionary = new Dictionary<int, PipeExits>();
		if (DIOHHJIJBBF == null || DIOHHJIJBBF.Length != IKJGJONMALC.gridWidth * IKJGJONMALC.gridHeight)
		{
			return dictionary;
		}
		int entryCell = IKJGJONMALC.entryCell;
		PipeExits entryDirection = IKJGJONMALC.entryDirection;
		if (DIOHHJIJBBF[entryCell] == null || (Object)(object)DIOHHJIJBBF[entryCell].tile == (Object)null || !DIOHHJIJBBF[entryCell].tile.BIIHOAPHDFM(entryDirection))
		{
			return dictionary;
		}
		dictionary[entryCell] = entryDirection;
		Queue<int> queue = new Queue<int>();
		queue.Enqueue(entryCell);
		while (queue.Count > 0)
		{
			int num = queue.Dequeue();
			PipeTile pipeTile = DIOHHJIJBBF[num]?.tile;
			if ((Object)(object)pipeTile == (Object)null)
			{
				continue;
			}
			PipeExits[] mLGDEGPDEGL = MLGDEGPDEGL;
			foreach (PipeExits fCGBJEIIMBC in mLGDEGPDEGL)
			{
				if (!pipeTile.BIIHOAPHDFM(fCGBJEIIMBC))
				{
					continue;
				}
				int num2 = BFLMOOKAFCL(num, fCGBJEIIMBC, IKJGJONMALC.gridWidth, IKJGJONMALC.gridHeight);
				if (num2 >= 0 && !dictionary.ContainsKey(num2))
				{
					PipeTile pipeTile2 = DIOHHJIJBBF[num2]?.tile;
					if (!((Object)(object)pipeTile2 == (Object)null) && pipeTile2.BIIHOAPHDFM(PipeTile.CBJIEPEGKGD(fCGBJEIIMBC)))
					{
						dictionary[num2] = PipeTile.CBJIEPEGKGD(fCGBJEIIMBC);
						queue.Enqueue(num2);
					}
				}
			}
		}
		return dictionary;
	}

	public static HashSet<int> OJEEGNIKKOD(PipeTileInstance[] DIOHHJIJBBF, int ICEFODMHMJL, int OBJJDEOCAGF, int IPPCBFDIFFM, PipeExits MAMACMHPCHD)
	{
		HashSet<int> hashSet = new HashSet<int>();
		if (DIOHHJIJBBF == null || DIOHHJIJBBF.Length != ICEFODMHMJL * OBJJDEOCAGF)
		{
			return hashSet;
		}
		if (DIOHHJIJBBF[IPPCBFDIFFM] == null || (Object)(object)DIOHHJIJBBF[IPPCBFDIFFM].tile == (Object)null || !DIOHHJIJBBF[IPPCBFDIFFM].tile.BIIHOAPHDFM(MAMACMHPCHD))
		{
			return hashSet;
		}
		Queue<int> queue = new Queue<int>();
		queue.Enqueue(IPPCBFDIFFM);
		hashSet.Add(IPPCBFDIFFM);
		while (queue.Count > 0)
		{
			int num = queue.Dequeue();
			PipeTile pipeTile = DIOHHJIJBBF[num]?.tile;
			if ((Object)(object)pipeTile == (Object)null)
			{
				continue;
			}
			PipeExits[] mLGDEGPDEGL = MLGDEGPDEGL;
			foreach (PipeExits fCGBJEIIMBC in mLGDEGPDEGL)
			{
				if (!pipeTile.BIIHOAPHDFM(fCGBJEIIMBC))
				{
					continue;
				}
				int num2 = BFLMOOKAFCL(num, fCGBJEIIMBC, ICEFODMHMJL, OBJJDEOCAGF);
				if (num2 >= 0 && !hashSet.Contains(num2))
				{
					PipeTile pipeTile2 = DIOHHJIJBBF[num2]?.tile;
					if (!((Object)(object)pipeTile2 == (Object)null) && pipeTile2.BIIHOAPHDFM(PipeTile.CBJIEPEGKGD(fCGBJEIIMBC)))
					{
						hashSet.Add(num2);
						queue.Enqueue(num2);
					}
				}
			}
		}
		return hashSet;
	}

	public static bool FODOIPLNAGI(PipeTileInstance[] EOAONHNCDDO, PipePuzzleData IKJGJONMALC)
	{
		if (!FODOIPLNAGI(EOAONHNCDDO, IKJGJONMALC.gridWidth, IKJGJONMALC.gridHeight, IKJGJONMALC.entryCell, IKJGJONMALC.entryDirection, IKJGJONMALC.exitCell, IKJGJONMALC.exitDirection))
		{
			return false;
		}
		if (IKJGJONMALC.requiredTilesCount == 0)
		{
			return true;
		}
		HashSet<int> lHDPADCJAAJ = OJEEGNIKKOD(EOAONHNCDDO, IKJGJONMALC);
		HashSet<int> hashSet = JEHAPJHEDKI(EOAONHNCDDO, lHDPADCJAAJ);
		for (int i = 0; i < EOAONHNCDDO.Length; i++)
		{
			if (EOAONHNCDDO[i] != null && EOAONHNCDDO[i].isRequired && !hashSet.Contains(EOAONHNCDDO[i].instanceId))
			{
				return false;
			}
		}
		return true;
	}

	public static List<(int index, PipeExits flowFrom)> BJIMNEJEPIM(PipeTileInstance[] DIOHHJIJBBF, PipePuzzleData IKJGJONMALC)
	{
		List<(int, PipeExits)> list = new List<(int, PipeExits)>();
		HashSet<int> hashSet = new HashSet<int>();
		if (DIOHHJIJBBF == null || DIOHHJIJBBF.Length != IKJGJONMALC.gridWidth * IKJGJONMALC.gridHeight)
		{
			return list;
		}
		int entryCell = IKJGJONMALC.entryCell;
		PipeExits entryDirection = IKJGJONMALC.entryDirection;
		if (DIOHHJIJBBF[entryCell] == null || (Object)(object)DIOHHJIJBBF[entryCell].tile == (Object)null || !DIOHHJIJBBF[entryCell].tile.BIIHOAPHDFM(entryDirection))
		{
			return list;
		}
		Queue<(int, PipeExits)> queue = new Queue<(int, PipeExits)>();
		queue.Enqueue((entryCell, entryDirection));
		hashSet.Add(entryCell);
		while (queue.Count > 0)
		{
			var (num, item) = queue.Dequeue();
			list.Add((num, item));
			PipeTile pipeTile = DIOHHJIJBBF[num]?.tile;
			if ((Object)(object)pipeTile == (Object)null)
			{
				continue;
			}
			PipeExits[] mLGDEGPDEGL = MLGDEGPDEGL;
			foreach (PipeExits fCGBJEIIMBC in mLGDEGPDEGL)
			{
				if (!pipeTile.BIIHOAPHDFM(fCGBJEIIMBC))
				{
					continue;
				}
				int num2 = BFLMOOKAFCL(num, fCGBJEIIMBC, IKJGJONMALC.gridWidth, IKJGJONMALC.gridHeight);
				if (num2 >= 0 && !hashSet.Contains(num2))
				{
					PipeTile pipeTile2 = DIOHHJIJBBF[num2]?.tile;
					if (!((Object)(object)pipeTile2 == (Object)null) && pipeTile2.BIIHOAPHDFM(PipeTile.CBJIEPEGKGD(fCGBJEIIMBC)))
					{
						hashSet.Add(num2);
						queue.Enqueue((num2, PipeTile.CBJIEPEGKGD(fCGBJEIIMBC)));
					}
				}
			}
		}
		return list;
	}

	public static HashSet<int> JEHAPJHEDKI(PipeTileInstance[] DIOHHJIJBBF, HashSet<int> LHDPADCJAAJ)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (int item in LHDPADCJAAJ)
		{
			if (DIOHHJIJBBF[item] != null)
			{
				hashSet.Add(DIOHHJIJBBF[item].instanceId);
			}
		}
		return hashSet;
	}

	public static HashSet<int> OJEEGNIKKOD(PipeTileInstance[] EOAONHNCDDO, PipePuzzleData IKJGJONMALC)
	{
		return OJEEGNIKKOD(EOAONHNCDDO, IKJGJONMALC.gridWidth, IKJGJONMALC.gridHeight, IKJGJONMALC.entryCell, IKJGJONMALC.entryDirection);
	}
}
