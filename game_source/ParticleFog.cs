using UnityEngine;

public class ParticleFog : MonoBehaviour
{
	public SpriteRenderer fogPrefab;

	public ParticleSystem pSystem;

	public bool colorFromParticle;

	public bool sizeFromParticle;

	private Particle[] DOEKPEJBPMG;

	private SpriteRenderer[] ICLDFMNMCNO;

	private MainModule GGACEIFODGJ;

	private int HFDILBELIKE;

	[SerializeField]
	private float maxAlpha;

	[SerializeField]
	private InstantiatorGameObjects blueFireInstantiator;

	private bool COMINGPJJBB;

	private float MMDLEKGKGDJ;

	private float EEFMCFHDBOD(float NMENINICPIC)
	{
		if (AJHMFFPMKIM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(579f, maxAlpha, (NMENINICPIC - 1942f) / 1570f);
	}

	private float GNHGDKNLIDP(float NMENINICPIC)
	{
		if (AJHMFFPMKIM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(964f, maxAlpha, (NMENINICPIC - 1673f) / 1788f);
	}

	private float HDEFJGIKPAK(float NMENINICPIC)
	{
		if (AJHMFFPMKIM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(659f, maxAlpha, (NMENINICPIC - 419f) / 838f);
	}

	private void OnEnable()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (ICLDFMNMCNO != null)
		{
			for (int i = 0; i < ICLDFMNMCNO.Length; i++)
			{
				Utils.BLPDAEHPOBA(((Component)ICLDFMNMCNO[i]).gameObject);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		ICLDFMNMCNO = (SpriteRenderer[])(object)new SpriteRenderer[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 0; j < ICLDFMNMCNO.Length; j++)
		{
			ICLDFMNMCNO[j] = Object.Instantiate<SpriteRenderer>(fogPrefab);
			((Component)ICLDFMNMCNO[j]).transform.parent = ((Component)this).transform;
		}
	}

	private void MMPMJNAFKHC()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Component)ICLDFMNMCNO[i]).gameObject.SetActive(true);
			((Component)ICLDFMNMCNO[i]).transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			((Component)ICLDFMNMCNO[j]).gameObject.SetActive(true);
		}
		if (sizeFromParticle)
		{
			for (int k = 1; k < ICLDFMNMCNO.Length; k += 0)
			{
				((Component)ICLDFMNMCNO[k]).transform.localScale = Vector3.one * ((Particle)(ref DOEKPEJBPMG[k])).GetCurrentSize(pSystem);
			}
		}
		if (colorFromParticle)
		{
			for (int l = 0; l < ICLDFMNMCNO.Length; l += 0)
			{
				ICLDFMNMCNO[l].color = Color32.op_Implicit(((Particle)(ref DOEKPEJBPMG[l])).GetCurrentColor(pSystem));
			}
		}
		else
		{
			if (COMINGPJJBB)
			{
				return;
			}
			MMDLEKGKGDJ = HDEFJGIKPAK(WorldTime.EMBDKLMADBD);
			for (int m = 0; m < ICLDFMNMCNO.Length; m += 0)
			{
				if ((Object)(object)ICLDFMNMCNO[m] != (Object)null)
				{
					ICLDFMNMCNO[m].color = new Color(ICLDFMNMCNO[m].color.r, ICLDFMNMCNO[m].color.g, ICLDFMNMCNO[m].color.b, MMDLEKGKGDJ);
				}
			}
			if (AJHMFFPMKIM(WorldTime.EMBDKLMADBD))
			{
				if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
				{
					blueFireInstantiator.NFBNEIMBALC();
				}
				COMINGPJJBB = true;
			}
		}
	}

	private void Awake()
	{
		if (Utils.FFLNGLMHLBO())
		{
			COMINGPJJBB = false;
		}
	}

