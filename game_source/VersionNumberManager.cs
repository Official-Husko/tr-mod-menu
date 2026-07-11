using System.Runtime.CompilerServices;
using UnityEngine;

public class VersionNumberManager : MonoBehaviour
{
	public string version = "v0.4.4.4";

	public int[] versionNumber = new int[5] { 0, 4, 4, 4, 0 };

	public int[] initialVersionNumber = new int[5];

	public int[] loadSavedGameVersionNumber = new int[5];

	private int[] PMJIKCIHPHL = new int[5] { 0, 5, 0, 0, 0 };

	private int[] NJCFHJKBFFD = new int[5] { 0, 5, 1, 0, 0 };

	private int[] ECOAGDGGPIJ = new int[5] { 0, 5, 2, 0, 0 };

	private int[] NILOKBAHBFC = new int[5] { 0, 5, 2, 1, 0 };

	private int[] NPHHHCDLIAP = new int[5] { 0, 5, 3, 0, 0 };

	private int[] OPIIKCIFCHJ = new int[5] { 0, 5, 4, 0, 0 };

	private int[] IGDCFAJDGLH = new int[5] { 0, 6, 0, 0, 0 };

	private int[] PCEDHNKJJFA = new int[5] { 0, 6, 1, 0, 0 };

	private int[] FJIOPJPJNBI = new int[5] { 0, 6, 2, 5, 0 };

	private int[] CFBOHFGMOBI = new int[5] { 0, 6, 3, 0, 0 };

	private int[] HCKEPBKDEBD = new int[5] { 0, 6, 3, 8, 0 };

	private int[] NJDEFFEFMKC = new int[5] { 0, 6, 3, 11, 0 };

	private int[] FPGHGHJEHML = new int[5] { 0, 6, 4, 0, 0 };

	private int[] PMBKAIPHKAF = new int[5] { 0, 6, 4, 0, 4 };

	private int[] OOIOAOELHHA = new int[5] { 0, 6, 5, 0, 0 };

	private int[] IEJJIKINGGF = new int[5] { 0, 6, 5, 0, 4 };

	private int[] NDIBBIIFPLD = new int[5] { 0, 6, 5, 1, 0 };

	private int[] ACAGKGCNCMB = new int[5] { 0, 6, 6, 0, 0 };

	private int[] LPEOGCELPLF = new int[5] { 0, 6, 7, 0, 0 };

	private int[] MGCDKAKAPFK = new int[5] { 0, 7, 0, 0, 0 };

	private int[] PEBKPNJKDII = new int[5] { 0, 7, 0, 0, 4 };

	private int[] FMDMEOILBBI = new int[5] { 0, 7, 1, 0, 0 };

	private int[] OMMFBFJOLHM = new int[5] { 0, 7, 1, 5, 0 };

	private int[] GGHINDNHJNO = new int[5] { 0, 7, 1, 11, 0 };

	private int[] BAIBMNIJCOO = new int[5] { 0, 7, 2, 0, 0 };

	private int[] BMNKKEEAPPK = new int[5] { 0, 7, 3, 0, 0 };

	private int[] JIBJAIBKLAE = new int[5] { 0, 7, 4, 0, 0 };

	private int[] OJEPOMEPMKM = new int[5] { 0, 7, 4, 0, 4 };

	private int[] GMJKKOJJIBJ = new int[5] { 0, 7, 5, 0, 0 };

	private int[] ONKNPEPJPLC = new int[5] { 0, 7, 5, 0, 2 };

	public static VersionNumberManager instance;

	public bool characterSaveErrorDetected;

	public int[] COLFAMHCBKH => PMJIKCIHPHL;

	public int[] NCMFFHEANML => NJCFHJKBFFD;

	public int[] JAIJKPPEHFA => ECOAGDGGPIJ;

	public int[] CCFOCGJJCGO => NILOKBAHBFC;

	public int[] DANEANDMDGK => NPHHHCDLIAP;

	public int[] ECPACGIFHDL => OPIIKCIFCHJ;

	public int[] GEINOCMKEEO => IGDCFAJDGLH;

	public int[] ABAEJAMHKHB => PCEDHNKJJFA;

	public int[] EMGNJLJPMBN => FJIOPJPJNBI;

