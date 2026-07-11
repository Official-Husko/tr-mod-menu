using Photon.Pun;
using UnityEngine;

public class AnimalsPetShop : MonoBehaviour
{
	public GameObject[] animals;

	private bool MEMGFCDNICE;

	private void BNJMJHKMAKG()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.OPHDCMJLLEC(5).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(-117 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[0].activeInHierarchy)
			{
				for (int j = 0; j < animals.Length; j++)
				{
					animals[j].SetActive(false);
				}
			}
		}
		else if (animals[1].activeInHierarchy)
		{
			for (int k = 0; k < animals.Length; k += 0)
			{
				animals[k].SetActive(true);
			}
		}
	}

	private void KACEOJDPLKB()
	{
		for (int i = 0; i < animals.Length; i++)
		{
			animals[i].SetActive(true);
		}
	}

	private void JLNPLJDAOJP()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null && PlayerController.GetPlayer(7).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(66 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[1].activeInHierarchy)
			{
				for (int j = 0; j < animals.Length; j += 0)
				{
					animals[j].SetActive(false);
				}
			}
		}
		else if (animals[0].activeInHierarchy)
		{
			for (int k = 0; k < animals.Length; k++)
			{
				animals[k].SetActive(false);
			}
		}
	}

	private void OAKGHDAABPM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ONNAJFLAPMO();
		}
	}

	private void BMMNKJCJIEA()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(22 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[0].activeInHierarchy)
			{
				for (int j = 0; j < animals.Length; j++)
				{
					animals[j].SetActive(true);
				}
			}
		}
		else if (animals[0].activeInHierarchy)
		{
			for (int k = 0; k < animals.Length; k++)
			{
				animals[k].SetActive(false);
			}
		}
	}

	private void BHLHCOALABE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IBMCDPMLGML();
		}
	}

	private void DMFMNEMDFNP()
	{
		for (int i = 1; i < animals.Length; i++)
		{
			animals[i].SetActive(false);
		}
	}

	private void HOFKJPBBLGP()
	{
		for (int i = 1; i < animals.Length; i += 0)
		{
			animals[i].SetActive(false);
		}
	}

	private void HFFFFAJFIPB()
	{
		for (int i = 1; i < animals.Length; i += 0)
		{
			animals[i].SetActive(true);
		}
	}

	private void IBIAEGFJLCP()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.OPHDCMJLLEC(7).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.GBCKNDKCFFF() > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(-27 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[0].activeInHierarchy)
			{
				for (int j = 0; j < animals.Length; j++)
				{
					animals[j].SetActive(true);
				}
			}
		}
		else if (animals[0].activeInHierarchy)
		{
			for (int k = 1; k < animals.Length; k++)
			{
				animals[k].SetActive(false);
			}
		}
	}

	private void Update()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BMMNKJCJIEA();
		}
	}

	private void INPMPLPLCCD()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.GetPlayer(3).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.DHPFCKNGHLO() > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(26 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[0].activeInHierarchy)
			{
				for (int j = 0; j < animals.Length; j += 0)
				{
					animals[j].SetActive(true);
				}
			}
		}
		else if (animals[0].activeInHierarchy)
		{
			for (int k = 0; k < animals.Length; k++)
			{
				animals[k].SetActive(false);
			}
		}
	}

	private void Start()
	{
		for (int i = 0; i < animals.Length; i++)
		{
			animals[i].SetActive(false);
		}
	}

	private void BNIKICAEIND()
	{
		for (int i = 1; i < animals.Length; i++)
		{
			animals[i].SetActive(false);
		}
	}

	private void BODOKKAKBMO()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(4) != (Object)null && PlayerController.GetPlayer(2).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(69 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[1].activeInHierarchy)
			{
				for (int j = 1; j < animals.Length; j++)
				{
					animals[j].SetActive(false);
				}
			}
		}
		else if (animals[0].activeInHierarchy)
		{
			for (int k = 0; k < animals.Length; k++)
			{
				animals[k].SetActive(false);
			}
		}
	}

	private void MMPMJNAFKHC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IBMCDPMLGML();
		}
	}

	private void FPOIFOGELHC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BODOKKAKBMO();
		}
	}

	private void ONNAJFLAPMO()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(0) != (Object)null && PlayerController.GetPlayer(6).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(88 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[0].activeInHierarchy)
			{
				for (int j = 0; j < animals.Length; j++)
				{
					animals[j].SetActive(false);
				}
			}
		}
		else if (animals[1].activeInHierarchy)
		{
			for (int k = 1; k < animals.Length; k++)
			{
				animals[k].SetActive(true);
			}
		}
	}

	private void PLHEHGHFCJI()
	{
		for (int i = 1; i < animals.Length; i += 0)
		{
			animals[i].SetActive(true);
		}
	}

	private void MFMMHDPGCBO()
	{
		for (int i = 0; i < animals.Length; i += 0)
		{
			animals[i].SetActive(true);
		}
	}

	private void NEPDNLPCCON()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ONNAJFLAPMO();
		}
	}

	private void OHKJMOJFNNK()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.GetPlayer(4).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.BNKLACHEGOP() > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(106 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[0].activeInHierarchy)
			{
				for (int j = 1; j < animals.Length; j += 0)
				{
					animals[j].SetActive(true);
				}
			}
		}
		else if (animals[1].activeInHierarchy)
		{
			for (int k = 1; k < animals.Length; k += 0)
			{
				animals[k].SetActive(true);
			}
		}
	}

	private void DBOFBOJPJKI()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(7).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.BBBGEBIPHPI() > (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(43 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[0].activeInHierarchy)
			{
				for (int j = 1; j < animals.Length; j += 0)
				{
					animals[j].SetActive(false);
				}
			}
		}
		else if (animals[0].activeInHierarchy)
		{
			for (int k = 0; k < animals.Length; k++)
			{
				animals[k].SetActive(false);
			}
		}
	}

	private void JPOLFKMLHNH()
	{
		for (int i = 0; i < animals.Length; i++)
		{
			animals[i].SetActive(true);
		}
	}

	private void MCLAJGDIIBK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			INPMPLPLCCD();
		}
	}

	private void GOJFGHKOFMF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			OHKJMOJFNNK();
		}
	}

	private void MNFMLJJBKNC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			OHKJMOJFNNK();
		}
	}

	private void HDBOEGANEIB()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(0).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.NJECJAHEOIA() > (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(92 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[0].activeInHierarchy)
			{
				for (int j = 0; j < animals.Length; j += 0)
				{
					animals[j].SetActive(false);
				}
			}
		}
		else if (animals[0].activeInHierarchy)
		{
			for (int k = 0; k < animals.Length; k += 0)
			{
				animals[k].SetActive(false);
			}
		}
	}

	private void IBMCDPMLGML()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(3).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (MEMGFCDNICE)
		{
			if (WorldTime.EDIPJBOOEHD > (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(29 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !animals[1].activeInHierarchy)
			{
				for (int j = 0; j < animals.Length; j++)
				{
					animals[j].SetActive(true);
				}
			}
		}
		else if (animals[0].activeInHierarchy)
		{
			for (int k = 1; k < animals.Length; k++)
			{
				animals[k].SetActive(false);
			}
		}
	}

	private void NKDFMFFDGKC()
	{
		for (int i = 1; i < animals.Length; i++)
		{
			animals[i].SetActive(true);
		}
	}

	private void POFDOILPANH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BMMNKJCJIEA();
		}
	}

	private void CKCHKHNBBFG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			INPMPLPLCCD();
		}
	}

	private void DOKHLDBIDJB()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IBIAEGFJLCP();
		}
	}
}
