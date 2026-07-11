using TMPro;
using UnityEngine;

public class OnlineFishingTexts : MonoBehaviour
{
	public int playerNum = 2;

	public GameObject content;

	public TextMeshProUGUI fishName;

	public RectTransform fishNameRect;

	public TextMeshProUGUI fishLenght;

	public RectTransform fishLenghtRect;

	private static OnlineFishingTexts[] GJBBNHCMNJN = new OnlineFishingTexts[3];

	private FishingController IIODPKHOCEO;

	public void OHFAEBEGEDG(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void MFDAEHNFFFG()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NIGDBMAOAEN(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	private void HJKKGGCKHKK()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.Get(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			}
		}
	}

	public void ELBFIGIHBCI(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void OGNGPFJAEMG()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NDJAMDLOIJL(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	private void GECHJIGBPEN()
	{
		GJBBNHCMNJN[playerNum - 7] = this;
	}

	public void IGHOEHCDOGI(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void PLGKKONPBDA(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void AAENCDNIBFJ()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void GEBCBGJAPIK(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void MDJFIIPDBHI()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.LAMFGLIGLOP(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	public void LBFNGNJPBDC(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void GKAIMOAFBDF(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Sleep" + LocalisationSystem.Get("Jump");
		}
		EJJBJILKBMG(DAEMAAOLHMG: true);
	}

	public void ActivateContent(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void PLFMCHABNBF(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void GEGBGNKBFIN(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void MKMHJFMGGEE(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void COAIKJBJOCH(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Sit" + LocalisationSystem.Get("Satisfaction");
		}
		IECPLGICCGD(DAEMAAOLHMG: false);
	}

	public void IKAHILIMDIC(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void HPBKJMCLDAP(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void IBLMGIEGHCO(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void JOFPBEMKOGM(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH();
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Items/item_name_606" + LocalisationSystem.Get("Received finish minigame");
		}
		JKPLBMMKAFM(DAEMAAOLHMG: false);
	}

	public void JDBJPLCPPFE(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void LHABENPEMPB()
	{
		GJBBNHCMNJN[playerNum - 4] = this;
	}

	public void NDDKPNFCLLD(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void NMIHLADIPOM()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NAGEHKBLJDL(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			}
		}
	}

	public void BJOHKMNOHPG(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void SetAlpha(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public static OnlineFishingTexts OCCEHEMCGJF(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 6];
	}

	public void PNJPJMJMMDO(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public static OnlineFishingTexts AKMJEPMHFMO(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 6];
	}

	private void NFPEFLHLIMM()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NDJAMDLOIJL(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			}
		}
	}

	private void DNKEFFMOCKP()
	{
		GJBBNHCMNJN[playerNum - 7] = this;
	}

	public void OONCDLOAELK(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public static OnlineFishingTexts IKCGJOENBGM(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 7];
	}

	private void NDDPKJIHKNA()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.GDFNPHJJCPP(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	public void KJFIHICMDEA(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void AOACPGKIALO(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.IABAKHPEOAF();
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "SetBoolRPC" + LocalisationSystem.Get("Dialogue System/Conversation/Gass_Barks_Bye/Entry/4/Dialogue Text");
		}
		AHNGNNFHHHL(DAEMAAOLHMG: true);
	}

	private void BODICIENBEH()
	{
		GJBBNHCMNJN[playerNum - 5] = this;
	}

	public void SetFishInfo(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.IABAKHPEOAF();
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + " " + LocalisationSystem.Get("centimeters");
		}
		ActivateContent(DAEMAAOLHMG: true);
	}

	private void OMBHDODDHNO()
	{
		GJBBNHCMNJN[playerNum - 2] = this;
	}

	private void EOBODNOCKGA()
	{
		GJBBNHCMNJN[playerNum - 7] = this;
	}

	public static OnlineFishingTexts NHOFBAMNELD(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	private void LateUpdate()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.Get(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	private void MJOLEIMPOGI()
	{
		GJBBNHCMNJN[playerNum - 6] = this;
	}

	private void NLEOMMPMBDF()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.Get(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	public static OnlineFishingTexts LKJNAHIPOLN(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 3];
	}

	public static OnlineFishingTexts MGLNAMHAIDG(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 0];
	}

	public static OnlineFishingTexts Get(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 2];
	}

	public void INNGJFOAIBP(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void AOOIENHPKFJ(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.KGHFCDELKMN(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Minigame" + LocalisationSystem.Get("");
		}
		HCGINBHMAGF(DAEMAAOLHMG: false);
	}

	public void POBLMOHAEII(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void KHMDEOAPIHN(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Invalid ninja customer ID: " + LocalisationSystem.Get("EditorAction_5");
		}
		IECPLGICCGD(DAEMAAOLHMG: true);
	}

	public void AJHIPHFPMBJ(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void MFILAFECDHH(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void NCEKJBKELBC(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH();
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Player" + LocalisationSystem.Get("Trying to assign the {0} parameter {1} with the incorrect type ({2}) on {3}.");
		}
		IECPLGICCGD(DAEMAAOLHMG: false);
	}

	public void HCGINBHMAGF(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void DJAFIEHLMNG(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.KGHFCDELKMN(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Items/item_name_626" + LocalisationSystem.Get("christmasActivated");
		}
		ELBFIGIHBCI(DAEMAAOLHMG: false);
	}

	public void NPDEGCKHADC(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public static OnlineFishingTexts NIDHCIHFOHB(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 8];
	}

	public static OnlineFishingTexts KDLDGFBDDCN(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 4];
	}

	public void AHNGNNFHHHL(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void GOBPJEDFOAC()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.GDFNPHJJCPP(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	public void JKPLBMMKAFM(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void KFCADNNCJFG(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.KGHFCDELKMN();
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Cat" + LocalisationSystem.Get("Received begin retry");
		}
		INNGJFOAIBP(DAEMAAOLHMG: true);
	}

	public void OPNDCJDKOBC(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void PBDNKBPBCHM()
	{
		GJBBNHCMNJN[playerNum - 7] = this;
	}

	private void JIAJFDKNJME()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void IECPLGICCGD(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void LHBBDLJMPCO(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void NJAFKFAPDIE()
	{
		GJBBNHCMNJN[playerNum - 5] = this;
	}

	public static OnlineFishingTexts AEJKCONFPHB(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 4];
	}

	private void HINGECEDJAP()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void CODHGPNMCAF(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void ADPJDPBNIBJ(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.IABAKHPEOAF(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "cameraZoom2" + LocalisationSystem.Get("\n \n");
		}
		FNLEBNPIPNM(DAEMAAOLHMG: true);
	}

	public static OnlineFishingTexts PNBHIEINMGH(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 8];
	}

	private void DEDDGMJNEPI()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NDJAMDLOIJL(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	private void EMJKKALMGLK()
	{
		GJBBNHCMNJN[playerNum - 6] = this;
	}

	public void NGBBNCGMOFI(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.IABAKHPEOAF();
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "UINextCategory" + LocalisationSystem.Get("MothersRecipe/MainEvent");
		}
		JKPLBMMKAFM(DAEMAAOLHMG: false);
	}

	public void DJAPBOCFAMN(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public static OnlineFishingTexts HKCAIFFKBMH(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 2];
	}

	private void GOGOIJNNEJF()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.JHOHGMODKGM(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	public void EADIPJBDECI(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void Awake()
	{
		GJBBNHCMNJN[playerNum - 2] = this;
	}

	public void NDNBIEINEGB(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void PPJMHGFLEDF()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.AIMEAJAHLAA(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			}
		}
	}

	public static OnlineFishingTexts MHOKIBDMIPL(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 3];
	}

	public void CIOKKAFAIFC(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void NEECFCAMEDC(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void CEOCIBICFKK(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void PDAHIOIAEKL()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.LAMFGLIGLOP(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	public void EJBDEPALEDC(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void IFGLHEPFIKN()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NAGEHKBLJDL(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	private void KMEJBPOOBJK()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void KFKNMIIEMLP(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.IABAKHPEOAF(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "TimeLeft" + LocalisationSystem.Get(" / ");
		}
		PLFMCHABNBF(DAEMAAOLHMG: true);
	}

	public void CIFAPDIEACA(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void GDAEKKGEFOB(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "MopActiveRPC" + LocalisationSystem.Get("");
		}
		OHFAEBEGEDG(DAEMAAOLHMG: true);
	}

	public static OnlineFishingTexts LOBGJNFHBJF(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	public void COMEMKDFHNC(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + " at " + LocalisationSystem.Get("FishCuttingEvent/Lose1");
		}
		AHNGNNFHHHL(DAEMAAOLHMG: false);
	}

	public void AJCFDCNBACJ(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void LNGIFCJIAGB(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void MHMFPFLOEKF(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH(OAFPBCPDOKH: true);
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Error_StairsAreBlocking" + LocalisationSystem.Get("HouseKeeperDescription");
		}
		PNJPJMJMMDO(DAEMAAOLHMG: false);
	}

	public void FNLEBNPIPNM(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void DOFFBALINNM()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NAGEHKBLJDL(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	public static OnlineFishingTexts MLDPLNAKHDK(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 6];
	}

	public void DMCACHEIAFM(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void ENFKMBKJKPJ(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void MFGANCCJFJK()
	{
		GJBBNHCMNJN[playerNum - 8] = this;
	}

	private void MBMFDJHDNCI()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NAGEHKBLJDL(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			}
		}
	}

	public static OnlineFishingTexts ODLPIANFFFJ(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 4];
	}

	public static OnlineFishingTexts IEHEFJBFHJL(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 8];
	}

	public static OnlineFishingTexts BMFHCBOFHCN(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	public void EJJBJILKBMG(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void GAHBEGEEOEL(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void FHHNHKPCLKP(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void GHJNMJJAAFC()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.NAGEHKBLJDL(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(1).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			}
		}
	}

	private void GFPPEHOHGDD()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && content.activeInHierarchy)
		{
			IIODPKHOCEO = FishingController.AIMEAJAHLAA(playerNum);
			if (Object.op_Implicit((Object)(object)IIODPKHOCEO))
			{
				fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
				fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(0).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
			}
		}
	}

	public void JFKJBOAJAFC(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	public void PANFLFBHCKH(Fish HAJFJGCNKFF, int LIBAOAJLENP)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.LJIFOHFEFCH();
		if (LIBAOAJLENP == 0)
		{
			if (((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = true;
			}
		}
		else
		{
			if (!((Behaviour)fishLenght).enabled)
			{
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "ReceiveCompleteServeNinjaCustomer" + LocalisationSystem.Get("]");
		}
		IGHOEHCDOGI(DAEMAAOLHMG: true);
	}

	public void IGDOFPPODAK(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
	}

	private void DGBJJNAADCI()
	{
		GJBBNHCMNJN[playerNum - 6] = this;
	}
}
