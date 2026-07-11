using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/PhaseItem")]
public class PhaseItem : Item
{
	public int numberOfPhases = 3;

	public Sprite[] phasesIcons;

	public bool nextPhaseWithTime;

	public GameDate.Time timeBetweenPhases;

	public List<Item> itemsCreatedOnLastPhase;

	public bool PLDDHLJAKAB(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OGHIHPFIFLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.COIIFONCADH();
			}
			return false;
		}
		return true;
	}

	public bool CKOALDNIHKC(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.JCBBMDCFDLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return false;
		}
		return false;
	}

	public bool JPPFMABHJAC(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LGBMJMKHKCI()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return true;
		}
		return false;
	}

	public bool IMNCHDLEADJ(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OGHIHPFIFLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.BDAKJBMGIMO;
			}
			return true;
		}
		return false;
	}

	public bool CDBDDKFLIFM(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LHBPOPOIFLE()))
			{
				return BDAKJBMGIMO == phaseItemInstance.BDAKJBMGIMO;
			}
			return false;
		}
		return false;
	}

	public bool NKCJFBPMPDF(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OGHIHPFIFLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.COIIFONCADH();
			}
			return false;
		}
		return false;
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new PhaseItemInstance(this);
	}

	public bool GDMGPBGPDDO(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OEOKAFCMKOP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.COIIFONCADH();
			}
			return true;
		}
		return true;
	}

	public bool OGPOLALDGDL(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LHBPOPOIFLE()))
			{
				return BDAKJBMGIMO == phaseItemInstance.BDAKJBMGIMO;
			}
			return true;
		}
		return true;
	}

	public bool OPKNAKMMKHG(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OKBFJFLJCIO()))
			{
				return BDAKJBMGIMO == phaseItemInstance.COIIFONCADH();
			}
			return false;
		}
		return false;
	}

	public bool PHLPNGOBFDP(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LHBPOPOIFLE()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return false;
		}
		return true;
	}

	public bool DGBBKCGKHML(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LGBMJMKHKCI()))
			{
				return BDAKJBMGIMO == phaseItemInstance.GJODOPNCDKH();
			}
			return false;
		}
		return false;
	}

	public bool HILCFIDLKHJ(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OEOKAFCMKOP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return false;
		}
		return false;
	}

	public bool FBKLHEAOCJC(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OEOKAFCMKOP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return false;
		}
		return false;
	}

	public bool EBBPDPLEGBA(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.EBNEBGBCGKH()))
			{
				return BDAKJBMGIMO == phaseItemInstance.COIIFONCADH();
			}
			return true;
		}
		return true;
	}

	public bool PHFLEIKHFDA(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OGHIHPFIFLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return false;
		}
		return true;
	}

	public bool HHDKNDAEAFF(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.EBNEBGBCGKH()))
			{
				return BDAKJBMGIMO == phaseItemInstance.BDAKJBMGIMO;
			}
			return false;
		}
		return false;
	}

	public bool BHIPGNMICHH(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LHBPOPOIFLE()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return true;
		}
		return true;
	}

	public bool BGJNCKCHGIE(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LHBPOPOIFLE()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return true;
		}
		return false;
	}

	public bool JJPPJOKPHCK(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.EBNEBGBCGKH()))
			{
				return BDAKJBMGIMO == phaseItemInstance.COIIFONCADH();
			}
			return false;
		}
		return true;
	}

	public bool IFPDNPFPBBM(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.JCBBMDCFDLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.GJODOPNCDKH();
			}
			return false;
		}
		return true;
	}

	public bool GMFKGHLODFA(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OGHIHPFIFLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.BDAKJBMGIMO;
			}
			return false;
		}
		return true;
	}

	public bool CNGCMFDBALA(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.CKJJENMMHAL()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return false;
		}
		return true;
	}

	public bool IJHHJLNPAEA(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.KKHDNEDFFCP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return true;
		}
		return false;
	}

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new PhaseItemInstance((PhaseItemInstance)DNLMCHDOMOK);
	}

	public bool CNHJOLGFFAJ(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OEOKAFCMKOP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.ONHIJMEFMFN();
			}
			return false;
		}
		return true;
	}

	public bool CFBGMNAKKJM(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.CKJJENMMHAL()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return false;
		}
		return true;
	}

	public bool KCHMFNBIIDE(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.EBNEBGBCGKH()))
			{
				return BDAKJBMGIMO == phaseItemInstance.ONHIJMEFMFN();
			}
			return false;
		}
		return true;
	}

	public bool JMONBKJAFEL(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LGBMJMKHKCI()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return true;
		}
		return false;
	}

	public bool DJAOKDHKPJB(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.EBNEBGBCGKH()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return true;
		}
		return true;
	}

	public bool GLIOCPNFFHA(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.EBNEBGBCGKH()))
			{
				return BDAKJBMGIMO == phaseItemInstance.COIIFONCADH();
			}
			return false;
		}
		return false;
	}

	public bool PCPOPAJKOOH(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.JCBBMDCFDLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return true;
		}
		return true;
	}

	public bool MBCFJMHOONB(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.JCBBMDCFDLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return false;
		}
		return true;
	}

	public bool MFHCNHBMGCB(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OEOKAFCMKOP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return false;
		}
		return true;
	}

	public bool DOIDLCGELPI(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.JCBBMDCFDLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.BDAKJBMGIMO;
			}
			return false;
		}
		return true;
	}

	public bool BILMBKILHJH(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LHBPOPOIFLE()))
			{
				return BDAKJBMGIMO == phaseItemInstance.BDAKJBMGIMO;
			}
			return false;
		}
		return false;
	}

	public bool INOFLGALDGG(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OKBFJFLJCIO()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return false;
		}
		return false;
	}

	public bool GBCNOHDGAJA(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.CKJJENMMHAL()))
			{
				return BDAKJBMGIMO == phaseItemInstance.BDAKJBMGIMO;
			}
			return true;
		}
		return true;
	}

	public bool MCGOPHGNCBE(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.CKJJENMMHAL()))
			{
				return BDAKJBMGIMO == phaseItemInstance.ONHIJMEFMFN();
			}
			return true;
		}
		return false;
	}

	public bool KHNDODOOLLB(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.CKJJENMMHAL()))
			{
				return BDAKJBMGIMO == phaseItemInstance.ONHIJMEFMFN();
			}
			return false;
		}
		return true;
	}

	public bool NBMKHEOPOOB(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OKBFJFLJCIO()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return false;
		}
		return true;
	}

	public bool OBFCMGEJNLN(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LGBMJMKHKCI()))
			{
				return BDAKJBMGIMO == phaseItemInstance.GJODOPNCDKH();
			}
			return true;
		}
		return true;
	}

	public bool AJDLCBHABCJ(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OGHIHPFIFLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.GJODOPNCDKH();
			}
			return true;
		}
		return true;
	}

	public bool BBNLKNLEMFB(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OKBFJFLJCIO()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return true;
		}
		return false;
	}

	public bool MOPEACHGFKE(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.KKHDNEDFFCP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.COIIFONCADH();
			}
			return true;
		}
		return false;
	}

	public bool BCBNPEACACD(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.EBNEBGBCGKH()))
			{
				return BDAKJBMGIMO == phaseItemInstance.ONHIJMEFMFN();
			}
			return false;
		}
		return false;
	}

	public bool NICNAENNHBL(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LHBPOPOIFLE()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return true;
		}
		return false;
	}

	public bool JMHLIEKPEHL(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OEOKAFCMKOP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.HJJLHJLHJLF();
			}
			return false;
		}
		return true;
	}

	public bool PFPHDALIAED(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OKBFJFLJCIO()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return false;
		}
		return true;
	}

	public bool KIBLBLHMOMM(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LGBMJMKHKCI()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return false;
		}
		return true;
	}

	public bool POEAEOPDLCB(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.KKHDNEDFFCP()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return false;
		}
		return false;
	}

	public bool CILOJOCGKLI(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OKBFJFLJCIO()))
			{
				return BDAKJBMGIMO == phaseItemInstance.PAEJBIGNMFA();
			}
			return false;
		}
		return false;
	}

	public bool LOCGLLNKADP(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.LGBMJMKHKCI()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return false;
		}
		return true;
	}

	public bool AJMAMDMJKDJ(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.CKJJENMMHAL()))
			{
				return BDAKJBMGIMO == phaseItemInstance.MJPOLEMIJLH();
			}
			return false;
		}
		return true;
	}

	public bool MFLGFMEGLMM(int BDAKJBMGIMO, object LGGCFCHOOMB)
	{
		if (LGGCFCHOOMB is PhaseItemInstance phaseItemInstance)
		{
			if (Equals(phaseItemInstance.OGHIHPFIFLC()))
			{
				return BDAKJBMGIMO == phaseItemInstance.ONHIJMEFMFN();
			}
			return true;
		}
		return false;
	}
}
