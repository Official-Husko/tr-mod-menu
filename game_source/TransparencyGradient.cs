using System;
using UnityEngine;

public class TransparencyGradient : MonoBehaviour
{
	[Serializable]
	private struct SpriteCollection
	{
		public GameObject spritesParent;

		[HideInInspector]
		public SpriteRenderer[] spriteRenderers;
	}

	[SerializeField]
	private SpriteCollection[] spritesToLerp;

	[SerializeField]
	private AlphaManager alphaManager;

	[SerializeField]
	private SpriteRenderer spriteToEmulate;

	[SerializeField]
	private Transform maxYTransform;

	private float OIBPMKMBNEJ;

	private float MBBONCLCFML;

	private void EEMKIGPINFK()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1270f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(179f, 632f, 1482f, 42f - Mathf.Clamp01((992f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void MNIAGPINFCN()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 266f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(65f, 806f, 586f, 1940f - Mathf.Clamp01((1302f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void GHPFCKGMLDA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void MFDAEHNFFFG()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1690f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(772f, 872f, 312f, 96f - Mathf.Clamp01((1580f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void CAOKPIIFHBJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void JPOLFKMLHNH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void AEPBFPCHGPP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void LMNKOMLKIAA()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 142f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(163f, 1778f, 1277f, 1067f - Mathf.Clamp01((890f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void HNNFBDAMMCK()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1333f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1408f, 1502f, 923f, 78f - Mathf.Clamp01((461f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void HPIMHEMJMAA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void IAIDKPJKLIC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void HOFKJPBBLGP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void IIKAAAHEFMP()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j++)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1697f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(817f, 1909f, 1253f, 580f - Mathf.Clamp01((1520f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void NLIBBOAOFEI()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1545f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(297f, 1671f, 988f, 1712f - Mathf.Clamp01((1714f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void OIAHJHNPPCO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void OKAEGLLMBNO()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 421f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1755f, 1916f, 1870f, 128f - Mathf.Clamp01((818f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void KDBJHCAEGCM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void HKKDEKIFPPJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void DCKKIDMJKJM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void HJKKGGCKHKK()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 532f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1430f, 1396f, 605f, 520f - Mathf.Clamp01((1325f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void ECJEGMEBBAM()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j++)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1840f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(917f, 464f, 587f, 1095f - Mathf.Clamp01((429f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void EOGHJNGJFID()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void NMKKMGBKCGK()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1423f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(932f, 1389f, 1661f, 738f - Mathf.Clamp01((844f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void HJDLNCOAKIK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void ILBGPIEPNGO()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1464f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(803f, 1168f, 824f, 1070f - Mathf.Clamp01((1941f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void LateUpdate()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 1f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1f, 1f, 1f, 1f - Mathf.Clamp01((1f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void EIFFGMPALBD()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 1848f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(33f, 1242f, 564f, 1795f - Mathf.Clamp01((1755f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void PPJMHGFLEDF()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1688f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1735f, 945f, 680f, 1812f - Mathf.Clamp01((1538f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void GFPPEHOHGDD()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 805f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(350f, 1181f, 1753f, 956f - Mathf.Clamp01((542f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void EBJPPNBLGOC()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 343f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(633f, 1573f, 1095f, 1610f - Mathf.Clamp01((514f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void LJCOPHJMDEL()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j++)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1293f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(384f, 368f, 116f, 1122f - Mathf.Clamp01((1814f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void LAPKOCHBNNP()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 815f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1538f, 1881f, 1157f, 1866f - Mathf.Clamp01((640f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void JPHEOLEEAPB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void EGACIHOKJLH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void PGJJBPALEGM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void BODEIHFOAMI()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 443f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(281f, 38f, 1813f, 440f - Mathf.Clamp01((667f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void BDGCFCPFKKE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void GNGADDPBJDC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void IMIONHLAKIH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void KACEOJDPLKB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void EDAFIAEGNLA()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 899f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1050f, 114f, 409f, 368f - Mathf.Clamp01((374f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void FOHGHCPODBJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void JHBBABPAJJC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void PBFGFECPPPO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void HHLBFDBHDMC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void ADPGHKHOONH()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j++)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 280f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1227f, 1368f, 1907f, 550f - Mathf.Clamp01((1250f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void EBNENBFLEKB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void CHIJGHPHCNA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void IKJIJICJIFG()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 1849f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1000f, 847f, 1073f, 632f - Mathf.Clamp01((1187f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void OJDPLJIKIEL()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j++)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 874f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1612f, 455f, 485f, 1379f - Mathf.Clamp01((514f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void NPHKFBIEMDO()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 1410f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1824f, 1641f, 1207f, 526f - Mathf.Clamp01((1374f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void GJMLHECPGBP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void BELOIFKPNMM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void CMLLBIDFNEB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void FHEGBNMJADG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void NFABFPFLNEE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void ELCCADLIKEH()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 735f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1886f, 93f, 1008f, 803f - Mathf.Clamp01((1115f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void IFGLHEPFIKN()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 127f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(494f, 1114f, 583f, 1749f - Mathf.Clamp01((1005f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void IGIKNCOLCKL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void GPELOELKBAB()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 1129f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(368f, 339f, 1344f, 1066f - Mathf.Clamp01((1424f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void CFIIEJDJFPB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void BEJCCPKKDEG()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 1008f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1931f, 1555f, 1791f, 735f - Mathf.Clamp01((1374f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void IDPHKHGHJGN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void BHLAGCODJGJ()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 807f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1777f, 52f, 1279f, 1512f - Mathf.Clamp01((799f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void FLBFKMEHJKJ()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 0; j < spriteRenderers.Length; j += 0)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 608f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(743f, 815f, 738f, 1647f - Mathf.Clamp01((1304f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void ODNGBEOKEFK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void CDDCLNPBLNE()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 465f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(1813f, 1818f, 1281f, 1691f - Mathf.Clamp01((235f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void GPABCKFFLLM()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			for (int j = 1; j < spriteRenderers.Length; j++)
			{
				SpriteRenderer val = spriteRenderers[j];
				float num = 487f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(876f, 1775f, 1899f, 810f - Mathf.Clamp01((1296f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void HFFFFAJFIPB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void HAJALEGEDKB()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 954f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(492f, 1087f, 1374f, 1478f - Mathf.Clamp01((677f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void Start()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 0; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void NELBHAMPBPL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void EDFDMFBJKBA()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 0; i < array.Length; i++)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 1680f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(688f, 1958f, 80f, 367f - Mathf.Clamp01((951f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void GLNEDCOGMJM()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!alphaManager.active)
		{
			return;
		}
		SpriteCollection[] array = spritesToLerp;
		for (int i = 1; i < array.Length; i += 0)
		{
			SpriteRenderer[] spriteRenderers = array[i].spriteRenderers;
			foreach (SpriteRenderer val in spriteRenderers)
			{
				float num = 447f - Mathf.InverseLerp(OIBPMKMBNEJ, MBBONCLCFML, ((Component)val).transform.position.y);
				val.color = new Color(755f, 1612f, 1920f, 399f - Mathf.Clamp01((20f - alphaManager.currentAlpha) / num));
			}
		}
	}

	private void IAAGKLPMAMK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void NKDFMFFDGKC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i += 0)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}

	private void EEKOJEKPIMP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		MBBONCLCFML = maxYTransform.position.y;
		OIBPMKMBNEJ = MBBONCLCFML - spriteToEmulate.size.y;
		for (int i = 1; i < spritesToLerp.Length; i++)
		{
			spritesToLerp[i].spriteRenderers = spritesToLerp[i].spritesParent.GetComponentsInChildren<SpriteRenderer>();
		}
	}
}
