using AlmenaraGames;
using TMPro;
using UnityEngine;

public class FishingTexts : MonoBehaviour
{
	public int playerNum = 1;

	public GameObject content;

	public TextMeshProUGUI fishName;

	public RectTransform fishNameRect;

	public TextMeshProUGUI fishLenght;

	public RectTransform fishLenghtRect;

	public TextMeshProUGUI newRecordText;

	public RectTransform newRecordRect;

	private static FishingTexts[] GJBBNHCMNJN = new FishingTexts[5];

	private void Awake()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	private void PNJJEDEFAGO()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void OIKMFJGEBFO(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "UIInteract" + LocalisationSystem.Get("nodes not free 2");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		IIGKKEOOANA(DAEMAAOLHMG: false);
	}

	private void BFJOEMCBJJO()
	{
		GJBBNHCMNJN[playerNum - 0] = this;
	}

	private void DKFGDMNBAAK()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.AIMEAJAHLAA(playerNum) != (Object)null && (Object)(object)FishingController.Get(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(playerNum).WorldToScreenPoint(FishingController.NDJAMDLOIJL(playerNum).fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(playerNum).WorldToScreenPoint(FishingController.NIGDBMAOAEN(playerNum).fishingHook.fishLenghtPosition.position)));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.NAGEHKBLJDL(playerNum).fishingHook.recordPosition.position)));
		}
	}

	private void NLIBBOAOFEI()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.NIGDBMAOAEN(playerNum) != (Object)null && (Object)(object)FishingController.LAMFGLIGLOP(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.AIMEAJAHLAA(playerNum).fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.LAMFGLIGLOP(playerNum).fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.NIGDBMAOAEN(playerNum).fishingHook.recordPosition.position)));
		}
	}

	private void LMNKOMLKIAA()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.LAMFGLIGLOP(playerNum) != (Object)null && (Object)(object)FishingController.NAGEHKBLJDL(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(FishingController.AIMEAJAHLAA(playerNum).fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(playerNum).WorldToScreenPoint(FishingController.LAMFGLIGLOP(playerNum).fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.LAMFGLIGLOP(playerNum).fishingHook.recordPosition.position), BJOCPBIKBEE: true));
		}
	}

	public void PDAOEOPLEDN(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position)));
	}

	public void ANLCEMPLLLN(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void HGKAIMAIODL(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void ActivateContent(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public static FishingTexts CJMILOMGFJL(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	public static FishingTexts MENNLOGFNOK(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	private void MNIAGPINFCN()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.Get(playerNum) != (Object)null && (Object)(object)FishingController.NDJAMDLOIJL(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(playerNum).WorldToScreenPoint(FishingController.GDFNPHJJCPP(playerNum).fishingHook.fishNamePosition.position)));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(FishingController.NAGEHKBLJDL(playerNum).fishingHook.fishLenghtPosition.position)));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.GDFNPHJJCPP(playerNum).fishingHook.recordPosition.position)));
		}
	}

	public void EKHOGCGAGKI(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "ToggleGroup/ToggleBasic" + LocalisationSystem.Get("[ControllerType=");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		HGKAIMAIODL(DAEMAAOLHMG: true);
	}

	public void BHEODOABDNP(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "ReceiveChristmasTreeMessage" + LocalisationSystem.Get("Two numbers are needed. 'add item ID COUNT'");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		IIGKKEOOANA(DAEMAAOLHMG: false);
	}

	private void HEMAHKJEONA()
	{
		GJBBNHCMNJN[playerNum - 0] = this;
	}

	public void BGPECFFCCJP(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position)));
	}

	public void GGFJPOFJJPA(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.KGHFCDELKMN(OAFPBCPDOKH: true);
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "NormalRight" + LocalisationSystem.Get("[SymbolPuzzle] Solution: ");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		IIGKKEOOANA(DAEMAAOLHMG: true);
	}

	public void GDODDAMEIMH(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public static FishingTexts Get(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	public void FBOLODINAPM(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "HollyShop" + LocalisationSystem.Get("talent_name_115");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		IIGKKEOOANA(DAEMAAOLHMG: true);
	}

	public void AJDLJCAMFBE(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void LJAKFFIMNML(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	private void CIICEKEJANM()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	private void FBHHPNJGNJG()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	private void BODICIENBEH()
	{
		GJBBNHCMNJN[playerNum - 0] = this;
	}

	private void ECJFMIKNAKG()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.AIMEAJAHLAA(playerNum) != (Object)null && (Object)(object)FishingController.GDFNPHJJCPP(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(playerNum).WorldToScreenPoint(FishingController.JHOHGMODKGM(playerNum).fishingHook.fishNamePosition.position)));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.fishLenghtPosition.position)));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.AIMEAJAHLAA(playerNum).fishingHook.recordPosition.position)));
		}
	}

	public void BLCPNPEPLNI(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
				((Behaviour)fishLenght).enabled = false;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + " to user for reason " + LocalisationSystem.Get("BetterDuringOneMonth");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		DPKEKBCEGJK(DAEMAAOLHMG: true);
	}

	public void CIIPMBBPGFM(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void NPLKACJCPHF(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public static FishingTexts HKCAIFFKBMH(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	public static FishingTexts HJHCKIAKCKD(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 0];
	}

	public void EHHHPJEMFJN(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void LAPKOCHBNNP()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.JHOHGMODKGM(playerNum) != (Object)null && (Object)(object)FishingController.NDJAMDLOIJL(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(FishingController.AIMEAJAHLAA(playerNum).fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.FKNGHFFDPEC(playerNum).WorldToScreenPoint(FishingController.NAGEHKBLJDL(playerNum).fishingHook.recordPosition.position)));
		}
	}

	public void ONHAHCMNIPA(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.KGHFCDELKMN(OAFPBCPDOKH: true);
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "add floor not found" + LocalisationSystem.Get("RoadBlocked/Main 2");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().banjoSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		ANLCEMPLLLN(DAEMAAOLHMG: true);
	}

	public void SetOnlinePosition(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position)));
	}

	public static FishingTexts BDJFHFHLJGN(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 0];
	}

	public void MGLKDIBNKBI(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Freeze" + LocalisationSystem.Get("Walk");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoBigSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		HGKAIMAIODL(DAEMAAOLHMG: true);
	}

	public void KJMLCIFOKBD(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position), BJOCPBIKBEE: true));
	}

	private void AFHGDCBNALO()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.GDFNPHJJCPP(playerNum) != (Object)null && (Object)(object)FishingController.Get(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.LAMFGLIGLOP(playerNum).fishingHook.fishNamePosition.position)));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.NAGEHKBLJDL(playerNum).fishingHook.fishLenghtPosition.position)));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.NIGDBMAOAEN(playerNum).fishingHook.recordPosition.position), BJOCPBIKBEE: true));
		}
	}

	public void JABLIBHHMBJ(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	private void GECHJIGBPEN()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void DHDDMCAKPLJ(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position), BJOCPBIKBEE: true));
	}

	private void JDAMCMODANB()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void DKOIHLKFPEF(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position), BJOCPBIKBEE: true));
	}

	public void EEPAAAONKFC(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position), BJOCPBIKBEE: true));
	}

	private void EBJPPNBLGOC()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.GDFNPHJJCPP(playerNum) != (Object)null && (Object)(object)FishingController.NDJAMDLOIJL(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.NAGEHKBLJDL(playerNum).fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.LAMFGLIGLOP(playerNum).fishingHook.fishLenghtPosition.position)));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.NAGEHKBLJDL(playerNum).fishingHook.recordPosition.position)));
		}
	}

	public void LIKGOOHKNBM(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "via End-Segment" + LocalisationSystem.Get("RecieveEndMaiEvent");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().banjoBigSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		ActivateContent(DAEMAAOLHMG: false);
	}

	private void HINGECEDJAP()
	{
		GJBBNHCMNJN[playerNum - 0] = this;
	}

	public void OOPCKEBPFLP(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void SetFishInfo(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		ActivateContent(DAEMAAOLHMG: true);
	}

	public void CEOCIBICFKK(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void FEGMFNFOOFP(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position)));
	}

	public void DINMCCGIBAO(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position)));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position)));
	}

	public void PANFLFBHCKH(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "ReciveResetDialogueUISawmill" + LocalisationSystem.Get("Dialogue System/Conversation/Gass_Barks_Bye/Entry/2/Dialogue Text");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		NPLKACJCPHF(DAEMAAOLHMG: false);
	}

	public void HPBKJMCLDAP(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void OFDKGCJCDIB(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public static FishingTexts NHOFBAMNELD(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 0];
	}

	private void FLBFKMEHJKJ()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.Get(playerNum) != (Object)null && (Object)(object)FishingController.AIMEAJAHLAA(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(playerNum).WorldToScreenPoint(FishingController.NAGEHKBLJDL(playerNum).fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.fishLenghtPosition.position)));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.recordPosition.position)));
		}
	}

	public void PDIKKJNDLEO(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Fullscreen Window" + LocalisationSystem.Get("UIInteract");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		ANLCEMPLLLN(DAEMAAOLHMG: true);
	}

	public void OGMHNGJOBFG(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Mozzarella" + LocalisationSystem.Get("DecorationTile_9");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		EHHHPJEMFJN(DAEMAAOLHMG: false);
	}

	private void LateUpdate()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.Get(playerNum) != (Object)null && (Object)(object)FishingController.Get(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.fishNamePosition.position)));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.fishLenghtPosition.position)));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.recordPosition.position)));
		}
	}

	public void JPJFDDBAPDE(FishingController IIODPKHOCEO)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
		fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.AFEPIAHBKDA(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.fishLenghtPosition.position)));
		newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(IIODPKHOCEO.fishingHook.recordPosition.position), BJOCPBIKBEE: true));
	}

	private void NEOICNJNKNL()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void SetAlpha(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void IKEIHOMMAKM(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "End Event " + LocalisationSystem.Get("Cancel");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().banjoBigSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		CACCPKAMMEN(DAEMAAOLHMG: true);
	}

	public void NDCIGCGAHND(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
				((Behaviour)fishLenght).enabled = true;
			}
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "" + LocalisationSystem.Get("");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		HPBKJMCLDAP(DAEMAAOLHMG: true);
	}

	public static FishingTexts FBKOKJCKICN(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 0];
	}

	public static FishingTexts NIDHCIHFOHB(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	public void OONCDLOAELK(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	private void KMEJBPOOBJK()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	private void NLGHNDLPPKI()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	public void GCCGIJHCECJ(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void FMOAPCHMDBL(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	private void NPHKFBIEMDO()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.GDFNPHJJCPP(playerNum) != (Object)null && (Object)(object)FishingController.NAGEHKBLJDL(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.NIGDBMAOAEN(playerNum).fishingHook.fishNamePosition.position), BJOCPBIKBEE: true));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.fishLenghtPosition.position), BJOCPBIKBEE: true));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.IIAGBBKKGPJ(playerNum).WorldToScreenPoint(FishingController.NIGDBMAOAEN(playerNum).fishingHook.recordPosition.position), BJOCPBIKBEE: true));
		}
	}

	public void NNFPDALCBOO(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "ReceiveInfoTerrain" + LocalisationSystem.Get("Tutorial/T107/Dialogue2");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		HGKAIMAIODL(DAEMAAOLHMG: true);
	}

	public static FishingTexts PIOIOJFDDNF(int GELMAIBEHDO)
	{
		return GJBBNHCMNJN[GELMAIBEHDO - 1];
	}

	private void KHONOODGLBI()
	{
		GJBBNHCMNJN[playerNum - 1] = this;
	}

	private void GFPPEHOHGDD()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (content.activeInHierarchy && (Object)(object)FishingController.NAGEHKBLJDL(playerNum) != (Object)null && (Object)(object)FishingController.AIMEAJAHLAA(playerNum).fishingHook != (Object)null)
		{
			fishNameRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.LAMFGLIGLOP(playerNum).fishingHook.fishNamePosition.position)));
			fishLenghtRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.PIEGMALBKJG(playerNum).WorldToScreenPoint(FishingController.Get(playerNum).fishingHook.fishLenghtPosition.position)));
			newRecordRect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(CommonReferences.GetCamera(playerNum).WorldToScreenPoint(FishingController.LAMFGLIGLOP(playerNum).fishingHook.recordPosition.position), BJOCPBIKBEE: true));
		}
	}

	public void DPKEKBCEGJK(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void IIGKKEOOANA(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void OLFAGOKILJK(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
	{
		((TMP_Text)fishName).text = HAJFJGCNKFF.KGHFCDELKMN();
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Fill" + LocalisationSystem.Get("Player/Bark/Error/NotAllPlayersHere");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		DPKEKBCEGJK(DAEMAAOLHMG: true);
	}

	public void CACCPKAMMEN(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
	}

	public void LFIDLJDPCOI(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Interact" + LocalisationSystem.Get("ThemeListScrollView");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().banjoSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		HGKAIMAIODL(DAEMAAOLHMG: true);
	}

	public void JFKJBOAJAFC(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void AOACPGKIALO(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "Player2" + LocalisationSystem.Get("Food");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		DPKEKBCEGJK(DAEMAAOLHMG: false);
	}

	public void NEECFCAMEDC(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void ENABCANHAFE(float GODBHHOFBMJ)
	{
		((TMP_Text)fishName).alpha = GODBHHOFBMJ;
		((TMP_Text)fishLenght).alpha = GODBHHOFBMJ;
		((TMP_Text)newRecordText).alpha = GODBHHOFBMJ;
	}

	public void GEOMGBAACGO(Fish HAJFJGCNKFF, int LIBAOAJLENP, bool PFBIBFJKHDD)
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
			((TMP_Text)fishLenght).text = LIBAOAJLENP + "The character name can't be empty." + LocalisationSystem.Get("RecalculatingAllWallTiles (ONLINE) [client]");
			if (PFBIBFJKHDD)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().banjoBigSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
			else
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.banjoSuccess, ((Component)PlayerController.GetPlayer(playerNum)).transform);
			}
		}
		((Component)newRecordText).gameObject.SetActive(PFBIBFJKHDD);
		EHHHPJEMFJN(DAEMAAOLHMG: false);
	}

	private void BGBFJPJLPMF()
	{
		GJBBNHCMNJN[playerNum - 0] = this;
	}
}
