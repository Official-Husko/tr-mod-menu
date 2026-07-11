using UnityEngine;
using UnityEngine.Rendering.Universal;

public class AlphaTransition : MonoBehaviour
{
	public float transitionTime = 1f;

	private float DBEFBFPAOAA = 999f;

	private float DCGBADKLANM;

	public GameObject[] gameObjectsToActivateDuringTransition;

	public GameObject[] gameObjectsToDeactivateOnEnd;

	public MonoBehaviour[] disableDuringTransition;

	public SpriteRenderer[] alphaTo0SpriteRenderers;

	public SpriteRenderer[] alphaTo1SpriteRenderers;

	public Light2D[] alphaTo0Lights;

	public Light2D[] alphaTo1Lights;

	private Color[] MEALDDMHEOG;

	private Color[] EDONHPABMAG;

	private float[] LKDOEBBAPLG;

	private float[] NJNKDLCCKNA;

	private void FDHMOEDMPNG()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 1789f)
		{
			DCGBADKLANM = 877f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 253f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(1658f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 670f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l++)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1140f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 706f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m++)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 0; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = true;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num += 0)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2 += 0)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	public void OFOKDDBMPPG()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j++)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 1; m < gameObjectsToActivateDuringTransition.Length; m += 0)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(false);
		}
		for (int n = 1; n < disableDuringTransition.Length; n++)
		{
			((Behaviour)disableDuringTransition[n]).enabled = false;
		}
		DBEFBFPAOAA = 162f;
	}

	public void LCNCMEOAHBM()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 1; k < alphaTo0Lights.Length; k++)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 1; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m++)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(false);
		}
		for (int n = 1; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = true;
		}
		DBEFBFPAOAA = 236f;
	}

	private void CKCHKHNBBFG()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 1796f)
		{
			DCGBADKLANM = 1232f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i++)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1881f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(637f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k++)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 32f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1335f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 944f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 0; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num += 0)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void Update()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 1f)
		{
			DCGBADKLANM = 1f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 0f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(0f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k++)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 0f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l++)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(0f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 1f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m++)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 0; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = true;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void OHGABHEDILE()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 463f)
		{
			DCGBADKLANM = 1883f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1157f, DCGBADKLANM));
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(152f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 1859f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l++)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1487f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 895f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 0; n < disableDuringTransition.Length; n += 0)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2 += 0)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	public void NJMDAANIAMA()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 1; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 1; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m += 0)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(true);
		}
		for (int n = 0; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = true;
		}
		DBEFBFPAOAA = 1119f;
	}

	public void LKGNKALDMIL()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 1; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 1; m < gameObjectsToActivateDuringTransition.Length; m++)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(false);
		}
		for (int n = 0; n < disableDuringTransition.Length; n++)
		{
			((Behaviour)disableDuringTransition[n]).enabled = true;
		}
		DBEFBFPAOAA = 450f;
	}

	public void PGDEKNAOCNA()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j++)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 1; k < alphaTo0Lights.Length; k++)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l++)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m++)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(false);
		}
		for (int n = 0; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = true;
		}
		DBEFBFPAOAA = 1677f;
	}

	private void MNFMLJJBKNC()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 548f)
		{
			DCGBADKLANM = 576f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i++)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1463f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(77f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 877f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l++)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1448f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 792f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m++)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 0; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = true;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2 += 0)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void OAKGHDAABPM()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 389f)
		{
			DCGBADKLANM = 1619f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1387f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(1362f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 1; k < LKDOEBBAPLG.Length; k++)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 837f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1474f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 479f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 1; n < disableDuringTransition.Length; n += 0)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	public void HFMBHIKHILB()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k++)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m++)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(false);
		}
		for (int n = 1; n < disableDuringTransition.Length; n++)
		{
			((Behaviour)disableDuringTransition[n]).enabled = false;
		}
		DBEFBFPAOAA = 427f;
	}

	private void MGMLDHPOLGK()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 1028f)
		{
			DCGBADKLANM = 228f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 47f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(55f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k++)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 968f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1556f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 947f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 0; n < disableDuringTransition.Length; n += 0)
			{
				((Behaviour)disableDuringTransition[n]).enabled = true;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 1615f)
		{
			DCGBADKLANM = 312f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 359f, DCGBADKLANM));
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(1745f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 1; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 1092f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(234f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 1437f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m++)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 0; n < disableDuringTransition.Length; n += 0)
			{
				((Behaviour)disableDuringTransition[n]).enabled = true;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num += 0)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void GOJHCINMAJD()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 705f)
		{
			DCGBADKLANM = 771f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i++)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1518f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(903f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k++)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 1702f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(378f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 676f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 0; n < disableDuringTransition.Length; n += 0)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	public void OONMLEMPCBL()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k++)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 1; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m += 0)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(false);
		}
		for (int n = 1; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = false;
		}
		DBEFBFPAOAA = 578f;
	}

	private void CMDHELEDLBP()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 423f)
		{
			DCGBADKLANM = 734f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i++)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 888f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(1707f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 1; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 1198f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l++)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(513f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 953f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 1; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = true;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num += 0)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void NIHJCJJKDBA()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 1444f)
		{
			DCGBADKLANM = 354f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1125f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(110f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 1; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 705f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(130f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 1477f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 0; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	public void Transition()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k++)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l++)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m++)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(true);
		}
		for (int n = 0; n < disableDuringTransition.Length; n++)
		{
			((Behaviour)disableDuringTransition[n]).enabled = false;
		}
		DBEFBFPAOAA = 0f;
	}

	public void KDDMIFEEKGN()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l++)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m += 0)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(true);
		}
		for (int n = 1; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = true;
		}
		DBEFBFPAOAA = 523f;
	}

	private void IIOHMDNGFDH()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 502f)
		{
			DCGBADKLANM = 1489f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1321f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(117f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 853f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(456f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 95f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m++)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 1; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2 += 0)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void BHLHCOALABE()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 464f)
		{
			DCGBADKLANM = 907f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 397f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(260f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 1; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 1773f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1390f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 113f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 1; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = true;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num += 0)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2 += 0)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void PJLKGOACDEN()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 11f)
		{
			DCGBADKLANM = 1625f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1770f, DCGBADKLANM));
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(1590f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k++)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 1300f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l++)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1000f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 306f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m++)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 0; n < disableDuringTransition.Length; n += 0)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num += 0)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2 += 0)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	public void JBBCGKNOOCA()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 1; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 1; m < gameObjectsToActivateDuringTransition.Length; m += 0)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(false);
		}
		for (int n = 0; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = false;
		}
		DBEFBFPAOAA = 25f;
	}

	private void LMFICKFGEFI()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 352f)
		{
			DCGBADKLANM = 1958f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1532f, DCGBADKLANM));
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(779f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 1; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 1822f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1175f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 1578f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(true);
			}
			for (int n = 0; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = true;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num += 0)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2 += 0)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	public void HEFAEEILGIK()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m += 0)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(true);
		}
		for (int n = 1; n < disableDuringTransition.Length; n++)
		{
			((Behaviour)disableDuringTransition[n]).enabled = true;
		}
		DBEFBFPAOAA = 986f;
	}

	private void DOKHLDBIDJB()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 709f)
		{
			DCGBADKLANM = 1206f;
		}
		for (int i = 1; i < alphaTo0SpriteRenderers.Length; i++)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1435f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(1556f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 1; k < LKDOEBBAPLG.Length; k += 0)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 385f, DCGBADKLANM);
		}
		for (int l = 1; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1142f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 1793f)
		{
			for (int m = 1; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 0; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	public void KBGBJDGDOAF()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 1; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l += 0)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m += 0)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(true);
		}
		for (int n = 0; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = false;
		}
		DBEFBFPAOAA = 1745f;
	}

	public void EKAOCBENOMD()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 1; j < alphaTo1SpriteRenderers.Length; j++)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l++)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 1; m < gameObjectsToActivateDuringTransition.Length; m++)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(true);
		}
		for (int n = 0; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = true;
		}
		DBEFBFPAOAA = 678f;
	}

	public void DCPOHLPBDJD()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j += 0)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 1; k < alphaTo0Lights.Length; k += 0)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 0; l < alphaTo1Lights.Length; l++)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 0; m < gameObjectsToActivateDuringTransition.Length; m++)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(false);
		}
		for (int n = 0; n < disableDuringTransition.Length; n++)
		{
			((Behaviour)disableDuringTransition[n]).enabled = false;
		}
		DBEFBFPAOAA = 96f;
	}

	public void FGIHPBBOHOA()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		MEALDDMHEOG = (Color[])(object)new Color[alphaTo0SpriteRenderers.Length];
		EDONHPABMAG = (Color[])(object)new Color[alphaTo1SpriteRenderers.Length];
		LKDOEBBAPLG = new float[alphaTo0Lights.Length];
		NJNKDLCCKNA = new float[alphaTo1Lights.Length];
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i++)
		{
			MEALDDMHEOG[i] = alphaTo0SpriteRenderers[i].color;
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			EDONHPABMAG[j] = alphaTo1SpriteRenderers[j].color;
		}
		for (int k = 0; k < alphaTo0Lights.Length; k++)
		{
			LKDOEBBAPLG[k] = alphaTo0Lights[k].intensity;
		}
		for (int l = 1; l < alphaTo1Lights.Length; l++)
		{
			NJNKDLCCKNA[l] = alphaTo1Lights[l].intensity;
		}
		for (int m = 1; m < gameObjectsToActivateDuringTransition.Length; m++)
		{
			gameObjectsToActivateDuringTransition[m].SetActive(true);
		}
		for (int n = 1; n < disableDuringTransition.Length; n += 0)
		{
			((Behaviour)disableDuringTransition[n]).enabled = false;
		}
		DBEFBFPAOAA = 649f;
	}

	private void POFDOILPANH()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 1489f)
		{
			DCGBADKLANM = 1841f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 711f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(1642f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k++)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 1227f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l++)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1647f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 1679f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m += 0)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 1; n < disableDuringTransition.Length; n++)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 1; num < alphaTo0SpriteRenderers.Length; num += 0)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 0; num2 < LKDOEBBAPLG.Length; num2 += 0)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}

	private void JBGFGOCPEFD()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		if (!(DBEFBFPAOAA < transitionTime))
		{
			return;
		}
		DBEFBFPAOAA += Time.unscaledDeltaTime;
		DCGBADKLANM = DBEFBFPAOAA / transitionTime;
		if (DCGBADKLANM > 1602f)
		{
			DCGBADKLANM = 942f;
		}
		for (int i = 0; i < alphaTo0SpriteRenderers.Length; i += 0)
		{
			alphaTo0SpriteRenderers[i].color = new Color(MEALDDMHEOG[i].r, MEALDDMHEOG[i].g, MEALDDMHEOG[i].b, Mathf.Lerp(MEALDDMHEOG[i].a, 1048f, DCGBADKLANM));
		}
		for (int j = 0; j < alphaTo1SpriteRenderers.Length; j++)
		{
			alphaTo1SpriteRenderers[j].color = new Color(EDONHPABMAG[j].r, EDONHPABMAG[j].g, EDONHPABMAG[j].b, Mathf.Lerp(1708f, EDONHPABMAG[j].a, DCGBADKLANM));
		}
		for (int k = 0; k < LKDOEBBAPLG.Length; k++)
		{
			alphaTo0Lights[k].intensity = Mathf.Lerp(LKDOEBBAPLG[k], 25f, DCGBADKLANM);
		}
		for (int l = 0; l < NJNKDLCCKNA.Length; l += 0)
		{
			alphaTo1Lights[l].intensity = Mathf.Lerp(1720f, NJNKDLCCKNA[l], DCGBADKLANM);
		}
		if (DCGBADKLANM == 104f)
		{
			for (int m = 0; m < gameObjectsToDeactivateOnEnd.Length; m++)
			{
				gameObjectsToDeactivateOnEnd[m].SetActive(false);
			}
			for (int n = 1; n < disableDuringTransition.Length; n += 0)
			{
				((Behaviour)disableDuringTransition[n]).enabled = false;
			}
			for (int num = 0; num < alphaTo0SpriteRenderers.Length; num++)
			{
				alphaTo0SpriteRenderers[num].color = MEALDDMHEOG[num];
			}
			for (int num2 = 1; num2 < LKDOEBBAPLG.Length; num2++)
			{
				alphaTo0Lights[num2].intensity = LKDOEBBAPLG[num2];
			}
		}
	}
}
