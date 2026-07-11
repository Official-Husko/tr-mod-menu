using AlmenaraGames;
using UnityEngine;

public class FootstepObjectSound : MonoBehaviour
{
	public AudioObject sound;

	[SerializeField]
	private bool checkForPlayerSortingOrder;

	[SerializeField]
	private int desiredSortingOrderNumber;

	private void EDCINHFBGAN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tray"))
		{
			Footsteps.instance.GCEOCONCEME(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Gameplay"))
		{
			Footsteps.instance.DPINBENFHHP(this, 2);
		}
	}

	private void BNOJNEJMCID(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/CantDoYet"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.OEAFBOHIADI(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Walk") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(3).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.GANOHDDECCD(this, 8);
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Eat"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DKHCHMJNCNP(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("selected_objects") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(4).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.DKHCHMJNCNP(this, 8);
		}
	}

	private void NAFADNEKCOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" / "))
		{
			Footsteps.instance.HHEBAILPGMA(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Pool Object from "))
		{
			Footsteps.instance.HHEBAILPGMA(this, 0);
		}
	}

	private void BLOCHBJIICN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemJerky"))
		{
			Footsteps.instance.JPMMLHHIDMD(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Collider "))
		{
			Footsteps.instance.GCEOCONCEME(this, 0);
		}
	}

	private void AIOJHEKNMIC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("bath travelling"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.OEAFBOHIADI(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" (") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(8).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.SetAudio(this, 0);
		}
	}

	private void INBCLBHEBKE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(")"))
		{
			Footsteps.instance.DPINBENFHHP(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ZoneCostBonus"))
		{
			Footsteps.instance.DPINBENFHHP(this, 5);
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player/Bark/Tutorial/CrafterBlock"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DKHCHMJNCNP(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Waiting for season change done") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(8).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.OEAFBOHIADI(this, 7);
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Rich presence "))
		{
			if (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DNOKGIDFDKG(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_1") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(5).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.SetAudio(this, 3);
		}
	}

	private void DJNNHILGACE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" with less than 6 drinks"))
		{
			Footsteps.instance.GCEOCONCEME(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error: could not find player with name "))
		{
			Footsteps.instance.RemoveAudio(this, 3);
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("MainProgress"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BirdInteract"))
		{
			Footsteps.instance.RemoveAudio(this, 0);
		}
	}

	private void MOOJEOLFOOC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("<b><color=#A90000>"))
		{
			Footsteps.instance.IHJDPDCGLCI(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveTicketPrice"))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 8);
		}
	}

	private void EKNEIMIENPG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			Footsteps.instance.HHEBAILPGMA(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/BirdPositiveComments/Entry/3/Dialogue Text"))
		{
			Footsteps.instance.JPMMLHHIDMD(this, 2);
		}
	}

	private void APJFDMCLDBD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveRockStartInformation"))
		{
			Footsteps.instance.JJHBCMFMMOM(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T117/Dialogue2"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 7);
		}
	}

	private void ONNMDGBPGEI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" is not fish"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DKHCHMJNCNP(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Ach_") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.DKHCHMJNCNP(this, 4);
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("NinjaChallengeEvent/Lose 2"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DNOKGIDFDKG(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cannot abandon") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(3).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.LOMAMCDELHL(this, 4);
		}
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T110/Dialogue1"))
		{
			Footsteps.instance.JJHBCMFMMOM(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" nulo en "))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 3);
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("OnBecameInvisible"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DNOKGIDFDKG(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_644") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(7).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.LOMAMCDELHL(this, 8);
		}
	}

	private void FCOMECPDBDN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Hikari/Quest"))
		{
			Footsteps.instance.JJHBCMFMMOM(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 1);
		}
	}

	private void PFIONHCONDI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ObjectVerticalMove"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DNOKGIDFDKG(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("chatSounds") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(8).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.LOMAMCDELHL(this, 4);
		}
	}

	private void DAJNPOGFLLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" world door: "))
		{
			Footsteps.instance.JPMMLHHIDMD(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/BirdNegativeComments/Entry/5/Dialogue Text"))
		{
			Footsteps.instance.DPINBENFHHP(this, 7);
		}
	}

	private void OOALHOHGANE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Object"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.GANOHDDECCD(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("stormy") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(2).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.LOMAMCDELHL(this, 4);
		}
	}

	private void KKEPLLEAAMB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BeginFishCuttingMinigameRequest"))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("repUnlockOrderQuest"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 4);
		}
	}

	private void NIPJAFAPNCP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveNewLetter"))
		{
			Footsteps.instance.GCEOCONCEME(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("in"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 0);
		}
	}

	private void NDDNAEAMADD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Walk"))
		{
			Footsteps.instance.IHJDPDCGLCI(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("autoRun"))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 8);
		}
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("NoEresDigno/EndEvent2"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DNOKGIDFDKG(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_5") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(0).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.LOMAMCDELHL(this, 6);
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BForBook"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.LOMAMCDELHL(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UIInteract") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(6).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.DKHCHMJNCNP(this, 2);
		}
	}

	private void NKJMIFCPJFA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Offer"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DKHCHMJNCNP(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(4).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.SetAudio(this, 8);
		}
	}

	private void CMJBBBHGHCD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Disconnecting..."))
		{
			Footsteps.instance.JPMMLHHIDMD(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Pull beer"))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 6);
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			Footsteps.instance.RemoveAudio(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			Footsteps.instance.RemoveAudio(this, 2);
		}
	}

	private void DGLMPEODEKI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("TableDirty"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveStackContainer"))
		{
			Footsteps.instance.JPMMLHHIDMD(this, 8);
		}
	}

	private void IBINNLHHLMD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			Footsteps.instance.RemoveAudio(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Eating"))
		{
			Footsteps.instance.DPINBENFHHP(this, 5);
		}
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Bartender"))
		{
			Footsteps.instance.GCEOCONCEME(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemThymeSeeds"))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 0);
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ThemeText"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.NIGAKGOLEFP(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveHireWorker") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(5).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.NIGAKGOLEFP(this, 0);
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("CannotPickUpWhileWorking"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.GANOHDDECCD(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("\n") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(0).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.SetAudio(this, 4);
		}
	}

	private void NBHAMBCMEGD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("The mine piece "))
		{
			Footsteps.instance.RemoveAudio(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_593"))
		{
			Footsteps.instance.RemoveAudio(this, 3);
		}
	}

	private void BNNLNCGNHFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LearnPrecision"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.OEAFBOHIADI(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(".png") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(3).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.SetAudio(this, 6);
		}
	}

	private void FJKGPAPACOI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/10/Dialogue Text"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DKHCHMJNCNP(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Tutorial/Barn_Holly") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(8).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.NIGAKGOLEFP(this, 8);
		}
	}

	private void EMCFHILONOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_605"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.GANOHDDECCD(this, 0);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("TutorialPhase") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(2).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.LOMAMCDELHL(this, 1);
		}
	}

	private void FCMFGPKMKBI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/1/Dialogue Text"))
		{
			Footsteps.instance.JJHBCMFMMOM(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Fill"))
		{
			Footsteps.instance.IHJDPDCGLCI(this, 2);
		}
	}

	private void EKJIEGLPBLA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("IngameInvite"))
		{
			Footsteps.instance.RemoveAudio(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Desconocido"))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 5);
		}
	}

	private void ICKIIAHACEH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Interact"))
		{
			Footsteps.instance.JPMMLHHIDMD(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			Footsteps.instance.JPMMLHHIDMD(this, 4);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.SetAudio(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2") && (!checkForPlayerSortingOrder || PlayerController.GetPlayer(2).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.SetAudio(this, 2);
		}
	}

	private void PDCJGGJMPCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Done Loading Online Scripts"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.DNOKGIDFDKG(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ActionBar4") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(0).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.OEAFBOHIADI(this, 1);
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T122/Dialogue3"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(1).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.NIGAKGOLEFP(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BathhouseGameManager: Pool not found.") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(0).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.DKHCHMJNCNP(this, 2);
		}
	}

	private void BINMHNJBDNI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Listen"))
		{
			Footsteps.instance.IHJDPDCGLCI(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Error_Stones"))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 8);
		}
	}

	private void KEICGGPGIED(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" totalMsgs: "))
		{
			Footsteps.instance.IHJDPDCGLCI(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" OnCharacterStateChanged"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 3);
		}
	}

	private void OCEIGDHOJJM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("creating level"))
		{
			Footsteps.instance.GCEOCONCEME(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("BaseCamp"))
		{
			Footsteps.instance.RemoveAudio(this, 0);
		}
	}

	private void DAGGKPKBCLD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" not found. Cannot receive permission accepted"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Sell"))
		{
			Footsteps.instance.CNKGMLGNPGL(this, 3);
		}
	}

	private void NICLCHABAMK(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("CursorSensitivity"))
		{
			Footsteps.instance.JPMMLHHIDMD(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Players win!"))
		{
			Footsteps.instance.DPINBENFHHP(this, 7);
		}
	}

	private void MKCEGNPBGMP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemSweetPotatoSeeds"))
		{
			Footsteps.instance.RemoveAudio(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Kyroh doesnt has drinks in tray"))
		{
			Footsteps.instance.GCEOCONCEME(this, 6);
		}
	}

	private void FKILALCMOOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(".png"))
		{
			Footsteps.instance.HHEBAILPGMA(this, 1);
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			Footsteps.instance.HHEBAILPGMA(this, 7);
		}
	}

	private void HHGJLOKEPJE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Requirements not met"))
		{
			Footsteps.instance.IHJDPDCGLCI(this, 0);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("FloorDirt"))
		{
			Footsteps.instance.GCEOCONCEME(this, 7);
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("CannotPickUpWhileWorking"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.LOMAMCDELHL(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Cheese making") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(2).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.LOMAMCDELHL(this, 7);
		}
	}

	private void PPJEJKCPCLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("snow"))
		{
			if (!checkForPlayerSortingOrder || PlayerController.GetPlayer(0).sortingGroup.sortingOrder == desiredSortingOrderNumber)
			{
				Footsteps.instance.SetAudio(this, 1);
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemAromaHopsSeeds") && (!checkForPlayerSortingOrder || PlayerController.OPHDCMJLLEC(1).sortingGroup.sortingOrder == desiredSortingOrderNumber))
		{
			Footsteps.instance.LOMAMCDELHL(this, 2);
		}
	}
}
