using System.Collections.Generic;
using UnityEngine;

public static class PositionCompressor
{
	public struct RectArea
	{
		public Vector2 min;

		public Vector2 max;

		public RectArea(Vector2 MPCJBPJAGKK, Vector2 ACAIKFICNFP)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			min = MPCJBPJAGKK;
			max = ACAIKFICNFP;
		}
	}

	public static List<RectArea> IAGJABMPLDG(List<Vector4> HOGCDGDBLHP)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		List<RectArea> list = new List<RectArea>();
		Vector2 mPCJBPJAGKK = default(Vector2);
		Vector2 aCAIKFICNFP = default(Vector2);
		foreach (Vector4 item in HOGCDGDBLHP)
		{
			((Vector2)(ref mPCJBPJAGKK))._002Ector(item.x, item.y);
			((Vector2)(ref aCAIKFICNFP))._002Ector(item.z, item.w);
			list.Add(new RectArea(mPCJBPJAGKK, aCAIKFICNFP));
		}
		return list;
	}

	public static List<RectArea> BKKLPHMMFPD(List<Vector2> HAEIAGKNEPC)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		HashSet<Vector2> hashSet = new HashSet<Vector2>(HAEIAGKNEPC);
		List<RectArea> list = new List<RectArea>();
		float num = 0.25f;
		while (hashSet.Count > 0)
		{
			Vector2 val = default(Vector2);
			using (HashSet<Vector2>.Enumerator enumerator = hashSet.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					val = enumerator.Current;
				}
			}
			Vector2 val2 = val;
			while (hashSet.Contains(new Vector2(val2.x + num, val2.y)))
			{
				val2.x += num;
			}
			bool flag = true;
			while (flag)
			{
				for (float num2 = val.x; num2 <= val2.x; num2 += num)
				{
					if (!hashSet.Contains(new Vector2(num2, val2.y + num)))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					val2.y += num;
				}
			}
			list.Add(new RectArea(val, val2));
			for (float num3 = val.y; num3 <= val2.y; num3 += num)
			{
				for (float num4 = val.x; num4 <= val2.x; num4 += num)
				{
					hashSet.Remove(new Vector2(num4, num3));
				}
			}
		}
		return list;
	}

	public static List<Vector4> HNGJBHDMGFF(List<RectArea> CLEIMCHAJEA)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		List<Vector4> list = new List<Vector4>();
		for (int i = 0; i < CLEIMCHAJEA.Count; i++)
		{
			list.Add(new Vector4(CLEIMCHAJEA[i].min.x, CLEIMCHAJEA[i].min.y, CLEIMCHAJEA[i].max.x, CLEIMCHAJEA[i].max.y));
		}
		return list;
	}

	public static List<Vector2> AANHMONEMJF(List<RectArea> CLEIMCHAJEA, float EJMFJABBJDF = 0.5f)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < CLEIMCHAJEA.Count; i++)
		{
			for (float num = CLEIMCHAJEA[i].min.y; num <= CLEIMCHAJEA[i].max.y; num += EJMFJABBJDF)
			{
				for (float num2 = CLEIMCHAJEA[i].min.x; num2 <= CLEIMCHAJEA[i].max.x; num2 += EJMFJABBJDF)
				{
					list.Add(new Vector2(num2, num));
				}
			}
		}
		return list;
	}
}
