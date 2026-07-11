using System;
using UnityEngine;

public class CatBed : MonoBehaviour
{
	public GameObject sitLocation;

	public CatNPC catNPC;

	public bool setChild = true;

	public Animator bedAnimator;

	public Animator[] multipleBedAnimators;

	public bool tower;

	public Placeable placeable;

	private void MLPAOEEILAL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			OFFHOJOOKFO();
		}
	}

	private void LDLBMMMLEDJ()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(FHIAHMIHFCF));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(HBFKBPGECAD));
		HPILHJGKAGD();
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			OBAGBCPLIGK();
		}
	}

	private void JGDGOCLJHJJ(int JIIGOACEIKL)
	{
		DPJBMBBJJHG();
	}

	private void ACFABFCGIGH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			OFFHOJOOKFO();
		}
	}

	public void BEPDPAKGANF(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		JLJLLFILPBE();
	}

	private void OPILNECCOGP()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void NNKFDFPIBOK(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		NBGAAGHMGBA();
	}

	public void ODFDKDCOILH(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		FHDLABMCHMC();
	}

	private void OOIHNJHMBMC()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(JNMFNGKICEO));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(NKOLECDMBMG));
		BBLBPHHEGMH();
	}

	private void ANHOOODHPKD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			GOLPJECDELM();
		}
	}

	private void EDKFNAPDMCN()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NMHKNEBDFIG));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(LBCJGAHENDC));
		BNMKLGDBOJP();
	}

	private void LEDLEMPGOOA()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void KDBPILKHOKG()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.WakeUp();
		}
	}

	private void KOBNHPKEJJD()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			DJACHKIJJNC();
		}
	}

	private void FPNCANODJKE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(MJADNPFDOPL));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(OEIHNEHGGIG));
		JDNBOOJPFOA();
	}

	private void ECGFJJFMFPC()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void MNABONMMFFB()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			OFFHOJOOKFO();
		}
	}

	private void HGEJJCAHLPJ()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void MJADNPFDOPL(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		FHFNNAMOAAM();
	}

	private void IAPNLANCMEM()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void CBJLCPKAJKF()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void MMBHJALJDKI()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.APCIIKMPNJK();
		}
	}

	private void KECECIAOODC(int JIIGOACEIKL)
	{
		JLCOPFBGAJK();
	}

	public void DDMCMDMLLGP(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		NGBGBBDFPDN();
	}

	private void PGPPIHJJGDB()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(MIIGEHEKCKP));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(DPOLOPNCLPC));
		MOGELLNPFMM();
	}

	private void EOPMNBONBBL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			MMBHJALJDKI();
		}
	}

	private void EHONGHBOHDJ(int JIIGOACEIKL)
	{
		LEDLEMPGOOA();
	}

	private void KBDIKBDJKDB()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void FHIAHMIHFCF(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DJACHKIJJNC();
	}

	public void EEFBCKBAAEE()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.PBIIABMONHB();
		}
	}

	private void BLAJNBKAGDJ()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void PFOFOIDGPGC()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.WakeUp();
		}
	}

	public void LDHMAGOHCDA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		KDBIGFHECJG();
	}

	private void IBMDFNKKPJF()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(LNAFHBIANLO));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(LLEBBOBHAMA));
		DLPEGJMHOKC();
	}

	public void ADEFFBFDOEK(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CGHLOFKHHOA();
	}

	public void BLMPBHIOLCH(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HFJFGKKKJCN();
	}

	private void NEOICNJNKNL()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(CMEEMIAINEJ));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(CIFPGKHOKMF));
		LLKMJAIEKPE();
	}

	private void ICDGNPEAKPJ(int JIIGOACEIKL)
	{
		KBDCMKINODK();
	}

	public void CMEEMIAINEJ(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		PJEEHBGEEHN();
	}

	private void MJOKMDPCFGC(int JIIGOACEIKL)
	{
		MOGELLNPFMM();
	}

	private void DPJBMBBJJHG()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void JNMFNGKICEO(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		EEFBCKBAAEE();
	}

	public void LNINKAJMDLF(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		KDBIGFHECJG();
	}

	private void CIFPGKHOKMF(int JIIGOACEIKL)
	{
		ECGFJJFMFPC();
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(CLDIJLIAKDN));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(DPOLOPNCLPC));
		FPEOOHOANNO();
	}

	private void EGMCBAMIKAC()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void OIOIPMBDAAN(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		NBGAAGHMGBA();
	}

	public void WakeUpCat()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.WakeUp();
		}
	}

	private void DPOLOPNCLPC(int JIIGOACEIKL)
	{
		HGEJJCAHLPJ();
	}

	public void NGBGBBDFPDN()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.BOJBEDMEIAJ();
		}
	}

	public void OBAGBCPLIGK()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.KKJDAOHHIIJ();
		}
	}

	public void FHDLABMCHMC()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.PBIIABMONHB();
		}
	}

	private void LLEBBOBHAMA(int JIIGOACEIKL)
	{
		JDNBOOJPFOA();
	}

	public void IJLJCACMNNA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CGHLOFKHHOA();
	}

	private void GHOKECKAICE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(IKLPBOEMCHA));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(APBMADBDFKI));
		HGEJJCAHLPJ();
	}

	private void NMBMJOHAHKM(int JIIGOACEIKL)
	{
		OJJLFFMHOBN();
	}

	private void JMOCCKJNOAM(int JIIGOACEIKL)
	{
		HPILHJGKAGD();
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			OFFHOJOOKFO();
		}
	}

	public void GOLPJECDELM()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.AOGFHJCDKNO();
		}
	}

	public void DJACHKIJJNC()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.APCIIKMPNJK();
		}
	}

	public void MIIGEHEKCKP(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		MMBHJALJDKI();
	}

	public void BEOHDPAFPMJ(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		JLJLLFILPBE();
	}

	public void KDBIGFHECJG()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.APCIIKMPNJK();
		}
	}

	private void HADABGPLLLB()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WakeUpCat();
		}
	}

	private void KMBEOPAHKGB()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(MJADNPFDOPL));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(OLBMKDCMOPL));
		KBDCMKINODK();
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			FHDLABMCHMC();
		}
	}

	public void IKLPBOEMCHA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		KDBPILKHOKG();
	}

	private void AHFOFFGBPAO()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void DEKGNHEHKFB()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			HPIGNEBGJEM();
		}
	}

	private void GDDFCJIKECK()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void HEMAHKJEONA()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(DDMCMDMLLGP));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(HPNCOCNPCGL));
		OJJLFFMHOBN();
	}

	public void KCJLFPBKPIC(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GOLPJECDELM();
	}

	private void HBFKBPGECAD(int JIIGOACEIKL)
	{
		IAPNLANCMEM();
	}

	private void MOGELLNPFMM()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void BNMKLGDBOJP()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			HFJFGKKKJCN();
		}
	}

	public void PJEEHBGEEHN()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.WakeUp();
		}
	}

	private void BIMPGFHPCNP()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void JLCOPFBGAJK()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void DMCNNINDIGD(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		KDBIGFHECJG();
	}

	public void HPIGNEBGJEM()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.BOJBEDMEIAJ();
		}
	}

	public void OFFHOJOOKFO()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.WakeUp();
		}
	}

	private void DLPEGJMHOKC()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void JBKJMNOPMKH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			JLJLLFILPBE();
		}
	}

	private void Awake()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(OnThisPlaceableSelected));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(JGDGOCLJHJJ));
		DPJBMBBJJHG();
	}

	private void OLBMKDCMOPL(int JIIGOACEIKL)
	{
		HGEJJCAHLPJ();
	}

	private void HFADOIEKKFP(int JIIGOACEIKL)
	{
		DLPEGJMHOKC();
	}

	public void HIIFLMCOHCP(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		JLJLLFILPBE();
	}

	public void LPJKADFGNFC(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		JLJLLFILPBE();
	}

	private void BHAFCBHENPL()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(EEGCPLIEOMN));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(NKOLECDMBMG));
		ABNHDDELJOE();
	}

	private void HPILHJGKAGD()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void GOPOPJJKEMI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		NBGAAGHMGBA();
	}

	private void CLNBMOPMNOF()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(LNAFHBIANLO));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(KECECIAOODC));
		OPILNECCOGP();
	}

	public void GNEBIPMMJAE()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.AOGFHJCDKNO();
		}
	}

	private void NLNOFEBEBDE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(OJCOPELHNDP));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(HBFKBPGECAD));
		BBLBPHHEGMH();
	}

	private void CHNDBEDECMG()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void OJJLFFMHOBN()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void EKEABGKDPLH()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.KKJDAOHHIIJ();
		}
	}

	private void ODBDHFBMDAG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			GOLPJECDELM();
		}
	}

	public void CLDIJLIAKDN(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HPIGNEBGJEM();
	}

	private void HHFCEBPEEPK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			KDBIGFHECJG();
		}
	}

	public void OJCOPELHNDP(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		EEFBCKBAAEE();
	}

	public void DHGODIAHFHM(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		EKEABGKDPLH();
	}

	private void OEIHNEHGGIG(int JIIGOACEIKL)
	{
		EGMCBAMIKAC();
	}

	public void NMHKNEBDFIG(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		OFFHOJOOKFO();
	}

	private void LBCJGAHENDC(int JIIGOACEIKL)
	{
		DPJBMBBJJHG();
	}

	private void HPNCOCNPCGL(int JIIGOACEIKL)
	{
		DPJBMBBJJHG();
	}

	private void LJHIPOLCFBP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			NBDIJCMHPKH();
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WakeUpCat();
		}
	}

	private void NKOLECDMBMG(int JIIGOACEIKL)
	{
		ECGFJJFMFPC();
	}

	private void JDNBOOJPFOA()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void BMIEFEAGALP(int JIIGOACEIKL)
	{
		EGMCBAMIKAC();
	}

	public void OCCNGAJGIDJ(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GOLPJECDELM();
	}

	private void FDNAEJDHODK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			EEFBCKBAAEE();
		}
	}

	private void FBEGKOCHOGG()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void KBDCMKINODK()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void EEGCPLIEOMN(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		JLJLLFILPBE();
	}

	public void NBDIJCMHPKH()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.KKJDAOHHIIJ();
		}
	}

	public void GIAJIFPNHCP(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HFJFGKKKJCN();
	}

	public void NOGHLNDMMCA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		OBAGBCPLIGK();
	}

	private void LLKMJAIEKPE()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void GMCKBBECJOE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(GOPOPJJKEMI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(NMBMJOHAHKM));
		GDDFCJIKECK();
	}

	private void NJFDKCMBMDH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			EEFBCKBAAEE();
		}
	}

	public void NBGAAGHMGBA()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.APCIIKMPNJK();
		}
	}

	private void MDIENLHEDGE()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			FHDLABMCHMC();
		}
	}

	private void GBKNIJENJEF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			JLJLLFILPBE();
		}
	}

	public void JLJLLFILPBE()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.PBIIABMONHB();
		}
	}

	private void FPEOOHOANNO()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void CGMFALLCMDF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			MMBHJALJDKI();
		}
	}

	private void ABNHDDELJOE()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	public void LNAFHBIANLO(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		JLJLLFILPBE();
	}

	public void CGHLOFKHHOA()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.PBIIABMONHB();
		}
	}

	public void FHFNNAMOAAM()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.APCIIKMPNJK();
		}
	}

	private void BBLBPHHEGMH()
	{
		if (multipleBedAnimators != null && multipleBedAnimators.Length != 0)
		{
			Placeable component = ((Component)this).GetComponent<Placeable>();
			if ((Object)(object)component != (Object)null && component.multipleSkins && multipleBedAnimators.Length >= component.skinsGameObjects.Length)
			{
				bedAnimator = multipleBedAnimators[component.GetSkinIndex()];
			}
		}
	}

	private void PNLAJCHBHPH()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(CLDIJLIAKDN));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(JMOCCKJNOAM));
		HPILHJGKAGD();
	}

	private void HMOMBAFIJAI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			PJEEHBGEEHN();
		}
	}

	public void NJIKONFANBP()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.BOJBEDMEIAJ();
		}
	}

	public void OnThisPlaceableSelected(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		WakeUpCat();
	}

	public void HFJFGKKKJCN()
	{
		if ((Object)(object)catNPC != (Object)null)
		{
			catNPC.KKJDAOHHIIJ();
		}
	}

	private void APBMADBDFKI(int JIIGOACEIKL)
	{
		HGEJJCAHLPJ();
	}

	private void PKDLPIDBHDH(int JIIGOACEIKL)
	{
		ABNHDDELJOE();
	}
}
