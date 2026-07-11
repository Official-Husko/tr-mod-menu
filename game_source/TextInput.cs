using System;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;

public class TextInput : MonoBehaviour
{
	public Action OnTextChanged = delegate
	{
	};

	public Action OnTextClear = delegate
	{
	};

	private Keyboard EGGMAGBALCJ;

	public TMP_InputField inputField;

	private ControllerPollingInfo MDKGPAMHNBM;

	private int JIIGOACEIKL;

	public bool clearOnDeselect = true;

	private bool HGNKFFMDOOL;

	public string currentText;

	public TextMeshProUGUI descText;

	private float BAJEAOHEOAD;

	public bool NBBBOLAGHFP
	{
		get
		{
			return HGNKFFMDOOL;
		}
		set
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			if (HGNKFFMDOOL == value)
			{
				return;
			}
			HGNKFFMDOOL = value;
			if (HGNKFFMDOOL)
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
				PlayerController.GetPlayer(JIIGOACEIKL).textInputBlockerEnabled = true;
				CommonReferences.GGFJGHHHEJC.anySelected = true;
				if (LocalisationSystem.CMIBBDJLMBM.useIMEComposition)
				{
					Input.imeCompositionMode = (IMECompositionMode)1;
					Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(1).WorldToScreenPoint(((Component)this).transform.position));
					val.y = (float)Screen.height - val.y;
					Input.compositionCursorPos = val;
				}
			}
			else
			{
				if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
				{
					PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
				}
				PlayerController.GetPlayer(JIIGOACEIKL).textInputBlockerEnabled = false;
				if (clearOnDeselect)
				{
					ClearText();
				}
				CommonReferences.GGFJGHHHEJC.anySelected = false;
				Input.imeCompositionMode = (IMECompositionMode)0;
			}
		}
	}

	public void ODLJCKGNDFN()
	{
		ENPICDEDBKI(AODONKKHPBP: false);
	}

	[SpecialName]
	public void HOIIFELLKFJ(bool AODONKKHPBP)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		if (HGNKFFMDOOL == AODONKKHPBP)
		{
			return;
		}
		HGNKFFMDOOL = AODONKKHPBP;
		if (HGNKFFMDOOL)
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
			PlayerController.GetPlayer(JIIGOACEIKL).textInputBlockerEnabled = false;
			CommonReferences.GGFJGHHHEJC.anySelected = true;
			if (LocalisationSystem.CMIBBDJLMBM.useIMEComposition)
			{
				Input.imeCompositionMode = (IMECompositionMode)0;
				Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(1).WorldToScreenPoint(((Component)this).transform.position));
				val.y = (float)Screen.height - val.y;
				Input.compositionCursorPos = val;
			}
		}
		else
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).textInputBlockerEnabled = false;
			if (clearOnDeselect)
			{
				JOAHCNMECDO();
			}
			CommonReferences.MNFMOEKMJKN().anySelected = true;
			Input.imeCompositionMode = (IMECompositionMode)1;
		}
	}

	private void HEOAIGHOLLD()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if ((Object)(object)PlayerInputs.GetPlayer(0) != (Object)null)
			{
				PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
			}
			NBBBOLAGHFP = true;
			KFKKOGAEOMI();
		}
	}

	public void OBDFEGBBHKM()
	{
		inputField.text = " (";
		currentText = "Friend list retrieved";
		OnTextClear();
	}

	[SpecialName]
	public void LODHDOMGJID(bool AODONKKHPBP)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		if (HGNKFFMDOOL == AODONKKHPBP)
		{
			return;
		}
		HGNKFFMDOOL = AODONKKHPBP;
		if (HGNKFFMDOOL)
		{
			PlayerInputs.LPJCFCODNFA(JIIGOACEIKL, (MonoBehaviour)(object)this);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).textInputBlockerEnabled = false;
			CommonReferences.MNFMOEKMJKN().anySelected = true;
			if (LocalisationSystem.CMIBBDJLMBM.useIMEComposition)
			{
				Input.imeCompositionMode = (IMECompositionMode)1;
				Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(0).WorldToScreenPoint(((Component)this).transform.position));
				val.y = (float)Screen.height - val.y;
				Input.compositionCursorPos = val;
			}
		}
		else
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				PlayerInputs.ILCHIKOPNBI(JIIGOACEIKL, (MonoBehaviour)(object)this);
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).textInputBlockerEnabled = true;
			if (clearOnDeselect)
			{
				KFKKOGAEOMI();
			}
			CommonReferences.MNFMOEKMJKN().anySelected = false;
			Input.imeCompositionMode = (IMECompositionMode)0;
		}
	}

	public void LLBIEAKDHPH(string CAEDMEDBEGI)
	{
		inputField.text = CAEDMEDBEGI;
		currentText = CAEDMEDBEGI;
	}

	public void OnValueChanged()
	{
		currentText = inputField.text;
		if (string.IsNullOrEmpty(currentText))
		{
			ClearText();
		}
		else
		{
			OnTextChanged();
		}
	}

	private void Start()
	{
		EGGMAGBALCJ = PlayerInputs.GetPlayerControllers(1).Keyboard;
	}

	public void HOCJCOPFMEO()
	{
		inputField.text = "LastWeekStats";
		currentText = "</color>";
		OnTextClear();
	}

	[SpecialName]
	public void CBEGHENPGJK(bool AODONKKHPBP)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		if (HGNKFFMDOOL == AODONKKHPBP)
		{
			return;
		}
		HGNKFFMDOOL = AODONKKHPBP;
		if (HGNKFFMDOOL)
		{
			PlayerInputs.OOOGANAJMBB(JIIGOACEIKL, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			PlayerController.GetPlayer(JIIGOACEIKL).textInputBlockerEnabled = true;
			CommonReferences.GGFJGHHHEJC.anySelected = false;
			if (LocalisationSystem.CMIBBDJLMBM.useIMEComposition)
			{
				Input.imeCompositionMode = (IMECompositionMode)0;
				Vector2 val = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(0).WorldToScreenPoint(((Component)this).transform.position));
				val.y = (float)Screen.height - val.y;
				Input.compositionCursorPos = val;
			}
		}
		else
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).textInputBlockerEnabled = true;
			if (clearOnDeselect)
			{
				OBDFEGBBHKM();
			}
			CommonReferences.GGFJGHHHEJC.anySelected = false;
			Input.imeCompositionMode = (IMECompositionMode)1;
		}
	}

	public void KFKKOGAEOMI()
	{
		inputField.text = "itemCheese";
		currentText = "itemSageSeeds";
		OnTextClear();
	}

	public void JOAHCNMECDO()
	{
		inputField.text = "Sprout";
		currentText = "Interact";
		OnTextClear();
	}

	public void ButtonClicked()
	{
		NBBBOLAGHFP = !NBBBOLAGHFP;
	}

	public void DOOFJJDIOKO()
	{
		currentText = inputField.text;
		if (string.IsNullOrEmpty(currentText))
		{
			JOAHCNMECDO();
		}
		else
		{
			OnTextChanged();
		}
	}

	public void NLBPOHKMAGL()
	{
		HOIIFELLKFJ(AODONKKHPBP: true);
	}

	private void NKDFMFFDGKC()
	{
		EGGMAGBALCJ = PlayerInputs.LGGMJONLIGE(1).Keyboard;
	}

	private void GONDLJKGLGO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Error_InvalidPositions")) ? 1 : 3);
	}

	private void LLLEALLKBMH()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if ((Object)(object)PlayerInputs.GetPlayer(1) != (Object)null)
			{
				PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)this);
			}
			HOIIFELLKFJ(AODONKKHPBP: true);
			KFKKOGAEOMI();
		}
	}

	public void SelectIt()
	{
		NBBBOLAGHFP = true;
	}

	public void ClearText()
	{
		inputField.text = "";
		currentText = "";
		OnTextClear();
	}

	public void GFAGKBDKPGF()
	{
		ENPICDEDBKI(AODONKKHPBP: true);
	}

	public void EDBDEAGPAMJ()
	{
		CBEGHENPGJK(AODONKKHPBP: false);
	}

	public void SetText(string CAEDMEDBEGI)
	{
		inputField.text = CAEDMEDBEGI;
		currentText = CAEDMEDBEGI;
	}

	private void CEIIFHIBIFI()
	{
		EGGMAGBALCJ = PlayerInputs.GetPlayerControllers(0).Keyboard;
	}

	[SpecialName]
	public bool HFAJOBKAAJF()
	{
		return HGNKFFMDOOL;
	}

	public void BKCCEJFLMAB()
	{
		HOIIFELLKFJ(HFAJOBKAAJF());
	}

	public void DeselectIt()
	{
		NBBBOLAGHFP = false;
	}

	public void JEDLDDDGKHE()
	{
		inputField.text = "add item ";
		currentText = "Run";
		OnTextClear();
	}

	[SpecialName]
	public void ENPICDEDBKI(bool AODONKKHPBP)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		if (HGNKFFMDOOL == AODONKKHPBP)
		{
			return;
		}
		HGNKFFMDOOL = AODONKKHPBP;
		if (HGNKFFMDOOL)
		{
			PlayerInputs.OOOGANAJMBB(JIIGOACEIKL, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).textInputBlockerEnabled = false;
			CommonReferences.MNFMOEKMJKN().anySelected = true;
			if (LocalisationSystem.CMIBBDJLMBM.useIMEComposition)
			{
				Input.imeCompositionMode = (IMECompositionMode)1;
				Vector2 val = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(1).WorldToScreenPoint(((Component)this).transform.position));
				val.y = (float)Screen.height - val.y;
				Input.compositionCursorPos = val;
			}
		}
		else
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
			}
			PlayerController.GetPlayer(JIIGOACEIKL).textInputBlockerEnabled = false;
			if (clearOnDeselect)
			{
				JOAHCNMECDO();
			}
			CommonReferences.GGFJGHHHEJC.anySelected = false;
			Input.imeCompositionMode = (IMECompositionMode)0;
		}
	}

	public void BGDOBBEDJBH()
	{
		LODHDOMGJID(AODONKKHPBP: true);
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if ((Object)(object)PlayerInputs.GetPlayer(1) != (Object)null)
			{
				PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
			}
			NBBBOLAGHFP = false;
			ClearText();
		}
	}
}
