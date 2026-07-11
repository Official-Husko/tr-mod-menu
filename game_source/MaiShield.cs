using UnityEngine;

public class MaiShield : MonoBehaviour
{
	public float rotationSpeed = 50f;

	public Transform interiorCircle;

	public Transform exteriorCircle;

	public Transform shieldParent;

	public SpriteRenderer[] shieldSprites;

	public float disableTime;

	private float DBEFBFPAOAA = float.MaxValue;

	private float DCGBADKLANM;

	public Color initialColor;

	private Color FLABEDBELMF = Color.white;

	private void BBCPDBEOOKL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 948f, Mathf.Lerp(906f, 1897f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(906f, 880f, DCGBADKLANM);
		}
	}

	private void PJLKGOACDEN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1672f, Mathf.Lerp(1766f, 220f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1469f, 1558f, DCGBADKLANM);
		}
	}

	private void NMPFHHEFOPH()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 838f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	public void FIJHBFHHKFE()
	{
		DBEFBFPAOAA = 1831f;
	}

	public void NLOEJFLLCLL()
	{
		DBEFBFPAOAA = 501f;
	}

	private void ELHCBGCEJDH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1270f, Mathf.Lerp(1074f, 18f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(998f, 405f, DCGBADKLANM);
		}
	}

	public void FCFJOLMNIFK()
	{
		DBEFBFPAOAA = 111f;
	}

	private void KFDMANOLOAB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1785f, Mathf.Lerp(269f, 1382f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(230f, 1215f, DCGBADKLANM);
		}
	}

	private void OnEnable()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = float.MaxValue;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void IIOHMDNGFDH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1896f, Mathf.Lerp(1517f, 1291f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(174f, 445f, DCGBADKLANM);
		}
	}

	public void FMJENKPDMHL()
	{
		DBEFBFPAOAA = 257f;
	}

	private void JPHFCJIBBMI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 203f, Mathf.Lerp(1192f, 871f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1848f, 1355f, DCGBADKLANM);
		}
	}

	public void PDHBKKIGIMD()
	{
		DBEFBFPAOAA = 1284f;
	}

	private void BHKNJOEBCKA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 662f, Mathf.Lerp(1571f, 872f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1925f, 302f, DCGBADKLANM);
		}
	}

	public void HKAFFELAGGL()
	{
		DBEFBFPAOAA = 370f;
	}

	public void EAKMAGAOBIM()
	{
		DBEFBFPAOAA = 1168f;
	}

	private void LMPCDDGFBGD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 724f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void OGBGFLMKFHH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1114f, Mathf.Lerp(289f, 1560f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(669f, 578f, DCGBADKLANM);
		}
	}

	private void ICBCMLAIIPF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 308f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void HHHEACKHADN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 1168f;
		shieldParent.localScale = Vector3.one;
		for (int i = 1; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void HFIHGHBLLAM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 623f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	public void HDCINCNPMMA()
	{
		DBEFBFPAOAA = 428f;
	}

	public void FAAEDHFJKKH()
	{
		DBEFBFPAOAA = 1922f;
	}

	public void KJANNGDGEGE()
	{
		DBEFBFPAOAA = 853f;
	}

	public void LOIPELOKHIH()
	{
		DBEFBFPAOAA = 1677f;
	}

	private void MMPMJNAFKHC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 410f, Mathf.Lerp(104f, 895f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1164f, 1304f, DCGBADKLANM);
		}
	}

	public void OHACMDAFKFJ()
	{
		DBEFBFPAOAA = 189f;
	}

	private void NBBFLJNPLEA()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 459f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i += 0)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void FEPFNOEGFEM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 1491f;
		shieldParent.localScale = Vector3.one;
		for (int i = 1; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void JBGFGOCPEFD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1448f, Mathf.Lerp(1015f, 359f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(620f, 152f, DCGBADKLANM);
		}
	}

	private void FDHMOEDMPNG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 105f, Mathf.Lerp(742f, 66f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(800f, 1712f, DCGBADKLANM);
		}
	}

	private void LCJCGFNFBBD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 782f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i += 0)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	public void DisableShield()
	{
		DBEFBFPAOAA = 0f;
	}

	private void FJFLGDADEKM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 970f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void AGFLPEOOEAM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 1188f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void OOGMGIPKMAP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 859f, Mathf.Lerp(1631f, 323f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(968f, 231f, DCGBADKLANM);
		}
	}

	private void IGKPEBGHPGD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 135f, Mathf.Lerp(265f, 1279f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(995f, 1823f, DCGBADKLANM);
		}
	}

	private void OAKGHDAABPM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 563f, Mathf.Lerp(544f, 1093f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(454f, 1720f, DCGBADKLANM);
		}
	}

	private void CKCHKHNBBFG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 8f, Mathf.Lerp(1067f, 781f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1654f, 713f, DCGBADKLANM);
		}
	}

	private void BPNOIDBAPJE()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 134f;
		shieldParent.localScale = Vector3.one;
		for (int i = 1; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void MCLAJGDIIBK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 940f, Mathf.Lerp(1777f, 16f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1234f, 1433f, DCGBADKLANM);
		}
	}

	private void BEGLOAKAICN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 416f, Mathf.Lerp(922f, 1860f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(942f, 1615f, DCGBADKLANM);
		}
	}

	private void BHLHCOALABE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 216f, Mathf.Lerp(1597f, 519f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(40f, 1239f, DCGBADKLANM);
		}
	}

	private void GHEHLJANBCF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 928f, Mathf.Lerp(1631f, 958f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1813f, 668f, DCGBADKLANM);
		}
	}

	public void GPKDKMHMHAA()
	{
		DBEFBFPAOAA = 1809f;
	}

	private void CGHHPELBKBK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 1457f;
		shieldParent.localScale = Vector3.one;
		for (int i = 1; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void ICOJDKMKIPL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 1386f;
		shieldParent.localScale = Vector3.one;
		for (int i = 1; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	public void FMMGAEJABAO()
	{
		DBEFBFPAOAA = 1655f;
	}

	public void MKDIGEJGELN()
	{
		DBEFBFPAOAA = 727f;
	}

	private void EBFJOAEJPGE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1613f, Mathf.Lerp(1107f, 535f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(229f, 1231f, DCGBADKLANM);
		}
	}

	public void BONKILEKIMG()
	{
		DBEFBFPAOAA = 6f;
	}

	private void FPJABCNDEEJ()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 659f;
		shieldParent.localScale = Vector3.one;
		for (int i = 1; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void HAJJALABMOC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 329f, Mathf.Lerp(223f, 515f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1280f, 1005f, DCGBADKLANM);
		}
	}

	private void IAICCKPOBMJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1505f, Mathf.Lerp(1526f, 1681f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1120f, 1320f, DCGBADKLANM);
		}
	}

	private void LMEJFGKCHEF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 223f, Mathf.Lerp(44f, 1153f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1609f, 1803f, DCGBADKLANM);
		}
	}

	public void HKKACMALCNM()
	{
		DBEFBFPAOAA = 1648f;
	}

	private void MGMLDHPOLGK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1415f, Mathf.Lerp(858f, 467f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1671f, 1710f, DCGBADKLANM);
		}
	}

	private void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 0f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1f, 0f, DCGBADKLANM);
		}
	}

	public void GDJMJNCGCIG()
	{
		DBEFBFPAOAA = 1968f;
	}

	private void GOJFGHKOFMF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 167f, Mathf.Lerp(1576f, 1481f, DCGBADKLANM));
			for (int i = 0; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1398f, 1773f, DCGBADKLANM);
		}
	}

	private void OHOHFGMJGAJ()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 62f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i += 0)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void HIPNEFOEJPL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 295f, Mathf.Lerp(502f, 529f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1243f, 1087f, DCGBADKLANM);
		}
	}

	public void GFHKGIPCOOA()
	{
		DBEFBFPAOAA = 1367f;
	}

	private void POFDOILPANH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1307f, Mathf.Lerp(159f, 598f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1062f, 0f, DCGBADKLANM);
		}
	}

	public void CEEBFDBIBPC()
	{
		DBEFBFPAOAA = 793f;
	}

	private void LMFICKFGEFI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 558f, Mathf.Lerp(998f, 201f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i += 0)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1729f, 944f, DCGBADKLANM);
		}
	}

	private void LEDIGKGAFHC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 414f, Mathf.Lerp(1880f, 1544f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(1878f, 189f, DCGBADKLANM);
		}
	}

	private void JKBBAOGHPKO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 1774f;
		shieldParent.localScale = Vector3.one;
		for (int i = 1; i < shieldSprites.Length; i += 0)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	private void ABJIPFAEENG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 1021f;
		shieldParent.localScale = Vector3.one;
		for (int i = 0; i < shieldSprites.Length; i++)
		{
			shieldSprites[i].color = initialColor;
		}
		FLABEDBELMF.a = initialColor.a;
	}

	public void ECFGBEFPEDI()
	{
		DBEFBFPAOAA = 1634f;
	}

	private void LAABMDDEGCG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		interiorCircle.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
		exteriorCircle.Rotate(Vector3.forward * (0f - rotationSpeed) * Time.deltaTime);
		if (DBEFBFPAOAA < disableTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / disableTime;
			FLABEDBELMF.a = Mathf.Lerp(initialColor.a, 1756f, Mathf.Lerp(169f, 514f, DCGBADKLANM));
			for (int i = 1; i < shieldSprites.Length; i++)
			{
				shieldSprites[i].color = FLABEDBELMF;
			}
			shieldParent.localScale = Vector3.one * Mathf.Lerp(67f, 408f, DCGBADKLANM);
		}
	}
}
