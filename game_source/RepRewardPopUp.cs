using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class RepRewardPopUp : UIWindow
{
	private static RepRewardPopUp IADEMLIIDPC;

	[SerializeField]
	private TextMeshProUGUI repTitleText;

	[SerializeField]
	private TextMeshProUGUI repDescriptionText;

	public List<ReputationInfo> awaitingCompleteList;

	private ReputationInfo NHAHLKCCDED;

	[SerializeField]
	private GamepadSprite closeGamepadSprite;

	[HideInInspector]
	public bool updateNextFrame = true;

	public static RepRewardPopUp GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
			}
			return IADEMLIIDPC;
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		Utils.JEAHJILAIAP(0f);
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
	}

	public void ONLDHHGPFFA()
	{
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).updateNextFrame = false;
		BOBCIFEDJED();
	}

	private void KBPMAFGHENF(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.FJEHCJEFBED();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.PHODHOADOCG();
	}

	[SpecialName]
	public static RepRewardPopUp ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static RepRewardPopUp DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	public void OLMDHEFMIBI()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = true;
		BOBCIFEDJED();
	}

	private void DMCHMIAJPIL(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.NGIGAGAOPLK();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.AEDCKIPGHBG();
	}

	[SpecialName]
	public static RepRewardPopUp LDBJELPPBAI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	private void JOBPBLBLNKB(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.PLMCFBOCOKO();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.BNIKGJFDLOF();
	}

	[SpecialName]
	public static RepRewardPopUp JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	public void AGGCOJKJNFK()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = false;
		BOBCIFEDJED();
	}

	private void AHGKPCDIMFA(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.CABGJDFOOFO();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.BNIKGJFDLOF();
	}

	[SpecialName]
	public static RepRewardPopUp KNOKBLFFNLM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	private void JJAENEOCCAJ(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.DIBBECHDFNP();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.COHFIGGNKNB();
	}

	private void BBCHLKCICGF(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.MMANMBJBFKD();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.DPHEIKDACID();
	}

	private void PNPCLIGJLGG(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.PLMCFBOCOKO();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.AEDCKIPGHBG();
	}

	private void OHPLIAOLJII(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.FEKDBOIJGDL();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.JDEDLPOJLOG();
	}

	private void PJPKNIBAJKB(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.DLEDNLMPIPM();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.NHGNHGDAAKK();
	}

	[SpecialName]
	public static RepRewardPopUp HNNJEBNIPOI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static RepRewardPopUp MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static RepRewardPopUp FOPGLLMEEDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static RepRewardPopUp KHMEGDIABBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static RepRewardPopUp NEFIEJALANL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	public void BMCFPPOHIAL()
	{
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).updateNextFrame = true;
		CloseUI();
	}

	private void DDNBEKJLAPH(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.OJEFDEFPFOG();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.IGDKFHCHEAJ();
	}

	public void AMCPCFKHNKC()
	{
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).updateNextFrame = true;
		BOBCIFEDJED();
	}

	[SpecialName]
	public static RepRewardPopUp CNDNOECMKME()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	private void DBFKBPHEJBC(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.OJEFDEFPFOG();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.IGDKFHCHEAJ();
	}

	[SpecialName]
	public static RepRewardPopUp OFLELHKKNKC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static RepRewardPopUp LADDMEMMJFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
			awaitingCompleteList = new List<ReputationInfo>();
		}
	}

	public void FPJKDEOJCHP()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = true;
		CloseUI();
	}

	private void KDPJMBEIIAM(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.DLEDNLMPIPM();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.MDDOEMHDNGD();
	}

	[SpecialName]
	public static RepRewardPopUp EFPJLFMBPLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			Sound.GGFJGHHHEJC.MuteLoops();
		}
	}

	private void NPNCBAFDOIN(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.DLEDNLMPIPM();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.LDOJKNPINLA();
	}

	[SpecialName]
	public static RepRewardPopUp MLPCDJPLBAC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	protected override void Update()
	{
		base.Update();
		if (updateNextFrame)
		{
			updateNextFrame = false;
		}
		else if (IsOpen() && !TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO)
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown(closeGamepadSprite.GetActionType()))
				{
					AcceptButtonClicked();
				}
			}
			else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
			{
				AcceptButtonClicked();
			}
		}
		else if (!QuestTooltipUI.GGFJGHHHEJC.IsOpen() && !CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && !CommonReferences.GGFJGHHHEJC.IsInDialogue(2) && awaitingCompleteList.Count() > 0 && (!GameManager.LocalCoop() || !MainUI.IsAnyUIOpen()))
		{
			Open(1);
			NHAHLKCCDED = awaitingCompleteList[0];
			HOMANOMFMLM(NHAHLKCCDED);
			awaitingCompleteList.Remove(NHAHLKCCDED);
		}
	}

	private void PLDKAONIIDM(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.GCFGGOJEDHI();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.BNIKGJFDLOF();
	}

	private void GOCJBBEOAOL(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.HBEKMGFNLNN();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.IGDKFHCHEAJ();
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			Utils.JEAHJILAIAP(1f);
			PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
			base.CloseUI();
			Sound.GGFJGHHHEJC.UnmuteLoops();
		}
	}

	public void DNMPEEBDJPG()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = false;
		BOBCIFEDJED();
	}

	[SpecialName]
	public static RepRewardPopUp DCAEBALADIM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	public void PJEGJNPPDKN()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = true;
		CloseUI();
	}

	[SpecialName]
	public static RepRewardPopUp MOJDNGDNCCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	public void LJNLBFJGEJF()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = true;
		CloseUI();
	}

	[SpecialName]
	public static RepRewardPopUp LANAINBEMCM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	private void OAOOFDCGHDP(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.DIBBECHDFNP();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.EDHPCKDJKDE();
	}

	[SpecialName]
	public static RepRewardPopUp OAPOJCODNCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static RepRewardPopUp FMIDAFEGDCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	public void NIIMAOLFIMA()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = true;
		CloseUI();
	}

	private void HOMANOMFMLM(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.PGDCOBHAAJE();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.IGDKFHCHEAJ();
	}

	[SpecialName]
	public static RepRewardPopUp MPFJOKOJIOO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RepRewardPopUp>();
		}
		return IADEMLIIDPC;
	}

	public void IOLIBJIMCHG()
	{
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).updateNextFrame = false;
		BOBCIFEDJED();
	}

	public void BLDIFDCFHDF()
	{
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).updateNextFrame = false;
		BOBCIFEDJED();
	}

	public void AcceptButtonClicked()
	{
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).updateNextFrame = true;
		CloseUI();
	}

	public void FAKOBCLGKGE()
	{
		PlayerInputs.GetPlayer(base.JIIGOACEIKL).updateNextFrame = false;
		BOBCIFEDJED();
	}

	public void CNDOAHGJBHE()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = true;
		BOBCIFEDJED();
	}

	public void EILGDLOAALO()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = false;
		CloseUI();
	}

	private void EEDALDFDHBK(ReputationInfo BBJDPIJPLPA)
	{
		((TMP_Text)repTitleText).text = BBJDPIJPLPA.HBEKMGFNLNN();
		((TMP_Text)repDescriptionText).text = BBJDPIJPLPA.COHFIGGNKNB();
	}

	public void OABKDLAFLJE()
	{
		PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).updateNextFrame = true;
		BOBCIFEDJED();
	}
}
