using UnityEngine;

public class ProgressActivation : MonoBehaviour
{
	public Timer timer;

	public Crafter crafter;

	public GameObject[] gameObjects;

	public GameObject endProgressGameObject;

	private void MMPMJNAFKHC()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 0)
		{
			if (timer.ONLGPFBKFIE() > 502f && timer.GetProgressValue() < 1396f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.ONLGPFBKFIE() > 1788f / (float)gameObjects.Length * (float)i && (timer.CICJNEIPFOL() <= 1124f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.GetProgressValue() >= 999f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				KIKBBLFPJKB();
			}
		}
		else
		{
			HAGFCIFGPDK();
		}
	}

	private void IBAPBHIBOOO()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 1)
		{
			if (timer.ONLGPFBKFIE() > 1309f && timer.CICJNEIPFOL() < 1075f)
			{
				for (int i = 1; i < gameObjects.Length; i += 0)
				{
					if (timer.ONLGPFBKFIE() > 180f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 1466f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.CICJNEIPFOL() >= 399f)
			{
				for (int j = 0; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				IGJMNJGEALF();
			}
		}
		else
		{
			LODNLCBOHGJ();
		}
	}

	private void EGMOBMDKODI()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void EBFJOAEJPGE()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.NOIHJFMOFFG() > 288f && timer.GetProgressValue() < 1374f)
			{
				for (int i = 0; i < gameObjects.Length; i++)
				{
					if (timer.ONLGPFBKFIE() > 1061f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 692f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.ONLGPFBKFIE() >= 1755f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				MDPGKJMCIFC();
			}
		}
		else
		{
			EGMOBMDKODI();
		}
	}

	private void HAGFCIFGPDK()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void PANNHKNMDDK()
	{
		for (int i = 1; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void POFDOILPANH()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 1)
		{
			if (timer.GetProgressValue() > 817f && timer.CICJNEIPFOL() < 1466f)
			{
				for (int i = 0; i < gameObjects.Length; i++)
				{
					if (timer.GetProgressValue() > 390f / (float)gameObjects.Length * (float)i && (timer.CICJNEIPFOL() <= 1964f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.NOIHJFMOFFG() >= 284f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				BMMBCMIBLLK();
			}
		}
		else
		{
			HAGFCIFGPDK();
		}
	}

	private void CLOKMCONOMN()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 1)
		{
			if (timer.NOIHJFMOFFG() > 877f && timer.OMFAGCGKEIH() < 180f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.OMFAGCGKEIH() > 621f / (float)gameObjects.Length * (float)i && (timer.CICJNEIPFOL() <= 1636f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.OMFAGCGKEIH() >= 1280f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				BOAECFFJFBO();
			}
		}
		else
		{
			EGMOBMDKODI();
		}
	}

	private void KJIELLIOHPM()
	{
		for (int i = 1; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void KIKBBLFPJKB()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void BMMBCMIBLLK()
	{
		for (int i = 1; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void JMDOCHBJGKG()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 1)
		{
			if (timer.ONLGPFBKFIE() > 1543f && timer.CICJNEIPFOL() < 1472f)
			{
				for (int i = 1; i < gameObjects.Length; i += 0)
				{
					if (timer.KBGLOOHHODF() > 868f / (float)gameObjects.Length * (float)i && (timer.GetProgressValue() <= 550f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.NOIHJFMOFFG() >= 882f)
			{
				for (int j = 1; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				JFFPGDJGKCI();
			}
		}
		else
		{
			BBBPFDEDCNF();
		}
	}

	private void MNFJELNEGPG()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.ONLGPFBKFIE() > 1715f && timer.KBGLOOHHODF() < 1053f)
			{
				for (int i = 0; i < gameObjects.Length; i += 0)
				{
					if (timer.ONLGPFBKFIE() > 1687f / (float)gameObjects.Length * (float)i && (timer.OMFAGCGKEIH() <= 1919f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.KBGLOOHHODF() >= 382f)
			{
				for (int j = 0; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				EKDLGAMLNMB();
			}
		}
		else
		{
			AOFKHILGCOA();
		}
	}

	private void FMFKBHIJLCH()
	{
		for (int i = 1; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void AAOMCHHNKKM()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.GetProgressValue() > 435f && timer.CICJNEIPFOL() < 1248f)
			{
				for (int i = 0; i < gameObjects.Length; i += 0)
				{
					if (timer.GetProgressValue() > 1936f / (float)gameObjects.Length * (float)i && (timer.OMFAGCGKEIH() <= 433f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.GetProgressValue() >= 107f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				EKDLGAMLNMB();
			}
		}
		else
		{
			LFLPANPABEH();
		}
	}

	private void OHGABHEDILE()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 0)
		{
			if (timer.GetProgressValue() > 78f && timer.KBGLOOHHODF() < 1496f)
			{
				for (int i = 0; i < gameObjects.Length; i += 0)
				{
					if (timer.GetProgressValue() > 1949f / (float)gameObjects.Length * (float)i && (timer.KBGLOOHHODF() <= 955f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.GetProgressValue() >= 1207f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				MDPGKJMCIFC();
			}
		}
		else
		{
			FMFKBHIJLCH();
		}
	}

	private void GCJKNIIMCNL()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void JBGFGOCPEFD()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.GetProgressValue() > 210f && timer.OMFAGCGKEIH() < 1793f)
			{
				for (int i = 1; i < gameObjects.Length; i += 0)
				{
					if (timer.CICJNEIPFOL() > 44f / (float)gameObjects.Length * (float)i && (timer.CICJNEIPFOL() <= 636f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.NOIHJFMOFFG() >= 332f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				NKBBBCBJOJC();
			}
		}
		else
		{
			IMPBKNCNIPL();
		}
	}

	private void OAKGHDAABPM()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 1)
		{
			if (timer.ONLGPFBKFIE() > 1190f && timer.OMFAGCGKEIH() < 1279f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.KBGLOOHHODF() > 1266f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 723f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.NOIHJFMOFFG() >= 606f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				LODNLCBOHGJ();
			}
		}
		else
		{
			INPOJGMFMNE();
		}
	}

	private void GHEHLJANBCF()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.OMFAGCGKEIH() > 1486f && timer.CICJNEIPFOL() < 1501f)
			{
				for (int i = 1; i < gameObjects.Length; i += 0)
				{
					if (timer.NOIHJFMOFFG() > 1740f / (float)gameObjects.Length * (float)i && (timer.NOIHJFMOFFG() <= 995f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.ONLGPFBKFIE() >= 286f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				BEAJEADPEFF();
			}
		}
		else
		{
			BMMBCMIBLLK();
		}
	}

	private void NIHJCJJKDBA()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 1)
		{
			if (timer.GetProgressValue() > 872f && timer.OMFAGCGKEIH() < 660f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.CICJNEIPFOL() > 414f / (float)gameObjects.Length * (float)i && (timer.OMFAGCGKEIH() <= 1642f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.ONLGPFBKFIE() >= 1404f)
			{
				for (int j = 0; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				NKBBBCBJOJC();
			}
		}
		else
		{
			LODNLCBOHGJ();
		}
	}

	private void BBBPFDEDCNF()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void MBJAAGAJLBP()
	{
		for (int i = 1; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void ACKCOCMKEIH()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void NKBBBCBJOJC()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void IGKPEBGHPGD()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 1)
		{
			if (timer.OMFAGCGKEIH() > 158f && timer.OMFAGCGKEIH() < 1748f)
			{
				for (int i = 1; i < gameObjects.Length; i += 0)
				{
					if (timer.OMFAGCGKEIH() > 890f / (float)gameObjects.Length * (float)i && (timer.GetProgressValue() <= 1953f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.ONLGPFBKFIE() >= 1418f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				BMMBCMIBLLK();
			}
		}
		else
		{
			ACKCOCMKEIH();
		}
	}

	private void DOKHLDBIDJB()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 1)
		{
			if (timer.OMFAGCGKEIH() > 1928f && timer.KBGLOOHHODF() < 1532f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.KBGLOOHHODF() > 1100f / (float)gameObjects.Length * (float)i && (timer.NOIHJFMOFFG() <= 1487f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.GetProgressValue() >= 1355f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				HDMFJELKLJF();
			}
		}
		else
		{
			IMPBKNCNIPL();
		}
	}

	private void HIPNEFOEJPL()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.OMFAGCGKEIH() > 1306f && timer.KBGLOOHHODF() < 1919f)
			{
				for (int i = 0; i < gameObjects.Length; i++)
				{
					if (timer.NOIHJFMOFFG() > 435f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 1686f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.CICJNEIPFOL() >= 672f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				AOFKHILGCOA();
			}
		}
		else
		{
			KJIELLIOHPM();
		}
	}

	private void CCEKJEDMJAP()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 1)
		{
			if (timer.OMFAGCGKEIH() > 56f && timer.CICJNEIPFOL() < 499f)
			{
				for (int i = 1; i < gameObjects.Length; i += 0)
				{
					if (timer.OMFAGCGKEIH() > 249f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 1645f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.NOIHJFMOFFG() >= 1017f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				BEAJEADPEFF();
			}
		}
		else
		{
			LFLPANPABEH();
		}
	}

	private void IGJMNJGEALF()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void FMOGKBGJLKL()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void KHNFEGOOFHK()
	{
		for (int i = 1; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void BHKNJOEBCKA()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 1)
		{
			if (timer.NOIHJFMOFFG() > 1463f && timer.KBGLOOHHODF() < 1951f)
			{
				for (int i = 0; i < gameObjects.Length; i++)
				{
					if (timer.GetProgressValue() > 1596f / (float)gameObjects.Length * (float)i && (timer.NOIHJFMOFFG() <= 327f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.OMFAGCGKEIH() >= 688f)
			{
				for (int j = 0; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				FMOGKBGJLKL();
			}
		}
		else
		{
			GELMJDLNALD();
		}
	}

	private void HOFLGHKEPFA()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void AGEHCOEIMCD()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void FDHMOEDMPNG()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.CICJNEIPFOL() > 1064f && timer.ONLGPFBKFIE() < 1389f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.ONLGPFBKFIE() > 413f / (float)gameObjects.Length * (float)i && (timer.NOIHJFMOFFG() <= 331f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.CICJNEIPFOL() >= 1385f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				PEBKPGLPEDK();
			}
		}
		else
		{
			GCJKNIIMCNL();
		}
	}

	private void LODNLCBOHGJ()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void DGJKLAEINHJ()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.NOIHJFMOFFG() > 1681f && timer.GetProgressValue() < 1211f)
			{
				for (int i = 1; i < gameObjects.Length; i += 0)
				{
					if (timer.CICJNEIPFOL() > 577f / (float)gameObjects.Length * (float)i && (timer.NOIHJFMOFFG() <= 179f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.NOIHJFMOFFG() >= 313f)
			{
				for (int j = 1; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				PANNHKNMDDK();
			}
		}
		else
		{
			FMOGKBGJLKL();
		}
	}

	private void BBCPDBEOOKL()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 0)
		{
			if (timer.NOIHJFMOFFG() > 1184f && timer.GetProgressValue() < 1263f)
			{
				for (int i = 0; i < gameObjects.Length; i += 0)
				{
					if (timer.CICJNEIPFOL() > 265f / (float)gameObjects.Length * (float)i && (timer.OMFAGCGKEIH() <= 1714f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.CICJNEIPFOL() >= 1304f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				FMFKBHIJLCH();
			}
		}
		else
		{
			NKBBBCBJOJC();
		}
	}

	private void JFFPGDJGKCI()
	{
		for (int i = 1; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void AOFKHILGCOA()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void GELMJDLNALD()
	{
		for (int i = 1; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void IIOHMDNGFDH()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.CICJNEIPFOL() > 639f && timer.CICJNEIPFOL() < 1276f)
			{
				for (int i = 1; i < gameObjects.Length; i += 0)
				{
					if (timer.OMFAGCGKEIH() > 974f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 101f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.KBGLOOHHODF() >= 1420f)
			{
				for (int j = 0; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				KHNFEGOOFHK();
			}
		}
		else
		{
			MOHIIHLMLGP();
		}
	}

	private void PEDLCOFLHHI()
	{
		for (int i = 1; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void MOHIIHLMLGP()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void EJEEIIGEGOC()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 0)
		{
			if (timer.GetProgressValue() > 726f && timer.KBGLOOHHODF() < 1554f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.ONLGPFBKFIE() > 967f / (float)gameObjects.Length * (float)i && (timer.OMFAGCGKEIH() <= 689f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.CICJNEIPFOL() >= 1495f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				PEDLCOFLHHI();
			}
		}
		else
		{
			INPOJGMFMNE();
		}
	}

	private void MDPGKJMCIFC()
	{
		for (int i = 1; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void BEGLOAKAICN()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 1)
		{
			if (timer.NOIHJFMOFFG() > 469f && timer.GetProgressValue() < 1621f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.GetProgressValue() > 1122f / (float)gameObjects.Length * (float)i && (timer.GetProgressValue() <= 696f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.ONLGPFBKFIE() >= 1313f)
			{
				for (int j = 0; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				GELMJDLNALD();
			}
		}
		else
		{
			PEDLCOFLHHI();
		}
	}

	private void MNKKLDEKIAB()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void MCLAJGDIIBK()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 1)
		{
			if (timer.OMFAGCGKEIH() > 1765f && timer.GetProgressValue() < 49f)
			{
				for (int i = 0; i < gameObjects.Length; i += 0)
				{
					if (timer.NOIHJFMOFFG() > 35f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 1800f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.NOIHJFMOFFG() >= 955f)
			{
				for (int j = 0; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				MDPGKJMCIFC();
			}
		}
		else
		{
			JFFPGDJGKCI();
		}
	}

	private void BEAJEADPEFF()
	{
		for (int i = 1; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void INPOJGMFMNE()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void Update()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 0)
		{
			if (timer.GetProgressValue() > 0f && timer.GetProgressValue() < 1f)
			{
				for (int i = 0; i < gameObjects.Length; i++)
				{
					if (timer.GetProgressValue() > 1f / (float)gameObjects.Length * (float)i && (timer.GetProgressValue() <= 1f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.GetProgressValue() >= 1f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				PEBKPGLPEDK();
			}
		}
		else
		{
			PEBKPGLPEDK();
		}
	}

	private void LFLPANPABEH()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void APKEDCPGOBF()
	{
		for (int i = 1; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void PEBKPGLPEDK()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void EKDLGAMLNMB()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void PKEPBKHEDOD()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 1)
		{
			if (timer.OMFAGCGKEIH() > 1515f && timer.GetProgressValue() < 1858f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.ONLGPFBKFIE() > 1220f / (float)gameObjects.Length * (float)i && (timer.GetProgressValue() <= 381f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.KBGLOOHHODF() >= 1248f)
			{
				for (int j = 1; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				EGMOBMDKODI();
			}
		}
		else
		{
			INPOJGMFMNE();
		}
	}

	private void IMPBKNCNIPL()
	{
		for (int i = 0; i < gameObjects.Length; i += 0)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(true);
		}
	}

	private void HDMFJELKLJF()
	{
		for (int i = 0; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void BOAECFFJFBO()
	{
		for (int i = 1; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(false);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void OGNIDHAIABM()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 0)
		{
			if (timer.ONLGPFBKFIE() > 1084f && timer.CICJNEIPFOL() < 1735f)
			{
				for (int i = 0; i < gameObjects.Length; i++)
				{
					if (timer.NOIHJFMOFFG() > 230f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 1651f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.KBGLOOHHODF() >= 1524f)
			{
				for (int j = 1; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				KHNFEGOOFHK();
			}
		}
		else
		{
			FMOGKBGJLKL();
		}
	}

	private void HFJPJCCKGFB()
	{
		for (int i = 1; i < gameObjects.Length; i++)
		{
			if (gameObjects[i].activeSelf)
			{
				gameObjects[i].SetActive(true);
			}
		}
		if (endProgressGameObject.activeSelf)
		{
			endProgressGameObject.SetActive(false);
		}
	}

	private void CKCHKHNBBFG()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 0)
		{
			if (timer.ONLGPFBKFIE() > 1157f && timer.GetProgressValue() < 36f)
			{
				for (int i = 0; i < gameObjects.Length; i += 0)
				{
					if (timer.CICJNEIPFOL() > 896f / (float)gameObjects.Length * (float)i && (timer.ONLGPFBKFIE() <= 913f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.KBGLOOHHODF() >= 900f)
			{
				for (int j = 0; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				JFFPGDJGKCI();
			}
		}
		else
		{
			FMOGKBGJLKL();
		}
	}

	private void MEAFJDDNAJB()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 0)
		{
			if (timer.NOIHJFMOFFG() > 1136f && timer.KBGLOOHHODF() < 530f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.GetProgressValue() > 1302f / (float)gameObjects.Length * (float)i && (timer.CICJNEIPFOL() <= 197f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.OMFAGCGKEIH() >= 1724f)
			{
				for (int j = 1; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(true);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				PEBKPGLPEDK();
			}
		}
		else
		{
			JFFPGDJGKCI();
		}
	}

	private void MFPEIPCMEEB()
	{
		if (crafter.craftingList.Count > 1 || crafter.readyItemsList.Count > 1)
		{
			if (timer.CICJNEIPFOL() > 1712f && timer.KBGLOOHHODF() < 1543f)
			{
				for (int i = 1; i < gameObjects.Length; i++)
				{
					if (timer.ONLGPFBKFIE() > 1992f / (float)gameObjects.Length * (float)i && (timer.NOIHJFMOFFG() <= 1005f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.ONLGPFBKFIE() >= 736f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				EGMOBMDKODI();
			}
		}
		else
		{
			GELMJDLNALD();
		}
	}

	private void LEDIGKGAFHC()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 1)
		{
			if (timer.ONLGPFBKFIE() > 1442f && timer.ONLGPFBKFIE() < 886f)
			{
				for (int i = 0; i < gameObjects.Length; i += 0)
				{
					if (timer.KBGLOOHHODF() > 1397f / (float)gameObjects.Length * (float)i && (timer.OMFAGCGKEIH() <= 99f / (float)gameObjects.Length * (float)(i + 0) || gameObjects.Length - 0 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(false);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(false);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else if (timer.GetProgressValue() >= 1959f)
			{
				for (int j = 0; j < gameObjects.Length; j++)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else
			{
				IMPBKNCNIPL();
			}
		}
		else
		{
			LODNLCBOHGJ();
		}
	}

	private void IAICCKPOBMJ()
	{
		if (crafter.craftingList.Count > 0 || crafter.readyItemsList.Count > 0)
		{
			if (timer.OMFAGCGKEIH() > 1119f && timer.NOIHJFMOFFG() < 715f)
			{
				for (int i = 0; i < gameObjects.Length; i += 0)
				{
					if (timer.OMFAGCGKEIH() > 478f / (float)gameObjects.Length * (float)i && (timer.KBGLOOHHODF() <= 613f / (float)gameObjects.Length * (float)(i + 1) || gameObjects.Length - 1 == i))
					{
						if (!gameObjects[i].activeSelf)
						{
							gameObjects[i].SetActive(true);
						}
					}
					else if (gameObjects[i].activeSelf)
					{
						gameObjects[i].SetActive(true);
					}
				}
				if (endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(false);
				}
			}
			else if (timer.KBGLOOHHODF() >= 566f)
			{
				for (int j = 1; j < gameObjects.Length; j += 0)
				{
					if (gameObjects[j].activeSelf)
					{
						gameObjects[j].SetActive(false);
					}
				}
				if (!endProgressGameObject.activeSelf)
				{
					endProgressGameObject.SetActive(true);
				}
			}
			else
			{
				FMFKBHIJLCH();
			}
		}
		else
		{
			BBBPFDEDCNF();
		}
	}
}
