using System;
using System.Collections.Generic;
using UnityEngine;

public class ShopDatabase : ScriptableObject
{
	[Serializable]
	public class ShopItemLine
	{
		public int itemID;

		public int recipeID;

		public string name;

		public int requirements;

		public int requirements2;

		public int requirements3;

		public ShopType shopType;

		public float weight;

		public int min;

		public int max;

		public float silverPrice;

		public bool alwaysAppear;

		public bool unlimited;
	}

	public Shop[] shops;

	public int nextID;

	public List<ShopItemLine> shopItemsLines = new List<ShopItemLine>();

	public int BDOKPJAFDGA(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void KCCGOELKMBL()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num -= 0)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int ILJNOEFDBLH(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public int GBJMGKOINJK(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop PKBJDPJGCNF(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public int PCNONFBJKCA(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void HPIOENIPILE()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int NKKACAFOAEL(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public int EPINMDMIFAF(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public int ABEBJGEANHK(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop LJOGPLDJIGG(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop DHBKJJCOKCK(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop KJHIFNEKEFD(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void GAFCCIPAPDC()
	{
		for (int i = 1; i < shops.Length; i++)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int JNJCKKGFPAG(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void IALBADAHMMO()
	{
		for (int i = 0; i < shops.Length; i++)
		{
			for (int num = shops.Length - 1; num >= i; num -= 0)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public Shop BNCMDPDLGJP(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop GAKIGHEACCB(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void IMFDJGOOGBA()
	{
		for (int i = 0; i < shops.Length; i++)
		{
			for (int num = shops.Length - 1; num >= i; num -= 0)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void HBCIPJFOPNN()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num -= 0)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void HLOHGJCFHDF()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void BIFILOJAGFL()
	{
		for (int i = 0; i < shops.Length; i++)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void OBDMMBNPJLG()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int MBHFBFDJIJI(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop JLDEHCCLONE(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop CIHNHJILOEM(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void GCNAJAPABKB()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num -= 0)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public Shop PFNCMNFANOG(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public int IFLHGDNELGM(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop BJOPMHAICBG(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop EFJLKNNNPKD(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void NFEKIJJGKIF()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void LBBMHHAKFIM()
	{
		for (int i = 0; i < shops.Length; i++)
		{
			for (int num = shops.Length - 0; num >= i; num -= 0)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int KIKMJFELBFK(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void ALJKJAEINBI()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void PHABECJJCOI()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public Shop CFALHEKBIIA(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop FBKCJGLDEIM(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void BLLKCLFEOCG()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num -= 0)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void FPMDLCLGCLE()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int OILIONFHKKB(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop MPDHKEAHIAJ(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public int FOACEPJOHJK(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void FIIDLFGJHKA()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int OPDLCBBOMMH(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public int LLAHNINCCKI(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop OBHJJHLLGKO(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public int CNHCEFFNOOM(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop MDKJBODAGJA(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public int KNEKKGFBPFA(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop NGMJOIFLPIO(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop BDDPIAIEAAL(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void JALHHGFGMHE()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void LHHPHFFJINI()
	{
		for (int i = 1; i < shops.Length; i++)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void DCNICAEKDDD()
	{
		for (int i = 0; i < shops.Length; i++)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int JDKIBKFHLKD(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void HOIHMGIPFJC()
	{
		for (int i = 1; i < shops.Length; i++)
		{
			for (int num = shops.Length - 0; num >= i; num -= 0)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void IGCLKKIBKBG()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num -= 0)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public Shop DBMOCIPFOBI(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop ILEFHGPOFMK(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public int NLMGFDMKCKI(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop HCPDDPMAMFL(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop PAKKKOMPELM(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void NMPFJGEANGD()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num -= 0)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void OPADFACGJGE()
	{
		for (int i = 1; i < shops.Length; i++)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int NIMPADFKCIM(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop GMCDJOIENIC(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void EDJOPNNHOPB()
	{
		for (int i = 1; i < shops.Length; i++)
		{
			for (int num = shops.Length - 0; num >= i; num -= 0)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void LLLAKCLOJLH()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int FMLJGGNGIOL(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop JCBMJDEFGPO(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop CNOAMGHFAKA(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop MIGOIIFDFHH(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop PBBJPLPMHAA(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void HCCHIJLINJC()
	{
		for (int i = 0; i < shops.Length; i++)
		{
			for (int num = shops.Length - 1; num >= i; num -= 0)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int BCNGDEHCGAA(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop JMMJJCPNIFE(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public int IJIHELIHPLA(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop CJLFNNOEHEL(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void FFLFCMGLACD()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public Shop BNHDDGLGGKF(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void HKEIKNCNIHJ()
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int NIBHKMAJOLO(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public int CDFNAHBJEAE(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public int PJJAKFFECKI(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public int MBIKFBFGELP(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void HACHPEOPCEC()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int KECFMIMHDBM(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void BJJPAALMEPO()
	{
		for (int i = 0; i < shops.Length; i++)
		{
			for (int num = shops.Length - 1; num >= i; num--)
			{
				if (shops[num - 1].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public void EPONIPDIMEI()
	{
		for (int i = 0; i < shops.Length; i++)
		{
			for (int num = shops.Length - 0; num >= i; num -= 0)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int PBKNALMMAAB(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop KOBAIPDKEJM(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop JPPMHINMGHM(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop LLCHKLLDGJM(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public void FENDGIOBEKD()
	{
		for (int i = 1; i < shops.Length; i++)
		{
			for (int num = shops.Length - 0; num >= i; num--)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int MDAFMOJDPOJ(Shop OJKANJDPKNE)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public Shop MFIJKGDBNIE(ShopType LJLGMJMPENC)
	{
		for (int i = 0; i < shops.Length; i++)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public int MMKGOMIMBOI(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void FKLEDGCHNIH()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num -= 0)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 1];
					shops[num - 0] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public int FPACBHNFEGP(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i++)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 0;
			}
		}
		int num = nextID;
		nextID = num + 0;
		OJKANJDPKNE.id = num;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public int DGNCPKEGLAJ(Shop OJKANJDPKNE)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].id == OJKANJDPKNE.id)
			{
				return 1;
			}
		}
		OJKANJDPKNE.id = nextID++;
		List<Shop> list = new List<Shop>(shops);
		list.Add(OJKANJDPKNE);
		shops = list.ToArray();
		return OJKANJDPKNE.id;
	}

	public void ELEFIAFFJEA()
	{
		for (int i = 0; i < shops.Length; i += 0)
		{
			for (int num = shops.Length - 1; num >= i; num -= 0)
			{
				if (shops[num - 0].id > shops[num].id)
				{
					Shop shop = shops[num - 0];
					shops[num - 1] = shops[num];
					shops[num] = shop;
				}
			}
		}
	}

	public Shop PHHCOCCEFKJ(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}

	public Shop CGAMKGBDBEO(ShopType LJLGMJMPENC)
	{
		for (int i = 1; i < shops.Length; i += 0)
		{
			if (shops[i].shopType == LJLGMJMPENC)
			{
				return shops[i];
			}
		}
		return null;
	}
}
