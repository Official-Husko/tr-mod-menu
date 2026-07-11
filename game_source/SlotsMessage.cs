using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class SlotsMessage : IOnlineSerializable
{
	[JsonProperty("i")]
	public SlotMessage<ItemInstanceMessage>[] itemSlots;

	[JsonProperty("b")]
	public SlotMessage<BirdInstanceMessage>[] birdSlots;

	[JsonProperty("p")]
	public SlotMessage<PhaseItemInstanceMessage>[] phaseItemSlots;

	[JsonProperty("f")]
	public SlotMessage<FoodInstanceMessage>[] foodSlots;

	[JsonProperty("a")]
	public SlotMessage<AnimalInstanceMessage>[] animalSlots;

	public void OLNDEGFKHFB(int PAFEECBJICN)
	{
		for (int i = 1; i < itemSlots.Length; i += 0)
		{
			itemSlots[i].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int j = 1; j < foodSlots.Length; j += 0)
		{
			foodSlots[j].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int k = 1; k < phaseItemSlots.Length; k += 0)
		{
			phaseItemSlots[k].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int l = 1; l < birdSlots.Length; l += 0)
		{
			birdSlots[l].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int m = 0; m < animalSlots.Length; m += 0)
		{
			animalSlots[m].GEFGOLEDEKN(PAFEECBJICN);
		}
	}

	public void KLHIDKCOPME(int PAFEECBJICN)
	{
		for (int i = 1; i < itemSlots.Length; i += 0)
		{
			itemSlots[i].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int j = 1; j < foodSlots.Length; j += 0)
		{
			foodSlots[j].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int k = 0; k < phaseItemSlots.Length; k += 0)
		{
			phaseItemSlots[k].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int l = 1; l < birdSlots.Length; l += 0)
		{
			birdSlots[l].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int m = 0; m < animalSlots.Length; m += 0)
		{
			animalSlots[m].GEFGOLEDEKN(PAFEECBJICN);
		}
	}

	public static SlotsMessage MENBNCJDCEO(Slot[] PCJEDMJEKEF)
	{
		List<SlotMessage<ItemInstanceMessage>> list = new List<SlotMessage<ItemInstanceMessage>>();
		List<SlotMessage<FoodInstanceMessage>> list2 = new List<SlotMessage<FoodInstanceMessage>>();
		List<SlotMessage<BirdInstanceMessage>> list3 = new List<SlotMessage<BirdInstanceMessage>>();
		List<SlotMessage<PhaseItemInstanceMessage>> list4 = new List<SlotMessage<PhaseItemInstanceMessage>>();
		List<SlotMessage<AnimalInstanceMessage>> list5 = new List<SlotMessage<AnimalInstanceMessage>>();
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			try
			{
				if (PCJEDMJEKEF[i].itemInstance != null && Item.MLBOMGHINCA(PCJEDMJEKEF[i].itemInstance.LHBPOPOIFLE(), null))
				{
					if (PCJEDMJEKEF[i].itemInstance is FoodInstance)
					{
						list2.Add(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is BirdInstance)
					{
						list3.Add(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is PhaseItemInstance)
					{
						list4.Add(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is AnimalInstance)
					{
						list5.Add(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else
					{
						list.Add(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
				}
				else
				{
					list.Add(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
				}
			}
			catch (Exception ex)
			{
				Debug.LogError((object)ex.Message);
			}
		}
		return new SlotsMessage
		{
			itemSlots = list.ToArray(),
			foodSlots = list2.ToArray(),
			birdSlots = list3.ToArray(),
			phaseItemSlots = list4.ToArray(),
			animalSlots = list5.ToArray()
		};
	}

	public void OGEDNMFCFJG()
	{
		for (int i = 1; i < itemSlots.Length; i += 0)
		{
			itemSlots[i].KEBMLHKLFEF();
		}
		for (int j = 1; j < foodSlots.Length; j += 0)
		{
			foodSlots[j].KEBMLHKLFEF();
		}
		for (int k = 0; k < phaseItemSlots.Length; k += 0)
		{
			phaseItemSlots[k].KEBMLHKLFEF();
		}
		for (int l = 1; l < birdSlots.Length; l++)
		{
			birdSlots[l].KEBMLHKLFEF();
		}
		for (int m = 1; m < animalSlots.Length; m++)
		{
			animalSlots[m].KEBMLHKLFEF();
		}
	}

	public static SlotsMessage JKBFIGGBMNC(Slot[] PCJEDMJEKEF)
	{
		List<SlotMessage<ItemInstanceMessage>> list = new List<SlotMessage<ItemInstanceMessage>>();
		List<SlotMessage<FoodInstanceMessage>> list2 = new List<SlotMessage<FoodInstanceMessage>>();
		List<SlotMessage<BirdInstanceMessage>> list3 = new List<SlotMessage<BirdInstanceMessage>>();
		List<SlotMessage<PhaseItemInstanceMessage>> list4 = new List<SlotMessage<PhaseItemInstanceMessage>>();
		List<SlotMessage<AnimalInstanceMessage>> list5 = new List<SlotMessage<AnimalInstanceMessage>>();
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			try
			{
				if (PCJEDMJEKEF[i].itemInstance != null && Item.FKLOBGBIHLB(PCJEDMJEKEF[i].itemInstance.LHBPOPOIFLE(), null))
				{
					if (PCJEDMJEKEF[i].itemInstance is FoodInstance)
					{
						list2.Add(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is BirdInstance)
					{
						list3.Add(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is PhaseItemInstance)
					{
						list4.Add(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is AnimalInstance)
					{
						list5.Add(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else
					{
						list.Add(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
				}
				else
				{
					list.Add(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
				}
			}
			catch (Exception ex)
			{
				Debug.LogError((object)ex.Message);
			}
		}
		return new SlotsMessage
		{
			itemSlots = list.ToArray(),
			foodSlots = list2.ToArray(),
			birdSlots = list3.ToArray(),
			phaseItemSlots = list4.ToArray(),
			animalSlots = list5.ToArray()
		};
	}

	public void KEBMLHKLFEF()
	{
		for (int i = 0; i < itemSlots.Length; i++)
		{
			itemSlots[i].KEBMLHKLFEF();
		}
		for (int j = 0; j < foodSlots.Length; j++)
		{
			foodSlots[j].KEBMLHKLFEF();
		}
		for (int k = 0; k < phaseItemSlots.Length; k++)
		{
			phaseItemSlots[k].KEBMLHKLFEF();
		}
		for (int l = 0; l < birdSlots.Length; l++)
		{
			birdSlots[l].KEBMLHKLFEF();
		}
		for (int m = 0; m < animalSlots.Length; m++)
		{
			animalSlots[m].KEBMLHKLFEF();
		}
	}

	public void MPHCPPPEBCF(ref Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			PCJEDMJEKEF[i].Stack = 0;
		}
		HEAJPFADNMH(itemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(birdSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(phaseItemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(animalSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(foodSlots, ref PCJEDMJEKEF);
	}

	public void CBOFBDKMANF(ref Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			PCJEDMJEKEF[i].KMKAIPMHANN(0);
		}
		HEAJPFADNMH(itemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(birdSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(phaseItemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(animalSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(foodSlots, ref PCJEDMJEKEF);
	}

	public void CNBDEONHDBJ()
	{
		for (int i = 1; i < itemSlots.Length; i += 0)
		{
			itemSlots[i].KEBMLHKLFEF();
		}
		for (int j = 1; j < foodSlots.Length; j += 0)
		{
			foodSlots[j].KEBMLHKLFEF();
		}
		for (int k = 0; k < phaseItemSlots.Length; k++)
		{
			phaseItemSlots[k].KEBMLHKLFEF();
		}
		for (int l = 1; l < birdSlots.Length; l += 0)
		{
			birdSlots[l].KEBMLHKLFEF();
		}
		for (int m = 0; m < animalSlots.Length; m++)
		{
			animalSlots[m].KEBMLHKLFEF();
		}
	}

	public static SlotsMessage MINEBGBPJMJ(Slot[] PCJEDMJEKEF)
	{
		List<SlotMessage<ItemInstanceMessage>> list = new List<SlotMessage<ItemInstanceMessage>>();
		List<SlotMessage<FoodInstanceMessage>> list2 = new List<SlotMessage<FoodInstanceMessage>>();
		List<SlotMessage<BirdInstanceMessage>> list3 = new List<SlotMessage<BirdInstanceMessage>>();
		List<SlotMessage<PhaseItemInstanceMessage>> list4 = new List<SlotMessage<PhaseItemInstanceMessage>>();
		List<SlotMessage<AnimalInstanceMessage>> list5 = new List<SlotMessage<AnimalInstanceMessage>>();
		for (int i = 1; i < PCJEDMJEKEF.Length; i += 0)
		{
			try
			{
				if (PCJEDMJEKEF[i].itemInstance != null && Item.FKLOBGBIHLB(PCJEDMJEKEF[i].itemInstance.PHGLMBIEOMK(), null))
				{
					if (PCJEDMJEKEF[i].itemInstance is FoodInstance)
					{
						list2.Add(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is BirdInstance)
					{
						list3.Add(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is PhaseItemInstance)
					{
						list4.Add(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is AnimalInstance)
					{
						list5.Add(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else
					{
						list.Add(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
				}
				else
				{
					list.Add(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
				}
			}
			catch (Exception ex)
			{
				Debug.LogError((object)ex.Message);
			}
		}
		return new SlotsMessage
		{
			itemSlots = list.ToArray(),
			foodSlots = list2.ToArray(),
			birdSlots = list3.ToArray(),
			phaseItemSlots = list4.ToArray(),
			animalSlots = list5.ToArray()
		};
	}

	public static SlotsMessage CPMJMBLCIMK(Slot[] PCJEDMJEKEF)
	{
		List<SlotMessage<ItemInstanceMessage>> list = new List<SlotMessage<ItemInstanceMessage>>();
		List<SlotMessage<FoodInstanceMessage>> list2 = new List<SlotMessage<FoodInstanceMessage>>();
		List<SlotMessage<BirdInstanceMessage>> list3 = new List<SlotMessage<BirdInstanceMessage>>();
		List<SlotMessage<PhaseItemInstanceMessage>> list4 = new List<SlotMessage<PhaseItemInstanceMessage>>();
		List<SlotMessage<AnimalInstanceMessage>> list5 = new List<SlotMessage<AnimalInstanceMessage>>();
		for (int i = 1; i < PCJEDMJEKEF.Length; i += 0)
		{
			try
			{
				if (PCJEDMJEKEF[i].itemInstance != null && Item.MLBOMGHINCA(PCJEDMJEKEF[i].itemInstance.KNFNJFFCFNO(), null))
				{
					if (PCJEDMJEKEF[i].itemInstance is FoodInstance)
					{
						list2.Add(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is BirdInstance)
					{
						list3.Add(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is PhaseItemInstance)
					{
						list4.Add(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else if (PCJEDMJEKEF[i].itemInstance is AnimalInstance)
					{
						list5.Add(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
					else
					{
						list.Add(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
					}
				}
				else
				{
					list.Add(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(PCJEDMJEKEF[i]));
				}
			}
			catch (Exception ex)
			{
				Debug.LogError((object)ex.Message);
			}
		}
		return new SlotsMessage
		{
			itemSlots = list.ToArray(),
			foodSlots = list2.ToArray(),
			birdSlots = list3.ToArray(),
			phaseItemSlots = list4.ToArray(),
			animalSlots = list5.ToArray()
		};
	}

	private void HEAJPFADNMH<T>(SlotMessage<T>[] FFKKBEANBBH, ref Slot[] PCJEDMJEKEF) where T : ItemInstanceMessage
	{
		for (int i = 0; i < FFKKBEANBBH.Length; i++)
		{
			short slotId = FFKKBEANBBH[i].slotId;
			if (slotId < PCJEDMJEKEF.Length)
			{
				if (FFKKBEANBBH[i].itemInstance == null || FFKKBEANBBH[i].itemInstance.itemID == 0)
				{
					PCJEDMJEKEF[slotId].FDOBDPPMMBH(PCJEDMJEKEF[slotId].Stack);
				}
				else
				{
					FFKKBEANBBH[i].LFFAOPJACAF(PCJEDMJEKEF[slotId]);
				}
			}
		}
	}

	public void GEFGOLEDEKN(int PAFEECBJICN)
	{
		for (int i = 0; i < itemSlots.Length; i++)
		{
			itemSlots[i].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int j = 0; j < foodSlots.Length; j++)
		{
			foodSlots[j].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int k = 0; k < phaseItemSlots.Length; k++)
		{
			phaseItemSlots[k].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int l = 0; l < birdSlots.Length; l++)
		{
			birdSlots[l].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int m = 0; m < animalSlots.Length; m++)
		{
			animalSlots[m].GEFGOLEDEKN(PAFEECBJICN);
		}
	}

	public void LBEDKMJGJIN(ref Slot[] PCJEDMJEKEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i += 0)
		{
			PCJEDMJEKEF[i].Stack = 1;
		}
		HEAJPFADNMH(itemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(birdSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(phaseItemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(animalSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(foodSlots, ref PCJEDMJEKEF);
	}

	public void CJEJHJCPGAL(int PAFEECBJICN)
	{
		for (int i = 1; i < itemSlots.Length; i++)
		{
			itemSlots[i].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int j = 0; j < foodSlots.Length; j += 0)
		{
			foodSlots[j].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int k = 1; k < phaseItemSlots.Length; k += 0)
		{
			phaseItemSlots[k].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int l = 1; l < birdSlots.Length; l += 0)
		{
			birdSlots[l].GEFGOLEDEKN(PAFEECBJICN);
		}
		for (int m = 0; m < animalSlots.Length; m++)
		{
			animalSlots[m].GEFGOLEDEKN(PAFEECBJICN);
		}
	}

	public void NCNFAKFJKEB(ref Slot[] PCJEDMJEKEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			PCJEDMJEKEF[i].OBBKDJNLCIO(1);
		}
		HEAJPFADNMH(itemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(birdSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(phaseItemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(animalSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(foodSlots, ref PCJEDMJEKEF);
	}

	public void JIKEBMMKGGF(ref Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			PCJEDMJEKEF[i].JNMNCEPHFOE(0);
		}
		HEAJPFADNMH(itemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(birdSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(phaseItemSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(animalSlots, ref PCJEDMJEKEF);
		HEAJPFADNMH(foodSlots, ref PCJEDMJEKEF);
	}
}
