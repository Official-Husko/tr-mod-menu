using System;
using UnityEngine;
using UnityEngine.Rendering;

public class ChangeLayers : MonoBehaviour
{
	[Serializable]
	public struct LayersStruct
	{
		public SortingGroup sortingGroup;

		public SpriteRenderer spriteRenderer;

		public string layerName;

		public int orderInLayer;
	}

	public LayersStruct[] layersStruct;

	private int[] AFCMHMHFDOO;

	private int[] BAGMAAMOAOE;

	private void DNKEFFMOCKP()
	{
		LFDEKBLDACO();
	}

	public void DCADFPJCKOP()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void MMJIEBGKPCI()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void MFHHPHBHJMA()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void JPPHBBNMPNJ()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void BJPMEKNKEDC()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void GMEJNMBIBKE()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void KHGNLFHBAJF()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void MCKIHBCJAPO()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void MPGPLILIJOD()
	{
		AEBKHLLKFKH();
	}

	private void LHOIJEKIGCG()
	{
		FHLOMAIIGMF();
	}

	public void PIKKGMDMHAO()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void ResetLayers()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void NONAKCDGHDO()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void MMNBJPDJHGK()
	{
		LFDEKBLDACO();
	}

	private void KLGCMMIKGIO()
	{
		FHLOMAIIGMF();
	}

	private void GGOPCJOAOMC()
	{
		AEBKHLLKFKH();
	}

	private void AEBKHLLKFKH()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void CLCDNHNHMBG()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void OEHEADMOHLH()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void NBPMOJOKGKP()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void GHGODENDFMF()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void EBNCFFNKOFP()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void OKHLEMPJONN()
	{
		OEHEADMOHLH();
	}

	public void LGDAJCEGBAO()
	{
		GCEFIKFAFPE();
		BJHHDFCPEPC();
	}

	private void KBAIDLPPHPE()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void MPCFCNCMOAF()
	{
		HGCKANCJOCO();
	}

	public void MIPODFEDPKO()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void KHONOODGLBI()
	{
		KHGNLFHBAJF();
	}

	private void DKNNLPFIBIK()
	{
		BBIJEGMEGGP();
	}

	public void DALEDOPOGLO()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void BOFOILDBJDK()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void CLACCLMPPJH()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void HKKEIKPHDDH()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void EMDNBBNHHOH()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void JIFBEBDEDNM()
	{
		NCCNIPCIBLF();
		BPACMEKKDHI();
	}

	private void BKKKBAAIDEN()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void BPACMEKKDHI()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void BMKGHOJDDNB()
	{
		NCCNIPCIBLF();
	}

	private void EJMGGLEPLBJ()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void DHFDEOIJFPC()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void GMOLJHPOCBJ()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void PMCAJBBFLBE()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void HBBHJKODIHJ()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void LBNFGNCNAAN()
	{
		GMEJNMBIBKE();
		OHCCGLNDODH();
	}

	public void OHCCGLNDODH()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void NGHOGELOGCE()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void PFLOGDDBMCK()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void AIFHLFJNOAI()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void OILJIKANCFM()
	{
		EMPKLLHMIJK();
		EMDNBBNHHOH();
	}

	public void HKAENIOKAPJ()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void HELJOJLNKCE()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void IIPMLFMABPN()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void AGLMGDNBHBF()
	{
		DOBKNEAGDBP();
	}

	private void GEGNJJHHNEF()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void AGELAMLCINB()
	{
		GCEFIKFAFPE();
	}

	public void FOLPJBDMNMM()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void DPKKCFMGHJB()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void CFOOJFIPDNN()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void BBIJEGMEGGP()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void OEBFOEGLBAA()
	{
		JLHCGGBINIM();
		BPACMEKKDHI();
	}

	private void KLHIMJFCHPD()
	{
		MBGLAJFFGBA();
	}

