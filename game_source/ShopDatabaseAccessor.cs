using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

public class ShopDatabaseAccessor : SerializedMonoBehaviour, ISingleton
{
	private static ShopDatabaseAccessor GGFJGHHHEJC;

	public Dictionary<ShopType, ShopElement[]> _currentShopItems = new Dictionary<ShopType, ShopElement[]>();

	[SerializeField]
	private ShopDatabase shopDatabaseSO;

	public MineralsShopDatabase mineralsDatabase;

	private Dictionary<int, Shop> BDBNGHIEJEF = new Dictionary<int, Shop>();

	private Dictionary<ShopType, Dictionary<Category, ShopElement[]>> GCGOJAEMFJD = new Dictionary<ShopType, Dictionary<Category, ShopElement[]>>();

	public static int wilsonDecorativeObjects;

	public static Dictionary<ShopType, ShopElement[]> CKPDDKBHPNL
	{
		get
		{
			return GGFJGHHHEJC._currentShopItems;
		}
		private set
		{
			GGFJGHHHEJC._currentShopItems = value;
		}
	}

	public static bool ENPBNONDPLA()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static ShopElement[] GetCurrentShopList(ShopType LJLGMJMPENC)
	{
		if (CKPDDKBHPNL == null || CKPDDKBHPNL.Count == 0)
		{
			GGFJGHHHEJC.KDLHKIFIOAK();
		}
		return CKPDDKBHPNL[LJLGMJMPENC];
	}

