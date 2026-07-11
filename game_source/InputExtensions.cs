using System.Collections.Generic;
using UnityEngine;

public static class InputExtensions
{
	public static Vector3 PKDHIDFHFMO(this Vector3 DPNLDLEHMHO, float NCPGNLOJGAF, float JLMAILGJNCE, float DBMMGAKEKNM)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3(float.IsNaN(NCPGNLOJGAF) ? DPNLDLEHMHO.x : NCPGNLOJGAF, float.IsNaN(JLMAILGJNCE) ? DPNLDLEHMHO.y : JLMAILGJNCE, float.IsNaN(DBMMGAKEKNM) ? DPNLDLEHMHO.z : DBMMGAKEKNM);
	}

	public static void HOOBEDNMNFK<T>(this IList<T> FEJMDAAMEKF)
	{
		int count = FEJMDAAMEKF.Count;
		int num = count - 1;
		for (int i = 0; i < num; i++)
		{
			int index = Random.Range(i, count);
			T value = FEJMDAAMEKF[i];
			FEJMDAAMEKF[i] = FEJMDAAMEKF[index];
			FEJMDAAMEKF[index] = value;
		}
	}

	public static Vector3 DDOCMLCBENK(this Vector2 DPNLDLEHMHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3(DPNLDLEHMHO.x, DPNLDLEHMHO.y, 0f);
	}

	public static int ANHKNLFMFAN(this int AODONKKHPBP, int BHOCLEENAEC, int GDPJMPHCOIK)
	{
		if (AODONKKHPBP < BHOCLEENAEC)
		{
			return BHOCLEENAEC;
		}
		if (AODONKKHPBP > GDPJMPHCOIK)
		{
			return GDPJMPHCOIK;
		}
		return AODONKKHPBP;
	}
}
