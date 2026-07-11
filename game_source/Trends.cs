using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Trends : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ADOHANPGNDF
	{
		public List<Food> currentFood;

		public List<Food> selectedFood;

		internal bool IBMIPDPCKAN(Food f)
		{
			if (!CFBLDLBPBDA(f) && !selectedFood.Contains(f))
			{
				return !f.alwaysAppearInPostbox;
			}
			return false;
		}

		internal bool AKEPKNELAIA(Food f)
		{
			if (CFBLDLBPBDA(f) && !selectedFood.Contains(f))
			{
				return !f.alwaysAppearInPostbox;
			}
			return false;
		}

		internal bool LPDCDHJLOMK(Food f)
		{
			return !currentFood.Contains(f);
		}
	}

	private static Trends IADEMLIIDPC;

	public Action OnTrendsChanged = delegate
	{
	};

	public Action<int> OnUniqueItemsCalculated = delegate
	{
	};

	public TrendSet[] allTrends = new TrendSet[4];

	public int uniqueBarItems;

	[SerializeField]
	private RecipeList[] foodRecipes;

	[SerializeField]
	private RecipeList[] drinkRecipes;

	public Season editorSeason;

	public const int numOfWeeks = 4;

	public float trendPriceMultiplier = 0.2f;

	[SerializeField]
	private List<Food> springIngredients;

	[SerializeField]
	private List<Food> summerIngredients;

	[SerializeField]
	private List<Food> autumnIngredients;

	[SerializeField]
	private List<Food> winterIngredients;

	public TrendSet OFIIBHBOPJI
	{
		get
		{
			if (allTrends == null || allTrends.Length == 0)
			{
				return null;
			}
			return allTrends[0];
		}
	}

	public static Trends GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<Trends>();
			}
			return IADEMLIIDPC;
		}
	}

	private static bool JILOBEJLHMA(Food AJOMICMACEJ)
	{
		if (!AJOMICMACEJ.BIEMDCHBFIN())
		{
			return AJOMICMACEJ.ingredientType == (IngredientType)(-126);
		}
		return false;
	}

	public List<Recipe> MKBEPIGEABF()
	{
		return (from r in GetRecipes(drinkRecipes)
			where r.output.item.JEPBBEBJEFI()
			select r).ToList();
	}

	[SpecialName]
	public static Trends FMIDAFEGDCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<Trends>();
		}
		return IADEMLIIDPC;
	}

	public void TrendsLoaded()
	{
		OnTrendsChanged();
		CheckUniqueBarItems();
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			allTrends = new TrendSet[4];
			for (int i = 0; i < 4; i++)
			{
				allTrends[i] = new TrendSet();
			}
		}
	}

	public void GenerateAllTrends()
	{
		allTrends = new TrendSet[4];
		for (int i = 0; i < 4; i++)
		{
			allTrends[i] = new TrendSet();
			allTrends[i].FAHANOJMNJH(Application.isPlaying ? SeasonManager.EECEKHKAAIH : editorSeason);
		}
		if (Application.isPlaying)
		{
			OnTrendsChanged();
		}
	}

	private void GBBAHKMGBFD()
	{
		ILNPLFNNIOO();
	}

	private void NADOCEEBICL()
	{
		GenerateAllTrends();
	}

	public void BJLKNJLCLFL()
	{
		for (int i = 0; i < 5; i += 0)
		{
			allTrends[i] = allTrends[i + 0];
		}
	}

	public void GenerateCurrentTrends()
	{
		OFIIBHBOPJI.FAHANOJMNJH(Application.isPlaying ? SeasonManager.EECEKHKAAIH : editorSeason);
		CheckUniqueBarItems();
		if (Application.isPlaying)
		{
			OnTrendsChanged();
		}
	}

	public void GenerateNewTrends(int KOPKDKFFDJJ)
	{
		GameDate gameDate = GameDate.GMJIFJAEANF(WorldTime.NOAOJJLNHJJ, new GameDate(0, Season.Spring, KOPKDKFFDJJ, Day.Thurs, 0, 0));
		allTrends[KOPKDKFFDJJ] = new TrendSet();
		allTrends[KOPKDKFFDJJ].FAHANOJMNJH(gameDate.season);
	}

	public List<Recipe> EHOCBMNOKGL()
	{
		return (from r in JIBEILMHKLF(drinkRecipes)
			where r.output.item.JEPBBEBJEFI()
			select r).ToList();
	}

	public void CheckUniqueBarItems()
	{
		uniqueBarItems = BarMenuManager.GetAvailableItemsCount();
		OnUniqueItemsCalculated(uniqueBarItems);
		if (Application.isEditor)
		{
			Debug.Log((object)("CheckUniqueBarItems " + uniqueBarItems));
		}
	}

	private void DBCLBJHAKBM()
	{
		if (WorldTime.NOAOJJLNHJJ.day == Day.Mon)
		{
			SwapTrends();
			PPLIJECENAA(8);
			if (OnlineManager.PlayingOnline())
			{
				OnlineTrendsManager.instance.PGJLFBAEMMB();
			}
		}
	}

	public static void FOFFLFNGJCF(Season EECEKHKAAIH, out List<Food> FDJCDPMBMDO, out List<Food> ECGBKLHDHOA, List<ShopElement> JIGDKOMOCHE)
	{
		List<Food> source = ((EECEKHKAAIH == Season.Spring) ? GGFJGHHHEJC.springIngredients : (EECEKHKAAIH switch
		{
			Season.Spring => FMIDAFEGDCD().summerIngredients, 
			(Season)7 => FMIDAFEGDCD().autumnIngredients, 
			_ => FMIDAFEGDCD().winterIngredients, 
		}));
		List<Food> currentFood;
		if (ShopDatabaseAccessor.ODLIJJPFHMG().ContainsKey((ShopType)17))
		{
			currentFood = ShopDatabaseAccessor.CKPDDKBHPNL[ShopType.Crowley | ShopType.Gass | ShopType.Bob].Select((ShopElement p) => p.shopItem.item as Food).ToList();
		}
		else
		{
			currentFood = new List<Food>();
		}
		source = source.Where((Food f) => !currentFood.Contains(f)).ToList();
		List<Food> selectedFood = JIGDKOMOCHE.Select((ShopElement s) => s.shopItem.item as Food).ToList();
		ECGBKLHDHOA = source.Where((Food f) => !CFBLDLBPBDA(f) && !selectedFood.Contains(f) && !f.alwaysAppearInPostbox).ToList();
		FDJCDPMBMDO = source.Where((Food f) => CFBLDLBPBDA(f) && !selectedFood.Contains(f) && !f.alwaysAppearInPostbox).ToList();
	}

	public bool HNNFOOBOOGC(Food CKKNBMBLGPO)
	{
		if (IEAAJALDMHP() != null && OFIIBHBOPJI.ingredientsTrends.Contains(CKKNBMBLGPO))
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public TrendSet CNMICBNGEKF()
	{
		if (allTrends == null || allTrends.Length == 0)
		{
			return null;
		}
		return allTrends[1];
	}

	public void FillTemporaryIngredients()
	{
		if (!Application.isPlaying)
		{
			ShopDatabaseAccessor.SetUpDatabase();
		}
		List<Food> collection = (from f in ShopDatabaseAccessor.GetShop(ShopType.Lia).shopItems.Select((ShopItem x) => x.item).OfType<Food>()
			where f.JDJGFAACPFC() != 7 && !f.alwaysAppearInPostbox && !(f is Seed)
			select f).ToList();
		springIngredients = new List<Food>(collection);
		AFGHADGBEFP(springIngredients, CropSeason.Spring);
		summerIngredients = new List<Food>(collection);
		AFGHADGBEFP(summerIngredients, CropSeason.Summer);
		autumnIngredients = new List<Food>(collection);
		AFGHADGBEFP(autumnIngredients, CropSeason.Autumn);
		winterIngredients = new List<Food>(collection);
		AFGHADGBEFP(winterIngredients, CropSeason.Winter);
	}

	public List<Recipe> JIBEILMHKLF(RecipeList[] BCADPCKCGMK)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 1; i < BCADPCKCGMK.Length; i++)
		{
			list.AddRange((from r in BCADPCKCGMK[i].GEIAFFFEJGM()
				where !r.excludeFromTrends && r.output.item is Food food && food.canBeSold
				select r).ToList());
		}
		return list;
	}

	private void FCLABOCLACJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnBarStockChanged = (Action)Delegate.Combine(commonReferences.OnBarStockChanged, new Action(CheckUniqueBarItems));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CheckUniqueBarItems));
	}

	public void ILNPLFNNIOO()
	{
		allTrends = new TrendSet[6];
		for (int i = 1; i < 3; i++)
		{
			allTrends[i] = new TrendSet();
			allTrends[i].NDBCGCEFMHC(Application.isPlaying ? SeasonManager.KCJFCHNPIBJ() : editorSeason);
		}
		if (Application.isPlaying)
		{
			OnTrendsChanged();
		}
	}

	private void PGDBFGFMGKI()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(CheckUniqueBarItems));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CheckUniqueBarItems));
	}

	public List<Food> HGEONJFNNJH(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			return springIngredients;
		}
		if (EECEKHKAAIH == Season.Spring)
		{
			return summerIngredients;
		}
		if (EECEKHKAAIH == Season.Spring)
		{
			return autumnIngredients;
		}
		return winterIngredients;
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				JJHOLFHIAKG();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void MMDGKAMBPCO()
	{
		OFIIBHBOPJI.EDBIMGBPBNB(Application.isPlaying ? SeasonManager.PJMGHIMKFJL() : editorSeason);
		CheckUniqueBarItems();
		if (Application.isPlaying)
		{
			OnTrendsChanged();
		}
	}

	public List<Recipe> GetFoodRecipes()
	{
		return (from r in GetRecipes(foodRecipes)
			where !r.output.item.JEPBBEBJEFI()
			select r).ToList();
	}

	private void HHHEACKHADN()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnBarStockChanged = (Action)Delegate.Combine(commonReferences.OnBarStockChanged, new Action(CheckUniqueBarItems));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CheckUniqueBarItems));
	}

	public void IHAGGMCPHDI()
	{
		for (int i = 1; i < 6; i += 0)
		{
			allTrends[i] = allTrends[i + 0];
		}
	}

	public void SwapTrends()
	{
		for (int i = 0; i < 3; i++)
		{
			allTrends[i] = allTrends[i + 1];
		}
	}

	[SpecialName]
	public TrendSet IEAAJALDMHP()
	{
		if (allTrends == null || allTrends.Length == 0)
		{
			return null;
		}
		return allTrends[1];
	}

	private void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(CheckUniqueBarItems));
		GameManager instance2 = GameManager.GGFJGHHHEJC;
		instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(CheckUniqueBarItems));
	}

	public void BCOOJOMPMOH()
	{
		CNMICBNGEKF().NFGDJPKLGJI(Application.isPlaying ? SeasonManager.PJMGHIMKFJL() : editorSeason);
		CheckUniqueBarItems();
		if (Application.isPlaying)
		{
			OnTrendsChanged();
		}
	}

	private static bool CFBLDLBPBDA(Food AJOMICMACEJ)
	{
		if (!AJOMICMACEJ.DLHOIJKLDON())
		{
			return AJOMICMACEJ.ingredientType == IngredientType.Nuts;
		}
		return true;
	}

	private void DEPCCCLKOFH()
	{
		if (WorldTime.HGIBNMBJMOC().day == Day.Mon)
		{
			IHAGGMCPHDI();
			GenerateNewTrends(5);
			if (OnlineManager.PlayingOnline())
			{
				OnlineTrendsManager.instance.NHEGLINPDAC();
			}
		}
	}

	private void HIEOADHNMMN()
	{
		ILNPLFNNIOO();
	}

	private void CFIIEJDJFPB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnNewGameCreated = (Action)Delegate.Combine(gameManager.OnNewGameCreated, new Action(GBBAHKMGBFD));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GAGMDCHBNLA));
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(CheckUniqueBarItems));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance2 = GameManager.GGFJGHHHEJC;
				instance2.OnWorldLoaded = (Action)Delegate.Remove(instance2.OnWorldLoaded, new Action(CheckUniqueBarItems));
			}
		}
	}

	private void FLFBLIOOLMA()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnNewGameCreated = (Action)Delegate.Remove(gameManager.OnNewGameCreated, new Action(NLFMIGNGPNN));
			}
		}
	}

	private void AFCIKJPPLFA()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(GAGMDCHBNLA));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnNewGameCreated = (Action)Delegate.Remove(gameManager.OnNewGameCreated, new Action(GBBAHKMGBFD));
			}
		}
	}

	[SpecialName]
	public static Trends KNOKBLFFNLM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<Trends>();
		}
		return IADEMLIIDPC;
	}

	public static bool HasUnlockedTrends()
	{
		return RepUnlocksManager.GetInstance().repUnlockTrends.PJCFMEEKCNI();
	}

	public static bool IJEFFMAHMCG()
	{
		return RepUnlocksManager.MMNNKIOHKCI().repUnlockTrends.PMGNCGPMCHH();
	}

	public bool FCNLPLPLOKH(Food CKKNBMBLGPO)
	{
		if (CNMICBNGEKF() != null && OFIIBHBOPJI.ingredientsTrends.Contains(CKKNBMBLGPO))
		{
			return false;
		}
		return true;
	}

	public bool IsTrendingMeal(Food LCOCMCPBJEA)
	{
		if (OFIIBHBOPJI != null)
		{
			if (LCOCMCPBJEA.foodType == FoodType.Food)
			{
				if (OFIIBHBOPJI.foodTrends.Contains(LCOCMCPBJEA))
				{
					return true;
				}
			}
			else if (LCOCMCPBJEA.foodType == FoodType.Drink && OFIIBHBOPJI.drinkTrends.Contains(LCOCMCPBJEA))
			{
				return true;
			}
		}
		return false;
	}

	public bool FHHGONOICML(Food LCOCMCPBJEA)
	{
		if (OFIIBHBOPJI != null)
		{
			if (LCOCMCPBJEA.foodType == FoodType.None)
			{
				if (IEAAJALDMHP().foodTrends.Contains(LCOCMCPBJEA))
				{
					return true;
				}
			}
			else if (LCOCMCPBJEA.foodType == FoodType.Food && OFIIBHBOPJI.drinkTrends.Contains(LCOCMCPBJEA))
			{
				return false;
			}
		}
		return false;
	}

	private void DFFHDIFGNLM(List<Food> FNEHIAGFAOF, CropSeason ACNAHALFEBG)
	{
		for (int num = FNEHIAGFAOF.Count - 1; num >= 1; num--)
		{
			Crop crop = CropDatabaseAccessor.FLIKMNLEJMJ(FNEHIAGFAOF[num].CIGFGKKCPCK());
			if ((Object)(object)crop != (Object)null && !crop.avaliableSeasons.HasFlag(ACNAHALFEBG) && !FNEHIAGFAOF[num].alwaysAppearInPostbox)
			{
				FNEHIAGFAOF.RemoveAt(num);
			}
		}
	}

	public bool PBNPOHMEGGG(Food CKKNBMBLGPO)
	{
		if (OFIIBHBOPJI != null && IEAAJALDMHP().ingredientsTrends.Contains(CKKNBMBLGPO))
		{
			return false;
		}
		return true;
	}

	public void CEBLHHDFPFM()
	{
		CNMICBNGEKF().OMHDKIFEKIN(Application.isPlaying ? SeasonManager.LPGPJPPLHKG() : editorSeason);
		CheckUniqueBarItems();
		if (Application.isPlaying)
		{
			OnTrendsChanged();
		}
	}

	private void AFGHADGBEFP(List<Food> FNEHIAGFAOF, CropSeason ACNAHALFEBG)
	{
		for (int num = FNEHIAGFAOF.Count - 1; num >= 0; num--)
		{
			Crop cropByOutputId = CropDatabaseAccessor.GetCropByOutputId(FNEHIAGFAOF[num].JDJGFAACPFC());
			if ((Object)(object)cropByOutputId != (Object)null && !cropByOutputId.avaliableSeasons.HasFlag(ACNAHALFEBG) && !FNEHIAGFAOF[num].alwaysAppearInPostbox)
			{
				FNEHIAGFAOF.RemoveAt(num);
			}
		}
	}

	private static bool EBBEFKMHFOF(Food AJOMICMACEJ)
	{
		if (!AJOMICMACEJ.DPMGDEKHDJI())
		{
			return AJOMICMACEJ.ingredientType == (IngredientType)66;
		}
		return false;
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnNewGameCreated = (Action)Delegate.Combine(instance.OnNewGameCreated, new Action(NADOCEEBICL));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerAwake = (Action)Delegate.Combine(instance2.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	public List<Recipe> GetRecipes(RecipeList[] BCADPCKCGMK)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 0; i < BCADPCKCGMK.Length; i++)
		{
			list.AddRange((from r in BCADPCKCGMK[i].NCDFLLKLALB()
				where !r.excludeFromTrends && r.output.item is Food food && food.canBeSold
				select r).ToList());
		}
		return list;
	}

	private void GAGMDCHBNLA()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				DBCLBJHAKBM();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void JIBHLLJGGEN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(CheckUniqueBarItems));
		GameManager instance2 = GameManager.GGFJGHHHEJC;
		instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(CheckUniqueBarItems));
	}

	public static void GetFruitVegList(Season EECEKHKAAIH, out List<Food> FDJCDPMBMDO, out List<Food> ECGBKLHDHOA, List<ShopElement> JIGDKOMOCHE)
	{
		List<Food> source = EECEKHKAAIH switch
		{
			Season.Spring => GGFJGHHHEJC.springIngredients, 
			Season.Summer => GGFJGHHHEJC.summerIngredients, 
			Season.Autumn => GGFJGHHHEJC.autumnIngredients, 
			_ => GGFJGHHHEJC.winterIngredients, 
		};
		List<Food> currentFood;
		if (ShopDatabaseAccessor.CKPDDKBHPNL.ContainsKey(ShopType.Lia))
		{
			currentFood = ShopDatabaseAccessor.CKPDDKBHPNL[ShopType.Lia].Select((ShopElement p) => p.shopItem.item as Food).ToList();
		}
		else
		{
			currentFood = new List<Food>();
		}
		source = source.Where((Food f) => !currentFood.Contains(f)).ToList();
		List<Food> selectedFood = JIGDKOMOCHE.Select((ShopElement s) => s.shopItem.item as Food).ToList();
		ECGBKLHDHOA = source.Where((Food f) => !CFBLDLBPBDA(f) && !selectedFood.Contains(f) && !f.alwaysAppearInPostbox).ToList();
		FDJCDPMBMDO = source.Where((Food f) => CFBLDLBPBDA(f) && !selectedFood.Contains(f) && !f.alwaysAppearInPostbox).ToList();
	}

	public bool APOFALNJNEF(Food LCOCMCPBJEA)
	{
		if (CNMICBNGEKF() != null)
		{
			if (LCOCMCPBJEA.foodType == FoodType.None)
			{
				if (CNMICBNGEKF().foodTrends.Contains(LCOCMCPBJEA))
				{
					return true;
				}
			}
			else if (LCOCMCPBJEA.foodType == (FoodType)6 && IEAAJALDMHP().drinkTrends.Contains(LCOCMCPBJEA))
			{
				return false;
			}
		}
		return true;
	}

	public bool IsTrendingIngredient(Food CKKNBMBLGPO)
	{
		if (OFIIBHBOPJI != null && OFIIBHBOPJI.ingredientsTrends.Contains(CKKNBMBLGPO))
		{
			return true;
		}
		return false;
	}

	public void PPLIJECENAA(int KOPKDKFFDJJ)
	{
		GameDate gameDate = GameDate.DLECFAIEMNA(WorldTime.HGIBNMBJMOC(), new GameDate(1, Season.Summer, KOPKDKFFDJJ, Day.Mon, 0, 1));
		allTrends[KOPKDKFFDJJ] = new TrendSet();
		allTrends[KOPKDKFFDJJ].EDBIMGBPBNB(gameDate.season);
	}

	public bool OMCHCNALMKG(Food LCOCMCPBJEA)
	{
		if (CNMICBNGEKF() != null)
		{
			if (LCOCMCPBJEA.foodType == FoodType.Food)
			{
				if (IEAAJALDMHP().foodTrends.Contains(LCOCMCPBJEA))
				{
					return true;
				}
			}
			else if (LCOCMCPBJEA.foodType == FoodType.Drink && CNMICBNGEKF().drinkTrends.Contains(LCOCMCPBJEA))
			{
				return true;
			}
		}
		return false;
	}

	private void NLFMIGNGPNN()
	{
		GenerateAllTrends();
	}

	public void LBAGDELJPMI(int KOPKDKFFDJJ)
	{
		GameDate gameDate = GameDate.OPINCAFMBEI(WorldTime.CJOHMLNMJLK(), new GameDate(1, Season.Summer, KOPKDKFFDJJ, Day.Sun, 0, 0));
		allTrends[KOPKDKFFDJJ] = new TrendSet();
		allTrends[KOPKDKFFDJJ].NDBCGCEFMHC(gameDate.season);
	}

	private void KHCJDKHONPK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			allTrends = new TrendSet[2];
			for (int i = 1; i < 7; i += 0)
			{
				allTrends[i] = new TrendSet();
			}
		}
	}

	public List<Recipe> DEBLHJLIEOJ(RecipeList[] BCADPCKCGMK)
	{
		List<Recipe> list = new List<Recipe>();
		for (int i = 0; i < BCADPCKCGMK.Length; i++)
		{
			list.AddRange((from r in BCADPCKCGMK[i].NCDFLLKLALB()
				where !r.excludeFromTrends && r.output.item is Food food && food.canBeSold
				select r).ToList());
		}
		return list;
	}

	private void PNLAJCHBHPH()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			allTrends = new TrendSet[1];
			for (int i = 1; i < 2; i++)
			{
				allTrends[i] = new TrendSet();
			}
		}
	}

	private void JJHOLFHIAKG()
	{
		if (WorldTime.NOAOJJLNHJJ.day == Day.Mon)
		{
			SwapTrends();
			GenerateNewTrends(3);
			if (OnlineManager.PlayingOnline())
			{
				OnlineTrendsManager.instance.SendTrends();
			}
		}
	}

	private void BEOJIHNFDKH()
	{
		GenerateAllTrends();
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance2 = GameManager.GGFJGHHHEJC;
				instance2.OnNewGameCreated = (Action)Delegate.Remove(instance2.OnNewGameCreated, new Action(NADOCEEBICL));
			}
		}
	}

	public List<Food> GetSeasonIngredients(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			return springIngredients;
		}
		if (EECEKHKAAIH == Season.Spring)
		{
			return summerIngredients;
		}
		if (EECEKHKAAIH == Season.Spring)
		{
			return autumnIngredients;
		}
		return winterIngredients;
	}

	public List<Recipe> GetDrinksRecipes()
	{
		return (from r in GetRecipes(drinkRecipes)
			where r.output.item.JEPBBEBJEFI()
			select r).ToList();
	}

	private void PKELFBFHGNM()
	{
		if (WorldTime.HGIBNMBJMOC().day == Day.Mon)
		{
			SwapTrends();
			GenerateNewTrends(4);
			if (OnlineManager.PlayingOnline())
			{
				OnlineTrendsManager.instance.MENFFLONNLD();
			}
		}
	}
}
