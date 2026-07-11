using UnityEngine;

public class DisableCollidersOnEnter : MonoBehaviour
{
	[HideInInspector]
	public bool inside;

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(""))
		{
			PlayerController.AddTriggerEnabler(1, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("sForSeconds"))
		{
			PlayerController.AddTriggerEnabler(4, (Object)(object)this);
			inside = true;
		}
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("AdjustingGraphicsQuality"))
		{
			PlayerController.LLAFBAEFPLI(0, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Item Transaction. PERK!!"))
		{
			PlayerController.RemoveTriggerEnabler(6, (Object)(object)this);
			inside = true;
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("stop weather"))
		{
			PlayerController.AddTriggerEnabler(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Door"))
		{
			PlayerController.IMLMLIIIJCH(6, (Object)(object)this);
			inside = false;
		}
	}

	private void KKEPLLEAAMB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveCursorMove"))
		{
			PlayerController.LLAFBAEFPLI(0, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("<b><color=#A90000>"))
		{
			PlayerController.LLAFBAEFPLI(1, (Object)(object)this);
			inside = true;
		}
	}

	private void IBINNLHHLMD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("TrayTrigger"))
		{
			PlayerController.RemoveTriggerEnabler(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("piratescave"))
		{
			PlayerController.RemoveTriggerEnabler(5, (Object)(object)this);
			inside = true;
		}
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Floor_3"))
		{
			PlayerController.JMAIKINGIFL(0, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Prices"))
		{
			PlayerController.RemoveTriggerEnabler(8, (Object)(object)this);
			inside = true;
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("cameraZoom"))
		{
			PlayerController.AddTriggerEnabler(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("[SelectSpawnersByMaxDistance] entrance:{0} altar:{1} exit:{2}. Need {3} from {4} candidates."))
		{
			PlayerController.AddTriggerEnabler(3, (Object)(object)this);
			inside = true;
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player"))
		{
			PlayerController.AddTriggerEnabler(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player2"))
		{
			PlayerController.AddTriggerEnabler(2, (Object)(object)this);
			inside = true;
		}
	}

	private void OCEIGDHOJJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Open"))
		{
			PlayerController.LLAFBAEFPLI(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("==============================\n"))
		{
			PlayerController.JMAIKINGIFL(8, (Object)(object)this);
			inside = false;
		}
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Festín del Juramento/MaiDialogue 05"))
		{
			PlayerController.JMAIKINGIFL(1, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("LE_21"))
		{
			PlayerController.JMAIKINGIFL(3, (Object)(object)this);
			inside = false;
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemRoseWineJuice"))
		{
			PlayerController.AddTriggerEnabler(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("city travelling"))
		{
			PlayerController.AddTriggerEnabler(8, (Object)(object)this);
			inside = true;
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/6/Dialogue Text"))
		{
			PlayerController.JMAIKINGIFL(0, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("LearnPrecision"))
		{
			PlayerController.RemoveTriggerEnabler(6, (Object)(object)this);
			inside = false;
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Interact"))
		{
			PlayerController.AddTriggerEnabler(0, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(" decoFloorId: "))
		{
			PlayerController.AddTriggerEnabler(7, (Object)(object)this);
			inside = true;
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Cat"))
		{
			PlayerController.IMLMLIIIJCH(1, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Rotate"))
		{
			PlayerController.AddTriggerEnabler(0, (Object)(object)this);
			inside = false;
		}
	}

	private void FCOMECPDBDN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("R2"))
		{
			PlayerController.RemoveTriggerEnabler(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("cameraZoom2"))
		{
			PlayerController.RemoveTriggerEnabler(7, (Object)(object)this);
			inside = false;
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemIPAWort"))
		{
			PlayerController.IMLMLIIIJCH(0, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Tavern must be closed"))
		{
			PlayerController.IMLMLIIIJCH(7, (Object)(object)this);
			inside = true;
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ClosePopUp"))
		{
			PlayerController.IMLMLIIIJCH(1, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("LE_13"))
		{
			PlayerController.IMLMLIIIJCH(0, (Object)(object)this);
			inside = true;
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("\n"))
		{
			PlayerController.IMLMLIIIJCH(1, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("-"))
		{
			PlayerController.IMLMLIIIJCH(6, (Object)(object)this);
			inside = false;
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player"))
		{
			PlayerController.RemoveTriggerEnabler(1, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player2"))
		{
			PlayerController.RemoveTriggerEnabler(2, (Object)(object)this);
			inside = false;
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Precision/DrinkEvent4"))
		{
			PlayerController.AddTriggerEnabler(1, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Interact"))
		{
			PlayerController.IMLMLIIIJCH(5, (Object)(object)this);
			inside = true;
		}
	}

	private void NAFADNEKCOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("kickedCustomers"))
		{
			PlayerController.LLAFBAEFPLI(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(":"))
		{
			PlayerController.LLAFBAEFPLI(3, (Object)(object)this);
			inside = false;
		}
	}

	private void DAGGKPKBCLD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("talent_name_105"))
		{
			PlayerController.JMAIKINGIFL(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Exit build mode"))
		{
			PlayerController.RemoveTriggerEnabler(0, (Object)(object)this);
			inside = false;
		}
	}

	private void ILNDDFELMKL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("OnFloor"))
		{
			PlayerController.JMAIKINGIFL(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Another player already exists from online sync."))
		{
			PlayerController.JMAIKINGIFL(6, (Object)(object)this);
			inside = true;
		}
	}

	private void EKJIEGLPBLA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Attack/MainEvent 7"))
		{
			PlayerController.JMAIKINGIFL(0, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemRaspberrySeeds"))
		{
			PlayerController.JMAIKINGIFL(8, (Object)(object)this);
			inside = false;
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveStartCrowlyEvent"))
		{
			PlayerController.IMLMLIIIJCH(0, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ConnectionTimeout"))
		{
			PlayerController.AddTriggerEnabler(3, (Object)(object)this);
			inside = true;
		}
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("end conversation"))
		{
			PlayerController.LLAFBAEFPLI(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Error_StairsAreBlocking"))
		{
			PlayerController.RemoveTriggerEnabler(2, (Object)(object)this);
			inside = false;
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(""))
		{
			PlayerController.IMLMLIIIJCH(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Klayn not find path to at "))
		{
			PlayerController.IMLMLIIIJCH(4, (Object)(object)this);
			inside = false;
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveUnlockChristmasRecipes"))
		{
			PlayerController.IMLMLIIIJCH(1, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("showui"))
		{
			PlayerController.AddTriggerEnabler(4, (Object)(object)this);
			inside = false;
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("itemHoney"))
		{
			PlayerController.IMLMLIIIJCH(0, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("CatOfFriend"))
		{
			PlayerController.AddTriggerEnabler(4, (Object)(object)this);
			inside = false;
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("popUpBuilding38"))
		{
			PlayerController.AddTriggerEnabler(0, (Object)(object)this);
			inside = true;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Old KEG "))
		{
			PlayerController.IMLMLIIIJCH(0, (Object)(object)this);
			inside = false;
		}
	}

	private void DAJNPOGFLLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Table"))
		{
			PlayerController.LLAFBAEFPLI(0, (Object)(object)this);
			inside = false;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/TooDark/Entry/8/Dialogue Text"))
		{
			PlayerController.JMAIKINGIFL(6, (Object)(object)this);
			inside = false;
		}
	}
}
