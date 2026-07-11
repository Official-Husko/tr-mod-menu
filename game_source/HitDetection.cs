using UnityEngine;
using UnityEngine.Events;

public class HitDetection : MonoBehaviour
{
	public UnityEvent actionToDo;

	public int playerNum = 1;

	public bool bouncer;

	public float gamepadShakeIntensity = 0.6f;

	public float gamepadTremblingIntensity;

	public float shakeDuration = 0.2f;

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("UI2"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("City/Agatha/Stand"))
		{
			bouncer = false;
			playerNum = 7;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dirty"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 452f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void JGBLJPDNLMO(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("City/PetShop/Markus/Intro"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Content"))
		{
			bouncer = true;
			playerNum = 8;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Save"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1244f)
		{
			PlayerInputs.GetPlayer(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Remove"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("</color>"))
		{
			bouncer = true;
			playerNum = 5;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Keg empty"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1080f)
		{
			PlayerInputs.GetPlayer(playerNum).MPJIPOBMOJK(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("City/PetShop/Markus/Barks_FeedDog"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemHoney"))
		{
			bouncer = true;
			playerNum = 2;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("NewQuestAvailable"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 302f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).SetVibration(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1153"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag(": "))
		{
			bouncer = true;
			playerNum = 4;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Fixed workbench or malteadora rotation at "))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 579f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player2"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Held Item is a drink in "))
		{
			bouncer = true;
			playerNum = 5;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Y"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1991f)
		{
			PlayerInputs.GetPlayer(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void OCMFFLLPHCK(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("vibrationP2"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Suitabilities: "))
		{
			bouncer = false;
			playerNum = 6;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("UI2"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 977f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void OJOMNJEFKOG(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("LE_2"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Unique id "))
		{
			bouncer = true;
			playerNum = 8;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("HandUp"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1107f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).SetVibration(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("<sprite name=reputationIcon>"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveStatuePuzzle"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1128"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 990f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).KJGHGABOEGN(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(" "))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Crafting"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("<sprite name=reputationIcon> "))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1354f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).SetVibration(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void AIOJHEKNMIC(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("FinalTest/MainEvent 2"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("\n"))
		{
			bouncer = false;
			playerNum = 4;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Inventory full"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 97f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("buildingObjective_38_0"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("UI2"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag(" ("))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1738f)
		{
			PlayerInputs.GetPlayer(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Waiting"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("vSync"))
		{
			bouncer = true;
			playerNum = 4;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag(""))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1667f)
		{
			PlayerInputs.GetPlayer(playerNum).DCNHJFFIDJB(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void BNNLNCGNHFB(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Posible Ingredients"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("[MinePuzzleManager] Element {0} assigned to spawner {1} on piece {2}"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Networked Object "))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 845f)
		{
			PlayerInputs.GetPlayer(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(" : 00"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Honey"))
		{
			bouncer = true;
			playerNum = 2;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag(""))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 504f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("mainMenuMultiplayerButton"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag(":"))
		{
			bouncer = false;
			playerNum = 3;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Remove"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1311f)
		{
			PlayerInputs.GetPlayer(playerNum).SetVibration(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("MapCity"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1043"))
		{
			bouncer = false;
			playerNum = 6;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Trying to add a player that's already on the list."))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1060f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).KJGHGABOEGN(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void HIMBLFNCDLL(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Place"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("FishCuttingEvent/Talk2"))
		{
			bouncer = true;
			playerNum = 7;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Invalid playerNum"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1645f)
		{
			PlayerInputs.GetPlayer(playerNum).KJGHGABOEGN(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceivePlaceablesInsideBar"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("mForMins"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Bathouse Minigame has not been initialized. We must be in the bathhouseinterior scene."))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1214f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Rowdy/Entry/8/Dialogue Text"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("tutorialPopUp77"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_624"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 387f)
		{
			PlayerInputs.GetPlayer(playerNum).KJGHGABOEGN(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("HitCollider"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("HitCollider2"))
		{
			bouncer = false;
			playerNum = 2;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("HitColliderBouncer"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 0f)
		{
			PlayerInputs.GetPlayer(playerNum).SetVibration(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ThemeText"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("SwordActiveRPC"))
		{
			bouncer = true;
			playerNum = 8;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player Bed not found"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1600f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).DCNHJFFIDJB(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void LEKBKCLEEHE(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("CutEnd"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemBellPepperSeeds"))
		{
			bouncer = true;
			playerNum = 7;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Shield"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1471f)
		{
			PlayerInputs.GetPlayer(playerNum).MPJIPOBMOJK(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("DueloDeViejos/MainEvent"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("disableTutorial"))
		{
			bouncer = false;
			playerNum = 3;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Disabled"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1672f)
		{
			PlayerInputs.GetPlayer(playerNum).MPJIPOBMOJK(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("</color><br>"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Intro18"))
		{
			bouncer = false;
			playerNum = 8;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Tutorial/T107/Dialogue2"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1217f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).SetVibration(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemSickle"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player2"))
		{
			bouncer = false;
			playerNum = 4;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Gass_Quest/Entry/13/Dialogue Text"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 769f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("con {0} required tiles."))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Interaction was initiated, but the object is not in range. Only possible in online."))
		{
			bouncer = true;
			playerNum = 8;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("/"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1416f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Right Stick Button"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("[Puzzle Manager] - Voy a inicializar el current Puzzle que es de tipo "))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Distilling"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1956f)
		{
			PlayerInputs.GetPlayer(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void FJKGPAPACOI(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Open"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1130"))
		{
			bouncer = true;
			playerNum = 7;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Open"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1090f)
		{
			PlayerInputs.GetPlayer(playerNum).DCNHJFFIDJB(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void GAAKLENLEOF(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("TermasInterior/Kenta/Stand"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("MainProgress"))
		{
			bouncer = false;
			playerNum = 8;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_description_624"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 963f)
		{
			PlayerInputs.GetPlayer(playerNum).SetVibration(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void NKJMIFCPJFA(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/26/Dialogue Text"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Error_Mortar"))
		{
			bouncer = false;
			playerNum = 8;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/6/Dialogue Text"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 755f)
		{
			PlayerInputs.GetPlayer(playerNum).DCNHJFFIDJB(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(""))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_696"))
		{
			bouncer = false;
			playerNum = 5;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("NULL"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 372f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).DCNHJFFIDJB(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void PPJEJKCPCLC(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_description_673"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/16/Dialogue Text"))
		{
			bouncer = false;
			playerNum = 3;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Disabled"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1049f)
		{
			PlayerInputs.GetPlayer(playerNum).MPJIPOBMOJK(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveGenerateAvailableOrders"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Game is already running"))
		{
			bouncer = true;
			playerNum = 3;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Error_TableNeedsFreeSpace"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1793f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Received upgrade tool RPC for toolID: "))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("HarvestCut2"))
		{
			bouncer = false;
			playerNum = 5;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("UI2"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 347f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).DCNHJFFIDJB(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void DEOPBEHPEIN(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("InfoSectionCanvas/InfoSection"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("No path to psai soundtrack file set!"))
		{
			bouncer = false;
			playerNum = 7;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Incorrect room mode {0}"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 369f)
		{
			PlayerInputs.GetPlayer(playerNum).DCNHJFFIDJB(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void OOALHOHGANE(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Open"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Moving"))
		{
			bouncer = false;
			playerNum = 4;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/3/Dialogue Text"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 432f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_description_1109"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("MineFloor"))
		{
			bouncer = false;
			playerNum = 3;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Multiplayer"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 219f)
		{
			PlayerInputs.GetPlayer(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Disabled"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Multiplayer Object is null "))
		{
			bouncer = true;
			playerNum = 3;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("LE_21"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 764f)
		{
			PlayerInputs.GetPlayer(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("blackModulesParent null: {0}, "))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("/"))
		{
			bouncer = false;
			playerNum = 3;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("[OnlineLoadPuzzles] LoadPuzzleMessage: Found matching puzzle instance for mine level {0}. Setting reward collected: {1}, puzzle solved: {2}"))
		{
			bouncer = true;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 377f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).MPJIPOBMOJK(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1175"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("SendGameInfo"))
		{
			bouncer = true;
			playerNum = 7;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("mForMins"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 904f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("talentWoodwork"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("tutorialPopUp76"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("ValueSuitabilities"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 886f)
		{
			PlayerInputs.GetPlayer(playerNum).MPJIPOBMOJK(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("No bed assigned to actor number: {0}"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Items/item_name_1179"))
		{
			bouncer = false;
			playerNum = 7;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("FocusedMod"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 1493f)
		{
			PlayerInputs.DEGBDMMDIIL(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		playerNum = 0;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("/"))
		{
			bouncer = false;
			playerNum = 1;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("CultivableDuringTwoMonths"))
		{
			bouncer = false;
			playerNum = 2;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Inventory"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 125f)
		{
			PlayerInputs.GetPlayer(playerNum).GGKDNIMLGBJ(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("weedsCut"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Can't find seat. Reason: lastOrders"))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("SkeletonBird"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 298f)
		{
			PlayerInputs.GetPlayer(playerNum).MPJIPOBMOJK(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}

	private void EMCFHILONOH(Collider2D HANHCHBHHEH)
	{
		playerNum = 1;
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("NO SE HA PODIDO GENERAR EL PUZZLE - ERROR!!"))
		{
			bouncer = false;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag("Direction"))
		{
			bouncer = true;
			playerNum = 6;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		else if (((Component)HANHCHBHHEH).gameObject.CompareTag(""))
		{
			bouncer = true;
			playerNum = 0;
			if (actionToDo != null)
			{
				actionToDo.Invoke();
			}
		}
		if (playerNum != 0 && shakeDuration > 202f)
		{
			PlayerInputs.GetPlayer(playerNum).HMJBGJJOBKH(gamepadShakeIntensity, gamepadTremblingIntensity, shakeDuration);
		}
	}
}
