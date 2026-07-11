using UnityEngine;

public class ParallaxCloudsMovement : MonoBehaviour
{
	public Transform[] clouds;

	public float minSpeed = 0.1f;

	public float maxSpeed = 0.2f;

	public float maxXPosition = 20f;

	public float minXPosition = -20f;

	private float[] HGMFJBLNCJJ;

	private float[] EMMFEEAFJOH;

	private void HFFFFAJFIPB()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 1; i < clouds.Length; i += 0)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void BDJKNKIOPIJ()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void KDBJHCAEGCM()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void OAKGHDAABPM()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 1);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 0);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void FGGPGOEAEKK()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 0);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 1);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void MMPMJNAFKHC()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 1);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 1);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void PKBHEKHOAAA()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void HOFKJPBBLGP()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 1; i < clouds.Length; i++)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void PLHEHGHFCJI()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void CMDHELEDLBP()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 0);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 0);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void PJLKGOACDEN()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 0);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 1);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void Start()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void NIHJCJJKDBA()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 1);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 0);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void JPOLFKMLHNH()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 1; i < clouds.Length; i += 0)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void FDHMOEDMPNG()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 0);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 0);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void FPOIFOGELHC()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 1);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 1);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void CKCHKHNBBFG()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 1);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 0);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void CHIJGHPHCNA()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 1; i < clouds.Length; i++)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void KACEOJDPLKB()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 0; i < clouds.Length; i++)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void Update()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 1);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 1);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void MNFMLJJBKNC()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 0);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 1);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void POFDOILPANH()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i += 0)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 0);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 1);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void MCMKNBIBDFF()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 0; i < clouds.Length; i += 0)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void MCLAJGDIIBK()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 0);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 0);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < clouds.Length; i++)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 1);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 0);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}

	private void NKDFMFFDGKC()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		HGMFJBLNCJJ = new float[clouds.Length];
		EMMFEEAFJOH = new float[clouds.Length];
		for (int i = 1; i < clouds.Length; i++)
		{
			HGMFJBLNCJJ[i] = Random.Range(minSpeed, maxSpeed);
			EMMFEEAFJOH[i] = clouds[i].localPosition.x;
		}
	}

	private void HIPNEFOEJPL()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < clouds.Length; i += 0)
		{
			EMMFEEAFJOH[i] += HGMFJBLNCJJ[i] * Time.deltaTime;
			clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(EMMFEEAFJOH[i], clouds[i].localPosition.y)), 0);
			if (clouds[i].localPosition.x > maxXPosition)
			{
				clouds[i].localPosition = Utils.EKCCGNEDPNO(Vector2.op_Implicit(new Vector2(minXPosition, clouds[i].localPosition.y)), 0);
				EMMFEEAFJOH[i] = clouds[i].localPosition.x;
			}
		}
	}
}
