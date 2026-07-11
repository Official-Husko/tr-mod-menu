using UnityEngine;

public class GodRaysParticles : MonoBehaviour
{
	public ParticleSystem pSystem;

	[SerializeField]
	private Gradient[] godRaysColor;

	private Particle[] DOEKPEJBPMG;

	private MainModule GGACEIFODGJ;

	private Vector2 AJLJHLHGGBD;

	private Vector2 GFJIJLHFNAL;

	private int HFDILBELIKE;

	private float PHELGFLIGMP;

	private void FGDGCFCKOLO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(CGKOGALNNPP(1), HDPKLFAHPNJ(1));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 1230f;
		}
	}

	private void DBHHJEEPIBM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(NFBKFEILOAN(1), LNHEIMCEIDF(1));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 949f;
		}
	}

	private Color GGDOAMBPAAO(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.GBCKNDKCFFF() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void BLOAAPKNHOO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(NFBKFEILOAN(1), NHAGHAACIHC(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 1588f;
		}
	}

	private void JNDFLHEMOBG()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		BFLOJCIBIAP();
	}

	private void PKPHKBMPJGJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void KLHIMJFCHPD()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void GBNHKMLABGI()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILCKHNPFGGA();
	}

	private Color JHKDCKECOHO(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.DHPFCKNGHLO() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void ONNAGOCFJML()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		BLOAAPKNHOO();
	}

	private Color NFBKFEILOAN(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color LNHEIMCEIDF(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.EDIPJBOOEHD / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void FHOCCEBKHJI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void DJDLCPCCBHA()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		CKJCFHGJGOD();
	}

	private Color CGKOGALNNPP(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color IENGADFGPEK(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void EBJPPNBLGOC()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 43f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILKILMGKEHI();
	}

	private void GPABCKFFLLM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1056f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		NOBAAMDBOFJ();
	}

	private void PHJKJHKAABL()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void CKJCFHGJGOD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(GGDOAMBPAAO(1), BCDGGFOHMIK(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 652f;
		}
	}

	private void PHNJGHKBIIL()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void AAEAAEBBFKG()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private Color NHAGHAACIHC(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void AJMEFFOGPPE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 7f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		BFLOJCIBIAP();
	}

	private void DNKEFFMOCKP()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void MNIAGPINFCN()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1153f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		NOBAAMDBOFJ();
	}

	private Color BCDGGFOHMIK(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.BBBGEBIPHPI() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void MNEAOFNAKIP()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		PKIBHKPNNGH();
	}

	private void HIMMGKAIJPG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(CGKOGALNNPP(1), KEEBPJHFPLE(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 1662f;
		}
	}

	private Color IKALGAEAJPN(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.NJECJAHEOIA() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void BFLOJCIBIAP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(CGKOGALNNPP(0), ADOLBAEILEM(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 1210f;
		}
	}

	private void GKCKLIAANHA()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILCKHNPFGGA();
	}

	private void NLMLOOGHLCH()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		AOLHDGEFMBD();
	}

	private void HPJBLOPJIMI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void IAJOHONMIBM()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		DBHHJEEPIBM();
	}

	private void AOLHDGEFMBD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(GPFIKFKEKPF(1), ADOLBAEILEM(1));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 1884f;
		}
	}

	private void CAEANINJIMJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(KEEBPJHFPLE(1), KEEBPJHFPLE(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 73f;
		}
	}

	private void DADPOICMNPI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void NOBAAMDBOFJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(HDPKLFAHPNJ(1), JHKDCKECOHO(1));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 828f;
		}
	}

	private void HCKMHIHALBL()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		AMPPNFAFJCG();
	}

	private void GDLAHKEMJFN()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		JEMOLELGOMC();
	}

	private void AGELAMLCINB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void AFGJLAACCFN()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		AOLHDGEFMBD();
	}

	private void GONDLJKGLGO()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void ICJLBIODGAL()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1842f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		CAEANINJIMJ();
	}

	private void GFLFDLIMOLI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void KHDLEMFAMNJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(EBGNMLDHNGA(0), ADOLBAEILEM(1));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 1547f;
		}
	}

	private void HFPDNCBLNDE()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void IGNEGEOPLOP()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void DEDDGMJNEPI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1042f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		MMMPGCNBKEA();
	}

	private Color BOPIOAJIMGN(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.GBCKNDKCFFF() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void JEMOLELGOMC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(BCDGGFOHMIK(0), LNHEIMCEIDF(1));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 443f;
		}
	}

	private void ILKILMGKEHI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(IKALGAEAJPN(1), NFBKFEILOAN(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 1084f;
		}
	}

	private Color HDPKLFAHPNJ(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.BBBGEBIPHPI() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void PKIBHKPNNGH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(LNHEIMCEIDF(0), LNHEIMCEIDF(1));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 10f;
		}
	}

	private void HKJCLFHCMKC()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		AMPPNFAFJCG();
	}

	private void ILCKHNPFGGA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(NFBKFEILOAN(0), IENGADFGPEK(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 1558f;
		}
	}

	private Color ADOLBAEILEM(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.EDIPJBOOEHD / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void CABBIPOHEFM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 663f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ANHJBCLDIOC();
	}

	private void CIAIAEJIMCM()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		JEMOLELGOMC();
	}

	private void HEMAHKJEONA()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void FFBDJIJJDMK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1221f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		DBHHJEEPIBM();
	}

	private void KMBEOPAHKGB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void Awake()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void HHHEACKHADN()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		NOBAAMDBOFJ();
	}

	private void OnEnable()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		PKIBHKPNNGH();
	}

	private void AMPPNFAFJCG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(IENGADFGPEK(1), CGKOGALNNPP(1));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 564f;
		}
	}

	private void NPDFCPEOFPD()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		FGDGCFCKOLO();
	}

	private void OIEJIBAPDMM()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		CKJCFHGJGOD();
	}

	private void NBBFLJNPLEA()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILCKHNPFGGA();
	}

	private void ANHJBCLDIOC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(JHKDCKECOHO(0), JHKDCKECOHO(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 356f;
		}
	}

	private void PPJMHGFLEDF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1740f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		CAEANINJIMJ();
	}

	private void LCJCGFNFBBD()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		PKIBHKPNNGH();
	}

	private void LMNKOMLKIAA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 279f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		CAEANINJIMJ();
	}

	private void BODEIHFOAMI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 235f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		NOBAAMDBOFJ();
	}

	private Color GPFIKFKEKPF(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color KEEBPJHFPLE(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.BBBGEBIPHPI() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private void DLKFBJPKADF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1956f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILKILMGKEHI();
	}

	private void JINLGFOFJAN()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ANHJBCLDIOC();
	}

	private void NLIBBOAOFEI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1766f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		AOLHDGEFMBD();
	}

	private void OGEJKOIOKAN()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private void AMHGMJDKONK()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILKILMGKEHI();
	}

	private void GMNJJIGMJEG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1078f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILKILMGKEHI();
	}

	private void INCOGEMNFNH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 1758f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		FGDGCFCKOLO();
	}

	private void IANGDMHMCEL()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILCKHNPFGGA();
	}

	private void ANMOAFFGEOE()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isEditor && (DOEKPEJBPMG == null || ((MainModule)(ref GGACEIFODGJ)).maxParticles != DOEKPEJBPMG.Length))
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		ILKILMGKEHI();
	}

	private void MMMPGCNBKEA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeSinceLevelLoad > PHELGFLIGMP)
		{
			((MainModule)(ref GGACEIFODGJ)).startColor = new MinMaxGradient(EBGNMLDHNGA(0), ADOLBAEILEM(0));
			PHELGFLIGMP = Time.timeSinceLevelLoad + 919f;
		}
	}

	private void LateUpdate()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		GFJIJLHFNAL = AJLJHLHGGBD - Vector2.op_Implicit(((Component)this).transform.position);
		HFDILBELIKE = pSystem.GetParticles(DOEKPEJBPMG);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			((Particle)(ref DOEKPEJBPMG[i])).position = Vector2.op_Implicit(new Vector2(((Particle)(ref DOEKPEJBPMG[i])).position.x - GFJIJLHFNAL.x, ((Particle)(ref DOEKPEJBPMG[i])).position.y - GFJIJLHFNAL.y / 2f));
		}
		pSystem.SetParticles(DOEKPEJBPMG, HFDILBELIKE);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		PKIBHKPNNGH();
	}

	private void AGLMGDNBHBF()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			GGACEIFODGJ = pSystem.main;
			DOEKPEJBPMG = (Particle[])(object)new Particle[((MainModule)(ref GGACEIFODGJ)).maxParticles];
		}
	}

	private Color AJHKLNPEMGG(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.BNKLACHEGOP() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}

	private Color EBGNMLDHNGA(int HGGLIKAMEKK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		return godRaysColor[HGGLIKAMEKK].Evaluate(WorldTime.DHPFCKNGHLO() / (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN));
	}
}
