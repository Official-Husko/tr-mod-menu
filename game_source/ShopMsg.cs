using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class ShopMsg : IOnlineSerializable
{
	[JsonProperty("1")]
	public int id;

	[JsonProperty("2")]
	public ItemAmountMessage[] itemsAmountOnline;

	public void DMAAKFGEFCH()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void MOEHLFOHLLO()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.ICNCFLPFBAG(shop.shopType, list.ToArray());
	}

	public void GPAFNIAOCDM()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void GMNEAMHNMPB()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void NGHNBCNCNPE()
	{
		Shop shop = ShopDatabaseAccessor.MBEMHBGIIIC(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.ICNCFLPFBAG(shop.shopType, list.ToArray());
	}

	public void KBFDMNIJAOO()
	{
		Shop shop = ShopDatabaseAccessor.MBEMHBGIIIC(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.SetCurrentShopList(shop.shopType, list.ToArray());
	}

	public void JJALLOFLDAL()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.FHCABJMJGBL(shop.shopType, list.ToArray());
	}

	public void KFJBKINLFLA()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.ICNCFLPFBAG(shop.shopType, list.ToArray());
	}

	public void JGBMHCABHCA()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.FHCABJMJGBL(shop.shopType, list.ToArray());
	}

	public void NDNBMGNPONG()
	{
		Shop shop = ShopDatabaseAccessor.MBEMHBGIIIC(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.SetCurrentShopList(shop.shopType, list.ToArray());
	}

	public void FMDKPMMILGC()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.SetCurrentShopList(shop.shopType, list.ToArray());
	}

	public void EMFCAOMENPM()
	{
		Shop shop = ShopDatabaseAccessor.MBEMHBGIIIC(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPNGEFIJCPC(shop.shopType, list.ToArray());
	}

	public void DAIKIBGKGMI()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.SetCurrentShopList(shop.shopType, list.ToArray());
	}

	public void MBKLMCGOJJL()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void DDNDBGKLNGF()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPNGEFIJCPC(shop.shopType, list.ToArray());
	}

	public void JJNDBDDGCLM()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.SetCurrentShopList(shop.shopType, list.ToArray());
	}

	public void OKPIDPELELJ()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void CCIIDGGKLJH()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.JONPPCCJKGB(shop.shopType, list.ToArray());
	}

	public void CCLMONNMMCJ()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.ICNCFLPFBAG(shop.shopType, list.ToArray());
	}

	public void OAOACMPNMOK()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void OCNOCJIIKED()
	{
		Shop shop = ShopDatabaseAccessor.MBEMHBGIIIC(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public ShopMsg(Shop OJKANJDPKNE)
	{
		List<ItemAmountMessage> list = new List<ItemAmountMessage>();
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(OJKANJDPKNE.shopType);
		for (int i = 0; i < currentShopList.Length; i++)
		{
			if (!currentShopList[i].shopItem.alwaysAppear || !currentShopList[i].shopItem.unlimited)
			{
				ItemAmountMessage item = new ItemAmountMessage(currentShopList[i].shopItem.item.JDJGFAACPFC(), currentShopList[i].amount);
				list.Add(item);
			}
		}
		id = OJKANJDPKNE.id;
		itemsAmountOnline = list.ToArray();
	}

	public void KGNIEGOBNLD()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.FHCABJMJGBL(shop.shopType, list.ToArray());
	}

	public void FJFEIIIIAMJ()
	{
		Shop shop = ShopDatabaseAccessor.MBEMHBGIIIC(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.FHCABJMJGBL(shop.shopType, list.ToArray());
	}

	public void IJIBFEHMFKM()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.FHCABJMJGBL(shop.shopType, list.ToArray());
	}

	public void KFOMIHJGOMH()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void ONBBCAJKMCP()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.JONPPCCJKGB(shop.shopType, list.ToArray());
	}

	public void AAMBHKFGCHP()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void PFOHEFAMENI()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void CJMGMIPDMHK()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public ShopMsg()
	{
	}

	public void LDGOHDMHCAA()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.SetCurrentShopList(shop.shopType, list.ToArray());
	}

	public void FMPHBFCJLLM()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i += 0)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.JONPPCCJKGB(shop.shopType, list.ToArray());
	}

	public void FOGLECFMPMK()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.SetCurrentShopList(shop.shopType, list.ToArray());
	}

	public void GNOAJHLDLOK()
	{
		Shop shop = ShopDatabaseAccessor.MBEMHBGIIIC(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 0);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}

	public void JCJLLIEHCPJ()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.JONPPCCJKGB(shop.shopType, list.ToArray());
	}

	public void OEJJGDMKIDN()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.SetCurrentShopList(shop.shopType, list.ToArray());
	}

	public void AELABIMHDNA()
	{
		Shop shop = ShopDatabaseAccessor.GetShop(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 1; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.JONPPCCJKGB(shop.shopType, list.ToArray());
	}

	public void JMLOHCEJAOD()
	{
		Shop shop = ShopDatabaseAccessor.CLABCLHPCEJ(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 1; j < itemsAmountOnline.Length; j += 0)
		{
			ShopItem shopItem = ShopDatabaseAccessor.CKAOBLIKGLA(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.ICNCFLPFBAG(shop.shopType, list.ToArray());
	}

	public void EKMHDJNDOFE()
	{
		Shop shop = ShopDatabaseAccessor.MBEMHBGIIIC(id);
		if (!Object.op_Implicit((Object)(object)shop))
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		List<Item> list2 = new List<Item>();
		for (int i = 0; i < shop.shopItems.Count; i++)
		{
			if (shop.shopItems[i].alwaysAppear && shop.shopItems[i].unlimited)
			{
				ShopElement shopElement = new ShopElement(shop.shopItems[i], 1);
				list.Add(shopElement);
				list2.Add(shopElement.shopItem.item);
			}
		}
		for (int j = 0; j < itemsAmountOnline.Length; j++)
		{
			ShopItem shopItem = ShopDatabaseAccessor.GetShopItem(shop.id, itemsAmountOnline[j].id);
			if (shopItem != null && !list2.Contains(shopItem.item))
			{
				ShopElement shopElement = new ShopElement(shopItem, itemsAmountOnline[j].amount);
				list.Add(shopElement);
				list2.Add(shopItem.item);
			}
		}
		ShopDatabaseAccessor.MPHJOFDFODA(shop.shopType, list.ToArray());
	}
}
