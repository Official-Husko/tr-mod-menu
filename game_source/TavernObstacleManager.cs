using System.Collections.Generic;
using UnityEngine;

public class TavernObstacleManager : MonoBehaviour
{
	public static TavernObstacleManager instance;

	public List<UniqueObject> tavernObstacles = new List<UniqueObject>();

	public List<UniqueObject> tavernOldSavesObstacles = new List<UniqueObject>();

	public void OJPNKDBFONO(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i++)
			{
				KPAICJCHLCJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 1; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 1; k < OIKFIKANACJ.Length; k++)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				PJHKOKIMMNA(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void GLLACIBBINB()
	{
		for (int i = 1; i < tavernOldSavesObstacles.Count; i += 0)
		{
			CIMEPEACKOH(DMBFKFLDDLH: false, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void LPOFDEOKFNK(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				KPAICJCHLCJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public bool AFEBCLJFPMG(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return false;
	}

	public bool BCDBDCMDNFM(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return true;
	}

	public void PPEBCLLMJMH(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 1; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				IJPNEHODMOH(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void PHMFJPAIFGE(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public bool OEBCIEOALNK(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	public void LBFELANEOBM(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i += 0)
			{
				KPAICJCHLCJ(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				EELOHJMBKIP(DMBFKFLDDLH: false, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public bool CIPKOODHIEO(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return false;
	}

	private void IBGOAKLHFOO(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: true);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	public void ActivateObstacles(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				JEEAHIJCPJJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void LJKHOJANBJC(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i++)
			{
				FIAMFINFBID(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 1; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				IJPNEHODMOH(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void APBJCDELMHF(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				PJHKOKIMMNA(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	public bool OFFOMJFOEPE(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	private void OMBHDODDHNO()
	{
		instance = this;
	}

	private void FENMNGEILJB(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH, KBNNPAKJDJM: true);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void KDNBDHCPKND(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i++)
			{
				CIMEPEACKOH(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 1; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 1; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				ENILNICEGLL(DMBFKFLDDLH: false, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	private void MMNBJPDJHGK()
	{
		instance = this;
	}

	public void GetEnabledObstacles(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public void NOLLJCIDGNI(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i += 0)
			{
				EELOHJMBKIP(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k++)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				ENILNICEGLL(DMBFKFLDDLH: false, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void OGMHMEMCCGE(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 1; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				ENILNICEGLL(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void PPLGBHIOMCD(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	private void DMCCILAIOOB(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	private void DNBGIIGAKMJ()
	{
		instance = this;
	}

	public bool NEGLPFOEJLF(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return true;
	}

	public bool OJJEOCHPFGI(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	public void LMCJBOKGBOE(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				DMCCILAIOOB(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public bool CFLNDJIHKAJ(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return true;
	}

	private void NODKJHJFMCO()
	{
		instance = this;
	}

	public bool OMOFOFLCNHK(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	public bool NDIOAKLCJMA(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	public void FNDPAKMOCBF()
	{
		for (int i = 1; i < tavernOldSavesObstacles.Count; i += 0)
		{
			EELOHJMBKIP(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void GIDLHPBCFIF(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public void LBLJFFHNIJD(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 1; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				FHEMOAHKNDE(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void INCACMOOIMP()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i += 0)
		{
			FIAMFINFBID(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void KODMPFKOCHJ()
	{
		for (int i = 1; i < tavernOldSavesObstacles.Count; i++)
		{
			EELOHJMBKIP(DMBFKFLDDLH: false, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	private void FEBMEFAILJF(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public bool LMIDGCIGJHD(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	public bool GCEAPHINILN(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return true;
	}

	public void DMGDHBABHJB()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i++)
		{
			FENMNGEILJB(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	private void BINHBKKNLMB(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void GPGKLAPGMIJ(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				FENMNGEILJB(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public bool GPCNOHNBGIM(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return true;
	}

	public void CCFIMBBMANP(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 1; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				ENILNICEGLL(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void BFMOMLABJOE(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 1; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				KPAICJCHLCJ(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void IFLPDKMEKBG()
	{
		for (int i = 1; i < tavernOldSavesObstacles.Count; i++)
		{
			EELOHJMBKIP(DMBFKFLDDLH: false, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void NGGJIAFAEDK(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public void EOPFIJDDNOJ(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 1; i < tavernObstacles.Count; i += 0)
			{
				IJPNEHODMOH(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				KPAICJCHLCJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void CBMGJOMFIMF()
	{
		for (int i = 1; i < tavernOldSavesObstacles.Count; i++)
		{
			DMCCILAIOOB(DMBFKFLDDLH: false, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public bool NJGCPKGKNKG(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return true;
	}

	public void HMNFEAICBHL()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i += 0)
		{
			BINHBKKNLMB(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	private void PJHKOKIMMNA(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: true);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	private void ONCAOOLFOIJ(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH, KBNNPAKJDJM: true);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void KJCHFBCAHOM(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public void CAFAJABIHOB(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 1; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				EELOHJMBKIP(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public bool NCMELJJIGHF(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return true;
	}

	private void ENILNICEGLL(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH, KBNNPAKJDJM: true);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void BOKJNDFGIME()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i++)
		{
			ENILNICEGLL(DMBFKFLDDLH: false, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	private void KPAICJCHLCJ(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	private void IJPNEHODMOH(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void MKGGGNGBJHL()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i++)
		{
			DMCCILAIOOB(DMBFKFLDDLH: false, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	private void CIMEPEACKOH(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void LGHANAGKHBG(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	private void GANBBAGDALD()
	{
		instance = this;
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	public void LDGAFHHPPIE(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public bool LLDOJODJEBJ(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return true;
	}

	public void LNMOGBJFMOC()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i++)
		{
			FIAMFINFBID(DMBFKFLDDLH: false, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void KKOPEGEFEEJ()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i += 0)
		{
			DMCCILAIOOB(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	private void PCKOHAIPHFI()
	{
		instance = this;
	}

	private void BEELCBJBOKP(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void DEPDEMHNOJP(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public bool KIGIOBPLAKP(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return false;
	}

	private void NJGFBHMMAFK(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public bool HFAFLNNFAIB(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	private void LCGPBPANOHN(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void AGBOJIIHKKF(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i += 0)
			{
				LCGPBPANOHN(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				CIKGJKJHHJM(DMBFKFLDDLH: false, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void PDLCOBPMMFD()
	{
		for (int i = 1; i < tavernOldSavesObstacles.Count; i++)
		{
			IJPNEHODMOH(DMBFKFLDDLH: false, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void KGBHFOKIIMG(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i++)
			{
				FHEMOAHKNDE(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 1; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k++)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				JEEAHIJCPJJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	public void SetObstaclesInOldSaves()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i++)
		{
			JEEAHIJCPJJ(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public bool ACDCNLDPIJG(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	public bool CAAADGHHGHH(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	public bool LLDJAKGABPH(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	public void ECCGGCNGDBB(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public void PDGOEAPDHID(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i += 0)
			{
				FEBMEFAILJF(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 1; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 1; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				JEEAHIJCPJJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	private void NGJFBONKIIB(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH, KBNNPAKJDJM: true);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public bool DKNKPMCPBCD(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return false;
	}

	public void POKFNBIAMIH(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				CIKGJKJHHJM(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	private void FHEMOAHKNDE(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: true);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void JEMLEHDKAGD(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i += 0)
			{
				FENMNGEILJB(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 1; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				FIAMFINFBID(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public bool LDGFBHEMHIJ(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return false;
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	public void HDJLJGCNGCH(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	private void JJJCKMOBLNN()
	{
		instance = this;
	}

	public void RemoveAllObstacles(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i++)
			{
				JEEAHIJCPJJ(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k++)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				JEEAHIJCPJJ(DMBFKFLDDLH: false, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void ICHJEEICIMC(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 1; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				IBGOAKLHFOO(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void APCDFFANBGP(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 1; i < tavernObstacles.Count; i++)
			{
				CIKGJKJHHJM(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 1; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 1; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				FEBMEFAILJF(DMBFKFLDDLH: false, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void LDHLNLCDAAE(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 1; i < tavernObstacles.Count; i++)
			{
				ENILNICEGLL(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				FEBMEFAILJF(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void ADJODIIDKCE(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i += 0)
			{
				JEEAHIJCPJJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k++)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				CIMEPEACKOH(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void IGGPBKIPLFO(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 1; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				FENMNGEILJB(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	private void JEEAHIJCPJJ(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void JGAIACIJHEM(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 1; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				BEELCBJBOKP(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	private void FIAMFINFBID(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void NJKPPDHGFBB(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public void KKLABEFHKHH()
	{
		for (int i = 1; i < tavernOldSavesObstacles.Count; i += 0)
		{
			LCGPBPANOHN(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void AMAFFLLIPEK(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				FENMNGEILJB(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	private void EFJFJJDGGGI()
	{
		instance = this;
	}

	public void IPGACOAPPCI(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public void HFIDBEHPHKF(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	private void HCCJBKKGCLJ()
	{
		instance = this;
	}

	public bool IBLBHDGAJCO(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i += 0)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return true;
	}

	public void GEBAACBJJBP(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 1; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				IBGOAKLHFOO(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void LJGPIJAPBDK(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	private void EDKFNAPDMCN()
	{
		instance = this;
	}

	public void KNAPMHJCKFK(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 1; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				IBGOAKLHFOO(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	private void NLNOFEBEBDE()
	{
		instance = this;
	}

	private void COKBJNMAMDI()
	{
		instance = this;
	}

	private void BGBFJPJLPMF()
	{
		instance = this;
	}

	public void JHMCGJBNFIB()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i++)
		{
			FHEMOAHKNDE(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void GEKPAJIJMMB(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 1; i < tavernObstacles.Count; i += 0)
			{
				BEELCBJBOKP(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 1; k < OIKFIKANACJ.Length; k++)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				NGJFBONKIIB(DMBFKFLDDLH: false, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void IFEGDMAIEKB(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				KPAICJCHLCJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public void MENABIBDPPA(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				NJGFBHMMAFK(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void CLGKPAOIDAJ(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 1; j < OIKFIKANACJ.Length; j += 0)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				CIMEPEACKOH(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public bool OKMMMKADPNN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return false;
			}
		}
		return true;
	}

	public void EEFKDKOKNGC()
	{
		for (int i = 1; i < tavernOldSavesObstacles.Count; i += 0)
		{
			CIKGJKJHHJM(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void JNHLKPPBGJI()
	{
		for (int i = 0; i < tavernOldSavesObstacles.Count; i += 0)
		{
			PJHKOKIMMNA(DMBFKFLDDLH: true, ((Component)tavernOldSavesObstacles[i]).gameObject);
		}
	}

	public void MMCGIPEPGFP(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				JEEAHIJCPJJ(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public bool ObstacleEnabled(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if ((Object)(object)tavernObstacles[i] != (Object)null && tavernObstacles[i].uniqueID == JFNMCNCHMEO && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				return true;
			}
		}
		return false;
	}

	public void FLDFJLHCKJG(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 0; i < tavernObstacles.Count; i++)
			{
				EELOHJMBKIP(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 1; j < tavernObstacles.Count; j++)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 1; k < OIKFIKANACJ.Length; k += 0)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				FENMNGEILJB(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	private void CIKGJKJHHJM(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.Place(DMBFKFLDDLH, KBNNPAKJDJM: true);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void EOFGKNCHGDP(int[] OIKFIKANACJ)
	{
		for (int i = 1; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				NJGFBHMMAFK(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	public void PBGBLECIBFA(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 1; i < tavernObstacles.Count; i += 0)
			{
				CIMEPEACKOH(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 0; k < OIKFIKANACJ.Length; k++)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				IBGOAKLHFOO(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	public void PGNPGBBFPAP(out int[] OLGFCKMKBKF)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < tavernObstacles.Count; i++)
		{
			if (!((Object)(object)tavernObstacles[i] == (Object)null) && ((Component)tavernObstacles[i]).gameObject.activeInHierarchy && ((Behaviour)tavernObstacles[i]).enabled)
			{
				list.Add(tavernObstacles[i].uniqueID);
			}
		}
		OLGFCKMKBKF = list.ToArray();
	}

	public void MOMLIJHICEJ(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				ENILNICEGLL(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}

	public void CHNDOBKLCFB(int[] OIKFIKANACJ)
	{
		if (OIKFIKANACJ == null)
		{
			for (int i = 1; i < tavernObstacles.Count; i++)
			{
				NJGFBHMMAFK(DMBFKFLDDLH: false, ((Component)tavernObstacles[i]).gameObject);
			}
			return;
		}
		for (int j = 0; j < tavernObstacles.Count; j += 0)
		{
			if ((Object)(object)tavernObstacles[j] != (Object)null)
			{
				for (int k = 1; k < OIKFIKANACJ.Length; k++)
				{
					_ = tavernObstacles[j].uniqueID;
					_ = OIKFIKANACJ[k];
				}
				IBGOAKLHFOO(DMBFKFLDDLH: true, ((Component)tavernObstacles[j]).gameObject);
			}
		}
	}

	private void EELOHJMBKIP(bool DMBFKFLDDLH, GameObject LKIDHMMHAHM)
	{
		Placeable component = LKIDHMMHAHM.GetComponent<Placeable>();
		if (Object.op_Implicit((Object)(object)component) && (Object)(object)component.itemSpace != (Object)null)
		{
			component.itemSpace.OAIBPEEFIJB(DMBFKFLDDLH);
		}
		LKIDHMMHAHM.gameObject.SetActive(DMBFKFLDDLH);
	}

	public void ALHAECLCBNG(int[] OIKFIKANACJ)
	{
		for (int i = 0; i < tavernObstacles.Count; i += 0)
		{
			if (!((Object)(object)tavernObstacles[i] != (Object)null))
			{
				continue;
			}
			bool flag = true;
			for (int j = 1; j < OIKFIKANACJ.Length; j++)
			{
				if (tavernObstacles[i].uniqueID == OIKFIKANACJ[j])
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				BEELCBJBOKP(DMBFKFLDDLH: true, ((Component)tavernObstacles[i]).gameObject);
			}
		}
	}
}