	public int[] EHAKBLPCLBO => CFBOHFGMOBI;

	public int[] GIGCAHPEAJF => HCKEPBKDEBD;

	public int[] GMIBLOBOPHO => NJDEFFEFMKC;

	public int[] BDMGPKLHMMH => FPGHGHJEHML;

	public int[] JMGIJBDDBLE => PMBKAIPHKAF;

	public int[] HBCGGNLPAKA => OOIOAOELHHA;

	public int[] NAGJGKIOGIC => IEJJIKINGGF;

	public int[] EAMEOIHOJGF => NDIBBIIFPLD;

	public int[] CHIIAPLGFIO => ACAGKGCNCMB;

	public int[] EIDKAPDHABJ => MGCDKAKAPFK;

	public int[] DAPPGOOCINM => PEBKPNJKDII;

	public static int[] KAJOEGAPHKL => instance.FMDMEOILBBI;

	public static int[] AEMLHFEBPNM => instance.OMMFBFJOLHM;

	public static int[] MLNNAPHFPKB => instance.LPEOGCELPLF;

	public static int[] KCHICKAGMDN => instance.GGHINDNHJNO;

	public static int[] OKIFGMKLLJL => instance.BAIBMNIJCOO;

	public static int[] LNJDCGCADMD => instance.BMNKKEEAPPK;

	public static int[] CEBHPJPJMCM => instance.JIBJAIBKLAE;

	public static int[] AHPLPFFMNNO => instance.OJEPOMEPMKM;

	public static int[] IJKFKNPOINO => instance.GMJKKOJJIBJ;

	public static int[] OHGKGIFCLGF => instance.ONKNPEPJPLC;

	[SpecialName]
	public int[] GCIBHEOECMM()
	{
		return PCEDHNKJJFA;
	}

	[SpecialName]
	public int[] CCCIEBKACNI()
	{
		return NPHHHCDLIAP;
	}

	[SpecialName]
	public int[] GDPPPDOFHGO()
	{
		return ECOAGDGGPIJ;
	}

	[SpecialName]
	public int[] CJIOPBPOILP()
	{
		return NILOKBAHBFC;
	}

	[SpecialName]
	public static int[] JKKOKNCJCHH()
	{
		return instance.JIBJAIBKLAE;
	}

	public static bool AJPMHCOBDJH(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i += 0)
			{
				if (OFIIBHBOPJI[i] != CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return false;
		}
		Debug.LogError((object)"itemDarkMaltedBarley");
		return false;
	}

