using AlmenaraGames;
using UnityEngine;

public class GuardController : MonoBehaviour
{
	public Animator anim;

	private void LDPNAPIGIIA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("particleSystem not attached to ") || ((Component)HANHCHBHHEH).CompareTag(""))
		{
			anim.SetBool("Apple Must", true);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().soldierMovement, ((Component)this).transform);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			anim.SetBool("Stop", true);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.soldierMovement, ((Component)this).transform);
		}
	}

	private void ABKKNODLBNL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Order") || ((Component)HANHCHBHHEH).CompareTag("Jump"))
		{
			anim.SetBool("KyrohNPC: Selected order with already ingredients in bento: ", false);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void BINMHNJBDNI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ChatCommandLockDescription") || ((Component)LGGCFCHOOMB).CompareTag("[GetFallbackCandidates] Total fallback candidates: {0}"))
		{
			anim.SetBool("itemMetalSheet", false);
		}
	}

	private void MKCEGNPBGMP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveHerbs") || ((Component)LGGCFCHOOMB).CompareTag("tutorialPopUp78"))
		{
			anim.SetBool("talents", false);
		}
	}

	private void MOOJEOLFOOC(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/EnterTavernDrink/Entry/5/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("Player/Bark/Tutorial/CantDoYet"))
		{
			anim.SetBool("Tool", true);
		}
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[BuildOrderedPuzzleQueue] Level {0} - UsedTypes: [{1}]") || ((Component)HANHCHBHHEH).CompareTag("NextItem"))
		{
			anim.SetBool("Dialogue System/Conversation/TooCold/Entry/1/Dialogue Text", false);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void BNOJBKLCCOA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(" (-") || ((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/5/Dialogue Text"))
		{
			anim.SetBool("-", true);
		}
	}

	private void OFNKDCBEAHP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ChocolateAleAbbreviation") || ((Component)LGGCFCHOOMB).CompareTag("Return To Last Basic Mood"))
		{
			anim.SetBool("Resolucion: ", false);
		}
	}

	private void IBINNLHHLMD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Steam Lobby received on launch command: {0}") || ((Component)LGGCFCHOOMB).CompareTag("SalonDelTrono/OxTalk"))
		{
			anim.SetBool("Farm/Event/SwordVioletArthur", true);
		}
	}

	private void HHGJLOKEPJE(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("LE_11") || ((Component)LGGCFCHOOMB).CompareTag("times played: "))
		{
			anim.SetBool("Disabled", true);
		}
	}

	private void ILJJIFMJICA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Load Game Client") || ((Component)LGGCFCHOOMB).CompareTag("Player"))
		{
			anim.SetBool("Fish cutting Game over.", false);
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MainProgress") || ((Component)HANHCHBHHEH).CompareTag("XP increased..."))
		{
			anim.SetBool("player2ToJoinGame", true);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}

	private void OHIPEHCDJFP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error in InteractObject.DisableInteract: ") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_610"))
		{
			anim.SetBool("[Brown", false);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void MGJIGIBHAKK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Inventory full") || ((Component)HANHCHBHHEH).CompareTag("Open"))
		{
			anim.SetBool("F2", true);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void HEOHCIAMEPD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Dirty") || ((Component)LGGCFCHOOMB).CompareTag("Player2"))
		{
			anim.SetBool("OnlinePlayer", false);
		}
	}

	private void FILGJJPEIFO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error_BarNotInADiningRoom") || ((Component)HANHCHBHHEH).CompareTag("No bed assigned to actor number: {0}"))
		{
			anim.SetBool("Order quest", false);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void JFJJJIEGDPH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Floor") || ((Component)HANHCHBHHEH).CompareTag("SetAnimatorStateRPC"))
		{
			anim.SetBool("ReceiveDeactivateEvent", true);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("OnlinePlayer") || ((Component)HANHCHBHHEH).CompareTag("Ingredient group "))
		{
			anim.SetBool("Gass_Quest", true);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Left Stick Right") || ((Component)HANHCHBHHEH).CompareTag("SpriteRenderer not attached on "))
		{
			anim.SetBool("\\[SinglePlayer=[^\\]]*\\]", false);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}

	private void DKGKGFAEGBD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Listview") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/33/Dialogue Text"))
		{
			anim.SetBool("Sleep", true);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}

	private void NHOPACFEAKA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("== END PLACE PIECES ==") || ((Component)LGGCFCHOOMB).CompareTag("sForSeconds"))
		{
			anim.SetBool("Items/item_description_631", false);
		}
	}

	private void AIOJHEKNMIC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Not enough ingredients") || ((Component)HANHCHBHHEH).CompareTag(" "))
		{
			anim.SetBool("immediately", false);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveResetBombVariable") || ((Component)HANHCHBHHEH).CompareTag("No"))
		{
			anim.SetBool("UIAddRemove", false);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Profit") || ((Component)HANHCHBHHEH).CompareTag("meatDishes"))
		{
			anim.SetBool("", true);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void HJIJHEONIIG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveInfoWorldTiles") || ((Component)LGGCFCHOOMB).CompareTag("<color=#18650E>"))
		{
			anim.SetBool("Items/item_name_1119", false);
		}
	}

	private void MDODDIKGEHI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Direction") || ((Component)LGGCFCHOOMB).CompareTag(")"))
		{
			anim.SetBool("itemFence", false);
		}
	}

	private void MOJBKEGFHOD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveLettersLoad") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_615"))
		{
			anim.SetBool("Tutorial_Main_", false);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void NGCPHGCKLGP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" because SharedFileDownloadListener.userID is null") || ((Component)HANHCHBHHEH).CompareTag("Hide"))
		{
			anim.SetBool(" ", false);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void HHBJICLBNPE(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("networkID has not been assigned properly") || ((Component)LGGCFCHOOMB).CompareTag("Pause"))
		{
			anim.SetBool("Normal", false);
		}
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Crop with ID ") || ((Component)HANHCHBHHEH).CompareTag("river"))
		{
			anim.SetBool("Shield", true);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}

	private void IODLDNOGLLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tavern must be closed") || ((Component)HANHCHBHHEH).CompareTag("ReceiveSimpleEvent"))
		{
			anim.SetBool("PirateMinigame/Talk", true);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player2") || ((Component)HANHCHBHHEH).CompareTag("Current map: "))
		{
			anim.SetBool("camp", true);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}

	private void FJEKAKFLJJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("k") || ((Component)HANHCHBHHEH).CompareTag("[MapChest] ("))
		{
			anim.SetBool("Open", true);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.soldierMovement, ((Component)this).transform);
		}
	}

	private void NLJMNADCDIN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveEmployeeBackToWorkRPC") || ((Component)LGGCFCHOOMB).CompareTag("[MinePuzzleManager] No altar spawner found for level {0}. Skipping puzzle generation."))
		{
			anim.SetBool("Recovering zone at ", true);
		}
	}

	private void MEKOIJNOMJG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Running") || ((Component)LGGCFCHOOMB).CompareTag("FarmReady"))
		{
			anim.SetBool(" not found", false);
		}
	}

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(": ") || ((Component)HANHCHBHHEH).CompareTag("[MinePuzzleManager] Adding {0} puzzle spawners from piece {1} (maxPuzzleSpawners: {2})"))
		{
			anim.SetBool("Northeast", false);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().soldierMovement, ((Component)this).transform);
		}
	}

	private void JMNPLNAGLCO(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(" not found in OnlineEventsManager.") || ((Component)LGGCFCHOOMB).CompareTag("Yes"))
		{
			anim.SetBool("mainMenuMultiplayerButtonConnecting", false);
		}
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_679") || ((Component)HANHCHBHHEH).CompareTag("quest_reward_27_28_29"))
		{
			anim.SetBool("Interact", false);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void LJJNLJILINI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(" exist in dictionary but is null") || ((Component)LGGCFCHOOMB).CompareTag("AvailableQuests doesnt exist"))
		{
			anim.SetBool("caveinn", true);
		}
	}

	private void BLBJCANJNBG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("HostDisconnected") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveFinishKlaynChallenge"))
		{
			anim.SetBool("waterQualityTestDone", false);
		}
	}

	private void GAANFGOOBGC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("EnabledRequest") || ((Component)HANHCHBHHEH).CompareTag("Held Item null in "))
		{
			anim.SetBool("Tech", false);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sickle") || ((Component)HANHCHBHHEH).CompareTag("SalonDelTrono/OrwinIITalk"))
		{
			anim.SetBool("TreasureMapUI", false);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().soldierMovement, ((Component)this).transform);
		}
	}

	private void IEBIOGJACBC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Error in OnlineObjectsManager.OnPlayerSleep: ") || ((Component)HANHCHBHHEH).CompareTag("The mine piece "))
		{
			anim.SetBool(" destroyed.", true);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void NFDJLCGELJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("castle travelling") || ((Component)HANHCHBHHEH).CompareTag("Saving ingredient "))
		{
			anim.SetBool("Japanese Door Not Sending Open Action. Unique ID: ", false);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().soldierMovement, ((Component)this).transform);
		}
	}

	private void JGBLJPDNLMO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("region") || ((Component)HANHCHBHHEH).CompareTag("SalonDelTrono/MainEvent"))
		{
			anim.SetBool("Items/item_description_634", false);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void LBJEAHNNMCN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("ReceiveStackPlayerInventory") || ((Component)LGGCFCHOOMB).CompareTag("MainProgress"))
		{
			anim.SetBool("- ", false);
		}
	}

	private void CIMPOOJOMMH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(".txt") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/25/Dialogue Text"))
		{
			anim.SetBool("Items/item_description_1141", true);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.soldierMovement, ((Component)this).transform);
		}
	}

	private void PMLPGABFLGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UI2") || ((Component)HANHCHBHHEH).CompareTag("Error in FogManager.OnNightEnd: "))
		{
			anim.SetBool(" - ", true);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.soldierMovement, ((Component)this).transform);
		}
	}

	private void DHIOKICDPIK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("") || ((Component)HANHCHBHHEH).CompareTag("All screen resolutions added..."))
		{
			anim.SetBool("Fortitude/MainEvent 3", false);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void DEOPBEHPEIN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("popUpBuilding7") || ((Component)HANHCHBHHEH).CompareTag("Sony DualSense"))
		{
			anim.SetBool("Leave", true);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.soldierMovement, ((Component)this).transform);
		}
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Held Item is a drink in ") || ((Component)HANHCHBHHEH).CompareTag("NinjaChallengeEvent/Main"))
		{
			anim.SetBool(" ", true);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void ONNMDGBPGEI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Eat") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1068"))
		{
			anim.SetBool("PlayerNum", true);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void ILNDDFELMKL(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("[Player2Name]") || ((Component)LGGCFCHOOMB).CompareTag("El componente ItemSetup del prefab '{0}' no referencia correctamente al item '{1}' (ID: {2})."))
		{
			anim.SetBool("\" unlocked", false);
		}
	}

	private void JCFDPDLMOME(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("player2ToDisconnectFromGame") || ((Component)HANHCHBHHEH).CompareTag("RecieveMaiInBar"))
		{
			anim.SetBool("Disabled", false);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void AAOFFIJHHIB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Till") || ((Component)HANHCHBHHEH).CompareTag("ReceiveSetDrinkColor"))
		{
			anim.SetBool("scaleUI", false);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void DEKJGPJMAPC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UIAddRemove") || ((Component)HANHCHBHHEH).CompareTag("Walk"))
		{
			anim.SetBool(", Value: ", true);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void FCOMECPDBDN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag(" not found in OnlineEventsManager.") || ((Component)LGGCFCHOOMB).CompareTag("add item "))
		{
			anim.SetBool("Winner", false);
		}
	}

	private void CNLANNFMFCN(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Text") || ((Component)LGGCFCHOOMB).CompareTag("Player/Bark/RygarStatue"))
		{
			anim.SetBool(" intensity:", false);
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Inventory full") || ((Component)HANHCHBHHEH).CompareTag("Filthy"))
		{
			anim.SetBool("itemRyeWort", false);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.soldierMovement, ((Component)this).transform);
		}
	}

	private void HIDDNMLHBFJ(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("vibrationP2") || ((Component)LGGCFCHOOMB).CompareTag("Player2"))
		{
			anim.SetBool("DueloDeViejos/MainEvent2", true);
		}
	}

	private void BIJGJOMFNOJ(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Rowdy/Entry/6/Dialogue Text") || ((Component)LGGCFCHOOMB).CompareTag("Winner"))
		{
			anim.SetBool("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/25/Dialogue Text", true);
		}
	}

	private void FJKGPAPACOI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" to actorNumber ") || ((Component)HANHCHBHHEH).CompareTag("Pirates/Brook/Saludo"))
		{
			anim.SetBool("MapQuarry", true);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void INBHNOLGOBP(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("OnlineManager's OnLevelLoaded") || ((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/5/Dialogue Text"))
		{
			anim.SetBool("Inventory full", false);
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" installed for reason ") || ((Component)HANHCHBHHEH).CompareTag("UIBack"))
		{
			anim.SetBool("ChatInviteCode", false);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void EIEKPEEPFGA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("No se encontró la conversación con el título '") || ((Component)LGGCFCHOOMB).CompareTag("PhysicalSpace"))
		{
			anim.SetBool(" ", false);
		}
	}

	private void NKJFOLAHKEG(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_description_687") || ((Component)LGGCFCHOOMB).CompareTag("Disabled"))
		{
			anim.SetBool(":<color=#3a0603> +", true);
		}
	}

	private void DAGGKPKBCLD(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Error in DialogueNPCBase.EndConversation: ") || ((Component)LGGCFCHOOMB).CompareTag("ReceiveTavernStatsLoad"))
		{
			anim.SetBool("Start water quality test", false);
		}
	}

	private void ILOJBCEKLDF(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Mine") || ((Component)LGGCFCHOOMB).CompareTag(" "))
		{
			anim.SetBool(" - ", true);
		}
	}

	private void ELKDCKDCKHL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Till") || ((Component)HANHCHBHHEH).CompareTag("veggieDishes"))
		{
			anim.SetBool("Fireplace not attached on OnlineFireplace of placeable ", false);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("quest_description_") || ((Component)HANHCHBHHEH).CompareTag("halloween event"))
		{
			anim.SetBool("Items/item_name_678", true);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().soldierMovement, ((Component)this).transform);
		}
	}

	private void OJOMNJEFKOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" // Replaced for ") || ((Component)HANHCHBHHEH).CompareTag("ObjectHorizontalMove"))
		{
			anim.SetBool("ErrorJoinRoomClosed", true);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().soldierMovement, ((Component)this).transform);
		}
	}

	private void EKJIEGLPBLA(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Disabled") || ((Component)LGGCFCHOOMB).CompareTag("NinjaChallengeEvent/Main"))
		{
			anim.SetBool("<size=", true);
		}
	}

	private void BJIPOABFPJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Balance/MainEvent2") || ((Component)HANHCHBHHEH).CompareTag("SalonDelTrono/MainEvent"))
		{
			anim.SetBool("place bomb", false);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void CMMHCNOAFCI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LearnMettle") || ((Component)HANHCHBHHEH).CompareTag("NinjaChallengeEvent/Win 2"))
		{
			anim.SetBool("Guest", false);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void KJJINNGPPEA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BobProgress") || ((Component)HANHCHBHHEH).CompareTag("Pool Parent "))
		{
			anim.SetBool("Items/item_description_1066", true);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}

	private void OnTriggerExit2D(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Player") || ((Component)LGGCFCHOOMB).CompareTag("Player2"))
		{
			anim.SetBool("Stop", false);
		}
	}

	private void GHCOOCFODFH(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("There was an issue when loading Travel Zones for the second floor. This is likely caused in online mode. Needs further investigating.") || ((Component)LGGCFCHOOMB).CompareTag("tutorialPopUp80"))
		{
			anim.SetBool("Bird sprite info not found with ID ", false);
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("<color=#BF0000>") || ((Component)HANHCHBHHEH).CompareTag("QuestInfoButton"))
		{
			anim.SetBool("UI", true);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().soldierMovement, ((Component)this).transform);
		}
	}

	private void DFDPLNHGAOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Disabled") || ((Component)HANHCHBHHEH).CompareTag("-"))
		{
			anim.SetBool("Use", false);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.soldierMovement, ((Component)this).transform);
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Actionbar 7") || ((Component)HANHCHBHHEH).CompareTag("ReceiveRoomRequest"))
		{
			anim.SetBool("ReceiveRenewCandle", false);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("EnterTavernFood") || ((Component)HANHCHBHHEH).CompareTag("Sending "))
		{
			anim.SetBool("LE_10", true);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().soldierMovement, ((Component)this).transform);
		}
	}

	private void DGLMPEODEKI(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Replacing Button on gameObject: ") || ((Component)LGGCFCHOOMB).CompareTag("[Brown"))
		{
			anim.SetBool("ReceiveToggleOpenBarnCanceled", true);
		}
	}

	private void ACKAOKBCDCJ(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Items/item_name_724") || ((Component)LGGCFCHOOMB).CompareTag(" installed"))
		{
			anim.SetBool(" (", true);
		}
	}

	private void MBEFBNJNMFF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("tutorialPopUp103") || ((Component)HANHCHBHHEH).CompareTag("Sleep"))
		{
			anim.SetBool("Items/item_name_1036", true);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().soldierMovement, ((Component)this).transform);
		}
	}

	private void NAFADNEKCOH(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Error_Planks") || ((Component)LGGCFCHOOMB).CompareTag("Collect"))
		{
			anim.SetBool("'.", false);
		}
	}

	private void HBHBMAKMOCM(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("Defeat") || ((Component)LGGCFCHOOMB).CompareTag(""))
		{
			anim.SetBool("popUpBuilding21", false);
		}
	}

	private void LMNMPBNMGCH(Collider2D LGGCFCHOOMB)
	{
		if (((Component)LGGCFCHOOMB).CompareTag("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects") || ((Component)LGGCFCHOOMB).CompareTag("itemLime"))
		{
			anim.SetBool("Error_MaxZones", false);
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Cat") || ((Component)HANHCHBHHEH).CompareTag("Serve"))
		{
			anim.SetBool("BirdInteract", false);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().soldierMovement, ((Component)this).transform);
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Club") || ((Component)HANHCHBHHEH).CompareTag("cropsHarvested"))
		{
			anim.SetBool("CatOfFriend", true);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.soldierMovement, ((Component)this).transform);
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Mouth") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_1191"))
		{
			anim.SetBool(" has null in occupy nodes with colliders list.", true);
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().soldierMovement, ((Component)this).transform);
		}
	}

	private void FFAECPIMMIL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Shovah3D") || ((Component)HANHCHBHHEH).CompareTag("ReceiveLastTravelPosition"))
		{
			anim.SetBool("Items/item_name_1188", false);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}

	private void LFPJOBMFDAC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" ") || ((Component)HANHCHBHHEH).CompareTag(" "))
		{
			anim.SetBool("Player/Bark/PickUpBlocker", false);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().soldierMovement, ((Component)this).transform);
		}
	}
}
