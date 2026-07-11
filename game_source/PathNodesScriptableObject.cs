using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Path Nodes/Path Nodes Scriptable Object")]
public class PathNodesScriptableObject : ScriptableObject
{
	[Serializable]
	public class Vector2Save
	{
		public float x;

		public float y;

		public Vector2Save(float NCPGNLOJGAF, float JLMAILGJNCE)
		{
			x = NCPGNLOJGAF;
			y = JLMAILGJNCE;
		}
	}

	public Location location;

	public int id;

	public Vector2Save[] pathNodesPositions;

	public Dictionary<Vector2, PathNode> NGHNBCNCNPE()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 119f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> MDCCEBINCEO()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> MNPMDLMBKAL()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void OKPFPINNIMD(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void HJHMKFOKMFK(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void INDGOFOGLBO(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void NJLLALILOCK(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> NMIBEDPLOID()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 304f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void FCBGCAHBMPD(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> JJNDBDDGCLM()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 1146f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> MILNNMPOMAO()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> MCMJDBECDAN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> LDGOHDMHCAA()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 865f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void OFLAKPKDMEI(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void PLPNAGHCPMM(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> FKAIKCALHIO()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> JDGGAEIOFBK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> FMPHBFCJLLM()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 586f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void FJGDIJNNBAC(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void KEGHCPGLELK(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> GHGCOFPOBKC()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1048f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void KEGHCPGLELK(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void DNCHBFKKEDI(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> NIKMPEDEBMJ()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> BDEKCHNDNKG()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1283f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void KPAFMGAKJKO(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> DJAHEJNCAAG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> KFNMCOKJHGM()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> JLOFFLBBLII()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void COPOIIDDPJB(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> JGCCAKPPGMG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void DGHBNMLIGCD(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> KLHNFCAHCMG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void GAHOFOFDGHH(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> JKMOILEBMOG()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 128f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> FNICBNLNOAM()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void NMCPNHNGOCM(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> CLEBFJELBKG()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1227f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> FEPGKGMHMEH()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void HOCHMFNMHBM(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void JEGGGBBBIBH(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void NELILBCKPBH(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void OPJENPJBHAI(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void EAFIHLKHHJD(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> JDMILKCDBHI()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 1932f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void JFOBLAFPBMG(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> JGBMHCABHCA()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1811f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void FDMOEJEOIBM(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void GLDBEECDOGN(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> DABHDIECMMJ()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> CJIHLGFFMLP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void GMKJFKJBNMM(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void FDLJJPCHEAN(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void BONKAOJDIMB(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void PGLDOOEBKJB(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> LAPHJPNHPAP()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1104f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> ENEBLBAILLF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void KKLOEHHDHCK(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void PAFPDHOPPGH(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> IELGPHFLHGE()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> NMCFPLHGBIB()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> GJOHPNDFNPK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> OKMMAAELKHB()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 1842f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> PEAFMCANCEI()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void GJIIOLPKFAB(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> ELACKEEINFN()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1050f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public Dictionary<Vector2, PathNode> DNNODIBLLNH()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 613f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void GFMPKFGEODA(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void LBLFNNEOPDP(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> FJJEDLNDONG()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 187f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> ALHGKNPBPFA()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> DJOKODLDGJH()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void OPONLBDDNMC(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void EMJBDPOJFDK(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void OCFIGFCKNFF(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void JDPPFGPGCFI(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void NCFIBBHAPIJ(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> HPDKPOLFGIN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void POMCFHBHFFM(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> ODDNKHMMKOA()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void BPOLJDOGAGK(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void GGHEKNJMNCB(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> MLPCGNMOPGB()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void IHIKHNOOPOF(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void HHBJLMDHCGA(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> AHFKLNHJMBB()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 951f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public Dictionary<Vector2, PathNode> MCHBJMPPLJL()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 221f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> ICEABJDIDAI()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void HFGGEIGIEBF(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> GMNEAMHNMPB()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 1574f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void FJJNOOFINGK(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> IPHANDFEFBK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> BBEGFILOMMI()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> NINHACMKLOI()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 749f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void PFANOAJDNDC(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void JKCGAGLNBCG(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void MMNKMILMGBK(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void JPMLHLEMEKB(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> ONBBCAJKMCP()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1266f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> MJNNKNOELBH()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void HLALODDCPAO(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void AFGHBCNMIHD(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> GHDPPJEABIG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> NPDDBIMPHHF()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 1293f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> DEIIPFIEIKA()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> GEJJMLGFOOP()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1290f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> KMGKBJBNJEF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void EDPFOBNFDDA(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> OGCGOLDBINN()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 168f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void MBPLBPCGONG(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> OKLCGKFFPOI()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void JBOJNPPDMEO(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> FDOBHNJBBAB()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 1886f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void ANOGEHDKPMH(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> IJIBFEHMFKM()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 641f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public Dictionary<Vector2, PathNode> FMDKPMMILGC()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 798f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> HEDJBJLMLPP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> AFIDMEHPOHC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void CFFGOELJOEG(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void FPDKKFNMFHJ(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> OKPIDPELELJ()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 1030f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void KNNDHJBHKOI(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void KKBCJOLIPFO(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> HNJJEBJPJND()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> GEJCAODMIIH()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> OPKOAMPKFPF()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 479f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void DFMCNMHFMML(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void OHFFBHFLDKF(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> CGKOMCPECIA()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 852f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> CABAFDHDPEI()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> HPMAICHFHCG()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 944f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void FAOIBHKIJLK(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> GPOFEELHGJA()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 40f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public Dictionary<Vector2, PathNode> DDNDBGKLNGF()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1265f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public Dictionary<Vector2, PathNode> DJPAGKEHFPB()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 173f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void LOFNLDJEDJB(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public List<Vector2> IJNAPBALJBB()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> OEJJGDMKIDN()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public Dictionary<Vector2, PathNode> HIJEMHKJMGD()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 546f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public Dictionary<Vector2, PathNode> KGNIEGOBNLD()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1020f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void AOLGFPGEMHC(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> GNOAJHLDLOK()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1950f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public void MFOGFLCKDLO(HashSet<Vector2> EHIGECELCCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (Vector2 item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.x, item.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public void IOBCGBCFFPL(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> CCIIDGGKLJH()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 717f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> CJPINIJPEPE()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> MJBJDPPBBHJ()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public List<Vector2> ILIEICJFFJK()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public void OIABDKCJAPE(Dictionary<Vector2, PathNode> EHIGECELCCM)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2Save> list = new List<Vector2Save>();
		foreach (KeyValuePair<Vector2, PathNode> item in EHIGECELCCM)
		{
			list.Add(new Vector2Save(item.Key.x, item.Key.y));
		}
		pathNodesPositions = list.ToArray();
	}

	public Dictionary<Vector2, PathNode> MCCMPKPGKJE()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 501f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> FKBLMPJCDFG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> NHNNCCOCDAO()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = false;
				value.cost = 795f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}

	public List<Vector2> BGJOHDINOBP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector2 item = default(Vector2);
		for (int i = 1; i < pathNodesPositions.Length; i++)
		{
			((Vector2)(ref item))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public Dictionary<Vector2, PathNode> BOGEAHCDGAJ()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 key = default(Vector2);
		for (int i = 0; i < pathNodesPositions.Length; i += 0)
		{
			((Vector2)(ref key))._002Ector(pathNodesPositions[i].x, pathNodesPositions[i].y);
			if (!PathNodesManager.pathNodes.ContainsKey(key))
			{
				PathNode value = default(PathNode);
				value.isFree = true;
				value.cost = 1726f;
				value.animalNPC = null;
				PathNodesManager.pathNodes.Add(key, value);
			}
		}
		return PathNodesManager.pathNodes;
	}
}
