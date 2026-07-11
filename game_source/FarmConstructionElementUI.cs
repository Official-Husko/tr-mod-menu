using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FarmConstructionElementUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public Action<FarmConstructionElementUI> OnButtonPressed = delegate
	{
	};

	public Action<int> OnPointerEnterAction = delegate
	{
	};

	public Action<int> OnPointerExitAction = delegate
	{
	};

	public int buttonNum;

	[SerializeField]
	private TextMeshProUGUI elementName;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Button button;

	[SerializeField]
	private SlotUI slotUI;

	[SerializeField]
	private TextMeshProUGUI levelText;

	public void IBIKMDOHBNF()
	{
		if (PlayerInputs.FJLAMCHKCOI(FarmConstructionUI.EKDNJDJHONF().JIIGOACEIKL))
		{
			OnPointerExitAction(buttonNum);
		}
	}

	public void ODOONGABBPH(PointerEventData NPBAMEMNFBI)
	{
		OnPointerExitAction(buttonNum);
	}

	public void OCKDAMCAOFA(PointerEventData NPBAMEMNFBI)
	{
		OnPointerEnterAction(buttonNum);
	}

	public void UpdateFeederInfo(string GEGDHHIDEEF, AnimalFeeder OHPCAOHHOEA)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		slotUI.IHENCGDNPBL.Stack = 1;
		if (OHPCAOHHOEA is AnimalFeederFood animalFeederFood)
		{
			slotUI.icon.SetSprite(animalFeederFood.style.icon);
		}
		else if (OHPCAOHHOEA is AnimalFeederWater animalFeederWater)
		{
			slotUI.icon.SetSprite(animalFeederWater.style.icon);
		}
		((TMP_Text)levelText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("LevelX"), (OHPCAOHHOEA.EONJGMONIOM + 1).ToString());
	}

	public bool KOHHOPOLMMD()
	{
		return ((Selectable)button).interactable;
	}

	public void PFBAJDGNCNK(string GEGDHHIDEEF, Sprite HEJNLFCKOKE)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		icon.sprite = HEJNLFCKOKE;
	}

	public void KMBCJNMHBOB()
	{
		if (PlayerInputs.EEJEOALIHFJ(FarmConstructionUI.JHKLPLPBKCI().JIIGOACEIKL))
		{
			OnPointerExitAction(buttonNum);
		}
	}

	public void OnDeselect()
	{
		if (PlayerInputs.IsGamepadActive(FarmConstructionUI.GGFJGHHHEJC.JIIGOACEIKL))
		{
			OnPointerExitAction(buttonNum);
		}
	}

	public void HBDDFMJOALH(PointerEventData NPBAMEMNFBI)
	{
		OnPointerExitAction(buttonNum);
	}

	public void OnSelect()
	{
		if (PlayerInputs.IsGamepadActive(FarmConstructionUI.GGFJGHHHEJC.JIIGOACEIKL))
		{
			OnPointerEnterAction(buttonNum);
		}
	}

	public void FNALECEACBK(string GEGDHHIDEEF, Sprite HEJNLFCKOKE)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		icon.sprite = HEJNLFCKOKE;
	}

	public bool AEBNKMAENDM()
	{
		return ((Selectable)button).interactable;
	}

	public void JDKHLOEHPNE()
	{
		OnButtonPressed(this);
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		OnPointerExitAction(buttonNum);
	}

	public void OIGPCKEONJN(string GEGDHHIDEEF, Sprite HEJNLFCKOKE)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		icon.sprite = HEJNLFCKOKE;
	}

	public void OAMABGPFPPF(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		OnPointerEnterAction(buttonNum);
	}

	public void LOMALNFDGHC(string GEGDHHIDEEF)
	{
		((TMP_Text)elementName).text = GEGDHHIDEEF;
	}

	public void UpdateActionInfo(string GEGDHHIDEEF, Sprite HEJNLFCKOKE)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		icon.sprite = HEJNLFCKOKE;
	}

	public void BOILBNHGKGO(string GEGDHHIDEEF)
	{
		((TMP_Text)elementName).text = GEGDHHIDEEF;
	}

	public void BDDIHGDAPEH()
	{
		if (PlayerInputs.POLDHCKJINN(FarmConstructionUI.MAIDHAPANEB().JIIGOACEIKL))
		{
			OnPointerEnterAction(buttonNum);
		}
	}

	public void FOCOPDPKIEN(PointerEventData NPBAMEMNFBI)
	{
		OnPointerExitAction(buttonNum);
	}

	public void AOJLBFECJPB(PointerEventData NPBAMEMNFBI)
	{
		OnPointerEnterAction(buttonNum);
	}

	public void JIEKLDEHFMA()
	{
		if (PlayerInputs.FJLAMCHKCOI(FarmConstructionUI.AAFOFNEHPLC().JIIGOACEIKL))
		{
			OnPointerExitAction(buttonNum);
		}
	}

	public void CMKNMEBAPNF(string GEGDHHIDEEF, AnimalFeeder OHPCAOHHOEA)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		slotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
		if (OHPCAOHHOEA is AnimalFeederFood animalFeederFood)
		{
			slotUI.icon.FBJKMPKINBB(animalFeederFood.style.icon);
		}
		else if (OHPCAOHHOEA is AnimalFeederWater animalFeederWater)
		{
			slotUI.icon.LCNODFNIGKM(animalFeederWater.style.icon);
		}
		((TMP_Text)levelText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" / H: "), (OHPCAOHHOEA.EONJGMONIOM + 1).ToString());
	}

	public void KFLOPOFFKHD()
	{
		if (PlayerInputs.FJLAMCHKCOI(FarmConstructionUI.PFHFIJDDOME().JIIGOACEIKL))
		{
			OnPointerEnterAction(buttonNum);
		}
	}

	public void SetInteractable(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
	}

	public void HNNOGOCEPHL(PointerEventData NPBAMEMNFBI)
	{
		OnPointerExitAction(buttonNum);
	}

	public bool IsInteractable()
	{
		return ((Selectable)button).interactable;
	}

	public void LBALJCCALBL(string GEGDHHIDEEF, AnimalFeeder OHPCAOHHOEA)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
		if (OHPCAOHHOEA is AnimalFeederFood animalFeederFood)
		{
			slotUI.icon.FBJKMPKINBB(animalFeederFood.style.icon);
		}
		else if (OHPCAOHHOEA is AnimalFeederWater animalFeederWater)
		{
			slotUI.icon.SetSprite(animalFeederWater.style.icon);
		}
		((TMP_Text)levelText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("time"), (OHPCAOHHOEA.EONJGMONIOM + 1).ToString());
	}

	public void IIHLEIIJKPN()
	{
		if (PlayerInputs.EEJEOALIHFJ(FarmConstructionUI.MIGKKKELOJO().JIIGOACEIKL))
		{
			OnPointerEnterAction(buttonNum);
		}
	}

	public void OnButtonClicked()
	{
		OnButtonPressed(this);
	}

	public void LNKPOCLFCEH(string GEGDHHIDEEF)
	{
		((TMP_Text)elementName).text = GEGDHHIDEEF;
	}

	public bool OBBGKPEINDA()
	{
		return ((Selectable)button).interactable;
	}

	public void NCGDJKGNEHB(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
	}

	public void SetText(string GEGDHHIDEEF)
	{
		((TMP_Text)elementName).text = GEGDHHIDEEF;
	}

	public void DMFNFCEJNDB()
	{
		if (PlayerInputs.FJLAMCHKCOI(FarmConstructionUI.BGMJCCFNNDL().JIIGOACEIKL))
		{
			OnPointerEnterAction(buttonNum);
		}
	}

	public void CKHGLDMCCNL(string GEGDHHIDEEF, AnimalFeeder OHPCAOHHOEA)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
		if (OHPCAOHHOEA is AnimalFeederFood animalFeederFood)
		{
			slotUI.icon.SetSprite(animalFeederFood.style.icon);
		}
		else if (OHPCAOHHOEA is AnimalFeederWater animalFeederWater)
		{
			slotUI.icon.JKDAHFEIJHA(animalFeederWater.style.icon);
		}
		TextMeshProUGUI obj = levelText;
		string cAEDMEDBEGI = LocalisationSystem.Get("MainProgress");
		string[] array = new string[0];
		array[1] = (OHPCAOHHOEA.EONJGMONIOM + 0).ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void IEFLHJKFEHP(PointerEventData NPBAMEMNFBI)
	{
		OnPointerEnterAction(buttonNum);
	}

	public void KLBGPCGDJGA(PointerEventData NPBAMEMNFBI)
	{
		OnPointerEnterAction(buttonNum);
	}

	public void DHJHHADLMMO(string GEGDHHIDEEF, Sprite HEJNLFCKOKE)
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
		((TMP_Text)elementName).text = GEGDHHIDEEF;
		icon.sprite = HEJNLFCKOKE;
	}

	public void CAKBJGFOOMF(string GEGDHHIDEEF)
	{
		((TMP_Text)elementName).text = GEGDHHIDEEF;
	}
}
