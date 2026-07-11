using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class QuestSlotUI : MonoBehaviour
{
	[SerializeField]
	protected UIWindow mainUI;

	[SerializeField]
	protected ActiveQuest activeQuest;

	[SerializeField]
	protected TextMeshProUGUI nameText;

	[SerializeField]
	protected TextMeshProUGUI modifierText;

	public TextMeshProUGUI repText;

	public SlotUIOrder slotUI;

	[SerializeField]
	protected GameObject xpObj;

	[SerializeField]
	protected GameObject infoBg;

	[SerializeField]
	protected Image bg;

	public int playerNum = 1;

	protected void BNEPMDMDGAI(Quest AINAHCLIAFF, string COAPHJJHNIO = "")
	{
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)nameText).text = AINAHCLIAFF.INKJOLLEBGI()[0].IABAKHPEOAF();
		if (!string.IsNullOrEmpty(COAPHJJHNIO))
		{
			TextMeshProUGUI obj = nameText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + " " + COAPHJJHNIO;
		}
		RequiredItemQuest requiredItemQuest = AINAHCLIAFF as RequiredItemQuest;
		((TMP_Text)modifierText).text = RandomOrderQuestsManager.GenerateDescriptionWithoutItem(requiredItemQuest.ingredientType, requiredItemQuest.ingredients, requiredItemQuest.modifiers, AINAHCLIAFF.INKJOLLEBGI()[0].recipe);
		slotUI.DLOJCEAJBLF.OFJDJIBMIGE(playerNum, AINAHCLIAFF.INKJOLLEBGI()[0]);
		if (requiredItemQuest.ingredients != null && AINAHCLIAFF.INKJOLLEBGI()[0].recipe.usingNewRecipesSystem && slotUI.DLOJCEAJBLF.itemInstance is IModifiable modifiable)
		{
			modifiable.KEKBKGGFOLK = new List<Food>(requiredItemQuest.ingredients);
		}
		slotUI.DLOJCEAJBLF.Stack = AINAHCLIAFF.requiredAmount;
		slotUI.UpdateSlot();
		((TMP_Text)repText).text = AINAHCLIAFF.reward.reputationPoints.ToString();
		if ((Object)(object)xpObj != (Object)null)
		{
			xpObj.SetActive(true);
			infoBg.SetActive(true);
			((Graphic)bg).color = new Color(1f, 1f, 1f, 1f);
		}
	}

	public void OpenRecipeBookWithItem()
	{
		if (activeQuest.quest is RequiredItemQuest requiredItemQuest)
		{
			Utils.EACNFFIKABJ(playerNum, requiredItemQuest.possibleItems[0]);
		}
	}

	protected virtual void Awake()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	protected int COJHAOOLGMP(Quest AINAHCLIAFF)
	{
		int num = 0;
		List<Slot> allSlots = CraftingInventory.GetAllSlots(playerNum);
		if (allSlots != null)
		{
			CraftItemTypeQuest craftItemTypeQuest = AINAHCLIAFF as CraftItemTypeQuest;
			for (int i = 0; i < allSlots.Count; i++)
			{
				if (craftItemTypeQuest.DGALJHKINMH(allSlots[i].itemInstance))
				{
					num += allSlots[i].Stack;
				}
			}
		}
		return num;
	}

	public void DisableQuest()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)xpObj != (Object)null)
		{
			xpObj.SetActive(false);
			infoBg.SetActive(false);
			((Graphic)bg).color = new Color(1f, 1f, 1f, 0.8f);
		}
	}
}
