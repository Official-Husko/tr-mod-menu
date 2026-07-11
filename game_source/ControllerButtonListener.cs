using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ControllerButtonListener : MonoBehaviour
{
	[SerializeField]
	private ActionType controllerActionType;

	[SerializeField]
	private ActionType keyboardActionType;

	[SerializeField]
	private Button button;

	[SerializeField]
	private UIWindow uiWindowPlayerNum;

	private int JIIGOACEIKL;

	private void CMDHELEDLBP()
	{
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.IAMBJKBABAP()) && PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void PGEGODAEBLC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("itemBarley")) ? 5 : 0);
		}
	}

	private void ICMNODPLPBK()
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.OBLNDHGPAJB) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void FGGPGOEAEKK()
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.JMMDGEDMMCH()) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("  currentState:       {0}\n")) ? 6 : 0);
		}
	}

	private void KJHKBGDJNDC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI")) ? 1 : 6);
		}
	}

	private void ALEAOANPHIO()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("LE_10")) ? 1 : 1);
		}
	}

	private void BHAFCBHENPL()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Friend ")) ? 4 : 0);
		}
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("OnUserStatsAndAchievementsStoreFailure: ")) ? 1 : 0);
		}
	}

	private void JDMMNLKLMAA()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("add item ")) ? 3 : 0);
		}
	}

	private void EMCCGDFOPEH()
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.JMMDGEDMMCH()) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void KDHLJKMKFMG()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Tutorial/BarnExitBarks_Holly")) ? 2 : 0);
		}
	}

	private void AKLEFPLEGKK()
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.IAMBJKBABAP()) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void MMNBJPDJHGK()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("EditorConfiguration not assigned in CommonReferences")) ? 1 : 8);
		}
	}

	private void NIHJCJJKDBA()
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.JJFBJKCGOCE()) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void FHOCCEBKHJI()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("]")) ? 4 : 0);
		}
	}

	private void Awake()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
		}
	}

	private void ELHCBGCEJDH()
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.KAJJIAHDONK()) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void MGMLDHPOLGK()
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.LGKCJHAKFHG()) && PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void PJLKGOACDEN()
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.GGAKEEMCHOE()) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void GOJHCINMAJD()
	{
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.EMKLCIIEBAM()) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void EJEEIIGEGOC()
	{
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.AIEEBMKCLPN()) && PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void MFGANCCJFJK()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Items/item_name_1068")) ? 0 : 0);
		}
	}

	private void IAICCKPOBMJ()
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.AIEEBMKCLPN()) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void KLMNLEDKEOE()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Bomb")) ? 1 : 4);
		}
	}

	private void PKEPBKHEDOD()
	{
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.MBKGNECJJOF()) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void DKNMGFDFLKL()
	{
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.LPCONIAFHEG()) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void JIAJFDKNJME()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("No settings configured for puzzle type {0}")) ? 8 : 0);
		}
	}

	private void JDAMCMODANB()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" blocking at ")) ? 1 : 1);
		}
	}

	private void BHKNJOEBCKA()
	{
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.LLPHHDGALAL()) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void OMBHDODDHNO()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/Gass_Introduce/Entry/20/Dialogue Text")) ? 1 : 1);
		}
	}

	private void Update()
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.OBLNDHGPAJB) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void MCLAJGDIIBK()
	{
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.JJFBJKCGOCE()) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void LMFICKFGEFI()
	{
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.MBKGNECJJOF()) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void EMJKKALMGLK()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" name")) ? 0 : 0);
		}
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/Gass_Introduce/Entry/4/Dialogue Text")) ? 6 : 0);
		}
	}

	private void AAOMCHHNKKM()
	{
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.EMKLCIIEBAM()) && PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void AGLMGDNBHBF()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UIInteract")) ? 1 : 5);
		}
	}

	private void JBGFGOCPEFD()
	{
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.LGKCJHAKFHG()) && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).LNEHPCEHFHL(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void DOKHLDBIDJB()
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if ((!Utils.NKAMHHCOEFO() || !InputFieldConsoleUtils.KAJJIAHDONK()) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(controllerActionType))
			{
				((UnityEvent)button.onClick).Invoke();
			}
		}
		else if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(keyboardActionType))
		{
			((UnityEvent)button.onClick).Invoke();
		}
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
		}
		else
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Use")) ? 1 : 4);
		}
	}
}
