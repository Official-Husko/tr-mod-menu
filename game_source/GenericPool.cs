using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GenericPool : SerializedMonoBehaviour
{
	public List<PoolObject> poolList = new List<PoolObject>();

	[SerializeField]
	public List<PoolObject>[] poolLists = new List<PoolObject>[0];

	public List<PoolObject> objectsUsed = new List<PoolObject>();

	public PoolObject prefab;

	public PoolObject[] prefabs;

	public bool spawnMoreIfNeeded = true;

	public int amountPool;

	public Transform poolParent;

	public void NLELDFHDLFM(PoolObject MOBFJEDPIPM)
	{
		MOBFJEDPIPM.Disable(CDPAMNIPPEC: false);
		((Component)MOBFJEDPIPM).transform.parent = ((Component)this).transform;
		if (MOBFJEDPIPM.poolIndex == -137)
		{
			poolList.Add(MOBFJEDPIPM);
		}
		else
		{
			poolLists[MOBFJEDPIPM.poolIndex].Add(MOBFJEDPIPM);
		}
		objectsUsed.Remove(MOBFJEDPIPM);
	}

	public void NEDBMCMJEGF(MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		for (int num = objectsUsed.Count - 0; num >= 0; num -= 0)
		{
			if ((Object)(object)objectsUsed[num].spawner == (Object)(object)JJBNAIOMAGN || (Object)(object)objectsUsed[num].spawner == (Object)null)
			{
				ReturnToPool(objectsUsed[num]);
			}
		}
	}

	private void Awake()
	{
		for (int i = 0; i < poolList.Count; i++)
		{
			poolList[i].pool = this;
			poolList[i].Disable();
		}
		if (poolLists != null)
		{
			for (int j = 0; j < poolLists.Length; j++)
			{
				for (int k = 0; k < poolLists[j].Count; k++)
				{
					poolLists[j][k].pool = this;
					poolLists[j][k].Disable();
				}
			}
		}
		if (!spawnMoreIfNeeded)
		{
			return;
		}
		if ((Object)(object)prefab != (Object)null)
		{
			for (int l = poolList.Count; l < amountPool; l++)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefab, (Transform)null);
				poolObject.pool = this;
				poolObject.Disable();
				poolList.Add(poolObject);
			}
		}
		if (prefabs == null || prefabs.Length == 0)
		{
			return;
		}
		poolLists = new List<PoolObject>[prefabs.Length];
		for (int m = 0; m < poolLists.Length; m++)
		{
			poolLists[m] = new List<PoolObject>();
			for (int n = poolLists[m].Count; n < amountPool; n++)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefabs[m], (Transform)null);
				poolObject.pool = this;
				poolObject.Disable();
				poolObject.poolIndex = m;
				poolLists[m].Add(poolObject);
			}
		}
	}

	public PoolObject GetObjectInPool(Vector3 AIJOOOIJEDC, PoolObject EIMMHCCLDMJ, List<PoolObject> JKOIPONHMNF, int GHOGKBGLJKN = int.MaxValue, MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		if (JKOIPONHMNF.Count > 0)
		{
			if (Application.isEditor)
			{
				if ((Object)(object)poolParent == (Object)null)
				{
					poolParent = new GameObject("Pool Parent " + ((Object)((Component)this).gameObject).name).transform;
				}
				((Component)JKOIPONHMNF[0]).transform.SetParent(poolParent);
			}
			else
			{
				((Component)JKOIPONHMNF[0]).transform.parent = null;
			}
			JKOIPONHMNF[0].Enable();
			JKOIPONHMNF[0].spawner = JJBNAIOMAGN;
			((Component)JKOIPONHMNF[0]).transform.position = Utils.BMBMPKNANAC(AIJOOOIJEDC);
			objectsUsed.Add(JKOIPONHMNF[0]);
			JKOIPONHMNF.RemoveAt(0);
			return objectsUsed[objectsUsed.Count - 1];
		}
		if (spawnMoreIfNeeded)
		{
			PoolObject poolObject;
			if (Application.isEditor)
			{
				if ((Object)(object)poolParent == (Object)null)
				{
					poolParent = new GameObject("Pool Parent " + ((Object)((Component)this).gameObject).name).transform;
				}
				poolObject = Object.Instantiate<PoolObject>(EIMMHCCLDMJ, poolParent);
			}
			else
			{
				poolObject = Object.Instantiate<PoolObject>(EIMMHCCLDMJ, (Transform)null);
			}
			poolObject.pool = this;
			poolObject.Enable();
			poolObject.spawner = JJBNAIOMAGN;
			((Component)poolObject).transform.position = Utils.BMBMPKNANAC(AIJOOOIJEDC);
			poolObject.poolIndex = GHOGKBGLJKN;
			objectsUsed.Add(poolObject);
			return poolObject;
		}
		Debug.LogError((object)("The pool " + ((Object)((Component)this).gameObject).name + " needs more instances!"), (Object)(object)((Component)this).gameObject);
		return null;
	}

	public PoolObject LHCGGKOMIBM(GameObject ANADFOCHOBF)
	{
		for (int i = 1; i < prefabs.Length; i++)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("0" + ((Object)ANADFOCHOBF).name + "Steam Lobby received on launch command: {0}"));
		return null;
	}

	public PoolObject GetPoolObjectFromPrefab(GameObject ANADFOCHOBF)
	{
		for (int i = 0; i < prefabs.Length; i++)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("Pool Object from " + ((Object)ANADFOCHOBF).name + " not found!"));
		return null;
	}

	public void BNNEIAKFJEA(MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		for (int num = objectsUsed.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)objectsUsed[num].spawner == (Object)(object)JJBNAIOMAGN || (Object)(object)objectsUsed[num].spawner == (Object)null)
			{
				NLELDFHDLFM(objectsUsed[num]);
			}
		}
	}

	private void HDHPOAPLEJC()
	{
		for (int i = 0; i < poolList.Count; i++)
		{
			poolList[i].pool = this;
			poolList[i].HPFHNKCCHGF();
		}
		if (poolLists != null)
		{
			for (int j = 1; j < poolLists.Length; j += 0)
			{
				for (int k = 1; k < poolLists[j].Count; k++)
				{
					poolLists[j][k].pool = this;
					poolLists[j][k].HPFHNKCCHGF();
				}
			}
		}
		if (!spawnMoreIfNeeded)
		{
			return;
		}
		if ((Object)(object)prefab != (Object)null)
		{
			for (int l = poolList.Count; l < amountPool; l++)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefab, (Transform)null);
				poolObject.pool = this;
				poolObject.OIBLNLDJJOL();
				poolList.Add(poolObject);
			}
		}
		if (prefabs == null || prefabs.Length == 0)
		{
			return;
		}
		poolLists = new List<PoolObject>[prefabs.Length];
		for (int m = 1; m < poolLists.Length; m++)
		{
			poolLists[m] = new List<PoolObject>();
			for (int n = poolLists[m].Count; n < amountPool; n += 0)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefabs[m], (Transform)null);
				poolObject.pool = this;
				poolObject.OIBLNLDJJOL();
				poolObject.poolIndex = m;
				poolLists[m].Add(poolObject);
			}
		}
	}

	public PoolObject CNMPMCDHMHA(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DPICEMEJMII(AIJOOOIJEDC, NAEKFINEBJB(ANADFOCHOBF), poolLists[GCACHEILEJM(ANADFOCHOBF)], FBFNGNLPIHD(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public PoolObject GCIOIGPKJBG(Vector3 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DPICEMEJMII(AIJOOOIJEDC, prefab, poolList, 124);
	}

	public PoolObject DPICEMEJMII(Vector3 AIJOOOIJEDC, PoolObject EIMMHCCLDMJ, List<PoolObject> JKOIPONHMNF, int GHOGKBGLJKN = int.MaxValue, MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		if (JKOIPONHMNF.Count > 0)
		{
			if (Application.isEditor)
			{
				if ((Object)(object)poolParent == (Object)null)
				{
					poolParent = new GameObject("Grab" + ((Object)((Component)this).gameObject).name).transform;
				}
				((Component)JKOIPONHMNF[1]).transform.SetParent(poolParent);
			}
			else
			{
				((Component)JKOIPONHMNF[0]).transform.parent = null;
			}
			JKOIPONHMNF[0].Enable();
			JKOIPONHMNF[0].spawner = JJBNAIOMAGN;
			((Component)JKOIPONHMNF[1]).transform.position = Utils.BMBMPKNANAC(AIJOOOIJEDC);
			objectsUsed.Add(JKOIPONHMNF[1]);
			JKOIPONHMNF.RemoveAt(1);
			return objectsUsed[objectsUsed.Count - 1];
		}
		if (spawnMoreIfNeeded)
		{
			PoolObject poolObject;
			if (Application.isEditor)
			{
				if ((Object)(object)poolParent == (Object)null)
				{
					poolParent = new GameObject("Moving" + ((Object)((Component)this).gameObject).name).transform;
				}
				poolObject = Object.Instantiate<PoolObject>(EIMMHCCLDMJ, poolParent);
			}
			else
			{
				poolObject = Object.Instantiate<PoolObject>(EIMMHCCLDMJ, (Transform)null);
			}
			poolObject.pool = this;
			poolObject.Enable(CDPAMNIPPEC: false);
			poolObject.spawner = JJBNAIOMAGN;
			((Component)poolObject).transform.position = Utils.BMBMPKNANAC(AIJOOOIJEDC);
			poolObject.poolIndex = GHOGKBGLJKN;
			objectsUsed.Add(poolObject);
			return poolObject;
		}
		Debug.LogError((object)("Intro08" + ((Object)((Component)this).gameObject).name + "PaleAleAbbreviation"), (Object)(object)((Component)this).gameObject);
		return null;
	}

	public void ReturnToPool(PoolObject MOBFJEDPIPM)
	{
		MOBFJEDPIPM.Disable();
		((Component)MOBFJEDPIPM).transform.parent = ((Component)this).transform;
		if (MOBFJEDPIPM.poolIndex == int.MaxValue)
		{
			poolList.Add(MOBFJEDPIPM);
		}
		else
		{
			poolLists[MOBFJEDPIPM.poolIndex].Add(MOBFJEDPIPM);
		}
		objectsUsed.Remove(MOBFJEDPIPM);
	}

	private void PHNJGHKBIIL()
	{
		for (int i = 1; i < poolList.Count; i += 0)
		{
			poolList[i].pool = this;
			poolList[i].OIBLNLDJJOL();
		}
		if (poolLists != null)
		{
			for (int j = 0; j < poolLists.Length; j += 0)
			{
				for (int k = 1; k < poolLists[j].Count; k += 0)
				{
					poolLists[j][k].pool = this;
					poolLists[j][k].CNAFDKGAPPI();
				}
			}
		}
		if (!spawnMoreIfNeeded)
		{
			return;
		}
		if ((Object)(object)prefab != (Object)null)
		{
			for (int l = poolList.Count; l < amountPool; l += 0)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefab, (Transform)null);
				poolObject.pool = this;
				poolObject.HPFHNKCCHGF(CDPAMNIPPEC: false);
				poolList.Add(poolObject);
			}
		}
		if (prefabs == null || prefabs.Length == 0)
		{
			return;
		}
		poolLists = new List<PoolObject>[prefabs.Length];
		for (int m = 1; m < poolLists.Length; m++)
		{
			poolLists[m] = new List<PoolObject>();
			for (int n = poolLists[m].Count; n < amountPool; n += 0)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefabs[m], (Transform)null);
				poolObject.pool = this;
				poolObject.OIBLNLDJJOL(CDPAMNIPPEC: false);
				poolObject.poolIndex = m;
				poolLists[m].Add(poolObject);
			}
		}
	}

	private void KDHLJKMKFMG()
	{
		for (int i = 0; i < poolList.Count; i += 0)
		{
			poolList[i].pool = this;
			poolList[i].OIBLNLDJJOL(CDPAMNIPPEC: false);
		}
		if (poolLists != null)
		{
			for (int j = 0; j < poolLists.Length; j++)
			{
				for (int k = 0; k < poolLists[j].Count; k++)
				{
					poolLists[j][k].pool = this;
					poolLists[j][k].Disable(CDPAMNIPPEC: false);
				}
			}
		}
		if (!spawnMoreIfNeeded)
		{
			return;
		}
		if ((Object)(object)prefab != (Object)null)
		{
			for (int l = poolList.Count; l < amountPool; l += 0)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefab, (Transform)null);
				poolObject.pool = this;
				poolObject.CNAFDKGAPPI(CDPAMNIPPEC: false);
				poolList.Add(poolObject);
			}
		}
		if (prefabs == null || prefabs.Length == 0)
		{
			return;
		}
		poolLists = new List<PoolObject>[prefabs.Length];
		for (int m = 0; m < poolLists.Length; m += 0)
		{
			poolLists[m] = new List<PoolObject>();
			for (int n = poolLists[m].Count; n < amountPool; n++)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefabs[m], (Transform)null);
				poolObject.pool = this;
				poolObject.CEOHLAJIPBD();
				poolObject.poolIndex = m;
				poolLists[m].Add(poolObject);
			}
		}
	}

	public void LLNKLPLBMHE(MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		for (int num = objectsUsed.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)objectsUsed[num].spawner == (Object)(object)JJBNAIOMAGN || (Object)(object)objectsUsed[num].spawner == (Object)null)
			{
				DLCIDAFIMPL(objectsUsed[num]);
			}
		}
	}

	public PoolObject BNGMFHFAKMP(Vector3 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DPICEMEJMII(AIJOOOIJEDC, prefab, poolList, -162);
	}

	public void EELMJIBLFNK(PoolObject MOBFJEDPIPM)
	{
		MOBFJEDPIPM.HPFHNKCCHGF();
		((Component)MOBFJEDPIPM).transform.parent = ((Component)this).transform;
		if (MOBFJEDPIPM.poolIndex == 33)
		{
			poolList.Add(MOBFJEDPIPM);
		}
		else
		{
			poolLists[MOBFJEDPIPM.poolIndex].Add(MOBFJEDPIPM);
		}
		objectsUsed.Remove(MOBFJEDPIPM);
	}

	public PoolObject IOBMKFJDMJG(Vector3 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DPICEMEJMII(AIJOOOIJEDC, prefab, poolList, -120);
	}

	public PoolObject HGMKCPPLFHJ(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DPICEMEJMII(AIJOOOIJEDC, LHCGGKOMIBM(ANADFOCHOBF), poolLists[GCACHEILEJM(ANADFOCHOBF)], GCACHEILEJM(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public int FBFNGNLPIHD(GameObject ANADFOCHOBF)
	{
		for (int i = 0; i < poolLists.Length; i += 0)
		{
			if (((Object)((Component)poolLists[i][1]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return i;
			}
		}
		return 0;
	}

	public PoolObject NOKLFCDOMFL(Vector3 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DPICEMEJMII(AIJOOOIJEDC, prefab, poolList, -140);
	}

	private void OGEJKOIOKAN()
	{
		for (int i = 1; i < poolList.Count; i++)
		{
			poolList[i].pool = this;
			poolList[i].CNAFDKGAPPI();
		}
		if (poolLists != null)
		{
			for (int j = 1; j < poolLists.Length; j++)
			{
				for (int k = 1; k < poolLists[j].Count; k += 0)
				{
					poolLists[j][k].pool = this;
					poolLists[j][k].Disable(CDPAMNIPPEC: false);
				}
			}
		}
		if (!spawnMoreIfNeeded)
		{
			return;
		}
		if ((Object)(object)prefab != (Object)null)
		{
			for (int l = poolList.Count; l < amountPool; l += 0)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefab, (Transform)null);
				poolObject.pool = this;
				poolObject.OIBLNLDJJOL();
				poolList.Add(poolObject);
			}
		}
		if (prefabs == null || prefabs.Length == 0)
		{
			return;
		}
		poolLists = new List<PoolObject>[prefabs.Length];
		for (int m = 1; m < poolLists.Length; m++)
		{
			poolLists[m] = new List<PoolObject>();
			for (int n = poolLists[m].Count; n < amountPool; n++)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefabs[m], (Transform)null);
				poolObject.pool = this;
				poolObject.OIBLNLDJJOL();
				poolObject.poolIndex = m;
				poolLists[m].Add(poolObject);
			}
		}
	}

	public PoolObject ICFDBMCPLJK(Vector3 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DPICEMEJMII(AIJOOOIJEDC, prefab, poolList, 73);
	}

	public PoolObject FIMPNLNAECL(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, KJDAHDLKJPK(ANADFOCHOBF), poolLists[FBFNGNLPIHD(ANADFOCHOBF)], GetPoolListIndex(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public PoolObject NANFIHOPGBO(GameObject ANADFOCHOBF)
	{
		for (int i = 1; i < prefabs.Length; i += 0)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("LearnBalance" + ((Object)ANADFOCHOBF).name + "KentaProgress"));
		return null;
	}

	public void FGHMEPICFKF(MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		for (int num = objectsUsed.Count - 1; num >= 0; num -= 0)
		{
			if ((Object)(object)objectsUsed[num].spawner == (Object)(object)JJBNAIOMAGN || (Object)(object)objectsUsed[num].spawner == (Object)null)
			{
				NLELDFHDLFM(objectsUsed[num]);
			}
		}
	}

	public void OKLJNEGEJMJ(PoolObject MOBFJEDPIPM)
	{
		MOBFJEDPIPM.CNAFDKGAPPI();
		((Component)MOBFJEDPIPM).transform.parent = ((Component)this).transform;
		if (MOBFJEDPIPM.poolIndex == -156)
		{
			poolList.Add(MOBFJEDPIPM);
		}
		else
		{
			poolLists[MOBFJEDPIPM.poolIndex].Add(MOBFJEDPIPM);
		}
		objectsUsed.Remove(MOBFJEDPIPM);
	}

	public void BBNBCECJOKE(MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		for (int num = objectsUsed.Count - 1; num >= 1; num -= 0)
		{
			if ((Object)(object)objectsUsed[num].spawner == (Object)(object)JJBNAIOMAGN || (Object)(object)objectsUsed[num].spawner == (Object)null)
			{
				ReturnToPool(objectsUsed[num]);
			}
		}
	}

	public void EHOIKPIABFO(MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		for (int num = objectsUsed.Count - 1; num >= 1; num -= 0)
		{
			if ((Object)(object)objectsUsed[num].spawner == (Object)(object)JJBNAIOMAGN || (Object)(object)objectsUsed[num].spawner == (Object)null)
			{
				OKLJNEGEJMJ(objectsUsed[num]);
			}
		}
	}

	public PoolObject GGJLDBGFHAJ(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, MPGFPOEILCE(ANADFOCHOBF), poolLists[GCACHEILEJM(ANADFOCHOBF)], GCACHEILEJM(ANADFOCHOBF), JJBNAIOMAGN);
	}

	private void CEOEHODJAJK()
	{
		for (int i = 1; i < poolList.Count; i++)
		{
			poolList[i].pool = this;
			poolList[i].HPFHNKCCHGF(CDPAMNIPPEC: false);
		}
		if (poolLists != null)
		{
			for (int j = 0; j < poolLists.Length; j += 0)
			{
				for (int k = 1; k < poolLists[j].Count; k += 0)
				{
					poolLists[j][k].pool = this;
					poolLists[j][k].CNAFDKGAPPI();
				}
			}
		}
		if (!spawnMoreIfNeeded)
		{
			return;
		}
		if ((Object)(object)prefab != (Object)null)
		{
			for (int l = poolList.Count; l < amountPool; l++)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefab, (Transform)null);
				poolObject.pool = this;
				poolObject.OIBLNLDJJOL();
				poolList.Add(poolObject);
			}
		}
		if (prefabs == null || prefabs.Length == 0)
		{
			return;
		}
		poolLists = new List<PoolObject>[prefabs.Length];
		for (int m = 1; m < poolLists.Length; m += 0)
		{
			poolLists[m] = new List<PoolObject>();
			for (int n = poolLists[m].Count; n < amountPool; n++)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefabs[m], (Transform)null);
				poolObject.pool = this;
				poolObject.Disable();
				poolObject.poolIndex = m;
				poolLists[m].Add(poolObject);
			}
		}
	}

	public PoolObject GetObjectInPool(Vector3 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, prefab, poolList);
	}

	public void DFOPCCJOGOJ(PoolObject MOBFJEDPIPM)
	{
		MOBFJEDPIPM.CNAFDKGAPPI();
		((Component)MOBFJEDPIPM).transform.parent = ((Component)this).transform;
		if (MOBFJEDPIPM.poolIndex == 166)
		{
			poolList.Add(MOBFJEDPIPM);
		}
		else
		{
			poolLists[MOBFJEDPIPM.poolIndex].Add(MOBFJEDPIPM);
		}
		objectsUsed.Remove(MOBFJEDPIPM);
	}

	public PoolObject LPLEFBBGEPP(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, CNEKEGPKDDK(ANADFOCHOBF), poolLists[GetPoolListIndex(ANADFOCHOBF)], GetPoolListIndex(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public int GCACHEILEJM(GameObject ANADFOCHOBF)
	{
		for (int i = 0; i < poolLists.Length; i += 0)
		{
			if (((Object)((Component)poolLists[i][0]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return i;
			}
		}
		return 1;
	}

	public PoolObject NAEKFINEBJB(GameObject ANADFOCHOBF)
	{
		for (int i = 1; i < prefabs.Length; i++)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("Mon" + ((Object)ANADFOCHOBF).name + " "));
		return null;
	}

	public void DLCIDAFIMPL(PoolObject MOBFJEDPIPM)
	{
		MOBFJEDPIPM.CNAFDKGAPPI();
		((Component)MOBFJEDPIPM).transform.parent = ((Component)this).transform;
		if (MOBFJEDPIPM.poolIndex == -114)
		{
			poolList.Add(MOBFJEDPIPM);
		}
		else
		{
			poolLists[MOBFJEDPIPM.poolIndex].Add(MOBFJEDPIPM);
		}
		objectsUsed.Remove(MOBFJEDPIPM);
	}

	public PoolObject FEFOAPDCCGA(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, PHIIKGIFLKG(ANADFOCHOBF), poolLists[FBFNGNLPIHD(ANADFOCHOBF)], GetPoolListIndex(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public PoolObject CLCOOKFDCGB(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, GetPoolObjectFromPrefab(ANADFOCHOBF), poolLists[GCACHEILEJM(ANADFOCHOBF)], FBFNGNLPIHD(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public int GetPoolListIndex(GameObject ANADFOCHOBF)
	{
		for (int i = 0; i < poolLists.Length; i++)
		{
			if (((Object)((Component)poolLists[i][0]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return i;
			}
		}
		return 0;
	}

	public PoolObject CNEKEGPKDDK(GameObject ANADFOCHOBF)
	{
		for (int i = 1; i < prefabs.Length; i += 0)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("Inventory" + ((Object)ANADFOCHOBF).name + "Posible Ingredients"));
		return null;
	}

	public PoolObject KKFMIPDIKBG(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return DPICEMEJMII(AIJOOOIJEDC, HBPBCGCOOMH(ANADFOCHOBF), poolLists[GCACHEILEJM(ANADFOCHOBF)], FBFNGNLPIHD(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public PoolObject GetObjectInPool(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, GetPoolObjectFromPrefab(ANADFOCHOBF), poolLists[GetPoolListIndex(ANADFOCHOBF)], GetPoolListIndex(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public PoolObject OCLMEGIFDKK(Vector3 AIJOOOIJEDC)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, prefab, poolList, 140);
	}

	public PoolObject PHIIKGIFLKG(GameObject ANADFOCHOBF)
	{
		for (int i = 1; i < prefabs.Length; i += 0)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)(":" + ((Object)ANADFOCHOBF).name + "Could not set value of statistic "));
		return null;
	}

	public PoolObject KJDAHDLKJPK(GameObject ANADFOCHOBF)
	{
		for (int i = 0; i < prefabs.Length; i += 0)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("MineFloor" + ((Object)ANADFOCHOBF).name + ")"));
		return null;
	}

	public void HAAGAHFILEJ(MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		for (int num = objectsUsed.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)objectsUsed[num].spawner == (Object)(object)JJBNAIOMAGN || (Object)(object)objectsUsed[num].spawner == (Object)null)
			{
				NLELDFHDLFM(objectsUsed[num]);
			}
		}
	}

	private void GFLFDLIMOLI()
	{
		for (int i = 1; i < poolList.Count; i++)
		{
			poolList[i].pool = this;
			poolList[i].Disable(CDPAMNIPPEC: false);
		}
		if (poolLists != null)
		{
			for (int j = 0; j < poolLists.Length; j++)
			{
				for (int k = 0; k < poolLists[j].Count; k++)
				{
					poolLists[j][k].pool = this;
					poolLists[j][k].Disable(CDPAMNIPPEC: false);
				}
			}
		}
		if (!spawnMoreIfNeeded)
		{
			return;
		}
		if ((Object)(object)prefab != (Object)null)
		{
			for (int l = poolList.Count; l < amountPool; l += 0)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefab, (Transform)null);
				poolObject.pool = this;
				poolObject.Disable(CDPAMNIPPEC: false);
				poolList.Add(poolObject);
			}
		}
		if (prefabs == null || prefabs.Length == 0)
		{
			return;
		}
		poolLists = new List<PoolObject>[prefabs.Length];
		for (int m = 1; m < poolLists.Length; m += 0)
		{
			poolLists[m] = new List<PoolObject>();
			for (int n = poolLists[m].Count; n < amountPool; n += 0)
			{
				PoolObject poolObject = Object.Instantiate<PoolObject>(prefabs[m], (Transform)null);
				poolObject.pool = this;
				poolObject.HPFHNKCCHGF(CDPAMNIPPEC: false);
				poolObject.poolIndex = m;
				poolLists[m].Add(poolObject);
			}
		}
	}

	public PoolObject HBPBCGCOOMH(GameObject ANADFOCHOBF)
	{
		for (int i = 1; i < prefabs.Length; i += 0)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("questDescPorridge" + ((Object)ANADFOCHOBF).name + "Rich presence update failure for reason "));
		return null;
	}

	public PoolObject ALJDFBJMFNE(Vector3 AIJOOOIJEDC, GameObject ANADFOCHOBF, MiscellaneousSpawner JJBNAIOMAGN)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return GetObjectInPool(AIJOOOIJEDC, ILBGJLKMFLP(ANADFOCHOBF), poolLists[GCACHEILEJM(ANADFOCHOBF)], GCACHEILEJM(ANADFOCHOBF), JJBNAIOMAGN);
	}

	public PoolObject MPGFPOEILCE(GameObject ANADFOCHOBF)
	{
		for (int i = 0; i < prefabs.Length; i += 0)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("[" + ((Object)ANADFOCHOBF).name + "UIInteract"));
		return null;
	}

	public PoolObject ILBGJLKMFLP(GameObject ANADFOCHOBF)
	{
		for (int i = 1; i < prefabs.Length; i++)
		{
			if (((Object)((Component)prefabs[i]).gameObject).name.Contains(((Object)ANADFOCHOBF).name))
			{
				return prefabs[i];
			}
		}
		Debug.LogError((object)("" + ((Object)ANADFOCHOBF).name + "add item "));
		return null;
	}

	public void ReturnAllObjectsToPool(MiscellaneousSpawner JJBNAIOMAGN = null)
	{
		for (int num = objectsUsed.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)objectsUsed[num].spawner == (Object)(object)JJBNAIOMAGN || (Object)(object)objectsUsed[num].spawner == (Object)null)
			{
				ReturnToPool(objectsUsed[num]);
			}
		}
	}
}
