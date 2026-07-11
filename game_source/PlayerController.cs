using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
	private static PlayerController[] GJBBNHCMNJN = new PlayerController[5];

	public Action<int, ZoneType, int> OnZoneChanged = delegate
	{
	};

	public Action OnPlayerMoving = delegate
	{
	};

	public Action<int> OnPlayerMovingWithNumber = delegate
	{
	};

	public int playerNum;

	public float speed = 1f;

	public float sprintMultiplier = 1.75f;

	public float shieldSpeed = 0.5f;

	public bool moving;

	public int zoneIndex;

	public Transform playerShadow;

	public CharacterAnimation characterAnimation;

	public CharacterCreator characterCreator;

	public TrayHandler trayHandler;

	public FishingController fishingController;

	public ToolsSkinController toolSkinController;

	public WaterInteractionController waterInteractionController;

	public BuriedInteractionController buriedInteractionController;

	public int _mineLevel;

	public GenericPool waterWavesPool;

	public PhotonView photonView;

	private HashSet<Object> KCOCHCLANLH = new HashSet<Object>();

	private HashSet<Object> CGFGDMHPEPG = new HashSet<Object>();

	public bool eatingCandy;

	[HideInInspector]
	public List<RampDisplacementCorrection> additionalDisplacement = new List<RampDisplacementCorrection>();

	public Rigidbody2D rb;

	private bool ICEANLPBNKC;

	public bool sprintBlocker;

	private bool ODNANDGFNFH;

	private bool HICJPMOHBDM;

	private bool CIEFNGKPNOM;

	[HideInInspector]
	public float currentMoveTime = 0.1f;

	private const float PHBKJNBNMLC = 0.01f;

	private const float LJFGFACNEPJ = 0.05f;

	private Vector2 EODIDNILDIF;

	[SerializeField]
	private ZoneType _currentZone;

	[SerializeField]
	private Location _currentLocation;

	private Coroutine HKNFMAAKEDI;

	public PlayerGridController gridController;

	public Collider2D playerCollider;

	[HideInInspector]
	public HumanInfo characterSaveBeforeHalloweenSkin;

	public GameObject hitCollider;

	[SerializeField]
	private bool isActioningTool;

	public float horizontalMove;

	public float verticalMove;

	public bool inWater;

	public bool textInputBlockerEnabled;

	public GameObject explosion;

	public EmotionsController emotionController;

	public SortingGroup sortingGroup;

	public InteractAction interactAction;

	public Action<Location> OnChangeLocation = delegate
	{
	};

	[HideInInspector]
	public OnlinePlayer onlinePlayer;

	public HitDetection hitDetection;

	public GameObject hitFx;

	public AudioObject hitSound;

	private static readonly Vector3 JKKKPDOPHJL = new Vector3(0f, 0.02083333f, 0f);

	private float NAPCGOBFECM;

	private Vector2 GFJIJLHFNAL;

	private Vector2 IBNMJHMLIMI;

	private Vector2[] GDHHIIMLBEL;

	private int OHANGILJGJI;

	private Vector3 AHFEIBMOHAN;

	private bool NBJAHOBPJAP;

	private bool GANGIDPBPBE;

	public PathRequestInfo pathRequestInfo;

	public bool autoMoving;

	private Vector2 AJLJHLHGGBD;

	private Placeable HMBOBOMFBBC;

	private Collider2D OBIFJMICINA;

	private bool OKKIAGLOJEN;

	private float ONMJCAIHJMP = 1f;

	private float PPMHCOBKMCN;

	protected static readonly int DKOGBJAOPPI = AnimatorParameterCache.p_WalkPressed;

	protected static readonly int EJHHMEBBCJB = AnimatorParameterCache.p_Shield;

	public int HCBDDKHPHCF
	{
		get
		{
			return _mineLevel;
		}
		set
		{
			_mineLevel = value;
			TavernManagerUI.SetMineLevel(playerNum, value);
		}
	}

	public bool NILLCIMMKJE
	{
		get
		{
			return isActioningTool;
		}
		set
		{
			isActioningTool = value;
		}
	}

	public ZoneType NNMHEPDJOHK
	{
		get
		{
			return _currentZone;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			int num = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
			if (zoneIndex != num || _currentZone != value)
			{
				_currentZone = value;
				zoneIndex = num;
				OnZoneChanged(playerNum, _currentZone, zoneIndex);
			}
		}
	}

	public Location LEOIMFNKFGA
	{
		get
		{
			return _currentLocation;
		}
		set
		{
			if (_currentLocation != value)
			{
				_currentLocation = value;
				OnZoneChanged(playerNum, _currentZone, zoneIndex);
				if (OnlineManager.IsMasterClient())
				{
					OnlineObjectsManager.instance.UpdateUntrackedObjects(LEOIMFNKFGA);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineManager.AMJGFDBFLPN[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(playerNum)] = value;
				}
			}
		}
	}

	public static void CLEIAKPOGMM(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GetPlayer(JIIGOACEIKL) == (Object)null))
		{
			((Component)GetPlayer(JIIGOACEIKL)).transform.position = IMOBLFMHKOD;
			OPHDCMJLLEC(JIIGOACEIKL).SetLocation(BAIMHDBJPDK);
			GetPlayer(JIIGOACEIKL).UpdateZone();
		}
	}

	public bool IsTavernLocationNeitherRoomNorCellar()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Utils.FNNJEGLDGKC(((Component)this).transform.position, NNMHEPDJOHK);
	}

	public bool AACILOPFOFJ()
	{
		if (ICEANLPBNKC)
		{
			return sprintBlocker;
		}
		return false;
	}

	public static void MHKHGICIDNF(int JIIGOACEIKL, Direction FCGBJEIIMBC)
	{
		if (Object.op_Implicit((Object)(object)OPHDCMJLLEC(JIIGOACEIKL)))
		{
			OPHDCMJLLEC(JIIGOACEIKL).NALNAIHNEMK(FCGBJEIIMBC);
		}
	}

	private IEnumerator DDHKHENDJBB()
	{
		explosion.SetActive(true);
		yield return CommonReferences.wait05;
		characterAnimation.FCGBJEIIMBC = Direction.Down;
		yield return CommonReferences.wait1_5;
		explosion.SetActive(false);
		eatingCandy = false;
		PlayerInputs.EnableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
	}

	public void FAIKBIJHLDN(Location BAIMHDBJPDK)
	{
		GEPOGLACOPO(BAIMHDBJPDK);
		OnChangeLocation(BAIMHDBJPDK);
		CommonReferences.MNFMOEKMJKN().AnyPlayerLocationChanged(BAIMHDBJPDK);
	}

	public void Explosion()
	{
		eatingCandy = true;
		((MonoBehaviour)this).StartCoroutine(DDHKHENDJBB());
		PlayerInputs.DisableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
	}

	public static HashSet<Object> IIPPNJJGKJB(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG;
	}

	public void KIFEAHDFOBA(int JIIGOACEIKL)
	{
		UpdateZone();
		if (LEOIMFNKFGA != 0 && trayHandler.tray.INBEHPAGAJD())
		{
			trayHandler.tray.NBODABCGELG(JIIGOACEIKL, GFNHAMCPEAK: false);
		}
	}

	[SpecialName]
	public void ABCLPGBNKDL(ZoneType AODONKKHPBP)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		int num = WorldGrid.APJABAKKKGD(((Component)this).transform.position);
		if (zoneIndex != num || _currentZone != AODONKKHPBP)
		{
			_currentZone = AODONKKHPBP;
			zoneIndex = num;
			OnZoneChanged(playerNum, _currentZone, zoneIndex);
		}
	}

	public void KickOut(HitDetection NOCOHCGPMFF = null)
	{
		if ((Object)(object)hitDetection != (Object)null)
		{
			HandleSendOut(NOCOHCGPMFF);
		}
	}

	public static PlayerController GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void SetDirection(Direction FCGBJEIIMBC)
	{
		characterAnimation.SetDirection(FCGBJEIIMBC);
	}

	private void IFHFNDELKOP()
	{
		try
		{
			CLLMOGFJLEB();
			if (Utils.FFLNGLMHLBO() && characterSaveBeforeHalloweenSkin != null)
			{
				characterCreator.SetHumanInfo(characterSaveBeforeHalloweenSkin);
				characterSaveBeforeHalloweenSkin = null;
			}
			HCBDDKHPHCF = 0;
			LFDHFGIPDKJ();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in PlayerController.OnPlayerSleep: " + ex.Message));
		}
	}

	public void SetLocation(Location BAIMHDBJPDK)
	{
		OnChangeLocation?.Invoke(BAIMHDBJPDK);
		CommonReferences.GGFJGHHHEJC.AnyPlayerLocationChanged(BAIMHDBJPDK);
		LEOIMFNKFGA = BAIMHDBJPDK;
		NNMHEPDJOHK = ZoneType.None;
	}

	public void SetVibrationToggle(int HPGKDNIHFMJ)
	{
		CIEFNGKPNOM = HPGKDNIHFMJ == 1;
	}

	public void PlayerBark(string GAGJHPKONIC)
	{
		if (Time.time > PPMHCOBKMCN)
		{
			DialogueManager.Bark(GAGJHPKONIC, ((Component)this).transform);
			PPMHCOBKMCN = Time.time + 5f;
		}
	}

	public void SetSprintingToggle(int JHGPIMILLBN)
	{
		if (JHGPIMILLBN == 1)
		{
			HICJPMOHBDM = false;
			ODNANDGFNFH = false;
			ICEANLPBNKC = ODNANDGFNFH;
		}
		else
		{
			HICJPMOHBDM = true;
			ODNANDGFNFH = false;
			ICEANLPBNKC = ODNANDGFNFH;
		}
	}

	private void Start()
	{
		GameManager.OnPlayerJoined(this);
		OthersMenuUI.GGFJGHHHEJC.SetAutoRun(GetPlayerNum());
		OthersMenuUI.GGFJGHHHEJC.SetVibration(GetPlayerNum());
		if (playerNum > 1)
		{
			PluginsGameData.singlePlayerOffline = false;
		}
	}

	private static bool NBAPLJMGFNP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public static PlayerController HGJCFHPNFBI()
	{
		for (int i = 0; i < GJBBNHCMNJN.Length; i += 0)
		{
			if (!((Object)(object)((Component)GJBBNHCMNJN[i]).gameObject.GetComponent<PhotonView>() == (Object)null) && ((Component)GJBBNHCMNJN[i]).gameObject.GetComponent<PhotonView>().IsMine)
			{
				return GJBBNHCMNJN[i];
			}
		}
		return null;
	}

	public static HashSet<Object> GetTriggerEnablers(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG;
	}

	public static void RemoveMovementBlocker(Object MOBFJEDPIPM)
	{
		PlayerController[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (PlayerController playerController in gJBBNHCMNJN)
		{
			if (!((Object)(object)playerController == (Object)null))
			{
				playerController.KCOCHCLANLH.Remove(MOBFJEDPIPM);
			}
		}
	}

	private void NCDBCDJKPLA()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
		NCFKAEBLMJN(this);
		PluginsGameData.singlePlayerOffline = true;
		for (int i = 1; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] != (Object)null && i > 0)
			{
				PluginsGameData.singlePlayerOffline = true;
				break;
			}
		}
		if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
		{
			GameManager.OnPlayerDisconnected(this);
		}
	}

	public bool HIBMABFALDC()
	{
		return CIEFNGKPNOM;
	}

	private void DPNAJMJBEHO()
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		if (!characterAnimation.animator.GetBool(EJHHMEBBCJB))
		{
			return;
		}
		if (moving && !autoMoving && KCOCHCLANLH.Count <= 1)
		{
			IBNMJHMLIMI = EODIDNILDIF;
			for (int i = 1; i < additionalDisplacement.Count; i++)
			{
				IBNMJHMLIMI += additionalDisplacement[i].PHMBKHLFPAP(characterAnimation.FCGBJEIIMBC, Vector2.op_Implicit(((Component)this).transform.position));
			}
			IBNMJHMLIMI *= shieldSpeed;
			HAFJAJKAPEO(Vector2.op_Implicit(IBNMJHMLIMI));
		}
		else if (rb.velocity != Vector2.zero && !autoMoving)
		{
			HAFJAJKAPEO(Vector3.zero);
		}
	}

	private IEnumerator KIABKHBBPCH()
	{
		explosion.SetActive(true);
		yield return CommonReferences.wait05;
		characterAnimation.FCGBJEIIMBC = Direction.Down;
		yield return CommonReferences.wait1_5;
		explosion.SetActive(false);
		eatingCandy = false;
		PlayerInputs.EnableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
	}

	public static void LLAFBAEFPLI(int JIIGOACEIKL, Object MOBFJEDPIPM)
	{
		if (KJLLBGGILAK(JIIGOACEIKL))
		{
			GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG.Remove(MOBFJEDPIPM);
		}
	}

	private IEnumerator AGCBGOOMFNC(Vector2 IMOBLFMHKOD, Direction LEPMPBGABLM)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		GoToPosition(IMOBLFMHKOD, KLGOCJMGKFO: true);
		while (!GoToPosition(IMOBLFMHKOD, KLGOCJMGKFO: false))
		{
			yield return null;
		}
		yield return CommonReferences.wait02;
		SetDirection(LEPMPBGABLM);
	}

	private void NKLKNPFCIBO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		EODIDNILDIF = Vector2.op_Implicit(Vector3.zero);
	}

	private void NEPDNLPCCON()
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		CalculateWaterDepth();
		if (OnlineManager.IgnoreDuringOnline(playerNum))
		{
			return;
		}
		if (KCOCHCLANLH.Count > 0 && !ShopUI.AGNKKAPMHLN(playerNum).HDEPMJIDJEM())
		{
			MECIOOGOLHN();
			return;
		}
		if (textInputBlockerEnabled || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || DevConsole.instance.opened)
		{
			MECIOOGOLHN();
			return;
		}
		if (PauseMenuUI.GGFJGHHHEJC.BGLJFMHCFJF())
		{
			MECIOOGOLHN();
			return;
		}
		if (autoMoving)
		{
			autoMoving = false;
			moving = false;
			return;
		}
		if (!playerCollider.isTrigger && CGFGDMHPEPG.Count > 0)
		{
			playerCollider.isTrigger = true;
			if (OnlineManager.PlayingOnline())
			{
				onlinePlayer.SendEnableTrigger(BJFHJCFOEHG: false);
			}
		}
		else if (playerCollider.isTrigger && CGFGDMHPEPG.Count <= 0)
		{
			playerCollider.isTrigger = false;
			if (OnlineManager.PlayingOnline())
			{
				onlinePlayer.PHELBIHMFHC(BJFHJCFOEHG: false);
			}
		}
		horizontalMove = PlayerInputs.GetPlayer(playerNum).GetAxis("Set Quality to ");
		verticalMove = PlayerInputs.DEGBDMMDIIL(playerNum).GetAxis("Region changed to: ");
		if (Mathf.Abs(horizontalMove) <= 1984f)
		{
			horizontalMove = 1363f;
		}
		if (Mathf.Abs(verticalMove) <= 447f)
		{
			verticalMove = 1175f;
		}
		characterAnimation.SetBool(DKOGBJAOPPI, horizontalMove == 1340f && verticalMove != 1061f, HALNIEBONKH: true);
		EODIDNILDIF = new Vector2(horizontalMove, verticalMove);
		EODIDNILDIF = Vector2.op_Implicit(Vector3.Normalize(Vector2.op_Implicit(EODIDNILDIF)));
		SetSprintingHold();
		if (EODIDNILDIF != Vector2.zero)
		{
			characterAnimation.FCGBJEIIMBC = Utils.LFOGGLLPPBI(((Vector2)(ref EODIDNILDIF)).normalized, characterAnimation.FCGBJEIIMBC);
			currentMoveTime = 1691f;
			moving = true;
			OnPlayerMoving();
			OnPlayerMovingWithNumber(playerNum);
		}
		characterAnimation.IHHBOLPDMCJ(moving);
		characterAnimation.IGONGEODOFP = IsSprinting();
	}

	public void AKOEDNPMFED(Direction FCGBJEIIMBC)
	{
		characterAnimation.SetDirection(FCGBJEIIMBC);
	}

	public static void TeleportPlayer(int JIIGOACEIKL, Vector3 IMOBLFMHKOD, Location BAIMHDBJPDK)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GetPlayer(JIIGOACEIKL) == (Object)null))
		{
			((Component)GetPlayer(JIIGOACEIKL)).transform.position = IMOBLFMHKOD;
			GetPlayer(JIIGOACEIKL).SetLocation(BAIMHDBJPDK);
			GetPlayer(JIIGOACEIKL).UpdateZone();
		}
	}

	public static void GHMJDCKBPHP(Object MOBFJEDPIPM)
	{
		PlayerController[] gJBBNHCMNJN = GJBBNHCMNJN;
		for (int i = 1; i < gJBBNHCMNJN.Length; i += 0)
		{
			PlayerController playerController = gJBBNHCMNJN[i];
			if (!((Object)(object)playerController == (Object)null) && !playerController.CGFGDMHPEPG.Contains(MOBFJEDPIPM))
			{
				playerController.CGFGDMHPEPG.Add(MOBFJEDPIPM);
			}
		}
	}

	private void PKBBLGHIEGH(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		EODIDNILDIF = Vector2.op_Implicit(Vector3.zero);
	}

	private void FixedUpdate()
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IgnoreDuringOnline(playerNum))
		{
			return;
		}
		if (moving && !autoMoving && KCOCHCLANLH.Count <= 0)
		{
			NAPCGOBFECM = speed;
			if (ICEANLPBNKC && !sprintBlocker)
			{
				NAPCGOBFECM *= sprintMultiplier;
			}
			if (PerksDatabaseAccessor.HasAnyOnlinePlayerUnlockedPerk(7))
			{
				NAPCGOBFECM += speed * (float)PerksDatabaseAccessor.GetPlayerPerkValue(7) / 100f;
			}
			if (inWater)
			{
				NAPCGOBFECM *= Mathf.Lerp(1f, 0.6f, Mathf.Min(1f, waterInteractionController.waterDepth / waterInteractionController.maxDistanceDepth));
			}
			GFJIJLHFNAL = EODIDNILDIF;
			for (int i = 0; i < additionalDisplacement.Count; i++)
			{
				GFJIJLHFNAL += additionalDisplacement[i].GetDisplacement(characterAnimation.FCGBJEIIMBC, Vector2.op_Implicit(((Component)this).transform.position));
			}
			GFJIJLHFNAL *= NAPCGOBFECM;
			if (PiratesGameManager.Playing)
			{
				GFJIJLHFNAL.y *= 0.6f;
			}
			else
			{
				GFJIJLHFNAL.y *= 0.85f;
			}
			HAFJAJKAPEO(Vector2.op_Implicit(GFJIJLHFNAL));
		}
		else if (rb.velocity != Vector2.zero && !autoMoving)
		{
			HAFJAJKAPEO(Vector3.zero);
		}
		EENBFHGDDEE();
	}

	private void HCEDMLJNOBL()
	{
		GameManager.OnPlayerJoined(this);
		OthersMenuUI.AFFGPMFKEFH().OIGCEBBNMPN(KLIHELDIPDP());
		OthersMenuUI.AFFGPMFKEFH().HLOPPMLOIDJ(KLIHELDIPDP());
		if (playerNum > 0)
		{
			PluginsGameData.singlePlayerOffline = false;
		}
	}

	private static void NCFKAEBLMJN(PlayerController ALCHPIJNJAI)
	{
		GJBBNHCMNJN[ALCHPIJNJAI.GetPlayerNum()] = null;
	}

	public static void IMLMLIIIJCH(int JIIGOACEIKL, Object MOBFJEDPIPM)
	{
		if (NBAPLJMGFNP(JIIGOACEIKL) && !GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG.Contains(MOBFJEDPIPM))
		{
			GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG.Add(MOBFJEDPIPM);
		}
	}

	public bool IsVibrationActive()
	{
		return CIEFNGKPNOM;
	}

	public void StartAction(Vector3 GGHMLBCCMKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (((Behaviour)this).isActiveAndEnabled)
		{
			NBJAHOBPJAP = false;
			pathRequestInfo.PMBNLIOPNOH(((Component)this).transform.position, GGHMLBCCMKL, FDDJKPPNLKG);
			PathRequestManager.RequestPath(pathRequestInfo);
		}
	}

	private void GKMNPFPJEPP(int JIIGOACEIKL)
	{
		UpdateZone();
	}

	private IEnumerator BAOADAONMCN(Vector2 IMOBLFMHKOD, Direction LEPMPBGABLM)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		GoToPosition(IMOBLFMHKOD, KLGOCJMGKFO: true);
		while (!GoToPosition(IMOBLFMHKOD, KLGOCJMGKFO: false))
		{
			yield return null;
		}
		yield return CommonReferences.wait02;
		SetDirection(LEPMPBGABLM);
	}

	[SpecialName]
	public void IGJDOHFFGMJ(Location AODONKKHPBP)
	{
		if (_currentLocation != AODONKKHPBP)
		{
			_currentLocation = AODONKKHPBP;
			OnZoneChanged(playerNum, _currentZone, zoneIndex);
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineObjectsManager.instance.UpdateUntrackedObjects(LEOIMFNKFGA);
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.AMJGFDBFLPN[OnlinePlayerDataManager.JBDEFDMGCDA(playerNum)] = AODONKKHPBP;
			}
		}
	}

	public static void AddMovementBlocker(Object MOBFJEDPIPM)
	{
		PlayerController[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (PlayerController playerController in gJBBNHCMNJN)
		{
			if (!((Object)(object)playerController == (Object)null) && !playerController.KCOCHCLANLH.Contains(MOBFJEDPIPM))
			{
				playerController.KCOCHCLANLH.Add(MOBFJEDPIPM);
				if (DecorationMode.GetPlayer(playerController.playerNum).DMBFKFLDDLH)
				{
					DecorationMode.GetPlayer(playerController.playerNum).ToggleDecorationMode();
				}
			}
		}
	}

	private static bool KJLLBGGILAK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public static int GetActivePlayerCount()
	{
		int num = 0;
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] != (Object)null)
			{
				num++;
			}
		}
		Debug.Log((object)("Active Player Count: " + num));
		return num;
	}

	private void LFDHFGIPDKJ()
	{
		sortingGroup.sortingOrder = 0;
		Utils.ELNJMNKOACA(((Component)this).gameObject, 11);
	}

	public bool JNBCHKDAFEC()
	{
		if (ICEANLPBNKC)
		{
			return sprintBlocker;
		}
		return false;
	}

	public static void AddTriggerEnabler(int JIIGOACEIKL, Object MOBFJEDPIPM)
	{
		if (KJLLBGGILAK(JIIGOACEIKL) && !GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG.Contains(MOBFJEDPIPM))
		{
			GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG.Add(MOBFJEDPIPM);
		}
	}

	public bool IsInCityArea()
	{
		if (LEOIMFNKFGA != Location.City && LEOIMFNKFGA != Location.Blacksmith && LEOIMFNKFGA != Location.Sawmill)
		{
			return LEOIMFNKFGA == Location.CityTavern;
		}
		return true;
	}

	private void OKPIONFMGEI(int JIIGOACEIKL)
	{
		UpdateZone();
	}

	public bool IsSprinting()
	{
		if (ICEANLPBNKC)
		{
			return !sprintBlocker;
		}
		return false;
	}

	public Vector3 GetPosition()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)this).transform.position;
	}

	public void KickWithForce(Vector3 JBMDOGNFIGJ)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(MFAKADCMNAG(JBMDOGNFIGJ));
	}

	public void CalculateWaterDepth()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (LEOIMFNKFGA == Location.Beach || LEOIMFNKFGA == Location.Forest)
		{
			inWater = WorldGrid.AOPAJANIPDB(((Component)this).transform.position);
			if (((Component)waterInteractionController).gameObject.activeSelf != inWater)
			{
				((Component)waterInteractionController).gameObject.SetActive(inWater);
			}
		}
		else if (inWater)
		{
			inWater = false;
			((Component)waterInteractionController).gameObject.SetActive(false);
		}
	}

	private void NJKHCOHADCL()
	{
		if (HKNFMAAKEDI != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKNFMAAKEDI);
			HKNFMAAKEDI = null;
		}
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance = TutorialManager.GGFJGHHHEJC;
			instance.OnPopUp = (Action)Delegate.Remove(instance.OnPopUp, new Action(PKBBLGHIEGH));
		}
		if ((Object)(object)PauseMenuUI.BDAGIEIJOOG() != (Object)null)
		{
			PauseMenuUI instance2 = PauseMenuUI.GGFJGHHHEJC;
			instance2.OnUIOpen = (Action<int>)Delegate.Remove(instance2.OnUIOpen, new Action<int>(PKBBLGHIEGH));
		}
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(KIFEAHDFOBA));
		}
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(gridController.JFPMFMKNNKL));
	}

	public void SetSprintingHold()
	{
		if (MainUI.IsAnyUIOpen(playerNum))
		{
			return;
		}
		if (!HICJPMOHBDM)
		{
			if (!ODNANDGFNFH)
			{
				ICEANLPBNKC = PlayerInputs.GetPlayer(playerNum).GetButton("SprintHoldAction");
			}
		}
		else if (PlayerInputs.GetPlayer(playerNum).GetButtonDown("SprintHoldAction"))
		{
			ODNANDGFNFH = !ODNANDGFNFH;
			ICEANLPBNKC = ODNANDGFNFH;
		}
	}

	public static void RemoveTriggerEnabler(Object MOBFJEDPIPM)
	{
		PlayerController[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (PlayerController playerController in gJBBNHCMNJN)
		{
			if (!((Object)(object)playerController == (Object)null))
			{
				playerController.CGFGDMHPEPG.Remove(MOBFJEDPIPM);
			}
		}
	}

	public static void JMAIKINGIFL(int JIIGOACEIKL, Object MOBFJEDPIPM)
	{
		if (NBAPLJMGFNP(JIIGOACEIKL))
		{
			GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG.Remove(MOBFJEDPIPM);
		}
	}

	public bool IsInPetShop()
	{
		return LEOIMFNKFGA == Location.PetShop;
	}

	private void EENBFHGDDEE()
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		if (!characterAnimation.animator.GetBool(EJHHMEBBCJB))
		{
			return;
		}
		if (moving && !autoMoving && KCOCHCLANLH.Count <= 0)
		{
			IBNMJHMLIMI = EODIDNILDIF;
			for (int i = 0; i < additionalDisplacement.Count; i++)
			{
				IBNMJHMLIMI += additionalDisplacement[i].GetDisplacement(characterAnimation.FCGBJEIIMBC, Vector2.op_Implicit(((Component)this).transform.position));
			}
			IBNMJHMLIMI *= shieldSpeed;
			HAFJAJKAPEO(Vector2.op_Implicit(IBNMJHMLIMI));
		}
		else if (rb.velocity != Vector2.zero && !autoMoving)
		{
			HAFJAJKAPEO(Vector3.zero);
		}
	}

	public static void AddTriggerEnabler(Object MOBFJEDPIPM)
	{
		PlayerController[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (PlayerController playerController in gJBBNHCMNJN)
		{
			if (!((Object)(object)playerController == (Object)null) && !playerController.CGFGDMHPEPG.Contains(MOBFJEDPIPM))
			{
				playerController.CGFGDMHPEPG.Add(MOBFJEDPIPM);
			}
		}
	}

	private void BEBMOLPGFHG()
	{
		sortingGroup.sortingOrder = 1;
		Utils.ELNJMNKOACA(((Component)this).gameObject, -110);
	}

	public void UpdateZone()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		NNMHEPDJOHK = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position);
	}

	public static void RemoveTriggerEnabler(int JIIGOACEIKL, Object MOBFJEDPIPM)
	{
		if (KJLLBGGILAK(JIIGOACEIKL))
		{
			GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG.Remove(MOBFJEDPIPM);
		}
	}

	private void HAFJAJKAPEO(Vector3 OOKKLAOFELJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		rb.velocity = Vector2.op_Implicit(OOKKLAOFELJ);
	}

	public static HashSet<Object> CMGLCNOGIJP(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL].CGFGDMHPEPG;
	}

	public Direction OJPCHIKBJCC()
	{
		return characterAnimation.FCGBJEIIMBC;
	}

	private static void HNNMKCLBFOH(PlayerController HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"CurrentThemeSection");
			return;
		}
		if (GameManager.FGFJEGOEDKJ())
		{
			if (((Component)HACPNLAPCCC).gameObject.GetComponent<PhotonView>().IsMine)
			{
				Debug.Log((object)"MoveDirection");
			}
			else
			{
				Debug.Log((object)"qualityWater");
			}
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i += 0)
		{
			if (!((Object)(object)GJBBNHCMNJN[i] != (Object)null))
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.playerNum = i;
				if (HACPNLAPCCC.playerNum == 0)
				{
					((Object)((Component)HACPNLAPCCC).gameObject).name = "Yes";
				}
				else if (HACPNLAPCCC.playerNum > 1)
				{
					((Object)((Component)HACPNLAPCCC).gameObject).name = " " + HACPNLAPCCC.playerNum;
				}
				if (i == 5 && !OnlineManager.PlayingOnline())
				{
					((Component)HACPNLAPCCC).gameObject.tag = "Received RPC SetInteger {0} with value {1} on {2}. Setting animator parameter.";
					HACPNLAPCCC.hitCollider.tag = "ProceduralMine instance is null when trying to assign mine ID.";
					HACPNLAPCCC.trayHandler.playerNum = 0;
					HACPNLAPCCC.fishingController.playerNum = 6;
					HACPNLAPCCC.fishingController.fishingHook.playerNum = 5;
					HACPNLAPCCC.IGJDOHFFGMJ(Location.Tavern);
				}
				else if (OnlineManager.PlayingOnline() && !((Component)HACPNLAPCCC).gameObject.GetComponent<PhotonView>().IsMine)
				{
					((Component)HACPNLAPCCC).gameObject.tag = "Eyebrows";
				}
				else if (i >= 0)
				{
					((Component)HACPNLAPCCC).gameObject.tag = "Left Control";
				}
				Debug.Log((object)(" / " + i), (Object)(object)((Component)HACPNLAPCCC).gameObject);
				return;
			}
		}
		Debug.LogWarning((object)"Dialogue System/Conversation/NeutralInTavern/Entry/17/Dialogue Text");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void OnDestroy()
	{
		if (GameManager.CIOEICMHCCK)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
		NCFKAEBLMJN(this);
		PluginsGameData.singlePlayerOffline = true;
		for (int i = 0; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] != (Object)null && i > 1)
			{
				PluginsGameData.singlePlayerOffline = false;
				break;
			}
		}
		if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
		{
			GameManager.OnPlayerDisconnected(this);
		}
	}

	private void MMAMJDLONFA()
	{
		if (HKNFMAAKEDI != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKNFMAAKEDI);
			HKNFMAAKEDI = null;
		}
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance = TutorialManager.GGFJGHHHEJC;
			instance.OnPopUp = (Action)Delegate.Remove(instance.OnPopUp, new Action(PKBBLGHIEGH));
		}
		if ((Object)(object)PauseMenuUI.EKDNJDJHONF() != (Object)null)
		{
			PauseMenuUI pauseMenuUI = PauseMenuUI.EKDNJDJHONF();
			pauseMenuUI.OnUIOpen = (Action<int>)Delegate.Remove(pauseMenuUI.OnUIOpen, new Action<int>(PKBBLGHIEGH));
		}
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnTravel = (Action<int>)Delegate.Remove(instance2.OnTravel, new Action<int>(OnTravel));
		}
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(gridController.JFPMFMKNNKL));
	}

	public int KLIHELDIPDP()
	{
		if (playerNum == 0)
		{
			CAAMEEBOAOF(this);
		}
		return playerNum;
	}

	public int GetPlayerNum()
	{
		if (playerNum == 0)
		{
			CAAMEEBOAOF(this);
		}
		return playerNum;
	}

	private void OnDisable()
	{
		if (HKNFMAAKEDI != null)
		{
			((MonoBehaviour)this).StopCoroutine(HKNFMAAKEDI);
			HKNFMAAKEDI = null;
		}
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance = TutorialManager.GGFJGHHHEJC;
			instance.OnPopUp = (Action)Delegate.Remove(instance.OnPopUp, new Action(PKBBLGHIEGH));
		}
		if ((Object)(object)PauseMenuUI.GGFJGHHHEJC != (Object)null)
		{
			PauseMenuUI instance2 = PauseMenuUI.GGFJGHHHEJC;
			instance2.OnUIOpen = (Action<int>)Delegate.Remove(instance2.OnUIOpen, new Action<int>(PKBBLGHIEGH));
		}
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
			instance3.OnTravel = (Action<int>)Delegate.Remove(instance3.OnTravel, new Action<int>(OnTravel));
		}
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(gridController.SetPlayerLayerEarthFocus));
	}

	public void NALNAIHNEMK(Direction FCGBJEIIMBC)
	{
		characterAnimation.SetDirection(FCGBJEIIMBC);
	}

	public static PlayerController GetOnlinePlayer()
	{
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if (!((Object)(object)((Component)GJBBNHCMNJN[i]).gameObject.GetComponent<PhotonView>() == (Object)null) && ((Component)GJBBNHCMNJN[i]).gameObject.GetComponent<PhotonView>().IsMine)
			{
				return GJBBNHCMNJN[i];
			}
		}
		return null;
	}

	[SpecialName]
	public void GEPOGLACOPO(Location AODONKKHPBP)
	{
		if (_currentLocation != AODONKKHPBP)
		{
			_currentLocation = AODONKKHPBP;
			OnZoneChanged(playerNum, _currentZone, zoneIndex);
			if (OnlineManager.IsMasterClient())
			{
				OnlineObjectsManager.instance.UpdateUntrackedObjects(LEOIMFNKFGA);
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.AJHKLAABCOC()[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(playerNum)] = AODONKKHPBP;
			}
		}
	}

	public static int GetPlayerNum(PlayerController GBANLDHOADN)
	{
		if (!GJBBNHCMNJN.Contains(GBANLDHOADN))
		{
			Debug.LogError((object)"Player is not in the list");
			return -1;
		}
		return GBANLDHOADN.GetPlayerNum();
	}

	public static HashSet<Object> GetMovementBlockers(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL].KCOCHCLANLH;
	}

	public bool IsTavernLocation()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Utils.EJPFCKFEMJF(((Component)this).transform.position);
	}

	public static bool IsPlayerDirectionLeftOrRight(int JIIGOACEIKL)
	{
		if (GetPlayerDirection(JIIGOACEIKL) != Direction.Left)
		{
			return GetPlayerDirection(JIIGOACEIKL) == Direction.Right;
		}
		return true;
	}

	public static void RemoveMovementBlocker(int JIIGOACEIKL, Object MOBFJEDPIPM)
	{
		if (KJLLBGGILAK(JIIGOACEIKL))
		{
			GJBBNHCMNJN[JIIGOACEIKL].KCOCHCLANLH.Remove(MOBFJEDPIPM);
		}
	}

	private IEnumerator CNMNEGKPHGE()
	{
		explosion.SetActive(true);
		yield return CommonReferences.wait05;
		characterAnimation.FCGBJEIIMBC = Direction.Down;
		yield return CommonReferences.wait1_5;
		explosion.SetActive(false);
		eatingCandy = false;
		PlayerInputs.EnableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
	}

	private static void CAAMEEBOAOF(PlayerController HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Trying to add a player that's already on the list.");
			return;
		}
		if (GameManager.PlayingOnline())
		{
			if (((Component)HACPNLAPCCC).gameObject.GetComponent<PhotonView>().IsMine)
			{
				Debug.Log((object)"This is the local player");
			}
			else
			{
				Debug.Log((object)"This is a networked player");
			}
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if (!((Object)(object)GJBBNHCMNJN[i] != (Object)null))
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.playerNum = i;
				if (HACPNLAPCCC.playerNum == 1)
				{
					((Object)((Component)HACPNLAPCCC).gameObject).name = "Player";
				}
				else if (HACPNLAPCCC.playerNum > 1)
				{
					((Object)((Component)HACPNLAPCCC).gameObject).name = "Player" + HACPNLAPCCC.playerNum;
				}
				if (i == 2 && !OnlineManager.PlayingOnline())
				{
					((Component)HACPNLAPCCC).gameObject.tag = "Player2";
					HACPNLAPCCC.hitCollider.tag = "HitCollider2";
					HACPNLAPCCC.trayHandler.playerNum = 2;
					HACPNLAPCCC.fishingController.playerNum = 2;
					HACPNLAPCCC.fishingController.fishingHook.playerNum = 2;
					HACPNLAPCCC.LEOIMFNKFGA = Location.Tavern;
				}
				else if (OnlineManager.PlayingOnline() && !((Component)HACPNLAPCCC).gameObject.GetComponent<PhotonView>().IsMine)
				{
					((Component)HACPNLAPCCC).gameObject.tag = "OnlinePlayer";
				}
				else if (i >= 2)
				{
					((Component)HACPNLAPCCC).gameObject.tag = "Untagged";
				}
				Debug.Log((object)("New Player added as player " + i), (Object)(object)((Component)HACPNLAPCCC).gameObject);
				return;
			}
		}
		Debug.LogWarning((object)"Trying to add player but player list is full.");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public static PlayerController OPHDCMJLLEC(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	[SpecialName]
	public bool BIBGIOPFJAF()
	{
		return isActioningTool;
	}

	public bool InInteractRange(GameObject MANJHEAHPIH)
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		HMBOBOMFBBC = MANJHEAHPIH.GetComponent<Placeable>();
		OKKIAGLOJEN = false;
		if ((Object)(object)HMBOBOMFBBC != (Object)null && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
		{
			for (int i = 0; i < HMBOBOMFBBC.itemSpace.buildSquares.Length; i++)
			{
				OKKIAGLOJEN = Vector2.Distance(Vector2.op_Implicit(((Component)HMBOBOMFBBC.itemSpace.buildSquares[i]).transform.position), Vector2.op_Implicit(((Component)this).transform.position)) < ONMJCAIHJMP;
				if (OKKIAGLOJEN)
				{
					break;
				}
			}
		}
		else if ((Object)(object)(OBIFJMICINA = MANJHEAHPIH.GetComponent<Collider2D>()) != (Object)null)
		{
			OKKIAGLOJEN = Vector2.Distance(OBIFJMICINA.ClosestPoint(Vector2.op_Implicit(((Component)this).transform.position)), Vector2.op_Implicit(((Component)this).transform.position)) < ONMJCAIHJMP;
		}
		else
		{
			OKKIAGLOJEN = Vector2.Distance(Vector2.op_Implicit(MANJHEAHPIH.transform.position), Vector2.op_Implicit(((Component)this).transform.position)) < ONMJCAIHJMP;
		}
		return OKKIAGLOJEN;
	}

	public static void AddMovementBlocker(int JIIGOACEIKL, Object MOBFJEDPIPM, bool ANJCLPDCJHL = false)
	{
		if (KJLLBGGILAK(JIIGOACEIKL) && !GJBBNHCMNJN[JIIGOACEIKL].KCOCHCLANLH.Contains(MOBFJEDPIPM))
		{
			GJBBNHCMNJN[JIIGOACEIKL].KCOCHCLANLH.Add(MOBFJEDPIPM);
			if (ANJCLPDCJHL && DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				DecorationMode.GetPlayer(JIIGOACEIKL).ToggleDecorationMode();
			}
		}
	}

	private bool HCJAJOGHDKM(Vector2 AEGIODEOOIJ)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		if (!NBJAHOBPJAP)
		{
			return false;
		}
		if (!playerCollider.isTrigger)
		{
			playerCollider.isTrigger = true;
			if (OnlineManager.PlayingOnline() && ((Behaviour)this).enabled)
			{
				onlinePlayer.SendEnableTrigger(BJFHJCFOEHG: true);
			}
		}
		if (GANGIDPBPBE)
		{
			rb.MovePosition(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), AEGIODEOOIJ, speed * 1.1f * Time.fixedDeltaTime));
		}
		else if (Vector2.Distance(Vector2.op_Implicit(((Component)this).transform.position), AEGIODEOOIJ) < Vector2.Distance(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(AHFEIBMOHAN)))
		{
			GANGIDPBPBE = true;
			rb.velocity = Vector2.zero;
			rb.MovePosition(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), AEGIODEOOIJ, speed * 1.1f * Time.fixedDeltaTime));
		}
		else
		{
			rb.MovePosition(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(AHFEIBMOHAN), speed * 1.1f * Time.fixedDeltaTime));
			if (Utils.BMBMPKNANAC(((Component)this).transform.position) == Utils.BMBMPKNANAC(AHFEIBMOHAN))
			{
				if (OHANGILJGJI < GDHHIIMLBEL.Length - 1 && OHANGILJGJI >= 0)
				{
					OHANGILJGJI++;
					AHFEIBMOHAN = Vector2.op_Implicit(GDHHIIMLBEL[OHANGILJGJI]);
				}
				else
				{
					OHANGILJGJI++;
				}
			}
		}
		characterAnimation.SetBool(DKOGBJAOPPI, EGFGNGJGBOP: true);
		Vector2 dPNLDLEHMHO = Vector2.op_Implicit(((Component)this).transform.position) - AJLJHLHGGBD;
		characterAnimation.FCGBJEIIMBC = Utils.LFOGGLLPPBI(dPNLDLEHMHO, characterAnimation.FCGBJEIIMBC);
		AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		characterAnimation.CNKHDCIKHCO = true;
		characterAnimation.IGONGEODOFP = false;
		if (OHANGILJGJI == GDHHIIMLBEL.Length)
		{
			GANGIDPBPBE = true;
		}
		return Vector2.op_Implicit(((Component)this).transform.position) == AEGIODEOOIJ;
	}

	public void KGMDOJACJLC(Vector2 IMOBLFMHKOD, Direction LEPMPBGABLM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(AGCBGOOMFNC(IMOBLFMHKOD, LEPMPBGABLM));
	}

	public static Vector3 GetPlayerPosition(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GetPlayer(JIIGOACEIKL)).transform.position;
	}

	public Direction GetDirection()
	{
		return characterAnimation.FCGBJEIIMBC;
	}

	private void Update()
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		CalculateWaterDepth();
		if (OnlineManager.IgnoreDuringOnline(playerNum))
		{
			return;
		}
		if (KCOCHCLANLH.Count > 0 && !ShopUI.Get(playerNum).IsOpen())
		{
			MECIOOGOLHN();
			return;
		}
		if (textInputBlockerEnabled || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || DevConsole.instance.opened)
		{
			MECIOOGOLHN();
			return;
		}
		if (PauseMenuUI.GGFJGHHHEJC.IsOpen())
		{
			MECIOOGOLHN();
			return;
		}
		if (autoMoving)
		{
			autoMoving = false;
			moving = false;
			return;
		}
		if (!playerCollider.isTrigger && CGFGDMHPEPG.Count > 0)
		{
			playerCollider.isTrigger = true;
			if (OnlineManager.PlayingOnline())
			{
				onlinePlayer.SendEnableTrigger(BJFHJCFOEHG: true);
			}
		}
		else if (playerCollider.isTrigger && CGFGDMHPEPG.Count <= 0)
		{
			playerCollider.isTrigger = false;
			if (OnlineManager.PlayingOnline())
			{
				onlinePlayer.SendEnableTrigger(BJFHJCFOEHG: false);
			}
		}
		horizontalMove = PlayerInputs.GetPlayer(playerNum).GetAxis("HorizontalMove");
		verticalMove = PlayerInputs.GetPlayer(playerNum).GetAxis("VerticalMove");
		if (Mathf.Abs(horizontalMove) <= 0.15f)
		{
			horizontalMove = 0f;
		}
		if (Mathf.Abs(verticalMove) <= 0.15f)
		{
			verticalMove = 0f;
		}
		characterAnimation.SetBool(DKOGBJAOPPI, horizontalMove != 0f || verticalMove != 0f);
		EODIDNILDIF = new Vector2(horizontalMove, verticalMove);
		EODIDNILDIF = Vector2.op_Implicit(Vector3.Normalize(Vector2.op_Implicit(EODIDNILDIF)));
		SetSprintingHold();
		if (EODIDNILDIF != Vector2.zero)
		{
			characterAnimation.FCGBJEIIMBC = Utils.LFOGGLLPPBI(((Vector2)(ref EODIDNILDIF)).normalized, characterAnimation.FCGBJEIIMBC);
			currentMoveTime = 0.05f;
			moving = true;
			OnPlayerMoving();
			OnPlayerMovingWithNumber(playerNum);
		}
		characterAnimation.CNKHDCIKHCO = moving;
		characterAnimation.IGONGEODOFP = IsSprinting();
	}

	private void Awake()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		CAAMEEBOAOF(this);
		if ((Object)(object)rb == (Object)null)
		{
			rb = ((Component)this).GetComponent<Rigidbody2D>();
		}
		characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
		characterSaveBeforeHalloweenSkin = null;
		_currentZone = ZoneType.WithoutZone;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		gridController.SetPlayerLayerEarthFocus();
	}

	public void OnTravel(int JIIGOACEIKL)
	{
		UpdateZone();
		if (LEOIMFNKFGA != Location.Tavern && trayHandler.tray.GCJDPMOAGKP())
		{
			trayHandler.tray.MKBDMMJCGGM(JIIGOACEIKL);
		}
	}

	private IEnumerator OFDLDCHCDFK()
	{
		while (true)
		{
			yield return CommonReferences.wait1;
			UpdateZone();
		}
	}

	private void OnEnable()
	{
		HKNFMAAKEDI = ((MonoBehaviour)this).StartCoroutine(OBDIFJGNBGG());
		TutorialManager instance = TutorialManager.GGFJGHHHEJC;
		instance.OnPopUp = (Action)Delegate.Combine(instance.OnPopUp, new Action(PKBBLGHIEGH));
		PauseMenuUI instance2 = PauseMenuUI.GGFJGHHHEJC;
		instance2.OnUIOpen = (Action<int>)Delegate.Combine(instance2.OnUIOpen, new Action<int>(PKBBLGHIEGH));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnTravel = (Action<int>)Delegate.Combine(instance3.OnTravel, new Action<int>(OnTravel));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(gridController.SetPlayerLayerEarthFocus));
	}

	public bool GoToPosition(Vector2 AEGIODEOOIJ, bool KLGOCJMGKFO)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (KLGOCJMGKFO)
		{
			StartAction(Vector2.op_Implicit(AEGIODEOOIJ));
			return false;
		}
		autoMoving = true;
		if (Mathf.Abs(AEGIODEOOIJ.x - ((Component)this).transform.position.x) > 0.025f || Mathf.Abs(AEGIODEOOIJ.y - ((Component)this).transform.position.y) > 0.025f)
		{
			return HCJAJOGHDKM(AEGIODEOOIJ);
		}
		return true;
	}

	public static Direction GetPlayerDirection(int JIIGOACEIKL)
	{
		return GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
	}

	public void PlayerBarkWithI2(string ONCMMKEFCBD)
	{
		DialogueManager.BarkString(LocalisationSystem.Get(ONCMMKEFCBD), ((Component)this).transform, (Transform)null, (string)null);
	}

	public void BIBLHGFCINF(string ONCMMKEFCBD)
	{
		DialogueManager.BarkString(LocalisationSystem.Get(ONCMMKEFCBD), ((Component)this).transform, (Transform)null, (string)null);
	}

	private IEnumerator MFAKADCMNAG(Vector3 JBMDOGNFIGJ)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			characterAnimation.LookAt(Vector2.op_Implicit(JBMDOGNFIGJ));
			Vector3 val = ((Component)this).transform.position - JBMDOGNFIGJ;
			rb.AddForce(Vector2.op_Implicit(val * 200f * rb.mass));
		}
		((MonoBehaviour)this).StartCoroutine(Utils.AAGGGBAPFGJ(characterAnimation.characterAnimator));
		hitFx.SetActive(true);
		MultiAudioManager.PlayAudioObject(hitSound, ((Component)this).transform);
		PlayerInputs.DisableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
		yield return CommonReferences.wait06;
		PlayerInputs.EnableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
		trayHandler.RemoveAllDrinks(playerNum);
	}

	private IEnumerator OBDIFJGNBGG()
	{
		while (true)
		{
			yield return CommonReferences.wait1;
			UpdateZone();
		}
	}

	private void CLLMOGFJLEB()
	{
		NBJAHOBPJAP = false;
	}

	private void NEOICNJNKNL()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		HNNMKCLBFOH(this);
		if ((Object)(object)rb == (Object)null)
		{
			rb = ((Component)this).GetComponent<Rigidbody2D>();
		}
		characterAnimation.LookDirectionByAngle(new Vector2(67f, 1106f));
		characterSaveBeforeHalloweenSkin = null;
		_currentZone = ZoneType.WithoutZone;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		gridController.JFPMFMKNNKL();
	}

	private void MAIMGNMIFKG()
	{
		HKNFMAAKEDI = ((MonoBehaviour)this).StartCoroutine(OFDLDCHCDFK());
		TutorialManager instance = TutorialManager.GGFJGHHHEJC;
		instance.OnPopUp = (Action)Delegate.Combine(instance.OnPopUp, new Action(PKBBLGHIEGH));
		PauseMenuUI pauseMenuUI = PauseMenuUI.EKDNJDJHONF();
		pauseMenuUI.OnUIOpen = (Action<int>)Delegate.Combine(pauseMenuUI.OnUIOpen, new Action<int>(PKBBLGHIEGH));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(OnTravel));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(gridController.LONMBAEEJFJ));
	}

	private void PKBBLGHIEGH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		EODIDNILDIF = Vector2.op_Implicit(Vector3.zero);
	}

	public bool IsTavernLocationNotCellar()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Utils.HNDBNJNJGJM(((Component)this).transform.position, NNMHEPDJOHK);
	}

	public void HandleSendOut(HitDetection NOCOHCGPMFF)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			KickWithForce(((Component)KlaynNPC.instance).transform.position);
		}
		if (OnlineManager.PlayingOnline())
		{
			onlinePlayer.SendKick(NOCOHCGPMFF);
		}
	}

	public void GoToPositionIndependentThread(Vector2 IMOBLFMHKOD, Direction LEPMPBGABLM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(AGCBGOOMFNC(IMOBLFMHKOD, LEPMPBGABLM));
	}

	public Direction LGFDLLCHLHL()
	{
		return characterAnimation.FCGBJEIIMBC;
	}

	public void SetOnlineLocation(Location BAIMHDBJPDK)
	{
		LEOIMFNKFGA = BAIMHDBJPDK;
		OnChangeLocation(BAIMHDBJPDK);
		CommonReferences.GGFJGHHHEJC.AnyPlayerLocationChanged(BAIMHDBJPDK);
	}

	private void MECIOOGOLHN()
	{
		characterAnimation.SetBool(DKOGBJAOPPI, EGFGNGJGBOP: false);
		characterAnimation.CNKHDCIKHCO = false;
	}

	private void FDDJKPPNLKG(Vector2[] GDHHIIMLBEL, bool ALOMLDIEHJL)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (ALOMLDIEHJL && GDHHIIMLBEL.Length != 0)
		{
			this.GDHHIIMLBEL = GDHHIIMLBEL;
			OHANGILJGJI = 0;
			AHFEIBMOHAN = Vector2.op_Implicit(this.GDHHIIMLBEL[OHANGILJGJI]);
			NBJAHOBPJAP = true;
			GANGIDPBPBE = false;
			AJLJHLHGGBD = Vector2.op_Implicit(((Component)this).transform.position);
		}
	}

	private void ENDHBFLFDLN()
	{
		GetPlayer(1).KCOCHCLANLH.Clear();
		GetPlayer(2).KCOCHCLANLH.Clear();
	}

	private void LateUpdate()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.IgnoreDuringOnline(playerNum) && (!PiratesGameManager.Playing || !PiratesGameManager.IsPlayerBuried(playerNum)))
		{
			((Component)this).transform.GetChild(0).localPosition = Vector3.zero;
			((Component)this).transform.GetChild(0).position = Utils.EKCCGNEDPNO(((Component)this).transform.GetChild(0).position, playerNum);
			playerShadow.position = Utils.EKCCGNEDPNO(((Component)this).transform.GetChild(0).position + JKKKPDOPHJL, playerNum);
		}
	}

	public static void SetDirection(int JIIGOACEIKL, Direction FCGBJEIIMBC)
	{
		if (Object.op_Implicit((Object)(object)GetPlayer(JIIGOACEIKL)))
		{
			GetPlayer(JIIGOACEIKL).SetDirection(FCGBJEIIMBC);
		}
	}
}
