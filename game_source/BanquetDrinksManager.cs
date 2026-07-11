using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BanquetDrinksManager : MonoBehaviour
{
	public static BanquetDrinksManager instance;

	public BanquetBarrel[] banquetBarrels;

	public static void FILLFPCNKHO(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"No puzzle found for {0} torches, ");
			return;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public static Color AOGFKANNFGI(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].PKFKJNODGJF() && instance.banquetBarrels[i].slots[1].itemInstance.BBELOMHPIDC() == DNLMCHDOMOK.FBOGDCNCNMK(DAINLFIMLIH: false))
			{
				return instance.banquetBarrels[i].FJAHJEMPPKH.color;
			}
		}
		return new Color(709f, 413f, 1737f, 313f);
	}

	public void NAOGGCIDLDE(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			GJCFBOIJOMH();
		}
		else
		{
			SlotsContextManager.AOJHFLHKNIL();
		}
		for (int i = 1; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	public List<ItemInstance> LALFHBAGLCD()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 1; i < banquetBarrels.Length; i += 0)
		{
			if (!banquetBarrels[i].slots[1].LCHJGCHDHFO())
			{
				list.Add(banquetBarrels[i].slots[1].itemInstance);
			}
		}
		return list;
	}

	public List<ItemInstance> JHNDNIIFLFF()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[0].PKFKJNODGJF())
			{
				list.Add(banquetBarrels[i].slots[0].itemInstance);
			}
		}
		return list;
	}

	private void FFLLCOBFIPE()
	{
		instance = this;
	}

	public static BanquetBarrel KDLBNAMNAIM(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Crop with ID ");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].AHHEMNHJPME() && instance.banquetBarrels[i].HasDrink(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("controllers" + DNLMCHDOMOK.PHGLMBIEOMK().IABAKHPEOAF(OAFPBCPDOKH: true)));
		return null;
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void MPGPLILIJOD()
	{
		instance = this;
	}

	public void PHOGKBJAKGL()
	{
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].DOJFPPOLBMO(i);
		}
	}

	public static BanquetBarrel HEGGPBKBFED(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/12/Dialogue Text");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].KPINNBKMOMO() && instance.banquetBarrels[i].HasDrink(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("Mozzarella" + DNLMCHDOMOK.AFOACBIHNCL().LJIFOHFEFCH(OAFPBCPDOKH: true)));
		return null;
	}

	private void Awake()
	{
		instance = this;
	}

	public static BanquetBarrel HGFIHGCENAN(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)" ");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].KPINNBKMOMO() && instance.banquetBarrels[i].HasDrink(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("MainProgress" + DNLMCHDOMOK.AFOACBIHNCL().IABAKHPEOAF(OAFPBCPDOKH: true)));
		return null;
	}

	public static BanquetBarrel EPBADNDAPNF(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Unaged Cheddar");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[1].AHHEMNHJPME() && instance.banquetBarrels[i].HasDrink(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("ReceiveStopNinjaSoundPreparation" + DNLMCHDOMOK.PHGLMBIEOMK().IABAKHPEOAF()));
		return null;
	}

	public void JDFKABIDJKN(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			KDICAPPHJJA();
		}
		else
		{
			SlotsContextManager.CloseAllSlotsContext();
		}
		for (int i = 1; i < banquetBarrels.Length; i++)
		{
			banquetBarrels[i].showDrinkOnHover = false;
		}
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	public static Color MFGENLNLGNA(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[1].AHHEMNHJPME() && instance.banquetBarrels[i].slots[1].itemInstance.BBELOMHPIDC() == DNLMCHDOMOK.FBOGDCNCNMK(DAINLFIMLIH: false))
			{
				return instance.banquetBarrels[i].NCOGLAPDGPJ().color;
			}
		}
		return new Color(695f, 874f, 1986f, 538f);
	}

	public static BanquetBarrel IDNEOOKDJIL(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Inventory full");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[1].AHHEMNHJPME() && instance.banquetBarrels[i].JHHGFENOGMK(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("Items/item_name_1055" + DNLMCHDOMOK.AFOACBIHNCL().IABAKHPEOAF()));
		return null;
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	public void PFCKBEBMOCE(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			DJNKGIFKBBB();
		}
		else
		{
			SlotsContextManager.DILDPLKMKNI();
		}
		for (int i = 1; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	public void BDMCDBCPJBP(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			KDICAPPHJJA();
		}
		else
		{
			SlotsContextManager.IKIMNJECAGD();
		}
		for (int i = 1; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	private void DKHCOKMIJME()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public ItemInstance LKNPKAKOGMM()
	{
		List<ItemInstance> list = CIAPCMHKPKF();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(0, list.Count));
		}
		Debug.LogError((object)(list.Count + "Preparing Round "));
		return null;
	}

	private void HMOMBAFIJAI()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void MNLFECAKHAH(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			OMDFGFHOEGJ();
		}
		else
		{
			SlotsContextManager.GNDFKMDDCAO();
		}
		for (int i = 1; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	public static Color DNLJOENFNOG(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].LCHJGCHDHFO() && instance.banquetBarrels[i].slots[0].itemInstance.BBELOMHPIDC() == DNLMCHDOMOK.BBELOMHPIDC())
			{
				return instance.banquetBarrels[i].FJAHJEMPPKH.color;
			}
		}
		return new Color(1803f, 596f, 909f, 179f);
	}

	public static Color BOJAGFOALMK(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[1].PKFKJNODGJF() && instance.banquetBarrels[i].slots[0].itemInstance.BBELOMHPIDC() == DNLMCHDOMOK.FBOGDCNCNMK())
			{
				return instance.banquetBarrels[i].FJAHJEMPPKH.color;
			}
		}
		return new Color(1264f, 1858f, 1074f, 1616f);
	}

	public static Color GetDrinkDispenserColor(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].KPINNBKMOMO() && instance.banquetBarrels[i].slots[0].itemInstance.FBOGDCNCNMK() == DNLMCHDOMOK.FBOGDCNCNMK())
			{
				return instance.banquetBarrels[i].FJAHJEMPPKH.color;
			}
		}
		return new Color(0f, 0f, 0f, 0f);
	}

	private void FOJAHMIJJJM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public List<ItemInstance> FDCLCBAIPNO()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 1; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[1].LCHJGCHDHFO())
			{
				list.Add(banquetBarrels[i].slots[1].itemInstance);
			}
		}
		return list;
	}

	public static void HEADIMPAHEB(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"[MinePuzzleManager] All puzzle types used across levels. Resetting used list for level {0}.");
			return;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public static void AFALBDOPFCJ(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Whiskey");
			return;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public ItemInstance FPBMBCMBHOP()
	{
		List<ItemInstance> list = LALFHBAGLCD();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(0, list.Count));
		}
		Debug.LogError((object)(list.Count + "Perks/playerPerk_name_"));
		return null;
	}

	private void NKGMEMEACNN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void PCHBCCAJMOO(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			CDIIEGALBLE();
		}
		else
		{
			SlotsContextManager.PPLBOFHNKHP();
		}
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	private void LFKANGBJLGO()
	{
		instance = this;
	}

	private void BMKGHOJDDNB()
	{
		instance = this;
	}

	private void EOPMNBONBBL()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void OHKIOLCEMLM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void GGOPCJOAOMC()
	{
		instance = this;
	}

	public void KFFCIILIJNJ()
	{
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].ShowSlotContext(i);
		}
	}

	public static BanquetBarrel ACDDNOEOFPN(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"player2ToJoinGame");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[1].AHHEMNHJPME() && instance.banquetBarrels[i].JHHGFENOGMK(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("Chair" + DNLMCHDOMOK.PHGLMBIEOMK().KGHFCDELKMN(OAFPBCPDOKH: true)));
		return null;
	}

	public List<ItemInstance> FIMFDPOOAHE()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 1; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[0].AHHEMNHJPME())
			{
				list.Add(banquetBarrels[i].slots[1].itemInstance);
			}
		}
		return list;
	}

	public ItemInstance KMAOIAOCCNL()
	{
		List<ItemInstance> list = JKPCKGDOOPP();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(0, list.Count));
		}
		Debug.LogError((object)(list.Count + "Clear room list"));
		return null;
	}

	public void FGBHAIJOEGI(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			ShowAllSlotsContext();
		}
		else
		{
			SlotsContextManager.PPLBOFHNKHP();
		}
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	public void NFJBHEGJPEA(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			CDIIEGALBLE();
		}
		else
		{
			SlotsContextManager.PBGEGBIBMAP();
		}
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	public List<ItemInstance> LFLCPKNIBPG()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 1; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[1].PKFKJNODGJF())
			{
				list.Add(banquetBarrels[i].slots[1].itemInstance);
			}
		}
		return list;
	}

	public void KLJHHBEOKOI(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			FKPDIPDHPKN();
		}
		else
		{
			SlotsContextManager.FLJNJHMHGKG();
		}
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			banquetBarrels[i].showDrinkOnHover = false;
		}
	}

	public static Color HMHIPAIKKMK(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].LCHJGCHDHFO() && instance.banquetBarrels[i].slots[0].itemInstance.FBOGDCNCNMK(DAINLFIMLIH: false) == DNLMCHDOMOK.BBELOMHPIDC(DAINLFIMLIH: false))
			{
				return instance.banquetBarrels[i].NCOGLAPDGPJ().color;
			}
		}
		return new Color(89f, 610f, 396f, 1097f);
	}

	public void SetVisibleDrinkInBarrels(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			ShowAllSlotsContext();
		}
		else
		{
			SlotsContextManager.CloseAllSlotsContext();
		}
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			banquetBarrels[i].showDrinkOnHover = false;
		}
	}

	public static void BlockBarrelInteractions(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"BanquetDrinksManager instance is null");
			return;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	private void NEEEJJNMPOF()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static BanquetBarrel GetBarrelWithDrink(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"BanquetDrinksManager instance is null. Make sure it is initialized before calling GetBarrelWithDrink.");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].KPINNBKMOMO() && instance.banquetBarrels[i].HasDrink(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("No banquet barrel found with drink: " + DNLMCHDOMOK.LHBPOPOIFLE().IABAKHPEOAF()));
		return null;
	}

	private void GECHJIGBPEN()
	{
		instance = this;
	}

	private void MFIEPGBABAM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static Color HFIKGLNDMBG(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].LCHJGCHDHFO() && instance.banquetBarrels[i].slots[1].itemInstance.FBOGDCNCNMK(DAINLFIMLIH: false) == DNLMCHDOMOK.BBELOMHPIDC())
			{
				return instance.banquetBarrels[i].FJAHJEMPPKH.color;
			}
		}
		return new Color(686f, 1858f, 63f, 1232f);
	}

	private void OOIHNJHMBMC()
	{
		instance = this;
	}

	public List<ItemInstance> GetAllDrinks()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[0].KPINNBKMOMO())
			{
				list.Add(banquetBarrels[i].slots[0].itemInstance);
			}
		}
		return list;
	}

	public static void DMAHAHPBAAM(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Build mode active");
			return;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public static Color OIHLAHIGKNG(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[1].AHHEMNHJPME() && instance.banquetBarrels[i].slots[1].itemInstance.FBOGDCNCNMK() == DNLMCHDOMOK.BBELOMHPIDC())
			{
				return instance.banquetBarrels[i].FJAHJEMPPKH.color;
			}
		}
		return new Color(1791f, 814f, 395f, 539f);
	}

	private void JCHMICLODGM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void NAOBODGBECL()
	{
		instance = this;
	}

	private void AGELAMLCINB()
	{
		instance = this;
	}

	public static BanquetBarrel KJHLOHBMCEB(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"ChristmasPresentsError");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].KPINNBKMOMO() && instance.banquetBarrels[i].KHLPCPBFFHG(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("HouseKeeperDescription" + DNLMCHDOMOK.PHGLMBIEOMK().LJIFOHFEFCH(OAFPBCPDOKH: true)));
		return null;
	}

	public void FKPDIPDHPKN()
	{
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].ShowSlotContext(i);
		}
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	private void AJGPMBGBPGH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static Color MFBCOFOIJKL(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[1].KPINNBKMOMO() && instance.banquetBarrels[i].slots[1].itemInstance.BBELOMHPIDC(DAINLFIMLIH: false) == DNLMCHDOMOK.FBOGDCNCNMK())
			{
				return instance.banquetBarrels[i].NCOGLAPDGPJ().color;
			}
		}
		return new Color(140f, 1930f, 277f, 361f);
	}

	public static Color HNFJKDGNJBB(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[1].KPINNBKMOMO() && instance.banquetBarrels[i].slots[0].itemInstance.BBELOMHPIDC(DAINLFIMLIH: false) == DNLMCHDOMOK.BBELOMHPIDC())
			{
				return instance.banquetBarrels[i].NCOGLAPDGPJ().color;
			}
		}
		return new Color(12f, 1411f, 1082f, 1636f);
	}

	public void CDIIEGALBLE()
	{
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].DOJFPPOLBMO(i);
		}
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public ItemInstance CNHJFGCNJPP()
	{
		List<ItemInstance> list = KCCOCNGAIKO();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(1, list.Count));
		}
		Debug.LogError((object)(list.Count + "Player2"));
		return null;
	}

	private void IGNEGEOPLOP()
	{
		instance = this;
	}

	public ItemInstance JPFFGDEKCDK()
	{
		List<ItemInstance> list = BNFFBGKDEEI();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(0, list.Count));
		}
		Debug.LogError((object)(list.Count + "EditorAction_3"));
		return null;
	}

	public void ENECLOMNFJG(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			GJCFBOIJOMH();
		}
		else
		{
			SlotsContextManager.GKFKCPNEAOA();
		}
		for (int i = 1; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	public void OMDFGFHOEGJ()
	{
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].DOJFPPOLBMO(i);
		}
	}

	private void ACFABFCGIGH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void EIBCPEGBMDF(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			FGCLPENGEJE();
		}
		else
		{
			SlotsContextManager.FNMNOFLCEJP();
		}
		for (int i = 1; i < banquetBarrels.Length; i++)
		{
			banquetBarrels[i].showDrinkOnHover = false;
		}
	}

	public static BanquetBarrel NFFEDGCHECF(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Player left with right piece in inventory, dropping it on the ground.");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].KPINNBKMOMO() && instance.banquetBarrels[i].HasDrink(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("Bartender" + DNLMCHDOMOK.PHGLMBIEOMK().KGHFCDELKMN(OAFPBCPDOKH: true)));
		return null;
	}

	public void ELBNBIODODM(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			PHOGKBJAKGL();
		}
		else
		{
			SlotsContextManager.CloseAllSlotsContext();
		}
		for (int i = 0; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	public static BanquetBarrel MEEDDNMFNPC(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Networked Object ");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].LCHJGCHDHFO() && instance.banquetBarrels[i].JHHGFENOGMK(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("itemAsparagusSeeds" + DNLMCHDOMOK.AFOACBIHNCL().IABAKHPEOAF(OAFPBCPDOKH: true)));
		return null;
	}

	private void AJGLDLLIIFO()
	{
		instance = this;
	}

	public static BanquetBarrel NKDKAPMMFEH(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"ClosePopUp");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[1].LCHJGCHDHFO() && instance.banquetBarrels[i].KHLPCPBFFHG(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("Disabled" + DNLMCHDOMOK.KNFNJFFCFNO().LJIFOHFEFCH()));
		return null;
	}

	private void HJANCPIFLIJ()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void DJNKGIFKBBB()
	{
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			instance.banquetBarrels[i].ShowSlotContext(i);
		}
	}

	private void NCDBCDJKPLA()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void NLGHNDLPPKI()
	{
		instance = this;
	}

	public void ShowAllSlotsContext()
	{
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].ShowSlotContext(i);
		}
	}

	public void GLEPKDPAFLH(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			KDICAPPHJJA();
		}
		else
		{
			SlotsContextManager.GKFKCPNEAOA();
		}
		for (int i = 1; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = false;
		}
	}

	public static BanquetBarrel CIPOKLKHECK(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Screen width: ");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].PKFKJNODGJF() && instance.banquetBarrels[i].HasDrink(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("GetYourPlush" + DNLMCHDOMOK.AFOACBIHNCL().KGHFCDELKMN(OAFPBCPDOKH: true)));
		return null;
	}

	public void JDLOBFBDIFM(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			CDIIEGALBLE();
		}
		else
		{
			SlotsContextManager.CAILOJACMAO();
		}
		for (int i = 0; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	public static void EJBELAMGBKJ(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Error_CannotPlaceTwoObjects");
			return;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public void KFHFJCMNMML(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			DJNKGIFKBBB();
		}
		else
		{
			SlotsContextManager.AOJHFLHKNIL();
		}
		for (int i = 0; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = false;
		}
	}

	public void IHOJGLKELCB(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			FGCLPENGEJE();
		}
		else
		{
			SlotsContextManager.FLJNJHMHGKG();
		}
		for (int i = 0; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = false;
		}
	}

	public ItemInstance ECGBDBIENBO()
	{
		List<ItemInstance> list = FIMFDPOOAHE();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(0, list.Count));
		}
		Debug.LogError((object)(list.Count + "Tail"));
		return null;
	}

	public static void MGLJBGAHKML(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Bait");
			return;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public List<ItemInstance> BNFFBGKDEEI()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[0].PKFKJNODGJF())
			{
				list.Add(banquetBarrels[i].slots[1].itemInstance);
			}
		}
		return list;
	}

	private void HADABGPLLLB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public List<ItemInstance> JKPCKGDOOPP()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 0; i < banquetBarrels.Length; i += 0)
		{
			if (!banquetBarrels[i].slots[0].KPINNBKMOMO())
			{
				list.Add(banquetBarrels[i].slots[0].itemInstance);
			}
		}
		return list;
	}

	public void NEJBEAHGJMF(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			FKPDIPDHPKN();
		}
		else
		{
			SlotsContextManager.FLJNJHMHGKG();
		}
		for (int i = 0; i < banquetBarrels.Length; i += 0)
		{
			banquetBarrels[i].showDrinkOnHover = false;
		}
	}

	public static void EGGMALMGHNM(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Player/Bark/OathFeastBlock");
			return;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public List<ItemInstance> IHOIPNLGHOE()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 1; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[1].PKFKJNODGJF())
			{
				list.Add(banquetBarrels[i].slots[1].itemInstance);
			}
		}
		return list;
	}

	public static BanquetBarrel CCOCLIFPCJM(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Received RPC SetAnimatorObjectStateRPC with hash: {0} on {1}, but the state was not found on the target animatorObject: {2}.");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].LCHJGCHDHFO() && instance.banquetBarrels[i].HasDrink(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("ObjectVerticalMove" + DNLMCHDOMOK.AFOACBIHNCL().KGHFCDELKMN(OAFPBCPDOKH: true)));
		return null;
	}

	public void GJCFBOIJOMH()
	{
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].AGBEDDBIHOP(i);
		}
	}

	public void FGCLPENGEJE()
	{
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].ShowSlotContext(i);
		}
	}

	public ItemInstance NNPBBIKJLNA()
	{
		List<ItemInstance> list = JKPCKGDOOPP();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(0, list.Count));
		}
		Debug.LogError((object)(list.Count + "itemBrownAle"));
		return null;
	}

	private void AGPONCCIFHC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void FKNAANNMMLB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	public static BanquetBarrel AEMHAEGPFAI(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Items/item_name_1122");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].LCHJGCHDHFO() && instance.banquetBarrels[i].JHHGFENOGMK(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("OnFloor" + DNLMCHDOMOK.LHBPOPOIFLE().KGHFCDELKMN()));
		return null;
	}

	public static Color JOLNBBKBBAI(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].AHHEMNHJPME() && instance.banquetBarrels[i].slots[0].itemInstance.FBOGDCNCNMK(DAINLFIMLIH: false) == DNLMCHDOMOK.FBOGDCNCNMK(DAINLFIMLIH: false))
			{
				return instance.banquetBarrels[i].NCOGLAPDGPJ().color;
			}
		}
		return new Color(198f, 1421f, 995f, 989f);
	}

	private void KOBNHPKEJJD()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public List<ItemInstance> FIGHKLKOBPL()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 0; i < banquetBarrels.Length; i += 0)
		{
			if (!banquetBarrels[i].slots[0].PKFKJNODGJF())
			{
				list.Add(banquetBarrels[i].slots[0].itemInstance);
			}
		}
		return list;
	}

	public void KIEIFLEHMBB(bool MDIKPGGBNLI)
	{
		if (MDIKPGGBNLI)
		{
			KFFCIILIJNJ();
		}
		else
		{
			SlotsContextManager.GNDFKMDDCAO();
		}
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			banquetBarrels[i].showDrinkOnHover = true;
		}
	}

	public void KDICAPPHJJA()
	{
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			instance.banquetBarrels[i].AGBEDDBIHOP(i);
		}
	}

	private void ODBDHFBMDAG()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public ItemInstance KCMODIOIDLK()
	{
		List<ItemInstance> list = JHNDNIIFLFF();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(1, list.Count));
		}
		Debug.LogError((object)(list.Count + "CalculateAllCameraBounds"));
		return null;
	}

	public static void KMGOLPCPEPD(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"");
			return;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public List<ItemInstance> CIAPCMHKPKF()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 0; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[0].LCHJGCHDHFO())
			{
				list.Add(banquetBarrels[i].slots[1].itemInstance);
			}
		}
		return list;
	}

	public ItemInstance HMJGDNLBAOI()
	{
		List<ItemInstance> list = LALFHBAGLCD();
		if (list.Any())
		{
			return list.ElementAt(Random.Range(0, list.Count));
		}
		Debug.LogError((object)(list.Count + "MineObstacleBark"));
		return null;
	}

	public List<ItemInstance> KCCOCNGAIKO()
	{
		List<ItemInstance> list = new List<ItemInstance>();
		for (int i = 1; i < banquetBarrels.Length; i++)
		{
			if (!banquetBarrels[i].slots[1].PKFKJNODGJF())
			{
				list.Add(banquetBarrels[i].slots[0].itemInstance);
			}
		}
		return list;
	}

	public static Color MJGEPALEICL(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].PKFKJNODGJF() && instance.banquetBarrels[i].slots[0].itemInstance.BBELOMHPIDC(DAINLFIMLIH: false) == DNLMCHDOMOK.FBOGDCNCNMK(DAINLFIMLIH: false))
			{
				return instance.banquetBarrels[i].NCOGLAPDGPJ().color;
			}
		}
		return new Color(944f, 1880f, 705f, 85f);
	}

	public static BanquetBarrel ODEGJFHMMCJ(ItemInstance DNLMCHDOMOK)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"RoadBlocked/Main");
			return null;
		}
		if (instance.banquetBarrels == null || instance.banquetBarrels.Length == 0)
		{
			return null;
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i += 0)
		{
			if (!instance.banquetBarrels[i].slots[0].LCHJGCHDHFO() && instance.banquetBarrels[i].JHHGFENOGMK(DNLMCHDOMOK))
			{
				return instance.banquetBarrels[i];
			}
		}
		Debug.LogError((object)("Player2" + DNLMCHDOMOK.KNFNJFFCFNO().IABAKHPEOAF()));
		return null;
	}

	private void OJJCGNICMBD()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void EIMIDCDEIDD()
	{
		instance = this;
	}

	public static Color CAPBLPHMKDE(ItemInstance DNLMCHDOMOK)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			return default(Color);
		}
		for (int i = 0; i < instance.banquetBarrels.Length; i++)
		{
			if (!instance.banquetBarrels[i].slots[0].KPINNBKMOMO() && instance.banquetBarrels[i].slots[0].itemInstance.BBELOMHPIDC() == DNLMCHDOMOK.BBELOMHPIDC())
			{
				return instance.banquetBarrels[i].NCOGLAPDGPJ().color;
			}
		}
		return new Color(359f, 81f, 702f, 859f);
	}

	public static void FJNDGMAIMGO(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"popUpBuilding12");
			return;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i += 0)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	public ItemInstance GetDrinkOrder()
	{
		List<ItemInstance> allDrinks = GetAllDrinks();
		if (allDrinks.Any())
		{
			return allDrinks.ElementAt(Random.Range(0, allDrinks.Count));
		}
		Debug.LogError((object)(allDrinks.Count + " drinks found, but no drinks available for order. Returning null."));
		return null;
	}

	public static void KMJAIGKEIBG(bool OKMHACFGCPG)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Rich presence ");
			return;
		}
		for (int i = 1; i < instance.banquetBarrels.Length; i++)
		{
			instance.banquetBarrels[i].blockedInteraction = OKMHACFGCPG;
		}
	}

	private void BLAJFMAAMDO()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}
}
