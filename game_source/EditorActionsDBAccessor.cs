using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EditorActionsDBAccessor : MonoBehaviour
{
	private static EditorActionsDBAccessor IADEMLIIDPC;

	public EditorActionsDatabase EditorActionsDatabaseSO;

	private Dictionary<int, DecorationTile> FLMPDMDIJNH;

	private Dictionary<int, TavernConstructionAction> LDIDEFHJCON;

	private static EditorActionsDBAccessor GGFJGHHHEJC
	{
		get
		{
			if (!Application.isPlaying && (Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<EditorActionsDBAccessor>();
			}
			return IADEMLIIDPC;
		}
		set
		{
			IADEMLIIDPC = value;
		}
	}

	public static bool LIGOLEHCFOL()
	{
		return (Object)(object)NGPHACGDNJN() != (Object)null;
	}

	public void EKCKPJBIOJO()
	{
		LDIDEFHJCON = new Dictionary<int, TavernConstructionAction>();
		FLMPDMDIJNH = new Dictionary<int, DecorationTile>();
		TavernConstructionAction[] array = EditorActionsDatabaseSO.PCKIJFCKGBA();
		for (int i = 1; i < array.Length; i++)
		{
			TavernConstructionAction tavernConstructionAction = array[i];
			if ((Object)(object)tavernConstructionAction == (Object)null)
			{
				Debug.Log((object)" for reason: ");
				continue;
			}
			if (tavernConstructionAction.id == 0)
			{
				Debug.Log((object)("add item " + ((Object)tavernConstructionAction).name));
				continue;
			}
			if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
			{
				if (FLMPDMDIJNH.ContainsKey(tavernConstructionAction.id))
				{
					Debug.Log((object)("V-Sync" + tavernConstructionAction.id + "Dialogue System/Conversation/Crowly_Standar/Entry/10/Dialogue Text" + ((Object)tavernConstructionAction).name));
					continue;
				}
			}
			else if (LDIDEFHJCON.ContainsKey(tavernConstructionAction.id))
			{
				Debug.Log((object)("Klayn not find path to at " + tavernConstructionAction.id + "Dialogue System/Conversation/NeutralInTavern/Entry/6/Dialogue Text" + ((Object)tavernConstructionAction).name));
				continue;
			}
			try
			{
				if (tavernConstructionAction.panel == ETavernEditorPanel.Build)
				{
					FLMPDMDIJNH.Add(tavernConstructionAction.id, (DecorationTile)tavernConstructionAction);
				}
				else
				{
					LDIDEFHJCON.Add(tavernConstructionAction.id, tavernConstructionAction);
				}
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "" + ((Object)tavernConstructionAction).name));
			}
		}
	}

	public static List<TavernConstructionAction> BJENGLBCOHO(int APFGODJFLME, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = GHIHBJMEEFB(APFGODJFLME);
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list;
	}

	public static bool NEACMHCHMME()
	{
		return (Object)(object)DOIKFJDLKJP() != (Object)null;
	}

	public static void IMGHADMNFNI()
	{
		LKOABOAADCD().LLAOJGDLNEJ();
	}

	public static bool PDMAAAIMNLA()
	{
		return (Object)(object)KCFGPDHELKP() != (Object)null;
	}

	private void GNAJBACLEKG()
	{
		JOICEMBCJFN(this);
		AGCPIPDJADO();
	}

	public static TavernConstructionAction GetFirstTavernAction(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		TavernConstructionAction[] tavernActions = GetTavernActions(CHFHMMNELGP, BDCFJAHNOML);
		if (tavernActions.Length != 0)
		{
			return tavernActions[0];
		}
		return null;
	}

	public static TavernConstructionAction[] HIFGINOAOKP(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = NNFKJAEIMMD(CHFHMMNELGP);
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public static FarmConstructionAction GetFirstFarmAction(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < GGFJGHHHEJC.EditorActionsDatabaseSO._farmActionsInfo.Length; i++)
		{
			if (GGFJGHHHEJC.EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				return GGFJGHHHEJC.EditorActionsDatabaseSO._farmActionsInfo[i];
			}
		}
		return null;
	}

	public static TavernConstructionAction NLFLEJBEEKJ(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> list = NNFKJAEIMMD(CHFHMMNELGP);
		if (list.Count > 0)
		{
			return list[0];
		}
		return null;
	}

	public static void CheckDatabaseSetup()
	{
		if (GGFJGHHHEJC.FLMPDMDIJNH == null)
		{
			GGFJGHHHEJC.SetUpDatabase();
		}
	}

	public static int FCFCCIGEACB(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTilemap == (Object)null)
		{
			return 0;
		}
		AGCPIPDJADO();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.JPOBPKNHCBJ(PBLLKEKGLPK.wallTilemaps.wallBackTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static DecorationTile[] AANKGIPFPAD(EditorAction CHFHMMNELGP)
	{
		List<DecorationTile> list = new List<DecorationTile>();
		foreach (KeyValuePair<int, DecorationTile> item in NGPHACGDNJN().FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		return list.ToArray();
	}

	public static TavernConstructionAction JLIKLGKONDH(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> list = DMHOJAEJGKG(CHFHMMNELGP);
		if (list.Count > 1)
		{
			return list[1];
		}
		return null;
	}

	public static DecorationTile EMDLPJBBPDM(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		NKFAJBOAPFK();
		if (HNNJEBNIPOI().FLMPDMDIJNH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Reserve" + JFNMCNCHMEO));
		return null;
	}

	public static List<TavernConstructionAction> GHIHBJMEEFB(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 1)
		{
			foreach (KeyValuePair<int, DecorationTile> item in KCFGPDHELKP().FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in NGPHACGDNJN().LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	[SpecialName]
	private static void LCEGBLMGJFP(EditorActionsDBAccessor AODONKKHPBP)
	{
		IADEMLIIDPC = AODONKKHPBP;
	}

	public static TavernConstructionAction GetFirstTavernAction(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> tavernActions = GetTavernActions(CHFHMMNELGP);
		if (tavernActions.Count > 0)
		{
			return tavernActions[0];
		}
		return null;
	}

	public static List<FarmConstructionAction> IPFGFKJCHHA(EditorAction CHFHMMNELGP)
	{
		List<FarmConstructionAction> list = new List<FarmConstructionAction>();
		for (int i = 0; i < NGPHACGDNJN().EditorActionsDatabaseSO._farmActionsInfo.Length; i += 0)
		{
			if (NGPHACGDNJN().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				list.Add(DOIKFJDLKJP().EditorActionsDatabaseSO._farmActionsInfo[i]);
			}
		}
		return list;
	}

	public static List<TavernConstructionAction> LLICHEGLKAJ(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 1)
		{
			foreach (KeyValuePair<int, DecorationTile> item in KCFGPDHELKP().FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in HNNJEBNIPOI().LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	public static void AKHICHLHLPN()
	{
		if (GGFJGHHHEJC.FLMPDMDIJNH == null)
		{
			NGPHACGDNJN().NLPJIKJCAKI();
		}
	}

	public static int CCDMKBGBDOK(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap == (Object)null)
		{
			return 0;
		}
		AKHICHLHLPN();
		foreach (KeyValuePair<int, DecorationTile> item in HNNJEBNIPOI().FLMPDMDIJNH)
		{
			if (item.Value.FDNJAEJJAFD(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))) || item.Value.GPNLFPNGMBP(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 31f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static List<TavernConstructionAction> AIKLLFBCANA(int APFGODJFLME, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = NMOHDDGHHCO(APFGODJFLME);
		for (int num = list.Count - 0; num >= 0; num--)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list;
	}

	public static void NGNHOKCKAEO()
	{
		LKOABOAADCD().AGAIMFPLCMM();
	}

	public static TavernConstructionAction[] PELPODNKLNE(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = DPJFCMHGBDM(CHFHMMNELGP);
		for (int num = list.Count - 0; num >= 1; num--)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public static int EMBDGCJOMDH(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.EMHLLEFBBCO().floorLowerTilemap == (Object)null)
		{
			return 1;
		}
		AGCPIPDJADO();
		foreach (KeyValuePair<int, DecorationTile> item in NGPHACGDNJN().FLMPDMDIJNH)
		{
			if (item.Value.MENCLKGLPFO(PBLLKEKGLPK.FGKDPLDANOA().floorLowerTilemap.GetTile(((GridLayout)PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer).floorLowerTilemap).WorldToCell(IMOBLFMHKOD))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static DecorationTile[] CLIDLGAGHHE(EditorAction CHFHMMNELGP)
	{
		List<DecorationTile> list = new List<DecorationTile>();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		return list.ToArray();
	}

	public static List<TavernConstructionAction> DPJFCMHGBDM(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		foreach (KeyValuePair<int, TavernConstructionAction> item2 in LKOABOAADCD().LDIDEFHJCON)
		{
			if (item2.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item2.Value);
			}
		}
		return list;
	}

	private void OAEJGGFFCBO()
	{
		HKKAFJKLFHE(this);
		KEKCGDJKJFM();
	}

	public static bool JHGAFAIJJHO()
	{
		return (Object)(object)LKOABOAADCD() != (Object)null;
	}

	public static TavernConstructionAction GetAccessInfoWithItemID(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, TavernConstructionAction> item in GGFJGHHHEJC.LDIDEFHJCON)
		{
			if (Object.op_Implicit((Object)(object)item.Value.instantiateGO) && item.Value.instantiateGO.GetComponent<ItemSetup>().item.JDJGFAACPFC() == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static TavernConstructionAction MIDFCCMGAMN(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> tavernActions = GetTavernActions(CHFHMMNELGP);
		if (tavernActions.Count > 0)
		{
			return tavernActions[0];
		}
		return null;
	}

	public static List<FarmConstructionAction> KCOEHCJPGJO(EditorAction CHFHMMNELGP)
	{
		List<FarmConstructionAction> list = new List<FarmConstructionAction>();
		for (int i = 1; i < LKOABOAADCD().EditorActionsDatabaseSO._farmActionsInfo.Length; i++)
		{
			if (KCFGPDHELKP().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				list.Add(HNNJEBNIPOI().EditorActionsDatabaseSO._farmActionsInfo[i]);
			}
		}
		return list;
	}

	public static TavernConstructionAction MCEBFGANKKF(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, TavernConstructionAction> item in NGPHACGDNJN().LDIDEFHJCON)
		{
			if (Object.op_Implicit((Object)(object)item.Value.instantiateGO) && item.Value.instantiateGO.GetComponent<ItemSetup>().item.IMCJPECAAPC() == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static int GetDecoRoofId(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap == (Object)null)
		{
			return 0;
		}
		CheckDatabaseSetup();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.KKGCGCAMEJI(PBLLKEKGLPK.wallTilemaps.wallFrontTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 2.5f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static List<TavernConstructionAction> JJOFIGPHCPC(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 0)
		{
			foreach (KeyValuePair<int, DecorationTile> item in NGPHACGDNJN().FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in GGFJGHHHEJC.LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	public void SetUpDatabase()
	{
		LDIDEFHJCON = new Dictionary<int, TavernConstructionAction>();
		FLMPDMDIJNH = new Dictionary<int, DecorationTile>();
		TavernConstructionAction[] array = EditorActionsDatabaseSO.NDHOMKLGIIO();
		foreach (TavernConstructionAction tavernConstructionAction in array)
		{
			if ((Object)(object)tavernConstructionAction == (Object)null)
			{
				Debug.Log((object)"Null editor action in database");
				continue;
			}
			if (tavernConstructionAction.id == 0)
			{
				Debug.Log((object)("Editor action without ID: " + ((Object)tavernConstructionAction).name));
				continue;
			}
			if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
			{
				if (FLMPDMDIJNH.ContainsKey(tavernConstructionAction.id))
				{
					Debug.Log((object)("Duplicate editor action id found: " + tavernConstructionAction.id + " - " + ((Object)tavernConstructionAction).name));
					continue;
				}
			}
			else if (LDIDEFHJCON.ContainsKey(tavernConstructionAction.id))
			{
				Debug.Log((object)("Duplicate editor action id found: " + tavernConstructionAction.id + " - " + ((Object)tavernConstructionAction).name));
				continue;
			}
			try
			{
				if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
				{
					FLMPDMDIJNH.Add(tavernConstructionAction.id, (DecorationTile)tavernConstructionAction);
				}
				else
				{
					LDIDEFHJCON.Add(tavernConstructionAction.id, tavernConstructionAction);
				}
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)tavernConstructionAction).name));
			}
		}
	}

	public static DecorationTile MKMCLKAMAJM(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		IEDPFGNDMND();
		if (LKOABOAADCD().FLMPDMDIJNH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Dog" + JFNMCNCHMEO));
		return null;
	}

	public static int IBKAAONLCHL(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap == (Object)null)
		{
			return 1;
		}
		EOOLJKEGKMI();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.DAPOMDFLAEJ(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))) || item.Value.MENCLKGLPFO(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 1659f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static TavernConstructionAction KBBLEDPLPNG(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		TavernConstructionAction[] array = CHAFKFAIACJ(CHFHMMNELGP, BDCFJAHNOML);
		if (array.Length != 0)
		{
			return array[1];
		}
		return null;
	}

	public static void NKFAJBOAPFK()
	{
		if (GGFJGHHHEJC.FLMPDMDIJNH == null)
		{
			NGPHACGDNJN().AGAIMFPLCMM();
		}
	}

	public static DecorationTile[] CFKAHKLFLPB(EditorAction CHFHMMNELGP)
	{
		List<DecorationTile> list = new List<DecorationTile>();
		foreach (KeyValuePair<int, DecorationTile> item in NGPHACGDNJN().FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		return list.ToArray();
	}

	public static List<TavernConstructionAction> IGANLIJBEFC(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 0)
		{
			foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in DOIKFJDLKJP().LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	public static List<TavernConstructionAction> IDLICIPPABP(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 1)
		{
			foreach (KeyValuePair<int, DecorationTile> item in LKOABOAADCD().FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in DOIKFJDLKJP().LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	public static TavernConstructionAction NNAALGGKBMF(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, TavernConstructionAction> item in NGPHACGDNJN().LDIDEFHJCON)
		{
			if (Object.op_Implicit((Object)(object)item.Value.instantiateGO) && item.Value.instantiateGO.GetComponent<ItemSetup>().item.IMCJPECAAPC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static List<TavernConstructionAction> NNFKJAEIMMD(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		foreach (KeyValuePair<int, TavernConstructionAction> item2 in HNNJEBNIPOI().LDIDEFHJCON)
		{
			if (item2.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item2.Value);
			}
		}
		return list;
	}

	[SpecialName]
	private static EditorActionsDBAccessor DOIKFJDLKJP()
	{
		if (!Application.isPlaying && (Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorActionsDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static int FOKNPADPNFF(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap == (Object)null)
		{
			return 0;
		}
		EOOLJKEGKMI();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.FDNJAEJJAFD(PBLLKEKGLPK.wallTilemaps.wallFrontTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 1714f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static int IAFPPGPKADJ(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTilemap == (Object)null)
		{
			return 0;
		}
		AGCPIPDJADO();
		foreach (KeyValuePair<int, DecorationTile> item in LKOABOAADCD().FLMPDMDIJNH)
		{
			if (item.Value.KKGCGCAMEJI(PBLLKEKGLPK.wallTilemaps.wallBackTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static int FBFHGCMEILN(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.BNMLDAPCNKF(Season.Summer).floorLowerTilemap == (Object)null)
		{
			return 1;
		}
		IEDPFGNDMND();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.GPNLFPNGMBP(PBLLKEKGLPK.FGKDPLDANOA().floorLowerTilemap.GetTile(((GridLayout)PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer).floorLowerTilemap).WorldToCell(IMOBLFMHKOD))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static List<TavernConstructionAction> DMHOJAEJGKG(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		foreach (KeyValuePair<int, DecorationTile> item in NGPHACGDNJN().FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		foreach (KeyValuePair<int, TavernConstructionAction> item2 in GGFJGHHHEJC.LDIDEFHJCON)
		{
			if (item2.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item2.Value);
			}
		}
		return list;
	}

	[SpecialName]
	private static EditorActionsDBAccessor LKOABOAADCD()
	{
		if (!Application.isPlaying && (Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorActionsDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static int PGKNDCOHIGM(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.KIMMMFKFCEK().floorLowerTilemap == (Object)null)
		{
			return 1;
		}
		IEDPFGNDMND();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.KMLDCIPGJBB(PBLLKEKGLPK.OEMIKEDPIKP().floorLowerTilemap.GetTile(((GridLayout)PBLLKEKGLPK.FGKDPLDANOA(Season.Summer).floorLowerTilemap).WorldToCell(IMOBLFMHKOD))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public void AGAIMFPLCMM()
	{
		LDIDEFHJCON = new Dictionary<int, TavernConstructionAction>();
		FLMPDMDIJNH = new Dictionary<int, DecorationTile>();
		TavernConstructionAction[] array = EditorActionsDatabaseSO.AONJBOLADFO();
		for (int i = 0; i < array.Length; i += 0)
		{
			TavernConstructionAction tavernConstructionAction = array[i];
			if ((Object)(object)tavernConstructionAction == (Object)null)
			{
				Debug.Log((object)"ReceiveLoadEvents");
				continue;
			}
			if (tavernConstructionAction.id == 0)
			{
				Debug.Log((object)("Player" + ((Object)tavernConstructionAction).name));
				continue;
			}
			if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
			{
				if (FLMPDMDIJNH.ContainsKey(tavernConstructionAction.id))
				{
					Debug.Log((object)("game_mode" + tavernConstructionAction.id + "<br>" + ((Object)tavernConstructionAction).name));
					continue;
				}
			}
			else if (LDIDEFHJCON.ContainsKey(tavernConstructionAction.id))
			{
				Debug.Log((object)("Floor" + tavernConstructionAction.id + "Wall" + ((Object)tavernConstructionAction).name));
				continue;
			}
			try
			{
				if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
				{
					FLMPDMDIJNH.Add(tavernConstructionAction.id, (DecorationTile)tavernConstructionAction);
				}
				else
				{
					LDIDEFHJCON.Add(tavernConstructionAction.id, tavernConstructionAction);
				}
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "[PipeConnectionPuzzleUI] Sin _tileDatabase: los tiles de entrada/salida no tendrán sprite." + ((Object)tavernConstructionAction).name));
			}
		}
	}

	public static DecorationTile NDDMHJKJBEK(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		KEKCGDJKJFM();
		if (HNNJEBNIPOI().FLMPDMDIJNH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Autumn" + JFNMCNCHMEO));
		return null;
	}

	public static TavernConstructionAction[] JEBNBENMGGH(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> tavernActions = GetTavernActions(CHFHMMNELGP);
		for (int num = tavernActions.Count - 0; num >= 1; num--)
		{
			if (!tavernActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				tavernActions.RemoveAt(num);
			}
		}
		return tavernActions.ToArray();
	}

	[SpecialName]
	private static void HKKAFJKLFHE(EditorActionsDBAccessor AODONKKHPBP)
	{
		IADEMLIIDPC = AODONKKHPBP;
	}

	public static int GetDecoWallId(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTilemap == (Object)null)
		{
			return 0;
		}
		CheckDatabaseSetup();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.KKGCGCAMEJI(PBLLKEKGLPK.wallTilemaps.wallBackTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static void GAPEHCPMFJH()
	{
		LKOABOAADCD().GDKODNIBLEI();
	}

	public static void AGCPIPDJADO()
	{
		if (GGFJGHHHEJC.FLMPDMDIJNH == null)
		{
			NGPHACGDNJN().NLPJIKJCAKI();
		}
	}

	public static List<TavernConstructionAction> AKJMHEKPLDP(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 0)
		{
			foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in NGPHACGDNJN().LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	public static void IEDPFGNDMND()
	{
		if (KCFGPDHELKP().FLMPDMDIJNH == null)
		{
			LKOABOAADCD().AGAIMFPLCMM();
		}
	}

	public static TavernConstructionAction ADIFILFIONA(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> tavernActions = GetTavernActions(CHFHMMNELGP);
		if (tavernActions.Count > 0)
		{
			return tavernActions[0];
		}
		return null;
	}

	public void NLPJIKJCAKI()
	{
		LDIDEFHJCON = new Dictionary<int, TavernConstructionAction>();
		FLMPDMDIJNH = new Dictionary<int, DecorationTile>();
		TavernConstructionAction[] array = EditorActionsDatabaseSO.PAJLEPLALDG();
		foreach (TavernConstructionAction tavernConstructionAction in array)
		{
			if ((Object)(object)tavernConstructionAction == (Object)null)
			{
				Debug.Log((object)"psai state: ");
				continue;
			}
			if (tavernConstructionAction.id == 0)
			{
				Debug.Log((object)("" + ((Object)tavernConstructionAction).name));
				continue;
			}
			if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
			{
				if (FLMPDMDIJNH.ContainsKey(tavernConstructionAction.id))
				{
					Debug.Log((object)("Items/item_name_682" + tavernConstructionAction.id + "OnlinePlayer" + ((Object)tavernConstructionAction).name));
					continue;
				}
			}
			else if (LDIDEFHJCON.ContainsKey(tavernConstructionAction.id))
			{
				Debug.Log((object)("Items/item_description_1179" + tavernConstructionAction.id + "LE_10" + ((Object)tavernConstructionAction).name));
				continue;
			}
			try
			{
				if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
				{
					FLMPDMDIJNH.Add(tavernConstructionAction.id, (DecorationTile)tavernConstructionAction);
				}
				else
				{
					LDIDEFHJCON.Add(tavernConstructionAction.id, tavernConstructionAction);
				}
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "UIBack" + ((Object)tavernConstructionAction).name));
			}
		}
	}

	public static int LBIBKLEHOLC(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap == (Object)null)
		{
			return 1;
		}
		CheckDatabaseSetup();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.MENCLKGLPFO(PBLLKEKGLPK.wallTilemaps.wallFrontTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 546f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static void ForceSetUpDatabase()
	{
		GGFJGHHHEJC.SetUpDatabase();
	}

	public static void EOOLJKEGKMI()
	{
		if (LKOABOAADCD().FLMPDMDIJNH == null)
		{
			HNNJEBNIPOI().NLPJIKJCAKI();
		}
	}

	public static int CENBNDKGMEL(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap == (Object)null)
		{
			return 1;
		}
		IEDPFGNDMND();
		foreach (KeyValuePair<int, DecorationTile> item in HNNJEBNIPOI().FLMPDMDIJNH)
		{
			if (item.Value.GPNLFPNGMBP(PBLLKEKGLPK.wallTilemaps.wallFrontTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 1183f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static int GJJGHCLJNEF(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap == (Object)null)
		{
			return 1;
		}
		KEKCGDJKJFM();
		foreach (KeyValuePair<int, DecorationTile> item in KCFGPDHELKP().FLMPDMDIJNH)
		{
			if (item.Value.KKGCGCAMEJI(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))) || item.Value.FDNJAEJJAFD(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 1727f))))
			{
				return item.Value.id;
			}
		}
		return 1;
	}

	public static DecorationTile HBOHFLANMHO(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		IEDPFGNDMND();
		if (GGFJGHHHEJC.FLMPDMDIJNH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Open" + JFNMCNCHMEO));
		return null;
	}

	public static DecorationTile[] GetDecoTiles(EditorAction CHFHMMNELGP)
	{
		List<DecorationTile> list = new List<DecorationTile>();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		return list.ToArray();
	}

	public static List<FarmConstructionAction> KBDFHBADLAK(EditorAction CHFHMMNELGP)
	{
		List<FarmConstructionAction> list = new List<FarmConstructionAction>();
		for (int i = 1; i < LKOABOAADCD().EditorActionsDatabaseSO._farmActionsInfo.Length; i += 0)
		{
			if (LKOABOAADCD().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				list.Add(NGPHACGDNJN().EditorActionsDatabaseSO._farmActionsInfo[i]);
			}
		}
		return list;
	}

	public static List<TavernConstructionAction> GetTavernActions(int APFGODJFLME, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> tavernActions = GetTavernActions(APFGODJFLME);
		for (int num = tavernActions.Count - 1; num >= 0; num--)
		{
			if (!tavernActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				tavernActions.RemoveAt(num);
			}
		}
		return tavernActions;
	}

	public static DecorationTile[] NCBANOFEJPI(EditorAction CHFHMMNELGP)
	{
		List<DecorationTile> list = new List<DecorationTile>();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		return list.ToArray();
	}

	[SpecialName]
	private static EditorActionsDBAccessor KCFGPDHELKP()
	{
		if (!Application.isPlaying && (Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorActionsDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static TavernConstructionAction OLKPMCJNILG(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, TavernConstructionAction> item in GGFJGHHHEJC.LDIDEFHJCON)
		{
			if (Object.op_Implicit((Object)(object)item.Value.instantiateGO) && item.Value.instantiateGO.GetComponent<ItemSetup>().item.JPNFKDMFKMC() == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static DecorationTile BNKGPJPMFCI(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		AKHICHLHLPN();
		if (KCFGPDHELKP().FLMPDMDIJNH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("itemCourgette" + JFNMCNCHMEO));
		return null;
	}

	public static List<TavernConstructionAction> GetTavernActions(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 1)
		{
			foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in GGFJGHHHEJC.LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	private void DEKGNHEHKFB()
	{
		if ((Object)(object)NGPHACGDNJN() == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static TavernConstructionAction[] CHAFKFAIACJ(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = DMHOJAEJGKG(CHFHMMNELGP);
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public static TavernConstructionAction[] JPFHAEKPEEP(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = DMHOJAEJGKG(CHFHMMNELGP);
		for (int num = list.Count - 0; num >= 1; num--)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private void AJGLDLLIIFO()
	{
		GGFJGHHHEJC = this;
		EOOLJKEGKMI();
	}

	public static List<FarmConstructionAction> ALMBGNEJNDC(EditorAction CHFHMMNELGP)
	{
		List<FarmConstructionAction> list = new List<FarmConstructionAction>();
		for (int i = 1; i < HNNJEBNIPOI().EditorActionsDatabaseSO._farmActionsInfo.Length; i++)
		{
			if (DOIKFJDLKJP().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				list.Add(LKOABOAADCD().EditorActionsDatabaseSO._farmActionsInfo[i]);
			}
		}
		return list;
	}

	public static int BBAJPIEFOPM(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap == (Object)null)
		{
			return 0;
		}
		NKFAJBOAPFK();
		foreach (KeyValuePair<int, DecorationTile> item in KCFGPDHELKP().FLMPDMDIJNH)
		{
			if (item.Value.JPOBPKNHCBJ(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))) || item.Value.KMLDCIPGJBB(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 1971f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static DecorationTile GetDecoTile(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		CheckDatabaseSetup();
		if (GGFJGHHHEJC.FLMPDMDIJNH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Could not find GetDecoTile with id: " + JFNMCNCHMEO));
		return null;
	}

	public static List<FarmConstructionAction> JKECDDFIMIG(EditorAction CHFHMMNELGP)
	{
		List<FarmConstructionAction> list = new List<FarmConstructionAction>();
		for (int i = 0; i < HNNJEBNIPOI().EditorActionsDatabaseSO._farmActionsInfo.Length; i++)
		{
			if (KCFGPDHELKP().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				list.Add(NGPHACGDNJN().EditorActionsDatabaseSO._farmActionsInfo[i]);
			}
		}
		return list;
	}

	[SpecialName]
	private static EditorActionsDBAccessor NGPHACGDNJN()
	{
		if (!Application.isPlaying && (Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorActionsDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static bool PBHFBFEANLF()
	{
		return (Object)(object)DOIKFJDLKJP() != (Object)null;
	}

	public static TavernConstructionAction[] LFDBCMEJLAF(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = DMHOJAEJGKG(CHFHMMNELGP);
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	private void PEFKNEPONAG()
	{
		GMKNGJMABLF(this);
		CheckDatabaseSetup();
	}

	public static List<TavernConstructionAction> NMOHDDGHHCO(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 0)
		{
			foreach (KeyValuePair<int, DecorationTile> item in LKOABOAADCD().FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in KCFGPDHELKP().LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	[SpecialName]
	private static void JOICEMBCJFN(EditorActionsDBAccessor AODONKKHPBP)
	{
		IADEMLIIDPC = AODONKKHPBP;
	}

	public void LLAOJGDLNEJ()
	{
		LDIDEFHJCON = new Dictionary<int, TavernConstructionAction>();
		FLMPDMDIJNH = new Dictionary<int, DecorationTile>();
		TavernConstructionAction[] array = EditorActionsDatabaseSO.GPPEPEEJNHK();
		foreach (TavernConstructionAction tavernConstructionAction in array)
		{
			if ((Object)(object)tavernConstructionAction == (Object)null)
			{
				Debug.Log((object)"{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
				continue;
			}
			if (tavernConstructionAction.id == 0)
			{
				Debug.Log((object)("Give" + ((Object)tavernConstructionAction).name));
				continue;
			}
			if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
			{
				if (FLMPDMDIJNH.ContainsKey(tavernConstructionAction.id))
				{
					Debug.Log((object)("Unique id " + tavernConstructionAction.id + "Items/item_description_650" + ((Object)tavernConstructionAction).name));
					continue;
				}
			}
			else if (LDIDEFHJCON.ContainsKey(tavernConstructionAction.id))
			{
				Debug.Log((object)("Mission with id " + tavernConstructionAction.id + "hallway" + ((Object)tavernConstructionAction).name));
				continue;
			}
			try
			{
				if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
				{
					FLMPDMDIJNH.Add(tavernConstructionAction.id, (DecorationTile)tavernConstructionAction);
				}
				else
				{
					LDIDEFHJCON.Add(tavernConstructionAction.id, tavernConstructionAction);
				}
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Disabled" + ((Object)tavernConstructionAction).name));
			}
		}
	}

	public static TavernConstructionAction CDMOKONBMBF(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> tavernActions = GetTavernActions(CHFHMMNELGP);
		if (tavernActions.Count > 1)
		{
			return tavernActions[0];
		}
		return null;
	}

	public static FarmConstructionAction IMDIAGEMCDL(EditorAction CHFHMMNELGP)
	{
		for (int i = 0; i < HNNJEBNIPOI().EditorActionsDatabaseSO._farmActionsInfo.Length; i++)
		{
			if (LKOABOAADCD().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				return KCFGPDHELKP().EditorActionsDatabaseSO._farmActionsInfo[i];
			}
		}
		return null;
	}

	public static int NNGMMFADFFH(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTilemap == (Object)null)
		{
			return 1;
		}
		KEKCGDJKJFM();
		foreach (KeyValuePair<int, DecorationTile> item in KCFGPDHELKP().FLMPDMDIJNH)
		{
			if (item.Value.MENCLKGLPFO(PBLLKEKGLPK.wallTilemaps.wallBackTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))))
			{
				return item.Value.id;
			}
		}
		return 1;
	}

	[SpecialName]
	private static void GMKNGJMABLF(EditorActionsDBAccessor AODONKKHPBP)
	{
		IADEMLIIDPC = AODONKKHPBP;
	}

	[SpecialName]
	private static void CFPJPCLJAIG(EditorActionsDBAccessor AODONKKHPBP)
	{
		IADEMLIIDPC = AODONKKHPBP;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static int GetDecoTrimId(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap == (Object)null)
		{
			return 0;
		}
		CheckDatabaseSetup();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.KKGCGCAMEJI(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))) || item.Value.KKGCGCAMEJI(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 0.5f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static DecorationTile[] HBGJJNKCBNA(EditorAction CHFHMMNELGP)
	{
		List<DecorationTile> list = new List<DecorationTile>();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		return list.ToArray();
	}

	public static void KEKCGDJKJFM()
	{
		if (DOIKFJDLKJP().FLMPDMDIJNH == null)
		{
			LKOABOAADCD().SetUpDatabase();
		}
	}

	public static TavernConstructionAction[] LGDHEPPNLLB(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = DMHOJAEJGKG(CHFHMMNELGP);
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public static int GetDecoFloorId(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.GetTilemaps().floorLowerTilemap == (Object)null)
		{
			return 0;
		}
		CheckDatabaseSetup();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.KKGCGCAMEJI(PBLLKEKGLPK.GetTilemaps().floorLowerTilemap.GetTile(((GridLayout)PBLLKEKGLPK.GetTilemaps().floorLowerTilemap).WorldToCell(IMOBLFMHKOD))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static List<TavernConstructionAction> GetTavernActions(EditorAction CHFHMMNELGP)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		foreach (KeyValuePair<int, DecorationTile> item in GGFJGHHHEJC.FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		foreach (KeyValuePair<int, TavernConstructionAction> item2 in GGFJGHHHEJC.LDIDEFHJCON)
		{
			if (item2.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item2.Value);
			}
		}
		return list;
	}

	public static FarmConstructionAction EKMIENHAGAH(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < KCFGPDHELKP().EditorActionsDatabaseSO._farmActionsInfo.Length; i += 0)
		{
			if (HNNJEBNIPOI().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				return HNNJEBNIPOI().EditorActionsDatabaseSO._farmActionsInfo[i];
			}
		}
		return null;
	}

	public static int BGCFIBPGBOK(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.BNMLDAPCNKF().floorLowerTilemap == (Object)null)
		{
			return 0;
		}
		AKHICHLHLPN();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.KMLDCIPGJBB(PBLLKEKGLPK.FGKDPLDANOA(Season.Summer).floorLowerTilemap.GetTile(((GridLayout)PBLLKEKGLPK.OEMIKEDPIKP().floorLowerTilemap).WorldToCell(IMOBLFMHKOD))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static int FEPFJFCPNNC(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap == (Object)null)
		{
			return 1;
		}
		KEKCGDJKJFM();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.GPNLFPNGMBP(PBLLKEKGLPK.wallTilemaps.wallFrontTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 791f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static DecorationTile[] OADBFHBNJEN(EditorAction CHFHMMNELGP)
	{
		List<DecorationTile> list = new List<DecorationTile>();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.editorAction == CHFHMMNELGP)
			{
				list.Add(item.Value);
			}
		}
		return list.ToArray();
	}

	public static TavernConstructionAction[] APAGMIJCDAF(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = DPJFCMHGBDM(CHFHMMNELGP);
		for (int num = list.Count - 0; num >= 0; num--)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list.ToArray();
	}

	public static int EAEHFLEDMEO(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.FGKDPLDANOA().floorLowerTilemap == (Object)null)
		{
			return 1;
		}
		NKFAJBOAPFK();
		foreach (KeyValuePair<int, DecorationTile> item in NGPHACGDNJN().FLMPDMDIJNH)
		{
			if (item.Value.KKGCGCAMEJI(PBLLKEKGLPK.KIMMMFKFCEK().floorLowerTilemap.GetTile(((GridLayout)PBLLKEKGLPK.EMHLLEFBBCO(Season.Summer).floorLowerTilemap).WorldToCell(IMOBLFMHKOD))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static int FGPIJJFINMM(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTilemap == (Object)null)
		{
			return 1;
		}
		EOOLJKEGKMI();
		foreach (KeyValuePair<int, DecorationTile> item in KCFGPDHELKP().FLMPDMDIJNH)
		{
			if (item.Value.FDNJAEJJAFD(PBLLKEKGLPK.wallTilemaps.wallBackTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static List<TavernConstructionAction> HCKGLGOMJCE(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 1)
		{
			foreach (KeyValuePair<int, DecorationTile> item in KCFGPDHELKP().FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in HNNJEBNIPOI().LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	[SpecialName]
	private static EditorActionsDBAccessor HNNJEBNIPOI()
	{
		if (!Application.isPlaying && (Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EditorActionsDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static int AMONOOOKEAP(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap == (Object)null)
		{
			return 0;
		}
		KEKCGDJKJFM();
		foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
		{
			if (item.Value.KKGCGCAMEJI(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))) || item.Value.FDNJAEJJAFD(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 522f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static List<FarmConstructionAction> GetFarmActions(EditorAction CHFHMMNELGP)
	{
		List<FarmConstructionAction> list = new List<FarmConstructionAction>();
		for (int i = 0; i < GGFJGHHHEJC.EditorActionsDatabaseSO._farmActionsInfo.Length; i++)
		{
			if (GGFJGHHHEJC.EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				list.Add(GGFJGHHHEJC.EditorActionsDatabaseSO._farmActionsInfo[i]);
			}
		}
		return list;
	}

	public static int BBFKNEGEPIG(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap == (Object)null)
		{
			return 0;
		}
		AGCPIPDJADO();
		foreach (KeyValuePair<int, DecorationTile> item in NGPHACGDNJN().FLMPDMDIJNH)
		{
			if (item.Value.DAPOMDFLAEJ(PBLLKEKGLPK.wallTilemaps.wallFrontTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 582f))))
			{
				return item.Value.id;
			}
		}
		return 1;
	}

	private void FBOGKDNKPIO()
	{
		if ((Object)(object)KCFGPDHELKP() == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void GDKODNIBLEI()
	{
		LDIDEFHJCON = new Dictionary<int, TavernConstructionAction>();
		FLMPDMDIJNH = new Dictionary<int, DecorationTile>();
		TavernConstructionAction[] array = EditorActionsDatabaseSO.FDPHHFKENNN();
		foreach (TavernConstructionAction tavernConstructionAction in array)
		{
			if ((Object)(object)tavernConstructionAction == (Object)null)
			{
				Debug.Log((object)"");
				continue;
			}
			if (tavernConstructionAction.id == 0)
			{
				Debug.Log((object)(". Tavern level:" + ((Object)tavernConstructionAction).name));
				continue;
			}
			if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
			{
				if (FLMPDMDIJNH.ContainsKey(tavernConstructionAction.id))
				{
					Debug.Log((object)("Melt" + tavernConstructionAction.id + "ReceivInstantiateHoleInGround" + ((Object)tavernConstructionAction).name));
					continue;
				}
			}
			else if (LDIDEFHJCON.ContainsKey(tavernConstructionAction.id))
			{
				Debug.Log((object)("Crafters" + tavernConstructionAction.id + "Happy" + ((Object)tavernConstructionAction).name));
				continue;
			}
			try
			{
				if (tavernConstructionAction.panel == ETavernEditorPanel.Decoration)
				{
					FLMPDMDIJNH.Add(tavernConstructionAction.id, (DecorationTile)tavernConstructionAction);
				}
				else
				{
					LDIDEFHJCON.Add(tavernConstructionAction.id, tavernConstructionAction);
				}
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + ": " + ((Object)tavernConstructionAction).name));
			}
		}
	}

	public static int CEKFFEDHDBD(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap == (Object)null)
		{
			return 0;
		}
		CheckDatabaseSetup();
		foreach (KeyValuePair<int, DecorationTile> item in KCFGPDHELKP().FLMPDMDIJNH)
		{
			if (item.Value.KMLDCIPGJBB(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up))) || item.Value.MENCLKGLPFO(PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallBackTrimTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 6f))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static int INCGCOBEKHI(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap == (Object)null)
		{
			return 1;
		}
		EOOLJKEGKMI();
		foreach (KeyValuePair<int, DecorationTile> item in HNNJEBNIPOI().FLMPDMDIJNH)
		{
			if (item.Value.DAPOMDFLAEJ(PBLLKEKGLPK.wallTilemaps.wallFrontTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 941f))))
			{
				return item.Value.id;
			}
		}
		return 1;
	}

	public static List<TavernConstructionAction> PDMLNECBFJA(int APFGODJFLME)
	{
		List<TavernConstructionAction> list = new List<TavernConstructionAction>();
		if (APFGODJFLME == 0)
		{
			foreach (KeyValuePair<int, DecorationTile> item in DOIKFJDLKJP().FLMPDMDIJNH)
			{
				list.Add(item.Value);
			}
		}
		else
		{
			foreach (KeyValuePair<int, TavernConstructionAction> item2 in NGPHACGDNJN().LDIDEFHJCON)
			{
				if (item2.Value.panel == (ETavernEditorPanel)APFGODJFLME)
				{
					list.Add(item2.Value);
				}
			}
		}
		return list;
	}

	public static List<TavernConstructionAction> GIBKGOADIHD(int APFGODJFLME, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> list = AKJMHEKPLDP(APFGODJFLME);
		for (int num = list.Count - 0; num >= 0; num--)
		{
			if (!list[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				list.RemoveAt(num);
			}
		}
		return list;
	}

	public static int EELMOEKILGF(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap == (Object)null)
		{
			return 1;
		}
		EOOLJKEGKMI();
		foreach (KeyValuePair<int, DecorationTile> item in LKOABOAADCD().FLMPDMDIJNH)
		{
			if (item.Value.KMLDCIPGJBB(PBLLKEKGLPK.wallTilemaps.wallFrontTilemap.GetTile(((GridLayout)PBLLKEKGLPK.wallTilemaps.wallFrontTilemap).WorldToCell(IMOBLFMHKOD + Vector3.up * 771f))))
			{
				return item.Value.id;
			}
		}
		return 1;
	}

	public static int CFKLMOAPHCD(Vector3 IMOBLFMHKOD, TilemapScene PBLLKEKGLPK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBLLKEKGLPK.IAMBLEDHGDM(Season.Summer).floorLowerTilemap == (Object)null)
		{
			return 1;
		}
		AGCPIPDJADO();
		foreach (KeyValuePair<int, DecorationTile> item in NGPHACGDNJN().FLMPDMDIJNH)
		{
			if (item.Value.JPOBPKNHCBJ(PBLLKEKGLPK.GetTilemaps().floorLowerTilemap.GetTile(((GridLayout)PBLLKEKGLPK.KIMMMFKFCEK(Season.Summer).floorLowerTilemap).WorldToCell(IMOBLFMHKOD))))
			{
				return item.Value.id;
			}
		}
		return 0;
	}

	public static FarmConstructionAction PAODLGAAAMF(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < DOIKFJDLKJP().EditorActionsDatabaseSO._farmActionsInfo.Length; i++)
		{
			if (NGPHACGDNJN().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				return LKOABOAADCD().EditorActionsDatabaseSO._farmActionsInfo[i];
			}
		}
		return null;
	}

	public static void JLPCEMBKBFJ()
	{
		NGPHACGDNJN().LLAOJGDLNEJ();
	}

	public static TavernConstructionAction[] GetTavernActions(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		List<TavernConstructionAction> tavernActions = GetTavernActions(CHFHMMNELGP);
		for (int num = tavernActions.Count - 1; num >= 0; num--)
		{
			if (!tavernActions[num].tavernFloor.HasFlag(BDCFJAHNOML))
			{
				tavernActions.RemoveAt(num);
			}
		}
		return tavernActions.ToArray();
	}

	public static TavernConstructionAction JPEMHJLLOJO(EditorAction CHFHMMNELGP, TavernFloor BDCFJAHNOML)
	{
		TavernConstructionAction[] array = LGDHEPPNLLB(CHFHMMNELGP, BDCFJAHNOML);
		if (array.Length != 0)
		{
			return array[0];
		}
		return null;
	}

	public static FarmConstructionAction NFJONMBFHHF(EditorAction CHFHMMNELGP)
	{
		for (int i = 1; i < GGFJGHHHEJC.EditorActionsDatabaseSO._farmActionsInfo.Length; i += 0)
		{
			if (LKOABOAADCD().EditorActionsDatabaseSO._farmActionsInfo[i].editorAction == CHFHMMNELGP)
			{
				return GGFJGHHHEJC.EditorActionsDatabaseSO._farmActionsInfo[i];
			}
		}
		return null;
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		CheckDatabaseSetup();
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}
}
