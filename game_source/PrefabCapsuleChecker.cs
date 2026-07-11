using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public static class PrefabCapsuleChecker
{
	public static Collider2D[] MHNGENCMMME(GameObject MEGPBGODLIL, bool OBAHANFAIJB, bool ELGCACAMMGH = false)
	{
		List<Collider2D> list = MEGPBGODLIL.GetComponentsInChildren<Collider2D>(ELGCACAMMGH).ToList();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (!((Behaviour)list[num]).enabled)
			{
				list.RemoveAt(num);
			}
			else if (list[num].isTrigger)
			{
				list.RemoveAt(num);
			}
			else if (OBAHANFAIJB && (Object)(object)((Component)list[num]).GetComponent<DisableOnCreateNodes>() != (Object)null)
			{
				list.RemoveAt(num);
			}
			else if (((Component)list[num]).gameObject.layer != 20 && ((Component)list[num]).gameObject.layer != 21)
			{
				Debug.LogError((object)("Collider " + ((Object)((Component)list[num]).gameObject).name + " is not in the correct layer. Please set it to Map or Object. to can occupy nodes"), (Object)(object)((Component)list[num]).gameObject);
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private static bool PCGNPLFDMFO(Vector2 KJCLGNLELOF, Vector2[] JAGPOKDACII)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		int num = JAGPOKDACII.Length - 1;
		int num2 = 0;
		while (num2 < JAGPOKDACII.Length)
		{
			if (JAGPOKDACII[num2].y > KJCLGNLELOF.y != JAGPOKDACII[num].y > KJCLGNLELOF.y && KJCLGNLELOF.x < (JAGPOKDACII[num].x - JAGPOKDACII[num2].x) * (KJCLGNLELOF.y - JAGPOKDACII[num2].y) / (JAGPOKDACII[num].y - JAGPOKDACII[num2].y) + JAGPOKDACII[num2].x)
			{
				flag = !flag;
			}
			num = num2++;
		}
		return flag;
	}

	private static bool JILIKLPNBKO(Vector2 AJEAEGDOOLK, Vector2 KKANDELPDKP, CapsuleDirection2D OOPPAOMELCM, CapsuleCollider2D PMCEIPHGDKK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		Vector2 aJEAEGDOOLK = Vector2.op_Implicit(((Component)PMCEIPHGDKK).transform.TransformPoint(Vector2.op_Implicit(((Collider2D)PMCEIPHGDKK).offset)));
		float oAOHMIGILFI = ((Component)PMCEIPHGDKK).transform.eulerAngles.z * (MathF.PI / 180f);
		JBAIEBJIJIC(AJEAEGDOOLK, KKANDELPDKP, OOPPAOMELCM, 0f, out var OJDOHNDEOIM, out var PAPDDMGBCBJ);
		JBAIEBJIJIC(aJEAEGDOOLK, PMCEIPHGDKK.size, PMCEIPHGDKK.direction, oAOHMIGILFI, out var OJDOHNDEOIM2, out var PAPDDMGBCBJ2);
		float num = DMHBABHCCCI(KKANDELPDKP, OOPPAOMELCM);
		float num2 = DMHBABHCCCI(PMCEIPHGDKK.size, PMCEIPHGDKK.direction);
		return HPNLEMHLMDG(OJDOHNDEOIM, PAPDDMGBCBJ, OJDOHNDEOIM2, PAPDDMGBCBJ2) <= (num + num2) * (num + num2);
	}

	private static void JBAIEBJIJIC(Vector2 AJEAEGDOOLK, Vector2 KKANDELPDKP, CapsuleDirection2D OOPPAOMELCM, float OAOHMIGILFI, out Vector2 OJDOHNDEOIM, out Vector2 PAPDDMGBCBJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		float num = DMHBABHCCCI(KKANDELPDKP, OOPPAOMELCM);
		float num2 = (((int)OOPPAOMELCM == 0) ? Mathf.Max(0f, KKANDELPDKP.y * 0.5f - num) : Mathf.Max(0f, KKANDELPDKP.x * 0.5f - num));
		Vector2 kJCLGNLELOF = (((int)OOPPAOMELCM == 0) ? Vector2.up : Vector2.right);
		kJCLGNLELOF = KGOFFJLGKIH(kJCLGNLELOF, OAOHMIGILFI);
		OJDOHNDEOIM = AJEAEGDOOLK - kJCLGNLELOF * num2;
		PAPDDMGBCBJ = AJEAEGDOOLK + kJCLGNLELOF * num2;
	}

	public static bool EADLEPMCMFA(Vector2 DKPCJLIIIDJ, Vector2 NMIFDBJEDEH, CapsuleDirection2D HICJEJPICCM, Collider2D PMCEIPHGDKK)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		Bounds bounds = PMCEIPHGDKK.bounds;
		if (!((Bounds)(ref bounds)).Contains(Vector2.op_Implicit(DKPCJLIIIDJ)))
		{
			Bounds bounds2 = PMCEIPHGDKK.bounds;
			((Bounds)(ref bounds2)).Expand(Mathf.Max(NMIFDBJEDEH.x, NMIFDBJEDEH.y));
			if (!((Bounds)(ref bounds2)).Contains(Vector2.op_Implicit(DKPCJLIIIDJ)))
			{
				return false;
			}
		}
		CompositeCollider2D val = (CompositeCollider2D)(object)((PMCEIPHGDKK is CompositeCollider2D) ? PMCEIPHGDKK : null);
		if (val == null)
		{
			TilemapCollider2D val2 = (TilemapCollider2D)(object)((PMCEIPHGDKK is TilemapCollider2D) ? PMCEIPHGDKK : null);
			if (val2 == null)
			{
				BoxCollider2D val3 = (BoxCollider2D)(object)((PMCEIPHGDKK is BoxCollider2D) ? PMCEIPHGDKK : null);
				if (val3 == null)
				{
					CapsuleCollider2D val4 = (CapsuleCollider2D)(object)((PMCEIPHGDKK is CapsuleCollider2D) ? PMCEIPHGDKK : null);
					if (val4 == null)
					{
						CircleCollider2D val5 = (CircleCollider2D)(object)((PMCEIPHGDKK is CircleCollider2D) ? PMCEIPHGDKK : null);
						if (val5 == null)
						{
							PolygonCollider2D val6 = (PolygonCollider2D)(object)((PMCEIPHGDKK is PolygonCollider2D) ? PMCEIPHGDKK : null);
							if (val6 != null)
							{
								return HKBGAGCLPGF(DKPCJLIIIDJ, NMIFDBJEDEH, HICJEJPICCM, val6);
							}
							return false;
						}
						return MCJHKPHDKFA(DKPCJLIIIDJ, NMIFDBJEDEH, HICJEJPICCM, val5);
					}
					return JILIKLPNBKO(DKPCJLIIIDJ, NMIFDBJEDEH, HICJEJPICCM, val4);
				}
				return BPBJKPHNPHK(DKPCJLIIIDJ, NMIFDBJEDEH, HICJEJPICCM, val3);
			}
			return KKPJPPMMMOE(DKPCJLIIIDJ, val2);
		}
		return KKPJPPMMMOE(DKPCJLIIIDJ, val);
	}

	public static List<Vector2> BGDLDFLKPLC(GameObject MEGPBGODLIL, bool KBFCBFDIBLO, bool OBAHANFAIJB = true, bool JNNOJMIDMDC = false)
	{
		Collider2D[] array = MHNGENCMMME(MEGPBGODLIL, OBAHANFAIJB, JNNOJMIDMDC);
		if (array == null)
		{
			return new List<Vector2>();
		}
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < array.Length; i++)
		{
			list.AddRange(FNLIKCILPIG(MEGPBGODLIL.transform, array[i], KBFCBFDIBLO));
		}
		return list;
	}

	private static bool MCJHKPHDKFA(Vector2 AJEAEGDOOLK, Vector2 KKANDELPDKP, CapsuleDirection2D OOPPAOMELCM, CircleCollider2D FMAHDNGKHGK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)FMAHDNGKHGK).transform.TransformPoint(Vector2.op_Implicit(((Collider2D)FMAHDNGKHGK).offset)));
		float num = FMAHDNGKHGK.radius * Mathf.Max(((Component)FMAHDNGKHGK).transform.lossyScale.x, ((Component)FMAHDNGKHGK).transform.lossyScale.y);
		float num2 = DMHBABHCCCI(KKANDELPDKP, OOPPAOMELCM);
		Vector2 val2 = AJEAEGDOOLK - val;
		return ((Vector2)(ref val2)).sqrMagnitude <= (num + num2) * (num + num2);
	}

	private static Vector2 DADALKFFODC(Vector2 IMOBLFMHKOD, Transform DMBHHLKMHOH, bool PDLKFBANOLH)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if (!PDLKFBANOLH)
		{
			return IMOBLFMHKOD;
		}
		return IMOBLFMHKOD - Vector2.op_Implicit(DMBHHLKMHOH.position);
	}

	public static List<Vector2> FNLIKCILPIG(Transform DMBHHLKMHOH, Collider2D DJDHCIHLNDO, bool PDLKFBANOLH = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		Bounds bounds = DJDHCIHLNDO.bounds;
		Vector2 val = Vector2.op_Implicit(Utils.MJEACANINDN(((Bounds)(ref bounds)).min));
		bounds = DJDHCIHLNDO.bounds;
		Vector2 val2 = Vector2.op_Implicit(Utils.MJEACANINDN(((Bounds)(ref bounds)).max));
		List<Vector2> list = new List<Vector2>();
		Vector2 val3 = default(Vector2);
		for (float num = val.x; num <= val2.x; num += 0.25f)
		{
			for (float num2 = val.y; num2 <= val2.y; num2 += 0.25f)
			{
				((Vector2)(ref val3))._002Ector(num, num2);
				if (EADLEPMCMFA(val3, new Vector2(0.3f, 0.2f), (CapsuleDirection2D)1, DJDHCIHLNDO))
				{
					Vector2 item = DADALKFFODC(val3, DMBHHLKMHOH, PDLKFBANOLH);
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
		}
		return list;
	}

	private static bool HKBGAGCLPGF(Vector2 AJEAEGDOOLK, Vector2 KKANDELPDKP, CapsuleDirection2D OOPPAOMELCM, PolygonCollider2D HABMNCLJJGO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		float num = DMHBABHCCCI(KKANDELPDKP, OOPPAOMELCM);
		Vector2[] path = HABMNCLJJGO.GetPath(0);
		Vector2[] array = (Vector2[])(object)new Vector2[path.Length];
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = Vector2.op_Implicit(((Component)HABMNCLJJGO).transform.TransformPoint(Vector2.op_Implicit(path[i])));
		}
		if (PCGNPLFDMFO(AJEAEGDOOLK, array))
		{
			return true;
		}
		for (int j = 0; j < array.Length; j++)
		{
			Vector2 dPEOLFMDLAK = array[j];
			Vector2 oDNGJHPOMMK = array[(j + 1) % array.Length];
			if (OJILECOHMNG(AJEAEGDOOLK, dPEOLFMDLAK, oDNGJHPOMMK) <= num * num)
			{
				return true;
			}
		}
		return false;
	}

	private static float HPNLEMHLMDG(Vector2 CFFHOOJIGKB, Vector2 FHJNCICEKLL, Vector2 DIKGDKAKCOC, Vector2 MPJFEHMHAGA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		return Mathf.Min(new float[4]
		{
			OJILECOHMNG(CFFHOOJIGKB, DIKGDKAKCOC, MPJFEHMHAGA),
			OJILECOHMNG(FHJNCICEKLL, DIKGDKAKCOC, MPJFEHMHAGA),
			OJILECOHMNG(DIKGDKAKCOC, CFFHOOJIGKB, FHJNCICEKLL),
			OJILECOHMNG(MPJFEHMHAGA, CFFHOOJIGKB, FHJNCICEKLL)
		});
	}

	private static Vector2 KGOFFJLGKIH(Vector2 KJCLGNLELOF, float HLLDONGNCGA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2(KJCLGNLELOF.x * Mathf.Cos(HLLDONGNCGA) - KJCLGNLELOF.y * Mathf.Sin(HLLDONGNCGA), KJCLGNLELOF.x * Mathf.Sin(HLLDONGNCGA) + KJCLGNLELOF.y * Mathf.Cos(HLLDONGNCGA));
	}

	private static float DMHBABHCCCI(Vector2 KKANDELPDKP, CapsuleDirection2D OOPPAOMELCM)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)OOPPAOMELCM != 0)
		{
			return KKANDELPDKP.y * 0.5f;
		}
		return KKANDELPDKP.x * 0.5f;
	}

	private static float OJILECOHMNG(Vector2 KJCLGNLELOF, Vector2 DPEOLFMDLAK, Vector2 ODNGJHPOMMK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = ODNGJHPOMMK - DPEOLFMDLAK;
		Vector2 val2 = KJCLGNLELOF - DPEOLFMDLAK;
		float num = Mathf.Clamp01(Vector2.Dot(val2, val) / Vector2.Dot(val, val));
		Vector2 val3 = val2 - val * num;
		return ((Vector2)(ref val3)).sqrMagnitude;
	}

	private static bool KKPJPPMMMOE(Vector2 IMOBLFMHKOD, CompositeCollider2D IBODFKMJGFH)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = ((Collider2D)IBODFKMJGFH).ClosestPoint(IMOBLFMHKOD) - IMOBLFMHKOD;
		return ((Vector2)(ref val)).sqrMagnitude < 0.2f;
	}

	private static bool BPBJKPHNPHK(Vector2 AJEAEGDOOLK, Vector2 KKANDELPDKP, CapsuleDirection2D OOPPAOMELCM, BoxCollider2D JFANEFFGHHJ)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)JFANEFFGHHJ).transform.TransformPoint(Vector2.op_Implicit(((Collider2D)JFANEFFGHHJ).offset)));
		float num = ((Component)JFANEFFGHHJ).transform.eulerAngles.z * (MathF.PI / 180f);
		Vector2 val2 = KGOFFJLGKIH(AJEAEGDOOLK - val, 0f - num);
		Vector2 val3 = JFANEFFGHHJ.size * 0.5f;
		float num2 = DMHBABHCCCI(KKANDELPDKP, OOPPAOMELCM);
		Vector2 val4 = default(Vector2);
		((Vector2)(ref val4))._002Ector(Mathf.Clamp(val2.x, 0f - val3.x, val3.x), Mathf.Clamp(val2.y, 0f - val3.y, val3.y));
		Vector2 val5 = val2 - val4;
		return ((Vector2)(ref val5)).sqrMagnitude <= num2 * num2;
	}

	private static bool KKPJPPMMMOE(Vector2 IMOBLFMHKOD, TilemapCollider2D MFNKNAAHDPB)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		CompositeCollider2D composite = ((Collider2D)MFNKNAAHDPB).composite;
		if ((Object)(object)composite == (Object)null)
		{
			return false;
		}
		return KKPJPPMMMOE(IMOBLFMHKOD, composite);
	}
}
