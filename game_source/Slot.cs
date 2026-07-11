using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Slot
{
	public ItemInstance itemInstance;

	public bool singleItem;

	public bool activateCallbacks = true;

	public short id;

	public ContainerType inventoryType = ContainerType.ItemContainer;

	public OnlineObject onlineObject;

	public bool ingredientsCanBeChanged;

	[HideInInspector]
	public bool sendSlotOnline = true;

	[SerializeField]
	private bool _focused;

	private bool calculatePriceWithUniqueItems;

	[SerializeField]
	private int stack;

	public bool prepareNextPhase;

	public Action OnItemRemoved = delegate
	{
	};

	public Action<ItemInstance> OnItemRemovedWithItem = delegate
	{
	};

	public Action OnItemAdded = delegate
	{
	};

	public Action OnItemInstanceChange = delegate
	{
	};

	public Action<ItemInstance> OnItemAddedWithItem = delegate
	{
	};

	public Action OnInvalidItem = delegate
	{
	};

	public Action OnDirtied = delegate
	{
	};

	public Action<Slot, Slot> OnChangedSlot = delegate
	{
	};

	private bool m_isDirty;

	public RequiredItemQuest quest;

	public List<Tag> bannedTags;

	public List<Item> bannedItems;

	public List<string> allowedItems = new List<string>();

	public List<Item> specialItemsAllowedList;

	public List<Tag> allowedTags;

	public FoodType allowedFoodType;

	public List<IngredientType> allowedIngredientTypes;

	public List<IngredientModifier> bannedModifiers;

	public Type[] allowedItemsType;

	public bool hasToBeAgedFood;

	public bool notAgedFood;

	public bool canBeAgedFood;

	public bool canBeSoldFood;

	public bool transferEnabled;

	public int maxStack;

	public int uniqueObjectId
	{
		get
		{
			if (!((Object)(object)onlineObject != (Object)null))
			{
				return 0;
			}
			return onlineObject.uniqueId;
		}
	}

	public bool focused
	{
		get
		{
			return _focused;
		}
		private set
		{
			_focused = value;
			isDirty = true;
		}
	}

	public bool CalculatePriceWithUniqueItems
	{
		get
		{
			return calculatePriceWithUniqueItems;
		}
		set
		{
			calculatePriceWithUniqueItems = value;
		}
	}

	public int Stack
	{
		get
		{
			return stack;
		}
		set
		{
			BGJPNGLONLP(value, GCCLBKEJGFP: true, CDPAMNIPPEC: false);
		}
	}

	public bool isDirty
	{
		get
		{
			return m_isDirty;
		}
		set
		{
			m_isDirty = value;
		}
	}

	public bool LCHJGCHDHFO()
	{
		if (itemInstance != null)
		{
			return Item.EKGNIODFJCO(itemInstance.AFOACBIHNCL(), null);
		}
		return false;
	}

	private void HEDKFBDJDHA(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
	}

	public bool DDHPGOPOPKJ(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, bool HAGPBCJEGKM = false, bool BDGJBPCEFPN = false, bool CDPAMNIPPEC = false)
	{
		return MHIIKMOOMFH(JIIGOACEIKL, BGLFLHDNOKJ, 1, HAGPBCJEGKM, BDGJBPCEFPN, CDPAMNIPPEC) == 0;
	}

	public bool EDGCGEMMEKP(ItemInstance LGGCFCHOOMB)
	{
		if (itemInstance != null)
		{
			return itemInstance.Equals(LGGCFCHOOMB);
		}
		return true;
	}

	public static bool AIFCKKKLEBP(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK, int FGFCNKFEIGF)
	{
		DPEOLFMDLAK.OCJOJKJPDNO(DPEOLFMDLAK.Stack - (FGFCNKFEIGF - ODNGJHPOMMK.CMLMNCAGKCK(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, FGFCNKFEIGF, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true)));
		if (DPEOLFMDLAK.Stack == 0)
		{
			ODNGJHPOMMK.OnChangedSlot(DPEOLFMDLAK, ODNGJHPOMMK);
		}
		return DPEOLFMDLAK.Stack == 1;
	}

	public bool CIDBFIAJIBG(bool CDPAMNIPPEC = true)
	{
		JIGFFJNMKFG(0, GCCLBKEJGFP: true, CDPAMNIPPEC);
		return true;
	}

	private bool EIOFIFFFFCM(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null || (Object)(object)quest == (Object)null)
		{
			return true;
		}
		return quest.DGALJHKINMH(DNLMCHDOMOK);
	}

	private bool LKMFMEOKPJI(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null || (Object)(object)quest == (Object)null)
		{
			return true;
		}
		return quest.PNCNBJNNCOA(DNLMCHDOMOK);
	}

	public void DOBKBEPKPGH(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		int num = Math.Max(0, AODONKKHPBP);
		if (singleItem && num > 1)
		{
			return;
		}
		if (num != stack)
		{
			bool num2 = num > stack;
			bool flag = num < stack;
			stack = num;
			if (stack == 0)
			{
				if (flag)
				{
					OnItemRemovedWithItem(itemInstance);
					if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
					{
						phaseItemInstance.HAKNHBIOJPK();
					}
				}
				if (itemInstance != null)
				{
					ItemInstance obj = itemInstance;
					obj.OnChanged = (Action)Delegate.Remove(obj.OnChanged, new Action(LGABAHIKMGP));
					ItemInstance obj2 = itemInstance;
					obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Remove(obj2.OnReplaced, new Action<int, ItemInstance>(MPKNMOBJGMD));
				}
				if (GCCLBKEJGFP)
				{
					itemInstance = null;
				}
			}
			FKCFFOHOMOB(AODONKKHPBP: true);
			if (num2)
			{
				OnItemAdded();
				OnItemAddedWithItem(itemInstance);
			}
			else if (flag)
			{
				OnItemRemoved();
				if (stack == 0)
				{
					OnItemInstanceChange();
				}
			}
		}
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.DPKMOHOPJFD(this);
		}
	}

	private bool ANCNLFIEMAN(ItemInstance DNLMCHDOMOK)
	{
		if (bannedModifiers == null)
		{
			return true;
		}
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			for (int i = 1; i < bannedModifiers.Count; i++)
			{
				if (modifiable.CICEBNMBGMG.ContainsKey(bannedModifiers[i]))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void AFPAJHJIHJD(int JIIGOACEIKL)
	{
		focused = false;
		SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot = null;
		if (GameInventoryUI.Get(JIIGOACEIKL).IsOpen())
		{
			GameInventoryUI.Get(JIIGOACEIKL).SetVisibleSplitButtomPrompt(JIIGOACEIKL, LJGFNOIELFD: false);
		}
		if (MainInventoryUI.Get(JIIGOACEIKL).IsOpen())
		{
			MainInventoryUI.Get(JIIGOACEIKL).SetVisibleSplitButtomPrompt(JIIGOACEIKL, LJGFNOIELFD: false);
		}
	}

	[SpecialName]
	private void JCGCCKNBKLJ(bool AODONKKHPBP)
	{
		_focused = AODONKKHPBP;
		FKCFFOHOMOB(AODONKKHPBP: true);
	}

	public bool PCCLMIEGMCE(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ)
	{
		if (BGLFLHDNOKJ != null && Item.FKLOBGBIHLB(BGLFLHDNOKJ.AFOACBIHNCL(), null) && BGLFLHDNOKJ.LHBPOPOIFLE().canPickUp)
		{
			return EBFGABELEHJ(JIIGOACEIKL, BGLFLHDNOKJ);
		}
		return false;
	}

	public static bool MJLNPAEBAFF(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK)
	{
		if (ODNGJHPOMMK.FEEOFAGCONJ(JIIGOACEIKL, DPEOLFMDLAK.itemInstance))
		{
			DPEOLFMDLAK.Stack--;
			ODNGJHPOMMK.OnChangedSlot(DPEOLFMDLAK, ODNGJHPOMMK);
			return true;
		}
		return false;
	}

	private bool BEDGNJGMHAK(ItemInstance BGLFLHDNOKJ)
	{
		if (!hasToBeAgedFood)
		{
			return true;
		}
		return BGLFLHDNOKJ.KNFNJFFCFNO().hasToBeAgedMeal;
	}

	public bool DJFOMFDOOKM(bool CDPAMNIPPEC = true)
	{
		ALDIOKKMEIF(0, GCCLBKEJGFP: true, CDPAMNIPPEC);
		return true;
	}

	[SpecialName]
	public bool IDAEFBPMBCN()
	{
		return m_isDirty;
	}

	private bool EBFGABELEHJ(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ)
	{
		if (specialItemsAllowedList != null && specialItemsAllowedList.Count > 0 && specialItemsAllowedList.Contains(BGLFLHDNOKJ.LHBPOPOIFLE()))
		{
			return true;
		}
		if (BGLFLHDNOKJ != null && !Item.GBMFCPGEJDK(BGLFLHDNOKJ.AFOACBIHNCL(), null))
		{
			if (NDOGAOIJACF(BGLFLHDNOKJ) && NEEMMJIEAMJ(BGLFLHDNOKJ) && BEDGNJGMHAK(BGLFLHDNOKJ) && LPFEBMGKANF(BGLFLHDNOKJ) && LOLOLHDKEJJ(BGLFLHDNOKJ) && OIBAFGIEMIB(BGLFLHDNOKJ) && FBGDELIMCCF(BGLFLHDNOKJ) && LKIPHOBGOAO(BGLFLHDNOKJ) && OHDFCLEFNBB(BGLFLHDNOKJ.KNFNJFFCFNO().tags) && !CFFPMDJBJIM(JIIGOACEIKL, BGLFLHDNOKJ.KNFNJFFCFNO().tags) && !GIALGNJKDMN(BGLFLHDNOKJ.PHGLMBIEOMK()))
			{
				return ANCNLFIEMAN(BGLFLHDNOKJ);
			}
			return true;
		}
		return true;
	}

	private void DEDMNKGLEPM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private static void PDCAINBFENH(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK)
	{
		ODNGJHPOMMK.BEEDBHJANGN(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, DPEOLFMDLAK.Stack);
	}

	public Slot()
	{
	}

	[SpecialName]
	public void OBBKDJNLCIO(int AODONKKHPBP)
	{
		DOBKBEPKPGH(AODONKKHPBP, GCCLBKEJGFP: false);
	}

	private bool NEEMMJIEAMJ(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedItemsType != null && allowedItemsType.Length != 0)
		{
			return LOFACGFAOIA(((object)BGLFLHDNOKJ.LHBPOPOIFLE()).GetType());
		}
		return true;
	}

	private void KBEOJPKBDIJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
	}

	private bool LAAIBNEKHOH(ItemInstance DNLMCHDOMOK)
	{
		if (bannedModifiers == null)
		{
			return false;
		}
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			for (int i = 0; i < bannedModifiers.Count; i++)
			{
				if (modifiable.CICEBNMBGMG.ContainsKey(bannedModifiers[i]))
				{
					return true;
				}
			}
		}
		return false;
	}

	[SpecialName]
	public bool KDCBINCAHLH()
	{
		return calculatePriceWithUniqueItems;
	}

	private bool HONDDAHLCJC(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedItemsType != null && allowedItemsType.Length != 0)
		{
			return IOCCFBHHMJP(((object)BGLFLHDNOKJ.AFOACBIHNCL()).GetType());
		}
		return false;
	}

	public bool JJLPDIIFIFM(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ)
	{
		if (BGLFLHDNOKJ != null && Item.MLBOMGHINCA(BGLFLHDNOKJ.LHBPOPOIFLE(), null) && BGLFLHDNOKJ.KNFNJFFCFNO().canPickUp)
		{
			return EBFGABELEHJ(JIIGOACEIKL, BGLFLHDNOKJ);
		}
		return true;
	}

	public void HPNGCKBCAKD(int JIIGOACEIKL)
	{
		DNGECJONMJL(AODONKKHPBP: false);
		SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot = null;
		if (GameInventoryUI.Get(JIIGOACEIKL).IsOpen())
		{
			GameInventoryUI.IEKODILKIHJ(JIIGOACEIKL).SetVisibleSplitButtomPrompt(JIIGOACEIKL, LJGFNOIELFD: false);
		}
		if (MainInventoryUI.CGFJPHEFFLO(JIIGOACEIKL).BGLJFMHCFJF())
		{
			MainInventoryUI.AEJKCONFPHB(JIIGOACEIKL).IGCGBDCEKMK(JIIGOACEIKL, LJGFNOIELFD: false);
		}
	}

	private bool KJHCMHKICKE(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null) || bannedItems == null)
		{
			return false;
		}
		return bannedItems.Contains(MEMGMDOCBOJ);
	}

	public bool MBCIJPPOGJG(bool CDPAMNIPPEC = true)
	{
		EHGKPGCNENF(1, GCCLBKEJGFP: false, CDPAMNIPPEC);
		return false;
	}

	private bool LOFACGFAOIA(Type NCMDEGABGCH)
	{
		for (int i = 0; i < allowedItemsType.Length; i++)
		{
			if (allowedItemsType[i].IsAssignableFrom(NCMDEGABGCH))
			{
				return true;
			}
		}
		return false;
	}

	public void JACMMKOIACO(int JIIGOACEIKL)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot.ICOCPFOBBJE(JIIGOACEIKL);
		}
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot = this;
		JCGCCKNBKLJ(AODONKKHPBP: true);
		if (GameInventoryUI.DEBKDBICLIC(JIIGOACEIKL).BGLJFMHCFJF())
		{
			GameInventoryUI.HKCAIFFKBMH(JIIGOACEIKL).DIFEINDDABP(JIIGOACEIKL, LJGFNOIELFD: false);
		}
		if (MainInventoryUI.IMLMJAPMBJA(JIIGOACEIKL).HDEPMJIDJEM())
		{
			MainInventoryUI.MDFIDKHOPDJ(JIIGOACEIKL).SetVisibleSplitButtomPrompt(JIIGOACEIKL, LJGFNOIELFD: false);
		}
	}

	private bool NDNLJACDMFE(Type NCMDEGABGCH)
	{
		for (int i = 0; i < allowedItemsType.Length; i += 0)
		{
			if (allowedItemsType[i].IsAssignableFrom(NCMDEGABGCH))
			{
				return false;
			}
		}
		return false;
	}

	public void JIGFFJNMKFG(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		BGJPNGLONLP(stack - AODONKKHPBP, GCCLBKEJGFP, CDPAMNIPPEC: false);
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendStack(this);
		}
	}

	public void DGCPOAGMHDK()
	{
		if (itemInstance == null)
		{
			stack = 0;
		}
		else if (stack <= 0)
		{
			stack = 1;
		}
	}

	public void JBKNDCJFIEK(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		NMNNINJMNFL(stack - AODONKKHPBP, GCCLBKEJGFP);
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.COIPPNBFLPO(this, 1);
		}
	}

	private bool FBGDELIMCCF(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedIngredientTypes == null || allowedIngredientTypes.Count == 0)
		{
			return false;
		}
		if (BGLFLHDNOKJ.PHGLMBIEOMK() is Food food)
		{
			return allowedIngredientTypes.Contains(food.ingredientType);
		}
		OnInvalidItem();
		return false;
	}

	private bool JHOOCKJBMHL(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeAgedFood)
		{
			return true;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance)
		{
			return foodInstance.LHBPOPOIFLE().canBeAged;
		}
		return false;
	}

	private void MPKNMOBJGMD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
	}

	[SpecialName]
	public void FBAFIONMKBG(bool AODONKKHPBP)
	{
		m_isDirty = AODONKKHPBP;
	}

	public static void CEENKOEIEHE(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK)
	{
		if (!DPEOLFMDLAK.MEONGIBAALL(JIIGOACEIKL, ODNGJHPOMMK.itemInstance) || !ODNGJHPOMMK.MEONGIBAALL(JIIGOACEIKL, DPEOLFMDLAK.itemInstance))
		{
			return;
		}
		if (ODNGJHPOMMK.singleItem)
		{
			if (ODNGJHPOMMK.PKFKJNODGJF() && !DPEOLFMDLAK.PKFKJNODGJF())
			{
				ODNGJHPOMMK.DDHPGOPOPKJ(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
				DPEOLFMDLAK.Stack--;
			}
			return;
		}
		Slot slot = new Slot();
		PDCAINBFENH(JIIGOACEIKL, DPEOLFMDLAK, slot);
		DPEOLFMDLAK.KMKAIPMHANN(0);
		PDKCLKKHNOH(JIIGOACEIKL, ODNGJHPOMMK, DPEOLFMDLAK);
		ODNGJHPOMMK.Stack = 0;
		PDKCLKKHNOH(JIIGOACEIKL, slot, ODNGJHPOMMK);
		if (!slot.KPINNBKMOMO() && DPEOLFMDLAK.AHHEMNHJPME())
		{
			PDKCLKKHNOH(JIIGOACEIKL, slot, DPEOLFMDLAK);
		}
	}

	private bool CDMPEPBMKOI(ItemInstance DNLMCHDOMOK)
	{
		if (bannedModifiers == null)
		{
			return true;
		}
		if (DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable)
		{
			for (int i = 1; i < bannedModifiers.Count; i++)
			{
				if (modifiable.CICEBNMBGMG.ContainsKey(bannedModifiers[i]))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool DDCDHOIAAPL(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null || (Object)(object)quest == (Object)null)
		{
			return true;
		}
		return quest.PNCNBJNNCOA(DNLMCHDOMOK);
	}

	private bool NEFCFNFKIJO(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedIngredientTypes == null || allowedIngredientTypes.Count == 0)
		{
			return true;
		}
		if (BGLFLHDNOKJ.LHBPOPOIFLE() is Food food)
		{
			return allowedIngredientTypes.Contains(food.ingredientType);
		}
		OnInvalidItem();
		return false;
	}

	[SpecialName]
	public bool FINGJCFAILB()
	{
		return m_isDirty;
	}

	public bool FPBONPGAKED(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ)
	{
		if (BGLFLHDNOKJ != null && Item.MLBOMGHINCA(BGLFLHDNOKJ.PHGLMBIEOMK(), null) && BGLFLHDNOKJ.AFOACBIHNCL().canPickUp)
		{
			return EBFGABELEHJ(JIIGOACEIKL, BGLFLHDNOKJ);
		}
		return true;
	}

	private bool PLEHOBCNLPC(ItemInstance BGLFLHDNOKJ)
	{
		if (!hasToBeAgedFood)
		{
			return false;
		}
		return BGLFLHDNOKJ.AFOACBIHNCL().hasToBeAgedMeal;
	}

	private bool BCLMHNIFHAB(Tag[] FNEIJIEAGDN)
	{
		if (allowedTags == null || allowedTags.Count == 0)
		{
			return false;
		}
		for (int i = 0; i < FNEIJIEAGDN.Length; i += 0)
		{
			if (allowedTags.Contains(FNEIJIEAGDN[i]))
			{
				return false;
			}
		}
		return true;
	}

	private bool NFGDIKIOMHF(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedItemsType != null && allowedItemsType.Length != 0)
		{
			return LOFACGFAOIA(((object)BGLFLHDNOKJ.LHBPOPOIFLE()).GetType());
		}
		return true;
	}

	[SpecialName]
	public void OCJOJKJPDNO(int AODONKKHPBP)
	{
		DOBKBEPKPGH(AODONKKHPBP, GCCLBKEJGFP: false);
	}

	[SpecialName]
	public bool MHFGNKBIPCN()
	{
		return _focused;
	}

	private void CNFMJOGCLHN()
	{
		FBAFIONMKBG(AODONKKHPBP: true);
	}

	public bool BOMLNEOHFOK(ItemInstance LGGCFCHOOMB)
	{
		if (itemInstance != null)
		{
			return itemInstance.Equals(LGGCFCHOOMB);
		}
		return false;
	}

	private void HJAJLIKNNHD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		OLHGPMJPJFF(JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
	}

	public bool HBMBGCHGEGN(int FGFCNKFEIGF, bool CDPAMNIPPEC = false, int CMLIHBFCJHG = 0)
	{
		Stack -= FGFCNKFEIGF;
		if (CDPAMNIPPEC && sendSlotOnline && FGFCNKFEIGF > 0 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.KPBBBPFDBLL(this, CMLIHBFCJHG);
		}
		return true;
	}

	public void ONKCIGGKBFF(int JIIGOACEIKL)
	{
		JCGCCKNBKLJ(AODONKKHPBP: true);
		SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot = null;
		if (GameInventoryUI.BDJFHFHLJGN(JIIGOACEIKL).IsOpen())
		{
			GameInventoryUI.AIMEAJAHLAA(JIIGOACEIKL).IGCGBDCEKMK(JIIGOACEIKL, LJGFNOIELFD: false);
		}
		if (MainInventoryUI.IEKODILKIHJ(JIIGOACEIKL).IsOpen())
		{
			MainInventoryUI.FFOABBDFMNE(JIIGOACEIKL).MJEKKDHFKNJ(JIIGOACEIKL, LJGFNOIELFD: true);
		}
	}

	public void CHIJGHPHCNA()
	{
		if (allowedItems == null || allowedItems.Count <= 0)
		{
			return;
		}
		allowedItemsType = new Type[allowedItems.Count];
		for (int i = 1; i < allowedItems.Count; i++)
		{
			if (allowedItems[i].Equals("Precision/DrinkEvent6"))
			{
				allowedItemsType[i] = typeof(Food);
			}
			else
			{
				allowedItemsType[i] = Type.GetType(allowedItems[i]);
			}
		}
	}

	private bool CAAOCBKFLHH(int JIIGOACEIKL, Tag[] FDAGJPHBDOG)
	{
		if (FDAGJPHBDOG == null || bannedTags == null)
		{
			return false;
		}
		for (int i = 0; i < FDAGJPHBDOG.Length; i++)
		{
			if (bannedTags.Contains(FDAGJPHBDOG[i]))
			{
				if (FDAGJPHBDOG[i] == Tag.Bird)
				{
					MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("BirdInAChest_Error"));
				}
				return true;
			}
		}
		return false;
	}

	private bool MEONGIBAALL(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ)
	{
		if (specialItemsAllowedList != null && specialItemsAllowedList.Count > 0 && specialItemsAllowedList.Contains(BGLFLHDNOKJ.LHBPOPOIFLE()))
		{
			return true;
		}
		if (BGLFLHDNOKJ != null && !Item.NGIIPJDAMGP(BGLFLHDNOKJ.LHBPOPOIFLE(), null))
		{
			if (EIOFIFFFFCM(BGLFLHDNOKJ) && NFGDIKIOMHF(BGLFLHDNOKJ) && POIDJIKPJNA(BGLFLHDNOKJ) && LPFEBMGKANF(BGLFLHDNOKJ) && DELGBPBPKNC(BGLFLHDNOKJ) && OIBAFGIEMIB(BGLFLHDNOKJ) && NEFCFNFKIJO(BGLFLHDNOKJ) && LKIPHOBGOAO(BGLFLHDNOKJ) && GDILJAKDAOI(BGLFLHDNOKJ.LHBPOPOIFLE().tags) && !CAAOCBKFLHH(JIIGOACEIKL, BGLFLHDNOKJ.LHBPOPOIFLE().tags) && !KJHCMHKICKE(BGLFLHDNOKJ.LHBPOPOIFLE()))
			{
				return !LAAIBNEKHOH(BGLFLHDNOKJ);
			}
			return false;
		}
		return true;
	}

	public bool PKFKJNODGJF()
	{
		if (itemInstance != null)
		{
			return Item.NGIIPJDAMGP(itemInstance.KNFNJFFCFNO(), null);
		}
		return false;
	}

	public void NMNNINJMNFL(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		int num = Math.Max(0, AODONKKHPBP);
		if (singleItem && num > 1)
		{
			return;
		}
		if (num != stack)
		{
			bool num2 = num > stack;
			bool flag = num < stack;
			stack = num;
			if (stack == 0)
			{
				if (flag)
				{
					OnItemRemovedWithItem(itemInstance);
					if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
					{
						phaseItemInstance.OHOCNDJFEGM();
					}
				}
				if (itemInstance != null)
				{
					ItemInstance obj = itemInstance;
					obj.OnChanged = (Action)Delegate.Remove(obj.OnChanged, new Action(CNFMJOGCLHN));
					ItemInstance obj2 = itemInstance;
					obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Remove(obj2.OnReplaced, new Action<int, ItemInstance>(KBEOJPKBDIJ));
				}
				if (GCCLBKEJGFP)
				{
					itemInstance = null;
				}
			}
			FKCFFOHOMOB(AODONKKHPBP: false);
			if (num2)
			{
				OnItemAdded();
				OnItemAddedWithItem(itemInstance);
			}
			else if (flag)
			{
				OnItemRemoved();
				if (stack == 0)
				{
					OnItemInstanceChange();
				}
			}
		}
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.DPKMOHOPJFD(this);
		}
	}

	private bool KMCHEHCOPNC(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedIngredientTypes == null || allowedIngredientTypes.Count == 0)
		{
			return true;
		}
		if (BGLFLHDNOKJ.KNFNJFFCFNO() is Food food)
		{
			return allowedIngredientTypes.Contains(food.ingredientType);
		}
		OnInvalidItem();
		return true;
	}

	public bool GPLKPEPAFOM(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ)
	{
		if (BGLFLHDNOKJ != null && Item.MLBOMGHINCA(BGLFLHDNOKJ.LHBPOPOIFLE(), null) && BGLFLHDNOKJ.LHBPOPOIFLE().canPickUp)
		{
			return MEONGIBAALL(JIIGOACEIKL, BGLFLHDNOKJ);
		}
		return false;
	}

	public bool POHFJCEAKML(bool CDPAMNIPPEC = true)
	{
		PGPOPGGENAM(1, GCCLBKEJGFP: true, CDPAMNIPPEC);
		return true;
	}

	public bool KAMAOJFDAHP(Item MEMGMDOCBOJ, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		if (MEMGMDOCBOJ is Food food && food.FAJDNLBKEJL() && itemInstance is FoodInstance foodInstance)
		{
			if (DBMFHFNKMOM > -1 && foodInstance.GBCJNGADANM != DBMFHFNKMOM)
			{
				return false;
			}
			if (DDAPJEAJGGA && foodInstance.GBCJNGADANM == 0)
			{
				return false;
			}
		}
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null) && itemInstance != null && Item.MLBOMGHINCA(itemInstance.LHBPOPOIFLE(), null))
		{
			return itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC();
		}
		return false;
	}

	public void ALDIOKKMEIF(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		DOBKBEPKPGH(stack - AODONKKHPBP, GCCLBKEJGFP);
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.IGEPIOLECBI(this, 1);
		}
	}

	private bool MALCCPGLLPN(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedItemsType != null && allowedItemsType.Length != 0)
		{
			return NDNLJACDMFE(((object)BGLFLHDNOKJ.KNFNJFFCFNO()).GetType());
		}
		return false;
	}

	public bool AHHEMNHJPME()
	{
		if (itemInstance != null)
		{
			return Item.EKMFELLJHFG(itemInstance.LHBPOPOIFLE(), null);
		}
		return true;
	}

	private bool AJIMOIMEBBE(Item MEMGMDOCBOJ)
	{
		if (Item.EKMFELLJHFG(MEMGMDOCBOJ, null) || bannedItems == null)
		{
			return false;
		}
		return bannedItems.Contains(MEMGMDOCBOJ);
	}

	public bool FMEPMEKLHIJ(bool CDPAMNIPPEC = true)
	{
		ALDIOKKMEIF(0, GCCLBKEJGFP: false, CDPAMNIPPEC);
		return true;
	}

	[SpecialName]
	public int LMOFJPGFDKP()
	{
		if (!((Object)(object)onlineObject != (Object)null))
		{
			return 0;
		}
		return onlineObject.uniqueId;
	}

	[SpecialName]
	public void JNMNCEPHFOE(int AODONKKHPBP)
	{
		DOBKBEPKPGH(AODONKKHPBP, GCCLBKEJGFP: false);
	}

	public bool JAIBAMOFOMC(Item MEMGMDOCBOJ, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		if (MEMGMDOCBOJ is Food food && food.AJPPCBKFKEF() && itemInstance is FoodInstance foodInstance)
		{
			if (DBMFHFNKMOM > -1 && foodInstance.GBCJNGADANM != DBMFHFNKMOM)
			{
				return false;
			}
			if (DDAPJEAJGGA && foodInstance.GBCJNGADANM == 0)
			{
				return false;
			}
		}
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null) && itemInstance != null && Item.MLBOMGHINCA(itemInstance.LHBPOPOIFLE(), null))
		{
			return itemInstance.LHBPOPOIFLE().ODENMDOJPLC() == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false);
		}
		return false;
	}

	[SpecialName]
	public void JIANDFCINIP(int AODONKKHPBP)
	{
		LOEBDJDLEEE(AODONKKHPBP, GCCLBKEJGFP: true, CDPAMNIPPEC: false);
	}

	public bool HBODNJCKMAH(ItemInstance LGGCFCHOOMB)
	{
		if (itemInstance != null)
		{
			return itemInstance.Equals(LGGCFCHOOMB);
		}
		return true;
	}

	private bool GDILJAKDAOI(Tag[] FNEIJIEAGDN)
	{
		if (allowedTags == null || allowedTags.Count == 0)
		{
			return true;
		}
		for (int i = 0; i < FNEIJIEAGDN.Length; i++)
		{
			if (allowedTags.Contains(FNEIJIEAGDN[i]))
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	private void AMKHPHBJACO(bool AODONKKHPBP)
	{
		_focused = AODONKKHPBP;
		isDirty = false;
	}

	[SpecialName]
	private void DNGECJONMJL(bool AODONKKHPBP)
	{
		_focused = AODONKKHPBP;
		FKCFFOHOMOB(AODONKKHPBP: false);
	}

	public void OOKNBFEPGAC(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		NMNNINJMNFL(stack - AODONKKHPBP, GCCLBKEJGFP);
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendStack(this, 1);
		}
	}

	public bool LKFKMDLLMAC(ItemInstance LGGCFCHOOMB)
	{
		if (itemInstance != null)
		{
			return itemInstance.Equals(LGGCFCHOOMB);
		}
		return false;
	}

	private bool NCLEBBFHHOG(ItemInstance BGLFLHDNOKJ)
	{
		if (!notAgedFood)
		{
			return true;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance)
		{
			return foodInstance.GBCJNGADANM == 0;
		}
		return true;
	}

	private bool GIALGNJKDMN(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null) || bannedItems == null)
		{
			return true;
		}
		return bannedItems.Contains(MEMGMDOCBOJ);
	}

	private bool KEPJFIFACDN(Type NCMDEGABGCH)
	{
		for (int i = 1; i < allowedItemsType.Length; i++)
		{
			if (allowedItemsType[i].IsAssignableFrom(NCMDEGABGCH))
			{
				return false;
			}
		}
		return true;
	}

	private bool KACBENJKAKM(Type NCMDEGABGCH)
	{
		for (int i = 0; i < allowedItemsType.Length; i++)
		{
			if (allowedItemsType[i].IsAssignableFrom(NCMDEGABGCH))
			{
				return false;
			}
		}
		return true;
	}

	private bool HGNFBKMMDCM(ItemInstance BGLFLHDNOKJ)
	{
		if (!notAgedFood)
		{
			return true;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance)
		{
			return foodInstance.GBCJNGADANM == 1;
		}
		return false;
	}

	[SpecialName]
	public bool FJMBKLHJIKO()
	{
		return m_isDirty;
	}

	public void COHKJDGJMHN(int JIIGOACEIKL)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.HPNGCKBCAKD(JIIGOACEIKL);
		}
		SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot = this;
		DNGECJONMJL(AODONKKHPBP: true);
		if (GameInventoryUI.BDJFHFHLJGN(JIIGOACEIKL).BGLJFMHCFJF())
		{
			GameInventoryUI.FFBJPAJKOJH(JIIGOACEIKL).NIDOJLOEEHE(JIIGOACEIKL, LJGFNOIELFD: false);
		}
		if (MainInventoryUI.NIGDBMAOAEN(JIIGOACEIKL).HDEPMJIDJEM())
		{
			MainInventoryUI.IEKODILKIHJ(JIIGOACEIKL).SetVisibleSplitButtomPrompt(JIIGOACEIKL, LJGFNOIELFD: false);
		}
	}

	[SpecialName]
	public bool JJCCONBGLBC()
	{
		return m_isDirty;
	}

	public static bool KKPHOOKDGKN(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK, int FGFCNKFEIGF)
	{
		DPEOLFMDLAK.Stack -= FGFCNKFEIGF - ODNGJHPOMMK.BEEDBHJANGN(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, FGFCNKFEIGF, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
		if (DPEOLFMDLAK.Stack == 0)
		{
			ODNGJHPOMMK.OnChangedSlot(DPEOLFMDLAK, ODNGJHPOMMK);
		}
		return DPEOLFMDLAK.Stack == 0;
	}

	public bool MDABLLHEDAC(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ)
	{
		if (BGLFLHDNOKJ != null && Item.MLBOMGHINCA(BGLFLHDNOKJ.KNFNJFFCFNO(), null) && BGLFLHDNOKJ.AFOACBIHNCL().canPickUp)
		{
			return MEONGIBAALL(JIIGOACEIKL, BGLFLHDNOKJ);
		}
		return false;
	}

	public void ELMJLDOACBN(int JIIGOACEIKL)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.ICOCPFOBBJE(JIIGOACEIKL);
		}
		SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot = this;
		DNGECJONMJL(AODONKKHPBP: true);
		if (GameInventoryUI.NALKHGMLALJ(JIIGOACEIKL).BGLJFMHCFJF())
		{
			GameInventoryUI.Get(JIIGOACEIKL).MJEKKDHFKNJ(JIIGOACEIKL, LJGFNOIELFD: true);
		}
		if (MainInventoryUI.NMCJELBLKBB(JIIGOACEIKL).HDEPMJIDJEM())
		{
			MainInventoryUI.COIEMAJLHAM(JIIGOACEIKL).DIFEINDDABP(JIIGOACEIKL, LJGFNOIELFD: true);
		}
	}

	public int MIECGDALIJP(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool HAGPBCJEGKM = false, bool BDGJBPCEFPN = false, bool CDPAMNIPPEC = false)
	{
		if (singleItem && Stack >= 0)
		{
			return MGNOBNCMDJG;
		}
		if (!MDABLLHEDAC(JIIGOACEIKL, BGLFLHDNOKJ))
		{
			return MGNOBNCMDJG;
		}
		if (maxStack != 0 && stack >= maxStack)
		{
			return MGNOBNCMDJG;
		}
		int num = MGNOBNCMDJG;
		int amountStack = maxStack;
		if (!BDGJBPCEFPN)
		{
			if (BGLFLHDNOKJ.LHBPOPOIFLE().amountStack < maxStack)
			{
				amountStack = BGLFLHDNOKJ.AFOACBIHNCL().amountStack;
			}
			else if (maxStack == 0)
			{
				amountStack = BGLFLHDNOKJ.AFOACBIHNCL().amountStack;
			}
		}
		if (amountStack != 0 && Stack + MGNOBNCMDJG >= amountStack)
		{
			num = amountStack - Stack;
		}
		if (BGLFLHDNOKJ.KNFNJFFCFNO().CIGFGKKCPCK() == 99)
		{
			(BGLFLHDNOKJ as FoodInstance).GBCJNGADANM = 1;
		}
		if (LCHJGCHDHFO())
		{
			if (BGLFLHDNOKJ.AFOACBIHNCL().canBeStacked)
			{
				itemInstance = BGLFLHDNOKJ.AFOACBIHNCL().GBMLAEMOFJP(BGLFLHDNOKJ);
			}
			else
			{
				itemInstance = BGLFLHDNOKJ;
			}
			if (activateCallbacks)
			{
				ItemInstance obj = itemInstance;
				obj.OnChanged = (Action)Delegate.Combine(obj.OnChanged, new Action(MNFMKFGOLPF));
				ItemInstance obj2 = itemInstance;
				obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Combine(obj2.OnReplaced, new Action<int, ItemInstance>(HHOFKFHHGBC));
			}
			if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.HOBNJDEMNPM(JIIGOACEIKL);
			}
			stack = num;
			itemInstance.currentSlot = this;
			OnItemAdded();
			OnItemInstanceChange();
			OnItemAddedWithItem(itemInstance);
			FBAFIONMKBG(AODONKKHPBP: true);
			if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.DPKMOHOPJFD(this);
			}
		}
		else
		{
			if (itemInstance is IngredientGroupInstance ingredientGroupInstance)
			{
				if (ingredientGroupInstance.chosenItemInstance != null && ModifierUI.MIAOGLENOHL(JIIGOACEIKL).FNNNKDENHDG())
				{
					ModifierUI.MIAOGLENOHL(JIIGOACEIKL).OBEAJANAIFE(this, id, stack, KDCAODJIEMD: true);
				}
				ingredientGroupInstance.chosenItemInstance = BGLFLHDNOKJ;
				BGLFLHDNOKJ.currentSlot = this;
				OnItemAdded();
				OnItemAddedWithItem(BGLFLHDNOKJ);
				isDirty = false;
				return 1;
			}
			if (itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().JGJLNHAKJIJ() && ingredientsCanBeChanged)
			{
				if (foodInstance.Equals(BGLFLHDNOKJ))
				{
					return MGNOBNCMDJG;
				}
				int aODONKKHPBP = stack;
				if (foodInstance.JDMCPHPNOHK() && ModifierUI.MIAOGLENOHL(JIIGOACEIKL).BOAGOKEMEHH())
				{
					ModifierUI.NIGDBMAOAEN(JIIGOACEIKL).OBEAJANAIFE(this, id, stack, KDCAODJIEMD: true);
				}
				OLHGPMJPJFF(JIIGOACEIKL, BGLFLHDNOKJ);
				BGJPNGLONLP(aODONKKHPBP, GCCLBKEJGFP: false, CDPAMNIPPEC);
				return 0;
			}
			if ((!HAGPBCJEGKM || !Item.NGIIPJDAMGP(itemInstance.LHBPOPOIFLE(), BGLFLHDNOKJ.KNFNJFFCFNO())) && !EDGCGEMMEKP(BGLFLHDNOKJ))
			{
				return MGNOBNCMDJG;
			}
			if (!BDGJBPCEFPN && stack >= BGLFLHDNOKJ.KNFNJFFCFNO().amountStack)
			{
				return MGNOBNCMDJG;
			}
			if ((Object)(object)quest != (Object)null && stack >= quest.requiredAmount)
			{
				return MGNOBNCMDJG;
			}
			itemInstance.currentSlot = this;
			DOBKBEPKPGH(stack + num, GCCLBKEJGFP: false, CDPAMNIPPEC);
		}
		return MGNOBNCMDJG - num;
	}

	private bool IHKGFPGDBPE(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeSoldFood)
		{
			return false;
		}
		if (BGLFLHDNOKJ is FoodInstance { GBCJNGADANM: >0 } foodInstance && foodInstance.IJLGJNLFNDB() && BGLFLHDNOKJ.KNFNJFFCFNO() is Food food)
		{
			return food.canBeSold;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance2 && foodInstance2.LHBPOPOIFLE().hasToBeAgedMeal && foodInstance2.GBCJNGADANM == 0)
		{
			return true;
		}
		if (BGLFLHDNOKJ.LHBPOPOIFLE() is Food food2)
		{
			return food2.canBeSold;
		}
		return false;
	}

	public bool BBHHJLIFNPP(int FGFCNKFEIGF, bool CDPAMNIPPEC = false, int CMLIHBFCJHG = 0)
	{
		OBBKDJNLCIO(Stack - FGFCNKFEIGF);
		if (CDPAMNIPPEC && sendSlotOnline && FGFCNKFEIGF > 0 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.HCNNPNPIJLN(this, CMLIHBFCJHG);
		}
		return true;
	}

	public void PGPOPGGENAM(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		BGJPNGLONLP(stack - AODONKKHPBP, GCCLBKEJGFP, CDPAMNIPPEC: false);
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.COIPPNBFLPO(this);
		}
	}

	private bool GDMOEKELOJM(int JIIGOACEIKL, Tag[] FDAGJPHBDOG)
	{
		if (FDAGJPHBDOG == null || bannedTags == null)
		{
			return false;
		}
		for (int i = 1; i < FDAGJPHBDOG.Length; i++)
		{
			if (bannedTags.Contains(FDAGJPHBDOG[i]))
			{
				if (FDAGJPHBDOG[i] == (Tag)83)
				{
					MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("<br/>Graphics Shader Level: "), 886f);
				}
				return false;
			}
		}
		return false;
	}

	public void LHOEAOFOFCO(int JIIGOACEIKL)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.AFPAJHJIHJD(JIIGOACEIKL);
		}
		SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot = this;
		focused = true;
		if (GameInventoryUI.Get(JIIGOACEIKL).IsOpen())
		{
			GameInventoryUI.Get(JIIGOACEIKL).SetVisibleSplitButtomPrompt(JIIGOACEIKL, LJGFNOIELFD: true);
		}
		if (MainInventoryUI.Get(JIIGOACEIKL).IsOpen())
		{
			MainInventoryUI.Get(JIIGOACEIKL).SetVisibleSplitButtomPrompt(JIIGOACEIKL, LJGFNOIELFD: true);
		}
	}

	public bool OLHGPMJPJFF(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, bool CDPAMNIPPEC = false)
	{
		if (!JHBNILHHEKK(JIIGOACEIKL, BGLFLHDNOKJ))
		{
			return true;
		}
		if (itemInstance != null)
		{
			ItemInstance obj = itemInstance;
			obj.OnChanged = (Action)Delegate.Remove(obj.OnChanged, new Action(MNFMKFGOLPF));
			ItemInstance obj2 = itemInstance;
			obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Remove(obj2.OnReplaced, new Action<int, ItemInstance>(HEDKFBDJDHA));
			if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.NCJJKPFPBJD();
			}
		}
		if (BGLFLHDNOKJ.AFOACBIHNCL().canBeStacked)
		{
			itemInstance = BGLFLHDNOKJ.LHBPOPOIFLE().GBMLAEMOFJP(BGLFLHDNOKJ);
		}
		else
		{
			itemInstance = BGLFLHDNOKJ;
		}
		if (activateCallbacks)
		{
			ItemInstance obj3 = itemInstance;
			obj3.OnChanged = (Action)Delegate.Combine(obj3.OnChanged, new Action(LGABAHIKMGP));
			ItemInstance obj4 = itemInstance;
			obj4.OnReplaced = (Action<int, ItemInstance>)Delegate.Combine(obj4.OnReplaced, new Action<int, ItemInstance>(HJAJLIKNNHD));
		}
		if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance2)
		{
			phaseItemInstance2.BGJAPOEBGBL(JIIGOACEIKL);
		}
		stack = 1;
		itemInstance.currentSlot = this;
		OnItemAdded();
		OnItemAddedWithItem(itemInstance);
		OnItemInstanceChange();
		isDirty = false;
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.MEJEKJNLMKD(this);
		}
		return false;
	}

	private bool IOCCFBHHMJP(Type NCMDEGABGCH)
	{
		for (int i = 0; i < allowedItemsType.Length; i++)
		{
			if (allowedItemsType[i].IsAssignableFrom(NCMDEGABGCH))
			{
				return false;
			}
		}
		return true;
	}

	public static void GHCDPAJHKOI(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK)
	{
		if (!DPEOLFMDLAK.MEONGIBAALL(JIIGOACEIKL, ODNGJHPOMMK.itemInstance) || !ODNGJHPOMMK.MEONGIBAALL(JIIGOACEIKL, DPEOLFMDLAK.itemInstance))
		{
			return;
		}
		if (ODNGJHPOMMK.singleItem)
		{
			if (ODNGJHPOMMK.KPINNBKMOMO() && !DPEOLFMDLAK.KPINNBKMOMO())
			{
				ODNGJHPOMMK.FEEOFAGCONJ(JIIGOACEIKL, DPEOLFMDLAK.itemInstance);
				DPEOLFMDLAK.Stack--;
			}
			return;
		}
		Slot slot = new Slot();
		PDCAINBFENH(JIIGOACEIKL, DPEOLFMDLAK, slot);
		DPEOLFMDLAK.Stack = 0;
		NFBAGDKBOAD(JIIGOACEIKL, ODNGJHPOMMK, DPEOLFMDLAK);
		ODNGJHPOMMK.Stack = 0;
		NFBAGDKBOAD(JIIGOACEIKL, slot, ODNGJHPOMMK);
		if (!slot.KPINNBKMOMO() && DPEOLFMDLAK.KPINNBKMOMO())
		{
			NFBAGDKBOAD(JIIGOACEIKL, slot, DPEOLFMDLAK);
		}
	}

	public void BGJPNGLONLP(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		int num = Math.Max(0, AODONKKHPBP);
		if (singleItem && num > 1)
		{
			return;
		}
		if (num != stack)
		{
			bool num2 = num > stack;
			bool flag = num < stack;
			stack = num;
			if (stack == 0)
			{
				if (flag)
				{
					OnItemRemovedWithItem(itemInstance);
					if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
					{
						phaseItemInstance.NCBMBAIKEPA();
					}
				}
				if (itemInstance != null)
				{
					ItemInstance obj = itemInstance;
					obj.OnChanged = (Action)Delegate.Remove(obj.OnChanged, new Action(LGABAHIKMGP));
					ItemInstance obj2 = itemInstance;
					obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Remove(obj2.OnReplaced, new Action<int, ItemInstance>(HHOFKFHHGBC));
				}
				if (GCCLBKEJGFP)
				{
					itemInstance = null;
				}
			}
			isDirty = true;
			if (num2)
			{
				OnItemAdded();
				OnItemAddedWithItem(itemInstance);
			}
			else if (flag)
			{
				OnItemRemoved();
				if (stack == 0)
				{
					OnItemInstanceChange();
				}
			}
		}
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlot(this);
		}
	}

	[SpecialName]
	public void FKCFFOHOMOB(bool AODONKKHPBP)
	{
		m_isDirty = AODONKKHPBP;
	}

	public void EKDPBPHFFGJ(int JIIGOACEIKL)
	{
		if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.DAOFEOFLDIG(JIIGOACEIKL);
		}
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot = this;
		focused = true;
		if (GameInventoryUI.IEKODILKIHJ(JIIGOACEIKL).HDEPMJIDJEM())
		{
			GameInventoryUI.DEBKDBICLIC(JIIGOACEIKL).NIDOJLOEEHE(JIIGOACEIKL, LJGFNOIELFD: false);
		}
		if (MainInventoryUI.Get(JIIGOACEIKL).HDEPMJIDJEM())
		{
			MainInventoryUI.NDJAMDLOIJL(JIIGOACEIKL).MJEKKDHFKNJ(JIIGOACEIKL, LJGFNOIELFD: true);
		}
	}

	private bool LPFEBMGKANF(ItemInstance BGLFLHDNOKJ)
	{
		if (!notAgedFood)
		{
			return true;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance)
		{
			return foodInstance.GBCJNGADANM == 0;
		}
		return false;
	}

	public void KJBMKDJNOIP(int JIIGOACEIKL)
	{
		AMKHPHBJACO(AODONKKHPBP: false);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot = null;
		if (GameInventoryUI.MENNLOGFNOK(JIIGOACEIKL).BGLJFMHCFJF())
		{
			GameInventoryUI.JELOGNCPDAB(JIIGOACEIKL).NIDOJLOEEHE(JIIGOACEIKL, LJGFNOIELFD: true);
		}
		if (MainInventoryUI.NDJAMDLOIJL(JIIGOACEIKL).HDEPMJIDJEM())
		{
			MainInventoryUI.NIGDBMAOAEN(JIIGOACEIKL).MJEKKDHFKNJ(JIIGOACEIKL, LJGFNOIELFD: false);
		}
	}

	private bool DELGBPBPKNC(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeAgedFood)
		{
			return true;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance)
		{
			return foodInstance.LHBPOPOIFLE().canBeAged;
		}
		return false;
	}

	public static bool KAHHHGOHGKE(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK, int FGFCNKFEIGF)
	{
		DPEOLFMDLAK.Stack -= FGFCNKFEIGF - ODNGJHPOMMK.BEEDBHJANGN(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, FGFCNKFEIGF, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
		if (DPEOLFMDLAK.Stack == 0)
		{
			ODNGJHPOMMK.OnChangedSlot(DPEOLFMDLAK, ODNGJHPOMMK);
		}
		return DPEOLFMDLAK.Stack == 0;
	}

	public bool ONIFGHNHCPP(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, bool CDPAMNIPPEC = false)
	{
		if (!GPLKPEPAFOM(JIIGOACEIKL, BGLFLHDNOKJ))
		{
			return false;
		}
		if (itemInstance != null)
		{
			ItemInstance obj = itemInstance;
			obj.OnChanged = (Action)Delegate.Remove(obj.OnChanged, new Action(LGABAHIKMGP));
			ItemInstance obj2 = itemInstance;
			obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Remove(obj2.OnReplaced, new Action<int, ItemInstance>(HHOFKFHHGBC));
			if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.NCBMBAIKEPA();
			}
		}
		if (BGLFLHDNOKJ.LHBPOPOIFLE().canBeStacked)
		{
			itemInstance = BGLFLHDNOKJ.LHBPOPOIFLE().KDNBBPJCNDJ(BGLFLHDNOKJ);
		}
		else
		{
			itemInstance = BGLFLHDNOKJ;
		}
		if (activateCallbacks)
		{
			ItemInstance obj3 = itemInstance;
			obj3.OnChanged = (Action)Delegate.Combine(obj3.OnChanged, new Action(LGABAHIKMGP));
			ItemInstance obj4 = itemInstance;
			obj4.OnReplaced = (Action<int, ItemInstance>)Delegate.Combine(obj4.OnReplaced, new Action<int, ItemInstance>(HHOFKFHHGBC));
		}
		if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance2)
		{
			phaseItemInstance2.KCBNLEFGDPP(JIIGOACEIKL);
		}
		stack = 1;
		itemInstance.currentSlot = this;
		OnItemAdded();
		OnItemAddedWithItem(itemInstance);
		OnItemInstanceChange();
		isDirty = true;
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlot(this);
		}
		return true;
	}

	public static bool PDKCLKKHNOH(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK)
	{
		DPEOLFMDLAK.KMKAIPMHANN(ODNGJHPOMMK.MIECGDALIJP(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, DPEOLFMDLAK.Stack));
		if (DPEOLFMDLAK.Stack == 0)
		{
			ODNGJHPOMMK.OnChangedSlot(DPEOLFMDLAK, ODNGJHPOMMK);
		}
		return DPEOLFMDLAK.Stack == 1;
	}

	private bool LGLBJHNKMJE(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null) || bannedItems == null)
		{
			return true;
		}
		return bannedItems.Contains(MEMGMDOCBOJ);
	}

	private void MNFMKFGOLPF()
	{
		AJOGNKDJNAD(AODONKKHPBP: false);
	}

	public bool JHBNILHHEKK(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ)
	{
		if (BGLFLHDNOKJ != null && Item.FKLOBGBIHLB(BGLFLHDNOKJ.LHBPOPOIFLE(), null) && BGLFLHDNOKJ.KNFNJFFCFNO().canPickUp)
		{
			return EBFGABELEHJ(JIIGOACEIKL, BGLFLHDNOKJ);
		}
		return false;
	}

	public static bool BCEMMDNJAIF(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK, int FGFCNKFEIGF)
	{
		DPEOLFMDLAK.OBBKDJNLCIO(DPEOLFMDLAK.Stack - (FGFCNKFEIGF - ODNGJHPOMMK.BEEDBHJANGN(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, FGFCNKFEIGF, HAGPBCJEGKM: true)));
		if (DPEOLFMDLAK.Stack == 0)
		{
			ODNGJHPOMMK.OnChangedSlot(DPEOLFMDLAK, ODNGJHPOMMK);
		}
		return DPEOLFMDLAK.Stack == 0;
	}

	private bool LKIPHOBGOAO(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedFoodType == FoodType.None)
		{
			return true;
		}
		if (allowedFoodType == FoodType.Drink && BGLFLHDNOKJ.JEPBBEBJEFI())
		{
			return true;
		}
		if (allowedFoodType == FoodType.Food && !BGLFLHDNOKJ.JEPBBEBJEFI())
		{
			return true;
		}
		OnInvalidItem();
		return false;
	}

	public void DAOFEOFLDIG(int JIIGOACEIKL)
	{
		JCGCCKNBKLJ(AODONKKHPBP: false);
		SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot = null;
		if (GameInventoryUI.NALKHGMLALJ(JIIGOACEIKL).HDEPMJIDJEM())
		{
			GameInventoryUI.HKCAIFFKBMH(JIIGOACEIKL).MJEKKDHFKNJ(JIIGOACEIKL, LJGFNOIELFD: false);
		}
		if (MainInventoryUI.IMLMJAPMBJA(JIIGOACEIKL).BGLJFMHCFJF())
		{
			MainInventoryUI.AIMEAJAHLAA(JIIGOACEIKL).IGCGBDCEKMK(JIIGOACEIKL, LJGFNOIELFD: false);
		}
	}

	private static void FMKHCCMLGDD(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK)
	{
		ODNGJHPOMMK.CMLMNCAGKCK(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, DPEOLFMDLAK.Stack);
	}

	private bool CFFPMDJBJIM(int JIIGOACEIKL, Tag[] FDAGJPHBDOG)
	{
		if (FDAGJPHBDOG == null || bannedTags == null)
		{
			return true;
		}
		for (int i = 0; i < FDAGJPHBDOG.Length; i++)
		{
			if (bannedTags.Contains(FDAGJPHBDOG[i]))
			{
				if (FDAGJPHBDOG[i] == (Tag)(-42))
				{
					MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("talent_name_117"), 1646f);
				}
				return false;
			}
		}
		return false;
	}

	public bool MEODNPFJDMH(bool CDPAMNIPPEC = true)
	{
		JIGFFJNMKFG(1, GCCLBKEJGFP: true, CDPAMNIPPEC);
		return true;
	}

	public static bool IJDEHCDAAHF(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK, int FGFCNKFEIGF)
	{
		DPEOLFMDLAK.Stack -= FGFCNKFEIGF - ODNGJHPOMMK.BEEDBHJANGN(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, FGFCNKFEIGF);
		if (DPEOLFMDLAK.Stack == 0)
		{
			ODNGJHPOMMK.OnChangedSlot(DPEOLFMDLAK, ODNGJHPOMMK);
		}
		return DPEOLFMDLAK.Stack == 0;
	}

	private bool NKHIJJBOLKL(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeSoldFood)
		{
			return true;
		}
		if (BGLFLHDNOKJ is FoodInstance { GBCJNGADANM: >0 } foodInstance && foodInstance.IJLGJNLFNDB() && BGLFLHDNOKJ.LHBPOPOIFLE() is Food food)
		{
			return food.canBeSold;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance2 && foodInstance2.LHBPOPOIFLE().hasToBeAgedMeal && foodInstance2.GBCJNGADANM == 0)
		{
			return false;
		}
		if (BGLFLHDNOKJ.AFOACBIHNCL() is Food food2)
		{
			return food2.canBeSold;
		}
		return false;
	}

	[SpecialName]
	public void KMKAIPMHANN(int AODONKKHPBP)
	{
		LOEBDJDLEEE(AODONKKHPBP, GCCLBKEJGFP: false, CDPAMNIPPEC: false);
	}

	private bool OHDFCLEFNBB(Tag[] FNEIJIEAGDN)
	{
		if (allowedTags == null || allowedTags.Count == 0)
		{
			return true;
		}
		for (int i = 0; i < FNEIJIEAGDN.Length; i++)
		{
			if (allowedTags.Contains(FNEIJIEAGDN[i]))
			{
				return true;
			}
		}
		return false;
	}

	public bool JPACDDCJGPD(int FGFCNKFEIGF, bool CDPAMNIPPEC = false, int CMLIHBFCJHG = 0)
	{
		KMKAIPMHANN(Stack - FGFCNKFEIGF);
		if (CDPAMNIPPEC && sendSlotOnline && FGFCNKFEIGF > 0 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlot(this, CMLIHBFCJHG);
		}
		return false;
	}

	private void LGABAHIKMGP()
	{
		isDirty = true;
	}

	public int MHIIKMOOMFH(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool HAGPBCJEGKM = false, bool BDGJBPCEFPN = false, bool CDPAMNIPPEC = false)
	{
		if (singleItem && Stack >= 1)
		{
			return MGNOBNCMDJG;
		}
		if (!JHBNILHHEKK(JIIGOACEIKL, BGLFLHDNOKJ))
		{
			return MGNOBNCMDJG;
		}
		if (maxStack != 0 && stack >= maxStack)
		{
			return MGNOBNCMDJG;
		}
		int num = MGNOBNCMDJG;
		int amountStack = maxStack;
		if (!BDGJBPCEFPN)
		{
			if (BGLFLHDNOKJ.KNFNJFFCFNO().amountStack < maxStack)
			{
				amountStack = BGLFLHDNOKJ.KNFNJFFCFNO().amountStack;
			}
			else if (maxStack == 0)
			{
				amountStack = BGLFLHDNOKJ.LHBPOPOIFLE().amountStack;
			}
		}
		if (amountStack != 0 && Stack + MGNOBNCMDJG >= amountStack)
		{
			num = amountStack - Stack;
		}
		if (BGLFLHDNOKJ.AFOACBIHNCL().JGHNDJBCFAJ() == 3)
		{
			(BGLFLHDNOKJ as FoodInstance).JBIMNJGMFOC(0);
		}
		if (KPINNBKMOMO())
		{
			if (BGLFLHDNOKJ.LHBPOPOIFLE().canBeStacked)
			{
				itemInstance = BGLFLHDNOKJ.AFOACBIHNCL().GBMLAEMOFJP(BGLFLHDNOKJ);
			}
			else
			{
				itemInstance = BGLFLHDNOKJ;
			}
			if (activateCallbacks)
			{
				ItemInstance obj = itemInstance;
				obj.OnChanged = (Action)Delegate.Combine(obj.OnChanged, new Action(LGABAHIKMGP));
				ItemInstance obj2 = itemInstance;
				obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Combine(obj2.OnReplaced, new Action<int, ItemInstance>(HEDKFBDJDHA));
			}
			if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.HOBNJDEMNPM(JIIGOACEIKL);
			}
			stack = num;
			itemInstance.currentSlot = this;
			OnItemAdded();
			OnItemInstanceChange();
			OnItemAddedWithItem(itemInstance);
			isDirty = true;
			if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.DPKMOHOPJFD(this);
			}
		}
		else
		{
			if (itemInstance is IngredientGroupInstance ingredientGroupInstance)
			{
				if (ingredientGroupInstance.chosenItemInstance != null && ModifierUI.MIAOGLENOHL(JIIGOACEIKL).NFCHJIDFMFP())
				{
					ModifierUI.MIAOGLENOHL(JIIGOACEIKL).LLPKJIMIMBM(this, id, stack);
				}
				ingredientGroupInstance.chosenItemInstance = BGLFLHDNOKJ;
				BGLFLHDNOKJ.currentSlot = this;
				OnItemAdded();
				OnItemAddedWithItem(BGLFLHDNOKJ);
				AJOGNKDJNAD(AODONKKHPBP: true);
				return 1;
			}
			if (itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().JGJLNHAKJIJ() && ingredientsCanBeChanged)
			{
				if (foodInstance.Equals(BGLFLHDNOKJ))
				{
					return MGNOBNCMDJG;
				}
				int aODONKKHPBP = stack;
				if (foodInstance.JDMCPHPNOHK() && ModifierUI.MBGFHNEBOJM(JIIGOACEIKL).FNNNKDENHDG())
				{
					ModifierUI.NIGDBMAOAEN(JIIGOACEIKL).OBEAJANAIFE(this, id, stack, KDCAODJIEMD: true);
				}
				ONIFGHNHCPP(JIIGOACEIKL, BGLFLHDNOKJ);
				LOEBDJDLEEE(aODONKKHPBP, GCCLBKEJGFP: false, CDPAMNIPPEC);
				return 0;
			}
			if ((!HAGPBCJEGKM || !Item.GBMFCPGEJDK(itemInstance.PHGLMBIEOMK(), BGLFLHDNOKJ.KNFNJFFCFNO())) && !EDGCGEMMEKP(BGLFLHDNOKJ))
			{
				return MGNOBNCMDJG;
			}
			if (!BDGJBPCEFPN && stack >= BGLFLHDNOKJ.PHGLMBIEOMK().amountStack)
			{
				return MGNOBNCMDJG;
			}
			if ((Object)(object)quest != (Object)null && stack >= quest.requiredAmount)
			{
				return MGNOBNCMDJG;
			}
			itemInstance.currentSlot = this;
			BGJPNGLONLP(stack + num, GCCLBKEJGFP: false, CDPAMNIPPEC);
		}
		return MGNOBNCMDJG - num;
	}

	private bool NHPKOOIMDGH(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeAgedFood)
		{
			return false;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance)
		{
			return foodInstance.LHBPOPOIFLE().canBeAged;
		}
		return true;
	}

	private bool IEKMHELGJAG(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null || (Object)(object)quest == (Object)null)
		{
			return false;
		}
		return quest.MAHEIJJAHCD(DNLMCHDOMOK);
	}

	public void GNOBDKFFPOL()
	{
		if (itemInstance == null)
		{
			stack = 1;
		}
		else if (stack <= 0)
		{
			stack = 0;
		}
	}

	private bool BNCGEHPHPKI(Type NCMDEGABGCH)
	{
		for (int i = 1; i < allowedItemsType.Length; i++)
		{
			if (allowedItemsType[i].IsAssignableFrom(NCMDEGABGCH))
			{
				return false;
			}
		}
		return false;
	}

	private bool PPDFFPLDLKC(ItemInstance BGLFLHDNOKJ)
	{
		if (!hasToBeAgedFood)
		{
			return true;
		}
		return BGLFLHDNOKJ.PHGLMBIEOMK().hasToBeAgedMeal;
	}

	private void HHOFKFHHGBC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		ONIFGHNHCPP(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private bool NDOGAOIJACF(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null || (Object)(object)quest == (Object)null)
		{
			return true;
		}
		return quest.PCGAAKMLDAI(DNLMCHDOMOK);
	}

	private bool JEKLHGOJNJA(ItemInstance BGLFLHDNOKJ)
	{
		if (!notAgedFood)
		{
			return false;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance)
		{
			return foodInstance.GBCJNGADANM == 0;
		}
		return true;
	}

	[SpecialName]
	public bool FJDEJKNNFEP()
	{
		return _focused;
	}

	private bool APGBHBINPGF(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeSoldFood)
		{
			return true;
		}
		if (BGLFLHDNOKJ is FoodInstance { GBCJNGADANM: >1 } foodInstance && foodInstance.JLCBECDECBP() && BGLFLHDNOKJ.KNFNJFFCFNO() is Food food)
		{
			return food.canBeSold;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance2 && foodInstance2.LHBPOPOIFLE().hasToBeAgedMeal && foodInstance2.GBCJNGADANM == 0)
		{
			return false;
		}
		if (BGLFLHDNOKJ.KNFNJFFCFNO() is Food food2)
		{
			return food2.canBeSold;
		}
		return false;
	}

	private bool LOLOLHDKEJJ(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeAgedFood)
		{
			return false;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance)
		{
			return foodInstance.LHBPOPOIFLE().canBeAged;
		}
		return true;
	}

	public bool BLDMJOIEMNP(Item MEMGMDOCBOJ, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		if (MEMGMDOCBOJ is Food food && food.NBNNBMKANOF() && itemInstance is FoodInstance foodInstance)
		{
			if (DBMFHFNKMOM > -1 && foodInstance.GBCJNGADANM != DBMFHFNKMOM)
			{
				return true;
			}
			if (DDAPJEAJGGA && foodInstance.GBCJNGADANM == 0)
			{
				return true;
			}
		}
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null) && itemInstance != null && Item.FKLOBGBIHLB(itemInstance.AFOACBIHNCL(), null))
		{
			return itemInstance.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false) == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false);
		}
		return false;
	}

	private bool OIBAFGIEMIB(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeSoldFood)
		{
			return true;
		}
		if (BGLFLHDNOKJ is FoodInstance { GBCJNGADANM: >0 } foodInstance && foodInstance.JEPBBEBJEFI() && BGLFLHDNOKJ.LHBPOPOIFLE() is Food food)
		{
			return food.canBeSold;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance2 && foodInstance2.LHBPOPOIFLE().hasToBeAgedMeal && foodInstance2.GBCJNGADANM == 0)
		{
			return false;
		}
		if (BGLFLHDNOKJ.LHBPOPOIFLE() is Food food2)
		{
			return food2.canBeSold;
		}
		return false;
	}

	public void EHGKPGCNENF(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		DOBKBEPKPGH(stack - AODONKKHPBP, GCCLBKEJGFP);
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.COIPPNBFLPO(this, 1);
		}
	}

	[SpecialName]
	public int BAGBNNGFHKF()
	{
		if (!((Object)(object)onlineObject != (Object)null))
		{
			return 0;
		}
		return onlineObject.uniqueId;
	}

	public static bool NFBAGDKBOAD(int JIIGOACEIKL, Slot DPEOLFMDLAK, Slot ODNGJHPOMMK)
	{
		DPEOLFMDLAK.Stack = ODNGJHPOMMK.BEEDBHJANGN(JIIGOACEIKL, DPEOLFMDLAK.itemInstance, DPEOLFMDLAK.Stack);
		if (DPEOLFMDLAK.Stack == 0)
		{
			ODNGJHPOMMK.OnChangedSlot(DPEOLFMDLAK, ODNGJHPOMMK);
		}
		return DPEOLFMDLAK.Stack == 0;
	}

	public bool FEEOFAGCONJ(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, bool HAGPBCJEGKM = false, bool BDGJBPCEFPN = false, bool CDPAMNIPPEC = false)
	{
		return BEEDBHJANGN(JIIGOACEIKL, BGLFLHDNOKJ, 1, HAGPBCJEGKM, BDGJBPCEFPN, CDPAMNIPPEC) == 0;
	}

	public bool FDOBDPPMMBH(int FGFCNKFEIGF, bool CDPAMNIPPEC = false, int CMLIHBFCJHG = 0)
	{
		Stack -= FGFCNKFEIGF;
		if (CDPAMNIPPEC && sendSlotOnline && FGFCNKFEIGF > 0 && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlot(this, CMLIHBFCJHG);
		}
		return true;
	}

	public void MBOGHMKLBBB()
	{
		if (allowedItems == null || allowedItems.Count <= 0)
		{
			return;
		}
		allowedItemsType = new Type[allowedItems.Count];
		for (int i = 0; i < allowedItems.Count; i++)
		{
			if (allowedItems[i].Equals("Ingredient"))
			{
				allowedItemsType[i] = typeof(Food);
			}
			else
			{
				allowedItemsType[i] = Type.GetType(allowedItems[i]);
			}
		}
	}

	public bool OFJDJIBMIGE(int JIIGOACEIKL, Item BGLFLHDNOKJ)
	{
		if (Item.NGIIPJDAMGP(BGLFLHDNOKJ, null))
		{
			return false;
		}
		if (itemInstance != null)
		{
			ItemInstance obj = itemInstance;
			obj.OnChanged = (Action)Delegate.Remove(obj.OnChanged, new Action(LGABAHIKMGP));
			ItemInstance obj2 = itemInstance;
			obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Remove(obj2.OnReplaced, new Action<int, ItemInstance>(HHOFKFHHGBC));
			if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.NCBMBAIKEPA();
			}
		}
		itemInstance = BGLFLHDNOKJ.JMDALJBNFML();
		if (activateCallbacks)
		{
			ItemInstance obj3 = itemInstance;
			obj3.OnChanged = (Action)Delegate.Combine(obj3.OnChanged, new Action(LGABAHIKMGP));
			ItemInstance obj4 = itemInstance;
			obj4.OnReplaced = (Action<int, ItemInstance>)Delegate.Combine(obj4.OnReplaced, new Action<int, ItemInstance>(HHOFKFHHGBC));
		}
		if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance2)
		{
			phaseItemInstance2.KCBNLEFGDPP(JIIGOACEIKL);
		}
		stack = 1;
		itemInstance.currentSlot = this;
		OnItemAdded();
		OnItemInstanceChange();
		OnItemAddedWithItem(itemInstance);
		isDirty = true;
		return true;
	}

	private void HLHOPOMMELO()
	{
		FBAFIONMKBG(AODONKKHPBP: true);
	}

	public bool KPINNBKMOMO()
	{
		if (itemInstance != null)
		{
			return Item.NGIIPJDAMGP(itemInstance.LHBPOPOIFLE(), null);
		}
		return true;
	}

	public bool DOOMMIJPGOO(int JIIGOACEIKL, Item BGLFLHDNOKJ)
	{
		if (Item.EKMFELLJHFG(BGLFLHDNOKJ, null))
		{
			return true;
		}
		if (itemInstance != null)
		{
			ItemInstance obj = itemInstance;
			obj.OnChanged = (Action)Delegate.Remove(obj.OnChanged, new Action(CNFMJOGCLHN));
			ItemInstance obj2 = itemInstance;
			obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Remove(obj2.OnReplaced, new Action<int, ItemInstance>(HEDKFBDJDHA));
			if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.NCJJKPFPBJD();
			}
		}
		itemInstance = BGLFLHDNOKJ.JMDALJBNFML();
		if (activateCallbacks)
		{
			ItemInstance obj3 = itemInstance;
			obj3.OnChanged = (Action)Delegate.Combine(obj3.OnChanged, new Action(CNFMJOGCLHN));
			ItemInstance obj4 = itemInstance;
			obj4.OnReplaced = (Action<int, ItemInstance>)Delegate.Combine(obj4.OnReplaced, new Action<int, ItemInstance>(HJAJLIKNNHD));
		}
		if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance2)
		{
			phaseItemInstance2.KCBNLEFGDPP(JIIGOACEIKL);
		}
		stack = 1;
		itemInstance.currentSlot = this;
		OnItemAdded();
		OnItemInstanceChange();
		OnItemAddedWithItem(itemInstance);
		FBAFIONMKBG(AODONKKHPBP: false);
		return true;
	}

	private bool MGFBKIPPFNG(ItemInstance BGLFLHDNOKJ)
	{
		if (allowedFoodType == FoodType.None)
		{
			return false;
		}
		if (allowedFoodType == (FoodType)4 && BGLFLHDNOKJ.JLCBECDECBP())
		{
			return true;
		}
		if (allowedFoodType == FoodType.Food && !BGLFLHDNOKJ.BIIJEMDLBDP())
		{
			return false;
		}
		OnInvalidItem();
		return false;
	}

	public Slot(ItemInstance DNLMCHDOMOK, int FGFCNKFEIGF, int BCGMJPMMGFD)
	{
		maxStack = BCGMJPMMGFD;
		ONIFGHNHCPP(1, DNLMCHDOMOK);
		BGJPNGLONLP(FGFCNKFEIGF, GCCLBKEJGFP: true, CDPAMNIPPEC: false);
	}

	public int BEEDBHJANGN(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool HAGPBCJEGKM = false, bool BDGJBPCEFPN = false, bool CDPAMNIPPEC = false)
	{
		if (singleItem && Stack >= 1)
		{
			return MGNOBNCMDJG;
		}
		if (!GPLKPEPAFOM(JIIGOACEIKL, BGLFLHDNOKJ))
		{
			return MGNOBNCMDJG;
		}
		if (maxStack != 0 && stack >= maxStack)
		{
			return MGNOBNCMDJG;
		}
		int num = MGNOBNCMDJG;
		int amountStack = maxStack;
		if (!BDGJBPCEFPN)
		{
			if (BGLFLHDNOKJ.LHBPOPOIFLE().amountStack < maxStack)
			{
				amountStack = BGLFLHDNOKJ.LHBPOPOIFLE().amountStack;
			}
			else if (maxStack == 0)
			{
				amountStack = BGLFLHDNOKJ.LHBPOPOIFLE().amountStack;
			}
		}
		if (amountStack != 0 && Stack + MGNOBNCMDJG >= amountStack)
		{
			num = amountStack - Stack;
		}
		if (BGLFLHDNOKJ.LHBPOPOIFLE().JDJGFAACPFC() == 1318)
		{
			(BGLFLHDNOKJ as FoodInstance).GBCJNGADANM = 1;
		}
		if (KPINNBKMOMO())
		{
			if (BGLFLHDNOKJ.LHBPOPOIFLE().canBeStacked)
			{
				itemInstance = BGLFLHDNOKJ.LHBPOPOIFLE().KDNBBPJCNDJ(BGLFLHDNOKJ);
			}
			else
			{
				itemInstance = BGLFLHDNOKJ;
			}
			if (activateCallbacks)
			{
				ItemInstance obj = itemInstance;
				obj.OnChanged = (Action)Delegate.Combine(obj.OnChanged, new Action(LGABAHIKMGP));
				ItemInstance obj2 = itemInstance;
				obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Combine(obj2.OnReplaced, new Action<int, ItemInstance>(HHOFKFHHGBC));
			}
			if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.KCBNLEFGDPP(JIIGOACEIKL);
			}
			stack = num;
			itemInstance.currentSlot = this;
			OnItemAdded();
			OnItemInstanceChange();
			OnItemAddedWithItem(itemInstance);
			isDirty = true;
			if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.SendSlot(this);
			}
		}
		else
		{
			if (itemInstance is IngredientGroupInstance ingredientGroupInstance)
			{
				if (ingredientGroupInstance.chosenItemInstance != null && ModifierUI.Get(JIIGOACEIKL).IsOpened())
				{
					ModifierUI.Get(JIIGOACEIKL).TransferItemToCraftingInventory(this, id, stack);
				}
				ingredientGroupInstance.chosenItemInstance = BGLFLHDNOKJ;
				BGLFLHDNOKJ.currentSlot = this;
				OnItemAdded();
				OnItemAddedWithItem(BGLFLHDNOKJ);
				isDirty = true;
				return 0;
			}
			if (itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().NGDPNIFFHKL() && ingredientsCanBeChanged)
			{
				if (foodInstance.Equals(BGLFLHDNOKJ))
				{
					return MGNOBNCMDJG;
				}
				int aODONKKHPBP = stack;
				if (foodInstance.JDMCPHPNOHK() && ModifierUI.Get(JIIGOACEIKL).IsOpened())
				{
					ModifierUI.Get(JIIGOACEIKL).TransferItemToCraftingInventory(this, id, stack);
				}
				ONIFGHNHCPP(JIIGOACEIKL, BGLFLHDNOKJ);
				BGJPNGLONLP(aODONKKHPBP, GCCLBKEJGFP: true, CDPAMNIPPEC);
				return 0;
			}
			if ((!HAGPBCJEGKM || !Item.NGIIPJDAMGP(itemInstance.LHBPOPOIFLE(), BGLFLHDNOKJ.LHBPOPOIFLE())) && !BOMLNEOHFOK(BGLFLHDNOKJ))
			{
				return MGNOBNCMDJG;
			}
			if (!BDGJBPCEFPN && stack >= BGLFLHDNOKJ.LHBPOPOIFLE().amountStack)
			{
				return MGNOBNCMDJG;
			}
			if ((Object)(object)quest != (Object)null && stack >= quest.requiredAmount)
			{
				return MGNOBNCMDJG;
			}
			itemInstance.currentSlot = this;
			BGJPNGLONLP(stack + num, GCCLBKEJGFP: true, CDPAMNIPPEC);
		}
		return MGNOBNCMDJG - num;
	}

	public void LOEBDJDLEEE(int AODONKKHPBP, bool GCCLBKEJGFP = true, bool CDPAMNIPPEC = true)
	{
		int num = Math.Max(0, AODONKKHPBP);
		if (singleItem && num > 1)
		{
			return;
		}
		if (num != stack)
		{
			bool num2 = num > stack;
			bool flag = num < stack;
			stack = num;
			if (stack == 0)
			{
				if (flag)
				{
					OnItemRemovedWithItem(itemInstance);
					if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
					{
						phaseItemInstance.IPLGBPPJOCN();
					}
				}
				if (itemInstance != null)
				{
					ItemInstance obj = itemInstance;
					obj.OnChanged = (Action)Delegate.Remove(obj.OnChanged, new Action(MNFMKFGOLPF));
					ItemInstance obj2 = itemInstance;
					obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Remove(obj2.OnReplaced, new Action<int, ItemInstance>(KBEOJPKBDIJ));
				}
				if (GCCLBKEJGFP)
				{
					itemInstance = null;
				}
			}
			isDirty = true;
			if (num2)
			{
				OnItemAdded();
				OnItemAddedWithItem(itemInstance);
			}
			else if (flag)
			{
				OnItemRemoved();
				if (stack == 0)
				{
					OnItemInstanceChange();
				}
			}
		}
		if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlot(this);
		}
	}

	private bool POIDJIKPJNA(ItemInstance BGLFLHDNOKJ)
	{
		if (!hasToBeAgedFood)
		{
			return true;
		}
		return BGLFLHDNOKJ.LHBPOPOIFLE().hasToBeAgedMeal;
	}

	private bool GBJKDFDKKMI(ItemInstance BGLFLHDNOKJ)
	{
		if (!canBeSoldFood)
		{
			return false;
		}
		if (BGLFLHDNOKJ is FoodInstance { GBCJNGADANM: >0 } foodInstance && foodInstance.BIIJEMDLBDP() && BGLFLHDNOKJ.AFOACBIHNCL() is Food food)
		{
			return food.canBeSold;
		}
		if (BGLFLHDNOKJ is FoodInstance foodInstance2 && foodInstance2.LHBPOPOIFLE().hasToBeAgedMeal && foodInstance2.GBCJNGADANM == 0)
		{
			return false;
		}
		if (BGLFLHDNOKJ.LHBPOPOIFLE() is Food food2)
		{
			return food2.canBeSold;
		}
		return false;
	}

	public int CMLMNCAGKCK(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool HAGPBCJEGKM = false, bool BDGJBPCEFPN = false, bool CDPAMNIPPEC = false)
	{
		if (singleItem && Stack >= 1)
		{
			return MGNOBNCMDJG;
		}
		if (!GPLKPEPAFOM(JIIGOACEIKL, BGLFLHDNOKJ))
		{
			return MGNOBNCMDJG;
		}
		if (maxStack != 0 && stack >= maxStack)
		{
			return MGNOBNCMDJG;
		}
		int num = MGNOBNCMDJG;
		int amountStack = maxStack;
		if (!BDGJBPCEFPN)
		{
			if (BGLFLHDNOKJ.KNFNJFFCFNO().amountStack < maxStack)
			{
				amountStack = BGLFLHDNOKJ.AFOACBIHNCL().amountStack;
			}
			else if (maxStack == 0)
			{
				amountStack = BGLFLHDNOKJ.LHBPOPOIFLE().amountStack;
			}
		}
		if (amountStack != 0 && Stack + MGNOBNCMDJG >= amountStack)
		{
			num = amountStack - Stack;
		}
		if (BGLFLHDNOKJ.LHBPOPOIFLE().JDJGFAACPFC(DAINLFIMLIH: false) == -42)
		{
			(BGLFLHDNOKJ as FoodInstance).JBIMNJGMFOC(0);
		}
		if (AHHEMNHJPME())
		{
			if (BGLFLHDNOKJ.PHGLMBIEOMK().canBeStacked)
			{
				itemInstance = BGLFLHDNOKJ.LHBPOPOIFLE().JEDPCLGBLBA(BGLFLHDNOKJ);
			}
			else
			{
				itemInstance = BGLFLHDNOKJ;
			}
			if (activateCallbacks)
			{
				ItemInstance obj = itemInstance;
				obj.OnChanged = (Action)Delegate.Combine(obj.OnChanged, new Action(LGABAHIKMGP));
				ItemInstance obj2 = itemInstance;
				obj2.OnReplaced = (Action<int, ItemInstance>)Delegate.Combine(obj2.OnReplaced, new Action<int, ItemInstance>(HHOFKFHHGBC));
			}
			if (prepareNextPhase && itemInstance is PhaseItemInstance phaseItemInstance)
			{
				phaseItemInstance.BGJAPOEBGBL(JIIGOACEIKL);
			}
			stack = num;
			itemInstance.currentSlot = this;
			OnItemAdded();
			OnItemInstanceChange();
			OnItemAddedWithItem(itemInstance);
			FKCFFOHOMOB(AODONKKHPBP: false);
			if (CDPAMNIPPEC && sendSlotOnline && OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.FMAEFIBNHNI(this);
			}
		}
		else
		{
			if (itemInstance is IngredientGroupInstance ingredientGroupInstance)
			{
				if (ingredientGroupInstance.chosenItemInstance != null && ModifierUI.MBGFHNEBOJM(JIIGOACEIKL).NFCHJIDFMFP())
				{
					ModifierUI.Get(JIIGOACEIKL).TransferItemToCraftingInventory(this, id, stack);
				}
				ingredientGroupInstance.chosenItemInstance = BGLFLHDNOKJ;
				BGLFLHDNOKJ.currentSlot = this;
				OnItemAdded();
				OnItemAddedWithItem(BGLFLHDNOKJ);
				isDirty = true;
				return 0;
			}
			if (itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().JGJLNHAKJIJ() && ingredientsCanBeChanged)
			{
				if (foodInstance.Equals(BGLFLHDNOKJ))
				{
					return MGNOBNCMDJG;
				}
				int aODONKKHPBP = stack;
				if (foodInstance.JDMCPHPNOHK() && ModifierUI.Get(JIIGOACEIKL).IsOpened())
				{
					ModifierUI.MBGFHNEBOJM(JIIGOACEIKL).OBEAJANAIFE(this, id, stack);
				}
				OLHGPMJPJFF(JIIGOACEIKL, BGLFLHDNOKJ);
				DOBKBEPKPGH(aODONKKHPBP, GCCLBKEJGFP: false, CDPAMNIPPEC);
				return 1;
			}
			if ((!HAGPBCJEGKM || !Item.EKGNIODFJCO(itemInstance.LHBPOPOIFLE(), BGLFLHDNOKJ.PHGLMBIEOMK())) && !BOMLNEOHFOK(BGLFLHDNOKJ))
			{
				return MGNOBNCMDJG;
			}
			if (!BDGJBPCEFPN && stack >= BGLFLHDNOKJ.AFOACBIHNCL().amountStack)
			{
				return MGNOBNCMDJG;
			}
			if ((Object)(object)quest != (Object)null && stack >= quest.requiredAmount)
			{
				return MGNOBNCMDJG;
			}
			itemInstance.currentSlot = this;
			LOEBDJDLEEE(stack + num, GCCLBKEJGFP: true, CDPAMNIPPEC);
		}
		return MGNOBNCMDJG - num;
	}

	public void ICOCPFOBBJE(int JIIGOACEIKL)
	{
		JCGCCKNBKLJ(AODONKKHPBP: true);
		SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot = null;
		if (GameInventoryUI.DEBKDBICLIC(JIIGOACEIKL).BGLJFMHCFJF())
		{
			GameInventoryUI.BDJFHFHLJGN(JIIGOACEIKL).IGCGBDCEKMK(JIIGOACEIKL, LJGFNOIELFD: false);
		}
		if (MainInventoryUI.NIGDBMAOAEN(JIIGOACEIKL).IsOpen())
		{
			MainInventoryUI.NIGDBMAOAEN(JIIGOACEIKL).NIDOJLOEEHE(JIIGOACEIKL, LJGFNOIELFD: true);
		}
	}

	[SpecialName]
	public void AJOGNKDJNAD(bool AODONKKHPBP)
	{
		m_isDirty = AODONKKHPBP;
	}
}
