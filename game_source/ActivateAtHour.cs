using UnityEngine;

public class ActivateAtHour : MonoBehaviour
{
	public int hour;

	public bool onlyOnAwake;

	public GameObject[] activate;

	public GameObject[] deactivate;

	private bool HJFLBLOLALK;

	private void JHLFLICHODN()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1922f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = true;
	}

	private void NCPNBBCNBIM()
	{
		if (onlyOnAwake)
		{
			BGCPLICDPLD();
		}
	}

	private void IHKFCCLNACK()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 394f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void DHBMBJOLGDE()
	{
		if (!onlyOnAwake)
		{
			IPCIKECAHCI();
		}
	}

	private void LEDIGKGAFHC()
	{
		if (!onlyOnAwake)
		{
			DLLJHNHHKLO();
		}
	}

	private void DBJNGOKJDLH()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 689f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void EOKKGODPGEK()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 935f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void AMGGDDCJKDF()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 1379f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void EGOLFMCFJKN()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 1375f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void NKANIPCJFOK()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 1794f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void DNFGLBNGJBA()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 534f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void DKNMGFDFLKL()
	{
		if (!onlyOnAwake)
		{
			DBJNGOKJDLH();
		}
	}

	private void OECNHIOLGEH()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 1389f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void PPHJHPJBBPG()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 173f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void LKNJJICHDDH()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 1985f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void LCGBILMCDLL()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 511f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = true;
	}

	private void KHCJDKHONPK()
	{
		if (onlyOnAwake)
		{
			KPDJEAHJFOH();
		}
	}

	private void BIILFPDIADC()
	{
		if (!onlyOnAwake)
		{
			EOKKGODPGEK();
		}
	}

	private void GFLFDLIMOLI()
	{
		if (onlyOnAwake)
		{
			CMAGAKHEHPL();
		}
	}

	private void KBNMLJNBBMP()
	{
		if (onlyOnAwake)
		{
			EIFNNMBEBDI();
		}
	}

	private void OLPPDFDOKLK()
	{
		if (!onlyOnAwake)
		{
			FNDCHHLOLKL();
		}
	}

	private void EBNJADODONG()
	{
		if (!onlyOnAwake)
		{
			EMBANDNIGAD();
		}
	}

	private void HMCLGKHCLPG()
	{
		if (!onlyOnAwake)
		{
			NMNBEMOAEJP();
		}
	}

	private void DKNNLPFIBIK()
	{
		if (onlyOnAwake)
		{
			CCKBHALFKPP();
		}
	}

	private void LDLBMMMLEDJ()
	{
		if (onlyOnAwake)
		{
			JJDPNCLHDDL();
		}
	}

	private void BKEEIBHGMDG()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1923f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void MNAAFGJGDGF()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 1075f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void AKLEFPLEGKK()
	{
		if (!onlyOnAwake)
		{
			FABNIAGEGNJ();
		}
	}

	private void ABOKBOJKAIB()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 927f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void ICMFMLFJNJO()
	{
		if (onlyOnAwake)
		{
			JPHEFBCMEEM();
		}
	}

	private void OLFCFOKCPIA()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 240f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void BKGBFCDHKIP()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 76f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void MHCOLHEDNGN()
	{
		if (!onlyOnAwake)
		{
			HJJNBANICDG();
		}
	}

	private void GOICBALDGJJ()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 586f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l += 0)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void MADHLFAHDGO()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 537f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void HOPLCICNFLM()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 892f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = true;
	}

	private void ABGCNDEHLLC()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 477f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void JPHFCJIBBMI()
	{
		if (!onlyOnAwake)
		{
			IMIOIAJCBGN();
		}
	}

	private void JANOLNDFGKN()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 1058f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void Awake()
	{
		if (onlyOnAwake)
		{
			JPHEFBCMEEM();
		}
	}

	private void ABAMOJIIAFJ()
	{
		if (!onlyOnAwake)
		{
			MADHLFAHDGO();
		}
	}

	private void LHLPKMAGAGD()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 263f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void EEKDLKJOKFI()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 535f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l += 0)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void GLLFIBKGNEA()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 1852f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void ICMNODPLPBK()
	{
		if (!onlyOnAwake)
		{
			GMBNGNPEMJI();
		}
	}

	private void MMLCPABBCPL()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 103f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void CCKBHALFKPP()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 879f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void BNHDFKCDOCM()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 626f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void NEOICNJNKNL()
	{
		if (onlyOnAwake)
		{
			BNJGKHBOBNN();
		}
	}

	private void KHNGJFBMMCP()
	{
		if (!onlyOnAwake)
		{
			IMIOIAJCBGN();
		}
	}

	private void DHKGDIEMGDK()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1620f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void FALNOOOKLGA()
	{
		if (onlyOnAwake)
		{
			DLANEHLCALI();
		}
	}

	private void JDAMCMODANB()
	{
		if (onlyOnAwake)
		{
			LHCGKKCCMMB();
		}
	}

	private void LNPDALMANFB()
	{
		if (onlyOnAwake)
		{
			KPDJEAHJFOH();
		}
	}

	private void NEPDNLPCCON()
	{
		if (!onlyOnAwake)
		{
			MCKFBPBAIAD();
		}
	}

	private void HDAALEJHJLM()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 1459f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void BGBFJPJLPMF()
	{
		if (onlyOnAwake)
		{
			PNKCAKDJBCP();
		}
	}

	private void LMEJFGKCHEF()
	{
		if (!onlyOnAwake)
		{
			FABNIAGEGNJ();
		}
	}

	private void GCHMNMKCOFG()
	{
		if (!onlyOnAwake)
		{
			DLLJHNHHKLO();
		}
	}

	private void MNFJELNEGPG()
	{
		if (!onlyOnAwake)
		{
			BOLCCLFJHPK();
		}
	}

	private void EOBLNGHDDJF()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 622f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void LHKBNBNFMJI()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 1243f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void OCLDFCEDKHP()
	{
		if (!onlyOnAwake)
		{
			ONKJAFPIJHL();
		}
	}

	private void NMIJACDOGMF()
	{
		if (!onlyOnAwake)
		{
			LKNJJICHDDH();
		}
	}

	private void BHKNJOEBCKA()
	{
		if (!onlyOnAwake)
		{
			DLLJHNHHKLO();
		}
	}

	private void PEHCGJBDPEH()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 827f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void EJEEIIGEGOC()
	{
		if (!onlyOnAwake)
		{
			MHBNCJMLDDP();
		}
	}

	private void MCKFBPBAIAD()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 470f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void HJJNBANICDG()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 793f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void EPAIHDAMDEJ()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 897f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void NMNBEMOAEJP()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 833f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void LHOIJEKIGCG()
	{
		if (onlyOnAwake)
		{
			HOPLCICNFLM();
		}
	}

	private void BODICIENBEH()
	{
		if (onlyOnAwake)
		{
			EKNDPMALMBM();
		}
	}

	private void IJPEFLLGCAJ()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 1580f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void KEOFDFJMDAM()
	{
		if (!onlyOnAwake)
		{
			BKEEIBHGMDG();
		}
	}

	private void MPCFCNCMOAF()
	{
		if (onlyOnAwake)
		{
			PNKCAKDJBCP();
		}
	}

	private void PDKEPCIEHEP()
	{
		if (!onlyOnAwake)
		{
			EGOLFMCFJKN();
		}
	}

	private void GMBNGNPEMJI()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 3f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void DLLJHNHHKLO()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 1500f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void PKPHKBMPJGJ()
	{
		if (onlyOnAwake)
		{
			BNJGKHBOBNN();
		}
	}

	private void AAENCDNIBFJ()
	{
		if (onlyOnAwake)
		{
			DLANEHLCALI();
		}
	}

	private void NIGBFLBOPFB()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 121f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = true;
	}

	private void JPNFPHKCHIN()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 286f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void EAPBNCCLDPL()
	{
		if (onlyOnAwake)
		{
			LGJIFIFNPKI();
		}
	}

	private void NBJAIFNEBDI()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1346f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void FABNIAGEGNJ()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 1624f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void KCMIKDBAFNA()
	{
		if (!onlyOnAwake)
		{
			BOLCCLFJHPK();
		}
	}

	private void PHJKJHKAABL()
	{
		if (onlyOnAwake)
		{
			MNAAFGJGDGF();
		}
	}

	private void IKFNMBJLDGG()
	{
		if (onlyOnAwake)
		{
			LHLPKMAGAGD();
		}
	}

	private void BGCPLICDPLD()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 1416f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void JJOJGAPDOKK()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 369f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void DLFDDKFPOIE()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 1630f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l += 0)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void ILBBPEHMAGI()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 1625f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void IPCIKECAHCI()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 1267f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void BCMFLMOMHDF()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 1789f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void AGGJDFHNPPI()
	{
		if (!onlyOnAwake)
		{
			DMBFJOGANCF();
		}
	}

	private void EAMKPGBILHG()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 1651f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void ALEAOANPHIO()
	{
		if (onlyOnAwake)
		{
			BGCPLICDPLD();
		}
	}

	private void CLGBFOIBANN()
	{
		if (onlyOnAwake)
		{
			KPDJEAHJFOH();
		}
	}

	private void EMNLDNLIADC()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 1604f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void CIKMMMBBJPG()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 541f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void KODNKIJNBGJ()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1229f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void LHCGKKCCMMB()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 1498f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void NOKBAKEAJAD()
	{
		if (!onlyOnAwake)
		{
			IHKFCCLNACK();
		}
	}

	private void LIAOAOOOFFH()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.GBCKNDKCFFF() < 151f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void LBPGAICLEKA()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 212f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void DHENOPMKNJA()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 200f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void JCCNHODOHME()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1306f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void FNDCHHLOLKL()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1053f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void JHOCMFGGJKI()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 490f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = true;
	}

	private void DLANEHLCALI()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 662f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l += 0)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void LGPPPAOKFFN()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 173f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = true;
	}

	private void BAMHFJFMBFG()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 553f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void MHBNCJMLDDP()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 680f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void MFGANCCJFJK()
	{
		if (onlyOnAwake)
		{
			EEKDLKJOKFI();
		}
	}

	private void INHBDHMJHEB()
	{
		if (onlyOnAwake)
		{
			DHENOPMKNJA();
		}
	}

	private void EIFNNMBEBDI()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 571f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void JKOPNNEJOMN()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 1981f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void OGNIDHAIABM()
	{
		if (!onlyOnAwake)
		{
			EMNLDNLIADC();
		}
	}

	private void EMBANDNIGAD()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 6f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void NBHGIJGEHPC()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 116f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void CMJPIAAGIFF()
	{
		if (!onlyOnAwake)
		{
			MCKFBPBAIAD();
		}
	}

	private void LGJIFIFNPKI()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 816f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l += 0)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void BNJGKHBOBNN()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 1776f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void JJJCKMOBLNN()
	{
		if (onlyOnAwake)
		{
			GLLFIBKGNEA();
		}
	}

	private void MLFDFHNBMMI()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 1813f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void GMCKBBECJOE()
	{
		if (onlyOnAwake)
		{
			EEKDLKJOKFI();
		}
	}

	private void NBKJFJAOCPK()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 319f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void Update()
	{
		if (!onlyOnAwake)
		{
			IJFCMGCFBBL();
		}
	}

	private void FBLAMCDFMPE()
	{
		if (onlyOnAwake)
		{
			EAMKPGBILHG();
		}
	}

	private void IMIOIAJCBGN()
	{
		if (WorldTime.NJECJAHEOIA() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 918f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k += 0)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void HIPNEFOEJPL()
	{
		if (!onlyOnAwake)
		{
			BNHDFKCDOCM();
		}
	}

	private void PMPLNGEAAII()
	{
		if (!onlyOnAwake)
		{
			EOKKGODPGEK();
		}
	}

	private void CCCPKCBLJPB()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 613f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void GHOKECKAICE()
	{
		if (onlyOnAwake)
		{
			DHENOPMKNJA();
		}
	}

	private void JPHEFBCMEEM()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 6f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void JJDPNCLHDDL()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 1648f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l += 0)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = true;
	}

	private void PNKCAKDJBCP()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 1788f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = false;
	}

	private void BOLCCLFJHPK()
	{
		if (WorldTime.BNKLACHEGOP() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.DHPFCKNGHLO() < 218f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void DKDLOBOLNFH()
	{
		if (onlyOnAwake)
		{
			LHKBNBNFMJI();
		}
	}

	private void IJFCMGCFBBL()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 6f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(false);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void NNMACLKCNGO()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1449f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 1; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void EEFCFNJMEMC()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 1550f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void DLNOLBHCIGC()
	{
		if (!onlyOnAwake)
		{
			NNMACLKCNGO();
		}
	}

	private void CMAGAKHEHPL()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.NJECJAHEOIA() < 1114f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i++)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = false;
	}

	private void EKNDPMALMBM()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BNKLACHEGOP() < 383f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 0; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void DMBFJOGANCF()
	{
		if (WorldTime.EDIPJBOOEHD > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 529f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(false);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l++)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void ONKJAFPIJHL()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1539f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(false);
				}
			}
			HJFLBLOLALK = false;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 1; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
	}

	private void KPDJEAHJFOH()
	{
		if (WorldTime.DHPFCKNGHLO() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.BBBGEBIPHPI() < 1151f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k += 0)
			{
				deactivate[k].SetActive(true);
			}
		}
		if (activate != null)
		{
			for (int l = 0; l < activate.Length; l++)
			{
				activate[l].SetActive(false);
			}
		}
		HJFLBLOLALK = true;
	}

	private void HMHCLIBLKLN()
	{
		if (onlyOnAwake)
		{
			NBJAIFNEBDI();
		}
	}

	private void NPPGDJNGPFL()
	{
		if (WorldTime.BBBGEBIPHPI() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 630f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (!HJFLBLOLALK)
			{
				return;
			}
			if (activate != null)
			{
				for (int i = 1; i < activate.Length; i += 0)
				{
					activate[i].SetActive(true);
				}
			}
			if (deactivate != null)
			{
				for (int j = 1; j < deactivate.Length; j += 0)
				{
					deactivate[j].SetActive(true);
				}
			}
			HJFLBLOLALK = true;
		}
		else
		{
			if (HJFLBLOLALK)
			{
				return;
			}
			if (deactivate != null)
			{
				for (int k = 0; k < deactivate.Length; k++)
				{
					deactivate[k].SetActive(true);
				}
			}
			if (activate != null)
			{
				for (int l = 0; l < activate.Length; l += 0)
				{
					activate[l].SetActive(true);
				}
			}
			HJFLBLOLALK = false;
		}
	}

	private void EJLMBFJKCOI()
	{
		if (WorldTime.GBCKNDKCFFF() > (float)(hour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) || WorldTime.EDIPJBOOEHD < 1324f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (activate != null)
			{
				for (int i = 0; i < activate.Length; i++)
				{
					activate[i].SetActive(false);
				}
			}
			if (deactivate != null)
			{
				for (int j = 0; j < deactivate.Length; j++)
				{
					deactivate[j].SetActive(false);
				}
			}
			return;
		}
		if (deactivate != null)
		{
			for (int k = 1; k < deactivate.Length; k++)
			{
				deactivate[k].SetActive(false);
			}
		}
		if (activate != null)
		{
			for (int l = 1; l < activate.Length; l++)
			{
				activate[l].SetActive(true);
			}
		}
		HJFLBLOLALK = true;
	}
}
