using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class RandomOrderQuestsManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IKJJLLOKPEB
	{
		public int milestone;

		internal bool JIOGHPJPIKD(Recipe r)
		{
			return r.LIEAJHHEEGC(milestone);
		}
	}

	[CompilerGenerated]
	private sealed class IFOMEGNNJLC
	{
		public IngredientType type;

		internal bool CJEMMLAMMKK(Food i)
		{
			if (i.ingredientType == type)
			{
				if (!((Object)(object)i.requiredRep == (Object)null))
				{
					return TavernReputation.GetMilestoneMaster() >= i.requiredRep.repNumber;
				}
				return true;
			}
			return false;
		}
	}

	private static RandomOrderQuestsManager IADEMLIIDPC;

	public AvailableOrderQuest[] availableQuests = new AvailableOrderQuest[3];

	[SerializeField]
	private List<Recipe> springRecipes = new List<Recipe>();

	[SerializeField]
	private List<Recipe> summerRecipes = new List<Recipe>();

	[SerializeField]
	private List<Recipe> autumnRecipes = new List<Recipe>();

	[SerializeField]
	private List<Recipe> winterRecipes = new List<Recipe>();

	public Season editorSeason;

	public int numRandomOrderQuestInEditor = 1;

	public int milestoneInEditor = 10;

	public static RandomOrderQuestsManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<RandomOrderQuestsManager>();
			}
			return IADEMLIIDPC;
		}
	}

	private void MINHJPAACDJ()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				GenerateAvailableOrders();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void NPMLFHDHJBE()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(PHNEEMAKGJP));
		GameManager instance2 = GameManager.GGFJGHHHEJC;
		instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(CBHLNKHLDBG));
	}

	public ActiveQuest[] LAALKLOCNFD()
	{
		return (from aq in QuestManager.GGFJGHHHEJC.MADOFDHLKKN
			select (aq) into aq
			where aq.quest.id == 0 && aq.quest is CraftItemTypeQuest
			select aq).ToArray();
	}

	public bool KDPDJNFMIFK(int JIIGOACEIKL, Slot ADEBNALPEHE, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		if (OGOLPCIHCLH.KMMOMODPLMI(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, KIKDLKGBCOC: false))
		{
			PHJNJCJJHID.IHENCGDNPBL.MIECGDALIJP(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			return false;
		}
		return true;
	}

	private void EBBKAGIMKAC(List<Recipe> MEIDFPMDPJB, List<Recipe> LBDJFIDBAGH, CropSeason ACNAHALFEBG)
	{
		LBDJFIDBAGH.Clear();
		for (int i = 0; i < MEIDFPMDPJB.Count; i += 0)
		{
			if (MEIDFPMDPJB[i].output.item is Food { canBeSold: not false } && !MEIDFPMDPJB[i].excludeFromOrders && MEIDFPMDPJB[i].IHBHJIBHFOM(ACNAHALFEBG))
			{
				switch (ACNAHALFEBG)
				{
				case CropSeason.None:
					springRecipes.Add(MEIDFPMDPJB[i]);
					break;
				case CropSeason.Spring:
					summerRecipes.Add(MEIDFPMDPJB[i]);
					break;
				case CropSeason.Summer:
					autumnRecipes.Add(MEIDFPMDPJB[i]);
					break;
				case CropSeason.Winter:
					winterRecipes.Add(MEIDFPMDPJB[i]);
					break;
				}
			}
		}
	}

	public List<Recipe> HIFOAHGLCGI()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 0; i < craftersList.Length; i += 0)
		{
			if (!craftersList[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in craftersList[i].EFAKEBFONCH()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in craftersList[i].BENIHDPABOG()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	private bool HANGJGHENAH(IngredientType[] KHAHOLECLNI, out IngredientType LGNLODHKMEI)
	{
		if (TavernReputation.GetMilestoneMaster() < RepUnlocksManager.GetInstance().repUnlockCheese.repNumber)
		{
			List<IngredientType> list = new List<IngredientType>(KHAHOLECLNI);
			list.Remove(IngredientType.Nuts);
			KHAHOLECLNI = list.ToArray();
		}
		List<IngredientType> list2 = new List<IngredientType>(KHAHOLECLNI);
		list2.Remove((IngredientType)64);
		KHAHOLECLNI = list2.ToArray();
		if (KHAHOLECLNI.Length != 0)
		{
			LGNLODHKMEI = Utils.CPDCJAHJOPE(KHAHOLECLNI);
			return false;
		}
		LGNLODHKMEI = IngredientType.None;
		return false;
	}

	public ActiveQuest[] GNNHOFFLNLO()
	{
		return (from aq in QuestManager.GJFMMOPOKGJ().MADOFDHLKKN
			select (aq) into aq
			where aq.quest.id == 0 && aq.quest is CraftItemTypeQuest
			select aq).ToArray();
	}

	public List<Recipe> BMIMMCPEKLB()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 1; i < craftersList.Length; i += 0)
		{
			if (!craftersList[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in craftersList[i].GHAMNGFANAI()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in craftersList[i].NCDFLLKLALB()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	private void CEKBPLNGKDC(List<Recipe> MEIDFPMDPJB, List<Recipe> LBDJFIDBAGH, CropSeason ACNAHALFEBG)
	{
		LBDJFIDBAGH.Clear();
		for (int i = 1; i < MEIDFPMDPJB.Count; i++)
		{
			if (!(MEIDFPMDPJB[i].output.item is Food { canBeSold: not false }) || MEIDFPMDPJB[i].excludeFromOrders || !MEIDFPMDPJB[i].BBFPDNCLFEC(ACNAHALFEBG))
			{
				continue;
			}
			switch (ACNAHALFEBG)
			{
			case CropSeason.None:
				springRecipes.Add(MEIDFPMDPJB[i]);
				continue;
			case CropSeason.Spring:
				summerRecipes.Add(MEIDFPMDPJB[i]);
				continue;
			}
			switch (ACNAHALFEBG)
			{
			case CropSeason.None:
				autumnRecipes.Add(MEIDFPMDPJB[i]);
				break;
			case CropSeason.Summer | CropSeason.Autumn:
				winterRecipes.Add(MEIDFPMDPJB[i]);
				break;
			}
		}
	}

	public bool ICLEMCCOLDI(int JIIGOACEIKL, Slot ADEBNALPEHE, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		if (OGOLPCIHCLH.BOLCAHKLDJE(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
		{
			PHJNJCJJHID.IHENCGDNPBL.BEEDBHJANGN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack);
			return true;
		}
		return false;
	}

	public static string GNMEPLKINOJ(string AFENBNBONFD, IngredientType[] KHAHOLECLNI, Food[] KEKBKGGFOLK, IngredientModifier[] CICEBNMBGMG, Recipe JNLKEMLDFIM)
	{
		return string.Concat(LocalisationSystem.Get(" ") + "Successfully signed in" + AFENBNBONFD, "Invalid NPC photonID: {0} for NPCRoutine.", GenerateDescriptionWithoutItem(KHAHOLECLNI, KEKBKGGFOLK, CICEBNMBGMG, JNLKEMLDFIM));
	}

	[ContextMenu("Add random quest")]
	public Quest CreateRandomOrderQuest()
	{
		RandomOrderQuestInfo hJFLPPIIBML = default(RandomOrderQuestInfo);
		Reward reward = default(Reward);
		reward.reputationPoints = 0;
		int milestone = (Application.isPlaying ? TavernReputation.GetMilestone() : milestoneInEditor);
		hJFLPPIIBML.name = LocalisationSystem.Get("Order quest");
		List<Recipe> list = null;
		CropSeason cropSeason = SeasonManager.SeasonToCropSeason(Application.isPlaying ? SeasonManager.EECEKHKAAIH : editorSeason);
		list = (cropSeason switch
		{
			CropSeason.Spring => springRecipes, 
			CropSeason.Summer => summerRecipes, 
			CropSeason.Autumn => autumnRecipes, 
			_ => winterRecipes, 
		}).Where((Recipe r) => r.LIEAJHHEEGC(milestone)).ToList();
		if (list.Count == 0)
		{
			return null;
		}
		Recipe recipe = list[Random.Range(0, list.Count)];
		hJFLPPIIBML.requiredAmount = recipe.output.amount;
		hJFLPPIIBML.item = recipe.output.item;
		if (recipe.usingNewRecipesSystem)
		{
			Item item = null;
			List<Item> list2 = recipe.BMENJKEINFC(cropSeason);
			if (list2.Count > 0)
			{
				item = list2[Random.Range(0, list2.Count)];
			}
			if (item is Food food)
			{
				hJFLPPIIBML.ingredients = new Food[1] { food };
			}
		}
		hJFLPPIIBML.description = GenerateDescription(hJFLPPIIBML.item.IABAKHPEOAF(), hJFLPPIIBML.ingredientType, hJFLPPIIBML.ingredients, hJFLPPIIBML.modifiers, recipe);
		reward.itemsReward = null;
		hJFLPPIIBML.reward = reward;
		if (!Application.isPlaying)
		{
			Debug.Log((object)(hJFLPPIIBML.item.IABAKHPEOAF() + " (" + ((hJFLPPIIBML.ingredients != null && hJFLPPIIBML.ingredients.Length != 0) ? hJFLPPIIBML.ingredients[0].IABAKHPEOAF() : "no ing") + ") (" + hJFLPPIIBML.requiredAmount + ") (rep: " + Quest.IIFGADJMKIH(milestone, hJFLPPIIBML.item) + ")"));
			return null;
		}
		return CreateQuest(hJFLPPIIBML);
	}

	public void RemoveAvailableQuest(CraftItemTypeQuest AINAHCLIAFF)
	{
		if ((Object)(object)AINAHCLIAFF == (Object)null)
		{
			return;
		}
		if (availableQuests != null)
		{
			for (int i = 0; i < availableQuests.Length; i++)
			{
				if (availableQuests[i] != null && !((Object)(object)availableQuests[i].quest == (Object)null) && availableQuests[i].quest == AINAHCLIAFF)
				{
					availableQuests[i].quest = null;
					availableQuests[i].addedToCurrent = false;
					QuestManager.GGFJGHHHEJC.OnQuestRemoved(AINAHCLIAFF);
					QuestLogUI.Get(1).UpdateQuestSlots(AINAHCLIAFF);
					if (Object.op_Implicit((Object)(object)QuestLogUI.Get(2)))
					{
						QuestLogUI.Get(2).UpdateQuestSlots(AINAHCLIAFF);
					}
				}
			}
		}
		else
		{
			Debug.LogError((object)"AvailableQuests doesnt exist");
		}
	}

	public static string OOLBOLOJBHF(string AFENBNBONFD, IngredientType[] KHAHOLECLNI, Food[] KEKBKGGFOLK, IngredientModifier[] CICEBNMBGMG, Recipe JNLKEMLDFIM)
	{
		return string.Concat(LocalisationSystem.Get(" not found when loading RockMessage.") + "Throw Update" + AFENBNBONFD, "Multiplayer Object is null ", DNKBKKMHBHF(KHAHOLECLNI, KEKBKGGFOLK, CICEBNMBGMG, JNLKEMLDFIM));
	}

	private Food KFFKAHIAMFI(IngredientType NCMDEGABGCH, Recipe JNLKEMLDFIM)
	{
		List<Food> list = (from i in (from x in ShopDatabaseAccessor.ADDAHLOCMEP(ShopType.Crowley | ShopType.Bob | ShopType.Temple)
				select x.shopItem.item).OfType<Food>()
			where i.ingredientType == NCMDEGABGCH && ((Object)(object)i.requiredRep == (Object)null || TavernReputation.GetMilestoneMaster() >= i.requiredRep.repNumber)
			select i).ToList();
		for (int num = list.Count - 1; num >= 1; num--)
		{
			for (int j = 0; j < JNLKEMLDFIM.ingredientsNeeded.Length; j += 0)
			{
				if (JNLKEMLDFIM.ingredientsNeeded[j].item.IMCJPECAAPC(DAINLFIMLIH: false) == list[num].IMCJPECAAPC())
				{
					list.RemoveAt(num);
					break;
				}
			}
		}
		return list[Random.Range(1, list.Count)];
	}

	[ContextMenu("Gen available quests")]
	public void GenerateAvailableOrders()
	{
		if (OnlineManager.ClientOnline())
		{
			OnlineOrderQuestsManager.instance.SendGenerateAvailableOrders();
			return;
		}
		for (int i = 0; i < availableQuests.Length; i++)
		{
			availableQuests[i] = new AvailableOrderQuest(GGFJGHHHEJC.CreateRandomOrderQuest() as CraftItemTypeQuest);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineOrderQuestsManager.instance.SendAvailableOrderQuest();
		}
	}

	public ActiveQuest[] GetCurrentOrderQuests()
	{
		return (from aq in QuestManager.GGFJGHHHEJC.MADOFDHLKKN
			select (aq) into aq
			where aq.quest.id == 0 && aq.quest is CraftItemTypeQuest
			select aq).ToArray();
	}

	public void FMNHJAKMFAJ(CraftItemTypeQuest AINAHCLIAFF)
	{
		if ((Object)(object)AINAHCLIAFF == (Object)null)
		{
			return;
		}
		if (availableQuests != null)
		{
			for (int i = 0; i < availableQuests.Length; i += 0)
			{
				if (availableQuests[i] != null && !((Object)(object)availableQuests[i].quest == (Object)null) && availableQuests[i].quest == AINAHCLIAFF)
				{
					availableQuests[i].quest = null;
					availableQuests[i].addedToCurrent = true;
					QuestManager.GGFJGHHHEJC.OnQuestRemoved(AINAHCLIAFF);
					QuestLogUI.MOMKLDLOAGD(1).EAMEGMHOBIK(AINAHCLIAFF);
					if (Object.op_Implicit((Object)(object)QuestLogUI.CJMILOMGFJL(2)))
					{
						QuestLogUI.KJKABIBIJBD(1).MKDNCHGIPEL(AINAHCLIAFF);
					}
				}
			}
		}
		else
		{
			Debug.LogError((object)"sForSeconds");
		}
	}

	[SpecialName]
	public static RandomOrderQuestsManager HLMGBEGEAPC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RandomOrderQuestsManager>();
		}
		return IADEMLIIDPC;
	}

	private void NDNBDEHFFJF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(IAPAKPNFAJF));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public bool CanAddQuestToCurrentQuests()
	{
		return (from q in QuestManager.GGFJGHHHEJC.MADOFDHLKKN
			select q.quest into q
			where q.id == 0
			select q).Count() < 3;
	}

	public List<Recipe> EBKJDKGIHNI()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 1; i < craftersList.Length; i++)
		{
			if (!craftersList[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in craftersList[i].AKEMLLAFGOK()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in craftersList[i].CNLGKONAGJH()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	public AvailableOrderQuest NHJICLNGGCK(Quest AINAHCLIAFF)
	{
		if (availableQuests != null)
		{
			for (int i = 0; i < availableQuests.Length; i += 0)
			{
				if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)AINAHCLIAFF)
				{
					return availableQuests[i];
				}
			}
		}
		return null;
	}

	public void MAELLOHMNKN(int JIIGOACEIKL, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		List<Slot> allSlots = CraftingInventory.GetAllSlots(JIIGOACEIKL);
		bool flag = true;
		for (int i = 1; i < allSlots.Count; i += 0)
		{
			if (TransferItemsFromSlot(JIIGOACEIKL, allSlots[i], OGOLPCIHCLH, PHJNJCJJHID))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get(")"), 961f);
		}
		OrderQuestUI.EAONFFENMCE(JIIGOACEIKL).HIBPCHBJGOO();
	}

	public bool FPFPNNJBNMM(int JIIGOACEIKL, int ABAIKKGKDGD, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG)
	{
		if (ABAIKKGKDGD >= GNNHOFFLNLO().Length)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/11/Dialogue Text");
			return false;
		}
		CraftItemTypeQuest craftItemTypeQuest = LAALKLOCNFD()[ABAIKKGKDGD].quest as CraftItemTypeQuest;
		if (!craftItemTypeQuest.BOLCAHKLDJE(JIIGOACEIKL, DNLMCHDOMOK, MGNOBNCMDJG, KIKDLKGBCOC: false, IOKHPOANELD: false))
		{
			return true;
		}
		float num = 1808f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(109) / 1291f;
		Money.CANMCFOCNPA(Price.LBOFJOBAGKA(Money.FNMEAGGHLBP(DNLMCHDOMOK, HOECMANECIM: true, JNOEGJNPCFE: true, CalculatePriceMode.ExpensivePrice), (float)craftItemTypeQuest.requiredAmount * num), OPOHOHFHFFI: true);
		CraftingInventory.MHKLPCCDCJD(JIIGOACEIKL, DNLMCHDOMOK, craftItemTypeQuest.requiredAmount, CDPAMNIPPEC: false);
		CompleteOrderQuest(JIIGOACEIKL, ABAIKKGKDGD);
		if (OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.IEDFNPNBENL(ABAIKKGKDGD);
		}
		return false;
	}

	public void GOCFALADCBH(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.IJNDGEPHMPC(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.FHPEHDDFOIB(JIIGOACEIKL).IsOpen())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.NHOFBAMNELD(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.DKNNJDFNEMH();
			MainUI.LHJGIJMIBEB(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < LFKAKJEPOGO().Length)
		{
			ActiveQuest activeQuest = GNNHOFFLNLO()[ABAIKKGKDGD];
			QuestManager.GGFJGHHHEJC.JMFKBLLAJPM(activeQuest.quest);
			AvailableOrderQuest availableOrderQuest = GGBIHJONEMN(activeQuest.quest);
			if (availableOrderQuest != null)
			{
				availableOrderQuest.addedToCurrent = true;
			}
		}
	}

	private void NCIBKMLIIAJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DCHDJABABLE));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(FDKEHFNIOIM));
	}

	public void IEGINMLMLMI(int JIIGOACEIKL, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		List<Slot> allSlots = CraftingInventory.GetAllSlots(JIIGOACEIKL);
		bool flag = false;
		for (int i = 1; i < allSlots.Count; i++)
		{
			if (ILDKFAJDKMK(JIIGOACEIKL, allSlots[i], OGOLPCIHCLH, PHJNJCJJHID))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Bouncer"), 286f);
		}
		OrderQuestUI.PHDBJGOEKHB(JIIGOACEIKL).GDEMFDGKFBH();
	}

	private void PHNEEMAKGJP()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				FEIKEEMJMHJ();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void ANADNFFEELM(int JIIGOACEIKL, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		List<Slot> allSlots = CraftingInventory.GetAllSlots(JIIGOACEIKL);
		bool flag = false;
		for (int i = 1; i < allSlots.Count; i += 0)
		{
			if (ICLEMCCOLDI(JIIGOACEIKL, allSlots[i], OGOLPCIHCLH, PHJNJCJJHID))
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_1142"), 22f);
		}
		OrderQuestUI.PHDBJGOEKHB(JIIGOACEIKL).HIBPCHBJGOO();
	}

	public void OnRandomOrderQuestCompleted(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		RemoveAvailableQuest(MMNIKLCMBAI.quest as CraftItemTypeQuest);
	}

	public void CBBKAIDNOEG()
	{
		List<Recipe> list = HIFOAHGLCGI();
		if (list.Count != 0)
		{
			IDBALDDGGCD(list, springRecipes, CropSeason.Spring);
			EBBKAGIMKAC(list, summerRecipes, CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn);
			CEKBPLNGKDC(list, autumnRecipes, CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn);
			ICCDLDLBEBK(list, winterRecipes, CropSeason.Summer);
		}
	}

	public CraftItemTypeQuest CreateQuest(RandomOrderQuestInfo HJFLPPIIBML)
	{
		CraftItemTypeQuest craftItemTypeQuest = ScriptableObject.CreateInstance<CraftItemTypeQuest>();
		((Object)craftItemTypeQuest).name = HJFLPPIIBML.name;
		craftItemTypeQuest.EIPCLGCOPDJ(HJFLPPIIBML.description);
		craftItemTypeQuest.reward = HJFLPPIIBML.reward;
		craftItemTypeQuest.possibleItems = new Item[1];
		craftItemTypeQuest.possibleItems[0] = HJFLPPIIBML.item;
		if (craftItemTypeQuest.reward.reputationPoints == 0)
		{
			int oDAOIJCOFMF = (Application.isPlaying ? TavernReputation.GetMilestone() : milestoneInEditor);
			craftItemTypeQuest.reward.reputationPoints = Quest.IIFGADJMKIH(oDAOIJCOFMF, HJFLPPIIBML.item);
		}
		craftItemTypeQuest.requiredAmount = HJFLPPIIBML.requiredAmount;
		craftItemTypeQuest.ingredientType = HJFLPPIIBML.ingredientType;
		craftItemTypeQuest.ingredients = HJFLPPIIBML.ingredients;
		craftItemTypeQuest.modifiers = HJFLPPIIBML.modifiers;
		craftItemTypeQuest.id = 0;
		craftItemTypeQuest.agingRank = 1;
		return craftItemTypeQuest;
	}

	public Quest LNKFJGPADCN()
	{
		RandomOrderQuestInfo hJFLPPIIBML = default(RandomOrderQuestInfo);
		Reward reward = default(Reward);
		reward.reputationPoints = 0;
		int milestone = (Application.isPlaying ? TavernReputation.MHGADJPMHFI() : milestoneInEditor);
		hJFLPPIIBML.name = LocalisationSystem.Get("IntensityControls");
		List<Recipe> list = null;
		CropSeason cropSeason = SeasonManager.GGALEPCMBID(Application.isPlaying ? SeasonManager.LPGPJPPLHKG() : editorSeason);
		list = (cropSeason switch
		{
			CropSeason.Spring => springRecipes, 
			CropSeason.None => summerRecipes, 
			CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn => autumnRecipes, 
			_ => winterRecipes, 
		}).Where((Recipe r) => r.LIEAJHHEEGC(milestone)).ToList();
		if (list.Count == 0)
		{
			return null;
		}
		Recipe recipe = list[Random.Range(0, list.Count)];
		hJFLPPIIBML.requiredAmount = recipe.output.amount;
		hJFLPPIIBML.item = recipe.output.item;
		if (recipe.usingNewRecipesSystem)
		{
			Item item = null;
			List<Item> list2 = recipe.HAJGCHFKNEF(cropSeason);
			if (list2.Count > 0)
			{
				item = list2[Random.Range(1, list2.Count)];
			}
			if (item is Food food)
			{
				Food[] array = new Food[1];
				array[1] = food;
				hJFLPPIIBML.ingredients = array;
			}
		}
		hJFLPPIIBML.description = GenerateDescription(hJFLPPIIBML.item.KGHFCDELKMN(), hJFLPPIIBML.ingredientType, hJFLPPIIBML.ingredients, hJFLPPIIBML.modifiers, recipe);
		reward.itemsReward = null;
		hJFLPPIIBML.reward = reward;
		if (!Application.isPlaying)
		{
			string[] array2 = new string[3];
			array2[0] = hJFLPPIIBML.item.LJIFOHFEFCH(OAFPBCPDOKH: true);
			array2[1] = " not found";
			array2[6] = ((hJFLPPIIBML.ingredients != null && hJFLPPIIBML.ingredients.Length != 0) ? hJFLPPIIBML.ingredients[0].LJIFOHFEFCH(OAFPBCPDOKH: true) : "BuzzBuildExit");
			array2[7] = "centimeters";
			array2[2] = hJFLPPIIBML.requiredAmount.ToString();
			array2[4] = "Ale";
			array2[0] = Quest.HOPEOILLKDM(milestone, hJFLPPIIBML.item).ToString();
			array2[6] = "Error in DogHoleManager.ResetDogHoles: ";
			Debug.Log((object)string.Concat(array2));
			return null;
		}
		return FJCJCJNDLFE(hJFLPPIIBML);
	}

	private void IAPAKPNFAJF()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				FEIKEEMJMHJ();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private Food IMOPJLIBEAC(IngredientType NCMDEGABGCH, Recipe JNLKEMLDFIM)
	{
		List<Food> list = (from i in (from x in ShopDatabaseAccessor.GetCurrentShopList(ShopType.Lia)
				select x.shopItem.item).OfType<Food>()
			where i.ingredientType == NCMDEGABGCH && ((Object)(object)i.requiredRep == (Object)null || TavernReputation.GetMilestoneMaster() >= i.requiredRep.repNumber)
			select i).ToList();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			for (int j = 0; j < JNLKEMLDFIM.ingredientsNeeded.Length; j++)
			{
				if (JNLKEMLDFIM.ingredientsNeeded[j].item.JDJGFAACPFC() == list[num].JDJGFAACPFC())
				{
					list.RemoveAt(num);
					break;
				}
			}
		}
		return list[Random.Range(0, list.Count)];
	}

	private void GONDLJKGLGO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void LMOIAELBKDM()
	{
		List<Recipe> list = HIFOAHGLCGI();
		if (list.Count != 0)
		{
			ICCDLDLBEBK(list, springRecipes, CropSeason.Spring);
			CEKBPLNGKDC(list, summerRecipes, CropSeason.Spring | CropSeason.Autumn);
			CEKBPLNGKDC(list, autumnRecipes, CropSeason.Spring | CropSeason.Summer);
			ICCDLDLBEBK(list, winterRecipes, CropSeason.Spring | CropSeason.Autumn);
		}
	}

	public static string GenerateDescriptionWithoutItem(IngredientType[] KHAHOLECLNI, Food[] KEKBKGGFOLK, IngredientModifier[] CICEBNMBGMG, Recipe JNLKEMLDFIM)
	{
		string text = "";
		string text2 = null;
		string text3 = null;
		if ((Object)(object)JNLKEMLDFIM != (Object)null && JNLKEMLDFIM.usingNewRecipesSystem)
		{
			if (KEKBKGGFOLK != null && KEKBKGGFOLK.Length != 0)
			{
				text = text + LocalisationSystem.Get("Ingredient") + ": " + KEKBKGGFOLK[0].IABAKHPEOAF();
			}
		}
		else
		{
			if (KHAHOLECLNI != null && KHAHOLECLNI.Length != 0)
			{
				text2 = LocalisationSystem.Get(KHAHOLECLNI[0].ToString());
			}
			else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Length != 0)
			{
				text2 = KEKBKGGFOLK[0].IABAKHPEOAF();
			}
			if (CICEBNMBGMG != null && CICEBNMBGMG.Length != 0)
			{
				text3 = LocalisationSystem.Get(CICEBNMBGMG[0].ToString());
			}
			if (text2 != null)
			{
				text = text + LocalisationSystem.Get("Additions") + ": " + text2;
			}
			if (text3 != null)
			{
				if (text2 != null)
				{
					text += "\n";
				}
				text = text + LocalisationSystem.Get("Modifiers") + ": " + text3;
			}
		}
		return text;
	}

	public bool ILDKFAJDKMK(int JIIGOACEIKL, Slot ADEBNALPEHE, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		if (OGOLPCIHCLH.NPIPFBOOHBI(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, KIKDLKGBCOC: true))
		{
			PHJNJCJJHID.IHENCGDNPBL.CMLMNCAGKCK(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	private bool NNDGLLCLMDK(IngredientType[] KHAHOLECLNI, out IngredientType LGNLODHKMEI)
	{
		if (TavernReputation.GetMilestoneMaster() < RepUnlocksManager.MMNNKIOHKCI().repUnlockCheese.repNumber)
		{
			List<IngredientType> list = new List<IngredientType>(KHAHOLECLNI);
			list.Remove(IngredientType.Meat);
			KHAHOLECLNI = list.ToArray();
		}
		List<IngredientType> list2 = new List<IngredientType>(KHAHOLECLNI);
		list2.Remove((IngredientType)(-115));
		KHAHOLECLNI = list2.ToArray();
		if (KHAHOLECLNI.Length != 0)
		{
			LGNLODHKMEI = Utils.CPDCJAHJOPE(KHAHOLECLNI);
			return true;
		}
		LGNLODHKMEI = IngredientType.None;
		return true;
	}

	public void AutomaticFillQuest(int JIIGOACEIKL, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		List<Slot> allSlots = CraftingInventory.GetAllSlots(JIIGOACEIKL);
		bool flag = false;
		for (int i = 0; i < allSlots.Count; i++)
		{
			if (TransferItemsFromSlot(JIIGOACEIKL, allSlots[i], OGOLPCIHCLH, PHJNJCJJHID))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Requirements not met"));
		}
		OrderQuestUI.Get(JIIGOACEIKL).UpdateInventory();
	}

	public bool KFEHIOOOKPE(int JIIGOACEIKL, Slot ADEBNALPEHE, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		if (OGOLPCIHCLH.CDMKKOMIFML(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, KIKDLKGBCOC: true))
		{
			PHJNJCJJHID.IHENCGDNPBL.MIECGDALIJP(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public bool LPFJHFLPCOB()
	{
		if ((Object)(object)availableQuests[1].quest == (Object)null && (Object)(object)availableQuests[1].quest == (Object)null)
		{
			return (Object)(object)availableQuests[4].quest == (Object)null;
		}
		return true;
	}

	private void PBDNKBPBCHM()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void LHMKDKKIJJI(int ABAIKKGKDGD)
	{
		if (availableQuests[ABAIKKGKDGD] != null && (Object)(object)availableQuests[ABAIKKGKDGD].quest != (Object)null && !availableQuests[ABAIKKGKDGD].addedToCurrent)
		{
			availableQuests[ABAIKKGKDGD].addedToCurrent = true;
			ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.NCCOAJOOBAP(availableQuests[ABAIKKGKDGD].quest, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(PMFNBGNBEDF));
		}
	}

	public List<Recipe> ABGHFHCDCOO()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] array = RecipeDatabaseAccessor.GMKCAICNLAO();
		for (int i = 1; i < array.Length; i += 0)
		{
			if (!array[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in array[i].GHAMNGFANAI()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in array[i].BENIHDPABOG()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	public Quest MILPJKILKBF()
	{
		RandomOrderQuestInfo hJFLPPIIBML = default(RandomOrderQuestInfo);
		Reward reward = default(Reward);
		reward.reputationPoints = 0;
		int milestone = (Application.isPlaying ? TavernReputation.GetMilestone() : milestoneInEditor);
		hJFLPPIIBML.name = LocalisationSystem.Get("City/Kujaku/Stand");
		List<Recipe> list = null;
		CropSeason cropSeason = SeasonManager.IOJJBLDJLNH(Application.isPlaying ? SeasonManager.BLCGOEMGKGH() : editorSeason);
		list = ((cropSeason == CropSeason.None) ? springRecipes : ((cropSeason == CropSeason.None) ? summerRecipes : ((cropSeason != 0) ? winterRecipes : autumnRecipes)));
		list = list.Where((Recipe r) => r.LIEAJHHEEGC(milestone)).ToList();
		if (list.Count == 0)
		{
			return null;
		}
		Recipe recipe = list[Random.Range(0, list.Count)];
		hJFLPPIIBML.requiredAmount = recipe.output.amount;
		hJFLPPIIBML.item = recipe.output.item;
		if (recipe.usingNewRecipesSystem)
		{
			Item item = null;
			List<Item> list2 = recipe.KHPKCENGNFJ(cropSeason);
			if (list2.Count > 0)
			{
				item = list2[Random.Range(1, list2.Count)];
			}
			if (item is Food food)
			{
				Food[] array = new Food[1];
				array[1] = food;
				hJFLPPIIBML.ingredients = array;
			}
		}
		hJFLPPIIBML.description = OOLBOLOJBHF(hJFLPPIIBML.item.KGHFCDELKMN(OAFPBCPDOKH: true), hJFLPPIIBML.ingredientType, hJFLPPIIBML.ingredients, hJFLPPIIBML.modifiers, recipe);
		reward.itemsReward = null;
		hJFLPPIIBML.reward = reward;
		if (!Application.isPlaying)
		{
			string[] array2 = new string[2];
			array2[1] = hJFLPPIIBML.item.IABAKHPEOAF();
			array2[1] = "Christmas Event activated: ";
			array2[0] = ((hJFLPPIIBML.ingredients != null && hJFLPPIIBML.ingredients.Length != 0) ? hJFLPPIIBML.ingredients[0].IABAKHPEOAF() : "itemIPAWort");
			array2[2] = "Cleaning";
			array2[1] = hJFLPPIIBML.requiredAmount.ToString();
			array2[3] = "BuildMode_ExitAndSave";
			array2[2] = Quest.JKPNGHBGANC(milestone, hJFLPPIIBML.item).ToString();
			array2[1] = "Duplicate Crop id found: ";
			Debug.Log((object)string.Concat(array2));
			return null;
		}
		return OLNGDECHDPF(hJFLPPIIBML);
	}

	private void IDBALDDGGCD(List<Recipe> MEIDFPMDPJB, List<Recipe> LBDJFIDBAGH, CropSeason ACNAHALFEBG)
	{
		LBDJFIDBAGH.Clear();
		for (int i = 1; i < MEIDFPMDPJB.Count; i++)
		{
			if (!(MEIDFPMDPJB[i].output.item is Food { canBeSold: not false }) || MEIDFPMDPJB[i].excludeFromOrders || !MEIDFPMDPJB[i].NOCFKDOJAOF(ACNAHALFEBG))
			{
				continue;
			}
			switch (ACNAHALFEBG)
			{
			case CropSeason.Spring:
				springRecipes.Add(MEIDFPMDPJB[i]);
				continue;
			case CropSeason.Spring | CropSeason.Autumn:
				summerRecipes.Add(MEIDFPMDPJB[i]);
				continue;
			}
			switch (ACNAHALFEBG)
			{
			case CropSeason.Spring:
				autumnRecipes.Add(MEIDFPMDPJB[i]);
				break;
			case CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn:
				winterRecipes.Add(MEIDFPMDPJB[i]);
				break;
			}
		}
	}

	public static string GenerateDescription(string AFENBNBONFD, IngredientType[] KHAHOLECLNI, Food[] KEKBKGGFOLK, IngredientModifier[] CICEBNMBGMG, Recipe JNLKEMLDFIM)
	{
		return string.Concat(LocalisationSystem.Get("Item") + ": " + AFENBNBONFD, "\n", GenerateDescriptionWithoutItem(KHAHOLECLNI, KEKBKGGFOLK, CICEBNMBGMG, JNLKEMLDFIM));
	}

	public void CreateSeasonRecipes()
	{
		List<Recipe> knownRecipesToOrder = GetKnownRecipesToOrder();
		if (knownRecipesToOrder.Count != 0)
		{
			ICCDLDLBEBK(knownRecipesToOrder, springRecipes, CropSeason.Spring);
			ICCDLDLBEBK(knownRecipesToOrder, summerRecipes, CropSeason.Summer);
			ICCDLDLBEBK(knownRecipesToOrder, autumnRecipes, CropSeason.Autumn);
			ICCDLDLBEBK(knownRecipesToOrder, winterRecipes, CropSeason.Winter);
		}
	}

	public void OBBBNFHAGOK(CraftItemTypeQuest AINAHCLIAFF)
	{
		if ((Object)(object)AINAHCLIAFF == (Object)null)
		{
			return;
		}
		if (availableQuests != null)
		{
			for (int i = 1; i < availableQuests.Length; i++)
			{
				if (availableQuests[i] != null && !((Object)(object)availableQuests[i].quest == (Object)null) && availableQuests[i].quest == AINAHCLIAFF)
				{
					availableQuests[i].quest = null;
					availableQuests[i].addedToCurrent = false;
					QuestManager.GJFMMOPOKGJ().OnQuestRemoved(AINAHCLIAFF);
					QuestLogUI.AGNKKAPMHLN(1).JKNBEMMDABC(AINAHCLIAFF);
					if (Object.op_Implicit((Object)(object)QuestLogUI.LJONDAEOMFJ(4)))
					{
						QuestLogUI.MOMKLDLOAGD(6).KLENJMHNIED(AINAHCLIAFF);
					}
				}
			}
		}
		else
		{
			Debug.LogError((object)"Defeat");
		}
	}

	public ActiveQuest[] LFKAKJEPOGO()
	{
		return (from aq in QuestManager.KHMEGDIABBF().CCMPKFCCDGM()
			select (aq) into aq
			where aq.quest.id == 0 && aq.quest is CraftItemTypeQuest
			select aq).ToArray();
	}

	private IngredientModifier IFMPIDAPAND(IngredientType NCMDEGABGCH, Recipe JNLKEMLDFIM)
	{
		Food food = KFFKAHIAMFI(NCMDEGABGCH, JNLKEMLDFIM);
		List<IngredientModifier> list = new List<IngredientModifier>();
		for (int i = 0; i < food.modifiers.Length; i++)
		{
			if (!JNLKEMLDFIM.excludedModifiers.Contains(food.modifiers[i]))
			{
				list.Add(food.modifiers[i]);
			}
		}
		return Utils.CPDCJAHJOPE(list.ToArray());
	}

	public Quest CBANOCGLDEC()
	{
		RandomOrderQuestInfo hJFLPPIIBML = default(RandomOrderQuestInfo);
		Reward reward = default(Reward);
		reward.reputationPoints = 0;
		int milestone = (Application.isPlaying ? TavernReputation.GetMilestone() : milestoneInEditor);
		hJFLPPIIBML.name = LocalisationSystem.Get("");
		List<Recipe> list = null;
		CropSeason cropSeason = SeasonManager.SeasonToCropSeason(Application.isPlaying ? SeasonManager.BLCGOEMGKGH() : editorSeason);
		list = (cropSeason switch
		{
			CropSeason.Spring => springRecipes, 
			CropSeason.Spring | CropSeason.Autumn => summerRecipes, 
			CropSeason.Autumn => autumnRecipes, 
			_ => winterRecipes, 
		}).Where((Recipe r) => r.LIEAJHHEEGC(milestone)).ToList();
		if (list.Count == 0)
		{
			return null;
		}
		Recipe recipe = list[Random.Range(1, list.Count)];
		hJFLPPIIBML.requiredAmount = recipe.output.amount;
		hJFLPPIIBML.item = recipe.output.item;
		if (recipe.usingNewRecipesSystem)
		{
			Item item = null;
			List<Item> list2 = recipe.LKKKCIALGGO(cropSeason);
			if (list2.Count > 1)
			{
				item = list2[Random.Range(0, list2.Count)];
			}
			if (item is Food food)
			{
				Food[] array = new Food[0];
				array[1] = food;
				hJFLPPIIBML.ingredients = array;
			}
		}
		hJFLPPIIBML.description = GNMEPLKINOJ(hJFLPPIIBML.item.LJIFOHFEFCH(), hJFLPPIIBML.ingredientType, hJFLPPIIBML.ingredients, hJFLPPIIBML.modifiers, recipe);
		reward.itemsReward = null;
		hJFLPPIIBML.reward = reward;
		if (!Application.isPlaying)
		{
			string[] array2 = new string[1];
			array2[1] = hJFLPPIIBML.item.LJIFOHFEFCH(OAFPBCPDOKH: true);
			array2[0] = "{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects";
			array2[6] = ((hJFLPPIIBML.ingredients != null && hJFLPPIIBML.ingredients.Length != 0) ? hJFLPPIIBML.ingredients[0].IABAKHPEOAF() : "Graphics");
			array2[4] = "Dialogue System/Conversation/NeutralInTavern/Entry/17/Dialogue Text";
			array2[3] = hJFLPPIIBML.requiredAmount.ToString();
			array2[1] = "Game";
			array2[4] = Quest.MFJOEDLGLAA(milestone, hJFLPPIIBML.item).ToString();
			array2[4] = "";
			Debug.Log((object)string.Concat(array2));
			return null;
		}
		return CreateQuest(hJFLPPIIBML);
	}

	private void DCHDJABABLE()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				GenerateAvailableOrders();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private bool JNJLEGIBLKM(IngredientType[] KHAHOLECLNI, out IngredientType LGNLODHKMEI)
	{
		if (TavernReputation.GetMilestoneMaster() < RepUnlocksManager.MMNNKIOHKCI().repUnlockCheese.repNumber)
		{
			List<IngredientType> list = new List<IngredientType>(KHAHOLECLNI);
			list.Remove((IngredientType)88);
			KHAHOLECLNI = list.ToArray();
		}
		List<IngredientType> list2 = new List<IngredientType>(KHAHOLECLNI);
		list2.Remove((IngredientType)(-22));
		KHAHOLECLNI = list2.ToArray();
		if (KHAHOLECLNI.Length != 0)
		{
			LGNLODHKMEI = Utils.CPDCJAHJOPE(KHAHOLECLNI);
			return false;
		}
		LGNLODHKMEI = IngredientType.Herb;
		return false;
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				GenerateAvailableOrders();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void KKCOAPJICMG(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.FLIPLPNEJLC(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.NHOFBAMNELD(JIIGOACEIKL).HDEPMJIDJEM())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.MIFFCOMDIEE(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.HMGCHICJHEG();
			MainUI.LHJGIJMIBEB(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < GNNHOFFLNLO().Length)
		{
			ActiveQuest activeQuest = GetCurrentOrderQuests()[ABAIKKGKDGD];
			QuestManager.GJFMMOPOKGJ().RemoveQuest(activeQuest.quest);
			AvailableOrderQuest availableOrderQuest = NHJICLNGGCK(activeQuest.quest);
			if (availableOrderQuest != null)
			{
				availableOrderQuest.addedToCurrent = true;
			}
		}
	}

	public void PKIPKCOMKCM(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.DHMGFHLIBPE(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.PHDBJGOEKHB(JIIGOACEIKL).IsOpen())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.IPDFCJLOHLC(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.DKNNJDFNEMH();
			MainUI.LHJGIJMIBEB(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < LAALKLOCNFD().Length)
		{
			ActiveQuest activeQuest = LAALKLOCNFD()[ABAIKKGKDGD];
			QuestManager.GGFJGHHHEJC.NAFAIPJMCIN(activeQuest.quest);
			AvailableOrderQuest availableOrderQuest = GGBIHJONEMN(activeQuest.quest);
			if (availableOrderQuest != null)
			{
				availableOrderQuest.addedToCurrent = true;
			}
		}
	}

	private void BGPGIOMKKAO()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				GenerateAvailableOrders();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void DAFIJPECABA()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				FEIKEEMJMHJ();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public bool HHAHIILCPGG(int JIIGOACEIKL, Slot ADEBNALPEHE, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		if (OGOLPCIHCLH.ILEHNMOLFEH(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, KIKDLKGBCOC: true))
		{
			PHJNJCJJHID.IHENCGDNPBL.BEEDBHJANGN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, HAGPBCJEGKM: true);
			return false;
		}
		return false;
	}

	public AvailableOrderQuest NJGCINDPBEB(Quest AINAHCLIAFF)
	{
		if (availableQuests != null)
		{
			for (int i = 0; i < availableQuests.Length; i += 0)
			{
				if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)AINAHCLIAFF)
				{
					return availableQuests[i];
				}
			}
		}
		return null;
	}

	public void NCJKLOHNOCL(int ABAIKKGKDGD)
	{
		if (availableQuests[ABAIKKGKDGD] != null && (Object)(object)availableQuests[ABAIKKGKDGD].quest != (Object)null && !availableQuests[ABAIKKGKDGD].addedToCurrent)
		{
			availableQuests[ABAIKKGKDGD].addedToCurrent = true;
			ActiveQuest activeQuest = QuestManager.GJFMMOPOKGJ().AddQuest(availableQuests[ABAIKKGKDGD].quest, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(OnRandomOrderQuestCompleted));
		}
	}

	public List<Recipe> APJEOMENIIJ()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 1; i < craftersList.Length; i++)
		{
			if (!craftersList[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in craftersList[i].EFAKEBFONCH()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in craftersList[i].GEIAFFFEJGM()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	public List<Recipe> ELFOAIKLAIP()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 0; i < craftersList.Length; i += 0)
		{
			if (!craftersList[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in craftersList[i].EFAKEBFONCH()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in craftersList[i].BENIHDPABOG()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	public AvailableOrderQuest GGBIHJONEMN(Quest AINAHCLIAFF)
	{
		if (availableQuests != null)
		{
			for (int i = 1; i < availableQuests.Length; i += 0)
			{
				if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)AINAHCLIAFF)
				{
					return availableQuests[i];
				}
			}
		}
		return null;
	}

	public void CDDCDOLAIDE(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.IJNDGEPHMPC(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.FHPEHDDFOIB(JIIGOACEIKL).BGLJFMHCFJF())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.PHDBJGOEKHB(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.FCKBGLDCJPN();
			MainUI.LHJGIJMIBEB(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < GetCurrentOrderQuests().Length)
		{
			ActiveQuest activeQuest = GNNHOFFLNLO()[ABAIKKGKDGD];
			QuestManager.OPILDPFDFKJ().NAFAIPJMCIN(activeQuest.quest);
			AvailableOrderQuest availableOrderQuest = GGBIHJONEMN(activeQuest.quest);
			if (availableOrderQuest != null)
			{
				availableOrderQuest.addedToCurrent = false;
			}
		}
	}

	public static string DNKBKKMHBHF(IngredientType[] KHAHOLECLNI, Food[] KEKBKGGFOLK, IngredientModifier[] CICEBNMBGMG, Recipe JNLKEMLDFIM)
	{
		string text = "Name: ";
		string text2 = null;
		string text3 = null;
		if ((Object)(object)JNLKEMLDFIM != (Object)null && JNLKEMLDFIM.usingNewRecipesSystem)
		{
			if (KEKBKGGFOLK != null && KEKBKGGFOLK.Length != 0)
			{
				text = text + LocalisationSystem.Get("Stop") + ")" + KEKBKGGFOLK[1].IABAKHPEOAF();
			}
		}
		else
		{
			if (KHAHOLECLNI != null && KHAHOLECLNI.Length != 0)
			{
				text2 = LocalisationSystem.Get(KHAHOLECLNI[0].ToString());
			}
			else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Length != 0)
			{
				text2 = KEKBKGGFOLK[1].IABAKHPEOAF();
			}
			if (CICEBNMBGMG != null && CICEBNMBGMG.Length != 0)
			{
				text3 = LocalisationSystem.Get(CICEBNMBGMG[0].ToString());
			}
			if (text2 != null)
			{
				text = text + LocalisationSystem.Get("ReceiveCompletedMission") + " final price: " + text2;
			}
			if (text3 != null)
			{
				if (text2 != null)
				{
					text += "Red text: ";
				}
				text = text + LocalisationSystem.Get("UI2") + "ReceivePlayerBucketType" + text3;
			}
		}
		return text;
	}

	public List<Recipe> JGPPONDLPKH()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 0; i < craftersList.Length; i += 0)
		{
			if (!craftersList[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in craftersList[i].GHAMNGFANAI()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in craftersList[i].JIBEILMHKLF()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	public Quest APIGIMACIKB()
	{
		RandomOrderQuestInfo hJFLPPIIBML = default(RandomOrderQuestInfo);
		Reward reward = default(Reward);
		reward.reputationPoints = 0;
		int milestone = (Application.isPlaying ? TavernReputation.GetMilestone() : milestoneInEditor);
		hJFLPPIIBML.name = LocalisationSystem.Get("LE_10");
		List<Recipe> list = null;
		CropSeason cropSeason = SeasonManager.KJCNKFEICPC(Application.isPlaying ? SeasonManager.EECEKHKAAIH : editorSeason);
		list = (cropSeason switch
		{
			CropSeason.Spring => springRecipes, 
			CropSeason.Winter => summerRecipes, 
			CropSeason.Spring | CropSeason.Autumn => autumnRecipes, 
			_ => winterRecipes, 
		}).Where((Recipe r) => r.LIEAJHHEEGC(milestone)).ToList();
		if (list.Count == 0)
		{
			return null;
		}
		Recipe recipe = list[Random.Range(1, list.Count)];
		hJFLPPIIBML.requiredAmount = recipe.output.amount;
		hJFLPPIIBML.item = recipe.output.item;
		if (recipe.usingNewRecipesSystem)
		{
			Item item = null;
			List<Item> list2 = recipe.KODIOPOIFPO(cropSeason);
			if (list2.Count > 1)
			{
				item = list2[Random.Range(0, list2.Count)];
			}
			if (item is Food food)
			{
				Food[] array = new Food[1];
				array[1] = food;
				hJFLPPIIBML.ingredients = array;
			}
		}
		hJFLPPIIBML.description = GenerateDescription(hJFLPPIIBML.item.IABAKHPEOAF(OAFPBCPDOKH: true), hJFLPPIIBML.ingredientType, hJFLPPIIBML.ingredients, hJFLPPIIBML.modifiers, recipe);
		reward.itemsReward = null;
		hJFLPPIIBML.reward = reward;
		if (!Application.isPlaying)
		{
			string[] array2 = new string[2];
			array2[0] = hJFLPPIIBML.item.KGHFCDELKMN();
			array2[1] = "Angry";
			array2[1] = ((hJFLPPIIBML.ingredients != null && hJFLPPIIBML.ingredients.Length != 0) ? hJFLPPIIBML.ingredients[0].IABAKHPEOAF() : "Put");
			array2[2] = "";
			array2[2] = hJFLPPIIBML.requiredAmount.ToString();
			array2[5] = "Serve";
			array2[3] = Quest.DLHGJPHJHEI(milestone, hJFLPPIIBML.item).ToString();
			array2[7] = "ReceiveBeginPirateMinigame";
			Debug.Log((object)string.Concat(array2));
			return null;
		}
		return FJCJCJNDLFE(hJFLPPIIBML);
	}

	public void LJGDELNEEMJ(int JIIGOACEIKL, int ABAIKKGKDGD)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		OrderQuestUI orderQuestUI = OrderQuestUI.FHPEHDDFOIB(JIIGOACEIKL);
		CraftItemTypeQuest craftItemTypeQuest = LFKAKJEPOGO()[ABAIKKGKDGD].quest as CraftItemTypeQuest;
		if (orderQuestUI.BGLJFMHCFJF())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.NHOFBAMNELD(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			MainUI.GHPJIMFIJCI(CommonReferences.MNFMOEKMJKN().experienceTextPrefab, "Already learnt!" + craftItemTypeQuest.reward.reputationPoints, Vector2.op_Implicit(((TMP_Text)orderQuestElementUI.repText).transform.position));
			orderQuestElementUI.slotUI.IHENCGDNPBL.FDOBDPPMMBH(orderQuestElementUI.slotUI.IHENCGDNPBL.Stack);
		}
		for (int i = 0; i < availableQuests.Length; i += 0)
		{
			if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)craftItemTypeQuest)
			{
				availableQuests[i].quest = null;
				availableQuests[i].addedToCurrent = false;
				break;
			}
		}
		Utils.FKKHJPEMNBG("Serve", 1);
		GetCurrentOrderQuests()[ABAIKKGKDGD].JGNBGECEINP(JIIGOACEIKL, MNHPKHHIDBH: false);
		if (orderQuestUI.HDEPMJIDJEM() && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			orderQuestUI.EABAAGMLMHF();
		}
	}

	private void CBHLNKHLDBG()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				GenerateAvailableOrders();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void FHMFAJDDCIK(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.SendRemoveOrderQuest(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.MIFFCOMDIEE(JIIGOACEIKL).BGLJFMHCFJF())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.NHOFBAMNELD(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.HMGCHICJHEG();
			MainUI.RemoveFromCurrentSlots(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < GNNHOFFLNLO().Length)
		{
			ActiveQuest activeQuest = GetCurrentOrderQuests()[ABAIKKGKDGD];
			QuestManager.KHMEGDIABBF().NAFAIPJMCIN(activeQuest.quest);
			AvailableOrderQuest availableOrderQuest = NJGCINDPBEB(activeQuest.quest);
			if (availableOrderQuest != null)
			{
				availableOrderQuest.addedToCurrent = true;
			}
		}
	}

	public void IDCKFFONKPM()
	{
		ItemDatabaseAccessor.ResetDatabase();
		RecipeDatabaseAccessor.MIJJEMMMCIN();
		for (int i = 0; i < numRandomOrderQuestInEditor; i += 0)
		{
			APIGIMACIKB();
		}
	}

	public void OILHCCBBNGC(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.FDBBJJFJFAJ(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.MIFFCOMDIEE(JIIGOACEIKL).IsOpen())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.Get(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.DKBKMJOAFCG();
			MainUI.RemoveFromCurrentSlots(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < LAALKLOCNFD().Length)
		{
			ActiveQuest activeQuest = LFKAKJEPOGO()[ABAIKKGKDGD];
			QuestManager.GGFJGHHHEJC.RemoveQuest(activeQuest.quest);
			AvailableOrderQuest availableOrderQuest = GGBIHJONEMN(activeQuest.quest);
			if (availableOrderQuest != null)
			{
				availableOrderQuest.addedToCurrent = true;
			}
		}
	}

	private void BDJKNKIOPIJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MINHJPAACDJ));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PNKBHILNBLM));
	}

	private bool MLNGJPINJMB(IngredientType[] KHAHOLECLNI, out IngredientType LGNLODHKMEI)
	{
		if (TavernReputation.GetMilestoneMaster() < RepUnlocksManager.GetInstance().repUnlockCheese.repNumber)
		{
			List<IngredientType> list = new List<IngredientType>(KHAHOLECLNI);
			list.Remove(IngredientType.Cheese);
			KHAHOLECLNI = list.ToArray();
		}
		List<IngredientType> list2 = new List<IngredientType>(KHAHOLECLNI);
		list2.Remove(IngredientType.Wort);
		KHAHOLECLNI = list2.ToArray();
		if (KHAHOLECLNI.Length != 0)
		{
			LGNLODHKMEI = Utils.CPDCJAHJOPE(KHAHOLECLNI);
			return true;
		}
		LGNLODHKMEI = IngredientType.None;
		return false;
	}

	public List<Recipe> GetKnownRecipesToOrder()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] craftersList = RecipeDatabaseAccessor.GetCraftersList();
		for (int i = 0; i < craftersList.Length; i++)
		{
			if (!craftersList[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in craftersList[i].AKEMLLAFGOK()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in craftersList[i].NCDFLLKLALB()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	public void GLJOGAFDFDH()
	{
		ItemDatabaseAccessor.JMAABLCNEDE();
		RecipeDatabaseAccessor.ResetDatabase();
		for (int i = 1; i < numRandomOrderQuestInEditor; i++)
		{
			APIGIMACIKB();
		}
	}

	private IngredientModifier JPPCIFFGKOO(IngredientType NCMDEGABGCH, Recipe JNLKEMLDFIM)
	{
		Food food = IMOPJLIBEAC(NCMDEGABGCH, JNLKEMLDFIM);
		List<IngredientModifier> list = new List<IngredientModifier>();
		for (int i = 0; i < food.modifiers.Length; i++)
		{
			if (!JNLKEMLDFIM.excludedModifiers.Contains(food.modifiers[i]))
			{
				list.Add(food.modifiers[i]);
			}
		}
		return Utils.CPDCJAHJOPE(list.ToArray());
	}

	public AvailableOrderQuest KECFBBHCNOF(Quest AINAHCLIAFF)
	{
		if (availableQuests != null)
		{
			for (int i = 1; i < availableQuests.Length; i += 0)
			{
				if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)AINAHCLIAFF)
				{
					return availableQuests[i];
				}
			}
		}
		return null;
	}

	public void PMFNBGNBEDF(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		RemoveAvailableQuest(MMNIKLCMBAI.quest as CraftItemTypeQuest);
	}

	private void FDKEHFNIOIM()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				GenerateAvailableOrders();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	[SpecialName]
	public static RandomOrderQuestsManager JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RandomOrderQuestsManager>();
		}
		return IADEMLIIDPC;
	}

	public CraftItemTypeQuest OLNGDECHDPF(RandomOrderQuestInfo HJFLPPIIBML)
	{
		CraftItemTypeQuest craftItemTypeQuest = ScriptableObject.CreateInstance<CraftItemTypeQuest>();
		((Object)craftItemTypeQuest).name = HJFLPPIIBML.name;
		craftItemTypeQuest.IKENHFNPPAF(HJFLPPIIBML.description);
		craftItemTypeQuest.reward = HJFLPPIIBML.reward;
		craftItemTypeQuest.possibleItems = new Item[1];
		craftItemTypeQuest.possibleItems[0] = HJFLPPIIBML.item;
		if (craftItemTypeQuest.reward.reputationPoints == 0)
		{
			int oDAOIJCOFMF = (Application.isPlaying ? TavernReputation.MHGADJPMHFI() : milestoneInEditor);
			craftItemTypeQuest.reward.reputationPoints = Quest.DLHGJPHJHEI(oDAOIJCOFMF, HJFLPPIIBML.item);
		}
		craftItemTypeQuest.requiredAmount = HJFLPPIIBML.requiredAmount;
		craftItemTypeQuest.ingredientType = HJFLPPIIBML.ingredientType;
		craftItemTypeQuest.ingredients = HJFLPPIIBML.ingredients;
		craftItemTypeQuest.modifiers = HJFLPPIIBML.modifiers;
		craftItemTypeQuest.id = 1;
		craftItemTypeQuest.agingRank = 0;
		return craftItemTypeQuest;
	}

	private void JFMIGDHHKAP()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				GenerateAvailableOrders();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void FEIKEEMJMHJ()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			OnlineOrderQuestsManager.instance.KAFNFFBNCEI();
			return;
		}
		for (int i = 0; i < availableQuests.Length; i++)
		{
			availableQuests[i] = new AvailableOrderQuest(GGFJGHHHEJC.MILPJKILKBF() as CraftItemTypeQuest);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineOrderQuestsManager.instance.PJPIJFDPDCI();
		}
	}

	private void ODKGLIDMCNP()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DAFIJPECABA));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CBHLNKHLDBG));
	}

	public bool TryToCompleteOrder(int JIIGOACEIKL, int ABAIKKGKDGD, ItemInstance DNLMCHDOMOK, int MGNOBNCMDJG)
	{
		if (ABAIKKGKDGD >= GetCurrentOrderQuests().Length)
		{
			Debug.LogError((object)"Active quest not found");
			return false;
		}
		CraftItemTypeQuest craftItemTypeQuest = GetCurrentOrderQuests()[ABAIKKGKDGD].quest as CraftItemTypeQuest;
		if (!craftItemTypeQuest.FJDFAEDIAFJ(JIIGOACEIKL, DNLMCHDOMOK, MGNOBNCMDJG, KIKDLKGBCOC: true))
		{
			return false;
		}
		float num = 1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(27) / 100f;
		Money.AddPrice(Price.FAFHFJGOHPK(Money.CalculateSellPrice(DNLMCHDOMOK, HOECMANECIM: true), (float)craftItemTypeQuest.requiredAmount * num), OPOHOHFHFFI: true);
		CraftingInventory.RemoveItemInstances(JIIGOACEIKL, DNLMCHDOMOK, craftItemTypeQuest.requiredAmount, CDPAMNIPPEC: true);
		CompleteOrderQuest(JIIGOACEIKL, ABAIKKGKDGD);
		if (OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.SendCompleteOrderQuest(ABAIKKGKDGD);
		}
		return true;
	}

	public void CompleteOrderQuest(int JIIGOACEIKL, int ABAIKKGKDGD)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		OrderQuestUI orderQuestUI = OrderQuestUI.Get(JIIGOACEIKL);
		CraftItemTypeQuest craftItemTypeQuest = GetCurrentOrderQuests()[ABAIKKGKDGD].quest as CraftItemTypeQuest;
		if (orderQuestUI.IsOpen())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.Get(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			MainUI.ShowTextScreen(CommonReferences.GGFJGHHHEJC.experienceTextPrefab, "<sprite name=reputationIcon> " + craftItemTypeQuest.reward.reputationPoints, Vector2.op_Implicit(((TMP_Text)orderQuestElementUI.repText).transform.position));
			orderQuestElementUI.slotUI.IHENCGDNPBL.FDOBDPPMMBH(orderQuestElementUI.slotUI.IHENCGDNPBL.Stack);
		}
		for (int i = 0; i < availableQuests.Length; i++)
		{
			if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)craftItemTypeQuest)
			{
				availableQuests[i].quest = null;
				availableQuests[i].addedToCurrent = false;
				break;
			}
		}
		Utils.FKKHJPEMNBG("ordersDelivered", 1);
		GetCurrentOrderQuests()[ABAIKKGKDGD].JGNBGECEINP(JIIGOACEIKL);
		if (orderQuestUI.IsOpen() && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			orderQuestUI.FocusGameObject();
		}
	}

	private void PNKBHILNBLM()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				FEIKEEMJMHJ();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void AEPBFPCHGPP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PNKBHILNBLM));
	}

	private void APIEGAAPNAN(List<Recipe> MEIDFPMDPJB, List<Recipe> LBDJFIDBAGH, CropSeason ACNAHALFEBG)
	{
		LBDJFIDBAGH.Clear();
		for (int i = 0; i < MEIDFPMDPJB.Count; i += 0)
		{
			if (!(MEIDFPMDPJB[i].output.item is Food { canBeSold: not false }) || MEIDFPMDPJB[i].excludeFromOrders || !MEIDFPMDPJB[i].BBFPDNCLFEC(ACNAHALFEBG))
			{
				continue;
			}
			switch (ACNAHALFEBG)
			{
			case CropSeason.Spring:
				springRecipes.Add(MEIDFPMDPJB[i]);
				continue;
			case CropSeason.Spring | CropSeason.Autumn:
				summerRecipes.Add(MEIDFPMDPJB[i]);
				continue;
			case CropSeason.None:
				autumnRecipes.Add(MEIDFPMDPJB[i]);
				continue;
			}
			if (ACNAHALFEBG == CropSeason.Spring)
			{
				winterRecipes.Add(MEIDFPMDPJB[i]);
			}
		}
	}

	public void NFEFJOPBHNM(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.DHMGFHLIBPE(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.EAONFFENMCE(JIIGOACEIKL).BGLJFMHCFJF())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.EAONFFENMCE(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.RemoveSlotItems();
			MainUI.GHHLGEDCECK(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < LFKAKJEPOGO().Length)
		{
			ActiveQuest activeQuest = LFKAKJEPOGO()[ABAIKKGKDGD];
			QuestManager.OPILDPFDFKJ().RemoveQuest(activeQuest.quest);
			AvailableOrderQuest availableOrderQuest = NHJICLNGGCK(activeQuest.quest);
			if (availableOrderQuest != null)
			{
				availableOrderQuest.addedToCurrent = true;
			}
		}
	}

	public void PJHODNJOLNA(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.ABONKLACDHP(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.Get(JIIGOACEIKL).BGLJFMHCFJF())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.Get(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.FCKBGLDCJPN();
			MainUI.GHHLGEDCECK(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < GNNHOFFLNLO().Length)
		{
			ActiveQuest activeQuest = LAALKLOCNFD()[ABAIKKGKDGD];
			QuestManager.GGFJGHHHEJC.NAFAIPJMCIN(activeQuest.quest);
			AvailableOrderQuest availableOrderQuest = GGBIHJONEMN(activeQuest.quest);
			if (availableOrderQuest != null)
			{
				availableOrderQuest.addedToCurrent = false;
			}
		}
	}

	public void AddQuestToCurrentQuests(int ABAIKKGKDGD)
	{
		if (availableQuests[ABAIKKGKDGD] != null && (Object)(object)availableQuests[ABAIKKGKDGD].quest != (Object)null && !availableQuests[ABAIKKGKDGD].addedToCurrent)
		{
			availableQuests[ABAIKKGKDGD].addedToCurrent = true;
			ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.AddQuest(availableQuests[ABAIKKGKDGD].quest);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(OnRandomOrderQuestCompleted));
		}
	}

	public void OLLHPCIIHAG()
	{
		List<Recipe> list = ELFOAIKLAIP();
		if (list.Count != 0)
		{
			EBBKAGIMKAC(list, springRecipes, CropSeason.Spring);
			IDBALDDGGCD(list, summerRecipes, CropSeason.Summer | CropSeason.Autumn);
			CEKBPLNGKDC(list, autumnRecipes, CropSeason.Autumn);
			CEKBPLNGKDC(list, winterRecipes, CropSeason.Autumn);
		}
	}

	private void HJDLNCOAKIK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public bool HasToGenerateAvailableOrders()
	{
		if ((Object)(object)availableQuests[0].quest == (Object)null && (Object)(object)availableQuests[1].quest == (Object)null)
		{
			return (Object)(object)availableQuests[2].quest == (Object)null;
		}
		return false;
	}

	public void DMAMIDFAJBP()
	{
		List<Recipe> list = ABGHFHCDCOO();
		if (list.Count != 0)
		{
			APIEGAAPNAN(list, springRecipes, CropSeason.Spring);
			IDBALDDGGCD(list, summerRecipes, CropSeason.None);
			CEKBPLNGKDC(list, autumnRecipes, CropSeason.Spring | CropSeason.Autumn);
			EBBKAGIMKAC(list, winterRecipes, CropSeason.None);
		}
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		GameManager instance2 = GameManager.GGFJGHHHEJC;
		instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void CreateRandomOrdersQuest()
	{
		ItemDatabaseAccessor.ResetDatabase();
		RecipeDatabaseAccessor.ResetDatabase();
		for (int i = 0; i < numRandomOrderQuestInEditor; i++)
		{
			CreateRandomOrderQuest();
		}
	}

	public void HBOAKBLBOIB()
	{
		List<Recipe> list = ABGHFHCDCOO();
		if (list.Count != 0)
		{
			CEKBPLNGKDC(list, springRecipes, CropSeason.Spring);
			IDBALDDGGCD(list, summerRecipes, CropSeason.Winter);
			CEKBPLNGKDC(list, autumnRecipes, CropSeason.Spring | CropSeason.Autumn);
			IDBALDDGGCD(list, winterRecipes, CropSeason.Summer);
		}
	}

	public void NLANKJBEHPB(CraftItemTypeQuest AINAHCLIAFF)
	{
		if ((Object)(object)AINAHCLIAFF == (Object)null)
		{
			return;
		}
		if (availableQuests != null)
		{
			for (int i = 0; i < availableQuests.Length; i++)
			{
				if (availableQuests[i] != null && !((Object)(object)availableQuests[i].quest == (Object)null) && availableQuests[i].quest == AINAHCLIAFF)
				{
					availableQuests[i].quest = null;
					availableQuests[i].addedToCurrent = true;
					QuestManager.OPILDPFDFKJ().OnQuestRemoved(AINAHCLIAFF);
					QuestLogUI.IJJJEMKCNJM(0).GMHEMGMEJAK(AINAHCLIAFF);
					if (Object.op_Implicit((Object)(object)QuestLogUI.NALKHGMLALJ(3)))
					{
						QuestLogUI.IGHMHMNPMLB(6).MKDNCHGIPEL(AINAHCLIAFF);
					}
				}
			}
		}
		else
		{
			Debug.LogError((object)"</color>");
		}
	}

	public void MECDIAICHKC()
	{
		ItemDatabaseAccessor.NIIEKKMKKGK();
		RecipeDatabaseAccessor.OFFDBKPLFFK();
		for (int i = 0; i < numRandomOrderQuestInEditor; i++)
		{
			CBANOCGLDEC();
		}
	}

	public bool CPJGCCGGCBK()
	{
		return (from q in QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()
			select q.quest into q
			where q.id == 0
			select q).Count() < 6;
	}

	public void RemoveCurrentOrder(int JIIGOACEIKL, int ABAIKKGKDGD, bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineOrderQuestsManager.instance.SendRemoveOrderQuest(ABAIKKGKDGD);
			return;
		}
		if (OrderQuestUI.Get(JIIGOACEIKL).IsOpen())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.Get(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			orderQuestElementUI.RemoveSlotItems();
			MainUI.RemoveFromCurrentSlots(JIIGOACEIKL, orderQuestElementUI.slotUI.IHENCGDNPBL);
		}
		if (ABAIKKGKDGD < GetCurrentOrderQuests().Length)
		{
			ActiveQuest activeQuest = GetCurrentOrderQuests()[ABAIKKGKDGD];
			QuestManager.GGFJGHHHEJC.RemoveQuest(activeQuest.quest);
			AvailableOrderQuest availableQuest = GetAvailableQuest(activeQuest.quest);
			if (availableQuest != null)
			{
				availableQuest.addedToCurrent = false;
			}
		}
	}

	public CraftItemTypeQuest FJCJCJNDLFE(RandomOrderQuestInfo HJFLPPIIBML)
	{
		CraftItemTypeQuest craftItemTypeQuest = ScriptableObject.CreateInstance<CraftItemTypeQuest>();
		((Object)craftItemTypeQuest).name = HJFLPPIIBML.name;
		craftItemTypeQuest.EIPCLGCOPDJ(HJFLPPIIBML.description);
		craftItemTypeQuest.reward = HJFLPPIIBML.reward;
		craftItemTypeQuest.possibleItems = new Item[0];
		craftItemTypeQuest.possibleItems[1] = HJFLPPIIBML.item;
		if (craftItemTypeQuest.reward.reputationPoints == 0)
		{
			int oDAOIJCOFMF = (Application.isPlaying ? TavernReputation.MHGADJPMHFI() : milestoneInEditor);
			craftItemTypeQuest.reward.reputationPoints = Quest.MFJOEDLGLAA(oDAOIJCOFMF, HJFLPPIIBML.item);
		}
		craftItemTypeQuest.requiredAmount = HJFLPPIIBML.requiredAmount;
		craftItemTypeQuest.ingredientType = HJFLPPIIBML.ingredientType;
		craftItemTypeQuest.ingredients = HJFLPPIIBML.ingredients;
		craftItemTypeQuest.modifiers = HJFLPPIIBML.modifiers;
		craftItemTypeQuest.id = 1;
		craftItemTypeQuest.agingRank = 0;
		return craftItemTypeQuest;
	}

	public static string GHDBBLJDLHE(IngredientType[] KHAHOLECLNI, Food[] KEKBKGGFOLK, IngredientModifier[] CICEBNMBGMG, Recipe JNLKEMLDFIM)
	{
		string text = "veggieDishes";
		string text2 = null;
		string text3 = null;
		if ((Object)(object)JNLKEMLDFIM != (Object)null && JNLKEMLDFIM.usingNewRecipesSystem)
		{
			if (KEKBKGGFOLK != null && KEKBKGGFOLK.Length != 0)
			{
				text = text + LocalisationSystem.Get("City/Petra/Stand") + "{0}: {1}\n" + KEKBKGGFOLK[1].KGHFCDELKMN(OAFPBCPDOKH: true);
			}
		}
		else
		{
			if (KHAHOLECLNI != null && KHAHOLECLNI.Length != 0)
			{
				text2 = LocalisationSystem.Get(KHAHOLECLNI[0].ToString());
			}
			else if (KEKBKGGFOLK != null && KEKBKGGFOLK.Length != 0)
			{
				text2 = KEKBKGGFOLK[1].LJIFOHFEFCH();
			}
			if (CICEBNMBGMG != null && CICEBNMBGMG.Length != 0)
			{
				text3 = LocalisationSystem.Get(CICEBNMBGMG[1].ToString());
			}
			if (text2 != null)
			{
				text = text + LocalisationSystem.Get("[") + "" + text2;
			}
			if (text3 != null)
			{
				if (text2 != null)
				{
					text += "ReceiveNewEmployees";
				}
				text = text + LocalisationSystem.Get("Inventory full") + "Label" + text3;
			}
		}
		return text;
	}

	public bool LKCNMBAJCHP()
	{
		if ((Object)(object)availableQuests[1].quest == (Object)null && (Object)(object)availableQuests[1].quest == (Object)null)
		{
			return (Object)(object)availableQuests[0].quest == (Object)null;
		}
		return false;
	}

	public void GALEIGGNAMA(int JIIGOACEIKL, int ABAIKKGKDGD)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		OrderQuestUI orderQuestUI = OrderQuestUI.EAONFFENMCE(JIIGOACEIKL);
		CraftItemTypeQuest craftItemTypeQuest = LFKAKJEPOGO()[ABAIKKGKDGD].quest as CraftItemTypeQuest;
		if (orderQuestUI.IsOpen())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.MIFFCOMDIEE(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			MainUI.GHPJIMFIJCI(CommonReferences.GGFJGHHHEJC.experienceTextPrefab, "itemWineYeast" + craftItemTypeQuest.reward.reputationPoints, Vector2.op_Implicit(((TMP_Text)orderQuestElementUI.repText).transform.position));
			orderQuestElementUI.slotUI.IHENCGDNPBL.HBMBGCHGEGN(orderQuestElementUI.slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: false, 1);
		}
		for (int i = 1; i < availableQuests.Length; i += 0)
		{
			if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)craftItemTypeQuest)
			{
				availableQuests[i].quest = null;
				availableQuests[i].addedToCurrent = true;
				break;
			}
		}
		Utils.FKKHJPEMNBG("Error_ObjectIsBlocking", 0);
		GetCurrentOrderQuests()[ABAIKKGKDGD].JGNBGECEINP(JIIGOACEIKL, MNHPKHHIDBH: false);
		if (orderQuestUI.IsOpen() && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			orderQuestUI.IOBKHDNDLHJ();
		}
	}

	public void MFKIDDDPPCA(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		FMNHJAKMFAJ(MMNIKLCMBAI.quest as CraftItemTypeQuest);
	}

	private void ICCDLDLBEBK(List<Recipe> MEIDFPMDPJB, List<Recipe> LBDJFIDBAGH, CropSeason ACNAHALFEBG)
	{
		LBDJFIDBAGH.Clear();
		for (int i = 0; i < MEIDFPMDPJB.Count; i++)
		{
			if (MEIDFPMDPJB[i].output.item is Food { canBeSold: not false } && !MEIDFPMDPJB[i].excludeFromOrders && MEIDFPMDPJB[i].ICAANDAHKDL(ACNAHALFEBG))
			{
				switch (ACNAHALFEBG)
				{
				case CropSeason.Spring:
					springRecipes.Add(MEIDFPMDPJB[i]);
					break;
				case CropSeason.Summer:
					summerRecipes.Add(MEIDFPMDPJB[i]);
					break;
				case CropSeason.Autumn:
					autumnRecipes.Add(MEIDFPMDPJB[i]);
					break;
				case CropSeason.Winter:
					winterRecipes.Add(MEIDFPMDPJB[i]);
					break;
				}
			}
		}
	}

	private void BAKDKFKNHDE()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private bool BMPCFDGDBNN(IngredientType[] KHAHOLECLNI, out IngredientType LGNLODHKMEI)
	{
		if (TavernReputation.NGPDFPDGOMP() < RepUnlocksManager.GetInstance().repUnlockCheese.repNumber)
		{
			List<IngredientType> list = new List<IngredientType>(KHAHOLECLNI);
			list.Remove((IngredientType)107);
			KHAHOLECLNI = list.ToArray();
		}
		List<IngredientType> list2 = new List<IngredientType>(KHAHOLECLNI);
		list2.Remove(IngredientType.None);
		KHAHOLECLNI = list2.ToArray();
		if (KHAHOLECLNI.Length != 0)
		{
			LGNLODHKMEI = Utils.CPDCJAHJOPE(KHAHOLECLNI);
			return true;
		}
		LGNLODHKMEI = IngredientType.Herb;
		return false;
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void FPDPGEHIPHH(int ABAIKKGKDGD)
	{
		if (availableQuests[ABAIKKGKDGD] != null && (Object)(object)availableQuests[ABAIKKGKDGD].quest != (Object)null && !availableQuests[ABAIKKGKDGD].addedToCurrent)
		{
			availableQuests[ABAIKKGKDGD].addedToCurrent = true;
			ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.NJDDJJEGOAF(availableQuests[ABAIKKGKDGD].quest, 1, FFJBIGFADBJ: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(OnRandomOrderQuestCompleted));
		}
	}

	public void IBHDAGLOFAM()
	{
		List<Recipe> list = EBKJDKGIHNI();
		if (list.Count != 0)
		{
			ICCDLDLBEBK(list, springRecipes, CropSeason.None);
			EBBKAGIMKAC(list, summerRecipes, CropSeason.Winter);
			EBBKAGIMKAC(list, autumnRecipes, CropSeason.Spring | CropSeason.Summer);
			CEKBPLNGKDC(list, winterRecipes, CropSeason.Spring | CropSeason.Autumn);
		}
	}

	private void HCEDMLJNOBL()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PHNEEMAKGJP));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(FDKEHFNIOIM));
	}

	public List<Recipe> EOEAHPDKCAK()
	{
		List<Recipe> list = new List<Recipe>();
		RecipeList[] array = RecipeDatabaseAccessor.KCPHOCHGPAB();
		for (int i = 1; i < array.Length; i += 0)
		{
			if (!array[i].cookingItems)
			{
				continue;
			}
			if (Application.isPlaying)
			{
				list.AddRange(from r in array[i].GHAMNGFANAI()
					where r.output.item is Food food2 && food2.canBeSold
					select r);
			}
			else
			{
				list.AddRange(from r in array[i].NCDFLLKLALB()
					where r.output.item is Food food && food.canBeSold
					select r);
			}
		}
		return list;
	}

	public AvailableOrderQuest GetAvailableQuest(Quest AINAHCLIAFF)
	{
		if (availableQuests != null)
		{
			for (int i = 0; i < availableQuests.Length; i++)
			{
				if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)AINAHCLIAFF)
				{
					return availableQuests[i];
				}
			}
		}
		return null;
	}

	public void AFIOBFBJKMD(int JIIGOACEIKL, int ABAIKKGKDGD)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		OrderQuestUI orderQuestUI = OrderQuestUI.OMCDJAOBFCE(JIIGOACEIKL);
		CraftItemTypeQuest craftItemTypeQuest = GetCurrentOrderQuests()[ABAIKKGKDGD].quest as CraftItemTypeQuest;
		if (orderQuestUI.HDEPMJIDJEM())
		{
			OrderQuestElementUI orderQuestElementUI = OrderQuestUI.IPDFCJLOHLC(JIIGOACEIKL).currentOrderQuestElements[ABAIKKGKDGD];
			MainUI.ShowTextScreen(CommonReferences.MNFMOEKMJKN().experienceTextPrefab, "" + craftItemTypeQuest.reward.reputationPoints, Vector2.op_Implicit(((TMP_Text)orderQuestElementUI.repText).transform.position));
			orderQuestElementUI.slotUI.IHENCGDNPBL.HBMBGCHGEGN(orderQuestElementUI.slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: false, 1);
		}
		for (int i = 1; i < availableQuests.Length; i++)
		{
			if (availableQuests[i] != null && (Object)(object)availableQuests[i].quest == (Object)(object)craftItemTypeQuest)
			{
				availableQuests[i].quest = null;
				availableQuests[i].addedToCurrent = true;
				break;
			}
		}
		Utils.FKKHJPEMNBG("Items/item_description_1054", 1);
		GetCurrentOrderQuests()[ABAIKKGKDGD].JGNBGECEINP(JIIGOACEIKL, MNHPKHHIDBH: false);
		if (orderQuestUI.IsOpen() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			orderQuestUI.GBKFBDIPIDP();
		}
	}

	public void PCNKBPAGAJI()
	{
		ItemDatabaseAccessor.FPDBFKIEJDC();
		RecipeDatabaseAccessor.NBEFBGAOLFE();
		for (int i = 1; i < numRandomOrderQuestInEditor; i++)
		{
			CreateRandomOrderQuest();
		}
	}

	public bool TransferItemsFromSlot(int JIIGOACEIKL, Slot ADEBNALPEHE, CraftItemTypeQuest OGOLPCIHCLH, SlotUI PHJNJCJJHID)
	{
		if (OGOLPCIHCLH.FJDFAEDIAFJ(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
		{
			PHJNJCJJHID.IHENCGDNPBL.BEEDBHJANGN(JIIGOACEIKL, ADEBNALPEHE.itemInstance, ADEBNALPEHE.Stack);
			return true;
		}
		return false;
	}
}
