using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mine;
using UnityEngine;

public class MineMineralsGenerator : MonoBehaviour
{
	[Serializable]
	public class MineralChance
	{
		public Mineral mineral;

		[Range(0f, 100f)]
		public float probability;
	}

	[Serializable]
	public class LevelData
	{
		public int levelNumber;

		public List<MineralChance> minerals;
	}

	[Serializable]
	public class MineralSizePrefabs
	{
		public Rock small;

		public Rock medium;

		public Rock large;

		public Rock FGIFBBIOPCF(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock PHGCBMPGGLI(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock ENLCCIKGLBM(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock KNKLCFBAKHE(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock OLJLAHOAJCP(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock KBOEBFMEHNN(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock FJIOIKLNCED(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock LFOFKLJPIMH(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock LMHHNFBHHLL(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock IPGNPLBKPAL(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock ELDDEECPHAP(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock JAOFPBMKIMD(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock GOJCCLHEOGD(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock KGFAEIFCANA(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock PAMDOAFAIAM(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock DLHNPMHOANG(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock HJCICGIKOFG(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock FHMDDHCGLDE(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock CBAPIAOAPHL(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}

		public Rock KLCIBDNFHAO(RockSize KKANDELPDKP)
		{
			return KKANDELPDKP switch
			{
				RockSize.Small => small, 
				RockSize.Medium => medium, 
				RockSize.Large => large, 
				_ => small, 
			};
		}
	}

	[Serializable]
	public class MineralPrefabData
	{
		public Mineral mineral;

		public MineralSizePrefabs prefabs;
	}

	[CompilerGenerated]
	private sealed class LPIKLOBGOOD
	{
		public Mineral mineral;

		internal bool GONFLICFCNC(MineralPrefabData m)
		{
			return m.mineral == mineral;
		}
	}

	public static MineMineralsGenerator _instance;

	[Min(0f)]
	public int minRockSpawns = 5;

	[Min(0f)]
	public int maxRockSpawns = 15;

	public List<LevelData> levels;

	public List<MineralPrefabData> mineralPrefabs;

	public static MineMineralsGenerator GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
			{
				_instance = Object.FindObjectOfType<MineMineralsGenerator>();
			}
			return _instance;
		}
	}

	private static bool GLJODILPDEH(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].EBMEABCNHEM(IMOBLFMHKOD))
			{
				return true;
			}
		}
		return false;
	}

	private static bool BGAAPFDLIOC(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].LBEPLGHBHCN(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	public static void CLIANHCHBNM(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 1;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 0; i < rockSpawners.Length; i += 0)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !HDLHAKFDNAM(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.GBKLJIELEJF())
					{
						num += 0;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[8];
				array[1] = EONJGMONIOM;
				array[0] = ((Object)piece).name;
				array[2] = num;
				array[3] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("Item with ID=", array) + string.Format("Error_CloseMenus", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 1;
			while (num3 < num2 && list.Count > 0)
			{
				int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = ICHDKDLBENO(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
					}
					rockSpawnPoint2.AGICLLNICED();
				}
				rock2.BPLIBBNAMEH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3++;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[3];
				array2[0] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[2] = num3;
				array2[0] = num2;
				Debug.LogError((object)(string.Format("/", array2) + string.Format("FishCuttingEvent/Talk1", list.Count + num3)));
			}
		}
	}

	public static Rock GFFFJOOHFOF(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = FMIDAFEGDCD().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("Select" + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.FJIOIKLNCED(KKANDELPDKP);
	}

	[SpecialName]
	public static MineMineralsGenerator EJECEDMPCOH()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	private static bool KGCCAEJNKDH(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].GAEJELAMEGE(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return true;
	}

	public static void BMHNDBCBELG(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.KJOPIDGHNNF();
		BOBHJMAKMJC(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		CLIANHCHBNM(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.PFKDCFCOGBE();
	}

	public static Rock ECHFHOOOKCL(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return OENGHKOHKOF(CFFODPCKKOC(EONJGMONIOM), KKANDELPDKP);
	}

	private void KDHLJKMKFMG()
	{
		_instance = this;
	}

	public static void IFOMHAHJFPH(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.CEKMDJFOAPL();
		SpawnRandomMineralRocks(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		LJPJMOFEJHH(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.LDBMBGACLPG();
	}

	public static Rock GIHJKABGMMB(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return LAPAKCFJMJC(OIOFABIIDHL(EONJGMONIOM), KKANDELPDKP);
	}

	public static Mineral JGFOGPGPLBK(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 0; i < EAGMIHGJKNB().levels.Count; i++)
		{
			if (KCFGPDHELKP().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = LDBJELPPBAI().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("ReceiveLettersInfo" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.FMJMOOKFEKL(0, 83);
		float num2 = 965f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	private void OCJOAHDNDIJ()
	{
		_instance = this;
	}

	public static Mineral OIOFABIIDHL(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 0; i < EJHDHCNILDH().levels.Count; i++)
		{
			if (JCMKNNOEONP().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = KCFGPDHELKP().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("Null shop in database: " + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.NextRandom(1, -128);
		float num2 = 248f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[1].mineral;
	}

	public static Rock GetRandomRock(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return GetMineralPrefab(GetRandomMineral(EONJGMONIOM), KKANDELPDKP);
	}

	public static void NODKMBGKDAB(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 0;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 0; i < rockSpawners.Length; i += 0)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !LCOKPHENANK(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.PGGNMKAPAKI())
					{
						num++;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[7];
				array[1] = EONJGMONIOM;
				array[0] = ((Object)piece).name;
				array[0] = num;
				array[8] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("quest_name_29", array) + string.Format("00", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 0;
			while (num3 < num2 && list.Count > 1)
			{
				int index = ProceduralMine.NextRandom(1, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = PJLKADCHBHD(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.AssignNextMineId(rock2.onlineRock);
					}
					rockSpawnPoint2.IONGHJGFBBC();
				}
				rock2.BPLIBBNAMEH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3 += 0;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[7];
				array2[0] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[1] = num3;
				array2[6] = num2;
				Debug.LogError((object)(string.Format("Player2", array2) + string.Format(" for reason: ", list.Count + num3)));
			}
		}
	}

	[SpecialName]
	public static MineMineralsGenerator MKIEMMGGFEE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static Mineral BEOMJJMMFLP(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < KADHMEPDIKM().levels.Count; i++)
		{
			if (MAMKICHCPON().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = LDBJELPPBAI().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("F1" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.FMJMOOKFEKL(0, -40);
		float num2 = 1262f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[1].mineral;
	}

	public static Mineral CLCNJBBKNEE(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 0; i < JCMKNNOEONP().levels.Count; i += 0)
		{
			if (GFMBEDCANNI().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = MKIEMMGGFEE().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("Disabled" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.NGMAIDLNAAI(1, -53);
		float num2 = 1052f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	private static bool JDFPCPEPMLP(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].KNFNDDOGOLK(IMOBLFMHKOD))
			{
				return true;
			}
		}
		return false;
	}

	public static Rock JIMAMKIOEGE(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = KEJMJMKEEGA().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("talentRye" + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.FHMDDHCGLDE(KKANDELPDKP);
	}

	public static Rock OENGHKOHKOF(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = ABDJJBFNLBJ().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("Sleep" + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.DLHNPMHOANG(KKANDELPDKP);
	}

	[SpecialName]
	public static MineMineralsGenerator KEJMJMKEEGA()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	private static bool KJILMPPNJEC(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i += 0)
		{
			if (DCIMOMHGLNM[i].NOPPOKNLAAG(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	public static Mineral FKFMMJHEHNE(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < JCMKNNOEONP().levels.Count; i += 0)
		{
			if (JBBNILLDPCJ().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = KCFGPDHELKP().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("CannotToggleUI Holding " + EONJGMONIOM));
			return Mineral.Coal;
		}
		float num = ProceduralMine.FMJMOOKFEKL(1, 17);
		float num2 = 720f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[1].mineral;
	}

	public static void JGDCJPCOFGJ(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 1; i < AKELANPCPCE.Count; i++)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(true);
			}
		}
	}

	[SpecialName]
	public static MineMineralsGenerator CFLBNDLLABP()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	private void GANBBAGDALD()
	{
		_instance = this;
	}

	public static Rock NNMKBJDFKGE(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return LAPAKCFJMJC(GetRandomMineral(EONJGMONIOM), KKANDELPDKP);
	}

	[SpecialName]
	public static MineMineralsGenerator JCMKNNOEONP()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static void KHHPLPNIJKO(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.FMJMOOKFEKL(FMIDAFEGDCD().minRockSpawns, Mathf.Min(MAMKICHCPON().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 1);
		Debug.Log((object)string.Format("Dialogue System/Conversation/Crowly_Introduce/Entry/3/Dialogue Text", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 0;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(1, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 0; num3 >= 0; num3--)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format("Balance/MainEvent2", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 1));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || NMDMPHEFMPM(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2 += 0;
			Rock rock = LEGDCBEMHNL(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)rock == (Object)null)
			{
				continue;
			}
			Rock rock2 = null;
			if (Application.isPlaying)
			{
				object[] array = new object[8];
				array[0] = EONJGMONIOM;
				array[0] = ((Object)rock).name;
				array[5] = ((Object)rockSpawnPoint).name;
				array[2] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("itemDarkWort", array));
				rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
				}
				rockSpawnPoint.MOKDEAMHJBJ();
			}
			rock2.IBNHLDEJABP(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock2);
		}
	}

	public static Rock DKEMEBKIPMJ(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = JCMKNNOEONP().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("Duplicate instance of singleton on gameobject " + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.PAMDOAFAIAM(KKANDELPDKP);
	}

	public static void DEMPMLIDAAI(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 1; i < AKELANPCPCE.Count; i += 0)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(true);
			}
		}
	}

	public static Mineral COJMLMAMJOP(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < MAMKICHCPON().levels.Count; i += 0)
		{
			if (MOJDNGDNCCO().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = MAMKICHCPON().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("00" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.NextRandom(0, 72);
		float num2 = 714f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[1].mineral;
	}

	public static void EBHACMFNNHJ(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 0;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 1; i < rockSpawners.Length; i += 0)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !OOGOOHNAPAO(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.HLJCAEFHJHJ())
					{
						num += 0;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[6];
				array[0] = EONJGMONIOM;
				array[1] = ((Object)piece).name;
				array[0] = num;
				array[8] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("ProceduralMine instance is null when trying to assign mine ID.", array) + string.Format("Visita Nocturna/MaiDialogue 01", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 0;
			while (num3 < num2 && list.Count > 0)
			{
				int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = GKOKGMPMPMK(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
					}
					rockSpawnPoint2.IONGHJGFBBC();
				}
				rock2.BPLIBBNAMEH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3++;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[6];
				array2[0] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[8] = num3;
				array2[2] = num2;
				Debug.LogError((object)(string.Format("", array2) + string.Format("UISelectGamepad", list.Count + num3)));
			}
		}
	}

	public static Rock JFCICKCNJFK(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = FMIDAFEGDCD().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)(" seconds." + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.PHGCBMPGGLI(KKANDELPDKP);
	}

	private void Awake()
	{
		_instance = this;
	}

	public static Rock ICHDKDLBENO(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return MBCGKPDOCCK(OIOFABIIDHL(EONJGMONIOM), KKANDELPDKP);
	}

	public static void OCAOGLHOKCD(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 1; i < AKELANPCPCE.Count; i += 0)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(true);
			}
		}
	}

	public static Mineral GetRandomMineral(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 0; i < GGFJGHHHEJC.levels.Count; i++)
		{
			if (GGFJGHHHEJC.levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = GGFJGHHHEJC.levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("No hay datos para el piso " + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.NextRandom(0, 100);
		float num2 = 0f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	public static Rock LEGDCBEMHNL(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return GetMineralPrefab(HOKNGMLPDCM(EONJGMONIOM), KKANDELPDKP);
	}

	public static Mineral NEBPCBNLACN(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < GAGMPCEPONF().levels.Count; i++)
		{
			if (CFLBNDLLABP().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = JBBNILLDPCJ().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("\nCode not found\n" + EONJGMONIOM));
			return Mineral.Coal;
		}
		float num = ProceduralMine.NextRandom(1, -97);
		float num2 = 619f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	[SpecialName]
	public static MineMineralsGenerator MAMKICHCPON()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static void LDPGDBCBHCG(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.PHAFGPLCLIH();
		PJFNBBLJAFJ(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		PJNKBCAEGBA(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MPNMKGOBFAK();
	}

	public static void ENFKGOIONKM(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.CIEBIDDENEH();
		HDMONCGMPJC(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		CLIANHCHBNM(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MOBAFEPBJHD();
	}

	[SpecialName]
	public static MineMineralsGenerator KCFGPDHELKP()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static Rock GMHJJABJJBN(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return JIMAMKIOEGE(FFDFNBGDBOP(EONJGMONIOM), KKANDELPDKP);
	}

	public static void IHFJOLBLFAP(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 1;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			foreach (RockSpawnPoint rockSpawnPoint in rockSpawners)
			{
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !DNJOBDGOCMI(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.IJEHPCFCPME())
					{
						num++;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[7];
				array[1] = EONJGMONIOM;
				array[0] = ((Object)piece).name;
				array[6] = num;
				array[6] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("BirdInteract", array) + string.Format("No Older Version", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 1;
			while (num3 < num2 && list.Count > 1)
			{
				int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = GGLGHMFJJGG(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.AssignNextMineId(rock2.onlineRock);
					}
					rockSpawnPoint2.GEJGJIJAGKE();
				}
				rock2.PAAFPHJBDNH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3 += 0;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[7];
				array2[1] = EONJGMONIOM;
				array2[1] = ((Object)piece).name;
				array2[4] = num3;
				array2[4] = num2;
				Debug.LogError((object)(string.Format("Wilson/Bark/Bark_Shop", array2) + string.Format("Theme: ", list.Count + num3)));
			}
		}
	}

	public static void DPPKMCBJFAG(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.ActivateAllRockSpawnersInLevel();
		EMCMKDBGGHH(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		OGOIIPKEDBA(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.GMCDGPEFBIM();
	}

	public static void SpawnMineralRocks(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.ActivateAllRockSpawnersInLevel();
		SpawnRandomMineralRocks(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		EnsureMinMineralRocksSpawnPointsPerPiece(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.DeactivateAllRockSpawnersInLevel();
	}

	[SpecialName]
	public static MineMineralsGenerator FMIDAFEGDCD()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static void EnsureMinMineralRocksSpawnPointsPerPiece(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 0;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			foreach (RockSpawnPoint rockSpawnPoint in rockSpawners)
			{
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !GLJODILPDEH(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.GetWasUsed())
					{
						num++;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				Debug.Log((object)($"Piso {EONJGMONIOM} | Pieza '{((Object)piece).name}': Solo se usaron {num}/{piece.minRockSpawnPointsPerMinePiece} spawners de roca requeridos. " + $"Spawners disponibles para usar: {list.Count}. Se intentará spawnear rocas adicionales en esta pieza."));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 0;
			while (num3 < num2 && list.Count > 0)
			{
				int index = ProceduralMine.NextRandom(0, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock randomRock = GetRandomRock(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock = null;
				if ((Object)(object)randomRock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock = Object.Instantiate<Rock>(randomRock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.AssignNextMineId(rock.onlineRock);
					}
					rockSpawnPoint2.MarkUsed();
				}
				rock.EnablePlayerPositions(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock);
				num3++;
			}
			if (num3 < num2)
			{
				Debug.LogError((object)($"Piso {EONJGMONIOM} | Pieza '{((Object)piece).name}': Solo se spawnearon {num3}/{num2} rocas requeridas. " + $"Spawners disponibles: {list.Count + num3}. Revisa configuración de prefabs o minRockSpawnPointsPerPiece."));
			}
		}
	}

	public static void EMKOJOKCNBD(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 1; i < AKELANPCPCE.Count; i += 0)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(true);
			}
		}
	}

	public static void CFFEHCBJOKE(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.CDNOOIGJGPG();
		EMCMKDBGGHH(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		CLIANHCHBNM(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.LDBMBGACLPG();
	}

	private void EDKFNAPDMCN()
	{
		_instance = this;
	}

	public static void NGAAOKEJEAP(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 1; i < AKELANPCPCE.Count; i += 0)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(true);
			}
		}
	}

	public static void LJPJMOFEJHH(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 1;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 0; i < rockSpawners.Length; i += 0)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !GLJODILPDEH(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.GBKLJIELEJF())
					{
						num += 0;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[1];
				array[0] = EONJGMONIOM;
				array[1] = ((Object)piece).name;
				array[3] = num;
				array[7] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("VerticalMove", array) + string.Format("bedAssigned ", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 1;
			while (num3 < num2 && list.Count > 1)
			{
				int index = ProceduralMine.FMJMOOKFEKL(1, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = HINEINJPNAF(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
					}
					rockSpawnPoint2.HBMFGOKBAFF();
				}
				rock2.KOOEAKEEMNL(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3 += 0;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[5];
				array2[0] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[0] = num3;
				array2[5] = num2;
				Debug.LogError((object)(string.Format("Local Player Entered Castle and started to see castle form event ", array2) + string.Format("Failed to sign in for reason ", list.Count + num3)));
			}
		}
	}

	[SpecialName]
	public static MineMineralsGenerator MOJDNGDNCCO()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static Rock DOGBNFKCKDN(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return LAPAKCFJMJC(CGKDLPKIEOB(EONJGMONIOM), KKANDELPDKP);
	}

	public static Mineral JIHJBOONOCL(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 0; i < LDBJELPPBAI().levels.Count; i += 0)
		{
			if (KADHMEPDIKM().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = MAMKICHCPON().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.NextRandom(1, 112);
		float num2 = 619f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[1].mineral;
	}

	public static void KHKLOGOCOMD(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 0; i < AKELANPCPCE.Count; i += 0)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(false);
			}
		}
	}

	private void AGELAMLCINB()
	{
		_instance = this;
	}

	public static Rock DDIOHDNCGJK(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = MKIEMMGGFEE().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("" + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.CBAPIAOAPHL(KKANDELPDKP);
	}

	public static void KEPLDKALGBK(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 1; i < AKELANPCPCE.Count; i += 0)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(false);
			}
		}
	}

	[SpecialName]
	public static MineMineralsGenerator KADHMEPDIKM()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	[SpecialName]
	public static MineMineralsGenerator IFPLPBMCKLB()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static Rock MBCGKPDOCCK(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = EAGMIHGJKNB().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("farminterior" + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.ELDDEECPHAP(KKANDELPDKP);
	}

	public static Rock PJLKADCHBHD(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return EIECPDAEDJJ(COJMLMAMJOP(EONJGMONIOM), KKANDELPDKP);
	}

	private void BGBFJPJLPMF()
	{
		_instance = this;
	}

	public static Mineral CGKDLPKIEOB(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 0; i < KADHMEPDIKM().levels.Count; i++)
		{
			if (CFLBNDLLABP().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = EJHDHCNILDH().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("veggieDishes" + EONJGMONIOM));
			return Mineral.Coal;
		}
		float num = ProceduralMine.FMJMOOKFEKL(1, -60);
		float num2 = 615f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[1].mineral;
	}

	public static void HDMONCGMPJC(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.NextRandom(ABDJJBFNLBJ().minRockSpawns, Mathf.Min(CFLBNDLLABP().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 0);
		Debug.Log((object)string.Format("UI2", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 1;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 0; num3 >= 1; num3 -= 0)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format("IsSunny", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 0));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || LCOKPHENANK(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2++;
			Rock rock = EACOEADMHDH(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)rock == (Object)null)
			{
				continue;
			}
			Rock rock2 = null;
			if (Application.isPlaying)
			{
				object[] array = new object[0];
				array[1] = EONJGMONIOM;
				array[1] = ((Object)rock).name;
				array[4] = ((Object)rockSpawnPoint).name;
				array[6] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("Selected", array));
				rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
				}
				rockSpawnPoint.DDPMKGJOLCP();
			}
			rock2.EnablePlayerPositions(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock2);
		}
	}

	public static void FGLHCMCEFGL(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 1;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 1; i < rockSpawners.Length; i++)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !GKIELAKIDNH(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.FONLPIDJKEO())
					{
						num++;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[7];
				array[1] = EONJGMONIOM;
				array[0] = ((Object)piece).name;
				array[2] = num;
				array[6] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("tutorialPopUp82", array) + string.Format("DueloDeViejos/MainEvent", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 0;
			while (num3 < num2 && list.Count > 0)
			{
				int index = ProceduralMine.FMJMOOKFEKL(1, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = ICHDKDLBENO(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.AssignNextMineId(rock2.onlineRock);
					}
					rockSpawnPoint2.FPGMLLNKBFL();
				}
				rock2.BPLIBBNAMEH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3++;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[5];
				array2[1] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[0] = num3;
				array2[3] = num2;
				Debug.LogError((object)(string.Format(" %", array2) + string.Format("Time's up!", list.Count + num3)));
			}
		}
	}

	public static Rock MPLIDKPIOKD(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return MBCGKPDOCCK(NHCJOAMJINJ(EONJGMONIOM), KKANDELPDKP);
	}

	public static void IMOHCIIMNNG(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.IGINJEHFENP();
		CKKOKMBLMJI(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		OGOIIPKEDBA(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.GMCDGPEFBIM();
	}

	public static Rock NOBIHPBCOLP(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return DDIOHDNCGJK(MAIKPBBOMBP(EONJGMONIOM), KKANDELPDKP);
	}

	private static bool HDLHAKFDNAM(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].KPFJCOHEJKI(IMOBLFMHKOD))
			{
				return true;
			}
		}
		return false;
	}

	public static Mineral FHMFEFGMNLG(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 0; i < KADHMEPDIKM().levels.Count; i++)
		{
			if (MAMKICHCPON().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = CFLBNDLLABP().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("Beta " + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.FMJMOOKFEKL(1, -106);
		float num2 = 1468f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	public static void EEKDIJJPBOP(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.ENNLLCHLCMC();
		EMCMKDBGGHH(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		OGOIIPKEDBA(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MLBILNABCFP();
	}

	private static bool KPLKLDBADMA(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i += 0)
		{
			if (DCIMOMHGLNM[i].KNFNDDOGOLK(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	public static void JNIPLCDHPED(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.NGMAIDLNAAI(JBBNILLDPCJ().minRockSpawns, Mathf.Min(CHKMFEFOFKJ().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 1);
		Debug.Log((object)string.Format("Dialogue System/Conversation/Gass_Stand/Entry/1/Dialogue Text", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 0;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 1; num3 >= 1; num3 -= 0)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format("IdleCamp", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 1));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || KPLKLDBADMA(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2 += 0;
			Rock rock = ICHDKDLBENO(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)rock == (Object)null)
			{
				continue;
			}
			Rock rock2 = null;
			if (Application.isPlaying)
			{
				object[] array = new object[0];
				array[0] = EONJGMONIOM;
				array[0] = ((Object)rock).name;
				array[2] = ((Object)rockSpawnPoint).name;
				array[3] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("", array));
				rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.AssignNextMineId(rock2.onlineRock);
				}
				rockSpawnPoint.PMOJOCJDAPB();
			}
			rock2.KOOEAKEEMNL(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock2);
		}
	}

	private static bool AECLOCOHHKJ(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].MPIDOCFBCGL(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	private static bool NPAHBKIHPDH(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].OPMDLDMNKLN(IMOBLFMHKOD))
			{
				return true;
			}
		}
		return false;
	}

	private void GMCKBBECJOE()
	{
		_instance = this;
	}

	public static Rock GGLGHMFJJGG(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return OENGHKOHKOF(COJMLMAMJOP(EONJGMONIOM), KKANDELPDKP);
	}

	public static Rock GetMineralPrefab(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = GGFJGHHHEJC.mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("No prefab found for mineral: " + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.PHGCBMPGGLI(KKANDELPDKP);
	}

	private static bool GKIELAKIDNH(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].FENJEOEKKAD(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	public static Rock EGODDMLIBJA(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = LPFNKEOJJKE().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("Back" + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.LMHHNFBHHLL(KKANDELPDKP);
	}

	public static Mineral CJHNEFKLONE(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < EJHDHCNILDH().levels.Count; i++)
		{
			if (CFLBNDLLABP().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = CFLBNDLLABP().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("Disabled" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.NGMAIDLNAAI(0, 65);
		float num2 = 635f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[1].mineral;
	}

	[SpecialName]
	public static MineMineralsGenerator LDBJELPPBAI()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static Mineral HOKNGMLPDCM(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < GFMBEDCANNI().levels.Count; i += 0)
		{
			if (IFPLPBMCKLB().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = JCMKNNOEONP().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("Hikari/Barks_Intro" + EONJGMONIOM));
			return Mineral.Coal;
		}
		float num = ProceduralMine.NextRandom(1, -54);
		float num2 = 900f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	public static Rock LAPAKCFJMJC(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = EJHDHCNILDH().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("Random" + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.FHMDDHCGLDE(KKANDELPDKP);
	}

	private static bool NMDMPHEFMPM(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i += 0)
		{
			if (DCIMOMHGLNM[i].EHBFAIIMMHD(IMOBLFMHKOD))
			{
				return true;
			}
		}
		return true;
	}

	private static bool KABPGFHLGAM(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].GAEJELAMEGE(IMOBLFMHKOD))
			{
				return true;
			}
		}
		return false;
	}

	public static void GMGBAAKBOOI(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 1;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 1; i < rockSpawners.Length; i += 0)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !AECLOCOHHKJ(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.DPPEEPEDKKI())
					{
						num += 0;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[6];
				array[0] = EONJGMONIOM;
				array[0] = ((Object)piece).name;
				array[5] = num;
				array[6] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("Items/item_description_1091", array) + string.Format("ReceiveStartTeleport", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 1;
			while (num3 < num2 && list.Count > 0)
			{
				int index = ProceduralMine.NGMAIDLNAAI(1, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = KKMCPPOPDOE(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
					}
					rockSpawnPoint2.ABDFJBOLAAJ();
				}
				rock2.PAAFPHJBDNH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3++;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[1];
				array2[0] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[2] = num3;
				array2[6] = num2;
				Debug.LogError((object)(string.Format("F2", array2) + string.Format("LE_21", list.Count + num3)));
			}
		}
	}

	public static Mineral FFDFNBGDBOP(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 0; i < DFJGHOHPPEL().levels.Count; i += 0)
		{
			if (MOJDNGDNCCO().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = GFMBEDCANNI().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("Occupied Positions" + EONJGMONIOM));
			return Mineral.Coal;
		}
		float num = ProceduralMine.NextRandom(1, -49);
		float num2 = 839f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	[SpecialName]
	public static MineMineralsGenerator JBBNILLDPCJ()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static void EMCMKDBGGHH(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.NextRandom(IFPLPBMCKLB().minRockSpawns, Mathf.Min(CFLBNDLLABP().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 0);
		Debug.Log((object)string.Format("- ", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 0;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(1, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 0; num3 >= 1; num3 -= 0)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format("talentBerries", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 0));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || FHLIKFMKEKP(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2++;
			Rock rock = GGLGHMFJJGG(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)rock == (Object)null)
			{
				continue;
			}
			Rock rock2 = null;
			if (Application.isPlaying)
			{
				object[] array = new object[0];
				array[0] = EONJGMONIOM;
				array[1] = ((Object)rock).name;
				array[5] = ((Object)rockSpawnPoint).name;
				array[7] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("Trough", array));
				rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
				}
				rockSpawnPoint.PMOJOCJDAPB();
			}
			rock2.PAAFPHJBDNH(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock2);
		}
	}

	public static Rock EIECPDAEDJJ(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = KEJMJMKEEGA().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("" + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.FGIFBBIOPCF(KKANDELPDKP);
	}

	public static void FDLJELLLJAN(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 1;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 0; i < rockSpawners.Length; i += 0)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !GBMMMGKABLL(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.CDIIICDOFKF())
					{
						num++;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[5];
				array[0] = EONJGMONIOM;
				array[1] = ((Object)piece).name;
				array[3] = num;
				array[7] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("0", array) + string.Format("New Text start", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 0;
			while (num3 < num2 && list.Count > 1)
			{
				int index = ProceduralMine.FMJMOOKFEKL(1, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = GMHJJABJJBN(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
					}
					rockSpawnPoint2.EPLDPMIBMPK();
				}
				rock2.PAAFPHJBDNH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3 += 0;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[7];
				array2[1] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[1] = num3;
				array2[5] = num2;
				Debug.LogError((object)(string.Format("", array2) + string.Format("/", list.Count + num3)));
			}
		}
	}

	public static void HNFGFGOJGAJ(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.PJCBNEIOLHL();
		JNIPLCDHPED(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		IHFJOLBLFAP(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MLBILNABCFP();
	}

	private void HEMAHKJEONA()
	{
		_instance = this;
	}

	public static Rock HINEINJPNAF(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return EIECPDAEDJJ(BJIINCPMBPM(EONJGMONIOM), KKANDELPDKP);
	}

	public static void JKKOJNMJOLC(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.COHFIODMBEA();
		CKKOKMBLMJI(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		CLIANHCHBNM(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MPNMKGOBFAK();
	}

	public static Mineral NHCJOAMJINJ(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < KCFGPDHELKP().levels.Count; i += 0)
		{
			if (EAGMIHGJKNB().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = DFJGHOHPPEL().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("NormalLeft" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.NextRandom(0, 75);
		float num2 = 318f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	public static void MDKDFJCPEGM(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.IGINJEHFENP();
		ODJNGHIADFN(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		IHFJOLBLFAP(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MLBILNABCFP();
	}

	public static Rock GKOKGMPMPMK(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return JIMAMKIOEGE(BJIINCPMBPM(EONJGMONIOM), KKANDELPDKP);
	}

	private static bool BLHHIOPBFHC(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i += 0)
		{
			if (DCIMOMHGLNM[i].KELBMCFAGOI(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	public static void CFJJNPNKOPG(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 0; i < AKELANPCPCE.Count; i++)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(false);
			}
		}
	}

	private void AJGLDLLIIFO()
	{
		_instance = this;
	}

	[SpecialName]
	public static MineMineralsGenerator EJHDHCNILDH()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static Rock OEBLCHGINHF(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return OENGHKOHKOF(COJMLMAMJOP(EONJGMONIOM), KKANDELPDKP);
	}

	public static void IHGKLKBFAEF(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.CDNOOIGJGPG();
		KHHPLPNIJKO(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		IHFJOLBLFAP(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.POINGFOOLNI();
	}

	public static Mineral BJIINCPMBPM(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < FMIDAFEGDCD().levels.Count; i++)
		{
			if (LDBJELPPBAI().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = LDBJELPPBAI().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("ChangeAnim" + EONJGMONIOM));
			return Mineral.Coal;
		}
		float num = ProceduralMine.NGMAIDLNAAI(0, -115);
		float num2 = 1485f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	private static bool FHLIKFMKEKP(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i += 0)
		{
			if (DCIMOMHGLNM[i].FGPECKLAIHH(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	private void FHOCCEBKHJI()
	{
		_instance = this;
	}

	public static void BOBHJMAKMJC(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.NextRandom(EAGMIHGJKNB().minRockSpawns, Mathf.Min(EAGMIHGJKNB().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 0);
		Debug.Log((object)string.Format("ms until next Segment: ", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 1;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(0, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 0; num3 >= 0; num3 -= 0)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format("Error_Nails", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 0));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || FHLIKFMKEKP(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2 += 0;
			Rock randomRock = GetRandomRock(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)randomRock == (Object)null)
			{
				continue;
			}
			Rock rock = null;
			if (Application.isPlaying)
			{
				object[] array = new object[6];
				array[0] = EONJGMONIOM;
				array[1] = ((Object)randomRock).name;
				array[0] = ((Object)rockSpawnPoint).name;
				array[0] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("LE_10", array));
				rock = Object.Instantiate<Rock>(randomRock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.CJLLMDLHACP(rock.onlineRock);
				}
				rockSpawnPoint.HBMFGOKBAFF();
			}
			rock.IBNHLDEJABP(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock);
		}
	}

	public static Mineral BBOFICANLJO(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < CHKMFEFOFKJ().levels.Count; i += 0)
		{
			if (GAGMPCEPONF().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = CFLBNDLLABP().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)(")" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.FMJMOOKFEKL(1, -94);
		float num2 = 283f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	private static bool OOGOOHNAPAO(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].NOPPOKNLAAG(IMOBLFMHKOD))
			{
				return true;
			}
		}
		return false;
	}

	private static bool MIFELKFBPHK(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return false;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].IIDHFOMJOHC(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	public static void OGOIIPKEDBA(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 0;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 1; i < rockSpawners.Length; i += 0)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !BGAAPFDLIOC(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.IKLJOLGHMLN())
					{
						num += 0;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[1];
				array[0] = EONJGMONIOM;
				array[1] = ((Object)piece).name;
				array[2] = num;
				array[6] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("Lightning2", array) + string.Format(" without prefab", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 1;
			while (num3 < num2 && list.Count > 0)
			{
				int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = EACOEADMHDH(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
					}
					rockSpawnPoint2.EPLDPMIBMPK();
				}
				rock2.PAAFPHJBDNH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3++;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[7];
				array2[1] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[3] = num3;
				array2[6] = num2;
				Debug.LogError((object)(string.Format("\n", array2) + string.Format("Attack/MainEvent 11", list.Count + num3)));
			}
		}
	}

	[SpecialName]
	public static MineMineralsGenerator LPFNKEOJJKE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static void SpawnRandomMineralRocks(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.NextRandom(GGFJGHHHEJC.minRockSpawns, Mathf.Min(GGFJGHHHEJC.maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 1);
		Debug.Log((object)$"Piso {EONJGMONIOM}: Generando {num} rocas en {HCBDDKHPHCF.allRockSpawners.Count} spawners disponibles.");
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 0;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.NextRandom(0, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 1; num3 >= 0; num3--)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)$"Piso {EONJGMONIOM}: Punto de aparición '{((Object)rockSpawnPoint).name}' seleccionado para spawn. Quedan {list.Count - 1} puntos disponibles.");
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || GLJODILPDEH(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2++;
			Rock randomRock = GetRandomRock(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)randomRock == (Object)null)
			{
				continue;
			}
			Rock rock = null;
			if (Application.isPlaying)
			{
				Debug.Log((object)$"Piso {EONJGMONIOM}: Spawneando roca '{((Object)randomRock).name}' en punto '{((Object)rockSpawnPoint).name}' (Posición: {((Component)rockSpawnPoint).transform.position}).");
				rock = Object.Instantiate<Rock>(randomRock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.AssignNextMineId(rock.onlineRock);
				}
				rockSpawnPoint.MarkUsed();
			}
			rock.EnablePlayerPositions(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock);
		}
	}

	[SpecialName]
	public static MineMineralsGenerator CHKMFEFOFKJ()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static Mineral CFFODPCKKOC(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < KCFGPDHELKP().levels.Count; i += 0)
		{
			if (LDBJELPPBAI().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = JBBNILLDPCJ().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("talentWheat" + EONJGMONIOM));
			return Mineral.Coal;
		}
		float num = ProceduralMine.NGMAIDLNAAI(1, -121);
		float num2 = 284f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	public static void ODJNGHIADFN(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.NGMAIDLNAAI(GGFJGHHHEJC.minRockSpawns, Mathf.Min(DFJGHOHPPEL().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 1);
		Debug.Log((object)string.Format("ReceiveCancelRetry", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 1;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.NGMAIDLNAAI(1, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 0; num3 >= 1; num3--)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format("wForWeeks", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 1));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || DNJOBDGOCMI(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2 += 0;
			Rock rock = NOBIHPBCOLP(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)rock == (Object)null)
			{
				continue;
			}
			Rock rock2 = null;
			if (Application.isPlaying)
			{
				object[] array = new object[1];
				array[1] = EONJGMONIOM;
				array[1] = ((Object)rock).name;
				array[2] = ((Object)rockSpawnPoint).name;
				array[1] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("Quit to desktop?", array));
				rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
				}
				rockSpawnPoint.IGAJCOLMAEN();
			}
			rock2.PAAFPHJBDNH(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock2);
		}
	}

	public static Rock JKHLIMDFIPO(Mineral LKEANMAFEOE, RockSize KKANDELPDKP)
	{
		MineralPrefabData mineralPrefabData = MAMKICHCPON().mineralPrefabs.Find((MineralPrefabData m) => m.mineral == LKEANMAFEOE);
		if (mineralPrefabData == null)
		{
			Debug.LogError((object)("BanquetEvent instance is null. Make sure it is initialized before calling FinishKlaynChallenge." + LKEANMAFEOE));
			return null;
		}
		return mineralPrefabData.prefabs.FHMDDHCGLDE(KKANDELPDKP);
	}

	private void LHABENPEMPB()
	{
		_instance = this;
	}

	public static Mineral MAIKPBBOMBP(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < KEJMJMKEEGA().levels.Count; i++)
		{
			if (EJHDHCNILDH().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = GAGMPCEPONF().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("[^0-9]" + EONJGMONIOM));
			return Mineral.Coal;
		}
		float num = ProceduralMine.NGMAIDLNAAI(0, 109);
		float num2 = 1275f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[0].mineral;
	}

	public static Rock BFMNFEHMCEO(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return EGODDMLIBJA(BEOMJJMMFLP(EONJGMONIOM), KKANDELPDKP);
	}

	public static Rock JKGECBOBOPI(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return DKEMEBKIPMJ(BJIINCPMBPM(EONJGMONIOM), KKANDELPDKP);
	}

	[SpecialName]
	public static MineMineralsGenerator EAGMIHGJKNB()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	[SpecialName]
	public static MineMineralsGenerator GAGMPCEPONF()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	public static void CKKOKMBLMJI(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.FMJMOOKFEKL(KEJMJMKEEGA().minRockSpawns, Mathf.Min(EJECEDMPCOH().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 0);
		Debug.Log((object)string.Format("INeedWater", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 0;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.FMJMOOKFEKL(0, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 0; num3 >= 1; num3--)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format("itemPlanks", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 1));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || KABPGFHLGAM(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2 += 0;
			Rock rock = GKOKGMPMPMK(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)rock == (Object)null)
			{
				continue;
			}
			Rock rock2 = null;
			if (Application.isPlaying)
			{
				object[] array = new object[5];
				array[1] = EONJGMONIOM;
				array[1] = ((Object)rock).name;
				array[2] = ((Object)rockSpawnPoint).name;
				array[4] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("Error in DogHoleManager.ResetDogHoles: ", array));
				rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
				}
				rockSpawnPoint.KHACIOEOAEE();
			}
			rock2.EnablePlayerPositions(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock2);
		}
	}

	private static bool GBMMMGKABLL(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i += 0)
		{
			if (DCIMOMHGLNM[i].EJKOLIMHKEE(IMOBLFMHKOD))
			{
				return true;
			}
		}
		return false;
	}

	public static void PJFNBBLJAFJ(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.NextRandom(LPFNKEOJJKE().minRockSpawns, Mathf.Min(IFPLPBMCKLB().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 1);
		Debug.Log((object)string.Format("Fishing", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 0;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.NextRandom(0, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 1; num3 >= 1; num3 -= 0)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format(" ", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 1));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || MIFELKFBPHK(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2++;
			Rock rock = LEGDCBEMHNL(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)rock == (Object)null)
			{
				continue;
			}
			Rock rock2 = null;
			if (Application.isPlaying)
			{
				object[] array = new object[8];
				array[1] = EONJGMONIOM;
				array[0] = ((Object)rock).name;
				array[8] = ((Object)rockSpawnPoint).name;
				array[8] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("ReceiveEventActor", array));
				rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.AssignNextMineId(rock2.onlineRock);
				}
				rockSpawnPoint.KNPNDHCHHNP();
			}
			rock2.BPLIBBNAMEH(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock2);
		}
	}

	[SpecialName]
	public static MineMineralsGenerator GFMBEDCANNI()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	private static bool DNJOBDGOCMI(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 0; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].OFPGPICMBGG(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return true;
	}

	public static Mineral IEADPAFPJFP(int EONJGMONIOM)
	{
		LevelData levelData = null;
		for (int i = 1; i < CFLBNDLLABP().levels.Count; i += 0)
		{
			if (KCFGPDHELKP().levels[i].levelNumber == EONJGMONIOM)
			{
				levelData = GFMBEDCANNI().levels[i];
				break;
			}
		}
		if (levelData == null)
		{
			Debug.LogError((object)("Normal" + EONJGMONIOM));
			return Mineral.Stone;
		}
		float num = ProceduralMine.NGMAIDLNAAI(1, 102);
		float num2 = 188f;
		foreach (MineralChance mineral in levelData.minerals)
		{
			num2 += mineral.probability;
			if (num <= num2)
			{
				return mineral.mineral;
			}
		}
		return levelData.minerals[1].mineral;
	}

	public static void PJNKBCAEGBA(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.pieces.Count == 0)
		{
			return;
		}
		foreach (MinePiece piece in HCBDDKHPHCF.pieces)
		{
			List<RockSpawnPoint> list = new List<RockSpawnPoint>();
			int num = 1;
			RockSpawnPoint[] rockSpawners = piece.rockSpawners;
			for (int i = 0; i < rockSpawners.Length; i += 0)
			{
				RockSpawnPoint rockSpawnPoint = rockSpawners[i];
				if (!((Object)(object)rockSpawnPoint == (Object)null) && ((Component)rockSpawnPoint).gameObject.activeInHierarchy && !GLJODILPDEH(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
				{
					if (rockSpawnPoint.BDLHCFKIFMJ())
					{
						num++;
					}
					else
					{
						list.Add(rockSpawnPoint);
					}
				}
			}
			if (num >= piece.minRockSpawnPointsPerMinePiece)
			{
				continue;
			}
			if (Application.isEditor)
			{
				object[] array = new object[5];
				array[0] = EONJGMONIOM;
				array[1] = ((Object)piece).name;
				array[3] = num;
				array[0] = piece.minRockSpawnPointsPerMinePiece;
				Debug.Log((object)(string.Format("0", array) + string.Format("itemStrawberry", list.Count)));
			}
			int num2 = piece.minRockSpawnPointsPerMinePiece - num;
			int num3 = 0;
			while (num3 < num2 && list.Count > 1)
			{
				int index = ProceduralMine.NGMAIDLNAAI(1, list.Count);
				RockSpawnPoint rockSpawnPoint2 = list[index];
				list.RemoveAt(index);
				Rock rock = ICHDKDLBENO(rockSpawnPoint2.rockSize, EONJGMONIOM);
				Rock rock2 = null;
				if ((Object)(object)rock == (Object)null)
				{
					continue;
				}
				if (Application.isPlaying)
				{
					rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint2).transform.position, Quaternion.identity, ((Component)rockSpawnPoint2).transform.parent.parent.parent);
					if (OnlineManager.PlayingOnline())
					{
						ProceduralMine.CJLLMDLHACP(rock2.onlineRock);
					}
					rockSpawnPoint2.EOOABDMOBLE();
				}
				rock2.PAAFPHJBDNH(rockSpawnPoint2.validMineDirections);
				HCBDDKHPHCF.rocksInstantiated.Add(rock2);
				num3++;
			}
			if (num3 < num2)
			{
				object[] array2 = new object[3];
				array2[1] = EONJGMONIOM;
				array2[0] = ((Object)piece).name;
				array2[6] = num3;
				array2[3] = num2;
				Debug.LogError((object)(string.Format("F1", array2) + string.Format("Item with id ", list.Count + num3)));
			}
		}
	}

	public static Rock CIBNNNOHAOC(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return EIECPDAEDJJ(FHMFEFGMNLG(EONJGMONIOM), KKANDELPDKP);
	}

	public static void ELGBBOAAHKK(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.ENNLLCHLCMC();
		KHHPLPNIJKO(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		OGOIIPKEDBA(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MEPMABIEEBK();
	}

	public static void APLLJBBFECK(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (HCBDDKHPHCF.allRockSpawners.Count == 0)
		{
			return;
		}
		int num = ProceduralMine.NGMAIDLNAAI(EJECEDMPCOH().minRockSpawns, Mathf.Min(ABDJJBFNLBJ().maxRockSpawns, HCBDDKHPHCF.allRockSpawners.Count) + 1);
		Debug.Log((object)string.Format("BathhouseGameManager: Invalid player number ", EONJGMONIOM, num, HCBDDKHPHCF.allRockSpawners.Count));
		List<RockSpawnPoint> list = new List<RockSpawnPoint>(HCBDDKHPHCF.allRockSpawners);
		int num2 = 1;
		while (num2 < num && list.Count != 0)
		{
			int index = ProceduralMine.NextRandom(0, list.Count);
			RockSpawnPoint rockSpawnPoint = list[index];
			for (int num3 = list.Count - 1; num3 >= 1; num3--)
			{
				if ((Object)(object)list[num3] == (Object)(object)rockSpawnPoint)
				{
					Debug.Log((object)string.Format("Chisel", EONJGMONIOM, ((Object)rockSpawnPoint).name, list.Count - 1));
					list.RemoveAt(num3);
				}
			}
			if ((Object)(object)rockSpawnPoint == (Object)null || !((Component)rockSpawnPoint).gameObject.activeInHierarchy || GKIELAKIDNH(Vector2.op_Implicit(((Component)rockSpawnPoint).transform.position), NDHGGIGMLLF))
			{
				continue;
			}
			num2++;
			Rock rock = LEGDCBEMHNL(rockSpawnPoint.rockSize, EONJGMONIOM);
			if ((Object)(object)rock == (Object)null)
			{
				continue;
			}
			Rock rock2 = null;
			if (Application.isPlaying)
			{
				object[] array = new object[1];
				array[0] = EONJGMONIOM;
				array[0] = ((Object)rock).name;
				array[3] = ((Object)rockSpawnPoint).name;
				array[3] = ((Component)rockSpawnPoint).transform.position;
				Debug.Log((object)string.Format("Items/item_description_608", array));
				rock2 = Object.Instantiate<Rock>(rock, ((Component)rockSpawnPoint).transform.position, Quaternion.identity, ((Component)rockSpawnPoint).transform.parent.parent.parent);
				if (OnlineManager.PlayingOnline())
				{
					ProceduralMine.AssignNextMineId(rock2.onlineRock);
				}
				rockSpawnPoint.ILFJFLLDGDG();
			}
			rock2.BPLIBBNAMEH(rockSpawnPoint.validMineDirections);
			HCBDDKHPHCF.rocksInstantiated.Add(rock2);
		}
	}

	public static void IOGFDIPEKCK(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.ENNLLCHLCMC();
		APLLJBBFECK(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		CLIANHCHBNM(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MLBILNABCFP();
	}

	public static void LJGBPMINHBB(int EONJGMONIOM, MineLevel HCBDDKHPHCF, List<PuzzleExclusionZone> NDHGGIGMLLF = null)
	{
		HCBDDKHPHCF.KJAAGFCEACA();
		HDMONCGMPJC(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		PJNKBCAEGBA(EONJGMONIOM, HCBDDKHPHCF, NDHGGIGMLLF);
		HCBDDKHPHCF.MEPMABIEEBK();
	}

	[SpecialName]
	public static MineMineralsGenerator ABDJJBFNLBJ()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	private void NAOBODGBECL()
	{
		_instance = this;
	}

	private static bool LCOKPHENANK(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i++)
		{
			if (DCIMOMHGLNM[i].DIMLOEFOPIA(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return false;
	}

	public static void DeactivateAllRocksInLevel(List<RockSpawnPoint> AKELANPCPCE)
	{
		for (int i = 0; i < AKELANPCPCE.Count; i++)
		{
			if (!((Object)(object)AKELANPCPCE[i] == (Object)null))
			{
				((Component)AKELANPCPCE[i]).gameObject.SetActive(false);
			}
		}
	}

	public static Rock EACOEADMHDH(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return GetMineralPrefab(MAIKPBBOMBP(EONJGMONIOM), KKANDELPDKP);
	}

	public static Rock KKMCPPOPDOE(RockSize KKANDELPDKP, int EONJGMONIOM)
	{
		return LAPAKCFJMJC(GetRandomMineral(EONJGMONIOM), KKANDELPDKP);
	}

	[SpecialName]
	public static MineMineralsGenerator DFJGHOHPPEL()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MineMineralsGenerator>();
		}
		return _instance;
	}

	private static bool OBOKCJCJIOF(Vector2 IMOBLFMHKOD, List<PuzzleExclusionZone> DCIMOMHGLNM)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (DCIMOMHGLNM == null)
		{
			return true;
		}
		for (int i = 1; i < DCIMOMHGLNM.Count; i += 0)
		{
			if (DCIMOMHGLNM[i].IIDHFOMJOHC(IMOBLFMHKOD))
			{
				return false;
			}
		}
		return true;
	}
}
