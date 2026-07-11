using System.Collections;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.UI;

public class ReskinAnimation : MonoBehaviour
{
	public SpriteInfo spriteInfo;

	public CharacterMaterial characterMaterial;

	public string spriteSheetName;

	public Gender gender = Gender.Male;

	public BodyPart bodyPart;

	public bool takeDetails;

	public CharacterLayer layer;

	public bool isShadow;

	public bool getSprites2;

	[Space(20f)]
	public Image image;

	public SpriteRenderer spriteRenderer;

	public Sprite[] subSprites;

	private int MBNMPGOLGIJ;

	private Color KDEHDOHOILE;

	private bool FCFOOMAJCBD;

	[SerializeField]
	private bool layerExist = true;

	[SerializeField]
	private bool blockedSpriteSheet;

	public AudioObject resSfx;

	public void DFCFIDDPMAF(Color FLABEDBELMF)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)image == (Object)null && (Object)(object)spriteRenderer == (Object)null)
		{
			return;
		}
		if (!FCFOOMAJCBD)
		{
			if (Object.op_Implicit((Object)(object)image))
			{
				KDEHDOHOILE = ((Graphic)image).color;
			}
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				KDEHDOHOILE = spriteRenderer.color;
			}
		}
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.color = FLABEDBELMF;
		}
		FCFOOMAJCBD = false;
	}

	private void BNIKICAEIND()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			KDEHDOHOILE = ((Graphic)image).color;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			KDEHDOHOILE = spriteRenderer.color;
		}
		if ((Object)(object)resSfx != (Object)null && resSfx.loop)
		{
			MultiAudioManager.PlayAudioObject(resSfx, ((Component)this).transform);
		}
	}

	public void EIEFAEBCKCF()
	{
		if (Object.op_Implicit((Object)(object)image))
		{
			((Behaviour)image).enabled = !layerExist || blockedSpriteSheet || subSprites.Length != 0;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			((Renderer)spriteRenderer).enabled = !layerExist || blockedSpriteSheet || (nuint)subSprites.LongLength > 1;
		}
	}

	public void ForceValidMaterial()
	{
		if ((Object)(object)spriteInfo != (Object)null && spriteInfo is CharacterSprite characterSprite && Object.op_Implicit((Object)(object)characterSprite))
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer == layer)
				{
					characterMaterial = characterSprite.layerSettings[i].materials[0];
				}
			}
		}
		BLOMOJIAONH();
	}

	public void ChangeMaterial(CharacterMaterial DDHBCONGIPH)
	{
		if (!isShadow)
		{
			characterMaterial = DDHBCONGIPH;
		}
		BLOMOJIAONH();
	}

	public void ODOJKBIDFEL()
	{
		if ((Object)(object)spriteInfo != (Object)null && spriteInfo is CharacterSprite characterSprite && Object.op_Implicit((Object)(object)characterSprite))
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer == layer)
				{
					characterMaterial = characterSprite.layerSettings[i].materials[1];
				}
			}
		}
		DDAGOPGGKFG();
	}

	public void ResetLayerExistAndBlockedSpriteSheet()
	{
		if (!layerExist)
		{
			layerExist = true;
		}
		if (blockedSpriteSheet)
		{
			blockedSpriteSheet = false;
		}
	}

	public void ResetColor()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (FCFOOMAJCBD)
		{
			if (Object.op_Implicit((Object)(object)image))
			{
				((Graphic)image).color = KDEHDOHOILE;
			}
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				spriteRenderer.color = KDEHDOHOILE;
			}
		}
	}

	public void UpdateSkin()
	{
		if ((Object)(object)image == (Object)null)
		{
			image = ((Component)this).GetComponent<Image>();
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if (!layerExist)
		{
			layerExist = true;
		}
		if (blockedSpriteSheet)
		{
			blockedSpriteSheet = false;
		}
		CharacterChanged();
		BLOMOJIAONH();
	}

	private void NMKGOAJLMDG()
	{
		if (!((Object)(object)image != (Object)null) && !((Object)(object)spriteRenderer != (Object)null))
		{
			if ((Object)(object)image == (Object)null)
			{
				image = ((Component)this).GetComponent<Image>();
			}
			if ((Object)(object)spriteRenderer == (Object)null)
			{
				spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
			}
		}
	}

	public void NBMDFJEPAGO(SpriteInfo OJKJDNNBJOF, Gender HNLNENELPKI)
	{
		gender = HNLNENELPKI;
		spriteInfo = OJKJDNNBJOF;
		DKHMBDPJLEA();
	}

	public void NLMMDAIDPHB()
	{
		if ((Object)(object)spriteInfo != (Object)null && spriteInfo is CharacterSprite characterSprite && Object.op_Implicit((Object)(object)characterSprite))
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer == layer)
				{
					characterMaterial = characterSprite.layerSettings[i].materials[1];
				}
			}
		}
		EAKPEBGIPEO();
	}

	private void NHGIAMLNAHO()
	{
		CheckIsEnable();
		if (MBNMPGOLGIJ >= subSprites.Length)
		{
			return;
		}
		if ((Object)(object)image != (Object)null)
		{
			image.sprite = subSprites[MBNMPGOLGIJ];
			if (Application.isPlaying)
			{
				((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(BNLGBCJGOEA());
			}
			else
			{
				((Graphic)image).SetNativeSize();
			}
			return;
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.sprite = subSprites[MBNMPGOLGIJ];
		}
	}

	private IEnumerator BNLGBCJGOEA()
	{
		yield return null;
		((Graphic)image).SetNativeSize();
	}

	public void LHMBKMGCCML(Color FLABEDBELMF)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)image == (Object)null && (Object)(object)spriteRenderer == (Object)null)
		{
			return;
		}
		if (!FCFOOMAJCBD)
		{
			if (Object.op_Implicit((Object)(object)image))
			{
				KDEHDOHOILE = ((Graphic)image).color;
			}
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				KDEHDOHOILE = spriteRenderer.color;
			}
		}
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.color = FLABEDBELMF;
		}
		FCFOOMAJCBD = false;
	}

	public void NBEEDGIPLPL()
	{
		if ((Object)(object)resSfx != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(resSfx, ((Component)this).transform);
		}
	}

	public void CheckIsEnable()
	{
		if (Object.op_Implicit((Object)(object)image))
		{
			((Behaviour)image).enabled = layerExist && !blockedSpriteSheet && subSprites.Length != 0;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			((Renderer)spriteRenderer).enabled = layerExist && !blockedSpriteSheet && subSprites.Length != 0;
		}
	}

	public void SkeletonToBird()
	{
		((Component)this).GetComponentInParent<BirdNPC>().ChangeToBird();
	}

	public void JGNIENFHENN()
	{
		((Component)this).GetComponentInParent<BirdNPC>().ChangeToBird();
	}

	public void LIENHDAOBBN(bool FFPNCNKHMCL)
	{
		layerExist = FFPNCNKHMCL;
		EIEFAEBCKCF();
	}

	public void SetBlockedSpriteSheet(bool KLMDEPBMACA)
	{
		blockedSpriteSheet = KLMDEPBMACA;
		CheckIsEnable();
	}

	public void PLANHEOIPJL()
	{
		if ((Object)(object)spriteInfo != (Object)null)
		{
			if (getSprites2)
			{
				if (!string.IsNullOrEmpty(spriteInfo.defaultSpriteSheetName2))
				{
					subSprites = spriteInfo.NIAPGNFECOO();
				}
				else
				{
					subSprites = (Sprite[])(object)new Sprite[1];
				}
			}
			else
			{
				subSprites = spriteInfo.FBDFONEDCMB(string.IsNullOrEmpty(spriteInfo.defaultSpriteSheetName) ? spriteSheetName : spriteInfo.defaultSpriteSheetName, gender);
			}
		}
		else
		{
			subSprites = (Sprite[])(object)new Sprite[0];
		}
		PIOHNLHEODH();
	}

	public void DFLDFBOBGKA(CharacterMaterial DDHBCONGIPH)
	{
		if (!isShadow)
		{
			characterMaterial = DDHBCONGIPH;
		}
		EAKPEBGIPEO();
	}

	private void PIOHNLHEODH()
	{
		CheckIsEnable();
		if (MBNMPGOLGIJ >= subSprites.Length)
		{
			return;
		}
		if ((Object)(object)image != (Object)null)
		{
			image.sprite = subSprites[MBNMPGOLGIJ];
			if (Application.isPlaying)
			{
				((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(BNLGBCJGOEA());
			}
			else
			{
				((Graphic)image).SetNativeSize();
			}
			return;
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.sprite = subSprites[MBNMPGOLGIJ];
		}
	}

	public void EJDIKKHJOAH(int MOFKEDGAOEE)
	{
		EIEFAEBCKCF();
		if ((Object)(object)image != (Object)null)
		{
			if (MOFKEDGAOEE < subSprites.Length)
			{
				image.sprite = subSprites[MOFKEDGAOEE];
			}
			((Graphic)image).SetNativeSize();
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer) && MOFKEDGAOEE < subSprites.Length)
		{
			spriteRenderer.sprite = subSprites[MOFKEDGAOEE];
		}
		MBNMPGOLGIJ = MOFKEDGAOEE;
	}

	private void JLLGMEELDNC()
	{
		if ((Object)(object)image == (Object)null && (Object)(object)spriteRenderer == (Object)null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)image))
		{
			if ((Object)(object)characterMaterial != (Object)null)
			{
				if (!((Behaviour)image).enabled)
				{
					((Behaviour)image).enabled = true;
				}
				if (takeDetails && characterMaterial is IconMaterial iconMaterial && (Object)(object)iconMaterial.detailMaterial != (Object)null)
				{
					((Renderer)spriteRenderer).material = iconMaterial.detailMaterial;
				}
				else if (characterMaterial.id == 0)
				{
					((Graphic)image).material = null;
				}
				else
				{
					((Graphic)image).material = characterMaterial.material;
				}
			}
			else if (((Behaviour)image).enabled)
			{
				((Behaviour)image).enabled = true;
			}
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			if ((Object)(object)characterMaterial != (Object)null)
			{
				if (!((Renderer)spriteRenderer).enabled)
				{
					((Renderer)spriteRenderer).enabled = false;
				}
				if (takeDetails && characterMaterial is IconMaterial iconMaterial2 && (Object)(object)iconMaterial2.detailMaterial != (Object)null)
				{
					((Renderer)spriteRenderer).material = iconMaterial2.detailMaterial;
				}
				else
				{
					((Renderer)spriteRenderer).material = characterMaterial.material;
				}
			}
			else if (((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
		}
		EIEFAEBCKCF();
	}

	public void SetLayerExist(bool FFPNCNKHMCL)
	{
		layerExist = FFPNCNKHMCL;
		CheckIsEnable();
	}

	public void GDBHGFBOJCF(SpriteInfo OJKJDNNBJOF, Gender HNLNENELPKI)
	{
		gender = HNLNENELPKI;
		spriteInfo = OJKJDNNBJOF;
		DKHMBDPJLEA();
	}

	public void PlayResSfx()
	{
		if ((Object)(object)resSfx != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(resSfx, ((Component)this).transform);
		}
	}

	public void DKHMBDPJLEA()
	{
		if ((Object)(object)spriteInfo != (Object)null)
		{
			if (getSprites2)
			{
				if (!string.IsNullOrEmpty(spriteInfo.defaultSpriteSheetName2))
				{
					subSprites = spriteInfo.JLMNOPHKOIG();
				}
				else
				{
					subSprites = (Sprite[])(object)new Sprite[1];
				}
			}
			else
			{
				subSprites = spriteInfo.MHGHDPODBJL(string.IsNullOrEmpty(spriteInfo.defaultSpriteSheetName) ? spriteSheetName : spriteInfo.defaultSpriteSheetName, gender);
			}
		}
		else
		{
			subSprites = (Sprite[])(object)new Sprite[0];
		}
		PIOHNLHEODH();
	}

	public void ChangeSpriteInfo(SpriteInfo OJKJDNNBJOF)
	{
		spriteInfo = OJKJDNNBJOF;
		CharacterChanged();
	}

	public void ChangeColor(Color FLABEDBELMF)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)image == (Object)null && (Object)(object)spriteRenderer == (Object)null)
		{
			return;
		}
		if (!FCFOOMAJCBD)
		{
			if (Object.op_Implicit((Object)(object)image))
			{
				KDEHDOHOILE = ((Graphic)image).color;
			}
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				KDEHDOHOILE = spriteRenderer.color;
			}
		}
		if (Object.op_Implicit((Object)(object)image))
		{
			((Graphic)image).color = FLABEDBELMF;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.color = FLABEDBELMF;
		}
		FCFOOMAJCBD = true;
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			KDEHDOHOILE = ((Graphic)image).color;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			KDEHDOHOILE = spriteRenderer.color;
		}
		if ((Object)(object)resSfx != (Object)null && resSfx.loop)
		{
			MultiAudioManager.PlayAudioObject(resSfx, ((Component)this).transform);
		}
	}

	public void UpdateSprite(int MOFKEDGAOEE)
	{
		CheckIsEnable();
		if ((Object)(object)image != (Object)null)
		{
			if (MOFKEDGAOEE < subSprites.Length)
			{
				image.sprite = subSprites[MOFKEDGAOEE];
			}
			((Graphic)image).SetNativeSize();
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer) && MOFKEDGAOEE < subSprites.Length)
		{
			spriteRenderer.sprite = subSprites[MOFKEDGAOEE];
		}
		MBNMPGOLGIJ = MOFKEDGAOEE;
	}

	private void EAKPEBGIPEO()
	{
		if ((Object)(object)image == (Object)null && (Object)(object)spriteRenderer == (Object)null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)image))
		{
			if ((Object)(object)characterMaterial != (Object)null)
			{
				if (!((Behaviour)image).enabled)
				{
					((Behaviour)image).enabled = false;
				}
				if (takeDetails && characterMaterial is IconMaterial iconMaterial && (Object)(object)iconMaterial.detailMaterial != (Object)null)
				{
					((Renderer)spriteRenderer).material = iconMaterial.detailMaterial;
				}
				else if (characterMaterial.id == 0)
				{
					((Graphic)image).material = null;
				}
				else
				{
					((Graphic)image).material = characterMaterial.material;
				}
			}
			else if (((Behaviour)image).enabled)
			{
				((Behaviour)image).enabled = true;
			}
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			if ((Object)(object)characterMaterial != (Object)null)
			{
				if (!((Renderer)spriteRenderer).enabled)
				{
					((Renderer)spriteRenderer).enabled = true;
				}
				if (takeDetails && characterMaterial is IconMaterial iconMaterial2 && (Object)(object)iconMaterial2.detailMaterial != (Object)null)
				{
					((Renderer)spriteRenderer).material = iconMaterial2.detailMaterial;
				}
				else
				{
					((Renderer)spriteRenderer).material = characterMaterial.material;
				}
			}
			else if (((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = false;
			}
		}
		CheckIsEnable();
	}

	private void DDAGOPGGKFG()
	{
		if ((Object)(object)image == (Object)null && (Object)(object)spriteRenderer == (Object)null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)image))
		{
			if ((Object)(object)characterMaterial != (Object)null)
			{
				if (!((Behaviour)image).enabled)
				{
					((Behaviour)image).enabled = false;
				}
				if (takeDetails && characterMaterial is IconMaterial iconMaterial && (Object)(object)iconMaterial.detailMaterial != (Object)null)
				{
					((Renderer)spriteRenderer).material = iconMaterial.detailMaterial;
				}
				else if (characterMaterial.id == 0)
				{
					((Graphic)image).material = null;
				}
				else
				{
					((Graphic)image).material = characterMaterial.material;
				}
			}
			else if (((Behaviour)image).enabled)
			{
				((Behaviour)image).enabled = false;
			}
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			if ((Object)(object)characterMaterial != (Object)null)
			{
				if (!((Renderer)spriteRenderer).enabled)
				{
					((Renderer)spriteRenderer).enabled = true;
				}
				if (takeDetails && characterMaterial is IconMaterial iconMaterial2 && (Object)(object)iconMaterial2.detailMaterial != (Object)null)
				{
					((Renderer)spriteRenderer).material = iconMaterial2.detailMaterial;
				}
				else
				{
					((Renderer)spriteRenderer).material = characterMaterial.material;
				}
			}
			else if (((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = false;
			}
		}
		CheckIsEnable();
	}

	public void IGEIEFNLFHF(bool FFPNCNKHMCL)
	{
		layerExist = FFPNCNKHMCL;
		EIEFAEBCKCF();
	}

	private void GHPFCKGMLDA()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			KDEHDOHOILE = ((Graphic)image).color;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			KDEHDOHOILE = spriteRenderer.color;
		}
		if ((Object)(object)resSfx != (Object)null && resSfx.loop)
		{
			MultiAudioManager.PlayAudioObject(resSfx, ((Component)this).transform);
		}
	}

	public void FEDNNKEHPKH(SpriteInfo OJKJDNNBJOF, Gender HNLNENELPKI)
	{
		gender = HNLNENELPKI;
		spriteInfo = OJKJDNNBJOF;
		CharacterChanged();
	}

	public void CCJCLLGLNCL(CharacterMaterial DDHBCONGIPH)
	{
		if (!isShadow)
		{
			characterMaterial = DDHBCONGIPH;
		}
		JLLGMEELDNC();
	}

	public void KNKJGFPDLBD()
	{
		if ((Object)(object)spriteInfo != (Object)null && spriteInfo is CharacterSprite characterSprite && Object.op_Implicit((Object)(object)characterSprite))
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer == layer)
				{
					characterMaterial = characterSprite.layerSettings[i].materials[0];
				}
			}
		}
		DDAGOPGGKFG();
	}

	private void BLOMOJIAONH()
	{
		if ((Object)(object)image == (Object)null && (Object)(object)spriteRenderer == (Object)null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)image))
		{
			if ((Object)(object)characterMaterial != (Object)null)
			{
				if (!((Behaviour)image).enabled)
				{
					((Behaviour)image).enabled = true;
				}
				if (takeDetails && characterMaterial is IconMaterial iconMaterial && (Object)(object)iconMaterial.detailMaterial != (Object)null)
				{
					((Renderer)spriteRenderer).material = iconMaterial.detailMaterial;
				}
				else if (characterMaterial.id == 0)
				{
					((Graphic)image).material = null;
				}
				else
				{
					((Graphic)image).material = characterMaterial.material;
				}
			}
			else if (((Behaviour)image).enabled)
			{
				((Behaviour)image).enabled = false;
			}
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			if ((Object)(object)characterMaterial != (Object)null)
			{
				if (!((Renderer)spriteRenderer).enabled)
				{
					((Renderer)spriteRenderer).enabled = true;
				}
				if (takeDetails && characterMaterial is IconMaterial iconMaterial2 && (Object)(object)iconMaterial2.detailMaterial != (Object)null)
				{
					((Renderer)spriteRenderer).material = iconMaterial2.detailMaterial;
				}
				else
				{
					((Renderer)spriteRenderer).material = characterMaterial.material;
				}
			}
			else if (((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = false;
			}
		}
		CheckIsEnable();
	}

	public void KFHGLOFHCHH(int MOFKEDGAOEE)
	{
		EIEFAEBCKCF();
		if ((Object)(object)image != (Object)null)
		{
			if (MOFKEDGAOEE < subSprites.Length)
			{
				image.sprite = subSprites[MOFKEDGAOEE];
			}
			((Graphic)image).SetNativeSize();
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer) && MOFKEDGAOEE < subSprites.Length)
		{
			spriteRenderer.sprite = subSprites[MOFKEDGAOEE];
		}
		MBNMPGOLGIJ = MOFKEDGAOEE;
	}

	private void CAOKPIIFHBJ()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)image))
		{
			KDEHDOHOILE = ((Graphic)image).color;
		}
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			KDEHDOHOILE = spriteRenderer.color;
		}
		if ((Object)(object)resSfx != (Object)null && resSfx.loop)
		{
			MultiAudioManager.PlayAudioObject(resSfx, ((Component)this).transform);
		}
	}

	private void DFBNEANNMIE()
	{
		EIEFAEBCKCF();
		if (MBNMPGOLGIJ >= subSprites.Length)
		{
			return;
		}
		if ((Object)(object)image != (Object)null)
		{
			image.sprite = subSprites[MBNMPGOLGIJ];
			if (Application.isPlaying)
			{
				((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StartCoroutine(BNLGBCJGOEA());
			}
			else
			{
				((Graphic)image).SetNativeSize();
			}
			return;
		}
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)spriteRenderer != (Object)null)
		{
			spriteRenderer.sprite = subSprites[MBNMPGOLGIJ];
		}
	}

	public void DOOMILLFJNA(SpriteInfo OJKJDNNBJOF, Gender HNLNENELPKI)
	{
		gender = HNLNENELPKI;
		spriteInfo = OJKJDNNBJOF;
		CharacterChanged();
	}

	public void CharacterChanged()
	{
		if ((Object)(object)spriteInfo != (Object)null)
		{
			if (getSprites2)
			{
				if (!string.IsNullOrEmpty(spriteInfo.defaultSpriteSheetName2))
				{
					subSprites = spriteInfo.GNAADFGKKAH();
				}
				else
				{
					subSprites = (Sprite[])(object)new Sprite[0];
				}
			}
			else
			{
				subSprites = spriteInfo.JKGFEBGDBIC(string.IsNullOrEmpty(spriteInfo.defaultSpriteSheetName) ? spriteSheetName : spriteInfo.defaultSpriteSheetName, gender);
			}
		}
		else
		{
			subSprites = (Sprite[])(object)new Sprite[0];
		}
		NHGIAMLNAHO();
	}

	public void ChangeSpriteInfo(SpriteInfo OJKJDNNBJOF, Gender HNLNENELPKI)
	{
		gender = HNLNENELPKI;
		spriteInfo = OJKJDNNBJOF;
		CharacterChanged();
	}

	private void Awake()
	{
		if (!((Object)(object)image != (Object)null) && !((Object)(object)spriteRenderer != (Object)null))
		{
			if ((Object)(object)image == (Object)null)
			{
				image = ((Component)this).GetComponent<Image>();
			}
			if ((Object)(object)spriteRenderer == (Object)null)
			{
				spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
			}
		}
	}

	public void MOGEJAPHJHM(SpriteInfo OJKJDNNBJOF, Gender HNLNENELPKI)
	{
		gender = HNLNENELPKI;
		spriteInfo = OJKJDNNBJOF;
		CharacterChanged();
	}
}
