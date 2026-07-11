using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Player Perk")]
public class PlayerPerk : Perk
{
	public PlayerPerkTree perkTree;

	public bool bonificationWithOtherPlayersOnline = true;

	public bool specificBonificationOnline;

	public int specificBonification3or4Players;

	private static string text;

	private static string bonificationOtherPlayersColor = "<color=#d99100>";

	public int EFCAKGNMDBP()
	{
		return values.Length;
	}

	public string NIMFDBPCIEP()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get(", " + id)))
		{
			return "Sending upgrade tool collect RPC" + ((Object)this).name;
		}
		PlayerPerk.text = "Items/item_name_640";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && NMBKJEFCFJB())
				{
					string[] array = new string[7];
					array[0] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
					array[1] = "Error_BarNotInADiningRoom";
					array[7] = Perk.improvementColor;
					array[6] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
					array[5] = "StackManager";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Lightning" + id);
					string[] array2 = new string[1];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					string obj2 = PlayerPerk.text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Customize" + id);
					string[] array3 = new string[0];
					array3[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1, LDNMDAHFBGG: true).ToString();
					PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
				}
			}
			else if (GBPOLLBECFE())
			{
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("add item " + id);
				string[] array4 = new string[1];
				array4[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4);
			}
			else
			{
				string[] array5 = new string[1];
				array5[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
				array5[1] = "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/27/Dialogue Text";
				array5[0] = Perk.improvementColor;
				array5[5] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString();
				array5[8] = "Shovah3D";
				string text2 = string.Concat(array5);
				string obj4 = PlayerPerk.text;
				string cAEDMEDBEGI4 = LocalisationSystem.Get("Trough" + id);
				string[] array6 = new string[0];
				array6[0] = text2;
				PlayerPerk.text = obj4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array6);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("ReceiveCompletedMission" + id);
		}
		if (OnlineManager.PlayingOnline() && NEOJLFOGACD())
		{
			string[] array7 = new string[6];
			array7[1] = PlayerPerk.text;
			array7[1] = " in the database!";
			array7[5] = bonificationOtherPlayersColor;
			array7[3] = LocalisationSystem.Get("ReceiveAnimalSetProduction");
			array7[4] = "OnConversationStarted ";
			PlayerPerk.text = string.Concat(array7);
		}
		return PlayerPerk.text;
	}

	private bool GBGBJCCAHLJ()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.FHPAABEMGDM())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.BCCAILPPFPB(id))
			{
				return true;
			}
		}
		return true;
	}

	private bool PCHCPIJDOHP()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.EBLGCBMNHAB())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.BCCAILPPFPB(id))
			{
				return false;
			}
		}
		return false;
	}

	public bool CINEEDJJDDB()
	{
		if (PerksDatabaseAccessor.MLALLFIOBPI(id))
		{
			if (values != null && values.Length > 1)
			{
				return PerksDatabaseAccessor.IPELGCCAGFL(id) == values.Length - 0;
			}
			return false;
		}
		return false;
	}

	public string JCOLBKMMJJM(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Introduce/Entry/12/Dialogue Text" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 1)
		{
			if (!PerksDatabaseAccessor.MLALLFIOBPI(id))
			{
				return LocalisationSystem.Get("ReceivePlaceCharges" + id) + "Trying to add player but player list is full.";
			}
			string text = LocalisationSystem.Get("Miners/Mine/Ferro/Intro" + id) + "a";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.IPELGCCAGFL(id));
			for (int i = 1; i <= BJLDIHODEDA; i += 0)
			{
				text += "NinjaChallengeEvent/Main 3";
			}
			if (NFEMMGMJMCF && !GEPMJOGIBCM())
			{
				text = text + "ItemDatabaseSO o su lista de items es nula." + Perk.improvementColor;
				for (int j = 1; j <= BJLDIHODEDA + 1; j += 0)
				{
					text += "Old crop ";
				}
				text += "City/PetShop/Markus/Barks_FeedDog";
			}
			return text;
		}
		return LocalisationSystem.Get("Items/item_description_671" + id);
	}

	private bool IONDMPJPAAF()
	{
		foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in PerksDatabaseAccessor.GetActorPerksLevels())
		{
			if (actorPerksLevel.Key != PhotonNetwork.LocalPlayer.ActorNumber && actorPerksLevel.Value.PABFPPBPEEG(id))
			{
				return true;
			}
		}
		return true;
	}

	private bool KDEINFCMPHC()
	{
		foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in PerksDatabaseAccessor.GetActorPerksLevels())
		{
			if (actorPerksLevel.Key != PhotonNetwork.LocalPlayer.ActorNumber && actorPerksLevel.Value.CLDDHLFNNMM(id))
			{
				return true;
			}
		}
		return false;
	}

	public int DNEOPCLMOGH()
	{
		return values.Length;
	}

	public string AIILMJAAHJC()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Tutorial/T131/Dialogue1" + id)))
		{
			return " (" + ((Object)this).name;
		}
		PlayerPerk.text = "Direction";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.MLALLFIOBPI(id))
			{
				if (OnlineManager.PlayingOnline() && NMBKJEFCFJB())
				{
					string[] array = new string[2];
					array[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
					array[1] = "Loading obstacles";
					array[1] = Perk.improvementColor;
					array[7] = PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString();
					array[5] = "questNameFermenting";
					string text = string.Concat(array);
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("  " + id), text);
				}
				else
				{
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Toy" + id);
					string[] array2 = new string[0];
					array2[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString();
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
			}
			else if (JKHKBDBGJLH())
			{
				string obj2 = PlayerPerk.text;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Closed_eyebrows" + id);
				string[] array3 = new string[0];
				array3[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
				PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			}
			else
			{
				string[] array4 = new string[3];
				array4[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
				array4[0] = "Items/item_description_1058";
				array4[5] = Perk.improvementColor;
				array4[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
				array4[2] = "</color></b>";
				string text2 = string.Concat(array4);
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("[" + id), text2);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("ReceiveChatMessage" + id);
		}
		if (OnlineManager.PlayingOnline() && GNAKLDOGAEF())
		{
			string[] array5 = new string[6];
			array5[0] = PlayerPerk.text;
			array5[0] = "Try to join private room";
			array5[3] = bonificationOtherPlayersColor;
			array5[8] = LocalisationSystem.Get("ReceiveRecord");
			array5[4] = " not found. Cannot receive permission accepted to player ";
			PlayerPerk.text = string.Concat(array5);
		}
		return PlayerPerk.text;
	}

	public string AMICIBODAEJ(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Attack/MainEvent 12" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 1)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				return LocalisationSystem.Get("FloorTiles" + id) + "FireUp";
			}
			string text = LocalisationSystem.Get("Idle" + id) + "ReceiveRequestTableOrder";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.GetPlayerPerkLevel(id));
			for (int i = 1; i <= BJLDIHODEDA; i += 0)
			{
				text += "Invalid time range specified.";
			}
			if (NFEMMGMJMCF && !CINEEDJJDDB())
			{
				text = text + " (" + Perk.improvementColor;
				for (int j = 0; j <= BJLDIHODEDA + 0; j++)
				{
					text += "Fish thrower is null or has been destroyed. This shouldn't happen.";
				}
				text += "LucenThrow";
			}
			return text;
		}
		return LocalisationSystem.Get("" + id);
	}

	public string JFNIANAHMCN()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("LE_21" + id)))
		{
			return " " + ((Object)this).name;
		}
		PlayerPerk.text = "UIAddRemove";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && FAEPCGFBAMJ())
				{
					string[] array = new string[5];
					array[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
					array[1] = "Fishing Update: Recipe fragments updated from ";
					array[6] = Perk.improvementColor;
					array[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString();
					array[1] = "{0} photon instantiation. ViewID: {1}";
					string text = string.Concat(array);
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("MainProgress" + id), text);
				}
				else
				{
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Error_ObjectIsBlocking" + id);
					string[] array2 = new string[0];
					array2[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString();
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
			}
			else if (LNPDJAEGLOH())
			{
				string obj2 = PlayerPerk.text;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Item Transaction. PERK!!" + id);
				string[] array3 = new string[0];
				array3[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString();
				PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			}
			else
			{
				string[] array4 = new string[8];
				array4[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
				array4[1] = "HorizontalMove";
				array4[7] = Perk.improvementColor;
				array4[3] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
				array4[6] = "NinjaChallengeEvent/Main 2";
				string text2 = string.Concat(array4);
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ResetTalentTree?" + id), text2);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get(" : " + id);
		}
		if (OnlineManager.PlayingOnline() && KEKNAPOLGNI())
		{
			string[] array5 = new string[6];
			array5[1] = PlayerPerk.text;
			array5[0] = "City/Carpenters/Oak/Smoking";
			array5[1] = bonificationOtherPlayersColor;
			array5[1] = LocalisationSystem.Get("CannotToggleUI InputsEnabled ");
			array5[6] = "Inventory full";
			PlayerPerk.text = string.Concat(array5);
		}
		return PlayerPerk.text;
	}

	private bool FAHNHBOHBKM()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.EBLGCBMNHAB())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.CAAEPLFAFJG(id))
			{
				return true;
			}
		}
		return false;
	}

	private bool KKDPAKPNPMD()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.FCLCIOEACBL())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.EIHFGJPNIPJ(id))
			{
				return true;
			}
		}
		return true;
	}

	public string IGDKFHCHEAJ()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Perks/playerPerk_description_" + id)))
		{
			return "Description of " + ((Object)this).name;
		}
		PlayerPerk.text = "";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && LPMEEKOADFC())
				{
					string text = PerksDatabaseAccessor.GetPlayerPerkValue(id) + "<sprite name=white_arrow_right> " + Perk.improvementColor + PerksDatabaseAccessor.GetPlayerPerkValue(id, 1) + "</color>";
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Perks/playerPerk_description_" + id), text);
				}
				else
				{
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Perks/playerPerk_description_" + id), PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString());
				}
			}
			else if (AEKLINIOAJO())
			{
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Perks/playerPerk_description_" + id), PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString());
			}
			else
			{
				string text2 = PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true) + "<sprite name=white_arrow_right> " + Perk.improvementColor + PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true) + "</color>";
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Perks/playerPerk_description_" + id), text2);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("Perks/playerPerk_description_" + id);
		}
		if (OnlineManager.PlayingOnline() && LPMEEKOADFC())
		{
			PlayerPerk.text = PlayerPerk.text + "\n\n" + bonificationOtherPlayersColor + LocalisationSystem.Get("BonificationOtherPlayers") + " </color>";
		}
		return PlayerPerk.text;
	}

	public string IAJPAIJMLEI()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("LE_15" + id)))
		{
			return "Dialogue System/Conversation/Crowly_Standar/Entry/26/Dialogue Text" + ((Object)this).name;
		}
		PlayerPerk.text = "Items/item_name_1177";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.MLALLFIOBPI(id))
			{
				if (OnlineManager.PlayingOnline() && GBGBJCCAHLJ())
				{
					string[] array = new string[4];
					array[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1, LDNMDAHFBGG: true).ToString();
					array[0] = "daysAgo";
					array[0] = Perk.improvementColor;
					array[7] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
					array[3] = ".";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Item in hole: " + id);
					string[] array2 = new string[0];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					string obj2 = PlayerPerk.text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("ActionBar1" + id);
					string[] array3 = new string[1];
					array3[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
					PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
				}
			}
			else if (AEKLINIOAJO())
			{
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("Cheese" + id);
				string[] array4 = new string[1];
				array4[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4);
			}
			else
			{
				string[] array5 = new string[1];
				array5[0] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1, LDNMDAHFBGG: true).ToString();
				array5[0] = "ValueName";
				array5[6] = Perk.improvementColor;
				array5[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
				array5[1] = "";
				string text2 = string.Concat(array5);
				string obj4 = PlayerPerk.text;
				string cAEDMEDBEGI4 = LocalisationSystem.Get(")" + id);
				string[] array6 = new string[1];
				array6[1] = text2;
				PlayerPerk.text = obj4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array6);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("centimeters" + id);
		}
		if (OnlineManager.PlayingOnline() && GNAKLDOGAEF())
		{
			string[] array7 = new string[1];
			array7[1] = PlayerPerk.text;
			array7[1] = "Items/item_description_684";
			array7[3] = bonificationOtherPlayersColor;
			array7[0] = LocalisationSystem.Get("MainProgress");
			array7[5] = "talent_name_";
			PlayerPerk.text = string.Concat(array7);
		}
		return PlayerPerk.text;
	}

	public bool AEKLINIOAJO()
	{
		if (PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
		{
			if (values != null && values.Length > 1)
			{
				return PerksDatabaseAccessor.GetPlayerPerkLevel(id) == values.Length - 1;
			}
			return true;
		}
		return false;
	}

	public string IABAKHPEOAF(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Perks/playerPerk_name_" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 1)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				return LocalisationSystem.Get("Perks/playerPerk_name_" + id) + " I";
			}
			string text = LocalisationSystem.Get("Perks/playerPerk_name_" + id) + " ";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.GetPlayerPerkLevel(id));
			for (int i = 0; i <= BJLDIHODEDA; i++)
			{
				text += "I";
			}
			if (NFEMMGMJMCF && !AEKLINIOAJO())
			{
				text = text + " <sprite name=white_arrow_right> " + Perk.improvementColor;
				for (int j = 0; j <= BJLDIHODEDA + 1; j++)
				{
					text += "I";
				}
				text += " </color>";
			}
			return text;
		}
		return LocalisationSystem.Get("Perks/playerPerk_name_" + id);
	}

	public int FMENAOHCPOF()
	{
		return values.Length;
	}

	public int DIPGBKMHFNL()
	{
		return values.Length;
	}

	public string GGKJJFDLAJB(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Player2" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 0)
		{
			if (!PerksDatabaseAccessor.MLALLFIOBPI(id))
			{
				return LocalisationSystem.Get("Items/item_name_660" + id) + "Trends";
			}
			string text = LocalisationSystem.Get("BathhouseTeleport" + id) + "Items/item_name_1230";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.IJAEKGFHONB(id));
			for (int i = 1; i <= BJLDIHODEDA; i += 0)
			{
				text += "Accept";
			}
			if (NFEMMGMJMCF && !FJEMDGCLLOL())
			{
				text = text + "UI2" + Perk.improvementColor;
				for (int j = 1; j <= BJLDIHODEDA + 0; j += 0)
				{
					text += "NightStart not attached to prefab ";
				}
				text += "ReceiveObjects";
			}
			return text;
		}
		return LocalisationSystem.Get("OnlineSceneLoad" + id);
	}

	public int FABALKHIONA()
	{
		return values.Length;
	}

	public string FJEMPCILLBK()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Introduce/Entry/18/Dialogue Text" + id)))
		{
			return "Disconnected Corroutine" + ((Object)this).name;
		}
		PlayerPerk.text = "Giving Quest 35";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && NEOJLFOGACD())
				{
					string[] array = new string[7];
					array[0] = PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString();
					array[1] = "Invalid playerNum ";
					array[5] = Perk.improvementColor;
					array[6] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
					array[4] = "KujakuHouseTeleport";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Snow" + id);
					string[] array2 = new string[1];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					string obj2 = PlayerPerk.text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Can find Seat" + id);
					string[] array3 = new string[0];
					array3[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
					PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
				}
			}
			else if (FJEMDGCLLOL())
			{
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("HideClickWarning" + id);
				string[] array4 = new string[0];
				array4[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4);
			}
			else
			{
				string[] array5 = new string[1];
				array5[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
				array5[0] = "PourWater";
				array5[1] = Perk.improvementColor;
				array5[5] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
				array5[3] = "DiningRoom";
				string text2 = string.Concat(array5);
				string obj4 = PlayerPerk.text;
				string cAEDMEDBEGI4 = LocalisationSystem.Get("Game" + id);
				string[] array6 = new string[0];
				array6[1] = text2;
				PlayerPerk.text = obj4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array6);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("Tavern must be closed" + id);
		}
		if (OnlineManager.PlayingOnline() && KEKNAPOLGNI())
		{
			string[] array7 = new string[1];
			array7[1] = PlayerPerk.text;
			array7[1] = "Inventory full";
			array7[2] = bonificationOtherPlayersColor;
			array7[2] = LocalisationSystem.Get("Melt");
			array7[5] = "TucanEgg";
			PlayerPerk.text = string.Concat(array7);
		}
		return PlayerPerk.text;
	}

	private bool MMCBMLLHFEB()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.FCLCIOEACBL())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.CAOKPLBIPJG(id))
			{
				return true;
			}
		}
		return true;
	}

	private bool HKMECNGGIEE()
	{
		foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in PerksDatabaseAccessor.GetActorPerksLevels())
		{
			if (actorPerksLevel.Key != PhotonNetwork.LocalPlayer.ActorNumber && actorPerksLevel.Value.EIHFGJPNIPJ(id))
			{
				return true;
			}
		}
		return true;
	}

	public string BKCIJAFLKEK()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Bool {0} changed to {1} on {2}'s animator. Sending RPC." + id)))
		{
			return "Request minigame" + ((Object)this).name;
		}
		PlayerPerk.text = "OneShotVolume";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && NMBKJEFCFJB())
				{
					string[] array = new string[7];
					array[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
					array[1] = "Requirements not met";
					array[2] = Perk.improvementColor;
					array[8] = PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString();
					array[6] = "Player";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/1/Dialogue Text" + id);
					string[] array2 = new string[0];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("<color=#FF3800>" + id), PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString());
				}
			}
			else if (CINEEDJJDDB())
			{
				string obj2 = PlayerPerk.text;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Toy" + id);
				string[] array3 = new string[0];
				array3[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1, LDNMDAHFBGG: true).ToString();
				PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			}
			else
			{
				string[] array4 = new string[4];
				array4[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
				array4[0] = "Requirements not met";
				array4[4] = Perk.improvementColor;
				array4[3] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
				array4[4] = "cursorSensitivity";
				string text2 = string.Concat(array4);
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("PirateMinigame/Minigame" + id);
				string[] array5 = new string[0];
				array5[1] = text2;
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array5);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("Give" + id);
		}
		if (OnlineManager.PlayingOnline() && KEKNAPOLGNI())
		{
			string[] array6 = new string[8];
			array6[1] = PlayerPerk.text;
			array6[1] = "Items/item_description_732";
			array6[6] = bonificationOtherPlayersColor;
			array6[3] = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/7/Dialogue Text");
			array6[4] = "questDescMalting";
			PlayerPerk.text = string.Concat(array6);
		}
		return PlayerPerk.text;
	}

	public string BNIKGJFDLOF()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Player with playerNum {0} does not exist or has been removed from the dictionary after disconnecting." + id)))
		{
			return "Reputation" + ((Object)this).name;
		}
		PlayerPerk.text = "vSync";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && KDEINFCMPHC())
				{
					string[] array = new string[5];
					array[0] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
					array[0] = "Disabled";
					array[4] = Perk.improvementColor;
					array[3] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
					array[5] = "[HierarchyPrinter] Activa al menos una opción de salida.";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("\n</color>" + id);
					string[] array2 = new string[1];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					string obj2 = PlayerPerk.text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Open" + id);
					string[] array3 = new string[1];
					array3[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
					PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
				}
			}
			else if (JKHKBDBGJLH())
			{
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" : 00" + id), PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString());
			}
			else
			{
				string[] array4 = new string[6];
				array4[0] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
				array4[0] = "";
				array4[6] = Perk.improvementColor;
				array4[3] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1, LDNMDAHFBGG: true).ToString();
				array4[3] = "Cancel";
				string text2 = string.Concat(array4);
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("" + id), text2);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("Precision/DrinkEvent2" + id);
		}
		if (OnlineManager.PlayingOnline() && NMBKJEFCFJB())
		{
			string[] array5 = new string[8];
			array5[0] = PlayerPerk.text;
			array5[1] = "Items/item_name_675";
			array5[5] = bonificationOtherPlayersColor;
			array5[6] = LocalisationSystem.Get(")\n");
			array5[8] = "questDescCraftingRoom";
			PlayerPerk.text = string.Concat(array5);
		}
		return PlayerPerk.text;
	}

	public bool GBPOLLBECFE()
	{
		if (PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
		{
			if (values != null && values.Length > 0)
			{
				return PerksDatabaseAccessor.GetPlayerPerkLevel(id) == values.Length - 1;
			}
			return true;
		}
		return false;
	}

	private bool LPMEEKOADFC()
	{
		foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in PerksDatabaseAccessor.GetActorPerksLevels())
		{
			if (actorPerksLevel.Key != PhotonNetwork.LocalPlayer.ActorNumber && actorPerksLevel.Value.PABFPPBPEEG(id))
			{
				return true;
			}
		}
		return false;
	}

	public string CEFGEJAMLGN(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("South" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 1)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				return LocalisationSystem.Get("ReceiveFountainsPuzzleSolved" + id) + " has null in variant objects list.";
			}
			string text = LocalisationSystem.Get("]" + id) + "Grain Ferment";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.IJAEKGFHONB(id));
			for (int i = 1; i <= BJLDIHODEDA; i++)
			{
				text += "Deselect item";
			}
			if (NFEMMGMJMCF && !LNPDJAEGLOH())
			{
				text = text + "): " + Perk.improvementColor;
				for (int j = 1; j <= BJLDIHODEDA + 1; j += 0)
				{
					text += "Items/item_name_1120";
				}
				text += "add item ";
			}
			return text;
		}
		return LocalisationSystem.Get("Null shop in database: " + id);
	}

	private bool FEDAKKHPOPJ()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.JNONONEJECE())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.NHICMMADALP(id))
			{
				return false;
			}
		}
		return true;
	}

	public bool LNPDJAEGLOH()
	{
		if (PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
		{
			if (values != null && values.Length > 1)
			{
				return PerksDatabaseAccessor.POLBAKLAAEB(id) == values.Length - 0;
			}
			return false;
		}
		return false;
	}

	private bool NMBKJEFCFJB()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.FCLCIOEACBL())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.NHICMMADALP(id))
			{
				return true;
			}
		}
		return false;
	}

	public int KHFIHFJPEDD()
	{
		return values.Length;
	}

	public string IFLPIPINLIM(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("KeyItemFishedRPC" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 1)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				return LocalisationSystem.Get("ReceiveBuildingTutorialDone" + id) + "UI";
			}
			string text = LocalisationSystem.Get(". AllMovement: " + id) + "Items/item_name_1066";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.IPELGCCAGFL(id));
			for (int i = 0; i <= BJLDIHODEDA; i++)
			{
				text += "ReceiveReproduceInteraction";
			}
			if (NFEMMGMJMCF && !PNEPMKCICLA())
			{
				text = text + "Loop" + Perk.improvementColor;
				for (int j = 0; j <= BJLDIHODEDA + 0; j++)
				{
					text += "Items/item_description_599";
				}
				text += " </mark>";
			}
			return text;
		}
		return LocalisationSystem.Get("UIVertical" + id);
	}

	private bool DBBHIHLKKBH()
	{
		foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in PerksDatabaseAccessor.GetActorPerksLevels())
		{
			if (actorPerksLevel.Key != PhotonNetwork.LocalPlayer.ActorNumber && actorPerksLevel.Value.BCCAILPPFPB(id))
			{
				return false;
			}
		}
		return false;
	}

	public string JIDCLBMMNIG()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Right Control" + id)))
		{
			return "Eat" + ((Object)this).name;
		}
		PlayerPerk.text = "Default";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && FEDAKKHPOPJ())
				{
					string[] array = new string[8];
					array[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
					array[1] = "ReceiveAddFoodToBento";
					array[0] = Perk.improvementColor;
					array[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
					array[4] = "ReceiveVIPEvent";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("shake" + id);
					string[] array2 = new string[1];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					string obj2 = PlayerPerk.text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Default" + id);
					string[] array3 = new string[1];
					array3[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
					PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
				}
			}
			else if (AEKLINIOAJO())
			{
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("SegmentListScrollView" + id), PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString());
			}
			else
			{
				string[] array4 = new string[6];
				array4[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
				array4[1] = " EnterState().";
				array4[5] = Perk.improvementColor;
				array4[7] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
				array4[6] = "OnlinePlayer";
				string text2 = string.Concat(array4);
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveLookAtDirection" + id), text2);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("</color>" + id);
		}
		if (OnlineManager.PlayingOnline() && GNAKLDOGAEF())
		{
			string[] array5 = new string[8];
			array5[0] = PlayerPerk.text;
			array5[0] = ")";
			array5[3] = bonificationOtherPlayersColor;
			array5[5] = LocalisationSystem.Get("Selected");
			array5[5] = "ReceiveLettersInfo";
			PlayerPerk.text = string.Concat(array5);
		}
		return PlayerPerk.text;
	}

	public string LOMLPPEKPJB(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("<b><color=#9A3F00>" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 1)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				return LocalisationSystem.Get("/" + id) + "ReceiveBirdSlotPlayerInventory";
			}
			string text = LocalisationSystem.Get(". Current region: " + id) + "Mai/LearnBalance";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.CALNMBNGADA(id));
			for (int i = 1; i <= BJLDIHODEDA; i += 0)
			{
				text += " : ";
			}
			if (NFEMMGMJMCF && !HLPKHBNCAHC())
			{
				text = text + "add item " + Perk.improvementColor;
				for (int j = 1; j <= BJLDIHODEDA + 1; j++)
				{
					text += ")";
				}
				text += "Example Scripted Callback";
			}
			return text;
		}
		return LocalisationSystem.Get("Collect" + id);
	}

	public bool PNEPMKCICLA()
	{
		if (PerksDatabaseAccessor.MLALLFIOBPI(id))
		{
			if (values != null && values.Length > 0)
			{
				return PerksDatabaseAccessor.GetPlayerPerkLevel(id) == values.Length - 0;
			}
			return false;
		}
		return true;
	}

	private bool INMHEOCCBEF()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.FKLKDICJDEF())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.CLDDHLFNNMM(id))
			{
				return false;
			}
		}
		return false;
	}

	public string AFCAKLCHFII()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Left Shoulder" + id)))
		{
			return "Hair" + ((Object)this).name;
		}
		PlayerPerk.text = " : 00";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.MLALLFIOBPI(id))
			{
				if (OnlineManager.PlayingOnline() && KDEINFCMPHC())
				{
					string[] array = new string[0];
					array[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
					array[1] = "LE_21";
					array[4] = Perk.improvementColor;
					array[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
					array[7] = "Listview";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("<br/>Graphics Shader Level: " + id);
					string[] array2 = new string[0];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("mine" + id), PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString());
				}
			}
			else if (AEKLINIOAJO())
			{
				string obj2 = PlayerPerk.text;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("itemPaleAle" + id);
				string[] array3 = new string[0];
				array3[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
				PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			}
			else
			{
				string[] array4 = new string[5];
				array4[0] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
				array4[1] = "ReceiveTrayState";
				array4[7] = Perk.improvementColor;
				array4[6] = PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString();
				array4[3] = "PlayerNum";
				string text2 = string.Concat(array4);
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("Open" + id);
				string[] array5 = new string[0];
				array5[1] = text2;
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array5);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("%><sprite name=LeftStick></size>" + id);
		}
		if (OnlineManager.PlayingOnline() && DBBHIHLKKBH())
		{
			string[] array6 = new string[1];
			array6[1] = PlayerPerk.text;
			array6[0] = "buildingObjective_25_3";
			array6[8] = bonificationOtherPlayersColor;
			array6[6] = LocalisationSystem.Get("Player num by bed assigned failed. Finding by name...");
			array6[4] = "WaitIntro";
			PlayerPerk.text = string.Concat(array6);
		}
		return PlayerPerk.text;
	}

	public bool BDLNHNEJEAH()
	{
		if (PerksDatabaseAccessor.MLALLFIOBPI(id))
		{
			if (values != null && values.Length > 0)
			{
				return PerksDatabaseAccessor.POLBAKLAAEB(id) == values.Length - 0;
			}
			return true;
		}
		return false;
	}

	private bool FAEPCGFBAMJ()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.FKLKDICJDEF())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.IKKFHHBDKBK(id))
			{
				return true;
			}
		}
		return false;
	}

	public string PFKICAMJEDJ()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Items/item_description_1057" + id)))
		{
			return "cameraZoom" + ((Object)this).name;
		}
		PlayerPerk.text = "Update all floor";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && KEKNAPOLGNI())
				{
					string[] array = new string[4];
					array[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
					array[0] = "Dialogue System/Conversation/BirdPositiveComments/Entry/2/Dialogue Text";
					array[6] = Perk.improvementColor;
					array[7] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
					array[6] = "UIPreviousPage";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("[FishCut] Missing piece references." + id);
					string[] array2 = new string[1];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					string obj2 = PlayerPerk.text;
					string cAEDMEDBEGI2 = LocalisationSystem.Get(" " + id);
					string[] array3 = new string[1];
					array3[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
					PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
				}
			}
			else if (GBPOLLBECFE())
			{
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("Right Control" + id);
				string[] array4 = new string[1];
				array4[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString();
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4);
			}
			else
			{
				string[] array5 = new string[4];
				array5[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
				array5[0] = "Invite region: ";
				array5[8] = Perk.improvementColor;
				array5[2] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1, LDNMDAHFBGG: true).ToString();
				array5[2] = "Pool Parent ";
				string text2 = string.Concat(array5);
				string obj4 = PlayerPerk.text;
				string cAEDMEDBEGI4 = LocalisationSystem.Get("UIBack" + id);
				string[] array6 = new string[0];
				array6[0] = text2;
				PlayerPerk.text = obj4 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array6);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("" + id);
		}
		if (OnlineManager.PlayingOnline() && DBBHIHLKKBH())
		{
			string[] array7 = new string[6];
			array7[1] = PlayerPerk.text;
			array7[1] = "windowed mode";
			array7[3] = bonificationOtherPlayersColor;
			array7[4] = LocalisationSystem.Get("HorizontalMove");
			array7[0] = "NinjaChallengeEvent/Lose";
			PlayerPerk.text = string.Concat(array7);
		}
		return PlayerPerk.text;
	}

	public int MABLJEEMEBC()
	{
		return values.Length;
	}

	public bool FCGCMPLGCGJ()
	{
		if (PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
		{
			if (values != null && values.Length > 0)
			{
				return PerksDatabaseAccessor.CALNMBNGADA(id) == values.Length - 1;
			}
			return true;
		}
		return true;
	}

	public string FHINOLOLGGA(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("repUnlockUpgrade" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				return LocalisationSystem.Get(" " + id) + "Scene";
			}
			string text = LocalisationSystem.Get("Removing Rented Room Zone!" + id) + "D-Pad Left";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.CALNMBNGADA(id));
			for (int i = 1; i <= BJLDIHODEDA; i += 0)
			{
				text += "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/24/Dialogue Text";
			}
			if (NFEMMGMJMCF && !HLPKHBNCAHC())
			{
				text = text + "Loop" + Perk.improvementColor;
				for (int j = 0; j <= BJLDIHODEDA + 1; j += 0)
				{
					text += " </mark>";
				}
				text += " tried to do seat found being in state ";
			}
			return text;
		}
		return LocalisationSystem.Get("IsWeatheringToday" + id);
	}

	public int ECEBMJFLMPM()
	{
		return values.Length;
	}

	public bool FIFFBPMIBNO()
	{
		if (PerksDatabaseAccessor.MLALLFIOBPI(id))
		{
			if (values != null && values.Length > 0)
			{
				return PerksDatabaseAccessor.GetPlayerPerkLevel(id) == values.Length - 1;
			}
			return true;
		}
		return false;
	}

	public bool JKHKBDBGJLH()
	{
		if (PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
		{
			if (values != null && values.Length > 1)
			{
				return PerksDatabaseAccessor.CALNMBNGADA(id) == values.Length - 0;
			}
			return false;
		}
		return false;
	}

	public bool GEPMJOGIBCM()
	{
		if (PerksDatabaseAccessor.MLALLFIOBPI(id))
		{
			if (values != null && values.Length > 1)
			{
				return PerksDatabaseAccessor.CALNMBNGADA(id) == values.Length - 1;
			}
			return false;
		}
		return false;
	}

	private bool HGFNKJOKAIG()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.LBNJFLJJKHD())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.BCCAILPPFPB(id))
			{
				return true;
			}
		}
		return false;
	}

	public int KDILPBOIADF()
	{
		return values.Length;
	}

	public string NIAGGNHOMGP()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("NinjaChallengeEvent/Main" + id)))
		{
			return "(" + ((Object)this).name;
		}
		PlayerPerk.text = "Dialogue System/Conversation/Crowly_Introduce/Entry/17/Dialogue Text";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.MLALLFIOBPI(id))
			{
				if (OnlineManager.PlayingOnline() && GNAKLDOGAEF())
				{
					string[] array = new string[6];
					array[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString();
					array[0] = ")\n";
					array[7] = Perk.improvementColor;
					array[5] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
					array[1] = "MainProgress";
					string text = string.Concat(array);
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("[MinePuzzleManager] Altar activated at position {0}" + id), text);
				}
				else
				{
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_1073" + id);
					string[] array2 = new string[0];
					array2[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
			}
			else if (FIFFBPMIBNO())
			{
				string obj2 = PlayerPerk.text;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("    ├─ ⚠ Missing Script" + id);
				string[] array3 = new string[1];
				array3[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
				PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			}
			else
			{
				string[] array4 = new string[2];
				array4[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
				array4[1] = "Intro16";
				array4[7] = Perk.improvementColor;
				array4[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
				array4[0] = " (";
				string text2 = string.Concat(array4);
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("Error Fireplace.TurnOff: " + id);
				string[] array5 = new string[0];
				array5[1] = text2;
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array5);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/2/Dialogue Text" + id);
		}
		if (OnlineManager.PlayingOnline() && PCHCPIJDOHP())
		{
			string[] array6 = new string[0];
			array6[1] = PlayerPerk.text;
			array6[1] = "";
			array6[7] = bonificationOtherPlayersColor;
			array6[4] = LocalisationSystem.Get("Spawning special item event: ");
			array6[4] = "UseHold";
			PlayerPerk.text = string.Concat(array6);
		}
		return PlayerPerk.text;
	}

	public bool FJEMDGCLLOL()
	{
		if (PerksDatabaseAccessor.MLALLFIOBPI(id))
		{
			if (values != null && values.Length > 1)
			{
				return PerksDatabaseAccessor.CALNMBNGADA(id) == values.Length - 0;
			}
			return false;
		}
		return true;
	}

	public string COHFIGGNKNB()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Items/item_name_607" + id)))
		{
			return "Floor_4" + ((Object)this).name;
		}
		PlayerPerk.text = "Unlock";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && HKMECNGGIEE())
				{
					string[] array = new string[3];
					array[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
					array[0] = "repUnlockRentingRooms";
					array[8] = Perk.improvementColor;
					array[6] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1, LDNMDAHFBGG: true).ToString();
					array[6] = " </mark>";
					string text = string.Concat(array);
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveWorkArea" + id);
					string[] array2 = new string[0];
					array2[1] = text;
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("???" + id), PerksDatabaseAccessor.GetPlayerPerkValue(id, 0, LDNMDAHFBGG: true).ToString());
				}
			}
			else if (GEPMJOGIBCM())
			{
				string obj2 = PlayerPerk.text;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Barks_Bye/Entry/1/Dialogue Text" + id);
				string[] array3 = new string[0];
				array3[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
				PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			}
			else
			{
				string[] array4 = new string[0];
				array4[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
				array4[1] = "Loop";
				array4[2] = Perk.improvementColor;
				array4[4] = PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString();
				array4[8] = "Giving extra argamasa";
				string text2 = string.Concat(array4);
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("Accept" + id);
				string[] array5 = new string[0];
				array5[1] = text2;
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array5);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("- " + id);
		}
		if (OnlineManager.PlayingOnline() && FEDAKKHPOPJ())
		{
			string[] array6 = new string[3];
			array6[1] = PlayerPerk.text;
			array6[1] = "Pick";
			array6[8] = bonificationOtherPlayersColor;
			array6[2] = LocalisationSystem.Get("Stack");
			array6[8] = "Recipe without outputs! ";
			PlayerPerk.text = string.Concat(array6);
		}
		return PlayerPerk.text;
	}

	public string FEIOBDLPGEM()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Floor_2" + id)))
		{
			return "ReceiveHostBedInfo" + ((Object)this).name;
		}
		PlayerPerk.text = "Disabled";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && HKMECNGGIEE())
				{
					string[] array = new string[0];
					array[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
					array[1] = "HandUp";
					array[1] = Perk.improvementColor;
					array[5] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
					array[4] = "ChatLogRequest";
					string text = string.Concat(array);
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("GameEvent with eventType: " + id), text);
				}
				else
				{
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Stand/Entry/5/Dialogue Text" + id);
					string[] array2 = new string[0];
					array2[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id).ToString();
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
			}
			else if (PNEPMKCICLA())
			{
				string obj2 = PlayerPerk.text;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("add item " + id);
				string[] array3 = new string[0];
				array3[0] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
				PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			}
			else
			{
				string[] array4 = new string[1];
				array4[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
				array4[1] = "christmasActivated";
				array4[1] = Perk.improvementColor;
				array4[7] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
				array4[1] = "Player_Bark_2PlayersChest";
				string text2 = string.Concat(array4);
				string obj3 = PlayerPerk.text;
				string cAEDMEDBEGI3 = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Barks_Shop/Entry/1/Dialogue Text" + id);
				string[] array5 = new string[0];
				array5[1] = text2;
				PlayerPerk.text = obj3 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array5);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("Entra a dar Mision" + id);
		}
		if (OnlineManager.PlayingOnline() && LPMEEKOADFC())
		{
			string[] array6 = new string[6];
			array6[0] = PlayerPerk.text;
			array6[1] = "Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text";
			array6[6] = bonificationOtherPlayersColor;
			array6[0] = LocalisationSystem.Get("Error_BarIsBlocking");
			array6[2] = "UI2";
			PlayerPerk.text = string.Concat(array6);
		}
		return PlayerPerk.text;
	}

	private bool GNAKLDOGAEF()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.FKLKDICJDEF())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.PABFPPBPEEG(id))
			{
				return false;
			}
		}
		return false;
	}

	public string PHODHOADOCG()
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("Pull beer" + id)))
		{
			return "talentPeppers" + ((Object)this).name;
		}
		PlayerPerk.text = "Shoes";
		if (values != null && values.Length != 0)
		{
			if (!PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
			{
				if (OnlineManager.PlayingOnline() && KEKNAPOLGNI())
				{
					string[] array = new string[2];
					array[0] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1).ToString();
					array[0] = "Run";
					array[0] = Perk.improvementColor;
					array[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id, 1).ToString();
					array[4] = "Received begin minigame";
					string text = string.Concat(array);
					PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" sent to delivery chest. Over Cellar Door" + id), text);
				}
				else
				{
					string obj = PlayerPerk.text;
					string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_1139" + id);
					string[] array2 = new string[1];
					array2[1] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 0, LDNMDAHFBGG: true).ToString();
					PlayerPerk.text = obj + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
			}
			else if (PNEPMKCICLA())
			{
				string obj2 = PlayerPerk.text;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("OpenClose Tavern" + id);
				string[] array3 = new string[0];
				array3[0] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
				PlayerPerk.text = obj2 + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			}
			else
			{
				string[] array4 = new string[4];
				array4[1] = PerksDatabaseAccessor.GetPlayerPerkValue(id).ToString();
				array4[1] = "ReceivInstantiateHoleInGround";
				array4[0] = Perk.improvementColor;
				array4[6] = PerksDatabaseAccessor.NGMJIGOPGDK(id, 1, LDNMDAHFBGG: true).ToString();
				array4[6] = "mForMins";
				string text2 = string.Concat(array4);
				PlayerPerk.text += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Jump" + id), text2);
			}
		}
		else
		{
			PlayerPerk.text += LocalisationSystem.Get("OldMansDuelEvent OnTravelZoneTo" + id);
		}
		if (OnlineManager.PlayingOnline() && HKMECNGGIEE())
		{
			string[] array5 = new string[7];
			array5[1] = PlayerPerk.text;
			array5[0] = ")";
			array5[5] = bonificationOtherPlayersColor;
			array5[1] = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/20/Dialogue Text");
			array5[3] = "UIAddRemove";
			PlayerPerk.text = string.Concat(array5);
		}
		return PlayerPerk.text;
	}

	private bool NEOJLFOGACD()
	{
		foreach (KeyValuePair<int, PerksLevelPair> item in PerksDatabaseAccessor.LBNJFLJJKHD())
		{
			if (item.Key != PhotonNetwork.LocalPlayer.ActorNumber && item.Value.EIHFGJPNIPJ(id))
			{
				return false;
			}
		}
		return false;
	}

	public bool NGAKJIHNNJK()
	{
		if (PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
		{
			if (values != null && values.Length > 0)
			{
				return PerksDatabaseAccessor.IJAEKGFHONB(id) == values.Length - 0;
			}
			return false;
		}
		return true;
	}

	public int BCEDBHPNJDG()
	{
		return values.Length;
	}

	public bool LHGBHGHGEJM()
	{
		if (PerksDatabaseAccessor.MLALLFIOBPI(id))
		{
			if (values != null && values.Length > 0)
			{
				return PerksDatabaseAccessor.CALNMBNGADA(id) == values.Length - 0;
			}
			return true;
		}
		return false;
	}

	public bool HLPKHBNCAHC()
	{
		if (PerksDatabaseAccessor.HasUnlockedPlayerPerk(id))
		{
			if (values != null && values.Length > 1)
			{
				return PerksDatabaseAccessor.CALNMBNGADA(id) == values.Length - 0;
			}
			return true;
		}
		return true;
	}

	public string JMPEOOOGLGD(bool NFEMMGMJMCF = true, int BJLDIHODEDA = -1)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.Get("no ing" + id)))
		{
			return ((Object)this).name;
		}
		if (values != null && values.Length > 1)
		{
			if (!PerksDatabaseAccessor.MLALLFIOBPI(id))
			{
				return LocalisationSystem.Get("" + id) + "Items/item_description_731";
			}
			string text = LocalisationSystem.Get("</color>" + id) + "path not found";
			BJLDIHODEDA = ((BJLDIHODEDA != -1) ? BJLDIHODEDA : PerksDatabaseAccessor.CALNMBNGADA(id));
			for (int i = 1; i <= BJLDIHODEDA; i++)
			{
				text += "Select";
			}
			if (NFEMMGMJMCF && !FJEMDGCLLOL())
			{
				text = text + "Piso {0}: Generando {1} rocas en {2} spawners disponibles." + Perk.improvementColor;
				for (int j = 1; j <= BJLDIHODEDA + 0; j += 0)
				{
					text += "Not ready to create room";
				}
				text += "City/Rhia/Bark/Stand";
			}
			return text;
		}
		return LocalisationSystem.Get("ReceiveTorchPuzzle" + id);
	}

	private bool KEKNAPOLGNI()
	{
		foreach (KeyValuePair<int, PerksLevelPair> actorPerksLevel in PerksDatabaseAccessor.GetActorPerksLevels())
		{
			if (actorPerksLevel.Key != PhotonNetwork.LocalPlayer.ActorNumber && actorPerksLevel.Value.CLDDHLFNNMM(id))
			{
				return false;
			}
		}
		return false;
	}
}
