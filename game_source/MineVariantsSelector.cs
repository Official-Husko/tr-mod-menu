using System.Collections.Generic;
using UnityEngine;

public static class MineVariantsSelector
{
	private static readonly Dictionary<int, List<int>> BPNEFPELPLF = new Dictionary<int, List<int>>();

	public static void DHMBKGALAFC(MinePiece[] LINDLHCADGA)
	{
		BPNEFPELPLF.Clear();
		foreach (MinePiece minePiece in LINDLHCADGA)
		{
			BPNEFPELPLF[minePiece.JBCFIHPKMLF] = JBDKDBCIEMK(minePiece.variantObjects.Length);
		}
	}

	public static int CIBLIEJHFOC(MinePiece FLMCIFNEJKH, int FBMEHDFBBOO, HashSet<int> HKJOCNDGBDA = null)
	{
		if (!BPNEFPELPLF.TryGetValue(FLMCIFNEJKH.JBCFIHPKMLF, out var value))
		{
			value = JBDKDBCIEMK(FBMEHDFBBOO);
			BPNEFPELPLF[FLMCIFNEJKH.JBCFIHPKMLF] = value;
		}
		if (value.Count == 0)
		{
			value.AddRange(JBDKDBCIEMK(FBMEHDFBBOO));
		}
		List<int> list = value;
		if (HKJOCNDGBDA != null && HKJOCNDGBDA.Count > 0)
		{
			list = new List<int>();
			for (int i = 0; i < value.Count; i++)
			{
				if (!HKJOCNDGBDA.Contains(value[i]))
				{
					list.Add(value[i]);
				}
			}
			if (list.Count == 0)
			{
				Debug.LogWarning((object)$"[MineVariantsSelector] All variants excluded for piece {FLMCIFNEJKH.JBCFIHPKMLF}. Regenerating pool.");
				value.Clear();
				value.AddRange(JBDKDBCIEMK(FBMEHDFBBOO));
				list = new List<int>();
				for (int j = 0; j < value.Count; j++)
				{
					if (!HKJOCNDGBDA.Contains(value[j]))
					{
						list.Add(value[j]);
					}
				}
				if (list.Count == 0)
				{
					Debug.LogError((object)$"[MineVariantsSelector] No valid variants available for piece {FLMCIFNEJKH.JBCFIHPKMLF} after full pool regeneration.");
					return 0;
				}
			}
		}
		int index = ProceduralMine.NextRandom(0, list.Count);
		int num = list[index];
		value.Remove(num);
		return num;
	}

	private static List<int> JBDKDBCIEMK(int FBMEHDFBBOO)
	{
		List<int> list = new List<int>(FBMEHDFBBOO);
		for (int i = 0; i < FBMEHDFBBOO; i++)
		{
			list.Add(i);
		}
		return list;
	}
}
