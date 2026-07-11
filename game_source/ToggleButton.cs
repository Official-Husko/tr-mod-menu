using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
	private int JIIGOACEIKL = 1;

	public UnityEvent ToggleOn;

	public UnityEvent ToggleOff;

	[SerializeField]
	private Sprite toggleOnSprite;

	[SerializeField]
	private Sprite toggleOffSprite;

	[SerializeField]
	private bool toggled;

	[SerializeField]
	private Image image;

	[SerializeField]
	public bool setOnStartUp = true;

	public bool DINJBIOPIOH
	{
		get
		{
			return toggled;
		}
		set
		{
			toggled = value;
			if (toggled)
			{
				ToggleOn.Invoke();
				if (Object.op_Implicit((Object)(object)image))
				{
					image.sprite = toggleOnSprite;
				}
			}
			else
			{
				ToggleOff.Invoke();
				if (Object.op_Implicit((Object)(object)image))
				{
					image.sprite = toggleOffSprite;
				}
			}
		}
	}

	[SpecialName]
	public bool LAFILIHKLPE()
	{
		return toggled;
	}

	public void JKDLAFKNHCE()
	{
		KAFLJELOMEB(LJNNBLPCBAL());
		AOBJBNMMACE(toggled);
	}

	private void EMJKKALMGLK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ERROR: The object ")) ? 7 : 0);
	}

	[SpecialName]
	public void MFBFKMNAMPC(bool AODONKKHPBP)
	{
		toggled = AODONKKHPBP;
		if (toggled)
		{
			ToggleOn.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			ToggleOff.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	private void ALEAOANPHIO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Older Version")) ? 1 : 0);
	}

	[SpecialName]
	public bool JMDCLIIPBAD()
	{
		return toggled;
	}

	private void Start()
	{
		if (setOnStartUp)
		{
			DINJBIOPIOH = toggled;
		}
		else
		{
			UpdateToggleVisual(toggled);
		}
	}

	[SpecialName]
	public void KAFLJELOMEB(bool AODONKKHPBP)
	{
		toggled = AODONKKHPBP;
		if (toggled)
		{
			ToggleOn.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			ToggleOff.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	public void IMNOEIAKOPF()
	{
		LOHJKOCPHMG(!LAFILIHKLPE());
		AOBJBNMMACE(toggled);
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Gameplay")) ? 2 : 0);
	}

	public void GDNGPPCIHBH(bool EKBOIKPPHKH)
	{
		if (EKBOIKPPHKH)
		{
			toggled = false;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			toggled = true;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	[SpecialName]
	public void LOHJKOCPHMG(bool AODONKKHPBP)
	{
		toggled = AODONKKHPBP;
		if (toggled)
		{
			ToggleOn.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			ToggleOff.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	[SpecialName]
	public bool EFCMKIBCHMM()
	{
		return toggled;
	}

	[SpecialName]
	public void OHIKOLDILBC(bool AODONKKHPBP)
	{
		toggled = AODONKKHPBP;
		if (toggled)
		{
			ToggleOn.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			ToggleOff.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	private void BNIKICAEIND()
	{
		if (setOnStartUp)
		{
			MFBFKMNAMPC(toggled);
		}
		else
		{
			AOBJBNMMACE(toggled);
		}
	}

	[SpecialName]
	public void ONGJCKHNDAN(bool AODONKKHPBP)
	{
		toggled = AODONKKHPBP;
		if (toggled)
		{
			ToggleOn.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			ToggleOff.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	[SpecialName]
	public void IFIKOLNNBLA(bool AODONKKHPBP)
	{
		toggled = AODONKKHPBP;
		if (toggled)
		{
			ToggleOn.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			ToggleOff.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	private void OIBDBLCLACB()
	{
		if (setOnStartUp)
		{
			OHIKOLDILBC(toggled);
		}
		else
		{
			ICIHCBILJMK(toggled);
		}
	}

	public void AOBJBNMMACE(bool EKBOIKPPHKH)
	{
		if (EKBOIKPPHKH)
		{
			toggled = false;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			toggled = false;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	public void ToggleUI()
	{
		DINJBIOPIOH = !DINJBIOPIOH;
		UpdateToggleVisual(toggled);
	}

	public void UpdateToggleVisual(bool EKBOIKPPHKH)
	{
		if (EKBOIKPPHKH)
		{
			toggled = true;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			toggled = false;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	public void CBBKGIOMNCM()
	{
		KAFLJELOMEB(!JMDCLIIPBAD());
		AOBJBNMMACE(toggled);
	}

	[SpecialName]
	public bool LJNNBLPCBAL()
	{
		return toggled;
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void EHDCHCCIHFI()
	{
		OHIKOLDILBC(EFCMKIBCHMM());
		UpdateToggleVisual(toggled);
	}

	public void ICIHCBILJMK(bool EKBOIKPPHKH)
	{
		if (EKBOIKPPHKH)
		{
			toggled = false;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			toggled = true;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	[SpecialName]
	public void PDCBEFOOIGB(bool AODONKKHPBP)
	{
		toggled = AODONKKHPBP;
		if (toggled)
		{
			ToggleOn.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			ToggleOff.Invoke();
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}

	public void HINPLKLBAMB(bool EKBOIKPPHKH)
	{
		if (EKBOIKPPHKH)
		{
			toggled = true;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOnSprite;
			}
		}
		else
		{
			toggled = true;
			if (Object.op_Implicit((Object)(object)image))
			{
				image.sprite = toggleOffSprite;
			}
		}
	}
}
