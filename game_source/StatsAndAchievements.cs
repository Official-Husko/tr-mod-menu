using Galaxy.Api;
using UnityEngine;

public class StatsAndAchievements : MonoBehaviour
{
	private class FGDLLCLFDAC : GlobalUserStatsAndAchievementsRetrieveListener
	{
		public bool retrieved;

		public override void OnUserStatsAndAchievementsRetrieveSuccess(GalaxyID IKLBKLMFOAO)
		{
			retrieved = true;
			GalaxyManager.Instance.StatsAndAchievements.SetAchievement("launchTheGame");
			Debug.Log((object)("User " + ((object)IKLBKLMFOAO)?.ToString() + " stats and achievements retrieved"));
		}

		public override void OnUserStatsAndAchievementsRetrieveFailure(GalaxyID IKLBKLMFOAO, FailureReason OHLDLBCPHMJ)
		{
			retrieved = false;
			Debug.LogWarning((object)("User " + ((object)IKLBKLMFOAO)?.ToString() + " stats and achievements could not be retrieved, for reason " + ((object)(FailureReason)(ref OHLDLBCPHMJ)).ToString()));
		}
	}

	private class EOGCFABAFIP : GlobalStatsAndAchievementsStoreListener
	{
		public override void OnUserStatsAndAchievementsStoreFailure(FailureReason OHLDLBCPHMJ)
		{
			Debug.LogWarning((object)("OnUserStatsAndAchievementsStoreFailure: " + ((object)(FailureReason)(ref OHLDLBCPHMJ)).ToString()));
		}

		public override void OnUserStatsAndAchievementsStoreSuccess()
		{
		}
	}

