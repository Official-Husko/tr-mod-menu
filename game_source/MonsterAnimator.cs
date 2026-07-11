using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class MonsterAnimator : BaseAnimator
{
	public Animator animator;

	[SerializeField]
	public int monsterIndex;

	public int shadowIndex;

	public ReskinAnimation[] allReskins;

	public ReskinAnimation[] reskins;

	public ReskinAnimation[] shadowReskins;

	private int FNHCNGNCIJF;

	private int CKMGPHJOHDN;

	public bool safeMovement = true;

	private void EBJPPNBLGOC()
	{
		FLEODEFPJJF();
	}

	private void PPILDMIMADA()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(monsterIndex);
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

	public void IPOHFKGKMNE()
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
		PPILDMIMADA();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void FMDDHJHFPIO()
	{
		AGFEFJKLNFD();
	}

	public void GLNENJNMGGN()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void BAFMHANEGBK()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void MKDCOPAEHBK()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void OILCABPFJIH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void LACNIDGMKON()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(monsterIndex);
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

	public void BLHBHDHDKKH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void PCHKDNCLDKE()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void BEELAPNJKLG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void MBMFDJHDNCI()
	{
		CHHLGGHJMCG();
	}

	public void PDKCLEILBCE()
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
		ODOEEJHJLBC();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void IIPGMPFHHIA()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(monsterIndex);
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

	public void GetAllReskins()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void FFBDJIJJDMK()
	{
		OMACNPMKIDF();
	}

	public void NGHOKPHLGFH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void NODNNAAMCPB()
	{
		JJELNJFCEEG();
	}

	public void HEODMHOKEOD()
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
		JJELNJFCEEG();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void ILDICDKOLEP()
	{
		HNDKNEPGKLC();
	}

	private void FMBFGLJKCFB()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(monsterIndex);
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
		KJKGNJILMDC();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void BNMJBOKALBB()
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
		JBNGENAHPGM();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
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

	public void APKGMILECHA()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void KHCPJLEHCJC()
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
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void BBICGBMJDNP()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(monsterIndex);
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

	public void HOIIAEFLODN()
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
		BBICGBMJDNP();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void DPCGJANDCGA()
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
		FMBFGLJKCFB();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void JDDIHKNDCBC()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void BCKOBEAGOJP()
	{
		IOLPFMKMLBH();
	}

	public void HMOBFNFHGKC()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void FLEODEFPJJF()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(monsterIndex);
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

	private void ODOEEJHJLBC()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(monsterIndex);
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

	public void BBLNDMACKAP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void PHGEBLFGPKM()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(monsterIndex);
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

	private void HNDKNEPGKLC()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(monsterIndex);
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

	private void KCEANOJIIHC()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(monsterIndex);
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

	public void JECFICGEFIO()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void MAMJIDDNMKC()
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
		LACNIDGMKON();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void FLBFKMEHJKJ()
	{
		JBNGENAHPGM();
	}

	private void KJKGNJILMDC()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(monsterIndex);
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

	public void CBPAGKBHLKI()
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
		DNBDPGGDPJL();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void KEBLCNJMALL()
	{
		KJKGNJILMDC();
	}

	private void CHHLGGHJMCG()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(monsterIndex);
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

	public void NHCMKGEBOJG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void JJELNJFCEEG()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(monsterIndex);
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

	public void AKFJPLIECFJ()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void JBNGENAHPGM()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(monsterIndex);
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

	public void FCAPEDEFJOD()
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
		IOLPFMKMLBH();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void MJLBACCAOPA()
	{
		JJELNJFCEEG();
	}

	public void HOEPFPFDHJM()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void DKFPJDIKIBC()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void AGFEFJKLNFD()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(monsterIndex);
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
		IIOIANAEJFG();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void PFDALELMDAH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void DMMEOHOIEGE()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void KNEMEOCNLIA()
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
		ODOEEJHJLBC();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void NPHKFBIEMDO()
	{
		CHHLGGHJMCG();
	}

	private void IPIMLOIKCKL()
	{
		EHMJAMMNCBE();
	}

	private void EHMJAMMNCBE()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(monsterIndex);
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

	private void IIOIANAEJFG()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(monsterIndex);
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

	private void OMACNPMKIDF()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(monsterIndex);
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

	private void ECJFMIKNAKG()
	{
		JJELNJFCEEG();
	}

	private void AJMEFFOGPPE()
	{
		PHGEBLFGPKM();
	}

	private void DNBDPGGDPJL()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(monsterIndex);
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

	public void ELNGHICFDON()
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
		KJKGNJILMDC();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void DLKFBJPKADF()
	{
		HNDKNEPGKLC();
	}

	private void LateUpdate()
	{
		PHGEBLFGPKM();
	}

	public void PEAOOMHJCAC()
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
		BBICGBMJDNP();
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void IOLPFMKMLBH()
	{
		if (monsterIndex != FNHCNGNCIJF)
		{
			FNHCNGNCIJF = monsterIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(monsterIndex);
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
}
