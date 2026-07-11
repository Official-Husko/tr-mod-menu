using System;
using UnityEngine;

public class RandomTimeEnabler : MonoBehaviour
{
	public float minTime;

	public float maxTime;

	public Placeable placeable;

	public GameObject[] objectsToEnable;

	private float OAIPCHEDLEA;

	private void NEBFFEBAGGB()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			JABMEOPCFNK();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void DKHCOKMIJME()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(LKFAAKKPPCH));
		}
	}

	private void DMFMNEMDFNP()
	{
		FMFLOHOINHO();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(FINBDDHINDM));
	}

	private void AHFGOOHOLEL()
	{
		AJDMAKJNAPN();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HPONCEJDHAO));
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(MCMAJIBOOGB));
		}
	}

	private void HPEHEOGFLHO()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			CPFJDNFKBDD();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void FMFLOHOINHO()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void PIMCCDIHLCB()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void MMNFCJDEMJF()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void LBPBACIIIIC()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			CMDECGMABLK();
			for (int i = 0; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void IFHLGOMBACP()
	{
		NNCFFJBCACO();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(LGEFBPGHDLG));
	}

	private void IKPFHMDOJFE()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void CMDECGMABLK()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void CMLLBIDFNEB()
	{
		CNGJIJPAMIN();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(PCLIDGBLCAD));
	}

	private void AKPLLNELLJK()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(KNFLJDILNLG));
		}
	}

	private void BGENEAOILOF()
	{
		NNCFFJBCACO();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HMCJIAEPIDG));
	}

	private void BGCIHFLPPJM()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			AIGEMHFIBOK();
			for (int i = 0; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void EGHOIJHBDBP()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(LKFAAKKPPCH));
		}
	}

	private void AKAMNIHKHLF()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void NNCFFJBCACO()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void AOPLAGHILHO()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void ALCJOABPBMA()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(HMCJIAEPIDG));
		}
	}

	private void ALJLECPNFFD()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(PMFMIEICOPM));
		}
	}

	private void PJOKFEPCMBK()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void OFFACLJFMEJ()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void OFEAMHNPDEI()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void NFABFPFLNEE()
	{
		PJOKFEPCMBK();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(GMOECEMLMDK));
	}

	private void LGEFBPGHDLG()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			BGHCIKFEAME();
			for (int i = 1; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void LJLKBKEADGI()
	{
		AOEGINBNHGC();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(IOFLEJADPJE));
	}

	private void HIGFJAJAMFB()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			NNCFFJBCACO();
			for (int i = 0; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void IKMPNICLPBM()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(MCMAJIBOOGB));
		}
	}

	private void BFGHOANOOJE()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			CPFJDNFKBDD();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void HCOPKGIEKIE()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			CPFJDNFKBDD();
			for (int i = 1; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void JPHEOLEEAPB()
	{
		IKPFHMDOJFE();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(ALFCFDKAJAH));
	}

	private void DIEIFBFEKPP()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			JABMEOPCFNK();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void ODGKDCPMKDO()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			ICCBJLJIJIG();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void ALMLPDNMLJA()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			NNCFFJBCACO();
			for (int i = 0; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void FLOFJHNAIKP()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(LEEMGIPJIJD));
		}
	}

	private void KJIAAMJJANC()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			IKPFHMDOJFE();
			for (int i = 0; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void CNGJIJPAMIN()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void PMFMIEICOPM()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			BGHCIKFEAME();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void OMKHBBFMEHI()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			JOECOEGMDKM();
			for (int i = 1; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void AIDECDONLII()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			KMFKALAEODI();
			for (int i = 0; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void HJDLNCOAKIK()
	{
		AIGEMHFIBOK();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(LKFAAKKPPCH));
	}

	private void BFBGKGIFEJO()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(NOHGLGFAPMI));
		}
	}

	private void IOFLEJADPJE()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			GJEPKPEDEPD();
			for (int i = 0; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void NFBMMEEBEJG()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			JABMEOPCFNK();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void LEEMGIPJIJD()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			MMNFCJDEMJF();
			for (int i = 0; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void MFMFAKPJBFJ()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			DOPKMOBFOGE();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void BGHCIKFEAME()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void JABMEOPCFNK()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void ALFCFDKAJAH()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			AOPLAGHILHO();
			for (int i = 0; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void EGCDHFDFFII()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(LBPBACIIIIC));
		}
	}

	private void GMOECEMLMDK()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			BMBJGPJNCOG();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void BMBJGPJNCOG()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void HKKDEKIFPPJ()
	{
		AOEGINBNHGC();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(LKFAAKKPPCH));
	}

	private void MCMAJIBOOGB()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			GJEPKPEDEPD();
			for (int i = 0; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void JOECOEGMDKM()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void ICCBJLJIJIG()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void Start()
	{
		NNCFFJBCACO();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HIGFJAJAMFB));
	}

	private void AIGEMHFIBOK()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void DOPKMOBFOGE()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void PKFMLJGJKCP()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(FINBDDHINDM));
		}
	}

	private void ODBDHFBMDAG()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(CNPPKGJMFIL));
		}
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(KJIAAMJJANC));
		}
	}

	private void KACEOJDPLKB()
	{
		DIEJJBEMHPM();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(MCMAJIBOOGB));
	}

	private void CAOKPIIFHBJ()
	{
		FMFLOHOINHO();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(ALFCFDKAJAH));
	}

	private void AJDMAKJNAPN()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void CPFJDNFKBDD()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void HIBOPILFKBA()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			BGHCIKFEAME();
			for (int i = 1; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void IKCKLEHOBNG()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			AKAMNIHKHLF();
			for (int i = 0; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void NKGMEMEACNN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(AIDECDONLII));
		}
	}

	private void PLFKFKHFCEO()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			AOPLAGHILHO();
			for (int i = 0; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void GJEPKPEDEPD()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void MCMKNBIBDFF()
	{
		KMFKALAEODI();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HIBOPILFKBA));
	}

	private void FNFNLFOJHHA()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(NOHGLGFAPMI));
		}
	}

	private void LLFENNKCLOD()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void FINBDDHINDM()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			PIMCCDIHLCB();
			for (int i = 1; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void HPONCEJDHAO()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			FMFLOHOINHO();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void PCLIDGBLCAD()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			LLFENNKCLOD();
			for (int i = 1; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(HIGFJAJAMFB));
		}
	}

	private void NEEEJJNMPOF()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(PMFMIEICOPM));
		}
	}

	private void DIEJJBEMHPM()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void DCKKIDMJKJM()
	{
		AKAMNIHKHLF();
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(MCMAJIBOOGB));
	}

	private void LKFAAKKPPCH()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			CNGJIJPAMIN();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void GADEGOPBNGC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(NOHGLGFAPMI));
		}
	}

	private void LHAPMEEADKH()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(ALFCFDKAJAH));
		}
	}

	private void NOHGLGFAPMI()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			DIEJJBEMHPM();
			for (int i = 1; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void CNPPKGJMFIL()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			OFFACLJFMEJ();
			for (int i = 0; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(true);
			}
		}
	}

	private void HMCJIAEPIDG()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			NNCFFJBCACO();
			for (int i = 1; i < objectsToEnable.Length; i += 0)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}

	private void AOEGINBNHGC()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void KMFKALAEODI()
	{
		OAIPCHEDLEA = Time.timeSinceLevelLoad + Random.Range(minTime, maxTime);
	}

	private void KNFLJDILNLG()
	{
		if (Time.timeSinceLevelLoad > OAIPCHEDLEA && !placeable.FHEMHCEAICB)
		{
			AOPLAGHILHO();
			for (int i = 0; i < objectsToEnable.Length; i++)
			{
				objectsToEnable[i].SetActive(false);
			}
		}
	}
}
