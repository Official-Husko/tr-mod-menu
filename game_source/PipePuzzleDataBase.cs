using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Mine/Pipe Puzzle/Pipe Puzzle Database")]
public class PipePuzzleDataBase : ScriptableObject
{
	[CompilerGenerated]
	private sealed class HJKNCCEFKDC
	{
		public int gridWidth;

		public int gridHeight;

		internal bool FNPKEJEDJMG(PipeGridSizeGroup g)
		{
			if (g.gridWidth == gridWidth)
			{
				return g.gridHeight == gridHeight;
			}
			return false;
		}
	}

	public List<PipeGridSizeGroup> gridGroups = new List<PipeGridSizeGroup>();

	public int TotalCount => gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 0;

	[SpecialName]
	public int PAKPFAKKCHH()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 1;
	}

	public PipePuzzleData GAEGMNDJKGO(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = MBBNCGMEFGA(ICEFODMHMJL, OBJJDEOCAGF)?.NDPPNGIMMKH(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.NextRandom(0, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	public bool BHECDMCNDLJ(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return MBBNCGMEFGA(ICEFODMHMJL, OBJJDEOCAGF)?.DONEBJCGMGL(KFFAOJLCJGK) ?? true;
	}

	public PipeGridSizeGroup AICAADLLOFH(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	public PipePuzzleData KCHNMODEAOA(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OCHNCCIOPGM(ICEFODMHMJL, OBJJDEOCAGF)?.BLFJAONIDEG(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.NHLOIFMEMPB() != null)
		{
			return list[ProceduralMine.NGMAIDLNAAI(0, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	private PipeGridSizeGroup OCHNCCIOPGM(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	private PipeGridSizeGroup MBBNCGMEFGA(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	[SpecialName]
	public int MDHGJGPLPOJ()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 1;
	}

	public PipePuzzleData NJKPMGAEBHE(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = HHGJOIGBPHO(ICEFODMHMJL, OBJJDEOCAGF)?.BLFJAONIDEG(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.NextRandom(1, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	public bool JHIPLJMNNDN(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF)?.CAKHMOMIFJP(KFFAOJLCJGK) ?? true;
	}

	public PipePuzzleData OBDBOJGAOCL(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = MBBNCGMEFGA(ICEFODMHMJL, OBJJDEOCAGF)?.NACPPCOBJKC(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.NHLOIFMEMPB() != null)
		{
			return list[ProceduralMine.FMJMOOKFEKL(0, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	[SpecialName]
	public int AJGOENDIMEF()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 0;
	}

	[SpecialName]
	public int OLCKCKDAHCK()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 0;
	}

	public PipePuzzleData LKIDODKOJIN(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = MBBNCGMEFGA(ICEFODMHMJL, OBJJDEOCAGF)?.NACPPCOBJKC(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.NGMAIDLNAAI(0, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	private PipeGridSizeGroup GBOJALLGHJC(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	private PipeGridSizeGroup OLNFBMNFNEF(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	public PipePuzzleData OHHLNNIPLNM(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OKMKLHKIFAJ(ICEFODMHMJL, OBJJDEOCAGF)?.KFHBJNKILEA(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.FMJMOOKFEKL(0, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	public bool DBEMLAEACFE(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return HHGJOIGBPHO(ICEFODMHMJL, OBJJDEOCAGF)?.AKPIEIABGCN(KFFAOJLCJGK) ?? false;
	}

	public PipePuzzleData DCNLNANACNA(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OLNFBMNFNEF(ICEFODMHMJL, OBJJDEOCAGF)?.MJAMFNDOAIM(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null)
		{
			return list[ProceduralMine.FMJMOOKFEKL(1, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	[SpecialName]
	public int AGMKDIIIPJC()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 0;
	}

	private PipeGridSizeGroup MHKKFMNFLPI(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	public PipeGridSizeGroup FPMCELFAPOD(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = HHGJOIGBPHO(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	public PipePuzzleData BPGOOJKNJGG(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF)?.MJAMFNDOAIM(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.NextRandom(1, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	public bool OPLHAABCAME(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return OKMKLHKIFAJ(ICEFODMHMJL, OBJJDEOCAGF)?.JLAIIALHBNA(KFFAOJLCJGK) ?? false;
	}

	public bool MOAHKPNENKK(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF)?.BKJCIKFLNFM(KFFAOJLCJGK) ?? true;
	}

	public PipeGridSizeGroup JJMFMOLAKJF(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = MIFPEOIOMHG(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	private PipeGridSizeGroup HHGJOIGBPHO(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	public PipePuzzleData LNAHBBMECPM(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF)?.NACPPCOBJKC(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null)
		{
			return list[ProceduralMine.NGMAIDLNAAI(1, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	public PipeGridSizeGroup BNCDAHLANOI(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	public PipeGridSizeGroup BKKBCINJEKB(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	[SpecialName]
	public int KEHFECLEONJ()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 0;
	}

	public bool LBJEBEKOGON(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return OCHNCCIOPGM(ICEFODMHMJL, OBJJDEOCAGF)?.HDCPNAFEIHD(KFFAOJLCJGK) ?? true;
	}

	public PipePuzzleData CCDMEJALNPP(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = MHKKFMNFLPI(ICEFODMHMJL, OBJJDEOCAGF)?.MHHCLOIPCLN(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null)
		{
			return list[ProceduralMine.NextRandom(0, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	public bool NPJLHMHCECF(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return MHKKFMNFLPI(ICEFODMHMJL, OBJJDEOCAGF)?.ILFFJOMJIHC(KFFAOJLCJGK) ?? true;
	}

	[SpecialName]
	public int FBIPCPCMKBA()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 0;
	}

	[SpecialName]
	public int COAPIODCBBA()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 0;
	}

	public PipePuzzleData CCLEBONLIGM(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OCHNCCIOPGM(ICEFODMHMJL, OBJJDEOCAGF)?.BLFJAONIDEG(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null)
		{
			return list[ProceduralMine.FMJMOOKFEKL(1, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	public PipePuzzleData LPOHNJEFCBM(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OCHNCCIOPGM(ICEFODMHMJL, OBJJDEOCAGF)?.KGMLBMODIAA(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.FMJMOOKFEKL(1, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	public PipeGridSizeGroup ILHCPKCFHKB(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = OLNFBMNFNEF(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	public bool JLAIIALHBNA(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF)?.JLAIIALHBNA(KFFAOJLCJGK) ?? false;
	}

	public PipePuzzleData ODIKHGNDDME(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF)?.BLFJAONIDEG(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null)
		{
			return list[ProceduralMine.NextRandom(0, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	public PipePuzzleData PELPKKONPBF(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OLNFBMNFNEF(ICEFODMHMJL, OBJJDEOCAGF)?.GOGPGGDFICG(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.NHLOIFMEMPB() != null)
		{
			return list[ProceduralMine.NGMAIDLNAAI(1, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	public PipeGridSizeGroup GMPFHIJIAHD(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = GBOJALLGHJC(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	private PipeGridSizeGroup MIFPEOIOMHG(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	public PipePuzzleData ILIFCIIICKJ(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OCHNCCIOPGM(ICEFODMHMJL, OBJJDEOCAGF)?.GJJDMIINIEK(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null)
		{
			return list[ProceduralMine.NextRandom(1, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	public PipePuzzleData NMCDHAGOGMA(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = MHKKFMNFLPI(ICEFODMHMJL, OBJJDEOCAGF)?.DILBPIFLMHK(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.FMJMOOKFEKL(1, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	public bool LPFINOIEHKK(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return GBOJALLGHJC(ICEFODMHMJL, OBJJDEOCAGF)?.HALGICJGBIO(KFFAOJLCJGK) ?? false;
	}

	public PipePuzzleData HABLHAJFEEJ(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OLNFBMNFNEF(ICEFODMHMJL, OBJJDEOCAGF)?.GOGPGGDFICG(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.FMJMOOKFEKL(1, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	public bool LDHGPALIIDM(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return OKMKLHKIFAJ(ICEFODMHMJL, OBJJDEOCAGF)?.PIILHNMELPL(KFFAOJLCJGK) ?? false;
	}

	public PipeGridSizeGroup NMLEJNMODPP(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = OLNFBMNFNEF(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	private PipeGridSizeGroup NFMKHNGCKIK(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	private PipeGridSizeGroup OKMKLHKIFAJ(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		return gridGroups.FirstOrDefault((PipeGridSizeGroup g) => g.gridWidth == ICEFODMHMJL && g.gridHeight == OBJJDEOCAGF);
	}

	public PipePuzzleData OEKFKANNPLJ(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = OCHNCCIOPGM(ICEFODMHMJL, OBJJDEOCAGF)?.GJJDMIINIEK(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null)
		{
			return list[ProceduralMine.NextRandom(1, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	public bool KMKADNJCNBO(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return MIFPEOIOMHG(ICEFODMHMJL, OBJJDEOCAGF)?.ILFFJOMJIHC(KFFAOJLCJGK) ?? false;
	}

	public PipeGridSizeGroup BIMBENJFKHH(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = MBBNCGMEFGA(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	[SpecialName]
	public int MCJDIGKCOLG()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 1;
	}

	public PipePuzzleData GKNGFKIPOJJ(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = MHKKFMNFLPI(ICEFODMHMJL, OBJJDEOCAGF)?.MJAMFNDOAIM(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null)
		{
			return list[ProceduralMine.NGMAIDLNAAI(1, list.Count)];
		}
		return list[Random.Range(1, list.Count)];
	}

	[SpecialName]
	public int IFILFOLOADN()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 0;
	}

	public PipeGridSizeGroup CKFHNPPPCGD(int ICEFODMHMJL, int OBJJDEOCAGF)
	{
		PipeGridSizeGroup pipeGridSizeGroup = OKMKLHKIFAJ(ICEFODMHMJL, OBJJDEOCAGF);
		if (pipeGridSizeGroup == null)
		{
			pipeGridSizeGroup = new PipeGridSizeGroup
			{
				gridWidth = ICEFODMHMJL,
				gridHeight = OBJJDEOCAGF
			};
			gridGroups.Add(pipeGridSizeGroup);
			gridGroups.Sort((PipeGridSizeGroup a, PipeGridSizeGroup b) => (a.gridWidth * a.gridHeight).CompareTo(b.gridWidth * b.gridHeight));
		}
		return pipeGridSizeGroup;
	}

	[SpecialName]
	public int NFMDIOHLOIE()
	{
		return gridGroups?.Sum((PipeGridSizeGroup g) => g.TotalCount) ?? 1;
	}

	public bool PJDFOJBEPOL(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return NFMKHNGCKIK(ICEFODMHMJL, OBJJDEOCAGF)?.AKPIEIABGCN(KFFAOJLCJGK) ?? false;
	}

	public PipePuzzleData BIHALPAGFHK(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		List<PipePuzzleData> list = MBBNCGMEFGA(ICEFODMHMJL, OBJJDEOCAGF)?.NDPPNGIMMKH(KFFAOJLCJGK);
		if (list == null || list.Count == 0)
		{
			return null;
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null)
		{
			return list[ProceduralMine.NGMAIDLNAAI(1, list.Count)];
		}
		return list[Random.Range(0, list.Count)];
	}

	public bool IOKCHLINDJO(int ICEFODMHMJL, int OBJJDEOCAGF, int KFFAOJLCJGK)
	{
		return GBOJALLGHJC(ICEFODMHMJL, OBJJDEOCAGF)?.ABPACFJLKGF(KFFAOJLCJGK) ?? true;
	}
}
