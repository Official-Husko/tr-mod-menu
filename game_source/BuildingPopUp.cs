using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Building Pop Up")]
public class BuildingPopUp : ScriptableObject, PopUp
{
	[Serializable]
	public class Objective
	{
		public int id;

		public BuildingTutorialGoals goal;
	}

	public int id;

	public Objective[] objectives;

	public BuildingTutorialFocus focus;

	public int goalDecoId;

	public List<ETavernEditorPanel> panelsAvailable;

	public List<EditorAction> actionsAvailable;

	public List<int> decorationsAvailable;

	public TavernFloor floorsAvailable = TavernFloor.AllTavernFloors;

	public bool acceptButtonAvailable;

	public bool AIBJANIMHIH()
	{
		if (objectives != null)
		{
			return (nuint)objectives.LongLength > 1;
		}
		return false;
	}

	public bool MHMCIPELABC()
	{
		if (objectives != null)
		{
			return (nuint)objectives.LongLength > 1;
		}
		return false;
	}

	public bool CIBJDEMKMPF()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return true;
	}

	public bool FLFOJGBDHAC()
	{
		if (objectives != null)
		{
			return (nuint)objectives.LongLength > 1;
		}
		return true;
	}

	public string CEJJICLAIII(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 2 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 1)
		{
			return LocalisationSystem.GetStringWithTags("Object ", JIIGOACEIKL) + "Normal" + LocalisationSystem.GetStringWithTags("City/Rhia/Introduce", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("Player2" + id, JIIGOACEIKL);
	}

	public string JMADICIIOAO(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 4 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 0)
		{
			return LocalisationSystem.PKLPKIAHCDI("Object with itemID ", JIIGOACEIKL) + "Farm/Bob/Barks_Shop" + LocalisationSystem.GetStringWithTags("MainProgress", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI(" for " + id, JIIGOACEIKL);
	}

	public bool NINFCKGIDFG()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return true;
	}

	public string NECBJCEHBLL(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 2 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 2)
		{
			return LocalisationSystem.GetStringWithTags("", JIIGOACEIKL) + "SearchBox_ItemName..." + LocalisationSystem.PKLPKIAHCDI("Staff", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("" + id, JIIGOACEIKL);
	}

	public string GGLKODNHLJF(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 0 && (int)PlayerInputs.GetPlayerControllers(JIIGOACEIKL).GetLastActiveController().type != 3)
		{
			return LocalisationSystem.GetStringWithTags("Favorites", JIIGOACEIKL) + "Scene" + LocalisationSystem.GetStringWithTags("Getting file list from storage failed for reason: ", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("Dialogue System/Conversation/Crowly_Standar/Entry/23/Dialogue Text" + id, JIIGOACEIKL);
	}

	public bool EFIGIKIMLOO()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return true;
	}

	public string CBGNAEDDAIE(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 1 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 6)
		{
			return LocalisationSystem.PKLPKIAHCDI("HitCollider2", JIIGOACEIKL) + "" + LocalisationSystem.PKLPKIAHCDI("LearnBalance", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("Key1" + id, JIIGOACEIKL);
	}

	public string IIAOKPJGDOA(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 2 && (int)PlayerInputs.GetPlayerControllers(JIIGOACEIKL).GetLastActiveController().type != 2)
		{
			return LocalisationSystem.GetStringWithTags("popUpBuilding2", JIIGOACEIKL) + " " + LocalisationSystem.GetStringWithTags("popUpBuilding2B", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("popUpBuilding" + id, JIIGOACEIKL);
	}

	public string MKNLDOOFGFO(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 6 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 1)
		{
			return LocalisationSystem.PKLPKIAHCDI("RentedRoom", JIIGOACEIKL) + "UI2" + LocalisationSystem.PKLPKIAHCDI("add item ", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("AceT_Quest" + id, JIIGOACEIKL);
	}

	public string GGFELKGGPKF(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 4 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 5)
		{
			return LocalisationSystem.PKLPKIAHCDI("", JIIGOACEIKL) + "Can't find seat. Reason: CustomerEnterTime" + LocalisationSystem.PKLPKIAHCDI("Open", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("Puente_EA/Talk 2" + id, JIIGOACEIKL);
	}

	public string JHCCIKLMBLL(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 2 && (int)PlayerInputs.GetPlayerControllers(JIIGOACEIKL).GetLastActiveController().type != 6)
		{
			return LocalisationSystem.PKLPKIAHCDI("Intro", JIIGOACEIKL) + "</color>\n" + LocalisationSystem.GetStringWithTags("Disappear", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("Players are Sleeping. Waiting..." + id, JIIGOACEIKL);
	}

	public string CAHJMLCLMHC(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 2 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 0)
		{
			return LocalisationSystem.PKLPKIAHCDI("Fertile soil object not found at ", JIIGOACEIKL) + "Wake Up" + LocalisationSystem.PKLPKIAHCDI("South", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("check keybinds" + id, JIIGOACEIKL);
	}

	public bool JNHFNEBCNJK()
	{
		if (objectives != null)
		{
			return (nuint)objectives.LongLength > 1;
		}
		return true;
	}

	public string PJLEKLGJDKC(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 0 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 2)
		{
			return LocalisationSystem.GetStringWithTags("Sleep", JIIGOACEIKL) + "\n" + LocalisationSystem.PKLPKIAHCDI("UIInteract", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("Dialogue System/Conversation/NeutralInTavern/Entry/13/Dialogue Text" + id, JIIGOACEIKL);
	}

	public string OMLELBFMCNP(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 1 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 3)
		{
			return LocalisationSystem.GetStringWithTags("ReceiveHit", JIIGOACEIKL) + "SceneReferences Start" + LocalisationSystem.PKLPKIAHCDI("BeginChatFade", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("autoRunP2" + id, JIIGOACEIKL);
	}

	public bool GDGOIAFACLG()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return false;
	}

	public bool GEODFLPDMGB()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return true;
	}

	public string IFNHMMFFHEK(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 8 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 7)
		{
			return LocalisationSystem.PKLPKIAHCDI("Xbox", JIIGOACEIKL) + "MeltState" + LocalisationSystem.PKLPKIAHCDI("Trying to create a new room with a different code...", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("Dialogue System/Conversation/Gass_Introduce/Entry/3/Dialogue Text" + id, JIIGOACEIKL);
	}

	public bool EKAOINHPHAM()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return true;
	}

	public string MPFLJNMCKMK(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 4 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 8)
		{
			return LocalisationSystem.GetStringWithTags("UINextPage", JIIGOACEIKL) + "GiveItem" + LocalisationSystem.PKLPKIAHCDI("LE_15", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("ReceiveToolUpgradingRPC" + id, JIIGOACEIKL);
	}

	public bool NMIIPEDCPKL()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return true;
	}

	public bool AEBCOJGEOFF()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return false;
	}

	public bool JEEHJEILDIB()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return true;
	}

	public bool JHIEFBPELMI()
	{
		if (objectives != null)
		{
			return (nuint)objectives.LongLength > 1;
		}
		return true;
	}

	public bool GMKLPMGLDPM()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return false;
	}

	public string NCGMANCPLFF(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 5 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 8)
		{
			return LocalisationSystem.PKLPKIAHCDI("Avatar", JIIGOACEIKL) + "" + LocalisationSystem.PKLPKIAHCDI("MothersRecipe/Talk", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects" + id, JIIGOACEIKL);
	}

	public string NENEAPOEGED(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 2 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 3)
		{
			return LocalisationSystem.PKLPKIAHCDI("Chat end edit", JIIGOACEIKL) + "Example Method With Param: " + LocalisationSystem.PKLPKIAHCDI(" at ", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("NormalLeftExterior" + id, JIIGOACEIKL);
	}

	public bool PCLCAOHFOGF()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return false;
	}

	public bool CPMAIOPFPID()
	{
		if (objectives != null)
		{
			return (nuint)objectives.LongLength > 1;
		}
		return true;
	}

	public string OMFJDCDJDIB(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 5 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 0)
		{
			return LocalisationSystem.GetStringWithTags("City/Rhia/Bark/Stand", JIIGOACEIKL) + "SortByType" + LocalisationSystem.PKLPKIAHCDI("DestroyAfter", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("cliffs" + id, JIIGOACEIKL);
	}

	public string BFABCKACMIN(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 6 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 4)
		{
			return LocalisationSystem.PKLPKIAHCDI("ReceiveBathhouseEntranceEventLeftBathhouse", JIIGOACEIKL) + "activate event " + LocalisationSystem.GetStringWithTags("Quest Complete", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("NetworkSync " + id, JIIGOACEIKL);
	}

	public bool BGHJBKDILLG()
	{
		if (objectives != null)
		{
			return objectives.Length != 0;
		}
		return false;
	}

	public string BDADAKJPGMK(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 6 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 1)
		{
			return LocalisationSystem.GetStringWithTags("MineState", JIIGOACEIKL) + "Too late to open" + LocalisationSystem.PKLPKIAHCDI("BathhouseGame/Win", JIIGOACEIKL);
		}
		return LocalisationSystem.PKLPKIAHCDI("A number is needed." + id, JIIGOACEIKL);
	}

	public bool AFJCAMDENGE()
	{
		if (objectives != null)
		{
			return (nuint)objectives.LongLength > 1;
		}
		return true;
	}

	public string GECGLMFDKKO(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 8 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 2)
		{
			return LocalisationSystem.GetStringWithTags("MainProgress", JIIGOACEIKL) + ", " + LocalisationSystem.GetStringWithTags("Boots_L", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags(", " + id, JIIGOACEIKL);
	}

	public string KMLNPONEINN(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 4 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 8)
		{
			return LocalisationSystem.GetStringWithTags("Place", JIIGOACEIKL) + "Dead" + LocalisationSystem.PKLPKIAHCDI("Shield", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("DecorationTile_9" + id, JIIGOACEIKL);
	}

	public string MICFDOBFCCN(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 8 && (int)PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).GetLastActiveController().type != 7)
		{
			return LocalisationSystem.GetStringWithTags("</color>] ", JIIGOACEIKL) + "BarkActor" + LocalisationSystem.PKLPKIAHCDI("Next random: ", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags("- " + id, JIIGOACEIKL);
	}

	public string OMJMHPFEGNP(int JIIGOACEIKL)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if (id == 6 && (int)PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).GetLastActiveController().type != 2)
		{
			return LocalisationSystem.PKLPKIAHCDI("ActionBar8", JIIGOACEIKL) + "OnConversationStarted MothersRecipe Event " + LocalisationSystem.PKLPKIAHCDI("quest_name_17", JIIGOACEIKL);
		}
		return LocalisationSystem.GetStringWithTags(" not found" + id, JIIGOACEIKL);
	}
}
