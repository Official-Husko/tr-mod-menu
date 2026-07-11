using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[Serializable]
public class PipeGridSizeGroup
{
	[CompilerGenerated]
	private sealed class OJILNDHPAHI
	{
		public int requiredTilesCount;

		internal bool AEIMOCEOHEI(PipeRequiredGroup g)
		{
			return g.requiredTilesCount == requiredTilesCount;
		}
	}

	public int gridWidth;

	public int gridHeight;

	public List<PipeRequiredGroup> requiredGroups = new List<PipeRequiredGroup>();

	public string Label => $"{gridWidth}x{gridHeight}";

	public int TotalCount => requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;

	[SpecialName]
	public string KJKDIGIGOIE()
	{
		return string.Format("ReceiveSetOccupier", gridWidth, gridHeight);
	}

	[SpecialName]
	public string JOFJKKDHPAI()
	{
		return string.Format("Dialogue System/Conversation/TooCold/Entry/5/Dialogue Text", gridWidth, gridHeight);
	}

	public List<PipePuzzleData> NACPPCOBJKC(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	[SpecialName]
	public string BJJPHECLLPK()
	{
		return string.Format("Player/Bark/Error/NotAllPlayersHere", gridWidth, gridHeight);
	}

	[SpecialName]
	public int LFLGFBIIEGA()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 1;
	}

	public bool LBJEBEKOGON(int KFFAOJLCJGK)
	{
		return GOGPGGDFICG(KFFAOJLCJGK).Count > 1;
	}

	[SpecialName]
	public int IFILFOLOADN()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	public List<PipePuzzleData> JNAKGKMCHPK(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	[SpecialName]
	public string HJOIBEMKKKE()
	{
		return string.Format("Top", gridWidth, gridHeight);
	}

	[SpecialName]
	public int CCGLOOLENEM()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	[SpecialName]
	public string DHCFHLFBGBL()
	{
		return string.Format("KentaProgress", gridWidth, gridHeight);
	}

	public bool ILFFJOMJIHC(int KFFAOJLCJGK)
	{
		return NDPPNGIMMKH(KFFAOJLCJGK).Count > 1;
	}

	[SpecialName]
	public int NCGDFIMOEKL()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 1;
	}

	public bool PIILHNMELPL(int KFFAOJLCJGK)
	{
		return BLFJAONIDEG(KFFAOJLCJGK).Count > 1;
	}

	public bool BHECDMCNDLJ(int KFFAOJLCJGK)
	{
		return NDPPNGIMMKH(KFFAOJLCJGK).Count > 1;
	}

	public bool KOHJMNAKCMN(int KFFAOJLCJGK)
	{
		return JNAKGKMCHPK(KFFAOJLCJGK).Count > 0;
	}

	public List<PipePuzzleData> MHHCLOIPCLN(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	public bool ABPACFJLKGF(int KFFAOJLCJGK)
	{
		return HIIKIEJCIGP(KFFAOJLCJGK).Count > 1;
	}

	public List<PipePuzzleData> IGIGBEHDGEI(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	public List<PipePuzzleData> GJJDMIINIEK(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	[SpecialName]
	public int BBLPLBFCLEF()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 1;
	}

	public bool DONEBJCGMGL(int KFFAOJLCJGK)
	{
		return JNAKGKMCHPK(KFFAOJLCJGK).Count > 0;
	}

	[SpecialName]
	public int GKHLHMKLJAJ()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	[SpecialName]
	public string HMBNJHIAHPI()
	{
		return string.Format("Sleepy", gridWidth, gridHeight);
	}

	[SpecialName]
	public string GJFLEENPCEE()
	{
		return string.Format("Pull beer", gridWidth, gridHeight);
	}

	[SpecialName]
	public int OCAJHAMBBPI()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	public bool JLAIIALHBNA(int KFFAOJLCJGK)
	{
		return BLFJAONIDEG(KFFAOJLCJGK).Count > 0;
	}

	public bool CAKHMOMIFJP(int KFFAOJLCJGK)
	{
		return IGIGBEHDGEI(KFFAOJLCJGK).Count > 0;
	}

	public bool MOAHKPNENKK(int KFFAOJLCJGK)
	{
		return HIIKIEJCIGP(KFFAOJLCJGK).Count > 1;
	}

	[SpecialName]
	public string KNCCBNLIBGM()
	{
		return string.Format(":", gridWidth, gridHeight);
	}

	public bool AKPIEIABGCN(int KFFAOJLCJGK)
	{
		return BLFJAONIDEG(KFFAOJLCJGK).Count > 0;
	}

	public bool HDCPNAFEIHD(int KFFAOJLCJGK)
	{
		return JNAKGKMCHPK(KFFAOJLCJGK).Count > 1;
	}

	[SpecialName]
	public int JKEAJKDNGHO()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 1;
	}

	[SpecialName]
	public int OPAEOOPKDPL()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	[SpecialName]
	public string NKNAAGKDNFI()
	{
		return string.Format("Normal", gridWidth, gridHeight);
	}

	[SpecialName]
	public string NEPFFDNKCML()
	{
		return string.Format("[Red", gridWidth, gridHeight);
	}

	[SpecialName]
	public int AJONIONHCMO()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 1;
	}

