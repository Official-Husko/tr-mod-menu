using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BarnBarkTutorial : MonoBehaviour
{
	private float DJPGGLPHCGB;

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("[MinePipePuzzle] No hay puzzles para {0}x{1} "))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("", ((Component)HollyNPC.OOKBNHMMFON()).transform);
				ButtonsContext.GetPlayer(0).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("DiscusionMineros/Main"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("ERROR - Steam Lobby received on launch command, but the lobby ID could not be parsed.", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(8).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 321f;
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Random"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = false;
				DialogueManager.Bark("LicenciaDeApertura/KlaynDialogue 05", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(1).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(1).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 1474f;
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/20/Dialogue Text"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("NormalRight", ((Component)HollyNPC.OOKBNHMMFON()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("ActionBar10"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = false;
				DialogueManager.Bark("Dialogue System/Conversation/Crowly_Standar/Entry/45/Dialogue Text", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(5).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 1843f;
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player2"))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = true;
				DialogueManager.Bark("Items/item_description_1106", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(0).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("<sprite name=\"stoneIcon\">"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = false;
				DialogueManager.Bark(" : ", ((Component)HollyNPC.OOKBNHMMFON()).transform);
				ButtonsContext.GetPlayer(7).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 1343f;
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Boots_L"))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = false;
				DialogueManager.Bark("NPCWalkTo is null in NPCRoutine. Make sure the routine ", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(0).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("MainProgress"))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = true;
				DialogueManager.Bark("", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(6).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 121f;
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("itemsCrafted"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = false;
				DialogueManager.Bark("Fuel", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(0).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Trying to add player but player list is full."))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = false;
				DialogueManager.Bark("Items/item_description_601", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(7).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 862f;
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/24/Dialogue Text"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = true;
				DialogueManager.Bark("Items/item_description_635", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Laugh"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = false;
				DialogueManager.Bark("Empty bites list", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(5).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 1470f;
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("EditorAction_7"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("openedPaths 0 before all blocksGenerationNumber", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(0).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("ReceiveInfoTerrain", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(7).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 161f;
		}
	}

	private void JGBLJPDNLMO(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Hair"))
			{
				HollyNPC.OOKBNHMMFON().inInteractiveBark = false;
				DialogueManager.Bark("Ninja Orders Manager is not initialized.", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Drink"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = true;
				DialogueManager.Bark(":<color=#3a0603> +", ((Component)HollyNPC.OOKBNHMMFON()).transform);
				ButtonsContext.GetPlayer(5).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 1284f;
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Error_MaxZones"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = false;
				DialogueManager.Bark("LE_10", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(0).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag(" ("))
			{
				HollyNPC.OOKBNHMMFON().inInteractiveBark = true;
				DialogueManager.Bark(" (", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(1).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 375f;
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("Tutorial/BarnExitBarks_Holly", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("Tutorial/BarnExitBarks_Holly", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(2).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 5f;
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("Items/item_name_701", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("//"))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = false;
				DialogueManager.Bark("Intro04", ((Component)HollyNPC.OOKBNHMMFON()).transform);
				ButtonsContext.GetPlayer(0).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 476f;
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveBeerTaps"))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = true;
				DialogueManager.Bark("Christmas/Ace/Stand", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("ReceiveAddAvailableQuestToCurrentQuestMaster"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = false;
				DialogueManager.Bark("", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(2).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 1694f;
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = true;
				DialogueManager.Bark("Building", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("ReceiveRemoveFloor"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("Checking current game language", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(6).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 1285f;
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Table is dirty"))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = false;
				DialogueManager.Bark("ReceiveDialogueEnd", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(0).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("[Player1Name]"))
			{
				HollyNPC.OOKBNHMMFON().inInteractiveBark = true;
				DialogueManager.Bark(" - ", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(0).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 776f;
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Turn On"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = false;
				DialogueManager.Bark("Items/item_description_1034", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("TavernInConstruction"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = false;
				DialogueManager.Bark("Unsaved progress will be lost.", ((Component)HollyNPC.OOKBNHMMFON()).transform);
				ButtonsContext.GetPlayer(6).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 543f;
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag(" get price serve customer "))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = true;
				DialogueManager.Bark("<color=#BF0000>", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(1).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = true;
				DialogueManager.Bark("Player/Bark/ShovelHole", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(3).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 642f;
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Barks_Bye/Entry/5/Dialogue Text"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = false;
				DialogueManager.Bark("PressToPlay", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(1).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_620"))
			{
				HollyNPC.OOKBNHMMFON().inInteractiveBark = false;
				DialogueManager.Bark("itemRoastedPork", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(8).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 883f;
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("tutorialPopUp108"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = false;
				DialogueManager.Bark("INeedWater", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(0).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("[SymbolPuzzle] Solution: "))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("itemDripTray", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(2).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 149f;
		}
	}

	private void HIMBLFNCDLL(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("UINextPage"))
			{
				HollyNPC.OOKBNHMMFON().inInteractiveBark = true;
				DialogueManager.Bark("ReceiveBeehiveMessage", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_638"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = false;
				DialogueManager.Bark("<br>", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(7).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 452f;
		}
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Error_PlaceItInAnimalSpace"))
			{
				HollyNPC.OOKBNHMMFON().inInteractiveBark = true;
				DialogueManager.Bark("ZuzzuProgress", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(0).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_622"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("halloweenActivated", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(4).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 1677f;
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("tutorialPopUp76"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("beach", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Label"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = false;
				DialogueManager.Bark("Break", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(3).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 1177f;
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/22/Dialogue Text"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = true;
				DialogueManager.Bark("SetNPCPositionAndParent", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("ReceiveSetBool"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("IntensitySectionCanvas/IntensitySection", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(6).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 248f;
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = true;
				DialogueManager.Bark("is not a food instance", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(1).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Unique id "))
			{
				HollyNPC.OOKBNHMMFON().inInteractiveBark = false;
				DialogueManager.Bark("Put Out Fire", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(3).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 1252f;
		}
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Disappear"))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = false;
				DialogueManager.Bark("Items/item_description_1109", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(0).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("???"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = false;
				DialogueManager.Bark("talentChairs", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(4).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 830f;
		}
	}

	private void OCMFFLLPHCK(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("[SelectSpawnersByMaxDistance] Candidate {0} score:{1:F1} (entrance:{2:F1} mutual:{3:F1} altar:{4:F1} exit:{5:F1})"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = false;
				DialogueManager.Bark("Dialogue System/Conversation/Rowdy/Entry/8/Dialogue Text", ((Component)HollyNPC.OOKBNHMMFON()).transform);
				ButtonsContext.GetPlayer(0).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("UINextCategory"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("Not enough money", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(2).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 1292f;
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("itemDeliveryBox"))
			{
				HollyNPC.OOKBNHMMFON().inInteractiveBark = true;
				DialogueManager.Bark("OnGameRichPresenceJoinRequested \nFriend ID: ", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(1).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Grain Ferment"))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = false;
				DialogueManager.Bark("Serve", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(3).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 416f;
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Customer Pool instance NULL!"))
			{
				HollyNPC.GGFJGHHHEJC.inInteractiveBark = false;
				DialogueManager.Bark("buildingObjective_2_1", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("On Simple Event "))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = false;
				DialogueManager.Bark("itemBarleyBread", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(7).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 1720f;
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("UIPreviousCategory"))
			{
				HollyNPC.JFJOKGAOPHA().inInteractiveBark = true;
				DialogueManager.Bark("Ingredient null!", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(0).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("ReceiveInfoCrops"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = false;
				DialogueManager.Bark("quest_description_20", ((Component)HollyNPC.EHJOPCBIGAB()).transform);
				ButtonsContext.GetPlayer(3).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 758f;
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/45/Dialogue Text"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = false;
				DialogueManager.Bark("Dialogue System/Conversation/Crowly_Standar/Entry/50/Dialogue Text", ((Component)HollyNPC.EKGMDIHLEEH()).transform);
				ButtonsContext.GetPlayer(1).ResetButtons();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("BARKBUZZ"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("Items/item_name_729", ((Component)HollyNPC.OOKBNHMMFON()).transform);
				ButtonsContext.GetPlayer(7).ResetButtons();
			}
			DJPGGLPHCGB = Time.time + 322f;
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (Time.time > DJPGGLPHCGB)
		{
			if (((Component)HANHCHBHHEH).CompareTag("GetOnlinePlaceable() not found any uniqueId "))
			{
				HollyNPC.EKGMDIHLEEH().inInteractiveBark = true;
				DialogueManager.Bark("christmasActivated", ((Component)HollyNPC.JFJOKGAOPHA()).transform);
				ButtonsContext.GetPlayer(1).DKCMJENPPFA();
			}
			else if (((Component)HANHCHBHHEH).CompareTag("KentaProgress"))
			{
				HollyNPC.EHJOPCBIGAB().inInteractiveBark = true;
				DialogueManager.Bark("repUnlockOrderQuest", ((Component)HollyNPC.GGFJGHHHEJC).transform);
				ButtonsContext.GetPlayer(5).DKCMJENPPFA();
			}
			DJPGGLPHCGB = Time.time + 1345f;
		}
	}
}
