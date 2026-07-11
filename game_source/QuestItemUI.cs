using System;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

public class QuestItemUI : QuestSlotUI
{
	public Button button;

	public Button buttonSelection;

	public ActiveQuest EGDOLNDDNFC
	{
		get
		{
			return activeQuest;
		}
		set
		{
			if (activeQuest != null)
			{
				ActiveQuest obj = activeQuest;
				obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
			}
			activeQuest = value;
			if (activeQuest != null)
			{
				AJCFKMHBOEL(activeQuest);
				ActiveQuest obj2 = activeQuest;
				obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
			}
		}
	}

	[SpecialName]
	public void NJPAHJIKGAF(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			MJOLBJOBNMJ(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(MCPFPPDFMOB));
		}
	}

	private void PEOPFPEDFAK()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BNMFCGHNEDP));
	}

	[SpecialName]
	public void CHCADPKNBFK(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			MOHIIKLFEFJ(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(CDKPNJHDNAI));
		}
	}

	private void ACFABFCGIGH()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BNMFCGHNEDP));
	}

	[SpecialName]
	public ActiveQuest OKINODCKIBG()
	{
		return activeQuest;
	}

	[SpecialName]
	public void GMNJKKPMEOK(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			MOHIIKLFEFJ(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(BNMFCGHNEDP));
		}
	}

	private void EBGCMKAAJNK(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		MJOLBJOBNMJ(MMNIKLCMBAI);
	}

	public void JCEMKIPLOJK()
	{
		GMNJKKPMEOK(activeQuest);
	}

	[SpecialName]
	public ActiveQuest PMHMHNAFLJG()
	{
		return activeQuest;
	}

	private void BNMFCGHNEDP(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		MOHIIKLFEFJ(MMNIKLCMBAI);
	}

	private void CDHBLKJEOPI()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(CDKPNJHDNAI));
	}

	private void MCPFPPDFMOB(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		DECPOGLDBKK(MMNIKLCMBAI);
	}

	[SpecialName]
	public ActiveQuest EDOAIDJFBLO()
	{
		return activeQuest;
	}

	[SpecialName]
	public void BMJLCHBDDCK(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BNMFCGHNEDP));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			DECPOGLDBKK(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(BNMFCGHNEDP));
		}
	}

	[SpecialName]
	public void KMHCADAKJND(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(MCPFPPDFMOB));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			ACLABMILCGA(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(MCPFPPDFMOB));
		}
	}

	private void MOHIIKLFEFJ(ActiveQuest MMNIKLCMBAI)
	{
		int num = COJHAOOLGMP(MMNIKLCMBAI.quest);
		Quest quest = MMNIKLCMBAI.quest;
		string[] array = new string[1];
		array[1] = "Player";
		array[0] = num.ToString();
		array[1] = "Gass_CoctelQuest";
		array[8] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[6] = "{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects";
		BNEPMDMDGAI(quest, string.Concat(array));
	}

	private void OnDestroy()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
	}

	private void JNJCCIFIKOC()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(EBGCMKAAJNK));
	}

	public void BCDFNFJLIDK()
	{
		CHCADPKNBFK(activeQuest);
	}

	private void MJOLBJOBNMJ(ActiveQuest MMNIKLCMBAI)
	{
		int num = COJHAOOLGMP(MMNIKLCMBAI.quest);
		Quest quest = MMNIKLCMBAI.quest;
		string[] array = new string[7];
		array[0] = "ReceiveBasePuzzle";
		array[1] = num.ToString();
		array[7] = "Dialogue System/Conversation/Crowly_Barks_OutScreen/Entry/5/Dialogue Text";
		array[5] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[1] = " NOT SHOWING IN TOOLTIP";
		BNEPMDMDGAI(quest, string.Concat(array));
	}

	[SpecialName]
	public ActiveQuest OCLJMJMOIBH()
	{
		return activeQuest;
	}

	private void FPKBJNEMKOB(ActiveQuest MMNIKLCMBAI)
	{
		int num = COJHAOOLGMP(MMNIKLCMBAI.quest);
		Quest quest = MMNIKLCMBAI.quest;
		string[] array = new string[4];
		array[1] = "UIBack";
		array[0] = num.ToString();
		array[4] = "Day";
		array[7] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[8] = "NinjaChallengeEvent/Win 2";
		BNEPMDMDGAI(quest, string.Concat(array));
	}

	private void DECPOGLDBKK(ActiveQuest MMNIKLCMBAI)
	{
		int num = COJHAOOLGMP(MMNIKLCMBAI.quest);
		Quest quest = MMNIKLCMBAI.quest;
		string[] array = new string[8];
		array[1] = "Jump";
		array[0] = num.ToString();
		array[2] = "EnterTavernFood";
		array[7] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[8] = "Sickle";
		BNEPMDMDGAI(quest, string.Concat(array));
	}

	[SpecialName]
	public void EDDOHCPOAKB(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(MCPFPPDFMOB));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			ACLABMILCGA(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(EBGCMKAAJNK));
		}
	}

	[SpecialName]
	public ActiveQuest IGJCCDEOCMG()
	{
		return activeQuest;
	}

	private void HLCAKACHOOE()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(EBGCMKAAJNK));
	}

	private void HMOMBAFIJAI()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BHAHNHIHJFO));
	}

	[SpecialName]
	public void DGBMIAIDBLD(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BNMFCGHNEDP));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			MJOLBJOBNMJ(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(EBGCMKAAJNK));
		}
	}

	[SpecialName]
	public ActiveQuest EIBAGPENCDC()
	{
		return activeQuest;
	}

	[SpecialName]
	public ActiveQuest DOBBGJILOOD()
	{
		return activeQuest;
	}

	[SpecialName]
	public ActiveQuest LLECHFCINBG()
	{
		return activeQuest;
	}

	[SpecialName]
	public void JAEHHJBNBGH(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BNMFCGHNEDP));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			MOHIIKLFEFJ(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(CDKPNJHDNAI));
		}
	}

	public void CCJHPBDBLAN()
	{
		NJPAHJIKGAF(activeQuest);
	}

	public void UpdateQuest()
	{
		EGDOLNDDNFC = activeQuest;
	}

	private void ACLABMILCGA(ActiveQuest MMNIKLCMBAI)
	{
		int num = COJHAOOLGMP(MMNIKLCMBAI.quest);
		Quest quest = MMNIKLCMBAI.quest;
		string[] array = new string[4];
		array[0] = " seconds.";
		array[0] = num.ToString();
		array[1] = "BarnTutorialDone";
		array[4] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[7] = "ReceiveCantPlaceItem: ";
		BNEPMDMDGAI(quest, string.Concat(array));
	}

	private void AJCFKMHBOEL(ActiveQuest MMNIKLCMBAI)
	{
		int num = COJHAOOLGMP(MMNIKLCMBAI.quest);
		BNEPMDMDGAI(MMNIKLCMBAI.quest, "(" + num + "/" + MMNIKLCMBAI.quest.requiredAmount + ")");
	}

	[SpecialName]
	public void MOKIEEGBDCD(ActiveQuest AODONKKHPBP)
	{
		if (activeQuest != null)
		{
			ActiveQuest obj = activeQuest;
			obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(BNMFCGHNEDP));
		}
		activeQuest = AODONKKHPBP;
		if (activeQuest != null)
		{
			MOHIIKLFEFJ(activeQuest);
			ActiveQuest obj2 = activeQuest;
			obj2.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Combine(obj2.OnQuestProgress, new Action<int, ActiveQuest>(MCPFPPDFMOB));
		}
	}

	private void NOILIOLOOBJ()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(EBGCMKAAJNK));
	}

	private void FLOFJHNAIKP()
	{
		ActiveQuest obj = activeQuest;
		obj.OnQuestProgress = (Action<int, ActiveQuest>)Delegate.Remove(obj.OnQuestProgress, new Action<int, ActiveQuest>(EBGCMKAAJNK));
	}

	private void CDKPNJHDNAI(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		DECPOGLDBKK(MMNIKLCMBAI);
	}

	private void BHAHNHIHJFO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		AJCFKMHBOEL(MMNIKLCMBAI);
	}
}