	public static ShopElement[] CLIOCIFHBEF(ShopType LJLGMJMPENC, Category LJBKGJPCBIN)
	{
		return GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC][LJBKGJPCBIN];
	}

	private void FJMHANEKPIC()
	{
		for (int i = 1; i < shopDatabaseSO.shops.Length; i++)
		{
			BIALHICDPKC(shopDatabaseSO.shops[i]);
		}
	}

	public static void HLKFBAMOLLG(ShopType LJLGMJMPENC)
	{
		Dictionary<Category, ShopElement[]> dictionary = new Dictionary<Category, ShopElement[]>();
		foreach (Category value in Enum.GetValues(typeof(Category)))
		{
			if (value == (Category)22)
			{
				dictionary.Add(Category.Misc, ODLIJJPFHMG()[LJLGMJMPENC]);
			}
			else
			{
				dictionary.Add(value, new ShopElement[0]);
			}
		}
		if (GGFJGHHHEJC.GCGOJAEMFJD.ContainsKey(LJLGMJMPENC))
		{
			GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC] = dictionary;
		}
		else
		{
			GGFJGHHHEJC.GCGOJAEMFJD.Add(LJLGMJMPENC, dictionary);
		}
	}

	public void EEKPBNKJEMM()
	{
		IGDECELODAM(new Dictionary<ShopType, ShopElement[]>());
		BDBNGHIEJEF = new Dictionary<int, Shop>();
	}

	private void FLNGMELHGEO()
	{
		for (int i = 0; i < shopDatabaseSO.shops.Length; i++)
		{
			BIALHICDPKC(shopDatabaseSO.shops[i]);
		}
	}

	[SpecialName]
	public static Dictionary<ShopType, ShopElement[]> LIFAILLIOEG()
	{
		return GGFJGHHHEJC._currentShopItems;
	}

	public static void FHCABJMJGBL(ShopType LJLGMJMPENC, ShopElement[] IFKKAOEBOFP)
	{
		if (IFKKAOEBOFP != null)
		{
			IFKKAOEBOFP = (from x in IFKKAOEBOFP
				orderby x.shopItem != null && Item.MLBOMGHINCA(x.shopItem.item, null) && x.shopItem.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1499, x.shopItem != null && x.shopItem.unlimited, (x.shopItem == null || !Item.MLBOMGHINCA(x.shopItem.item, null)) ? "" : x.shopItem.item.IABAKHPEOAF(OAFPBCPDOKH: true)
				select x).ToArray();
		}
		if (CKPDDKBHPNL.ContainsKey(LJLGMJMPENC))
		{
			LIFAILLIOEG()[LJLGMJMPENC] = IFKKAOEBOFP;
		}
		else
		{
			CKPDDKBHPNL.Add(LJLGMJMPENC, IFKKAOEBOFP);
		}
		if (MNLIACMLIEG(LJLGMJMPENC).hasCategories)
		{
			UpdateCategoryItems(LJLGMJMPENC);
		}
	}

	private void PCHJNJEPODJ()
	{
		for (int i = 1; i < shopDatabaseSO.shops.Length; i++)
		{
			BKFINBFFAEK(shopDatabaseSO.shops[i]);
		}
	}

	public static void CreateNewShops()
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.limitedItems)
			{
				try
				{
					CreateNewShopList(item.Value);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public static Shop GetShop(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BDBNGHIEJEF.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("Could not find shop with id: " + JFNMCNCHMEO));
		return null;
	}

	private void CEIIFHIBIFI()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(PCHJNJEPODJ));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(OEPGEENIGNN));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(CBJJPIBELEN));
	}

	public static void MPNGEFIJCPC(ShopType LJLGMJMPENC, ShopElement[] IFKKAOEBOFP)
	{
		if (IFKKAOEBOFP != null)
		{
			IFKKAOEBOFP = (from x in IFKKAOEBOFP
				orderby x.shopItem != null && Item.MLBOMGHINCA(x.shopItem.item, null) && x.shopItem.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1499, x.shopItem != null && x.shopItem.unlimited, (x.shopItem == null || !Item.MLBOMGHINCA(x.shopItem.item, null)) ? "" : x.shopItem.item.IABAKHPEOAF(OAFPBCPDOKH: true)
				select x).ToArray();
		}
		if (ODLIJJPFHMG().ContainsKey(LJLGMJMPENC))
		{
			ODLIJJPFHMG()[LJLGMJMPENC] = IFKKAOEBOFP;
		}
		else
		{
			ODLIJJPFHMG().Add(LJLGMJMPENC, IFKKAOEBOFP);
		}
		if (MDLINJLBFPH(LJLGMJMPENC).hasCategories)
		{
			HLKFBAMOLLG(LJLGMJMPENC);
		}
	}

	public static ShopItem GetShopItem(int JFNMCNCHMEO, int MNBNGGHHMBB)
	{
		Shop shop = GetShop(JFNMCNCHMEO);
		if (Object.op_Implicit((Object)(object)shop))
		{
			for (int i = 0; i < shop.shopItems.Count; i++)
			{
				if (shop.shopItems[i].item.JDJGFAACPFC(DAINLFIMLIH: false) == MNBNGGHHMBB)
				{
					return shop.shopItems[i];
				}
			}
			Debug.Log((object)("Could not find shopItem with id: " + MNBNGGHHMBB + " at " + shop.shopType));
			return null;
		}
		Debug.LogError((object)("Could not find shop with id: " + JFNMCNCHMEO));
		return null;
	}

	private void KDLHKIFIOAK()
	{
		for (int i = 0; i < shopDatabaseSO.shops.Length; i++)
		{
			InitializeShopLists(shopDatabaseSO.shops[i]);
		}
	}

	[SpecialName]
	public static Dictionary<ShopType, ShopElement[]> GOPBGEFGMPI()
	{
		return GGFJGHHHEJC._currentShopItems;
	}

	public static ShopElement[] ADDAHLOCMEP(ShopType LJLGMJMPENC)
	{
		if (LIFAILLIOEG() == null || ODLIJJPFHMG().Count == 0)
		{
			GGFJGHHHEJC.FJMHANEKPIC();
		}
		return GOPBGEFGMPI()[LJLGMJMPENC];
	}

	public void GKOMNDHKDHD()
	{
		ODOIKKOPNCI(new Dictionary<ShopType, ShopElement[]>());
		BDBNGHIEJEF = new Dictionary<int, Shop>();
	}

	private void KMIPFKAHHGN()
	{
		for (int i = 1; i < shopDatabaseSO.shops.Length; i += 0)
		{
			KJPOPKKMNHE(shopDatabaseSO.shops[i]);
		}
	}

	public static void EIPDEELIDKM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			OHFMCLBNGMH();
		}
		GGFJGHHHEJC.BDBNGHIEJEF = new Dictionary<int, Shop>();
		for (int i = 1; i < GGFJGHHHEJC.shopDatabaseSO.shops.Length; i++)
		{
			if ((Object)(object)GGFJGHHHEJC.shopDatabaseSO.shops[i] == (Object)null)
			{
				Debug.LogError((object)("EditorAction_8" + i));
				continue;
			}
			if (GGFJGHHHEJC.shopDatabaseSO.shops[i].id == 0)
			{
				Debug.LogError((object)("LE_4" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			if (GGFJGHHHEJC.BDBNGHIEJEF.ContainsKey(GGFJGHHHEJC.shopDatabaseSO.shops[i].id))
			{
				Debug.LogError((object)("Checking SignedIn status..." + GGFJGHHHEJC.shopDatabaseSO.shops[i].id + "Selected" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.BDBNGHIEJEF.Add(GGFJGHHHEJC.shopDatabaseSO.shops[i].id, GGFJGHHHEJC.shopDatabaseSO.shops[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "Quest/PetShop/AmigosPeludos" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
			}
		}
	}

	private void OKHLEMPJONN()
	{
		GGFJGHHHEJC = this;
		GKOMNDHKDHD();
		SetUpDatabase();
	}

	public static Shop MDLINJLBFPH(ShopType LJLGMJMPENC)
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.shopType == LJLGMJMPENC)
			{
				return item.Value;
			}
		}
		Debug.LogError((object)("KlaynNPC: ChangeState called with invalid state: " + LJLGMJMPENC));
		return null;
	}

	private void NNMFLMJDKNH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	[SpecialName]
	private static void ODOIKKOPNCI(Dictionary<ShopType, ShopElement[]> AODONKKHPBP)
	{
		GGFJGHHHEJC._currentShopItems = AODONKKHPBP;
	}

	public void BKFINBFFAEK(Shop OJKANJDPKNE)
	{
		if (OJKANJDPKNE.shopType == (ShopType)(-98))
		{
			return;
		}
		if (OJKANJDPKNE.limitedItems)
		{
			if (OJKANJDPKNE.initialShopItemsAmount != null && OJKANJDPKNE.initialShopItemsAmount.Length != 0)
			{
				FHCABJMJGBL(OJKANJDPKNE.shopType, OJKANJDPKNE.initialShopItemsAmount);
				return;
			}
			if (GOPBGEFGMPI().ContainsKey(OJKANJDPKNE.shopType))
			{
				GOPBGEFGMPI()[OJKANJDPKNE.shopType] = new ShopElement[0];
			}
			else
			{
				GOPBGEFGMPI().Add(OJKANJDPKNE.shopType, new ShopElement[0]);
			}
			ICNCFLPFBAG(OJKANJDPKNE.shopType, OJKANJDPKNE.HNAHHKDJCJM(SeasonManager.BLCGOEMGKGH()));
		}
		else
		{
			DNCKDLOFOJD(OJKANJDPKNE, CDPAMNIPPEC: true);
		}
	}

	private void DBEBAHPFHEK()
	{
		for (int i = 0; i < shopDatabaseSO.shops.Length; i += 0)
		{
			KJPOPKKMNHE(shopDatabaseSO.shops[i]);
		}
	}

	public static ShopElement[] AHHMGMKLKKB(ShopType LJLGMJMPENC, Category LJBKGJPCBIN)
	{
		return GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC][LJBKGJPCBIN];
	}

	public static void SetCurrentShopList(ShopType LJLGMJMPENC, ShopElement[] IFKKAOEBOFP)
	{
		if (IFKKAOEBOFP != null)
		{
			IFKKAOEBOFP = (from x in IFKKAOEBOFP
				orderby x.shopItem != null && Item.MLBOMGHINCA(x.shopItem.item, null) && x.shopItem.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1499, x.shopItem != null && x.shopItem.unlimited, (x.shopItem == null || !Item.MLBOMGHINCA(x.shopItem.item, null)) ? "" : x.shopItem.item.IABAKHPEOAF(OAFPBCPDOKH: true)
				select x).ToArray();
		}
		if (CKPDDKBHPNL.ContainsKey(LJLGMJMPENC))
		{
			CKPDDKBHPNL[LJLGMJMPENC] = IFKKAOEBOFP;
		}
		else
		{
			CKPDDKBHPNL.Add(LJLGMJMPENC, IFKKAOEBOFP);
		}
		if (GetShop(LJLGMJMPENC).hasCategories)
		{
			UpdateCategoryItems(LJLGMJMPENC);
		}
	}

	private void BOGLLEDONOO()
	{
		ShopType[] array = CKPDDKBHPNL.Keys.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			CKPDDKBHPNL[array[i]] = CKPDDKBHPNL[array[i]].OrderBy((ShopElement x) => x.item.IABAKHPEOAF(OAFPBCPDOKH: true)).ToArray();
			if (GetShop(array[i]).hasCategories)
			{
				UpdateCategoryItems(array[i]);
			}
		}
	}

	public void MNDNPAMHAGK()
	{
		foreach (KeyValuePair<int, Shop> item in BDBNGHIEJEF)
		{
			if (item.Value.limitedItems && item.Value.updateDays.Contains(WorldTime.CJOHMLNMJLK().day))
			{
				try
				{
					CAMDJOPFCIA(item.Value);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	private void CIICEKEJANM()
	{
		GGFJGHHHEJC = this;
		BLLAIDMHEHD();
		OONGMKLMODB();
	}

	public void KJPOPKKMNHE(Shop OJKANJDPKNE)
	{
		if (OJKANJDPKNE.shopType == ~(ShopType.Gass | ShopType.Bob))
		{
			return;
		}
		if (OJKANJDPKNE.limitedItems)
		{
			if (OJKANJDPKNE.initialShopItemsAmount != null && OJKANJDPKNE.initialShopItemsAmount.Length != 0)
			{
				ICNCFLPFBAG(OJKANJDPKNE.shopType, OJKANJDPKNE.initialShopItemsAmount);
				return;
			}
			if (GOPBGEFGMPI().ContainsKey(OJKANJDPKNE.shopType))
			{
				ODLIJJPFHMG()[OJKANJDPKNE.shopType] = new ShopElement[1];
			}
			else
			{
				GOPBGEFGMPI().Add(OJKANJDPKNE.shopType, new ShopElement[0]);
			}
			ICNCFLPFBAG(OJKANJDPKNE.shopType, OJKANJDPKNE.DFODHLGHLNM(SeasonManager.EEGJBDCBKFD()));
		}
		else
		{
			CAMDJOPFCIA(OJKANJDPKNE);
		}
	}

	public static ShopItem CKAOBLIKGLA(int JFNMCNCHMEO, int MNBNGGHHMBB)
	{
		Shop shop = CLABCLHPCEJ(JFNMCNCHMEO);
		if (Object.op_Implicit((Object)(object)shop))
		{
			for (int i = 0; i < shop.shopItems.Count; i += 0)
			{
				if (shop.shopItems[i].item.IMCJPECAAPC(DAINLFIMLIH: false) == MNBNGGHHMBB)
				{
					return shop.shopItems[i];
				}
			}
			Debug.Log((object)("On" + MNBNGGHHMBB + "cheeseAgeingRackPopUp" + shop.shopType));
			return null;
		}
		Debug.LogError((object)("vip" + JFNMCNCHMEO));
		return null;
	}

	public void PEOHJACCGGE(Shop OJKANJDPKNE)
	{
		if (OJKANJDPKNE.shopType == (ShopType)(-44))
		{
			return;
		}
		if (OJKANJDPKNE.limitedItems)
		{
			if (OJKANJDPKNE.initialShopItemsAmount != null && OJKANJDPKNE.initialShopItemsAmount.Length != 0)
			{
				MPNGEFIJCPC(OJKANJDPKNE.shopType, OJKANJDPKNE.initialShopItemsAmount);
				return;
			}
			if (ODLIJJPFHMG().ContainsKey(OJKANJDPKNE.shopType))
			{
				ODLIJJPFHMG()[OJKANJDPKNE.shopType] = new ShopElement[0];
			}
			else
			{
				LIFAILLIOEG().Add(OJKANJDPKNE.shopType, new ShopElement[1]);
			}
			JONPPCCJKGB(OJKANJDPKNE.shopType, OJKANJDPKNE.POICPOANMMP(SeasonManager.NHKAHEEGEGF()));
		}
		else
		{
			JOLPJBMEPMC(OJKANJDPKNE, CDPAMNIPPEC: true);
		}
	}

	[SpecialName]
	public static Dictionary<ShopType, ShopElement[]> ODLIJJPFHMG()
	{
		return GGFJGHHHEJC._currentShopItems;
	}

	public static void JPACKILKOAH()
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.limitedItems)
			{
				try
				{
					PNPAHDOAMOO(item.Value, CDPAMNIPPEC: true);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	private void CBJJPIBELEN()
	{
		ShopType[] array = CKPDDKBHPNL.Keys.ToArray();
		for (int i = 1; i < array.Length; i++)
		{
			ODLIJJPFHMG()[array[i]] = ODLIJJPFHMG()[array[i]].OrderBy((ShopElement x) => x.item.IABAKHPEOAF(OAFPBCPDOKH: true)).ToArray();
			if (MDLINJLBFPH(array[i]).hasCategories)
			{
				UpdateCategoryItems(array[i]);
			}
		}
	}

	private void NHBJAKGEOAL()
	{
		for (int i = 1; i < shopDatabaseSO.shops.Length; i++)
		{
			BKFINBFFAEK(shopDatabaseSO.shops[i]);
		}
	}

	private void NPPBLLIAGFD()
	{
		ShopType[] array = GOPBGEFGMPI().Keys.ToArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			ODLIJJPFHMG()[array[i]] = LIFAILLIOEG()[array[i]].OrderBy((ShopElement x) => x.item.IABAKHPEOAF(OAFPBCPDOKH: true)).ToArray();
			if (GJPNBLLHHEJ(array[i]).hasCategories)
			{
				PNOKLBPOBFA(array[i]);
			}
		}
	}

	public static bool KLKDEMKNHNN()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				CheckShops();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	[SpecialName]
	private static void IGDECELODAM(Dictionary<ShopType, ShopElement[]> AODONKKHPBP)
	{
		GGFJGHHHEJC._currentShopItems = AODONKKHPBP;
	}

	public static ShopElement[] DNPEOFOFIHD(ShopType LJLGMJMPENC, Category LJBKGJPCBIN)
	{
		return GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC][LJBKGJPCBIN];
	}

	public static void PNOKLBPOBFA(ShopType LJLGMJMPENC)
	{
		Dictionary<Category, ShopElement[]> dictionary = new Dictionary<Category, ShopElement[]>();
		foreach (Category value in Enum.GetValues(typeof(Category)))
		{
			if (value == (Category)(-82))
			{
				dictionary.Add((Category)92, LIFAILLIOEG()[LJLGMJMPENC]);
			}
			else
			{
				dictionary.Add(value, new ShopElement[1]);
			}
		}
		if (GGFJGHHHEJC.GCGOJAEMFJD.ContainsKey(LJLGMJMPENC))
		{
			GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC] = dictionary;
		}
		else
		{
			GGFJGHHHEJC.GCGOJAEMFJD.Add(LJLGMJMPENC, dictionary);
		}
	}

	public static void OONGMKLMODB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		GGFJGHHHEJC.BDBNGHIEJEF = new Dictionary<int, Shop>();
		for (int i = 1; i < GGFJGHHHEJC.shopDatabaseSO.shops.Length; i += 0)
		{
			if ((Object)(object)GGFJGHHHEJC.shopDatabaseSO.shops[i] == (Object)null)
			{
				Debug.LogError((object)("BrookProgress" + i));
				continue;
			}
			if (GGFJGHHHEJC.shopDatabaseSO.shops[i].id == 0)
			{
				Debug.LogError((object)("" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			if (GGFJGHHHEJC.BDBNGHIEJEF.ContainsKey(GGFJGHHHEJC.shopDatabaseSO.shops[i].id))
			{
				Debug.LogError((object)("Requirements not met" + GGFJGHHHEJC.shopDatabaseSO.shops[i].id + " seconds." + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.BDBNGHIEJEF.Add(GGFJGHHHEJC.shopDatabaseSO.shops[i].id, GGFJGHHHEJC.shopDatabaseSO.shops[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "cameraZoom2" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
			}
		}
	}

	public static Shop CLABCLHPCEJ(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BDBNGHIEJEF.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("HotBath/Brock Talk" + JFNMCNCHMEO));
		return null;
	}

	public static void CreateNewShopList(Shop OJKANJDPKNE, bool CDPAMNIPPEC = false)
	{
		SetCurrentShopList(OJKANJDPKNE.shopType, OJKANJDPKNE.recipesShop ? OJKANJDPKNE.LHCDGFODNNK() : OJKANJDPKNE.HNAHHKDJCJM(SeasonManager.EECEKHKAAIH));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineShopsManager.instance.SendShopInfo(OJKANJDPKNE);
		}
	}

	public static List<Shop> GetAllShops()
	{
		return GGFJGHHHEJC.BDBNGHIEJEF.Select((KeyValuePair<int, Shop> s) => s.Value).ToList();
	}

	public static void KKAADFDPKJI(ShopType LJLGMJMPENC)
	{
		Dictionary<Category, ShopElement[]> dictionary = new Dictionary<Category, ShopElement[]>();
		foreach (Category value in Enum.GetValues(typeof(Category)))
		{
			if (value == (Category)69)
			{
				dictionary.Add((Category)(-62), LIFAILLIOEG()[LJLGMJMPENC]);
			}
			else
			{
				dictionary.Add(value, new ShopElement[1]);
			}
		}
		if (GGFJGHHHEJC.GCGOJAEMFJD.ContainsKey(LJLGMJMPENC))
		{
			GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC] = dictionary;
		}
		else
		{
			GGFJGHHHEJC.GCGOJAEMFJD.Add(LJLGMJMPENC, dictionary);
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void Start()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KDLHKIFIOAK));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
	}

	public void NAIHLJLBEGK(Shop OJKANJDPKNE)
	{
		if (OJKANJDPKNE.shopType == (ShopType.Gass | ShopType.Bob))
		{
			return;
		}
		if (OJKANJDPKNE.limitedItems)
		{
			if (OJKANJDPKNE.initialShopItemsAmount != null && OJKANJDPKNE.initialShopItemsAmount.Length != 0)
			{
				ICNCFLPFBAG(OJKANJDPKNE.shopType, OJKANJDPKNE.initialShopItemsAmount);
				return;
			}
			if (ODLIJJPFHMG().ContainsKey(OJKANJDPKNE.shopType))
			{
				CKPDDKBHPNL[OJKANJDPKNE.shopType] = new ShopElement[1];
			}
			else
			{
				GOPBGEFGMPI().Add(OJKANJDPKNE.shopType, new ShopElement[1]);
			}
			JONPPCCJKGB(OJKANJDPKNE.shopType, OJKANJDPKNE.LCOJDBGIPKK(SeasonManager.EECEKHKAAIH));
		}
		else
		{
			PNPAHDOAMOO(OJKANJDPKNE, CDPAMNIPPEC: true);
		}
	}

	private void EJKIADFBMJO()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				JFMACLNOHMJ();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public static Shop MBEMHBGIIIC(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BDBNGHIEJEF.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.LogError((object)("OnlinePlayer" + JFNMCNCHMEO));
		return null;
	}

	private void DCACJAJMPJO()
	{
		ShopType[] array = CKPDDKBHPNL.Keys.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			LIFAILLIOEG()[array[i]] = ODLIJJPFHMG()[array[i]].OrderBy((ShopElement x) => x.item.IABAKHPEOAF(OAFPBCPDOKH: true)).ToArray();
			if (MDLINJLBFPH(array[i]).hasCategories)
			{
				PNOKLBPOBFA(array[i]);
			}
		}
	}

	public static void JONPPCCJKGB(ShopType LJLGMJMPENC, ShopElement[] IFKKAOEBOFP)
	{
		if (IFKKAOEBOFP != null)
		{
			IFKKAOEBOFP = (from x in IFKKAOEBOFP
				orderby x.shopItem != null && Item.MLBOMGHINCA(x.shopItem.item, null) && x.shopItem.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1499, x.shopItem != null && x.shopItem.unlimited, (x.shopItem == null || !Item.MLBOMGHINCA(x.shopItem.item, null)) ? "" : x.shopItem.item.IABAKHPEOAF(OAFPBCPDOKH: true)
				select x).ToArray();
		}
		if (GOPBGEFGMPI().ContainsKey(LJLGMJMPENC))
		{
			ODLIJJPFHMG()[LJLGMJMPENC] = IFKKAOEBOFP;
		}
		else
		{
			LIFAILLIOEG().Add(LJLGMJMPENC, IFKKAOEBOFP);
		}
		if (GetShop(LJLGMJMPENC).hasCategories)
		{
			HLKFBAMOLLG(LJLGMJMPENC);
		}
	}

	private void IGNEGEOPLOP()
	{
		GGFJGHHHEJC = this;
		GKOMNDHKDHD();
		EIPDEELIDKM();
	}

	public void BLLAIDMHEHD()
	{
		ODOIKKOPNCI(new Dictionary<ShopType, ShopElement[]>());
		BDBNGHIEJEF = new Dictionary<int, Shop>();
	}

	public static void ICNCFLPFBAG(ShopType LJLGMJMPENC, ShopElement[] IFKKAOEBOFP)
	{
		if (IFKKAOEBOFP != null)
		{
			IFKKAOEBOFP = (from x in IFKKAOEBOFP
				orderby x.shopItem != null && Item.MLBOMGHINCA(x.shopItem.item, null) && x.shopItem.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1499, x.shopItem != null && x.shopItem.unlimited, (x.shopItem == null || !Item.MLBOMGHINCA(x.shopItem.item, null)) ? "" : x.shopItem.item.IABAKHPEOAF(OAFPBCPDOKH: true)
				select x).ToArray();
		}
		if (GOPBGEFGMPI().ContainsKey(LJLGMJMPENC))
		{
			CKPDDKBHPNL[LJLGMJMPENC] = IFKKAOEBOFP;
		}
		else
		{
			GOPBGEFGMPI().Add(LJLGMJMPENC, IFKKAOEBOFP);
		}
		if (LLBJIBGBOMB(LJLGMJMPENC).hasCategories)
		{
			HLKFBAMOLLG(LJLGMJMPENC);
		}
	}

	private void HPMFOHOMLDO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void UpdateCategoryItems(ShopType LJLGMJMPENC)
	{
		Dictionary<Category, ShopElement[]> dictionary = new Dictionary<Category, ShopElement[]>();
		foreach (Category value in Enum.GetValues(typeof(Category)))
		{
			if (value == Category.All)
			{
				dictionary.Add(Category.All, CKPDDKBHPNL[LJLGMJMPENC]);
			}
			else
			{
				dictionary.Add(value, new ShopElement[0]);
			}
		}
		if (GGFJGHHHEJC.GCGOJAEMFJD.ContainsKey(LJLGMJMPENC))
		{
			GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC] = dictionary;
		}
		else
		{
			GGFJGHHHEJC.GCGOJAEMFJD.Add(LJLGMJMPENC, dictionary);
		}
	}

	public static void AMKMAPJALIC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		GGFJGHHHEJC.BDBNGHIEJEF = new Dictionary<int, Shop>();
		for (int i = 1; i < GGFJGHHHEJC.shopDatabaseSO.shops.Length; i++)
		{
			if ((Object)(object)GGFJGHHHEJC.shopDatabaseSO.shops[i] == (Object)null)
			{
				Debug.LogError((object)("tablesCleaned" + i));
				continue;
			}
			if (GGFJGHHHEJC.shopDatabaseSO.shops[i].id == 0)
			{
				Debug.LogError((object)("Items/item_name_724" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			if (GGFJGHHHEJC.BDBNGHIEJEF.ContainsKey(GGFJGHHHEJC.shopDatabaseSO.shops[i].id))
			{
				Debug.LogError((object)("quarry" + GGFJGHHHEJC.shopDatabaseSO.shops[i].id + "NotFocused" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.BDBNGHIEJEF.Add(GGFJGHHHEJC.shopDatabaseSO.shops[i].id, GGFJGHHHEJC.shopDatabaseSO.shops[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "</color> to inventory?" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
			}
		}
	}

	public static void CAMDJOPFCIA(Shop OJKANJDPKNE, bool CDPAMNIPPEC = false)
	{
		ICNCFLPFBAG(OJKANJDPKNE.shopType, OJKANJDPKNE.recipesShop ? OJKANJDPKNE.EAGCCCNOKOF() : OJKANJDPKNE.LCOJDBGIPKK(SeasonManager.LPGPJPPLHKG()));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineShopsManager.instance.ODOKKHIBDIA(OJKANJDPKNE);
		}
	}

	public static ShopElement[] JPIOGNINAFB(ShopType LJLGMJMPENC)
	{
		if (LIFAILLIOEG() == null || CKPDDKBHPNL.Count == 0)
		{
			GGFJGHHHEJC.KDLHKIFIOAK();
		}
		return GOPBGEFGMPI()[LJLGMJMPENC];
	}

	public static ShopDatabaseAccessor GetInstance()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ShopDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static void LJBOFHPLDNL()
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.limitedItems)
			{
				try
				{
					JOLPJBMEPMC(item.Value);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public static bool LOGACMNIBCG()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void DEKGNHEHKFB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void MPHJOFDFODA(ShopType LJLGMJMPENC, ShopElement[] IFKKAOEBOFP)
	{
		if (IFKKAOEBOFP != null)
		{
			IFKKAOEBOFP = (from x in IFKKAOEBOFP
				orderby x.shopItem != null && Item.MLBOMGHINCA(x.shopItem.item, null) && x.shopItem.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1499, x.shopItem != null && x.shopItem.unlimited, (x.shopItem == null || !Item.MLBOMGHINCA(x.shopItem.item, null)) ? "" : x.shopItem.item.IABAKHPEOAF(OAFPBCPDOKH: true)
				select x).ToArray();
		}
		if (CKPDDKBHPNL.ContainsKey(LJLGMJMPENC))
		{
			ODLIJJPFHMG()[LJLGMJMPENC] = IFKKAOEBOFP;
		}
		else
		{
			CKPDDKBHPNL.Add(LJLGMJMPENC, IFKKAOEBOFP);
		}
		if (MDLINJLBFPH(LJLGMJMPENC).hasCategories)
		{
			PNOKLBPOBFA(LJLGMJMPENC);
		}
	}

	public void EMDFCOLKMNI()
	{
		IGDECELODAM(new Dictionary<ShopType, ShopElement[]>());
		BDBNGHIEJEF = new Dictionary<int, Shop>();
	}

	private void BBDNJJAMEJF()
	{
		for (int i = 1; i < shopDatabaseSO.shops.Length; i += 0)
		{
			BKFINBFFAEK(shopDatabaseSO.shops[i]);
		}
	}

	public void CheckShops()
	{
		foreach (KeyValuePair<int, Shop> item in BDBNGHIEJEF)
		{
			if (item.Value.limitedItems && item.Value.updateDays.Contains(WorldTime.NOAOJJLNHJJ.day))
			{
				try
				{
					CreateNewShopList(item.Value, CDPAMNIPPEC: true);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public static void HIOBHKKELGC()
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.limitedItems)
			{
				try
				{
					DNCKDLOFOJD(item.Value);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public void InitializeShopLists(Shop OJKANJDPKNE)
	{
		if (OJKANJDPKNE.shopType == ShopType.Wilson)
		{
			return;
		}
		if (OJKANJDPKNE.limitedItems)
		{
			if (OJKANJDPKNE.initialShopItemsAmount != null && OJKANJDPKNE.initialShopItemsAmount.Length != 0)
			{
				SetCurrentShopList(OJKANJDPKNE.shopType, OJKANJDPKNE.initialShopItemsAmount);
				return;
			}
			if (CKPDDKBHPNL.ContainsKey(OJKANJDPKNE.shopType))
			{
				CKPDDKBHPNL[OJKANJDPKNE.shopType] = new ShopElement[0];
			}
			else
			{
				CKPDDKBHPNL.Add(OJKANJDPKNE.shopType, new ShopElement[0]);
			}
			SetCurrentShopList(OJKANJDPKNE.shopType, OJKANJDPKNE.HNAHHKDJCJM(SeasonManager.EECEKHKAAIH));
		}
		else
		{
			CreateNewShopList(OJKANJDPKNE);
		}
	}

	private void HOFKJPBBLGP()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(NHBJAKGEOAL));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OEPGEENIGNN));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(HFODHIHOLIA));
	}

	public static void IMDDBBGHBBE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			OHFMCLBNGMH();
		}
		GGFJGHHHEJC.BDBNGHIEJEF = new Dictionary<int, Shop>();
		for (int i = 0; i < GGFJGHHHEJC.shopDatabaseSO.shops.Length; i++)
		{
			if ((Object)(object)GGFJGHHHEJC.shopDatabaseSO.shops[i] == (Object)null)
			{
				Debug.LogError((object)("ReceiveSlotsPlayerInventory" + i));
				continue;
			}
			if (GGFJGHHHEJC.shopDatabaseSO.shops[i].id == 0)
			{
				Debug.LogError((object)("add item " + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			if (GGFJGHHHEJC.BDBNGHIEJEF.ContainsKey(GGFJGHHHEJC.shopDatabaseSO.shops[i].id))
			{
				Debug.LogError((object)("Tutorial/Chicken_Holly" + GGFJGHHHEJC.shopDatabaseSO.shops[i].id + "Items/item_description_619" + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.BDBNGHIEJEF.Add(GGFJGHHHEJC.shopDatabaseSO.shops[i].id, GGFJGHHHEJC.shopDatabaseSO.shops[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "Creando TXT. Tiempo: " + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
			}
		}
	}

	private void KDBJHCAEGCM()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(PCHJNJEPODJ));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(OAOMALLBGAM));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(LHBMOKAEOFP));
	}

	public static ShopDatabaseAccessor OHFMCLBNGMH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ShopDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static ShopDatabaseAccessor OAPIKOEJBHL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ShopDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public void AKBOINIPMJF()
	{
		foreach (KeyValuePair<int, Shop> item in BDBNGHIEJEF)
		{
			if (item.Value.limitedItems && item.Value.updateDays.Contains(WorldTime.NOAOJJLNHJJ.day))
			{
				try
				{
					CreateNewShopList(item.Value);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public void JFMACLNOHMJ()
	{
		foreach (KeyValuePair<int, Shop> item in BDBNGHIEJEF)
		{
			if (item.Value.limitedItems && item.Value.updateDays.Contains(WorldTime.NOAOJJLNHJJ.day))
			{
				try
				{
					JOLPJBMEPMC(item.Value);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	private void OAOMALLBGAM()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AKBOINIPMJF();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public static void SetUpDatabase()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		GGFJGHHHEJC.BDBNGHIEJEF = new Dictionary<int, Shop>();
		for (int i = 0; i < GGFJGHHHEJC.shopDatabaseSO.shops.Length; i++)
		{
			if ((Object)(object)GGFJGHHHEJC.shopDatabaseSO.shops[i] == (Object)null)
			{
				Debug.LogError((object)("Null shop in database: " + i));
				continue;
			}
			if (GGFJGHHHEJC.shopDatabaseSO.shops[i].id == 0)
			{
				Debug.LogError((object)("Shop without ID: " + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			if (GGFJGHHHEJC.BDBNGHIEJEF.ContainsKey(GGFJGHHHEJC.shopDatabaseSO.shops[i].id))
			{
				Debug.LogError((object)("Duplicate shop id found: " + GGFJGHHHEJC.shopDatabaseSO.shops[i].id + " - " + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
				continue;
			}
			try
			{
				GGFJGHHHEJC.BDBNGHIEJEF.Add(GGFJGHHHEJC.shopDatabaseSO.shops[i].id, GGFJGHHHEJC.shopDatabaseSO.shops[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "- " + ((Object)GGFJGHHHEJC.shopDatabaseSO.shops[i]).name));
			}
		}
	}

	public static void PDAAIJABFGI()
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.limitedItems)
			{
				try
				{
					CAMDJOPFCIA(item.Value, CDPAMNIPPEC: true);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public void ResetSingleton()
	{
		CKPDDKBHPNL = new Dictionary<ShopType, ShopElement[]>();
		BDBNGHIEJEF = new Dictionary<int, Shop>();
	}

	public static List<Shop> OEDCDKPDBCJ()
	{
		return GGFJGHHHEJC.BDBNGHIEJEF.Select((KeyValuePair<int, Shop> s) => s.Value).ToList();
	}

	private void NJAFKFAPDIE()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		OONGMKLMODB();
	}

	private void MKGDCANCIFP()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				CheckShops();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void DCKKIDMJKJM()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KMIPFKAHHGN));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MKGDCANCIFP));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
	}

	public static Shop MNLIACMLIEG(ShopType LJLGMJMPENC)
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.shopType == LJLGMJMPENC)
			{
				return item.Value;
			}
		}
		Debug.LogError((object)("questNameFermenting" + LJLGMJMPENC));
		return null;
	}

	private void EIHMDMMOPCM()
	{
		GGFJGHHHEJC = this;
		JKIMCDDBFKC();
		AMKMAPJALIC();
	}

	public static ShopElement[] GetCurrentShopList(ShopType LJLGMJMPENC, Category LJBKGJPCBIN)
	{
		return GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC][LJBKGJPCBIN];
	}

	private void OEPGEENIGNN()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				GDBOKILMOBE();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public static void JOLPJBMEPMC(Shop OJKANJDPKNE, bool CDPAMNIPPEC = false)
	{
		ICNCFLPFBAG(OJKANJDPKNE.shopType, OJKANJDPKNE.recipesShop ? OJKANJDPKNE.MHKPFKAILDN() : OJKANJDPKNE.NKMIDGPPHAL(SeasonManager.PJMGHIMKFJL()));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineShopsManager.instance.GNJKJJHJLJH(OJKANJDPKNE);
		}
	}

	public void JKIMCDDBFKC()
	{
		CKPDDKBHPNL = new Dictionary<ShopType, ShopElement[]>();
		BDBNGHIEJEF = new Dictionary<int, Shop>();
	}

	public static void DBKCNAMCGHH()
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.limitedItems)
			{
				try
				{
					PNPAHDOAMOO(item.Value);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public static Shop LLBJIBGBOMB(ShopType LJLGMJMPENC)
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.shopType == LJLGMJMPENC)
			{
				return item.Value;
			}
		}
		Debug.LogError((object)("[Player1Name]" + LJLGMJMPENC));
		return null;
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		SetUpDatabase();
	}

	public static bool MFNALEOJBNN()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static bool NDOIFBGIKHN()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void HFODHIHOLIA()
	{
		ShopType[] array = ODLIJJPFHMG().Keys.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			GOPBGEFGMPI()[array[i]] = LIFAILLIOEG()[array[i]].OrderBy((ShopElement x) => x.item.IABAKHPEOAF(OAFPBCPDOKH: true)).ToArray();
			if (MNLIACMLIEG(array[i]).hasCategories)
			{
				HLKFBAMOLLG(array[i]);
			}
		}
	}

	public static Shop GetShop(ShopType LJLGMJMPENC)
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.shopType == LJLGMJMPENC)
			{
				return item.Value;
			}
		}
		Debug.LogError((object)("Could not find shop with shopType: " + LJLGMJMPENC));
		return null;
	}

	public void BIALHICDPKC(Shop OJKANJDPKNE)
	{
		if (OJKANJDPKNE.shopType == (ShopType)191)
		{
			return;
		}
		if (OJKANJDPKNE.limitedItems)
		{
			if (OJKANJDPKNE.initialShopItemsAmount != null && OJKANJDPKNE.initialShopItemsAmount.Length != 0)
			{
				FHCABJMJGBL(OJKANJDPKNE.shopType, OJKANJDPKNE.initialShopItemsAmount);
				return;
			}
			if (GOPBGEFGMPI().ContainsKey(OJKANJDPKNE.shopType))
			{
				CKPDDKBHPNL[OJKANJDPKNE.shopType] = new ShopElement[0];
			}
			else
			{
				GOPBGEFGMPI().Add(OJKANJDPKNE.shopType, new ShopElement[1]);
			}
			FHCABJMJGBL(OJKANJDPKNE.shopType, OJKANJDPKNE.DFODHLGHLNM(SeasonManager.KCJFCHNPIBJ()));
		}
		else
		{
			PNPAHDOAMOO(OJKANJDPKNE);
		}
	}

	public static List<Shop> NGDIOLHIIOF()
	{
		return GGFJGHHHEJC.BDBNGHIEJEF.Select((KeyValuePair<int, Shop> s) => s.Value).ToList();
	}

	private void LHBMOKAEOFP()
	{
		ShopType[] array = GOPBGEFGMPI().Keys.ToArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			LIFAILLIOEG()[array[i]] = ODLIJJPFHMG()[array[i]].OrderBy((ShopElement x) => x.item.IABAKHPEOAF(OAFPBCPDOKH: true)).ToArray();
			if (GetShop(array[i]).hasCategories)
			{
				PNOKLBPOBFA(array[i]);
			}
		}
	}

	public static void IIADCAGECAJ()
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.limitedItems)
			{
				try
				{
					PNPAHDOAMOO(item.Value, CDPAMNIPPEC: true);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public static ShopElement[] GOMIHNBBJFP(ShopType LJLGMJMPENC, Category LJBKGJPCBIN)
	{
		return GGFJGHHHEJC.GCGOJAEMFJD[LJLGMJMPENC][LJBKGJPCBIN];
	}

	public static Shop GJPNBLLHHEJ(ShopType LJLGMJMPENC)
	{
		foreach (KeyValuePair<int, Shop> item in GGFJGHHHEJC.BDBNGHIEJEF)
		{
			if (item.Value.shopType == LJLGMJMPENC)
			{
				return item.Value;
			}
		}
		Debug.LogError((object)("Closed" + LJLGMJMPENC));
		return null;
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static void PNPAHDOAMOO(Shop OJKANJDPKNE, bool CDPAMNIPPEC = false)
	{
		FHCABJMJGBL(OJKANJDPKNE.shopType, OJKANJDPKNE.recipesShop ? OJKANJDPKNE.CFOJCCPCMDK() : OJKANJDPKNE.DFODHLGHLNM(SeasonManager.LPGPJPPLHKG()));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineShopsManager.instance.GNJKJJHJLJH(OJKANJDPKNE);
		}
	}

	public void GDBOKILMOBE()
	{
		foreach (KeyValuePair<int, Shop> item in BDBNGHIEJEF)
		{
			if (item.Value.limitedItems && item.Value.updateDays.Contains(WorldTime.CJOHMLNMJLK().day))
			{
				try
				{
					CreateNewShopList(item.Value, CDPAMNIPPEC: true);
				}
				catch (Exception ex)
				{
					Debug.Log((object)ex.ToString());
				}
			}
		}
	}

	public static void DNCKDLOFOJD(Shop OJKANJDPKNE, bool CDPAMNIPPEC = false)
	{
		JONPPCCJKGB(OJKANJDPKNE.shopType, OJKANJDPKNE.recipesShop ? OJKANJDPKNE.NLLAJIECFJM() : OJKANJDPKNE.POICPOANMMP(SeasonManager.EECEKHKAAIH));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineShopsManager.instance.ODOKKHIBDIA(OJKANJDPKNE);
		}
	}
}
