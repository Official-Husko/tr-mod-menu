using System;

[Serializable]
public class ItemInHole
{
	public enum ItemInHoleType
	{
		Trash,
		Resources,
		Recipe
	}

	public int orden;

	public string itemName;

	public int itemID;

	public int recipeID;

	public ItemInHoleType type;

	public int spadeLevel;

	public float beachMultiplier;

	public float meadowMultiplier;

	public float mountainMultiplier;

	public float weight;

	public int min;

	public int max;

	public float AKKLONEPIOF(Location BAIMHDBJPDK)
	{
		return weight * IIMHADGEHOD(BAIMHDBJPDK);
	}

	public float AHLEDBIFEIG(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior => beachMultiplier, 
			~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float AFLLEIIGADD(Location BAIMHDBJPDK)
	{
		return weight * EGLPFFLDLJC(BAIMHDBJPDK);
	}

	public float GEFHMEOBELE(Location BAIMHDBJPDK)
	{
		return weight * PHIFPMDNHFK(BAIMHDBJPDK);
	}

	public float GCEHIEHHEOL(Location BAIMHDBJPDK)
	{
		return weight * NIFAHKLDIKC(BAIMHDBJPDK);
	}

	public float JPNHEBCMCCP(Location BAIMHDBJPDK)
	{
		return weight * ECOKLLAGGMK(BAIMHDBJPDK);
	}

	public float BJOJMHCJCFF(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Tavern | Location.Road | Location.River | Location.Farm => beachMultiplier, 
			~(Location.Tavern | Location.Quarry | Location.BarnInterior) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float CEKCDGMLGLN(Location BAIMHDBJPDK)
	{
		return weight * ECOKLLAGGMK(BAIMHDBJPDK);
	}

	public float IIMHADGEHOD(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Tavern | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior => beachMultiplier, 
			~(Location.Tavern | Location.Road | Location.Quarry) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float CBICLAENCJH(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior) => beachMultiplier, 
			~(Location.Camp | Location.Farm) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float NNJAMOOOAAI(Location BAIMHDBJPDK)
	{
		return weight * LKKKBIJNAMB(BAIMHDBJPDK);
	}

	public float ICIFJHKGEIP(Location BAIMHDBJPDK)
	{
		return weight * KDBHNFKLLDN(BAIMHDBJPDK);
	}

	public float JIIEFOLDGCM(Location BAIMHDBJPDK)
	{
		return weight * HOPGNOIGCJN(BAIMHDBJPDK);
	}

	public float APFPLGJDCLP(Location BAIMHDBJPDK)
	{
		return weight * PHIFPMDNHFK(BAIMHDBJPDK);
	}

	public float NHKOLBLODCL(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Tavern | Location.Road | Location.Farm | Location.FarmShop => beachMultiplier, 
			~(Location.Tavern | Location.River | Location.Quarry | Location.BarnInterior) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float IMHOKFCDAEA(Location BAIMHDBJPDK)
	{
		return weight * FBLAOHAJGIK(BAIMHDBJPDK);
	}

	public float EOGCFFBIIHJ(Location BAIMHDBJPDK)
	{
		return weight * PHIFPMDNHFK(BAIMHDBJPDK);
	}

	public float DLOAHMEAJOE(Location BAIMHDBJPDK)
	{
		return weight * GDMPFGGOBHL(BAIMHDBJPDK);
	}

	public float ACINPGLEJPO(Location BAIMHDBJPDK)
	{
		return weight * IIMHADGEHOD(BAIMHDBJPDK);
	}

	public float IFFKOMFILPI(Location BAIMHDBJPDK)
	{
		return weight * NIFAHKLDIKC(BAIMHDBJPDK);
	}

	public float ONEIALDEKIO(Location BAIMHDBJPDK)
	{
		return weight * KDBHNFKLLDN(BAIMHDBJPDK);
	}

	public float NAMMCHENAAJ(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			~(Location.Road | Location.River | Location.BarnInterior) => beachMultiplier, 
			~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float CNAHFAKAMBD(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			~(Location.Quarry | Location.Farm | Location.FarmShop) => beachMultiplier, 
			~(Location.Quarry | Location.Farm | Location.BarnInterior) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float FBLAOHAJGIK(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Tavern | Location.Road | Location.Camp | Location.Farm => beachMultiplier, 
			Location.Road | Location.Quarry | Location.Farm => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float PHIFPMDNHFK(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Beach => beachMultiplier, 
			Location.Quarry => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float EKPIHEMAJML(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Road | Location.River | Location.Camp => beachMultiplier, 
			~(Location.Tavern | Location.Camp | Location.BarnInterior) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float EGLPFFLDLJC(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Tavern | Location.BarnInterior => beachMultiplier, 
			Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float BDDLDEIMLHO(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			~(Location.River | Location.Quarry | Location.BarnInterior) => beachMultiplier, 
			~(Location.Tavern | Location.Road | Location.River | Location.Camp) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float HOPGNOIGCJN(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Road | Location.Camp | Location.Farm | Location.FarmShop => beachMultiplier, 
			~(Location.Road | Location.Quarry | Location.Farm) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float ECOKLLAGGMK(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm => beachMultiplier, 
			~(Location.Tavern | Location.River) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float KDBHNFKLLDN(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.Road | Location.Quarry | Location.BarnInterior => beachMultiplier, 
			Location.Road | Location.River | Location.BarnInterior => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float BPJLJMPFMBB(Location BAIMHDBJPDK)
	{
		return weight * HOPGNOIGCJN(BAIMHDBJPDK);
	}

	public float BLOGCMPKDFN(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			~(Location.River | Location.Quarry | Location.FarmShop) => beachMultiplier, 
			~(Location.Quarry | Location.Farm | Location.BarnInterior) => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float GDMPFGGOBHL(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry) => beachMultiplier, 
			Location.Road | Location.Camp | Location.Quarry => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float MPFCANEHHML(Location BAIMHDBJPDK)
	{
		return weight * ECOKLLAGGMK(BAIMHDBJPDK);
	}

	public float IOFCAIHABMM(Location BAIMHDBJPDK)
	{
		return weight * AHLEDBIFEIG(BAIMHDBJPDK);
	}

	public float NIFAHKLDIKC(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			Location.River | Location.FarmShop => beachMultiplier, 
			Location.Road | Location.River | Location.Camp => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float LKKKBIJNAMB(Location BAIMHDBJPDK)
	{
		return BAIMHDBJPDK switch
		{
			~(Location.Tavern | Location.Road | Location.River | Location.Quarry) => beachMultiplier, 
			Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm => mountainMultiplier, 
			_ => meadowMultiplier, 
		};
	}

	public float PLFCJIEGBIP(Location BAIMHDBJPDK)
	{
		return weight * CBICLAENCJH(BAIMHDBJPDK);
	}
}
