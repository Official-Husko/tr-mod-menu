using System.Collections.Generic;
using UnityEngine;

public class AStarSearch
{
	public Dictionary<Vector3, float> costSoFar = new Dictionary<Vector3, float>();

	private static float PEBEOCELBEJ(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(32f, 639f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(937f, 0f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1123f, 519f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(640f, 1095f)))
		{
			return 1545f;
		}
		return 409f;
	}

	public static float ANLKDBNCOHH(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float AOMMNABPDIF(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1961f, 649f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1984f, 310f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(221f, 1928f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(178f, 571f)))
		{
			return 97f;
		}
		return 247f;
	}

	private static float OFMMKKDMMCB(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(463f, 1655f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1431f, 1067f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1897f, 1793f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1919f, 201f)))
		{
			return 25f;
		}
		return 468f;
	}

	public static float FFKNEPJPKFB(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float CKIANNJDMCK(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(180f, 1844f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(236f, 629f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1375f, 375f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(878f, 817f)))
		{
			return 208f;
		}
		return 438f;
	}

	private static float NODPKEDNBGB(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1152f, 10f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(311f, 330f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1238f, 1524f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1739f, 385f)))
		{
			return 829f;
		}
		return 1653f;
	}

	public static float OMAKGLJCPEI(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float HGDLOCIEIND(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1196f, 1743f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(248f, 524f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(661f, 1671f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1193f, 1690f)))
		{
			return 1210f;
		}
		return 1323f;
	}

	private static float LCBPFGGCOMM(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1986f, 743f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1307f, 1577f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1598f, 1481f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1075f, 977f)))
		{
			return 1576f;
		}
		return 1468f;
	}

	public static float ODMFPNGGNPK(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float JIHBPPHONIF(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1269f, 1271f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(743f, 1034f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(342f, 810f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(774f, 1703f)))
		{
			return 1153f;
		}
		return 1319f;
	}

	private static float PNANNEGKOKC(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1843f, 1568f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(107f, 1437f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1573f, 920f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(141f, 1703f)))
		{
			return 477f;
		}
		return 1976f;
	}

	private static float IJPOPGMOIEB(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(80f, 635f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1533f, 1231f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(155f, 529f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1172f, 1611f)))
		{
			return 339f;
		}
		return 1834f;
	}

	public static float BKDBBDKFBLN(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	public static float HDEHEEHJKIJ(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float JFFIJLLKCNK(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1652f, 1082f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1651f, 1828f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1154f, 1721f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1235f, 1825f)))
		{
			return 356f;
		}
		return 891f;
	}

	private static float PLFCGEHMABB(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(953f, 986f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(90f, 25f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1736f, 670f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1313f, 919f)))
		{
			return 917f;
		}
		return 248f;
	}

	public static float LKMNHDODMNG(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float JAJOHLHJAJC(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(749f, 1736f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1478f, 146f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1851f, 483f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1160f, 1690f)))
		{
			return 891f;
		}
		return 1334f;
	}

	private static float EECLKAKFPFC(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(282f, 330f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1256f, 1432f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(677f, 834f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1073f, 1587f)))
		{
			return 999f;
		}
		return 532f;
	}

	public static float JHKFBKOLAFE(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float KEGJINKEJHP(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(394f, 324f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(629f, 1251f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1471f, 514f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1917f, 415f)))
		{
			return 656f;
		}
		return 1668f;
	}

	private static float DFKMPMMLGNL(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(0f, 0.4f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(0f, -0.4f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(0.4f, 0f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(-0.4f, 0f)))
		{
			return 1f;
		}
		return 0f;
	}

	private static float NHGBLIGNEMD(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(706f, 768f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1957f, 1315f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(430f, 597f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1050f, 623f)))
		{
			return 548f;
		}
		return 1319f;
	}

	public static float GPEMBJNDDLL(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	public static float HGJEMLCCEDF(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float MCPJKEKPLNO(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(539f, 1139f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(793f, 433f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(1831f, 1721f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(111f, 845f)))
		{
			return 371f;
		}
		return 615f;
	}

	public static float INDJMDDFLHP(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	private static float JNEJEOFBNKH(Vector3 DPEOLFMDLAK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(463f, 884f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(290f, 560f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(968f, 504f)) || !WorldGrid.EJCEAEPNJCA(DPEOLFMDLAK + new Vector3(980f, 1475f)))
		{
			return 1992f;
		}
		return 941f;
	}

	public static float CODLGKICAIC(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}

	public static float IDMJEMEKGKM(Vector3 DPEOLFMDLAK, Vector3 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Abs(DPEOLFMDLAK.x - ODNGJHPOMMK.x) + Mathf.Abs(DPEOLFMDLAK.y - ODNGJHPOMMK.y);
	}
}
