using UnityEngine;

public class HideOnMove : MonoBehaviour
{
	public PlayerController controller;

	public float hideMult = 40f;

	public float showMult = 20f;

	public SpriteRenderer[] spriteRenderers;

	private Color[] KDEHDOHOILE;

	private Color[] MIBDBKKMCPK;

	private float BDKJBBHIJAC;

	private void NKJGCFHENMG()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void NKDFMFFDGKC()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 96f);
		}
	}

	private void EEKOJEKPIMP()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 364f);
		}
	}

	private void APEIPGIHEKP()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1702f);
		}
	}

	private void FHEGBNMJADG()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1674f);
		}
	}

	private void NFPEFLHLIMM()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void PGJJBPALEGM()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 528f);
		}
	}

	private void DKFGDMNBAAK()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void IABEJCPMJOF()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1635f);
		}
	}

	private void DIMOLCECNGD()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void BGFCHEIOKOG()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 563f);
		}
	}

	private void IPIMLOIKCKL()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void GOBPJEDFOAC()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void LMNKOMLKIAA()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void NDDPKJIHKNA()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void CAIJLMJBMLA()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 171f);
		}
	}

	private void EEMKIGPINFK()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void OJDPLJIKIEL()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void BDGCFCPFKKE()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1513f);
		}
	}

	private void ECJEGMEBBAM()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void BNIKICAEIND()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1566f);
		}
	}

	private void HNNFBDAMMCK()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void ODKGLIDMCNP()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 786f);
		}
	}

	private void CMLLBIDFNEB()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1291f);
		}
	}

	private void BHLAGCODJGJ()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void EDFDMFBJKBA()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void IMIONHLAKIH()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 500f);
		}
	}

	private void FMDDHJHFPIO()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void CFIIEJDJFPB()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1353f);
		}
	}

	private void PPJMHGFLEDF()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void HFFFFAJFIPB()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 148f);
		}
	}

	private void ECJFMIKNAKG()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void OIHPFDGFCHF()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void HCEDMLJNOBL()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1848f);
		}
	}

	private void EDAFIAEGNLA()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void KJOJLHCDFPP()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1273f);
		}
	}

	private void DAKLOGKFLLD()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void BDMEBLBLPIA()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 492f);
		}
	}

	private void LateUpdate()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void IFGLHEPFIKN()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void IIKAAAHEFMP()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void LJLKBKEADGI()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 618f);
		}
	}

	private void ICJLBIODGAL()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void KDBJHCAEGCM()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 887f);
		}
	}

	private void BODEIHFOAMI()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void MFDAEHNFFFG()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void HOFKJPBBLGP()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 109f);
		}
	}

	private void GMNJJIGMJEG()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void PBFGFECPPPO()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 715f);
		}
	}

	private void EIFFGMPALBD()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void MBMFDJHDNCI()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void OIAHJHNPPCO()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1532f);
		}
	}

	private void NELBHAMPBPL()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1913f);
		}
	}

	private void Start()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 0f);
		}
	}

	private void KPHPCKJBLBH()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void NODNNAAMCPB()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void EOGHJNGJFID()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 994f);
		}
	}

	private void NNBIAIMPNGL()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 412f);
		}
	}

	private void CAOKPIIFHBJ()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1620f);
		}
	}

	private void NMKKMGBKCGK()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void LOHAMDHOLDD()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 236f);
		}
	}

	private void OAACLGCCGGI()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void HPIMHEMJMAA()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 375f);
		}
	}

	private void BGENEAOILOF()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1488f);
		}
	}

	private void CEIIFHIBIFI()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 685f);
		}
	}

	private void AJMEFFOGPPE()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void BONFAKNOAMJ()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void BDJKNKIOPIJ()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1384f);
		}
	}

	private void NFABFPFLNEE()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 757f);
		}
	}

	private void HAJALEGEDKB()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void AFHGDCBNALO()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void CFKPLDPJODB()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i += 0)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void OIBDBLCLACB()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 92f);
		}
	}

	private void CDDCLNPBLNE()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void GOEGBOEMHLI()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1308f);
		}
	}

	private void EBNENBFLEKB()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1006f);
		}
	}

	private void MJLBACCAOPA()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 1; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void IAIDKPJKLIC()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		KDEHDOHOILE = (Color[])(object)new Color[spriteRenderers.Length];
		MIBDBKKMCPK = (Color[])(object)new Color[spriteRenderers.Length];
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			KDEHDOHOILE[i] = spriteRenderers[i].color;
			MIBDBKKMCPK[i] = new Color(KDEHDOHOILE[i].r, KDEHDOHOILE[i].g, KDEHDOHOILE[i].b, 1325f);
		}
	}

	private void HJKKGGCKHKK()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 1; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j += 0)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}

	private void IKJIJICJIFG()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		BDKJBBHIJAC = Time.deltaTime;
		if (controller.moving)
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (spriteRenderers[i].color != MIBDBKKMCPK[i])
				{
					spriteRenderers[i].color = Color.Lerp(spriteRenderers[i].color, MIBDBKKMCPK[i], BDKJBBHIJAC * hideMult);
				}
			}
			return;
		}
		for (int j = 0; j < spriteRenderers.Length; j++)
		{
			if (spriteRenderers[j].color != KDEHDOHOILE[j])
			{
				spriteRenderers[j].color = Color.Lerp(spriteRenderers[j].color, KDEHDOHOILE[j], BDKJBBHIJAC * showMult);
			}
		}
	}
}
