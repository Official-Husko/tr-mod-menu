using System;
using UnityEngine;

public class ChangeIfSnowing : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;

	public Sprite frozenSprite;

	public Sprite unfrozenSprite;

	private void PLHEHGHFCJI()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(CMCOEGIPOOC));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
	}

	private void PCEFNHADDIG()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(OIDHPFPKCEI));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
		}
	}

	private void NELBHAMPBPL()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(GEKEPJDFBNJ));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EFOJGJMGCIH));
	}

	private void CAIJLMJBMLA()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(IJHHAAKKCEG));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ECCAACPKDBC));
	}

	private void OHLJKLFIGFC()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void LPAEKGACAPB()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void HHFCEBPEEPK()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(AJCICCPGKAA));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EFOJGJMGCIH));
		}
	}

	private void GADEGOPBNGC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(HGEFAHOEJKI));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BHIOJKOJBCO));
		}
	}

	private void APEIPGIHEKP()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(KFGJNMBEDDH));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OPHFKKHJPCO));
	}

	private void GEKEPJDFBNJ()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void LBGKBFNLPGF()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void AGPBHBKAHBA()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void EPEPNKCBNNJ(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != Season.Winter)
		{
			COBLEHIKLID();
		}
	}

	private void ADPMFCMFGKF()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void BHIINOMFMGE()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void DDJNEEELJDD(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != (Season)4)
		{
			ALBJIIBPGCP();
		}
	}

	private void CACJMKJBJDP()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(KNKKJLBKCBL));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(CHCIHNBDADN));
		}
	}

	private void OILHJENGGEL()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(AJCICCPGKAA));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BHIOJKOJBCO));
	}

	private void HINKPJCNPCF()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(LPDBEHHJFPD));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EPEPNKCBNNJ));
		}
	}

	private void HGHHBCCJFMF()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void GMKMALEEPLB(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != Season.Winter)
		{
			DBGPILFANKJ();
		}
	}

	private void CDGEFFLDHBD()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void HHMBCKCNPPN()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(AJCICCPGKAA));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
		}
	}

	private void PKFMLJGJKCP()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(BIMGPDGKLGL));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
		}
	}

	private void DHEFOKGIGLI()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void GNNFOOJAHJP()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void EFOJGJMGCIH(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != (Season)5)
		{
			ELHOFPGGPJK();
		}
	}

	private void COBLEHIKLID()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void BLAJFMAAMDO()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(KNKKJLBKCBL));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OMHDAEHGBKL));
		}
	}

	private void MOIDFDBCDIO()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void Start()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(BIMGPDGKLGL));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
	}

	private void KFGJNMBEDDH()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void FGFGCADFFBC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(CMCOEGIPOOC));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
		}
	}

	private void LPDBEHHJFPD()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void JCFDHFIMIBB()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void CGBJBDJELOP()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void GHHADCKLCKE()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void NLFHFPHDNCF()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(IJHHAAKKCEG));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(DDJNEEELJDD));
	}

	private void HBMDEHPHAPF()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(GHHADCKLCKE));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BHIOJKOJBCO));
	}

	private void NEEEJJNMPOF()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(HGEFAHOEJKI));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
		}
	}

	private void DIJMMDEEJCM(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != (Season)8)
		{
			NFGMDOCMDID();
		}
	}

	private void AJCICCPGKAA()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void CHCIHNBDADN(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != Season.Winter)
		{
			OHLJKLFIGFC();
		}
	}

	private void NCDBCDJKPLA()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(HGEFAHOEJKI));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EDIJKLMHCKH));
		}
	}

	private void PDMGPEGPDKB()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void FDNAEJDHODK()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(GNNFOOJAHJP));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(ECCAACPKDBC));
		}
	}

	private void KDBEBNFGJPA()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void OPHFKKHJPCO(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != Season.Summer)
		{
			PDMGPEGPDKB();
		}
	}

	private void AEKFNHLADFJ()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void NOCANBMHLPL()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void DBGPILFANKJ()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void AEDIIIAECIC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(HGHHBCCJFMF));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DDJNEEELJDD));
		}
	}

	private void MNABONMMFFB()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(LPDBEHHJFPD));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BHIOJKOJBCO));
		}
	}

	private void OJMJECJPODN(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != (Season)7)
		{
			CDGEFFLDHBD();
		}
	}

	private void CMCOEGIPOOC()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void GNFGLGCCIEB()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void OCPLOMJAFPC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(CGGPPDHCFEO));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OMHDAEHGBKL));
		}
	}

	private void BIMGPDGKLGL()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void ECCAACPKDBC(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != 0)
		{
			LPAEKGACAPB();
		}
	}

	private void HHLBFDBHDMC()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(HGEFAHOEJKI));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OPHFKKHJPCO));
	}

	private void IDPHKHGHJGN()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(HGEFAHOEJKI));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EFOJGJMGCIH));
	}

	private void NFGMDOCMDID()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void MCMKNBIBDFF()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(JCFDHFIMIBB));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OJMJECJPODN));
	}

	private void CDHBLKJEOPI()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(CGGPPDHCFEO));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
		}
	}

	private void LDNJAODEFCJ()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void CGGPPDHCFEO()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void ELHOFPGGPJK()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void CMLLBIDFNEB()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(DDNHODDHKOL));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
	}

	private void KNKKJLBKCBL()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void LANGHIOBJIH()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(LPDBEHHJFPD));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BHIOJKOJBCO));
	}

	private void FHEGBNMJADG()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(HGHHBCCJFMF));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ECCAACPKDBC));
	}

	private void DDNHODDHKOL()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void OIDHPFPKCEI()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void OOEBOIFOBNL()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void INDLPKAHNIL(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != (Season)7)
		{
			OOEBOIFOBNL();
		}
	}

	private void BPOOAHKHPCL()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(OIDHPFPKCEI));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
		}
	}

	private void HFDEFMHNHEH(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != (Season)8)
		{
			LBGKBFNLPGF();
		}
	}

	private void EDIJKLMHCKH(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != (Season)6)
		{
			APDJDHILKJC();
		}
	}

	private void CFLJHLIMHMD(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != 0)
		{
			CDGEFFLDHBD();
		}
	}

	private void JCLKGPNFCIL()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void IJHHAAKKCEG()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void JLCFNPBBKEK()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(BODIAPOOACK));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ECCAACPKDBC));
	}

	private void AGPONCCIFHC()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(GNNFOOJAHJP));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
		}
	}

	private void CAEELLKKKDP()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void ALBJIIBPGCP()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void GJNLCHHJJKH()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void BODIAPOOACK()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void BHIOJKOJBCO(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != 0)
		{
			GJNLCHHJJKH();
		}
	}

	private void APDJDHILKJC()
	{
		spriteRenderer.sprite = unfrozenSprite;
	}

	private void OMHDAEHGBKL(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH != Season.Autumn)
		{
			KDBEBNFGJPA();
		}
	}

	private void ICFHPJHBPDN()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(AJCICCPGKAA));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OJMJECJPODN));
	}

	private void FJBPFOIALMK()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(BIMGPDGKLGL));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EPEPNKCBNNJ));
		}
	}

	private void BDGCFCPFKKE()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(GHHADCKLCKE));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ECCAACPKDBC));
	}

	private void LOHAMDHOLDD()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(GNNFOOJAHJP));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EDIJKLMHCKH));
	}

	private void HGEFAHOEJKI()
	{
		spriteRenderer.sprite = frozenSprite;
	}

	private void PFLBPMIEKGF()
	{
		Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(CMCOEGIPOOC));
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EPEPNKCBNNJ));
	}

	private void OnDestroy()
	{
		Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(BIMGPDGKLGL));
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
		}
	}
}
