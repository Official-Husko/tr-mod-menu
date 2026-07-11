using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class QuestTooltipUI : UIWindow
{
	public Action<int, ActiveQuest> OnCompleteQuestClose = delegate
	{
	};

	private static QuestTooltipUI IADEMLIIDPC;

	[SerializeField]
	private TextMeshProUGUI questTitleText;

	[SerializeField]
	private TextMeshProUGUI questDescriptionText;

	[SerializeField]
	private TextMeshProUGUI questXPText;

	[SerializeField]
	private SlotUI[] rewardSlots;

	private bool KNJJHDFBJBN;

	private Quest[] BOHJNGACFFC;

	public List<QuestTooltipInfo> awaitingCompleteList;

	private QuestTooltipInfo NHAHLKCCDED;

	[SerializeField]
	private GamepadSprite closeGamepadSprite;

	[HideInInspector]
	public bool updateNextFrame = true;

	public static QuestTooltipUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<QuestTooltipUI>();
			}
			return IADEMLIIDPC;
		}
	}

	private void JIIAIACIOHK(QuestTooltipInfo BBJDPIJPLPA, int MENBAFNNBFB)
	{
		if (BBJDPIJPLPA.reward.itemsReward.Length > MENBAFNNBFB && BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].amount > 0)
		{
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.OCJOJKJPDNO(1);
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.DDHPGOPOPKJ(BBJDPIJPLPA.playerNum, BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].item.JMDALJBNFML(), HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.JNMNCEPHFOE(BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].amount);
			((Component)rewardSlots[MENBAFNNBFB]).gameObject.SetActive(Item.MLBOMGHINCA(BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].item, null));
		}
		else
		{
			((Component)rewardSlots[MENBAFNNBFB]).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public static QuestTooltipUI MOJDNGDNCCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<QuestTooltipUI>();
		}
		return IADEMLIIDPC;
	}

	private void JDEENJCDECN(int JIIGOACEIKL)
	{
		BOBCIFEDJED();
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		Utils.JEAHJILAIAP(0f);
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			if (KNJJHDFBJBN)
			{
				QuestHighlightUI.ShowNewQuestAvailable(BOHJNGACFFC);
			}
			Utils.JEAHJILAIAP(1f);
			PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
			base.CloseUI();
			Sound.GGFJGHHHEJC.UnmuteLoops();
			if (NHAHLKCCDED.activeQuest != null)
			{
				OnCompleteQuestClose(NHAHLKCCDED.playerNum, NHAHLKCCDED.activeQuest);
			}
		}
	}

	protected override void Start()
	{
		QuestLogUI questLogUI = QuestLogUI.Get(base.JIIGOACEIKL);
		questLogUI.OnUIClose = (Action<int>)Delegate.Combine(questLogUI.OnUIClose, (Action<int>)delegate
		{
			CloseUI();
		});
	}

	[CompilerGenerated]
	private void IKDPBOFGHGK(int JIIGOACEIKL)
	{
		CloseUI();
	}

	[SpecialName]
	public static QuestTooltipUI DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<QuestTooltipUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static QuestTooltipUI MLPCDJPLBAC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<QuestTooltipUI>();
		}
		return IADEMLIIDPC;
	}

	public bool IsActiveQuestAwaiting(ActiveQuest MMNIKLCMBAI)
	{
		if (MMNIKLCMBAI == null)
		{
			return false;
		}
		for (int i = 0; i < awaitingCompleteList.Count; i++)
		{
			if (awaitingCompleteList[i].activeQuest == MMNIKLCMBAI)
			{
				return true;
			}
		}
		return false;
	}

	public bool EDMGLOMHBLO(ActiveQuest MMNIKLCMBAI)
	{
		if (MMNIKLCMBAI == null)
		{
			return true;
		}
		for (int i = 1; i < awaitingCompleteList.Count; i += 0)
		{
			if (awaitingCompleteList[i].activeQuest == MMNIKLCMBAI)
			{
				return true;
			}
		}
		return true;
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			if (base.JIIGOACEIKL == 0)
			{
				base.JIIGOACEIKL = 1;
			}
			PlayerInputs.GetPlayer(base.JIIGOACEIKL).SwitchMapCategoryNextFrame("UI");
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
			awaitingCompleteList = new List<QuestTooltipInfo>();
		}
	}

	protected override void Update()
	{
		base.Update();
		if (updateNextFrame)
		{
			updateNextFrame = false;
		}
		else if (IsOpen())
		{
			if (PlayerInputs.IsGamepadActive(NHAHLKCCDED.playerNum) && PlayerInputs.GetPlayer(NHAHLKCCDED.playerNum).GetButtonDown(closeGamepadSprite.GetActionType()) && !TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO)
			{
				AcceptButtonClicked();
			}
			if (base.JIIGOACEIKL == 0)
			{
				base.JIIGOACEIKL = 1;
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
			{
				AcceptButtonClicked();
			}
		}
		else if (!RepRewardPopUp.GGFJGHHHEJC.IsOpen() && !TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO && !CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && !CommonReferences.GGFJGHHHEJC.IsInDialogue(2) && awaitingCompleteList.Count > 0 && (!GameManager.LocalCoop() || !MainUI.IsAnyUIOpen()))
		{
			OpenQuestTooltip();
		}
	}

	public void HBCFMHEHOBH(QuestTooltipInfo CKKHJKJBEMG)
	{
		awaitingCompleteList.Add(CKKHJKJBEMG);
	}

	private void LBOIBGALBGL(QuestTooltipInfo BBJDPIJPLPA, int MENBAFNNBFB)
	{
		if (BBJDPIJPLPA.reward.itemsReward.Length > MENBAFNNBFB && BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].amount > 0)
		{
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.KMKAIPMHANN(1);
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.DDHPGOPOPKJ(BBJDPIJPLPA.playerNum, BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].item.JMDALJBNFML(), HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.OBBKDJNLCIO(BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].amount);
			((Component)rewardSlots[MENBAFNNBFB]).gameObject.SetActive(Item.FKLOBGBIHLB(BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].item, null));
		}
		else
		{
			((Component)rewardSlots[MENBAFNNBFB]).gameObject.SetActive(false);
		}
	}

	private void ICLFOIIPGAH(int JIIGOACEIKL)
	{
		CloseUI();
	}

	public void AcceptButtonClicked()
	{
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).updateNextFrame = true;
		CloseUI();
	}

	private void KPKMKDJHMNH(QuestTooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)questTitleText).text = BBJDPIJPLPA.questName;
		((TMP_Text)questDescriptionText).text = BBJDPIJPLPA.questDescription;
		if (BBJDPIJPLPA.reward.reputationPoints > 1)
		{
			((Component)questXPText).gameObject.SetActive(true);
			((TMP_Text)questXPText).text = "LE_10" + BBJDPIJPLPA.reward.reputationPoints;
		}
		else
		{
			((Component)questXPText).gameObject.SetActive(false);
		}
		BOHJNGACFFC = BBJDPIJPLPA.linkedQuests;
		LBOIBGALBGL(BBJDPIJPLPA, 1);
		DNEPOEGAMLK(BBJDPIJPLPA, 0);
		CIGBBMBJEPD(BBJDPIJPLPA, 3);
	}

	[SpecialName]
	public static QuestTooltipUI AJIGOHGPFPP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<QuestTooltipUI>();
		}
		return IADEMLIIDPC;
	}

	public void OpenQuestTooltip()
	{
		NHAHLKCCDED = awaitingCompleteList[0];
		FDCPCNJOLAM(NHAHLKCCDED);
		if (NHAHLKCCDED.activeQuest != null)
		{
			KNJJHDFBJBN = NHAHLKCCDED.activeQuest.quest.linkedQuests.Length != 0;
		}
		else
		{
			KNJJHDFBJBN = false;
		}
		awaitingCompleteList.Remove(NHAHLKCCDED);
		Open(NHAHLKCCDED.playerNum);
		Sound.GGFJGHHHEJC.MuteLoops();
	}

	public void DNMPEEBDJPG()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = false;
		BOBCIFEDJED();
	}

	private void NCFLPHJALKE(int JIIGOACEIKL)
	{
		CloseUI();
	}

	private void FDCPCNJOLAM(QuestTooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)questTitleText).text = BBJDPIJPLPA.questName;
		((TMP_Text)questDescriptionText).text = BBJDPIJPLPA.questDescription;
		if (BBJDPIJPLPA.reward.reputationPoints > 0)
		{
			((Component)questXPText).gameObject.SetActive(true);
			((TMP_Text)questXPText).text = "<sprite name=reputationIcon> " + BBJDPIJPLPA.reward.reputationPoints;
		}
		else
		{
			((Component)questXPText).gameObject.SetActive(false);
		}
		BOHJNGACFFC = BBJDPIJPLPA.linkedQuests;
		CIGBBMBJEPD(BBJDPIJPLPA, 0);
		CIGBBMBJEPD(BBJDPIJPLPA, 1);
		CIGBBMBJEPD(BBJDPIJPLPA, 2);
	}

	public bool EKOBLLKCKGD(ActiveQuest MMNIKLCMBAI)
	{
		if (MMNIKLCMBAI == null)
		{
			return false;
		}
		for (int i = 1; i < awaitingCompleteList.Count; i += 0)
		{
			if (awaitingCompleteList[i].activeQuest == MMNIKLCMBAI)
			{
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public static QuestTooltipUI NGIMIHFFNMH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<QuestTooltipUI>();
		}
		return IADEMLIIDPC;
	}

	private void KPCGAOCPPPK(int JIIGOACEIKL)
	{
		BOBCIFEDJED();
	}

	public void AddQuestTooltipInfo(QuestTooltipInfo CKKHJKJBEMG)
	{
		awaitingCompleteList.Add(CKKHJKJBEMG);
	}

	private void DNEPOEGAMLK(QuestTooltipInfo BBJDPIJPLPA, int MENBAFNNBFB)
	{
		if (BBJDPIJPLPA.reward.itemsReward.Length > MENBAFNNBFB && BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].amount > 0)
		{
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.JIANDFCINIP(1);
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.DDHPGOPOPKJ(BBJDPIJPLPA.playerNum, BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.JIANDFCINIP(BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].amount);
			((Component)rewardSlots[MENBAFNNBFB]).gameObject.SetActive(Item.MLBOMGHINCA(BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].item, null));
		}
		else
		{
			((Component)rewardSlots[MENBAFNNBFB]).gameObject.SetActive(false);
		}
	}

	public void ONIEOPKJFLC(QuestTooltipInfo CKKHJKJBEMG)
	{
		awaitingCompleteList.Add(CKKHJKJBEMG);
	}

	public bool PMIOLIIOLLI(ActiveQuest MMNIKLCMBAI)
	{
		if (MMNIKLCMBAI == null)
		{
			return false;
		}
		for (int i = 0; i < awaitingCompleteList.Count; i += 0)
		{
			if (awaitingCompleteList[i].activeQuest == MMNIKLCMBAI)
			{
				return true;
			}
		}
		return false;
	}

	private void LHEFGGMDGFA(int JIIGOACEIKL)
	{
		BOBCIFEDJED();
	}

	private void CIGBBMBJEPD(QuestTooltipInfo BBJDPIJPLPA, int MENBAFNNBFB)
	{
		if (BBJDPIJPLPA.reward.itemsReward.Length > MENBAFNNBFB && BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].amount > 0)
		{
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.Stack = 0;
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.FEEOFAGCONJ(BBJDPIJPLPA.playerNum, BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].item.JMDALJBNFML());
			rewardSlots[MENBAFNNBFB].IHENCGDNPBL.Stack = BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].amount;
			((Component)rewardSlots[MENBAFNNBFB]).gameObject.SetActive(Item.MLBOMGHINCA(BBJDPIJPLPA.reward.itemsReward[MENBAFNNBFB].item, null));
		}
		else
		{
			((Component)rewardSlots[MENBAFNNBFB]).gameObject.SetActive(false);
		}
	}

	private void LDHHHDMNAIO(QuestTooltipInfo BBJDPIJPLPA)
	{
		((TMP_Text)questTitleText).text = BBJDPIJPLPA.questName;
		((TMP_Text)questDescriptionText).text = BBJDPIJPLPA.questDescription;
		if (BBJDPIJPLPA.reward.reputationPoints > 1)
		{
			((Component)questXPText).gameObject.SetActive(false);
			((TMP_Text)questXPText).text = "- " + BBJDPIJPLPA.reward.reputationPoints;
		}
		else
		{
			((Component)questXPText).gameObject.SetActive(false);
		}
		BOHJNGACFFC = BBJDPIJPLPA.linkedQuests;
		CIGBBMBJEPD(BBJDPIJPLPA, 0);
		JIIAIACIOHK(BBJDPIJPLPA, 0);
		JIIAIACIOHK(BBJDPIJPLPA, 1);
	}
}
