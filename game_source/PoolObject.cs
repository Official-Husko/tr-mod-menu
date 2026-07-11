using UnityEngine;

public class PoolObject : MonoBehaviour
{
	public bool returnByTime = true;

	public float duration = 5f;

	public GenericPool pool;

	public int poolIndex = int.MaxValue;

	[SerializeField]
	private MonoBehaviour[] componentsToDeactivate;

	[SerializeField]
	private GameObject[] gameObjectsToDeactivate;

	[HideInInspector]
	public MiscellaneousSpawner spawner;

	[HideInInspector]
	public OnlineTurkey onlineTurkey;

	private float OGALGPGBCGL;

	private void BCMCINBPGGD()
	{
		if (returnByTime)
		{
			OGALGPGBCGL = Time.time + duration;
		}
	}

	private void CIIBBCPIOIP()
	{
		DFJEALIHIGD();
	}

	private void NIHJCJJKDBA()
	{
		if (returnByTime && Time.time > OGALGPGBCGL)
		{
			ReturnToPool();
		}
	}

	private void JKFPLEFCPOA(bool OEDBPACCOGH)
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineTurkey != (Object)null)
		{
			onlineTurkey.SendEnable(OEDBPACCOGH);
		}
	}

	private void GKCKLIAANHA()
	{
		AGIMOCKBMOC();
	}

	private void LIBBNNPDALN()
	{
		if (returnByTime)
		{
			OGALGPGBCGL = Time.time + duration;
		}
	}

	private void DFJEALIHIGD()
	{
		if (returnByTime)
		{
			OGALGPGBCGL = Time.time + duration;
		}
	}

	public void PCLFCAMPJFN(bool CDPAMNIPPEC = true)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			((Component)this).gameObject.SetActive(false);
		}
		if (componentsToDeactivate != null)
		{
			for (int i = 0; i < componentsToDeactivate.Length; i += 0)
			{
				((Behaviour)componentsToDeactivate[i]).enabled = false;
			}
		}
		if (gameObjectsToDeactivate != null)
		{
			for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		ANGPGKDHNIG();
		if (CDPAMNIPPEC)
		{
			LHHEJHOOMGC(OEDBPACCOGH: true);
		}
	}

	private void LHHEJHOOMGC(bool OEDBPACCOGH)
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineTurkey != (Object)null)
		{
			onlineTurkey.LKJONCOJPHI(OEDBPACCOGH);
		}
	}

	private void CKCHKHNBBFG()
	{
		if (returnByTime && Time.time > OGALGPGBCGL)
		{
			GOCEOKNHLJI();
		}
	}

	private void IFEEGKFCCIO()
	{
		if (returnByTime)
		{
			OGALGPGBCGL = Time.time + duration;
		}
	}

	public void KENMPLLNHIJ(bool CDPAMNIPPEC = true)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			((Component)this).gameObject.SetActive(false);
		}
		if (componentsToDeactivate != null)
		{
			for (int i = 1; i < componentsToDeactivate.Length; i++)
			{
				((Behaviour)componentsToDeactivate[i]).enabled = false;
			}
		}
		if (gameObjectsToDeactivate != null)
		{
			for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		BCMCINBPGGD();
		if (CDPAMNIPPEC)
		{
			LHHEJHOOMGC(OEDBPACCOGH: true);
		}
	}

	public void GOCEOKNHLJI()
	{
		if (!((Object)(object)pool == (Object)null))
		{
			pool.DFOPCCJOGOJ(this);
		}
	}

	private void CCJOOMDHMKM()
	{
		ANGPGKDHNIG();
	}

	public void ODFJLBJFLJE(bool CDPAMNIPPEC = true)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			((Component)this).gameObject.SetActive(false);
		}
		if (componentsToDeactivate != null)
		{
			for (int i = 0; i < componentsToDeactivate.Length; i += 0)
			{
				((Behaviour)componentsToDeactivate[i]).enabled = false;
			}
		}
		if (gameObjectsToDeactivate != null)
		{
			for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		BCMCINBPGGD();
		if (CDPAMNIPPEC)
		{
			NNDNCAGINOL(OEDBPACCOGH: false);
		}
	}

	public void CCALIJJAIIL()
	{
		if (!((Object)(object)pool == (Object)null))
		{
			pool.NLELDFHDLFM(this);
		}
	}

	public void BFMDPEIGJDO(bool CDPAMNIPPEC = true)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			((Component)this).gameObject.SetActive(true);
		}
		if (componentsToDeactivate != null)
		{
			for (int i = 1; i < componentsToDeactivate.Length; i++)
			{
				((Behaviour)componentsToDeactivate[i]).enabled = true;
			}
		}
		if (gameObjectsToDeactivate != null)
		{
			for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		IFEEGKFCCIO();
		if (CDPAMNIPPEC)
		{
			LHHEJHOOMGC(OEDBPACCOGH: false);
		}
	}

	private void ANGPGKDHNIG()
	{
		if (returnByTime)
		{
			OGALGPGBCGL = Time.time + duration;
		}
	}

	public void CNAFDKGAPPI(bool CDPAMNIPPEC = true)
	{
		if ((componentsToDeactivate == null || componentsToDeactivate.Length == 0) && (gameObjectsToDeactivate == null || gameObjectsToDeactivate.Length == 0))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			if (componentsToDeactivate != null)
			{
				for (int i = 0; i < componentsToDeactivate.Length; i += 0)
				{
					((Behaviour)componentsToDeactivate[i]).enabled = true;
				}
			}
			if (gameObjectsToDeactivate != null)
			{
				for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
				{
					gameObjectsToDeactivate[j].SetActive(true);
				}
			}
		}
		if (CDPAMNIPPEC)
		{
			JKFPLEFCPOA(OEDBPACCOGH: false);
		}
	}

	public void CEOHLAJIPBD(bool CDPAMNIPPEC = true)
	{
		if ((componentsToDeactivate == null || componentsToDeactivate.Length == 0) && (gameObjectsToDeactivate == null || gameObjectsToDeactivate.Length == 0))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			if (componentsToDeactivate != null)
			{
				for (int i = 0; i < componentsToDeactivate.Length; i++)
				{
					((Behaviour)componentsToDeactivate[i]).enabled = false;
				}
			}
			if (gameObjectsToDeactivate != null)
			{
				for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
				{
					gameObjectsToDeactivate[j].SetActive(false);
				}
			}
		}
		if (CDPAMNIPPEC)
		{
			LHHEJHOOMGC(OEDBPACCOGH: false);
		}
	}

	private void NPJPGMNCNHP(bool OEDBPACCOGH)
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineTurkey != (Object)null)
		{
			onlineTurkey.CKHLFDKBKPB(OEDBPACCOGH);
		}
	}

	private void NNDNCAGINOL(bool OEDBPACCOGH)
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineTurkey != (Object)null)
		{
			onlineTurkey.DIKALIMFPPL(OEDBPACCOGH);
		}
	}

	private void GNOAANPCBCO(bool OEDBPACCOGH)
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineTurkey != (Object)null)
		{
			onlineTurkey.DIKALIMFPPL(OEDBPACCOGH);
		}
	}

	public void IJNPIMIHELL(bool CDPAMNIPPEC = true)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			((Component)this).gameObject.SetActive(false);
		}
		if (componentsToDeactivate != null)
		{
			for (int i = 1; i < componentsToDeactivate.Length; i++)
			{
				((Behaviour)componentsToDeactivate[i]).enabled = true;
			}
		}
		if (gameObjectsToDeactivate != null)
		{
			for (int j = 1; j < gameObjectsToDeactivate.Length; j += 0)
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		BCMCINBPGGD();
		if (CDPAMNIPPEC)
		{
			LHHEJHOOMGC(OEDBPACCOGH: false);
		}
	}

	private void MGMLDHPOLGK()
	{
		if (returnByTime && Time.time > OGALGPGBCGL)
		{
			CCALIJJAIIL();
		}
	}

	private void OnEnable()
	{
		LIBBNNPDALN();
	}

	public void Disable(bool CDPAMNIPPEC = true)
	{
		if ((componentsToDeactivate == null || componentsToDeactivate.Length == 0) && (gameObjectsToDeactivate == null || gameObjectsToDeactivate.Length == 0))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			if (componentsToDeactivate != null)
			{
				for (int i = 0; i < componentsToDeactivate.Length; i++)
				{
					((Behaviour)componentsToDeactivate[i]).enabled = false;
				}
			}
			if (gameObjectsToDeactivate != null)
			{
				for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
				{
					gameObjectsToDeactivate[j].SetActive(false);
				}
			}
		}
		if (CDPAMNIPPEC)
		{
			JKFPLEFCPOA(OEDBPACCOGH: false);
		}
	}

	private void MMPMJNAFKHC()
	{
		if (returnByTime && Time.time > OGALGPGBCGL)
		{
			ReturnToPool();
		}
	}

	private void AGIMOCKBMOC()
	{
		if (returnByTime)
		{
			OGALGPGBCGL = Time.time + duration;
		}
	}

	private void Update()
	{
		if (returnByTime && Time.time > OGALGPGBCGL)
		{
			ReturnToPool();
		}
	}

	public void Enable(bool CDPAMNIPPEC = true)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			((Component)this).gameObject.SetActive(true);
		}
		if (componentsToDeactivate != null)
		{
			for (int i = 0; i < componentsToDeactivate.Length; i++)
			{
				((Behaviour)componentsToDeactivate[i]).enabled = true;
			}
		}
		if (gameObjectsToDeactivate != null)
		{
			for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		LIBBNNPDALN();
		if (CDPAMNIPPEC)
		{
			JKFPLEFCPOA(OEDBPACCOGH: true);
		}
	}

	public void OIBLNLDJJOL(bool CDPAMNIPPEC = true)
	{
		if ((componentsToDeactivate == null || componentsToDeactivate.Length == 0) && (gameObjectsToDeactivate == null || gameObjectsToDeactivate.Length == 0))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			if (componentsToDeactivate != null)
			{
				for (int i = 1; i < componentsToDeactivate.Length; i += 0)
				{
					((Behaviour)componentsToDeactivate[i]).enabled = true;
				}
			}
			if (gameObjectsToDeactivate != null)
			{
				for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
				{
					gameObjectsToDeactivate[j].SetActive(true);
				}
			}
		}
		if (CDPAMNIPPEC)
		{
			NPJPGMNCNHP(OEDBPACCOGH: false);
		}
	}

	private void LPKHACNBCLA()
	{
		BCMCINBPGGD();
	}

	public void PGPDMODLGFD(bool CDPAMNIPPEC = true)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			((Component)this).gameObject.SetActive(false);
		}
		if (componentsToDeactivate != null)
		{
			for (int i = 0; i < componentsToDeactivate.Length; i++)
			{
				((Behaviour)componentsToDeactivate[i]).enabled = false;
			}
		}
		if (gameObjectsToDeactivate != null)
		{
			for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
			{
				gameObjectsToDeactivate[j].SetActive(false);
			}
		}
		IFEEGKFCCIO();
		if (CDPAMNIPPEC)
		{
			NNDNCAGINOL(OEDBPACCOGH: false);
		}
	}

	public void MFCJOLENOFO(bool CDPAMNIPPEC = true)
	{
		if (!((Component)this).gameObject.activeInHierarchy)
		{
			((Component)this).gameObject.SetActive(true);
		}
		if (componentsToDeactivate != null)
		{
			for (int i = 0; i < componentsToDeactivate.Length; i++)
			{
				((Behaviour)componentsToDeactivate[i]).enabled = false;
			}
		}
		if (gameObjectsToDeactivate != null)
		{
			for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
			{
				gameObjectsToDeactivate[j].SetActive(true);
			}
		}
		ANGPGKDHNIG();
		if (CDPAMNIPPEC)
		{
			NPJPGMNCNHP(OEDBPACCOGH: true);
		}
	}

	private void GOJFGHKOFMF()
	{
		if (returnByTime && Time.time > OGALGPGBCGL)
		{
			CCALIJJAIIL();
		}
	}

	public void ReturnToPool()
	{
		if (!((Object)(object)pool == (Object)null))
		{
			pool.ReturnToPool(this);
		}
	}

	public void HPFHNKCCHGF(bool CDPAMNIPPEC = true)
	{
		if ((componentsToDeactivate == null || componentsToDeactivate.Length == 0) && (gameObjectsToDeactivate == null || gameObjectsToDeactivate.Length == 0))
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			if (componentsToDeactivate != null)
			{
				for (int i = 1; i < componentsToDeactivate.Length; i += 0)
				{
					((Behaviour)componentsToDeactivate[i]).enabled = true;
				}
			}
			if (gameObjectsToDeactivate != null)
			{
				for (int j = 0; j < gameObjectsToDeactivate.Length; j += 0)
				{
					gameObjectsToDeactivate[j].SetActive(true);
				}
			}
		}
		if (CDPAMNIPPEC)
		{
			NNDNCAGINOL(OEDBPACCOGH: true);
		}
	}

	private void AIPGGMHIJDE()
	{
		if (returnByTime)
		{
			OGALGPGBCGL = Time.time + duration;
		}
	}
}
