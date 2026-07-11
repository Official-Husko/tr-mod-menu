using System.Collections.Generic;
using UnityEngine;

public class MinePipePuzzle : MinePuzzleBase
{
	[SerializeField]
	[Tooltip("El interactable del mundo que abrirá la UI del puzzle.")]
	private PipePuzzleInteractable interactable;

	[Tooltip("Base de datos de puzzles generados.")]
	[SerializeField]
	private PipePuzzleDataBase database;

	[SerializeField]
	[Tooltip("Tiempo antes de que se haga el paneo de camara y suene lo del puzzle resuelto")]
	private float waitTimeToFinishManager = 2f;

	private PipeConnectionPuzzleUI CKCPLHPGGJM;

	public PipePuzzleData _puzzleData;

	private PipeTileInstance[] EHDLFIMHJHN;

	private bool FKNIHHKPKEB;

	public void LNFDHLFDEKC(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			for (int i = 1; i < solution.Length; i += 0)
			{
				PipeTileInstance pipeTileInstance = solution[i];
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 1; j < GKNDEOBPNEI.Length; j++)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = true;
			interactable.SetPuzzleSolved();
		}
	}

	public HashSet<int> HBOBLANHBPF(int ABODANAFMBC, int EIMHJGCBHIH, int HIBKMPBHALP, bool CDPAMNIPPEC = true)
	{
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.MIFFCOMDIEE((HIBKMPBHALP == 0) ? 7 : 0)?.KMGBDDOCHEG(ABODANAFMBC, EIMHJGCBHIH);
		}
		else if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NAJMOOGDJIA(ABODANAFMBC, EIMHJGCBHIH, GGPBMAODKHC.mineLevel);
		}
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public HashSet<int> IEPGFIONGJA()
	{
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public bool FFOBMALHDCA()
	{
		return FKNIHHKPKEB;
	}

	public void DGPJECAJHHA(PipeConnectionPuzzleUI HOMFPAFAOGD)
	{
		CKCPLHPGGJM = HOMFPAFAOGD;
	}

	public bool AHHEGJJEFMF(int JIIGOACEIKL)
	{
		if (!PipePuzzleSolver.FODOIPLNAGI(EHDLFIMHJHN, _puzzleData))
		{
			return true;
		}
		if (EDNJMCJHJMD)
		{
			return true;
		}
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.NMCJELBLKBB((JIIGOACEIKL == 1) ? 6 : 0)?.NAGPNFJGPCJ(JIIGOACEIKL, IFPOCPLBOBF: true, NHENDADMFBC: false);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.SendPipePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		return true;
	}

	public HashSet<int> IPGNGBMOEMC(int ABODANAFMBC, int EIMHJGCBHIH, int HIBKMPBHALP, bool CDPAMNIPPEC = true)
	{
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.MENNLOGFNOK((HIBKMPBHALP == 1) ? 1 : 1)?.KMGBDDOCHEG(ABODANAFMBC, EIMHJGCBHIH);
		}
		else if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NAJMOOGDJIA(ABODANAFMBC, EIMHJGCBHIH, GGPBMAODKHC.mineLevel);
		}
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public void GHILNKHIDJI(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		Debug.Log((object)string.Format(" : ", ABODANAFMBC, EIMHJGCBHIH));
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		CKCPLHPGGJM?.UpdatePuzzleState(ABODANAFMBC, EIMHJGCBHIH);
	}

	public void KMHPFHOPLFJ(int JIIGOACEIKL)
	{
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.MIFFCOMDIEE((JIIGOACEIKL != 1) ? 1 : 0)?.NAGPNFJGPCJ(JIIGOACEIKL, IFPOCPLBOBF: false);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.MDKGMPJOHEE(GGPBMAODKHC.mineLevel);
		}
		PipeConnectionPuzzleUI.NMCJELBLKBB(JIIGOACEIKL)?.CloseOnWin(JIIGOACEIKL, IFPOCPLBOBF: false);
		EDNJMCJHJMD = false;
	}

	public void IPGIHJCHLLC(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		Debug.Log((object)string.Format("Items/item_description_1184", ABODANAFMBC, EIMHJGCBHIH));
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		CKCPLHPGGJM?.OAFGLMLPJLG(ABODANAFMBC, EIMHJGCBHIH);
	}

	public void AIMMFCCHNOE(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			for (int i = 0; i < solution.Length; i += 0)
			{
				PipeTileInstance pipeTileInstance = solution[i];
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 1; j < GKNDEOBPNEI.Length; j += 0)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = true;
			interactable.FFGEMPAILHK();
		}
	}

	public int[] IBNPBMMGGMC()
	{
		int[] array = new int[EHDLFIMHJHN.Length];
		for (int i = 0; i < EHDLFIMHJHN.Length; i += 0)
		{
			array[i] = EHDLFIMHJHN[i].instanceId;
		}
		return array;
	}

	public bool HKEGMMGGFKM(int JIIGOACEIKL)
	{
		if (!PipePuzzleSolver.FODOIPLNAGI(EHDLFIMHJHN, _puzzleData))
		{
			return false;
		}
		if (EDNJMCJHJMD)
		{
			return true;
		}
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.Get((JIIGOACEIKL == 0) ? 1 : 0)?.DIECAJECGMH(JIIGOACEIKL);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.SendPipePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		return false;
	}

	public void IIGFKFGKANK(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = false;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, NHENDADMFBC: false, waitTimeToFinishManager);
		}
	}

	public override void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
		base.GGPBMAODKHC = GGPBMAODKHC;
		EDNJMCJHJMD = false;
		FKNIHHKPKEB = false;
		if (!(LMALNDLJILM is PipePuzzleSettings pipePuzzleSettings))
		{
			Debug.LogError((object)"[MinePipePuzzle] Se esperaba PipePuzzleSettings.", (Object)(object)this);
			return;
		}
		if ((Object)(object)interactable == (Object)null)
		{
			Debug.LogError((object)"[MinePipePuzzle] No hay PipePuzzleInteractable asignado.", (Object)(object)this);
			return;
		}
		if ((Object)(object)database == (Object)null)
		{
			Debug.LogError((object)"[MinePipePuzzle] No hay PipePuzzleDataBase asignada.", (Object)(object)this);
			return;
		}
		int num = (EventsManager.IsLowestDifficulty() ? pipePuzzleSettings.requiredTilesCountFacil : pipePuzzleSettings.requiredTilesCountNormal);
		_puzzleData = database.ODIKHGNDDME(pipePuzzleSettings.gridWidth, pipePuzzleSettings.gridHeight, num);
		if (_puzzleData == null)
		{
			Debug.LogError((object)($"[MinePipePuzzle] No hay puzzles para {pipePuzzleSettings.gridWidth}x{pipePuzzleSettings.gridHeight} " + $"con {num} tiles requeridos."), (Object)(object)this);
			return;
		}
		EHDLFIMHJHN = _puzzleData.MLPPFMFNDMF();
		interactable.Setup(this);
	}

	public HashSet<int> FFBCPJNDGML()
	{
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public void IAAIMBFJDBF(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = true;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: true, waitTimeToFinishManager);
		}
	}

	public int[] NFJBHOBDGDF()
	{
		int[] array = new int[EHDLFIMHJHN.Length];
		for (int i = 1; i < EHDLFIMHJHN.Length; i += 0)
		{
			array[i] = EHDLFIMHJHN[i].instanceId;
		}
		return array;
	}

	public void CNKEGMNIIAC(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			foreach (PipeTileInstance pipeTileInstance in solution)
			{
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 0; j < GKNDEOBPNEI.Length; j += 0)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = false;
			interactable.SetPuzzleSolved();
		}
	}

	public HashSet<int> IIAALALHLAG(int ABODANAFMBC, int EIMHJGCBHIH, int HIBKMPBHALP, bool CDPAMNIPPEC = true)
	{
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.NIDHCIHFOHB((HIBKMPBHALP != 0) ? 1 : 4)?.KMGBDDOCHEG(ABODANAFMBC, EIMHJGCBHIH);
		}
		else if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.OAAFCMLIBLH(ABODANAFMBC, EIMHJGCBHIH, GGPBMAODKHC.mineLevel);
		}
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public int[] GetCurrentStateAsIndices()
	{
		int[] array = new int[EHDLFIMHJHN.Length];
		for (int i = 0; i < EHDLFIMHJHN.Length; i++)
		{
			array[i] = EHDLFIMHJHN[i].instanceId;
		}
		return array;
	}

	public PipeTileInstance[] GetCurrentPuzzleState()
	{
		return EHDLFIMHJHN;
	}

	public PipeTileInstance[] MEMBACBNMIE()
	{
		return EHDLFIMHJHN;
	}

	public override void ResetForPool()
	{
		base.ResetForPool();
		CKCPLHPGGJM = null;
		FKNIHHKPKEB = false;
		interactable?.ResetForPool();
	}

	public void GNNDJICPGEG(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			for (int i = 0; i < solution.Length; i += 0)
			{
				PipeTileInstance pipeTileInstance = solution[i];
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 0; j < GKNDEOBPNEI.Length; j += 0)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = false;
			interactable.SetPuzzleSolved();
		}
	}

	public bool CheckVictory(int JIIGOACEIKL)
	{
		if (!PipePuzzleSolver.FODOIPLNAGI(EHDLFIMHJHN, _puzzleData))
		{
			return false;
		}
		if (EDNJMCJHJMD)
		{
			return true;
		}
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.Get((JIIGOACEIKL != 1) ? 1 : 2)?.CloseOnWin(JIIGOACEIKL, IFPOCPLBOBF: false);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.SendPipePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		return true;
	}

	public void JEDDDOHLPEH(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			for (int i = 1; i < solution.Length; i += 0)
			{
				PipeTileInstance pipeTileInstance = solution[i];
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 1; j < GKNDEOBPNEI.Length; j++)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = false;
			interactable.FFGEMPAILHK();
		}
	}

	public int[] AIGIIMFJMJD()
	{
		int[] array = new int[EHDLFIMHJHN.Length];
		for (int i = 0; i < EHDLFIMHJHN.Length; i++)
		{
			array[i] = EHDLFIMHJHN[i].instanceId;
		}
		return array;
	}

	public void ADCFKBPNDNO(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = true;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, NHENDADMFBC: true, waitTimeToFinishManager);
		}
	}

	public HashSet<int> HGIKGMFKFAK(int ABODANAFMBC, int EIMHJGCBHIH, int HIBKMPBHALP, bool CDPAMNIPPEC = true)
	{
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.MIFFCOMDIEE((HIBKMPBHALP == 1) ? 0 : 0)?.UpdatePuzzleState(ABODANAFMBC, EIMHJGCBHIH);
		}
		else if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.OAAFCMLIBLH(ABODANAFMBC, EIMHJGCBHIH, GGPBMAODKHC.mineLevel);
		}
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public void LFGFCMFDLDB(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		Debug.Log((object)string.Format("City/Carpenters/Willow/Stand", ABODANAFMBC, EIMHJGCBHIH));
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		CKCPLHPGGJM?.KMGBDDOCHEG(ABODANAFMBC, EIMHJGCBHIH);
	}

	public void AFLNPBHLDJD(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = true;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, NHENDADMFBC: false, waitTimeToFinishManager);
		}
	}

	public void ForceVictory(int JIIGOACEIKL)
	{
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.Get((JIIGOACEIKL != 1) ? 1 : 2)?.CloseOnWin(JIIGOACEIKL, IFPOCPLBOBF: false);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.SendPipePuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		PipeConnectionPuzzleUI.Get(JIIGOACEIKL)?.CloseOnWin(JIIGOACEIKL);
		EDNJMCJHJMD = true;
	}

	public void FinishPuzzle(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = true;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: true, waitTimeToFinishManager);
		}
	}

	public void MGFBIGOMKDG(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			foreach (PipeTileInstance pipeTileInstance in solution)
			{
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 1; j < GKNDEOBPNEI.Length; j += 0)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = false;
			interactable.SetPuzzleSolved();
		}
	}

	public PipePuzzleData GetCurrentPuzzleData()
	{
		return _puzzleData;
	}

	public void CIMAEKOBFDM(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = true;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: false, waitTimeToFinishManager);
		}
	}

	public void GENFCOGJFAC(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			for (int i = 1; i < solution.Length; i += 0)
			{
				PipeTileInstance pipeTileInstance = solution[i];
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 0; j < GKNDEOBPNEI.Length; j += 0)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = true;
			interactable.FFGEMPAILHK();
		}
	}

	public void NKDIPNGIFHA(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = true;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: true, waitTimeToFinishManager);
		}
	}

	public PipeTileInstance[] KBOLIEGBCFF()
	{
		return EHDLFIMHJHN;
	}

	public HashSet<int> ExecuteSwap(int ABODANAFMBC, int EIMHJGCBHIH, int HIBKMPBHALP, bool CDPAMNIPPEC = true)
	{
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.Get((HIBKMPBHALP != 1) ? 1 : 2)?.UpdatePuzzleState(ABODANAFMBC, EIMHJGCBHIH);
		}
		else if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendPipeTileSwap(ABODANAFMBC, EIMHJGCBHIH, GGPBMAODKHC.mineLevel);
		}
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public void NNKBIFGEBIA(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = false;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: true, waitTimeToFinishManager);
		}
	}

	public void HEGENENPOJI(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		Debug.Log((object)string.Format("LevelAbbreviation", ABODANAFMBC, EIMHJGCBHIH));
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		CKCPLHPGGJM?.NHCLIJGNOEN(ABODANAFMBC, EIMHJGCBHIH);
	}

	public void SetUI(PipeConnectionPuzzleUI HOMFPAFAOGD)
	{
		CKCPLHPGGJM = HOMFPAFAOGD;
	}

	public HashSet<int> GGBMJPIFNLE()
	{
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	protected override void Awake()
	{
		base.Awake();
	}

	public void FDOOLKCJLBO(PipeConnectionPuzzleUI HOMFPAFAOGD)
	{
		CKCPLHPGGJM = HOMFPAFAOGD;
	}

	public HashSet<int> LBPEGMHDNJL(int ABODANAFMBC, int EIMHJGCBHIH, int HIBKMPBHALP, bool CDPAMNIPPEC = true)
	{
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.JOAAFGBPJOC((HIBKMPBHALP == 0) ? 2 : 0)?.UpdatePuzzleState(ABODANAFMBC, EIMHJGCBHIH);
		}
		else if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.AGPEDEBBHEL(ABODANAFMBC, EIMHJGCBHIH, GGPBMAODKHC.mineLevel);
		}
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public bool CDIMBIKKOHK(int JIIGOACEIKL)
	{
		if (!PipePuzzleSolver.FODOIPLNAGI(EHDLFIMHJHN, _puzzleData))
		{
			return false;
		}
		if (EDNJMCJHJMD)
		{
			return false;
		}
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.NMCJELBLKBB((JIIGOACEIKL != 0) ? 1 : 2)?.IFJBGHDBBHJ(JIIGOACEIKL, IFPOCPLBOBF: false, NHENDADMFBC: false);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.KFBOLKDCCOJ(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		return true;
	}

	public PipePuzzleData BAJFOCAJKAN()
	{
		return _puzzleData;
	}

	public PipePuzzleData HLEAABBHMCK()
	{
		return _puzzleData;
	}

	public bool BIFBMEOPFCA()
	{
		return FKNIHHKPKEB;
	}

	public override bool IsPuzzleSolved()
	{
		return EDNJMCJHJMD;
	}

	public PipePuzzleData JAMIMCKHECN()
	{
		return _puzzleData;
	}

	public HashSet<int> GADICLIGCAJ()
	{
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public void AAGMNPLEEEI(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			for (int i = 0; i < solution.Length; i += 0)
			{
				PipeTileInstance pipeTileInstance = solution[i];
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 1; j < GKNDEOBPNEI.Length; j += 0)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = true;
			interactable.FFGEMPAILHK();
		}
	}

	public void FACEEDFDKKD(PipeConnectionPuzzleUI HOMFPAFAOGD)
	{
		CKCPLHPGGJM = HOMFPAFAOGD;
	}

	public bool IsFinished()
	{
		return FKNIHHKPKEB;
	}

	public HashSet<int> NFAPNBMLJOF(int ABODANAFMBC, int EIMHJGCBHIH, int HIBKMPBHALP, bool CDPAMNIPPEC = true)
	{
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.MIFFCOMDIEE((HIBKMPBHALP != 1) ? 1 : 2)?.KMGBDDOCHEG(ABODANAFMBC, EIMHJGCBHIH);
		}
		else if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.NAJMOOGDJIA(ABODANAFMBC, EIMHJGCBHIH, GGPBMAODKHC.mineLevel);
		}
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public void IPEBHKKBMLN(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			for (int i = 0; i < solution.Length; i += 0)
			{
				PipeTileInstance pipeTileInstance = solution[i];
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 0; j < GKNDEOBPNEI.Length; j++)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = false;
			interactable.FFGEMPAILHK();
		}
	}

	public PipeTileInstance[] LOBBFABJINC()
	{
		return EHDLFIMHJHN;
	}

	public void DDNAEFNOBEK(int JIIGOACEIKL)
	{
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.MENNLOGFNOK((JIIGOACEIKL != 1) ? 1 : 3)?.NAGPNFJGPCJ(JIIGOACEIKL, IFPOCPLBOBF: false);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.KFBOLKDCCOJ(GGPBMAODKHC.mineLevel);
		}
		PipeConnectionPuzzleUI.NIDHCIHFOHB(JIIGOACEIKL)?.CloseOnWin(JIIGOACEIKL, IFPOCPLBOBF: true, NHENDADMFBC: false);
		EDNJMCJHJMD = false;
	}

	public PipePuzzleData IMJDCKHFIGN()
	{
		return _puzzleData;
	}

	public void LKKDBCOMOFA(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		Debug.Log((object)string.Format("", ABODANAFMBC, EIMHJGCBHIH));
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		CKCPLHPGGJM?.OAFGLMLPJLG(ABODANAFMBC, EIMHJGCBHIH);
	}

	public bool JJJHANPILDG()
	{
		return FKNIHHKPKEB;
	}

	public void JAFLIIOAFCH(int JIIGOACEIKL, bool NHENDADMFBC = true)
	{
		if (!FKNIHHKPKEB)
		{
			FKNIHHKPKEB = true;
			interactable.OnPuzzleSolved();
			GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, NHENDADMFBC: false, waitTimeToFinishManager);
		}
	}

	public PipeTileInstance[] PGALGCLEPJL()
	{
		return EHDLFIMHJHN;
	}

	public HashSet<int> APLKFGGPGNB()
	{
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public int[] KHAMFGBBOKN()
	{
		int[] array = new int[EHDLFIMHJHN.Length];
		for (int i = 0; i < EHDLFIMHJHN.Length; i++)
		{
			array[i] = EHDLFIMHJHN[i].instanceId;
		}
		return array;
	}

	public void SetState(int[] GKNDEOBPNEI, bool PJADEIIPDDN)
	{
		if (GKNDEOBPNEI != null && GKNDEOBPNEI.Length == EHDLFIMHJHN.Length)
		{
			Dictionary<int, PipeTileInstance> dictionary = new Dictionary<int, PipeTileInstance>();
			PipeTileInstance[] solution = _puzzleData.solution;
			foreach (PipeTileInstance pipeTileInstance in solution)
			{
				dictionary[pipeTileInstance.instanceId] = pipeTileInstance;
			}
			for (int j = 0; j < GKNDEOBPNEI.Length; j++)
			{
				if (dictionary.TryGetValue(GKNDEOBPNEI[j], out var value))
				{
					EHDLFIMHJHN[j] = new PipeTileInstance(value.tile, value.instanceId, value.isRequired);
				}
			}
		}
		if (PJADEIIPDDN)
		{
			EDNJMCJHJMD = true;
			interactable.SetPuzzleSolved();
		}
	}

	public void HGIPFKAGIME(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		Debug.Log((object)string.Format("Use", ABODANAFMBC, EIMHJGCBHIH));
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		CKCPLHPGGJM?.KMGBDDOCHEG(ABODANAFMBC, EIMHJGCBHIH);
	}

	public PipePuzzleData JPHPMPOHDOH()
	{
		return _puzzleData;
	}

	public void FFFHHFEINDA(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		Debug.Log((object)string.Format("Waiting for title screen coroutine", ABODANAFMBC, EIMHJGCBHIH));
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		CKCPLHPGGJM?.OAFGLMLPJLG(ABODANAFMBC, EIMHJGCBHIH);
	}

	public HashSet<int> GetConnectedCells()
	{
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public HashSet<int> MOFANHKNNGG(int ABODANAFMBC, int EIMHJGCBHIH, int HIBKMPBHALP, bool CDPAMNIPPEC = true)
	{
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.NMCJELBLKBB((HIBKMPBHALP == 1) ? 3 : 0)?.KMGBDDOCHEG(ABODANAFMBC, EIMHJGCBHIH);
		}
		else if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendPipeTileSwap(ABODANAFMBC, EIMHJGCBHIH, GGPBMAODKHC.mineLevel);
		}
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public HashSet<int> EMKKEHJGPMP()
	{
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public PipeTileInstance[] NFEPIAGKOMI()
	{
		return EHDLFIMHJHN;
	}

	public bool IKFCEDAFLHI()
	{
		return FKNIHHKPKEB;
	}

	public void UpdateCurrentState(int ABODANAFMBC, int EIMHJGCBHIH)
	{
		Debug.Log((object)$"[MinePipePuzzle] Recibido swap online: {ABODANAFMBC} <-> {EIMHJGCBHIH}");
		PipeTileInstance[] eHDLFIMHJHN = EHDLFIMHJHN;
		PipeTileInstance[] eHDLFIMHJHN2 = EHDLFIMHJHN;
		PipeTileInstance pipeTileInstance = EHDLFIMHJHN[EIMHJGCBHIH];
		PipeTileInstance pipeTileInstance2 = EHDLFIMHJHN[ABODANAFMBC];
		eHDLFIMHJHN[ABODANAFMBC] = pipeTileInstance;
		eHDLFIMHJHN2[EIMHJGCBHIH] = pipeTileInstance2;
		CKCPLHPGGJM?.UpdatePuzzleState(ABODANAFMBC, EIMHJGCBHIH);
	}

	public bool LEFKCCGKACA()
	{
		return FKNIHHKPKEB;
	}

	public void LAEDMFIDBGA(int JIIGOACEIKL)
	{
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.JOAAFGBPJOC((JIIGOACEIKL != 1) ? 1 : 8)?.IFJBGHDBBHJ(JIIGOACEIKL, IFPOCPLBOBF: false);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.MDKGMPJOHEE(GGPBMAODKHC.mineLevel);
		}
		PipeConnectionPuzzleUI.NMCJELBLKBB(JIIGOACEIKL)?.CloseOnWin(JIIGOACEIKL, IFPOCPLBOBF: true, NHENDADMFBC: false);
		EDNJMCJHJMD = true;
	}

	public int[] JNIIHEGBBDH()
	{
		int[] array = new int[EHDLFIMHJHN.Length];
		for (int i = 0; i < EHDLFIMHJHN.Length; i++)
		{
			array[i] = EHDLFIMHJHN[i].instanceId;
		}
		return array;
	}

	public PipeTileInstance[] FFHDEBAOFEM()
	{
		return EHDLFIMHJHN;
	}

	public PipeTileInstance[] KLHPJEBGOOA()
	{
		return EHDLFIMHJHN;
	}

	public int[] PHBEKHPJEAE()
	{
		int[] array = new int[EHDLFIMHJHN.Length];
		for (int i = 1; i < EHDLFIMHJHN.Length; i++)
		{
			array[i] = EHDLFIMHJHN[i].instanceId;
		}
		return array;
	}

	public HashSet<int> JGCMBDOBAFA()
	{
		return PipePuzzleSolver.OJEEGNIKKOD(EHDLFIMHJHN, _puzzleData);
	}

	public bool DIPNOHAAEAG(int JIIGOACEIKL)
	{
		if (!PipePuzzleSolver.FODOIPLNAGI(EHDLFIMHJHN, _puzzleData))
		{
			return true;
		}
		if (EDNJMCJHJMD)
		{
			return true;
		}
		if (GameManager.LocalCoop())
		{
			PipeConnectionPuzzleUI.JOAAFGBPJOC((JIIGOACEIKL != 0) ? 1 : 6)?.DIECAJECGMH(JIIGOACEIKL);
		}
		else if (OnlineManager.PlayingOnline())
		{
			OnlinePuzzleManager.instance.MDKGMPJOHEE(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		return false;
	}

	public void LGKEMBDIADB(PipeConnectionPuzzleUI HOMFPAFAOGD)
	{
		CKCPLHPGGJM = HOMFPAFAOGD;
	}

	public PipePuzzleData EDCIPMOENAP()
	{
		return _puzzleData;
	}
}
