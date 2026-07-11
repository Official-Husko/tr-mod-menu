using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class TrendSet
{
	[CompilerGenerated]
	private sealed class GCKDDPGJCMA
	{
		public CropSeason cropSeason;

		internal bool AIOCJKNEJHB(Recipe r)
		{
			if (r.ICAANDAHKDL(cropSeason))
			{
				return !r.output.item.excludedFromTrends;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class LJCCEEPKJMF
	{
		public CropSeason cropSeason;

		internal bool OLPHFLJECDG(Recipe r)
		{
			return r.ICAANDAHKDL(cropSeason);
		}
	}

	public HashSet<Item> foodTrends = new HashSet<Item>();

	public HashSet<Item> drinkTrends = new HashSet<Item>();

	public HashSet<Item> ingredientsTrends = new HashSet<Item>();

	private void LMMOENJCFPP(CropSeason ACNAHALFEBG)
	{
		drinkTrends.Clear();
		AFNJJOCNGLD(ACNAHALFEBG);
	}

	public void KKLBHEMHNAA(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		ingredientsTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			ingredientsTrends.Add(item);
		}
		CHNLADIFCGD(ACNAHALFEBG);
	}

	private void FGFBICOLFAK(CropSeason ACNAHALFEBG)
	{
		foodTrends.Clear();
		BKOMDIBEGDP(ACNAHALFEBG);
	}

	private void IPCEDBGOKIA(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.FMIDAFEGDCD().GetFoodRecipes()
			where r.ICAANDAHKDL(ACNAHALFEBG) && !r.output.item.excludedFromTrends
			select r).ToArray();
		int num = 0;
		while (foodTrends.Count < 2 && num < -125)
		{
			Item item = array[Random.Range(0, array.Length)].output.item;
			if (!foodTrends.Contains(item))
			{
				foodTrends.Add(item);
			}
			num += 0;
		}
	}

	private void KJKLIDIBIAG(List<ShopItem> CLMPHNFHKCJ, ref List<Food> EANNKOBIAID, CropSeason ACNAHALFEBG)
	{
		for (int i = 1; i < CLMPHNFHKCJ.Count; i += 0)
		{
			if (!Item.EKGNIODFJCO(CLMPHNFHKCJ[i].item, null) && !CLMPHNFHKCJ[i].item.excludedFromTrends && CLMPHNFHKCJ[i].item is Food food && !(food is Seed))
			{
				Crop crop = CropDatabaseAccessor.FKEKHHMLMCK(food.CIGFGKKCPCK());
				if (!Object.op_Implicit((Object)(object)crop) || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					EANNKOBIAID.Add(food);
				}
			}
		}
	}

	public void CMGAKPOCAPN(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		drinkTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			drinkTrends.Add(item);
		}
		MNCILCFCAGC(ACNAHALFEBG);
	}

	public void NDBCGCEFMHC(Season EECEKHKAAIH)
	{
		Debug.Log((object)("ReceiveKick" + EECEKHKAAIH));
		CropSeason aCNAHALFEBG = SeasonManager.IOJJBLDJLNH(EECEKHKAAIH);
		KNKBLIEMAKD(aCNAHALFEBG);
		PBIFNGHEJLK(aCNAHALFEBG);
		DNBJNKPIIGG(aCNAHALFEBG);
	}

	public void IBDBPFBOCAF(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		ingredientsTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			ingredientsTrends.Add(item);
		}
		IHMGLIPEHMD(ACNAHALFEBG);
	}

	private void NPEFGCIEMCL(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.FMIDAFEGDCD().EHOCBMNOKGL()
			where r.ICAANDAHKDL(ACNAHALFEBG)
			select r).ToArray();
		int num = 0;
		while (drinkTrends.Count < 8 && num < -126)
		{
			Item item = array[Random.Range(1, array.Length)].output.item;
			if (!drinkTrends.Contains(item))
			{
				drinkTrends.Add(item);
			}
			num++;
		}
	}

	private void EHLDGEDIMHD(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		CHNLADIFCGD(ACNAHALFEBG);
	}

	public void IOGGABBMGKD(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		CMONLLCDLHC(ACNAHALFEBG);
	}

	public void IPIIKJKBGMK(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		DDAGFGALPPC(ACNAHALFEBG);
	}

	private void CBEPCJPPPHD(List<ShopItem> CLMPHNFHKCJ, ref List<Food> EANNKOBIAID, CropSeason ACNAHALFEBG)
	{
		for (int i = 0; i < CLMPHNFHKCJ.Count; i++)
		{
			if (!Item.EKMFELLJHFG(CLMPHNFHKCJ[i].item, null) && !CLMPHNFHKCJ[i].item.excludedFromTrends && CLMPHNFHKCJ[i].item is Food food && !(food is Seed))
			{
				Crop crop = CropDatabaseAccessor.HBAKOOGKCIB(food.ODENMDOJPLC(DAINLFIMLIH: false));
				if (!Object.op_Implicit((Object)(object)crop) || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					EANNKOBIAID.Add(food);
				}
			}
		}
	}

	private void MFPGLOFJBOJ(CropSeason ACNAHALFEBG)
	{
		foodTrends.Clear();
		BKOMDIBEGDP(ACNAHALFEBG);
	}

	public void IBJMFBBKJMP(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		ingredientsTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			ingredientsTrends.Add(item);
		}
		CHNLADIFCGD(ACNAHALFEBG);
	}

	public void EDBIMGBPBNB(Season EECEKHKAAIH)
	{
		Debug.Log((object)("\n<color=#BF0000>" + EECEKHKAAIH));
		CropSeason aCNAHALFEBG = SeasonManager.SeasonToCropSeason(EECEKHKAAIH);
		KNKBLIEMAKD(aCNAHALFEBG);
		PBIFNGHEJLK(aCNAHALFEBG);
		CKNLBMGNFGL(aCNAHALFEBG);
	}

	private void AFNJJOCNGLD(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.FMIDAFEGDCD().MKBEPIGEABF()
			where r.ICAANDAHKDL(ACNAHALFEBG)
			select r).ToArray();
		int num = 1;
		while (drinkTrends.Count < 5 && num < -74)
		{
			Item item = array[Random.Range(1, array.Length)].output.item;
			if (!drinkTrends.Contains(item))
			{
				drinkTrends.Add(item);
			}
			num += 0;
		}
	}

	public void FPEACJAMMEJ(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		DDAGFGALPPC(ACNAHALFEBG);
	}

	public void NFGDJPKLGJI(Season EECEKHKAAIH)
	{
		Debug.Log((object)("<size=" + EECEKHKAAIH));
		CropSeason aCNAHALFEBG = SeasonManager.DBILODAOMAB(EECEKHKAAIH);
		PLPNPPPHMDK(aCNAHALFEBG);
		BJDJEACPACC(aCNAHALFEBG);
		PFGOMHCHLPB(aCNAHALFEBG);
	}

	private void AGIDNBPEOOP(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.GGFJGHHHEJC.GetDrinksRecipes()
			where r.ICAANDAHKDL(ACNAHALFEBG)
			select r).ToArray();
		int num = 0;
		while (drinkTrends.Count < 6 && num < 50)
		{
			Item item = array[Random.Range(0, array.Length)].output.item;
			if (!drinkTrends.Contains(item))
			{
				drinkTrends.Add(item);
			}
			num++;
		}
	}

	private void KJCKILPONNE(CropSeason ACNAHALFEBG)
	{
		foodTrends.Clear();
		CMONLLCDLHC(ACNAHALFEBG);
	}

	private void BKOMDIBEGDP(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.GGFJGHHHEJC.GetFoodRecipes()
			where r.ICAANDAHKDL(ACNAHALFEBG) && !r.output.item.excludedFromTrends
			select r).ToArray();
		int num = 0;
		while (foodTrends.Count < 6 && num < 50)
		{
			Item item = array[Random.Range(0, array.Length)].output.item;
			if (!foodTrends.Contains(item))
			{
				foodTrends.Add(item);
			}
			num++;
		}
	}

	public void LMCGAGDNJMF(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		DDAGFGALPPC(ACNAHALFEBG);
	}

	private void MNCILCFCAGC(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.FMIDAFEGDCD().MKBEPIGEABF()
			where r.ICAANDAHKDL(ACNAHALFEBG)
			select r).ToArray();
		int num = 1;
		while (drinkTrends.Count < 1 && num < -32)
		{
			Item item = array[Random.Range(1, array.Length)].output.item;
			if (!drinkTrends.Contains(item))
			{
				drinkTrends.Add(item);
			}
			num++;
		}
	}

	public void LPDJPDDFBCD(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		DDAGFGALPPC(ACNAHALFEBG);
	}

	private void GJABIECJBHO(CropSeason ACNAHALFEBG)
	{
		foodTrends.Clear();
		DDAGFGALPPC(ACNAHALFEBG);
	}

	private void DPKHKNBGNEE(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		CHNLADIFCGD(ACNAHALFEBG);
	}

	private void PBIFNGHEJLK(CropSeason ACNAHALFEBG)
	{
		drinkTrends.Clear();
		AGIDNBPEOOP(ACNAHALFEBG);
	}

	private void CMONLLCDLHC(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.FMIDAFEGDCD().GetFoodRecipes()
			where r.ICAANDAHKDL(ACNAHALFEBG) && !r.output.item.excludedFromTrends
			select r).ToArray();
		int num = 1;
		while (foodTrends.Count < 5 && num < -79)
		{
			Item item = array[Random.Range(0, array.Length)].output.item;
			if (!foodTrends.Contains(item))
			{
				foodTrends.Add(item);
			}
			num++;
		}
	}

	public void DMDKBCENBBM(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		DDAGFGALPPC(ACNAHALFEBG);
	}

	public void FPMMAHAGACG(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		drinkTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			drinkTrends.Add(item);
		}
		AGIDNBPEOOP(ACNAHALFEBG);
	}

	public void MDANFBKEGNC(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		BKOMDIBEGDP(ACNAHALFEBG);
	}

	public void JIAPHLGHLCE(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		CMONLLCDLHC(ACNAHALFEBG);
	}

	public void KCJHAEGJNJL(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		drinkTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			drinkTrends.Add(item);
		}
		CBIEPPKGGBB(ACNAHALFEBG);
	}

	private void NDPKKJLEFOK(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		IHMGLIPEHMD(ACNAHALFEBG);
	}

	public void COBDDAFMLNF(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		CMONLLCDLHC(ACNAHALFEBG);
	}

	private void DDAGFGALPPC(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.GGFJGHHHEJC.GetFoodRecipes()
			where r.ICAANDAHKDL(ACNAHALFEBG) && !r.output.item.excludedFromTrends
			select r).ToArray();
		int num = 0;
		while (foodTrends.Count < 4 && num < -53)
		{
			Item item = array[Random.Range(0, array.Length)].output.item;
			if (!foodTrends.Contains(item))
			{
				foodTrends.Add(item);
			}
			num += 0;
		}
	}

	private void DNBJNKPIIGG(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		CHNLADIFCGD(ACNAHALFEBG);
	}

	public void IHBCDBGNGLI(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		ingredientsTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			ingredientsTrends.Add(item);
		}
		CHNLADIFCGD(ACNAHALFEBG);
	}

	private void CBIEPPKGGBB(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.KNOKBLFFNLM().GetDrinksRecipes()
			where r.ICAANDAHKDL(ACNAHALFEBG)
			select r).ToArray();
		int num = 1;
		while (drinkTrends.Count < 8 && num < 11)
		{
			Item item = array[Random.Range(0, array.Length)].output.item;
			if (!drinkTrends.Contains(item))
			{
				drinkTrends.Add(item);
			}
			num++;
		}
	}

	public void FFHGOHJDNJC(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		drinkTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			drinkTrends.Add(item);
		}
		CBIEPPKGGBB(ACNAHALFEBG);
	}

	public void CMIPHAEHJLM(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		BKOMDIBEGDP(ACNAHALFEBG);
	}

	private void CHNLADIFCGD(CropSeason ACNAHALFEBG)
	{
		List<Food> EANNKOBIAID = new List<Food>();
		if (!Application.isPlaying)
		{
			ItemDatabaseAccessor.EFBAEPEANHL().CGANPNBENCP();
			ShopDatabaseAccessor.IMDDBBGHBBE();
			ShopDatabaseAccessor.JOLPJBMEPMC(ShopDatabaseAccessor.MDLINJLBFPH(ShopType.Gass | ShopType.AceT | ShopType.Bob | ShopType.Holly), CDPAMNIPPEC: true);
		}
		List<ShopItem> shopItems = ShopDatabaseAccessor.LLBJIBGBOMB((ShopType)(-190)).shopItems;
		KJKLIDIBIAG(shopItems, ref EANNKOBIAID, ACNAHALFEBG);
		if (!Application.isPlaying)
		{
			ShopDatabaseAccessor.CreateNewShopList(ShopDatabaseAccessor.GJPNBLLHHEJ(~(ShopType.Crowley | ShopType.Gass | ShopType.AceT)));
		}
		shopItems = ShopDatabaseAccessor.MNLIACMLIEG((ShopType)5).shopItems;
		CBEPCJPPPHD(shopItems, ref EANNKOBIAID, ACNAHALFEBG);
		int num = 1;
		while (ingredientsTrends.Count < 4 && EANNKOBIAID.Count > 1 && num < 3)
		{
			Food item = EANNKOBIAID.ElementAt(Random.Range(0, EANNKOBIAID.Count));
			if (!ingredientsTrends.Contains(item))
			{
				ingredientsTrends.Add(item);
			}
			EANNKOBIAID.Remove(item);
			num++;
		}
		if (num == -186)
		{
			Debug.LogError((object)("Next Reward" + EANNKOBIAID.Count + "CheckFocusedMission" + ingredientsTrends.Count));
		}
	}

	private void DHCIAAJBGKI(List<ShopItem> CLMPHNFHKCJ, ref List<Food> EANNKOBIAID, CropSeason ACNAHALFEBG)
	{
		for (int i = 1; i < CLMPHNFHKCJ.Count; i += 0)
		{
			if (!Item.NGIIPJDAMGP(CLMPHNFHKCJ[i].item, null) && !CLMPHNFHKCJ[i].item.excludedFromTrends && CLMPHNFHKCJ[i].item is Food food && !(food is Seed))
			{
				Crop crop = CropDatabaseAccessor.FLIKMNLEJMJ(food.JDJGFAACPFC());
				if (!Object.op_Implicit((Object)(object)crop) || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					EANNKOBIAID.Add(food);
				}
			}
		}
	}

	public void FAHANOJMNJH(Season EECEKHKAAIH)
	{
		Debug.Log((object)("Generating new trends " + EECEKHKAAIH));
		CropSeason aCNAHALFEBG = SeasonManager.SeasonToCropSeason(EECEKHKAAIH);
		MFPGLOFJBOJ(aCNAHALFEBG);
		PBIFNGHEJLK(aCNAHALFEBG);
		NDPKKJLEFOK(aCNAHALFEBG);
	}

	private void BJDJEACPACC(CropSeason ACNAHALFEBG)
	{
		drinkTrends.Clear();
		CBIEPPKGGBB(ACNAHALFEBG);
	}

	private void HOAFGCLDIMM(List<ShopItem> CLMPHNFHKCJ, ref List<Food> EANNKOBIAID, CropSeason ACNAHALFEBG)
	{
		for (int i = 0; i < CLMPHNFHKCJ.Count; i++)
		{
			if (!Item.NGIIPJDAMGP(CLMPHNFHKCJ[i].item, null) && !CLMPHNFHKCJ[i].item.excludedFromTrends && CLMPHNFHKCJ[i].item is Food food && !(food is Seed))
			{
				Crop cropByOutputId = CropDatabaseAccessor.GetCropByOutputId(food.JDJGFAACPFC());
				if (!Object.op_Implicit((Object)(object)cropByOutputId) || cropByOutputId.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					EANNKOBIAID.Add(food);
				}
			}
		}
	}

	private void MMGAAALOIHD(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		IHMGLIPEHMD(ACNAHALFEBG);
	}

	public void HNCOOENAHDC(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		ingredientsTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			ingredientsTrends.Add(item);
		}
		CHNLADIFCGD(ACNAHALFEBG);
	}

	private void IHMGLIPEHMD(CropSeason ACNAHALFEBG)
	{
		List<Food> EANNKOBIAID = new List<Food>();
		if (!Application.isPlaying)
		{
			ItemDatabaseAccessor.GetInstance().SetUpDatabase();
			ShopDatabaseAccessor.SetUpDatabase();
			ShopDatabaseAccessor.CreateNewShopList(ShopDatabaseAccessor.GetShop(ShopType.Lia));
		}
		List<ShopItem> shopItems = ShopDatabaseAccessor.GetShop(ShopType.Lia).shopItems;
		HOAFGCLDIMM(shopItems, ref EANNKOBIAID, ACNAHALFEBG);
		if (!Application.isPlaying)
		{
			ShopDatabaseAccessor.CreateNewShopList(ShopDatabaseAccessor.GetShop(ShopType.Holly));
		}
		shopItems = ShopDatabaseAccessor.GetShop(ShopType.Holly).shopItems;
		HOAFGCLDIMM(shopItems, ref EANNKOBIAID, ACNAHALFEBG);
		int num = 0;
		while (ingredientsTrends.Count < 6 && EANNKOBIAID.Count > 0 && num < 200)
		{
			Food item = EANNKOBIAID.ElementAt(Random.Range(0, EANNKOBIAID.Count));
			if (!ingredientsTrends.Contains(item))
			{
				ingredientsTrends.Add(item);
			}
			EANNKOBIAID.Remove(item);
			num++;
		}
		if (num == 200)
		{
			Debug.LogError((object)("Not found ingredients for trends " + EANNKOBIAID.Count + " " + ingredientsTrends.Count));
		}
	}

	private void KBCMGCMGLDK(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		CHNLADIFCGD(ACNAHALFEBG);
	}

	private void BCFPHLCBFKP(List<ShopItem> CLMPHNFHKCJ, ref List<Food> EANNKOBIAID, CropSeason ACNAHALFEBG)
	{
		for (int i = 0; i < CLMPHNFHKCJ.Count; i++)
		{
			if (!Item.EKGNIODFJCO(CLMPHNFHKCJ[i].item, null) && !CLMPHNFHKCJ[i].item.excludedFromTrends && CLMPHNFHKCJ[i].item is Food food && !(food is Seed))
			{
				Crop crop = CropDatabaseAccessor.KGOFJNOINIB(food.ODENMDOJPLC(DAINLFIMLIH: false));
				if (!Object.op_Implicit((Object)(object)crop) || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					EANNKOBIAID.Add(food);
				}
			}
		}
	}

	public void LGNIAAGBFFM(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		ingredientsTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			ingredientsTrends.Add(item);
		}
		CHNLADIFCGD(ACNAHALFEBG);
	}

	private void LIPFAADEELP(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		CHNLADIFCGD(ACNAHALFEBG);
	}

	private void MFMHOEICNJP(CropSeason ACNAHALFEBG)
	{
		drinkTrends.Clear();
		AGIDNBPEOOP(ACNAHALFEBG);
	}

	private void PLPNPPPHMDK(CropSeason ACNAHALFEBG)
	{
		foodTrends.Clear();
		BKOMDIBEGDP(ACNAHALFEBG);
	}

	public void OMHDKIFEKIN(Season EECEKHKAAIH)
	{
		Debug.Log((object)("<color=#A87700>" + EECEKHKAAIH));
		CropSeason aCNAHALFEBG = SeasonManager.LCGFNOJPGJF(EECEKHKAAIH);
		MFPGLOFJBOJ(aCNAHALFEBG);
		LMMOENJCFPP(aCNAHALFEBG);
		KBCMGCMGLDK(aCNAHALFEBG);
	}

	private void LPDDAHICDKE(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.FMIDAFEGDCD().GetFoodRecipes()
			where r.ICAANDAHKDL(ACNAHALFEBG) && !r.output.item.excludedFromTrends
			select r).ToArray();
		int num = 0;
		while (foodTrends.Count < 7 && num < -100)
		{
			Item item = array[Random.Range(0, array.Length)].output.item;
			if (!foodTrends.Contains(item))
			{
				foodTrends.Add(item);
			}
			num += 0;
		}
	}

	private void KNKBLIEMAKD(CropSeason ACNAHALFEBG)
	{
		foodTrends.Clear();
		GGFJJOENIJM(ACNAHALFEBG);
	}

	public void NINLBIJBFMO(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		foodTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			foodTrends.Add(item);
		}
		LPDDAHICDKE(ACNAHALFEBG);
	}

	private void MNGAFBDCIAC(List<ShopItem> CLMPHNFHKCJ, ref List<Food> EANNKOBIAID, CropSeason ACNAHALFEBG)
	{
		for (int i = 0; i < CLMPHNFHKCJ.Count; i++)
		{
			if (!Item.EKMFELLJHFG(CLMPHNFHKCJ[i].item, null) && !CLMPHNFHKCJ[i].item.excludedFromTrends && CLMPHNFHKCJ[i].item is Food food && !(food is Seed))
			{
				Crop crop = CropDatabaseAccessor.IOEKKOLCEBD(food.ODENMDOJPLC());
				if (!Object.op_Implicit((Object)(object)crop) || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					EANNKOBIAID.Add(food);
				}
			}
		}
	}

	private void GGFJJOENIJM(CropSeason ACNAHALFEBG)
	{
		Recipe[] array = (from r in Trends.KNOKBLFFNLM().GetFoodRecipes()
			where r.ICAANDAHKDL(ACNAHALFEBG) && !r.output.item.excludedFromTrends
			select r).ToArray();
		int num = 0;
		while (foodTrends.Count < 5 && num < -41)
		{
			Item item = array[Random.Range(1, array.Length)].output.item;
			if (!foodTrends.Contains(item))
			{
				foodTrends.Add(item);
			}
			num += 0;
		}
	}

	public void JHFOBOBBKHG(CropSeason ACNAHALFEBG, HashSet<Item> AJOMICMACEJ)
	{
		drinkTrends.Clear();
		foreach (Item item in AJOMICMACEJ)
		{
			drinkTrends.Add(item);
		}
		CBIEPPKGGBB(ACNAHALFEBG);
	}

	private void CODHKFDNOPD(List<ShopItem> CLMPHNFHKCJ, ref List<Food> EANNKOBIAID, CropSeason ACNAHALFEBG)
	{
		for (int i = 1; i < CLMPHNFHKCJ.Count; i++)
		{
			if (!Item.GBMFCPGEJDK(CLMPHNFHKCJ[i].item, null) && !CLMPHNFHKCJ[i].item.excludedFromTrends && CLMPHNFHKCJ[i].item is Food food && !(food is Seed))
			{
				Crop crop = CropDatabaseAccessor.HLMHANHNNOB(food.CIGFGKKCPCK(DAINLFIMLIH: false));
				if (!Object.op_Implicit((Object)(object)crop) || crop.avaliableSeasons.HasFlag(ACNAHALFEBG))
				{
					EANNKOBIAID.Add(food);
				}
			}
		}
	}

	private void CKNLBMGNFGL(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		IHMGLIPEHMD(ACNAHALFEBG);
	}

	private void PFGOMHCHLPB(CropSeason ACNAHALFEBG)
	{
		ingredientsTrends.Clear();
		CHNLADIFCGD(ACNAHALFEBG);
	}
}
