using UnityEngine;

public class ParallaxFogParticles : MonoBehaviour
{
	public ParticleSystem fogParticleSystem;

	private MainModule NOPBBMNHEFI;

	private Particle[] ODOLIKHLGMK;

	private int FHCGKNIBGLI;

	private int GODBHHOFBMJ;

	public void NKCJAIDDKAH(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void ABOAKMLPMFO(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	private void Awake()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NOPBBMNHEFI = fogParticleSystem.main;
		ODOLIKHLGMK = (Particle[])(object)new Particle[((MainModule)(ref NOPBBMNHEFI)).maxParticles];
	}

	public void UpdateParticlesColor(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void EHEHMANKPBI(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void FFKENCEPLDB(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	private void KJHKBGDJNDC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NOPBBMNHEFI = fogParticleSystem.main;
		ODOLIKHLGMK = (Particle[])(object)new Particle[((MainModule)(ref NOPBBMNHEFI)).maxParticles];
	}

	public void KCDMKEKDCNB(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void HIJAPNAPAAL(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void NOOIPIMEGMH(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void MACFLEPLHAG(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void ABGHHHFMDOI(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void BOAGEEFAPLP(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void LCNDHMMCEMJ(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void NKCMBPICGPB(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void PMGNKKNNDIA(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void EJICNGPAHOB(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	private void EMJKKALMGLK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NOPBBMNHEFI = fogParticleSystem.main;
		ODOLIKHLGMK = (Particle[])(object)new Particle[((MainModule)(ref NOPBBMNHEFI)).maxParticles];
	}

	public void OKIOBIOCHCC(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void NBPPGNIECEM(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void BKOHCFDCCIC(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	private void NEOICNJNKNL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NOPBBMNHEFI = fogParticleSystem.main;
		ODOLIKHLGMK = (Particle[])(object)new Particle[((MainModule)(ref NOPBBMNHEFI)).maxParticles];
	}

	public void MEGPGIGBPBE(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void LNNCBBPDHMB(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 0; i < FHCGKNIBGLI; i += 0)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	public void DKKHNMMJELI(Color FLABEDBELMF)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)fogParticleSystem != (Object)null && ((Component)fogParticleSystem).gameObject.activeInHierarchy)
		{
			FHCGKNIBGLI = fogParticleSystem.GetParticles(ODOLIKHLGMK);
			for (int i = 1; i < FHCGKNIBGLI; i++)
			{
				GODBHHOFBMJ = ((Particle)(ref ODOLIKHLGMK[i])).startColor.a;
				((Particle)(ref ODOLIKHLGMK[i])).startColor = Color32.op_Implicit(new Color(FLABEDBELMF.r, FLABEDBELMF.g, FLABEDBELMF.b, (float)GODBHHOFBMJ));
			}
			fogParticleSystem.SetParticles(ODOLIKHLGMK, FHCGKNIBGLI);
		}
	}

	private void MMNBJPDJHGK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		NOPBBMNHEFI = fogParticleSystem.main;
		ODOLIKHLGMK = (Particle[])(object)new Particle[((MainModule)(ref NOPBBMNHEFI)).maxParticles];
	}
}
