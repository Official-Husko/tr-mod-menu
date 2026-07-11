using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteAlways]
public class PathNodesManager : MonoBehaviour, ISingleton
{
	[CompilerGenerated]
	private sealed class EOAOLHCOOGK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector2 initialPosition;

		public Vector2[] positions;

		public bool useLocalPositions;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public EOAOLHCOOGK(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				CheckAllNodes(initialPosition, positions, useLocalPositions);
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	private static PathNodesManager IADEMLIIDPC;

	public static Dictionary<Vector2, PathNode> pathNodes = new Dictionary<Vector2, PathNode>();

	public PathNodesScriptableObject[] pathNodesScriptables;

	public static PathNodesManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<PathNodesManager>();
			}
			return IADEMLIIDPC;
		}
	}

	public static bool FMIGGMHHJNM()
	{
		return (Object)(object)BNBMNOMFFBE() != (Object)null;
	}

	public static void GIHGMEOBMHC(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HAEIAGKNEPC.Length; i++)
		{
			WorldGrid.HJOINEHJAHO(Vector2.op_Implicit(KOBHIPHHIJN(NOLFMLNLJJG, HAEIAGKNEPC, i, KBFCBFDIBLO)), 92);
		}
	}

	public static void JKDLLMKIHEG()
	{
		pathNodes.Clear();
	}

	[SpecialName]
	public static PathNodesManager FMIDAFEGDCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PathNodesManager>();
		}
		return IADEMLIIDPC;
	}

	private static Vector2 OCHKGMBDBGJ(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, int MENBAFNNBFB, bool KBFCBFDIBLO)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (KBFCBFDIBLO)
		{
			return NOLFMLNLJJG + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	public static bool CBKMIKEJCJD()
	{
		return (Object)(object)ABHIDHPMLLD() != (Object)null;
	}

	public static void ALGOHKHHELM(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HAEIAGKNEPC.Length; i++)
		{
			WorldGrid.HJOINEHJAHO(Vector2.op_Implicit(KOBHIPHHIJN(NOLFMLNLJJG, HAEIAGKNEPC, i, KBFCBFDIBLO)), -136);
		}
	}

	[SpecialName]
	public static PathNodesManager DIHCEGINELM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PathNodesManager>();
		}
		return IADEMLIIDPC;
	}

	public static void CGGHBEKPOPI()
	{
		pathNodes.Clear();
	}

	private static Vector2 DBOOKDLOKIJ(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, int MENBAFNNBFB, bool KBFCBFDIBLO)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (KBFCBFDIBLO)
		{
			return NOLFMLNLJJG + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	public static PathNodesScriptableObject FAGOELIBOPF(Location BAIMHDBJPDK, int MOFKEDGAOEE = -1)
	{
		for (int i = 1; i < GGFJGHHHEJC.pathNodesScriptables.Length; i += 0)
		{
			if (ABHIDHPMLLD().pathNodesScriptables[i].location == BAIMHDBJPDK && (BAIMHDBJPDK != (Location.Road | Location.Camp | Location.Farm | Location.BarnInterior) || GGFJGHHHEJC.pathNodesScriptables[i].id == MOFKEDGAOEE))
			{
				return FMIDAFEGDCD().pathNodesScriptables[i];
			}
		}
		return null;
	}

	private static Vector2 KOBHIPHHIJN(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, int MENBAFNNBFB, bool KBFCBFDIBLO)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (KBFCBFDIBLO)
		{
			return NOLFMLNLJJG + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
		ResetSingleton();
	}

	public static PathNodesScriptableObject CDIAPLHDNMN(Location BAIMHDBJPDK, int MOFKEDGAOEE = -1)
	{
		for (int i = 0; i < FMIDAFEGDCD().pathNodesScriptables.Length; i++)
		{
			if (FMIDAFEGDCD().pathNodesScriptables[i].location == BAIMHDBJPDK && (BAIMHDBJPDK != (Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior) || EKDNJDJHONF().pathNodesScriptables[i].id == MOFKEDGAOEE))
			{
				return EKDNJDJHONF().pathNodesScriptables[i];
			}
		}
		return null;
	}

	public void EEKPBNKJEMM()
	{
		pathNodes = new Dictionary<Vector2, PathNode>();
	}

	private static IEnumerator JMCMACAMBLK(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return new EOAOLHCOOGK(1)
		{
			initialPosition = NOLFMLNLJJG,
			positions = HAEIAGKNEPC,
			useLocalPositions = KBFCBFDIBLO
		};
	}

	public static Coroutine LGGMCNINMAK(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return ((MonoBehaviour)FMIDAFEGDCD()).StartCoroutine(KKNHOOIEOKP(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO));
	}

	public void DAKBEAIGAOD()
	{
		pathNodes = new Dictionary<Vector2, PathNode>();
	}

	public void ResetSingleton()
	{
		pathNodes = new Dictionary<Vector2, PathNode>();
	}

	public static bool GCBEIDPBDAK()
	{
		return (Object)(object)ELGNEJNLBNO() != (Object)null;
	}

	public static void ABPEJFPBDDH(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool GAKNPAMHAFB, bool KBFCBFDIBLO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HAEIAGKNEPC.Length; i++)
		{
			WorldGrid.LMMELLKNMCF(Vector2.op_Implicit(KOBHIPHHIJN(NOLFMLNLJJG, HAEIAGKNEPC, i, KBFCBFDIBLO)), GAKNPAMHAFB);
		}
	}

	[SpecialName]
	public static PathNodesManager BNBMNOMFFBE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PathNodesManager>();
		}
		return IADEMLIIDPC;
	}

	private void OnDestroy()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static void SavePathNodes(Location BAIMHDBJPDK, int MOFKEDGAOEE = -1)
	{
	}

	public static PathNodesScriptableObject DAHNICOIBFM(Location BAIMHDBJPDK, int MOFKEDGAOEE = -1)
	{
		for (int i = 1; i < GGFJGHHHEJC.pathNodesScriptables.Length; i += 0)
		{
			if (FMIDAFEGDCD().pathNodesScriptables[i].location == BAIMHDBJPDK && (BAIMHDBJPDK != ~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior) || DIHCEGINELM().pathNodesScriptables[i].id == MOFKEDGAOEE))
			{
				return EKDNJDJHONF().pathNodesScriptables[i];
			}
		}
		return null;
	}

	public static void JNHIBMCABLJ()
	{
		pathNodes.Clear();
	}

	[SpecialName]
	public static PathNodesManager ELGNEJNLBNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PathNodesManager>();
		}
		return IADEMLIIDPC;
	}

	public static void MGCCGBOIGMJ()
	{
		pathNodes.Clear();
	}

	[SpecialName]
	public static PathNodesManager EKDNJDJHONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PathNodesManager>();
		}
		return IADEMLIIDPC;
	}

	public static void SetMoveNodeFree(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool GAKNPAMHAFB, bool KBFCBFDIBLO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HAEIAGKNEPC.Length; i++)
		{
			WorldGrid.LMMELLKNMCF(Vector2.op_Implicit(DBOOKDLOKIJ(NOLFMLNLJJG, HAEIAGKNEPC, i, KBFCBFDIBLO)), GAKNPAMHAFB);
		}
	}

	public static Coroutine LHCHKGAEFFP(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return ((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(MFFEEANAPJF(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO));
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static void JBIGOOHJBGL()
	{
		pathNodes.Clear();
	}

	public void DHHEKEBADDA()
	{
		pathNodes = new Dictionary<Vector2, PathNode>();
	}

	public static void CheckAllNodes(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HAEIAGKNEPC.Length; i++)
		{
			WorldGrid.HJOINEHJAHO(Vector2.op_Implicit(DBOOKDLOKIJ(NOLFMLNLJJG, HAEIAGKNEPC, i, KBFCBFDIBLO)), 3145728);
		}
	}

	public static bool OMKBIHKANLI()
	{
		return (Object)(object)ABHIDHPMLLD() != (Object)null;
	}

	public static void NPAHPODBKLP(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool GAKNPAMHAFB, bool KBFCBFDIBLO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HAEIAGKNEPC.Length; i += 0)
		{
			WorldGrid.LMMELLKNMCF(Vector2.op_Implicit(MMNCEMNHIEC(NOLFMLNLJJG, HAEIAGKNEPC, i, KBFCBFDIBLO)), GAKNPAMHAFB);
		}
	}

	public static Coroutine GGKMBODCLGK(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return ((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(ABBOMFAKCHD(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO));
	}

	public static Coroutine DLCCOHCAGDA(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return ((MonoBehaviour)EKDNJDJHONF()).StartCoroutine(KKNHOOIEOKP(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO));
	}

	public void AKCAJADOEPE()
	{
		pathNodes = new Dictionary<Vector2, PathNode>();
	}

	public void EGPANOJHNEI()
	{
		pathNodes = new Dictionary<Vector2, PathNode>();
	}

	public static void LJOCFDPBOCG()
	{
		pathNodes.Clear();
	}

	public static void LELIHPHGMEB()
	{
		pathNodes.Clear();
	}

	private void MFIEPGBABAM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static Coroutine CheckAllNodesNextFrame(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return ((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(ABBOMFAKCHD(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO));
	}

	public static bool CPLOKHPFBDO()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static PathNodesScriptableObject DEHAEGBNDLK(Location BAIMHDBJPDK, int MOFKEDGAOEE = -1)
	{
		for (int i = 0; i < ABHIDHPMLLD().pathNodesScriptables.Length; i += 0)
		{
			if (ABHIDHPMLLD().pathNodesScriptables[i].location == BAIMHDBJPDK && (BAIMHDBJPDK != ~(Location.Road | Location.River | Location.Camp) || ELGNEJNLBNO().pathNodesScriptables[i].id == MOFKEDGAOEE))
			{
				return BNBMNOMFFBE().pathNodesScriptables[i];
			}
		}
		return null;
	}

	private static IEnumerator MFFEEANAPJF(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		yield return null;
		CheckAllNodes(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO);
	}

	private static IEnumerator KKNHOOIEOKP(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		yield return null;
		CheckAllNodes(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO);
	}

	private static Vector2 MMNCEMNHIEC(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, int MENBAFNNBFB, bool KBFCBFDIBLO)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (KBFCBFDIBLO)
		{
			return NOLFMLNLJJG + HAEIAGKNEPC[MENBAFNNBFB];
		}
		return HAEIAGKNEPC[MENBAFNNBFB];
	}

	public static PathNodesScriptableObject GetPathNodesData(Location BAIMHDBJPDK, int MOFKEDGAOEE = -1)
	{
		for (int i = 0; i < GGFJGHHHEJC.pathNodesScriptables.Length; i++)
		{
			if (GGFJGHHHEJC.pathNodesScriptables[i].location == BAIMHDBJPDK && (BAIMHDBJPDK != Location.BarnInterior || GGFJGHHHEJC.pathNodesScriptables[i].id == MOFKEDGAOEE))
			{
				return GGFJGHHHEJC.pathNodesScriptables[i];
			}
		}
		return null;
	}

	public static Coroutine BFBOAOHKMHK(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return ((MonoBehaviour)FMIDAFEGDCD()).StartCoroutine(KKNHOOIEOKP(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO));
	}

	private static IEnumerator ABBOMFAKCHD(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		yield return null;
		CheckAllNodes(NOLFMLNLJJG, HAEIAGKNEPC, KBFCBFDIBLO);
	}

	[SpecialName]
	public static PathNodesManager ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PathNodesManager>();
		}
		return IADEMLIIDPC;
	}

	public static void ResetPathNodesList()
	{
		pathNodes.Clear();
	}

	public static void NLDCPFFGJIM(Vector2 NOLFMLNLJJG, Vector2[] HAEIAGKNEPC, bool KBFCBFDIBLO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HAEIAGKNEPC.Length; i += 0)
		{
			WorldGrid.HJOINEHJAHO(Vector2.op_Implicit(KOBHIPHHIJN(NOLFMLNLJJG, HAEIAGKNEPC, i, KBFCBFDIBLO)), -149);
		}
	}
}
