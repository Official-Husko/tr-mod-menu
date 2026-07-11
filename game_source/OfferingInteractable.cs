using UnityEngine;

public class OfferingInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[SerializeField]
	private string interactLabel = "Offer";

	[SerializeField]
	private OfferingStatueAnimator _animator;

	private OfferingStatuePuzzle ONCCKDONEFG;

	public bool BAJPKFFHDPJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void GALHOBBBPKC(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.Deactivate();
	}

	public bool ICOEHINGKFF(int JIIGOACEIKL)
	{
		return true;
	}

	public void CDOOEGGKFBB(int JIIGOACEIKL)
	{
	}

	public void CHIEFMKOPHI(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.BJJOHMJACDG();
	}

	public void BBIAGBIAELE(int JIIGOACEIKL)
	{
	}

	public void KLNCEFLAPDP(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.PLOCNJBAAHO();
	}

	public bool FKGGJMDADLA(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.PIJKBBCAJON() && ONCCKDONEFG.CanOpenPuzzle())
		{
			return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).KNFEPKBIHND();
		}
		return true;
	}

	public void BLDCOHEMFIK(int JIIGOACEIKL)
	{
	}

	public void IJOHPJPPHHG(int JIIGOACEIKL)
	{
	}

	public void CJAEDKGEEGC(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.PLOCNJBAAHO();
	}

	public void FMCADMNFHID(int JIIGOACEIKL)
	{
	}

	public void EHCLHLHHCEM(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.PLOCNJBAAHO();
	}

	public void MAIKIONBICN(int JIIGOACEIKL)
	{
	}

	public bool KLPKPIPOBLG(int JIIGOACEIKL)
	{
		return false;
	}

	public bool FMDIGCNHBAP(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MMDECMPNLIL(int JIIGOACEIKL)
	{
		if (!HLDFEKIDJAK(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.JKCEMAMMLJE(JIIGOACEIKL);
		return false;
	}

	public OfferingStatueAnimator GetAnimator()
	{
		return _animator;
	}

	public void NEBIAJNDDOC(int JIIGOACEIKL)
	{
	}

	public bool FMNOFLHKOLL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!JMGDHMFOMDP(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public bool EHDHLMNCLDA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public bool IJOAKPKLADE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!HLDFEKIDJAK(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public OfferingStatueAnimator KAKOKMNPIOM()
	{
		return _animator;
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!CKHHGCILKKK(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public void GDPLNBDKOCB(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.Deactivate();
	}

	public bool FCLHFAJMLBO(int JIIGOACEIKL)
	{
		if (!BANJNCOOACM(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.OpenPuzzle(JIIGOACEIKL);
		return false;
	}

	public bool JEHOCIKPEJD(int JIIGOACEIKL)
	{
		if (!CNADCCGDBPD(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.BJFOFHBOICE(JIIGOACEIKL);
		return false;
	}

	public bool MACDOFEHENF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.MDPKONCJHBI() && ONCCKDONEFG.NKNLLAGJCCF())
		{
			return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	public void GGCCMCLILLH(int JIIGOACEIKL)
	{
	}

	public bool IEPGEGHEKEN(int JIIGOACEIKL)
	{
		if (!CKHHGCILKKK(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.JKCEMAMMLJE(JIIGOACEIKL);
		return false;
	}

	public void FJBPHNEBDEP(int JIIGOACEIKL)
	{
	}

	public bool COPFMLIIOOB(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return true;
		}
		if (!ONCCKDONEFG.PIJKBBCAJON() && ONCCKDONEFG.LFJAIAIJJGD())
		{
			return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool BOCELNICOKA(int JIIGOACEIKL)
	{
		if (!COPFMLIIOOB(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.JKCEMAMMLJE(JIIGOACEIKL);
		return true;
	}

	public bool BDCIGELBCNJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public OfferingStatueAnimator AFNNNMPJFLE()
	{
		return _animator;
	}

	public bool HGAJIMIGBIH(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.MDPKONCJHBI() && ONCCKDONEFG.CanOpenPuzzle())
		{
			return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool DKLAKIBJKID(int JIIGOACEIKL)
	{
		if (!FKGGJMDADLA(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.BJFOFHBOICE(JIIGOACEIKL);
		return false;
	}

	public OfferingStatueAnimator HGJCPEKCCOD()
	{
		return _animator;
	}

	public void NBKMKEEELOM(int JIIGOACEIKL)
	{
	}

	public void Setup(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.Deactivate();
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.OpenPuzzle(JIIGOACEIKL);
		return true;
	}

	public bool BOJEGMBKILO(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public bool JEJAGPHMLLF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!BANJNCOOACM(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public bool BIJCBIGOMEA(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return true;
		}
		if (!ONCCKDONEFG.HKAOHMPIAHC() && ONCCKDONEFG.NKNLLAGJCCF())
		{
			return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	public void BGPEJFDJADD(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.Deactivate();
	}

	public void MMDJIDCALJB(int JIIGOACEIKL)
	{
	}

	public bool CKHHGCILKKK(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.HGBOPAKJNHJ() && ONCCKDONEFG.NKNLLAGJCCF())
		{
			return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	public bool GIPEJKINDHI(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.DDCOMOHHEBB() && ONCCKDONEFG.LFJAIAIJJGD())
		{
			return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	public bool FMCADNOBGKP(int JIIGOACEIKL)
	{
		return false;
	}

	public void GJDKDDMFGBM(int JIIGOACEIKL)
	{
	}

	public bool HBONBNNJPEI(int JIIGOACEIKL)
	{
		if (!CKHHGCILKKK(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.OpenPuzzle(JIIGOACEIKL);
		return false;
	}

	public bool BMLBGBOIOCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void JJLOHJPGDDA(int JIIGOACEIKL)
	{
	}

	public bool LOOGAHBFNLA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!FKGGJMDADLA(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public bool CONCJMINIFL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!JMGDHMFOMDP(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public OfferingStatueAnimator DBAFGMJJEJG()
	{
		return _animator;
	}

	public void GOIMNNEEDCI(int JIIGOACEIKL)
	{
	}

	public void NDJHJHJBPHC(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.HGBOPAKJNHJ() && ONCCKDONEFG.LFJAIAIJJGD())
		{
			return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	public bool HFAILPNNNBB(int JIIGOACEIKL)
	{
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void KECJNJANCEK(int JIIGOACEIKL)
	{
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!BANJNCOOACM(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void BOHBDMHDIDC(int JIIGOACEIKL)
	{
	}

	public OfferingStatueAnimator NFFMFPHPKBE()
	{
		return _animator;
	}

	public bool OMNKOKKEIFI(int JIIGOACEIKL)
	{
		if (!FKGGJMDADLA(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.BJFOFHBOICE(JIIGOACEIKL);
		return true;
	}

	public bool BKGFMLPODHD(int JIIGOACEIKL)
	{
		if (!BANJNCOOACM(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.NCAMBIKPNOE(JIIGOACEIKL);
		return false;
	}

	public OfferingStatueAnimator PNIBABBFGNB()
	{
		return _animator;
	}

	public void ABLEAALPEOO(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.PLOCNJBAAHO();
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public bool HLDFEKIDJAK(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.HGBOPAKJNHJ() && ONCCKDONEFG.LFJAIAIJJGD())
		{
			return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DFNMDDHOIJI();
		}
		return true;
	}

	public void PONPDBMNLCK(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.BJJOHMJACDG();
	}

	public bool CGBBGIFMMDB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool DAGCKCKKKCJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!CKHHGCILKKK(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public void MFGCJPNCFNB(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.PLOCNJBAAHO();
	}

	public bool GFKDNEJHNNI(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.PIJKBBCAJON() && ONCCKDONEFG.CanOpenPuzzle())
		{
			return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	public void PLKFEPAHAEK(int JIIGOACEIKL)
	{
	}

	public void HDMKLMNBMAN(OfferingStatuePuzzle KILHLOPKOMH)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		_animator.BJJOHMJACDG();
	}

	public bool JIOLELDNKIM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!BIJCBIGOMEA(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public void NMPNLEAAJNM(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.OpenPuzzle(JIIGOACEIKL);
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.IsPuzzleSolved() && ONCCKDONEFG.CanOpenPuzzle())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void KDLNDOKFPCC(int JIIGOACEIKL)
	{
	}

	public OfferingStatueAnimator ANBJIJILNAC()
	{
		return _animator;
	}

	public bool CNADCCGDBPD(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.DDCOMOHHEBB() && ONCCKDONEFG.NKNLLAGJCCF())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).GABNNLJOMHI();
		}
		return true;
	}

	public bool FKNBGLEMLFM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void BKOLLDJAOFC(int JIIGOACEIKL)
	{
	}

	public bool KAPFKOCOOCO(int JIIGOACEIKL)
	{
		if (!JMGDHMFOMDP(JIIGOACEIKL))
		{
			return false;
		}
		ONCCKDONEFG.BJFOFHBOICE(JIIGOACEIKL);
		return false;
	}

	public bool IBGDPEAIOLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!GFKDNEJHNNI(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public bool NCMFIAHEIOH(int JIIGOACEIKL)
	{
		return true;
	}

	public OfferingStatueAnimator CAMPPEONOLN()
	{
		return _animator;
	}

	public bool JMGDHMFOMDP(int JIIGOACEIKL)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null)
		{
			return false;
		}
		if (!ONCCKDONEFG.HGBOPAKJNHJ() && ONCCKDONEFG.CanOpenPuzzle())
		{
			return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	public bool MBADIPPGFAO(int JIIGOACEIKL)
	{
		if (!CKHHGCILKKK(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.OpenPuzzle(JIIGOACEIKL);
		return false;
	}

	public bool GIOPJJHBCHJ(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		ONCCKDONEFG.JKCEMAMMLJE(JIIGOACEIKL);
		return false;
	}

	public bool JKDKJKNLIDC(int JIIGOACEIKL)
	{
		return true;
	}

	public void JOHOFKOAIBD(int JIIGOACEIKL)
	{
	}

	public bool BDEEAGGBHCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void PLCEPEDKHLO(int JIIGOACEIKL)
	{
	}

	public bool CEBLDOMPJNI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!HLDFEKIDJAK(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public bool GKJKEDDHMCO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool HEHFGHDILPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}
}
