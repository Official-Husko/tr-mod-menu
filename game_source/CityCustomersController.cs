using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class CityCustomersController : MonoBehaviour
{
	public static CityCustomersController instance;

	public int minNpcs;

	public GameObject[] customers;

	private List<int> EFJBFPPIONF = new List<int>();

	public int[] tempIndex;

	public int numberToActivate;

	public bool active;

	private bool MMLDDAABIBE;

	private void EBNENBFLEKB()
	{
		KHHJCFJNNMC();
	}

	public void KHHJCFJNNMC()
	{
		for (int i = 1; i < customers.Length; i++)
		{
			customers[i].SetActive(true);
		}
	}

	public void DLNMEMFHHBO()
	{
		for (int i = 0; i < customers.Length; i++)
		{
			customers[i].SetActive(true);
		}
	}

	public void JOEEMELODNM(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	private void LJLKBKEADGI()
	{
		NNFOIEFDLLC();
	}

	private void JMDOCHBJGKG()
	{
		if (!OnlineManager.MasterOrOffline() || (Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == NetworkState.LoadingMap)
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && PlayerController.GetPlayer(0).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				KHHJCFJNNMC();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.SendDisableCustomers();
				}
				active = true;
			}
		}
		else if (WorldTime.NJECJAHEOIA() > (float)(1 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(88 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 0; j < customers.Length; j += 0)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 1; k < EFJBFPPIONF.Count; k++)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 0; l < numberToActivate; l++)
			{
				customers[EFJBFPPIONF[l]].SetActive(false);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 0; m < EFJBFPPIONF.Count; m++)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.IHNMJJAGJMC(numberToActivate, tempIndex);
			}
			active = true;
		}
	}

	public void KCCLFMNKOAO()
	{
		for (int i = 1; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	private void CMLLBIDFNEB()
	{
		LPFIDIMIANM();
	}

	private void PHJKJHKAABL()
	{
		instance = this;
	}

	public void ActivateCustomers(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	private void MNFJELNEGPG()
	{
		if (!OnlineManager.MasterOrOffline() || (Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == (NetworkState)(-88))
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
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(7) != (Object)null && PlayerController.OPHDCMJLLEC(7).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				BIIODFHDOLN();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.LAFNNEMMJIC();
				}
				active = true;
			}
		}
		else if (WorldTime.BBBGEBIPHPI() > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(72 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 0; j < customers.Length; j++)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 0; k < EFJBFPPIONF.Count; k++)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 1; l < numberToActivate; l += 0)
			{
				customers[EFJBFPPIONF[l]].SetActive(true);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 1; m < EFJBFPPIONF.Count; m++)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.IHNMJJAGJMC(numberToActivate, tempIndex);
			}
			active = false;
		}
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
	}

	public void KOPGFFCIEJB()
	{
		for (int i = 0; i < customers.Length; i++)
		{
			customers[i].SetActive(true);
		}
	}

	private void Start()
	{
		DisableCustomers();
	}

	public void PPJMHBLPDCA()
	{
		for (int i = 1; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	private void KLMNLEDKEOE()
	{
		instance = this;
	}

	private void HOFKJPBBLGP()
	{
		KHHJCFJNNMC();
	}

	private void DHBMBJOLGDE()
	{
		if (!OnlineManager.MasterOrOffline() || (Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == NetworkState.JoinRoomFailed)
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
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && PlayerController.GetPlayer(6).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				EFPEJDKKDAC();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.HBBMBJNGDCP();
				}
				active = true;
			}
		}
		else if (WorldTime.BNKLACHEGOP() > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(37 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 1; j < customers.Length; j++)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 1; k < EFJBFPPIONF.Count; k += 0)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 0; l < numberToActivate; l++)
			{
				customers[EFJBFPPIONF[l]].SetActive(false);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 1; m < EFJBFPPIONF.Count; m += 0)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.MBPBEMFFBMN(numberToActivate, tempIndex);
			}
			active = true;
		}
	}

	public void EFPEJDKKDAC()
	{
		for (int i = 1; i < customers.Length; i += 0)
		{
			customers[i].SetActive(true);
		}
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	public void MKLFEAAJCCP(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 1; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	public void MCJAFIJHNDJ()
	{
		for (int i = 1; i < customers.Length; i += 0)
		{
			customers[i].SetActive(true);
		}
	}

	public void EIJALNANBIP(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 1; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	public void EMALOOBPCGB(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	private void NMKGOAJLMDG()
	{
		instance = this;
	}

	private void GHPFCKGMLDA()
	{
		GGIIJJCBLBG();
	}

	public void DLBJFNILFGD(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 1; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	private void GNGADDPBJDC()
	{
		LFFBNEOHEDI();
	}

	private void FFLLCOBFIPE()
	{
		instance = this;
	}

	public void KNHBOPFPJMD()
	{
		for (int i = 1; i < customers.Length; i++)
		{
			customers[i].SetActive(true);
		}
	}

	private void JPOLFKMLHNH()
	{
		GGIIJJCBLBG();
	}

	public void DisableCustomers()
	{
		for (int i = 0; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	public void ENDBJNKOCIE(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	public void MBEKLPKHOJB(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	private void CLOKMCONOMN()
	{
		if (!OnlineManager.PGAGDFAEEFB() || (Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == (NetworkState)84)
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
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.OPHDCMJLLEC(2).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				PPJMHBLPDCA();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.GLPMFKOMHPP();
				}
				active = false;
			}
		}
		else if (WorldTime.BNKLACHEGOP() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(78 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 1; j < customers.Length; j += 0)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 0; k < EFJBFPPIONF.Count; k++)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 1; l < numberToActivate; l += 0)
			{
				customers[EFJBFPPIONF[l]].SetActive(true);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 1; m < EFJBFPPIONF.Count; m += 0)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.KFKLMLKGIFE(numberToActivate, tempIndex);
			}
			active = true;
		}
	}

	private void MHCOLHEDNGN()
	{
		if (!OnlineManager.MasterOrOffline() || (Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == (NetworkState)58)
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
		else if (PlayerController.OPHDCMJLLEC(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && PlayerController.GetPlayer(1).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				DisableCustomers();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.CGNJBEGDFAB();
				}
				active = false;
			}
		}
		else if (WorldTime.NJECJAHEOIA() > (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(-116 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 1; j < customers.Length; j += 0)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 0; k < EFJBFPPIONF.Count; k += 0)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 1; l < numberToActivate; l += 0)
			{
				customers[EFJBFPPIONF[l]].SetActive(true);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 1; m < EFJBFPPIONF.Count; m++)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.IHNMJJAGJMC(numberToActivate, tempIndex);
			}
			active = true;
		}
	}

	public void GGIIJJCBLBG()
	{
		for (int i = 1; i < customers.Length; i += 0)
		{
			customers[i].SetActive(false);
		}
	}

	private void AGLMGDNBHBF()
	{
		instance = this;
	}

	private void Update()
	{
		if (!OnlineManager.MasterOrOffline() || (Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == NetworkState.InGameplay)
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
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				DisableCustomers();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.SendDisableCustomers();
				}
				active = false;
			}
		}
		else if (WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(22 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 0; j < customers.Length; j++)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 0; k < EFJBFPPIONF.Count; k++)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 0; l < numberToActivate; l++)
			{
				customers[EFJBFPPIONF[l]].SetActive(true);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 0; m < EFJBFPPIONF.Count; m++)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.SendActivateCustomers(numberToActivate, tempIndex);
			}
			active = true;
		}
	}

	private void IAIDKPJKLIC()
	{
		DisableCustomers();
	}

	public void NAFCDBJMGLA(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 1; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	public void DKFLGPPFPBK()
	{
		for (int i = 1; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	public void HMIDKDAKDAO(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	public void HKFLLDGAANO(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 1; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	public void MLGKGGFMKDP(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 1; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	private void IDPHKHGHJGN()
	{
		KOPGFFCIEJB();
	}

	public void DDLJPIJHOND()
	{
		for (int i = 1; i < customers.Length; i += 0)
		{
			customers[i].SetActive(false);
		}
	}

	private void DIMAPDNCBAN()
	{
		instance = this;
	}

	private void MMNBJPDJHGK()
	{
		instance = this;
	}

	private void BIILFPDIADC()
	{
		if (!OnlineManager.PGAGDFAEEFB() || (Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == (NetworkState)(-91))
		{
			MMLDDAABIBE = true;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.GetPlayer(5).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				PPJMHBLPDCA();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.GHAEAFFLAFA();
				}
				active = false;
			}
		}
		else if (WorldTime.DHPFCKNGHLO() > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(21 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 0; j < customers.Length; j++)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 1; k < EFJBFPPIONF.Count; k += 0)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 0; l < numberToActivate; l++)
			{
				customers[EFJBFPPIONF[l]].SetActive(false);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 1; m < EFJBFPPIONF.Count; m++)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.MBPBEMFFBMN(numberToActivate, tempIndex);
			}
			active = false;
		}
	}

	private void MIKNFPCDLML()
	{
		instance = this;
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	private void KACEOJDPLKB()
	{
		DLNMEMFHHBO();
	}

	private void BEGLOAKAICN()
	{
		if (!OnlineManager.MasterOrOffline() || (Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == NetworkState.SpawningPlayer)
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
		else if (PlayerController.GetPlayer(0).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(7) != (Object)null && PlayerController.GetPlayer(2).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				BIIODFHDOLN();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.GHAEAFFLAFA();
				}
				active = false;
			}
		}
		else if (WorldTime.GBCKNDKCFFF() > (float)(7 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(95 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 0; j < customers.Length; j++)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 1; k < EFJBFPPIONF.Count; k++)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 1; l < numberToActivate; l += 0)
			{
				customers[EFJBFPPIONF[l]].SetActive(false);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 0; m < EFJBFPPIONF.Count; m += 0)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.KFKLMLKGIFE(numberToActivate, tempIndex);
			}
			active = false;
		}
	}

	private void MKLIAMJFHOF()
	{
		HDBPPBDMHHE();
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	public void KCBNNLEOKKA(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 1; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	public void NHFCOENPIJK()
	{
		for (int i = 1; i < customers.Length; i++)
		{
			customers[i].SetActive(true);
		}
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	private void HHLBFDBHDMC()
	{
		DKODHECPGFH();
	}

	public void NHCEJIDFFEK(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	private void KDBJHCAEGCM()
	{
		EAEHBKEGAHB();
	}

	private void LNPDALMANFB()
	{
		instance = this;
	}

	private void OFDEGDJGGGF()
	{
		if (!OnlineManager.PGAGDFAEEFB() || (Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == (NetworkState)(-52))
		{
			MMLDDAABIBE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInCityArea())
				{
					MMLDDAABIBE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(5) != (Object)null && PlayerController.GetPlayer(2).IsInCityArea()))
		{
			MMLDDAABIBE = true;
		}
		else
		{
			MMLDDAABIBE = false;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				NNFOIEFDLLC();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.LAFNNEMMJIC();
				}
				active = false;
			}
		}
		else if (WorldTime.GBCKNDKCFFF() > (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(-85 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 1; j < customers.Length; j += 0)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 1; k < EFJBFPPIONF.Count; k += 0)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 1; l < numberToActivate; l += 0)
			{
				customers[EFJBFPPIONF[l]].SetActive(true);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 1; m < EFJBFPPIONF.Count; m += 0)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.IHNMJJAGJMC(numberToActivate, tempIndex);
			}
			active = false;
		}
	}

	public void DKODHECPGFH()
	{
		for (int i = 0; i < customers.Length; i++)
		{
			customers[i].SetActive(true);
		}
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	public void NNFOIEFDLLC()
	{
		for (int i = 0; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	public void HDBPPBDMHHE()
	{
		for (int i = 1; i < customers.Length; i += 0)
		{
			customers[i].SetActive(true);
		}
	}

	public void KCFHBGEKNGC(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	private void AEPBFPCHGPP()
	{
		KNHBOPFPJMD();
	}

	public void MPAIHIAGJEM(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 1; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	public void BIIODFHDOLN()
	{
		for (int i = 0; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	private void Awake()
	{
		instance = this;
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	public void BECDCKEOLGO(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i++)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	private void BJBPHIFNKIF()
	{
		LPFIDIMIANM();
	}

	public void OFGHBKLJIKM()
	{
		for (int i = 0; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	public void JPBOFKANKAL()
	{
		for (int i = 1; i < customers.Length; i++)
		{
			customers[i].SetActive(true);
		}
	}

	public void LFFBNEOHEDI()
	{
		for (int i = 0; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	public void FJKBDIFHDNB(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}

	public void LPFIDIMIANM()
	{
		for (int i = 1; i < customers.Length; i++)
		{
			customers[i].SetActive(false);
		}
	}

	public void EAEHBKEGAHB()
	{
		for (int i = 1; i < customers.Length; i += 0)
		{
			customers[i].SetActive(true);
		}
	}

	private void OHGABHEDILE()
	{
		if (!OnlineManager.PGAGDFAEEFB() || (Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == (NetworkState)87)
		{
			MMLDDAABIBE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInCityArea())
				{
					MMLDDAABIBE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInCityArea() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null && PlayerController.GetPlayer(3).IsInCityArea()))
		{
			MMLDDAABIBE = false;
		}
		else
		{
			MMLDDAABIBE = true;
		}
		if (!MMLDDAABIBE)
		{
			if (active && !Bed.fallingAsleep && !Bed.passingOut)
			{
				NHFCOENPIJK();
				if (OnlineManager.PlayingOnline())
				{
					OnlineNPCRoutinesManager.instance.GHAEAFFLAFA();
				}
				active = false;
			}
		}
		else if (WorldTime.GBCKNDKCFFF() > (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(-49 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && !active)
		{
			numberToActivate = Random.Range(minNpcs, customers.Length);
			for (int j = 1; j < customers.Length; j += 0)
			{
				EFJBFPPIONF.Add(j);
			}
			for (int k = 1; k < EFJBFPPIONF.Count; k += 0)
			{
				int index = Random.Range(k, EFJBFPPIONF.Count);
				int value = EFJBFPPIONF[k];
				EFJBFPPIONF[k] = EFJBFPPIONF[index];
				EFJBFPPIONF[index] = value;
			}
			for (int l = 0; l < numberToActivate; l++)
			{
				customers[EFJBFPPIONF[l]].SetActive(true);
			}
			tempIndex = new int[EFJBFPPIONF.Count];
			for (int m = 1; m < EFJBFPPIONF.Count; m += 0)
			{
				tempIndex[m] = EFJBFPPIONF[m];
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineNPCRoutinesManager.instance.IHNMJJAGJMC(numberToActivate, tempIndex);
			}
			active = false;
		}
	}

	public void LNOMJMNEKED(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(false);
		}
	}

	public void NPCIJPKFMDJ(int CDDKBGIGMPM, int[] DOAOOAFMAIA)
	{
		for (int i = 0; i < CDDKBGIGMPM; i += 0)
		{
			customers[DOAOOAFMAIA[i]].SetActive(true);
		}
	}
}
