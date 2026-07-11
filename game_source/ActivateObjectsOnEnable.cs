using UnityEngine;

public class ActivateObjectsOnEnable : MonoBehaviour
{
	public GameObject[] gameObjectsToActivate;

	public GameObject[] gameObjectsToDeactivate;

	public SpriteRenderer[] spriteRenderersToActivate;

	public SpriteRenderer[] spriteRenderersToDeactivate;

	private void MEDLNBCAJCL()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void HEOAIGHOLLD()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void ANLHPMPMBFM()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void CCJOOMDHMKM()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void ADJHOLOIGJE()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void AONIDCIEKCM()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void GKCKLIAANHA()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void JMMBKMOBAFB()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void GBAKNAINDJM()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void EPFDKCELPDD()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void BFKCHCLJIPL()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void NJKHCOHADCL()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void GDKOIIEHKGO()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void PDAFINABOBC()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void AECMHPBLPNP()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void FGLCNIOLKKL()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void NPDFCPEOFPD()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void EPFJBCOKEHC()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void FBHBEAJFBAH()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void ICKIAOEOHDJ()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void ANMOAFFGEOE()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void JMAHDPMEEHM()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void LFBIFPBPDMJ()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void DNAMDIHOOKN()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void DJJENHCMCBN()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void JINLGFOFJAN()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void JKBBAOGHPKO()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void NELLIBBABJD()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void OJPLLAOFDCC()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void BJOOCKCBPLJ()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void ADDLDNPHIHF()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void PJOAFKEIPPD()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void NBBFLJNPLEA()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void JIBHLLJGGEN()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void ECHMKEAGFFO()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void HGEKPHOPJCD()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void HJKONJICGML()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void OFJIMLOLIDP()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void AGFLPEOOEAM()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void FINKPIHPHDE()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void HCKMHIHALBL()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void LMPCDDGFBGD()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void JLLHILICJOC()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void OnEnable()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void HFIHGHBLLAM()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void OKEGMHBDHIP()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void HKJCLFHCMKC()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void GJCADEIJMCM()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void PGDAOMNADHA()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void NLHALEAEDMM()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = true;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void AFGJLAACCFN()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void HHHEACKHADN()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 1; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void AOJCCOIHPMH()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
		}
	}

	private void OnDisable()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void DIJOBOFGCIK()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 0; j < spriteRenderersToActivate.Length; j += 0)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void INEOMPKPILM()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void FJFLGDADEKM()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void JMHIFDNKOPH()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = false;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void EGHFDLCNPNC()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void LCJCGFNFBBD()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(true);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k += 0)
		{
			gameObjectsToDeactivate[k].SetActive(true);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void IMMHKDGFCJA()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		for (int k = 1; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}

	private void MAEGGDLLHBG()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(true);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 1; l < spriteRenderersToDeactivate.Length; l += 0)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
			}
		}
	}

	private void OIEJIBAPDMM()
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(false);
		}
		for (int j = 1; j < spriteRenderersToActivate.Length; j++)
		{
			((Renderer)spriteRenderersToActivate[j]).enabled = false;
		}
		for (int k = 0; k < gameObjectsToDeactivate.Length; k++)
		{
			gameObjectsToDeactivate[k].SetActive(false);
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			((Renderer)spriteRenderersToDeactivate[l]).enabled = false;
		}
	}

	private void ADEBBJOALDN()
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToActivate[i]))
			{
				gameObjectsToActivate[i].SetActive(false);
			}
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			if (Object.op_Implicit((Object)(object)gameObjectsToDeactivate[j]))
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		for (int k = 0; k < spriteRenderersToActivate.Length; k++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToActivate[k]))
			{
				((Renderer)spriteRenderersToActivate[k]).enabled = true;
			}
		}
		for (int l = 0; l < spriteRenderersToDeactivate.Length; l++)
		{
			if (Object.op_Implicit((Object)(object)spriteRenderersToDeactivate[l]))
			{
				((Renderer)spriteRenderersToDeactivate[l]).enabled = true;
			}
		}
	}
}
