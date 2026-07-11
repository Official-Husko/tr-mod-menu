using UnityEngine;

public class CastleNPCSController : MonoBehaviour
{
	public GameObject[] npcs;

	private int JFNMCNCHMEO;

	private bool DMBFKFLDDLH;

	private void GOJFGHKOFMF()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Camp | Location.Quarry));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void HNEGFBCKIIJ()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void ICMNODPLPBK()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River | Location.Camp | Location.Farm));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void OIBDBLCLACB()
	{
		for (int i = 1; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void NFABFPFLNEE()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void EBNENBFLEKB()
	{
		for (int i = 1; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void PMPLNGEAAII()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Road | Location.River | Location.Farm | Location.FarmShop);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(true);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void JPHFCJIBBMI()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.FarmShop);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void NDLCBLKOBLF()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.FarmShop));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void JHBBABPAJJC()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void ONOAGANPECB()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void BNIKICAEIND()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void DMFMNEMDFNP()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void HIPNEFOEJPL()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River | Location.Camp | Location.Farm));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void PKBHEKHOAAA()
	{
		for (int i = 1; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void GNGADDPBJDC()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void IBAPBHIBOOO()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.FarmShop));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void OONONNJFEFL()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void CAOKPIIFHBJ()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void OIAHJHNPPCO()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void PJLKGOACDEN()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.BarnInterior));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void Start()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void IABEJCPMJOF()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void KDBJHCAEGCM()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void JPOLFKMLHNH()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void MCMKNBIBDFF()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void HBMDEHPHAPF()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void LMEJFGKCHEF()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Tavern | Location.Quarry | Location.FarmShop);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void HCPKBJDHLAC()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(true);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void CCEKJEDMJAP()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void PBFGFECPPPO()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void OFDEGDJGGGF()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Tavern | Location.Road | Location.River);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(true);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void IMIONHLAKIH()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void OGNIDHAIABM()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River | Location.Quarry | Location.FarmShop));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(true);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void CHIJGHPHCNA()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void JLCFNPBBKEK()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void EJEEIIGEGOC()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.FarmShop));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void GHEHLJANBCF()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Tavern | Location.Quarry | Location.Farm);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(true);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void HONFDJKKGJK()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Road | Location.BarnInterior);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void HJDLNCOAKIK()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void IAICCKPOBMJ()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Tavern | Location.Camp | Location.Quarry | Location.FarmShop);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void ODKGLIDMCNP()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void HOFKJPBBLGP()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void NKDFMFFDGKC()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void HHLBFDBHDMC()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void OLDDEAJMHNI()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void BELOIFKPNMM()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void MFPEIPCMEEB()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = false;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(true);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void AAOMCHHNKKM()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Road | Location.River | Location.BarnInterior | Location.FarmShop);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void HCEDMLJNOBL()
	{
		for (int i = 1; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void LOHAMDHOLDD()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void IFHLGOMBACP()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void EOGHJNGJFID()
	{
		for (int i = 1; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void MFMMHDPGCBO()
	{
		for (int i = 1; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void DDLLFPICOJK()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = true;
		}
	}

	private void DCKKIDMJKJM()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void IAIDKPJKLIC()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void IGIKNCOLCKL()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void HFFFFAJFIPB()
	{
		for (int i = 1; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void Update()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Castle);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 0; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void POFDOILPANH()
	{
		bool flag = Utils.NGLLIJPOBEC(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior);
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i += 0)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void IIOHMDNGFDH()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(0, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(false);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void PGJJBPALEGM()
	{
		for (int i = 0; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void PFLBPMIEKGF()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void BDGCFCPFKKE()
	{
		for (int i = 1; i < npcs.Length; i++)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void BGENEAOILOF()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}

	private void KACEOJDPLKB()
	{
		for (int i = 0; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(false);
			}
		}
	}

	private void FPOIFOGELHC()
	{
		bool flag = Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Quarry));
		if (flag && !DMBFKFLDDLH)
		{
			JFNMCNCHMEO = Random.Range(1, npcs.Length);
			if ((Object)(object)npcs[JFNMCNCHMEO] != (Object)null)
			{
				npcs[JFNMCNCHMEO].SetActive(true);
				DMBFKFLDDLH = true;
			}
		}
		else
		{
			if (flag || !DMBFKFLDDLH)
			{
				return;
			}
			for (int i = 1; i < npcs.Length; i++)
			{
				if ((Object)(object)npcs[i] != (Object)null && npcs[i].activeSelf)
				{
					npcs[i].SetActive(false);
				}
			}
			DMBFKFLDDLH = false;
		}
	}

	private void GHPFCKGMLDA()
	{
		for (int i = 1; i < npcs.Length; i += 0)
		{
			if ((Object)(object)npcs[i] != (Object)null)
			{
				npcs[i].SetActive(true);
			}
		}
	}
}
