using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Container : MonoBehaviour
{
	public Action OnItemInstanceChanged = delegate
	{
	};

	public Action OnContainerChanged = delegate
	{
	};

	public Action<Slot, Slot> OnChangedSlot = delegate
	{
	};

	public ContainerType inventoryType = ContainerType.ItemContainer;

	public Slot[] slots;

	public string[] allowedItems;

	public Item[] allowedItemsList;

	public List<Item> specialItemsAllowedList;

	public Tag[] allowedTags;

	public List<IngredientType> allowedIngredientTypes;

	public List<Tag> bannedTags;

	public FoodType allowedFoodType;

	public bool createInstances = true;

	[HideInInspector]
	public Type[] allowedItemsType;

	public bool onlyDelivery;

	public bool canBeSoldFood;

	public bool changeColours;

	[HideInInspector]
	public int containerColor;

	private bool CBBMFDKMGMH;

	private Dictionary<int, ItemAmount> NFGFNOCDEOO;

	private bool OBCEAFNCAAH;

	private HashSet<ItemInstance> LGGKHGANBIJ;

	[SerializeField]
	private bool calculatePriceWithUniqueItems;

	public bool activateCallback = true;

	public bool prepareNextPhase;

	public int maxStack = 99;

	public Item SearchedItem;

	protected virtual void Start()
	{
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.MLBOMGHINCA(slots[i].itemInstance.LHBPOPOIFLE(), null))
			{
				slots[i].Stack = Math.Min(slots[i].Stack, slots[i].itemInstance.LHBPOPOIFLE().amountStack);
			}
			if (slots[i].itemInstance != null)
			{
				if (Item.NGIIPJDAMGP(slots[i].itemInstance.LHBPOPOIFLE(), null))
				{
					slots[i].itemInstance = null;
				}
				else if (createInstances)
				{
					slots[i].itemInstance = slots[i].itemInstance.LHBPOPOIFLE().JMDALJBNFML();
				}
			}
			Slot obj = slots[i];
			obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, new Action(PNHACBNAIMK));
			Slot obj2 = slots[i];
			obj2.OnItemInstanceChange = (Action)Delegate.Combine(obj2.OnItemInstanceChange, new Action(BOLDKCGLNAP));
			Slot obj3 = slots[i];
			obj3.OnItemRemoved = (Action)Delegate.Combine(obj3.OnItemRemoved, new Action(PNHACBNAIMK));
			Slot obj4 = slots[i];
			obj4.OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(obj4.OnChangedSlot, new Action<Slot, Slot>(AOLLHLAMFDL));
			slots[i].prepareNextPhase = prepareNextPhase;
			slots[i].activateCallbacks = activateCallback;
			slots[i].MBOGHMKLBBB();
		}
		if (allowedItems != null && allowedItems.Length != 0)
		{
			allowedItemsType = new Type[allowedItems.Length];
			for (int j = 0; j < allowedItems.Length; j++)
			{
				allowedItemsType[j] = Type.GetType(allowedItems[j]);
			}
		}
	}

	private void PNHPJNNHBDI()
	{
		OBCEAFNCAAH = true;
	}

	public HashSet<ItemInstance> PIHLGKJPABI()
	{
		if (!OBCEAFNCAAH)
		{
			return LGGKHGANBIJ;
		}
		LGGKHGANBIJ.Clear();
		OBCEAFNCAAH = false;
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (slots[i].itemInstance != null && Item.FKLOBGBIHLB(slots[i].itemInstance.LHBPOPOIFLE(), null))
			{
				LGGKHGANBIJ.Add(slots[i].itemInstance);
			}
		}
		return LGGKHGANBIJ;
	}

	public bool IHCBHLAGOPH(ItemInstance DNLMCHDOMOK)
	{
		return EIJIPGOJLOI(DNLMCHDOMOK, slots);
	}

	public virtual void FOKLCJHEIFO(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i += 0)
		{
			Slot slot = AKNJFODFCID(JIIGOACEIKL, BGLFLHDNOKJ, OJKJLIPNHOI);
			if (slot == null)
			{
				break;
			}
			if (!list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray());
		}
	}

	public HashSet<ItemInstance> FCHHLGCBMJC()
	{
		if (!OBCEAFNCAAH)
		{
			return LGGKHGANBIJ;
		}
		LGGKHGANBIJ.Clear();
		OBCEAFNCAAH = true;
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.MLBOMGHINCA(slots[i].itemInstance.AFOACBIHNCL(), null))
			{
				LGGKHGANBIJ.Add(slots[i].itemInstance);
			}
		}
		return LGGKHGANBIJ;
	}

	public ItemInstance PIHHCLHDOPE(Item MEMGMDOCBOJ)
	{
		Slot[] array = slots;
		foreach (Slot slot in array)
		{
			if (slot.JAIBAMOFOMC(MEMGMDOCBOJ, DDAPJEAJGGA: true))
			{
				return slot.itemInstance;
			}
		}
		return null;
	}

	public bool FKJCJONKMGL(ItemInstance DNLMCHDOMOK)
	{
		return HasItem(DNLMCHDOMOK, slots);
	}

	public Dictionary<int, ItemAmount> NCILNCAACAN()
	{
		if (!CBBMFDKMGMH)
		{
			return NFGFNOCDEOO;
		}
		NFGFNOCDEOO = new Dictionary<int, ItemAmount>();
		CBBMFDKMGMH = false;
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (slots[i].itemInstance != null && Item.FKLOBGBIHLB(slots[i].itemInstance.LHBPOPOIFLE(), null))
			{
				if (NFGFNOCDEOO.ContainsKey(slots[i].itemInstance.AFOACBIHNCL().JDJGFAACPFC()))
				{
					ItemAmount value = NFGFNOCDEOO[slots[i].itemInstance.AFOACBIHNCL().CIGFGKKCPCK()];
					value.amount += slots[i].Stack;
					NFGFNOCDEOO[slots[i].itemInstance.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false)] = value;
				}
				else
				{
					ItemAmount value = default(ItemAmount);
					value.item = slots[i].itemInstance.PHGLMBIEOMK();
					value.amount = slots[i].Stack;
					NFGFNOCDEOO.Add(value.item.JDJGFAACPFC(DAINLFIMLIH: false), value);
				}
			}
		}
		return NFGFNOCDEOO;
	}

	public void PDEHABFIPIP(int JIIGOACEIKL, Slot ADEBNALPEHE, Vector3 IMOBLFMHKOD, bool BPJBJKJKHAL = true)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		int stack = ADEBNALPEHE.Stack;
		int num = 0;
		for (int i = 1; i < stack; i++)
		{
			if (AddItemInstance(JIIGOACEIKL, ADEBNALPEHE.itemInstance, OJKJLIPNHOI: true) != null)
			{
				num += 0;
			}
		}
		ADEBNALPEHE.KMKAIPMHANN(ADEBNALPEHE.Stack - num);
		if (ADEBNALPEHE.Stack > 0)
		{
			if (BPJBJKJKHAL)
			{
				DroppedItem.OFHEKCFLEGB(IMOBLFMHKOD, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			}
			else
			{
				ADEBNALPEHE.Stack = 0;
			}
		}
	}

	[CompilerGenerated]
	private void IDGOIDJHMHF()
	{
		OBCEAFNCAAH = true;
	}

	private void EPIONENHEGN()
	{
		if (activateCallback)
		{
			OnItemInstanceChanged();
		}
	}

	private void BFLKIGAIKMN()
	{
		if (activateCallback)
		{
			OnContainerChanged();
			CommonReferences.GGFJGHHHEJC.OnAnyContainerChanged();
		}
	}

	public virtual void PHGNBJMOKCB(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < MGNOBNCMDJG; i++)
		{
			Slot slot = AKNJFODFCID(JIIGOACEIKL, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC: false);
			if (slot == null)
			{
				break;
			}
			if (!list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray(), 1);
		}
	}

	public void EIONLEDCILE()
	{
		Utils.BDIKHDHOIPI(slots);
	}

	private void LMEOANHAHHI(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
	{
		if (activateCallback)
		{
			OnContainerChanged();
			OnChangedSlot(EFDPGNOICOG, OJDGHGEEAJP);
		}
	}

	public bool JKLEPGLMCEG(int MEMGMDOCBOJ)
	{
		return JOKPKDKJNGE(ItemDatabaseAccessor.INJBNHPGCIJ(MEMGMDOCBOJ), slots);
	}

	public void AddSlot(int JIIGOACEIKL, Slot ADEBNALPEHE, Vector3 IMOBLFMHKOD, bool BPJBJKJKHAL = true)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		int stack = ADEBNALPEHE.Stack;
		int num = 0;
		for (int i = 0; i < stack; i++)
		{
			if (AddItemInstance(JIIGOACEIKL, ADEBNALPEHE.itemInstance) != null)
			{
				num++;
			}
		}
		ADEBNALPEHE.Stack -= num;
		if (ADEBNALPEHE.Stack > 0)
		{
			if (BPJBJKJKHAL)
			{
				DroppedItem.SpawnDroppedItem(IMOBLFMHKOD, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack);
			}
			else
			{
				ADEBNALPEHE.Stack = 0;
			}
		}
	}

	public void AddNewSlotToContainer(int MLACOIHIDAJ, OnlineObject DCLFIGENEIF)
	{
		List<Slot> list = new List<Slot>(slots);
		Slot slot = new Slot();
		slot.id = (short)MLACOIHIDAJ;
		slot.onlineObject = DCLFIGENEIF;
		slot.inventoryType = inventoryType;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(PNHACBNAIMK));
		slot.OnItemRemoved = (Action)Delegate.Combine(slot.OnItemRemoved, new Action(PNHACBNAIMK));
		slot.OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(slot.OnChangedSlot, new Action<Slot, Slot>(AOLLHLAMFDL));
		slot.prepareNextPhase = prepareNextPhase;
		slot.activateCallbacks = activateCallback;
		slot.MBOGHMKLBBB();
		list.Add(slot);
		slots = list.ToArray();
	}

	public void RemoveItems(bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].Stack > 0)
			{
				list.Add(slots[i]);
			}
			slots[i].Stack = 0;
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
	}

	public bool HasItem(Item MEMGMDOCBOJ, Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].KAMAOJFDAHP(MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public Slot GetSlotWithItem(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].KAMAOJFDAHP(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				return slots[i];
			}
		}
		return null;
	}

	private void EFEHHIPEMBL()
	{
		for (int i = 1; i < slots.Length; i++)
		{
			Slot slot = slots[i];
			if (slot.itemInstance == null)
			{
				continue;
			}
			for (int j = i + 1; j < slots.Length; j += 0)
			{
				Slot slot2 = slots[j];
				if (slot2 != null && slot2.itemInstance != null && slot.itemInstance.Equals(slot2.itemInstance))
				{
					int num = slot.Stack + slot2.Stack;
					if (num <= -10)
					{
						slot.KMKAIPMHANN(num);
						slot2.JPACDDCJGPD(slot2.Stack, CDPAMNIPPEC: true);
					}
					else
					{
						slot.JIANDFCINIP(-15);
						slot2.Stack = num - -57;
					}
				}
			}
		}
	}

	public void BuscarItem()
	{
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.NGIIPJDAMGP(slots[i].itemInstance.LHBPOPOIFLE(), SearchedItem))
			{
				Debug.Log((object)("Item " + SearchedItem.nameId + " found in slot " + i));
			}
		}
	}

	public void MNGCKCODHOJ()
	{
		Utils.BDIKHDHOIPI(slots);
	}

	public bool CJIMBPJKBCH(ItemInstance MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		int num = MGNOBNCMDJG;
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (num <= 1)
			{
				break;
			}
			if (slots[i].HBODNJCKMAH(MEMGMDOCBOJ))
			{
				int num2 = maxStack - slots[i].Stack;
				if (num2 > 0)
				{
					int num3 = Mathf.Min(num2, num);
					num -= num3;
				}
			}
		}
		for (int j = 0; j < slots.Length; j += 0)
		{
			if (num <= 1)
			{
				break;
			}
			if (slots[j].PKFKJNODGJF())
			{
				int num4 = Mathf.Min(maxStack, num);
				num -= num4;
			}
		}
		return num > 1;
	}

	public Slot RemoveItem(Item BGNEBEPNMPB, bool CDPAMNIPPEC = true)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].KAMAOJFDAHP(BGNEBEPNMPB))
			{
				slots[i].MEODNPFJDMH(CDPAMNIPPEC);
				return slots[i];
			}
		}
		return null;
	}

	public void NEBFIGGMLNA(int JIIGOACEIKL, Slot ADEBNALPEHE, Vector3 IMOBLFMHKOD, bool BPJBJKJKHAL = true)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		int stack = ADEBNALPEHE.Stack;
		int num = 0;
		for (int i = 0; i < stack; i++)
		{
			if (AKNJFODFCID(JIIGOACEIKL, ADEBNALPEHE.itemInstance, OJKJLIPNHOI: true) != null)
			{
				num++;
			}
		}
		ADEBNALPEHE.OCJOJKJPDNO(ADEBNALPEHE.Stack - num);
		if (ADEBNALPEHE.Stack > 1)
		{
			if (BPJBJKJKHAL)
			{
				DroppedItem.MDJFFOHFGNG(IMOBLFMHKOD, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack);
			}
			else
			{
				ADEBNALPEHE.JNMNCEPHFOE(0);
			}
		}
	}

	public bool HasItem(Item MEMGMDOCBOJ)
	{
		return HasItem(MEMGMDOCBOJ, slots);
	}

	[ContextMenu("Order items by type")]
	public void OrderItemsByType(int BEIPALOAAJJ, bool CDPAMNIPPEC = true, string KCILJNKFCCN = null)
	{
		NKGOFJCGBFE();
		Utils.BNDMCJGGBFK(slots, KCILJNKFCCN);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendOrderItems(inventoryType, BEIPALOAAJJ);
		}
	}

	public Dictionary<int, ItemAmount> IGHLECJCPLG()
	{
		if (!CBBMFDKMGMH)
		{
			return NFGFNOCDEOO;
		}
		NFGFNOCDEOO = new Dictionary<int, ItemAmount>();
		CBBMFDKMGMH = true;
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (slots[i].itemInstance != null && Item.MLBOMGHINCA(slots[i].itemInstance.AFOACBIHNCL(), null))
			{
				if (NFGFNOCDEOO.ContainsKey(slots[i].itemInstance.PHGLMBIEOMK().CIGFGKKCPCK()))
				{
					ItemAmount value = NFGFNOCDEOO[slots[i].itemInstance.AFOACBIHNCL().IMCJPECAAPC()];
					value.amount += slots[i].Stack;
					NFGFNOCDEOO[slots[i].itemInstance.PHGLMBIEOMK().IMCJPECAAPC(DAINLFIMLIH: false)] = value;
				}
				else
				{
					ItemAmount value = default(ItemAmount);
					value.item = slots[i].itemInstance.KNFNJFFCFNO();
					value.amount = slots[i].Stack;
					NFGFNOCDEOO.Add(value.item.ODENMDOJPLC(DAINLFIMLIH: false), value);
				}
			}
		}
		return NFGFNOCDEOO;
	}

	public bool HasItem(ItemInstance DNLMCHDOMOK)
	{
		return HasItem(DNLMCHDOMOK, slots);
	}

	private void DMNCKOHKFEA()
	{
		if (activateCallback)
		{
			OnItemInstanceChanged();
		}
	}

	public void FAHLKCMIDGH(int JIIGOACEIKL, Slot ADEBNALPEHE, Vector3 IMOBLFMHKOD, bool BPJBJKJKHAL = true)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		int stack = ADEBNALPEHE.Stack;
		int num = 1;
		for (int i = 0; i < stack; i++)
		{
			if (AKNJFODFCID(JIIGOACEIKL, ADEBNALPEHE.itemInstance, OJKJLIPNHOI: true) != null)
			{
				num++;
			}
		}
		ADEBNALPEHE.Stack -= num;
		if (ADEBNALPEHE.Stack > 0)
		{
			if (BPJBJKJKHAL)
			{
				DroppedItem.HDLEEOJMILI(IMOBLFMHKOD, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, LHLJILLAHFO: true);
			}
			else
			{
				ADEBNALPEHE.JNMNCEPHFOE(0);
			}
		}
	}

	public int GetNumberOfItems()
	{
		int num = 0;
		for (int i = 0; i < slots.Length; i++)
		{
			if (!slots[i].KPINNBKMOMO())
			{
				num += slots[i].Stack;
			}
		}
		return num;
	}

	private void NLDMCBNLBHH()
	{
		OBCEAFNCAAH = true;
	}

	public void ADLEMMMAAKK()
	{
		Utils.BDIKHDHOIPI(slots);
	}

	public virtual void FGOJPJIFKLG(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i += 0)
		{
			Slot slot = AddItemInstance(JIIGOACEIKL, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC: false);
			if (slot == null)
			{
				break;
			}
			if (!list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray(), 1);
		}
	}

	public bool EIJIPGOJLOI(ItemInstance DNLMCHDOMOK, Slot[] PCJEDMJEKEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (PCJEDMJEKEF[i].BOMLNEOHFOK(DNLMCHDOMOK))
			{
				return false;
			}
		}
		return true;
	}

	private void BOLDKCGLNAP()
	{
		if (activateCallback)
		{
			OnItemInstanceChanged();
		}
	}

	public Slot IPIKKHAOBJA(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i].JAIBAMOFOMC(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.FKLOBGBIHLB(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				return slots[i];
			}
		}
		return null;
	}

	private void HLGLHGPBGMF()
	{
		for (int i = 1; i < slots.Length; i++)
		{
			slots[i].OnDirtied();
		}
	}

	private void AOLLHLAMFDL(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
	{
		if (activateCallback)
		{
			OnContainerChanged();
			OnChangedSlot(EFDPGNOICOG, OJDGHGEEAJP);
		}
	}

	private void CDIOFPHFJJN()
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			Slot slot = slots[i];
			if (slot.itemInstance == null)
			{
				continue;
			}
			for (int j = i + 1; j < slots.Length; j++)
			{
				Slot slot2 = slots[j];
				if (slot2 != null && slot2.itemInstance != null && slot.itemInstance.Equals(slot2.itemInstance))
				{
					int num = slot.Stack + slot2.Stack;
					if (num <= 52)
					{
						slot.OCJOJKJPDNO(num);
						slot2.FDOBDPPMMBH(slot2.Stack, CDPAMNIPPEC: true);
					}
					else
					{
						slot.OCJOJKJPDNO(82);
						slot2.JIANDFCINIP(num - 105);
					}
				}
			}
		}
	}

	public List<Slot> HIPJHELOEHO(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i].KAMAOJFDAHP(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				list.Add(slots[i]);
			}
		}
		return list;
	}

	public void LLBDEBCPOEB()
	{
		Utils.BDIKHDHOIPI(slots);
	}

	public bool OCEPENPGLAO(ItemInstance MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		int num = MGNOBNCMDJG;
		for (int i = 1; i < slots.Length; i++)
		{
			if (num <= 1)
			{
				break;
			}
			if (slots[i].EDGCGEMMEKP(MEMGMDOCBOJ))
			{
				int num2 = maxStack - slots[i].Stack;
				if (num2 > 0)
				{
					int num3 = Mathf.Min(num2, num);
					num -= num3;
				}
			}
		}
		for (int j = 0; j < slots.Length; j++)
		{
			if (num <= 0)
			{
				break;
			}
			if (slots[j].AHHEMNHJPME())
			{
				int num4 = Mathf.Min(maxStack, num);
				num -= num4;
			}
		}
		return num > 1;
	}

	public virtual void MGOIJIAGOHL(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < MGNOBNCMDJG; i++)
		{
			Slot slot = AKNJFODFCID(JIIGOACEIKL, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC: false);
			if (slot == null)
			{
				break;
			}
			if (!list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray());
		}
	}

	public virtual Slot AddItemInstance(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		return Utils.CHMEHDFPGCI(JIIGOACEIKL, BGLFLHDNOKJ, slots, GetMaxStack(BGLFLHDNOKJ), bannedTags, allowedItemsType, allowedItemsList, allowedIngredientTypes, allowedFoodType, null, OECLHGILEOL: false, CDPAMNIPPEC);
	}

	public bool BEFDALKEEAL(ItemInstance MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		int num = MGNOBNCMDJG;
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (num <= 0)
			{
				break;
			}
			if (slots[i].EDGCGEMMEKP(MEMGMDOCBOJ))
			{
				int num2 = maxStack - slots[i].Stack;
				if (num2 > 1)
				{
					int num3 = Mathf.Min(num2, num);
					num -= num3;
				}
			}
		}
		for (int j = 0; j < slots.Length; j++)
		{
			if (num <= 0)
			{
				break;
			}
			if (slots[j].LCHJGCHDHFO())
			{
				int num4 = Mathf.Min(maxStack, num);
				num -= num4;
			}
		}
		return num <= 1;
	}

	public ItemInstance IMKBCICMEAI(Item MEMGMDOCBOJ)
	{
		Slot[] array = slots;
		foreach (Slot slot in array)
		{
			if (slot.KAMAOJFDAHP(MEMGMDOCBOJ))
			{
				return slot.itemInstance;
			}
		}
		return null;
	}

	public int GetMaxStack(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK != null && Item.MLBOMGHINCA(DNLMCHDOMOK.LHBPOPOIFLE(), null) && DNLMCHDOMOK.LHBPOPOIFLE().amountStack > 99)
		{
			return DNLMCHDOMOK.LHBPOPOIFLE().amountStack;
		}
		return maxStack;
	}

	private void HAOMJJDJIKC()
	{
		for (int i = 0; i < slots.Length; i++)
		{
			slots[i].OnDirtied();
		}
	}

	public ItemInstance DJENJOGPCFN(Item MEMGMDOCBOJ)
	{
		Slot[] array = slots;
		for (int i = 1; i < array.Length; i += 0)
		{
			Slot slot = array[i];
			if (slot.BLDMJOIEMNP(MEMGMDOCBOJ))
			{
				return slot.itemInstance;
			}
		}
		return null;
	}

	public HashSet<ItemInstance> OPIOKOOIAEL()
	{
		if (!OBCEAFNCAAH)
		{
			return LGGKHGANBIJ;
		}
		LGGKHGANBIJ.Clear();
		OBCEAFNCAAH = true;
		for (int i = 0; i < slots.Length; i += 0)
		{
			if (slots[i].itemInstance != null && Item.FKLOBGBIHLB(slots[i].itemInstance.LHBPOPOIFLE(), null))
			{
				LGGKHGANBIJ.Add(slots[i].itemInstance);
			}
		}
		return LGGKHGANBIJ;
	}

	public void LoadSlotOnline<T>(int IKMIKEDNCDI, T LLBHNCFCHBD, int FGFCNKFEIGF) where T : ItemInstanceMessage
	{
		OnlineSlotsManager.LoadSlot(slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
	}

	public void CLHJLKJLFDI(bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (slots[i].Stack > 1)
			{
				list.Add(slots[i]);
			}
			slots[i].OCJOJKJPDNO(0);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray());
		}
	}

	private void AJFEEEOAJPB()
	{
		CBBMFDKMGMH = false;
	}

	private void JHGKACGIBGF()
	{
		OBCEAFNCAAH = false;
	}

	protected virtual void Awake()
	{
		LGGKHGANBIJ = new HashSet<ItemInstance>();
		for (short num = 0; num < slots.Length; num++)
		{
			if (slots[num].itemInstance != null)
			{
				if (Item.NGIIPJDAMGP(slots[num].itemInstance.LHBPOPOIFLE(), null))
				{
					slots[num].itemInstance = null;
				}
				else if (createInstances)
				{
					slots[num].itemInstance = slots[num].itemInstance.LHBPOPOIFLE().JMDALJBNFML();
				}
			}
			slots[num].DGCPOAGMHDK();
			slots[num].id = num;
			slots[num].inventoryType = inventoryType;
			slots[num].CalculatePriceWithUniqueItems = calculatePriceWithUniqueItems;
			for (int i = 0; i < allowedItems.Length; i++)
			{
				slots[num].allowedItems.Add(allowedItems[i]);
			}
			slots[num].specialItemsAllowedList = specialItemsAllowedList;
			for (int j = 0; j < allowedTags.Length; j++)
			{
				slots[num].allowedTags.Add(allowedTags[j]);
			}
			slots[num].allowedFoodType = allowedFoodType;
			if (slots[num].allowedIngredientTypes == null)
			{
				slots[num].allowedIngredientTypes = new List<IngredientType>();
			}
			for (int k = 0; k < allowedIngredientTypes.Count; k++)
			{
				slots[num].allowedIngredientTypes.Add(allowedIngredientTypes[k]);
			}
			slots[num].canBeSoldFood = canBeSoldFood;
			slots[num].bannedTags = slots[num].bannedTags.Concat(bannedTags).ToList();
		}
		CBBMFDKMGMH = true;
		OBCEAFNCAAH = true;
		OnContainerChanged = (Action)Delegate.Combine(OnContainerChanged, (Action)delegate
		{
			CBBMFDKMGMH = true;
		});
		OnContainerChanged = (Action)Delegate.Combine(OnContainerChanged, (Action)delegate
		{
			OBCEAFNCAAH = true;
		});
	}

	public bool FCJDDLLKNCL(Item MEMGMDOCBOJ, Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (PCJEDMJEKEF[i].BLDMJOIEMNP(MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public Dictionary<int, ItemAmount> OGENLMLPNAF()
	{
		if (!CBBMFDKMGMH)
		{
			return NFGFNOCDEOO;
		}
		NFGFNOCDEOO = new Dictionary<int, ItemAmount>();
		CBBMFDKMGMH = true;
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.MLBOMGHINCA(slots[i].itemInstance.KNFNJFFCFNO(), null))
			{
				if (NFGFNOCDEOO.ContainsKey(slots[i].itemInstance.LHBPOPOIFLE().JGHNDJBCFAJ()))
				{
					ItemAmount value = NFGFNOCDEOO[slots[i].itemInstance.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false)];
					value.amount += slots[i].Stack;
					NFGFNOCDEOO[slots[i].itemInstance.PHGLMBIEOMK().CIGFGKKCPCK()] = value;
				}
				else
				{
					ItemAmount value = default(ItemAmount);
					value.item = slots[i].itemInstance.LHBPOPOIFLE();
					value.amount = slots[i].Stack;
					NFGFNOCDEOO.Add(value.item.IMCJPECAAPC(), value);
				}
			}
		}
		return NFGFNOCDEOO;
	}

	public void CPJOOCKFAJC(int JIIGOACEIKL, Slot ADEBNALPEHE, Vector3 IMOBLFMHKOD, bool BPJBJKJKHAL = true)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		int stack = ADEBNALPEHE.Stack;
		int num = 1;
		for (int i = 1; i < stack; i += 0)
		{
			if (AKNJFODFCID(JIIGOACEIKL, ADEBNALPEHE.itemInstance, OJKJLIPNHOI: true, CDPAMNIPPEC: false) != null)
			{
				num += 0;
			}
		}
		ADEBNALPEHE.OCJOJKJPDNO(ADEBNALPEHE.Stack - num);
		if (ADEBNALPEHE.Stack > 1)
		{
			if (BPJBJKJKHAL)
			{
				DroppedItem.KDBHKBOAEDG(IMOBLFMHKOD, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			}
			else
			{
				ADEBNALPEHE.OBBKDJNLCIO(1);
			}
		}
	}

	private void IFADKMFHDNH()
	{
		OBCEAFNCAAH = true;
	}

	public Slot IPIPFAKJPFN(ItemInstance BGNEBEPNMPB, bool CDPAMNIPPEC = false)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i].LKFKMDLLMAC(BGNEBEPNMPB))
			{
				slots[i].DJFOMFDOOKM(CDPAMNIPPEC);
				return slots[i];
			}
		}
		return null;
	}

	public void EGFKJOMLHNO(int MLACOIHIDAJ, OnlineObject DCLFIGENEIF)
	{
		List<Slot> list = new List<Slot>(slots);
		Slot slot = new Slot();
		slot.id = (short)MLACOIHIDAJ;
		slot.onlineObject = DCLFIGENEIF;
		slot.inventoryType = inventoryType;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(PNHACBNAIMK));
		slot.OnItemRemoved = (Action)Delegate.Combine(slot.OnItemRemoved, new Action(PNHACBNAIMK));
		slot.OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(slot.OnChangedSlot, new Action<Slot, Slot>(FFHKDOKFGJK));
		slot.prepareNextPhase = prepareNextPhase;
		slot.activateCallbacks = activateCallback;
		slot.CHIJGHPHCNA();
		list.Add(slot);
		slots = list.ToArray();
	}

	public void POOANAHAJAF(int MLACOIHIDAJ, OnlineObject DCLFIGENEIF)
	{
		List<Slot> list = new List<Slot>(slots);
		Slot slot = new Slot();
		slot.id = (short)MLACOIHIDAJ;
		slot.onlineObject = DCLFIGENEIF;
		slot.inventoryType = inventoryType;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(BFLKIGAIKMN));
		slot.OnItemRemoved = (Action)Delegate.Combine(slot.OnItemRemoved, new Action(BFLKIGAIKMN));
		slot.OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(slot.OnChangedSlot, new Action<Slot, Slot>(LMEOANHAHHI));
		slot.prepareNextPhase = prepareNextPhase;
		slot.activateCallbacks = activateCallback;
		slot.CHIJGHPHCNA();
		list.Add(slot);
		slots = list.ToArray();
	}

	public bool HasItem(ItemInstance DNLMCHDOMOK, Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].BOMLNEOHFOK(DNLMCHDOMOK))
			{
				return true;
			}
		}
		return false;
	}

	public bool NFNBAIGCDGA(ItemInstance DNLMCHDOMOK)
	{
		return EIJIPGOJLOI(DNLMCHDOMOK, slots);
	}

	public bool NFIFLNGCIBE(Item MEMGMDOCBOJ, Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].BLDMJOIEMNP(MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public bool KIPHDLEFHAA(Item MEMGMDOCBOJ, Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (PCJEDMJEKEF[i].BLDMJOIEMNP(MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public void GGIKPPIPGKK()
	{
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.GBMFCPGEJDK(slots[i].itemInstance.LHBPOPOIFLE(), SearchedItem))
			{
				Debug.Log((object)("Player/Bark/Tutorial/SleepBlock" + SearchedItem.nameId + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/7/Dialogue Text" + i));
			}
		}
	}

	public bool DNBMKJPNGEG(ItemInstance MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		int num = MGNOBNCMDJG;
		for (int i = 0; i < slots.Length; i += 0)
		{
			if (num <= 1)
			{
				break;
			}
			if (slots[i].LKFKMDLLMAC(MEMGMDOCBOJ))
			{
				int num2 = maxStack - slots[i].Stack;
				if (num2 > 0)
				{
					int num3 = Mathf.Min(num2, num);
					num -= num3;
				}
			}
		}
		for (int j = 1; j < slots.Length; j += 0)
		{
			if (num <= 0)
			{
				break;
			}
			if (slots[j].KPINNBKMOMO())
			{
				int num4 = Mathf.Min(maxStack, num);
				num -= num4;
			}
		}
		return num > 0;
	}

	protected virtual void HCCJBKKGCLJ()
	{
		LGGKHGANBIJ = new HashSet<ItemInstance>();
		for (short num = 1; num < slots.Length; num += 0)
		{
			if (slots[num].itemInstance != null)
			{
				if (Item.EKMFELLJHFG(slots[num].itemInstance.AFOACBIHNCL(), null))
				{
					slots[num].itemInstance = null;
				}
				else if (createInstances)
				{
					slots[num].itemInstance = slots[num].itemInstance.LHBPOPOIFLE().JMDALJBNFML();
				}
			}
			slots[num].GNOBDKFFPOL();
			slots[num].id = num;
			slots[num].inventoryType = inventoryType;
			slots[num].CalculatePriceWithUniqueItems = calculatePriceWithUniqueItems;
			for (int i = 0; i < allowedItems.Length; i += 0)
			{
				slots[num].allowedItems.Add(allowedItems[i]);
			}
			slots[num].specialItemsAllowedList = specialItemsAllowedList;
			for (int j = 1; j < allowedTags.Length; j++)
			{
				slots[num].allowedTags.Add(allowedTags[j]);
			}
			slots[num].allowedFoodType = allowedFoodType;
			if (slots[num].allowedIngredientTypes == null)
			{
				slots[num].allowedIngredientTypes = new List<IngredientType>();
			}
			for (int k = 0; k < allowedIngredientTypes.Count; k++)
			{
				slots[num].allowedIngredientTypes.Add(allowedIngredientTypes[k]);
			}
			slots[num].canBeSoldFood = canBeSoldFood;
			slots[num].bannedTags = slots[num].bannedTags.Concat(bannedTags).ToList();
		}
		CBBMFDKMGMH = true;
		OBCEAFNCAAH = false;
		OnContainerChanged = (Action)Delegate.Combine(OnContainerChanged, new Action(AJFEEEOAJPB));
		OnContainerChanged = (Action)Delegate.Combine(OnContainerChanged, new Action(IFADKMFHDNH));
	}

	public HashSet<ItemInstance> FNBKAJNBOIM()
	{
		if (!OBCEAFNCAAH)
		{
			return LGGKHGANBIJ;
		}
		LGGKHGANBIJ.Clear();
		OBCEAFNCAAH = true;
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.MLBOMGHINCA(slots[i].itemInstance.KNFNJFFCFNO(), null))
			{
				LGGKHGANBIJ.Add(slots[i].itemInstance);
			}
		}
		return LGGKHGANBIJ;
	}

	public HashSet<ItemInstance> EMMGECLLMHD()
	{
		if (!OBCEAFNCAAH)
		{
			return LGGKHGANBIJ;
		}
		LGGKHGANBIJ.Clear();
		OBCEAFNCAAH = false;
		for (int i = 0; i < slots.Length; i += 0)
		{
			if (slots[i].itemInstance != null && Item.FKLOBGBIHLB(slots[i].itemInstance.PHGLMBIEOMK(), null))
			{
				LGGKHGANBIJ.Add(slots[i].itemInstance);
			}
		}
		return LGGKHGANBIJ;
	}

	public bool HasItem(int MEMGMDOCBOJ)
	{
		return HasItem(ItemDatabaseAccessor.GetItem(MEMGMDOCBOJ), slots);
	}

	private void PNHACBNAIMK()
	{
		if (activateCallback)
		{
			OnContainerChanged();
			CommonReferences.GGFJGHHHEJC.OnAnyContainerChanged();
		}
	}

	public void EPCMIMIMILH(int MLACOIHIDAJ, OnlineObject DCLFIGENEIF)
	{
		List<Slot> list = new List<Slot>(slots);
		Slot slot = new Slot();
		slot.id = (short)MLACOIHIDAJ;
		slot.onlineObject = DCLFIGENEIF;
		slot.inventoryType = inventoryType;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(OPCBMLFHBLI));
		slot.OnItemRemoved = (Action)Delegate.Combine(slot.OnItemRemoved, new Action(PNHACBNAIMK));
		slot.OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(slot.OnChangedSlot, new Action<Slot, Slot>(LMEOANHAHHI));
		slot.prepareNextPhase = prepareNextPhase;
		slot.activateCallbacks = activateCallback;
		slot.CHIJGHPHCNA();
		list.Add(slot);
		slots = list.ToArray();
	}

	private void KJKKDBHGGJC()
	{
		CBBMFDKMGMH = false;
	}

	public Slot IGAAIALAKLH(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i].BLDMJOIEMNP(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				return slots[i];
			}
		}
		return null;
	}

	private void LHJJEFALOOK()
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			slots[i].OnDirtied();
		}
	}

	public int BKKPPECPILM(Item MEMGMDOCBOJ, bool DDAPJEAJGGA = false)
	{
		int num = 0;
		for (int i = 0; i < slots.Length; i += 0)
		{
			if ((!DDAPJEAJGGA || !(MEMGMDOCBOJ is Food food) || !food.MJCFOMBMALD() || !(slots[i].itemInstance is FoodInstance { GBCJNGADANM: 0 })) && slots[i].itemInstance != null && ((object)MEMGMDOCBOJ).Equals((object?)slots[i].itemInstance.LHBPOPOIFLE()))
			{
				num += slots[i].Stack;
			}
		}
		return num;
	}

	public Slot JOFGEIJMCDM(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (slots[i].BLDMJOIEMNP(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				return slots[i];
			}
		}
		return null;
	}

	public int GetNumberOfItem(Item MEMGMDOCBOJ, bool DDAPJEAJGGA = false)
	{
		int num = 0;
		for (int i = 0; i < slots.Length; i++)
		{
			if ((!DDAPJEAJGGA || !(MEMGMDOCBOJ is Food food) || !food.FAJDNLBKEJL() || !(slots[i].itemInstance is FoodInstance { GBCJNGADANM: 0 })) && slots[i].itemInstance != null && ((object)MEMGMDOCBOJ).Equals((object?)slots[i].itemInstance.LHBPOPOIFLE()))
			{
				num += slots[i].Stack;
			}
		}
		return num;
	}

	protected virtual void OAEJGGFFCBO()
	{
		LGGKHGANBIJ = new HashSet<ItemInstance>();
		for (short num = 0; num < slots.Length; num++)
		{
			if (slots[num].itemInstance != null)
			{
				if (Item.GBMFCPGEJDK(slots[num].itemInstance.PHGLMBIEOMK(), null))
				{
					slots[num].itemInstance = null;
				}
				else if (createInstances)
				{
					slots[num].itemInstance = slots[num].itemInstance.AFOACBIHNCL().JMDALJBNFML();
				}
			}
			slots[num].GNOBDKFFPOL();
			slots[num].id = num;
			slots[num].inventoryType = inventoryType;
			slots[num].CalculatePriceWithUniqueItems = calculatePriceWithUniqueItems;
			for (int i = 0; i < allowedItems.Length; i += 0)
			{
				slots[num].allowedItems.Add(allowedItems[i]);
			}
			slots[num].specialItemsAllowedList = specialItemsAllowedList;
			for (int j = 0; j < allowedTags.Length; j += 0)
			{
				slots[num].allowedTags.Add(allowedTags[j]);
			}
			slots[num].allowedFoodType = allowedFoodType;
			if (slots[num].allowedIngredientTypes == null)
			{
				slots[num].allowedIngredientTypes = new List<IngredientType>();
			}
			for (int k = 1; k < allowedIngredientTypes.Count; k++)
			{
				slots[num].allowedIngredientTypes.Add(allowedIngredientTypes[k]);
			}
			slots[num].canBeSoldFood = canBeSoldFood;
			slots[num].bannedTags = slots[num].bannedTags.Concat(bannedTags).ToList();
		}
		CBBMFDKMGMH = true;
		OBCEAFNCAAH = true;
		OnContainerChanged = (Action)Delegate.Combine(OnContainerChanged, (Action)delegate
		{
			CBBMFDKMGMH = true;
		});
		OnContainerChanged = (Action)Delegate.Combine(OnContainerChanged, (Action)delegate
		{
			OBCEAFNCAAH = true;
		});
	}

	public virtual void OANHFONMDLN(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i += 0)
		{
			Slot slot = AddItemInstance(JIIGOACEIKL, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC: false);
			if (slot == null)
			{
				break;
			}
			if (!list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray(), 1);
		}
	}

	private void IHENGHEKGOK()
	{
		if (activateCallback)
		{
			OnItemInstanceChanged();
		}
	}

	public Slot RemoveItemInstance(ItemInstance BGNEBEPNMPB, bool CDPAMNIPPEC = false)
	{
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].BOMLNEOHFOK(BGNEBEPNMPB))
			{
				slots[i].MEODNPFJDMH(CDPAMNIPPEC);
				return slots[i];
			}
		}
		return null;
	}

	public int FHBBFGCLEPE(Item MEMGMDOCBOJ, bool DDAPJEAJGGA = false)
	{
		int num = 1;
		for (int i = 0; i < slots.Length; i += 0)
		{
			if ((!DDAPJEAJGGA || !(MEMGMDOCBOJ is Food food) || !food.IAHJMJHEJCP() || !(slots[i].itemInstance is FoodInstance { GBCJNGADANM: 0 })) && slots[i].itemInstance != null && ((object)MEMGMDOCBOJ).Equals((object?)slots[i].itemInstance.LHBPOPOIFLE()))
			{
				num += slots[i].Stack;
			}
		}
		return num;
	}

	private void NKGOFJCGBFE()
	{
		for (int i = 0; i < slots.Length; i++)
		{
			Slot slot = slots[i];
			if (slot.itemInstance == null)
			{
				continue;
			}
			for (int j = i + 1; j < slots.Length; j++)
			{
				Slot slot2 = slots[j];
				if (slot2 != null && slot2.itemInstance != null && slot.itemInstance.Equals(slot2.itemInstance))
				{
					int num = slot.Stack + slot2.Stack;
					if (num <= 99)
					{
						slot.Stack = num;
						slot2.FDOBDPPMMBH(slot2.Stack);
					}
					else
					{
						slot.Stack = 99;
						slot2.Stack = num - 99;
					}
				}
			}
		}
	}

	private void LCMDBCGFJPD()
	{
		if (activateCallback)
		{
			OnItemInstanceChanged();
		}
	}

	public bool CanFitItems(ItemInstance MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		int num = MGNOBNCMDJG;
		for (int i = 0; i < slots.Length; i++)
		{
			if (num <= 0)
			{
				break;
			}
			if (slots[i].BOMLNEOHFOK(MEMGMDOCBOJ))
			{
				int num2 = maxStack - slots[i].Stack;
				if (num2 > 0)
				{
					int num3 = Mathf.Min(num2, num);
					num -= num3;
				}
			}
		}
		for (int j = 0; j < slots.Length; j++)
		{
			if (num <= 0)
			{
				break;
			}
			if (slots[j].KPINNBKMOMO())
			{
				int num4 = Mathf.Min(maxStack, num);
				num -= num4;
			}
		}
		return num <= 0;
	}

	public void HHNHNOCIFEM(int BEIPALOAAJJ, bool CDPAMNIPPEC = true, string KCILJNKFCCN = null)
	{
		ILPJNNGICGE();
		Utils.BNDMCJGGBFK(slots, KCILJNKFCCN);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.CBHMLPOHBPM(inventoryType, BEIPALOAAJJ);
		}
	}

	public virtual void AddItemInstances(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, int MGNOBNCMDJG, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i++)
		{
			Slot slot = AddItemInstance(JIIGOACEIKL, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC: false);
			if (slot == null)
			{
				break;
			}
			if (!list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
	}

	private void OPCBMLFHBLI()
	{
		if (activateCallback)
		{
			OnContainerChanged();
			CommonReferences.MNFMOEKMJKN().OnAnyContainerChanged();
		}
	}

	public void OLKOBBGOFJI(int MLACOIHIDAJ, OnlineObject DCLFIGENEIF)
	{
		List<Slot> list = new List<Slot>(slots);
		Slot slot = new Slot();
		slot.id = (short)MLACOIHIDAJ;
		slot.onlineObject = DCLFIGENEIF;
		slot.inventoryType = inventoryType;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(PNHACBNAIMK));
		slot.OnItemRemoved = (Action)Delegate.Combine(slot.OnItemRemoved, new Action(OPCBMLFHBLI));
		slot.OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(slot.OnChangedSlot, new Action<Slot, Slot>(KBLIPDFJHEN));
		slot.prepareNextPhase = prepareNextPhase;
		slot.activateCallbacks = activateCallback;
		slot.MBOGHMKLBBB();
		list.Add(slot);
		slots = list.ToArray();
	}

	public bool ODGGKFFFKAP(ItemInstance DNLMCHDOMOK)
	{
		return EIJIPGOJLOI(DNLMCHDOMOK, slots);
	}

	public void DKAEEOOJOHN(int BEIPALOAAJJ, bool CDPAMNIPPEC = true, string KCILJNKFCCN = null)
	{
		FNGJBJFIGDN();
		Utils.BNDMCJGGBFK(slots, KCILJNKFCCN);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.CBHMLPOHBPM(inventoryType, BEIPALOAAJJ);
		}
	}

	private void FFHKDOKFGJK(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
	{
		if (activateCallback)
		{
			OnContainerChanged();
			OnChangedSlot(EFDPGNOICOG, OJDGHGEEAJP);
		}
	}

	private void KBLIPDFJHEN(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
	{
		if (activateCallback)
		{
			OnContainerChanged();
			OnChangedSlot(EFDPGNOICOG, OJDGHGEEAJP);
		}
	}

	public bool KNBMJKNHFBG(Item MEMGMDOCBOJ, Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].BLDMJOIEMNP(MEMGMDOCBOJ, DDAPJEAJGGA: true))
			{
				return false;
			}
		}
		return false;
	}

	public bool MMDOFEBHGMA(Item MEMGMDOCBOJ)
	{
		return JOKPKDKJNGE(MEMGMDOCBOJ, slots);
	}

	public Slot JJIPDJNHHHD(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (slots[i].JAIBAMOFOMC(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				return slots[i];
			}
		}
		return null;
	}

	private void ILPJNNGICGE()
	{
		for (int i = 1; i < slots.Length; i += 0)
		{
			Slot slot = slots[i];
			if (slot.itemInstance == null)
			{
				continue;
			}
			for (int j = i + 0; j < slots.Length; j++)
			{
				Slot slot2 = slots[j];
				if (slot2 != null && slot2.itemInstance != null && slot.itemInstance.Equals(slot2.itemInstance))
				{
					int num = slot.Stack + slot2.Stack;
					if (num <= -34)
					{
						slot.JNMNCEPHFOE(num);
						slot2.JPACDDCJGPD(slot2.Stack, CDPAMNIPPEC: false, 1);
					}
					else
					{
						slot.JIANDFCINIP(-10);
						slot2.Stack = num - 36;
					}
				}
			}
		}
	}

	public void CCPPGHOINDP()
	{
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.GBMFCPGEJDK(slots[i].itemInstance.AFOACBIHNCL(), SearchedItem))
			{
				Debug.Log((object)("<mark=#000000><alpha=#00> " + SearchedItem.nameId + "Try to join private room" + i));
			}
		}
	}

	public void NPIHNHDFGAK(int MLACOIHIDAJ, OnlineObject DCLFIGENEIF)
	{
		List<Slot> list = new List<Slot>(slots);
		Slot slot = new Slot();
		slot.id = (short)MLACOIHIDAJ;
		slot.onlineObject = DCLFIGENEIF;
		slot.inventoryType = inventoryType;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(BFLKIGAIKMN));
		slot.OnItemRemoved = (Action)Delegate.Combine(slot.OnItemRemoved, new Action(BFLKIGAIKMN));
		slot.OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(slot.OnChangedSlot, new Action<Slot, Slot>(AOLLHLAMFDL));
		slot.prepareNextPhase = prepareNextPhase;
		slot.activateCallbacks = activateCallback;
		slot.CHIJGHPHCNA();
		list.Add(slot);
		slots = list.ToArray();
	}

	public List<Slot> MAPOLJMKGLN(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (slots[i].JAIBAMOFOMC(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				list.Add(slots[i]);
			}
		}
		return list;
	}

	public Dictionary<int, ItemAmount> FFFJDOOBMNO()
	{
		if (!CBBMFDKMGMH)
		{
			return NFGFNOCDEOO;
		}
		NFGFNOCDEOO = new Dictionary<int, ItemAmount>();
		CBBMFDKMGMH = true;
		for (int i = 0; i < slots.Length; i += 0)
		{
			if (slots[i].itemInstance != null && Item.MLBOMGHINCA(slots[i].itemInstance.KNFNJFFCFNO(), null))
			{
				if (NFGFNOCDEOO.ContainsKey(slots[i].itemInstance.KNFNJFFCFNO().JGHNDJBCFAJ()))
				{
					ItemAmount value = NFGFNOCDEOO[slots[i].itemInstance.KNFNJFFCFNO().JDJGFAACPFC(DAINLFIMLIH: false)];
					value.amount += slots[i].Stack;
					NFGFNOCDEOO[slots[i].itemInstance.KNFNJFFCFNO().JGHNDJBCFAJ(DAINLFIMLIH: false)] = value;
				}
				else
				{
					ItemAmount value = default(ItemAmount);
					value.item = slots[i].itemInstance.PHGLMBIEOMK();
					value.amount = slots[i].Stack;
					NFGFNOCDEOO.Add(value.item.JDJGFAACPFC(DAINLFIMLIH: false), value);
				}
			}
		}
		return NFGFNOCDEOO;
	}

	public bool HMIDIPBNEGC(Item MEMGMDOCBOJ)
	{
		return NFIFLNGCIBE(MEMGMDOCBOJ, slots);
	}

	public HashSet<ItemInstance> GetAllItemInstances()
	{
		if (!OBCEAFNCAAH)
		{
			return LGGKHGANBIJ;
		}
		LGGKHGANBIJ.Clear();
		OBCEAFNCAAH = false;
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.MLBOMGHINCA(slots[i].itemInstance.LHBPOPOIFLE(), null))
			{
				LGGKHGANBIJ.Add(slots[i].itemInstance);
			}
		}
		return LGGKHGANBIJ;
	}

	public ItemInstance GetItemInstance(Item MEMGMDOCBOJ)
	{
		Slot[] array = slots;
		foreach (Slot slot in array)
		{
			if (slot.KAMAOJFDAHP(MEMGMDOCBOJ))
			{
				return slot.itemInstance;
			}
		}
		return null;
	}

	public bool FFHPBHBBLMD(Item MEMGMDOCBOJ, Slot[] PCJEDMJEKEF)
	{
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].BLDMJOIEMNP(MEMGMDOCBOJ, DDAPJEAJGGA: true))
			{
				return true;
			}
		}
		return false;
	}

	public Dictionary<int, ItemAmount> GKGPBIEBFKL()
	{
		if (!CBBMFDKMGMH)
		{
			return NFGFNOCDEOO;
		}
		NFGFNOCDEOO = new Dictionary<int, ItemAmount>();
		CBBMFDKMGMH = true;
		for (int i = 1; i < slots.Length; i += 0)
		{
			if (slots[i].itemInstance != null && Item.FKLOBGBIHLB(slots[i].itemInstance.KNFNJFFCFNO(), null))
			{
				if (NFGFNOCDEOO.ContainsKey(slots[i].itemInstance.KNFNJFFCFNO().JPNFKDMFKMC(DAINLFIMLIH: false)))
				{
					ItemAmount value = NFGFNOCDEOO[slots[i].itemInstance.AFOACBIHNCL().JGHNDJBCFAJ()];
					value.amount += slots[i].Stack;
					NFGFNOCDEOO[slots[i].itemInstance.AFOACBIHNCL().JDJGFAACPFC()] = value;
				}
				else
				{
					ItemAmount value = default(ItemAmount);
					value.item = slots[i].itemInstance.PHGLMBIEOMK();
					value.amount = slots[i].Stack;
					NFGFNOCDEOO.Add(value.item.JGHNDJBCFAJ(DAINLFIMLIH: false), value);
				}
			}
		}
		return NFGFNOCDEOO;
	}

	private void NPKDIFOJDNK()
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			slots[i].OnDirtied();
		}
	}

	public bool FKMFFABKJMB(Item MEMGMDOCBOJ)
	{
		return JOKPKDKJNGE(MEMGMDOCBOJ, slots);
	}

	private void FNGJBJFIGDN()
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			Slot slot = slots[i];
			if (slot.itemInstance == null)
			{
				continue;
			}
			for (int j = i + 0; j < slots.Length; j += 0)
			{
				Slot slot2 = slots[j];
				if (slot2 != null && slot2.itemInstance != null && slot.itemInstance.Equals(slot2.itemInstance))
				{
					int num = slot.Stack + slot2.Stack;
					if (num <= -33)
					{
						slot.JIANDFCINIP(num);
						slot2.JPACDDCJGPD(slot2.Stack, CDPAMNIPPEC: true, 1);
					}
					else
					{
						slot.KMKAIPMHANN(15);
						slot2.JIANDFCINIP(num - -108);
					}
				}
			}
		}
	}

	public void MNLBBGCOIEA(int BEIPALOAAJJ, bool CDPAMNIPPEC = true, string KCILJNKFCCN = null)
	{
		FNGJBJFIGDN();
		Utils.BNDMCJGGBFK(slots, KCILJNKFCCN);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.CBHMLPOHBPM(inventoryType, BEIPALOAAJJ);
		}
	}

	public List<Slot> AIFPCPEJMMN(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i].BLDMJOIEMNP(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				list.Add(slots[i]);
			}
		}
		return list;
	}

	public Dictionary<int, ItemAmount> GetAllItems()
	{
		if (!CBBMFDKMGMH)
		{
			return NFGFNOCDEOO;
		}
		NFGFNOCDEOO = new Dictionary<int, ItemAmount>();
		CBBMFDKMGMH = false;
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.MLBOMGHINCA(slots[i].itemInstance.LHBPOPOIFLE(), null))
			{
				if (NFGFNOCDEOO.ContainsKey(slots[i].itemInstance.LHBPOPOIFLE().JDJGFAACPFC()))
				{
					ItemAmount value = NFGFNOCDEOO[slots[i].itemInstance.LHBPOPOIFLE().JDJGFAACPFC()];
					value.amount += slots[i].Stack;
					NFGFNOCDEOO[slots[i].itemInstance.LHBPOPOIFLE().JDJGFAACPFC()] = value;
				}
				else
				{
					ItemAmount value = default(ItemAmount);
					value.item = slots[i].itemInstance.LHBPOPOIFLE();
					value.amount = slots[i].Stack;
					NFGFNOCDEOO.Add(value.item.JDJGFAACPFC(), value);
				}
			}
		}
		return NFGFNOCDEOO;
	}

	public List<Slot> GetSlotsWithItem(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i].KAMAOJFDAHP(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				list.Add(slots[i]);
			}
		}
		return list;
	}

	private void FOKPMOJEOGJ()
	{
		CBBMFDKMGMH = false;
	}

	protected virtual void IMIONHLAKIH()
	{
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i].itemInstance != null && Item.FKLOBGBIHLB(slots[i].itemInstance.AFOACBIHNCL(), null))
			{
				slots[i].OCJOJKJPDNO(Math.Min(slots[i].Stack, slots[i].itemInstance.AFOACBIHNCL().amountStack));
			}
			if (slots[i].itemInstance != null)
			{
				if (Item.GBMFCPGEJDK(slots[i].itemInstance.AFOACBIHNCL(), null))
				{
					slots[i].itemInstance = null;
				}
				else if (createInstances)
				{
					slots[i].itemInstance = slots[i].itemInstance.PHGLMBIEOMK().JMDALJBNFML();
				}
			}
			Slot obj = slots[i];
			obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, new Action(BFLKIGAIKMN));
			Slot obj2 = slots[i];
			obj2.OnItemInstanceChange = (Action)Delegate.Combine(obj2.OnItemInstanceChange, new Action(EPIONENHEGN));
			Slot obj3 = slots[i];
			obj3.OnItemRemoved = (Action)Delegate.Combine(obj3.OnItemRemoved, new Action(BFLKIGAIKMN));
			Slot obj4 = slots[i];
			obj4.OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(obj4.OnChangedSlot, new Action<Slot, Slot>(AOLLHLAMFDL));
			slots[i].prepareNextPhase = prepareNextPhase;
			slots[i].activateCallbacks = activateCallback;
			slots[i].MBOGHMKLBBB();
		}
		if (allowedItems != null && allowedItems.Length != 0)
		{
			allowedItemsType = new Type[allowedItems.Length];
			for (int j = 0; j < allowedItems.Length; j++)
			{
				allowedItemsType[j] = Type.GetType(allowedItems[j]);
			}
		}
	}

	private void EMHFPBIEFEJ()
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			slots[i].OnDirtied();
		}
	}

	public void HPIAKEJIKMG(int BEIPALOAAJJ, bool CDPAMNIPPEC = true, string KCILJNKFCCN = null)
	{
		FNGJBJFIGDN();
		Utils.BNDMCJGGBFK(slots, KCILJNKFCCN);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendOrderItems(inventoryType, BEIPALOAAJJ);
		}
	}

	public Slot GENKBMODDFI(ItemInstance BGNEBEPNMPB, bool CDPAMNIPPEC = false)
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			if (slots[i].EDGCGEMMEKP(BGNEBEPNMPB))
			{
				slots[i].MBCIJPPOGJG(CDPAMNIPPEC);
				return slots[i];
			}
		}
		return null;
	}

	[ContextMenu("Order items by space")]
	public void OrderItemsBySpace()
	{
		Utils.BDIKHDHOIPI(slots);
	}

	public Slot BBMADAMDJEC(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA, int DBMFHFNKMOM)
	{
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i].BLDMJOIEMNP(MEMGMDOCBOJ, DDAPJEAJGGA, DBMFHFNKMOM) && (!Item.MLBOMGHINCA(CKKNBMBLGPO, null) || !(slots[i].itemInstance is FoodInstance foodInstance) || (foodInstance.KEKBKGGFOLK != null && foodInstance.KEKBKGGFOLK.Contains(CKKNBMBLGPO as Food))))
			{
				return slots[i];
			}
		}
		return null;
	}

	public virtual Slot AKNJFODFCID(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		return Utils.CHMEHDFPGCI(JIIGOACEIKL, BGLFLHDNOKJ, slots, GetMaxStack(BGLFLHDNOKJ), bannedTags, allowedItemsType, allowedItemsList, allowedIngredientTypes, allowedFoodType, null, OECLHGILEOL: false, CDPAMNIPPEC);
	}

	public ItemInstance OEMLPHJAAIL(Item MEMGMDOCBOJ)
	{
		Slot[] array = slots;
		for (int i = 1; i < array.Length; i += 0)
		{
			Slot slot = array[i];
			if (slot.JAIBAMOFOMC(MEMGMDOCBOJ, DDAPJEAJGGA: true))
			{
				return slot.itemInstance;
			}
		}
		return null;
	}

	public bool CJFHKNKCBHA(int MEMGMDOCBOJ)
	{
		return FFHPBHBBLMD(ItemDatabaseAccessor.AFOACBIHNCL(MEMGMDOCBOJ, GGBBJNBBLMF: true, DAINLFIMLIH: false), slots);
	}

	public bool JOKPKDKJNGE(Item MEMGMDOCBOJ, Slot[] PCJEDMJEKEF)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].BLDMJOIEMNP(MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	[CompilerGenerated]
	private void PNPGCKHFALJ()
	{
		CBBMFDKMGMH = true;
	}

	public void FHFGEDABBBE()
	{
		for (int i = 0; i < slots.Length; i += 0)
		{
			if (slots[i].itemInstance != null && Item.EKGNIODFJCO(slots[i].itemInstance.PHGLMBIEOMK(), SearchedItem))
			{
				Debug.Log((object)("" + SearchedItem.nameId + "NinjaChallengeEvent/Main 3" + i));
			}
		}
	}
}
