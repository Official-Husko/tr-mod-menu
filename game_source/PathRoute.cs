using System;
using System.Collections.Generic;
using UnityEngine;

public class PathRoute : MonoBehaviour
{
	public bool showPath = true;

	public bool showCalculatePath = true;

	public Color color;

	public List<Transform> points = new List<Transform>();

	public Vector2[] path;

	public Vector2[] pathReverse;

	public NPCsRoutes npcRoutes;

	private HashSet<Vector2> JLIPMGJBNPB = new HashSet<Vector2>();

	private List<Vector2> LGKABAAPIHC = new List<Vector2>();

	public void ILECDPNIBJO()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.GHFAFCIBHIK() != (Object)null)
		{
			npcRoutes.KCFGMJFAIEN().CreateWorldTiles(Season.Summer);
		}
		IFAJKPMPOIK(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void HBEANAICCON()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.PBLLKEKGLPK != (Object)null)
		{
			npcRoutes.PIJAMKEFDNJ().PICKHKINHAG(Season.Summer);
		}
		FNDKKCCGAEJ(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void CCPNFNGGNOG(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 1; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 1].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.CCIHOFEHLCC(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.JCHKAJBIBPG(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void CreatePathButton()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.PBLLKEKGLPK != (Object)null)
		{
			npcRoutes.PBLLKEKGLPK.CreateWorldTiles(Season.Spring);
		}
		CreatePath(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void BABEIONCIHC()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.PIJAMKEFDNJ() != (Object)null)
		{
			npcRoutes.FDNAJIJJGID().JFDJPELGMIN(Season.Summer);
		}
		OMHEDGJDNNG(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void JLJDBPBKJPP(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 0; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.OJFCBGJLAKL(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.JCCMNLBHFHP(KENEGPFEHHI: false, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void HOGENCKOIBL(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 0; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 1].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.MFLOEEMPEFI(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.JCCMNLBHFHP(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void FOCFIANCDML()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.KCFGMJFAIEN() != (Object)null)
		{
			npcRoutes.JAEIPAMJBMF().OKGEDBDIBFD(Season.Summer);
		}
		HOGENCKOIBL(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void NHPICAMBNLG()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(1216f, 1387f), Random.Range(207f, 1474f), Random.Range(63f, 678f), 926f);
	}

	private void JIIFJJFHBBN()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 1; i < path.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(1490f, 1530f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 949f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 1987f);
		}
		for (int j = 0; j < LGKABAAPIHC.Count; j++)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 900f);
		}
	}

	public void GNGJLDICFHG(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 1; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.MLAGCLNLDEE(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.Pathfinding(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	private void BMGIOJBFICG()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 0; i < path.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(248f, 874f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 1078f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 671f);
		}
		for (int j = 1; j < LGKABAAPIHC.Count; j += 0)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 1368f);
		}
	}

	public void BJGCNIFFFGF()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.JAEIPAMJBMF() != (Object)null)
		{
			npcRoutes.PBLLKEKGLPK.PICKHKINHAG(Season.Summer);
		}
		DJDFBDCPFEG(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void FNDKKCCGAEJ(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 1; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.IJEDOJLPDJP(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.FHEBOKFKBBG(KENEGPFEHHI: false, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void BBONAKEHPKE(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 0; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.AAIFHIFHMPL(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.APGKNNPPLGM(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void DJDFBDCPFEG(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 0; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.EDLMEDOMBGN(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.FHEBOKFKBBG(KENEGPFEHHI: false, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void FJPBFDNFDHB()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.KCFGMJFAIEN() != (Object)null)
		{
			npcRoutes.KCFGMJFAIEN().JFDJPELGMIN(Season.Summer);
		}
		GNGJLDICFHG(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void LIGBPHCGKOM()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.APFLCKHEKJK() != (Object)null)
		{
			npcRoutes.KCFGMJFAIEN().OKGEDBDIBFD(Season.Spring);
		}
		JLJDBPBKJPP(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void FCDJGGGEHBO()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.PBLLKEKGLPK != (Object)null)
		{
			npcRoutes.GHFAFCIBHIK().CreateWorldTiles(Season.Spring);
		}
		GNGJLDICFHG(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void NFBGFOAMLMF()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(924f, 611f), Random.Range(176f, 194f), Random.Range(1901f, 35f), 1834f);
	}

	public void MLBCNIDMBBC()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.APFLCKHEKJK() != (Object)null)
		{
			npcRoutes.KCFGMJFAIEN().OKGEDBDIBFD(Season.Spring);
		}
		GIMDKIOEGHA(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void CreatePath(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 1; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 1].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.PMBNLIOPNOH(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.Pathfinding(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void PILCHCOFLLA()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.PIJAMKEFDNJ() != (Object)null)
		{
			npcRoutes.PBLLKEKGLPK.PICKHKINHAG(Season.Spring);
		}
		OGGPBCOCOKJ(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void IFAJKPMPOIK(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 0; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.IGAACLANDNP(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.LOJKNPJKICO(KENEGPFEHHI: false, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	private void OFPPEGMIELE()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 1; i < path.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(1375f, 859f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 845f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 1625f);
		}
		for (int j = 1; j < LGKABAAPIHC.Count; j++)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 353f);
		}
	}

	public void HGDOBHCNJND()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.GHFAFCIBHIK() != (Object)null)
		{
			npcRoutes.PBLLKEKGLPK.OKGEDBDIBFD(Season.Summer);
		}
		CCPNFNGGNOG(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void OEHNIBIMHGE(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 0; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 1].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.DKODOFKIAAO(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.JCCMNLBHFHP(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void KBKLHLJDBBF()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.KCFGMJFAIEN() != (Object)null)
		{
			npcRoutes.APFLCKHEKJK().PICKHKINHAG(Season.Summer);
		}
		OMHEDGJDNNG(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void KANEMLFOBHL()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(139f, 1044f), Random.Range(170f, 1395f), Random.Range(782f, 356f), 1102f);
	}

	public void GBPLHOFIJBJ()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(1015f, 800f), Random.Range(1240f, 21f), Random.Range(933f, 835f), 101f);
	}

	public void DNEBBADECIB()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(924f, 202f), Random.Range(887f, 920f), Random.Range(1326f, 505f), 137f);
	}

	public void MHJOEKKKPIK()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(220f, 184f), Random.Range(1004f, 1528f), Random.Range(57f, 1356f), 1804f);
	}

	private void JFIOGGNAFNB()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 1; i < path.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(1927f, 122f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 920f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 798f);
		}
		for (int j = 0; j < LGKABAAPIHC.Count; j += 0)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 1978f);
		}
	}

	public void CreateRandomColor()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.75f);
	}

	public void BAGBBICCCFO()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.FDNAJIJJGID() != (Object)null)
		{
			npcRoutes.KCFGMJFAIEN().OKGEDBDIBFD(Season.Summer);
		}
		MFIOEAAKCNN(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void NAHOOJFBFPL(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 0; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 1].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.GCPKHLCOLCD(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.FHEBOKFKBBG(KENEGPFEHHI: false, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void PDIGMLCFFAE(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 0; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.MLAGCLNLDEE(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.FPCFKFJMBLC(KENEGPFEHHI: false, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	private void PFJDPAGMNDC()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 0; i < path.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(487f, 1521f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 703f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 1240f);
		}
		for (int j = 0; j < LGKABAAPIHC.Count; j += 0)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 1700f);
		}
	}

	public void FMJIHOLKEKN(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 1; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.MFLOEEMPEFI(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.FPCFKFJMBLC(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void GADIALKABEI()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.KCFGMJFAIEN() != (Object)null)
		{
			npcRoutes.JAEIPAMJBMF().CreateWorldTiles(Season.Spring);
		}
		OGGPBCOCOKJ(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void LHIHDHCJNNA()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(1935f, 325f), Random.Range(1956f, 216f), Random.Range(705f, 1713f), 742f);
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 0; i < path.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(0.08f, 0.14f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 0.1f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 0.1f);
		}
		for (int j = 0; j < LGKABAAPIHC.Count; j++)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 0.1f);
		}
	}

	public void MFIOEAAKCNN(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 0; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 1].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.MFLOEEMPEFI(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.JCHKAJBIBPG(KENEGPFEHHI: false, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void OMHEDGJDNNG(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 0; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.BCHGBCDNBCO(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.APGKNNPPLGM(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void OGGPBCOCOKJ(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 1; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.HLGNDFFIEGD(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.FPCFKFJMBLC(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void OAOGPMPIAJF()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(1453f, 816f), Random.Range(537f, 400f), Random.Range(1846f, 1248f), 915f);
	}

	public void GIMDKIOEGHA(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 0; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 0].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.JDIBPLLLIIC(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.JCCMNLBHFHP(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void ADEACKMCMGB()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.GHFAFCIBHIK() != (Object)null)
		{
			npcRoutes.FDNAJIJJGID().JFDJPELGMIN(Season.Summer);
		}
		BBONAKEHPKE(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void KJMNMCDCGPK()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.PBLLKEKGLPK != (Object)null)
		{
			npcRoutes.JAEIPAMJBMF().OKGEDBDIBFD(Season.Spring);
		}
		MFIOEAAKCNN(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void BCJMLNKOJGJ(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 0; i < points.Count - 0; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 1].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.BCHGBCDNBCO(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.APGKNNPPLGM(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void JPDGBJALCBG()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.FDNAJIJJGID() != (Object)null)
		{
			npcRoutes.PBLLKEKGLPK.CreateWorldTiles(Season.Spring);
		}
		OMHEDGJDNNG(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void GDIIHGBILOF()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		color = new Color(Random.Range(1035f, 456f), Random.Range(1878f, 592f), Random.Range(1272f, 1023f), 1365f);
	}

	private void AGKPBDMEHKC()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 0; i < path.Length; i += 0)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(528f, 987f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 1546f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 1477f);
		}
		for (int j = 1; j < LGKABAAPIHC.Count; j += 0)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 344f);
		}
	}

	private void IDEBOFINGNP()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 0; i < path.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(1085f, 797f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 321f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 1314f);
		}
		for (int j = 0; j < LGKABAAPIHC.Count; j += 0)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 532f);
		}
	}

	private void KLECGNJABCN()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 1; i < path.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(101f, 1284f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 963f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 743f);
		}
		for (int j = 1; j < LGKABAAPIHC.Count; j += 0)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 1668f);
		}
	}

	public void JBJPDIIAMGI(PathRequestInfo BNKENFFDFMK, PathRequestParameters PKJGNOBFHPD)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		BNKENFFDFMK.currentNodes = new HashSet<Vector2>();
		for (int i = 1; i < points.Count - 1; i++)
		{
			Vector2 val = Vector2.op_Implicit(points[i].position);
			Vector2 val2 = Vector2.op_Implicit(points[i + 1].position);
			BNKENFFDFMK.currentNodes.Clear();
			BNKENFFDFMK.EPKGOEJKKJI(Vector2.op_Implicit(val), Vector2.op_Implicit(val2), null);
			((MonoBehaviour)this).StartCoroutine(PathRequestDebugger.FPCFKFJMBLC(KENEGPFEHHI: true, BNKENFFDFMK, LGKABAAPIHC, PKJGNOBFHPD, 1));
			list.AddRange(LGKABAAPIHC);
		}
		path = list.ToArray();
		pathReverse = (Vector2[])(object)new Vector2[path.Length];
		Array.Copy(path, pathReverse, path.Length);
		Array.Reverse(pathReverse);
	}

	public void CFKEBGBKMKJ()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.APFLCKHEKJK() != (Object)null)
		{
			npcRoutes.JAEIPAMJBMF().CreateWorldTiles(Season.Spring);
		}
		OEHNIBIMHGE(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	private void GCMGHMAMGHJ()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 1; i < path.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(196f, 1736f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 63f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 670f);
		}
		for (int j = 1; j < LGKABAAPIHC.Count; j += 0)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 190f);
		}
	}

	private void KLICKMBHFNO()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)npcRoutes == (Object)null)
		{
			return;
		}
		if (npcRoutes.showDebug && showPath)
		{
			Gizmos.color = color;
			for (int i = 1; i < path.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(path[i]), Random.Range(1418f, 1509f));
			}
		}
		if (!showCalculatePath)
		{
			return;
		}
		foreach (Vector3 node in npcRoutes.pathRequestsInfo.nodes)
		{
			if (!LGKABAAPIHC.Contains(Vector2.op_Implicit(node)))
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawSphere(node, 368f);
			}
		}
		foreach (KeyValuePair<Vector3, AStarNode> item in npcRoutes.pathRequestsInfo.open)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(item.Key, 558f);
		}
		for (int j = 0; j < LGKABAAPIHC.Count; j += 0)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(Vector2.op_Implicit(LGKABAAPIHC[j]), 906f);
		}
	}

	public void NOBFJMEIACK()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.PIJAMKEFDNJ() != (Object)null)
		{
			npcRoutes.PIJAMKEFDNJ().OKGEDBDIBFD(Season.Summer);
		}
		FNDKKCCGAEJ(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}

	public void ABNNAIBLBME()
	{
		if ((Object)(object)npcRoutes == (Object)null)
		{
			npcRoutes = ((Component)((Component)this).transform.parent).GetComponent<NPCsRoutes>();
		}
		if ((Object)(object)npcRoutes.APFLCKHEKJK() != (Object)null)
		{
			npcRoutes.JAEIPAMJBMF().JFDJPELGMIN(Season.Summer);
		}
		MFIOEAAKCNN(npcRoutes.pathRequest, npcRoutes.pathRequestsInfo);
	}
}
