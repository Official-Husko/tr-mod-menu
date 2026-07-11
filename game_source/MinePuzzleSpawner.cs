using UnityEngine;

public class MinePuzzleSpawner : MonoBehaviour
{
	[SerializeField]
	public PuzzleSpawnerType allowedPuzzleTypes;

	[SerializeField]
	private PuzzleSpawnerVisual[] visuals;

	[SerializeField]
	private MineVariant parentVariant;

	public bool forceActivate;

	public PuzzleSpawnerType OHHEPOABLLM()
	{
		return allowedPuzzleTypes;
	}

	public void CDOGBMNPCCF()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void BAJCFGKJAMH()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void CNHIBBJOIFF()
	{
		for (int i = 0; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public PuzzleSpawnerType CGNCNGHPOIH()
	{
		return allowedPuzzleTypes;
	}

	public bool KAPDADIELEK(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public bool EIKBMNPAAFA(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public bool IsPuzzleTypeAllowed(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public PuzzleSpawnerType BIPAGOAOLAA()
	{
		return allowedPuzzleTypes;
	}

	public bool MPECAPCKPHC()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)(">" + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.MIGCLHCHKDP();
		return true;
	}

	public bool MPPGGDJDHFK(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public bool AIGHLECFLPH(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void IOHFMOAKMPF()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool ActivateVariant()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("[MinePuzzleSpawner] No se ha asignado un MineVariant padre para el spawner en " + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.ActivateVariant();
		return true;
	}

	public PuzzleSpawnerType PNOODMNNFDI()
	{
		return allowedPuzzleTypes;
	}

	public bool LHENKBOPFKP()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("Interact" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.EEIGHAJIPIB();
		return false;
	}

	public bool LNLAMNFMDPC()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("con {0} tiles requeridos." + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.LNLAMNFMDPC();
		return false;
	}

	public bool HJGHHCODHBO(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public PuzzleSpawnerType NNEDKHOOKMJ()
	{
		return allowedPuzzleTypes;
	}

	public void OLLDMNKEDGO()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 0; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public void Start()
	{
		DesactivateVisuals();
	}

	public PuzzleSpawnerType KDHPBMDPKHB()
	{
		return allowedPuzzleTypes;
	}

	public PuzzleSpawnerType BBEPHDAPPML()
	{
		return allowedPuzzleTypes;
	}

	public bool HCCNOELPJFN(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void OHLEOKIMMKK()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void CAOKPIIFHBJ()
	{
		HEODOAFGPGE();
	}

	public bool JILOMNIBHFJ(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void EJGHEEFALJL()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void HNIPHNKJADP()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 0; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public void KJBIDNLHOMD()
	{
		KHFGNMJAAKL();
	}

	public bool OJMLKOJIPHO(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void KEDJCEGFJNB()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 0; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool CHNEOGFIDCK(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void GJMLHECPGBP()
	{
		CKNLCEHBFOP();
	}

	public bool BOAKNMNBPOI()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("LE_1" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.MIGCLHCHKDP();
		return false;
	}

	public bool NOBGICABFKD()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("/ExtraSettings.sd" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.DAINIKDJHKM();
		return true;
	}

	public void LPHGBJCMFOI()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void ODKGLIDMCNP()
	{
		OHLEOKIMMKK();
	}

	public void LPHCFGEAPFB()
	{
		for (int i = 1; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void NLFHFPHDNCF()
	{
		CNHIBBJOIFF();
	}

	public bool MGBNKCLLKMJ()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("in" + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.EEIGHAJIPIB();
		return false;
	}

	public void IMIONHLAKIH()
	{
		LPHCFGEAPFB();
	}

	public void CKNLCEHBFOP()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void KJOJLHCDFPP()
	{
		EEJJMICDEIL();
	}

	public bool GHEKEHPBEKJ(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void HPIMHEMJMAA()
	{
		EJGHEEFALJL();
	}

	public PuzzleSpawnerType NJALKBLNMOJ()
	{
		return allowedPuzzleTypes;
	}

	public PuzzleSpawnerType IDKLNHOEPJM()
	{
		return allowedPuzzleTypes;
	}

	public void KHFGNMJAAKL()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void LOLMIAPJEIF()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void EGACIHOKJLH()
	{
		OPDIENELLDA();
	}

	public PuzzleSpawnerType IHDCDGIHFAE()
	{
		return allowedPuzzleTypes;
	}

	public bool FGLFEFHDKMF()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("descOldDoormat" + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.DMIAKEKBENF();
		return false;
	}

	public bool PBLBOONLEIK()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("Dialogue System/Conversation/NeutralInTavern/Entry/7/Dialogue Text" + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.JICOBKPJMEJ();
		return true;
	}

	public void MLLADNLMIMP()
	{
		OPDIENELLDA();
	}

	public void HPDGPEFFGOG()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public bool LNADNOJAPGI(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public bool BGCCNFCCNAK()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("\n" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.NJNMBBFEDGP();
		return false;
	}

	public PuzzleSpawnerType CGHDIPIAJNK()
	{
		return allowedPuzzleTypes;
	}

	public void EEJJMICDEIL()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void FBNIJPEJDCL()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public PuzzleSpawnerType IMJPFABPDBF()
	{
		return allowedPuzzleTypes;
	}

	public void BJIFMDFPNEI()
	{
		for (int i = 1; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public PuzzleSpawnerType GetSpawnerType()
	{
		return allowedPuzzleTypes;
	}

	public PuzzleSpawnerType BBHIINMAFEF()
	{
		return allowedPuzzleTypes;
	}

	public bool IFIAPCNIAFA(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void LLCIMPOCNDN()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool NOBGMJPKKJF()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("#.##%" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.ONBGOHKMKOF();
		return false;
	}

	public void PLHPEMNDAFB()
	{
		CDOGBMNPCCF();
	}

	public void NJICCENKPFJ()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public PuzzleSpawnerType LHCBFJJAAOI()
	{
		return allowedPuzzleTypes;
	}

	public PuzzleSpawnerType JJJMIEBJMBO()
	{
		return allowedPuzzleTypes;
	}

	public void INMOLEDNFKG()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool JICOBKPJMEJ()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("privatetest" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.LNLAMNFMDPC();
		return false;
	}

	public PuzzleSpawnerType ALCCPHMCBJO()
	{
		return allowedPuzzleTypes;
	}

	public void PKBHEKHOAAA()
	{
		BAJCFGKJAMH();
	}

	public void PMBBMKOKCFH()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool CHLIIFBKEFC()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("Waiting for players to finish their transitions..." + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.DFFCOAMDPCD();
		return true;
	}

	public bool FMLBOOOHIKK(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void IFHLGOMBACP()
	{
		BHKLGOAEPFL();
	}

	public void LAGGFECNPPA()
	{
		for (int i = 1; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void IPENBHNLEBI()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void HEODOAFGPGE()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void OCBNLECPJBN()
	{
		CDOGBMNPCCF();
	}

	public bool KLHKHKLOPHK()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("EngineControlsCanvas/EngineControlSection" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.BGCCNFCCNAK();
		return false;
	}

	public bool MCCOJFCNPFG()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("Unique crop not found! Unique ID: " + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.LNAEOICBCNJ();
		return false;
	}

	public bool PGHIPHDEGPL()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("repUnlockFarmCarp" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.COEPDBMBDKC();
		return true;
	}

	public void NNBIAIMPNGL()
	{
		LAGGFECNPPA();
	}

	public void ILADLPGFKAJ()
	{
		for (int i = 0; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public bool BJCMOOEHHGO()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("CalmRowdyCustomer" + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.GCGFBHGLCEJ();
		return true;
	}

	public void IJHDOMJFGCI()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public void EKNIMLDJPNK()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void DesactivateVisuals()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void OPDIENELLDA()
	{
		for (int i = 0; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public bool NKJGLHOMJGG()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("Pause" + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.DFFCOAMDPCD();
		return false;
	}

	public PuzzleSpawnerType MAIAICLBPCI()
	{
		return allowedPuzzleTypes;
	}

	public bool EIHANPKHOEH()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("Book" + ((Object)((Component)this).gameObject).name));
			return true;
		}
		parentVariant.GLBIHCBNIAK();
		return true;
	}

	public void PGJJBPALEGM()
	{
		KFLCKHNDAPA();
	}

	public void GKNFLLCEKAM()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public void ActivateVisuals()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 0; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public void GKJOEALENMG()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 0; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool CKOHOLLEFHB(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public bool AOAOBHELPJA(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public bool PNPMJDDODGD()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("ChatCommandLockDescription" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.CHLIIFBKEFC();
		return true;
	}

	public void LMPFENIGNLB()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public void OIBDBLCLACB()
	{
		KFLCKHNDAPA();
	}

	public void LFPGDGAKPBD()
	{
		APHBOGFNPHC();
	}

	public void OJPAAEIACJH()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool HFEJCILGOMO()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("vip" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.FINGBJHNDJE();
		return true;
	}

	public PuzzleSpawnerType DEGKOBMBNOF()
	{
		return allowedPuzzleTypes;
	}

	public void MFMMHDPGCBO()
	{
		FBNIJPEJDCL();
	}

	public void ANKODAGCBNL()
	{
		for (int i = 0; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public PuzzleSpawnerType HONELBLCMFO()
	{
		return allowedPuzzleTypes;
	}

	public bool EPNLHNFMHOH(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void IPMDKJPLPLI()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool GEBOMKGNAMP()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("Items/item_name_1116" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.DAINIKDJHKM();
		return false;
	}

	public void APHBOGFNPHC()
	{
		for (int i = 0; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public bool CIIIOEHBJGA(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void BFBECJAAPAP()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 0; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool IOHODEFFFBG(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void DNPFMCHJLFL()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void FKPNIHJGFBJ()
	{
		OHLEOKIMMKK();
	}

	public void FFAOEJCBLNF()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public void DCEAPGJPADF()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool DHJPLGIPECP(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public PuzzleSpawnerType LDEKKJCPLDK()
	{
		return allowedPuzzleTypes;
	}

	public void LJOBDHPMNPJ()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public bool IFDBGAKNNEP()
	{
		if ((Object)(object)parentVariant == (Object)null)
		{
			Debug.LogWarning((object)("This ingredient is temporarily available" + ((Object)((Component)this).gameObject).name));
			return false;
		}
		parentVariant.CHLIIFBKEFC();
		return true;
	}

	public void NDIMCKOLGNP()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 0; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public void NKKGIMMCMMG()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void BHKLGOAEPFL()
	{
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public bool IKKLAPLEOMC(PuzzleSpawnerType NCMDEGABGCH)
	{
		return allowedPuzzleTypes.HasFlag(NCMDEGABGCH);
	}

	public void KFLCKHNDAPA()
	{
		for (int i = 0; i < visuals.Length; i += 0)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(true);
			}
		}
	}

	public PuzzleSpawnerType MJNGMFEFKKO()
	{
		return allowedPuzzleTypes;
	}

	public void FCCKKMOOGKF()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 1; i < visuals.Length; i += 0)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}

	public void ELNODGGEIAG()
	{
		for (int i = 0; i < visuals.Length; i++)
		{
			if ((Object)(object)visuals[i].visual != (Object)null)
			{
				visuals[i].visual.SetActive(false);
			}
		}
	}

	public void PBFGFECPPPO()
	{
		KHFGNMJAAKL();
	}

	public void AHPCMAAEDPM()
	{
		if (visuals == null)
		{
			return;
		}
		for (int i = 0; i < visuals.Length; i++)
		{
			if (!((Object)(object)visuals[i].visual == (Object)null))
			{
				visuals[i].visual.SetActive(allowedPuzzleTypes.HasFlag(visuals[i].type));
			}
		}
	}
}
