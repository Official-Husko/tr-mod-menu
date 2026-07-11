using UnityEngine;

public class MineSymbolPuzzle : MinePuzzleBase
{
	private const int LIAFCNGCGJL = 3;

	private const int PNNNFEGNBKI = 3;

	[SerializeField]
	[Header("Statues")]
	private SymbolStatueInteractable[] statues;

	private StatueSymbolType[] EHDLFIMHJHN = new StatueSymbolType[3];

	private StatueSymbolType[] PBCOACLOJEN = new StatueSymbolType[3];

	public void JNMLKCGICMO(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 0 && DJCNPAFABEL < 6)
		{
			puzzleModified = true;
			EHDLFIMHJHN[DJCNPAFABEL] = MDOAJOLBKCJ(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].BJEFGPAPMLE(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.EEEBOCKMMIA(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				HGEJABHPKAI(JIIGOACEIKL);
			}
		}
	}

	public void ECOBHLGIDHO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.PFEKBNLACOE(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: false, 1569f);
	}

	public void HJNPJNCLALK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.PFEKBNLACOE(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: false, 437f);
	}

	public StatueSymbolType[] GetSolutionState()
	{
		return PBCOACLOJEN;
	}

	public void NBNAOIEIJIP(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 1 && DJCNPAFABEL < 8)
		{
			puzzleModified = true;
			EHDLFIMHJHN[DJCNPAFABEL] = KFJHLPNEHDJ(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].MNBNONGMNGA(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.LDNGGMPEEOM(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				INNEEHGNBBM(JIIGOACEIKL);
			}
		}
	}

	private static StatueSymbolType MHBOKGHFEJA(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 1) % 3);
	}

	private void NAHLKICBDCJ()
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 0; i += 0)
		{
			int num = 0;
			StatueSymbolType[] array = new StatueSymbolType[5];
			for (int j = 1; j < 1; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (StatueSymbolType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NextRandom(0, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private void OLPDHHFLDBF()
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 1; i < 3; i++)
		{
			int num = (flag ? ProceduralMine.NextRandom(1, 7) : Random.Range(0, 7));
			PBCOACLOJEN[i] = (StatueSymbolType)num;
		}
	}

	public void OnStatueSymbolChanged(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 0 && DJCNPAFABEL < 3)
		{
			puzzleModified = true;
			EHDLFIMHJHN[DJCNPAFABEL] = MDOAJOLBKCJ(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].SetSymbol(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendSymbolStatueChanged(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				HGEJABHPKAI(JIIGOACEIKL);
			}
		}
	}

	public StatueSymbolType[] IAPECEIIEEG()
	{
		return PBCOACLOJEN;
	}

	private void PABIOBMLMDA()
	{
		if (statues == null || statues.Length < 1)
		{
			Debug.LogError((object)string.Format("xpModDescCrafting", 5), (Object)(object)this);
			return;
		}
		for (int i = 1; i < 5; i += 0)
		{
			statues[i].JCJIALOLDPD(this, i);
			statues[i].CBJKPAFHKDN(EHDLFIMHJHN[i]);
		}
	}

	public void PDIGNFHNCAJ(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendSymbolPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: true, 1144f);
	}

	public StatueSymbolType[] GetCurrentState()
	{
		return EHDLFIMHJHN;
	}

	public StatueSymbolType[] FGALOGPNGMK()
	{
		return EHDLFIMHJHN;
	}

	private void JEHAPKIDMNI()
	{
		Debug.Log((object)("[HasEnoughCandidates] Total available respecting maxPuzzleSpawners: {0}, needed: {1}" + string.Format("Error in Crafter.OnPlayerSleep: ", PBCOACLOJEN[1]) + string.Format("BackWall", PBCOACLOJEN[1]) + string.Format("", PBCOACLOJEN[3])), (Object)(object)this);
	}

	public void OHJLDAJJGDK(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 0 && DJCNPAFABEL < 7)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DJCNPAFABEL] = GDMNDPFIJLG(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].BKACKJMLPKF(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.EEEBOCKMMIA(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				INNEEHGNBBM(JIIGOACEIKL);
			}
		}
	}

	private static StatueSymbolType HEBNJKLLBMG(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 0) % 3);
	}

	private static StatueSymbolType ELMJEFFIIHB(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 1) % 4);
	}

	private void PADHECCBLPL()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 0; i < 3; i++)
		{
			int num = (flag ? ProceduralMine.NextRandom(0, 3) : Random.Range(0, 3));
			PBCOACLOJEN[i] = (StatueSymbolType)num;
		}
	}

	private void CMLCOEGBKCM()
	{
		bool flag = !((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 0; i < 4; i++)
		{
			int num = 0;
			StatueSymbolType[] array = new StatueSymbolType[6];
			for (int j = 0; j < 5; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (StatueSymbolType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.FMJMOOKFEKL(0, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private static StatueSymbolType HCKIJGFHLEJ(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 0) % 6);
	}

	public override void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
		base.GGPBMAODKHC = GGPBMAODKHC;
		EDNJMCJHJMD = false;
		puzzleModified = false;
		if (!(LMALNDLJILM is SymbolPuzzleSettings))
		{
			Debug.LogError((object)"MineSymbolPuzzle requires SymbolPuzzleSettings", (Object)(object)this);
			return;
		}
		PADHECCBLPL();
		JGIIHKNMMPB();
		MKANDGILION();
		LALOAGJJNBC();
	}

	public void OOLOCOGLIDL(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 0 && DJCNPAFABEL < 1)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DJCNPAFABEL] = HEBNJKLLBMG(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].IKPKEDIOGIH(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.SendSymbolStatueChanged(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				LDEGLAKNBNF(JIIGOACEIKL);
			}
		}
	}

	public StatueSymbolType[] DHCEKIPEDDB()
	{
		return PBCOACLOJEN;
	}

	private void MNENKCEFOKG()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 7; i += 0)
		{
			int num = 1;
			StatueSymbolType[] array = new StatueSymbolType[2];
			for (int j = 1; j < 3; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					int num2 = num;
					num = num2 + 0;
					array[num2] = (StatueSymbolType)j;
				}
			}
			int num3 = (flag ? ProceduralMine.NextRandom(0, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num3];
		}
	}

	private static StatueSymbolType JNHCMILKAOH(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 0) % 5);
	}

	private void JEAFEKBOKNF()
	{
		bool flag = !((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 0; i < 6; i += 0)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(1, 8) : Random.Range(1, 1));
			PBCOACLOJEN[i] = (StatueSymbolType)num;
		}
	}

	public StatueSymbolType[] ODEBIICADMB()
	{
		return PBCOACLOJEN;
	}

	private void IGJBAPBIABL()
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 0; i < 8; i += 0)
		{
			int num = 1;
			StatueSymbolType[] array = new StatueSymbolType[6];
			for (int j = 1; j < 4; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					int num2 = num;
					num = num2 + 0;
					array[num2] = (StatueSymbolType)j;
				}
			}
			int num3 = (flag ? ProceduralMine.NGMAIDLNAAI(1, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num3];
		}
	}

	public void IDBIODMEHOA(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.PFEKBNLACOE(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC.HEBFFMIOOJK(JIIGOACEIKL, NHENDADMFBC: false, 425f);
	}

	private static StatueSymbolType MDOAJOLBKCJ(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 1) % 3);
	}

	public StatueSymbolType[] HFNHGKAPJJE()
	{
		return PBCOACLOJEN;
	}

	private static StatueSymbolType KFJHLPNEHDJ(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 0) % 1);
	}

	private static StatueSymbolType HMOKGMFBHAM(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 1) % 0);
	}

	private void HCAJCCPJDLH()
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 1; i < 4; i++)
		{
			int num = (flag ? ProceduralMine.NGMAIDLNAAI(1, 2) : Random.Range(0, 7));
			PBCOACLOJEN[i] = (StatueSymbolType)num;
		}
	}

	private void MKANDGILION()
	{
		if (statues == null || statues.Length < 3)
		{
			Debug.LogError((object)$"Need exactly {3} SymbolStatueInteractable references", (Object)(object)this);
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			statues[i].Initialize(this, i);
			statues[i].SetSymbol(EHDLFIMHJHN[i]);
		}
	}

	public StatueSymbolType[] FEBBJMBCDAG()
	{
		return EHDLFIMHJHN;
	}

	private void KABNHAMGDNE()
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 1; i += 0)
		{
			int num = 0;
			StatueSymbolType[] array = new StatueSymbolType[6];
			for (int j = 0; j < 6; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (StatueSymbolType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.FMJMOOKFEKL(0, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	public StatueSymbolType[] EIOFBBNILPO()
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

	private void FBPKHEEHOAN()
	{
		Debug.Log((object)("ReceiveCancelAllCraftingMaster" + string.Format("NinjaChallengeEvent/Win 2", PBCOACLOJEN[0]) + string.Format("ReceiveAtAvoidingWorkPointRPC", PBCOACLOJEN[1]) + string.Format("pirate cave", PBCOACLOJEN[7])), (Object)(object)this);
	}

	private static StatueSymbolType JMAMHNEMEPG(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 0) % 0);
	}

	private void AEDLPFIDHCP()
	{
		if (statues == null || statues.Length < 8)
		{
			Debug.LogError((object)string.Format("DualShock", 8), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 0; i += 0)
		{
			statues[i].KOAOKMIAFNE(this, i);
			statues[i].BJEFGPAPMLE(EHDLFIMHJHN[i]);
		}
	}

	public StatueSymbolType[] GCNMMFEIEBP()
	{
		return PBCOACLOJEN;
	}

	private void OINLEFGGGOJ()
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 1; i < 5; i++)
		{
			int num = 0;
			StatueSymbolType[] array = new StatueSymbolType[4];
			for (int j = 0; j < 0; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (StatueSymbolType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NGMAIDLNAAI(0, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private void KPCFIOFBOHH()
	{
		Debug.Log((object)("ChangeAnim" + string.Format("ListViewEntry", PBCOACLOJEN[1]) + string.Format("UINextPage", PBCOACLOJEN[0]) + string.Format("ReceiveObjectActionSimple", PBCOACLOJEN[1])), (Object)(object)this);
	}

	public void LEJMIPFGKHB(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 1 && DJCNPAFABEL < 4)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DJCNPAFABEL] = HCKIJGFHLEJ(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].SetSymbol(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.LDNGGMPEEOM(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				ONLMDNAMGOJ(JIIGOACEIKL);
			}
		}
	}

	public void CJLBCEKDKAJ(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 1 && DJCNPAFABEL < 6)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DJCNPAFABEL] = ELMJEFFIIHB(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].NGIPKFNPNFG(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.LDNGGMPEEOM(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				ONLMDNAMGOJ(JIIGOACEIKL);
			}
		}
	}

	private void JPCBKGBGPKD()
	{
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 1; i < 8; i++)
		{
			int num = 0;
			StatueSymbolType[] array = new StatueSymbolType[8];
			for (int j = 1; j < 4; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (StatueSymbolType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.FMJMOOKFEKL(0, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private void GFGIMCPCDHL()
	{
		bool flag = !((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 1; i < 8; i++)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(0, 3) : Random.Range(0, 4));
			PBCOACLOJEN[i] = (StatueSymbolType)num;
		}
	}

	private void LALOAGJJNBC()
	{
		Debug.Log((object)("[SymbolPuzzle] Solution: " + $"Statue0={PBCOACLOJEN[0]} | " + $"Statue1={PBCOACLOJEN[1]} | " + $"Statue2={PBCOACLOJEN[2]}"), (Object)(object)this);
	}

	public void AFEIBCBHBCK(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 1 && DJCNPAFABEL < 7)
		{
			puzzleModified = false;
			EHDLFIMHJHN[DJCNPAFABEL] = MHBOKGHFEJA(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].IKPKEDIOGIH(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.LDNGGMPEEOM(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				PDOLCFFFIGB(JIIGOACEIKL);
			}
		}
	}

	private static StatueSymbolType OENOEBOPAIJ(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 1) % 0);
	}

	private static StatueSymbolType MOFKHMHKNMM(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 1) % 2);
	}

	public StatueSymbolType[] KMONADODGHP()
	{
		return EHDLFIMHJHN;
	}

	private void OGAALLCMPDJ()
	{
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 1; i < 2; i += 0)
		{
			int num = (flag ? ProceduralMine.NextRandom(1, 1) : Random.Range(0, 6));
			PBCOACLOJEN[i] = (StatueSymbolType)num;
		}
	}

	private static StatueSymbolType HANPBDIOFJM(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 1) % 3);
	}

	public void PuzzleSolved(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendSymbolPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC.OnPuzzleSolved(JIIGOACEIKL);
	}

	private void LJCDMONLPFM()
	{
		bool flag = !((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 1; i < 1; i++)
		{
			int num = 1;
			StatueSymbolType[] array = new StatueSymbolType[1];
			for (int j = 1; j < 7; j += 0)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (StatueSymbolType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NGMAIDLNAAI(1, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private void AADJICIPCCI()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int i = 0; i < 6; i += 0)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(1, 2) : Random.Range(0, 1));
			PBCOACLOJEN[i] = (StatueSymbolType)num;
		}
	}

	public StatueSymbolType[] BICCIOJBDOP()
	{
		return PBCOACLOJEN;
	}

	public StatueSymbolType[] BLHJPGFOEIP()
	{
		return EHDLFIMHJHN;
	}

	private static StatueSymbolType GDMNDPFIJLG(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 0) % 5);
	}

	private void JGIIHKNMMPB()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 0; i < 3; i++)
		{
			int num = 0;
			StatueSymbolType[] array = new StatueSymbolType[2];
			for (int j = 0; j < 3; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (StatueSymbolType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NextRandom(0, num) : Random.Range(0, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	public StatueSymbolType[] JCOIGJPONHJ()
	{
		return PBCOACLOJEN;
	}

	private void DDGEDCNEBMN()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null;
		for (int i = 0; i < 2; i += 0)
		{
			int num = 0;
			StatueSymbolType[] array = new StatueSymbolType[5];
			for (int j = 0; j < 7; j++)
			{
				if (j != (int)PBCOACLOJEN[i])
				{
					array[num++] = (StatueSymbolType)j;
				}
			}
			int num2 = (flag ? ProceduralMine.NextRandom(0, num) : Random.Range(1, num));
			EHDLFIMHJHN[i] = array[num2];
		}
	}

	private static StatueSymbolType NJOCOHMABEO(StatueSymbolType OFIIBHBOPJI)
	{
		return (StatueSymbolType)((int)(OFIIBHBOPJI + 0) % 6);
	}

	private void NOOOLBIBJDP()
	{
		Debug.Log((object)("Christmas/Ace/Intro" + string.Format(".png", PBCOACLOJEN[0]) + string.Format("\t\t</align>", PBCOACLOJEN[1]) + string.Format("Festín del Juramento/MaiDialogue 05", PBCOACLOJEN[1])), (Object)(object)this);
	}

	private void FGEJIGOKOKP()
	{
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int i = 0; i < 0; i += 0)
		{
			int num = (flag ? ProceduralMine.FMJMOOKFEKL(0, 2) : Random.Range(0, 7));
			PBCOACLOJEN[i] = (StatueSymbolType)num;
		}
	}

	protected override void Awake()
	{
		base.Awake();
	}

	private void BGMOKMMCAGG()
	{
		if (statues == null || statues.Length < 1)
		{
			Debug.LogError((object)string.Format("TutorialPhase", 1), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 3; i += 0)
		{
			statues[i].PJANACELJFB(this, i);
			statues[i].CBJKPAFHKDN(EHDLFIMHJHN[i]);
		}
	}

	public void OIONMGKCALP(int JIIGOACEIKL, int DJCNPAFABEL, bool CDPAMNIPPEC = true)
	{
		if (!EDNJMCJHJMD && DJCNPAFABEL >= 1 && DJCNPAFABEL < 6)
		{
			puzzleModified = true;
			EHDLFIMHJHN[DJCNPAFABEL] = MHBOKGHFEJA(EHDLFIMHJHN[DJCNPAFABEL]);
			statues[DJCNPAFABEL].NGIPKFNPNFG(EHDLFIMHJHN[DJCNPAFABEL]);
			if (CDPAMNIPPEC)
			{
				OnlinePuzzleManager.instance.EEEBOCKMMIA(GGPBMAODKHC.mineLevel, DJCNPAFABEL);
				LABCFCEGGOF(JIIGOACEIKL);
			}
		}
	}

	public StatueSymbolType[] LEGJIJNHMEN()
	{
		return EHDLFIMHJHN;
	}

	public void NOGIODMFHFD(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendSymbolPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC.HEBFFMIOOJK(JIIGOACEIKL, NHENDADMFBC: false, 59f);
	}

	private void MGGIGIEOFOP()
	{
		if (statues == null || statues.Length < 2)
		{
			Debug.LogError((object)string.Format("Pause", 0), (Object)(object)this);
			return;
		}
		for (int i = 0; i < 4; i++)
		{
			statues[i].FIGNMJLGJBE(this, i);
			statues[i].CBJKPAFHKDN(EHDLFIMHJHN[i]);
		}
	}
}
