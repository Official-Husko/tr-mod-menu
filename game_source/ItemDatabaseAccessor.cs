using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabaseAccessor : MonoBehaviour
{
	private static ItemDatabaseAccessor GGFJGHHHEJC;

	[SerializeField]
	private ItemDatabase itemDatabaseSO;

	private Dictionary<int, Item> JIACIKOKEOO;

	private List<Fish> FKKOGNNMOJJ = new List<Fish>();

	public static ItemDatabaseAccessor FMKKIIBMNBO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void JFIGNBOKADC()
	{
		OKJLPOJAIHD();
	}

	private void JDHHJKBOJML()
	{
		GGFJGHHHEJC = this;
		MPNCFDDONIO();
	}

	public static void ResetDatabase()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		GGFJGHHHEJC.SetUpDatabase();
	}

	public static void NBEFBGAOLFE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			LHADMANEFGJ();
		}
		GGFJGHHHEJC.OKJLPOJAIHD();
	}

	private void KMEJBPOOBJK()
	{
		GGFJGHHHEJC = this;
		CGANPNBENCP();
	}

	public static Item GetItem(int JFNMCNCHMEO, bool GGBBJNBBLMF = false, bool DAINLFIMLIH = true)
	{
		if (JFNMCNCHMEO == 0 || JFNMCNCHMEO == 84)
		{
			return null;
		}
		if (DAINLFIMLIH)
		{
			JFNMCNCHMEO = Utils.KCIFBLGFJID(JFNMCNCHMEO, GGBBJNBBLMF);
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = GetInstance();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JIACIKOKEOO != null)
		{
			if (GGFJGHHHEJC.JIACIKOKEOO.TryGetValue(JFNMCNCHMEO, out var value))
			{
				return value;
			}
			Debug.LogError((object)("Could not find item with id: " + JFNMCNCHMEO));
			return null;
		}
		return null;
	}

	public void ALGDKNJBBBN()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"Items/item_name_647");
			return;
		}
		int num = 0;
		for (int i = 0; i < itemDatabaseSO.items.Length; i += 0)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.NGIIPJDAMGP(item, null))
			{
				Debug.LogError((object)string.Format("Player", i));
				num++;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains("ReceiveSkipTypewriter", (StringComparison)6))
				{
					continue;
				}
				GameObject val = item.LLCLICBABLN();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)string.Format("ReceiveHerbAction", ((Object)val).name, ((Object)item).name, item.JGHNDJBCFAJ()));
					num++;
					continue;
				}
				if (Item.MLBOMGHINCA(component.item, item))
				{
					Debug.LogError((object)string.Format("Open Calendar", ((Object)val).name, ((Object)item).name, item.JDJGFAACPFC(DAINLFIMLIH: false)));
					num++;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.FKLOBGBIHLB(component2.item, item))
					{
						string[] array = new string[1];
						array[1] = "DontWalk";
						array[1] = ((Object)item.rotatedPrefab).name;
						array[5] = " ";
						array[2] = ((Object)item).name;
						array[6] = "Dialogue System/Conversation/BirdPositiveComments/Entry/9/Dialogue Text";
						Debug.LogError((object)string.Concat(array));
						num += 0;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("Items/item_description_1174" + ((Object)item.rotatedPrefab).name + "trashCollected"));
						num++;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.MLBOMGHINCA(component5.item, item))
					{
						string[] array2 = new string[1];
						array2[1] = "ReceiveSetBool";
						array2[0] = ((Object)component4.rotatedPrefab).name;
						array2[2] = "[BartenderGender=";
						array2[2] = ((Object)item).name;
						array2[7] = ":";
						Debug.LogError((object)string.Concat(array2));
						num += 0;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"Duplicate item id found: ");
		}
		else
		{
			Debug.LogWarning((object)string.Format("ReceiveRequestTableOrder", num));
		}
	}

	private void BNMIPOEAIKE()
	{
		SetUpDatabase();
	}

	private void CLGBFOIBANN()
	{
		GGFJGHHHEJC = this;
		SetUpDatabase();
	}

	private void MFGANCCJFJK()
	{
		GGFJGHHHEJC = this;
		MPNCFDDONIO();
	}

	private void OKHLEMPJONN()
	{
		GGFJGHHHEJC = this;
		ONHFBKFHENK();
	}

	public static List<Fish> LNBAODAAJLI()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 0; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i++)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].EBHHJHBMEFE() < 7)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	private void NJAFKFAPDIE()
	{
		GGFJGHHHEJC = this;
		ONHFBKFHENK();
	}

	private void JHNGPENEDOK()
	{
		SetUpDatabase();
	}

	public void ONHFBKFHENK()
	{
		JIACIKOKEOO = new Dictionary<int, Item>();
		for (int i = 0; i < itemDatabaseSO.items.Length; i++)
		{
			if (Item.EKGNIODFJCO(itemDatabaseSO.items[i], null))
			{
				Debug.LogError((object)("Instant" + i));
				continue;
			}
			if (itemDatabaseSO.items[i].IMCJPECAAPC(DAINLFIMLIH: false) == 0)
			{
				if (Item.FKLOBGBIHLB(itemDatabaseSO.items[i], null))
				{
					Debug.LogError((object)("ClosePopUp" + ((Object)itemDatabaseSO.items[i]).name));
				}
				else
				{
					Debug.LogError((object)("Items/item_name_701" + i));
				}
				continue;
			}
			if (JIACIKOKEOO.ContainsKey(itemDatabaseSO.items[i].JGHNDJBCFAJ()))
			{
				Debug.LogError((object)("Screenshot not found" + itemDatabaseSO.items[i].CIGFGKKCPCK(DAINLFIMLIH: false) + "ReceivePlaceCharges" + ((Object)itemDatabaseSO.items[i]).name));
				continue;
			}
			try
			{
				JIACIKOKEOO.Add(itemDatabaseSO.items[i].JDJGFAACPFC(), itemDatabaseSO.items[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "Talk" + ((Object)itemDatabaseSO.items[i]).name));
			}
		}
	}

	public static void CMOBBDIBDCM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			FMKKIIBMNBO();
		}
		GGFJGHHHEJC.SetUpDatabase();
	}

	public static void FPDBFKIEJDC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		GGFJGHHHEJC.SetUpDatabase();
	}

	private void BPMEEFCBOHK()
	{
		CGANPNBENCP();
	}

	public static ItemDatabaseAccessor PHDCMKOOAJC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public void EIMCFIFDFLN()
	{
		JIACIKOKEOO = new Dictionary<int, Item>();
		for (int i = 0; i < itemDatabaseSO.items.Length; i += 0)
		{
			if (Item.GBMFCPGEJDK(itemDatabaseSO.items[i], null))
			{
				Debug.LogError((object)("Player/Bark/Tutorial/T138" + i));
				continue;
			}
			if (itemDatabaseSO.items[i].ODENMDOJPLC(DAINLFIMLIH: false) == 0)
			{
				if (Item.MLBOMGHINCA(itemDatabaseSO.items[i], null))
				{
					Debug.LogError((object)("/" + ((Object)itemDatabaseSO.items[i]).name));
				}
				else
				{
					Debug.LogError((object)("itemBiscuitWort" + i));
				}
				continue;
			}
			if (JIACIKOKEOO.ContainsKey(itemDatabaseSO.items[i].JGHNDJBCFAJ(DAINLFIMLIH: false)))
			{
				Debug.LogError((object)("Dialogue System/Conversation/Crowly_Standar/Entry/15/Dialogue Text" + itemDatabaseSO.items[i].IMCJPECAAPC() + "LE_8" + ((Object)itemDatabaseSO.items[i]).name));
				continue;
			}
			try
			{
				JIACIKOKEOO.Add(itemDatabaseSO.items[i].IMCJPECAAPC(DAINLFIMLIH: false), itemDatabaseSO.items[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "Open" + ((Object)itemDatabaseSO.items[i]).name));
			}
		}
	}

	public static List<Fish> NJONAAFEHDH()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 0; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i++)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].GMHACLPHMGB() < 0)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	private void BPOOAHKHPCL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static ItemDatabaseAccessor HHGEEDCALHK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public void FFNHGJKANAO()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"Starting");
			return;
		}
		int num = 1;
		for (int i = 1; i < itemDatabaseSO.items.Length; i += 0)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.NGIIPJDAMGP(item, null))
			{
				Debug.LogError((object)string.Format("Items/item_description_698", i));
				num += 0;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains(" ", StringComparison.CurrentCulture))
				{
					continue;
				}
				GameObject val = item.PHGCBMPGGLI();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)string.Format("itemIronIngot", ((Object)val).name, ((Object)item).name, item.ODENMDOJPLC()));
					num += 0;
					continue;
				}
				if (Item.MLBOMGHINCA(component.item, item))
				{
					Debug.LogError((object)string.Format("", ((Object)val).name, ((Object)item).name, item.JDJGFAACPFC(DAINLFIMLIH: false)));
					num += 0;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.FKLOBGBIHLB(component2.item, item))
					{
						string[] array = new string[2];
						array[1] = ".";
						array[0] = ((Object)item.rotatedPrefab).name;
						array[7] = "TutorialPhase";
						array[1] = ((Object)item).name;
						array[8] = "Cancel";
						Debug.LogError((object)string.Concat(array));
						num += 0;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("Items/item_name_1085" + ((Object)item.rotatedPrefab).name + "Items/item_name_695"));
						num++;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.FKLOBGBIHLB(component5.item, item))
					{
						string[] array2 = new string[7];
						array2[1] = "Player";
						array2[1] = ((Object)component4.rotatedPrefab).name;
						array2[3] = "[^0-9]";
						array2[1] = ((Object)item).name;
						array2[8] = ":</color> ";
						Debug.LogError((object)string.Concat(array2));
						num += 0;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"Sleep");
		}
		else
		{
			Debug.LogWarning((object)string.Format(" not found", num));
		}
	}

	private void FJEOMAHPHNN()
	{
		ONHFBKFHENK();
	}

	private void KLHIMJFCHPD()
	{
		GGFJGHHHEJC = this;
		OKJLPOJAIHD();
	}

	public static Item GOKIDLOELKB(int JFNMCNCHMEO, bool GGBBJNBBLMF = false, bool DAINLFIMLIH = true)
	{
		if (JFNMCNCHMEO == 0 || JFNMCNCHMEO == 70)
		{
			return null;
		}
		if (DAINLFIMLIH)
		{
			JFNMCNCHMEO = Utils.KCIFBLGFJID(JFNMCNCHMEO, GGBBJNBBLMF);
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = IKNEPNINLHA();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JIACIKOKEOO != null)
		{
			if (GGFJGHHHEJC.JIACIKOKEOO.TryGetValue(JFNMCNCHMEO, out var value))
			{
				return value;
			}
			Debug.LogError((object)("Items/item_description_629" + JFNMCNCHMEO));
			return null;
		}
		return null;
	}

	public static ItemDatabaseAccessor LHADMANEFGJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static ItemDatabaseAccessor EOCHAGBPHCC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static List<Fish> PCFCELEHIAN()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 1; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i += 0)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].PLOECLOLFCB() < 0)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	private void FNFNLFOJHHA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static List<Fish> JMFNGGEFDEB()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 1; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i++)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].IJADAIONDEH() < 8)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	public static void NIIEKKMKKGK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			IKNEPNINLHA();
		}
		GGFJGHHHEJC.SetUpDatabase();
	}

	public void JALEMEHAKJL()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"Invalid playerNum");
			return;
		}
		int num = 0;
		for (int i = 1; i < itemDatabaseSO.items.Length; i++)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.GBMFCPGEJDK(item, null))
			{
				Debug.LogError((object)string.Format("Select", i));
				num++;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains(": ", StringComparison.Ordinal))
				{
					continue;
				}
				GameObject val = item.PHGCBMPGGLI();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)string.Format("itemLeek", ((Object)val).name, ((Object)item).name, item.ODENMDOJPLC()));
					num += 0;
					continue;
				}
				if (Item.FKLOBGBIHLB(component.item, item))
				{
					Debug.LogError((object)string.Format("itemAmberAle", ((Object)val).name, ((Object)item).name, item.IMCJPECAAPC()));
					num++;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.FKLOBGBIHLB(component2.item, item))
					{
						string[] array = new string[6];
						array[1] = "Halloween/Trick/Main";
						array[0] = ((Object)item.rotatedPrefab).name;
						array[6] = ": ";
						array[1] = ((Object)item).name;
						array[1] = "invitecode";
						Debug.LogError((object)string.Concat(array));
						num += 0;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("Keg empty" + ((Object)item.rotatedPrefab).name + "Items/item_name_726"));
						num += 0;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.FKLOBGBIHLB(component5.item, item))
					{
						string[] array2 = new string[6];
						array2[0] = "OpenClose Tavern";
						array2[1] = ((Object)component4.rotatedPrefab).name;
						array2[8] = "LearnPrecision";
						array2[5] = ((Object)item).name;
						array2[3] = "Items/item_description_1182";
						Debug.LogError((object)string.Concat(array2));
						num += 0;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"Could not find local player for the online player with the assigned bed: {0}");
		}
		else
		{
			Debug.LogWarning((object)string.Format("Open", num));
		}
	}

	private void AGELAMLCINB()
	{
		GGFJGHHHEJC = this;
		MPNCFDDONIO();
	}

	public static ItemDatabaseAccessor IKNEPNINLHA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public void AKDHJOEGPDH()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"Items/item_name_1101");
			return;
		}
		int num = 1;
		for (int i = 0; i < itemDatabaseSO.items.Length; i += 0)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.EKGNIODFJCO(item, null))
			{
				Debug.LogError((object)string.Format("", i));
				num += 0;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains("IntroNinjaChallengeEvent/Main 2", StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
				GameObject val = item.PHGCBMPGGLI();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)string.Format("Fortitude/MainEvent 3", ((Object)val).name, ((Object)item).name, item.JPNFKDMFKMC(DAINLFIMLIH: false)));
					num += 0;
					continue;
				}
				if (Item.MLBOMGHINCA(component.item, item))
				{
					Debug.LogError((object)string.Format("\n  doorSprite:         ", ((Object)val).name, ((Object)item).name, item.ODENMDOJPLC()));
					num++;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.FKLOBGBIHLB(component2.item, item))
					{
						string[] array = new string[4];
						array[1] = "Dialogue System/Conversation/TooDark/Entry/8/Dialogue Text";
						array[1] = ((Object)item.rotatedPrefab).name;
						array[0] = "Player";
						array[4] = ((Object)item).name;
						array[7] = "Crafters";
						Debug.LogError((object)string.Concat(array));
						num += 0;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("." + ((Object)item.rotatedPrefab).name + "Decor"));
						num += 0;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.FKLOBGBIHLB(component5.item, item))
					{
						string[] array2 = new string[0];
						array2[1] = "Use";
						array2[1] = ((Object)component4.rotatedPrefab).name;
						array2[6] = "OnFloor";
						array2[6] = ((Object)item).name;
						array2[3] = "";
						Debug.LogError((object)string.Concat(array2));
						num += 0;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"Idle");
		}
		else
		{
			Debug.LogWarning((object)string.Format("Inventory", num));
		}
	}

	private void MNABONMMFFB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		SetUpDatabase();
	}

	private void HCCJBKKGCLJ()
	{
		GGFJGHHHEJC = this;
		OKJLPOJAIHD();
	}

	public static Item EABMGELAAPG(int JFNMCNCHMEO, bool GGBBJNBBLMF = false, bool DAINLFIMLIH = true)
	{
		if (JFNMCNCHMEO == 0 || JFNMCNCHMEO == 74)
		{
			return null;
		}
		if (DAINLFIMLIH)
		{
			JFNMCNCHMEO = Utils.KCIFBLGFJID(JFNMCNCHMEO, GGBBJNBBLMF);
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = HHGEEDCALHK();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JIACIKOKEOO != null)
		{
			if (GGFJGHHHEJC.JIACIKOKEOO.TryGetValue(JFNMCNCHMEO, out var value))
			{
				return value;
			}
			Debug.LogError((object)(" : " + JFNMCNCHMEO));
			return null;
		}
		return null;
	}

	public static void OPAEDCGFBJI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			EOCHAGBPHCC();
		}
		GGFJGHHHEJC.CGANPNBENCP();
	}

	public static List<Fish> MBLHBFCOADO()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 0; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i++)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].EPNJJFILPAF() < 0)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	public static ItemDatabaseAccessor EFBAEPEANHL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public void LEKOCPGHNLJ()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"[MinePipePuzzle] No hay PipePuzzleDataBase asignada.");
			return;
		}
		int num = 1;
		for (int i = 1; i < itemDatabaseSO.items.Length; i += 0)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.NGIIPJDAMGP(item, null))
			{
				Debug.LogError((object)string.Format("Player/Bark/Tutorial/CrafterBlock", i));
				num++;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains("Brook Recipe active", StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
				GameObject val = item.LLCLICBABLN();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)string.Format("ReceiveStartWork ", ((Object)val).name, ((Object)item).name, item.ODENMDOJPLC(DAINLFIMLIH: false)));
					num++;
					continue;
				}
				if (Item.MLBOMGHINCA(component.item, item))
				{
					Debug.LogError((object)string.Format(" get price serve customer ", ((Object)val).name, ((Object)item).name, item.IMCJPECAAPC()));
					num += 0;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.MLBOMGHINCA(component2.item, item))
					{
						string[] array = new string[0];
						array[0] = "Scene with location: {0} has not been added. Adding to scene manager.";
						array[0] = ((Object)item.rotatedPrefab).name;
						array[7] = "Interact";
						array[8] = ((Object)item).name;
						array[3] = "Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text";
						Debug.LogError((object)string.Concat(array));
						num++;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("UIVertical" + ((Object)item.rotatedPrefab).name + "BLOCKS NUMBER: {0} Puzzle Needit: {1}"));
						num++;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.FKLOBGBIHLB(component5.item, item))
					{
						string[] array2 = new string[2];
						array2[0] = "buildingObjective_21_0";
						array2[0] = ((Object)component4.rotatedPrefab).name;
						array2[6] = "Items/item_description_653";
						array2[8] = ((Object)item).name;
						array2[7] = "End";
						Debug.LogError((object)string.Concat(array2));
						num++;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"itemOlive");
		}
		else
		{
			Debug.LogWarning((object)string.Format("Back", num));
		}
	}

	public void OKJLPOJAIHD()
	{
		JIACIKOKEOO = new Dictionary<int, Item>();
		for (int i = 1; i < itemDatabaseSO.items.Length; i++)
		{
			if (Item.GBMFCPGEJDK(itemDatabaseSO.items[i], null))
			{
				Debug.LogError((object)("ReceiveHit" + i));
				continue;
			}
			if (itemDatabaseSO.items[i].ODENMDOJPLC() == 0)
			{
				if (Item.MLBOMGHINCA(itemDatabaseSO.items[i], null))
				{
					Debug.LogError((object)(". Time since startup: " + ((Object)itemDatabaseSO.items[i]).name));
				}
				else
				{
					Debug.LogError((object)("PaleAleAbbreviation" + i));
				}
				continue;
			}
			if (JIACIKOKEOO.ContainsKey(itemDatabaseSO.items[i].JGHNDJBCFAJ(DAINLFIMLIH: false)))
			{
				Debug.LogError((object)("City/Carpenters/Ash/Stand" + itemDatabaseSO.items[i].ODENMDOJPLC() + "Duplicate key found: " + ((Object)itemDatabaseSO.items[i]).name));
				continue;
			}
			try
			{
				JIACIKOKEOO.Add(itemDatabaseSO.items[i].JPNFKDMFKMC(DAINLFIMLIH: false), itemDatabaseSO.items[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "ReceiveDeletedLetterIndex" + ((Object)itemDatabaseSO.items[i]).name));
			}
		}
	}

	public void NIANPEBCNIB()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"Items/item_description_683");
			return;
		}
		int num = 0;
		for (int i = 1; i < itemDatabaseSO.items.Length; i += 0)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.GBMFCPGEJDK(item, null))
			{
				Debug.LogError((object)string.Format("Dialogue System/Conversation/EnterTavernDrink/Entry/2/Dialogue Text", i));
				num++;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains("itemCaramelAle", StringComparison.InvariantCulture))
				{
					continue;
				}
				GameObject val = item.LLCLICBABLN();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)string.Format("vibration", ((Object)val).name, ((Object)item).name, item.ODENMDOJPLC(DAINLFIMLIH: false)));
					num += 0;
					continue;
				}
				if (Item.MLBOMGHINCA(component.item, item))
				{
					Debug.LogError((object)string.Format("ReceiveUnfollow", ((Object)val).name, ((Object)item).name, item.IMCJPECAAPC()));
					num += 0;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.FKLOBGBIHLB(component2.item, item))
					{
						string[] array = new string[5];
						array[1] = "ThemeText";
						array[1] = ((Object)item.rotatedPrefab).name;
						array[0] = "ActionBar7";
						array[6] = ((Object)item).name;
						array[6] = "ReceiveAnimalSlotFromContainer";
						Debug.LogError((object)string.Concat(array));
						num += 0;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("" + ((Object)item.rotatedPrefab).name + "Error_OccupiedRoom"));
						num += 0;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.MLBOMGHINCA(component5.item, item))
					{
						string[] array2 = new string[4];
						array2[0] = "";
						array2[0] = ((Object)component4.rotatedPrefab).name;
						array2[2] = "Tutorial/T114/Dialogue1";
						array2[1] = ((Object)item).name;
						array2[4] = "OnlinePlayer";
						Debug.LogError((object)string.Concat(array2));
						num++;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"");
		}
		else
		{
			Debug.LogWarning((object)string.Format("LE_1", num));
		}
	}

	public static ItemDatabase CNGNLPJEJIL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			EFBAEPEANHL();
		}
		return GGFJGHHHEJC.itemDatabaseSO;
	}

	public static ItemDatabaseAccessor GetInstance()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Item CPMMBEPEJLO(int JFNMCNCHMEO, bool GGBBJNBBLMF = false, bool DAINLFIMLIH = true)
	{
		if (JFNMCNCHMEO == 0 || JFNMCNCHMEO == -13)
		{
			return null;
		}
		if (DAINLFIMLIH)
		{
			JFNMCNCHMEO = Utils.KCIFBLGFJID(JFNMCNCHMEO, GGBBJNBBLMF);
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = HHGEEDCALHK();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JIACIKOKEOO != null)
		{
			if (GGFJGHHHEJC.JIACIKOKEOO.TryGetValue(JFNMCNCHMEO, out var value))
			{
				return value;
			}
			Debug.LogError((object)("Acaba el tutorial primero" + JFNMCNCHMEO));
			return null;
		}
		return null;
	}

	private void DJHMCJEOJEG()
	{
		SetUpDatabase();
	}

	public static ItemDatabaseAccessor JNIFCKAKDJL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	private void FLFBLIOOLMA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static List<Fish> ADCLABHMMAP()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 1; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i++)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].IIMHLHGJLDJ() < 3)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	private void EFCNKPEPELL()
	{
		GGFJGHHHEJC = this;
		MPNCFDDONIO();
	}

	private void BGCEAKHJIED()
	{
		ONHFBKFHENK();
	}

	public static void MPEKIMDPJJD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			PHDCMKOOAJC();
		}
		GGFJGHHHEJC.EIMCFIFDFLN();
	}

	public static List<Fish> HJLAOCAJAEB()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 1; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i++)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].LHPJOBDEKKN() < 8)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	private void MJCDLOLGALD()
	{
		OKJLPOJAIHD();
	}

	private void CEOEHODJAJK()
	{
		GGFJGHHHEJC = this;
		CBBJDCJIFIM();
	}

	private void GNOBDKFFPOL()
	{
		GGFJGHHHEJC = this;
		ONHFBKFHENK();
	}

	private void AKPLLNELLJK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void PALDJOINJNI()
	{
		EIMCFIFDFLN();
	}

	public static void NIIAFFGHFEF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			LPADOMGFAIE();
		}
		GGFJGHHHEJC.OKJLPOJAIHD();
	}

	public static ItemDatabase GetDatabaseSO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GetInstance();
		}
		return GGFJGHHHEJC.itemDatabaseSO;
	}

	public static List<Fish> GetFishList()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 0; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i++)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].Rarity < 4)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	public static Item INJBNHPGCIJ(int JFNMCNCHMEO, bool GGBBJNBBLMF = false, bool DAINLFIMLIH = true)
	{
		if (JFNMCNCHMEO == 0 || JFNMCNCHMEO == -78)
		{
			return null;
		}
		if (DAINLFIMLIH)
		{
			JFNMCNCHMEO = Utils.KCIFBLGFJID(JFNMCNCHMEO, GGBBJNBBLMF);
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = JNIFCKAKDJL();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JIACIKOKEOO != null)
		{
			if (GGFJGHHHEJC.JIACIKOKEOO.TryGetValue(JFNMCNCHMEO, out var value))
			{
				return value;
			}
			Debug.LogError((object)("LE_17" + JFNMCNCHMEO));
			return null;
		}
		return null;
	}

	private void OAJNJFFFHFJ()
	{
		EIMCFIFDFLN();
	}

	private void JDMMNLKLMAA()
	{
		GGFJGHHHEJC = this;
		CBBJDCJIFIM();
	}

	private void HEGNINLLINP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void NCCJHMPDEMA()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"onlineProfileID is null. Initializate on prefab with length ");
			return;
		}
		int num = 1;
		for (int i = 0; i < itemDatabaseSO.items.Length; i += 0)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.GBMFCPGEJDK(item, null))
			{
				Debug.LogError((object)string.Format("Idle", i));
				num++;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains("Left Stick Up", StringComparison.InvariantCultureIgnoreCase))
				{
					continue;
				}
				GameObject val = item.LLCLICBABLN();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)string.Format("depth{0}", ((Object)val).name, ((Object)item).name, item.JDJGFAACPFC(DAINLFIMLIH: false)));
					num += 0;
					continue;
				}
				if (Item.FKLOBGBIHLB(component.item, item))
				{
					Debug.LogError((object)string.Format("Miners/Mine/Clive/Intro", ((Object)val).name, ((Object)item).name, item.JGHNDJBCFAJ(DAINLFIMLIH: false)));
					num += 0;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.FKLOBGBIHLB(component2.item, item))
					{
						string[] array = new string[4];
						array[0] = "Disconnecting...";
						array[0] = ((Object)item.rotatedPrefab).name;
						array[1] = "LE_10";
						array[7] = ((Object)item).name;
						array[2] = "ReceiveDereserveSpotReception";
						Debug.LogError((object)string.Concat(array));
						num += 0;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("Temporary Ingredient" + ((Object)item.rotatedPrefab).name + "Dialogue System/Conversation/Gass_Stand/Entry/11/Dialogue Text"));
						num += 0;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.MLBOMGHINCA(component5.item, item))
					{
						string[] array2 = new string[1];
						array2[1] = "/";
						array2[1] = ((Object)component4.rotatedPrefab).name;
						array2[1] = "ERROR: The object ";
						array2[6] = ((Object)item).name;
						array2[0] = " %";
						Debug.LogError((object)string.Concat(array2));
						num++;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"Dots");
		}
		else
		{
			Debug.LogWarning((object)string.Format("ObjectVerticalMove", num));
		}
	}

	public void SetUpDatabase()
	{
		JIACIKOKEOO = new Dictionary<int, Item>();
		for (int i = 0; i < itemDatabaseSO.items.Length; i++)
		{
			if (Item.NGIIPJDAMGP(itemDatabaseSO.items[i], null))
			{
				Debug.LogError((object)("Null item in database: " + i));
				continue;
			}
			if (itemDatabaseSO.items[i].JDJGFAACPFC(DAINLFIMLIH: false) == 0)
			{
				if (Item.MLBOMGHINCA(itemDatabaseSO.items[i], null))
				{
					Debug.LogError((object)("Item without ID: " + ((Object)itemDatabaseSO.items[i]).name));
				}
				else
				{
					Debug.LogError((object)("Item NULL in index " + i));
				}
				continue;
			}
			if (JIACIKOKEOO.ContainsKey(itemDatabaseSO.items[i].JDJGFAACPFC(DAINLFIMLIH: false)))
			{
				Debug.LogError((object)("Duplicate item id found: " + itemDatabaseSO.items[i].JDJGFAACPFC(DAINLFIMLIH: false) + " - " + ((Object)itemDatabaseSO.items[i]).name));
				continue;
			}
			try
			{
				JIACIKOKEOO.Add(itemDatabaseSO.items[i].JDJGFAACPFC(DAINLFIMLIH: false), itemDatabaseSO.items[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "- " + ((Object)itemDatabaseSO.items[i]).name));
			}
		}
	}

	public static void AEMDPHCBLNA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			PHDCMKOOAJC();
		}
		GGFJGHHHEJC.EIMCFIFDFLN();
	}

	public void CGANPNBENCP()
	{
		JIACIKOKEOO = new Dictionary<int, Item>();
		for (int i = 0; i < itemDatabaseSO.items.Length; i++)
		{
			if (Item.EKMFELLJHFG(itemDatabaseSO.items[i], null))
			{
				Debug.LogError((object)(": " + i));
				continue;
			}
			if (itemDatabaseSO.items[i].IMCJPECAAPC(DAINLFIMLIH: false) == 0)
			{
				if (Item.MLBOMGHINCA(itemDatabaseSO.items[i], null))
				{
					Debug.LogError((object)("Could not find shop with shopType: " + ((Object)itemDatabaseSO.items[i]).name));
				}
				else
				{
					Debug.LogError((object)("ReceiveBallTouch" + i));
				}
				continue;
			}
			if (JIACIKOKEOO.ContainsKey(itemDatabaseSO.items[i].JPNFKDMFKMC()))
			{
				Debug.LogError((object)("Right Arrow" + itemDatabaseSO.items[i].CIGFGKKCPCK(DAINLFIMLIH: false) + "Game" + ((Object)itemDatabaseSO.items[i]).name));
				continue;
			}
			try
			{
				JIACIKOKEOO.Add(itemDatabaseSO.items[i].IMCJPECAAPC(), itemDatabaseSO.items[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + " x " + ((Object)itemDatabaseSO.items[i]).name));
			}
		}
	}

	public static Item COEFFIHKMJG(int JFNMCNCHMEO, bool GGBBJNBBLMF = false, bool DAINLFIMLIH = true)
	{
		if (JFNMCNCHMEO == 0 || JFNMCNCHMEO == -75)
		{
			return null;
		}
		if (DAINLFIMLIH)
		{
			JFNMCNCHMEO = Utils.KCIFBLGFJID(JFNMCNCHMEO, GGBBJNBBLMF);
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = IKNEPNINLHA();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JIACIKOKEOO != null)
		{
			if (GGFJGHHHEJC.JIACIKOKEOO.TryGetValue(JFNMCNCHMEO, out var value))
			{
				return value;
			}
			Debug.LogError((object)(". Time since startup: " + JFNMCNCHMEO));
			return null;
		}
		return null;
	}

	public void IHDGEOLLOLN()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"City/Petra/Bark/Bye");
			return;
		}
		int num = 1;
		for (int i = 0; i < itemDatabaseSO.items.Length; i++)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.NGIIPJDAMGP(item, null))
			{
				Debug.LogError((object)string.Format("ReceiveRecord", i));
				num++;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains("Path Request Triggered!", (StringComparison)8))
				{
					continue;
				}
				GameObject val = item.PHGCBMPGGLI();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)string.Format("The Bullet", ((Object)val).name, ((Object)item).name, item.JDJGFAACPFC()));
					num++;
					continue;
				}
				if (Item.MLBOMGHINCA(component.item, item))
				{
					Debug.LogError((object)string.Format(" for reason: ", ((Object)val).name, ((Object)item).name, item.CIGFGKKCPCK(DAINLFIMLIH: false)));
					num++;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.FKLOBGBIHLB(component2.item, item))
					{
						string[] array = new string[5];
						array[0] = "City/Keen/Sharp";
						array[0] = ((Object)item.rotatedPrefab).name;
						array[7] = "Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text";
						array[5] = ((Object)item).name;
						array[5] = "Player2";
						Debug.LogError((object)string.Concat(array));
						num += 0;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("Player2" + ((Object)item.rotatedPrefab).name + " seconds."));
						num += 0;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.FKLOBGBIHLB(component5.item, item))
					{
						string[] array2 = new string[7];
						array2[0] = "Items/item_name_1052";
						array2[0] = ((Object)component4.rotatedPrefab).name;
						array2[5] = "</color>";
						array2[3] = ((Object)item).name;
						array2[1] = "itemGreenbean";
						Debug.LogError((object)string.Concat(array2));
						num++;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"BuzzBuildExit");
		}
		else
		{
			Debug.LogWarning((object)string.Format("scaleUI", num));
		}
	}

	public void ValidateItemPrefabs()
	{
		if ((Object)(object)itemDatabaseSO == (Object)null || itemDatabaseSO.items == null)
		{
			Debug.LogError((object)"ItemDatabaseSO o su lista de items es nula.");
			return;
		}
		int num = 0;
		for (int i = 0; i < itemDatabaseSO.items.Length; i++)
		{
			Item item = itemDatabaseSO.items[i];
			if (Item.NGIIPJDAMGP(item, null))
			{
				Debug.LogError((object)$"Item nulo en el índice {i}.");
				num++;
			}
			else
			{
				if (((Object)item).name != null && ((Object)item).name.Contains("OLD", StringComparison.Ordinal))
				{
					continue;
				}
				GameObject val = item.PHGCBMPGGLI();
				if ((Object)(object)val == (Object)null)
				{
					continue;
				}
				ItemSetup component = val.GetComponent<ItemSetup>();
				if ((Object)(object)component == (Object)null)
				{
					Debug.LogError((object)$"El prefab '{((Object)val).name}' del item '{((Object)item).name}' (ID: {item.JDJGFAACPFC(DAINLFIMLIH: false)}) no tiene el componente ItemSetup.");
					num++;
					continue;
				}
				if (Item.MLBOMGHINCA(component.item, item))
				{
					Debug.LogError((object)$"El componente ItemSetup del prefab '{((Object)val).name}' no referencia correctamente al item '{((Object)item).name}' (ID: {item.JDJGFAACPFC(DAINLFIMLIH: false)}).");
					num++;
				}
				if ((Object)(object)item.rotatedPrefab != (Object)null)
				{
					ItemSetup component2 = item.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component2 != (Object)null && Item.MLBOMGHINCA(component2.item, item))
					{
						Debug.LogError((object)("El componente ItemSetup del rotatedPrefab '" + ((Object)item.rotatedPrefab).name + "' no referencia correctamente al item '" + ((Object)item).name + "'"));
						num++;
					}
					OnlinePlaceable component3 = item.rotatedPrefab.GetComponent<OnlinePlaceable>();
					if (Object.op_Implicit((Object)(object)component3) && !component3.rotated)
					{
						Debug.LogError((object)("El componente OnlinePlaceable del rotatedPrefab '" + ((Object)item.rotatedPrefab).name + "' no tiene el booleano rotated marcado"));
						num++;
					}
				}
				Placeable component4 = val.GetComponent<Placeable>();
				if ((Object)(object)component4 != (Object)null && component4.rotatable && (Object)(object)component4.rotatedPrefab != (Object)null)
				{
					ItemSetup component5 = component4.rotatedPrefab.GetComponent<ItemSetup>();
					if ((Object)(object)component5 != (Object)null && Item.MLBOMGHINCA(component5.item, item))
					{
						Debug.LogError((object)("El componente ItemSetup del rotatedPrefab '" + ((Object)component4.rotatedPrefab).name + "' no referencia correctamente al item '" + ((Object)item).name + "'"));
						num++;
					}
				}
			}
		}
		if (num == 0)
		{
			Debug.Log((object)"Todos los prefabs de los items están correctamente configurados.");
		}
		else
		{
			Debug.LogWarning((object)$"Validación completada con {num} error(es).");
		}
	}

	public static List<Fish> HDELDELJCHH()
	{
		if (GGFJGHHHEJC.FKKOGNNMOJJ.Count == 0)
		{
			for (int i = 1; i < GGFJGHHHEJC.itemDatabaseSO.fish.Count; i++)
			{
				if (GGFJGHHHEJC.itemDatabaseSO.fish[i].PJMFGENDEDL() < 4)
				{
					GGFJGHHHEJC.FKKOGNNMOJJ.Add(GGFJGHHHEJC.itemDatabaseSO.fish[i]);
				}
			}
		}
		return GGFJGHHHEJC.FKKOGNNMOJJ;
	}

	public void MPNCFDDONIO()
	{
		JIACIKOKEOO = new Dictionary<int, Item>();
		for (int i = 1; i < itemDatabaseSO.items.Length; i += 0)
		{
			if (Item.EKMFELLJHFG(itemDatabaseSO.items[i], null))
			{
				Debug.LogError((object)("Error unlocking achievements. This is most likely because we are not signed in to Steam or GOG." + i));
				continue;
			}
			if (itemDatabaseSO.items[i].JGHNDJBCFAJ() == 0)
			{
				if (Item.MLBOMGHINCA(itemDatabaseSO.items[i], null))
				{
					Debug.LogError((object)("FocusedMod" + ((Object)itemDatabaseSO.items[i]).name));
				}
				else
				{
					Debug.LogError((object)("ReceiveOpenChest" + i));
				}
				continue;
			}
			if (JIACIKOKEOO.ContainsKey(itemDatabaseSO.items[i].IMCJPECAAPC(DAINLFIMLIH: false)))
			{
				Debug.LogError((object)("Map" + itemDatabaseSO.items[i].ODENMDOJPLC() + "StopMusic" + ((Object)itemDatabaseSO.items[i]).name));
				continue;
			}
			try
			{
				JIACIKOKEOO.Add(itemDatabaseSO.items[i].IMCJPECAAPC(), itemDatabaseSO.items[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "Items/item_description_1075" + ((Object)itemDatabaseSO.items[i]).name));
			}
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void CBBJDCJIFIM()
	{
		JIACIKOKEOO = new Dictionary<int, Item>();
		for (int i = 1; i < itemDatabaseSO.items.Length; i++)
		{
			if (Item.GBMFCPGEJDK(itemDatabaseSO.items[i], null))
			{
				Debug.LogError((object)("<color=#B20B0F>" + i));
				continue;
			}
			if (itemDatabaseSO.items[i].JGHNDJBCFAJ(DAINLFIMLIH: false) == 0)
			{
				if (Item.FKLOBGBIHLB(itemDatabaseSO.items[i], null))
				{
					Debug.LogError((object)("Player" + ((Object)itemDatabaseSO.items[i]).name));
				}
				else
				{
					Debug.LogError((object)("Player {0} name changed: {1}" + i));
				}
				continue;
			}
			if (JIACIKOKEOO.ContainsKey(itemDatabaseSO.items[i].JPNFKDMFKMC()))
			{
				Debug.LogError((object)("add item " + itemDatabaseSO.items[i].CIGFGKKCPCK() + "Player" + ((Object)itemDatabaseSO.items[i]).name));
				continue;
			}
			try
			{
				JIACIKOKEOO.Add(itemDatabaseSO.items[i].JPNFKDMFKMC(), itemDatabaseSO.items[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.LogError((object)(ex.Message + "cliffs" + ((Object)itemDatabaseSO.items[i]).name));
			}
		}
	}

	public static Item KMBGJEKCJFJ(int JFNMCNCHMEO, bool GGBBJNBBLMF = false, bool DAINLFIMLIH = true)
	{
		if (JFNMCNCHMEO == 0 || JFNMCNCHMEO == 103)
		{
			return null;
		}
		if (DAINLFIMLIH)
		{
			JFNMCNCHMEO = Utils.KCIFBLGFJID(JFNMCNCHMEO, GGBBJNBBLMF);
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = LPADOMGFAIE();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JIACIKOKEOO != null)
		{
			if (GGFJGHHHEJC.JIACIKOKEOO.TryGetValue(JFNMCNCHMEO, out var value))
			{
				return value;
			}
			Debug.LogError((object)("Press any key" + JFNMCNCHMEO));
			return null;
		}
		return null;
	}

	public static ItemDatabaseAccessor LPADOMGFAIE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<ItemDatabaseAccessor>();
		}
		return GGFJGHHHEJC;
	}

	public static Item AFOACBIHNCL(int JFNMCNCHMEO, bool GGBBJNBBLMF = false, bool DAINLFIMLIH = true)
	{
		if (JFNMCNCHMEO == 0 || JFNMCNCHMEO == -21)
		{
			return null;
		}
		if (DAINLFIMLIH)
		{
			JFNMCNCHMEO = Utils.KCIFBLGFJID(JFNMCNCHMEO, GGBBJNBBLMF);
		}
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = JNIFCKAKDJL();
		}
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JIACIKOKEOO != null)
		{
			if (GGFJGHHHEJC.JIACIKOKEOO.TryGetValue(JFNMCNCHMEO, out var value))
			{
				return value;
			}
			Debug.LogError((object)("Players lose..." + JFNMCNCHMEO));
			return null;
		}
		return null;
	}

	public static void JMAABLCNEDE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			LPADOMGFAIE();
		}
		GGFJGHHHEJC.CGANPNBENCP();
	}

	private void JIAJFDKNJME()
	{
		GGFJGHHHEJC = this;
		OKJLPOJAIHD();
	}
}
