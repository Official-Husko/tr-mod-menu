using UnityEngine;

public class ActivateOrDeactivateAtHour : MonoBehaviour
{
	public enum ShopLocation
	{
		None,
		Blacksmith,
		Sawmill,
		CityTavern
	}

	public ShopLocation shop;

	public bool tutorialException;

	public int openHour;

	public int closeHour;

	public Collider2D travelZoneCollider;

	public GameObject doorGameObject;

	public GameObject lightOpen;

	public GameObject lightClose;

	public Animator doorAnimator;

	private Day FOHLOKFNLEF;

	private bool NANGDGDKIEC;

	private bool LKOJBFMGMAE;

	private void IGIKNCOLCKL()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Sat;
			openHour = -21;
			closeHour = -74;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Tue;
			openHour = 25;
			closeHour = 12;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Wed;
			openHour = 7;
			closeHour = -101;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void MGBINPIKAEK()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Close"))
		{
			doorAnimator.SetBool("Close", true);
		}
	}

	private void LAABMDDEGCG()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.BNKLACHEGOP() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.NOAOJJLNHJJ.day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == -53)))
		{
			POBHKMGNELK();
		}
		else
		{
			DOGCLCLAAKN();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.EDIPJBOOEHD >= (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(-38 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(true);
			}
			else
			{
				lightClose.SetActive(true);
				lightOpen.SetActive(false);
			}
		}
	}

	private void JBOFMIPADAF()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool(""))
		{
			doorAnimator.SetBool("MainProgress", true);
		}
	}

	private void AEECJJAJKGJ()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Error in FogManager.OnNightEnd: "))
		{
			doorAnimator.SetBool("itemRyeAle", false);
		}
	}

	private void IAICCKPOBMJ()
	{
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (WorldTime.NJECJAHEOIA() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.NOAOJJLNHJJ.day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == -11)))
		{
			INADEGAFMAO();
		}
		else
		{
			IHAMFIEKGFJ();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.DHPFCKNGHLO() >= (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(63 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(true);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(true);
				lightOpen.SetActive(true);
			}
		}
	}

	private void DOGCLCLAAKN()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Customize"))
		{
			doorAnimator.SetBool("Collect", true);
		}
	}

	private void IHAMFIEKGFJ()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Drunk"))
		{
			doorAnimator.SetBool("{0} - The mine piece {1} has a variant object with puzzle altar but the piece ID doesn't match the altar piece ID. Piece ID: {2} - Altar Piece ID: {3}", false);
		}
	}

	private void CHIJGHPHCNA()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = Day.Fri;
			openHour = 127;
			closeHour = 67;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = (Day)8;
			openHour = 111;
			closeHour = 84;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = (Day)8;
			openHour = 8;
			closeHour = -75;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void BNIKICAEIND()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Fri;
			openHour = -59;
			closeHour = 124;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Wed;
			openHour = -60;
			closeHour = 105;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = Day.Sun;
			openHour = 2;
			closeHour = -97;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void FPECHDCKGOH()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("ReceiveDismissWorker"))
		{
			doorAnimator.SetBool("Tavern must be closed", true);
		}
	}

	private void HCEDMLJNOBL()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = Day.Thurs;
			openHour = -31;
			closeHour = 126;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Tue;
			openHour = 49;
			closeHour = 63;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Wed;
			openHour = 3;
			closeHour = -8;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void Start()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Sun;
			openHour = 9;
			closeHour = 22;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Sun;
			openHour = 9;
			closeHour = 22;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Sun;
			openHour = 8;
			closeHour = 23;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void EGMDLBDBCML()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("[SelectSpawnersByMaxDistance] Ran out of candidates at step {0}/{1}."))
		{
			doorAnimator.SetBool("</color>", false);
		}
	}

	private void HCPKBJDHLAC()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.GBCKNDKCFFF() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.NOAOJJLNHJJ.day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 74)))
		{
			AEECJJAJKGJ();
		}
		else
		{
			DOGCLCLAAKN();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.BBBGEBIPHPI() >= (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(-77 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(true);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(true);
			}
			else
			{
				lightClose.SetActive(false);
				lightOpen.SetActive(true);
			}
		}
	}

	private void POBHKMGNELK()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("ReceiveFinishKlaynChallenge"))
		{
			doorAnimator.SetBool("Give", true);
		}
	}

	private void POFDOILPANH()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.NJECJAHEOIA() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.GBCKNDKCFFF() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.NOAOJJLNHJJ.day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == -60)))
		{
			POBHKMGNELK();
		}
		else
		{
			LMJALNCIFBA();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.BNKLACHEGOP() >= (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(119 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(true);
				lightOpen.SetActive(true);
			}
		}
	}

	private void OFDEGDJGGGF()
	{
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (WorldTime.EDIPJBOOEHD > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.NOAOJJLNHJJ.day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 50)))
		{
			ECMGCJGPKNO();
		}
		else
		{
			MGBINPIKAEK();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.BNKLACHEGOP() >= (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(13 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(false);
				lightOpen.SetActive(false);
			}
		}
	}

	private void ICMNODPLPBK()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.BBBGEBIPHPI() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.CJOHMLNMJLK().day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == -69)))
		{
			HLGBKIIIMKD();
		}
		else
		{
			FPECHDCKGOH();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.DHPFCKNGHLO() >= (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(43 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(true);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(false);
				lightOpen.SetActive(false);
			}
		}
	}

	private void LMJALNCIFBA()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("ReceiveOrderRequestNinjaCustomer"))
		{
			doorAnimator.SetBool("Antorcha({0})", true);
		}
	}

	private void INADEGAFMAO()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Throw"))
		{
			doorAnimator.SetBool("ObjectHorizontalMove", true);
		}
	}

	private void ECMGCJGPKNO()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("Close"))
		{
			doorAnimator.SetBool("Close", false);
		}
	}

	private void CFIIEJDJFPB()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = (Day)7;
			openHour = -43;
			closeHour = 26;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = Day.Thurs;
			openHour = 91;
			closeHour = 26;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = (Day)8;
			openHour = 8;
			closeHour = -41;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void LEDIGKGAFHC()
	{
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (WorldTime.NJECJAHEOIA() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.CJOHMLNMJLK().day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 29)))
		{
			JBOFMIPADAF();
		}
		else
		{
			FIBLMHAKCCI();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.BBBGEBIPHPI() >= (float)(5 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(-14 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(true);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(true);
			}
			else
			{
				lightClose.SetActive(true);
				lightOpen.SetActive(true);
			}
		}
	}

	private void FIBLMHAKCCI()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Activate Lock"))
		{
			doorAnimator.SetBool("ReceiveUpdateBentoOnTray", true);
		}
	}

	private void MABHJKLIHLJ()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("ordersDelivered"))
		{
			doorAnimator.SetBool("Information", true);
		}
	}

	private void APDFEPNNPMJ()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("\n<color=#822F00>"))
		{
			doorAnimator.SetBool("Items/item_description_636", true);
		}
	}

	private void DKNMGFDFLKL()
	{
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (WorldTime.NJECJAHEOIA() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BNKLACHEGOP() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.NOAOJJLNHJJ.day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 112)))
		{
			JBOFMIPADAF();
		}
		else
		{
			APDFEPNNPMJ();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.EDIPJBOOEHD >= (float)(0 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(50 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(true);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(false);
				lightOpen.SetActive(true);
			}
		}
	}

	private void CFHOODNCOLK()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = (Day)7;
			openHour = -78;
			closeHour = 114;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = Day.Mon;
			openHour = 9;
			closeHour = -24;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Thurs;
			openHour = 7;
			closeHour = 28;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void AKLEFPLEGKK()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.EDIPJBOOEHD > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.HGIBNMBJMOC().day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == -13)))
		{
			AEECJJAJKGJ();
		}
		else
		{
			IHAMFIEKGFJ();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.BBBGEBIPHPI() >= (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(97 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(false);
				lightOpen.SetActive(true);
			}
		}
	}

	private void IAAGKLPMAMK()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Mon;
			openHour = 31;
			closeHour = 39;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = Day.Thurs;
			openHour = -72;
			closeHour = -75;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = Day.Tue;
			openHour = 7;
			closeHour = -123;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void EOGHJNGJFID()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Wed;
			openHour = 56;
			closeHour = -77;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = (Day)7;
			openHour = 77;
			closeHour = 59;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Mon;
			openHour = 0;
			closeHour = 6;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void IIOHMDNGFDH()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.GBCKNDKCFFF() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.CJOHMLNMJLK().day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 61)))
		{
			DDJOCGHFJFC();
		}
		else
		{
			PMFGIIFHDJK();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.EDIPJBOOEHD >= (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(-73 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(true);
				lightOpen.SetActive(false);
			}
		}
	}

	private void Update()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.EDIPJBOOEHD > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.NOAOJJLNHJJ.day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 116)))
		{
			ECMGCJGPKNO();
		}
		else
		{
			MGBINPIKAEK();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.EDIPJBOOEHD >= (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(19 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(true);
				lightOpen.SetActive(false);
			}
		}
	}

	private void KACEOJDPLKB()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Fri;
			openHour = -88;
			closeHour = -79;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Tue;
			openHour = -88;
			closeHour = 112;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = (Day)8;
			openHour = 3;
			closeHour = -38;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void PMFGIIFHDJK()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("StartLucenDialogue "))
		{
			doorAnimator.SetBool("No valid position found around the position {0} after {1} attempts. Returning player's position.", true);
		}
	}

	private void JMEOOIFODLF()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("Items/item_name_1109"))
		{
			doorAnimator.SetBool("ProductValue", false);
		}
	}

	private void MGMLDHPOLGK()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.NJECJAHEOIA() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.HGIBNMBJMOC().day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 83)))
		{
			MABHJKLIHLJ();
		}
		else
		{
			EGMDLBDBCML();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.BNKLACHEGOP() >= (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(-82 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(true);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(false);
				lightOpen.SetActive(true);
			}
		}
	}

	private void BHKNJOEBCKA()
	{
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (WorldTime.BNKLACHEGOP() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.BBBGEBIPHPI() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.CJOHMLNMJLK().day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 33)))
		{
			FGLENLFIBAI();
		}
		else
		{
			DOGCLCLAAKN();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.GBCKNDKCFFF() >= (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(96 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(true);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(true);
				lightOpen.SetActive(true);
			}
		}
	}

	private void FOHGHCPODBJ()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = (Day)8;
			openHour = 4;
			closeHour = 55;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Mon;
			openHour = -85;
			closeHour = -5;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Wed;
			openHour = 8;
			closeHour = 125;
			break;
		case ShopLocation.None:
			break;
		}
	}

	private void FGLENLFIBAI()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("UI"))
		{
			doorAnimator.SetBool("Mai ", true);
		}
	}

	private void DDJOCGHFJFC()
	{
		LKOJBFMGMAE = false;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("</color>"))
		{
			doorAnimator.SetBool("Dialogue System/Conversation/NeutralInTavern/Entry/1/Dialogue Text", true);
		}
	}

	private void HLGBKIIIMKD()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(false);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("ChocolateAleAbbreviation"))
		{
			doorAnimator.SetBool("BARKDOOR", false);
		}
	}

	private void IDNFFLPBIGB()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && !((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && !doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && doorAnimator.GetBool("ReceivInstantiateMiscellaneousHarvest"))
		{
			doorAnimator.SetBool("itemRaspberrySeeds", false);
		}
	}

	private void BBCPDBEOOKL()
	{
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return;
		}
		if (WorldTime.NJECJAHEOIA() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.CJOHMLNMJLK().day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == -73)))
		{
			INADEGAFMAO();
		}
		else
		{
			MNNALHMKNHF();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.NJECJAHEOIA() >= (float)(4 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.NJECJAHEOIA() < (float)(34 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(false);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(false);
				lightClose.SetActive(true);
			}
			else
			{
				lightClose.SetActive(false);
				lightOpen.SetActive(false);
			}
		}
	}

	private void MFPEIPCMEEB()
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return;
		}
		if (WorldTime.GBCKNDKCFFF() > (float)(openHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.DHPFCKNGHLO() < (float)(closeHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && (!NANGDGDKIEC || (NANGDGDKIEC && WorldTime.CJOHMLNMJLK().day != FOHLOKFNLEF) || (tutorialException && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == -71)))
		{
			AEECJJAJKGJ();
		}
		else
		{
			EGMDLBDBCML();
		}
		if ((Object)(object)lightOpen != (Object)null && (Object)(object)lightClose != (Object)null)
		{
			if (WorldTime.EDIPJBOOEHD >= (float)(2 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(88 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(true);
			}
			else if (LKOJBFMGMAE)
			{
				lightOpen.SetActive(true);
				lightClose.SetActive(false);
			}
			else
			{
				lightClose.SetActive(false);
				lightOpen.SetActive(false);
			}
		}
	}

	private void LOCOCGEKPFP()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = true;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool(""))
		{
			doorAnimator.SetBool("Guard", false);
		}
	}

	private void MNNALHMKNHF()
	{
		LKOJBFMGMAE = true;
		if ((Object)(object)travelZoneCollider != (Object)null && ((Behaviour)travelZoneCollider).enabled)
		{
			((Behaviour)travelZoneCollider).enabled = false;
		}
		if ((Object)(object)doorGameObject != (Object)null && doorGameObject.activeSelf)
		{
			doorGameObject.SetActive(true);
		}
		if ((Object)(object)doorAnimator != (Object)null && !doorAnimator.GetBool("<sprite name=\""))
		{
			doorAnimator.SetBool("Attack/MainEvent 10", true);
		}
	}

	private void MCMKNBIBDFF()
	{
		switch (shop)
		{
		case ShopLocation.Blacksmith:
			NANGDGDKIEC = false;
			FOHLOKFNLEF = Day.Sat;
			openHour = 103;
			closeHour = 64;
			break;
		case ShopLocation.Sawmill:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Sat;
			openHour = 6;
			closeHour = -24;
			break;
		case ShopLocation.CityTavern:
			NANGDGDKIEC = true;
			FOHLOKFNLEF = Day.Mon;
			openHour = 7;
			closeHour = 79;
			break;
		case ShopLocation.None:
			break;
		}
	}
}