	private class BMOBLIHDPBG : GlobalAchievementChangeListener
	{
		public override void OnAchievementUnlocked(string GEGDHHIDEEF)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Achievement \"" + GEGDHHIDEEF + "\" unlocked"));
			}
		}
	}

	private FGDLLCLFDAC ILNHCCMBGHM;

	private BMOBLIHDPBG ADGBMKPFECD;

	private EOGCFABAFIP AEKHOGJDONA;

	private void HIFDFFEJNEH()
	{
		BPIBMEEHADI();
	}

	public int KEPLFGIJGIG(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Room code received from steam is not valid: " + DCCBGCHNHIK + "ReceiveSitDown" + (object)val));
		}
		return result;
	}

	public void SetAchievement(string DCCBGCHNHIK)
	{
		//IL_0018: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetAchievement(DCCBGCHNHIK);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Achievement " + DCCBGCHNHIK + " could not be unlocked for reason: " + (object)val));
		}
	}

	public bool DPAJCKEDFHJ(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = true;
		try
		{
			uint num = 0u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Tail" + DCCBGCHNHIK + "Bob" + (object)val));
		}
		return result;
	}

	public void GKKPOHGIEOA(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("ReceiveSitDown" + DCCBGCHNHIK + "ReceiveFarmConstructionDeactivated" + (object)val));
		}
	}

	public void HAIHNGCLJBI()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("RPC Receive Reset All Talents From Other " + (object)val));
		}
	}

	private void MIGKLADBLGC()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public void BCLEHLKFCPG(string DCCBGCHNHIK)
	{
		//IL_0018: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetAchievement(DCCBGCHNHIK);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Dialogue System/Conversation/TavernClean/Entry/6/Dialogue Text" + DCCBGCHNHIK + "add item " + (object)val));
		}
	}

	public string JNJCKJPCMHH(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = " ";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Entra a dar Mision" + DCCBGCHNHIK + "Low" + (object)val));
		}
		return result;
	}

	public string DFKMAAKLMKK(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "Dialogue System/Conversation/BirdCatInteraction/Entry/4/Dialogue Text";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("ReceiveAtAvoidingWorkPointRPC" + DCCBGCHNHIK + "bob" + (object)val));
		}
		return result;
	}

	private void CKKPEJGBDKK()
	{
		MIGKLADBLGC();
	}

	private void NPFEJCEOIDA()
	{
		if (ILNHCCMBGHM == null)
		{
			ILNHCCMBGHM = new FGDLLCLFDAC();
		}
		if (ADGBMKPFECD == null)
		{
			ADGBMKPFECD = new BMOBLIHDPBG();
		}
		if (AEKHOGJDONA == null)
		{
			AEKHOGJDONA = new EOGCFABAFIP();
		}
	}

	public string FHFDPEPOEBJ(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "Not ready to join room";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("cForCalendar" + DCCBGCHNHIK + "Intro15" + (object)val));
		}
		return result;
	}

	private void EKJHKFAMGBC()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public void HJECFEDFEKL(string DCCBGCHNHIK)
	{
		//IL_0018: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetAchievement(DCCBGCHNHIK);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("itemPaperCoaster" + DCCBGCHNHIK + "Items/item_name_668" + (object)val));
		}
	}

	public string MHLMOBPGPIA(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "Eyes";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("New Milestone" + DCCBGCHNHIK + "BuzzCanBuild" + (object)val));
		}
		return result;
	}

	private void ECHHHBBHNLF()
	{
		LPNMMHOFKMH();
	}

	private void OJJEONJKHPO()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	private void CACPOGPOKOJ()
	{
		BPIBMEEHADI();
	}

	public void BKMCMHMLLLP(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Item with ID=" + DCCBGCHNHIK + "Focused" + (object)val));
		}
	}

	public bool BHNAAHHHAIN(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 1u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Serve" + DCCBGCHNHIK + "questNameFarming" + (object)val));
		}
		return result;
	}

	public void IBCIKPMNMPG(string DCCBGCHNHIK, int EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatInt(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Player" + DCCBGCHNHIK + "Disabled" + (object)val));
		}
	}

	public void SetStatInt(string DCCBGCHNHIK, int EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatInt(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not set value of statistic " + DCCBGCHNHIK + " for reason: " + (object)val));
		}
	}

	public void OBKHAJCMOOH()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Items/item_name_613" + (object)val));
		}
	}

	public void RequestUserStatsAndAchievements()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Achievements definitions could not be retrived for reason: " + (object)val));
		}
	}

	public int OBDIHGEILFD(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Destroying dropped item..." + DCCBGCHNHIK + "descGrog" + (object)val));
		}
		return result;
	}

	public int CDJEDKIELDH(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("/" + DCCBGCHNHIK + "Start" + (object)val));
		}
		return result;
	}

	public int JCHEKAEDDGO(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)(")" + DCCBGCHNHIK + "." + (object)val));
		}
		return result;
	}

	public bool FDGGDPIHMEH(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 0u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Occupied Positions" + DCCBGCHNHIK + "Angry" + (object)val));
		}
		return result;
	}

	public void NMEIMNHFHPO(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Explosion" + DCCBGCHNHIK + "Tutorial/T100/Dialogue3" + (object)val));
		}
	}

	public void ILLGMEGLLGC()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("ObjectHorizontalMove" + (object)val));
		}
	}

	private void JKFDONKHFBD()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public void GMAADCEHILB()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Ratio pantalla: " + (object)val));
		}
	}

	private void NELLIBBABJD()
	{
		OLFICKKMKFH();
	}

	private void JAKILILIBIM()
	{
		OLFICKKMKFH();
	}

	public float GCIDKGHPNGF(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 1747f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Farm/Buzz/Door_Bark_Searching" + DCCBGCHNHIK + "Press {0} to continue" + (object)val));
		}
		return result;
	}

	public void FOKMAKLDJIO()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("MainProgress" + (object)val));
		}
	}

	public void EGOPEJIHFME(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Moving" + DCCBGCHNHIK + "ZoneProductionBonus" + (object)val));
		}
	}

	public int IGAILBBBIAI(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("ReceiveDialogueInfo" + DCCBGCHNHIK + "ThemeTypeLabelBlueprint" + (object)val));
		}
		return result;
	}

	public bool IIKAOAMMMCG(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 0u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("ReceiveCastleFormStartLucenEvent" + DCCBGCHNHIK + "Zones" + (object)val));
		}
		return result;
	}

	public void NEILHGAJPBB(string DCCBGCHNHIK)
	{
		//IL_0018: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetAchievement(DCCBGCHNHIK);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Rummage" + DCCBGCHNHIK + "Dialogue System/Conversation/Crowly_Standar/Entry/28/Dialogue Text" + (object)val));
		}
	}

	public float PPMPHAJPAPL(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 718f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Items/item_name_724" + DCCBGCHNHIK + "Chest" + (object)val));
		}
		return result;
	}

	public int EJAIIFALKAL(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("MineFloor" + DCCBGCHNHIK + "]" + (object)val));
		}
		return result;
	}

	private void IHJNCGFNDJK()
	{
		if (ILNHCCMBGHM == null)
		{
			ILNHCCMBGHM = new FGDLLCLFDAC();
		}
		if (ADGBMKPFECD == null)
		{
			ADGBMKPFECD = new BMOBLIHDPBG();
		}
		if (AEKHOGJDONA == null)
		{
			AEKHOGJDONA = new EOGCFABAFIP();
		}
	}

	public void DLGHGCDGFHB(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("ErrorJoinRoomDoesNotExist" + DCCBGCHNHIK + " downloaded, written with name " + (object)val));
		}
	}

	private void LEDDEJEHILK()
	{
		if (ILNHCCMBGHM == null)
		{
			ILNHCCMBGHM = new FGDLLCLFDAC();
		}
		if (ADGBMKPFECD == null)
		{
			ADGBMKPFECD = new BMOBLIHDPBG();
		}
		if (AEKHOGJDONA == null)
		{
			AEKHOGJDONA = new EOGCFABAFIP();
		}
	}

	private void GAIDKMLNHHL()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public bool GetAchievement(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 0u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not get status of achievement " + DCCBGCHNHIK + " for reason: " + (object)val));
		}
		return result;
	}

	public float EJMOKIGJOKH(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 1086f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("BirdInteract" + DCCBGCHNHIK + "Sleep" + (object)val));
		}
		return result;
	}

	public float DHGAIDDIHDF(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 517f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Items/item_description_1121" + DCCBGCHNHIK + "questDescMalting" + (object)val));
		}
		return result;
	}

	public void FNPEBCEDKFE(string DCCBGCHNHIK, int EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatInt(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("TermasInterior/Kenta/Intro" + DCCBGCHNHIK + "  fallingChest:       " + (object)val));
		}
	}

	public bool JGFGIEKIOLN(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = true;
		try
		{
			uint num = 1u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Mussel parent not found!!. Parent unique ID: " + DCCBGCHNHIK + "Received PlaceableMsg of another type not BirdMessage to " + (object)val));
		}
		return result;
	}

	public bool LJOEBAAABBP(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 1u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Inventory" + DCCBGCHNHIK + "Items/item_name_628" + (object)val));
		}
		return result;
	}

	private void BLLIKFLFIDI()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public void IMNJHBLJDFC()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Employee" + (object)val));
		}
	}

	public string OBCFKFDPJJK(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "Desactivado: ";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("================== Activate Variants Piece: ({0}-{1}/{2}) =======================" + DCCBGCHNHIK + "Correo Enviado. Tiempo: " + (object)val));
		}
		return result;
	}

	public void COPOONIJBKJ()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("</color>" + (object)val));
		}
	}

	public string DGIJABPHLCI(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "SelectPlaceableIfIsPossibleMaster";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Rotate Placeable" + DCCBGCHNHIK + "ReceiveInfoTerrain" + (object)val));
		}
		return result;
	}

	public float GetStatFloat(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 0f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not get value of statistic " + DCCBGCHNHIK + " for reason: " + (object)val));
		}
		return result;
	}

	public bool IHIFLPBDAMC(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 1u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("UI" + DCCBGCHNHIK + "" + (object)val));
		}
		return result;
	}

	private void KPAMNICLKCG()
	{
		if (ILNHCCMBGHM == null)
		{
			ILNHCCMBGHM = new FGDLLCLFDAC();
		}
		if (ADGBMKPFECD == null)
		{
			ADGBMKPFECD = new BMOBLIHDPBG();
		}
		if (AEKHOGJDONA == null)
		{
			AEKHOGJDONA = new EOGCFABAFIP();
		}
	}

	public string IHHJDCNKGKH(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = ")";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)(" / H: " + DCCBGCHNHIK + "itemWheatWort" + (object)val));
		}
		return result;
	}

	private void OLFICKKMKFH()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public float GFIGELKLGLO(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 1637f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Example Method With Custom ID" + DCCBGCHNHIK + "ReceiveDoneLoading" + (object)val));
		}
		return result;
	}

	public string FJKBPHCOIPL(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "Dialogue System/Conversation/Gass_Introduce/Entry/23/Dialogue Text";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Player/Bark/Tutorial/T101" + DCCBGCHNHIK + "Pull beer" + (object)val));
		}
		return result;
	}

	public int DKEBPCFBEMH(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Jose D" + DCCBGCHNHIK + "MineShopDatabase: No config found for level " + (object)val));
		}
		return result;
	}

	public float BKGKOCOGJGD(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 958f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Items/item_description_607" + DCCBGCHNHIK + "https://discord.gg/7rBtuZb" + (object)val));
		}
		return result;
	}

	public bool BFNJHOPLJOC(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 1u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("]" + DCCBGCHNHIK + "Dialogue System/Conversation/EnterTavernNeutral/Entry/1/Dialogue Text" + (object)val));
		}
		return result;
	}

	private void ODBKBMCMFNB()
	{
		BLLIKFLFIDI();
	}

	private void DGADMHMAJJP()
	{
		if (ILNHCCMBGHM == null)
		{
			ILNHCCMBGHM = new FGDLLCLFDAC();
		}
		if (ADGBMKPFECD == null)
		{
			ADGBMKPFECD = new BMOBLIHDPBG();
		}
		if (AEKHOGJDONA == null)
		{
			AEKHOGJDONA = new EOGCFABAFIP();
		}
	}

	private void LPNMMHOFKMH()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public void ODOHOGBFMKH(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("OnConversationStarted " + DCCBGCHNHIK + "" + (object)val));
		}
	}

	private void ABJIPFAEENG()
	{
		LEDDEJEHILK();
		FOKMAKLDJIO();
	}

	public void NFPICLKNFKE()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("On Simple Event " + (object)val));
		}
	}

	public int GetStatInt(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 0;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not get value of statistic " + DCCBGCHNHIK + " for reason: " + (object)val));
		}
		return result;
	}

	private void ADEBBJOALDN()
	{
		GAIDKMLNHHL();
	}

	private void POFIEEODEJO()
	{
		NPFEJCEOIDA();
		LGCLAGPLCEH();
	}

	public int KLPAKJKNNNK(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Error_StairsAreBlocking" + DCCBGCHNHIK + "SalonDelTrono/LucenTalk" + (object)val));
		}
		return result;
	}

	public string LCMIDHNNEAN(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "Ingredient";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Items/item_description_1044" + DCCBGCHNHIK + "Pirates/Brook/Stand" + (object)val));
		}
		return result;
	}

	public void KPCJCIENDOE()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Items/item_name_1110" + (object)val));
		}
	}

	public void CDIHNFMEMFB()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("itemWhiteGrapeMust" + (object)val));
		}
	}

	public void ResetStatsAndAchievements()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not get reset user stats and achievements for reason: " + (object)val));
		}
	}

	public void JBKDHDGOFPB(string DCCBGCHNHIK)
	{
		//IL_0018: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetAchievement(DCCBGCHNHIK);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("LE_10" + DCCBGCHNHIK + "\n" + (object)val));
		}
	}

	public int CKAHIDIHJDB(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Return" + DCCBGCHNHIK + "OrderDelivered" + (object)val));
		}
		return result;
	}

	public void SetStatFloat(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not set value of statistic " + DCCBGCHNHIK + " for reason: " + (object)val));
		}
	}

	public bool DMDJAHAOEIM(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = true;
		try
		{
			uint num = 0u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("travelling time -" + DCCBGCHNHIK + "Items/item_description_1049" + (object)val));
		}
		return result;
	}

	public void OGGGDNJGEKO(string DCCBGCHNHIK, int EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatInt(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("caveinn" + DCCBGCHNHIK + "veggieDishes" + (object)val));
		}
	}

	public void OHMEFKBKNLO()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Till" + (object)val));
		}
	}

	private void KIGPLPELFKP()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public int JEJMOEGMAJH(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 0;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("ReceiveActivateEatGameObjects" + DCCBGCHNHIK + "Hoppy" + (object)val));
		}
		return result;
	}

	public void LGCLAGPLCEH()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("DisableRightExterior" + (object)val));
		}
	}

	public float KLMONMAMGDP(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 1534f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("tutorial" + DCCBGCHNHIK + "CurrentSegmentSection" + (object)val));
		}
		return result;
	}

	private void NLOHEIIMLPA()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public string LAOJGBDBKAH(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "LE_4";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("_Keybind_" + DCCBGCHNHIK + "OpenConsole" + (object)val));
		}
		return result;
	}

	public void GDBNHMJCCLL(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("</color>" + DCCBGCHNHIK + "<br/>Graphics Shader Level: " + (object)val));
		}
	}

	public string GetAchievementName(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not get name of achievement " + DCCBGCHNHIK + " for reason: " + (object)val));
		}
		return result;
	}

	public float BJAGJEOLAEM(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		float result = 646f;
		try
		{
			result = GalaxyInstance.Stats().GetStatFloat(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not find local player for the online player with the assigned bed: {0}" + DCCBGCHNHIK + "City/Kujaku/Introduce" + (object)val));
		}
		return result;
	}

	public bool MFCDMLPFLBA(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 0u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Items/item_name_1127" + DCCBGCHNHIK + "SetNPCParent" + (object)val));
		}
		return result;
	}

	private void KJJAGKNOFIG()
	{
		JKFDONKHFBD();
	}

	public void CKPCFINILKC(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("DontWalk" + DCCBGCHNHIK + "" + (object)val));
		}
	}

	public void OBJOJEHMMCD()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().ResetStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Player2" + (object)val));
		}
	}

	public void BCCNGDLEAAI(string DCCBGCHNHIK, int EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatInt(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not get SharedFileID for file " + DCCBGCHNHIK + "CheckArea" + (object)val));
		}
	}

	private void HKAMIGHHDEJ()
	{
		KIGPLPELFKP();
	}

	public int PGHDBCHDHIJ(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 0;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Statue0={0} | " + DCCBGCHNHIK + "Private Example Method" + (object)val));
		}
		return result;
	}

	public void HALAPFILLNP(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Player/Bark/RentRoom/NoRooms" + DCCBGCHNHIK + "ReceiveEmployeeWorking" + (object)val));
		}
	}

	private void OnDisable()
	{
		BPIBMEEHADI();
	}

	private void HJKONJICGML()
	{
		NPFEJCEOIDA();
		RequestUserStatsAndAchievements();
	}

	public int AEEJKCFKPGH(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 0;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)(" world door: " + DCCBGCHNHIK + "Items/item_name_1044" + (object)val));
		}
		return result;
	}

	public string GFAEMCFNOII(string DCCBGCHNHIK)
	{
		//IL_0015: Expected O, but got Unknown
		string result = "startPolling";
		try
		{
			result = GalaxyInstance.Stats().GetAchievementDisplayName(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("BombShopDisable" + DCCBGCHNHIK + "Items/item_description_1093" + (object)val));
		}
		return result;
	}

	public void IGMNIHAFJHJ(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Dialogue System/Conversation/Gass_Quest/Entry/45/Dialogue Text" + DCCBGCHNHIK + "Game" + (object)val));
		}
	}

	public bool AICJGFIKIEC(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = false;
		try
		{
			uint num = 1u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("nextNodes NOT free. timer: " + DCCBGCHNHIK + "Partida comprimida. Tiempo: " + (object)val));
		}
		return result;
	}

	public void MMHPPPPAMJK(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Dialogue System/Conversation/TavernFilthy/Entry/1/Dialogue Text" + DCCBGCHNHIK + "NormalRightExterior" + (object)val));
		}
	}

	public void EDDBJHOIDEF()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("houseKeeperWage" + (object)val));
		}
	}

	public void GFMPGMPOOHC()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("LoopVolume" + (object)val));
		}
	}

	public bool LOCKBJDBMHI(string DCCBGCHNHIK)
	{
		//IL_0016: Expected O, but got Unknown
		bool result = true;
		try
		{
			uint num = 1u;
			GalaxyInstance.Stats().GetAchievement(DCCBGCHNHIK, ref result, ref num);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("particleSystem not attached to " + DCCBGCHNHIK + "MineSymbolPuzzle requires SymbolPuzzleSettings" + (object)val));
		}
		return result;
	}

	private void BPIBMEEHADI()
	{
		if (ILNHCCMBGHM != null)
		{
			((IGalaxyListener)ILNHCCMBGHM).Dispose();
		}
		if (ADGBMKPFECD != null)
		{
			((IGalaxyListener)ADGBMKPFECD).Dispose();
		}
		if (AEKHOGJDONA != null)
		{
			((IGalaxyListener)AEKHOGJDONA).Dispose();
		}
	}

	public void FCKFDCFFCBO(string DCCBGCHNHIK, int EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatInt(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("buildingObjective_14_0" + DCCBGCHNHIK + "Item " + (object)val));
		}
	}

	private void OnEnable()
	{
		IHJNCGFNDJK();
		RequestUserStatsAndAchievements();
	}

	public int LMLALKBHEAN(string DCCBGCHNHIK)
	{
		//IL_0011: Expected O, but got Unknown
		int result = 1;
		try
		{
			result = GalaxyInstance.Stats().GetStatInt(DCCBGCHNHIK);
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("PirateMinigame/Minigame" + DCCBGCHNHIK + "" + (object)val));
		}
		return result;
	}

	public void DFLPDABAPCL()
	{
		//IL_000d: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().RequestUserStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Spice" + (object)val));
		}
	}

	public void LGFIMOHCCDJ(string DCCBGCHNHIK, float EMOHEOJJPNE)
	{
		//IL_0019: Expected O, but got Unknown
		try
		{
			GalaxyInstance.Stats().SetStatFloat(DCCBGCHNHIK, EMOHEOJJPNE);
			GalaxyInstance.Stats().StoreStatsAndAchievements();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("HarvestCut2" + DCCBGCHNHIK + "Items/item_description_595" + (object)val));
		}
	}

	private void HFIHGHBLLAM()
	{
		NPFEJCEOIDA();
		GFMPGMPOOHC();
	}
}
