using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SceneReferences : MonoBehaviour, ISingleton
{
	public static Action OnGameplaySceneLoaded = delegate
	{
	};

	public const string MENU_SCENE = "Inicio";

	public const string GAMEPLAY_SCENE = "Gameplay";

	public static SceneReferences instance;

	public DialogueSystemController dialogueController;

	public StandardDialogueUI[] dialogueUI;

	public StandardDialogueUI dialogueUIIntro;

	public StandardDialogueUI[] dialogueUINoPortrait;

	[SerializeField]
	private CameraTarget player1CameraTarget;

	[SerializeField]
	private CameraTarget player2CameraTarget;

	[SerializeField]
	private CompositeCollider2D cameraBounds;

	public BoxCollider2D castleGardenBounds;

	public BoxCollider2D banquetEventBounds;

	[SerializeField]
	private BoxCollider2D boundsFirstFloor;

	[SerializeField]
	private BoxCollider2D boundsSecondFloor;

	[SerializeField]
	private BoxCollider2D boundsCellar;

	public GameObject worldLight;

	[SerializeField]
	private NPCSpawner[] npcSpawners;

	public Transform firstFloorPos;

	public Transform secondFloorPos;

	public Transform cellarPos;

	public Transform oldFarmPositionMin;

	public Transform oldFarmPositionMax;

	public Transform newFarmPosition;

	public Transform oldBedroomPosMin;

	public Transform oldBedroomPosMax;

	public Transform newBedroomPos;

	public Transform oldTavernPosMin;

	public Transform oldTavernPosMax;

	public Transform newTavernPos;

	public Transform oldCellarPosMin;

	public Transform oldCellarPosMax;

	public Transform newCellarPos;

	public Transform oldRentedRoomsPositionMin;

	public Transform oldRentedRoomsPositionMax;

	public Transform avoidWork;

	public Transform newGameStartPos;

	public Collider2D excludeTreesOnNewGame;

	public Collider2D[] mapColliders;

	public GameObject tutorialCollider;

	public BuildingTutorialSpace[] tutorialsSpace;

	public GameObject tutorialParent;

	public GameObject floorDirt;

	public GameObject cellarDoor;

	public GameObject barSurface;

	public Light2D blueLight;

	public Table table;

	public Sitable[] sitables;

	public GameObject[] multiplayerRoomsObjects;

	public AlphaTransition fireplaceAlphaTransition;

	public ParticleSystem[] blueFires;

	public Light2D[] blueFireLights;

	public NightStart[] nightStartDeactive;

	public GameObject npcRoutines;

	public AgingBarrel agingBarrel;

	public List<GameObject> tutorialRats;

	public Customer[] humanMais;

	public CustomerPool customerPool;

	public GameObject humanCustomerPool;

	public Transform quarryCaveTp;

	public Placeable[] crafterPlaceable;

	public ItemContainer initialChest;

	public AwningManager[] awningManager;

	public BirdSellerNPC crowlyNpc;

	public GameObject castleGardenNpcs;

	public GameObject castleGardenGuards;

	public GameObject castleGardenPeacocks;

	public InteractableForm[] interactableForms;

	public static bool FEHELEPDHNL { get; private set; }

	public static bool AFEDGPJNCDN { get; set; }

	public static SceneReferences GetSceneReferences()
	{
		return instance;
	}

	[SpecialName]
	public static void EJJLOKOBLPL(bool AODONKKHPBP)
	{
		_003CABMJLBJAICM_003Ek__BackingField = AODONKKHPBP;
	}

	public static void Setup()
	{
		Debug.Log((object)"Setup");
		GameManager.GGFJGHHHEJC.SetCinemachinesConfinerBoundaries((Collider2D)(object)instance.cameraBounds);
		SetPlayer1CameraTarget(((Component)PlayerController.GetPlayer(1)).transform);
		TavernConstructionManager.ToggleActived();
		if (AFEDGPJNCDN)
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.LOLAFOECMGP();
			}
			GameManager.GGFJGHHHEJC.OnNewGameCreated();
		}
		GameManager.OnLevelLoaded();
		if (AFEDGPJNCDN)
		{
			AFEDGPJNCDN = false;
		}
	}

	[SpecialName]
	public static bool BHELOBCGMJH()
	{
		return _003CABMJLBJAICM_003Ek__BackingField;
	}

	public void BAECOKOMNBA()
	{
		MBJCIDAOCJK(AODONKKHPBP: false);
		OnGameplaySceneLoaded = delegate
		{
		};
	}

	public static NPCSpawner GetRandomSpawnPoint()
	{
		return instance.npcSpawners[Random.Range(0, instance.npcSpawners.Length)];
	}

	private void NNMFLMJDKNH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
			ResetSingleton();
		}
	}

	public static CameraTarget LIEDGBKNFDC()
	{
		return instance.player2CameraTarget;
	}

	private void JECHMEFJABD()
	{
		Debug.Log((object)"Open");
		if (!OnlineManager.HHDBMDMFEMP())
		{
			FJAOMGJLDOA();
		}
	}

	public static void DGJJPAICOKK()
	{
		Debug.Log((object)"Hikari/Barks_Intro");
		GameManager.NJNFHEPLEHL().SetCinemachinesConfinerBoundaries((Collider2D)(object)instance.cameraBounds);
		SetPlayer1CameraTarget(((Component)PlayerController.OPHDCMJLLEC(0)).transform);
		TavernConstructionManager.ToggleActived();
		if (CDCFHKEAEKK())
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.BOGGAADDEOK();
			}
			GameManager.NJNFHEPLEHL().OnNewGameCreated();
		}
		GameManager.OnLevelLoaded();
		if (AFEDGPJNCDN)
		{
			EJJLOKOBLPL(AODONKKHPBP: true);
		}
	}

	private void BOGGAADDEOK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Items/item_description_1039");
		PlayerController.CLEIAKPOGMM(1, newGameStartPos.position, Location.None);
		Sound.MAIDHAPANEB().blockSound.Add((MonoBehaviour)(object)this);
		Sound.BNBMNOMFFBE().blockSound.Remove((MonoBehaviour)(object)this);
		Bed.MLHELNBJJDN();
		QuestManager.OPILDPFDFKJ().NJDDJJEGOAF(QuestDatabaseAccessor.MFCLBOPPEBB(1), 0, FFJBIGFADBJ: true);
		GeneratorsManager.instance.MOJFAGEDHML(LCIDLBLPKHB: false);
	}

	public static CameraTarget CFFMMHJABJG()
	{
		return instance.player2CameraTarget;
	}

	public static CameraTarget ODMIFGMCGAG()
	{
		return instance.player1CameraTarget;
	}

	public static void PNGNCBKFLKO(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player1CameraTarget);
		instance.player1CameraTarget.player = NKIAGIMMHIC;
	}

	public static void IBCMBINOMEP(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player1CameraTarget);
		instance.player1CameraTarget.player = NKIAGIMMHIC;
	}

	public static BoxCollider2D CGGNGMODOLB(TavernFloor BDCFJAHNOML)
	{
		return (BoxCollider2D)(BDCFJAHNOML switch
		{
			TavernFloor.Cellar => instance.boundsFirstFloor, 
			TavernFloor.Cellar | TavernFloor.FirstFloor => instance.boundsSecondFloor, 
			TavernFloor.None => instance.boundsCellar, 
			_ => null, 
		});
	}

	private void FHEGBNMJADG()
	{
		Debug.Log((object)"Masters/Klayn/Banquet");
		if (!OnlineManager.HHDBMDMFEMP())
		{
			Setup();
		}
	}

	public static void CBIADBNNMEP(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player1CameraTarget);
		instance.player1CameraTarget.player = NKIAGIMMHIC;
	}

	private void GADEGOPBNGC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
			CDLFMIEGNLO();
		}
	}

	public static void EHOHLKNKIHI(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player2CameraTarget);
		instance.player2CameraTarget.player = NKIAGIMMHIC;
		AIKCENBGIKE();
	}

	private void LOLAFOECMGP()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"NewGameSetup");
		PlayerController.TeleportPlayer(1, newGameStartPos.position, Location.Tavern);
		Sound.GGFJGHHHEJC.blockSound.Add((MonoBehaviour)(object)this);
		Sound.GGFJGHHHEJC.blockSound.Remove((MonoBehaviour)(object)this);
		Bed.EnableBed();
		QuestManager.GGFJGHHHEJC.AddQuest(QuestDatabaseAccessor.GetQuest(1), 0, FFJBIGFADBJ: true);
		GeneratorsManager.instance.GenerateNewForestMapWithCoroutine(LCIDLBLPKHB: true);
	}

	[SpecialName]
	public static void FHFNNLMPONG(bool AODONKKHPBP)
	{
		_003CABMJLBJAICM_003Ek__BackingField = AODONKKHPBP;
	}

	public static NPCSpawner MHFJEGDFJIN()
	{
		return instance.npcSpawners[Random.Range(0, instance.npcSpawners.Length)];
	}

	private void Awake()
	{
		instance = this;
		Debug.Log((object)"SceneReferences Awake");
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.LogSyncRunning();
			Debug.Log((object)(GameManager.NoPlayers() ? "No players at the start of the scene. Spawning..." : "Another player already exists from online sync."));
		}
		else if (GameManager.NoPlayers())
		{
			Debug.Log((object)"No players at the start of the scene. Spawning...");
			GameManager.SpawnPlayer();
		}
		FEHELEPDHNL = true;
		OnGameplaySceneLoaded?.Invoke();
	}

	public static CameraTarget GetPlayer2CameraTarget()
	{
		return instance.player2CameraTarget;
	}

	[SpecialName]
	private static void BAAFMNNJCGI(bool AODONKKHPBP)
	{
		_003CJAAOHHODKCE_003Ek__BackingField = AODONKKHPBP;
	}

	private void HEGNINLLINP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
			BAECOKOMNBA();
		}
	}

	public static void NADDNMAEAII(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player1CameraTarget);
		instance.player1CameraTarget.player = NKIAGIMMHIC;
	}

	public void BLLAIDMHEHD()
	{
		BAAFMNNJCGI(AODONKKHPBP: true);
		OnGameplaySceneLoaded = delegate
		{
		};
	}

	public static SceneReferences FAOPFMBMMJJ()
	{
		return instance;
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
			ResetSingleton();
		}
	}

	public static void EnableMapColliders(bool IKAGABHNANJ)
	{
		for (int i = 0; i < instance.mapColliders.Length; i++)
		{
			((Behaviour)instance.mapColliders[i]).enabled = IKAGABHNANJ;
		}
	}

	public static NPCSpawner EOGIHFDHLDM()
	{
		return instance.npcSpawners[Random.Range(0, instance.npcSpawners.Length)];
	}

	public static void PHNHNNLOIMO(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player1CameraTarget);
		instance.player1CameraTarget.player = NKIAGIMMHIC;
	}

	public static void IKBDMLBIDPJ(bool IKAGABHNANJ)
	{
		for (int i = 0; i < instance.mapColliders.Length; i++)
		{
			((Behaviour)instance.mapColliders[i]).enabled = IKAGABHNANJ;
		}
	}

	private void JCNGGPIICIN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
			ResetSingleton();
		}
	}

	public static NPCSpawner EOMEEMMKMCI()
	{
		return instance.npcSpawners[Random.Range(0, instance.npcSpawners.Length)];
	}

	public static void JFFDELEKIOA(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player2CameraTarget);
		instance.player2CameraTarget.player = NKIAGIMMHIC;
		EnablePlayer2Camera();
	}

	[SpecialName]
	public static void MCCNDLHAPCL(bool AODONKKHPBP)
	{
		_003CABMJLBJAICM_003Ek__BackingField = AODONKKHPBP;
	}

	private void EFCNKPEPELL()
	{
		instance = this;
		Debug.Log((object)"Trying to add player but player list is full.");
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.OIAPJGOIAID();
			Debug.Log((object)(GameManager.OPGGPLEOGCG() ? "BobProgress" : "Tue"));
		}
		else if (GameManager.OPGGPLEOGCG())
		{
			Debug.Log((object)"/");
			GameManager.MBDHHECIIPD();
		}
		CIIDENKOEIK(AODONKKHPBP: true);
		OnGameplaySceneLoaded?.Invoke();
	}

	public static CameraTarget CMNMEBCHAIP()
	{
		return instance.player2CameraTarget;
	}

	private void HFPDNCBLNDE()
	{
		instance = this;
		Debug.Log((object)"Cheddar");
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.OIAPJGOIAID();
			Debug.Log((object)(GameManager.CAGIBNLHJBN() ? "UINextCategory" : "No se encontró una entrada con ID {0} en la conversación '{1}'."));
		}
		else if (GameManager.NoPlayers())
		{
			Debug.Log((object)"No empty bucket");
			GameManager.MBDHHECIIPD();
		}
		CIIDENKOEIK(AODONKKHPBP: true);
		OnGameplaySceneLoaded?.Invoke();
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
		Debug.Log((object)"ReceiveEnable");
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.LogSyncRunning();
			Debug.Log((object)(GameManager.CAGIBNLHJBN() ? "ReceiveDialogueStart" : "Unlocked at Tavern Reputation {0}"));
		}
		else if (GameManager.CAGIBNLHJBN())
		{
			Debug.Log((object)"No content to disable in this NPC!");
			GameManager.SpawnPlayer();
		}
		FEHELEPDHNL = true;
		OnGameplaySceneLoaded?.Invoke();
	}

	public static SceneReferences CKDKHMPHENE()
	{
		return instance;
	}

	public static void KOMJFGMNGJI()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(1)).gameObject.SetActive(false);
		}
	}

	public void ResetSingleton()
	{
		FEHELEPDHNL = false;
		OnGameplaySceneLoaded = delegate
		{
		};
	}

	public static void BEKHJPMGCEE()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(0)).gameObject.SetActive(true);
		}
	}

	public static NPCSpawner HNCGCLEMCDM()
	{
		return instance.npcSpawners[Random.Range(0, instance.npcSpawners.Length)];
	}

	private void JGANMNOMAHL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Remove");
		PlayerController.CLEIAKPOGMM(0, newGameStartPos.position, Location.None);
		Sound.DIHCEGINELM().blockSound.Add((MonoBehaviour)(object)this);
		Sound.ABDJJBFNLBJ().blockSound.Remove((MonoBehaviour)(object)this);
		Bed.EnableBed();
		QuestManager.KHMEGDIABBF().NJDDJJEGOAF(QuestDatabaseAccessor.DIBHHGJNNFH(1), 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
		GeneratorsManager.instance.MOJFAGEDHML(LCIDLBLPKHB: true);
	}

	public static bool AKEMBBNDPNH()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static void NJNHNCEBNND()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(0)).gameObject.SetActive(true);
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
		Debug.Log((object)"<sprite name=white_arrow_right> ");
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.OIAPJGOIAID();
			Debug.Log((object)(GameManager.NoPlayers() ? "" : "Items/item_description_690"));
		}
		else if (GameManager.CAGIBNLHJBN())
		{
			Debug.Log((object)"LearnPrecision");
			GameManager.MBDHHECIIPD();
		}
		DIGCLPNBLII(AODONKKHPBP: false);
		OnGameplaySceneLoaded?.Invoke();
	}

	[SpecialName]
	public static void CECNDHMJLNK(bool AODONKKHPBP)
	{
		_003CABMJLBJAICM_003Ek__BackingField = AODONKKHPBP;
	}

	public static void AIKCENBGIKE()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(0)).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static bool HBHONAHCMMM()
	{
		return _003CABMJLBJAICM_003Ek__BackingField;
	}

	public static bool EEHODLICINM()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
		Debug.Log((object)"stormy clouds");
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.LogSyncRunning();
			Debug.Log((object)(GameManager.OPGGPLEOGCG() ? "onlineProfileID is null. Initializate on prefab with length " : "itemCactus"));
		}
		else if (GameManager.OPGGPLEOGCG())
		{
			Debug.Log((object)"</color>");
			GameManager.MBDHHECIIPD();
		}
		CIIDENKOEIK(AODONKKHPBP: false);
		OnGameplaySceneLoaded?.Invoke();
	}

	private void PKBHEKHOAAA()
	{
		Debug.Log((object)" could not be removed because it does not exist");
		if (!OnlineManager.HHDBMDMFEMP())
		{
			BLJMJIHCIPH();
		}
	}

	public static void BLJMJIHCIPH()
	{
		Debug.Log((object)"ValueIntensity");
		GameManager.GGFJGHHHEJC.SetCinemachinesConfinerBoundaries((Collider2D)(object)instance.cameraBounds);
		PNGNCBKFLKO(((Component)PlayerController.OPHDCMJLLEC(0)).transform);
		TavernConstructionManager.HHKCIPLGMKJ();
		if (OFFDMEIFGNM())
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.KBDCNHEHPBK();
			}
			GameManager.NJNFHEPLEHL().OnNewGameCreated();
		}
		GameManager.OnLevelLoaded();
		if (AFEDGPJNCDN)
		{
			EJJLOKOBLPL(AODONKKHPBP: false);
		}
	}

	public static void ODMLOHCDFIM(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player2CameraTarget);
		instance.player2CameraTarget.player = NKIAGIMMHIC;
		NJNHNCEBNND();
	}

	[SpecialName]
	private static void DIGCLPNBLII(bool AODONKKHPBP)
	{
		_003CJAAOHHODKCE_003Ek__BackingField = AODONKKHPBP;
	}

	public static CameraTarget AIFEHACAOCA()
	{
		return instance.player2CameraTarget;
	}

	public static void GEBFLINPJPK()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(1)).gameObject.SetActive(false);
		}
	}

	public void OEJLHOFAMED()
	{
		FEHELEPDHNL = true;
		OnGameplaySceneLoaded = delegate
		{
		};
	}

	public static void NFDMOFEIOCL()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(1)).gameObject.SetActive(true);
		}
	}

	public static SceneReferences CFAMKBHIGLO()
	{
		return instance;
	}

	[SpecialName]
	private static void CIIDENKOEIK(bool AODONKKHPBP)
	{
		_003CJAAOHHODKCE_003Ek__BackingField = AODONKKHPBP;
	}

	public static BoxCollider2D NGHCOOLAMJM(TavernFloor BDCFJAHNOML)
	{
		return (BoxCollider2D)(BDCFJAHNOML switch
		{
			TavernFloor.Cellar => instance.boundsFirstFloor, 
			TavernFloor.Cellar | TavernFloor.FirstFloor => instance.boundsSecondFloor, 
			TavernFloor.None => instance.boundsCellar, 
			_ => null, 
		});
	}

	private void GNMMELIJKML()
	{
		Debug.Log((object)"/Female/");
		if (!OnlineManager.ClientOnline())
		{
			OHMJHCGOAJC();
		}
	}

	public void CDLFMIEGNLO()
	{
		MBJCIDAOCJK(AODONKKHPBP: true);
		OnGameplaySceneLoaded = delegate
		{
		};
	}

	private void BNIKICAEIND()
	{
		Debug.Log((object)"Quest Complete");
		if (!OnlineManager.ClientOnline())
		{
			Setup();
		}
	}

	public static void EnablePlayer2Camera()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(0)).gameObject.SetActive(true);
		}
	}

	public static void CJAEDKGEEGC()
	{
		Debug.Log((object)"Generate All Routes");
		GameManager.GGFJGHHHEJC.JJOKGJAEDHO((Collider2D)(object)instance.cameraBounds);
		PNGNCBKFLKO(((Component)PlayerController.OPHDCMJLLEC(1)).transform);
		TavernConstructionManager.ToggleActived();
		if (CDCFHKEAEKK())
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				instance.BOGGAADDEOK();
			}
			GameManager.GGFJGHHHEJC.OnNewGameCreated();
		}
		GameManager.OnLevelLoaded();
		if (AFEDGPJNCDN)
		{
			AFEDGPJNCDN = false;
		}
	}

	[SpecialName]
	public static bool OFFDMEIFGNM()
	{
		return _003CABMJLBJAICM_003Ek__BackingField;
	}

	public static void OHMJHCGOAJC()
	{
		Debug.Log((object)"ReceiveTableMessage");
		GameManager.NJNFHEPLEHL().SetCinemachinesConfinerBoundaries((Collider2D)(object)instance.cameraBounds);
		PNGNCBKFLKO(((Component)PlayerController.OPHDCMJLLEC(0)).transform);
		TavernConstructionManager.ToggleActived();
		if (OFFDMEIFGNM())
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.KBDCNHEHPBK();
			}
			GameManager.GGFJGHHHEJC.OnNewGameCreated();
		}
		GameManager.OnLevelLoaded();
		if (CDCFHKEAEKK())
		{
			EJJLOKOBLPL(AODONKKHPBP: false);
		}
	}

	public static NPCSpawner MFLJMPFLMEI()
	{
		return instance.npcSpawners[Random.Range(1, instance.npcSpawners.Length)];
	}

	public static void SetPlayer2CameraTarget(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player2CameraTarget);
		instance.player2CameraTarget.player = NKIAGIMMHIC;
		EnablePlayer2Camera();
	}

	public static void EMEDBLJBGKC()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(1)).gameObject.SetActive(false);
		}
	}

	public static void DisablePlayer2Camera()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(0)).gameObject.SetActive(false);
		}
	}

	private void DMFMNEMDFNP()
	{
		Debug.Log((object)"MilkAction");
		if (!OnlineManager.HHDBMDMFEMP())
		{
			OHMJHCGOAJC();
		}
	}

	public static void MPHHGCEPHDB(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player2CameraTarget);
		instance.player2CameraTarget.player = NKIAGIMMHIC;
		KOMJFGMNGJI();
	}

	[SpecialName]
	private static void MBJCIDAOCJK(bool AODONKKHPBP)
	{
		_003CJAAOHHODKCE_003Ek__BackingField = AODONKKHPBP;
	}

	public static void DMIJPGKGNLJ()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(0)).gameObject.SetActive(true);
		}
	}

	private void OLDDEAJMHNI()
	{
		Debug.Log((object)"tutorialPopUp110");
		if (!OnlineManager.HHDBMDMFEMP())
		{
			BLJMJIHCIPH();
		}
	}

	public static bool FMIGGMHHJNM()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
		Debug.Log((object)"ReceiveShopInfoLoad");
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.OIAPJGOIAID();
			Debug.Log((object)(GameManager.OPGGPLEOGCG() ? "Shield" : "wall floor not found with highlight at "));
		}
		else if (GameManager.OPGGPLEOGCG())
		{
			Debug.Log((object)"City/PetShop/Nessy/Stand");
			GameManager.SpawnPlayer();
		}
		CIIDENKOEIK(AODONKKHPBP: true);
		OnGameplaySceneLoaded?.Invoke();
	}

	public static void SetPlayer1CameraTarget(Transform NKIAGIMMHIC)
	{
		Debug.Log((object)NKIAGIMMHIC);
		Debug.Log((object)instance.player1CameraTarget);
		instance.player1CameraTarget.player = NKIAGIMMHIC;
	}

	public static NPCSpawner EPOOJLDLPEG()
	{
		return instance.npcSpawners[Random.Range(1, instance.npcSpawners.Length)];
	}

	public static BoxCollider2D GetCameraBounds(TavernFloor BDCFJAHNOML)
	{
		return (BoxCollider2D)(BDCFJAHNOML switch
		{
			TavernFloor.FirstFloor => instance.boundsFirstFloor, 
			TavernFloor.SecondFloor => instance.boundsSecondFloor, 
			TavernFloor.Cellar => instance.boundsCellar, 
			_ => null, 
		});
	}

	private void AGLMGDNBHBF()
	{
		instance = this;
		Debug.Log((object)"{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.OIAPJGOIAID();
			Debug.Log((object)(GameManager.NoPlayers() ? "Stone" : "beach"));
		}
		else if (GameManager.NoPlayers())
		{
			Debug.Log((object)"Player");
			GameManager.MBDHHECIIPD();
		}
		BAAFMNNJCGI(AODONKKHPBP: false);
		OnGameplaySceneLoaded?.Invoke();
	}

	public static CameraTarget DAGNFNGCODB()
	{
		return instance.player2CameraTarget;
	}

	public static void DHGGJAAHICN()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(1)).gameObject.SetActive(false);
		}
	}

	public static void FJAOMGJLDOA()
	{
		Debug.Log((object)"Disappear");
		GameManager.NJNFHEPLEHL().JJOKGJAEDHO((Collider2D)(object)instance.cameraBounds);
		SetPlayer1CameraTarget(((Component)PlayerController.OPHDCMJLLEC(0)).transform);
		TavernConstructionManager.HHKCIPLGMKJ();
		if (HBHONAHCMMM())
		{
			if (OnlineManager.MasterOrOffline())
			{
				instance.KBDCNHEHPBK();
			}
			GameManager.GGFJGHHHEJC.OnNewGameCreated();
		}
		GameManager.OnLevelLoaded();
		if (HBHONAHCMMM())
		{
			CECNDHMJLNK(AODONKKHPBP: true);
		}
	}

	[SpecialName]
	public static bool KCIBKIPIFDO()
	{
		return _003CJAAOHHODKCE_003Ek__BackingField;
	}

	static SceneReferences()
	{
		_003CABMJLBJAICM_003Ek__BackingField = false;
	}

	[SpecialName]
	public static bool CDCFHKEAEKK()
	{
		return _003CABMJLBJAICM_003Ek__BackingField;
	}

	public static CameraTarget GetPlayer1CameraTarget()
	{
		return instance.player1CameraTarget;
	}

	public static CameraTarget DOEGLOMGEKJ()
	{
		return instance.player2CameraTarget;
	}

	private void Start()
	{
		Debug.Log((object)"SceneReferences Start");
		if (!OnlineManager.ClientOnline())
		{
			Setup();
		}
	}

	public static void HIODDANJMKM()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.player2CameraTarget == (Object)null))
		{
			((Component)((Component)instance.player2CameraTarget).transform.GetChild(1)).gameObject.SetActive(false);
		}
	}

	private void KBDCNHEHPBK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Dialogue System/Conversation/Crowly_Barks_Shop/Entry/1/Dialogue Text");
		PlayerController.TeleportPlayer(0, newGameStartPos.position, Location.Tavern);
		Sound.DIHCEGINELM().blockSound.Add((MonoBehaviour)(object)this);
		Sound.MAIDHAPANEB().blockSound.Remove((MonoBehaviour)(object)this);
		Bed.MLHELNBJJDN();
		QuestManager.GJFMMOPOKGJ().JOAHBCAAFMC(QuestDatabaseAccessor.HHKKPIHIEJL(1), 1, FFJBIGFADBJ: true, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
		GeneratorsManager.instance.BGPGEAKNGFA(LCIDLBLPKHB: true);
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static NPCSpawner EGHCHFMENHK()
	{
		return instance.npcSpawners[Random.Range(1, instance.npcSpawners.Length)];
	}

	private void KOBNHPKEJJD()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
			CDLFMIEGNLO();
		}
	}
}
