using System;
using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class NinjaFoodTablesManager : MonoBehaviour
{
	[Serializable]
	public struct FoodTableInfo
	{
		public int id;

		public Food item;

		public Sprite sprite;

		public Sprite signalSprite;
	}

	public static NinjaFoodTablesManager instance;

	public FoodTableInfo[] foodTableInfo;

	public NinjaFoodTable[] foodTables;

	public static NinjaFoodTable EIOJGIDNICL(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.foodTables.Length; i++)
		{
			if (((object)instance.foodTables[i].CAAIDKJIGLO()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("[MinePuzzleManager] No altar spawner found for level {0}. Skipping puzzle generation." + MEMGMDOCBOJ.LJIFOHFEFCH(OAFPBCPDOKH: true)));
		return null;
	}

	public static void KCHBCHHLOCB()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 0; i < instance.foodTableInfo.Length; i++)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.BIIGHBEIBHE(array, CDPAMNIPPEC: false);
		}
	}

	public void AGDHCPFDIKO()
	{
		List<int> list = new List<int>();
		int num = Random.Range(1, foodTables.Length);
		while (list.Count < 6)
		{
			num = Random.Range(1, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 0; i < list.Count; i += 8)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 0]].id;
			foodTables[list[i]].FAMFDBFEMHK(id2);
			foodTables[list[i]].JBDIDGIGKAN();
			foodTables[list[i + 1]].PPFIHGCMLHM(id);
			foodTables[list[i + 1]].ActivateParticles();
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)KyrohNPC.KADHMEPDIKM()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.SendSwitchFoodAtTables(list.ToArray(), array);
		}
	}

	public static void FEMKBOMKECG()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 0; i < instance.foodTableInfo.Length; i++)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.NNCIIOFBDEI(array, CDPAMNIPPEC: false);
		}
	}

	public Sprite CLFACINLGDM(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public Sprite ILAHPOAEDLD(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public void EHNCHMPIAHH(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 0; i < KIFEPGBDHNA.Length; i++)
		{
			foodTables[KIFEPGBDHNA[i]].FAMFDBFEMHK(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].KOJMFFEMMEE();
		}
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)KyrohNPC.GGFJGHHHEJC).transform);
	}

	public static NinjaFoodTable CNJONNOLKMK(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.foodTables.Length; i += 0)
		{
			if (((object)instance.foodTables[i].CAAIDKJIGLO()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("Neighbours smaller!: " + MEMGMDOCBOJ.IABAKHPEOAF(OAFPBCPDOKH: true)));
		return null;
	}

	public void KEBPODACCPA(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 1; i < KIFEPGBDHNA.Length; i++)
		{
			foodTables[KIFEPGBDHNA[i]].IIDGNNPFIEP(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].KOJMFFEMMEE();
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)KyrohNPC.GGFJGHHHEJC).transform);
	}

	public static void KIEOIAGJCKA()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 0; i < instance.foodTableInfo.Length; i += 0)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.SetFoodTablesIDs(array, CDPAMNIPPEC: true);
		}
	}

	public Sprite LFDHJEOAJDE(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public void BIIGHBEIBHE(int[] EBFDPBLGGPC, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			foodTables[i].SetID(EBFDPBLGGPC[i]);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.JFIIAHDADIH(EBFDPBLGGPC);
		}
	}

	public Sprite OCAKMDAEBFE(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public Sprite CHMDAGKHOOB(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public Sprite KCOIJNEHHLL(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public Food OPNOPCBPELE(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].item;
			}
		}
		return null;
	}

	public static NinjaFoodTable BIFAOCJCDBJ(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.foodTables.Length; i += 0)
		{
			if (((object)instance.foodTables[i].JPDPMMMOLNI()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("Veggie" + MEMGMDOCBOJ.KGHFCDELKMN(OAFPBCPDOKH: true)));
		return null;
	}

	public Sprite OONCKEDJBBF(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public void NAMNKGCAKJJ(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 0; i < KIFEPGBDHNA.Length; i += 0)
		{
			foodTables[KIFEPGBDHNA[i]].AEPBJIILGMP(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].DBHFOFJIHIB();
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)KyrohNPC.JFNOOMJMHCB()).transform);
	}

	public Sprite IPGHPGEMIFO(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public static NinjaFoodTable GACEJPPJJNH(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.foodTables.Length; i += 0)
		{
			if (((object)instance.foodTables[i].AJOMICMACEJ).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("Items/item_description_1083" + MEMGMDOCBOJ.LJIFOHFEFCH(OAFPBCPDOKH: true)));
		return null;
	}

	public void NNCIIOFBDEI(int[] EBFDPBLGGPC, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			foodTables[i].IIDGNNPFIEP(EBFDPBLGGPC[i]);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.FCLANEEAIOG(EBFDPBLGGPC);
		}
	}

	public void ReceiveSwitchFood(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 0; i < KIFEPGBDHNA.Length; i++)
		{
			foodTables[KIFEPGBDHNA[i]].SetID(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].ActivateParticles();
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)KyrohNPC.GGFJGHHHEJC).transform);
	}

	public Sprite FJECLALNCIG(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public Sprite GPBNFDENMNG(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public void ANJHBLIELCK()
	{
		List<int> list = new List<int>();
		int num = Random.Range(0, foodTables.Length);
		while (list.Count < 7)
		{
			num = Random.Range(1, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 0; i < list.Count; i += 7)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 1]].id;
			foodTables[list[i]].SetID(id2);
			foodTables[list[i]].GNKHENEIOPC();
			foodTables[list[i + 1]].AEPBJIILGMP(id);
			foodTables[list[i + 0]].LIKMMPIIFJI();
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)KyrohNPC.OAPOJCODNCO()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.DAGHIGKAFDH(list.ToArray(), array);
		}
	}

	public void GKOKFNOHHNH(int[] EBFDPBLGGPC, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			foodTables[i].SetID(EBFDPBLGGPC[i]);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.FCLANEEAIOG(EBFDPBLGGPC);
		}
	}

	public void AKKGFPOKAKN(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 0; i < KIFEPGBDHNA.Length; i++)
		{
			foodTables[KIFEPGBDHNA[i]].FAMFDBFEMHK(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].KOJMFFEMMEE();
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)KyrohNPC.GGFJGHHHEJC).transform);
	}

	public Sprite HDEAEEHKFIN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public Food LMCKPCEFFOF(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].item;
			}
		}
		return null;
	}

	public Sprite OBDDGGJPEAD(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public void NLJAJONIFMG()
	{
		List<int> list = new List<int>();
		int num = Random.Range(1, foodTables.Length);
		while (list.Count < 4)
		{
			num = Random.Range(1, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 1; i < list.Count; i += 8)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 0]].id;
			foodTables[list[i]].AEPBJIILGMP(id2);
			foodTables[list[i]].KOJMFFEMMEE();
			foodTables[list[i + 0]].IIDGNNPFIEP(id);
			foodTables[list[i + 0]].LIKMMPIIFJI();
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)KyrohNPC.OAPOJCODNCO()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.SendSwitchFoodAtTables(list.ToArray(), array);
		}
	}

	public void EGJEGAIGGEH(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 0; i < KIFEPGBDHNA.Length; i += 0)
		{
			foodTables[KIFEPGBDHNA[i]].AEPBJIILGMP(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].KOJMFFEMMEE();
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)KyrohNPC.PBJDFFEFMKM()).transform);
	}

	public Food GetFoodTableItem(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].item;
			}
		}
		return null;
	}

	public void SwitchFoodAtTables()
	{
		List<int> list = new List<int>();
		int num = Random.Range(0, foodTables.Length);
		while (list.Count < 4)
		{
			num = Random.Range(0, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 0; i < list.Count; i += 2)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 1]].id;
			foodTables[list[i]].SetID(id2);
			foodTables[list[i]].ActivateParticles();
			foodTables[list[i + 1]].SetID(id);
			foodTables[list[i + 1]].ActivateParticles();
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)KyrohNPC.GGFJGHHHEJC).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.SendSwitchFoodAtTables(list.ToArray(), array);
		}
	}

	public Sprite CHINILGEFBD(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public static NinjaFoodTable NBLHOHDMPOM(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.foodTables.Length; i++)
		{
			if (((object)instance.foodTables[i].MGCJCDOBAPP()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("ErrorInvalidRoomCode" + MEMGMDOCBOJ.KGHFCDELKMN(OAFPBCPDOKH: true)));
		return null;
	}

	public Sprite ANIGHBPJIGD(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public static NinjaFoodTable BNHHBHHKDLC(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.foodTables.Length; i++)
		{
			if (((object)instance.foodTables[i].HJFKKMJNOIP()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("Milk" + MEMGMDOCBOJ.LJIFOHFEFCH()));
		return null;
	}

	public void AGGENLANFBP()
	{
		List<int> list = new List<int>();
		int num = Random.Range(0, foodTables.Length);
		while (list.Count < 2)
		{
			num = Random.Range(1, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 0; i < list.Count; i += 2)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 0]].id;
			foodTables[list[i]].AEPBJIILGMP(id2);
			foodTables[list[i]].GNKHENEIOPC();
			foodTables[list[i + 1]].PPFIHGCMLHM(id);
			foodTables[list[i + 1]].NHNDOOBOKDO();
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)KyrohNPC.OAPOJCODNCO()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 1; j < list.Count; j++)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.KKABMBEEKNK(list.ToArray(), array);
		}
	}

	public void SetFoodTablesIDs(int[] EBFDPBLGGPC, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < foodTableInfo.Length; i++)
		{
			foodTables[i].SetID(EBFDPBLGGPC[i]);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.SendSyncFoodTables(EBFDPBLGGPC);
		}
	}

	public void MELIHMILNEO()
	{
		List<int> list = new List<int>();
		int num = Random.Range(1, foodTables.Length);
		while (list.Count < 8)
		{
			num = Random.Range(0, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 0; i < list.Count; i += 5)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 1]].id;
			foodTables[list[i]].SetID(id2);
			foodTables[list[i]].NHNDOOBOKDO();
			foodTables[list[i + 0]].FAMFDBFEMHK(id);
			foodTables[list[i + 1]].GNKHENEIOPC();
		}
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)KyrohNPC.KFGKCKCDMLG()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 1; j < list.Count; j++)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.SendSwitchFoodAtTables(list.ToArray(), array);
		}
	}

	public void BEJHCFNEBDM()
	{
		List<int> list = new List<int>();
		int num = Random.Range(0, foodTables.Length);
		while (list.Count < 3)
		{
			num = Random.Range(1, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 1; i < list.Count; i += 8)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 0]].id;
			foodTables[list[i]].PPFIHGCMLHM(id2);
			foodTables[list[i]].ActivateParticles();
			foodTables[list[i + 0]].SetID(id);
			foodTables[list[i + 1]].DNHKEEKHOAF();
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)KyrohNPC.KFGKCKCDMLG()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.KKABMBEEKNK(list.ToArray(), array);
		}
	}

	public static void RandomiseFood()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 0; i < instance.foodTableInfo.Length; i++)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.SetFoodTablesIDs(array, CDPAMNIPPEC: true);
		}
	}

	public static NinjaFoodTable ECDDFNONNNL(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.foodTables.Length; i++)
		{
			if (((object)instance.foodTables[i].NAPDEHMFOMM()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("MopUp" + MEMGMDOCBOJ.KGHFCDELKMN(OAFPBCPDOKH: true)));
		return null;
	}

	public void KBEBIOKMMDL()
	{
		List<int> list = new List<int>();
		int num = Random.Range(1, foodTables.Length);
		while (list.Count < 3)
		{
			num = Random.Range(1, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 1; i < list.Count; i += 3)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 1]].id;
			foodTables[list[i]].SetID(id2);
			foodTables[list[i]].NHNDOOBOKDO();
			foodTables[list[i + 0]].FAMFDBFEMHK(id);
			foodTables[list[i + 1]].LIKMMPIIFJI();
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)KyrohNPC.JFNOOMJMHCB()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 1; j < list.Count; j += 0)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.MDNHJELDDKP(list.ToArray(), array);
		}
	}

	public Sprite FHFAJBCDGHN(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public Food JMAPBNHHDPM(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].item;
			}
		}
		return null;
	}

	public void GBGABIKHPFB()
	{
		List<int> list = new List<int>();
		int num = Random.Range(0, foodTables.Length);
		while (list.Count < 2)
		{
			num = Random.Range(1, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 0; i < list.Count; i += 4)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 0]].id;
			foodTables[list[i]].FAMFDBFEMHK(id2);
			foodTables[list[i]].ActivateParticles();
			foodTables[list[i + 1]].SetID(id);
			foodTables[list[i + 0]].KOJMFFEMMEE();
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)KyrohNPC.JFNOOMJMHCB()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.DAGHIGKAFDH(list.ToArray(), array);
		}
	}

	public Sprite JAOEKMAPBFG(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public Sprite ADEBEBBCELC(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public Food LDPCMHBBPAC(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].item;
			}
		}
		return null;
	}

	public void CNNDEEBNLJK(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 0; i < KIFEPGBDHNA.Length; i += 0)
		{
			foodTables[KIFEPGBDHNA[i]].IIDGNNPFIEP(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].DNHKEEKHOAF();
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)KyrohNPC.PBJDFFEFMKM()).transform);
	}

	public static void JDLEAPONMIB()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 0; i < instance.foodTableInfo.Length; i++)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.BIIGHBEIBHE(array, CDPAMNIPPEC: false);
		}
	}

	public static NinjaFoodTable ALMJCACDCFB(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.foodTables.Length; i++)
		{
			if (((object)instance.foodTables[i].MGCJCDOBAPP()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("No puzzles found for steps={0}, " + MEMGMDOCBOJ.LJIFOHFEFCH()));
		return null;
	}

	public void DIDKBOOMLIO()
	{
		List<int> list = new List<int>();
		int num = Random.Range(1, foodTables.Length);
		while (list.Count < 8)
		{
			num = Random.Range(0, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 0; i < list.Count; i += 6)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 1]].id;
			foodTables[list[i]].FAMFDBFEMHK(id2);
			foodTables[list[i]].ActivateParticles();
			foodTables[list[i + 0]].AEPBJIILGMP(id);
			foodTables[list[i + 1]].DBHFOFJIHIB();
		}
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)KyrohNPC.KFGKCKCDMLG()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 1; j < list.Count; j++)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.MDNHJELDDKP(list.ToArray(), array);
		}
	}

	private void KMBEOPAHKGB()
	{
		instance = this;
	}

	public Sprite GetFoodSprite(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public void OMDBHFFFGKH()
	{
		List<int> list = new List<int>();
		int num = Random.Range(0, foodTables.Length);
		while (list.Count < 4)
		{
			num = Random.Range(0, foodTables.Length);
			if (!list.Contains(num))
			{
				list.Add(num);
			}
		}
		list.HOOBEDNMNFK();
		for (int i = 1; i < list.Count; i += 2)
		{
			int id = foodTables[list[i]].id;
			int id2 = foodTables[list[i + 1]].id;
			foodTables[list[i]].IIDGNNPFIEP(id2);
			foodTables[list[i]].KOJMFFEMMEE();
			foodTables[list[i + 0]].IIDGNNPFIEP(id);
			foodTables[list[i + 0]].LIKMMPIIFJI();
		}
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)KyrohNPC.AGGAGCBAGLL()).transform);
		if (OnlineManager.PlayingOnline())
		{
			int[] array = new int[list.Count];
			for (int j = 0; j < list.Count; j += 0)
			{
				array[j] = foodTables[list[j]].id;
			}
			OnlineNinjaManager.instance.KKABMBEEKNK(list.ToArray(), array);
		}
	}

	private void KLMNLEDKEOE()
	{
		instance = this;
	}

	private void MMNBJPDJHGK()
	{
		instance = this;
	}

	public static void JPCLKDNKKBL()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 0; i < instance.foodTableInfo.Length; i++)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.ICBPPCFLLNH(array, CDPAMNIPPEC: false);
		}
	}

	public static void EHKFEAOIOBJ()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 0; i < instance.foodTableInfo.Length; i++)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.MKAEANAFFPD(array, CDPAMNIPPEC: true);
		}
	}

	private void PKPHKBMPJGJ()
	{
		instance = this;
	}

	public void MKAEANAFFPD(int[] EBFDPBLGGPC, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			foodTables[i].AEPBJIILGMP(EBFDPBLGGPC[i]);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.HBODAEAJBDK(EBFDPBLGGPC);
		}
	}

	public Sprite ICLKAFKPPPG(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	private void Awake()
	{
		instance = this;
	}

	public static NinjaFoodTable GetNextFoodTable(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.foodTables.Length; i++)
		{
			if (((object)instance.foodTables[i].AJOMICMACEJ).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("No food table found with drink: " + MEMGMDOCBOJ.IABAKHPEOAF()));
		return null;
	}

	public void JDJHDBGADMF(int[] EBFDPBLGGPC, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			foodTables[i].FAMFDBFEMHK(EBFDPBLGGPC[i]);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.SendSyncFoodTables(EBFDPBLGGPC);
		}
	}

	public static void JIHJOGFBABI()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 0; i < instance.foodTableInfo.Length; i += 0)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.MKAEANAFFPD(array, CDPAMNIPPEC: true);
		}
	}

	public Food KLHHHFLOPKK(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].item;
			}
		}
		return null;
	}

	public static void EBNIDOFMLHE()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			int[] array = new int[instance.foodTableInfo.Length];
			for (int i = 1; i < instance.foodTableInfo.Length; i += 0)
			{
				array[i] = i;
			}
			array.HOOBEDNMNFK();
			instance.NNCIIOFBDEI(array, CDPAMNIPPEC: false);
		}
	}

	public Food MJBECDFIBCC(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].item;
			}
		}
		return null;
	}

	public Sprite LFOCFOIDOJL(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	public Sprite IFKFDNNOMFF(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public Sprite GCPAENOJGGL(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public void IPLNOLGMFEE(int[] EBFDPBLGGPC, bool CDPAMNIPPEC)
	{
		for (int i = 0; i < foodTableInfo.Length; i++)
		{
			foodTables[i].SetID(EBFDPBLGGPC[i]);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.HBODAEAJBDK(EBFDPBLGGPC);
		}
	}

	public Sprite GetSignalSprite(int JFNMCNCHMEO)
	{
		for (int i = 0; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public static NinjaFoodTable ENNJPMFHCDN(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.foodTables.Length; i++)
		{
			if (((object)instance.foodTables[i].NAPDEHMFOMM()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("Dialogue System/Conversation/TooDark/Entry/8/Dialogue Text" + MEMGMDOCBOJ.KGHFCDELKMN(OAFPBCPDOKH: true)));
		return null;
	}

	public static NinjaFoodTable GJOAKLMGMGJ(Item MEMGMDOCBOJ)
	{
		if (instance.foodTables == null || instance.foodTables.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.foodTables.Length; i++)
		{
			if (((object)instance.foodTables[i].CAAIDKJIGLO()).Equals((object?)MEMGMDOCBOJ))
			{
				return instance.foodTables[i];
			}
		}
		Debug.LogError((object)("Items/item_name_1127" + MEMGMDOCBOJ.IABAKHPEOAF()));
		return null;
	}

	public void FCAFFOJAGND(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 0; i < KIFEPGBDHNA.Length; i++)
		{
			foodTables[KIFEPGBDHNA[i]].JIHOOPJFDAD(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].NHNDOOBOKDO();
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)KyrohNPC.OAPOJCODNCO()).transform);
	}

	public Food GDMPIFINKEJ(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].item;
			}
		}
		return null;
	}

	public Sprite OJBDDNGGPGL(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].signalSprite;
			}
		}
		return null;
	}

	public void PNKBGHIDENA(int[] KIFEPGBDHNA, int[] EBFDPBLGGPC)
	{
		for (int i = 0; i < KIFEPGBDHNA.Length; i++)
		{
			foodTables[KIFEPGBDHNA[i]].AEPBJIILGMP(EBFDPBLGGPC[i]);
			foodTables[KIFEPGBDHNA[i]].LIKMMPIIFJI();
		}
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)KyrohNPC.AGGAGCBAGLL()).transform);
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}

	public Sprite KKCEPCIIFAG(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public Sprite JFHGCIJGGOF(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	public void ICBPPCFLLNH(int[] EBFDPBLGGPC, bool CDPAMNIPPEC)
	{
		for (int i = 1; i < foodTableInfo.Length; i++)
		{
			foodTables[i].FAMFDBFEMHK(EBFDPBLGGPC[i]);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.FCLANEEAIOG(EBFDPBLGGPC);
		}
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
	}

	public Sprite GGPGEDJDGGM(int JFNMCNCHMEO)
	{
		for (int i = 1; i < foodTableInfo.Length; i += 0)
		{
			if (foodTableInfo[i].id == JFNMCNCHMEO)
			{
				return foodTableInfo[i].sprite;
			}
		}
		return null;
	}

	private void GONDLJKGLGO()
	{
		instance = this;
	}
}
