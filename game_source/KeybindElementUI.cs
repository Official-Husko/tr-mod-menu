using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class KeybindElementUI : MonoBehaviour
{
	public int playerNum = 1;

	public TextMeshProUGUI keyBindText;

	[HideInInspector]
	public bool infoUpdated;

	public Image darkness;

	public Button button;

	[HideInInspector]
	public ActionElementMap actionElementMap;

	[HideInInspector]
	public int actionNum;

	[SerializeField]
	private Animator animator;

	private bool MAPFDGCKBLD = true;

	private bool DHABBNGPLOF;

	public bool ADOMEKMBGAO
	{
		get
		{
			return DHABBNGPLOF;
		}
		set
		{
			MAPFDGCKBLD = true;
			DHABBNGPLOF = value;
			animator.SetBool("Polling", DHABBNGPLOF);
			if (!DHABBNGPLOF)
			{
				animator.SetTrigger("Normal");
			}
		}
	}

	protected void IFELHIDGLIA(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			UISelectionManager.GetPlayer(playerNum).Select(HHFPKDCPPBD);
		}
	}

	public void RemoveKeyAssigned()
	{
		if (KeybindUI.GGFJGHHHEJC.keybindsSave.keybindSave.ContainsKey(KeybindUI.GGFJGHHHEJC.GetKeybindSaveName(playerNum, ((Object)((Component)this).transform.parent).name, actionElementMap.actionDescriptiveName)))
		{
			KeybindUI.GGFJGHHHEJC.keybindsSave.keybindSave.Remove(KeybindUI.GGFJGHHHEJC.GetKeybindSaveName(playerNum, ((Object)((Component)this).transform.parent).name, actionElementMap.actionDescriptiveName));
		}
		actionElementMap.elementIdentifierId = 0;
	}

	public virtual void PollKey()
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			UISelectionManager.GetPlayer(playerNum).Deselect();
		}
	}

	private void Update()
	{
		if (MAPFDGCKBLD)
		{
			MAPFDGCKBLD = false;
		}
		else if (DHABBNGPLOF)
		{
			PollKey();
		}
	}

	private void Start()
	{
		ADOMEKMBGAO = false;
	}

	public virtual void UpdateInfo(ActionElementMap KBMOOCGHDKH, int BKFCHPEAJEI)
	{
		infoUpdated = true;
		ADOMEKMBGAO = false;
		actionElementMap = KBMOOCGHDKH;
		actionNum = BKFCHPEAJEI;
		if (BKFCHPEAJEI % 2 == 0)
		{
			((Behaviour)darkness).enabled = true;
		}
		else
		{
			((Behaviour)darkness).enabled = false;
		}
	}

	protected void MMOHOJGCKEE(ControllerPollingInfo OOAILMIOFBA)
	{
		if (!((ControllerPollingInfo)(ref OOAILMIOFBA)).success)
		{
			return;
		}
		int elementIdentifierId = actionElementMap.elementIdentifierId;
		actionElementMap.elementIdentifierId = ((ControllerPollingInfo)(ref OOAILMIOFBA)).elementIdentifierId;
		UpdateInfo(actionElementMap, actionNum);
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			int mapCategoryId = ReInput.mapping.GetMapCategoryId("Default");
			if (actionElementMap.controllerMap.categoryId == mapCategoryId && elementIdentifierId != ((ControllerPollingInfo)(ref OOAILMIOFBA)).elementIdentifierId)
			{
				HEFKJAPFOCG(actionElementMap.actionId, elementIdentifierId, ((ControllerPollingInfo)(ref OOAILMIOFBA)).elementIdentifierId);
			}
		}
		KNKIKOCCOBH();
		KeybindUI.GGFJGHHHEJC.IIGILKKIPAM = null;
		KeybindUI.GGFJGHHHEJC.updateNextFrame = true;
		IFELHIDGLIA((Selectable)(object)button);
	}

	private void KNKIKOCCOBH()
	{
		string keybindSaveName = KeybindUI.GGFJGHHHEJC.GetKeybindSaveName(playerNum, ((Object)((Component)this).transform.parent).name, actionElementMap.actionDescriptiveName);
		if (KeybindUI.GGFJGHHHEJC.keybindsSave.keybindSave.ContainsKey(keybindSaveName))
		{
			KeybindUI.GGFJGHHHEJC.keybindsSave.keybindSave[keybindSaveName] = actionElementMap.elementIdentifierId;
		}
		else
		{
			KeybindUI.GGFJGHHHEJC.keybindsSave.keybindSave.Add(keybindSaveName, actionElementMap.elementIdentifierId);
		}
		Save.instance.SaveKeybinds();
	}

	private void HEFKJAPFOCG(int AKNHBKJKDKN, int MMONLPIKIHM, int CAEPFDIGDLB)
	{
		ActionElementMap elementIdentifierIdInMapCategory = KeybindUI.GetElementIdentifierIdInMapCategory(playerNum, "Key2", AKNHBKJKDKN);
		if (elementIdentifierIdInMapCategory.elementIdentifierId == MMONLPIKIHM)
		{
			elementIdentifierIdInMapCategory.elementIdentifierId = CAEPFDIGDLB;
			KeybindUI.GGFJGHHHEJC.key2.list[actionNum].UpdateInfo(elementIdentifierIdInMapCategory, actionNum);
		}
	}
}
