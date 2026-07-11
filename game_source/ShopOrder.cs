using System;
using System.Collections.Generic;

[Serializable]
public struct ShopOrder
{
	public int playerNum;

	public List<ItemInstanceAmount> items;

	public int deliveryHour;

	public Shop shop;

	public ShopOrder(int GELMAIBEHDO, List<ItemInstanceAmount> IOKCMFLOOIJ, int BOCEPCMKGCN, Shop AJNNMGKJPAK)
	{
		playerNum = GELMAIBEHDO;
		items = IOKCMFLOOIJ;
		deliveryHour = BOCEPCMKGCN;
		shop = AJNNMGKJPAK;
	}
}
