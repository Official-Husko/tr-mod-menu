using System;
using System.Collections.Generic;
using UnityEngine;

public class CraftingInventory : MonoBehaviour, ISingleton
{
	private static CraftingInventory GGFJGHHHEJC;

	private HashSet<ItemContainer> DDOMGCBEFOK = new HashSet<ItemContainer>();

	private static Slot KCJBFOAAFLK;

	public static Action OnChanged = delegate
	{
	};

	private static TavernZone HEDBALNLGML;

	public static Slot GetSlotWithItem(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		KCJBFOAAFLK = PlayerInventory.GetPlayer(JIIGOACEIKL).GetSlotWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (!AKNBKINJGCF || MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME))
			{
				KCJBFOAAFLK = item.GetSlotWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
				if (KCJBFOAAFLK != null)
				{
					return KCJBFOAAFLK;
				}
			}
		}
		return null;
	}

	public static Slot FBOKJMJDFPM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool GLBECJCBBHF = false, Placeable FLAAGFECLME = null, bool HMPDLIPFBGD = false, bool CIGOMGBFJGF = true)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		if (DNLMCHDOMOK == null)
		{
			return null;
		}
		if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HJNJCAEECNP(DNLMCHDOMOK) && PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: false))
		{
			flag = false;
		}
		Slot slot = null;
		if (!flag)
		{
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if ((!GLBECJCBBHF || PHFEJKEAMHM(JIIGOACEIKL, item, FLAAGFECLME)) && item.IHCBHLAGOPH(DNLMCHDOMOK))
				{
					slot = item.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (!flag && PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false))
		{
			flag = false;
		}
		if (!flag)
		{
			foreach (ItemContainer item2 in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if (!GLBECJCBBHF || GGHANEBFFCO(JIIGOACEIKL, item2, FLAAGFECLME))
				{
					slot = item2.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag && HMPDLIPFBGD)
		{
			DroppedItem.JBIAHBPAFPI(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, DNLMCHDOMOK, 0, LHLJILLAHFO: true, HFAKAMFMOGM: true);
			flag = true;
		}
		if (flag && CIGOMGBFJGF)
		{
			ItemsCollectedUI.GLLBFKGDNFH(JIIGOACEIKL, DNLMCHDOMOK);
		}
		return slot;
	}

	public static int JIECOEDLHEC(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		List<Slot> slotsWithItem = GetSlotsWithItem(JIIGOACEIKL, MEMGMDOCBOJ, CKKNBMBLGPO, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA);
		int num = 0;
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.EOCHAGBPHCC().BKKPPECPILM(MEMGMDOCBOJ, DDAPJEAJGGA);
		}
		for (int i = 0; i < slotsWithItem.Count; i += 0)
		{
			num += slotsWithItem[i].Stack;
		}
		return num;
	}

	public static void MHKLPCCDCJD(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < MGNOBNCMDJG; i += 0)
		{
			bool flag = false;
			Slot slot = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC: true);
			if (slot != null)
			{
				flag = false;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC: true);
				if (slot != null)
				{
					flag = false;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 0)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray());
			}
		}
	}

	private static bool MFPJBFKKGNC(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != ZoneType.WithoutZone)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.EAPCLAODGAE.currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == Location.BarnInterior && HCBMNONKPML.EAPCLAODGAE.currentLocation == Location.BarnInterior)
			{
				return true;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.EAPCLAODGAE.attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.GetCentralAreaSpace(GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL) : GameCraftingUI.GetCentralAreaSpace(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.HasThisPlaceableInArea(HCBMNONKPML.EAPCLAODGAE);
			}
		}
		return false;
	}

	public static int AELILCDEMPJ(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		int num = 0;
		for (int i = 1; i < PHNKKAHPIAO.Count; i++)
		{
			num += NNIPPDCKOEB(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM, DDAPJEAJGGA);
		}
		return num;
	}

	public static int KCCBHHEGEHG(int JIIGOACEIKL, Item MEMGMDOCBOJ, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false)
	{
		int num = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).KIHAKOFNNPI(MEMGMDOCBOJ);
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((!AKNBKINJGCF || JEKIGPHNFJA(JIIGOACEIKL, item, FLAAGFECLME)) && item.OGENLMLPNAF().TryGetValue(MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false), out var value))
			{
				num += value.amount;
			}
		}
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.IOGANKJOLLB().GetNumberOfItem(MEMGMDOCBOJ, DDAPJEAJGGA: true);
		}
		return num;
	}

	public static bool EPIALAKOHJD(ItemContainer KGNFAONKLDG)
	{
		return GGFJGHHHEJC.DDOMGCBEFOK.Contains(KGNFAONKLDG);
	}

	public static Slot RemoveItemInstance(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, Placeable FLAAGFECLME, bool CDPAMNIPPEC = true)
	{
		Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			OnChanged();
			return slot;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME))
			{
				slot = item.RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC);
				if (slot != null)
				{
					OnChanged();
					return slot;
				}
			}
		}
		return null;
	}

	public static int EGPLEPOKCLO(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		int num = 0;
		for (int i = 1; i < PHNKKAHPIAO.Count; i++)
		{
			num += JIECOEDLHEC(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM, DDAPJEAJGGA);
		}
		return num;
	}

	public List<Slot> ILOHDFGHKKA(int JIIGOACEIKL, List<Item> PHNKKAHPIAO, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < PHNKKAHPIAO.Count; i += 0)
		{
			list.AddRange(INLEBGJNNIB(JIIGOACEIKL, PHNKKAHPIAO[i], CKKNBMBLGPO, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA: true));
		}
		return list;
	}

	public static List<Slot> GetSlotsWithItems(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, Item GFABGJEHHME, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < PHNKKAHPIAO.Count; i++)
		{
			if (Item.MLBOMGHINCA(GFABGJEHHME, null))
			{
				list.AddRange(GetSlotsWithItem(JIIGOACEIKL, PHNKKAHPIAO[i].item, GFABGJEHHME, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
			else
			{
				list.AddRange(GetSlotsWithItem(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
		}
		return list;
	}

	public static bool PAJKJOOEJLA(ItemContainer KGNFAONKLDG)
	{
		return GGFJGHHHEJC.DDOMGCBEFOK.Contains(KGNFAONKLDG);
	}

	public static bool HNONDKKLHBJ(ItemContainer KGNFAONKLDG)
	{
		return GGFJGHHHEJC.DDOMGCBEFOK.Contains(KGNFAONKLDG);
	}

	public static void CFHFICPJCKK(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < MGNOBNCMDJG; i += 0)
		{
			bool flag = false;
			Slot slot = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC: false);
			if (slot != null)
			{
				flag = true;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.IPIPFAKJPFN(BGNEBEPNMPB, CDPAMNIPPEC: true);
				if (slot != null)
				{
					flag = false;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 1)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.SendSlots(list.ToArray(), 1);
			}
		}
	}

	private static void KBDBOKCIAKC(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<Item> AAHCDDHIBFH)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)PCJEDMJEKEF[i].itemInstance?.LHBPOPOIFLE()) && (AAHCDDHIBFH == null || AAHCDDHIBFH.Contains(PCJEDMJEKEF[i].itemInstance?.PHGLMBIEOMK())))
			{
				OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
			}
		}
	}

	private void JBMFHIDFLGN()
	{
		OnChanged();
	}

	public static void OGNNFEIFALF(ItemContainer KGNFAONKLDG)
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Add(KGNFAONKLDG);
	}

	private static void OPPNAEMIBOF(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<IngredientType> NHJOOAMMPAO, RecipeIngredient[] LEICAADGFKK)
	{
		bool flag = true;
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (!(PCJEDMJEKEF[i].itemInstance?.PHGLMBIEOMK() is Food food))
			{
				continue;
			}
			for (int j = 0; j < NHJOOAMMPAO.Count; j++)
			{
				if (food.ingredientType != NHJOOAMMPAO[j])
				{
					continue;
				}
				flag = false;
				if (LEICAADGFKK != null)
				{
					for (int k = 1; k < LEICAADGFKK.Length; k++)
					{
						if (LEICAADGFKK[k].item.ODENMDOJPLC() == food.ODENMDOJPLC())
						{
							flag = false;
							break;
						}
					}
				}
				if (!flag)
				{
					OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
					break;
				}
			}
		}
	}

	public static Slot NGJBGHJFJMM(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, Placeable FLAAGFECLME, bool CDPAMNIPPEC = true)
	{
		Slot slot = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			OnChanged();
			return slot;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (EDCBJLDMKDC(JIIGOACEIKL, item, FLAAGFECLME))
			{
				slot = item.IPIPFAKJPFN(BGNEBEPNMPB, CDPAMNIPPEC);
				if (slot != null)
				{
					OnChanged();
					return slot;
				}
			}
		}
		return null;
	}

	public static List<Slot> HJOAPCDKOBD(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, Item GFABGJEHHME, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < PHNKKAHPIAO.Count; i++)
		{
			if (Item.MLBOMGHINCA(GFABGJEHHME, null))
			{
				list.AddRange(INLEBGJNNIB(JIIGOACEIKL, PHNKKAHPIAO[i].item, GFABGJEHHME, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
			else
			{
				list.AddRange(INLEBGJNNIB(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
		}
		return list;
	}

	public List<Slot> DEGJKEBPMEE(int JIIGOACEIKL, List<Item> PHNKKAHPIAO, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < PHNKKAHPIAO.Count; i++)
		{
			list.AddRange(INLEBGJNNIB(JIIGOACEIKL, PHNKKAHPIAO[i], CKKNBMBLGPO, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA: true));
		}
		return list;
	}

	public static bool HIIHADBIHOA(Item BGNEBEPNMPB, Placeable FLAAGFECLME = null)
	{
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (BPANOFDLOBE(1, item, FLAAGFECLME) && item.RemoveItem(BGNEBEPNMPB) != null)
			{
				OnChanged();
				return false;
			}
		}
		return true;
	}

	public static Slot LBIMPLILOJP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool GLBECJCBBHF = false, Placeable FLAAGFECLME = null, bool HMPDLIPFBGD = false, bool CIGOMGBFJGF = true)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (DNLMCHDOMOK == null)
		{
			return null;
		}
		if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(DNLMCHDOMOK) && PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false))
		{
			flag = false;
		}
		Slot slot = null;
		if (!flag)
		{
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if ((!GLBECJCBBHF || PHFEJKEAMHM(JIIGOACEIKL, item, FLAAGFECLME)) && item.FKJCJONKMGL(DNLMCHDOMOK))
				{
					slot = item.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (!flag && PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false))
		{
			flag = false;
		}
		if (!flag)
		{
			foreach (ItemContainer item2 in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if (!GLBECJCBBHF || MPPFPJLEFPG(JIIGOACEIKL, item2, FLAAGFECLME))
				{
					slot = item2.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (flag && HMPDLIPFBGD)
		{
			DroppedItem.KDBHKBOAEDG(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, DNLMCHDOMOK, 0, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
			flag = true;
		}
		if (flag && CIGOMGBFJGF)
		{
			ItemsCollectedUI.GCJGFICKJLC(JIIGOACEIKL, DNLMCHDOMOK);
		}
		return slot;
	}

	public static bool FLLDAMPLHKI(int JIIGOACEIKL, Item MEMGMDOCBOJ, Placeable FLAAGFECLME, bool LJPHECMPECH)
	{
		if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).CHOAPBFAAAM(MEMGMDOCBOJ))
		{
			return true;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((LJPHECMPECH || MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME)) && item.HasItem(MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public static int NAGIFDHFFIF(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		int num = 0;
		for (int i = 0; i < PHNKKAHPIAO.Count; i++)
		{
			num += JIECOEDLHEC(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM, DDAPJEAJGGA);
		}
		return num;
	}

	public void LDJKLBBBFLJ()
	{
		DDOMGCBEFOK = new HashSet<ItemContainer>();
		KCJBFOAAFLK = null;
		OnChanged = delegate
		{
		};
	}

	public static Slot BGNCPMONPGH(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool GLBECJCBBHF = false, Placeable FLAAGFECLME = null, bool HMPDLIPFBGD = false, bool CIGOMGBFJGF = true)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		if (DNLMCHDOMOK == null)
		{
			return null;
		}
		if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).GLLKALMBIDD(DNLMCHDOMOK) && PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(DNLMCHDOMOK, HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false))
		{
			flag = false;
		}
		Slot slot = null;
		if (!flag)
		{
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if ((!GLBECJCBBHF || GGHANEBFFCO(JIIGOACEIKL, item, FLAAGFECLME)) && item.IHCBHLAGOPH(DNLMCHDOMOK))
				{
					slot = item.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (!flag && PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false))
		{
			flag = false;
		}
		if (!flag)
		{
			foreach (ItemContainer item2 in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if (!GLBECJCBBHF || EDCBJLDMKDC(JIIGOACEIKL, item2, FLAAGFECLME))
				{
					slot = item2.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (!flag && HMPDLIPFBGD)
		{
			DroppedItem.OFHEKCFLEGB(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, DNLMCHDOMOK, 0, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
			flag = false;
		}
		if (flag && CIGOMGBFJGF)
		{
			ItemsCollectedUI.BABIDMDCDJB(JIIGOACEIKL, DNLMCHDOMOK);
		}
		return slot;
	}

	public static void PJFGODCLHOL()
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Clear();
	}

	public static void BPNOLJEEMMF(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i += 0)
		{
			bool flag = true;
			Slot slot = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC: true);
			if (slot != null)
			{
				flag = false;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.GENKBMODDFI(BGNEBEPNMPB);
				if (slot != null)
				{
					flag = true;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 0)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.MPMAHFAFGNL(list.ToArray());
			}
		}
	}

	private static bool GGHANEBFFCO(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != ZoneType.WithoutZone)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.EAPCLAODGAE.currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == ~(Location.Camp | Location.Farm | Location.BarnInterior) && HCBMNONKPML.ENLGJFFFOJN().currentLocation == ~(Location.Tavern | Location.Road | Location.Quarry))
			{
				return true;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.EAPCLAODGAE.attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.GetCentralAreaSpace(GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL()) : GameCraftingUI.OOJNDCKKMPO(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.MKNBIEBKNPO(HCBMNONKPML.LNOEOEGPCBD());
			}
		}
		return false;
	}

	public static int NNIPPDCKOEB(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		List<Slot> list = INLEBGJNNIB(JIIGOACEIKL, MEMGMDOCBOJ, CKKNBMBLGPO, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA);
		int num = 0;
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.LLJEGHHGOGC().BKKPPECPILM(MEMGMDOCBOJ, DDAPJEAJGGA);
		}
		for (int i = 1; i < list.Count; i += 0)
		{
			num += list[i].Stack;
		}
		return num;
	}

	public static Slot FPIMKGHFHJM(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool GLBECJCBBHF = false, Placeable FLAAGFECLME = null, bool HMPDLIPFBGD = false, bool CIGOMGBFJGF = true)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (DNLMCHDOMOK == null)
		{
			return null;
		}
		if (PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(DNLMCHDOMOK) && PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: false))
		{
			flag = false;
		}
		Slot slot = null;
		if (!flag)
		{
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if ((!GLBECJCBBHF || LGFCAPPPJLA(JIIGOACEIKL, item, FLAAGFECLME)) && item.IHCBHLAGOPH(DNLMCHDOMOK))
				{
					slot = item.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: true, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag && PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false))
		{
			flag = true;
		}
		if (!flag)
		{
			foreach (ItemContainer item2 in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if (!GLBECJCBBHF || BPANOFDLOBE(JIIGOACEIKL, item2, FLAAGFECLME))
				{
					slot = item2.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: true);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (flag && HMPDLIPFBGD)
		{
			DroppedItem.MDJFFOHFGNG(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, DNLMCHDOMOK, 0);
			flag = false;
		}
		if (flag && CIGOMGBFJGF)
		{
			ItemsCollectedUI.GLLBFKGDNFH(JIIGOACEIKL, DNLMCHDOMOK);
		}
		return slot;
	}

	public static bool RemoveItemFromAllContainers(Item BGNEBEPNMPB, Placeable FLAAGFECLME = null)
	{
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (MFPJBFKKGNC(1, item, FLAAGFECLME) && item.RemoveItem(BGNEBEPNMPB) != null)
			{
				OnChanged();
				return true;
			}
		}
		return false;
	}

	public static List<Slot> FNGNKIAPDFL(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, Item GFABGJEHHME, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < PHNKKAHPIAO.Count; i += 0)
		{
			if (Item.FKLOBGBIHLB(GFABGJEHHME, null))
			{
				list.AddRange(INLEBGJNNIB(JIIGOACEIKL, PHNKKAHPIAO[i].item, GFABGJEHHME, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
			else
			{
				list.AddRange(GetSlotsWithItem(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
		}
		return list;
	}

	private static void JFGBCEDMEMB(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<Item> AAHCDDHIBFH)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)PCJEDMJEKEF[i].itemInstance?.LHBPOPOIFLE()) && (AAHCDDHIBFH == null || AAHCDDHIBFH.Contains(PCJEDMJEKEF[i].itemInstance?.AFOACBIHNCL())))
			{
				OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
			}
		}
	}

	public static Slot EKBDKPCHPKN(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		KCJBFOAAFLK = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).GetSlotWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (!AKNBKINJGCF || LGFCAPPPJLA(JIIGOACEIKL, item, FLAAGFECLME))
			{
				KCJBFOAAFLK = item.JJIPDJNHHHD(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
				if (KCJBFOAAFLK != null)
				{
					return KCJBFOAAFLK;
				}
			}
		}
		return null;
	}

	public static void NCGOKJLANCF()
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Clear();
	}

	public static void ClearItems()
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Clear();
	}

	public static bool IOPAKGHOPLC(Item BGNEBEPNMPB, Placeable FLAAGFECLME = null)
	{
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (JEKIGPHNFJA(0, item, FLAAGFECLME) && item.RemoveItem(BGNEBEPNMPB) != null)
			{
				OnChanged();
				return true;
			}
		}
		return false;
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public static List<Slot> CMFCHAHLMOC(int JIIGOACEIKL, List<IngredientType> NHJOOAMMPAO, Placeable FLAAGFECLME, RecipeIngredient[] LEICAADGFKK)
	{
		List<Slot> list = new List<Slot>();
		Slot[] pCJEDMJEKEF = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OMCMMDDGHFB();
		OPPNAEMIBOF(list, pCJEDMJEKEF, NHJOOAMMPAO, LEICAADGFKK);
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (HOEKENNNJEJ(JIIGOACEIKL, item, FLAAGFECLME))
			{
				NEICJPGGLJE(list, item.slots, NHJOOAMMPAO, LEICAADGFKK);
			}
		}
		return list;
	}

	private void BMENFEDNOGJ()
	{
		OnChanged();
	}

	public static void AJKEELDHGDD()
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Clear();
	}

	public static void APEOKJGBMGJ(ItemContainer KGNFAONKLDG)
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Remove(KGNFAONKLDG);
	}

	public static void LDEFFEBOKNL(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i += 0)
		{
			bool flag = false;
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC: true);
			if (slot != null)
			{
				flag = true;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.IPIPFAKJPFN(BGNEBEPNMPB, CDPAMNIPPEC: true);
				if (slot != null)
				{
					flag = false;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 0)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray());
			}
		}
	}

	public static bool NFLMOKFHJHN(ItemContainer KGNFAONKLDG)
	{
		return GGFJGHHHEJC.DDOMGCBEFOK.Contains(KGNFAONKLDG);
	}

	public static void DMIECBFAGBB(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i += 0)
		{
			bool flag = false;
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).DEAFNEAFKBM(BGNEBEPNMPB, CDPAMNIPPEC: true);
			if (slot != null)
			{
				flag = true;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.IPIPFAKJPFN(BGNEBEPNMPB, CDPAMNIPPEC: true);
				if (slot != null)
				{
					flag = true;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 1)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray());
			}
		}
	}

	public static bool ContainsItem(ItemContainer KGNFAONKLDG)
	{
		return GGFJGHHHEJC.DDOMGCBEFOK.Contains(KGNFAONKLDG);
	}

	public static void AddItem(ItemContainer KGNFAONKLDG)
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Add(KGNFAONKLDG);
	}

	public static int NumberOfItems(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		int num = 0;
		for (int i = 0; i < PHNKKAHPIAO.Count; i++)
		{
			num += NumberOfItems(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM, DDAPJEAJGGA);
		}
		return num;
	}

	public static Slot AddItemInstance(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool GLBECJCBBHF = false, Placeable FLAAGFECLME = null, bool HMPDLIPFBGD = false, bool CIGOMGBFJGF = true)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (DNLMCHDOMOK == null)
		{
			return null;
		}
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(DNLMCHDOMOK) && PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false))
		{
			flag = true;
		}
		Slot slot = null;
		if (!flag)
		{
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if ((!GLBECJCBBHF || MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME)) && item.HasItem(DNLMCHDOMOK))
				{
					slot = item.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag && PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false))
		{
			flag = true;
		}
		if (!flag)
		{
			foreach (ItemContainer item2 in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if (!GLBECJCBBHF || MFPJBFKKGNC(JIIGOACEIKL, item2, FLAAGFECLME))
				{
					slot = item2.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag && HMPDLIPFBGD)
		{
			DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, DNLMCHDOMOK);
			flag = true;
		}
		if (flag && CIGOMGBFJGF)
		{
			ItemsCollectedUI.AddItemCollected(JIIGOACEIKL, DNLMCHDOMOK);
		}
		return slot;
	}

	public static Slot LKOAICOOLBI(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool GLBECJCBBHF = false, Placeable FLAAGFECLME = null, bool HMPDLIPFBGD = false, bool CIGOMGBFJGF = true)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		if (DNLMCHDOMOK == null)
		{
			return null;
		}
		if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).HasItem(DNLMCHDOMOK) && PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false))
		{
			flag = false;
		}
		Slot slot = null;
		if (!flag)
		{
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if ((!GLBECJCBBHF || OOCDOBDAPCG(JIIGOACEIKL, item, FLAAGFECLME)) && item.NFNBAIGCDGA(DNLMCHDOMOK))
				{
					slot = item.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag && PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).OJDGOADOCMG(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false))
		{
			flag = false;
		}
		if (!flag)
		{
			foreach (ItemContainer item2 in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if (!GLBECJCBBHF || HOEKENNNJEJ(JIIGOACEIKL, item2, FLAAGFECLME))
				{
					slot = item2.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK);
					if (slot != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (flag && HMPDLIPFBGD)
		{
			DroppedItem.HDLEEOJMILI(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, DNLMCHDOMOK, 1, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
			flag = true;
		}
		if (flag && CIGOMGBFJGF)
		{
			ItemsCollectedUI.AddItemCollected(JIIGOACEIKL, DNLMCHDOMOK);
		}
		return slot;
	}

	public static void RemoveItemInstances(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i++)
		{
			bool flag = false;
			Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC: false);
			if (slot != null)
			{
				flag = true;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.RemoveItemInstance(BGNEBEPNMPB);
				if (slot != null)
				{
					flag = true;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 0)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.SendSlots(list.ToArray());
			}
		}
	}

	private static void EAIMOABLLEO(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<Item> AAHCDDHIBFH)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)PCJEDMJEKEF[i].itemInstance?.AFOACBIHNCL()) && (AAHCDDHIBFH == null || AAHCDDHIBFH.Contains(PCJEDMJEKEF[i].itemInstance?.KNFNJFFCFNO())))
			{
				OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
			}
		}
	}

	public static List<Slot> GetSlotsWithItem(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		List<Slot> list = new List<Slot>(PlayerInventory.GetPlayer(JIIGOACEIKL).GetSlotsWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM));
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (!AKNBKINJGCF || MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME))
			{
				list.AddRange(item.GetSlotsWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM));
			}
		}
		return list;
	}

	public List<Slot> GetSlotsWithItems(int JIIGOACEIKL, List<Item> PHNKKAHPIAO, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < PHNKKAHPIAO.Count; i++)
		{
			list.AddRange(GetSlotsWithItem(JIIGOACEIKL, PHNKKAHPIAO[i], CKKNBMBLGPO, AKNBKINJGCF, FLAAGFECLME));
		}
		return list;
	}

	private static bool BPICPKOFFIC(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != 0)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.EAPCLAODGAE.currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == (Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.BarnInterior) && HCBMNONKPML.LNOEOEGPCBD().currentLocation == ~(Location.Tavern | Location.Road | Location.River | Location.Farm))
			{
				return true;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.ENLGJFFFOJN().attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.NLCEFNFJJIE(GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL()) : GameCraftingUI.NLCEFNFJJIE(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.JKNCLMPJCPN(HCBMNONKPML.LNOEOEGPCBD());
			}
		}
		return false;
	}

	public static Slot OICKBPJPKPG(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		KCJBFOAAFLK = PlayerInventory.GetPlayer(JIIGOACEIKL).GMBJNBOAJGL(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (!AKNBKINJGCF || JEKIGPHNFJA(JIIGOACEIKL, item, FLAAGFECLME))
			{
				KCJBFOAAFLK = item.JOFGEIJMCDM(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
				if (KCJBFOAAFLK != null)
				{
					return KCJBFOAAFLK;
				}
			}
		}
		return null;
	}

	public static Slot MKNHIDCOHKK(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		KCJBFOAAFLK = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GMBJNBOAJGL(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (!AKNBKINJGCF || GGHANEBFFCO(JIIGOACEIKL, item, FLAAGFECLME))
			{
				KCJBFOAAFLK = item.JOFGEIJMCDM(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
				if (KCJBFOAAFLK != null)
				{
					return KCJBFOAAFLK;
				}
			}
		}
		return null;
	}

	private void DGAMIDJNFDJ()
	{
		OnChanged();
	}

	public static bool HasItem(int JIIGOACEIKL, Item MEMGMDOCBOJ, Placeable FLAAGFECLME, bool LJPHECMPECH)
	{
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(MEMGMDOCBOJ))
		{
			return true;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((LJPHECMPECH || MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME)) && item.HasItem(MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public static void PANJKIHJNEO()
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Clear();
	}

	private static bool PHFEJKEAMHM(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != 0)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.LNOEOEGPCBD().currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == ~(Location.Camp | Location.Farm | Location.BarnInterior) && HCBMNONKPML.ENLGJFFFOJN().currentLocation == (Location.Tavern | Location.River | Location.Camp | Location.Quarry))
			{
				return false;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.ENLGJFFFOJN().attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.GetCentralAreaSpace(GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL()) : GameCraftingUI.OOJNDCKKMPO(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.MKNBIEBKNPO(HCBMNONKPML.EAPCLAODGAE);
			}
		}
		return true;
	}

	public static void JFBBLOHNIKI(ItemContainer KGNFAONKLDG)
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Remove(KGNFAONKLDG);
	}

	public static Slot MLAKGAJFEDC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool GLBECJCBBHF = false, Placeable FLAAGFECLME = null, bool HMPDLIPFBGD = false, bool CIGOMGBFJGF = true)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (DNLMCHDOMOK == null)
		{
			return null;
		}
		if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).HJNJCAEECNP(DNLMCHDOMOK) && PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false))
		{
			flag = false;
		}
		Slot slot = null;
		if (!flag)
		{
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if ((!GLBECJCBBHF || HOEKENNNJEJ(JIIGOACEIKL, item, FLAAGFECLME)) && item.HasItem(DNLMCHDOMOK))
				{
					slot = item.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: true, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (!flag && PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false))
		{
			flag = true;
		}
		if (!flag)
		{
			foreach (ItemContainer item2 in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if (!GLBECJCBBHF || JEKIGPHNFJA(JIIGOACEIKL, item2, FLAAGFECLME))
				{
					slot = item2.AKNJFODFCID(JIIGOACEIKL, DNLMCHDOMOK);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (!flag && HMPDLIPFBGD)
		{
			DroppedItem.HDLEEOJMILI(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, DNLMCHDOMOK, 1, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
			flag = false;
		}
		if (flag && CIGOMGBFJGF)
		{
			ItemsCollectedUI.AddItemCollected(JIIGOACEIKL, DNLMCHDOMOK);
		}
		return slot;
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)PlayerInventory.GetPlayer(1)))
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(BMENFEDNOGJ));
		}
		if (Object.op_Implicit((Object)(object)PlayerInventory.GetPlayer(2)))
		{
			PlayerInventory player2 = PlayerInventory.GetPlayer(2);
			player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(BMENFEDNOGJ));
		}
		GGFJGHHHEJC = null;
	}

	public static int ODIEJJCDBLM(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		int num = 1;
		for (int i = 0; i < PHNKKAHPIAO.Count; i++)
		{
			num += NNIPPDCKOEB(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM, DDAPJEAJGGA);
		}
		return num;
	}

	public static int NumberOfItems(int JIIGOACEIKL, Item MEMGMDOCBOJ, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false)
	{
		int num = PlayerInventory.GetPlayer(JIIGOACEIKL).NumberOfItems(MEMGMDOCBOJ);
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((!AKNBKINJGCF || MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME)) && item.GetAllItems().TryGetValue(MEMGMDOCBOJ.JDJGFAACPFC(), out var value))
			{
				num += value.amount;
			}
		}
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.GetInstance().GetNumberOfItem(MEMGMDOCBOJ);
		}
		return num;
	}

	public static void RemoveItem(ItemContainer KGNFAONKLDG)
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Remove(KGNFAONKLDG);
	}

	public static bool PBPIFALOEBH(ItemContainer KGNFAONKLDG)
	{
		return GGFJGHHHEJC.DDOMGCBEFOK.Contains(KGNFAONKLDG);
	}

	public static int LPEGAFPFKLH(int JIIGOACEIKL, Item MEMGMDOCBOJ, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false)
	{
		int num = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KIHAKOFNNPI(MEMGMDOCBOJ);
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((!AKNBKINJGCF || HOEKENNNJEJ(JIIGOACEIKL, item, FLAAGFECLME)) && item.IGHLECJCPLG().TryGetValue(MEMGMDOCBOJ.IMCJPECAAPC(), out var value))
			{
				num += value.amount;
			}
		}
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.FFOMKKIAHKI().BKKPPECPILM(MEMGMDOCBOJ);
		}
		return num;
	}

	private static bool JEKIGPHNFJA(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != 0)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.EAPCLAODGAE.currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == Location.Quarry && HCBMNONKPML.ENLGJFFFOJN().currentLocation == Location.River)
			{
				return true;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.LNOEOEGPCBD().attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.OOJNDCKKMPO(GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL) : GameCraftingUI.NLCEFNFJJIE(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.GGBDNJOPFDE(HCBMNONKPML.EAPCLAODGAE);
			}
		}
		return true;
	}

	private void JPOLFKMLHNH()
	{
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(DGAMIDJNFDJ));
		PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(DGAMIDJNFDJ));
	}

	public static bool JKLEPGLMCEG(int JIIGOACEIKL, Item MEMGMDOCBOJ, Placeable FLAAGFECLME, bool LJPHECMPECH)
	{
		if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).HasItem(MEMGMDOCBOJ))
		{
			return true;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((LJPHECMPECH || BPICPKOFFIC(JIIGOACEIKL, item, FLAAGFECLME)) && item.HasItem(MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	public static void NCMJDCGLOII()
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Clear();
	}

	private static bool MPPFPJLEFPG(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != ZoneType.WithoutZone)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.LNOEOEGPCBD().currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == ~(Location.Road | Location.Camp | Location.Farm) && HCBMNONKPML.ENLGJFFFOJN().currentLocation == ~Location.Tavern)
			{
				return true;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.ENLGJFFFOJN().attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.GetCentralAreaSpace(GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL()) : GameCraftingUI.OOJNDCKKMPO(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.AJBDGPHMNNB(HCBMNONKPML.EAPCLAODGAE);
			}
		}
		return false;
	}

	public static int NumberOfItemsAllPlayers(Item MEMGMDOCBOJ, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false)
	{
		int num = PlayerInventory.GetPlayer(1).NumberOfItems(MEMGMDOCBOJ);
		if (OnlineManager.MasterOrOffline())
		{
			num += PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).NumberOfItems(MEMGMDOCBOJ);
			for (int i = 2; i <= 4; i++)
			{
				num += PlayerInventory.GetPlayer(i, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(MEMGMDOCBOJ);
			}
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((!AKNBKINJGCF || MFPJBFKKGNC(1, item, FLAAGFECLME)) && item.GetAllItems().TryGetValue(MEMGMDOCBOJ.JDJGFAACPFC(), out var value))
			{
				num += value.amount;
			}
		}
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.GetInstance().GetNumberOfItem(MEMGMDOCBOJ);
		}
		return num;
	}

	private static void HNLPBBHIBAD(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<Item> AAHCDDHIBFH)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)PCJEDMJEKEF[i].itemInstance?.LHBPOPOIFLE()) && (AAHCDDHIBFH == null || AAHCDDHIBFH.Contains(PCJEDMJEKEF[i].itemInstance?.LHBPOPOIFLE())))
			{
				OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
			}
		}
	}

	public static List<Slot> KOCJBDLAIGE(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, Item GFABGJEHHME, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < PHNKKAHPIAO.Count; i++)
		{
			if (Item.FKLOBGBIHLB(GFABGJEHHME, null))
			{
				list.AddRange(INLEBGJNNIB(JIIGOACEIKL, PHNKKAHPIAO[i].item, GFABGJEHHME, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
			else
			{
				list.AddRange(GetSlotsWithItem(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
		}
		return list;
	}

	public static Slot LHFCGOEMMHC(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK, bool GLBECJCBBHF = false, Placeable FLAAGFECLME = null, bool HMPDLIPFBGD = false, bool CIGOMGBFJGF = true)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		if (DNLMCHDOMOK == null)
		{
			return null;
		}
		if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HJNJCAEECNP(DNLMCHDOMOK) && PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false))
		{
			flag = false;
		}
		Slot slot = null;
		if (!flag)
		{
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if ((!GLBECJCBBHF || BPICPKOFFIC(JIIGOACEIKL, item, FLAAGFECLME)) && item.NFNBAIGCDGA(DNLMCHDOMOK))
				{
					slot = item.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = false;
						break;
					}
				}
			}
		}
		if (!flag && PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(DNLMCHDOMOK, HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false))
		{
			flag = true;
		}
		if (!flag)
		{
			foreach (ItemContainer item2 in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				if (!GLBECJCBBHF || MPPFPJLEFPG(JIIGOACEIKL, item2, FLAAGFECLME))
				{
					slot = item2.AddItemInstance(JIIGOACEIKL, DNLMCHDOMOK, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
					if (slot != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag && HMPDLIPFBGD)
		{
			DroppedItem.SpawnDroppedItem(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, DNLMCHDOMOK, 0);
			flag = false;
		}
		if (flag && CIGOMGBFJGF)
		{
			ItemsCollectedUI.AddItemCollected(JIIGOACEIKL, DNLMCHDOMOK);
		}
		return slot;
	}

	public static void DBJIJNAPCPH(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i += 0)
		{
			bool flag = false;
			Slot slot = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JCBCAAMBINH(BGNEBEPNMPB, CDPAMNIPPEC: true);
			if (slot != null)
			{
				flag = true;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.RemoveItemInstance(BGNEBEPNMPB);
				if (slot != null)
				{
					flag = false;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 1)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.SendSlots(list.ToArray());
			}
		}
	}

	private static void NEICJPGGLJE(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<IngredientType> NHJOOAMMPAO, RecipeIngredient[] LEICAADGFKK)
	{
		bool flag = false;
		for (int i = 1; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (!(PCJEDMJEKEF[i].itemInstance?.LHBPOPOIFLE() is Food food))
			{
				continue;
			}
			for (int j = 0; j < NHJOOAMMPAO.Count; j += 0)
			{
				if (food.ingredientType != NHJOOAMMPAO[j])
				{
					continue;
				}
				flag = true;
				if (LEICAADGFKK != null)
				{
					for (int k = 1; k < LEICAADGFKK.Length; k++)
					{
						if (LEICAADGFKK[k].item.IMCJPECAAPC(DAINLFIMLIH: false) == food.JPNFKDMFKMC(DAINLFIMLIH: false))
						{
							flag = false;
							break;
						}
					}
				}
				if (!flag)
				{
					OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
					break;
				}
			}
		}
	}

	public static Slot CKHLHBJDEOH(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, Placeable FLAAGFECLME, bool CDPAMNIPPEC = true)
	{
		Slot slot = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).DEAFNEAFKBM(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			OnChanged();
			return slot;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (PHFEJKEAMHM(JIIGOACEIKL, item, FLAAGFECLME))
			{
				slot = item.GENKBMODDFI(BGNEBEPNMPB, CDPAMNIPPEC);
				if (slot != null)
				{
					OnChanged();
					return slot;
				}
			}
		}
		return null;
	}

	public List<Slot> NFNIMKBBFOH(int JIIGOACEIKL, List<Item> PHNKKAHPIAO, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < PHNKKAHPIAO.Count; i += 0)
		{
			list.AddRange(GetSlotsWithItem(JIIGOACEIKL, PHNKKAHPIAO[i], CKKNBMBLGPO, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA: true));
		}
		return list;
	}

	private static bool OOCDOBDAPCG(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != ZoneType.WithoutZone)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.ENLGJFFFOJN().currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == ~(Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) && HCBMNONKPML.EAPCLAODGAE.currentLocation == (Location.Tavern | Location.Road | Location.River | Location.Farm))
			{
				return false;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.LNOEOEGPCBD().attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.NLCEFNFJJIE(GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL()) : GameCraftingUI.OOJNDCKKMPO(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.GGBDNJOPFDE(HCBMNONKPML.EAPCLAODGAE);
			}
		}
		return false;
	}

	public static bool GFPNDAGAHKB(int JIIGOACEIKL, Item MEMGMDOCBOJ, Placeable FLAAGFECLME, bool LJPHECMPECH)
	{
		if (DeliveryChest.HPCJAODINCN().HMIDIPBNEGC(MEMGMDOCBOJ))
		{
			return false;
		}
		if (Bin.instance.HasItem(MEMGMDOCBOJ))
		{
			return true;
		}
		if (FLLDAMPLHKI(JIIGOACEIKL, MEMGMDOCBOJ, FLAAGFECLME, LJPHECMPECH))
		{
			return false;
		}
		return true;
	}

	public static void BCJLLNIBKNN(ItemContainer KGNFAONKLDG)
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Add(KGNFAONKLDG);
	}

	public static List<Slot> INLEBGJNNIB(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		List<Slot> list = new List<Slot>(PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AJCLODBGGHA(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM));
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (!AKNBKINJGCF || MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME))
			{
				list.AddRange(item.MAPOLJMKGLN(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM));
			}
		}
		return list;
	}

	public static int HAGHJELAEMM(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		List<Slot> slotsWithItem = GetSlotsWithItem(JIIGOACEIKL, MEMGMDOCBOJ, CKKNBMBLGPO, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA);
		int num = 1;
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.HPCJAODINCN().BKKPPECPILM(MEMGMDOCBOJ, DDAPJEAJGGA);
		}
		for (int i = 0; i < slotsWithItem.Count; i += 0)
		{
			num += slotsWithItem[i].Stack;
		}
		return num;
	}

	public static void MMHAKIKCJCP()
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Clear();
	}

	public static int LEMBKIDEHPM(int JIIGOACEIKL, Item MEMGMDOCBOJ, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false)
	{
		int num = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).DEGAJPFIJDD(MEMGMDOCBOJ);
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((!AKNBKINJGCF || PHFEJKEAMHM(JIIGOACEIKL, item, FLAAGFECLME)) && item.GKGPBIEBFKL().TryGetValue(MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false), out var value))
			{
				num += value.amount;
			}
		}
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.OCFJOKBKFIF().FHBBFGCLEPE(MEMGMDOCBOJ);
		}
		return num;
	}

	public static int ICCOLMNMGJJ(int JIIGOACEIKL, Item MEMGMDOCBOJ, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false)
	{
		int num = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).NAENGEHEGHP(MEMGMDOCBOJ);
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if ((!AKNBKINJGCF || BPANOFDLOBE(JIIGOACEIKL, item, FLAAGFECLME)) && item.NCILNCAACAN().TryGetValue(MEMGMDOCBOJ.JPNFKDMFKMC(), out var value))
			{
				num += value.amount;
			}
		}
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.KOJHKCGIINL().GetNumberOfItem(MEMGMDOCBOJ, DDAPJEAJGGA: true);
		}
		return num;
	}

	private static void BJEKFOJJALL(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<IngredientType> NHJOOAMMPAO, RecipeIngredient[] LEICAADGFKK)
	{
		bool flag = true;
		for (int i = 1; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (!(PCJEDMJEKEF[i].itemInstance?.AFOACBIHNCL() is Food food))
			{
				continue;
			}
			for (int j = 1; j < NHJOOAMMPAO.Count; j++)
			{
				if (food.ingredientType != NHJOOAMMPAO[j])
				{
					continue;
				}
				flag = false;
				if (LEICAADGFKK != null)
				{
					for (int k = 0; k < LEICAADGFKK.Length; k++)
					{
						if (LEICAADGFKK[k].item.ODENMDOJPLC(DAINLFIMLIH: false) == food.CIGFGKKCPCK())
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
					break;
				}
			}
		}
	}

	public static bool CCPJDNGGCOF(ItemContainer KGNFAONKLDG)
	{
		return GGFJGHHHEJC.DDOMGCBEFOK.Contains(KGNFAONKLDG);
	}

	public static void RemoveItemInstances(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, Placeable FLAAGFECLME, int FGFCNKFEIGF, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < FGFCNKFEIGF; i++)
		{
			Slot slot = RemoveItemInstance(JIIGOACEIKL, BGNEBEPNMPB, FLAAGFECLME, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
	}

	private static bool EDCBJLDMKDC(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != 0)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.EAPCLAODGAE.currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == (Location.Road | Location.Farm | Location.BarnInterior) && HCBMNONKPML.ENLGJFFFOJN().currentLocation == (Location.Road | Location.Farm | Location.BarnInterior))
			{
				return false;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.LNOEOEGPCBD().attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.GetCentralAreaSpace(GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL()) : GameCraftingUI.NLCEFNFJJIE(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.CENFPFAGBFD(HCBMNONKPML.EAPCLAODGAE);
			}
		}
		return true;
	}

	public static void NBGMKMNIDIE(ItemContainer KGNFAONKLDG)
	{
		GGFJGHHHEJC.DDOMGCBEFOK.Remove(KGNFAONKLDG);
	}

	public static void LJMOCMBBNHN(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, Placeable FLAAGFECLME, int FGFCNKFEIGF, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < FGFCNKFEIGF; i += 0)
		{
			Slot slot = NGJBGHJFJMM(JIIGOACEIKL, BGNEBEPNMPB, FLAAGFECLME);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray());
		}
	}

	public static int GDNCBCMHHKB(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		int num = 0;
		for (int i = 0; i < PHNKKAHPIAO.Count; i += 0)
		{
			num += NumberOfItems(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, AHCENOLCIBM, DDAPJEAJGGA);
		}
		return num;
	}

	public static void MOFCLPBOKJF(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < MGNOBNCMDJG; i += 0)
		{
			bool flag = true;
			Slot slot = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DEAFNEAFKBM(BGNEBEPNMPB, CDPAMNIPPEC: false);
			if (slot != null)
			{
				flag = false;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.IPIPFAKJPFN(BGNEBEPNMPB);
				if (slot != null)
				{
					flag = false;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 1)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray());
			}
		}
	}

	private static bool LGFCAPPPJLA(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != 0)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.EAPCLAODGAE.currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry) && HCBMNONKPML.EAPCLAODGAE.currentLocation == Location.BarnInterior)
			{
				return false;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.LNOEOEGPCBD().attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.OOJNDCKKMPO(GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL) : GameCraftingUI.NLCEFNFJJIE(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.MKNBIEBKNPO(HCBMNONKPML.ENLGJFFFOJN());
			}
		}
		return false;
	}

	public static Slot OBAGDPEAAEI(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		KCJBFOAAFLK = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (!AKNBKINJGCF || MPPFPJLEFPG(JIIGOACEIKL, item, FLAAGFECLME))
			{
				KCJBFOAAFLK = item.GetSlotWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
				if (KCJBFOAAFLK != null)
				{
					return KCJBFOAAFLK;
				}
			}
		}
		return null;
	}

	private static bool BPANOFDLOBE(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != 0)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.ENLGJFFFOJN().currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == (Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) && HCBMNONKPML.ENLGJFFFOJN().currentLocation == ~(Location.Road | Location.River | Location.Quarry))
			{
				return true;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.EAPCLAODGAE.attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.GetCentralAreaSpace(GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL) : GameCraftingUI.GetCentralAreaSpace(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.CENFPFAGBFD(HCBMNONKPML.EAPCLAODGAE);
			}
		}
		return true;
	}

	private static bool HOEKENNNJEJ(int JIIGOACEIKL, ItemContainer HCBMNONKPML, Placeable FLAAGFECLME)
	{
		if ((Object)(object)FLAAGFECLME != (Object)null)
		{
			if (FLAAGFECLME.currentZoneType != 0 && FLAAGFECLME.currentZoneType != ZoneType.WithoutZone)
			{
				HEDBALNLGML = FLAAGFECLME.GetCurrentTavernZone();
				if (HEDBALNLGML != null)
				{
					return HCBMNONKPML.ENLGJFFFOJN().currentZoneIndex == FLAAGFECLME.GetCurrentTavernZone().id;
				}
			}
			if (FLAAGFECLME.currentLocation == ~(Location.Tavern | Location.Road | Location.Camp | Location.BarnInterior) && HCBMNONKPML.EAPCLAODGAE.currentLocation == (Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.BarnInterior))
			{
				return true;
			}
		}
		if (Object.op_Implicit((Object)(object)HCBMNONKPML.LNOEOEGPCBD().attachedToPlaceable))
		{
			Crafter component = ((Component)FLAAGFECLME).GetComponent<Crafter>();
			AreaSpace areaSpace = ((!((Object)(object)component != (Object)null)) ? GameCraftingUI.OOJNDCKKMPO(GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL()) : GameCraftingUI.OOJNDCKKMPO(component));
			if (Object.op_Implicit((Object)(object)areaSpace))
			{
				return areaSpace.AJBDGPHMNNB(HCBMNONKPML.EAPCLAODGAE);
			}
		}
		return false;
	}

	public static List<Slot> GetSlotsOfSpecificIngredientTypes(int JIIGOACEIKL, List<IngredientType> NHJOOAMMPAO, Placeable FLAAGFECLME, RecipeIngredient[] LEICAADGFKK)
	{
		List<Slot> list = new List<Slot>();
		Slot[] allSlots = PlayerInventory.GetPlayer(JIIGOACEIKL).GetAllSlots();
		PANDKHDAHHH(list, allSlots, NHJOOAMMPAO, LEICAADGFKK);
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (MFPJBFKKGNC(JIIGOACEIKL, item, FLAAGFECLME))
			{
				PANDKHDAHHH(list, item.slots, NHJOOAMMPAO, LEICAADGFKK);
			}
		}
		return list;
	}

	public static Slot GJPIKCMIKJN(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, Placeable FLAAGFECLME, bool CDPAMNIPPEC = true)
	{
		Slot slot = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).DEAFNEAFKBM(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			OnChanged();
			return slot;
		}
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			if (BPANOFDLOBE(JIIGOACEIKL, item, FLAAGFECLME))
			{
				slot = item.IPIPFAKJPFN(BGNEBEPNMPB, CDPAMNIPPEC);
				if (slot != null)
				{
					OnChanged();
					return slot;
				}
			}
		}
		return null;
	}

	private static void DABFGKAEFFC(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<Item> AAHCDDHIBFH)
	{
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)PCJEDMJEKEF[i].itemInstance?.LHBPOPOIFLE()) && (AAHCDDHIBFH == null || AAHCDDHIBFH.Contains(PCJEDMJEKEF[i].itemInstance?.LHBPOPOIFLE())))
			{
				OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
			}
		}
	}

	public static void PFOLOLPOKEM(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, Placeable FLAAGFECLME, int FGFCNKFEIGF, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < FGFCNKFEIGF; i++)
		{
			Slot slot = GJPIKCMIKJN(JIIGOACEIKL, BGNEBEPNMPB, FLAAGFECLME, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray(), 1);
		}
	}

	private void Start()
	{
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(BMENFEDNOGJ));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(BMENFEDNOGJ));
	}

	private void NDNBDEHFFJF()
	{
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(JBMFHIDFLGN));
		PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(2, LAGHIOKLJGH: true);
		playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(JBMFHIDFLGN));
	}

	public static int NumberOfItems(int JIIGOACEIKL, Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool AKNBKINJGCF = false, Placeable FLAAGFECLME = null, bool AHCENOLCIBM = false, bool DDAPJEAJGGA = false)
	{
		List<Slot> slotsWithItem = GetSlotsWithItem(JIIGOACEIKL, MEMGMDOCBOJ, CKKNBMBLGPO, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA);
		int num = 0;
		if (AHCENOLCIBM)
		{
			num += BarMenuInventory.GetInstance().GetNumberOfItem(MEMGMDOCBOJ, DDAPJEAJGGA);
		}
		for (int i = 0; i < slotsWithItem.Count; i++)
		{
			num += slotsWithItem[i].Stack;
		}
		return num;
	}

	private static void PANDKHDAHHH(List<Slot> OOIFFJLMBKI, Slot[] PCJEDMJEKEF, List<IngredientType> NHJOOAMMPAO, RecipeIngredient[] LEICAADGFKK)
	{
		bool flag = false;
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (!(PCJEDMJEKEF[i].itemInstance?.LHBPOPOIFLE() is Food food))
			{
				continue;
			}
			for (int j = 0; j < NHJOOAMMPAO.Count; j++)
			{
				if (food.ingredientType != NHJOOAMMPAO[j])
				{
					continue;
				}
				flag = false;
				if (LEICAADGFKK != null)
				{
					for (int k = 0; k < LEICAADGFKK.Length; k++)
					{
						if (LEICAADGFKK[k].item.JDJGFAACPFC() == food.JDJGFAACPFC())
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					OOIFFJLMBKI.Add(PCJEDMJEKEF[i]);
					break;
				}
			}
		}
	}

	public static void LBFFLDBNGDC(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, int MGNOBNCMDJG, bool CDPAMNIPPEC)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 1; i < MGNOBNCMDJG; i++)
		{
			bool flag = false;
			Slot slot = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).DEAFNEAFKBM(BGNEBEPNMPB, CDPAMNIPPEC: false);
			if (slot != null)
			{
				flag = false;
				list.Add(slot);
				continue;
			}
			foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
			{
				slot = item.RemoveItemInstance(BGNEBEPNMPB);
				if (slot != null)
				{
					flag = true;
					list.Add(slot);
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		if (list.Count > 1)
		{
			OnChanged();
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray());
			}
		}
	}

	public static List<Slot> ILLBNFDODMK(int JIIGOACEIKL, List<ItemMod> PHNKKAHPIAO, Item GFABGJEHHME, bool AKNBKINJGCF, Placeable FLAAGFECLME, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < PHNKKAHPIAO.Count; i += 0)
		{
			if (Item.MLBOMGHINCA(GFABGJEHHME, null))
			{
				list.AddRange(INLEBGJNNIB(JIIGOACEIKL, PHNKKAHPIAO[i].item, GFABGJEHHME, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
			else
			{
				list.AddRange(GetSlotsWithItem(JIIGOACEIKL, PHNKKAHPIAO[i].item, PHNKKAHPIAO[i].mod, AKNBKINJGCF, FLAAGFECLME, DDAPJEAJGGA, DBMFHFNKMOM));
			}
		}
		return list;
	}

	public void ResetSingleton()
	{
		DDOMGCBEFOK = new HashSet<ItemContainer>();
		KCJBFOAAFLK = null;
		OnChanged = delegate
		{
		};
	}

	public static bool HasItemInAnySlot(int JIIGOACEIKL, Item MEMGMDOCBOJ, Placeable FLAAGFECLME, bool LJPHECMPECH)
	{
		if (DeliveryChest.GetInstance().HasItem(MEMGMDOCBOJ))
		{
			return true;
		}
		if (Bin.instance.HasItem(MEMGMDOCBOJ))
		{
			return true;
		}
		if (HasItem(JIIGOACEIKL, MEMGMDOCBOJ, FLAAGFECLME, LJPHECMPECH))
		{
			return true;
		}
		return false;
	}

	public static List<Slot> GetAllSlots(int JIIGOACEIKL, List<Item> AAHCDDHIBFH = null)
	{
		List<Slot> list = new List<Slot>();
		HNLPBBHIBAD(list, PlayerInventory.GetPlayer(JIIGOACEIKL).GetAllSlots(), AAHCDDHIBFH);
		foreach (ItemContainer item in GGFJGHHHEJC.DDOMGCBEFOK)
		{
			HNLPBBHIBAD(list, item.slots, AAHCDDHIBFH);
		}
		return list;
	}

	public static void GCOIMIAMJMH(int JIIGOACEIKL, ItemInstance BGNEBEPNMPB, Placeable FLAAGFECLME, int FGFCNKFEIGF, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		for (int i = 0; i < FGFCNKFEIGF; i += 0)
		{
			Slot slot = NGJBGHJFJMM(JIIGOACEIKL, BGNEBEPNMPB, FLAAGFECLME, CDPAMNIPPEC: false);
			if (slot != null && !list.Contains(slot))
			{
				list.Add(slot);
			}
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray(), 1);
		}
	}
}
