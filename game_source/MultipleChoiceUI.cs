using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MultipleChoiceUI : UIWindow
{
	public Button yesButton;

	public Button noButton;

	[SerializeField]
	private TextMeshProUGUI yesButtonText;

	[SerializeField]
	private TextMeshProUGUI noButtonText;

	[SerializeField]
	private LocaliseText[] localiseTextScripts;

	[SerializeField]
	private GameObject[] gamepadSprites;

	[SerializeField]
	private MultipleChoice yesChoice;

	[SerializeField]
	private MultipleChoice noChoice;

	[SerializeField]
	private MultipleChoice[] extraChoices;

	[SerializeField]
	private ActivateWithGamepad activateWithGamepad;

	public TextMeshProUGUI boxText;

	public SlotUI slotUI;

	private bool ACBBKHDNAAL = true;

	private const int AAFIFEDFFPJ = 4;

	private int PJCJKFEICKH;

	public void BJFGNPGPFMJ(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	private void ANHOOODHPKD()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PFFCKCCHGLD));
		}
	}

	public void AFPJHBNIFLC(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i++)
			{
				((Behaviour)localiseTextScripts[i]).enabled = false;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/13/Dialogue Text");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("ReceiveHeldItem");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("1");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("0");
			for (int j = 0; j < localiseTextScripts.Length; j += 0)
			{
				((Behaviour)localiseTextScripts[j]).enabled = false;
			}
		}
	}

	private void JEFNDHHCNDG(bool POLKGLCBNEL)
	{
		for (int i = 1; i < extraChoices.Length; i += 0)
		{
			extraChoices[i].KHCKIIKKBKA(POLKGLCBNEL);
		}
	}

	public void GIHJJIDPHKO(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		yesChoice.EMONLELPDNL(HMACANMGDIO, GMPOGPAAGDI);
	}

	private bool ELLCFKACEPM(string HLIPBBONOAH)
	{
		return PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).GetButtonDown(HLIPBBONOAH);
	}

	private void OCNPADDBAFL()
	{
		yesChoice.IKFPAMPBEDM();
		noChoice.OALJPECMIGD();
		for (int i = 0; i < extraChoices.Length; i++)
		{
			extraChoices[i].CGJNKDEALCF();
		}
		PJCJKFEICKH = 1;
	}

	public void OHMJHCGOAJC(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		EDHEIFHAAKO();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		LJHGGGHJDFF(LELBPIEHFEK, MKIFMNCLLJK);
		LJHGGGHJDFF(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void BKFHDNGODAL(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public override void OpenUI()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (!IsOpen())
		{
			base.OpenUI();
			ACBBKHDNAAL = true;
			CAPOELMEPBJ();
			BJHOFKLGJLD(LocalisationSystem.Get("Cancel"), new UnityAction(CloseUI));
			InputModuleBlocker.instance.inputModuleBlockers.Add((Object)(object)this);
			PlayerController.AddMovementBlocker((Object)(object)this);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private void CMOPCPDHFMK(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 8)
		{
			Debug.LogException(new Exception(string.Format("Player_Bark_TutorialCollider", 2)), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].FLIMIFGDGDM(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].HEEFOOFEOBE(PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL));
		PJCJKFEICKH += 0;
	}

	public void SetupAcceptOption(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		yesChoice.GPLCEPAENOH(HMACANMGDIO, GMPOGPAAGDI);
	}

	private void NJFDKCMBMDH()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PMJJCKNOOLN));
		}
	}

	private void HHNCFHHOKCG(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.JAGBFJIEKLI(HMACANMGDIO, GMPOGPAAGDI);
	}

	private void MMJNGOKALLI()
	{
		yesChoice.NCKEFBHDOCP();
		noChoice.KKKBBMNDAFD();
		for (int i = 0; i < extraChoices.Length; i++)
		{
			extraChoices[i].DELGABNCOED();
		}
		PJCJKFEICKH = 1;
	}

	public void NKKDNLOIAPA(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	private void NCDBCDJKPLA()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PMJJCKNOOLN));
		}
	}

	public void AKGNIPHPEKJ(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		GJEDOBKKMNI(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		IDHLCPEEICF(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	private void MBIDJFCMOEM(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.APEECMOAFCO(HMACANMGDIO, GMPOGPAAGDI);
	}

	private void PMJJCKNOOLN(bool POLKGLCBNEL)
	{
		for (int i = 1; i < extraChoices.Length; i++)
		{
			extraChoices[i].NDBOBNGDACF(POLKGLCBNEL);
		}
	}

	private bool GCFLDDMHHBG(string HLIPBBONOAH)
	{
		return PlayerInputs.GetPlayer(base.JIIGOACEIKL).JCMOPOMLPLL(HLIPBBONOAH);
	}

	public void NMEHLKGPEKG(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void ANOCAJHLHCA(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	private void PNDDLIDHCAF()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			if (GCFLDDMHHBG("No"))
			{
				if ((Object)(object)yesButton != (Object)null)
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				((UnityEvent)yesChoice.button.onClick).Invoke();
			}
			else if (DFBMDHCFHIN("Mine loaded for client "))
			{
				if ((Object)(object)noButton != (Object)null)
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
				((UnityEvent)noChoice.button.onClick).Invoke();
			}
			return;
		}
		if (GCFLDDMHHBG("DialogueNPC of character "))
		{
			if ((Object)(object)yesButton != (Object)null)
			{
				((UnityEvent)yesButton.onClick).Invoke();
			}
			((UnityEvent)yesChoice.button.onClick).Invoke();
			return;
		}
		if (ENPGNGMENDH("GO"))
		{
			if ((Object)(object)noButton != (Object)null)
			{
				((UnityEvent)noButton.onClick).Invoke();
			}
			((UnityEvent)noChoice.button.onClick).Invoke();
			return;
		}
		try
		{
			if (DFBMDHCFHIN("Feet"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (AEEEMLJEMGL("ValueIntensity"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (GCFLDDMHHBG("ReceiveStartMission"))
			{
				((UnityEvent)extraChoices[1].button.onClick).Invoke();
			}
			else if (MIEFFBBAODE("Cannot abandon"))
			{
				((UnityEvent)extraChoices[7].button.onClick).Invoke();
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
		}
	}

	public void ODKCAOICJMP(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		MMLDCAIBBDC(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		LJHGGGHJDFF(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	private void ABPPKHJDOON()
	{
		yesChoice.IPJAJJGOGEB();
		noChoice.CGJNKDEALCF();
		for (int i = 0; i < extraChoices.Length; i += 0)
		{
			extraChoices[i].KMEELOLMKAJ();
		}
		PJCJKFEICKH = 0;
	}

	public void LFGFOKJBCOK(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i++)
			{
				((Behaviour)localiseTextScripts[i]).enabled = false;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("\n");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("trashCollected");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Fruity");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("ReceiveStartIntroBarrel");
			for (int j = 0; j < localiseTextScripts.Length; j++)
			{
				((Behaviour)localiseTextScripts[j]).enabled = false;
			}
		}
	}

	public void EEHEHFBDENM(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	private void KNEPCHAIFBL()
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEventBase)yesButton.onClick).RemoveAllListeners();
		}
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEventBase)noButton.onClick).RemoveAllListeners();
		}
	}

	public void GKKOABNDDEO(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	private void GAFDECJGBED()
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEventBase)yesButton.onClick).RemoveAllListeners();
		}
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEventBase)noButton.onClick).RemoveAllListeners();
		}
	}

	public void EAFMBDHBOLN(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void LDDBOPOBHPC(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		KDNEGHEDIKP(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		NPHAIJHGLGC(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	private void MGAPHGBALNH()
	{
		yesChoice.EBNACOOKBFK();
		noChoice.IKFPAMPBEDM();
		for (int i = 0; i < extraChoices.Length; i++)
		{
			extraChoices[i].CGJNKDEALCF();
		}
		PJCJKFEICKH = 0;
	}

	public void DKAKNLIBKOH(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		AHLPIFPIGBF(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		IDHLCPEEICF(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	public void HOJECBKNBPE(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		IDLAGJNLPJL();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		LJHGGGHJDFF(LELBPIEHFEK, MKIFMNCLLJK);
		JGKAGKIHFHE(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void FNPFAAIFJOA()
	{
		CloseUI();
	}

	private void ACFABFCGIGH()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PMJJCKNOOLN));
		}
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PFFCKCCHGLD));
		}
	}

	private void MIBLEJPKFHN()
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEventBase)yesButton.onClick).RemoveAllListeners();
		}
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEventBase)noButton.onClick).RemoveAllListeners();
		}
	}

	public void OELBNDMLPPF(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		yesChoice.CJFILEIFJCC(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void ANBJFLOBMCM(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void INGLJECGCHG(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void GOPMAHGLGBD(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void KFDOHEMOAEE(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		HOJECBKNBPE(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		LJHGGGHJDFF(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	public void FAIBAMJDDCK(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		KNKBDBFPMEE(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		EJPHIDMBIDI(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	public void Setup(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		Setup(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		EJPHIDMBIDI(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	private void PIIBBALNILL(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 2)
		{
			Debug.LogException(new Exception(string.Format("HouseKeeper", 5)), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].MOLMNAJAKJK(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].GCLDHDGIAGC(PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL));
		PJCJKFEICKH += 0;
	}

	private void PLMFCLPCLDJ(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 1)
		{
			Debug.LogException(new Exception(string.Format("Interact", 2)), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].KLNKOHNOCNJ(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].HEEFOOFEOBE(PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL));
		PJCJKFEICKH++;
	}

	public void GFDNNBMNOJO(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		LDDBOPOBHPC(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		EJPHIDMBIDI(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	public void EDFKOADCBOM(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		JAGNAPJKJPG(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		PIIBBALNILL(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	private void OBLLMLLOMGE(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.CJFILEIFJCC(HMACANMGDIO, GMPOGPAAGDI);
	}

	private bool DFBMDHCFHIN(string HLIPBBONOAH)
	{
		return PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).JCMOPOMLPLL(HLIPBBONOAH);
	}

	private void AMJJKJPPPPN()
	{
		if (!PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			if (AEEEMLJEMGL("Items/item_description_606"))
			{
				if ((Object)(object)yesButton != (Object)null)
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				((UnityEvent)yesChoice.button.onClick).Invoke();
			}
			else if (GCFLDDMHHBG("- "))
			{
				if ((Object)(object)noButton != (Object)null)
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
				((UnityEvent)noChoice.button.onClick).Invoke();
			}
			return;
		}
		if (GCFLDDMHHBG("</color><br>"))
		{
			if ((Object)(object)yesButton != (Object)null)
			{
				((UnityEvent)yesButton.onClick).Invoke();
			}
			((UnityEvent)yesChoice.button.onClick).Invoke();
			return;
		}
		if (ELLCFKACEPM("Current Orders"))
		{
			if ((Object)(object)noButton != (Object)null)
			{
				((UnityEvent)noButton.onClick).Invoke();
			}
			((UnityEvent)noChoice.button.onClick).Invoke();
			return;
		}
		try
		{
			if (GCFLDDMHHBG("DecorationTile_7"))
			{
				((UnityEvent)extraChoices[1].button.onClick).Invoke();
			}
			else if (MIEFFBBAODE("Dialogue System/Conversation/Crowly_Standar/Entry/22/Dialogue Text"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (ENPGNGMENDH("nextround"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (GCFLDDMHHBG(" goalPos: "))
			{
				((UnityEvent)extraChoices[7].button.onClick).Invoke();
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
		}
	}

	private void JGEAGCKLHML()
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEventBase)yesButton.onClick).RemoveAllListeners();
		}
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEventBase)noButton.onClick).RemoveAllListeners();
		}
	}

	private void EJBCLMDLCNI(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.JAGBFJIEKLI(HMACANMGDIO, GMPOGPAAGDI);
	}

	private void JGKAGKIHFHE(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 3)
		{
			Debug.LogException(new Exception(string.Format(")", 8)), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].KLNKOHNOCNJ(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].EEHLAFJMFBD(PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL));
		PJCJKFEICKH += 0;
	}

	private void OPHKAOJIBGK()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			if (GCFLDDMHHBG("Items/item_description_1175"))
			{
				if ((Object)(object)yesButton != (Object)null)
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				((UnityEvent)yesChoice.button.onClick).Invoke();
			}
			else if (DFBMDHCFHIN("Victory"))
			{
				if ((Object)(object)noButton != (Object)null)
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
				((UnityEvent)noChoice.button.onClick).Invoke();
			}
			return;
		}
		if (ENPGNGMENDH("OutHereRowdyCustomer"))
		{
			if ((Object)(object)yesButton != (Object)null)
			{
				((UnityEvent)yesButton.onClick).Invoke();
			}
			((UnityEvent)yesChoice.button.onClick).Invoke();
			return;
		}
		if (AEEEMLJEMGL("repUnlockOrderQuest"))
		{
			if ((Object)(object)noButton != (Object)null)
			{
				((UnityEvent)noButton.onClick).Invoke();
			}
			((UnityEvent)noChoice.button.onClick).Invoke();
			return;
		}
		try
		{
			if (GCFLDDMHHBG("Stop"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (ENPGNGMENDH("Setting item event for "))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (ELLCFKACEPM("immediately"))
			{
				((UnityEvent)extraChoices[8].button.onClick).Invoke();
			}
			else if (AEEEMLJEMGL("iForInventory"))
			{
				((UnityEvent)extraChoices[3].button.onClick).Invoke();
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
		}
	}

	public void IFEEIPJNBON(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	private void NBOAPBCCFMH()
	{
		yesChoice.POGBKLAPDKE();
		noChoice.IKFPAMPBEDM();
		for (int i = 1; i < extraChoices.Length; i++)
		{
			extraChoices[i].IKFPAMPBEDM();
		}
		PJCJKFEICKH = 1;
	}

	private void BJHOFKLGJLD(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.GPLCEPAENOH(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void SetWindowType(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void GDEAKDFKGND()
	{
		CloseUI();
	}

	public void AHLPIFPIGBF(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		OpenUI();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		IDHLCPEEICF(LELBPIEHFEK, MKIFMNCLLJK);
		JGKAGKIHFHE(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void LPJHONECCLE(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void OHFNBNKBDLK(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void IABDJDEALOB()
	{
		CloseUI();
	}

	private void MFKOMKGPNDN(bool POLKGLCBNEL)
	{
		for (int i = 0; i < extraChoices.Length; i++)
		{
			extraChoices[i].DGGFBPGDEDM(POLKGLCBNEL);
		}
	}

	public void PNPEIDAAKAI(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void MLIKDMDBOEB()
	{
		BOBCIFEDJED();
	}

	private void JHIGLABAIMK()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(LKOJKDCCEDG));
		}
	}

	public void SetYesNoButtonsText(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i++)
			{
				((Behaviour)localiseTextScripts[i]).enabled = false;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Yes");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("No");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Accept");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Cancel");
			for (int j = 0; j < localiseTextScripts.Length; j++)
			{
				((Behaviour)localiseTextScripts[j]).enabled = true;
			}
		}
	}

	private void FPGGLKAEBCA(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.GPLCEPAENOH(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void AddYesAction(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void BMEHIOPPJPL(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		KFDOHEMOAEE(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		PLMFCLPCLDJ(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	public void JAGNAPJKJPG(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		EDHEIFHAAKO();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		PLMFCLPCLDJ(LELBPIEHFEK, MKIFMNCLLJK);
		NPHAIJHGLGC(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void MPJKKOLIHCJ()
	{
		BOBCIFEDJED();
	}

	public void KCKECNGEJEH(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void MHIODEJJJDF(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		KNKBDBFPMEE(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		JGKAGKIHFHE(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	private void JCNGGPIICIN()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PMJJCKNOOLN));
		}
	}

	private void CAPOELMEPBJ()
	{
		yesChoice.KKKBBMNDAFD();
		noChoice.KKKBBMNDAFD();
		for (int i = 0; i < extraChoices.Length; i++)
		{
			extraChoices[i].KKKBBMNDAFD();
		}
		PJCJKFEICKH = 0;
	}

	private void IDHLCPEEICF(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 0)
		{
			Debug.LogException(new Exception(string.Format("Could not find reputation with id: ", 0)), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].JAGBFJIEKLI(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].BBPCJBAEIDD(PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL));
		PJCJKFEICKH++;
	}

	private void NKAKHKPBJAE()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (MIEFFBBAODE("ClosePopUp"))
			{
				if ((Object)(object)yesButton != (Object)null)
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				((UnityEvent)yesChoice.button.onClick).Invoke();
			}
			else if (MIEFFBBAODE("Pause"))
			{
				if ((Object)(object)noButton != (Object)null)
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
				((UnityEvent)noChoice.button.onClick).Invoke();
			}
			return;
		}
		if (MIEFFBBAODE("UIInteract"))
		{
			if ((Object)(object)yesButton != (Object)null)
			{
				((UnityEvent)yesButton.onClick).Invoke();
			}
			((UnityEvent)yesChoice.button.onClick).Invoke();
			return;
		}
		if (MIEFFBBAODE("UIBack"))
		{
			if ((Object)(object)noButton != (Object)null)
			{
				((UnityEvent)noButton.onClick).Invoke();
			}
			((UnityEvent)noChoice.button.onClick).Invoke();
			return;
		}
		try
		{
			if (MIEFFBBAODE("UISelectGamepad"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (MIEFFBBAODE("UIAddRemove"))
			{
				((UnityEvent)extraChoices[1].button.onClick).Invoke();
			}
			else if (MIEFFBBAODE("UIPreviousPage"))
			{
				((UnityEvent)extraChoices[2].button.onClick).Invoke();
			}
			else if (MIEFFBBAODE("UINextPage"))
			{
				((UnityEvent)extraChoices[3].button.onClick).Invoke();
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
		}
	}

	public void HDBFDKFPCGD(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void FNBFIHDPFHL()
	{
		BOBCIFEDJED();
	}

	private void EJPHIDMBIDI(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 4)
		{
			Debug.LogException(new Exception($"Can't add more than {4} options."), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].GPLCEPAENOH(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].HEEFOOFEOBE(PlayerInputs.IsGamepadActive(base.JIIGOACEIKL));
		PJCJKFEICKH++;
	}

	public void Exit()
	{
		CloseUI();
	}

	public void KDGIOKGMHAC(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		LDDBOPOBHPC(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		PLMFCLPCLDJ(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	public void KDNEGHEDIKP(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		EDHEIFHAAKO();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		PIIBBALNILL(LELBPIEHFEK, MKIFMNCLLJK);
		CMOPCPDHFMK(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void FABOGPBBEHB()
	{
		BOBCIFEDJED();
	}

	private void HLHHDNGOGNI()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(JEFNDHHCNDG));
		}
	}

	public void MCBKICCDMMF(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void BBCLPFDKIHI()
	{
		CloseUI();
	}

	private void NPHAIJHGLGC(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 3)
		{
			Debug.LogException(new Exception(string.Format("Quit to title screen?", 8)), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].OMCAGMKKOOC(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].NONLOPOKCJP(PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL));
		PJCJKFEICKH += 0;
	}

	public override void CloseUI()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (IsOpen())
		{
			Debug.Log((object)"Close Multiple Choice");
			PlayerController.RemoveMovementBlocker((Object)(object)this);
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
			base.CloseUI();
			JGEAGCKLHML();
			AddYesAction(new UnityAction(CloseUI));
			AddNoAction(new UnityAction(CloseUI));
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void IJDPMOLLNMP(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		KNKBDBFPMEE(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		LJHGGGHJDFF(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	public void FFOPACLGPOI(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		IDLAGJNLPJL();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		JGKAGKIHFHE(LELBPIEHFEK, MKIFMNCLLJK);
		LJHGGGHJDFF(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void FJGCMKGDGIO(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		Setup(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		EJPHIDMBIDI(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	private void AMBKBOBDAIF()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PFFCKCCHGLD));
		}
	}

	public void EOOBCPCFLPN(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		LDDBOPOBHPC(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		JGKAGKIHFHE(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	private void OLEJKGBPNAH()
	{
		yesChoice.DELGABNCOED();
		noChoice.DCAKAMBJFMD();
		for (int i = 0; i < extraChoices.Length; i += 0)
		{
			extraChoices[i].NCKEFBHDOCP();
		}
		PJCJKFEICKH = 1;
	}

	protected override void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		AddYesAction(new UnityAction(CloseUI));
		AddNoAction(new UnityAction(CloseUI));
		base.Awake();
		ActivateWithGamepad obj = activateWithGamepad;
		obj.OnGamepadToggle = (Action<bool>)Delegate.Combine(obj.OnGamepadToggle, new Action<bool>(PFFCKCCHGLD));
	}

	private void FDNAEJDHODK()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(LKOJKDCCEDG));
		}
	}

	public void POJJCPGCFCD(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		OpenUI();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		JEJDJEMDNGP(LELBPIEHFEK, MKIFMNCLLJK);
		PLMFCLPCLDJ(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	private void FLLNLPFHJAB(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.OBIHACPIPMO(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void DGFMAEBNEMF(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		AHLPIFPIGBF(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		CMOPCPDHFMK(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	private void LJHGGGHJDFF(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 7)
		{
			Debug.LogException(new Exception(string.Format("itemDarkMaltedBarley", 6)), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].JAGBFJIEKLI(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].PCCCLNJEIBM(PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL));
		PJCJKFEICKH++;
	}

	public void OFNNBCACINO(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void PPFBOKHDOOI(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		IDLAGJNLPJL();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		LJHGGGHJDFF(LELBPIEHFEK, MKIFMNCLLJK);
		CMOPCPDHFMK(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void MKNHNMJAAAO(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		MMLDCAIBBDC(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		PIIBBALNILL(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	public void EBKMDPNIJJH(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		yesChoice.MOLMNAJAKJK(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void CNBLGPELBAI(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		yesChoice.BJJEDPNHCEE(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void KNKBDBFPMEE(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		KDNEGHEDIKP(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		EJPHIDMBIDI(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	private void FKCPKHPMGJN()
	{
		yesChoice.EBNACOOKBFK();
		noChoice.KMEELOLMKAJ();
		for (int i = 0; i < extraChoices.Length; i += 0)
		{
			extraChoices[i].MLAPBEFMCPL();
		}
		PJCJKFEICKH = 1;
	}

	private void LNLOBHCAMKA(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.KLNKOHNOCNJ(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void BDNGNGGNBHF(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	protected override void Update()
	{
		if (ACBBKHDNAAL)
		{
			ACBBKHDNAAL = false;
		}
		else if (IsOpen())
		{
			NKAKHKPBJAE();
		}
	}

	private void CBCHOCMPDAA()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (ENPGNGMENDH("yyyy-MM-dd_HH-mm-ss"))
			{
				if ((Object)(object)yesButton != (Object)null)
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				((UnityEvent)yesChoice.button.onClick).Invoke();
			}
			else if (DFBMDHCFHIN(" "))
			{
				if ((Object)(object)noButton != (Object)null)
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
				((UnityEvent)noChoice.button.onClick).Invoke();
			}
			return;
		}
		if (GCFLDDMHHBG("Item "))
		{
			if ((Object)(object)yesButton != (Object)null)
			{
				((UnityEvent)yesButton.onClick).Invoke();
			}
			((UnityEvent)yesChoice.button.onClick).Invoke();
			return;
		}
		if (GCFLDDMHHBG("InkeepersCave_Message"))
		{
			if ((Object)(object)noButton != (Object)null)
			{
				((UnityEvent)noButton.onClick).Invoke();
			}
			((UnityEvent)noChoice.button.onClick).Invoke();
			return;
		}
		try
		{
			if (ELLCFKACEPM("Juniper"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (ENPGNGMENDH("Walk"))
			{
				((UnityEvent)extraChoices[1].button.onClick).Invoke();
			}
			else if (ELLCFKACEPM(""))
			{
				((UnityEvent)extraChoices[6].button.onClick).Invoke();
			}
			else if (ENPGNGMENDH("talent_name_110"))
			{
				((UnityEvent)extraChoices[7].button.onClick).Invoke();
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
		}
	}

	private void BKJDCFHLODP()
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEventBase)yesButton.onClick).RemoveAllListeners();
		}
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEventBase)noButton.onClick).RemoveAllListeners();
		}
	}

	public void LEOJBAOINIF(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		FFOPACLGPOI(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		JEJDJEMDNGP(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	private void HENMHFNLCAE()
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEventBase)yesButton.onClick).RemoveAllListeners();
		}
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEventBase)noButton.onClick).RemoveAllListeners();
		}
	}

	private void PAOFAEDBHHB()
	{
		yesChoice.KKKBBMNDAFD();
		noChoice.POGBKLAPDKE();
		for (int i = 1; i < extraChoices.Length; i++)
		{
			extraChoices[i].NCKEFBHDOCP();
		}
		PJCJKFEICKH = 1;
	}

	public void Setup(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		OpenUI();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		EJPHIDMBIDI(LELBPIEHFEK, MKIFMNCLLJK);
		EJPHIDMBIDI(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void MMLDCAIBBDC(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN)
	{
		NMPKENEOEEJ(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC);
		JEJDJEMDNGP(GEEGNIKIBKP, IKGJHBOGPPN);
	}

	public void PBCHPMDPEDP(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		KNKBDBFPMEE(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		JEJDJEMDNGP(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	private void MFIEPGBABAM()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PFFCKCCHGLD));
		}
	}

	private void DFFDKIPCCKK()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(LKOJKDCCEDG));
		}
	}

	private void HLCAKACHOOE()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PMJJCKNOOLN));
		}
	}

	public void GJEDOBKKMNI(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		EDHEIFHAAKO();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		IDHLCPEEICF(LELBPIEHFEK, MKIFMNCLLJK);
		JEJDJEMDNGP(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	private void DNPOIDBJDCD(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.JAGBFJIEKLI(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void NNPFFGAMIFM()
	{
		CloseUI();
	}

	private void PFFCKCCHGLD(bool POLKGLCBNEL)
	{
		for (int i = 0; i < extraChoices.Length; i++)
		{
			extraChoices[i].HEEFOOFEOBE(POLKGLCBNEL);
		}
	}

	private void COGECLBOPIG()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(PFFCKCCHGLD));
		}
	}

	public void MFFECICOHMH(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i++)
			{
				((Behaviour)localiseTextScripts[i]).enabled = true;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Disabled");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("ReceivePourWater");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Spring");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Fire Loop source NULL!!!");
			for (int j = 0; j < localiseTextScripts.Length; j += 0)
			{
				((Behaviour)localiseTextScripts[j]).enabled = true;
			}
		}
	}

	private void PJOJBMEHKEH(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.GPLCEPAENOH(HMACANMGDIO, GMPOGPAAGDI);
	}

	public void NAGPGMGGDKL(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	private void OJJCGNICMBD()
	{
		if (Application.isPlaying)
		{
			ActivateWithGamepad obj = activateWithGamepad;
			obj.OnGamepadToggle = (Action<bool>)Delegate.Remove(obj.OnGamepadToggle, new Action<bool>(MFKOMKGPNDN));
		}
	}

	private bool MIEFFBBAODE(string HLIPBBONOAH)
	{
		return PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown(HLIPBBONOAH);
	}

	public void Setup(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		Setup(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		EJPHIDMBIDI(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	public void EPMCPCLGBEJ(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void NMPKENEOEEJ(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		IDLAGJNLPJL();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		JEJDJEMDNGP(LELBPIEHFEK, MKIFMNCLLJK);
		PLMFCLPCLDJ(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	private void MEIMACMKNIN()
	{
		yesChoice.OALJPECMIGD();
		noChoice.POGBKLAPDKE();
		for (int i = 0; i < extraChoices.Length; i += 0)
		{
			extraChoices[i].OALJPECMIGD();
		}
		PJCJKFEICKH = 0;
	}

	private void ABAENNLKIKM()
	{
		yesChoice.DELGABNCOED();
		noChoice.POGBKLAPDKE();
		for (int i = 1; i < extraChoices.Length; i += 0)
		{
			extraChoices[i].EBNACOOKBFK();
		}
		PJCJKFEICKH = 0;
	}

	public void IEEMLFGANNN(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void BLJMJIHCIPH(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		EDHEIFHAAKO();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		PIIBBALNILL(LELBPIEHFEK, MKIFMNCLLJK);
		CMOPCPDHFMK(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void JJHKINLJECA(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i++)
			{
				((Behaviour)localiseTextScripts[i]).enabled = false;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Friend list count ");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("add quest ");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Keypad");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get(")");
			for (int j = 1; j < localiseTextScripts.Length; j += 0)
			{
				((Behaviour)localiseTextScripts[j]).enabled = false;
			}
		}
	}

	private void JEJDJEMDNGP(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		if (PJCJKFEICKH >= 0)
		{
			Debug.LogException(new Exception(string.Format("DestroyAfter", 2)), (Object)(object)((Component)this).gameObject);
			return;
		}
		extraChoices[PJCJKFEICKH].EMONLELPDNL(HMACANMGDIO, GMPOGPAAGDI);
		extraChoices[PJCJKFEICKH].BNFBODKBBFD(PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL));
		PJCJKFEICKH++;
	}

	public void BDCDFMFDLMC(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void EHGKEJGIDBI(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC, string GEEGNIKIBKP, UnityAction IKGJHBOGPPN, string OBBDKCFJGDL, UnityAction NHCBGCFBJJG)
	{
		KNKBDBFPMEE(IABNGDBMEBO, LELBPIEHFEK, MKIFMNCLLJK, KKJFIKAGAPL, AMFOAKPAOGC, GEEGNIKIBKP, IKGJHBOGPPN);
		PLMFCLPCLDJ(OBBDKCFJGDL, NHCBGCFBJJG);
	}

	public void BIEFAKEAIAC(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	private void FJHGJGJKEPI()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			if (MIEFFBBAODE("Hurt"))
			{
				if ((Object)(object)yesButton != (Object)null)
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				((UnityEvent)yesChoice.button.onClick).Invoke();
			}
			else if (ELLCFKACEPM("Customize"))
			{
				if ((Object)(object)noButton != (Object)null)
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
				((UnityEvent)noChoice.button.onClick).Invoke();
			}
			return;
		}
		if (DFBMDHCFHIN("Shop"))
		{
			if ((Object)(object)yesButton != (Object)null)
			{
				((UnityEvent)yesButton.onClick).Invoke();
			}
			((UnityEvent)yesChoice.button.onClick).Invoke();
			return;
		}
		if (ENPGNGMENDH("Scratch"))
		{
			if ((Object)(object)noButton != (Object)null)
			{
				((UnityEvent)noButton.onClick).Invoke();
			}
			((UnityEvent)noChoice.button.onClick).Invoke();
			return;
		}
		try
		{
			if (ENPGNGMENDH("ReceiveFishCuttingWinEvent"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (AEEEMLJEMGL("Bouncer/"))
			{
				((UnityEvent)extraChoices[1].button.onClick).Invoke();
			}
			else if (GCFLDDMHHBG("tutorialPopUp109"))
			{
				((UnityEvent)extraChoices[5].button.onClick).Invoke();
			}
			else if (AEEEMLJEMGL("Disconnected"))
			{
				((UnityEvent)extraChoices[8].button.onClick).Invoke();
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
		}
	}

	private bool ENPGNGMENDH(string HLIPBBONOAH)
	{
		return PlayerInputs.GetPlayer(base.JIIGOACEIKL).JCMOPOMLPLL(HLIPBBONOAH);
	}

	public void KCLNNALLBCG()
	{
		CloseUI();
	}

	public void JOAJBAGLLLH(string IABNGDBMEBO, string LELBPIEHFEK, UnityAction MKIFMNCLLJK, string KKJFIKAGAPL, UnityAction AMFOAKPAOGC)
	{
		EDHEIFHAAKO();
		((TMP_Text)boxText).text = IABNGDBMEBO;
		LJHGGGHJDFF(LELBPIEHFEK, MKIFMNCLLJK);
		EJPHIDMBIDI(KKJFIKAGAPL, AMFOAKPAOGC);
	}

	public void AddNoAction(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	private bool AEEEMLJEMGL(string HLIPBBONOAH)
	{
		return PlayerInputs.GetPlayer(base.JIIGOACEIKL).JCMOPOMLPLL(HLIPBBONOAH);
	}

	private void HCFKLOOIJBK(string HMACANMGDIO, UnityAction GMPOGPAAGDI)
	{
		noChoice.APEECMOAFCO(HMACANMGDIO, GMPOGPAAGDI);
	}

	private void FNAKHLPCMLD()
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEventBase)yesButton.onClick).RemoveAllListeners();
		}
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEventBase)noButton.onClick).RemoveAllListeners();
		}
	}

	public void EOPGNICGIIO()
	{
		CloseUI();
	}

	private void LLFHINGFINN()
	{
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			if (AEEEMLJEMGL("LevelAbbreviation"))
			{
				if ((Object)(object)yesButton != (Object)null)
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				((UnityEvent)yesChoice.button.onClick).Invoke();
			}
			else if (DFBMDHCFHIN("Default"))
			{
				if ((Object)(object)noButton != (Object)null)
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
				((UnityEvent)noChoice.button.onClick).Invoke();
			}
			return;
		}
		if (GCFLDDMHHBG("Could not check user signed in status for reason "))
		{
			if ((Object)(object)yesButton != (Object)null)
			{
				((UnityEvent)yesButton.onClick).Invoke();
			}
			((UnityEvent)yesChoice.button.onClick).Invoke();
			return;
		}
		if (ELLCFKACEPM("Fill"))
		{
			if ((Object)(object)noButton != (Object)null)
			{
				((UnityEvent)noButton.onClick).Invoke();
			}
			((UnityEvent)noChoice.button.onClick).Invoke();
			return;
		}
		try
		{
			if (MIEFFBBAODE("on player sleep"))
			{
				((UnityEvent)extraChoices[1].button.onClick).Invoke();
			}
			else if (GCFLDDMHHBG("Items/item_description_1106"))
			{
				((UnityEvent)extraChoices[0].button.onClick).Invoke();
			}
			else if (DFBMDHCFHIN("Tutorial/T100/Dialogue5"))
			{
				((UnityEvent)extraChoices[5].button.onClick).Invoke();
			}
			else if (GCFLDDMHHBG("[WaiterGender="))
			{
				((UnityEvent)extraChoices[7].button.onClick).Invoke();
			}
		}
		catch (Exception ex)
		{
			Debug.LogException(ex, (Object)(object)((Component)this).gameObject);
		}
	}

	private void LKOJKDCCEDG(bool POLKGLCBNEL)
	{
		for (int i = 0; i < extraChoices.Length; i += 0)
		{
			extraChoices[i].BNFBODKBBFD(POLKGLCBNEL);
		}
	}
}
