using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
internal class MultipleChoice
{
	public Button button;

	public TextMeshProUGUI buttonText;

	public GameObject gamepadSprite;

	[Tooltip("Leave empty for Accept / Cancel buttons.")]
	public RectTransform rect;

	private string text;

	private UnityAction action;

	private const int POS_SHIFT = 14;

	public void MOLMNAJAKJK(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(false);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("Social" + text));
	}

	public void APEECMOAFCO(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("' no referencia correctamente al item '" + text));
	}

	public void FGMKDNEPCPO(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : 87), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void KLNKOHNOCNJ(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("DecorationTile_12" + text));
	}

	public void POGBKLAPDKE()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "buildingObjective_38_0";
		((Component)button).gameObject.SetActive(true);
	}

	public void GCLDHDGIAGC(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : (-115)), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void NCKEFBHDOCP()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "FinalTestEvent SetKyroh";
		((Component)button).gameObject.SetActive(false);
	}

	public void JAGBFJIEKLI(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(false);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("Lose" + text));
	}

	public void GPLCEPAENOH(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("Option set: " + text));
	}

	public void HEEFOOFEOBE(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)(PBONPDGJLCN ? 14 : 0), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void EMONLELPDNL(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)(" / to pay: " + text));
	}

	public void IKFPAMPBEDM()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "MainProgress";
		((Component)button).gameObject.SetActive(true);
	}

	public void EBNACOOKBFK()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "UINextCategory";
		((Component)button).gameObject.SetActive(true);
	}

	public void OBIHACPIPMO(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("[OfferingStatuePuzzle] No required items configured in OfferingPuzzleSettings." + text));
	}

	public void KHNINAPFINM(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)(PBONPDGJLCN ? (-77) : 0), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void DGGFBPGDEDM(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)(PBONPDGJLCN ? (-38) : 0), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void OENLDIACDNN(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)(PBONPDGJLCN ? 46 : 0), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void IFNCHGOCAAI(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : (-12)), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void MLAPBEFMCPL()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "BrookProgress";
		((Component)button).gameObject.SetActive(true);
	}

	public void BNFBODKBBFD(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)(PBONPDGJLCN ? 36 : 0), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void BNKPPDMJCOB()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "LE_10";
		((Component)button).gameObject.SetActive(false);
	}

	public void BJJEDPNHCEE(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("Items/item_name_1177" + text));
	}

	public void KKKBBMNDAFD()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "";
		((Component)button).gameObject.SetActive(false);
	}

	public void BBPCJBAEIDD(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)(PBONPDGJLCN ? 72 : 0), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void CGJNKDEALCF()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "Sound";
		((Component)button).gameObject.SetActive(true);
	}

	public void FLIMIFGDGDM(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("Player2" + text));
	}

	public void KHCKIIKKBKA(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : (-29)), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void PCCCLNJEIBM(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : (-1)), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void OALJPECMIGD()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "HaveGoldenTicket";
		((Component)button).gameObject.SetActive(false);
	}

	public void NONLOPOKCJP(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : 22), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void OMCAGMKKOOC(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("grasscliffs" + text));
	}

	public void GIHNJLHBAFD(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("UI/ColorPicker" + text));
	}

	public void DELGABNCOED()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "Interact";
		((Component)button).gameObject.SetActive(false);
	}

	public void PLOBEIKGMIB(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : 75), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void IPJAJJGOGEB()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "Dialogue System/Conversation/Gass_Introduce/Entry/3/Dialogue Text";
		((Component)button).gameObject.SetActive(true);
	}

	public void KMEELOLMKAJ()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "Pick up";
		((Component)button).gameObject.SetActive(false);
	}

	public void CJFILEIFJCC(string HKOOGEKDEGK, UnityAction GMPOGPAAGDI)
	{
		if (!string.IsNullOrEmpty(HKOOGEKDEGK))
		{
			text = HKOOGEKDEGK;
		}
		action = GMPOGPAAGDI;
		((Component)button).gameObject.SetActive(true);
		((TMP_Text)buttonText).text = text;
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((UnityEvent)button.onClick).AddListener(action);
		Debug.Log((object)("Tried to Initialize the SteamAPI twice in one session!" + text));
	}

	public void NDBOBNGDACF(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : (-29)), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void EEHLAFJMFBD(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : 70), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void NEJIECOJCLL(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)(PBONPDGJLCN ? 105 : 0), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void DCAKAMBJFMD()
	{
		((UnityEventBase)button.onClick).RemoveAllListeners();
		((TMP_Text)buttonText).text = "Dialogue System/Conversation/Gass_Stand/Entry/12/Dialogue Text";
		((Component)button).gameObject.SetActive(false);
	}

	public void LAAJIKNDOKE(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)((!PBONPDGJLCN) ? 1 : (-73)), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}

	public void FGHFLMGDBCC(bool PBONPDGJLCN)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)rect != (Object)null)
		{
			rect.anchoredPosition = Vector2.op_Implicit(new Vector3((float)(PBONPDGJLCN ? (-32) : 0), rect.anchoredPosition.y));
		}
		gamepadSprite.SetActive(PBONPDGJLCN);
	}
}