	public void HBMHCLEPLCC()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void GALMICMLCJN()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void Change()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void FCNKGINGJNM()
	{
		MBGLAJFFGBA();
	}

	public void DOFPPKMBKBK()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void KBNMLJNBBMP()
	{
		HELJOJLNKCE();
	}

	public void OLHIPJCLFDO()
	{
		JLHCGGBINIM();
		EMDNBBNHHOH();
	}

	private void AMNCIAEMBFO()
	{
		EJMGGLEPLBJ();
	}

	public void OGOPJIEIKMF()
	{
		NGHOGELOGCE();
		OHCCGLNDODH();
	}

	public void LHHKBFJCLIG()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void MFJMIMGBPFM()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void GCGHHBKHKFC()
	{
		NCCNIPCIBLF();
		JNAMPAJPOLG();
	}

	public void OGDALNCIMDN()
	{
		PFLOGDDBMCK();
		Change();
	}

	public void KCJDCCIKEIG()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void AJGLDLLIIFO()
	{
		KHGNLFHBAJF();
	}

	private void DOBKNEAGDBP()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void GLPMHKEOGDG()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void GKDGKLKMHNK()
	{
		AEBKHLLKFKH();
		MFJMIMGBPFM();
	}

	public void EDBBOIJBKIH()
	{
		NGHOGELOGCE();
		BJHHDFCPEPC();
	}

	public void PECIMDAJHBP()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void FNAANFNHKOM()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void KPPOIOLLNDH()
	{
		LNIFNCCJAAF();
		OHCCGLNDODH();
	}

	private void OCJOAHDNDIJ()
	{
		LFDEKBLDACO();
	}

	public void NFFCEPPGGBM()
	{
		KBAIDLPPHPE();
		BPACMEKKDHI();
	}

	private void FHOCCEBKHJI()
	{
		OEHEADMOHLH();
	}

	private void JLHCGGBINIM()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void MBGLAJFFGBA()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void JDAMCMODANB()
	{
		HOPMNMOJJPN();
	}

	public void JHNEMKILJFJ()
	{
		KHGNLFHBAJF();
		NONJOIFOFID();
	}

	private void NCCNIPCIBLF()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void JNAMPAJPOLG()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void NGKHMPHIMPK()
	{
		AELGKKFGJGK();
		HKKEIKPHDDH();
	}

	public void CGODLDFPHCP()
	{
		AELGKKFGJGK();
		OHCCGLNDODH();
	}

	private void NCPNBBCNBIM()
	{
		BKKKBAAIDEN();
	}

	public void BJHHDFCPEPC()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void FFKEKPDEHHN()
	{
		OEHEADMOHLH();
		OFICMFHDPOO();
	}

	public void OKGCMCDBPJB()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void OEODLMICCIA()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void LFDEKBLDACO()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void AAPLKAHNGGN()
	{
		KMJLCFIPFMN();
		GMOLJHPOCBJ();
	}

	private void KKHALNGOFDJ()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void CNHHPMDFBJM()
	{
		NCCNIPCIBLF();
	}

	private void HMHCLIBLKLN()
	{
		GMEJNMBIBKE();
	}

	public void OFICMFHDPOO()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void HGCKANCJOCO()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void KMJLCFIPFMN()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void FCNJAPEHFBD()
	{
		AELGKKFGJGK();
		OFICMFHDPOO();
	}

	public void DAMMFONEMGH()
	{
		AEBKHLLKFKH();
		FKFNDJJBEFH();
	}

	public void IBKMLAEJMBC()
	{
		EBNCFFNKOFP();
		CFOOJFIPDNN();
	}

	private void FPNCANODJKE()
	{
		KHGNLFHBAJF();
	}

	public void LKHEPLBIKPA()
	{
		FHLOMAIIGMF();
		MFJMIMGBPFM();
	}

