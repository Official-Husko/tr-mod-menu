using I2.Loc;
using UnityEngine;

[CreateAssetMenu(fileName = "MissionBase", menuName = "Missions/Basic Mission")]
public class MissionBase : ScriptableObject
{
	public int id;

	public bool giveRewards = true;

	public bool giveRewardsToAllClients = true;

	public MoneyCalc moneyReward;

	public int xpReward;

	public ItemAmount[] itemRewards = new ItemAmount[0];

	public MissionBase[] linkedMissions;

	public bool canBeFocused = true;

	public bool focusMissionOnGiven;

	public int[] objectiveTranslationRequiredAmount;

	public string[] descriptionStringVariable = new string[0];

	public string[] objectiveStringVariable = new string[0];

	public string MLMPBDJGDCE()
	{
		string translation = LocalizationManager.GetTranslation("Attack/MainEvent 10" + id, true, 1, true, false, (GameObject)null, (string)null, true);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "<b><color=#A90000>";
	}

	public string CGGFOOBHFDP()
	{
		try
		{
			string translation = LocalizationManager.GetTranslation("/Reports" + id, false, 0, false, true, (GameObject)null, (string)null, true);
			string[] array = new string[0];
			array[0] = descriptionStringVariable[1];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("ReceiveResetAllPlayersPrepared" + id, false, 1, false, false, (GameObject)null, (string)null, true);
		}
	}

