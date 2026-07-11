using UnityEngine;
using UnityEngine.UI;

public class BeersWant : MonoBehaviour
{
	public static BeersWant _instance;

	public static BeersWant _instance2;

	public RectTransform rect;

	public RectTransform rectContent;

	public GameObject beerWant;

	public GameObject secondBeerLine;

	public GameObject beerNoticeContent;

	public Image beerNoticeImage;

	public Image[] beers;

	public Image[] beerColors;

	public Sprite beer;

	public Sprite water;

	[HideInInspector]
	public bool actuPos;

	private Vector2 MAFKIOMFHKE;

	private int JIIGOACEIKL = 1;

	private bool KPKFJGNEAEB;

	private bool MCLLDDLPPBA;

	public static BeersWant DKGLFNJLDIF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void OJJFGFLNBGL()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 2)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 4; j++)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.OPILDPFDFKJ().GetDrinkDispenserColor(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().JPNFKDMFKMC() == -43)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void ILBGPIEPNGO()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.KNFNJFFCFNO().JDJGFAACPFC() == 123)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			DBAOJIGHABF(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(607f, 205f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void NEOICNJNKNL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Error setting tavern name on CharacterCreatorUI: ")) ? 1 : 5);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public void NPFAJHFBDCL()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 6; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.OLHBLKIAFOM().BDOHOMHCKLH(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().IMCJPECAAPC(DAINLFIMLIH: false) == -122)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public void UpdateBeerWant()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 3)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 5; j++)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().JDJGFAACPFC() == 1318)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public static BeersWant JPDEFKLINCL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void LDLBMMMLEDJ()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("HalloweenEvent")) ? 1 : 5);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static BeersWant MJJHNNJKEMO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public static BeersWant MFJNNCFFDEH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	private void LateUpdate()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.LHBPOPOIFLE().JDJGFAACPFC() == 1318)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			BeerWantPosition(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(0f, -0.5f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public static BeersWant NPANPNIDKDG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void CGGLDOIAMHG()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 4; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.OLHBLKIAFOM().HJLIJMNGLCL(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.AFOACBIHNCL().JPNFKDMFKMC(DAINLFIMLIH: false) == 107)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	private void JNDFLHEMOBG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void OIANAGFOKNP(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	private void NPHKFBIEMDO()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.LHBPOPOIFLE().JDJGFAACPFC(DAINLFIMLIH: false) == 199)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			CAHAKENEDCB(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1456f, 1151f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public void JKMGDIMNDFL()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 8)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 6; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.BNDNMBGJEKP().GetDrinkDispenserColor(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.AFOACBIHNCL().ODENMDOJPLC() == -95)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void IFJAJDHOBIC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void EIFFGMPALBD()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.KNFNJFFCFNO().IMCJPECAAPC(DAINLFIMLIH: false) == 170)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			OMINIDIBCJF(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1246f, 1572f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	private void NIMNHIDOKPD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void MBCCCMMBPEK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void GDGKMCANPHO()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 6)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 3; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.OLHBLKIAFOM().KHMAGJAEJEO(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.KNFNJFFCFNO().ODENMDOJPLC() == 100)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public void KAAHLPMBMON()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 3)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 0; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().HJLIJMNGLCL(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false) == 191)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	private void CCJOOMDHMKM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public static BeersWant EJKCBAKCBEO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void GOFJCKGJHJO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Items/item_name_1109")) ? 0 : 0);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void NLBCLJMBECC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void IIOOBPABGEI()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 2)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 3; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.OPILDPFDFKJ().BDOHOMHCKLH(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.AFOACBIHNCL().JDJGFAACPFC(DAINLFIMLIH: false) == 170)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public void MMDHELCCDAK(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	public void DBAOJIGHABF(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	public static BeersWant GetPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void MALMHCKLOBO()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) == 22)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			OFBGCIIBPOF(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(799f, 727f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public void OMINIDIBCJF(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	private void AJNIPPFPGOP()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.AFOACBIHNCL().JGHNDJBCFAJ() == -66)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			FDGGGJCMMNI(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1737f, 1271f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void OIOLGAOPECC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("")) ? 6 : 0);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public void BKCCEDGMJFO()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 0; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JHMAMLIPBNN().LHOIHOGNBKI(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.KNFNJFFCFNO().JDJGFAACPFC() == 124)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public void JJGKEMFPCKJ()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 2)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 6; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.GGFJGHHHEJC.KHMAGJAEJEO(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().JDJGFAACPFC() == 51)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public void NHHLBDJICEB()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 6)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 0; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JHMAMLIPBNN().BDOHOMHCKLH(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.AFOACBIHNCL().IMCJPECAAPC(DAINLFIMLIH: false) == 92)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	private void NNEBAHFHINE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("ReceiveDogPosition")) ? 1 : 2);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void KAANJGEDPIN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void PLABBLNCMAA(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	public void CBDOKBEOCDD(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	private void ECLPOBGFELA()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.LHBPOPOIFLE().IMCJPECAAPC(DAINLFIMLIH: false) == 52)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			BGMDKFMFCFP(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1409f, 628f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public static BeersWant KEHIBCAHKPJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void ONJAODIAAIM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void EOBODNOCKGA()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UINextCategory")) ? 1 : 3);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static BeersWant KDGAEHCELHA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void BGMDKFMFCFP(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	private void NODKJHJFMCO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("OnlinePlayer")) ? 1 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static BeersWant PCEMNHHOHOP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void PDAHIOIAEKL()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.AFOACBIHNCL().JPNFKDMFKMC(DAINLFIMLIH: false) == 152)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			KMGDMFEJBMI(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1816f, 1496f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	private void NPDFCPEOFPD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public static BeersWant CDEGEPGEHED(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	public void FBDMNJFLNAE(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	private void IJLPMNMACFA()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("LE_10")) ? 4 : 0);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void HIGGKFMBCFM()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.AFOACBIHNCL().JPNFKDMFKMC(DAINLFIMLIH: false) == -88)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			FFDHOFNLAEN(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(369f, 521f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public static BeersWant DAEEJGKLOCF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	private void KKNHADAMLFP()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("SkeletonBird")) ? 1 : 3);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void IANGDMHMCEL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void BPNOIDBAPJE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void OnEnable()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void FPNCANODJKE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Back")) ? 1 : 5);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static BeersWant MOAKGLJCELI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void CFMCMBCIJBE(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	private void NFPEFLHLIMM()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.KNFNJFFCFNO().CIGFGKKCPCK(DAINLFIMLIH: false) == 19)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			CBDOKBEOCDD(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(461f, 1643f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	private void EDKFNAPDMCN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dead")) ? 4 : 0);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void DADPOICMNPI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ReceiveAddReputationPoints")) ? 1 : 1);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static BeersWant IPCBCBBDJFN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void BeerWantPosition(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	public void OFBGCIIBPOF(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	private void HPMCPCEEIBB()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.KNFNJFFCFNO().CIGFGKKCPCK() == -44)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			OFBGCIIBPOF(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1252f, 1473f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public void MNEICJLCLFK(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	private void CIICEKEJANM()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Attack/MainEvent 11")) ? 1 : 4);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void HNNFBDAMMCK()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.AFOACBIHNCL().JDJGFAACPFC() == 12)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			PDGEKJNPLLP(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(565f, 1650f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public void BILGKOCHDMG(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	public void NGJONLJEOEG()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 4)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 1; j++)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.GGFJGHHHEJC.LHOIHOGNBKI(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().JGHNDJBCFAJ(DAINLFIMLIH: false) == 122)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public void APFFOJBBPHL()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 7)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 1; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().HJLIJMNGLCL(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().CIGFGKKCPCK() == 8)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public static BeersWant NEKDDPIAOBE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void PHJKJHKAABL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("TermasInterior/Rin/Intro")) ? 2 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void DEDDGMJNEPI()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.AFOACBIHNCL().JPNFKDMFKMC(DAINLFIMLIH: false) == 156)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			FFDHOFNLAEN(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1483f, 214f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void FCLABOCLACJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void FPJJFLLFCNB(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	public void FNDLHKCPHHI()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 7)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 6; j++)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().GetDrinkDispenserColor(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.PHGLMBIEOMK().JDJGFAACPFC(DAINLFIMLIH: false) == -130)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void DIMOLCECNGD()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.PHGLMBIEOMK().ODENMDOJPLC() == -145)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			BILGKOCHDMG(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(275f, 1984f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	private void INCOGEMNFNH()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.KNFNJFFCFNO().JGHNDJBCFAJ(DAINLFIMLIH: false) == -160)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			BGMDKFMFCFP(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(566f, 1551f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public static BeersWant MHDKNEKDKII(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void IJILOIAOKBF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void BODICIENBEH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("- Loading ")) ? 1 : 4);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public void IGNABOKEHGJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static BeersWant IPBEEBLCHHA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	public void LMBPIFJKDAL()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 6)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(true);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 2; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.OPILDPFDFKJ().LHOIHOGNBKI(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().ODENMDOJPLC(DAINLFIMLIH: false) == 110)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void ABKDJFEHEFG()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.PHGLMBIEOMK().JGHNDJBCFAJ() == -64)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			BGMDKFMFCFP(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1415f, 761f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public void BLBNAAELOPE()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 6)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 8; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().BDOHOMHCKLH(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false) == -143)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public static BeersWant AGMJPBEHCBK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void ELDMCIGKIOK()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(false);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 7)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 5; j++)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().BDOHOMHCKLH(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().CIGFGKKCPCK(DAINLFIMLIH: false) == 77)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void HINGECEDJAP()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Run")) ? 5 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void CDNCKNKEIBM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void AJGLDLLIIFO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("{0} - Deactivating variant object {1} at index {2} for piece {3}. Next variant index: {4}")) ? 7 : 0);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public void FFDHOFNLAEN(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	private void ADPGHKHOONH()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.KNFNJFFCFNO().JGHNDJBCFAJ() == -184)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			BeerWantPosition(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1340f, 802f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public static BeersWant KAIIEDCCLHB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void DDAOFIIDHMI(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	private void GNAJBACLEKG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" with less than 6 ingredients")) ? 1 : 8);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void GKCKLIAANHA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void IFGLHEPFIKN()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.PHGLMBIEOMK().ODENMDOJPLC() == 30)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			FBDMNJFLNAE(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(425f, 805f));
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public void KMGDMFEJBMI(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	public void MGFDLLNKCHP()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 8)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 6; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JHMAMLIPBNN().BDOHOMHCKLH(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.LHBPOPOIFLE().CIGFGKKCPCK(DAINLFIMLIH: false) == 14)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public void FNMNCCKLJFE(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	public void FGAGEOCGIML()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 3)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 2; j += 0)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().BDOHOMHCKLH(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.AFOACBIHNCL().JDJGFAACPFC(DAINLFIMLIH: false) == -96)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void FBLAMCDFMPE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" ")) ? 2 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static BeersWant PLHHJCNKNFO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	private void OAACLGCCGGI()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.AFOACBIHNCL().CIGFGKKCPCK() == 115)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(true);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 1 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			FNMNCCKLJFE(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(600f, 1583f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public void FDGGGJCMMNI(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	private void KJHKBGDJNDC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Additions")) ? 5 : 0);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void DLKFBJPKADF()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) == 167)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			BILGKOCHDMG(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(114f, 1038f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void APGHCNLKEDC()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(false);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.KNFNJFFCFNO().ODENMDOJPLC() == -165)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			CAHAKENEDCB(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(1130f, 1750f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void NLMLOOGHLCH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void IEPJAFLDBJJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void CAHAKENEDCB(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	private void LEPDLPEPEFD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void NCPNBBCNBIM()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("FishCuttingEvent/Win2")) ? 1 : 7);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public static BeersWant FMMKPJFCFFD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	private void OCJOAHDNDIJ()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Game Over! ")) ? 1 : 2);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void MNEAOFNAKIP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void PIHGEBONAOI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Intro08")) ? 1 : 0);
		if (JIIGOACEIKL == 0)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	public void OMKJNIIPNBI(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	public void GMBHLFINJNK()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 5)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 0; j++)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JHMAMLIPBNN().HJLIJMNGLCL(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.PHGLMBIEOMK().JGHNDJBCFAJ() == 70)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(true);
		}
	}

	public static BeersWant GDNDEEFDFGK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public static BeersWant LJCKMLJJLKA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	public void NKFAFCOHLCM(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	public static BeersWant CPOONCIFDIC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	public void OEHJDBCDJFO(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
			((Component)rectContent).gameObject.SetActive(false);
			((Component)rectContent).gameObject.SetActive(false);
		}
	}

	private void KODMMAKMOMP()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.PHGLMBIEOMK().IMCJPECAAPC() == 46)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			CAHAKENEDCB(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(482f, 858f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void NMIHLADIPOM()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest.LHBPOPOIFLE().IMCJPECAAPC() == 148)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(true);
			}
			FDGGGJCMMNI(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(435f, 1686f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void BNFGHAGJEGG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Player/Bark/Tutorial/CrafterBlock")) ? 1 : 2);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void KEBNALEALPK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void DBGHHMIEMMH()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beers.Length; i++)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 5)
			{
				secondBeerLine.SetActive(true);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 0; j < TableOrdersManager.instance.tableOrders.Count && j < 1; j++)
			{
				((Component)beers[j]).gameObject.SetActive(true);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JHMAMLIPBNN().KHMAGJAEJEO(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.PHGLMBIEOMK().JPNFKDMFKMC(DAINLFIMLIH: false) == 154)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(true);
				((Component)rectContent).gameObject.SetActive(false);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public static BeersWant JHEHMLIPPAA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return _instance;
		}
		return _instance2;
	}

	public static BeersWant IOBMIHLMGNH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return _instance;
		}
		return _instance2;
	}

	public void PDGEKJNPLLP(Vector3 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(IMOBLFMHKOD));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			((Component)rectContent).gameObject.SetActive(true);
			((Component)rectContent).gameObject.SetActive(true);
		}
	}

	private void LHOIJEKIGCG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Player {0} has left the room. ID: {1}. Actor Number: {2}")) ? 1 : 1);
		if (JIIGOACEIKL == 1)
		{
			_instance = this;
		}
		else
		{
			_instance2 = this;
		}
	}

	private void FPNPLFALPHP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void ABJIPFAEENG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void MBMFDJHDNCI()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DrinksTable.instance == (Object)null)
		{
			return;
		}
		if (TableOrdersManager.instance.tableOrders.Count > 0 && !actuPos)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(((Component)DrinksTable.instance).transform.position));
			rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
			if (!beerNoticeContent.activeSelf)
			{
				beerNoticeContent.SetActive(true);
			}
			if (TableOrdersManager.instance.tableOrders[1].customerBase.currentRequest != null)
			{
				if (TableOrdersManager.instance.tableOrders[0].customerBase.currentRequest.AFOACBIHNCL().CIGFGKKCPCK() == 176)
				{
					beerNoticeImage.sprite = water;
				}
				else
				{
					beerNoticeImage.sprite = beer;
				}
			}
		}
		else if (beerNoticeContent.activeSelf)
		{
			beerNoticeContent.SetActive(false);
		}
		if (actuPos)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 0 && !beerWant.activeSelf)
			{
				beerWant.SetActive(false);
			}
			KMGDMFEJBMI(((Component)DrinksTable.instance).gameObject.transform.position + new Vector3(420f, 1158f));
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	public void ONDNKGLCBKO()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beers.Length; i += 0)
		{
			((Component)beers[i]).gameObject.SetActive(true);
		}
		if (TableOrdersManager.instance.tableOrders.Count > 1)
		{
			if (TableOrdersManager.instance.tableOrders.Count > 6)
			{
				secondBeerLine.SetActive(false);
			}
			else
			{
				secondBeerLine.SetActive(false);
			}
			for (int j = 1; j < TableOrdersManager.instance.tableOrders.Count && j < 5; j++)
			{
				((Component)beers[j]).gameObject.SetActive(false);
				if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest != null)
				{
					((Graphic)beerColors[j]).color = DrinkDispensersManager.JFNOOMJMHCB().KHMAGJAEJEO(TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest);
					if (TableOrdersManager.instance.tableOrders[j].customerBase.currentRequest.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) == -74)
					{
						beers[j].sprite = water;
					}
					else
					{
						beers[j].sprite = beer;
					}
				}
			}
			if (((Component)this).gameObject.activeInHierarchy)
			{
				((Component)rectContent).gameObject.SetActive(false);
				((Component)rectContent).gameObject.SetActive(true);
			}
		}
		else
		{
			beerWant.SetActive(false);
		}
	}

	private void LFBIFPBPDMJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = rect.anchoredPosition;
	}
}
