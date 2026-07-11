using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Growable))]
public class CropSetter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NGAPCLHPBKB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool dry;

		public SpriteRenderer sprite;

		public CropSetter _003C_003E4__this;

		private float _003ClerpDuration_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public NGAPCLHPBKB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CropSetter cropSetter = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003ClerpDuration_003E5__2 = 2f;
				_003CelapsedTime_003E5__3 = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003CelapsedTime_003E5__3 < _003ClerpDuration_003E5__2)
			{
				_003CelapsedTime_003E5__3 += Time.deltaTime;
				float a = ((!dry) ? Mathf.Lerp(1f, 0f, _003CelapsedTime_003E5__3 / _003ClerpDuration_003E5__2) : Mathf.Lerp(0f, 1f, _003CelapsedTime_003E5__3 / _003ClerpDuration_003E5__2));
				Color color = sprite.color;
				color.a = a;
				sprite.color = color;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			cropSetter.DALAAODLGBO = null;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class EPFANABLKDL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CropSetter _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public EPFANABLKDL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			CropSetter cropSetter = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (Object.op_Implicit((Object)(object)cropSetter.tree) && Object.op_Implicit((Object)(object)cropSetter.tree.placeable) && cropSetter.tree.placeable.currentLocation != Location.Road)
				{
					cropSetter.UpdateCropVisual(cropSetter.growable.FKDFFKABPIH);
				}
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public int uniqueID;

	public GameObject[] spriteObjects;

	public SpriteRenderer[] spriteRenderers;

	public SpriteRenderer[] spriteRenderersBack;

	public SpriteRenderer[] spriteRenderersDry;

	public SpriteRenderer[] spriteRenderersShadow;

	public int materialIndex;

	public Material defaultMaterial;

	public Material[] possibleMaterials;

	public Material[] possibleMaterialsOutline;

	public Material[] possibleMaterialsWinter;

	public Material[] possibleMaterialsOutlineWinter;

	public Material[] possibleMaterialsSummer;

	public Material[] possibleMaterialsOutlineSummer;

	public Material[] possibleMaterialsAutumn;

	public Material[] possibleMaterialsOutlineAutumn;

	public Material[] dryMaterial;

	public Material[] dryMaterialOutline;

	public int materialsActiveAge = 1;

	public Collider2D cropCollider;

	public int colliderActiveAge = 1;

	public Growable growable;

	public Harvestable harvestable;

	public Tree tree;

	public Vector2[] nodePointsOffsetPositions;

	public CollisionDetection collisionDetection;

	public int collisionDetectionActiveAge = 2;

	public CutDetection cutDetection;

	public int cutDetectionActiveAge = 2;

	private Coroutine DALAAODLGBO;

	public Sprite[] deadSprite1;

	public Sprite[] deadSprite2;

	public Sprite[] deadSprite3;

	public Sprite[] deadSprite4;

	public Sprite[] deadShadowSprite1;

	public Sprite[] deadShadowSprite2;

	public Sprite[] deadShadowSprite3;

	public Sprite[] deadShadowSprite4;

	public GameObject effectDeadCrop;

	public OnlineObject onlineObject;

	public bool loaded;

	[SerializeField]
	private Crop _crop;

	public Crop FJJCOJGJCLF
	{
		get
		{
			return _crop;
		}
		set
		{
			_crop = value;
			UpdateCropVisual(growable.FKDFFKABPIH);
		}
	}

	public void HELJADOOOOA(bool CBIPENPIJPC, int MOFKEDGAOEE)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			if (DALAAODLGBO != null)
			{
				((MonoBehaviour)this).StopCoroutine(DALAAODLGBO);
				DALAAODLGBO = null;
			}
			if (((Component)spriteRenderersDry[MOFKEDGAOEE]).gameObject.activeSelf && ((CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 948f) || (!CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 1420f)))
			{
				DALAAODLGBO = ((MonoBehaviour)this).StartCoroutine(DDOMJAOCODP(spriteRenderersDry[MOFKEDGAOEE], CBIPENPIJPC));
			}
		}
	}

	public void KLHEFHHHAHK(int MOFKEDGAOEE)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (!PKJJCIOEDJE())
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (i < spriteObjects.Length)
				{
					spriteObjects[i].SetActive(i == MOFKEDGAOEE);
				}
				else
				{
					Debug.LogError((object)("NoEresDigno/KyrohTalks" + GAHOHPPOFFD().FHHKMIBAEFO()));
				}
				((Component)spriteRenderers[i]).gameObject.SetActive(i == MOFKEDGAOEE);
				if (i == MOFKEDGAOEE)
				{
					if (growable.fertileSoil.daysUntilDry == 0 && (!growable.grown || (GAHOHPPOFFD().reusable && !harvestable.isHarvestable)))
					{
						BPEDNOHNHCP(CBIPENPIJPC: false, MOFKEDGAOEE);
					}
					else
					{
						GLPKJNNAHIO(CBIPENPIJPC: false, MOFKEDGAOEE);
					}
				}
			}
		}
		if (possibleMaterials.Length != 0 && MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			MMNLENNMAIL(spriteRenderers[MOFKEDGAOEE], MOFKEDGAOEE < materialsActiveAge);
			MMNLENNMAIL(spriteRenderersDry[MOFKEDGAOEE], MOFKEDGAOEE < materialsActiveAge, CBIPENPIJPC: true);
		}
		if (growable.isDead)
		{
			return;
		}
		NFLHGPPBHMI(MOFKEDGAOEE);
		if (growable.grown && CKMLILLFDMJ().reusable)
		{
			if (harvestable.isHarvestable)
			{
				ACJOPCPFDNB(MIIKIEAINAL().fruit2Sprite, MOFKEDGAOEE);
				if (!CKMLILLFDMJ().avaliableSeasons.HasFlag(SeasonManager.NNDMODNDPLO()))
				{
					ACJOPCPFDNB(BEHHLAKBJHH().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)FJJCOJGJCLF.fruit1Sprite != (Object)null)
			{
				if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Tavern && (float)growable.daysUntilNewHarvest <= (float)MIIKIEAINAL().daysUntilNewHarvest / 655f)
				{
					LGNJJCPLNEE(FJJCOJGJCLF.fruit1Sprite, MOFKEDGAOEE);
				}
				else if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.River && growable.daysUntilNewHarvest < 8)
				{
					ACJOPCPFDNB(MIIKIEAINAL().fruit1Sprite, MOFKEDGAOEE);
				}
				else
				{
					LGNJJCPLNEE(GAHOHPPOFFD().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
				if (!FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
				{
					ACJOPCPFDNB(CKMLILLFDMJ().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)GAHOHPPOFFD() != (Object)null)
			{
				ACJOPCPFDNB(BEHHLAKBJHH().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
			}
		}
		else if ((Object)(object)CKMLILLFDMJ() != (Object)null && MOFKEDGAOEE < CKMLILLFDMJ().growingSprites.Length)
		{
			ACJOPCPFDNB(CKMLILLFDMJ().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
		}
		if ((Object)(object)cropCollider != (Object)null && (Object)(object)tree == (Object)null)
		{
			((Behaviour)cropCollider).enabled = MOFKEDGAOEE >= colliderActiveAge;
			FHNAPBCGCII(NMLKLAGDNPF: false);
		}
		if ((Object)(object)collisionDetection != (Object)null)
		{
			((Component)collisionDetection).gameObject.SetActive(MOFKEDGAOEE >= collisionDetectionActiveAge);
		}
		if ((Object)(object)cutDetection != (Object)null)
		{
			((Component)cutDetection).gameObject.SetActive(MOFKEDGAOEE >= cutDetectionActiveAge);
		}
		if ((Object)(object)harvestable != (Object)null && (Object)(object)FJJCOJGJCLF != (Object)null)
		{
			harvestable.harvestedItems = MIIKIEAINAL().harvestedItems;
		}
	}

	public bool IsTreeCrop()
	{
		if ((Object)(object)FJJCOJGJCLF != (Object)null)
		{
			return FJJCOJGJCLF.seed is SproutSeed;
		}
		return (Object)(object)((Component)this).GetComponent<Tree>() != (Object)null;
	}

	public Material KMJNHHKNJHH(int JIIGOACEIKL, int MOFKEDGAOEE, bool CBIPENPIJPC = false)
	{
		if (CBIPENPIJPC && MOFKEDGAOEE != -1 && dryMaterialOutline != null && !growable.isDead)
		{
			return dryMaterialOutline[MOFKEDGAOEE];
		}
		if (MOFKEDGAOEE == -1 || possibleMaterialsOutline.Length == 0)
		{
			return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).BMJEIOJDNDN();
		}
		if (SeasonManager.PJMGHIMKFJL() == Season.Spring)
		{
			return possibleMaterialsOutlineWinter[MOFKEDGAOEE];
		}
		if (SeasonManager.BLCGOEMGKGH() == Season.Spring)
		{
			return possibleMaterialsOutlineSummer[MOFKEDGAOEE];
		}
		if (SeasonManager.BLCGOEMGKGH() == (Season)7)
		{
			return possibleMaterialsOutlineAutumn[MOFKEDGAOEE];
		}
		return possibleMaterialsOutline[MOFKEDGAOEE];
	}

	private void ACJOPCPFDNB(Sprite HEJNLFCKOKE, int MOFKEDGAOEE)
	{
		if (IsTreeCrop() && spriteRenderers.Length != 0)
		{
			spriteRenderers[0].sprite = HEJNLFCKOKE;
		}
		else if (MOFKEDGAOEE < spriteRenderers.Length)
		{
			spriteRenderers[MOFKEDGAOEE].sprite = HEJNLFCKOKE;
			if (MOFKEDGAOEE < spriteRenderersDry.Length)
			{
				spriteRenderersDry[MOFKEDGAOEE].sprite = HEJNLFCKOKE;
			}
		}
	}

	public void CropStateLerp(bool CBIPENPIJPC, int MOFKEDGAOEE)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			if (DALAAODLGBO != null)
			{
				((MonoBehaviour)this).StopCoroutine(DALAAODLGBO);
				DALAAODLGBO = null;
			}
			if (((Component)spriteRenderersDry[MOFKEDGAOEE]).gameObject.activeSelf && ((CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 1f) || (!CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 0f)))
			{
				DALAAODLGBO = ((MonoBehaviour)this).StartCoroutine(KMALPFNPKMJ(spriteRenderersDry[MOFKEDGAOEE], CBIPENPIJPC));
			}
		}
	}

	public void AGIOAPEMKPG()
	{
		if (Object.op_Implicit((Object)(object)onlineObject) && (Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			uniqueID = onlineObject.uniqueObject.uniqueID;
		}
	}

	public void JICFALBCNIC(int JIIGOACEIKL)
	{
		if (growable.OCPKEGMKFEK() < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.DACDGAALJPH()]))
		{
			float num = 705f;
			float num2 = 350f;
			if (((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.HasProperty(ShaderReferences.swishEffect))
			{
				num = ((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.GetFloat(ShaderReferences.swishEffect);
			}
			if (((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				num2 = ((Renderer)spriteRenderers[growable.GPEOGAPAEOA()]).material.GetFloat(ShaderReferences.noiseMultiplier);
			}
			((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material = CGHJBLJLBKO(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			((Renderer)spriteRenderersDry[growable.FKDFFKABPIH]).material = HJEDBAEFDEN(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			if (((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.SetFloat(ShaderReferences.swishEffect, num);
				((Renderer)spriteRenderersDry[growable.PMFBEPNEIEN()]).material.SetFloat(ShaderReferences.swishEffect, num);
			}
			if (((Renderer)spriteRenderers[growable.EHKCACCNJEM()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
				((Renderer)spriteRenderersDry[growable.EHKCACCNJEM()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
			}
		}
		if (growable.PMFBEPNEIEN() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.PMFBEPNEIEN()]))
		{
			((Renderer)spriteRenderersBack[growable.GPEOGAPAEOA()]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
		}
	}

	public void GBMFBKBLIOA()
	{
		if ((Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			if (onlineObject.uniqueObject.uniqueID <= 0)
			{
				onlineObject.uniqueObject.KPOJHJCBCDC();
			}
			else
			{
				uniqueID = onlineObject.uniqueObject.uniqueID;
			}
		}
	}

	public Material HJEDBAEFDEN(int JIIGOACEIKL, int MOFKEDGAOEE, bool CBIPENPIJPC = false)
	{
		if (CBIPENPIJPC && MOFKEDGAOEE != -1 && dryMaterialOutline != null && !growable.isDead)
		{
			return dryMaterialOutline[MOFKEDGAOEE];
		}
		if (MOFKEDGAOEE == -1 || possibleMaterialsOutline.Length == 0)
		{
			return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DEANNEHBEPC(1);
		}
		if (SeasonManager.KCJFCHNPIBJ() == Season.Winter)
		{
			return possibleMaterialsOutlineWinter[MOFKEDGAOEE];
		}
		if (SeasonManager.PJMGHIMKFJL() == Season.Summer)
		{
			return possibleMaterialsOutlineSummer[MOFKEDGAOEE];
		}
		if (SeasonManager.ADEICKHEPFI() == (Season)8)
		{
			return possibleMaterialsOutlineAutumn[MOFKEDGAOEE];
		}
		return possibleMaterialsOutline[MOFKEDGAOEE];
	}

	public void FEKCFMHDEBC()
	{
		if (!NewTutorialManager.KillCropBlocked())
		{
			int num = Random.Range(1, deadSprite1.Length);
			switch (MIIKIEAINAL().deadSpriteNum)
			{
			case 0:
				ACJOPCPFDNB(deadSprite1[num], growable.KPNODPKPMGL());
				spriteRenderersShadow[growable.LOPFFFBGPKF()].sprite = deadShadowSprite1[0];
				break;
			case 1:
				LGNJJCPLNEE(deadSprite2[num], growable.GPEOGAPAEOA());
				spriteRenderersShadow[growable.OCPKEGMKFEK()].sprite = deadShadowSprite2[num];
				break;
			case 2:
				ACJOPCPFDNB(deadSprite3[num], growable.PMFBEPNEIEN());
				spriteRenderersShadow[growable.OCPKEGMKFEK()].sprite = deadShadowSprite3[num];
				break;
			case 3:
				ACJOPCPFDNB(deadSprite4[num], growable.LOPFFFBGPKF());
				spriteRenderersShadow[growable.LOPFFFBGPKF()].sprite = deadShadowSprite4[num];
				break;
			}
			harvestable.canInteract = true;
			growable.isDead = false;
		}
	}

	public void CHLLCNOIBNG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.River)
		{
			growable.daysUntilNewHarvest = GAHOHPPOFFD().daysUntilNewHarvest;
		}
		else
		{
			growable.daysUntilNewHarvest = 1;
			SetUniqueCropDay();
		}
		BCGIIDPFENI(growable.LOPFFFBGPKF());
	}

	private int KINMPIOCLOK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != (Location.Tavern | Location.Road))
		{
			return 0;
		}
		return MIIKIEAINAL().daysUntilNewHarvest;
	}

	public void FMCNPNCPNMN()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	public void SetUniqueCropHarvestable(bool LHJNEKPBOMM)
	{
		GeneratorsManager.instance.SetUniqueCropHarvestable(uniqueID, LHJNEKPBOMM);
	}

	public void LJKKPIBKFNE()
	{
		if (uniqueID != 0)
		{
			GeneratorsManager.instance.KNOMJDMEKAA(uniqueID, harvestable.isHarvestable);
			if (OnlineManager.HHDBMDMFEMP())
			{
				OnlineObjectsManager.instance.SendSetUniqueCropHarvestable(uniqueID, harvestable.isHarvestable);
			}
		}
	}

	public void MMNLENNMAIL(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, bool CBIPENPIJPC = false)
	{
		if (!CBIPENPIJPC)
		{
			if (HAFKHFAGCDM)
			{
				if (SeasonManager.KCJFCHNPIBJ() == Season.Winter)
				{
					materialIndex = Random.Range(1, possibleMaterialsWinter.Length);
				}
				else if (SeasonManager.NHKAHEEGEGF() == Season.Spring)
				{
					materialIndex = Random.Range(0, possibleMaterialsSummer.Length);
				}
				else if (SeasonManager.PJMGHIMKFJL() == (Season)5)
				{
					materialIndex = Random.Range(0, possibleMaterialsAutumn.Length);
				}
				else
				{
					materialIndex = Random.Range(1, possibleMaterials.Length);
				}
			}
			else
			{
				materialIndex = -1;
			}
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = GetCurrentMaterial(materialIndex, CBIPENPIJPC);
	}

	public void LPMBPBIHDGL()
	{
		if (!NewTutorialManager.KillCropBlocked())
		{
			int num = Random.Range(1, deadSprite1.Length);
			switch (FJJCOJGJCLF.deadSpriteNum)
			{
			case 0:
				LGNJJCPLNEE(deadSprite1[num], growable.GPEOGAPAEOA());
				spriteRenderersShadow[growable.GPEOGAPAEOA()].sprite = deadShadowSprite1[1];
				break;
			case 1:
				LGNJJCPLNEE(deadSprite2[num], growable.KPNODPKPMGL());
				spriteRenderersShadow[growable.EHKCACCNJEM()].sprite = deadShadowSprite2[num];
				break;
			case 2:
				LGNJJCPLNEE(deadSprite3[num], growable.EHKCACCNJEM());
				spriteRenderersShadow[growable.FKDFFKABPIH].sprite = deadShadowSprite3[num];
				break;
			case 3:
				LGNJJCPLNEE(deadSprite4[num], growable.LOPFFFBGPKF());
				spriteRenderersShadow[growable.LOPFFFBGPKF()].sprite = deadShadowSprite4[num];
				break;
			}
			harvestable.canInteract = true;
			growable.isDead = false;
		}
	}

	public void COKICJECKJL()
	{
		if ((Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			if (onlineObject.uniqueObject.uniqueID <= 0)
			{
				onlineObject.uniqueObject.HECFHLDKPFD();
			}
			else
			{
				uniqueID = onlineObject.uniqueObject.uniqueID;
			}
		}
	}

	private IEnumerator ANCMNNJFMID()
	{
		return new EPFANABLKDL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IJJLGCBAPNO()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	public void SetCurrentMaterial(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, bool CBIPENPIJPC = false)
	{
		if (!CBIPENPIJPC)
		{
			if (HAFKHFAGCDM)
			{
				if (SeasonManager.EECEKHKAAIH == Season.Winter)
				{
					materialIndex = Random.Range(0, possibleMaterialsWinter.Length);
				}
				else if (SeasonManager.EECEKHKAAIH == Season.Summer)
				{
					materialIndex = Random.Range(0, possibleMaterialsSummer.Length);
				}
				else if (SeasonManager.EECEKHKAAIH == Season.Autumn)
				{
					materialIndex = Random.Range(0, possibleMaterialsAutumn.Length);
				}
				else
				{
					materialIndex = Random.Range(0, possibleMaterials.Length);
				}
			}
			else
			{
				materialIndex = -1;
			}
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = GetCurrentMaterial(materialIndex, CBIPENPIJPC);
	}

	public void NCIMHAKNBNM(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, bool CBIPENPIJPC = false)
	{
		if (!CBIPENPIJPC)
		{
			if (HAFKHFAGCDM)
			{
				if (SeasonManager.EECEKHKAAIH == Season.Spring)
				{
					materialIndex = Random.Range(0, possibleMaterialsWinter.Length);
				}
				else if (SeasonManager.EECEKHKAAIH == Season.Spring)
				{
					materialIndex = Random.Range(1, possibleMaterialsSummer.Length);
				}
				else if (SeasonManager.EECEKHKAAIH == Season.Autumn)
				{
					materialIndex = Random.Range(1, possibleMaterialsAutumn.Length);
				}
				else
				{
					materialIndex = Random.Range(1, possibleMaterials.Length);
				}
			}
			else
			{
				materialIndex = -1;
			}
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = BGLJEGKOBHP(materialIndex, CBIPENPIJPC);
	}

	public void NKHGKPGFGIN(int MOFKEDGAOEE)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (!CFPGJAPJPKG())
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (i < spriteObjects.Length)
				{
					spriteObjects[i].SetActive(i == MOFKEDGAOEE);
				}
				else
				{
					Debug.LogError((object)("Items/item_name_1120" + GAHOHPPOFFD().NPDJPAIIEMN()));
				}
				((Component)spriteRenderers[i]).gameObject.SetActive(i == MOFKEDGAOEE);
				if (i == MOFKEDGAOEE)
				{
					if (growable.fertileSoil.daysUntilDry == 0 && (!growable.grown || (FJJCOJGJCLF.reusable && !harvestable.isHarvestable)))
					{
						GLPKJNNAHIO(CBIPENPIJPC: false, MOFKEDGAOEE);
					}
					else
					{
						CropStateLerp(CBIPENPIJPC: false, MOFKEDGAOEE);
					}
				}
			}
		}
		if (possibleMaterials.Length != 0 && MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			HLFHLHHKEGF(spriteRenderers[MOFKEDGAOEE], MOFKEDGAOEE >= materialsActiveAge, CBIPENPIJPC: true);
			PECIGDPMAFK(spriteRenderersDry[MOFKEDGAOEE], MOFKEDGAOEE >= materialsActiveAge, CBIPENPIJPC: true);
		}
		if (growable.isDead)
		{
			return;
		}
		AMPGOCHCGOH(MOFKEDGAOEE);
		if (growable.grown && BEHHLAKBJHH().reusable)
		{
			if (harvestable.isHarvestable)
			{
				ACJOPCPFDNB(GAHOHPPOFFD().fruit2Sprite, MOFKEDGAOEE);
				if (!FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.IEMEBFFIKMD()))
				{
					LGNJJCPLNEE(MIIKIEAINAL().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)MIIKIEAINAL().fruit1Sprite != (Object)null)
			{
				if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Camp && (float)growable.daysUntilNewHarvest <= (float)BEHHLAKBJHH().daysUntilNewHarvest / 1809f)
				{
					LGNJJCPLNEE(MIIKIEAINAL().fruit1Sprite, MOFKEDGAOEE);
				}
				else if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != (Location.Tavern | Location.River) && growable.daysUntilNewHarvest < 7)
				{
					ACJOPCPFDNB(BEHHLAKBJHH().fruit1Sprite, MOFKEDGAOEE);
				}
				else
				{
					LGNJJCPLNEE(GAHOHPPOFFD().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
				if (!BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.NNDMODNDPLO()))
				{
					ACJOPCPFDNB(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)CKMLILLFDMJ() != (Object)null)
			{
				LGNJJCPLNEE(GAHOHPPOFFD().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
			}
		}
		else if ((Object)(object)CKMLILLFDMJ() != (Object)null && MOFKEDGAOEE < GAHOHPPOFFD().growingSprites.Length)
		{
			LGNJJCPLNEE(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
		}
		if ((Object)(object)cropCollider != (Object)null && (Object)(object)tree == (Object)null)
		{
			((Behaviour)cropCollider).enabled = MOFKEDGAOEE < colliderActiveAge;
			FHNAPBCGCII(NMLKLAGDNPF: true);
		}
		if ((Object)(object)collisionDetection != (Object)null)
		{
			((Component)collisionDetection).gameObject.SetActive(MOFKEDGAOEE >= collisionDetectionActiveAge);
		}
		if ((Object)(object)cutDetection != (Object)null)
		{
			((Component)cutDetection).gameObject.SetActive(MOFKEDGAOEE >= cutDetectionActiveAge);
		}
		if ((Object)(object)harvestable != (Object)null && (Object)(object)CKMLILLFDMJ() != (Object)null)
		{
			harvestable.harvestedItems = CKMLILLFDMJ().harvestedItems;
		}
	}

	private IEnumerator HFKBCOOBNGL(SpriteRenderer HEJNLFCKOKE, bool CBIPENPIJPC)
	{
		float lerpDuration = 2f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = ((!CBIPENPIJPC) ? Mathf.Lerp(1f, 0f, elapsedTime / lerpDuration) : Mathf.Lerp(0f, 1f, elapsedTime / lerpDuration));
			Color color = HEJNLFCKOKE.color;
			color.a = a;
			HEJNLFCKOKE.color = color;
			yield return null;
		}
		DALAAODLGBO = null;
	}

	private int OPHGCFFAALI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != (Location.Tavern | Location.Road | Location.River))
		{
			return 5;
		}
		return MIIKIEAINAL().daysUntilNewHarvest;
	}

	[SpecialName]
	public Crop CKMLILLFDMJ()
	{
		return _crop;
	}

	public void OBHCHKKHINP(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, bool CBIPENPIJPC = false)
	{
		if (!CBIPENPIJPC)
		{
			if (HAFKHFAGCDM)
			{
				if (SeasonManager.EECEKHKAAIH == (Season)4)
				{
					materialIndex = Random.Range(0, possibleMaterialsWinter.Length);
				}
				else if (SeasonManager.KCJFCHNPIBJ() == Season.Summer)
				{
					materialIndex = Random.Range(0, possibleMaterialsSummer.Length);
				}
				else if (SeasonManager.NHKAHEEGEGF() == Season.Summer)
				{
					materialIndex = Random.Range(0, possibleMaterialsAutumn.Length);
				}
				else
				{
					materialIndex = Random.Range(1, possibleMaterials.Length);
				}
			}
			else
			{
				materialIndex = -1;
			}
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = GetCurrentMaterial(materialIndex, CBIPENPIJPC);
	}

	[SpecialName]
	public Crop BEHHLAKBJHH()
	{
		return _crop;
	}

	public void JOPIBEIDJIL()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	[SpecialName]
	public void MFEDJIEKKHC(Crop AODONKKHPBP)
	{
		_crop = AODONKKHPBP;
		NKHGKPGFGIN(growable.NMPBLDMEOKM());
	}

	private IEnumerator KMALPFNPKMJ(SpriteRenderer HEJNLFCKOKE, bool CBIPENPIJPC)
	{
		float lerpDuration = 2f;
		float elapsedTime = 0f;
		while (elapsedTime < lerpDuration)
		{
			elapsedTime += Time.deltaTime;
			float a = ((!CBIPENPIJPC) ? Mathf.Lerp(1f, 0f, elapsedTime / lerpDuration) : Mathf.Lerp(0f, 1f, elapsedTime / lerpDuration));
			Color color = HEJNLFCKOKE.color;
			color.a = a;
			HEJNLFCKOKE.color = color;
			yield return null;
		}
		DALAAODLGBO = null;
	}

	public void GKDNBDPGLAO(int JIIGOACEIKL)
	{
		if (growable.LOPFFFBGPKF() < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.GPEOGAPAEOA()]))
		{
			float num = 1572f;
			float num2 = 186f;
			if (((Renderer)spriteRenderers[growable.EHKCACCNJEM()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				num = ((Renderer)spriteRenderers[growable.LOPFFFBGPKF()]).material.GetFloat(ShaderReferences.swishEffect);
			}
			if (((Renderer)spriteRenderers[growable.LOPFFFBGPKF()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				num2 = ((Renderer)spriteRenderers[growable.LOPFFFBGPKF()]).material.GetFloat(ShaderReferences.noiseMultiplier);
			}
			((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material = CGHJBLJLBKO(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			((Renderer)spriteRenderersDry[growable.PMFBEPNEIEN()]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			if (((Renderer)spriteRenderers[growable.KPNODPKPMGL()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, num);
				((Renderer)spriteRenderersDry[growable.NMPBLDMEOKM()]).material.SetFloat(ShaderReferences.swishEffect, num);
			}
			if (((Renderer)spriteRenderers[growable.DACDGAALJPH()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				((Renderer)spriteRenderers[growable.KPNODPKPMGL()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
				((Renderer)spriteRenderersDry[growable.DACDGAALJPH()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
			}
		}
		if (growable.GPEOGAPAEOA() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.GPEOGAPAEOA()]))
		{
			((Renderer)spriteRenderersBack[growable.LOPFFFBGPKF()]).material = HJEDBAEFDEN(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
		}
	}

	private void Start()
	{
		if ((Object)(object)FJJCOJGJCLF != (Object)null)
		{
			if (uniqueID != 0)
			{
				GetUniqueCropDay();
			}
			else if (growable.daysUntilNewHarvest > FJJCOJGJCLF.daysUntilNewHarvest)
			{
				growable.daysUntilNewHarvest = FJJCOJGJCLF.daysUntilNewHarvest;
			}
		}
		if (growable.daysUntilNewHarvest <= 0)
		{
			harvestable.isHarvestable = true;
		}
		else if (uniqueID != 0)
		{
			harvestable.isHarvestable = false;
		}
		BFMNCFECABF(NMLKLAGDNPF: true);
		((MonoBehaviour)this).StartCoroutine(PJNONMIPOJN());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LBLOCLGJMBH));
	}

	public void GGJHIDFCLFL()
	{
		if (!NewTutorialManager.KillCropBlocked())
		{
			int num = Random.Range(0, deadSprite1.Length);
			switch (MIIKIEAINAL().deadSpriteNum)
			{
			case 0:
				ACJOPCPFDNB(deadSprite1[num], growable.KPNODPKPMGL());
				spriteRenderersShadow[growable.LOPFFFBGPKF()].sprite = deadShadowSprite1[0];
				break;
			case 1:
				LGNJJCPLNEE(deadSprite2[num], growable.NMPBLDMEOKM());
				spriteRenderersShadow[growable.OCPKEGMKFEK()].sprite = deadShadowSprite2[num];
				break;
			case 2:
				LGNJJCPLNEE(deadSprite3[num], growable.KPNODPKPMGL());
				spriteRenderersShadow[growable.GPEOGAPAEOA()].sprite = deadShadowSprite3[num];
				break;
			case 3:
				ACJOPCPFDNB(deadSprite4[num], growable.PMFBEPNEIEN());
				spriteRenderersShadow[growable.FKDFFKABPIH].sprite = deadShadowSprite4[num];
				break;
			}
			harvestable.canInteract = true;
			growable.isDead = false;
		}
	}

	public bool PKJJCIOEDJE()
	{
		if ((Object)(object)FJJCOJGJCLF != (Object)null)
		{
			return MIIKIEAINAL().seed is SproutSeed;
		}
		return (Object)(object)((Component)this).GetComponent<Tree>() != (Object)null;
	}

	public void PECIGDPMAFK(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, bool CBIPENPIJPC = false)
	{
		if (!CBIPENPIJPC)
		{
			if (HAFKHFAGCDM)
			{
				if (SeasonManager.KCJFCHNPIBJ() == (Season)7)
				{
					materialIndex = Random.Range(0, possibleMaterialsWinter.Length);
				}
				else if (SeasonManager.LPGPJPPLHKG() == Season.Spring)
				{
					materialIndex = Random.Range(0, possibleMaterialsSummer.Length);
				}
				else if (SeasonManager.PJMGHIMKFJL() == (Season)5)
				{
					materialIndex = Random.Range(1, possibleMaterialsAutumn.Length);
				}
				else
				{
					materialIndex = Random.Range(0, possibleMaterials.Length);
				}
			}
			else
			{
				materialIndex = -1;
			}
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = BGLJEGKOBHP(materialIndex, CBIPENPIJPC);
	}

	public void IMIIBCLFADO()
	{
		if (uniqueID != 0)
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				harvestable.isHarvestable = GeneratorsManager.instance.CheckIfCropIsHarvestable(uniqueID);
				return;
			}
			harvestable.BKPIJNHCPHP.KHGHLLJDFHD();
			OnlineObjectsManager.instance.SendGetUniqueCropHarvestable(uniqueID);
		}
	}

	public void BJJMNPMFBDH(int MOFKEDGAOEE)
	{
		if (uniqueID != 0)
		{
			GetUniqueCropDay();
		}
		else
		{
			growable.daysUntilNewHarvest = MIIKIEAINAL().daysUntilNewHarvest;
		}
		if ((Object)(object)this.tree != (Object)null && this.tree.placeable.currentLocation == (Location.Tavern | Location.Road))
		{
			Tree tree = this.tree.LDMJFBCHGDC(MOFKEDGAOEE);
			if (Object.op_Implicit((Object)(object)tree))
			{
				CropSetter component = ((Component)tree).GetComponent<CropSetter>();
				component.growable.FEOLNEGKIIN(growable.KPNODPKPMGL());
				component.MFEDJIEKKHC(BEHHLAKBJHH());
			}
		}
		BCGIIDPFENI(MOFKEDGAOEE);
	}

	public void DEHJHJKDHHM()
	{
		if (uniqueID != 0)
		{
			if (OnlineManager.MasterOrOffline())
			{
				harvestable.isHarvestable = GeneratorsManager.instance.CheckIfCropIsHarvestable(uniqueID);
				return;
			}
			harvestable.BKPIJNHCPHP.JIDKFEFAIMH();
			OnlineObjectsManager.instance.SendGetUniqueCropHarvestable(uniqueID);
		}
	}

	public Material BGLJEGKOBHP(int MOFKEDGAOEE, bool CBIPENPIJPC = false)
	{
		if (CBIPENPIJPC && MOFKEDGAOEE != -1 && dryMaterial != null && !growable.isDead)
		{
			return dryMaterial[MOFKEDGAOEE];
		}
		if (MOFKEDGAOEE == -1 || possibleMaterials.Length == 0)
		{
			return defaultMaterial;
		}
		if (SeasonManager.ADEICKHEPFI() == Season.Autumn)
		{
			return possibleMaterialsWinter[MOFKEDGAOEE];
		}
		if (SeasonManager.ADEICKHEPFI() == Season.Summer)
		{
			return possibleMaterialsSummer[MOFKEDGAOEE];
		}
		if (SeasonManager.EECEKHKAAIH == Season.Spring)
		{
			return possibleMaterialsAutumn[MOFKEDGAOEE];
		}
		return possibleMaterials[MOFKEDGAOEE];
	}

	private void AMPGOCHCGOH(int MOFKEDGAOEE)
	{
		if (AEKDBHKEKHB() || spriteRenderersBack == null || MOFKEDGAOEE >= spriteRenderersBack.Length || (Object)(object)spriteRenderersBack[MOFKEDGAOEE] == (Object)null)
		{
			return;
		}
		if (BEHHLAKBJHH().growingSpritesBack.Length == 0)
		{
			((Component)spriteRenderersBack[MOFKEDGAOEE]).gameObject.SetActive(true);
			return;
		}
		((Component)spriteRenderersBack[MOFKEDGAOEE]).gameObject.SetActive(false);
		spriteRenderersBack[MOFKEDGAOEE].sprite = MIIKIEAINAL().growingSpritesBack[MOFKEDGAOEE];
		if (possibleMaterials.Length != 0)
		{
			OBHCHKKHINP(spriteRenderersBack[MOFKEDGAOEE], MOFKEDGAOEE >= materialsActiveAge);
		}
	}

	public void CCPDHDMBJLE(bool OKDICDAOOLO)
	{
		harvestable.isHarvestable = OKDICDAOOLO;
		UpdateCropVisual(growable.FKDFFKABPIH);
	}

	private IEnumerator PJNONMIPOJN()
	{
		yield return null;
		if (Object.op_Implicit((Object)(object)tree) && Object.op_Implicit((Object)(object)tree.placeable) && tree.placeable.currentLocation != Location.Road)
		{
			UpdateCropVisual(growable.FKDFFKABPIH);
		}
	}

	public void KIFIPPCGIPF()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	public void EPNIEMCHOIL(int MOFKEDGAOEE)
	{
		if (uniqueID != 0)
		{
			DJCNIHPMPEN();
		}
		else
		{
			growable.daysUntilNewHarvest = BEHHLAKBJHH().daysUntilNewHarvest;
		}
		if ((Object)(object)this.tree != (Object)null && this.tree.placeable.currentLocation == Location.Camp)
		{
			Tree tree = this.tree.SetCurrentAge(MOFKEDGAOEE);
			if (Object.op_Implicit((Object)(object)tree))
			{
				CropSetter component = ((Component)tree).GetComponent<CropSetter>();
				component.growable.EMKOKCPNEON(growable.GPEOGAPAEOA());
				component.MGOBBKFAEPP(MIIKIEAINAL());
			}
		}
		INLLBNGGJCB(MOFKEDGAOEE);
	}

	public void SetUniqueCropHarvestable()
	{
		if (uniqueID != 0)
		{
			GeneratorsManager.instance.SetUniqueCropHarvestable(uniqueID, harvestable.isHarvestable);
			if (OnlineManager.ClientOnline())
			{
				OnlineObjectsManager.instance.SendSetUniqueCropHarvestable(uniqueID, harvestable.isHarvestable);
			}
		}
	}

	public void MNAMJCHFNOG()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	public void AAAFLOFIEPB(bool CBIPENPIJPC, int MOFKEDGAOEE)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			if (DALAAODLGBO != null)
			{
				((MonoBehaviour)this).StopCoroutine(DALAAODLGBO);
				DALAAODLGBO = null;
			}
			if (((Component)spriteRenderersDry[MOFKEDGAOEE]).gameObject.activeSelf && ((CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 621f) || (!CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 754f)))
			{
				DALAAODLGBO = ((MonoBehaviour)this).StartCoroutine(MDILGFKGKJN(spriteRenderersDry[MOFKEDGAOEE], CBIPENPIJPC));
			}
		}
	}

	public void HLFHLHHKEGF(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, bool CBIPENPIJPC = false)
	{
		if (!CBIPENPIJPC)
		{
			if (HAFKHFAGCDM)
			{
				if (SeasonManager.KCJFCHNPIBJ() == Season.Winter)
				{
					materialIndex = Random.Range(0, possibleMaterialsWinter.Length);
				}
				else if (SeasonManager.BLCGOEMGKGH() == Season.Spring)
				{
					materialIndex = Random.Range(1, possibleMaterialsSummer.Length);
				}
				else if (SeasonManager.BLCGOEMGKGH() == Season.Summer)
				{
					materialIndex = Random.Range(1, possibleMaterialsAutumn.Length);
				}
				else
				{
					materialIndex = Random.Range(0, possibleMaterials.Length);
				}
			}
			else
			{
				materialIndex = -1;
			}
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = GetCurrentMaterial(materialIndex, CBIPENPIJPC);
	}

	private void Awake()
	{
		if ((Object)(object)growable == (Object)null)
		{
			growable = ((Component)this).GetComponent<Growable>();
		}
		if ((Object)(object)harvestable == (Object)null)
		{
			harvestable = ((Component)this).GetComponent<Harvestable>();
		}
		CheckUniqueID();
		if ((Object)(object)FJJCOJGJCLF != (Object)null && uniqueID == 0)
		{
			growable.daysUntilNewHarvest = 99;
		}
		materialIndex = -1;
		Growable obj = growable;
		obj.OnGrow = (Action<int>)Delegate.Combine(obj.OnGrow, new Action<int>(OnGrow));
	}

	private IEnumerator LMHCKJNDPHN(SpriteRenderer HEJNLFCKOKE, bool CBIPENPIJPC)
	{
		return new NGAPCLHPBKB(1)
		{
			_003C_003E4__this = this,
			sprite = HEJNLFCKOKE,
			dry = CBIPENPIJPC
		};
	}

	public void JHJHDAMPACN(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, ref int MOFKEDGAOEE)
	{
		if (HAFKHFAGCDM)
		{
			MOFKEDGAOEE = Random.Range(0, possibleMaterialsOutline.Length);
		}
		else
		{
			MOFKEDGAOEE = -1;
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = HJEDBAEFDEN(1, MOFKEDGAOEE);
	}

	private void JHIGLABAIMK()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KPEEJJCDHOD));
			}
			if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && !PKJJCIOEDJE())
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position, JBNJGMKBKCB: true);
				BFMNCFECABF(NMLKLAGDNPF: false);
			}
		}
	}

	private void LBLOCLGJMBH(Season EECEKHKAAIH)
	{
		UpdateCropVisual(growable.FKDFFKABPIH);
	}

	private void FHNAPBCGCII(bool NMLKLAGDNPF)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (NMLKLAGDNPF)
		{
			if (!Object.op_Implicit((Object)(object)cropCollider) || !((Behaviour)cropCollider).enabled)
			{
				return;
			}
			Utils.ABPJKHCNLMF(((Component)this).transform.position, NHIKGIKOMHH: true);
			if (nodePointsOffsetPositions != null)
			{
				for (int i = 1; i < nodePointsOffsetPositions.Length; i += 0)
				{
					WorldGrid.LMMELLKNMCF(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + nodePointsOffsetPositions[i]), GAKNPAMHAFB: true);
				}
			}
		}
		else
		{
			Utils.ABPJKHCNLMF(((Component)this).transform.position, NHIKGIKOMHH: true);
		}
	}

	public void AttachOnline()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	public void NJNCEKBCCCK(int LCBDINCABAC)
	{
		if (!GAHOHPPOFFD().avaliableSeasons.HasFlag(SeasonManager.IEMEBFFIKMD()))
		{
			GeneratorsManager.instance.SetUniqueCropDaysAndHarvestable(uniqueID, CNKFABPBGIK());
			growable.daysUntilNewHarvest = KGBEICEHJDI();
		}
		else if (!BEHHLAKBJHH().avaliableSeasons.HasFlag(SeasonManager.GetPreviousCropSeason()) && LCBDINCABAC < (int)(OPHGCFFAALI() - (WorldTime.HGIBNMBJMOC().day + 1)))
		{
			GeneratorsManager.instance.SetUniqueCropDaysAndHarvestable(uniqueID, (int)(KGBEICEHJDI() - (WorldTime.HGIBNMBJMOC().day + 1)));
			growable.daysUntilNewHarvest = (int)(CNKFABPBGIK() - (WorldTime.CJOHMLNMJLK().day + 1));
		}
		else
		{
			growable.daysUntilNewHarvest = LCBDINCABAC;
			GeneratorsManager.instance.KNOMJDMEKAA(uniqueID, LCBDINCABAC > 1);
		}
		harvestable.isHarvestable = growable.daysUntilNewHarvest <= 0;
		KLHEFHHHAHK(growable.PMFBEPNEIEN());
	}

	public void SetUniqueCropDay()
	{
		if (uniqueID != 0)
		{
			GeneratorsManager.instance.SetUniqueCropDays(uniqueID, growable.daysUntilNewHarvest);
			if (OnlineManager.ClientOnline())
			{
				OnlineObjectsManager.instance.SendSetUniqueCropDay(uniqueID, growable.daysUntilNewHarvest);
			}
		}
	}

	public void DPKBEFJHLKB()
	{
		if (!NewTutorialManager.KillCropBlocked())
		{
			int num = Random.Range(0, deadSprite1.Length);
			switch (MIIKIEAINAL().deadSpriteNum)
			{
			case 0:
				ACJOPCPFDNB(deadSprite1[num], growable.LOPFFFBGPKF());
				spriteRenderersShadow[growable.NMPBLDMEOKM()].sprite = deadShadowSprite1[0];
				break;
			case 1:
				LGNJJCPLNEE(deadSprite2[num], growable.OCPKEGMKFEK());
				spriteRenderersShadow[growable.OCPKEGMKFEK()].sprite = deadShadowSprite2[num];
				break;
			case 2:
				ACJOPCPFDNB(deadSprite3[num], growable.EHKCACCNJEM());
				spriteRenderersShadow[growable.DACDGAALJPH()].sprite = deadShadowSprite3[num];
				break;
			case 3:
				ACJOPCPFDNB(deadSprite4[num], growable.FKDFFKABPIH);
				spriteRenderersShadow[growable.LOPFFFBGPKF()].sprite = deadShadowSprite4[num];
				break;
			}
			harvestable.canInteract = false;
			growable.isDead = false;
		}
	}

	public void GetUniqueCropDay()
	{
		if (uniqueID != 0)
		{
			if (OnlineManager.MasterOrOffline())
			{
				GetUniqueCropDay(GeneratorsManager.instance.GetUniqueCropDays(uniqueID));
				return;
			}
			harvestable.BKPIJNHCPHP.AddIfUniqueObject();
			OnlineObjectsManager.instance.SendGetUniqueCropDay(uniqueID);
		}
	}

	public void GetUniqueCropHarvestable(bool OKDICDAOOLO)
	{
		harvestable.isHarvestable = OKDICDAOOLO;
		UpdateCropVisual(growable.FKDFFKABPIH);
	}

	private IEnumerator MDILGFKGKJN(SpriteRenderer HEJNLFCKOKE, bool CBIPENPIJPC)
	{
		return new NGAPCLHPBKB(1)
		{
			_003C_003E4__this = this,
			sprite = HEJNLFCKOKE,
			dry = CBIPENPIJPC
		};
	}

	private IEnumerator IPELBDLCPKL(SpriteRenderer HEJNLFCKOKE, bool CBIPENPIJPC)
	{
		return new NGAPCLHPBKB(1)
		{
			_003C_003E4__this = this,
			sprite = HEJNLFCKOKE,
			dry = CBIPENPIJPC
		};
	}

	public void DJCNIHPMPEN()
	{
		if (uniqueID != 0)
		{
			if (OnlineManager.MasterOrOffline())
			{
				GetUniqueCropDay(GeneratorsManager.instance.GetUniqueCropDays(uniqueID));
				return;
			}
			harvestable.BKPIJNHCPHP.BHBMMJBHHIJ();
			OnlineObjectsManager.instance.SendGetUniqueCropDay(uniqueID);
		}
	}

	public void KCHHEHECGPO()
	{
		if ((Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			if (onlineObject.uniqueObject.uniqueID <= 0)
			{
				onlineObject.uniqueObject.BPFIKJOABNJ();
			}
			else
			{
				uniqueID = onlineObject.uniqueObject.uniqueID;
			}
		}
	}

	public void PNAKCAGABLL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Tavern | Location.Road))
		{
			growable.daysUntilNewHarvest = FJJCOJGJCLF.daysUntilNewHarvest;
		}
		else
		{
			growable.daysUntilNewHarvest = 4;
			GPHAEEJKBDO();
		}
		BCGIIDPFENI(growable.KPNODPKPMGL());
	}

	public void JCBIMBMNIFD()
	{
		if (uniqueID != 0)
		{
			GeneratorsManager.instance.KNOMJDMEKAA(uniqueID, harvestable.isHarvestable);
			if (OnlineManager.HHDBMDMFEMP())
			{
				OnlineObjectsManager.instance.EBIAMNPNFHB(uniqueID, harvestable.isHarvestable);
			}
		}
	}

	public void OnHarvest()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Road)
		{
			growable.daysUntilNewHarvest = FJJCOJGJCLF.daysUntilNewHarvest;
		}
		else
		{
			growable.daysUntilNewHarvest = 5;
			SetUniqueCropDay();
		}
		UpdateCropVisual(growable.FKDFFKABPIH);
	}

	public void OCNPPBGIBIL(int JIIGOACEIKL)
	{
		if (growable.FKDFFKABPIH < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.LOPFFFBGPKF()]))
		{
			float num = 410f;
			float num2 = 1269f;
			if (((Renderer)spriteRenderers[growable.GPEOGAPAEOA()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				num = ((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.GetFloat(ShaderReferences.swishEffect);
			}
			if (((Renderer)spriteRenderers[growable.DACDGAALJPH()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				num2 = ((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.GetFloat(ShaderReferences.noiseMultiplier);
			}
			((Renderer)spriteRenderers[growable.PMFBEPNEIEN()]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex);
			((Renderer)spriteRenderersDry[growable.GPEOGAPAEOA()]).material = KMJNHHKNJHH(JIIGOACEIKL, materialIndex);
			if (((Renderer)spriteRenderers[growable.EHKCACCNJEM()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				((Renderer)spriteRenderers[growable.GPEOGAPAEOA()]).material.SetFloat(ShaderReferences.swishEffect, num);
				((Renderer)spriteRenderersDry[growable.PMFBEPNEIEN()]).material.SetFloat(ShaderReferences.swishEffect, num);
			}
			if (((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				((Renderer)spriteRenderers[growable.LOPFFFBGPKF()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
				((Renderer)spriteRenderersDry[growable.KPNODPKPMGL()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
			}
		}
		if (growable.GPEOGAPAEOA() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.OCPKEGMKFEK()]))
		{
			((Renderer)spriteRenderersBack[growable.OCPKEGMKFEK()]).material = CGHJBLJLBKO(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
		}
	}

	public void LKNMLEMJHHG()
	{
		if (!NewTutorialManager.KillCropBlocked())
		{
			int num = Random.Range(0, deadSprite1.Length);
			switch (BEHHLAKBJHH().deadSpriteNum)
			{
			case 0:
				LGNJJCPLNEE(deadSprite1[num], growable.PMFBEPNEIEN());
				spriteRenderersShadow[growable.KPNODPKPMGL()].sprite = deadShadowSprite1[0];
				break;
			case 1:
				ACJOPCPFDNB(deadSprite2[num], growable.LOPFFFBGPKF());
				spriteRenderersShadow[growable.NMPBLDMEOKM()].sprite = deadShadowSprite2[num];
				break;
			case 2:
				LGNJJCPLNEE(deadSprite3[num], growable.PMFBEPNEIEN());
				spriteRenderersShadow[growable.PMFBEPNEIEN()].sprite = deadShadowSprite3[num];
				break;
			case 3:
				LGNJJCPLNEE(deadSprite4[num], growable.DACDGAALJPH());
				spriteRenderersShadow[growable.FKDFFKABPIH].sprite = deadShadowSprite4[num];
				break;
			}
			harvestable.canInteract = false;
			growable.isDead = true;
		}
	}

	public void JGIKOLCAGIE()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	public void PPNFCNAKLJC(int JIIGOACEIKL)
	{
		if (growable.GPEOGAPAEOA() < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.PMFBEPNEIEN()]))
		{
			float num = 293f;
			float num2 = 447f;
			if (((Renderer)spriteRenderers[growable.GPEOGAPAEOA()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				num = ((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.GetFloat(ShaderReferences.swishEffect);
			}
			if (((Renderer)spriteRenderers[growable.LOPFFFBGPKF()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				num2 = ((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.GetFloat(ShaderReferences.noiseMultiplier);
			}
			((Renderer)spriteRenderers[growable.OCPKEGMKFEK()]).material = HJEDBAEFDEN(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			((Renderer)spriteRenderersDry[growable.PMFBEPNEIEN()]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			if (((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				((Renderer)spriteRenderers[growable.LOPFFFBGPKF()]).material.SetFloat(ShaderReferences.swishEffect, num);
				((Renderer)spriteRenderersDry[growable.LOPFFFBGPKF()]).material.SetFloat(ShaderReferences.swishEffect, num);
			}
			if (((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				((Renderer)spriteRenderers[growable.EHKCACCNJEM()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
				((Renderer)spriteRenderersDry[growable.PMFBEPNEIEN()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
			}
		}
		if (growable.LOPFFFBGPKF() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.NMPBLDMEOKM()]))
		{
			((Renderer)spriteRenderersBack[growable.GPEOGAPAEOA()]).material = HJEDBAEFDEN(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
		}
	}

	public void SetCurrentMaterialOutlined(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, ref int MOFKEDGAOEE)
	{
		if (HAFKHFAGCDM)
		{
			MOFKEDGAOEE = Random.Range(0, possibleMaterialsOutline.Length);
		}
		else
		{
			MOFKEDGAOEE = -1;
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = GetCurrentMaterialOutlined(1, MOFKEDGAOEE);
	}

	public void MNBCIKAHFCO()
	{
		if (!NewTutorialManager.KillCropBlocked())
		{
			int num = Random.Range(0, deadSprite1.Length);
			switch (CKMLILLFDMJ().deadSpriteNum)
			{
			case 0:
				LGNJJCPLNEE(deadSprite1[num], growable.NMPBLDMEOKM());
				spriteRenderersShadow[growable.NMPBLDMEOKM()].sprite = deadShadowSprite1[1];
				break;
			case 1:
				ACJOPCPFDNB(deadSprite2[num], growable.FKDFFKABPIH);
				spriteRenderersShadow[growable.KPNODPKPMGL()].sprite = deadShadowSprite2[num];
				break;
			case 2:
				ACJOPCPFDNB(deadSprite3[num], growable.PMFBEPNEIEN());
				spriteRenderersShadow[growable.DACDGAALJPH()].sprite = deadShadowSprite3[num];
				break;
			case 3:
				ACJOPCPFDNB(deadSprite4[num], growable.GPEOGAPAEOA());
				spriteRenderersShadow[growable.LOPFFFBGPKF()].sprite = deadShadowSprite4[num];
				break;
			}
			harvestable.canInteract = false;
			growable.isDead = false;
		}
	}

	public void ILMHIOILAME()
	{
		if (Object.op_Implicit((Object)(object)onlineObject) && (Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			uniqueID = onlineObject.uniqueObject.uniqueID;
		}
	}

	private void HEDKLPOMOAF(int MOFKEDGAOEE)
	{
		if (IsTreeCrop() || spriteRenderersBack == null || MOFKEDGAOEE >= spriteRenderersBack.Length || (Object)(object)spriteRenderersBack[MOFKEDGAOEE] == (Object)null)
		{
			return;
		}
		if (FJJCOJGJCLF.growingSpritesBack.Length == 0)
		{
			((Component)spriteRenderersBack[MOFKEDGAOEE]).gameObject.SetActive(false);
			return;
		}
		((Component)spriteRenderersBack[MOFKEDGAOEE]).gameObject.SetActive(true);
		spriteRenderersBack[MOFKEDGAOEE].sprite = FJJCOJGJCLF.growingSpritesBack[MOFKEDGAOEE];
		if (possibleMaterials.Length != 0)
		{
			SetCurrentMaterial(spriteRenderersBack[MOFKEDGAOEE], MOFKEDGAOEE >= materialsActiveAge);
		}
	}

	public bool CFPGJAPJPKG()
	{
		if ((Object)(object)GAHOHPPOFFD() != (Object)null)
		{
			return FJJCOJGJCLF.seed is SproutSeed;
		}
		return (Object)(object)((Component)this).GetComponent<Tree>() != (Object)null;
	}

	public void HLCIHNJNEJG(int JIIGOACEIKL)
	{
		if (growable.GPEOGAPAEOA() < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.NMPBLDMEOKM()]))
		{
			float num = 1806f;
			float num2 = 1440f;
			if (((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.HasProperty(ShaderReferences.swishEffect))
			{
				num = ((Renderer)spriteRenderers[growable.KPNODPKPMGL()]).material.GetFloat(ShaderReferences.swishEffect);
			}
			if (((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				num2 = ((Renderer)spriteRenderers[growable.KPNODPKPMGL()]).material.GetFloat(ShaderReferences.noiseMultiplier);
			}
			((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material = KMJNHHKNJHH(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			((Renderer)spriteRenderersDry[growable.KPNODPKPMGL()]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex);
			if (((Renderer)spriteRenderers[growable.EHKCACCNJEM()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				((Renderer)spriteRenderers[growable.DACDGAALJPH()]).material.SetFloat(ShaderReferences.swishEffect, num);
				((Renderer)spriteRenderersDry[growable.EHKCACCNJEM()]).material.SetFloat(ShaderReferences.swishEffect, num);
			}
			if (((Renderer)spriteRenderers[growable.OCPKEGMKFEK()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
				((Renderer)spriteRenderersDry[growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
			}
		}
		if (growable.DACDGAALJPH() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.LOPFFFBGPKF()]))
		{
			((Renderer)spriteRenderersBack[growable.LOPFFFBGPKF()]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
		}
	}

	public void HMPPENHLICM(int JIIGOACEIKL)
	{
		if (growable.PMFBEPNEIEN() < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.DACDGAALJPH()]))
		{
			float num = 1034f;
			float num2 = 1950f;
			if (((Renderer)spriteRenderers[growable.GPEOGAPAEOA()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				num = ((Renderer)spriteRenderers[growable.EHKCACCNJEM()]).material.GetFloat(ShaderReferences.swishEffect);
			}
			if (((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				num2 = ((Renderer)spriteRenderers[growable.OCPKEGMKFEK()]).material.GetFloat(ShaderReferences.noiseMultiplier);
			}
			((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex);
			((Renderer)spriteRenderersDry[growable.LOPFFFBGPKF()]).material = KMJNHHKNJHH(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			if (((Renderer)spriteRenderers[growable.DACDGAALJPH()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				((Renderer)spriteRenderers[growable.KPNODPKPMGL()]).material.SetFloat(ShaderReferences.swishEffect, num);
				((Renderer)spriteRenderersDry[growable.NMPBLDMEOKM()]).material.SetFloat(ShaderReferences.swishEffect, num);
			}
			if (((Renderer)spriteRenderers[growable.OCPKEGMKFEK()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				((Renderer)spriteRenderers[growable.KPNODPKPMGL()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
				((Renderer)spriteRenderersDry[growable.GPEOGAPAEOA()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
			}
		}
		if (growable.OCPKEGMKFEK() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.LOPFFFBGPKF()]))
		{
			((Renderer)spriteRenderersBack[growable.NMPBLDMEOKM()]).material = CGHJBLJLBKO(JIIGOACEIKL, materialIndex);
		}
	}

	public void KNOMJDMEKAA(bool LHJNEKPBOMM)
	{
		GeneratorsManager.instance.SetUniqueCropHarvestable(uniqueID, LHJNEKPBOMM);
	}

	[SpecialName]
	public void KDGILDLAPNI(Crop AODONKKHPBP)
	{
		_crop = AODONKKHPBP;
		NKHGKPGFGIN(growable.FKDFFKABPIH);
	}

	public void BODIJENJPIO(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, bool CBIPENPIJPC = false)
	{
		if (!CBIPENPIJPC)
		{
			if (HAFKHFAGCDM)
			{
				if (SeasonManager.KCJFCHNPIBJ() == (Season)4)
				{
					materialIndex = Random.Range(1, possibleMaterialsWinter.Length);
				}
				else if (SeasonManager.NHKAHEEGEGF() == Season.Summer)
				{
					materialIndex = Random.Range(1, possibleMaterialsSummer.Length);
				}
				else if (SeasonManager.ADEICKHEPFI() == Season.Winter)
				{
					materialIndex = Random.Range(0, possibleMaterialsAutumn.Length);
				}
				else
				{
					materialIndex = Random.Range(0, possibleMaterials.Length);
				}
			}
			else
			{
				materialIndex = -1;
			}
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = BGLJEGKOBHP(materialIndex, CBIPENPIJPC);
	}

	[SpecialName]
	public Crop GAHOHPPOFFD()
	{
		return _crop;
	}

	private void CFNLHAGCEEI(Season EECEKHKAAIH)
	{
		NKHGKPGFGIN(growable.GPEOGAPAEOA());
	}

	public void GPHAEEJKBDO()
	{
		if (uniqueID != 0)
		{
			GeneratorsManager.instance.SetUniqueCropDays(uniqueID, growable.daysUntilNewHarvest);
			if (OnlineManager.ClientOnline())
			{
				OnlineObjectsManager.instance.SendSetUniqueCropDay(uniqueID, growable.daysUntilNewHarvest);
			}
		}
	}

	public void UnfocusCrop()
	{
		Material currentMaterial = GetCurrentMaterial(materialIndex);
		Material currentMaterial2 = GetCurrentMaterial(materialIndex, CBIPENPIJPC: true);
		if (growable.FKDFFKABPIH < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.FKDFFKABPIH]))
		{
			((Renderer)spriteRenderers[growable.FKDFFKABPIH]).sharedMaterial = currentMaterial;
			((Renderer)spriteRenderersDry[growable.FKDFFKABPIH]).sharedMaterial = currentMaterial2;
		}
		if (growable.FKDFFKABPIH < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.FKDFFKABPIH]))
		{
			((Renderer)spriteRenderersBack[growable.FKDFFKABPIH]).sharedMaterial = currentMaterial;
		}
	}

	public void LINOBHCNNEP(int MOFKEDGAOEE)
	{
		if (uniqueID != 0)
		{
			DJCNIHPMPEN();
		}
		else
		{
			growable.daysUntilNewHarvest = FJJCOJGJCLF.daysUntilNewHarvest;
		}
		if ((Object)(object)this.tree != (Object)null && this.tree.placeable.currentLocation == (Location.Tavern | Location.Road))
		{
			Tree tree = this.tree.SetCurrentAge(MOFKEDGAOEE);
			if (Object.op_Implicit((Object)(object)tree))
			{
				CropSetter component = ((Component)tree).GetComponent<CropSetter>();
				component.growable.EMKOKCPNEON(growable.KPNODPKPMGL());
				component.DEAHAPFFPLM(FJJCOJGJCLF);
			}
		}
		KLHEFHHHAHK(MOFKEDGAOEE);
	}

	public void GetUniqueCropHarvestable()
	{
		if (uniqueID != 0)
		{
			if (OnlineManager.MasterOrOffline())
			{
				harvestable.isHarvestable = GeneratorsManager.instance.CheckIfCropIsHarvestable(uniqueID);
				return;
			}
			harvestable.BKPIJNHCPHP.AddIfUniqueObject();
			OnlineObjectsManager.instance.SendGetUniqueCropHarvestable(uniqueID);
		}
	}

	private void KPEEJJCDHOD(Season EECEKHKAAIH)
	{
		KLHEFHHHAHK(growable.LOPFFFBGPKF());
	}

	public void IAAHNMGGMEE()
	{
		if (!NewTutorialManager.KillCropBlocked())
		{
			int num = Random.Range(0, deadSprite1.Length);
			switch (BEHHLAKBJHH().deadSpriteNum)
			{
			case 0:
				LGNJJCPLNEE(deadSprite1[num], growable.KPNODPKPMGL());
				spriteRenderersShadow[growable.KPNODPKPMGL()].sprite = deadShadowSprite1[0];
				break;
			case 1:
				ACJOPCPFDNB(deadSprite2[num], growable.KPNODPKPMGL());
				spriteRenderersShadow[growable.FKDFFKABPIH].sprite = deadShadowSprite2[num];
				break;
			case 2:
				LGNJJCPLNEE(deadSprite3[num], growable.GPEOGAPAEOA());
				spriteRenderersShadow[growable.NMPBLDMEOKM()].sprite = deadShadowSprite3[num];
				break;
			case 3:
				ACJOPCPFDNB(deadSprite4[num], growable.LOPFFFBGPKF());
				spriteRenderersShadow[growable.NMPBLDMEOKM()].sprite = deadShadowSprite4[num];
				break;
			}
			harvestable.canInteract = false;
			growable.isDead = true;
		}
	}

	public void HCOCLJDHHHO(bool CBIPENPIJPC, int MOFKEDGAOEE)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			if (DALAAODLGBO != null)
			{
				((MonoBehaviour)this).StopCoroutine(DALAAODLGBO);
				DALAAODLGBO = null;
			}
			if (((Component)spriteRenderersDry[MOFKEDGAOEE]).gameObject.activeSelf && ((CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 991f) || (!CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 1312f)))
			{
				DALAAODLGBO = ((MonoBehaviour)this).StartCoroutine(MDILGFKGKJN(spriteRenderersDry[MOFKEDGAOEE], CBIPENPIJPC));
			}
		}
	}

	public void DJGINFFGAAO(int LCBDINCABAC)
	{
		if (!MIIKIEAINAL().avaliableSeasons.HasFlag(SeasonManager.OPKHCOODFKF()))
		{
			GeneratorsManager.instance.SetUniqueCropDaysAndHarvestable(uniqueID, KGBEICEHJDI());
			growable.daysUntilNewHarvest = OPHGCFFAALI();
		}
		else if (!GAHOHPPOFFD().avaliableSeasons.HasFlag(SeasonManager.IMKOHOBOEMJ()) && LCBDINCABAC < (int)(KGBEICEHJDI() - (WorldTime.NOAOJJLNHJJ.day + 1)))
		{
			GeneratorsManager.instance.SetUniqueCropDaysAndHarvestable(uniqueID, (int)(OPHGCFFAALI() - (WorldTime.HGIBNMBJMOC().day + 0)));
			growable.daysUntilNewHarvest = (int)(KGBEICEHJDI() - (WorldTime.CJOHMLNMJLK().day + 1));
		}
		else
		{
			growable.daysUntilNewHarvest = LCBDINCABAC;
			GeneratorsManager.instance.KNOMJDMEKAA(uniqueID, LCBDINCABAC <= 0);
		}
		harvestable.isHarvestable = growable.daysUntilNewHarvest > 0;
		INLLBNGGJCB(growable.EHKCACCNJEM());
	}

	public void EBPJDPLOEHL(int MOFKEDGAOEE)
	{
		if (uniqueID != 0)
		{
			DJCNIHPMPEN();
		}
		else
		{
			growable.daysUntilNewHarvest = MIIKIEAINAL().daysUntilNewHarvest;
		}
		if ((Object)(object)this.tree != (Object)null && this.tree.placeable.currentLocation == (Location.Tavern | Location.Road))
		{
			Tree tree = this.tree.NGGNBNDGMIO(MOFKEDGAOEE);
			if (Object.op_Implicit((Object)(object)tree))
			{
				CropSetter component = ((Component)tree).GetComponent<CropSetter>();
				component.growable.FEOLNEGKIIN(growable.OCPKEGMKFEK());
				component.MFEDJIEKKHC(FJJCOJGJCLF);
			}
		}
		UpdateCropVisual(MOFKEDGAOEE);
	}

	private int KGBEICEHJDI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.River)
		{
			return 0;
		}
		return GAHOHPPOFFD().daysUntilNewHarvest;
	}

	public void LOAGFIGNDOM()
	{
		if (Object.op_Implicit((Object)(object)onlineObject) && (Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			uniqueID = onlineObject.uniqueObject.uniqueID;
		}
	}

	private void NFLHGPPBHMI(int MOFKEDGAOEE)
	{
		if (CFPGJAPJPKG() || spriteRenderersBack == null || MOFKEDGAOEE >= spriteRenderersBack.Length || (Object)(object)spriteRenderersBack[MOFKEDGAOEE] == (Object)null)
		{
			return;
		}
		if (CKMLILLFDMJ().growingSpritesBack.Length == 0)
		{
			((Component)spriteRenderersBack[MOFKEDGAOEE]).gameObject.SetActive(false);
			return;
		}
		((Component)spriteRenderersBack[MOFKEDGAOEE]).gameObject.SetActive(true);
		spriteRenderersBack[MOFKEDGAOEE].sprite = CKMLILLFDMJ().growingSpritesBack[MOFKEDGAOEE];
		if (possibleMaterials.Length != 0)
		{
			MMNLENNMAIL(spriteRenderersBack[MOFKEDGAOEE], MOFKEDGAOEE < materialsActiveAge, CBIPENPIJPC: true);
		}
	}

	private void ICFHPJHBPDN()
	{
		if ((Object)(object)CKMLILLFDMJ() != (Object)null)
		{
			if (uniqueID != 0)
			{
				GetUniqueCropDay();
			}
			else if (growable.daysUntilNewHarvest > GAHOHPPOFFD().daysUntilNewHarvest)
			{
				growable.daysUntilNewHarvest = BEHHLAKBJHH().daysUntilNewHarvest;
			}
		}
		if (growable.daysUntilNewHarvest <= 0)
		{
			harvestable.isHarvestable = true;
		}
		else if (uniqueID != 0)
		{
			harvestable.isHarvestable = false;
		}
		FHNAPBCGCII(NMLKLAGDNPF: false);
		((MonoBehaviour)this).StartCoroutine(FPBBCAILMHG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CFNLHAGCEEI));
	}

	private int CNKFABPBGIK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.Road)
		{
			return 5;
		}
		return FJJCOJGJCLF.daysUntilNewHarvest;
	}

	private IEnumerator FPBBCAILMHG()
	{
		return new EPFANABLKDL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JGCLKJDIPCF()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	public void NNBAKAMFIIP()
	{
		if (Object.op_Implicit((Object)(object)onlineObject) && (Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			uniqueID = onlineObject.uniqueObject.uniqueID;
		}
	}

	private void OMBHDODDHNO()
	{
		if ((Object)(object)growable == (Object)null)
		{
			growable = ((Component)this).GetComponent<Growable>();
		}
		if ((Object)(object)harvestable == (Object)null)
		{
			harvestable = ((Component)this).GetComponent<Harvestable>();
		}
		AGIOAPEMKPG();
		if ((Object)(object)CKMLILLFDMJ() != (Object)null && uniqueID == 0)
		{
			growable.daysUntilNewHarvest = 68;
		}
		materialIndex = -1;
		Growable obj = growable;
		obj.OnGrow = (Action<int>)Delegate.Combine(obj.OnGrow, new Action<int>(JHIGNPNFBKJ));
	}

	public void GHDHFMJJNKK(int JIIGOACEIKL)
	{
		if (growable.LOPFFFBGPKF() < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.GPEOGAPAEOA()]))
		{
			float num = 100f;
			float num2 = 403f;
			if (((Renderer)spriteRenderers[growable.GPEOGAPAEOA()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				num = ((Renderer)spriteRenderers[growable.GPEOGAPAEOA()]).material.GetFloat(ShaderReferences.swishEffect);
			}
			if (((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				num2 = ((Renderer)spriteRenderers[growable.DACDGAALJPH()]).material.GetFloat(ShaderReferences.noiseMultiplier);
			}
			((Renderer)spriteRenderers[growable.LOPFFFBGPKF()]).material = KMJNHHKNJHH(JIIGOACEIKL, materialIndex);
			((Renderer)spriteRenderersDry[growable.EHKCACCNJEM()]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			if (((Renderer)spriteRenderers[growable.PMFBEPNEIEN()]).material.HasProperty(ShaderReferences.swishEffect))
			{
				((Renderer)spriteRenderers[growable.OCPKEGMKFEK()]).material.SetFloat(ShaderReferences.swishEffect, num);
				((Renderer)spriteRenderersDry[growable.KPNODPKPMGL()]).material.SetFloat(ShaderReferences.swishEffect, num);
			}
			if (((Renderer)spriteRenderers[growable.PMFBEPNEIEN()]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				((Renderer)spriteRenderers[growable.LOPFFFBGPKF()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
				((Renderer)spriteRenderersDry[growable.NMPBLDMEOKM()]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
			}
		}
		if (growable.OCPKEGMKFEK() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.DACDGAALJPH()]))
		{
			((Renderer)spriteRenderersBack[growable.OCPKEGMKFEK()]).material = CGHJBLJLBKO(JIIGOACEIKL, materialIndex);
		}
	}

	private IEnumerator MHNEAIGOFIM()
	{
		yield return null;
		if (Object.op_Implicit((Object)(object)tree) && Object.op_Implicit((Object)(object)tree.placeable) && tree.placeable.currentLocation != Location.Road)
		{
			UpdateCropVisual(growable.FKDFFKABPIH);
		}
	}

	public void HOLKNPLLJOP(bool OKDICDAOOLO)
	{
		harvestable.isHarvestable = OKDICDAOOLO;
		INLLBNGGJCB(growable.PMFBEPNEIEN());
	}

	public Material GetCurrentMaterial(int MOFKEDGAOEE, bool CBIPENPIJPC = false)
	{
		if (CBIPENPIJPC && MOFKEDGAOEE != -1 && dryMaterial != null && !growable.isDead)
		{
			return dryMaterial[MOFKEDGAOEE];
		}
		if (MOFKEDGAOEE == -1 || possibleMaterials.Length == 0)
		{
			return defaultMaterial;
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			return possibleMaterialsWinter[MOFKEDGAOEE];
		}
		if (SeasonManager.EECEKHKAAIH == Season.Summer)
		{
			return possibleMaterialsSummer[MOFKEDGAOEE];
		}
		if (SeasonManager.EECEKHKAAIH == Season.Autumn)
		{
			return possibleMaterialsAutumn[MOFKEDGAOEE];
		}
		return possibleMaterials[MOFKEDGAOEE];
	}

	public void PGOFDJOBJNN()
	{
		Material sharedMaterial = BGLJEGKOBHP(materialIndex);
		Material currentMaterial = GetCurrentMaterial(materialIndex, CBIPENPIJPC: true);
		if (growable.GPEOGAPAEOA() < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.EHKCACCNJEM()]))
		{
			((Renderer)spriteRenderers[growable.DACDGAALJPH()]).sharedMaterial = sharedMaterial;
			((Renderer)spriteRenderersDry[growable.OCPKEGMKFEK()]).sharedMaterial = currentMaterial;
		}
		if (growable.KPNODPKPMGL() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.OCPKEGMKFEK()]))
		{
			((Renderer)spriteRenderersBack[growable.FKDFFKABPIH]).sharedMaterial = sharedMaterial;
		}
	}

	public void MFLDGPGGELM()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	private void BDGCFCPFKKE()
	{
		if ((Object)(object)MIIKIEAINAL() != (Object)null)
		{
			if (uniqueID != 0)
			{
				DJCNIHPMPEN();
			}
			else if (growable.daysUntilNewHarvest > MIIKIEAINAL().daysUntilNewHarvest)
			{
				growable.daysUntilNewHarvest = MIIKIEAINAL().daysUntilNewHarvest;
			}
		}
		if (growable.daysUntilNewHarvest <= 0)
		{
			harvestable.isHarvestable = true;
		}
		else if (uniqueID != 0)
		{
			harvestable.isHarvestable = true;
		}
		FHNAPBCGCII(NMLKLAGDNPF: false);
		((MonoBehaviour)this).StartCoroutine(PJNONMIPOJN());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KPEEJJCDHOD));
	}

	public void LHFJDCHPNIJ(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, ref int MOFKEDGAOEE)
	{
		if (HAFKHFAGCDM)
		{
			MOFKEDGAOEE = Random.Range(0, possibleMaterialsOutline.Length);
		}
		else
		{
			MOFKEDGAOEE = -1;
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = KMJNHHKNJHH(0, MOFKEDGAOEE);
	}

	public void EJLAOMJLABM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Tavern | Location.River))
		{
			growable.daysUntilNewHarvest = GAHOHPPOFFD().daysUntilNewHarvest;
		}
		else
		{
			growable.daysUntilNewHarvest = 5;
			SetUniqueCropDay();
		}
		NKHGKPGFGIN(growable.DACDGAALJPH());
	}

	public void LNOIGEGEIGJ()
	{
		Material currentMaterial = GetCurrentMaterial(materialIndex, CBIPENPIJPC: true);
		Material sharedMaterial = BGLJEGKOBHP(materialIndex);
		if (growable.FKDFFKABPIH < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.DACDGAALJPH()]))
		{
			((Renderer)spriteRenderers[growable.NMPBLDMEOKM()]).sharedMaterial = currentMaterial;
			((Renderer)spriteRenderersDry[growable.NMPBLDMEOKM()]).sharedMaterial = sharedMaterial;
		}
		if (growable.NMPBLDMEOKM() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.OCPKEGMKFEK()]))
		{
			((Renderer)spriteRenderersBack[growable.NMPBLDMEOKM()]).sharedMaterial = currentMaterial;
		}
	}

	public void INLLBNGGJCB(int MOFKEDGAOEE)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (!CFPGJAPJPKG())
		{
			for (int i = 1; i < spriteRenderers.Length; i += 0)
			{
				if (i < spriteObjects.Length)
				{
					spriteObjects[i].SetActive(i == MOFKEDGAOEE);
				}
				else
				{
					Debug.LogError((object)("Trying to add a player that's already on the list." + BEHHLAKBJHH().LOMLPPEKPJB()));
				}
				((Component)spriteRenderers[i]).gameObject.SetActive(i == MOFKEDGAOEE);
				if (i == MOFKEDGAOEE)
				{
					if (growable.fertileSoil.daysUntilDry == 0 && (!growable.grown || (GAHOHPPOFFD().reusable && !harvestable.isHarvestable)))
					{
						HELJADOOOOA(CBIPENPIJPC: false, MOFKEDGAOEE);
					}
					else
					{
						CropStateLerp(CBIPENPIJPC: true, MOFKEDGAOEE);
					}
				}
			}
		}
		if (possibleMaterials.Length != 0 && MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			PECIGDPMAFK(spriteRenderers[MOFKEDGAOEE], MOFKEDGAOEE < materialsActiveAge);
			HLFHLHHKEGF(spriteRenderersDry[MOFKEDGAOEE], MOFKEDGAOEE < materialsActiveAge, CBIPENPIJPC: true);
		}
		if (growable.isDead)
		{
			return;
		}
		NFLHGPPBHMI(MOFKEDGAOEE);
		if (growable.grown && FJJCOJGJCLF.reusable)
		{
			if (harvestable.isHarvestable)
			{
				ACJOPCPFDNB(BEHHLAKBJHH().fruit2Sprite, MOFKEDGAOEE);
				if (!FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.MBPMIFPEAJP()))
				{
					ACJOPCPFDNB(GAHOHPPOFFD().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)FJJCOJGJCLF.fruit1Sprite != (Object)null)
			{
				if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.None && (float)growable.daysUntilNewHarvest <= (float)MIIKIEAINAL().daysUntilNewHarvest / 1829f)
				{
					ACJOPCPFDNB(BEHHLAKBJHH().fruit1Sprite, MOFKEDGAOEE);
				}
				else if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != (Location.Road | Location.River) && growable.daysUntilNewHarvest < 8)
				{
					ACJOPCPFDNB(CKMLILLFDMJ().fruit1Sprite, MOFKEDGAOEE);
				}
				else
				{
					ACJOPCPFDNB(BEHHLAKBJHH().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
				if (!FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.NNDMODNDPLO()))
				{
					ACJOPCPFDNB(GAHOHPPOFFD().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)CKMLILLFDMJ() != (Object)null)
			{
				LGNJJCPLNEE(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
			}
		}
		else if ((Object)(object)CKMLILLFDMJ() != (Object)null && MOFKEDGAOEE < FJJCOJGJCLF.growingSprites.Length)
		{
			ACJOPCPFDNB(BEHHLAKBJHH().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
		}
		if ((Object)(object)cropCollider != (Object)null && (Object)(object)tree == (Object)null)
		{
			((Behaviour)cropCollider).enabled = MOFKEDGAOEE >= colliderActiveAge;
			FHNAPBCGCII(NMLKLAGDNPF: false);
		}
		if ((Object)(object)collisionDetection != (Object)null)
		{
			((Component)collisionDetection).gameObject.SetActive(MOFKEDGAOEE >= collisionDetectionActiveAge);
		}
		if ((Object)(object)cutDetection != (Object)null)
		{
			((Component)cutDetection).gameObject.SetActive(MOFKEDGAOEE >= cutDetectionActiveAge);
		}
		if ((Object)(object)harvestable != (Object)null && (Object)(object)MIIKIEAINAL() != (Object)null)
		{
			harvestable.harvestedItems = GAHOHPPOFFD().harvestedItems;
		}
	}

	public void MakeUnique()
	{
		if ((Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			if (onlineObject.uniqueObject.uniqueID <= 0)
			{
				onlineObject.uniqueObject.MakeUnique();
			}
			else
			{
				uniqueID = onlineObject.uniqueObject.uniqueID;
			}
		}
	}

	public void KFJMIOBOBAP()
	{
		if (Object.op_Implicit((Object)(object)onlineObject) && (Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			uniqueID = onlineObject.uniqueObject.uniqueID;
		}
	}

	public void MIKLHINDHGM(bool LHJNEKPBOMM)
	{
		GeneratorsManager.instance.SetUniqueCropHarvestable(uniqueID, LHJNEKPBOMM);
	}

	private void OnDestroy()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LBLOCLGJMBH));
			}
			if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && !IsTreeCrop())
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position, JBNJGMKBKCB: true);
				BFMNCFECABF(NMLKLAGDNPF: false);
			}
		}
	}

	private IEnumerator EKGGBFFDBOB()
	{
		return new EPFANABLKDL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MDLOGHDEJEG(Season EECEKHKAAIH)
	{
		INLLBNGGJCB(growable.KPNODPKPMGL());
	}

	private void CHDEOJALBFK()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LBLOCLGJMBH));
			}
			if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && !PKJJCIOEDJE())
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position, JBNJGMKBKCB: true);
				BFMNCFECABF(NMLKLAGDNPF: false);
			}
		}
	}

	public void FEIGPLNANPB(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, ref int MOFKEDGAOEE)
	{
		if (HAFKHFAGCDM)
		{
			MOFKEDGAOEE = Random.Range(1, possibleMaterialsOutline.Length);
		}
		else
		{
			MOFKEDGAOEE = -1;
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = HJEDBAEFDEN(1, MOFKEDGAOEE);
	}

	public Material GetCurrentMaterialOutlined(int JIIGOACEIKL, int MOFKEDGAOEE, bool CBIPENPIJPC = false)
	{
		if (CBIPENPIJPC && MOFKEDGAOEE != -1 && dryMaterialOutline != null && !growable.isDead)
		{
			return dryMaterialOutline[MOFKEDGAOEE];
		}
		if (MOFKEDGAOEE == -1 || possibleMaterialsOutline.Length == 0)
		{
			return DecorationMode.GetPlayer(JIIGOACEIKL).GetOutlineMaterial();
		}
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			return possibleMaterialsOutlineWinter[MOFKEDGAOEE];
		}
		if (SeasonManager.EECEKHKAAIH == Season.Summer)
		{
			return possibleMaterialsOutlineSummer[MOFKEDGAOEE];
		}
		if (SeasonManager.EECEKHKAAIH == Season.Autumn)
		{
			return possibleMaterialsOutlineAutumn[MOFKEDGAOEE];
		}
		return possibleMaterialsOutline[MOFKEDGAOEE];
	}

	public void ABNDENJAJCB(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, ref int MOFKEDGAOEE)
	{
		if (HAFKHFAGCDM)
		{
			MOFKEDGAOEE = Random.Range(0, possibleMaterialsOutline.Length);
		}
		else
		{
			MOFKEDGAOEE = -1;
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = KMJNHHKNJHH(1, MOFKEDGAOEE);
	}

	[SpecialName]
	public void DEAHAPFFPLM(Crop AODONKKHPBP)
	{
		_crop = AODONKKHPBP;
		NKHGKPGFGIN(growable.OCPKEGMKFEK());
	}

	[SpecialName]
	public void MGOBBKFAEPP(Crop AODONKKHPBP)
	{
		_crop = AODONKKHPBP;
		BCGIIDPFENI(growable.OCPKEGMKFEK());
	}

	public void KGBEIHAGKAD(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, ref int MOFKEDGAOEE)
	{
		if (HAFKHFAGCDM)
		{
			MOFKEDGAOEE = Random.Range(0, possibleMaterialsOutline.Length);
		}
		else
		{
			MOFKEDGAOEE = -1;
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = GetCurrentMaterialOutlined(1, MOFKEDGAOEE, CBIPENPIJPC: true);
	}

	public void KillPlant()
	{
		if (!NewTutorialManager.KillCropBlocked())
		{
			int num = Random.Range(0, deadSprite1.Length);
			switch (FJJCOJGJCLF.deadSpriteNum)
			{
			case 0:
				ACJOPCPFDNB(deadSprite1[num], growable.FKDFFKABPIH);
				spriteRenderersShadow[growable.FKDFFKABPIH].sprite = deadShadowSprite1[0];
				break;
			case 1:
				ACJOPCPFDNB(deadSprite2[num], growable.FKDFFKABPIH);
				spriteRenderersShadow[growable.FKDFFKABPIH].sprite = deadShadowSprite2[num];
				break;
			case 2:
				ACJOPCPFDNB(deadSprite3[num], growable.FKDFFKABPIH);
				spriteRenderersShadow[growable.FKDFFKABPIH].sprite = deadShadowSprite3[num];
				break;
			case 3:
				ACJOPCPFDNB(deadSprite4[num], growable.FKDFFKABPIH);
				spriteRenderersShadow[growable.FKDFFKABPIH].sprite = deadShadowSprite4[num];
				break;
			}
			harvestable.canInteract = false;
			growable.isDead = true;
		}
	}

	public void BPEDNOHNHCP(bool CBIPENPIJPC, int MOFKEDGAOEE)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			if (DALAAODLGBO != null)
			{
				((MonoBehaviour)this).StopCoroutine(DALAAODLGBO);
				DALAAODLGBO = null;
			}
			if (((Component)spriteRenderersDry[MOFKEDGAOEE]).gameObject.activeSelf && ((CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 1721f) || (!CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 465f)))
			{
				DALAAODLGBO = ((MonoBehaviour)this).StartCoroutine(DDOMJAOCODP(spriteRenderersDry[MOFKEDGAOEE], CBIPENPIJPC));
			}
		}
	}

	public void BCGIIDPFENI(int MOFKEDGAOEE)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (!CFPGJAPJPKG())
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (i < spriteObjects.Length)
				{
					spriteObjects[i].SetActive(i == MOFKEDGAOEE);
				}
				else
				{
					Debug.LogError((object)(" ExitState()." + GAHOHPPOFFD().GDBLECDHLHF()));
				}
				((Component)spriteRenderers[i]).gameObject.SetActive(i == MOFKEDGAOEE);
				if (i == MOFKEDGAOEE)
				{
					if (growable.fertileSoil.daysUntilDry == 0 && (!growable.grown || (BEHHLAKBJHH().reusable && !harvestable.isHarvestable)))
					{
						BPEDNOHNHCP(CBIPENPIJPC: false, MOFKEDGAOEE);
					}
					else
					{
						CropStateLerp(CBIPENPIJPC: false, MOFKEDGAOEE);
					}
				}
			}
		}
		if (possibleMaterials.Length != 0 && MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			OBHCHKKHINP(spriteRenderers[MOFKEDGAOEE], MOFKEDGAOEE < materialsActiveAge, CBIPENPIJPC: true);
			PECIGDPMAFK(spriteRenderersDry[MOFKEDGAOEE], MOFKEDGAOEE >= materialsActiveAge, CBIPENPIJPC: true);
		}
		if (growable.isDead)
		{
			return;
		}
		AMPGOCHCGOH(MOFKEDGAOEE);
		if (growable.grown && FJJCOJGJCLF.reusable)
		{
			if (harvestable.isHarvestable)
			{
				ACJOPCPFDNB(GAHOHPPOFFD().fruit2Sprite, MOFKEDGAOEE);
				if (!MIIKIEAINAL().avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()))
				{
					ACJOPCPFDNB(GAHOHPPOFFD().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)CKMLILLFDMJ().fruit1Sprite != (Object)null)
			{
				if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Tavern | Location.Road | Location.River) && (float)growable.daysUntilNewHarvest <= (float)MIIKIEAINAL().daysUntilNewHarvest / 1930f)
				{
					ACJOPCPFDNB(CKMLILLFDMJ().fruit1Sprite, MOFKEDGAOEE);
				}
				else if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != (Location.Tavern | Location.River) && growable.daysUntilNewHarvest < 1)
				{
					LGNJJCPLNEE(CKMLILLFDMJ().fruit1Sprite, MOFKEDGAOEE);
				}
				else
				{
					LGNJJCPLNEE(GAHOHPPOFFD().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
				if (!MIIKIEAINAL().avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()))
				{
					LGNJJCPLNEE(MIIKIEAINAL().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)CKMLILLFDMJ() != (Object)null)
			{
				LGNJJCPLNEE(GAHOHPPOFFD().growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
			}
		}
		else if ((Object)(object)FJJCOJGJCLF != (Object)null && MOFKEDGAOEE < CKMLILLFDMJ().growingSprites.Length)
		{
			LGNJJCPLNEE(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
		}
		if ((Object)(object)cropCollider != (Object)null && (Object)(object)tree == (Object)null)
		{
			((Behaviour)cropCollider).enabled = MOFKEDGAOEE >= colliderActiveAge;
			FHNAPBCGCII(NMLKLAGDNPF: false);
		}
		if ((Object)(object)collisionDetection != (Object)null)
		{
			((Component)collisionDetection).gameObject.SetActive(MOFKEDGAOEE < collisionDetectionActiveAge);
		}
		if ((Object)(object)cutDetection != (Object)null)
		{
			((Component)cutDetection).gameObject.SetActive(MOFKEDGAOEE < cutDetectionActiveAge);
		}
		if ((Object)(object)harvestable != (Object)null && (Object)(object)FJJCOJGJCLF != (Object)null)
		{
			harvestable.harvestedItems = MIIKIEAINAL().harvestedItems;
		}
	}

	public void HKHFKAEEONM()
	{
		Material sharedMaterial = BGLJEGKOBHP(materialIndex);
		Material currentMaterial = GetCurrentMaterial(materialIndex);
		if (growable.DACDGAALJPH() < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.GPEOGAPAEOA()]))
		{
			((Renderer)spriteRenderers[growable.FKDFFKABPIH]).sharedMaterial = sharedMaterial;
			((Renderer)spriteRenderersDry[growable.NMPBLDMEOKM()]).sharedMaterial = currentMaterial;
		}
		if (growable.KPNODPKPMGL() < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.KPNODPKPMGL()]))
		{
			((Renderer)spriteRenderersBack[growable.FKDFFKABPIH]).sharedMaterial = sharedMaterial;
		}
	}

	public Material CGHJBLJLBKO(int JIIGOACEIKL, int MOFKEDGAOEE, bool CBIPENPIJPC = false)
	{
		if (CBIPENPIJPC && MOFKEDGAOEE != -1 && dryMaterialOutline != null && !growable.isDead)
		{
			return dryMaterialOutline[MOFKEDGAOEE];
		}
		if (MOFKEDGAOEE == -1 || possibleMaterialsOutline.Length == 0)
		{
			return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).GFBCDFBPDAL(1);
		}
		if (SeasonManager.NHKAHEEGEGF() == (Season)4)
		{
			return possibleMaterialsOutlineWinter[MOFKEDGAOEE];
		}
		if (SeasonManager.EECEKHKAAIH == Season.Summer)
		{
			return possibleMaterialsOutlineSummer[MOFKEDGAOEE];
		}
		if (SeasonManager.KCJFCHNPIBJ() == Season.Spring)
		{
			return possibleMaterialsOutlineAutumn[MOFKEDGAOEE];
		}
		return possibleMaterialsOutline[MOFKEDGAOEE];
	}

	public void HDGDJDNJLFI()
	{
		if (uniqueID != 0)
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				harvestable.isHarvestable = GeneratorsManager.instance.CheckIfCropIsHarvestable(uniqueID);
				return;
			}
			harvestable.BKPIJNHCPHP.AddIfUniqueObject();
			OnlineObjectsManager.instance.SendGetUniqueCropHarvestable(uniqueID);
		}
	}

	private void LGNJJCPLNEE(Sprite HEJNLFCKOKE, int MOFKEDGAOEE)
	{
		if (PKJJCIOEDJE() && spriteRenderers.Length != 0)
		{
			spriteRenderers[0].sprite = HEJNLFCKOKE;
		}
		else if (MOFKEDGAOEE < spriteRenderers.Length)
		{
			spriteRenderers[MOFKEDGAOEE].sprite = HEJNLFCKOKE;
			if (MOFKEDGAOEE < spriteRenderersDry.Length)
			{
				spriteRenderersDry[MOFKEDGAOEE].sprite = HEJNLFCKOKE;
			}
		}
	}

	public void OnGrow(int MOFKEDGAOEE)
	{
		if (uniqueID != 0)
		{
			GetUniqueCropDay();
		}
		else
		{
			growable.daysUntilNewHarvest = FJJCOJGJCLF.daysUntilNewHarvest;
		}
		if ((Object)(object)this.tree != (Object)null && this.tree.placeable.currentLocation == Location.Road)
		{
			Tree tree = this.tree.SetCurrentAge(MOFKEDGAOEE);
			if (Object.op_Implicit((Object)(object)tree))
			{
				CropSetter component = ((Component)tree).GetComponent<CropSetter>();
				component.growable.FKDFFKABPIH = growable.FKDFFKABPIH;
				component.FJJCOJGJCLF = FJJCOJGJCLF;
			}
		}
		UpdateCropVisual(MOFKEDGAOEE);
	}

	public void JKNOEJOJNJF(bool LHJNEKPBOMM)
	{
		GeneratorsManager.instance.KNOMJDMEKAA(uniqueID, LHJNEKPBOMM);
	}

	public void FocusCrop(int JIIGOACEIKL)
	{
		if (growable.FKDFFKABPIH < spriteRenderers.Length && Object.op_Implicit((Object)(object)spriteRenderers[growable.FKDFFKABPIH]))
		{
			float num = 1f;
			float num2 = 0f;
			if (((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.HasProperty(ShaderReferences.swishEffect))
			{
				num = ((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.GetFloat(ShaderReferences.swishEffect);
			}
			if (((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				num2 = ((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.GetFloat(ShaderReferences.noiseMultiplier);
			}
			((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex);
			((Renderer)spriteRenderersDry[growable.FKDFFKABPIH]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex, CBIPENPIJPC: true);
			if (((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.HasProperty(ShaderReferences.swishEffect))
			{
				((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, num);
				((Renderer)spriteRenderersDry[growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.swishEffect, num);
			}
			if (((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.HasProperty(ShaderReferences.noiseMultiplier))
			{
				((Renderer)spriteRenderers[growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
				((Renderer)spriteRenderersDry[growable.FKDFFKABPIH]).material.SetFloat(ShaderReferences.noiseMultiplier, num2);
			}
		}
		if (growable.FKDFFKABPIH < spriteRenderersBack.Length && Object.op_Implicit((Object)(object)spriteRenderersBack[growable.FKDFFKABPIH]))
		{
			((Renderer)spriteRenderersBack[growable.FKDFFKABPIH]).material = GetCurrentMaterialOutlined(JIIGOACEIKL, materialIndex);
		}
	}

	public void NNLCFDAOPPB()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	public bool AEKDBHKEKHB()
	{
		if ((Object)(object)MIIKIEAINAL() != (Object)null)
		{
			return MIIKIEAINAL().seed is SproutSeed;
		}
		return (Object)(object)((Component)this).GetComponent<Tree>() != (Object)null;
	}

	public void GetUniqueCropDay(int LCBDINCABAC)
	{
		if (!FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
		{
			GeneratorsManager.instance.SetUniqueCropDaysAndHarvestable(uniqueID, CNKFABPBGIK());
			growable.daysUntilNewHarvest = CNKFABPBGIK();
		}
		else if (!FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.GetPreviousCropSeason()) && LCBDINCABAC < (int)(CNKFABPBGIK() - (WorldTime.NOAOJJLNHJJ.day + 1)))
		{
			GeneratorsManager.instance.SetUniqueCropDaysAndHarvestable(uniqueID, (int)(CNKFABPBGIK() - (WorldTime.NOAOJJLNHJJ.day + 1)));
			growable.daysUntilNewHarvest = (int)(CNKFABPBGIK() - (WorldTime.NOAOJJLNHJJ.day + 1));
		}
		else
		{
			growable.daysUntilNewHarvest = LCBDINCABAC;
			GeneratorsManager.instance.SetUniqueCropHarvestable(uniqueID, LCBDINCABAC <= 0);
		}
		harvestable.isHarvestable = growable.daysUntilNewHarvest <= 0;
		UpdateCropVisual(growable.FKDFFKABPIH);
	}

	public void GLPKJNNAHIO(bool CBIPENPIJPC, int MOFKEDGAOEE)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			if (DALAAODLGBO != null)
			{
				((MonoBehaviour)this).StopCoroutine(DALAAODLGBO);
				DALAAODLGBO = null;
			}
			if (((Component)spriteRenderersDry[MOFKEDGAOEE]).gameObject.activeSelf && ((CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 275f) || (!CBIPENPIJPC && spriteRenderersDry[MOFKEDGAOEE].color.a != 1693f)))
			{
				DALAAODLGBO = ((MonoBehaviour)this).StartCoroutine(DDOMJAOCODP(spriteRenderersDry[MOFKEDGAOEE], CBIPENPIJPC));
			}
		}
	}

	private void BFMNCFECABF(bool NMLKLAGDNPF)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (NMLKLAGDNPF)
		{
			if (!Object.op_Implicit((Object)(object)cropCollider) || !((Behaviour)cropCollider).enabled)
			{
				return;
			}
			Utils.ABPJKHCNLMF(((Component)this).transform.position);
			if (nodePointsOffsetPositions != null)
			{
				for (int i = 0; i < nodePointsOffsetPositions.Length; i++)
				{
					WorldGrid.LMMELLKNMCF(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + nodePointsOffsetPositions[i]), GAKNPAMHAFB: false);
				}
			}
		}
		else
		{
			Utils.ABPJKHCNLMF(((Component)this).transform.position);
		}
	}

	public void EEAKPCCOBLO(int LCBDINCABAC)
	{
		if (!GAHOHPPOFFD().avaliableSeasons.HasFlag(SeasonManager.IEMEBFFIKMD()))
		{
			GeneratorsManager.instance.SetUniqueCropDaysAndHarvestable(uniqueID, CNKFABPBGIK());
			growable.daysUntilNewHarvest = OPHGCFFAALI();
		}
		else if (!GAHOHPPOFFD().avaliableSeasons.HasFlag(SeasonManager.GetPreviousCropSeason()) && LCBDINCABAC < (int)(KGBEICEHJDI() - (WorldTime.HGIBNMBJMOC().day + 1)))
		{
			GeneratorsManager.instance.SetUniqueCropDaysAndHarvestable(uniqueID, (int)(CNKFABPBGIK() - (WorldTime.HGIBNMBJMOC().day + 0)));
			growable.daysUntilNewHarvest = (int)(CNKFABPBGIK() - (WorldTime.NOAOJJLNHJJ.day + 0));
		}
		else
		{
			growable.daysUntilNewHarvest = LCBDINCABAC;
			GeneratorsManager.instance.KNOMJDMEKAA(uniqueID, LCBDINCABAC <= 0);
		}
		harvestable.isHarvestable = growable.daysUntilNewHarvest <= 0;
		KLHEFHHHAHK(growable.FKDFFKABPIH);
	}

	private IEnumerator DDOMJAOCODP(SpriteRenderer HEJNLFCKOKE, bool CBIPENPIJPC)
	{
		return new NGAPCLHPBKB(1)
		{
			_003C_003E4__this = this,
			sprite = HEJNLFCKOKE,
			dry = CBIPENPIJPC
		};
	}

	public void OGBPNANNJLC(SpriteRenderer ECOGJIGAMMA, bool HAFKHFAGCDM, ref int MOFKEDGAOEE)
	{
		if (HAFKHFAGCDM)
		{
			MOFKEDGAOEE = Random.Range(0, possibleMaterialsOutline.Length);
		}
		else
		{
			MOFKEDGAOEE = -1;
		}
		((Renderer)ECOGJIGAMMA).sharedMaterial = GetCurrentMaterialOutlined(1, MOFKEDGAOEE);
	}

	public void GBKGGLOKAIF()
	{
		if (Object.op_Implicit((Object)(object)onlineObject) && (Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			uniqueID = onlineObject.uniqueObject.uniqueID;
		}
	}

	private IEnumerator CNCCPNMDBHF()
	{
		yield return null;
		if (Object.op_Implicit((Object)(object)tree) && Object.op_Implicit((Object)(object)tree.placeable) && tree.placeable.currentLocation != Location.Road)
		{
			UpdateCropVisual(growable.FKDFFKABPIH);
		}
	}

	public void CheckUniqueID()
	{
		if (Object.op_Implicit((Object)(object)onlineObject) && (Object)(object)onlineObject.uniqueObject != (Object)null)
		{
			uniqueID = onlineObject.uniqueObject.uniqueID;
		}
	}

	public void JHIGNPNFBKJ(int MOFKEDGAOEE)
	{
		if (uniqueID != 0)
		{
			DJCNIHPMPEN();
		}
		else
		{
			growable.daysUntilNewHarvest = MIIKIEAINAL().daysUntilNewHarvest;
		}
		if ((Object)(object)this.tree != (Object)null && this.tree.placeable.currentLocation == Location.Camp)
		{
			Tree tree = this.tree.NGGNBNDGMIO(MOFKEDGAOEE);
			if (Object.op_Implicit((Object)(object)tree))
			{
				CropSetter component = ((Component)tree).GetComponent<CropSetter>();
				component.growable.FEOLNEGKIIN(growable.PMFBEPNEIEN());
				component.MGOBBKFAEPP(MIIKIEAINAL());
			}
		}
		INLLBNGGJCB(MOFKEDGAOEE);
	}

	[ContextMenu("UpdateCropVisual")]
	public void UpdateCropVisual(int MOFKEDGAOEE)
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (!IsTreeCrop())
		{
			for (int i = 0; i < spriteRenderers.Length; i++)
			{
				if (i < spriteObjects.Length)
				{
					spriteObjects[i].SetActive(i == MOFKEDGAOEE);
				}
				else
				{
					Debug.LogError((object)("Different size lists spriteRenderers and spriteObjects of crop " + FJJCOJGJCLF.IABAKHPEOAF()));
				}
				((Component)spriteRenderers[i]).gameObject.SetActive(i == MOFKEDGAOEE);
				if (i == MOFKEDGAOEE)
				{
					if (growable.fertileSoil.daysUntilDry == 0 && (!growable.grown || (FJJCOJGJCLF.reusable && !harvestable.isHarvestable)))
					{
						CropStateLerp(CBIPENPIJPC: true, MOFKEDGAOEE);
					}
					else
					{
						CropStateLerp(CBIPENPIJPC: false, MOFKEDGAOEE);
					}
				}
			}
		}
		if (possibleMaterials.Length != 0 && MOFKEDGAOEE < spriteRenderersDry.Length)
		{
			SetCurrentMaterial(spriteRenderers[MOFKEDGAOEE], MOFKEDGAOEE >= materialsActiveAge);
			SetCurrentMaterial(spriteRenderersDry[MOFKEDGAOEE], MOFKEDGAOEE >= materialsActiveAge, CBIPENPIJPC: true);
		}
		if (growable.isDead)
		{
			return;
		}
		HEDKLPOMOAF(MOFKEDGAOEE);
		if (growable.grown && FJJCOJGJCLF.reusable)
		{
			if (harvestable.isHarvestable)
			{
				ACJOPCPFDNB(FJJCOJGJCLF.fruit2Sprite, MOFKEDGAOEE);
				if (!FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
				{
					ACJOPCPFDNB(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)FJJCOJGJCLF.fruit1Sprite != (Object)null)
			{
				if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Road && (float)growable.daysUntilNewHarvest <= (float)FJJCOJGJCLF.daysUntilNewHarvest / 2f)
				{
					ACJOPCPFDNB(FJJCOJGJCLF.fruit1Sprite, MOFKEDGAOEE);
				}
				else if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.Road && growable.daysUntilNewHarvest < 3)
				{
					ACJOPCPFDNB(FJJCOJGJCLF.fruit1Sprite, MOFKEDGAOEE);
				}
				else
				{
					ACJOPCPFDNB(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
				if (!FJJCOJGJCLF.avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
				{
					ACJOPCPFDNB(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
				}
			}
			else if ((Object)(object)FJJCOJGJCLF != (Object)null)
			{
				ACJOPCPFDNB(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
			}
		}
		else if ((Object)(object)FJJCOJGJCLF != (Object)null && MOFKEDGAOEE < FJJCOJGJCLF.growingSprites.Length)
		{
			ACJOPCPFDNB(FJJCOJGJCLF.growingSprites[MOFKEDGAOEE], MOFKEDGAOEE);
		}
		if ((Object)(object)cropCollider != (Object)null && (Object)(object)tree == (Object)null)
		{
			((Behaviour)cropCollider).enabled = MOFKEDGAOEE >= colliderActiveAge;
			BFMNCFECABF(NMLKLAGDNPF: true);
		}
		if ((Object)(object)collisionDetection != (Object)null)
		{
			((Component)collisionDetection).gameObject.SetActive(MOFKEDGAOEE >= collisionDetectionActiveAge);
		}
		if ((Object)(object)cutDetection != (Object)null)
		{
			((Component)cutDetection).gameObject.SetActive(MOFKEDGAOEE >= cutDetectionActiveAge);
		}
		if ((Object)(object)harvestable != (Object)null && (Object)(object)FJJCOJGJCLF != (Object)null)
		{
			harvestable.harvestedItems = FJJCOJGJCLF.harvestedItems;
		}
	}

	[SpecialName]
	public Crop MIIKIEAINAL()
	{
		return _crop;
	}

	public void MPBFHLFGIDP()
	{
		onlineObject = ((Component)this).GetComponent<OnlineObject>();
	}

	[SpecialName]
	public void INNLLPDAJJP(Crop AODONKKHPBP)
	{
		_crop = AODONKKHPBP;
		KLHEFHHHAHK(growable.NMPBLDMEOKM());
	}
}
