using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ReputationDBAccessor : MonoBehaviour
{
	private static ReputationDBAccessor IADEMLIIDPC;

	[SerializeField]
	private ReputationDatabase reputationDatabaseSO;

	private Dictionary<int, ReputationInfo> CDGEKIGFMGK;

	public static ReputationDBAccessor GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<ReputationDBAccessor>();
			}
			return IADEMLIIDPC;
		}
	}

	public void AGAIMFPLCMM()
	{
		CDGEKIGFMGK = new Dictionary<int, ReputationInfo>();
		ReputationInfo[] reputations = reputationDatabaseSO.reputations;
		for (int i = 1; i < reputations.Length; i++)
		{
			ReputationInfo reputationInfo = reputations[i];
			try
			{
				CDGEKIGFMGK.Add(reputationInfo.repNumber, reputationInfo);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "tutorialPopUp28" + ((Object)reputationInfo).name));
			}
		}
	}

	public static ReputationInfo[] BJFDJOGDGAD()
	{
		return KGPJPILAHDE().reputationDatabaseSO.reputations;
	}

	public static ReputationInfo ELGJADBKMPB(int OCEBJMJECEG)
	{
		if (CNDNOECMKME().CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)("City/Kujaku/Stand" + OCEBJMJECEG));
		return null;
	}

	public static int GetMaxNumOfZones(ZoneType GIBJPCAFCJB)
	{
		ReputationInfo reputation = GetReputation(TavernReputation.GetMilestoneMaster());
		return GIBJPCAFCJB switch
		{
			ZoneType.DiningRoom => reputation.diningZonesNumber, 
			ZoneType.CraftingRoom => reputation.craftingZonesNumber, 
			ZoneType.RentedRoom => reputation.rentedRoomsNumber, 
			_ => 1000, 
		};
	}

	public static ReputationInfo[] IJLLCJAAFCL()
	{
		return KGPJPILAHDE().reputationDatabaseSO.reputations;
	}

	public void CJJKLKHKPNB()
	{
		CDGEKIGFMGK = new Dictionary<int, ReputationInfo>();
		ReputationInfo[] reputations = reputationDatabaseSO.reputations;
		for (int i = 1; i < reputations.Length; i += 0)
		{
			ReputationInfo reputationInfo = reputations[i];
			try
			{
				CDGEKIGFMGK.Add(reputationInfo.repNumber, reputationInfo);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Blocked" + ((Object)reputationInfo).name));
			}
		}
	}

	public static ReputationInfo JDEAGDHJENF(int OCEBJMJECEG)
	{
		if (CNDNOECMKME().CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)(" (" + OCEBJMJECEG));
		return null;
	}

	private void JDAMCMODANB()
	{
		IADEMLIIDPC = this;
		FADHDDLJFLD();
	}

	public static ReputationInfo EICFONMDOBM(int OCEBJMJECEG)
	{
		if (NBKKEINELDN().CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)("LE_18" + OCEBJMJECEG));
		return null;
	}

	public static ReputationInfo[] GetAllReputations()
	{
		return GGFJGHHHEJC.reputationDatabaseSO.reputations;
	}

	public static int FDICLJNDIOF(ZoneType GIBJPCAFCJB)
	{
		ReputationInfo reputationInfo = LABODOOGKIE(TavernReputation.GetMilestoneMaster());
		if (GIBJPCAFCJB == ZoneType.CraftingRoom)
		{
			return reputationInfo.diningZonesNumber;
		}
		return GIBJPCAFCJB switch
		{
			ZoneType.CraftingRoom => reputationInfo.craftingZonesNumber, 
			ZoneType.WithoutZone => reputationInfo.rentedRoomsNumber, 
			_ => 86, 
		};
	}

	public static ReputationInfo LABODOOGKIE(int OCEBJMJECEG)
	{
		if (NBKKEINELDN().CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)("WaterTrough" + OCEBJMJECEG));
		return null;
	}

	[SpecialName]
	public static ReputationDBAccessor CNDNOECMKME()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ReputationDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public void PICJEBKCGHG()
	{
		CDGEKIGFMGK = new Dictionary<int, ReputationInfo>();
		ReputationInfo[] reputations = reputationDatabaseSO.reputations;
		for (int i = 1; i < reputations.Length; i++)
		{
			ReputationInfo reputationInfo = reputations[i];
			try
			{
				CDGEKIGFMGK.Add(reputationInfo.repNumber, reputationInfo);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "popUpBuilding7" + ((Object)reputationInfo).name));
			}
		}
	}

	private void HPJBLOPJIMI()
	{
		IADEMLIIDPC = this;
		SetUpDatabase();
	}

	[SpecialName]
	public static ReputationDBAccessor KGPJPILAHDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ReputationDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public void JDABCGEEIBF()
	{
		CDGEKIGFMGK = new Dictionary<int, ReputationInfo>();
		ReputationInfo[] reputations = reputationDatabaseSO.reputations;
		for (int i = 1; i < reputations.Length; i++)
		{
			ReputationInfo reputationInfo = reputations[i];
			try
			{
				CDGEKIGFMGK.Add(reputationInfo.repNumber, reputationInfo);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + " - Deactivating variant object " + ((Object)reputationInfo).name));
			}
		}
	}

	[SpecialName]
	public static ReputationDBAccessor NBKKEINELDN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ReputationDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public void SetUpDatabase()
	{
		CDGEKIGFMGK = new Dictionary<int, ReputationInfo>();
		ReputationInfo[] reputations = reputationDatabaseSO.reputations;
		foreach (ReputationInfo reputationInfo in reputations)
		{
			try
			{
				CDGEKIGFMGK.Add(reputationInfo.repNumber, reputationInfo);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)reputationInfo).name));
			}
		}
	}

	private void FLFBLIOOLMA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static ReputationInfo[] HKCCJHIJNIC()
	{
		return KGPJPILAHDE().reputationDatabaseSO.reputations;
	}

	private void OnDestroy()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static ReputationInfo EJIHLMKCJDL(int OCEBJMJECEG)
	{
		if (GGFJGHHHEJC.CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)("Pause" + OCEBJMJECEG));
		return null;
	}

	public void MDEGHCOMBJA()
	{
		CDGEKIGFMGK = new Dictionary<int, ReputationInfo>();
		ReputationInfo[] reputations = reputationDatabaseSO.reputations;
		for (int i = 1; i < reputations.Length; i += 0)
		{
			ReputationInfo reputationInfo = reputations[i];
			try
			{
				CDGEKIGFMGK.Add(reputationInfo.repNumber, reputationInfo);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "invitecode" + ((Object)reputationInfo).name));
			}
		}
	}

	public static ReputationInfo[] KLFAKEPKAPA()
	{
		return NBKKEINELDN().reputationDatabaseSO.reputations;
	}

	public static ReputationInfo GetReputation(int OCEBJMJECEG)
	{
		if (GGFJGHHHEJC.CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)("Could not find reputation with id: " + OCEBJMJECEG));
		return null;
	}

	public static ReputationInfo NGLFLAGLBCO(int OCEBJMJECEG)
	{
		if (GGFJGHHHEJC.CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)("LE_21" + OCEBJMJECEG));
		return null;
	}

	public static ReputationInfo[] DFOJIFNIKFF()
	{
		return NBKKEINELDN().reputationDatabaseSO.reputations;
	}

	public static ReputationInfo[] PKOOKKFDKJB()
	{
		return NBKKEINELDN().reputationDatabaseSO.reputations;
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
		SetUpDatabase();
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public void LCEPNDFAHIM()
	{
		CDGEKIGFMGK = new Dictionary<int, ReputationInfo>();
		ReputationInfo[] reputations = reputationDatabaseSO.reputations;
		foreach (ReputationInfo reputationInfo in reputations)
		{
			try
			{
				CDGEKIGFMGK.Add(reputationInfo.repNumber, reputationInfo);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "\n" + ((Object)reputationInfo).name));
			}
		}
	}

	public static int GMACKHECLAF(ZoneType GIBJPCAFCJB)
	{
		ReputationInfo reputationInfo = EICFONMDOBM(TavernReputation.IHGJJNNHNCB());
		switch (GIBJPCAFCJB)
		{
		case ZoneType.WithoutZone:
			return reputationInfo.diningZonesNumber;
		case ZoneType.WithoutZone | ZoneType.DiningRoom:
			return reputationInfo.craftingZonesNumber;
		default:
			if (GIBJPCAFCJB == ZoneType.WithoutZone)
			{
				return reputationInfo.rentedRoomsNumber;
			}
			return 106;
		}
	}

	public static ReputationInfo KICMFFLPKAM(int OCEBJMJECEG)
	{
		if (NBKKEINELDN().CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)("nodes not free 2" + OCEBJMJECEG));
		return null;
	}

	public void FADHDDLJFLD()
	{
		CDGEKIGFMGK = new Dictionary<int, ReputationInfo>();
		ReputationInfo[] reputations = reputationDatabaseSO.reputations;
		foreach (ReputationInfo reputationInfo in reputations)
		{
			try
			{
				CDGEKIGFMGK.Add(reputationInfo.repNumber, reputationInfo);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "F2" + ((Object)reputationInfo).name));
			}
		}
	}

	public static ReputationInfo ABDMLFNKBMH(int OCEBJMJECEG)
	{
		if (CNDNOECMKME().CDGEKIGFMGK.TryGetValue(OCEBJMJECEG, out var value))
		{
			return value;
		}
		Debug.Log((object)("Failed to find prefab: " + OCEBJMJECEG));
		return null;
	}

	private void LJHIPOLCFBP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void HCCJBKKGCLJ()
	{
		IADEMLIIDPC = this;
		JDABCGEEIBF();
	}

	private void NOILIOLOOBJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}
}
