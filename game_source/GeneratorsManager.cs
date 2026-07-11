using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

public class GeneratorsManager : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class DFHKDDCDOHH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GeneratorsManager _003C_003E4__this;

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
		public DFHKDDCDOHH(int _003C_003E1__state)
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
			GeneratorsManager generatorsManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				generatorsManager.RemoveDarkTerrain();
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((MonoBehaviour)generatorsManager).StartCoroutine(generatorsManager.ELMFKIKNIIJ());
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

	public static GeneratorsManager instance;

	public List<HerbGenerator> herbGenerators = new List<HerbGenerator>();

	public List<TreeGenerator> treeGenerators = new List<TreeGenerator>();

	public List<SaveData.UniqueCropSave> uniqueCrops = new List<SaveData.UniqueCropSave>();

	public List<SaveData.UniqueBushSave> uniqueBush = new List<SaveData.UniqueBushSave>();

	public Dictionary<int, List<SaveData.UniqueSpawnerSave>> uniqueSpawner = new Dictionary<int, List<SaveData.UniqueSpawnerSave>>();

	private Coroutine CEGDFJCGKOO;

	private static List<Generator> BDEKBKJGHJM;

	private void NKNODEGIPCP()
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (!uniqueCrops[i].isHarvestable)
			{
				uniqueCrops[i].daysUntilNewHarvest--;
				if (uniqueCrops[i].daysUntilNewHarvest <= 0)
				{
					uniqueCrops[i].isHarvestable = true;
				}
			}
			else if (uniqueCrops[i].daysUntilNewHarvest > 0)
			{
				uniqueCrops[i].isHarvestable = false;
			}
		}
	}

	private void MNAAANAEKBA()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		for (int i = 0; i < herbGenerators.Count; i++)
		{
			num += herbGenerators[i].forestElements.Count;
		}
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Road);
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		WorldTile ILDEFBIANKO;
		for (int j = 0; j < allPositionsToCalculate.Length; j++)
		{
			Vector3 val = ((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).CellToWorld(allPositionsToCalculate[j]);
			if (WorldGrid.GCGNCHFNEBJ(val, out ILDEFBIANKO) && ILDEFBIANKO.location == Location.Road && !ILDEFBIANKO.isPath && Mathf.PerlinNoise(val.x, val.y) > 0.46f)
			{
				if (num < 1000)
				{
					GameTileMaps.GGFJGHHHEJC.SetDarkGrassTileAtPosition(val, tilemapScene.GetTilemaps(), SeasonManager.EECEKHKAAIH, tilemapScene);
				}
				GameTileMaps.GGFJGHHHEJC.SetDarkGroundTileAtPosition(val, tilemapScene.GetTilemaps(), SeasonManager.EECEKHKAAIH, tilemapScene);
			}
		}
		for (int k = 0; k < allPositionsToCalculate.Length; k++)
		{
			Vector3 val = ((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).CellToWorld(allPositionsToCalculate[k]);
			if (WorldGrid.GCGNCHFNEBJ(val, out ILDEFBIANKO))
			{
				if (num < 800)
				{
					WorldGrid.GDBBPKCJMJI(val, ILDEFBIANKO.PBLLKEKGLPK.GetTilemaps().darkGrassTilemap, SeasonManager.EECEKHKAAIH);
				}
				WorldGrid.GDBBPKCJMJI(val, ILDEFBIANKO.PBLLKEKGLPK.GetTilemaps().darkGroundTilemap, SeasonManager.EECEKHKAAIH);
			}
		}
	}

	public void BGPGEAKNGFA(bool LCIDLBLPKHB)
	{
		DestroyAllForestElements();
		((MonoBehaviour)this).StartCoroutine(GNEEKBHPBBO(LCIDLBLPKHB));
	}

	private IEnumerator GNEEKBHPBBO(bool LCIDLBLPKHB)
	{
		yield return null;
		List<Generator> generators = GetAllGenerators();
		TimerHelper h = new TimerHelper();
		for (int l = 0; l < 50; l++)
		{
			for (int j = 0; j < generators.Count; j++)
			{
				generators[j].GenerateForestElements(LCIDLBLPKHB, KENEGPFEHHI: true, CDPAMNIPPEC: false);
				if (h.GetMillisecs() > 50f)
				{
					h.Reset();
					yield return null;
				}
			}
			if (l % 2 != 0)
			{
				continue;
			}
			for (int j = 0; j < treeGenerators.Count; j++)
			{
				List<ForestElement> trees = treeGenerators[j].forestElements;
				for (int k = 0; k < trees.Count; k++)
				{
					(trees[k] as Tree).GenerateSeedAndGrow(LCIDLBLPKHB);
					if (h.GetMillisecs() > 50f)
					{
						h.Reset();
						yield return null;
					}
				}
			}
		}
		GenerateDarkTerrain();
	}

	public void MOJFAGEDHML(bool LCIDLBLPKHB)
	{
		DestroyAllForestElements();
		((MonoBehaviour)this).StartCoroutine(GNEEKBHPBBO(LCIDLBLPKHB));
	}

	public void AddUniqueCrops(CropSetter BOIGHCFJHPF)
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == BOIGHCFJHPF.uniqueID)
			{
				return;
			}
		}
		SaveData.UniqueCropSave uniqueCropSave = new SaveData.UniqueCropSave();
		uniqueCropSave.uniqueID = BOIGHCFJHPF.uniqueID;
		uniqueCropSave.daysUntilNewHarvest = BOIGHCFJHPF.growable.daysUntilNewHarvest;
		if (BOIGHCFJHPF.growable.daysUntilNewHarvest <= 0)
		{
			uniqueCropSave.isHarvestable = true;
		}
		uniqueCrops.Add(uniqueCropSave);
	}

	private void GIIPPLCCJED()
	{
		try
		{
			NNCBPDLNDJH();
			NKNODEGIPCP();
			MEAFDIJLOPA();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void AddUniqueSpawner(MiscellaneousSpawner PEKCGCDBFEG)
	{
		if ((Object)(object)PEKCGCDBFEG != (Object)null && (Object)(object)PEKCGCDBFEG.uniqueObject != (Object)null && !uniqueSpawner.ContainsKey(PEKCGCDBFEG.uniqueObject.uniqueID))
		{
			List<SaveData.UniqueSpawnerSave> list = new List<SaveData.UniqueSpawnerSave>();
			uniqueSpawner.Add(PEKCGCDBFEG.uniqueObject.uniqueID, list);
			for (int i = 0; i < PEKCGCDBFEG.uniqueSpawnerID.Length; i++)
			{
				SaveData.UniqueSpawnerSave uniqueSpawnerSave = new SaveData.UniqueSpawnerSave();
				uniqueSpawnerSave.uniqueID = PEKCGCDBFEG.uniqueObject.uniqueID;
				uniqueSpawnerSave.spawnerID = PEKCGCDBFEG.uniqueSpawnerID[i];
				uniqueSpawnerSave.daysUntilNewHarvest = 0;
				uniqueSpawnerSave.harvestable = false;
				uniqueSpawnerSave.spawnerPosition = 0;
				list.Add(uniqueSpawnerSave);
			}
		}
	}

	private void Awake()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
		else
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GIIPPLCCJED));
	}

	private void NNCBPDLNDJH()
	{
		for (int i = 0; i < uniqueBush.Count; i++)
		{
			if (uniqueBush[i].daysUntilNewHarvest > 0)
			{
				uniqueBush[i].daysUntilNewHarvest--;
			}
		}
	}

	private IEnumerator ELMFKIKNIIJ()
	{
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Road);
		Vector3Int[] allPositions = tilemapScene.GetAllPositionsToCalculate();
		TimerHelper h = new TimerHelper();
		for (int i = 0; i < allPositions.Length; i++)
		{
			Vector3 val = ((GridLayout)GameTileMaps.GGFJGHHHEJC.floorBaseTilemap).CellToWorld(allPositions[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				continue;
			}
			if (ILDEFBIANKO.herbs != null)
			{
				GameTileMaps.GGFJGHHHEJC.SetDarkGrassTileAtPosition(val, tilemapScene.GetTilemaps(SeasonManager.EECEKHKAAIH), SeasonManager.EECEKHKAAIH, tilemapScene);
			}
			else
			{
				int num = 0;
				for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
				{
					num += WorldGrid.FDELHDADCEN(val + WorldGrid.allNeighbours[j].position);
				}
				if (num > 1)
				{
					GameTileMaps.GGFJGHHHEJC.SetDarkGrassTileAtPosition(val, tilemapScene.GetTilemaps(SeasonManager.EECEKHKAAIH), SeasonManager.EECEKHKAAIH, tilemapScene);
				}
			}
			if (h.GetMillisecs() > 50f)
			{
				h.Reset();
				yield return null;
			}
		}
		CEGDFJCGKOO = null;
	}

	private void AIGBLOJLPDE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			List<Generator> allGenerators = GetAllGenerators();
			for (int i = 0; i < allGenerators.Count; i++)
			{
				allGenerators[i].GenerateForestElements();
			}
		}
		GenerateDarkTerrain();
	}

	private IEnumerator BDIGFMCMJBO()
	{
		RemoveDarkTerrain();
		yield return CommonReferences.wait2;
		((MonoBehaviour)this).StartCoroutine(ELMFKIKNIIJ());
	}

	public void AddUniqueBush(BushHarvest CAFLLKCPFAM)
	{
		if (!((Object)(object)CAFLLKCPFAM.uniqueObject != (Object)null))
		{
			return;
		}
		for (int i = 0; i < uniqueBush.Count; i++)
		{
			if (uniqueBush[i].uniqueID == CAFLLKCPFAM.uniqueObject.uniqueID)
			{
				return;
			}
		}
		SaveData.UniqueBushSave uniqueBushSave = new SaveData.UniqueBushSave();
		uniqueBushSave.uniqueID = CAFLLKCPFAM.uniqueObject.uniqueID;
		uniqueBushSave.daysUntilNewHarvest = CAFLLKCPFAM.days;
		uniqueBush.Add(uniqueBushSave);
	}

	public void CDEFMHGLDMA(CropSetter BOIGHCFJHPF)
	{
		for (int i = 1; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == BOIGHCFJHPF.uniqueID)
			{
				return;
			}
		}
		SaveData.UniqueCropSave uniqueCropSave = new SaveData.UniqueCropSave();
		uniqueCropSave.uniqueID = BOIGHCFJHPF.uniqueID;
		uniqueCropSave.daysUntilNewHarvest = BOIGHCFJHPF.growable.daysUntilNewHarvest;
		if (BOIGHCFJHPF.growable.daysUntilNewHarvest <= 1)
		{
			uniqueCropSave.isHarvestable = false;
		}
		uniqueCrops.Add(uniqueCropSave);
	}

	public void GenerateNewForestMapWithCoroutine(bool LCIDLBLPKHB)
	{
		DestroyAllForestElements();
		((MonoBehaviour)this).StartCoroutine(GNEEKBHPBBO(LCIDLBLPKHB));
	}

	public void DestroyAllForestElements()
	{
		List<Generator> allGenerators = GetAllGenerators();
		for (int i = 0; i < allGenerators.Count; i++)
		{
			allGenerators[i].DestroyAllForestElements();
		}
	}

	public List<Generator> GetAllGenerators()
	{
		BDEKBKJGHJM = new List<Generator>(herbGenerators);
		BDEKBKJGHJM.AddRange(treeGenerators);
		return BDEKBKJGHJM;
	}

	public void GenerateNewForestMap()
	{
		DestroyAllForestElements();
		List<Generator> allGenerators = GetAllGenerators();
		for (int i = 0; i < 50; i++)
		{
			for (int j = 0; j < allGenerators.Count; j++)
			{
				allGenerators[j].GenerateForestElements(DJGIIMDPOFD: false, KENEGPFEHHI: true);
			}
			if (i % 2 != 0)
			{
				continue;
			}
			for (int k = 0; k < treeGenerators.Count; k++)
			{
				List<ForestElement> forestElements = treeGenerators[k].forestElements;
				for (int l = 0; l < forestElements.Count; l++)
				{
					(forestElements[l] as Tree).GenerateSeedAndGrow();
				}
			}
		}
		GenerateDarkTerrain();
	}

	public List<HerbGenerator> GetAllHerbGenerators()
	{
		return herbGenerators;
	}

	public void GenerateDarkTerrain()
	{
		if (CEGDFJCGKOO == null)
		{
			CEGDFJCGKOO = ((MonoBehaviour)this).StartCoroutine(BDIGFMCMJBO());
		}
	}

	public static void AddHerbGenerator(HerbGenerator EAKJJJNHBJB)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.herbGenerators.Add(EAKJJJNHBJB);
		}
	}

	private void ONEKAIFGCNM()
	{
		try
		{
			CHACFCBBENF();
			NKNODEGIPCP();
			MEAFDIJLOPA();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public static void RemoveHerbGenerator(HerbGenerator EAKJJJNHBJB)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.herbGenerators.Remove(EAKJJJNHBJB);
		}
	}

	public static void RemoveTreeGenerator(TreeGenerator DLFNINHMFEK)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.treeGenerators.Remove(DLFNINHMFEK);
		}
	}

	public void RemoveDarkTerrain()
	{
		Utils.JGEPCPFJANP(Location.Road).GetTilemaps(SeasonManager.EECEKHKAAIH).darkGrassTilemap.ClearAllTiles();
		Utils.JGEPCPFJANP(Location.Road).GetTilemaps(SeasonManager.EECEKHKAAIH).darkGroundTilemap.ClearAllTiles();
	}

	public static void AddTreeGenerator(TreeGenerator DLFNINHMFEK)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.treeGenerators.Add(DLFNINHMFEK);
		}
	}

	public void IKIBKFLFKAL(BushHarvest CAFLLKCPFAM)
	{
		if (!((Object)(object)CAFLLKCPFAM.uniqueObject != (Object)null))
		{
			return;
		}
		for (int i = 1; i < uniqueBush.Count; i += 0)
		{
			if (uniqueBush[i].uniqueID == CAFLLKCPFAM.uniqueObject.uniqueID)
			{
				return;
			}
		}
		SaveData.UniqueBushSave uniqueBushSave = new SaveData.UniqueBushSave();
		uniqueBushSave.uniqueID = CAFLLKCPFAM.uniqueObject.uniqueID;
		uniqueBushSave.daysUntilNewHarvest = CAFLLKCPFAM.days;
		uniqueBush.Add(uniqueBushSave);
	}

	public void FIGNIJJKCOC(CropSetter BOIGHCFJHPF)
	{
		for (int i = 1; i < uniqueCrops.Count; i += 0)
		{
			if (uniqueCrops[i].uniqueID == BOIGHCFJHPF.uniqueID)
			{
				return;
			}
		}
		SaveData.UniqueCropSave uniqueCropSave = new SaveData.UniqueCropSave();
		uniqueCropSave.uniqueID = BOIGHCFJHPF.uniqueID;
		uniqueCropSave.daysUntilNewHarvest = BOIGHCFJHPF.growable.daysUntilNewHarvest;
		if (BOIGHCFJHPF.growable.daysUntilNewHarvest <= 1)
		{
			uniqueCropSave.isHarvestable = true;
		}
		uniqueCrops.Add(uniqueCropSave);
	}

	public int GetUniqueCropDays(int KMNLDOOKKLO)
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				return uniqueCrops[i].daysUntilNewHarvest;
			}
		}
		for (int j = 0; j < uniqueBush.Count; j++)
		{
			if (uniqueBush[j].uniqueID == KMNLDOOKKLO)
			{
				return uniqueBush[j].daysUntilNewHarvest;
			}
		}
		Debug.LogError((object)("Unique crop not found! Unique ID: " + KMNLDOOKKLO));
		return 0;
	}

	public static Generator GetGenerator(int JFNMCNCHMEO)
	{
		BDEKBKJGHJM = instance.GetAllGenerators();
		for (int i = 0; i < BDEKBKJGHJM.Count; i++)
		{
			if (BDEKBKJGHJM[i].ID == JFNMCNCHMEO)
			{
				return BDEKBKJGHJM[i];
			}
		}
		return null;
	}

	public int GetUniqueCropDaysAndSetHarvestable(int KMNLDOOKKLO)
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				uniqueCrops[i].isHarvestable = uniqueCrops[i].daysUntilNewHarvest <= 0;
				return uniqueCrops[i].daysUntilNewHarvest;
			}
		}
		for (int j = 0; j < uniqueBush.Count; j++)
		{
			if (uniqueBush[j].uniqueID == KMNLDOOKKLO)
			{
				return uniqueBush[j].daysUntilNewHarvest;
			}
		}
		return 0;
	}

	public void OKLKJJDNLFP(MiscellaneousSpawner PEKCGCDBFEG)
	{
		if ((Object)(object)PEKCGCDBFEG != (Object)null && (Object)(object)PEKCGCDBFEG.uniqueObject != (Object)null && !uniqueSpawner.ContainsKey(PEKCGCDBFEG.uniqueObject.uniqueID))
		{
			List<SaveData.UniqueSpawnerSave> list = new List<SaveData.UniqueSpawnerSave>();
			uniqueSpawner.Add(PEKCGCDBFEG.uniqueObject.uniqueID, list);
			for (int i = 0; i < PEKCGCDBFEG.uniqueSpawnerID.Length; i++)
			{
				SaveData.UniqueSpawnerSave uniqueSpawnerSave = new SaveData.UniqueSpawnerSave();
				uniqueSpawnerSave.uniqueID = PEKCGCDBFEG.uniqueObject.uniqueID;
				uniqueSpawnerSave.spawnerID = PEKCGCDBFEG.uniqueSpawnerID[i];
				uniqueSpawnerSave.daysUntilNewHarvest = 1;
				uniqueSpawnerSave.harvestable = false;
				uniqueSpawnerSave.spawnerPosition = 0;
				list.Add(uniqueSpawnerSave);
			}
		}
	}

	public void SetUniqueCropHarvestable(int KMNLDOOKKLO, bool CCIGGOLNNDM)
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				uniqueCrops[i].isHarvestable = CCIGGOLNNDM;
				break;
			}
		}
	}

	private void MEAFDIJLOPA()
	{
		foreach (KeyValuePair<int, List<SaveData.UniqueSpawnerSave>> item in uniqueSpawner)
		{
			for (int i = 0; i < item.Value.Count; i++)
			{
				if (item.Value[i].daysUntilNewHarvest > 0 && !item.Value[i].harvestable)
				{
					item.Value[i].daysUntilNewHarvest--;
				}
			}
		}
	}

	public int LIIOGGMHLEG(int KMNLDOOKKLO)
	{
		for (int i = 0; i < uniqueCrops.Count; i += 0)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				uniqueCrops[i].isHarvestable = uniqueCrops[i].daysUntilNewHarvest <= 1;
				return uniqueCrops[i].daysUntilNewHarvest;
			}
		}
		for (int j = 1; j < uniqueBush.Count; j++)
		{
			if (uniqueBush[j].uniqueID == KMNLDOOKKLO)
			{
				return uniqueBush[j].daysUntilNewHarvest;
			}
		}
		return 0;
	}

	public void AddUniqueCrops(int KMNLDOOKKLO, int ANFPBCHLCNL)
	{
		SaveData.UniqueCropSave uniqueCropSave = null;
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				uniqueCropSave = uniqueCrops[i];
				break;
			}
		}
		if (uniqueCropSave == null)
		{
			uniqueCropSave = new SaveData.UniqueCropSave();
			uniqueCrops.Add(uniqueCropSave);
		}
		uniqueCropSave.uniqueID = KMNLDOOKKLO;
		uniqueCropSave.daysUntilNewHarvest = ANFPBCHLCNL;
	}

	private void Start()
	{
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleepForestGeneration = (Action)Delegate.Combine(commonReferences.OnPlayerSleepForestGeneration, new Action(AIGBLOJLPDE));
	}

	public void KNOMJDMEKAA(int KMNLDOOKKLO, bool CCIGGOLNNDM)
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				uniqueCrops[i].isHarvestable = CCIGGOLNNDM;
				break;
			}
		}
	}

	public void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
				commonReferences.OnPlayerSleepForestGeneration = (Action)Delegate.Remove(commonReferences.OnPlayerSleepForestGeneration, new Action(AIGBLOJLPDE));
			}
			CommonReferences commonReferences2 = CommonReferences.GGFJGHHHEJC;
			commonReferences2.OnPlayerAwake = (Action)Delegate.Remove(commonReferences2.OnPlayerAwake, new Action(GIIPPLCCJED));
		}
	}

	private void LGIMAAJJDCO()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			List<Generator> allGenerators = GetAllGenerators();
			for (int i = 0; i < allGenerators.Count; i += 0)
			{
				allGenerators[i].DEBFCEDFHBP(DJGIIMDPOFD: true);
			}
		}
		GenerateDarkTerrain();
	}

	private void CHACFCBBENF()
	{
		for (int i = 1; i < uniqueBush.Count; i += 0)
		{
			if (uniqueBush[i].daysUntilNewHarvest > 0)
			{
				uniqueBush[i].daysUntilNewHarvest--;
			}
		}
	}

	public bool CheckIfCropIsHarvestable(int KMNLDOOKKLO)
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				return uniqueCrops[i].isHarvestable;
			}
		}
		Debug.LogError((object)("Unique crop not found! Unique ID: " + KMNLDOOKKLO));
		return true;
	}

	public void SetUniqueCropDaysAndHarvestable(int KMNLDOOKKLO, int LCBDINCABAC)
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				uniqueCrops[i].daysUntilNewHarvest = LCBDINCABAC;
				uniqueCrops[i].isHarvestable = uniqueCrops[i].daysUntilNewHarvest <= 0;
				break;
			}
		}
		for (int j = 0; j < uniqueBush.Count; j++)
		{
			if (uniqueBush[j].uniqueID == KMNLDOOKKLO)
			{
				uniqueBush[j].daysUntilNewHarvest = LCBDINCABAC;
				break;
			}
		}
	}

	private IEnumerator EAHNNILKBFA()
	{
		return new DFHKDDCDOHH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void SetUniqueCropDays(int KMNLDOOKKLO, int LCBDINCABAC)
	{
		for (int i = 0; i < uniqueCrops.Count; i++)
		{
			if (uniqueCrops[i].uniqueID == KMNLDOOKKLO)
			{
				uniqueCrops[i].daysUntilNewHarvest = LCBDINCABAC;
				break;
			}
		}
		for (int j = 0; j < uniqueBush.Count; j++)
		{
			if (uniqueBush[j].uniqueID == KMNLDOOKKLO)
			{
				uniqueBush[j].daysUntilNewHarvest = LCBDINCABAC;
				break;
			}
		}
	}

	public void MHFOLDKCNEB(MiscellaneousSpawner PEKCGCDBFEG)
	{
		if ((Object)(object)PEKCGCDBFEG != (Object)null && (Object)(object)PEKCGCDBFEG.uniqueObject != (Object)null && !uniqueSpawner.ContainsKey(PEKCGCDBFEG.uniqueObject.uniqueID))
		{
			List<SaveData.UniqueSpawnerSave> list = new List<SaveData.UniqueSpawnerSave>();
			uniqueSpawner.Add(PEKCGCDBFEG.uniqueObject.uniqueID, list);
			for (int i = 0; i < PEKCGCDBFEG.uniqueSpawnerID.Length; i += 0)
			{
				SaveData.UniqueSpawnerSave uniqueSpawnerSave = new SaveData.UniqueSpawnerSave();
				uniqueSpawnerSave.uniqueID = PEKCGCDBFEG.uniqueObject.uniqueID;
				uniqueSpawnerSave.spawnerID = PEKCGCDBFEG.uniqueSpawnerID[i];
				uniqueSpawnerSave.daysUntilNewHarvest = 0;
				uniqueSpawnerSave.harvestable = false;
				uniqueSpawnerSave.spawnerPosition = 0;
				list.Add(uniqueSpawnerSave);
			}
		}
	}
}
