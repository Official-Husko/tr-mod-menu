using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimalFeeder : MonoBehaviour, IProximity, IInteractable, IHoverable
{
	[Serializable]
	public class FeederFoodList
	{
		public GameObject[] allSprites;
	}

	public int id;

	public FeederType feederType;

	[SerializeField]
	private int _level;

	[SerializeField]
	protected SpriteRenderer[] improvementsGO;

	public int[] maxAmount;

	public Transform tooltipPosition;

	public Container container;

	public OnlineAnimalFeederFood onlineAnimalFeederFood;

	public Material initialMaterial;

	public FarmBuilding farmBuilding;

	protected bool HFKDOAMFAHJ = true;

	[SerializeField]
	private bool updatingContainer;

	private Material NGHODLKOKOI;

	public FeederFoodList[] foodSprites;

	public FeederFoodList[] foodSprites2;

	public FeederFoodList[] foodSprites3;

	public int EONJGMONIOM
	{
		get
		{
			return _level;
		}
		protected set
		{
			_level = Mathf.Max(0, Mathf.Min(value, 2));
		}
	}

	public bool EPBLEDFPJIM
	{
		get
		{
			for (int i = 0; i < improvementsGO.Length; i++)
			{
				if ((Object)(object)improvementsGO[i] != (Object)null)
				{
					if ((Object)(object)((Renderer)improvementsGO[i]).sharedMaterial == (Object)(object)NGHODLKOKOI)
					{
						return true;
					}
					return false;
				}
			}
			return false;
		}
	}

	public virtual bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			return !IIEDALMMNLI;
		}
		return false;
	}

	private void CKKEJAINOBO(int JIIGOACEIKL)
	{
		FoodFeederUI foodFeederUI = FoodFeederUI.Get(JIIGOACEIKL);
		foodFeederUI.OnUIClose = (Action<int>)Delegate.Remove(foodFeederUI.OnUIClose, new Action<int>(CKKEJAINOBO));
		MainUI.SetCurrentContainer(JIIGOACEIKL, null, 0);
	}

	public virtual bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void SetOutline(int JIIGOACEIKL, bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			if ((Object)(object)NGHODLKOKOI == (Object)null)
			{
				NGHODLKOKOI = DecorationMode.GetPlayer(JIIGOACEIKL).GetOutlineMaterial();
			}
			for (int num = improvementsGO.Length - 1; num >= 0; num--)
			{
				if ((Object)(object)improvementsGO[num] != (Object)null && (Object)(object)((Renderer)improvementsGO[num]).sharedMaterial != (Object)(object)NGHODLKOKOI)
				{
					((Renderer)improvementsGO[num]).sharedMaterial = NGHODLKOKOI;
				}
			}
			return;
		}
		NGHODLKOKOI = null;
		for (int i = 0; i < improvementsGO.Length; i++)
		{
			if ((Object)(object)improvementsGO[i] != (Object)null)
			{
				((Renderer)improvementsGO[i]).sharedMaterial = initialMaterial;
			}
		}
	}

	protected void DDNFENEHJBL(int JIIGOACEIKL)
	{
		FoodFeederUI.Get(JIIGOACEIKL).SetAnimalFeeder(this, id, maxAmount[EONJGMONIOM]);
		FoodFeederUI.Get(JIIGOACEIKL).OpenUI();
		FoodFeederUI foodFeederUI = FoodFeederUI.Get(JIIGOACEIKL);
		foodFeederUI.OnUIClose = (Action<int>)Delegate.Combine(foodFeederUI.OnUIClose, new Action<int>(CKKEJAINOBO));
		MainUI.SetCurrentContainer(JIIGOACEIKL, container, id);
	}

	public bool CanFillWithWater(int JIIGOACEIKL)
	{
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem) != null)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(CommonReferences.GGFJGHHHEJC.bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false))
			{
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.waterSplash));
				return true;
			}
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(CommonReferences.GGFJGHHHEJC.bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			CommonReferences.GGFJGHHHEJC.PlayerBark("Inventory full", JIIGOACEIKL);
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("No bucket of water", JIIGOACEIKL);
		}
		return false;
	}

	public abstract bool MouseUp(int JIIGOACEIKL);

	public abstract int GetCurrentAmount();

	public void SetLevel(int EONJGMONIOM)
	{
		this.EONJGMONIOM = EONJGMONIOM;
		UpdateSprite();
	}

	public virtual void SetStyle(SpritesList ONLCBJNNJMB)
	{
	}

	public ItemInstance GetNextFoodFromContainer()
	{
		if (!container.slots[0].KPINNBKMOMO())
		{
			return container.slots[0].itemInstance;
		}
		if (container.slots.Length > 1 && !container.slots[1].KPINNBKMOMO())
		{
			return container.slots[1].itemInstance;
		}
		if (container.slots.Length > 2 && !container.slots[2].KPINNBKMOMO())
		{
			return container.slots[2].itemInstance;
		}
		return null;
	}

	private void ELCIKJJCHGC()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		updatingContainer = true;
		for (int i = 0; i < container.slots.Length; i++)
		{
			if (!container.slots[i].KPINNBKMOMO() && !Utils.DOOILKJLDHD(container.slots[i].itemInstance, container))
			{
				if (OnlineManager.MasterOrOffline())
				{
					DroppedItem.SpawnDroppedItem(((Component)this).transform.position, container.slots[i].itemInstance, container.slots[i].Stack);
				}
				container.slots[i].Stack = 0;
			}
		}
		container.OrderItemsBySpace();
		updatingContainer = false;
		ButtonsContext.ResetAllCrafterAction();
		UpdateSprite();
	}

	protected virtual void Start()
	{
		if ((Object)(object)container == (Object)null)
		{
			return;
		}
		Container obj = container;
		obj.OnContainerChanged = (Action)Delegate.Combine(obj.OnContainerChanged, new Action(NLJMBNIHLAK));
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (farmBuilding is Barn)
		{
			for (int i = 0; i < container.slots.Length; i++)
			{
				container.slots[i].onlineObject = onlineAnimalFeederFood;
			}
		}
		else if (farmBuilding is HenHouse henHouse && Object.op_Implicit((Object)(object)henHouse.placeable) && Object.op_Implicit((Object)(object)henHouse.placeable.onlinePlaceable))
		{
			for (int j = 0; j < container.slots.Length; j++)
			{
				container.slots[j].onlineObject = henHouse.onlineHenHouse;
			}
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void Awake()
	{
		if ((Object)(object)initialMaterial == (Object)null)
		{
			initialMaterial = ((Renderer)improvementsGO[0]).sharedMaterial;
		}
		UpdateSprite();
	}

	private void IBPJFGHIJJJ()
	{
		for (int i = 0; i < foodSprites.Length; i++)
		{
			for (int j = 0; j < foodSprites[i].allSprites.Length; j++)
			{
				foodSprites[i].allSprites[j].SetActive(false);
			}
		}
		for (int k = 0; k < foodSprites2.Length; k++)
		{
			for (int l = 0; l < foodSprites2[k].allSprites.Length; l++)
			{
				foodSprites2[k].allSprites[l].SetActive(false);
			}
		}
		for (int m = 0; m < foodSprites3.Length; m++)
		{
			for (int n = 0; n < foodSprites3[m].allSprites.Length; n++)
			{
				foodSprites3[m].allSprites[n].SetActive(false);
			}
		}
	}

	public virtual void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.ResetCrafterAction(JIIGOACEIKL);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetFoodFeederBar();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetWaterFeederBar();
	}

	private void MCCIJJBMEKH(int MGNOBNCMDJG)
	{
		if ((Object)(object)container != (Object)null && container.slots != null && container.slots.Length != 0 && container.slots[0].itemInstance != null)
		{
			if (container.slots[0].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1241 || container.slots[0].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1243)
			{
				for (int i = 0; i < foodSprites.Length; i++)
				{
					for (int j = 0; j < foodSprites[i].allSprites.Length; j++)
					{
						foodSprites[i].allSprites[j].SetActive(i == MGNOBNCMDJG);
					}
				}
			}
			else if (container.slots[0].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1242)
			{
				for (int k = 0; k < foodSprites2.Length; k++)
				{
					for (int l = 0; l < foodSprites2[k].allSprites.Length; l++)
					{
						foodSprites2[k].allSprites[l].SetActive(k == MGNOBNCMDJG);
					}
				}
			}
			else
			{
				if (container.slots[0].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() != 1244)
				{
					return;
				}
				for (int m = 0; m < foodSprites3.Length; m++)
				{
					for (int n = 0; n < foodSprites3[m].allSprites.Length; n++)
					{
						foodSprites3[m].allSprites[n].SetActive(m == MGNOBNCMDJG);
					}
				}
			}
			return;
		}
		for (int num = 0; num < foodSprites.Length; num++)
		{
			for (int num2 = 0; num2 < foodSprites[num].allSprites.Length; num2++)
			{
				foodSprites[num].allSprites[num2].SetActive(num == MGNOBNCMDJG);
			}
		}
	}

	public abstract void ResetState();

	public abstract void UpdateSprite();

	protected void MIBCPFGIABD()
	{
		int currentAmount = GetCurrentAmount();
		int num = foodSprites.Length;
		float num2 = (float)maxAmount[EONJGMONIOM] / (float)num;
		HFKDOAMFAHJ = currentAmount < maxAmount[EONJGMONIOM];
		if (currentAmount == 0)
		{
			IBPJFGHIJJJ();
			return;
		}
		for (int i = 0; i < num; i++)
		{
			if ((float)currentAmount <= num2)
			{
				MCCIJJBMEKH(i);
				break;
			}
			if (i == num - 1)
			{
				MCCIJJBMEKH(i);
			}
			else
			{
				num2 *= 2f;
			}
		}
	}

	private void NLJMBNIHLAK()
	{
		if (!updatingContainer)
		{
			updatingContainer = true;
			container.OrderItemsBySpace();
			farmBuilding.UpdateAnimalsState();
			updatingContainer = false;
			UpdateSprite();
		}
	}

	public void SetAllFarmAnimalsFoodRestriction()
	{
		List<Item> list = new List<Item>((ItemDatabaseAccessor.GetItem(1236) as Animal).OKPDBKOAGFO());
		Item[] array = (ItemDatabaseAccessor.GetItem(1237) as Animal).OKPDBKOAGFO();
		for (int i = 0; i < array.Length; i++)
		{
			if (!list.Contains(array[i]))
			{
				list.Add(array[i]);
			}
		}
		array = (ItemDatabaseAccessor.GetItem(1238) as Animal).OKPDBKOAGFO();
		for (int j = 0; j < array.Length; j++)
		{
			if (!list.Contains(array[j]))
			{
				list.Add(array[j]);
			}
		}
		container.allowedItemsList = list.ToArray();
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void SetAnimalFoodRestriction(AnimalNPC GGJLNHNAKCF)
	{
		container.allowedItemsList = GGJLNHNAKCF.CMOBLFMDNKF.OKPDBKOAGFO();
		ELCIKJJCHGC();
	}

	public void AnimalFeederSlotPressed(int JIIGOACEIKL, Slot ADEBNALPEHE, int FGFCNKFEIGF, bool GFNHAMCPEAK = true)
	{
		if (farmBuilding is Barn)
		{
			if (GFNHAMCPEAK)
			{
				int FNNBABJKAIH;
				int num = ((FGFCNKFEIGF != 1) ? Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out FNNBABJKAIH, 0, CDPAMNIPPEC: false) : (Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false) ? 1 : 0));
				if (GFNHAMCPEAK && OnlineManager.PlayingOnline() && num > 0)
				{
					OnlineObjectsManager.instance.SendAnimalFeederSlotPressed(ADEBNALPEHE, FGFCNKFEIGF);
				}
			}
			else
			{
				ADEBNALPEHE.FDOBDPPMMBH(FGFCNKFEIGF);
			}
		}
		else if (FGFCNKFEIGF == 1)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE);
		}
		else
		{
			Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var _);
		}
	}

	protected bool LFEGMOHKLEG()
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			updatingContainer = true;
			if (!container.slots[0].KPINNBKMOMO())
			{
				container.slots[0].Stack--;
			}
			else if (container.slots.Length > 1 && !container.slots[1].KPINNBKMOMO())
			{
				container.slots[1].Stack--;
			}
			else
			{
				if (container.slots.Length <= 2 || container.slots[2].KPINNBKMOMO())
				{
					updatingContainer = false;
					return false;
				}
				container.slots[2].Stack--;
			}
			container.OrderItemsBySpace();
			updatingContainer = false;
			UpdateSprite();
			return true;
		}
		return false;
	}

	public abstract void UpdateByProximity(int JIIGOACEIKL);

	public virtual void Improve()
	{
		EONJGMONIOM++;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public abstract bool WasteUnit(int HFDILBELIKE);
}
