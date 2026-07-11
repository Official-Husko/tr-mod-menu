using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
	private static PlayerInventory GGFJGHHHEJC;

	private static PlayerInventory CNKLEOKFFLB;

	private static PlayerInventory[] BFMGIFGHMCL = new PlayerInventory[5];

	public Action OnChanged = delegate
	{
	};

	private bool KMCKIPJMEAI;

	private Dictionary<int, ItemAmount> PELCFIGNFPC;

	private Slot[] HOAIHLBLPLJ;

	public Slot mouseSlot;

	public bool playerOnline;

	public int playerNum = 1;

	public Inventory inventory;

	public ActionBarInventory actionBarInventory;

	private static Slot KCJBFOAAFLK;

	private static List<Slot> BBGEPJBEBIE;

	private void OnDisable()
	{
		if ((Object)(object)actionBarInventory != (Object)null)
		{
			ActionBarInventory obj = actionBarInventory;
			obj.OnContainerChanged = (Action)Delegate.Remove(obj.OnContainerChanged, new Action(PNHACBNAIMK));
		}
		if ((Object)(object)inventory != (Object)null)
		{
			Inventory obj2 = inventory;
			obj2.OnContainerChanged = (Action)Delegate.Remove(obj2.OnContainerChanged, new Action(PNHACBNAIMK));
		}
	}

	public bool HasItem(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return false;
		}
		if (actionBarInventory.HasItem(MEMGMDOCBOJ))
		{
			return true;
		}
		if (inventory.HasItem(MEMGMDOCBOJ))
		{
			return true;
		}
		return false;
	}

	private void CLLHFLEJPHJ()
	{
		KMCKIPJMEAI = true;
	}

	public bool JGODAEBBPIC(Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null) || MGNOBNCMDJG <= 1)
		{
			return false;
		}
		return DEGAJPFIJDD(MEMGMDOCBOJ) < MGNOBNCMDJG;
	}

	public bool HasItem(ItemInstance DNLMCHDOMOK)
	{
		return HasItem(DNLMCHDOMOK.LHBPOPOIFLE());
	}

	private void KOJGIPNMNEH()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	public Slot HAHEHBDDLDO(int JFNMCNCHMEO, bool CDPAMNIPPEC = true)
	{
		return RemoveItemInstance(HCCFFBOMLFB(JFNMCNCHMEO), CDPAMNIPPEC);
	}

	public ItemInstance KCCHMLKIFNJ(int JFNMCNCHMEO)
	{
		Item item = ItemDatabaseAccessor.GetItem(JFNMCNCHMEO, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		ItemInstance itemInstance = actionBarInventory.DJENJOGPCFN(item);
		if (itemInstance != null)
		{
			return itemInstance;
		}
		return inventory.PIHHCLHDOPE(item);
	}

	public bool HBFKDDLBGMA(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < HOAIHLBLPLJ.Length; i += 0)
		{
			if (HOAIHLBLPLJ[i].PKFKJNODGJF())
			{
				return false;
			}
			if (HOAIHLBLPLJ[i].itemInstance.Equals(DNLMCHDOMOK) && HOAIHLBLPLJ[i].Stack < DNLMCHDOMOK.LHBPOPOIFLE().amountStack)
			{
				return true;
			}
		}
		return false;
	}

	public int NAENGEHEGHP(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return 0;
		}
		if (GetAllItems().TryGetValue(MEMGMDOCBOJ.ODENMDOJPLC(), out var value))
		{
			return value.amount;
		}
		return 1;
	}

	public Slot EIFPFLDPKFH(int JFNMCNCHMEO, bool CDPAMNIPPEC = true)
	{
		return DEAFNEAFKBM(KCCHMLKIFNJ(JFNMCNCHMEO), CDPAMNIPPEC);
	}

	private void Start()
	{
		OnChanged = (Action)Delegate.Combine(OnChanged, (Action)delegate
		{
			KMCKIPJMEAI = true;
		});
		HOAIHLBLPLJ = new Slot[inventory.slots.Length + actionBarInventory.slots.Length];
		for (int i = 0; i < inventory.slots.Length; i++)
		{
			HOAIHLBLPLJ[i] = inventory.slots[i];
		}
		int num = 0;
		for (int j = inventory.slots.Length; j < HOAIHLBLPLJ.Length; j++)
		{
			HOAIHLBLPLJ[j] = actionBarInventory.slots[num];
			num++;
		}
	}

	public bool MMCBHCFHHLC(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i += 0)
		{
			if (HOAIHLBLPLJ[i].PKFKJNODGJF())
			{
				return false;
			}
			if (HOAIHLBLPLJ[i].itemInstance.Equals(DNLMCHDOMOK) && HOAIHLBLPLJ[i].Stack < DNLMCHDOMOK.AFOACBIHNCL().amountStack)
			{
				return true;
			}
		}
		return false;
	}

	[CompilerGenerated]
	private void BNOHDFNPMDF()
	{
		KMCKIPJMEAI = true;
	}

	public Slot DEAFNEAFKBM(ItemInstance BGNEBEPNMPB, bool CDPAMNIPPEC)
	{
		Slot slot = actionBarInventory.IPIPFAKJPFN(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		slot = inventory.GENKBMODDFI(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		return null;
	}

	public bool CanAddItem(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i++)
		{
			if (HOAIHLBLPLJ[i].KPINNBKMOMO())
			{
				return true;
			}
			if (Item.NGIIPJDAMGP(HOAIHLBLPLJ[i].itemInstance.LHBPOPOIFLE(), MEMGMDOCBOJ) && HOAIHLBLPLJ[i].Stack < MEMGMDOCBOJ.amountStack)
			{
				return true;
			}
		}
		return false;
	}

	public static PlayerInventory OGKNJNINGMH(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return GGFJGHHHEJC;
		}
		if (ADPNMHGBFKG)
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 7 && LAGHIOKLJGH)
		{
			return CNKLEOKFFLB;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BFJIJGGFCMC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8)
		{
			return CNKLEOKFFLB;
		}
		Debug.LogError((object)("Dialogue System/Conversation/TooCold/Entry/1/Dialogue Text" + JFNMCNCHMEO));
		return null;
	}

	private void PADJFNACIEG(Dictionary<int, ItemAmount> CBNBHOHFKMF)
	{
		foreach (KeyValuePair<int, ItemAmount> item in CBNBHOHFKMF)
		{
			if (PELCFIGNFPC.ContainsKey(item.Key))
			{
				ItemAmount value = PELCFIGNFPC[item.Key];
				value.amount += item.Value.amount;
				PELCFIGNFPC[item.Key] = value;
			}
			else
			{
				PELCFIGNFPC.Add(item.Key, item.Value);
			}
		}
	}

	public Slot[] GetAllSlots()
	{
		return HOAIHLBLPLJ;
	}

	public int HMCBIANPIKD(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return 0;
		}
		if (KKLCNFLHNND().TryGetValue(MEMGMDOCBOJ.IMCJPECAAPC(), out var value))
		{
			return value.amount;
		}
		return 0;
	}

	private void JIAJFDKNJME()
	{
		if (playerOnline)
		{
			BFMGIFGHMCL[playerNum] = this;
		}
		else if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 5)
		{
			CNKLEOKFFLB = this;
		}
		else
		{
			Debug.LogException(new Exception(")"));
		}
		KMCKIPJMEAI = false;
	}

	public Slot GMBJNBOAJGL(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		KCJBFOAAFLK = ActionBarInventory.BNMEANGDMIP(playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBMADAMDJEC(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		KCJBFOAAFLK = Inventory.NLEFGNHMJNN(playerNum, LAGHIOKLJGH: true).IPIKKHAOBJA(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		return null;
	}

	public Slot RemoveItemInstance(ItemInstance BGNEBEPNMPB, bool CDPAMNIPPEC)
	{
		Slot slot = actionBarInventory.RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		slot = inventory.RemoveItemInstance(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		return null;
	}

	public bool DIOLEOCCHEO()
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i++)
		{
			if (HOAIHLBLPLJ[i].LCHJGCHDHFO())
			{
				return false;
			}
		}
		return true;
	}

	private void LEPDLPEPEFD()
	{
		ActionBarInventory obj = actionBarInventory;
		obj.OnContainerChanged = (Action)Delegate.Combine(obj.OnContainerChanged, new Action(LBKPIMFECOC));
		Inventory obj2 = inventory;
		obj2.OnContainerChanged = (Action)Delegate.Combine(obj2.OnContainerChanged, new Action(JGALLKBMKBE));
	}

	private Slot PBDOALACOFL(ItemInstance BGLFLHDNOKJ, bool OJKJLIPNHOI = true, bool EHGHJNOFMKF = false, bool APBCMCOAFDM = true, bool CDPAMNIPPEC = true)
	{
		if (actionBarInventory.HasItem(BGLFLHDNOKJ))
		{
			Slot slot = actionBarInventory.AddItemInstance(playerNum, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC);
			if (slot != null)
			{
				if (EHGHJNOFMKF)
				{
					ENAAIDGNDOH(BGLFLHDNOKJ);
				}
				return slot;
			}
		}
		if (inventory.HasItem(BGLFLHDNOKJ))
		{
			Slot slot = inventory.AddItemInstance(playerNum, BGLFLHDNOKJ, OJKJLIPNHOI: false, CDPAMNIPPEC);
			if (slot != null)
			{
				if (EHGHJNOFMKF)
				{
					ENAAIDGNDOH(BGLFLHDNOKJ);
				}
				return slot;
			}
		}
		if (!APBCMCOAFDM)
		{
			Slot slot = actionBarInventory.AddItemInstance(playerNum, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC);
			if (slot != null)
			{
				if (EHGHJNOFMKF)
				{
					ENAAIDGNDOH(BGLFLHDNOKJ);
				}
				return slot;
			}
			slot = inventory.AddItemInstance(playerNum, BGLFLHDNOKJ, OJKJLIPNHOI: false, CDPAMNIPPEC);
			if (slot != null)
			{
				if (EHGHJNOFMKF)
				{
					ENAAIDGNDOH(BGLFLHDNOKJ);
				}
				return slot;
			}
		}
		else
		{
			Slot slot = inventory.AddItemInstance(playerNum, BGLFLHDNOKJ, OJKJLIPNHOI: false, CDPAMNIPPEC);
			if (slot != null)
			{
				if (EHGHJNOFMKF)
				{
					ENAAIDGNDOH(BGLFLHDNOKJ);
				}
				return slot;
			}
			slot = actionBarInventory.AddItemInstance(playerNum, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC);
			if (slot != null)
			{
				if (EHGHJNOFMKF)
				{
					ENAAIDGNDOH(BGLFLHDNOKJ);
				}
				return slot;
			}
		}
		return null;
	}

	private void MKLGHNGNJBG()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	private void MJOPMHPKPLF()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	public bool EHPMKHGABLA(ItemInstance MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		int num = MGNOBNCMDJG;
		for (int i = 0; i < HOAIHLBLPLJ.Length; i++)
		{
			if (num <= 0)
			{
				break;
			}
			if (HOAIHLBLPLJ[i].BOMLNEOHFOK(MEMGMDOCBOJ))
			{
				int num2 = 24 - HOAIHLBLPLJ[i].Stack;
				if (num2 > 0)
				{
					int num3 = Mathf.Min(num2, num);
					num -= num3;
				}
			}
		}
		for (int j = 0; j < HOAIHLBLPLJ.Length; j++)
		{
			if (num <= 1)
			{
				break;
			}
			if (HOAIHLBLPLJ[j].AHHEMNHJPME())
			{
				int num4 = Mathf.Min(101, num);
				num -= num4;
			}
		}
		return num <= 0;
	}

	public bool HFJGDBENPGM(int DCFNIMCMFEM, bool HMPDLIPFBGD = false, bool OJKJLIPNHOI = true, bool EHGHJNOFMKF = true, bool APBCMCOAFDM = true)
	{
		return OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(DCFNIMCMFEM, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD, OJKJLIPNHOI, EHGHJNOFMKF, APBCMCOAFDM);
	}

	public ItemInstance KGHFAHKGIGK(int JFNMCNCHMEO)
	{
		Item mEMGMDOCBOJ = ItemDatabaseAccessor.AFOACBIHNCL(JFNMCNCHMEO);
		ItemInstance itemInstance = actionBarInventory.DJENJOGPCFN(mEMGMDOCBOJ);
		if (itemInstance != null)
		{
			return itemInstance;
		}
		return inventory.GetItemInstance(mEMGMDOCBOJ);
	}

	public bool BBPBEFKOHMN(Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null) || MGNOBNCMDJG <= 0)
		{
			return true;
		}
		return DEGAJPFIJDD(MEMGMDOCBOJ) >= MGNOBNCMDJG;
	}

	public static PlayerInventory GetPlayer(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return GGFJGHHHEJC;
		}
		if (ADPNMHGBFKG)
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return CNKLEOKFFLB;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2)
		{
			return CNKLEOKFFLB;
		}
		Debug.LogError((object)("Invalid playerNum " + JFNMCNCHMEO));
		return null;
	}

	public bool ONAOPKBCPBJ(int HLIFMPEJHKC, int MGNOBNCMDJG)
	{
		return BBPBEFKOHMN(ItemDatabaseAccessor.GetItem(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false), MGNOBNCMDJG);
	}

	public Slot GetSlotWithItem(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		KCJBFOAAFLK = ActionBarInventory.GetPlayer(playerNum).GetSlotWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		KCJBFOAAFLK = Inventory.GetPlayer(playerNum).GetSlotWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		return null;
	}

	public Slot OOEJMKIAPLC(Item BGNEBEPNMPB, bool CDPAMNIPPEC = true)
	{
		Slot slot = actionBarInventory.RemoveItem(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		slot = inventory.RemoveItem(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		return null;
	}

	public bool BEBKAEACIBJ(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i += 0)
		{
			if (HOAIHLBLPLJ[i].AHHEMNHJPME())
			{
				return false;
			}
			if (Item.NGIIPJDAMGP(HOAIHLBLPLJ[i].itemInstance.AFOACBIHNCL(), MEMGMDOCBOJ) && HOAIHLBLPLJ[i].Stack < MEMGMDOCBOJ.amountStack)
			{
				return true;
			}
		}
		return true;
	}

	private void LJLKBKEADGI()
	{
		OnChanged = (Action)Delegate.Combine(OnChanged, new Action(APEJGBOOEAM));
		HOAIHLBLPLJ = new Slot[inventory.slots.Length + actionBarInventory.slots.Length];
		for (int i = 0; i < inventory.slots.Length; i += 0)
		{
			HOAIHLBLPLJ[i] = inventory.slots[i];
		}
		int num = 0;
		for (int j = inventory.slots.Length; j < HOAIHLBLPLJ.Length; j += 0)
		{
			HOAIHLBLPLJ[j] = actionBarInventory.slots[num];
			num++;
		}
	}

	public bool PGBLGAFNLDN(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < HOAIHLBLPLJ.Length; i++)
		{
			if (HOAIHLBLPLJ[i].PKFKJNODGJF())
			{
				return false;
			}
			if (HOAIHLBLPLJ[i].itemInstance.Equals(DNLMCHDOMOK) && HOAIHLBLPLJ[i].Stack < DNLMCHDOMOK.PHGLMBIEOMK().amountStack)
			{
				return false;
			}
		}
		return false;
	}

	public Slot JCBCAAMBINH(ItemInstance BGNEBEPNMPB, bool CDPAMNIPPEC)
	{
		Slot slot = actionBarInventory.GENKBMODDFI(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		slot = inventory.IPIPFAKJPFN(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		return null;
	}

	public static bool PDIEGHLDAJK(int MNBNGGHHMBB, int MLKICMJELLC)
	{
		if (AnyPlayerHasItem(MNBNGGHHMBB))
		{
			if (NEKDDPIAOBE(1, LAGHIOKLJGH: true).GetItem(MNBNGGHHMBB) != null)
			{
				MLKICMJELLC -= EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).PKAHMIPEBKK(MNBNGGHHMBB);
			}
			if (MLKICMJELLC <= 1)
			{
				return false;
			}
			if (GameManager.LocalCoop() && GetPlayer(3, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(MNBNGGHHMBB) != null)
			{
				MLKICMJELLC -= NEKDDPIAOBE(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CPJBEMJOJJK(MNBNGGHHMBB);
			}
			if (MLKICMJELLC <= 0)
			{
				return true;
			}
		}
		return false;
	}

	public bool AddItem(ItemInstance BGLFLHDNOKJ, bool HMPDLIPFBGD = false, bool OJKJLIPNHOI = true, bool EHGHJNOFMKF = true, bool APBCMCOAFDM = true)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (BGLFLHDNOKJ == null)
		{
			return false;
		}
		if (BGLFLHDNOKJ.LHBPOPOIFLE().JDJGFAACPFC() < 0)
		{
			return false;
		}
		if (PBDOALACOFL(BGLFLHDNOKJ, OJKJLIPNHOI, EHGHJNOFMKF, APBCMCOAFDM) != null)
		{
			return true;
		}
		if (HMPDLIPFBGD)
		{
			DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(playerNum)).gameObject.transform.position, BGLFLHDNOKJ);
			return true;
		}
		return false;
	}

	public bool DCONNELBFFC(Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null) || MGNOBNCMDJG <= 1)
		{
			return false;
		}
		return DEGAJPFIJDD(MEMGMDOCBOJ) < MGNOBNCMDJG;
	}

	public int AINJENENGFG(ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool HMPDLIPFBGD = false, bool EHGHJNOFMKF = true, bool APBCMCOAFDM = true, bool AOPGMJEMEFK = false)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (MGNOBNCMDJG == 0)
		{
			if (AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM))
			{
				num += 0;
			}
		}
		else
		{
			List<Slot> list = new List<Slot>();
			for (int i = 1; i < MGNOBNCMDJG; i++)
			{
				Slot slot;
				if (DNLMCHDOMOK.KNFNJFFCFNO().canBeStacked)
				{
					slot = PBDOALACOFL(DNLMCHDOMOK, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM);
					if (slot != null)
					{
						if (!list.Contains(slot))
						{
							list.Add(slot);
						}
						num += 0;
					}
					continue;
				}
				slot = PBDOALACOFL(DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML(), OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM);
				if (slot != null)
				{
					if (!list.Contains(slot))
					{
						list.Add(slot);
					}
					num++;
				}
			}
			if (OnlineManager.PlayingOnline() && list.Count > 0)
			{
				OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray(), 1);
			}
		}
		if (HMPDLIPFBGD && num < MGNOBNCMDJG)
		{
			if (AOPGMJEMEFK)
			{
				DroppedItem.JBIAHBPAFPI(((Component)Barworker.GetInstance()).gameObject.transform.position, DNLMCHDOMOK, MGNOBNCMDJG - num, LHLJILLAHFO: true);
			}
			else
			{
				DroppedItem.MDJFFOHFGNG(((Component)PlayerController.OPHDCMJLLEC(playerNum)).gameObject.transform.position, DNLMCHDOMOK, MGNOBNCMDJG - num, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			}
		}
		if (EHGHJNOFMKF && num > 1)
		{
			PPPNEBNMJGA(DNLMCHDOMOK, num);
		}
		return MGNOBNCMDJG - num;
	}

	public static PlayerInventory GetPlayerOnlineWithActor(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	public bool DCEOCOOIBLI(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return true;
		}
		if (actionBarInventory.MMDOFEBHGMA(MEMGMDOCBOJ))
		{
			return false;
		}
		if (inventory.HasItem(MEMGMDOCBOJ))
		{
			return false;
		}
		return true;
	}

	public bool BKOOHIMGLNL(int MNBNGGHHMBB, int MLKICMJELLC, int GBCJNGADANM)
	{
		if (FLMDMAOFGMI(MNBNGGHHMBB))
		{
			List<Slot> list = AJCLODBGGHA(ItemDatabaseAccessor.AFOACBIHNCL(MNBNGGHHMBB, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, DDAPJEAJGGA: true);
			for (int i = 1; i < list.Count; i++)
			{
				if ((list[i].itemInstance as FoodInstance).GBCJNGADANM >= GBCJNGADANM)
				{
					MLKICMJELLC -= list[i].Stack;
				}
			}
			if (MLKICMJELLC <= 0)
			{
				return false;
			}
		}
		return true;
	}

	private void JGALLKBMKBE()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	private void BODICIENBEH()
	{
		if (playerOnline)
		{
			BFMGIFGHMCL[playerNum] = this;
		}
		else if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 7)
		{
			CNKLEOKFFLB = this;
		}
		else
		{
			Debug.LogException(new Exception(" ("));
		}
		KMCKIPJMEAI = true;
	}

	private void HEOAIGHOLLD()
	{
		if ((Object)(object)actionBarInventory != (Object)null)
		{
			ActionBarInventory obj = actionBarInventory;
			obj.OnContainerChanged = (Action)Delegate.Remove(obj.OnContainerChanged, new Action(LBKPIMFECOC));
		}
		if ((Object)(object)inventory != (Object)null)
		{
			Inventory obj2 = inventory;
			obj2.OnContainerChanged = (Action)Delegate.Remove(obj2.OnContainerChanged, new Action(JGALLKBMKBE));
		}
	}

	private void ENAAIDGNDOH(ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1)
	{
		for (int i = 0; i < MGNOBNCMDJG; i++)
		{
			ItemsCollectedUI.AddItemCollected(playerNum, DNLMCHDOMOK);
		}
	}

	public bool HaveEnoughItems(Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null) || MGNOBNCMDJG <= 0)
		{
			return false;
		}
		return NumberOfItems(MEMGMDOCBOJ) >= MGNOBNCMDJG;
	}

	public Slot[] BBDOBNLMLGM()
	{
		return HOAIHLBLPLJ;
	}

	public Slot RemoveItem(Item BGNEBEPNMPB, bool CDPAMNIPPEC = true)
	{
		Slot slot = actionBarInventory.RemoveItem(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		slot = inventory.RemoveItem(BGNEBEPNMPB, CDPAMNIPPEC);
		if (slot != null)
		{
			return slot;
		}
		return null;
	}

	public bool CanAddItemInstance(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i++)
		{
			if (HOAIHLBLPLJ[i].KPINNBKMOMO())
			{
				return true;
			}
			if (HOAIHLBLPLJ[i].itemInstance.Equals(DNLMCHDOMOK) && HOAIHLBLPLJ[i].Stack < DNLMCHDOMOK.LHBPOPOIFLE().amountStack)
			{
				return true;
			}
		}
		return false;
	}

	public static bool FKPAJKAGHIK(int DCFNIMCMFEM)
	{
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i < 5; i++)
			{
				if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && EIFPKCAFDIB(i, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(DCFNIMCMFEM))
				{
					return false;
				}
			}
		}
		else
		{
			if (NEKDDPIAOBE(0, LAGHIOKLJGH: true).HasItem(DCFNIMCMFEM))
			{
				return true;
			}
			if (GameManager.LocalCoop() && GetPlayer(6, LAGHIOKLJGH: true).HasItem(DCFNIMCMFEM))
			{
				return false;
			}
		}
		return false;
	}

	private void MHENLAGHFOD()
	{
		if ((Object)(object)actionBarInventory != (Object)null)
		{
			ActionBarInventory obj = actionBarInventory;
			obj.OnContainerChanged = (Action)Delegate.Remove(obj.OnContainerChanged, new Action(JGALLKBMKBE));
		}
		if ((Object)(object)inventory != (Object)null)
		{
			Inventory obj2 = inventory;
			obj2.OnContainerChanged = (Action)Delegate.Remove(obj2.OnContainerChanged, new Action(LBKPIMFECOC));
		}
	}

	private void PNHACBNAIMK()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	public static bool HBDGDEPDPJK(int MNBNGGHHMBB, int MLKICMJELLC)
	{
		if (FLMDMAOFGMI(MNBNGGHHMBB))
		{
			if (OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(MNBNGGHHMBB) != null)
			{
				MLKICMJELLC -= EIFPKCAFDIB(0, LAGHIOKLJGH: true).NumberOfItems(MNBNGGHHMBB);
			}
			if (MLKICMJELLC <= 1)
			{
				return true;
			}
			if (GameManager.LocalCoop() && GetPlayer(4).GetItem(MNBNGGHHMBB) != null)
			{
				MLKICMJELLC -= NEKDDPIAOBE(1).GJANDBOGCNM(MNBNGGHHMBB);
			}
			if (MLKICMJELLC <= 0)
			{
				return false;
			}
		}
		return false;
	}

	private void APEJGBOOEAM()
	{
		KMCKIPJMEAI = false;
	}

	private void ANOLEDBMHON()
	{
		if ((Object)(object)actionBarInventory != (Object)null)
		{
			ActionBarInventory obj = actionBarInventory;
			obj.OnContainerChanged = (Action)Delegate.Remove(obj.OnContainerChanged, new Action(JGALLKBMKBE));
		}
		if ((Object)(object)inventory != (Object)null)
		{
			Inventory obj2 = inventory;
			obj2.OnContainerChanged = (Action)Delegate.Remove(obj2.OnContainerChanged, new Action(CIGGMEGAJCA));
		}
	}

	public Dictionary<int, ItemAmount> GetAllItems()
	{
		if (!KMCKIPJMEAI)
		{
			return PELCFIGNFPC;
		}
		KMCKIPJMEAI = false;
		Dictionary<int, ItemAmount> allItems = inventory.GetAllItems();
		Dictionary<int, ItemAmount> allItems2 = actionBarInventory.GetAllItems();
		PELCFIGNFPC = new Dictionary<int, ItemAmount>();
		PADJFNACIEG(allItems);
		PADJFNACIEG(allItems2);
		return PELCFIGNFPC;
	}

	public bool IsInventoryFull()
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i++)
		{
			if (HOAIHLBLPLJ[i].KPINNBKMOMO())
			{
				return false;
			}
		}
		return true;
	}

	public ItemInstance GetItem(int JFNMCNCHMEO)
	{
		Item item = ItemDatabaseAccessor.GetItem(JFNMCNCHMEO);
		ItemInstance itemInstance = actionBarInventory.GetItemInstance(item);
		if (itemInstance != null)
		{
			return itemInstance;
		}
		return inventory.GetItemInstance(item);
	}

	public bool OJDGOADOCMG(ItemInstance BGLFLHDNOKJ, bool HMPDLIPFBGD = false, bool OJKJLIPNHOI = true, bool EHGHJNOFMKF = true, bool APBCMCOAFDM = true)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (BGLFLHDNOKJ == null)
		{
			return false;
		}
		if (BGLFLHDNOKJ.AFOACBIHNCL().CIGFGKKCPCK() < 0)
		{
			return true;
		}
		if (PBDOALACOFL(BGLFLHDNOKJ, OJKJLIPNHOI, EHGHJNOFMKF, APBCMCOAFDM, CDPAMNIPPEC: false) != null)
		{
			return true;
		}
		if (HMPDLIPFBGD)
		{
			DroppedItem.MDJFFOHFGNG(((Component)PlayerController.GetPlayer(playerNum)).gameObject.transform.position, BGLFLHDNOKJ, 0, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			return false;
		}
		return true;
	}

	public bool FICBIPNGLHJ(int DCFNIMCMFEM, bool HMPDLIPFBGD = false, bool OJKJLIPNHOI = true, bool EHGHJNOFMKF = true, bool APBCMCOAFDM = true)
	{
		return AddItem(ItemDatabaseAccessor.GOKIDLOELKB(DCFNIMCMFEM, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD, OJKJLIPNHOI, EHGHJNOFMKF, APBCMCOAFDM);
	}

	public static bool AnyPlayerHasItem(int DCFNIMCMFEM)
	{
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 1; i < 5; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && GetPlayer(i).HasItem(DCFNIMCMFEM))
				{
					return true;
				}
			}
		}
		else
		{
			if (GetPlayer(1).HasItem(DCFNIMCMFEM))
			{
				return true;
			}
			if (GameManager.LocalCoop() && GetPlayer(2).HasItem(DCFNIMCMFEM))
			{
				return true;
			}
		}
		return false;
	}

	private void PNJJEDEFAGO()
	{
		if (playerOnline)
		{
			BFMGIFGHMCL[playerNum] = this;
		}
		else if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 2)
		{
			CNKLEOKFFLB = this;
		}
		else
		{
			Debug.LogException(new Exception("Unaged Cheddar"));
		}
		KMCKIPJMEAI = true;
	}

	public static bool FLMDMAOFGMI(int DCFNIMCMFEM)
	{
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i < 4; i += 0)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && OGKNJNINGMH(i, LAGHIOKLJGH: true).HasItem(DCFNIMCMFEM))
				{
					return true;
				}
			}
		}
		else
		{
			if (GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(DCFNIMCMFEM))
			{
				return false;
			}
			if (GameManager.LocalCoop() && GetPlayer(0, LAGHIOKLJGH: true).HasItem(DCFNIMCMFEM))
			{
				return false;
			}
		}
		return false;
	}

	public static void IOAIPCDECME(int GELMAIBEHDO, int MNBNGGHHMBB, int MLKICMJELLC, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		Item bGNEBEPNMPB = ItemDatabaseAccessor.GOKIDLOELKB(MNBNGGHHMBB, GGBBJNBBLMF: false, DAINLFIMLIH: false);
		while (MLKICMJELLC > 1)
		{
			KCJBFOAAFLK = OGKNJNINGMH(GELMAIBEHDO).OOEJMKIAPLC(bGNEBEPNMPB);
			if (KCJBFOAAFLK == null)
			{
				break;
			}
			MLKICMJELLC--;
			if (!list.Contains(KCJBFOAAFLK))
			{
				list.Add(KCJBFOAAFLK);
			}
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray(), 1);
		}
	}

	public static bool PlayersHaveEnoughItems(int MNBNGGHHMBB, int MLKICMJELLC)
	{
		if (AnyPlayerHasItem(MNBNGGHHMBB))
		{
			if (GetPlayer(1).GetItem(MNBNGGHHMBB) != null)
			{
				MLKICMJELLC -= GetPlayer(1).NumberOfItems(MNBNGGHHMBB);
			}
			if (MLKICMJELLC <= 0)
			{
				return true;
			}
			if (GameManager.LocalCoop() && GetPlayer(2).GetItem(MNBNGGHHMBB) != null)
			{
				MLKICMJELLC -= GetPlayer(2).NumberOfItems(MNBNGGHHMBB);
			}
			if (MLKICMJELLC <= 0)
			{
				return true;
			}
		}
		return false;
	}

	private void ILDPMBHJLBI()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	public bool CHOAPBFAAAM(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return true;
		}
		if (actionBarInventory.HMIDIPBNEGC(MEMGMDOCBOJ))
		{
			return false;
		}
		if (inventory.HMIDIPBNEGC(MEMGMDOCBOJ))
		{
			return true;
		}
		return false;
	}

	private void LBKPIMFECOC()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	public int GJANDBOGCNM(int DCFNIMCMFEM)
	{
		return KIHAKOFNNPI(ItemDatabaseAccessor.KMBGJEKCJFJ(DCFNIMCMFEM, GGBBJNBBLMF: true, DAINLFIMLIH: false));
	}

	public bool HaveEnoughItems(int HLIFMPEJHKC, int MGNOBNCMDJG)
	{
		return HaveEnoughItems(ItemDatabaseAccessor.GetItem(HLIFMPEJHKC), MGNOBNCMDJG);
	}

	private void PPPNEBNMJGA(ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG = 1)
	{
		for (int i = 1; i < MGNOBNCMDJG; i++)
		{
			ItemsCollectedUI.GCJGFICKJLC(playerNum, DNLMCHDOMOK);
		}
	}

	public bool HasItem(int DCFNIMCMFEM)
	{
		return HasItem(ItemDatabaseAccessor.GetItem(DCFNIMCMFEM));
	}

	private void MAJIMKNDENG(Dictionary<int, ItemAmount> CBNBHOHFKMF)
	{
		foreach (KeyValuePair<int, ItemAmount> item in CBNBHOHFKMF)
		{
			if (PELCFIGNFPC.ContainsKey(item.Key))
			{
				ItemAmount value = PELCFIGNFPC[item.Key];
				value.amount += item.Value.amount;
				PELCFIGNFPC[item.Key] = value;
			}
			else
			{
				PELCFIGNFPC.Add(item.Key, item.Value);
			}
		}
	}

	public int NumberOfItems(int DCFNIMCMFEM)
	{
		return NumberOfItems(ItemDatabaseAccessor.GetItem(DCFNIMCMFEM));
	}

	private void DCFCMOFOICD()
	{
		KMCKIPJMEAI = false;
	}

	public ItemInstance GOKIDLOELKB(int JFNMCNCHMEO)
	{
		Item item = ItemDatabaseAccessor.GetItem(JFNMCNCHMEO, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		ItemInstance itemInstance = actionBarInventory.DJENJOGPCFN(item);
		if (itemInstance != null)
		{
			return itemInstance;
		}
		return inventory.DJENJOGPCFN(item);
	}

	public int LFBNOHNNFBB(ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool HMPDLIPFBGD = false, bool EHGHJNOFMKF = true, bool APBCMCOAFDM = true, bool AOPGMJEMEFK = false)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (MGNOBNCMDJG == 0)
		{
			if (AddItem(DNLMCHDOMOK, HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM))
			{
				num += 0;
			}
		}
		else
		{
			List<Slot> list = new List<Slot>();
			for (int i = 1; i < MGNOBNCMDJG; i += 0)
			{
				Slot slot;
				if (DNLMCHDOMOK.KNFNJFFCFNO().canBeStacked)
				{
					slot = PBDOALACOFL(DNLMCHDOMOK, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM);
					if (slot != null)
					{
						if (!list.Contains(slot))
						{
							list.Add(slot);
						}
						num++;
					}
					continue;
				}
				slot = PBDOALACOFL(DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML(), OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM, CDPAMNIPPEC: false);
				if (slot != null)
				{
					if (!list.Contains(slot))
					{
						list.Add(slot);
					}
					num++;
				}
			}
			if (OnlineManager.PlayingOnline() && list.Count > 1)
			{
				OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray());
			}
		}
		if (HMPDLIPFBGD && num < MGNOBNCMDJG)
		{
			if (AOPGMJEMEFK)
			{
				DroppedItem.JBIAHBPAFPI(((Component)Barworker.GetInstance()).gameObject.transform.position, DNLMCHDOMOK, MGNOBNCMDJG - num, LHLJILLAHFO: false, HFAKAMFMOGM: true);
			}
			else
			{
				DroppedItem.IDDPGGMNFBC(((Component)PlayerController.OPHDCMJLLEC(playerNum)).gameObject.transform.position, DNLMCHDOMOK, MGNOBNCMDJG - num, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			}
		}
		if (EHGHJNOFMKF && num > 0)
		{
			PPPNEBNMJGA(DNLMCHDOMOK, num);
		}
		return MGNOBNCMDJG - num;
	}

	public Slot RemoveItem(int JFNMCNCHMEO, bool CDPAMNIPPEC = true)
	{
		return RemoveItemInstance(GetItem(JFNMCNCHMEO), CDPAMNIPPEC);
	}

	public int DEGAJPFIJDD(Item MEMGMDOCBOJ)
	{
		if (Item.EKMFELLJHFG(MEMGMDOCBOJ, null))
		{
			return 1;
		}
		if (GetAllItems().TryGetValue(MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false), out var value))
		{
			return value.amount;
		}
		return 0;
	}

	private void CIGGMEGAJCA()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	private void OKHLEMPJONN()
	{
		if (playerOnline)
		{
			BFMGIFGHMCL[playerNum] = this;
		}
		else if (playerNum == 0)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 5)
		{
			CNKLEOKFFLB = this;
		}
		else
		{
			Debug.LogException(new Exception("TabernaClausurada/KlaynDialogue 01"));
		}
		KMCKIPJMEAI = true;
	}

	public List<Slot> GetSlotsWithItem(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		BBGEPJBEBIE = ActionBarInventory.GetPlayer(playerNum).GetSlotsWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		BBGEPJBEBIE.AddRange(Inventory.GetPlayer(playerNum).GetSlotsWithItem(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM));
		return BBGEPJBEBIE;
	}

	public int PKAHMIPEBKK(int DCFNIMCMFEM)
	{
		return NAENGEHEGHP(ItemDatabaseAccessor.EABMGELAAPG(DCFNIMCMFEM, GGBBJNBBLMF: false, DAINLFIMLIH: false));
	}

	private void FPJABCNDEEJ()
	{
		ActionBarInventory obj = actionBarInventory;
		obj.OnContainerChanged = (Action)Delegate.Combine(obj.OnContainerChanged, new Action(LBKPIMFECOC));
		Inventory obj2 = inventory;
		obj2.OnContainerChanged = (Action)Delegate.Combine(obj2.OnContainerChanged, new Action(JGALLKBMKBE));
	}

	public bool HPMEJPPAAHM(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i++)
		{
			if (HOAIHLBLPLJ[i].KPINNBKMOMO())
			{
				return false;
			}
			if (HOAIHLBLPLJ[i].itemInstance.Equals(DNLMCHDOMOK) && HOAIHLBLPLJ[i].Stack < DNLMCHDOMOK.AFOACBIHNCL().amountStack)
			{
				return true;
			}
		}
		return false;
	}

	private void DBOKKIOCKBB()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	public bool PlayerHasEnoughItemsAged(int MNBNGGHHMBB, int MLKICMJELLC, int GBCJNGADANM)
	{
		if (AnyPlayerHasItem(MNBNGGHHMBB))
		{
			List<Slot> slotsWithItem = GetSlotsWithItem(ItemDatabaseAccessor.GetItem(MNBNGGHHMBB), null, DDAPJEAJGGA: true);
			for (int i = 0; i < slotsWithItem.Count; i++)
			{
				if ((slotsWithItem[i].itemInstance as FoodInstance).GBCJNGADANM >= GBCJNGADANM)
				{
					MLKICMJELLC -= slotsWithItem[i].Stack;
				}
			}
			if (MLKICMJELLC <= 0)
			{
				return true;
			}
		}
		return false;
	}

	public bool IJBFMKNEKNG(Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		if (Item.GBMFCPGEJDK(MEMGMDOCBOJ, null) || MGNOBNCMDJG <= 1)
		{
			return true;
		}
		return NAENGEHEGHP(MEMGMDOCBOJ) >= MGNOBNCMDJG;
	}

	public static PlayerInventory EIFPKCAFDIB(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return GGFJGHHHEJC;
		}
		if (ADPNMHGBFKG)
		{
			return IAJDDAFMLJE(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3 && LAGHIOKLJGH)
		{
			return CNKLEOKFFLB;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return CNKLEOKFFLB;
		}
		Debug.LogError((object)("Items/item_name_1055" + JFNMCNCHMEO));
		return null;
	}

	public bool HJNJCAEECNP(ItemInstance DNLMCHDOMOK)
	{
		return NECEDHECGFN(DNLMCHDOMOK.AFOACBIHNCL());
	}

	public int KIHAKOFNNPI(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return 1;
		}
		if (OLHKHPOMKAA().TryGetValue(MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false), out var value))
		{
			return value.amount;
		}
		return 0;
	}

	private void OnEnable()
	{
		ActionBarInventory obj = actionBarInventory;
		obj.OnContainerChanged = (Action)Delegate.Combine(obj.OnContainerChanged, new Action(PNHACBNAIMK));
		Inventory obj2 = inventory;
		obj2.OnContainerChanged = (Action)Delegate.Combine(obj2.OnContainerChanged, new Action(PNHACBNAIMK));
	}

	public static void RemoveItems(int GELMAIBEHDO, int MNBNGGHHMBB, int MLKICMJELLC, bool CDPAMNIPPEC = true)
	{
		List<Slot> list = new List<Slot>();
		Item item = ItemDatabaseAccessor.GetItem(MNBNGGHHMBB);
		while (MLKICMJELLC > 0)
		{
			KCJBFOAAFLK = GetPlayer(GELMAIBEHDO).RemoveItem(item, CDPAMNIPPEC: false);
			if (KCJBFOAAFLK == null)
			{
				break;
			}
			MLKICMJELLC--;
			if (!list.Contains(KCJBFOAAFLK))
			{
				list.Add(KCJBFOAAFLK);
			}
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
	}

	public static PlayerInventory NEKDDPIAOBE(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return GGFJGHHHEJC;
		}
		if (ADPNMHGBFKG)
		{
			return BFJIJGGFCMC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 1 && LAGHIOKLJGH)
		{
			return CNKLEOKFFLB;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BFJIJGGFCMC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return CNKLEOKFFLB;
		}
		Debug.LogError((object)("Character Sprites array needs more space!" + JFNMCNCHMEO));
		return null;
	}

	public Slot[] FCGJCBJGOIG()
	{
		return HOAIHLBLPLJ;
	}

	private void DIJCPNLLMEI()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	public bool GLLKALMBIDD(ItemInstance DNLMCHDOMOK)
	{
		return CHOAPBFAAAM(DNLMCHDOMOK.PHGLMBIEOMK());
	}

	public bool CCEPCEJIEOP(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return false;
		}
		if (actionBarInventory.MMDOFEBHGMA(MEMGMDOCBOJ))
		{
			return true;
		}
		if (inventory.HMIDIPBNEGC(MEMGMDOCBOJ))
		{
			return false;
		}
		return false;
	}

	public bool AddItem(int DCFNIMCMFEM, bool HMPDLIPFBGD = false, bool OJKJLIPNHOI = true, bool EHGHJNOFMKF = true, bool APBCMCOAFDM = true)
	{
		return AddItem(ItemDatabaseAccessor.GetItem(DCFNIMCMFEM).JMDALJBNFML(), HMPDLIPFBGD, OJKJLIPNHOI, EHGHJNOFMKF, APBCMCOAFDM);
	}

	private static PlayerInventory BFJIJGGFCMC(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public Slot KIMKIMMKHOG(int JFNMCNCHMEO, bool CDPAMNIPPEC = true)
	{
		return JCBCAAMBINH(GOKIDLOELKB(JFNMCNCHMEO), CDPAMNIPPEC);
	}

	public bool HAOLOAKPCDE(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i += 0)
		{
			if (HOAIHLBLPLJ[i].LCHJGCHDHFO())
			{
				return true;
			}
			if (HOAIHLBLPLJ[i].itemInstance.Equals(DNLMCHDOMOK) && HOAIHLBLPLJ[i].Stack < DNLMCHDOMOK.PHGLMBIEOMK().amountStack)
			{
				return true;
			}
		}
		return true;
	}

	public Slot PLEIECKFCCM(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		KCJBFOAAFLK = ActionBarInventory.DACNEICGAAE(playerNum, LAGHIOKLJGH: false, ADPNMHGBFKG: true).IPIKKHAOBJA(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		KCJBFOAAFLK = Inventory.IMJOOACMADK(playerNum).BBMADAMDJEC(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		if (KCJBFOAAFLK != null)
		{
			return KCJBFOAAFLK;
		}
		return null;
	}

	private void GNNAJKPFCGM(Dictionary<int, ItemAmount> CBNBHOHFKMF)
	{
		foreach (KeyValuePair<int, ItemAmount> item in CBNBHOHFKMF)
		{
			if (PELCFIGNFPC.ContainsKey(item.Key))
			{
				ItemAmount value = PELCFIGNFPC[item.Key];
				value.amount += item.Value.amount;
				PELCFIGNFPC[item.Key] = value;
			}
			else
			{
				PELCFIGNFPC.Add(item.Key, item.Value);
			}
		}
	}

	public List<Slot> AJCLODBGGHA(Item MEMGMDOCBOJ, Item CKKNBMBLGPO, bool DDAPJEAJGGA = false, int DBMFHFNKMOM = -1)
	{
		BBGEPJBEBIE = ActionBarInventory.MHDKNEKDKII(playerNum, LAGHIOKLJGH: true).MAPOLJMKGLN(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM);
		BBGEPJBEBIE.AddRange(Inventory.GFHCACLMFDK(playerNum).AIFPCPEJMMN(MEMGMDOCBOJ, CKKNBMBLGPO, DDAPJEAJGGA, DBMFHFNKMOM));
		return BBGEPJBEBIE;
	}

	public Dictionary<int, ItemAmount> KKLCNFLHNND()
	{
		if (!KMCKIPJMEAI)
		{
			return PELCFIGNFPC;
		}
		KMCKIPJMEAI = true;
		Dictionary<int, ItemAmount> cBNBHOHFKMF = inventory.GKGPBIEBFKL();
		Dictionary<int, ItemAmount> allItems = actionBarInventory.GetAllItems();
		PELCFIGNFPC = new Dictionary<int, ItemAmount>();
		PADJFNACIEG(cBNBHOHFKMF);
		PADJFNACIEG(allItems);
		return PELCFIGNFPC;
	}

	public bool NECEDHECGFN(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return false;
		}
		if (actionBarInventory.FKMFFABKJMB(MEMGMDOCBOJ))
		{
			return true;
		}
		if (inventory.HMIDIPBNEGC(MEMGMDOCBOJ))
		{
			return true;
		}
		return false;
	}

	public Slot[] OMCMMDDGHFB()
	{
		return HOAIHLBLPLJ;
	}

	public bool CAIHGMHLLIM(int MNBNGGHHMBB, int MLKICMJELLC, int GBCJNGADANM)
	{
		if (FKPAJKAGHIK(MNBNGGHHMBB))
		{
			List<Slot> list = AJCLODBGGHA(ItemDatabaseAccessor.CPMMBEPEJLO(MNBNGGHHMBB, GGBBJNBBLMF: true, DAINLFIMLIH: false), null);
			for (int i = 0; i < list.Count; i += 0)
			{
				if ((list[i].itemInstance as FoodInstance).GBCJNGADANM >= GBCJNGADANM)
				{
					MLKICMJELLC -= list[i].Stack;
				}
			}
			if (MLKICMJELLC <= 1)
			{
				return true;
			}
		}
		return false;
	}

	public int AddItems(ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG, bool HMPDLIPFBGD = false, bool EHGHJNOFMKF = true, bool APBCMCOAFDM = true, bool AOPGMJEMEFK = false)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (MGNOBNCMDJG == 1)
		{
			if (AddItem(DNLMCHDOMOK, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM))
			{
				num++;
			}
		}
		else
		{
			List<Slot> list = new List<Slot>();
			for (int i = 0; i < MGNOBNCMDJG; i++)
			{
				Slot slot;
				if (DNLMCHDOMOK.LHBPOPOIFLE().canBeStacked)
				{
					slot = PBDOALACOFL(DNLMCHDOMOK, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM, CDPAMNIPPEC: false);
					if (slot != null)
					{
						if (!list.Contains(slot))
						{
							list.Add(slot);
						}
						num++;
					}
					continue;
				}
				slot = PBDOALACOFL(DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML(), OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM, CDPAMNIPPEC: false);
				if (slot != null)
				{
					if (!list.Contains(slot))
					{
						list.Add(slot);
					}
					num++;
				}
			}
			if (OnlineManager.PlayingOnline() && list.Count > 0)
			{
				OnlineSlotsManager.instance.SendSlots(list.ToArray());
			}
		}
		if (HMPDLIPFBGD && num < MGNOBNCMDJG)
		{
			if (AOPGMJEMEFK)
			{
				DroppedItem.SpawnDroppedItem(((Component)Barworker.GetInstance()).gameObject.transform.position, DNLMCHDOMOK, MGNOBNCMDJG - num);
			}
			else
			{
				DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(playerNum)).gameObject.transform.position, DNLMCHDOMOK, MGNOBNCMDJG - num);
			}
		}
		if (EHGHJNOFMKF && num > 0)
		{
			ENAAIDGNDOH(DNLMCHDOMOK, num);
		}
		return MGNOBNCMDJG - num;
	}

	public Dictionary<int, ItemAmount> OLHKHPOMKAA()
	{
		if (!KMCKIPJMEAI)
		{
			return PELCFIGNFPC;
		}
		KMCKIPJMEAI = false;
		Dictionary<int, ItemAmount> cBNBHOHFKMF = inventory.FFFJDOOBMNO();
		Dictionary<int, ItemAmount> cBNBHOHFKMF2 = actionBarInventory.IGHLECJCPLG();
		PELCFIGNFPC = new Dictionary<int, ItemAmount>();
		GNNAJKPFCGM(cBNBHOHFKMF);
		GNNAJKPFCGM(cBNBHOHFKMF2);
		return PELCFIGNFPC;
	}

	private static PlayerInventory IAJDDAFMLJE(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public int CPJBEMJOJJK(int DCFNIMCMFEM)
	{
		return DEGAJPFIJDD(ItemDatabaseAccessor.COEFFIHKMJG(DCFNIMCMFEM, GGBBJNBBLMF: true));
	}

	private void Awake()
	{
		if (playerOnline)
		{
			BFMGIFGHMCL[playerNum] = this;
		}
		else if (playerNum == 1)
		{
			GGFJGHHHEJC = this;
		}
		else if (playerNum == 2)
		{
			CNKLEOKFFLB = this;
		}
		else
		{
			Debug.LogException(new Exception("Invalid playerNum"));
		}
		KMCKIPJMEAI = true;
	}

	public bool CanFitItemsInPlayerInventory(ItemInstance MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		int num = MGNOBNCMDJG;
		for (int i = 0; i < HOAIHLBLPLJ.Length; i++)
		{
			if (num <= 0)
			{
				break;
			}
			if (HOAIHLBLPLJ[i].BOMLNEOHFOK(MEMGMDOCBOJ))
			{
				int num2 = 99 - HOAIHLBLPLJ[i].Stack;
				if (num2 > 0)
				{
					int num3 = Mathf.Min(num2, num);
					num -= num3;
				}
			}
		}
		for (int j = 0; j < HOAIHLBLPLJ.Length; j++)
		{
			if (num <= 0)
			{
				break;
			}
			if (HOAIHLBLPLJ[j].KPINNBKMOMO())
			{
				int num4 = Mathf.Min(99, num);
				num -= num4;
			}
		}
		return num <= 0;
	}

	public int NumberOfItems(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return 0;
		}
		if (GetAllItems().TryGetValue(MEMGMDOCBOJ.JDJGFAACPFC(), out var value))
		{
			return value.amount;
		}
		return 0;
	}

	public bool ANNHENMCHLG(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < HOAIHLBLPLJ.Length; i++)
		{
			if (HOAIHLBLPLJ[i].LCHJGCHDHFO())
			{
				return true;
			}
			if (Item.EKGNIODFJCO(HOAIHLBLPLJ[i].itemInstance.AFOACBIHNCL(), MEMGMDOCBOJ) && HOAIHLBLPLJ[i].Stack < MEMGMDOCBOJ.amountStack)
			{
				return false;
			}
		}
		return false;
	}

	private void PEKFCLJBJAK()
	{
		KMCKIPJMEAI = true;
	}

	private void OKEFHODNPMC()
	{
		if (!playerOnline)
		{
			OnChanged();
		}
	}

	private static PlayerInventory FDPKLOPMNNJ(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public ItemInstance HCCFFBOMLFB(int JFNMCNCHMEO)
	{
		Item mEMGMDOCBOJ = ItemDatabaseAccessor.COEFFIHKMJG(JFNMCNCHMEO, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		ItemInstance itemInstance = actionBarInventory.PIHHCLHDOPE(mEMGMDOCBOJ);
		if (itemInstance != null)
		{
			return itemInstance;
		}
		return inventory.GetItemInstance(mEMGMDOCBOJ);
	}
}