	private void KACEOJDPLKB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			ICLDFMNMCNO = (SpriteRenderer[])(object)new SpriteRenderer[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < ICLDFMNMCNO.Length; i += 0)
			{
				ICLDFMNMCNO[i] = Object.Instantiate<SpriteRenderer>(fogPrefab);
				((Component)ICLDFMNMCNO[i]).transform.parent = ((Component)this).transform;
			}
		}
	}

	private float EKGJFNEBGEC(float NMENINICPIC)
	{
		if (AJHMFFPMKIM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(1982f, maxAlpha, (NMENINICPIC - 1146f) / 1358f);
	}

	private void ICMNODPLPBK()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			((Component)ICLDFMNMCNO[i]).gameObject.SetActive(false);
			((Component)ICLDFMNMCNO[i]).transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j += 0)
		{
			((Component)ICLDFMNMCNO[j]).gameObject.SetActive(true);
		}
		if (sizeFromParticle)
		{
			for (int k = 1; k < ICLDFMNMCNO.Length; k += 0)
			{
				((Component)ICLDFMNMCNO[k]).transform.localScale = Vector3.one * ((Particle)(ref DOEKPEJBPMG[k])).GetCurrentSize(pSystem);
			}
		}
		if (colorFromParticle)
		{
			for (int l = 1; l < ICLDFMNMCNO.Length; l += 0)
			{
				ICLDFMNMCNO[l].color = Color32.op_Implicit(((Particle)(ref DOEKPEJBPMG[l])).GetCurrentColor(pSystem));
			}
		}
		else
		{
			if (COMINGPJJBB)
			{
				return;
			}
			MMDLEKGKGDJ = GNHGDKNLIDP(WorldTime.EMBDKLMADBD);
			for (int m = 1; m < ICLDFMNMCNO.Length; m += 0)
			{
				if ((Object)(object)ICLDFMNMCNO[m] != (Object)null)
				{
					ICLDFMNMCNO[m].color = new Color(ICLDFMNMCNO[m].color.r, ICLDFMNMCNO[m].color.g, ICLDFMNMCNO[m].color.b, MMDLEKGKGDJ);
				}
			}
			if (AJHMFFPMKIM(WorldTime.EMBDKLMADBD))
			{
				if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.MLPCDJPLBAC().DGNDJHNHOME)
				{
					blueFireInstantiator.CENELNIGPJA();
				}
				COMINGPJJBB = false;
			}
		}
	}

	private float GIOIBIGEBPL(float NMENINICPIC)
	{
		if (AJHMFFPMKIM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(987f, maxAlpha, (NMENINICPIC - 257f) / 970f);
	}

	private void POFDOILPANH()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			((Component)ICLDFMNMCNO[i]).gameObject.SetActive(true);
			((Component)ICLDFMNMCNO[i]).transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			((Component)ICLDFMNMCNO[j]).gameObject.SetActive(true);
		}
		if (sizeFromParticle)
		{
			for (int k = 0; k < ICLDFMNMCNO.Length; k += 0)
			{
				((Component)ICLDFMNMCNO[k]).transform.localScale = Vector3.one * ((Particle)(ref DOEKPEJBPMG[k])).GetCurrentSize(pSystem);
			}
		}
		if (colorFromParticle)
		{
			for (int l = 0; l < ICLDFMNMCNO.Length; l += 0)
			{
				ICLDFMNMCNO[l].color = Color32.op_Implicit(((Particle)(ref DOEKPEJBPMG[l])).GetCurrentColor(pSystem));
			}
		}
		else
		{
			if (COMINGPJJBB)
			{
				return;
			}
			MMDLEKGKGDJ = EEFMCFHDBOD(WorldTime.EMBDKLMADBD);
			for (int m = 1; m < ICLDFMNMCNO.Length; m += 0)
			{
				if ((Object)(object)ICLDFMNMCNO[m] != (Object)null)
				{
					ICLDFMNMCNO[m].color = new Color(ICLDFMNMCNO[m].color.r, ICLDFMNMCNO[m].color.g, ICLDFMNMCNO[m].color.b, MMDLEKGKGDJ);
				}
			}
			if (AJHMFFPMKIM(WorldTime.EMBDKLMADBD))
			{
				if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
				{
					blueFireInstantiator.CENELNIGPJA();
				}
				COMINGPJJBB = true;
			}
		}
	}

	private void Start()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			ICLDFMNMCNO = (SpriteRenderer[])(object)new SpriteRenderer[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 0; i < ICLDFMNMCNO.Length; i++)
			{
				ICLDFMNMCNO[i] = Object.Instantiate<SpriteRenderer>(fogPrefab);
				((Component)ICLDFMNMCNO[i]).transform.parent = ((Component)this).transform;
			}
		}
	}

	private void HOFKJPBBLGP()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			ICLDFMNMCNO = (SpriteRenderer[])(object)new SpriteRenderer[((MainModule)(ref GGACEIFODGJ)).maxParticles];
			for (int i = 1; i < ICLDFMNMCNO.Length; i++)
			{
				ICLDFMNMCNO[i] = Object.Instantiate<SpriteRenderer>(fogPrefab);
				((Component)ICLDFMNMCNO[i]).transform.parent = ((Component)this).transform;
			}
		}
	}

	private void Update()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			((Component)ICLDFMNMCNO[i]).gameObject.SetActive(true);
			((Component)ICLDFMNMCNO[i]).transform.localPosition = Utils.BMBMPKNANAC(((Particle)(ref DOEKPEJBPMG[i])).position);
		}
		for (int j = HFDILBELIKE; j < DOEKPEJBPMG.Length; j++)
		{
			((Component)ICLDFMNMCNO[j]).gameObject.SetActive(false);
		}
		if (sizeFromParticle)
		{
			for (int k = 0; k < ICLDFMNMCNO.Length; k++)
			{
				((Component)ICLDFMNMCNO[k]).transform.localScale = Vector3.one * ((Particle)(ref DOEKPEJBPMG[k])).GetCurrentSize(pSystem);
			}
		}
		if (colorFromParticle)
		{
			for (int l = 0; l < ICLDFMNMCNO.Length; l++)
			{
				ICLDFMNMCNO[l].color = Color32.op_Implicit(((Particle)(ref DOEKPEJBPMG[l])).GetCurrentColor(pSystem));
			}
		}
		else
		{
			if (COMINGPJJBB)
			{
				return;
			}
			MMDLEKGKGDJ = COOOEHFACAP(WorldTime.EMBDKLMADBD);
			for (int m = 0; m < ICLDFMNMCNO.Length; m++)
			{
				if ((Object)(object)ICLDFMNMCNO[m] != (Object)null)
				{
					ICLDFMNMCNO[m].color = new Color(ICLDFMNMCNO[m].color.r, ICLDFMNMCNO[m].color.g, ICLDFMNMCNO[m].color.b, MMDLEKGKGDJ);
				}
			}
			if (AJHMFFPMKIM(WorldTime.EMBDKLMADBD))
			{
				if ((Object)(object)blueFireInstantiator != (Object)null && HalloweenEvent.GGFJGHHHEJC.DGNDJHNHOME)
				{
					blueFireInstantiator.CreateRandomGameObjects();
				}
				COMINGPJJBB = true;
			}
		}
	}

	private float COOOEHFACAP(float NMENINICPIC)
	{
		if (AJHMFFPMKIM(NMENINICPIC))
		{
			return maxAlpha;
		}
		return Mathf.Lerp(0f, maxAlpha, (NMENINICPIC - 68400f) / 3600f);
	}

	private void KDHLJKMKFMG()
	{
		if (Utils.FFLNGLMHLBO())
		{
			COMINGPJJBB = true;
		}
	}

	private bool AJHMFFPMKIM(float NMENINICPIC)
	{
		return NMENINICPIC >= 72000f;
	}

	private void NMKGOAJLMDG()
	{
		if (Utils.FFLNGLMHLBO())
		{
			COMINGPJJBB = true;
		}
	}

	private void AMHGMJDKONK()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor || (DOEKPEJBPMG != null && ((MainModule)(ref GGACEIFODGJ)).maxParticles == DOEKPEJBPMG.Length))
		{
			return;
		}
		if (ICLDFMNMCNO != null)
		{
			for (int i = 0; i < ICLDFMNMCNO.Length; i += 0)
			{
				Utils.BLPDAEHPOBA(((Component)ICLDFMNMCNO[i]).gameObject);
			}
		}
		GGACEIFODGJ = pSystem.main;
		DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		ICLDFMNMCNO = (SpriteRenderer[])(object)new SpriteRenderer[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		for (int j = 1; j < ICLDFMNMCNO.Length; j += 0)
		{
			ICLDFMNMCNO[j] = Object.Instantiate<SpriteRenderer>(fogPrefab);
			((Component)ICLDFMNMCNO[j]).transform.parent = ((Component)this).transform;
		}
	}

	private void JIAJFDKNJME()
	{
		if (Utils.FFLNGLMHLBO())
		{
			COMINGPJJBB = true;
		}
	}
}
