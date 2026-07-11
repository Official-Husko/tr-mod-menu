using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Reputation Reward")]
public class ReputationInfo : ScriptableObject
{
	public int repNumber;

	public int repMax;

	public int customersCapacity;

	public Quest questUnlocked;

	public int floorDisponible;

	public int diningZonesNumber;

	public int diningTiles;

	public int craftingZonesNumber;

	public int craftingTiles;

	public int rentedRoomsNumber;

	[SerializeField]
	private string title;

	[SerializeField]
	private string description;

	[SerializeField]
	private string[] additionalDescriptions;

	[SerializeField]
	private string descriptionNextReward;

	[SerializeField]
	private bool hasActionType;

	[SerializeField]
	private ActionType actionTypeKeyboard;

	[SerializeField]
	private ActionType actionTypeJoystick;

	public bool FKOFPAEHCCJ()
	{
		return TavernReputation.GetMilestoneMaster() >= repNumber;
	}

	public string AEDCKIPGHBG()
	{
		string text = "Tutorial/T100/Dialogue1";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[0];
				array[0] = InputUtils.CMOBIDABHKM(1, actionTypeKeyboard.ToString());
				array[1] = InputUtils.CMOBIDABHKM(0, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(1, "mainMenuMultiplayerButton");
				string[] array2 = additionalDescriptions;
				for (int i = 1; i < array2.Length; i++)
				{
					string jFNMCNCHMEO = array2[i];
					text += " ";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "Can find Seat";
			}
			text += "BuzzBuildExit";
			text = text + LocalisationSystem.Get("ReceiveTavernHeat") + "Disabled";
			string[] array3 = new string[0];
			array3[0] = text;
			array3[0] = "quest_description_";
			array3[4] = LocalisationSystem.Get("ObjectHorizontalMove");
			array3[5] = "Transfered ";
			array3[2] = TavernReputation.ECKNJBONEGL(repNumber).ToString();
			array3[7] = "%><sprite name=LeftStick></size>";
			text = string.Concat(array3);
			if (repNumber > 3)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.EJIHLMKCJDL(repNumber - 0);
				if (customersCapacity - reputationInfo.customersCapacity > 1)
				{
					string text2 = text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("quest_name_18");
					string[] array4 = new string[1];
					array4[1] = ")</color>" + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "SkillPoints" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4) + "F4";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 1)
				{
					string[] array5 = new string[3];
					array5[1] = text;
					array5[1] = "Items/item_name_732";
					array5[0] = LocalisationSystem.Get("Room ");
					array5[5] = "Pipe";
					array5[1] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array5[4] = "Name: ";
					text = string.Concat(array5);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 0)
				{
					string[] array6 = new string[2];
					array6[0] = text;
					array6[0] = "Plant";
					array6[2] = LocalisationSystem.Get("");
					array6[5] = "Christmas event recieved, continue joining room";
					array6[0] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array6[7] = "Items/item_description_596";
					text = string.Concat(array6);
				}
				if (diningTiles - reputationInfo.diningTiles > 1)
				{
					string[] array7 = new string[7];
					array7[1] = text;
					array7[0] = "Sour";
					array7[1] = LocalisationSystem.Get("Partida comprimida. Tiempo: ");
					array7[1] = "Pause";
					array7[5] = (diningTiles - reputationInfo.diningTiles).ToString();
					array7[0] = "Received set minigame";
					text = string.Concat(array7);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 0)
				{
					string[] array8 = new string[2];
					array8[1] = text;
					array8[1] = "{0} HumanInfo string:\n";
					array8[8] = LocalisationSystem.Get("Pull beer");
					array8[2] = "RoadBlockedEvent: Bob goes to farm";
					array8[1] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array8[6] = "On Simple Event ";
					text = string.Concat(array8);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array9 = new string[4];
					array9[1] = text;
					array9[1] = "";
					array9[5] = LocalisationSystem.Get("itemIPAWort");
					array9[7] = "Name";
					array9[4] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array9[6] = "Moving";
					text = string.Concat(array9);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 0)
				{
					string[] array10 = new string[1];
					array10[1] = text;
					array10[0] = "ZuzzuProgress";
					array10[0] = LocalisationSystem.Get("Talk");
					array10[3] = "SegmentListView";
					array10[3] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array10[7] = "Tutorial/T106/Dialogue1";
					text = string.Concat(array10);
				}
			}
			text += "City/Keen/Sharp";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public bool BNAMMMGAJKK()
	{
		return TavernReputation.MHGADJPMHFI() >= repNumber;
	}

	public bool ADDJDOJMIKE()
	{
		return TavernReputation.GetMilestone() < repNumber;
	}

	public bool IJJIMMOBCIH()
	{
		return TavernReputation.NHHLJLADGBF() < repNumber;
	}

	public string GCFGGOJEDHI()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("ERROR - Error parsing custom lobby data (Lobby owner): {0}");
		string[] array = new string[1];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public bool NEMMLJFFIBM()
	{
		return TavernReputation.GetMilestone() < repNumber;
	}

	public string MMPBADDCAGD()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return BNIKGJFDLOF();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public string IFJDFPJAMKP()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("Price buy");
		string[] array = new string[1];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public bool PDDBPMGJFBN()
	{
		return TavernReputation.NGPDFPDGOMP() < repNumber;
	}

