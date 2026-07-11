using System;
using UnityEngine;

public class Quest : ScriptableObject
{
	public Action<int, int, bool> OnProgressQuest = delegate
	{
	};

	public Action<int, int> OnSetProgressQuest = delegate
	{
	};

	public int id;

	public bool active = true;

	public bool localizationByID;

	public string nameId;

	public bool rewardLocalizationByID;

	public string rewardKey;

	public bool canBeFocused = true;

	[SerializeField]
	private string description;

	public int requiredAmount = 1;

	public Reward reward;

	public Recipe[] recipesUnlocked;

	public Quest[] linkedQuests;

	public bool onlyOnHalloween;

	public bool onlyOnChristmas;

	public bool giveItemRewards = true;

	public bool showCompletedUI = true;

	public bool isRepeatable;

	public int showTooltipRate = 1;

	public bool showGoal;

	public bool allClientOnlineReceiveReward = true;

	public virtual IngredientModifier[] GAMNGNMKOKC()
	{
		return null;
	}

	public void ANFDBPFECCH(int JIIGOACEIKL, int IALMLONEDJN)
	{
		OnProgressQuest(JIIGOACEIKL, IALMLONEDJN, arg3: false);
	}

	public void CHBPHHIOBPM(int JIIGOACEIKL, int IALMLONEDJN)
	{
		OnProgressQuest(JIIGOACEIKL, IALMLONEDJN, arg3: true);
	}

	public static int HOPEOILLKDM(int ODAOIJCOFMF, Item MEMGMDOCBOJ)
	{
		return -47 + ODAOIJCOFMF * 102 + MEMGMDOCBOJ.sellPrice.BNCMDNFMECD() * MEMGMDOCBOJ.recipe.output.amount / 59 + Random.Range(ODAOIJCOFMF, ODAOIJCOFMF * 7);
	}