	public void NONJOIFOFID()
	{
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void GCEFIKFAFPE()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void JEOPJLBGEHE()
	{
		KHGNLFHBAJF();
		HKKEIKPHDDH();
	}

	public void KNDAEECDJFA()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void EIMIDCDEIDD()
	{
		EMPKLLHMIJK();
	}

	public void JKKBFJBFOBF()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void LNIFNCCJAAF()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void FHLOMAIIGMF()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void FELJAKBBFJD()
	{
		EBNCFFNKOFP();
	}

	private void BODICIENBEH()
	{
		BOFOILDBJDK();
	}

	private void HOPMNMOJJPN()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void KJHKBGDJNDC()
	{
		KHGNLFHBAJF();
	}

	public void FJGKKCFKIEK()
	{
		for (int i = 0; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	private void PNLAJCHBHPH()
	{
		BBIJEGMEGGP();
	}

	private void Awake()
	{
		HGCKANCJOCO();
	}

	public void ENPGDFCKMKH()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	public void JKJHDNGDKOP()
	{
		DOBKNEAGDBP();
		CLCDNHNHMBG();
	}

	private void KGIKOECKEHI()
	{
		KKHALNGOFDJ();
	}

	public void LBLGBBLCAOM()
	{
		MBGLAJFFGBA();
		AIFHLFJNOAI();
	}

	public void ChangeButton()
	{
		HGCKANCJOCO();
		Change();
	}

	public void IHBHNBMKMBC()
	{
		FHLOMAIIGMF();
		NONJOIFOFID();
	}

	private void DGBJJNAADCI()
	{
		GCEFIKFAFPE();
	}

	public void OMAOHCELMJN()
	{
		NCCNIPCIBLF();
		MCKIHBCJAPO();
	}

	private void KMEJBPOOBJK()
	{
		HELJOJLNKCE();
	}

	private void OIOLGAOPECC()
	{
		HELJOJLNKCE();
	}

	public void POJKPGFINKK()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void AELGKKFGJGK()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	public void FKFNDJJBEFH()
	{
		for (int i = 0; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					layersStruct[i].sortingGroup.sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				layersStruct[i].sortingGroup.sortingOrder = layersStruct[i].orderInLayer;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				if (!string.IsNullOrEmpty(layersStruct[i].layerName))
				{
					((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = SortingLayer.NameToID(layersStruct[i].layerName);
				}
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = layersStruct[i].orderInLayer;
			}
		}
	}

	public void NLPDOOKCJEK()
	{
		for (int i = 1; i < layersStruct.Length; i += 0)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				layersStruct[i].sortingGroup.sortingLayerID = AFCMHMHFDOO[i];
				layersStruct[i].sortingGroup.sortingOrder = BAGMAAMOAOE[i];
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				((Renderer)layersStruct[i].spriteRenderer).sortingLayerID = AFCMHMHFDOO[i];
				((Renderer)layersStruct[i].spriteRenderer).sortingOrder = BAGMAAMOAOE[i];
			}
		}
	}

	private void OMBHDODDHNO()
	{
		BBIJEGMEGGP();
	}

	private void EMPKLLHMIJK()
	{
		AFCMHMHFDOO = new int[layersStruct.Length];
		BAGMAAMOAOE = new int[layersStruct.Length];
		for (int i = 1; i < layersStruct.Length; i++)
		{
			if ((Object)(object)layersStruct[i].sortingGroup != (Object)null)
			{
				AFCMHMHFDOO[i] = layersStruct[i].sortingGroup.sortingLayerID;
				BAGMAAMOAOE[i] = layersStruct[i].sortingGroup.sortingOrder;
			}
			if ((Object)(object)layersStruct[i].spriteRenderer != (Object)null)
			{
				AFCMHMHFDOO[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingLayerID;
				BAGMAAMOAOE[i] = ((Renderer)layersStruct[i].spriteRenderer).sortingOrder;
			}
		}
	}

	private void EFABNGNAENH()
	{
		JLHCGGBINIM();
	}
}
