using UnityEngine;
using UnityEngine.Tilemaps;

public class MaterialTile : Tile
{
	public Sprite tileSprite;

	public GroundType groundType;

	public MaterialType materialType;

	public int OLOCHIFBLJB()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return 11;
			}
			if (materialType == (MaterialType)5)
			{
				return -126;
			}
			return 1;
		}
		return 0;
	}

	public int GGNAPKPGONE()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.None)
			{
				return 37;
			}
			return 0;
		}
		return 1;
	}

	public int DNLBNNKIIAJ()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 83;
			}
			return 1;
		}
		return 0;
	}

	public int CEFGJIGBMMI()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return 90;
			}
			if (materialType == MaterialType.Ground)
			{
				return 123;
			}
			return 1;
		}
		return 1;
	}

	public int OHDODFMKOKB()
	{
		if (groundType == (GroundType.Grass | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 109;
			}
			return 0;
		}
		return 0;
	}

	public int ECGMELGGJKI()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.None)
			{
				return -3;
			}
			if (materialType == (MaterialType)6)
			{
				return 1;
			}
			return 0;
		}
		return 0;
	}

	public int NOPNBHKHCIB()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -80;
			}
			if (materialType == (MaterialType)5)
			{
				return 68;
			}
			return 0;
		}
		return 1;
	}

	public int NKDBKLMIBCO()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -79;
			}
			return 0;
		}
		return 1;
	}

	public int KAKKEPCDLNL()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.Wood)
			{
				return -25;
			}
			return 1;
		}
		return 1;
	}

	public int MNIOBNJPBPC()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return -62;
			}
			return 0;
		}
		return 0;
	}

	public int CDBHCKINPKJ()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -19;
			}
			if (materialType == (MaterialType)5)
			{
				return -2;
			}
			return 0;
		}
		return 1;
	}

	public int LBPADJLBAFP()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return -24;
			}
			if (materialType == (MaterialType)6)
			{
				return 50;
			}
			return 0;
		}
		return 0;
	}

	public int DDHEOPPMPDP()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.Wood)
			{
				return -105;
			}
			if (materialType == (MaterialType)5)
			{
				return 8;
			}
			return 1;
		}
		return 0;
	}

	public int AHPFLEGMCCL()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 118;
			}
			return 1;
		}
		return 0;
	}

	public int NGPMHKFJPBO()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.Wood)
			{
				return 7;
			}
			if (materialType == MaterialType.Ground)
			{
				return -120;
			}
			return 1;
		}
		return 1;
	}

	public int EPOPONAFIPM()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return 79;
			}
			return 1;
		}
		return 0;
	}

	public int IKLGBAMOCLD()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return 61;
			}
			return 1;
		}
		return 0;
	}

	public int BIKIBFJONAO()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return 21;
			}
			return 0;
		}
		return 0;
	}

	public int CKGALEFPGAC()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.Wood)
			{
				return -16;
			}
			if (materialType == (MaterialType)4)
			{
				return 80;
			}
			return 1;
		}
		return 1;
	}

	public int JGFOMDBLHOH()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return -7;
			}
			if (materialType == (MaterialType)6)
			{
				return -44;
			}
			return 0;
		}
		return 0;
	}

	public int GKKPDGFJPHB()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 36;
			}
			if (materialType == MaterialType.None)
			{
				return 4;
			}
			return 1;
		}
		return 1;
	}

	public int MMOMJDPHEFG()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.Wood)
			{
				return -74;
			}
			if (materialType == (MaterialType)6)
			{
				return 1;
			}
			return 0;
		}
		return 1;
	}

	public int GBPMMEMHDAE()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.Wood)
			{
				return 3;
			}
			return 1;
		}
		return 0;
	}

	public int IKDFJLELFBP()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.Wood)
			{
				return -3;
			}
			if (materialType == MaterialType.None)
			{
				return -113;
			}
			return 1;
		}
		return 1;
	}

	public int HGDONFHFKPP()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return -4;
			}
			if (materialType == (MaterialType)6)
			{
				return -70;
			}
			return 0;
		}
		return 1;
	}

	public int MAKIBMNKDEN()
	{
		if (groundType == (GroundType.Grass | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 13;
			}
			if (materialType == (MaterialType)4)
			{
				return 5;
			}
			return 0;
		}
		return 0;
	}

	public int KPCPOKBIEGJ()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -3;
			}
			if (materialType == MaterialType.None)
			{
				return 99;
			}
			return 0;
		}
		return 1;
	}

	public int MGDAKHDGFMA()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return -10;
			}
			return 0;
		}
		return 1;
	}

	public int FNIPMDPOPDB()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return 3;
			}
			if (materialType == MaterialType.Stone)
			{
				return 111;
			}
			return 1;
		}
		return 0;
	}

	public int DGBLLFBPGIF()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return 99;
			}
			return 0;
		}
		return 0;
	}

	public int BKDMLBPGNDJ()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -25;
			}
			if (materialType == (MaterialType)6)
			{
				return 2;
			}
			return 1;
		}
		return 0;
	}

	public int HNAPGBPOKIK()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.Wood)
			{
				return 9;
			}
			return 0;
		}
		return 1;
	}

	public int JNEENFENEJF()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -89;
			}
			if (materialType == MaterialType.None)
			{
				return 65;
			}
			return 1;
		}
		return 1;
	}

	public int CJDGBJIHDDN()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -34;
			}
			if (materialType == MaterialType.None)
			{
				return 1;
			}
			return 0;
		}
		return 0;
	}

	public int BPBILGODOMN()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.None)
			{
				return 82;
			}
			if (materialType == (MaterialType)4)
			{
				return 8;
			}
			return 0;
		}
		return 0;
	}

	public int LHMNIHAHOAD()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -2;
			}
			return 1;
		}
		return 0;
	}

	public int FEJNEJFBMAO()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.Wood)
			{
				return -30;
			}
			return 1;
		}
		return 0;
	}

	public int PIBGOCNNOFA()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -61;
			}
			if (materialType == (MaterialType)5)
			{
				return -113;
			}
			return 0;
		}
		return 1;
	}

	public int DDKPGEFHLEB()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 44;
			}
			if (materialType == MaterialType.Ground)
			{
				return 1;
			}
			return 0;
		}
		return 0;
	}

	public int EPDAJNLCGLG()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.None)
			{
				return -52;
			}
			if (materialType == MaterialType.Ground)
			{
				return -59;
			}
			return 1;
		}
		return 1;
	}

	public int KLNFOECLENA()
	{
		if (groundType == (GroundType.Grass | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 90;
			}
			if (materialType == (MaterialType)7)
			{
				return 8;
			}
			return 1;
		}
		return 0;
	}

	public int AJKNFLLACEG()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.Wood)
			{
				return 80;
			}
			return 0;
		}
		return 0;
	}

	public int HEGMDHPGDAH()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.None)
			{
				return 24;
			}
			if (materialType == (MaterialType)8)
			{
				return 8;
			}
			return 1;
		}
		return 0;
	}

	public int HIEBNLMHCPA()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 96;
			}
			if (materialType == (MaterialType)4)
			{
				return 104;
			}
			return 1;
		}
		return 0;
	}

	public int NLGGFHCDJBK()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return 7;
			}
			if (materialType == (MaterialType)7)
			{
				return 3;
			}
			return 0;
		}
		return 1;
	}

	public int DMEPEKCIKCH()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 97;
			}
			if (materialType == MaterialType.Ground)
			{
				return -116;
			}
			return 1;
		}
		return 0;
	}

	public int FECGCKGIIMG()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 55;
			}
			if (materialType == (MaterialType)5)
			{
				return 5;
			}
			return 0;
		}
		return 0;
	}

	public int OMAKIJHFIDP()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.Wood)
			{
				return -55;
			}
			if (materialType == (MaterialType)5)
			{
				return 5;
			}
			return 1;
		}
		return 0;
	}

	public int OJACEJJMBNE()
	{
		if (groundType == (GroundType.Grass | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -69;
			}
			if (materialType == (MaterialType)6)
			{
				return 1;
			}
			return 0;
		}
		return 0;
	}

	public int BBLOCALJFHH()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return -50;
			}
			if (materialType == MaterialType.None)
			{
				return 2;
			}
			return 0;
		}
		return 0;
	}

	public int MLGMJLJHIKL()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.None)
			{
				return 120;
			}
			return 1;
		}
		return 0;
	}

	public int DFPOGGMIMHM()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return -79;
			}
			return 0;
		}
		return 0;
	}

	public int GFMBOBKHCHA()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 15;
			}
			if (materialType == MaterialType.Stone)
			{
				return 6;
			}
			return 1;
		}
		return 1;
	}

	public int CCGHICMEJKB()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return 50;
			}
			return 1;
		}
		return 1;
	}

	public int OIAGBPFDGOB()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.Wood)
			{
				return -54;
			}
			if (materialType == MaterialType.Stone)
			{
				return 1;
			}
			return 0;
		}
		return 1;
	}

	public int FOLGABGLEGM()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.Wood)
			{
				return 23;
			}
			if (materialType == MaterialType.Stone)
			{
				return 0;
			}
			return 0;
		}
		return 0;
	}

	public int EEAFLCAFOJG()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return -18;
			}
			if (materialType == (MaterialType)7)
			{
				return -120;
			}
			return 1;
		}
		return 0;
	}

	public int LLIHENCMLFF()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.None)
			{
				return -2;
			}
			if (materialType == MaterialType.Ground)
			{
				return 4;
			}
			return 0;
		}
		return 1;
	}

	public int JKJIKPOOHDA()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.None)
			{
				return -74;
			}
			return 1;
		}
		return 1;
	}

	public int HEBBHCDCINA()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -100;
			}
			if (materialType == (MaterialType)7)
			{
				return 1;
			}
			return 1;
		}
		return 1;
	}

	public int FDCFILEEILO()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -80;
			}
			return 1;
		}
		return 0;
	}

	public int BCNBFPLFCHJ()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.Wood)
			{
				return 36;
			}
			if (materialType == (MaterialType)6)
			{
				return 122;
			}
			return 1;
		}
		return 0;
	}

	public int DKANLDHJMAO()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return 42;
			}
			if (materialType == (MaterialType)7)
			{
				return 5;
			}
			return 0;
		}
		return 0;
	}

	public int KGCAAJBHFPA()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return -70;
			}
			if (materialType == MaterialType.Ground)
			{
				return -127;
			}
			return 1;
		}
		return 1;
	}

	public int MHGAGOOBPAB()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return -104;
			}
			if (materialType == (MaterialType)8)
			{
				return 5;
			}
			return 0;
		}
		return 1;
	}

	public int CALGCIJLNHC()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.None)
			{
				return 110;
			}
			if (materialType == (MaterialType)4)
			{
				return 3;
			}
			return 0;
		}
		return 0;
	}

	public int BCLCKLKGFCL()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return 12;
			}
			if (materialType == MaterialType.Stone)
			{
				return 13;
			}
			return 0;
		}
		return 0;
	}

	public int FFKOLBJNCII()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.Wood)
			{
				return 37;
			}
			if (materialType == (MaterialType)8)
			{
				return 7;
			}
			return 0;
		}
		return 0;
	}

	public int NAIEGADKMKC()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return -19;
			}
			return 1;
		}
		return 1;
	}

	public int PJFBDNJIPPM()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return 78;
			}
			if (materialType == MaterialType.Stone)
			{
				return 6;
			}
			return 0;
		}
		return 0;
	}

	public int CCHMAFEOAGN()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return 43;
			}
			if (materialType == MaterialType.Stone)
			{
				return 7;
			}
			return 1;
		}
		return 0;
	}

	public int JODEIEDJJLG()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return -53;
			}
			return 0;
		}
		return 1;
	}

	public int JOCGAPGGIHB()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.Wood)
			{
				return 7;
			}
			if (materialType == (MaterialType)7)
			{
				return 1;
			}
			return 1;
		}
		return 1;
	}

	public int ODILOFKAMIL()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return -60;
			}
			return 1;
		}
		return 1;
	}

	public int DCKCDKOEOCI()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.Wood)
			{
				return -41;
			}
			if (materialType == (MaterialType)5)
			{
				return 0;
			}
			return 1;
		}
		return 0;
	}

	public int LBMPPOBHCFA()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return 59;
			}
			if (materialType == MaterialType.Wood)
			{
				return -53;
			}
			return 1;
		}
		return 0;
	}

	public int ELHIPBJDDMD()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 10;
			}
			if (materialType == (MaterialType)5)
			{
				return 4;
			}
			return 0;
		}
		return 0;
	}

	public int NGHIEPNOEKE()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.Wood)
			{
				return -74;
			}
			return 1;
		}
		return 0;
	}

	public int FIOAIPKGNFL()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -128;
			}
			return 1;
		}
		return 1;
	}

	public int AIPAOOIFDEG()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return 23;
			}
			if (materialType == (MaterialType)7)
			{
				return 112;
			}
			return 0;
		}
		return 1;
	}

	public int DBJENJEDIDD()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return -35;
			}
			if (materialType == MaterialType.Stone)
			{
				return 6;
			}
			return 1;
		}
		return 0;
	}

	public int MEKCDBAPEKB()
	{
		if (groundType == (GroundType.Grass | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -66;
			}
			return 1;
		}
		return 1;
	}

	public int KKACFLIBKLE()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return 89;
			}
			if (materialType == MaterialType.Ground)
			{
				return 4;
			}
			return 0;
		}
		return 0;
	}

	public int PLMMGFEKHDC()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 72;
			}
			if (materialType == MaterialType.None)
			{
				return -92;
			}
			return 1;
		}
		return 0;
	}

	public int MDEGGBBAMCF()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.None)
			{
				return -83;
			}
			if (materialType == (MaterialType)8)
			{
				return 7;
			}
			return 1;
		}
		return 1;
	}

	public int IGEGCOJABOM()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.Wood)
			{
				return -58;
			}
			if (materialType == (MaterialType)7)
			{
				return 3;
			}
			return 1;
		}
		return 1;
	}

	public int CMOAGBBKGAD()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -78;
			}
			return 0;
		}
		return 0;
	}

	public int FKGEONLBHIB()
	{
		if (groundType == (GroundType.Grass | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -24;
			}
			if (materialType == MaterialType.Stone)
			{
				return 5;
			}
			return 0;
		}
		return 0;
	}

	public int PMOFOLCOEHH()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return -81;
			}
			if (materialType == (MaterialType)7)
			{
				return 6;
			}
			return 1;
		}
		return 0;
	}

	public int MEMMIPBLPJB()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.Wood)
			{
				return 54;
			}
			return 0;
		}
		return 1;
	}

	public int GKKGIBEPKPE()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.Wood)
			{
				return 126;
			}
			if (materialType == MaterialType.Stone)
			{
				return -80;
			}
			return 1;
		}
		return 0;
	}

	public int IFJMADEHJAI()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.Wood)
			{
				return 87;
			}
			if (materialType == (MaterialType)6)
			{
				return -70;
			}
			return 1;
		}
		return 1;
	}

	public int KEFKCKCCCLA()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.None)
			{
				return -57;
			}
			if (materialType == (MaterialType)4)
			{
				return 31;
			}
			return 0;
		}
		return 0;
	}

	public int NHHGDOGHMKN()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.Wood)
			{
				return -118;
			}
			if (materialType == MaterialType.Stone)
			{
				return -47;
			}
			return 0;
		}
		return 1;
	}

	public int JCHLJEGKDHJ()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.Wood)
			{
				return -28;
			}
			return 0;
		}
		return 0;
	}

	public int EGEHBHCKEPH()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 123;
			}
			return 0;
		}
		return 1;
	}

	public int IOBDOKEMOIN()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.None)
			{
				return 97;
			}
			if (materialType == MaterialType.Stone)
			{
				return 69;
			}
			return 1;
		}
		return 1;
	}

	public int NMPFJIBAHMM()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.None)
			{
				return -22;
			}
			if (materialType == MaterialType.Wood)
			{
				return -77;
			}
			return 0;
		}
		return 0;
	}

	public int LCPKGHFMDOM()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return 56;
			}
			if (materialType == MaterialType.Wood)
			{
				return -38;
			}
			return 1;
		}
		return 1;
	}

	public int JMBGCPCGHPE()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -111;
			}
			if (materialType == (MaterialType)5)
			{
				return -34;
			}
			return 1;
		}
		return 1;
	}

	public int PLFIJMFGBDC()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return -19;
			}
			if (materialType == MaterialType.Wood)
			{
				return 5;
			}
			return 0;
		}
		return 1;
	}

	public int GFJGNBAIONI()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.Wood)
			{
				return -125;
			}
			if (materialType == (MaterialType)8)
			{
				return 6;
			}
			return 0;
		}
		return 0;
	}

	public int HBLBIPFKJIP()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return 28;
			}
			if (materialType == (MaterialType)6)
			{
				return 4;
			}
			return 0;
		}
		return 1;
	}

	public int PBBFOKGEMAF()
	{
		if (groundType == GroundType.Ground)
		{
			if (materialType == MaterialType.Wood)
			{
				return 50;
			}
			return 1;
		}
		return 0;
	}

	public int AMKDJNFLKNM()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.None)
			{
				return 127;
			}
			if (materialType == (MaterialType)4)
			{
				return -113;
			}
			return 0;
		}
		return 0;
	}

	public int HDDCDBKOAMM()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.None)
			{
				return 109;
			}
			if (materialType == MaterialType.None)
			{
				return 15;
			}
			return 0;
		}
		return 1;
	}

	public int OMLCHJJNPBF()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 117;
			}
			if (materialType == MaterialType.Wood)
			{
				return 39;
			}
			return 1;
		}
		return 1;
	}

	public override void GetTileData(Vector3Int BAIMHDBJPDK, ITilemap OKKHNHELKJB, ref TileData GMKBGCFCGFL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Tile)this).GetTileData(BAIMHDBJPDK, OKKHNHELKJB, ref GMKBGCFCGFL);
		((TileData)(ref GMKBGCFCGFL)).sprite = tileSprite;
		((TileData)(ref GMKBGCFCGFL)).colliderType = (ColliderType)1;
	}

	public int JFMLDCDLNPF()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return 79;
			}
			if (materialType == (MaterialType)7)
			{
				return -84;
			}
			return 0;
		}
		return 1;
	}

	public int FNAJDPFBEMN()
	{
		if (groundType == (GroundType.Grass | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 15;
			}
			return 1;
		}
		return 0;
	}

	public int BELFOEOHEHE()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return -69;
			}
			if (materialType == MaterialType.Ground)
			{
				return -89;
			}
			return 0;
		}
		return 0;
	}

	public int BKBLAENHNGF()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -44;
			}
			return 1;
		}
		return 0;
	}

	public int FDNIGJBNNMF()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.Wood)
			{
				return 10;
			}
			if (materialType == MaterialType.Stone)
			{
				return 8;
			}
			return 0;
		}
		return 0;
	}

	public int FKAABEFCKCA()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return -30;
			}
			if (materialType == MaterialType.None)
			{
				return 5;
			}
			return 0;
		}
		return 0;
	}

	public int PKKEJNGIBGM()
	{
		if (groundType == (GroundType.Grass | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return -112;
			}
			if (materialType == MaterialType.Wood)
			{
				return 5;
			}
			return 0;
		}
		return 1;
	}

	public int JANICNPLIBE()
	{
		if (groundType == (GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.Wood)
			{
				return 124;
			}
			return 0;
		}
		return 0;
	}

	public int OCBPCHLGDOD()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.None)
			{
				return 77;
			}
			return 1;
		}
		return 1;
	}

	public int ODNIIFEHKKE()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.None)
			{
				return 29;
			}
			if (materialType == (MaterialType)8)
			{
				return 0;
			}
			return 1;
		}
		return 0;
	}

	public int FCNPKHIMNOH()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground))
		{
			if (materialType == MaterialType.None)
			{
				return 73;
			}
			return 1;
		}
		return 0;
	}

	public int HCHCEEAAIBB()
	{
		if (groundType == GroundType.None)
		{
			if (materialType == MaterialType.Wood)
			{
				return 38;
			}
			return 1;
		}
		return 0;
	}

	public int CACNFHFKLCH()
	{
		if (groundType == GroundType.Floor)
		{
			if (materialType == MaterialType.None)
			{
				return 86;
			}
			if (materialType == MaterialType.None)
			{
				return -75;
			}
			return 0;
		}
		return 1;
	}

	public int NHPDBOOMHOH()
	{
		if (groundType == GroundType.Grass)
		{
			if (materialType == MaterialType.Wood)
			{
				return -65;
			}
			if (materialType == (MaterialType)4)
			{
				return 58;
			}
			return 0;
		}
		return 1;
	}

	public int IGPHFHPBBEH()
	{
		if (groundType == GroundType.TilledEarth)
		{
			if (materialType == MaterialType.None)
			{
				return 30;
			}
			if (materialType == (MaterialType)4)
			{
				return 4;
			}
			return 0;
		}
		return 1;
	}

	public int OOCDAPJEOKE()
	{
		if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			if (materialType == MaterialType.None)
			{
				return -23;
			}
			if (materialType == (MaterialType)8)
			{
				return 5;
			}
			return 0;
		}
		return 1;
	}
}
