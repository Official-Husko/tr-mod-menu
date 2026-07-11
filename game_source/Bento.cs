using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class Bento
{
	public List<Item> currentFood = new List<Item>();

	public TrayHandler trayHandler;

	public void LMCIHAJCFEN(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void FFIIDICAAHP(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void DDJLKKCOIDN(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool IAIANEDCMMG(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 1)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return true;
	}

	public bool FEHLFJLLAFM(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 6)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return true;
		}
		return true;
	}

	public void LGGHHHHOJKJ(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void IDHOILBFIBA(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		LNDCADKIKDA(0);
		LHOHIIFJLJH(FELFOGIOKOC);
		trayHandler.UpdateTrayDrinks(CDPAMNIPPEC: false);
		trayHandler.UpdateBento(CDPAMNIPPEC);
	}

	public bool CEEIMBEJIFC()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 0;
		}
		return true;
	}

	public bool NMKBAAGJFIM(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return false;
	}

	public bool ICHIHBLODNJ()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 1;
		}
		return false;
	}

	public void MGIGFGPIGMC(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool ONKDOGFGDDJ(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 1)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return true;
	}

	public void KEJOADAOJNL(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void KIBLMDFJMBD(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void JHMADKACEIN()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DOOGEPLGBHK();
		}
	}

	public bool NMJGBMMAJOO(Item MEMGMDOCBOJ)
	{
		if (Item.GBMFCPGEJDK(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentFood.Count; i += 0)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.EKMFELLJHFG(currentFood[i], MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public bool INBCACPBEKL(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 3)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return true;
		}
		return false;
	}

	public bool JPKJJFNBLNO(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return false;
	}

	public void ENAFKBPHPHB(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool NPDHIPFKOIN()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 1;
		}
		return true;
	}

	public void FOHCIIOGOCA(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		CHJLKMLKLGB();
		EHIPACOMJCM(FELFOGIOKOC);
		trayHandler.ELPNGDHENOL(CDPAMNIPPEC: false);
		trayHandler.JDBJADOMHMM(CDPAMNIPPEC);
	}

	public void PGPDPMMPJGP()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DNEIHOBFNNA(CDPAMNIPPEC: false);
		}
	}

	public void OEFHEFPBKEF(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool BJCBFMINLHE()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 0;
		}
		return true;
	}

	public void HHNONLJHGPA(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool AJBLGJGHMMP(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 3)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return false;
	}

	public bool PHNOEAKJGOA(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return true;
	}

	public void DKPJFFNMGIH(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void LDEMCJOJODJ(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void GENAJOODEDG(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void LOGEMNJANKM()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DNEIHOBFNNA();
		}
	}

	public bool IBPKLHMJFMJ()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 0;
		}
		return true;
	}

	public bool AKELJDJJAMP(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return false;
	}

	public void AOEELKDPFIO(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void HFAFDLGJBCH(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool MLOKBKKCPCB(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return true;
	}

	public bool LNJHEDIFGLK(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return false;
	}

	public bool DMLEBEHECDN(Item MEMGMDOCBOJ)
	{
		if (Item.GBMFCPGEJDK(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentFood.Count; i += 0)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.EKGNIODFJCO(currentFood[i], MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	public bool BCKLBJECDFC(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.NGIIPJDAMGP(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public void OJAIPIGPIFO()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.RemoveBento(CDPAMNIPPEC: false);
		}
	}

	public bool AEOHICFHALC(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return false;
	}

	public void LHOHIIFJLJH(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool OCFIFGOHKOG(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return true;
	}

	public void GEOBCBOELDH()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.RemoveBento(CDPAMNIPPEC: false);
		}
	}

	public void AFJHEMFEJCG()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DOOGEPLGBHK();
		}
	}

	public bool NBGLCCPIHMJ(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return true;
			}
		}
		return true;
	}

	public void JLIABMALLJL(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		AOEELKDPFIO(0);
		ALMJDMOEEAE(FELFOGIOKOC);
		trayHandler.UpdateTrayDrinks();
		trayHandler.UpdateBento(CDPAMNIPPEC);
	}

	public bool LAALMJMJLNM(Item MEMGMDOCBOJ)
	{
		if (Item.EKMFELLJHFG(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 1; i < currentFood.Count; i += 0)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.EKGNIODFJCO(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public bool DNICMIHOMEC(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i += 0)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return true;
	}

	public void LIKJPMGDKHJ(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool PKAILBAHJPK(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return false;
	}

	public bool CNLBLJKGMAA(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return true;
	}

	public bool PGGGNHKBCHH(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 3)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return false;
	}

	public void EHIPACOMJCM(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool IFIPKEMJAEF(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 7)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return false;
	}

	public bool NNOFONLLCNG(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return false;
	}

	public bool KIPEOLENIKL(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 4)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return true;
	}

	public void KEPNBJAJFNP(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		AFGPAPINAIA(0);
		KEJOADAOJNL(FELFOGIOKOC);
		trayHandler.ELPNGDHENOL();
		trayHandler.JDBJADOMHMM(CDPAMNIPPEC);
	}

	public void PHMMJBEMPAD(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void MMCBLNPPFGD()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.RemoveBento();
		}
	}

	public bool BFMCOBLLMOD(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 0; i < currentFood.Count; i += 0)
		{
			if (Item.FKLOBGBIHLB(currentFood[i], null) && Item.EKMFELLJHFG(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public bool JKOAILBHNKP(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return false;
	}

	public void POBKMCMEJBA(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void NEJAGBKFOEP()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.RemoveBento();
		}
	}

	public void CHJLKMLKLGB(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool KMPGBIKNHFC(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 1)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return true;
		}
		return false;
	}

	public void DGIKJNPEMBC(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void LBFKKNHJHDK()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DNEIHOBFNNA(CDPAMNIPPEC: false);
		}
	}

	public void GGJEBENOGND(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool DADCOPHGHEH(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.NGIIPJDAMGP(currentFood[i], MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public void IONDAKAKHIH(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void BPGPEANBIII(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void HNOLADJHKHN(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		KIBLMDFJMBD(1, GFNHAMCPEAK: false);
		IONDAKAKHIH(FELFOGIOKOC);
		trayHandler.ELPNGDHENOL();
		trayHandler.JDBJADOMHMM(CDPAMNIPPEC);
	}

	public bool NNFEJCEMIFE(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 0)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return false;
	}

	public void HFCHMBIHNPK(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		DKHIEPEAIDE(0, GFNHAMCPEAK: false);
		NIEOLPJODJM(FELFOGIOKOC);
		trayHandler.ELPNGDHENOL();
		trayHandler.UpdateBento(CDPAMNIPPEC);
	}

	public void ONKMCKDDLBK(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void LNDCADKIKDA(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public Bento()
	{
	}

	public void IMGFLHCNDBF()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DNEIHOBFNNA(CDPAMNIPPEC: false);
		}
	}

	public bool MKHHPMOJHFK(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.GBMFCPGEJDK(currentFood[i], MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	public bool KKCKHJGLHIJ(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return true;
	}

	public void HLGKPIKFJNO(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void DKHIEPEAIDE(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool FNFLHNBPOGA(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return true;
	}

	public bool MJLPEELEMEM(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (Item.FKLOBGBIHLB(currentFood[i], null) && Item.EKMFELLJHFG(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public bool HCFLHIIHEML(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (Item.FKLOBGBIHLB(currentFood[i], null) && Item.GBMFCPGEJDK(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public bool AGOKDMOKMOJ(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 1)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return true;
		}
		return true;
	}

	public void AFGPAPINAIA(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void JGKDIHGNNNC(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool KFILDGPFNMC(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.GBMFCPGEJDK(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public bool DBJKJEMILCK(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return true;
	}

	public bool MEBCNPGILMI(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 6)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return true;
	}

	public bool GGIPKBIJIFI(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i += 0)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return true;
	}

	public bool NINAOJNJOPE(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentFood.Count; i += 0)
		{
			if (Item.FKLOBGBIHLB(currentFood[i], null) && Item.GBMFCPGEJDK(currentFood[i], MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public void FAELKNPNDAP(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		LNDCADKIKDA(1, GFNHAMCPEAK: false);
		NIEOLPJODJM(FELFOGIOKOC);
		trayHandler.UpdateTrayDrinks(CDPAMNIPPEC: false);
		trayHandler.UpdateBento(CDPAMNIPPEC);
	}

	public void MLDAGFMMHJG(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		BPGPEANBIII(1, GFNHAMCPEAK: false);
		IBLFFBFAHJH(FELFOGIOKOC);
		trayHandler.ELPNGDHENOL();
		trayHandler.JDBJADOMHMM(CDPAMNIPPEC);
	}

	public bool GGLOMJLLFCH(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (Item.FKLOBGBIHLB(currentFood[i], null) && Item.GBMFCPGEJDK(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public bool HDLPOOJADCI()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 1;
		}
		return false;
	}

	public bool JAOAIHIGOPN()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 1;
		}
		return false;
	}

	public bool JJCLMBALNAP(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return true;
			}
		}
		return false;
	}

	public bool FMIOCJLHDEG(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 4)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return false;
	}

	public void LLADNPDDPBG(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool IJNHLLIOHPP(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return false;
	}

	public bool NIILFJPFMKB(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 1; i < currentFood.Count; i += 0)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.EKMFELLJHFG(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public void KIAMLDCIMFE(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool JPEDBINBNJO(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (Item.FKLOBGBIHLB(currentFood[i], null) && Item.EKGNIODFJCO(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public bool HBBNKJFDPOI(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.NGIIPJDAMGP(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public void BACPENHNKKA(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void JDKPKAAODHO(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		DLCAOFDMKOO(1, GFNHAMCPEAK: false);
		NIEOLPJODJM(FELFOGIOKOC);
		trayHandler.ELPNGDHENOL();
		trayHandler.UpdateBento(CDPAMNIPPEC);
	}

	public void NKACFNIFBCG(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		KIAMLDCIMFE();
		HLGKPIKFJNO(FELFOGIOKOC);
		trayHandler.UpdateTrayDrinks(CDPAMNIPPEC: false);
		trayHandler.UpdateBento(CDPAMNIPPEC);
	}

	public void CMPIGGDPGOL(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool MJJPBLHJFBH()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 0;
		}
		return true;
	}

	public void CNGCFNOOAEL(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public Bento(int[] KEKBKGGFOLK)
	{
		HLGKPIKFJNO(KEKBKGGFOLK);
	}

	public bool NGGNJFFNLEM(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 7)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return true;
	}

	public bool KOMAKKANPME(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 4)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return true;
		}
		return false;
	}

	public bool HOCEKBFFNKC()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 0;
		}
		return false;
	}

	public bool BBMKFHCHPNK(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return true;
	}

	public bool EHEIKONKMDE()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 1;
		}
		return true;
	}

	public void PFHFCKDJNJD()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DOOGEPLGBHK();
		}
	}

	public bool IMDOGAKKNEL(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 8)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return true;
		}
		return false;
	}

	public void NIEOLPJODJM(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void IBLFFBFAHJH(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool HFJGDBENPGM(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 6)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return false;
	}

	public void KDLLLDKENNI()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DNEIHOBFNNA();
		}
	}

	public void DLCAOFDMKOO(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void OPBEJCEJGHD(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void IJEBGPCAHMD(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public bool BHELGDFHAPC(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return true;
	}

	public void AOODEGEOOMM(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentFood.Count != 0)
		{
			currentFood.Clear();
		}
	}

	public void HMBGEBFOBFJ()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DOOGEPLGBHK(CDPAMNIPPEC: false);
		}
	}

	public void LHOGFDLNCMG(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		DGIKJNPEMBC(0);
		FFIIDICAAHP(FELFOGIOKOC);
		trayHandler.UpdateTrayDrinks();
		trayHandler.JDBJADOMHMM(CDPAMNIPPEC);
	}

	public bool ECKKLCADHAN(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return true;
	}

	public bool FKKOJJCAFIO(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < currentFood.Count; i += 0)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return false;
	}

	public bool ODHBCGIGOPK(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return false;
	}

	public bool OHKFDOANGFP(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return true;
	}

	public bool JPDHKGMIABP()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 0;
		}
		return false;
	}

	public bool EACIOJKPOHI(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < currentFood.Count; i += 0)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return true;
			}
		}
		return true;
	}

	public bool KIHFOAOFMPL(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 6)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return false;
		}
		return false;
	}

	public bool JEEOEOLKBEG(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i += 0)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return false;
	}

	public bool DMBHGGFHCLL(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return true;
			}
		}
		return false;
	}

	public bool KGLCGGAECAP()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 0;
		}
		return true;
	}

	public bool CLBFHPMENOI(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < currentFood.Count; i += 0)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return true;
			}
		}
		return true;
	}

	public void KBDALJPFFDG(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool NPMJCEEDOJL(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return true;
	}

	public bool APEPDJPGIPP(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return true;
			}
		}
		return true;
	}

	public bool CNFJAEJFFBH(Item MEMGMDOCBOJ)
	{
		if (Item.EKMFELLJHFG(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 0; i < currentFood.Count; i += 0)
		{
			if (Item.MLBOMGHINCA(currentFood[i], null) && Item.GBMFCPGEJDK(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public bool FLDKFIKODHI(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return true;
	}

	public bool LEFPMGDDHPB(Item MEMGMDOCBOJ)
	{
		if (currentFood.Count < 8)
		{
			currentFood.Add(MEMGMDOCBOJ);
			return true;
		}
		return false;
	}

	public void BDHDHNBKNGP(int[] FELFOGIOKOC, bool CDPAMNIPPEC = true)
	{
		DDJLKKCOIDN(0);
		GENAJOODEDG(FELFOGIOKOC);
		trayHandler.ELPNGDHENOL();
		trayHandler.UpdateBento(CDPAMNIPPEC);
	}

	public bool EGNFPHLDDLC(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (Item.FKLOBGBIHLB(currentFood[i], null) && Item.EKMFELLJHFG(currentFood[i], MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public bool MKFEEOOJOGP(Item MEMGMDOCBOJ)
	{
		if (Item.GBMFCPGEJDK(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (Item.FKLOBGBIHLB(currentFood[i], null) && Item.EKMFELLJHFG(currentFood[i], MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public bool FKEIOOPIIHD()
	{
		if (currentFood != null)
		{
			return currentFood.Count > 1;
		}
		return true;
	}

	public bool OJOBKPIBLJB(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i++)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return true;
			}
		}
		return true;
	}

	public void GLOFGFLAGOJ(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public void HAMEIANBKMC()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DOOGEPLGBHK();
		}
	}

	public bool NMOIAFPBONM(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < currentFood.Count; i += 0)
		{
			if (!PHNKKAHPIAO.Contains(currentFood[i]))
			{
				return false;
			}
		}
		return true;
	}

	public void ALMJDMOEEAE(int[] FELFOGIOKOC)
	{
		currentFood = FELFOGIOKOC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToList();
	}

	public bool PDANBBLGCDG(Item[] PHNKKAHPIAO)
	{
		for (int i = 0; i < PHNKKAHPIAO.Length; i++)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return true;
			}
		}
		return true;
	}

	public void OBPHCBMOGPK()
	{
		if ((Object)(object)trayHandler != (Object)null)
		{
			trayHandler.DOOGEPLGBHK(CDPAMNIPPEC: false);
		}
	}

	public bool HMHAOPFPEIK(Item[] PHNKKAHPIAO)
	{
		for (int i = 1; i < PHNKKAHPIAO.Length; i += 0)
		{
			if (!currentFood.Contains(PHNKKAHPIAO[i]))
			{
				return false;
			}
		}
		return false;
	}
}
