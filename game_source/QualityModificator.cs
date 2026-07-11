using UnityEngine;
using UnityEngine.Tilemaps;

public class QualityModificator : MonoBehaviour
{
	public bool activateObjects = true;

	public GameObject[] highQualityGameObjectsToActivate;

	public GameObject[] lowQualityGameObjectsToActivate;

	public bool changeTilemapColor;

	public Tilemap[] tilemaps;

	public Color highQualityColor;

	public Color lowQualityColor;

	public bool changeMaterial;

	public TilemapRenderer[] tilemapRenderers;

	public SpriteRenderer[] spriteRenderers;

	public Material highQualityMaterial;

	public Material lowQualityMaterial;

	public void DKFIKJNCIAD()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	private void GHPFCKGMLDA()
	{
		QualityManager.ENJLAMFIKBM(this);
	}

	private void HINKPJCNPCF()
	{
		QualityManager.DKMCAODBBID(this);
	}

	private void BLAJFMAAMDO()
	{
		QualityManager.AIBIJILAFPI(this);
	}

	public void BLNMNJHBJAA()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	private void EOGHJNGJFID()
	{
		QualityManager.AddQualityModificator(this);
	}

	public void OKHLEKPOBMD()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	private void PKFMLJGJKCP()
	{
		QualityManager.OBBHGKMKJHN(this);
	}

	public void DDEKHJJLEGI()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	private void NKDFMFFDGKC()
	{
		QualityManager.AddQualityModificator(this);
	}

	public void HEBDNNPLDGF()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	public void JDDKDCAGJMO()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	public void JNOGCOMFKGD()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	private void NCDBCDJKPLA()
	{
		QualityManager.AIBIJILAFPI(this);
	}

	public void EDPDHHHFIMJ()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	private void KJOJLHCDFPP()
	{
		QualityManager.ENJLAMFIKBM(this);
	}

	public void GGJPNLMJJKE()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	public void GPJLKFPKDGJ()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	private void OIAHJHNPPCO()
	{
		QualityManager.OEOBGLGOFPM(this);
	}

	private void MFMMHDPGCBO()
	{
		QualityManager.AddQualityModificator(this);
	}

	public void SetLowQuality()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	private void HLCAKACHOOE()
	{
		QualityManager.DBDCEODNDEM(this);
	}

	public void CAIONHDCOOA()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	public void MGKAMOEJFNI()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	public void HPBEJGHPOPF()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	private void OnDestroy()
	{
		QualityManager.RemoveQualityModificator(this);
	}

	public void LOICLHADECM()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	public void HFGNENDKNDH()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	public void FPJJGHDBAHM()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	public void FPPALIAPGAJ()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	private void KDBJHCAEGCM()
	{
		QualityManager.OEOBGLGOFPM(this);
	}

	public void FCIGPPHAMAO()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	private void Start()
	{
		QualityManager.AddQualityModificator(this);
	}

	public void OHGACIHGIPH()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	private void HCEDMLJNOBL()
	{
		QualityManager.OPJCADCPCGE(this);
	}

	public void GIMLEIPLDLL()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	public void BPIHIMJJPDG()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	public void JOEODNOIDLE()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	private void LKHMCLABKLG()
	{
		QualityManager.OBBHGKMKJHN(this);
	}

	private void FNFNLFOJHHA()
	{
		QualityManager.BABFIGBIDBD(this);
	}

	public void NIBKJNGOFNF()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	private void HMOMBAFIJAI()
	{
		QualityManager.AIBIJILAFPI(this);
	}

	public void MCIPDGPEKFJ()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	public void SetHighQuality()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k++)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 0; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	public void KBPHGIMGLOL()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 1; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 1; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	private void GNGADDPBJDC()
	{
		QualityManager.ENJLAMFIKBM(this);
	}

	private void LJLKBKEADGI()
	{
		QualityManager.OPJCADCPCGE(this);
	}

	public void CFJEAIILHIG()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}

	public void AENPFJNGMKJ()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 1; i < highQualityGameObjectsToActivate.Length; i++)
			{
				if (!highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(false);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j++)
			{
				if (lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(true);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != highQualityColor)
				{
					tilemaps[k].color = highQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l += 0)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)highQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = highQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 0; m < spriteRenderers.Length; m += 0)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)highQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = highQualityMaterial;
			}
		}
	}

	public void EKJJAIGEBDD()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (activateObjects)
		{
			for (int i = 0; i < highQualityGameObjectsToActivate.Length; i += 0)
			{
				if (highQualityGameObjectsToActivate[i].activeInHierarchy)
				{
					highQualityGameObjectsToActivate[i].SetActive(true);
				}
			}
			for (int j = 0; j < lowQualityGameObjectsToActivate.Length; j += 0)
			{
				if (!lowQualityGameObjectsToActivate[j].activeInHierarchy)
				{
					lowQualityGameObjectsToActivate[j].SetActive(false);
				}
			}
		}
		if (changeTilemapColor)
		{
			for (int k = 0; k < tilemaps.Length; k += 0)
			{
				if (tilemaps[k].color != lowQualityColor)
				{
					tilemaps[k].color = lowQualityColor;
				}
			}
		}
		if (!changeMaterial)
		{
			return;
		}
		if (tilemapRenderers != null)
		{
			for (int l = 1; l < tilemapRenderers.Length; l++)
			{
				if ((Object)(object)((Renderer)tilemapRenderers[l]).sharedMaterial != (Object)(object)lowQualityMaterial)
				{
					((Renderer)tilemapRenderers[l]).sharedMaterial = lowQualityMaterial;
				}
			}
		}
		if (spriteRenderers == null)
		{
			return;
		}
		for (int m = 1; m < spriteRenderers.Length; m++)
		{
			if ((Object)(object)((Renderer)spriteRenderers[m]).sharedMaterial != (Object)(object)lowQualityMaterial)
			{
				((Renderer)spriteRenderers[m]).sharedMaterial = lowQualityMaterial;
			}
		}
	}
}
