using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;

public abstract class ShopBaseUI : UIWindow
{
	public Action<int, List<BasketItem>> OnItemsBought = delegate
	{
	};

	[SerializeField]
	protected List<ShopElementUI> optionsElements;

	[SerializeField]
	protected List<ShopElementUI> basketElements;

	public MoneyUI moneyUI;

	[SerializeField]
	protected GameObject cantAffordBox;

	[SerializeField]
	protected GameObject cantAffordBoxRecipeFragments;

	[SerializeField]
	protected GameObject cantAffordBoxWilsonCoins;

	[SerializeField]
	protected GameObject cantAffordBoxTickets;

	[SerializeField]
	protected ShopElementUI optionElementPrefab;

	[SerializeField]
	protected ShopElementUI basketElementPrefab;

	[SerializeField]
	protected GameObject optionsListParent;

	[SerializeField]
	protected GameObject basketListParent;

	public Shop shop;

	protected float CMGDCLIIONE;

	protected List<BasketItem> GCECCIJABEN;

	public bool clue;

	public bool aquarium;

	public bool buy;

	public bool barnAnimals;

	public void CheckUISelection()
	{
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && (Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)null && !((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject.activeSelf)
		{
			FPNILKPDAKD();
		}
	}

	private void DJCKAODHCOE(ShopElementUI PBBFOIJHBBO, ShopElement OAENMCBBANN)
	{
		OAENMCBBANN.BJEDNMLOPEN();
		if (OAENMCBBANN.itemInstance is AnimalInstance animalInstance)
		{
			animalInstance.showBirthdayOnTooltip = false;
		}
		PBBFOIJHBBO.SetShopItem(OAENMCBBANN, OAENMCBBANN.amount, OLMEEOAEMED: true);
		if ((Object)(object)shop != (Object)null)
		{
			if (Object.op_Implicit((Object)(object)PBBFOIJHBBO.shopElement.recipe) && PBBFOIJHBBO.shopElement.amount == 0)
			{
				((Component)PBBFOIJHBBO).gameObject.SetActive(false);
			}
			else if (Object.op_Implicit((Object)(object)PBBFOIJHBBO.shopElement.recipe))
			{
				((Component)PBBFOIJHBBO).gameObject.SetActive(true);
			}
		}
	}

	public virtual void UpdateOptionsUI()
	{
	}

	protected void CHKJOFLKKGH()
	{
		for (int i = 0; i < GCECCIJABEN.Count; i++)
		{
			if (i >= basketElements.Count)
			{
				basketElements.Add(Object.Instantiate<ShopElementUI>(basketElementPrefab, basketListParent.transform));
				basketElements[i].SetPlayerNum(base.JIIGOACEIKL);
				basketElements[i].shopBase = this;
			}
			if (Object.op_Implicit((Object)(object)GCECCIJABEN[i].currentShopElement.item))
			{
				((Component)basketElements[i]).gameObject.SetActive(true);
				basketElements[i].SetShopItem(GCECCIJABEN[i].currentShopElement, GCECCIJABEN[i].boughtAmount, OLMEEOAEMED: false);
			}
		}
		for (int j = GCECCIJABEN.Count; j < basketElements.Count; j++)
		{
			((Component)basketElements[j]).gameObject.SetActive(false);
		}
	}

	public void UpdateOptionsElement(ShopElement OAENMCBBANN)
	{
		for (int i = 0; i < optionsElements.Count; i++)
		{
			if ((Object)(object)optionsElements[i].shopElement.recipe != (Object)null && (Object)(object)optionsElements[i].shopElement.recipe == (Object)(object)OAENMCBBANN.recipe)
			{
				DJCKAODHCOE(optionsElements[i], OAENMCBBANN);
				break;
			}
			if (optionsElements[i].shopElement.shopItem != null && optionsElements[i].shopElement.shopItem == OAENMCBBANN.shopItem)
			{
				DJCKAODHCOE(optionsElements[i], OAENMCBBANN);
				break;
			}
		}
	}

	protected void OGBKMPPJHON()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			((MonoBehaviour)this).StartCoroutine(PBCDJFLNNKG());
		}
	}

	public int GetBasketTotalRecipeFragments()
	{
		int num = 0;
		foreach (BasketItem item in GCECCIJABEN)
		{
			if (!Item.NGIIPJDAMGP(item.currentShopElement.item, null))
			{
				num += item.currentShopElement.recipe.recipeFragments * item.boughtAmount;
			}
		}
		return num;
	}

	public MoneyCalc GetBasketTotal()
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		for (int i = 0; i < GCECCIJABEN.Count; i++)
		{
			if (!Item.NGIIPJDAMGP(GCECCIJABEN[i].currentShopElement.item, null))
			{
				Price eNDNDAOPKHD = GCECCIJABEN[i].currentShopElement.HNGEJNDLALE();
				moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(eNDNDAOPKHD, GCECCIJABEN[i].boughtAmount), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
		}
		return moneyCalc;
	}

	public void AddItem(ShopElement IFKKAOEBOFP)
	{
		BasketItem value = default(BasketItem);
		if ((Object)(object)IFKKAOEBOFP.recipe == (Object)null)
		{
			for (int i = 0; i < GCECCIJABEN.Count; i++)
			{
				if (GCECCIJABEN[i].currentShopElement.shopItem != null && Item.NGIIPJDAMGP(GCECCIJABEN[i].currentShopElement.shopItem.item, IFKKAOEBOFP.shopItem.item) && (!(GCECCIJABEN[i].currentShopElement.itemInstance is AnimalInstance animalInstance) || animalInstance.ACCPCEDGELP(IFKKAOEBOFP.itemInstance as AnimalInstance)))
				{
					if (GCECCIJABEN[i].currentShopElement.amount != 99 && (!((Object)(object)shop != (Object)null) || !shop.usingRecipeFragments))
					{
						value = GCECCIJABEN[i];
						value.boughtAmount++;
						GCECCIJABEN[i] = value;
					}
					return;
				}
			}
		}
		value.boughtAmount = 1;
		value.currentShopElement = IFKKAOEBOFP;
		GCECCIJABEN.Add(value);
	}

	public void OrderBasket()
	{
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)shop == (Object)null || (shop.shopType != ShopType.AceT && !shop.usingRecipeFragments && shop.shopType != ShopType.Wilson))
		{
			if (PlayerInventory.GetPlayer(base.JIIGOACEIKL).IsInventoryFull())
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
				return;
			}
			Price gCCPFAHOHEH = GetBasketTotal().ALLHDAPPBHL();
			if (!Money.CanAfford(gCCPFAHOHEH))
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Not enough money"));
				return;
			}
			OnItemsBought(base.JIIGOACEIKL, GCECCIJABEN);
			if (GCECCIJABEN.Count > 0)
			{
				buy = true;
				ShopsManager.AddOrder(new ShopOrder(base.JIIGOACEIKL, new List<ItemInstanceAmount>((from x in GCECCIJABEN
					where x.currentShopElement.shopItem != null
					select new ItemInstanceAmount(x.currentShopElement.itemInstance, x.boughtAmount)).ToArray()), WorldTime.NOAOJJLNHJJ.hour, shop));
			}
			for (int num = GCECCIJABEN.Count - 1; num >= 0; num--)
			{
				int boughtAmount = GCECCIJABEN[num].boughtAmount;
				for (int num2 = 0; num2 < boughtAmount; num2++)
				{
					if ((Object)(object)HollyNPC.GGFJGHHHEJC != (Object)null && shop.shopType == ShopType.Holly)
					{
						Result variable;
						if (GCECCIJABEN[num].currentShopElement.item.JDJGFAACPFC() == 1239)
						{
							variable = DialogueLua.GetVariable("HenHouseTutorialDone");
							if (!((Result)(ref variable)).asBool && !HollyNPC.GGFJGHHHEJC.inTutorial)
							{
								HollyNPC.GGFJGHHHEJC.inTutorial = true;
								HollyNPC.GGFJGHHHEJC.StartConversation(base.JIIGOACEIKL, "Tutorial/Chicken_Holly", FLHBPHPKIML: true);
								HollyNPC.GGFJGHHHEJC.hollyRoutine.inTutorial = true;
								((Behaviour)HollyNPC.GGFJGHHHEJC.hollyRoutine).enabled = false;
								goto IL_0350;
							}
						}
						if (GCECCIJABEN[num].currentShopElement.item.JDJGFAACPFC() == 1236 || GCECCIJABEN[num].currentShopElement.item.JDJGFAACPFC() == 1237 || GCECCIJABEN[num].currentShopElement.item.JDJGFAACPFC() == 1238)
						{
							variable = DialogueLua.GetVariable("BarnTutorialDone");
							if (!((Result)(ref variable)).asBool && !HollyNPC.GGFJGHHHEJC.inTutorial)
							{
								barnAnimals = false;
								if ((Object)(object)Barn.instance != (Object)null && Barn.instance.animalSpaces != null)
								{
									for (int i = 0; i < Barn.instance.animalSpaces.Length; i++)
									{
										if ((Object)(object)Barn.instance.animalSpaces[i].DHJHEALFPJN != (Object)null)
										{
											barnAnimals = true;
											DialogueLua.SetVariable("BarnTutorialDone", (object)true);
											break;
										}
									}
								}
								if (!barnAnimals)
								{
									HollyNPC.GGFJGHHHEJC.inTutorial = true;
									HollyNPC.GGFJGHHHEJC.StartConversation(base.JIIGOACEIKL, "Tutorial/Barn_Holly", FLHBPHPKIML: true);
									HollyNPC.GGFJGHHHEJC.hollyRoutine.inTutorial = true;
									((Behaviour)HollyNPC.GGFJGHHHEJC.hollyRoutine).enabled = false;
								}
							}
						}
					}
					goto IL_0350;
					IL_0350:
					if ((Object)(object)GCECCIJABEN[num].currentShopElement.recipe != (Object)null)
					{
						RecipesManager.UnlockRecipeMaster(GCECCIJABEN[num].currentShopElement.recipe);
					}
					else if (Item.MLBOMGHINCA(GCECCIJABEN[num].currentShopElement.item, null))
					{
						RecipeDatabaseAccessor.UnlockRecipesBuyingItem(GCECCIJABEN[num].currentShopElement.item.JDJGFAACPFC());
					}
					RemoveItem(GCECCIJABEN[num].currentShopElement.itemInstance, 1);
				}
			}
			Money.MinusPrice(gCCPFAHOHEH);
			CloseUI();
		}
		else if ((Object)(object)shop != (Object)null && shop.usingRecipeFragments)
		{
			if (GetBasketTotalRecipeFragments() > RecipesManager.recipeFragments)
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Not enough recipe fragments"));
				return;
			}
			if (GetBasketTotalRecipeFragments() != 0)
			{
				for (int j = 0; j < GCECCIJABEN.Count; j++)
				{
					RecipesManager.UnlockRecipe(GCECCIJABEN[j].currentShopElement.recipe);
				}
				RecipesManager.recipeFragments -= GetBasketTotalRecipeFragments();
				RecipesManager.recipeFragmentsUsed += GetBasketTotalRecipeFragments();
				if (RecipesManager.recipeFragmentsUsed >= 50)
				{
					Utils.DLIIAHACOJB(30);
				}
				CloseUI();
			}
		}
		else if ((Object)(object)shop != (Object)null && shop.shopType == ShopType.Wilson)
		{
			if (GetBasketTotalWilsonCoins() > PlayerInventory.GetPlayer(base.JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(1500)))
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Not enough money"));
				return;
			}
			OnItemsBought(base.JIIGOACEIKL, GCECCIJABEN);
			ShopOrder iJEFIBKNFOE = new ShopOrder(base.JIIGOACEIKL, new List<ItemInstanceAmount>(GCECCIJABEN.Select((BasketItem x) => new ItemInstanceAmount(x.currentShopElement.itemInstance, x.boughtAmount)).ToArray()), WorldTime.NOAOJJLNHJJ.hour, shop);
			for (int num3 = iJEFIBKNFOE.items.Count - 1; num3 >= 0; num3--)
			{
				if (iJEFIBKNFOE.items[num3].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1499 || iJEFIBKNFOE.items[num3].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1513 || iJEFIBKNFOE.items[num3].itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1514)
				{
					iJEFIBKNFOE.items.RemoveAt(num3);
				}
			}
			ShopsManager.OrderInWithDelay(iJEFIBKNFOE, 0.3f);
			int num4 = 0;
			clue = false;
			aquarium = false;
			buy = true;
			for (int num5 = GCECCIJABEN.Count - 1; num5 >= 0; num5--)
			{
				int boughtAmount2 = GCECCIJABEN[num5].boughtAmount;
				for (int k = 0; k < boughtAmount2; k++)
				{
					if (Item.NGIIPJDAMGP(GCECCIJABEN[num5].currentShopElement.item, ItemDatabaseAccessor.GetItem(1499)))
					{
						clue = true;
					}
					if (Item.NGIIPJDAMGP(GCECCIJABEN[num5].currentShopElement.item, ItemDatabaseAccessor.GetItem(3443)) || Item.NGIIPJDAMGP(GCECCIJABEN[num5].currentShopElement.item, ItemDatabaseAccessor.GetItem(3444)) || Item.NGIIPJDAMGP(GCECCIJABEN[num5].currentShopElement.item, ItemDatabaseAccessor.GetItem(3445)) || Item.NGIIPJDAMGP(GCECCIJABEN[num5].currentShopElement.item, ItemDatabaseAccessor.GetItem(3446)) || Item.NGIIPJDAMGP(GCECCIJABEN[num5].currentShopElement.item, ItemDatabaseAccessor.GetItem(3447)) || Item.NGIIPJDAMGP(GCECCIJABEN[num5].currentShopElement.item, ItemDatabaseAccessor.GetItem(3448)))
					{
						num4++;
						aquarium = true;
					}
					List<Slot> list = new List<Slot>();
					for (int l = 0; l < GCECCIJABEN[num5].currentShopElement.item.wilsonCoinsPrice; l++)
					{
						Slot slot = PlayerInventory.GetPlayer(base.JIIGOACEIKL).RemoveItem(ItemDatabaseAccessor.GetItem(1500), CDPAMNIPPEC: false);
						if (slot != null && !list.Contains(slot))
						{
							list.Add(slot);
						}
					}
					if (list.Count > 0 && OnlineManager.PlayingOnline())
					{
						OnlineSlotsManager.instance.SendSlots(list.ToArray());
					}
					if (GCECCIJABEN[num5].currentShopElement.item.JDJGFAACPFC() == 1499)
					{
						FishingManager.AddFishInformation(FishingManager.instance.GetAllFishesNoInfo()[Random.Range(0, FishingManager.instance.GetAllFishesNoInfo().Count)]);
					}
					else if (GCECCIJABEN[num5].currentShopElement.item.JDJGFAACPFC() == 1513 || GCECCIJABEN[num5].currentShopElement.item.JDJGFAACPFC() == 1514)
					{
						ItemDatabaseAccessor.GetItem(GCECCIJABEN[num5].currentShopElement.item.JDJGFAACPFC()).IPGBILAIAPG(CDPAMNIPPEC: true);
					}
					else
					{
						ShopDatabaseAccessor.wilsonDecorativeObjects += GCECCIJABEN[num5].currentShopElement.amount;
						if (ShopDatabaseAccessor.wilsonDecorativeObjects >= 50)
						{
							Utils.DLIIAHACOJB(33);
						}
					}
					if (Application.isEditor)
					{
						Debug.Log((object)"ShopWilson");
					}
					RemoveItem(GCECCIJABEN[num5].currentShopElement.itemInstance, 1);
				}
			}
			if (aquarium)
			{
				Utils.DLIIAHACOJB(26);
				for (int m = 3443; m < 3449; m++)
				{
					num4 += Utils.JCKKCOCGDLA(base.JIIGOACEIKL, ItemDatabaseAccessor.GetItem(m), AKNBKINJGCF: false, null, AHCENOLCIBM: true);
				}
				Debug.Log((object)("aquariumNumber " + num4));
				if (num4 >= 5)
				{
					Utils.DLIIAHACOJB(27);
				}
			}
			CloseUI();
		}
		else
		{
			if (GetBasketTotalTickets() > PlayerInventory.GetPlayer(base.JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(1224)))
			{
				MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Not enough money"));
				return;
			}
			buy = true;
			OnItemsBought(base.JIIGOACEIKL, GCECCIJABEN);
			ShopOrder iJEFIBKNFOE2 = new ShopOrder(base.JIIGOACEIKL, new List<ItemInstanceAmount>(GCECCIJABEN.Select((BasketItem x) => new ItemInstanceAmount(x.currentShopElement.itemInstance, x.boughtAmount)).ToArray()), WorldTime.NOAOJJLNHJJ.hour, shop);
			List<Slot> list2 = new List<Slot>();
			for (int num6 = GCECCIJABEN.Count - 1; num6 >= 0; num6--)
			{
				int boughtAmount3 = GCECCIJABEN[num6].boughtAmount;
				for (int n = 0; n < boughtAmount3; n++)
				{
					for (int num7 = 0; num7 < GCECCIJABEN[num6].currentShopElement.item.ticketPrice; num7++)
					{
						Slot slot2 = PlayerInventory.GetPlayer(base.JIIGOACEIKL).RemoveItem(ItemDatabaseAccessor.GetItem(1224), CDPAMNIPPEC: false);
						if (slot2 != null && !list2.Contains(slot2))
						{
							list2.Add(slot2);
						}
					}
					RemoveItem(GCECCIJABEN[num6].currentShopElement.itemInstance, 1);
				}
			}
			if (list2.Count > 0 && OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.SendSlots(list2.ToArray());
			}
			ShopsManager.OrderInWithDelay(iJEFIBKNFOE2, 0.3f);
			CloseUI();
		}
		GELCMGCKCGG();
	}

	public int GetBasketTotalTickets()
	{
		int num = 0;
		foreach (BasketItem item in GCECCIJABEN)
		{
			if (!Item.NGIIPJDAMGP(item.currentShopElement.item, null))
			{
				num += item.currentShopElement.item.ticketPrice * item.boughtAmount;
			}
		}
		return num;
	}

	protected override void Awake()
	{
		base.Awake();
		GCECCIJABEN = new List<BasketItem>();
	}

	public void UpdateBasketUI()
	{
		CHKJOFLKKGH();
		if ((Object)(object)shop == (Object)null || (!shop.usingRecipeFragments && shop.shopType != ShopType.Wilson && shop.shopType != ShopType.AceT))
		{
			MoneyCalc basketTotal = GetBasketTotal();
			moneyUI.SetPrice(basketTotal.ALLHDAPPBHL());
			cantAffordBox.SetActive(!Money.CanAfford(basketTotal.ALLHDAPPBHL()));
		}
		else if (shop.shopType == ShopType.AceT)
		{
			((TMP_Text)(this as ShopUI).ticketBasketText).text = GetBasketTotalTickets().ToString();
			cantAffordBoxTickets.SetActive(GetBasketTotalTickets() > PlayerInventory.GetPlayer(base.JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(1224)));
		}
		else if (shop.shopType == ShopType.Wilson)
		{
			((TMP_Text)(this as ShopUI).wilsonCoinBasketText).text = GetBasketTotalWilsonCoins().ToString();
			cantAffordBoxWilsonCoins.SetActive(GetBasketTotalWilsonCoins() > PlayerInventory.GetPlayer(base.JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(1500)));
		}
		else
		{
			((TMP_Text)(this as ShopUI).recipeFragmentsBasketText).text = GetBasketTotalRecipeFragments().ToString();
			cantAffordBoxRecipeFragments.SetActive(GetBasketTotalRecipeFragments() > RecipesManager.recipeFragments);
		}
	}

	public virtual void AddItemToBasket(ShopElement IFKKAOEBOFP)
	{
		if (Object.op_Implicit((Object)(object)IFKKAOEBOFP.item) && IFKKAOEBOFP.amount > 0)
		{
			bool unlimited = IFKKAOEBOFP.unlimited;
			if (!unlimited)
			{
				IFKKAOEBOFP.amount--;
				UpdateOptionsElement(IFKKAOEBOFP);
			}
			AddItem(IFKKAOEBOFP);
			UpdateBasketUI();
			if (!unlimited)
			{
				CheckUISelection();
			}
		}
	}

	public bool RemoveItemFromBasket(ShopElement IFKKAOEBOFP, int FFDIEOBBFKL = 1, bool HIOAJHJNCPO = true)
	{
		if (!IFKKAOEBOFP.unlimited)
		{
			IFKKAOEBOFP.amount += FFDIEOBBFKL;
			UpdateOptionsElement(IFKKAOEBOFP);
		}
		bool result = false;
		if (RemoveItem(IFKKAOEBOFP.itemInstance, FFDIEOBBFKL, HIOAJHJNCPO))
		{
			CMGDCLIIONE = -1f;
			result = true;
		}
		UpdateBasketUI();
		return result;
	}

	public IEnumerator SelectInNextFrame(GameObject HGNKFFMDOOL)
	{
		if ((Object)(object)HGNKFFMDOOL != (Object)null)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
		yield return null;
		if ((Object)(object)HGNKFFMDOOL != (Object)null)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(HGNKFFMDOOL);
		}
	}

	private IEnumerator PBCDJFLNNKG()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		int index = 0;
		for (int i = 0; i < optionsElements.Count; i++)
		{
			if (((Component)optionsElements[i]).gameObject.activeSelf)
			{
				index = i;
				break;
			}
		}
		if (optionsElements.Count > 0 && ((Component)optionsElements[index]).gameObject.activeSelf)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)optionsElements[index]).gameObject);
		}
		else if (basketElements.Count > 0 && ((Component)basketElements[0]).gameObject.activeSelf)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)basketElements[0]).gameObject);
		}
	}

	public void ClearBasket()
	{
		for (int num = GCECCIJABEN.Count - 1; num >= 0; num--)
		{
			RemoveItemFromBasket(GCECCIJABEN[num].currentShopElement, GCECCIJABEN[num].boughtAmount, HIOAJHJNCPO: false);
		}
		UpdateBasketUI();
	}

	protected void FPNILKPDAKD()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || !((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)null))
		{
			return;
		}
		int siblingIndex = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.GetSiblingIndex();
		int num = 0;
		Transform parent = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent;
		for (int i = 0; i < parent.childCount; i++)
		{
			if (((Component)parent.GetChild(i)).gameObject.activeSelf)
			{
				num++;
			}
		}
		if (num <= 1)
		{
			if (ShopUI.Get(base.JIIGOACEIKL).IsOpen())
			{
				OGBKMPPJHON();
			}
			if (AnimalShopUI.Get(base.JIIGOACEIKL).IsOpen())
			{
				AnimalShopUI.Get(base.JIIGOACEIKL).FirstShopElement();
			}
			return;
		}
		for (int j = siblingIndex; j < parent.childCount; j++)
		{
			if (((Component)parent.GetChild(j)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(SelectInNextFrame(((Component)parent.GetChild(j)).gameObject));
				return;
			}
		}
		for (int num2 = siblingIndex - 1; num2 >= 0; num2--)
		{
			if (((Component)parent.GetChild(num2)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(SelectInNextFrame(((Component)parent.GetChild(num2)).gameObject));
				return;
			}
		}
		OGBKMPPJHON();
	}

	protected void GELCMGCKCGG()
	{
		UpdateOptionsUI();
		UpdateBasketUI();
	}

	public int GetBasketTotalWilsonCoins()
	{
		int num = 0;
		foreach (BasketItem item in GCECCIJABEN)
		{
			if (!Item.NGIIPJDAMGP(item.currentShopElement.item, null))
			{
				num += item.currentShopElement.item.wilsonCoinsPrice * item.boughtAmount;
			}
		}
		return num;
	}

	public bool RemoveItem(ItemInstance DNLMCHDOMOK, int FFDIEOBBFKL, bool HIOAJHJNCPO = false)
	{
		for (int i = 0; i < GCECCIJABEN.Count; i++)
		{
			if (GCECCIJABEN[i].currentShopElement.itemInstance != DNLMCHDOMOK)
			{
				continue;
			}
			for (int j = 0; j < FFDIEOBBFKL; j++)
			{
				if (GCECCIJABEN[i].boughtAmount <= 1)
				{
					if (HIOAJHJNCPO)
					{
						FPNILKPDAKD();
					}
					GCECCIJABEN.RemoveAt(i);
					return true;
				}
				BasketItem value = GCECCIJABEN[i];
				value.boughtAmount--;
				GCECCIJABEN[i] = value;
			}
			return false;
		}
		return true;
	}

	protected override void Start()
	{
		base.Start();
		basketElements = new List<ShopElementUI>();
		for (int i = 0; i < 5; i++)
		{
			basketElements.Add(Object.Instantiate<ShopElementUI>(basketElementPrefab, basketListParent.transform));
			basketElements[i].SetPlayerNum(base.JIIGOACEIKL);
			basketElements[i].shopBase = this;
			((Component)basketElements[i]).gameObject.SetActive(false);
		}
	}
}
