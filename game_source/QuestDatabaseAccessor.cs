using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestDatabaseAccessor : MonoBehaviour
{
	private static QuestDatabaseAccessor GGFJGHHHEJC;

	[SerializeField]
	private QuestDatabase questDatabaseSO;

	private Dictionary<int, Quest> LGANMFCPLOM;

	private void NEOICNJNKNL()
	{
		GGFJGHHHEJC = this;
		PJAEPJKJMAG();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.OLLFFLGNLCC();
			}
		}
	}

	private void FOJAHMIJJJM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void AAENCDNIBFJ()
	{
		GGFJGHHHEJC = this;
		EBHCGJIMKAM();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	private void AMNCIAEMBFO()
	{
		GGFJGHHHEJC = this;
		FDHLCGNGJII();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.LLINLDNJMEI();
			}
		}
	}

	private void JBBHDOMALDB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JNKKJELMCNN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void ONIALAOGMCF()
	{
		GGFJGHHHEJC = this;
		PHOHABCLHGO();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	public static Quest MGGNBIOLKDH(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ReceiveCollectItemsMaster" + JFNMCNCHMEO));
		return null;
	}

	private void OEAAPIBLALL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void BEGPEFGJCDG()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"ErrorJoinRoomClosed");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Game" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)(". Time since startup: " + quest.id + "KyrohNPC: Selected order with already ingredients in bento: " + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "itemMint" + ((Object)quest).name));
			}
		}
	}

	private void OGEJKOIOKAN()
	{
		GGFJGHHHEJC = this;
		BBAMEABOPOJ();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.LLINLDNJMEI();
			}
		}
	}

	private void FJBPFOIALMK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static int LDMAONPBBAF(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.GKGFILCAMJM(OGOLPCIHCLH);
	}

	public static int OFIAJNCGKJL(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.MNNHFBEAELD(OGOLPCIHCLH);
	}

	private void EJPHHEPNPKK()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"NightStart not attached to prefab ");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("OLD" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Failed to sign in for reason " + quest.id + "Player" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Language" + ((Object)quest).name));
			}
		}
	}

	public static Quest IBOBPANPHAE(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("SortByType" + JFNMCNCHMEO));
		return null;
	}

	public static int GICBBCJLBGO(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.FNAAKBNDCJJ(OGOLPCIHCLH);
	}

	private void HLHHDNGOGNI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HMANFAEHJCA()
	{
		GGFJGHHHEJC = this;
		LFDGMMLEDGI();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.LLINLDNJMEI();
			}
		}
	}

	public static int CCIGFLGFONN(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.FAMCCNEPLKI(OGOLPCIHCLH);
	}

	private void DONGKOKMGMM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HFPDNCBLNDE()
	{
		GGFJGHHHEJC = this;
		LFDGMMLEDGI();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.JAHHAIBKFFO();
			}
		}
	}

	public static Quest MFCLBOPPEBB(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Remove" + JFNMCNCHMEO));
		return null;
	}

	public static Quest JHOAPLEPKKK(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Already learnt!" + JFNMCNCHMEO));
		return null;
	}

	private void DEHDIPKFEKM()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Statue1={0} | " + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/6/Dialogue Text" + quest.id + "Failed to load psai soundtrack from path '" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Exit build mode" + ((Object)quest).name));
			}
		}
	}

	private void GOJKOBEEMNA()
	{
		GGFJGHHHEJC = this;
		NOLCHICHJDO();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.JAHHAIBKFFO();
			}
		}
	}

	private void EAAAEOPANPB()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Name");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("LE_21" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("LE_22" + quest.id + "Upgrade" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Walk" + ((Object)quest).name));
			}
		}
	}

	private void AGILHHEMEFC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void OJAJLIAMGEJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Quest DIBHHGJNNFH(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Argos" + JFNMCNCHMEO));
		return null;
	}

	private void HLCAKACHOOE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	private void NODKJHJFMCO()
	{
		GGFJGHHHEJC = this;
		EAAAEOPANPB();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.JAHHAIBKFFO();
			}
		}
	}

	private void IKIPGJNEJNG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DBCEKDGEOMM()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"quest_objective_");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Hiding Keyboard " + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)(" not found. Cannot receive permission accepted to player " + quest.id + "%" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "MainProgress" + ((Object)quest).name));
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

	private void EFABNGNAENH()
	{
		GGFJGHHHEJC = this;
		EJPHHEPNPKK();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.OLLFFLGNLCC();
			}
		}
	}

	private void FHDGNECEJMC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void MDIENLHEDGE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void NOLCHICHJDO()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Wilson/Bark/Bark_Bye");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("CaramelAleAbbreviation" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("ReceiveCrystalHit" + quest.id + "Items/item_description_661" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "currentTutorialPhaseID " + ((Object)quest).name));
			}
		}
	}

	public static Quest BAPKGPKIGHP(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("piratescave" + JFNMCNCHMEO));
		return null;
	}

	private void MFJIHCKEIIF()
	{
		GGFJGHHHEJC = this;
		FIHLKGANFLM();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	private void FDHLCGNGJII()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"descPaperCoaster");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Items/item_name_602" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("ReceiveTrigger" + quest.id + "PressSPACE" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "\n" + ((Object)quest).name));
			}
		}
	}

	private void LGMNOHJHKDH()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Crafting");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)(", " + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("IntensitySectionCanvas/IntensitySection" + quest.id + "Ignore Raycast" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Hit" + ((Object)quest).name));
			}
		}
	}

	private void PNOPPINFCML()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Could not check user signed in status for reason ");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("ReceiveNinjaChallengeEventFadeOut" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("ReceiveOnConversationResponseMenu" + quest.id + "Dialogue System/Conversation/Crowly_Introduce/Entry/37/Dialogue Text" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "\n" + ((Object)quest).name));
			}
		}
	}

	private void GMCKBBECJOE()
	{
		GGFJGHHHEJC = this;
		FIHLKGANFLM();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	private void HJANCPIFLIJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void KDOMBHECOJN()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"sForSeconds");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Left Stick Up" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("UISelectGamepad" + quest.id + "Sit" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Unlocked at Tavern Reputation {0}" + ((Object)quest).name));
			}
		}
	}

	private void GBKNIJENJEF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void LFKANGBJLGO()
	{
		GGFJGHHHEJC = this;
		EAAAEOPANPB();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	private void PHOHABCLHGO()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Price");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("itemBitterHopsSeeds" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("itemSpringOnion" + quest.id + " CloseUI ConstructionUI" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "" + ((Object)quest).name));
			}
		}
	}

	private void DNKEFFMOCKP()
	{
		GGFJGHHHEJC = this;
		DBCEKDGEOMM();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.OLLFFLGNLCC();
			}
		}
	}

	public static int NBLACHLMOPK(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.HFNPOCDIDPP(OGOLPCIHCLH);
	}

	public static int GKGFILCAMJM(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.ACCCJKAHDKI(OGOLPCIHCLH);
	}

	public static Quest DMPJEDAGDEI(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("itemRoseWineJuice" + JFNMCNCHMEO));
		return null;
	}

	private void OJJCGNICMBD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Quest DJMDLPHMPEL(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("No MinePuzzleBase found for type {0}" + JFNMCNCHMEO));
		return null;
	}

	public static int OFINHHEFCAN(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.MGIMGFKHJOC(OGOLPCIHCLH);
	}

	public static Quest PALCOBBGFGM(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("MainProgress" + JFNMCNCHMEO));
		return null;
	}

	private void IIPKPMPGLOL()
	{
		GGFJGHHHEJC = this;
		CIANHMMPJOO();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.JAHHAIBKFFO();
			}
		}
	}

	private void PKILBBEDHBH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HFKOBCFMNJJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void AJGPMBGBPGH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static int EAPLFAEGMBN(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.HFNPOCDIDPP(OGOLPCIHCLH);
	}

	private void FMKANEPMJFE()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Attack/MainEvent 9");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("0" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("ServedCustomers" + quest.id + "LoopVolume" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Items/item_description_669" + ((Object)quest).name));
			}
		}
	}

	public static int JJJOFMFLEDN(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.MGIMGFKHJOC(OGOLPCIHCLH);
	}

	private void JDABCGEEIBF()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"itemAubergineSeeds");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Interact" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Dialogue System/Conversation/Gass_Quest/Entry/35/Dialogue Text" + quest.id + "Meditation" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Items/item_name_1075" + ((Object)quest).name));
			}
		}
	}

	public static Quest GKOCDANPNLD(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ReceivePourWater" + JFNMCNCHMEO));
		return null;
	}

	private void FJIKFLGOFJP()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"ReceiveBarkInfoWithObjectAndLuaInt");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Exit build mode" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("LE_21" + quest.id + "room_name" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Balance/MainEvent" + ((Object)quest).name));
			}
		}
	}

	private void BLAJFMAAMDO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void LFDGMMLEDGI()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"[OfferingStatuePuzzle] No required items configured in OfferingPuzzleSettings.");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("KickedSpinDirection" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Dismiss" + quest.id + "ReceiveTreeInfo" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Request begin replay" + ((Object)quest).name));
			}
		}
	}

	private void FGLJPGBFPBC()
	{
		GGFJGHHHEJC = this;
		EBHCGJIMKAM();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.OLLFFLGNLCC();
			}
		}
	}

	private void NHIOFNINLLK()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Items/item_description_634");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("ControllerInfo without nameID: " + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Items/item_name_1177" + quest.id + "Items/item_description_724" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Rotate Placeable" + ((Object)quest).name));
			}
		}
	}

	private void NHNAAFGHPEC()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"DecorationTile_3");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)(": " + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("LE_16" + quest.id + "SmokeBomb" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Need exactly {0} SymbolStatueInteractable references" + ((Object)quest).name));
			}
		}
	}

	private void CIANHMMPJOO()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"CookiesNeeded");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("GetYourPlush" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Interact" + quest.id + "Dog" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Plant" + ((Object)quest).name));
			}
		}
	}

	private void KJHKBGDJNDC()
	{
		GGFJGHHHEJC = this;
		EBHCGJIMKAM();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.JAHHAIBKFFO();
			}
		}
	}

	public static Quest HMMFCOFIGMN(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Mussel without parent!" + JFNMCNCHMEO));
		return null;
	}

	public static Quest BBGBOLLAGKN(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Close" + JFNMCNCHMEO));
		return null;
	}

	private void MPGPLILIJOD()
	{
		GGFJGHHHEJC = this;
		LGMNOHJHKDH();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.OLLFFLGNLCC();
			}
		}
	}

	private void PNLAJCHBHPH()
	{
		GGFJGHHHEJC = this;
		LFDGMMLEDGI();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.JAHHAIBKFFO();
			}
		}
	}

	public static Quest IMGKJJNFFPD(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Null item in database: " + JFNMCNCHMEO));
		return null;
	}

	private void KLHIMJFCHPD()
	{
		GGFJGHHHEJC = this;
		KDOMBHECOJN();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static int KDKEDKDAAFK(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.JOJKNGEJOGH(OGOLPCIHCLH);
	}

	private void LKHMCLABKLG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DKNNLPFIBIK()
	{
		GGFJGHHHEJC = this;
		FJIKFLGOFJP();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.LLINLDNJMEI();
			}
		}
	}

	private void PJAEPJKJMAG()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"GB");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Order quest" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Actionbar 7" + quest.id + "OnlinePlayer" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "allTavernPositions is empty" + ((Object)quest).name));
			}
		}
	}

	public static int AddQuest(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.BAALKNEHBBM(OGOLPCIHCLH);
	}

	public static Quest LIOCDDEMOMC(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("" + JFNMCNCHMEO));
		return null;
	}

	private void PCEFNHADDIG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void EMMGKMCCGDA()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)" - Player points: ");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("%><sprite name=RightStick></size>" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("[MinePuzzleManager] Puzzle {0} placed with {1} elements." + quest.id + "Items/item_name_667" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Duplicate editor action id found: " + ((Object)quest).name));
			}
		}
	}

	private void DMNENKNLDAH()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Null Quest in database");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Quest without ID: " + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Duplicate Quest id found: " + quest.id + " - " + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)quest).name));
			}
		}
	}

	public static Quest MIPBDJIJLLK(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Error with assigned bed {0}" + JFNMCNCHMEO));
		return null;
	}

	public static Quest FMKALGFOBGH(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Pause" + JFNMCNCHMEO));
		return null;
	}

	private void JNJCCIFIKOC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void PGEGODAEBLC()
	{
		GGFJGHHHEJC = this;
		FCDNIFADIAE();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	private void PGPPIHJJGDB()
	{
		GGFJGHHHEJC = this;
		LFDGMMLEDGI();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.OLLFFLGNLCC();
			}
		}
	}

	private void LHAPMEEADKH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Quest HHKKPIHIEJL(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Cancel" + JFNMCNCHMEO));
		return null;
	}

	private void KLMNLEDKEOE()
	{
		GGFJGHHHEJC = this;
		BEGPEFGJCDG();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.MFHHJFEJAMF();
			}
		}
	}

	private void IGNEGEOPLOP()
	{
		GGFJGHHHEJC = this;
		CIANHMMPJOO();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.LLINLDNJMEI();
			}
		}
	}

	private void CJJKLKHKPNB()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 0; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Read");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Light Fire" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Scene " + quest.id + "KyrohScene" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + ". " + ((Object)quest).name));
			}
		}
	}

	private void BDDBDNPCPGC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static int IOFOBPEEDEC(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.PDFAEOHEPNE(OGOLPCIHCLH);
	}

	public static int LHHNHMJNHDD(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.DHLONIEEEHE(OGOLPCIHCLH);
	}

	private void KOBNHPKEJJD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void FIHLKGANFLM()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"Field: ");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("No content to disable in this NPC!" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("chatx" + quest.id + "LE_14" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Need to learn previous XP increase!" + ((Object)quest).name));
			}
		}
	}

	private void OAEJGGFFCBO()
	{
		GGFJGHHHEJC = this;
		FDHLCGNGJII();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.OLLFFLGNLCC();
			}
		}
	}

	public static int OBMNICIDEDH(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.BAALKNEHBBM(OGOLPCIHCLH);
	}

	private void PGABAEGKPIG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Quest JNLONKGAKPB(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("forceintro" + JFNMCNCHMEO));
		return null;
	}

	private void EOPMNBONBBL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void NNGJOHLNKNH()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i += 0)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"ReceiveStartWork ");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Dialogue System/Conversation/Crowly_Standar/Entry/21/Dialogue Text" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("UIInteract" + quest.id + "None" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "ReceiveBirdSlotFromContainer" + ((Object)quest).name));
			}
		}
	}

	private void EICDGBINBAG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void EBHCGJIMKAM()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"MissionTalkWith: NPC not found for character ");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("Item without ID: " + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Reject" + quest.id + "Showing popup " + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "RecieveEndMaiEvent" + ((Object)quest).name));
			}
		}
	}

	private void NOILIOLOOBJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Quest HAGEEBPCFGK(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("The invite code for this game is: {0}." + JFNMCNCHMEO));
		return null;
	}

	private void NAOBODGBECL()
	{
		GGFJGHHHEJC = this;
		EJPHHEPNPKK();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest != (Object)null)
			{
				quest.LLINLDNJMEI();
			}
		}
	}

	public static int OJJCMCFHPOK(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.KDKEDKDAAFK(OGOLPCIHCLH);
	}

	private void MPDOFGBMDPD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Quest GetQuest(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Could not find Quest with id: " + JFNMCNCHMEO));
		return null;
	}

	private void BBAMEABOPOJ()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		foreach (Quest quest in quests)
		{
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"ReceiveCollectItems");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("UseHold" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("add item " + quest.id + "[ActivatePuzzle] Type: " + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "LE_3" + ((Object)quest).name));
			}
		}
	}

	public static Quest GJDOEFIOGEM(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Leave" + JFNMCNCHMEO));
		return null;
	}

	public static Quest ILEMIHPDHKF(int JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			return null;
		}
		if (GGFJGHHHEJC.LGANMFCPLOM.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("No se encontró la base de datos maestra." + JFNMCNCHMEO));
		return null;
	}

	public static int FMPOGABGDBK(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.JOJKNGEJOGH(OGOLPCIHCLH);
	}

	private void MDGLECECOIG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HKECEBGKACL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void FCDNIFADIAE()
	{
		LGANMFCPLOM = new Dictionary<int, Quest>();
		Quest[] quests = questDatabaseSO.quests;
		for (int i = 1; i < quests.Length; i++)
		{
			Quest quest = quests[i];
			if ((Object)(object)quest == (Object)null)
			{
				Debug.Log((object)"itemInk");
				continue;
			}
			if (quest.id == 0)
			{
				Debug.Log((object)("_BaseColor" + ((Object)quest).name));
				continue;
			}
			if (LGANMFCPLOM.ContainsKey(quest.id))
			{
				Debug.Log((object)("Intro/TavernAlone" + quest.id + "talentWine" + ((Object)quest).name));
				continue;
			}
			try
			{
				LGANMFCPLOM.Add(quest.id, quest);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Items/item_name_699" + ((Object)quest).name));
			}
		}
	}

	public static int BFGBBJCLCBM(Quest OGOLPCIHCLH)
	{
		return GGFJGHHHEJC.questDatabaseSO.MNNHFBEAELD(OGOLPCIHCLH);
	}
}
