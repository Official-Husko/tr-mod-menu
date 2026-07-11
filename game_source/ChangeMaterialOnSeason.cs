using System;
using UnityEngine;

public class ChangeMaterialOnSeason : MonoBehaviour
{
	[SerializeField]
	private ParticleSystemRenderer[] particleRenderers;

	[SerializeField]
	private SpriteRenderer[] spriteRenders;

	[SerializeField]
	private Material springMat;

	[SerializeField]
	private Material summerMat;

	[SerializeField]
	private Material autumnMat;

	[SerializeField]
	private Material winterMat;

	private void NPMLFHDHJBE()
	{
		DPNNFPCOJJC(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HNDNCPNCLOI));
	}

	private void LDDBOMFJMNN(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void BDDBDNPCPGC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LDDBOMFJMNN));
		}
	}

	private void OHKIOLCEMLM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DPDLDHAIKMG));
		}
	}

	private void FHEGBNMJADG()
	{
		DPNNFPCOJJC(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NFPFEHJJIFG));
	}

	private void KJBIDNLHOMD()
	{
		NKKBAHENDNM(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CENNDLFGLKG));
	}

	private void HBMDEHPHAPF()
	{
		DDKNGBMFMNA(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MNACLNHPGLC));
	}

	private void BPOOAHKHPCL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DPNNFPCOJJC));
		}
	}

	private void BDGCFCPFKKE()
	{
		DOCLIABEPFF(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FJGOIBKPHLP));
	}

	private void DCMNFJOPCPF()
	{
		ODMNPIOGBOH(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JAFPHPKGPDN));
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LFABABPPHDO));
		}
	}

	private void DGOGKLMHJEG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MLMHMPNFOJJ));
		}
	}

	private void DCKKIDMJKJM()
	{
		LOCGAGGGKIL(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BFGBHFDGMAC));
	}

	private void FNFNLFOJHHA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MGHJPEIPBEL));
		}
	}

	private void AEDIIIAECIC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MLMHMPNFOJJ));
		}
	}

	private void OIBDBLCLACB()
	{
		MJGLNFDEGCC(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NAPNPPCOPJL));
	}

	private void PGJJBPALEGM()
	{
		PKHIKDCDNII(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NBPFLLKFGAN));
	}

	private void GELMGKDMJFE()
	{
		LFABABPPHDO(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LHNNFHBFCDC));
	}

	private void KCLKEAHGGEK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BFGBHFDGMAC));
		}
	}

	private void ODMNPIOGBOH(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void GFEOBIGKDMG()
	{
		LDDBOMFJMNN(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KABJOEOOKEJ));
	}

	private void NHBPEHFOMCJ(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void KACEOJDPLKB()
	{
		JAFPHPKGPDN(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NFPFEHJJIFG));
	}

	private void IKMPNICLPBM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OJPOOEGHNIC));
		}
	}

	private void DIGLPPFFKEC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LDDBOMFJMNN));
		}
	}

	private void BELOIFKPNMM()
	{
		NCMHNICKBOL(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NAPNPPCOPJL));
	}

	private void OIFEHEBHIFI(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void NKKBAHENDNM(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LDDBOMFJMNN));
		}
	}

	private void CMLLBIDFNEB()
	{
		EIANBEENFGK(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(DPNNFPCOJJC));
	}

	private void GBKNIJENJEF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BFGBHFDGMAC));
		}
	}

	private void OJPOOEGHNIC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void NCIBKMLIIAJ()
	{
		LIAPDLABBNF(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(DOCLIABEPFF));
	}

	private void KPILPDFCHBG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LHNNFHBFCDC));
		}
	}

	private void GOOPOBMDALA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LIAPDLABBNF));
		}
	}

	private void DMFMNEMDFNP()
	{
		NCMHNICKBOL(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FFKCFLEDLJA));
	}

	private void KABJOEOOKEJ(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void EIANBEENFGK(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void NBPFLLKFGAN(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void FDNAEJDHODK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LHNNFHBFCDC));
		}
	}

	private void Start()
	{
		DDKNGBMFMNA(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(DDKNGBMFMNA));
	}

	private void GHPFCKGMLDA()
	{
		KMGOBBCDDHM(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BBKEKDNIMFN));
	}

	private void NHGBJHMHEGD()
	{
		KABJOEOOKEJ(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OIFEHEBHIFI));
	}

	private void KMGOBBCDDHM(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void PLHEHGHFCJI()
	{
		DDKNGBMFMNA(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JAFPHPKGPDN));
	}

	private void EACIGGOOKGD()
	{
		LFABABPPHDO(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NCMHNICKBOL));
	}

	private void JCNPCJOBENP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OJPOOEGHNIC));
		}
	}

	private void IGAHGFIGCLH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(NBPFLLKFGAN));
		}
	}

	private void HBEBKMNGLBJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LFABABPPHDO));
		}
	}

	private void HOKBBFHGACN()
	{
		LHNNFHBFCDC(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NBPFLLKFGAN));
	}

	private void DOCLIABEPFF(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void HKKDEKIFPPJ()
	{
		NCMHNICKBOL(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NFPFEHJJIFG));
	}

	private void DDKNGBMFMNA(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void BDJKNKIOPIJ()
	{
		DEPCFBJODND(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ODMNPIOGBOH));
	}

	private void FFKCFLEDLJA(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void APEIPGIHEKP()
	{
		MMKFEDBIGNC(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CLLDEAJFEJF));
	}

	private void AHGPALJKOKP()
	{
		PKHIKDCDNII(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LOCGAGGGKIL));
	}

	private void NCMHNICKBOL(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void AIEKBPENOKC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DEPCFBJODND));
		}
	}

	private void BFGBHFDGMAC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void GBFPCABGAII()
	{
		EIANBEENFGK(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(GDJEAHFKAFB));
	}

	private void IAAGKLPMAMK()
	{
		ODMNPIOGBOH(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OIFEHEBHIFI));
	}

	private void KJOJLHCDFPP()
	{
		LFABABPPHDO(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NBPFLLKFGAN));
	}

	private void JAFPHPKGPDN(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void OCBNLECPJBN()
	{
		FJGOIBKPHLP(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CLLDEAJFEJF));
	}

	private void OJJCGNICMBD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MLMHMPNFOJJ));
		}
	}

	private void KIKHIJGMFDC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void JFIOBKKLAEL(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void LHNNFHBFCDC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void OLDDEAJMHNI()
	{
		LHNNFHBFCDC(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KIKHIJGMFDC));
	}

	private void JBBHDOMALDB()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GDJEAHFKAFB));
		}
	}

	private void FPDPAJHNGHK()
	{
		ODMNPIOGBOH(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MGHJPEIPBEL));
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DDKNGBMFMNA));
		}
	}

	private void EBNKNEIDDDI()
	{
		ODMNPIOGBOH(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(DEPCFBJODND));
	}

	private void PLHPEMNDAFB()
	{
		LIAPDLABBNF(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CENNDLFGLKG));
	}

	private void GDJEAHFKAFB(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void HLHHDNGOGNI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MMKFEDBIGNC));
		}
	}

	private void EGPONANBCNP()
	{
		CENNDLFGLKG(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KIKHIJGMFDC));
	}

	private void LJHIPOLCFBP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HNDNCPNCLOI));
		}
	}

	private void ILCBKEIEOAN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MJGLNFDEGCC));
		}
	}

	private void NFPFEHJJIFG(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void CKGJAOHPHOA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JFIOBKKLAEL));
		}
	}

	private void HPMFOHOMLDO()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DEPCFBJODND));
		}
	}

	private void HFFFFAJFIPB()
	{
		DDKNGBMFMNA(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NHBPEHFOMCJ));
	}

	private void DPNNFPCOJJC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void OIDCKGOCGKB()
	{
		LIAPDLABBNF(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LDDBOMFJMNN));
	}

	private void MGHJPEIPBEL(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void IDHCFOCEPMD()
	{
		MJGLNFDEGCC(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LFABABPPHDO));
	}

	private void DKHCOKMIJME()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GDJEAHFKAFB));
		}
	}

	private void PKHIKDCDNII(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void CDDGGGHFDMD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DPNNFPCOJJC));
		}
	}

	private void MBBIGANCPNE()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(CENNDLFGLKG));
		}
	}

	private void MLMHMPNFOJJ(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void OKAPGNGLOHO()
	{
		BFGBHFDGMAC(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KIKHIJGMFDC));
	}

	private void GIPBKJDLDPN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(NKKBAHENDNM));
		}
	}

	private void FOHGHCPODBJ()
	{
		MJGLNFDEGCC(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(DDKNGBMFMNA));
	}

	private void NAPNPPCOPJL(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void BBKEKDNIMFN(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void ODKGLIDMCNP()
	{
		DPDLDHAIKMG(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CLLDEAJFEJF));
	}

	private void LOCGAGGGKIL(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void CENNDLFGLKG(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void CLLDEAJFEJF(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void IAIDKPJKLIC()
	{
		CLLDEAJFEJF(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HNDNCPNCLOI));
	}

	private void JPOLFKMLHNH()
	{
		NKKBAHENDNM(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OJPOOEGHNIC));
	}

	private void MNACLNHPGLC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void CFHOODNCOLK()
	{
		KABJOEOOKEJ(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NFPFEHJJIFG));
	}

	private void OJAJLIAMGEJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KABJOEOOKEJ));
		}
	}

	private void FKPNIHJGFBJ()
	{
		JAFPHPKGPDN(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ODMNPIOGBOH));
	}

	private void BIGFBGOMOBA()
	{
		NFPFEHJJIFG(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KMGOBBCDDHM));
	}

	private void ENJENNBHAKJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MJGLNFDEGCC));
		}
	}

	private void IDPHKHGHJGN()
	{
		LIAPDLABBNF(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MMKFEDBIGNC));
	}

	private void PNMPJMJGGJF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OJPOOEGHNIC));
		}
	}

	private void HNEGFBCKIIJ()
	{
		DEPCFBJODND(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PKHIKDCDNII));
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DPDLDHAIKMG));
		}
	}

	private void LFNENELHOGJ()
	{
		NAPNPPCOPJL(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BBKEKDNIMFN));
	}

	private void MDIENLHEDGE()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LDDBOMFJMNN));
		}
	}

	private void HNDNCPNCLOI(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void JHIGLABAIMK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DOCLIABEPFF));
		}
	}

	private void BLAJFMAAMDO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PKHIKDCDNII));
		}
	}

	private void KOEHNENIBNP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DDKNGBMFMNA));
		}
	}

	private void MAOJJPECDAG()
	{
		CENNDLFGLKG(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MGHJPEIPBEL));
	}

	private void DPDLDHAIKMG(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void LFABABPPHDO(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void IIDPFCKPCDC()
	{
		MNACLNHPGLC(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(DOCLIABEPFF));
	}

	private void DEPCFBJODND(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void MMKFEDBIGNC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void FJGOIBKPHLP(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m += 0)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j += 0)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void LIAPDLABBNF(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 0; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 1; l < spriteRenders.Length; l++)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 0; k < spriteRenders.Length; k += 0)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i++)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 0; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void IABEJCPMJOF()
	{
		HNDNCPNCLOI(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KIKHIJGMFDC));
	}

	private void EIDJLHFAMIB()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MMKFEDBIGNC));
		}
	}

	private void FJBPFOIALMK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MMKFEDBIGNC));
		}
	}

	private void HOKAPOOCJCC()
	{
		OIFEHEBHIFI(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CLLDEAJFEJF));
	}

	private void IFHLGOMBACP()
	{
		KABJOEOOKEJ(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KMGOBBCDDHM));
	}

	private void MJGLNFDEGCC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (particleRenderers != null && (Object)(object)springMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 1; i < array.Length; i++)
				{
					((Renderer)array[i]).material = springMat;
				}
			}
			if (spriteRenders != null && (Object)(object)springMat != (Object)null)
			{
				for (int m = 1; m < spriteRenders.Length; m++)
				{
					((Renderer)spriteRenders[m]).material = springMat;
				}
			}
			break;
		case Season.Summer:
			if (particleRenderers != null && (Object)(object)summerMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = summerMat;
				}
			}
			if (spriteRenders != null && (Object)(object)summerMat != (Object)null)
			{
				for (int l = 0; l < spriteRenders.Length; l += 0)
				{
					((Renderer)spriteRenders[l]).material = summerMat;
				}
			}
			break;
		case Season.Autumn:
			if (particleRenderers != null && (Object)(object)autumnMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = autumnMat;
				}
			}
			if (spriteRenders != null && (Object)(object)autumnMat != (Object)null)
			{
				for (int k = 1; k < spriteRenders.Length; k++)
				{
					((Renderer)spriteRenders[k]).material = autumnMat;
				}
			}
			break;
		case Season.Winter:
			if (particleRenderers != null && (Object)(object)winterMat != (Object)null)
			{
				ParticleSystemRenderer[] array = particleRenderers;
				for (int i = 0; i < array.Length; i += 0)
				{
					((Renderer)array[i]).material = winterMat;
				}
			}
			if (spriteRenders != null && (Object)(object)winterMat != (Object)null)
			{
				for (int j = 1; j < spriteRenders.Length; j++)
				{
					((Renderer)spriteRenders[j]).material = winterMat;
				}
			}
			break;
		}
	}

	private void MFIEPGBABAM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(DPNNFPCOJJC));
		}
	}
}
