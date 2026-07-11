using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class YesNoDialogueUI : UIWindow
{
	public Button yesButton;

	public Button noButton;

	[SerializeField]
	private TextMeshProUGUI yesButtonText;

	[SerializeField]
	private TextMeshProUGUI noButtonText;

	[SerializeField]
	private LocaliseText[] localiseTextScripts;

	public GameObject noButtonGamepadSprite;

	public TextMeshProUGUI boxText;

	public SlotUI slotUI;

	private bool ACBBKHDNAAL = true;

	public void EHPOHGHHPCJ(ItemInstance DNLMCHDOMOK)
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, DNLMCHDOMOK);
	}

	public void ODNAACABPHB()
	{
		CloseUI();
	}

	public void DOODJNGPFIL()
	{
		slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
	}

	public void HBFFMJPJCDK(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	protected override void Update()
	{
		if (ACBBKHDNAAL)
		{
			ACBBKHDNAAL = false;
		}
		else
		{
			if (!IsOpen())
			{
				return;
			}
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIInteract"))
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIBack"))
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
			}
			else
			{
				if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
				{
					((UnityEvent)yesButton.onClick).Invoke();
				}
				if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("Pause"))
				{
					((UnityEvent)noButton.onClick).Invoke();
				}
			}
		}
	}

	private void KDEEGADNNPB()
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

	public void JHLKKBIFCDG()
	{
		CloseUI();
	}

	public void EIKBHDCGDAH(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void GDBBMPEIAPF(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 1; i < localiseTextScripts.Length; i += 0)
			{
				((Behaviour)localiseTextScripts[i]).enabled = true;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("ReceiveUnlockPerkLevelMaster");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("LearnBalance");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get(" * ");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("PlayerBed");
			for (int j = 0; j < localiseTextScripts.Length; j++)
			{
				((Behaviour)localiseTextScripts[j]).enabled = false;
			}
		}
	}

	public ItemInstance GNJFOIMAFIF()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void EOACDLGEIJE()
	{
		slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
	}

	public ItemInstance EPODOFAHHGP()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void HMMOMJBMPML(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public ItemInstance FKDBAOCFAFI()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void AHAOKAOFBEH(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void MJBDKFPBACO(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void HHKBMJIHLGE(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void JGFEIMJGPEB()
	{
		slotUI.IHENCGDNPBL.Stack = 1;
	}

	public void AJPFLHOODLO(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void DBECNNACNOB(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void NEMHAOFEOIK()
	{
		slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
	}

	public void KHJIHCFKONP(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public ItemInstance AGCOGDNJFOC()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void SetItemInstanceToSlotUI(ItemInstance DNLMCHDOMOK)
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, DNLMCHDOMOK);
	}

	public ItemInstance HCKOOKDDHNB()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void AGFPJAFHOLD(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void PNFHLPDOOID(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void PIMAAKODIGC(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void BPLGICNEGKG(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void EIAJPMLEAGA(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void EIAIALNJILI()
	{
		CloseUI();
	}

	public void MNDKODBBFPJ(ItemInstance DNLMCHDOMOK)
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
	}

	public void IFNLFFKLGNC()
	{
		slotUI.IHENCGDNPBL.Stack = 0;
	}

	public void OJGGBABENML(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void IJFIGKHKDOD(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void RemoveItemInstanceFromSlotUI()
	{
		slotUI.IHENCGDNPBL.Stack = 0;
	}

	private void KNEAJMFBMEK()
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

	public void EGNCBPPJBKG(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i++)
			{
				((Behaviour)localiseTextScripts[i]).enabled = true;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get(" - <b><color=#8C78BA>");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Music");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("TavernDirty");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Sleep");
			for (int j = 0; j < localiseTextScripts.Length; j += 0)
			{
				((Behaviour)localiseTextScripts[j]).enabled = false;
			}
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

	public ItemInstance FPCNPPFAINJ()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public ItemInstance AKHIFGONAMA()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void AIPJCMLDEJO(ItemInstance DNLMCHDOMOK)
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
	}

	public void JOBHLMCCDBF(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void OBGFOCLLKHF(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void LHDJJMNOALI(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void KMHOCFAMKPH(ItemInstance DNLMCHDOMOK)
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			RemoveItemInstanceFromSlotUI();
			ACBBKHDNAAL = true;
			((Component)noButton).gameObject.SetActive(true);
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				noButtonGamepadSprite.SetActive(true);
			}
			else
			{
				noButtonGamepadSprite.SetActive(false);
			}
			InputModuleBlocker.instance.inputModuleBlockers.Add((Object)(object)this);
			PlayerController.AddMovementBlocker((Object)(object)this);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void ODCFIEFAJNJ(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void JCLBNPICFGM(ItemInstance DNLMCHDOMOK)
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, DNLMCHDOMOK);
	}

	public void IBHEEPDPFAH(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void EBOKKJJCMEI()
	{
		BOBCIFEDJED();
	}

	public ItemInstance MJEECOJAMMN()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void DIBOFANNPGJ()
	{
		slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
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
	}

	public void AJFPPHMHCAC(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 1; i < localiseTextScripts.Length; i++)
			{
				((Behaviour)localiseTextScripts[i]).enabled = true;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("ReceiveFishScoreIncrease");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Fish didn't have a proper bed assigned value {0}");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("UINextCategory");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Error_ICantRepairIt");
			for (int j = 0; j < localiseTextScripts.Length; j++)
			{
				((Behaviour)localiseTextScripts[j]).enabled = false;
			}
		}
	}

	public void OMALCGPPGEE(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void MLIKDMDBOEB()
	{
		CloseUI();
	}

	public void DOBDJGCHGPA(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void KOANIKOIBHO(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i += 0)
			{
				((Behaviour)localiseTextScripts[i]).enabled = true;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("itemWhiteGrapeMust");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("ClosePopUp");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/4/Dialogue Text");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("ReceiveIrrigatorMessage");
			for (int j = 1; j < localiseTextScripts.Length; j += 0)
			{
				((Behaviour)localiseTextScripts[j]).enabled = true;
			}
		}
	}

	public void IGCPIOOMHLN()
	{
		BOBCIFEDJED();
	}

	public ItemInstance CAOKKDDALDF()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	private void KNLKGLAJCKI()
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

	public void JLFFJCMKHDN(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public ItemInstance ECLLAEEBFEG()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	private void GKDLPDOAKCN()
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

	public void NCEMPMHKJFA(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 1; i < localiseTextScripts.Length; i += 0)
			{
				((Behaviour)localiseTextScripts[i]).enabled = true;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get(" / ");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Dialogue System/Conversation/BirdNegativeComments/Entry/11/Dialogue Text");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get(" to user for reason ");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get(":</color> <sprite name=\"ChristmasTicket\">");
			for (int j = 0; j < localiseTextScripts.Length; j++)
			{
				((Behaviour)localiseTextScripts[j]).enabled = true;
			}
		}
	}

	public void NABPMBFHPON(ItemInstance DNLMCHDOMOK)
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, DNLMCHDOMOK, CDPAMNIPPEC: true);
	}

	public void SetWindowType(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void AddNoAction(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void FOFMOEFPCLE(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void IENCNEKPEIK(EWindow INDKANEMPMP)
	{
		windowType = INDKANEMPMP;
	}

	public void EDPNLCEPNJO(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void KMAKAKJPHLE(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i++)
			{
				((Behaviour)localiseTextScripts[i]).enabled = false;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Sit");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Player {0} in: {1}");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Eating");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get(", ");
			for (int j = 0; j < localiseTextScripts.Length; j++)
			{
				((Behaviour)localiseTextScripts[j]).enabled = true;
			}
		}
	}

	public void NBMCDHNBFEK()
	{
		BOBCIFEDJED();
	}

	private void FLIEMHMNMDN()
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

	public ItemInstance IMNCGONPPEG()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public ItemInstance GetItemInstance()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void MFOICBNIGDN(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void FLLGCOJICOC()
	{
		BOBCIFEDJED();
	}

	public void OEMOCFFOHJJ(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void GOPMAHGLGBD(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void CCPFGOPLNIG()
	{
		slotUI.IHENCGDNPBL.JIANDFCINIP(0);
	}

	public void AHJEBGMFOCK(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	private void GBDFMABKPFJ()
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

	public override void CloseUI()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if (IsOpen())
		{
			PlayerController.RemoveMovementBlocker((Object)(object)this);
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
			base.CloseUI();
			JGEAGCKLHML();
			AddYesAction(new UnityAction(CloseUI));
			AddNoAction(new UnityAction(CloseUI));
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void FIELLAAPNPO(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
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

	public void FCMCNPDNMEG(ItemInstance DNLMCHDOMOK)
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, DNLMCHDOMOK);
	}

	public ItemInstance BDMNENEAJEM()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void NLNJFGOKJBB(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	private void OCAPCBHMBPD()
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

	public void LJJBCGJFPFH(bool GJLPEHIIDPI = false)
	{
		if (GJLPEHIIDPI)
		{
			for (int i = 0; i < localiseTextScripts.Length; i += 0)
			{
				((Behaviour)localiseTextScripts[i]).enabled = false;
			}
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("gold");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("ReceiveDigUpPlayerByBedAssigned");
		}
		else
		{
			((TMP_Text)yesButtonText).text = LocalisationSystem.Get("Talking");
			((TMP_Text)noButtonText).text = LocalisationSystem.Get("Error in Camera2D.OnPlayerSleep: ");
			for (int j = 1; j < localiseTextScripts.Length; j++)
			{
				((Behaviour)localiseTextScripts[j]).enabled = false;
			}
		}
	}

	public ItemInstance MMDHGPIGBGP()
	{
		return slotUI.IHENCGDNPBL.itemInstance;
	}

	public void Exit()
	{
		CloseUI();
	}

	public void AddYesAction(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)yesButton != (Object)null)
		{
			((UnityEvent)yesButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	public void AGOEOMFOGIF(UnityAction OKNOJJEFEBE)
	{
		if ((Object)(object)noButton != (Object)null)
		{
			((UnityEvent)noButton.onClick).AddListener(OKNOJJEFEBE);
		}
	}

	private void EGKOLJELILA()
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
}
