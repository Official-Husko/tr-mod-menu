using UnityEngine;
using UnityEngine.Tilemaps;

public class FloorLimitsManager : MonoBehaviour, ISingleton
{
	public enum Opt
	{
		N,
		T,
		F
	}

	private static FloorLimitsManager GGFJGHHHEJC;

	private static DecorationTile MIMAGPFCMKH;

	private static FloorLimit MDIJNOHDOFK;

	private static TileBase DPANAKMICJH;

	private static bool OGJOGEEOPEN;

	private static bool IGICEDDLEAF;

	private static bool NNFAMJBFKMF;

	private static bool EGLGALMJBMI;

	private static bool PJJCGBPLHIO;

	private static bool OHKACKDCLHP;

	private static bool NLLCGPJEFGN;

	private static bool MDJJNIFMFCI;

	private static int FPGOGONNGDG;

	private void JHIGLABAIMK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void DDPJCNNFIAA()
	{
	}

	private static bool AIONAAAIEJD(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.PlayerBed))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer)))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)6)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 1)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static void MOCMKMCMMEM(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		IMEEFODHKGD(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			MFAEIGNLOMN(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private static bool EPLHIKFFFLP(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == ~(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.NextToWall))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.BNMLDAPCNKF()))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 0)
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public void IMMMIPGKOED()
	{
	}

	public static void BMAGOOLBLMF(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		OOPLMEGKNPM(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			NCHGLHLJCIJ(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	public void OLHHINKCELK()
	{
	}

	private void PCKOHAIPHFI()
	{
		GGFJGHHHEJC = this;
		JPKHIHLOHKE();
	}

	public static void DFPMEAKNFOF(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		MFAEIGNLOMN(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
		{
			HMFKKEBGEGB(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private static bool HNGLICIJJIK(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!FKLBDOCNJDH(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!NNCFEBHLIBO(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!DCOCAAKIDNI(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!DCOCAAKIDNI(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return false;
		}
		if (!NNCFEBHLIBO(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return false;
		}
		if (!KCKCIMHNGNH(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!AEBCPMPMCCG(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return true;
		}
		if (!FKLBDOCNJDH(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return true;
	}

	private static void JMBCGBBDPKH(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.NDDMHJKJBEK(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.KIMMMFKFCEK(Season.Summer)))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.FGKDPLDANOA(Season.Summer).floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.GetTilemaps(Season.Summer).floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = DCOFGNGNJAD(IMOBLFMHKOD + new Vector3(1503f, 195f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = ONKGCMEBLHD(IMOBLFMHKOD + new Vector3(1874f, 714f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = MEEICCLKING(IMOBLFMHKOD + new Vector3(361f, 1065f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = PBIILCKCIJN(IMOBLFMHKOD + new Vector3(465f, 756f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = MDJDEANKCLF(IMOBLFMHKOD + new Vector3(88f, 1552f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = MDJDEANKCLF(IMOBLFMHKOD + new Vector3(1408f, 201f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = DGLKIKGGEJK(IMOBLFMHKOD + new Vector3(1230f, 993f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = EHFDELBEPFI(IMOBLFMHKOD + new Vector3(988f, 460f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (EMFDIOOMAPI((Opt)6, Opt.T, Opt.N, Opt.T, Opt.T, Opt.T, (Opt)3, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (MIDPJDMEAFH(Opt.T, Opt.T, (Opt)6, Opt.N, Opt.T, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (OIKFIMJMCMH(Opt.N, Opt.N, Opt.N, Opt.T, (Opt)5, Opt.N, (Opt)6, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (HGHJCPJMOGA(Opt.T, Opt.N, (Opt)5, Opt.T, Opt.N, Opt.N, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (CPKGNMILEFP(Opt.T, Opt.N, Opt.N, Opt.N, Opt.N, Opt.T, Opt.T, Opt.N) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1878f), MDIJNOHDOFK.R.Length)];
		}
		else if (PEJKPGNIOKJ(Opt.T, Opt.N, Opt.T, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 644f), MDIJNOHDOFK.L.Length)];
		}
		else if (NDOBPHHAKPI((Opt)6, Opt.N, Opt.T, Opt.N, Opt.T, Opt.T, Opt.T, Opt.T) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1744f), MDIJNOHDOFK.U.Length)];
		}
		else if (CMHCHDEFLGK(Opt.T, Opt.N, Opt.T, Opt.T, (Opt)7, Opt.N, Opt.N, Opt.T) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 318f), MDIJNOHDOFK.D.Length)];
		}
		else if (HGHJCPJMOGA(Opt.T, Opt.T, Opt.T, Opt.N, Opt.N, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (HNGLICIJJIK(Opt.T, (Opt)6, Opt.N, Opt.N, Opt.N, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (HNGLICIJJIK(Opt.T, Opt.N, Opt.N, Opt.N, Opt.T, Opt.T, Opt.N, (Opt)3))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (DDLBGFMBMMG(Opt.T, Opt.N, Opt.N, Opt.N, Opt.N, (Opt)6, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.FGKDPLDANOA().floorUpperTilemap);
	}

	private static bool CAKKMPPKHKF(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.StairsUp | SpecificType.NextToWall))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer)))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			_ = FPGOGONNGDG;
			_ = 1;
			return false;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)7)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 0)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private void CGMFALLCMDF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void FLOFJHNAIKP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool JEBFEAJENDA(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.NextToWall))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.BNMLDAPCNKF(Season.Summer)))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			_ = FPGOGONNGDG;
			_ = 1;
			return true;
		}
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 1)
			{
				return false;
			}
			return false;
		}
		return false;
	}

	public static void FBIIFOFPMPA(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		OOPLMEGKNPM(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			OOPLMEGKNPM(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private void MBBIGANCPNE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void AAEAAEBBFKG()
	{
		GGFJGHHHEJC = this;
		JPKHIHLOHKE();
	}

	private static void DIPECGOFAKH(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer)))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.BNMLDAPCNKF().floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.FGKDPLDANOA().floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = MDJDEANKCLF(IMOBLFMHKOD + new Vector3(1335f, 1075f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = EHFDELBEPFI(IMOBLFMHKOD + new Vector3(1877f, 1665f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = AIONAAAIEJD(IMOBLFMHKOD + new Vector3(933f, 1922f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = MDJDEANKCLF(IMOBLFMHKOD + new Vector3(1832f, 1961f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = CAKKMPPKHKF(IMOBLFMHKOD + new Vector3(1866f, 382f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = IKKAOIMNCIK(IMOBLFMHKOD + new Vector3(1144f, 557f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = DGLKIKGGEJK(IMOBLFMHKOD + new Vector3(922f, 164f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = ONKGCMEBLHD(IMOBLFMHKOD + new Vector3(562f, 51f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (DDLBGFMBMMG((Opt)3, Opt.N, Opt.N, Opt.N, Opt.T, Opt.T, (Opt)5, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (NDOBPHHAKPI(Opt.F, Opt.T, (Opt)8, Opt.N, Opt.N, Opt.T, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (MIDPJDMEAFH(Opt.T, Opt.N, Opt.T, Opt.T, (Opt)5, Opt.N, (Opt)5, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (CMHCHDEFLGK(Opt.T, Opt.T, (Opt)8, Opt.N, (Opt)3, Opt.T, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (HAKLBBOELFE(Opt.N, Opt.N, (Opt)4, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1913f), MDIJNOHDOFK.R.Length)];
		}
		else if (MIDPJDMEAFH(Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, (Opt)5, Opt.T) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1101f), MDIJNOHDOFK.L.Length)];
		}
		else if (MIDPJDMEAFH((Opt)4, Opt.T, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1620f), MDIJNOHDOFK.U.Length)];
		}
		else if (IGILIPFFKNE(Opt.T, Opt.T, Opt.T, Opt.N, (Opt)3, Opt.T, Opt.T, Opt.T) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1447f), MDIJNOHDOFK.D.Length)];
		}
		else if (MIDPJDMEAFH(Opt.N, Opt.N, Opt.N, (Opt)8, Opt.T, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (IGILIPFFKNE(Opt.N, (Opt)8, Opt.N, Opt.T, Opt.N, Opt.T, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (HGHJCPJMOGA(Opt.N, Opt.N, Opt.T, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (HAKLBBOELFE(Opt.N, Opt.T, Opt.T, Opt.N, Opt.N, Opt.F, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.FGKDPLDANOA(Season.Summer).floorUpperTilemap);
	}

	private static bool NKHKILIGJOP(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!FKLBDOCNJDH(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!FKLBDOCNJDH(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!FKLBDOCNJDH(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return false;
		}
		if (!FKLBDOCNJDH(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return false;
		}
		if (!FKLBDOCNJDH(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return false;
		}
		if (!FKLBDOCNJDH(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!FKLBDOCNJDH(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return false;
		}
		if (!FKLBDOCNJDH(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return true;
	}

	private static bool OIKFIMJMCMH(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!KCKCIMHNGNH(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return true;
		}
		if (!KCKCIMHNGNH(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return true;
		}
		if (!AFGNKFCDFBN(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!AEBCPMPMCCG(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return true;
		}
		if (!DCOCAAKIDNI(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!AFGNKFCDFBN(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!HLBHBAPMCFG(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return false;
		}
		if (!AFGNKFCDFBN(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return true;
		}
		return true;
	}

	public void JPKHIHLOHKE()
	{
	}

	private static void MFAEIGNLOMN(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.HBOHFLANMHO(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.OEMIKEDPIKP()))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.GetTilemaps().floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.FGKDPLDANOA(Season.Summer).floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = DCOFGNGNJAD(IMOBLFMHKOD + new Vector3(782f, 405f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = BPLHIFAAEAH(IMOBLFMHKOD + new Vector3(1484f, 9f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = PBIILCKCIJN(IMOBLFMHKOD + new Vector3(719f, 1442f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = IKKAOIMNCIK(IMOBLFMHKOD + new Vector3(433f, 1916f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = DCOFGNGNJAD(IMOBLFMHKOD + new Vector3(1134f, 1920f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = EHFDELBEPFI(IMOBLFMHKOD + new Vector3(890f, 1867f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = EFHOICCJIED(IMOBLFMHKOD + new Vector3(251f, 1323f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = CJENPANPKBO(IMOBLFMHKOD + new Vector3(393f, 1468f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (MIDPJDMEAFH(Opt.T, Opt.T, Opt.N, Opt.T, Opt.N, Opt.T, (Opt)8, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (MIDPJDMEAFH(Opt.T, Opt.N, (Opt)8, Opt.N, Opt.T, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (IGILIPFFKNE(Opt.N, Opt.N, Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (HGHJCPJMOGA(Opt.T, Opt.T, (Opt)5, Opt.N, Opt.F, Opt.T, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (DDLBGFMBMMG(Opt.T, Opt.N, (Opt)5, Opt.N, Opt.T, Opt.N, Opt.T, Opt.T) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1060f), MDIJNOHDOFK.R.Length)];
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, Opt.F, Opt.N) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1085f), MDIJNOHDOFK.L.Length)];
		}
		else if (PEJKPGNIOKJ((Opt)7, Opt.N, Opt.T, Opt.N, Opt.T, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1454f), MDIJNOHDOFK.U.Length)];
		}
		else if (HAKLBBOELFE(Opt.T, Opt.T, Opt.N, Opt.N, Opt.N, Opt.T, Opt.T, Opt.T) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 340f), MDIJNOHDOFK.D.Length)];
		}
		else if (EMFDIOOMAPI(Opt.T, Opt.T, Opt.N, (Opt)3, Opt.N, Opt.T, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.F, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (NDOBPHHAKPI(Opt.N, Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, Opt.T, (Opt)8))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (OIKFIMJMCMH(Opt.N, Opt.N, Opt.T, Opt.N, Opt.T, Opt.N, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.OEMIKEDPIKP(Season.Summer).floorUpperTilemap);
	}

	private static bool CMHCHDEFLGK(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!AFGNKFCDFBN(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return true;
		}
		if (!MKNHHIJHBDH(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!NNCFEBHLIBO(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!MKNHHIJHBDH(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return true;
		}
		if (!NDOIFBGIKHN(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!AEBCPMPMCCG(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return true;
		}
		if (!NNCFEBHLIBO(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return true;
		}
		if (!KCKCIMHNGNH(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return true;
		}
		return true;
	}

	public static void KPCBALIDMOE(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		HMFKKEBGEGB(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			MFAEIGNLOMN(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private static bool ONKGCMEBLHD(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.Door | SpecificType.StairsUp))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.KIMMMFKFCEK(Season.Summer)))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)6)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 1)
			{
				return false;
			}
			return false;
		}
		return false;
	}

	private void FDGFMMKIBPL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void FBOGKDNKPIO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool HAKLBBOELFE(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!NDOIFBGIKHN(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!AEBCPMPMCCG(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return true;
		}
		if (!NNCFEBHLIBO(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!HLBHBAPMCFG(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return true;
		}
		if (!EDEMCOCLKGC(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!AEBCPMPMCCG(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!AFGNKFCDFBN(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return false;
		}
		if (!FKLBDOCNJDH(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return false;
	}

	private static void LFIEHNDIIJA(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.EMDLPJBBPDM(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.IAMBLEDHGDM()))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.BNMLDAPCNKF(Season.Summer).floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.OEMIKEDPIKP(Season.Summer).floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = AIJCNONIADH(IMOBLFMHKOD + new Vector3(1612f, 1862f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = IKKAOIMNCIK(IMOBLFMHKOD + new Vector3(1606f, 201f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = EPLHIKFFFLP(IMOBLFMHKOD + new Vector3(162f, 482f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = BPLHIFAAEAH(IMOBLFMHKOD + new Vector3(1491f, 1662f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = BPLHIFAAEAH(IMOBLFMHKOD + new Vector3(835f, 1243f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = MEEICCLKING(IMOBLFMHKOD + new Vector3(1400f, 714f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = CJENPANPKBO(IMOBLFMHKOD + new Vector3(1881f, 97f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = EPLHIKFFFLP(IMOBLFMHKOD + new Vector3(1222f, 1119f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (CMHCHDEFLGK((Opt)8, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N, (Opt)4, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (HNGLICIJJIK((Opt)8, Opt.T, (Opt)4, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (CICICLDDCNN(Opt.N, Opt.N, Opt.N, Opt.N, Opt.N, Opt.T, (Opt)7, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (IGILIPFFKNE(Opt.T, Opt.N, (Opt)8, Opt.N, (Opt)7, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.N, Opt.N, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 722f), MDIJNOHDOFK.R.Length)];
		}
		else if (JNNCGDEAHJL(Opt.N, Opt.N, Opt.T, Opt.T, Opt.N, Opt.N, (Opt)5, Opt.T) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 819f), MDIJNOHDOFK.L.Length)];
		}
		else if (NDOBPHHAKPI((Opt)7, Opt.N, Opt.N, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 775f), MDIJNOHDOFK.U.Length)];
		}
		else if (PEJKPGNIOKJ(Opt.N, Opt.N, Opt.N, Opt.T, (Opt)3, Opt.N, Opt.T, Opt.N) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 226f), MDIJNOHDOFK.D.Length)];
		}
		else if (HAKLBBOELFE(Opt.T, Opt.T, Opt.N, Opt.F, Opt.T, Opt.N, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (JNNCGDEAHJL(Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (DDLBGFMBMMG(Opt.N, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (OIKFIMJMCMH(Opt.N, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.OEMIKEDPIKP(Season.Summer).floorUpperTilemap);
	}

	private static bool AIJCNONIADH(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.Door | SpecificType.RoomDoor | SpecificType.PlayerBed))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.OEMIKEDPIKP(Season.Summer)))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 1;
			return true;
		}
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 0)
			{
				return true;
			}
			return true;
		}
		return true;
	}

	private static void NKOIMDFMMPB(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.BNKGPJPMFCI(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.BNMLDAPCNKF()))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.KIMMMFKFCEK().floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.GetTilemaps(Season.Summer).floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = EPLHIKFFFLP(IMOBLFMHKOD + new Vector3(491f, 1652f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = CAKKMPPKHKF(IMOBLFMHKOD + new Vector3(1072f, 1957f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = MDJDEANKCLF(IMOBLFMHKOD + new Vector3(209f, 720f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = EFHOICCJIED(IMOBLFMHKOD + new Vector3(133f, 1398f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = BPLHIFAAEAH(IMOBLFMHKOD + new Vector3(1181f, 617f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = CAKKMPPKHKF(IMOBLFMHKOD + new Vector3(1962f, 420f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = DCOFGNGNJAD(IMOBLFMHKOD + new Vector3(1024f, 1643f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = PIALDAKAJIP(IMOBLFMHKOD + new Vector3(798f, 1809f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (DDLBGFMBMMG(Opt.F, Opt.T, Opt.N, Opt.T, Opt.N, Opt.N, (Opt)3, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (NDOBPHHAKPI((Opt)5, Opt.T, Opt.N, Opt.N, Opt.N, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (OIKFIMJMCMH(Opt.T, Opt.T, Opt.N, Opt.N, (Opt)8, Opt.T, (Opt)5, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (HAKLBBOELFE(Opt.T, Opt.T, Opt.N, Opt.N, Opt.F, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (IGILIPFFKNE(Opt.T, Opt.N, Opt.F, Opt.T, Opt.T, Opt.N, Opt.T, Opt.T) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 698f), MDIJNOHDOFK.R.Length)];
		}
		else if (OIKFIMJMCMH(Opt.N, Opt.N, Opt.N, Opt.T, Opt.T, Opt.N, (Opt)4, Opt.N) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 22f), MDIJNOHDOFK.L.Length)];
		}
		else if (MIDPJDMEAFH(Opt.F, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T, Opt.N, Opt.N) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 86f), MDIJNOHDOFK.U.Length)];
		}
		else if (NDOBPHHAKPI(Opt.N, Opt.T, Opt.T, Opt.T, (Opt)7, Opt.T, Opt.T, Opt.N) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 8f), MDIJNOHDOFK.D.Length)];
		}
		else if (NDOBPHHAKPI(Opt.T, Opt.N, Opt.T, (Opt)4, Opt.N, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (NDOBPHHAKPI(Opt.N, Opt.N, Opt.N, Opt.N, Opt.N, Opt.N, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (PEJKPGNIOKJ(Opt.N, Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, Opt.T, Opt.F))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (JNNCGDEAHJL(Opt.N, Opt.N, Opt.N, Opt.T, Opt.N, (Opt)3, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer).floorUpperTilemap);
	}

	public void ResetSingleton()
	{
	}

	private static bool EFHOICCJIED(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.StairsUp | SpecificType.StairsDown))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(Season.Summer)))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)5)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 1)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private static bool HGHJCPJMOGA(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!HLBHBAPMCFG(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!NNCFEBHLIBO(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!KCKCIMHNGNH(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!AFGNKFCDFBN(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return false;
		}
		if (!NNCFEBHLIBO(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!DCOCAAKIDNI(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return true;
		}
		if (!FKLBDOCNJDH(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return true;
		}
		if (!NNCFEBHLIBO(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return true;
	}

	private static bool CICICLDDCNN(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!AFGNKFCDFBN(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!MKNHHIJHBDH(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return true;
		}
		if (!NDOIFBGIKHN(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return false;
		}
		if (!EDEMCOCLKGC(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return false;
		}
		if (!DCOCAAKIDNI(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return false;
		}
		if (!AEBCPMPMCCG(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!NDOIFBGIKHN(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return false;
		}
		if (!AEBCPMPMCCG(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return false;
	}

	public void GHNJFMJJGDP()
	{
	}

	private static bool KCKCIMHNGNH(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.N && !NCIHJIJKCHB)
			{
				return false;
			}
			if (PCCNAKNPKAG == Opt.N && NCIHJIJKCHB)
			{
				return false;
			}
		}
		return true;
	}

	public static void OJAEFHJDOOJ(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		NCHGLHLJCIJ(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			MFAEIGNLOMN(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private static bool NDOIFBGIKHN(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.T && !NCIHJIJKCHB)
			{
				return true;
			}
			if (PCCNAKNPKAG == (Opt)3 && NCIHJIJKCHB)
			{
				return true;
			}
		}
		return true;
	}

	private void JOIMGFPMKNI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void BNHNFAAGLEP()
	{
	}

	private void DNBGIIGAKMJ()
	{
		GGFJGHHHEJC = this;
		CDPEKMENJKH();
	}

	private static bool GDNFDFHNMKF(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.StairsDown))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.IAMBLEDHGDM(Season.Summer)))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			_ = FPGOGONNGDG;
			_ = 1;
			return true;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)5)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 0)
			{
				return false;
			}
			return false;
		}
		return false;
	}

	public void BAALODAJNOP()
	{
	}

	private static bool NNCFEBHLIBO(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.N && !NCIHJIJKCHB)
			{
				return false;
			}
			if (PCCNAKNPKAG == (Opt)5 && NCIHJIJKCHB)
			{
				return true;
			}
		}
		return false;
	}

	public static void OOPMAIOJIII(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		IMEEFODHKGD(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
		{
			BKIBEBALMMH(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private static bool PIALDAKAJIP(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.NextToWall))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer)))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 0)
			{
				return true;
			}
			return true;
		}
		return false;
	}

	private static void HMFKKEBGEGB(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.EMDLPJBBPDM(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps()))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.IAMBLEDHGDM(Season.Summer).floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer).floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = PBIILCKCIJN(IMOBLFMHKOD + new Vector3(1657f, 348f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(4f, 1234f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = DGLKIKGGEJK(IMOBLFMHKOD + new Vector3(280f, 103f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = ONKGCMEBLHD(IMOBLFMHKOD + new Vector3(842f, 525f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = EFHOICCJIED(IMOBLFMHKOD + new Vector3(1516f, 523f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = DGLKIKGGEJK(IMOBLFMHKOD + new Vector3(1180f, 815f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = MDJDEANKCLF(IMOBLFMHKOD + new Vector3(422f, 1082f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = CAKKMPPKHKF(IMOBLFMHKOD + new Vector3(1931f, 209f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (NDOBPHHAKPI((Opt)7, Opt.T, Opt.T, Opt.N, Opt.T, Opt.T, (Opt)4, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (CMHCHDEFLGK((Opt)3, Opt.T, Opt.T, Opt.N, Opt.T, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (EMFDIOOMAPI(Opt.T, Opt.T, Opt.N, Opt.N, Opt.N, Opt.N, (Opt)6, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (JNNCGDEAHJL(Opt.T, Opt.N, Opt.N, Opt.T, (Opt)4, Opt.T, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (OIKFIMJMCMH(Opt.N, Opt.N, (Opt)3, Opt.T, Opt.T, Opt.T, Opt.T, Opt.N) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1657f), MDIJNOHDOFK.R.Length)];
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.N, (Opt)6, Opt.T) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 755f), MDIJNOHDOFK.L.Length)];
		}
		else if (JNNCGDEAHJL((Opt)8, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 898f), MDIJNOHDOFK.U.Length)];
		}
		else if (NKHKILIGJOP(Opt.T, Opt.N, Opt.N, Opt.N, (Opt)8, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1084f), MDIJNOHDOFK.D.Length)];
		}
		else if (NDOBPHHAKPI(Opt.N, Opt.T, Opt.T, (Opt)4, Opt.N, Opt.T, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (HAKLBBOELFE(Opt.N, Opt.T, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (CMHCHDEFLGK(Opt.N, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N, Opt.N, (Opt)6))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (CMHCHDEFLGK(Opt.T, Opt.N, Opt.T, Opt.N, Opt.N, (Opt)5, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.IAMBLEDHGDM().floorUpperTilemap);
	}

	private static bool MDJDEANKCLF(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.Door | SpecificType.Bar | SpecificType.StairsDown))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.KIMMMFKFCEK()))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return true;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)6)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 0)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static void NJADPGDADGL(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		OOPLMEGKNPM(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			OOPLMEGKNPM(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private void NEEEJJNMPOF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void FLDOAGCBIFN(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		JMBCGBBDPKH(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			OOPLMEGKNPM(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private static bool BPLHIFAAEAH(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.PlayerBed | SpecificType.StairsDown))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.KIMMMFKFCEK(Season.Summer)))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 1;
			return true;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)8)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 1)
			{
				return false;
			}
			return true;
		}
		return true;
	}

	public void GHGFJOALEGA()
	{
	}

	private void OKHLEMPJONN()
	{
		GGFJGHHHEJC = this;
		CDPEKMENJKH();
	}

	private static void IMEEFODHKGD(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps()))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.GetTilemaps().floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.GetTilemaps().floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(0f, 0.5f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(0f, -0.5f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(0.5f, 0f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(-0.5f, 0f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(0.5f, 0.5f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(0.5f, -0.5f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(-0.5f, -0.5f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (NKHKILIGJOP(Opt.F, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N, Opt.F, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (NKHKILIGJOP(Opt.F, Opt.N, Opt.F, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.T, Opt.N, Opt.F, Opt.N, Opt.F, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.N, Opt.F, Opt.N, Opt.F, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.N, Opt.F, Opt.N, Opt.T, Opt.T, Opt.T, Opt.T) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 2f), MDIJNOHDOFK.R.Length)];
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.N, Opt.F, Opt.N) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 2f), MDIJNOHDOFK.L.Length)];
		}
		else if (NKHKILIGJOP(Opt.F, Opt.N, Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.N) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 2f), MDIJNOHDOFK.U.Length)];
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.T, Opt.N, Opt.F, Opt.N, Opt.T, Opt.T) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 2f), MDIJNOHDOFK.D.Length)];
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.T, Opt.F, Opt.T, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.F, Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.F))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, Opt.F, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.GetTilemaps().floorUpperTilemap);
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool CPKGNMILEFP(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!KCKCIMHNGNH(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!KCKCIMHNGNH(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return true;
		}
		if (!AEBCPMPMCCG(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return false;
		}
		if (!EDEMCOCLKGC(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return true;
		}
		if (!FKLBDOCNJDH(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!FKLBDOCNJDH(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!AFGNKFCDFBN(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return true;
		}
		if (!FKLBDOCNJDH(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return false;
	}

	private void HPMFOHOMLDO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool HLBHBAPMCFG(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.N && !NCIHJIJKCHB)
			{
				return false;
			}
			if (PCCNAKNPKAG == (Opt)6 && NCIHJIJKCHB)
			{
				return false;
			}
		}
		return true;
	}

	private static void HKIHHIDGIGH(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.GetDecoTile(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.FGKDPLDANOA(Season.Summer)))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.KIMMMFKFCEK(Season.Summer).floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.IAMBLEDHGDM(Season.Summer).floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = BPLHIFAAEAH(IMOBLFMHKOD + new Vector3(942f, 677f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = AIONAAAIEJD(IMOBLFMHKOD + new Vector3(1420f, 1142f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = NEALDGMNIIO(IMOBLFMHKOD + new Vector3(602f, 1849f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = DGLKIKGGEJK(IMOBLFMHKOD + new Vector3(79f, 1766f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = MEEICCLKING(IMOBLFMHKOD + new Vector3(1779f, 1172f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = MEEICCLKING(IMOBLFMHKOD + new Vector3(449f, 1972f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = PIALDAKAJIP(IMOBLFMHKOD + new Vector3(304f, 1737f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = CJENPANPKBO(IMOBLFMHKOD + new Vector3(510f, 1877f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (NKHKILIGJOP((Opt)6, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T, (Opt)3, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (PEJKPGNIOKJ(Opt.T, Opt.T, (Opt)8, Opt.T, Opt.T, Opt.T, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (MIDPJDMEAFH(Opt.N, Opt.T, Opt.N, Opt.T, (Opt)4, Opt.T, (Opt)4, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (IGILIPFFKNE(Opt.T, Opt.T, (Opt)7, Opt.T, (Opt)5, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (MIDPJDMEAFH(Opt.T, Opt.N, (Opt)5, Opt.N, Opt.T, Opt.T, Opt.T, Opt.T) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1213f), MDIJNOHDOFK.R.Length)];
		}
		else if (CPKGNMILEFP(Opt.T, Opt.N, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T, Opt.N) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1757f), MDIJNOHDOFK.L.Length)];
		}
		else if (HAKLBBOELFE((Opt)6, Opt.N, Opt.T, Opt.T, Opt.N, Opt.N, Opt.N, Opt.T) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1031f), MDIJNOHDOFK.U.Length)];
		}
		else if (CPKGNMILEFP(Opt.T, Opt.T, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 616f), MDIJNOHDOFK.D.Length)];
		}
		else if (NKHKILIGJOP(Opt.T, Opt.N, Opt.N, (Opt)6, Opt.N, Opt.T, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (CICICLDDCNN(Opt.N, Opt.F, Opt.N, Opt.T, Opt.T, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (IGILIPFFKNE(Opt.T, Opt.N, Opt.N, Opt.N, Opt.N, Opt.T, Opt.T, Opt.F))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (NDOBPHHAKPI(Opt.T, Opt.T, Opt.T, Opt.T, Opt.T, (Opt)7, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.OEMIKEDPIKP().floorUpperTilemap);
	}

	private static bool EDEMCOCLKGC(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.N && !NCIHJIJKCHB)
			{
				return true;
			}
			if (PCCNAKNPKAG == Opt.F && NCIHJIJKCHB)
			{
				return false;
			}
		}
		return true;
	}

	private void HBEBKMNGLBJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool EHFDELBEPFI(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == ~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.PlayerBed))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.KIMMMFKFCEK()))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return true;
		}
		if (KJIGECBPBOD.materialType == MaterialType.Ground)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 1)
			{
				return true;
			}
			return false;
		}
		return true;
	}

	private static bool CJENPANPKBO(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.Bar))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.OEMIKEDPIKP()))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 0)
			{
				return false;
			}
			return true;
		}
		return true;
	}

	private void FGFGCADFFBC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void UpdateFloorLimits(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		IMEEFODHKGD(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			IMEEFODHKGD(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	public void PKPGJJGOLGE()
	{
	}

	public static void JKCODCCPBHE(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		JMBCGBBDPKH(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			BKIBEBALMMH(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	public static void ADGDAPKMMJG(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		LFIEHNDIIJA(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			MFAEIGNLOMN(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private void ALEAOANPHIO()
	{
		GGFJGHHHEJC = this;
		GHGFJOALEGA();
	}

	private static bool NDOBPHHAKPI(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!EDEMCOCLKGC(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!HLBHBAPMCFG(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!HLBHBAPMCFG(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!AEBCPMPMCCG(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return false;
		}
		if (!NDOIFBGIKHN(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!KCKCIMHNGNH(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!MKNHHIJHBDH(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return true;
		}
		if (!KCKCIMHNGNH(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return false;
	}

	private static bool NEALDGMNIIO(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == ~(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.StairsDown))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps()))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 1;
			return false;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)8)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 1)
			{
				return false;
			}
			return false;
		}
		return true;
	}

	private static void CKLELFFPFNH(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.BNKGPJPMFCI(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.BNMLDAPCNKF(Season.Summer)))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.KIMMMFKFCEK().floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.OEMIKEDPIKP().floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = IKKAOIMNCIK(IMOBLFMHKOD + new Vector3(261f, 1188f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = AIJCNONIADH(IMOBLFMHKOD + new Vector3(784f, 138f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = MEEICCLKING(IMOBLFMHKOD + new Vector3(1366f, 943f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = IKKAOIMNCIK(IMOBLFMHKOD + new Vector3(1352f, 995f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = NEALDGMNIIO(IMOBLFMHKOD + new Vector3(1391f, 154f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = DCOFGNGNJAD(IMOBLFMHKOD + new Vector3(1871f, 1317f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = BPLHIFAAEAH(IMOBLFMHKOD + new Vector3(452f, 731f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = JEBFEAJENDA(IMOBLFMHKOD + new Vector3(476f, 1607f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (CICICLDDCNN(Opt.T, Opt.N, Opt.T, Opt.T, Opt.N, Opt.N, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (PEJKPGNIOKJ((Opt)8, Opt.T, (Opt)4, Opt.T, Opt.T, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (PEJKPGNIOKJ(Opt.N, Opt.T, Opt.N, Opt.T, (Opt)6, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (HNGLICIJJIK(Opt.N, Opt.N, (Opt)3, Opt.N, Opt.N, Opt.T, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (CMHCHDEFLGK(Opt.T, Opt.T, (Opt)8, Opt.T, Opt.N, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1291f), MDIJNOHDOFK.R.Length)];
		}
		else if (CMHCHDEFLGK(Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, Opt.T, (Opt)4, Opt.N) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1482f), MDIJNOHDOFK.L.Length)];
		}
		else if (HNGLICIJJIK((Opt)3, Opt.T, Opt.T, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1288f), MDIJNOHDOFK.U.Length)];
		}
		else if (JNNCGDEAHJL(Opt.T, Opt.N, Opt.T, Opt.N, (Opt)7, Opt.T, Opt.T, Opt.N) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1254f), MDIJNOHDOFK.D.Length)];
		}
		else if (CPKGNMILEFP(Opt.N, Opt.N, Opt.T, Opt.F, Opt.T, Opt.N, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (DDLBGFMBMMG(Opt.N, (Opt)8, Opt.N, Opt.N, Opt.N, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (DDLBGFMBMMG(Opt.N, Opt.T, Opt.N, Opt.T, Opt.T, Opt.N, Opt.T, (Opt)8))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (HNGLICIJJIK(Opt.T, Opt.T, Opt.N, Opt.T, Opt.T, (Opt)6, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.IAMBLEDHGDM().floorUpperTilemap);
	}

	private static void BKIBEBALMMH(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.BNKGPJPMFCI(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(Season.Summer)))
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.BNMLDAPCNKF(Season.Summer).floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.FGKDPLDANOA().floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = MEEICCLKING(IMOBLFMHKOD + new Vector3(1168f, 879f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = GDNFDFHNMKF(IMOBLFMHKOD + new Vector3(390f, 1988f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(457f, 82f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = MDJDEANKCLF(IMOBLFMHKOD + new Vector3(984f, 1428f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = DCOFGNGNJAD(IMOBLFMHKOD + new Vector3(302f, 489f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = JEBFEAJENDA(IMOBLFMHKOD + new Vector3(984f, 1334f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = GDNFDFHNMKF(IMOBLFMHKOD + new Vector3(1628f, 374f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = EHFDELBEPFI(IMOBLFMHKOD + new Vector3(145f, 2f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (MIDPJDMEAFH(Opt.F, Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, (Opt)3, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (OIKFIMJMCMH((Opt)4, Opt.T, (Opt)4, Opt.T, Opt.N, Opt.N, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (EMFDIOOMAPI(Opt.T, Opt.T, Opt.T, Opt.N, (Opt)4, Opt.T, (Opt)5, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (HNGLICIJJIK(Opt.N, Opt.N, (Opt)6, Opt.N, Opt.N, Opt.N, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (HNGLICIJJIK(Opt.N, Opt.N, (Opt)7, Opt.T, Opt.T, Opt.N, Opt.T, Opt.N) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 806f), MDIJNOHDOFK.R.Length)];
		}
		else if (EMFDIOOMAPI(Opt.N, Opt.T, Opt.N, Opt.N, Opt.N, Opt.T, Opt.N, Opt.N) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1466f), MDIJNOHDOFK.L.Length)];
		}
		else if (PEJKPGNIOKJ((Opt)8, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, Opt.N, Opt.N) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1624f), MDIJNOHDOFK.U.Length)];
		}
		else if (PEJKPGNIOKJ(Opt.T, Opt.T, Opt.T, Opt.T, (Opt)3, Opt.T, Opt.N, Opt.N) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1365f), MDIJNOHDOFK.D.Length)];
		}
		else if (CICICLDDCNN(Opt.T, Opt.N, Opt.T, (Opt)7, Opt.N, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (JNNCGDEAHJL(Opt.T, (Opt)3, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (HGHJCPJMOGA(Opt.N, Opt.N, Opt.N, Opt.T, Opt.N, Opt.N, Opt.T, Opt.F))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (NKHKILIGJOP(Opt.T, Opt.N, Opt.N, Opt.T, Opt.T, (Opt)4, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.FGKDPLDANOA(Season.Summer).floorUpperTilemap);
	}

	private static bool PBIILCKCIJN(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.StairsDown))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.KIMMMFKFCEK()))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 1;
			return true;
		}
		if (KJIGECBPBOD.materialType == MaterialType.Stone)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 1)
			{
				return true;
			}
			return true;
		}
		return false;
	}

	public static void AHNDBLLGFJA(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DIPECGOFAKH(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			NKOIMDFMMPB(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	private static bool IGILIPFFKNE(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!KCKCIMHNGNH(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return true;
		}
		if (!AEBCPMPMCCG(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return true;
		}
		if (!KCKCIMHNGNH(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!MKNHHIJHBDH(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return false;
		}
		if (!AEBCPMPMCCG(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!AFGNKFCDFBN(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!DCOCAAKIDNI(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return false;
		}
		if (!NDOIFBGIKHN(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return false;
	}

	public static void KEMLDPFJOKB(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		NCHGLHLJCIJ(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
		{
			HMFKKEBGEGB(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private static bool MEEICCLKING(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == ~(SpecificType.Door | SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.StairsDown))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.OEMIKEDPIKP(Season.Summer)))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)7)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 1)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private void GHDBHNMOBMN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool JNNCGDEAHJL(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!MKNHHIJHBDH(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return true;
		}
		if (!FKLBDOCNJDH(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!NNCFEBHLIBO(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!NNCFEBHLIBO(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return false;
		}
		if (!KCKCIMHNGNH(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!DCOCAAKIDNI(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return true;
		}
		if (!AFGNKFCDFBN(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return false;
		}
		if (!AFGNKFCDFBN(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return true;
		}
		return false;
	}

	private static bool PEJKPGNIOKJ(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!KCKCIMHNGNH(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!NNCFEBHLIBO(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!KCKCIMHNGNH(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return false;
		}
		if (!NNCFEBHLIBO(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return false;
		}
		if (!KCKCIMHNGNH(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return true;
		}
		if (!DCOCAAKIDNI(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!AFGNKFCDFBN(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return true;
		}
		if (!FKLBDOCNJDH(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return true;
		}
		return true;
	}

	private static bool AEBCPMPMCCG(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.T && !NCIHJIJKCHB)
			{
				return true;
			}
			if (PCCNAKNPKAG == (Opt)8 && NCIHJIJKCHB)
			{
				return false;
			}
		}
		return true;
	}

	public void CDPEKMENJKH()
	{
	}

	public static void EDEHMHNPFGD(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		DIPECGOFAKH(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
		{
			HMFKKEBGEGB(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private static bool MKNHHIJHBDH(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.N && !NCIHJIJKCHB)
			{
				return true;
			}
			if (PCCNAKNPKAG == (Opt)3 && NCIHJIJKCHB)
			{
				return false;
			}
		}
		return false;
	}

	private static bool AFGNKFCDFBN(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.T && !NCIHJIJKCHB)
			{
				return false;
			}
			if (PCCNAKNPKAG == Opt.F && NCIHJIJKCHB)
			{
				return true;
			}
		}
		return true;
	}

	public static void MHEBMBNLCBD(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		LFIEHNDIIJA(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			IMEEFODHKGD(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private void PMLBFEFMNPF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HMOMBAFIJAI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool DDLBGFMBMMG(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!NNCFEBHLIBO(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return true;
		}
		if (!NDOIFBGIKHN(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!KCKCIMHNGNH(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!AEBCPMPMCCG(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return true;
		}
		if (!MKNHHIJHBDH(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return false;
		}
		if (!DCOCAAKIDNI(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!AEBCPMPMCCG(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return true;
		}
		if (!HLBHBAPMCFG(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return false;
		}
		return true;
	}

	private static void NCHGLHLJCIJ(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.BNKGPJPMFCI(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps()))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.IAMBLEDHGDM().floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.KIMMMFKFCEK(Season.Summer).floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = IKKAOIMNCIK(IMOBLFMHKOD + new Vector3(866f, 1121f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = GDNFDFHNMKF(IMOBLFMHKOD + new Vector3(276f, 1797f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = AIONAAAIEJD(IMOBLFMHKOD + new Vector3(461f, 1619f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = PIALDAKAJIP(IMOBLFMHKOD + new Vector3(607f, 1811f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = AIONAAAIEJD(IMOBLFMHKOD + new Vector3(48f, 202f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = DGLKIKGGEJK(IMOBLFMHKOD + new Vector3(642f, 53f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = CJENPANPKBO(IMOBLFMHKOD + new Vector3(759f, 1631f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = ONKGCMEBLHD(IMOBLFMHKOD + new Vector3(338f, 1427f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (CMHCHDEFLGK((Opt)4, Opt.T, Opt.T, Opt.N, Opt.N, Opt.N, Opt.F, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (OIKFIMJMCMH((Opt)6, Opt.T, (Opt)5, Opt.N, Opt.T, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (JNNCGDEAHJL(Opt.N, Opt.N, Opt.T, Opt.T, (Opt)6, Opt.N, (Opt)8, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (EMFDIOOMAPI(Opt.T, Opt.T, (Opt)4, Opt.T, (Opt)3, Opt.T, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (CPKGNMILEFP(Opt.T, Opt.N, (Opt)7, Opt.T, Opt.T, Opt.T, Opt.T, Opt.N) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1428f), MDIJNOHDOFK.R.Length)];
		}
		else if (CICICLDDCNN(Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, Opt.N, (Opt)7, Opt.N) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1259f), MDIJNOHDOFK.L.Length)];
		}
		else if (IGILIPFFKNE((Opt)8, Opt.N, Opt.T, Opt.T, Opt.N, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 278f), MDIJNOHDOFK.U.Length)];
		}
		else if (OIKFIMJMCMH(Opt.T, Opt.N, Opt.T, Opt.N, (Opt)7, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1458f), MDIJNOHDOFK.D.Length)];
		}
		else if (NKHKILIGJOP(Opt.T, Opt.T, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (MIDPJDMEAFH(Opt.T, (Opt)3, Opt.N, Opt.T, Opt.T, Opt.N, Opt.N, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (CICICLDDCNN(Opt.N, Opt.T, Opt.N, Opt.N, Opt.N, Opt.N, Opt.T, Opt.F))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (IGILIPFFKNE(Opt.N, Opt.T, Opt.T, Opt.T, Opt.T, (Opt)4, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.BNMLDAPCNKF().floorUpperTilemap);
	}

	public static void MBBOOFOKHLI(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		OOPLMEGKNPM(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			HKIHHIDGIGH(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	private void AGELAMLCINB()
	{
		GGFJGHHHEJC = this;
		BAALODAJNOP();
	}

	public void CCMMGLMGLPA()
	{
	}

	private static void OOPLMEGKNPM(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		MIMAGPFCMKH = EditorActionsDBAccessor.EMDLPJBBPDM(WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK));
		if ((Object)(object)MIMAGPFCMKH == (Object)null || !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.EMHLLEFBBCO()))
		{
			GameTileMaps.PPPFKJPOBOH(IMOBLFMHKOD, null, PBLLKEKGLPK.IAMBLEDHGDM(Season.Summer).floorUpperTilemap);
			return;
		}
		MDIJNOHDOFK = MIMAGPFCMKH.floorLimit;
		if ((Object)(object)MDIJNOHDOFK == (Object)null)
		{
			GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, null, PBLLKEKGLPK.KIMMMFKFCEK(Season.Summer).floorUpperTilemap);
			return;
		}
		OGJOGEEOPEN = BPLHIFAAEAH(IMOBLFMHKOD + new Vector3(406f, 1411f), MIMAGPFCMKH, PBLLKEKGLPK);
		PJJCGBPLHIO = MEEICCLKING(IMOBLFMHKOD + new Vector3(319f, 564f), MIMAGPFCMKH, PBLLKEKGLPK);
		NNFAMJBFKMF = OMIOELBNLIO(IMOBLFMHKOD + new Vector3(1144f, 1086f), MIMAGPFCMKH, PBLLKEKGLPK);
		OHKACKDCLHP = GDNFDFHNMKF(IMOBLFMHKOD + new Vector3(1937f, 1224f), MIMAGPFCMKH, PBLLKEKGLPK);
		IGICEDDLEAF = AIJCNONIADH(IMOBLFMHKOD + new Vector3(1516f, 57f), MIMAGPFCMKH, PBLLKEKGLPK);
		EGLGALMJBMI = JEBFEAJENDA(IMOBLFMHKOD + new Vector3(1482f, 635f), MIMAGPFCMKH, PBLLKEKGLPK);
		MDJJNIFMFCI = MEEICCLKING(IMOBLFMHKOD + new Vector3(722f, 1105f), MIMAGPFCMKH, PBLLKEKGLPK);
		NLLCGPJEFGN = EHFDELBEPFI(IMOBLFMHKOD + new Vector3(216f, 1117f), MIMAGPFCMKH, PBLLKEKGLPK);
		DPANAKMICJH = null;
		if (NKHKILIGJOP(Opt.T, Opt.N, Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.LU;
		}
		else if (NDOBPHHAKPI((Opt)7, Opt.T, Opt.T, Opt.N, Opt.N, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.RU;
		}
		else if (HAKLBBOELFE(Opt.T, Opt.T, Opt.T, Opt.N, Opt.N, Opt.T, (Opt)8, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.LD;
		}
		else if (NDOBPHHAKPI(Opt.T, Opt.T, (Opt)8, Opt.N, (Opt)6, Opt.N, Opt.T, Opt.N))
		{
			DPANAKMICJH = MDIJNOHDOFK.RD;
		}
		else if (DDLBGFMBMMG(Opt.T, Opt.N, (Opt)4, Opt.N, Opt.N, Opt.N, Opt.N, Opt.N) && MDIJNOHDOFK.R.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.R[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 59f), MDIJNOHDOFK.R.Length)];
		}
		else if (HAKLBBOELFE(Opt.N, Opt.T, Opt.N, Opt.N, Opt.N, Opt.T, (Opt)4, Opt.T) && MDIJNOHDOFK.L.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.L[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.y * 1735f), MDIJNOHDOFK.L.Length)];
		}
		else if (CMHCHDEFLGK((Opt)5, Opt.N, Opt.T, Opt.T, Opt.T, Opt.N, Opt.T, Opt.T) && MDIJNOHDOFK.U.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.U[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1415f), MDIJNOHDOFK.U.Length)];
		}
		else if (JNNCGDEAHJL(Opt.N, Opt.N, Opt.N, Opt.N, (Opt)4, Opt.T, Opt.N, Opt.T) && MDIJNOHDOFK.D.Length != 0)
		{
			DPANAKMICJH = MDIJNOHDOFK.D[Utils.NMLNAGFLNMC((int)(IMOBLFMHKOD.x * 1610f), MDIJNOHDOFK.D.Length)];
		}
		else if (HAKLBBOELFE(Opt.T, Opt.N, Opt.T, (Opt)5, Opt.T, Opt.N, Opt.N, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRD;
		}
		else if (HNGLICIJJIK(Opt.N, (Opt)5, Opt.N, Opt.N, Opt.T, Opt.N, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PRU;
		}
		else if (HNGLICIJJIK(Opt.T, Opt.N, Opt.T, Opt.T, Opt.N, Opt.T, Opt.N, (Opt)5))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLU;
		}
		else if (IGILIPFFKNE(Opt.T, Opt.T, Opt.N, Opt.T, Opt.N, Opt.T, Opt.T, Opt.T))
		{
			DPANAKMICJH = MDIJNOHDOFK.PLD;
		}
		else
		{
			DPANAKMICJH = null;
		}
		GameTileMaps.SetTileAtPosition(IMOBLFMHKOD, DPANAKMICJH, PBLLKEKGLPK.GetTilemaps(Season.Summer).floorUpperTilemap);
	}

	private static bool DCOFGNGNJAD(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.Door | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.StairsDown))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.KIMMMFKFCEK(Season.Summer)))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)8)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 1)
			{
				return true;
			}
			return true;
		}
		return false;
	}

	private static bool DGLKIKGGEJK(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall))
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps(Season.Summer)))
		{
			return true;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == MaterialType.Stone)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 1)
			{
				return false;
			}
			return false;
		}
		return false;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void HPPNKIMKDJB(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		MFAEIGNLOMN(IMOBLFMHKOD, PBLLKEKGLPK);
		for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			DIPECGOFAKH(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position, PBLLKEKGLPK);
		}
	}

	public void KHOLMLLDFJP()
	{
	}

	private void MFIEPGBABAM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool MIDPJDMEAFH(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!AEBCPMPMCCG(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!KCKCIMHNGNH(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!EDEMCOCLKGC(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return true;
		}
		if (!NNCFEBHLIBO(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return true;
		}
		if (!NNCFEBHLIBO(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return false;
		}
		if (!NDOIFBGIKHN(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!KCKCIMHNGNH(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return true;
		}
		if (!EDEMCOCLKGC(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return true;
		}
		return true;
	}

	private void BFJOEMCBJJO()
	{
		GGFJGHHHEJC = this;
		GHNJFMJJGDP();
	}

	private static bool EMFDIOOMAPI(Opt KKHOIFKIGPE, Opt IFLLBCNNIMO, Opt GDIGPFGIGPL, Opt OOIDGPJAEPC, Opt MMPKLNMBOMO, Opt BGJFKBFPEML, Opt IFHNAJLPFDF, Opt BMCILHHFDKG)
	{
		if (!AEBCPMPMCCG(KKHOIFKIGPE, OGJOGEEOPEN))
		{
			return false;
		}
		if (!EDEMCOCLKGC(IFLLBCNNIMO, IGICEDDLEAF))
		{
			return false;
		}
		if (!MKNHHIJHBDH(GDIGPFGIGPL, NNFAMJBFKMF))
		{
			return false;
		}
		if (!NDOIFBGIKHN(OOIDGPJAEPC, EGLGALMJBMI))
		{
			return true;
		}
		if (!DCOCAAKIDNI(MMPKLNMBOMO, PJJCGBPLHIO))
		{
			return false;
		}
		if (!AFGNKFCDFBN(BGJFKBFPEML, NLLCGPJEFGN))
		{
			return false;
		}
		if (!DCOCAAKIDNI(IFHNAJLPFDF, OHKACKDCLHP))
		{
			return false;
		}
		if (!AEBCPMPMCCG(BMCILHHFDKG, MDJJNIFMFCI))
		{
			return true;
		}
		return false;
	}

	public void EMDFCOLKMNI()
	{
	}

	private static bool DCOCAAKIDNI(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.T && !NCIHJIJKCHB)
			{
				return true;
			}
			if (PCCNAKNPKAG == (Opt)7 && NCIHJIJKCHB)
			{
				return true;
			}
		}
		return true;
	}

	private static bool IKKAOIMNCIK(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.Bar | SpecificType.NextToWall))
		{
			return true;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer)))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.None)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 1;
			return false;
		}
		if (KJIGECBPBOD.materialType == (MaterialType)7)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return false;
			}
			if (FPGOGONNGDG > 1)
			{
				return false;
			}
			return false;
		}
		return true;
	}

	private void AEDIIIAECIC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void GFIOOMOHADL()
	{
	}

	private void KDHLJKMKFMG()
	{
		GGFJGHHHEJC = this;
		DDPJCNNFIAA();
	}

	private static bool OMIOELBNLIO(Vector3 IMOBLFMHKOD, DecorationTile KJIGECBPBOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KELFJIPHBFP(IMOBLFMHKOD) == SpecificType.StairsDown)
		{
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD, PBLLKEKGLPK.GetTilemaps()))
		{
			return false;
		}
		FPGOGONNGDG = WorldGrid.EIHIPOEOBCO(IMOBLFMHKOD, PBLLKEKGLPK);
		if (KJIGECBPBOD.materialType == MaterialType.Wood)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			_ = FPGOGONNGDG;
			_ = 0;
			return false;
		}
		if (KJIGECBPBOD.materialType == MaterialType.Stone)
		{
			if (FPGOGONNGDG == KJIGECBPBOD.id)
			{
				return true;
			}
			if (FPGOGONNGDG > 0)
			{
				return false;
			}
			return true;
		}
		return true;
	}

	public void JKIMCDDBFKC()
	{
	}

	private static bool FKLBDOCNJDH(Opt PCCNAKNPKAG, bool NCIHJIJKCHB)
	{
		if (PCCNAKNPKAG != 0)
		{
			if (PCCNAKNPKAG == Opt.T && !NCIHJIJKCHB)
			{
				return false;
			}
			if (PCCNAKNPKAG == Opt.F && NCIHJIJKCHB)
			{
				return false;
			}
		}
		return true;
	}
}
