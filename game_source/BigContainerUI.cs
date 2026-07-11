using System;
using System.Collections.Generic;
using UnityEngine;

public class BigContainerUI : ContainerUI
{
	private List<PageButtonUI> DBDKLDCJGAO;

	[SerializeField]
	private PageButtonUI pageButtonUI;

	[SerializeField]
	private GameObject pagesParent;

	[SerializeField]
	private GameObject top;

	[SerializeField]
	private GameObject trendsButton;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private GamepadSprite previousPageSprite;

	[SerializeField]
	private GamepadSprite nextPageSprite;

	[SerializeField]
	private GamepadSprite trendsGamepadSprite;

	[SerializeField]
	private GameObject previousKeyPageSprite;

	[SerializeField]
	private GameObject nextKeyPageSprite;

	private float CMGDCLIIONE;

	private static BigContainerUI[] GJBBNHCMNJN = new BigContainerUI[3];

	[SerializeField]
	private GameObject rightArrow;

	[SerializeField]
	private GameObject leftArrow;

	private int CHAEMDNAODI;

	public void DPOLOLACDDJ(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	private void LIGKOAGOGKE(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].MHNCEBLHLKH(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
		HICIPMAJJPI();
		PGEGOAJILGD();
	}

	private void MFPPDNEBJNM(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		HICIPMAJJPI();
		NEMIFDKGJLI();
	}

	public void CEPJPBKALOG()
	{
		if (currentPage > 0)
		{
			DJPBNJGDFIL(currentPage - 0);
		}
	}

	public void LMNNGCOMAFE(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).KBFCCPBHDMP() != (Object)null)
		{
			for (int i = 1; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BCHJGDHJHJK()).gameObject))
				{
					flag = true;
					slotsUI[i].FLMJLOIKEEN();
					break;
				}
			}
		}
		for (int j = 0; j < DBDKLDCJGAO.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
				CJPDBOGEENB(j);
				currentPage = j;
				if (EKLFNJDAKAM > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 1)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public void FKMNOMIAILM(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void DDJINJHKGKD()
	{
		if (currentPage > 1)
		{
			HJFKMPHCIEN(currentPage - 0);
		}
	}

	private void NJEMOGJIEHF(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].MHNCEBLHLKH(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].MHNCEBLHLKH(null);
			}
		}
		CAJOAHJFMDA();
		SelectObjectIfSlotSelected();
	}

	public void LeftArrow()
	{
		if (currentPage > 0)
		{
			FocusPage(currentPage - 1);
		}
	}

	public void EEFKFENNCND(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 0; i < EKLFNJDAKAM; i += 0)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(true);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(HAGADLDHGOK));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j += 0)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(true);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(false);
			}
		}
	}

	public void APHEJLILBBK()
	{
		if (currentPage > 0)
		{
			EICKAJAPDKH(currentPage - 1);
		}
	}

	public void HDMFLEALFJI(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void DINEBCPJMCK(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 0; i < EKLFNJDAKAM; i += 0)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(false);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(HJFKMPHCIEN));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j++)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(false);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(false);
			}
		}
	}

	public void HKMJNLMKNKN(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 1; i < EKLFNJDAKAM; i += 0)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(false);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(EICKAJAPDKH));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j++)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(true);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(false);
			}
		}
	}

	public void BOMOOKAENJN(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void PreparePagesMode(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 0; i < EKLFNJDAKAM; i++)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(true);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(FocusPage));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j++)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(false);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(false);
			}
		}
	}

	public void HMHLEPCGNNE(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 0; i < EKLFNJDAKAM; i++)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(true);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(OLCKKACAMJK));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j += 0)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(true);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(true);
			}
		}
	}

	private void ONCPDEIOALH(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].MHNCEBLHLKH(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].MHNCEBLHLKH(null);
			}
		}
		FillPageSlots();
		SelectObjectIfSlotSelected();
	}

	public void SetTrendsButtonVisible(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public static BigContainerUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static BigContainerUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void DJPBNJGDFIL(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KBFCCPBHDMP() != (Object)null)
		{
			for (int i = 0; i < slotsUI.Count; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BEOANCLEPOO()).gameObject))
				{
					flag = true;
					slotsUI[i].EndHover();
					break;
				}
			}
		}
		for (int j = 0; j < DBDKLDCJGAO.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
				LDGNLGGIFDK(j);
				currentPage = j;
				if (EKLFNJDAKAM > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BCHJGDHJHJK()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	private void BFMBLIFLDIM(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].MHNCEBLHLKH(null);
			}
		}
		JOFLPCPBOPK();
		SelectObjectIfSlotSelected();
	}

	public void LCNPMHDPDMP()
	{
		if (currentPage < EKLFNJDAKAM - 1)
		{
			KKGCJPMJNOL(currentPage + 0);
		}
	}

	public static BigContainerUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void PLPLDPJDCEK(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 0; i < EKLFNJDAKAM; i += 0)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(true);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(HAGADLDHGOK));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j += 0)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(false);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(true);
			}
		}
	}

	public static BigContainerUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
	}

	public void FocusPage(int KHEICLKLPDE)
	{
		bool flag = false;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)null)
		{
			for (int i = 0; i < slotsUI.Count; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject))
				{
					flag = true;
					slotsUI[i].EndHover();
					break;
				}
			}
		}
		for (int j = 0; j < DBDKLDCJGAO.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
				CJPDBOGEENB(j);
				currentPage = j;
				if (EKLFNJDAKAM > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < DBDKLDCJGAO.Count - 1)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	public static BigContainerUI OHPNDOJNCBK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void ANBDDNMIJHG(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BCHJGDHJHJK() != (Object)null)
		{
			for (int i = 0; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BCHJGDHJHJK()).gameObject))
				{
					flag = true;
					slotsUI[i].EndHover();
					break;
				}
			}
		}
		for (int j = 0; j < DBDKLDCJGAO.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
				BFMBLIFLDIM(j);
				currentPage = j;
				if (EKLFNJDAKAM > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 1)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(false);
					}
					else if (KHEICLKLPDE > 1 && KHEICLKLPDE < DBDKLDCJGAO.Count - 1)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	private void BHOIKCLCLPA(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Count; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].MHNCEBLHLKH(null);
			}
		}
		FillPageSlots();
		NEMIFDKGJLI();
	}

	public void IMGNABAPJHN()
	{
		if (currentPage < EKLFNJDAKAM - 1)
		{
			HJFKMPHCIEN(currentPage + 0);
		}
	}

	public static BigContainerUI AANKLOIDPOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static BigContainerUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static BigContainerUI EPLOMIBMKFC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void KHBBJJNNBPD(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 1; i < EKLFNJDAKAM; i += 0)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(false);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(OLCKKACAMJK));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j++)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(false);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(true);
			}
		}
	}

	public void KKGCJPMJNOL(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).CGCIFFOJGOK() != (Object)null)
		{
			for (int i = 0; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).MGOEJJIMAIP()).gameObject))
				{
					flag = false;
					slotsUI[i].EndHover();
					break;
				}
			}
		}
		for (int j = 0; j < DBDKLDCJGAO.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
				CJPDBOGEENB(j);
				currentPage = j;
				if (EKLFNJDAKAM > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public void HJFKMPHCIEN(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BEOANCLEPOO() != (Object)null)
		{
			for (int i = 0; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).FOKMCIDMIKF()).gameObject))
				{
					flag = true;
					slotsUI[i].EndHover();
					break;
				}
			}
		}
		for (int j = 1; j < DBDKLDCJGAO.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
				BHOIKCLCLPA(j);
				currentPage = j;
				if (EKLFNJDAKAM > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 1)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CGCIFFOJGOK()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	private void LDGNLGGIFDK(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		CAJOAHJFMDA();
		NEMIFDKGJLI();
	}

	public void NACCNOFNEHM(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 1; i < EKLFNJDAKAM; i++)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(false);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(ANBDDNMIJHG));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j += 0)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(true);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(true);
			}
		}
	}

	public static BigContainerUI JGNOJMLHPOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static BigContainerUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void KINJADPMEPL(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
		CAJOAHJFMDA();
		SelectObjectIfSlotSelected();
	}

	private void PNFCCDIKJEF(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].MHNCEBLHLKH(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].MHNCEBLHLKH(null);
			}
		}
		AOCEJNAPJBJ();
		SelectObjectIfSlotSelected();
	}

	public static BigContainerUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void JALJCAFBLBC(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		CAJOAHJFMDA();
		PGEGOAJILGD();
	}

	public static BigContainerUI BFCEHJIIAHN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void EICKAJAPDKH(int KHEICLKLPDE)
	{
		bool flag = false;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KDJFBLKPFKM() != (Object)null)
		{
			for (int i = 1; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).KDJFBLKPFKM()).gameObject))
				{
					flag = false;
					slotsUI[i].FLMJLOIKEEN();
					break;
				}
			}
		}
		for (int j = 0; j < DBDKLDCJGAO.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
				ONCPDEIOALH(j);
				currentPage = j;
				if (EKLFNJDAKAM > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 1)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < DBDKLDCJGAO.Count - 1)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).MGOEJJIMAIP()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	public void FCOIPBNHGMJ(int KHEICLKLPDE)
	{
		bool flag = false;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)null)
		{
			for (int i = 0; i < slotsUI.Count; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BOHHKGMEEEE()).gameObject))
				{
					flag = false;
					slotsUI[i].EndHover();
					break;
				}
			}
		}
		for (int j = 0; j < DBDKLDCJGAO.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
				LIGKOAGOGKE(j);
				currentPage = j;
				if (EKLFNJDAKAM > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 1 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public void PLOOPMCJEGP(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 0; i < EKLFNJDAKAM; i += 0)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(true);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(KKGCJPMJNOL));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j++)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(true);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(false);
			}
		}
	}

	public void EJKMBKIOOLC(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void OLCKKACAMJK(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BEOANCLEPOO() != (Object)null)
		{
			for (int i = 0; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FOKMCIDMIKF()).gameObject))
				{
					flag = false;
					slotsUI[i].FLMJLOIKEEN();
					break;
				}
			}
		}
		for (int j = 1; j < DBDKLDCJGAO.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
				LDGNLGGIFDK(j);
				currentPage = j;
				if (EKLFNJDAKAM > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(false);
					}
					else if (KHEICLKLPDE > 1 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FOKMCIDMIKF()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	private void JPKHAEMOKFM(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].MHNCEBLHLKH(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		FillPageSlots();
		NEMIFDKGJLI();
	}

	public void CMNEGEJDGEC()
	{
		if (currentPage < EKLFNJDAKAM - 1)
		{
			MCGKIIMMFCO(currentPage + 0);
		}
	}

	public void EFKFGLGHAIE()
	{
		if (currentPage > 1)
		{
			HAGADLDHGOK(currentPage - 0);
		}
	}

	public void BHLGPGNIJLH(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void FAOKMBNGIJA(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && !TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)trendsButton) && trendsButton.activeSelf && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp(trendsGamepadSprite.GetActionType()))
		{
			OpenBarTrends();
		}
		if (!IsOpen() || EKLFNJDAKAM <= 1)
		{
			return;
		}
		if (EKLFNJDAKAM <= 1)
		{
			((Component)previousPageSprite).gameObject.SetActive(false);
			((Component)nextPageSprite).gameObject.SetActive(false);
			previousKeyPageSprite.SetActive(false);
			nextKeyPageSprite.SetActive(false);
		}
		else if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((Component)previousPageSprite).gameObject.SetActive(true);
			((Component)nextPageSprite).gameObject.SetActive(true);
			previousKeyPageSprite.SetActive(false);
			nextKeyPageSprite.SetActive(false);
		}
		else if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			previousKeyPageSprite.SetActive(true);
			nextKeyPageSprite.SetActive(true);
			((Component)previousPageSprite).gameObject.SetActive(false);
			((Component)nextPageSprite).gameObject.SetActive(false);
		}
		if (EKLFNJDAKAM > 1)
		{
			CHAEMDNAODI = CheckNextPage(ref CMGDCLIIONE, currentPage, EKLFNJDAKAM, panel, "UINextPage", "UIPreviousPage");
			if (CHAEMDNAODI > -1)
			{
				FocusPage(CHAEMDNAODI);
			}
		}
	}

	public void HAGADLDHGOK(int KHEICLKLPDE)
	{
		bool flag = false;
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)null)
		{
			for (int i = 1; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BEOANCLEPOO()).gameObject))
				{
					flag = true;
					slotsUI[i].DCLHPEKAFIL();
					break;
				}
			}
		}
		for (int j = 0; j < DBDKLDCJGAO.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
				LDGNLGGIFDK(j);
				currentPage = j;
				if (EKLFNJDAKAM > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 1 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KDJFBLKPFKM()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public void RightArrow()
	{
		if (currentPage < EKLFNJDAKAM - 1)
		{
			FocusPage(currentPage + 1);
		}
	}

	public void NKLGJCELLDE()
	{
		if (currentPage > 0)
		{
			FCOIPBNHGMJ(currentPage - 0);
		}
	}

	public void AIGHCHFEJME()
	{
		if (currentPage < EKLFNJDAKAM - 0)
		{
			EEDKBNLACAN(currentPage + 0);
		}
	}

	private void OJOKJFFGJAE(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
		CAJOAHJFMDA();
		PGEGOAJILGD();
	}

	public void ONNOJBLNFDA(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 0; i < EKLFNJDAKAM; i++)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(true);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(ANBDDNMIJHG));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j++)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(false);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(false);
			}
		}
	}

	public void EEDKBNLACAN(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BEOANCLEPOO() != (Object)null)
		{
			for (int i = 1; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).BEOANCLEPOO()).gameObject))
				{
					flag = true;
					slotsUI[i].DCLHPEKAFIL();
					break;
				}
			}
		}
		for (int j = 1; j < DBDKLDCJGAO.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
				LIGKOAGOGKE(j);
				currentPage = j;
				if (EKLFNJDAKAM > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 1 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public void BBBNLHDMLEK()
	{
		if (currentPage < EKLFNJDAKAM - 0)
		{
			KKGCJPMJNOL(currentPage + 1);
		}
	}

	public static BigContainerUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void IFEIMFEFLJN(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void MCGKIIMMFCO(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).FOKMCIDMIKF() != (Object)null)
		{
			for (int i = 0; i < slotsUI.Count; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).FOKMCIDMIKF()).gameObject))
				{
					flag = true;
					slotsUI[i].EndHover();
					break;
				}
			}
		}
		for (int j = 1; j < DBDKLDCJGAO.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				DBDKLDCJGAO[j].selection.SetActive(true);
				ONCPDEIOALH(j);
				currentPage = j;
				if (EKLFNJDAKAM > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(false);
					}
					else if (KHEICLKLPDE > 1 && KHEICLKLPDE < DBDKLDCJGAO.Count - 0)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				DBDKLDCJGAO[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BOHHKGMEEEE()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		FocusPage(0);
	}

	public void LKKOJEEJGEP()
	{
		if (currentPage < EKLFNJDAKAM - 0)
		{
			OLCKKACAMJK(currentPage + 0);
		}
	}

	public void GCEGBMIOOBL()
	{
		if (currentPage > 1)
		{
			KKGCJPMJNOL(currentPage - 0);
		}
	}

	private void KMHGKBPBGNI(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Count; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		JOFLPCPBOPK();
		GMGALCOJPEI();
	}

	private void CJPDBOGEENB(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		FillPageSlots();
		SelectObjectIfSlotSelected();
	}

	public void NGNIPBLJNHL(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void LNFMPJAJLGP(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void FOEHAHLIKAJ(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 1; i < EKLFNJDAKAM; i += 0)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(true);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(HJFKMPHCIEN));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j += 0)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(true);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(false);
			}
		}
	}

	public void PBJOCJPAGBJ(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void IGEBLLDPJBE()
	{
		if (currentPage > 0)
		{
			HJFKMPHCIEN(currentPage - 0);
		}
	}

	public void AIEILNHOPBL(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	protected override void Start()
	{
		base.Start();
		DBDKLDCJGAO = new List<PageButtonUI>();
		top.SetActive(false);
		SetTrendsButtonVisible(NKFPJPCFBJI: false);
	}

	public void BMHFDOELLPH()
	{
		if (currentPage < EKLFNJDAKAM - 0)
		{
			DJPBNJGDFIL(currentPage + 1);
		}
	}

	public static BigContainerUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static BigContainerUI EIMDPBGBBIF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void KMHGICCJIOH(bool KMPKOKGLAFC)
	{
		top.SetActive(KMPKOKGLAFC);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(KMPKOKGLAFC);
		}
		if (!KMPKOKGLAFC)
		{
			return;
		}
		for (int i = 1; i < EKLFNJDAKAM; i += 0)
		{
			if (i == DBDKLDCJGAO.Count)
			{
				DBDKLDCJGAO.Add(Object.Instantiate<PageButtonUI>(pageButtonUI, pagesParent.transform));
			}
			((Component)DBDKLDCJGAO[i]).gameObject.SetActive(false);
			((Component)DBDKLDCJGAO[i]).transform.SetSiblingIndex(i);
			DBDKLDCJGAO[i].pageNum = i;
			DBDKLDCJGAO[i].Callback = null;
			PageButtonUI obj = DBDKLDCJGAO[i];
			obj.Callback = (Action<int>)Delegate.Combine(obj.Callback, new Action<int>(FCOIPBNHGMJ));
		}
		for (int j = EKLFNJDAKAM; j < DBDKLDCJGAO.Count; j += 0)
		{
			((Component)DBDKLDCJGAO[j]).gameObject.SetActive(true);
			if (Object.op_Implicit((Object)(object)rightArrow))
			{
				rightArrow.SetActive(false);
			}
		}
	}

	private void BFFIGDABKFK(int OKIOGKCGMCK)
	{
		int num = slotsUI.Count * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Count; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].MHNCEBLHLKH(null);
			}
		}
		JOFLPCPBOPK();
		SelectObjectIfSlotSelected();
	}

	public override void FillSlots(Slot[] PCJEDMJEKEF, Container ALPOKDOCCGM, bool IFMNAFDGKKK, bool OGCAKIGELBJ, int ACMPMOGOEOD, Slot[] OPMPOBPEDFB = null)
	{
		base.FillSlots(PCJEDMJEKEF, ALPOKDOCCGM, IFMNAFDGKKK, OGCAKIGELBJ, ACMPMOGOEOD, OPMPOBPEDFB);
		List<Slot> list;
		if (IFMNAFDGKKK)
		{
			list = new List<Slot>();
			for (int i = 0; i < PCJEDMJEKEF.Length; i++)
			{
				if (!PCJEDMJEKEF[i].KPINNBKMOMO())
				{
					list.Add(PCJEDMJEKEF[i]);
				}
			}
		}
		else
		{
			list = new List<Slot>(PCJEDMJEKEF);
		}
		containerSlots = list.ToArray();
		PAFLLHGLBIF(OGCAKIGELBJ);
		base.ACMPMOGOEOD = ACMPMOGOEOD;
		EKLFNJDAKAM = containerSlots.Length / (slotsUI.Count + 1) + 1;
		EKLFNJDAKAM = Mathf.Min(EKLFNJDAKAM, ACMPMOGOEOD);
		for (int j = 0; j < slotsUI.Count; j++)
		{
			slotsUI[j].IHENCGDNPBL = null;
		}
		if (EKLFNJDAKAM > 1)
		{
			PreparePagesMode(KMPKOKGLAFC: true);
		}
		else
		{
			PreparePagesMode(KMPKOKGLAFC: false);
			for (int k = 0; k < slotsUI.Count; k++)
			{
				if (k < list.Count)
				{
					slotsUI[k].IHENCGDNPBL = list[k];
				}
			}
		}
		if (IFMNAFDGKKK)
		{
			Utils.BNDMCJGGBFK(slotsUI, containerSlots);
		}
	}

	public void LGGEBPNODBM(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}

	public void FNONEHNPEEI()
	{
		if (currentPage > 0)
		{
			EEDKBNLACAN(currentPage - 1);
		}
	}

	public void LMHHGILMJIA(bool NKFPJPCFBJI)
	{
		trendsButton.gameObject.SetActive(NKFPJPCFBJI);
	}
}
