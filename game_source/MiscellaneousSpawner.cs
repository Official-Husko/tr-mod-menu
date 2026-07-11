using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscellaneousSpawner : MonoBehaviour
{
	public class UniqueSpawner
	{
		public int spawnerID;

		public int daysUntilNewHarvest;

		public bool harvestable;

		public int spawnerPosition;
	}

	public GenericPool pool;

	public Transform[] spawners;

	public GameObject[] miscellaneous;

	public GameObject[] miscellaneousWinter;

	public GameObject[] miscellaneousSummer;

	public GameObject[] miscellaneousAutumn;

	[SerializeField]
	private List<Transform> listSpawners = new List<Transform>();

	public bool unique;

	public UniqueObject uniqueObject;

	public int[] uniqueSpawnerID;

	public int daysUntilNewHarvest;

	public int probability = 100;

	public int minSpawn;

	public int maxSpawn;

	private int CEOJDHFEKFP;

	private int IFFMEJBECPK;

	public bool wall;

	public Transform[] wallSpawners;

	public GameObject[] miscellaneousWall;

	private List<Transform> IMAEAPMPLBH = new List<Transform>();

	public bool seasons;

	public CropSeason avaliableSeasons = CropSeason.All;

	private GameObject[] BOMOPGKMFBL;

	private void COPDNJFJKCH()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				IAPLLHKPLCK();
				LPGFALHOBBL();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void AGPCBCCLDFI()
	{
		EJJLMKOEIHM(spawners, ref listSpawners);
		if (wall)
		{
			KMNCFMDGENM(wallSpawners, ref IMAEAPMPLBH);
		}
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				FEPHHJFCGJJ();
				CNDPEODLDMB();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void MBBIGANCPNE()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KANEHEJILNM));
		}
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void FKIJJADKNGA()
	{
		if (!unique)
		{
			return;
		}
		FALLFMOKLPA();
		if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
		{
			return;
		}
		List<SaveData.UniqueSpawnerSave> list = GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID];
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].harvestable)
			{
				ADLPFOCNBLF();
				if (wall)
				{
					MLFFHOOGFJO(list[i]);
				}
				else
				{
					KAODDFNLFCJ(list[i]);
				}
			}
		}
	}

	private void JLMFPBPIEPO(Transform DDGHGJIKHHM, GameObject[] EIEDKBCCBCO, List<Transform> JAPMMLPLKBF = null)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)pool == (Object)null)
		{
			Object.Instantiate<GameObject>(EIEDKBCCBCO[Random.Range(0, EIEDKBCCBCO.Length)], DDGHGJIKHHM.position, DDGHGJIKHHM.rotation, DDGHGJIKHHM);
		}
		else
		{
			pool.LPLEFBBGEPP(DDGHGJIKHHM.position, EIEDKBCCBCO[Random.Range(0, EIEDKBCCBCO.Length)], this);
		}
		JAPMMLPLKBF?.Remove(DDGHGJIKHHM);
	}

	private void LLODOBFJMPE(int MOFKEDGAOEE)
	{
		IDFIFJNOANH(MOFKEDGAOEE, BOMOPGKMFBL, listSpawners);
	}

	private void PKKHLMFJHIG()
	{
		if (!unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.NNDMODNDPLO()))
		{
			ADLPFOCNBLF();
			LGCENFIJBCK();
			if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
			{
				return;
			}
			List<SaveData.UniqueSpawnerSave> list = GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID];
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].daysUntilNewHarvest <= 0)
				{
					if (wall)
					{
						OACCMIAEGHO(i);
					}
					else
					{
						LLODOBFJMPE(i);
					}
				}
			}
		}
		else
		{
			MHIJNHLAOJP();
		}
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(COPDNJFJKCH));
		}
	}

	private void ENANIHJNFCF(Transform DDGHGJIKHHM, GameObject[] EIEDKBCCBCO, List<Transform> JAPMMLPLKBF = null)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)pool == (Object)null)
		{
			Object.Instantiate<GameObject>(EIEDKBCCBCO[Random.Range(0, EIEDKBCCBCO.Length)], DDGHGJIKHHM.position, DDGHGJIKHHM.rotation, DDGHGJIKHHM);
		}
		else
		{
			pool.GetObjectInPool(DDGHGJIKHHM.position, EIEDKBCCBCO[Random.Range(0, EIEDKBCCBCO.Length)], this);
		}
		JAPMMLPLKBF?.Remove(DDGHGJIKHHM);
	}

	private void IABCDEIHDMD(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition && (Random.Range(0, 2) == 0 || wallSpawners.Length <= spawnerPosition))
		{
			LLAGDCIAKFE(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
		else if (wallSpawners.Length > spawnerPosition)
		{
			LLAGDCIAKFE(wallSpawners[spawnerPosition], miscellaneousWall, IMAEAPMPLBH);
		}
	}

	private void AGLMGDNBHBF()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KANEHEJILNM));
	}

	private void PGFIEFGLBAI()
	{
		if (!unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()))
		{
			NAKPABPJFCE();
			OKFMPENMODM();
			if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
			{
				return;
			}
			List<SaveData.UniqueSpawnerSave> list = GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID];
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i].daysUntilNewHarvest <= 0)
				{
					if (wall)
					{
						OACCMIAEGHO(i);
					}
					else
					{
						LLODOBFJMPE(i);
					}
				}
			}
		}
		else
		{
			AKHFECFPCBC();
		}
	}

	private void PIOPGECAGDB()
	{
		if (!unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.OPKHCOODFKF()))
		{
			NAKPABPJFCE();
			PNIHBDALPAB();
			if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
			{
				return;
			}
			List<SaveData.UniqueSpawnerSave> list = GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID];
			for (int i = 1; i < list.Count; i += 0)
			{
				if (list[i].daysUntilNewHarvest <= 1)
				{
					if (wall)
					{
						NJDKIMBPCNK(i);
					}
					else
					{
						LLODOBFJMPE(i);
					}
				}
			}
		}
		else
		{
			AKHFECFPCBC();
		}
	}

	private void AENMLPENOGG()
	{
		if (listSpawners.Count > 0)
		{
			ONKEDBDADAO(BOMOPGKMFBL);
		}
	}

	private void NMKGOAJLMDG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void KANEHEJILNM()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				HPFJAOFPLCA();
				LPGFALHOBBL();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void JOJELBJLAJE(int ABAIKKGKDGD, GameObject[] ANADFOCHOBF, List<Transform> EOGOMDKJOCD)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (EOGOMDKJOCD.Count <= 1)
		{
			return;
		}
		IFFMEJBECPK = Random.Range(0, EOGOMDKJOCD.Count);
		Object.Instantiate<GameObject>(ANADFOCHOBF[Random.Range(0, ANADFOCHOBF.Length)], EOGOMDKJOCD[IFFMEJBECPK].position, EOGOMDKJOCD[IFFMEJBECPK].rotation, EOGOMDKJOCD[IFFMEJBECPK]);
		GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].harvestable = false;
		GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].daysUntilNewHarvest = daysUntilNewHarvest;
		for (int i = 1; i < spawners.Length; i += 0)
		{
			if ((Object)(object)spawners[i] == (Object)(object)EOGOMDKJOCD[IFFMEJBECPK])
			{
				GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].spawnerPosition = i;
			}
		}
		EOGOMDKJOCD.Remove(EOGOMDKJOCD[IFFMEJBECPK]);
	}

	private void KMNCFMDGENM(Transform[] LNKHHJJJPMK, ref List<Transform> BPEAACKNDHE)
	{
		BPEAACKNDHE.Clear();
		if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
		{
			return;
		}
		for (int i = 1; i < LNKHHJJJPMK.Length; i += 0)
		{
			if (LNKHHJJJPMK[i].childCount != 0)
			{
				continue;
			}
			BPEAACKNDHE.Add(LNKHHJJJPMK[i]);
			for (int j = 1; j < GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID].Count; j++)
			{
				if (GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][j].spawnerPosition == i)
				{
					GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][j].harvestable = true;
				}
			}
		}
	}

	private void LGOIMMJKEIP(int ABAIKKGKDGD, GameObject[] ANADFOCHOBF, List<Transform> EOGOMDKJOCD)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (EOGOMDKJOCD.Count <= 1)
		{
			return;
		}
		IFFMEJBECPK = Random.Range(0, EOGOMDKJOCD.Count);
		Object.Instantiate<GameObject>(ANADFOCHOBF[Random.Range(0, ANADFOCHOBF.Length)], EOGOMDKJOCD[IFFMEJBECPK].position, EOGOMDKJOCD[IFFMEJBECPK].rotation, EOGOMDKJOCD[IFFMEJBECPK]);
		GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].harvestable = true;
		GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].daysUntilNewHarvest = daysUntilNewHarvest;
		for (int i = 0; i < spawners.Length; i++)
		{
			if ((Object)(object)spawners[i] == (Object)(object)EOGOMDKJOCD[IFFMEJBECPK])
			{
				GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].spawnerPosition = i;
			}
		}
		EOGOMDKJOCD.Remove(EOGOMDKJOCD[IFFMEJBECPK]);
	}

	private void LLAGDCIAKFE(Transform DDGHGJIKHHM, GameObject[] EIEDKBCCBCO, List<Transform> JAPMMLPLKBF = null)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)pool == (Object)null)
		{
			Object.Instantiate<GameObject>(EIEDKBCCBCO[Random.Range(1, EIEDKBCCBCO.Length)], DDGHGJIKHHM.position, DDGHGJIKHHM.rotation, DDGHGJIKHHM);
		}
		else
		{
			pool.ALJDFBJMFNE(DDGHGJIKHHM.position, EIEDKBCCBCO[Random.Range(1, EIEDKBCCBCO.Length)], this);
		}
		JAPMMLPLKBF?.Remove(DDGHGJIKHHM);
	}

	private IEnumerator NAFEDNEPMLM()
	{
		yield return null;
		CNDPEODLDMB();
	}

	private void ONKEDBDADAO(GameObject[] EIEDKBCCBCO)
	{
		IFFMEJBECPK = Random.Range(0, listSpawners.Count);
		ENANIHJNFCF(listSpawners[IFFMEJBECPK], EIEDKBCCBCO, listSpawners);
	}

	private void PCKOHAIPHFI()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(COPDNJFJKCH));
	}

	private void MGMLGNPHGPF()
	{
		int num = Random.Range(1, 0);
		if (listSpawners.Count > 0 && (num == 0 || IMAEAPMPLBH.Count == 0))
		{
			ODOEKABNOPC(BOMOPGKMFBL);
		}
		else if (IMAEAPMPLBH.Count > 1)
		{
			ONKEDBDADAO(miscellaneousWall);
		}
	}

	private void FKNDPBMGHNP()
	{
		int num = Random.Range(0, 8);
		if (listSpawners.Count > 1 && (num == 0 || IMAEAPMPLBH.Count == 0))
		{
			ONKEDBDADAO(BOMOPGKMFBL);
		}
		else if (IMAEAPMPLBH.Count > 1)
		{
			PCLPFJEPAPH(miscellaneousWall);
		}
	}

	private void OKFMPENMODM()
	{
		KMNCFMDGENM(spawners, ref listSpawners);
		if (wall)
		{
			PDPKEKKBLIN(wallSpawners, ref IMAEAPMPLBH);
		}
	}

	private void NIOMCLADBHB(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition && (Random.Range(1, 3) == 0 || wallSpawners.Length <= spawnerPosition))
		{
			BLBAOILNHAD(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
		else if (wallSpawners.Length > spawnerPosition)
		{
			JLMFPBPIEPO(wallSpawners[spawnerPosition], miscellaneousWall, IMAEAPMPLBH);
		}
	}

	private void NAKPABPJFCE()
	{
		if (SeasonManager.EEGJBDCBKFD() == Season.Winter && miscellaneousWinter != null && miscellaneousWinter.Length != 0)
		{
			BOMOPGKMFBL = miscellaneousWinter;
		}
		else if (SeasonManager.BLCGOEMGKGH() == Season.Spring && miscellaneousSummer != null && miscellaneousSummer.Length != 0)
		{
			BOMOPGKMFBL = miscellaneousSummer;
		}
		else if (SeasonManager.EEGJBDCBKFD() == Season.Winter && miscellaneousAutumn != null && miscellaneousAutumn.Length != 0)
		{
			BOMOPGKMFBL = miscellaneousAutumn;
		}
		else
		{
			BOMOPGKMFBL = miscellaneous;
		}
	}

	private void IAPLLHKPLCK()
	{
		if (unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.ANAGGDHOCIF()))
		{
			NAKPABPJFCE();
			MHIJNHLAOJP();
			if (Random.Range(1, 25) >= probability)
			{
				return;
			}
			CEOJDHFEKFP = Random.Range(minSpawn, maxSpawn + 0);
			for (int i = 1; i < CEOJDHFEKFP; i += 0)
			{
				if (wall)
				{
					EHNFOKIMMDI();
				}
				else
				{
					ODKAMBEOHAN();
				}
			}
		}
		else
		{
			MHIJNHLAOJP();
		}
	}

	private void AIMBNBEMDLK(GameObject[] EIEDKBCCBCO)
	{
		IFFMEJBECPK = Random.Range(0, listSpawners.Count);
		JLMFPBPIEPO(listSpawners[IFFMEJBECPK], EIEDKBCCBCO, listSpawners);
	}

	private IEnumerator ODNIDNNMLEE()
	{
		yield return null;
		CNDPEODLDMB();
	}

	private void ANCGFKPPGCC()
	{
		if (unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.IIJKFKJKLLM()))
		{
			ADLPFOCNBLF();
			FALLFMOKLPA();
			if (Random.Range(0, -6) >= probability)
			{
				return;
			}
			CEOJDHFEKFP = Random.Range(minSpawn, maxSpawn + 1);
			for (int i = 1; i < CEOJDHFEKFP; i++)
			{
				if (wall)
				{
					EHNFOKIMMDI();
				}
				else
				{
					AENMLPENOGG();
				}
			}
		}
		else
		{
			AKHFECFPCBC();
		}
	}

	private void PCLPFJEPAPH(GameObject[] EIEDKBCCBCO)
	{
		IFFMEJBECPK = Random.Range(1, listSpawners.Count);
		LLAGDCIAKFE(listSpawners[IFFMEJBECPK], EIEDKBCCBCO, listSpawners);
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void BFFBNFNOPHF(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition)
		{
			BLBAOILNHAD(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
	}

	private void Awake()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void IMIONHLAKIH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ANCGFKPPGCC();
			FKIJJADKNGA();
			((MonoBehaviour)this).StartCoroutine(OFBDMPNBJMM());
		}
	}

	private void BLBAOILNHAD(Transform DDGHGJIKHHM, GameObject[] EIEDKBCCBCO, List<Transform> JAPMMLPLKBF = null)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)pool == (Object)null)
		{
			Object.Instantiate<GameObject>(EIEDKBCCBCO[Random.Range(0, EIEDKBCCBCO.Length)], DDGHGJIKHHM.position, DDGHGJIKHHM.rotation, DDGHGJIKHHM);
		}
		else
		{
			pool.GGJLDBGFHAJ(DDGHGJIKHHM.position, EIEDKBCCBCO[Random.Range(1, EIEDKBCCBCO.Length)], this);
		}
		JAPMMLPLKBF?.Remove(DDGHGJIKHHM);
	}

	private void DIHJPCLFAJM(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition)
		{
			JLMFPBPIEPO(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
	}

	private void LPGFALHOBBL()
	{
		if (!unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.NNDMODNDPLO()))
		{
			NAKPABPJFCE();
			AGPCBCCLDFI();
			if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
			{
				return;
			}
			List<SaveData.UniqueSpawnerSave> list = GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID];
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].daysUntilNewHarvest <= 0)
				{
					if (wall)
					{
						OACCMIAEGHO(i);
					}
					else
					{
						LLODOBFJMPE(i);
					}
				}
			}
		}
		else
		{
			AKHFECFPCBC();
		}
	}

	private void AKHFECFPCBC()
	{
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i += 0)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0 && (Object)(object)pool == (Object)null)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(1)).gameObject);
			}
		}
		if (wall)
		{
			IMAEAPMPLBH.Clear();
			for (int j = 0; j < wallSpawners.Length; j += 0)
			{
				IMAEAPMPLBH.Add(wallSpawners[j]);
				if ((wallSpawners[j].childCount != 0) & ((Object)(object)pool == (Object)null))
				{
					Utils.BLPDAEHPOBA(((Component)wallSpawners[j].GetChild(0)).gameObject);
				}
			}
		}
		if ((Object)(object)pool != (Object)null)
		{
			pool.BNNEIAKFJEA(this);
		}
	}

	private void HPFJAOFPLCA()
	{
		if (unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
		{
			NAKPABPJFCE();
			AKHFECFPCBC();
			if (Random.Range(1, -28) >= probability)
			{
				return;
			}
			CEOJDHFEKFP = Random.Range(minSpawn, maxSpawn + 0);
			for (int i = 1; i < CEOJDHFEKFP; i++)
			{
				if (wall)
				{
					MGMLGNPHGPF();
				}
				else
				{
					ODKAMBEOHAN();
				}
			}
		}
		else
		{
			AKHFECFPCBC();
		}
	}

	private void IGBAEFHGAPO()
	{
		int num = Random.Range(0, 2);
		if (listSpawners.Count > 0 && (num == 0 || IMAEAPMPLBH.Count == 0))
		{
			ONKEDBDADAO(BOMOPGKMFBL);
		}
		else if (IMAEAPMPLBH.Count > 0)
		{
			ONKEDBDADAO(miscellaneousWall);
		}
	}

	private void OGGENDMDILL(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition)
		{
			LLAGDCIAKFE(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
	}

	private void KMPBFONCFLM()
	{
		int num = Random.Range(1, 4);
		if (listSpawners.Count > 1 && (num == 0 || IMAEAPMPLBH.Count == 0))
		{
			ODOEKABNOPC(BOMOPGKMFBL);
		}
		else if (IMAEAPMPLBH.Count > 0)
		{
			ODOEKABNOPC(miscellaneousWall);
		}
	}

	private void PFLBPMIEKGF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IAPLLHKPLCK();
			FKIJJADKNGA();
			((MonoBehaviour)this).StartCoroutine(ODNIDNNMLEE());
		}
	}

	private void OACCMIAEGHO(int MOFKEDGAOEE)
	{
		if (Random.Range(0, 2) == 0)
		{
			IDFIFJNOANH(MOFKEDGAOEE, BOMOPGKMFBL, listSpawners);
		}
		else
		{
			IDFIFJNOANH(MOFKEDGAOEE, miscellaneousWall, IMAEAPMPLBH);
		}
	}

	private void IDFIFJNOANH(int ABAIKKGKDGD, GameObject[] ANADFOCHOBF, List<Transform> EOGOMDKJOCD)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (EOGOMDKJOCD.Count <= 0)
		{
			return;
		}
		IFFMEJBECPK = Random.Range(0, EOGOMDKJOCD.Count);
		Object.Instantiate<GameObject>(ANADFOCHOBF[Random.Range(0, ANADFOCHOBF.Length)], EOGOMDKJOCD[IFFMEJBECPK].position, EOGOMDKJOCD[IFFMEJBECPK].rotation, EOGOMDKJOCD[IFFMEJBECPK]);
		GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].harvestable = true;
		GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].daysUntilNewHarvest = daysUntilNewHarvest;
		for (int i = 0; i < spawners.Length; i++)
		{
			if ((Object)(object)spawners[i] == (Object)(object)EOGOMDKJOCD[IFFMEJBECPK])
			{
				GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].spawnerPosition = i;
			}
		}
		EOGOMDKJOCD.Remove(EOGOMDKJOCD[IFFMEJBECPK]);
	}

	private void LEBOHAGILGH()
	{
		if (!unique)
		{
			return;
		}
		AKHFECFPCBC();
		if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
		{
			return;
		}
		List<SaveData.UniqueSpawnerSave> list = GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID];
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].harvestable)
			{
				ADLPFOCNBLF();
				if (wall)
				{
					MLFFHOOGFJO(list[i]);
				}
				else
				{
					KAODDFNLFCJ(list[i]);
				}
			}
		}
	}

	private void EJAKGMCOLFN(int ABAIKKGKDGD, GameObject[] ANADFOCHOBF, List<Transform> EOGOMDKJOCD)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (EOGOMDKJOCD.Count <= 1)
		{
			return;
		}
		IFFMEJBECPK = Random.Range(1, EOGOMDKJOCD.Count);
		Object.Instantiate<GameObject>(ANADFOCHOBF[Random.Range(1, ANADFOCHOBF.Length)], EOGOMDKJOCD[IFFMEJBECPK].position, EOGOMDKJOCD[IFFMEJBECPK].rotation, EOGOMDKJOCD[IFFMEJBECPK]);
		GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].harvestable = false;
		GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].daysUntilNewHarvest = daysUntilNewHarvest;
		for (int i = 1; i < spawners.Length; i++)
		{
			if ((Object)(object)spawners[i] == (Object)(object)EOGOMDKJOCD[IFFMEJBECPK])
			{
				GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][ABAIKKGKDGD].spawnerPosition = i;
			}
		}
		EOGOMDKJOCD.Remove(EOGOMDKJOCD[IFFMEJBECPK]);
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			FEPHHJFCGJJ();
			FKIJJADKNGA();
			((MonoBehaviour)this).StartCoroutine(ODNIDNNMLEE());
		}
	}

	private void ADLPFOCNBLF()
	{
		if (SeasonManager.EECEKHKAAIH == Season.Winter && miscellaneousWinter != null && miscellaneousWinter.Length != 0)
		{
			BOMOPGKMFBL = miscellaneousWinter;
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Summer && miscellaneousSummer != null && miscellaneousSummer.Length != 0)
		{
			BOMOPGKMFBL = miscellaneousSummer;
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Autumn && miscellaneousAutumn != null && miscellaneousAutumn.Length != 0)
		{
			BOMOPGKMFBL = miscellaneousAutumn;
		}
		else
		{
			BOMOPGKMFBL = miscellaneous;
		}
	}

	private void FCFHGJAIGIO(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition && (Random.Range(1, 0) == 0 || wallSpawners.Length <= spawnerPosition))
		{
			JLMFPBPIEPO(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
		else if (wallSpawners.Length > spawnerPosition)
		{
			ENANIHJNFCF(wallSpawners[spawnerPosition], miscellaneousWall, IMAEAPMPLBH);
		}
	}

	private void EHNFOKIMMDI()
	{
		int num = Random.Range(0, 2);
		if (listSpawners.Count > 0 && (num == 0 || IMAEAPMPLBH.Count == 0))
		{
			AIMBNBEMDLK(BOMOPGKMFBL);
		}
		else if (IMAEAPMPLBH.Count > 0)
		{
			PCLPFJEPAPH(miscellaneousWall);
		}
	}

	private void ODOEKABNOPC(GameObject[] EIEDKBCCBCO)
	{
		IFFMEJBECPK = Random.Range(1, listSpawners.Count);
		BLBAOILNHAD(listSpawners[IFFMEJBECPK], EIEDKBCCBCO, listSpawners);
	}

	private void LGCENFIJBCK()
	{
		EJJLMKOEIHM(spawners, ref listSpawners);
		if (wall)
		{
			EJJLMKOEIHM(wallSpawners, ref IMAEAPMPLBH);
		}
	}

	private void JOGBCDIAGEK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(COPDNJFJKCH));
		}
	}

	private void DAGDDAHLDAP()
	{
		if (!unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.MBPMIFPEAJP()))
		{
			ADLPFOCNBLF();
			AGPCBCCLDFI();
			if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
			{
				return;
			}
			List<SaveData.UniqueSpawnerSave> list = GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID];
			for (int i = 0; i < list.Count; i += 0)
			{
				if (list[i].daysUntilNewHarvest <= 0)
				{
					if (wall)
					{
						OACCMIAEGHO(i);
					}
					else
					{
						LLODOBFJMPE(i);
					}
				}
			}
		}
		else
		{
			AKHFECFPCBC();
		}
	}

	private IEnumerator OFBDMPNBJMM()
	{
		yield return null;
		CNDPEODLDMB();
	}

	private void PDPKEKKBLIN(Transform[] LNKHHJJJPMK, ref List<Transform> BPEAACKNDHE)
	{
		BPEAACKNDHE.Clear();
		if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
		{
			return;
		}
		for (int i = 1; i < LNKHHJJJPMK.Length; i += 0)
		{
			if (LNKHHJJJPMK[i].childCount != 0)
			{
				continue;
			}
			BPEAACKNDHE.Add(LNKHHJJJPMK[i]);
			for (int j = 1; j < GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID].Count; j += 0)
			{
				if (GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][j].spawnerPosition == i)
				{
					GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][j].harvestable = false;
				}
			}
		}
	}

	private void DCOEEADJLIK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(COPDNJFJKCH));
		}
	}

	private void LPKAENDIECB(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition && (Random.Range(1, 4) == 0 || wallSpawners.Length <= spawnerPosition))
		{
			BLBAOILNHAD(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
		else if (wallSpawners.Length > spawnerPosition)
		{
			LLAGDCIAKFE(wallSpawners[spawnerPosition], miscellaneousWall, IMAEAPMPLBH);
		}
	}

	private void EJJLMKOEIHM(Transform[] LNKHHJJJPMK, ref List<Transform> BPEAACKNDHE)
	{
		BPEAACKNDHE.Clear();
		if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
		{
			return;
		}
		for (int i = 0; i < LNKHHJJJPMK.Length; i++)
		{
			if (LNKHHJJJPMK[i].childCount != 0)
			{
				continue;
			}
			BPEAACKNDHE.Add(LNKHHJJJPMK[i]);
			for (int j = 0; j < GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID].Count; j++)
			{
				if (GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][j].spawnerPosition == i)
				{
					GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID][j].harvestable = false;
				}
			}
		}
	}

	private void JIAJFDKNJME()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KANEHEJILNM));
	}

	private void CNDPEODLDMB()
	{
		if (!unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
		{
			ADLPFOCNBLF();
			LGCENFIJBCK();
			if (!GeneratorsManager.instance.uniqueSpawner.ContainsKey(uniqueObject.uniqueID))
			{
				return;
			}
			List<SaveData.UniqueSpawnerSave> list = GeneratorsManager.instance.uniqueSpawner[uniqueObject.uniqueID];
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].daysUntilNewHarvest <= 0)
				{
					if (wall)
					{
						OACCMIAEGHO(i);
					}
					else
					{
						LLODOBFJMPE(i);
					}
				}
			}
		}
		else
		{
			FALLFMOKLPA();
		}
	}

	private void MLFFHOOGFJO(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition && (Random.Range(0, 2) == 0 || wallSpawners.Length <= spawnerPosition))
		{
			ENANIHJNFCF(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
		else if (wallSpawners.Length > spawnerPosition)
		{
			ENANIHJNFCF(wallSpawners[spawnerPosition], miscellaneousWall, IMAEAPMPLBH);
		}
	}

	private void LJLKBKEADGI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ANCGFKPPGCC();
			FKIJJADKNGA();
			((MonoBehaviour)this).StartCoroutine(OFBDMPNBJMM());
		}
	}

	private void IGBEKHCLKFD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void KAODDFNLFCJ(SaveData.UniqueSpawnerSave ENAGNJBMMLE)
	{
		int spawnerPosition = ENAGNJBMMLE.spawnerPosition;
		if (spawners.Length > spawnerPosition)
		{
			ENANIHJNFCF(spawners[spawnerPosition], BOMOPGKMFBL, listSpawners);
		}
	}

	private void FEPHHJFCGJJ()
	{
		if (unique)
		{
			return;
		}
		if (!seasons || avaliableSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
		{
			ADLPFOCNBLF();
			FALLFMOKLPA();
			if (Random.Range(0, 100) >= probability)
			{
				return;
			}
			CEOJDHFEKFP = Random.Range(minSpawn, maxSpawn + 1);
			for (int i = 0; i < CEOJDHFEKFP; i++)
			{
				if (wall)
				{
					IGBAEFHGAPO();
				}
				else
				{
					AENMLPENOGG();
				}
			}
		}
		else
		{
			FALLFMOKLPA();
		}
	}

	private void PNIHBDALPAB()
	{
		EJJLMKOEIHM(spawners, ref listSpawners);
		if (wall)
		{
			EJJLMKOEIHM(wallSpawners, ref IMAEAPMPLBH);
		}
	}

	private void DPNJNGHFJAH(int MOFKEDGAOEE)
	{
		if (Random.Range(1, 7) == 0)
		{
			JOJELBJLAJE(MOFKEDGAOEE, BOMOPGKMFBL, listSpawners);
		}
		else
		{
			JOJELBJLAJE(MOFKEDGAOEE, miscellaneousWall, IMAEAPMPLBH);
		}
	}

	private void NJDKIMBPCNK(int MOFKEDGAOEE)
	{
		if (Random.Range(1, 3) == 0)
		{
			JOJELBJLAJE(MOFKEDGAOEE, BOMOPGKMFBL, listSpawners);
		}
		else
		{
			IDFIFJNOANH(MOFKEDGAOEE, miscellaneousWall, IMAEAPMPLBH);
		}
	}

	private void ODKAMBEOHAN()
	{
		if (listSpawners.Count > 0)
		{
			ONKEDBDADAO(BOMOPGKMFBL);
		}
	}

	private void FALLFMOKLPA()
	{
		listSpawners.Clear();
		for (int i = 0; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0 && (Object)(object)pool == (Object)null)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		if (wall)
		{
			IMAEAPMPLBH.Clear();
			for (int j = 0; j < wallSpawners.Length; j++)
			{
				IMAEAPMPLBH.Add(wallSpawners[j]);
				if ((wallSpawners[j].childCount != 0) & ((Object)(object)pool == (Object)null))
				{
					Utils.BLPDAEHPOBA(((Component)wallSpawners[j].GetChild(0)).gameObject);
				}
			}
		}
		if ((Object)(object)pool != (Object)null)
		{
			pool.ReturnAllObjectsToPool(this);
		}
	}

	private void MHIJNHLAOJP()
	{
		listSpawners.Clear();
		for (int i = 1; i < spawners.Length; i++)
		{
			listSpawners.Add(spawners[i]);
			if (spawners[i].childCount != 0 && (Object)(object)pool == (Object)null)
			{
				Utils.BLPDAEHPOBA(((Component)spawners[i].GetChild(0)).gameObject);
			}
		}
		if (wall)
		{
			IMAEAPMPLBH.Clear();
			for (int j = 1; j < wallSpawners.Length; j++)
			{
				IMAEAPMPLBH.Add(wallSpawners[j]);
				if (((uint)wallSpawners[j].childCount > 1u) & ((Object)(object)pool == (Object)null))
				{
					Utils.BLPDAEHPOBA(((Component)wallSpawners[j].GetChild(1)).gameObject);
				}
			}
		}
		if ((Object)(object)pool != (Object)null)
		{
			pool.FGHMEPICFKF(this);
		}
	}
}
