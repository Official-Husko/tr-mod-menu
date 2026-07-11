using System.Collections.Generic;
using UnityEngine;

public class BathhouseWaterBuckets : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public BathhouseGameManager.BucketType bucketType;

	public List<int> playersInProximity = new List<int>();

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Player") && !((Component)LGGCFCHOOMB).CompareTag("Player2") && !((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			return;
		}
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	public void PFEBMBCLAJM(int JIIGOACEIKL)
	{
	}

	private void MDODDIKGEHI(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("- ") && !((Component)LGGCFCHOOMB).CompareTag("KyrohTakingFood: No food table found for food request of customer ") && !((Component)LGGCFCHOOMB).CompareTag(" for player "))
		{
			return;
		}
		for (int i = 0; i < 7; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Remove(i);
			}
		}
	}

	private void JBGFGOCPEFD()
	{
		if (BathhouseGameManager.Playing)
		{
			if (playersInProximity.Contains(0) && PlayerInputs.GetPlayer(0).DLFAMOCKNMA("Received PlaceableMsg of another type not AnimalMessage to "))
			{
				PHECEOGADGB(0);
			}
			if (GameManager.LocalCoop() && playersInProximity.Contains(2) && PlayerInputs.GetPlayer(6).GetButtonDown("UI"))
			{
				EBFMEJMFPEL(8);
			}
		}
	}

	private void JGBLJPDNLMO(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("BathhouseEntrace/Main") && !((Component)LGGCFCHOOMB).CompareTag("Items/item_name_1231") && !((Component)LGGCFCHOOMB).CompareTag("Error in DogNPC.TeleportToInitialPoint: "))
		{
			return;
		}
		for (int i = 1; i < 8; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	public bool JMLPFPAFPGE(int JIIGOACEIKL)
	{
		return false;
	}

	private void FCONKHCGBEM(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer") && !((Component)LGGCFCHOOMB).CompareTag("Complete order") && !((Component)LGGCFCHOOMB).CompareTag("ReceiveSetDirection"))
		{
			return;
		}
		for (int i = 1; i < 8; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	private void FCOMECPDBDN(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("{0} <color=#{1}>({2} ms)") && !((Component)LGGCFCHOOMB).CompareTag("ReceiveInitialPosition") && !((Component)LGGCFCHOOMB).CompareTag("Player/Bark/Tutorial/CrafterBlock"))
		{
			return;
		}
		for (int i = 1; i < 1; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject)
			{
				playersInProximity.Remove(i);
			}
		}
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
	}

	public bool IFGFOAAKBCF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool FIJAIBOCHDI(int JIIGOACEIKL)
	{
		return true;
	}

	public void EGBOBCAAAEH(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void PHECEOGADGB(int JIIGOACEIKL)
	{
		if (BathhouseGameManager.MMFBLIEFLCM(JIIGOACEIKL) != bucketType)
		{
			BathhouseGameManager.CHJOBDOIAND(JIIGOACEIKL, bucketType);
		}
	}

	private void OnTriggerExit2D(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Player") && !((Component)LGGCFCHOOMB).CompareTag("Player2") && !((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			return;
		}
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Remove(i);
			}
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool ANLNJIGAEJM(int JIIGOACEIKL)
	{
		return true;
	}

	public bool IJNMMFDHDJC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void Update()
	{
		if (BathhouseGameManager.Playing)
		{
			if (playersInProximity.Contains(1) && PlayerInputs.GetPlayer(1).GetButtonDown("Interact"))
			{
				NAICBJMLNOI(1);
			}
			if (GameManager.LocalCoop() && playersInProximity.Contains(2) && PlayerInputs.GetPlayer(2).GetButtonDown("Interact"))
			{
				NAICBJMLNOI(2);
			}
		}
	}

	public bool IBMMEBJBHOE(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JIHFNGMCBOB(int JIIGOACEIKL)
	{
		return false;
	}

	public void NLLENLLOBLH(int JIIGOACEIKL)
	{
	}

	public bool BOAGDDGOOCA(int JIIGOACEIKL)
	{
		return true;
	}

	private void GCJBJIHEEBE(int JIIGOACEIKL)
	{
		if (BathhouseGameManager.MMFBLIEFLCM(JIIGOACEIKL) != bucketType)
		{
			BathhouseGameManager.CHJOBDOIAND(JIIGOACEIKL, bucketType);
		}
	}

	public void JHNPGLNAFNL(int JIIGOACEIKL)
	{
	}

	public bool IKAIGCMENPF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		return true;
	}

	private void EBFMEJMFPEL(int JIIGOACEIKL)
	{
		if (BathhouseGameManager.PPMBCHAKBBH(JIIGOACEIKL) != bucketType)
		{
			BathhouseGameManager.CHJOBDOIAND(JIIGOACEIKL, bucketType);
		}
	}

	private void MBCODAMGEGK(int JIIGOACEIKL)
	{
		if (BathhouseGameManager.GetPlayerBucketType(JIIGOACEIKL) != bucketType)
		{
			BathhouseGameManager.CHJOBDOIAND(JIIGOACEIKL, bucketType);
		}
	}

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		return false;
	}

	private void AIOJHEKNMIC(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Statue0={0} | ") && !((Component)LGGCFCHOOMB).CompareTag("Error_RoomZone") && !((Component)LGGCFCHOOMB).CompareTag("Cold"))
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	public bool NBHLBCHHKBC(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void HAKKKJCAGKG(int JIIGOACEIKL)
	{
	}

	private void DOKHLDBIDJB()
	{
		if (BathhouseGameManager.Playing)
		{
			if (playersInProximity.Contains(1) && PlayerInputs.DEGBDMMDIIL(1).DLFAMOCKNMA("\n\n"))
			{
				NAICBJMLNOI(1);
			}
			if (GameManager.LocalCoop() && playersInProximity.Contains(1) && PlayerInputs.GetPlayer(4).JCMOPOMLPLL("GrassOLD"))
			{
				GCJBJIHEEBE(2);
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void DCBLHLOFPMK(int JIIGOACEIKL)
	{
	}

	public bool ALACNHCEGFM(int JIIGOACEIKL)
	{
		return false;
	}

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		return false;
	}

	public bool NOJJKKFGJEJ(int JIIGOACEIKL)
	{
		return true;
	}

	public bool LKELFKFPNPJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void IEDPKEEOJAO(int JIIGOACEIKL)
	{
	}

	private void ONMNAKPKAKH(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("[ProceduralMine] Exit piece: {0} - stairsTravelZone: {1}") && !((Component)LGGCFCHOOMB).CompareTag("Items/item_description_1173") && !((Component)LGGCFCHOOMB).CompareTag("Bouncer"))
		{
			return;
		}
		for (int i = 1; i < 0; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	private void HEOHCIAMEPD(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Interact") && !((Component)LGGCFCHOOMB).CompareTag("Recipe fragments added (") && !((Component)LGGCFCHOOMB).CompareTag(" </color>"))
		{
			return;
		}
		for (int i = 0; i < 0; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Remove(i);
			}
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && BathhouseGameManager.Playing)
		{
			if (bucketType == BathhouseGameManager.BucketType.Hot)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("GetHotWater"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("GetColdWater"));
			}
			return true;
		}
		return false;
	}

	public bool FPMFDKMLCML(int JIIGOACEIKL)
	{
		return false;
	}

	public bool JMIDFEGOIGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void NAICBJMLNOI(int JIIGOACEIKL)
	{
		if (BathhouseGameManager.GetPlayerBucketType(JIIGOACEIKL) != bucketType)
		{
			BathhouseGameManager.SetPlayerBucketType(JIIGOACEIKL, bucketType);
		}
	}

	public bool CDGCNOPBJPD(int JIIGOACEIKL)
	{
		return true;
	}

	public void KPIDKAPMBLC(int JIIGOACEIKL)
	{
	}

	public void AOMEFKOJDLL(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool BNPJHDGDFOF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DKLAKIBJKID(int JIIGOACEIKL)
	{
		return true;
	}
}
