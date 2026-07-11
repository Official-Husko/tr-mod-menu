using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class BasicAnimator : MonoBehaviour
{
	public Animator animator;

	[SerializeField]
	public int birdIndex;

	public int shadowIndex;

	public ReskinAnimation[] allReskins;

	public ReskinAnimation[] reskins;

	public ReskinAnimation[] shadowReskins;

	private int AIIGJBGJMJK;

	private int CKMGPHJOHDN;

	public bool safeMovement = true;

	public void GAHNCHNBFNA()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void GOGOIJNNEJF()
	{
		IIHOHMDMIBL();
	}

	public void IHOCEHGCNOF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void AGNAEDGMKKN()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void OOLPKIPGJKN(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i++)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void EGKDGHNPPDC(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void HPKOMPLKKEJ()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void OMEOHNKOCIJ()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(birdIndex);
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

	public void DNHOMDKGOJE()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void FMDDHJHFPIO()
	{
		DHNPMLNIGHM();
	}

	public void DKFPJDIKIBC()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void LCOCDBEFIEA()
	{
		PJOPHPBABAI();
	}

	public void KNIDGLAOHBP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void DNJADOEECLA()
	{
		EJPAHEBOHII();
	}

	public void GIFGHAHEFFG(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void ALLBDHLJPKG(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	private void CDDBJOGKKIE()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(birdIndex);
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

	public void JAHGNKDACBB(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
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
		OMEOHNKOCIJ();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void CNPDGLHFJON(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	public void DPCGJANDCGA()
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
		NHHILKBOMNH();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void LPKJLJINEEE()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void PFDALELMDAH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void EFNDOOIAONB(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	public void LDJCDAAFMKK(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void FDDOHPJLOLJ(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void CCNOMFKIMLF(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	public void JOMEEGEHOAG(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	private void OMLDFOBLGIM()
	{
		PJOPHPBABAI();
	}

	public void ALFEMNIIHDO()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void HMGBIMHKFOD()
	{
		GLDBPNOPMGA();
	}

	public void LEBHOADHBDG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void PPCFKGAKNPI(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void MPAPHPCKFPA()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void PJOPHPBABAI()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(birdIndex);
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

	private void IFGLHEPFIKN()
	{
		NHHILKBOMNH();
	}

	public void MEHIAHMBGFH(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	public void JKDPGFKPMAA(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void CHPJCLOJEMF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void ODMMGJPCGOE(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	private void IIHOHMDMIBL()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(birdIndex);
			}
		}
		if (shadowIndex != CKMGPHJOHDN)
		{
			CKMGPHJOHDN = shadowIndex;
			for (int j = 1; j < shadowReskins.Length; j += 0)
			{
				shadowReskins[j].UpdateSprite(shadowIndex);
			}
		}
	}

	public void GetAllReskins()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void HJKKGGCKHKK()
	{
		EJPAHEBOHII();
	}

	public void IBDJODAFMDK(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void BNPNLDNJPBO(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	public void DDIGDOCNGBJ(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	public void FHNLFPCHLKF()
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
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void MLCKBDHCOMC()
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
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void DIBGAJEMFLB()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void DECHNJMHIMF(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	private void CHHLGGHJMCG()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(birdIndex);
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

	private void MDILKDEGCOE()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(birdIndex);
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

	public void GFKGHMNHNBJ()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void BPHHCOFIDOO(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void PHNLCDONNKO(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void GFOFFHGOPLP(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	public void AIAJIIHOHAA(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	private void IPIMLOIKCKL()
	{
		IIHOHMDMIBL();
	}

	public void KPGAAJDMIDC(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	public void JNNLHBFMFDD()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void OMLNDHJAAJD()
	{
		NHHILKBOMNH();
	}

	private void FMBFGLJKCFB()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].KFHGLOFHCHH(birdIndex);
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

	public void ABDDMFHMDNJ(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	public void MNBMKFKEJAK(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	private void CABBIPOHEFM()
	{
		IIHOHMDMIBL();
	}

	private void HJNIBHFPBHP()
	{
		GLDBPNOPMGA();
	}

	public void GDJKLMJFGCP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void EDAFIAEGNLA()
	{
		PHGEBLFGPKM();
	}

	public void MIINHHNJJLM(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	private void AIAFGBCOJKL()
	{
		PJOPHPBABAI();
	}

	public void FOAKBEPJCLB(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void DNGJDJPLHAP()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void FLBFKMEHJKJ()
	{
		PHGEBLFGPKM();
	}

	private void PLKGNHIFLGG()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].EJDIKKHJOAH(birdIndex);
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

	public void ENNIIOPPMME(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i++)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	private void DEDDGMJNEPI()
	{
		GLDBPNOPMGA();
	}

	public void GBBDPBCGMNK(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void IJGBCCGKOIH(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	public void HLIPFGOJFNF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void BNODBICHMAI()
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
		PJOPHPBABAI();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void PLGODNAIKDG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void EONNHGPOPCO(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void NLDCMCNLIMM(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void FEIDDFAAIHA(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	private void PFGDOHMJGGO()
	{
		IIHOHMDMIBL();
	}

	public void KAMENAFHLDE(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	private void BONFAKNOAMJ()
	{
		CHHLGGHJMCG();
	}

	public void AKFIEJFHPJG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void BHOKKKPNFCH(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	public void MPDHMNNGMEF()
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
		PLKGNHIFLGG();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void KNMDFHPCPJD()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void KDEMAMKPGGN(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	private void HIGGKFMBCFM()
	{
		EJPAHEBOHII();
	}

	private void GPABCKFFLLM()
	{
		MDILKDEGCOE();
	}

	public void MBPCHHDCNNK()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void MJPBMAEKGNJ(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void BGHLAKDCMHL(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void DBFGCDIOAMA(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	private void EJPAHEBOHII()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 1; i < reskins.Length; i++)
			{
				reskins[i].EJDIKKHJOAH(birdIndex);
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

	private void LateUpdate()
	{
		PHGEBLFGPKM();
	}

	public void OMGPBJPCDJP(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void ChangeSkin(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void IPLCOANLPHJ()
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
		CDDBJOGKKIE();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void GNEPLHPJPKB()
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
		IIHOHMDMIBL();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void PHGEBLFGPKM()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(birdIndex);
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

	public void MFLLIOGFGNL()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void NPEOJEJIDHD()
	{
		GLDBPNOPMGA();
	}

	public void ChangeMaterial(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	public void BFCOBMMBHJJ(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void PPIODHAHMHD()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void MAKEINHLJHL(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
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

	public void NGJPGIHCIMK(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i++)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	public void BNMJBOKALBB()
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
		NHHILKBOMNH();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void BJGGFPLMJFK(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].DFLDFBOBGKA(DDHBCONGIPH);
		}
	}

	public void GFIOAFNILKG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void HPMCPCEEIBB()
	{
		CDDBJOGKKIE();
	}

	public void POPGIJOFAPM()
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
		FMBFGLJKCFB();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void CCKENPPLIEP(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 0; i < reskins.Length; i++)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void INIKPDJFCEO(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeMaterial(DDHBCONGIPH);
		}
	}

	private void DHNPMLNIGHM()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 0; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(birdIndex);
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

	public void GNCJEBDMLJK(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 1; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void KKFIDABIBMF(SpriteInfo OJKJDNNBJOF)
	{
		for (int i = 0; i < reskins.Length; i += 0)
		{
			reskins[i].ChangeSpriteInfo(OJKJDNNBJOF);
		}
	}

	public void FJGJMEEMENK()
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
		PJOPHPBABAI();
		for (int j = 1; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void FKFHNKLPFLL()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void CDDCLNPBLNE()
	{
		NHHILKBOMNH();
	}

	public void OGDMOIBJFKL(CharacterMaterial DDHBCONGIPH)
	{
		for (int i = 1; i < reskins.Length; i++)
		{
			reskins[i].CCJCLLGLNCL(DDHBCONGIPH);
		}
	}

	private void AOLGGDAHDMP()
	{
		GLDBPNOPMGA();
	}

	public void FGMJECNPEEF()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void GLDBPNOPMGA()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].KFHGLOFHCHH(birdIndex);
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

	public void DBPOMGIEMDJ()
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
		FMBFGLJKCFB();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private void NHHILKBOMNH()
	{
		if (birdIndex != AIIGJBGJMJK)
		{
			AIIGJBGJMJK = birdIndex;
			for (int i = 1; i < reskins.Length; i += 0)
			{
				reskins[i].UpdateSprite(birdIndex);
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
}
