using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class AnimatorParameterCache
{
	[CompilerGenerated]
	private sealed class JMMCCFDNGFI
	{
		public int _hash;

		internal bool EHGFIBGGMOP(AnimatorControllerParameter p)
		{
			return p.nameHash == _hash;
		}
	}

	public static readonly int p_Hot = Animator.StringToHash("Hot");

	public static readonly int p_HotEnd = Animator.StringToHash("HotEnd");

	public static readonly int p_Cold = Animator.StringToHash("Cold");

	public static readonly int p_ColdEnd = Animator.StringToHash("ColdEnd");

	public static readonly int p_Hammer = Animator.StringToHash("Hammer");

	public static readonly int p_HammerRoof = Animator.StringToHash("HammerRoof");

	public static readonly int p_Map = Animator.StringToHash("Map");

	public static readonly int p_Saw = Animator.StringToHash("Saw");

	public static readonly int p_Open = Animator.StringToHash("Open");

	public static readonly int p_Close = Animator.StringToHash("Close");

	public static readonly int p_Crouch = Animator.StringToHash("Crouch");

	public static readonly int p_Inactive = Animator.StringToHash("Inactive");

	public static readonly int p_Leaving = Animator.StringToHash("Leaving");

	public static readonly int p_WalkTo = Animator.StringToHash("WalkTo");

	public static readonly int p_WaitEvent = Animator.StringToHash("WaitEvent");

	public static readonly int p_AvoidingWork = Animator.StringToHash("AvoidingWork");

	public static readonly int p_Avoid = Animator.StringToHash("Avoid");

	public static readonly int p_Waiting = Animator.StringToHash("Waiting");

	public static readonly int p_WaitingToServe = Animator.StringToHash("WaitingToServe");

	public static readonly int p_ServingCustomer = Animator.StringToHash("ServingCustomer");

	public static readonly int p_HittingPlayer = Animator.StringToHash("HittingPlayer");

	public static readonly int p_TakingDrink = Animator.StringToHash("TakingDrink");

	public static readonly int p_TakingFood = Animator.StringToHash("TakingFood");

	public static readonly int p_PreparingFood = Animator.StringToHash("PreparingFood");

	public static readonly int p_SwitchingFood = Animator.StringToHash("SwitchingFood");

	public static readonly int p_ThrowingSpikes = Animator.StringToHash("ThrowingSpikes");

	public static readonly int p_Club = Animator.StringToHash("Club");

	public static readonly int p_KickRowdyCustomer = Animator.StringToHash("KickRowdyCustomer");

	public static readonly int p_CalmRowdyCustomer = Animator.StringToHash("CalmRowdyCustomer");

	public static readonly int p_Hit = Animator.StringToHash("Hit");

	public static readonly int p_BringBackWorkers = Animator.StringToHash("BringBackWorkers");

	public static readonly int p_UseHold = Animator.StringToHash("UseHold");

	public static readonly int p_Mop = Animator.StringToHash("Mop");

	public static readonly int p_ServingRoomOrder = Animator.StringToHash("ServingRoomOrder");

	public static readonly int p_RentingRooms = Animator.StringToHash("RentingRooms");

	public static readonly int p_HeadingToDrinksTable = Animator.StringToHash("HeadingToDrinksTable");

	public static readonly int p_ServingTableOrder = Animator.StringToHash("ServingTableOrder");

	public static readonly int p_CleaningTable = Animator.StringToHash("CleaningTable");

	public static readonly int p_CleaningRoom = Animator.StringToHash("CleaningRoom");

	public static readonly int p_RenewingCandle = Animator.StringToHash("RenewingCandle");

	public static readonly int p_CleaningFloorDirt = Animator.StringToHash("CleaningFloorDirt");

	public static readonly int p_LightingFireplace = Animator.StringToHash("LightingFireplace");

	public static readonly int p_EatingAtTable = Animator.StringToHash("EatingAtTable");

	public static readonly int p_OrderInTable = Animator.StringToHash("OrderInTable");

	public static readonly int p_LoopPeek = Animator.StringToHash("LoopPeek");

	public static readonly int p_LoopSleep = Animator.StringToHash("LoopSleep");

	public static readonly int p_Dead = Animator.StringToHash("Dead");

	public static readonly int p_Peek = Animator.StringToHash("Peek");

	public static readonly int p_Sleep = Animator.StringToHash("Sleep");

	public static readonly int p_Look = Animator.StringToHash("Look");

	public static readonly int p_Loop = Animator.StringToHash("Loop");

	public static readonly int p_Random = Animator.StringToHash("Random");

	public static readonly int p_BirdType = Animator.StringToHash("BirdType");

	public static readonly int p_Flight = Animator.StringToHash("Flight");

	public static readonly int p_Res = Animator.StringToHash("Res");

	public static readonly int p_Scratch = Animator.StringToHash("Scratch");

	public static readonly int p_LookAround = Animator.StringToHash("LookAround");

	public static readonly int p_LeftMovement = Animator.StringToHash("LeftMovement");

	public static readonly int p_StandUp = Animator.StringToHash("StandUp");

	public static readonly int p_Hurt = Animator.StringToHash("Hurt");

	public static readonly int p_Run = Animator.StringToHash("Run");

	public static readonly int p_Idle = Animator.StringToHash("Idle");

	public static readonly int p_Moving = Animator.StringToHash("Moving");

	public static readonly int p_Running = Animator.StringToHash("Running");

	public static readonly int p_Walk = Animator.StringToHash("Walk");

	public static readonly int p_Direction = Animator.StringToHash("Direction");

	public static readonly int p_ToolRight = Animator.StringToHash("ToolRight");

	public static readonly int p_Spade = Animator.StringToHash("Spade");

	public static readonly int p_Fishing = Animator.StringToHash("Fishing");

	public static readonly int p_IdleFishing = Animator.StringToHash("IdleFishing");

	public static readonly int p_StruggleFishing = Animator.StringToHash("StruggleFishing");

	public static readonly int p_AxRight = Animator.StringToHash("AxRight");

	public static readonly int p_Mine = Animator.StringToHash("Mine");

	public static readonly int p_Till = Animator.StringToHash("Till");

	public static readonly int p_SickleDown = Animator.StringToHash("SickleDown");

	public static readonly int p_SickleUp = Animator.StringToHash("SickleUp");

	public static readonly int p_Watering = Animator.StringToHash("Watering");

	public static readonly int p_StartInteracting = Animator.StringToHash("StartInteracting");

	public static readonly int p_Interact = Animator.StringToHash("Interact");

	public static readonly int p_StartCleaning = Animator.StringToHash("StartCleaning");

	public static readonly int p_Cleaning = Animator.StringToHash("Cleaning");

	public static readonly int p_SitDown = Animator.StringToHash("SitDown");

	public static readonly int p_SitUp = Animator.StringToHash("SitUp");

	public static readonly int p_SitRight = Animator.StringToHash("SitRight");

	public static readonly int p_Stand = Animator.StringToHash("Stand");

	public static readonly int p_Eat = Animator.StringToHash("Eat");

	public static readonly int p_EatNumber = Animator.StringToHash("EatNumber");

	public static readonly int p_Shield = Animator.StringToHash("Shield");

	public static readonly int p_AimDirection = Animator.StringToHash("AimDirection");

	public static readonly int p_WalkPressed = Animator.StringToHash("WalkPressed");

	public static readonly int p_RandomLook = Animator.StringToHash("RandomLook");

	public static readonly int p_Outro = Animator.StringToHash("Outro");

	public static readonly int p_Sell = Animator.StringToHash("Sell");

	public static readonly int p_Move = Animator.StringToHash("Move");

	public static readonly int p_Sleeping = Animator.StringToHash("Sleeping");

	public static readonly int p_Eating = Animator.StringToHash("Eating");

	public static readonly int p_LickPaw = Animator.StringToHash("LickPaw");

	public static readonly int p_Yawn = Animator.StringToHash("Yawn");

	public static readonly int p_WagTail = Animator.StringToHash("WagTail");

	public static readonly int p_BendEar = Animator.StringToHash("BendEar");

	public static readonly int p_Sit = Animator.StringToHash("Sit");

	public static readonly int p_Lick = Animator.StringToHash("Lick");

	public static string LNHIGJBJEPI(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Player", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "per room";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("\n<color=#822F00>", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "ErrorJoinDefault";
		}
	}

	public static string ICAIHPCIEBH(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Received begin minigame", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Items/item_description_648", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Plant";
		}
	}

	public static string MDDNGNHBFDM(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Wilson/Bark/Bark_Bye", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Items/item_name_598";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("ReceiveRemoveOrderNinjaCustomer", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "IntroNinjaChallengeEvent/Main 2";
		}
	}

	public static string INCMGNEMKAB(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Items/item_name_687", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "CultivableDuringOneMonth";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Dialogue System/Conversation/NeutralInTavern/Entry/16/Dialogue Text", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Dialogue System/Conversation/EnterTavernDrink/Entry/5/Dialogue Text";
		}
	}

	public static string IPCCEPBIBKJ(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Creating new MinePiece in pool: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "\n<color=#BF0000>";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Tutorial/T116/Dialogue2", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Items/item_name_1135";
		}
	}

	public static string CGBIFFENAHL(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Rented Room component not found";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Bird materials empty ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Tutorial/T100/Dialogue5";
		}
	}

	public static string JDFPBOCIBDH(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("ReceiveOfferingUIClosed", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Pausing network sync until the world is loaded...";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("PlayerBed", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Player/Bark/Tutorial/T138";
		}
	}

	public static string CMLIAAJDBLB(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Duplicate item id found: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "ReceiveBuildingTutorialDone";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("tablesCleaned", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "ItemInstance is not valid.";
		}
	}

	public static string JMALJOLGCGO(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Duplicate key found: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Could not find Crop with id: ";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("popUpBuilding23", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Read";
		}
	}

	public static string EFFGPLMGMEI(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("CalmRowdyCustomer", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "openShop";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("City/Kujaku/Bark/Bye", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "BarkActor";
		}
	}

	public static string HIPMHKLNLCF(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Dialogue System/Conversation/Crowly_Standar/Entry/20/Dialogue Text", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Items/item_description_1036";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Piso {0}: Punto de aparición '{1}' seleccionado para spawn. Quedan {2} puntos disponibles.";
		}
	}

	public static string HKGBFFLINBA(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Items/item_name_1120", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "descGruel";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("HandUp", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Bouncer/";
		}
	}

	public static string KCHHBMCOBJG(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)$"{BNAJNKBCLEJ} is not active.", (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)$"{BNAJNKBCLEJ} doesn't have a parameter with that hash.", (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "";
		}
	}

	public static string MBPIGJGNNFD(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Tech", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Cat";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format(" to ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Jose D";
		}
	}

	public static string FPCMJEBHKAJ(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("F3", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "RentedRoom";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Hikari/Barks_Intro", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return " seconds.";
		}
	}

	public static string ALPINKDBKJN(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("<sprite name=\"ironNailsIcon\">", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "HotBath/Rochelle Talk";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("CheckFocusedMission", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Gass_Introduce";
		}
	}

	public static string FDGIFKOBOPG(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("disconnect_cause", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return ". ";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("LoadGameplaySceneOnline masterClient", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Player2";
		}
	}

	public static string HNMBGBOMLIE(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Food", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Disabled";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("[ActivatePuzzle] Type: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Could not get value of statistic ";
		}
	}

	public static string BOMBNJDKBPI(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Player2", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Sun";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Items/item_description_1062", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Disabled";
		}
	}

	public static string HKDNLLIPCOO(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("\n<color=#BF0000>", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "BARKBUZZ";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("UIHorizontal", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Selected Room Reset to: {0}";
		}
	}

	public static string LMLJDGKJDEK(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format(":</color> <sprite name=\"ChristmasTicket\">", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "DialogueNPC of character ";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Fullscreen Window", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "itemJam";
		}
	}

	public static string BIEOJGMCKBH(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)$"Could not find local player for the online player with the assigned bed: {BNAJNKBCLEJ}", (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "ChristmasPresentsError";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Disabled", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return " not found";
		}
	}

	public static string GKCBNJCLKDB(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "remaining ms: ";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Could not get status of achievement ";
		}
	}

	public static string JGIDFLKOPML(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("LE_21", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Xbox";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("ReceiveStartCrowlyEvent", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "_BaseMap";
		}
	}

	public static string JLBKJNMJHOC(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("No banquet barrel found with drink: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "_";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Cat Selector", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Error max zones";
		}
	}

	public static string NNPHMFLLPKA(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("DeselectPlaceableOthers", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Items/item_name_726";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("No", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "00";
		}
	}

	public static string HGCJIJFJFGL(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format(" itemInstance: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Items/item_description_618";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Send info for ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Player";
		}
	}

	public static string FKDKDAEAFAD(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("House keeper OnFailStart cleaning table ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "/";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("itemColiflowerSeeds", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Unaged Brandy";
		}
	}

	public static string FMOFONAALJA(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format(" / ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Error_SmallRoom";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Dialogue System/Conversation/Gass_Quest/Entry/17/Dialogue Text", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "[Brown2";
		}
	}

	public static string IHCNNMICHNL(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("ReceiveAddFoodToBento", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "-> ";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("CellarUnlockMessage", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Intro09";
		}
	}

	public static string OFCILOJACIK(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "UIBack";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("itemRedPotato", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "\\[BartenderGender=[^\\]]*\\]";
		}
	}

	public static string DIFCGOFLFLA(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Items/item_description_689", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "SortByType";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("ReceiveOrderRequestNinjaCustomer", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Items/item_description_1078";
		}
	}

	public static string GOGKAFDNBKA(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "/";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("qualityWater2", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "ResetTalentTree?";
		}
	}

	public static string DFAGNJFHDOD(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("UINextPage", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "itemRosemarySeeds";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("TavernName", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "ChatCommandUnlockDescription";
		}
	}

	public static string PIBKDHBPEBK(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Cycle Placeable Colors", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "application/gzip";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("SetNPCPositionAndParent", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "ReturnToBasicMood";
		}
	}

	public static string PECAOALMHED(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Unique crop not found! Unique ID: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "[PipeConnectionPuzzleUI] BuildGrid llamado sin PipePuzzleData.";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Tutorial/T300/Dialogue2", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return " ";
		}
	}

	public static string NKNDLLMKJEN(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Walk";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("fog", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "subject";
		}
	}

	public static string ALIBCLPCEEC(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("-", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Game";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Partida comprimida. Tiempo: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Quest not found in database with id: ";
		}
	}

	public static string BIACPFJMBCN(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Starting", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Dropped item ";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("Items/item_name_1052", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "NoEresDigno/MainEvent";
		}
	}

	public static string ILMOJDNODHA(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("Error in HoleInGround.OnPlayerSleep: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Dialogue System/Conversation/Crowly_Introduce/Entry/36/Dialogue Text";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format("itemShimejiMushrooms", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "ReceiveBedOccupantsInfo";
		}
	}

	public static string AOGFDGHKBOC(Animator BNAJNKBCLEJ, int OCBFLLHGDAP)
	{
		try
		{
			if (!((Behaviour)BNAJNKBCLEJ).isActiveAndEnabled)
			{
				Debug.LogWarning((object)string.Format("SAVE_DATA: fireplace saving error: ", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
				return "Back";
			}
			return Array.Find(BNAJNKBCLEJ.parameters, (AnimatorControllerParameter p) => p.nameHash == OCBFLLHGDAP).name;
		}
		catch
		{
			Debug.LogWarning((object)string.Format(" (", BNAJNKBCLEJ), (Object)(object)((Component)BNAJNKBCLEJ).gameObject);
			return "Room Index: {0}, Selected Room: {1}";
		}
	}
}
