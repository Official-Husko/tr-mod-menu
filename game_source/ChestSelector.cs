using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ChestSelector : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	private ItemContainer ALPOKDOCCGM;

	public ItemContainer HKEFPDOEMNF
	{
		get
		{
			return ALPOKDOCCGM;
		}
		set
		{
			ALPOKDOCCGM = value;
			icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
		}
	}

	public void MEKEHONHHOE()
	{
		if (!((Object)(object)MIADHPLPILK() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.FHBIFJNCOAI(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.JGNOJMLHPOK(0).CPNMIBGCKIN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.BFCEHJIIAHN(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.JDODHPEDACJ(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(MGEJLDCHINI().OpenContainer(1));
	}

	[SpecialName]
	public ItemContainer DGGAIPFFFII()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public void GADODGHKGIH(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void PBEIGKBCKLG(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void MIJIHMLPODI(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void KEKNHBIBAMD()
	{
		if (!((Object)(object)GCGDJJMFMJA() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.NDJAMDLOIJL(0).IsOpen())
		{
			if ((Object)(object)BigContainerUI.AANKLOIDPOA(0).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.PHDBJGOEKHB(0).CloseUI();
				return;
			}
			BigContainerUI.JGNOJMLHPOK(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(LCANMPAKOKD().OpenContainer(1));
	}

	[SpecialName]
	public ItemContainer FJOKFHNHPCI()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public void GDFLDNHIHPA(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void KGIENPNPJKP()
	{
		if (!((Object)(object)MIADHPLPILK() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.EPLOMIBMKFC(1).IsOpen())
		{
			if ((Object)(object)BigContainerUI.FHBIFJNCOAI(0).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.IGHMHMNPMLB(1).CloseUI();
				return;
			}
			BigContainerUI.EPLOMIBMKFC(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(HJCNLFMCDFD().OpenContainer(1));
	}

	private void JMHIFDNKOPH()
	{
		if ((Object)(object)PEFLFBPEMLD() != (Object)null)
		{
			NMACHJAMBFO().Deselect(1);
		}
	}

	private void LBFFMGAKDFG()
	{
		if ((Object)(object)NMACHJAMBFO() != (Object)null)
		{
			NHKOMEDGAFP().Deselect(0);
		}
	}

	private void DIEKBCKJMPH()
	{
		if ((Object)(object)MGEJLDCHINI() != (Object)null)
		{
			MPMOBNMENIC().Deselect(0);
		}
	}

	private void MKGKKAJHLAO()
	{
		if ((Object)(object)DFCBIJALAHF() != (Object)null)
		{
			NCJCAPCINGJ().Deselect(1);
		}
	}

	[SpecialName]
	public void PIIPFNEFOLK(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void NJFHAGALEBH()
	{
		if (!((Object)(object)ECHOGBLPALK() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.OHPNDOJNCBK(1).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.Get(1).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.AIMEAJAHLAA(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.ILDNNNMOCOC(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(HKEFPDOEMNF.OGJDHOMLGFK(1));
	}

	[SpecialName]
	public ItemContainer NCJCAPCINGJ()
	{
		return ALPOKDOCCGM;
	}

	private void EPHDHKDCNOD()
	{
		if ((Object)(object)LCANMPAKOKD() != (Object)null)
		{
			FNBLIFNFLPI().Deselect(0);
		}
	}

	[SpecialName]
	public ItemContainer OHGNHIFNLAB()
	{
		return ALPOKDOCCGM;
	}

	public void OpenContainer()
	{
		if (!((Object)(object)HKEFPDOEMNF != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.Get(1).IsOpen())
		{
			if ((Object)(object)BigContainerUI.Get(1).ALPOKDOCCGM == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.Get(1).CloseUI();
				return;
			}
			BigContainerUI.Get(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(HKEFPDOEMNF.OpenContainer(1));
	}

	public void MKJLKDFCPHO()
	{
		if (!((Object)(object)OPPGMCLMOEF() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.Get(0).IsOpen())
		{
			if ((Object)(object)BigContainerUI.AANKLOIDPOA(1).ALPOKDOCCGM == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.AIMEAJAHLAA(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.JDODHPEDACJ(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(JGNEFJFHFOF().OpenContainer(1, CDPAMNIPPEC: false));
	}

	[SpecialName]
	public ItemContainer FNBLIFNFLPI()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public ItemContainer NCOJLGAKBGL()
	{
		return ALPOKDOCCGM;
	}

	private void MEDLNBCAJCL()
	{
		if ((Object)(object)NMACHJAMBFO() != (Object)null)
		{
			BJCPHJPIFJP().Deselect(1);
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)HKEFPDOEMNF != (Object)null)
		{
			HKEFPDOEMNF.Deselect(1);
		}
	}

	[SpecialName]
	public void BGDHNECEOCH(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void NNHGCNEGKGO()
	{
		if (!((Object)(object)NHJNOHHBAJI() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.Get(0).IsOpen())
		{
			if ((Object)(object)BigContainerUI.ILDNNNMOCOC(1).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.NDJAMDLOIJL(0).CloseUI();
				return;
			}
			BigContainerUI.ILDNNNMOCOC(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(NCJCAPCINGJ().OGJDHOMLGFK(1));
	}

	[SpecialName]
	public void MFMMILDANPA(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void BLKJEOIFMKH()
	{
		if (!((Object)(object)HKEFPDOEMNF != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.BFCEHJIIAHN(0).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.FHBIFJNCOAI(1).JPKAMFAKIAN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.ILDNNNMOCOC(1).CloseUI();
				return;
			}
			BigContainerUI.ILDNNNMOCOC(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(OBAHPGBEPNH().OpenContainer(0));
	}

	[SpecialName]
	public ItemContainer MIADHPLPILK()
	{
		return ALPOKDOCCGM;
	}

	public void MGAAKGJLKHH()
	{
		if (!((Object)(object)HJCNLFMCDFD() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.JDODHPEDACJ(1).IsOpen())
		{
			if ((Object)(object)BigContainerUI.AANKLOIDPOA(0).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.IGHMHMNPMLB(0).CloseUI();
				return;
			}
			BigContainerUI.ILDNNNMOCOC(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(DFCBIJALAHF().OGJDHOMLGFK(1, CDPAMNIPPEC: false));
	}

	private void HEOAIGHOLLD()
	{
		if ((Object)(object)NCJCAPCINGJ() != (Object)null)
		{
			ECHOGBLPALK().Deselect(1);
		}
	}

	[SpecialName]
	public ItemContainer HJCNLFMCDFD()
	{
		return ALPOKDOCCGM;
	}

	public void NFHNGEDBLGD()
	{
		if (!((Object)(object)BJCPHJPIFJP() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.EIMDPBGBBIF(0).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.AANKLOIDPOA(0).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.NDJAMDLOIJL(0).CloseUI();
				return;
			}
			BigContainerUI.OHPNDOJNCBK(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(HJCNLFMCDFD().OpenContainer(1, CDPAMNIPPEC: false));
	}

	public void MJFBCAEDIMH()
	{
		if (!((Object)(object)LCANMPAKOKD() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.IGHMHMNPMLB(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.Get(1).ALPOKDOCCGM == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.EIMDPBGBBIF(1).CloseUI();
				return;
			}
			BigContainerUI.Get(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(FOOHDNPCNCK().OpenContainer(0));
	}

	private void HJEOOBGDCMA()
	{
		if ((Object)(object)EOPBDOILJAA() != (Object)null)
		{
			EOPBDOILJAA().Deselect(0);
		}
	}

	[SpecialName]
	public ItemContainer FOOHDNPCNCK()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public ItemContainer DFCBIJALAHF()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public void DGCEKNBJEBN(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void EGHBGLLOEPP()
	{
		if (!((Object)(object)MPMOBNMENIC() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.IGHMHMNPMLB(0).IsOpen())
		{
			if ((Object)(object)BigContainerUI.BFCEHJIIAHN(0).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.EPLOMIBMKFC(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.JDODHPEDACJ(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(HKEFPDOEMNF.OpenContainer(0, CDPAMNIPPEC: false));
	}

	public void JMDAJNIHDEF()
	{
		if (!((Object)(object)NKCPGONCMBN() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.EPLOMIBMKFC(1).IsOpen())
		{
			if ((Object)(object)BigContainerUI.PHDBJGOEKHB(1).CPNMIBGCKIN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.IGHMHMNPMLB(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.PHDBJGOEKHB(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(FNBLIFNFLPI().OGJDHOMLGFK(1, CDPAMNIPPEC: false));
	}

	private void AFLDHACLDPK()
	{
		if ((Object)(object)NCOJLGAKBGL() != (Object)null)
		{
			EOPBDOILJAA().Deselect(0);
		}
	}

	private void AECMHPBLPNP()
	{
		if ((Object)(object)HKEFPDOEMNF != (Object)null)
		{
			FNBLIFNFLPI().Deselect(0);
		}
	}

	private void MAEGGDLLHBG()
	{
		if ((Object)(object)JGNEFJFHFOF() != (Object)null)
		{
			OPPGMCLMOEF().Deselect(1);
		}
	}

	public void JFDDIAIKJOI()
	{
		if (!((Object)(object)MIADHPLPILK() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.MDFIDKHOPDJ(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.IGHMHMNPMLB(1).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.BFCEHJIIAHN(1).BOBCIFEDJED();
				return;
			}
			BigContainerUI.ILDNNNMOCOC(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(MIADHPLPILK().OGJDHOMLGFK(0, CDPAMNIPPEC: false));
	}

	private void IMOMHCNPCEC()
	{
		if ((Object)(object)EOPBDOILJAA() != (Object)null)
		{
			OBAHPGBEPNH().Deselect(1);
		}
	}

	[SpecialName]
	public ItemContainer NIMHHBJFMCG()
	{
		return ALPOKDOCCGM;
	}

	public void OPDBDHGJNCM()
	{
		if (!((Object)(object)JGNEFJFHFOF() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.EIMDPBGBBIF(1).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.EIMDPBGBBIF(1).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.JGNOJMLHPOK(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.JGNOJMLHPOK(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(HKEFPDOEMNF.OGJDHOMLGFK(1, CDPAMNIPPEC: false));
	}

	[SpecialName]
	public ItemContainer NHJNOHHBAJI()
	{
		return ALPOKDOCCGM;
	}

	public void PIHDDADDAJC()
	{
		if (!((Object)(object)NCJCAPCINGJ() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.AANKLOIDPOA(1).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.JDODHPEDACJ(1).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.IGHMHMNPMLB(0).CloseUI();
				return;
			}
			BigContainerUI.AANKLOIDPOA(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(FOOHDNPCNCK().OpenContainer(0, CDPAMNIPPEC: false));
	}

	[SpecialName]
	public ItemContainer OPPGMCLMOEF()
	{
		return ALPOKDOCCGM;
	}

	private void DNAMDIHOOKN()
	{
		if ((Object)(object)MIADHPLPILK() != (Object)null)
		{
			NCJCAPCINGJ().Deselect(0);
		}
	}

	private void HANCJHIDCNJ()
	{
		if ((Object)(object)HJCNLFMCDFD() != (Object)null)
		{
			ECHOGBLPALK().Deselect(1);
		}
	}

	[SpecialName]
	public void IFKMJFPAHLP(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	private void JPJDFHEANJH()
	{
		if ((Object)(object)NCOJLGAKBGL() != (Object)null)
		{
			BJCPHJPIFJP().Deselect(0);
		}
	}

	private void AHCPFICKFHA()
	{
		if ((Object)(object)ECHOGBLPALK() != (Object)null)
		{
			FOOHDNPCNCK().Deselect(0);
		}
	}

	[SpecialName]
	public ItemContainer PEFLFBPEMLD()
	{
		return ALPOKDOCCGM;
	}

	private void CHDGJHNBNEJ()
	{
		if ((Object)(object)MIADHPLPILK() != (Object)null)
		{
			DGGAIPFFFII().Deselect(0);
		}
	}

	private void CFEAEHLDCOI()
	{
		if ((Object)(object)MPMOBNMENIC() != (Object)null)
		{
			NCJCAPCINGJ().Deselect(1);
		}
	}

	[SpecialName]
	public ItemContainer JGNEFJFHFOF()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public ItemContainer BJCPHJPIFJP()
	{
		return ALPOKDOCCGM;
	}

	public void IMOMHELEBPM()
	{
		if (!((Object)(object)PEFLFBPEMLD() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.AIMEAJAHLAA(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.NDJAMDLOIJL(0).ALPOKDOCCGM == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.JGNOJMLHPOK(1).CloseUI();
				return;
			}
			BigContainerUI.OHPNDOJNCBK(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(OHGNHIFNLAB().OGJDHOMLGFK(1, CDPAMNIPPEC: false));
	}

	private void CNFELPNGNOB()
	{
		if ((Object)(object)GCGDJJMFMJA() != (Object)null)
		{
			DFCBIJALAHF().Deselect(0);
		}
	}

	public void BFJHBOGICLF()
	{
		if (!((Object)(object)OPPGMCLMOEF() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.AANKLOIDPOA(1).IsOpen())
		{
			if ((Object)(object)BigContainerUI.BFCEHJIIAHN(1).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.PHDBJGOEKHB(1).CloseUI();
				return;
			}
			BigContainerUI.EPLOMIBMKFC(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(OPPGMCLMOEF().OpenContainer(1));
	}

	private void GKEPJIFAMKI()
	{
		if ((Object)(object)MIADHPLPILK() != (Object)null)
		{
			FNBLIFNFLPI().Deselect(0);
		}
	}

	private void JMAHDPMEEHM()
	{
		if ((Object)(object)MPMOBNMENIC() != (Object)null)
		{
			JGNEFJFHFOF().Deselect(0);
		}
	}

	public void DGAGOEDDDBJ()
	{
		if (!((Object)(object)MIADHPLPILK() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.IGHMHMNPMLB(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.EIMDPBGBBIF(0).EDPIANLDIDG() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.IGHMHMNPMLB(0).CloseUI();
				return;
			}
			BigContainerUI.MDFIDKHOPDJ(1).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(JGNEFJFHFOF().OpenContainer(0));
	}

	[SpecialName]
	public void OPKCEKGDIFI(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	private void GGDMGADLMOG()
	{
		if ((Object)(object)NIMHHBJFMCG() != (Object)null)
		{
			OPPGMCLMOEF().Deselect(1);
		}
	}

	[SpecialName]
	public void GLKJCFHBKCM(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	private void ODBKBMCMFNB()
	{
		if ((Object)(object)OPPGMCLMOEF() != (Object)null)
		{
			OHGNHIFNLAB().Deselect(1);
		}
	}

	private void KJOCGLKMMOM()
	{
		if ((Object)(object)FJOKFHNHPCI() != (Object)null)
		{
			EOPBDOILJAA().Deselect(0);
		}
	}

	private void AIFOBFHCHGK()
	{
		if ((Object)(object)FNBLIFNFLPI() != (Object)null)
		{
			NCOJLGAKBGL().Deselect(1);
		}
	}

	[SpecialName]
	public ItemContainer EOPBDOILJAA()
	{
		return ALPOKDOCCGM;
	}

	public void IDJKOCEIEAG()
	{
		if (!((Object)(object)NCOJLGAKBGL() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.BFCEHJIIAHN(0).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.AIMEAJAHLAA(0).CPNMIBGCKIN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.OHPNDOJNCBK(1).BOBCIFEDJED();
				return;
			}
			BigContainerUI.EIMDPBGBBIF(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(FOOHDNPCNCK().OpenContainer(0, CDPAMNIPPEC: false));
	}

	[SpecialName]
	public void MAFEPANKOOP(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void JJMBNMMDFJF(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public ItemContainer LCANMPAKOKD()
	{
		return ALPOKDOCCGM;
	}

	private void CACPOGPOKOJ()
	{
		if ((Object)(object)FNBLIFNFLPI() != (Object)null)
		{
			NIMHHBJFMCG().Deselect(0);
		}
	}

	[SpecialName]
	public void DKOMJEGGKLF(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void BFGNMFKMCGP(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void HPGFLJNCLOC()
	{
		if (!((Object)(object)JGNEFJFHFOF() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.EPLOMIBMKFC(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.PHDBJGOEKHB(1).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.OHPNDOJNCBK(0).CloseUI();
				return;
			}
			BigContainerUI.JDODHPEDACJ(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(FNBLIFNFLPI().OGJDHOMLGFK(1, CDPAMNIPPEC: false));
	}

	[SpecialName]
	public ItemContainer BKCKDABNDLJ()
	{
		return ALPOKDOCCGM;
	}

	private void BPINJGFECPF()
	{
		if ((Object)(object)PEFLFBPEMLD() != (Object)null)
		{
			PEFLFBPEMLD().Deselect(1);
		}
	}

	[SpecialName]
	public void PPJPNNOKCFI(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void LBNBJIJABPA()
	{
		if (!((Object)(object)NIMHHBJFMCG() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.JGNOJMLHPOK(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.JGNOJMLHPOK(1).CPNMIBGCKIN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.OHPNDOJNCBK(1).CloseUI();
				return;
			}
			BigContainerUI.JDODHPEDACJ(1).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(NIMHHBJFMCG().OGJDHOMLGFK(0));
	}

	[SpecialName]
	public ItemContainer NMACHJAMBFO()
	{
		return ALPOKDOCCGM;
	}

	private void IAEPFFMCKOH()
	{
		if ((Object)(object)HKEFPDOEMNF != (Object)null)
		{
			NHKOMEDGAFP().Deselect(1);
		}
	}

	[SpecialName]
	public void ICKNEJKOHJE(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public ItemContainer GCGDJJMFMJA()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public ItemContainer MGEJLDCHINI()
	{
		return ALPOKDOCCGM;
	}

	public void CNECHENFBAL()
	{
		if (!((Object)(object)JGNEFJFHFOF() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.ILDNNNMOCOC(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.JDODHPEDACJ(1).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.EPLOMIBMKFC(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.EIMDPBGBBIF(1).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(DFCBIJALAHF().OpenContainer(1));
	}

	public void JDNMAFOKOOE()
	{
		if (!((Object)(object)PEFLFBPEMLD() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.PHDBJGOEKHB(0).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.NDJAMDLOIJL(0).EDPIANLDIDG() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.AANKLOIDPOA(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.MDFIDKHOPDJ(1).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(OPPGMCLMOEF().OpenContainer(1));
	}

	[SpecialName]
	public ItemContainer ECHOGBLPALK()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public void LBBEACLCEAM(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	private void LDBBNBEBKLA()
	{
		if ((Object)(object)LCANMPAKOKD() != (Object)null)
		{
			BKCKDABNDLJ().Deselect(1);
		}
	}

	private void OFJIMLOLIDP()
	{
		if ((Object)(object)EOPBDOILJAA() != (Object)null)
		{
			OPPGMCLMOEF().Deselect(1);
		}
	}

	public void DHDAPINNKDM()
	{
		if (!((Object)(object)DFCBIJALAHF() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.IGHMHMNPMLB(0).IsOpen())
		{
			if ((Object)(object)BigContainerUI.AIMEAJAHLAA(0).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.Get(0).CloseUI();
				return;
			}
			BigContainerUI.MDFIDKHOPDJ(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(OBAHPGBEPNH().OGJDHOMLGFK(0));
	}

	private void OAAGBFIAIGN()
	{
		if ((Object)(object)OHGNHIFNLAB() != (Object)null)
		{
			JGNEFJFHFOF().Deselect(0);
		}
	}

	public void NCGCOBPIPON()
	{
		if (!((Object)(object)HKEFPDOEMNF != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.AIMEAJAHLAA(1).IsOpen())
		{
			if ((Object)(object)BigContainerUI.ILDNNNMOCOC(1).CPNMIBGCKIN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.Get(1).CloseUI();
				return;
			}
			BigContainerUI.AIMEAJAHLAA(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(NMACHJAMBFO().OpenContainer(1, CDPAMNIPPEC: false));
	}

	public void NMIHFFICLPB()
	{
		if (!((Object)(object)JGNEFJFHFOF() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.JDODHPEDACJ(1).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.MDFIDKHOPDJ(1).CPNMIBGCKIN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.ILDNNNMOCOC(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.AIMEAJAHLAA(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(NHKOMEDGAFP().OpenContainer(1, CDPAMNIPPEC: false));
	}

	public void NCCEOMAEIJF()
	{
		if (!((Object)(object)GCGDJJMFMJA() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.AANKLOIDPOA(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.ILDNNNMOCOC(0).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.EPLOMIBMKFC(0).CloseUI();
				return;
			}
			BigContainerUI.ILDNNNMOCOC(1).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(ECHOGBLPALK().OpenContainer(0));
	}

	private void GJCADEIJMCM()
	{
		if ((Object)(object)NKCPGONCMBN() != (Object)null)
		{
			MGEJLDCHINI().Deselect(1);
		}
	}

	[SpecialName]
	public void CCOPJHDMHBM(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void LDLBOALBGFD(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void DMOEPMNNPAI()
	{
		if (!((Object)(object)NIMHHBJFMCG() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.OHPNDOJNCBK(1).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.IGHMHMNPMLB(1).ALPOKDOCCGM == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.Get(1).CloseUI();
				return;
			}
			BigContainerUI.OHPNDOJNCBK(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(NIMHHBJFMCG().OGJDHOMLGFK(1));
	}

	[SpecialName]
	public void ELFCJGICCNF(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void MMAEGAHANGO(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void JCDMHKEIGJF(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public ItemContainer DIBKIHHPBGL()
	{
		return ALPOKDOCCGM;
	}

	private void CMMMINEGNFP()
	{
		if ((Object)(object)FNBLIFNFLPI() != (Object)null)
		{
			NCOJLGAKBGL().Deselect(0);
		}
	}

	public void GHLMKHCIIIM()
	{
		if (!((Object)(object)NCOJLGAKBGL() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.NDJAMDLOIJL(1).IsOpen())
		{
			if ((Object)(object)BigContainerUI.FHBIFJNCOAI(1).CPNMIBGCKIN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.EIMDPBGBBIF(1).BOBCIFEDJED();
				return;
			}
			BigContainerUI.ILDNNNMOCOC(1).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(DGGAIPFFFII().OGJDHOMLGFK(1));
	}

	public void GFPJBKBGLCI()
	{
		if (!((Object)(object)BJCPHJPIFJP() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.FHBIFJNCOAI(1).IsOpen())
		{
			if ((Object)(object)BigContainerUI.MDFIDKHOPDJ(0).LHCMGHKILLJ() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.PHDBJGOEKHB(0).CloseUI();
				return;
			}
			BigContainerUI.ILDNNNMOCOC(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(HKEFPDOEMNF.OpenContainer(1, CDPAMNIPPEC: false));
	}

	[SpecialName]
	public ItemContainer OBAHPGBEPNH()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public void PPJIKECKJOD(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void DNABAALBGIP(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void JPFJOCJIIGA()
	{
		if (!((Object)(object)MIADHPLPILK() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.NDJAMDLOIJL(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.OHPNDOJNCBK(1).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.IGHMHMNPMLB(0).CloseUI();
				return;
			}
			BigContainerUI.OHPNDOJNCBK(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(HKEFPDOEMNF.OpenContainer(0, CDPAMNIPPEC: false));
	}

	private void IFBKCNJGADL()
	{
		if ((Object)(object)NHJNOHHBAJI() != (Object)null)
		{
			EOPBDOILJAA().Deselect(0);
		}
	}

	public void LNPMGHEEKFL()
	{
		if (!((Object)(object)OBAHPGBEPNH() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.PHDBJGOEKHB(1).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.MDFIDKHOPDJ(1).JPKAMFAKIAN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.NDJAMDLOIJL(0).BOBCIFEDJED();
				return;
			}
			BigContainerUI.EIMDPBGBBIF(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(DGGAIPFFFII().OpenContainer(0, CDPAMNIPPEC: false));
	}

	[SpecialName]
	public ItemContainer MPMOBNMENIC()
	{
		return ALPOKDOCCGM;
	}

	public void EPCCMLOEJOL()
	{
		if (!((Object)(object)DGGAIPFFFII() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.AIMEAJAHLAA(1).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.AANKLOIDPOA(0).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.ILDNNNMOCOC(0).CloseUI();
				return;
			}
			BigContainerUI.OHPNDOJNCBK(0).BOBCIFEDJED();
		}
		((MonoBehaviour)this).StartCoroutine(HJCNLFMCDFD().OGJDHOMLGFK(1, CDPAMNIPPEC: false));
	}

	private void OCDECHJNNCD()
	{
		if ((Object)(object)PEFLFBPEMLD() != (Object)null)
		{
			MIADHPLPILK().Deselect(0);
		}
	}

	private void GCANIILEGFN()
	{
		if ((Object)(object)BKCKDABNDLJ() != (Object)null)
		{
			OBAHPGBEPNH().Deselect(1);
		}
	}

	[SpecialName]
	public void OPCMGPGCDLH(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void PLDNDFCFMNL(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	private void EPFJBCOKEHC()
	{
		if ((Object)(object)MPMOBNMENIC() != (Object)null)
		{
			PEFLFBPEMLD().Deselect(1);
		}
	}

	[SpecialName]
	public void CHCHEBCOLGP(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	public void OABDCPNMHDH()
	{
		if (!((Object)(object)PEFLFBPEMLD() != (Object)null) || NewTutorialManager.ContainerBlocked(0))
		{
			return;
		}
		if (BigContainerUI.AIMEAJAHLAA(0).HDEPMJIDJEM())
		{
			if ((Object)(object)BigContainerUI.PHDBJGOEKHB(0).EAHMDMDHLMH() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.IGHMHMNPMLB(0).CloseUI();
				return;
			}
			BigContainerUI.BFCEHJIIAHN(0).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(OHGNHIFNLAB().OGJDHOMLGFK(1));
	}

	[SpecialName]
	public void PODGOHAIMFI(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public ItemContainer NKCPGONCMBN()
	{
		return ALPOKDOCCGM;
	}

	public void ICGBKGNHNDH()
	{
		if (!((Object)(object)MGEJLDCHINI() != (Object)null) || NewTutorialManager.ContainerBlocked(1))
		{
			return;
		}
		if (BigContainerUI.JDODHPEDACJ(0).BGLJFMHCFJF())
		{
			if ((Object)(object)BigContainerUI.AANKLOIDPOA(0).JPKAMFAKIAN() == (Object)(object)ALPOKDOCCGM)
			{
				BigContainerUI.FHBIFJNCOAI(1).BOBCIFEDJED();
				return;
			}
			BigContainerUI.JDODHPEDACJ(1).CloseUI();
		}
		((MonoBehaviour)this).StartCoroutine(BJCPHJPIFJP().OGJDHOMLGFK(1));
	}

	[SpecialName]
	public ItemContainer NHKOMEDGAFP()
	{
		return ALPOKDOCCGM;
	}

	[SpecialName]
	public void BMOCOLBHAEG(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void EACNHOHALPC(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void JFANMKADLDG(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void DOFLHCPHFIJ(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	private void DDIBFALLCNO()
	{
		if ((Object)(object)HKEFPDOEMNF != (Object)null)
		{
			NHKOMEDGAFP().Deselect(1);
		}
	}

	private void KNJBPNKFJJC()
	{
		if ((Object)(object)GCGDJJMFMJA() != (Object)null)
		{
			OBAHPGBEPNH().Deselect(0);
		}
	}

	[SpecialName]
	public void BPFGKNJJANI(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}

	[SpecialName]
	public void LKKBPJEKFDN(ItemContainer AODONKKHPBP)
	{
		ALPOKDOCCGM = AODONKKHPBP;
		icon.sprite = ((Component)ALPOKDOCCGM).GetComponent<ItemSetup>().item.icon;
	}
}
