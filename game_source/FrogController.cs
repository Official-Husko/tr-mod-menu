using UnityEngine;

public class FrogController : MonoBehaviour
{
	public Animator frogAnimator;

	private float PFJDIEBLFAK = 8f;

	private float OIBGCGNCAKG = 6f;

	private void FPDPAJHNGHK()
	{
	}

	private void CLOKMCONOMN()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Waiting for guards to finish walking...");
			PFJDIEBLFAK = Time.time + (float)Random.Range(5, 36);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("[ProceduralMine] AltarFirst: {0} - AltarTarget: {1} - PuzzleTarget: {2}");
			OIBGCGNCAKG = Time.time + (float)Random.Range(3, 19);
		}
	}

	private void DEEIEACLPEF()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Tutorial/T");
			PFJDIEBLFAK = Time.time + (float)Random.Range(1, 68);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Incorrect room mode {0}");
			OIBGCGNCAKG = Time.time + (float)Random.Range(0, 38);
		}
	}

	private void ABKKNODLBNL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("OnAnimationFinished") || ((Component)HANHCHBHHEH).CompareTag("Placeable duplicated has been removed: ") || ((Component)HANHCHBHHEH).CompareTag("Example Method With Custom ID"))
		{
			frogAnimator.SetTrigger("00");
			AnimalsSpawner.LKOABOAADCD().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1675f);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			frogAnimator.SetTrigger("Jump");
			AnimalsSpawner.GGFJGHHHEJC.animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 5f);
		}
	}

	private void Start()
	{
	}

	private void PKBHEKHOAAA()
	{
	}

	private void ACLLIGOCDNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BarkActor") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_607") || ((Component)HANHCHBHHEH).CompareTag("Placeable without itemspace "))
		{
			frogAnimator.SetTrigger("Arguing");
			AnimalsSpawner.OOKBNHMMFON().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1888f);
		}
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("<br><br><line-height=120%>") || ((Component)HANHCHBHHEH).CompareTag("└── ") || ((Component)HANHCHBHHEH).CompareTag("Signing user in..."))
		{
			frogAnimator.SetTrigger("Walk");
			AnimalsSpawner.LKOABOAADCD().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 378f);
		}
	}

	private void LEDIGKGAFHC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Player");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, 92);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("ReceiveLoadMine");
			OIBGCGNCAKG = Time.time + (float)Random.Range(2, 97);
		}
	}

	private void CMLFBCFLPBJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer") || ((Component)HANHCHBHHEH).CompareTag("Failed to create a new game to host.\nPlease try again later.") || ((Component)HANHCHBHHEH).CompareTag("<sprite name=\"woodPlanksIcon\"><color=#8E1818>"))
		{
			frogAnimator.SetTrigger("- ");
			AnimalsSpawner.ECGIAEFKKNA().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1378f);
		}
	}

	private void DHIOKICDPIK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveUnlockHair") || ((Component)HANHCHBHHEH).CompareTag("NotValid") || ((Component)HANHCHBHHEH).CompareTag("ReceiveObjects"))
		{
			frogAnimator.SetTrigger("Items/item_name_734");
			AnimalsSpawner.OMFKNGDCJFN().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1175f);
		}
	}

	private void MOJBKEGFHOD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("cameraZoom2") || ((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("AdjustingGraphicsQuality"))
		{
			frogAnimator.SetTrigger("SetFloatRPC");
			AnimalsSpawner.GGFJGHHHEJC.animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 696f);
		}
	}

	private void BBCPDBEOOKL()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Scratch");
			PFJDIEBLFAK = Time.time + (float)Random.Range(1, 81);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Sit");
			OIBGCGNCAKG = Time.time + (float)Random.Range(0, -13);
		}
	}

	private void DBKCPJIKFFC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("LE_21");
			PFJDIEBLFAK = Time.time + (float)Random.Range(4, 36);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("F2");
			OIBGCGNCAKG = Time.time + (float)Random.Range(7, -47);
		}
	}

	private void Update()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Mouth");
			PFJDIEBLFAK = Time.time + (float)Random.Range(6, 15);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Eyes");
			OIBGCGNCAKG = Time.time + (float)Random.Range(4, 10);
		}
	}

	private void BDMEBLBLPIA()
	{
	}

	private void NNBIAIMPNGL()
	{
	}

	private void EOGHJNGJFID()
	{
	}

	private void MGMLDHPOLGK()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("[MinePuzzleManager] Found {0} altar pieces. IsBigPuzzle:{1} PuzzleSpawners:{2} SingleSpawnerMode:{3}.");
			PFJDIEBLFAK = Time.time + (float)Random.Range(1, -11);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Minigame");
			OIBGCGNCAKG = Time.time + (float)Random.Range(5, -25);
		}
	}

	private void PHLLBPLOLFO()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Wort");
			PFJDIEBLFAK = Time.time + (float)Random.Range(4, -37);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Club");
			OIBGCGNCAKG = Time.time + (float)Random.Range(5, 96);
		}
	}

	private void EAEKKBEJMFC()
	{
	}

	private void NLFHFPHDNCF()
	{
	}

	private void LFNENELHOGJ()
	{
	}

	private void NFDJLCGELJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Direction") || ((Component)HANHCHBHHEH).CompareTag("ReceivInstantiateHoleInGround") || ((Component)HANHCHBHHEH).CompareTag("HandUp"))
		{
			frogAnimator.SetTrigger("Select");
			AnimalsSpawner.CNDNOECMKME().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 782f);
		}
	}

	private void BNNLNCGNHFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(". Time since startup: ") || ((Component)HANHCHBHHEH).CompareTag("Interact") || ((Component)HANHCHBHHEH).CompareTag("Enviando Reporte"))
		{
			frogAnimator.SetTrigger("Error_RoomDirty");
			AnimalsSpawner.JHKLPLPBKCI().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 508f);
		}
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("GameEvent of type ") || ((Component)HANHCHBHHEH).CompareTag("Setup ") || ((Component)HANHCHBHHEH).CompareTag("Tutorial/T122/Dialogue3"))
		{
			frogAnimator.SetTrigger("</color><br>");
			AnimalsSpawner.OMFKNGDCJFN().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 934f);
		}
	}

	private void HBMDEHPHAPF()
	{
	}

	private void OOGMGIPKMAP()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("EditorAction_");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, -44);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Player");
			OIBGCGNCAKG = Time.time + (float)Random.Range(2, 126);
		}
	}

	private void FJEKAKFLJJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/11/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag(" data received") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_642"))
		{
			frogAnimator.SetTrigger("Prefab not found for item with id ");
			AnimalsSpawner.LKOABOAADCD().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 749f);
		}
	}

	private void MNFMLJJBKNC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("UseHold");
			PFJDIEBLFAK = Time.time + (float)Random.Range(8, 89);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("ReturnToBasicMood");
			OIBGCGNCAKG = Time.time + (float)Random.Range(5, 88);
		}
	}

	private void HCPKBJDHLAC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("");
			PFJDIEBLFAK = Time.time + (float)Random.Range(8, 37);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Dog");
			OIBGCGNCAKG = Time.time + (float)Random.Range(5, -2);
		}
	}

	private void NELBHAMPBPL()
	{
	}

	private void NDLCBLKOBLF()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Sit");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, -70);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("AnimatorObjectStateRequest");
			OIBGCGNCAKG = Time.time + (float)Random.Range(6, 91);
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Giving extra nails") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_730") || ((Component)HANHCHBHHEH).CompareTag("Sick"))
		{
			frogAnimator.SetTrigger("Bait");
			AnimalsSpawner.NBKKEINELDN().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 362f);
		}
	}

	private void GNGADDPBJDC()
	{
	}

	private void CKCHKHNBBFG()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Dialogue System/Conversation/BirdNegativeComments/Entry/4/Dialogue Text");
			PFJDIEBLFAK = Time.time + (float)Random.Range(6, 17);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger(" is already in Kyroh's tray bento.");
			OIBGCGNCAKG = Time.time + (float)Random.Range(6, -54);
		}
	}

	private void FHEGBNMJADG()
	{
	}

	private void GGPDPOAICOM()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("<color=#BF0000>");
			PFJDIEBLFAK = Time.time + (float)Random.Range(2, -38);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("talentPeppers");
			OIBGCGNCAKG = Time.time + (float)Random.Range(0, -6);
		}
	}

	private void IOINOMJHICB()
	{
	}

	private void BELOIFKPNMM()
	{
	}

	private void EAJDLPCKDEC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("00") || ((Component)HANHCHBHHEH).CompareTag("Disabled") || ((Component)HANHCHBHHEH).CompareTag("In item "))
		{
			frogAnimator.SetTrigger("Players are Sleeping. Waiting...");
			AnimalsSpawner.CNDNOECMKME().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 85f);
		}
	}

	private void BIILFPDIADC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger(" ");
			PFJDIEBLFAK = Time.time + (float)Random.Range(8, 44);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Dialogue System/Conversation/Gass_Barks_Bye/Entry/6/Dialogue Text");
			OIBGCGNCAKG = Time.time + (float)Random.Range(6, -66);
		}
	}

	private void ACPFEBOENOM()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("</color><br>");
			PFJDIEBLFAK = Time.time + (float)Random.Range(4, 79);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("KlaynNPC: ChangeState called with invalid state: ");
			OIBGCGNCAKG = Time.time + (float)Random.Range(2, -83);
		}
	}

	private void HOKBBFHGACN()
	{
	}

	private void KDBJHCAEGCM()
	{
	}

	private void JBGFGOCPEFD()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger(" : ");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, -66);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Dialogue System/Conversation/TavernClean/Entry/7/Dialogue Text");
			OIBGCGNCAKG = Time.time + (float)Random.Range(8, 0);
		}
	}

	private void MGJIGIBHAKK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("NextItem") || ((Component)HANHCHBHHEH).CompareTag("Toy") || ((Component)HANHCHBHHEH).CompareTag("RecipeFromHost"))
		{
			frogAnimator.SetTrigger("Sleep");
			AnimalsSpawner.GGFJGHHHEJC.animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 855f);
		}
	}

	private void BGFCHEIOKOG()
	{
	}

	private void NLIGLFEEFNO()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("\n");
			PFJDIEBLFAK = Time.time + (float)Random.Range(1, 89);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("ReceiveTavernAction");
			OIBGCGNCAKG = Time.time + (float)Random.Range(5, -36);
		}
	}

	private void APJNDKLBHCF()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Key2");
			PFJDIEBLFAK = Time.time + (float)Random.Range(0, -72);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Room occupied");
			OIBGCGNCAKG = Time.time + (float)Random.Range(7, -6);
		}
	}

	private void MKLIAMJFHOF()
	{
	}

	private void AHFGOOHOLEL()
	{
	}

	private void MGDDKALLJDN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("\n") || ((Component)HANHCHBHHEH).CompareTag("NormalLeft") || ((Component)HANHCHBHHEH).CompareTag("Error in CatRelationship.CheckRelationship: "))
		{
			frogAnimator.SetTrigger("Dialogue System/Conversation/Gass_Quest/Entry/39/Dialogue Text");
			AnimalsSpawner.BNBMNOMFFBE().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 713f);
		}
	}

	private void DLNOLBHCIGC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("MainProgress");
			PFJDIEBLFAK = Time.time + (float)Random.Range(8, -111);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("TermasInterior/Rin/Intro");
			OIBGCGNCAKG = Time.time + (float)Random.Range(6, 89);
		}
	}

	private void MLLADNLMIMP()
	{
	}

	private void HCKBMOKECOA()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("No content to enable / disable in this NPC!");
			PFJDIEBLFAK = Time.time + (float)Random.Range(2, -26);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("IntensityBars");
			OIBGCGNCAKG = Time.time + (float)Random.Range(2, -39);
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BanquetEvent instance is null. Make sure it is initialized before calling DeactivateBanquetEvent.") || ((Component)HANHCHBHHEH).CompareTag("SetAnimatorObjectStateRPC") || ((Component)HANHCHBHHEH).CompareTag("CiderAleAbbreviation"))
		{
			frogAnimator.SetTrigger("UISelectGamepad");
			AnimalsSpawner.JCMKNNOEONP().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1370f);
		}
	}

	private void HPIMHEMJMAA()
	{
	}

	private void AAOFFIJHHIB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("All bubbles in use!") || ((Component)HANHCHBHHEH).CompareTag("Drink") || ((Component)HANHCHBHHEH).CompareTag(" is not supported by CanvasWorldScaler"))
		{
			frogAnimator.SetTrigger("itemBrownWort");
			AnimalsSpawner.LKOABOAADCD().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 401f);
		}
	}

	private void OJOMNJEFKOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ErrorDisconnectedTitleScreen") || ((Component)HANHCHBHHEH).CompareTag("piratescave") || ((Component)HANHCHBHHEH).CompareTag("Sleep"))
		{
			frogAnimator.SetTrigger("Items/item_name_609");
			AnimalsSpawner.BNBMNOMFFBE().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1923f);
		}
	}

	private void HJDLNCOAKIK()
	{
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MainProgress") || ((Component)HANHCHBHHEH).CompareTag("Angry") || ((Component)HANHCHBHHEH).CompareTag("popUpBuilding11"))
		{
			frogAnimator.SetTrigger("SwitchFood");
			AnimalsSpawner.LKOABOAADCD().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 226f);
		}
	}

	private void ONOAGANPECB()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("GENERIC STATE - NAME UNDEFINED");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, 28);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Items/item_description_1144");
			OIBGCGNCAKG = Time.time + (float)Random.Range(4, -32);
		}
	}

	private void GOEGBOEMHLI()
	{
	}

	private void JHOEAKHHNDD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/CrafterBlock") || ((Component)HANHCHBHHEH).CompareTag("Antorcha({0})") || ((Component)HANHCHBHHEH).CompareTag("LE_21"))
		{
			frogAnimator.SetTrigger("-1");
			AnimalsSpawner.JCMKNNOEONP().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1213f);
		}
	}

	private void OIAHJHNPPCO()
	{
	}

	private void PMLPGABFLGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Fish didn't have a proper bed assigned value {0}") || ((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag(" not found."))
		{
			frogAnimator.SetTrigger("Loading obstacles only in old saves");
			AnimalsSpawner.LKOABOAADCD().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1902f);
		}
	}

	private void FOHGHCPODBJ()
	{
	}

	private void LMEJFGKCHEF()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("ReceivePhaseMessage");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, 16);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger(" </mark>");
			OIBGCGNCAKG = Time.time + (float)Random.Range(8, -96);
		}
	}

	private void ICFHPJHBPDN()
	{
	}

	private void FOHCEDHJOEF()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("flashLights");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, -80);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("CurrentThemeSection");
			OIBGCGNCAKG = Time.time + (float)Random.Range(6, 6);
		}
	}

	private void IMIONHLAKIH()
	{
	}

	private void GJMLHECPGBP()
	{
	}

	private void CFIIEJDJFPB()
	{
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Showing Keyboard ") || ((Component)HANHCHBHHEH).CompareTag("Integer {0} changed to {1} on {2}'s animator. Sending RPC.") || ((Component)HANHCHBHHEH).CompareTag("questNameGruel"))
		{
			frogAnimator.SetTrigger("UpgradeToLevel");
			AnimalsSpawner.ECGIAEFKKNA().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1658f);
		}
	}

	private void IDMNLNDEBMC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("ReceiveDisableContent");
			PFJDIEBLFAK = Time.time + (float)Random.Range(4, -80);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("disableTutorial");
			OIBGCGNCAKG = Time.time + (float)Random.Range(6, 34);
		}
	}

	private void JGBLJPDNLMO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("No") || ((Component)HANHCHBHHEH).CompareTag("Hurt") || ((Component)HANHCHBHHEH).CompareTag(" "))
		{
			frogAnimator.SetTrigger("Dialogue System/Conversation/Crowly_Introduce/Entry/34/Dialogue Text");
			AnimalsSpawner.LKOABOAADCD().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1856f);
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Received {0} position to snap to: {1}") || ((Component)HANHCHBHHEH).CompareTag("ReceiveGroundTypeList") || ((Component)HANHCHBHHEH).CompareTag(""))
		{
			frogAnimator.SetTrigger("City/Amos/Bark/Buy");
			AnimalsSpawner.ABDJJBFNLBJ().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 845f);
		}
	}

	private void HFMJPMEALMO()
	{
	}

	private void EGDIINMEMGE()
	{
	}

	private void EBNKNEIDDDI()
	{
	}

	private void GHEHLJANBCF()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("itemChocolateAle");
			PFJDIEBLFAK = Time.time + (float)Random.Range(7, 6);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("UIBack");
			OIBGCGNCAKG = Time.time + (float)Random.Range(5, -25);
		}
	}

	private void CEIIFHIBIFI()
	{
	}

	private void PLHEHGHFCJI()
	{
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/22/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag("ErrorInvalidRoomCode") || ((Component)HANHCHBHHEH).CompareTag("popUpBuilding8"))
		{
			frogAnimator.SetTrigger(" / ");
			AnimalsSpawner.GGFJGHHHEJC.animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1025f);
		}
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("Walk") || ((Component)HANHCHBHHEH).CompareTag(" : 00"))
		{
			frogAnimator.SetTrigger("[Brown2");
			AnimalsSpawner.OMFKNGDCJFN().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1085f);
		}
	}

	private void NKJMIFCPJFA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1118") || ((Component)HANHCHBHHEH).CompareTag("Balance/MainEvent2") || ((Component)HANHCHBHHEH).CompareTag("UI2"))
		{
			frogAnimator.SetTrigger("Dialogue System/Conversation/Gass_Introduce/Entry/19/Dialogue Text");
			AnimalsSpawner.JHKLPLPBKCI().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1436f);
		}
	}

	private void FADCNMKMAFI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ClosePopUp") || ((Component)HANHCHBHHEH).CompareTag("KickedCustomers") || ((Component)HANHCHBHHEH).CompareTag("OnSeasonChanged to "))
		{
			frogAnimator.SetTrigger("ReceiveCure");
			AnimalsSpawner.MPFJOKOJIOO().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 577f);
		}
	}

	private void KFDMANOLOAB()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("ReceiveTalentsLoad");
			PFJDIEBLFAK = Time.time + (float)Random.Range(0, -36);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("ReceiveAnimalSlotFromContainer");
			OIBGCGNCAKG = Time.time + (float)Random.Range(2, 89);
		}
	}

	private void IIOHMDNGFDH()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Intro20");
			PFJDIEBLFAK = Time.time + (float)Random.Range(5, -16);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("DecorationTile_9");
			OIBGCGNCAKG = Time.time + (float)Random.Range(3, -78);
		}
	}

	private void DEOPBEHPEIN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_669") || ((Component)HANHCHBHHEH).CompareTag("Down") || ((Component)HANHCHBHHEH).CompareTag("Sprinting is now FASTER."))
		{
			frogAnimator.SetTrigger(" PlayerNum: ");
			AnimalsSpawner.ELGNEJNLBNO().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 467f);
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("Door") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TooCold/Entry/5/Dialogue Text"))
		{
			frogAnimator.SetTrigger("talent_name_107");
			AnimalsSpawner.BNBMNOMFFBE().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1333f);
		}
	}

	private void AJDKOMCHALC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("ClosePopUp");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, -79);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("OWNER_ID");
			OIBGCGNCAKG = Time.time + (float)Random.Range(2, -86);
		}
	}

	private void DGJKLAEINHJ()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("\n\n");
			PFJDIEBLFAK = Time.time + (float)Random.Range(2, 37);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Move <color=#A51919>");
			OIBGCGNCAKG = Time.time + (float)Random.Range(2, 91);
		}
	}

	private void OILHJENGGEL()
	{
	}

	private void NIHJCJJKDBA()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("DecorationTile_25");
			PFJDIEBLFAK = Time.time + (float)Random.Range(0, -83);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("Hit");
			OIBGCGNCAKG = Time.time + (float)Random.Range(1, 92);
		}
	}

	private void MLICJIBNIFA()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("<color=#19FF00>");
			PFJDIEBLFAK = Time.time + (float)Random.Range(4, -48);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("ThemeTriggerPanelItemBlueprint");
			OIBGCGNCAKG = Time.time + (float)Random.Range(0, 112);
		}
	}

	private void GOJHCINMAJD()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Intro/ThirdConversation");
			PFJDIEBLFAK = Time.time + (float)Random.Range(2, -26);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger(". Time since startup: ");
			OIBGCGNCAKG = Time.time + (float)Random.Range(7, 126);
		}
	}

	private void DOKHLDBIDJB()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("LE_10");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, 13);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("/");
			OIBGCGNCAKG = Time.time + (float)Random.Range(8, 97);
		}
	}

	private void LANGHIOBJIH()
	{
	}

	private void AAOMCHHNKKM()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("UIAddRemove");
			PFJDIEBLFAK = Time.time + (float)Random.Range(3, 50);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger(" seconds.");
			OIBGCGNCAKG = Time.time + (float)Random.Range(5, 9);
		}
	}

	private void HNEGFBCKIIJ()
	{
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("mine") || ((Component)HANHCHBHHEH).CompareTag(": "))
		{
			frogAnimator.SetTrigger(" : ");
			AnimalsSpawner.JHKLPLPBKCI().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1922f);
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1114") || ((Component)HANHCHBHHEH).CompareTag("Leave immediately") || ((Component)HANHCHBHHEH).CompareTag("CutScene"))
		{
			frogAnimator.SetTrigger("Direction");
			AnimalsSpawner.AGGAGCBAGLL().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 516f);
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("quest_description_28") || ((Component)HANHCHBHHEH).CompareTag(", ") || ((Component)HANHCHBHHEH).CompareTag("quest_description_27"))
		{
			frogAnimator.SetTrigger("Magic");
			AnimalsSpawner.AFFGPMFKEFH().animals.Remove(((Component)this).gameObject);
			Utils.BLPDAEHPOBA(((Component)this).gameObject, 1919f);
		}
	}

	private void MMPMJNAFKHC()
	{
		if (Time.time >= PFJDIEBLFAK)
		{
			frogAnimator.SetTrigger("Initial DevConsole message: ");
			PFJDIEBLFAK = Time.time + (float)Random.Range(0, -54);
		}
		if (Time.time >= OIBGCGNCAKG)
		{
			frogAnimator.SetTrigger("UI");
			OIBGCGNCAKG = Time.time + (float)Random.Range(1, -84);
		}
	}
}
