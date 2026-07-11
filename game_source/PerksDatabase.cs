using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Employee Perks Database")]
public class PerksDatabase : SerializedScriptableObject
{
	[Serializable]
	public class WorkerPerkLine
	{
		public int id;

		public string name;

		public string description;

		public WorkerType workerType;

		public int[] levels;

		public int copperCost;

		public bool negative;

		public int[] incompatibilities;
	}

	[Serializable]
	public class PlayerPerkLine
	{
		public int id;

		public string name;

		public string description;

		public int[] levels;

		public string perkTree;
	}

	public Dictionary<int, PlayerPerk> playerPerks = new Dictionary<int, PlayerPerk>();

	public Dictionary<int, EmployeePerk> employeesPerks = new Dictionary<int, EmployeePerk>();

	public EmployeePerk[] barworkerPositivePerks;

	public EmployeePerk[] waiterPositivePerks;

	public EmployeePerk[] bouncerPositivePerks;

	public EmployeePerk[] houseKeeperPositivePerks;

	public EmployeePerk[] barworkerNegativePerks;

	public EmployeePerk[] waiterNegativePerks;

	public EmployeePerk[] bouncerNegativePerks;

	public EmployeePerk[] houseKeeperNegativePerks;

	public List<PlayerPerkLine> playerPerksLines = new List<PlayerPerkLine>();

	public List<WorkerPerkLine> employeePerksLines = new List<WorkerPerkLine>();

