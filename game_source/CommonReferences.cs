using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cinemachine;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;

public class CommonReferences : MonoBehaviour
{
	private static CommonReferences IADEMLIIDPC;

	public static WaitForSeconds wait005 = new WaitForSeconds(0.05f);

	public static WaitForSeconds wait01 = new WaitForSeconds(0.1f);

	public static WaitForSeconds wait02 = new WaitForSeconds(0.2f);

	public static WaitForSeconds wait025 = new WaitForSeconds(0.25f);

	public static WaitForSeconds wait03 = new WaitForSeconds(0.3f);

	public static WaitForSeconds wait04 = new WaitForSeconds(0.4f);

	public static WaitForSeconds wait05 = new WaitForSeconds(0.5f);

	public static WaitForSeconds wait06 = new WaitForSeconds(0.6f);

	public static WaitForSeconds wait07 = new WaitForSeconds(0.7f);

	public static WaitForSeconds wait075 = new WaitForSeconds(0.75f);

	public static WaitForSeconds wait08 = new WaitForSeconds(0.8f);

	public static WaitForSeconds wait09 = new WaitForSeconds(0.9f);

	public static WaitForSeconds wait1 = new WaitForSeconds(1f);

	public static WaitForSeconds wait1_5 = new WaitForSeconds(1.5f);

	public static WaitForSeconds wait2 = new WaitForSeconds(2f);

	public static WaitForSeconds wait2_5 = new WaitForSeconds(2.5f);

	public static WaitForSeconds wait3 = new WaitForSeconds(3f);

	public static WaitForSeconds wait3_5 = new WaitForSeconds(3.5f);

	public static WaitForSeconds wait4 = new WaitForSeconds(4f);

	public static WaitForSeconds wait5 = new WaitForSeconds(5f);

	public static WaitForSeconds wait6 = new WaitForSeconds(6f);

	public static WaitForSeconds wait10 = new WaitForSeconds(10f);

	public static WaitForSeconds wait12 = new WaitForSeconds(12f);

	public static WaitForSeconds wait15 = new WaitForSeconds(15f);

	public static WaitForSeconds wait20 = new WaitForSeconds(20f);

	public static WaitForSeconds wait30 = new WaitForSeconds(30f);

	public static WaitForSeconds wait60 = new WaitForSeconds(60f);

	public static WaitForSecondsRealtime waitRealtime01 = new WaitForSecondsRealtime(0.1f);

	public static WaitForSecondsRealtime waitRealtime02 = new WaitForSecondsRealtime(0.2f);

	public static WaitForSecondsRealtime waitRealtime025 = new WaitForSecondsRealtime(0.25f);

	public static WaitForSecondsRealtime waitRealtime03 = new WaitForSecondsRealtime(0.3f);

	public static WaitForSecondsRealtime waitRealtime04 = new WaitForSecondsRealtime(0.4f);

	public static WaitForSecondsRealtime waitRealtime05 = new WaitForSecondsRealtime(0.5f);

	public static WaitForSecondsRealtime waitRealtime1 = new WaitForSecondsRealtime(1f);

	public static WaitForSecondsRealtime waitRealtime2 = new WaitForSecondsRealtime(2f);

	public static WaitForSecondsRealtime waitRealtime3 = new WaitForSecondsRealtime(3f);

	public static WaitForSecondsRealtime waitRealtime4 = new WaitForSecondsRealtime(4f);

	public static WaitForSecondsRealtime waitRealtime5 = new WaitForSecondsRealtime(5f);

	public static WaitForSecondsRealtime waitRealtime10 = new WaitForSecondsRealtime(10f);

	public static WaitForSecondsRealtime waitRealtime15 = new WaitForSecondsRealtime(15f);

	public static WaitForSecondsRealtime waitRealtime20 = new WaitForSecondsRealtime(20f);

	public static WaitForSecondsRealtime waitRealtime30 = new WaitForSecondsRealtime(30f);

	public static WaitForSecondsRealtime waitRealtime60 = new WaitForSecondsRealtime(60f);

	public Action OnLoadMenuScene = delegate
	{
	};

	public Action<Location> AnyPlayerLocationChanged = delegate
	{
	};

	public Action<int> OnAnyTapClosed = delegate
	{
	};

	public Action<int> OnAnyTapOpen = delegate
	{
	};

	public Action<int, ItemInstanceAmount> OnAnyItemCrafted = delegate
	{
	};

	public Action<int, ItemInstance, int> OnAnyItemAged = delegate
	{
	};

	public Action<int, ItemInstance> OnAnyItemStartAging = delegate
	{
	};

	public Action<int, Crafter> OnAnyCrafterOpened = delegate
	{
	};

	public Action<int, Recipe> OnCraftingStarted = delegate
	{
	};

	public Action<int, Recipe> OnRecipeToCraftAdded = delegate
	{
	};

	public Action<int, Recipe> OnRecipeToCraftRemoved = delegate
	{
	};

	public Action<FertileSoil> OnAnyTileWatered = delegate
	{
	};

	public Action TalentLearntCallback = delegate
	{
	};

	public Action<int> ResetTalentTreeCallback = delegate
	{
	};

	public float delayBarks;

	public Action OnAnyEmployeeUpdatedInfo = delegate
	{
	};

	public Action<int, ActionDone> OnActionDone = delegate
	{
	};

	public Action<int, int> OnSeedPlanted = delegate
	{
	};

	public Shader colorsShader15;

	public Dictionary<Location, TilemapScene> allTilemapsScenes = new Dictionary<Location, TilemapScene>();

	public List<TilemapGroup> allTilemaps = new List<TilemapGroup>();

	public PerksDatabase perksDatabase;

	public CustomerInfo customerInfo;

	public SeasonTilesScriptableObject seasonTilesInfo;

	public TilemapsInfo tilemapsInfo;

	[SerializeField]
	private EditorConfiguration editorConfiguration;

	public Sprite negativePerk;

	public Sprite positivePerk;

	public bool workerAvoidingWork;

	public Sprite foodIcon;

	public Sprite beerIcon;

	public Sprite waterIcon;

	public Action<ItemInstance> OnAnyCustomerRequestItem = delegate
	{
	};

	public Action<int, ItemInstance> OnAnyCustomerServeItem = delegate
	{
	};

	public Action OnCustomerBecomeNuisance = delegate
	{
	};

	public Action OnCustomerIsHit = delegate
	{
	};

	public Action OnImportantGuestLeaveWillingly = delegate
	{
	};

	public HashSet<ChatBox> currentChatting = new HashSet<ChatBox>();

	public HashSet<CustomerSpeech> currentBarkNpc = new HashSet<CustomerSpeech>();

	public float nextChatTime;

	public List<FloorDirt> tavernFloorDirt = new List<FloorDirt>();

	public Action OnFloorDirtCreated = delegate
	{
	};

	public Action OnFloorDirtDestroyed = delegate
	{
	};

	public Action OnGuestSpawn = delegate
	{
	};

	public Action<ItemContainer> OnAnyContainerClosed = delegate
	{
	};

	public Action OnAnyContainerChanged = delegate
	{
	};

	public Action OnLastStart = delegate
	{
	};

