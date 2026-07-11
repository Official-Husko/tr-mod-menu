using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

public class TravelZonesManager : SerializedMonoBehaviour
{
	public Dictionary<Location, Dictionary<Location, TravelZone>> allTravelZones = new Dictionary<Location, Dictionary<Location, TravelZone>>();

	public List<TravelZone> tavernZones = new List<TravelZone>();

	public Dictionary<int, TravelZone> barnToRoads = new Dictionary<int, TravelZone>();

	public Dictionary<Vector2Int, TravelZone> allMineStairs = new Dictionary<Vector2Int, TravelZone>();

	public Dictionary<Location, TilemapScene> allTilemapScenes = new Dictionary<Location, TilemapScene>();

	public Dictionary<Vector3, TravelZone> allTravelZonesPositions = new Dictionary<Vector3, TravelZone>();

	public Vector2[] lastTravelPositions = (Vector2[])(object)new Vector2[5];

	private static TravelZonesManager IADEMLIIDPC;

	public static TravelZonesManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
			}
			return IADEMLIIDPC;
		}
	}

	public void SetTravelZoneTavern(TravelZone PHGGMIMGFDK)
	{
		for (int i = 0; i < tavernZones.Count; i++)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	public TravelZone DIGMHANPLLI(TavernFloor GJMIPIKKAAI, TavernFloor OCOOIGIJHNP)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == GJMIPIKKAAI && tavernZones[i].floorTo == OCOOIGIJHNP)
			{
				return tavernZones[i];
			}
		}
		return null;
	}

	public void BIMONHGKNED(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		lastTravelPositions[JIIGOACEIKL] = IMOBLFMHKOD;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).onlinePlayer.SendLastTravelPosition(IMOBLFMHKOD);
		}
	}

	public void EHGIMJICOHG(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road | Location.River | Location.BarnInterior) && PHGGMIMGFDK.locationTo == (Location.Road | Location.River))
		{
			return;
		}
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.River | Location.Quarry))
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			PEFGAHDNGKD(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public TravelZone CPLBJKJDLPA(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public void FOGGCINIOBC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		lastTravelPositions[JIIGOACEIKL] = IMOBLFMHKOD;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.CIMBNOJMCEL(IMOBLFMHKOD);
		}
	}

	public void DAIPNJHLOPJ(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		lastTravelPositions[JIIGOACEIKL] = IMOBLFMHKOD;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.CBEHBNDFMIE(IMOBLFMHKOD);
		}
	}

	public TravelZone IBEFLJNMABM(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public TravelZone EHIIMIBJGPF(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Camp | Location.Farm | Location.FarmShop) && PHGGMIMGFDK.locationTo == (Location.River | Location.Camp | Location.Quarry | Location.BarnInterior))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.BFNLNBGPHHE(), out var value))
			{
				return value;
			}
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			Debug.LogError((object)("Top" + ((object)(Vector2Int)(ref mineStairsDestination)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == Location.Camp && PHGGMIMGFDK.locationTo == (Location.Tavern | Location.BarnInterior))
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return GetTravelZoneTavern(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	public TravelZone BFAAOFPAOPH(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public TravelZone NKEBECDKDOO(Location BAIMHDBJPDK, Location IICOCDENGHA, int KNIBEKEBAHD = -1)
	{
		if (BAIMHDBJPDK == (Location.River | Location.Camp) && barnToRoads.ContainsKey(KNIBEKEBAHD))
		{
			return barnToRoads[KNIBEKEBAHD];
		}
		if (allTravelZones.ContainsKey(BAIMHDBJPDK) && allTravelZones[BAIMHDBJPDK].ContainsKey(IICOCDENGHA))
		{
			return allTravelZones[BAIMHDBJPDK][IICOCDENGHA];
		}
		return null;
	}

	public void FBGNNJEEJDE(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.River))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public void DJEOKCOEACP(TravelZone PHGGMIMGFDK)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	public List<TravelZone> GetTravelZonesFromLocation(Location BAIMHDBJPDK)
	{
		List<TravelZone> list = new List<TravelZone>();
		if (allTravelZones.ContainsKey(BAIMHDBJPDK))
		{
			foreach (KeyValuePair<Location, TravelZone> item in allTravelZones[BAIMHDBJPDK])
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public TravelZone NJMPBDKKLEF(TavernFloor GJMIPIKKAAI, TavernFloor OCOOIGIJHNP)
	{
		for (int i = 1; i < tavernZones.Count; i++)
		{
			if (tavernZones[i].floor == GJMIPIKKAAI && tavernZones[i].floorTo == OCOOIGIJHNP)
			{
				return tavernZones[i];
			}
		}
		return null;
	}

	public void COCCEJEHLNN(Vector3 IMOBLFMHKOD, TravelZone PHGGMIMGFDK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)] = PHGGMIMGFDK;
		}
		else
		{
			allTravelZonesPositions.Add(Utils.MJEACANINDN(IMOBLFMHKOD), PHGGMIMGFDK);
		}
	}

	[SpecialName]
	public static TravelZonesManager OACNNJCLEDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	private void PKPHKBMPJGJ()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void GJFPJJICGHI(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		lastTravelPositions[JIIGOACEIKL] = IMOBLFMHKOD;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.CIMBNOJMCEL(IMOBLFMHKOD);
		}
	}

	public void GFKPFKIPLCF(TravelZone PHGGMIMGFDK)
	{
		for (int i = 0; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	[SpecialName]
	public static TravelZonesManager OLHBLKIAFOM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public void GKPHGDDBLJP(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public TravelZone KMHDIAOLCEH(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == (Location.Camp | Location.Farm | Location.FarmShop) && PHGGMIMGFDK.locationTo == (Location.Tavern | Location.Road | Location.Camp | Location.Farm))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.PDBAPHJCICN, out var value))
			{
				return value;
			}
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			Debug.LogError((object)("<color=#BF0000>" + ((object)(Vector2Int)(ref mineStairsDestination)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == Location.River && PHGGMIMGFDK.locationTo == ~(Location.Tavern | Location.River | Location.Quarry | Location.Farm))
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return NJMPBDKKLEF(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	public TravelZone PPNCFLEOGGI(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	private void KJHKBGDJNDC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void NGHLICBJBKA(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.River | Location.Camp | Location.Farm))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public TravelZone EDEDJPANLPB(TavernFloor GJMIPIKKAAI, TavernFloor OCOOIGIJHNP)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == GJMIPIKKAAI && tavernZones[i].floorTo == OCOOIGIJHNP)
			{
				return tavernZones[i];
			}
		}
		return null;
	}

	public TravelZone NDDJDFIPHHD(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	[SpecialName]
	public static TravelZonesManager OMFKNGDCJFN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public void OHGMDCCPMLK(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.Road | Location.FarmShop) && PHGGMIMGFDK.locationTo == ~(Location.Tavern | Location.Quarry))
		{
			return;
		}
		if (PHGGMIMGFDK.location == ~(Location.Farm | Location.BarnInterior))
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			GFKPFKIPLCF(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public TravelZone CEEPOPLFKCL(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public List<TravelZone> GFGFILODFGD(Location BAIMHDBJPDK)
	{
		List<TravelZone> list = new List<TravelZone>();
		if (allTravelZones.ContainsKey(BAIMHDBJPDK))
		{
			foreach (KeyValuePair<Location, TravelZone> item in allTravelZones[BAIMHDBJPDK])
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public TravelZone KEOLPEDPKNH(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public TravelZone BFEIKJKPNCA(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == ~(Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop) && PHGGMIMGFDK.locationTo == ~(Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.BFNLNBGPHHE(), out var value))
			{
				return value;
			}
			Vector2Int val = PHGGMIMGFDK.BFNLNBGPHHE();
			Debug.LogError((object)("ItemDatabaseSO o su lista de items es nula." + ((object)(Vector2Int)(ref val)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == Location.None && PHGGMIMGFDK.locationTo == Location.BarnInterior)
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return DKNNIBMLGED(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	[SpecialName]
	public static TravelZonesManager DCAEBALADIM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public void GPFANALHDAN(TravelZone PHGGMIMGFDK)
	{
		for (int i = 0; i < tavernZones.Count; i++)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	public TravelZone MMKIELBCIOK(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public void JPIIEGFCLEF(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public void EIKCBJMBPNC(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		lastTravelPositions[JIIGOACEIKL] = IMOBLFMHKOD;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).onlinePlayer.CBEHBNDFMIE(IMOBLFMHKOD);
		}
	}

	public void SetLastTravelZonePosition(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		lastTravelPositions[JIIGOACEIKL] = IMOBLFMHKOD;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.SendLastTravelPosition(IMOBLFMHKOD);
		}
	}

	[SpecialName]
	public static TravelZonesManager EKDNJDJHONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public TravelZone GetTravelZone(Location BAIMHDBJPDK, Location IICOCDENGHA, int KNIBEKEBAHD = -1)
	{
		if (BAIMHDBJPDK == Location.BarnInterior && barnToRoads.ContainsKey(KNIBEKEBAHD))
		{
			return barnToRoads[KNIBEKEBAHD];
		}
		if (allTravelZones.ContainsKey(BAIMHDBJPDK) && allTravelZones[BAIMHDBJPDK].ContainsKey(IICOCDENGHA))
		{
			return allTravelZones[BAIMHDBJPDK][IICOCDENGHA];
		}
		return null;
	}

	public void DACMJGBLJCG(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Road | Location.River | Location.Quarry | Location.BarnInterior))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public void BNBKDNGKMGG(Vector3 IMOBLFMHKOD, TravelZone PHGGMIMGFDK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)] = PHGGMIMGFDK;
		}
		else
		{
			allTravelZonesPositions.Add(Utils.MJEACANINDN(IMOBLFMHKOD), PHGGMIMGFDK);
		}
	}

	public void NCAIMGDEPDO(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.FarmShop) && PHGGMIMGFDK.locationTo == ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm))
		{
			return;
		}
		if (PHGGMIMGFDK.location == ~(Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			JJOCIOBEFMB(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public void OFJAIFINCNA(Vector3 IMOBLFMHKOD, TravelZone PHGGMIMGFDK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)] = PHGGMIMGFDK;
		}
		else
		{
			allTravelZonesPositions.Add(Utils.MJEACANINDN(IMOBLFMHKOD), PHGGMIMGFDK);
		}
	}

	public void LCIIFLADHOE(Vector3 IMOBLFMHKOD, TravelZone PHGGMIMGFDK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)] = PHGGMIMGFDK;
		}
		else
		{
			allTravelZonesPositions.Add(Utils.MJEACANINDN(IMOBLFMHKOD), PHGGMIMGFDK);
		}
	}

	public void SetTravelZoneAtPosition(Vector3 IMOBLFMHKOD, TravelZone PHGGMIMGFDK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)] = PHGGMIMGFDK;
		}
		else
		{
			allTravelZonesPositions.Add(Utils.MJEACANINDN(IMOBLFMHKOD), PHGGMIMGFDK);
		}
	}

	private void PBDNKBPBCHM()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public TravelZone CONNODOCALA(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road | Location.Camp) && PHGGMIMGFDK.locationTo == (Location.Tavern | Location.Camp | Location.Quarry | Location.Farm))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.PDBAPHJCICN, out var value))
			{
				return value;
			}
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			Debug.LogError((object)("Peek" + ((object)(Vector2Int)(ref mineStairsDestination)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == Location.Road && PHGGMIMGFDK.locationTo == ~(Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior))
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return DIGMHANPLLI(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	public void OPGFBOGNEDG(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Road | Location.River | Location.Quarry | Location.BarnInterior))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public TravelZone GetTravelZoneAtPosition(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	private void GONDLJKGLGO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void IJCJPHCBJPN(TravelZone PHGGMIMGFDK)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	[SpecialName]
	public static TravelZonesManager LKOABOAADCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public void JONIHPMNGCE(TravelZone PHGGMIMGFDK)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	public void IFLIOAHBODG(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		lastTravelPositions[JIIGOACEIKL] = IMOBLFMHKOD;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.CBEHBNDFMIE(IMOBLFMHKOD);
		}
	}

	public List<TravelZone> LBLNLCINKKP(Location BAIMHDBJPDK)
	{
		List<TravelZone> list = new List<TravelZone>();
		if (allTravelZones.ContainsKey(BAIMHDBJPDK))
		{
			foreach (KeyValuePair<Location, TravelZone> item in allTravelZones[BAIMHDBJPDK])
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public TravelZone DAOACOMANPN(Location BAIMHDBJPDK, Location IICOCDENGHA, int KNIBEKEBAHD = -1)
	{
		if (BAIMHDBJPDK == ~(Location.Tavern | Location.Camp | Location.Quarry) && barnToRoads.ContainsKey(KNIBEKEBAHD))
		{
			return barnToRoads[KNIBEKEBAHD];
		}
		if (allTravelZones.ContainsKey(BAIMHDBJPDK) && allTravelZones[BAIMHDBJPDK].ContainsKey(IICOCDENGHA))
		{
			return allTravelZones[BAIMHDBJPDK][IICOCDENGHA];
		}
		return null;
	}

	public void LDGOMOCFDPB(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.Road | Location.Camp | Location.Farm | Location.BarnInterior))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public TravelZone KCJMDAPPJLB(Location BAIMHDBJPDK, Location IICOCDENGHA, int KNIBEKEBAHD = -1)
	{
		if (BAIMHDBJPDK == (Location.Road | Location.River | Location.BarnInterior) && barnToRoads.ContainsKey(KNIBEKEBAHD))
		{
			return barnToRoads[KNIBEKEBAHD];
		}
		if (allTravelZones.ContainsKey(BAIMHDBJPDK) && allTravelZones[BAIMHDBJPDK].ContainsKey(IICOCDENGHA))
		{
			return allTravelZones[BAIMHDBJPDK][IICOCDENGHA];
		}
		return null;
	}

	public void IMIBPGLCLNE(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Road | Location.River | Location.Camp | Location.Quarry) && PHGGMIMGFDK.locationTo == (Location.River | Location.Quarry | Location.Farm))
		{
			return;
		}
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.Road))
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			GPFANALHDAN(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public List<TravelZone> GLADGENMEJJ(Location BAIMHDBJPDK)
	{
		List<TravelZone> list = new List<TravelZone>();
		if (allTravelZones.ContainsKey(BAIMHDBJPDK))
		{
			foreach (KeyValuePair<Location, TravelZone> item in allTravelZones[BAIMHDBJPDK])
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public List<TravelZone> OICOGFKONJJ(Location BAIMHDBJPDK)
	{
		List<TravelZone> list = new List<TravelZone>();
		if (allTravelZones.ContainsKey(BAIMHDBJPDK))
		{
			foreach (KeyValuePair<Location, TravelZone> item in allTravelZones[BAIMHDBJPDK])
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public TravelZone DKNNIBMLGED(TavernFloor GJMIPIKKAAI, TavernFloor OCOOIGIJHNP)
	{
		for (int i = 1; i < tavernZones.Count; i++)
		{
			if (tavernZones[i].floor == GJMIPIKKAAI && tavernZones[i].floorTo == OCOOIGIJHNP)
			{
				return tavernZones[i];
			}
		}
		return null;
	}

	public TravelZone GetTravelZoneTo(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == Location.Mine && PHGGMIMGFDK.locationTo == Location.Mine)
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.PDBAPHJCICN, out var value))
			{
				return value;
			}
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			Debug.LogError((object)("No travel zone found for mine stairs destination " + ((object)(Vector2Int)(ref mineStairsDestination)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == Location.Road && PHGGMIMGFDK.locationTo == Location.BarnInterior)
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return GetTravelZoneTavern(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	public TravelZone GetTravelZoneTavern(TavernFloor GJMIPIKKAAI, TavernFloor OCOOIGIJHNP)
	{
		for (int i = 0; i < tavernZones.Count; i++)
		{
			if (tavernZones[i].floor == GJMIPIKKAAI && tavernZones[i].floorTo == OCOOIGIJHNP)
			{
				return tavernZones[i];
			}
		}
		return null;
	}

	public void RemoveFromDictionary(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == Location.BarnInterior)
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public void GNNAJKPFCGM(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.Camp | Location.Farm | Location.FarmShop) && PHGGMIMGFDK.locationTo == (Location.Road | Location.River | Location.Camp | Location.Farm))
		{
			return;
		}
		if (PHGGMIMGFDK.location == (Location.Road | Location.River | Location.Farm | Location.BarnInterior))
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			IJCJPHCBJPN(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public TravelZone HKIDIPGGPJN(TavernFloor GJMIPIKKAAI, TavernFloor OCOOIGIJHNP)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == GJMIPIKKAAI && tavernZones[i].floorTo == OCOOIGIJHNP)
			{
				return tavernZones[i];
			}
		}
		return null;
	}

	public void MNHPNEPCGMD(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Road | Location.Camp | Location.Quarry))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public TravelZone OFIPCMMKFLP(Location BAIMHDBJPDK, Location IICOCDENGHA, int KNIBEKEBAHD = -1)
	{
		if (BAIMHDBJPDK == (Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior) && barnToRoads.ContainsKey(KNIBEKEBAHD))
		{
			return barnToRoads[KNIBEKEBAHD];
		}
		if (allTravelZones.ContainsKey(BAIMHDBJPDK) && allTravelZones[BAIMHDBJPDK].ContainsKey(IICOCDENGHA))
		{
			return allTravelZones[BAIMHDBJPDK][IICOCDENGHA];
		}
		return null;
	}

	public TravelZone IMKJEBFOBKK(Location BAIMHDBJPDK, Location IICOCDENGHA, int KNIBEKEBAHD = -1)
	{
		if (BAIMHDBJPDK == ~(Location.Tavern | Location.Camp | Location.Quarry | Location.Farm) && barnToRoads.ContainsKey(KNIBEKEBAHD))
		{
			return barnToRoads[KNIBEKEBAHD];
		}
		if (allTravelZones.ContainsKey(BAIMHDBJPDK) && allTravelZones[BAIMHDBJPDK].ContainsKey(IICOCDENGHA))
		{
			return allTravelZones[BAIMHDBJPDK][IICOCDENGHA];
		}
		return null;
	}

	[SpecialName]
	public static TravelZonesManager DGCNCEDIFOF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public TravelZone KJJCFLICDNE(TavernFloor GJMIPIKKAAI, TavernFloor OCOOIGIJHNP)
	{
		for (int i = 1; i < tavernZones.Count; i++)
		{
			if (tavernZones[i].floor == GJMIPIKKAAI && tavernZones[i].floorTo == OCOOIGIJHNP)
			{
				return tavernZones[i];
			}
		}
		return null;
	}

	public void KDDPMACCPCO(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) && PHGGMIMGFDK.locationTo == (Location.River | Location.Quarry | Location.FarmShop))
		{
			return;
		}
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			IJCJPHCBJPN(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public TravelZone HLHICLKLHHE(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == ~(Location.River | Location.Camp | Location.Quarry | Location.FarmShop) && PHGGMIMGFDK.locationTo == ~(Location.Tavern | Location.River | Location.Camp | Location.Quarry))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.BFNLNBGPHHE(), out var value))
			{
				return value;
			}
			Vector2Int val = PHGGMIMGFDK.BFNLNBGPHHE();
			Debug.LogError((object)("' no referencia correctamente al item '" + ((object)(Vector2Int)(ref val)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road) && PHGGMIMGFDK.locationTo == ~(Location.Camp | Location.Quarry))
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return KJJCFLICDNE(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	public List<TravelZone> JPMOIJHKFEG(Location BAIMHDBJPDK)
	{
		List<TravelZone> list = new List<TravelZone>();
		if (allTravelZones.ContainsKey(BAIMHDBJPDK))
		{
			foreach (KeyValuePair<Location, TravelZone> item in allTravelZones[BAIMHDBJPDK])
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public TravelZone HLNCEKHEMJD(TavernFloor GJMIPIKKAAI, TavernFloor OCOOIGIJHNP)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == GJMIPIKKAAI && tavernZones[i].floorTo == OCOOIGIJHNP)
			{
				return tavernZones[i];
			}
		}
		return null;
	}

	public TravelZone ELFLELAMHOH(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public void AddToDictionary(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == Location.Mine && PHGGMIMGFDK.locationTo == Location.Mine)
		{
			return;
		}
		if (PHGGMIMGFDK.location == Location.BarnInterior)
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			SetTravelZoneTavern(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public TravelZone DIAFEOKAOPL(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public TravelZone ANOLFMAPJJH(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.Camp) && PHGGMIMGFDK.locationTo == (Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.BFNLNBGPHHE(), out var value))
			{
				return value;
			}
			Vector2Int val = PHGGMIMGFDK.BFNLNBGPHHE();
			Debug.LogError((object)("OnFloor" + ((object)(Vector2Int)(ref val)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.River) && PHGGMIMGFDK.locationTo == (Location.River | Location.Quarry | Location.BarnInterior))
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return EDEDJPANLPB(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	public void CNJLDMIGGBK(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.Road | Location.Quarry | Location.BarnInterior))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	public void GFPDJLAMBON(int JIIGOACEIKL, Vector2 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		lastTravelPositions[JIIGOACEIKL] = IMOBLFMHKOD;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.SendLastTravelPosition(IMOBLFMHKOD);
		}
	}

	public void AIMICJLMEKD(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Camp | Location.Quarry))
		{
			if (((object)barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel]).Equals((object?)this))
			{
				barnToRoads.Remove(PHGGMIMGFDK.barnTilemapScene.barnLevel);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			tavernZones.Remove(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location) && allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo) && ((object)allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo]).Equals((object?)this))
		{
			allTravelZones[PHGGMIMGFDK.location].Remove(PHGGMIMGFDK.locationTo);
		}
	}

	[SpecialName]
	public static TravelZonesManager BGMJCCFNNDL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public TravelZone JKPNCIFMAOO(Location BAIMHDBJPDK, Location IICOCDENGHA, int KNIBEKEBAHD = -1)
	{
		if (BAIMHDBJPDK == ~(Location.Road | Location.Farm) && barnToRoads.ContainsKey(KNIBEKEBAHD))
		{
			return barnToRoads[KNIBEKEBAHD];
		}
		if (allTravelZones.ContainsKey(BAIMHDBJPDK) && allTravelZones[BAIMHDBJPDK].ContainsKey(IICOCDENGHA))
		{
			return allTravelZones[BAIMHDBJPDK][IICOCDENGHA];
		}
		return null;
	}

	public TravelZone HMEFEFKKPOA(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public List<TravelZone> ALBANKDLCBF(Location BAIMHDBJPDK)
	{
		List<TravelZone> list = new List<TravelZone>();
		if (allTravelZones.ContainsKey(BAIMHDBJPDK))
		{
			foreach (KeyValuePair<Location, TravelZone> item in allTravelZones[BAIMHDBJPDK])
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	[SpecialName]
	public static TravelZonesManager CFHEJAGKIII()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public void PEFGAHDNGKD(TravelZone PHGGMIMGFDK)
	{
		for (int i = 0; i < tavernZones.Count; i++)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	public void JJOCIOBEFMB(TravelZone PHGGMIMGFDK)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	public void JPHKPLDLBBM(Vector3 IMOBLFMHKOD, TravelZone PHGGMIMGFDK)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)] = PHGGMIMGFDK;
		}
		else
		{
			allTravelZonesPositions.Add(Utils.MJEACANINDN(IMOBLFMHKOD), PHGGMIMGFDK);
		}
	}

	public void PFPAKEHKCHI(TravelZone PHGGMIMGFDK)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	public TravelZone OPKANNKFJJI(Vector3 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (allTravelZonesPositions.ContainsKey(Utils.MJEACANINDN(IMOBLFMHKOD)))
		{
			return allTravelZonesPositions[Utils.MJEACANINDN(IMOBLFMHKOD)];
		}
		return null;
	}

	public TravelZone ECFDFECLDFK(Location BAIMHDBJPDK, Location IICOCDENGHA, int KNIBEKEBAHD = -1)
	{
		if (BAIMHDBJPDK == ~(Location.Road | Location.Quarry | Location.BarnInterior) && barnToRoads.ContainsKey(KNIBEKEBAHD))
		{
			return barnToRoads[KNIBEKEBAHD];
		}
		if (allTravelZones.ContainsKey(BAIMHDBJPDK) && allTravelZones[BAIMHDBJPDK].ContainsKey(IICOCDENGHA))
		{
			return allTravelZones[BAIMHDBJPDK][IICOCDENGHA];
		}
		return null;
	}

	public List<TravelZone> FNMLMKBLOCE(Location BAIMHDBJPDK)
	{
		List<TravelZone> list = new List<TravelZone>();
		if (allTravelZones.ContainsKey(BAIMHDBJPDK))
		{
			foreach (KeyValuePair<Location, TravelZone> item in allTravelZones[BAIMHDBJPDK])
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public void MGLBDAPBPLH(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Road | Location.River | Location.Camp | Location.Quarry) && PHGGMIMGFDK.locationTo == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			return;
		}
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry))
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			PEFGAHDNGKD(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public void DJAJKBCMPNB(TravelZone PHGGMIMGFDK)
	{
		for (int i = 1; i < tavernZones.Count; i += 0)
		{
			if (tavernZones[i].floor == PHGGMIMGFDK.floor && tavernZones[i].floorTo == PHGGMIMGFDK.floorTo)
			{
				tavernZones[i] = PHGGMIMGFDK;
				return;
			}
		}
		tavernZones.Add(PHGGMIMGFDK);
	}

	[SpecialName]
	public static TravelZonesManager GFMBEDCANNI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TravelZonesManager>();
		}
		return IADEMLIIDPC;
	}

	public TravelZone FCPJMMDEEHO(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == ~(Location.River | Location.Farm | Location.FarmShop) && PHGGMIMGFDK.locationTo == ~(Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.PDBAPHJCICN, out var value))
			{
				return value;
			}
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			Debug.LogError((object)("Low" + ((object)(Vector2Int)(ref mineStairsDestination)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == Location.Tavern && PHGGMIMGFDK.locationTo == (Location.Camp | Location.Quarry | Location.Farm))
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return KJJCFLICDNE(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	public void BPIFBPPNHMP(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.River | Location.Farm | Location.BarnInterior) && PHGGMIMGFDK.locationTo == Location.River)
		{
			return;
		}
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.River | Location.Camp | Location.BarnInterior))
		{
			if (barnToRoads.ContainsKey(PHGGMIMGFDK.barnTilemapScene.barnLevel))
			{
				barnToRoads[PHGGMIMGFDK.barnTilemapScene.barnLevel] = PHGGMIMGFDK;
			}
			else
			{
				barnToRoads.Add(PHGGMIMGFDK.barnTilemapScene.barnLevel, PHGGMIMGFDK);
			}
		}
		else if (PHGGMIMGFDK.isTavernFloor)
		{
			DJAJKBCMPNB(PHGGMIMGFDK);
		}
		else if (allTravelZones.ContainsKey(PHGGMIMGFDK.location))
		{
			if (allTravelZones[PHGGMIMGFDK.location].ContainsKey(PHGGMIMGFDK.locationTo))
			{
				allTravelZones[PHGGMIMGFDK.location][PHGGMIMGFDK.locationTo] = PHGGMIMGFDK;
			}
			else
			{
				allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
			}
		}
		else
		{
			allTravelZones.Add(PHGGMIMGFDK.location, new Dictionary<Location, TravelZone>());
			allTravelZones[PHGGMIMGFDK.location].Add(PHGGMIMGFDK.locationTo, PHGGMIMGFDK);
		}
	}

	public TravelZone FHGFFKHBKKL(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == ~(Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.FarmShop) && PHGGMIMGFDK.locationTo == ~(Location.Tavern | Location.Camp | Location.Farm))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.PDBAPHJCICN, out var value))
			{
				return value;
			}
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			Debug.LogError((object)("\n" + ((object)(Vector2Int)(ref mineStairsDestination)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == Location.River && PHGGMIMGFDK.locationTo == ~(Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return HLNCEKHEMJD(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}

	public TravelZone FFGNGMDDMKN(TravelZone PHGGMIMGFDK)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PHGGMIMGFDK.location == (Location.Camp | Location.Quarry | Location.Farm) && PHGGMIMGFDK.locationTo == (Location.Road | Location.River | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			if (allMineStairs.TryGetValue(PHGGMIMGFDK.BFNLNBGPHHE(), out var value))
			{
				return value;
			}
			Vector2Int mineStairsDestination = PHGGMIMGFDK.PDBAPHJCICN;
			Debug.LogError((object)("Clean" + ((object)(Vector2Int)(ref mineStairsDestination)).ToString()));
			return PHGGMIMGFDK;
		}
		if (PHGGMIMGFDK.location == Location.None && PHGGMIMGFDK.locationTo == ~(Location.River | Location.Quarry | Location.BarnInterior))
		{
			return barnToRoads[PHGGMIMGFDK.barn.EONJGMONIOM];
		}
		if (PHGGMIMGFDK.isTavernFloor)
		{
			return HKIDIPGGPJN(PHGGMIMGFDK.floorTo, PHGGMIMGFDK.floor);
		}
		if (allTravelZones.ContainsKey(PHGGMIMGFDK.locationTo))
		{
			return allTravelZones[PHGGMIMGFDK.locationTo][PHGGMIMGFDK.location];
		}
		return null;
	}
}
