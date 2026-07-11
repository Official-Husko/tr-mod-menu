using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SoundMenuUI : UIWindow
{
	private static SoundMenuUI IADEMLIIDPC;

	public VolumeSliderUI sfxSlider;

	public VolumeSliderUI musicSlider;

	public ToggleButton tutorialEnabledToggle;

	[SerializeField]
	private ToggleButton chatToggle;

	[SerializeField]
	private Button firstFocusedGameObject;

	public static SoundMenuUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
			}
			return IADEMLIIDPC;
		}
	}

	private void FGKEHGOKHDF(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	private void IFEMNEJNGAE(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
	}

	public void GOBKKMHMJFB()
	{
		Options.AAFBLMLIJPH = false;
	}

	public void HFKFCHCDFEJ()
	{
		Options.AAFBLMLIJPH = false;
	}

	private void CMHDCGCEOID()
	{
		sfxSlider.FJAAIIJEKIE = Options.DJLJFDPNCPI;
		musicSlider.KBNLFAGEGBI(Options.DCIGBKPCLCK);
		chatToggle.PDCBEFOOIGB(Options.AAFBLMLIJPH);
	}

	private void HAHFGAJAIHB(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	public void LNHMIFCBEGF()
	{
		Options.AAFBLMLIJPH = true;
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			sfxSlider.CDFNCDHCFLO += FGKEHGOKHDF;
			musicSlider.CDFNCDHCFLO += JFMMDDEEFAK;
			TutorialManager instance = TutorialManager.GGFJGHHHEJC;
			instance.OnTutorialEnabledChanged = (Action<bool>)Delegate.Combine(instance.OnTutorialEnabledChanged, (Action<bool>)delegate(bool BJFHJCFOEHG)
			{
				tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
			});
			base.Awake();
		}
	}

	private void CBCHGIMMNEO()
	{
		sfxSlider.MMAJFCNPLEJ(Options.DJLJFDPNCPI);
		musicSlider.KEPPKDCOHAC(Options.DCIGBKPCLCK);
		chatToggle.ONGJCKHNDAN(Options.AAFBLMLIJPH);
	}

	public void ToggleChatSoudOff()
	{
		Options.AAFBLMLIJPH = false;
	}

	public void GMHLGJPCFOJ()
	{
		Options.AAFBLMLIJPH = true;
	}

	public void HEOKOHGANDF()
	{
		Options.AAFBLMLIJPH = false;
	}

	[SpecialName]
	public static SoundMenuUI LADDMEMMJFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void CNDPOFMPDNH(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.HINPLKLBAMB(BJFHJCFOEHG);
	}

	private void GJDGGGFGJGC(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	private void JLCMAJIKAJL(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	public void OEOPPNHDGDK()
	{
		Options.AAFBLMLIJPH = true;
	}

	private void BGNCGDNAKCG(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	[SpecialName]
	public static SoundMenuUI HNNJEBNIPOI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void PJPCMHKFBHJ()
	{
		Options.AAFBLMLIJPH = false;
	}

	[SpecialName]
	public static SoundMenuUI CHPEMJMLDCN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void HBPHCJEJDDF(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	private void PFIHKCJDGDC(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	public override void CloseUIRemainActive()
	{
		if (LKOJBFMGMAE)
		{
			base.CloseUIRemainActive();
		}
	}

	public void BHOCEIMKMDE()
	{
		Options.AAFBLMLIJPH = true;
	}

	private void FMIGOLPCOGL(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	[SpecialName]
	public static SoundMenuUI JHKLPLPBKCI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void HHMADGCIMDG(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.ICIHCBILJMK(BJFHJCFOEHG);
	}

	private void LLCKBCJBNEN()
	{
		sfxSlider.IJFAJPJKNNH(Options.DJLJFDPNCPI);
		musicSlider.PGGMLNBOPNP(Options.DCIGBKPCLCK);
		chatToggle.DINJBIOPIOH = Options.AAFBLMLIJPH;
	}

	[SpecialName]
	public static SoundMenuUI ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			BNJOFIGDOJC();
		}
	}

	private void BCGHFDKLPPN(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.HINPLKLBAMB(BJFHJCFOEHG);
	}

	private void HPILLAKICJE(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	public void EJADCBIHFMG()
	{
		Options.AAFBLMLIJPH = true;
	}

	[SpecialName]
	public static SoundMenuUI CNDNOECMKME()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void ToggleChatSoudOn()
	{
		Options.AAFBLMLIJPH = true;
	}

	private void ACDLDDIPBFD()
	{
		sfxSlider.CELOAJLLBFK(Options.DJLJFDPNCPI);
		musicSlider.CELOAJLLBFK(Options.DCIGBKPCLCK);
		chatToggle.IFIKOLNNBLA(Options.AAFBLMLIJPH);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)firstFocusedGameObject);
		}
	}

	public void FKPJAGFLFJF()
	{
		Options.AAFBLMLIJPH = false;
	}

	private void CJKFGILLMBH()
	{
		sfxSlider.HBIDFOGDGBJ(Options.DJLJFDPNCPI);
		musicSlider.MMAJFCNPLEJ(Options.DCIGBKPCLCK);
		chatToggle.DINJBIOPIOH = Options.AAFBLMLIJPH;
	}

	private void PCLFFALIBNO()
	{
		sfxSlider.CELOAJLLBFK(Options.DJLJFDPNCPI);
		musicSlider.BAEGKMFKKMA(Options.DCIGBKPCLCK);
		chatToggle.KAFLJELOMEB(Options.AAFBLMLIJPH);
	}

	[SpecialName]
	public static SoundMenuUI NGIMIHFFNMH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void JFMMDDEEFAK(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			base.CloseUI();
		}
	}

	[SpecialName]
	public static SoundMenuUI LANAINBEMCM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void FEKHEEKNKCK()
	{
		Options.AAFBLMLIJPH = true;
	}

	[SpecialName]
	public static SoundMenuUI MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void JLNLLCBCOKL(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.ICIHCBILJMK(BJFHJCFOEHG);
	}

	private void GMGFMHNPMCK(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	private void LNFIFCJPDIN(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	private void HPIBEJFPPHM(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	private void EDBOKOBDPOE(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.AOBJBNMMACE(BJFHJCFOEHG);
	}

	private void DPJFDMHHPLN(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	public void GNHKKLKMFEN()
	{
		Options.AAFBLMLIJPH = true;
	}

	private void KCKDEPAAMHI(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.HINPLKLBAMB(BJFHJCFOEHG);
	}

	public void PPDFOINEFNA()
	{
		Options.AAFBLMLIJPH = false;
	}

	public void EMMFFJCIDHC()
	{
		Options.AAFBLMLIJPH = true;
	}

	private void BNJOFIGDOJC()
	{
		sfxSlider.FJAAIIJEKIE = Options.DJLJFDPNCPI;
		musicSlider.FJAAIIJEKIE = Options.DCIGBKPCLCK;
		chatToggle.DINJBIOPIOH = Options.AAFBLMLIJPH;
	}

	private void LOGCDMECAPG()
	{
		sfxSlider.PGGMLNBOPNP(Options.DJLJFDPNCPI);
		musicSlider.KBPFOJJOPFP(Options.DCIGBKPCLCK);
		chatToggle.MFBFKMNAMPC(Options.AAFBLMLIJPH);
	}

	[CompilerGenerated]
	private void GGBPGNMFKNE(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
	}

	private void HKHNCCFGEBC(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	[SpecialName]
	public static SoundMenuUI KIALFDOKABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<SoundMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void FPDEJHIIDMD()
	{
		sfxSlider.KEPPKDCOHAC(Options.DJLJFDPNCPI);
		musicSlider.FMELNHLDODF(Options.DCIGBKPCLCK);
		chatToggle.DINJBIOPIOH = Options.AAFBLMLIJPH;
	}

	public void KPLGCDELCGA()
	{
		Options.AAFBLMLIJPH = false;
	}

	private void PDNLNBGLHDD(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.ICIHCBILJMK(BJFHJCFOEHG);
	}

	private void MBPNAILJDDD(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	private void LENNDHDMLFI(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.ICIHCBILJMK(BJFHJCFOEHG);
	}

	public void BHLNOLFCHEK()
	{
		Options.AAFBLMLIJPH = true;
	}

	private void FEDGLBNDAAK()
	{
		sfxSlider.JJNPEPDDEOF(Options.DJLJFDPNCPI);
		musicSlider.BEBHKDFEDKO(Options.DCIGBKPCLCK);
		chatToggle.LOHJKOCPHMG(Options.AAFBLMLIJPH);
	}

	private void HPIGHCLBONJ(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	private void CNCOPKDHNML(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	public void EBNINIAMLAG()
	{
		Options.AAFBLMLIJPH = false;
	}

	public void KAIIHOKBDGK()
	{
		Options.AAFBLMLIJPH = true;
	}
}
