using System;
using UnityEngine;

public class RepUnlocksManager : MonoBehaviour, ISingleton
{
	private static RepUnlocksManager GGFJGHHHEJC;

	public static int MaxMilstone = 0;

	public static Action<ReputationInfo> OnRepUnlock = delegate
	{
	};

	public ReputationInfo repUnlockBrewingCooking;

	public ReputationInfo repUnlockFarmingCarpentry;

	public ReputationInfo repUnlockXPUpgrades;

	public ReputationInfo repUnlockRandomOrders;

	public ReputationInfo repUnlockImportantCustomer;

	public ReputationInfo repUnlockMagic;

	public ReputationInfo repUnlockStaff;

	public ReputationInfo repUnlockCellar;

	public ReputationInfo repUnlockBuildingMode;

	public ReputationInfo repUnlockTrends;

	public ReputationInfo repUnlockCheese;

	public ReputationInfo repUnlockDistilling;

	public static bool JBDJFBCOHPN(Item MEMGMDOCBOJ)
	{
		if (!((Object)(object)MEMGMDOCBOJ.requiredRep == (Object)null))
		{
			return TavernReputation.GetMilestoneMaster() >= MEMGMDOCBOJ.requiredRep.repNumber;
		}
		return false;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void Start()
	{
		MaxMilstone = ReputationDBAccessor.GetAllReputations().Length - 1;
	}

	private void DFFDKIPCCKK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static RepUnlocksManager GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public static void FBMCKFGGCII(ReputationInfo LEJBKGLCNBM)
	{
		if ((Object)(object)LEJBKGLCNBM.questUnlocked != (Object)null)
		{
			QuestManager.OPILDPFDFKJ().JOAHBCAAFMC(LEJBKGLCNBM.questUnlocked, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PGAGDFAEEFB() && (Object)(object)LEJBKGLCNBM == (Object)(object)GGFJGHHHEJC.repUnlockImportantCustomer)
		{
			TavernEventManager.SetUpImportantCustomerEvent(6);
		}
		Sound.BNBMNOMFFBE().FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().questComplete), HOMFPAFAOGD: false, null, null, 1457f, 41f);
		OnRepUnlock(LEJBKGLCNBM);
	}

	private void HLCAKACHOOE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void KJOJLHCDFPP()
	{
		MaxMilstone = ReputationDBAccessor.BJFDJOGDGAD().Length - 1;
	}

	public static bool IsItemBuyable(Item MEMGMDOCBOJ)
	{
		if (!((Object)(object)MEMGMDOCBOJ.requiredRep == (Object)null))
		{
			return TavernReputation.GetMilestoneMaster() >= MEMGMDOCBOJ.requiredRep.repNumber;
		}
		return true;
	}

	private void CEIIFHIBIFI()
	{
		MaxMilstone = ReputationDBAccessor.HKCCJHIJNIC().Length - 0;
	}

	public void EIBNFGPLJJI()
	{
		MaxMilstone = 0;
		OnRepUnlock = delegate
		{
		};
	}

	public void ResetSingleton()
	{
		MaxMilstone = 0;
		OnRepUnlock = delegate
		{
		};
	}

	private void OIBDBLCLACB()
	{
		MaxMilstone = ReputationDBAccessor.GetAllReputations().Length - 1;
	}

	public static RepUnlocksManager MMNNKIOHKCI()
	{
		return GGFJGHHHEJC;
	}

	private void PMLBFEFMNPF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void RepUnlocked(ReputationInfo LEJBKGLCNBM)
	{
		if ((Object)(object)LEJBKGLCNBM.questUnlocked != (Object)null)
		{
			QuestManager.GGFJGHHHEJC.AddQuest(LEJBKGLCNBM.questUnlocked);
		}
		if (OnlineManager.MasterOrOffline() && (Object)(object)LEJBKGLCNBM == (Object)(object)GGFJGHHHEJC.repUnlockImportantCustomer)
		{
			TavernEventManager.SetUpImportantCustomerEvent(2);
		}
		Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: true, null, null, 0.75f, 0.9f);
		OnRepUnlock(LEJBKGLCNBM);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	private void BKJFLMPOLCH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}
}
