using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class KeybindElementControllerUI : KeybindElementUI, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class BCNDHHCMHJP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeybindElementControllerUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public BCNDHHCMHJP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			KeybindElementControllerUI keybindElementControllerUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				keybindElementControllerUI.HFMPKOMCEGB();
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public ControllerType controllerType;

	public Transform selected;

	public Transform selected2;

	public void ADFKFIJBGJA(PointerEventData NPBAMEMNFBI)
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			HOEAILPKEHC();
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)GameplayUI.GGFJGHHHEJC != (Object)null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(GDLHIHJEHKK());
		}
	}

	public void JDPKILNFDLK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		if ((int)controllerType == 0)
		{
			MainUI.NEFOKCKKLNI().Open(playerNum);
			TextMeshProUGUI boxText = MainUI.NEFOKCKKLNI().boxText;
			object text;
			if (!string.IsNullOrEmpty(LocalisationSystem.Get("IntroNinjaChallengeEvent/Main")))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("forceintro");
				string[] array = new string[0];
				array[0] = LocalisationSystem.Get(actionElementMap.actionDescriptiveName);
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = "Items/item_description_1046";
			}
			((TMP_Text)boxText).text = (string)text;
			MainUI.NEFOKCKKLNI().HHKBMJIHLGE(new UnityAction(CFELMHIMIHC));
			MainUI.LBHLPIFCINB().PIMAAKODIGC(new UnityAction(NIJCIPCMIOH));
		}
		else
		{
			CFELMHIMIHC();
		}
	}

	private IEnumerator IEDKDBDDCHO()
	{
		yield return null;
		HFMPKOMCEGB();
	}

	private void LFBIFPBPDMJ()
	{
		playerNum = OptionsMenuUI.DEGPIHEEFHJ().JIIGOACEIKL;
	}

	public void JIEKLDEHFMA(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			HBAKHENONJE();
		}
	}

	private void HBIGFFAHNID()
	{
		KeybindUI.MLPCDJPLBAC().updateNextFrame = true;
		KeybindUI.ABHIDHPMLLD().BEHHBDLMICD(this);
	}

	public void KNBMNFANBHA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if ((int)controllerType == 0 && !PlayerInputs.IsGamepadActive(playerNum))
		{
			FKCOELIMFAA();
		}
		else if ((int)controllerType == 5 && PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			JDPKILNFDLK();
		}
	}

	public void ButtonClicked()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if ((int)controllerType == 0 && !PlayerInputs.IsGamepadActive(playerNum))
		{
			ButtonClickedAction();
		}
		else if ((int)controllerType == 2 && PlayerInputs.IsGamepadActive(playerNum))
		{
			ButtonClickedAction();
		}
	}

	private IEnumerator DIJODDJNNFA()
	{
		return new BCNDHHCMHJP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HBAKHENONJE()
	{
		selected.SetParent(((Component)this).transform);
		((Component)selected).gameObject.SetActive(false);
		selected2.SetParent(((Component)this).transform);
		((Component)selected2).gameObject.SetActive(true);
	}

	private void CAHFNIKEMOD()
	{
		selected.SetParent(((Component)this).transform);
		((Component)selected).gameObject.SetActive(false);
		selected2.SetParent(((Component)this).transform);
		((Component)selected2).gameObject.SetActive(false);
	}

	private IEnumerator JAOOLIFPAPN()
	{
		yield return null;
		HFMPKOMCEGB();
	}

	public void DFMHKIHCDBJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if ((int)controllerType == 0 && !PlayerInputs.ODGALPDEIFG(playerNum))
		{
			JDPKILNFDLK();
		}
		else if ((int)controllerType == 1 && PlayerInputs.POLDHCKJINN(playerNum))
		{
			ButtonClickedAction();
		}
	}

	private void AGJILHINHFF()
	{
		selected.SetParent(((Component)this).transform);
		((Component)selected).gameObject.SetActive(false);
		selected2.SetParent(((Component)this).transform);
		((Component)selected2).gameObject.SetActive(true);
	}

	public void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			ICGFHLFCEEL();
		}
	}

	private IEnumerator PLNOCMHCBGE()
	{
		return new BCNDHHCMHJP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LIDNCNJDJID()
	{
		KeybindUI.DICHPHEOINO().updateNextFrame = false;
		KeybindUI.BIIOFAHFNPA().AJKGFHECHFN(this);
	}

	private IEnumerator GDLHIHJEHKK()
	{
		yield return null;
		HFMPKOMCEGB();
	}

	private void DDIBFALLCNO()
	{
		if ((Object)(object)GameplayUI.NGIMIHFFNMH() != (Object)null)
		{
			((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StartCoroutine(MHEGPFIPNGE());
		}
	}

	private void HFMPKOMCEGB()
	{
		selected.SetParent(((Component)this).transform);
		((Component)selected).gameObject.SetActive(false);
		selected2.SetParent(((Component)this).transform);
		((Component)selected2).gameObject.SetActive(false);
	}

	public void IKBEDHHFAGB(PointerEventData NPBAMEMNFBI)
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			HBAKHENONJE();
		}
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			HFMPKOMCEGB();
		}
	}

	public void ButtonClickedAction()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		if ((int)controllerType == 2)
		{
			MainUI.GetYesNoDialogue().Open(playerNum);
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = (string.IsNullOrEmpty(LocalisationSystem.Get("startPolling")) ? "Do you want to change input?" : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("startPolling"), LocalisationSystem.Get(actionElementMap.actionDescriptiveName)));
			MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(JGDCAIPJGBI));
			MainUI.GetYesNoDialogue().AddNoAction(new UnityAction(NIJCIPCMIOH));
		}
		else
		{
			JGDCAIPJGBI();
		}
	}

	private void CFELMHIMIHC()
	{
		KeybindUI.GGFJGHHHEJC.updateNextFrame = true;
		KeybindUI.DICHPHEOINO().EIKNKDAFOFL(this);
	}

	public void DPDADDGNBMB(PointerEventData NPBAMEMNFBI)
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			HOEAILPKEHC();
		}
	}

	public void GLJPIMOLHKJ(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(playerNum))
		{
			HFMPKOMCEGB();
		}
	}

	private IEnumerator GIJOGGEHADE()
	{
		yield return null;
		HFMPKOMCEGB();
	}

	public void FKCOELIMFAA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		if ((int)controllerType == 6)
		{
			MainUI.GetYesNoDialogue().OFGKFMJKBON(playerNum);
			TextMeshProUGUI boxText = MainUI.GetYesNoDialogue().boxText;
			object text;
			if (!string.IsNullOrEmpty(LocalisationSystem.Get("ReceiveAnimalSlotFromContainer")))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(" ");
				string[] array = new string[0];
				array[1] = LocalisationSystem.Get(actionElementMap.actionDescriptiveName);
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = " will be destroyed in ";
			}
			((TMP_Text)boxText).text = (string)text;
			MainUI.MCPEEGPBPLH().AHJEBGMFOCK(new UnityAction(JGDCAIPJGBI));
			MainUI.LBHLPIFCINB().GOPMAHGLGBD(new UnityAction(NIJCIPCMIOH));
		}
		else
		{
			CFELMHIMIHC();
		}
	}

	public void BDDIHGDAPEH(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.ODGALPDEIFG(playerNum))
		{
			HOEAILPKEHC();
		}
	}

	private void JGDCAIPJGBI()
	{
		KeybindUI.GGFJGHHHEJC.updateNextFrame = true;
		KeybindUI.GGFJGHHHEJC.IIGILKKIPAM = this;
	}

	private void NIJCIPCMIOH()
	{
		KeybindUI.GGFJGHHHEJC.updateNextFrame = true;
		IFELHIDGLIA((Selectable)(object)button);
	}

	private void OnEnable()
	{
		playerNum = OptionsMenuUI.GGFJGHHHEJC.JIIGOACEIKL;
	}

	public void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(playerNum))
		{
			HFMPKOMCEGB();
		}
	}

	public void LKDDEOAKINH(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			ICGFHLFCEEL();
		}
	}

	public void GDJHCGLBFAM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if ((int)controllerType == 0 && !PlayerInputs.IsGamepadActive(playerNum))
		{
			NNMPMMHOPBE();
		}
		else if ((int)controllerType == 8 && PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			NNMPMMHOPBE();
		}
	}

	public void KHKBMIAMNCD(PointerEventData NPBAMEMNFBI)
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			ICGFHLFCEEL();
		}
	}

	private void HOEAILPKEHC()
	{
		if (playerNum == 1)
		{
			selected.SetParent(((Component)this).transform.parent);
			selected.SetSiblingIndex(selected.parent.childCount - 1);
		}
		else
		{
			selected2.SetParent(((Component)this).transform.parent);
			selected2.SetSiblingIndex(selected2.parent.childCount - 1);
		}
	}

	private IEnumerator JOOKIGOPGOM()
	{
		yield return null;
		HFMPKOMCEGB();
	}

	private void IAJOHONMIBM()
	{
		playerNum = OptionsMenuUI.EFPJLFMBPLL().JIIGOACEIKL;
	}

	private IEnumerator MHEGPFIPNGE()
	{
		yield return null;
		HFMPKOMCEGB();
	}

	public void HBPIBPJPGIG(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			HOEAILPKEHC();
		}
	}

	private void ICGFHLFCEEL()
	{
		if (playerNum == 1)
		{
			selected.SetParent(((Component)this).transform.parent);
			selected.SetSiblingIndex(selected.parent.childCount - 1);
		}
		else
		{
			selected2.SetParent(((Component)this).transform.parent);
			selected2.SetSiblingIndex(selected2.parent.childCount - 1);
		}
	}

	public void FBAIHBIJGEM(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			HOEAILPKEHC();
		}
	}

	private void IFPAKNFPCIP()
	{
		selected.SetParent(((Component)this).transform);
		((Component)selected).gameObject.SetActive(true);
		selected2.SetParent(((Component)this).transform);
		((Component)selected2).gameObject.SetActive(false);
	}

	public void GGDKELNDIAG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		if ((int)controllerType == 5)
		{
			MainUI.LBHLPIFCINB().OFGKFMJKBON(playerNum);
			TextMeshProUGUI boxText = MainUI.MCPEEGPBPLH().boxText;
			object text;
			if (!string.IsNullOrEmpty(LocalisationSystem.Get("Error_UnableToBeReached")))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("[OnlineMineManager] ReceiveGenerateMineLevel: Client doesnt have scene loaded. Level={0} Seed={1}");
				string[] array = new string[0];
				array[0] = LocalisationSystem.Get(actionElementMap.actionDescriptiveName);
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = "ActionBar3";
			}
			((TMP_Text)boxText).text = (string)text;
			MainUI.MCPEEGPBPLH().AJPFLHOODLO(new UnityAction(LIDNCNJDJID));
			MainUI.LBHLPIFCINB().DBECNNACNOB(new UnityAction(NIJCIPCMIOH));
		}
		else
		{
			LIDNCNJDJID();
		}
	}

	public override void PollKey()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		base.PollKey();
		if ((int)controllerType == 2)
		{
			ControllerPollingInfo oOAILMIOFBA = PlayerInputs.GetPlayerControllers(playerNum).GetLastActiveController((ControllerType)2).PollForFirstElementDown();
			MMOHOJGCKEE(oOAILMIOFBA);
		}
		else if (!PlayerInputs.GetPlayer(playerNum).GetButtonDown("UIBack"))
		{
			MMOHOJGCKEE(PlayerInputs.GetPlayerControllers(playerNum).Keyboard.PollForFirstKeyDown());
		}
	}

	public void NNMPMMHOPBE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		if ((int)controllerType == 7)
		{
			MainUI.MCPEEGPBPLH().Open(playerNum);
			TextMeshProUGUI boxText = MainUI.GetYesNoDialogue().boxText;
			object text;
			if (!string.IsNullOrEmpty(LocalisationSystem.Get(" doesn't exist.")))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("BeginChatFade");
				string[] array = new string[0];
				array[1] = LocalisationSystem.Get(actionElementMap.actionDescriptiveName);
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = "Avatar";
			}
			((TMP_Text)boxText).text = (string)text;
			MainUI.NEFOKCKKLNI().HMMOMJBMPML(new UnityAction(JGDCAIPJGBI));
			MainUI.MCPEEGPBPLH().DBECNNACNOB(new UnityAction(NIJCIPCMIOH));
		}
		else
		{
			JGDCAIPJGBI();
		}
	}

	public override void UpdateInfo(ActionElementMap KBMOOCGHDKH, int BKFCHPEAJEI)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		base.UpdateInfo(KBMOOCGHDKH, BKFCHPEAJEI);
		playerNum = PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL;
		if ((int)controllerType == 2)
		{
			((TMP_Text)keyBindText).text = ButtonsContext.GetPlayer(playerNum).GetSpriteTagWithElementName(KBMOOCGHDKH.elementIdentifierName, PlayerInputs.GetPlayerControllers(playerNum).GetLastActiveController((ControllerType)2));
			((Selectable)button).interactable = true;
			return;
		}
		if (KBMOOCGHDKH.elementIdentifierName == null || KBMOOCGHDKH.elementIdentifierName.Equals("None"))
		{
			((TMP_Text)keyBindText).text = "";
			return;
		}
		if (KBMOOCGHDKH.elementIdentifierName == "Back Quote")
		{
			((TMP_Text)keyBindText).text = "`";
		}
		else
		{
			((TMP_Text)keyBindText).text = LocalisationSystem.Get(KBMOOCGHDKH.elementIdentifierName);
			if (string.IsNullOrEmpty(((TMP_Text)keyBindText).text))
			{
				((TMP_Text)keyBindText).text = KBMOOCGHDKH.elementIdentifierName;
			}
		}
		if (ReInput.mapping.GetMapCategoryId("Key2") == KBMOOCGHDKH.controllerMap.categoryId)
		{
			ActionElementMap elementIdentifierIdInMapCategory = KeybindUI.GetElementIdentifierIdInMapCategory(playerNum, "Default", KBMOOCGHDKH.actionId, KBMOOCGHDKH.actionDescriptiveName);
			if (elementIdentifierIdInMapCategory != null && elementIdentifierIdInMapCategory.elementIdentifierId == KBMOOCGHDKH.elementIdentifierId)
			{
				((TMP_Text)keyBindText).text = "";
			}
		}
	}

	private void GKCKLIAANHA()
	{
		playerNum = OptionsMenuUI.GGFJGHHHEJC.JIIGOACEIKL;
	}

	private IEnumerator DLBIKENFGHB()
	{
		return new BCNDHHCMHJP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			ICGFHLFCEEL();
		}
	}

	private IEnumerator CDGNDOEIBHF()
	{
		yield return null;
		HFMPKOMCEGB();
	}
}
