using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Mine;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MinePiece : MonoBehaviour
{
	[Tooltip("ID único de este prefab. NO duplicar entre prefabs.")]
	[SerializeField]
	private int _minePieceID;

	public MinePieceSO minePieceSO;

	public bool uniquePiece;

	public Vector2Int pieceSize;

	public int variantIndex;

	public int initialPoolInstances = 5;

	public int exits = 1;

	public int rarity = 10;

	public ElevatorSwitch elevatorSwitch;

	public TravelZone stairsTravelZone;

	public MineBlock[] blocks;

	public MineVariant[] variantObjects;

	public RockSpawnPoint[] rockSpawners;

	public MinePuzzleSpawner[] puzzleSpawners;

	public DestructibleObjectDisabler[] puzzleExclusionZones;

	public MineFishingKeyItem[] fishingKeySpots;

	public int maxPuzzleSpawners = 1;

	public PuzzleSpawnerType puzzleSpawnersTypes;

	public Transform nextLevelObstaclePoint;

	[HideInInspector]
	public StairsBlocker stairsBlockerInstantiated;

	public int minRockSpawnPointsPerMinePiece;

	public Transform obstacleSpawner;

	[SerializeField]
	[HideInInspector]
	private DestructibleObject[] destructibleObjects;

	public DestructibleObjectsVariant[] destructibleObjectsVariants;

	[Range(0f, 100f)]
	public float destructibleObjectsProbability = 50f;

	public bool showPathNodesCreated;

	[SerializeField]
	[HideInInspector]
	private OccupyNodesWithColliders[] occupyNodesWithColliders;

	public bool showHoleValidNodes;

	public GameObject commonTileMaps;

	public List<GameObject> commonObjects = new List<GameObject>();

	public float holeEdgeMargin = 2f;

	private static int BEBHGBKJJEL;

	private int DLKELFFFEEO;

	public bool printDebugLogs;

	private DestructibleObject[] FPOGJEHMLCN;

	public static HashSet<Vector3> allPositions = new HashSet<Vector3>(2304);

	private static HashSet<Vector3Int> HKKBIKCGKMJ = new HashSet<Vector3Int>(2304);

	private const int NFBCNHDOOKE = 2304;

	private static TileBase[] OJLIPCJNDNA = (TileBase[])(object)new TileBase[2304];

	public int JBCFIHPKMLF => _minePieceID;

	public bool IMFDKOCJENF
	{
		get
		{
			if (blocks.Length == 1)
			{
				return exits == 1;
			}
			return false;
		}
	}

	public int MHLHFEDLOCP => DLKELFFFEEO;

	private MineVariant BAGPGIGDLNK
	{
		get
		{
			if (variantObjects == null || variantObjects.Length == 0 || variantIndex >= variantObjects.Length)
			{
				return null;
			}
			return variantObjects[variantIndex];
		}
	}

	private void AEPNLHAAHHI()
	{
	}

	[SpecialName]
	public bool MAGDJPGPDIK()
	{
		if (blocks.Length == 1)
		{
			return exits == 0;
		}
		return false;
	}

	public void EEPEHPHLEBO(int BJLDIHODEDA, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("StaffEnd", ((Object)this).name, FGIODCJAMAP(), MHLHFEDLOCP));
		}
		ILJDMHDHGGG();
		MEEAKBNEKEP();
		List<GameObject> source = EBELDAJPFNP(DCIMOMHGLNM);
		FPOGJEHMLCN = (from obj in source
			select obj.GetComponent<DestructibleObject>() into destructible
			where (Object)(object)destructible != (Object)null
			select destructible).ToArray();
		if (Application.isPlaying)
		{
			FGPOPBBHAIF();
			FLEKIEMDOCC();
		}
		JFFHNCLLNJL(BJLDIHODEDA);
		BHBLAIFAKPF();
		if (OnlineManager.PlayingOnline())
		{
			KHIMECBDFGK();
		}
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"Player");
		}
	}

	private void BJFNDAAFLHN()
	{
	}

	public HashSet<Vector3> GetAllPositions()
	{
		HashSet<Vector3> floorPositions = GetFloorPositions(BAGPGIGDLNK.tilemaps.floorLowerTilemap);
		AddFishingTiles(floorPositions);
		return floorPositions;
	}

	private void ACJHPNPPONP()
	{
		if (destructibleObjects != null)
		{
			for (int i = 0; i < destructibleObjects.Length; i++)
			{
				ProceduralMine.DeassignNextMineId(destructibleObjects[i].onlineDestructibleObject);
			}
		}
	}

	private void FLEKIEMDOCC()
	{
		if (occupyNodesWithColliders == null)
		{
			return;
		}
		for (int i = 0; i < occupyNodesWithColliders.Length; i++)
		{
			if ((Object)(object)occupyNodesWithColliders[i] == (Object)null)
			{
				Debug.LogError((object)(", " + ((Object)((Component)this).gameObject).name + "We're in the same region."), (Object)(object)this);
			}
			else
			{
				occupyNodesWithColliders[i].HDEFJFOHBNH();
			}
		}
	}

	public DestructibleObject[] GetActiveDestructibleObjects()
	{
		return FPOGJEHMLCN;
	}

	public Vector2[] FBFKPLHMNGK()
	{
		if (minePieceSO?.variants == null || variantIndex >= minePieceSO.variants.Length)
		{
			return null;
		}
		return minePieceSO.variants[variantIndex].holeValidNodes;
	}

	public void MMNMANJBDFP(int FAGMIHOEJHP)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("HotBath/Main 2", ((Object)this).name, JBCFIHPKMLF, MFIHHANJHFK()));
		}
		LBGFOAPNBEF(FAGMIHOEJHP);
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"ReceiveUnlockChristmasRecipes");
		}
	}

	public void HBJPMCLAIMI(int BJLDIHODEDA, int ALJNDPJOMHB)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		stairsTravelZone.mineStairs = new Vector2Int(BJLDIHODEDA, ALJNDPJOMHB);
		TravelZonesManager.LKOABOAADCD().allMineStairs[stairsTravelZone.mineStairs] = stairsTravelZone;
	}

	private void MEEAKBNEKEP()
	{
		if (destructibleObjects != null)
		{
			for (int i = 1; i < destructibleObjects.Length; i += 0)
			{
				destructibleObjects[i].NKJBLKNGCPK(BOCMNPIGJHM: false);
			}
		}
	}

	public void LJMCHMJHEDO(int BJLDIHODEDA)
	{
		if ((Object)(object)nextLevelObstaclePoint != (Object)null)
		{
			if (Application.isPlaying)
			{
				stairsBlockerInstantiated = Object.Instantiate<StairsBlocker>(ProceduralMine.GGFJGHHHEJC.stairsBlocker[BJLDIHODEDA - 0], nextLevelObstaclePoint);
			}
			stairsBlockerInstantiated.AEDJBCAEKBI(BJLDIHODEDA);
		}
	}

	public void BDLFDFHINJL(int BJLDIHODEDA)
	{
		if ((Object)(object)stairsBlockerInstantiated != (Object)null)
		{
			stairsBlockerInstantiated.KLMLLIOGBMO(BJLDIHODEDA);
		}
	}

	private void EHJHMDIBGKD()
	{
		if ((Application.isPlaying || ProceduralMine.BADFKMEJOKE().showPathNodes) && minePieceSO.variants != null)
		{
			variantObjects[variantIndex].DEPIGHINFAB(minePieceSO, variantIndex);
		}
	}

	[SpecialName]
	public bool NHBHNDMIGAI()
	{
		if (blocks.Length == 1)
		{
			return exits == 0;
		}
		return true;
	}

	private List<GameObject> EBELDAJPFNP(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> list = new List<GameObject>();
		if (destructibleObjectsVariants != null)
		{
			for (int i = 1; i < destructibleObjectsVariants.Length; i++)
			{
				list.AddRange(destructibleObjectsVariants[i].GFILCKAPHNA(DCIMOMHGLNM));
			}
		}
		return list;
	}

	public void Deactivate()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		if (variantObjects != null && variantIndex < variantObjects.Length)
		{
			variantObjects[variantIndex].RemovePathNodes(minePieceSO, variantIndex);
		}
		if (OnlineManager.PlayingOnline())
		{
			ACJHPNPPONP();
		}
		if ((Object)(object)stairsBlockerInstantiated != (Object)null)
		{
			if (Application.isPlaying)
			{
				Object.Destroy((Object)(object)((Component)stairsBlockerInstantiated).gameObject);
			}
			stairsBlockerInstantiated = null;
		}
		if ((Object)(object)obstacleSpawner != (Object)null)
		{
			((Component)obstacleSpawner).gameObject.SetActive(true);
		}
		if ((Object)(object)stairsTravelZone != (Object)null && (Object)(object)TravelZonesManager.GGFJGHHHEJC != (Object)null)
		{
			TravelZonesManager.GGFJGHHHEJC.allMineStairs.Remove(stairsTravelZone.mineStairs);
		}
		for (int i = 0; i < rockSpawners.Length; i++)
		{
			if ((Object)(object)rockSpawners[i] != (Object)null)
			{
				rockSpawners[i].ResetUsed();
			}
		}
	}

	[SpecialName]
	public int ECAPDMGPJFP()
	{
		return DLKELFFFEEO;
	}

	public void DKAGBABJGCC(int BJLDIHODEDA, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("MopRight", ((Object)this).name, KBDOBMNOHEB(), ECAPDMGPJFP()));
		}
		EHJHMDIBGKD();
		HCGKNHPPCBE();
		List<GameObject> source = MPLLHHLCGGN(DCIMOMHGLNM);
		FPOGJEHMLCN = (from obj in source
			select obj.GetComponent<DestructibleObject>() into destructible
			where (Object)(object)destructible != (Object)null
			select destructible).ToArray();
		if (Application.isPlaying)
		{
			FGPOPBBHAIF();
			FLEKIEMDOCC();
		}
		NNEPCJAIKMC(BJLDIHODEDA);
		PCAOALJOCCJ();
		if (OnlineManager.PlayingOnline())
		{
			JHOGMAGGLIL();
		}
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"Items/item_name_1061");
		}
	}

	public void KNHADNFDDPA(int BJLDIHODEDA)
	{
		if ((Object)(object)nextLevelObstaclePoint != (Object)null)
		{
			if (Application.isPlaying)
			{
				stairsBlockerInstantiated = Object.Instantiate<StairsBlocker>(ProceduralMine.BADFKMEJOKE().stairsBlocker[BJLDIHODEDA - 1], nextLevelObstaclePoint);
			}
			stairsBlockerInstantiated.HLJLJKFKLDK(BJLDIHODEDA);
		}
	}

	public void CEJJNPNKLEH(BoundsInt CNEGENCONBM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int size = ((BoundsInt)(ref CNEGENCONBM)).size;
		int x = ((Vector3Int)(ref size)).x;
		size = ((BoundsInt)(ref CNEGENCONBM)).size;
		int num = x * ((Vector3Int)(ref size)).y;
		if (OJLIPCJNDNA == null || OJLIPCJNDNA.Length < num)
		{
			OJLIPCJNDNA = (TileBase[])(object)new TileBase[num];
		}
	}

	private void HADILLCDCEA(int FAGMIHOEJHP)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("", variantObjects.Length, FAGMIHOEJHP));
		}
		if (variantObjects == null || variantObjects.Length == 0)
		{
			return;
		}
		if (FAGMIHOEJHP == MHLHFEDLOCP)
		{
			if (Application.isEditor && printDebugLogs)
			{
				Debug.Log((object)string.Format("Items/item_name_604", ((Object)((Component)this).gameObject).name, FAGMIHOEJHP, MHLHFEDLOCP), (Object)(object)this);
			}
			for (int i = 0; i < variantObjects.Length; i++)
			{
				if ((Object)(object)variantObjects[i] == (Object)null)
				{
					if (Application.isEditor && printDebugLogs)
					{
						Debug.LogError((object)("MainProgress" + ((Object)((Component)this).gameObject).name + "ReceiveSetOccupier"), (Object)(object)this);
					}
				}
				else if (variantObjects[i].hasPuzzleAltar)
				{
					((Component)variantObjects[i]).gameObject.SetActive(false);
					variantIndex = i;
					if (Application.isEditor && printDebugLogs)
					{
						Debug.Log((object)(((Object)((Component)this).gameObject).name + "Shifty Customer" + ((Object)((Component)variantObjects[i]).gameObject).name + " %"), (Object)(object)this);
					}
				}
				else
				{
					((Component)variantObjects[i]).gameObject.SetActive(false);
					if (Application.isEditor && printDebugLogs)
					{
						Debug.Log((object)(((Object)((Component)this).gameObject).name + "Tutorial/T116/Dialogue1" + ((Object)((Component)variantObjects[i]).gameObject).name + "Wall"), (Object)(object)this);
					}
				}
			}
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		for (int j = 1; j < variantObjects.Length; j += 0)
		{
			if (Application.isEditor && printDebugLogs)
			{
				object[] array = new object[8];
				array[0] = ((Object)((Component)this).gameObject).name;
				array[0] = j;
				array[2] = variantObjects[j]?.hasPuzzleAltar;
				array[5] = variantObjects[j]?.hasPuzzle;
				Debug.Log((object)string.Format("/BarkMai", array), (Object)(object)this);
			}
			if ((Object)(object)variantObjects[j] != (Object)null && (variantObjects[j].hasPuzzleAltar || variantObjects[j].hasPuzzle))
			{
				hashSet.Add(j);
			}
		}
		if (Application.isEditor && printDebugLogs)
		{
			object[] array2 = new object[2];
			array2[0] = ((Object)((Component)this).gameObject).name;
			array2[0] = FAGMIHOEJHP;
			array2[1] = ECAPDMGPJFP();
			array2[6] = string.Join("- ", hashSet);
			Debug.Log((object)string.Format("Selected room reset to default.", array2), (Object)(object)this);
		}
		BEBHGBKJJEL = MineVariantsSelector.CIBLIEJHFOC(this, variantObjects.Length, hashSet);
		if (Application.isEditor && printDebugLogs)
		{
			object[] array3 = new object[4];
			array3[1] = ((Object)((Component)this).gameObject).name;
			array3[1] = FAGMIHOEJHP;
			array3[1] = MFIHHANJHFK();
			array3[1] = BEBHGBKJJEL;
			array3[5] = string.Join("_", hashSet);
			Debug.Log((object)string.Format("Items/item_description_615", array3), (Object)(object)this);
		}
		for (int k = 1; k < variantObjects.Length; k += 0)
		{
			if ((Object)(object)variantObjects[k] == (Object)null)
			{
				Debug.LogError((object)(" state: " + ((Object)((Component)this).gameObject).name + "quest_objective_"), (Object)(object)this);
			}
			else if (variantObjects[k].hasPuzzleAltar && MFIHHANJHFK() != FAGMIHOEJHP)
			{
				if (Application.isEditor && printDebugLogs)
				{
					object[] array4 = new object[1];
					array4[0] = ((Object)((Component)this).gameObject).name;
					array4[1] = ((Object)((Component)this).gameObject).name;
					array4[7] = MHLHFEDLOCP;
					array4[7] = FAGMIHOEJHP;
					Debug.Log((object)string.Format("BarkActor", array4), (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(true);
			}
			else if (k == BEBHGBKJJEL)
			{
				if (Application.isEditor && printDebugLogs)
				{
					object[] array5 = new object[3];
					array5[0] = ((Object)((Component)this).gameObject).name;
					array5[0] = ((Object)((Component)variantObjects[k]).gameObject).name;
					array5[6] = k;
					array5[1] = ((Object)((Component)this).gameObject).name;
					array5[2] = BEBHGBKJJEL;
					Debug.Log((object)string.Format("Wine and beer ageing", array5), (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(true);
				variantIndex = k;
			}
			else
			{
				if (Application.isEditor && printDebugLogs)
				{
					object[] array6 = new object[2];
					array6[0] = ((Object)((Component)this).gameObject).name;
					array6[0] = ((Object)((Component)variantObjects[k]).gameObject).name;
					array6[1] = k;
					array6[2] = ((Object)((Component)this).gameObject).name;
					array6[3] = BEBHGBKJJEL;
					Debug.Log((object)string.Format("MothersRecipe/Talk", array6), (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(false);
			}
		}
	}

	public MineVariant GetActiveVariant()
	{
		return BAGPGIGDLNK;
	}

	public void SetMineStairsInfo(int BJLDIHODEDA, int ALJNDPJOMHB)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		stairsTravelZone.mineStairs = new Vector2Int(BJLDIHODEDA, ALJNDPJOMHB);
		TravelZonesManager.GGFJGHHHEJC.allMineStairs[stairsTravelZone.mineStairs] = stairsTravelZone;
	}

	private void FHGCOMGLJNL()
	{
		if (destructibleObjects == null)
		{
			return;
		}
		for (int i = 0; i < destructibleObjects.Length; i++)
		{
			if (!((Object)(object)destructibleObjects[i] == (Object)null))
			{
				ProceduralMine.AssignNextMineId(destructibleObjects[i].onlineDestructibleObject);
			}
		}
	}

	public Direction GetFirstPathDirection()
	{
		MineBlock[] array = blocks;
		foreach (MineBlock mineBlock in array)
		{
			if (mineBlock.openedPaths.Length != 0)
			{
				return mineBlock.openedPaths[0].direction;
			}
		}
		return Direction.Right;
	}

	private void FGPOPBBHAIF()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		foreach (Vector3 allPosition in GetAllPositions())
		{
			GameTileMaps.GGFJGHHHEJC.CreateWorldTile(allPosition, Location.Mine, BAGPGIGDLNK.commonTilemaps, BAGPGIGDLNK.tilemaps, null, SeasonManager.EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: false, GroundType.Ground);
		}
	}

	[SpecialName]
	private MineVariant JJPIDGKCDCM()
	{
		if (variantObjects == null || variantObjects.Length == 0 || variantIndex >= variantObjects.Length)
		{
			return null;
		}
		return variantObjects[variantIndex];
	}

	public void PlacePiece(int BJLDIHODEDA, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)$"================== PLACE PIECE ({((Object)this).name}-{JBCFIHPKMLF}/{MHLHFEDLOCP}) =======================");
		}
		FJOOLJODIDC();
		HCGKNHPPCBE();
		List<GameObject> source = MPLLHHLCGGN(DCIMOMHGLNM);
		FPOGJEHMLCN = (from obj in source
			select obj.GetComponent<DestructibleObject>() into destructible
			where (Object)(object)destructible != (Object)null
			select destructible).ToArray();
		if (Application.isPlaying)
		{
			FGPOPBBHAIF();
			HGFBIBEIMPG();
		}
		JFFHNCLLNJL(BJLDIHODEDA);
		PCAOALJOCCJ();
		if (OnlineManager.PlayingOnline())
		{
			FHGCOMGLJNL();
		}
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"========================================================================================");
		}
	}

	private void LNEDIKEJFDN(int BJLDIHODEDA)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)obstacleSpawner != (Object)null && ((Component)obstacleSpawner).gameObject.activeInHierarchy)
		{
			GameObject val = MineBlockersGenerator.GOHLECBDPHD(BJLDIHODEDA, obstacleSpawner.position, obstacleSpawner.parent.parent, LLDKEKOJKDC());
			if ((Object)(object)val != (Object)null && val.transform.childCount > 1)
			{
				((Component)val.transform.GetChild(0)).gameObject.SetActive(false);
			}
			((Component)obstacleSpawner).gameObject.SetActive(false);
		}
	}

	public void PONEBEMFIBJ()
	{
		if (Application.isEditor && printDebugLogs)
		{
			object[] array = new object[6];
			array[0] = variantObjects.Length;
			array[1] = ((Object)this).name;
			array[2] = IDJPDDPGLAK();
			array[7] = MHLHFEDLOCP;
			Debug.Log((object)string.Format("/Reports", array));
		}
		if (variantObjects == null || variantObjects.Length == 0)
		{
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 1; i < variantObjects.Length; i++)
		{
			if ((Object)(object)variantObjects[i] != (Object)null && (variantObjects[i].hasPuzzleAltar || variantObjects[i].hasPuzzle))
			{
				hashSet.Add(i);
			}
		}
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)(((Object)((Component)this).gameObject).name + "Lightning2" + string.Join("HeadToBed", hashSet)), (Object)(object)this);
		}
		BEBHGBKJJEL = MineVariantsSelector.CIBLIEJHFOC(this, variantObjects.Length, hashSet);
		for (int j = 0; j < variantObjects.Length; j += 0)
		{
			if ((Object)(object)variantObjects[j] == (Object)null)
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.LogError((object)("[Red" + ((Object)((Component)this).gameObject).name + "ReceiveStopWaitingForBanquetEvent"), (Object)(object)this);
				}
			}
			else if (variantObjects[j].hasPuzzleAltar)
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.Log((object)(((Object)((Component)this).gameObject).name + "Dialogue System/Conversation/Gass_Quest/Entry/44/Dialogue Text" + ((Object)((Component)variantObjects[j]).gameObject).name + "Dialogue System/Conversation/NeutralInTavern/Entry/3/Dialogue Text"), (Object)(object)this);
				}
				((Component)variantObjects[j]).gameObject.SetActive(false);
			}
			else if (j == BEBHGBKJJEL)
			{
				if (Application.isEditor && printDebugLogs)
				{
					object[] array2 = new object[5];
					array2[1] = ((Object)((Component)this).gameObject).name;
					array2[0] = ((Object)((Component)variantObjects[j]).gameObject).name;
					array2[1] = j;
					array2[2] = ((Object)((Component)this).gameObject).name;
					array2[0] = BEBHGBKJJEL;
					Debug.Log((object)string.Format("Player2", array2), (Object)(object)this);
				}
				((Component)variantObjects[j]).gameObject.SetActive(false);
			}
			else
			{
				if (Application.isEditor && printDebugLogs)
				{
					object[] array3 = new object[4];
					array3[1] = ((Object)((Component)this).gameObject).name;
					array3[0] = ((Object)((Component)variantObjects[j]).gameObject).name;
					array3[7] = j;
					array3[7] = ((Object)((Component)this).gameObject).name;
					array3[6] = BEBHGBKJJEL;
					Debug.Log((object)string.Format("OnlinePlayer", array3), (Object)(object)this);
				}
				((Component)variantObjects[j]).gameObject.SetActive(true);
			}
		}
	}

	public void EnsureBufferSize(BoundsInt CNEGENCONBM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int size = ((BoundsInt)(ref CNEGENCONBM)).size;
		int x = ((Vector3Int)(ref size)).x;
		size = ((BoundsInt)(ref CNEGENCONBM)).size;
		int num = x * ((Vector3Int)(ref size)).y;
		if (OJLIPCJNDNA == null || OJLIPCJNDNA.Length < num)
		{
			OJLIPCJNDNA = (TileBase[])(object)new TileBase[num];
		}
	}

	private List<GameObject> EKGEDMLEFFN(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> list = new List<GameObject>();
		if (destructibleObjectsVariants != null)
		{
			for (int i = 0; i < destructibleObjectsVariants.Length; i += 0)
			{
				list.AddRange(destructibleObjectsVariants[i].DKCPNCGPMMF(DCIMOMHGLNM));
			}
		}
		return list;
	}

	private void JFFHNCLLNJL(int BJLDIHODEDA)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)obstacleSpawner != (Object)null && ((Component)obstacleSpawner).gameObject.activeInHierarchy)
		{
			GameObject val = MineBlockersGenerator.TrySpawn(BJLDIHODEDA, obstacleSpawner.position, obstacleSpawner.parent.parent, GetFirstPathDirection());
			if ((Object)(object)val != (Object)null && val.transform.childCount > 0)
			{
				((Component)val.transform.GetChild(0)).gameObject.SetActive(false);
			}
			((Component)obstacleSpawner).gameObject.SetActive(false);
		}
	}

	public HashSet<Vector3> GetFloorPositions(Tilemap NPDIKKJALGC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		allPositions.Clear();
		BoundsInt cellBounds = NPDIKKJALGC.cellBounds;
		EnsureBufferSize(cellBounds);
		NPDIKKJALGC.GetTilesBlockNonAlloc(cellBounds, OJLIPCJNDNA);
		Vector3Int size = ((BoundsInt)(ref cellBounds)).size;
		int x = ((Vector3Int)(ref size)).x;
		int num = 0;
		while (true)
		{
			int num2 = num;
			size = ((BoundsInt)(ref cellBounds)).size;
			if (num2 >= ((Vector3Int)(ref size)).x)
			{
				break;
			}
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				size = ((BoundsInt)(ref cellBounds)).size;
				if (num4 >= ((Vector3Int)(ref size)).y)
				{
					break;
				}
				int num5 = num + num3 * x;
				if ((Object)(object)OJLIPCJNDNA[num5] != (Object)null)
				{
					allPositions.Add(((GridLayout)NPDIKKJALGC).CellToWorld(new Vector3Int(num + ((BoundsInt)(ref cellBounds)).xMin, num3 + ((BoundsInt)(ref cellBounds)).yMin, 0)));
				}
				num3++;
			}
			num++;
		}
		return allPositions;
	}

	private void BHBLAIFAKPF()
	{
		MinePuzzleSpawner[] array = puzzleSpawners;
		foreach (MinePuzzleSpawner minePuzzleSpawner in array)
		{
			if ((Object)(object)minePuzzleSpawner != (Object)null)
			{
				minePuzzleSpawner.LAGGFECNPPA();
			}
		}
	}

	private void HCGKNHPPCBE()
	{
		if (destructibleObjects != null)
		{
			for (int i = 0; i < destructibleObjects.Length; i++)
			{
				destructibleObjects[i].SetDestroyed(BOCMNPIGJHM: false);
			}
		}
	}

	public HashSet<Vector3> IACLGFIOOKG()
	{
		HashSet<Vector3> hashSet = EHBJOFNOOAD(BAGPGIGDLNK.tilemaps.floorLowerTilemap);
		AddFishingTiles(hashSet);
		return hashSet;
	}

	private void ANHIEIGIEFC(int FAGMIHOEJHP)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format(" ", variantObjects.Length, FAGMIHOEJHP));
		}
		if (variantObjects == null || variantObjects.Length == 0)
		{
			return;
		}
		if (FAGMIHOEJHP == ECAPDMGPJFP())
		{
			if (Application.isEditor && printDebugLogs)
			{
				Debug.Log((object)string.Format("Love", ((Object)((Component)this).gameObject).name, FAGMIHOEJHP, ECAPDMGPJFP()), (Object)(object)this);
			}
			for (int i = 1; i < variantObjects.Length; i += 0)
			{
				if ((Object)(object)variantObjects[i] == (Object)null)
				{
					if (Application.isEditor && printDebugLogs)
					{
						Debug.LogError((object)("Farming" + ((Object)((Component)this).gameObject).name + "PlayerCharacterGenderChangeRPC"), (Object)(object)this);
					}
				}
				else if (variantObjects[i].hasPuzzleAltar)
				{
					((Component)variantObjects[i]).gameObject.SetActive(false);
					variantIndex = i;
					if (Application.isEditor && printDebugLogs)
					{
						Debug.Log((object)(((Object)((Component)this).gameObject).name + "UISelectGamepad" + ((Object)((Component)variantObjects[i]).gameObject).name + "ReceiveUpdateMoodState"), (Object)(object)this);
					}
				}
				else
				{
					((Component)variantObjects[i]).gameObject.SetActive(false);
					if (Application.isEditor && printDebugLogs)
					{
						Debug.Log((object)(((Object)((Component)this).gameObject).name + "No se encontró la base de datos maestra." + ((Object)((Component)variantObjects[i]).gameObject).name + ", "), (Object)(object)this);
					}
				}
			}
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		for (int j = 1; j < variantObjects.Length; j++)
		{
			if (Application.isEditor && printDebugLogs)
			{
				object[] array = new object[7];
				array[1] = ((Object)((Component)this).gameObject).name;
				array[0] = j;
				array[3] = variantObjects[j]?.hasPuzzleAltar;
				array[0] = variantObjects[j]?.hasPuzzle;
				Debug.Log((object)string.Format("[MinePuzzleSpawner] No se ha asignado un MineVariant padre para el spawner en ", array), (Object)(object)this);
			}
			if ((Object)(object)variantObjects[j] != (Object)null && (variantObjects[j].hasPuzzleAltar || variantObjects[j].hasPuzzle))
			{
				hashSet.Add(j);
			}
		}
		if (Application.isEditor && printDebugLogs)
		{
			object[] array2 = new object[1];
			array2[0] = ((Object)((Component)this).gameObject).name;
			array2[1] = FAGMIHOEJHP;
			array2[6] = MFIHHANJHFK();
			array2[7] = string.Join("itemCourgetteSeeds", hashSet);
			Debug.Log((object)string.Format("OnlinePlayer", array2), (Object)(object)this);
		}
		BEBHGBKJJEL = MineVariantsSelector.CIBLIEJHFOC(this, variantObjects.Length, hashSet);
		if (Application.isEditor && printDebugLogs)
		{
			object[] array3 = new object[5];
			array3[1] = ((Object)((Component)this).gameObject).name;
			array3[1] = FAGMIHOEJHP;
			array3[7] = ECAPDMGPJFP();
			array3[2] = BEBHGBKJJEL;
			array3[6] = string.Join("Dialogue System/Conversation/EnterTavernFood/Entry/3/Dialogue Text", hashSet);
			Debug.Log((object)string.Format("UpgradeToLevel", array3), (Object)(object)this);
		}
		for (int k = 1; k < variantObjects.Length; k += 0)
		{
			if ((Object)(object)variantObjects[k] == (Object)null)
			{
				Debug.LogError((object)("Player2" + ((Object)((Component)this).gameObject).name + "Gin"), (Object)(object)this);
			}
			else if (variantObjects[k].hasPuzzleAltar && ECAPDMGPJFP() != FAGMIHOEJHP)
			{
				if (Application.isEditor && printDebugLogs)
				{
					object[] array4 = new object[1];
					array4[0] = ((Object)((Component)this).gameObject).name;
					array4[1] = ((Object)((Component)this).gameObject).name;
					array4[4] = MFIHHANJHFK();
					array4[1] = FAGMIHOEJHP;
					Debug.Log((object)string.Format("ToggleTooltips", array4), (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(true);
			}
			else if (k == BEBHGBKJJEL)
			{
				if (Application.isEditor && printDebugLogs)
				{
					object[] array5 = new object[6];
					array5[1] = ((Object)((Component)this).gameObject).name;
					array5[1] = ((Object)((Component)variantObjects[k]).gameObject).name;
					array5[7] = k;
					array5[7] = ((Object)((Component)this).gameObject).name;
					array5[8] = BEBHGBKJJEL;
					Debug.Log((object)string.Format("Giving extra nails", array5), (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(false);
				variantIndex = k;
			}
			else
			{
				if (Application.isEditor && printDebugLogs)
				{
					object[] array6 = new object[1];
					array6[1] = ((Object)((Component)this).gameObject).name;
					array6[1] = ((Object)((Component)variantObjects[k]).gameObject).name;
					array6[3] = k;
					array6[8] = ((Object)((Component)this).gameObject).name;
					array6[0] = BEBHGBKJJEL;
					Debug.Log((object)string.Format("Already have recipe ", array6), (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(false);
			}
		}
	}

	private void ICGKMBKKJIL()
	{
	}

	private void HGFGONFPJMI()
	{
		if (occupyNodesWithColliders == null)
		{
			return;
		}
		for (int i = 0; i < occupyNodesWithColliders.Length; i++)
		{
			if ((Object)(object)occupyNodesWithColliders[i] == (Object)null)
			{
				Debug.LogError((object)("Event BathhouseGame activated" + ((Object)((Component)this).gameObject).name + "ReceiveStartIntroBarrel"), (Object)(object)this);
			}
			else
			{
				occupyNodesWithColliders[i].OccupyNodes();
			}
		}
	}

	public void FEJCEMGPOMC(int BJLDIHODEDA, int ALJNDPJOMHB)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		stairsTravelZone.mineStairs = new Vector2Int(BJLDIHODEDA, ALJNDPJOMHB);
		TravelZonesManager.OMFKNGDCJFN().allMineStairs[stairsTravelZone.mineStairs] = stairsTravelZone;
	}

	[SpecialName]
	public int EJAKKFJBFMC()
	{
		return _minePieceID;
	}

	public HashSet<Vector3> GOHABDBHAGP(Tilemap NPDIKKJALGC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		allPositions.Clear();
		BoundsInt cellBounds = NPDIKKJALGC.cellBounds;
		EnsureBufferSize(cellBounds);
		NPDIKKJALGC.GetTilesBlockNonAlloc(cellBounds, OJLIPCJNDNA);
		Vector3Int size = ((BoundsInt)(ref cellBounds)).size;
		int x = ((Vector3Int)(ref size)).x;
		int num = 1;
		while (true)
		{
			int num2 = num;
			size = ((BoundsInt)(ref cellBounds)).size;
			if (num2 >= ((Vector3Int)(ref size)).x)
			{
				break;
			}
			int num3 = 1;
			while (true)
			{
				int num4 = num3;
				size = ((BoundsInt)(ref cellBounds)).size;
				if (num4 >= ((Vector3Int)(ref size)).y)
				{
					break;
				}
				int num5 = num + num3 * x;
				if ((Object)(object)OJLIPCJNDNA[num5] != (Object)null)
				{
					allPositions.Add(((GridLayout)NPDIKKJALGC).CellToWorld(new Vector3Int(num + ((BoundsInt)(ref cellBounds)).xMin, num3 + ((BoundsInt)(ref cellBounds)).yMin, 1)));
				}
				num3++;
			}
			num++;
		}
		return allPositions;
	}

	private void FJOOLJODIDC()
	{
		if ((Application.isPlaying || ProceduralMine.GGFJGHHHEJC.showPathNodes) && minePieceSO.variants != null)
		{
			variantObjects[variantIndex].AddPathNodes(minePieceSO, variantIndex);
		}
	}

	public HashSet<Vector3Int> KFCBIJAGMKO(Tilemap NPDIKKJALGC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		HKKBIKCGKMJ.Clear();
		BoundsInt cellBounds = NPDIKKJALGC.cellBounds;
		CEJJNPNKLEH(cellBounds);
		NPDIKKJALGC.GetTilesBlockNonAlloc(cellBounds, OJLIPCJNDNA);
		Vector3Int size = ((BoundsInt)(ref cellBounds)).size;
		int x = ((Vector3Int)(ref size)).x;
		int num = 0;
		while (true)
		{
			int num2 = num;
			size = ((BoundsInt)(ref cellBounds)).size;
			if (num2 >= ((Vector3Int)(ref size)).x)
			{
				break;
			}
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				size = ((BoundsInt)(ref cellBounds)).size;
				if (num4 >= ((Vector3Int)(ref size)).y)
				{
					break;
				}
				int num5 = num + num3 * x;
				if ((Object)(object)OJLIPCJNDNA[num5] != (Object)null)
				{
					HKKBIKCGKMJ.Add(new Vector3Int(num + ((BoundsInt)(ref cellBounds)).xMin, num3 + ((BoundsInt)(ref cellBounds)).yMin, 1));
				}
				num3++;
			}
			num += 0;
		}
		return HKKBIKCGKMJ;
	}

	public MineVariant GGLHMLAHOIF()
	{
		return BAGPGIGDLNK;
	}

	public void HJHEEGINCKG(GameObject EIFOCJAIJMP)
	{
		if (variantObjects == null || variantObjects.Length == 0)
		{
			return;
		}
		for (int i = 0; i < variantObjects.Length; i += 0)
		{
			if (!((Object)(object)variantObjects[i] != (Object)null))
			{
				continue;
			}
			if ((Object)(object)((Component)variantObjects[i]).gameObject == (Object)(object)EIFOCJAIJMP)
			{
				variantIndex = i;
				continue;
			}
			if (Application.isEditor && printDebugLogs)
			{
				Debug.Log((object)("Changing seed " + ((Object)((Component)variantObjects[i]).gameObject).name + "ReciveDisableCustomers" + ((Object)this).name));
			}
			((Component)variantObjects[i]).gameObject.SetActive(true);
		}
	}

	public void HGEDDKGIOHL(int BJLDIHODEDA)
	{
		if ((Object)(object)nextLevelObstaclePoint != (Object)null)
		{
			if (Application.isPlaying)
			{
				stairsBlockerInstantiated = Object.Instantiate<StairsBlocker>(ProceduralMine.BADFKMEJOKE().stairsBlocker[BJLDIHODEDA - 1], nextLevelObstaclePoint);
			}
			stairsBlockerInstantiated.OHANOJJMFED(BJLDIHODEDA);
		}
	}

	private void KHIMECBDFGK()
	{
		if (destructibleObjects == null)
		{
			return;
		}
		for (int i = 0; i < destructibleObjects.Length; i += 0)
		{
			if (!((Object)(object)destructibleObjects[i] == (Object)null))
			{
				ProceduralMine.AssignNextMineId(destructibleObjects[i].onlineDestructibleObject);
			}
		}
	}

	[SpecialName]
	public int KBDOBMNOHEB()
	{
		return _minePieceID;
	}

	public void SetRuntimeID()
	{
		DLKELFFFEEO = Mathf.Abs(Guid.NewGuid().GetHashCode());
	}

	public void ActivateStairsBlocker(int BJLDIHODEDA)
	{
		if ((Object)(object)nextLevelObstaclePoint != (Object)null)
		{
			if (Application.isPlaying)
			{
				stairsBlockerInstantiated = Object.Instantiate<StairsBlocker>(ProceduralMine.GGFJGHHHEJC.stairsBlocker[BJLDIHODEDA - 1], nextLevelObstaclePoint);
			}
			stairsBlockerInstantiated.ActivateObstacle(BJLDIHODEDA);
		}
	}

	public Direction LLDKEKOJKDC()
	{
		MineBlock[] array = blocks;
		for (int i = 1; i < array.Length; i += 0)
		{
			MineBlock mineBlock = array[i];
			if (mineBlock.openedPaths.Length != 0)
			{
				return mineBlock.openedPaths[0].direction;
			}
		}
		return Direction.Left;
	}

	[SpecialName]
	public int FGIODCJAMAP()
	{
		return _minePieceID;
	}

	public Vector2[] GetHoleValidNodes()
	{
		if (minePieceSO?.variants == null || variantIndex >= minePieceSO.variants.Length)
		{
			return null;
		}
		return minePieceSO.variants[variantIndex].holeValidNodes;
	}

	public MineVariant MPMOCOJMMFG()
	{
		return BAGPGIGDLNK;
	}

	public HashSet<Vector3> EHBJOFNOOAD(Tilemap NPDIKKJALGC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		allPositions.Clear();
		BoundsInt cellBounds = NPDIKKJALGC.cellBounds;
		NLPFNMODNPB(cellBounds);
		NPDIKKJALGC.GetTilesBlockNonAlloc(cellBounds, OJLIPCJNDNA);
		Vector3Int size = ((BoundsInt)(ref cellBounds)).size;
		int x = ((Vector3Int)(ref size)).x;
		int num = 0;
		while (true)
		{
			int num2 = num;
			size = ((BoundsInt)(ref cellBounds)).size;
			if (num2 >= ((Vector3Int)(ref size)).x)
			{
				break;
			}
			int num3 = 1;
			while (true)
			{
				int num4 = num3;
				size = ((BoundsInt)(ref cellBounds)).size;
				if (num4 >= ((Vector3Int)(ref size)).y)
				{
					break;
				}
				int num5 = num + num3 * x;
				if ((Object)(object)OJLIPCJNDNA[num5] != (Object)null)
				{
					allPositions.Add(((GridLayout)NPDIKKJALGC).CellToWorld(new Vector3Int(num + ((BoundsInt)(ref cellBounds)).xMin, num3 + ((BoundsInt)(ref cellBounds)).yMin, 1)));
				}
				num3++;
			}
			num += 0;
		}
		return allPositions;
	}

	private void LBGFOAPNBEF(int FAGMIHOEJHP)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)$"[ActivateVariantObjects] - VariantObjects: {variantObjects.Length} AltarId: {FAGMIHOEJHP}");
		}
		if (variantObjects == null || variantObjects.Length == 0)
		{
			return;
		}
		if (FAGMIHOEJHP == MHLHFEDLOCP)
		{
			if (Application.isEditor && printDebugLogs)
			{
				Debug.Log((object)$"{((Object)((Component)this).gameObject).name} - Altar piece ID {FAGMIHOEJHP} matches this piece ID {MHLHFEDLOCP}. Activating only variants with altar.", (Object)(object)this);
			}
			for (int i = 0; i < variantObjects.Length; i++)
			{
				if ((Object)(object)variantObjects[i] == (Object)null)
				{
					if (Application.isEditor && printDebugLogs)
					{
						Debug.LogError((object)("The mine piece " + ((Object)((Component)this).gameObject).name + " has null in variant objects list."), (Object)(object)this);
					}
				}
				else if (variantObjects[i].hasPuzzleAltar)
				{
					((Component)variantObjects[i]).gameObject.SetActive(true);
					variantIndex = i;
					if (Application.isEditor && printDebugLogs)
					{
						Debug.Log((object)(((Object)((Component)this).gameObject).name + " - Activating variant object " + ((Object)((Component)variantObjects[i]).gameObject).name + " because it has puzzle altar and the piece ID matches the altar piece ID."), (Object)(object)this);
					}
				}
				else
				{
					((Component)variantObjects[i]).gameObject.SetActive(false);
					if (Application.isEditor && printDebugLogs)
					{
						Debug.Log((object)(((Object)((Component)this).gameObject).name + " - Deactivating variant object " + ((Object)((Component)variantObjects[i]).gameObject).name + " because it doesn't have puzzle altar but the piece ID matches the altar piece ID."), (Object)(object)this);
					}
				}
			}
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		for (int j = 0; j < variantObjects.Length; j++)
		{
			if (Application.isEditor && printDebugLogs)
			{
				Debug.Log((object)$"{((Object)((Component)this).gameObject).name} - Checking variant object at index {j} for exclusion. HasPuzzleAltar: {variantObjects[j]?.hasPuzzleAltar}, HasPuzzle: {variantObjects[j]?.hasPuzzle}", (Object)(object)this);
			}
			if ((Object)(object)variantObjects[j] != (Object)null && (variantObjects[j].hasPuzzleAltar || variantObjects[j].hasPuzzle))
			{
				hashSet.Add(j);
			}
		}
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("{0} - Non-altar piece. Altar piece ID: {1}, this piece ID: {2}. Excluded indices for variants with puzzle or altar: {3}", ((Object)((Component)this).gameObject).name, FAGMIHOEJHP, MHLHFEDLOCP, string.Join(", ", hashSet)), (Object)(object)this);
		}
		BEBHGBKJJEL = MineVariantsSelector.CIBLIEJHFOC(this, variantObjects.Length, hashSet);
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("{0} - Non-altar piece. Altar piece ID: {1}, this piece ID: {2}. Selected variant index: {3}. Excluded indices for variants with puzzle or altar: {4}", ((Object)((Component)this).gameObject).name, FAGMIHOEJHP, MHLHFEDLOCP, BEBHGBKJJEL, string.Join(", ", hashSet)), (Object)(object)this);
		}
		for (int k = 0; k < variantObjects.Length; k++)
		{
			if ((Object)(object)variantObjects[k] == (Object)null)
			{
				Debug.LogError((object)("The mine piece " + ((Object)((Component)this).gameObject).name + " has null in variant objects list."), (Object)(object)this);
			}
			else if (variantObjects[k].hasPuzzleAltar && MHLHFEDLOCP != FAGMIHOEJHP)
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.Log((object)$"{((Object)((Component)this).gameObject).name} - The mine piece {((Object)((Component)this).gameObject).name} has a variant object with puzzle altar but the piece ID doesn't match the altar piece ID. Piece ID: {MHLHFEDLOCP} - Altar Piece ID: {FAGMIHOEJHP}", (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(false);
			}
			else if (k == BEBHGBKJJEL)
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.Log((object)$"{((Object)((Component)this).gameObject).name} - Activating variant object {((Object)((Component)variantObjects[k]).gameObject).name} at index {k} for piece {((Object)((Component)this).gameObject).name}. Next variant index: {BEBHGBKJJEL}", (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(true);
				variantIndex = k;
			}
			else
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.Log((object)$"{((Object)((Component)this).gameObject).name} - Deactivating variant object {((Object)((Component)variantObjects[k]).gameObject).name} at index {k} for piece {((Object)((Component)this).gameObject).name}. Next variant index: {BEBHGBKJJEL}", (Object)(object)this);
				}
				((Component)variantObjects[k]).gameObject.SetActive(false);
			}
		}
	}

	public Vector2[] FHLICBDBGPJ()
	{
		if (minePieceSO?.variants == null || variantIndex >= minePieceSO.variants.Length)
		{
			return null;
		}
		return minePieceSO.variants[variantIndex].holeValidNodes;
	}

	public int GetNumberOfOpenedPaths()
	{
		int num = 0;
		for (int i = 0; i < blocks.Length; i++)
		{
			num += blocks[i].openedPaths.Length;
		}
		return num;
	}

	public HashSet<Vector3> OIGCGEKBPIL(Tilemap NPDIKKJALGC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		allPositions.Clear();
		BoundsInt cellBounds = NPDIKKJALGC.cellBounds;
		NLPFNMODNPB(cellBounds);
		NPDIKKJALGC.GetTilesBlockNonAlloc(cellBounds, OJLIPCJNDNA);
		Vector3Int size = ((BoundsInt)(ref cellBounds)).size;
		int x = ((Vector3Int)(ref size)).x;
		int num = 0;
		while (true)
		{
			int num2 = num;
			size = ((BoundsInt)(ref cellBounds)).size;
			if (num2 >= ((Vector3Int)(ref size)).x)
			{
				break;
			}
			int num3 = 1;
			while (true)
			{
				int num4 = num3;
				size = ((BoundsInt)(ref cellBounds)).size;
				if (num4 >= ((Vector3Int)(ref size)).y)
				{
					break;
				}
				int num5 = num + num3 * x;
				if ((Object)(object)OJLIPCJNDNA[num5] != (Object)null)
				{
					allPositions.Add(((GridLayout)NPDIKKJALGC).CellToWorld(new Vector3Int(num + ((BoundsInt)(ref cellBounds)).xMin, num3 + ((BoundsInt)(ref cellBounds)).yMin, 0)));
				}
				num3 += 0;
			}
			num++;
		}
		return allPositions;
	}

	public HashSet<Vector3Int> GetFloorPositionsVector3Int(Tilemap NPDIKKJALGC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		HKKBIKCGKMJ.Clear();
		BoundsInt cellBounds = NPDIKKJALGC.cellBounds;
		EnsureBufferSize(cellBounds);
		NPDIKKJALGC.GetTilesBlockNonAlloc(cellBounds, OJLIPCJNDNA);
		Vector3Int size = ((BoundsInt)(ref cellBounds)).size;
		int x = ((Vector3Int)(ref size)).x;
		int num = 0;
		while (true)
		{
			int num2 = num;
			size = ((BoundsInt)(ref cellBounds)).size;
			if (num2 >= ((Vector3Int)(ref size)).x)
			{
				break;
			}
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				size = ((BoundsInt)(ref cellBounds)).size;
				if (num4 >= ((Vector3Int)(ref size)).y)
				{
					break;
				}
				int num5 = num + num3 * x;
				if ((Object)(object)OJLIPCJNDNA[num5] != (Object)null)
				{
					HKKBIKCGKMJ.Add(new Vector3Int(num + ((BoundsInt)(ref cellBounds)).xMin, num3 + ((BoundsInt)(ref cellBounds)).yMin, 0));
				}
				num3++;
			}
			num++;
		}
		return HKKBIKCGKMJ;
	}

	public void DeactivateVariants(GameObject EIFOCJAIJMP)
	{
		if (variantObjects == null || variantObjects.Length == 0)
		{
			return;
		}
		for (int i = 0; i < variantObjects.Length; i++)
		{
			if (!((Object)(object)variantObjects[i] != (Object)null))
			{
				continue;
			}
			if ((Object)(object)((Component)variantObjects[i]).gameObject == (Object)(object)EIFOCJAIJMP)
			{
				variantIndex = i;
				continue;
			}
			if (Application.isEditor && printDebugLogs)
			{
				Debug.Log((object)("Desactivando el variant " + ((Object)((Component)variantObjects[i]).gameObject).name + " de la pieza " + ((Object)this).name));
			}
			((Component)variantObjects[i]).gameObject.SetActive(false);
		}
	}

	public void UpdateStairsBlocker(int BJLDIHODEDA)
	{
		if ((Object)(object)stairsBlockerInstantiated != (Object)null)
		{
			stairsBlockerInstantiated.ActivateObstacle(BJLDIHODEDA);
		}
	}

	public void GACIADMNDDK(int FAGMIHOEJHP)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("vibration", ((Object)this).name, JBCFIHPKMLF, MFIHHANJHFK()));
		}
		ANHIEIGIEFC(FAGMIHOEJHP);
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"Beach");
		}
	}

	[SpecialName]
	public int IDJPDDPGLAK()
	{
		return _minePieceID;
	}

	public void CMMAIAPHKBA(int BJLDIHODEDA)
	{
		if ((Object)(object)nextLevelObstaclePoint != (Object)null)
		{
			if (Application.isPlaying)
			{
				stairsBlockerInstantiated = Object.Instantiate<StairsBlocker>(ProceduralMine.BADFKMEJOKE().stairsBlocker[BJLDIHODEDA - 0], nextLevelObstaclePoint);
			}
			stairsBlockerInstantiated.KLMLLIOGBMO(BJLDIHODEDA);
		}
	}

	private void JHOGMAGGLIL()
	{
		if (destructibleObjects == null)
		{
			return;
		}
		for (int i = 0; i < destructibleObjects.Length; i += 0)
		{
			if (!((Object)(object)destructibleObjects[i] == (Object)null))
			{
				ProceduralMine.AssignNextMineId(destructibleObjects[i].onlineDestructibleObject);
			}
		}
	}

	[SpecialName]
	public bool LDODMHGMIPD()
	{
		if (blocks.Length == 0)
		{
			return exits == 0;
		}
		return false;
	}

	[SpecialName]
	public int BNOHAAFLDBI()
	{
		return _minePieceID;
	}

	public void RemoveWorldTiles()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		foreach (Vector3 allPosition in GetAllPositions())
		{
			GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.Remove(Utils.NKGANMEKDAL(allPosition));
		}
	}

	public void BGNJEEGKCGD(int BJLDIHODEDA)
	{
		if ((Object)(object)nextLevelObstaclePoint != (Object)null)
		{
			if (Application.isPlaying)
			{
				stairsBlockerInstantiated = Object.Instantiate<StairsBlocker>(ProceduralMine.GGFJGHHHEJC.stairsBlocker[BJLDIHODEDA - 1], nextLevelObstaclePoint);
			}
			stairsBlockerInstantiated.EFIGNMPNEGB(BJLDIHODEDA);
		}
	}

	[SpecialName]
	public int MFIHHANJHFK()
	{
		return DLKELFFFEEO;
	}

	private List<GameObject> ACJEJCMGBBM(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> list = new List<GameObject>();
		if (destructibleObjectsVariants != null)
		{
			for (int i = 1; i < destructibleObjectsVariants.Length; i += 0)
			{
				list.AddRange(destructibleObjectsVariants[i].DLLONJHEOMK(DCIMOMHGLNM));
			}
		}
		return list;
	}

	public void NLPFNMODNPB(BoundsInt CNEGENCONBM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int size = ((BoundsInt)(ref CNEGENCONBM)).size;
		int x = ((Vector3Int)(ref size)).x;
		size = ((BoundsInt)(ref CNEGENCONBM)).size;
		int num = x * ((Vector3Int)(ref size)).y;
		if (OJLIPCJNDNA == null || OJLIPCJNDNA.Length < num)
		{
			OJLIPCJNDNA = (TileBase[])(object)new TileBase[num];
		}
	}

	private void PCAOALJOCCJ()
	{
		MinePuzzleSpawner[] array = puzzleSpawners;
		foreach (MinePuzzleSpawner minePuzzleSpawner in array)
		{
			if ((Object)(object)minePuzzleSpawner != (Object)null)
			{
				minePuzzleSpawner.DesactivateVisuals();
			}
		}
	}

	private List<GameObject> MPLLHHLCGGN(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> list = new List<GameObject>();
		if (destructibleObjectsVariants != null)
		{
			for (int i = 0; i < destructibleObjectsVariants.Length; i++)
			{
				list.AddRange(destructibleObjectsVariants[i].ActivateDestructibleObjectsStyle(DCIMOMHGLNM));
			}
		}
		return list;
	}

	private void NNEPCJAIKMC(int BJLDIHODEDA)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)obstacleSpawner != (Object)null && ((Component)obstacleSpawner).gameObject.activeInHierarchy)
		{
			GameObject val = MineBlockersGenerator.MJBPIHEPMJP(BJLDIHODEDA, obstacleSpawner.position, obstacleSpawner.parent.parent, LLDKEKOJKDC());
			if ((Object)(object)val != (Object)null && val.transform.childCount > 0)
			{
				((Component)val.transform.GetChild(1)).gameObject.SetActive(false);
			}
			((Component)obstacleSpawner).gameObject.SetActive(false);
		}
	}

	public void BBMKJFADMNL(int BJLDIHODEDA, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format(" / ", ((Object)this).name, IDJPDDPGLAK(), MHLHFEDLOCP));
		}
		EHJHMDIBGKD();
		MEEAKBNEKEP();
		List<GameObject> source = MPLLHHLCGGN(DCIMOMHGLNM);
		FPOGJEHMLCN = (from obj in source
			select obj.GetComponent<DestructibleObject>() into destructible
			where (Object)(object)destructible != (Object)null
			select destructible).ToArray();
		if (Application.isPlaying)
		{
			FGPOPBBHAIF();
			HGFGONFPJMI();
		}
		NNEPCJAIKMC(BJLDIHODEDA);
		PCAOALJOCCJ();
		if (OnlineManager.PlayingOnline())
		{
			KHIMECBDFGK();
		}
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"Dialogue System/Conversation/TavernFilthy/Entry/10/Dialogue Text");
		}
	}

	public void AddFishingTiles(HashSet<Vector3> FEOLOCIPKMB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		Tilemap fishingTilemap = BAGPGIGDLNK.commonTilemaps.fishingTilemap;
		if ((Object)(object)fishingTilemap == (Object)null)
		{
			return;
		}
		BoundsInt cellBounds = fishingTilemap.cellBounds;
		EnsureBufferSize(cellBounds);
		fishingTilemap.GetTilesBlockNonAlloc(cellBounds, OJLIPCJNDNA);
		Vector3Int size = ((BoundsInt)(ref cellBounds)).size;
		int x = ((Vector3Int)(ref size)).x;
		int num = 0;
		while (true)
		{
			int num2 = num;
			size = ((BoundsInt)(ref cellBounds)).size;
			if (num2 >= ((Vector3Int)(ref size)).x)
			{
				break;
			}
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				size = ((BoundsInt)(ref cellBounds)).size;
				if (num4 >= ((Vector3Int)(ref size)).y)
				{
					break;
				}
				int num5 = num + num3 * x;
				if ((Object)(object)OJLIPCJNDNA[num5] != (Object)null)
				{
					FEOLOCIPKMB.Add(((GridLayout)BAGPGIGDLNK.commonTilemaps.fishingTilemap).CellToWorld(new Vector3Int(num + ((BoundsInt)(ref cellBounds)).xMin, num3 + ((BoundsInt)(ref cellBounds)).yMin, 0)));
				}
				num3++;
			}
			num++;
		}
	}

	public void PHPLGIJCFNA(int FAGMIHOEJHP)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("ActionBar10", ((Object)this).name, FGIODCJAMAP(), MFIHHANJHFK()));
		}
		LBGFOAPNBEF(FAGMIHOEJHP);
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"<color=#FF3800>");
		}
	}

	public void LDIJMFGJNAM(int BJLDIHODEDA, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)string.Format("sprout seeds", ((Object)this).name, EJAKKFJBFMC(), MFIHHANJHFK()));
		}
		FJOOLJODIDC();
		HCGKNHPPCBE();
		List<GameObject> source = EKGEDMLEFFN(DCIMOMHGLNM);
		FPOGJEHMLCN = (from obj in source
			select obj.GetComponent<DestructibleObject>() into destructible
			where (Object)(object)destructible != (Object)null
			select destructible).ToArray();
		if (Application.isPlaying)
		{
			FGPOPBBHAIF();
			HGFGONFPJMI();
		}
		JFFHNCLLNJL(BJLDIHODEDA);
		PCAOALJOCCJ();
		if (OnlineManager.PlayingOnline())
		{
			KHIMECBDFGK();
		}
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"Get Components ");
		}
	}

	private void ILJDMHDHGGG()
	{
		if ((Application.isPlaying || ProceduralMine.GGFJGHHHEJC.showPathNodes) && minePieceSO.variants != null)
		{
			variantObjects[variantIndex].ACOOMNHNEFF(minePieceSO, variantIndex);
		}
	}

	public void ActivateVariants(int FAGMIHOEJHP)
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)$"================== Activate Variants Piece: ({((Object)this).name}-{JBCFIHPKMLF}/{MHLHFEDLOCP}) =======================");
		}
		LBGFOAPNBEF(FAGMIHOEJHP);
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)"========================================================================================");
		}
	}

	public DestructibleObject[] KEBINNLEPBG()
	{
		return FPOGJEHMLCN;
	}

	private List<GameObject> MMHGMCIOGKP(List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		List<GameObject> list = new List<GameObject>();
		if (destructibleObjectsVariants != null)
		{
			for (int i = 1; i < destructibleObjectsVariants.Length; i += 0)
			{
				list.AddRange(destructibleObjectsVariants[i].KBHMGGBOMGA(DCIMOMHGLNM));
			}
		}
		return list;
	}

	public void RestoreNonAltarVariant()
	{
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)$"[RestoreNonAltarVariant] - VariantObjects: {variantObjects.Length} - ({((Object)this).name}-{JBCFIHPKMLF}/{MHLHFEDLOCP}) ");
		}
		if (variantObjects == null || variantObjects.Length == 0)
		{
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 0; i < variantObjects.Length; i++)
		{
			if ((Object)(object)variantObjects[i] != (Object)null && (variantObjects[i].hasPuzzleAltar || variantObjects[i].hasPuzzle))
			{
				hashSet.Add(i);
			}
		}
		if (Application.isEditor && printDebugLogs)
		{
			Debug.Log((object)(((Object)((Component)this).gameObject).name + " - Restoring non-altar variants. Excluded indices for variants with puzzle or altar: " + string.Join(", ", hashSet)), (Object)(object)this);
		}
		BEBHGBKJJEL = MineVariantsSelector.CIBLIEJHFOC(this, variantObjects.Length, hashSet);
		for (int j = 0; j < variantObjects.Length; j++)
		{
			if ((Object)(object)variantObjects[j] == (Object)null)
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.LogError((object)("The mine piece " + ((Object)((Component)this).gameObject).name + " has null in variant objects list."), (Object)(object)this);
				}
			}
			else if (variantObjects[j].hasPuzzleAltar)
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.Log((object)(((Object)((Component)this).gameObject).name + " - Deactivating variant object " + ((Object)((Component)variantObjects[j]).gameObject).name + " because it has puzzle altar and this method is for restoring non-altar variants."), (Object)(object)this);
				}
				((Component)variantObjects[j]).gameObject.SetActive(false);
			}
			else if (j == BEBHGBKJJEL)
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.Log((object)$"{((Object)((Component)this).gameObject).name} - Restoring non-altar variant object {((Object)((Component)variantObjects[j]).gameObject).name} at index {j} for piece {((Object)((Component)this).gameObject).name}. Next variant index: {BEBHGBKJJEL}", (Object)(object)this);
				}
				((Component)variantObjects[j]).gameObject.SetActive(true);
			}
			else
			{
				if (Application.isEditor && printDebugLogs)
				{
					Debug.Log((object)$"{((Object)((Component)this).gameObject).name} - Deactivating non-altar variant object {((Object)((Component)variantObjects[j]).gameObject).name} at index {j} for piece {((Object)((Component)this).gameObject).name} because it's not the selected variant. Next variant index: {BEBHGBKJJEL}", (Object)(object)this);
				}
				((Component)variantObjects[j]).gameObject.SetActive(false);
			}
		}
	}

	private void CIGEKPMKCEI()
	{
	}

	private void HGFBIBEIMPG()
	{
		if (occupyNodesWithColliders == null)
		{
			return;
		}
		for (int i = 0; i < occupyNodesWithColliders.Length; i++)
		{
			if ((Object)(object)occupyNodesWithColliders[i] == (Object)null)
			{
				Debug.LogError((object)("The mine piece " + ((Object)((Component)this).gameObject).name + " has null in occupy nodes with colliders list."), (Object)(object)this);
			}
			else
			{
				occupyNodesWithColliders[i].OccupyNodes();
			}
		}
	}

	private void NJPELJCJEFB()
	{
	}
}
