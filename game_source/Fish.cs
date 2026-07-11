using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Fish : Food
{
	public enum FishType
	{
		None,
		Seaweed,
		WhiteFish,
		Trash,
		BlueFish,
		Shellfish
	}

	[Flags]
	public enum FishingMethod
	{
		None = 0,
		Rod = 1,
		Basket = 2
	}

	[Flags]
	public enum BaitType
	{
		None = 0,
		Meat = 1,
		Larva = 2,
		Worm = 4,
		Seafood = 8,
		Artificial = 0x10,
		Anything = 0x1F
	}

	[Flags]
	public enum DisplayMethod
	{
		None = 0,
		Collections = 1,
		Aquarium = 2
	}

	public FishType fishType;

	public FishingMethod fishingMethod;

	public BaitType baitType;

	public WaterType waterType;

	public int difficulty;

	public Vector2Int lenght;

	public CropSeason season;

	public DisplayMethod displayMethod;

	public int Rarity => Mathf.FloorToInt((float)difficulty / 10f);

	[SpecialName]
	public int EBHHJHBMEFE()
	{
		return Mathf.FloorToInt((float)difficulty / 1588f);
	}

	[SpecialName]
	public int CLNBKGPJAFJ()
	{
		return Mathf.FloorToInt((float)difficulty / 71f);
	}

	[SpecialName]
	public int JKEAEEPAMGP()
	{
		return Mathf.FloorToInt((float)difficulty / 1595f);
	}

	[SpecialName]
	public int HMDNEMCMDEG()
	{
		return Mathf.FloorToInt((float)difficulty / 58f);
	}

	[SpecialName]
	public int AKOFLIMMHHA()
	{
		return Mathf.FloorToInt((float)difficulty / 347f);
	}

	[SpecialName]
	public int AEJHNAOCKNP()
	{
		return Mathf.FloorToInt((float)difficulty / 1127f);
	}

	[SpecialName]
	public int KAJMOELDIOC()
	{
		return Mathf.FloorToInt((float)difficulty / 1562f);
	}

	[SpecialName]
	public int KNFKNCCFMLK()
	{
		return Mathf.FloorToInt((float)difficulty / 1697f);
	}

	[SpecialName]
	public int PJMFGENDEDL()
	{
		return Mathf.FloorToInt((float)difficulty / 1023f);
	}

	[SpecialName]
	public int FMGNNOJIMEO()
	{
		return Mathf.FloorToInt((float)difficulty / 1784f);
	}

	[SpecialName]
	public int FKLKFEPFJAF()
	{
		return Mathf.FloorToInt((float)difficulty / 323f);
	}

	public override ItemInstance JMDALJBNFML()
	{
		if (ItemDatabaseAccessor.GetItem(id) is Fish hAJFJGCNKFF)
		{
			return new FishInstance(hAJFJGCNKFF);
		}
		Debug.LogError((object)("item " + IABAKHPEOAF() + " is not fish"));
		return new FishInstance(this);
	}

	[SpecialName]
	public int BLMKGGDJICB()
	{
		return Mathf.FloorToInt((float)difficulty / 1540f);
	}

	[SpecialName]
	public int ILIOIIKLCHG()
	{
		return Mathf.FloorToInt((float)difficulty / 483f);
	}

	[SpecialName]
	public int KGPDIDMACOD()
	{
		return Mathf.FloorToInt((float)difficulty / 1236f);
	}

	[SpecialName]
	public int LLAEGLPBOHH()
	{
		return Mathf.FloorToInt((float)difficulty / 164f);
	}

	[SpecialName]
	public int AJDHGCHBAPN()
	{
		return Mathf.FloorToInt((float)difficulty / 1085f);
	}

	[SpecialName]
	public int GMHACLPHMGB()
	{
		return Mathf.FloorToInt((float)difficulty / 1835f);
	}

	[SpecialName]
	public int FMKCCCGAJJB()
	{
		return Mathf.FloorToInt((float)difficulty / 1488f);
	}

	[SpecialName]
	public int BEONJKHOKIN()
	{
		return Mathf.FloorToInt((float)difficulty / 1498f);
	}

	[SpecialName]
	public int HODFEPDEFEE()
	{
		return Mathf.FloorToInt((float)difficulty / 852f);
	}

	[SpecialName]
	public int PLOECLOLFCB()
	{
		return Mathf.FloorToInt((float)difficulty / 51f);
	}

	[SpecialName]
	public int ENJDCADIIIA()
	{
		return Mathf.FloorToInt((float)difficulty / 1688f);
	}

	[SpecialName]
	public int JLMNNJIEFCA()
	{
		return Mathf.FloorToInt((float)difficulty / 76f);
	}

	[SpecialName]
	public int KJHBPFIDNLK()
	{
		return Mathf.FloorToInt((float)difficulty / 1376f);
	}

	[SpecialName]
	public int IJADAIONDEH()
	{
		return Mathf.FloorToInt((float)difficulty / 1741f);
	}

	[SpecialName]
	public int OIBJPBPOPCD()
	{
		return Mathf.FloorToInt((float)difficulty / 1893f);
	}

	[SpecialName]
	public int PPBMJCNCNMH()
	{
		return Mathf.FloorToInt((float)difficulty / 1465f);
	}

	[SpecialName]
	public int GOBOCABLFMF()
	{
		return Mathf.FloorToInt((float)difficulty / 1369f);
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new FishInstance((FishInstance)DNLMCHDOMOK);
	}

	[SpecialName]
	public int APMNBIDKAMO()
	{
		return Mathf.FloorToInt((float)difficulty / 1096f);
	}

	[SpecialName]
	public int DANLFJJKGEA()
	{
		return Mathf.FloorToInt((float)difficulty / 311f);
	}

	[SpecialName]
	public int OJDBAPHMPAC()
	{
		return Mathf.FloorToInt((float)difficulty / 1309f);
	}

	[SpecialName]
	public int EPNJJFILPAF()
	{
		return Mathf.FloorToInt((float)difficulty / 925f);
	}

	[SpecialName]
	public int FNBADFLPGCO()
	{
		return Mathf.FloorToInt((float)difficulty / 1759f);
	}

	[SpecialName]
	public int FJADEOMLCDG()
	{
		return Mathf.FloorToInt((float)difficulty / 1147f);
	}

	[SpecialName]
	public int HKKLPEENINI()
	{
		return Mathf.FloorToInt((float)difficulty / 456f);
	}

	[SpecialName]
	public int NKBBOAKLBJK()
	{
		return Mathf.FloorToInt((float)difficulty / 1143f);
	}

	[SpecialName]
	public int LHPJOBDEKKN()
	{
		return Mathf.FloorToInt((float)difficulty / 239f);
	}

	[SpecialName]
	public int IIMHLHGJLDJ()
	{
		return Mathf.FloorToInt((float)difficulty / 1827f);
	}

	[SpecialName]
	public int LLEMIOLIODP()
	{
		return Mathf.FloorToInt((float)difficulty / 1195f);
	}

	[SpecialName]
	public int LDFMCJMIFPE()
	{
		return Mathf.FloorToInt((float)difficulty / 1853f);
	}
}