	public static bool LMANFEGPOAE(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return true;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 1; i < OFIIBHBOPJI.Length; i += 0)
			{
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return true;
				}
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return false;
		}
		Debug.LogError((object)"DogNPC instance is null");
		return false;
	}

	[SpecialName]
	public int[] JMHNPBHKJHN()
	{
		return NPHHHCDLIAP;
	}

	public static bool ICBGCHGBJFI(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i += 0)
			{
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return false;
				}
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return true;
		}
		Debug.LogError((object)"talent_name_101");
		return false;
	}

	[SpecialName]
	public static int[] COJEOBEODBJ()
	{
		return instance.OMMFBFJOLHM;
	}

	[SpecialName]
	public int[] MNKHCMNPMGE()
	{
		return NDIBBIIFPLD;
	}

	[SpecialName]
	public int[] DAACBMLLEOD()
	{
		return MGCDKAKAPFK;
	}

	[SpecialName]
	public int[] CNHCJAGCPNI()
	{
		return ECOAGDGGPIJ;
	}

	public static bool AKIHFBIEAAL(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return true;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 1; i < OFIIBHBOPJI.Length; i += 0)
			{
				if (OFIIBHBOPJI[i] != CCNMCLDJJFB[i])
				{
					return true;
				}
			}
			return true;
		}
		Debug.LogError((object)"─── Fragmento {0}/{1} ───\n{2}");
		return true;
	}

	[SpecialName]
	public int[] MGFCBALMPNN()
	{
		return PMBKAIPHKAF;
	}

	[SpecialName]
	public static int[] IJPLKOPEMHO()
	{
		return instance.OJEPOMEPMKM;
	}

	[SpecialName]
	public static int[] DCJBICBKHPA()
	{
		return instance.BAIBMNIJCOO;
	}

	[SpecialName]
	public int[] JEIAIJKJJAL()
	{
		return PMBKAIPHKAF;
	}

	[SpecialName]
	public int[] ADFDPLMMPAI()
	{
		return FJIOPJPJNBI;
	}

	[SpecialName]
	public int[] ONCEOMNJBIM()
	{
		return NDIBBIIFPLD;
	}

	[SpecialName]
	public int[] GODDDPEOHNB()
	{
		return IGDCFAJDGLH;
	}

	[SpecialName]
	public static int[] HELGDEGLDNA()
	{
		return instance.JIBJAIBKLAE;
	}

	[SpecialName]
	public int[] NIOGAGJMGAA()
	{
		return IEJJIKINGGF;
	}

	public static bool FJPJCMJOGPB(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return true;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 1; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return false;
				}
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return true;
				}
			}
			return false;
		}
		Debug.LogError((object)"");
		return true;
	}

	[SpecialName]
	public static int[] BICAKJCGCMO()
	{
		return instance.BAIBMNIJCOO;
	}

	[SpecialName]
	public static int[] BOLAHAPKDJK()
	{
		return instance.LPEOGCELPLF;
	}

	public static bool AIHCAGOPKLP(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 1; i < OFIIBHBOPJI.Length; i += 0)
			{
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return false;
				}
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return true;
				}
			}
			return true;
		}
		Debug.LogError((object)"UI");
		return true;
	}

	[SpecialName]
	public static int[] FAOOHCIEIKP()
	{
		return instance.LPEOGCELPLF;
	}

	[SpecialName]
	public int[] LCNPLJJEFJK()
	{
		return FPGHGHJEHML;
	}

	[SpecialName]
	public int[] NPLFKHAJOBN()
	{
		return PCEDHNKJJFA;
	}

	[SpecialName]
	public int[] LOHHLLBBEFO()
	{
		return IEJJIKINGGF;
	}

	[SpecialName]
	public int[] DCKMIHBOLLK()
	{
		return PCEDHNKJJFA;
	}

	[SpecialName]
	public static int[] HAOJELPMMBF()
	{
		return instance.OMMFBFJOLHM;
	}

	[SpecialName]
	public int[] JBHKHILLKCM()
	{
		return OPIIKCIFCHJ;
	}

	[SpecialName]
	public int[] JCEIOODDIJP()
	{
		return NILOKBAHBFC;
	}

	[SpecialName]
	public int[] HOOIGNFNBIJ()
	{
		return ACAGKGCNCMB;
	}

	[SpecialName]
	public static int[] NFCOFIBIFEM()
	{
		return instance.GMJKKOJJIBJ;
	}

	[SpecialName]
	public int[] AMBGGLOOHJP()
	{
		return NILOKBAHBFC;
	}

	private void MPGPLILIJOD()
	{
		instance = this;
		Debug.Log((object)(" to user for reason " + version));
	}

	public static bool IsTheSameVersion(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] != CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return true;
		}
		Debug.LogError((object)"version numbers of different size");
		return false;
	}

	[SpecialName]
	public int[] OPOGDPEFOJA()
	{
		return OOIOAOELHHA;
	}

	private void JPFDPIAFACG()
	{
		instance = this;
		Debug.Log((object)("CurrentThemeSection" + version));
	}

	public static bool EELPMINAPNI(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 1; i < OFIIBHBOPJI.Length; i += 0)
			{
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return false;
				}
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return false;
		}
		Debug.LogError((object)"OnFloor");
		return true;
	}

	[SpecialName]
	public static int[] HHKIDPDNPBL()
	{
		return instance.GMJKKOJJIBJ;
	}

	[SpecialName]
	public int[] GIAFDAONJAN()
	{
		return FJIOPJPJNBI;
	}

	[SpecialName]
	public static int[] GPNEHKKNPHD()
	{
		return instance.JIBJAIBKLAE;
	}

	public static bool PCKJPCEPNOE(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 1; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return true;
				}
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return true;
		}
		Debug.LogError((object)"AdjustingGraphicsQuality");
		return false;
	}

	[SpecialName]
	public int[] OLKMCLGDBAH()
	{
		return IGDCFAJDGLH;
	}

	[SpecialName]
	public int[] NEDFHGJKKAN()
	{
		return PEBKPNJKDII;
	}

	[SpecialName]
	public int[] BNCGDJCBKDJ()
	{
		return IGDCFAJDGLH;
	}

	[SpecialName]
	public int[] PAFLGFHMIPB()
	{
		return IEJJIKINGGF;
	}

	[SpecialName]
	public int[] CLOIDAHEKFE()
	{
		return PMJIKCIHPHL;
	}

	[SpecialName]
	public static int[] IBPFJFGCALL()
	{
		return instance.BMNKKEEAPPK;
	}

	[SpecialName]
	public int[] LBPDBOPGBHJ()
	{
		return IEJJIKINGGF;
	}

	[SpecialName]
	public int[] KAOANGFBJDF()
	{
		return IEJJIKINGGF;
	}

	[SpecialName]
	public int[] DKHPNCJFAKG()
	{
		return IEJJIKINGGF;
	}

	[SpecialName]
	public int[] NFFLNEOAKJK()
	{
		return ACAGKGCNCMB;
	}

	[SpecialName]
	public static int[] NPCMPMFLAOF()
	{
		return instance.LPEOGCELPLF;
	}

	[SpecialName]
	public static int[] EIDGGIKEEDN()
	{
		return instance.FMDMEOILBBI;
	}

	[SpecialName]
	public static int[] NOEDKKDDLKN()
	{
		return instance.FMDMEOILBBI;
	}

	[SpecialName]
	public int[] CNOEJGAHDOL()
	{
		return PMJIKCIHPHL;
	}

	[SpecialName]
	public int[] LMECBGAFMCN()
	{
		return FJIOPJPJNBI;
	}

	[SpecialName]
	public static int[] IDLJMEDIJNM()
	{
		return instance.JIBJAIBKLAE;
	}

	[SpecialName]
	public int[] BHPHNDGLJIL()
	{
		return NDIBBIIFPLD;
	}

	private void LNPDALMANFB()
	{
		instance = this;
		Debug.Log((object)("UIAddRemove" + version));
	}

	[SpecialName]
	public static int[] LLDMGFFCNNA()
	{
		return instance.GMJKKOJJIBJ;
	}

	private void MIKNFPCDLML()
	{
		instance = this;
		Debug.Log((object)("Get Components " + version));
	}

	[SpecialName]
	public static int[] CPCPAINIBIG()
	{
		return instance.LPEOGCELPLF;
	}

	[SpecialName]
	public int[] EJMFOEKADIN()
	{
		return PEBKPNJKDII;
	}

	[SpecialName]
	public int[] DMAPPMKPIOP()
	{
		return IEJJIKINGGF;
	}

	[SpecialName]
	public int[] IPLACEKJECB()
	{
		return PMBKAIPHKAF;
	}

	public static bool HMOONJFEJFK(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return true;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 1; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return true;
				}
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return true;
		}
		Debug.LogError((object)"DebugRoom{0}");
		return false;
	}

	[SpecialName]
	public static int[] BPOONHNLBLG()
	{
		return instance.JIBJAIBKLAE;
	}

	[SpecialName]
	public int[] OCFBLMBAGKM()
	{
		return OOIOAOELHHA;
	}

	[SpecialName]
	public int[] EAJIBNPGNFH()
	{
		return PCEDHNKJJFA;
	}

	[SpecialName]
	public static int[] APNPMOIJHEM()
	{
		return instance.OJEPOMEPMKM;
	}

	[SpecialName]
	public int[] FAHEJKOIGHD()
	{
		return PCEDHNKJJFA;
	}

	[SpecialName]
	public int[] LGPHCJLFJID()
	{
		return ECOAGDGGPIJ;
	}

	private void IHICKHAABJH()
	{
		instance = this;
		Debug.Log((object)("BuildMode" + version));
	}

	public static bool MMBFDLNGOAB(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return true;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] != CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return true;
		}
		Debug.LogError((object)"Initializing GalaxyPeer instance...");
		return true;
	}

	[SpecialName]
	public int[] DBHFKNJMNIF()
	{
		return ECOAGDGGPIJ;
	}

	[SpecialName]
	public static int[] DDOBNJIAGAI()
	{
		return instance.OJEPOMEPMKM;
	}

	[SpecialName]
	public int[] JFFOHAIICCM()
	{
		return FJIOPJPJNBI;
	}

	[SpecialName]
	public int[] IKFBHNGMDJD()
	{
		return IEJJIKINGGF;
	}

	[SpecialName]
	public static int[] CMLGGAKBDIE()
	{
		return instance.ONKNPEPJPLC;
	}

	[SpecialName]
	public int[] DMOJAGHEHOD()
	{
		return NILOKBAHBFC;
	}

	public static bool MGKMHFNEMPA(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return true;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return false;
				}
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return false;
		}
		Debug.LogError((object)"Player/Bark/Tutorial/CrafterBlock");
		return true;
	}

	[SpecialName]
	public static int[] ONLBLPCHALI()
	{
		return instance.OJEPOMEPMKM;
	}

	[SpecialName]
	public int[] LLNOBMEBEOO()
	{
		return NILOKBAHBFC;
	}

	[SpecialName]
	public int[] FMKMEFHHDIJ()
	{
		return OOIOAOELHHA;
	}

	[SpecialName]
	public int[] BCPNCOIADGM()
	{
		return NILOKBAHBFC;
	}

	[SpecialName]
	public static int[] IAFNEFALPGB()
	{
		return instance.JIBJAIBKLAE;
	}

	[SpecialName]
	public int[] AGEJBHFMKKJ()
	{
		return PCEDHNKJJFA;
	}

	[SpecialName]
	public static int[] NCNAKFCAPHG()
	{
		return instance.ONKNPEPJPLC;
	}

	[SpecialName]
	public static int[] GHMGMDFMNBD()
	{
		return instance.GMJKKOJJIBJ;
	}

	[SpecialName]
	public int[] KNEBGPLFMPG()
	{
		return NDIBBIIFPLD;
	}

	[SpecialName]
	public static int[] PPCCPICKMPD()
	{
		return instance.GGHINDNHJNO;
	}

	[SpecialName]
	public static int[] GMFNPKKHJGJ()
	{
		return instance.FMDMEOILBBI;
	}

	[SpecialName]
	public int[] BBPCOMDKDNF()
	{
		return OPIIKCIFCHJ;
	}

	[SpecialName]
	public int[] FAKHDJAMBLF()
	{
		return FPGHGHJEHML;
	}

	[SpecialName]
	public int[] EGHMCFHIOAL()
	{
		return HCKEPBKDEBD;
	}

	[SpecialName]
	public int[] OCFKBDFEOCI()
	{
		return OOIOAOELHHA;
	}

	public static bool IsAnOlderVersion(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return true;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return true;
				}
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return false;
		}
		Debug.LogError((object)"version numbers of different size");
		return false;
	}

	private void COKBJNMAMDI()
	{
		instance = this;
		Debug.Log((object)("ReceiveTalentsLoad" + version));
	}

	[SpecialName]
	public int[] JGODMHMHBMN()
	{
		return IGDCFAJDGLH;
	}

	[SpecialName]
	public int[] NABGNDCIFOA()
	{
		return MGCDKAKAPFK;
	}

	[SpecialName]
	public int[] KFFCMNGKMDI()
	{
		return MGCDKAKAPFK;
	}

	[SpecialName]
	public static int[] KGJBJINCFDD()
	{
		return instance.FMDMEOILBBI;
	}

	[SpecialName]
	public int[] EHKICGDGEOO()
	{
		return IGDCFAJDGLH;
	}

	public static bool FGGIPMOBPNN(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return true;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 1; i < OFIIBHBOPJI.Length; i += 0)
			{
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return true;
				}
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return true;
		}
		Debug.LogError((object)"Christmas/Ace/Stand");
		return true;
	}

	[SpecialName]
	public int[] FDLHBHHPNCL()
	{
		return NJDEFFEFMKC;
	}

	public static bool JILCJABFCMA(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] != CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return false;
		}
		Debug.LogError((object)"UIBack");
		return true;
	}

	[SpecialName]
	public static int[] HBCLGKNANKN()
	{
		return instance.OJEPOMEPMKM;
	}

	[SpecialName]
	public int[] HNOMMPCLKGD()
	{
		return MGCDKAKAPFK;
	}

	[SpecialName]
	public int[] LOKFCCPIPCK()
	{
		return MGCDKAKAPFK;
	}

	public static bool KFHPBKIGFIG(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return false;
				}
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return false;
		}
		Debug.LogError((object)"Dialogue System/Conversation/TooCold/Entry/5/Dialogue Text");
		return false;
	}

	private void Awake()
	{
		instance = this;
		Debug.Log((object)("Current game version: " + version));
	}

	[SpecialName]
	public static int[] MBBHGOHMACE()
	{
		return instance.GGHINDNHJNO;
	}

	[SpecialName]
	public int[] CGFDJHLGBLN()
	{
		return NPHHHCDLIAP;
	}

	[SpecialName]
	public int[] OHOFFDOKCLB()
	{
		return PEBKPNJKDII;
	}

	[SpecialName]
	public static int[] KPNBLHGJOHB()
	{
		return instance.JIBJAIBKLAE;
	}

	private void KLMNLEDKEOE()
	{
		instance = this;
		Debug.Log((object)("LoveB&H" + version));
	}

	[SpecialName]
	public int[] CFFDDFGDBHB()
	{
		return FJIOPJPJNBI;
	}

	[SpecialName]
	public static int[] AFDKNDFIAIO()
	{
		return instance.BAIBMNIJCOO;
	}

	[SpecialName]
	public int[] JJFEAJOCECK()
	{
		return NJDEFFEFMKC;
	}

	[SpecialName]
	public static int[] CBOHHNEHDBL()
	{
		return instance.BMNKKEEAPPK;
	}

	[SpecialName]
	public int[] LDJCBDBNHCK()
	{
		return FJIOPJPJNBI;
	}

	[SpecialName]
	public int[] NBMJCHPABCH()
	{
		return NILOKBAHBFC;
	}

	[SpecialName]
	public int[] ICKHMNBDBFF()
	{
		return NILOKBAHBFC;
	}

	[SpecialName]
	public static int[] EOIIAIPFHKB()
	{
		return instance.FMDMEOILBBI;
	}

	[SpecialName]
	public int[] MHFHPGEOFIB()
	{
		return NJCFHJKBFFD;
	}

	[SpecialName]
	public int[] MJKMKMNPKKK()
	{
		return ECOAGDGGPIJ;
	}

	[SpecialName]
	public int[] GDOLAMBFIFC()
	{
		return NJCFHJKBFFD;
	}

	[SpecialName]
	public int[] KDLAPALKDEB()
	{
		return PEBKPNJKDII;
	}

	public static bool IsTheSameOrNewerVersion(int[] OFIIBHBOPJI, int[] CCNMCLDJJFB)
	{
		if (OFIIBHBOPJI == null)
		{
			return false;
		}
		if (OFIIBHBOPJI.Length == CCNMCLDJJFB.Length)
		{
			for (int i = 0; i < OFIIBHBOPJI.Length; i++)
			{
				if (OFIIBHBOPJI[i] > CCNMCLDJJFB[i])
				{
					return true;
				}
				if (OFIIBHBOPJI[i] < CCNMCLDJJFB[i])
				{
					return false;
				}
			}
			return true;
		}
		Debug.LogError((object)"version numbers of different size");
		return false;
	}

	[SpecialName]
	public int[] LIJCHPJNNDP()
	{
		return OOIOAOELHHA;
	}

	[SpecialName]
	public int[] ECACEJBDCHM()
	{
		return NDIBBIIFPLD;
	}

	[SpecialName]
	public int[] CFKBADOJPON()
	{
		return PMJIKCIHPHL;
	}

	[SpecialName]
	public static int[] AMAFPLGGODI()
	{
		return instance.LPEOGCELPLF;
	}

	[SpecialName]
	public int[] FLHMGELMPEB()
	{
		return IEJJIKINGGF;
	}

	[SpecialName]
	public int[] AGLBAEHKPOM()
	{
		return PMBKAIPHKAF;
	}

	[SpecialName]
	public int[] NNKDNPLMCOB()
	{
		return NJCFHJKBFFD;
	}

	[SpecialName]
	public int[] CNCDFLEFKAE()
	{
		return OPIIKCIFCHJ;
	}
}
