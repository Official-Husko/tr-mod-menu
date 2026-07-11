using System;
using System.Collections.Generic;
using UnityEngine;

public class CropDatabaseAccessor : MonoBehaviour
{
	private static CropDatabaseAccessor GGFJGHHHEJC;

	[SerializeField]
	private CropsDatabase CropDatabaseSO;

	private Dictionary<int, Crop> NJDBKKGAGDC;

	public Crop[] allCrops;

	public Dictionary<Category, Crop[]> buyableCrops = new Dictionary<Category, Crop[]>();

	public static Crop ALJPIPOLLJC(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			BMDNOGNAPJJ();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[1].item.IMCJPECAAPC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void JNJCCIFIKOC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop HBAKOOGKCIB(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[1].item.CIGFGKKCPCK(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void ODBDHFBMDAG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void IGBPLHNBBAB()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		foreach (Crop crop in crops)
		{
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"vibrationP2");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("Attack/MainEvent 3" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Level" + crop.id + "El componente ItemSetup del rotatedPrefab '" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "LE_10" + ((Object)crop).name));
			}
		}
	}

	public static Crop JGDCGHGNNLL(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GICPPAGFDPG();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.JPNFKDMFKMC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void FFLLCOBFIPE()
	{
		GGFJGHHHEJC = this;
		AGAIMFPLCMM();
	}

	public static Crop OJKKMLKDDAL(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Bomb" + JFNMCNCHMEO));
		return null;
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void CLGBFOIBANN()
	{
		GGFJGHHHEJC = this;
		OONGMKLMODB();
	}

	private void FKNAANNMMLB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop HNKLGKCEEIN(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Selected" + JFNMCNCHMEO));
		return null;
	}

	public static Crop LMELCJFOIIH(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			IIJAOOJGNHO();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.JDJGFAACPFC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void LHAPMEEADKH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void AMBKBOBDAIF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop LJMAGFEDABF(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ListViewEntry" + JFNMCNCHMEO));
		return null;
	}

	private void IKMPNICLPBM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static CropDatabaseAccessor BMDNOGNAPJJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static CropDatabaseAccessor JBEGCCBHOIA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void EIDJLHFAMIB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop KMLNNPPPICM(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Eat" + JFNMCNCHMEO));
		return null;
	}

	private void IGBEKHCLKFD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static CropDatabaseAccessor COJCDHBCJKE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void ACFABFCGIGH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop FFDFBGGDPOP(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)(" " + JFNMCNCHMEO));
		return null;
	}

	private void NNGJOHLNKNH()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 0; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"ReceiveFinishBathhouseMinigame");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("Remove" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("tutorialPopUp0" + crop.id + "ReceiveActivateAndStartBanquetEvent" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Name..." + ((Object)crop).name));
			}
		}
	}

	public static Crop NJEHKMJDCCM(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ReceiveAskHostForRoomToJoin" + JFNMCNCHMEO));
		return null;
	}

