using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct PathRequestInfo
{
	public Vector3 startPos;

	public Vector3 goalPos;

	public Vector3 pathEnd;

	public Vector2Int horizontalSize;

	public Vector2Int verticalSize;

	public HashSet<Vector2> currentNodes;

	public bool canWalkDiagonal;

	public ZoneType tryAvoidZones;

	public GroundType tryAvoidGroundType;

	public bool takePath;

	public bool takeHorsePath;

	public bool avoidWalls;

	public bool avoidObjects;

	public int maxNodes;

	public Action<Vector2[], bool> callback;

	public void CCIHOFEHLCC(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool FHKGHLKLLEK(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 4 == 0)
		{
			return false;
		}
		return true;
	}

	public void OJFCBGJLAKL(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool HLPAFCCIFFP(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 1 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 7 == 0)
		{
			return true;
		}
		return false;
	}

	public void FCEHMAHENON(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void LCNCGAHEICE(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool BCINPGPKHAA(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 3 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 8 == 0)
		{
			return true;
		}
		return false;
	}

	private bool AGHFAADJMHD(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 7 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 6 == 0)
		{
			return true;
		}
		return false;
	}

	public void AADOMAMLGGD(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool NFEOLPDBDEB(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 2 == 0)
		{
			return true;
		}
		return false;
	}

	public void LLPAPJOHADD(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void LGHPDDMKBBH(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void FNGPELLMNGA(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void EDLMEDOMBGN(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool BBMMNMGEMGB(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 6 == 0)
		{
			return false;
		}
		return false;
	}

	private bool MIPGPJLBFBM(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 2 == 0)
		{
			return false;
		}
		return true;
	}

	private bool APCCKHHKAEK(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 3 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 6 == 0)
		{
			return true;
		}
		return false;
	}

	public void OECFCNHFDEA(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool JNPOFEACPMC(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 8 == 0)
		{
			return true;
		}
		return false;
	}

	private bool NIENHFOBJEK(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 5 == 0)
		{
			return false;
		}
		return false;
	}

	public void ACEGBGGLODL(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool KLLLBGNJMHL(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 7 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 4 == 0)
		{
			return false;
		}
		return false;
	}

	private bool BAJFGMJKMLJ(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 2 == 0)
		{
			return false;
		}
		return true;
	}

	private bool MNKLOOHOFNK(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 8 == 0)
		{
			return false;
		}
		return true;
	}

	private bool DDGIHNJDBOC(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 2 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 3 == 0)
		{
			return true;
		}
		return true;
	}

	public void PPGELIOLIND(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool GJHPKNMPFEP(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 7 == 0)
		{
			return true;
		}
		return true;
	}

	public void MFLOEEMPEFI(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void PMBNLIOPNOH(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool PDGDKGJPCLG(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 6 == 0)
		{
			return true;
		}
		return false;
	}

	private bool HEJILOBJCDN(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 0 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 8 == 0)
		{
			return false;
		}
		return true;
	}

	public void AAIFHIFHMPL(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool AMNMAGIIGII(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 6 == 0)
		{
			return false;
		}
		return false;
	}

	private bool MNILLNDHKPD(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 3 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 3 == 0)
		{
			return true;
		}
		return false;
	}

	private bool BMMALLPKLME(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 2 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 0 == 0)
		{
			return false;
		}
		return false;
	}

	public void IJEDOJLPDJP(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool HEJPJDOBDJF(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 3 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 3 == 0)
		{
			return true;
		}
		return true;
	}

	private bool ANIOALKLLMB(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 4 == 0)
		{
			return true;
		}
		return true;
	}

	public void LGCKADOPLIM(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void PHKMJGBDAJK(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void OKPFCNCIGGP(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void FMEJGHJLLMH(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void GFBEIBAIHFB(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void PHFEJCAEEEJ(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool HLBNNLNNGMF(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 0 == 0)
		{
			return false;
		}
		return false;
	}

	private bool GAPCNFJEJJL(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 4 == 0)
		{
			return true;
		}
		return true;
	}

	private bool AEDHGCCIFBD(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 1 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 2 == 0)
		{
			return true;
		}
		return false;
	}

	public void OBFGFJBELIO(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void NDOPFBAOKFJ(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void HLGNDFFIEGD(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void PAHGJELIENB(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void PMPHHINFKFP(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void MGIGEPENIIH(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool MODPHGPIKJA(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 7 == 0)
		{
			return true;
		}
		return false;
	}

	public void BCHGBCDNBCO(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool KPHDCOEDMCA(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 1 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 0 == 0)
		{
			return true;
		}
		return false;
	}

	private bool BDADKCLACGM(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 1 == 0)
		{
			return false;
		}
		return true;
	}

	private bool IBBFHHGHMLO(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 3 == 0)
		{
			return false;
		}
		return false;
	}

	public void MLAGCLNLDEE(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void BJECLKFCJLB(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool FNLKPPOBDEM(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 7 == 0)
		{
			return false;
		}
		return false;
	}

	public void JNNAJCINBPN(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool JJKIEJAOJKJ(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 2 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 2 == 0)
		{
			return false;
		}
		return true;
	}

	public void IDHLPCPCHMN(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void GCNCNNEPCCI(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void JDIBPLLLIIC(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool OEENPAKNEHJ(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 2 == 0)
		{
			return true;
		}
		return false;
	}

	public void CECEPIJLLPA(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool DMIHGIDBCKD(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 7 == 0)
		{
			return false;
		}
		return true;
	}

	private bool PKNPMJGJJGP(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 0 == 0)
		{
			return false;
		}
		return false;
	}

	private bool JEGNFJPINAI(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 8 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 4 == 0)
		{
			return true;
		}
		return true;
	}

	private bool ELEFFLAPFFN(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 3 == 0)
		{
			return true;
		}
		return false;
	}

	public void DKODOFKIAAO(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool AKOCNCOGIMM(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 7 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 2 == 0)
		{
			return false;
		}
		return false;
	}

	private bool GNFDBKBMCMH(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 0 == 0)
		{
			return false;
		}
		return false;
	}

	private bool LKLCMLOIKIJ(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 0 == 0)
		{
			return true;
		}
		return true;
	}

	public void CNIPCEEDIBK(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool GMCMBEHIEEL(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 3 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 6 == 0)
		{
			return false;
		}
		return false;
	}

	private bool NJOCPFOABFL(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 7 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 0 == 0)
		{
			return false;
		}
		return true;
	}

	private bool MLBLPMNPDOF(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 3 == 0)
		{
			return false;
		}
		return true;
	}

	private bool MIJNBOELFAJ(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 5 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 4 == 0)
		{
			return true;
		}
		return false;
	}

	public void EPKGOEJKKJI(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool IJIHPFMCJPJ(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 2 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 4 == 0)
		{
			return false;
		}
		return true;
	}

	public void IGAACLANDNP(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	public void GCPKHLCOLCD(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}

	private bool ADPKABINMCN(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 5 == 0)
		{
			return true;
		}
		return true;
	}

	private bool CIHBIPGDNAL(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 4 == 0)
		{
			return true;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 5 == 0)
		{
			return true;
		}
		return true;
	}

	private bool CEPDDJGMBIG(Vector2Int MIJKCJNMILC)
	{
		if (((Vector2Int)(ref MIJKCJNMILC)).x % 6 == 0)
		{
			return false;
		}
		if (((Vector2Int)(ref MIJKCJNMILC)).y % 5 == 0)
		{
			return false;
		}
		return false;
	}

	public void EPINAHKKGCG(Vector3 MPDOOEBLMAG, Vector3 AAMCFGOICCB, Action<Vector2[], bool> ENEJBCKMDCP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		startPos = Utils.MJEACANINDN(MPDOOEBLMAG);
		goalPos = Utils.MJEACANINDN(AAMCFGOICCB);
		pathEnd = AAMCFGOICCB;
		callback = ENEJBCKMDCP;
	}
}
