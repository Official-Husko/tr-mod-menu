using System.Linq;
using UnityEngine;

public class CustomerStateSpawning : CustomerStateBase
{
	private bool OEBNHGNJEJL;

	private int FNNAHIHFCLA()
	{
		if (!WorldTime.isNight)
		{
			return 13;
		}
		return 1;
	}

	private void JLFMAHMNNFE(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)PNPNDEOAHAI())
		{
			Debug.Log((object)("Left Stick Left" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "add item " + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("PhaseItem" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"ReceiveCollectItems");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"[ProceduralMine] ALTAR: No valid piece for path dir={0} at block {1}. Candidates: {2}. Retrying next iteration.");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Trying to add player but player list is full.");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		BarMenuManager.GIFDOGOMAFL();
		if (Random.Range(0, 1) <= 12 + MCBDOADMCJD())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private void HOKOEGKNICO(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)HMJEJFAHEKJ())
		{
			Debug.Log((object)(")" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Return To Last Basic Mood" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Dialogue System/Conversation/TooCold/Entry/5/Dialogue Text");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"UINextPage");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)":</color> ");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, -77) <= 94 + BDGNJKKHBKP())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool FOMMPFPAKII()
	{
		float num = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 174f);
		float num2 = num / NPCRoadManager.MBJINBKDIHC();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(1005f, 136f, num2) : 675f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"No puzzles found for steps={0}, ");
			}
			return true;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"DecorationTile_6");
			}
			return true;
		}
		if (Random.Range(945f, 1416f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 65)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_701");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"There was an error reading the input text. Most likely incorrect length.");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != 0)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"itemMint");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.LDMNFGMCNOJ())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Player_Bark_2PlayersChest");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Inventory full");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveHit");
			}
			return true;
		}
		return false;
	}

	private bool ELNNFFBFFOP()
	{
		float num = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.LNHPEHJLPNF().Length)) : 1509f);
		float num2 = num / NPCRoadManager.CDEHEEAMLIA();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(1809f, 1317f, num2) : 1989f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"\n");
			}
			return true;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Floor_2");
			}
			return false;
		}
		if (Random.Range(1474f, 1874f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -56)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"OnFaceActivationRPC");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_4");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.WithoutZone)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_626");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.GetMaxCustomersDisponible())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Actionbar 1");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"FarmReady");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Disabled");
			}
			return true;
		}
		return true;
	}

	private bool BIKLMDPJFEB()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 605f);
		float num2 = num / NPCRoadManager.OINJEPAPOCB();
		float num3 = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? Mathf.Lerp(1388f, 1107f, num2) : 1420f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Interact");
			}
			return true;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"quest_description_");
			}
			return true;
		}
		if (Random.Range(366f, 843f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 15)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Player/Bark/Tutorial/AgingBarrelBlock");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Close");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.DiningRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"tavern");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.LDMNFGMCNOJ())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"PlayerLeftBed");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Disabled");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Close");
			}
			return false;
		}
		return true;
	}

	private bool CGMMMPDGPKF()
	{
		float num = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.LNHPEHJLPNF().Length)) : 437f);
		float num2 = num / NPCRoadManager.DALPDIJOAGM();
		float num3 = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? Mathf.Lerp(1013f, 1510f, num2) : 1251f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"mForMins");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"JOYSTICKS\n");
			}
			return false;
		}
		if (Random.Range(1745f, 1348f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 11)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveEmployeeTask");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/Crowly_Barks_Shop/Entry/5/Dialogue Text");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != 0)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Hikari/Introduce");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"https://discord.gg/7rBtuZb");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"dog ");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" / ");
			}
			return true;
		}
		return true;
	}

	private int EMKDINPIOEN()
	{
		if (!WorldTime.isNight)
		{
			return 53;
		}
		return 0;
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		if (IDLMKLPCIPB())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can find Seat");
			}
			((Component)JHIFLALPEBF).gameObject.GetComponent<Customer>();
			new SeatFinder().GMHHCAJIJGP(JHIFLALPEBF, EFADOCDHPKG);
			CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1f;
		}
		else
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find Seat");
			}
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
	}

	private void BFDBOGBCFHA(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)PNPNDEOAHAI())
		{
			Debug.Log((object)("Active Player Count: " + ((Object)((Component)PJNGMCJIHME).gameObject).name + "F2" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("AnimatorObjectStateRequest" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Rotate");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_18");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)": ");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		BarMenuManager.GetAvailableItemInstances();
		if (Random.Range(1, -114) <= -100 + FMKHEKLEAJG())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private int JJPMPIOMLDP()
	{
		if (!WorldTime.isNight)
		{
			return -100;
		}
		return 0;
	}

	private void NBLFDEIKLIB(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)MHOMONJLOBL())
		{
			Debug.Log((object)("No" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Right Stick Left" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("Enter" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Quit to title screen?");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveExitInteraction");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"ReceiveObjectAction");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
		BarMenuManager.GetAvailableItemInstances();
		if (Random.Range(0, 57) <= 65 + MHLMEAIMHPH())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool JKEHCDFCKHN()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.LNHPEHJLPNF().Length)) : 651f);
		float num2 = num / NPCRoadManager.OINJEPAPOCB();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(1918f, 1334f, num2) : 467f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveKick");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Wilson/Bark/Bark_Clue");
			}
			return false;
		}
		if (Random.Range(607f, 172f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -53)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"FishCuttingEvent/RetryTalk");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"<sprite name=\"woodIcon\">");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"\\[BartenderGender=[^\\]]*\\]");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.GetMaxCustomersDisponible())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" ");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Exit build mode");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Selected");
			}
			return false;
		}
		return true;
	}

	private void KGHMGFOCBMH(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)MKFCKADLFPM())
		{
			Debug.Log((object)(" : 00" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "TutorialPhase" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("]" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Kicking player on bed {0} with actor number {1}");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveDisableNPC");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Near");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, -126) <= 20 + MEFBKABDMNF())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private void DNCLMKPCFLD(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)LCLNMMCICJG())
		{
			Debug.Log((object)("[ControllerType:" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Player" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("Failed to set rich presence key " + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Pasamos aplicación a ventana");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Player2_Bark_2PlayersChest");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, -6) <= -58 + MHLMEAIMHPH())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private void MICGFMJNFLP(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)IAEKIGLIHCO())
		{
			Debug.Log((object)("Aromatic" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "psai: The game object lacks a local Collider component for psai Trigger: {0}" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)(" with less than 6 ingredients" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Dialogue System/Conversation/EnterTavernDrink/Entry/2/Dialogue Text");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Ground");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Use");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		BarMenuManager.GetAvailableItemInstances();
		if (Random.Range(1, -51) <= -11 + EMKDINPIOEN())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private void OJEOBFNNBOL(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)GetStateEnumID())
		{
			Debug.Log((object)("/" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "ErrorServerTimeout" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("Scratch" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"No se ha vinculado el sprite renderer en ");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"BecomeNuisance");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		BarMenuManager.GIFDOGOMAFL();
		if (Random.Range(1, 90) <= 122 + BDGNJKKHBKP())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool PLPCKKMCEHH()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.OGDDCMFDCAH().Length)) : 1435f);
		float num2 = num / NPCRoadManager.GJJKMODBFAB();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(1330f, 1318f, num2) : 37f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" ");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Bark");
			}
			return true;
		}
		if (Random.Range(1337f, 297f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -96)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Highest Room ID: {0}");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"EXTRA ZONES: ");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_635");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.GetMaxCustomersDisponible())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)".gz");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"\n<color=#BF0000>");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"NPCWalkTo is null in NPCRoutine. Make sure the routine ");
			}
			return false;
		}
		return true;
	}

	private bool ONAMHEBEOOJ()
	{
		float num = ((TavernSeatingManager.DKFBAGJBPGP().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 1083f);
		float num2 = num / NPCRoadManager.BOJNKHGCIPE();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(235f, 1339f, num2) : 33f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Mooruroa");
			}
			return true;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Received PlaceableMsg of another type not AnimalMessage to ");
			}
			return false;
		}
		if (Random.Range(1222f, 153f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -75)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Selected values:\n");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Trying to add player but player list is full.");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.CraftingRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.JLAMIIDFILF())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Christmas/Ace/Intro");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveAddKickedCustomer");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Barrel");
			}
			return false;
		}
		return true;
	}

	private bool KHBNCBDKEIL()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 209f);
		float num2 = num / NPCRoadManager.IJOJFICLAAF();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(1751f, 36f, num2) : 1015f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Error_FloorTilesLimit");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveAddReputationPoints");
			}
			return true;
		}
		if (Random.Range(480f, 1996f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 1)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"PlaceOnATable");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveStartCrowlyEvent");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.RentedRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Collect");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.IANAPDACKLA())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"no ing");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" is drinking sake. numDrinks: ");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_8");
			}
			return false;
		}
		return true;
	}

	private void IKKEMIAJGIG(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)NAENMNNCHIO())
		{
			Debug.Log((object)("Serve" + ((Object)((Component)PJNGMCJIHME).gameObject).name + " " + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("Pick up" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Pull beer");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"DemolishConfirmation");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Selected values:\n");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, -49) <= 100 + JJPMPIOMLDP())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool MMNFNCDBGIL()
	{
		float num = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.DKFBAGJBPGP().Length)) : 1949f);
		float num2 = num / NPCRoadManager.CDEHEEAMLIA();
		float num3 = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? Mathf.Lerp(476f, 1753f, num2) : 1914f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/TooHot/Entry/5/Dialogue Text");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: MaxCustomer");
			}
			return true;
		}
		if (Random.Range(396f, 1415f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -100)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveDoneLoading");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Invalid symbol index {0}");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/24/Dialogue Text");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.IANAPDACKLA())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"in");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Shovah3D");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Item Transaction. PERK!!");
			}
			return true;
		}
		return true;
	}

	private int BDGNJKKHBKP()
	{
		if (!WorldTime.isNight)
		{
			return -126;
		}
		return 1;
	}

	private int MCBDOADMCJD()
	{
		if (!WorldTime.isNight)
		{
			return 113;
		}
		return 1;
	}

	private bool HCHMNHNDCIJ()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.GAGEINOKNAK.Length)) : 1014f);
		float num2 = num / NPCRoadManager.EIPIMCOGMDG();
		float num3 = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? Mathf.Lerp(227f, 1014f, num2) : 1591f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"MineFloor");
			}
			return true;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"");
			}
			return false;
		}
		if (Random.Range(1315f, 413f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -66)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Desactivado: ");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"action");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.DiningRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_10");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_1183");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"</color>");
			}
			return false;
		}
		return false;
	}

	private bool IDLMKLPCIPB()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.GAGEINOKNAK.Length)) : 1f);
		float num2 = num / NPCRoadManager.GetCapacity();
		float num3 = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? Mathf.Lerp(1f, 0.5f, num2) : 0f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Important Guest");
			}
			return true;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: CustomerEnterTime");
			}
			return false;
		}
		if (Random.Range(0f, 1f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 115)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: enterChance");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: Tavern Closed");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.DiningRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: DiningRoom");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.GetMaxCustomersDisponible())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: MaxCustomer");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: lastOrders");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: customersWaitingSeat");
			}
			return false;
		}
		return true;
	}

	private int AIOKONLCNCL()
	{
		if (!WorldTime.isNight)
		{
			return 47;
		}
		return 0;
	}

	private int MEFBKABDMNF()
	{
		if (!WorldTime.isNight)
		{
			return -36;
		}
		return 0;
	}

	private void PLDPNCIGAII(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)HMJEJFAHEKJ())
		{
			Debug.Log((object)("Cancel" + ((Object)((Component)PJNGMCJIHME).gameObject).name + " not found. Cannot receive permission accepted to player " + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("City/Agatha/Bark/Buy" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Duplicate crafting room lock found");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"_");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"New");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		BarMenuManager.GIFDOGOMAFL();
		if (Random.Range(1, -127) <= -75 + CLDDBAJPBOM())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private void INOGJKEIGFC(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)PCAHAEIHBBB())
		{
			Debug.Log((object)("D-Pad Up" + ((Object)((Component)PJNGMCJIHME).gameObject).name + " share request sent" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("</color>" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Winner");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Unaged Rum");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Hair");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		BarMenuManager.GetAvailableItemInstances();
		if (Random.Range(1, 93) <= 19 + LGEPGMGKJDI())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private void EFADOCDHPKG(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)GetStateEnumID())
		{
			Debug.Log((object)("Customer " + ((Object)((Component)PJNGMCJIHME).gameObject).name + " tried to do seat found being in state " + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("Customer tried to do seat found with close tavern " + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"SeatFound...");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"...Failed");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"...Successfully");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		BarMenuManager.GetAvailableItemInstances();
		if (Random.Range(0, 100) <= 50 + DOGIEBBMDIC())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private int CKBELEAPJHE()
	{
		if (!WorldTime.isNight)
		{
			return -47;
		}
		return 1;
	}

	private bool GLLAHPOMAHH()
	{
		float num = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.GAGEINOKNAK.Length)) : 1248f);
		float num2 = num / NPCRoadManager.OPDLKJHAHOH();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(1124f, 264f, num2) : 1703f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_643");
			}
			return true;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"itemButter");
			}
			return true;
		}
		if (Random.Range(1084f, 1801f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 94)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"DisableRight");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveEndIntroLucen");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.WithoutZone)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Accept order");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.IANAPDACKLA())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Brook Recipe active");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" giveRewards: ");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"OldMansDuelEvent OnTravelZoneTo");
			}
			return false;
		}
		return false;
	}

	private bool EFGFKAKGBOF()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.LNHPEHJLPNF().Length)) : 278f);
		float num2 = num / NPCRoadManager.GetCapacity();
		float num3 = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? Mathf.Lerp(818f, 1229f, num2) : 526f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"A number is needed.");
			}
			return true;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Farm/Bob/Stand");
			}
			return false;
		}
		if (Random.Range(988f, 746f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 75)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_13");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"chatx");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Cat");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.LDMNFGMCNOJ())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"PhaseItem");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"itemWheatFlour");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LearnPrecision");
			}
			return true;
		}
		return true;
	}

	private void PJCEEMDPFBO(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)MKFCKADLFPM())
		{
			Debug.Log((object)("LearnBalance" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Grain" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("Left Stick Down" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Colliders encontrados: ");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Update all floor");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, -91) <= -44 + JPHECMAFCEA())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool GBFBMGMKCJO()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.DKFBAGJBPGP().Length)) : 217f);
		float num2 = num / NPCRoadManager.GetCapacity();
		float num3 = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? Mathf.Lerp(1804f, 370f, num2) : 1164f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Start water quality test");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"time");
			}
			return false;
		}
		if (Random.Range(1320f, 901f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -50)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Calendar");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveSkipTypewriter");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.RentedRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Drunk");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Multiplayer");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_591");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"IntensityBars");
			}
			return true;
		}
		return false;
	}

	private bool PNLKGHMIGNF()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.LNHPEHJLPNF().Length)) : 193f);
		float num2 = num / NPCRoadManager.FIJKELGCGJK();
		float num3 = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? Mathf.Lerp(135f, 1274f, num2) : 66f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"City/PetShop/Nessy/PerritosAbandonados2");
			}
			return true;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveSimpleEvent");
			}
			return false;
		}
		if (Random.Range(191f, 1263f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -105)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" 0");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"-");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.CraftingRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"SetAnimatorObjectStateRPC");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.JLAMIIDFILF())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dog");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"\n");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Interact");
			}
			return false;
		}
		return false;
	}

	private int MPEFMHJKEOO()
	{
		if (!WorldTime.isNight)
		{
			return -123;
		}
		return 0;
	}

	private void GMOFEEEJCNC(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)LCLNMMCICJG())
		{
			Debug.Log((object)("{0} doesn't have a parameter with that hash." + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Dialogue System/Conversation/Crowly_Standar/Entry/29/Dialogue Text" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Standar/Entry/13/Dialogue Text" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Hurt");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Speed");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"BanquetDrinksManager instance is null");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(1, -80) <= -108 + CKBELEAPJHE())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool IAGPIGOPNLO()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.DKFBAGJBPGP().Length)) : 532f);
		float num2 = num / NPCRoadManager.DALPDIJOAGM();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(1260f, 1888f, num2) : 792f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveLoadRecipes");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Object ");
			}
			return false;
		}
		if (Random.Range(434f, 682f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -128)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Trying to add player but player list is full.");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"City/Woody/Introduce");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.RentedRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/Rowdy/Entry/6/Dialogue Text");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Tray");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Tray");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Input field already has console support component: {0}");
			}
			return true;
		}
		return true;
	}

	private bool CFOIPAEGLHB()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.OGDDCMFDCAH().Length)) : 1142f);
		float num2 = num / NPCRoadManager.DALPDIJOAGM();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(1629f, 572f, num2) : 1945f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Disabled");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Cannot create Steam lobby.");
			}
			return false;
		}
		if (Random.Range(558f, 1296f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -82)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Scratch");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"DecorationTile_11");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.RentedRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveOrderRequestNinjaCustomer");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" appearance data: ");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)") recipes locked");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"AvailableQuests doesnt exist");
			}
			return true;
		}
		return false;
	}

	private void FGEDOMODFAE(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)PCAHAEIHBBB())
		{
			Debug.Log((object)(" " + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Items/item_name_1088" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("ReceiveSetDrinkColorMaster" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"ThrowSpikes");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"]");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		BarMenuManager.GetAvailableItemInstances();
		if (Random.Range(1, 123) <= -115 + JJPMPIOMLDP())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private int AIOOIMIHFCA()
	{
		if (!WorldTime.isNight)
		{
			return 58;
		}
		return 1;
	}

	private bool NGGKEIGHOMH()
	{
		float num = ((TavernSeatingManager.DKFBAGJBPGP().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 738f);
		float num2 = num / NPCRoadManager.OINJEPAPOCB();
		float num3 = ((TavernSeatingManager.DKFBAGJBPGP().Length != 0) ? Mathf.Lerp(609f, 1493f, num2) : 1738f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/Gass_Stand/Entry/14/Dialogue Text");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"No Older Version");
			}
			return false;
		}
		if (Random.Range(1253f, 8f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -71)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Quit to title screen?");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"perHour");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.WithoutZone)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"buildingObjective_2_1");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_1177");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"[MinePuzzleManager] Could not select enough spread spawners for {0}. Trying another type.");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Player Awake error on ");
			}
			return false;
		}
		return true;
	}

	private bool GFGOABPLMEE()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 1550f);
		float num2 = num / NPCRoadManager.FIJKELGCGJK();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(1913f, 1319f, num2) : 810f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Text");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"KyrohPreparingFood: Other player has advantage, going to WaitingToServe.");
			}
			return true;
		}
		if (Random.Range(1802f, 1417f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -117)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ActiveDecoMode");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_16");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.RentedRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Back Quote");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Interact");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_611");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_692");
			}
			return false;
		}
		return true;
	}

	private bool LMIFMBIBDCJ()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.OGDDCMFDCAH().Length)) : 898f);
		float num2 = num / NPCRoadManager.FIJKELGCGJK();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(924f, 1418f, num2) : 1518f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"\n");
			}
			return true;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_1124");
			}
			return false;
		}
		if (Random.Range(798f, 832f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 83)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Failed to load psai soundtrack from path '");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)".");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != 0)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"???");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.IANAPDACKLA())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" for reason ");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"NotEnoughProfessionPoints");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/TavernFilthy/Entry/9/Dialogue Text");
			}
			return true;
		}
		return true;
	}

	private void NALPIKDGPKD(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)KFICKCHHNKA())
		{
			Debug.Log((object)("Chop" + ((Object)((Component)PJNGMCJIHME).gameObject).name + " " + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("Error_Planks" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"ClosePopUp");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Unique id ");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"onlineProfileID is null. Initializate on prefab with length ");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, 31) <= 40 + DOGIEBBMDIC())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool EGMCENPJCAA()
	{
		float num = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.GAGEINOKNAK.Length)) : 1048f);
		float num2 = num / NPCRoadManager.GetCapacity();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(560f, 799f, num2) : 1286f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"UIInteract");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Drink");
			}
			return true;
		}
		if (Random.Range(436f, 117f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -32)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Error_RoomZone");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/TavernFilthy/Entry/9/Dialogue Text");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.RentedRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Initial DevConsole message: ");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.LDMNFGMCNOJ())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"AmberAleAbbreviation");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"OnlinePlayer");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveTavernStatsInfo");
			}
			return false;
		}
		return false;
	}

	private bool NIBHCMDMCCO()
	{
		float num = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.OGDDCMFDCAH().Length)) : 1754f);
		float num2 = num / NPCRoadManager.KAMEOKGOMEG();
		float num3 = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? Mathf.Lerp(1034f, 249f, num2) : 1380f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"day ");
			}
			return true;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" UpdateState().");
			}
			return false;
		}
		if (Random.Range(1599f, 351f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -93)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/Gass_Introduce/Entry/13/Dialogue Text");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Read");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.DiningRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Selected room reset to default.");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.JLAMIIDFILF())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"OnlyABird");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Graphics Device Name: ");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Normal");
			}
			return false;
		}
		return true;
	}

	public override int GetStateEnumID()
	{
		return 1;
	}

	private void NAFLOGFJDGB(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)KFICKCHHNKA())
		{
			Debug.Log((object)("Tutorial/T108/Dialogue1" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "TutorialPhase" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("Scene" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Disappear");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"PlayerLeftBed");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)" OnCharacterAppearanceChanged");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, -70) <= -27 + EBEBNPFDIDI())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool INNDGLAHOGC()
	{
		float num = ((TavernSeatingManager.DKFBAGJBPGP().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.GAGEINOKNAK.Length)) : 888f);
		float num2 = num / NPCRoadManager.BOJNKHGCIPE();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(719f, 161f, num2) : 996f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_639");
			}
			return true;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Open");
			}
			return true;
		}
		if (Random.Range(211f, 1707f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -57)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"pirates cave");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/TooHot/Entry/2/Dialogue Text");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"chaty");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.IANAPDACKLA())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/TavernClean/Entry/2/Dialogue Text");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"popUpBuilding26");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Balance/MainEvent2");
			}
			return false;
		}
		return true;
	}

	private void NNFCDPHDFFM(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)PJCJDHLNOHN())
		{
			Debug.Log((object)("ReceiveFishScoreUpdate" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Dialogue System/Conversation/Gass_Quest/Entry/1/Dialogue Text" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("NormalLeftExterior" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)". Time since startup: ");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Others");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"UIPreviousCategory");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, 85) <= -100 + CFDBDDMDFNA())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool AOELFAALGLD()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.OGDDCMFDCAH().Length)) : 1771f);
		float num2 = num / NPCRoadManager.DAKLPDPANKN();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(1262f, 448f, num2) : 55f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" ");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"MineState");
			}
			return true;
		}
		if (Random.Range(1834f, 1910f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 1)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Missing fade image for coop mode");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Player Waiting To Start Event");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.RentedRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"HandUp");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.IANAPDACKLA())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_682");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"FindSeat Corroutine");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Hit");
			}
			return false;
		}
		return false;
	}

	private int PJCHNAPBCGJ()
	{
		if (!WorldTime.isNight)
		{
			return -123;
		}
		return 0;
	}

	private void EKCIMJNMKMC(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)EDEOOIFHKDO())
		{
			Debug.Log((object)("ReceiveDroppedItemMessage" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "BecomeNuisance" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("Error in AmbienceController.OnNightEnd: " + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Farming multiplier");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)")");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Recipes list empty ");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		BarMenuManager.GIFDOGOMAFL();
		if (Random.Range(1, 68) <= -32 + EMKDINPIOEN())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool HJOLLPBMGGJ()
	{
		float num = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.DKFBAGJBPGP().Length)) : 818f);
		float num2 = num / NPCRoadManager.OINJEPAPOCB();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(1090f, 1661f, num2) : 919f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Done Loading Online Scripts");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"TermasInterior/Kenta/Stand");
			}
			return false;
		}
		if (Random.Range(1686f, 162f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -44)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Loading tavern floor tiles");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"City/Kujaku/Bark/Bye");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != 0)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/7/Dialogue Text");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.LDMNFGMCNOJ())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Friend list retrieved");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"BuzzNPC: ChangeState called with invalid state: ");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"UINextCategory");
			}
			return false;
		}
		return false;
	}

	private void NPEKKKIIGHM(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)NAENMNNCHIO())
		{
			Debug.Log((object)("City/Bruce/Stand" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Open" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("ReceivePlayerUsingObject" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Tree");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"BarIdleNumber");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"BouncerDescription");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
		BarMenuManager.GIFDOGOMAFL();
		if (Random.Range(0, 73) <= 26 + OGADDGLPLKN())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool IHDEPCACBHO()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.LNHPEHJLPNF().Length)) : 427f);
		float num2 = num / NPCRoadManager.FIJKELGCGJK();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(1718f, 1959f, num2) : 1010f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Toy");
			}
			return true;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ChatLogRequest");
			}
			return false;
		}
		if (Random.Range(1767f, 1376f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 107)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_1038");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"City/Carpenters/Ash/Stand");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Miners/Camp/Ferro/Talk");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.GetMaxCustomersDisponible())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"onlineProfileID is null. Initializate on prefab with length ");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_5");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"{0} state changed to: {1}");
			}
			return false;
		}
		return false;
	}

	private int GHDANHOLNEO()
	{
		if (!WorldTime.isNight)
		{
			return 13;
		}
		return 0;
	}

	private int PBMHIMGGMEJ()
	{
		if (!WorldTime.isNight)
		{
			return 23;
		}
		return 0;
	}

	private int CFDBDDMDFNA()
	{
		if (!WorldTime.isNight)
		{
			return -61;
		}
		return 1;
	}

	private bool IEKDGNGMDOL()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.OGDDCMFDCAH().Length)) : 1665f);
		float num2 = num / NPCRoadManager.CDEHEEAMLIA();
		float num3 = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? Mathf.Lerp(472f, 1649f, num2) : 782f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Player2");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Sprite Info without ID: ");
			}
			return true;
		}
		if (Random.Range(1769f, 1324f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 47)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Tutorial/T112/Dialogue1");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Could not find reputation with id: ");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ConnectionTimeout");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveEventActor");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"City/Carpenters/Ash/Stand");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"itemEmptyKeg");
			}
			return true;
		}
		return false;
	}

	private int IPLPMEODIOE()
	{
		if (!WorldTime.isNight)
		{
			return -6;
		}
		return 0;
	}

	private bool DLJMGANBKBB()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 902f);
		float num2 = num / NPCRoadManager.IJOJFICLAAF();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(195f, 1001f, num2) : 447f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"UIAddRemove");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"AnimalsNeedMoreSpace");
			}
			return true;
		}
		if (Random.Range(1565f, 590f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 30)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Requirements not met");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" ");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ZoneProductionBonus");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Occupied Positions");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Start");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" - <b><color=#8C78BA>");
			}
			return false;
		}
		return false;
	}

	private int JPHECMAFCEA()
	{
		if (!WorldTime.isNight)
		{
			return 10;
		}
		return 1;
	}

	private int OGADDGLPLKN()
	{
		if (!WorldTime.isNight)
		{
			return 49;
		}
		return 0;
	}

	private int PDAEMEDIOJJ()
	{
		if (!WorldTime.isNight)
		{
			return 93;
		}
		return 0;
	}

	private int LGEPGMGKJDI()
	{
		if (!WorldTime.isNight)
		{
			return 39;
		}
		return 0;
	}

	private int DOGIEBBMDIC()
	{
		if (!WorldTime.isNight)
		{
			return -20;
		}
		return 0;
	}

	private bool AJKEOCFOBEM()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.GAGEINOKNAK.Length)) : 70f);
		float num2 = num / NPCRoadManager.IJOJFICLAAF();
		float num3 = ((TavernSeatingManager.DKFBAGJBPGP().Length != 0) ? Mathf.Lerp(1016f, 1402f, num2) : 1554f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Error_OccupiedRoom");
			}
			return true;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"></size>");
			}
			return false;
		}
		if (Random.Range(602f, 1130f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -95)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_606");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"repUnlockFarmCarp");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Animator is null or has been destroyed.");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.JLAMIIDFILF())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" (Online Master Clone)");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"_");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"On Simple Event ");
			}
			return true;
		}
		return true;
	}

	private bool FDHPDPHIODE()
	{
		float num = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.GAGEINOKNAK.Length)) : 1387f);
		float num2 = num / NPCRoadManager.MBJINBKDIHC();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(813f, 147f, num2) : 1917f);
		if (PJNGMCJIHME.customerType == CustomerType.Traveller)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Cat");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Invalid item");
			}
			return false;
		}
		if (Random.Range(128f, 1255f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 87)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Item");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Ingredient");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.WithoutZone)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" : ");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" : 00");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_1032");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"/");
			}
			return false;
		}
		return false;
	}

	private int LGEEEMJGEIP()
	{
		if (!WorldTime.isNight)
		{
			return -4;
		}
		return 1;
	}

	private void KCFAABPELAF(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)PJCJDHLNOHN())
		{
			Debug.Log((object)("]" + ((Object)((Component)PJNGMCJIHME).gameObject).name + " (" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("ReceiveFarmConstructionActivated" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"</color>");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"???");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		BarMenuManager.GIFDOGOMAFL();
		if (Random.Range(0, -105) <= 12 + LGEEEMJGEIP())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private int HBICIGBAKNM()
	{
		if (!WorldTime.isNight)
		{
			return 112;
		}
		return 0;
	}

	private void AAOODAJPNPM(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)HMJEJFAHEKJ())
		{
			Debug.Log((object)("Use" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "itemPaleAle" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("itemWheatFlour" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"challenges");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)", ");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"SetTriggerRPC");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		BarMenuManager.GetAvailableItemInstances();
		if (Random.Range(0, 114) <= -94 + FNNAHIHFCLA())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private int EBEBNPFDIDI()
	{
		if (!WorldTime.isNight)
		{
			return 55;
		}
		return 1;
	}

	private bool AILEOFEICEF()
	{
		float num = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 392f);
		float num2 = num / NPCRoadManager.BOJNKHGCIPE();
		float num3 = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? Mathf.Lerp(389f, 1850f, num2) : 1152f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"/");
			}
			return false;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Year");
			}
			return true;
		}
		if (Random.Range(1746f, 1976f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= -128)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)", ");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"seeds");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.CraftingRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)">");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.HHBGBOAFNNP())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"quest_name_18");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"repUnlockMagic");
			}
			return false;
		}
		return true;
	}

	private bool KBBPKINEEIG()
	{
		float num = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 224f);
		float num2 = num / NPCRoadManager.IJOJFICLAAF();
		float num3 = ((TavernSeatingManager.OGDDCMFDCAH().Length != 0) ? Mathf.Lerp(111f, 1564f, num2) : 979f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"tutorialPopUp76");
			}
			return true;
		}
		if (Time.time < CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" : 00");
			}
			return false;
		}
		if (Random.Range(1878f, 250f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 21)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Exit build mode");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"<color=#C65314>");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_1446");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.IANAPDACKLA())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_3");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Remove");
			}
			return true;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Can't find seat. Reason: Tavern Closed");
			}
			return false;
		}
		return true;
	}

	private int IOGBOLJHDHD()
	{
		if (!WorldTime.isNight)
		{
			return -6;
		}
		return 0;
	}

	private void KJKPMHGBCDJ(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)IAEKIGLIHCO())
		{
			Debug.Log((object)("increase xp" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Items/item_name_1048" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("Perks/playerPerk_description_" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Left Alt");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_description_663");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"SprintHoldAction");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, 66) <= 27 + PBMHIMGGMEJ())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private void CJJPBEGFOHG(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)MKFCKADLFPM())
		{
			Debug.Log((object)("Cat bed is null!" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "OnlinePlayer" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("LE_10" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"ReceiveUpdateContentsRoom");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"LE_10");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		BarMenuManager.GIFDOGOMAFL();
		if (Random.Range(0, 71) <= 40 + PBMHIMGGMEJ())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private bool BDEDKMCDLOC()
	{
		float num = ((TavernSeatingManager.GAGEINOKNAK.Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.DKFBAGJBPGP().Length)) : 1927f);
		float num2 = num / NPCRoadManager.FIJKELGCGJK();
		float num3 = ((TavernSeatingManager.ACPEOIOHAHF().Length != 0) ? Mathf.Lerp(1254f, 138f, num2) : 691f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"talentRoasting");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Player2");
			}
			return false;
		}
		if (Random.Range(1525f, 750f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 61)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"application/gzip");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Disabled");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"itemBlueberry");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.GetMaxCustomersDisponible())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"CutEnd");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Current map: ");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Bouncer");
			}
			return false;
		}
		return false;
	}

	private int CLDDBAJPBOM()
	{
		if (!WorldTime.isNight)
		{
			return -100;
		}
		return 1;
	}

	private void NLGHDMIEHAM(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)HMJEJFAHEKJ())
		{
			Debug.Log((object)("There was an issue when loading Travel Zones for the second floor. This is likely caused in online mode. Needs further investigating." + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Serve" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)("add item " + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)" not found in OnlineEventsManager.");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Do you want to change input?");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"save");
		}
		PJNGMCJIHME.seatAssigned = false;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, 71) <= 7 + CFDBDDMDFNA())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private int FMKHEKLEAJG()
	{
		if (!WorldTime.isNight)
		{
			return 89;
		}
		return 0;
	}

	private bool AOJKDNFMBBJ()
	{
		float num = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.ACPEOIOHAHF().Length)) : 813f);
		float num2 = num / NPCRoadManager.KAMEOKGOMEG();
		float num3 = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? Mathf.Lerp(1151f, 659f, num2) : 1887f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveOfferingUIOpened");
			}
			return true;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Items/item_name_1071");
			}
			return true;
		}
		if (Random.Range(626f, 80f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 14)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)" for reason: ");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Sleep");
			}
			return false;
		}
		if (Bar.instance.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.CraftingRoom))
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Stand");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.LDMNFGMCNOJ())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Dialogue System/Conversation/Gass_Introduce/Entry/3/Dialogue Text");
			}
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"SetNPCPosition");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Animal");
			}
			return true;
		}
		return false;
	}

	private bool JEDODMEHJKJ()
	{
		float num = ((TavernSeatingManager.LNHPEHJLPNF().Length != 0) ? ((float)(TavernManager.GGFJGHHHEJC.customers.Count / TavernSeatingManager.OGDDCMFDCAH().Length)) : 318f);
		float num2 = num / NPCRoadManager.FIJKELGCGJK();
		float num3 = ((TavernSeatingManager.DKFBAGJBPGP().Length != 0) ? Mathf.Lerp(506f, 159f, num2) : 643f);
		if (PJNGMCJIHME.customerType == CustomerType.ImportantGuest)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
			}
			return false;
		}
		if (Time.time < CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Tutorial/T300/Talk");
			}
			return false;
		}
		if (Random.Range(823f, 692f) > num3 && !NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.GetCurrentPhase() != (Object)null && NewTutorialManager.GetCurrentPhase().GetID() >= 102)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ChristmasPresent");
			}
			return false;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"ReceiveSitDown");
			}
			return true;
		}
		if (Bar.instance.placeable.currentZoneType != ZoneType.CraftingRoom)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)", ");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.customers.Count >= TavernReputation.JLAMIIDFILF())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"A very important guest is visiting!");
			}
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"vampirehouse");
			}
			return false;
		}
		if (NPCRoadManager.customersWaitingSeat.Any())
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"Player2");
			}
			return false;
		}
		return false;
	}

	private void OOMFAEDMEJD(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)EAHCHMKILCL())
		{
			Debug.Log((object)("Items/item_description_1063" + ((Object)((Component)PJNGMCJIHME).gameObject).name + "Player2" + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Debug.Log((object)("BARKDOOR" + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Error_Planks");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"unlock recipe ");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"LE_8");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = false;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		BarMenuManager.GetAvailableItemInstances();
		if (Random.Range(0, 25) <= -87 + HBICIGBAKNM())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}

	private int MHLMEAIMHPH()
	{
		if (!WorldTime.isNight)
		{
			return 127;
		}
		return 1;
	}

	private void EJABNIOIHEI(HumanNPC JHIFLALPEBF, Seat FGJPAFDBIIO, bool ALOMLDIEHJL)
	{
		if (PJNGMCJIHME.customerState != (CustomerState)PJCJDHLNOHN())
		{
			Debug.Log((object)("MeltState" + ((Object)((Component)PJNGMCJIHME).gameObject).name + " " + PJNGMCJIHME.customerState));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Debug.Log((object)(": " + ((Object)((Component)PJNGMCJIHME).gameObject).name));
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"");
		}
		if (!ALOMLDIEHJL || FGJPAFDBIIO.reserved)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"[Red");
			}
			PJNGMCJIHME.OnSeatNotFound();
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
			return;
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Invalid year: ");
		}
		PJNGMCJIHME.seatAssigned = true;
		JHIFLALPEBF.seat = FGJPAFDBIIO;
		FGJPAFDBIIO.reserved = true;
		TavernManager.GGFJGHHHEJC.CustomerEnterTavern(PJNGMCJIHME);
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		BarMenuManager.AMKCBEBBFMO();
		if (Random.Range(0, -20) <= 104 + LGEEEMJGEIP())
		{
			PJNGMCJIHME.preference = CustomerPreference.Food;
		}
		else
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		if (NewTutorialManager.ForceDrinkOrders())
		{
			PJNGMCJIHME.preference = CustomerPreference.Drink;
		}
		PJNGMCJIHME.OnSeatFound();
	}
}