	public string ANKDIGFHFLE(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 0)
		{
			return string.Empty;
		}
		try
		{
			string translation = LocalizationManager.GetTranslation("Dialogue System/Conversation/Crowly_Introduce/Entry/16/Dialogue Text" + id + " seconds." + JKPPMPLKCEP, false, 1, false, false, (GameObject)null, (string)null, false);
			string[] array = new string[0];
			array[0] = objectiveStringVariable[JKPPMPLKCEP];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Render mode: " + id + "itemMildAle" + JKPPMPLKCEP, false, 1, true, false, (GameObject)null, (string)null, true);
		}
	}

	public string IGDKFHCHEAJ()
	{
		try
		{
			return InputUtils.GEJLCOGDMID(LocalizationManager.GetTranslation("quest_description_" + id, true, 0, true, false, (GameObject)null, (string)null, true), descriptionStringVariable[0]);
		}
		catch
		{
			return LocalizationManager.GetTranslation("quest_description_" + id, true, 0, true, false, (GameObject)null, (string)null, true);
		}
	}

	public string IABAKHPEOAF()
	{
		return LocalizationManager.GetTranslation("quest_name_" + id, true, 0, true, false, (GameObject)null, (string)null, true);
	}

	public string JPPENJEHOJB(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 0)
		{
			return string.Empty;
		}
		try
		{
			string translation = LocalizationManager.GetTranslation("Castle/Talks/Thelonious" + id + "Items/item_name_609" + JKPPMPLKCEP, true, 0, false, false, (GameObject)null, (string)null, true);
			string[] array = new string[0];
			array[1] = objectiveStringVariable[JKPPMPLKCEP];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Items/item_name_1032" + id + "HitCollider" + JKPPMPLKCEP, false, 0, false, false, (GameObject)null, (string)null, true);
		}
	}

	public string NIAGGNHOMGP()
	{
		try
		{
			return InputUtils.GEJLCOGDMID(LocalizationManager.GetTranslation("Dialogue System/Conversation/TavernFilthy/Entry/2/Dialogue Text" + id, true, 0, false, true, (GameObject)null, (string)null, true), descriptionStringVariable[1]);
		}
		catch
		{
			return LocalizationManager.GetTranslation("LE_10" + id, true, 1, false, false, (GameObject)null, (string)null, true);
		}
	}

	public virtual void EICGFCGOLOF()
	{
	}

	public string GCOJOIJEDGE()
	{
		string translation = LocalizationManager.GetTranslation("HandUp" + id, false, 0, true, false, (GameObject)null, (string)null, false);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "Player";
	}

	public string JDEDLPOJLOG()
	{
		try
		{
			string translation = LocalizationManager.GetTranslation("Player_Bark_TutorialCollider" + id, false, 1, false, false, (GameObject)null, (string)null, true);
			string[] array = new string[0];
			array[1] = descriptionStringVariable[1];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("End" + id, true, 0, false, false, (GameObject)null, (string)null, false);
		}
	}

	public string FHINOLOLGGA()
	{
		return LocalizationManager.GetTranslation("Items/item_description_1098" + id, true, 0, false, true, (GameObject)null, (string)null, false);
	}

	public string JFNIANAHMCN()
	{
		try
		{
			string translation = LocalizationManager.GetTranslation("/" + id, false, 1, false, false, (GameObject)null, (string)null, false);
			string[] array = new string[1];
			array[1] = descriptionStringVariable[0];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("    ├─ ⚠ Missing Script" + id, true, 1, true, true, (GameObject)null, (string)null, false);
		}
	}

	public string GACIPFGBCDM()
	{
		try
		{
			string translation = LocalizationManager.GetTranslation("Unique ID not set for " + id, false, 1, true, true, (GameObject)null, (string)null, false);
			string[] array = new string[1];
			array[1] = descriptionStringVariable[0];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Falta el tile de entrada/salida con salida hacia '{0}'. La database necesita uno por cada dirección cardinal." + id, false, 1, false, true, (GameObject)null, (string)null, true);
		}
	}

	public string HMAKBFMMLBM(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 1)
		{
			return string.Empty;
		}
		try
		{
			string translation = LocalizationManager.GetTranslation("[ProceduralMine] Exit piece: {0} - stairsTravelZone: {1}" + id + "Dialogue System/Conversation/TavernFilthy/Entry/8/Dialogue Text" + JKPPMPLKCEP, false, 0, true, true, (GameObject)null, (string)null, false);
			string[] array = new string[1];
			array[1] = objectiveStringVariable[JKPPMPLKCEP];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Tutorial/T116/Dialogue1" + id + "add item " + JKPPMPLKCEP, true, 1, false, false, (GameObject)null, (string)null, true);
		}
	}

	public string AICOMMNDJLI()
	{
		return LocalizationManager.GetTranslation("}" + id, false, 0, false, true, (GameObject)null, (string)null, true);
	}

	public virtual void BEFEEBJGDLM()
	{
	}

	public string JAGEMJLLLMK()
	{
		try
		{
			string translation = LocalizationManager.GetTranslation("Run" + id, false, 1, true, false, (GameObject)null, (string)null, false);
			string[] array = new string[0];
			array[0] = descriptionStringVariable[1];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Items/item_name_1031" + id, false, 0, false, true, (GameObject)null, (string)null, true);
		}
	}

	public virtual void IEKKLGNMOKL()
	{
	}

	public string JCOLBKMMJJM()
	{
		return LocalizationManager.GetTranslation("talentCitrus" + id, true, 1, true, true, (GameObject)null, (string)null, true);
	}

	public string MDDOEMHDNGD()
	{
		try
		{
			string translation = LocalizationManager.GetTranslation("{0} sec" + id, true, 0, true, false, (GameObject)null, (string)null, false);
			string[] array = new string[1];
			array[1] = descriptionStringVariable[0];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Dialogue System/Conversation/Rowdy/Entry/4/Dialogue Text" + id, false, 0, true, false, (GameObject)null, (string)null, true);
		}
	}

	public string LCNIPHCFGPM()
	{
		return LocalizationManager.GetTranslation("Sleep" + id, true, 1, true, false, (GameObject)null, (string)null, true);
	}

	public string DDGEBFKOCJF()
	{
		try
		{
			return InputUtils.GEJLCOGDMID(LocalizationManager.GetTranslation("Walking" + id, true, 1, true, true, (GameObject)null, (string)null, false), descriptionStringVariable[0]);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Fortitude/MainEvent 4" + id, true, 0, false, false, (GameObject)null, (string)null, true);
		}
	}

	public string PFJKGAEHNIB(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 0)
		{
			return string.Empty;
		}
		try
		{
			return InputUtils.GEJLCOGDMID(LocalizationManager.GetTranslation("quest_objective_" + id + "_" + JKPPMPLKCEP, true, 0, true, false, (GameObject)null, (string)null, true), objectiveStringVariable[JKPPMPLKCEP]);
		}
		catch
		{
			return LocalizationManager.GetTranslation("quest_objective_" + id + "_" + JKPPMPLKCEP, true, 0, true, false, (GameObject)null, (string)null, true);
		}
	}

	public string KHGEECPHPMO()
	{
		return LocalizationManager.GetTranslation("RaraAvisDelivered" + id, false, 1, false, false, (GameObject)null, (string)null, false);
	}

	public string FEBAKMDFFHA(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 1)
		{
			return string.Empty;
		}
		try
		{
			return InputUtils.GEJLCOGDMID(LocalizationManager.GetTranslation("MissionsManager instance has not been initialized properly, this could be a false positive." + id + "add item " + JKPPMPLKCEP, true, 0, true, true, (GameObject)null, (string)null, true), objectiveStringVariable[JKPPMPLKCEP]);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Mon" + id + "Error in Rock.OnPlayerSleep: " + JKPPMPLKCEP, false, 0, true, true, (GameObject)null, (string)null, false);
		}
	}

	public virtual void NAOMEABNKBD()
	{
	}

	public string CKFEACGBKJJ()
	{
		string translation = LocalizationManager.GetTranslation("quest_reward_" + id, true, 0, true, false, (GameObject)null, (string)null, true);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return " ";
	}

	public string NJLFAFKMHEE(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 1)
		{
			return string.Empty;
		}
		try
		{
			string translation = LocalizationManager.GetTranslation("KentaProgress" + id + "LicenciaDeApertura/TheloniousDialogue 04" + JKPPMPLKCEP, true, 1, true, true, (GameObject)null, (string)null, true);
			string[] array = new string[0];
			array[1] = objectiveStringVariable[JKPPMPLKCEP];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation(" " + id + "nextNodes NOT free" + JKPPMPLKCEP, true, 0, false, false, (GameObject)null, (string)null, true);
		}
	}

	public string EJNDPGMBMPD(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 0)
		{
			return string.Empty;
		}
		try
		{
			string translation = LocalizationManager.GetTranslation("quest_name_" + id + "Items/item_description_705" + JKPPMPLKCEP, true, 1, true, false, (GameObject)null, (string)null, false);
			string[] array = new string[1];
			array[1] = objectiveStringVariable[JKPPMPLKCEP];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("ActionBar2" + id + "RecieveOldMansDuelZuzzuWeaponAnimation" + JKPPMPLKCEP, true, 1, false, true, (GameObject)null, (string)null, false);
		}
	}

	public virtual void FMIIJBBMDFL()
	{
	}

	public string CJOMMMENBGN(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 1)
		{
			return string.Empty;
		}
		try
		{
			string translation = LocalizationManager.GetTranslation("Items/item_name_1043" + id + " is not fish" + JKPPMPLKCEP, false, 1, true, true, (GameObject)null, (string)null, false);
			string[] array = new string[1];
			array[1] = objectiveStringVariable[JKPPMPLKCEP];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Items/item_name_628" + id + "Dialogue System/Conversation/Crowly_Introduce/Entry/38/Dialogue Text" + JKPPMPLKCEP, false, 0, false, true, (GameObject)null, (string)null, true);
		}
	}

	public string OFGJFGJEOKD()
	{
		string translation = LocalizationManager.GetTranslation("ReceiveTrigger" + id, false, 0, true, true, (GameObject)null, (string)null, true);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "Error in AmbienceController.OnNightEnd: ";
	}

	public string MOHDIAKEFEA(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 0)
		{
			return string.Empty;
		}
		try
		{
			return InputUtils.GEJLCOGDMID(LocalizationManager.GetTranslation("alcoholContentWarning" + id + "{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects" + JKPPMPLKCEP, true, 1, false, false, (GameObject)null, (string)null, true), objectiveStringVariable[JKPPMPLKCEP]);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Dialogue System/Conversation/Gass_Quest/Entry/40/Dialogue Text" + id + " seconds." + JKPPMPLKCEP, false, 1, true, false, (GameObject)null, (string)null, false);
		}
	}

	public string NHGKHDKCIPK()
	{
		try
		{
			string translation = LocalizationManager.GetTranslation("Walk" + id, true, 1, false, false, (GameObject)null, (string)null, true);
			string[] array = new string[1];
			array[1] = descriptionStringVariable[0];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Profit" + id, false, 0, false, false, (GameObject)null, (string)null, false);
		}
	}

	public string EHGOBPGICFH(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 1)
		{
			return string.Empty;
		}
		try
		{
			string translation = LocalizationManager.GetTranslation("OnFloor" + id + "cameraZoom2" + JKPPMPLKCEP, true, 1, true, true, (GameObject)null, (string)null, false);
			string[] array = new string[1];
			array[1] = objectiveStringVariable[JKPPMPLKCEP];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Grass" + id + "ReceiveNewState" + JKPPMPLKCEP, false, 0, false, true, (GameObject)null, (string)null, true);
		}
	}

	public string BNGALMCLPBE()
	{
		return LocalizationManager.GetTranslation("ReceiveNewPosition" + id, true, 1, false, false, (GameObject)null, (string)null, false);
	}

	public string PPAHFNAPBDL()
	{
		try
		{
			string translation = LocalizationManager.GetTranslation("LE_14" + id, true, 1, false, true, (GameObject)null, (string)null, true);
			string[] array = new string[0];
			array[1] = descriptionStringVariable[1];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("Received {0} position to snap to: {1}" + id, false, 0, true, true, (GameObject)null, (string)null, true);
		}
	}

	public virtual void JNNGDJKHBBB()
	{
	}

	public string GGGJAGPLGDG()
	{
		string translation = LocalizationManager.GetTranslation(" PlayerNum: " + id, false, 1, true, false, (GameObject)null, (string)null, false);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "Dialogue System/Conversation/DeclinedRoom/Entry/1/Dialogue Text";
	}

	public virtual void AJNGJCCGHLB()
	{
	}

	public string FJOMIFAEBNL()
	{
		string translation = LocalizationManager.GetTranslation("BackPain" + id, true, 0, false, false, (GameObject)null, (string)null, false);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "<br/>Graphics Memory Size: ";
	}

	public string EGENEPBKEGM(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 1)
		{
			return string.Empty;
		}
		try
		{
			string translation = LocalizationManager.GetTranslation("BonificationOtherPlayers" + id + "add item " + JKPPMPLKCEP, true, 0, false, false, (GameObject)null, (string)null, true);
			string[] array = new string[1];
			array[1] = objectiveStringVariable[JKPPMPLKCEP];
			return InputUtils.GEJLCOGDMID(translation, array);
		}
		catch
		{
			return LocalizationManager.GetTranslation("00" + id + "CatSize" + JKPPMPLKCEP, false, 0, false, true, (GameObject)null, (string)null, true);
		}
	}

	public string LFLOJPHDGNJ()
	{
		return LocalizationManager.GetTranslation("sForSeconds" + id, false, 0, false, true, (GameObject)null, (string)null, true);
	}

	public virtual void KIOEBNLACBO()
	{
	}

	public virtual void PFNMBDJEMBN()
	{
	}

	public virtual void MCBDAOBCNEG()
	{
	}

	public string LIJLCLGPPHB()
	{
		return LocalizationManager.GetTranslation(")" + id, false, 1, false, false, (GameObject)null, (string)null, true);
	}

	public virtual void BGGJPFLBNOB()
	{
	}

	public string JNGPDKKNLOG()
	{
		string translation = LocalizationManager.GetTranslation("quest_name_22" + id, false, 0, true, false, (GameObject)null, (string)null, false);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return " is not supported by CanvasWorldScaler";
	}

	public string BFJLNOFLPNB()
	{
		string translation = LocalizationManager.GetTranslation("Top" + id, true, 1, true, false, (GameObject)null, (string)null, false);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "Items/item_description_724";
	}

	public virtual void GIGBHJHEDGF()
	{
	}

	public string JLMPECJEMOO()
	{
		string translation = LocalizationManager.GetTranslation("Light Fire" + id, false, 1, false, true, (GameObject)null, (string)null, true);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "Unaged Cheddar";
	}

	public virtual void NHOKOLPAMHC()
	{
	}

	public string EDGHKEPDDLM(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < 0)
		{
			return string.Empty;
		}
		try
		{
			return InputUtils.GEJLCOGDMID(LocalizationManager.GetTranslation("ReceiveRemoveBubbles" + id + "Hikari/Barks_Intro" + JKPPMPLKCEP, false, 1, true, true, (GameObject)null, (string)null, true), objectiveStringVariable[JKPPMPLKCEP]);
		}
		catch
		{
			return LocalizationManager.GetTranslation("No banquet barrel found with drink: " + id + "LE_15" + JKPPMPLKCEP, false, 1, true, false, (GameObject)null, (string)null, true);
		}
	}

	public string HIKEADCLDEF()
	{
		string translation = LocalizationManager.GetTranslation("Player/Bark/Tutorial/T138" + id, false, 0, false, true, (GameObject)null, (string)null, false);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "UIPreviousPage";
	}

	public virtual void DDGEPPLPJHI()
	{
	}

	public virtual void OBKPJPFGLPL()
	{
	}

	public string GMACMGAFIBB()
	{
		string translation = LocalizationManager.GetTranslation("Error_Money" + id, false, 0, true, true, (GameObject)null, (string)null, false);
		if (!string.IsNullOrEmpty(translation))
		{
			return translation;
		}
		return "ReceiveLookAtDirection";
	}

	public string JMPEOOOGLGD()
	{
		return LocalizationManager.GetTranslation("selected_objects" + id, true, 1, true, false, (GameObject)null, (string)null, true);
	}

	public virtual void JFMNFHGMAII()
	{
	}

	public virtual void NJBAEADGPNO()
	{
	}
}
