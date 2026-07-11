using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public static class Tweener
{
	[CompilerGenerated]
	private sealed class JMMCCFDNGFI
	{
		public Transform target;

		internal void EODCNHMMIFP(Vector3 v)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			target.position = v;
		}

		internal Vector3 DBIMIFCKMJE()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return target.position;
		}
	}

	[CompilerGenerated]
	private sealed class OJJKIIPNFLL
	{
		public float startValue;

		internal float GMLHICNDJPN()
		{
			return startValue;
		}
	}

	[CompilerGenerated]
	private sealed class KDPLPOCCBKB
	{
		public Transform target;

		internal void OKMDNCAJAKG(Vector3 v)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			target.localPosition = v;
		}

		internal Vector3 ANDEKJOEAAG()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return target.localPosition;
		}
	}

	[CompilerGenerated]
	private sealed class PCNNOPLPFMF
	{
		public Transform target;

		internal Vector3 FJKFPCFIHGE()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return target.localScale;
		}

		internal void AHJNOKLKIDJ(Vector3 v)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			target.localScale = v;
		}
	}

	[CompilerGenerated]
	private sealed class KNMCLJPFFIF
	{
		public Transform target;

		internal Quaternion HODEKLNIPGI()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return target.rotation;
		}

		internal void BFHLLCOFPFK(Quaternion q)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			target.rotation = q;
		}
	}

	[CompilerGenerated]
	private sealed class HJKNCCEFKDC
	{
		public SpriteRenderer sr;

		internal void FLOMEKNCLGO(float t)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			Color color = sr.color;
			color.a = t;
			sr.color = color;
		}

		internal float DDPKBCNMHNO()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return sr.color.a;
		}
	}

	[CompilerGenerated]
	private sealed class GCKDDPGJCMA
	{
		public CanvasGroup cg;

		internal void FLOMEKNCLGO(float t)
		{
			cg.alpha = t;
		}

		internal float DDPKBCNMHNO()
		{
			return cg.alpha;
		}
	}

	[CompilerGenerated]
	private sealed class OJILNDHPAHI
	{
		public Graphic graphic;

		internal void FLOMEKNCLGO(float t)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			Color color = graphic.color;
			color.a = t;
			graphic.color = color;
		}

		internal float DDPKBCNMHNO()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return graphic.color.a;
		}
	}

	[CompilerGenerated]
	private sealed class PIPNNPOCCKO
	{
		public SpriteRenderer sr;

		internal void IJAAENAKAMD(Color c)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			sr.color = c;
		}

		internal Color IJPHMINCLGI()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return sr.color;
		}
	}

	[CompilerGenerated]
	private sealed class LJCCEEPKJMF
	{
		public Graphic graphic;

		internal Color IJPHMINCLGI()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return graphic.color;
		}

		internal void IJAAENAKAMD(Color c)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			graphic.color = c;
		}
	}

	public static TweenHandle LBJBKOEBOAD(Transform AEGIODEOOIJ, Vector3 BMEBKODLPLF, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.EaseOutQuad, Action IFHEEKLEFNE = null)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(LJNPLHKBKPG(delegate(Vector3 v)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AEGIODEOOIJ.localScale = v;
		}, () => AEGIODEOOIJ.localScale, BMEBKODLPLF, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle FPNKDMJIALH(Action<float> FFKNIHPCAEM, float LIALPHCJOOK, float BMEBKODLPLF, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.Linear, Action IFHEEKLEFNE = null)
	{
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(JKMDCGPADBK(FFKNIHPCAEM, () => LIALPHCJOOK, BMEBKODLPLF, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle BHLJGCKKONF(SpriteRenderer ECOGJIGAMMA, Color BKCBPDKGJCF, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.Linear, Action IFHEEKLEFNE = null)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(IDPDOBFOFOO(delegate(Color c)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			ECOGJIGAMMA.color = c;
		}, () => ECOGJIGAMMA.color, BKCBPDKGJCF, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle MLGKDJMJOML(CanvasGroup KHGHCANNJFI, float ABOMBEFIHFE, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.Linear, Action IFHEEKLEFNE = null)
	{
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(JKMDCGPADBK(delegate(float t)
		{
			KHGHCANNJFI.alpha = t;
		}, () => KHGHCANNJFI.alpha, ABOMBEFIHFE, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	private static IEnumerator ELNBNEAAJGN(Transform AEGIODEOOIJ, float OMHCOLMFGNJ, float JKLGEPEIEKF, int OFGKNMOPHIK, TweenHandle FAMHLOBLCFP, Action IFHEEKLEFNE)
	{
		Vector3 originalPos = AEGIODEOOIJ.localPosition;
		float elapsed = 0f;
		float interval = OMHCOLMFGNJ / (float)OFGKNMOPHIK;
		while (elapsed < OMHCOLMFGNJ)
		{
			if (FAMHLOBLCFP.ANANJKCMFCA)
			{
				AEGIODEOOIJ.localPosition = originalPos;
				yield break;
			}
			float num = 1f - elapsed / OMHCOLMFGNJ;
			Vector3 val = Random.insideUnitSphere * JKLGEPEIEKF * num;
			val.z = 0f;
			AEGIODEOOIJ.localPosition = originalPos + val;
			elapsed += interval;
			yield return (object)new WaitForSeconds(interval);
		}
		if (!FAMHLOBLCFP.ANANJKCMFCA)
		{
			AEGIODEOOIJ.localPosition = originalPos;
			IFHEEKLEFNE?.Invoke();
		}
	}

	private static float GMFLNGDIHPL(float DCGBADKLANM)
	{
		if (DCGBADKLANM < 0.36363637f)
		{
			return 7.5625f * DCGBADKLANM * DCGBADKLANM;
		}
		if (DCGBADKLANM < 0.72727275f)
		{
			return 7.5625f * (DCGBADKLANM -= 0.54545456f) * DCGBADKLANM + 0.75f;
		}
		if (DCGBADKLANM < 0.90909094f)
		{
			return 7.5625f * (DCGBADKLANM -= 0.8181818f) * DCGBADKLANM + 0.9375f;
		}
		return 7.5625f * (DCGBADKLANM -= 21f / 22f) * DCGBADKLANM + 63f / 64f;
	}

	private static IEnumerator JKMDCGPADBK(Action<float> FFKNIHPCAEM, Func<float> LGCHMGMLGOJ, float DBACIMHFEKD, float OMHCOLMFGNJ, EaseType CMDDJMOKALH, TweenHandle FAMHLOBLCFP, Action IFHEEKLEFNE)
	{
		float start = LGCHMGMLGOJ();
		float elapsed = 0f;
		while (elapsed < OMHCOLMFGNJ)
		{
			if (FAMHLOBLCFP.ANANJKCMFCA)
			{
				yield break;
			}
			elapsed += Time.deltaTime;
			FFKNIHPCAEM(Mathf.LerpUnclamped(start, DBACIMHFEKD, AAFMLNNBILN(CMDDJMOKALH, elapsed / OMHCOLMFGNJ)));
			yield return null;
		}
		if (!FAMHLOBLCFP.ANANJKCMFCA)
		{
			FFKNIHPCAEM(DBACIMHFEKD);
			IFHEEKLEFNE?.Invoke();
		}
	}

	public static TweenHandle MLGKDJMJOML(Graphic PHKEEOJODAE, float ABOMBEFIHFE, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.Linear, Action IFHEEKLEFNE = null)
	{
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(JKMDCGPADBK(delegate(float t)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			Color color = PHKEEOJODAE.color;
			color.a = t;
			PHKEEOJODAE.color = color;
		}, () => PHKEEOJODAE.color.a, ABOMBEFIHFE, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle NOAJGMLHMIH(Transform AEGIODEOOIJ, Vector3 BMEBKODLPLF, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.EaseOutQuad, Action IFHEEKLEFNE = null)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(LJNPLHKBKPG(delegate(Vector3 v)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AEGIODEOOIJ.localPosition = v;
		}, () => AEGIODEOOIJ.localPosition, BMEBKODLPLF, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle MLGKDJMJOML(SpriteRenderer ECOGJIGAMMA, float ABOMBEFIHFE, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.Linear, Action IFHEEKLEFNE = null)
	{
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(JKMDCGPADBK(delegate(float t)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			Color color = ECOGJIGAMMA.color;
			color.a = t;
			ECOGJIGAMMA.color = color;
		}, () => ECOGJIGAMMA.color.a, ABOMBEFIHFE, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle HLJMGIALFAN(Transform AEGIODEOOIJ, Vector3 BMEBKODLPLF, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.EaseOutQuad, Action IFHEEKLEFNE = null)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(LJNPLHKBKPG(delegate(Vector3 v)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AEGIODEOOIJ.position = v;
		}, () => AEGIODEOOIJ.position, BMEBKODLPLF, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle BHLJGCKKONF(Graphic PHKEEOJODAE, Color BKCBPDKGJCF, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.Linear, Action IFHEEKLEFNE = null)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(IDPDOBFOFOO(delegate(Color c)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			PHKEEOJODAE.color = c;
		}, () => PHKEEOJODAE.color, BKCBPDKGJCF, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	private static IEnumerator MNCJAAIMPCG(Action<Quaternion> FFKNIHPCAEM, Func<Quaternion> LGCHMGMLGOJ, Quaternion DBACIMHFEKD, float OMHCOLMFGNJ, EaseType CMDDJMOKALH, TweenHandle FAMHLOBLCFP, Action IFHEEKLEFNE)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Quaternion start = LGCHMGMLGOJ();
		float elapsed = 0f;
		while (elapsed < OMHCOLMFGNJ)
		{
			if (FAMHLOBLCFP.ANANJKCMFCA)
			{
				yield break;
			}
			elapsed += Time.deltaTime;
			FFKNIHPCAEM(Quaternion.LerpUnclamped(start, DBACIMHFEKD, AAFMLNNBILN(CMDDJMOKALH, elapsed / OMHCOLMFGNJ)));
			yield return null;
		}
		if (!FAMHLOBLCFP.ANANJKCMFCA)
		{
			FFKNIHPCAEM(DBACIMHFEKD);
			IFHEEKLEFNE?.Invoke();
		}
	}

	private static IEnumerator EIBCLHJBIHP(float FLHBPHPKIML, Action AABDPKCDEKB, TweenHandle FAMHLOBLCFP)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		if (!FAMHLOBLCFP.ANANJKCMFCA)
		{
			AABDPKCDEKB?.Invoke();
		}
	}

	public static TweenHandle IMANLCEPDNI(Transform AEGIODEOOIJ, float OMHCOLMFGNJ, float JKLGEPEIEKF = 0.3f, int OFGKNMOPHIK = 10, Action IFHEEKLEFNE = null)
	{
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(ELNBNEAAJGN(AEGIODEOOIJ, OMHCOLMFGNJ, JKLGEPEIEKF, OFGKNMOPHIK, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle IOCPBAENGOI(Transform AEGIODEOOIJ, float AIOMDOECNJJ, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.EaseOutBack, Action IFHEEKLEFNE = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		Vector3 localScale = AEGIODEOOIJ.localScale;
		Vector3 hLNPJOMCJKG = localScale * (1f + AIOMDOECNJJ);
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(HKPNDFMLKGI(AEGIODEOOIJ, localScale, hLNPJOMCJKG, OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	public static TweenHandle LBJBKOEBOAD(Transform AEGIODEOOIJ, float BMEBKODLPLF, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.EaseOutQuad, Action IFHEEKLEFNE = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return LBJBKOEBOAD(AEGIODEOOIJ, Vector3.one * BMEBKODLPLF, OMHCOLMFGNJ, CMDDJMOKALH, IFHEEKLEFNE);
	}

	private static IEnumerator IDPDOBFOFOO(Action<Color> FFKNIHPCAEM, Func<Color> LGCHMGMLGOJ, Color DBACIMHFEKD, float OMHCOLMFGNJ, EaseType CMDDJMOKALH, TweenHandle FAMHLOBLCFP, Action IFHEEKLEFNE)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Color start = LGCHMGMLGOJ();
		float elapsed = 0f;
		while (elapsed < OMHCOLMFGNJ)
		{
			if (FAMHLOBLCFP.ANANJKCMFCA)
			{
				yield break;
			}
			elapsed += Time.deltaTime;
			FFKNIHPCAEM(Color.LerpUnclamped(start, DBACIMHFEKD, AAFMLNNBILN(CMDDJMOKALH, elapsed / OMHCOLMFGNJ)));
			yield return null;
		}
		if (!FAMHLOBLCFP.ANANJKCMFCA)
		{
			FFKNIHPCAEM(DBACIMHFEKD);
			IFHEEKLEFNE?.Invoke();
		}
	}

	public static TweenHandle DMGLGCEDNDO(Transform AEGIODEOOIJ, Vector3 DCOKGFPJHCN, float OMHCOLMFGNJ, EaseType CMDDJMOKALH = EaseType.EaseOutQuad, Action IFHEEKLEFNE = null)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(MNCJAAIMPCG(delegate(Quaternion q)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AEGIODEOOIJ.rotation = q;
		}, () => AEGIODEOOIJ.rotation, Quaternion.Euler(DCOKGFPJHCN), OMHCOLMFGNJ, CMDDJMOKALH, tweenHandle, IFHEEKLEFNE));
		return tweenHandle;
	}

	private static IEnumerator LJNPLHKBKPG(Action<Vector3> FFKNIHPCAEM, Func<Vector3> LGCHMGMLGOJ, Vector3 DBACIMHFEKD, float OMHCOLMFGNJ, EaseType CMDDJMOKALH, TweenHandle FAMHLOBLCFP, Action IFHEEKLEFNE)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = LGCHMGMLGOJ();
		float elapsed = 0f;
		while (elapsed < OMHCOLMFGNJ)
		{
			if (FAMHLOBLCFP.ANANJKCMFCA)
			{
				yield break;
			}
			elapsed += Time.deltaTime;
			FFKNIHPCAEM(Vector3.LerpUnclamped(start, DBACIMHFEKD, AAFMLNNBILN(CMDDJMOKALH, elapsed / OMHCOLMFGNJ)));
			yield return null;
		}
		if (!FAMHLOBLCFP.ANANJKCMFCA)
		{
			FFKNIHPCAEM(DBACIMHFEKD);
			IFHEEKLEFNE?.Invoke();
		}
	}

	public static float AAFMLNNBILN(EaseType CMDDJMOKALH, float DCGBADKLANM)
	{
		DCGBADKLANM = Mathf.Clamp01(DCGBADKLANM);
		switch (CMDDJMOKALH)
		{
		case EaseType.Linear:
			return DCGBADKLANM;
		case EaseType.EaseInQuad:
			return DCGBADKLANM * DCGBADKLANM;
		case EaseType.EaseOutQuad:
			return DCGBADKLANM * (2f - DCGBADKLANM);
		case EaseType.EaseInOutQuad:
			if (!(DCGBADKLANM < 0.5f))
			{
				return -1f + (4f - 2f * DCGBADKLANM) * DCGBADKLANM;
			}
			return 2f * DCGBADKLANM * DCGBADKLANM;
		case EaseType.EaseInCubic:
			return DCGBADKLANM * DCGBADKLANM * DCGBADKLANM;
		case EaseType.EaseOutCubic:
		{
			float num = DCGBADKLANM - 1f;
			return num * num * num + 1f;
		}
		case EaseType.EaseInOutCubic:
			if (!(DCGBADKLANM < 0.5f))
			{
				return (DCGBADKLANM - 1f) * (2f * DCGBADKLANM - 2f) * (2f * DCGBADKLANM - 2f) + 1f;
			}
			return 4f * DCGBADKLANM * DCGBADKLANM * DCGBADKLANM;
		case EaseType.EaseInSine:
			return 1f - Mathf.Cos(DCGBADKLANM * MathF.PI * 0.5f);
		case EaseType.EaseOutSine:
			return Mathf.Sin(DCGBADKLANM * MathF.PI * 0.5f);
		case EaseType.EaseInOutSine:
			return (0f - (Mathf.Cos(MathF.PI * DCGBADKLANM) - 1f)) * 0.5f;
		case EaseType.EaseInBack:
			return DCGBADKLANM * DCGBADKLANM * (2.70158f * DCGBADKLANM - 1.70158f);
		case EaseType.EaseOutBack:
		{
			float num3 = DCGBADKLANM - 1f;
			return num3 * num3 * (2.70158f * num3 + 1.70158f) + 1f;
		}
		case EaseType.EaseInOutBack:
		{
			float num2 = 2.5949094f;
			if (!(DCGBADKLANM < 0.5f))
			{
				return (Mathf.Pow(2f * DCGBADKLANM - 2f, 2f) * ((num2 + 1f) * (DCGBADKLANM * 2f - 2f) + num2) + 2f) * 0.5f;
			}
			return Mathf.Pow(2f * DCGBADKLANM, 2f) * ((num2 + 1f) * 2f * DCGBADKLANM - num2) * 0.5f;
		}
		case EaseType.EaseOutBounce:
			return GMFLNGDIHPL(DCGBADKLANM);
		case EaseType.EaseOutElastic:
			if (DCGBADKLANM == 0f || DCGBADKLANM == 1f)
			{
				return DCGBADKLANM;
			}
			return Mathf.Pow(2f, -10f * DCGBADKLANM) * Mathf.Sin((DCGBADKLANM * 10f - 0.75f) * (MathF.PI * 2f) / 3f) + 1f;
		default:
			return DCGBADKLANM;
		}
	}

	public static TweenHandle INMCALMJNJE(float FLHBPHPKIML, Action AABDPKCDEKB)
	{
		TweenHandle tweenHandle = new TweenHandle(null);
		tweenHandle.BEGCPKOAJCP = TweenRunner.HFBLDMHFBDJ.Run(EIBCLHJBIHP(FLHBPHPKIML, AABDPKCDEKB, tweenHandle));
		return tweenHandle;
	}

	private static IEnumerator HKPNDFMLKGI(Transform AEGIODEOOIJ, Vector3 GAFHNGLHCPG, Vector3 HLNPJOMCJKG, float OMHCOLMFGNJ, EaseType CMDDJMOKALH, TweenHandle FAMHLOBLCFP, Action IFHEEKLEFNE)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		float half = OMHCOLMFGNJ * 0.5f;
		float elapsed2 = 0f;
		while (elapsed2 < half)
		{
			if (FAMHLOBLCFP.ANANJKCMFCA)
			{
				yield break;
			}
			elapsed2 += Time.deltaTime;
			AEGIODEOOIJ.localScale = Vector3.LerpUnclamped(GAFHNGLHCPG, HLNPJOMCJKG, AAFMLNNBILN(CMDDJMOKALH, elapsed2 / half));
			yield return null;
		}
		elapsed2 = 0f;
		while (elapsed2 < half)
		{
			if (FAMHLOBLCFP.ANANJKCMFCA)
			{
				yield break;
			}
			elapsed2 += Time.deltaTime;
			AEGIODEOOIJ.localScale = Vector3.LerpUnclamped(HLNPJOMCJKG, GAFHNGLHCPG, AAFMLNNBILN(CMDDJMOKALH, elapsed2 / half));
			yield return null;
		}
		if (!FAMHLOBLCFP.ANANJKCMFCA)
		{
			AEGIODEOOIJ.localScale = GAFHNGLHCPG;
			IFHEEKLEFNE?.Invoke();
		}
	}
}
