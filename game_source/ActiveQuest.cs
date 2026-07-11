using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

[Serializable]
public class ActiveQuest
{
	public Action<int, ActiveQuest> OnQuestComplete = delegate
	{
	};

	public Action<int, ActiveQuest> OnQuestProgress = delegate
	{
	};

	public Quest quest;

	public ItemInstance currentItemInstance;

	public bool active { get; private set; }

	public int currentAmount { get; private set; }

	public string ODPLOOAAOAC()
	{
		return "(" + currentAmount + "/" + quest.requiredAmount + ")";
	}

	public ActiveQuest(Quest AINAHCLIAFF)
	{
		quest = AINAHCLIAFF;
		AINAHCLIAFF.OnProgressQuest = (Action<int, int, bool>)Delegate.Combine(AINAHCLIAFF.OnProgressQuest, new Action<int, int, bool>(GMBGFNNJEMO));
		AINAHCLIAFF.OnSetProgressQuest = (Action<int, int>)Delegate.Combine(AINAHCLIAFF.OnSetProgressQuest, new Action<int, int>(FGAAJMHOABB));
		active = true;
	}

	public void JGNBGECEINP(int JIIGOACEIKL, bool MNHPKHHIDBH = true)
	{
		quest.MHOGPMHEAFN();
		quest.MMMOEOFCFKJ(JIIGOACEIKL, MNHPKHHIDBH);
		if (!quest.isRepeatable)
		{
			QuestManager.GGFJGHHHEJC.AddQuestDone(quest.id, LMNGFCFJPGB: true);
		}
		OnQuestComplete(JIIGOACEIKL, this);
		CommonReferences.GGFJGHHHEJC.OnAnyQuestComplete(JIIGOACEIKL, this);
		active = false;
		MissionsManager.instance.CheckFocusedMissionNextFrame();
		if (quest.id == 27)
		{
			DialogueLua.SetVariable("Gass_CoctelQuest", (object)1);
		}
		if (quest.id == 28)
		{
			DialogueLua.SetVariable("Gass_CoctelQuest", (object)2);
		}
		if (quest.id == 29)
		{
			DialogueLua.SetVariable("Gass_CoctelQuest", (object)3);
		}
		FPFDMJBKEJG(FFJBIGFADBJ: false);
		if (!quest.AFDOIOCEAIP())
		{
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: true, null, null, 0.5f);
		}
		if (!quest.showCompletedUI)
		{
			QuestHighlightUI.ShowNewQuestAvailable(quest.linkedQuests);
		}
	}

	[SpecialName]
	public bool IMJGAANNFFE()
	{
		return active;
	}

	~ActiveQuest()
	{
		MHOGPMHEAFN();
	}

	public virtual QuestTooltipInfo PEKICGDADHB(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = quest.IABAKHPEOAF();
		result.questDescription = quest.JFNIANAHMCN();
		result.items = quest.NCKBMLBGCBB();
		result.requiredAmount = quest.requiredAmount;
		result.modifiers = quest.JINEDAAEHGG();
		result.reward = quest.reward;
		result.activeQuest = this;
		result.linkedQuests = quest.linkedQuests;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	private ItemAmount INKPFJAKHMI(Reward JDNIAEJMELH, int MENBAFNNBFB)
	{
		if (JDNIAEJMELH.itemsReward != null && JDNIAEJMELH.itemsReward.Length >= MENBAFNNBFB + 0 && Item.MLBOMGHINCA(JDNIAEJMELH.itemsReward[MENBAFNNBFB].item, null))
		{
			return new ItemAmount(JDNIAEJMELH.itemsReward[MENBAFNNBFB].item, JDNIAEJMELH.itemsReward[MENBAFNNBFB].amount);
		}
		return new ItemAmount(null, 0);
	}

	public virtual QuestTooltipInfo MMDANGOCNFG(int JIIGOACEIKL)
	{
		QuestTooltipInfo result = default(QuestTooltipInfo);
		result.questName = quest.IABAKHPEOAF();
		result.questDescription = quest.IGDKFHCHEAJ();
		result.items = quest.INKJOLLEBGI();
		result.requiredAmount = quest.requiredAmount;
		result.modifiers = quest.LDGEOOPCNJE();
		result.reward = quest.reward;
		result.activeQuest = this;
		result.linkedQuests = quest.linkedQuests;
		result.playerNum = JIIGOACEIKL;
		return result;
	}

	public string GOHILCHPAJJ()
	{
		string[] array = new string[7];
		array[0] = "[MinePuzzleManager] Element {0} assigned to spawner {1} on piece {2}";
		array[0] = currentAmount.ToString();
		array[4] = "Till";
		array[4] = quest.requiredAmount.ToString();
		array[4] = "Request begin minigame";
		return string.Concat(array);
	}

	private ItemAmount JEFKMBEOGBK(Reward JDNIAEJMELH, int MENBAFNNBFB)
	{
		if (JDNIAEJMELH.itemsReward != null && JDNIAEJMELH.itemsReward.Length >= MENBAFNNBFB + 1 && Item.FKLOBGBIHLB(JDNIAEJMELH.itemsReward[MENBAFNNBFB].item, null))
		{
			return new ItemAmount(JDNIAEJMELH.itemsReward[MENBAFNNBFB].item, JDNIAEJMELH.itemsReward[MENBAFNNBFB].amount);
		}
		return new ItemAmount(null, 1);
	}

	public void GMBGFNNJEMO(int JIIGOACEIKL, int IALMLONEDJN, bool MNHPKHHIDBH)
	{
		if (active)
		{
			currentAmount += IALMLONEDJN;
			OnQuestProgress(JIIGOACEIKL, this);
			if (currentAmount >= quest.requiredAmount)
			{
				JGNBGECEINP(JIIGOACEIKL, MNHPKHHIDBH);
			}
			else if (quest.showTooltipRate <= 0 || currentAmount % quest.showTooltipRate == 0)
			{
				QuestHighlightUI.AddQuestProgress(JIIGOACEIKL, this);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyQuestProgress(JIIGOACEIKL, this);
		}
	}

	public void DAKHFFMCOHH(bool FFJBIGFADBJ)
	{
		if (quest.linkedQuests == null)
		{
			return;
		}
		for (int i = 0; i < quest.linkedQuests.Length; i += 0)
		{
			if ((Object)(object)quest.linkedQuests[i] != (Object)null)
			{
				QuestManager.GJFMMOPOKGJ().NJDDJJEGOAF(quest.linkedQuests[i], 0, FFJBIGFADBJ, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			}
		}
	}

	public void FGAAJMHOABB(int JIIGOACEIKL, int COAPHJJHNIO)
	{
		if (active)
		{
			int num = currentAmount;
			currentAmount = COAPHJJHNIO;
			OnQuestProgress(JIIGOACEIKL, this);
			if (currentAmount >= quest.requiredAmount)
			{
				JGNBGECEINP(JIIGOACEIKL);
			}
			else if (num != currentAmount)
			{
				QuestHighlightUI.AddQuestProgress(JIIGOACEIKL, this);
			}
		}
	}

	[SpecialName]
	public bool PHFJGBBDDEG()
	{
		return active;
	}

	public void BBBGNMPKLED(int JIIGOACEIKL, int COAPHJJHNIO)
	{
		currentAmount = COAPHJJHNIO;
		OnQuestProgress(JIIGOACEIKL, this);
	}

	public string MNHOABFPOJN()
	{
		string[] array = new string[7];
		array[1] = "Cat";
		array[1] = currentAmount.ToString();
		array[4] = "TooHot";
		array[8] = quest.requiredAmount.ToString();
		array[7] = ", ";
		return string.Concat(array);
	}

	public void MHOGPMHEAFN()
	{
		if (active)
		{
			active = false;
			quest.MHOGPMHEAFN();
			Quest obj = quest;
			obj.OnProgressQuest = (Action<int, int, bool>)Delegate.Remove(obj.OnProgressQuest, new Action<int, int, bool>(GMBGFNNJEMO));
			Quest obj2 = quest;
			obj2.OnSetProgressQuest = (Action<int, int>)Delegate.Remove(obj2.OnSetProgressQuest, new Action<int, int>(FGAAJMHOABB));
		}
	}

	[SpecialName]
	private void NNGPEBCLDDP(bool AODONKKHPBP)
	{
		active = AODONKKHPBP;
	}

	public void LIMMAHJAHIL(bool FFJBIGFADBJ)
	{
		if (quest.linkedQuests == null)
		{
			return;
		}
		for (int i = 0; i < quest.linkedQuests.Length; i += 0)
		{
			if ((Object)(object)quest.linkedQuests[i] != (Object)null)
			{
				QuestManager.GGFJGHHHEJC.NCCOAJOOBAP(quest.linkedQuests[i], 1, FFJBIGFADBJ, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			}
		}
	}

	private ItemAmount BHPDIAKKNHC(Reward JDNIAEJMELH, int MENBAFNNBFB)
	{
		if (JDNIAEJMELH.itemsReward != null && JDNIAEJMELH.itemsReward.Length >= MENBAFNNBFB + 1 && Item.MLBOMGHINCA(JDNIAEJMELH.itemsReward[MENBAFNNBFB].item, null))
		{
			return new ItemAmount(JDNIAEJMELH.itemsReward[MENBAFNNBFB].item, JDNIAEJMELH.itemsReward[MENBAFNNBFB].amount);
		}
		return new ItemAmount(null, 0);
	}

	public void FPFDMJBKEJG(bool FFJBIGFADBJ)
	{
		if (quest.linkedQuests == null)
		{
			return;
		}
		for (int i = 0; i < quest.linkedQuests.Length; i++)
		{
			if ((Object)(object)quest.linkedQuests[i] != (Object)null)
			{
				QuestManager.GGFJGHHHEJC.AddQuest(quest.linkedQuests[i], 0, FFJBIGFADBJ);
			}
		}
	}
}
