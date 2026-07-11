using PixelCrushers.DialogueSystem;
using UnityEngine;

public class HikariCollider : MonoBehaviour
{
	public int num;

	private float PPMHCOBKMCN;

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("in") && !((Component)HANHCHBHHEH).CompareTag("Error in Crafter.OnPlayerSleep: "))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Walk");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("Game", (object)0);
				DialogueManager.Bark("Items/item_name_1044", ((Component)HikariNPC.EFPJLFMBPLL()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Introduce/Entry/20/Dialogue Text");
		if (((Result)(ref variable)).asInt >= 0)
		{
			variable = DialogueLua.GetVariable("ReceiveGetUp");
			if (((Result)(ref variable)).asInt < 86)
			{
				DialogueManager.Bark("UIInteract", ((Component)PlayerController.OPHDCMJLLEC(((Component)HANHCHBHHEH).CompareTag("UINextCategory") ? 1 : 5)).transform);
				PPMHCOBKMCN = Time.time + 1597f;
			}
		}
		variable = DialogueLua.GetVariable(" seconds.");
		if (((Result)(ref variable)).asInt >= 18)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("questRequired") && !((Component)HANHCHBHHEH).CompareTag("\n\n<color=#A95A00>"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("itemMaltedBarley");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("Items/item_name_1123", (object)6);
				DialogueManager.Bark("KyrohScene", ((Component)HikariNPC.ABDJJBFNLBJ()).transform);
				((Component)this).gameObject.SetActive(true);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("[^0-9]");
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable("");
			if (((Result)(ref variable)).asInt < -22)
			{
				DialogueManager.Bark("VSync", ((Component)PlayerController.OPHDCMJLLEC((!((Component)HANHCHBHHEH).CompareTag("")) ? 8 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1113f;
			}
		}
		variable = DialogueLua.GetVariable(" needs more instances!");
		if (((Result)(ref variable)).asInt >= -94)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Talk") && !((Component)HANHCHBHHEH).CompareTag("UIAddRemove"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("ReceiveNPCDirection");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("AceT_Quest", (object)4);
				DialogueManager.Bark("Items/item_description_619", ((Component)HikariNPC.MNFMOEKMJKN()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Introduce/Entry/19/Dialogue Text");
		if (((Result)(ref variable)).asInt >= 1)
		{
			variable = DialogueLua.GetVariable("Items/item_name_600");
			if (((Result)(ref variable)).asInt < -10)
			{
				DialogueManager.Bark("", ((Component)PlayerController.GetPlayer((!((Component)HANHCHBHHEH).CompareTag("Items/item_name_1106")) ? 1 : 0)).transform);
				PPMHCOBKMCN = Time.time + 720f;
			}
		}
		variable = DialogueLua.GetVariable("└── ");
		if (((Result)(ref variable)).asInt >= -61)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("East") && !((Component)HANHCHBHHEH).CompareTag(" "))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable(")\n");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("ReceiveTavernEventsLoad", (object)4);
				DialogueManager.Bark(" blocking at ", ((Component)HikariNPC.MNFMOEKMJKN()).transform);
				((Component)this).gameObject.SetActive(true);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Game");
		if (((Result)(ref variable)).asInt >= 6)
		{
			variable = DialogueLua.GetVariable("BackPain");
			if (((Result)(ref variable)).asInt < 86)
			{
				DialogueManager.Bark("LE_10", ((Component)PlayerController.OPHDCMJLLEC((!((Component)HANHCHBHHEH).CompareTag("</color></b>")) ? 3 : 0)).transform);
				PPMHCOBKMCN = Time.time + 211f;
			}
		}
		variable = DialogueLua.GetVariable("Dialogue System/Conversation/TooCold/Entry/3/Dialogue Text");
		if (((Result)(ref variable)).asInt >= -35)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("player2ToDisconnectFromGame") && !((Component)HANHCHBHHEH).CompareTag("TabernaClausurada/KlaynDialogue 01"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("ButtonEndSegment");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("]", (object)0);
				DialogueManager.Bark("Item Transaction. Tutorial active!!", ((Component)HikariNPC.EFPJLFMBPLL()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable(" ");
		if (((Result)(ref variable)).asInt >= 7)
		{
			variable = DialogueLua.GetVariable("depth{0}");
			if (((Result)(ref variable)).asInt < 86)
			{
				DialogueManager.Bark(" will be destroyed in ", ((Component)PlayerController.OPHDCMJLLEC(((Component)HANHCHBHHEH).CompareTag("Items/item_name_688") ? 1 : 8)).transform);
				PPMHCOBKMCN = Time.time + 1355f;
			}
		}
		variable = DialogueLua.GetVariable("talentPickles");
		if (((Result)(ref variable)).asInt >= -25)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Disabled") && !((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("UINextPage");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("NetworkSync ", (object)1);
				DialogueManager.Bark("Month", ((Component)HikariNPC.EFPJLFMBPLL()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Cat with id ");
		if (((Result)(ref variable)).asInt >= 0)
		{
			variable = DialogueLua.GetVariable("Menu Mode Settings");
			if (((Result)(ref variable)).asInt < 107)
			{
				DialogueManager.Bark("Perks/playerPerk_description_", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("BathhouseEntrace/Main") ? 1 : 3)).transform);
				PPMHCOBKMCN = Time.time + 1080f;
			}
		}
		variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Introduce/Entry/22/Dialogue Text");
		if (((Result)(ref variable)).asInt >= -18)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Eat") && !((Component)HANHCHBHHEH).CompareTag("GB"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("OnConversationStarted ");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("Read", (object)8);
				DialogueManager.Bark("ReceiveStartKlaynChallenge", ((Component)HikariNPC.GGFJGHHHEJC).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Toy");
		if (((Result)(ref variable)).asInt >= 5)
		{
			variable = DialogueLua.GetVariable(" value ");
			if (((Result)(ref variable)).asInt < 86)
			{
				DialogueManager.Bark(" blocking at ", ((Component)PlayerController.GetPlayer((!((Component)HANHCHBHHEH).CompareTag("Drunk")) ? 4 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1825f;
			}
		}
		variable = DialogueLua.GetVariable("OTHER PLAYER HAS ADVANTAGE. Kyroh points: ");
		if (((Result)(ref variable)).asInt >= 38)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Error_CloseMenus") && !((Component)HANHCHBHHEH).CompareTag("itemStoutWort"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("ReceiveRenewCandle Unique id ");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("Items/item_name_1089", (object)1);
				DialogueManager.Bark("BARKBUZZ", ((Component)HikariNPC.OFLELHKKNKC()).transform);
				((Component)this).gameObject.SetActive(true);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("itemMango");
		if (((Result)(ref variable)).asInt >= 0)
		{
			variable = DialogueLua.GetVariable("Mine");
			if (((Result)(ref variable)).asInt < 72)
			{
				DialogueManager.Bark("{0} does not have a valid animation with the hash {1}. ", ((Component)PlayerController.OPHDCMJLLEC(((Component)HANHCHBHHEH).CompareTag("ErrorVersionMatchFailed") ? 1 : 8)).transform);
				PPMHCOBKMCN = Time.time + 1454f;
			}
		}
		variable = DialogueLua.GetVariable(" ");
		if (((Result)(ref variable)).asInt >= -119)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("[OnlineLoadPuzzles] LoadTorchPuzzleMessage: puzzle instance {0} is null") && !((Component)HANHCHBHHEH).CompareTag("NoEresDigno/EndEvent"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable(" - ");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("", (object)2);
				DialogueManager.Bark("stormy", ((Component)HikariNPC.EFPJLFMBPLL()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("DisableLeft");
		if (((Result)(ref variable)).asInt >= 6)
		{
			variable = DialogueLua.GetVariable("Sleep");
			if (((Result)(ref variable)).asInt < -117)
			{
				DialogueManager.Bark("Hurt", ((Component)PlayerController.GetPlayer((!((Component)HANHCHBHHEH).CompareTag("The mine piece ")) ? 1 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1683f;
			}
		}
		variable = DialogueLua.GetVariable("itemEmptyKeg");
		if (((Result)(ref variable)).asInt >= 58)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Stay") && !((Component)HANHCHBHHEH).CompareTag("，"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Puente_EA/Talk 1");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("Items/item_name_1063", (object)7);
				DialogueManager.Bark("Error in StaffManager.StaffInstantGoHome: ", ((Component)HikariNPC.ABDJJBFNLBJ()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("0");
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable("/");
			if (((Result)(ref variable)).asInt < 18)
			{
				DialogueManager.Bark("DecorationTile_22", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("Comfort") ? 1 : 0)).transform);
				PPMHCOBKMCN = Time.time + 711f;
			}
		}
		variable = DialogueLua.GetVariable("Items/item_description_627");
		if (((Result)(ref variable)).asInt >= -66)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag(" seconds.") && !((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/44/Dialogue Text"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("ErrorInvalidRoomCode");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("BuzzProgress", (object)2);
				DialogueManager.Bark("PlayerNum not set in the inspector for FadeCamera component. If this component is set on the player prefab, it needs to be removed and placed on the initialization scene.", ((Component)HikariNPC.ABDJJBFNLBJ()).transform);
				((Component)this).gameObject.SetActive(true);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable(" (");
		if (((Result)(ref variable)).asInt >= 6)
		{
			variable = DialogueLua.GetVariable(" NOT SHOWING IN TOOLTIP");
			if (((Result)(ref variable)).asInt < 120)
			{
				DialogueManager.Bark(" / G: ", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag(" final price: ") ? 0 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1122f;
			}
		}
		variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt >= 35)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void OCMFFLLPHCK(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("DecorationTile_20") && !((Component)HANHCHBHHEH).CompareTag("itemMushroom"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("FinalTestEvent SetEventCoroutine");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable(" perk 23 propina ", (object)3);
				DialogueManager.Bark("MaximumCapacity", ((Component)HikariNPC.EKDNJDJHONF()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Float {0} changed to {1} on {2}'s animator. Sending RPC.");
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable("\n");
			if (((Result)(ref variable)).asInt < 14)
			{
				DialogueManager.Bark("v0.7.5", ((Component)PlayerController.OPHDCMJLLEC((!((Component)HANHCHBHHEH).CompareTag("OTHER PLAYER HAS ADVANTAGE. Kyroh points: ")) ? 6 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1927f;
			}
		}
		variable = DialogueLua.GetVariable("PanelToggleUI");
		if (((Result)(ref variable)).asInt >= 29)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Cat") && !((Component)HANHCHBHHEH).CompareTag("Left"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("F2");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("setDefaultSettings", (object)8);
				DialogueManager.Bark("Path node error. Only 1 node at [0, 0] ", ((Component)HikariNPC.EKDNJDJHONF()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Swap");
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable("UI2");
			if (((Result)(ref variable)).asInt < 11)
			{
				DialogueManager.Bark("Sleep", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("itemRyeFlour") ? 1 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1564f;
			}
		}
		variable = DialogueLua.GetVariable("popUpBuilding38");
		if (((Result)(ref variable)).asInt >= 117)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("LE_10", (object)2);
				DialogueManager.Bark("Hikari/Barks_Intro", ((Component)HikariNPC.GGFJGHHHEJC).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt >= 5)
		{
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt < 11)
			{
				DialogueManager.Bark("Hikari/Barks_Intro", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("Player") ? 1 : 2)).transform);
				PPMHCOBKMCN = Time.time + 5f;
			}
		}
		variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt >= 11)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("ReceiveDecorationWall") && !((Component)HANHCHBHHEH).CompareTag("Requirements not met"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Error in DogRelationship.CheckRelationship: ");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("ActionBar10", (object)7);
				DialogueManager.Bark("veggieDishes", ((Component)HikariNPC.GGFJGHHHEJC).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Planning");
		if (((Result)(ref variable)).asInt >= 8)
		{
			variable = DialogueLua.GetVariable(" - ");
			if (((Result)(ref variable)).asInt < -90)
			{
				DialogueManager.Bark("Player", ((Component)PlayerController.OPHDCMJLLEC(((Component)HANHCHBHHEH).CompareTag("LE_10") ? 1 : 4)).transform);
				PPMHCOBKMCN = Time.time + 1459f;
			}
		}
		variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt >= 14)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("itemMead") && !((Component)HANHCHBHHEH).CompareTag("RecieveMaiInBar"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("CustomerPool.DisableAllCustomers: pool customer is null! Someone is destroying customers directly?");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("itemPumpkin", (object)3);
				DialogueManager.Bark("Enter", ((Component)HikariNPC.ABDJJBFNLBJ()).transform);
				((Component)this).gameObject.SetActive(true);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("BlackAleAbbreviation");
		if (((Result)(ref variable)).asInt >= 1)
		{
			variable = DialogueLua.GetVariable("BathhouseGameManager: Invalid player number ");
			if (((Result)(ref variable)).asInt < -26)
			{
				DialogueManager.Bark("SalonDelTrono/RibellaTalk", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("unlock recipe ") ? 1 : 2)).transform);
				PPMHCOBKMCN = Time.time + 71f;
			}
		}
		variable = DialogueLua.GetVariable("Farm/Buzz/Bark_Build");
		if (((Result)(ref variable)).asInt >= 69)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("CREATOR_ID") && !((Component)HANHCHBHHEH).CompareTag("Items/item_name_1173"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("???");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable(" not found. Can no instantiate online placeable", (object)1);
				DialogueManager.Bark("Farm/Bob/Stand", ((Component)HikariNPC.MNFMOEKMJKN()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("CutEnd");
		if (((Result)(ref variable)).asInt >= 3)
		{
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt < 10)
			{
				DialogueManager.Bark("ReceiveRemoveTableOrder", ((Component)PlayerController.OPHDCMJLLEC(((Component)HANHCHBHHEH).CompareTag("Open Calendar") ? 1 : 8)).transform);
				PPMHCOBKMCN = Time.time + 1793f;
			}
		}
		variable = DialogueLua.GetVariable("XP Upgrades");
		if (((Result)(ref variable)).asInt >= -2)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("ReceivePipeTileSwap") && !((Component)HANHCHBHHEH).CompareTag("SetMinigame"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable(" not intantiated due to ClientOnline still doesnt have SceneLoaded");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("christmasActivated", (object)6);
				DialogueManager.Bark("ReceiveRequestChallengeRestart", ((Component)HikariNPC.EFPJLFMBPLL()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Quest Done");
		if (((Result)(ref variable)).asInt >= 4)
		{
			variable = DialogueLua.GetVariable("Player with actor number {0} does not exist or has already been removed from the dictionary after disconnecting.");
			if (((Result)(ref variable)).asInt < -87)
			{
				DialogueManager.Bark("Item without ID: ", ((Component)PlayerController.GetPlayer((!((Component)HANHCHBHHEH).CompareTag("Defeat")) ? 2 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1547f;
			}
		}
		variable = DialogueLua.GetVariable("Quest not found in database with id: ");
		if (((Result)(ref variable)).asInt >= -76)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("\n") && !((Component)HANHCHBHHEH).CompareTag("VerticalMove"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Lightning2");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("Configure", (object)3);
				DialogueManager.Bark("UI2", ((Component)HikariNPC.EFPJLFMBPLL()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Removing tavern floor tiles (ONLINE) ");
		if (((Result)(ref variable)).asInt >= 3)
		{
			variable = DialogueLua.GetVariable("ReceiveHasSnowList");
			if (((Result)(ref variable)).asInt < 60)
			{
				DialogueManager.Bark("MainProgress", ((Component)PlayerController.OPHDCMJLLEC((!((Component)HANHCHBHHEH).CompareTag("Selected")) ? 4 : 0)).transform);
				PPMHCOBKMCN = Time.time + 948f;
			}
		}
		variable = DialogueLua.GetVariable("Player");
		if (((Result)(ref variable)).asInt >= -108)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Gass_CoctelQuest") && !((Component)HANHCHBHHEH).CompareTag("[TavernName]"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("itemRyeWort");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("+connect_lobby", (object)3);
				DialogueManager.Bark("ReceiveHostBedInfo", ((Component)HikariNPC.GGFJGHHHEJC).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("SendRoomRequest");
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable("alcoholContentWarning");
			if (((Result)(ref variable)).asInt < -31)
			{
				DialogueManager.Bark("LoopVolume", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("Tutorial_Main_") ? 1 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1079f;
			}
		}
		variable = DialogueLua.GetVariable("Toy");
		if (((Result)(ref variable)).asInt >= 97)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Received ") && !((Component)HANHCHBHHEH).CompareTag("Puente_EA/Talk 2"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("UI2");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("DestroyAfter", (object)1);
				DialogueManager.Bark("current Theme playing", ((Component)HikariNPC.ABDJJBFNLBJ()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("PlayerJoined_F");
		if (((Result)(ref variable)).asInt >= 0)
		{
			variable = DialogueLua.GetVariable("chatx");
			if (((Result)(ref variable)).asInt < -12)
			{
				DialogueManager.Bark("currentTutorialPhaseID ", ((Component)PlayerController.OPHDCMJLLEC(((Component)HANHCHBHHEH).CompareTag("Items/item_description_1065") ? 1 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1330f;
			}
		}
		variable = DialogueLua.GetVariable(" for reason: ");
		if (((Result)(ref variable)).asInt >= 46)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Income") && !((Component)HANHCHBHHEH).CompareTag("quest_description_"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Place");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("Low", (object)4);
				DialogueManager.Bark("Error in DogHoleManager.ResetDogHoles: ", ((Component)HikariNPC.ABDJJBFNLBJ()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("HarvestableDuringOneMonth");
		if (((Result)(ref variable)).asInt >= 5)
		{
			variable = DialogueLua.GetVariable("Fill Area/Fill");
			if (((Result)(ref variable)).asInt < -8)
			{
				DialogueManager.Bark("ThemeTriggerSection", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("F2") ? 1 : 3)).transform);
				PPMHCOBKMCN = Time.time + 1021f;
			}
		}
		variable = DialogueLua.GetVariable(" ");
		if (((Result)(ref variable)).asInt >= 21)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Cancel") && !((Component)HANHCHBHHEH).CompareTag("No settings configured for puzzle type {0}"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Invalid playerNum ");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("Checking SignedIn status...", (object)5);
				DialogueManager.Bark("Received PlaceableMsg of another type not CrafterMsg to ", ((Component)HikariNPC.OFLELHKKNKC()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("ReciveHollyPositionForTutorial");
		if (((Result)(ref variable)).asInt >= 4)
		{
			variable = DialogueLua.GetVariable("No");
			if (((Result)(ref variable)).asInt < 44)
			{
				DialogueManager.Bark("Default", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("\n") ? 1 : 8)).transform);
				PPMHCOBKMCN = Time.time + 807f;
			}
		}
		variable = DialogueLua.GetVariable("ReceiveStartTeleport");
		if (((Result)(ref variable)).asInt >= 17)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("No players at the start of the scene. Spawning...") && !((Component)HANHCHBHHEH).CompareTag("BarIdleNumber"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Drink");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("repUnlockOrderQuest", (object)4);
				DialogueManager.Bark("Read", ((Component)HikariNPC.EFPJLFMBPLL()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Error_Planks");
		if (((Result)(ref variable)).asInt >= 0)
		{
			variable = DialogueLua.GetVariable("dForDays");
			if (((Result)(ref variable)).asInt < -116)
			{
				DialogueManager.Bark("BobAnimation SetSleep", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("Gass_CoctelQuest") ? 0 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1701f;
			}
		}
		variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Stand/Entry/15/Dialogue Text");
		if (((Result)(ref variable)).asInt >= -33)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("LE_12") && !((Component)HANHCHBHHEH).CompareTag("Error in Crafter.OnPlayerSleep: "))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable(" seconds.");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("StackManager", (object)5);
				DialogueManager.Bark("ReceiveTrends", ((Component)HikariNPC.EKDNJDJHONF()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Label");
		if (((Result)(ref variable)).asInt >= 1)
		{
			variable = DialogueLua.GetVariable("tutorialPopUp76");
			if (((Result)(ref variable)).asInt < -34)
			{
				DialogueManager.Bark(":0", ((Component)PlayerController.GetPlayer(((Component)HANHCHBHHEH).CompareTag("Items/item_description_633") ? 1 : 4)).transform);
				PPMHCOBKMCN = Time.time + 373f;
			}
		}
		variable = DialogueLua.GetVariable("Direction");
		if (((Result)(ref variable)).asInt >= 17)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("LearnPrecision") && !((Component)HANHCHBHHEH).CompareTag("ReceiveNewState"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Player 2 inputs disabled.");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("Pause", (object)8);
				DialogueManager.Bark("Items/item_description_638", ((Component)HikariNPC.ABDJJBFNLBJ()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("itemIronIngot");
		if (((Result)(ref variable)).asInt >= 3)
		{
			variable = DialogueLua.GetVariable(" ");
			if (((Result)(ref variable)).asInt < -64)
			{
				DialogueManager.Bark("Rotate", ((Component)PlayerController.GetPlayer((!((Component)HANHCHBHHEH).CompareTag("Player2")) ? 3 : 0)).transform);
				PPMHCOBKMCN = Time.time + 89f;
			}
		}
		variable = DialogueLua.GetVariable("increase workers level");
		if (((Result)(ref variable)).asInt >= 49)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("HitCollider2") && !((Component)HANHCHBHHEH).CompareTag("Items/item_description_644"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("Reserve");
			if (((Result)(ref variable)).asInt == 0)
			{
				DialogueLua.SetVariable("Ingredients", (object)6);
				DialogueManager.Bark("", ((Component)HikariNPC.MNFMOEKMJKN()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("CannotToggleUI PauseMenuUI opened");
		if (((Result)(ref variable)).asInt >= 4)
		{
			variable = DialogueLua.GetVariable("No content to disable in this NPC!");
			if (((Result)(ref variable)).asInt < 122)
			{
				DialogueManager.Bark(" is not a valid code for a private room.", ((Component)PlayerController.OPHDCMJLLEC((!((Component)HANHCHBHHEH).CompareTag("itemSageSeeds")) ? 1 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1476f;
			}
		}
		variable = DialogueLua.GetVariable("Items/item_description_647");
		if (((Result)(ref variable)).asInt >= -80)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Held Item null in ") && !((Component)HANHCHBHHEH).CompareTag("Till"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("https://www.makeship.com/products/bob-plush-2");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("endconversations", (object)2);
				DialogueManager.Bark("BarkActor", ((Component)HikariNPC.EKDNJDJHONF()).transform);
				((Component)this).gameObject.SetActive(false);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Direction");
		if (((Result)(ref variable)).asInt >= 7)
		{
			variable = DialogueLua.GetVariable(" ");
			if (((Result)(ref variable)).asInt < 72)
			{
				DialogueManager.Bark("[PlayerGender=", ((Component)PlayerController.OPHDCMJLLEC((!((Component)HANHCHBHHEH).CompareTag("Create room list")) ? 6 : 0)).transform);
				PPMHCOBKMCN = Time.time + 975f;
			}
		}
		variable = DialogueLua.GetVariable("00");
		if (((Result)(ref variable)).asInt >= 62)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).CompareTag("Items/item_name_600") && !((Component)HANHCHBHHEH).CompareTag("Random"))
		{
			return;
		}
		Result variable;
		if (num == 0)
		{
			variable = DialogueLua.GetVariable("save");
			if (((Result)(ref variable)).asInt == 1)
			{
				DialogueLua.SetVariable("Items/item_name_1060", (object)2);
				DialogueManager.Bark("Invalid item", ((Component)HikariNPC.EKDNJDJHONF()).transform);
				((Component)this).gameObject.SetActive(true);
			}
		}
		if (!(Time.time > PPMHCOBKMCN) || num != 1)
		{
			return;
		}
		variable = DialogueLua.GetVariable("Player");
		if (((Result)(ref variable)).asInt >= 3)
		{
			variable = DialogueLua.GetVariable("Cleaning Speed");
			if (((Result)(ref variable)).asInt < -51)
			{
				DialogueManager.Bark("Month", ((Component)PlayerController.OPHDCMJLLEC((!((Component)HANHCHBHHEH).CompareTag("FishCuttingEvent/Talk2")) ? 6 : 0)).transform);
				PPMHCOBKMCN = Time.time + 1080f;
			}
		}
		variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Standar/Entry/16/Dialogue Text");
		if (((Result)(ref variable)).asInt >= -81)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}
}
