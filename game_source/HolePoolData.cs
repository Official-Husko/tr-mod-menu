using System;
using UnityEngine;

public static class HolePoolData
{
	private static ItemInHole[] IOKCMFLOOIJ;

	public static ItemInHole[] PHNKKAHPIAO
	{
		get
		{
			if (IOKCMFLOOIJ == null)
			{
				DLOFMECJBEM();
			}
			return IOKCMFLOOIJ;
		}
	}

	private static void DLOFMECJBEM()
	{
		HolePoolItemDataSO holePoolItemDataSO = Resources.Load<HolePoolItemDataSO>("HolePoolData");
		if ((Object)(object)holePoolItemDataSO == (Object)null)
		{
			Debug.LogError((object)"[HolePoolData] No se encontró el HolePoolItemDataSO");
			IOKCMFLOOIJ = Array.Empty<ItemInHole>();
		}
		else
		{
			IOKCMFLOOIJ = holePoolItemDataSO.items;
		}
	}
}
