using PixelCrushers.DialogueSystem;
using UnityEngine;

public class TutorialCollider : MonoBehaviour
{
	private float DBGOAKNJEPF;

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("ReceiveUnlockChristmasRecipes") || ((Component)HANHCHBHHEH).CompareTag("ReturnToBasicMood")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("NormalRightExterior", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 784f;
		}
	}

	private void POFDOILPANH()
	{
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO())
			{
				if (QuestManager.GGFJGHHHEJC.GDFGPDJDACP(-80))
				{
					Debug.Log((object)"Error_RoomIndependent");
					((Component)this).gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.Log((object)"[MinePuzzleManager] Activating puzzle of type {0}");
				((Component)this).gameObject.SetActive(false);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && QuestManager.GJFMMOPOKGJ().IsQuestDone(19))
		{
			Debug.Log((object)"Items/item_name_727");
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void JBGFGOCPEFD()
	{
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
			{
				if (QuestManager.GJFMMOPOKGJ().IsQuestDone(-109))
				{
					Debug.Log((object)"Items/item_description_624");
					((Component)this).gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.Log((object)"Items/item_name_1121");
				((Component)this).gameObject.SetActive(false);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && QuestManager.OPILDPFDFKJ().GDFGPDJDACP(-103))
		{
			Debug.Log((object)"Items/item_name_731");
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void EFCNKPEPELL()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void Awake()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void IAICCKPOBMJ()
	{
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
			{
				if (QuestManager.KHMEGDIABBF().BKKJNEKBMBE(-3))
				{
					Debug.Log((object)"Items/item_description_1094");
					((Component)this).gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.Log((object)"Eyelids");
				((Component)this).gameObject.SetActive(true);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && QuestManager.GGFJGHHHEJC.BKKJNEKBMBE(-34))
		{
			Debug.Log((object)"LE_10");
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void HCCJBKKGCLJ()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("Dog") || ((Component)HANHCHBHHEH).CompareTag("Player2")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("Close Multiple Choice", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 1943f;
		}
	}

	private void Update()
	{
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
			{
				if (QuestManager.GGFJGHHHEJC.IsQuestDone(14))
				{
					Debug.Log((object)"Quest Done");
					((Component)this).gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.Log((object)"Tutorial Disabled");
				((Component)this).gameObject.SetActive(false);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && QuestManager.GGFJGHHHEJC.IsQuestDone(14))
		{
			Debug.Log((object)"Quest Done");
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void DKDLOBOLNFH()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void NMKGOAJLMDG()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void EMJKKALMGLK()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void JDAMCMODANB()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void MFGANCCJFJK()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("Player_Bark_TutorialCollider", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 10f;
		}
	}

	private void DKNMGFDFLKL()
	{
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
			{
				if (QuestManager.GJFMMOPOKGJ().BKKJNEKBMBE(-94))
				{
					Debug.Log((object)"Tavern Vision");
					((Component)this).gameObject.SetActive(true);
				}
			}
			else
			{
				Debug.Log((object)"HenHouseTutorialDone");
				((Component)this).gameObject.SetActive(false);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && QuestManager.KHMEGDIABBF().BKKJNEKBMBE(30))
		{
			Debug.Log((object)"VSync");
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void GAAKLENLEOF(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("DismissWorker?") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/17/Dialogue Text")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("itemBrownWort", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 915f;
		}
	}

	private void BFJOEMCBJJO()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag(" ") || ((Component)HANHCHBHHEH).CompareTag("LevelAbbreviation")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("quest_description_25", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 1322f;
		}
	}

	private void HIPNEFOEJPL()
	{
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO())
			{
				if (QuestManager.OPILDPFDFKJ().GDFGPDJDACP(23))
				{
					Debug.Log((object)"MissionTalkWith: NPC not found for character ");
					((Component)this).gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.Log((object)"DoYouWantToRepairIt");
				((Component)this).gameObject.SetActive(true);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && QuestManager.KHMEGDIABBF().IsQuestDone(-12))
		{
			Debug.Log((object)"Disabled");
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("mainMenuMultiplayerButton") || ((Component)HANHCHBHHEH).CompareTag("")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 1649f;
		}
	}

	private void BHLHCOALABE()
	{
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
			{
				if (QuestManager.OPILDPFDFKJ().GDFGPDJDACP(-49))
				{
					Debug.Log((object)"Items/item_description_607");
					((Component)this).gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.Log((object)"UpdatePopUP_");
				((Component)this).gameObject.SetActive(true);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && QuestManager.GJFMMOPOKGJ().GDFGPDJDACP(111))
		{
			Debug.Log((object)"Player/Bark/Tutorial/T138");
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("Unique ID not set for ") || ((Component)HANHCHBHHEH).CompareTag("UIInteract")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("Dialogue System/Conversation/EnterTavernDrink/Entry/7/Dialogue Text", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 1056f;
		}
	}

	private void FGGPGOEAEKK()
	{
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO())
			{
				if (QuestManager.OPILDPFDFKJ().IsQuestDone(80))
				{
					Debug.Log((object)"world time");
					((Component)this).gameObject.SetActive(true);
				}
			}
			else
			{
				Debug.Log((object)"WaitIntro");
				((Component)this).gameObject.SetActive(true);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && QuestManager.GGFJGHHHEJC.GDFGPDJDACP(114))
		{
			Debug.Log((object)"EXTRA ZONES: ");
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag(" installed for reason ") || ((Component)HANHCHBHHEH).CompareTag("[MinePuzzleManager] Not enough spawners even with fallback for {0} (needed {1}). Trying another type.")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("ReceiveInfoCrops", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 1577f;
		}
	}

	private void JDMMNLKLMAA()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("Up") || ((Component)HANHCHBHHEH).CompareTag("[")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("Items/item_name_1043", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 1516f;
		}
	}

	private void FHOCCEBKHJI()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void OMBHDODDHNO()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void KLMNLEDKEOE()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void PJLKGOACDEN()
	{
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO())
			{
				if (QuestManager.GGFJGHHHEJC.IsQuestDone(-60))
				{
					Debug.Log((object)"DecorationTile_25");
					((Component)this).gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.Log((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/21/Dialogue Text");
				((Component)this).gameObject.SetActive(true);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && QuestManager.GGFJGHHHEJC.GDFGPDJDACP(-106))
		{
			Debug.Log((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/37/Dialogue Text");
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("Setup") || ((Component)HANHCHBHHEH).CompareTag("Forward")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("Open", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 510f;
		}
	}

	private void KHONOODGLBI()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("Leave immediately") || ((Component)HANHCHBHHEH).CompareTag("Perks/perk_name_")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("Food", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 35f;
		}
	}

	private void FPOIFOGELHC()
	{
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD)
			{
				if (QuestManager.GJFMMOPOKGJ().GDFGPDJDACP(112))
				{
					Debug.Log((object)"BarkActor");
					((Component)this).gameObject.SetActive(false);
				}
			}
			else
			{
				Debug.Log((object)"IdleCamp");
				((Component)this).gameObject.SetActive(true);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && QuestManager.GGFJGHHHEJC.BKKJNEKBMBE(-95))
		{
			Debug.Log((object)"dog");
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("City/Woody/Bark/Bye") || ((Component)HANHCHBHHEH).CompareTag("Item nulo en el índice {0}.")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("Could not find item with id: ", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 1774f;
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("TimeLeft") || ((Component)HANHCHBHHEH).CompareTag("Round ")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("ReceiveTavernEventsLoad", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 631f;
		}
	}

	private void NEPDNLPCCON()
	{
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO())
			{
				if (QuestManager.GJFMMOPOKGJ().GDFGPDJDACP(-88))
				{
					Debug.Log((object)"Close");
					((Component)this).gameObject.SetActive(true);
				}
			}
			else
			{
				Debug.Log((object)"Move Forward");
				((Component)this).gameObject.SetActive(true);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && QuestManager.KHMEGDIABBF().IsQuestDone(6))
		{
			Debug.Log((object)"Rowdy");
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void GFLFDLIMOLI()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void NEOICNJNKNL()
	{
		DBGOAKNJEPF = Time.time;
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("Minning") || ((Component)HANHCHBHHEH).CompareTag("Interact")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("[ActivatePuzzle] Type: ", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 431f;
		}
	}

	private void OJOMNJEFKOG(Collider2D HANHCHBHHEH)
	{
		if ((((Component)HANHCHBHHEH).CompareTag("<sprite name=\"stoneIcon\">") || ((Component)HANHCHBHHEH).CompareTag("- ")) && Time.time >= DBGOAKNJEPF)
		{
			DialogueManager.Bark("Show", ((Component)HANHCHBHHEH).transform);
			DBGOAKNJEPF = Time.time + 1693f;
		}
	}

	private void GOJHCINMAJD()
	{
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		if (!SaveUI.instance.startingNewGame)
		{
			if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO())
			{
				if (QuestManager.GGFJGHHHEJC.BKKJNEKBMBE(14))
				{
					Debug.Log((object)"Lost connection to the server.\nPlease try again later.");
					((Component)this).gameObject.SetActive(true);
				}
			}
			else
			{
				Debug.Log((object)"A very important guest is visiting!");
				((Component)this).gameObject.SetActive(false);
			}
		}
		else if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && QuestManager.GGFJGHHHEJC.GDFGPDJDACP(23))
		{
			Debug.Log((object)"Moving");
			((Component)this).gameObject.SetActive(true);
		}
	}
}
