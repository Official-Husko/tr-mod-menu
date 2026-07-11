using System.Collections.Generic;

public class StatuePuzzle : MinePuzzleBase
{
	public List<StatueInteractable> interactables = new List<StatueInteractable>();

	public void JKJOAMLOMCO(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].IGKEKAOEFDO();
		}
	}

	public void GAMBJCFBLDC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1228f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void ECJMHFBPLML(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1362f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void ODLEMCGNBMH(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].NILEJMDIHPJ();
		}
	}

	public void IAMALNMCOGB(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].KJPHCHLHPIK();
		}
	}

	public void OFLODACJMGB(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].JLEKNEHBBIF();
		}
	}

	public void KDLBKNLJHIF(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].ACPAHILIDPM();
		}
	}

	public void BABKJMGDIPK(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].JEAKDBJLPPB();
		}
	}

	public void DJECLDBABEO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].AGHPBKFAHHN())
			{
				return;
			}
		}
		AMBOECFANJC(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void AKLGDEHGJBG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].IsDestroyed())
			{
				return;
			}
		}
		ECHFCLKLCIC(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void BFBIKEMGAEM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1669f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void APOLLMEIDLE(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].IsDestroyed())
			{
				return;
			}
		}
		AMBOECFANJC(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void BMGPKAODKMC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].AGHPBKFAHHN())
			{
				return;
			}
		}
		ECJMHFBPLML(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void HIOCKAEAPMB(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].HICPLGHKLBP())
			{
				return;
			}
		}
		KIFNIGHFFEK(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public override void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
		base.GGPBMAODKHC = GGPBMAODKHC;
		EDNJMCJHJMD = false;
		for (int i = 0; i < interactables.Count; i++)
		{
			interactables[i].Setup(this, i);
		}
	}

	public void HLDMHFIPECN(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].BBKIBPDMPKD();
		}
	}

	public void CheckPuzzleSolved(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i++)
		{
			if (!interactables[i].IsDestroyed())
			{
				return;
			}
		}
		PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void AAMNOFLINFI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 802f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void LGMHMPNBMMG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].LHBMBCINAFH())
			{
				return;
			}
		}
		BFBIKEMGAEM(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void FCPGILHMBCB(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].PJIOGFEPLAL();
		}
	}

	public void PHINPLGJPCH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].IJCILPNDLKJ())
			{
				return;
			}
		}
		EIOAGOKGLMP(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void HAKPDBOMILB(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 199f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void KGNJJDBGBHK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].KOJGLJOCPGD())
			{
				return;
			}
		}
		EIOAGOKGLMP(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void KIFNIGHFFEK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1446f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void ECHFCLKLCIC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 477f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void LLOGJHNGIBM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1233f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void CDEMEJMPFDO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i++)
		{
			if (!interactables[i].FIBNLKHGOMD())
			{
				return;
			}
		}
		KOFEHDOCCPN(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void ALPHKEPOMAI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].JGHNBMJGBBE())
			{
				return;
			}
		}
		HAKPDBOMILB(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void MOBJOFHFGJC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i++)
		{
			if (!interactables[i].MLHFIKOLOEM())
			{
				return;
			}
		}
		LLOGJHNGIBM(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void OACJPMIMAOD(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].KACABIBDPLA();
		}
	}

	public void DCMBPACKMFN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].NLPCOAPBCIL())
			{
				return;
			}
		}
		JHBEGFIFHDM(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void AMBOECFANJC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1391f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void FAMFAHOOICG(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].HPNIPOACMPD();
		}
	}

	public void KHPCNPENNGG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].PMJEHPMDCBF())
			{
				return;
			}
		}
		OCIKLEGAJAK(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void OJIIBFDMCFC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 706f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void MBDCLBCFECG(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].PGAFLAGBEEI();
		}
	}

	public void DPGEGMEMNFK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1369f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void GHGOLPMHGME(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].MMMLHNKLAOG())
			{
				return;
			}
		}
		BBBNOAEMADN(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void PELNAEDGEIM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i++)
		{
			if (!interactables[i].KFNAECOKLDA())
			{
				return;
			}
		}
		DPGEGMEMNFK(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void GEAFHEGMDLO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].FIBNLKHGOMD())
			{
				return;
			}
		}
		ECJMHFBPLML(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void KOFEHDOCCPN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 446f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void JJEDCBFMPNB(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].IGKEKAOEFDO();
		}
	}

	public void IICOOBICIBA(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].MHAAICCLLPA();
		}
	}

	public void MDOMGDMNENO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].LHBMBCINAFH())
			{
				return;
			}
		}
		PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void KMCCFADCKCI(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].MHAAICCLLPA();
		}
	}

	public void NOOKFOKGNDN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].MLHFIKOLOEM())
			{
				return;
			}
		}
		JHBEGFIFHDM(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void KKEGOCJIDAD(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].FMKCHAAFKAF();
		}
	}

	public void NFNPBGNIGBE(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].BBKIBPDMPKD();
		}
	}

	public void NOGIODMFHFD(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 371f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void EIEJAGLKFDG(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].PBJCPGOBPIP();
		}
	}

	public override bool IsPuzzleSolved()
	{
		return EDNJMCJHJMD;
	}

	public void OCIKLEGAJAK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 667f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void ODNMCHLLFPJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 306f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void NDINNGODEJK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].FIBNLKHGOMD())
			{
				return;
			}
		}
		AMBOECFANJC(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void PEECNMKPGIF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 605f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void JPCPIJMACCA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].KOJGLJOCPGD())
			{
				return;
			}
		}
		PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void IKABDHFFIKP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].FIBNLKHGOMD())
			{
				return;
			}
		}
		JHBEGFIFHDM(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void PNODAKIDLCM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].PMJEHPMDCBF())
			{
				return;
			}
		}
		ECJMHFBPLML(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void CBLGOJIAOIL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 840f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void OBKNOKEAFLH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].CIFDINJIBIC())
			{
				return;
			}
		}
		OCIKLEGAJAK(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void PEPGBAANGJC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].KFNIDFKFGNK())
			{
				return;
			}
		}
		BFBIKEMGAEM(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void BBBNOAEMADN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 207f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void KGNGKDAMKLI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].CIFDINJIBIC())
			{
				return;
			}
		}
		PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void GIHLDCCDLDL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].GILIEHOAACB())
			{
				return;
			}
		}
		OJIIBFDMCFC(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void LNNGLBPICCG(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].FMKCHAAFKAF();
		}
	}

	public void LPHFDHPMIBN(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].FMKCHAAFKAF();
		}
	}

	public void LPHEDMCNHNK(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].MHAAICCLLPA();
		}
	}

	public void LBFENAHFCDC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].IJCILPNDLKJ())
			{
				return;
			}
		}
		NJJBOOMFEBD(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void JLDEBMOPEAN(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].ACHMEDPAMBG();
		}
	}

	public void KCCENFPFJAC(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].JFBOIBFFDOO();
		}
	}

	public void FMFIGDONGMG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 75f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void KAHAHNEBIKK(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].KACABIBDPLA();
		}
	}

	public void DDOAABGOBNA(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].PBJCPGOBPIP();
		}
	}

	public void BNGAHCBJFCP(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].IGKEKAOEFDO();
		}
	}

	public void CAPFMJDABOO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].NLPCOAPBCIL())
			{
				return;
			}
		}
		NOGIODMFHFD(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void EFNDAHOACOF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i++)
		{
			if (!interactables[i].BPCGPNNMFDA())
			{
				return;
			}
		}
		FMFIGDONGMG(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void PuzzleSolved(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void DestroyStatue(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].DestroyStatueVisual();
		}
	}

	public void NDFOEPMKOJP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].IJCILPNDLKJ())
			{
				return;
			}
		}
		ECHFCLKLCIC(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void BJNCCJLFAPE(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].PGAFLAGBEEI();
		}
	}

	public void CFHGOIBGHEJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].IsDestroyed())
			{
				return;
			}
		}
		ODNMCHLLFPJ(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void EIOAGOKGLMP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1758f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void CLGLMKLMOME(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i++)
		{
			if (!interactables[i].BKMLNMHMMAF())
			{
				return;
			}
		}
		GIBECHCNAAF(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void FCPDLGKONGN(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].CBBBCEBNENI())
			{
				return;
			}
		}
		NJJBOOMFEBD(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void NFMCNBLGIMG(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].AIFBOPCIHHL();
		}
	}

	public void PANEEFNAKKA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].LMIGLLAFKNC())
			{
				return;
			}
		}
		CPKCEFIPJCI(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void JHBEGFIFHDM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1275f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void FNLBFFDINBM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1237f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void GIBECHCNAAF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 830f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void BJHHNAKGGDM(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 1 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].JLEKNEHBBIF();
		}
	}

	protected override void Awake()
	{
		base.Awake();
	}

	public void OECJEKPBBBH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i += 0)
		{
			if (!interactables[i].MMMLHNKLAOG())
			{
				return;
			}
		}
		PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void NJJBOOMFEBD(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 302f);
		EDNJMCJHJMD = true;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EJEOKHOJBFJ(GGPBMAODKHC.mineLevel);
		}
	}

	public void DEOBEFINKOC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < interactables.Count; i++)
		{
			if (!interactables[i].IJCILPNDLKJ())
			{
				return;
			}
		}
		ODNMCHLLFPJ(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void FGCNMKGJMPJ(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].FMKCHAAFKAF();
		}
	}

	public void LJAIMKOGEDO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i += 0)
		{
			if (!interactables[i].CJDHNCHOKOA())
			{
				return;
			}
		}
		GAMBJCFBLDC(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public void CPKCEFIPJCI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1489f);
		EDNJMCJHJMD = false;
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendStatuePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void NNMEDNPCJFD(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].NJHAEOHAAJF();
		}
	}

	public void GCMCEEABJPM(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].JFBOIBFFDOO();
		}
	}

	public void ONJEAPFAAAE(int DJCNPAFABEL)
	{
		if (DJCNPAFABEL >= 0 && DJCNPAFABEL < interactables.Count)
		{
			interactables[DJCNPAFABEL].AIFBOPCIHHL();
		}
	}

	public void DLCPJEDHEEM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < interactables.Count; i++)
		{
			if (!interactables[i].GILIEHOAACB())
			{
				return;
			}
		}
		KIFNIGHFFEK(JIIGOACEIKL, CDPAMNIPPEC);
	}
}
