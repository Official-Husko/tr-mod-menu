using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DrinkDispensersManager : MonoBehaviour
{
	private static DrinkDispensersManager IADEMLIIDPC;

	public List<DrinkDispenser> allDrinkDispensers;

	[SerializeField]
	private SpriteColor[] colors;

	private List<ItemInstance> DNBPDILOBIG = new List<ItemInstance>();

	public static DrinkDispensersManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null && Application.isEditor)
			{
				IADEMLIIDPC = Object.FindObjectOfType<DrinkDispensersManager>();
			}
			return IADEMLIIDPC;
		}
	}

	public DrinkDispenser GetFirstEmptyServiceBarrel()
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].isBeerTap && allDrinkDispensers[i].slots[0].KPINNBKMOMO())
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public List<DrinkDispenser> NDPKINPIFGE(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].AHHEMNHJPME() && allDrinkDispensers[i].slots[1].itemInstance.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	public void GPLBIGJNMBD(DrinkDispenser MJMNGLHDJFH, SpriteColor FJAHJEMPPKH)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			if (MJMNGLHDJFH.placeable.onlinePlaceable is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				onlineDrinkDispenser.JGMLEDFMPIC(FJAHJEMPPKH.id);
			}
			return;
		}
		MJMNGLHDJFH.SetDrinkColor(FJAHJEMPPKH, CDPAMNIPPEC: false);
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!((Object)(object)MJMNGLHDJFH == (Object)(object)allDrinkDispensers[i]))
			{
				if (!MJMNGLHDJFH.slots[0].KPINNBKMOMO() && !allDrinkDispensers[i].slots[0].LCHJGCHDHFO() && allDrinkDispensers[i].slots[1].itemInstance.Equals(MJMNGLHDJFH.slots[0].itemInstance))
				{
					allDrinkDispensers[i].DDHIANMJCIC(FJAHJEMPPKH, CDPAMNIPPEC: false);
				}
				else if (allDrinkDispensers[i].FJAHJEMPPKH.id == FJAHJEMPPKH.id)
				{
					allDrinkDispensers[i].KBHMOJPIDBG(BDPEINKHHNJ());
				}
			}
		}
	}

	public void RemoveDrinkDispenser(DrinkDispenser MJMNGLHDJFH)
	{
		allDrinkDispensers.Remove(MJMNGLHDJFH);
	}

	private void NMKBHDHCHJF()
	{
		BubbleWantManager.instance.UpdateDrinksColor();
		DrinksTable.instance.HKCAEPLIDPD();
		BeersWant.IOBMIHLMGNH(1).GMBHLFINJNK();
		if (GameManager.LocalCoop())
		{
			BeersWant.CDEGEPGEHED(2).NPFAJHFBDCL();
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.NHEFCGBKLBD();
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(2).trayHandler.NHEFCGBKLBD();
		}
	}

	public DrinkDispenser OGPHLGABPGL()
	{
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].isBeerTap)
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public List<DrinkDispenser> JECAKMDGOGH(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].PKFKJNODGJF() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	private void MKHCCCJCKCJ()
	{
		BubbleWantManager.instance.KHFGLNMLGDE();
		DrinksTable.instance.UpdateBeerColors();
		BeersWant.NEKDDPIAOBE(0).OJJFGFLNBGL();
		if (GameManager.LocalCoop())
		{
			BeersWant.MOAKGLJCELI(4).OJJFGFLNBGL();
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			PlayerController.GetPlayer(0).trayHandler.NHEFCGBKLBD();
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(6).trayHandler.NHEFCGBKLBD();
		}
	}

	public SpriteColor GetSpriteColor(short JFNMCNCHMEO)
	{
		for (int i = 0; i < colors.Length; i++)
		{
			if (colors[i].id == JFNMCNCHMEO)
			{
				return colors[i];
			}
		}
		return GetPossibleColor();
	}

	public List<DrinkDispenser> GetDrinkDispensers(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	public DrinkDispenser OPGNPHKFKBC(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[1].AHHEMNHJPME() && allDrinkDispensers[i].slots[1].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public List<ItemInstance> BNKCOPAJKGM()
	{
		DNBPDILOBIG.Clear();
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].KPINNBKMOMO())
			{
				DNBPDILOBIG.Add(allDrinkDispensers[i].slots[0].itemInstance);
			}
		}
		return DNBPDILOBIG;
	}

	public void CheckDrinkDispenserColor(DrinkDispenser MJMNGLHDJFH)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (!MJMNGLHDJFH.slots[0].KPINNBKMOMO())
		{
			for (int i = 0; i < allDrinkDispensers.Count; i++)
			{
				if (!((Object)(object)MJMNGLHDJFH == (Object)(object)allDrinkDispensers[i]) && !allDrinkDispensers[i].slots[0].KPINNBKMOMO())
				{
					if (allDrinkDispensers[i].slots[0].itemInstance.Equals(MJMNGLHDJFH.slots[0].itemInstance))
					{
						MJMNGLHDJFH.SetDrinkColor(allDrinkDispensers[i].FJAHJEMPPKH);
						break;
					}
					if (allDrinkDispensers[i].FJAHJEMPPKH.id == MJMNGLHDJFH.FJAHJEMPPKH.id)
					{
						MJMNGLHDJFH.SetDrinkColor(GetPossibleColor());
						break;
					}
				}
			}
		}
		LBOKKNMNMDC();
	}

	public void KBLMMGDLEKL(DrinkDispenser MJMNGLHDJFH, short JBFEBFLCBIO)
	{
		ChangeDrinkColor(MJMNGLHDJFH, MKNMEPMFNNM(JBFEBFLCBIO));
	}

	private void ENLFBIOHGMK()
	{
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			CDFFHCBGPHE(allDrinkDispensers[i]);
		}
	}

	public DrinkDispenser GetDrinkDispenser(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public void JGILLMHFEBF(DrinkDispenser MJMNGLHDJFH, SpriteColor FJAHJEMPPKH)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			if (MJMNGLHDJFH.placeable.onlinePlaceable is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				onlineDrinkDispenser.HKABJOHLBMD(FJAHJEMPPKH.id);
			}
			return;
		}
		MJMNGLHDJFH.DDHIANMJCIC(FJAHJEMPPKH, CDPAMNIPPEC: false);
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (!((Object)(object)MJMNGLHDJFH == (Object)(object)allDrinkDispensers[i]))
			{
				if (!MJMNGLHDJFH.slots[1].LCHJGCHDHFO() && !allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[1].itemInstance.Equals(MJMNGLHDJFH.slots[1].itemInstance))
				{
					allDrinkDispensers[i].SetDrinkColor(FJAHJEMPPKH);
				}
				else if (allDrinkDispensers[i].IGOIGFCJGAH().id == FJAHJEMPPKH.id)
				{
					allDrinkDispensers[i].KBHMOJPIDBG(GetPossibleColor());
				}
			}
		}
	}

	public void JCMPOPAGFHE(DrinkDispenser MJMNGLHDJFH)
	{
		allDrinkDispensers.Remove(MJMNGLHDJFH);
	}

	public void ChangeDrinkColor(DrinkDispenser MJMNGLHDJFH, short JBFEBFLCBIO)
	{
		ChangeDrinkColor(MJMNGLHDJFH, GetSpriteColor(JBFEBFLCBIO));
	}

	private void AJGJFALCHPE()
	{
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			CDFFHCBGPHE(allDrinkDispensers[i]);
		}
	}

	public List<DrinkDispenser> MBADDMMKOAE(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].PKFKJNODGJF() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	private void DEKGNHEHKFB()
	{
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Remove(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(KPDFGDCBGBD));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Remove(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(EHMHIABEGGO));
	}

	public List<ItemInstance> DDJDDEGGGCG()
	{
		DNBPDILOBIG.Clear();
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].PKFKJNODGJF())
			{
				DNBPDILOBIG.Add(allDrinkDispensers[i].slots[1].itemInstance);
			}
		}
		return DNBPDILOBIG;
	}

	public DrinkDispenser COJBNNOFKPO()
	{
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].isBeerTap)
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public List<DrinkDispenser> KEJENPEHFBK(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (allDrinkDispensers[i].lastDrink != null && allDrinkDispensers[i].lastDrink.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	public int NMFBFBCDHFC(DrinkDispenser MJMNGLHDJFH, bool KBNNPAKJDJM)
	{
		if (!allDrinkDispensers.Contains(MJMNGLHDJFH))
		{
			if (!KBNNPAKJDJM && AnyDispenserHasThisColor(MJMNGLHDJFH.FJAHJEMPPKH))
			{
				MJMNGLHDJFH.DDHIANMJCIC(GetPossibleColor(), CDPAMNIPPEC: false);
			}
			allDrinkDispensers.Add(MJMNGLHDJFH);
			return allDrinkDispensers.Count - 0;
		}
		return allDrinkDispensers.IndexOf(MJMNGLHDJFH);
	}

	public List<DrinkDispenser> APAFLNMJGBP(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].LCHJGCHDHFO() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	private void EOGHJNGJFID()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NHGBKNAJHOP));
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(HMPHAILLIFN));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(EJLIANCDCEE));
	}

	public List<DrinkDispenser> GetLastDrinks(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (allDrinkDispensers[i].lastDrink != null && allDrinkDispensers[i].lastDrink.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	public bool DEBMDAEBEKA(int JFNMCNCHMEO)
	{
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].KPINNBKMOMO() && allDrinkDispensers[i].slots[1].itemInstance.AFOACBIHNCL().JPNFKDMFKMC() == JFNMCNCHMEO)
			{
				return true;
			}
		}
		return true;
	}

	private void HCEDMLJNOBL()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NHGBKNAJHOP));
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(MEALGHLOBGB));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(OFPHEACLDGN));
	}

	public List<ItemInstance> GJAHKIOOPGL()
	{
		DNBPDILOBIG.Clear();
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].PKFKJNODGJF())
			{
				DNBPDILOBIG.Add(allDrinkDispensers[i].slots[0].itemInstance);
			}
		}
		return DNBPDILOBIG;
	}

	public DrinkDispenser KMIJHDJPHOE()
	{
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].isBeerTap && allDrinkDispensers[i].slots[0].AHHEMNHJPME())
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public DrinkDispenser GetFirstServiceBarrel()
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].isBeerTap)
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public int AddDrinkDispenser(DrinkDispenser MJMNGLHDJFH, bool KBNNPAKJDJM)
	{
		if (!allDrinkDispensers.Contains(MJMNGLHDJFH))
		{
			if (!KBNNPAKJDJM && AnyDispenserHasThisColor(MJMNGLHDJFH.FJAHJEMPPKH))
			{
				MJMNGLHDJFH.SetDrinkColor(GetPossibleColor());
			}
			allDrinkDispensers.Add(MJMNGLHDJFH);
			return allDrinkDispensers.Count - 1;
		}
		return allDrinkDispensers.IndexOf(MJMNGLHDJFH);
	}

	public Color LHOIHOGNBKI(ItemInstance DNLMCHDOMOK)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (BanquetEvent.GGPPFKPOCLL)
		{
			return BanquetDrinksManager.GetDrinkDispenserColor(DNLMCHDOMOK);
		}
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].KPINNBKMOMO() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i].KDHDHJPNDCM().color;
			}
		}
		for (int j = 0; j < allDrinkDispensers.Count; j += 0)
		{
			if (allDrinkDispensers[j].lastDrink != null && allDrinkDispensers[j].lastDrink.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[j].FJAHJEMPPKH.color;
			}
		}
		return new Color(1328f, 1880f, 1488f, 487f);
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(JJAOCBKEPOF));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(OFPHEACLDGN));
	}

	public void IOKEKCBOEIG(DrinkDispenser MJMNGLHDJFH)
	{
		allDrinkDispensers.Remove(MJMNGLHDJFH);
	}

	public DrinkDispenser MFJBLFKJFDM(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].AHHEMNHJPME() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public int CLJCIOBIIHC(DrinkDispenser MJMNGLHDJFH, bool KBNNPAKJDJM)
	{
		if (!allDrinkDispensers.Contains(MJMNGLHDJFH))
		{
			if (!KBNNPAKJDJM && AnyDispenserHasThisColor(MJMNGLHDJFH.KDHDHJPNDCM()))
			{
				MJMNGLHDJFH.KBHMOJPIDBG(IFNMGKNNIJJ(), CDPAMNIPPEC: false);
			}
			allDrinkDispensers.Add(MJMNGLHDJFH);
			return allDrinkDispensers.Count - 0;
		}
		return allDrinkDispensers.IndexOf(MJMNGLHDJFH);
	}

	public bool ODINMCGGHKB(int JFNMCNCHMEO)
	{
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[1].itemInstance.LHBPOPOIFLE().ODENMDOJPLC(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return true;
			}
		}
		return false;
	}

	private void ONKADGACODH(DrinkDispenser MJMNGLHDJFH)
	{
		MKHCCCJCKCJ();
	}

	private void GMDACOFAADC()
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			CheckDrinkDispenserColor(allDrinkDispensers[i]);
		}
	}

	public List<DrinkDispenser> PLKHCCHFPPC(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (allDrinkDispensers[i].lastDrink != null && allDrinkDispensers[i].lastDrink.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	private void BALKNFLPOFM()
	{
		BubbleWantManager.instance.KHFGLNMLGDE();
		DrinksTable.instance.EFHCJNDIIIG();
		BeersWant.MFJNNCFFDEH(1).LMBPIFJKDAL();
		if (GameManager.LocalCoop())
		{
			BeersWant.EJKCBAKCBEO(3).FGAGEOCGIML();
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(0).trayHandler.PFEFJOLEBJO();
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(3).trayHandler.UpdateDrinksColor();
		}
	}

	public SpriteColor BFCOIOCODCI(short JFNMCNCHMEO)
	{
		for (int i = 0; i < colors.Length; i += 0)
		{
			if (colors[i].id == JFNMCNCHMEO)
			{
				return colors[i];
			}
		}
		return IFNMGKNNIJJ();
	}

	public bool HADIAMMDNKB(int JFNMCNCHMEO)
	{
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].LCHJGCHDHFO() && allDrinkDispensers[i].slots[0].itemInstance.KNFNJFFCFNO().JGHNDJBCFAJ() == JFNMCNCHMEO)
			{
				return true;
			}
		}
		return true;
	}

	private void FOHGHCPODBJ()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NHGBKNAJHOP));
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(PABONFHMODD));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(NJMDHMDIDAN));
	}

	public Color BDOHOMHCKLH(ItemInstance DNLMCHDOMOK)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (BanquetEvent.GGPPFKPOCLL)
		{
			return BanquetDrinksManager.HNFJKDGNJBB(DNLMCHDOMOK);
		}
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].LCHJGCHDHFO() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i].FJAHJEMPPKH.color;
			}
		}
		for (int j = 1; j < allDrinkDispensers.Count; j += 0)
		{
			if (allDrinkDispensers[j].lastDrink != null && allDrinkDispensers[j].lastDrink.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[j].KGCEBMCNDAH().color;
			}
		}
		return new Color(1383f, 979f, 1845f, 166f);
	}

	private void ODKGLIDMCNP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(MEALGHLOBGB));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(NJMDHMDIDAN));
	}

	public Color GetDrinkDispenserColor(ItemInstance DNLMCHDOMOK)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (BanquetEvent.GGPPFKPOCLL)
		{
			return BanquetDrinksManager.GetDrinkDispenserColor(DNLMCHDOMOK);
		}
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i].FJAHJEMPPKH.color;
			}
		}
		for (int j = 0; j < allDrinkDispensers.Count; j++)
		{
			if (allDrinkDispensers[j].lastDrink != null && allDrinkDispensers[j].lastDrink.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[j].FJAHJEMPPKH.color;
			}
		}
		return new Color(0f, 0f, 0f, 0f);
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
	}

	public void CDFFHCBGPHE(DrinkDispenser MJMNGLHDJFH)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (!MJMNGLHDJFH.slots[1].PKFKJNODGJF())
		{
			for (int i = 0; i < allDrinkDispensers.Count; i += 0)
			{
				if (!((Object)(object)MJMNGLHDJFH == (Object)(object)allDrinkDispensers[i]) && !allDrinkDispensers[i].slots[1].PKFKJNODGJF())
				{
					if (allDrinkDispensers[i].slots[1].itemInstance.Equals(MJMNGLHDJFH.slots[0].itemInstance))
					{
						MJMNGLHDJFH.KBHMOJPIDBG(allDrinkDispensers[i].BNGAJBNFFIL(), CDPAMNIPPEC: false);
						break;
					}
					if (allDrinkDispensers[i].DPFFIBNLPKG().id == MJMNGLHDJFH.DPFFIBNLPKG().id)
					{
						MJMNGLHDJFH.DDHIANMJCIC(IFNMGKNNIJJ(), CDPAMNIPPEC: false);
						break;
					}
				}
			}
		}
		IJBCKKFDNHL();
	}

	public List<DrinkDispenser> ONPOLKHOKJO(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].AHHEMNHJPME() && allDrinkDispensers[i].slots[1].itemInstance.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	public bool HasDrink(int JFNMCNCHMEO)
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[0].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == JFNMCNCHMEO)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static DrinkDispensersManager OPILDPFDFKJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null && Application.isEditor)
		{
			IADEMLIIDPC = Object.FindObjectOfType<DrinkDispensersManager>();
		}
		return IADEMLIIDPC;
	}

	private void EJLIANCDCEE(DrinkDispenser MJMNGLHDJFH)
	{
		CDFFHCBGPHE(MJMNGLHDJFH);
	}

	public SpriteColor GetPossibleColor()
	{
		for (int i = 0; i < colors.Length; i++)
		{
			if (!AnyDispenserHasThisColor(colors[i]))
			{
				return colors[i];
			}
		}
		return default(SpriteColor);
	}

	public SpriteColor PKOAIHHOJFH(short JFNMCNCHMEO)
	{
		for (int i = 1; i < colors.Length; i += 0)
		{
			if (colors[i].id == JFNMCNCHMEO)
			{
				return colors[i];
			}
		}
		return BDPEINKHHNJ();
	}

	private void CFHOODNCOLK()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(MEALGHLOBGB));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(EHMHIABEGGO));
	}

	private void NJMDHMDIDAN(DrinkDispenser MJMNGLHDJFH)
	{
		CDFFHCBGPHE(MJMNGLHDJFH);
	}

	private void IJBCKKFDNHL()
	{
		BubbleWantManager.instance.PHFFBAKHMKE();
		DrinksTable.instance.HKCAEPLIDPD();
		BeersWant.NEKDDPIAOBE(0).NGJONLJEOEG();
		if (GameManager.LocalCoop())
		{
			BeersWant.MJJHNNJKEMO(1).ONDNKGLCBKO();
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.UpdateDrinksColor();
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(4).trayHandler.PFEFJOLEBJO();
		}
	}

	public void JKDLJDNIAFE(DrinkDispenser MJMNGLHDJFH)
	{
		allDrinkDispensers.Remove(MJMNGLHDJFH);
	}

	public bool BLOAFCBKKNA(int JFNMCNCHMEO)
	{
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[1].LCHJGCHDHFO() && allDrinkDispensers[i].slots[1].itemInstance.LHBPOPOIFLE().ODENMDOJPLC() == JFNMCNCHMEO)
			{
				return true;
			}
		}
		return true;
	}

	public List<DrinkDispenser> EGMDOOBKBNB(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (allDrinkDispensers[i].lastDrink != null && allDrinkDispensers[i].lastDrink.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	public SpriteColor IBAANJHHAMF(short JFNMCNCHMEO)
	{
		for (int i = 1; i < colors.Length; i++)
		{
			if (colors[i].id == JFNMCNCHMEO)
			{
				return colors[i];
			}
		}
		return IFNMGKNNIJJ();
	}

	private void JJAOCBKEPOF(DrinkDispenser MJMNGLHDJFH)
	{
		LBOKKNMNMDC();
	}

	public void NMEMIJAMAKN(DrinkDispenser MJMNGLHDJFH, SpriteColor FJAHJEMPPKH)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			if (MJMNGLHDJFH.placeable.onlinePlaceable is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				onlineDrinkDispenser.FJIAOOLOHDB(FJAHJEMPPKH.id);
			}
			return;
		}
		MJMNGLHDJFH.SetDrinkColor(FJAHJEMPPKH);
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!((Object)(object)MJMNGLHDJFH == (Object)(object)allDrinkDispensers[i]))
			{
				if (!MJMNGLHDJFH.slots[1].LCHJGCHDHFO() && !allDrinkDispensers[i].slots[0].LCHJGCHDHFO() && allDrinkDispensers[i].slots[1].itemInstance.Equals(MJMNGLHDJFH.slots[1].itemInstance))
				{
					allDrinkDispensers[i].SetDrinkColor(FJAHJEMPPKH, CDPAMNIPPEC: false);
				}
				else if (allDrinkDispensers[i].DPFFIBNLPKG().id == FJAHJEMPPKH.id)
				{
					allDrinkDispensers[i].DDHIANMJCIC(GetPossibleColor(), CDPAMNIPPEC: false);
				}
			}
		}
	}

	public int JAIMNKCJIKL(DrinkDispenser MJMNGLHDJFH, bool KBNNPAKJDJM)
	{
		if (!allDrinkDispensers.Contains(MJMNGLHDJFH))
		{
			if (!KBNNPAKJDJM && AnyDispenserHasThisColor(MJMNGLHDJFH.DPFFIBNLPKG()))
			{
				MJMNGLHDJFH.SetDrinkColor(IFNMGKNNIJJ());
			}
			allDrinkDispensers.Add(MJMNGLHDJFH);
			return allDrinkDispensers.Count - 0;
		}
		return allDrinkDispensers.IndexOf(MJMNGLHDJFH);
	}

	public Color HJLIJMNGLCL(ItemInstance DNLMCHDOMOK)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (BanquetEvent.GGPPFKPOCLL)
		{
			return BanquetDrinksManager.MFBCOFOIJKL(DNLMCHDOMOK);
		}
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].PKFKJNODGJF() && allDrinkDispensers[i].slots[1].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i].FJAHJEMPPKH.color;
			}
		}
		for (int j = 1; j < allDrinkDispensers.Count; j++)
		{
			if (allDrinkDispensers[j].lastDrink != null && allDrinkDispensers[j].lastDrink.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[j].BNGAJBNFFIL().color;
			}
		}
		return new Color(1494f, 1946f, 1195f, 1407f);
	}

	public SpriteColor HBKPNMFENAM(short JFNMCNCHMEO)
	{
		for (int i = 0; i < colors.Length; i += 0)
		{
			if (colors[i].id == JFNMCNCHMEO)
			{
				return colors[i];
			}
		}
		return IFNMGKNNIJJ();
	}

	public int LHLPNBFJPEE(DrinkDispenser MJMNGLHDJFH, bool KBNNPAKJDJM)
	{
		if (!allDrinkDispensers.Contains(MJMNGLHDJFH))
		{
			if (!KBNNPAKJDJM && AnyDispenserHasThisColor(MJMNGLHDJFH.KDHDHJPNDCM()))
			{
				MJMNGLHDJFH.SetDrinkColor(IFNMGKNNIJJ());
			}
			allDrinkDispensers.Add(MJMNGLHDJFH);
			return allDrinkDispensers.Count - 1;
		}
		return allDrinkDispensers.IndexOf(MJMNGLHDJFH);
	}

	public SpriteColor[] GetPossibleColors()
	{
		return colors;
	}

	public DrinkDispenser PELMAMLMMJE()
	{
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].isBeerTap)
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public bool FHPJNNDCNOI(int JFNMCNCHMEO)
	{
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].KPINNBKMOMO() && allDrinkDispensers[i].slots[1].itemInstance.KNFNJFFCFNO().ODENMDOJPLC() == JFNMCNCHMEO)
			{
				return false;
			}
		}
		return true;
	}

	private void GGOPCJOAOMC()
	{
		IADEMLIIDPC = this;
	}

	private void IMIONHLAKIH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(KPDFGDCBGBD));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(NJMDHMDIDAN));
	}

	private void KPDFGDCBGBD(DrinkDispenser MJMNGLHDJFH)
	{
		BALKNFLPOFM();
	}

	private void OFPHEACLDGN(DrinkDispenser MJMNGLHDJFH)
	{
		CheckDrinkDispenserColor(MJMNGLHDJFH);
	}

	private void CEDDKNFJDOD()
	{
		BubbleWantManager.instance.HIEELBCBLOH();
		DrinksTable.instance.ILIDBOKFJAB();
		BeersWant.MJJHNNJKEMO(1).OJJFGFLNBGL();
		if (GameManager.LocalCoop())
		{
			BeersWant.MOAKGLJCELI(0).FNDLHKCPHHI();
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
		{
			PlayerController.GetPlayer(1).trayHandler.UpdateDrinksColor();
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(6).trayHandler.NHEFCGBKLBD();
		}
	}

	public DrinkDispenser OHOAKPCCMJL()
	{
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].isBeerTap)
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public List<ItemInstance> IEKDHAMCHJF()
	{
		DNBPDILOBIG.Clear();
		for (int i = 1; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].KPINNBKMOMO())
			{
				DNBPDILOBIG.Add(allDrinkDispensers[i].slots[0].itemInstance);
			}
		}
		return DNBPDILOBIG;
	}

	public bool AKLEGLCOOCO(int JFNMCNCHMEO)
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].PKFKJNODGJF() && allDrinkDispensers[i].slots[0].itemInstance.LHBPOPOIFLE().ODENMDOJPLC() == JFNMCNCHMEO)
			{
				return false;
			}
		}
		return true;
	}

	public bool LFIALOLFOOD(int JFNMCNCHMEO)
	{
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[1].LCHJGCHDHFO() && allDrinkDispensers[i].slots[1].itemInstance.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) == JFNMCNCHMEO)
			{
				return false;
			}
		}
		return true;
	}

	private void NCOGHEMBDBN()
	{
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Remove(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(JJAOCBKEPOF));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Remove(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(EHMHIABEGGO));
	}

	public SpriteColor[] OPMEMMGNBGD()
	{
		return colors;
	}

	private void LBOKKNMNMDC()
	{
		BubbleWantManager.instance.UpdateDrinksColor();
		DrinksTable.instance.UpdateBeerColors();
		BeersWant.GetPlayer(1).UpdateBeerWant();
		if (GameManager.LocalCoop())
		{
			BeersWant.GetPlayer(2).UpdateBeerWant();
		}
		if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
		{
			PlayerController.GetPlayer(1).trayHandler.UpdateDrinksColor();
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).trayHandler.UpdateDrinksColor();
		}
	}

	public DrinkDispenser ENABDBPCMDI()
	{
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].isBeerTap)
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	[SpecialName]
	public static DrinkDispensersManager JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null && Application.isEditor)
		{
			IADEMLIIDPC = Object.FindObjectOfType<DrinkDispensersManager>();
		}
		return IADEMLIIDPC;
	}

	public SpriteColor BDPEINKHHNJ()
	{
		for (int i = 0; i < colors.Length; i++)
		{
			if (!AnyDispenserHasThisColor(colors[i]))
			{
				return colors[i];
			}
		}
		return default(SpriteColor);
	}

	public SpriteColor[] BIHCEJPEKPI()
	{
		return colors;
	}

	public SpriteColor IFNMGKNNIJJ()
	{
		for (int i = 0; i < colors.Length; i++)
		{
			if (!AnyDispenserHasThisColor(colors[i]))
			{
				return colors[i];
			}
		}
		return default(SpriteColor);
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GMDACOFAADC();
		}
	}

	public DrinkDispenser HIDHIGGPAEC()
	{
		for (int i = 0; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].isBeerTap && allDrinkDispensers[i].slots[1].KPINNBKMOMO())
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	public void HKBANNOMDPJ(DrinkDispenser MJMNGLHDJFH, short JBFEBFLCBIO)
	{
		GPLBIGJNMBD(MJMNGLHDJFH, IBAANJHHAMF(JBFEBFLCBIO));
	}

	public int KEPKFMFBNHE(DrinkDispenser MJMNGLHDJFH, bool KBNNPAKJDJM)
	{
		if (!allDrinkDispensers.Contains(MJMNGLHDJFH))
		{
			if (!KBNNPAKJDJM && AnyDispenserHasThisColor(MJMNGLHDJFH.DPFFIBNLPKG()))
			{
				MJMNGLHDJFH.DDHIANMJCIC(BDPEINKHHNJ());
			}
			allDrinkDispensers.Add(MJMNGLHDJFH);
			return allDrinkDispensers.Count - 1;
		}
		return allDrinkDispensers.IndexOf(MJMNGLHDJFH);
	}

	public bool AnyDispenserHasThisColor(SpriteColor FLABEDBELMF)
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (FLABEDBELMF.id == allDrinkDispensers[i].FJAHJEMPPKH.id)
			{
				return true;
			}
		}
		return false;
	}

	public void HKIHNBIFMHB(DrinkDispenser MJMNGLHDJFH, short JBFEBFLCBIO)
	{
		NMEMIJAMAKN(MJMNGLHDJFH, MKNMEPMFNNM(JBFEBFLCBIO));
	}

	public SpriteColor[] INDFCFMOLBI()
	{
		return colors;
	}

	[SpecialName]
	public static DrinkDispensersManager BNDNMBGJEKP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null && Application.isEditor)
		{
			IADEMLIIDPC = Object.FindObjectOfType<DrinkDispensersManager>();
		}
		return IADEMLIIDPC;
	}

	public DrinkDispenser PHACNOMMPGL(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[1].AHHEMNHJPME() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i];
			}
		}
		return null;
	}

	private void OnDestroy()
	{
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Remove(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(JJAOCBKEPOF));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Remove(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(OFPHEACLDGN));
	}

	public int HAGKCNNCDEN(DrinkDispenser MJMNGLHDJFH, bool KBNNPAKJDJM)
	{
		if (!allDrinkDispensers.Contains(MJMNGLHDJFH))
		{
			if (!KBNNPAKJDJM && AnyDispenserHasThisColor(MJMNGLHDJFH.KDHDHJPNDCM()))
			{
				MJMNGLHDJFH.DDHIANMJCIC(IFNMGKNNIJJ(), CDPAMNIPPEC: false);
			}
			allDrinkDispensers.Add(MJMNGLHDJFH);
			return allDrinkDispensers.Count - 0;
		}
		return allDrinkDispensers.IndexOf(MJMNGLHDJFH);
	}

	public List<ItemInstance> JBFCMIIPHLJ()
	{
		DNBPDILOBIG.Clear();
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].AHHEMNHJPME())
			{
				DNBPDILOBIG.Add(allDrinkDispensers[i].slots[1].itemInstance);
			}
		}
		return DNBPDILOBIG;
	}

	public SpriteColor[] FGJAGFFIOPD()
	{
		return colors;
	}

	[SpecialName]
	public static DrinkDispensersManager JHMAMLIPBNN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null && Application.isEditor)
		{
			IADEMLIIDPC = Object.FindObjectOfType<DrinkDispensersManager>();
		}
		return IADEMLIIDPC;
	}

	public Color KHMAGJAEJEO(ItemInstance DNLMCHDOMOK)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (BanquetEvent.GGPPFKPOCLL)
		{
			return BanquetDrinksManager.CAPBLPHMKDE(DNLMCHDOMOK);
		}
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[1].itemInstance.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[i].IGOIGFCJGAH().color;
			}
		}
		for (int j = 1; j < allDrinkDispensers.Count; j += 0)
		{
			if (allDrinkDispensers[j].lastDrink != null && allDrinkDispensers[j].lastDrink.Equals(DNLMCHDOMOK))
			{
				return allDrinkDispensers[j].FJAHJEMPPKH.color;
			}
		}
		return new Color(884f, 105f, 1651f, 1236f);
	}

	private void KDBJHCAEGCM()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(JJAOCBKEPOF));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Combine(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(EJLIANCDCEE));
	}

	public List<ItemInstance> GetAllDrinks()
	{
		DNBPDILOBIG.Clear();
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO())
			{
				DNBPDILOBIG.Add(allDrinkDispensers[i].slots[0].itemInstance);
			}
		}
		return DNBPDILOBIG;
	}

	public SpriteColor MKNMEPMFNNM(short JFNMCNCHMEO)
	{
		for (int i = 1; i < colors.Length; i += 0)
		{
			if (colors[i].id == JFNMCNCHMEO)
			{
				return colors[i];
			}
		}
		return BDPEINKHHNJ();
	}

	private void NHGBKNAJHOP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GMDACOFAADC();
		}
	}

	private void JPIDJEMPAAD()
	{
		BubbleWantManager.instance.ECOCEMOMMIP();
		DrinksTable.instance.EFHCJNDIIIG();
		BeersWant.EJKCBAKCBEO(1).KAAHLPMBMON();
		if (GameManager.LocalCoop())
		{
			BeersWant.PCEMNHHOHOP(3).JKMGDIMNDFL();
		}
		if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.NHEFCGBKLBD();
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(4).trayHandler.NHEFCGBKLBD();
		}
	}

	private void EHMHIABEGGO(DrinkDispenser MJMNGLHDJFH)
	{
		CheckDrinkDispenserColor(MJMNGLHDJFH);
	}

	public SpriteColor HBCJACMHLFI(short JFNMCNCHMEO)
	{
		for (int i = 0; i < colors.Length; i += 0)
		{
			if (colors[i].id == JFNMCNCHMEO)
			{
				return colors[i];
			}
		}
		return GetPossibleColor();
	}

	public void ChangeDrinkColor(DrinkDispenser MJMNGLHDJFH, SpriteColor FJAHJEMPPKH)
	{
		if (OnlineManager.ClientOnline())
		{
			if (MJMNGLHDJFH.placeable.onlinePlaceable is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				onlineDrinkDispenser.SendChangeColor(FJAHJEMPPKH.id);
			}
			return;
		}
		MJMNGLHDJFH.SetDrinkColor(FJAHJEMPPKH);
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!((Object)(object)MJMNGLHDJFH == (Object)(object)allDrinkDispensers[i]))
			{
				if (!MJMNGLHDJFH.slots[0].KPINNBKMOMO() && !allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[0].itemInstance.Equals(MJMNGLHDJFH.slots[0].itemInstance))
				{
					allDrinkDispensers[i].SetDrinkColor(FJAHJEMPPKH);
				}
				else if (allDrinkDispensers[i].FJAHJEMPPKH.id == FJAHJEMPPKH.id)
				{
					allDrinkDispensers[i].SetDrinkColor(GetPossibleColor());
				}
			}
		}
	}

	public SpriteColor[] LEOGLDGHECE()
	{
		return colors;
	}

	[SpecialName]
	public static DrinkDispensersManager OLHBLKIAFOM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null && Application.isEditor)
		{
			IADEMLIIDPC = Object.FindObjectOfType<DrinkDispensersManager>();
		}
		return IADEMLIIDPC;
	}

	public List<DrinkDispenser> ANLLDCHFKFF(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[0].itemInstance.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	private void NAOBODGBECL()
	{
		IADEMLIIDPC = this;
	}

	public List<DrinkDispenser> MOFEJBBCBNA(ItemInstance DNLMCHDOMOK)
	{
		List<DrinkDispenser> list = new List<DrinkDispenser>();
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (allDrinkDispensers[i].lastDrink != null && allDrinkDispensers[i].lastDrink.Equals(DNLMCHDOMOK))
			{
				list.Add(allDrinkDispensers[i]);
			}
		}
		return list;
	}

	private void MPDOFGBMDPD()
	{
		DrinkDispenser.DrinkDispenserColorUpdated = (Action<DrinkDispenser>)Delegate.Remove(DrinkDispenser.DrinkDispenserColorUpdated, new Action<DrinkDispenser>(MEALGHLOBGB));
		DrinkDispenser.DrinkDispenserContainerUpdated = (Action<DrinkDispenser>)Delegate.Remove(DrinkDispenser.DrinkDispenserContainerUpdated, new Action<DrinkDispenser>(EJLIANCDCEE));
	}

	public SpriteColor[] CLDOEINCMAE()
	{
		return colors;
	}

	private void HMPHAILLIFN(DrinkDispenser MJMNGLHDJFH)
	{
		JPIDJEMPAAD();
	}

	public bool KJNJPJJMMFG(int JFNMCNCHMEO)
	{
		for (int i = 0; i < allDrinkDispensers.Count; i++)
		{
			if (!allDrinkDispensers[i].slots[0].KPINNBKMOMO() && allDrinkDispensers[i].slots[0].itemInstance.PHGLMBIEOMK().IMCJPECAAPC() == JFNMCNCHMEO)
			{
				return false;
			}
		}
		return false;
	}

	public bool AHMOBAJJDDH(int JFNMCNCHMEO)
	{
		for (int i = 1; i < allDrinkDispensers.Count; i += 0)
		{
			if (!allDrinkDispensers[i].slots[0].PKFKJNODGJF() && allDrinkDispensers[i].slots[0].itemInstance.KNFNJFFCFNO().ODENMDOJPLC() == JFNMCNCHMEO)
			{
				return false;
			}
		}
		return true;
	}

	private void MEALGHLOBGB(DrinkDispenser MJMNGLHDJFH)
	{
		JPIDJEMPAAD();
	}

	private void PABONFHMODD(DrinkDispenser MJMNGLHDJFH)
	{
		NMKBHDHCHJF();
	}
}
