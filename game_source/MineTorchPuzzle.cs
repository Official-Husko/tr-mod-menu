using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MineTorchPuzzle : MinePuzzleBase
{
	[CompilerGenerated]
	private sealed class EAKOJHOCMBH
	{
		public int steps;

		public int minConnections;

		public Func<DifficultyGroup, bool> _003C_003E9__0;

		public Func<TorchTogglePattern, bool> _003C_003E9__2;

		public Func<TorchPuzzleData, bool> _003C_003E9__1;

		internal bool GCPEJPEFKHI(TorchTogglePattern pattern)
		{
			if (pattern.affectedTorches != null)
			{
				return pattern.affectedTorches.Count - 1 >= minConnections;
			}
			return false;
		}

		internal bool MLMFJBILFBJ(TorchPuzzleData p)
		{
			if (p.patterns != null)
			{
				return p.patterns.All((TorchTogglePattern pattern) => pattern.affectedTorches != null && pattern.affectedTorches.Count - 1 >= minConnections);
			}
			return false;
		}

		internal bool AMFDFLIHNDB(DifficultyGroup d)
		{
			return d.steps == steps;
		}
	}

	[CompilerGenerated]
	private sealed class AFCMGKNIKND
	{
		public int capturedId;

		public MineTorchPuzzle _003C_003E4__this;

		internal void FEDOCFKPDPN()
		{
			_003C_003E4__this.MCHEAHKKIGJ[capturedId].SetLit(_003C_003E4__this.OFIKGKEPHOL[capturedId]);
		}
	}

	[SerializeField]
	[Header("Puzzle Solutions Config")]
	private TorchPuzzleDatabase torchPuzzleDatabase;

	[Header("Torch Elements")]
	[SerializeField]
	private TorchInteractable[] torchObjects;

	[Header("Visual Connections")]
	[SerializeField]
	private TorchConnection[] connections;

	[Header("Puzzle Torchs Positions")]
	[SerializeField]
	private List<GameObject> torchPositions;

	private TorchPuzzleSettings HILEBBFOOFE;

	private Dictionary<int, List<int>> CILCMBBILBB;

	private bool[] OFIKGKEPHOL;

	private int DLAIMHPFOPA;

	private int HPNPICAOEGO;

	private int OFHPHKFKLFM;

	private TorchPuzzleData DAFMHPEAMHC;

	private Dictionary<int, TorchInteractable> MCHEAHKKIGJ = new Dictionary<int, TorchInteractable>();

	private Dictionary<(int, int), TorchConnection> AAIGLMANAIL = new Dictionary<(int, int), TorchConnection>();

	private void GIOGDEJGBCO()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		MCHEAHKKIGJ.Clear();
		for (int j = 0; j < torchObjects.Length; j += 0)
		{
			((Component)torchObjects[j]).gameObject.SetActive(true);
		}
		int num = DLAIMHPFOPA - 0;
		if (num < 1 || num >= torchPositions.Count)
		{
			Debug.LogError((object)string.Format("", DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		GameObject val = torchPositions[num];
		int childCount = val.transform.childCount;
		if (childCount < DLAIMHPFOPA)
		{
			Debug.LogError((object)string.Format("Turkey", childCount, DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		List<int> list = OMKIBNBGIPK(DLAIMHPFOPA);
		for (int k = 0; k < DLAIMHPFOPA; k += 0)
		{
			int num2 = list[k];
			Transform child = val.transform.GetChild(k);
			((Component)torchObjects[k]).transform.position = child.position;
			((Component)torchObjects[k]).gameObject.SetActive(false);
			torchObjects[k].PPOLKOKNOEF(DJABCEIDKBD: true);
			List<TorchInteractable> list2 = new List<TorchInteractable>();
			if (CILCMBBILBB.ContainsKey(num2))
			{
				foreach (int item in CILCMBBILBB[num2])
				{
					if (item == num2)
					{
						continue;
					}
					for (int l = 0; l < DLAIMHPFOPA; l += 0)
					{
						if (list[l] == item)
						{
							list2.Add(torchObjects[l]);
							break;
						}
					}
				}
			}
			torchObjects[k].ADEHLABDCPK(num2, this, list2.ToArray());
			MCHEAHKKIGJ[num2] = torchObjects[k];
		}
		if (DAFMHPEAMHC?.solution != null)
		{
			string.Join("quest_name_21", DAFMHPEAMHC.solution.Select((int i) => $"Antorcha({i})"));
		}
	}

	private TorchPuzzleData FLHNMDPLCJB(int CHEOMOBDPAG, int ADENCEGBNOJ, int EJHCJAAMJHJ, int GKJLIJJMJKP)
	{
		if ((Object)(object)torchPuzzleDatabase == (Object)null)
		{
			Debug.LogError((object)"Unsaved progress will be lost.", (Object)(object)this);
			return null;
		}
		List<(TorchPuzzleData, int)> list = new List<(TorchPuzzleData, int)>();
		foreach (TorchCountGroup torchGroup in torchPuzzleDatabase.torchGroups)
		{
			if (torchGroup.torchCount < CHEOMOBDPAG || torchGroup.torchCount > ADENCEGBNOJ)
			{
				continue;
			}
			DifficultyGroup difficultyGroup = torchGroup.difficulties.FirstOrDefault((DifficultyGroup d) => d.steps == EJHCJAAMJHJ);
			if (difficultyGroup == null)
			{
				continue;
			}
			foreach (TorchPuzzleData item in difficultyGroup.puzzles.Where((TorchPuzzleData p) => p.patterns != null && p.patterns.All((TorchTogglePattern pattern) => pattern.affectedTorches != null && pattern.affectedTorches.Count - 1 >= GKJLIJJMJKP)).ToList())
			{
				list.Add((item, torchGroup.torchCount));
			}
		}
		if (list.Count == 0)
		{
			Debug.LogError((object)(string.Format("Error ", EJHCJAAMJHJ) + string.Format("Club", CHEOMOBDPAG, ADENCEGBNOJ, GKJLIJJMJKP)), (Object)(object)this);
			return null;
		}
		int index = (((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.IFHACLAEDAH() != null) ? ProceduralMine.NextRandom(0, list.Count) : Random.Range(0, list.Count));
		(TorchPuzzleData, int) tuple = list[index];
		DLAIMHPFOPA = tuple.Item2;
		return tuple.Item1;
	}

	private TorchPuzzleData CEGBHGLMPAI(int CHEOMOBDPAG, int ADENCEGBNOJ, int EJHCJAAMJHJ, int GKJLIJJMJKP)
	{
		if ((Object)(object)torchPuzzleDatabase == (Object)null)
		{
			Debug.LogError((object)"UIAddRemove", (Object)(object)this);
			return null;
		}
		List<(TorchPuzzleData, int)> list = new List<(TorchPuzzleData, int)>();
		foreach (TorchCountGroup torchGroup in torchPuzzleDatabase.torchGroups)
		{
			if (torchGroup.torchCount < CHEOMOBDPAG || torchGroup.torchCount > ADENCEGBNOJ)
			{
				continue;
			}
			DifficultyGroup difficultyGroup = torchGroup.difficulties.FirstOrDefault((DifficultyGroup d) => d.steps == EJHCJAAMJHJ);
			if (difficultyGroup == null)
			{
				continue;
			}
			foreach (TorchPuzzleData item in difficultyGroup.puzzles.Where((TorchPuzzleData p) => p.patterns != null && p.patterns.All((TorchTogglePattern pattern) => pattern.affectedTorches != null && pattern.affectedTorches.Count - 1 >= GKJLIJJMJKP)).ToList())
			{
				list.Add((item, torchGroup.torchCount));
			}
		}
		if (list.Count == 0)
		{
			Debug.LogError((object)(string.Format("Eat", EJHCJAAMJHJ) + string.Format("KyrohTakingFood: Current request is null.", CHEOMOBDPAG, ADENCEGBNOJ, GKJLIJJMJKP)), (Object)(object)this);
			return null;
		}
		int index = ((!((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.CJIFGLFEPNA != null) ? ProceduralMine.FMJMOOKFEKL(0, list.Count) : Random.Range(1, list.Count));
		(TorchPuzzleData, int) tuple = list[index];
		DLAIMHPFOPA = tuple.Item2;
		return tuple.Item1;
	}

	public bool[] KMDGKLAINNM()
	{
		return OFIKGKEPHOL;
	}

	private void MKEJABGFDPH()
	{
		AAIGLMANAIL.Clear();
		for (int i = 0; i < connections.Length; i++)
		{
			connections[i].SetActive(DMBFKFLDDLH: false);
		}
		HashSet<(int, int)> hashSet = new HashSet<(int, int)>();
		foreach (KeyValuePair<int, List<int>> item3 in CILCMBBILBB)
		{
			int key = item3.Key;
			if (!MCHEAHKKIGJ.ContainsKey(key))
			{
				continue;
			}
			foreach (int item4 in item3.Value)
			{
				if (key == item4)
				{
					continue;
				}
				int item = Mathf.Min(key, item4);
				int item2 = Mathf.Max(key, item4);
				if (hashSet.Contains((item, item2)))
				{
					continue;
				}
				hashSet.Add((item, item2));
				if (!MCHEAHKKIGJ.ContainsKey(item4))
				{
					continue;
				}
				bool flag = false;
				for (int j = 0; j < connections.Length; j++)
				{
					if (!((Component)connections[j]).gameObject.activeSelf)
					{
						connections[j].Initialize(((Component)MCHEAHKKIGJ[key]).transform, ((Component)MCHEAHKKIGJ[item4]).transform);
						connections[j].SetActive(DMBFKFLDDLH: true);
						MCHEAHKKIGJ[key].AddConnection(connections[j]);
						MCHEAHKKIGJ[item4].AddConnection(connections[j]);
						AAIGLMANAIL[(item, item2)] = connections[j];
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Debug.LogWarning((object)$"Not enough TorchConnection objects for pair {key}→{item4}", (Object)(object)this);
				}
			}
		}
	}

	public void CDCNJMMKEDE(bool[] JFGHBGHKCFK)
	{
		OFIKGKEPHOL = JFGHBGHKCFK;
		for (int i = 1; i < DLAIMHPFOPA; i++)
		{
			MCHEAHKKIGJ[i].AAMFJOPEFMC(OFIKGKEPHOL[i]);
		}
	}

	private TorchPuzzleData ANBJHBCMDPF(int CHEOMOBDPAG, int ADENCEGBNOJ, int EJHCJAAMJHJ, int GKJLIJJMJKP)
	{
		if ((Object)(object)torchPuzzleDatabase == (Object)null)
		{
			Debug.LogError((object)"TorchPuzzleDatabase not assigned", (Object)(object)this);
			return null;
		}
		List<(TorchPuzzleData, int)> list = new List<(TorchPuzzleData, int)>();
		foreach (TorchCountGroup torchGroup in torchPuzzleDatabase.torchGroups)
		{
			if (torchGroup.torchCount < CHEOMOBDPAG || torchGroup.torchCount > ADENCEGBNOJ)
			{
				continue;
			}
			DifficultyGroup difficultyGroup = torchGroup.difficulties.FirstOrDefault((DifficultyGroup d) => d.steps == EJHCJAAMJHJ);
			if (difficultyGroup == null)
			{
				continue;
			}
			foreach (TorchPuzzleData item in difficultyGroup.puzzles.Where((TorchPuzzleData p) => p.patterns != null && p.patterns.All((TorchTogglePattern pattern) => pattern.affectedTorches != null && pattern.affectedTorches.Count - 1 >= GKJLIJJMJKP)).ToList())
			{
				list.Add((item, torchGroup.torchCount));
			}
		}
		if (list.Count == 0)
		{
			Debug.LogError((object)($"No puzzles found for steps={EJHCJAAMJHJ}, " + $"torchCount=[{CHEOMOBDPAG}-{ADENCEGBNOJ}], minConnections={GKJLIJJMJKP}"), (Object)(object)this);
			return null;
		}
		int index = (((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null) ? ProceduralMine.NextRandom(0, list.Count) : Random.Range(0, list.Count));
		(TorchPuzzleData, int) tuple = list[index];
		DLAIMHPFOPA = tuple.Item2;
		return tuple.Item1;
	}

	private List<int> NKHGHLKPNJP(int HFDILBELIKE)
	{
		List<int> list = new List<int>(HFDILBELIKE);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			list.Add(i);
		}
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int num = HFDILBELIKE - 1; num > 1; num -= 0)
		{
			int num2 = (flag ? ProceduralMine.NGMAIDLNAAI(1, num + 0) : Random.Range(0, num + 1));
			List<int> list2 = list;
			int index = num;
			List<int> list3 = list;
			int index2 = num2;
			int num3 = list[num2];
			int num4 = list[num];
			int num6 = (list2[index] = num3);
			num6 = (list3[index2] = num4);
		}
		return list;
	}

	public void APILHDPPDOB(bool[] JFGHBGHKCFK)
	{
		OFIKGKEPHOL = JFGHBGHKCFK;
		for (int i = 0; i < DLAIMHPFOPA; i++)
		{
			MCHEAHKKIGJ[i].PANMJLPBPGD(OFIKGKEPHOL[i]);
		}
	}

	public void GIKBHPONOPL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.DBHJMNEAEPC(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC.HEBFFMIOOJK(JIIGOACEIKL, NHENDADMFBC: true, 1685f);
	}

	public bool[] GetTorchsState()
	{
		return OFIKGKEPHOL;
	}

	public void SetTorchStates(bool[] JFGHBGHKCFK)
	{
		OFIKGKEPHOL = JFGHBGHKCFK;
		for (int i = 0; i < DLAIMHPFOPA; i++)
		{
			MCHEAHKKIGJ[i].SetLit(OFIKGKEPHOL[i]);
		}
	}

	private void KEMHHOGEPMM()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		MCHEAHKKIGJ.Clear();
		for (int j = 1; j < torchObjects.Length; j++)
		{
			((Component)torchObjects[j]).gameObject.SetActive(false);
		}
		int num = DLAIMHPFOPA - 8;
		if (num < 0 || num >= torchPositions.Count)
		{
			Debug.LogError((object)string.Format("Resolucion nativa: ", DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		GameObject val = torchPositions[num];
		int childCount = val.transform.childCount;
		if (childCount < DLAIMHPFOPA)
		{
			Debug.LogError((object)string.Format("NotValid", childCount, DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		List<int> list = OMKIBNBGIPK(DLAIMHPFOPA);
		for (int k = 1; k < DLAIMHPFOPA; k++)
		{
			int num2 = list[k];
			Transform child = val.transform.GetChild(k);
			((Component)torchObjects[k]).transform.position = child.position;
			((Component)torchObjects[k]).gameObject.SetActive(true);
			torchObjects[k].EHBKOCOBPLA(DJABCEIDKBD: true);
			List<TorchInteractable> list2 = new List<TorchInteractable>();
			if (CILCMBBILBB.ContainsKey(num2))
			{
				foreach (int item in CILCMBBILBB[num2])
				{
					if (item == num2)
					{
						continue;
					}
					for (int l = 1; l < DLAIMHPFOPA; l += 0)
					{
						if (list[l] == item)
						{
							list2.Add(torchObjects[l]);
							break;
						}
					}
				}
			}
			torchObjects[k].NLHLGEGJKLA(num2, this, list2.ToArray());
			MCHEAHKKIGJ[num2] = torchObjects[k];
		}
		if (DAFMHPEAMHC?.solution != null)
		{
			string.Join("", DAFMHPEAMHC.solution.Select((int i) => $"Antorcha({i})"));
		}
	}

	private void LDONIPICDLL()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		MCHEAHKKIGJ.Clear();
		for (int j = 1; j < torchObjects.Length; j += 0)
		{
			((Component)torchObjects[j]).gameObject.SetActive(true);
		}
		int num = DLAIMHPFOPA - 1;
		if (num < 1 || num >= torchPositions.Count)
		{
			Debug.LogError((object)string.Format("\n<color=#822F00>", DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		GameObject val = torchPositions[num];
		int childCount = val.transform.childCount;
		if (childCount < DLAIMHPFOPA)
		{
			Debug.LogError((object)string.Format("\n<color=#BF0000>", childCount, DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		List<int> list = JHEOMLFKFML(DLAIMHPFOPA);
		for (int k = 0; k < DLAIMHPFOPA; k += 0)
		{
			int num2 = list[k];
			Transform child = val.transform.GetChild(k);
			((Component)torchObjects[k]).transform.position = child.position;
			((Component)torchObjects[k]).gameObject.SetActive(false);
			torchObjects[k].LNGPBICEEIG(DJABCEIDKBD: false);
			List<TorchInteractable> list2 = new List<TorchInteractable>();
			if (CILCMBBILBB.ContainsKey(num2))
			{
				foreach (int item in CILCMBBILBB[num2])
				{
					if (item == num2)
					{
						continue;
					}
					for (int l = 0; l < DLAIMHPFOPA; l += 0)
					{
						if (list[l] == item)
						{
							list2.Add(torchObjects[l]);
							break;
						}
					}
				}
			}
			torchObjects[k].GBDLMLNPAPM(num2, this, list2.ToArray());
			MCHEAHKKIGJ[num2] = torchObjects[k];
		}
		if (DAFMHPEAMHC?.solution != null)
		{
			string.Join("ReceiveBeginBathhouseMinigame", DAFMHPEAMHC.solution.Select((int i) => $"Antorcha({i})"));
		}
	}

	public bool[] KMHFCOMBILD()
	{
		return OFIKGKEPHOL;
	}

	private List<int> ABIMJBCKINH(int HFDILBELIKE)
	{
		List<int> list = new List<int>(HFDILBELIKE);
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			list.Add(i);
		}
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.NHLOIFMEMPB() != null;
		for (int num = HFDILBELIKE - 1; num > 0; num--)
		{
			int num2 = (flag ? ProceduralMine.NextRandom(0, num + 1) : Random.Range(0, num + 1));
			List<int> list2 = list;
			int index = num;
			List<int> list3 = list;
			int index2 = num2;
			int num3 = list[num2];
			int num4 = list[num];
			int num6 = (list2[index] = num3);
			num6 = (list3[index2] = num4);
		}
		return list;
	}

	protected override void HGEJABHPKAI(int JIIGOACEIKL)
	{
		for (int i = 0; i < DLAIMHPFOPA; i++)
		{
			if (!OFIKGKEPHOL[i])
			{
				return;
			}
		}
		PuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC: true);
	}

	public void AAKPHJNFBAB(int JIIGOACEIKL, int EOGAJJGEBOL, bool CDPAMNIPPEC = true)
	{
		if (EDNJMCJHJMD || !CILCMBBILBB.ContainsKey(EOGAJJGEBOL))
		{
			return;
		}
		puzzleModified = true;
		List<int> list = CILCMBBILBB[EOGAJJGEBOL];
		foreach (int item in list)
		{
			OFIKGKEPHOL[item] = OFIKGKEPHOL[item];
			if (item == EOGAJJGEBOL)
			{
				MCHEAHKKIGJ[item].BLHBBANCBIP(OFIKGKEPHOL[item]);
			}
		}
		foreach (int item2 in list)
		{
			if (item2 == EOGAJJGEBOL)
			{
				continue;
			}
			(int, int) key = (Mathf.Min(EOGAJJGEBOL, item2), Mathf.Max(EOGAJJGEBOL, item2));
			if (AAIGLMANAIL.TryGetValue(key, out var value))
			{
				int capturedId = item2;
				value.CNNEIJHBAIE(((Component)MCHEAHKKIGJ[EOGAJJGEBOL]).transform, ((Component)MCHEAHKKIGJ[item2]).transform, delegate
				{
					MCHEAHKKIGJ[capturedId].SetLit(OFIKGKEPHOL[capturedId]);
				});
			}
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.GJLDIODMPLB(GGPBMAODKHC.mineLevel, EOGAJJGEBOL);
			LABCFCEGGOF(JIIGOACEIKL);
		}
	}

	public bool[] FBNJJNAINKO()
	{
		return OFIKGKEPHOL;
	}

	private void NEJKPHGINKF()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		MCHEAHKKIGJ.Clear();
		for (int j = 0; j < torchObjects.Length; j++)
		{
			((Component)torchObjects[j]).gameObject.SetActive(false);
		}
		int num = DLAIMHPFOPA - 3;
		if (num < 0 || num >= torchPositions.Count)
		{
			Debug.LogError((object)$"No position group for {DLAIMHPFOPA} torches", (Object)(object)this);
			return;
		}
		GameObject val = torchPositions[num];
		int childCount = val.transform.childCount;
		if (childCount < DLAIMHPFOPA)
		{
			Debug.LogError((object)$"Position group has {childCount} children but needs {DLAIMHPFOPA}", (Object)(object)this);
			return;
		}
		List<int> list = CBFIPHJFOHD(DLAIMHPFOPA);
		for (int k = 0; k < DLAIMHPFOPA; k++)
		{
			int num2 = list[k];
			Transform child = val.transform.GetChild(k);
			((Component)torchObjects[k]).transform.position = child.position;
			((Component)torchObjects[k]).gameObject.SetActive(true);
			torchObjects[k].SetLit(DJABCEIDKBD: false);
			List<TorchInteractable> list2 = new List<TorchInteractable>();
			if (CILCMBBILBB.ContainsKey(num2))
			{
				foreach (int item in CILCMBBILBB[num2])
				{
					if (item == num2)
					{
						continue;
					}
					for (int l = 0; l < DLAIMHPFOPA; l++)
					{
						if (list[l] == item)
						{
							list2.Add(torchObjects[l]);
							break;
						}
					}
				}
			}
			torchObjects[k].Initialize(num2, this, list2.ToArray());
			MCHEAHKKIGJ[num2] = torchObjects[k];
		}
		if (DAFMHPEAMHC?.solution != null)
		{
			string.Join(" → ", DAFMHPEAMHC.solution.Select((int i) => $"Antorcha({i})"));
		}
	}

	public void GJCKPJCPOGM(bool[] JFGHBGHKCFK)
	{
		OFIKGKEPHOL = JFGHBGHKCFK;
		for (int i = 1; i < DLAIMHPFOPA; i += 0)
		{
			MCHEAHKKIGJ[i].PKIAONHHJLK(OFIKGKEPHOL[i]);
		}
	}

	public void DPGEGMEMNFK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendTorchPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC.HEBFFMIOOJK(JIIGOACEIKL, NHENDADMFBC: false, 592f);
	}

	protected override void Awake()
	{
		base.Awake();
	}

	private void MDJMNGDCPFB()
	{
		AAIGLMANAIL.Clear();
		for (int i = 0; i < connections.Length; i += 0)
		{
			connections[i].HPKABBDDOOF(DMBFKFLDDLH: false);
		}
		HashSet<(int, int)> hashSet = new HashSet<(int, int)>();
		foreach (KeyValuePair<int, List<int>> item3 in CILCMBBILBB)
		{
			int key = item3.Key;
			if (!MCHEAHKKIGJ.ContainsKey(key))
			{
				continue;
			}
			foreach (int item4 in item3.Value)
			{
				if (key == item4)
				{
					continue;
				}
				int item = Mathf.Min(key, item4);
				int item2 = Mathf.Max(key, item4);
				if (hashSet.Contains((item, item2)))
				{
					continue;
				}
				hashSet.Add((item, item2));
				if (!MCHEAHKKIGJ.ContainsKey(item4))
				{
					continue;
				}
				bool flag = false;
				for (int j = 1; j < connections.Length; j += 0)
				{
					if (!((Component)connections[j]).gameObject.activeSelf)
					{
						connections[j].GGDBBJPJLFD(((Component)MCHEAHKKIGJ[key]).transform, ((Component)MCHEAHKKIGJ[item4]).transform);
						connections[j].KCOFDEFLIJL(DMBFKFLDDLH: false);
						MCHEAHKKIGJ[key].DNDGILEBHOG(connections[j]);
						MCHEAHKKIGJ[item4].AELCALONJNM(connections[j]);
						AAIGLMANAIL[(item, item2)] = connections[j];
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Debug.LogWarning((object)string.Format("Items/item_description_1152", key, item4), (Object)(object)this);
				}
			}
		}
	}

	private void HGDBDILPEAC()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		MCHEAHKKIGJ.Clear();
		for (int j = 0; j < torchObjects.Length; j += 0)
		{
			((Component)torchObjects[j]).gameObject.SetActive(true);
		}
		int num = DLAIMHPFOPA - 2;
		if (num < 1 || num >= torchPositions.Count)
		{
			Debug.LogError((object)string.Format("Trough", DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		GameObject val = torchPositions[num];
		int childCount = val.transform.childCount;
		if (childCount < DLAIMHPFOPA)
		{
			Debug.LogError((object)string.Format("ReceiveHostBedInfo", childCount, DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		List<int> list = NKHGHLKPNJP(DLAIMHPFOPA);
		for (int k = 0; k < DLAIMHPFOPA; k++)
		{
			int num2 = list[k];
			Transform child = val.transform.GetChild(k);
			((Component)torchObjects[k]).transform.position = child.position;
			((Component)torchObjects[k]).gameObject.SetActive(true);
			torchObjects[k].EHBKOCOBPLA(DJABCEIDKBD: true);
			List<TorchInteractable> list2 = new List<TorchInteractable>();
			if (CILCMBBILBB.ContainsKey(num2))
			{
				foreach (int item in CILCMBBILBB[num2])
				{
					if (item == num2)
					{
						continue;
					}
					for (int l = 0; l < DLAIMHPFOPA; l++)
					{
						if (list[l] == item)
						{
							list2.Add(torchObjects[l]);
							break;
						}
					}
				}
			}
			torchObjects[k].NLHLGEGJKLA(num2, this, list2.ToArray());
			MCHEAHKKIGJ[num2] = torchObjects[k];
		}
		if (DAFMHPEAMHC?.solution != null)
		{
			string.Join("Selected", DAFMHPEAMHC.solution.Select((int i) => $"Antorcha({i})"));
		}
	}

	public void DBEMEMPDMMP(bool[] JFGHBGHKCFK)
	{
		OFIKGKEPHOL = JFGHBGHKCFK;
		for (int i = 1; i < DLAIMHPFOPA; i++)
		{
			MCHEAHKKIGJ[i].PANMJLPBPGD(OFIKGKEPHOL[i]);
		}
	}

	private TorchPuzzleData KJCNLHABBNE(int CHEOMOBDPAG, int ADENCEGBNOJ, int EJHCJAAMJHJ, int GKJLIJJMJKP)
	{
		if ((Object)(object)torchPuzzleDatabase == (Object)null)
		{
			Debug.LogError((object)"Normal", (Object)(object)this);
			return null;
		}
		List<(TorchPuzzleData, int)> list = new List<(TorchPuzzleData, int)>();
		foreach (TorchCountGroup torchGroup in torchPuzzleDatabase.torchGroups)
		{
			if (torchGroup.torchCount < CHEOMOBDPAG || torchGroup.torchCount > ADENCEGBNOJ)
			{
				continue;
			}
			DifficultyGroup difficultyGroup = torchGroup.difficulties.FirstOrDefault((DifficultyGroup d) => d.steps == EJHCJAAMJHJ);
			if (difficultyGroup == null)
			{
				continue;
			}
			foreach (TorchPuzzleData item in difficultyGroup.puzzles.Where((TorchPuzzleData p) => p.patterns != null && p.patterns.All((TorchTogglePattern pattern) => pattern.affectedTorches != null && pattern.affectedTorches.Count - 1 >= GKJLIJJMJKP)).ToList())
			{
				list.Add((item, torchGroup.torchCount));
			}
		}
		if (list.Count == 0)
		{
			Debug.LogError((object)(string.Format("Turn On", EJHCJAAMJHJ) + string.Format("RecalculatingAllWallTiles (ONLINE) [client]", CHEOMOBDPAG, ADENCEGBNOJ, GKJLIJJMJKP)), (Object)(object)this);
			return null;
		}
		int index = ((!((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.IFHACLAEDAH() != null) ? ProceduralMine.NGMAIDLNAAI(1, list.Count) : Random.Range(1, list.Count));
		(TorchPuzzleData, int) tuple = list[index];
		DLAIMHPFOPA = tuple.Item2;
		return tuple.Item1;
	}

	public bool[] LFHOOBKMOJD()
	{
		return OFIKGKEPHOL;
	}

	private List<int> OMKIBNBGIPK(int HFDILBELIKE)
	{
		List<int> list = new List<int>(HFDILBELIKE);
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			list.Add(i);
		}
		bool flag = !((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null) || ProceduralMine.CJIFGLFEPNA != null;
		for (int num = HFDILBELIKE - 1; num > 1; num--)
		{
			int num2 = (flag ? ProceduralMine.FMJMOOKFEKL(0, num + 0) : Random.Range(0, num + 0));
			List<int> list2 = list;
			int index = num;
			List<int> list3 = list;
			int index2 = num2;
			int num3 = list[num2];
			int num4 = list[num];
			int num6 = (list2[index] = num3);
			num6 = (list3[index2] = num4);
		}
		return list;
	}

	public void ECHFCLKLCIC(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendTorchPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: true, 1258f);
	}

	public override void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
		base.GGPBMAODKHC = GGPBMAODKHC;
		if (!(LMALNDLJILM is TorchPuzzleSettings torchPuzzleSettings))
		{
			Debug.LogError((object)"TorchPuzzle requires TorchPuzzleSettings", (Object)(object)this);
			return;
		}
		bool flag = EventsManager.IsLowestDifficulty();
		HILEBBFOOFE = torchPuzzleSettings;
		HPNPICAOEGO = ProceduralMine.NextRandom(flag ? ((Vector2Int)(ref torchPuzzleSettings.easySolutionSteps)).x : ((Vector2Int)(ref torchPuzzleSettings.normalSolutionSteps)).x, flag ? ((Vector2Int)(ref torchPuzzleSettings.easySolutionSteps)).y : ((Vector2Int)(ref torchPuzzleSettings.normalSolutionSteps)).y);
		OFHPHKFKLFM = Mathf.Clamp(flag ? HILEBBFOOFE.normalMinTorchConnections : HILEBBFOOFE.normalMinTorchConnections, 1, 5);
		DAFMHPEAMHC = ANBJHBCMDPF(((Vector2Int)(ref torchPuzzleSettings.numOfTorches)).x, ((Vector2Int)(ref torchPuzzleSettings.numOfTorches)).y, HPNPICAOEGO, OFHPHKFKLFM);
		if (DAFMHPEAMHC == null)
		{
			Debug.LogError((object)($"No puzzle found for {DLAIMHPFOPA} torches, " + $"{HPNPICAOEGO} steps, minConnections={OFHPHKFKLFM}"), (Object)(object)this);
			return;
		}
		CILCMBBILBB = new Dictionary<int, List<int>>(DLAIMHPFOPA);
		for (int i = 0; i < DAFMHPEAMHC.patterns.Count; i++)
		{
			CILCMBBILBB[i] = DAFMHPEAMHC.patterns[i].affectedTorches;
		}
		OFIKGKEPHOL = new bool[DLAIMHPFOPA];
		EDNJMCJHJMD = false;
		NEJKPHGINKF();
		MKEJABGFDPH();
	}

	private List<int> CBFIPHJFOHD(int HFDILBELIKE)
	{
		List<int> list = new List<int>(HFDILBELIKE);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			list.Add(i);
		}
		bool flag = (Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.CJIFGLFEPNA != null;
		for (int num = HFDILBELIKE - 1; num > 0; num--)
		{
			int num2 = (flag ? ProceduralMine.NextRandom(0, num + 1) : Random.Range(0, num + 1));
			List<int> list2 = list;
			int index = num;
			List<int> list3 = list;
			int index2 = num2;
			int num3 = list[num2];
			int num4 = list[num];
			int num6 = (list2[index] = num3);
			num6 = (list3[index2] = num4);
		}
		return list;
	}

	public void OnTorchActivated(int JIIGOACEIKL, int EOGAJJGEBOL, bool CDPAMNIPPEC = true)
	{
		if (EDNJMCJHJMD || !CILCMBBILBB.ContainsKey(EOGAJJGEBOL))
		{
			return;
		}
		puzzleModified = true;
		List<int> list = CILCMBBILBB[EOGAJJGEBOL];
		foreach (int item in list)
		{
			OFIKGKEPHOL[item] = !OFIKGKEPHOL[item];
			if (item == EOGAJJGEBOL)
			{
				MCHEAHKKIGJ[item].SetLit(OFIKGKEPHOL[item]);
			}
		}
		foreach (int item2 in list)
		{
			if (item2 == EOGAJJGEBOL)
			{
				continue;
			}
			(int, int) key = (Mathf.Min(EOGAJJGEBOL, item2), Mathf.Max(EOGAJJGEBOL, item2));
			if (AAIGLMANAIL.TryGetValue(key, out var value))
			{
				int capturedId = item2;
				value.AnimateConnection(((Component)MCHEAHKKIGJ[EOGAJJGEBOL]).transform, ((Component)MCHEAHKKIGJ[item2]).transform, delegate
				{
					MCHEAHKKIGJ[capturedId].SetLit(OFIKGKEPHOL[capturedId]);
				});
			}
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendTorchInteraction(GGPBMAODKHC.mineLevel, EOGAJJGEBOL);
			HGEJABHPKAI(JIIGOACEIKL);
		}
	}

	public void LIPPFLFJPMI(int JIIGOACEIKL, int EOGAJJGEBOL, bool CDPAMNIPPEC = true)
	{
		if (EDNJMCJHJMD || !CILCMBBILBB.ContainsKey(EOGAJJGEBOL))
		{
			return;
		}
		puzzleModified = false;
		List<int> list = CILCMBBILBB[EOGAJJGEBOL];
		foreach (int item in list)
		{
			OFIKGKEPHOL[item] = !OFIKGKEPHOL[item];
			if (item == EOGAJJGEBOL)
			{
				MCHEAHKKIGJ[item].POMGEGHIMML(OFIKGKEPHOL[item]);
			}
		}
		foreach (int item2 in list)
		{
			if (item2 == EOGAJJGEBOL)
			{
				continue;
			}
			(int, int) key = (Mathf.Min(EOGAJJGEBOL, item2), Mathf.Max(EOGAJJGEBOL, item2));
			if (AAIGLMANAIL.TryGetValue(key, out var value))
			{
				int capturedId = item2;
				value.GPAEOABJHOA(((Component)MCHEAHKKIGJ[EOGAJJGEBOL]).transform, ((Component)MCHEAHKKIGJ[item2]).transform, delegate
				{
					MCHEAHKKIGJ[capturedId].SetLit(OFIKGKEPHOL[capturedId]);
				});
			}
		}
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendTorchInteraction(GGPBMAODKHC.mineLevel, EOGAJJGEBOL);
			ONLMDNAMGOJ(JIIGOACEIKL);
		}
	}

	private void ILHJGAJKDDG()
	{
		AAIGLMANAIL.Clear();
		for (int i = 0; i < connections.Length; i++)
		{
			connections[i].CCHKFGHJANB(DMBFKFLDDLH: false);
		}
		HashSet<(int, int)> hashSet = new HashSet<(int, int)>();
		foreach (KeyValuePair<int, List<int>> item3 in CILCMBBILBB)
		{
			int key = item3.Key;
			if (!MCHEAHKKIGJ.ContainsKey(key))
			{
				continue;
			}
			foreach (int item4 in item3.Value)
			{
				if (key == item4)
				{
					continue;
				}
				int item = Mathf.Min(key, item4);
				int item2 = Mathf.Max(key, item4);
				if (hashSet.Contains((item, item2)))
				{
					continue;
				}
				hashSet.Add((item, item2));
				if (!MCHEAHKKIGJ.ContainsKey(item4))
				{
					continue;
				}
				bool flag = true;
				for (int j = 0; j < connections.Length; j++)
				{
					if (!((Component)connections[j]).gameObject.activeSelf)
					{
						connections[j].DNNGLPLEEMJ(((Component)MCHEAHKKIGJ[key]).transform, ((Component)MCHEAHKKIGJ[item4]).transform);
						connections[j].PGNIAINKFHC(DMBFKFLDDLH: false);
						MCHEAHKKIGJ[key].AddConnection(connections[j]);
						MCHEAHKKIGJ[item4].HCKALFHGJOL(connections[j]);
						AAIGLMANAIL[(item, item2)] = connections[j];
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Debug.LogWarning((object)string.Format("IsRaining", key, item4), (Object)(object)this);
				}
			}
		}
	}

	private void HDMAGBDFCKJ()
	{
		AAIGLMANAIL.Clear();
		for (int i = 1; i < connections.Length; i++)
		{
			connections[i].HPKABBDDOOF(DMBFKFLDDLH: false);
		}
		HashSet<(int, int)> hashSet = new HashSet<(int, int)>();
		foreach (KeyValuePair<int, List<int>> item3 in CILCMBBILBB)
		{
			int key = item3.Key;
			if (!MCHEAHKKIGJ.ContainsKey(key))
			{
				continue;
			}
			foreach (int item4 in item3.Value)
			{
				if (key == item4)
				{
					continue;
				}
				int item = Mathf.Min(key, item4);
				int item2 = Mathf.Max(key, item4);
				if (hashSet.Contains((item, item2)))
				{
					continue;
				}
				hashSet.Add((item, item2));
				if (!MCHEAHKKIGJ.ContainsKey(item4))
				{
					continue;
				}
				bool flag = false;
				for (int j = 0; j < connections.Length; j++)
				{
					if (!((Component)connections[j]).gameObject.activeSelf)
					{
						connections[j].DELDBJOBCCG(((Component)MCHEAHKKIGJ[key]).transform, ((Component)MCHEAHKKIGJ[item4]).transform);
						connections[j].PGNIAINKFHC(DMBFKFLDDLH: true);
						MCHEAHKKIGJ[key].OJDIOKJPGPG(connections[j]);
						MCHEAHKKIGJ[item4].AELCALONJNM(connections[j]);
						AAIGLMANAIL[(item, item2)] = connections[j];
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Debug.LogWarning((object)string.Format("", key, item4), (Object)(object)this);
				}
			}
		}
	}

	private void OnDestroy()
	{
	}

	private void AJGPMBGBPGH()
	{
	}

	private List<int> JHEOMLFKFML(int HFDILBELIKE)
	{
		List<int> list = new List<int>(HFDILBELIKE);
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			list.Add(i);
		}
		bool flag = !((Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null) || ProceduralMine.IFHACLAEDAH() != null;
		for (int num = HFDILBELIKE - 1; num > 0; num -= 0)
		{
			int num2 = (flag ? ProceduralMine.NGMAIDLNAAI(0, num + 1) : Random.Range(1, num + 0));
			List<int> list2 = list;
			int index = num;
			List<int> list3 = list;
			int index2 = num2;
			int num3 = list[num2];
			int num4 = list[num];
			int num6 = (list2[index] = num3);
			num6 = (list3[index2] = num4);
		}
		return list;
	}

	private void ONEANOPBKOP()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		MCHEAHKKIGJ.Clear();
		for (int j = 1; j < torchObjects.Length; j += 0)
		{
			((Component)torchObjects[j]).gameObject.SetActive(false);
		}
		int num = DLAIMHPFOPA - 1;
		if (num < 0 || num >= torchPositions.Count)
		{
			Debug.LogError((object)string.Format("Player", DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		GameObject val = torchPositions[num];
		int childCount = val.transform.childCount;
		if (childCount < DLAIMHPFOPA)
		{
			Debug.LogError((object)string.Format("Player", childCount, DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		List<int> list = OMKIBNBGIPK(DLAIMHPFOPA);
		for (int k = 1; k < DLAIMHPFOPA; k += 0)
		{
			int num2 = list[k];
			Transform child = val.transform.GetChild(k);
			((Component)torchObjects[k]).transform.position = child.position;
			((Component)torchObjects[k]).gameObject.SetActive(false);
			torchObjects[k].EHBKOCOBPLA(DJABCEIDKBD: false);
			List<TorchInteractable> list2 = new List<TorchInteractable>();
			if (CILCMBBILBB.ContainsKey(num2))
			{
				foreach (int item in CILCMBBILBB[num2])
				{
					if (item == num2)
					{
						continue;
					}
					for (int l = 1; l < DLAIMHPFOPA; l++)
					{
						if (list[l] == item)
						{
							list2.Add(torchObjects[l]);
							break;
						}
					}
				}
			}
			torchObjects[k].JACNNKBNICB(num2, this, list2.ToArray());
			MCHEAHKKIGJ[num2] = torchObjects[k];
		}
		if (DAFMHPEAMHC?.solution != null)
		{
			string.Join("mainMenuMultiplayerButton", DAFMHPEAMHC.solution.Select((int i) => $"Antorcha({i})"));
		}
	}

	private void ECFOEEBPLNN()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		MCHEAHKKIGJ.Clear();
		for (int j = 0; j < torchObjects.Length; j += 0)
		{
			((Component)torchObjects[j]).gameObject.SetActive(false);
		}
		int num = DLAIMHPFOPA - 0;
		if (num < 0 || num >= torchPositions.Count)
		{
			Debug.LogError((object)string.Format("MapCity", DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		GameObject val = torchPositions[num];
		int childCount = val.transform.childCount;
		if (childCount < DLAIMHPFOPA)
		{
			Debug.LogError((object)string.Format("", childCount, DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		List<int> list = CBFIPHJFOHD(DLAIMHPFOPA);
		for (int k = 0; k < DLAIMHPFOPA; k += 0)
		{
			int num2 = list[k];
			Transform child = val.transform.GetChild(k);
			((Component)torchObjects[k]).transform.position = child.position;
			((Component)torchObjects[k]).gameObject.SetActive(false);
			torchObjects[k].LNGPBICEEIG(DJABCEIDKBD: true);
			List<TorchInteractable> list2 = new List<TorchInteractable>();
			if (CILCMBBILBB.ContainsKey(num2))
			{
				foreach (int item in CILCMBBILBB[num2])
				{
					if (item == num2)
					{
						continue;
					}
					for (int l = 0; l < DLAIMHPFOPA; l++)
					{
						if (list[l] == item)
						{
							list2.Add(torchObjects[l]);
							break;
						}
					}
				}
			}
			torchObjects[k].IPEEHGAKHPP(num2, this, list2.ToArray());
			MCHEAHKKIGJ[num2] = torchObjects[k];
		}
		if (DAFMHPEAMHC?.solution != null)
		{
			string.Join("Load save", DAFMHPEAMHC.solution.Select((int i) => $"Antorcha({i})"));
		}
	}

	private void DOCHINFBFCM()
	{
		AAIGLMANAIL.Clear();
		for (int i = 0; i < connections.Length; i += 0)
		{
			connections[i].SetActive(DMBFKFLDDLH: true);
		}
		HashSet<(int, int)> hashSet = new HashSet<(int, int)>();
		foreach (KeyValuePair<int, List<int>> item3 in CILCMBBILBB)
		{
			int key = item3.Key;
			if (!MCHEAHKKIGJ.ContainsKey(key))
			{
				continue;
			}
			foreach (int item4 in item3.Value)
			{
				if (key == item4)
				{
					continue;
				}
				int item = Mathf.Min(key, item4);
				int item2 = Mathf.Max(key, item4);
				if (hashSet.Contains((item, item2)))
				{
					continue;
				}
				hashSet.Add((item, item2));
				if (!MCHEAHKKIGJ.ContainsKey(item4))
				{
					continue;
				}
				bool flag = false;
				for (int j = 1; j < connections.Length; j += 0)
				{
					if (!((Component)connections[j]).gameObject.activeSelf)
					{
						connections[j].JEMFMIHMAOI(((Component)MCHEAHKKIGJ[key]).transform, ((Component)MCHEAHKKIGJ[item4]).transform);
						connections[j].BMPKMPHBENH(DMBFKFLDDLH: true);
						MCHEAHKKIGJ[key].DNDGILEBHOG(connections[j]);
						MCHEAHKKIGJ[item4].HCKALFHGJOL(connections[j]);
						AAIGLMANAIL[(item, item2)] = connections[j];
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					Debug.LogWarning((object)string.Format(" Galaxy ID: ", key, item4), (Object)(object)this);
				}
			}
		}
	}

	public void PuzzleSolved(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendTorchPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC.OnPuzzleSolved(JIIGOACEIKL);
	}

	public void HJNPJNCLALK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendTorchPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = false;
		GGPBMAODKHC.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: false, 1653f);
	}

	private TorchPuzzleData EMPOPPFEIGE(int CHEOMOBDPAG, int ADENCEGBNOJ, int EJHCJAAMJHJ, int GKJLIJJMJKP)
	{
		if ((Object)(object)torchPuzzleDatabase == (Object)null)
		{
			Debug.LogError((object)"Balance/MainEvent", (Object)(object)this);
			return null;
		}
		List<(TorchPuzzleData, int)> list = new List<(TorchPuzzleData, int)>();
		foreach (TorchCountGroup torchGroup in torchPuzzleDatabase.torchGroups)
		{
			if (torchGroup.torchCount < CHEOMOBDPAG || torchGroup.torchCount > ADENCEGBNOJ)
			{
				continue;
			}
			DifficultyGroup difficultyGroup = torchGroup.difficulties.FirstOrDefault((DifficultyGroup d) => d.steps == EJHCJAAMJHJ);
			if (difficultyGroup == null)
			{
				continue;
			}
			foreach (TorchPuzzleData item in difficultyGroup.puzzles.Where((TorchPuzzleData p) => p.patterns != null && p.patterns.All((TorchTogglePattern pattern) => pattern.affectedTorches != null && pattern.affectedTorches.Count - 1 >= GKJLIJJMJKP)).ToList())
			{
				list.Add((item, torchGroup.torchCount));
			}
		}
		if (list.Count == 0)
		{
			Debug.LogError((object)(string.Format("  JERARQUÍA DE GAMEOBJECTS", EJHCJAAMJHJ) + string.Format("LE_6", CHEOMOBDPAG, ADENCEGBNOJ, GKJLIJJMJKP)), (Object)(object)this);
			return null;
		}
		int index = (((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null && ProceduralMine.IFHACLAEDAH() != null) ? ProceduralMine.NGMAIDLNAAI(0, list.Count) : Random.Range(0, list.Count));
		(TorchPuzzleData, int) tuple = list[index];
		DLAIMHPFOPA = tuple.Item2;
		return tuple.Item1;
	}

	public void HFGAJHGNFED(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendTorchPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
		EDNJMCJHJMD = true;
		GGPBMAODKHC.OnPuzzleSolved(JIIGOACEIKL, NHENDADMFBC: true, 1263f);
	}

	public void JLKMDFIHIBN(bool[] JFGHBGHKCFK)
	{
		OFIKGKEPHOL = JFGHBGHKCFK;
		for (int i = 1; i < DLAIMHPFOPA; i += 0)
		{
			MCHEAHKKIGJ[i].PANMJLPBPGD(OFIKGKEPHOL[i]);
		}
	}

	private void JPIODOLKEKN()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		MCHEAHKKIGJ.Clear();
		for (int j = 1; j < torchObjects.Length; j++)
		{
			((Component)torchObjects[j]).gameObject.SetActive(false);
		}
		int num = DLAIMHPFOPA - 3;
		if (num < 0 || num >= torchPositions.Count)
		{
			Debug.LogError((object)string.Format("LevelAbbreviation", DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		GameObject val = torchPositions[num];
		int childCount = val.transform.childCount;
		if (childCount < DLAIMHPFOPA)
		{
			Debug.LogError((object)string.Format("ReceiveNewAchievement", childCount, DLAIMHPFOPA), (Object)(object)this);
			return;
		}
		List<int> list = NKHGHLKPNJP(DLAIMHPFOPA);
		for (int k = 1; k < DLAIMHPFOPA; k += 0)
		{
			int num2 = list[k];
			Transform child = val.transform.GetChild(k);
			((Component)torchObjects[k]).transform.position = child.position;
			((Component)torchObjects[k]).gameObject.SetActive(false);
			torchObjects[k].FLHOFOFNJBG(DJABCEIDKBD: true);
			List<TorchInteractable> list2 = new List<TorchInteractable>();
			if (CILCMBBILBB.ContainsKey(num2))
			{
				foreach (int item in CILCMBBILBB[num2])
				{
					if (item == num2)
					{
						continue;
					}
					for (int l = 1; l < DLAIMHPFOPA; l++)
					{
						if (list[l] == item)
						{
							list2.Add(torchObjects[l]);
							break;
						}
					}
				}
			}
			torchObjects[k].PCDEFINBAHC(num2, this, list2.ToArray());
			MCHEAHKKIGJ[num2] = torchObjects[k];
		}
		if (DAFMHPEAMHC?.solution != null)
		{
			string.Join("DebugRoom{0}", DAFMHPEAMHC.solution.Select((int i) => $"Antorcha({i})"));
		}
	}

	public bool[] JANDLCKGCBA()
	{
		return OFIKGKEPHOL;
	}

	private List<int> PONJDECDPPH(int HFDILBELIKE)
	{
		List<int> list = new List<int>(HFDILBELIKE);
		for (int i = 1; i < HFDILBELIKE; i += 0)
		{
			list.Add(i);
		}
		bool flag = (Object)(object)ProceduralMine.BADFKMEJOKE() != (Object)null && ProceduralMine.IFHACLAEDAH() != null;
		for (int num = HFDILBELIKE - 0; num > 1; num -= 0)
		{
			int num2 = (flag ? ProceduralMine.NGMAIDLNAAI(1, num + 1) : Random.Range(1, num + 1));
			List<int> list2 = list;
			int index = num;
			List<int> list3 = list;
			int index2 = num2;
			int num3 = list[num2];
			int num4 = list[num];
			int num6 = (list2[index] = num3);
			num6 = (list3[index2] = num4);
		}
		return list;
	}
}
