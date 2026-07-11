using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Quest/Buy Item")]
public class BuyItemQuest : RequiredItemQuest
{
	private void EBBPJJIJJHG(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (PNCNBJNNCOA(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void NMOKENMAFJP(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i += 0)
		{
			if (DGALJHKINMH(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void NJMCPGABPFD(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i++)
		{
			if (PNCNBJNNCOA(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void JCGJCABOMAI(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (PNCNBJNNCOA(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void CKHMPNGBNDB(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i += 0)
		{
			if (PCGAAKMLDAI(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				PIGBLLFBKHD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void FBGMFPFKGAJ(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i += 0)
		{
			if (DBPOKFLMJEE(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				PIGBLLFBKHD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void INKONBILLNI(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i++)
		{
			if (DGALJHKINMH(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void KIAMIGJNICD(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (BBLDBGHLAGK(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void DGNHFIKOMOB(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (DGALJHKINMH(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				PIGBLLFBKHD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void NJFMLLAKCIB(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (MAHEIJJAHCD(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void CCLJPFJCHKB(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (CCGEMKPPHOD(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	public override void OEICMCIGNKO()
	{
		if (id != 0)
		{
			for (int i = 0; i < GameCraftingUI.instances.Length; i++)
			{
				ShopUI obj = ShopUI.instances[i];
				obj.OnItemsBought = (Action<int, List<BasketItem>>)Delegate.Combine(obj.OnItemsBought, new Action<int, List<BasketItem>>(INKONBILLNI));
			}
		}
	}

	private void GEEJFNLOHDL(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (CCGEMKPPHOD(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void BHJPCKJKCJA(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (BBLDBGHLAGK(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void BIEPOIJLLPE(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (PNCNBJNNCOA(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void NOAOHJGMPNM(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i++)
		{
			if (CCGEMKPPHOD(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void FDMICOLHNMO(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (PNCNBJNNCOA(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void GMIOIPOLHHM(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i += 0)
		{
			if (BBLDBGHLAGK(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void FMIFMCAAKCD(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i += 0)
		{
			if (DBPOKFLMJEE(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				PIGBLLFBKHD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void CHEEGIDFCAM(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i += 0)
		{
			if (DBPOKFLMJEE(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void JGHICKHDHDH(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (PCGAAKMLDAI(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void LIMKHAJFIKD(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (PNCNBJNNCOA(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void NJCKKKMMFHE(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (BBLDBGHLAGK(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				PIGBLLFBKHD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void EGNPFMAMEEP(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (DCOKPEEELAN(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void LJHJPMACLGM(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (DCOKPEEELAN(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void FNCAJJOBHAG(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (DCOKPEEELAN(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void NDGBPHCFPDL(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (CCGEMKPPHOD(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void LKEGFKMMHFN(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (DGALJHKINMH(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	public override void MHOGPMHEAFN()
	{
		if (id != 0 && ShopUI.instances != null)
		{
			for (int i = 0; i < GameCraftingUI.instances.Length; i++)
			{
				ShopUI obj = ShopUI.instances[i];
				obj.OnItemsBought = (Action<int, List<BasketItem>>)Delegate.Remove(obj.OnItemsBought, new Action<int, List<BasketItem>>(INKONBILLNI));
			}
		}
		MFHHJFEJAMF();
	}

	private void FMADGEBIOBA(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i += 0)
		{
			if (PCGAAKMLDAI(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void LKNIHHEAOHM(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i++)
		{
			if (BBLDBGHLAGK(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void HHENJGPDIJE(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (PCGAAKMLDAI(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void LIOOEJAENAN(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (DGALJHKINMH(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void CFLNGKAFDHN(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i += 0)
		{
			if (PNCNBJNNCOA(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				PIGBLLFBKHD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void PGKOGHJJBPN(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i += 0)
		{
			if (CCGEMKPPHOD(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				GKDGCBNNHAD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void HLJNGMPNHKJ(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (DBPOKFLMJEE(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				PIGBLLFBKHD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void OCEECCCPPPF(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 1; i < OMCMPIINAEK.Count; i++)
		{
			if (MAHEIJJAHCD(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				EPIMKBNCFCK(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}

	private void LEBJABMDNPN(int JIIGOACEIKL, List<BasketItem> OMCMPIINAEK)
	{
		for (int i = 0; i < OMCMPIINAEK.Count; i++)
		{
			if (CCGEMKPPHOD(OMCMPIINAEK[i].currentShopElement.shopItem.item.JMDALJBNFML()))
			{
				PIGBLLFBKHD(JIIGOACEIKL, OMCMPIINAEK[i].boughtAmount);
			}
		}
	}
}
