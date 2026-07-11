using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TutorialManagerBase : MonoBehaviour
{
	public Action<bool> OnTutorialEnabledChanged = delegate
	{
	};

	public Action OnPopUp = delegate
	{
	};

	public Action OnMinimise = delegate
	{
	};

	protected PopUp NNHALHFFIEB;

	protected PopUp NJHCNNPDANG;

	protected List<PopUp> FNCLBNHNOKF = new List<PopUp>();

	[SerializeField]
	protected TextMeshProUGUI tutorialBoxText;

	public RectTransform contentRectTransform;

	[SerializeField]
	protected RectTransform tutorialPanelRectTransform;

	[SerializeField]
	protected RectTransform goalsPanelRectTransform;

	[SerializeField]
	protected GameObject closeButtonRoot;

	[SerializeField]
	protected Button closeButton;

	[SerializeField]
	protected GameObject dimBackground;

	[SerializeField]
	protected GameObject toggleParent;

	[SerializeField]
	protected Button leftArrow;

	[SerializeField]
	protected Button rightArrow;

	[SerializeField]
	protected GameObject minimisedObject;

	[SerializeField]
	protected GameObject buttonObject;

	[SerializeField]
	protected RectTransform panelRectTransform;

	[SerializeField]
	protected TextMeshProUGUI closePopUpText;

	[SerializeField]
	protected GamepadSprite closeGamepadSprite;

	[SerializeField]
	protected bool maximised;

	[SerializeField]
	protected TextImageUI[] goalsTextMeshes;

	public bool minimisePopUpsClosed;

	protected bool KBPGGKMPKHL;

	protected float CMGDCLIIONE;

	protected int CJODOOFLLLB = 1;

	public bool FGFFCFBJJBG => ((Component)tutorialPanelRectTransform).gameObject.activeSelf;

	public bool ECMGCJGPKNO
	{
		get
		{
			if (((Component)tutorialPanelRectTransform).gameObject.activeSelf)
			{
				return GCEHLDLKOIC;
			}
			return false;
		}
	}

	public virtual PopUp EHAEJKGLAHE
	{
		get
		{
			return NNHALHFFIEB;
		}
		set
		{
			NNHALHFFIEB = value;
		}
	}

	public bool GCEHLDLKOIC
	{
		get
		{
			return maximised;
		}
		set
		{
			if (value != maximised)
			{
				maximised = value;
				if (maximised)
				{
					InputModuleBlocker.instance.inputModuleBlockers.Add((Object)(object)this);
				}
				else
				{
					InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
				}
			}
		}
	}

	[SpecialName]
	public virtual void NJEMGFFPCLJ(PopUp AODONKKHPBP)
	{
		NNHALHFFIEB = AODONKKHPBP;
	}

	public virtual void IMEGPDMIFLA()
	{
		if (FNCLBNHNOKF.Count > 1)
		{
			ENNFNPONCMB();
			MKMBMGCKLCL(FNCLBNHNOKF.Last(), MDNOOMBIFNN: true, BLKLCBCGHCN: true);
			HOFBAKJFOGF();
			HFOHHCHDPMM();
		}
		else
		{
			GMKNBGCHEAK();
			DLIEOCLFJFM();
		}
	}

	public void INKEHJBONOA()
	{
		toggleParent.gameObject.SetActive(true);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
		OnTutorialEnabledChanged(obj: false);
	}

	protected virtual void BHAFCBHENPL()
	{
		maximised = true;
		if (Object.op_Implicit((Object)(object)InputModuleBlocker.instance))
		{
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
		}
		((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
	}

	protected virtual void ENNFNPONCMB()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		Sound.GGFJGHHHEJC.UnmuteLoops();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		((Component)closePopUpText).gameObject.SetActive(false);
		minimisePopUpsClosed = false;
		((Transform)contentRectTransform).position = closeButtonRoot.transform.position;
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(false);
		}
		GCEHLDLKOIC = false;
		OnMinimise();
		RepRewardPopUp.GGFJGHHHEJC.updateNextFrame = true;
		QuestTooltipUI.GGFJGHHHEJC.updateNextFrame = true;
	}

	[SpecialName]
	public virtual void EOPGGIMAELC(PopUp AODONKKHPBP)
	{
		NNHALHFFIEB = AODONKKHPBP;
	}

	public void MOAAGKCIOKF()
	{
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(false);
		}
		CPCDIGPNBEC(AODONKKHPBP: true);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
		minimisePopUpsClosed = false;
		RepRewardPopUp.CNDNOECMKME().updateNextFrame = true;
		QuestTooltipUI.AJIGOHGPFPP().updateNextFrame = false;
	}

	protected virtual void GMKNBGCHEAK()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		Sound.DIHCEGINELM().EMPBOBCEGOK();
		PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)this);
		((Component)closePopUpText).gameObject.SetActive(false);
		minimisePopUpsClosed = true;
		((Transform)contentRectTransform).position = closeButtonRoot.transform.position;
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(false);
		}
		GCEHLDLKOIC = true;
		OnMinimise();
		RepRewardPopUp.FMIDAFEGDCD().updateNextFrame = false;
		QuestTooltipUI.MOJDNGDNCCO().updateNextFrame = false;
	}

	public void MFIOMEIBAFM()
	{
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(true);
		}
		CPCDIGPNBEC(AODONKKHPBP: true);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
		minimisePopUpsClosed = true;
		RepRewardPopUp.OFLELHKKNKC().updateNextFrame = true;
		QuestTooltipUI.AJIGOHGPFPP().updateNextFrame = false;
	}

	[SpecialName]
	public bool GLKJKJLNKLC()
	{
		return ((Component)tutorialPanelRectTransform).gameObject.activeSelf;
	}

	[SpecialName]
	public bool ADLMJEBAPAI()
	{
		if (((Component)tutorialPanelRectTransform).gameObject.activeSelf)
		{
			return LLBPLOCOJAG();
		}
		return true;
	}

	public void LNBOHALFPLE()
	{
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			BuildingTutorialManager.instance.CPMBIBKCKOE();
		}
		else if (FarmConstructionManager.IsActived())
		{
			TutorialFarmConstruction.instance.PHIBFDDAOKO();
		}
		else
		{
			ClosePopUpFocused();
		}
	}

	public void KHBAIAGLHGM()
	{
		if (BuildingTutorialManager.PABJKGJJHFG())
		{
			BuildingTutorialManager.instance.NFLAELMJJKK();
		}
		else if (FarmConstructionManager.IsActived())
		{
			TutorialFarmConstruction.instance.JGOFBBMOANJ();
		}
		else
		{
			FKGEBGCBOGO();
		}
	}

	public void OFLPBGMGMCF()
	{
		int num = FNCLBNHNOKF.IndexOf(NNHALHFFIEB);
		if (num > 1)
		{
			MKMBMGCKLCL(FNCLBNHNOKF[num - 0]);
			HOFBAKJFOGF();
			((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(false);
			if (num - 0 == 0)
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
			else
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void IILLPMNEFNI()
	{
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(false);
		}
		CCOGCFPJIDN(AODONKKHPBP: true);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
		minimisePopUpsClosed = false;
		RepRewardPopUp.MPFJOKOJIOO().updateNextFrame = true;
		QuestTooltipUI.DEGPIHEEFHJ().updateNextFrame = true;
	}

	public void ClosePopUp()
	{
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(false);
		}
		GCEHLDLKOIC = false;
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
		minimisePopUpsClosed = true;
		RepRewardPopUp.GGFJGHHHEJC.updateNextFrame = true;
		QuestTooltipUI.GGFJGHHHEJC.updateNextFrame = true;
	}

	[SpecialName]
	public virtual void LHPHLLFABDC(PopUp AODONKKHPBP)
	{
		NNHALHFFIEB = AODONKKHPBP;
	}

	public void ClosePopUpAcceptButton()
	{
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			BuildingTutorialManager.instance.ClosePopUpFocused();
		}
		else if (FarmConstructionManager.IsActived())
		{
			TutorialFarmConstruction.instance.ClosePopUpFarmTutorial();
		}
		else
		{
			ClosePopUpFocused();
		}
	}

	public void HFOHHCHDPMM()
	{
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(true);
		}
		CPCDIGPNBEC(AODONKKHPBP: false);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
		minimisePopUpsClosed = true;
		RepRewardPopUp.LDBJELPPBAI().updateNextFrame = false;
		QuestTooltipUI.DEGPIHEEFHJ().updateNextFrame = true;
	}

	[SpecialName]
	public virtual PopUp DDJGDONPNOB()
	{
		return NNHALHFFIEB;
	}

	[SpecialName]
	public bool NJJLHDHDAIM()
	{
		if (((Component)tutorialPanelRectTransform).gameObject.activeSelf)
		{
			return JCGLIEOIHCP();
		}
		return false;
	}

	public virtual void NFLAELMJJKK()
	{
		if (FNCLBNHNOKF.Count > 1)
		{
			ENNFNPONCMB();
			MKMBMGCKLCL(FNCLBNHNOKF.Last(), MDNOOMBIFNN: false);
			HDGODFPOBAI();
		}
		else
		{
			HDGODFPOBAI();
			IILLPMNEFNI();
		}
	}

	public virtual void FKGEBGCBOGO()
	{
		if (FNCLBNHNOKF.Count > 0)
		{
			HDGODFPOBAI();
			OJGDDKDLKFM(FNCLBNHNOKF.Last(), MDNOOMBIFNN: false, BLKLCBCGHCN: true);
			GMKNBGCHEAK();
		}
		else
		{
			GMKNBGCHEAK();
			ClosePopUp();
		}
	}

	protected virtual void OMBHDODDHNO()
	{
		maximised = false;
		if (Object.op_Implicit((Object)(object)InputModuleBlocker.instance))
		{
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
		}
		((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
	}

	protected virtual void OAEJGGFFCBO()
	{
		maximised = true;
		if (Object.op_Implicit((Object)(object)InputModuleBlocker.instance))
		{
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
		}
		((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
	}

	public int GetCurrentPlayer()
	{
		if (CJODOOFLLLB == 2 && GameManager.LocalCoop())
		{
			return 2;
		}
		return 1;
	}

	protected virtual void HOFBAKJFOGF()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		Sound.DIHCEGINELM().EMPBOBCEGOK();
		PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)this);
		((Component)closePopUpText).gameObject.SetActive(false);
		minimisePopUpsClosed = false;
		((Transform)contentRectTransform).position = closeButtonRoot.transform.position;
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(false);
		}
		GCEHLDLKOIC = false;
		OnMinimise();
		RepRewardPopUp.MOJDNGDNCCO().updateNextFrame = false;
		QuestTooltipUI.NGIMIHFFNMH().updateNextFrame = false;
	}

	public virtual void GGHMMAOGOFH(PopUp FKHFBMFJKDM, bool MDNOOMBIFNN = true, bool BLKLCBCGHCN = false)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		if (CommonReferences.MNFMOEKMJKN().IsInDialogue(0) || !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) || BLKLCBCGHCN)
		{
			PlayerInputs.DLKKNGHEMPB((MonoBehaviour)(object)this, JONJPDAEHFB: false);
			CCOGCFPJIDN(AODONKKHPBP: false);
			if ((Object)(object)dimBackground != (Object)null)
			{
				dimBackground.SetActive(true);
			}
			minimisedObject.SetActive(false);
			buttonObject.SetActive(true);
			((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(170f, 1432f));
			KBPGGKMPKHL = true;
			((Component)closePopUpText).gameObject.SetActive(true);
			panelRectTransform.ForceUpdateRectTransforms();
			Sound.MAIDHAPANEB().AFILAFJFGMI();
			((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(false);
			if (FNCLBNHNOKF.Count > 0)
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(false);
			}
			else
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
			((UnityEventBase)leftArrow.onClick).RemoveAllListeners();
			((UnityEventBase)rightArrow.onClick).RemoveAllListeners();
			((UnityEvent)leftArrow.onClick).AddListener(new UnityAction(ScrollLeft));
			((UnityEvent)rightArrow.onClick).AddListener(new UnityAction(ScrollRight));
			OnPopUp();
		}
	}

	[SpecialName]
	public bool PMGEOLNMJGB()
	{
		if (((Component)tutorialPanelRectTransform).gameObject.activeSelf)
		{
			return LLBPLOCOJAG();
		}
		return false;
	}

	[SpecialName]
	public bool GHEFOKLIDMM()
	{
		return ((Component)tutorialPanelRectTransform).gameObject.activeSelf;
	}

	public void DLIEOCLFJFM()
	{
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(true);
		}
		CCOGCFPJIDN(AODONKKHPBP: false);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
		minimisePopUpsClosed = true;
		RepRewardPopUp.JFNOOMJMHCB().updateNextFrame = true;
		QuestTooltipUI.NGIMIHFFNMH().updateNextFrame = true;
	}

	public int NGKKADCBLNI()
	{
		if (CJODOOFLLLB == 7 && GameManager.LocalCoop())
		{
			return 0;
		}
		return 1;
	}

	public void OGKBLHPAFKM()
	{
		toggleParent.gameObject.SetActive(false);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
		OnTutorialEnabledChanged(obj: true);
	}

	[SpecialName]
	public void CCOGCFPJIDN(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != maximised)
		{
			maximised = AODONKKHPBP;
			if (maximised)
			{
				InputModuleBlocker.instance.inputModuleBlockers.Add((Object)(object)this);
			}
			else
			{
				InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
			}
		}
	}

	public virtual void CPMBIBKCKOE()
	{
		if (FNCLBNHNOKF.Count > 0)
		{
			GMKNBGCHEAK();
			ShowPopUp(FNCLBNHNOKF.Last(), MDNOOMBIFNN: false, BLKLCBCGHCN: true);
			GMKNBGCHEAK();
		}
		else
		{
			ENNFNPONCMB();
			ClosePopUp();
		}
	}

	public virtual void OJGDDKDLKFM(PopUp FKHFBMFJKDM, bool MDNOOMBIFNN = true, bool BLKLCBCGHCN = false)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		if ((!CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(1) && CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(7)) || BLKLCBCGHCN)
		{
			PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this, JONJPDAEHFB: false);
			CCOGCFPJIDN(AODONKKHPBP: true);
			if ((Object)(object)dimBackground != (Object)null)
			{
				dimBackground.SetActive(true);
			}
			minimisedObject.SetActive(true);
			buttonObject.SetActive(true);
			((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1187f, 242f));
			KBPGGKMPKHL = false;
			((Component)closePopUpText).gameObject.SetActive(true);
			panelRectTransform.ForceUpdateRectTransforms();
			Sound.BNBMNOMFFBE().OCGHFDOMDAP();
			((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(true);
			if (FNCLBNHNOKF.Count > 0)
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
			else
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
			((UnityEventBase)leftArrow.onClick).RemoveAllListeners();
			((UnityEventBase)rightArrow.onClick).RemoveAllListeners();
			((UnityEvent)leftArrow.onClick).AddListener(new UnityAction(OFLPBGMGMCF));
			((UnityEvent)rightArrow.onClick).AddListener(new UnityAction(ScrollRight));
			OnPopUp();
		}
	}

	[SpecialName]
	public bool JCGLIEOIHCP()
	{
		return maximised;
	}

	[SpecialName]
	public virtual void BOKBNODICON(PopUp AODONKKHPBP)
	{
		NNHALHFFIEB = AODONKKHPBP;
	}

	protected virtual void OGEJKOIOKAN()
	{
		maximised = false;
		if (Object.op_Implicit((Object)(object)InputModuleBlocker.instance))
		{
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
		}
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
	}

	public void ScrollLeft()
	{
		int num = FNCLBNHNOKF.IndexOf(NNHALHFFIEB);
		if (num > 0)
		{
			ShowPopUp(FNCLBNHNOKF[num - 1]);
			ENNFNPONCMB();
			((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(true);
			if (num - 1 == 0)
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(false);
			}
			else
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	[SpecialName]
	public virtual PopUp CGKJNOAFIOC()
	{
		return NNHALHFFIEB;
	}

	public virtual void AEBKHLILFNJ(PopUp FKHFBMFJKDM, bool MDNOOMBIFNN = true, bool BLKLCBCGHCN = false)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		if ((!CommonReferences.GGFJGHHHEJC.IsInDialogue(0) && CommonReferences.MNFMOEKMJKN().IsInDialogue(0)) || BLKLCBCGHCN)
		{
			PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
			CCOGCFPJIDN(AODONKKHPBP: false);
			if ((Object)(object)dimBackground != (Object)null)
			{
				dimBackground.SetActive(true);
			}
			minimisedObject.SetActive(false);
			buttonObject.SetActive(true);
			((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1019f, 1399f));
			KBPGGKMPKHL = true;
			((Component)closePopUpText).gameObject.SetActive(true);
			panelRectTransform.ForceUpdateRectTransforms();
			Sound.DIHCEGINELM().ALBEOGBKEPJ();
			((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(true);
			if (FNCLBNHNOKF.Count > 0)
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(false);
			}
			else
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
			((UnityEventBase)leftArrow.onClick).RemoveAllListeners();
			((UnityEventBase)rightArrow.onClick).RemoveAllListeners();
			((UnityEvent)leftArrow.onClick).AddListener(new UnityAction(OFLPBGMGMCF));
			((UnityEvent)rightArrow.onClick).AddListener(new UnityAction(ScrollRight));
			OnPopUp();
		}
	}

	[SpecialName]
	public virtual PopUp NDBGOJLEFAC()
	{
		return NNHALHFFIEB;
	}

	[SpecialName]
	public virtual void LMELDMNIPNH(PopUp AODONKKHPBP)
	{
		NNHALHFFIEB = AODONKKHPBP;
	}

	public virtual void PBJHKPLOIIO()
	{
		if (FNCLBNHNOKF.Count > 0)
		{
			HDGODFPOBAI();
			ShowPopUp(FNCLBNHNOKF.Last(), MDNOOMBIFNN: false, BLKLCBCGHCN: true);
			ENNFNPONCMB();
			DLIEOCLFJFM();
		}
		else
		{
			HDGODFPOBAI();
			HFOHHCHDPMM();
		}
	}

	public void DisableTutorial()
	{
		toggleParent.gameObject.SetActive(false);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
		OnTutorialEnabledChanged(obj: false);
	}

	public void GOHHLFCAMEG()
	{
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			BuildingTutorialManager.instance.FKGEBGCBOGO();
		}
		else if (FarmConstructionManager.IsActived())
		{
			TutorialFarmConstruction.instance.JGOFBBMOANJ();
		}
		else
		{
			ClosePopUpFocused();
		}
	}

	[SpecialName]
	public bool LLBPLOCOJAG()
	{
		return maximised;
	}

	public virtual void MKMBMGCKLCL(PopUp FKHFBMFJKDM, bool MDNOOMBIFNN = true, bool BLKLCBCGHCN = false)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		if (CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(1) || CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(7) || BLKLCBCGHCN)
		{
			PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
			GCEHLDLKOIC = false;
			if ((Object)(object)dimBackground != (Object)null)
			{
				dimBackground.SetActive(false);
			}
			minimisedObject.SetActive(true);
			buttonObject.SetActive(false);
			((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(502f, 655f));
			KBPGGKMPKHL = false;
			((Component)closePopUpText).gameObject.SetActive(true);
			panelRectTransform.ForceUpdateRectTransforms();
			Sound.DIHCEGINELM().GHDPAKLGKGI();
			((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(true);
			if (FNCLBNHNOKF.Count > 1)
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(false);
			}
			else
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
			((UnityEventBase)leftArrow.onClick).RemoveAllListeners();
			((UnityEventBase)rightArrow.onClick).RemoveAllListeners();
			((UnityEvent)leftArrow.onClick).AddListener(new UnityAction(OFLPBGMGMCF));
			((UnityEvent)rightArrow.onClick).AddListener(new UnityAction(ScrollRight));
			OnPopUp();
		}
	}

	public void ICGIHNALIIL()
	{
		toggleParent.gameObject.SetActive(false);
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
		OnTutorialEnabledChanged(obj: false);
	}

	public virtual void ClosePopUpFocused()
	{
		if (FNCLBNHNOKF.Count > 0)
		{
			ENNFNPONCMB();
			ShowPopUp(FNCLBNHNOKF.Last());
			ENNFNPONCMB();
		}
		else
		{
			ENNFNPONCMB();
			ClosePopUp();
		}
	}

	[SpecialName]
	public virtual PopUp OIHHBLABAPO()
	{
		return NNHALHFFIEB;
	}

	protected virtual void Awake()
	{
		maximised = false;
		if (Object.op_Implicit((Object)(object)InputModuleBlocker.instance))
		{
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
		}
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
	}

	[SpecialName]
	public void MHODLMAGHFI(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != maximised)
		{
			maximised = AODONKKHPBP;
			if (maximised)
			{
				InputModuleBlocker.instance.inputModuleBlockers.Add((Object)(object)this);
			}
			else
			{
				InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
			}
		}
	}

	public virtual void AMPAGFNEAHB()
	{
		if (FNCLBNHNOKF.Count > 1)
		{
			HOFBAKJFOGF();
			AEBKHLILFNJ(FNCLBNHNOKF.Last(), MDNOOMBIFNN: true, BLKLCBCGHCN: true);
			GMKNBGCHEAK();
			MFIOMEIBAFM();
		}
		else
		{
			GMKNBGCHEAK();
			MFIOMEIBAFM();
		}
	}

	protected virtual void OKHLEMPJONN()
	{
		maximised = true;
		if (Object.op_Implicit((Object)(object)InputModuleBlocker.instance))
		{
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
		}
		((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
	}

	protected virtual void HDGODFPOBAI()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		Sound.DIHCEGINELM().NNGCIMHKMFF();
		PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)this);
		((Component)closePopUpText).gameObject.SetActive(true);
		minimisePopUpsClosed = true;
		((Transform)contentRectTransform).position = closeButtonRoot.transform.position;
		if ((Object)(object)dimBackground != (Object)null)
		{
			dimBackground.SetActive(true);
		}
		GCEHLDLKOIC = false;
		OnMinimise();
		RepRewardPopUp.MAIDHAPANEB().updateNextFrame = true;
		QuestTooltipUI.AJIGOHGPFPP().updateNextFrame = true;
	}

	public int IBOEALLMIOK()
	{
		if (CJODOOFLLLB == 1 && GameManager.LocalCoop())
		{
			return 6;
		}
		return 1;
	}

	public int CGKBPHPJICO()
	{
		if (CJODOOFLLLB == 2 && GameManager.LocalCoop())
		{
			return 0;
		}
		return 1;
	}

	public virtual void ShowPopUp(PopUp FKHFBMFJKDM, bool MDNOOMBIFNN = true, bool BLKLCBCGHCN = false)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		if ((!CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && !CommonReferences.GGFJGHHHEJC.IsInDialogue(2)) || BLKLCBCGHCN)
		{
			PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
			GCEHLDLKOIC = true;
			if ((Object)(object)dimBackground != (Object)null)
			{
				dimBackground.SetActive(true);
			}
			minimisedObject.SetActive(false);
			buttonObject.SetActive(false);
			((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(-1000f, -1000f));
			KBPGGKMPKHL = true;
			((Component)closePopUpText).gameObject.SetActive(true);
			panelRectTransform.ForceUpdateRectTransforms();
			Sound.GGFJGHHHEJC.MuteLoops();
			((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(false);
			if (FNCLBNHNOKF.Count > 1)
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			}
			else
			{
				((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(false);
			}
			((UnityEventBase)leftArrow.onClick).RemoveAllListeners();
			((UnityEventBase)rightArrow.onClick).RemoveAllListeners();
			((UnityEvent)leftArrow.onClick).AddListener(new UnityAction(ScrollLeft));
			((UnityEvent)rightArrow.onClick).AddListener(new UnityAction(ScrollRight));
			OnPopUp();
		}
	}

	[SpecialName]
	public bool FJIEPAIMELO()
	{
		if (((Component)tutorialPanelRectTransform).gameObject.activeSelf)
		{
			return LLBPLOCOJAG();
		}
		return false;
	}

	public void ScrollRight()
	{
		int num = FNCLBNHNOKF.IndexOf(NNHALHFFIEB);
		if (num < FNCLBNHNOKF.Count - 1)
		{
			ShowPopUp(FNCLBNHNOKF[num + 1]);
			ENNFNPONCMB();
			((Component)((Component)leftArrow).transform.parent).gameObject.SetActive(true);
			if (num + 2 == FNCLBNHNOKF.Count)
			{
				((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(false);
			}
			else
			{
				((Component)((Component)rightArrow).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	[SpecialName]
	public virtual PopUp HIMDPOCOGGB()
	{
		return NNHALHFFIEB;
	}

	public virtual void ClosePopUpButton()
	{
		if (FNCLBNHNOKF.Count > 0)
		{
			ENNFNPONCMB();
			ShowPopUp(FNCLBNHNOKF.Last());
			ENNFNPONCMB();
			ClosePopUp();
		}
		else
		{
			ENNFNPONCMB();
			ClosePopUp();
		}
	}

	[SpecialName]
	public void CPCDIGPNBEC(bool AODONKKHPBP)
	{
		if (AODONKKHPBP != maximised)
		{
			maximised = AODONKKHPBP;
			if (maximised)
			{
				InputModuleBlocker.instance.inputModuleBlockers.Add((Object)(object)this);
			}
			else
			{
				InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
			}
		}
	}

	[SpecialName]
	public virtual PopUp CEDINKPJDCP()
	{
		return NNHALHFFIEB;
	}
}
