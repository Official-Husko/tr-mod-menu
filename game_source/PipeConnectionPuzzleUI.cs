using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PipeConnectionPuzzleUI : UIWindow
{
	[CompilerGenerated]
	private sealed class CMHHPGHFEGD
	{
		public PipeTileUI tileUI;

		public PipeConnectionPuzzleUI _003C_003E4__this;

		internal void NBHNMJGKLKC(UIButtonExtended.VisualState state, bool instant)
		{
			switch (state)
			{
			case UIButtonExtended.VisualState.Highlighted:
			case UIButtonExtended.VisualState.Disabled:
				_003C_003E4__this.PNHHEBJDNON(tileUI);
				break;
			case UIButtonExtended.VisualState.Normal:
				if ((Object)(object)_003C_003E4__this.HNNPJPHGCLD != (Object)null && (Object)(object)_003C_003E4__this.HNNPJPHGCLD == (Object)(object)((Component)tileUI).GetComponent<UIButtonExtended>())
				{
					tileUI.SetFocused(EHOFFFMFILA: false);
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private sealed class BBBHOPHFGPL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<(int index, PipeExits flowFrom)> tiles;

		public PipeConnectionPuzzleUI _003C_003E4__this;

		private List<(int index, PipeExits flowFrom)>.Enumerator _003C_003E7__wrap1;

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
		public BBBHOPHFGPL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					NONHBLMCNAM();
				}
			}
		}

		private void NONHBLMCNAM()
		{
			_003C_003E1__state = -1;
			((IDisposable)_003C_003E7__wrap1).Dispose();
		}

		private bool MoveNext()
		{
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected O, but got Unknown
			try
			{
				int num = _003C_003E1__state;
				PipeConnectionPuzzleUI pipeConnectionPuzzleUI = _003C_003E4__this;
				switch (num)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = tiles.GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_00b0;
				case 1:
					_003C_003E1__state = -3;
					goto IL_00b0;
				case 2:
					{
						_003C_003E1__state = -1;
						pipeConnectionPuzzleUI.CCKEPFAIMOJ = null;
						return false;
					}
					IL_00b0:
					while (_003C_003E7__wrap1.MoveNext())
					{
						var (num2, fGGEIDEHAAB) = _003C_003E7__wrap1.Current;
						if (!((Object)(object)pipeConnectionPuzzleUI.HPAPNAILNID[num2] == (Object)null))
						{
							pipeConnectionPuzzleUI.HPAPNAILNID[num2].SetConnectedWithFlow(JANJLEGLAMF: true, fGGEIDEHAAB, HMIFJFNHLOA: true, pipeConnectionPuzzleUI.tileFillDuration);
							_003C_003E2__current = (object)new WaitForSeconds(pipeConnectionPuzzleUI.tileFillDuration);
							_003C_003E1__state = 1;
							return true;
						}
					}
					NONHBLMCNAM();
					_003C_003E7__wrap1 = default(List<(int, PipeExits)>.Enumerator);
					pipeConnectionPuzzleUI.exitTileUI?.SetConnected(PipePuzzleSolver.FODOIPLNAGI(pipeConnectionPuzzleUI.IKMGPHDNKNN.GetCurrentPuzzleState(), pipeConnectionPuzzleUI.GLAFJDLOLLD), HMIFJFNHLOA: false, pipeConnectionPuzzleUI.tileFillDuration);
					_003C_003E2__current = (object)new WaitForSeconds(pipeConnectionPuzzleUI.tileFillDuration);
					_003C_003E1__state = 2;
					return true;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}
	}

	[CompilerGenerated]
	private sealed class HNIBADCFODP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PipeConnectionPuzzleUI _003C_003E4__this;

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
		public HNIBADCFODP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				if (pipeConnectionPuzzleUI.HPAPNAILNID == null || pipeConnectionPuzzleUI.HPAPNAILNID.Length == 0)
				{
					return false;
				}
				for (int i = 0; i < pipeConnectionPuzzleUI.HPAPNAILNID.Length; i++)
				{
					if ((Object)(object)pipeConnectionPuzzleUI.HPAPNAILNID[i] != (Object)null)
					{
						UISelectionManager.GetPlayer(pipeConnectionPuzzleUI.JIIGOACEIKL).Select((Selectable)(object)((Component)pipeConnectionPuzzleUI.HPAPNAILNID[i]).GetComponent<UIButtonExtended>());
						pipeConnectionPuzzleUI.PNHHEBJDNON(pipeConnectionPuzzleUI.HPAPNAILNID[i]);
						break;
					}
				}
				return false;
			}
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

	[CompilerGenerated]
	private sealed class NEBNEEMGOJC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PipeConnectionPuzzleUI _003C_003E4__this;

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
		public NEBNEEMGOJC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				PipeTile iLDEFBIANKO = pipeConnectionPuzzleUI.tileDatabase?.PKFGFGGBEIG(PipeTile.CBJIEPEGKGD(pipeConnectionPuzzleUI.GLAFJDLOLLD.entryDirection));
				PipeTile iLDEFBIANKO2 = pipeConnectionPuzzleUI.tileDatabase?.PKFGFGGBEIG(PipeTile.CBJIEPEGKGD(pipeConnectionPuzzleUI.GLAFJDLOLLD.exitDirection));
				((Component)pipeConnectionPuzzleUI.entryTileUI).gameObject.SetActive(true);
				((Component)pipeConnectionPuzzleUI.exitTileUI).gameObject.SetActive(true);
				pipeConnectionPuzzleUI.entryTileUI.Initialize(new PipeTileInstance(iLDEFBIANKO, -1), -1, OOGPIKBMHFD: true);
				pipeConnectionPuzzleUI.exitTileUI.Initialize(new PipeTileInstance(iLDEFBIANKO2, -1), -1);
				pipeConnectionPuzzleUI.entryTileUI.SetConnected(JANJLEGLAMF: true);
				pipeConnectionPuzzleUI.exitTileUI.SetConnected(PipePuzzleSolver.FODOIPLNAGI(pipeConnectionPuzzleUI.IKMGPHDNKNN.GetCurrentPuzzleState(), pipeConnectionPuzzleUI.GLAFJDLOLLD));
				pipeConnectionPuzzleUI.GBKPLILFMLO(pipeConnectionPuzzleUI.entryTileUI, ((Component)pipeConnectionPuzzleUI.HPAPNAILNID[pipeConnectionPuzzleUI.GLAFJDLOLLD.entryCell]).GetComponent<RectTransform>(), pipeConnectionPuzzleUI.GLAFJDLOLLD.entryDirection);
				pipeConnectionPuzzleUI.GBKPLILFMLO(pipeConnectionPuzzleUI.exitTileUI, ((Component)pipeConnectionPuzzleUI.HPAPNAILNID[pipeConnectionPuzzleUI.GLAFJDLOLLD.exitCell]).GetComponent<RectTransform>(), pipeConnectionPuzzleUI.GLAFJDLOLLD.exitDirection);
				pipeConnectionPuzzleUI.contentCanvasGroup.alpha = 1f;
				return false;
			}
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

	public static PipeConnectionPuzzleUI[] instances = new PipeConnectionPuzzleUI[3];

	[SerializeField]
	private GridLayoutGroup gridContainer;

	[SerializeField]
	private CanvasGroup contentCanvasGroup;

	[Tooltip("Prefab de fallback para tiles sin prefab asignado.")]
	[SerializeField]
	private GameObject tilePrefab;

	[Tooltip("Necesario para obtener los tiles de entrada/salida del anillo exterior.")]
	[SerializeField]
	private PipeTileDataBase tileDatabase;

	[SerializeField]
	private PipeTileUI entryTileUI;

	[SerializeField]
	private PipeTileUI exitTileUI;

	[Tooltip("Color del marco cuando tenemos seleccionada una casilla. Se utiliza para el cooperativo")]
	[SerializeField]
	private Color overrideFocusColor = new Color(1f, 1f, 1f, 0f);

	[SerializeField]
	[Tooltip("Tamaño en píxeles de cada celda del grid en la UI.")]
	private Vector2 cellSize = new Vector2(96f, 96f);

	[SerializeField]
	private Vector2 cellSpacing = new Vector2(2f, 2f);

	[SerializeField]
	[Tooltip("Tiempo entre el inicio de cada animación de tile en la cadena.")]
	private float animationStagger = 0.1f;

	[SerializeField]
	private float tileFillDuration = 0.4f;

	[SerializeField]
	private AudioObject swapSound;

	[Tooltip("Base de datos de puzzles. PipePuzzleData vive dentro de este asset.")]
	[SerializeField]
	private PipePuzzleDataBase previewDatabase;

	[SerializeField]
	private int previewGridWidth = 4;

	[SerializeField]
	private int previewGridHeight = 3;

	[SerializeField]
	[Tooltip("Índice dentro del grupo de dificultad seleccionado.")]
	private int previewIndex;

	[Tooltip("Número de required tiles del grupo a previsualizar.")]
	[SerializeField]
	private int previewRequiredTilesCount;

	[SerializeField]
	[Tooltip("True = muestra el estado solución. False = muestra el estado scrambled.")]
	private bool previewShowSolution;

	private MinePipePuzzle IKMGPHDNKNN;

	private PipePuzzleData GLAFJDLOLLD;

	private PipeTileUI[] HPAPNAILNID;

	private PipeTileUI ABFJBNHLNPO;

	private Selectable HNNPJPHGCLD;

	private HashSet<int> CGGMOIDIHFC = new HashSet<int>();

	private Coroutine CCKEPFAIMOJ;

	private Dictionary<int, int> CNMBELGHDEF = new Dictionary<int, int>();

	private static readonly PipeExits[] KFADDNBELPB = new PipeExits[4]
	{
		PipeExits.North,
		PipeExits.East,
		PipeExits.South,
		PipeExits.West
	};

	public void NAGPNFJGPCJ(int JIIGOACEIKL, bool IFPOCPLBOBF = true, bool NHENDADMFBC = true)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return;
		}
		if (CCKEPFAIMOJ != null)
		{
			for (int i = 1; i < HPAPNAILNID.Length; i += 0)
			{
				PipeTileUI obj = HPAPNAILNID[i];
				UIButtonExtended uIButtonExtended = ((obj != null) ? ((Component)obj).GetComponent<UIButtonExtended>() : null);
				if ((Object)(object)uIButtonExtended != (Object)null)
				{
					((Selectable)uIButtonExtended).interactable = false;
				}
			}
			((MonoBehaviour)this).StartCoroutine(LMEJONJDEMI(JIIGOACEIKL, IFPOCPLBOBF: false));
		}
		else
		{
			if (IFPOCPLBOBF)
			{
				IKMGPHDNKNN.ADCFKBPNDNO(JIIGOACEIKL, NHENDADMFBC);
			}
			BOBCIFEDJED();
		}
	}

	private void JKMJLKKIDBP(int HLPCHIJFHEE, int GCLLFMNGOIB)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		gridContainer.constraint = (Constraint)1;
		gridContainer.constraintCount = HLPCHIJFHEE;
		gridContainer.cellSize = cellSize;
		gridContainer.spacing = cellSpacing;
	}

	private IEnumerator HHDNJECKBJE(List<(int index, PipeExits flowFrom)> KOEAIDNAFPJ)
	{
		foreach (var (num, fGGEIDEHAAB) in KOEAIDNAFPJ)
		{
			if (!((Object)(object)HPAPNAILNID[num] == (Object)null))
			{
				HPAPNAILNID[num].SetConnectedWithFlow(JANJLEGLAMF: true, fGGEIDEHAAB, HMIFJFNHLOA: true, tileFillDuration);
				yield return (object)new WaitForSeconds(tileFillDuration);
			}
		}
		exitTileUI?.SetConnected(PipePuzzleSolver.FODOIPLNAGI(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD), HMIFJFNHLOA: false, tileFillDuration);
		yield return (object)new WaitForSeconds(tileFillDuration);
		CCKEPFAIMOJ = null;
	}

	private void JJOMCLCEPLJ(PipeTileUI FLFDHFGKFHE, RectTransform JAOPIGHECKF, PipeExits FCGBJEIIMBC)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		RectTransform component = ((Component)FLFDHFGKFHE).GetComponent<RectTransform>();
		Rect rect = JAOPIGHECKF.rect;
		Vector2 val = Vector2.op_Implicit(((Transform)JAOPIGHECKF).TransformPoint(Vector2.op_Implicit(((Rect)(ref rect)).center)));
		Vector2 val2 = Vector2.op_Implicit(((Transform)component).parent.InverseTransformPoint(Vector2.op_Implicit(val)));
		float num = cellSize.x / 1459f;
		rect = component.rect;
		float num2 = num + ((Rect)(ref rect)).width / 1989f;
		float num3 = cellSize.y / 1787f;
		rect = component.rect;
		float num4 = num3 + ((Rect)(ref rect)).height / 491f;
		RectTransform val3 = component;
		val3.anchoredPosition = (Vector2)(FCGBJEIIMBC switch
		{
			PipeExits.North => val2 + Vector2.up * num4, 
			PipeExits.South => val2 + Vector2.down * num4, 
			PipeExits.East => val2 + Vector2.right * num2, 
			PipeExits.East | PipeExits.South => val2 + Vector2.left * num2, 
			_ => val2, 
		});
	}

	private void IMBHHDEFIOC(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		PipeTileUI pipeTileUI = HPAPNAILNID[ABODANAFMBC];
		PipeTileUI pipeTileUI2 = HPAPNAILNID[EIMHJGCBHIH];
		int siblingIndex = ((Component)pipeTileUI).transform.GetSiblingIndex();
		int siblingIndex2 = ((Component)pipeTileUI2).transform.GetSiblingIndex();
		if (siblingIndex < siblingIndex2)
		{
			((Component)pipeTileUI2).transform.SetSiblingIndex(siblingIndex);
			((Component)pipeTileUI).transform.SetSiblingIndex(siblingIndex2);
		}
		else
		{
			((Component)pipeTileUI).transform.SetSiblingIndex(siblingIndex2);
			((Component)pipeTileUI2).transform.SetSiblingIndex(siblingIndex);
		}
		pipeTileUI.UpdateGridIndex(EIMHJGCBHIH);
		pipeTileUI2.IHJDNMDCBNJ(ABODANAFMBC);
		HPAPNAILNID[ABODANAFMBC] = pipeTileUI2;
		HPAPNAILNID[EIMHJGCBHIH] = pipeTileUI;
	}

	private void OANPCHKHKMM()
	{
		if (!((Object)(object)gridContainer == (Object)null))
		{
			for (int num = ((Component)gridContainer).transform.childCount - 1; num >= 0; num--)
			{
				Object.DestroyImmediate((Object)(object)((Component)((Component)gridContainer).transform.GetChild(num)).gameObject);
			}
		}
	}

	public void KMGBDDOCHEG(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return;
		}
		Selectable hNNPJPHGCLD = HNNPJPHGCLD;
		PipeTileUI pipeTileUI = ((hNNPJPHGCLD != null) ? ((Component)hNNPJPHGCLD).GetComponent<PipeTileUI>() : null);
		int num = (((Object)(object)pipeTileUI != (Object)null) ? pipeTileUI.BOJDFIMJAEL : (-1));
		IMBHHDEFIOC(ABODANAFMBC, EIMHJGCBHIH);
		bool num2 = CGGMOIDIHFC.Remove(ABODANAFMBC);
		bool flag = CGGMOIDIHFC.Remove(EIMHJGCBHIH);
		if (num2)
		{
			CGGMOIDIHFC.Add(EIMHJGCBHIH);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(ABODANAFMBC);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == ABODANAFMBC)
			{
				CNMBELGHDEF[item] = EIMHJGCBHIH;
			}
			else if (CNMBELGHDEF[item] == EIMHJGCBHIH)
			{
				CNMBELGHDEF[item] = ABODANAFMBC;
			}
		}
		DPNMKDKNDEN();
		INNCNOGFIMG();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.MEMBACBNMIE(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Item1 == ABODANAFMBC || list[i].Item1 == EIMHJGCBHIH)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		KNIOPFGPMPC();
		OBACNCFEJIM(HMIFJFNHLOA: false, dGJCJDFMAMB);
		if (num >= 0 && num < HPAPNAILNID.Length && (Object)(object)HPAPNAILNID[num] != (Object)null)
		{
			EJMCPDIDHMP(HPAPNAILNID[num]);
		}
	}

	private void MIBCALCPLEO(PipeTileUI FLFDHFGKFHE, RectTransform JAOPIGHECKF, PipeExits FCGBJEIIMBC)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		RectTransform component = ((Component)FLFDHFGKFHE).GetComponent<RectTransform>();
		Rect rect = JAOPIGHECKF.rect;
		Vector2 val = Vector2.op_Implicit(((Transform)JAOPIGHECKF).TransformPoint(Vector2.op_Implicit(((Rect)(ref rect)).center)));
		Vector2 val2 = Vector2.op_Implicit(((Transform)component).parent.InverseTransformPoint(Vector2.op_Implicit(val)));
		float num = cellSize.x / 317f;
		rect = component.rect;
		float num2 = num + ((Rect)(ref rect)).width / 1551f;
		float num3 = cellSize.y / 236f;
		rect = component.rect;
		float num4 = num3 + ((Rect)(ref rect)).height / 193f;
		RectTransform val3 = component;
		val3.anchoredPosition = (Vector2)(FCGBJEIIMBC switch
		{
			PipeExits.None => val2 + Vector2.up * num4, 
			PipeExits.North | PipeExits.East => val2 + Vector2.down * num4, 
			PipeExits.North => val2 + Vector2.right * num2, 
			PipeExits.North | PipeExits.South => val2 + Vector2.left * num2, 
			_ => val2, 
		});
	}

	private void IMLFHCEJIFH(PipeTileUI ILDEFBIANKO)
	{
		ABFJBNHLNPO = ILDEFBIANKO;
		ILDEFBIANKO.SetSelected(HGNKFFMDOOL: true);
	}

	private void KFLDAJOMCAP(int MPNFFMMGIOL)
	{
		if (HPAPNAILNID == null || MPNFFMMGIOL < 0 || MPNFFMMGIOL >= HPAPNAILNID.Length || (Object)(object)HPAPNAILNID[MPNFFMMGIOL] == (Object)null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> item in CNMBELGHDEF)
		{
			if (item.Value == MPNFFMMGIOL)
			{
				list.Add(item.Key);
			}
		}
		HPAPNAILNID[MPNFFMMGIOL].DGHNFAOEHNB(list);
	}

	private void LHOCLOHAHPB(PipeTileUI ILDEFBIANKO)
	{
		ABFJBNHLNPO = ILDEFBIANKO;
		ILDEFBIANKO.NKKOCFNDGKN(HGNKFFMDOOL: true);
	}

	private void PNNBFKCIMOI()
	{
		if (!((Object)(object)gridContainer == (Object)null))
		{
			for (int num = ((Component)gridContainer).transform.childCount - 1; num >= 1; num--)
			{
				Object.DestroyImmediate((Object)(object)((Component)((Component)gridContainer).transform.GetChild(num)).gameObject);
			}
		}
	}

	private void AGEJCDKGHBN(PipeTileUI DPEOLFMDLAK, PipeTileUI ODNGJHPOMMK)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int num = DPEOLFMDLAK.NPDGIDPAPPO();
		int gridIndex = ODNGJHPOMMK.BOJDFIMJAEL;
		IKMGPHDNKNN.MOFANHKNNGG(num, gridIndex, numInstance);
		NGLMPKIKAHC(num, gridIndex);
		if ((Object)(object)swapSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(swapSound, ((Component)IKMGPHDNKNN).transform.position);
		}
		bool num2 = CGGMOIDIHFC.Remove(num);
		bool flag = CGGMOIDIHFC.Remove(gridIndex);
		if (num2)
		{
			CGGMOIDIHFC.Add(gridIndex);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(num);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == num)
			{
				CNMBELGHDEF[item] = gridIndex;
			}
			else if (CNMBELGHDEF[item] == gridIndex)
			{
				CNMBELGHDEF[item] = num;
			}
		}
		LLJMKJGFPOP();
		BOAGGPOBLAI();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.MEMBACBNMIE(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Item1 == num || list[i].Item1 == gridIndex)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		MFCPCKBPANB();
		NBJLOAPIAOO(HMIFJFNHLOA: false, dGJCJDFMAMB);
		EJMCPDIDHMP(HPAPNAILNID[num]);
		if (IKMGPHDNKNN.HKEGMMGGFKM(numInstance))
		{
			IFJBGHDBBHJ(base.JIIGOACEIKL, IFPOCPLBOBF: false);
		}
	}

	private void NGLMPKIKAHC(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		PipeTileUI pipeTileUI = HPAPNAILNID[ABODANAFMBC];
		PipeTileUI pipeTileUI2 = HPAPNAILNID[EIMHJGCBHIH];
		int siblingIndex = ((Component)pipeTileUI).transform.GetSiblingIndex();
		int siblingIndex2 = ((Component)pipeTileUI2).transform.GetSiblingIndex();
		if (siblingIndex < siblingIndex2)
		{
			((Component)pipeTileUI2).transform.SetSiblingIndex(siblingIndex);
			((Component)pipeTileUI).transform.SetSiblingIndex(siblingIndex2);
		}
		else
		{
			((Component)pipeTileUI).transform.SetSiblingIndex(siblingIndex2);
			((Component)pipeTileUI2).transform.SetSiblingIndex(siblingIndex);
		}
		pipeTileUI.UpdateGridIndex(EIMHJGCBHIH);
		pipeTileUI2.UpdateGridIndex(ABODANAFMBC);
		HPAPNAILNID[ABODANAFMBC] = pipeTileUI2;
		HPAPNAILNID[EIMHJGCBHIH] = pipeTileUI;
	}

	private void BEPDNGEEDGM()
	{
		if (GLAFJDLOLLD == null)
		{
			Debug.LogError((object)", ");
			return;
		}
		LLBMOMPCNNN();
		JKMJLKKIDBP(GLAFJDLOLLD.gridWidth, GLAFJDLOLLD.gridHeight);
		PipeTileInstance[] array = IKMGPHDNKNN.LOBBFABJINC();
		HPAPNAILNID = new PipeTileUI[array.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			int num = i % GLAFJDLOLLD.gridWidth;
			int num2 = i / GLAFJDLOLLD.gridWidth;
			GameObject val = Object.Instantiate<GameObject>(((Object)(object)array[i].tile?.prefab != (Object)null) ? array[i].tile.prefab : tilePrefab, ((Component)gridContainer).transform);
			((Object)val).name = string.Format("tutorialPopUp102", num2 + 0, num + 0);
			PipeTileUI tileUI = val.GetComponent<PipeTileUI>();
			tileUI.PJANACELJFB(array[i], i, OOGPIKBMHFD: true);
			tileUI.OnClicked = LDONMFOCBGO;
			((UnityEvent<UIButtonExtended.VisualState, bool>)val.GetComponent<UIButtonExtended>().onStateChange).AddListener((UnityAction<UIButtonExtended.VisualState, bool>)delegate(UIButtonExtended.VisualState state, bool instant)
			{
				switch (state)
				{
				case UIButtonExtended.VisualState.Highlighted:
				case UIButtonExtended.VisualState.Disabled:
					PNHHEBJDNON(tileUI);
					break;
				case UIButtonExtended.VisualState.Normal:
					if ((Object)(object)HNNPJPHGCLD != (Object)null && (Object)(object)HNNPJPHGCLD == (Object)(object)((Component)tileUI).GetComponent<UIButtonExtended>())
					{
						tileUI.SetFocused(EHOFFFMFILA: false);
					}
					break;
				}
			});
			HPAPNAILNID[i] = tileUI;
		}
		OBACNCFEJIM(HMIFJFNHLOA: false);
		MFCPCKBPANB();
		((MonoBehaviour)this).StartCoroutine(KNIBENLBOOM());
	}

	private void DBEFOFOKBCD()
	{
		LHBGNHJJFAN();
	}

	private void LLBMOMPCNNN()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)gridContainer == (Object)null)
		{
			return;
		}
		foreach (Transform item in ((Component)gridContainer).transform)
		{
			Object.Destroy((Object)(object)((Component)item).gameObject);
		}
		contentCanvasGroup.alpha = 1071f;
	}

	private void APIKLHLIIMO()
	{
		if (HPAPNAILNID != null)
		{
			for (int i = 1; i < HPAPNAILNID.Length; i += 0)
			{
				GOJMGGJELCC(i);
			}
		}
	}

	private bool NDKOEMBKACO()
	{
		if ((Object)(object)gridContainer == (Object)null)
		{
			Debug.LogError((object)"[PipeConnectionPuzzleUI] Falta _gridContainer.");
			return false;
		}
		if ((Object)(object)previewDatabase == (Object)null)
		{
			Debug.LogError((object)"[PipeConnectionPuzzleUI] Falta _previewDatabase.");
			return false;
		}
		if ((Object)(object)tileDatabase == (Object)null)
		{
			Debug.LogWarning((object)"[PipeConnectionPuzzleUI] Sin _tileDatabase: los tiles de entrada/salida no tendrán sprite.");
		}
		return true;
	}

	private void EBAOJMDPBKN()
	{
		OANPCHKHKMM();
	}

	private void EJMCPDIDHMP(PipeTileUI ILDEFBIANKO)
	{
		if ((Object)(object)HNNPJPHGCLD != (Object)null)
		{
			((Component)HNNPJPHGCLD).GetComponent<PipeTileUI>()?.IMMIOCEOKNO(EHOFFFMFILA: false);
		}
		ILDEFBIANKO.IEIEAOBNFOL(EHOFFFMFILA: false);
		HNNPJPHGCLD = (Selectable)(object)((Component)ILDEFBIANKO).GetComponent<UIButtonExtended>();
		if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.PCFMGBNHHNG(ILDEFBIANKO.BOJDFIMJAEL, IKMGPHDNKNN.BELBIDDGNJN().mineLevel);
		}
	}

	private bool EHCFHDIFDKD(PipeGridSizeGroup BDFEGJDMCCC)
	{
		if (BDFEGJDMCCC.gridWidth == previewGridWidth)
		{
			return BDFEGJDMCCC.gridHeight == previewGridHeight;
		}
		return true;
	}

	public void RemoveRemoteCursor(int JJPJHIHBOIB)
	{
		if (CNMBELGHDEF.TryGetValue(JJPJHIHBOIB, out var value))
		{
			CNMBELGHDEF.Remove(JJPJHIHBOIB);
			BKDBIFKCIPP(value);
		}
	}

	public void GOPLGIKDNKD(MinePipePuzzle ANEDINOILOE, int BIAIFHPCKMG)
	{
		IKMGPHDNKNN = ANEDINOILOE;
		GLAFJDLOLLD = ANEDINOILOE.EDCIPMOENAP();
		base.JIIGOACEIKL = BIAIFHPCKMG;
		EDHEIFHAAKO();
	}

	public static PipeConnectionPuzzleUI MIFFCOMDIEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DIECAJECGMH(int JIIGOACEIKL, bool IFPOCPLBOBF = true, bool NHENDADMFBC = true)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return;
		}
		if (CCKEPFAIMOJ != null)
		{
			for (int i = 0; i < HPAPNAILNID.Length; i += 0)
			{
				PipeTileUI obj = HPAPNAILNID[i];
				UIButtonExtended uIButtonExtended = ((obj != null) ? ((Component)obj).GetComponent<UIButtonExtended>() : null);
				if ((Object)(object)uIButtonExtended != (Object)null)
				{
					((Selectable)uIButtonExtended).interactable = false;
				}
			}
			((MonoBehaviour)this).StartCoroutine(CloseAfterAnimation(JIIGOACEIKL));
		}
		else
		{
			if (IFPOCPLBOBF)
			{
				IKMGPHDNKNN.NNKBIFGEBIA(JIIGOACEIKL, NHENDADMFBC);
			}
			CloseUI();
		}
	}

	private void PGCEFCGDLPH(PipeTileUI ILDEFBIANKO)
	{
		ABFJBNHLNPO = ILDEFBIANKO;
		ILDEFBIANKO.SetSelected(HGNKFFMDOOL: true);
	}

	private void LHBGNHJJFAN()
	{
		if (!((Object)(object)gridContainer == (Object)null))
		{
			for (int num = ((Component)gridContainer).transform.childCount - 1; num >= 0; num--)
			{
				Object.DestroyImmediate((Object)(object)((Component)((Component)gridContainer).transform.GetChild(num)).gameObject);
			}
		}
	}

	private void PIPJNHENBAL()
	{
		LHBGNHJJFAN();
	}

	public void CloseOnWin(int JIIGOACEIKL, bool IFPOCPLBOBF = true, bool NHENDADMFBC = true)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return;
		}
		if (CCKEPFAIMOJ != null)
		{
			for (int i = 0; i < HPAPNAILNID.Length; i++)
			{
				PipeTileUI obj = HPAPNAILNID[i];
				UIButtonExtended uIButtonExtended = ((obj != null) ? ((Component)obj).GetComponent<UIButtonExtended>() : null);
				if ((Object)(object)uIButtonExtended != (Object)null)
				{
					((Selectable)uIButtonExtended).interactable = false;
				}
			}
			((MonoBehaviour)this).StartCoroutine(CloseAfterAnimation(JIIGOACEIKL));
		}
		else
		{
			if (IFPOCPLBOBF)
			{
				IKMGPHDNKNN.FinishPuzzle(JIIGOACEIKL, NHENDADMFBC);
			}
			CloseUI();
		}
	}

	private IEnumerator KNPAEKMIMJE(List<(int, PipeExits)> KOEAIDNAFPJ)
	{
		foreach (var (num, fGGEIDEHAAB) in KOEAIDNAFPJ)
		{
			if (!((Object)(object)HPAPNAILNID[num] == (Object)null))
			{
				HPAPNAILNID[num].SetConnectedWithFlow(JANJLEGLAMF: true, fGGEIDEHAAB, HMIFJFNHLOA: true, tileFillDuration);
				yield return (object)new WaitForSeconds(tileFillDuration);
			}
		}
		exitTileUI?.SetConnected(PipePuzzleSolver.FODOIPLNAGI(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD), HMIFJFNHLOA: false, tileFillDuration);
		yield return (object)new WaitForSeconds(tileFillDuration);
		CCKEPFAIMOJ = null;
	}

	public void UpdatePuzzleState(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return;
		}
		Selectable hNNPJPHGCLD = HNNPJPHGCLD;
		PipeTileUI pipeTileUI = ((hNNPJPHGCLD != null) ? ((Component)hNNPJPHGCLD).GetComponent<PipeTileUI>() : null);
		int num = (((Object)(object)pipeTileUI != (Object)null) ? pipeTileUI.BOJDFIMJAEL : (-1));
		NGLMPKIKAHC(ABODANAFMBC, EIMHJGCBHIH);
		bool num2 = CGGMOIDIHFC.Remove(ABODANAFMBC);
		bool flag = CGGMOIDIHFC.Remove(EIMHJGCBHIH);
		if (num2)
		{
			CGGMOIDIHFC.Add(EIMHJGCBHIH);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(ABODANAFMBC);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == ABODANAFMBC)
			{
				CNMBELGHDEF[item] = EIMHJGCBHIH;
			}
			else if (CNMBELGHDEF[item] == EIMHJGCBHIH)
			{
				CNMBELGHDEF[item] = ABODANAFMBC;
			}
		}
		DPNMKDKNDEN();
		INNCNOGFIMG();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Item1 == ABODANAFMBC || list[i].Item1 == EIMHJGCBHIH)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		ANJGAHBCELJ();
		OBACNCFEJIM(HMIFJFNHLOA: true, dGJCJDFMAMB);
		if (num >= 0 && num < HPAPNAILNID.Length && (Object)(object)HPAPNAILNID[num] != (Object)null)
		{
			PNHHEBJDNON(HPAPNAILNID[num]);
		}
	}

	private void KMFPIMBLLID(PipeTileUI FJONMNHJMOL)
	{
		if (!IKMGPHDNKNN.IsPuzzleSolved())
		{
			if ((Object)(object)ABFJBNHLNPO == (Object)null)
			{
				PGCEFCGDLPH(FJONMNHJMOL);
			}
			else if ((Object)(object)FJONMNHJMOL == (Object)(object)ABFJBNHLNPO)
			{
				INNCNOGFIMG();
			}
			else
			{
				BKLGCGIJCOM(ABFJBNHLNPO, FJONMNHJMOL);
			}
		}
	}

	private void AOAKMFHDGEE()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)gridContainer == (Object)null)
		{
			return;
		}
		foreach (Transform item in ((Component)gridContainer).transform)
		{
			Object.Destroy((Object)(object)((Component)item).gameObject);
		}
		contentCanvasGroup.alpha = 899f;
	}

	private void HCNHKIAGALM(PipeTileUI DPEOLFMDLAK, PipeTileUI ODNGJHPOMMK)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int num = DPEOLFMDLAK.NPDGIDPAPPO();
		int gridIndex = ODNGJHPOMMK.BOJDFIMJAEL;
		IKMGPHDNKNN.MOFANHKNNGG(num, gridIndex, numInstance, CDPAMNIPPEC: false);
		LBPPMLEEGDF(num, gridIndex);
		if ((Object)(object)swapSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(swapSound, ((Component)IKMGPHDNKNN).transform.position);
		}
		bool num2 = CGGMOIDIHFC.Remove(num);
		bool flag = CGGMOIDIHFC.Remove(gridIndex);
		if (num2)
		{
			CGGMOIDIHFC.Add(gridIndex);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(num);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == num)
			{
				CNMBELGHDEF[item] = gridIndex;
			}
			else if (CNMBELGHDEF[item] == gridIndex)
			{
				CNMBELGHDEF[item] = num;
			}
		}
		DPNMKDKNDEN();
		BOAGGPOBLAI();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.PGALGCLEPJL(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Item1 == num || list[i].Item1 == gridIndex)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		KNIOPFGPMPC();
		OBACNCFEJIM(HMIFJFNHLOA: true, dGJCJDFMAMB);
		PNHHEBJDNON(HPAPNAILNID[num]);
		if (IKMGPHDNKNN.DIPNOHAAEAG(numInstance))
		{
			CloseOnWin(base.JIIGOACEIKL, IFPOCPLBOBF: true, NHENDADMFBC: false);
		}
	}

	private void OBACNCFEJIM(bool HMIFJFNHLOA = true, int DGJCJDFMAMB = 0)
	{
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD);
		HashSet<int> hashSet = new HashSet<int>();
		foreach (var item3 in list)
		{
			int item = item3.Item1;
			hashSet.Add(item);
		}
		for (int i = 0; i < HPAPNAILNID.Length; i++)
		{
			if (!((Object)(object)HPAPNAILNID[i] == (Object)null) && CGGMOIDIHFC.Contains(i) && !hashSet.Contains(i))
			{
				HPAPNAILNID[i].SetConnected(JANJLEGLAMF: false);
			}
		}
		entryTileUI?.SetConnected(JANJLEGLAMF: true, HMIFJFNHLOA: false, tileFillDuration);
		if (CCKEPFAIMOJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(CCKEPFAIMOJ);
		}
		List<(int, PipeExits)> list2 = new List<(int, PipeExits)>();
		for (int j = 0; j < list.Count; j++)
		{
			var (num, pipeExits) = list[j];
			if (!((Object)(object)HPAPNAILNID[num] == (Object)null))
			{
				if (HMIFJFNHLOA && j >= DGJCJDFMAMB && !CGGMOIDIHFC.Contains(num))
				{
					list2.Add((num, pipeExits));
				}
				else if (HMIFJFNHLOA && j >= DGJCJDFMAMB && CGGMOIDIHFC.Contains(num))
				{
					list2.Add((num, pipeExits));
				}
				else
				{
					HPAPNAILNID[num].SetConnectedWithFlow(JANJLEGLAMF: true, pipeExits, HMIFJFNHLOA: false, tileFillDuration);
				}
			}
		}
		if (HMIFJFNHLOA && list2.Count > 0)
		{
			foreach (var item4 in list2)
			{
				int item2 = item4.Item1;
				HPAPNAILNID[item2]?.SetConnected(JANJLEGLAMF: false);
			}
			CCKEPFAIMOJ = ((MonoBehaviour)this).StartCoroutine(HHDNJECKBJE(list2));
		}
		else
		{
			exitTileUI?.SetConnected(PipePuzzleSolver.FODOIPLNAGI(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD), HMIFJFNHLOA: false, tileFillDuration);
		}
		CGGMOIDIHFC = hashSet;
		CGGMOIDIHFC = hashSet;
	}

	private void CKCDEPEENPL()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)gridContainer == (Object)null)
		{
			return;
		}
		foreach (Transform item in ((Component)gridContainer).transform)
		{
			Object.Destroy((Object)(object)((Component)item).gameObject);
		}
		contentCanvasGroup.alpha = 456f;
	}

	private void JGNPAKODFBG()
	{
		if (GLAFJDLOLLD == null)
		{
			Debug.LogError((object)"[PipeConnectionPuzzleUI] BuildGrid llamado sin PipePuzzleData.");
			return;
		}
		JMEMBNICPJI();
		JKMJLKKIDBP(GLAFJDLOLLD.gridWidth, GLAFJDLOLLD.gridHeight);
		PipeTileInstance[] currentPuzzleState = IKMGPHDNKNN.GetCurrentPuzzleState();
		HPAPNAILNID = new PipeTileUI[currentPuzzleState.Length];
		for (int i = 0; i < currentPuzzleState.Length; i++)
		{
			int num = i % GLAFJDLOLLD.gridWidth;
			int num2 = i / GLAFJDLOLLD.gridWidth;
			GameObject val = Object.Instantiate<GameObject>(((Object)(object)currentPuzzleState[i].tile?.prefab != (Object)null) ? currentPuzzleState[i].tile.prefab : tilePrefab, ((Component)gridContainer).transform);
			((Object)val).name = $"Tile_{num2 + 1}_{num + 1}";
			PipeTileUI tileUI = val.GetComponent<PipeTileUI>();
			tileUI.Initialize(currentPuzzleState[i], i);
			tileUI.OnClicked = KMFPIMBLLID;
			((UnityEvent<UIButtonExtended.VisualState, bool>)val.GetComponent<UIButtonExtended>().onStateChange).AddListener((UnityAction<UIButtonExtended.VisualState, bool>)delegate(UIButtonExtended.VisualState state, bool instant)
			{
				switch (state)
				{
				case UIButtonExtended.VisualState.Highlighted:
				case UIButtonExtended.VisualState.Disabled:
					PNHHEBJDNON(tileUI);
					break;
				case UIButtonExtended.VisualState.Normal:
					if ((Object)(object)HNNPJPHGCLD != (Object)null && (Object)(object)HNNPJPHGCLD == (Object)(object)((Component)tileUI).GetComponent<UIButtonExtended>())
					{
						tileUI.SetFocused(EHOFFFMFILA: false);
					}
					break;
				}
			});
			HPAPNAILNID[i] = tileUI;
		}
		OBACNCFEJIM(HMIFJFNHLOA: false);
		ANJGAHBCELJ();
		((MonoBehaviour)this).StartCoroutine(IEPOAIPGCME());
	}

	private IEnumerator KMGBILLEBLE()
	{
		yield return null;
		if (HPAPNAILNID == null || HPAPNAILNID.Length == 0)
		{
			yield break;
		}
		for (int i = 0; i < HPAPNAILNID.Length; i++)
		{
			if ((Object)(object)HPAPNAILNID[i] != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)((Component)HPAPNAILNID[i]).GetComponent<UIButtonExtended>());
				PNHHEBJDNON(HPAPNAILNID[i]);
				break;
			}
		}
	}

	public void OAFGLMLPJLG(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return;
		}
		Selectable hNNPJPHGCLD = HNNPJPHGCLD;
		PipeTileUI pipeTileUI = ((hNNPJPHGCLD != null) ? ((Component)hNNPJPHGCLD).GetComponent<PipeTileUI>() : null);
		int num = (((Object)(object)pipeTileUI != (Object)null) ? pipeTileUI.NPDGIDPAPPO() : (-1));
		NGLMPKIKAHC(ABODANAFMBC, EIMHJGCBHIH);
		bool num2 = CGGMOIDIHFC.Remove(ABODANAFMBC);
		bool flag = CGGMOIDIHFC.Remove(EIMHJGCBHIH);
		if (num2)
		{
			CGGMOIDIHFC.Add(EIMHJGCBHIH);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(ABODANAFMBC);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == ABODANAFMBC)
			{
				CNMBELGHDEF[item] = EIMHJGCBHIH;
			}
			else if (CNMBELGHDEF[item] == EIMHJGCBHIH)
			{
				CNMBELGHDEF[item] = ABODANAFMBC;
			}
		}
		DPNMKDKNDEN();
		INNCNOGFIMG();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.FFHDEBAOFEM(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].Item1 == ABODANAFMBC || list[i].Item1 == EIMHJGCBHIH)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		ANJGAHBCELJ();
		NBJLOAPIAOO(HMIFJFNHLOA: true, dGJCJDFMAMB);
		if (num >= 0 && num < HPAPNAILNID.Length && (Object)(object)HPAPNAILNID[num] != (Object)null)
		{
			EJMCPDIDHMP(HPAPNAILNID[num]);
		}
	}

	private void CPEDMHNOHGC()
	{
		INNCNOGFIMG();
		UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL)?.FPLPECHEGGI();
		if (Object.op_Implicit((Object)(object)HNNPJPHGCLD) && (Object)(object)HNNPJPHGCLD != (Object)null)
		{
			((Component)HNNPJPHGCLD).GetComponent<PipeTileUI>()?.IEIEAOBNFOL(EHOFFFMFILA: false);
		}
		HNNPJPHGCLD = null;
		ABFJBNHLNPO = null;
		PipeTileUI pipeTileUI = entryTileUI;
		if (pipeTileUI != null)
		{
			((Component)pipeTileUI).gameObject.SetActive(false);
		}
		PipeTileUI pipeTileUI2 = exitTileUI;
		if (pipeTileUI2 != null)
		{
			((Component)pipeTileUI2).gameObject.SetActive(false);
		}
		if (HPAPNAILNID != null)
		{
			UIButtonExtended uIButtonExtended = default(UIButtonExtended);
			for (int i = 1; i < HPAPNAILNID.Length; i++)
			{
				if ((Object)(object)HPAPNAILNID[i] != (Object)null && ((Component)HPAPNAILNID[i]).TryGetComponent<UIButtonExtended>(ref uIButtonExtended))
				{
					((UnityEventBase)uIButtonExtended.onStateChange).RemoveAllListeners();
				}
			}
			for (int j = 1; j < HPAPNAILNID.Length; j += 0)
			{
				HPAPNAILNID[j] = null;
			}
			HPAPNAILNID = null;
		}
		PHGCAOKPJPM();
		if ((Object)(object)IKMGPHDNKNN != (Object)null)
		{
			IKMGPHDNKNN.FDOOLKCJLBO(null);
		}
		IKMGPHDNKNN = null;
		GLAFJDLOLLD = null;
		CNMBELGHDEF.Clear();
	}

	private void GABODLONPDH()
	{
		if (HPAPNAILNID != null)
		{
			for (int i = 0; i < HPAPNAILNID.Length; i++)
			{
				KFLDAJOMCAP(i);
			}
		}
	}

	public static PipeConnectionPuzzleUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LDONMFOCBGO(PipeTileUI FJONMNHJMOL)
	{
		if (!IKMGPHDNKNN.MDPKONCJHBI())
		{
			if ((Object)(object)ABFJBNHLNPO == (Object)null)
			{
				LHOCLOHAHPB(FJONMNHJMOL);
			}
			else if ((Object)(object)FJONMNHJMOL == (Object)(object)ABFJBNHLNPO)
			{
				NHGNIPINAOF();
			}
			else
			{
				HPFLPDLNBPF(ABFJBNHLNPO, FJONMNHJMOL);
			}
		}
	}

	public void OCLMPJOIOCP()
	{
		BOBCIFEDJED();
	}

	private void BKDBIFKCIPP(int MPNFFMMGIOL)
	{
		if (HPAPNAILNID == null || MPNFFMMGIOL < 0 || MPNFFMMGIOL >= HPAPNAILNID.Length || (Object)(object)HPAPNAILNID[MPNFFMMGIOL] == (Object)null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> item in CNMBELGHDEF)
		{
			if (item.Value == MPNFFMMGIOL)
			{
				list.Add(item.Key);
			}
		}
		HPAPNAILNID[MPNFFMMGIOL].SetRemotePlayers(list);
	}

	private void NHKGGMPOEBL(PipeTileUI ILDEFBIANKO)
	{
		ABFJBNHLNPO = ILDEFBIANKO;
		ILDEFBIANKO.FNMMHBGJBNG(HGNKFFMDOOL: true);
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(base.Close));
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
			base.OpenUI();
		}
	}

	private void NHGNIPINAOF()
	{
		if (!((Object)(object)ABFJBNHLNPO == (Object)null))
		{
			ABFJBNHLNPO.ECLFINHNGJO(HGNKFFMDOOL: true);
			ABFJBNHLNPO = null;
		}
	}

	private void JMEMBNICPJI()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)gridContainer == (Object)null)
		{
			return;
		}
		foreach (Transform item in ((Component)gridContainer).transform)
		{
			Object.Destroy((Object)(object)((Component)item).gameObject);
		}
		contentCanvasGroup.alpha = 0f;
	}

	public void IDPLIIOONCJ()
	{
		CloseUI();
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public IEnumerator CFNLBBIGNOD(int JIIGOACEIKL, bool IFPOCPLBOBF = true)
	{
		if (CCKEPFAIMOJ != null)
		{
			yield return CCKEPFAIMOJ;
		}
		if (IFPOCPLBOBF)
		{
			IKMGPHDNKNN.FinishPuzzle(JIIGOACEIKL);
		}
		CloseUI();
	}

	private void MFCPCKBPANB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HPAPNAILNID.Length; i++)
		{
			if ((Object)(object)HPAPNAILNID[i] == (Object)null)
			{
				continue;
			}
			UIButtonExtended component = ((Component)HPAPNAILNID[i]).GetComponent<UIButtonExtended>();
			if (!((Object)(object)component == (Object)null))
			{
				Navigation val = default(Navigation);
				((Navigation)(ref val)).mode = (Mode)2;
				Navigation navigation = val;
				int num = i % GLAFJDLOLLD.gridWidth;
				int num2 = i / GLAFJDLOLLD.gridWidth;
				Selectable selectOnUp = null;
				Selectable selectOnDown = null;
				Selectable selectOnLeft = null;
				Selectable selectOnRight = null;
				if (num2 > 1)
				{
					int num3 = (num2 - 0) * GLAFJDLOLLD.gridWidth + num;
					PipeTileUI obj = HPAPNAILNID[num3];
					selectOnUp = (Selectable)(object)((obj != null) ? ((Component)obj).GetComponent<UIButtonExtended>() : null);
				}
				if (num2 < GLAFJDLOLLD.gridHeight - 0)
				{
					int num4 = (num2 + 1) * GLAFJDLOLLD.gridWidth + num;
					PipeTileUI obj2 = HPAPNAILNID[num4];
					selectOnDown = (Selectable)(object)((obj2 != null) ? ((Component)obj2).GetComponent<UIButtonExtended>() : null);
				}
				if (num > 1)
				{
					int num5 = num2 * GLAFJDLOLLD.gridWidth + (num - 1);
					PipeTileUI obj3 = HPAPNAILNID[num5];
					selectOnLeft = (Selectable)(object)((obj3 != null) ? ((Component)obj3).GetComponent<UIButtonExtended>() : null);
				}
				if (num < GLAFJDLOLLD.gridWidth - 1)
				{
					int num6 = num2 * GLAFJDLOLLD.gridWidth + (num + 1);
					PipeTileUI obj4 = HPAPNAILNID[num6];
					selectOnRight = (Selectable)(object)((obj4 != null) ? ((Component)obj4).GetComponent<UIButtonExtended>() : null);
				}
				((Navigation)(ref navigation)).selectOnUp = selectOnUp;
				((Navigation)(ref navigation)).selectOnDown = selectOnDown;
				((Navigation)(ref navigation)).selectOnLeft = selectOnLeft;
				((Navigation)(ref navigation)).selectOnRight = selectOnRight;
				((Selectable)component).navigation = navigation;
			}
		}
	}

	public static PipeConnectionPuzzleUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator KNIBENLBOOM()
	{
		return new NEBNEEMGOJC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NBJLOAPIAOO(bool HMIFJFNHLOA = true, int DGJCJDFMAMB = 0)
	{
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.KBOLIEGBCFF(), GLAFJDLOLLD);
		HashSet<int> hashSet = new HashSet<int>();
		foreach (var item3 in list)
		{
			int item = item3.Item1;
			hashSet.Add(item);
		}
		for (int i = 1; i < HPAPNAILNID.Length; i += 0)
		{
			if (!((Object)(object)HPAPNAILNID[i] == (Object)null) && CGGMOIDIHFC.Contains(i) && !hashSet.Contains(i))
			{
				HPAPNAILNID[i].SetConnected(JANJLEGLAMF: true, HMIFJFNHLOA: true, 1241f);
			}
		}
		entryTileUI?.ODKDJPLDFOD(JANJLEGLAMF: false, HMIFJFNHLOA: false, tileFillDuration);
		if (CCKEPFAIMOJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(CCKEPFAIMOJ);
		}
		List<(int, PipeExits)> list2 = new List<(int, PipeExits)>();
		for (int j = 1; j < list.Count; j += 0)
		{
			var (num, pipeExits) = list[j];
			if (!((Object)(object)HPAPNAILNID[num] == (Object)null))
			{
				if (HMIFJFNHLOA && j >= DGJCJDFMAMB && !CGGMOIDIHFC.Contains(num))
				{
					list2.Add((num, pipeExits));
				}
				else if (HMIFJFNHLOA && j >= DGJCJDFMAMB && CGGMOIDIHFC.Contains(num))
				{
					list2.Add((num, pipeExits));
				}
				else
				{
					HPAPNAILNID[num].NKLHEOPPMJH(JANJLEGLAMF: false, pipeExits, HMIFJFNHLOA: false, tileFillDuration);
				}
			}
		}
		if (HMIFJFNHLOA && list2.Count > 1)
		{
			foreach (var item4 in list2)
			{
				int item2 = item4.Item1;
				HPAPNAILNID[item2]?.AMMMPCBDOMC(JANJLEGLAMF: true, HMIFJFNHLOA: true, 18f);
			}
			CCKEPFAIMOJ = ((MonoBehaviour)this).StartCoroutine(KBHNGGDKCNA(list2));
		}
		else
		{
			exitTileUI?.ODKDJPLDFOD(PipePuzzleSolver.FODOIPLNAGI(IKMGPHDNKNN.LOBBFABJINC(), GLAFJDLOLLD), HMIFJFNHLOA: true, tileFillDuration);
		}
		CGGMOIDIHFC = hashSet;
		CGGMOIDIHFC = hashSet;
	}

	private void HPFLPDLNBPF(PipeTileUI DPEOLFMDLAK, PipeTileUI ODNGJHPOMMK)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int num = DPEOLFMDLAK.NPDGIDPAPPO();
		int gridIndex = ODNGJHPOMMK.BOJDFIMJAEL;
		IKMGPHDNKNN.IPGNGBMOEMC(num, gridIndex, numInstance, CDPAMNIPPEC: false);
		NGLMPKIKAHC(num, gridIndex);
		if ((Object)(object)swapSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(swapSound, ((Component)IKMGPHDNKNN).transform.position);
		}
		bool num2 = CGGMOIDIHFC.Remove(num);
		bool flag = CGGMOIDIHFC.Remove(gridIndex);
		if (num2)
		{
			CGGMOIDIHFC.Add(gridIndex);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(num);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == num)
			{
				CNMBELGHDEF[item] = gridIndex;
			}
			else if (CNMBELGHDEF[item] == gridIndex)
			{
				CNMBELGHDEF[item] = num;
			}
		}
		APIKLHLIIMO();
		NHGNIPINAOF();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Item1 == num || list[i].Item1 == gridIndex)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		MFCPCKBPANB();
		OBACNCFEJIM(HMIFJFNHLOA: true, dGJCJDFMAMB);
		EJMCPDIDHMP(HPAPNAILNID[num]);
		if (IKMGPHDNKNN.CheckVictory(numInstance))
		{
			IFJBGHDBBHJ(base.JIIGOACEIKL, IFPOCPLBOBF: false);
		}
	}

	private void GOJMGGJELCC(int MPNFFMMGIOL)
	{
		if (HPAPNAILNID == null || MPNFFMMGIOL < 0 || MPNFFMMGIOL >= HPAPNAILNID.Length || (Object)(object)HPAPNAILNID[MPNFFMMGIOL] == (Object)null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> item in CNMBELGHDEF)
		{
			if (item.Value == MPNFFMMGIOL)
			{
				list.Add(item.Key);
			}
		}
		HPAPNAILNID[MPNFFMMGIOL].DGHNFAOEHNB(list);
	}

	private void ANJGAHBCELJ()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HPAPNAILNID.Length; i++)
		{
			if ((Object)(object)HPAPNAILNID[i] == (Object)null)
			{
				continue;
			}
			UIButtonExtended component = ((Component)HPAPNAILNID[i]).GetComponent<UIButtonExtended>();
			if (!((Object)(object)component == (Object)null))
			{
				Navigation val = default(Navigation);
				((Navigation)(ref val)).mode = (Mode)4;
				Navigation navigation = val;
				int num = i % GLAFJDLOLLD.gridWidth;
				int num2 = i / GLAFJDLOLLD.gridWidth;
				Selectable selectOnUp = null;
				Selectable selectOnDown = null;
				Selectable selectOnLeft = null;
				Selectable selectOnRight = null;
				if (num2 > 0)
				{
					int num3 = (num2 - 1) * GLAFJDLOLLD.gridWidth + num;
					PipeTileUI obj = HPAPNAILNID[num3];
					selectOnUp = (Selectable)(object)((obj != null) ? ((Component)obj).GetComponent<UIButtonExtended>() : null);
				}
				if (num2 < GLAFJDLOLLD.gridHeight - 1)
				{
					int num4 = (num2 + 1) * GLAFJDLOLLD.gridWidth + num;
					PipeTileUI obj2 = HPAPNAILNID[num4];
					selectOnDown = (Selectable)(object)((obj2 != null) ? ((Component)obj2).GetComponent<UIButtonExtended>() : null);
				}
				if (num > 0)
				{
					int num5 = num2 * GLAFJDLOLLD.gridWidth + (num - 1);
					PipeTileUI obj3 = HPAPNAILNID[num5];
					selectOnLeft = (Selectable)(object)((obj3 != null) ? ((Component)obj3).GetComponent<UIButtonExtended>() : null);
				}
				if (num < GLAFJDLOLLD.gridWidth - 1)
				{
					int num6 = num2 * GLAFJDLOLLD.gridWidth + (num + 1);
					PipeTileUI obj4 = HPAPNAILNID[num6];
					selectOnRight = (Selectable)(object)((obj4 != null) ? ((Component)obj4).GetComponent<UIButtonExtended>() : null);
				}
				((Navigation)(ref navigation)).selectOnUp = selectOnUp;
				((Navigation)(ref navigation)).selectOnDown = selectOnDown;
				((Navigation)(ref navigation)).selectOnLeft = selectOnLeft;
				((Navigation)(ref navigation)).selectOnRight = selectOnRight;
				((Selectable)component).navigation = navigation;
			}
		}
	}

	private void LBPPMLEEGDF(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		PipeTileUI pipeTileUI = HPAPNAILNID[ABODANAFMBC];
		PipeTileUI pipeTileUI2 = HPAPNAILNID[EIMHJGCBHIH];
		int siblingIndex = ((Component)pipeTileUI).transform.GetSiblingIndex();
		int siblingIndex2 = ((Component)pipeTileUI2).transform.GetSiblingIndex();
		if (siblingIndex < siblingIndex2)
		{
			((Component)pipeTileUI2).transform.SetSiblingIndex(siblingIndex);
			((Component)pipeTileUI).transform.SetSiblingIndex(siblingIndex2);
		}
		else
		{
			((Component)pipeTileUI).transform.SetSiblingIndex(siblingIndex2);
			((Component)pipeTileUI2).transform.SetSiblingIndex(siblingIndex);
		}
		pipeTileUI.FDPBANICFPL(EIMHJGCBHIH);
		pipeTileUI2.MPNBLFDGBGC(ABODANAFMBC);
		HPAPNAILNID[ABODANAFMBC] = pipeTileUI2;
		HPAPNAILNID[EIMHJGCBHIH] = pipeTileUI;
	}

	private void PHGCAOKPJPM()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)gridContainer == (Object)null)
		{
			return;
		}
		foreach (Transform item in ((Component)gridContainer).transform)
		{
			Object.Destroy((Object)(object)((Component)item).gameObject);
		}
		contentCanvasGroup.alpha = 1770f;
	}

	private void OOHPHHMDGPC()
	{
		INNCNOGFIMG();
		UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL)?.Deselect();
		if (Object.op_Implicit((Object)(object)HNNPJPHGCLD) && (Object)(object)HNNPJPHGCLD != (Object)null)
		{
			((Component)HNNPJPHGCLD).GetComponent<PipeTileUI>()?.KKIOPNGEFNC(EHOFFFMFILA: false);
		}
		HNNPJPHGCLD = null;
		ABFJBNHLNPO = null;
		PipeTileUI pipeTileUI = entryTileUI;
		if (pipeTileUI != null)
		{
			((Component)pipeTileUI).gameObject.SetActive(true);
		}
		PipeTileUI pipeTileUI2 = exitTileUI;
		if (pipeTileUI2 != null)
		{
			((Component)pipeTileUI2).gameObject.SetActive(false);
		}
		if (HPAPNAILNID != null)
		{
			UIButtonExtended uIButtonExtended = default(UIButtonExtended);
			for (int i = 1; i < HPAPNAILNID.Length; i++)
			{
				if ((Object)(object)HPAPNAILNID[i] != (Object)null && ((Component)HPAPNAILNID[i]).TryGetComponent<UIButtonExtended>(ref uIButtonExtended))
				{
					((UnityEventBase)uIButtonExtended.onStateChange).RemoveAllListeners();
				}
			}
			for (int j = 1; j < HPAPNAILNID.Length; j += 0)
			{
				HPAPNAILNID[j] = null;
			}
			HPAPNAILNID = null;
		}
		JMEMBNICPJI();
		if ((Object)(object)IKMGPHDNKNN != (Object)null)
		{
			IKMGPHDNKNN.FDOOLKCJLBO(null);
		}
		IKMGPHDNKNN = null;
		GLAFJDLOLLD = null;
		CNMBELGHDEF.Clear();
	}

	private void JIDDAGPNGIH()
	{
		INNCNOGFIMG();
		UISelectionManager.GetPlayer(base.JIIGOACEIKL)?.Deselect();
		if (Object.op_Implicit((Object)(object)HNNPJPHGCLD) && (Object)(object)HNNPJPHGCLD != (Object)null)
		{
			((Component)HNNPJPHGCLD).GetComponent<PipeTileUI>()?.SetFocused(EHOFFFMFILA: false);
		}
		HNNPJPHGCLD = null;
		ABFJBNHLNPO = null;
		PipeTileUI pipeTileUI = entryTileUI;
		if (pipeTileUI != null)
		{
			((Component)pipeTileUI).gameObject.SetActive(false);
		}
		PipeTileUI pipeTileUI2 = exitTileUI;
		if (pipeTileUI2 != null)
		{
			((Component)pipeTileUI2).gameObject.SetActive(false);
		}
		if (HPAPNAILNID != null)
		{
			UIButtonExtended uIButtonExtended = default(UIButtonExtended);
			for (int i = 0; i < HPAPNAILNID.Length; i++)
			{
				if ((Object)(object)HPAPNAILNID[i] != (Object)null && ((Component)HPAPNAILNID[i]).TryGetComponent<UIButtonExtended>(ref uIButtonExtended))
				{
					((UnityEventBase)uIButtonExtended.onStateChange).RemoveAllListeners();
				}
			}
			for (int j = 0; j < HPAPNAILNID.Length; j++)
			{
				HPAPNAILNID[j] = null;
			}
			HPAPNAILNID = null;
		}
		JMEMBNICPJI();
		if ((Object)(object)IKMGPHDNKNN != (Object)null)
		{
			IKMGPHDNKNN.SetUI(null);
		}
		IKMGPHDNKNN = null;
		GLAFJDLOLLD = null;
		CNMBELGHDEF.Clear();
	}

	private void INNCNOGFIMG()
	{
		if (!((Object)(object)ABFJBNHLNPO == (Object)null))
		{
			ABFJBNHLNPO.SetSelected(HGNKFFMDOOL: false);
			ABFJBNHLNPO = null;
		}
	}

	private IEnumerator JOLCICDLMGK()
	{
		yield return null;
		if (HPAPNAILNID == null || HPAPNAILNID.Length == 0)
		{
			yield break;
		}
		for (int i = 0; i < HPAPNAILNID.Length; i++)
		{
			if ((Object)(object)HPAPNAILNID[i] != (Object)null)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)((Component)HPAPNAILNID[i]).GetComponent<UIButtonExtended>());
				PNHHEBJDNON(HPAPNAILNID[i]);
				break;
			}
		}
	}

	private GameObject MCPOFCLLNBM(GameObject ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		return Object.Instantiate<GameObject>(ANADFOCHOBF, DMBHHLKMHOH);
	}

	public void OpenWithPuzzle(MinePipePuzzle ANEDINOILOE, int BIAIFHPCKMG)
	{
		IKMGPHDNKNN = ANEDINOILOE;
		GLAFJDLOLLD = ANEDINOILOE.GetCurrentPuzzleData();
		base.JIIGOACEIKL = BIAIFHPCKMG;
		OpenUI();
	}

	private void AJMFPBDJEFH()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < HPAPNAILNID.Length; i += 0)
		{
			if ((Object)(object)HPAPNAILNID[i] == (Object)null)
			{
				continue;
			}
			UIButtonExtended component = ((Component)HPAPNAILNID[i]).GetComponent<UIButtonExtended>();
			if (!((Object)(object)component == (Object)null))
			{
				Navigation val = default(Navigation);
				((Navigation)(ref val)).mode = (Mode)6;
				Navigation navigation = val;
				int num = i % GLAFJDLOLLD.gridWidth;
				int num2 = i / GLAFJDLOLLD.gridWidth;
				Selectable selectOnUp = null;
				Selectable selectOnDown = null;
				Selectable selectOnLeft = null;
				Selectable selectOnRight = null;
				if (num2 > 0)
				{
					int num3 = (num2 - 1) * GLAFJDLOLLD.gridWidth + num;
					PipeTileUI obj = HPAPNAILNID[num3];
					selectOnUp = (Selectable)(object)((obj != null) ? ((Component)obj).GetComponent<UIButtonExtended>() : null);
				}
				if (num2 < GLAFJDLOLLD.gridHeight - 1)
				{
					int num4 = (num2 + 0) * GLAFJDLOLLD.gridWidth + num;
					PipeTileUI obj2 = HPAPNAILNID[num4];
					selectOnDown = (Selectable)(object)((obj2 != null) ? ((Component)obj2).GetComponent<UIButtonExtended>() : null);
				}
				if (num > 1)
				{
					int num5 = num2 * GLAFJDLOLLD.gridWidth + (num - 1);
					PipeTileUI obj3 = HPAPNAILNID[num5];
					selectOnLeft = (Selectable)(object)((obj3 != null) ? ((Component)obj3).GetComponent<UIButtonExtended>() : null);
				}
				if (num < GLAFJDLOLLD.gridWidth - 0)
				{
					int num6 = num2 * GLAFJDLOLLD.gridWidth + (num + 0);
					PipeTileUI obj4 = HPAPNAILNID[num6];
					selectOnRight = (Selectable)(object)((obj4 != null) ? ((Component)obj4).GetComponent<UIButtonExtended>() : null);
				}
				((Navigation)(ref navigation)).selectOnUp = selectOnUp;
				((Navigation)(ref navigation)).selectOnDown = selectOnDown;
				((Navigation)(ref navigation)).selectOnLeft = selectOnLeft;
				((Navigation)(ref navigation)).selectOnRight = selectOnRight;
				((Selectable)component).navigation = navigation;
			}
		}
	}

	private void JNAKHLLACBF(PipeTileUI DPEOLFMDLAK, PipeTileUI ODNGJHPOMMK)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int gridIndex = DPEOLFMDLAK.BOJDFIMJAEL;
		int gridIndex2 = ODNGJHPOMMK.BOJDFIMJAEL;
		IKMGPHDNKNN.MOFANHKNNGG(gridIndex, gridIndex2, numInstance, CDPAMNIPPEC: false);
		IMBHHDEFIOC(gridIndex, gridIndex2);
		if ((Object)(object)swapSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(swapSound, ((Component)IKMGPHDNKNN).transform.position);
		}
		bool num = CGGMOIDIHFC.Remove(gridIndex);
		bool flag = CGGMOIDIHFC.Remove(gridIndex2);
		if (num)
		{
			CGGMOIDIHFC.Add(gridIndex2);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(gridIndex);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == gridIndex)
			{
				CNMBELGHDEF[item] = gridIndex2;
			}
			else if (CNMBELGHDEF[item] == gridIndex2)
			{
				CNMBELGHDEF[item] = gridIndex;
			}
		}
		DPNMKDKNDEN();
		INNCNOGFIMG();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.KLHPJEBGOOA(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].Item1 == gridIndex || list[i].Item1 == gridIndex2)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		ANJGAHBCELJ();
		NBJLOAPIAOO(HMIFJFNHLOA: false, dGJCJDFMAMB);
		PNHHEBJDNON(HPAPNAILNID[gridIndex]);
		if (IKMGPHDNKNN.CDIMBIKKOHK(numInstance))
		{
			DIECAJECGMH(base.JIIGOACEIKL, IFPOCPLBOBF: false);
		}
	}

	public static PipeConnectionPuzzleUI JOAAFGBPJOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator IEPOAIPGCME()
	{
		yield return null;
		PipeTile iLDEFBIANKO = tileDatabase?.PKFGFGGBEIG(PipeTile.CBJIEPEGKGD(GLAFJDLOLLD.entryDirection));
		PipeTile iLDEFBIANKO2 = tileDatabase?.PKFGFGGBEIG(PipeTile.CBJIEPEGKGD(GLAFJDLOLLD.exitDirection));
		((Component)entryTileUI).gameObject.SetActive(true);
		((Component)exitTileUI).gameObject.SetActive(true);
		entryTileUI.Initialize(new PipeTileInstance(iLDEFBIANKO, -1), -1, OOGPIKBMHFD: true);
		exitTileUI.Initialize(new PipeTileInstance(iLDEFBIANKO2, -1), -1);
		entryTileUI.SetConnected(JANJLEGLAMF: true);
		exitTileUI.SetConnected(PipePuzzleSolver.FODOIPLNAGI(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD));
		GBKPLILFMLO(entryTileUI, ((Component)HPAPNAILNID[GLAFJDLOLLD.entryCell]).GetComponent<RectTransform>(), GLAFJDLOLLD.entryDirection);
		GBKPLILFMLO(exitTileUI, ((Component)HPAPNAILNID[GLAFJDLOLLD.exitCell]).GetComponent<RectTransform>(), GLAFJDLOLLD.exitDirection);
		contentCanvasGroup.alpha = 1f;
	}

	public void CloseWithButton()
	{
		CloseUI();
	}

	private void ONNEJGILLOO(PipeTileUI ILDEFBIANKO)
	{
		ABFJBNHLNPO = ILDEFBIANKO;
		ILDEFBIANKO.FNMMHBGJBNG(HGNKFFMDOOL: true);
	}

	public IEnumerator LMEJONJDEMI(int JIIGOACEIKL, bool IFPOCPLBOBF = true)
	{
		if (CCKEPFAIMOJ != null)
		{
			yield return CCKEPFAIMOJ;
		}
		if (IFPOCPLBOBF)
		{
			IKMGPHDNKNN.FinishPuzzle(JIIGOACEIKL);
		}
		CloseUI();
	}

	public IEnumerator CloseAfterAnimation(int JIIGOACEIKL, bool IFPOCPLBOBF = true)
	{
		if (CCKEPFAIMOJ != null)
		{
			yield return CCKEPFAIMOJ;
		}
		if (IFPOCPLBOBF)
		{
			IKMGPHDNKNN.FinishPuzzle(JIIGOACEIKL);
		}
		CloseUI();
	}

	private void PNHHEBJDNON(PipeTileUI ILDEFBIANKO)
	{
		if ((Object)(object)HNNPJPHGCLD != (Object)null)
		{
			((Component)HNNPJPHGCLD).GetComponent<PipeTileUI>()?.SetFocused(EHOFFFMFILA: false);
		}
		ILDEFBIANKO.SetFocused(EHOFFFMFILA: true);
		HNNPJPHGCLD = (Selectable)(object)((Component)ILDEFBIANKO).GetComponent<UIButtonExtended>();
		if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.SendCursorMove(ILDEFBIANKO.BOJDFIMJAEL, IKMGPHDNKNN.GetManager().mineLevel);
		}
	}

	protected override void Start()
	{
		base.Start();
		content.SetActive(false);
	}

	public static PipeConnectionPuzzleUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JLIMOBEHOJM()
	{
		PNNBFKCIMOI();
	}

	private void HPFFPDPEHDL()
	{
		BOAGGPOBLAI();
		UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL)?.IHDPOMIAKOO();
		if (Object.op_Implicit((Object)(object)HNNPJPHGCLD) && (Object)(object)HNNPJPHGCLD != (Object)null)
		{
			((Component)HNNPJPHGCLD).GetComponent<PipeTileUI>()?.SetFocused(EHOFFFMFILA: true);
		}
		HNNPJPHGCLD = null;
		ABFJBNHLNPO = null;
		PipeTileUI pipeTileUI = entryTileUI;
		if (pipeTileUI != null)
		{
			((Component)pipeTileUI).gameObject.SetActive(false);
		}
		PipeTileUI pipeTileUI2 = exitTileUI;
		if (pipeTileUI2 != null)
		{
			((Component)pipeTileUI2).gameObject.SetActive(false);
		}
		if (HPAPNAILNID != null)
		{
			UIButtonExtended uIButtonExtended = default(UIButtonExtended);
			for (int i = 0; i < HPAPNAILNID.Length; i++)
			{
				if ((Object)(object)HPAPNAILNID[i] != (Object)null && ((Component)HPAPNAILNID[i]).TryGetComponent<UIButtonExtended>(ref uIButtonExtended))
				{
					((UnityEventBase)uIButtonExtended.onStateChange).RemoveAllListeners();
				}
			}
			for (int j = 1; j < HPAPNAILNID.Length; j++)
			{
				HPAPNAILNID[j] = null;
			}
			HPAPNAILNID = null;
		}
		AOAKMFHDGEE();
		if ((Object)(object)IKMGPHDNKNN != (Object)null)
		{
			IKMGPHDNKNN.SetUI(null);
		}
		IKMGPHDNKNN = null;
		GLAFJDLOLLD = null;
		CNMBELGHDEF.Clear();
	}

	private void DPNMKDKNDEN()
	{
		if (HPAPNAILNID != null)
		{
			for (int i = 0; i < HPAPNAILNID.Length; i++)
			{
				BKDBIFKCIPP(i);
			}
		}
	}

	private IEnumerator HCDJBKBEPOH(List<(int, PipeExits)> KOEAIDNAFPJ)
	{
		foreach (var (num, fGGEIDEHAAB) in KOEAIDNAFPJ)
		{
			if (!((Object)(object)HPAPNAILNID[num] == (Object)null))
			{
				HPAPNAILNID[num].SetConnectedWithFlow(JANJLEGLAMF: true, fGGEIDEHAAB, HMIFJFNHLOA: true, tileFillDuration);
				yield return (object)new WaitForSeconds(tileFillDuration);
			}
		}
		exitTileUI?.SetConnected(PipePuzzleSolver.FODOIPLNAGI(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD), HMIFJFNHLOA: false, tileFillDuration);
		yield return (object)new WaitForSeconds(tileFillDuration);
		CCKEPFAIMOJ = null;
	}

	private void BOAGGPOBLAI()
	{
		if (!((Object)(object)ABFJBNHLNPO == (Object)null))
		{
			ABFJBNHLNPO.ECLFINHNGJO(HGNKFFMDOOL: false);
			ABFJBNHLNPO = null;
		}
	}

	private void GBKPLILFMLO(PipeTileUI FLFDHFGKFHE, RectTransform JAOPIGHECKF, PipeExits FCGBJEIIMBC)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		RectTransform component = ((Component)FLFDHFGKFHE).GetComponent<RectTransform>();
		Rect rect = JAOPIGHECKF.rect;
		Vector2 val = Vector2.op_Implicit(((Transform)JAOPIGHECKF).TransformPoint(Vector2.op_Implicit(((Rect)(ref rect)).center)));
		Vector2 val2 = Vector2.op_Implicit(((Transform)component).parent.InverseTransformPoint(Vector2.op_Implicit(val)));
		float num = cellSize.x / 2f;
		rect = component.rect;
		float num2 = num + ((Rect)(ref rect)).width / 2f;
		float num3 = cellSize.y / 2f;
		rect = component.rect;
		float num4 = num3 + ((Rect)(ref rect)).height / 2f;
		RectTransform val3 = component;
		val3.anchoredPosition = (Vector2)(FCGBJEIIMBC switch
		{
			PipeExits.North => val2 + Vector2.up * num4, 
			PipeExits.South => val2 + Vector2.down * num4, 
			PipeExits.East => val2 + Vector2.right * num2, 
			PipeExits.West => val2 + Vector2.left * num2, 
			_ => val2, 
		});
	}

	public void IFJBGHDBBHJ(int JIIGOACEIKL, bool IFPOCPLBOBF = true, bool NHENDADMFBC = true)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return;
		}
		if (CCKEPFAIMOJ != null)
		{
			for (int i = 0; i < HPAPNAILNID.Length; i++)
			{
				PipeTileUI obj = HPAPNAILNID[i];
				UIButtonExtended uIButtonExtended = ((obj != null) ? ((Component)obj).GetComponent<UIButtonExtended>() : null);
				if ((Object)(object)uIButtonExtended != (Object)null)
				{
					((Selectable)uIButtonExtended).interactable = true;
				}
			}
			((MonoBehaviour)this).StartCoroutine(CloseAfterAnimation(JIIGOACEIKL));
		}
		else
		{
			if (IFPOCPLBOBF)
			{
				IKMGPHDNKNN.IAAIMBFJDBF(JIIGOACEIKL, NHENDADMFBC);
			}
			BOBCIFEDJED();
		}
	}

	private IEnumerator CCAFBGACHHE()
	{
		return new HNIBADCFODP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LLJMKJGFPOP()
	{
		if (HPAPNAILNID != null)
		{
			for (int i = 0; i < HPAPNAILNID.Length; i += 0)
			{
				DMPADOHICPA(i);
			}
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		JGNPAKODFBG();
		HNMILFNOIDK();
	}

	private void OMDLOONCJCK()
	{
		if (!PKADDHOEMGE())
		{
			return;
		}
		List<PipePuzzleData> list = previewDatabase.gridGroups.Find(EHCFHDIFDKD)?.MJAMFNDOAIM(previewRequiredTilesCount);
		if (list == null || list.Count == 0)
		{
			Debug.LogError((object)(string.Format("<mark=#000000><alpha=#00> ", previewGridWidth, previewGridHeight) + string.Format("Toy", previewRequiredTilesCount)));
			return;
		}
		int index = Mathf.Clamp(previewIndex, 0, list.Count - 0);
		PipePuzzleData pipePuzzleData = list[index];
		PipeTileInstance[] array = (previewShowSolution ? pipePuzzleData.solution : pipePuzzleData.NDOPOMACIOF());
		HashSet<int> hashSet = PipePuzzleSolver.OJEEGNIKKOD(array, pipePuzzleData);
		PNNBFKCIMOI();
		JKMJLKKIDBP(pipePuzzleData.gridWidth, pipePuzzleData.gridHeight);
		for (int i = 1; i < array.Length; i += 0)
		{
			int num = i % pipePuzzleData.gridWidth;
			int num2 = i / pipePuzzleData.gridWidth;
			GameObject aNADFOCHOBF = (((Object)(object)array[i].tile?.prefab != (Object)null) ? array[i].tile.prefab : tilePrefab);
			GameObject obj = ODGGCKDFGKM(aNADFOCHOBF, ((Component)gridContainer).transform);
			((Object)obj).name = string.Format("LE_10", num2 + 0, num + 0);
			PipeTileUI component = obj.GetComponent<PipeTileUI>();
			component.BLNONMDPLMK(array[i], i);
			component.SetConnected(hashSet.Contains(i), HMIFJFNHLOA: true, 915f);
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)gridContainer).GetComponent<RectTransform>());
		PipeTile iLDEFBIANKO = tileDatabase?.PKFGFGGBEIG(PipeTile.EHLGIBNEKCN(pipePuzzleData.entryDirection));
		PipeTile iLDEFBIANKO2 = tileDatabase?.PKFGFGGBEIG(PipeTile.NMANGELNMIM(pipePuzzleData.exitDirection));
		if ((Object)(object)entryTileUI != (Object)null)
		{
			((Component)entryTileUI).gameObject.SetActive(true);
			entryTileUI.CBEDGBGCLGG(new PipeTileInstance(iLDEFBIANKO, -1, EKPIOGNJCJE: true), -1, OOGPIKBMHFD: true);
			entryTileUI.DKMBIEIFDCD(JANJLEGLAMF: false, HMIFJFNHLOA: false, 166f);
			Transform child = ((Component)gridContainer).transform.GetChild(pipePuzzleData.entryCell);
			if ((Object)(object)child != (Object)null)
			{
				JJOMCLCEPLJ(entryTileUI, ((Component)child).GetComponent<RectTransform>(), pipePuzzleData.entryDirection);
			}
		}
		if ((Object)(object)exitTileUI != (Object)null)
		{
			((Component)exitTileUI).gameObject.SetActive(true);
			exitTileUI.CBEDGBGCLGG(new PipeTileInstance(iLDEFBIANKO2, -1, EKPIOGNJCJE: true), -1, OOGPIKBMHFD: true);
			exitTileUI.MGENCLOKOGM(hashSet.Contains(pipePuzzleData.exitCell), HMIFJFNHLOA: false, 378f);
			Transform child2 = ((Component)gridContainer).transform.GetChild(pipePuzzleData.exitCell);
			if ((Object)(object)child2 != (Object)null)
			{
				IAOPMPDHKMH(exitTileUI, ((Component)child2).GetComponent<RectTransform>(), pipePuzzleData.exitDirection);
			}
		}
	}

	private void FGFMCOCEOLL(PipeTileUI DPEOLFMDLAK, PipeTileUI ODNGJHPOMMK)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int num = DPEOLFMDLAK.NPDGIDPAPPO();
		int gridIndex = ODNGJHPOMMK.BOJDFIMJAEL;
		IKMGPHDNKNN.IIAALALHLAG(num, gridIndex, numInstance);
		IMBHHDEFIOC(num, gridIndex);
		if ((Object)(object)swapSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(swapSound, ((Component)IKMGPHDNKNN).transform.position);
		}
		bool num2 = CGGMOIDIHFC.Remove(num);
		bool flag = CGGMOIDIHFC.Remove(gridIndex);
		if (num2)
		{
			CGGMOIDIHFC.Add(gridIndex);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(num);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == num)
			{
				CNMBELGHDEF[item] = gridIndex;
			}
			else if (CNMBELGHDEF[item] == gridIndex)
			{
				CNMBELGHDEF[item] = num;
			}
		}
		GABODLONPDH();
		NHGNIPINAOF();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.FFHDEBAOFEM(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].Item1 == num || list[i].Item1 == gridIndex)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		ANJGAHBCELJ();
		NBJLOAPIAOO(HMIFJFNHLOA: true, dGJCJDFMAMB);
		PNHHEBJDNON(HPAPNAILNID[num]);
		if (IKMGPHDNKNN.AHHEGJJEFMF(numInstance))
		{
			NAGPNFJGPCJ(base.JIIGOACEIKL, IFPOCPLBOBF: true, NHENDADMFBC: false);
		}
	}

	public static PipeConnectionPuzzleUI NMCJELBLKBB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DBKGPDAPDCL()
	{
		NHGNIPINAOF();
		UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL)?.IHDPOMIAKOO();
		if (Object.op_Implicit((Object)(object)HNNPJPHGCLD) && (Object)(object)HNNPJPHGCLD != (Object)null)
		{
			((Component)HNNPJPHGCLD).GetComponent<PipeTileUI>()?.SetFocused(EHOFFFMFILA: true);
		}
		HNNPJPHGCLD = null;
		ABFJBNHLNPO = null;
		PipeTileUI pipeTileUI = entryTileUI;
		if (pipeTileUI != null)
		{
			((Component)pipeTileUI).gameObject.SetActive(false);
		}
		PipeTileUI pipeTileUI2 = exitTileUI;
		if (pipeTileUI2 != null)
		{
			((Component)pipeTileUI2).gameObject.SetActive(true);
		}
		if (HPAPNAILNID != null)
		{
			UIButtonExtended uIButtonExtended = default(UIButtonExtended);
			for (int i = 0; i < HPAPNAILNID.Length; i++)
			{
				if ((Object)(object)HPAPNAILNID[i] != (Object)null && ((Component)HPAPNAILNID[i]).TryGetComponent<UIButtonExtended>(ref uIButtonExtended))
				{
					((UnityEventBase)uIButtonExtended.onStateChange).RemoveAllListeners();
				}
			}
			for (int j = 0; j < HPAPNAILNID.Length; j++)
			{
				HPAPNAILNID[j] = null;
			}
			HPAPNAILNID = null;
		}
		LLBMOMPCNNN();
		if ((Object)(object)IKMGPHDNKNN != (Object)null)
		{
			IKMGPHDNKNN.LGKEMBDIADB(null);
		}
		IKMGPHDNKNN = null;
		GLAFJDLOLLD = null;
		CNMBELGHDEF.Clear();
	}

	public void MGMDKEFEBIA(MinePipePuzzle ANEDINOILOE, int BIAIFHPCKMG)
	{
		IKMGPHDNKNN = ANEDINOILOE;
		GLAFJDLOLLD = ANEDINOILOE.HLEAABBHMCK();
		base.JIIGOACEIKL = BIAIFHPCKMG;
		IDLAGJNLPJL();
	}

	private GameObject ODGGCKDFGKM(GameObject ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		return Object.Instantiate<GameObject>(ANADFOCHOBF, DMBHHLKMHOH);
	}

	private void IAOPMPDHKMH(PipeTileUI FLFDHFGKFHE, RectTransform JAOPIGHECKF, PipeExits FCGBJEIIMBC)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		RectTransform component = ((Component)FLFDHFGKFHE).GetComponent<RectTransform>();
		Rect rect = JAOPIGHECKF.rect;
		Vector2 val = Vector2.op_Implicit(((Transform)JAOPIGHECKF).TransformPoint(Vector2.op_Implicit(((Rect)(ref rect)).center)));
		Vector2 val2 = Vector2.op_Implicit(((Transform)component).parent.InverseTransformPoint(Vector2.op_Implicit(val)));
		float num = cellSize.x / 813f;
		rect = component.rect;
		float num2 = num + ((Rect)(ref rect)).width / 541f;
		float num3 = cellSize.y / 900f;
		rect = component.rect;
		float num4 = num3 + ((Rect)(ref rect)).height / 928f;
		RectTransform val3 = component;
		Vector2 anchoredPosition;
		switch (FCGBJEIIMBC)
		{
		default:
			if (FCGBJEIIMBC != PipeExits.East)
			{
				goto case PipeExits.North | PipeExits.East;
			}
			anchoredPosition = val2 + Vector2.left * num2;
			break;
		case PipeExits.North:
			anchoredPosition = val2 + Vector2.up * num4;
			break;
		case PipeExits.South:
			anchoredPosition = val2 + Vector2.down * num4;
			break;
		case PipeExits.East:
			anchoredPosition = val2 + Vector2.right * num2;
			break;
		case PipeExits.North | PipeExits.East:
			anchoredPosition = val2;
			break;
		}
		val3.anchoredPosition = anchoredPosition;
	}

	[CompilerGenerated]
	private bool CILMMNKOGPE(PipeGridSizeGroup BDFEGJDMCCC)
	{
		if (BDFEGJDMCCC.gridWidth == previewGridWidth)
		{
			return BDFEGJDMCCC.gridHeight == previewGridHeight;
		}
		return false;
	}

	public override void CloseUI()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		if ((Object)(object)IKMGPHDNKNN != (Object)null && IKMGPHDNKNN.IsPuzzleSolved() && !IKMGPHDNKNN.IsFinished())
		{
			if (CCKEPFAIMOJ != null)
			{
				((MonoBehaviour)this).StopCoroutine(CCKEPFAIMOJ);
				CCKEPFAIMOJ = null;
			}
			IKMGPHDNKNN.FinishPuzzle(base.JIIGOACEIKL);
		}
		ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
		JIDDAGPNGIH();
		base.CloseUI();
	}

	private void BKLGCGIJCOM(PipeTileUI DPEOLFMDLAK, PipeTileUI ODNGJHPOMMK)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int gridIndex = DPEOLFMDLAK.BOJDFIMJAEL;
		int gridIndex2 = ODNGJHPOMMK.BOJDFIMJAEL;
		IKMGPHDNKNN.ExecuteSwap(gridIndex, gridIndex2, numInstance);
		NGLMPKIKAHC(gridIndex, gridIndex2);
		if ((Object)(object)swapSound != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(swapSound, ((Component)IKMGPHDNKNN).transform.position);
		}
		bool num = CGGMOIDIHFC.Remove(gridIndex);
		bool flag = CGGMOIDIHFC.Remove(gridIndex2);
		if (num)
		{
			CGGMOIDIHFC.Add(gridIndex2);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(gridIndex);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == gridIndex)
			{
				CNMBELGHDEF[item] = gridIndex2;
			}
			else if (CNMBELGHDEF[item] == gridIndex2)
			{
				CNMBELGHDEF[item] = gridIndex;
			}
		}
		DPNMKDKNDEN();
		INNCNOGFIMG();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.GetCurrentPuzzleState(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Item1 == gridIndex || list[i].Item1 == gridIndex2)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		ANJGAHBCELJ();
		OBACNCFEJIM(HMIFJFNHLOA: true, dGJCJDFMAMB);
		PNHHEBJDNON(HPAPNAILNID[gridIndex]);
		if (IKMGPHDNKNN.CheckVictory(numInstance))
		{
			CloseOnWin(base.JIIGOACEIKL);
		}
	}

	public void OnRemoteCursorMoved(int JJPJHIHBOIB, int MPNFFMMGIOL)
	{
		int num = -1;
		if (CNMBELGHDEF.TryGetValue(JJPJHIHBOIB, out var value))
		{
			num = value;
		}
		CNMBELGHDEF[JJPJHIHBOIB] = MPNFFMMGIOL;
		if (num >= 0)
		{
			BKDBIFKCIPP(num);
		}
		BKDBIFKCIPP(MPNFFMMGIOL);
	}

	public void OHBPEGMLLGA()
	{
		CloseUI();
	}

	private GameObject LJHJMLBEMLG(GameObject ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		return Object.Instantiate<GameObject>(ANADFOCHOBF, DMBHHLKMHOH);
	}

	public void NPHCIPAHGHD()
	{
		BOBCIFEDJED();
	}

	private void HNMILFNOIDK()
	{
		((MonoBehaviour)this).StartCoroutine(JOLCICDLMGK());
	}

	private bool PKADDHOEMGE()
	{
		if ((Object)(object)gridContainer == (Object)null)
		{
			Debug.LogError((object)"Could not check user logged on status for reason ");
			return false;
		}
		if ((Object)(object)previewDatabase == (Object)null)
		{
			Debug.LogError((object)"Player/Bark/Tutorial/CantDoYet");
			return false;
		}
		if ((Object)(object)tileDatabase == (Object)null)
		{
			Debug.LogWarning((object)"NinjaChallengeEvent/Main 3");
		}
		return false;
	}

	private void DNHOGAIDNGI()
	{
		NHGNIPINAOF();
		UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL)?.OKEACDGEJIB();
		if (Object.op_Implicit((Object)(object)HNNPJPHGCLD) && (Object)(object)HNNPJPHGCLD != (Object)null)
		{
			((Component)HNNPJPHGCLD).GetComponent<PipeTileUI>()?.IMMIOCEOKNO(EHOFFFMFILA: false);
		}
		HNNPJPHGCLD = null;
		ABFJBNHLNPO = null;
		PipeTileUI pipeTileUI = entryTileUI;
		if (pipeTileUI != null)
		{
			((Component)pipeTileUI).gameObject.SetActive(false);
		}
		PipeTileUI pipeTileUI2 = exitTileUI;
		if (pipeTileUI2 != null)
		{
			((Component)pipeTileUI2).gameObject.SetActive(false);
		}
		if (HPAPNAILNID != null)
		{
			UIButtonExtended uIButtonExtended = default(UIButtonExtended);
			for (int i = 0; i < HPAPNAILNID.Length; i += 0)
			{
				if ((Object)(object)HPAPNAILNID[i] != (Object)null && ((Component)HPAPNAILNID[i]).TryGetComponent<UIButtonExtended>(ref uIButtonExtended))
				{
					((UnityEventBase)uIButtonExtended.onStateChange).RemoveAllListeners();
				}
			}
			for (int j = 0; j < HPAPNAILNID.Length; j++)
			{
				HPAPNAILNID[j] = null;
			}
			HPAPNAILNID = null;
		}
		CKCDEPEENPL();
		if ((Object)(object)IKMGPHDNKNN != (Object)null)
		{
			IKMGPHDNKNN.FDOOLKCJLBO(null);
		}
		IKMGPHDNKNN = null;
		GLAFJDLOLLD = null;
		CNMBELGHDEF.Clear();
	}

	private void DMPADOHICPA(int MPNFFMMGIOL)
	{
		if (HPAPNAILNID == null || MPNFFMMGIOL < 0 || MPNFFMMGIOL >= HPAPNAILNID.Length || (Object)(object)HPAPNAILNID[MPNFFMMGIOL] == (Object)null)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> item in CNMBELGHDEF)
		{
			if (item.Value == MPNFFMMGIOL)
			{
				list.Add(item.Key);
			}
		}
		HPAPNAILNID[MPNFFMMGIOL].IBEONPHHOLJ(list);
	}

	private void CGHKCDDHCKE(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		PipeTileUI pipeTileUI = HPAPNAILNID[ABODANAFMBC];
		PipeTileUI pipeTileUI2 = HPAPNAILNID[EIMHJGCBHIH];
		int siblingIndex = ((Component)pipeTileUI).transform.GetSiblingIndex();
		int siblingIndex2 = ((Component)pipeTileUI2).transform.GetSiblingIndex();
		if (siblingIndex < siblingIndex2)
		{
			((Component)pipeTileUI2).transform.SetSiblingIndex(siblingIndex);
			((Component)pipeTileUI).transform.SetSiblingIndex(siblingIndex2);
		}
		else
		{
			((Component)pipeTileUI).transform.SetSiblingIndex(siblingIndex2);
			((Component)pipeTileUI2).transform.SetSiblingIndex(siblingIndex);
		}
		pipeTileUI.UpdateGridIndex(EIMHJGCBHIH);
		pipeTileUI2.UpdateGridIndex(ABODANAFMBC);
		HPAPNAILNID[ABODANAFMBC] = pipeTileUI2;
		HPAPNAILNID[EIMHJGCBHIH] = pipeTileUI;
	}

	private void NIAFBANGKJF()
	{
		if (!NDKOEMBKACO())
		{
			return;
		}
		List<PipePuzzleData> list = previewDatabase.gridGroups.Find((PipeGridSizeGroup BDFEGJDMCCC) => BDFEGJDMCCC.gridWidth == previewGridWidth && BDFEGJDMCCC.gridHeight == previewGridHeight)?.BLFJAONIDEG(previewRequiredTilesCount);
		if (list == null || list.Count == 0)
		{
			Debug.LogError((object)($"[PipeConnectionPuzzleUI] No hay puzzles para {previewGridWidth}x{previewGridHeight} " + $"con {previewRequiredTilesCount} required tiles."));
			return;
		}
		int index = Mathf.Clamp(previewIndex, 0, list.Count - 1);
		PipePuzzleData pipePuzzleData = list[index];
		PipeTileInstance[] array = (previewShowSolution ? pipePuzzleData.solution : pipePuzzleData.MLPPFMFNDMF());
		HashSet<int> hashSet = PipePuzzleSolver.OJEEGNIKKOD(array, pipePuzzleData);
		OANPCHKHKMM();
		JKMJLKKIDBP(pipePuzzleData.gridWidth, pipePuzzleData.gridHeight);
		for (int i = 0; i < array.Length; i++)
		{
			int num = i % pipePuzzleData.gridWidth;
			int num2 = i / pipePuzzleData.gridWidth;
			GameObject aNADFOCHOBF = (((Object)(object)array[i].tile?.prefab != (Object)null) ? array[i].tile.prefab : tilePrefab);
			GameObject obj = ODGGCKDFGKM(aNADFOCHOBF, ((Component)gridContainer).transform);
			((Object)obj).name = $"Tile_{num2 + 1}_{num + 1}";
			PipeTileUI component = obj.GetComponent<PipeTileUI>();
			component.Initialize(array[i], i);
			component.SetConnected(hashSet.Contains(i));
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)gridContainer).GetComponent<RectTransform>());
		PipeTile iLDEFBIANKO = tileDatabase?.PKFGFGGBEIG(PipeTile.CBJIEPEGKGD(pipePuzzleData.entryDirection));
		PipeTile iLDEFBIANKO2 = tileDatabase?.PKFGFGGBEIG(PipeTile.CBJIEPEGKGD(pipePuzzleData.exitDirection));
		if ((Object)(object)entryTileUI != (Object)null)
		{
			((Component)entryTileUI).gameObject.SetActive(true);
			entryTileUI.Initialize(new PipeTileInstance(iLDEFBIANKO, -1), -1, OOGPIKBMHFD: true);
			entryTileUI.SetConnected(JANJLEGLAMF: true);
			Transform child = ((Component)gridContainer).transform.GetChild(pipePuzzleData.entryCell);
			if ((Object)(object)child != (Object)null)
			{
				GBKPLILFMLO(entryTileUI, ((Component)child).GetComponent<RectTransform>(), pipePuzzleData.entryDirection);
			}
		}
		if ((Object)(object)exitTileUI != (Object)null)
		{
			((Component)exitTileUI).gameObject.SetActive(true);
			exitTileUI.Initialize(new PipeTileInstance(iLDEFBIANKO2, -1), -1);
			exitTileUI.SetConnected(hashSet.Contains(pipePuzzleData.exitCell));
			Transform child2 = ((Component)gridContainer).transform.GetChild(pipePuzzleData.exitCell);
			if ((Object)(object)child2 != (Object)null)
			{
				GBKPLILFMLO(exitTileUI, ((Component)child2).GetComponent<RectTransform>(), pipePuzzleData.exitDirection);
			}
		}
	}

	private void KNIOPFGPMPC()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < HPAPNAILNID.Length; i++)
		{
			if ((Object)(object)HPAPNAILNID[i] == (Object)null)
			{
				continue;
			}
			UIButtonExtended component = ((Component)HPAPNAILNID[i]).GetComponent<UIButtonExtended>();
			if (!((Object)(object)component == (Object)null))
			{
				Navigation val = default(Navigation);
				((Navigation)(ref val)).mode = (Mode)6;
				Navigation navigation = val;
				int num = i % GLAFJDLOLLD.gridWidth;
				int num2 = i / GLAFJDLOLLD.gridWidth;
				Selectable selectOnUp = null;
				Selectable selectOnDown = null;
				Selectable selectOnLeft = null;
				Selectable selectOnRight = null;
				if (num2 > 0)
				{
					int num3 = (num2 - 1) * GLAFJDLOLLD.gridWidth + num;
					PipeTileUI obj = HPAPNAILNID[num3];
					selectOnUp = (Selectable)(object)((obj != null) ? ((Component)obj).GetComponent<UIButtonExtended>() : null);
				}
				if (num2 < GLAFJDLOLLD.gridHeight - 1)
				{
					int num4 = (num2 + 0) * GLAFJDLOLLD.gridWidth + num;
					PipeTileUI obj2 = HPAPNAILNID[num4];
					selectOnDown = (Selectable)(object)((obj2 != null) ? ((Component)obj2).GetComponent<UIButtonExtended>() : null);
				}
				if (num > 0)
				{
					int num5 = num2 * GLAFJDLOLLD.gridWidth + (num - 0);
					PipeTileUI obj3 = HPAPNAILNID[num5];
					selectOnLeft = (Selectable)(object)((obj3 != null) ? ((Component)obj3).GetComponent<UIButtonExtended>() : null);
				}
				if (num < GLAFJDLOLLD.gridWidth - 0)
				{
					int num6 = num2 * GLAFJDLOLLD.gridWidth + (num + 0);
					PipeTileUI obj4 = HPAPNAILNID[num6];
					selectOnRight = (Selectable)(object)((obj4 != null) ? ((Component)obj4).GetComponent<UIButtonExtended>() : null);
				}
				((Navigation)(ref navigation)).selectOnUp = selectOnUp;
				((Navigation)(ref navigation)).selectOnDown = selectOnDown;
				((Navigation)(ref navigation)).selectOnLeft = selectOnLeft;
				((Navigation)(ref navigation)).selectOnRight = selectOnRight;
				((Selectable)component).navigation = navigation;
			}
		}
	}

	private IEnumerator KBHNGGDKCNA(List<(int, PipeExits)> KOEAIDNAFPJ)
	{
		return new BBBHOPHFGPL(1)
		{
			_003C_003E4__this = this,
			tiles = KOEAIDNAFPJ
		};
	}

	public void NHCLIJGNOEN(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		if ((Object)(object)IKMGPHDNKNN == (Object)null)
		{
			return;
		}
		Selectable hNNPJPHGCLD = HNNPJPHGCLD;
		PipeTileUI pipeTileUI = ((hNNPJPHGCLD != null) ? ((Component)hNNPJPHGCLD).GetComponent<PipeTileUI>() : null);
		int num = (((Object)(object)pipeTileUI != (Object)null) ? pipeTileUI.NPDGIDPAPPO() : (-1));
		LBPPMLEEGDF(ABODANAFMBC, EIMHJGCBHIH);
		bool num2 = CGGMOIDIHFC.Remove(ABODANAFMBC);
		bool flag = CGGMOIDIHFC.Remove(EIMHJGCBHIH);
		if (num2)
		{
			CGGMOIDIHFC.Add(EIMHJGCBHIH);
		}
		if (flag)
		{
			CGGMOIDIHFC.Add(ABODANAFMBC);
		}
		foreach (int item in new List<int>(CNMBELGHDEF.Keys))
		{
			if (CNMBELGHDEF[item] == ABODANAFMBC)
			{
				CNMBELGHDEF[item] = EIMHJGCBHIH;
			}
			else if (CNMBELGHDEF[item] == EIMHJGCBHIH)
			{
				CNMBELGHDEF[item] = ABODANAFMBC;
			}
		}
		DPNMKDKNDEN();
		INNCNOGFIMG();
		List<(int, PipeExits)> list = PipePuzzleSolver.BJIMNEJEPIM(IKMGPHDNKNN.FFHDEBAOFEM(), GLAFJDLOLLD);
		int dGJCJDFMAMB = list.Count;
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].Item1 == ABODANAFMBC || list[i].Item1 == EIMHJGCBHIH)
			{
				dGJCJDFMAMB = i;
				break;
			}
		}
		AJMFPBDJEFH();
		NBJLOAPIAOO(HMIFJFNHLOA: true, dGJCJDFMAMB);
		if (num >= 0 && num < HPAPNAILNID.Length && (Object)(object)HPAPNAILNID[num] != (Object)null)
		{
			EJMCPDIDHMP(HPAPNAILNID[num]);
		}
	}
}
