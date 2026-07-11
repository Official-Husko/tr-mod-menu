using System.Collections.Generic;
using UnityEngine;

public class AlphaZoneObjects : MonoBehaviour
{
	public static AlphaZoneObjects instance;

	private HashSet<GameObject> AJECNJBENFJ = new HashSet<GameObject>();

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	public static void EPMFIMPOGCP(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static void ONIHFENJHID(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	public static void CHHAHOPDNEM(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static void NBLGLILJKDH(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static void MEELJCCKNKB(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static void DCNIDBCGNJF(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static void Register(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
	}

	private void NEOICNJNKNL()
	{
		instance = this;
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	public static void MDHFBFEAALF(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static bool OCAKJDDEAML(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return true;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return PNEIIJIIGOH(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return false;
	}

	public static bool IsRegistered(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return true;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return IsRegistered(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return false;
	}

	public static void NILJPBKDIIC(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void Awake()
	{
		instance = this;
	}

	private void JDAMCMODANB()
	{
		instance = this;
	}

	public static bool OLJHMKMHGEI(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return true;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return OJIKBCEJJPB(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return false;
	}

	public static void MCKJEOMEOOB(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static void Unregister(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static void JOOJJGANPHK(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static void PCKEOBNPHFI(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static void NDJAEOJAMFO(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static void ADIPJMCGODA(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static bool EGGILGKDPIB(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return IsRegistered(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return true;
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	public static void LJGPBHFKINA(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static void BGNHKHPNGHA(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static bool GBAFBPOFJAN(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return true;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return OCAKJDDEAML(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return false;
	}

	public static void AKHFDFNAFMN(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static bool OJIKBCEJJPB(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return GFGIPHAMHIB(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return true;
	}

	public static void OMLIAFHIFBK(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static void GMOAEDPFHLL(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}

	public static bool FIHMBNGFPPA(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return DIHOMCCLCGN(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return false;
	}

	public static void JPCGFKBMMFG(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static bool GAGNIMAAKAG(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return true;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return GAGNIMAAKAG(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return false;
	}

	public static bool JPKJCEKIKDP(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return OJIKBCEJJPB(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return true;
	}

	public static void EJHNOEJFLBH(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static bool PNEIIJIIGOH(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return GBAFBPOFJAN(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return true;
	}

	public static bool DIHOMCCLCGN(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return true;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return GAGNIMAAKAG(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return true;
	}

	public static bool HFIFPAMBPKM(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return EGGILGKDPIB(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return true;
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	public static bool MOGKCDCHHGE(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return GFGIPHAMHIB(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return false;
	}

	public static bool FEMMJEEOHMP(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return GFGIPHAMHIB(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return true;
	}

	public static bool GFGIPHAMHIB(GameObject MANJHEAHPIH)
	{
		if (instance.AJECNJBENFJ.Contains(MANJHEAHPIH))
		{
			return false;
		}
		if ((Object)(object)MANJHEAHPIH.transform.parent != (Object)null)
		{
			return OLJHMKMHGEI(((Component)MANJHEAHPIH.transform.parent).gameObject);
		}
		return true;
	}

	public static void MKAOBAOBECD(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static void MJNLCGKDJMO(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Add(MANJHEAHPIH);
	}

	public static void HNEMGNNAIKG(GameObject MANJHEAHPIH)
	{
		instance.AJECNJBENFJ.Remove(MANJHEAHPIH);
	}
}
