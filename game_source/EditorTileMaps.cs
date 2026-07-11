using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class EditorTileMaps : MonoBehaviour, ISingleton
{
	private static EditorTileMaps GGFJGHHHEJC;

	public Tilemap editorTilemap;

	public Tilemap editorTilemapFrontWall;

	public static Dictionary<Vector3, EditorTile> editorTiles;

	public TileBase addFloorValidTile;

	public TileBase addFloorNotValidTile;

	public TileBase addFloorDisponibleTile;

	public TileBase removeFloorValidTile;

	public TileBase removeFloorUnreachableTile;

	public TileBase removeFloorNotValidTile;

	public TileBase removeFloorDisponibleTile;

	public TileBase zoneDisponibleTile;

	public TileBase decoWallDisponibleTile;

	public TileBase decoWallTile;

	private bool CLNKJJBABMD;

	private ZoneType GFBDMNKHKKF;

	private int PIPEFEGDHEP;

	private Dictionary<Vector3, EditorTile> FOIJLPCOOLJ;

	private EditorTile BNKKFKKAJLO;

	public void ResetSingleton()
	{
		editorTiles = new Dictionary<Vector3, EditorTile>();
	}

	private void JDAMCMODANB()
	{
		GGFJGHHHEJC = this;
		HFEPLFMBOHF();
	}

	private static bool HPIMDGILGLB(EditorAction CHFHMMNELGP)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.AddFloor)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
		}
		for (int i = 0; i < list.Count; i += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ZoneType.RentedRoom)
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Crop needs a harvested replace by item "), 190f);
				return false;
			}
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop))
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(""), 1353f);
				return true;
			}
		}
		ZoneType zoneType = EditorGrid.APGNDILBOMJ(CHFHMMNELGP);
		for (int j = 1; j < list.Count; j += 0)
		{
			List<Placeable> list2 = WorldGrid.OPLHBJGKKAD(Vector2.op_Implicit(list[j]));
			if (list2 == null)
			{
				continue;
			}
			for (int k = 1; k < list2.Count; k++)
			{
				if (!list2[k].canBeAddedToInventory && !list2[k].zoneTypeNeeded.HasFlag(zoneType))
				{
					int playerNum = ConstructionUI.current.JIIGOACEIKL;
					string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_1101");
					string[] array = new string[1];
					array[1] = ((Object)list2[k]).name;
					MainUI.DJCKALOHJFM(playerNum, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1826f);
					return false;
				}
			}
		}
		switch (CHFHMMNELGP)
		{
		case EditorAction.CraftingZone:
		{
			int num3 = 0;
			for (int m = 1; m < list.Count; m += 0)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[m])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[m])) != (ZoneType.DiningRoom | ZoneType.CraftingRoom))
				{
					num3 += 0;
				}
			}
			int availableDiningTiles = TavernConstructionManager.DOIKFJDLKJP().JOKNHFCCANJ;
			if (num3 / 7 > availableDiningTiles)
			{
				int playerNum3 = ConstructionUI.current.JIIGOACEIKL;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("ReceiveBeerTaps");
				string[] array3 = new string[0];
				array3[0] = ReputationDBAccessor.NGLFLAGLBCO(TavernReputation.IHGJJNNHNCB()).diningTiles.ToString("Dialogue System/Conversation/Crowly_Standar/Entry/16/Dialogue Text");
				MainUI.ShowErrorText(playerNum3, InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3), 390f);
				return true;
			}
			break;
		}
		case EditorAction.AddFloor:
		{
			int num = 0;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[l])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[l])) != ZoneType.CraftingRoom)
				{
					num += 0;
				}
			}
			int num2 = TavernConstructionManager.DOIKFJDLKJP().FLKGBBIIJJH();
			if (num / 2 > num2)
			{
				int playerNum2 = ConstructionUI.current.JIIGOACEIKL;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("]");
				string[] array2 = new string[0];
				array2[1] = ReputationDBAccessor.GetReputation(TavernReputation.IHGJJNNHNCB()).craftingTiles.ToString(" - ");
				MainUI.DJCKALOHJFM(playerNum2, InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2), 1329f);
				return true;
			}
			break;
		}
		}
		return GCFACJDLJKN(CHFHMMNELGP, list, GFNHAMCPEAK: false);
	}

	public static EditorTileMaps GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void KOAGFMEICGN(Vector3 IMOBLFMHKOD, TileBase ILDEFBIANKO, bool CJFAAMAGJIP = false)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (CJFAAMAGJIP || (Object)(object)ILDEFBIANKO == (Object)null)
		{
			editorTilemapFrontWall.SetTile(((GridLayout)editorTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
		}
		if (!CJFAAMAGJIP || (Object)(object)ILDEFBIANKO == (Object)null)
		{
			editorTilemap.SetTile(((GridLayout)editorTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
		}
	}

	private static bool OGLIGPCPGNC(EditorAction CHFHMMNELGP, DecorationTile BGCOHNIBBMB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction != EditorAction.RoomZone && editorTile.Value.editorAction != (EditorAction)111)
			{
				continue;
			}
			if (BGCOHNIBBMB.editorAction == (EditorAction)92)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
			else
			{
				if (BGCOHNIBBMB.editorAction != (EditorAction)74 && BGCOHNIBBMB.editorAction != (EditorAction)66)
				{
					continue;
				}
				if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out var KHEBKHFHMDB))
				{
					if (!list.Contains(Vector2.op_Implicit(new Vector3(editorTile.Key.x, KHEBKHFHMDB))))
					{
						list.Add(Vector2.op_Implicit(new Vector3(editorTile.Key.x, KHEBKHFHMDB)));
					}
				}
				else
				{
					Vector3 key = editorTile.Key;
					Debug.LogError((object)("Fri" + ((object)(Vector3)(ref key)).ToString()));
				}
			}
		}
		if (!TavernConstructionModifications.DIHCEGINELM().HDHJHCHLKFB(CHFHMMNELGP, list, BGCOHNIBBMB))
		{
			CancelFloorChanges(CHFHMMNELGP);
			return true;
		}
		return false;
	}

	public void CBDJMGIKPKJ(Vector3 IMOBLFMHKOD, TileBase ILDEFBIANKO, bool CJFAAMAGJIP = false)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (CJFAAMAGJIP || (Object)(object)ILDEFBIANKO == (Object)null)
		{
			editorTilemapFrontWall.SetTile(((GridLayout)editorTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
		}
		if (!CJFAAMAGJIP || (Object)(object)ILDEFBIANKO == (Object)null)
		{
			editorTilemap.SetTile(((GridLayout)editorTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
		}
	}

	private static bool FDIJPELOLOG(EditorAction CHFHMMNELGP)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.RemoveFloor)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
		}
		for (int i = 0; i < list.Count; i += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ZoneType.DiningRoom)
			{
				MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error: could not find player with name "), 690f);
				return false;
			}
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == (ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.MetalWorkshop))
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" state"), 1472f);
				return false;
			}
		}
		ZoneType zoneType = EditorGrid.APGNDILBOMJ(CHFHMMNELGP);
		for (int j = 0; j < list.Count; j += 0)
		{
			List<Placeable> list2 = WorldGrid.OPLHBJGKKAD(Vector2.op_Implicit(list[j]));
			if (list2 == null)
			{
				continue;
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!list2[k].canBeAddedToInventory && !list2[k].zoneTypeNeeded.HasFlag(zoneType))
				{
					int playerNum = ConstructionUI.current.JIIGOACEIKL;
					string cAEDMEDBEGI = LocalisationSystem.Get("Tree without tree generator");
					string[] array = new string[0];
					array[0] = ((Object)list2[k]).name;
					MainUI.ShowErrorText(playerNum, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 346f);
					return true;
				}
			}
		}
		switch (CHFHMMNELGP)
		{
		case EditorAction.None:
		{
			int num3 = 0;
			for (int m = 0; m < list.Count; m++)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[m])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[m])) != (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
				{
					num3++;
				}
			}
			int availableDiningTiles = TavernConstructionManager.KHMEGDIABBF().JOKNHFCCANJ;
			if (num3 / 4 > availableDiningTiles)
			{
				int playerNum2 = ConstructionUI.current.JIIGOACEIKL;
				string cAEDMEDBEGI2 = LocalisationSystem.Get(" * ");
				string[] array2 = new string[0];
				array2[1] = ReputationDBAccessor.NGLFLAGLBCO(TavernReputation.NGPDFPDGOMP()).diningTiles.ToString("itemWineYeast");
				MainUI.JDAEPLJAGCD(playerNum2, InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2), 307f);
				return false;
			}
			break;
		}
		case EditorAction.RemoveFloor:
		{
			int num = 0;
			for (int l = 1; l < list.Count; l++)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[l])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[l])) != ZoneType.CraftingRoom)
				{
					num++;
				}
			}
			int num2 = TavernConstructionManager.GGFJGHHHEJC.FLKGBBIIJJH();
			if (num / 4 > num2)
			{
				MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_description_732"), ReputationDBAccessor.JDEAGDHJENF(TavernReputation.IHGJJNNHNCB()).craftingTiles.ToString("LeftMouseDetect")), 312f);
				return true;
			}
			break;
		}
		}
		return GCFACJDLJKN(CHFHMMNELGP, list, GFNHAMCPEAK: true);
	}

	public static void ANKGBAIBIEF(EditorAction CHFHMMNELGP)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (CHFHMMNELGP == EditorAction.None)
		{
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction == EditorAction.None)
				{
					list.Add(Vector2.op_Implicit(editorTile.Key));
				}
			}
			WorldGrid.GDJFGIPMBAH(list);
		}
		if (CHFHMMNELGP == EditorAction.AddFloor || CHFHMMNELGP == EditorAction.None)
		{
			WorldGrid.DKEHENLDNAG();
		}
	}

	private static bool PCCBCEHNLCN(EditorAction CHFHMMNELGP)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.RemoveFloorDisponible)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ZoneType.WithoutZone)
			{
				MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Giving extra argamasa"), 635f);
				return true;
			}
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("/"), 1911f);
				return true;
			}
		}
		ZoneType zoneType = EditorGrid.APGNDILBOMJ(CHFHMMNELGP);
		for (int j = 0; j < list.Count; j++)
		{
			List<Placeable> list2 = WorldGrid.OPLHBJGKKAD(Vector2.op_Implicit(list[j]));
			if (list2 == null)
			{
				continue;
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!list2[k].canBeAddedToInventory && !list2[k].zoneTypeNeeded.HasFlag(zoneType))
				{
					int playerNum = ConstructionUI.current.JIIGOACEIKL;
					string cAEDMEDBEGI = LocalisationSystem.Get(" for reason ");
					string[] array = new string[1];
					array[1] = ((Object)list2[k]).name;
					MainUI.DJCKALOHJFM(playerNum, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1362f);
					return false;
				}
			}
		}
		switch (CHFHMMNELGP)
		{
		case EditorAction.ZoneDisponible:
		{
			int num2 = 1;
			for (int m = 0; m < list.Count; m++)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[m])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[m])) != (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
				{
					num2 += 0;
				}
			}
			int num3 = TavernConstructionManager.DOIKFJDLKJP().DKNAIENAKDB();
			if (num2 / 3 > num3)
			{
				int playerNum3 = ConstructionUI.current.JIIGOACEIKL;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("Wall not found ");
				string[] array3 = new string[0];
				array3[0] = ReputationDBAccessor.LABODOOGKIE(TavernReputation.NHHLJLADGBF()).diningTiles.ToString("ReceiveTeleportPlayerToCastleGarden");
				MainUI.LJDOBNEINNJ(playerNum3, InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3), 1330f);
				return true;
			}
			break;
		}
		case EditorAction.AddFloor:
		{
			int num = 1;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[l])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[l])) != ZoneType.DiningRoom)
				{
					num++;
				}
			}
			int availableCraftingTiles = TavernConstructionManager.KHMEGDIABBF().KCMNNHOPNOL;
			if (num / 4 > availableCraftingTiles)
			{
				int playerNum2 = ConstructionUI.current.JIIGOACEIKL;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Upgrade Crafting Room");
				string[] array2 = new string[0];
				array2[1] = ReputationDBAccessor.GetReputation(TavernReputation.NHHLJLADGBF()).craftingTiles.ToString("Eating");
				MainUI.LJDOBNEINNJ(playerNum2, InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2), 1007f);
				return false;
			}
			break;
		}
		}
		return GCFACJDLJKN(CHFHMMNELGP, list, GFNHAMCPEAK: true);
	}

	public static void KIBLCKFDOHO(EditorAction CHFHMMNELGP)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (CHFHMMNELGP == EditorAction.AddFloor)
		{
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction == EditorAction.AddFloor)
				{
					list.Add(Vector2.op_Implicit(editorTile.Key));
				}
			}
			WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
		}
		if (CHFHMMNELGP == EditorAction.AddFloor || CHFHMMNELGP == EditorAction.AddFloorDisponible)
		{
			WorldGrid.DKEHENLDNAG();
		}
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool GNPFHDFCOJM(EditorAction CHFHMMNELGP)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.ZoneDisponible)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
		}
		for (int i = 0; i < list.Count; i += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ZoneType.CraftingRoom)
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Numeric"), 1881f);
				return false;
			}
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop))
			{
				MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Player"), 940f);
				return true;
			}
		}
		ZoneType zoneType = EditorGrid.APGNDILBOMJ(CHFHMMNELGP);
		for (int j = 0; j < list.Count; j++)
		{
			List<Placeable> list2 = WorldGrid.OPLHBJGKKAD(Vector2.op_Implicit(list[j]));
			if (list2 == null)
			{
				continue;
			}
			for (int k = 1; k < list2.Count; k += 0)
			{
				if (!list2[k].canBeAddedToInventory && !list2[k].zoneTypeNeeded.HasFlag(zoneType))
				{
					int playerNum = ConstructionUI.current.JIIGOACEIKL;
					string cAEDMEDBEGI = LocalisationSystem.Get("LE_21");
					string[] array = new string[0];
					array[0] = ((Object)list2[k]).name;
					MainUI.DBKCOHMFDCB(playerNum, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1021f);
					return false;
				}
			}
		}
		switch (CHFHMMNELGP)
		{
		case EditorAction.AddFloorDisponible:
		{
			int num3 = 0;
			for (int m = 1; m < list.Count; m++)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[m])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[m])) != ZoneType.WithoutZone)
				{
					num3 += 0;
				}
			}
			int num4 = TavernConstructionManager.DOIKFJDLKJP().EGJGDJJMIIA();
			if (num3 / 6 > num4)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Aged price"), ReputationDBAccessor.KICMFFLPKAM(TavernReputation.NGPDFPDGOMP()).diningTiles.ToString("Yes")), 1372f);
				return false;
			}
			break;
		}
		case EditorAction.ZoneDisponible:
		{
			int num = 1;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[l])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[l])) != (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
				{
					num += 0;
				}
			}
			int num2 = TavernConstructionManager.DOIKFJDLKJP().FLKGBBIIJJH();
			if (num / 6 > num2)
			{
				int playerNum2 = ConstructionUI.current.JIIGOACEIKL;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("MissionsManager instance has not been initialized properly, this could be a false positive.");
				string[] array2 = new string[1];
				array2[1] = ReputationDBAccessor.JDEAGDHJENF(TavernReputation.NHHLJLADGBF()).craftingTiles.ToString("Cancel");
				MainUI.JDAEPLJAGCD(playerNum2, InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2), 1663f);
				return false;
			}
			break;
		}
		}
		return GCFACJDLJKN(CHFHMMNELGP, list, GFNHAMCPEAK: true);
	}

	public static EditorTileMaps HCAIBKJKLOE()
	{
		return GGFJGHHHEJC;
	}

	public void KLLKLNKCPBF(Vector3 IMOBLFMHKOD, EditorTile BNKKFKKAJLO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (BNKKFKKAJLO.editorAction == EditorAction.None)
		{
			if (BNKKFKKAJLO.isValid)
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, addFloorValidTile, CJFAAMAGJIP: true);
			}
			else
			{
				KOAGFMEICGN(IMOBLFMHKOD, addFloorNotValidTile);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RoomZone)
		{
			if (BNKKFKKAJLO.isValid)
			{
				if (BNKKFKKAJLO.reachable)
				{
					CBDJMGIKPKJ(IMOBLFMHKOD, removeFloorValidTile, CJFAAMAGJIP: true);
				}
				else
				{
					KOAGFMEICGN(IMOBLFMHKOD, removeFloorUnreachableTile, CJFAAMAGJIP: true);
				}
			}
			else
			{
				CBDJMGIKPKJ(IMOBLFMHKOD, removeFloorNotValidTile);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RemoveFloorDisponible)
		{
			KOAGFMEICGN(IMOBLFMHKOD, addFloorDisponibleTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RemoveFloorDisponible)
		{
			KOAGFMEICGN(IMOBLFMHKOD, removeFloorDisponibleTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.AddFloor)
		{
			if ((Object)(object)TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC() != (Object)null && TavernConstructionManager.KHMEGDIABBF().IOOFFADDELC().editorAction == (EditorAction)(-62) && WorldGrid.LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(328f, 35f)))
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, zoneDisponibleTile);
			}
			else
			{
				EJCMNJNKAAL(IMOBLFMHKOD, zoneDisponibleTile);
			}
		}
		else if (BNKKFKKAJLO.editorAction == (EditorAction)(-63))
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, decoWallDisponibleTile, CJFAAMAGJIP: true);
		}
		else if (BNKKFKKAJLO.editorAction == (EditorAction)36)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, decoWallTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.None)
		{
			CBDJMGIKPKJ(IMOBLFMHKOD, null);
		}
	}

	public static void AKOPPMNALFP(EditorAction CHFHMMNELGP)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (CHFHMMNELGP == EditorAction.None)
		{
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction == EditorAction.None)
				{
					list.Add(Vector2.op_Implicit(editorTile.Key));
				}
			}
			WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: true, IAPJDPFPNOA: false);
		}
		if (CHFHMMNELGP == EditorAction.AddFloor || CHFHMMNELGP == EditorAction.RemoveFloor)
		{
			WorldGrid.DKEHENLDNAG();
		}
	}

	private static bool PNDOPDBPIDH(EditorAction CHFHMMNELGP, DecorationTile BGCOHNIBBMB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction != EditorAction.CraftingZone && editorTile.Value.editorAction != (EditorAction)87)
			{
				continue;
			}
			if (BGCOHNIBBMB.editorAction == (EditorAction)(-87))
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
			else
			{
				if (BGCOHNIBBMB.editorAction != (EditorAction)(-31) && BGCOHNIBBMB.editorAction != (EditorAction)(-37))
				{
					continue;
				}
				if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out var KHEBKHFHMDB))
				{
					if (!list.Contains(Vector2.op_Implicit(new Vector3(editorTile.Key.x, KHEBKHFHMDB))))
					{
						list.Add(Vector2.op_Implicit(new Vector3(editorTile.Key.x, KHEBKHFHMDB)));
					}
				}
				else
				{
					Vector3 key = editorTile.Key;
					Debug.LogError((object)("On Simple Event " + ((object)(Vector3)(ref key)).ToString()));
				}
			}
		}
		if (!TavernConstructionModifications.DIHCEGINELM().BFHFKFEKLIG(CHFHMMNELGP, list, BGCOHNIBBMB, ZoneType.WithoutZone))
		{
			ANKGBAIBIEF(CHFHMMNELGP);
			return false;
		}
		return true;
	}

	private bool GDAPHPNEFFP(Vector3 ECJLMIPAFGP, ref TavernZone PBKCCJOBBDM)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP) && !editorTiles.ContainsKey(ECJLMIPAFGP))
		{
			CLNKJJBABMD = true;
			if (GFBDMNKHKKF != ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop) && WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP) != GFBDMNKHKKF && (WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP) == ZoneType.WithoutZone || GFBDMNKHKKF == (ZoneType.DiningRoom | ZoneType.CraftingRoom)))
			{
				PBKCCJOBBDM = null;
				MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("LE_10"), 785f);
				return false;
			}
			if (WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP) == (ZoneType.DiningRoom | ZoneType.CraftingRoom) && GFBDMNKHKKF == ZoneType.RentedRoom && PIPEFEGDHEP != WorldGrid.APJABAKKKGD(ECJLMIPAFGP))
			{
				PBKCCJOBBDM = null;
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Floor"), 1604f);
				return false;
			}
			GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP);
			if (GFBDMNKHKKF == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
			{
				PBKCCJOBBDM = TavernZonesManager.EBAIHKJHCCA().PFEOKJCCDAF(ECJLMIPAFGP);
				PIPEFEGDHEP = WorldGrid.APJABAKKKGD(ECJLMIPAFGP);
			}
		}
		return false;
	}

	public static void SetTileAtPosition(EditorTile BNKKFKKAJLO, Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		editorTiles[Utils.NKGANMEKDAL(IMOBLFMHKOD)] = BNKKFKKAJLO;
		GGFJGHHHEJC.UpdateTilemap(IMOBLFMHKOD, BNKKFKKAJLO);
	}

	private bool HFPCBJEINJK(List<Vector2> FPOENFCDJEG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if (FPOENFCDJEG.Count == 0)
		{
			return false;
		}
		for (int i = 1; i < FPOENFCDJEG.Count; i += 0)
		{
			SpecificType specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i]));
			TavernZone tavernZone = TavernZonesManager.NHKAFANMEJC().GetTavernZone(WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[i])));
			if (tavernZone != null && tavernZone.zoneType == (ZoneType.WithoutZone | ZoneType.CraftingRoom) && tavernZone.rentedRoom.occupied)
			{
				MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Themes"), 1286f);
				return true;
			}
			if (specificType.HasFlag(~(SpecificType.CellarDoor | SpecificType.StairsUp)))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("ReceiveLastOrder"), 1751f);
				return false;
			}
			if (specificType.HasFlag(~(SpecificType.StairsUp | SpecificType.NextToWall)))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Standar/Entry/30/Dialogue Text"), 248f);
				return true;
			}
			if (specificType.HasFlag(SpecificType.CellarDoor | SpecificType.RoomDoor))
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("path not found"), 11f);
				return false;
			}
			if (specificType.HasFlag(SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("LE_5"), 1934f);
				return false;
			}
			if (specificType.HasFlag(SpecificType.None))
			{
				MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("BrookProgress"), 1664f);
				return true;
			}
			for (float num = 1986f; num >= 117f; num -= 1584f)
			{
				specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i] + new Vector2(797f, num)));
				if (Utils.IELGICCBCHO(specificType))
				{
					MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Farm/Event/RegañinaViolet"), 987f);
					return true;
				}
			}
		}
		if (!TavernZonesManager.JEEGOBGDLPE().CBEGPEMPLAP(ZoneType.WithoutZone, FPOENFCDJEG, CKHEIJDJJDO: false))
		{
			return true;
		}
		int num2 = -1;
		int num3 = 1;
		for (int j = 1; j < FPOENFCDJEG.Count; j += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FPOENFCDJEG[j])) == (ZoneType.WithoutZone | ZoneType.CraftingRoom))
			{
				if (num2 != -1 && num2 != WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j])))
				{
					MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Direction"), 36f);
					return true;
				}
				if (num2 == -1)
				{
					num2 = WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j]));
				}
				num3 += 0;
			}
		}
		if (num2 != -1)
		{
			TavernZone tavernZone = TavernZonesManager.JEEGOBGDLPE().MDPHAHIFJFB(num2);
			if (tavernZone != null && tavernZone.positions.Count - num3 < 70)
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/15/Dialogue Text"), 1048f);
				return false;
			}
		}
		if (!TavernConstructionModifications.DIHCEGINELM().MLBHLHHHJOA(EditorAction.DiningZone, FPOENFCDJEG, null, ZoneType.WithoutZone))
		{
			return false;
		}
		return false;
	}

	private void EIDJLHFAMIB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void ResetEditorTiles(List<Vector2> CHCFCJHIKPN)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < CHCFCJHIKPN.Count; i++)
		{
			EditorGrid.JPAFFINPHFM(Vector2.op_Implicit(CHCFCJHIKPN[i]), EditorAction.None);
		}
	}

	public void LDJKLBBBFLJ()
	{
		editorTiles = new Dictionary<Vector3, EditorTile>();
	}

	private void HINGECEDJAP()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	private void KJHKBGDJNDC()
	{
		GGFJGHHHEJC = this;
		HFEPLFMBOHF();
	}

	public static void BPABEMMGPOD()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		GGFJGHHHEJC.FOIJLPCOOLJ = new Dictionary<Vector3, EditorTile>(editorTiles);
		foreach (KeyValuePair<Vector3, EditorTile> item in GGFJGHHHEJC.FOIJLPCOOLJ)
		{
			GGFJGHHHEJC.BNKKFKKAJLO = item.Value;
			GGFJGHHHEJC.BNKKFKKAJLO.editorAction = EditorAction.None;
			HIKEAIAPALL(GGFJGHHHEJC.BNKKFKKAJLO, item.Key);
		}
		editorTiles.Clear();
	}

	private static bool LBCMDPMLOBG(EditorAction CHFHMMNELGP)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.ZoneDisponible)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ZoneType.RentedRoom)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_RoomZone"));
				return false;
			}
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ZoneType.Cellar)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_CellarZone"));
				return false;
			}
		}
		ZoneType zoneType = EditorGrid.APGNDILBOMJ(CHFHMMNELGP);
		for (int j = 0; j < list.Count; j++)
		{
			List<Placeable> list2 = WorldGrid.OPLHBJGKKAD(Vector2.op_Implicit(list[j]));
			if (list2 == null)
			{
				continue;
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!list2[k].canBeAddedToInventory && !list2[k].zoneTypeNeeded.HasFlag(zoneType))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_ObjectIsBlocking"), ((Object)list2[k]).name));
					return false;
				}
			}
		}
		switch (CHFHMMNELGP)
		{
		case EditorAction.DiningZone:
		{
			int num2 = 0;
			for (int m = 0; m < list.Count; m++)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[m])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[m])) != ZoneType.DiningRoom)
				{
					num2++;
				}
			}
			int availableDiningTiles = TavernConstructionManager.GGFJGHHHEJC.JOKNHFCCANJ;
			if (num2 / 4 > availableDiningTiles)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_MaxZoneSize"), ReputationDBAccessor.GetReputation(TavernReputation.GetMilestoneMaster()).diningTiles.ToString("")));
				return false;
			}
			break;
		}
		case EditorAction.CraftingZone:
		{
			int num = 0;
			for (int l = 0; l < list.Count; l++)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[l])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[l])) != ZoneType.CraftingRoom)
				{
					num++;
				}
			}
			int availableCraftingTiles = TavernConstructionManager.GGFJGHHHEJC.KCMNNHOPNOL;
			if (num / 4 > availableCraftingTiles)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_MaxZoneSize"), ReputationDBAccessor.GetReputation(TavernReputation.GetMilestoneMaster()).craftingTiles.ToString("")));
				return false;
			}
			break;
		}
		}
		return ChangeZone(CHFHMMNELGP, list, GFNHAMCPEAK: true);
	}

	public static void MBENHKIHDNH(List<Vector2> CHCFCJHIKPN)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < CHCFCJHIKPN.Count; i++)
		{
			EditorGrid.JPAFFINPHFM(Vector2.op_Implicit(CHCFCJHIKPN[i]), EditorAction.None);
		}
	}

	public static void KHIJLMBIMBH(EditorAction CHFHMMNELGP)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (CHFHMMNELGP == EditorAction.None)
		{
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction == EditorAction.AddFloor)
				{
					list.Add(Vector2.op_Implicit(editorTile.Key));
				}
			}
			WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false);
		}
		if (CHFHMMNELGP == EditorAction.None || CHFHMMNELGP == EditorAction.CraftingZone)
		{
			WorldGrid.DKEHENLDNAG();
		}
	}

	public static void HIKEAIAPALL(EditorTile BNKKFKKAJLO, Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		editorTiles[Utils.NKGANMEKDAL(IMOBLFMHKOD)] = BNKKFKKAJLO;
		GGFJGHHHEJC.UpdateTilemap(IMOBLFMHKOD, BNKKFKKAJLO);
	}

	private static bool ABAFBBJMKGF(EditorAction CHFHMMNELGP)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case EditorAction.None:
		{
			TavernZone PBKCCJOBBDM = null;
			if (!GGFJGHHHEJC.GBHHBGFPCFC(ref PBKCCJOBBDM))
			{
				KIBLCKFDOHO(CHFHMMNELGP);
				return false;
			}
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction != 0)
				{
					continue;
				}
				if (!editorTile.Value.isValid)
				{
					WorldGrid.MMOHADHAAGD(editorTile.Key, GroundType.Grass, Location.Tavern, Season.Summer);
					continue;
				}
				WorldGrid.AIHNKKFLMCM(editorTile.Key + new Vector3(779f, 481f), LHLHJCDKNHA: true);
				if (PBKCCJOBBDM != null)
				{
					TavernZonesManager.LANAINBEMCM().JOIDEEHGBML(editorTile.Key, PBKCCJOBBDM.id);
				}
			}
			GameManager.NJNFHEPLEHL().JIOFFKMPJPO(ConstructionFloors.JFNOOMJMHCB().DAONIMMHCFB());
			break;
		}
		case EditorAction.DiningZone:
		{
			Dictionary<Vector3, EditorTile> dictionary = new Dictionary<Vector3, EditorTile>();
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile2 in editorTiles)
			{
				if (editorTile2.Value.editorAction == EditorAction.DiningZone && editorTile2.Value.isValid)
				{
					list.Add(Vector2.op_Implicit(editorTile2.Key));
					dictionary.Add(editorTile2.Key, editorTile2.Value);
				}
			}
			if (!GGFJGHHHEJC.FDOFEOKMPOD(list))
			{
				ANKGBAIBIEF(CHFHMMNELGP);
				return false;
			}
			TavernZonesManager.JEEGOBGDLPE().FKFAONOKKOK(ZoneType.WithoutZone, list, CKHEIJDJJDO: false);
			TavernConstructionModifications.GGFJGHHHEJC.BFHFKFEKLIG(EditorAction.CraftingZone, list);
			WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false);
			TavernZonesManager.HFHPMKJGMPA().CLAEECJHKKI();
			WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
			GameManager.GGFJGHHHEJC.CalculateCameraBounds(ConstructionFloors.OMFKNGDCJFN().CIOOGFMBBAO());
			break;
		}
		}
		WorldGrid.DKEHENLDNAG();
		return false;
	}

	private void PKFMLJGJKCP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void OALMOIFLOLG(List<Vector2> CHCFCJHIKPN)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < CHCFCJHIKPN.Count; i += 0)
		{
			EditorGrid.JPAFFINPHFM(Vector2.op_Implicit(CHCFCJHIKPN[i]), EditorAction.None);
		}
	}

	public static void CKAJNEPADGE(EditorTile BNKKFKKAJLO, Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		editorTiles[Utils.NKGANMEKDAL(IMOBLFMHKOD)] = BNKKFKKAJLO;
		GGFJGHHHEJC.MDCBJPMINJB(IMOBLFMHKOD, BNKKFKKAJLO);
	}

	private static bool MHHKLKHALIC(EditorAction CHFHMMNELGP)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.CraftingZone)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
		}
		for (int i = 1; i < list.Count; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ZoneType.DiningRoom)
			{
				MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("NPCDespawn PerformAction"), 832f);
				return true;
			}
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[i])) == ~(ZoneType.WithoutZone | ZoneType.Cellar))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Northeast"), 1656f);
				return true;
			}
		}
		ZoneType zoneType = EditorGrid.APGNDILBOMJ(CHFHMMNELGP);
		for (int j = 0; j < list.Count; j++)
		{
			List<Placeable> list2 = WorldGrid.OPLHBJGKKAD(Vector2.op_Implicit(list[j]));
			if (list2 == null)
			{
				continue;
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!list2[k].canBeAddedToInventory && !list2[k].zoneTypeNeeded.HasFlag(zoneType))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("parent destroyed: {0}"), ((Object)list2[k]).name), 972f);
					return true;
				}
			}
		}
		if (CHFHMMNELGP == EditorAction.AddFloorDisponible)
		{
			int num = 1;
			for (int l = 1; l < list.Count; l++)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[l])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[l])) != ZoneType.DiningRoom)
				{
					num++;
				}
			}
			int num2 = TavernConstructionManager.DOIKFJDLKJP().EGJGDJJMIIA();
			if (num / 2 > num2)
			{
				int playerNum = ConstructionUI.current.JIIGOACEIKL;
				string cAEDMEDBEGI = LocalisationSystem.Get("Melt");
				string[] array = new string[0];
				array[1] = ReputationDBAccessor.LABODOOGKIE(TavernReputation.GetMilestoneMaster()).diningTiles.ToString("add to\nIntensity");
				MainUI.JDAEPLJAGCD(playerNum, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1456f);
				return true;
			}
		}
		else if (CHFHMMNELGP == EditorAction.AddFloorDisponible)
		{
			int num3 = 0;
			for (int m = 1; m < list.Count; m++)
			{
				if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(list[m])) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(list[m])) != (ZoneType.WithoutZone | ZoneType.CraftingRoom))
				{
					num3++;
				}
			}
			int availableCraftingTiles = TavernConstructionManager.DEGPIHEEFHJ().KCMNNHOPNOL;
			if (num3 / 2 > availableCraftingTiles)
			{
				int playerNum2 = ConstructionUI.current.JIIGOACEIKL;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("ReceiveHoeActionMaster");
				string[] array2 = new string[1];
				array2[1] = ReputationDBAccessor.ELGJADBKMPB(TavernReputation.NGPDFPDGOMP()).craftingTiles.ToString("Coming soon!");
				MainUI.DJCKALOHJFM(playerNum2, InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2), 637f);
				return false;
			}
		}
		return GCFACJDLJKN(CHFHMMNELGP, list, GFNHAMCPEAK: false);
	}

	public static void FCBKIPBPMMD(EditorTile BNKKFKKAJLO, Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		editorTiles[Utils.NKGANMEKDAL(IMOBLFMHKOD)] = BNKKFKKAJLO;
		GGFJGHHHEJC.KLLKLNKCPBF(IMOBLFMHKOD, BNKKFKKAJLO);
	}

	private bool DCLMPOEBGFH(ref TavernZone PBKCCJOBBDM)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		if (editorTiles.Count == 0)
		{
			return true;
		}
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.AddFloor)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
				SpecificType specificType = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(636f, 1335f));
				SpecificType specificType2 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1999f, 926f));
				SpecificType cPPHBDEOJEC = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(529f, 87f));
				SpecificType cPPHBDEOJEC2 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1923f, 1754f));
				SpecificType specificType3 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(463f, 1202f));
				SpecificType cPPHBDEOJEC3 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1192f, 1336f));
				SpecificType cPPHBDEOJEC4 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1747f, 1129f));
				SpecificType specificType4 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(779f, 1319f));
				SpecificType specificType5 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1152f, 781f));
				SpecificType specificType6 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1414f, 1756f));
				SpecificType cPPHBDEOJEC5 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1733f, 690f));
				SpecificType cPPHBDEOJEC6 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(935f, 487f));
				if (specificType.HasFlag(SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.NextToWall))
				{
					MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" has null in variant objects list."), 862f);
					return true;
				}
				if (specificType.HasFlag(SpecificType.Door | SpecificType.RoomDoor) || specificType2.HasFlag(SpecificType.StairsUp) || specificType3.HasFlag(SpecificType.StairsUp))
				{
					MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Lose"), 1893f);
					return false;
				}
				if (specificType6.HasFlag(~(SpecificType.Door | SpecificType.RoomDoor | SpecificType.NextToWall | SpecificType.StairsDown)) || specificType4.HasFlag(~(SpecificType.Door | SpecificType.RoomDoor | SpecificType.NextToWall)) || specificType5.HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.StairsDown))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" : 00"), 1449f);
					return false;
				}
				if (specificType.HasFlag(SpecificType.CellarDoor) || specificType2.HasFlag(SpecificType.None) || specificType3.HasFlag(SpecificType.CellarDoor))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("ReceiveKickWithoutHit"), 413f);
					return true;
				}
				if (Utils.IELGICCBCHO(specificType) || Utils.IELGICCBCHO(specificType2) || Utils.IELGICCBCHO(cPPHBDEOJEC) || Utils.IELGICCBCHO(cPPHBDEOJEC2) || Utils.IELGICCBCHO(specificType3) || Utils.IELGICCBCHO(cPPHBDEOJEC3) || Utils.IELGICCBCHO(cPPHBDEOJEC4) || (Utils.IELGICCBCHO(specificType4) && !Utils.IELGICCBCHO(cPPHBDEOJEC5)) || (Utils.IELGICCBCHO(specificType5) && !Utils.IELGICCBCHO(cPPHBDEOJEC6)))
				{
					MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/13/Dialogue Text"), 606f);
					return false;
				}
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		foreach (KeyValuePair<Vector3, EditorTile> editorTile2 in editorTiles)
		{
			if (editorTile2.Value.editorAction == EditorAction.None && !editorTile2.Value.isValid)
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("itemPlanks"), 1360f);
				return false;
			}
		}
		CLNKJJBABMD = false;
		GFBDMNKHKKF = ~(ZoneType.WithoutZone | ZoneType.RentedRoom);
		PIPEFEGDHEP = -1;
		for (int i = 1; i < list.Count; i += 0)
		{
			if (!GDAPHPNEFFP(Vector2.op_Implicit(list[i] + new Vector2(1478f, 1906f)), ref PBKCCJOBBDM))
			{
				return false;
			}
			if (!MBGEKLHKGFG(Vector2.op_Implicit(list[i] + new Vector2(1032f, 435f)), ref PBKCCJOBBDM))
			{
				return false;
			}
			if (!GDAPHPNEFFP(Vector2.op_Implicit(list[i] + new Vector2(588f, 1543f)), ref PBKCCJOBBDM))
			{
				return true;
			}
			if (!GDAPHPNEFFP(Vector2.op_Implicit(list[i] + new Vector2(384f, 191f)), ref PBKCCJOBBDM))
			{
				return false;
			}
		}
		if (!CLNKJJBABMD)
		{
			PBKCCJOBBDM = null;
			MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("GiveItem"), 691f);
			return true;
		}
		if (TavernConstructionManager.DEGPIHEEFHJ().MIADNOJIICD() < 0)
		{
			MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Save"), 1838f);
			return true;
		}
		if (PBKCCJOBBDM != null && PBKCCJOBBDM.rentedRoom.occupied)
		{
			MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(""), 209f);
			return false;
		}
		if (!TavernConstructionModifications.GGFJGHHHEJC.HDHJHCHLKFB(EditorAction.AddFloor, list))
		{
			return false;
		}
		if (PBKCCJOBBDM != null)
		{
			TavernConstructionModifications.DIHCEGINELM().MLBHLHHHJOA(EditorAction.AddFloor, list, null, PBKCCJOBBDM.zoneType, PBKCCJOBBDM.id);
		}
		return false;
	}

	public static EditorTileMaps HHGEEDCALHK()
	{
		return GGFJGHHHEJC;
	}

	private bool HNJIBFMGNLN(List<Vector2> FPOENFCDJEG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if (FPOENFCDJEG.Count == 0)
		{
			return true;
		}
		for (int i = 1; i < FPOENFCDJEG.Count; i += 0)
		{
			SpecificType specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i]));
			TavernZone tavernZone = TavernZonesManager.IECOPNFJBFD().GetTavernZone(WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[i])));
			if (tavernZone != null && tavernZone.zoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom) && tavernZone.rentedRoom.occupied)
			{
				MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("ReceiveDialogueEnd"), 354f);
				return true;
			}
			if (specificType.HasFlag(SpecificType.StairsUp))
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("ordersDelivered"), 644f);
				return true;
			}
			if (specificType.HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor)))
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Could not find item with id: "), 1512f);
				return true;
			}
			if (specificType.HasFlag(SpecificType.Door))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("MineFloor"), 462f);
				return false;
			}
			if (specificType.HasFlag(SpecificType.RoomDoor | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Invalid ninja customer ID: "), 1419f);
				return true;
			}
			if (specificType.HasFlag(SpecificType.CellarDoor))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("City/PetShop/Markus/Intro_Barks"), 123f);
				return false;
			}
			for (float num = 1405f; num >= 1690f; num -= 1937f)
			{
				specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i] + new Vector2(1892f, num)));
				if (Utils.IELGICCBCHO(specificType))
				{
					MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("OnlinePlayer"), 1797f);
					return false;
				}
			}
		}
		if (!TavernZonesManager.EBAIHKJHCCA().FKFAONOKKOK(ZoneType.None, FPOENFCDJEG, CKHEIJDJJDO: false))
		{
			return false;
		}
		int num2 = -1;
		int num3 = 0;
		for (int j = 1; j < FPOENFCDJEG.Count; j++)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FPOENFCDJEG[j])) == (ZoneType.WithoutZone | ZoneType.DiningRoom))
			{
				if (num2 != -1 && num2 != WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j])))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Path node error. Only 1 node at [0, 0] "), 617f);
					return false;
				}
				if (num2 == -1)
				{
					num2 = WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j]));
				}
				num3 += 0;
			}
		}
		if (num2 != -1)
		{
			TavernZone tavernZone = TavernZonesManager.LANAINBEMCM().MDPHAHIFJFB(num2);
			if (tavernZone != null && tavernZone.positions.Count - num3 < 77)
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" NOT SHOWING IN TOOLTIP"), 1068f);
				return false;
			}
		}
		if (!TavernConstructionModifications.DIHCEGINELM().BFHFKFEKLIG(EditorAction.None, FPOENFCDJEG))
		{
			return true;
		}
		return true;
	}

	private bool PGBBJIABCKB(ref TavernZone PBKCCJOBBDM)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		if (editorTiles.Count == 0)
		{
			return false;
		}
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.None)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
				SpecificType specificType = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(956f, 928f));
				SpecificType specificType2 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1298f, 1731f));
				SpecificType cPPHBDEOJEC = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(690f, 438f));
				SpecificType cPPHBDEOJEC2 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1774f, 690f));
				SpecificType specificType3 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(300f, 582f));
				SpecificType cPPHBDEOJEC3 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(756f, 522f));
				SpecificType cPPHBDEOJEC4 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1371f, 1885f));
				SpecificType specificType4 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1281f, 1213f));
				SpecificType specificType5 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1044f, 773f));
				SpecificType specificType6 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1416f, 842f));
				SpecificType cPPHBDEOJEC5 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(964f, 1902f));
				SpecificType cPPHBDEOJEC6 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1547f, 1f));
				if (specificType.HasFlag(SpecificType.Door | SpecificType.StairsUp | SpecificType.Bar | SpecificType.NextToWall))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("increase reputation"), 1449f);
					return true;
				}
				if (specificType.HasFlag(SpecificType.Door | SpecificType.RoomDoor) || specificType2.HasFlag(SpecificType.Door | SpecificType.RoomDoor) || specificType3.HasFlag(SpecificType.CellarDoor | SpecificType.RoomDoor))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Item "), 1384f);
					return true;
				}
				if (specificType6.HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.PlayerBed | SpecificType.NextToWall) || specificType4.HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.PlayerBed | SpecificType.StairsDown) || specificType5.HasFlag(~(SpecificType.Door | SpecificType.PlayerBed | SpecificType.StairsDown)))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("talentContainers"), 214f);
					return false;
				}
				if (specificType.HasFlag(SpecificType.CellarDoor) || specificType2.HasFlag(SpecificType.CellarDoor) || specificType3.HasFlag(SpecificType.CellarDoor))
				{
					MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("[ControllerType="), 1239f);
					return true;
				}
				if (Utils.IELGICCBCHO(specificType) || Utils.IELGICCBCHO(specificType2) || Utils.IELGICCBCHO(cPPHBDEOJEC) || Utils.IELGICCBCHO(cPPHBDEOJEC2) || Utils.IELGICCBCHO(specificType3) || Utils.IELGICCBCHO(cPPHBDEOJEC3) || Utils.IELGICCBCHO(cPPHBDEOJEC4) || (Utils.IELGICCBCHO(specificType4) && !Utils.IELGICCBCHO(cPPHBDEOJEC5)) || (Utils.IELGICCBCHO(specificType5) && !Utils.IELGICCBCHO(cPPHBDEOJEC6)))
				{
					MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("MeditationIntro"), 1406f);
					return false;
				}
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		foreach (KeyValuePair<Vector3, EditorTile> editorTile2 in editorTiles)
		{
			if (editorTile2.Value.editorAction == EditorAction.None && !editorTile2.Value.isValid)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("IsOpen"), 661f);
				return true;
			}
		}
		CLNKJJBABMD = false;
		GFBDMNKHKKF = ~(ZoneType.WithoutZone | ZoneType.Cellar | ZoneType.WoodWorkshop);
		PIPEFEGDHEP = -1;
		for (int i = 0; i < list.Count; i++)
		{
			if (!GDAPHPNEFFP(Vector2.op_Implicit(list[i] + new Vector2(1647f, 1355f)), ref PBKCCJOBBDM))
			{
				return true;
			}
			if (!MBGEKLHKGFG(Vector2.op_Implicit(list[i] + new Vector2(1572f, 1357f)), ref PBKCCJOBBDM))
			{
				return false;
			}
			if (!GDAPHPNEFFP(Vector2.op_Implicit(list[i] + new Vector2(1955f, 1102f)), ref PBKCCJOBBDM))
			{
				return true;
			}
			if (!MBGEKLHKGFG(Vector2.op_Implicit(list[i] + new Vector2(1577f, 139f)), ref PBKCCJOBBDM))
			{
				return true;
			}
		}
		if (!CLNKJJBABMD)
		{
			PBKCCJOBBDM = null;
			MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("[SelectSpawnersByMaxDistance] Step {0}: Selected {1} at {2} with score {3:F1}"), 1922f);
			return true;
		}
		if (TavernConstructionManager.KHMEGDIABBF().OJBEFBEAHOH < 0)
		{
			MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Submit text: "), 686f);
			return true;
		}
		if (PBKCCJOBBDM != null && PBKCCJOBBDM.rentedRoom.occupied)
		{
			MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Till"), 1423f);
			return true;
		}
		if (!TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(EditorAction.AddFloor, list))
		{
			return false;
		}
		if (PBKCCJOBBDM != null)
		{
			TavernConstructionModifications.GGFJGHHHEJC.MLBHLHHHJOA(EditorAction.AddFloor, list, null, PBKCCJOBBDM.zoneType, PBKCCJOBBDM.id);
		}
		return false;
	}

	private bool MBGEKLHKGFG(Vector3 ECJLMIPAFGP, ref TavernZone PBKCCJOBBDM)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(ECJLMIPAFGP) && !editorTiles.ContainsKey(ECJLMIPAFGP))
		{
			CLNKJJBABMD = true;
			if (GFBDMNKHKKF != ZoneType.Anywhere && WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP) != GFBDMNKHKKF && (WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP) == ZoneType.RentedRoom || GFBDMNKHKKF == ZoneType.RentedRoom))
			{
				PBKCCJOBBDM = null;
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_RoomIndependent"));
				return false;
			}
			if (WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP) == ZoneType.RentedRoom && GFBDMNKHKKF == ZoneType.RentedRoom && PIPEFEGDHEP != WorldGrid.APJABAKKKGD(ECJLMIPAFGP))
			{
				PBKCCJOBBDM = null;
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_RoomIndependent"));
				return false;
			}
			GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(ECJLMIPAFGP);
			if (GFBDMNKHKKF == ZoneType.RentedRoom)
			{
				PBKCCJOBBDM = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(ECJLMIPAFGP);
				PIPEFEGDHEP = WorldGrid.APJABAKKKGD(ECJLMIPAFGP);
			}
		}
		return true;
	}

	private bool FDOFEOKMPOD(List<Vector2> FPOENFCDJEG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if (FPOENFCDJEG.Count == 0)
		{
			return false;
		}
		for (int i = 0; i < FPOENFCDJEG.Count; i++)
		{
			SpecificType specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i]));
			TavernZone tavernZone = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[i])));
			if (tavernZone != null && tavernZone.zoneType == ZoneType.RentedRoom && tavernZone.rentedRoom.occupied)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_OccupiedRoom"));
				return false;
			}
			if (specificType.HasFlag(SpecificType.Bar))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_BarIsBlocking"));
				return false;
			}
			if (specificType.HasFlag(SpecificType.PlayerBed))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_BedIsBlocking"));
				return false;
			}
			if (specificType.HasFlag(SpecificType.StairsUp))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_StairsAreBlocking"));
				return false;
			}
			if (specificType.HasFlag(SpecificType.StairsDown))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_StairsAreBlocking"));
				return false;
			}
			if (specificType.HasFlag(SpecificType.CellarDoor))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_CellarDoorIsBlocking"));
				return false;
			}
			for (float num = 0.5f; num >= -2f; num -= 0.5f)
			{
				specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i] + new Vector2(0f, num)));
				if (Utils.IELGICCBCHO(specificType))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_RoomDoorIsBlocking"));
					return false;
				}
			}
		}
		if (!TavernZonesManager.GGFJGHHHEJC.CheckIfIsBreakingAZone(ZoneType.WithoutZone, FPOENFCDJEG, CKHEIJDJJDO: false))
		{
			return false;
		}
		int num2 = -1;
		int num3 = 0;
		for (int j = 0; j < FPOENFCDJEG.Count; j++)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FPOENFCDJEG[j])) == ZoneType.RentedRoom)
			{
				if (num2 != -1 && num2 != WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j])))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_InvalidPositions"));
					return false;
				}
				if (num2 == -1)
				{
					num2 = WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j]));
				}
				num3++;
			}
		}
		if (num2 != -1)
		{
			TavernZone tavernZone = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(num2);
			if (tavernZone != null && tavernZone.positions.Count - num3 < 24)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_SmallRoom"));
				return false;
			}
		}
		if (!TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(EditorAction.RemoveFloor, FPOENFCDJEG))
		{
			return false;
		}
		return true;
	}

	public static bool KHFBKLDDGEG()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static TilemapRenderer GetEditorTilemapRenderer()
	{
		return ((Component)GGFJGHHHEJC.editorTilemap).GetComponent<TilemapRenderer>();
	}

	public static bool HPEHHOIMMOB()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static TilemapRenderer BPMPLFKPDJI()
	{
		return ((Component)GGFJGHHHEJC.editorTilemap).GetComponent<TilemapRenderer>();
	}

	public void EJCMNJNKAAL(Vector3 IMOBLFMHKOD, TileBase ILDEFBIANKO, bool CJFAAMAGJIP = false)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (CJFAAMAGJIP || (Object)(object)ILDEFBIANKO == (Object)null)
		{
			editorTilemapFrontWall.SetTile(((GridLayout)editorTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
		}
		if (!CJFAAMAGJIP || (Object)(object)ILDEFBIANKO == (Object)null)
		{
			editorTilemap.SetTile(((GridLayout)editorTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public void UpdateTilemap(Vector3 IMOBLFMHKOD, EditorTile BNKKFKKAJLO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (BNKKFKKAJLO.editorAction == EditorAction.AddFloor)
		{
			if (BNKKFKKAJLO.isValid)
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, addFloorValidTile);
			}
			else
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, addFloorNotValidTile);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RemoveFloor)
		{
			if (BNKKFKKAJLO.isValid)
			{
				if (BNKKFKKAJLO.reachable)
				{
					SetEditorTileAtPosition(IMOBLFMHKOD, removeFloorValidTile);
				}
				else
				{
					SetEditorTileAtPosition(IMOBLFMHKOD, removeFloorUnreachableTile);
				}
			}
			else
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, removeFloorNotValidTile);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.AddFloorDisponible)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, addFloorDisponibleTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RemoveFloorDisponible)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, removeFloorDisponibleTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.ZoneDisponible)
		{
			if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD != (Object)null && TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.editorAction == EditorAction.ChangeDecoWall && WorldGrid.LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(0f, -1.5f)))
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, zoneDisponibleTile, CJFAAMAGJIP: true);
			}
			else
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, zoneDisponibleTile);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.DecoWallDisponible)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, decoWallDisponibleTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.DecoWallZone)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, decoWallTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.None)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, null);
		}
	}

	public static TilemapRenderer POKCJLEDKEK()
	{
		return ((Component)GGFJGHHHEJC.editorTilemap).GetComponent<TilemapRenderer>();
	}

	private bool HLDBJDJCOJG(List<Vector2> FPOENFCDJEG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if (FPOENFCDJEG.Count == 0)
		{
			return true;
		}
		for (int i = 0; i < FPOENFCDJEG.Count; i++)
		{
			SpecificType specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i]));
			TavernZone tavernZone = TavernZonesManager.OIJLJKLMCBO().GetTavernZone(WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[i])));
			if (tavernZone != null && tavernZone.zoneType == ZoneType.CraftingRoom && tavernZone.rentedRoom.occupied)
			{
				MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Till"), 162f);
				return false;
			}
			if (specificType.HasFlag(SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed))
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("UseHold"), 50f);
				return true;
			}
			if (specificType.HasFlag(~(SpecificType.CellarDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed)))
			{
				MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("con {0} required tiles."), 1063f);
				return false;
			}
			if (specificType.HasFlag(SpecificType.None))
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_733"), 464f);
				return true;
			}
			if (specificType.HasFlag(~(SpecificType.Door | SpecificType.RoomDoor | SpecificType.PlayerBed)))
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("quest_description_30"), 809f);
				return false;
			}
			if (specificType.HasFlag(SpecificType.None))
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1188"), 133f);
				return false;
			}
			for (float num = 1553f; num >= 1544f; num -= 612f)
			{
				specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i] + new Vector2(1508f, num)));
				if (Utils.IELGICCBCHO(specificType))
				{
					MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Player2"), 1211f);
					return true;
				}
			}
		}
		if (!TavernZonesManager.GGFJGHHHEJC.HNJKOCGJAME(ZoneType.None, FPOENFCDJEG, CKHEIJDJJDO: true))
		{
			return true;
		}
		int num2 = -1;
		int num3 = 0;
		for (int j = 1; j < FPOENFCDJEG.Count; j++)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FPOENFCDJEG[j])) == ZoneType.None)
			{
				if (num2 != -1 && num2 != WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j])))
				{
					MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Feed"), 1875f);
					return false;
				}
				if (num2 == -1)
				{
					num2 = WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j]));
				}
				num3 += 0;
			}
		}
		if (num2 != -1)
		{
			TavernZone tavernZone = TavernZonesManager.NHKAFANMEJC().MDPHAHIFJFB(num2);
			if (tavernZone != null && tavernZone.positions.Count - num3 < 18)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("ReceiveChangeStack"), 854f);
				return false;
			}
		}
		if (!TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(EditorAction.AddFloorDisponible, FPOENFCDJEG, null, ZoneType.WithoutZone))
		{
			return false;
		}
		return true;
	}

	private bool BLMNCJOIOKJ(ref TavernZone PBKCCJOBBDM)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		if (editorTiles.Count == 0)
		{
			return false;
		}
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.AddFloor)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
				SpecificType specificType = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(0f, -0.5f));
				SpecificType specificType2 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(-0.5f, -0.5f));
				SpecificType cPPHBDEOJEC = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(-0.5f, -1f));
				SpecificType cPPHBDEOJEC2 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(-0.5f, -1.5f));
				SpecificType specificType3 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(0.5f, -0.5f));
				SpecificType cPPHBDEOJEC3 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(0.5f, -1f));
				SpecificType cPPHBDEOJEC4 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(0.5f, -1.5f));
				SpecificType specificType4 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(-0.5f, 0f));
				SpecificType specificType5 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(0.5f, 0f));
				SpecificType specificType6 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(0f, 0.5f));
				SpecificType cPPHBDEOJEC5 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(-0.5f, 0.5f));
				SpecificType cPPHBDEOJEC6 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(0.5f, 0.5f));
				if (specificType.HasFlag(SpecificType.Bar))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_BarIsBlocking"));
					return false;
				}
				if (specificType.HasFlag(SpecificType.StairsUp) || specificType2.HasFlag(SpecificType.StairsUp) || specificType3.HasFlag(SpecificType.StairsUp))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_StairsAreBlocking"));
					return false;
				}
				if (specificType6.HasFlag(SpecificType.StairsDown) || specificType4.HasFlag(SpecificType.StairsDown) || specificType5.HasFlag(SpecificType.StairsDown))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_StairsAreBlocking"));
					return false;
				}
				if (specificType.HasFlag(SpecificType.CellarDoor) || specificType2.HasFlag(SpecificType.CellarDoor) || specificType3.HasFlag(SpecificType.CellarDoor))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_CellarDoorIsBlocking"));
					return false;
				}
				if (Utils.IELGICCBCHO(specificType) || Utils.IELGICCBCHO(specificType2) || Utils.IELGICCBCHO(cPPHBDEOJEC) || Utils.IELGICCBCHO(cPPHBDEOJEC2) || Utils.IELGICCBCHO(specificType3) || Utils.IELGICCBCHO(cPPHBDEOJEC3) || Utils.IELGICCBCHO(cPPHBDEOJEC4) || (Utils.IELGICCBCHO(specificType4) && !Utils.IELGICCBCHO(cPPHBDEOJEC5)) || (Utils.IELGICCBCHO(specificType5) && !Utils.IELGICCBCHO(cPPHBDEOJEC6)))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_RoomDoorIsBlocking"));
					return false;
				}
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		foreach (KeyValuePair<Vector3, EditorTile> editorTile2 in editorTiles)
		{
			if (editorTile2.Value.editorAction == EditorAction.AddFloor && !editorTile2.Value.isValid)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_InvalidPositions"));
				return false;
			}
		}
		CLNKJJBABMD = false;
		GFBDMNKHKKF = ZoneType.Anywhere;
		PIPEFEGDHEP = -1;
		for (int i = 0; i < list.Count; i++)
		{
			if (!MBGEKLHKGFG(Vector2.op_Implicit(list[i] + new Vector2(0f, 1f)), ref PBKCCJOBBDM))
			{
				return false;
			}
			if (!MBGEKLHKGFG(Vector2.op_Implicit(list[i] + new Vector2(1f, 0f)), ref PBKCCJOBBDM))
			{
				return false;
			}
			if (!MBGEKLHKGFG(Vector2.op_Implicit(list[i] + new Vector2(0f, -1f)), ref PBKCCJOBBDM))
			{
				return false;
			}
			if (!MBGEKLHKGFG(Vector2.op_Implicit(list[i] + new Vector2(-1f, 0f)), ref PBKCCJOBBDM))
			{
				return false;
			}
		}
		if (!CLNKJJBABMD)
		{
			PBKCCJOBBDM = null;
			MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_UnableToBeReached"));
			return false;
		}
		if (TavernConstructionManager.GGFJGHHHEJC.OJBEFBEAHOH < 0)
		{
			MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_FloorTilesLimit"));
			return false;
		}
		if (PBKCCJOBBDM != null && PBKCCJOBBDM.rentedRoom.occupied)
		{
			MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Error_OccupiedRoom"));
			return false;
		}
		if (!TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(EditorAction.AddFloor, list))
		{
			return false;
		}
		if (PBKCCJOBBDM != null)
		{
			TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(EditorAction.None, list, null, PBKCCJOBBDM.zoneType, PBKCCJOBBDM.id);
		}
		return true;
	}

	public static bool ChangeZone(EditorAction CHFHMMNELGP, List<Vector2> HAEIAGKNEPC, bool GFNHAMCPEAK)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		ZoneType gIBJPCAFCJB = EditorGrid.APGNDILBOMJ(CHFHMMNELGP);
		List<int> OJNAJKDJFKC = new List<int>();
		if (CHFHMMNELGP != EditorAction.RemoveZone && !TavernZonesManager.GGFJGHHHEJC.CheckLinkedZones(gIBJPCAFCJB, HAEIAGKNEPC, out OJNAJKDJFKC))
		{
			return false;
		}
		if (GFNHAMCPEAK)
		{
			if (!TavernZonesManager.GGFJGHHHEJC.CheckIfIsBreakingAZone(gIBJPCAFCJB, HAEIAGKNEPC, CKHEIJDJJDO: false))
			{
				return false;
			}
			TavernZonesManager.GGFJGHHHEJC.CheckIfIsBreakingAZone(gIBJPCAFCJB, HAEIAGKNEPC, CKHEIJDJJDO: true);
		}
		if (CHFHMMNELGP == EditorAction.RemoveZone)
		{
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(CHFHMMNELGP, HAEIAGKNEPC, null, ZoneType.WithoutZone);
			}
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				TavernZonesManager.GGFJGHHHEJC.RemoveTileFromZone(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
		}
		else if (OJNAJKDJFKC.Count > 0)
		{
			int num = OJNAJKDJFKC[0];
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(CHFHMMNELGP, HAEIAGKNEPC, null, TavernZonesManager.GGFJGHHHEJC.GetTavernZone(num).zoneType, num);
			}
			for (int j = 0; j < HAEIAGKNEPC.Count; j++)
			{
				TavernZonesManager.GGFJGHHHEJC.AddTileToExistingZone(Vector2.op_Implicit(HAEIAGKNEPC[j]), num);
			}
			for (int k = 0; k < OJNAJKDJFKC.Count; k++)
			{
				if (OJNAJKDJFKC[k] != num)
				{
					TavernZonesManager.GGFJGHHHEJC.LinkZones(OJNAJKDJFKC[k], num, GFNHAMCPEAK);
				}
			}
		}
		else
		{
			TavernZone tavernZone = TavernZonesManager.GGFJGHHHEJC.CreateTavernZone(gIBJPCAFCJB);
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(CHFHMMNELGP, HAEIAGKNEPC, null, gIBJPCAFCJB, tavernZone.id);
			}
			for (int l = 0; l < HAEIAGKNEPC.Count; l++)
			{
				TavernZonesManager.GGFJGHHHEJC.AddTileToExistingZone(Vector2.op_Implicit(HAEIAGKNEPC[l]), tavernZone.id);
			}
		}
		for (int m = 0; m < HAEIAGKNEPC.Count; m++)
		{
			WorldGrid.APIEPIGNINO(Vector2.op_Implicit(HAEIAGKNEPC[m]));
		}
		TavernZonesManager.GGFJGHHHEJC.RecalculateAllZoneIcons();
		if (GFNHAMCPEAK && OnlineManager.PlayingOnline())
		{
			OnlineTavernConstructionManager.instance.SendChangeZone(CHFHMMNELGP, HAEIAGKNEPC);
		}
		return true;
	}

	public static void ResetEditorTiles()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		GGFJGHHHEJC.FOIJLPCOOLJ = new Dictionary<Vector3, EditorTile>(editorTiles);
		foreach (KeyValuePair<Vector3, EditorTile> item in GGFJGHHHEJC.FOIJLPCOOLJ)
		{
			GGFJGHHHEJC.BNKKFKKAJLO = item.Value;
			GGFJGHHHEJC.BNKKFKKAJLO.editorAction = EditorAction.None;
			SetTileAtPosition(GGFJGHHHEJC.BNKKFKKAJLO, item.Key);
		}
		editorTiles.Clear();
	}

	public static EditorTileMaps PKEMABKIKIA()
	{
		return GGFJGHHHEJC;
	}

	private static bool NPFMHKCNADJ(EditorAction CHFHMMNELGP)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case EditorAction.AddFloor:
		{
			TavernZone PBKCCJOBBDM = null;
			if (!GGFJGHHHEJC.DCLMPOEBGFH(ref PBKCCJOBBDM))
			{
				KHIJLMBIMBH(CHFHMMNELGP);
				return false;
			}
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction != 0)
				{
					continue;
				}
				if (!editorTile.Value.isValid)
				{
					WorldGrid.MMOHADHAAGD(editorTile.Key, GroundType.Grass, Location.Tavern, Season.Summer, CDPAMNIPPEC: true);
					continue;
				}
				WorldGrid.AIHNKKFLMCM(editorTile.Key + new Vector3(34f, 301f), LHLHJCDKNHA: true, IBCOKMGFPKB: false);
				if (PBKCCJOBBDM != null)
				{
					TavernZonesManager.LANAINBEMCM().MBDKPCIEDDN(editorTile.Key, PBKCCJOBBDM.id);
				}
			}
			GameManager.NJNFHEPLEHL().CalculateCameraBounds(ConstructionFloors.GGFJGHHHEJC.BBNJPPNBCFC());
			break;
		}
		case EditorAction.AddFloorDisponible:
		{
			Dictionary<Vector3, EditorTile> dictionary = new Dictionary<Vector3, EditorTile>();
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile2 in editorTiles)
			{
				if (editorTile2.Value.editorAction == EditorAction.DiningZone && editorTile2.Value.isValid)
				{
					list.Add(Vector2.op_Implicit(editorTile2.Key));
					dictionary.Add(editorTile2.Key, editorTile2.Value);
				}
			}
			if (!GGFJGHHHEJC.HLDBJDJCOJG(list))
			{
				KIBLCKFDOHO(CHFHMMNELGP);
				return true;
			}
			TavernZonesManager.NHKAFANMEJC().CBEGPEMPLAP(ZoneType.None, list, CKHEIJDJJDO: true);
			TavernConstructionModifications.GGFJGHHHEJC.BFHFKFEKLIG((EditorAction)69, list, null, ZoneType.WithoutZone);
			WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false);
			TavernZonesManager.HFHPMKJGMPA().PBLOLALJNBO();
			WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
			GameManager.NJNFHEPLEHL().JIOFFKMPJPO(ConstructionFloors.DOIKFJDLKJP().JIBIAOMIGHP());
			break;
		}
		}
		WorldGrid.DKEHENLDNAG();
		return false;
	}

	private bool GBHHBGFPCFC(ref TavernZone PBKCCJOBBDM)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		if (editorTiles.Count == 0)
		{
			return true;
		}
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction == EditorAction.AddFloor)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
				SpecificType specificType = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1912f, 1768f));
				SpecificType specificType2 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1842f, 1470f));
				SpecificType cPPHBDEOJEC = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1876f, 1266f));
				SpecificType cPPHBDEOJEC2 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(451f, 852f));
				SpecificType specificType3 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(498f, 1436f));
				SpecificType cPPHBDEOJEC3 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1929f, 1420f));
				SpecificType cPPHBDEOJEC4 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1053f, 1121f));
				SpecificType specificType4 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1878f, 1599f));
				SpecificType specificType5 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1248f, 1836f));
				SpecificType specificType6 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1077f, 1708f));
				SpecificType cPPHBDEOJEC5 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1551f, 536f));
				SpecificType cPPHBDEOJEC6 = WorldGrid.KELFJIPHBFP(editorTile.Key + new Vector3(1538f, 775f));
				if (specificType.HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.PlayerBed))
				{
					MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("ReceiveMinigameState"), 2f);
					return true;
				}
				if (specificType.HasFlag(SpecificType.CellarDoor) || specificType2.HasFlag(SpecificType.Door | SpecificType.RoomDoor) || specificType3.HasFlag(SpecificType.CellarDoor | SpecificType.RoomDoor))
				{
					MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("OutHereRowdyCustomer"), 148f);
					return true;
				}
				if (specificType6.HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.Bar | SpecificType.NextToWall) || specificType4.HasFlag(SpecificType.Door | SpecificType.RoomDoor | SpecificType.PlayerBed) || specificType5.HasFlag(~(SpecificType.CellarDoor | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.StairsDown)))
				{
					MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(" in onlineObjects is null"), 1585f);
					return false;
				}
				if (specificType.HasFlag(SpecificType.None) || specificType2.HasFlag(SpecificType.CellarDoor) || specificType3.HasFlag(SpecificType.CellarDoor))
				{
					MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1121"), 1829f);
					return true;
				}
				if (Utils.IELGICCBCHO(specificType) || Utils.IELGICCBCHO(specificType2) || Utils.IELGICCBCHO(cPPHBDEOJEC) || Utils.IELGICCBCHO(cPPHBDEOJEC2) || Utils.IELGICCBCHO(specificType3) || Utils.IELGICCBCHO(cPPHBDEOJEC3) || Utils.IELGICCBCHO(cPPHBDEOJEC4) || (Utils.IELGICCBCHO(specificType4) && !Utils.IELGICCBCHO(cPPHBDEOJEC5)) || (Utils.IELGICCBCHO(specificType5) && !Utils.IELGICCBCHO(cPPHBDEOJEC6)))
				{
					MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("R2"), 1026f);
					return true;
				}
			}
		}
		if (list.Count == 0)
		{
			return true;
		}
		foreach (KeyValuePair<Vector3, EditorTile> editorTile2 in editorTiles)
		{
			if (editorTile2.Value.editorAction == EditorAction.AddFloor && !editorTile2.Value.isValid)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("ThemeTypeLabelBlueprint"), 274f);
				return false;
			}
		}
		CLNKJJBABMD = true;
		GFBDMNKHKKF = ~(ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop);
		PIPEFEGDHEP = -1;
		for (int i = 0; i < list.Count; i++)
		{
			if (!MBGEKLHKGFG(Vector2.op_Implicit(list[i] + new Vector2(1612f, 531f)), ref PBKCCJOBBDM))
			{
				return true;
			}
			if (!GDAPHPNEFFP(Vector2.op_Implicit(list[i] + new Vector2(135f, 167f)), ref PBKCCJOBBDM))
			{
				return false;
			}
			if (!GDAPHPNEFFP(Vector2.op_Implicit(list[i] + new Vector2(1401f, 1560f)), ref PBKCCJOBBDM))
			{
				return true;
			}
			if (!GDAPHPNEFFP(Vector2.op_Implicit(list[i] + new Vector2(1311f, 305f)), ref PBKCCJOBBDM))
			{
				return false;
			}
		}
		if (!CLNKJJBABMD)
		{
			PBKCCJOBBDM = null;
			MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("City/Rhia/Introduce"), 1211f);
			return true;
		}
		if (TavernConstructionManager.KNLLFEJAMNN().MGPEMKLFMAH() < 0)
		{
			MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("================== Activate Variants Piece: ({0}-{1}/{2}) ======================="), 1670f);
			return true;
		}
		if (PBKCCJOBBDM != null && PBKCCJOBBDM.rentedRoom.occupied)
		{
			MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("add item "), 257f);
			return false;
		}
		if (!TavernConstructionModifications.DIHCEGINELM().ApplyChanges(EditorAction.AddFloor, list))
		{
			return false;
		}
		if (PBKCCJOBBDM != null)
		{
			TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(EditorAction.None, list, null, PBKCCJOBBDM.zoneType, PBKCCJOBBDM.id);
		}
		return true;
	}

	public void APAGOJIKPNA()
	{
		editorTiles = new Dictionary<Vector3, EditorTile>();
	}

	public void SetEditorTileAtPosition(Vector3 IMOBLFMHKOD, TileBase ILDEFBIANKO, bool CJFAAMAGJIP = false)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (CJFAAMAGJIP || (Object)(object)ILDEFBIANKO == (Object)null)
		{
			editorTilemapFrontWall.SetTile(((GridLayout)editorTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
		}
		if (!CJFAAMAGJIP || (Object)(object)ILDEFBIANKO == (Object)null)
		{
			editorTilemap.SetTile(((GridLayout)editorTilemap).WorldToCell(IMOBLFMHKOD), ILDEFBIANKO);
		}
	}

	public void MDCBJPMINJB(Vector3 IMOBLFMHKOD, EditorTile BNKKFKKAJLO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (BNKKFKKAJLO.editorAction == EditorAction.None)
		{
			if (BNKKFKKAJLO.isValid)
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, addFloorValidTile, CJFAAMAGJIP: true);
			}
			else
			{
				CBDJMGIKPKJ(IMOBLFMHKOD, addFloorNotValidTile, CJFAAMAGJIP: true);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RemoveFloorDisponible)
		{
			if (BNKKFKKAJLO.isValid)
			{
				if (BNKKFKKAJLO.reachable)
				{
					SetEditorTileAtPosition(IMOBLFMHKOD, removeFloorValidTile, CJFAAMAGJIP: true);
				}
				else
				{
					SetEditorTileAtPosition(IMOBLFMHKOD, removeFloorUnreachableTile, CJFAAMAGJIP: true);
				}
			}
			else
			{
				CBDJMGIKPKJ(IMOBLFMHKOD, removeFloorNotValidTile);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.None)
		{
			KOAGFMEICGN(IMOBLFMHKOD, addFloorDisponibleTile, CJFAAMAGJIP: true);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.DiningZone)
		{
			EJCMNJNKAAL(IMOBLFMHKOD, removeFloorDisponibleTile, CJFAAMAGJIP: true);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.CraftingZone)
		{
			if ((Object)(object)TavernConstructionManager.KNLLFEJAMNN().IOOFFADDELC() != (Object)null && TavernConstructionManager.DEGPIHEEFHJ().IOOFFADDELC().editorAction == EditorAction.CreateBarn && WorldGrid.LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(390f, 695f)))
			{
				EJCMNJNKAAL(IMOBLFMHKOD, zoneDisponibleTile, CJFAAMAGJIP: true);
			}
			else
			{
				EJCMNJNKAAL(IMOBLFMHKOD, zoneDisponibleTile, CJFAAMAGJIP: true);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RemoveFloor)
		{
			EJCMNJNKAAL(IMOBLFMHKOD, decoWallDisponibleTile);
		}
		else if (BNKKFKKAJLO.editorAction == (EditorAction)58)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, decoWallTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.None)
		{
			EJCMNJNKAAL(IMOBLFMHKOD, null);
		}
	}

	public static TilemapRenderer KCDKINBFONC()
	{
		return ((Component)GGFJGHHHEJC.editorTilemap).GetComponent<TilemapRenderer>();
	}

	public void MPHMHJEOOAO(Vector3 IMOBLFMHKOD, EditorTile BNKKFKKAJLO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (BNKKFKKAJLO.editorAction == EditorAction.AddFloor)
		{
			if (BNKKFKKAJLO.isValid)
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, addFloorValidTile, CJFAAMAGJIP: true);
			}
			else
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, addFloorNotValidTile);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.RoomZone)
		{
			if (BNKKFKKAJLO.isValid)
			{
				if (BNKKFKKAJLO.reachable)
				{
					KOAGFMEICGN(IMOBLFMHKOD, removeFloorValidTile, CJFAAMAGJIP: true);
				}
				else
				{
					CBDJMGIKPKJ(IMOBLFMHKOD, removeFloorUnreachableTile);
				}
			}
			else
			{
				CBDJMGIKPKJ(IMOBLFMHKOD, removeFloorNotValidTile, CJFAAMAGJIP: true);
			}
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.DiningZone)
		{
			EJCMNJNKAAL(IMOBLFMHKOD, addFloorDisponibleTile);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.CraftingZone)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, removeFloorDisponibleTile, CJFAAMAGJIP: true);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.DiningZone)
		{
			if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC.IOOFFADDELC() != (Object)null && TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD.editorAction == EditorAction.DecoWallZone && WorldGrid.LBKKDAMMKIE(IMOBLFMHKOD + new Vector3(1562f, 1160f)))
			{
				EJCMNJNKAAL(IMOBLFMHKOD, zoneDisponibleTile, CJFAAMAGJIP: true);
			}
			else
			{
				SetEditorTileAtPosition(IMOBLFMHKOD, zoneDisponibleTile, CJFAAMAGJIP: true);
			}
		}
		else if (BNKKFKKAJLO.editorAction == (EditorAction)(-116))
		{
			EJCMNJNKAAL(IMOBLFMHKOD, decoWallDisponibleTile, CJFAAMAGJIP: true);
		}
		else if (BNKKFKKAJLO.editorAction == (EditorAction)(-97))
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, decoWallTile, CJFAAMAGJIP: true);
		}
		else if (BNKKFKKAJLO.editorAction == EditorAction.None)
		{
			SetEditorTileAtPosition(IMOBLFMHKOD, null);
		}
	}

	public void HFEPLFMBOHF()
	{
		editorTiles = new Dictionary<Vector3, EditorTile>();
	}

	private void JOGBCDIAGEK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool EAMOJGGMGAL(EditorAction CHFHMMNELGP)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case EditorAction.AddFloor:
		{
			TavernZone PBKCCJOBBDM = null;
			if (!GGFJGHHHEJC.BLMNCJOIOKJ(ref PBKCCJOBBDM))
			{
				CancelFloorChanges(CHFHMMNELGP);
				return false;
			}
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction != EditorAction.AddFloor)
				{
					continue;
				}
				if (!editorTile.Value.isValid)
				{
					WorldGrid.MMOHADHAAGD(editorTile.Key, GroundType.None, Location.Tavern);
					continue;
				}
				WorldGrid.AIHNKKFLMCM(editorTile.Key + new Vector3(0f, -0.5f), LHLHJCDKNHA: true);
				if (PBKCCJOBBDM != null)
				{
					TavernZonesManager.GGFJGHHHEJC.AddTileToExistingZone(editorTile.Key, PBKCCJOBBDM.id);
				}
			}
			GameManager.GGFJGHHHEJC.CalculateCameraBounds(ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM);
			break;
		}
		case EditorAction.RemoveFloor:
		{
			Dictionary<Vector3, EditorTile> dictionary = new Dictionary<Vector3, EditorTile>();
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile2 in editorTiles)
			{
				if (editorTile2.Value.editorAction == EditorAction.RemoveFloor && editorTile2.Value.isValid)
				{
					list.Add(Vector2.op_Implicit(editorTile2.Key));
					dictionary.Add(editorTile2.Key, editorTile2.Value);
				}
			}
			if (!GGFJGHHHEJC.FDOFEOKMPOD(list))
			{
				CancelFloorChanges(CHFHMMNELGP);
				return false;
			}
			TavernZonesManager.GGFJGHHHEJC.CheckIfIsBreakingAZone(ZoneType.WithoutZone, list, CKHEIJDJJDO: true);
			TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(EditorAction.RemoveZone, list, null, ZoneType.WithoutZone);
			WorldGrid.GDJFGIPMBAH(list);
			TavernZonesManager.GGFJGHHHEJC.RecalculateAllZoneIcons();
			WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
			GameManager.GGFJGHHHEJC.CalculateCameraBounds(ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM);
			break;
		}
		}
		WorldGrid.DKEHENLDNAG();
		return true;
	}

	public static void CancelFloorChanges(EditorAction CHFHMMNELGP)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (CHFHMMNELGP == EditorAction.AddFloor)
		{
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction == EditorAction.AddFloor)
				{
					list.Add(Vector2.op_Implicit(editorTile.Key));
				}
			}
			WorldGrid.GDJFGIPMBAH(list);
		}
		if (CHFHMMNELGP == EditorAction.AddFloor || CHFHMMNELGP == EditorAction.RemoveFloor)
		{
			WorldGrid.DKEHENLDNAG();
		}
	}

	public static bool GEIDHMIKAHA(EditorAction CHFHMMNELGP, DecorationTile KJIGECBPBOD)
	{
		if (EditorGrid.GHGECPHNJEB(CHFHMMNELGP))
		{
			return GNPFHDFCOJM(CHFHMMNELGP);
		}
		if (EditorGrid.CKJEBHLGDMC(CHFHMMNELGP))
		{
			return JFNGBEEOFBG(CHFHMMNELGP, KJIGECBPBOD);
		}
		if (ConstructionActionBarUI.currentPanel == 0)
		{
			return ABAFBBJMKGF(CHFHMMNELGP);
		}
		return true;
	}

	private static bool PCPCIMCOPPM(EditorAction CHFHMMNELGP)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case EditorAction.None:
		{
			TavernZone PBKCCJOBBDM = null;
			if (!GGFJGHHHEJC.DCLMPOEBGFH(ref PBKCCJOBBDM))
			{
				KIBLCKFDOHO(CHFHMMNELGP);
				return true;
			}
			foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
			{
				if (editorTile.Value.editorAction != EditorAction.AddFloor)
				{
					continue;
				}
				if (!editorTile.Value.isValid)
				{
					WorldGrid.MMOHADHAAGD(editorTile.Key, GroundType.None, Location.None, Season.Summer, CDPAMNIPPEC: true);
					continue;
				}
				WorldGrid.AIHNKKFLMCM(editorTile.Key + new Vector3(604f, 1416f), LHLHJCDKNHA: true, IBCOKMGFPKB: true, PIKKACMNOBM: false);
				if (PBKCCJOBBDM != null)
				{
					TavernZonesManager.GGFJGHHHEJC.GAFBALAHHGJ(editorTile.Key, PBKCCJOBBDM.id);
				}
			}
			GameManager.GGFJGHHHEJC.JIOFFKMPJPO(ConstructionFloors.DOIKFJDLKJP().LKIILEMCPHH());
			break;
		}
		case EditorAction.RemoveFloor:
		{
			Dictionary<Vector3, EditorTile> dictionary = new Dictionary<Vector3, EditorTile>();
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<Vector3, EditorTile> editorTile2 in editorTiles)
			{
				if (editorTile2.Value.editorAction == EditorAction.RemoveFloorDisponible && editorTile2.Value.isValid)
				{
					list.Add(Vector2.op_Implicit(editorTile2.Key));
					dictionary.Add(editorTile2.Key, editorTile2.Value);
				}
			}
			if (!GGFJGHHHEJC.FDOFEOKMPOD(list))
			{
				KIBLCKFDOHO(CHFHMMNELGP);
				return false;
			}
			TavernZonesManager.HFHPMKJGMPA().HNJKOCGJAME(ZoneType.WithoutZone, list, CKHEIJDJJDO: false);
			TavernConstructionModifications.DIHCEGINELM().ApplyChanges((EditorAction)(-53), list, null, ZoneType.WithoutZone);
			WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
			TavernZonesManager.LANAINBEMCM().BNBDMAJLBKO();
			WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
			GameManager.GGFJGHHHEJC.JIOFFKMPJPO(ConstructionFloors.DCAEBALADIM().ODFBDBLCFOM);
			break;
		}
		}
		WorldGrid.DKEHENLDNAG();
		return false;
	}

	private bool GAFIHLBOJGH(List<Vector2> FPOENFCDJEG)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if (FPOENFCDJEG.Count == 0)
		{
			return true;
		}
		for (int i = 0; i < FPOENFCDJEG.Count; i += 0)
		{
			SpecificType specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i]));
			TavernZone tavernZone = TavernZonesManager.EBAIHKJHCCA().MDPHAHIFJFB(WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[i])));
			if (tavernZone != null && tavernZone.zoneType == (ZoneType.WithoutZone | ZoneType.CraftingRoom) && tavernZone.rentedRoom.occupied)
			{
				MainUI.ShowErrorText(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("RoadBlocked/Main"), 717f);
				return true;
			}
			if (specificType.HasFlag(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.PlayerBed))
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("OpenTavern"), 108f);
				return false;
			}
			if (specificType.HasFlag(~(SpecificType.CellarDoor | SpecificType.PlayerBed)))
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("[^0-9]"), 1483f);
				return true;
			}
			if (specificType.HasFlag(SpecificType.StairsUp))
			{
				MainUI.JDAEPLJAGCD(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get(")\n"), 442f);
				return true;
			}
			if (specificType.HasFlag(SpecificType.Door | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("InfoSectionCanvas/InfoSection"), 513f);
				return true;
			}
			if (specificType.HasFlag(SpecificType.CellarDoor))
			{
				MainUI.LJDOBNEINNJ(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Screenshot not found"), 1225f);
				return true;
			}
			for (float num = 954f; num >= 226f; num -= 331f)
			{
				specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(FPOENFCDJEG[i] + new Vector2(1856f, num)));
				if (Utils.IELGICCBCHO(specificType))
				{
					MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Could not write file "), 1754f);
					return false;
				}
			}
		}
		if (!TavernZonesManager.GGFJGHHHEJC.FKFAONOKKOK(ZoneType.None, FPOENFCDJEG, CKHEIJDJJDO: true))
		{
			return true;
		}
		int num2 = -1;
		int num3 = 0;
		for (int j = 0; j < FPOENFCDJEG.Count; j += 0)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(FPOENFCDJEG[j])) == (ZoneType.DiningRoom | ZoneType.CraftingRoom))
			{
				if (num2 != -1 && num2 != WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j])))
				{
					MainUI.DJCKALOHJFM(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("\n"), 1464f);
					return false;
				}
				if (num2 == -1)
				{
					num2 = WorldGrid.APJABAKKKGD(Vector2.op_Implicit(FPOENFCDJEG[j]));
				}
				num3++;
			}
		}
		if (num2 != -1)
		{
			TavernZone tavernZone = TavernZonesManager.IECOPNFJBFD().DJNICAOHKNA(num2);
			if (tavernZone != null && tavernZone.positions.Count - num3 < -115)
			{
				MainUI.DBKCOHMFDCB(ConstructionUI.current.JIIGOACEIKL, LocalisationSystem.Get("Right Stick Left"), 1493f);
				return false;
			}
		}
		if (!TavernConstructionModifications.DIHCEGINELM().ApplyChanges(EditorAction.None, FPOENFCDJEG, null, ZoneType.WithoutZone))
		{
			return false;
		}
		return false;
	}

	public static bool ApplyChanges(EditorAction CHFHMMNELGP, DecorationTile KJIGECBPBOD)
	{
		if (EditorGrid.GHGECPHNJEB(CHFHMMNELGP))
		{
			return LBCMDPMLOBG(CHFHMMNELGP);
		}
		if (EditorGrid.CKJEBHLGDMC(CHFHMMNELGP))
		{
			return JFNGBEEOFBG(CHFHMMNELGP, KJIGECBPBOD);
		}
		if (ConstructionActionBarUI.currentPanel == 0)
		{
			return EAMOJGGMGAL(CHFHMMNELGP);
		}
		return false;
	}

	private void CLGBFOIBANN()
	{
		GGFJGHHHEJC = this;
		LDJKLBBBFLJ();
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void HKDNFKFGMIA()
	{
		editorTiles = new Dictionary<Vector3, EditorTile>();
	}

	public static void DLLHLPCFLNL(EditorTile BNKKFKKAJLO, Vector3 IMOBLFMHKOD)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		editorTiles[Utils.NKGANMEKDAL(IMOBLFMHKOD)] = BNKKFKKAJLO;
		GGFJGHHHEJC.KLLKLNKCPBF(IMOBLFMHKOD, BNKKFKKAJLO);
	}

	private static bool JFNGBEEOFBG(EditorAction CHFHMMNELGP, DecorationTile BGCOHNIBBMB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		foreach (KeyValuePair<Vector3, EditorTile> editorTile in editorTiles)
		{
			if (editorTile.Value.editorAction != EditorAction.ZoneDisponible && editorTile.Value.editorAction != EditorAction.DecoWallZone)
			{
				continue;
			}
			if (BGCOHNIBBMB.editorAction == EditorAction.ChangeDecoFloor)
			{
				list.Add(Vector2.op_Implicit(editorTile.Key));
			}
			else
			{
				if (BGCOHNIBBMB.editorAction != EditorAction.ChangeDecoWall && BGCOHNIBBMB.editorAction != EditorAction.ChangeDecoWallTrim)
				{
					continue;
				}
				if (WorldGrid.KHJJCAGIJAP(editorTile.Key, out var KHEBKHFHMDB))
				{
					if (!list.Contains(Vector2.op_Implicit(new Vector3(editorTile.Key.x, KHEBKHFHMDB))))
					{
						list.Add(Vector2.op_Implicit(new Vector3(editorTile.Key.x, KHEBKHFHMDB)));
					}
				}
				else
				{
					Vector3 key = editorTile.Key;
					Debug.LogError((object)("wall floor not found with highlight at " + ((object)(Vector3)(ref key)).ToString()));
				}
			}
		}
		if (!TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(CHFHMMNELGP, list, BGCOHNIBBMB))
		{
			CancelFloorChanges(CHFHMMNELGP);
			return false;
		}
		return true;
	}

	public static bool GCFACJDLJKN(EditorAction CHFHMMNELGP, List<Vector2> HAEIAGKNEPC, bool GFNHAMCPEAK)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		ZoneType gIBJPCAFCJB = EditorGrid.APGNDILBOMJ(CHFHMMNELGP);
		List<int> OJNAJKDJFKC = new List<int>();
		if (CHFHMMNELGP != (EditorAction)(-69) && !TavernZonesManager.GGFJGHHHEJC.DKAECLABDNP(gIBJPCAFCJB, HAEIAGKNEPC, out OJNAJKDJFKC))
		{
			return true;
		}
		if (GFNHAMCPEAK)
		{
			if (!TavernZonesManager.JEEGOBGDLPE().HNJKOCGJAME(gIBJPCAFCJB, HAEIAGKNEPC, CKHEIJDJJDO: true))
			{
				return false;
			}
			TavernZonesManager.OIJLJKLMCBO().IGCCMOKDDOO(gIBJPCAFCJB, HAEIAGKNEPC, CKHEIJDJJDO: true);
		}
		if (CHFHMMNELGP == (EditorAction)(-7))
		{
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.DIHCEGINELM().HDHJHCHLKFB(CHFHMMNELGP, HAEIAGKNEPC);
			}
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				TavernZonesManager.EBAIHKJHCCA().BFBEPPAPOAB(Vector2.op_Implicit(HAEIAGKNEPC[i]), MEPFCAODGLH: false);
			}
		}
		else if (OJNAJKDJFKC.Count > 0)
		{
			int num = OJNAJKDJFKC[0];
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.GGFJGHHHEJC.ApplyChanges(CHFHMMNELGP, HAEIAGKNEPC, null, TavernZonesManager.NHKAFANMEJC().MDPHAHIFJFB(num).zoneType, num);
			}
			for (int j = 1; j < HAEIAGKNEPC.Count; j++)
			{
				TavernZonesManager.IECOPNFJBFD().JOIDEEHGBML(Vector2.op_Implicit(HAEIAGKNEPC[j]), num);
			}
			for (int k = 0; k < OJNAJKDJFKC.Count; k++)
			{
				if (OJNAJKDJFKC[k] != num)
				{
					TavernZonesManager.OIJLJKLMCBO().BLBEBDLKMMJ(OJNAJKDJFKC[k], num, GFNHAMCPEAK);
				}
			}
		}
		else
		{
			TavernZone tavernZone = TavernZonesManager.GGFJGHHHEJC.LPMJIJKNMPB(gIBJPCAFCJB);
			if (GFNHAMCPEAK)
			{
				TavernConstructionModifications.GGFJGHHHEJC.MLBHLHHHJOA(CHFHMMNELGP, HAEIAGKNEPC, null, gIBJPCAFCJB, tavernZone.id);
			}
			for (int l = 0; l < HAEIAGKNEPC.Count; l++)
			{
				TavernZonesManager.GGFJGHHHEJC.LCNMKMFNCFN(Vector2.op_Implicit(HAEIAGKNEPC[l]), tavernZone.id);
			}
		}
		for (int m = 0; m < HAEIAGKNEPC.Count; m++)
		{
			WorldGrid.APIEPIGNINO(Vector2.op_Implicit(HAEIAGKNEPC[m]), LHLHJCDKNHA: true);
		}
		TavernZonesManager.LANAINBEMCM().CLAEECJHKKI();
		if (GFNHAMCPEAK && OnlineManager.PlayingOnline())
		{
			OnlineTavernConstructionManager.instance.IDLGFIEPGBD(CHFHMMNELGP, HAEIAGKNEPC);
		}
		return true;
	}

	public static bool NLMLLHEOFCE(EditorAction CHFHMMNELGP, DecorationTile KJIGECBPBOD)
	{
		if (EditorGrid.GHGECPHNJEB(CHFHMMNELGP))
		{
			return HPIMDGILGLB(CHFHMMNELGP);
		}
		if (EditorGrid.CKJEBHLGDMC(CHFHMMNELGP))
		{
			return PNDOPDBPIDH(CHFHMMNELGP, KJIGECBPBOD);
		}
		if (ConstructionActionBarUI.currentPanel == 0)
		{
			return NPFMHKCNADJ(CHFHMMNELGP);
		}
		return true;
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}
}