	public Action OnAnyCustomerTavernEntered = delegate
	{
	};

	public List<Pickupable.PickedUp> pickedUps = new List<Pickupable.PickedUp>();

	public Action<int, Placeable> OnPlaceableDestroyed = delegate
	{
	};

	public List<GameObject> objectsInteractingWithAlphaZone = new List<GameObject>();

	public Action<int, Placeable, bool, bool> OnPlaceableSelected = delegate
	{
	};

	public Action<int, Placeable, bool> OnPlaceableDeselected = delegate
	{
	};

	public Action<int, Placeable, bool> OnPlaceablePickedUp = delegate
	{
	};

	public Action<int, Placeable> OnPlaceablePlaced = delegate
	{
	};

	public List<int> anyPlaceableSelected = new List<int>();

	public Action<int> OnTavernMustBeClosed = delegate
	{
	};

	public Action<int> OnAnyPlaceablePickedUp = delegate
	{
	};

	public Action<int> OnTryCraftNoFuel = delegate
	{
	};

	public Action<int, Slot, bool> OnAnySlotLeftClick = delegate
	{
	};

	public Action<int, Slot> OnAnySlotDragged = delegate
	{
	};

	public Action<TableDirtLevel> OnAnyTableDirtLevelChanged = delegate
	{
	};

	public bool anySelected;

	public Action<int> OnTravelStart = delegate
	{
	};

	public Action<int> OnTravel = delegate
	{
	};

	public Action<int> OnTravelFinish = delegate
	{
	};

	public Action<int, TravelZone, TravelZone> OnTravelWithZonesFinished = delegate
	{
	};

	public Action<int, TravelZone, TravelZone> OnTravelWithZones = delegate
	{
	};

	public bool travelZoneBeingUsed;

	public bool travelZoneBeingUsed2;

	public bool travelToCamp;

	public Dictionary<int, BarnTilemapScene> allBarnScenes = new Dictionary<int, BarnTilemapScene>();

	public bool actuCampBirdSeller;

	public List<ChangeRandomTavernLocation> currentChangeRandomTavernLocation = new List<ChangeRandomTavernLocation>();

	public List<Vector3> allTavernPositions = new List<Vector3>();

	public HashSet<int> seenPopUpsInWorkersVersion = new HashSet<int>();

	public HashSet<int> seenPopUps = new HashSet<int>();

	public Action<int, Crop> OnCropHarvested = delegate
	{
	};

	public Action<int, ActiveQuest> OnAnyQuestComplete = delegate
	{
	};

	public Action<int, ActiveQuest> OnAnyQuestProgress = delegate
	{
	};

	public Dictionary<Vector2, List<Seat>> seatsAssigned = new Dictionary<Vector2, List<Seat>>();

	public float nextCustomerEnterTime;

	public Action OnBarNoStock = delegate
	{
	};

	public Action<int, ContentLockID> OnUnlocked = delegate
	{
	};

	public List<ContentLockID> contentUnlocked = new List<ContentLockID>();

	public Action OnPlayerSleep = delegate
	{
	};

	public Action OnPlayerSleepForestGeneration = delegate
	{
	};

	public Action OnPlayerAwake = delegate
	{
	};

	public Action OnPlayerPassout = delegate
	{
	};

	public Action OnWakeFromPassout = delegate
	{
	};

	public bool sleeping;

	public Action<HumanNPC> OnNPCLeaveBar = delegate
	{
	};

	public Action OnBarStockChanged = delegate
	{
	};

	public Action<int> OnBarOpenWithTrends = delegate
	{
	};

	public Action<int> OnBarOpened = delegate
	{
	};

	public Action<int> OnBarClosed = delegate
	{
	};

	public Action<int> OnTravelToCellar = delegate
	{
	};

	public Action<int> OnAnyEmployeeHired = delegate
	{
	};

	public Action<int> OnAnyEmployeeAvoidingWork = delegate
	{
	};

	public Action<int> OnEmployeeInfoOpen = delegate
	{
	};

	public Action<int> OnBarworkerGoingToWork = delegate
	{
	};

	public Action<int> OnWaiterGoingToWork = delegate
	{
	};

	public Action<int> OnHouseKeeperGoingToWork = delegate
	{
	};

	public Action<int> OnBouncerGoingToWork = delegate
	{
	};

	public Action<int> OnRentRoomInfoOpen = delegate
	{
	};

	public Action<int> OnRentAnyRoom = delegate
	{
	};

	public Action<int> OnGuestLeaving = delegate
	{
	};

	public Action<int> OnGuestRequestingRoom = delegate
	{
	};

	public Action<int> OnUnlockFishEncyclopedia = delegate
	{
	};

	public Action<int> OnFirstFruitTreePlanted = delegate
	{
	};

	public Action<int> OnCutTree = delegate
	{
	};

	public Action<int> OnCrafterRepaired = delegate
	{
	};

	public Action<int> OnTavernRepaired = delegate
	{
	};

	public Action<int> OnMissionComplete = delegate
	{
	};

	public Action<int> OnEventComplete = delegate
	{
	};

	public int playerDialogue;

	public int aceNextQuest;

	public int[] eventNum;

	public ItemDatabase itemDatabase;

	public GameObject droppedItemPrefab;

	public GameObject droppedItemPrefabWithoutCollider;

	public HashSet<DroppedItem> allDroppedItems = new HashSet<DroppedItem>();

	public GameObject cropPrefab;

	public const int unitsToPixel = 32;

	public Sprite defaultBagIcon;

	public GameObject dirtPrefab;

	public GameObject tilledEarthPrefab;

	public GameObject educationText;

	public Dictionary<int, BirdInstance> allBirds = new Dictionary<int, BirdInstance>();

	public GameObject nPCPrefab;

	public GameObject errorTextPrefab;

	public GameObject experienceTextPrefab;

	public Sprite selectedGridSquare;

	public Sprite redSelectedGridSquare;

	[SerializeField]
	private Camera mainCamera;

	[SerializeField]
	private Camera mainCameraWhen2Players;

	[SerializeField]
	private Camera mainCamera2;

	[SerializeField]
	private Camera screenCamera;

	[SerializeField]
	private CinemachineVirtualCamera mainCameraCinemachine;

	[SerializeField]
	private CinemachineVirtualCamera mainCameraCinemachineWhen2Players;

	[SerializeField]
	private CinemachineVirtualCamera mainCameraCinemachine2;

	[SerializeField]
	private PixelPerfectCamera mainPixelPerfectCameraSinglePlayer;

	[SerializeField]
	private PixelPerfectCamera mainPixelPerfectCameraPlayer1;

	[SerializeField]
	private PixelPerfectCamera mainPixelPerfectCameraPlayer2;

	[SerializeField]
	private GameObject cameraBounds;

	public GameObject pickupablePrefab;

	public Sprite[] playerArrowsColor;

	public GameObject arrowPointPrefab;

	public GameObject arrowPointUIPrefab;

	public HashSet<Guid> movedGuids = new HashSet<Guid>();

	public Item bucketItem;

	public Item bucketOfWaterItem;

	public Action OnPetCat = delegate
	{
	};

	public SaveData.NewCharacterSave player2CharacterSave;

