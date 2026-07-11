using System.Collections.Generic;

public static class WeightedRandom
{
	public static BlockerType ICBIHJHDNHN(List<BlockerChance> GMIHPAMNJOD)
	{
		int num = ProceduralMine.NextRandom(0, 100);
		int num2 = 0;
		foreach (BlockerChance item in GMIHPAMNJOD)
		{
			num2 += item.weight;
			if (num < num2)
			{
				return item.type;
			}
		}
		return BlockerType.None;
	}
}
