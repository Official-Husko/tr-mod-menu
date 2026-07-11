using UnityEngine;

public class AnimalFeederChicken : AnimalFeeder
{
	protected override void Start()
	{
		base.Start();
		UpdateSprite();
		container.maxStack = maxAmount[base.EONJGMONIOM];
	}

	public override bool WasteUnit(int HFDILBELIKE)
	{
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			if (!LFEGMOHKLEG())
			{
				return false;
			}
		}
		return true;
	}

	public override void UpdateSprite()
	{
		for (int i = 0; i < improvementsGO.Length; i++)
		{
			((Component)improvementsGO[i]).gameObject.SetActive(i == base.EONJGMONIOM);
		}
		MIBCPFGIABD();
	}

	public override void Improve()
	{
		base.Improve();
		container.maxStack = maxAmount[base.EONJGMONIOM];
		container.slots[0].onlineObject = farmBuilding.placeable.onlinePlaceable;
		UpdateSprite();
	}

	public override void ResetState()
	{
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			DDNFENEHJBL(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetCrafterAction(new ItemInstanceAmount(container.slots[0].itemInstance, 1));
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetFoodFeederBar(container.GetNumberOfItems(), maxAmount[base.EONJGMONIOM]);
			return true;
		}
		return false;
	}

	public override void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public override int GetCurrentAmount()
	{
		return container.GetNumberOfItems();
	}
}
