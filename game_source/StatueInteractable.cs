using AlmenaraGames;
using UnityEngine;

public class StatueInteractable : MonoBehaviour
{
	public int statueID;

	[SerializeField]
	private GameObject normalGameObject;

	[SerializeField]
	private GameObject destroyedGameObject;

	[SerializeField]
	private AudioObject destroySound;

	[SerializeField]
	private HitDetection hitDetection;

	private StatuePuzzle GEEBMKNIHFN;

	public void HAFHBLDGEGL()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !BCGHPKPONPK() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.CHJCACCDMIP().mineLevel, statueID);
			ACPAHILIDPM();
			GEEBMKNIHFN.OECJEKPBBBH(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool BPCGPNNMFDA()
	{
		return destroyedGameObject.activeSelf;
	}

	public void KCDEOOOJIOD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public bool JGHNBMJGBBE()
	{
		return destroyedGameObject.activeSelf;
	}

	public void EKBOMNKBHCP(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
	}

	public void NBNPBGHNENJ()
	{
		if (!GEEBMKNIHFN.HGBOPAKJNHJ() && !HICPLGHKLBP() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.CEMEKIJMEAN().mineLevel, statueID);
			FMKCHAAFKAF();
			GEEBMKNIHFN.KGNGKDAMKLI(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void MMPFMOKKCMI()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !LMIGLLAFKNC() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.CEMEKIJMEAN().mineLevel, statueID);
			JLEKNEHBBIF();
			GEEBMKNIHFN.GHGOLPMHGME(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void GJEDOBKKMNI(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
	}

	public bool BCGHPKPONPK()
	{
		return destroyedGameObject.activeSelf;
	}

	public void MEPNCPCNANF()
	{
		if (!GEEBMKNIHFN.PIJKBBCAJON() && !JGHNBMJGBBE() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.CHJCACCDMIP().mineLevel, statueID);
			HEJPKJKLFGN();
			GEEBMKNIHFN.CAPFMJDABOO(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void AHCPOAOININ()
	{
		if (!GEEBMKNIHFN.HGBOPAKJNHJ() && !BCGHPKPONPK() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.AJHGOJEHLED().mineLevel, statueID);
			BBKIBPDMPKD();
			GEEBMKNIHFN.AKLGDEHGJBG(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void JLEKNEHBBIF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void NILEJMDIHPJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void OLPBEKAOBHE()
	{
		if (!GEEBMKNIHFN.HKAOHMPIAHC() && !BCGHPKPONPK() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.GetManager().mineLevel, statueID);
			PJIOGFEPLAL();
			GEEBMKNIHFN.KGNGKDAMKLI(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool NLPCOAPBCIL()
	{
		return destroyedGameObject.activeSelf;
	}

	public bool IJCILPNDLKJ()
	{
		return destroyedGameObject.activeSelf;
	}

	public void ACPAHILIDPM()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public bool FKNJNJINMPM()
	{
		return destroyedGameObject.activeSelf;
	}

	public bool CIFDINJIBIC()
	{
		return destroyedGameObject.activeSelf;
	}

	public void GFIHPDAAOKN()
	{
		if (!GEEBMKNIHFN.HGBOPAKJNHJ() && !GILIEHOAACB() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			JEAKDBJLPPB();
			GEEBMKNIHFN.EFNDAHOACOF(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool KFNAECOKLDA()
	{
		return destroyedGameObject.activeSelf;
	}

	public void CLEAPIKELIN()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !JGHNBMJGBBE() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			JLEKNEHBBIF();
			GEEBMKNIHFN.FCPDLGKONGN(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void GBDALPGENAN()
	{
		if (!GEEBMKNIHFN.APPEDHAFFBP() && !DOFFCEFPBLB() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.AJHGOJEHLED().mineLevel, statueID);
			NJHAEOHAAJF();
			GEEBMKNIHFN.PHINPLGJPCH(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public bool ELNMFDBBFOG()
	{
		return destroyedGameObject.activeSelf;
	}

	public void IGJPFBMGJJM(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public void JAGNAPJKJPG(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
	}

	public void DDGPINFNJCC()
	{
		if (!GEEBMKNIHFN.HKAOHMPIAHC() && !PMJEHPMDCBF() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.GetManager().mineLevel, statueID);
			KCDEOOOJIOD();
			GEEBMKNIHFN.HIOCKAEAPMB(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool KOJGLJOCPGD()
	{
		return destroyedGameObject.activeSelf;
	}

	public void KACABIBDPLA()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void IFGEGFHECHM(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public void FAIBAMJDDCK(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
	}

	public void MMCNBAFLFPD(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
	}

	public void JHJBAKPPJKC(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public void FJAOMGJLDOA(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
	}

	public void BDKKEFMJDFO()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !BCGHPKPONPK() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.CHJCACCDMIP().mineLevel, statueID);
			JLEKNEHBBIF();
			GEEBMKNIHFN.KGNGKDAMKLI(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void ODKCAOICJMP(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public void CKIPFELJDNM(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
	}

	public void EHGKEJGIDBI(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public void EMMOCJDJBKB()
	{
		if (!GEEBMKNIHFN.APPEDHAFFBP() && !CJDHNCHOKOA() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.GetManager().mineLevel, statueID);
			BBKIBPDMPKD();
			GEEBMKNIHFN.PANEEFNAKKA(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void ONMOHGMGAGE()
	{
		if (!GEEBMKNIHFN.MDPKONCJHBI() && !IJCILPNDLKJ() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.CHJCACCDMIP().mineLevel, statueID);
			NILEJMDIHPJ();
			GEEBMKNIHFN.FCPDLGKONGN(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void BCPFKDAKEFD()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !BKMLNMHMMAF() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.CEMEKIJMEAN().mineLevel, statueID);
			JLEKNEHBBIF();
			GEEBMKNIHFN.FCPDLGKONGN(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public bool HCKDMFMEPFN()
	{
		return destroyedGameObject.activeSelf;
	}

	public void KEMOPONAMKO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void MHIODEJJJDF(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public void AJKCMMMIAKB()
	{
		if (!GEEBMKNIHFN.HGBOPAKJNHJ() && !KFNIDFKFGNK() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			KEMOPONAMKO();
			GEEBMKNIHFN.DEOBEFINKOC(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void MHAAICCLLPA()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void BODPLMGKMIC()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !FIBNLKHGOMD() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.CEMEKIJMEAN().mineLevel, statueID);
			MHAAICCLLPA();
			GEEBMKNIHFN.GEAFHEGMDLO(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void PJIOGFEPLAL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void Setup(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
	}

	public void FJFDCCFFEJC()
	{
		if (!GEEBMKNIHFN.PIJKBBCAJON() && !KFNAECOKLDA() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.CEMEKIJMEAN().mineLevel, statueID);
			NILEJMDIHPJ();
			GEEBMKNIHFN.LJAIMKOGEDO(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool AGHPBKFAHHN()
	{
		return destroyedGameObject.activeSelf;
	}

	public bool GILIEHOAACB()
	{
		return destroyedGameObject.activeSelf;
	}

	public void BBKIBPDMPKD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void LKGOGINNCJF(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
	}

	public void JNOFEBGBEPE()
	{
		if (!GEEBMKNIHFN.APPEDHAFFBP() && !BCGHPKPONPK() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.GetManager().mineLevel, statueID);
			BBKIBPDMPKD();
			GEEBMKNIHFN.CAPFMJDABOO(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void BJPBGLILOKI(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public void JFBOIBFFDOO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public bool MMMLHNKLAOG()
	{
		return destroyedGameObject.activeSelf;
	}

	public void MFGCJPNCFNB(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
	}

	public void KJPHCHLHPIK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void EAMNMIIILJL(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
	}

	public void HEELOCBKBFM()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !ELNMFDBBFOG() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.GetManager().mineLevel, statueID);
			ACPAHILIDPM();
			GEEBMKNIHFN.BMGPKAODKMC(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool CJDHNCHOKOA()
	{
		return destroyedGameObject.activeSelf;
	}

	public void APEGAMEGCAB(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
	}

	public bool CBBBCEBNENI()
	{
		return destroyedGameObject.activeSelf;
	}

	public void PAECFIAACMF()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !ELNMFDBBFOG() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			KJPHCHLHPIK();
			GEEBMKNIHFN.HIOCKAEAPMB(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void FMKCHAAFKAF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void GFHLEPNIIOC()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !CBBBCEBNENI() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.BELBIDDGNJN().mineLevel, statueID);
			ACPAHILIDPM();
			GEEBMKNIHFN.BMGPKAODKMC(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void JCJBPAPGHHP()
	{
		if (!GEEBMKNIHFN.PIJKBBCAJON() && !AGHPBKFAHHN() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.BELBIDDGNJN().mineLevel, statueID);
			HPNIPOACMPD();
			GEEBMKNIHFN.ALPHKEPOMAI(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool FIBNLKHGOMD()
	{
		return destroyedGameObject.activeSelf;
	}

	public void LGINIMJCLDA()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !DOFFCEFPBLB() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			DestroyStatueVisual();
			GEEBMKNIHFN.GIHLDCCDLDL(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void AIFBOPCIHHL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void CPMAKHJCCIH(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public void FANGMFJIHLC()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !AGHPBKFAHHN() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.CEMEKIJMEAN().mineLevel, statueID);
			ACHMEDPAMBG();
			GEEBMKNIHFN.NOOKFOKGNDN(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void FJGCMKGDGIO(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
	}

	public void PBJCPGOBPIP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void BBIMGMGAKFC(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(true);
	}

	public bool KFNIDFKFGNK()
	{
		return destroyedGameObject.activeSelf;
	}

	public bool LMIGLLAFKNC()
	{
		return destroyedGameObject.activeSelf;
	}

	public void JEAKDBJLPPB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void NJHAEOHAAJF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public bool JJHNJIOKJGC()
	{
		return destroyedGameObject.activeSelf;
	}

	public void LPIIMCPILON()
	{
		if (!GEEBMKNIHFN.PIJKBBCAJON() && !KFNIDFKFGNK() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			JLEKNEHBBIF();
			GEEBMKNIHFN.CAPFMJDABOO(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void HPNIPOACMPD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void LCLIMFJKGKN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void HANAGOELPBB()
	{
		if (!GEEBMKNIHFN.APPEDHAFFBP() && !HICPLGHKLBP() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.CEMEKIJMEAN().mineLevel, statueID);
			LCLIMFJKGKN();
			GEEBMKNIHFN.LJAIMKOGEDO(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void IKNINHBHOOL()
	{
		if (!GEEBMKNIHFN.APPEDHAFFBP() && !BCGHPKPONPK() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.BELBIDDGNJN().mineLevel, statueID);
			KACABIBDPLA();
			GEEBMKNIHFN.GIHLDCCDLDL(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void DCBFECMFHIA()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !LMIGLLAFKNC() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			LCLIMFJKGKN();
			GEEBMKNIHFN.OBKNOKEAFLH(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void HEJPKJKLFGN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void FHPMPMONPBD()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !DOFFCEFPBLB() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			BJHEOFKFCAB();
			GEEBMKNIHFN.BMGPKAODKMC(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void DestroyStatueVisual()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public bool LHBMBCINAFH()
	{
		return destroyedGameObject.activeSelf;
	}

	public void PDFDCIEIPGP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void PGAFLAGBEEI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public bool PMJEHPMDCBF()
	{
		return destroyedGameObject.activeSelf;
	}

	public bool IsDestroyed()
	{
		return destroyedGameObject.activeSelf;
	}

	public void IDHJEDHEFDD(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
	}

	public void IGKEKAOEFDO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void HOCALAJDCNB()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !FIBNLKHGOMD() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.BELBIDDGNJN().mineLevel, statueID);
			JLEKNEHBBIF();
			GEEBMKNIHFN.PEPGBAANGJC(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void GLNFHGNFJME(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
	}

	public void AKGNIPHPEKJ(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
	}

	public void ACHMEDPAMBG()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}

	public void EAPHJDCHJOO()
	{
		if (!GEEBMKNIHFN.HKAOHMPIAHC() && !JGHNBMJGBBE() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			HPNIPOACMPD();
			GEEBMKNIHFN.HIOCKAEAPMB(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public bool BKMLNMHMMAF()
	{
		return destroyedGameObject.activeSelf;
	}

	public bool HICPLGHKLBP()
	{
		return destroyedGameObject.activeSelf;
	}

	public void LPDEMMEDAOJ(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
	}

	public void DDBCBMHMBEK()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !CJDHNCHOKOA() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.BELBIDDGNJN().mineLevel, statueID);
			PBJCPGOBPIP();
			GEEBMKNIHFN.PEPGBAANGJC(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool MLHFIKOLOEM()
	{
		return destroyedGameObject.activeSelf;
	}

	public void OnStatueHit()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !IsDestroyed() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.GetManager().mineLevel, statueID);
			DestroyStatueVisual();
			GEEBMKNIHFN.CheckPuzzleSolved(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public bool DOFFCEFPBLB()
	{
		return destroyedGameObject.activeSelf;
	}

	public void DMEJBMKGENH(StatuePuzzle ELNFILACCAN, int EKIFFMKGBHJ)
	{
		GEEBMKNIHFN = ELNFILACCAN;
		statueID = EKIFFMKGBHJ;
		destroyedGameObject.SetActive(false);
		normalGameObject.SetActive(true);
	}

	public void IFAFIEMKAOD()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !MMMLHNKLAOG() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.AJHGOJEHLED().mineLevel, statueID);
			KJPHCHLHPIK();
			GEEBMKNIHFN.NOOKFOKGNDN(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void HPMOPMIIGGI()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !HCKDMFMEPFN() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.AJHGOJEHLED().mineLevel, statueID);
			AIFBOPCIHHL();
			GEEBMKNIHFN.CFHGOIBGHEJ(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void KGPKBDEACAD()
	{
		if (!GEEBMKNIHFN.PIJKBBCAJON() && !NLPCOAPBCIL() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.GetManager().mineLevel, statueID);
			PBJCPGOBPIP();
			GEEBMKNIHFN.CheckPuzzleSolved(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void IDFNBAMFGCF()
	{
		if (!GEEBMKNIHFN.IsPuzzleSolved() && !KFNAECOKLDA() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.SendDestroyStatue(GEEBMKNIHFN.NAMECAKIKHJ().mineLevel, statueID);
			ACHMEDPAMBG();
			GEEBMKNIHFN.PEPGBAANGJC(hitDetection.playerNum, CDPAMNIPPEC: true);
		}
	}

	public void IMFBIKDDANL()
	{
		if (!GEEBMKNIHFN.DDCOMOHHEBB() && !FKNJNJINMPM() && hitDetection.playerNum != 0)
		{
			OnlinePuzzleManager.instance.HAKKEHICGDG(GEEBMKNIHFN.GetManager().mineLevel, statueID);
			JLEKNEHBBIF();
			GEEBMKNIHFN.CheckPuzzleSolved(hitDetection.playerNum, CDPAMNIPPEC: false);
		}
	}

	public void BJHEOFKFCAB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		destroyedGameObject.SetActive(true);
		normalGameObject.SetActive(false);
		if ((Object)(object)destroySound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(destroySound, ((Component)this).transform.position);
		}
	}
}
