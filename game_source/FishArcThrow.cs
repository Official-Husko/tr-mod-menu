using UnityEngine;

public static class FishArcThrow
{
	public struct CubicArc
	{
		public Vector2 p0;

		public Vector2 p1;

		public Vector2 p2;

		public Vector2 p3;

		public float totalTime;

		public float tCut;
	}

	public static Vector2 EKKHFDENDPH(in CubicArc DPEOLFMDLAK, float ECJCGAAGDFB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Clamp01(ECJCGAAGDFB / DPEOLFMDLAK.totalTime);
		float num2 = 1f - num;
		return num2 * num2 * num2 * DPEOLFMDLAK.p0 + 3f * num2 * num2 * num * DPEOLFMDLAK.p1 + 3f * num2 * num * num * DPEOLFMDLAK.p2 + num * num * num * DPEOLFMDLAK.p3;
	}

	public static CubicArc DEDHBCHLDEB(Vector2 MDMAAIKFBFB, Vector2 CFGAIGMBCDC, float MELFALGIDJJ, float DCIOCGFJFDB, float GKLHHHHGAFC, float MCDLFDDNCCH, float DJEPMPDKCIO, float EILAMMIMOGC = 0f)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		MCDLFDDNCCH = Mathf.Clamp01(MCDLFDDNCCH);
		float num = MCDLFDDNCCH;
		float num2 = 1f - num;
		CubicArc cubicArc = default(CubicArc);
		cubicArc.p0 = MDMAAIKFBFB;
		cubicArc.p3 = CFGAIGMBCDC;
		cubicArc.totalTime = Mathf.Max(0.01f, MELFALGIDJJ);
		cubicArc.tCut = MCDLFDDNCCH;
		CubicArc DPEOLFMDLAK = cubicArc;
		float num3 = (MDMAAIKFBFB.x + CFGAIGMBCDC.x) * 0.5f + EILAMMIMOGC;
		float num4 = Mathf.Max(MDMAAIKFBFB.y, CFGAIGMBCDC.y);
		DPEOLFMDLAK.p1 = new Vector2(num3, num4 + DJEPMPDKCIO);
		Vector2 val = new Vector2(DCIOCGFJFDB, GKLHHHHGAFC);
		float num5 = 3f * num2 * num * num;
		if (Mathf.Abs(num5) < 1E-05f)
		{
			num5 = 1E-05f;
		}
		Vector2 val2 = val - num2 * num2 * num2 * DPEOLFMDLAK.p0 - 3f * (num2 * num2) * num * DPEOLFMDLAK.p1 - num * num * num * DPEOLFMDLAK.p3;
		DPEOLFMDLAK.p2 = val2 / num5;
		if (!IPOFGLGLJIC(in DPEOLFMDLAK, MCDLFDDNCCH))
		{
			DPEOLFMDLAK.tCut = Mathf.Min(0.95f, MCDLFDDNCCH + 0.05f);
			num = DPEOLFMDLAK.tCut;
			num2 = 1f - num;
			num5 = 3f * num2 * num * num;
			if (Mathf.Abs(num5) < 1E-05f)
			{
				num5 = 1E-05f;
			}
			val2 = new Vector2(DCIOCGFJFDB, GKLHHHHGAFC) - num2 * num2 * num2 * DPEOLFMDLAK.p0 - 3f * (num2 * num2) * num * DPEOLFMDLAK.p1 - num * num * num * DPEOLFMDLAK.p3;
			DPEOLFMDLAK.p2 = val2 / num5;
		}
		return DPEOLFMDLAK;
	}

	public static bool NMPHLFNJPMA(in CubicArc DPEOLFMDLAK, float ECJCGAAGDFB, float ACIEFOFPKBG)
	{
		float num = Mathf.Clamp01(ECJCGAAGDFB / DPEOLFMDLAK.totalTime);
		float num2 = 0.5f * ACIEFOFPKBG / Mathf.Max(0.0001f, DPEOLFMDLAK.totalTime);
		return Mathf.Abs(num - DPEOLFMDLAK.tCut) <= num2;
	}

	public static bool IPOFGLGLJIC(in CubicArc DPEOLFMDLAK, float NHGGJNPBIFG)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Clamp01(NHGGJNPBIFG);
		float num2 = 1f - num;
		return (3f * num2 * num2 * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 6f * num2 * num * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 3f * num * num * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2)).y < 0f;
	}
}