	public static Crop AKHEEALPLFC(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("" + JFNMCNCHMEO));
		return null;
	}

	private void PEOPFPEDFAK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop CLAOEPMOMCN(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			HNMGNIGHJGP();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[1].item.JPNFKDMFKMC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void BFJOEMCBJJO()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	private void HCCJBKKGCLJ()
	{
		GGFJGHHHEJC = this;
		AGAIMFPLCMM();
	}

	public static Crop PBDEFOEKCFG(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Player" + JFNMCNCHMEO));
		return null;
	}

	public static Crop HKLKEKDIOKJ(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Select" + JFNMCNCHMEO));
		return null;
	}

	private void FDNAEJDHODK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void NHNAAFGHPEC()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"High");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("Left" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("allTavernPositions is empty" + crop.id + "LE_18" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "OnLobbyDataUpdate \nLobby: {0}\nUser: {1}" + ((Object)crop).name));
			}
		}
	}

	public static Crop MMBCLPBCHMB(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			COJCDHBCJKE();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.JPNFKDMFKMC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static CropDatabaseAccessor HNMGNIGHJGP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static CropDatabaseAccessor CAJHNGGCJKM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Crop EBAHNDAKGME(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GDAEMIPHAHH();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.ODENMDOJPLC() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void FJFKBNOAFLL()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"WaitIntro");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("ReceiveFoodRequestAsDrink" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("/" + crop.id + "This shouldn't happen. freePositions list must not have been initialized properly." + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Stop" + ((Object)crop).name));
			}
		}
	}

	private void ICNAMMPLBDI()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"Error_SmallRoom");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("cheeseAgeingRackPopUp" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Failed to find prefab: " + crop.id + "popUpBuilding20" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "itemStoutWort" + ((Object)crop).name));
			}
		}
	}

	private void MDIENLHEDGE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void CLNBMOPMNOF()
	{
		GGFJGHHHEJC = this;
		JMMGFMPDCKC();
	}

	public static Crop DFCICEANLDA(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			DNEGFMDKNHL();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.JPNFKDMFKMC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void EGHOIJHBDBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void LAMDALODNDH()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)", ");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("Bird materials empty " + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Items/item_name_686" + crop.id + "Items/item_description_1105" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Current map: " + ((Object)crop).name));
			}
		}
	}

	private void ANBIODFHCKK()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)".gz");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("buildingObjective_36_0" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Deselect item" + crop.id + "Tavern" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "{0}    └─ ... ({1} hijo(s) no expandido(s))" + ((Object)crop).name));
			}
		}
	}

	private void DGLEDCINFKI()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i++)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"0");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("The index (" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("LE_6" + crop.id + "NoEresDigno/EndEvent" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Farm/Bob/Stand" + ((Object)crop).name));
			}
		}
	}

	private void MFGANCCJFJK()
	{
		GGFJGHHHEJC = this;
		AGAIMFPLCMM();
	}

	private void HKECEBGKACL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static CropDatabaseAccessor AOKJPGGLJEB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Crop NDGHEAHJNJG(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)(" " + JFNMCNCHMEO));
		return null;
	}

	private void AEDIIIAECIC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DHHJDBGFJJG()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		foreach (Crop crop in crops)
		{
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"Cat");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("in" + crop.id + "Game" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Items/item_description_664" + ((Object)crop).name));
			}
		}
	}

	public static CropDatabaseAccessor DNEGFMDKNHL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Crop GetCropByOutputId(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.JDJGFAACPFC() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static Crop OBGMKHFFKFD(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ReceiveChatMessage" + JFNMCNCHMEO));
		return null;
	}

	private void NKGMEMEACNN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static CropDatabaseAccessor NOEBLLHOEOP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Crop LJGMKFLOBBN(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GICPPAGFDPG();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.IMCJPECAAPC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void ONCFHCIABPK()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 0; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"F2");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("Disabled" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Changing quality " + crop.id + "Player" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "MainProgress" + ((Object)crop).name));
			}
		}
	}

	public static Crop OHKMKEBGHPA(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			AKKHNCEFDCB();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.ODENMDOJPLC() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static Crop IKEJNHACJAE(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GICPPAGFDPG();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static CropDatabaseAccessor AKKHNCEFDCB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static CropDatabaseAccessor EMBCJPOLBCB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Crop FKEKHHMLMCK(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			DNEGFMDKNHL();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[1].item.JPNFKDMFKMC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static Crop PHKMAONBJIC(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			BMDNOGNAPJJ();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[1].item.IMCJPECAAPC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static Crop KGOFJNOINIB(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GICPPAGFDPG();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.IMCJPECAAPC() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static Crop AIFMIOGPPOG(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GICPPAGFDPG();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.CIGFGKKCPCK(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static CropDatabaseAccessor GetInstance()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Crop FLIKMNLEJMJ(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			IIJAOOJGNHO();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.ODENMDOJPLC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static Crop KKHKIJOMFEG(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			CAJHNGGCJKM();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.CIGFGKKCPCK() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static CropDatabaseAccessor GDAEMIPHAHH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void MDEGHCOMBJA()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 0; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"Open");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("ReceiveShopInfo" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("in" + crop.id + "Disappear" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + ":</color> " + ((Object)crop).name));
			}
		}
	}

	public static Crop DLKGDEFEFJI(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			CAJHNGGCJKM();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.ODENMDOJPLC() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static Crop IOEKKOLCEBD(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[1].item.IMCJPECAAPC() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static CropDatabaseAccessor GICPPAGFDPG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void NOLCHICHJDO()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		foreach (Crop crop in crops)
		{
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"TabernaClausurada/MaiDialogue 02");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("itemWheatBread" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("<mark=#000000><alpha=#00> " + crop.id + "DecorationTile_17" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Player2" + ((Object)crop).name));
			}
		}
	}

	private void NJAFKFAPDIE()
	{
		GGFJGHHHEJC = this;
		AGAIMFPLCMM();
	}

	public static Crop GetCrop(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Could not find Crop with id: " + JFNMCNCHMEO));
		return null;
	}

	private void EFCNKPEPELL()
	{
		GGFJGHHHEJC = this;
		ONCFHCIABPK();
	}

	private void KCLKEAHGGEK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JMMGFMPDCKC()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 0; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"ValueRemainingMs");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)(" with item: " + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("quest_name_21" + crop.id + " " + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Items/item_name_601" + ((Object)crop).name));
			}
		}
	}

	private void AGILHHEMEFC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop FBOGFJNFFEL(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)(" : " + JFNMCNCHMEO));
		return null;
	}

	public static CropDatabaseAccessor IIJAOOJGNHO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	private void HBEBKMNGLBJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop NLMFFBNODKD(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Item " + JFNMCNCHMEO));
		return null;
	}

	private void NLIJOHDIKEE()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i++)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"Dialogue System/Conversation/Crowly_Barks_Shop/Entry/1/Dialogue Text");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("." + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Could not get name of achievement " + crop.id + "Recipe Book" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "ReceiveFishScoreUpdate" + ((Object)crop).name));
			}
		}
	}

	private void DADPOICMNPI()
	{
		GGFJGHHHEJC = this;
		LAMDALODNDH();
	}

	public static Crop OECNPMMAPMG(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("OpenXPModifiers" + JFNMCNCHMEO));
		return null;
	}

	public static Crop LHABAHGPNKL(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			COJCDHBCJKE();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.CIGFGKKCPCK() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static Crop DNPCKACKGBL(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("[MinePuzzleManager] Ordered puzzle queue for level {0}: [{1}]" + JFNMCNCHMEO));
		return null;
	}

	private void FLHOGPGJCFD()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i++)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)" at ");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("No valid position found around the position {0} after {1} attempts. Returning player's position." + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)(" is different from current " + crop.id + "[Variants] Piece {0} ({1}) has {2} variants and {3} are active. Only 1 should be active." + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "" + ((Object)crop).name));
			}
		}
	}

	private void AGAIMFPLCMM()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 0; i < crops.Length; i += 0)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"Favorites");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("item " + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("UI" + crop.id + "itemStoutWort" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Tool" + ((Object)crop).name));
			}
		}
	}

	public static Crop NKKBKOONIDO(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Items/item_description_605" + JFNMCNCHMEO));
		return null;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Crop MNENEFEONBL(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			JBEGCCBHOIA();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.JPNFKDMFKMC() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void FBLAMCDFMPE()
	{
		GGFJGHHHEJC = this;
		MDEGHCOMBJA();
	}

	public static Crop HLMHANHNNOB(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			CAJHNGGCJKM();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.ODENMDOJPLC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	public static CropDatabaseAccessor MDHKPJPPGCN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void PIHGEBONAOI()
	{
		GGFJGHHHEJC = this;
		NNGJOHLNKNH();
	}

	private void DEKGNHEHKFB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static CropDatabaseAccessor PKEMABKIKIA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<CropDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Crop OGFAJNIPDID(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			AOKJPGGLJEB();
		}
		for (int i = 0; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i++)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.JPNFKDMFKMC() == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void CNKNJLAGHNP()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		foreach (Crop crop in crops)
		{
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"</color>");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("Items/item_description_" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Dialogue System/Conversation/Gass_Barks_Bye/Entry/4/Dialogue Text" + crop.id + "LE_12" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "" + ((Object)crop).name));
			}
		}
	}

	public static Crop HGIJMKHCIEA(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.NJDBKKGAGDC.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ReceiveHerbs" + JFNMCNCHMEO));
		return null;
	}

	private void PBDNKBPBCHM()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	private void NHIOFNINLLK()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		for (int i = 1; i < crops.Length; i++)
		{
			Crop crop = crops[i];
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)" 2");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("LE_21" + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Items/item_description_1141" + crop.id + "<br/>Operating System: " + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)crop).name));
			}
		}
	}

	private void KMEJBPOOBJK()
	{
		GGFJGHHHEJC = this;
		CNKNJLAGHNP();
	}

	public static Crop FMIAGJDKGAI(int JFNMCNCHMEO)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			AOKJPGGLJEB();
		}
		for (int i = 1; i < GGFJGHHHEJC.CropDatabaseSO.Crops.Length; i += 0)
		{
			if (GGFJGHHHEJC.CropDatabaseSO.Crops[i].harvestedItems[0].item.ODENMDOJPLC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.CropDatabaseSO.Crops[i];
			}
		}
		return null;
	}

	private void DMNENKNLDAH()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		foreach (Crop crop in crops)
		{
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"Null Crop in database");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("Crop without ID: " + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("Duplicate Crop id found: " + crop.id + " - " + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)crop).name));
			}
		}
	}

	private void OONGMKLMODB()
	{
		NJDBKKGAGDC = new Dictionary<int, Crop>();
		Crop[] crops = CropDatabaseSO.Crops;
		foreach (Crop crop in crops)
		{
			if ((Object)(object)crop == (Object)null)
			{
				Debug.Log((object)"ReceiveFoodRequestAsDrink");
				continue;
			}
			if (crop.id == 0)
			{
				Debug.Log((object)("- " + ((Object)crop).name));
				continue;
			}
			if (NJDBKKGAGDC.ContainsKey(crop.id))
			{
				Debug.Log((object)("SetMinigame" + crop.id + "TermasInterior/Kenta/Stand" + ((Object)crop).name));
				continue;
			}
			try
			{
				NJDBKKGAGDC.Add(crop.id, crop);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "RequiresMaceration" + ((Object)crop).name));
			}
		}
	}
}
