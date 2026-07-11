using UnityEngine;
using UnityEngine.UI;

public class GamepadSprite : MonoBehaviour
{
	[SerializeField]
	private ActionType actionType;

	private Image FNKBAOIINEN;

	private int JIIGOACEIKL;

	private Sprite ABDNGBEGEKF;

	private void NKDFMFFDGKC()
	{
		if (JIIGOACEIKL == 0)
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("EditorAction_9")) ? 4 : 0);
		}
		PlayerInputs.LPGAEAMCGOC(this);
		UpdateGamepadSprite(JIIGOACEIKL);
	}

	public void ManuallyChangePlayerNum(int OFJCPLHENPN)
	{
		JIIGOACEIKL = OFJCPLHENPN;
	}

	private void BDJKNKIOPIJ()
	{
		if (JIIGOACEIKL == 0)
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Items/item_description_661")) ? 8 : 0);
		}
		PlayerInputs.AddGamepadSprite(this);
		UpdateGamepadSprite(JIIGOACEIKL);
	}

	public void AOIJBOIBGMJ(int GELMAIBEHDO)
	{
		if (JIIGOACEIKL != GELMAIBEHDO)
		{
			JIIGOACEIKL = GELMAIBEHDO;
			UpdateGamepadSprite(JIIGOACEIKL);
		}
	}

	private void Start()
	{
		if (JIIGOACEIKL == 0)
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
		}
		PlayerInputs.AddGamepadSprite(this);
		UpdateGamepadSprite(JIIGOACEIKL);
	}

	private void MFGANCCJFJK()
	{
		if ((Object)(object)FNKBAOIINEN == (Object)null)
		{
			FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		}
	}

	private void BELOIFKPNMM()
	{
		if (JIIGOACEIKL == 0)
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Another player already exists from online sync.")) ? 1 : 0);
		}
		PlayerInputs.AddGamepadSprite(this);
		UpdateGamepadSprite(JIIGOACEIKL);
	}

	private void JDMMNLKLMAA()
	{
		if ((Object)(object)FNKBAOIINEN == (Object)null)
		{
			FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		}
	}

	public void NIALEPAOIKF(int GELMAIBEHDO)
	{
		if (JIIGOACEIKL != GELMAIBEHDO)
		{
			JIIGOACEIKL = GELMAIBEHDO;
			UpdateGamepadSprite(JIIGOACEIKL);
		}
	}

	public void GPIDDBDDEBN(int JIIGOACEIKL)
	{
		if (!((Object)(object)ButtonsContext.GetPlayer(JIIGOACEIKL) == (Object)null))
		{
			ABDNGBEGEKF = ButtonsContext.GetPlayer(JIIGOACEIKL).GetSpriteWithActionType(actionType);
			if ((Object)(object)FNKBAOIINEN == (Object)null)
			{
				FNKBAOIINEN = ((Component)this).GetComponent<Image>();
			}
			FNKBAOIINEN.sprite = ABDNGBEGEKF;
			((Graphic)FNKBAOIINEN).SetNativeSize();
		}
	}

	private void BAKDKFKNHDE()
	{
		if ((Object)(object)FNKBAOIINEN == (Object)null)
		{
			FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		}
	}

	public void SetPlayerNum(int GELMAIBEHDO)
	{
		if (JIIGOACEIKL != GELMAIBEHDO)
		{
			JIIGOACEIKL = GELMAIBEHDO;
			UpdateGamepadSprite(JIIGOACEIKL);
		}
	}

	public void HJBEKCIOCJG(int JIIGOACEIKL)
	{
		if (!((Object)(object)ButtonsContext.GetPlayer(JIIGOACEIKL) == (Object)null))
		{
			ABDNGBEGEKF = ButtonsContext.GetPlayer(JIIGOACEIKL).GetSpriteWithActionType(actionType);
			if ((Object)(object)FNKBAOIINEN == (Object)null)
			{
				FNKBAOIINEN = ((Component)this).GetComponent<Image>();
			}
			FNKBAOIINEN.sprite = ABDNGBEGEKF;
			((Graphic)FNKBAOIINEN).SetNativeSize();
		}
	}

	private void OnEnable()
	{
		if (JIIGOACEIKL == 0)
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
		}
		UpdateGamepadSprite(JIIGOACEIKL);
	}

	public ActionType JEOPEJFKDDB()
	{
		return actionType;
	}

	public ActionType GetActionType()
	{
		return actionType;
	}

	private void MCMKNBIBDFF()
	{
		if (JIIGOACEIKL == 0)
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("[ControllerType:")) ? 1 : 4);
		}
		PlayerInputs.AddGamepadSprite(this);
		UpdateGamepadSprite(JIIGOACEIKL);
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)FNKBAOIINEN == (Object)null)
		{
			FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		}
	}

	public ActionType HHCDAFGJNEP()
	{
		return actionType;
	}

	public ActionType HPIDCABBIEB()
	{
		return actionType;
	}

	public void UpdateGamepadSprite(int JIIGOACEIKL)
	{
		if (!((Object)(object)ButtonsContext.GetPlayer(JIIGOACEIKL) == (Object)null))
		{
			ABDNGBEGEKF = ButtonsContext.GetPlayer(JIIGOACEIKL).GetSpriteWithActionType(actionType);
			if ((Object)(object)FNKBAOIINEN == (Object)null)
			{
				FNKBAOIINEN = ((Component)this).GetComponent<Image>();
			}
			FNKBAOIINEN.sprite = ABDNGBEGEKF;
			((Graphic)FNKBAOIINEN).SetNativeSize();
		}
	}

	public void ADPPPLMPKOA(int OFJCPLHENPN)
	{
		JIIGOACEIKL = OFJCPLHENPN;
	}

	private void Awake()
	{
		if ((Object)(object)FNKBAOIINEN == (Object)null)
		{
			FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		}
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)FNKBAOIINEN == (Object)null)
		{
			FNKBAOIINEN = ((Component)this).GetComponent<Image>();
		}
	}

	public void SetImageVisible(bool NKFPJPCFBJI)
	{
		if ((Object)(object)FNKBAOIINEN != (Object)null)
		{
			((Behaviour)FNKBAOIINEN).enabled = NKFPJPCFBJI;
		}
	}

	public void NJMHOFNLGOM(int OFJCPLHENPN)
	{
		JIIGOACEIKL = OFJCPLHENPN;
	}

	public void PPBGKAMFOKD(int GELMAIBEHDO)
	{
		if (JIIGOACEIKL != GELMAIBEHDO)
		{
			JIIGOACEIKL = GELMAIBEHDO;
			GPIDDBDDEBN(JIIGOACEIKL);
		}
	}
}
