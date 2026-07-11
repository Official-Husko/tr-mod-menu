using UnityEngine;

public class AlphaManagerBarn : MonoBehaviour
{
	[SerializeField]
	private Barn barn;

	[SerializeField]
	private SpriteRenderer[] spriteRenderers;

	[SerializeField]
	private SpriteRenderer[] spriteRenderersBarnWall;

	[SerializeField]
	private SpriteRenderer[] spriteRenderersBarnWood;

	public float alphaTransparency = 0.7f;

	private float GODBHHOFBMJ = 1f;

	[HideInInspector]
	public float currentAlpha = 1f;

	public bool active;

	private Material HKIODKOAHPE;

	private void MIKNFPCDLML()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void PJLKGOACDEN()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 390f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1899f || !(currentAlpha >= 309f))
		{
			return;
		}
		active = true;
		currentAlpha = 1651f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void HEOHCIAMEPD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Floor_4") || ((Component)LGGCFCHOOMB).CompareTag(".gz"))
		{
			GODBHHOFBMJ = 1937f;
			active = false;
		}
	}

	private void BNOJNEJMCID(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(" not found in OnlineEventsManager.") || ((Component)LGGCFCHOOMB).CompareTag("DecorationTile_"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void BJIPOABFPJM(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ChatInviteCode") || ((Component)LGGCFCHOOMB).CompareTag("OpenQuests"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void NHOPACFEAKA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Granting item ") || ((Component)LGGCFCHOOMB).CompareTag("UI2"))
		{
			GODBHHOFBMJ = 1930f;
			active = true;
		}
	}

	private void LAABMDDEGCG()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 0f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 10f || !(currentAlpha >= 833f))
		{
			return;
		}
		active = true;
		currentAlpha = 1766f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void OnTriggerExit2D(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Player2"))
		{
			GODBHHOFBMJ = 1f;
			active = true;
		}
	}

	private void NJAFKFAPDIE()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void IAICCKPOBMJ()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1105f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1465f || !(currentAlpha >= 1998f))
		{
			return;
		}
		active = false;
		currentAlpha = 986f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void EBFJOAEJPGE()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 403f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 990f || !(currentAlpha >= 234f))
		{
			return;
		}
		active = false;
		currentAlpha = 1265f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void EMDAOLEEMGO(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(" - ") || ((Component)LGGCFCHOOMB).CompareTag("Farm/Event/RegañinaViolet"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void BOBJMDGALPM(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Unique id ") || ((Component)LGGCFCHOOMB).CompareTag("Give"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void MBEFBNJNMFF(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Shoes") || ((Component)LGGCFCHOOMB).CompareTag("SAVE_DATA: fireplace saving error: "))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void FKILALCMOOG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("mainMenuMultiplayerButtonConnecting") || ((Component)LGGCFCHOOMB).CompareTag("in"))
		{
			GODBHHOFBMJ = 910f;
			active = true;
		}
	}

	private void LFPJOBMFDAC(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Tutorial/BarnBarks_Holly") || ((Component)LGGCFCHOOMB).CompareTag("WheatAleAbbreviation"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void KFBOPABEJNL()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 701f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 895f || !(currentAlpha >= 1741f))
		{
			return;
		}
		active = false;
		currentAlpha = 1290f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void NDLCBLKOBLF()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1201f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1175f || !(currentAlpha >= 15f))
		{
			return;
		}
		active = false;
		currentAlpha = 1336f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void CIICEKEJANM()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void HHBJICLBNPE(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("The mine piece ") || ((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			GODBHHOFBMJ = 1285f;
			active = true;
		}
	}

	private void PJIMENLPNOE()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1902f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 362f || !(currentAlpha >= 1652f))
		{
			return;
		}
		active = true;
		currentAlpha = 968f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void EIEKPEEPFGA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("PirateMinigame/Talk") || ((Component)LGGCFCHOOMB).CompareTag("Path node error. Only 1 node at [0, 0] "))
		{
			GODBHHOFBMJ = 1940f;
			active = true;
		}
	}

	private void MPDHPPDAGMB(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/1/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("InteractPlaceableIfIsPossibleMaster"))
		{
			GODBHHOFBMJ = 895f;
			active = false;
		}
	}

	private void MOJBKEGFHOD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("popUpBuilding14") || ((Component)LGGCFCHOOMB).CompareTag("SortingGroup not attached to prefab "))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void NAOBODGBECL()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void CLNBMOPMNOF()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void AAEAAEBBFKG()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void NIPJAFAPNCP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(" in the database!") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveStartKlaynDialogueOathFeast"))
		{
			GODBHHOFBMJ = 1321f;
			active = false;
		}
	}

	private void OFNKDCBEAHP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/10/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("Duplicate crafting room lock found"))
		{
			GODBHHOFBMJ = 1112f;
			active = false;
		}
	}

	private void HCCJBKKGCLJ()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void KJJINNGPPEA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/46/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("tutorialPopUp28"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void GNAHKAHPCFB()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1810f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1362f || !(currentAlpha >= 585f))
		{
			return;
		}
		active = true;
		currentAlpha = 625f;
		for (int l = 1; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void KICCNEPCCFB(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1067") || ((Component)LGGCFCHOOMB).CompareTag(""))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void JKEGDKKBJFH(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Festín del Juramento/PresentacionMaestros 01") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1051"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void EDCINHFBGAN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_name_727") || ((Component)LGGCFCHOOMB).CompareTag("RPC Receive Talents From Other "))
		{
			GODBHHOFBMJ = 263f;
			active = true;
		}
	}

	private void PBDNKBPBCHM()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void MGMLDHPOLGK()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 452f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1146f || !(currentAlpha >= 470f))
		{
			return;
		}
		active = true;
		currentAlpha = 1910f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void IPNLMNFNLLJ(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("MaximumCapacity") || ((Component)LGGCFCHOOMB).CompareTag("Till"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void Update()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 5f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1f || !(currentAlpha >= 0.98f))
		{
			return;
		}
		active = false;
		currentAlpha = 1f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void PKEPBKHEDOD()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 80f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1466f || !(currentAlpha >= 1481f))
		{
			return;
		}
		active = false;
		currentAlpha = 1425f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void LMEJFGKCHEF()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 322f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 15f || !(currentAlpha >= 240f))
		{
			return;
		}
		active = false;
		currentAlpha = 1331f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void HONFDJKKGJK()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1284f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1505f || !(currentAlpha >= 227f))
		{
			return;
		}
		active = true;
		currentAlpha = 1986f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void GHEHLJANBCF()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1377f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1092f || !(currentAlpha >= 520f))
		{
			return;
		}
		active = true;
		currentAlpha = 1500f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void EIGEIJJPFFP()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 726f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1888f || !(currentAlpha >= 769f))
		{
			return;
		}
		active = true;
		currentAlpha = 1646f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void GGCCOKCOMEE()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1080f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 337f || !(currentAlpha >= 1560f))
		{
			return;
		}
		active = true;
		currentAlpha = 1351f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void LJJNLJILINI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Modifiers") || ((Component)LGGCFCHOOMB).CompareTag("UIInteract"))
		{
			GODBHHOFBMJ = 401f;
			active = true;
		}
	}

	private void PIHGEBONAOI()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void EJEEIIGEGOC()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1965f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1575f || !(currentAlpha >= 761f))
		{
			return;
		}
		active = true;
		currentAlpha = 184f;
		for (int l = 1; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void LEDIGKGAFHC()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1475f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1678f || !(currentAlpha >= 778f))
		{
			return;
		}
		active = false;
		currentAlpha = 276f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void OAKGHDAABPM()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1066f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1275f || !(currentAlpha >= 486f))
		{
			return;
		}
		active = false;
		currentAlpha = 232f;
		for (int l = 1; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void PAMNMLOLLKN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("tutorialPopUp116") || ((Component)LGGCFCHOOMB).CompareTag("Default"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void JPHFCJIBBMI()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1592f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 158f || !(currentAlpha >= 1582f))
		{
			return;
		}
		active = false;
		currentAlpha = 209f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void MPGPLILIJOD()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void EBNJADODONG()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1183f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 50f || !(currentAlpha >= 1924f))
		{
			return;
		}
		active = false;
		currentAlpha = 1193f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void GGDINGHDFPI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Error_OccupiedRoom") || ((Component)LGGCFCHOOMB).CompareTag("UIAddRemove"))
		{
			GODBHHOFBMJ = 191f;
			active = false;
		}
	}

	private void BHLHCOALABE()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1828f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 448f || !(currentAlpha >= 885f))
		{
			return;
		}
		active = true;
		currentAlpha = 1933f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void HPJBLOPJIMI()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void FJEKAKFLJJM(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("\n") || ((Component)LGGCFCHOOMB).CompareTag("OWNER_ID"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void OMBHDODDHNO()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void EHBMONGBJFI()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void OLPPDFDOKLK()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 559f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1466f || !(currentAlpha >= 1773f))
		{
			return;
		}
		active = false;
		currentAlpha = 1613f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void KFEMIEAPHNI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("") || ((Component)LGGCFCHOOMB).CompareTag("itemGreenbeanSeeds"))
		{
			GODBHHOFBMJ = 466f;
			active = false;
		}
	}

	private void EIHHJKFDCCC(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveUnlockHair") || ((Component)LGGCFCHOOMB).CompareTag("Suitabilities: "))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void MCLAJGDIIBK()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1360f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 113f || !(currentAlpha >= 1461f))
		{
			return;
		}
		active = true;
		currentAlpha = 677f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void GECHJIGBPEN()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void NFKHMBDBPLL(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("P2Cam") || ((Component)LGGCFCHOOMB).CompareTag("Tool"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void LEEOKPCIOGA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("UI2") || ((Component)LGGCFCHOOMB).CompareTag(""))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void LBJEAHNNMCN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("+") || ((Component)LGGCFCHOOMB).CompareTag("wilson"))
		{
			GODBHHOFBMJ = 112f;
			active = false;
		}
	}

	private void BINMHNJBDNI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Pet") || ((Component)LGGCFCHOOMB).CompareTag("LE_19"))
		{
			GODBHHOFBMJ = 306f;
			active = true;
		}
	}

	private void HNIFLGIAFBE(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("vibrationP2") || ((Component)LGGCFCHOOMB).CompareTag("Region check failed"))
		{
			GODBHHOFBMJ = 333f;
			active = true;
		}
	}

	private void GOJKOBEEMNA()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void GCAEAMDBGBM(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Received PlaceableMsg of another type not CrafterMsg to ") || ((Component)LGGCFCHOOMB).CompareTag("Use"))
		{
			GODBHHOFBMJ = 1436f;
			active = true;
		}
	}

	private void JMAAFFBIBCG()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 779f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 754f || !(currentAlpha >= 1383f))
		{
			return;
		}
		active = false;
		currentAlpha = 601f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void JJFIDIGMAMC(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("00") || ((Component)LGGCFCHOOMB).CompareTag("UI2"))
		{
			GODBHHOFBMJ = 1422f;
			active = false;
		}
	}

	private void GNOBDKFFPOL()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void ILOJBCEKLDF(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveFoodRequestAsMenuSlot") || ((Component)LGGCFCHOOMB).CompareTag("Fire Loop NULL!!"))
		{
			GODBHHOFBMJ = 1136f;
			active = false;
		}
	}

	private void BLOCHBJIICN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("") || ((Component)LGGCFCHOOMB).CompareTag("BathhouseGameManager: Invalid player number "))
		{
			GODBHHOFBMJ = 707f;
			active = true;
		}
	}

	private void NDFEMHNLKCE(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Gass_Introduce/Entry/5/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag(" "))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Player2"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void GAANFGOOBGC(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("pauseMenuRoomCode") || ((Component)LGGCFCHOOMB).CompareTag("MineFloor"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void CLOKMCONOMN()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 14f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 32f || !(currentAlpha >= 1973f))
		{
			return;
		}
		active = true;
		currentAlpha = 1303f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void IOHIEBBDOJN()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 473f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 789f || !(currentAlpha >= 1765f))
		{
			return;
		}
		active = false;
		currentAlpha = 868f;
		for (int l = 0; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void APJNDKLBHCF()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 105f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 676f || !(currentAlpha >= 215f))
		{
			return;
		}
		active = true;
		currentAlpha = 1176f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void MPCFCNCMOAF()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void AJGLDLLIIFO()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void EKNEIMIENPG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1106") || ((Component)LGGCFCHOOMB).CompareTag("[OfferingStatuePuzzle] Initialized. Required items: "))
		{
			GODBHHOFBMJ = 521f;
			active = false;
		}
	}

	private void PEFKNEPONAG()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void CNBLOMJJECI()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1035f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 398f || !(currentAlpha >= 1499f))
		{
			return;
		}
		active = true;
		currentAlpha = 1719f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void MJKDLOHNECA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("VerticalMove") || ((Component)LGGCFCHOOMB).CompareTag("UI"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void FCONKHCGBEM(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1230"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void JOPKPGIEAPD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1104") || ((Component)LGGCFCHOOMB).CompareTag("tutorialPopUp23"))
		{
			GODBHHOFBMJ = 741f;
			active = true;
		}
	}

	private void MLICJIBNIFA()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 259f);
		for (int i = 1; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1704f || !(currentAlpha >= 1357f))
		{
			return;
		}
		active = true;
		currentAlpha = 1939f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void JFJJJIEGDPH(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(")") || ((Component)LGGCFCHOOMB).CompareTag("LE_3"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void PCKOHAIPHFI()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void FJKKLJHHMLC(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("SetNPCPositionAndParent") || ((Component)LGGCFCHOOMB).CompareTag(" PlayerNum: "))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void CMJBBBHGHCD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("https://www.isolatedgames.com/bug-report/index.php") || ((Component)LGGCFCHOOMB).CompareTag("qualityWater"))
		{
			GODBHHOFBMJ = 545f;
			active = true;
		}
	}

	private void JGBLJPDNLMO(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("City/Rhia/Bark/Stand") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveResetAllTalents"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void KLCFOJHHBJA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("On Simple Event ") || ((Component)LGGCFCHOOMB).CompareTag("Farm/Violet/Main"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void IBMDFNKKPJF()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void HIMBLFNCDLL(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Eat") || ((Component)LGGCFCHOOMB).CompareTag("Graphics Device Name: "))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void BBGDBHFFDGE(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("[^0-9]") || ((Component)LGGCFCHOOMB).CompareTag(" "))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = false;
		}
	}

	private void Awake()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void JMDOCHBJGKG()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1748f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1464f || !(currentAlpha >= 1937f))
		{
			return;
		}
		active = true;
		currentAlpha = 1304f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void PAJBIPKEAIG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("End") || ((Component)LGGCFCHOOMB).CompareTag("Walk"))
		{
			GODBHHOFBMJ = 649f;
			active = false;
		}
	}

	private void DAGGKPKBCLD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("You lose...") || ((Component)LGGCFCHOOMB).CompareTag("room info with code "))
		{
			GODBHHOFBMJ = 925f;
			active = true;
		}
	}

	private void JDMMNLKLMAA()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void GEFCGLEGHOA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Fortitude/MainEvent 4") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveStartIntroMasters"))
		{
			GODBHHOFBMJ = 1895f;
			active = true;
		}
	}

	private void LDMDHDACNFJ()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1275f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 923f || !(currentAlpha >= 1172f))
		{
			return;
		}
		active = true;
		currentAlpha = 1188f;
		for (int l = 0; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m++)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void ENKFHHEMHGG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ItemsOutOfStock") || ((Component)LGGCFCHOOMB).CompareTag("Inventory full"))
		{
			GODBHHOFBMJ = 1991f;
			active = false;
		}
	}

	private void NAFADNEKCOH(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("</color>") || ((Component)LGGCFCHOOMB).CompareTag("add letter "))
		{
			GODBHHOFBMJ = 71f;
			active = true;
		}
	}

	private void INBHNOLGOBP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("\n<color=#822F00>") || ((Component)LGGCFCHOOMB).CompareTag("\n"))
		{
			GODBHHOFBMJ = 462f;
			active = false;
		}
	}

	private void FHOCCEBKHJI()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[0]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void DCFEMOFDLHH(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("itemLeek") || ((Component)LGGCFCHOOMB).CompareTag("New"))
		{
			GODBHHOFBMJ = 455f;
			active = false;
		}
	}

	private void OMLHIAADEHE()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1107f);
		for (int i = 0; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 0; j < spriteRenderersBarnWall.Length; j++)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1749f || !(currentAlpha >= 197f))
		{
			return;
		}
		active = true;
		currentAlpha = 1007f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void PMLKGEDCLBL(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Direction") || ((Component)LGGCFCHOOMB).CompareTag("Clear"))
		{
			GODBHHOFBMJ = alphaTransparency;
			active = true;
		}
	}

	private void OHDEOCEKHBM(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Mine") || ((Component)LGGCFCHOOMB).CompareTag("<br>"))
		{
			GODBHHOFBMJ = 1474f;
			active = false;
		}
	}

	private void BFGFGIFBDDL(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Use") || ((Component)LGGCFCHOOMB).CompareTag("DestroyWithTime: No object assigned to destroy. Destroying the GameObject this script is attached to instead."))
		{
			GODBHHOFBMJ = 593f;
			active = false;
		}
	}

	private void MEKOIJNOMJG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(".") || ((Component)LGGCFCHOOMB).CompareTag("Open"))
		{
			GODBHHOFBMJ = 1523f;
			active = false;
		}
	}

	private void DNBGIIGAKMJ()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[0] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void FBLAMCDFMPE()
	{
		if (spriteRenderers.Length != 0 && (Object)(object)spriteRenderers[1] != (Object)null)
		{
			HKIODKOAHPE = ((Renderer)spriteRenderers[1]).sharedMaterial;
		}
		else
		{
			HKIODKOAHPE = null;
		}
	}

	private void MNFJELNEGPG()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 1651f);
		for (int i = 0; i < spriteRenderers.Length; i += 0)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 0; k < spriteRenderersBarnWood.Length; k += 0)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1548f || !(currentAlpha >= 1885f))
		{
			return;
		}
		active = false;
		currentAlpha = 1070f;
		for (int l = 1; l < spriteRenderers.Length; l++)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 1; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 1; n < spriteRenderersBarnWood.Length; n++)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}

	private void LHFOFAMDKEO()
	{
		if (!active || (Object)(object)barn == (Object)null)
		{
			return;
		}
		currentAlpha = Mathf.Lerp(currentAlpha, GODBHHOFBMJ, Time.deltaTime * 863f);
		for (int i = 1; i < spriteRenderers.Length; i++)
		{
			if ((Object)(object)spriteRenderers[i] != (Object)null)
			{
				((Renderer)spriteRenderers[i]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
			}
		}
		for (int j = 1; j < spriteRenderersBarnWall.Length; j += 0)
		{
			((Renderer)spriteRenderersBarnWall[j]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		for (int k = 1; k < spriteRenderersBarnWood.Length; k++)
		{
			((Renderer)spriteRenderersBarnWood[k]).material.SetFloat(ShaderReferences.alpha, currentAlpha);
		}
		if (GODBHHOFBMJ != 1358f || !(currentAlpha >= 663f))
		{
			return;
		}
		active = true;
		currentAlpha = 1630f;
		for (int l = 1; l < spriteRenderers.Length; l += 0)
		{
			if ((Object)(object)spriteRenderers[l] != (Object)null)
			{
				((Renderer)spriteRenderers[l]).sharedMaterial = HKIODKOAHPE;
			}
		}
		for (int m = 0; m < spriteRenderersBarnWall.Length; m += 0)
		{
			((Renderer)spriteRenderersBarnWall[m]).sharedMaterial = barn.style.material;
		}
		for (int n = 0; n < spriteRenderersBarnWood.Length; n += 0)
		{
			((Renderer)spriteRenderersBarnWood[n]).sharedMaterial = barn.style.detailMaterial;
		}
	}
}
