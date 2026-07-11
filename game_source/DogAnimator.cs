using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class DogAnimator : BaseAnimator
{
	public Animator animator;

	[SerializeField]
	public int dogIndex;

	public int shadowIndex;

	public ReskinAnimation[] allReskins;

	public ReskinAnimation[] reskins;

	public ReskinAnimation[] shadowReskins;

	private int HBBHDBGMOCB;

	private int CKMGPHJOHDN;

	public void FKDHIGHEILF()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		MDODJODAJCE();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void MNAONLLBKDC()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		EIMPOHJFEAL();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void IIKAAAHEFMP()
	{
		FCMNOADAEAC();
	}

	public void BBHGKGPAINM()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		GFAEJFLEIFA();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void MBMFDJHDNCI()
	{
		JFALJHBHDMD();
	}

	private void NLEOMMPMBDF()
	{
		PBCOMKMPGGO();
	}

	public void LOMPKIHOBGP()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		JBNGENAHPGM();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void MIAJIBIIEKO()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	public void GNEPLHPJPKB()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		IIPGMPFHHIA();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void AFGIPGGIGKC()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		KHIMBMDEOJE();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void PDKCLEILBCE()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		KIJGAEMEHGL();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void DOFDJMHDJKD()
	{
		EJPAHEBOHII();
	}

	public void AddImages()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		PHGEBLFGPKM();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void NDMIJJJOOAA()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	private void KHIMBMDEOJE()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void GFAEJFLEIFA()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	private void KHKLJBJLBND()
	{
		AGFEFJKLNFD();
	}

	private void AGFEFJKLNFD()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void BFNIFGHFKGK()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void GBGJKGGECCJ()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void EFCBBBIECOE()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void JBNGENAHPGM()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void IIHOHMDMIBL()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void KIJGAEMEHGL()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void DOFFBALINNM()
	{
		LNGHIPPNHLJ();
	}

	private void NPEOJEJIDHD()
	{
		EJPAHEBOHII();
	}

	private void MNIAGPINFCN()
	{
		HBPLKBCPCIP();
	}

	private void JFALJHBHDMD()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void EHMJAMMNCBE()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void LEBHOADHBDG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void PHGEBLFGPKM()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void IBGIINIBPCI()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		MDODJODAJCE();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void JIIGLMCKFIP()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		KHIMBMDEOJE();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void MPAPHPCKFPA()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void FPGKPFNHDCE()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		GFAEJFLEIFA();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void IHPNFGJMNEI()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		CECHDDKDMID();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void LNLIFHDDGID()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		FLHHGHJGPAD();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void HBPLKBCPCIP()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void DHNPMLNIGHM()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void AIOGOOKGNLA()
	{
		CMAEPGNPKJE();
	}

	private void NMKKMGBKCGK()
	{
		KPKAOKOHOMJ();
	}

	private void GHJNMJJAAFC()
	{
		CHHLGGHJMCG();
	}

	public void HDBBEGJKMFB()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		KIJGAEMEHGL();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void ADMLPDCEOMA()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void PFMHGKEDAPN()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void KPKAOKOHOMJ()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void BNODBICHMAI()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		DHNPMLNIGHM();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void ILHBACDLKGP()
	{
		DIFANPEDCDO();
	}

	public void DNHOMDKGOJE()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void CMAEPGNPKJE()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void EKCDIPLBBOL()
	{
		PPLIOHKBFNB();
	}

	private void FFBDJIJJDMK()
	{
		MFIOGKIKKPF();
	}

	public void MDLDKCIGKGK()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void JFKIOIFNCCF()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		JFALJHBHDMD();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void JBKCINCGHHL()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		CECHDDKDMID();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void EIMPOHJFEAL()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	public void MOKAKGMCCLC()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		LACNIDGMKON();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void MDODJODAJCE()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void NHJBIFNAGAB()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		AGFEFJKLNFD();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void LACNIDGMKON()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void FBGPFNELHDL()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void PNBAMBBAKJD()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void GPABCKFFLLM()
	{
		FBGPFNELHDL();
	}

	public void ODAAEMGMJMB()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void OILCABPFJIH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void BEPFCEEEFMG()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	public void MKGOKMJFDFP()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		DHNPMLNIGHM();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void HEFFCKIKHOD()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void AHFJJHNKDJA()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		PBCOMKMPGGO();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void NODNNAAMCPB()
	{
		EIMPOHJFEAL();
	}

	public void MIPDHKECIME()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void DPKEDHBMMBH()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		KIJGAEMEHGL();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void GOGOIJNNEJF()
	{
		GFAEJFLEIFA();
	}

	private void PBCOMKMPGGO()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void PLKGNHIFLGG()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void OLNJHFPBFBK()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		CECHDDKDMID();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void ECJEGMEBBAM()
	{
		CHHLGGHJMCG();
	}

	private void KIPDGECFDFI()
	{
		NDMIJJJOOAA();
	}

	public void BLHBHDHDKKH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void DPGOMEBLCNL()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void NNPLIFOCKIN()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		EOBNCDNHBMN();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void EEEELGEFFFE()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void HCBGGFCNDLP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void APBJNPAKJHF()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	public void JFABKDIIPCN()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void OJAEFEMMDJM()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void PJGJNLGNGHK()
	{
		MFIOGKIKKPF();
	}

	public void FELOFICJDEJ()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		EJPAHEBOHII();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void LNGHIPPNHLJ()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void OKAEGLLMBNO()
	{
		DHNPMLNIGHM();
	}

	public void KDDGGMKGANK()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		FLHHGHJGPAD();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void FGMJECNPEEF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void OPEIDDFCPGB()
	{
		FCMNOADAEAC();
	}

	public void BKCAEDNLJJB()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void DIFANPEDCDO()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void EOBNCDNHBMN()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void GAHNCHNBFNA()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void PPLIOHKBFNB()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void NLIBBOAOFEI()
	{
		EOBNCDNHBMN();
	}

	private void HNNFBDAMMCK()
	{
		MDODJODAJCE();
	}

	private void EJPAHEBOHII()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void BODEIHFOAMI()
	{
		APBJNPAKJHF();
	}

	private void HJNIBHFPBHP()
	{
		LACNIDGMKON();
	}

	private void FLBFKMEHJKJ()
	{
		FBGPFNELHDL();
	}

	private void DIMOLCECNGD()
	{
		EHMJAMMNCBE();
	}

	private void PBOHGKICLOP()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	public void BBLNDMACKAP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void NGGFADOFCAL()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void FLHHGHJGPAD()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void PFGDOHMJGGO()
	{
		DHNPMLNIGHM();
	}

	public void NPJPJBBBOKP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void PGNKELBEIAH()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		FCMNOADAEAC();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void JPPCPMOMDON()
	{
		CMAEPGNPKJE();
	}

	public void ICLMNHPBMFN()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		GFAEJFLEIFA();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void FJGJMEEMENK()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		EJPAHEBOHII();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void IIPGMPFHHIA()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	private void FCMNOADAEAC()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void IPPENKNOIBJ()
	{
		CMAEPGNPKJE();
	}

	private void HDBEDEGEMCC()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	private void OPGEGPCBNJB()
	{
		JBNGENAHPGM();
	}

	private void GPELOELKBAB()
	{
		FLHHGHJGPAD();
	}

	public void GetAllReskins()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void HOLBFJJHEPA()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		PBOHGKICLOP();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void MHJHCBCBBNG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void IADIOMBFMHL()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		GFAEJFLEIFA();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void NMIHLADIPOM()
	{
		HBPLKBCPCIP();
	}

	public void DIBGAJEMFLB()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void BEELAPNJKLG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void CECHDDKDMID()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 0; j < shadowReskins.Length; j++)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	private void CHHLGGHJMCG()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}

	public void CGBHIDPGPJO()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void LAPAENPBFKF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void BAMLKKIFHIG()
	{
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		IIHOHMDMIBL();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void LateUpdate()
	{
		PHGEBLFGPKM();
	}

	public void BKGMIODBIHK()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		CECHDDKDMID();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void MFIOGKIKKPF()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].KFHGLOFHCHH(shadowIndex);
			}
		}
	}

	public void GDBAFCJDPIL()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void PODNELDNBCK()
	{
		if (dogIndex != HBBHDBGMOCB)
		{
			HBBHDBGMOCB = dogIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(dogIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].EJDIKKHJOAH(shadowIndex);
			}
		}
	}
}