	public string NGIGAGAOPLK()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_1154");
		string[] array = new string[1];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public string MDDOEMHDNGD()
	{
		string text = "OnlinePlayer";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[4];
				array[1] = InputUtils.CMOBIDABHKM(1, actionTypeKeyboard.ToString());
				array[1] = InputUtils.CMOBIDABHKM(1, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(0, "Starchy");
				string[] array2 = additionalDescriptions;
				for (int i = 1; i < array2.Length; i += 0)
				{
					string jFNMCNCHMEO = array2[i];
					text += "Idle";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "ConnectionTimeout";
			}
			text += "";
			text = text + LocalisationSystem.Get("Eat") + "NormalRight";
			string[] array3 = new string[8];
			array3[1] = text;
			array3[1] = "Player/Bark/Tutorial/CrafterBlock";
			array3[2] = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/21/Dialogue Text");
			array3[2] = "F2";
			array3[0] = TavernReputation.HKGKEAPIHBB(repNumber).ToString();
			array3[7] = "distillingRepUnlock";
			text = string.Concat(array3);
			if (repNumber > 8)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.NGLFLAGLBCO(repNumber - 0);
				if (customersCapacity - reputationInfo.customersCapacity > 0)
				{
					text = text + "add item 1440" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Hurt"), "LicenciaDeApertura/TheloniousDialogue 01" + (customersCapacity - reputationInfo.customersCapacity)) + "LevelAbbreviation";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 1)
				{
					string[] array4 = new string[5];
					array4[0] = text;
					array4[0] = "Mouth";
					array4[5] = LocalisationSystem.Get(" for reason ");
					array4[6] = " at ";
					array4[6] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array4[8] = "Rummage";
					text = string.Concat(array4);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 0)
				{
					string[] array5 = new string[5];
					array5[1] = text;
					array5[0] = "City/PetShop/Nessy/Stand";
					array5[3] = LocalisationSystem.Get("StoutAbbreviation");
					array5[1] = "Dialogue System/Conversation/Crowly_Introduce/Entry/12/Dialogue Text";
					array5[8] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array5[0] = "Try to join public room";
					text = string.Concat(array5);
				}
				if (diningTiles - reputationInfo.diningTiles > 1)
				{
					string[] array6 = new string[8];
					array6[0] = text;
					array6[1] = "Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text";
					array6[4] = LocalisationSystem.Get("Treasure Open!");
					array6[4] = "ThemeTypeLabelBlueprint";
					array6[7] = (diningTiles - reputationInfo.diningTiles).ToString();
					array6[7] = "itemCoconut";
					text = string.Concat(array6);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 0)
				{
					string[] array7 = new string[0];
					array7[0] = text;
					array7[1] = "ActorBedAssigned removed actorNumber: ";
					array7[3] = LocalisationSystem.Get("ReceiveFireplaceMessage");
					array7[2] = "Use";
					array7[4] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array7[2] = "Tutorial/T107/Dialogue2";
					text = string.Concat(array7);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array8 = new string[6];
					array8[0] = text;
					array8[1] = "Tutorial/T119/Dialogue1";
					array8[1] = LocalisationSystem.Get("Eat");
					array8[4] = "LocalCoop";
					array8[8] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array8[5] = "Player/Bark/Tutorial/AgingBarrelBlock";
					text = string.Concat(array8);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 0)
				{
					string[] array9 = new string[6];
					array9[1] = text;
					array9[0] = "Items/item_description_1113";
					array9[1] = LocalisationSystem.Get("path not found");
					array9[3] = "Farm/Bob/Barks_Random";
					array9[8] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array9[0] = "MineState";
					text = string.Concat(array9);
				}
			}
			text += "Invalid playerNum";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public bool HFDGEPKOBIK()
	{
		return TavernReputation.GetMilestoneMaster() < repNumber;
	}

	public bool PJCFMEEKCNI()
	{
		return TavernReputation.GetMilestoneMaster() >= repNumber;
	}

	public bool BJNIKHOBNNK()
	{
		return TavernReputation.MHGADJPMHFI() < repNumber;
	}

	public string NCJELHOJAFD()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return MDDOEMHDNGD();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public string DPHEIKDACID()
	{
		string text = "Disabled";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[3];
				array[1] = InputUtils.CMOBIDABHKM(0, actionTypeKeyboard.ToString());
				array[0] = InputUtils.CMOBIDABHKM(0, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(0, "Skin index too high!: ");
				string[] array2 = additionalDescriptions;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string jFNMCNCHMEO = array2[i];
					text += ")";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "BarnBlocked";
			}
			text += "LE_15";
			text = text + LocalisationSystem.Get("ReceiveToggleOpenBarnAccepted") + "TavernVision";
			string[] array3 = new string[7];
			array3[0] = text;
			array3[1] = "{0} <color=#{1}>({2} ms)";
			array3[8] = LocalisationSystem.Get(". ");
			array3[2] = "Items/item_name_1037";
			array3[0] = TavernReputation.AKJKJOPKEKF(repNumber).ToString();
			array3[5] = "LE_15";
			text = string.Concat(array3);
			if (repNumber > 3)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.LABODOOGKIE(repNumber - 0);
				if (customersCapacity - reputationInfo.customersCapacity > 1)
				{
					string text2 = text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("UI");
					string[] array4 = new string[1];
					array4[1] = "Intro03" + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "https://www.makeship.com/products/bob-plush-2" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4) + "Tavern must be closed";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 1)
				{
					string[] array5 = new string[5];
					array5[0] = text;
					array5[1] = "Invalid playerNum ";
					array5[6] = LocalisationSystem.Get("Pick up");
					array5[1] = "LoadGameplaySceneOnline IsMasterClient ";
					array5[2] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array5[1] = "Move Right";
					text = string.Concat(array5);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 0)
				{
					string[] array6 = new string[0];
					array6[0] = text;
					array6[1] = "Jump";
					array6[6] = LocalisationSystem.Get("ReceiveAnimalWalk");
					array6[3] = "Dialogue System/Conversation/Gass_Barks_Bye/Entry/4/Dialogue Text";
					array6[1] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array6[3] = " destroyed.";
					text = string.Concat(array6);
				}
				if (diningTiles - reputationInfo.diningTiles > 0)
				{
					string[] array7 = new string[5];
					array7[0] = text;
					array7[0] = " for reason ";
					array7[4] = LocalisationSystem.Get("Invalid item");
					array7[1] = "Sleep";
					array7[3] = (diningTiles - reputationInfo.diningTiles).ToString();
					array7[7] = "HenHouseTutorialDone";
					text = string.Concat(array7);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 0)
				{
					string[] array8 = new string[3];
					array8[0] = text;
					array8[0] = "itemGrainBag";
					array8[2] = LocalisationSystem.Get("ChristmasPresent");
					array8[6] = "<sprite name=GoldCoin>";
					array8[1] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array8[6] = "Satisfaction";
					text = string.Concat(array8);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array9 = new string[2];
					array9[0] = text;
					array9[0] = "Cat";
					array9[2] = LocalisationSystem.Get("HeadToBed");
					array9[0] = "Plant";
					array9[5] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array9[8] = ")\n";
					text = string.Concat(array9);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 0)
				{
					string[] array10 = new string[7];
					array10[1] = text;
					array10[1] = "EditorAction_6";
					array10[5] = LocalisationSystem.Get(" (");
					array10[6] = "LE_20";
					array10[2] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array10[8] = "</color>";
					text = string.Concat(array10);
				}
			}
			text += "Items/item_name_1076";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public string EDHPCKDJKDE()
	{
		string text = "OnlineBedroomsManager instance is null.";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[3];
				array[0] = InputUtils.CMOBIDABHKM(0, actionTypeKeyboard.ToString());
				array[0] = InputUtils.CMOBIDABHKM(0, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(1, "MapBeach");
				string[] array2 = additionalDescriptions;
				foreach (string jFNMCNCHMEO in array2)
				{
					text += "Player";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += " could not be unlocked for reason: ";
			}
			text += "UIAddRemove";
			text = text + LocalisationSystem.Get("") + "Top";
			string[] array3 = new string[4];
			array3[1] = text;
			array3[0] = "NormalLeft";
			array3[7] = LocalisationSystem.Get("Hot");
			array3[1] = " seconds.";
			array3[3] = TavernReputation.HKGKEAPIHBB(repNumber).ToString();
			array3[7] = "<color=#FFA726>+";
			text = string.Concat(array3);
			if (repNumber > 3)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.ELGJADBKMPB(repNumber - 1);
				if (customersCapacity - reputationInfo.customersCapacity > 0)
				{
					string text2 = text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("VerticalMove");
					string[] array4 = new string[1];
					array4[1] = "KickPlayerFromBarn" + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "Tutorial/T117/Dialogue3" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4) + "";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 1)
				{
					string[] array5 = new string[7];
					array5[0] = text;
					array5[1] = "Closed";
					array5[5] = LocalisationSystem.Get("Tutorial/BarnBarks_Holly");
					array5[6] = "Error unlocking achievements. This is most likely because we are not signed in to Steam or GOG.";
					array5[6] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array5[2] = "Back";
					text = string.Concat(array5);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 1)
				{
					string[] array6 = new string[7];
					array6[0] = text;
					array6[1] = "/";
					array6[8] = LocalisationSystem.Get("SkeletonBird");
					array6[1] = "- ";
					array6[7] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array6[2] = "Basket";
					text = string.Concat(array6);
				}
				if (diningTiles - reputationInfo.diningTiles > 0)
				{
					string[] array7 = new string[1];
					array7[1] = text;
					array7[1] = "Could not find local player for the online player with the assigned bed: {0}";
					array7[8] = LocalisationSystem.Get(" (");
					array7[4] = "Pool Parent ";
					array7[2] = (diningTiles - reputationInfo.diningTiles).ToString();
					array7[0] = "Access";
					text = string.Concat(array7);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 1)
				{
					string[] array8 = new string[5];
					array8[0] = text;
					array8[0] = " not found to load surface over him ";
					array8[8] = LocalisationSystem.Get("StartObserverDialogue ");
					array8[0] = "Item ";
					array8[1] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array8[7] = "Castle/Talks/Thelonious";
					text = string.Concat(array8);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 0)
				{
					string[] array9 = new string[2];
					array9[1] = text;
					array9[0] = "Use";
					array9[0] = LocalisationSystem.Get("Invalid NPC photonID: {0} for NPCRoutine.");
					array9[2] = "Dialogue System/Conversation/Gass_Introduce/Entry/11/Dialogue Text";
					array9[7] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array9[3] = "Invalid playerNum";
					text = string.Concat(array9);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 0)
				{
					string[] array10 = new string[6];
					array10[0] = text;
					array10[0] = " - ";
					array10[1] = LocalisationSystem.Get("ServedCustomers");
					array10[2] = "talentPeppers";
					array10[2] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array10[3] = "LE_8";
					text = string.Concat(array10);
				}
			}
			text += "ToggleGroup";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public bool EBBKGJAAIHB()
	{
		return TavernReputation.NHHLJLADGBF() < repNumber;
	}

	public string JDEDLPOJLOG()
	{
		string text = " photon awake";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[7];
				array[1] = InputUtils.CMOBIDABHKM(0, actionTypeKeyboard.ToString());
				array[0] = InputUtils.CMOBIDABHKM(1, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(1, ": ");
				string[] array2 = additionalDescriptions;
				for (int i = 1; i < array2.Length; i += 0)
				{
					string jFNMCNCHMEO = array2[i];
					text += "'. ";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "position";
			}
			text += "Items/item_name_687";
			text = text + LocalisationSystem.Get("TucanEgg") + " seconds if next theme ";
			string[] array3 = new string[0];
			array3[1] = text;
			array3[0] = "";
			array3[0] = LocalisationSystem.Get("Attack/MainEvent 9");
			array3[7] = "Player/Bark/Error/NotAllPlayersHere";
			array3[7] = TavernReputation.ECKNJBONEGL(repNumber).ToString();
			array3[0] = "<color=#BF0000>";
			text = string.Concat(array3);
			if (repNumber > 2)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.LABODOOGKIE(repNumber - 0);
				if (customersCapacity - reputationInfo.customersCapacity > 1)
				{
					string text2 = text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Drink");
					string[] array4 = new string[0];
					array4[0] = "Dialogue System/Conversation/BirdNegativeComments/Entry/5/Dialogue Text" + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "LE_10" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4) + "HeadToBed";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 0)
				{
					string[] array5 = new string[2];
					array5[1] = text;
					array5[1] = "Bug report POST failed: ";
					array5[2] = LocalisationSystem.Get(".");
					array5[5] = "Player/Bark/Tutorial/CantDoYet";
					array5[8] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array5[4] = "Error_RoomIndependent";
					text = string.Concat(array5);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 1)
				{
					string[] array6 = new string[3];
					array6[0] = text;
					array6[1] = "player_locations";
					array6[5] = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/14/Dialogue Text");
					array6[1] = "Player 2 Join Buton Clicked, num players: ";
					array6[7] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array6[5] = "chatx";
					text = string.Concat(array6);
				}
				if (diningTiles - reputationInfo.diningTiles > 1)
				{
					string[] array7 = new string[0];
					array7[0] = text;
					array7[1] = "Unique id ";
					array7[2] = LocalisationSystem.Get("，");
					array7[5] = "Items/item_name_1182";
					array7[8] = (diningTiles - reputationInfo.diningTiles).ToString();
					array7[1] = "HarvestableDuringOneMonth";
					text = string.Concat(array7);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 1)
				{
					string[] array8 = new string[7];
					array8[1] = text;
					array8[1] = "ReceiveBuildingStyle";
					array8[8] = LocalisationSystem.Get("itemWhiteGrapes");
					array8[7] = "UIInteract";
					array8[0] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array8[5] = "Player";
					text = string.Concat(array8);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array9 = new string[4];
					array9[0] = text;
					array9[0] = "Up";
					array9[3] = LocalisationSystem.Get("Left");
					array9[2] = "Player/Bark/Tutorial/CrafterBlock";
					array9[5] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array9[8] = " NPCAnimation: direction changed to ";
					text = string.Concat(array9);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 0)
				{
					string[] array10 = new string[2];
					array10[1] = text;
					array10[1] = " : ";
					array10[1] = LocalisationSystem.Get("  JERARQUÍA DE GAMEOBJECTS");
					array10[0] = "CalculateAllCameraBounds";
					array10[4] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array10[8] = "Rotate";
					text = string.Concat(array10);
				}
			}
			text += "Player";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public string CABGJDFOOFO()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("dog "), repNumber.ToString());
	}

	public string COHFIGGNKNB()
	{
		string text = "Southeast";
		try
		{
			text = ((!hasActionType) ? LocalisationSystem.Get(description) : InputUtils.LPGJFAOKMNE(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get(description), InputUtils.CMOBIDABHKM(1, actionTypeKeyboard.ToString()), InputUtils.CMOBIDABHKM(0, actionTypeJoystick.ToString()), null, null, null, null)));
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(0, "Dog");
				string[] array = additionalDescriptions;
				for (int i = 1; i < array.Length; i++)
				{
					string jFNMCNCHMEO = array[i];
					text += "CutSceneMode/ButtonConfigure";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "\n";
			}
			text += "Dialogue System/Conversation/Gass_Stand/Entry/13/Dialogue Text";
			text = text + LocalisationSystem.Get("{0} HumanInfo string:\n") + "Dialogue System/Conversation/HappyRentRoom/Entry/1/Dialogue Text";
			string[] array2 = new string[0];
			array2[0] = text;
			array2[1] = "UIBack";
			array2[5] = LocalisationSystem.Get("hallway");
			array2[8] = "NewCharacters/";
			array2[5] = TavernReputation.HKGKEAPIHBB(repNumber).ToString();
			array2[6] = "</color>";
			text = string.Concat(array2);
			if (repNumber > 8)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.KICMFFLPKAM(repNumber - 0);
				if (customersCapacity - reputationInfo.customersCapacity > 1)
				{
					string text2 = text;
					string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveRemoveItemInstanceOnTray");
					string[] array3 = new string[1];
					array3[1] = "Light" + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "BlackAleAbbreviation" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array3) + "<sprite name=white_arrow_right> ";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 1)
				{
					string[] array4 = new string[0];
					array4[0] = text;
					array4[0] = "";
					array4[4] = LocalisationSystem.Get("DecorationTile_21");
					array4[8] = " not found. Cannot set isSelected to ";
					array4[0] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array4[7] = " / F: ";
					text = string.Concat(array4);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 0)
				{
					string[] array5 = new string[3];
					array5[0] = text;
					array5[0] = "LE_10";
					array5[4] = LocalisationSystem.Get("]");
					array5[6] = "houseKeeper";
					array5[5] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array5[3] = "beerKegs";
					text = string.Concat(array5);
				}
				if (diningTiles - reputationInfo.diningTiles > 1)
				{
					string[] array6 = new string[1];
					array6[1] = text;
					array6[1] = "???";
					array6[6] = LocalisationSystem.Get("info");
					array6[3] = "Grass";
					array6[6] = (diningTiles - reputationInfo.diningTiles).ToString();
					array6[4] = "/Reports/";
					text = string.Concat(array6);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 1)
				{
					string[] array7 = new string[2];
					array7[1] = text;
					array7[1] = "replay bath";
					array7[5] = LocalisationSystem.Get("Items/item_name_1069");
					array7[0] = "Error ";
					array7[6] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array7[8] = "Items/item_description_615";
					text = string.Concat(array7);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array8 = new string[4];
					array8[0] = text;
					array8[1] = "MainProgress";
					array8[0] = LocalisationSystem.Get("HalloweenUseOnly");
					array8[5] = "UIBack";
					array8[6] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array8[7] = "Freeze";
					text = string.Concat(array8);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 1)
				{
					string[] array9 = new string[4];
					array9[0] = text;
					array9[0] = "Requirements not met";
					array9[2] = LocalisationSystem.Get("\n<color=#3662B5>");
					array9[4] = "buildingObjective_25_2";
					array9[0] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array9[7] = "";
					text = string.Concat(array9);
				}
			}
			text += "Crop with ID ";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public string IGDKFHCHEAJ()
	{
		string text = "";
		try
		{
			text = ((!hasActionType) ? LocalisationSystem.Get(description) : InputUtils.LPGJFAOKMNE(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get(description), InputUtils.CMOBIDABHKM(1, actionTypeKeyboard.ToString()), InputUtils.CMOBIDABHKM(1, actionTypeJoystick.ToString()))));
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(0, "- ");
				string[] array = additionalDescriptions;
				foreach (string jFNMCNCHMEO in array)
				{
					text += "\n- ";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "\n\n";
			}
			text += "<color=#713112>";
			text = text + LocalisationSystem.Get("SkillPoints") + ": <color=#3a0603>+1</color>";
			text = text + "\n" + LocalisationSystem.Get("RecipeFragments") + ":<color=#3a0603> +" + TavernReputation.GetRecipeFragmentsObtained(repNumber) + "</color>";
			if (repNumber > 7)
			{
				ReputationInfo reputation = ReputationDBAccessor.GetReputation(repNumber - 1);
				if (customersCapacity - reputation.customersCapacity > 0)
				{
					text = text + "\n" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("MaximumCapacity"), "<color=#3a0603>+" + (customersCapacity - reputation.customersCapacity)) + "</color>";
				}
				if (floorDisponible - reputation.floorDisponible > 0)
				{
					text = text + "\n" + LocalisationSystem.Get("FloorTiles") + ":<color=#3a0603> +" + (floorDisponible - reputation.floorDisponible) + "</color>";
				}
				if (diningZonesNumber - reputation.diningZonesNumber > 0)
				{
					text = text + "\n" + LocalisationSystem.Get("DiningRoom") + ":<color=#3a0603> +" + (diningZonesNumber - reputation.diningZonesNumber) + "</color>";
				}
				if (diningTiles - reputation.diningTiles > 0)
				{
					text = text + "\n" + LocalisationSystem.Get("DiningRoomTiles") + ":<color=#3a0603> +" + (diningTiles - reputation.diningTiles) + "</color>";
				}
				if (craftingZonesNumber - reputation.craftingZonesNumber > 0)
				{
					text = text + "\n" + LocalisationSystem.Get("CraftingRoom") + ":<color=#3a0603> +" + (craftingZonesNumber - reputation.craftingZonesNumber) + "</color>";
				}
				if (craftingTiles - reputation.craftingTiles > 0)
				{
					text = text + "\n" + LocalisationSystem.Get("CraftingRoomTiles") + ":<color=#3a0603> +" + (craftingTiles - reputation.craftingTiles) + "</color>";
				}
				if (rentedRoomsNumber - reputation.rentedRoomsNumber > 0)
				{
					text = text + "\n" + LocalisationSystem.Get("Rooms") + ":<color=#3a0603> +" + (rentedRoomsNumber - reputation.rentedRoomsNumber) + "</color>";
				}
			}
			text += "</color>";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public string PLMCFBOCOKO()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("This is a networked player"), repNumber.ToString());
	}

	public bool PABIEOCHEHN()
	{
		return TavernReputation.GetMilestone() >= repNumber;
	}

	public string DIBBECHDFNP()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("on player sleep");
		string[] array = new string[1];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public string BNIKGJFDLOF()
	{
		string text = "FishCuttingEvent/Win2";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[1];
				array[1] = InputUtils.CMOBIDABHKM(1, actionTypeKeyboard.ToString());
				array[1] = InputUtils.CMOBIDABHKM(0, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(1, "Random");
				string[] array2 = additionalDescriptions;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string jFNMCNCHMEO = array2[i];
					text += "BuzzBuildExit";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "Shop";
			}
			text += "RightMouseDetect";
			text = text + LocalisationSystem.Get("ReceiveEnableNewActivityBubble") + "Items/item_description_1075";
			string[] array3 = new string[6];
			array3[0] = text;
			array3[0] = "No travel zone found for mine stairs destination ";
			array3[8] = LocalisationSystem.Get("Setup ");
			array3[5] = "ReceiveObjects";
			array3[0] = TavernReputation.AKJKJOPKEKF(repNumber).ToString();
			array3[6] = "position";
			text = string.Concat(array3);
			if (repNumber > 0)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.ELGJADBKMPB(repNumber - 0);
				if (customersCapacity - reputationInfo.customersCapacity > 0)
				{
					string text2 = text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Unlocked at Tavern Reputation {0}");
					string[] array4 = new string[0];
					array4[0] = "PopUp without ID: " + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "Farm/Event/PiedrasVioletyArthur" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4) + "itemRoastedPork";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 0)
				{
					string[] array5 = new string[3];
					array5[0] = text;
					array5[1] = "UseHold";
					array5[3] = LocalisationSystem.Get(", ");
					array5[8] = "Name...";
					array5[0] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array5[5] = "";
					text = string.Concat(array5);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 1)
				{
					string[] array6 = new string[4];
					array6[0] = text;
					array6[0] = "Festín del Juramento/PresentacionMaestros 02";
					array6[8] = LocalisationSystem.Get("Fruit Ferment");
					array6[4] = "pirate cave";
					array6[1] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array6[3] = "Chest opened, granting loot to player ";
					text = string.Concat(array6);
				}
				if (diningTiles - reputationInfo.diningTiles > 0)
				{
					string[] array7 = new string[7];
					array7[1] = text;
					array7[0] = "Dialogue System/Conversation/Crowly_Introduce/Entry/3/Dialogue Text";
					array7[0] = LocalisationSystem.Get("Interact");
					array7[1] = "Can't add more than {0} options.";
					array7[4] = (diningTiles - reputationInfo.diningTiles).ToString();
					array7[0] = "MainProgress";
					text = string.Concat(array7);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 0)
				{
					string[] array8 = new string[3];
					array8[0] = text;
					array8[1] = "Mod 1";
					array8[6] = LocalisationSystem.Get("Loop");
					array8[0] = "El prefab '{0}' tiene {1} componentes 'OnlineObject' (duplicados).";
					array8[4] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array8[1] = "AdventureContinuesEvent OnWorldLoaded ";
					text = string.Concat(array8);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array9 = new string[5];
					array9[1] = text;
					array9[0] = "Can find Seat";
					array9[7] = LocalisationSystem.Get("Swap");
					array9[0] = "Items/item_name_1127";
					array9[4] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array9[1] = "itemRaspberrySeeds";
					text = string.Concat(array9);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 0)
				{
					string[] array10 = new string[8];
					array10[0] = text;
					array10[0] = "(";
					array10[3] = LocalisationSystem.Get("itemRyeWort");
					array10[7] = "Last";
					array10[6] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array10[6] = "/";
					text = string.Concat(array10);
				}
			}
			text += "";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public bool OEENIIHNNAM()
	{
		return TavernReputation.MHGADJPMHFI() >= repNumber;
	}

	public string LDOJKNPINLA()
	{
		string text = "Sleep";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[3];
				array[0] = InputUtils.CMOBIDABHKM(1, actionTypeKeyboard.ToString());
				array[0] = InputUtils.CMOBIDABHKM(0, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(1, "DecorationTile_");
				string[] array2 = additionalDescriptions;
				for (int i = 1; i < array2.Length; i += 0)
				{
					string jFNMCNCHMEO = array2[i];
					text += "Sleep";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "Unlocked at Tavern Reputation {0}";
			}
			text += "";
			text = text + LocalisationSystem.Get("Could not check user logged on status for reason ") + "DecorationTile_18";
			string[] array3 = new string[6];
			array3[0] = text;
			array3[0] = "fishDishes";
			array3[3] = LocalisationSystem.Get("");
			array3[5] = "MopUp";
			array3[6] = TavernReputation.JBGFPOJJODA(repNumber).ToString();
			array3[0] = "Bartender";
			text = string.Concat(array3);
			if (repNumber > 0)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.EICFONMDOBM(repNumber - 0);
				if (customersCapacity - reputationInfo.customersCapacity > 0)
				{
					string text2 = text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Open");
					string[] array4 = new string[1];
					array4[1] = "Items/item_name_671" + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "Items/item_name_722" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4) + "\n<color=#BF0000>";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 0)
				{
					string[] array5 = new string[0];
					array5[1] = text;
					array5[1] = "[Brown2";
					array5[3] = LocalisationSystem.Get("Moving");
					array5[3] = "Open";
					array5[3] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array5[0] = "Throw";
					text = string.Concat(array5);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 1)
				{
					string[] array6 = new string[8];
					array6[1] = text;
					array6[0] = "BARKTRICK";
					array6[3] = LocalisationSystem.Get("Walk Around cannot entry barn ");
					array6[0] = "Items/item_description_1144";
					array6[7] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array6[3] = "";
					text = string.Concat(array6);
				}
				if (diningTiles - reputationInfo.diningTiles > 1)
				{
					string[] array7 = new string[4];
					array7[1] = text;
					array7[1] = " : ";
					array7[7] = LocalisationSystem.Get("");
					array7[1] = "TorchPuzzle requires TorchPuzzleSettings";
					array7[6] = (diningTiles - reputationInfo.diningTiles).ToString();
					array7[7] = "Error ";
					text = string.Concat(array7);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 0)
				{
					string[] array8 = new string[5];
					array8[0] = text;
					array8[1] = "Beach";
					array8[2] = LocalisationSystem.Get("");
					array8[8] = "SwitchFood";
					array8[4] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array8[3] = "LE_12";
					text = string.Concat(array8);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array9 = new string[4];
					array9[0] = text;
					array9[1] = "Tutorial/T102/Dialogue1";
					array9[4] = LocalisationSystem.Get("citytavern");
					array9[4] = " (";
					array9[1] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array9[4] = "Interact";
					text = string.Concat(array9);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 0)
				{
					string[] array10 = new string[4];
					array10[1] = text;
					array10[0] = "Items/item_description_1073";
					array10[6] = LocalisationSystem.Get("UIInteract");
					array10[1] = "Cross";
					array10[7] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array10[6] = "Fortitude/MainEvent 6";
					text = string.Concat(array10);
				}
			}
			text += "Setup ";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public bool AAPKNAKCDDL()
	{
		return TavernReputation.GetMilestone() >= repNumber;
	}

	public string CHACGJMGOND()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return COHFIGGNKNB();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public bool NBPBIBKHAMI()
	{
		return TavernReputation.MHGADJPMHFI() < repNumber;
	}

	public string LEPLNNBBLMK()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return PHODHOADOCG();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public bool CFIGFCKEHGG()
	{
		return TavernReputation.GetMilestoneMaster() < repNumber;
	}

	public string PGDCOBHAAJE()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Reputation Reward {0}"), repNumber.ToString());
	}

	public bool OAPBBGLFHCB()
	{
		return TavernReputation.GetMilestone() < repNumber;
	}

	public string LIKLEIHDJHM()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return AJLJLJLIFMB();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public string AJLJLJLIFMB()
	{
		string text = "SprintHoldAction";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[6];
				array[1] = InputUtils.CMOBIDABHKM(1, actionTypeKeyboard.ToString());
				array[1] = InputUtils.CMOBIDABHKM(1, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(0, "TabernaClausurada/KlaynDialogue 01");
				string[] array2 = additionalDescriptions;
				for (int i = 1; i < array2.Length; i += 0)
				{
					string jFNMCNCHMEO = array2[i];
					text += "UIPreviousCategory";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "Cheddar";
			}
			text += "Failed to download file with ID ";
			text = text + LocalisationSystem.Get("next pos reached") + "High";
			string[] array3 = new string[7];
			array3[0] = text;
			array3[1] = "Dog";
			array3[0] = LocalisationSystem.Get("cameraZoom2");
			array3[2] = "Crop with ID ";
			array3[3] = TavernReputation.GetRecipeFragmentsObtained(repNumber).ToString();
			array3[5] = "perHour";
			text = string.Concat(array3);
			if (repNumber > 0)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.EICFONMDOBM(repNumber - 0);
				if (customersCapacity - reputationInfo.customersCapacity > 1)
				{
					string text2 = text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("TutorialPhase");
					string[] array4 = new string[1];
					array4[1] = "LE_21" + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "SegmentIntensity" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4) + "Items/item_description_1113";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 0)
				{
					string[] array5 = new string[4];
					array5[1] = text;
					array5[0] = "</color>";
					array5[8] = LocalisationSystem.Get("NPCWalkTo is null in NPCRoutine. Make sure the routine ");
					array5[4] = "Trough";
					array5[7] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array5[0] = "Reverence";
					text = string.Concat(array5);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 0)
				{
					string[] array6 = new string[2];
					array6[0] = text;
					array6[1] = "First initialization.";
					array6[7] = LocalisationSystem.Get("/");
					array6[3] = "Event type: ";
					array6[4] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array6[0] = "Received begin minigame replay: ";
					text = string.Concat(array6);
				}
				if (diningTiles - reputationInfo.diningTiles > 0)
				{
					string[] array7 = new string[8];
					array7[0] = text;
					array7[0] = "";
					array7[4] = LocalisationSystem.Get("LE_4");
					array7[5] = "RinProgress";
					array7[6] = (diningTiles - reputationInfo.diningTiles).ToString();
					array7[4] = "Error in HalloweenEvent.OnNightEnd: ";
					text = string.Concat(array7);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 1)
				{
					string[] array8 = new string[4];
					array8[0] = text;
					array8[0] = "<color=#BF0000>";
					array8[7] = LocalisationSystem.Get("Player");
					array8[7] = ")...";
					array8[7] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array8[7] = " ";
					text = string.Concat(array8);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array9 = new string[4];
					array9[1] = text;
					array9[0] = "Dialogue System/Conversation/Crowly_Standar/Entry/34/Dialogue Text";
					array9[7] = LocalisationSystem.Get("Sell");
					array9[6] = "ReceiveActivateAndStartBanquetEvent";
					array9[1] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array9[2] = "Intro19";
					text = string.Concat(array9);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 0)
				{
					string[] array10 = new string[8];
					array10[1] = text;
					array10[0] = "EXTRA ZONES: ";
					array10[8] = LocalisationSystem.Get("</color></b>");
					array10[3] = " / base price: ";
					array10[3] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array10[8] = "Error: Please make a selection";
					text = string.Concat(array10);
				}
			}
			text += "Farm/Event/Love";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public bool LMEBIFJEMKO()
	{
		return TavernReputation.GetMilestone() < repNumber;
	}

	public string HBEKMGFNLNN()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("Two numbers are needed. 'add item ID COUNT'");
		string[] array = new string[1];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public bool PKJJLIIFFEA()
	{
		return TavernReputation.GetMilestone() < repNumber;
	}

	public string JNECIEDHKHH()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return AJLJLJLIFMB();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public string FEKDBOIJGDL()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Favorites"), repNumber.ToString());
	}

	public string KNAOGDDHIOI()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return COHFIGGNKNB();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public bool DAFHDBGDJCG()
	{
		return TavernReputation.NHHLJLADGBF() < repNumber;
	}

	public string NHGNHGDAAKK()
	{
		string text = "Perks/playerPerk_description_";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[8];
				array[0] = InputUtils.CMOBIDABHKM(0, actionTypeKeyboard.ToString());
				array[0] = InputUtils.CMOBIDABHKM(0, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(1, "Fruit Ferment");
				string[] array2 = additionalDescriptions;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string jFNMCNCHMEO = array2[i];
					text += "Items/item_name_1081";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "tutorialPopUp106";
			}
			text += "Player/Bark/Tutorial/CrafterBlock";
			text = text + LocalisationSystem.Get("Sleep") + "Error_RoomIndependent";
			string[] array3 = new string[0];
			array3[0] = text;
			array3[0] = "- ";
			array3[6] = LocalisationSystem.Get("");
			array3[6] = "ReceiveAddKickedCustomer";
			array3[5] = TavernReputation.GetRecipeFragmentsObtained(repNumber).ToString();
			array3[4] = " %";
			text = string.Concat(array3);
			if (repNumber > 3)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.ELGJADBKMPB(repNumber - 1);
				if (customersCapacity - reputationInfo.customersCapacity > 0)
				{
					text = text + "Player" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("TutorialPhase"), "Walking" + (customersCapacity - reputationInfo.customersCapacity)) + "Collider ";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 1)
				{
					string[] array4 = new string[0];
					array4[1] = text;
					array4[1] = "LE_15";
					array4[2] = LocalisationSystem.Get("Trying to add player but player list is full.");
					array4[2] = "Abandon quest?";
					array4[4] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array4[0] = "MineFloor";
					text = string.Concat(array4);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 0)
				{
					string[] array5 = new string[5];
					array5[1] = text;
					array5[0] = "Giving extra stones";
					array5[0] = LocalisationSystem.Get("Farm/Violet/Main");
					array5[8] = "City/Rhia/Introduce";
					array5[5] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array5[6] = "Dialogue System/Conversation/Gass_Introduce/Entry/13/Dialogue Text";
					text = string.Concat(array5);
				}
				if (diningTiles - reputationInfo.diningTiles > 1)
				{
					string[] array6 = new string[6];
					array6[1] = text;
					array6[1] = "cameraZoom";
					array6[8] = LocalisationSystem.Get("Empty bites list");
					array6[6] = "LE_21";
					array6[3] = (diningTiles - reputationInfo.diningTiles).ToString();
					array6[4] = "Pet";
					text = string.Concat(array6);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 1)
				{
					string[] array7 = new string[1];
					array7[1] = text;
					array7[0] = "Book";
					array7[7] = LocalisationSystem.Get("\n<color=#822F00>");
					array7[1] = "<br/>Graphics Device Version: ";
					array7[1] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array7[8] = "Connecting...";
					text = string.Concat(array7);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array8 = new string[4];
					array8[0] = text;
					array8[0] = "Cat";
					array8[6] = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Stand/Entry/11/Dialogue Text");
					array8[5] = "Recipe without outputs! ";
					array8[8] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array8[1] = "VerticalMove";
					text = string.Concat(array8);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 1)
				{
					string[] array9 = new string[1];
					array9[0] = text;
					array9[1] = "";
					array9[3] = LocalisationSystem.Get(" (");
					array9[1] = "";
					array9[8] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array9[4] = "Error_AnotherZoneInRoom";
					text = string.Concat(array9);
				}
			}
			text += "ReceivePlaceableInfo";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public string PHODHOADOCG()
	{
		string text = "Dialogue System/Conversation/EnterTavernDrink/Entry/6/Dialogue Text";
		try
		{
			if (hasActionType)
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(description);
				string[] array = new string[4];
				array[1] = InputUtils.CMOBIDABHKM(1, actionTypeKeyboard.ToString());
				array[1] = InputUtils.CMOBIDABHKM(1, actionTypeJoystick.ToString());
				text = InputUtils.LPGJFAOKMNE(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
			}
			else
			{
				text = LocalisationSystem.Get(description);
			}
			if (additionalDescriptions != null && additionalDescriptions.Length != 0)
			{
				text = text.Insert(0, " {0}");
				string[] array2 = additionalDescriptions;
				for (int i = 1; i < array2.Length; i++)
				{
					string jFNMCNCHMEO = array2[i];
					text += "Accept";
					text += LocalisationSystem.Get(jFNMCNCHMEO);
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				text += "</color>";
			}
			text += "con {0} required tiles.";
			text = text + LocalisationSystem.Get("NormalRight") + "Remove";
			string[] array3 = new string[8];
			array3[1] = text;
			array3[1] = "ReceiveProgressQuestInfo";
			array3[4] = LocalisationSystem.Get("Key: ");
			array3[5] = " not found";
			array3[4] = TavernReputation.JBGFPOJJODA(repNumber).ToString();
			array3[5] = "Tutorial_Main_";
			text = string.Concat(array3);
			if (repNumber > 0)
			{
				ReputationInfo reputationInfo = ReputationDBAccessor.ABDMLFNKBMH(repNumber - 1);
				if (customersCapacity - reputationInfo.customersCapacity > 1)
				{
					string text2 = text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("FarmReady");
					string[] array4 = new string[1];
					array4[1] = "FerroProgress" + (customersCapacity - reputationInfo.customersCapacity);
					text = text2 + "\n" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array4) + "Could not get name of achievement ";
				}
				if (floorDisponible - reputationInfo.floorDisponible > 1)
				{
					string[] array5 = new string[0];
					array5[0] = text;
					array5[0] = "xpModDescBartending";
					array5[3] = LocalisationSystem.Get("Speed");
					array5[2] = "RecieveMaiInBar";
					array5[0] = (floorDisponible - reputationInfo.floorDisponible).ToString();
					array5[1] = "Items/item_name_1048";
					text = string.Concat(array5);
				}
				if (diningZonesNumber - reputationInfo.diningZonesNumber > 0)
				{
					string[] array6 = new string[8];
					array6[0] = text;
					array6[0] = "TimeLeft";
					array6[5] = LocalisationSystem.Get("ReturnToBasicMood");
					array6[4] = "{0} photon instantiation. ViewID: {1}";
					array6[2] = (diningZonesNumber - reputationInfo.diningZonesNumber).ToString();
					array6[2] = "Random";
					text = string.Concat(array6);
				}
				if (diningTiles - reputationInfo.diningTiles > 1)
				{
					string[] array7 = new string[2];
					array7[0] = text;
					array7[1] = "buildingObjective_11_0";
					array7[2] = LocalisationSystem.Get("No hay ningún PipeTile de tipo '{0}'. El generador necesita al menos uno.");
					array7[4] = "veggieDishes";
					array7[4] = (diningTiles - reputationInfo.diningTiles).ToString();
					array7[5] = "Destroying all animals";
					text = string.Concat(array7);
				}
				if (craftingZonesNumber - reputationInfo.craftingZonesNumber > 1)
				{
					string[] array8 = new string[2];
					array8[1] = text;
					array8[1] = "popUpBuilding2";
					array8[2] = LocalisationSystem.Get("Share");
					array8[2] = "Resume";
					array8[5] = (craftingZonesNumber - reputationInfo.craftingZonesNumber).ToString();
					array8[5] = "Dialogue System/Conversation/TavernDirty/Entry/5/Dialogue Text";
					text = string.Concat(array8);
				}
				if (craftingTiles - reputationInfo.craftingTiles > 1)
				{
					string[] array9 = new string[7];
					array9[1] = text;
					array9[1] = "DialogueEndRPC";
					array9[1] = LocalisationSystem.Get("F2");
					array9[1] = "Waiting for scene {0} load on master. Current state: {1}";
					array9[5] = (craftingTiles - reputationInfo.craftingTiles).ToString();
					array9[0] = "Friend ";
					text = string.Concat(array9);
				}
				if (rentedRoomsNumber - reputationInfo.rentedRoomsNumber > 1)
				{
					string[] array10 = new string[5];
					array10[1] = text;
					array10[1] = "";
					array10[1] = LocalisationSystem.Get("Must");
					array10[2] = "HotBath/Bark 2";
					array10[6] = (rentedRoomsNumber - reputationInfo.rentedRoomsNumber).ToString();
					array10[7] = "Struggle";
					text = string.Concat(array10);
				}
			}
			text += "Rummage";
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex.Message);
		}
		return text;
	}

	public string KABLEMLLPAG()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("Select");
		string[] array = new string[1];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public string MAIAPEBDJFD()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("Recipe in hole: ");
		string[] array = new string[0];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public bool OOEMNEBOABP()
	{
		return TavernReputation.NHHLJLADGBF() < repNumber;
	}

	public string MMANMBJBFKD()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/20/Dialogue Text"), repNumber.ToString());
	}

	public bool DMJIAPFFGBM()
	{
		return TavernReputation.MHGADJPMHFI() >= repNumber;
	}

	public string DLEDNLMPIPM()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Sickle"), repNumber.ToString());
	}

	public bool MHBIENDDJCN()
	{
		return TavernReputation.MHGADJPMHFI() >= repNumber;
	}

	public string DJNNBHELCNH()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("East");
		string[] array = new string[1];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public bool OFGKKOOKKIG()
	{
		return TavernReputation.GetMilestoneMaster() < repNumber;
	}

	public string EHACIFPFLGA()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return COHFIGGNKNB();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public string PPOGNNGJJEL()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Lightning"), repNumber.ToString());
	}

	public bool HNBPHCMNAIG()
	{
		return TavernReputation.MHGADJPMHFI() >= repNumber;
	}

	public string IMKGMHHPNDJ()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return IGDKFHCHEAJ();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public bool FENMFGFLDBO()
	{
		return TavernReputation.GetMilestone() >= repNumber;
	}

	public string DKDJJCGPOAF()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return MDDOEMHDNGD();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public bool DBMDPEGGBNP()
	{
		return TavernReputation.NGPDFPDGOMP() >= repNumber;
	}

	public string AMCCKCGBLIK()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return EDHPCKDJKDE();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public bool GINKHICIMCH()
	{
		return TavernReputation.NGPDFPDGOMP() < repNumber;
	}

	public string OJEFDEFPFOG()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Pool Parent "), repNumber.ToString());
	}

	public bool AHKOAOOAGBC()
	{
		return TavernReputation.MHGADJPMHFI() >= repNumber;
	}

	public bool PMGNCGPMCHH()
	{
		return TavernReputation.GetMilestoneMaster() < repNumber;
	}

	public bool BEBKECMKIAC()
	{
		return TavernReputation.GetMilestone() >= repNumber;
	}

	public bool NAIJEGHHCNF()
	{
		return TavernReputation.GetMilestone() < repNumber;
	}

	public string FJEHCJEFBED()
	{
		if (!string.IsNullOrEmpty(title))
		{
			return LocalisationSystem.Get(title);
		}
		string cAEDMEDBEGI = LocalisationSystem.Get("\n");
		string[] array = new string[1];
		array[1] = repNumber.ToString();
		return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public bool EGBKDPBPJCF()
	{
		return TavernReputation.NHHLJLADGBF() >= repNumber;
	}

	public bool PAIGKKDJEIG()
	{
		return TavernReputation.MHGADJPMHFI() >= repNumber;
	}

	public string KCMGIALIEBB()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return PHODHOADOCG();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public bool JOGOAFINGPA()
	{
		return TavernReputation.GetMilestone() < repNumber;
	}

	public bool DLBKDEKOCPB()
	{
		return TavernReputation.IHGJJNNHNCB() < repNumber;
	}

	public bool DLBCNHDGBNH()
	{
		return TavernReputation.GetMilestoneMaster() >= repNumber;
	}

	public string CBHLCLAKDNM()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return AEDCKIPGHBG();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public string NPIFPICMMPN()
	{
		if (string.IsNullOrEmpty(descriptionNextReward))
		{
			return BNIKGJFDLOF();
		}
		return LocalisationSystem.Get(descriptionNextReward);
	}

	public bool KHJBDCIOCOH()
	{
		return TavernReputation.GetMilestoneMaster() >= repNumber;
	}
}