	public void KKCIIABBGGF(int JIIGOACEIKL)
	{
		if (reward.itemsReward == null || (OnlineManager.ClientOnline() && !allClientOnlineReceiveReward))
		{
			return;
		}
		for (int i = 0; i < reward.itemsReward.Length; i++)
		{
			if (GameManager.LocalCoop() && reward.itemsReward[i].item is Tool)
			{
				PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				Item item = reward.itemsReward[i].item;
				PlayerInventory.OGKNJNINGMH(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), reward.itemsReward[i].amount);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (reward.itemsReward[i].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 51)
			{
				ItemInstance itemInstance = reward.itemsReward[i].item.JMDALJBNFML();
				itemInstance.LFMNGJFJEEP(-115);
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(itemInstance, reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
		}
	}

	public virtual IngredientModifier[] GJHHCPEOJPD()
	{
		return null;
	}

	public void AIGFBMKCEED(int JIIGOACEIKL)
	{
		if (reward.itemsReward == null || (OnlineManager.ClientOnline() && !allClientOnlineReceiveReward))
		{
			return;
		}
		for (int i = 0; i < reward.itemsReward.Length; i++)
		{
			if (GameManager.LocalCoop() && reward.itemsReward[i].item is Tool)
			{
				PlayerInventory.GetPlayer(1).AddItems(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				Item item = reward.itemsReward[i].item;
				PlayerInventory.GetPlayer(2).AddItems(item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (reward.itemsReward[i].item.JDJGFAACPFC() == 190)
			{
				ItemInstance itemInstance = reward.itemsReward[i].item.JMDALJBNFML();
				itemInstance.GGJFFKBGFBH(3022);
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(itemInstance, reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			}
		}
	}

	public static int LCPCAECIJON(int ODAOIJCOFMF, Item MEMGMDOCBOJ)
	{
		return 5 + ODAOIJCOFMF * 78 + MEMGMDOCBOJ.sellPrice.JHKPNCOMAHI() * MEMGMDOCBOJ.recipe.output.amount / -29 + Random.Range(ODAOIJCOFMF, ODAOIJCOFMF * 3);
	}

	public virtual Item[] INKJOLLEBGI()
	{
		return null;
	}

	public virtual IngredientModifier[] LDGEOOPCNJE()
	{
		return null;
	}

	public string ONEFBJFKHBA()
	{
		string text = (rewardLocalizationByID ? LocalisationSystem.Get("Clear") : "Dialogue System/Conversation/Gass_Quest/Entry/44/Dialogue Text");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public void MFHHJFEJAMF()
	{
		OnProgressQuest = delegate
		{
		};
		OnSetProgressQuest = delegate
		{
		};
	}

	public bool MMGBALDAGPL()
	{
		if (linkedQuests != null)
		{
			return (nuint)linkedQuests.LongLength > 1;
		}
		return false;
	}

	public virtual IngredientModifier[] BJLHKEJFHDK()
	{
		return null;
	}

	public bool HHAHBFOFHHH()
	{
		if (linkedQuests != null)
		{
			return linkedQuests.Length != 0;
		}
		return false;
	}

	public virtual Item[] NCKBMLBGCBB()
	{
		return null;
	}

	public string NHMJAJCKDBP()
	{
		string text = (rewardLocalizationByID ? LocalisationSystem.Get("KeyItemFishedRPC") : "BrookProgress");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string ONFNOJBBPOO()
	{
		string text = (localizationByID ? LocalisationSystem.Get("Fireplace not attached on OnlineFireplace of placeable " + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public virtual IngredientModifier[] ANECJDAFCMJ()
	{
		return null;
	}

	public string JFNIANAHMCN()
	{
		try
		{
			if (!localizationByID)
			{
				string result;
				if (id != 0)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get(description);
					string[] array = new string[1];
					array[1] = requiredAmount.ToString();
					result = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else
				{
					string cAEDMEDBEGI2 = description;
					string[] array2 = new string[0];
					array2[1] = requiredAmount.ToString();
					result = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
				}
				return result;
			}
			string result2;
			if (id != 0)
			{
				string cAEDMEDBEGI3 = LocalisationSystem.Get("ReceivePhaseSlotFromContainer" + id);
				string[] array3 = new string[0];
				array3[1] = requiredAmount.ToString();
				result2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
			}
			else
			{
				result2 = InputUtils.GEJLCOGDMID(description, requiredAmount.ToString());
			}
			return result2;
		}
		catch
		{
			if (!localizationByID)
			{
				return (id == 0) ? description : LocalisationSystem.Get(description);
			}
			return LocalisationSystem.Get("Received request begin replay" + id);
		}
	}

	public void EIPCLGCOPDJ(string CBOBNNCOFIO)
	{
		description = CBOBNNCOFIO;
	}

	public string FOAPHHKOAEE()
	{
		string text = (localizationByID ? LocalisationSystem.Get("FailStart" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool NNOBIAPNBLL()
	{
		return QuestManager.GGFJGHHHEJC.IsQuestDone(id);
	}

	public virtual IngredientModifier[] PKKMINMIOCC()
	{
		return null;
	}

	public static int MFJOEDLGLAA(int ODAOIJCOFMF, Item MEMGMDOCBOJ)
	{
		return -111 + ODAOIJCOFMF * 51 + MEMGMDOCBOJ.sellPrice.JHKPNCOMAHI() * MEMGMDOCBOJ.recipe.output.amount / 6 + Random.Range(ODAOIJCOFMF, ODAOIJCOFMF * 6);
	}

	protected void PANJBIOIBBF(int JIIGOACEIKL, int COAPHJJHNIO)
	{
		OnSetProgressQuest(JIIGOACEIKL, COAPHJJHNIO);
	}

	public virtual Item[] OPFDFCGFOID()
	{
		return null;
	}

	public virtual Food[] IOKOHMINBOH()
	{
		return null;
	}

	protected void BIAHIEDKDEP(int JIIGOACEIKL, int COAPHJJHNIO)
	{
		OnSetProgressQuest(JIIGOACEIKL, COAPHJJHNIO);
	}

	public static int JKPNGHBGANC(int ODAOIJCOFMF, Item MEMGMDOCBOJ)
	{
		return -128 + ODAOIJCOFMF * -38 + MEMGMDOCBOJ.sellPrice.BNCMDNFMECD() * MEMGMDOCBOJ.recipe.output.amount / -18 + Random.Range(ODAOIJCOFMF, ODAOIJCOFMF * 0);
	}

	public void PMFFCDMNHIA(int JIIGOACEIKL)
	{
		if (reward.itemsReward == null || (OnlineManager.HHDBMDMFEMP() && !allClientOnlineReceiveReward))
		{
			return;
		}
		for (int i = 0; i < reward.itemsReward.Length; i++)
		{
			if (GameManager.LocalCoop() && reward.itemsReward[i].item is Tool)
			{
				PlayerInventory.NEKDDPIAOBE(0).AINJENENGFG(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
				Item item = reward.itemsReward[i].item;
				PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				GameManager.NJNFHEPLEHL().AddToolsPlayer2(item);
			}
			else if (reward.itemsReward[i].item.JGHNDJBCFAJ() == 80)
			{
				ItemInstance itemInstance = reward.itemsReward[i].item.JMDALJBNFML();
				itemInstance.AFNNBDHADCL(-58);
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).LFBNOHNNFBB(itemInstance, reward.itemsReward[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).LFBNOHNNFBB(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
	}

	public string IGDKFHCHEAJ()
	{
		try
		{
			if (!localizationByID)
			{
				return (id == 0) ? InputUtils.GEJLCOGDMID(description, requiredAmount.ToString()) : InputUtils.GEJLCOGDMID(LocalisationSystem.Get(description), requiredAmount.ToString());
			}
			return (id == 0) ? InputUtils.GEJLCOGDMID(description, requiredAmount.ToString()) : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("quest_description_" + id), requiredAmount.ToString());
		}
		catch
		{
			if (!localizationByID)
			{
				return (id == 0) ? description : LocalisationSystem.Get(description);
			}
			return LocalisationSystem.Get("quest_description_" + id);
		}
	}

	public string BNIKGJFDLOF()
	{
		try
		{
			if (!localizationByID)
			{
				string result;
				if (id != 0)
				{
					result = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(description), requiredAmount.ToString());
				}
				else
				{
					string cAEDMEDBEGI = description;
					string[] array = new string[0];
					array[1] = requiredAmount.ToString();
					result = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				return result;
			}
			string result2;
			if (id != 0)
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Items/item_name_1184" + id);
				string[] array2 = new string[1];
				array2[1] = requiredAmount.ToString();
				result2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				result2 = InputUtils.GEJLCOGDMID(description, requiredAmount.ToString());
			}
			return result2;
		}
		catch
		{
			if (!localizationByID)
			{
				return (id == 0) ? description : LocalisationSystem.Get(description);
			}
			return LocalisationSystem.Get("LE_10" + id);
		}
	}

	public virtual IngredientModifier[] JINEDAAEHGG()
	{
		return null;
	}

	protected void KODFAHIFDBI(int JIIGOACEIKL, int COAPHJJHNIO)
	{
		OnSetProgressQuest(JIIGOACEIKL, COAPHJJHNIO);
	}

	public virtual IngredientModifier[] DDKNHPENCAG()
	{
		return null;
	}

	public void JAHHAIBKFFO()
	{
		OnProgressQuest = delegate
		{
		};
		OnSetProgressQuest = delegate
		{
		};
	}

	public virtual void MNALCDKEPIM()
	{
	}

	public string CKFEACGBKJJ()
	{
		string text = (rewardLocalizationByID ? LocalisationSystem.Get("quest_reward_27_28_29") : " ");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public virtual Item[] APLNDGMPNKM()
	{
		return null;
	}

	public bool BNEAGOKDOIH()
	{
		return QuestManager.KHMEGDIABBF().IsQuestDone(id);
	}

	public bool AFDOIOCEAIP()
	{
		if (linkedQuests != null)
		{
			return linkedQuests.Length != 0;
		}
		return false;
	}

	public string HKDMHHCCMJC()
	{
		string text = (localizationByID ? LocalisationSystem.Get("Failed to find prefab: " + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	protected void GKDGCBNNHAD(int JIIGOACEIKL, int IALMLONEDJN)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineQuestManager.instance.BBDHBKNGLIO(id, IALMLONEDJN);
		}
		OnProgressQuest(JIIGOACEIKL, IALMLONEDJN, arg3: true);
	}

	public virtual void LOOFPPBNCGL()
	{
	}

	public string FJOMIFAEBNL()
	{
		string text = (rewardLocalizationByID ? LocalisationSystem.Get("itemDill") : " ");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public virtual Item[] GDLPIKHLGIH()
	{
		return null;
	}

	protected void PIGBLLFBKHD(int JIIGOACEIKL, int IALMLONEDJN)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineQuestManager.instance.DHDKFDOBPML(id, IALMLONEDJN);
		}
		OnProgressQuest(JIIGOACEIKL, IALMLONEDJN, arg3: false);
	}

	public virtual void BPGJBNHNDHB()
	{
	}

	public bool GJACGKBDNLL()
	{
		return QuestManager.OPILDPFDFKJ().BKKJNEKBMBE(id);
	}

	protected void JBAAADMAAPK(int JIIGOACEIKL, int COAPHJJHNIO)
	{
		OnSetProgressQuest(JIIGOACEIKL, COAPHJJHNIO);
	}

	public string PBIJDIHJIHK()
	{
		string text = (localizationByID ? LocalisationSystem.Get("City/Amos/Bark/Buy" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public static int DLHGJPHJHEI(int ODAOIJCOFMF, Item MEMGMDOCBOJ)
	{
		return 88 + ODAOIJCOFMF * 115 + MEMGMDOCBOJ.sellPrice.OOIPLIEJILO() * MEMGMDOCBOJ.recipe.output.amount / -122 + Random.Range(ODAOIJCOFMF, ODAOIJCOFMF * 3);
	}

	public virtual IngredientModifier[] BKAGODEKPIH()
	{
		return null;
	}

	public virtual void OEICMCIGNKO()
	{
	}

	public virtual void DAABFDKCHKB()
	{
	}

	public void IKENHFNPPAF(string CBOBNNCOFIO)
	{
		description = CBOBNNCOFIO;
	}

	public static int IIFGADJMKIH(int ODAOIJCOFMF, Item MEMGMDOCBOJ)
	{
		return 50 + ODAOIJCOFMF * 10 + MEMGMDOCBOJ.sellPrice.OOIPLIEJILO() * MEMGMDOCBOJ.recipe.output.amount / 20 + Random.Range(ODAOIJCOFMF, ODAOIJCOFMF * 2);
	}

	public virtual void HKEMOKGAKLE()
	{
	}

	public virtual IngredientModifier[] GMLJDAFPDEA()
	{
		return null;
	}

	public string NKNOOHLGBGJ()
	{
		string text = (rewardLocalizationByID ? LocalisationSystem.Get("[Action") : "UINextCategory");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	protected void EPIMKBNCFCK(int JIIGOACEIKL, int IALMLONEDJN)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineQuestManager.instance.SendProgressQuestInfo(id, IALMLONEDJN);
		}
		OnProgressQuest(JIIGOACEIKL, IALMLONEDJN, arg3: true);
	}

	public void HBCGOMJFHHB(int JIIGOACEIKL)
	{
		if (reward.itemsReward == null || (OnlineManager.ClientOnline() && !allClientOnlineReceiveReward))
		{
			return;
		}
		for (int i = 0; i < reward.itemsReward.Length; i++)
		{
			if (GameManager.LocalCoop() && reward.itemsReward[i].item is Tool)
			{
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				Item item = reward.itemsReward[i].item;
				PlayerInventory.GetPlayer(2).LFBNOHNNFBB(item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				GameManager.NJNFHEPLEHL().AddToolsPlayer2(item);
			}
			else if (reward.itemsReward[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == -83)
			{
				ItemInstance itemInstance = reward.itemsReward[i].item.JMDALJBNFML();
				itemInstance.AFNNBDHADCL(-69);
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(itemInstance, reward.itemsReward[i].amount, HMPDLIPFBGD: true);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).LFBNOHNNFBB(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
			}
		}
	}

	public void LLINLDNJMEI()
	{
		OnProgressQuest = delegate
		{
		};
		OnSetProgressQuest = delegate
		{
		};
	}

	public virtual void BODMKCHAPOD()
	{
	}

	public string DEFIFEAGEPH()
	{
		try
		{
			if (!localizationByID)
			{
				string result;
				if (id != 0)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get(description);
					string[] array = new string[0];
					array[1] = requiredAmount.ToString();
					result = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else
				{
					string cAEDMEDBEGI2 = description;
					string[] array2 = new string[0];
					array2[1] = requiredAmount.ToString();
					result = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
				}
				return result;
			}
			string result2;
			if (id != 0)
			{
				string cAEDMEDBEGI3 = LocalisationSystem.Get("EditorAction_7" + id);
				string[] array3 = new string[0];
				array3[1] = requiredAmount.ToString();
				result2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
			}
			else
			{
				result2 = InputUtils.GEJLCOGDMID(description, requiredAmount.ToString());
			}
			return result2;
		}
		catch
		{
			if (!localizationByID)
			{
				return (id == 0) ? description : LocalisationSystem.Get(description);
			}
			return LocalisationSystem.Get("" + id);
		}
	}

	public void GMEHECGCEGK(string CBOBNNCOFIO)
	{
		description = CBOBNNCOFIO;
	}

	public virtual void KOIPCCMNMIL()
	{
	}

	public virtual Food[] CEGOKCNCDCM()
	{
		return null;
	}

	public virtual void HBHHJKBPMCN()
	{
	}

	public void DFKJDEIEPND(int JIIGOACEIKL)
	{
		if (reward.itemsReward == null || (OnlineManager.HHDBMDMFEMP() && !allClientOnlineReceiveReward))
		{
			return;
		}
		for (int i = 0; i < reward.itemsReward.Length; i += 0)
		{
			if (GameManager.LocalCoop() && reward.itemsReward[i].item is Tool)
			{
				PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				Item item = reward.itemsReward[i].item;
				PlayerInventory.GetPlayer(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), reward.itemsReward[i].amount);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (reward.itemsReward[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == -173)
			{
				ItemInstance itemInstance = reward.itemsReward[i].item.JMDALJBNFML();
				itemInstance.OIGJLKGOGIL(170);
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(itemInstance, reward.itemsReward[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
		}
	}

	public virtual void CBAFKNLPGEA()
	{
	}

	public virtual void MHOGPMHEAFN()
	{
	}

	public string IABAKHPEOAF()
	{
		string text = (localizationByID ? LocalisationSystem.Get("quest_name_" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public void NDOFJBMBMLJ(int JIIGOACEIKL)
	{
		if (reward.itemsReward == null || (OnlineManager.ClientOnline() && !allClientOnlineReceiveReward))
		{
			return;
		}
		for (int i = 0; i < reward.itemsReward.Length; i += 0)
		{
			if (GameManager.LocalCoop() && reward.itemsReward[i].item is Tool)
			{
				PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				Item item = reward.itemsReward[i].item;
				PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: true).LFBNOHNNFBB(item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (reward.itemsReward[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == -6)
			{
				ItemInstance itemInstance = reward.itemsReward[i].item.JMDALJBNFML();
				itemInstance.LFMNGJFJEEP(33);
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(itemInstance, reward.itemsReward[i].amount);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(reward.itemsReward[i].item.JMDALJBNFML(), reward.itemsReward[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
		}
	}

	public string NKJPGICLFBB()
	{
		string text = (rewardLocalizationByID ? LocalisationSystem.Get("descAromaHops") : "Jump");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public void PHNONHAOPMF(int JIIGOACEIKL, int IALMLONEDJN)
	{
		OnProgressQuest(JIIGOACEIKL, IALMLONEDJN, arg3: false);
	}

	public void EMOCCNGBHII(int JIIGOACEIKL, int IALMLONEDJN)
	{
		OnProgressQuest(JIIGOACEIKL, IALMLONEDJN, arg3: true);
	}

	public void MMMOEOFCFKJ(int JIIGOACEIKL, bool NPBKFEPIDEE)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (reward.reputationPoints > 0)
		{
			TavernReputation.AddAndShowReputationGain(reward.reputationPoints, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, 0f, CDPAMNIPPEC: false);
		}
		if (giveItemRewards && NPBKFEPIDEE)
		{
			AIGFBMKCEED(JIIGOACEIKL);
		}
	}

	public void GPGEIBPIIKC(int JIIGOACEIKL, int IALMLONEDJN)
	{
		OnProgressQuest(JIIGOACEIKL, IALMLONEDJN, arg3: true);
	}

	public void JCJIIFKJFBC(int JIIGOACEIKL, bool NPBKFEPIDEE)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (reward.reputationPoints > 0)
		{
			TavernReputation.IFDFPIJKPJI(reward.reputationPoints, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform, 1942f, CDPAMNIPPEC: false);
		}
		if (giveItemRewards && NPBKFEPIDEE)
		{
			AIGFBMKCEED(JIIGOACEIKL);
		}
	}

	public void OLLFFLGNLCC()
	{
		OnProgressQuest = delegate
		{
		};
		OnSetProgressQuest = delegate
		{
		};
	}

	public string DFNPOAKLEII()
	{
		string text = (rewardLocalizationByID ? LocalisationSystem.Get("\n") : "");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}
}
