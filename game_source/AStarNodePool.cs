using System.Collections.Generic;
using UnityEngine;

public class AStarNodePool
{
	private readonly Stack<PathRequestManager.AStarNode> HBPBGONMDBL = new Stack<PathRequestManager.AStarNode>(128);

	public void JHAOKEKBOJD(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode AKMJEPMHFMO()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void HLNBKBBDMAG(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public PathRequestManager.AStarNode LPJPJMPOHPG()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode HKCAIFFKBMH()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void CMIHGGGMMFP(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void IBNCKDMHLDM(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode IMLMJAPMBJA()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void LFJNBIHMDDJ(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode PCEEOGGDBFB()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void FPEPPLAPJAI(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode PIOIOJFDDNF()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void HGINBPIKBFL(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void LLIPDBCNNAG(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void PEGJGKLFODJ(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void GNFOCMPJIHE(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void GLANABEBLFL(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void DACEFEKDGKH(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void GNECLFNOMNL(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode GDFNPHJJCPP()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode EJKJJAOHGEL()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode ILDNNNMOCOC()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void PCFCDCCMHCN(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode EOPIEMLAPFN()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void BJEMIADLGJC(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void BGHFKEMKEFG(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void CFEJMCCOCNH(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void PNAFIOICPCD(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void HLENHDIMDAB(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public PathRequestManager.AStarNode ENIICLMAPDJ()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void BNOHJNHGAHF(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void BMINCCOPHLJ(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public PathRequestManager.AStarNode NMCJELBLKBB()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void GMCOBPMEIEG(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void NDDBBMALPPC(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public PathRequestManager.AStarNode OMLGNAJPLDE()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode OCCEHEMCGJF()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode IPDFCJLOHLC()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void BNDKLBKJELE(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void IEOPDCPBNHN(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void CBICIDCININ(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void OMGEMBNPKIE(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void BFDBNFGFEJC(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void KCCFHNGHDEN(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void MDDDFDABCNJ(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void OBAAAFNLGOK(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void PBEGMGLKOCL(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public PathRequestManager.AStarNode LAMFGLIGLOP()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode FFBJPAJKOJH()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void NBICGHPEDMP(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode LKJNAHIPOLN()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void KKJHILKEAGJ(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void CCIOFPILCBN(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void MLMFOMJOIAC(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void EAJKOODEEDH(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void OKHCMLGJDMJ(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void CPNBKDAMLEH(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode HILKHEKNGIF()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode NJOFJHCKGAL()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void OGDAHIKMIIP(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode LMEMFKKKMGJ()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode EKEDKKKPAEE()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void HKMKENKNFPH(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public PathRequestManager.AStarNode EIMDPBGBBIF()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void MBCCFNFJHMN(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void GAJFHFLELHB(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void IHAGPOHCINB(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void LICPLGGBPCC(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void FLADGCACEMJ(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void HCLKKKCNEDI(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode NAGEHKBLJDL()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void OHFJACNFMAP(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void CLFMNPCOIEM(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void HLOCDEFFKJF(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode MIMFFJHBFDJ()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void ONOHAAHGAHJ(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void DFFKMOGLALD(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public PathRequestManager.AStarNode BBDNJAKIBFN()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode MGLNAMHAIDG()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public PathRequestManager.AStarNode JHOHGMODKGM()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void AHIIENJLFEI(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void LNEGMOADHMM(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public PathRequestManager.AStarNode IEPGACAGIPO()
	{
		if (HBPBGONMDBL.Count > 0)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void LJPMLEJJCFL(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void OJLPNOHICMD(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void BMNAGCCLKLH(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public PathRequestManager.AStarNode CJMILOMGFJL()
	{
		if (HBPBGONMDBL.Count > 1)
		{
			return HBPBGONMDBL.Pop();
		}
		return default(PathRequestManager.AStarNode);
	}

	public void NLMGPOGLMDO(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void APCNJNIGMPN(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void MOKEEHPGGDE(PathRequestManager.AStarNode OEFJJFEIBHE)
	{
		HBPBGONMDBL.Push(OEFJJFEIBHE);
	}

	public void KPGAKGHKONI(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void PJGEAFLPNKH(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void AANOOFFFIDL(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void MMDJHHCLBDJ(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}

	public void FCEGNFBLLFM(Dictionary<Vector2, PathRequestManager.AStarNode> AKDNMCEHLOD)
	{
		foreach (KeyValuePair<Vector2, PathRequestManager.AStarNode> item in AKDNMCEHLOD)
		{
			HBPBGONMDBL.Push(item.Value);
		}
	}
}
