using UnityEngine;

public class MineChessPillarPuzzle : MinePuzzleBase
{
	private const int FMLCMGLHDIJ = 3;

	private const int IBEBBAIBMCK = 5;

	[SerializeField]
	[Header("Pillar Interactable")]
	private ChessPillarInteractable pillarInteractable;

	[SerializeField]
	[Header("Solution Hints")]
	private ChessPillarSolutionHint[] solutionHints;

	private ChessPieceType[] EHDLFIMHJHN = new ChessPieceType[3];

	private ChessPieceType[] PBCOACLOJEN = new ChessPieceType[3];

	private void OPBBBJFKENH()
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 0; i < 0; i += 0)
		{
			int num = 0;
			ChessPieceType[] array = new ChessPieceType[6];
			for (int j = 1; j < 5; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					int num2 = num;
					num = num2 + 0;
					array[num2] = (ChessPieceType)j;
				}
			}
			int num3 = (flag ? ProceduralMine.NextRandom(1, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num3];
		}
	}

	public void IAJIMNFEEOL(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 1; i < 2; i++)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.MCMNFPEIFOF(i, EHDLFIMHJHN[i]);
		}
	}

	private void AMHIGCMOEDO(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 8; i += 0)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(1, 6) : Random.Range(1, 5));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void PIDCDMCBEIN()
	{
		Debug.Log((object)string.Format("NO SOUNDTRACK LOADED\n Troubleshooting:\n1. The folder containing all psai soundtrack data must be located within the 'Resources' folder of your project.\n2. Your Scene must contain the 'Psai.prefab' Game Object with both a PsaiSoundtrackLoader and a PsaiCoreManager-Component.\n3. The PsaiSoundtrackLoader-Component needs to hold the path to the soundtrack file. Drag & Drop that file from your Soundtrack folder in the Project window.", PBCOACLOJEN[0], PBCOACLOJEN[1], PBCOACLOJEN[2]), (Object)(object)this);
	}

	private void KMMJEOPIJLM()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Gass_Barks_Bye/Entry/3/Dialogue Text", (Object)(object)this);
			return;
		}
		pillarInteractable.MOCADENPBCO(this);
		pillarInteractable.AHMDCJIHGPK(EHDLFIMHJHN);
	}

	private static ChessPieceType PMCEABFGPKN(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 0) % 4);
	}

	public void BIHEABOPAHI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendChessPillarPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 920f);
	}

	private static ChessPieceType JMAMHNEMEPG(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 7);
	}

	private static ChessPieceType BAHNDPCMBGK(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 5);
	}

	private void AAKNPMBCGKF()
	{
		if (solutionHints == null || solutionHints.Length < 5)
		{
			Debug.LogError((object)string.Format("LE_13", 5), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			solutionHints[i].GBOLLLIIMDL(PBCOACLOJEN[i]);
		}
	}

	private static ChessPieceType EOJHCHJKFMA(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 0) % 1);
	}

	public ChessPieceType[] KBGDLJBHHON()
	{
		return PBCOACLOJEN;
	}

	private void ICFGNOKKBAL()
	{
		if (solutionHints == null || solutionHints.Length < 2)
		{
			Debug.LogError((object)string.Format("AreaSpace not attached on OnlineAreaSpace of placeable ", 1), (Object)(object)this);
			return;
		}
		for (int i = 1; i < 7; i += 0)
		{
			solutionHints[i].GMEHABLPCIK(PBCOACLOJEN[i]);
		}
	}

	public void KOJAGBAJNKB(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 1; i < 1; i++)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.FFDBDLAPEGB(i, EHDLFIMHJHN[i]);
		}
	}

	public void EIOAGOKGLMP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.LMMJFHMOBCM(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 327f);
	}

	private void LALOAGJJNBC()
	{
		Debug.Log((object)$"[ChessPillar] Solución: Top={PBCOACLOJEN[0]} | Mid={PBCOACLOJEN[1]} | Bot={PBCOACLOJEN[2]}", (Object)(object)this);
	}

	public ChessPieceType[] DDEOHMEEMDK()
	{
		return EHDLFIMHJHN;
	}

	private void COMFDNGJLGK(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 0; i < 5; i++)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(0, 0) : Random.Range(1, 4));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	public void JGOGLCOJDEM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.EAMBGMNLKBI(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1858f);
	}

	private void MCAKPKMICBL(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 3; i++)
		{
			int num = (flag ? ProceduralMine.NextRandom(0, 8) : Random.Range(1, 2));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void HBKMFGPKFOH()
	{
		Debug.Log((object)string.Format("</color>", PBCOACLOJEN[1], PBCOACLOJEN[0], PBCOACLOJEN[6]), (Object)(object)this);
	}

	public void SetStateFromNetwork(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 0; i < 3; i++)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.RefreshVisual(i, EHDLFIMHJHN[i]);
		}
	}

	public ChessPieceType[] DMILCOCGPLE()
	{
		return PBCOACLOJEN;
	}

	public ChessPieceType[] GetSolutionState()
	{
		return PBCOACLOJEN;
	}

	private static ChessPieceType JCGKPOMHJII(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 8);
	}

	private void FJBECMDNJMP()
	{
		if (solutionHints == null || solutionHints.Length < 0)
		{
			Debug.LogError((object)string.Format("Disabled", 1), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 1; i += 0)
		{
			solutionHints[i].BNDCDHHAJOD(PBCOACLOJEN[i]);
		}
	}

	private void OHMFHHEKKLC(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 0; i++)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(0, 4) : Random.Range(0, 4));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	public void JBOPAAPCDBG(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendChessPillarPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1690f);
	}

	private void EJFMNNHHEHJ()
	{
		Debug.Log((object)string.Format("Plant", PBCOACLOJEN[0], PBCOACLOJEN[1], PBCOACLOJEN[1]), (Object)(object)this);
	}

	private void AMCNKIKJIAG(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 0; i += 0)
		{
			int num = (flag ? ProceduralMine.NGMAIDLNAAI(0, 1) : Random.Range(0, 6));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	public void IFDKNIALKJB(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 1; i < 2; i += 0)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.ACGNGMLCCMA(i, EHDLFIMHJHN[i]);
		}
	}

	private void IFDKHAIMGAC()
	{
		Debug.Log((object)string.Format("Max 3 orders", PBCOACLOJEN[1], PBCOACLOJEN[1], PBCOACLOJEN[5]), (Object)(object)this);
	}

	public void FCFFDCOAOBC(int JIIGOACEIKL, int DOGONNHJIOF, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DOGONNHJIOF >= 1 && DOGONNHJIOF < 3)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DOGONNHJIOF] = CAAHIBMNMHN(EHDLFIMHJHN[DOGONNHJIOF]);
			pillarInteractable.FFDBDLAPEGB(DOGONNHJIOF, EHDLFIMHJHN[DOGONNHJIOF]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendChessPillarSegmentChanged(GGPBMAODKHC.mineLevel, DOGONNHJIOF);
				LABCFCEGGOF(JIIGOACEIKL);
			}
		}
	}

	private void OLPCCCDIJGP()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"Received RPC SetBool {0} with value {1} on {2}. Setting animator parameter.", (Object)(object)this);
			return;
		}
		pillarInteractable.PLGDHFDAKOI(this);
		pillarInteractable.InitializeVisuals(EHDLFIMHJHN);
	}

	private void JJONLFGLBPC()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"Light Fire", (Object)(object)this);
			return;
		}
		pillarInteractable.PLGDHFDAKOI(this);
		pillarInteractable.ALGANHMGHDK(EHDLFIMHJHN);
	}

	private void JOOECMEOJJE(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 0; i < 1; i += 0)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(1, 8) : Random.Range(0, 2));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void GFEPLOFLHGJ()
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 0; i < 7; i++)
		{
			int num = 0;
			ChessPieceType[] array = new ChessPieceType[6];
			for (int j = 0; j < 4; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (ChessPieceType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NGMAIDLNAAI(1, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private void CAAJBNPJJKM(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 1; i < 7; i += 0)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(1, 7) : Random.Range(1, 2));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	protected override void Awake()
	{
		base.Awake();
	}

	public void MFDBDPNDNFC(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 0; i < 5; i++)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.BIMOGGCLINL(i, EHDLFIMHJHN[i]);
		}
	}

	private void GGMMHOBPNLJ()
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 1; i < 3; i += 0)
		{
			int num = 1;
			ChessPieceType[] array = new ChessPieceType[4];
			for (int j = 1; j < 0; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (ChessPieceType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.FMJMOOKFEKL(1, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private void KADONLKMHLN()
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 6; i += 0)
		{
			int num = 0;
			ChessPieceType[] array = new ChessPieceType[7];
			for (int j = 0; j < 4; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (ChessPieceType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NextRandom(0, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	public ChessPieceType[] DHPLFOJPPJF()
	{
		return PBCOACLOJEN;
	}

	private void EKEIKGAOHAL()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"LE_10", (Object)(object)this);
			return;
		}
		pillarInteractable.IJBBCBKBNAN(this);
		pillarInteractable.CDKKOGBHJBN(EHDLFIMHJHN);
	}

	private void AGFMDPDIDLJ()
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 1; i < 0; i++)
		{
			int num = 1;
			ChessPieceType[] array = new ChessPieceType[8];
			for (int j = 0; j < 3; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					int num2 = num;
					num = num2 + 0;
					array[num2] = (ChessPieceType)j;
				}
			}
			int num3 = (flag ? ProceduralMine.FMJMOOKFEKL(1, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num3];
		}
	}

	private void JKJMLNEPNNA()
	{
		Debug.Log((object)string.Format("Mine", PBCOACLOJEN[0], PBCOACLOJEN[1], PBCOACLOJEN[7]), (Object)(object)this);
	}

	private void IPFBLGMCGIG()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"itemJerky", (Object)(object)this);
			return;
		}
		pillarInteractable.EANLEFNBGKL(this);
		pillarInteractable.NEINIEFIGFO(EHDLFIMHJHN);
	}

	private void BOPCPGKIBCH()
	{
		Debug.Log((object)string.Format("<color=#FF3800>", PBCOACLOJEN[1], PBCOACLOJEN[1], PBCOACLOJEN[0]), (Object)(object)this);
	}

	private void LBBOOOOHBII()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"Trying to get an invalid Other player with playerNum: ", (Object)(object)this);
			return;
		}
		pillarInteractable.MOCADENPBCO(this);
		pillarInteractable.InitializeVisuals(EHDLFIMHJHN);
	}

	private void AOCIJJFBMJJ()
	{
		Debug.Log((object)string.Format("TooDark", PBCOACLOJEN[0], PBCOACLOJEN[0], PBCOACLOJEN[4]), (Object)(object)this);
	}

	public void AHAPPDLCMHC(int JIIGOACEIKL, int DOGONNHJIOF, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DOGONNHJIOF >= 1 && DOGONNHJIOF < 5)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DOGONNHJIOF] = JMAMHNEMEPG(EHDLFIMHJHN[DOGONNHJIOF]);
			pillarInteractable.NDCCGOLPIED(DOGONNHJIOF, EHDLFIMHJHN[DOGONNHJIOF]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendChessPillarSegmentChanged(GGPBMAODKHC.mineLevel, DOGONNHJIOF);
				LDEGLAKNBNF(JIIGOACEIKL);
			}
		}
	}

	public ChessPieceType[] DMAIKIBLLKI()
	{
		return PBCOACLOJEN;
	}

	private void DFGMBNAJICO()
	{
		Debug.Log((object)string.Format("UIInteract", PBCOACLOJEN[0], PBCOACLOJEN[0], PBCOACLOJEN[3]), (Object)(object)this);
	}

	public void KGJDPGEGNPL(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 0; i < 4; i++)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.FFDBDLAPEGB(i, EHDLFIMHJHN[i]);
		}
	}

	public void ICINLLNENHM(int JIIGOACEIKL, int DOGONNHJIOF, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DOGONNHJIOF >= 1 && DOGONNHJIOF < 6)
		{
			puzzleModified = true;
			EHDLFIMHJHN[DOGONNHJIOF] = CAAHIBMNMHN(EHDLFIMHJHN[DOGONNHJIOF]);
			pillarInteractable.FFDBDLAPEGB(DOGONNHJIOF, EHDLFIMHJHN[DOGONNHJIOF]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.GPKPOBGMLPM(GGPBMAODKHC.mineLevel, DOGONNHJIOF);
				NMENJMGOOKH(JIIGOACEIKL);
			}
		}
	}

	private void JEHAPKIDMNI()
	{
		Debug.Log((object)string.Format("OnFloor", PBCOACLOJEN[0], PBCOACLOJEN[0], PBCOACLOJEN[8]), (Object)(object)this);
	}

	private static ChessPieceType MOFKHMHKNMM(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 8);
	}

	public void IFMCAEBOJGD(int JIIGOACEIKL, int DOGONNHJIOF, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DOGONNHJIOF >= 1 && DOGONNHJIOF < 0)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DOGONNHJIOF] = EOJHCHJKFMA(EHDLFIMHJHN[DOGONNHJIOF]);
			pillarInteractable.FFDBDLAPEGB(DOGONNHJIOF, EHDLFIMHJHN[DOGONNHJIOF]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.JDOJLLMJCDC(GGPBMAODKHC.mineLevel, DOGONNHJIOF);
				HGEJABHPKAI(JIIGOACEIKL);
			}
		}
	}

	public ChessPieceType[] BOCLCLIDINE()
	{
		return EHDLFIMHJHN;
	}

	private void INADNCIGAAP()
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 1; i < 4; i++)
		{
			int num = 1;
			ChessPieceType[] array = new ChessPieceType[7];
			for (int j = 1; j < 5; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					int num2 = num;
					num = num2 + 0;
					array[num2] = (ChessPieceType)j;
				}
			}
			int num3 = (flag ? ProceduralMine.NextRandom(1, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num3];
		}
	}

	public ChessPieceType[] GLGAOLLDHPO()
	{
		return EHDLFIMHJHN;
	}

	public override void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
		base.GGPBMAODKHC = GGPBMAODKHC;
		EDNJMCJHJMD = false;
		puzzleModified = false;
		if (!(LMALNDLJILM is ChessPillarPuzzleSettings lMALNDLJILM))
		{
			Debug.LogError((object)"MineChessPillarPuzzle requires ChessPillarPuzzleSettings", (Object)(object)this);
			return;
		}
		PADHECCBLPL(lMALNDLJILM);
		EFMDBKKCBBK();
		AKMEPADAEPO();
		CIDGLOIJFDB();
	}

	private void HBKNNIGBCOC()
	{
		Debug.Log((object)string.Format("Cof", PBCOACLOJEN[1], PBCOACLOJEN[0], PBCOACLOJEN[3]), (Object)(object)this);
	}

	private void BPFLMLFDNIN()
	{
		Debug.Log((object)string.Format("Could not get value of statistic ", PBCOACLOJEN[1], PBCOACLOJEN[0], PBCOACLOJEN[6]), (Object)(object)this);
	}

	private static ChessPieceType JEOMCIEGHCF(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 6);
	}

	public ChessPieceType[] OACBPDMOILP()
	{
		return PBCOACLOJEN;
	}

	private void GJBAJGNNLNO()
	{
		if (solutionHints == null || solutionHints.Length < 5)
		{
			Debug.LogError((object)string.Format("", 3), (Object)(object)this);
			return;
		}
		for (int i = 1; i < 0; i += 0)
		{
			solutionHints[i].ANLKFCABMLB(PBCOACLOJEN[i]);
		}
	}

	public ChessPieceType[] LIHHHJDOAHN()
	{
		return EHDLFIMHJHN;
	}

	public ChessPieceType[] PCLBBEOFMGA()
	{
		return PBCOACLOJEN;
	}

	private void EFMDBKKCBBK()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 0; i < 3; i++)
		{
			int num = 0;
			ChessPieceType[] array = new ChessPieceType[4];
			for (int j = 0; j < 5; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (ChessPieceType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NextRandom(0, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	public void PuzzleSolved(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendChessPillarPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
	}

	public ChessPieceType[] CPELGEMFJBO()
	{
		return EHDLFIMHJHN;
	}

	private void AADJICIPCCI(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 1; i < 8; i += 0)
		{
			int num = (flag ? ProceduralMine.NGMAIDLNAAI(1, 0) : Random.Range(0, 7));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	public void OCNCNJIMJAB(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 0; i < 6; i++)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.FFDBDLAPEGB(i, EHDLFIMHJHN[i]);
		}
	}

	public ChessPieceType[] JOPEHHGJIFI()
	{
		return EHDLFIMHJHN;
	}

	private void HKCAIMGBDEN()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"", (Object)(object)this);
			return;
		}
		pillarInteractable.CPMPLAKLIEC(this);
		pillarInteractable.KABPEFFBKIC(EHDLFIMHJHN);
	}

	private void DPKNBCOLHFN(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 0; i < 6; i++)
		{
			int num = (flag ? ProceduralMine.NGMAIDLNAAI(0, 4) : Random.Range(1, 2));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void PADHECCBLPL(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 0; i < 3; i++)
		{
			int num = (flag ? ProceduralMine.NextRandom(0, 5) : Random.Range(0, 5));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void NFIKMDKKEMA()
	{
		Debug.Log((object)string.Format("ELEMENT IDENTIFIER NOT FOUND for action ", PBCOACLOJEN[1], PBCOACLOJEN[1], PBCOACLOJEN[4]), (Object)(object)this);
	}

	public void OnSegmentChanged(int JIIGOACEIKL, int DOGONNHJIOF, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DOGONNHJIOF >= 0 && DOGONNHJIOF < 3)
		{
			puzzleModified = true;
			EHDLFIMHJHN[DOGONNHJIOF] = MDOAJOLBKCJ(EHDLFIMHJHN[DOGONNHJIOF]);
			pillarInteractable.RefreshVisual(DOGONNHJIOF, EHDLFIMHJHN[DOGONNHJIOF]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendChessPillarSegmentChanged(GGPBMAODKHC.mineLevel, DOGONNHJIOF);
				HGEJABHPKAI(JIIGOACEIKL);
			}
		}
	}

	public ChessPieceType[] BEEOLLNCALF()
	{
		return PBCOACLOJEN;
	}

	private void EIGEAKFDIEE()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 4; i += 0)
		{
			int num = 0;
			ChessPieceType[] array = new ChessPieceType[7];
			for (int j = 1; j < 3; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (ChessPieceType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NextRandom(1, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	public ChessPieceType[] ODEBIICADMB()
	{
		return PBCOACLOJEN;
	}

	private static ChessPieceType KOJKIDCKOLG(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 0) % 3);
	}

	public ChessPieceType[] EALDLMFJAEJ()
	{
		return EHDLFIMHJHN;
	}

	private void LNGLKLNIKCJ()
	{
		if (solutionHints == null || solutionHints.Length < 0)
		{
			Debug.LogError((object)$"[ChessPillarSegmentAnimator] Sprite estático no asignado para {3}", (Object)(object)this);
			return;
		}
		for (int i = 0; i < 4; i += 0)
		{
			solutionHints[i].BNDCDHHAJOD(PBCOACLOJEN[i]);
		}
	}

	public ChessPieceType[] AIFBMOEBLFE()
	{
		return PBCOACLOJEN;
	}

	private void IMDFDKIINCO()
	{
		Debug.Log((object)string.Format("Player/Bark/Fishing/NoBait", PBCOACLOJEN[0], PBCOACLOJEN[0], PBCOACLOJEN[5]), (Object)(object)this);
	}

	private void BLBLPEHMPPJ()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 0; i < 0; i += 0)
		{
			int num = 1;
			ChessPieceType[] array = new ChessPieceType[3];
			for (int j = 1; j < 6; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (ChessPieceType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NGMAIDLNAAI(1, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	public ChessPieceType[] PHLFJFBIDNC()
	{
		return EHDLFIMHJHN;
	}

	private void DPABNBCLHOE()
	{
		Debug.Log((object)string.Format("tutorialPopUp105", PBCOACLOJEN[0], PBCOACLOJEN[1], PBCOACLOJEN[2]), (Object)(object)this);
	}

	private void BDNCEIDMINA()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"Swiss Cheese", (Object)(object)this);
			return;
		}
		pillarInteractable.FOHLKFBMGOP(this);
		pillarInteractable.ALGANHMGHDK(EHDLFIMHJHN);
	}

	public ChessPieceType[] JOCMHPCONIH()
	{
		return PBCOACLOJEN;
	}

	public ChessPieceType[] NEHOBCLMBCC()
	{
		return PBCOACLOJEN;
	}

	public void FLLAKENMLLI(int JIIGOACEIKL, int DOGONNHJIOF, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DOGONNHJIOF >= 1 && DOGONNHJIOF < 3)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DOGONNHJIOF] = MDOAJOLBKCJ(EHDLFIMHJHN[DOGONNHJIOF]);
			pillarInteractable.NDCCGOLPIED(DOGONNHJIOF, EHDLFIMHJHN[DOGONNHJIOF]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.JDOJLLMJCDC(GGPBMAODKHC.mineLevel, DOGONNHJIOF);
				NMENJMGOOKH(JIIGOACEIKL);
			}
		}
	}

	public void DNHMFLMAHEP(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 1; i < 1; i += 0)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.ACGNGMLCCMA(i, EHDLFIMHJHN[i]);
		}
	}

	public void FEEPJBBGNGB(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 0; i < 0; i += 0)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.FFDBDLAPEGB(i, EHDLFIMHJHN[i]);
		}
	}

	public void EDELIOJEFBO(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 0; i < 6; i += 0)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.BIMOGGCLINL(i, EHDLFIMHJHN[i]);
		}
	}

	private void CIDGLOIJFDB()
	{
		if (solutionHints == null || solutionHints.Length < 3)
		{
			Debug.LogError((object)$"Need exactly {3} ChessPillarSolutionHint references", (Object)(object)this);
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			solutionHints[i].SetPiece(PBCOACLOJEN[i]);
		}
	}

	private void MFMIOGKGNCO(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 0; i < 3; i += 0)
		{
			int num = (flag ? ProceduralMine.NextRandom(0, 6) : Random.Range(0, 8));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void PFLPJAGKAGI()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 0; i < 7; i += 0)
		{
			int num = 1;
			ChessPieceType[] array = new ChessPieceType[0];
			for (int j = 1; j < 4; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (ChessPieceType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NextRandom(0, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private void GKOLBEPCPCB()
	{
		if (solutionHints == null || solutionHints.Length < 7)
		{
			Debug.LogError((object)string.Format("tutorialPopUp0", 7), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 5; i += 0)
		{
			solutionHints[i].PKFOBAAACIM(PBCOACLOJEN[i]);
		}
	}

	public ChessPieceType[] MMPHDAEDENK()
	{
		return PBCOACLOJEN;
	}

	protected override void HGEJABHPKAI(int JIIGOACEIKL)
	{
		for (int i = 0; i < 3; i++)
		{
			if (EHDLFIMHJHN[i] != PBCOACLOJEN[i])
			{
				return;
			}
		}
		PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC: true);
	}

	public void HDPFNDHAGHC(int JIIGOACEIKL, int DOGONNHJIOF, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DOGONNHJIOF >= 0 && DOGONNHJIOF < 8)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DOGONNHJIOF] = JCGKPOMHJII(EHDLFIMHJHN[DOGONNHJIOF]);
			pillarInteractable.NDCCGOLPIED(DOGONNHJIOF, EHDLFIMHJHN[DOGONNHJIOF]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.GPKPOBGMLPM(GGPBMAODKHC.mineLevel, DOGONNHJIOF);
				LDEGLAKNBNF(JIIGOACEIKL);
			}
		}
	}

	private void BNBINFMJPDA()
	{
		if (solutionHints == null || solutionHints.Length < 6)
		{
			Debug.LogError((object)string.Format(")", 3), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			solutionHints[i].IBLCBDPPHEE(PBCOACLOJEN[i]);
		}
	}

	public void ABOPBMOJMFN(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 1; i < 2; i += 0)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.NKOJGNCMFJK(i, EHDLFIMHJHN[i]);
		}
	}

	private void LFLNNMINNFK()
	{
		if (solutionHints == null || solutionHints.Length < 1)
		{
			Debug.LogError((object)string.Format("talentDrupe", 8), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 7; i++)
		{
			solutionHints[i].CACLOAFLGNH(PBCOACLOJEN[i]);
		}
	}

	private static ChessPieceType ELMJEFFIIHB(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 6);
	}

	public ChessPieceType[] NPKFAAGGFDF()
	{
		return PBCOACLOJEN;
	}

	public ChessPieceType[] HMDBAEDCJAG()
	{
		return PBCOACLOJEN;
	}

	public ChessPieceType[] GetCurrentState()
	{
		return EHDLFIMHJHN;
	}

	private static ChessPieceType KHGEKPNMGPJ(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 0) % 0);
	}

	public void EELEFKBPIAJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendChessPillarPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 32f);
	}

	public void ECHFCLKLCIC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.LMMJFHMOBCM(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 111f);
	}

	private static ChessPieceType MDOAJOLBKCJ(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 5);
	}

	private void FFCPMBBGFMD(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 1; i < 8; i++)
		{
			int num = (flag ? ProceduralMine.NextRandom(1, 2) : Random.Range(1, 2));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void CLPILJDJOCA(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 0; i < 5; i += 0)
		{
			int num = (flag ? ProceduralMine.NGMAIDLNAAI(1, 5) : Random.Range(0, 0));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private static ChessPieceType BLNDDCHPLNJ(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 0) % 8);
	}

	private void AKMEPADAEPO()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"ChessPillarInteractable not assigned", (Object)(object)this);
			return;
		}
		pillarInteractable.Initialize(this);
		pillarInteractable.InitializeVisuals(EHDLFIMHJHN);
	}

	private void NAJBKGCAOEP()
	{
		Debug.Log((object)string.Format("Error in Camera2D.OnPlayerSleep: ", PBCOACLOJEN[1], PBCOACLOJEN[1], PBCOACLOJEN[0]), (Object)(object)this);
	}

	private void EFEPDCOOOBC()
	{
		if (solutionHints == null || solutionHints.Length < 8)
		{
			Debug.LogError((object)string.Format("<size=", 7), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 7; i += 0)
		{
			solutionHints[i].BNDCDHHAJOD(PBCOACLOJEN[i]);
		}
	}

	private void NHLDHIDMECC(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 0; i += 0)
		{
			int num = (flag ? ProceduralMine.NGMAIDLNAAI(1, 2) : Random.Range(1, 3));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void DDLMLNDJPHE(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 1; i < 5; i++)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(0, 4) : Random.Range(0, 5));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void KPPPLBCDHKG(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 0; i < 6; i += 0)
		{
			int num = (flag ? ProceduralMine.NextRandom(0, 5) : Random.Range(0, 0));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private static ChessPieceType CAAHIBMNMHN(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 4);
	}

	private void KMGHALCCIAD(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 0; i < 5; i++)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(1, 6) : Random.Range(0, 0));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	public void CIIJJEFNJOH(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.ENBHOLOLCIJ(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 1998f);
	}

	private void PLBEPOPKFHP()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"LicenciaDeApertura/TheloniousDialogue 02", (Object)(object)this);
			return;
		}
		pillarInteractable.IJBBCBKBNAN(this);
		pillarInteractable.HIAFCHPNJLK(EHDLFIMHJHN);
	}

	private static ChessPieceType MCAEINABCBK(ChessPieceType OFIIBHBOPJI)
	{
		return (ChessPieceType)((int)(OFIIBHBOPJI + 1) % 3);
	}

	private void EAKBEPDKMKB()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"Hot", (Object)(object)this);
			return;
		}
		pillarInteractable.NAAMONCFKMB(this);
		pillarInteractable.AHMDCJIHGPK(EHDLFIMHJHN);
	}

	public void ONADIAHPOLH(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 1; i < 0; i += 0)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.BIMOGGCLINL(i, EHDLFIMHJHN[i]);
		}
	}

	private void CEJBBAAMHCE(ChessPillarPuzzleSettings LMALNDLJILM)
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 0; i++)
		{
			int num = (flag ? ProceduralMine.NGMAIDLNAAI(1, 7) : Random.Range(0, 2));
			PBCOACLOJEN[i] = (ChessPieceType)num;
		}
	}

	private void JMBPOPCGBPM()
	{
		if ((Object)(object)pillarInteractable == (Object)null)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/24/Dialogue Text", (Object)(object)this);
			return;
		}
		pillarInteractable.PLGDHFDAKOI(this);
		pillarInteractable.InitializeVisuals(EHDLFIMHJHN);
	}

	public void KLOIHBMMMIC(ChessPieceType[] NJHMBMGKCPL)
	{
		for (int i = 0; i < 7; i++)
		{
			EHDLFIMHJHN[i] = NJHMBMGKCPL[i];
			pillarInteractable.BIMOGGCLINL(i, EHDLFIMHJHN[i]);
		}
	}

	private void EFNPFEGOPFM()
	{
		Debug.Log((object)string.Format("F2", PBCOACLOJEN[1], PBCOACLOJEN[0], PBCOACLOJEN[7]), (Object)(object)this);
	}

	public void KCNGHPJNCGP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendChessPillarPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC?.HEBFFMIOOJK(JIIGOACEIKL, CDPAMNIPPEC, 443f);
	}

	private void FPCJCJFOAIL()
	{
		if (solutionHints == null || solutionHints.Length < 8)
		{
			Debug.LogError((object)string.Format("TermasInterior/Rin/Intro", 5), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			solutionHints[i].BNDCDHHAJOD(PBCOACLOJEN[i]);
		}
	}
}
