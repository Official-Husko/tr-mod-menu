using UnityEngine;

public class PlayerMaskDoorDetector : MonoBehaviour
{
	public GameObject[] masks;

	private bool BALGIGOPBAK;

	private bool JIBPIDKHGCB;

	private bool GOMGNFLDING;

	private bool KKKBJAEACLK;

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveTrigger"))
		{
			if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
			{
				PlayerController.GetPlayer(1).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			}
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1094"))
		{
			if (PlayerController.GetPlayer(6).IsTavernLocation())
			{
				PlayerController.OPHDCMJLLEC(2).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(7).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: true);
			}
			JIBPIDKHGCB = true;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Eat"))
		{
			if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
			{
				PlayerController.OPHDCMJLLEC(0).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.GetPlayer(0).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: true);
			}
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LE_21"))
		{
			if (PlayerController.OPHDCMJLLEC(7).IsTavernLocation())
			{
				PlayerController.GetPlayer(1).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: true);
			}
			else
			{
				PlayerController.GetPlayer(0).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: false);
			}
			JIBPIDKHGCB = false;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void HHGJLOKEPJE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_625"))
		{
			PlayerController.OPHDCMJLLEC(0).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: false);
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Custom lobby data (Lobby creator): {0}"))
		{
			PlayerController.GetPlayer(2).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: false);
			JIBPIDKHGCB = false;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 0; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1100"))
		{
			if (PlayerController.GetPlayer(0).IsTavernLocation())
			{
				PlayerController.OPHDCMJLLEC(0).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			}
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Harvest"))
		{
			if (PlayerController.OPHDCMJLLEC(2).IsTavernLocation())
			{
				PlayerController.GetPlayer(4).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(5).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false);
			}
			JIBPIDKHGCB = false;
		}
		for (int i = 0; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("{0} sec"))
		{
			PlayerController.OPHDCMJLLEC(1).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: false);
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Invalid ninja customer ID: "))
		{
			PlayerController.OPHDCMJLLEC(5).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			JIBPIDKHGCB = false;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void MDODDIKGEHI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tray"))
		{
			PlayerController.GetPlayer(1).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: true);
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("mForMins"))
		{
			PlayerController.GetPlayer(8).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			JIBPIDKHGCB = true;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 1; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(true);
			}
		}
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UI2"))
		{
			PlayerController.OPHDCMJLLEC(1).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/9/Dialogue Text"))
		{
			PlayerController.GetPlayer(7).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: false);
			JIBPIDKHGCB = true;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 1; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(true);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			PlayerController.GetPlayer(1).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false);
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			PlayerController.GetPlayer(2).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false);
			JIBPIDKHGCB = false;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(true);
			}
		}
	}

	private void KKEPLLEAAMB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Information"))
		{
			PlayerController.GetPlayer(1).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: true);
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Guards finished walking."))
		{
			PlayerController.GetPlayer(8).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			JIBPIDKHGCB = true;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 1; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
			{
				PlayerController.GetPlayer(0).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.GetPlayer(0).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: false);
			}
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Collect"))
		{
			if (PlayerController.OPHDCMJLLEC(8).IsTavernLocation())
			{
				PlayerController.OPHDCMJLLEC(1).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.GetPlayer(2).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: true);
			}
			JIBPIDKHGCB = true;
		}
		for (int i = 0; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			if (PlayerController.GetPlayer(1).IsTavernLocation())
			{
				PlayerController.GetPlayer(1).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true);
			}
			else
			{
				PlayerController.GetPlayer(1).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			if (PlayerController.GetPlayer(2).IsTavernLocation())
			{
				PlayerController.GetPlayer(2).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true);
			}
			else
			{
				PlayerController.GetPlayer(2).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			JIBPIDKHGCB = true;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(true);
			}
		}
	}

	private void EDCINHFBGAN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T133/Dialogue1"))
		{
			PlayerController.OPHDCMJLLEC(0).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernDirty/Entry/1/Dialogue Text"))
		{
			PlayerController.OPHDCMJLLEC(3).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			JIBPIDKHGCB = false;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 0; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void ENKFHHEMHGG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("IsRaining"))
		{
			PlayerController.GetPlayer(0).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true);
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Year"))
		{
			PlayerController.GetPlayer(0).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			JIBPIDKHGCB = false;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(true);
			}
		}
	}

	private void INBCLBHEBKE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Pool Object from "))
		{
			PlayerController.OPHDCMJLLEC(1).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: false);
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("OpenStats"))
		{
			PlayerController.GetPlayer(7).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			JIBPIDKHGCB = false;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 1; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_3"))
		{
			if (PlayerController.GetPlayer(0).IsTavernLocation())
			{
				PlayerController.GetPlayer(1).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(0).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false);
			}
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UnNuevoMaestro/HikariTalk"))
		{
			if (PlayerController.GetPlayer(1).IsTavernLocation())
			{
				PlayerController.GetPlayer(8).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(8).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: true);
			}
			JIBPIDKHGCB = false;
		}
		for (int i = 1; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			if (PlayerController.GetPlayer(1).IsTavernLocation())
			{
				PlayerController.GetPlayer(1).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false);
			}
			else
			{
				PlayerController.GetPlayer(1).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			}
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" appearance data: "))
		{
			if (PlayerController.OPHDCMJLLEC(7).IsTavernLocation())
			{
				PlayerController.GetPlayer(1).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(3).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: true);
			}
			JIBPIDKHGCB = true;
		}
		for (int i = 0; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void APJFDMCLDBD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("showui"))
		{
			PlayerController.OPHDCMJLLEC(1).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1057"))
		{
			PlayerController.GetPlayer(1).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			JIBPIDKHGCB = true;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 0; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void ILNDDFELMKL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemIronIngot"))
		{
			PlayerController.OPHDCMJLLEC(1).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("City/Amos/Bark/Bye"))
		{
			PlayerController.GetPlayer(0).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false);
			JIBPIDKHGCB = false;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 1; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void EKJIEGLPBLA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BackPain"))
		{
			PlayerController.OPHDCMJLLEC(0).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceivePetBowlMessage"))
		{
			PlayerController.OPHDCMJLLEC(8).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false);
			JIBPIDKHGCB = true;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 1; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("HandUp"))
		{
			if (PlayerController.GetPlayer(0).IsTavernLocation())
			{
				PlayerController.OPHDCMJLLEC(0).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("MineState"))
		{
			if (PlayerController.OPHDCMJLLEC(8).IsTavernLocation())
			{
				PlayerController.GetPlayer(4).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.GetPlayer(8).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: false);
			}
			JIBPIDKHGCB = true;
		}
		for (int i = 1; i < masks.Length; i += 0)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(true);
			}
		}
	}

	private void KCDODEOOBHG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveEndIntroMasters"))
		{
			PlayerController.OPHDCMJLLEC(0).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			BALGIGOPBAK = false;
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			PlayerController.OPHDCMJLLEC(6).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true);
			JIBPIDKHGCB = false;
		}
		if (BALGIGOPBAK || JIBPIDKHGCB || KKKBJAEACLK || GOMGNFLDING)
		{
			return;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void PKHMNNJFLAA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Reverence"))
		{
			if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
			{
				PlayerController.OPHDCMJLLEC(0).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: false);
			}
			else
			{
				PlayerController.GetPlayer(0).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("{"))
		{
			if (PlayerController.OPHDCMJLLEC(7).IsTavernLocation())
			{
				PlayerController.GetPlayer(6).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.GetPlayer(6).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: false);
			}
			JIBPIDKHGCB = true;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(false);
			}
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			if (PlayerController.GetPlayer(0).IsTavernLocation())
			{
				PlayerController.GetPlayer(1).characterAnimation.ActivateTrayMask(HCOPJPMDEKP: false, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).characterAnimation.FNIIMHDNFHI(HCOPJPMDEKP: true);
			}
			BALGIGOPBAK = true;
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Building"))
		{
			if (PlayerController.GetPlayer(2).IsTavernLocation())
			{
				PlayerController.GetPlayer(0).characterAnimation.FDNLDBBGCAB(HCOPJPMDEKP: true, GFDKIKCEGPG: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(3).characterAnimation.GHKKLLEIIJN(HCOPJPMDEKP: false);
			}
			JIBPIDKHGCB = false;
		}
		for (int i = 0; i < masks.Length; i++)
		{
			if (!masks[i].activeSelf)
			{
				masks[i].SetActive(true);
			}
		}
	}
}
