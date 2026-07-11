using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

public struct WorldTile
{
	public bool tucked;

	public bool isPath;

	public bool isHorsePath;

	public bool buildable;

	public bool canPlaceObjects;

	public List<GameObject> blockingObjects;

	public bool canPlaceSeat;

	public Direction canPlaceSeatDirection;

	public bool wooded;

	public bool farmable;

	public CropSeason canFishSeasons;

	public bool wall;

	public bool hasSnow;

	public bool showDarkSnow;

	public float snowProbability;

	public MonoBehaviour door;

	public List<Herb> herbs;

	public List<Placeable> placeables;

	public GroundType groundType;

	public MaterialType materialType;

	public int decoFloorId;

	public int decoWallId;

	public int decoTrimId;

	public Location location;

	public ZoneType zoneType;

	public int zoneIndex;

	public IrrigatorType irrigator;

	private TileBase HOHBICFPLOJ;

	private TileBase INILMHHCDJC;

	private TileBase FNLDNADLOAM;

	private TileBase EBBMLNAAFBB;

	private TileBase HFBPDKFLNAB;

	public TilemapScene PBLLKEKGLPK => Utils.JGEPCPFJANP(location);

	public void IIBPLFINCCO(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase PNJKJCMOHAN(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Summer)
		{
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return FNLDNADLOAM;
			}
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public void JCGNBBEPFPK(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase LENHFCHIIDM()
	{
		return HOHBICFPLOJ;
	}

	[SpecialName]
	public TilemapScene DDPEADPBOEO()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase EECEBFNMIAC(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)5)
		{
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return FNLDNADLOAM;
			}
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase DGFOBONDHNO(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase NMABGIJDKBP(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Floor:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase EBHOHNAJMND()
	{
		return HOHBICFPLOJ;
	}

	public TileBase MHCNJNHMPFG()
	{
		return HOHBICFPLOJ;
	}

	public void MKGCPLMECKI(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)6)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public void EOADIFCOMAM(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public void ILFAIOCJFGI(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)5)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Ground:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Ground:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	[SpecialName]
	public TilemapScene CEIAELFAEFM()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase HBHALMNFOMK(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	[SpecialName]
	public TilemapScene LCJEHOMJELL()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public void MEACCADBOOI(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	[SpecialName]
	public TilemapScene OLNAGNHCCAO()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public void HFCIKOJPEKG(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public void MEOBOLCCGIF(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public void GDIHAGEOCDO(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)4)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Floor:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public TileBase LNBBMCDPHJE(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)8)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public void MGHOHJILEEF(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)8)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else if (GBKMNAPGIOM == GroundType.Grass)
		{
			INILMHHCDJC = OBPOFPDBFFD;
		}
		else if (GBKMNAPGIOM == GroundType.Grass)
		{
			EBBMLNAAFBB = OBPOFPDBFFD;
		}
	}

	public void BMBIKMOADNB(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase OAPDCBDOCNC()
	{
		return HOHBICFPLOJ;
	}

	public void CHBANJLBBAH(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Autumn)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Floor:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Ground | GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public void ALGINELEMIE(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase NDLPMOLMHBI(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)5)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.None:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase KHDCBPGEFFK()
	{
		return HOHBICFPLOJ;
	}

	public void PBNNMKKHOOI(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public void JDEOHLBNPCI(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public void OLGLHKFHMCI(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Winter)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Floor:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else if (GBKMNAPGIOM == GroundType.Grass)
		{
			INILMHHCDJC = OBPOFPDBFFD;
		}
		else if (GBKMNAPGIOM == GroundType.Grass)
		{
			EBBMLNAAFBB = OBPOFPDBFFD;
		}
	}

	[SpecialName]
	public TilemapScene ENJLPBDIEOG()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public void DOBFABBGEMG(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.None:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	[SpecialName]
	public TilemapScene NIGCFOGOMHI()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public void OLLKMOHOOBJ(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)7)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	[SpecialName]
	public TilemapScene MDAKFICLAMD()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase CHJFPFMFKIB()
	{
		return HOHBICFPLOJ;
	}

	public void NPDLIGIAAKD(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase KJHCKEEHMOJ()
	{
		return HOHBICFPLOJ;
	}

	public TileBase AEMBBMBKEHJ()
	{
		return HOHBICFPLOJ;
	}

	[SpecialName]
	public TilemapScene CLLNPGEIHDB()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase NINEODFNLEP()
	{
		return HOHBICFPLOJ;
	}

	public void NMDKGBDDIIG(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Ground:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public TileBase JFMNFGKJDIA(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)4)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.Ground | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Floor:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public void CJIBBGIMMDO(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase EBDOKPGOGGI()
	{
		return HOHBICFPLOJ;
	}

	public void IPLEAHHPLBO(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Autumn)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public TileBase NPAOBLGKCEE()
	{
		return HOHBICFPLOJ;
	}

	[SpecialName]
	public TilemapScene JJCNIFHNKDH()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase BCMIDCPCFEP(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)6)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Ground | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase EEEAMJOPKHL(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Winter)
		{
			if (GBKMNAPGIOM == GroundType.None)
			{
				return FNLDNADLOAM;
			}
			if (GBKMNAPGIOM == GroundType.None)
			{
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Ground | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	[SpecialName]
	public TilemapScene GMEICKDHFFO()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public void AIAEEPOIFKM(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase HOIKBKBIBJP(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Winter)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase DAHCHLJIEFE()
	{
		return HOHBICFPLOJ;
	}

	public TileBase HOMHHMIINFP()
	{
		return HOHBICFPLOJ;
	}

	public TileBase ADIJIBIMGBJ(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)6)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Ground:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase NFCMHALAOMH()
	{
		return HOHBICFPLOJ;
	}

	public void HCIEKPPHCBJ(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)6)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public TileBase NPOMFJPAPGA(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Winter)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Ground:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase GIJGFLEECOC()
	{
		return HOHBICFPLOJ;
	}

	public TileBase JDLLEHJCJJE(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)6)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public void JDCDPGHODEE(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase DHJBCIKHIDB(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)6)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Floor:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public void CJMEBGANPNL(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public void EEIMFAKGHCG(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase NPAKABKABLK(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.None:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase ODLFOOLFAID(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Winter)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase CAJBCNJBCNM(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)7)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return INILMHHCDJC;
			}
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase KIIANJJOCHJ()
	{
		return HOHBICFPLOJ;
	}

	public TileBase FPOJDIEKJAK(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Autumn)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.Ground:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public void JAOOEIHHEKM(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	[SpecialName]
	public TilemapScene ILPLLBICFGH()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase LDOPMABEHLM()
	{
		return HOHBICFPLOJ;
	}

	public void BKBADOOLIHE(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)7)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Floor:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public TileBase CAGELGMOKLP(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)4)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Ground:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase DCOPACAAMHF()
	{
		return HOHBICFPLOJ;
	}

	public TileBase HICLACDDOMG(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Summer)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Ground | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Floor:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase JPODPJHMJBP()
	{
		return HOHBICFPLOJ;
	}

	public TileBase GLBGMAJCIPA()
	{
		return HOHBICFPLOJ;
	}

	[SpecialName]
	public TilemapScene MCELCLBJDFD()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public void PBJLCLLBCKE(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase HMBOPKJOJBH(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			if (GBKMNAPGIOM == GroundType.None)
			{
				return INILMHHCDJC;
			}
			if (GBKMNAPGIOM == GroundType.None)
			{
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase AEJOLEMKHKB(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return FNLDNADLOAM;
			}
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.Ground:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase DIDNBJDLAGM(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)7)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.Ground | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Floor:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public void FEKAKMMLNEJ(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase MEHGKIGOAFH()
	{
		return HOHBICFPLOJ;
	}

	public void FDBCNABBNDM(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Autumn)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Floor:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	[SpecialName]
	public TilemapScene FDNAJIJJGID()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase MOBHGDKFFCM()
	{
		return HOHBICFPLOJ;
	}

	[SpecialName]
	public TilemapScene JAHMFHKBPMO()
	{
		return Utils.JGEPCPFJANP(location);
	}

	[SpecialName]
	public TilemapScene LDJAFHMMBBD()
	{
		return Utils.JGEPCPFJANP(location);
	}

	[SpecialName]
	public TilemapScene JHOJPFMKHIK()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase FBJEPEKCHDC()
	{
		return HOHBICFPLOJ;
	}

	[SpecialName]
	public TilemapScene HPJLBHDIPGK()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public void AHKDFBKEMBF(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Winter)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Ground | GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public void FFABMIODBCF(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)4)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Ground | GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public void DECOHEBFCEK(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)4)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public TileBase FFIJELKEBJL()
	{
		return HOHBICFPLOJ;
	}

	public void JMOJOJNDEIB(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase CBFPHENFOEG(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)7)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Ground | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase FGGDKIDMOGK()
	{
		return HOHBICFPLOJ;
	}

	public void CNFAEGLKBJC(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)5)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public void HGKLCFKAPDO(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	[SpecialName]
	public TilemapScene BDHPJHGCKIJ()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase ENNDDLMKIBK()
	{
		return HOHBICFPLOJ;
	}

	public void FFIOOOGHGEG(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public void CHFLKGKFCOM(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Summer)
		{
			if (GBKMNAPGIOM == GroundType.None)
			{
				FNLDNADLOAM = OBPOFPDBFFD;
			}
			else if (GBKMNAPGIOM == GroundType.None)
			{
				HFBPDKFLNAB = OBPOFPDBFFD;
			}
			return;
		}
		switch (GBKMNAPGIOM)
		{
		case GroundType.Grass:
			INILMHHCDJC = OBPOFPDBFFD;
			break;
		case GroundType.None:
			EBBMLNAAFBB = OBPOFPDBFFD;
			break;
		}
	}

	public void EMCFBKPDHJB(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Summer)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else if (GBKMNAPGIOM == GroundType.None)
		{
			INILMHHCDJC = OBPOFPDBFFD;
		}
		else if (GBKMNAPGIOM == GroundType.None)
		{
			EBBMLNAAFBB = OBPOFPDBFFD;
		}
	}

	public TileBase BGILDPNEHCA()
	{
		return HOHBICFPLOJ;
	}

	public void ELEIJMHLHCH(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase FNGHKNICGFF(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)5)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return FNLDNADLOAM;
			case GroundType.Grass:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				return INILMHHCDJC;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	[SpecialName]
	public TilemapScene GDHHGKCOFII()
	{
		return Utils.JGEPCPFJANP(location);
	}

	public TileBase HFNIOEHFLCP()
	{
		return HOHBICFPLOJ;
	}

	public void EKLOKPCJCLC(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase LCHFFGLDHKB()
	{
		return HOHBICFPLOJ;
	}

	public TileBase BGOCPLHBBDI(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)7)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.TilledEarth:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return INILMHHCDJC;
			case GroundType.TilledEarth:
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public TileBase OLGMEOFLPCB()
	{
		return HOHBICFPLOJ;
	}

	public void KJPKJMFPOJC(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public TileBase FEAGNPFPLLP()
	{
		return HOHBICFPLOJ;
	}

	public void EMEOLBDJLMC(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Winter)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Ground:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Ground:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public TileBase DDHMNMPPOPH()
	{
		return HOHBICFPLOJ;
	}

	public TileBase FOPJEIJOCLM(GroundType GBKMNAPGIOM, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)6)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				return FNLDNADLOAM;
			case GroundType.Grass | GroundType.Ground:
				return HFBPDKFLNAB;
			}
		}
		else
		{
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return INILMHHCDJC;
			}
			if (GBKMNAPGIOM == GroundType.Grass)
			{
				return EBBMLNAAFBB;
			}
		}
		return null;
	}

	public void OJJLPJJFMDO(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else if (GBKMNAPGIOM == GroundType.Grass)
		{
			INILMHHCDJC = OBPOFPDBFFD;
		}
		else if (GBKMNAPGIOM == GroundType.Grass)
		{
			EBBMLNAAFBB = OBPOFPDBFFD;
		}
	}

	public void MBNLJNCDNHI(TileBase OBPOFPDBFFD)
	{
		HOHBICFPLOJ = OBPOFPDBFFD;
	}

	public void FMKECODDNHH(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == Season.Summer)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.TilledEarth:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Ground:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	public void KHEDCMODKJF(GroundType GBKMNAPGIOM, Season EECEKHKAAIH, TileBase OBPOFPDBFFD)
	{
		if (EECEKHKAAIH == (Season)6)
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				FNLDNADLOAM = OBPOFPDBFFD;
				break;
			case GroundType.None:
				HFBPDKFLNAB = OBPOFPDBFFD;
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.None:
				INILMHHCDJC = OBPOFPDBFFD;
				break;
			case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
				EBBMLNAAFBB = OBPOFPDBFFD;
				break;
			}
		}
	}

	[SpecialName]
	public TilemapScene IJADBGIPIJO()
	{
		return Utils.JGEPCPFJANP(location);
	}
}