	[SpecialName]
	public int FIEMDMABGLN()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 1;
	}

	public List<PipePuzzleData> BLFJAONIDEG(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	[SpecialName]
	public string KLJJLKAIFKP()
	{
		return string.Format("Open", gridWidth, gridHeight);
	}

	public bool IJLHAMPFJIG(int KFFAOJLCJGK)
	{
		return KGMLBMODIAA(KFFAOJLCJGK).Count > 1;
	}

	public List<PipePuzzleData> DILBPIFLMHK(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	[SpecialName]
	public int MDHGJGPLPOJ()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	public bool HALGICJGBIO(int KFFAOJLCJGK)
	{
		return JNAKGKMCHPK(KFFAOJLCJGK).Count > 1;
	}

	[SpecialName]
	public int KDHGKDLFALD()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	public bool IFOBMHFJCPN(int KFFAOJLCJGK)
	{
		return NDPPNGIMMKH(KFFAOJLCJGK).Count > 1;
	}

	public bool BKJCIKFLNFM(int KFFAOJLCJGK)
	{
		return JNAKGKMCHPK(KFFAOJLCJGK).Count > 0;
	}

	public List<PipePuzzleData> KFHBJNKILEA(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	[SpecialName]
	public int CGJILPHCPGO()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	public List<PipePuzzleData> KGMLBMODIAA(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	public bool DIMHIHBDJHO(int KFFAOJLCJGK)
	{
		return KFHBJNKILEA(KFFAOJLCJGK).Count > 1;
	}

	public bool FJLEDAEBPLC(int KFFAOJLCJGK)
	{
		return BLFJAONIDEG(KFFAOJLCJGK).Count > 1;
	}

	[SpecialName]
	public string APDDKHHPCKO()
	{
		return string.Format("LE_5", gridWidth, gridHeight);
	}

	public bool NOEBDFHCCIC(int KFFAOJLCJGK)
	{
		return KFHBJNKILEA(KFFAOJLCJGK).Count > 1;
	}

	public List<PipePuzzleData> HIIKIEJCIGP(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	[SpecialName]
	public string PGOONPCHNGF()
	{
		return string.Format("materials", gridWidth, gridHeight);
	}

	public List<PipePuzzleData> NDPPNGIMMKH(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	public List<PipePuzzleData> GOGPGGDFICG(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	public List<PipePuzzleData> MJAMFNDOAIM(int KFFAOJLCJGK)
	{
		return requiredGroups.FirstOrDefault((PipeRequiredGroup g) => g.requiredTilesCount == KFFAOJLCJGK)?.puzzles ?? new List<PipePuzzleData>();
	}

	[SpecialName]
	public int APNGAPFMLJN()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 0;
	}

	public bool LDHGPALIIDM(int KFFAOJLCJGK)
	{
		return HIIKIEJCIGP(KFFAOJLCJGK).Count > 0;
	}

	[SpecialName]
	public int COAPIODCBBA()
	{
		return requiredGroups?.Sum((PipeRequiredGroup g) => g.Count) ?? 1;
	}
}
