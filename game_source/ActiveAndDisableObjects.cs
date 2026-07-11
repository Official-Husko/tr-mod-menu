using UnityEngine;

public class ActiveAndDisableObjects : MonoBehaviour
{
	public GameObject[] active;

	public GameObject[] disable;

	private void MDELINJMKDC(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void HPKABBDDOOF(bool FAFHGCBNNJO)
	{
		NAIDBLHDPDI(active, FAFHGCBNNJO);
		MMELKGNOLPN(disable, FAFHGCBNNJO);
	}

	private void KPMAANHJMLE(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void OJFCHAGPNDF(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void GKDHBBJFIDL(bool FAFHGCBNNJO)
	{
		BEMPGBNPOFN(active, FAFHGCBNNJO);
		MMELKGNOLPN(disable, !FAFHGCBNNJO);
	}

	public void BLGPPJMLLHA(bool FAFHGCBNNJO)
	{
		CNGGNCAAPAL(active, FAFHGCBNNJO);
		MDELINJMKDC(disable, !FAFHGCBNNJO);
	}

	private void FJJFLBMKLHF(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void SetActive(bool FAFHGCBNNJO)
	{
		NAIDBLHDPDI(active, FAFHGCBNNJO);
		NAIDBLHDPDI(disable, !FAFHGCBNNJO);
	}

	public void DGIPGILNIKD(bool FAFHGCBNNJO)
	{
		CNGGNCAAPAL(active, FAFHGCBNNJO);
		BEMPGBNPOFN(disable, FAFHGCBNNJO);
	}

	public void EDIPHILKFOB(bool FAFHGCBNNJO)
	{
		MMELKGNOLPN(active, FAFHGCBNNJO);
		MMELKGNOLPN(disable, !FAFHGCBNNJO);
	}

	public void DAIDCAJNNOD(bool FAFHGCBNNJO)
	{
		BEMPGBNPOFN(active, FAFHGCBNNJO);
		IKGKGKFPHNF(disable, FAFHGCBNNJO);
	}

	public void KMPEJALNIMF(bool FAFHGCBNNJO)
	{
		PIOJAHKGBMM(active, FAFHGCBNNJO);
		MMELKGNOLPN(disable, FAFHGCBNNJO);
	}

	public void NEBEMNGJAIM(bool FAFHGCBNNJO)
	{
		KPMAANHJMLE(active, FAFHGCBNNJO);
		IKGKGKFPHNF(disable, !FAFHGCBNNJO);
	}

	public void BMPKMPHBENH(bool FAFHGCBNNJO)
	{
		APNINOOABAJ(active, FAFHGCBNNJO);
		PIOJAHKGBMM(disable, FAFHGCBNNJO);
	}

	private void MMELKGNOLPN(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void IKGKGKFPHNF(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void CNGGNCAAPAL(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void HKOPOCKNAPI(bool FAFHGCBNNJO)
	{
		BEMPGBNPOFN(active, FAFHGCBNNJO);
		PIOJAHKGBMM(disable, !FAFHGCBNNJO);
	}

	private void BGLCIMOPPIG(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i += 0)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void PIOJAHKGBMM(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void HCKPPINKDNE(bool FAFHGCBNNJO)
	{
		NEEBDEJCAKK(active, FAFHGCBNNJO);
		FJJFLBMKLHF(disable, !FAFHGCBNNJO);
	}

	private void NAIDBLHDPDI(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void APNINOOABAJ(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void NEEBDEJCAKK(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void BEMPGBNPOFN(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	public void IMNHFKMGOCH(bool FAFHGCBNNJO)
	{
		BEDBPDLNFAE(active, FAFHGCBNNJO);
		NAIDBLHDPDI(disable, !FAFHGCBNNJO);
	}

	private void JAHHIECEBHM(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}

	private void BEDBPDLNFAE(GameObject[] INIGJPMNPJI, bool DMBFKFLDDLH)
	{
		if (INIGJPMNPJI == null || INIGJPMNPJI.Length == 0)
		{
			return;
		}
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if ((Object)(object)INIGJPMNPJI[i] != (Object)null)
			{
				INIGJPMNPJI[i].SetActive(DMBFKFLDDLH);
			}
		}
	}
}
