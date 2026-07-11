using System;
using System.Collections.Generic;

[Serializable]
public class ItemInstancesAmountOnline : IOnlineSerializable
{
	public ItemInstanceAmountOnline<ItemInstanceMessage>[] itemInstancesAmount;

	public ItemInstanceAmountOnline<BirdInstanceMessage>[] birdInstancesAmount;

	public ItemInstanceAmountOnline<PhaseItemInstanceMessage>[] phaseInstancesAmount;

	public ItemInstanceAmountOnline<FoodInstanceMessage>[] foodInstancesAmount;

	public ItemInstanceAmountOnline<AnimalInstanceMessage>[] animalInstancesAmount;

	public ItemInstanceAmount[] IEEFFOHNEDD()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] MABFDGDBBBL()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] GAJBMNDFJAE()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] CDCBONDBCAM()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] BEAAGIGACOG()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] CHPABIOLOMP()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] ELAFEDCCLPL()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] ANKHKBLFNLG()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] GLLPNNEHELJ()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] BNKFDLAACEC()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	private void IDHPJLANMKA<T>(ItemInstanceAmount[] PGBEEGPOINO, ItemInstanceAmountOnline<T>[] FNEHIAGFAOF) where T : ItemInstanceMessage, new()
	{
		for (int i = 0; i < FNEHIAGFAOF.Length; i++)
		{
			PGBEEGPOINO[FNEHIAGFAOF[i].index] = new ItemInstanceAmount(FNEHIAGFAOF[i].itemInstanceOnline.ANMBPDJLNFN(), FNEHIAGFAOF[i].amount);
		}
	}

	public ItemInstancesAmountOnline(List<ItemInstanceAmount> LMPEMAFJBEL)
	{
		List<ItemInstanceAmountOnline<BirdInstanceMessage>> list = new List<ItemInstanceAmountOnline<BirdInstanceMessage>>();
		List<ItemInstanceAmountOnline<ItemInstanceMessage>> list2 = new List<ItemInstanceAmountOnline<ItemInstanceMessage>>();
		List<ItemInstanceAmountOnline<PhaseItemInstanceMessage>> list3 = new List<ItemInstanceAmountOnline<PhaseItemInstanceMessage>>();
		List<ItemInstanceAmountOnline<FoodInstanceMessage>> list4 = new List<ItemInstanceAmountOnline<FoodInstanceMessage>>();
		List<ItemInstanceAmountOnline<AnimalInstanceMessage>> list5 = new List<ItemInstanceAmountOnline<AnimalInstanceMessage>>();
		for (int i = 0; i < LMPEMAFJBEL.Count; i++)
		{
			if (LMPEMAFJBEL[i].itemInstance is BirdInstance)
			{
				list.Add(new ItemInstanceAmountOnline<BirdInstanceMessage>(i, LMPEMAFJBEL[i]));
			}
			else if (LMPEMAFJBEL[i].itemInstance is PhaseItemInstance)
			{
				list3.Add(new ItemInstanceAmountOnline<PhaseItemInstanceMessage>(i, LMPEMAFJBEL[i]));
			}
			else if (LMPEMAFJBEL[i].itemInstance is FoodInstance)
			{
				list4.Add(new ItemInstanceAmountOnline<FoodInstanceMessage>(i, LMPEMAFJBEL[i]));
			}
			else if (LMPEMAFJBEL[i].itemInstance is AnimalInstance)
			{
				list5.Add(new ItemInstanceAmountOnline<AnimalInstanceMessage>(i, LMPEMAFJBEL[i]));
			}
			else
			{
				list2.Add(new ItemInstanceAmountOnline<ItemInstanceMessage>(i, LMPEMAFJBEL[i]));
			}
		}
		birdInstancesAmount = list.ToArray();
		itemInstancesAmount = list2.ToArray();
		phaseInstancesAmount = list3.ToArray();
		foodInstancesAmount = list4.ToArray();
		animalInstancesAmount = list5.ToArray();
	}

	public ItemInstanceAmount[] JABGBPKPMOC()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] BFHGEIIGLNJ()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] KCCJIANLPLC()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] KIHHKCLGNJF()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] JHMLFAOIEBO()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] KONPCLAKDEO()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] PLEMLJLFCFM()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] IFPNCCLJPDN()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] DMJDBIOPMBI()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] GBJHMALHOED()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] PCHDDJDEDOM()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] LGGHICBGNOC()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] BMJCHEINLID()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] LBIJOGIGNLE()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] DIHHAIBCADB()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] BELHKALEMMD()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] LLNDJDPCDCA()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] AJDACJJKHIC()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] MAPGELMOHBC()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] HKNNLKLOGGF()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] LKDGINKDKKE()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] CCKNOPFGBLP()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}

	public ItemInstanceAmount[] IDHHMLHDMCA()
	{
		ItemInstanceAmount[] array = new ItemInstanceAmount[birdInstancesAmount.Length + itemInstancesAmount.Length + phaseInstancesAmount.Length + foodInstancesAmount.Length + animalInstancesAmount.Length];
		IDHPJLANMKA(array, birdInstancesAmount);
		IDHPJLANMKA(array, itemInstancesAmount);
		IDHPJLANMKA(array, phaseInstancesAmount);
		IDHPJLANMKA(array, foodInstancesAmount);
		IDHPJLANMKA(array, animalInstancesAmount);
		return array;
	}
}
