using System;
using System.Collections.Generic;
using UnityEngine;

public class MissionsDatabaseAccessor : MonoBehaviour
{
	private static MissionsDatabaseAccessor GGFJGHHHEJC;

	[SerializeField]
	private MissionsDatabase missionsDatabaseSO;

	private Dictionary<int, MissionBase> CHLGNFBDKFI;

	private static void MIMJLNKGCBP()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		foreach (MissionBase missionBase in missions)
		{
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Start water quality test" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Reputation" + ((Object)missionBase).name));
			}
		}
	}

	private void ALEAOANPHIO()
	{
		GGFJGHHHEJC = this;
		HKMKMMHIFLO();
	}

	private static void NOLCHICHJDO()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i++)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Level {0}: {1}" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "itemOrange" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionBase[] LIJODHPJAEN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private static void NIHDCJJAOCO()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 0; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Player/Bark/Fishing/NoBait" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "GameEvent with eventType: " + ((Object)missionBase).name));
			}
		}
	}

	private void KKNHADAMLFP()
	{
		GGFJGHHHEJC = this;
		OODCADFBOHK();
	}

	public static MissionsDatabase MMMDPBELNBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FFOMKKIAHKI();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	private static void DFCAOIHNLFC()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i++)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("ReceiveTavernStatsInfo" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "HandUp" + ((Object)missionBase).name));
			}
		}
	}

	private static void HKMKMMHIFLO()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Unaged Swiss" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Player2" + ((Object)missionBase).name));
			}
		}
	}

	private void DNBGIIGAKMJ()
	{
		GGFJGHHHEJC = this;
		DFCAOIHNLFC();
	}

	public static MissionsDatabase PKKGFPGDIEP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FFOMKKIAHKI();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionBase PHFFCJBKCBO(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"kujaku");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Items/item_name_724" + JFNMCNCHMEO + "New_Recipe"));
		return null;
	}

	public static MissionBase BFIOJIDKHBD(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"InkeepersCave_Message");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("FerroProgress" + JFNMCNCHMEO + "MayaMinigames"));
		return null;
	}

	public static MissionBase[] BFHDCFCGKJF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private static void IGNFDHNFNFO()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 0; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Ignore Raycast" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Player/Bark/Tutorial/CantDoYet" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionBase[] NFNOHCJPBPP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private static void CEACHLDMNAA()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 0; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Players win!" + ((Object)missionBase).name));
			}
		}
	}

	private void BHAFCBHENPL()
	{
		GGFJGHHHEJC = this;
		IFPONMBPEDP();
	}

	public static MissionsDatabase JBMCCHOBPBE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			JDHEBHNLDLI();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionsDatabase NAGEBJIFDEM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GOBCANBKFEM();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	private static void IFPONMBPEDP()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("\n" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Player2" + ((Object)missionBase).name));
			}
		}
	}

	private void KJHKBGDJNDC()
	{
		GGFJGHHHEJC = this;
		DDACEAHJAJP();
	}

	public static MissionsDatabaseAccessor AFABPIAEKEC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void HMHCLIBLKLN()
	{
		GGFJGHHHEJC = this;
		BBAICNHHAHO();
	}

	public static MissionsDatabaseAccessor FMKKIIBMNBO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase[] OOOOLKNHOMF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionBase FDCCEDJHGON(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"ChatCommandLockDescription");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Invalid item" + JFNMCNCHMEO + "Press {0} to continue"));
		return null;
	}

	public static MissionsDatabase HDDMHALCDFA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			JDHEBHNLDLI();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionBase PHIMEKLBNGG(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"ReceiveSelectPerkLevel");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Reputation" + JFNMCNCHMEO + "Attack/MainEvent 11"));
		return null;
	}

	public static MissionsDatabase EJNAOONJJHA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GOBCANBKFEM();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionBase[] KGEFBBPEDFG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private static void EAIMFNPMNHN()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 0; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("A very important guest is visiting!" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "</color>" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionsDatabase MOGNFOGDBJB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			NNBHMCGJONC();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	private void GFLFDLIMOLI()
	{
		GGFJGHHHEJC = this;
		HKMKMMHIFLO();
	}

	private void HDHPOAPLEJC()
	{
		GGFJGHHHEJC = this;
		CEACHLDMNAA();
	}

	public static MissionBase[] CLDPMCPBCNF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionBase BNKOCDLDCCC(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)" - ");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Invalid playerNum" + JFNMCNCHMEO + "Light fuse"));
		return null;
	}

	public static MissionBase OBCFDJKOKJD(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"ReceiveExitInteraction");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("itemsCrafted" + JFNMCNCHMEO + "Items/item_description_628"));
		return null;
	}

	public static MissionBase AAOMPECKGGC(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"<color=#A87700>");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("UIVertical" + JFNMCNCHMEO + "increase money"));
		return null;
	}

	private static void EFJNIJLKNCH()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		foreach (MissionBase missionBase in missions)
		{
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Invalid year: " + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + " 2" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionsDatabaseAccessor GetInstance()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase AOBBIHKDJNE(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)(" CloseUI ConstructionUI" + JFNMCNCHMEO + "Mouse Wheel Up"));
		return null;
	}

	private void LDLBMMMLEDJ()
	{
		GGFJGHHHEJC = this;
		INGECIBELNB();
	}

	public static MissionBase[] NKHDKLCJLJO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionBase JBBLBKILIKK(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Get Components ");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("</color>" + JFNMCNCHMEO + "Up"));
		return null;
	}

	public static MissionBase[] COBOMCODABO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private void BFJOEMCBJJO()
	{
		GGFJGHHHEJC = this;
		GLGGLPGNFLM();
	}

	private static void PJAEPJKJMAG()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 0; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Customer " + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Current user name: " + ((Object)missionBase).name));
			}
		}
	}

	private void OAEJGGFFCBO()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	public static MissionBase IKAMJGKBLNE(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"UIBack");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)(". Rumble int: " + JFNMCNCHMEO + "Walk"));
		return null;
	}

	public static MissionBase[] AGHAFAIBNKD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private static void BBAICNHHAHO()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		foreach (MissionBase missionBase in missions)
		{
			if (missionBase.id == 0)
			{
				Debug.Log((object)("ReceiveUnlockedRecipeMaster" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Random" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionBase[] PGFMNMGBOPN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionsDatabaseAccessor EBPNKOMGCPB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase[] ADPJDKGBPAB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private static void OODCADFBOHK()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i++)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("End" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Upgrade Tavern" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionBase[] EMPGJFKLFPI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionsDatabaseAccessor FJBAFMJHBCO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionsDatabase LLLOBGCEBKE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FMKKIIBMNBO();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionBase LANFKIPJOBJ(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"ReciveActivateCustomers");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Autumn" + JFNMCNCHMEO + "<br/>Graphics Device Type: "));
		return null;
	}

	public static MissionBase BMBCKOMOCBB(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Shield");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("\"" + JFNMCNCHMEO + "/ExtraSettings.sd"));
		return null;
	}

	private static void CKMADJFIODH()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 0; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("ReceiveAddMoney" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Error in StaffManager.StaffInstantGoHome: " + ((Object)missionBase).name));
			}
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	public static MissionBase[] FADGHKHPKKE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionsDatabase NEEOHPEODGF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GOBCANBKFEM();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	private void CLGBFOIBANN()
	{
		GGFJGHHHEJC = this;
		DDACEAHJAJP();
	}

	public static MissionsDatabaseAccessor KIKCLAICGBH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase IIGFBPHMHKH(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"xpModDescFarming");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("LE_10" + JFNMCNCHMEO + "\n"));
		return null;
	}

	public static MissionBase[] DOIFPLAFLCP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionBase PJMFLAKNEFO(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Masters/Klayn/Banquet");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Hikari/Introduce" + JFNMCNCHMEO + "_"));
		return null;
	}

	public static MissionBase[] GKHGLGCGGJO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionBase[] ENHCPGEDNEM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private void PNLAJCHBHPH()
	{
		GGFJGHHHEJC = this;
		IGNFDHNFNFO();
	}

	private void GANBBAGDALD()
	{
		GGFJGHHHEJC = this;
		NOLCHICHJDO();
	}

	public static MissionBase GetMission(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"MissionsDatabaseAccessor instance is null. Make sure it is initialized before calling this method.");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Mission with id " + JFNMCNCHMEO + " not found"));
		return null;
	}

	public static MissionBase MNHDCNOEPME(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Eating" + JFNMCNCHMEO + "CraftedIn"));
		return null;
	}

	private void OOIHNJHMBMC()
	{
		GGFJGHHHEJC = this;
		CEACHLDMNAA();
	}

	private void KGIKOECKEHI()
	{
		GGFJGHHHEJC = this;
		IFPONMBPEDP();
	}

	private void KHCJDKHONPK()
	{
		GGFJGHHHEJC = this;
		FMKANEPMJFE();
	}

	public static MissionsDatabase LIKGHEFHHFP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			AFABPIAEKEC();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	private static void FADHDDLJFLD()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("ReceiveInventoryToChest" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Dialogue System/Conversation/Gass_Quest/Entry/37/Dialogue Text" + ((Object)missionBase).name));
			}
		}
	}

	private void ENGCLKEINDH()
	{
		GGFJGHHHEJC = this;
		GLGGLPGNFLM();
	}

	private void GOFJCKGJHJO()
	{
		GGFJGHHHEJC = this;
		BBAICNHHAHO();
	}

	private static void DMNENKNLDAH()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		foreach (MissionBase missionBase in missions)
		{
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Mission without ID: " + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)missionBase).name));
			}
		}
	}

	public static MissionsDatabaseAccessor JDHEBHNLDLI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private static void DDACEAHJAJP()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 0; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("TorchPuzzle requires TorchPuzzleSettings" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + ": " + ((Object)missionBase).name));
			}
		}
	}

	private static void AMKMAPJALIC()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		foreach (MissionBase missionBase in missions)
		{
			if (missionBase.id == 0)
			{
				Debug.Log((object)("/Localisation.txt" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "itemPepperoni" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionBase JKLECDPNOCA(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Piso {0}: Generando {1} rocas en {2} spawners disponibles.");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Stack" + JFNMCNCHMEO + "FocusedActionBar"));
		return null;
	}

	private static void FMKANEPMJFE()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 0; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Trough" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "popUpBuilding23" + ((Object)missionBase).name));
			}
		}
	}

	private static void INGECIBELNB()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)(", " + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "<size=" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionBase EJPACLKCCON(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Sell" + JFNMCNCHMEO + "UIBack"));
		return null;
	}

	public static MissionsDatabase PMKLDJEDLGN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			MGAIDIDBIBB();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionsDatabase AKMLJPHFINL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FMKKIIBMNBO();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionsDatabase CINGDHPOEPF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			KIKCLAICGBH();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionsDatabase LJIJKBGJMEG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			NIIKFOMKOEJ();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	private void KLMNLEDKEOE()
	{
		GGFJGHHHEJC = this;
		BBAICNHHAHO();
	}

	public static MissionsDatabaseAccessor NNBHMCGJONC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase[] PINENIPOLBN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private void GONDLJKGLGO()
	{
		GGFJGHHHEJC = this;
		NIHDCJJAOCO();
	}

	public static MissionsDatabase MNHALNDJHDC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FFOMKKIAHKI();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionsDatabaseAccessor NIIKFOMKOEJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase[] OJJBMNLHLAN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionBase MFFGKHKJFPA(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)" ");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Happy" + JFNMCNCHMEO + "TabernaClausurada/MaiDialogue 02"));
		return null;
	}

	public static MissionBase[] AAIHDILOIPK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionsDatabase FCHHPKFOJPF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			EBPNKOMGCPB();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionBase[] IGOIFFPIBNP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionsDatabaseAccessor KOJHKCGIINL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void OIOLGAOPECC()
	{
		GGFJGHHHEJC = this;
		EFJNIJLKNCH();
	}

	private static void GLGGLPGNFLM()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i += 0)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("[" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + " - " + ((Object)missionBase).name));
			}
		}
	}

	public static MissionsDatabaseAccessor FFOMKKIAHKI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase CGCJKKMJOCA(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Club");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Error_Nails" + JFNMCNCHMEO + "City/Carpenters/Oak/Smoking"));
		return null;
	}

	public static MissionsDatabaseAccessor MGAIDIDBIBB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase LKOIGMFNMBK(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"subject");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Direction" + JFNMCNCHMEO + "]"));
		return null;
	}

	public static MissionBase[] GetAllMissions()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionsDatabaseAccessor DMHFCKCGLAF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase[] CDMKJOGIAKI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private void PBDNKBPBCHM()
	{
		GGFJGHHHEJC = this;
		NOLCHICHJDO();
	}

	public static MissionsDatabaseAccessor GOBCANBKFEM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase ICIIJHFHGCH(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Close");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("increase money" + JFNMCNCHMEO + ")"));
		return null;
	}

	public static MissionsDatabase GetDatabase()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionsDatabaseAccessor PGJJCELOJNC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionBase[] OLDPLHBEDDL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionsDatabaseAccessor CMBAAHFGOAM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionsDatabaseAccessor EIEIHPHBJKB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<MissionsDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static MissionsDatabase PKNHFOMOEFK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			NIIKFOMKOEJ();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	private void EFCNKPEPELL()
	{
		GGFJGHHHEJC = this;
		CKMADJFIODH();
	}

	public static MissionBase HLGBPNAPMNF(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Player");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("SceneReferences Awake" + JFNMCNCHMEO + " - "));
		return null;
	}

	public static MissionBase DOFHABNKOJK(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Error in CatNPC.TeleToBed: ");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Tutorial/T107/Dialogue2" + JFNMCNCHMEO + "Sleep"));
		return null;
	}

	private void AMNCIAEMBFO()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	private static void PICJEBKCGHG()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		foreach (MissionBase missionBase in missions)
		{
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Destroying tree at same position: " + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "ReceiveToggleOpenBarnAccepted" + ((Object)missionBase).name));
			}
		}
	}

	public static MissionsDatabase PMCDHMCJIBA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FFOMKKIAHKI();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionBase[] OBBJDCFOJCA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private void JJJCKMOBLNN()
	{
		GGFJGHHHEJC = this;
		DDACEAHJAJP();
	}

	private void LHABENPEMPB()
	{
		GGFJGHHHEJC = this;
		OODCADFBOHK();
	}

	public static MissionBase EOGILBJHCOO(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Low");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("" + JFNMCNCHMEO + "mForMins"));
		return null;
	}

	public static MissionBase[] OLONEKOKJMO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private void FBHHPNJGNJG()
	{
		GGFJGHHHEJC = this;
		BBAICNHHAHO();
	}

	public static MissionBase AAOPEALLACK(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"%><sprite name=");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Ground" + JFNMCNCHMEO + "Items/item_description_1078"));
		return null;
	}

	private static void EHPHAJHIOGA()
	{
		GGFJGHHHEJC.CHLGNFBDKFI = new Dictionary<int, MissionBase>();
		MissionBase[] missions = GGFJGHHHEJC.missionsDatabaseSO.missions;
		for (int i = 1; i < missions.Length; i++)
		{
			MissionBase missionBase = missions[i];
			if (missionBase.id == 0)
			{
				Debug.Log((object)("Style" + ((Object)missionBase).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.CHLGNFBDKFI.Add(missionBase.id, missionBase);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + ":</color> " + ((Object)missionBase).name));
			}
		}
	}

	public static MissionBase HEEGFGBKHHK(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Player2");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Pool Parent " + JFNMCNCHMEO + "Invalid playerNum"));
		return null;
	}

	private void FALNOOOKLGA()
	{
		GGFJGHHHEJC = this;
		OODCADFBOHK();
	}

	public static MissionsDatabase CEMEBAOGKFD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			EBPNKOMGCPB();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}

	public static MissionBase[] DBFBBLJHGCO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	public static MissionBase DJAPDAKEDBA(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"Invalid year: ");
			return null;
		}
		if (GGFJGHHHEJC.CHLGNFBDKFI.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.CHLGNFBDKFI[JFNMCNCHMEO];
		}
		Debug.LogError((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/19/Dialogue Text" + JFNMCNCHMEO + "ReceiveCleanSprites"));
		return null;
	}

	private void DIMAPDNCBAN()
	{
		GGFJGHHHEJC = this;
		PICJEBKCGHG();
	}

	public static MissionBase[] POGLDKGEMMH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		return GGFJGHHHEJC.missionsDatabaseSO.missions;
	}

	private void INHBDHMJHEB()
	{
		GGFJGHHHEJC = this;
		DFCAOIHNLFC();
	}

	public static MissionsDatabase MCEIOAEFHFB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FJBAFMJHBCO();
		}
		return GGFJGHHHEJC.missionsDatabaseSO;
	}
}
