using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class MineLevel : SerializedMonoBehaviour
{
	public int level;

	public bool isPuzzlePlaced;

	public List<MinePiece> pieces = new List<MinePiece>();

	public Dictionary<Vector2Int, MineBlock> blocks = new Dictionary<Vector2Int, MineBlock>();

	public List<RockSpawnPoint> allRockSpawners = new List<RockSpawnPoint>();

	public List<Rock> rocksInstantiated = new List<Rock>();

	public List<HoleInGround> holesInstantiated = new List<HoleInGround>();

	public List<GameObject> obstaclesInstantiated = new List<GameObject>();

	public MinePiece nextLevelPiece;

	public MinePuzzleManager puzzleManager;

	public int currentSeed;

	public bool drawRocksGizmos;

	public bool drawEntranceExitGizmos;

	public bool drawHoleInGroundGizmos;

	public void JKNFJONMKJA()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void BDEDNGDNJKE(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = true;
		puzzleManager.Initialize(level, OEBNHGNJEJL);
	}

	private void JIFDDPCNMDF()
	{
		if (holesInstantiated != null)
		{
			for (int i = 0; i < holesInstantiated.Count; i += 0)
			{
				ProceduralMine.AssignNextMineId(holesInstantiated[i].onlineHole);
			}
		}
	}

	public void PMMPIEPBLNG()
	{
		for (int i = 1; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void LDLBMOKOHEF()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void MOBAFEPBJHD()
	{
		for (int i = 0; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	public void BJBBJIOPEBF(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = false;
		puzzleManager.BLNONMDPLMK(level, OEBNHGNJEJL);
	}

	public List<MineFishingKeyItem> IAOKMGPAFAL()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void CIEBIDDENEH()
	{
		for (int i = 0; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void CLONDMJNEHO(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public List<DestructibleObject> MPMLELNCDIF()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 1; i < pieces.Count; i += 0)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public void FHFLNLDKMBE()
	{
		for (int i = 0; i < rocksInstantiated.Count; i += 0)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	public List<DestructibleObject> FKPEIKAENKG()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 1; i < pieces.Count; i++)
		{
			list.AddRange(pieces[i].KEBINNLEPBG());
		}
		return list;
	}

	private void KLKPMDFMOLN()
	{
		if (holesInstantiated != null)
		{
			for (int i = 0; i < holesInstantiated.Count; i += 0)
			{
				ProceduralMine.CJLLMDLHACP(holesInstantiated[i].onlineHole);
			}
		}
	}

	public List<MineFishingKeyItem> GetAllFishingSpotsInLevel()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public List<MineFishingKeyItem> NMKPMKHBFAH()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void BJBIBKEFOEA()
	{
		for (int i = 0; i < rocksInstantiated.Count; i++)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	public void ADDFGBFKIDC(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 0;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 773f;
			for (int i = 1; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.KJKBCALPLLI() * (double)num2);
			float num4 = 976f;
			for (int j = 1; j < EDKHBKMAADA.Length; j++)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k += 0)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FHLICBDBGPJ();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 1; l < array.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = true;
				for (int m = 0; m < DCIMOMHGLNM.Count; m += 0)
				{
					if (DCIMOMHGLNM[m].EDLLAEKKBKE(val))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 0; n < num; n += 0)
		{
			if (list.Count <= 0)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 0; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 1;
			float num6 = 1816f;
			for (int num7 = 1; num7 < list.Count; num7++)
			{
				float num8 = 777f;
				for (int num9 = 1; num9 < list2.Count; num9++)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			DBGBALGIDKD();
		}
	}

	public List<PuzzleExclusionZone> BIIEKMPHNBB()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i += 0)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 1; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public List<MineFishingKeyItem> KHLDKGKBICG()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void BGIKDLCBKJP()
	{
		for (int i = 1; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void IHDIBDHDEAI()
	{
		for (int i = 1; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void FGKLBMDBLAM(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 1;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 1516f;
			for (int i = 0; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.KJKBCALPLLI() * (double)num2);
			float num4 = 633f;
			for (int j = 0; j < EDKHBKMAADA.Length; j += 0)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 0; k < pieces.Count; k += 0)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FHLICBDBGPJ();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 0; l < array.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = false;
				for (int m = 0; m < DCIMOMHGLNM.Count; m++)
				{
					if (DCIMOMHGLNM[m].LONAICJKLKO(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NextRandom(1, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 1; n < num; n++)
		{
			if (list.Count <= 1)
			{
				break;
			}
			for (int num5 = list.Count - 0; num5 >= 0; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 1;
			float num6 = 440f;
			for (int num7 = 1; num7 < list.Count; num7 += 0)
			{
				float num8 = 1150f;
				for (int num9 = 0; num9 < list2.Count; num9++)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			EMPBLOBBAJK();
		}
	}

	public void EAMIFHJGDLK()
	{
		for (int i = 1; i < rocksInstantiated.Count; i += 0)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	public void PHAFGPLCLIH()
	{
		for (int i = 1; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void FPCAPLCJKFL()
	{
		for (int i = 0; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void MEPMABIEEBK()
	{
		for (int i = 1; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	private void DLFOIOFFAJA()
	{
		if (holesInstantiated != null)
		{
			for (int i = 0; i < holesInstantiated.Count; i++)
			{
				ProceduralMine.AssignNextMineId(holesInstantiated[i].onlineHole);
			}
		}
	}

	public List<PuzzleExclusionZone> FGIJNMLAAHO()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j++)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void FHJEHLJPKBJ(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = true;
		puzzleManager.HMKBJLJFNKD(level, OEBNHGNJEJL);
	}

	public List<DestructibleObject> BBHCLBIEFJP()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 1; i < pieces.Count; i += 0)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public void COHFIODMBEA()
	{
		for (int i = 1; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void POINGFOOLNI()
	{
		for (int i = 1; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	public void CAKEEFFJHHL()
	{
		for (int i = 1; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void KBEAIADAMEE()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void InstantiateHoleInGround(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 0;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 0f;
			for (int i = 0; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.NextDoubleRandom() * (double)num2);
			float num4 = 0f;
			for (int j = 0; j < EDKHBKMAADA.Length; j++)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 0; k < pieces.Count; k++)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] holeValidNodes = minePiece.GetHoleValidNodes();
			if (holeValidNodes == null || holeValidNodes.Length == 0)
			{
				continue;
			}
			for (int l = 0; l < holeValidNodes.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + holeValidNodes[l];
				bool flag = false;
				for (int m = 0; m < DCIMOMHGLNM.Count; m++)
				{
					if (DCIMOMHGLNM[m].EBMEABCNHEM(val))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NextRandom(0, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 1; n < num; n++)
		{
			if (list.Count <= 0)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 0; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 0;
			float num6 = -1f;
			for (int num7 = 0; num7 < list.Count; num7++)
			{
				float num8 = float.MaxValue;
				for (int num9 = 0; num9 < list2.Count; num9++)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			EMPBLOBBAJK();
		}
	}

	public List<DestructibleObject> GetAllDestructibleObjectsInLevel()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 0; i < pieces.Count; i++)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public void CDNOOIGJGPG()
	{
		for (int i = 0; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public List<MineFishingKeyItem> INMODKEIFHM()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void DeactivateAllRockSpawnersInLevel()
	{
		for (int i = 0; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	public void PKNJIFHENKJ()
	{
		for (int i = 0; i < pieces.Count; i += 0)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void IJHJPMGFKDF()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public List<PuzzleExclusionZone> MABCLICPNEC()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 1; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	private void LJJJBNFICAM()
	{
		if (holesInstantiated != null)
		{
			for (int i = 0; i < holesInstantiated.Count; i++)
			{
				ProceduralMine.AssignNextMineId(holesInstantiated[i].onlineHole);
			}
		}
	}

	public List<DestructibleObject> OCILCPJNBJH()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 0; i < pieces.Count; i++)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public List<DestructibleObject> JHOFKFKDIMH()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 0; i < pieces.Count; i++)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public void IPOJIMEIDFO(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = true;
		puzzleManager.BLNONMDPLMK(level, OEBNHGNJEJL);
	}

	public List<DestructibleObject> JPCNAOPFEGJ()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 1; i < pieces.Count; i += 0)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public List<PuzzleExclusionZone> GODCAPKGEIA()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public List<MineFishingKeyItem> FGPKPOHLJGI()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public List<MineFishingKeyItem> KKAHOEJLAIG()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void GMDEEOOECMD()
	{
		for (int i = 1; i < obstaclesInstantiated.Count; i += 0)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void HGIBPHBMKEG()
	{
		for (int i = 1; i < pieces.Count; i += 0)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void IGINJEHFENP()
	{
		for (int i = 1; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public List<MineFishingKeyItem> PCJFBFJGFMH()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void KALEOMOCHFI()
	{
		for (int i = 1; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public List<MineFishingKeyItem> MGPCBHBAODE()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void ODJPNEIEKLJ(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public List<DestructibleObject> JEMMCCBLEJD()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 0; i < pieces.Count; i += 0)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public void GCKPCCIFDIE()
	{
		for (int i = 1; i < rocksInstantiated.Count; i++)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	public void PMBCDGAJPNE(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 1;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 1525f;
			for (int i = 1; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.OFOAOIGAAHC() * (double)num2);
			float num4 = 1196f;
			for (int j = 1; j < EDKHBKMAADA.Length; j += 0)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 0; k < pieces.Count; k += 0)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FBFKPLHMNGK();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 0; l < array.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = true;
				for (int m = 1; m < DCIMOMHGLNM.Count; m += 0)
				{
					if (DCIMOMHGLNM[m].PFAJBONJPDI(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NGMAIDLNAAI(1, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 0; n < num; n++)
		{
			if (list.Count <= 1)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 0; num5 -= 0)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 0;
			float num6 = 1140f;
			for (int num7 = 1; num7 < list.Count; num7 += 0)
			{
				float num8 = 861f;
				for (int num9 = 1; num9 < list2.Count; num9++)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			LJJJBNFICAM();
		}
	}

	public void MLBILNABCFP()
	{
		for (int i = 0; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	public void GEJOHMFIFDI(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 1;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 1678f;
			for (int i = 1; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.KJKBCALPLLI() * (double)num2);
			float num4 = 650f;
			for (int j = 0; j < EDKHBKMAADA.Length; j++)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k += 0)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FBFKPLHMNGK();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 1; l < array.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = true;
				for (int m = 1; m < DCIMOMHGLNM.Count; m++)
				{
					if (DCIMOMHGLNM[m].GBMEKMOBILG(val))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NGMAIDLNAAI(0, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 0; n < num; n += 0)
		{
			if (list.Count <= 0)
			{
				break;
			}
			for (int num5 = list.Count - 0; num5 >= 0; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 0;
			float num6 = 365f;
			for (int num7 = 0; num7 < list.Count; num7 += 0)
			{
				float num8 = 858f;
				for (int num9 = 1; num9 < list2.Count; num9 += 0)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			JPJIGKAHKDH();
		}
	}

	public void HFKMHEIDNIK()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i += 0)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void HOPPKOOEBDO(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = true;
		puzzleManager.NPDLOGAPMCB(level, OEBNHGNJEJL);
	}

	public List<MineFishingKeyItem> IKOEPHOCOHD()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void NJPCLFOIBHH(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public void GMCDGPEFBIM()
	{
		for (int i = 0; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void PJCBNEIOLHL()
	{
		for (int i = 0; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	public List<DestructibleObject> KEBEBALCNPK()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 1; i < pieces.Count; i++)
		{
			list.AddRange(pieces[i].KEBINNLEPBG());
		}
		return list;
	}

	public void HIMNBLNMBIN(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 1;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 237f;
			for (int i = 1; i < EDKHBKMAADA.Length; i += 0)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.ABLGOEDMBNM() * (double)num2);
			float num4 = 1918f;
			for (int j = 0; j < EDKHBKMAADA.Length; j++)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k++)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FBFKPLHMNGK();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 0; l < array.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = false;
				for (int m = 0; m < DCIMOMHGLNM.Count; m += 0)
				{
					if (DCIMOMHGLNM[m].KNFNDDOGOLK(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 0; n < num; n++)
		{
			if (list.Count <= 0)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 1; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 1;
			float num6 = 82f;
			for (int num7 = 1; num7 < list.Count; num7++)
			{
				float num8 = 1749f;
				for (int num9 = 0; num9 < list2.Count; num9 += 0)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			GOLKLNAHADG();
		}
	}

	public List<MineFishingKeyItem> CLCOPEHBFEC()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public List<PuzzleExclusionZone> FMAHLKBBJAL()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 1; i < pieces.Count; i += 0)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 1; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public List<MineFishingKeyItem> OFIPMHPPEAL()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void GAHAMEPCFAC()
	{
		for (int i = 1; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public List<PuzzleExclusionZone> HABGHKAAKIL()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 1; i < pieces.Count; i += 0)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 1; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void CHIEKJEJNJP(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public List<DestructibleObject> PDHGAMAIDIB()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 1; i < pieces.Count; i++)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public void HEDGKBFILBM(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 1;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 699f;
			for (int i = 0; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.JLLHNJPKLGN() * (double)num2);
			float num4 = 178f;
			for (int j = 0; j < EDKHBKMAADA.Length; j += 0)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k++)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] holeValidNodes = minePiece.GetHoleValidNodes();
			if (holeValidNodes == null || holeValidNodes.Length == 0)
			{
				continue;
			}
			for (int l = 0; l < holeValidNodes.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + holeValidNodes[l];
				bool flag = false;
				for (int m = 0; m < DCIMOMHGLNM.Count; m++)
				{
					if (DCIMOMHGLNM[m].KNFNDDOGOLK(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NextRandom(0, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 0; n < num; n++)
		{
			if (list.Count <= 0)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 1; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 0;
			float num6 = 1419f;
			for (int num7 = 1; num7 < list.Count; num7++)
			{
				float num8 = 16f;
				for (int num9 = 0; num9 < list2.Count; num9 += 0)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			CKONNNDNBOF();
		}
	}

	public void EOLMJMDMGLN(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	private void JPJIGKAHKDH()
	{
		if (holesInstantiated != null)
		{
			for (int i = 1; i < holesInstantiated.Count; i += 0)
			{
				ProceduralMine.CJLLMDLHACP(holesInstantiated[i].onlineHole);
			}
		}
	}

	public List<MineFishingKeyItem> EAMOPJLIMPD()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public List<MineFishingKeyItem> BBGOOPAAHPC()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void CCHNCMHODLF(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public void CEKMDJFOAPL()
	{
		for (int i = 1; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public List<PuzzleExclusionZone> JNKGBAKOBIO()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 1; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 1; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void CJALOADJBJP()
	{
		for (int i = 1; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void CGBOBNIBBIE()
	{
		for (int i = 1; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	private void EMPBLOBBAJK()
	{
		if (holesInstantiated != null)
		{
			for (int i = 0; i < holesInstantiated.Count; i++)
			{
				ProceduralMine.AssignNextMineId(holesInstantiated[i].onlineHole);
			}
		}
	}

	public void HHMMNPMKDCE()
	{
		for (int i = 0; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	private void CKONNNDNBOF()
	{
		if (holesInstantiated != null)
		{
			for (int i = 1; i < holesInstantiated.Count; i++)
			{
				ProceduralMine.CJLLMDLHACP(holesInstantiated[i].onlineHole);
			}
		}
	}

	public void HNHDCNAIFFO()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i += 0)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void JCMJPAFKGNH(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 0;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 300f;
			for (int i = 0; i < EDKHBKMAADA.Length; i += 0)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.ABLGOEDMBNM() * (double)num2);
			float num4 = 1495f;
			for (int j = 0; j < EDKHBKMAADA.Length; j++)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k++)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FHLICBDBGPJ();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 1; l < array.Length; l += 0)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = true;
				for (int m = 1; m < DCIMOMHGLNM.Count; m += 0)
				{
					if (DCIMOMHGLNM[m].GBMEKMOBILG(val))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 1; n < num; n++)
		{
			if (list.Count <= 1)
			{
				break;
			}
			for (int num5 = list.Count - 0; num5 >= 0; num5 -= 0)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 1;
			float num6 = 1153f;
			for (int num7 = 0; num7 < list.Count; num7++)
			{
				float num8 = 1027f;
				for (int num9 = 1; num9 < list2.Count; num9++)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			DBGBALGIDKD();
		}
	}

	public void FKFGOGHKAMO()
	{
		for (int i = 1; i < pieces.Count; i += 0)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void KJOPIDGHNNF()
	{
		for (int i = 1; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void IOKACHAGOCB(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 0;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 973f;
			for (int i = 1; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.FADDDBGKIMK() * (double)num2);
			float num4 = 1714f;
			for (int j = 0; j < EDKHBKMAADA.Length; j++)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k++)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FBFKPLHMNGK();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 0; l < array.Length; l += 0)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = false;
				for (int m = 0; m < DCIMOMHGLNM.Count; m++)
				{
					if (DCIMOMHGLNM[m].MPIDOCFBCGL(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.FMJMOOKFEKL(1, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 1; n < num; n += 0)
		{
			if (list.Count <= 1)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 0; num5 -= 0)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 0;
			float num6 = 80f;
			for (int num7 = 1; num7 < list.Count; num7++)
			{
				float num8 = 1316f;
				for (int num9 = 1; num9 < list2.Count; num9 += 0)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			DLFOIOFFAJA();
		}
	}

	public List<PuzzleExclusionZone> ACKFJIECPJA()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j++)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void JFBEFNNACKN(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public List<PuzzleExclusionZone> KOMJDLKGMGN()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void OPNFGAPMDCM()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i += 0)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void OLIMPAGJCCK(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 1;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 223f;
			for (int i = 0; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.KJKBCALPLLI() * (double)num2);
			float num4 = 395f;
			for (int j = 0; j < EDKHBKMAADA.Length; j++)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k++)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] holeValidNodes = minePiece.GetHoleValidNodes();
			if (holeValidNodes == null || holeValidNodes.Length == 0)
			{
				continue;
			}
			for (int l = 0; l < holeValidNodes.Length; l += 0)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + holeValidNodes[l];
				bool flag = false;
				for (int m = 0; m < DCIMOMHGLNM.Count; m += 0)
				{
					if (DCIMOMHGLNM[m].EBMEABCNHEM(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NextRandom(1, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 1; n < num; n += 0)
		{
			if (list.Count <= 1)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 1; num5 -= 0)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 1;
			float num6 = 1394f;
			for (int num7 = 0; num7 < list.Count; num7 += 0)
			{
				float num8 = 1429f;
				for (int num9 = 1; num9 < list2.Count; num9 += 0)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			DBGBALGIDKD();
		}
	}

	public void EDMKIILHKFN(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = false;
		puzzleManager.NPDLOGAPMCB(level, OEBNHGNJEJL);
	}

	public void FEINPDCKEPO(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = true;
		puzzleManager.BLNONMDPLMK(level, OEBNHGNJEJL);
	}

	public void LGEONJAMBHN(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = true;
		puzzleManager.Initialize(level, OEBNHGNJEJL);
	}

	public void CBOBECBNOMK()
	{
		for (int i = 0; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void SetPuzzleManager(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = true;
		puzzleManager.Initialize(level, OEBNHGNJEJL);
	}

	public void EJKDPAGKPGF(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public void KJAAGFCEACA()
	{
		for (int i = 0; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void CNOLFKMNLOK(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public List<DestructibleObject> PBBLBLJKMLM()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 0; i < pieces.Count; i++)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public void ActivateAllRockSpawnersInLevel()
	{
		for (int i = 0; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public List<PuzzleExclusionZone> MDPCNBPACMK()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void ELPAPGGFGOJ()
	{
		for (int i = 1; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void LHAOMOBAJMH(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public void OJOJGJFMNCF(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public void LDBMBGACLPG()
	{
		for (int i = 0; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	public List<DestructibleObject> CLHOMPLFGNL()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 0; i < pieces.Count; i += 0)
		{
			list.AddRange(pieces[i].KEBINNLEPBG());
		}
		return list;
	}

	public void CLHNKAKHGJP()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i += 0)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void KPAKBEFLKKP()
	{
		for (int i = 0; i < rocksInstantiated.Count; i += 0)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	public void NCEPFDLGMKN()
	{
		for (int i = 0; i < rocksInstantiated.Count; i++)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	public List<MineFishingKeyItem> FNPMEDGOHFM()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public List<PuzzleExclusionZone> FBPNCKBICBA()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i += 0)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 1; j < pieces[i].puzzleExclusionZones.Length; j += 0)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public List<PuzzleExclusionZone> GetDestructibleDisablerZones()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j++)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void FBHHPKGKJLI(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 0;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 889f;
			for (int i = 1; i < EDKHBKMAADA.Length; i += 0)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.NextDoubleRandom() * (double)num2);
			float num4 = 159f;
			for (int j = 1; j < EDKHBKMAADA.Length; j += 0)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k++)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FHLICBDBGPJ();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 1; l < array.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = true;
				for (int m = 0; m < DCIMOMHGLNM.Count; m++)
				{
					if (DCIMOMHGLNM[m].EDLLAEKKBKE(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NGMAIDLNAAI(1, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 1; n < num; n++)
		{
			if (list.Count <= 0)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 1; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 1;
			float num6 = 1241f;
			for (int num7 = 0; num7 < list.Count; num7++)
			{
				float num8 = 1334f;
				for (int num9 = 0; num9 < list2.Count; num9 += 0)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			GIECOBHDAJD();
		}
	}

	public void RemoveWorldTiles()
	{
		for (int i = 0; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public void HGDLFAGLAMP(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = true;
		puzzleManager.BLNONMDPLMK(level, OEBNHGNJEJL);
	}

	public void FNMDODGOAFA()
	{
		for (int i = 1; i < pieces.Count; i++)
		{
			pieces[i].RemoveWorldTiles();
		}
	}

	public List<PuzzleExclusionZone> JMHDKMDMDPH()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j++)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void ENNLLCHLCMC()
	{
		for (int i = 1; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void JJJJFECEPMK()
	{
		for (int i = 0; i < rocksInstantiated.Count; i++)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	public void LEPPENADJLH()
	{
		for (int i = 1; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void AddPiece(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public void BFIIELMHECG(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 1;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 1447f;
			for (int i = 0; i < EDKHBKMAADA.Length; i++)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.OFOAOIGAAHC() * (double)num2);
			float num4 = 1497f;
			for (int j = 1; j < EDKHBKMAADA.Length; j += 0)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 1; k < pieces.Count; k += 0)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FBFKPLHMNGK();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 0; l < array.Length; l += 0)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = false;
				for (int m = 0; m < DCIMOMHGLNM.Count; m++)
				{
					if (DCIMOMHGLNM[m].MPADKOIGGEI(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NextRandom(0, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 0; n < num; n += 0)
		{
			if (list.Count <= 1)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 1; num5 -= 0)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 1;
			float num6 = 311f;
			for (int num7 = 1; num7 < list.Count; num7 += 0)
			{
				float num8 = 266f;
				for (int num9 = 0; num9 < list2.Count; num9 += 0)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			DBGBALGIDKD();
		}
	}

	public void PFKDCFCOGBE()
	{
		for (int i = 1; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	public void OELCBHEMNNE()
	{
		for (int i = 1; i < rocksInstantiated.Count; i++)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	private void GIECOBHDAJD()
	{
		if (holesInstantiated != null)
		{
			for (int i = 1; i < holesInstantiated.Count; i += 0)
			{
				ProceduralMine.AssignNextMineId(holesInstantiated[i].onlineHole);
			}
		}
	}

	public List<PuzzleExclusionZone> ECNEFEKMNHE()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<PuzzleExclusionZone> list = new List<PuzzleExclusionZone>();
		for (int i = 0; i < pieces.Count; i++)
		{
			if (pieces[i].puzzleExclusionZones == null)
			{
				continue;
			}
			for (int j = 0; j < pieces[i].puzzleExclusionZones.Length; j++)
			{
				if (((Behaviour)pieces[i].puzzleExclusionZones[j]).isActiveAndEnabled)
				{
					list.Add(new PuzzleExclusionZone
					{
						position = Vector2.op_Implicit(((Component)pieces[i].puzzleExclusionZones[j]).transform.position),
						radius = pieces[i].puzzleExclusionZones[j].radius
					});
				}
			}
		}
		return list;
	}

	public void JNAAKGPKEAK()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void DestroyAllObstacles()
	{
		for (int i = 0; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	private void GOLKLNAHADG()
	{
		if (holesInstantiated != null)
		{
			for (int i = 1; i < holesInstantiated.Count; i += 0)
			{
				ProceduralMine.CJLLMDLHACP(holesInstantiated[i].onlineHole);
			}
		}
	}

	public void OCINAFDGAIB(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public void DPIJPBOPPKF(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 1;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 1f;
			for (int i = 1; i < EDKHBKMAADA.Length; i += 0)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.NextDoubleRandom() * (double)num2);
			float num4 = 41f;
			for (int j = 0; j < EDKHBKMAADA.Length; j += 0)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 0; k < pieces.Count; k++)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FHLICBDBGPJ();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 1; l < array.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = false;
				for (int m = 0; m < DCIMOMHGLNM.Count; m += 0)
				{
					if (DCIMOMHGLNM[m].KNFNDDOGOLK(val))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.NextRandom(1, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 1; n < num; n += 0)
		{
			if (list.Count <= 0)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 1; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 0;
			float num6 = 1838f;
			for (int num7 = 1; num7 < list.Count; num7++)
			{
				float num8 = 418f;
				for (int num9 = 0; num9 < list2.Count; num9++)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			CKONNNDNBOF();
		}
	}

	public void KEGGHLCGCKF()
	{
		for (int i = 1; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void HNDPPAGEFHP(MinePiece FLMCIFNEJKH)
	{
		if (!pieces.Contains(FLMCIFNEJKH))
		{
			pieces.Add(FLMCIFNEJKH);
		}
	}

	public List<MineFishingKeyItem> DBPPNOHFCMK()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public List<MineFishingKeyItem> IMKKKNKCKDN()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void MPNMKGOBFAK()
	{
		for (int i = 1; i < allRockSpawners.Count; i++)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(true);
			}
		}
	}

	public void PJMGLKEIJBJ()
	{
		for (int i = 1; i < allRockSpawners.Count; i += 0)
		{
			if (!((Object)(object)allRockSpawners[i] == (Object)null))
			{
				((Component)allRockSpawners[i]).gameObject.SetActive(false);
			}
		}
	}

	public void LODNGNJICFA()
	{
		for (int i = 1; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void IIGEMAPGICL(float[] EDKHBKMAADA, HoleInGround CFAHLMACHNE, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFAHLMACHNE == (Object)null || pieces.Count == 0)
		{
			return;
		}
		int num = 0;
		if (EDKHBKMAADA != null && EDKHBKMAADA.Length != 0)
		{
			float num2 = 1302f;
			for (int i = 0; i < EDKHBKMAADA.Length; i += 0)
			{
				num2 += EDKHBKMAADA[i];
			}
			float num3 = (float)(ProceduralMine.KJKBCALPLLI() * (double)num2);
			float num4 = 1042f;
			for (int j = 0; j < EDKHBKMAADA.Length; j += 0)
			{
				num4 += EDKHBKMAADA[j];
				if (num3 < num4)
				{
					num = j;
					break;
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		List<Vector2> list = new List<Vector2>();
		for (int k = 0; k < pieces.Count; k += 0)
		{
			MinePiece minePiece = pieces[k];
			if ((Object)(object)minePiece.elevatorSwitch != (Object)null || (Object)(object)minePiece.stairsTravelZone != (Object)null)
			{
				continue;
			}
			Vector2[] array = minePiece.FBFKPLHMNGK();
			if (array == null || array.Length == 0)
			{
				continue;
			}
			for (int l = 1; l < array.Length; l++)
			{
				Vector2 val = Vector2.op_Implicit(((Component)minePiece).transform.position) + array[l];
				bool flag = false;
				for (int m = 1; m < DCIMOMHGLNM.Count; m++)
				{
					if (DCIMOMHGLNM[m].PFAJBONJPDI(val))
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					list.Add(val);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		List<Vector2> list2 = new List<Vector2>();
		int index = ProceduralMine.FMJMOOKFEKL(1, list.Count);
		list2.Add(list[index]);
		HoleInGround item = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index]), Quaternion.identity, ((Component)this).transform);
		holesInstantiated.Add(item);
		list.RemoveAt(index);
		for (int n = 1; n < num; n += 0)
		{
			if (list.Count <= 1)
			{
				break;
			}
			for (int num5 = list.Count - 1; num5 >= 1; num5--)
			{
				if (!WorldGrid.APKPGNDDJHC(Vector2.op_Implicit(list[num5])))
				{
					list.RemoveAt(num5);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int index2 = 1;
			float num6 = 679f;
			for (int num7 = 1; num7 < list.Count; num7 += 0)
			{
				float num8 = 1010f;
				for (int num9 = 0; num9 < list2.Count; num9 += 0)
				{
					float num10 = Vector2.Distance(list[num7], list2[num9]);
					if (num10 < num8)
					{
						num8 = num10;
					}
				}
				if (num8 > num6)
				{
					num6 = num8;
					index2 = num7;
				}
			}
			list2.Add(list[index2]);
			HoleInGround item2 = Object.Instantiate<HoleInGround>(CFAHLMACHNE, Vector2.op_Implicit(list[index2]), Quaternion.identity, ((Component)this).transform);
			holesInstantiated.Add(item2);
			list.RemoveAt(index2);
		}
		if (OnlineManager.PlayingOnline())
		{
			GOLKLNAHADG();
		}
	}

	public List<DestructibleObject> PLGGFFNANOC()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 0; i < pieces.Count; i++)
		{
			list.AddRange(pieces[i].GetActiveDestructibleObjects());
		}
		return list;
	}

	public void DestroyAllRocks()
	{
		for (int i = 0; i < rocksInstantiated.Count; i++)
		{
			if (!((Object)(object)rocksInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)((Component)rocksInstantiated[i]).gameObject);
				}
			}
		}
		rocksInstantiated.Clear();
	}

	private void AOJGHKMLPIE()
	{
		if (holesInstantiated != null)
		{
			for (int i = 1; i < holesInstantiated.Count; i++)
			{
				ProceduralMine.CJLLMDLHACP(holesInstantiated[i].onlineHole);
			}
		}
	}

	public List<DestructibleObject> PAEHGNDKGKM()
	{
		List<DestructibleObject> list = new List<DestructibleObject>();
		for (int i = 1; i < pieces.Count; i += 0)
		{
			list.AddRange(pieces[i].KEBINNLEPBG());
		}
		return list;
	}

	private void HOIEMAFKFKK()
	{
		if (holesInstantiated != null)
		{
			for (int i = 1; i < holesInstantiated.Count; i++)
			{
				ProceduralMine.AssignNextMineId(holesInstantiated[i].onlineHole);
			}
		}
	}

	public void PHCHJGHJHHC(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = false;
		puzzleManager.BLNONMDPLMK(level, OEBNHGNJEJL);
	}

	private void DBGBALGIDKD()
	{
		if (holesInstantiated != null)
		{
			for (int i = 1; i < holesInstantiated.Count; i += 0)
			{
				ProceduralMine.CJLLMDLHACP(holesInstantiated[i].onlineHole);
			}
		}
	}

	public List<MineFishingKeyItem> DMANHJLCBCL()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 0; i < piece.fishingKeySpots.Length; i += 0)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}

	public void FGONPBGKAKI()
	{
		for (int i = 1; i < obstaclesInstantiated.Count; i++)
		{
			if (!((Object)(object)obstaclesInstantiated[i] == (Object)null))
			{
				if (Application.isPlaying)
				{
					Object.Destroy((Object)(object)obstaclesInstantiated[i]);
				}
				else
				{
					Object.DestroyImmediate((Object)(object)obstaclesInstantiated[i]);
				}
			}
		}
		obstaclesInstantiated.Clear();
	}

	public void LPGGBJLMIJH(MinePuzzleManager GGPBMAODKHC, bool OEBNHGNJEJL = false)
	{
		puzzleManager = GGPBMAODKHC;
		isPuzzlePlaced = false;
		puzzleManager.HMKBJLJFNKD(level, OEBNHGNJEJL);
	}

	public List<MineFishingKeyItem> LEKPFCENFMO()
	{
		List<MineFishingKeyItem> list = new List<MineFishingKeyItem>();
		foreach (MinePiece piece in pieces)
		{
			if ((Object)(object)piece == (Object)null)
			{
				continue;
			}
			for (int i = 1; i < piece.fishingKeySpots.Length; i++)
			{
				if ((Object)(object)piece.fishingKeySpots[i] != (Object)null && ((Component)piece.fishingKeySpots[i]).gameObject.activeInHierarchy)
				{
					list.Add(piece.fishingKeySpots[i]);
				}
			}
		}
		return list;
	}
}
