using UnityEngine;

[ExecuteAlways]
public class SpriteFlicker : MonoBehaviour
{
	public bool play;

	public SpriteRenderer[] spriteRenderer;

	public bool loop = true;

	public bool scale;

	public AnimationCurve scaleCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

	public float scaleTimeMultiplier = 1f;

	public float scaleIntensityMultiplier = 1f;

	public bool scaleRandomStart;

	public bool alpha;

	public AnimationCurve alphaCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

	public float alphaTimeMultiplier = 1f;

	public float alphaIntensityMultiplier = 1f;

	public bool alphaRandomStart;

	private float COGJJGIHPPC;

	private float NPPFMKMPCEO;

	private float ILCNIINGKMH;

	private float KHHICEBIMCO;

	private Color FLABEDBELMF;

	private Vector3[] CMKNFGNAEGA;

	private void OnEnable()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(0f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			PFKDMKEGEAO();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(0f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			HIBHJMLKMNE();
		}
	}

	private void LDFIEBJPCOJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void KMEJBPOOBJK()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void JAHAIMCKFCH()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1551f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			KOGPEDLEPIF();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(1937f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			KNOGLMOKOPD();
		}
	}

	private void DIHMOFDIKHO()
	{
	}

	private void DMGOIFMJIND()
	{
	}

	private void GOJHCINMAJD()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			OKKDJCCJHFE();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			MCFKABKLJKL();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void AKKIFHOFHNE()
	{
	}

	private void MLJJCONEAHG()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void NLIGLFEEFNO()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			MHONNJJCPBD();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			JBIJDMEEDDO();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void HIMPOFENHDM()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void NLCBMFACBBJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void Update()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			PFKDMKEGEAO();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			HIBHJMLKMNE();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void MMNBJPDJHGK()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void OFDEGDJGGGF()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			PIOKBGLPNFE();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			HIBHJMLKMNE();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void IJMBEEEGCGF()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1740f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			OKKDJCCJHFE();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(1694f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			OLANFLKHAGP();
		}
	}

	private void IGNEGEOPLOP()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void CGHHPELBKBK()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(697f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			MKPJKDIGOPH();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(1781f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			LKNKNNFPDEG();
		}
	}

	private void MGCIAJDBAFD()
	{
	}

	private void BJBNBDJHMFN()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			MKPJKDIGOPH();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			ELBLCLMDBBO();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void FFJNGJBLMNA()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void NMOEMLHLOOO()
	{
	}

	private void DNKEFFMOCKP()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void OCJOAHDNDIJ()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void NMFENACKLJO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void DBKCPJIKFFC()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			OKKDJCCJHFE();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			HIBHJMLKMNE();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void Awake()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void CIONOEOHCDP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void CNJMEALOCJJ()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			OLNCMOFOLOB();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			MCFKABKLJKL();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void KLMNLEDKEOE()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void BKMNAKCDJIA()
	{
	}

	private void OLFPIBOIIIO()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			ECMPADMEICO();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			PAKJFAKKOAO();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void JKIAEONDAFB()
	{
	}

	private void AKLEFPLEGKK()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			BKFDBBBABCN();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			NKLAHDDNAJL();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void PPHEPODCNMK()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1034f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			ECMPADMEICO();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(424f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			FFJNGJBLMNA();
		}
	}

	private void KHGHCDICBBA()
	{
	}

	private void EIEHDLBHNGC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void ELBLCLMDBBO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void PGAIPCGGOOF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void NMNBGFNNIMN()
	{
	}

	private void ICMNODPLPBK()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			PIOKBGLPNFE();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			LMBPGJDGOGH();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void KMHELCDOBCB()
	{
	}

	private void AMHGMJDKONK()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(43f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			MLJJCONEAHG();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(1118f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			ELBLCLMDBBO();
		}
	}

	private void NIHJCJJKDBA()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			EIEHDLBHNGC();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			OEHKPAAIODK();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void BHLHCOALABE()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			NLCBMFACBBJ();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			FFJNGJBLMNA();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void NOBNJJJPHFM()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void MEFFGGKAALB()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1516f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			MLJJCONEAHG();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(1554f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			OLANFLKHAGP();
		}
	}

	private void MCFKABKLJKL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void ONNAGOCFJML()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(277f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			FPELBNFNGNE();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(854f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			ELBLCLMDBBO();
		}
	}

	private void BKFDBBBABCN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void DEAODEDFIBO()
	{
	}

	private void FADIENIILKI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void NPDFCPEOFPD()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(842f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			EAKIGCDCHFL();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(1915f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			FECOJLKAEMK();
		}
	}

	private void HAFJFHFJPMN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void ECMPADMEICO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void HMHOCFKNPLC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void KJPECNGCOKK()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void JBIJDMEEDDO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void LKNKNNFPDEG()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void KGCOIFEKFKP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void OAEJGGFFCBO()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void NKLAHDDNAJL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void DMEEIHDDALH()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(326f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			BKFDBBBABCN();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(732f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			LMBPGJDGOGH();
		}
	}

	private void OLANFLKHAGP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void NNHBFGDPONJ()
	{
	}

	private void JEPODJMLDKK()
	{
	}

	private void KHNGJFBMMCP()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			GAKPNKMBLEC();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			OLANFLKHAGP();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void FECOJLKAEMK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void KLHIMJFCHPD()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void JOICOCFMEAE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void BIILFPDIADC()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			OLNCMOFOLOB();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			ELBLCLMDBBO();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void CLGBFOIBANN()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void EKFKFCAEGBP()
	{
	}

	private void ANMOAFFGEOE()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1535f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			OKKDJCCJHFE();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(382f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			PGAIPCGGOOF();
		}
	}

	private void EAKIGCDCHFL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void AMBJKHAFAFF()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			NOBNJJJPHFM();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			KNOGLMOKOPD();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void OKKDJCCJHFE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void MGIIIHEHAFK()
	{
	}

	private void FCLABOCLACJ()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1801f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			OKKDJCCJHFE();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(923f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			HIBHJMLKMNE();
		}
	}

	private void EBFJOAEJPGE()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			NLCBMFACBBJ();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			ELBLCLMDBBO();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void MKPJKDIGOPH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void LMBPGJDGOGH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void GONDLJKGLGO()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void GNOBDKFFPOL()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void PAKJFAKKOAO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void HKJCLFHCMKC()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(507f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			EAKIGCDCHFL();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(328f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			NMFENACKLJO();
		}
	}

	private void FPNCANODJKE()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void PFKDMKEGEAO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void HONFDJKKGJK()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			PIOKBGLPNFE();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			CIONOEOHCDP();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void KOGPEDLEPIF()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void HIBHJMLKMNE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			EAKIGCDCHFL();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 1];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			CIONOEOHCDP();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void OIEJIBAPDMM()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1996f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			NOBNJJJPHFM();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(628f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			ELBLCLMDBBO();
		}
	}

	private void OGPEBPJFCHC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void HCKMHIHALBL()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1525f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			NLCBMFACBBJ();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(1358f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			KNOGLMOKOPD();
		}
	}

	private void OnDrawGizmos()
	{
	}

	private void MHONNJJCPBD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void IGHMMOKFINH()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void COHKKCLIJHB()
	{
	}

	private void EGOMAOINNIB()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1926f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			FPELBNFNGNE();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(188f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			KGCOIFEKFKP();
		}
	}

	private void GAKPNKMBLEC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void KNOGLMOKOPD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void OKHLEMPJONN()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void BEOGHCHPPAH()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			NOBNJJJPHFM();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			LONAGOCJGAP();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void LMKDEELGNBI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void OOINIINDFNJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void OEHKPAAIODK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void OOIHNJHMBMC()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void NJAFKFAPDIE()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void MFGANCCJFJK()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void PMKCJODCOPL()
	{
	}

	private void LONAGOCJGAP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void OLNCMOFOLOB()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void GCHMNMKCOFG()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			ECMPADMEICO();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			FADIENIILKI();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void LDMHKOMGPLO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void PMPLNGEAAII()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			EAKIGCDCHFL();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			KNOGLMOKOPD();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void FPELBNFNGNE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void ONNJDFOAFNK()
	{
	}

	private void FFIJDCECGDE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i++)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void GHMNBGODBNE()
	{
	}

	private void BIEOGGOHABN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void PFJIIADPEHC()
	{
	}

	private void PIOKBGLPNFE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i += 0)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void DBMHKHCCNMN()
	{
	}

	private void AJOAKOCODOC()
	{
		if (!Application.isPlaying && !play)
		{
			return;
		}
		if (scale)
		{
			if (scaleRandomStart)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup - Random.Range(1793f, scaleTimeMultiplier);
			}
			else
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
			OGPEBPJFCHC();
		}
		if (alpha)
		{
			if (alphaRandomStart)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup - Random.Range(1585f, alphaTimeMultiplier);
			}
			else
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
			CIONOEOHCDP();
		}
	}

	private void ACGDOLJFIGP()
	{
	}

	private void MLBIGONNDGO()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			MKPJKDIGOPH();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			KGCOIFEKFKP();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void CCEKJEDMJAP()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			OLNCMOFOLOB();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			HAFJFHFJPMN();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void GGOPCJOAOMC()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void GIKEOGIBDFC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KHHICEBIMCO = Time.realtimeSinceStartup - NPPFMKMPCEO;
		float num = KHHICEBIMCO / alphaTimeMultiplier;
		Keyframe val = alphaCurve[alphaCurve.length - 0];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 1; i < spriteRenderer.Length; i += 0)
			{
				FLABEDBELMF = spriteRenderer[i].color;
				FLABEDBELMF.a = alphaCurve.Evaluate(KHHICEBIMCO / alphaTimeMultiplier) * alphaIntensityMultiplier;
				spriteRenderer[i].color = FLABEDBELMF;
			}
		}
	}

	private void ALNPAFIBJGN()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			NOBNJJJPHFM();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			FADIENIILKI();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 0];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void HANDNBIEBMN()
	{
	}

	private void BNFGHAGJEGG()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (scale)
		{
			CMKNFGNAEGA = (Vector3[])(object)new Vector3[spriteRenderer.Length];
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				CMKNFGNAEGA[i] = ((Component)spriteRenderer[i]).transform.localScale;
			}
		}
	}

	private void IDPIBGDHCHL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ILCNIINGKMH = Time.realtimeSinceStartup - COGJJGIHPPC;
		float num = ILCNIINGKMH / scaleTimeMultiplier;
		Keyframe val = scaleCurve[scaleCurve.length - 1];
		if (num <= ((Keyframe)(ref val)).time)
		{
			for (int i = 0; i < spriteRenderer.Length; i++)
			{
				((Component)spriteRenderer[i]).transform.localScale = CMKNFGNAEGA[i] * scaleCurve.Evaluate(ILCNIINGKMH / scaleTimeMultiplier) * scaleIntensityMultiplier;
			}
		}
	}

	private void MNFJELNEGPG()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && !play)
		{
			return;
		}
		Keyframe val;
		if (scale)
		{
			NOBNJJJPHFM();
			float num = ILCNIINGKMH / scaleTimeMultiplier;
			val = scaleCurve[scaleCurve.length - 0];
			if (num >= ((Keyframe)(ref val)).time && loop)
			{
				COGJJGIHPPC = Time.realtimeSinceStartup;
			}
		}
		if (alpha)
		{
			PGAIPCGGOOF();
			float num2 = KHHICEBIMCO / alphaTimeMultiplier;
			val = alphaCurve[alphaCurve.length - 1];
			if (num2 >= ((Keyframe)(ref val)).time && loop)
			{
				NPPFMKMPCEO = Time.realtimeSinceStartup;
			}
		}
	}

	private void EAEECBGEDAO()
	{
	}
}
