using AlmenaraGames;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class GassAnimator : BaseAnimator
{
	public Animator animator;

	public AudioObject blinkSound;

	public AudioObject disappearSound;

	[SerializeField]
	public int gassIndex;

	public int lampIndex;

	public int fireIndex;

	public ReskinAnimation[] allReskins;

	public ReskinAnimation[] reskins;

	public ReskinAnimation[] lampReskins;

	public ReskinAnimation[] fireReskins;

	private int MDIOMAEFJCG;

	private int LAEHBLPGOCK;

	private int CCKOIAJMFOH;

	public bool safeMovement = true;

	public void HJHHHAOFDJM()
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
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void AJGGDPFKBKB()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void BEJCCPKKDEG()
	{
		JBNGENAHPGM();
	}

	private void MNIAGPINFCN()
	{
		JBNGENAHPGM();
	}

	public void KNIDGLAOHBP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void ECJFMIKNAKG()
	{
		JBNGENAHPGM();
	}

	public void OHPJBOGJGIM()
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
		PHGEBLFGPKM();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void MDODJODAJCE()
	{
		if (gassIndex != MDIOMAEFJCG)
		{
			MDIOMAEFJCG = gassIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(gassIndex);
			}
		}
		if (lampIndex != LAEHBLPGOCK)
		{
			LAEHBLPGOCK = lampIndex;
			for (int j = 1; j < lampReskins.Length; j += 0)
			{
				lampReskins[j].UpdateSprite(lampIndex);
			}
		}
		if (fireIndex != CCKOIAJMFOH)
		{
			CCKOIAJMFOH = fireIndex;
			for (int k = 0; k < fireReskins.Length; k++)
			{
				fireReskins[k].KFHGLOFHCHH(fireIndex);
			}
		}
	}

	public void PHPLJHDLLNG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void LateUpdate()
	{
		PHGEBLFGPKM();
	}

	public void ODAAEMGMJMB()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void INGEKJKOCPM()
	{
		MultiAudioManager.PlayAudioObject(disappearSound, ((Component)this).transform);
	}

	public void PFDALELMDAH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void SoundDisappear()
	{
		MultiAudioManager.PlayAudioObject(disappearSound, ((Component)this).transform);
	}

	private void DLKFBJPKADF()
	{
		PHGEBLFGPKM();
	}

	public void MHEELCOMGKM()
	{
		MultiAudioManager.PlayAudioObject(disappearSound, ((Component)this).transform);
	}

	public void NGHOKPHLGFH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void HLMABBPEGIF()
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

	public void GBPBKNDDLJA()
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
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void GLNENJNMGGN()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void HMOBFNFHGKC()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
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

	public void HBOLCJAJOGH()
	{
		MultiAudioManager.PlayAudioObject(blinkSound, ((Component)this).transform);
	}

	public void DPCGJANDCGA()
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
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void GetAllReskins()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void DMPDGPIFJDA()
	{
		MultiAudioManager.PlayAudioObject(disappearSound, ((Component)this).transform);
	}

	private void BCKOBEAGOJP()
	{
		JBNGENAHPGM();
	}

	private void PHGEBLFGPKM()
	{
		if (gassIndex != MDIOMAEFJCG)
		{
			MDIOMAEFJCG = gassIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(gassIndex);
			}
		}
		if (lampIndex != LAEHBLPGOCK)
		{
			LAEHBLPGOCK = lampIndex;
			for (int j = 0; j < lampReskins.Length; j++)
			{
				lampReskins[j].UpdateSprite(lampIndex);
			}
		}
		if (fireIndex != CCKOIAJMFOH)
		{
			CCKOIAJMFOH = fireIndex;
			for (int k = 0; k < fireReskins.Length; k++)
			{
				fireReskins[k].UpdateSprite(fireIndex);
			}
		}
	}

	private void NKJGCFHENMG()
	{
		PHGEBLFGPKM();
	}

	public void SoundBlink()
	{
		MultiAudioManager.PlayAudioObject(blinkSound, ((Component)this).transform);
	}

	private void AFHGDCBNALO()
	{
		MDODJODAJCE();
	}

	public void BENJBCHKICL()
	{
		MultiAudioManager.PlayAudioObject(disappearSound, ((Component)this).transform);
	}

	private void JBNGENAHPGM()
	{
		if (gassIndex != MDIOMAEFJCG)
		{
			MDIOMAEFJCG = gassIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(gassIndex);
			}
		}
		if (lampIndex != LAEHBLPGOCK)
		{
			LAEHBLPGOCK = lampIndex;
			for (int j = 1; j < lampReskins.Length; j++)
			{
				lampReskins[j].UpdateSprite(lampIndex);
			}
		}
		if (fireIndex != CCKOIAJMFOH)
		{
			CCKOIAJMFOH = fireIndex;
			for (int k = 1; k < fireReskins.Length; k++)
			{
				fireReskins[k].KFHGLOFHCHH(fireIndex);
			}
		}
	}

	private void ICJLBIODGAL()
	{
		PHGEBLFGPKM();
	}

	public void AIFHAEAFLHK()
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
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void LBJNMEABLME()
	{
		MultiAudioManager.PlayAudioObject(blinkSound, ((Component)this).transform);
	}
}
