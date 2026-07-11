using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : Item
{
	[Serializable]
	public struct IconsCombination
	{
		public int id;

		public AnimalsSpriteInfo bodyPart;

		public CharacterMaterial material1;

		public CharacterMaterial material2;

		public Sprite icon;
	}

	public AnimalType animalType;

	public float probabilityToSick = 0.5f;

	public IconsCombination[] iconsCombination;

	[SerializeField]
	private Item[] foodItems;

	public bool productionLimitedToOnce = true;

	public ItemProduction productionItem;

	[SerializeField]
	private ItemProduction[] sacrificeItems;

	public override ItemInstance KDNBBPJCNDJ(ItemInstance DNLMCHDOMOK)
	{
		return new AnimalInstance((AnimalInstance)DNLMCHDOMOK);
	}

	public int[] DKBKBEJKOFA(int JFNMCNCHMEO)
	{
		for (int i = 0; i < iconsCombination.Length; i++)
		{
			if (JFNMCNCHMEO == iconsCombination[i].id)
			{
				return new int[2]
				{
					iconsCombination[i].material1.id,
					iconsCombination[i].material2.id
				};
			}
		}
		return null;
	}

	public Item[] OKPDBKOAGFO()
	{
		return foodItems;
	}

	public Sprite AAGOCCCEKMH(List<int> ACGHEKFLOBI, List<int> AAFDDDINDFM)
	{
		for (int i = 0; i < iconsCombination.Length; i++)
		{
			if ((!((Object)(object)iconsCombination[i].bodyPart != (Object)null) || ACGHEKFLOBI.Contains(iconsCombination[i].bodyPart.id)) && (!((Object)(object)iconsCombination[i].material1 != (Object)null) || AAFDDDINDFM.Contains(iconsCombination[i].material1.id)) && (!((Object)(object)iconsCombination[i].material2 != (Object)null) || AAFDDDINDFM.Contains(iconsCombination[i].material2.id)))
			{
				return iconsCombination[i].icon;
			}
		}
		return null;
	}

	public List<ItemAmount> LPCKMEJAODN(int EONJGMONIOM)
	{
		List<ItemAmount> list = new List<ItemAmount>();
		for (int i = 0; i < sacrificeItems.Length; i++)
		{
			ItemAmount item = new ItemAmount(sacrificeItems[i].item, (int)sacrificeItems[i].CKALIPBHDFB(EONJGMONIOM));
			list.Add(item);
		}
		return list;
	}

	public override ItemInstance JMDALJBNFML()
	{
		return new AnimalInstance(this);
	}
}