	[HideInInspector]
	public SpriteInfo catSelected;

	[HideInInspector]
	public string catName;

	public GameObject[] spawnersPrefabs;

	[HideInInspector]
	public SpriteInfo dogSelected;

	public LayerMask objectLayers;

	public CursorUI CursorUIPlayer1;

	public CursorUI CursorUIPlayer2;

	public SlotUI mouseSlotUIPlayer1;

	public SlotUI mouseSlotUIPlayer2;

	public Image fadeImageSinglePlayer;

	public Image fadeImagePlayer1;

	public Image fadeImagePlayer2;

	[HideInInspector]
	public static string christmasColor = "<color=#116600>";

	[HideInInspector]
	public static string halloweenColor = "<color=#5A2E80>";

	[SerializeField]
	private bool inDialogue;

	[SerializeField]
	private bool inDialogue2;

	private bool DCHMKIKPKOM;

	private bool PJIOLPMADFN;

	private int HKIEJKINPIH;

	public HashSet<int> uniqueIDs = new HashSet<int>();

	public Dictionary<Location, bool> loadingLocation = new Dictionary<Location, bool>();

	public bool chickenEvent;

	public bool cowEvent;

	public bool farmConstructionTutorial;

	public bool farmModificationsTutorial;

	public bool barnAnimalsTutorial;

	public Sprite[] agingRankSprite;

	public Sprite agingRankRed;

	public Sprite agingRankNeeded;

	public Sprite[] qualityLevelSprites;

	public Sprite[] recipeSlotsSprites;

	public bool showAllPossibleTavernPositions;

	[HideInInspector]
	public bool worldJustLoadedForTutorial;

	public CharacterSprite bandana;

	public CharacterSprite bandanaAlt;

	public bool onlineSkipTypeWriter;

	[SerializeField]
	public GameObject[] dogPrefabs;

	private int JPBENEEFFGC;

