using System.Collections.Generic;
using UnityEngine;

public static class EditorGrid
{
	private static EditorTile BNKKFKKAJLO;

	private static EditorTile EGKPNEOKDBL;

	private static List<Vector2> HDENCBCBGCM = new List<Vector2>();

	private static float KHEBKHFHMDB;

	private static Vector3 ECJLMIPAFGP = default(Vector3);

	private static EditorTile FKJFCKCFNCE;

	private static Dictionary<Vector3, EditorTile> PDBLOGMCFAP;

	private static EditorTile MMMHAJHLPBF;

	private static Dictionary<Vector3, EditorTile> FOIJLPCOOLJ = new Dictionary<Vector3, EditorTile>();

	private static List<Vector2> GDFIONOLFIB = new List<Vector2>();

	private static Vector3[] EMBAIAOPIAD = (Vector3[])(object)new Vector3[8]
	{
		new Vector3(-1f, 1f),
		new Vector3(0f, 1f),
		new Vector3(1f, 1f),
		new Vector3(1f, 0f),
		new Vector3(1f, -1f),
		new Vector3(0f, -1f),
		new Vector3(-1f, -1f),
		new Vector3(-1f, 0f)
	};

	private static int ACJBHDMECIG;

	public static EditorAction AJGOLEOFPOL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out EGKPNEOKDBL))
		{
			return EGKPNEOKDBL.editorAction;
		}
		return EditorAction.None;
	}

	private static bool OHOOCPGBGEJ(Vector3 IMOBLFMHKOD, List<Vector2> GJMIPIKKAAI, bool DPJCDBLIDFO = false)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		if (ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM == TavernFloor.FirstFloor)
		{
			if (Utils.EENFKOKHBLA(Vector2.op_Implicit(IMOBLFMHKOD)) == Utils.EENFKOKHBLA(Vector2.op_Implicit(((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road)).transform.position)))
			{
				return false;
			}
		}
		else if (Utils.EENFKOKHBLA(Vector2.op_Implicit(IMOBLFMHKOD)) == Utils.EENFKOKHBLA(Vector2.op_Implicit(((Component)Utils.IMOJLANDCJB(ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM)).transform.position)))
		{
			return false;
		}
		if (GDFIONOLFIB.Contains(Vector2.op_Implicit(IMOBLFMHKOD)))
		{
			return true;
		}
		if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD))
		{
			GDFIONOLFIB.Add(Vector2.op_Implicit(IMOBLFMHKOD));
			GDFIONOLFIB.Add(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0f, 0.5f)));
			GDFIONOLFIB.Add(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0.5f, 0f)));
			GDFIONOLFIB.Add(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0.5f, 0.5f)));
			GJMIPIKKAAI.Add(Vector2.op_Implicit(IMOBLFMHKOD));
			bool flag = true;
			flag &= OHOOCPGBGEJ(IMOBLFMHKOD + Vector3.right, GJMIPIKKAAI);
			flag &= OHOOCPGBGEJ(IMOBLFMHKOD + Vector3.left, GJMIPIKKAAI);
			flag &= OHOOCPGBGEJ(IMOBLFMHKOD + Vector3.up, GJMIPIKKAAI);
			flag &= OHOOCPGBGEJ(IMOBLFMHKOD + Vector3.down, GJMIPIKKAAI);
			if (DPJCDBLIDFO && flag)
			{
				for (int i = 0; i < GJMIPIKKAAI.Count; i++)
				{
					KICMMMBCPNF(Vector2.op_Implicit(GJMIPIKKAAI[i]), EditorAction.RemoveFloor);
					KICMMMBCPNF(Vector2.op_Implicit(GJMIPIKKAAI[i] + new Vector2(0f, 0.5f)), EditorAction.RemoveFloor);
					KICMMMBCPNF(Vector2.op_Implicit(GJMIPIKKAAI[i] + new Vector2(0.5f, 0f)), EditorAction.RemoveFloor);
					KICMMMBCPNF(Vector2.op_Implicit(GJMIPIKKAAI[i] + new Vector2(0.5f, 0.5f)), EditorAction.RemoveFloor);
					MJLDKNNKGOO(Vector2.op_Implicit(GJMIPIKKAAI[i]), BPOCENNHJJC: false);
					MJLDKNNKGOO(Vector2.op_Implicit(GJMIPIKKAAI[i] + new Vector2(0f, 0.5f)), BPOCENNHJJC: false);
					MJLDKNNKGOO(Vector2.op_Implicit(GJMIPIKKAAI[i] + new Vector2(0.5f, 0f)), BPOCENNHJJC: false);
					MJLDKNNKGOO(Vector2.op_Implicit(GJMIPIKKAAI[i] + new Vector2(0.5f, 0.5f)), BPOCENNHJJC: false);
				}
			}
			return flag;
		}
		return true;
	}

	private static void PEBFAFPIOGL(Vector3 FCMMFDIGFMB)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (float num = 0.5f; num <= 2f; num += 0.5f)
		{
			KICMMMBCPNF(FCMMFDIGFMB + Vector3.up * num, EditorAction.ZoneDisponible);
		}
	}

	public static void HOLEHONPOPK()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		FOIJLPCOOLJ.Clear();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.AddFloor)
			{
				BNKKFKKAJLO = default(EditorTile);
				BNKKFKKAJLO.editorAction = editorTile.Value.editorAction;
				BNKKFKKAJLO.isValid = editorTile.Value.isValid;
				FOIJLPCOOLJ.Add(editorTile.Key, BNKKFKKAJLO);
			}
		}
		EditorTileMaps.ResetEditorTiles();
		foreach (KeyValuePair<Vector3, EditorTile> item in FOIJLPCOOLJ)
		{
			KILADDNLCOM(item.Key, item.Value);
		}
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.Tavern).GetTilemaps(SeasonManager.EECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) == GroundType.Floor)
			{
				EPPNABFHBNJ(iMOBLFMHKOD);
			}
		}
		foreach (KeyValuePair<Vector3, EditorTile> item2 in FOIJLPCOOLJ)
		{
			EPPNABFHBNJ(item2.Key);
		}
	}

	public static void KICMMMBCPNF(Vector3 IMOBLFMHKOD, EditorAction CHFHMMNELGP, DecorationTile BGCOHNIBBMB = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		if (!GCGNCHFNEBJ(IMOBLFMHKOD, out FKJFCKCFNCE))
		{
			FKJFCKCFNCE = default(EditorTile);
		}
		FKJFCKCFNCE.editorAction = CHFHMMNELGP;
		FKJFCKCFNCE.isValid = true;
		FKJFCKCFNCE.reachable = true;
		if (CHFHMMNELGP == EditorAction.AddFloor)
		{
			WorldGrid.IFKKOPKHBHJ(IMOBLFMHKOD, ((Object)(object)BGCOHNIBBMB == (Object)null) ? 10 : BGCOHNIBBMB.id, Utils.BCLCKLKGFCL(IMOBLFMHKOD), Utils.BIKIBFJONAO());
		}
		KILADDNLCOM(IMOBLFMHKOD, FKJFCKCFNCE);
	}

	public static void KILADDNLCOM(Vector3 IMOBLFMHKOD, EditorTile BNKKFKKAJLO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		EditorTileMaps.SetTileAtPosition(BNKKFKKAJLO, IMOBLFMHKOD);
	}

	public static List<Vector2> AFHIGCDKMGH(List<Vector2> CHCFCJHIKPN)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		GDFIONOLFIB.Clear();
		for (int i = 0; i < CHCFCJHIKPN.Count; i++)
		{
			if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(CHCFCJHIKPN[i])) && WorldGrid.EACFFPAOFLP(Vector2.op_Implicit(CHCFCJHIKPN[i])))
			{
				KICMMMBCPNF(Vector2.op_Implicit(CHCFCJHIKPN[i]), EditorAction.RemoveFloor);
				MJLDKNNKGOO(Vector2.op_Implicit(CHCFCJHIKPN[i]), BPOCENNHJJC: true);
				GDFIONOLFIB.Add(Utils.NKGANMEKDAL(CHCFCJHIKPN[i]));
			}
		}
		List<Vector2> list = new List<Vector2>();
		for (int j = 0; j < CHCFCJHIKPN.Count; j++)
		{
			list.Clear();
			ECJLMIPAFGP = Vector2.op_Implicit(Utils.EENFKOKHBLA(CHCFCJHIKPN[j] + Vector2.right));
			OHOOCPGBGEJ(ECJLMIPAFGP, list, DPJCDBLIDFO: true);
			list.Clear();
			ECJLMIPAFGP = Vector2.op_Implicit(Utils.EENFKOKHBLA(CHCFCJHIKPN[j] + Vector2.left));
			OHOOCPGBGEJ(ECJLMIPAFGP, list, DPJCDBLIDFO: true);
			list.Clear();
			ECJLMIPAFGP = Vector2.op_Implicit(Utils.EENFKOKHBLA(CHCFCJHIKPN[j] + Vector2.up));
			OHOOCPGBGEJ(ECJLMIPAFGP, list, DPJCDBLIDFO: true);
			list.Clear();
			ECJLMIPAFGP = Vector2.op_Implicit(Utils.EENFKOKHBLA(CHCFCJHIKPN[j] + Vector2.down));
			OHOOCPGBGEJ(ECJLMIPAFGP, list, DPJCDBLIDFO: true);
		}
		return GDFIONOLFIB;
	}

	public static void MJLDKNNKGOO(Vector3 IMOBLFMHKOD, bool BPOCENNHJJC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out BNKKFKKAJLO))
		{
			BNKKFKKAJLO.reachable = BPOCENNHJJC;
			KILADDNLCOM(IMOBLFMHKOD, BNKKFKKAJLO);
		}
	}

	public static bool CKJEBHLGDMC(EditorAction CHFHMMNELGP)
	{
		if (CHFHMMNELGP != EditorAction.ChangeDecoFloor && CHFHMMNELGP != EditorAction.ChangeDecoWall)
		{
			return CHFHMMNELGP == EditorAction.ChangeDecoWallTrim;
		}
		return true;
	}

	private static bool MABKKBKEOBO(Vector2 IMOBLFMHKOD, List<Vector2> LOGEEKDNDEP, Vector2 KGIPCGANABJ)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (LOGEEKDNDEP.Contains(IMOBLFMHKOD) || IMOBLFMHKOD == KGIPCGANABJ)
		{
			return false;
		}
		if (GDFIONOLFIB.Contains(IMOBLFMHKOD))
		{
			return true;
		}
		if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(IMOBLFMHKOD)))
		{
			GDFIONOLFIB.Add(IMOBLFMHKOD);
			if (!MABKKBKEOBO(IMOBLFMHKOD + Vector2.right * 0.5f, LOGEEKDNDEP, KGIPCGANABJ))
			{
				return false;
			}
			if (!MABKKBKEOBO(IMOBLFMHKOD + Vector2.left * 0.5f, LOGEEKDNDEP, KGIPCGANABJ))
			{
				return false;
			}
			if (!MABKKBKEOBO(IMOBLFMHKOD + Vector2.up * 0.5f, LOGEEKDNDEP, KGIPCGANABJ))
			{
				return false;
			}
			if (!MABKKBKEOBO(IMOBLFMHKOD + Vector2.down * 0.5f, LOGEEKDNDEP, KGIPCGANABJ))
			{
				return false;
			}
		}
		return true;
	}

	private static bool MFFIMPBLGFO(Vector3 IMOBLFMHKOD, int DFFGLLDDEPN, bool HDDAMOLLMEB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (GIEMLFKIBKM(Vector2.op_Implicit(IMOBLFMHKOD), Vector2.down, DFFGLLDDEPN, HDDAMOLLMEB))
		{
			return GIEMLFKIBKM(Vector2.op_Implicit(IMOBLFMHKOD), Vector2.up, DFFGLLDDEPN, HDDAMOLLMEB);
		}
		return false;
	}

	public static void CEDBHKIPBOB(Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		HDENCBCBGCM.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
	}

	public static void AJACKDNIDPA(Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		HDENCBCBGCM.Remove(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
	}

	private static bool GIEMLFKIBKM(Vector2 IMOBLFMHKOD, Vector2 FCGBJEIIMBC, int DFFGLLDDEPN, bool HDDAMOLLMEB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (!DCFELCEFBOH(IMOBLFMHKOD + FCGBJEIIMBC * 0.5f * 2f, HDDAMOLLMEB) && DCFELCEFBOH(IMOBLFMHKOD + FCGBJEIIMBC * 0.5f * (float)DFFGLLDDEPN, HDDAMOLLMEB))
		{
			return false;
		}
		return true;
	}

	public static void PBONOODLPCC()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		FOIJLPCOOLJ = new Dictionary<Vector3, EditorTile>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.RemoveFloor)
			{
				BNKKFKKAJLO = default(EditorTile);
				BNKKFKKAJLO.editorAction = EditorAction.RemoveFloor;
				BNKKFKKAJLO.isValid = editorTile.Value.isValid;
				BNKKFKKAJLO.reachable = editorTile.Value.reachable;
				FOIJLPCOOLJ.Add(editorTile.Key, BNKKFKKAJLO);
			}
		}
		EditorTileMaps.ResetEditorTiles();
		foreach (KeyValuePair<Vector3, EditorTile> item in FOIJLPCOOLJ)
		{
			KILADDNLCOM(item.Key, item.Value);
		}
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.Tavern).GetTilemaps(SeasonManager.EECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) == GroundType.Floor && AJGOLEOFPOL(iMOBLFMHKOD) != EditorAction.RemoveFloor && FBJHIJNIOGH(iMOBLFMHKOD, EditorAction.RemoveFloor))
			{
				KICMMMBCPNF(iMOBLFMHKOD, EditorAction.RemoveFloorDisponible);
			}
		}
	}

	public static List<Vector2> ELGBOCBINPH(List<Vector2> CHCFCJHIKPN, EditorAction CHFHMMNELGP, DecorationTile BGCOHNIBBMB)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (CHFHMMNELGP == EditorAction.RemoveFloor)
		{
			return AFHIGCDKMGH(CHCFCJHIKPN);
		}
		for (int i = 0; i < CHCFCJHIKPN.Count; i++)
		{
			if (FBJHIJNIOGH(Vector2.op_Implicit(CHCFCJHIKPN[i]), CHFHMMNELGP, BGCOHNIBBMB))
			{
				if (CHFHMMNELGP == EditorAction.ChangeDecoWallTrim)
				{
					KICMMMBCPNF(Vector2.op_Implicit(CHCFCJHIKPN[i]), EditorAction.DecoWallZone);
				}
				else if (GHGECPHNJEB(CHFHMMNELGP) || CKJEBHLGDMC(CHFHMMNELGP))
				{
					KICMMMBCPNF(Vector2.op_Implicit(CHCFCJHIKPN[i]), EditorAction.ZoneDisponible);
				}
				else
				{
					KICMMMBCPNF(Vector2.op_Implicit(CHCFCJHIKPN[i]), CHFHMMNELGP, BGCOHNIBBMB);
				}
			}
		}
		return null;
	}

	public static List<Vector2> DCOKLAGEKPB(List<Vector2> PMHJMCIODBO, int FOFKHCNCIJL, List<Vector2> LOGEEKDNDEP)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		GDFIONOLFIB.Clear();
		for (int i = 0; i < PMHJMCIODBO.Count; i++)
		{
			GDFIONOLFIB.Add(Utils.NKGANMEKDAL(PMHJMCIODBO[i]));
		}
		Vector2 val = PMHJMCIODBO[0] + new Vector2(0f, 0.5f * (float)FOFKHCNCIJL);
		if (MABKKBKEOBO(Utils.NKGANMEKDAL(val), LOGEEKDNDEP, Vector2.op_Implicit(Utils.MKLBDDEIPEC(Vector2.op_Implicit(val)))))
		{
			return GDFIONOLFIB;
		}
		return new List<Vector2>();
	}

	private static void EPPNABFHBNJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		if (FBJHIJNIOGH(IMOBLFMHKOD + Vector3.up, EditorAction.AddFloor))
		{
			KICMMMBCPNF(IMOBLFMHKOD + Vector3.up, EditorAction.AddFloorDisponible);
		}
		if (FBJHIJNIOGH(IMOBLFMHKOD + Vector3.down, EditorAction.AddFloor))
		{
			KICMMMBCPNF(IMOBLFMHKOD + Vector3.down, EditorAction.AddFloorDisponible);
		}
		if (FBJHIJNIOGH(IMOBLFMHKOD + Vector3.right, EditorAction.AddFloor))
		{
			KICMMMBCPNF(IMOBLFMHKOD + Vector3.right, EditorAction.AddFloorDisponible);
		}
		if (FBJHIJNIOGH(IMOBLFMHKOD + Vector3.left, EditorAction.AddFloor))
		{
			KICMMMBCPNF(IMOBLFMHKOD + Vector3.left, EditorAction.AddFloorDisponible);
		}
	}

	public static ZoneType APGNDILBOMJ(EditorAction CHFHMMNELGP)
	{
		ZoneType result = ZoneType.WithoutZone;
		switch (CHFHMMNELGP)
		{
		case EditorAction.DiningZone:
			result = ZoneType.DiningRoom;
			break;
		case EditorAction.CraftingZone:
			result = ZoneType.CraftingRoom;
			break;
		case EditorAction.RoomZone:
			result = ZoneType.RentedRoom;
			break;
		case EditorAction.RemoveZone:
			result = ZoneType.WithoutZone;
			break;
		default:
			Debug.LogError((object)("Area type not found with this editor action: " + CHFHMMNELGP));
			break;
		}
		return result;
	}

	public static bool ENFKMBHBBEM(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out BNKKFKKAJLO))
		{
			return BNKKFKKAJLO.isValid;
		}
		return true;
	}

	public static void PHFLEECBGMA(Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		EditorTileMaps.ResetEditorTiles();
		if (WorldGrid.ALNFLFCLIEP(IMOBLFMHKOD) && (!BuildingTutorialManager.IKNOJDMCFOK || BPBIDHBIBHD(IMOBLFMHKOD)) && WorldGrid.KHJJCAGIJAP(IMOBLFMHKOD, out KHEBKHFHMDB))
		{
			PEBFAFPIOGL(new Vector3(IMOBLFMHKOD.x, KHEBKHFHMDB));
			ICOHDEECKGB(IMOBLFMHKOD.x, KHEBKHFHMDB, -1);
			ICOHDEECKGB(IMOBLFMHKOD.x, KHEBKHFHMDB, 1);
		}
	}

	public static bool FBJHIJNIOGH(Vector3 IMOBLFMHKOD, EditorAction CHFHMMNELGP, DecorationTile BGCOHNIBBMB = null)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernConstructionManager.GGFJGHHHEJC.IsInsideBuildLimits(IMOBLFMHKOD, Utils.FCFHPAPKOEL(IMOBLFMHKOD)))
		{
			return false;
		}
		if (BuildingTutorialManager.IKNOJDMCFOK && !BPBIDHBIBHD(IMOBLFMHKOD))
		{
			return false;
		}
		switch (CHFHMMNELGP)
		{
		case EditorAction.AddFloor:
			if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD))
			{
				return AJGOLEOFPOL(IMOBLFMHKOD) != EditorAction.AddFloor;
			}
			return false;
		case EditorAction.RemoveFloor:
			if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD) && WorldGrid.EACFFPAOFLP(IMOBLFMHKOD))
			{
				return AJGOLEOFPOL(IMOBLFMHKOD) != EditorAction.RemoveFloor;
			}
			return false;
		case EditorAction.DiningZone:
		case EditorAction.CraftingZone:
		case EditorAction.RoomZone:
			return WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD);
		case EditorAction.ChangeDecoFloor:
			return WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD);
		case EditorAction.ChangeDecoWall:
			return false;
		case EditorAction.ChangeDecoWallTrim:
			if (WorldGrid.KHJJCAGIJAP(IMOBLFMHKOD, out KHEBKHFHMDB) && (WorldGrid.KELFJIPHBFP(new Vector3(IMOBLFMHKOD.x, KHEBKHFHMDB)).HasFlag(SpecificType.CellarDoor) || WorldGrid.KELFJIPHBFP(new Vector3(IMOBLFMHKOD.x, KHEBKHFHMDB)).HasFlag(SpecificType.StairsUp)))
			{
				return false;
			}
			if (WorldGrid.DNDMDGOHDJD(IMOBLFMHKOD + new Vector3(0f, -1f)) && !WorldGrid.LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(0f, -0.5f)))
			{
				if ((Object)(object)BGCOHNIBBMB != (Object)null)
				{
					return BGCOHNIBBMB.tileInfo.numTilesY >= 2;
				}
				return false;
			}
			if (WorldGrid.DNDMDGOHDJD(IMOBLFMHKOD + new Vector3(0f, -0.5f)) && !WorldGrid.LBKKDAMMKIE(IMOBLFMHKOD))
			{
				return true;
			}
			return false;
		default:
			return true;
		}
	}

	public static bool MNLNPHMOEMC(Vector3 IMOBLFMHKOD, bool HDDAMOLLMEB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + Vector3.right * 0.5f * 2f), HDDAMOLLMEB))
		{
			return true;
		}
		if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + Vector3.up * 0.5f * 2f), HDDAMOLLMEB))
		{
			return true;
		}
		if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + Vector3.left * 0.5f * 2f), HDDAMOLLMEB))
		{
			return true;
		}
		if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + Vector3.down * 0.5f * 2f), HDDAMOLLMEB))
		{
			return true;
		}
		return false;
	}

	private static bool IOIPJLMFJKL(Vector2 IMOBLFMHKOD, float DFFGLLDDEPN, bool HDDAMOLLMEB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (DCFELCEFBOH(IMOBLFMHKOD + Vector2.down * 0.5f * DFFGLLDDEPN, HDDAMOLLMEB))
		{
			return DCFELCEFBOH(IMOBLFMHKOD + Vector2.up * 0.5f * DFFGLLDDEPN, HDDAMOLLMEB);
		}
		return false;
	}

	public static void HNLMGBGBEMC()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		EditorTileMaps.ResetEditorTiles();
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.Tavern).GetTilemaps(SeasonManager.EECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Floor && ItemSpace.IsDoorSpaceValid(val))
			{
				KICMMMBCPNF(val, EditorAction.AddFloorDisponible);
				KICMMMBCPNF(val + new Vector3(0.5f, 0f), EditorAction.AddFloorDisponible);
				KICMMMBCPNF(val + new Vector3(0f, 0.5f), EditorAction.AddFloorDisponible);
				KICMMMBCPNF(val + new Vector3(0.5f, 0.5f), EditorAction.AddFloorDisponible);
			}
		}
	}

	private static bool BELABGNPDAD(Vector3 IMOBLFMHKOD, int HHACEADGOOM)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		ACJBHDMECIG = 0;
		for (int i = 0; i < EMBAIAOPIAD.Length + (HHACEADGOOM - 1); i++)
		{
			if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + EMBAIAOPIAD[i % EMBAIAOPIAD.Length]))
			{
				ACJBHDMECIG++;
				if (ACJBHDMECIG == HHACEADGOOM)
				{
					return true;
				}
			}
			else
			{
				ACJBHDMECIG = 0;
			}
		}
		return false;
	}

	private static bool GFJPMLIBFOB(Vector2 IMOBLFMHKOD, Vector2 JHIHMIELOKF, float DFFGLLDDEPN, bool HDDAMOLLMEB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (DCFELCEFBOH(IMOBLFMHKOD + Vector2.down * 0.5f * DFFGLLDDEPN, HDDAMOLLMEB))
		{
			return DCFELCEFBOH(IMOBLFMHKOD + JHIHMIELOKF * 0.5f * DFFGLLDDEPN, HDDAMOLLMEB);
		}
		return false;
	}

	private static void HCIMBOHHFAN(ref EditorTile BNKKFKKAJLO, Vector3 IMOBLFMHKOD, bool HDDAMOLLMEB)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		if (BNKKFKKAJLO.editorAction == EditorAction.AddFloor)
		{
			if (!MNLNPHMOEMC(IMOBLFMHKOD, HDDAMOLLMEB))
			{
				BNKKFKKAJLO.isValid = false;
			}
			if (!MFFIMPBLGFO(IMOBLFMHKOD, 4, HDDAMOLLMEB))
			{
				BNKKFKKAJLO.isValid = false;
			}
			else if (LFCMGFFNNFG(Vector2.op_Implicit(IMOBLFMHKOD), 2, HDDAMOLLMEB) || LFCMGFFNNFG(Vector2.op_Implicit(IMOBLFMHKOD), 4, HDDAMOLLMEB))
			{
				BNKKFKKAJLO.isValid = false;
			}
			else
			{
				BNKKFKKAJLO.isValid = true;
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RemoveFloor)
		{
			BNKKFKKAJLO.isValid = !IOIPJLMFJKL(Vector2.op_Implicit(IMOBLFMHKOD), 2f, HDDAMOLLMEB);
			if (BNKKFKKAJLO.isValid)
			{
				if (GFJPMLIBFOB(Vector2.op_Implicit(IMOBLFMHKOD), Vector2.right, 2f, HDDAMOLLMEB) && !DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(1f, -1f)), HDDAMOLLMEB))
				{
					BNKKFKKAJLO.isValid = false;
				}
				else if (GFJPMLIBFOB(Vector2.op_Implicit(IMOBLFMHKOD), Vector2.left, 2f, HDDAMOLLMEB) && !DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(-1f, -1f)), HDDAMOLLMEB))
				{
					BNKKFKKAJLO.isValid = false;
				}
				else if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0f, -1f)), HDDAMOLLMEB) && !DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(1f, 0f)), HDDAMOLLMEB) && DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(1f, 1f)), HDDAMOLLMEB))
				{
					BNKKFKKAJLO.isValid = false;
				}
				else if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0f, -1f)), HDDAMOLLMEB) && !DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(-1f, 0f)), HDDAMOLLMEB) && DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(-1f, 1f)), HDDAMOLLMEB))
				{
					BNKKFKKAJLO.isValid = false;
				}
				else if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0f, 1f)), HDDAMOLLMEB) && !DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(1f, 0f)), HDDAMOLLMEB) && DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(1f, -1f)), HDDAMOLLMEB))
				{
					BNKKFKKAJLO.isValid = false;
				}
				else if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0f, 1f)), HDDAMOLLMEB) && !DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(-1f, 0f)), HDDAMOLLMEB) && DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(-1f, -1f)), HDDAMOLLMEB))
				{
					BNKKFKKAJLO.isValid = false;
				}
				else if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(1f, 0f)), HDDAMOLLMEB) && !DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(1f, 1f)), HDDAMOLLMEB) && DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0f, 1f)), HDDAMOLLMEB))
				{
					BNKKFKKAJLO.isValid = false;
				}
				else if (DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(-1f, 0f)), HDDAMOLLMEB) && !DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(-1f, 1f)), HDDAMOLLMEB) && DCFELCEFBOH(Vector2.op_Implicit(IMOBLFMHKOD + new Vector3(0f, 1f)), HDDAMOLLMEB))
				{
					BNKKFKKAJLO.isValid = false;
				}
			}
		}
		else
		{
			BNKKFKKAJLO.isValid = true;
		}
	}

	private static bool LFCMGFFNNFG(Vector2 IMOBLFMHKOD, int CIHPCEAHGPD, bool HDDAMOLLMEB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (!LFCMGFFNNFG(IMOBLFMHKOD, -Vector2.one, CIHPCEAHGPD, HDDAMOLLMEB) && !LFCMGFFNNFG(IMOBLFMHKOD, new Vector2(-1f, 1f), CIHPCEAHGPD, HDDAMOLLMEB) && !LFCMGFFNNFG(IMOBLFMHKOD, new Vector2(1f, -1f), CIHPCEAHGPD, HDDAMOLLMEB))
		{
			return LFCMGFFNNFG(IMOBLFMHKOD, Vector2.one, CIHPCEAHGPD, HDDAMOLLMEB);
		}
		return true;
	}

	private static void JOIOPNHHLEC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (FBJHIJNIOGH(IMOBLFMHKOD, EditorAction.AddFloor))
		{
			if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.up))
			{
				KICMMMBCPNF(IMOBLFMHKOD, EditorAction.AddFloorDisponible);
			}
			else if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.down))
			{
				KICMMMBCPNF(IMOBLFMHKOD, EditorAction.AddFloorDisponible);
			}
			else if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.right))
			{
				KICMMMBCPNF(IMOBLFMHKOD, EditorAction.AddFloorDisponible);
			}
			else if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.left))
			{
				KICMMMBCPNF(IMOBLFMHKOD, EditorAction.AddFloorDisponible);
			}
		}
	}

	public static void HCGOFEEMILC(EditorAction CHFHMMNELGP)
	{
		EditorTileMaps.CancelFloorChanges(CHFHMMNELGP);
		EditorTileMaps.ResetEditorTiles();
	}

	public static void HOLEHONPOPK(List<Vector2> CHCFCJHIKPN)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < CHCFCJHIKPN.Count; i++)
		{
			if (AJGOLEOFPOL(Vector2.op_Implicit(CHCFCJHIKPN[i])) != EditorAction.AddFloor)
			{
				JPAFFINPHFM(Vector2.op_Implicit(CHCFCJHIKPN[i]), EditorAction.None);
			}
		}
		for (int j = 0; j < CHCFCJHIKPN.Count; j++)
		{
			JOIOPNHHLEC(Vector2.op_Implicit(CHCFCJHIKPN[j]));
		}
	}

	public static void HCGOFEEMILC(EditorAction CHFHMMNELGP, List<Vector2> CHCFCJHIKPN)
	{
		EditorTileMaps.CancelFloorChanges(CHFHMMNELGP);
		EditorTileMaps.ResetEditorTiles(CHCFCJHIKPN);
	}

	private static bool LFCMGFFNNFG(Vector2 IMOBLFMHKOD, Vector2 FCGBJEIIMBC, int CIHPCEAHGPD, bool HDDAMOLLMEB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (DCFELCEFBOH(IMOBLFMHKOD + new Vector2(FCGBJEIIMBC.x * 0.5f * 2f, 0f), HDDAMOLLMEB))
		{
			return false;
		}
		if (DCFELCEFBOH(IMOBLFMHKOD + new Vector2(0f, FCGBJEIIMBC.y * 0.5f * 2f), HDDAMOLLMEB))
		{
			return false;
		}
		return DCFELCEFBOH(IMOBLFMHKOD + new Vector2(FCGBJEIIMBC.x * 2f, FCGBJEIIMBC.y * (float)CIHPCEAHGPD) * 0.5f, HDDAMOLLMEB);
	}

	public static bool CBALGENFPNP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.down) && AJGOLEOFPOL(IMOBLFMHKOD + Vector3.down) != EditorAction.AddFloor)
		{
			return WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.down * 2f);
		}
		return false;
	}

	public static bool DCFELCEFBOH(Vector2 IMOBLFMHKOD, bool HDDAMOLLMEB = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (AJGOLEOFPOL(Vector2.op_Implicit(IMOBLFMHKOD)) == EditorAction.AddFloor)
		{
			if (HDDAMOLLMEB && !ENFKMBHBBEM(Vector2.op_Implicit(IMOBLFMHKOD)))
			{
				return false;
			}
		}
		else if (AJGOLEOFPOL(Vector2.op_Implicit(IMOBLFMHKOD)) == EditorAction.RemoveFloor)
		{
			if (HDDAMOLLMEB)
			{
				return !ENFKMBHBBEM(Vector2.op_Implicit(IMOBLFMHKOD));
			}
			return false;
		}
		if (!WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(IMOBLFMHKOD)))
		{
			return AJGOLEOFPOL(Vector2.op_Implicit(IMOBLFMHKOD)) == EditorAction.AddFloor;
		}
		return true;
	}

	public static bool BPBIDHBIBHD(Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return HDENCBCBGCM.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
	}

	public static bool BOBIOJCKMKP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out BNKKFKKAJLO) && BNKKFKKAJLO.editorAction == EditorAction.AddFloor)
		{
			return true;
		}
		return WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD);
	}

	public static bool GHGECPHNJEB(EditorAction CHFHMMNELGP)
	{
		if (CHFHMMNELGP != EditorAction.DiningZone && CHFHMMNELGP != EditorAction.CraftingZone)
		{
			return CHFHMMNELGP == EditorAction.RemoveZone;
		}
		return true;
	}

	public static bool CODCAMEPMGA(EditorAction CHFHMMNELGP, DecorationTile KJIGECBPBOD)
	{
		bool result = EditorTileMaps.ApplyChanges(CHFHMMNELGP, KJIGECBPBOD);
		EditorTileMaps.ResetEditorTiles();
		return result;
	}

	public static void IKEHMKFNPFN(EditorAction CHFHMMNELGP)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		PDBLOGMCFAP = new Dictionary<Vector3, EditorTile>(EditorTileMaps.editorTiles);
		foreach (KeyValuePair<Vector3, EditorTile> item in PDBLOGMCFAP)
		{
			MMMHAJHLPBF = default(EditorTile);
			MMMHAJHLPBF.editorAction = item.Value.editorAction;
			MMMHAJHLPBF.reachable = item.Value.reachable;
			HCIMBOHHFAN(ref MMMHAJHLPBF, item.Key, HDDAMOLLMEB: false);
			KILADDNLCOM(item.Key, MMMHAJHLPBF);
		}
		for (int i = 0; i < 2; i++)
		{
			PDBLOGMCFAP = new Dictionary<Vector3, EditorTile>(EditorTileMaps.editorTiles);
			foreach (KeyValuePair<Vector3, EditorTile> item2 in PDBLOGMCFAP)
			{
				MMMHAJHLPBF = default(EditorTile);
				MMMHAJHLPBF.editorAction = item2.Value.editorAction;
				MMMHAJHLPBF.reachable = item2.Value.reachable;
				HCIMBOHHFAN(ref MMMHAJHLPBF, item2.Key, HDDAMOLLMEB: true);
				KILADDNLCOM(item2.Key, MMMHAJHLPBF);
			}
		}
	}

	public static bool GCGNCHFNEBJ(Vector3 IMOBLFMHKOD, out EditorTile ILDEFBIANKO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			ILDEFBIANKO = default(EditorTile);
			return false;
		}
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		return EditorTileMaps.editorTiles.TryGetValue(IMOBLFMHKOD, out ILDEFBIANKO);
	}

	public static bool LFCLOGADPDC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (!WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.up) && AJGOLEOFPOL(IMOBLFMHKOD + Vector3.up) != EditorAction.AddFloor)
		{
			return WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + Vector3.up * 2f);
		}
		return false;
	}

	private static void ICOHDEECKGB(float NCPGNLOJGAF, float KHEBKHFHMDB, int FCGBJEIIMBC)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		NCPGNLOJGAF += 0.5f * (float)FCGBJEIIMBC;
		while (true)
		{
			if (WorldGrid.DNDMDGOHDJD(new Vector3(NCPGNLOJGAF, KHEBKHFHMDB)))
			{
				PEBFAFPIOGL(new Vector3(NCPGNLOJGAF, KHEBKHFHMDB));
				NCPGNLOJGAF += 0.5f * (float)FCGBJEIIMBC;
				continue;
			}
			if (WorldGrid.EJCEAEPNJCA(new Vector3(NCPGNLOJGAF, KHEBKHFHMDB)) && WorldGrid.EJCEAEPNJCA(new Vector3(NCPGNLOJGAF, KHEBKHFHMDB + 0.5f)) && WorldGrid.EJCEAEPNJCA(new Vector3(NCPGNLOJGAF + 0.5f * (float)FCGBJEIIMBC, KHEBKHFHMDB)) && WorldGrid.EJCEAEPNJCA(new Vector3(NCPGNLOJGAF + 0.5f * (float)FCGBJEIIMBC, KHEBKHFHMDB + 0.5f)) && !WorldGrid.EJCEAEPNJCA(new Vector3(NCPGNLOJGAF + 1f * (float)FCGBJEIIMBC, KHEBKHFHMDB + 0.5f)))
			{
				NCPGNLOJGAF += 1f * (float)FCGBJEIIMBC;
				continue;
			}
			break;
		}
	}

	public static void GBFIMODIMLM(DecorationTile OAGIPPNEFJP)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		FOIJLPCOOLJ.Clear();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in EditorTileMaps.editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.DecoWallZone)
			{
				EditorTile value = default(EditorTile);
				value.editorAction = EditorAction.DecoWallZone;
				value.isValid = editorTile.Value.isValid;
				FOIJLPCOOLJ.Add(editorTile.Key, value);
			}
		}
		EditorTileMaps.ResetEditorTiles();
		foreach (KeyValuePair<Vector3, EditorTile> item in FOIJLPCOOLJ)
		{
			KILADDNLCOM(item.Key, item.Value);
		}
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.Tavern).GetTilemaps(SeasonManager.EECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO) || !WorldGrid.DNDMDGOHDJD(val) || WorldGrid.LBKKDAMMKIE(val + new Vector3(0f, 0.5f)) || AJGOLEOFPOL(val + new Vector3(0f, 0.5f)) == EditorAction.DecoWallZone)
			{
				continue;
			}
			DecorationTile decoTile = EditorActionsDBAccessor.GetDecoTile(ILDEFBIANKO.decoWallId);
			if ((Object)(object)decoTile != (Object)null && decoTile.canAddTrim && (Object)(object)OAGIPPNEFJP != (Object)null && ILDEFBIANKO.decoTrimId != OAGIPPNEFJP.id)
			{
				for (int j = 0; j < OAGIPPNEFJP.tileInfo.numTilesY; j++)
				{
					KICMMMBCPNF(val + new Vector3(0f, 0.5f + 0.5f * (float)j), EditorAction.DecoWallDisponible);
				}
			}
		}
	}

	public static void JPAFFINPHFM(Vector3 IMOBLFMHKOD, EditorAction OKNOJJEFEBE)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (GCGNCHFNEBJ(IMOBLFMHKOD, out EGKPNEOKDBL))
		{
			EGKPNEOKDBL.editorAction = OKNOJJEFEBE;
			KILADDNLCOM(IMOBLFMHKOD, EGKPNEOKDBL);
		}
	}
}
