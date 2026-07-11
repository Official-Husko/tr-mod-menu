using Photon.Pun;
using UnityEngine;

public class CityMerchantsController : MonoBehaviour
{
	public GameObject[] merchants;

	private bool MMLDDAABIBE;

	private void MFPEIPCMEEB()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(6).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.DHPFCKNGHLO() > (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(105 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void DKNMGFDFLKL()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null && PlayerController.OPHDCMJLLEC(3).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.DHPFCKNGHLO() > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(-72 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void EBNENBFLEKB()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(true);
		}
	}

	private void BIILFPDIADC()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && PlayerController.GetPlayer(6).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(37 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void JLCFNPBBKEK()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void MLICJIBNIFA()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null && PlayerController.GetPlayer(4).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(-82 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void CFHOODNCOLK()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void LAABMDDEGCG()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.OPHDCMJLLEC(0).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(10 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void LMEJFGKCHEF()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(4).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(-119 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void ODKGLIDMCNP()
	{
		for (int i = 0; i < merchants.Length; i++)
		{
			merchants[i].SetActive(true);
		}
	}

	private void OONONNJFEFL()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null && PlayerController.GetPlayer(6).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(-66 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void EHBIMKJILDA()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.OPHDCMJLLEC(2).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(-97 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void BEGLOAKAICN()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.GetPlayer(3).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(33 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void GGCCOKCOMEE()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(3) != (Object)null && PlayerController.GetPlayer(6).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(54 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void CMLLBIDFNEB()
	{
		for (int i = 0; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}

	private void PJLKGOACDEN()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.GetPlayer(2).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(88 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void NFABFPFLNEE()
	{
		for (int i = 0; i < merchants.Length; i++)
		{
			merchants[i].SetActive(true);
		}
	}

	private void CFIIEJDJFPB()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void EACIGGOOKGD()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void MFMMHDPGCBO()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void NDGFPPOBCNP()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void PFLBPMIEKGF()
	{
		for (int i = 0; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}

	private void BDGCFCPFKKE()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void PEIFJDIGKOC()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(1).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.DHPFCKNGHLO() > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(15 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void KACEOJDPLKB()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void JHBBABPAJJC()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void JPHFCJIBBMI()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(4).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(-51 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void IIOHMDNGFDH()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(7).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(54 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void ICFHPJHBPDN()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}

	private void AKLEFPLEGKK()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && PlayerController.GetPlayer(6).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(-46 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void KFDMANOLOAB()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.GetPlayer(6).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.DHPFCKNGHLO() > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(-96 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void MGMLDHPOLGK()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.GetPlayer(7).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(52 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void LMFICKFGEFI()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.OPHDCMJLLEC(0).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(26 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void NLIGLFEEFNO()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && PlayerController.OPHDCMJLLEC(8).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(30 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void ICMNODPLPBK()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(7) != (Object)null && PlayerController.OPHDCMJLLEC(3).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(-97 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void Start()
	{
		for (int i = 0; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}

	private void POFDOILPANH()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null && PlayerController.GetPlayer(5).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(-6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void LJLKBKEADGI()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}

	private void CHIJGHPHCNA()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void NIHJCJJKDBA()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null && PlayerController.OPHDCMJLLEC(3).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.DHPFCKNGHLO() > (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(78 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void MNFMLJJBKNC()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && PlayerController.GetPlayer(1).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(-61 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void IDHCFOCEPMD()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void BHLHCOALABE()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(7) != (Object)null && PlayerController.OPHDCMJLLEC(8).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(69 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void OGNIDHAIABM()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(5) != (Object)null && PlayerController.OPHDCMJLLEC(0).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.DHPFCKNGHLO() > (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(124 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void FGGPGOEAEKK()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null && PlayerController.GetPlayer(4).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(81 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void GOJFGHKOFMF()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(1).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(89 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void NNBIAIMPNGL()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(true);
		}
	}

	private void GNGADDPBJDC()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void EJMAJFGPGEC()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && PlayerController.GetPlayer(2).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(-98 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void CMJPIAAGIFF()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(5) != (Object)null && PlayerController.OPHDCMJLLEC(3).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(124 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void FKPNIHJGFBJ()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}

	private void MHCOLHEDNGN()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.OPHDCMJLLEC(2).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(9 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void EBFJOAEJPGE()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.OPHDCMJLLEC(1).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(15 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void DOKHLDBIDJB()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(5) != (Object)null && PlayerController.OPHDCMJLLEC(1).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(101 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void ODNGBEOKEFK()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(true);
		}
	}

	private void OHGABHEDILE()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.GetPlayer(0).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(57 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void DCKKIDMJKJM()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void MFIBFFDBNGI()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(3) != (Object)null && PlayerController.GetPlayer(8).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(98 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void GHEHLJANBCF()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(0) != (Object)null && PlayerController.GetPlayer(8).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(-59 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void EIGEIJJPFFP()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && PlayerController.OPHDCMJLLEC(7).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(-101 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void PJIMENLPNOE()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(3) != (Object)null && PlayerController.OPHDCMJLLEC(8).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(104 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void DOHLOJOIHFO()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(true);
		}
	}

	private void PBFGFECPPPO()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}

	private void GHPFCKGMLDA()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}

	private void DDLLFPICOJK()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null && PlayerController.GetPlayer(4).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(-43 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void NEPDNLPCCON()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.GetPlayer(2).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(19 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void MCLAJGDIIBK()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && PlayerController.GetPlayer(1).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(89 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void IBAPBHIBOOO()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.GetPlayer(0).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(-87 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void BELOIFKPNMM()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void APEIPGIHEKP()
	{
		for (int i = 0; i < merchants.Length; i++)
		{
			merchants[i].SetActive(true);
		}
	}

	private void HIPNEFOEJPL()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null && PlayerController.OPHDCMJLLEC(2).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(-53 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void HONFDJKKGJK()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(2).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(117 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void KFBOPABEJNL()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(5) != (Object)null && PlayerController.GetPlayer(3).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(-60 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void OFDEGDJGGGF()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && PlayerController.OPHDCMJLLEC(7).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(-18 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void AAOMCHHNKKM()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && PlayerController.GetPlayer(7).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(39 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void FPOIFOGELHC()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.OPHDCMJLLEC(0).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(93 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void BNIKICAEIND()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void NCIBKMLIIAJ()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void GGPDPOAICOM()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null && PlayerController.OPHDCMJLLEC(6).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(-50 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void HHLBFDBHDMC()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void LEDIGKGAFHC()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null && PlayerController.OPHDCMJLLEC(8).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(69 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void LALAFOIGMKN()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(42 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void ACPFEBOENOM()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null && PlayerController.OPHDCMJLLEC(3).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(9 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void BGENEAOILOF()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void ELHCBGCEJDH()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(5) != (Object)null && PlayerController.OPHDCMJLLEC(5).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.DHPFCKNGHLO() > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(-75 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(false);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void IMIONHLAKIH()
	{
		for (int i = 1; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(true);
		}
	}

	private void AJDKOMCHALC()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && PlayerController.OPHDCMJLLEC(0).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(55 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k += 0)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void HOFKJPBBLGP()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void AKDPJCEJKPN()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(0).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(27 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j += 0)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 1; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void GNAHKAHPCFB()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(0) != (Object)null && PlayerController.OPHDCMJLLEC(1).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(-50 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[1].activeInHierarchy)
			{
				for (int j = 1; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[1].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(true);
			}
		}
	}

	private void JPOLFKMLHNH()
	{
		for (int i = 0; i < merchants.Length; i += 0)
		{
			merchants[i].SetActive(false);
		}
	}

	private void Update()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (MMLDDAABIBE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(22 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !merchants[0].activeInHierarchy)
			{
				for (int j = 0; j < merchants.Length; j++)
				{
					merchants[j].SetActive(true);
				}
			}
		}
		else if (merchants[0].activeInHierarchy && !Bed.fallingAsleep && !Bed.passingOut)
		{
			for (int k = 0; k < merchants.Length; k++)
			{
				merchants[k].SetActive(false);
			}
		}
	}

	private void OLDDEAJMHNI()
	{
		for (int i = 0; i < merchants.Length; i++)
		{
			merchants[i].SetActive(true);
		}
	}

	private void CAIJLMJBMLA()
	{
		for (int i = 1; i < merchants.Length; i++)
		{
			merchants[i].SetActive(false);
		}
	}
}