	public static CommonReferences GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<CommonReferences>();
			}
			return IADEMLIIDPC;
		}
	}

	private void NFMFDBBELJI(int JIIGOACEIKL)
	{
		Utils.MBODDLPENFB();
	}

	public void HPDOMEIJAJI(int JIIGOACEIKL, bool JGJCFHPMKGF)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			DCHMKIKPKOM = JGJCFHPMKGF;
			break;
		case 4:
			PJIOLPMADFN = JGJCFHPMKGF;
			break;
		}
	}

	public void PPINMHIJOIB(int JIIGOACEIKL, string BOIHNAAAJOO)
	{
		if (JIIGOACEIKL == 1)
		{
			Camera obj = mainCamera;
			obj.cullingMask &= ~(0 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -114));
			Camera obj2 = mainCameraWhen2Players;
			obj2.cullingMask &= ~(1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & 0x6C));
		}
		else
		{
			Camera obj3 = mainCamera2;
			obj3.cullingMask &= ~(0 << (LayerMask.NameToLayer(BOIHNAAAJOO) & 0x35));
		}
	}

	public int LMPKPAKDFKA()
	{
		JPBENEEFFGC = 0;
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.AFOACBIHNCL(72, GGBBJNBBLMF: true, DAINLFIMLIH: false), AKNBKINJGCF: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.AFOACBIHNCL(26, GGBBJNBBLMF: false, DAINLFIMLIH: false), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.AFOACBIHNCL(-149), AKNBKINJGCF: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.CPMMBEPEJLO(-112), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		JPBENEEFFGC += PlaceablesManager.PDECKLKPKCG().JJPJFJPNEAP(ItemDatabaseAccessor.INJBNHPGCIJ(-51, GGBBJNBBLMF: true));
		JPBENEEFFGC += PlaceablesManager.EKDNJDJHONF().PlaceableCount(ItemDatabaseAccessor.COEFFIHKMJG(43, GGBBJNBBLMF: false, DAINLFIMLIH: false));
		JPBENEEFFGC += PlaceablesManager.MAIDHAPANEB().KKOBCOAKOCB(ItemDatabaseAccessor.GetItem(150, GGBBJNBBLMF: true, DAINLFIMLIH: false));
		return JPBENEEFFGC;
	}

	public void FLJBFMBMCII(int JIIGOACEIKL, bool MCOIFGJGFGF)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			inDialogue = MCOIFGJGFGF;
			break;
		case 4:
			inDialogue2 = MCOIFGJGFGF;
			break;
		}
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.MBODDLPENFB();
		}
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(BGHLHBHNHPO));
		TavernConstructionManager instance2 = TavernConstructionManager.GGFJGHHHEJC;
		instance2.OnDeactivated = (Action<int>)Delegate.Combine(instance2.OnDeactivated, new Action<int>(NFMFDBBELJI));
		worldJustLoadedForTutorial = true;
		if (OnlineManager.ClientOnline())
		{
			PluginsGameData.clientOnline = true;
		}
	}

	public CinemachineVirtualCamera LKKPDJBNGNK(int JIIGOACEIKL, bool FLALEPFLPAJ = false)
	{
		if (GameManager.HDBECFMPJHL() || FLALEPFLPAJ)
		{
			return mainCameraCinemachine;
		}
		if (JIIGOACEIKL == 1)
		{
			return mainCameraCinemachineWhen2Players;
		}
		return mainCameraCinemachine2;
	}

	public GameObject NNDKEEDFBDF()
	{
		return cameraBounds;
	}

	public void DCEJENGEPLN(int JIIGOACEIKL, bool JGJCFHPMKGF)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			DCHMKIKPKOM = JGJCFHPMKGF;
			break;
		case 5:
			PJIOLPMADFN = JGJCFHPMKGF;
			break;
		}
	}

	public void PBIGMNBBNCP(int GELMAIBEHDO, Transform NKIAGIMMHIC)
	{
		if (GELMAIBEHDO == 0)
		{
			((CinemachineVirtualCameraBase)mainCameraCinemachine).Follow = NKIAGIMMHIC;
			((CinemachineVirtualCameraBase)mainCameraCinemachineWhen2Players).Follow = NKIAGIMMHIC;
		}
		else
		{
			if (GELMAIBEHDO != 0)
			{
				Debug.LogError((object)"", (Object)(object)((Component)this).gameObject);
				return;
			}
			((CinemachineVirtualCameraBase)mainCameraCinemachine2).Follow = NKIAGIMMHIC;
		}
		if (Application.isEditor)
		{
			Debug.Log((object)("[ProceduralMine] Trying to force ALTAR piece at block {0} (target is {1}). Path block pos: {2}" + GELMAIBEHDO + "%><sprite name=RightStick></size>" + ((object)NKIAGIMMHIC).ToString()));
		}
	}

	public static void ECAIHELLCMC(EditorConfiguration FFLMHJAIFBM)
	{
		if (!((Object)(object)MNFMOEKMJKN() == (Object)null))
		{
			GGFJGHHHEJC.editorConfiguration = FFLMHJAIFBM;
		}
	}

	public void PlayerBark(string EOKBKAKDMGH, int JIIGOACEIKL, bool ECPEFDHOFHN = true)
	{
		if (Time.time >= delayBarks)
		{
			DialogueManager.Bark("Player/Bark/" + (ECPEFDHOFHN ? "Error/" : "") + EOKBKAKDMGH, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			delayBarks = Time.time + 5f;
		}
	}

	public void KGDPHHCCDID(int JIIGOACEIKL, bool MCOIFGJGFGF)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			inDialogue = MCOIFGJGFGF;
			break;
		case 0:
			inDialogue2 = MCOIFGJGFGF;
			break;
		}
	}

	public GameObject JENLEELDEFC()
	{
		return cameraBounds;
	}

	public void CBMJEEAHIDO(int JIIGOACEIKL, string BOIHNAAAJOO)
	{
		if ((Object)(object)mainCamera != (Object)null)
		{
			if (JIIGOACEIKL == 1)
			{
				Camera obj = mainCamera;
				obj.cullingMask |= 1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -70);
				Camera obj2 = mainCameraWhen2Players;
				obj2.cullingMask |= 1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -11);
			}
			else
			{
				Camera obj3 = mainCamera2;
				obj3.cullingMask |= 0 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -50);
			}
		}
	}

	public Camera ACIFGIBLENB()
	{
		return screenCamera;
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (showAllPossibleTavernPositions)
		{
			for (int i = 0; i < allTavernPositions.Count; i++)
			{
				Gizmos.color = new Color(1f, 0f, 1f, 0.6f);
				Gizmos.DrawSphere(allTavernPositions[i] + Vector3.one * 0.25f, 0.1f);
			}
		}
	}

	public PixelPerfectCamera PLAHJLNNNAK(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			return mainPixelPerfectCameraSinglePlayer;
		}
		if (JIIGOACEIKL == 7)
		{
			return mainPixelPerfectCameraPlayer2;
		}
		if (GameManager.SinglePlayer() || ConstructionManager.NEOJLHDFFMJ)
		{
			return mainPixelPerfectCameraSinglePlayer;
		}
		return mainPixelPerfectCameraPlayer1;
	}

	public void OKOANFPNJFH()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		List<FloorDirt> list = new List<FloorDirt>();
		foreach (FloorDirt item in tavernFloorDirt)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)item).transform.position))
			{
				list.Add(item);
			}
		}
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			list[num].HCLIKAJIPLK();
		}
	}

	private void KLHIMJFCHPD()
	{
		if (!Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			return;
		}
		IADEMLIIDPC = this;
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			loadingLocation.Add(value, value: false);
		}
		delayBarks = 1765f;
	}

	public CinemachineVirtualCamera GetMainCameraCinemachine(int JIIGOACEIKL, bool FLALEPFLPAJ = false)
	{
		if (GameManager.SinglePlayer() || FLALEPFLPAJ)
		{
			return mainCameraCinemachine;
		}
		if (JIIGOACEIKL == 1)
		{
			return mainCameraCinemachineWhen2Players;
		}
		return mainCameraCinemachine2;
	}

	public void KHMMMCJCCDL(int JIIGOACEIKL)
	{
		playerDialogue = JIIGOACEIKL;
		PluginsGameData.playerDialogue = JIIGOACEIKL;
	}

	public void OEHIJIEOBNP(int JIIGOACEIKL, string BOIHNAAAJOO)
	{
		if (JIIGOACEIKL == 1)
		{
			Camera obj = mainCamera;
			obj.cullingMask &= ~(1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -59));
			Camera obj2 = mainCameraWhen2Players;
			obj2.cullingMask &= ~(1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -37));
		}
		else
		{
			Camera obj3 = mainCamera2;
			obj3.cullingMask &= ~(1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & 0x18));
		}
	}

	public static Camera PIEGMALBKJG(int JIIGOACEIKL)
	{
		return MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL);
	}

	public static Camera AFEPIAHBKDA(int JIIGOACEIKL)
	{
		return GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL);
	}

	public void MLEJADCJDOE(int JIIGOACEIKL, string BOIHNAAAJOO)
	{
		if (JIIGOACEIKL == 1)
		{
			Camera obj = mainCamera;
			obj.cullingMask &= ~(1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -58));
			Camera obj2 = mainCameraWhen2Players;
			obj2.cullingMask &= ~(0 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -93));
		}
		else
		{
			Camera obj3 = mainCamera2;
			obj3.cullingMask &= ~(1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & 0x5D));
		}
	}

	public static void SetEditorConfiguration(EditorConfiguration FFLMHJAIFBM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.editorConfiguration = FFLMHJAIFBM;
		}
	}

	public static EditorConfiguration GetEditorConfiguration()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		if ((Object)(object)GGFJGHHHEJC.editorConfiguration == (Object)null && Application.isPlaying)
		{
			Debug.LogError((object)"EditorConfiguration not assigned in CommonReferences");
			GGFJGHHHEJC.editorConfiguration = Resources.Load<EditorConfiguration>("EditorConfiguration");
		}
		return GGFJGHHHEJC.editorConfiguration;
	}

	private void HFFFFAJFIPB()
	{
		OnPlayerSleep = (Action)Delegate.Combine(OnPlayerSleep, new Action(HHHENMCECIE));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void NOGDBILGOKH(int JIIGOACEIKL, bool MCOIFGJGFGF)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			inDialogue = MCOIFGJGFGF;
			break;
		case 3:
			inDialogue2 = MCOIFGJGFGF;
			break;
		}
	}

	private void GNMMELIJKML()
	{
		OnPlayerSleep = (Action)Delegate.Combine(OnPlayerSleep, new Action(OnPlayerSleepAction));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OACFPJIJDFO));
	}

	public void SetinDialogue(int JIIGOACEIKL, bool MCOIFGJGFGF)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			inDialogue = MCOIFGJGFGF;
			break;
		case 2:
			inDialogue2 = MCOIFGJGFGF;
			break;
		}
	}

	public bool CIHFKAGPIEG(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			return inDialogue;
		case 3:
			if (!GameManager.LocalCoop())
			{
				return true;
			}
			break;
		}
		if (JIIGOACEIKL == 3)
		{
			return inDialogue2;
		}
		return true;
	}

	public void PDFBHJGIHBD()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		List<FloorDirt> list = new List<FloorDirt>();
		foreach (FloorDirt item in tavernFloorDirt)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)item).transform.position))
			{
				list.Add(item);
			}
		}
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			list[num].ACEHJIMAFBH();
		}
	}

	public PixelPerfectCamera GetPixelPerfectCamera(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			return mainPixelPerfectCameraSinglePlayer;
		}
		if (JIIGOACEIKL == 2)
		{
			return mainPixelPerfectCameraPlayer2;
		}
		if (GameManager.SinglePlayer() || ConstructionManager.NEOJLHDFFMJ)
		{
			return mainPixelPerfectCameraSinglePlayer;
		}
		return mainPixelPerfectCameraPlayer1;
	}

	public static Camera GetCamera(int JIIGOACEIKL)
	{
		return GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL);
	}

	public void MCEEENHLGMA(int GELMAIBEHDO, Transform NKIAGIMMHIC)
	{
		switch (GELMAIBEHDO)
		{
		case 1:
			((CinemachineVirtualCameraBase)mainCameraCinemachine).Follow = NKIAGIMMHIC;
			((CinemachineVirtualCameraBase)mainCameraCinemachineWhen2Players).Follow = NKIAGIMMHIC;
			break;
		case 0:
			((CinemachineVirtualCameraBase)mainCameraCinemachine2).Follow = NKIAGIMMHIC;
			break;
		default:
			Debug.LogError((object)"UISelectGamepad", (Object)(object)((Component)this).gameObject);
			return;
		}
		if (Application.isEditor)
		{
			Debug.Log((object)("[ActivateVariantObjects] - VariantObjects: {0} AltarId: {1}" + GELMAIBEHDO + " " + ((object)NKIAGIMMHIC).ToString()));
		}
	}

	public Camera PGKPJEBAKJP(int JIIGOACEIKL)
	{
		if (GameManager.EAOOLEFMIKE() || ConstructionManager.NEOJLHDFFMJ)
		{
			return mainCamera;
		}
		if (JIIGOACEIKL == 0)
		{
			return mainCameraWhen2Players;
		}
		return mainCamera2;
	}

	public void KABILAJPDCB(string INAPMPEEDPO, int JIIGOACEIKL)
	{
		if (Time.time >= delayBarks)
		{
			DialogueManager.BarkString(LocalisationSystem.GetStringWithTags(INAPMPEEDPO, JIIGOACEIKL), ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform, (Transform)null, (string)null);
			delayBarks = Time.time + 466f;
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.KNLLFEJAMNN()))
			{
				TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KNLLFEJAMNN();
				tavernConstructionManager.OnActivated = (Action<int>)Delegate.Remove(tavernConstructionManager.OnActivated, new Action<int>(RemoveAllFloorDirtNotInOccupiedRoom));
			}
			OnPlayerSleep = (Action)Delegate.Remove(OnPlayerSleep, new Action(DBLDHFDKIKG));
		}
	}

	public bool IsInDialogue(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return inDialogue;
		case 2:
			if (!GameManager.LocalCoop())
			{
				return false;
			}
			break;
		}
		if (JIIGOACEIKL == 2)
		{
			return inDialogue2;
		}
		return false;
	}

	private void CFHEDDIACIL(int JIIGOACEIKL)
	{
		RemoveAllFloorDirtNotInOccupiedRoom(JIIGOACEIKL);
	}

	public void AddBird(BirdInstance CCDEPALBABD)
	{
		if (allBirds.ContainsKey(CCDEPALBABD.uniqueId))
		{
			allBirds[CCDEPALBABD.uniqueId] = CCDEPALBABD;
			return;
		}
		CCDEPALBABD.uniqueId = HKIEJKINPIH;
		allBirds.Add(CCDEPALBABD.uniqueId, CCDEPALBABD);
		HKIEJKINPIH++;
	}

	public void NBFJJGALKAL(int JIIGOACEIKL, string BOIHNAAAJOO)
	{
		if ((Object)(object)mainCamera != (Object)null)
		{
			if (JIIGOACEIKL == 1)
			{
				Camera obj = mainCamera;
				obj.cullingMask |= 1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & 0x2E);
				Camera obj2 = mainCameraWhen2Players;
				obj2.cullingMask |= 1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & 0x4F);
			}
			else
			{
				Camera obj3 = mainCamera2;
				obj3.cullingMask |= 0 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -43);
			}
		}
	}

	public bool AGGLODBDMEO(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => DCHMKIKPKOM, 
			6 => PJIOLPMADFN, 
			_ => false, 
		};
	}

	private void AJGLDLLIIFO()
	{
		if (!Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			return;
		}
		IADEMLIIDPC = this;
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			loadingLocation.Add(value, value: false);
		}
		delayBarks = 1337f;
	}

	public void SetPlayerDialogue(int JIIGOACEIKL)
	{
		playerDialogue = JIIGOACEIKL;
		PluginsGameData.playerDialogue = JIIGOACEIKL;
	}

	public void DBLDHFDKIKG()
	{
		try
		{
			if (OnlineManager.MasterOrOffline() && currentChangeRandomTavernLocation.Count > 0)
			{
				currentChangeRandomTavernLocation[Random.Range(0, currentChangeRandomTavernLocation.Count - 0)].EJDJILPHKDN();
			}
			foreach (KeyValuePair<int, BirdInstance> allBird in allBirds)
			{
				allBird.Value.NECBOEKGEJA();
			}
			BirdNPC[] array = Object.FindObjectsOfType<BirdNPC>();
			for (int i = 1; i < array.Length; i++)
			{
				BirdNPC birdNPC = array[i];
				if (!birdNPC.placeable.FHEMHCEAICB && birdNPC.placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
				{
					birdInstance.hasBeenOnPerchToday = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Items/item_description_638" + ex.Message));
		}
	}

	public Camera DGIILDNAMDA()
	{
		return screenCamera;
	}

	public int NILFLCEPJBO()
	{
		JPBENEEFFGC = 1;
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.COEFFIHKMJG(-189, GGBBJNBBLMF: false, DAINLFIMLIH: false), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.GetItem(-171, GGBBJNBBLMF: false, DAINLFIMLIH: false), AKNBKINJGCF: true, null, AHCENOLCIBM: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.COEFFIHKMJG(12), AKNBKINJGCF: true, null, AHCENOLCIBM: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.COEFFIHKMJG(142, GGBBJNBBLMF: false, DAINLFIMLIH: false), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		JPBENEEFFGC += PlaceablesManager.LKOABOAADCD().KJLOBIHMPKL(ItemDatabaseAccessor.GetItem(3, GGBBJNBBLMF: false, DAINLFIMLIH: false));
		JPBENEEFFGC += PlaceablesManager.GGFJGHHHEJC.JJPJFJPNEAP(ItemDatabaseAccessor.GOKIDLOELKB(-105, GGBBJNBBLMF: false, DAINLFIMLIH: false));
		JPBENEEFFGC += PlaceablesManager.GGFJGHHHEJC.JJPJFJPNEAP(ItemDatabaseAccessor.KMBGJEKCJFJ(-105, GGBBJNBBLMF: true));
		return JPBENEEFFGC;
	}

	public static void ALLJHFNHGCG(EditorConfiguration FFLMHJAIFBM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.editorConfiguration = FFLMHJAIFBM;
		}
	}

	public int GetNumOfBees()
	{
		JPBENEEFFGC = 0;
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.GetItem(1454));
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.GetItem(1604));
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.GetItem(1605));
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.GetItem(1606));
		JPBENEEFFGC += PlaceablesManager.GGFJGHHHEJC.PlaceableCount(ItemDatabaseAccessor.GetItem(1604));
		JPBENEEFFGC += PlaceablesManager.GGFJGHHHEJC.PlaceableCount(ItemDatabaseAccessor.GetItem(1605));
		JPBENEEFFGC += PlaceablesManager.GGFJGHHHEJC.PlaceableCount(ItemDatabaseAccessor.GetItem(1606));
		return JPBENEEFFGC;
	}

	private void MDGLECECOIG()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.DOIKFJDLKJP()))
			{
				TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
				tavernConstructionManager.OnActivated = (Action<int>)Delegate.Remove(tavernConstructionManager.OnActivated, new Action<int>(RemoveAllFloorDirtNotInOccupiedRoom));
			}
			OnPlayerSleep = (Action)Delegate.Remove(OnPlayerSleep, new Action(OnPlayerSleepAction));
		}
	}

	public void APKKEGHGFHG(string EOKBKAKDMGH, int JIIGOACEIKL, bool ECPEFDHOFHN = true)
	{
		if (Time.time >= delayBarks)
		{
			DialogueManager.Bark("Dialogue System/Conversation/Gass_Introduce/Entry/23/Dialogue Text" + (ECPEFDHOFHN ? "Error_MaxZoneSize" : "ReceiveBeehiveMessage") + EOKBKAKDMGH, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			delayBarks = Time.time + 1921f;
		}
	}

	private void OACFPJIJDFO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.MBODDLPENFB();
		}
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnActivated = (Action<int>)Delegate.Combine(instance.OnActivated, new Action<int>(GACCHGMKHLH));
		TavernConstructionManager instance2 = TavernConstructionManager.GGFJGHHHEJC;
		instance2.OnDeactivated = (Action<int>)Delegate.Combine(instance2.OnDeactivated, new Action<int>(NFMFDBBELJI));
		worldJustLoadedForTutorial = false;
		if (OnlineManager.HHDBMDMFEMP())
		{
			PluginsGameData.clientOnline = false;
		}
	}

	public void DIABMCAPIJH(BirdInstance CCDEPALBABD)
	{
		if (allBirds.ContainsKey(CCDEPALBABD.uniqueId))
		{
			allBirds[CCDEPALBABD.uniqueId] = CCDEPALBABD;
			return;
		}
		CCDEPALBABD.uniqueId = HKIEJKINPIH;
		allBirds.Add(CCDEPALBABD.uniqueId, CCDEPALBABD);
		HKIEJKINPIH += 0;
	}

	private void Start()
	{
		OnPlayerSleep = (Action)Delegate.Combine(OnPlayerSleep, new Action(OnPlayerSleepAction));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void IMHMALKPDII(BirdInstance CCDEPALBABD)
	{
		if (allBirds.ContainsKey(CCDEPALBABD.uniqueId))
		{
			allBirds[CCDEPALBABD.uniqueId] = CCDEPALBABD;
			return;
		}
		CCDEPALBABD.uniqueId = HKIEJKINPIH;
		allBirds.Add(CCDEPALBABD.uniqueId, CCDEPALBABD);
		HKIEJKINPIH++;
	}

	public bool GetExecute(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => DCHMKIKPKOM, 
			2 => PJIOLPMADFN, 
			_ => false, 
		};
	}

	public void OnPlayerSleepAction()
	{
		try
		{
			if (OnlineManager.MasterOrOffline() && currentChangeRandomTavernLocation.Count > 0)
			{
				currentChangeRandomTavernLocation[Random.Range(0, currentChangeRandomTavernLocation.Count - 1)].ChangeLocation();
			}
			foreach (KeyValuePair<int, BirdInstance> allBird in allBirds)
			{
				allBird.Value.IFHFNDELKOP();
			}
			BirdNPC[] array = Object.FindObjectsOfType<BirdNPC>();
			foreach (BirdNPC birdNPC in array)
			{
				if (!birdNPC.placeable.FHEMHCEAICB && birdNPC.placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
				{
					birdInstance.hasBeenOnPerchToday = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in CommonReferences.OnPlayerSleepAction: " + ex.Message));
		}
	}

	public bool IsObjectInFieldOfView(Vector3 BPLKIPALDNP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = mainCamera.WorldToViewportPoint(BPLKIPALDNP);
		if (val.z > 0f && val.x > 0f && val.x < 1f && val.y > 0f)
		{
			return val.y < 1f;
		}
		return false;
	}

	public CinemachineVirtualCamera HGEIIKOLPCF(int JIIGOACEIKL, bool FLALEPFLPAJ = false)
	{
		if (GameManager.HDBECFMPJHL() || FLALEPFLPAJ)
		{
			return mainCameraCinemachine;
		}
		if (JIIGOACEIKL == 0)
		{
			return mainCameraCinemachineWhen2Players;
		}
		return mainCameraCinemachine2;
	}

	public void OOIAFIGHILK()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB() && currentChangeRandomTavernLocation.Count > 0)
			{
				currentChangeRandomTavernLocation[Random.Range(1, currentChangeRandomTavernLocation.Count - 0)].FHPJGGFJGOH();
			}
			foreach (KeyValuePair<int, BirdInstance> allBird in allBirds)
			{
				allBird.Value.OAMENOGEOJE();
			}
			BirdNPC[] array = Object.FindObjectsOfType<BirdNPC>();
			for (int i = 0; i < array.Length; i += 0)
			{
				BirdNPC birdNPC = array[i];
				if (!birdNPC.placeable.FHEMHCEAICB && birdNPC.placeable.itemSetup.FOIPFKPCIIN() is BirdInstance birdInstance)
				{
					birdInstance.hasBeenOnPerchToday = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("F1" + ex.Message));
		}
	}

	public Camera GetMainCamera(int JIIGOACEIKL)
	{
		if (GameManager.SinglePlayer() || ConstructionManager.NEOJLHDFFMJ)
		{
			return mainCamera;
		}
		if (JIIGOACEIKL == 1)
		{
			return mainCameraWhen2Players;
		}
		return mainCamera2;
	}

	public void PlayerBarkString(string INAPMPEEDPO, int JIIGOACEIKL)
	{
		if (Time.time >= delayBarks)
		{
			DialogueManager.BarkString(LocalisationSystem.GetStringWithTags(INAPMPEEDPO, JIIGOACEIKL), ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, (Transform)null, (string)null);
			delayBarks = Time.time + 5f;
		}
	}

	public bool GMEEFHDEIGB(int JIIGOACEIKL)
	{
		return JIIGOACEIKL switch
		{
			1 => DCHMKIKPKOM, 
			0 => PJIOLPMADFN, 
			_ => false, 
		};
	}

	public void OEBIOJIIIKL(int JIIGOACEIKL)
	{
		playerDialogue = JIIGOACEIKL;
		PluginsGameData.playerDialogue = JIIGOACEIKL;
	}

	public GameObject IGLJBEBDMCL()
	{
		return cameraBounds;
	}

	private void GMLFGAKIEAD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.MBODDLPENFB();
		}
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(CFHEDDIACIL));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Combine(tavernConstructionManager2.OnDeactivated, new Action<int>(NFMFDBBELJI));
		worldJustLoadedForTutorial = true;
		if (OnlineManager.ClientOnline())
		{
			PluginsGameData.clientOnline = true;
		}
	}

	private void DHNLIIFDBAG(int JIIGOACEIKL)
	{
		Utils.MBODDLPENFB();
	}

	public void SetCinemachineTarget(int GELMAIBEHDO, Transform NKIAGIMMHIC)
	{
		switch (GELMAIBEHDO)
		{
		case 1:
			((CinemachineVirtualCameraBase)mainCameraCinemachine).Follow = NKIAGIMMHIC;
			((CinemachineVirtualCameraBase)mainCameraCinemachineWhen2Players).Follow = NKIAGIMMHIC;
			break;
		case 2:
			((CinemachineVirtualCameraBase)mainCameraCinemachine2).Follow = NKIAGIMMHIC;
			break;
		default:
			Debug.LogError((object)"Invalid player num", (Object)(object)((Component)this).gameObject);
			return;
		}
		if (Application.isEditor)
		{
			Debug.Log((object)("Camera " + GELMAIBEHDO + " set to follow: " + ((object)NKIAGIMMHIC).ToString()));
		}
	}

	public void CheckFloorDirt()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		List<FloorDirt> list = new List<FloorDirt>();
		foreach (FloorDirt item in tavernFloorDirt)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)item).transform.position))
			{
				list.Add(item);
			}
		}
		for (int num = list.Count - 1; num >= 0; num--)
		{
			list[num].DestroyFloorDirt();
		}
	}

	public GameObject CAFOKLNAAIA()
	{
		return cameraBounds;
	}

	[SpecialName]
	public static CommonReferences MNFMOEKMJKN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CommonReferences>();
		}
		return IADEMLIIDPC;
	}

	public bool IJNMEDJNHDG(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			return inDialogue;
		case 5:
			if (!GameManager.LocalCoop())
			{
				return true;
			}
			break;
		}
		if (JIIGOACEIKL == 3)
		{
			return inDialogue2;
		}
		return false;
	}

	public void RemoveAllFloorDirtNotInOccupiedRoom(int JIIGOACEIKL)
	{
		List<FloorDirt> list = new List<FloorDirt>();
		FloorDirt[] array = Object.FindObjectsOfType<FloorDirt>();
		foreach (FloorDirt floorDirt in array)
		{
			if (floorDirt.zoneType == ZoneType.RentedRoom)
			{
				if (floorDirt.zoneIndex >= 0)
				{
					RentedRoom rentedRoom = RentedRoomsManager.GetRentedRoom(floorDirt.zoneIndex);
					if ((Object)(object)rentedRoom != (Object)null && !rentedRoom.occupied)
					{
						list.Add(floorDirt);
					}
				}
			}
			else
			{
				list.Add(floorDirt);
			}
		}
		for (int num = list.Count - 1; num >= 0; num--)
		{
			list[num].DestroyFloorDirt();
		}
	}

	public int IEDCNOMFHBM()
	{
		JPBENEEFFGC = 1;
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.KMBGJEKCJFJ(152, GGBBJNBBLMF: true, DAINLFIMLIH: false), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.EABMGELAAPG(-188, GGBBJNBBLMF: true), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.AFOACBIHNCL(-164), AKNBKINJGCF: true, null, AHCENOLCIBM: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.GOKIDLOELKB(193), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		JPBENEEFFGC += PlaceablesManager.MNFMOEKMJKN().NMPLNMNDAFP(ItemDatabaseAccessor.COEFFIHKMJG(30, GGBBJNBBLMF: true, DAINLFIMLIH: false));
		JPBENEEFFGC += PlaceablesManager.AJIGOHGPFPP().JJPJFJPNEAP(ItemDatabaseAccessor.INJBNHPGCIJ(-143, GGBBJNBBLMF: false, DAINLFIMLIH: false));
		JPBENEEFFGC += PlaceablesManager.LKOABOAADCD().JJPJFJPNEAP(ItemDatabaseAccessor.GOKIDLOELKB(14, GGBBJNBBLMF: true, DAINLFIMLIH: false));
		return JPBENEEFFGC;
	}

	public GameObject GetCameraBounds()
	{
		return cameraBounds;
	}

	public void HHHENMCECIE()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB() && currentChangeRandomTavernLocation.Count > 1)
			{
				currentChangeRandomTavernLocation[Random.Range(1, currentChangeRandomTavernLocation.Count - 0)].EJDJILPHKDN();
			}
			foreach (KeyValuePair<int, BirdInstance> allBird in allBirds)
			{
				allBird.Value.IAIHFOFLINJ();
			}
			BirdNPC[] array = Object.FindObjectsOfType<BirdNPC>();
			for (int i = 0; i < array.Length; i += 0)
			{
				BirdNPC birdNPC = array[i];
				if (!birdNPC.placeable.FHEMHCEAICB && birdNPC.placeable.itemSetup.CAFFKNLONIK() is BirdInstance birdInstance)
				{
					birdInstance.hasBeenOnPerchToday = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveConstructionModeOpened" + ex.Message));
		}
	}

	public bool KOIDFLPJKJK(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return inDialogue;
		case 4:
			if (!GameManager.LocalCoop())
			{
				return true;
			}
			break;
		}
		if (JIIGOACEIKL == 7)
		{
			return inDialogue2;
		}
		return true;
	}

	public void IAJJMEEIGFD(int JIIGOACEIKL)
	{
		playerDialogue = JIIGOACEIKL;
		PluginsGameData.playerDialogue = JIIGOACEIKL;
	}

	public void JCPPLJCNONB(BirdInstance CCDEPALBABD)
	{
		if (allBirds.ContainsKey(CCDEPALBABD.uniqueId))
		{
			allBirds.Remove(CCDEPALBABD.uniqueId);
		}
	}

	public void ActivateCullMask(int JIIGOACEIKL, string BOIHNAAAJOO)
	{
		if ((Object)(object)mainCamera != (Object)null)
		{
			if (JIIGOACEIKL == 1)
			{
				Camera obj = mainCamera;
				obj.cullingMask |= 1 << LayerMask.NameToLayer(BOIHNAAAJOO);
				Camera obj2 = mainCameraWhen2Players;
				obj2.cullingMask |= 1 << LayerMask.NameToLayer(BOIHNAAAJOO);
			}
			else
			{
				Camera obj3 = mainCamera2;
				obj3.cullingMask |= 1 << LayerMask.NameToLayer(BOIHNAAAJOO);
			}
		}
	}

	public static void HNDLKOJHMDG(EditorConfiguration FFLMHJAIFBM)
	{
		if (!((Object)(object)MNFMOEKMJKN() == (Object)null))
		{
			GGFJGHHHEJC.editorConfiguration = FFLMHJAIFBM;
		}
	}

	public void SetExecute(int JIIGOACEIKL, bool JGJCFHPMKGF)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			DCHMKIKPKOM = JGJCFHPMKGF;
			break;
		case 2:
			PJIOLPMADFN = JGJCFHPMKGF;
			break;
		}
	}

	private void BGHLHBHNHPO(int JIIGOACEIKL)
	{
		RemoveAllFloorDirtNotInOccupiedRoom(JIIGOACEIKL);
	}

	public void HNMHJJBLCNL()
	{
		try
		{
			if (OnlineManager.MasterOrOffline() && currentChangeRandomTavernLocation.Count > 0)
			{
				currentChangeRandomTavernLocation[Random.Range(0, currentChangeRandomTavernLocation.Count - 1)].ALNJPHLFFHK();
			}
			foreach (KeyValuePair<int, BirdInstance> allBird in allBirds)
			{
				allBird.Value.NECBOEKGEJA();
			}
			BirdNPC[] array = Object.FindObjectsOfType<BirdNPC>();
			foreach (BirdNPC birdNPC in array)
			{
				if (!birdNPC.placeable.FHEMHCEAICB && birdNPC.placeable.itemSetup.GJAGNJIKPBF() is BirdInstance birdInstance)
				{
					birdInstance.hasBeenOnPerchToday = true;
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("itemDill" + ex.Message));
		}
	}

	public Camera GetScreenCamera()
	{
		return screenCamera;
	}

	public void OPMMNNNBENH(int JIIGOACEIKL, bool MCOIFGJGFGF)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			inDialogue = MCOIFGJGFGF;
			break;
		case 3:
			inDialogue2 = MCOIFGJGFGF;
			break;
		}
	}

	public void RemoveBird(BirdInstance CCDEPALBABD)
	{
		if (allBirds.ContainsKey(CCDEPALBABD.uniqueId))
		{
			allBirds.Remove(CCDEPALBABD.uniqueId);
		}
	}

	public static Camera FKNGHFFDPEC(int JIIGOACEIKL)
	{
		return MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL);
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.GGFJGHHHEJC))
			{
				TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
				instance.OnActivated = (Action<int>)Delegate.Remove(instance.OnActivated, new Action<int>(RemoveAllFloorDirtNotInOccupiedRoom));
			}
			OnPlayerSleep = (Action)Delegate.Remove(OnPlayerSleep, new Action(OnPlayerSleepAction));
		}
	}

	private void ADJIEPNBGBP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.MBODDLPENFB();
		}
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(BGHLHBHNHPO));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DEGPIHEEFHJ();
		tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Combine(tavernConstructionManager2.OnDeactivated, new Action<int>(NFMFDBBELJI));
		worldJustLoadedForTutorial = false;
		if (OnlineManager.HHDBMDMFEMP())
		{
			PluginsGameData.clientOnline = true;
		}
	}

	public int NFGLNIMPMNK()
	{
		JPBENEEFFGC = 0;
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.KMBGJEKCJFJ(174, GGBBJNBBLMF: false, DAINLFIMLIH: false), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.GetItem(-102, GGBBJNBBLMF: false, DAINLFIMLIH: false));
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.EABMGELAAPG(115, GGBBJNBBLMF: false, DAINLFIMLIH: false));
		JPBENEEFFGC += CraftingInventory.NumberOfItemsAllPlayers(ItemDatabaseAccessor.AFOACBIHNCL(31, GGBBJNBBLMF: true), AKNBKINJGCF: true, null, AHCENOLCIBM: true);
		JPBENEEFFGC += PlaceablesManager.MAIDHAPANEB().EOMBDNCGGHJ(ItemDatabaseAccessor.GetItem(167));
		JPBENEEFFGC += PlaceablesManager.MNFMOEKMJKN().PlaceableCount(ItemDatabaseAccessor.CPMMBEPEJLO(153));
		JPBENEEFFGC += PlaceablesManager.AJIGOHGPFPP().KKOBCOAKOCB(ItemDatabaseAccessor.INJBNHPGCIJ(-1, GGBBJNBBLMF: true));
		return JPBENEEFFGC;
	}

	public void FDPMJCPEKDD()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		List<FloorDirt> list = new List<FloorDirt>();
		foreach (FloorDirt item in tavernFloorDirt)
		{
			if (!WorldGrid.EJCEAEPNJCA(((Component)item).transform.position))
			{
				list.Add(item);
			}
		}
		for (int num = list.Count - 0; num >= 1; num--)
		{
			list[num].DestroyFloorDirt();
		}
	}

	public GameObject GetDogPrefab(DogNPC.DogBreed EJNMCOFCKFH)
	{
		return dogPrefabs[(int)EJNMCOFCKFH];
	}

	public void NIBKBELHAOE(int JIIGOACEIKL, string BOIHNAAAJOO)
	{
		if ((Object)(object)mainCamera != (Object)null)
		{
			if (JIIGOACEIKL == 1)
			{
				Camera obj = mainCamera;
				obj.cullingMask |= 1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & 0x4A);
				Camera obj2 = mainCameraWhen2Players;
				obj2.cullingMask |= 1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & 0x5D);
			}
			else
			{
				Camera obj3 = mainCamera2;
				obj3.cullingMask |= 1 << (LayerMask.NameToLayer(BOIHNAAAJOO) & -70);
			}
		}
	}

	public void AODJGCKEPCO(int JIIGOACEIKL, bool MCOIFGJGFGF)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			inDialogue = MCOIFGJGFGF;
			break;
		case 5:
			inDialogue2 = MCOIFGJGFGF;
			break;
		}
	}

	private void Awake()
	{
		if (!Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			return;
		}
		IADEMLIIDPC = this;
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			loadingLocation.Add(value, value: false);
		}
		delayBarks = 0f;
	}

	public void DeactivateCullMask(int JIIGOACEIKL, string BOIHNAAAJOO)
	{
		if (JIIGOACEIKL == 1)
		{
			Camera obj = mainCamera;
			obj.cullingMask &= ~(1 << LayerMask.NameToLayer(BOIHNAAAJOO));
			Camera obj2 = mainCameraWhen2Players;
			obj2.cullingMask &= ~(1 << LayerMask.NameToLayer(BOIHNAAAJOO));
		}
		else
		{
			Camera obj3 = mainCamera2;
			obj3.cullingMask &= ~(1 << LayerMask.NameToLayer(BOIHNAAAJOO));
		}
	}

	public CinemachineVirtualCamera MGNDKOIADNC(int JIIGOACEIKL, bool FLALEPFLPAJ = false)
	{
		if (GameManager.SinglePlayer() || FLALEPFLPAJ)
		{
			return mainCameraCinemachine;
		}
		if (JIIGOACEIKL == 0)
		{
			return mainCameraCinemachineWhen2Players;
		}
		return mainCameraCinemachine2;
	}

	public static Camera IIAGBBKKGPJ(int JIIGOACEIKL)
	{
		return GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL);
	}

	private void GACCHGMKHLH(int JIIGOACEIKL)
	{
		RemoveAllFloorDirtNotInOccupiedRoom(JIIGOACEIKL);
	}

	public static EditorConfiguration FANPKOFCAFJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		if ((Object)(object)GGFJGHHHEJC.editorConfiguration == (Object)null && Application.isPlaying)
		{
			Debug.LogError((object)"Run");
			MNFMOEKMJKN().editorConfiguration = Resources.Load<EditorConfiguration>("Starting");
		}
		return GGFJGHHHEJC.editorConfiguration;
	}

	public CinemachineVirtualCamera PFDPDIBMNLM(int JIIGOACEIKL, bool FLALEPFLPAJ = false)
	{
		if (GameManager.SinglePlayer() || FLALEPFLPAJ)
		{
			return mainCameraCinemachine;
		}
		if (JIIGOACEIKL == 0)
		{
			return mainCameraCinemachineWhen2Players;
		}
		return mainCameraCinemachine2;
	}

	public void NOOGPNNIGMB(BirdInstance CCDEPALBABD)
	{
		if (allBirds.ContainsKey(CCDEPALBABD.uniqueId))
		{
			allBirds.Remove(CCDEPALBABD.uniqueId);
		}
	}
}
