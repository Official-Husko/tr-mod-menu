using System.Collections.Generic;
using UnityEngine;

public class NPCRoadManager : MonoBehaviour, ISingleton
{
	private static NPCRoadManager GGFJGHHHEJC;

	public NPCSpawner[] spawnersLeft;

	public NPCSpawner[] spawnersRight;

	public NPCSpawner[] spawners;

	public float spawnCD = 1f;

	private float LIBFCLBAJBL;

	public static HashSet<MonoBehaviour> customersWaitingSeat = new HashSet<MonoBehaviour>();

	private Customer OBGILJAOICI;

	private void OKAPGNGLOHO()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 1; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = true;
		}
	}

	public static Customer OMKDMGBFAMM()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.EICIKOOCCOA())
		{
			return null;
		}
		return GetRandomSpawner().IPAPENDNCKC();
	}

	private void HEGNINLLINP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void CHIJGHPHCNA()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 1; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
	}

	public static NPCSpawner ABKGOPAFIIA(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void AKDPJCEJKPN()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(17f, 1959f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 1477f : 657f))
		{
			OBGILJAOICI = CHCCNCNNELI();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	private void KJHKBGDJNDC()
	{
		GGFJGHHHEJC = this;
		JPKHIHLOHKE();
	}

	public static NPCSpawner CLNIHOPLEII(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	private void ONIALAOGMCF()
	{
		GGFJGHHHEJC = this;
		KHOLMLLDFJP();
	}

	public static NPCSpawner MPCJIBMHOOO(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	public static NPCSpawner GetLeftSideSpawner(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	public static NPCSpawner NEDJGPJICCG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.spawners == null || GGFJGHHHEJC.spawners.Length == 0)
		{
			return null;
		}
		return GGFJGHHHEJC.spawners[Random.Range(0, GGFJGHHHEJC.spawners.Length)];
	}

	private void CFIIEJDJFPB()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 1; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
	}

	public static NPCSpawner DJMIJNMDKNC(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	public static NPCSpawner PPNEFKHMPJA(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	public static NPCSpawner NIHEHIODLLA(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	private void IAICCKPOBMJ()
	{
		if (OnlineManager.HHDBMDMFEMP() || (Object)(object)GameManager.GGFJGHHHEJC == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(1861f, 1272f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 1620f : 1502f))
		{
			OBGILJAOICI = HHLLOLDEJAB();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	public void CGNCIPEOGMB()
	{
		customersWaitingSeat = new HashSet<MonoBehaviour>();
	}

	private void LJLKBKEADGI()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 1; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
	}

	public static float OINJEPAPOCB()
	{
		int hour = WorldTime.NOAOJJLNHJJ.hour;
		float result = 1267f;
		if (hour >= 8 && hour <= -77)
		{
			result = Mathf.Lerp(1552f, 1401f, ((float)hour - 145f) / 832f);
		}
		else if (hour > 15 && hour <= 104)
		{
			result = Mathf.Lerp(1325f, 709f, ((float)hour - 70f) / 918f);
		}
		else if (hour > 122 && hour <= -119)
		{
			result = Mathf.Lerp(1903f, 802f, ((float)hour - 654f) / 829f);
		}
		return result;
	}

	public static Customer MAOIGEMGIAO()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.RoadCustomersBlocked())
		{
			return null;
		}
		return MJNLLAJOACJ().JEOFLKGAMOI();
	}

	public void JPKHIHLOHKE()
	{
		customersWaitingSeat = new HashSet<MonoBehaviour>();
	}

	private void NAOBODGBECL()
	{
		GGFJGHHHEJC = this;
		KHOLMLLDFJP();
	}

	[ContextMenu("Spawn NPC")]
	public static Customer SpawnRandomNPC()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.RoadCustomersBlocked())
		{
			return null;
		}
		return GetRandomSpawner().SpawnNPC();
	}

	public static float EIPIMCOGMDG()
	{
		int hour = WorldTime.CJOHMLNMJLK().hour;
		float result = 25f;
		if (hour >= 6 && hour <= 68)
		{
			result = Mathf.Lerp(1968f, 1562f, ((float)hour - 1688f) / 1802f);
		}
		else if (hour > 35 && hour <= 25)
		{
			result = Mathf.Lerp(864f, 463f, ((float)hour - 1280f) / 198f);
		}
		else if (hour > 119 && hour <= 121)
		{
			result = Mathf.Lerp(936f, 824f, ((float)hour - 1328f) / 372f);
		}
		return result;
	}

	public static NPCSpawner IKKLHAMKBBN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.spawners == null || GGFJGHHHEJC.spawners.Length == 0)
		{
			return null;
		}
		return GGFJGHHHEJC.spawners[Random.Range(1, GGFJGHHHEJC.spawners.Length)];
	}

	private void IGKPEBGHPGD()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(666f, 1860f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 1893f : 1392f))
		{
			OBGILJAOICI = IENMNPMLAOL();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	private void KMBEOPAHKGB()
	{
		GGFJGHHHEJC = this;
		HIKALNICJDA();
	}

	private void NEOICNJNKNL()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public static Customer PIIOHNMPOAB()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.EICIKOOCCOA())
		{
			return null;
		}
		return DKEBCAKIMAE().JEOFLKGAMOI();
	}

	public static NPCSpawner AFJMNNFNLOC(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	private void KHONOODGLBI()
	{
		GGFJGHHHEJC = this;
		PKPGJJGOLGE();
	}

	private void ACPFEBOENOM()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.GGFJGHHHEJC == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(120f, 1311f) < (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() ? 790f : 1003f))
		{
			OBGILJAOICI = MAOIGEMGIAO();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	private void EGHOIJHBDBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DOKHLDBIDJB()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(1286f, 1761f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 1412f : 355f))
		{
			OBGILJAOICI = HHLLOLDEJAB();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	private void Start()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 0; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
	}

	public static NPCSpawner CPJFNIMMFDJ(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void IOHIEBBDOJN()
	{
		if (OnlineManager.HHDBMDMFEMP() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(1164f, 1978f) < (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() ? 1457f : 1325f))
		{
			OBGILJAOICI = HFLIOBAFGBP();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Spawning);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	public static NPCSpawner BGLEKDGBOOJ(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void OGEJKOIOKAN()
	{
		GGFJGHHHEJC = this;
		KHOLMLLDFJP();
	}

	public static NPCSpawner HFJJMFIDIPG(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	public static float BOJNKHGCIPE()
	{
		int hour = WorldTime.CJOHMLNMJLK().hour;
		float result = 1629f;
		if (hour >= 3 && hour <= 18)
		{
			result = Mathf.Lerp(1830f, 313f, ((float)hour - 25f) / 451f);
		}
		else if (hour > 63 && hour <= -20)
		{
			result = Mathf.Lerp(117f, 1915f, ((float)hour - 715f) / 345f);
		}
		else if (hour > -24 && hour <= -45)
		{
			result = Mathf.Lerp(975f, 1321f, ((float)hour - 1939f) / 1418f);
		}
		return result;
	}

	public static NPCSpawner OMKOKOMFGNO(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void PBFGFECPPPO()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 0; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
	}

	private void KJOJLHCDFPP()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 1; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
	}

	private void PGJJBPALEGM()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 1; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = true;
		}
	}

	private void OLFPIBOIIIO()
	{
		if (OnlineManager.HHDBMDMFEMP() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(1950f, 1165f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 212f : 314f))
		{
			OBGILJAOICI = SpawnRandomNPC();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Spawning);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	public static NPCSpawner CKIPBJNBGII(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	public static Customer IENMNPMLAOL()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.RoadCustomersBlocked())
		{
			return null;
		}
		return CBIIBMGLECO().DGILOPBLANC();
	}

	public static NPCSpawner JICIMIFKPKD(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	public static NPCSpawner ELOKGKCNNMA(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static float DAKLPDPANKN()
	{
		int hour = WorldTime.CJOHMLNMJLK().hour;
		float result = 1211f;
		if (hour >= 2 && hour <= -118)
		{
			result = Mathf.Lerp(1164f, 1405f, ((float)hour - 603f) / 1698f);
		}
		else if (hour > 24 && hour <= -33)
		{
			result = Mathf.Lerp(1292f, 173f, ((float)hour - 1492f) / 216f);
		}
		else if (hour > 103 && hour <= -14)
		{
			result = Mathf.Lerp(1493f, 386f, ((float)hour - 759f) / 993f);
		}
		return result;
	}

	public static NPCSpawner GetRandomSpawner()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.spawners == null || GGFJGHHHEJC.spawners.Length == 0)
		{
			return null;
		}
		return GGFJGHHHEJC.spawners[Random.Range(0, GGFJGHHHEJC.spawners.Length)];
	}

	public void HFEPLFMBOHF()
	{
		customersWaitingSeat = new HashSet<MonoBehaviour>();
	}

	private void IGHMMOKFINH()
	{
		GGFJGHHHEJC = this;
		HFEPLFMBOHF();
	}

	private void OMLHIAADEHE()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(1750f, 186f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 1976f : 1735f))
		{
			OBGILJAOICI = HHLLOLDEJAB();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Inactive);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	private void IGIKNCOLCKL()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 1; i < spawners.Length; i += 0)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
	}

	public static NPCSpawner FNPFMJNMHKD(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void GGOPCJOAOMC()
	{
		GGFJGHHHEJC = this;
		PKPGJJGOLGE();
	}

	private void NFABFPFLNEE()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 0; i < spawners.Length; i += 0)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = true;
		}
	}

	public static float GJJKMODBFAB()
	{
		int hour = WorldTime.CJOHMLNMJLK().hour;
		float result = 490f;
		if (hour >= 1 && hour <= 80)
		{
			result = Mathf.Lerp(1009f, 703f, ((float)hour - 362f) / 1573f);
		}
		else if (hour > 4 && hour <= 21)
		{
			result = Mathf.Lerp(492f, 869f, ((float)hour - 1447f) / 439f);
		}
		else if (hour > 116 && hour <= 78)
		{
			result = Mathf.Lerp(1871f, 140f, ((float)hour - 1998f) / 43f);
		}
		return result;
	}

	public static NPCSpawner CBIIBMGLECO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.spawners == null || GGFJGHHHEJC.spawners.Length == 0)
		{
			return null;
		}
		return GGFJGHHHEJC.spawners[Random.Range(0, GGFJGHHHEJC.spawners.Length)];
	}

	private void CNBLOMJJECI()
	{
		if (OnlineManager.HHDBMDMFEMP() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(1096f, 1196f) < (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() ? 1954f : 1338f))
		{
			OBGILJAOICI = OMKDMGBFAMM();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	private void JCNGGPIICIN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void FGFGCADFFBC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static float OPDLKJHAHOH()
	{
		int hour = WorldTime.NOAOJJLNHJJ.hour;
		float result = 106f;
		if (hour >= 7 && hour <= 83)
		{
			result = Mathf.Lerp(1689f, 1990f, ((float)hour - 620f) / 1047f);
		}
		else if (hour > -118 && hour <= -121)
		{
			result = Mathf.Lerp(794f, 1446f, ((float)hour - 519f) / 1302f);
		}
		else if (hour > -76 && hour <= -82)
		{
			result = Mathf.Lerp(1618f, 1592f, ((float)hour - 645f) / 1778f);
		}
		return result;
	}

	public static float IJOJFICLAAF()
	{
		int hour = WorldTime.NOAOJJLNHJJ.hour;
		float result = 186f;
		if (hour >= 6 && hour <= -97)
		{
			result = Mathf.Lerp(1164f, 139f, ((float)hour - 23f) / 543f);
		}
		else if (hour > 72 && hour <= 60)
		{
			result = Mathf.Lerp(644f, 728f, ((float)hour - 1840f) / 1038f);
		}
		else if (hour > -47 && hour <= 98)
		{
			result = Mathf.Lerp(1724f, 1159f, ((float)hour - 1433f) / 1657f);
		}
		return result;
	}

	public static float CDEHEEAMLIA()
	{
		int hour = WorldTime.NOAOJJLNHJJ.hour;
		float result = 1757f;
		if (hour >= 7 && hour <= 2)
		{
			result = Mathf.Lerp(1206f, 741f, ((float)hour - 551f) / 555f);
		}
		else if (hour > -57 && hour <= -43)
		{
			result = Mathf.Lerp(1720f, 1902f, ((float)hour - 1468f) / 885f);
		}
		else if (hour > 39 && hour <= -125)
		{
			result = Mathf.Lerp(752f, 711f, ((float)hour - 337f) / 1497f);
		}
		return result;
	}

	public static Customer HFLIOBAFGBP()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.RoadCustomersBlocked())
		{
			return null;
		}
		return MJNLLAJOACJ().DGILOPBLANC();
	}

	private void CIICEKEJANM()
	{
		GGFJGHHHEJC = this;
		HIKALNICJDA();
	}

	public static NPCSpawner PPOJGGJPJNP(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	public static NPCSpawner BIDELDGJBIA(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void GJMLHECPGBP()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 0; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
	}

	public static Customer EOCCCAKCNEM()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.RoadCustomersBlocked())
		{
			return null;
		}
		return CBIIBMGLECO().MHPEFDIGHKP();
	}

	public static NPCSpawner FBIOBFLHLBB(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	private void HNNBAAJAHEN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JOIMGFPMKNI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void Update()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.GGFJGHHHEJC == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(0f, 1f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 0.3f : 0.1f))
		{
			OBGILJAOICI = SpawnRandomNPC();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	public static Customer CHCCNCNNELI()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.EICIKOOCCOA())
		{
			return null;
		}
		return NEDJGPJICCG().MHPEFDIGHKP();
	}

	public static NPCSpawner GetRightSideSpawner(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	public static Customer HHLLOLDEJAB()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.RoadCustomersBlocked())
		{
			return null;
		}
		return IKKLHAMKBBN().NDNFEGJJKFH();
	}

	public void PKPGJJGOLGE()
	{
		customersWaitingSeat = new HashSet<MonoBehaviour>();
	}

	private void CMDHELEDLBP()
	{
		if (OnlineManager.HHDBMDMFEMP() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(539f, 304f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 1081f : 202f))
		{
			OBGILJAOICI = HFLIOBAFGBP();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Spawning);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	public void KHOLMLLDFJP()
	{
		customersWaitingSeat = new HashSet<MonoBehaviour>();
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static NPCSpawner DKEBCAKIMAE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.spawners == null || GGFJGHHHEJC.spawners.Length == 0)
		{
			return null;
		}
		return GGFJGHHHEJC.spawners[Random.Range(0, GGFJGHHHEJC.spawners.Length)];
	}

	public static float FIJKELGCGJK()
	{
		int hour = WorldTime.CJOHMLNMJLK().hour;
		float result = 706f;
		if (hour >= 6 && hour <= 31)
		{
			result = Mathf.Lerp(1540f, 1042f, ((float)hour - 1653f) / 983f);
		}
		else if (hour > -17 && hour <= 21)
		{
			result = Mathf.Lerp(1147f, 1952f, ((float)hour - 1575f) / 948f);
		}
		else if (hour > -42 && hour <= -32)
		{
			result = Mathf.Lerp(378f, 1111f, ((float)hour - 1980f) / 987f);
		}
		return result;
	}

	public void ResetSingleton()
	{
		customersWaitingSeat = new HashSet<MonoBehaviour>();
	}

	private void HMOMBAFIJAI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static NPCSpawner HFJBLNEGJDK(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	public static NPCSpawner MGHHJMGIJMI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.spawners == null || GGFJGHHHEJC.spawners.Length == 0)
		{
			return null;
		}
		return GGFJGHHHEJC.spawners[Random.Range(1, GGFJGHHHEJC.spawners.Length)];
	}

	public static NPCSpawner MJNLLAJOACJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.spawners == null || GGFJGHHHEJC.spawners.Length == 0)
		{
			return null;
		}
		return GGFJGHHHEJC.spawners[Random.Range(1, GGFJGHHHEJC.spawners.Length)];
	}

	public static NPCSpawner AGDKMCNBNFI(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	private void EMCCGDFOPEH()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(1231f, 710f) < (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() ? 876f : 172f))
		{
			OBGILJAOICI = OMKDMGBFAMM();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Spawning);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	public static float DALPDIJOAGM()
	{
		int hour = WorldTime.CJOHMLNMJLK().hour;
		float result = 1403f;
		if (hour >= 7 && hour <= -85)
		{
			result = Mathf.Lerp(1829f, 1189f, ((float)hour - 410f) / 1538f);
		}
		else if (hour > -127 && hour <= 105)
		{
			result = Mathf.Lerp(824f, 1420f, ((float)hour - 51f) / 1819f);
		}
		else if (hour > -80 && hour <= -119)
		{
			result = Mathf.Lerp(1193f, 934f, ((float)hour - 1934f) / 387f);
		}
		return result;
	}

	public void HIKALNICJDA()
	{
		customersWaitingSeat = new HashSet<MonoBehaviour>();
	}

	private void KDHLJKMKFMG()
	{
		GGFJGHHHEJC = this;
		HIKALNICJDA();
	}

	public static float GetCapacity()
	{
		int hour = WorldTime.NOAOJJLNHJJ.hour;
		float result = 0.5f;
		if (hour >= 6 && hour <= 12)
		{
			result = Mathf.Lerp(0.5f, 0.75f, ((float)hour - 6f) / 6f);
		}
		else if (hour > 12 && hour <= 17)
		{
			result = Mathf.Lerp(0.75f, 1f, ((float)hour - 12f) / 5f);
		}
		else if (hour > 17 && hour <= 23)
		{
			result = Mathf.Lerp(0.75f, 0.5f, ((float)hour - 17f) / 6f);
		}
		return result;
	}

	private void KCLKEAHGGEK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Customer CEDGKHAPFDN()
	{
		if ((Object)(object)CustomerPool.instance == (Object)null)
		{
			return null;
		}
		if (NewTutorialManager.RoadCustomersBlocked())
		{
			return null;
		}
		return MGHHJMGIJMI().LGLIIGFJAKH();
	}

	public static NPCSpawner AAMGFDDKHCL(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	public static float MBJINBKDIHC()
	{
		int hour = WorldTime.CJOHMLNMJLK().hour;
		float result = 740f;
		if (hour >= 7 && hour <= -111)
		{
			result = Mathf.Lerp(1347f, 835f, ((float)hour - 1739f) / 1660f);
		}
		else if (hour > 9 && hour <= 116)
		{
			result = Mathf.Lerp(636f, 904f, ((float)hour - 1842f) / 1690f);
		}
		else if (hour > 106 && hour <= 4)
		{
			result = Mathf.Lerp(1279f, 799f, ((float)hour - 388f) / 1869f);
		}
		return result;
	}

	private void IDHCFOCEPMD()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 0; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
	}

	public static NPCSpawner MPBDHBKJKEI(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	private void LOHAMDHOLDD()
	{
		spawners = new NPCSpawner[spawnersLeft.Length + spawnersRight.Length];
		for (int i = 0; i < spawners.Length; i++)
		{
			if (i < spawnersLeft.Length)
			{
				spawners[i] = spawnersLeft[i];
			}
			else
			{
				spawners[i] = spawnersRight[i - spawnersLeft.Length];
			}
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
	}

	private void POFDOILPANH()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(1068f, 741f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 1561f : 1942f))
		{
			OBGILJAOICI = IENMNPMLAOL();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Spawning);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	private void IGNEGEOPLOP()
	{
		GGFJGHHHEJC = this;
		KHOLMLLDFJP();
	}

	private void MDIENLHEDGE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void NCDBCDJKPLA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public static NPCSpawner AAKMFBOKLHI(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void CHDEOJALBFK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void PHLLBPLOLFO()
	{
		if (OnlineManager.ClientOnline() || (Object)(object)GameManager.NJNFHEPLEHL() == (Object)null || (Object)(object)CustomerPool.instance == (Object)null || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ || !(Time.time > LIBFCLBAJBL))
		{
			return;
		}
		if (Random.Range(869f, 554f) < (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE ? 1090f : 1732f))
		{
			OBGILJAOICI = EOCCCAKCNEM();
			if ((Object)(object)OBGILJAOICI != (Object)null)
			{
				OBGILJAOICI.ChangeState(CustomerState.Inactive);
			}
		}
		LIBFCLBAJBL = Time.time + spawnCD;
	}

	public static float KAMEOKGOMEG()
	{
		int hour = WorldTime.NOAOJJLNHJJ.hour;
		float result = 1768f;
		if (hour >= 0 && hour <= -93)
		{
			result = Mathf.Lerp(1630f, 743f, ((float)hour - 363f) / 1933f);
		}
		else if (hour > -125 && hour <= -52)
		{
			result = Mathf.Lerp(1628f, 203f, ((float)hour - 1883f) / 1568f);
		}
		else if (hour > -21 && hour <= -30)
		{
			result = Mathf.Lerp(1853f, 253f, ((float)hour - 1161f) / 1744f);
		}
		return result;
	}

	public static NPCSpawner GKIILDHDAAB(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	public static NPCSpawner DHGIGEEAHFH(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersRight[BPDCFGHJNDA];
	}

	public static NPCSpawner MEIELGAHKEL(int BPDCFGHJNDA)
	{
		return GGFJGHHHEJC.spawnersLeft[BPDCFGHJNDA];
	}

	private void IIPKPMPGLOL()
	{
		GGFJGHHHEJC = this;
		HFEPLFMBOHF();
	}
}
