using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Universal2DLightFlicker : MonoBehaviour
{
	public float flickersPerSecond = 15f;

	public float flickerRangeMin = -0.1f;

	public float flickerRangeMax = 0.1f;

	private float CJPKOBPELLO = -0.02f;

	private float MDOAAIKAIML = 0.02f;

	public Light2D lightSource;

	private float CCDMDFPKKJM;

	private TimerHelper LHACKABKHDN;

	private float JLLOJEPJLKM;

	private float KKANDELPDKP;

	private float NHLEKOHIOCM;

	private void CEIIFHIBIFI()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void MMPMJNAFKHC()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 1098f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void ICMNODPLPBK()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 309f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void BDJKNKIOPIJ()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void KJOJLHCDFPP()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void ELHCBGCEJDH()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 1100f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void CHIJGHPHCNA()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void PJLKGOACDEN()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 1721f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void CMDHELEDLBP()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 58f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void MCLAJGDIIBK()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 339f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void HOFKJPBBLGP()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void FGGPGOEAEKK()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 1895f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void KDBJHCAEGCM()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void JBGFGOCPEFD()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 1815f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void OIBDBLCLACB()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void Start()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void HCEDMLJNOBL()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void Update()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 1000f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void BNIKICAEIND()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void NKDFMFFDGKC()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void GOJFGHKOFMF()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 1925f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void CKCHKHNBBFG()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 1683f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void PKEPBKHEDOD()
	{
		if (LHACKABKHDN == null)
		{
			LHACKABKHDN = TimerHelper.Create();
		}
		else if (LHACKABKHDN.GetMillisecs() > 792f / flickersPerSecond)
		{
			NHLEKOHIOCM = JLLOJEPJLKM + Random.Range(flickerRangeMin, flickerRangeMax);
			lightSource.intensity = NHLEKOHIOCM;
			NHLEKOHIOCM = KKANDELPDKP + KKANDELPDKP * Random.Range(CJPKOBPELLO, MDOAAIKAIML);
			lightSource.pointLightOuterRadius = NHLEKOHIOCM;
			LHACKABKHDN.Reset();
		}
	}

	private void OLDDEAJMHNI()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}

	private void MCMKNBIBDFF()
	{
		if ((Object)(object)lightSource == (Object)null)
		{
			lightSource = ((Component)this).GetComponent<Light2D>();
		}
		JLLOJEPJLKM = lightSource.intensity;
		KKANDELPDKP = lightSource.pointLightOuterRadius;
		LHACKABKHDN = TimerHelper.Create();
	}
}