	public EmployeePerk[] MCMBLBKBLNK(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => barworkerPositivePerks, 
			WorkerType.Waiter => waiterPositivePerks, 
			WorkerType.Bouncer => bouncerPositivePerks, 
			_ => houseKeeperPositivePerks, 
		};
	}

	public EmployeePerk KKNFMGCDCHL(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public EmployeePerk OKMGINDJJNL(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public PlayerPerk HBEOPJBKJMP(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public EmployeePerk[] JAIBDLMIFGG(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			return barworkerPositivePerks;
		case WorkerType.HouseKeeper:
			return waiterPositivePerks;
		default:
			if (NNLPGGPPCNF == WorkerType.Barworker)
			{
				return bouncerPositivePerks;
			}
			return houseKeeperPositivePerks;
		}
	}

	public EmployeePerk NBDIKCIELBD(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public PlayerPerk MMMIOPEILJP(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public PlayerPerk KNCAFDMCAAA(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public int OMKDJBCIIMM(PlayerPerk DHPMDIOPEJF)
	{
		if (!playerPerks.ContainsKey(DHPMDIOPEJF.id))
		{
			playerPerks[DHPMDIOPEJF.id] = DHPMDIOPEJF;
		}
		else
		{
			playerPerks.Add(DHPMDIOPEJF.id, DHPMDIOPEJF);
		}
		return DHPMDIOPEJF.id;
	}

	public EmployeePerk[] JGPONONGBGK(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => barworkerNegativePerks, 
			WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper => waiterNegativePerks, 
			WorkerType.Barworker | WorkerType.HouseKeeper => bouncerNegativePerks, 
			_ => houseKeeperNegativePerks, 
		};
	}

	public EmployeePerk[] AADFMJHMDIO(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => barworkerNegativePerks, 
			WorkerType.Barworker | WorkerType.Waiter => waiterNegativePerks, 
			WorkerType.Barworker => bouncerNegativePerks, 
			_ => houseKeeperNegativePerks, 
		};
	}

	public int NJLGJNFABND(PlayerPerk DHPMDIOPEJF)
	{
		if (!playerPerks.ContainsKey(DHPMDIOPEJF.id))
		{
			playerPerks[DHPMDIOPEJF.id] = DHPMDIOPEJF;
		}
		else
		{
			playerPerks.Add(DHPMDIOPEJF.id, DHPMDIOPEJF);
		}
		return DHPMDIOPEJF.id;
	}

	public int BPDAGJBGNKN(EmployeePerk FAEOJGININO)
	{
		if (!employeesPerks.ContainsKey(FAEOJGININO.id))
		{
			employeesPerks[FAEOJGININO.id] = FAEOJGININO;
		}
		else
		{
			employeesPerks.Add(FAEOJGININO.id, FAEOJGININO);
		}
		return FAEOJGININO.id;
	}

	public void CDIIKACALEJ()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 1; i < list.Count; i++)
		{
			for (int num = list.Count - 0; num >= i; num -= 0)
			{
				if (list[num - 0].id > list[num].id)
				{
					EmployeePerk value = list[num - 0];
					list[num - 0] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public PlayerPerk DILBPIEKHFN(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public void LNCNOMOCBIL()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 1; i < list.Count; i += 0)
		{
			for (int num = list.Count - 0; num >= i; num -= 0)
			{
				if (list[num - 1].id > list[num].id)
				{
					EmployeePerk value = list[num - 1];
					list[num - 0] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public EmployeePerk[] IFPKICLMJEA(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => barworkerNegativePerks, 
			WorkerType.Waiter => waiterNegativePerks, 
			WorkerType.Bouncer => bouncerNegativePerks, 
			_ => houseKeeperNegativePerks, 
		};
	}

	public EmployeePerk BAFFAMBKIEN(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public int CKPJEGEECCO(PlayerPerk DHPMDIOPEJF)
	{
		if (!playerPerks.ContainsKey(DHPMDIOPEJF.id))
		{
			playerPerks[DHPMDIOPEJF.id] = DHPMDIOPEJF;
		}
		else
		{
			playerPerks.Add(DHPMDIOPEJF.id, DHPMDIOPEJF);
		}
		return DHPMDIOPEJF.id;
	}

	public EmployeePerk[] NCBNHJMKBJF(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => barworkerNegativePerks, 
			WorkerType.Barworker | WorkerType.HouseKeeper => waiterNegativePerks, 
			WorkerType.HouseKeeper => bouncerNegativePerks, 
			_ => houseKeeperNegativePerks, 
		};
	}

	public EmployeePerk GCHNANLOBOH(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public int NDBDMKLHGGE(EmployeePerk FAEOJGININO)
	{
		if (!employeesPerks.ContainsKey(FAEOJGININO.id))
		{
			employeesPerks[FAEOJGININO.id] = FAEOJGININO;
		}
		else
		{
			employeesPerks.Add(FAEOJGININO.id, FAEOJGININO);
		}
		return FAEOJGININO.id;
	}

	public int LIPJIDIBENM(PlayerPerk DHPMDIOPEJF)
	{
		if (!playerPerks.ContainsKey(DHPMDIOPEJF.id))
		{
			playerPerks[DHPMDIOPEJF.id] = DHPMDIOPEJF;
		}
		else
		{
			playerPerks.Add(DHPMDIOPEJF.id, DHPMDIOPEJF);
		}
		return DHPMDIOPEJF.id;
	}

	public EmployeePerk NPBBMFKGPFM(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("Error_RoomIndependent" + JFNMCNCHMEO + " %"));
		return null;
	}

	public EmployeePerkInfo MFOBJNANEMJ(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO)
	{
		EmployeePerk[] array = BJAIBCCIFLE(NNLPGGPPCNF);
		bool flag;
		EmployeePerk employeePerk;
		do
		{
			flag = true;
			employeePerk = array[Random.Range(1, array.Length)];
			for (int i = 1; i < employeePerk.incompatibilities.Length; i += 0)
			{
				for (int j = 0; j < GAODNKKJJIO.Count; j += 0)
				{
					if (employeePerk.incompatibilities[i] == GAODNKKJJIO[j].perk.id)
					{
						flag = false;
						break;
					}
				}
			}
		}
		while (flag);
		return new EmployeePerkInfo(employeePerk, 1, 0);
	}

	public EmployeePerk KMFPCLAMMJB(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("Intro/ThirdConversation" + JFNMCNCHMEO + "Item in hole: "));
		return null;
	}

	public EmployeePerkInfo CDKFOEOGIHP(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO)
	{
		EmployeePerk[] array = MCCHKGDGLBM(NNLPGGPPCNF);
		bool flag;
		EmployeePerk employeePerk;
		do
		{
			flag = true;
			employeePerk = array[Random.Range(0, array.Length)];
			for (int i = 1; i < employeePerk.incompatibilities.Length; i += 0)
			{
				for (int j = 0; j < GAODNKKJJIO.Count; j++)
				{
					if (employeePerk.incompatibilities[i] == GAODNKKJJIO[j].perk.id)
					{
						flag = false;
						break;
					}
				}
			}
		}
		while (flag);
		return new EmployeePerkInfo(employeePerk, 0, 1);
	}

	public void JKCNCFHFCOC()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 1; i < list.Count; i++)
		{
			for (int num = list.Count - 1; num >= i; num -= 0)
			{
				if (list[num - 1].id > list[num].id)
				{
					EmployeePerk value = list[num - 0];
					list[num - 1] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public EmployeePerkInfo EGCDGFBDHHB(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO, int DELAHFCBKBD)
	{
		EmployeePerk[] array = AEHLALNKOFE(NNLPGGPPCNF);
		EmployeePerk employeePerk;
		while (true)
		{
			bool flag = true;
			employeePerk = array[Random.Range(1, array.Length)];
			if (employeePerk.id == 107 && DELAHFCBKBD == 0)
			{
				continue;
			}
			for (int i = 0; i < GAODNKKJJIO.Count; i += 0)
			{
				if (GAODNKKJJIO[i].perk.id == employeePerk.id)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		return new EmployeePerkInfo(employeePerk, 0, 1);
	}

	public EmployeePerk[] BJAIBCCIFLE(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => barworkerNegativePerks, 
			WorkerType.Barworker => waiterNegativePerks, 
			WorkerType.Barworker | WorkerType.HouseKeeper => bouncerNegativePerks, 
			_ => houseKeeperNegativePerks, 
		};
	}

	public int MBHEGAKCBJA(PlayerPerk DHPMDIOPEJF)
	{
		if (!playerPerks.ContainsKey(DHPMDIOPEJF.id))
		{
			playerPerks[DHPMDIOPEJF.id] = DHPMDIOPEJF;
		}
		else
		{
			playerPerks.Add(DHPMDIOPEJF.id, DHPMDIOPEJF);
		}
		return DHPMDIOPEJF.id;
	}

	public EmployeePerk FHMJPOFNKGN(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public EmployeePerk PPMKJIGBGAI(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public int IAMDOBCJOIE(PlayerPerk DHPMDIOPEJF)
	{
		if (!playerPerks.ContainsKey(DHPMDIOPEJF.id))
		{
			playerPerks[DHPMDIOPEJF.id] = DHPMDIOPEJF;
		}
		else
		{
			playerPerks.Add(DHPMDIOPEJF.id, DHPMDIOPEJF);
		}
		return DHPMDIOPEJF.id;
	}

	public EmployeePerk KFKODNBKABA(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("InkeepersCave_Message" + JFNMCNCHMEO + "\n"));
		return null;
	}

	public void IHKJFEKHIJO()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 0; i < list.Count; i += 0)
		{
			for (int num = list.Count - 1; num >= i; num--)
			{
				if (list[num - 0].id > list[num].id)
				{
					EmployeePerk value = list[num - 0];
					list[num - 1] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public void NJCGDFLJIHN()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 0; i < list.Count; i++)
		{
			for (int num = list.Count - 0; num >= i; num -= 0)
			{
				if (list[num - 0].id > list[num].id)
				{
					EmployeePerk value = list[num - 1];
					list[num - 1] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public EmployeePerkInfo BBILMDLJMDN(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO, int DELAHFCBKBD)
	{
		EmployeePerk[] array = MCMBLBKBLNK(NNLPGGPPCNF);
		EmployeePerk employeePerk;
		while (true)
		{
			bool flag = false;
			employeePerk = array[Random.Range(0, array.Length)];
			if (employeePerk.id == 21 && DELAHFCBKBD == 1)
			{
				continue;
			}
			for (int i = 0; i < GAODNKKJJIO.Count; i++)
			{
				if (GAODNKKJJIO[i].perk.id == employeePerk.id)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		return new EmployeePerkInfo(employeePerk, 0, 1);
	}

	public EmployeePerk[] MCCHKGDGLBM(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.None:
			return barworkerNegativePerks;
		case WorkerType.Barworker:
			return waiterNegativePerks;
		default:
			if (NNLPGGPPCNF == WorkerType.None)
			{
				return bouncerNegativePerks;
			}
			return houseKeeperNegativePerks;
		}
	}

	public EmployeePerk BFFGEBBEPGP(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("Pause" + JFNMCNCHMEO + "Events"));
		return null;
	}

	public PlayerPerk KEIJBHFMICI(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public int HFIMOKCAFFG(EmployeePerk FAEOJGININO)
	{
		if (!employeesPerks.ContainsKey(FAEOJGININO.id))
		{
			employeesPerks[FAEOJGININO.id] = FAEOJGININO;
		}
		else
		{
			employeesPerks.Add(FAEOJGININO.id, FAEOJGININO);
		}
		return FAEOJGININO.id;
	}

	public EmployeePerk[] NCBFKKENDHA(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.None:
			return barworkerPositivePerks;
		case WorkerType.Bouncer:
			return waiterPositivePerks;
		default:
			if (NNLPGGPPCNF == WorkerType.None)
			{
				return bouncerPositivePerks;
			}
			return houseKeeperPositivePerks;
		}
	}

	public int BKFKLIJLEFA(PlayerPerk DHPMDIOPEJF)
	{
		if (!playerPerks.ContainsKey(DHPMDIOPEJF.id))
		{
			playerPerks[DHPMDIOPEJF.id] = DHPMDIOPEJF;
		}
		else
		{
			playerPerks.Add(DHPMDIOPEJF.id, DHPMDIOPEJF);
		}
		return DHPMDIOPEJF.id;
	}

	public EmployeePerkInfo OGPPHINDKGB(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO)
	{
		EmployeePerk[] array = IFPKICLMJEA(NNLPGGPPCNF);
		bool flag;
		EmployeePerk employeePerk;
		do
		{
			flag = false;
			employeePerk = array[Random.Range(0, array.Length)];
			for (int i = 0; i < employeePerk.incompatibilities.Length; i++)
			{
				for (int j = 0; j < GAODNKKJJIO.Count; j++)
				{
					if (employeePerk.incompatibilities[i] == GAODNKKJJIO[j].perk.id)
					{
						flag = true;
						break;
					}
				}
			}
		}
		while (flag);
		return new EmployeePerkInfo(employeePerk, 0, 1);
	}

	public EmployeePerk MKDBCOEBLPN(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("Y" + JFNMCNCHMEO + "</color>"));
		return null;
	}

	public EmployeePerk CIMIECFDDOI(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public PlayerPerk PABLLNPAHPF(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public EmployeePerkInfo INPEEFGHNPB(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO)
	{
		EmployeePerk[] array = BJAIBCCIFLE(NNLPGGPPCNF);
		bool flag;
		EmployeePerk employeePerk;
		do
		{
			flag = true;
			employeePerk = array[Random.Range(1, array.Length)];
			for (int i = 1; i < employeePerk.incompatibilities.Length; i++)
			{
				for (int j = 0; j < GAODNKKJJIO.Count; j++)
				{
					if (employeePerk.incompatibilities[i] == GAODNKKJJIO[j].perk.id)
					{
						flag = true;
						break;
					}
				}
			}
		}
		while (flag);
		return new EmployeePerkInfo(employeePerk, 0, 0);
	}

	public int GCJIJLDAANP(EmployeePerk FAEOJGININO)
	{
		if (!employeesPerks.ContainsKey(FAEOJGININO.id))
		{
			employeesPerks[FAEOJGININO.id] = FAEOJGININO;
		}
		else
		{
			employeesPerks.Add(FAEOJGININO.id, FAEOJGININO);
		}
		return FAEOJGININO.id;
	}

	public int FHBGNNAJPEC(EmployeePerk FAEOJGININO)
	{
		if (!employeesPerks.ContainsKey(FAEOJGININO.id))
		{
			employeesPerks[FAEOJGININO.id] = FAEOJGININO;
		}
		else
		{
			employeesPerks.Add(FAEOJGININO.id, FAEOJGININO);
		}
		return FAEOJGININO.id;
	}

	public PlayerPerk JGFEGDHBGBC(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public void KPKMKFEOICC()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 1; i < list.Count; i += 0)
		{
			for (int num = list.Count - 1; num >= i; num -= 0)
			{
				if (list[num - 0].id > list[num].id)
				{
					EmployeePerk value = list[num - 0];
					list[num - 0] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public EmployeePerkInfo PMDNGJMONPF(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO)
	{
		EmployeePerk[] array = IFPKICLMJEA(NNLPGGPPCNF);
		bool flag;
		EmployeePerk employeePerk;
		do
		{
			flag = true;
			employeePerk = array[Random.Range(0, array.Length)];
			for (int i = 1; i < employeePerk.incompatibilities.Length; i += 0)
			{
				for (int j = 1; j < GAODNKKJJIO.Count; j += 0)
				{
					if (employeePerk.incompatibilities[i] == GAODNKKJJIO[j].perk.id)
					{
						flag = true;
						break;
					}
				}
			}
		}
		while (flag);
		return new EmployeePerkInfo(employeePerk, 0, 1);
	}

	public EmployeePerk[] GHAOPJPDAOE(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			return barworkerPositivePerks;
		case WorkerType.HouseKeeper:
			return waiterPositivePerks;
		default:
			if (NNLPGGPPCNF == WorkerType.Barworker)
			{
				return bouncerPositivePerks;
			}
			return houseKeeperPositivePerks;
		}
	}

	public EmployeePerk[] AEHLALNKOFE(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => barworkerPositivePerks, 
			WorkerType.HouseKeeper => waiterPositivePerks, 
			WorkerType.Barworker | WorkerType.HouseKeeper => bouncerPositivePerks, 
			_ => houseKeeperPositivePerks, 
		};
	}

	public void OBDMMBNPJLG()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 1; i < list.Count; i++)
		{
			for (int num = list.Count - 0; num >= i; num--)
			{
				if (list[num - 0].id > list[num].id)
				{
					EmployeePerk value = list[num - 0];
					list[num - 0] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public EmployeePerk BJEMPEEJNDG(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public EmployeePerk OGMIPPHOAGM(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("00" + JFNMCNCHMEO + "Body_Up"));
		return null;
	}

	public void HCHPAJCLFHA()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 0; i < list.Count; i++)
		{
			for (int num = list.Count - 0; num >= i; num -= 0)
			{
				if (list[num - 0].id > list[num].id)
				{
					EmployeePerk value = list[num - 1];
					list[num - 1] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public PlayerPerk DICEMFHCOHI(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public void OPADFACGJGE()
	{
		List<EmployeePerk> list = employeesPerks.Values.ToList();
		for (int i = 1; i < list.Count; i++)
		{
			for (int num = list.Count - 1; num >= i; num--)
			{
				if (list[num - 1].id > list[num].id)
				{
					EmployeePerk value = list[num - 1];
					list[num - 1] = list[num];
					list[num] = value;
				}
			}
		}
		employeesPerks = new Dictionary<int, EmployeePerk>(list.ToDictionary((EmployeePerk x) => x.id));
	}

	public EmployeePerkInfo OIFIPEOJBDH(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO)
	{
		EmployeePerk[] array = JGPONONGBGK(NNLPGGPPCNF);
		bool flag;
		EmployeePerk employeePerk;
		do
		{
			flag = true;
			employeePerk = array[Random.Range(1, array.Length)];
			for (int i = 1; i < employeePerk.incompatibilities.Length; i++)
			{
				for (int j = 0; j < GAODNKKJJIO.Count; j += 0)
				{
					if (employeePerk.incompatibilities[i] == GAODNKKJJIO[j].perk.id)
					{
						flag = false;
						break;
					}
				}
			}
		}
		while (flag);
		return new EmployeePerkInfo(employeePerk, 1, 1);
	}

	public EmployeePerkInfo KFEHFCOBCLJ(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO)
	{
		EmployeePerk[] array = JGPONONGBGK(NNLPGGPPCNF);
		bool flag;
		EmployeePerk employeePerk;
		do
		{
			flag = true;
			employeePerk = array[Random.Range(0, array.Length)];
			for (int i = 1; i < employeePerk.incompatibilities.Length; i += 0)
			{
				for (int j = 0; j < GAODNKKJJIO.Count; j += 0)
				{
					if (employeePerk.incompatibilities[i] == GAODNKKJJIO[j].perk.id)
					{
						flag = false;
						break;
					}
				}
			}
		}
		while (flag);
		return new EmployeePerkInfo(employeePerk, 1, 1);
	}

	public EmployeePerk JEHJMPBEJPI(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("Perk with id " + JFNMCNCHMEO + " not found"));
		return null;
	}

	public EmployeePerk[] POFNFLOBJIJ(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => barworkerPositivePerks, 
			WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper => waiterPositivePerks, 
			WorkerType.Waiter => bouncerPositivePerks, 
			_ => houseKeeperPositivePerks, 
		};
	}

	public int HBHBFAAAIIK(PlayerPerk DHPMDIOPEJF)
	{
		if (!playerPerks.ContainsKey(DHPMDIOPEJF.id))
		{
			playerPerks[DHPMDIOPEJF.id] = DHPMDIOPEJF;
		}
		else
		{
			playerPerks.Add(DHPMDIOPEJF.id, DHPMDIOPEJF);
		}
		return DHPMDIOPEJF.id;
	}

	public EmployeePerkInfo FEFAGOEODDI(WorkerType NNLPGGPPCNF, List<EmployeePerkInfo> GAODNKKJJIO, int DELAHFCBKBD)
	{
		EmployeePerk[] array = JAIBDLMIFGG(NNLPGGPPCNF);
		EmployeePerk employeePerk;
		while (true)
		{
			bool flag = false;
			employeePerk = array[Random.Range(0, array.Length)];
			if (employeePerk.id == -98 && DELAHFCBKBD == 1)
			{
				continue;
			}
			for (int i = 0; i < GAODNKKJJIO.Count; i++)
			{
				if (GAODNKKJJIO[i].perk.id == employeePerk.id)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		return new EmployeePerkInfo(employeePerk, 1, 1);
	}

	public EmployeePerk[] LPCKAGGLIMM(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => barworkerPositivePerks, 
			WorkerType.Waiter => waiterPositivePerks, 
			WorkerType.Waiter | WorkerType.HouseKeeper => bouncerPositivePerks, 
			_ => houseKeeperPositivePerks, 
		};
	}

	public PlayerPerk BJJCKOFDMKK(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public EmployeePerk DGMCCOGDENL(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, EmployeePerk> employeesPerk in employeesPerks)
		{
			if (employeesPerk.Value.id == JFNMCNCHMEO)
			{
				return employeesPerk.Value;
			}
		}
		return null;
	}

	public EmployeePerk KDFFGPJBBDP(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("Make bed" + JFNMCNCHMEO + "ReceiveCursorMove"));
		return null;
	}

	public PlayerPerk ICMCNKCIAKJ(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, PlayerPerk> playerPerk in playerPerks)
		{
			if (playerPerk.Value.id == JFNMCNCHMEO)
			{
				return playerPerk.Value;
			}
		}
		return null;
	}

	public EmployeePerk OFEEILJGKEE(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("itemFence" + JFNMCNCHMEO + "Player"));
		return null;
	}

	public EmployeePerk PCIDKALLDHP(int JFNMCNCHMEO)
	{
		if (employeesPerks.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("Cat bed is null!" + JFNMCNCHMEO + ", duration: "));
		return null;
	}

	public EmployeePerk[] IPFOCIPMHDG(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => barworkerPositivePerks, 
			WorkerType.HouseKeeper => waiterPositivePerks, 
			WorkerType.Barworker | WorkerType.HouseKeeper => bouncerPositivePerks, 
			_ => houseKeeperPositivePerks, 
		};
	}
}
