using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UISelectionManager : MonoBehaviour
{
	private static UISelectionManager IADEMLIIDPC;

	private static UISelectionManager BBINLIGKIPE;

	public int playerNum;

	[SerializeField]
	private Selectable _selected;

	[HideInInspector]
	public int currentPlayerNumSelection = 1;

	private float IMDFNGAKGKI;

	private float JLPOFCJOPJJ;

	private float FIHGGDIGIEA;

	private float EFNKHHGMPLD;

	private float JLNNKHOPINH;

	public Selectable lastSelection;

	private Selectable NALKHMACHFL;

	public Selectable HGNKFFMDOOL => _selected;

	private void EBNJADODONG()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "", AxisContribution.Negative, 1313f, 1547f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
				NMAOFEFMNNB(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (LBAOPFLACKC(_selected))
			{
				ABBEMDMCPHI(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "Received cursor move for grid index {0} from player {1} in mine level {2}", AxisContribution.Negative, 694f, 631f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
				IHFNCOGFJOJ(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (MCIGMELKFDC(_selected))
			{
				ABBEMDMCPHI(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "TimeLeft", AxisContribution.Negative, 801f, 1634f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
				IHFNCOGFJOJ(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (LBAOPFLACKC(_selected))
			{
				MCPGDCCHEHM(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "[BouncerGender=", AxisContribution.Positive, 200f, 1285f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				BNFLJFFKMMN(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (LBAOPFLACKC(_selected))
			{
				CGDNLCJDFIG(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "itemCoconutSeeds", 250f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.SetExecute(playerNum, JGJCFHPMKGF: false);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					BNBPMIKMDDP((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					HPJBFMEHFKF((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "ReceiveUpdateDrinkColorTable", 528f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				CMBBFEABMBE((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	public void BMCAGHAMOIC()
	{
		_selected = null;
	}

	public void Select(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	public void HIOFAHPKLLE()
	{
		_selected = null;
	}

	[SpecialName]
	public Selectable PBGKEEENPME()
	{
		return _selected;
	}

	public static UISelectionManager GIGBGIIAKMP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void LFLFDKBKILJ(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			HPJBFMEHFKF(null);
		}
		CMBBFEABMBE(MEGPBGODLIL.GetComponent<Selectable>());
	}

	private void Update()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.IsGamepadActive(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "UIVertical", AxisContribution.Positive))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
				Select(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PFIOABIMBHH(_selected))
			{
				Select(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "UIVertical", AxisContribution.Negative))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
				Select(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PFIOABIMBHH(_selected))
			{
				Select(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "UIHorizontal", AxisContribution.Positive))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
				Select(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PFIOABIMBHH(_selected))
			{
				Select(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "UIHorizontal", AxisContribution.Negative))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				Select(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PFIOABIMBHH(_selected))
			{
				Select(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "UIInteract"))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.SetExecute(playerNum, JGJCFHPMKGF: true);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					Select((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					Select((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "UIBack") && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				Select((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	[SpecialName]
	public Selectable BCHJGDHJHJK()
	{
		return _selected;
	}

	public void BEGCHMCDPOK()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = MGOEJJIMAIP();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	public void BIHHMCBFPNK()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = HGNKFFMDOOL;
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	public void JLHDKMCCHHH()
	{
		_selected = null;
	}

	public void ALPPCGLKHIO(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			IHFNCOGFJOJ(null);
		}
		BNFLJFFKMMN(MEGPBGODLIL.GetComponent<Selectable>());
	}

	private void HNEGFBCKIIJ()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(EBBDPPNOMED));
	}

	public void CGDNLCJDFIG(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			BNBPMIKMDDP(MNDCJGAHJCG);
		}
		else
		{
			Select(HHFPKDCPPBD);
		}
	}

	public void FAJHEKCACNF(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			NCGCKHGOJCM(MNDCJGAHJCG);
		}
		else
		{
			BNBPMIKMDDP(HHFPKDCPPBD);
		}
	}

	private void OGNIDHAIABM()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "BaseCamp", AxisContribution.Negative, 52f, 689f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
				NMAOFEFMNNB(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (FMIDGIANEMF(_selected))
			{
				FKDFHIKHPAG(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "Pet", AxisContribution.Positive, 1937f, 1037f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
				NMAOFEFMNNB(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (FCKGGJGEBEE(_selected))
			{
				MCPGDCCHEHM(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "particleSystem not attached to ", AxisContribution.Positive, 2f, 1735f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
				PICNNIMLFFL(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (DCELGJHEANJ(_selected))
			{
				FKDFHIKHPAG(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "Cat", AxisContribution.Negative, 1810f, 951f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				NCGCKHGOJCM(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (PFDHGEBEMFD(_selected))
			{
				MJPGCPCNOOH(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "on player sleep", 1468f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.SetExecute(playerNum, JGJCFHPMKGF: false);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					IHFNCOGFJOJ((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					GPCLGOHKMCK((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "RewardEntry weights sum {0}, expected 100", 1495f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				MGIFADFILOI((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	public static UISelectionManager BPDFMAEOGGC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void MGGIGAIHHON(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			CMBBFEABMBE(MNDCJGAHJCG);
		}
		else
		{
			MGIFADFILOI(HHFPKDCPPBD);
		}
	}

	public void LCLJFCKELJN()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = CGCIFFOJGOK();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	public void Select(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			Select((Selectable)null);
		}
		Select(MEGPBGODLIL.GetComponent<Selectable>());
	}

	public void IHFNCOGFJOJ(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	public void EBBDPPNOMED()
	{
		_selected = null;
	}

	public void HCHMAIEMAGA(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	public void GGNLGAMLOKK()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = MGOEJJIMAIP();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	private void PEFKNEPONAG()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public void JHHNCDODNBD(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			CMBBFEABMBE(null);
		}
		PICNNIMLFFL(MEGPBGODLIL.GetComponent<Selectable>());
	}

	[SpecialName]
	public Selectable FOKMCIDMIKF()
	{
		return _selected;
	}

	[SpecialName]
	public Selectable KBFCCPBHDMP()
	{
		return _selected;
	}

	public void MCPGDCCHEHM(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			HPJBFMEHFKF(MNDCJGAHJCG);
		}
		else
		{
			HCHMAIEMAGA(HHFPKDCPPBD);
		}
	}

	public static UISelectionManager HELHJMDEDNL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private bool CJMMCGGMDHC(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return true;
		}
		return true;
	}

	public void FKDFHIKHPAG(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			GPCLGOHKMCK(MNDCJGAHJCG);
		}
		else
		{
			BNFLJFFKMMN(HHFPKDCPPBD);
		}
	}

	public void NMAOFEFMNNB(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	public void NCGCKHGOJCM(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	private void LMFICKFGEFI()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "", AxisContribution.Positive, 502f, 1391f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
				IHFNCOGFJOJ(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (DCELGJHEANJ(_selected))
			{
				MJPGCPCNOOH(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "Player", AxisContribution.Negative, 154f, 1837f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
				NMAOFEFMNNB(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PFIOABIMBHH(_selected))
			{
				Select(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "BuildMode", AxisContribution.Negative, 311f, 929f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
				PICNNIMLFFL(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (FCKGGJGEBEE(_selected))
			{
				MGGIGAIHHON(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "ActionBar5", AxisContribution.Positive, 378f, 1128f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				MGIFADFILOI(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (CJMMCGGMDHC(_selected))
			{
				CGDNLCJDFIG(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "No seat or table!", 4f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
				{
					CommonReferences.MNFMOEKMJKN().HPDOMEIJAJI(playerNum, JGJCFHPMKGF: false);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					GPCLGOHKMCK((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					HCHMAIEMAGA((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "Drink", 1649f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				BNBPMIKMDDP((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	public void Select(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			Select(MNDCJGAHJCG);
		}
		else
		{
			Select(HHFPKDCPPBD);
		}
	}

	public void IHDPOMIAKOO()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = HGNKFFMDOOL;
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	public void LBFFIBKMLGO()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = CGCIFFOJGOK();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	[SpecialName]
	public Selectable BEOANCLEPOO()
	{
		return _selected;
	}

	[SpecialName]
	public Selectable CGCIFFOJGOK()
	{
		return _selected;
	}

	private void IDHCFOCEPMD()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(HIOFAHPKLLE));
	}

	public void DBDKJHDDEKI()
	{
		_selected = null;
	}

	public void KGPDHFFEDKP(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			BNBPMIKMDDP(null);
		}
		NMAOFEFMNNB(MEGPBGODLIL.GetComponent<Selectable>());
	}

	private void MMNBJPDJHGK()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public Selectable MGOEJJIMAIP()
	{
		return _selected;
	}

	public void BNBPMIKMDDP(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	private void Start()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(OnPlayer2Disconnected));
	}

	public void MJPGCPCNOOH(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			PICNNIMLFFL(MNDCJGAHJCG);
		}
		else
		{
			CMBBFEABMBE(HHFPKDCPPBD);
		}
	}

	private bool PFIOABIMBHH(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return true;
		}
		return false;
	}

	private void BIILFPDIADC()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "Farm/Buzz/Introduce", AxisContribution.Positive, 1222f, 1944f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
				GPCLGOHKMCK(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (PFDHGEBEMFD(_selected))
			{
				FAJHEKCACNF(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "}", AxisContribution.Negative, 1216f, 253f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
				HCHMAIEMAGA(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (CJMMCGGMDHC(_selected))
			{
				KHMDOPOEGCI(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "0", AxisContribution.Positive, 1331f, 1258f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
				HPJBFMEHFKF(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (MCIGMELKFDC(_selected))
			{
				ABBEMDMCPHI(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "VSync", AxisContribution.Negative, 1370f, 170f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				BNBPMIKMDDP(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (CJMMCGGMDHC(_selected))
			{
				MJPGCPCNOOH(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, " ", 252f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.DCEJENGEPLN(playerNum, JGJCFHPMKGF: true);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					BNFLJFFKMMN((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					Select((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "\n", 415f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				CMBBFEABMBE((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	public void MGIFADFILOI(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	private void HFMJPMEALMO()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(EBBDPPNOMED));
	}

	public void FJAKDODEIIF()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = BEOANCLEPOO();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	private bool FCKGGJGEBEE(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return false;
		}
		return true;
	}

	private void NCPNBBCNBIM()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public void GHPMOPMMLJI(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			HPJBFMEHFKF(null);
		}
		IHFNCOGFJOJ(MEGPBGODLIL.GetComponent<Selectable>());
	}

	public void OnPlayer2Disconnected()
	{
		_selected = null;
	}

	private void Awake()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void GECHJIGBPEN()
	{
		if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public Selectable KDJFBLKPFKM()
	{
		return _selected;
	}

	public void FBKDHHPNBIL()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = BEOANCLEPOO();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	public void MFCNGGMNBHB(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	public void CKMLGHPIEEK()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = PBGKEEENPME();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	private void BELOIFKPNMM()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(DBDKJHDDEKI));
	}

	private void EGDIINMEMGE()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(OnPlayer2Disconnected));
	}

	public void HPJBFMEHFKF(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	public void BOBIPFOJBKC(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			MFCNGGMNBHB(MNDCJGAHJCG);
		}
		else
		{
			BNBPMIKMDDP(HHFPKDCPPBD);
		}
	}

	public void FILHNMJHBGI(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			IHFNCOGFJOJ(MNDCJGAHJCG);
		}
		else
		{
			PICNNIMLFFL(HHFPKDCPPBD);
		}
	}

	private void HOFKJPBBLGP()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(BMCAGHAMOIC));
	}

	private void JBGFGOCPEFD()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "Day", AxisContribution.Positive, 1190f, 311f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
				PICNNIMLFFL(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (PPANICJCEIA(_selected))
			{
				KHMDOPOEGCI(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, " ", AxisContribution.Negative, 1522f, 1838f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
				HPJBFMEHFKF(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (MCIGMELKFDC(_selected))
			{
				LIEJLJFBDFC(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "Sharing one of the files from local storage failed for reason: ", AxisContribution.Positive, 1581f, 428f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
				CMBBFEABMBE(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (PFDHGEBEMFD(_selected))
			{
				MJPGCPCNOOH(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "RegisterExclusionZone - Spawner: ", AxisContribution.Positive, 537f, 232f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				NCGCKHGOJCM(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (MCIGMELKFDC(_selected))
			{
				ABBEMDMCPHI(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "Achievements definitions could not be retrived for reason: ", 883f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: true);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					MFCNGGMNBHB((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					MGIFADFILOI((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "Dialogue System/Conversation/NeutralInTavern/Entry/13/Dialogue Text", 348f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				PICNNIMLFFL((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	private void OAKGHDAABPM()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "- ", AxisContribution.Positive, 678f, 1282f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
				PICNNIMLFFL(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (DCELGJHEANJ(_selected))
			{
				FILHNMJHBGI(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "Player", AxisContribution.Positive, 1194f, 1205f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
				CMBBFEABMBE(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (CJMMCGGMDHC(_selected))
			{
				FKDFHIKHPAG(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "Summer", AxisContribution.Positive, 1691f, 906f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
				NCGCKHGOJCM(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (DCELGJHEANJ(_selected))
			{
				ABBEMDMCPHI(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "Angry", AxisContribution.Positive, 489f, 105f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
				CMBBFEABMBE(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PFIOABIMBHH(_selected))
			{
				CMPEPGEMEDI(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, " - ", 826f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum))
				{
					CommonReferences.MNFMOEKMJKN().SetExecute(playerNum, JGJCFHPMKGF: true);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					NMAOFEFMNNB((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					BNFLJFFKMMN((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "MineSymbolPuzzle requires SymbolPuzzleSettings", 1815f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				IHFNCOGFJOJ((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	private void DKNMGFDFLKL()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "Drink", AxisContribution.Negative, 430f, 292f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
				MGIFADFILOI(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (FCKGGJGEBEE(_selected))
			{
				MCPGDCCHEHM(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "Aged price", AxisContribution.Negative, 603f, 1382f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
				Select(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (LBAOPFLACKC(_selected))
			{
				ABBEMDMCPHI(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "halloweenActivated", AxisContribution.Negative, 48f, 1353f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
				BNFLJFFKMMN(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (CJMMCGGMDHC(_selected))
			{
				CGDNLCJDFIG(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "Profit", AxisContribution.Negative, 1252f, 1410f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				MGIFADFILOI(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (FCKGGJGEBEE(_selected))
			{
				FILHNMJHBGI(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "Inventory full", 1076f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum))
				{
					CommonReferences.MNFMOEKMJKN().DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					Select((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					MFCNGGMNBHB((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "NinjaChallengeEvent/Win", 1426f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				PICNNIMLFFL((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	private void DEEIEACLPEF()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.POLDHCKJINN(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "ReceiveNextGameDate", AxisContribution.Negative, 1511f, 668f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
				PICNNIMLFFL(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (PFDHGEBEMFD(_selected))
			{
				FAJHEKCACNF(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "Calendar", AxisContribution.Positive, 191f, 1227f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
				PICNNIMLFFL(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (MCIGMELKFDC(_selected))
			{
				LIEJLJFBDFC(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "ReceiveLookAtDirection", AxisContribution.Negative, 440f, 1473f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
				HPJBFMEHFKF(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (MCIGMELKFDC(_selected))
			{
				KHMDOPOEGCI(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "start ninja", AxisContribution.Positive, 1536f, 1973f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
				BNBPMIKMDDP(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (DCELGJHEANJ(_selected))
			{
				FKDFHIKHPAG(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "ReceiveFountainsPuzzleSolved", 596f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: true);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					MFCNGGMNBHB((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					HCHMAIEMAGA((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "Received ", 509f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				HPJBFMEHFKF((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	public void MCBONGNMONH()
	{
		_selected = null;
	}

	private void EJMAJFGPGEC()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "Sleep", AxisContribution.Negative, 877f, 79f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
				NMAOFEFMNNB(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (FCKGGJGEBEE(_selected))
			{
				CMPEPGEMEDI(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "itemStick", AxisContribution.Negative, 842f, 544f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
				PICNNIMLFFL(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PPANICJCEIA(_selected))
			{
				MCPGDCCHEHM(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "BarkActor", AxisContribution.Positive, 1346f, 1109f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
				MFCNGGMNBHB(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PPANICJCEIA(_selected))
			{
				MCPGDCCHEHM(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "Giving extra stones", AxisContribution.Positive, 126f, 1947f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				NCGCKHGOJCM(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (CJMMCGGMDHC(_selected))
			{
				FAJHEKCACNF(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, " // Replaced for ", 316f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.SetExecute(playerNum, JGJCFHPMKGF: true);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					IHFNCOGFJOJ((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					HCHMAIEMAGA((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "Fill", 286f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				HPJBFMEHFKF((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	public void ABBEMDMCPHI(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			PICNNIMLFFL(MNDCJGAHJCG);
		}
		else
		{
			BNBPMIKMDDP(HHFPKDCPPBD);
		}
	}

	public static UISelectionManager GetPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public Selectable BOHHKGMEEEE()
	{
		return _selected;
	}

	public void DAFBICEGOFO()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = HGNKFFMDOOL;
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	private bool LBAOPFLACKC(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return false;
		}
		return false;
	}

	private void OILHJENGGEL()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(EBBDPPNOMED));
	}

	private bool MCIGMELKFDC(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return true;
		}
		return false;
	}

	public void FPLPECHEGGI()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = KBFCCPBHDMP();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	public void Deselect()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = HGNKFFMDOOL;
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	private void OFDEGDJGGGF()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "City/Lia/Bark/Bye", AxisContribution.Positive, 1817f, 1446f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
				GPCLGOHKMCK(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (LBAOPFLACKC(_selected))
			{
				CGDNLCJDFIG(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "Cancel", AxisContribution.Positive, 498f, 1727f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
				PICNNIMLFFL(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (FCKGGJGEBEE(_selected))
			{
				BOBIPFOJBKC(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/30/Dialogue Text", AxisContribution.Positive, 1935f, 90f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
				NMAOFEFMNNB(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (LBAOPFLACKC(_selected))
			{
				CGDNLCJDFIG(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "Ax Level Low", AxisContribution.Positive, 1046f, 727f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
				IHFNCOGFJOJ(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (DCELGJHEANJ(_selected))
			{
				BOBIPFOJBKC(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "Attack/MainEvent 11", 147f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: true);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					HCHMAIEMAGA((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					GPCLGOHKMCK((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "add letter", 591f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				NCGCKHGOJCM((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	public void LDAGOHPIGNA(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			HCHMAIEMAGA(null);
		}
		GPCLGOHKMCK(MEGPBGODLIL.GetComponent<Selectable>());
	}

	public void KMEJOPAKIJM(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			MGIFADFILOI(MNDCJGAHJCG);
		}
		else
		{
			HPJBFMEHFKF(HHFPKDCPPBD);
		}
	}

	public void LPIOJMDAMBP()
	{
		_selected = null;
	}

	public void CMPEPGEMEDI(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			NMAOFEFMNNB(MNDCJGAHJCG);
		}
		else
		{
			NCGCKHGOJCM(HHFPKDCPPBD);
		}
	}

	public void CMBBFEABMBE(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	private bool DCELGJHEANJ(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return true;
		}
		return true;
	}

	private bool PFDHGEBEMFD(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return false;
		}
		return true;
	}

	private void NCIBKMLIIAJ()
	{
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(HIOFAHPKLLE));
	}

	private bool PPANICJCEIA(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return true;
		}
		return true;
	}

	private void PKPHKBMPJGJ()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public void OKEACDGEJIB()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = PBGKEEENPME();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	public void CPMHFMLDDFC(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			NMAOFEFMNNB(null);
		}
		IHFNCOGFJOJ(MEGPBGODLIL.GetComponent<Selectable>());
	}

	[SpecialName]
	public Selectable OFCEDMBCBBH()
	{
		return _selected;
	}

	public static UISelectionManager EAJJMLJKOPH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void KCDBIMPMGON(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			NCGCKHGOJCM(null);
		}
		HCHMAIEMAGA(MEGPBGODLIL.GetComponent<Selectable>());
	}

	private void PHNJGHKBIIL()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void LHFOFAMDKEO()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "ReceiveEnableNPC", AxisContribution.Negative, 879f, 605f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = true;
				BNFLJFFKMMN(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (DCELGJHEANJ(_selected))
			{
				MJPGCPCNOOH(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "talentShelves", AxisContribution.Positive, 80f, 873f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
				MGIFADFILOI(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (DCELGJHEANJ(_selected))
			{
				MJPGCPCNOOH(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "Player", AxisContribution.Positive, 109f, 225f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
				GPCLGOHKMCK(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = true;
			}
			else if (FMIDGIANEMF(_selected))
			{
				KMEJOPAKIJM(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "Ingredient", AxisContribution.Negative, 771f, 492f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				MGIFADFILOI(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (FMIDGIANEMF(_selected))
			{
				KHMDOPOEGCI(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "BarkActor", 365f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum))
				{
					CommonReferences.MNFMOEKMJKN().DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					NCGCKHGOJCM((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					MFCNGGMNBHB((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "Dialogue System/Conversation/Crowly_Introduce/Entry/24/Dialogue Text", 1703f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				NMAOFEFMNNB((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	private void JMDOCHBJGKG()
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		if ((Object)(object)_selected == (Object)null || !PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		if (Utils.AEJGKHNAABC(playerNum, ref IMDFNGAKGKI, "Tray", AxisContribution.Positive, 1196f, 39f))
		{
			if (_selected is UIButtonExtended uIButtonExtended)
			{
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
				MGIFADFILOI(((Selectable)uIButtonExtended).FindSelectableOnUp());
				uIButtonExtended.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PPANICJCEIA(_selected))
			{
				Select(_selected.FindSelectableOnUp(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref JLPOFCJOPJJ, "Collect", AxisContribution.Negative, 1783f, 1984f))
		{
			if (_selected is UIButtonExtended uIButtonExtended2)
			{
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
				PICNNIMLFFL(((Selectable)uIButtonExtended2).FindSelectableOnDown());
				uIButtonExtended2.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PFDHGEBEMFD(_selected))
			{
				FILHNMJHBGI(_selected.FindSelectableOnDown(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref FIHGGDIGIEA, "OnlinePlayer", AxisContribution.Positive, 1751f, 1433f))
		{
			if (_selected is UIButtonExtended uIButtonExtended3)
			{
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
				CMBBFEABMBE(((Selectable)uIButtonExtended3).FindSelectableOnRight());
				uIButtonExtended3.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (PFDHGEBEMFD(_selected))
			{
				CMPEPGEMEDI(_selected.FindSelectableOnRight(), _selected);
			}
		}
		if (Utils.AEJGKHNAABC(playerNum, ref EFNKHHGMPLD, "LE_10", AxisContribution.Positive, 1961f, 1851f))
		{
			if (_selected is UIButtonExtended uIButtonExtended4)
			{
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = true;
				NCGCKHGOJCM(((Selectable)uIButtonExtended4).FindSelectableOnLeft());
				uIButtonExtended4.selectTheSameButtonIfNotFoundNextNav = false;
			}
			else if (DCELGJHEANJ(_selected))
			{
				CGDNLCJDFIG(_selected.FindSelectableOnLeft(), _selected);
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "PLAYERNAME ", 302f))
		{
			if (_selected is UIButtonExtended uIButtonExtended5 && ((Component)_selected).gameObject.activeInHierarchy)
			{
				if (CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(playerNum))
				{
					CommonReferences.GGFJGHHHEJC.DCEJENGEPLN(playerNum, JGJCFHPMKGF: true);
				}
				ExecuteEvents.Execute<ISubmitHandler>(((Component)uIButtonExtended5).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
			}
			else
			{
				Selectable selected = _selected;
				TMP_Dropdown val = (TMP_Dropdown)(object)((selected is TMP_Dropdown) ? selected : null);
				if (val != null)
				{
					DropdownOption.SelectedDropdown = val;
					ExecuteEvents.Execute<ISubmitHandler>(((Component)val).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					CMBBFEABMBE((Selectable)(object)((Component)val).GetComponentInChildren<DropdownOption>());
				}
				else if (_selected is DropdownOption dropdownOption)
				{
					ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdownOption).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
					GPCLGOHKMCK((Selectable)(object)DropdownOption.SelectedDropdown);
					DropdownOption.SelectedDropdown = null;
				}
			}
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref JLNNKHOPINH, "ReceiveInitialPosition", 1892f) && _selected is DropdownOption dropdownOption2)
		{
			ExecuteEvents.Execute<ICancelHandler>(((Component)dropdownOption2).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
			if ((Object)(object)DropdownOption.SelectedDropdown != (Object)null)
			{
				ExecuteEvents.Execute<ICancelHandler>(((Component)DropdownOption.SelectedDropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.cancelHandler);
				HCHMAIEMAGA((Selectable)(object)DropdownOption.SelectedDropdown);
			}
			DropdownOption.SelectedDropdown = null;
		}
	}

	public void CKNJJKJDBGA()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		lastSelection = FOKMCIDMIKF();
		_selected = null;
		if ((Object)(object)lastSelection != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			lastSelection.OnDeselect(new BaseEventData(EventSystem.current));
		}
	}

	public void BNFLJFFKMMN(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	private bool FMIDGIANEMF(Selectable HHFPKDCPPBD)
	{
		if (HHFPKDCPPBD is TMP_Dropdown || HHFPKDCPPBD is TMP_InputField || HHFPKDCPPBD is DropdownOption)
		{
			return true;
		}
		return false;
	}

	public void PICNNIMLFFL(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	public void JJOGJECCPPD(GameObject MEGPBGODLIL)
	{
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			NMAOFEFMNNB(null);
		}
		PICNNIMLFFL(MEGPBGODLIL.GetComponent<Selectable>());
	}

	private void OCJOAHDNDIJ()
	{
		if (playerNum == 0)
		{
			IADEMLIIDPC = this;
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public void GPCLGOHKMCK(Selectable HHFPKDCPPBD)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		NALKHMACHFL = _selected;
		_selected = HHFPKDCPPBD;
		if ((Object)(object)NALKHMACHFL != (Object)null)
		{
			EventSystem.current.SetSelectedGameObject((GameObject)null);
			NALKHMACHFL.OnDeselect(new BaseEventData(EventSystem.current));
		}
		if ((Object)(object)_selected != (Object)null)
		{
			_selected.Select();
		}
	}

	public void KHMDOPOEGCI(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			IHFNCOGFJOJ(MNDCJGAHJCG);
		}
		else
		{
			PICNNIMLFFL(HHFPKDCPPBD);
		}
	}

	public static UISelectionManager GNCPLNHMFHN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void LIEJLJFBDFC(Selectable HHFPKDCPPBD, Selectable MNDCJGAHJCG)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null)
		{
			MFCNGGMNBHB(MNDCJGAHJCG);
		}
		else
		{
			NMAOFEFMNNB(HHFPKDCPPBD);
		}
	}
}
