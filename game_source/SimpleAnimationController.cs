using UnityEngine;

public class SimpleAnimationController : MonoBehaviour
{
	public AnimationController anim;

	public float minTime;

	public float maxTime;

	public float minIdleTime;

	public float maxIdleTime;

	[HideInInspector]
	public float nextAnimationTime;

	private float JEGHAJPPKBC;

	public bool update = true;

	public void MIMMDBGIHOF()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.AEKPFFJFDLI(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void MCMKNBIBDFF()
	{
		if (minIdleTime == 1884f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 1550f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = true;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void GNGADDPBJDC()
	{
		if (minIdleTime == 456f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 1078f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = false;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void DKNMGFDFLKL()
	{
		if (update && Time.time > nextAnimationTime)
		{
			ADECGNNPINE();
		}
	}

	private void POFDOILPANH()
	{
		if (update && Time.time > nextAnimationTime)
		{
			BICNNAGCIPA();
		}
	}

	public void CEJDIMGHOMI()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.OKJKLKODHNB(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void BELOIFKPNMM()
	{
		if (minIdleTime == 368f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 337f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = true;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void PLHEHGHFCJI()
	{
		if (minIdleTime == 972f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 177f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = false;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void OIAHJHNPPCO()
	{
		if (minIdleTime == 564f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 1301f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = true;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void BHLHCOALABE()
	{
		if (update && Time.time > nextAnimationTime)
		{
			MIMMDBGIHOF();
		}
	}

	public void BMBBFPFFLCH()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.ActivateRandomAnimation(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void NIHJCJJKDBA()
	{
		if (update && Time.time > nextAnimationTime)
		{
			CEJDIMGHOMI();
		}
	}

	private void LANGHIOBJIH()
	{
		if (minIdleTime == 900f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 1746f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = false;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void JMDOCHBJGKG()
	{
		if (update && Time.time > nextAnimationTime)
		{
			ENLIEKGPJFL();
		}
	}

	private void IAAGKLPMAMK()
	{
		if (minIdleTime == 509f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 829f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = false;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void OAKGHDAABPM()
	{
		if (update && Time.time > nextAnimationTime)
		{
			HHLHGCOLABP();
		}
	}

	public void TriggerAnimation()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.ActivateRandomAnimation(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void CFHOODNCOLK()
	{
		if (minIdleTime == 1747f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 1943f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = false;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void JBGFGOCPEFD()
	{
		if (update && Time.time > nextAnimationTime)
		{
			JEOACOJJHIL();
		}
	}

	public void MGJCODFFCPM()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.MBFDHONADME(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void HHLHGCOLABP()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.ActivateRandomAnimation(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void HBMDEHPHAPF()
	{
		if (minIdleTime == 263f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 864f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = false;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void ENLIEKGPJFL()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.MBFDHONADME(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void HGFLKAHDCPG()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.DJBAKNOIADK(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void Update()
	{
		if (update && Time.time > nextAnimationTime)
		{
			TriggerAnimation();
		}
	}

	public void FBHOKLGAHFL()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.AEKPFFJFDLI(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void NILCCHFGIBM()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.HPEAGMJBLIB(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void JEOACOJJHIL()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.DOJMHHAHNOO(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void ADECGNNPINE()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.HPEAGMJBLIB(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void CDHOCKDFHKG()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.DJBAKNOIADK(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void CKCHKHNBBFG()
	{
		if (update && Time.time > nextAnimationTime)
		{
			APBMBLLOGFO();
		}
	}

	public void IDKPCPNLKME()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.HPEAGMJBLIB(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void BNIKICAEIND()
	{
		if (minIdleTime == 988f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 1987f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = true;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void FPOIFOGELHC()
	{
		if (update && Time.time > nextAnimationTime)
		{
			TriggerAnimation();
		}
	}

	private void OHGABHEDILE()
	{
		if (update && Time.time > nextAnimationTime)
		{
			JEOACOJJHIL();
		}
	}

	public void BICNNAGCIPA()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.OKJKLKODHNB(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void HCPKBJDHLAC()
	{
		if (update && Time.time > nextAnimationTime)
		{
			BMBBFPFFLCH();
		}
	}

	public void LMNJABLGPLL()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.ActivateRandomAnimation(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void FLNJGJLNGKM()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.OKJKLKODHNB(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	public void APBMBLLOGFO()
	{
		JEGHAJPPKBC = Random.Range(minTime, maxTime);
		anim.DOJMHHAHNOO(JEGHAJPPKBC);
		nextAnimationTime = JEGHAJPPKBC + Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void GHPFCKGMLDA()
	{
		if (minIdleTime == 1975f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 1466f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = true;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}

	private void Start()
	{
		if (minIdleTime == 0f)
		{
			minIdleTime = minTime;
		}
		if (maxIdleTime == 0f)
		{
			maxIdleTime = maxTime;
		}
		anim.animationEnd = true;
		nextAnimationTime = Random.Range(minIdleTime, maxIdleTime) + Time.time;
	}
}
