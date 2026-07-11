using UnityEngine;
using UnityEngine.Tilemaps;

public class MineVariant : MonoBehaviour
{
	public bool hasPuzzleAltar;

	public bool hasPuzzle;

	public Tilemap groundTilemap;

	public CommonTilemaps commonTilemaps;

	public TilemapGroup tilemaps;

	public Tilemap[] holeTileMaps;

	public void JOGGMDOCHME(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void JMCDJAIAHNH()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void ALBFBOFOLCF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void KDDGPLHDLEN()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void PGMODJPOFFB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void JAMLFONMKDN()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void COOBFMDPHLF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void PHPLLLLHAHL(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void COJGNOMGEDE(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void LEPCGOBMNDJ(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void JHPBLNABOBH(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void COEPDBMBDKC()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void DMBMIOAJFFK(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void JKINFOGGIIH(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void EFNJHCKKIAB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void NMOHNDFLNOC(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void BPIGJOKJIOL(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void NEHPHNLKPKM(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void APAHLFPPECB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void LHEMPHOFJJE(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void LIHGMPIPIFK(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void NOBGICABFKD()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void AGAJFFELKHE(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void DEPIGHINFAB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void ONBGOHKMKOF()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void GBJGIDHKBEM(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void GLBIHCBNIAK()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void DFGIMKEKHIP()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void DELJJNFLKGF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void EFJHJPBADPG()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void PHHNMLJJOAE(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void ENOHOAMPGGB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void EMMPIFHCAFK(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void HHJJKHIMHMP(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void MDKEFLECIJC()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void PPOBNKPNPKO(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void AODOEGNCGNB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void NIHFGLEGMDM(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void BOJDNFHGOEC(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void LJPNEPHBNKJ()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void KGFMHFNDICN(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void PGHIPHDEGPL()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void CFFFEHPPLFB()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void NJNMBBFEDGP()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void NOKFNAGIOOI(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void BBFEDGIKMFL(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void FINGBJHNDJE()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void OOEJPMGIIGH(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void KDMLICCMOFB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void ACPAJKGOKJA(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void DMFJIEMLDMI()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void OCGHOBKIGAE()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void MFMGLNKCEPM()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void ACOOMNHNEFF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void FAFNDGEHCFL()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void AMMGADDAPEE(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void AKIEENDLADA(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void CKLGNHLAOGH()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void CHLIIFBKEFC()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void MIFNPIAOAOJ()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void DMIAKEKBENF()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void NIJELJJJLGD(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void IANBCCJNPEB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void NPBEMDHGHEN()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void ILACAMKDNNF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void BKIGKJNOJND()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void LDMOCGJMDDH(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void PHEJCBPCNEJ(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void GKLAMJJAMBF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void FDDDFICPIBK()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void AddPathNodes(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void LADOELLLIMK(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void OOGNAFJGMBC(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void JOKAEOBFIHM(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void RemovePathNodes(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void OHKLNIOPBKN(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void NBALMHLGCEM()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void OLNLJEPOAJL()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void FBHAPKPAOIM(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void GCGFBHGLCEJ()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void OMAMCLHAOPH(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void JKNCIOJAPEI(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void IDJPDJFCBFH()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void BMDGIMILOMN(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void LNAEOICBCNJ()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void AAKLHBIPJFL(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void PKKHMEFKIHH()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void FEIJHEFCBDJ(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void DFFMKGNIDEF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void FLEAILLANJH(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void ONCPHLDOGOG(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void FNMAAPNDACM()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void CLGHENOLEJB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void PHLKOLCONIE()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void HFMKLEEMHED()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void DFFCOAMDPCD()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void LNLAMNFMDPC()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void CCEDFKIBGBG()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void HKMMNEBEKFB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void MIGCLHCHKDP()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void HGHMFJGICPE()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void KIBNFLGAFJG()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void BFLHHGLKKKP()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void PKCBNMKDDFG(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void DAFPMBNCPFJ(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void OAHGAPIJHOA()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void DKOHFFKLDJB(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void BGCCNFCCNAK()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void GIPHIFKDEIK(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void MFLNHGDAGMK(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void PEINEJCOLCJ()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void NICNIMDCBCO(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void ODNAHALOMII(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void ELBEIGNKLKP()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void MKOCDGNOGBE(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void PLBKOILLEOJ(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void PNPMJDDODGD()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void EEIGHAJIPIB()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void JNNNLJAMOCE(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void FLOLKKKFGCM(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void ActivateVariant()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void OHCJLLDFOAE(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void NKEIEFILDOG(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void JICOBKPJMEJ()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().DeactivateVariants(((Component)this).gameObject);
	}

	public void AHHNLHGKBEA(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void GJAMOEOPGOC()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void BNELFKIOEDL(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void GIOKDMOJMAP(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void CIGCAGDICBF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void ODPPHGJAHCO(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i++)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void KJHGKGCCDGM(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void HFEJCILGOMO()
	{
		((Component)this).gameObject.SetActive(false);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}

	public void PNJHOJIIGCF(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void EFBOIKILGHO(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 0; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				WorldGrid.MJDKNJPJILH(Vector2.op_Implicit(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]));
			}
		}
	}

	public void KMHBLFPMABO(MinePieceSO IPKAIBNEMJM, int NJGLLHDIADJ)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (NJGLLHDIADJ < IPKAIBNEMJM.variants.Length)
		{
			for (int i = 1; i < IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated.Length; i += 0)
			{
				PathNodesManager.pathNodes.Remove(Vector2.op_Implicit(((Component)this).transform.position) + IPKAIBNEMJM.variants[NJGLLHDIADJ].pathNodesCreated[i]);
			}
		}
	}

	public void DAINIKDJHKM()
	{
		((Component)this).gameObject.SetActive(true);
		((Component)this).GetComponentInParent<MinePiece>().HJHEEGINCKG(((Component)this).gameObject);
	}
}
