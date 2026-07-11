using System.Collections.Generic;
using UnityEngine;

public class DestructibleObjectsVariant : MonoBehaviour
{
	public GameObject[] destructibleObjectsStyles;

	public List<GameObject> LFBGKKMMNJH(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = IFBMEAGLAIA(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(false);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public List<GameObject> NNEMGLNIEHK(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = FHDKPEMDPJE(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public List<GameObject> PKAAJKPOEIE(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = AODLKDANAML(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public List<GameObject> JNJGEFNKBML(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = GOMPKDDLJAM(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	private List<GameObject> IFBMEAGLAIA(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 0; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].FGPECKLAIHH(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(false);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> GJFDAHGEPDM(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = IPNMJMMHIFO(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public List<GameObject> NKLFHLHBNKC(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = AODLKDANAML(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(false);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	private List<GameObject> MOFMNPIBEFM(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 1; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].IIDHFOMJOHC(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> GFILCKAPHNA(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = IPNMJMMHIFO(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public void IKEPABBIKIB()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void BLCNLFIJPHN()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void PKGECILDPFK()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	private List<GameObject> DFHCJDABPBI(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 1; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].PFAJBONJPDI(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> NMLCAOHKMLN(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = ANAAAEFILJC(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public List<GameObject> KBHMGGBOMGA(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(1, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = IPNMJMMHIFO(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public List<GameObject> LIGBDGINAAD(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(1, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = OABGMJKMFBM(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public void LJKLJBGJBGH()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void IHDKKACJENC()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void DAHFGENJMGO()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> DKCPNCGPMMF(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = AODLKDANAML(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public void CGNOIMBEIEO()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> BKKMCGNGCJE(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = DFHCJDABPBI(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public void GPLGHIGCCEH()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void HPCJHFPMKNM()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	private List<GameObject> DKCHNOICKOM(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 0; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].OIOBNCKGHKN(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public void GJNHEMKMBLD()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> IPFBAMINALN(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = IPNMJMMHIFO(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	private List<GameObject> CAOHICINMHA(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 1; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].EHBFAIIMMHD(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public void EHHMPHFINFJ()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void GetDestructibleObjects()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> NJBALFMKLFA(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(1, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = DFHCJDABPBI(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public List<GameObject> PCLCIFMMJCD(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = IPNMJMMHIFO(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	private List<GameObject> NGEHJMAHNPH(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 0; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].MPIDOCFBCGL(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> GLMDFLMCHKM(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = NGEHJMAHNPH(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public void FPPPFCLJBIC()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	private List<GameObject> GOMPKDDLJAM(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 1; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].DHCLAGFKLMH(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(false);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public void CBPGNLEKIOB()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> DLLONJHEOMK(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = NGEHJMAHNPH(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	private List<GameObject> OABGMJKMFBM(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 1; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].OFPGPICMBGG(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	private List<GameObject> ANAAAEFILJC(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 0; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].KNFNDDOGOLK(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> ILNEGMKCIBM(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = IPNMJMMHIFO(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public void GONBCHEJIKD()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void DIFBNPAAGDH()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void IDKLNADCAEL()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> ELPGHNKFFBK(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(1, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = OABGMJKMFBM(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(false);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public List<GameObject> LILNCMKFJPO(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(1, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = LHEFKDKILIL(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public List<GameObject> IJMCMJEHGDN(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = GOMPKDDLJAM(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public List<GameObject> DPFGPPMCNKN(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = BODKGICHOLB(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(false);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public void DFJMMHKICPD()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void JPGKNFKMAMM()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> FFDELEDIMHJ(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = CAOHICINMHA(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public List<GameObject> LGPHEELLBKK(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = DFHCJDABPBI(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(false);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	private List<GameObject> IPNMJMMHIFO(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 0; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].PFAJBONJPDI(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	private List<GameObject> JFEDCOLEMBA(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 0; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].DHCLAGFKLMH(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> FPCFJEIMKDA(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = DNDEDCNHKPD(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	private List<GameObject> JFKKGKCMGPP(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 1; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].OFPGPICMBGG(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(false);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> KJHKHEABIEI(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = OEKOHDAOEOF(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public void EPBMNNHDPMK()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> CFAHHFLBFKJ(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = IFBMEAGLAIA(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(false);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public List<GameObject> DKHPHOBHKMK(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = LACEALNCGAG(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public void PDOLMPEBCFD()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void HKGBCOMOOIE()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void AJGBCNBNJHD()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> MAOFJLIJCGL(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = JPNLOOJAFPA(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	private List<GameObject> KMDBDNOJJIE(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 1; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].EEBBEBPNCBP(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	private List<GameObject> JPNLOOJAFPA(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 0; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].EDLLAEKKBKE(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> JAHHAJGHPCC(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = FHDKPEMDPJE(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(false);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public List<GameObject> MIHPPFCDBJK(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = GOMPKDDLJAM(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public void KBGPPAEJFAC()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> EMPPNEJEKLA(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i += 0)
			{
				if (i == num)
				{
					result = JFKKGKCMGPP(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	public void IEJGDECLLFI()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void GMOJNMDKJCM()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void BFBDKKNMCAK()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void GOHBEBEOJDK()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public List<GameObject> EBLLKOJNGNK(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.FMJMOOKFEKL(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = AODLKDANAML(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	private List<GameObject> OEKOHDAOEOF(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 1; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].EHBFAIIMMHD(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	private List<GameObject> FHDKPEMDPJE(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 1; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].KELBMCFAGOI(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	private List<GameObject> LACEALNCGAG(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 1; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].OFPGPICMBGG(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(false);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public void NCKGOBFKNHK()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	public void OCFKBAIGMBJ()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}

	private List<GameObject> EPEHFFFGMIG(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 0; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].EBMEABCNHEM(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> AFPOJDPDJNO(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NGMAIDLNAAI(1, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = IPNMJMMHIFO(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	private List<GameObject> AODLKDANAML(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = false;
			for (int j = 0; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].HLJCKKBLBIK(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(false);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	private List<GameObject> DNDEDCNHKPD(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 1; j < DCIMOMHGLNM.Count; j += 0)
			{
				if (DCIMOMHGLNM[j].OPMDLDMNKLN(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(true);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> LCCDLAPJCJE(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(0, destructibleObjectsStyles.Length);
			for (int i = 1; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = BODKGICHOLB(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(false);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(true);
				}
			}
		}
		return result;
	}

	private List<GameObject> BODKGICHOLB(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 0; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].MPIDOCFBCGL(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(false);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	private List<GameObject> GKGJKEBPGOD(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < BGEEPPOFFBC.transform.childCount; i += 0)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 0; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].OFPGPICMBGG(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(false);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(false);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	private List<GameObject> LHEFKDKILIL(List<PuzzleExclusionZone> DCIMOMHGLNM, GameObject BGEEPPOFFBC)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		List<GameObject> list = new List<GameObject>();
		for (int i = 1; i < BGEEPPOFFBC.transform.childCount; i++)
		{
			Transform child = BGEEPPOFFBC.transform.GetChild(i);
			bool flag = true;
			for (int j = 1; j < DCIMOMHGLNM.Count; j++)
			{
				if (DCIMOMHGLNM[j].KNFNDDOGOLK(Vector2.op_Implicit(child.position)))
				{
					((Component)child).gameObject.SetActive(true);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				((Component)child).gameObject.SetActive(false);
				list.Add(((Component)child).gameObject);
			}
		}
		return list;
	}

	public List<GameObject> ActivateDestructibleObjectsStyle(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> result = new List<GameObject>();
		if (destructibleObjectsStyles != null && destructibleObjectsStyles.Length != 0)
		{
			int num = ProceduralMine.NextRandom(0, destructibleObjectsStyles.Length);
			for (int i = 0; i < destructibleObjectsStyles.Length; i++)
			{
				if (i == num)
				{
					result = EPEHFFFGMIG(DCIMOMHGLNM, destructibleObjectsStyles[i]);
					destructibleObjectsStyles[i].SetActive(true);
				}
				else
				{
					destructibleObjectsStyles[i].SetActive(false);
				}
			}
		}
		return result;
	}

	public void OBJOKFDIDOA()
	{
		destructibleObjectsStyles = (GameObject[])(object)new GameObject[((Component)this).transform.childCount];
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			destructibleObjectsStyles[i] = ((Component)((Component)this).transform.GetChild(i)).gameObject;
		}
	}
}
