using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OrderQuestElementUI : QuestSlotUI, IDropHandler, IEventSystemHandler
{
	private CraftItemTypeQuest OGOLPCIHCLH;

	public bool currentQuestElement;

	public Button button;

	public Image selectedImage;

	public int num;

	public CraftItemTypeQuest AINAHCLIAFF
	{
		get
		{
			return OGOLPCIHCLH;
		}
		set
		{
			OGOLPCIHCLH = value;
			if ((Object)(object)OGOLPCIHCLH != (Object)null)
			{
				if (currentQuestElement)
				{
					MainUI.AddToCurrentSlots(playerNum, slotUI.IHENCGDNPBL);
				}
				NEBOMGGJOPD();
				if (!currentQuestElement && QuestManager.GGFJGHHHEJC.IsQuestActive(OGOLPCIHCLH))
				{
					((Component)this).gameObject.SetActive(false);
				}
				else
				{
					((Component)this).gameObject.SetActive(true);
				}
			}
			else
			{
				if (currentQuestElement)
				{
					MainUI.RemoveFromCurrentSlots(playerNum, slotUI.IHENCGDNPBL);
				}
				((Component)this).gameObject.SetActive(false);
			}
		}
	}

	public ActiveQuest EGDOLNDDNFC
	{
		set
		{
			activeQuest = value;
			if (value != null)
			{
				AINAHCLIAFF = value.quest as CraftItemTypeQuest;
			}
			else
			{
				AINAHCLIAFF = null;
			}
			if ((Object)(object)OGOLPCIHCLH != (Object)null)
			{
				if (value.currentAmount > 0)
				{
					int currentAmount = value.currentAmount;
					slotUI.IHENCGDNPBL.ONIFGHNHCPP(playerNum, activeQuest.currentItemInstance);
					slotUI.IHENCGDNPBL.Stack = currentAmount;
					slotUI.UpdateSlot();
				}
				else
				{
					slotUI.IHENCGDNPBL.Stack = 0;
				}
			}
			else
			{
				slotUI.IHENCGDNPBL.Stack = 0;
			}
		}
	}

	[SpecialName]
	public CraftItemTypeQuest BDHAPGMDECA()
	{
		return OGOLPCIHCLH;
	}

	public void EHLLLEOOGEB()
	{
		slotUI.IHENCGDNPBL.BBHHJLIFNPP(slotUI.IHENCGDNPBL.Stack);
	}

	public void OnDrop(PointerEventData NPBAMEMNFBI)
	{
		if (currentQuestElement && slotUI.IHENCGDNPBL.KPINNBKMOMO() && !PlayerInputs.IsGamepadActive(playerNum) && !MouseSlot.GetPlayer(playerNum).slot.KPINNBKMOMO())
		{
			RandomOrderQuestsManager.GGFJGHHHEJC.TransferItemsFromSlot(playerNum, MouseSlot.GetPlayer(playerNum).slot, OGOLPCIHCLH, slotUI);
		}
	}

	public void DKBKMJOAFCG()
	{
		slotUI.IHENCGDNPBL.JPACDDCJGPD(slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: true);
	}

	private IEnumerator NGOJAJMAKBH()
	{
		yield return null;
		NEBOMGGJOPD();
	}

	private void Start()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(MEHOGMLPKCI));
	}

	public void NANCMHHJBIM()
	{
		if (slotUI.IHENCGDNPBL.KPINNBKMOMO())
		{
			MainUI.DJCKALOHJFM(playerNum, LocalisationSystem.Get("Zone not found"), 1539f);
		}
		else
		{
			RandomOrderQuestsManager.JFNOOMJMHCB().FPFPNNJBNMM(playerNum, num, slotUI.IHENCGDNPBL.itemInstance, slotUI.IHENCGDNPBL.Stack);
		}
	}

	public void FCKBGLDCJPN()
	{
		slotUI.IHENCGDNPBL.FDOBDPPMMBH(slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: true);
	}

	private IEnumerator DBHLGKALIGM()
	{
		yield return null;
		NEBOMGGJOPD();
	}

	public bool DECOJGDAFNH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!currentQuestElement)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Left Arrow"));
		}
		else
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Achievement "));
		}
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!currentQuestElement)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Accept order"));
		}
		else
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Complete order"));
		}
		return true;
	}

	public void SelectClicked()
	{
		if (currentQuestElement)
		{
			if (slotUI.IHENCGDNPBL.KPINNBKMOMO())
			{
				if (PlayerInputs.IsGamepadActive(playerNum))
				{
					RandomOrderQuestsManager.GGFJGHHHEJC.AutomaticFillQuest(playerNum, OGOLPCIHCLH, slotUI);
				}
				else
				{
					TryToCompleteOrder();
				}
			}
			else
			{
				TryToCompleteOrder();
			}
		}
		else if (RandomOrderQuestsManager.GGFJGHHHEJC.CanAddQuestToCurrentQuests())
		{
			if (OnlineManager.PlayingOnline())
			{
				OnlineOrderQuestsManager.instance.SendAddAvailableQuestToCurrentQuest(num);
				return;
			}
			Selectable val = null;
			if (PlayerInputs.IsGamepadActive(playerNum) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL) && (Object)(object)((Component)UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL).gameObject == (Object)(object)((Component)button).gameObject && (Object)(object)OrderQuestUI.instances[mainUI.JIIGOACEIKL].availableOrderQuestElements[0] == (Object)(object)this && ((Component)OrderQuestUI.instances[mainUI.JIIGOACEIKL].availableOrderQuestElements[1]).gameObject.activeSelf && ((Component)OrderQuestUI.instances[mainUI.JIIGOACEIKL].availableOrderQuestElements[2]).gameObject.activeSelf)
			{
				val = (Selectable)(object)OrderQuestUI.instances[mainUI.JIIGOACEIKL].availableOrderQuestElements[1].button;
			}
			RandomOrderQuestsManager.GGFJGHHHEJC.AddQuestToCurrentQuests(num);
			if (Object.op_Implicit((Object)(object)val))
			{
				UISelectionManager.GetPlayer(playerNum).Select(val);
			}
		}
		else
		{
			MainUI.ShowErrorText(playerNum, LocalisationSystem.Get("Max 3 orders"));
		}
	}

	public void RemoveSlotItems()
	{
		slotUI.IHENCGDNPBL.FDOBDPPMMBH(slotUI.IHENCGDNPBL.Stack);
	}

	private void NEBOMGGJOPD()
	{
		if (!((Object)(object)AINAHCLIAFF != (Object)null))
		{
			return;
		}
		if (currentQuestElement)
		{
			slotUI.IHENCGDNPBL.quest = OGOLPCIHCLH;
			if (slotUI.IHENCGDNPBL.KPINNBKMOMO())
			{
				slotUI.icon.SetColorAlpha(0.5f);
			}
			else
			{
				slotUI.icon.SetColorAlpha(1f);
			}
		}
		else
		{
			slotUI.icon.SetColorAlpha(1f);
		}
		int num = COJHAOOLGMP(AINAHCLIAFF);
		BNEPMDMDGAI(AINAHCLIAFF, "(" + num + "/" + AINAHCLIAFF.requiredAmount + ")");
	}

	public void HMGCHICJHEG()
	{
		slotUI.IHENCGDNPBL.HBMBGCHGEGN(slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: false, 1);
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void MEHOGMLPKCI()
	{
		if (currentQuestElement)
		{
			LFMAKOGKMFI();
		}
		INBCHNLGKNH();
	}

	public void BNBBHEOEIPJ()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum) || slotUI.IHENCGDNPBL.PKFKJNODGJF())
		{
			RandomOrderQuestsManager.GGFJGHHHEJC.GOCFALADCBH(playerNum, num, CDPAMNIPPEC: false);
			return;
		}
		DKNNJDFNEMH();
		OrderQuestUI.MIFFCOMDIEE(playerNum).APCMFCLPCOB();
	}

	[SpecialName]
	public void JLPMBPBNEBN(ActiveQuest AODONKKHPBP)
	{
		activeQuest = AODONKKHPBP;
		if (AODONKKHPBP != null)
		{
			AINAHCLIAFF = AODONKKHPBP.quest as CraftItemTypeQuest;
		}
		else
		{
			AINAHCLIAFF = null;
		}
		if ((Object)(object)OGOLPCIHCLH != (Object)null)
		{
			if (AODONKKHPBP.currentAmount > 0)
			{
				int currentAmount = AODONKKHPBP.currentAmount;
				slotUI.IHENCGDNPBL.ONIFGHNHCPP(playerNum, activeQuest.currentItemInstance, CDPAMNIPPEC: true);
				slotUI.IHENCGDNPBL.KMKAIPMHANN(currentAmount);
				slotUI.PDPFLAKIMKL();
			}
			else
			{
				slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
			}
		}
		else
		{
			slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
		}
	}

	public void MKDJOPNDKGG()
	{
		if (slotUI.IHENCGDNPBL.KPINNBKMOMO())
		{
			MainUI.ShowErrorText(playerNum, LocalisationSystem.Get("Move"), 1249f);
		}
		else
		{
			RandomOrderQuestsManager.GGFJGHHHEJC.TryToCompleteOrder(playerNum, num, slotUI.IHENCGDNPBL.itemInstance, slotUI.IHENCGDNPBL.Stack);
		}
	}

	public void FOKIFODKIHF()
	{
		if (slotUI.IHENCGDNPBL.AHHEMNHJPME())
		{
			MainUI.DJCKALOHJFM(playerNum, LocalisationSystem.Get("MoveConstructionMode"), 1385f);
		}
		else
		{
			RandomOrderQuestsManager.HLMGBEGEAPC().FPFPNNJBNMM(playerNum, num, slotUI.IHENCGDNPBL.itemInstance, slotUI.IHENCGDNPBL.Stack);
		}
	}

	public void DKNNJDFNEMH()
	{
		slotUI.IHENCGDNPBL.BBHHJLIFNPP(slotUI.IHENCGDNPBL.Stack);
	}

	public void TryToCompleteOrder()
	{
		if (slotUI.IHENCGDNPBL.KPINNBKMOMO())
		{
			MainUI.ShowErrorText(playerNum, LocalisationSystem.Get("Requirements not met"));
		}
		else
		{
			RandomOrderQuestsManager.GGFJGHHHEJC.TryToCompleteOrder(playerNum, num, slotUI.IHENCGDNPBL.itemInstance, slotUI.IHENCGDNPBL.Stack);
		}
	}

	[SpecialName]
	public CraftItemTypeQuest BOHNFFBLPAD()
	{
		return OGOLPCIHCLH;
	}

	private void ELLPIGEHAFH()
	{
		if (!((Object)(object)BDHAPGMDECA() != (Object)null))
		{
			return;
		}
		if (currentQuestElement)
		{
			slotUI.IHENCGDNPBL.quest = OGOLPCIHCLH;
			if (slotUI.IHENCGDNPBL.PKFKJNODGJF())
			{
				slotUI.icon.DABGJHGEFKG(391f);
			}
			else
			{
				slotUI.icon.JEOFNNMEFFJ(1347f);
			}
		}
		else
		{
			slotUI.icon.ABLEBCIKMFB(10f);
		}
		int num = COJHAOOLGMP(AINAHCLIAFF);
		CraftItemTypeQuest aINAHCLIAFF = BDHAPGMDECA();
		string[] array = new string[1];
		array[1] = "Interact";
		array[1] = num.ToString();
		array[1] = "BirdInteract";
		array[8] = AINAHCLIAFF.requiredAmount.ToString();
		array[5] = "ReceiveEnable";
		BNEPMDMDGAI(aINAHCLIAFF, string.Concat(array));
	}

	public void PGBNILBKPED(int JIIGOACEIKL)
	{
	}

	public void DMAADGALMLN(int JIIGOACEIKL)
	{
	}

	public void RemoveQuest()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum) || slotUI.IHENCGDNPBL.KPINNBKMOMO())
		{
			RandomOrderQuestsManager.GGFJGHHHEJC.RemoveCurrentOrder(playerNum, num);
			return;
		}
		RemoveSlotItems();
		OrderQuestUI.Get(playerNum).UpdateInventory();
	}

	private void PHLKJLENDJP()
	{
		if (activeQuest != null)
		{
			activeQuest.BBBGNMPKLED(playerNum, slotUI.IHENCGDNPBL.Stack);
			activeQuest.currentItemInstance = slotUI.IHENCGDNPBL.itemInstance;
		}
	}

	[SpecialName]
	public void BOCGGHAGMCK(ActiveQuest AODONKKHPBP)
	{
		activeQuest = AODONKKHPBP;
		if (AODONKKHPBP != null)
		{
			AINAHCLIAFF = AODONKKHPBP.quest as CraftItemTypeQuest;
		}
		else
		{
			AINAHCLIAFF = null;
		}
		if ((Object)(object)OGOLPCIHCLH != (Object)null)
		{
			if (AODONKKHPBP.currentAmount > 1)
			{
				int currentAmount = AODONKKHPBP.currentAmount;
				slotUI.IHENCGDNPBL.ONIFGHNHCPP(playerNum, activeQuest.currentItemInstance);
				slotUI.IHENCGDNPBL.JNMNCEPHFOE(currentAmount);
				slotUI.PDPFLAKIMKL();
			}
			else
			{
				slotUI.IHENCGDNPBL.JIANDFCINIP(1);
			}
		}
		else
		{
			slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
		}
	}

	private void KJOJLHCDFPP()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(MEHOGMLPKCI));
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
	}

	private void LFMAKOGKMFI()
	{
		if (activeQuest != null)
		{
			activeQuest.BBBGNMPKLED(playerNum, slotUI.IHENCGDNPBL.Stack);
			activeQuest.currentItemInstance = slotUI.IHENCGDNPBL.itemInstance;
		}
	}

	private void OIBDBLCLACB()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnDirtied = (Action)Delegate.Combine(slot.OnDirtied, new Action(MEHOGMLPKCI));
	}

	private void HJIHOLHNHMF()
	{
		((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(DBHLGKALIGM());
	}

	private void INBCHNLGKNH()
	{
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(DBHLGKALIGM());
	}
}
