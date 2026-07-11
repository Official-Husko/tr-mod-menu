using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class BirdInstance : ItemInstance
{
	public static float dayWithoutCookieDecrement = 0.05f;

	public int uniqueId = -1;

	public string birdName;

	public GameDate birthday;

	public int birdId;

	public int birdMaterialId;

	public int prevSkelBirdId;

	public int prevSkelBirdMaterialId;

	public float lastCookieGivenTime = -100f;

	public int cookiesGivenPerDay;

	public bool hasBeenOnPerchToday;

	private bool birdLoaded;

	private float _commentsQuality;

	public float commentsQuality
	{
		get
		{
			return _commentsQuality;
		}
		set
		{
			_commentsQuality = Mathf.Min(1f, Mathf.Max(0f, value));
			ENAIKFPGHPO();
		}
	}

	public Material IEHJMMBMLPO()
	{
		if ((Object)(object)JCIIKMKEHDG() == (Object)null)
		{
			return CharacterSpritesDBAccessor.GetMaterial(0).material;
		}
		if ((Object)(object)JCIIKMKEHDG().detailMaterial != (Object)null)
		{
			return JCIIKMKEHDG().detailMaterial;
		}
		return JCIIKMKEHDG().material;
	}

	public Bird FBEBPIIEPMP()
	{
		return (Bird)item;
	}

	public void BHPFMGBNLLD()
	{
		birdLoaded = true;
	}

	public BirdSpriteInfo NIDCNIJLJGB()
	{
		return CharacterSpritesDBAccessor.CFIIJIIMODJ(birdId);
	}

	public new Bird PHGLMBIEOMK()
	{
		return (Bird)item;
	}

	public void EENFDLDHPKC()
	{
		birdLoaded = true;
	}

	[SpecialName]
	public float CJKMAPKDJKA()
	{
		return _commentsQuality;
	}

	private void GILGIELFOAD()
	{
		List<BirdSpriteInfo> randomBirds = CharacterSpritesDBAccessor.GetRandomBirds((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = randomBirds[Random.Range(0, randomBirds.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.KNLMHIDFNEO();
		prevSkelBirdId = 1;
		prevSkelBirdMaterialId = 0;
	}

	public BirdSpriteInfo NJOOBKLDMLG()
	{
		return CharacterSpritesDBAccessor.DGALMPEEDMJ(birdId);
	}

	public IconMaterial BOLDBDHDEBL()
	{
		return CharacterSpritesDBAccessor.HACHFHGFFEB(birdMaterialId) as IconMaterial;
	}

	public BirdSpriteInfo CPPLDOLBFMD()
	{
		return CharacterSpritesDBAccessor.MPKNABIPKJM(birdId);
	}

	public void OGHKJDJPDNA()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			commentsQuality = AMDIEGDFGML() - dayWithoutCookieDecrement;
		}
		cookiesGivenPerDay = 0;
		hasBeenOnPerchToday = false;
	}

	public void NECBOEKGEJA()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			PPMDIMHLKMD(EDAGEHMHKDH() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 1;
		hasBeenOnPerchToday = false;
	}

	[SpecialName]
	public void KEPECNFIGGN(float AODONKKHPBP)
	{
		_commentsQuality = Mathf.Min(101f, Mathf.Max(1577f, AODONKKHPBP));
		CNGPHDNCNJG();
	}

	public Material GGHGJBLBCIH()
	{
		if ((Object)(object)MHLADNFFCMG() == (Object)null)
		{
			return CharacterSpritesDBAccessor.PFABHCPKGCA(1).material;
		}
		if ((Object)(object)AIBMAOLKFHJ().detailMaterial != (Object)null)
		{
			return IJPMHPIJKLM().detailMaterial;
		}
		return OFLAMMAFGFP().material;
	}

	private void ENAIKFPGHPO()
	{
		if (commentsQuality == 1f)
		{
			Utils.DLIIAHACOJB(8);
		}
	}

	public new Bird LHBPOPOIFLE()
	{
		return (Bird)item;
	}

	public void PBCCAJOPKEG()
	{
		birdLoaded = true;
	}

	public void LKHEKMHJGPL()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			ABNDNJGAPMO(MMPBCMCGJEO() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 0;
		hasBeenOnPerchToday = false;
	}

	public void NPFKLKGCNGO()
	{
		birdLoaded = false;
	}

	public void OEJEFONONII()
	{
		birdLoaded = true;
	}

	public override Sprite AAGOCCCEKMH()
	{
		BirdSpriteInfo bird = CharacterSpritesDBAccessor.GetBird(birdId);
		if ((Object)(object)bird == (Object)null)
		{
			Debug.LogError((object)("Bird sprite info not found with ID " + birdId));
		}
		if ((Object)(object)bird != (Object)null && birdMaterialId >= 0 && (Object)(object)JCIIKMKEHDG() != (Object)null)
		{
			return JCIIKMKEHDG().icon;
		}
		return item.icon;
	}

	private void CNGPHDNCNJG()
	{
		if (PCMNPKEMBJH() == 1748f)
		{
			Utils.DLIIAHACOJB(1);
		}
	}

	private void KNBJIDBKHLC()
	{
		if (commentsQuality == 119f)
		{
			Utils.DLIIAHACOJB(0, CDPAMNIPPEC: true);
		}
	}

	private void EFIACMEPHDI()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.NLMBFBEDJFA((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(0, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.CIKNMBHPKCI();
		prevSkelBirdId = 1;
		prevSkelBirdMaterialId = 0;
	}

	private void DCPOFEKLIKB()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.FMFBIHOBGJA((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(1, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.KFILKMGGLII();
		prevSkelBirdId = 1;
		prevSkelBirdMaterialId = 0;
	}

	public IconMaterial IHAGCNBHDOO()
	{
		return CharacterSpritesDBAccessor.HACHFHGFFEB(birdMaterialId) as IconMaterial;
	}

	public BirdInstance(BirdInstance CCDEPALBABD)
		: base(CCDEPALBABD)
	{
		birdLoaded = true;
		uniqueId = CCDEPALBABD.uniqueId;
		birdName = CCDEPALBABD.birdName;
		birthday = CCDEPALBABD.birthday;
		birdId = CCDEPALBABD.birdId;
		birdMaterialId = CCDEPALBABD.birdMaterialId;
		prevSkelBirdId = CCDEPALBABD.prevSkelBirdId;
		prevSkelBirdMaterialId = CCDEPALBABD.prevSkelBirdMaterialId;
		commentsQuality = CCDEPALBABD.commentsQuality;
		lastCookieGivenTime = CCDEPALBABD.lastCookieGivenTime;
	}

	private void OIFMBNHGHBJ()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.KOEDGKBADGD((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(0, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.FOHAFIBNNKD();
		prevSkelBirdId = 0;
		prevSkelBirdMaterialId = 1;
	}

	public void LODAPIBOABC()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			JKGDBKNIFJF(EAGIKHGKJOK() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 1;
		hasBeenOnPerchToday = true;
	}

	[SpecialName]
	public float PCMNPKEMBJH()
	{
		return _commentsQuality;
	}

	private void OHNNEEEGGBL()
	{
		List<BirdSpriteInfo> randomBirds = CharacterSpritesDBAccessor.GetRandomBirds((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = randomBirds[Random.Range(0, randomBirds.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.LIGJOCEOHKB();
		prevSkelBirdId = 0;
		prevSkelBirdMaterialId = 0;
	}

	public IconMaterial BNPLOPHHGLL()
	{
		return CharacterSpritesDBAccessor.MDBJNKMOKMM(birdMaterialId) as IconMaterial;
	}

	[SpecialName]
	public float HLNEJKENOFP()
	{
		return _commentsQuality;
	}

	public Bird HCCFFBOMLFB()
	{
		return (Bird)item;
	}

	public void KCPGNNMAHJL()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			MOIKAMNFMND(MMPBCMCGJEO() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 1;
		hasBeenOnPerchToday = true;
	}

	public IconMaterial JCIIKMKEHDG()
	{
		return CharacterSpritesDBAccessor.GetMaterial(birdMaterialId) as IconMaterial;
	}

	[SpecialName]
	public float LCLIGNKKGGP()
	{
		return _commentsQuality;
	}

	public void CMKGCFINBGJ()
	{
		birdLoaded = false;
	}

	private void CGGGCNNJKFE()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.KOEDGKBADGD((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(0, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.PCNCFIMKCKP();
		prevSkelBirdId = 0;
		prevSkelBirdMaterialId = 0;
	}

	[SpecialName]
	public void ABNDNJGAPMO(float AODONKKHPBP)
	{
		_commentsQuality = Mathf.Min(398f, Mathf.Max(637f, AODONKKHPBP));
		CNGPHDNCNJG();
	}

	public Material BCKBAHPJJGG()
	{
		if ((Object)(object)AIBMAOLKFHJ() == (Object)null)
		{
			return CharacterSpritesDBAccessor.MDBJNKMOKMM(1).material;
		}
		if ((Object)(object)JKMNPJFDOHG().detailMaterial != (Object)null)
		{
			return OFLAMMAFGFP().detailMaterial;
		}
		return AIBMAOLKFHJ().material;
	}

	private void KAKNFHAEFDB()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.NLMBFBEDJFA((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(1, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.GGLIOOIHFNP();
		prevSkelBirdId = 1;
		prevSkelBirdMaterialId = 1;
	}

	[SpecialName]
	public float MMPBCMCGJEO()
	{
		return _commentsQuality;
	}

	public BirdSpriteInfo JIIKFCAOMGK()
	{
		return CharacterSpritesDBAccessor.GetBird(birdId);
	}

	[SpecialName]
	public float BNJDFHHOAPP()
	{
		return _commentsQuality;
	}

	public BirdSpriteInfo LCGFLCEFDNI()
	{
		return CharacterSpritesDBAccessor.IDPLFDGMIFL(birdId);
	}

	public void GDKLMINHHHL()
	{
		birdLoaded = false;
	}

	[SpecialName]
	public void PPMDIMHLKMD(float AODONKKHPBP)
	{
		_commentsQuality = Mathf.Min(1937f, Mathf.Max(662f, AODONKKHPBP));
		GAFOIKHFOKB();
	}

	[SpecialName]
	public float MACEIGHIIBP()
	{
		return _commentsQuality;
	}

	public IconMaterial JKMNPJFDOHG()
	{
		return CharacterSpritesDBAccessor.MDBJNKMOKMM(birdMaterialId) as IconMaterial;
	}

	[SpecialName]
	public float GKJACPFDDME()
	{
		return _commentsQuality;
	}

	public BirdSpriteInfo JFKEFOFKPIG()
	{
		return CharacterSpritesDBAccessor.GetBird(birdId);
	}

	public BirdSpriteInfo FNLHHNNHIMD()
	{
		return CharacterSpritesDBAccessor.GetBird(birdId);
	}

	public Material IIKIAGMPJGP()
	{
		if ((Object)(object)MHLADNFFCMG() == (Object)null)
		{
			return CharacterSpritesDBAccessor.HACHFHGFFEB(0).material;
		}
		if ((Object)(object)BOLDBDHDEBL().detailMaterial != (Object)null)
		{
			return AIBMAOLKFHJ().detailMaterial;
		}
		return JCIIKMKEHDG().material;
	}

	public BirdSpriteInfo HMGIBPLAHIK()
	{
		return CharacterSpritesDBAccessor.CFIIJIIMODJ(birdId);
	}

	private void KACAEMINGLN()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.FMFBIHOBGJA((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(1, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.EACHNJDOHPB();
		prevSkelBirdId = 1;
		prevSkelBirdMaterialId = 1;
	}

	private void GCOHIIGIGEB()
	{
		if (LLLNIJBENAO() == 1036f)
		{
			Utils.DLIIAHACOJB(0, CDPAMNIPPEC: true);
		}
	}

	public new Bird KNFNJFFCFNO()
	{
		return (Bird)item;
	}

	public BirdSpriteInfo GBFKDIJDNEM()
	{
		return CharacterSpritesDBAccessor.DGALMPEEDMJ(birdId);
	}

	public Material NPBFLGNHIGM()
	{
		if ((Object)(object)OFLAMMAFGFP() == (Object)null)
		{
			return CharacterSpritesDBAccessor.HACHFHGFFEB(0).material;
		}
		if ((Object)(object)BOLDBDHDEBL().detailMaterial != (Object)null)
		{
			return BOLDBDHDEBL().detailMaterial;
		}
		return JCIIKMKEHDG().material;
	}

	public BirdSpriteInfo PNEEHGHBFCI()
	{
		return CharacterSpritesDBAccessor.MLLGJMHHDJC(birdId);
	}

	[SpecialName]
	public float LLLNIJBENAO()
	{
		return _commentsQuality;
	}

	[SpecialName]
	public void PPCOHMIGDAP(float AODONKKHPBP)
	{
		_commentsQuality = Mathf.Min(50f, Mathf.Max(1635f, AODONKKHPBP));
		GCOHIIGIGEB();
	}

	public void GCIBNNDBNGG()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			MOIKAMNFMND(LCLIGNKKGGP() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 1;
		hasBeenOnPerchToday = false;
	}

	public void GJFCIDIDLEM()
	{
		birdLoaded = true;
	}

	public Bird JOHCGGOOCBE()
	{
		return (Bird)item;
	}

	public void ONPKLGKDDMJ()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			KEPECNFIGGN(HLNEJKENOFP() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 1;
		hasBeenOnPerchToday = false;
	}

	public void OAMENOGEOJE()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			ABNDNJGAPMO(EDAGEHMHKDH() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 1;
		hasBeenOnPerchToday = false;
	}

	private void PEOIKKAMMBD()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.NLMBFBEDJFA((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(1, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.LGHHJIBGGNI();
		prevSkelBirdId = 1;
		prevSkelBirdMaterialId = 1;
	}

	private void POBOFIBEMMI()
	{
		if (CJKMAPKDJKA() == 1915f)
		{
			Utils.DLIIAHACOJB(0);
		}
	}

	[SpecialName]
	public void OBMKKPEBOEI(float AODONKKHPBP)
	{
		_commentsQuality = Mathf.Min(794f, Mathf.Max(1774f, AODONKKHPBP));
		GCOHIIGIGEB();
	}

	public BirdSpriteInfo CNCCLIOHJDL()
	{
		return CharacterSpritesDBAccessor.DGALMPEEDMJ(birdId);
	}

	public override string IABAKHPEOAF(bool OAFPBCPDOKH = false, string KCILJNKFCCN = null)
	{
		if (string.IsNullOrEmpty(birdName))
		{
			return item.IABAKHPEOAF(OAFPBCPDOKH, KCILJNKFCCN);
		}
		return birdName;
	}

	public Bird MBLEGAKJDEH()
	{
		return (Bird)item;
	}

	public void IFHFNDELKOP()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			commentsQuality -= dayWithoutCookieDecrement;
		}
		cookiesGivenPerDay = 0;
		hasBeenOnPerchToday = false;
	}

	public BirdSpriteInfo JDCKLGIMKDE()
	{
		return CharacterSpritesDBAccessor.DGALMPEEDMJ(birdId);
	}

	private void AIKHFAAIDLH()
	{
		if (MMPBCMCGJEO() == 564f)
		{
			Utils.DLIIAHACOJB(1, CDPAMNIPPEC: true);
		}
	}

	public Material ICACBNCIBOL()
	{
		if ((Object)(object)AIBMAOLKFHJ() == (Object)null)
		{
			return CharacterSpritesDBAccessor.PFABHCPKGCA(0).material;
		}
		if ((Object)(object)IJPMHPIJKLM().detailMaterial != (Object)null)
		{
			return MHLADNFFCMG().detailMaterial;
		}
		return OFLAMMAFGFP().material;
	}

	public BirdInstance(Bird GPIHGDCLNEG)
		: base(GPIHGDCLNEG)
	{
		item = GPIHGDCLNEG;
		birthday = WorldTime.NOAOJJLNHJJ;
		commentsQuality = 0.2f;
		if (!birdLoaded)
		{
			OHNNEEEGGBL();
		}
		CommonReferences.GGFJGHHHEJC.AddBird(this);
	}

	public Material BMJBEJOFAKB()
	{
		if ((Object)(object)IJPMHPIJKLM() == (Object)null)
		{
			return CharacterSpritesDBAccessor.CIJJJBJNLIF(0).material;
		}
		if ((Object)(object)IHAGCNBHDOO().detailMaterial != (Object)null)
		{
			return JCIIKMKEHDG().detailMaterial;
		}
		return BOLDBDHDEBL().material;
	}

	public Material HIPDCEKHNID()
	{
		if ((Object)(object)IJPMHPIJKLM() == (Object)null)
		{
			return CharacterSpritesDBAccessor.MDBJNKMOKMM(1).material;
		}
		if ((Object)(object)MHLADNFFCMG().detailMaterial != (Object)null)
		{
			return BOLDBDHDEBL().detailMaterial;
		}
		return IHAGCNBHDOO().material;
	}

	private void GLJJEIAKFNI()
	{
		if (MMPBCMCGJEO() == 1127f)
		{
			Utils.DLIIAHACOJB(1, CDPAMNIPPEC: true);
		}
	}

	public Material DKHIPNDINKF()
	{
		if ((Object)(object)MHLADNFFCMG() == (Object)null)
		{
			return CharacterSpritesDBAccessor.MIAIOBLCEND(0).material;
		}
		if ((Object)(object)AIBMAOLKFHJ().detailMaterial != (Object)null)
		{
			return BOLDBDHDEBL().detailMaterial;
		}
		return MHLADNFFCMG().material;
	}

	public Material HJHNHNPKPDP()
	{
		if ((Object)(object)BNPLOPHHGLL() == (Object)null)
		{
			return CharacterSpritesDBAccessor.MDBJNKMOKMM(1).material;
		}
		if ((Object)(object)JKMNPJFDOHG().detailMaterial != (Object)null)
		{
			return AIBMAOLKFHJ().detailMaterial;
		}
		return AIBMAOLKFHJ().material;
	}

	private void KPELODGFABE()
	{
		if (EDAGEHMHKDH() == 315f)
		{
			Utils.DLIIAHACOJB(5, CDPAMNIPPEC: true);
		}
	}

	[SpecialName]
	public void JKGDBKNIFJF(float AODONKKHPBP)
	{
		_commentsQuality = Mathf.Min(1740f, Mathf.Max(1607f, AODONKKHPBP));
		GLJJEIAKFNI();
	}

	public override TooltipInfo MLCIDCBCMOA(int JIIGOACEIKL, bool CCAICMBJAGH = false, bool CCLILNLKFPJ = false, bool PKBJMLACEMM = true, bool FCJLFPLAOJE = false, bool FPLPFMKFKNH = false)
	{
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.itemInstance = this;
		if (!string.IsNullOrEmpty(birdName))
		{
			tooltipInfo.toolTipTitle = birdName;
		}
		else
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Bird");
		}
		tooltipInfo.mainBody = birthday.KBCEHEPDDHI();
		return tooltipInfo;
	}

	[SpecialName]
	public float EAGIKHGKJOK()
	{
		return _commentsQuality;
	}

	private void PBPEFIHMKEC()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.FMFBIHOBGJA((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(1, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.IKHGFBANAKN();
		prevSkelBirdId = 0;
		prevSkelBirdMaterialId = 0;
	}

	public Material CCLFDMOKCGG()
	{
		if ((Object)(object)IJPMHPIJKLM() == (Object)null)
		{
			return CharacterSpritesDBAccessor.PFABHCPKGCA(1).material;
		}
		if ((Object)(object)JKMNPJFDOHG().detailMaterial != (Object)null)
		{
			return OFLAMMAFGFP().detailMaterial;
		}
		return OFLAMMAFGFP().material;
	}

	public Material DAGEBDLEHKA()
	{
		if ((Object)(object)MHLADNFFCMG() == (Object)null)
		{
			return CharacterSpritesDBAccessor.MDBJNKMOKMM(1).material;
		}
		if ((Object)(object)OFLAMMAFGFP().detailMaterial != (Object)null)
		{
			return JCIIKMKEHDG().detailMaterial;
		}
		return OFLAMMAFGFP().material;
	}

	public void CMBADHMGHLG()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			ABNDNJGAPMO(MACEIGHIIBP() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 1;
		hasBeenOnPerchToday = true;
	}

	public BirdSpriteInfo HHNCDLBBEOE()
	{
		return CharacterSpritesDBAccessor.CFIIJIIMODJ(birdId);
	}

	private void LLJGIIKCDFD()
	{
		if (AMDIEGDFGML() == 1026f)
		{
			Utils.DLIIAHACOJB(2, CDPAMNIPPEC: true);
		}
	}

	[SpecialName]
	public float EDAGEHMHKDH()
	{
		return _commentsQuality;
	}

	public BirdSpriteInfo JBLLEIOBNAF()
	{
		return CharacterSpritesDBAccessor.KBJHAIFBIIF(birdId);
	}

	public IconMaterial AIBMAOLKFHJ()
	{
		return CharacterSpritesDBAccessor.GetMaterial(birdMaterialId) as IconMaterial;
	}

	public Bird NBNLKGKJGFK()
	{
		return (Bird)item;
	}

	public void HCCIICLPLEG()
	{
		birdLoaded = true;
	}

	private void OGJIJFIBKLH()
	{
		List<BirdSpriteInfo> list = CharacterSpritesDBAccessor.AGEOGOPCEEN((item as Bird).birdType);
		BirdSpriteInfo birdSpriteInfo = list[Random.Range(1, list.Count)];
		birdId = birdSpriteInfo.id;
		birdMaterialId = birdSpriteInfo.LGHHJIBGGNI();
		prevSkelBirdId = 1;
		prevSkelBirdMaterialId = 0;
	}

	[SpecialName]
	public float AMDIEGDFGML()
	{
		return _commentsQuality;
	}

	public void IAIHFOFLINJ()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			PPCOHMIGDAP(BNJDFHHOAPP() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 0;
		hasBeenOnPerchToday = true;
	}

	public void EMCLKHNDGPH()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			PPCOHMIGDAP(GKJACPFDDME() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 0;
		hasBeenOnPerchToday = false;
	}

	public IconMaterial IJPMHPIJKLM()
	{
		return CharacterSpritesDBAccessor.PFABHCPKGCA(birdMaterialId) as IconMaterial;
	}

	public IconMaterial MHLADNFFCMG()
	{
		return CharacterSpritesDBAccessor.CIJJJBJNLIF(birdMaterialId) as IconMaterial;
	}

	public IconMaterial OFLAMMAFGFP()
	{
		return CharacterSpritesDBAccessor.GetMaterial(birdMaterialId) as IconMaterial;
	}

	private void GAFOIKHFOKB()
	{
		if (BNJDFHHOAPP() == 1867f)
		{
			Utils.DLIIAHACOJB(7, CDPAMNIPPEC: true);
		}
	}

	private void NGGKGDHGOFK()
	{
		if (MACEIGHIIBP() == 377f)
		{
			Utils.DLIIAHACOJB(2);
		}
	}

	public Material HGKDNPGJKAB()
	{
		if ((Object)(object)JCIIKMKEHDG() == (Object)null)
		{
			return CharacterSpritesDBAccessor.CIJJJBJNLIF(1).material;
		}
		if ((Object)(object)OFLAMMAFGFP().detailMaterial != (Object)null)
		{
			return MHLADNFFCMG().detailMaterial;
		}
		return MHLADNFFCMG().material;
	}

	public Material KJLPDKGLING()
	{
		if ((Object)(object)MHLADNFFCMG() == (Object)null)
		{
			return CharacterSpritesDBAccessor.PFABHCPKGCA(1).material;
		}
		if ((Object)(object)BNPLOPHHGLL().detailMaterial != (Object)null)
		{
			return JCIIKMKEHDG().detailMaterial;
		}
		return BOLDBDHDEBL().material;
	}

	public void CMJIKLLFHKA()
	{
		if (hasBeenOnPerchToday && cookiesGivenPerDay == 0)
		{
			KEPECNFIGGN(EAGIKHGKJOK() - dayWithoutCookieDecrement);
		}
		cookiesGivenPerDay = 1;
		hasBeenOnPerchToday = false;
	}

	[SpecialName]
	public void MOIKAMNFMND(float AODONKKHPBP)
	{
		_commentsQuality = Mathf.Min(164f, Mathf.Max(405f, AODONKKHPBP));
		LLJGIIKCDFD();
	}
}
