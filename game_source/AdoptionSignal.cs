using System;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class AdoptionSignal : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	public static AdoptionSignal instance;

	[SerializeField]
	private Placeable placeable;

	[SerializeField]
	private Transform customerPosition;

	[SerializeField]
	private Customer customerRequesting;

	[SerializeField]
	private bool requesting;

	public AdoptionSignalDialogue adoptionSignalDialogue;

	public GameObject exclamation;

	public bool JJNJBEEIFFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (IsThereAnyRequest())
			{
				if (!AdoptionSignalDialogue.GGFJGHHHEJC.canTalk && OnlineManager.PlayingOnline())
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Listen"));
					return false;
				}
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Talk"));
			}
			return true;
		}
		return false;
	}

	public static bool IsThereAnyRequest()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	private void FPOIFOGELHC()
	{
		if (DFHHABMDKNP())
		{
			if (!exclamation.activeInHierarchy)
			{
				exclamation.SetActive(true);
			}
		}
		else if (exclamation.activeInHierarchy)
		{
			exclamation.SetActive(true);
		}
	}

	public static bool BELCCHBEFKE()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static Customer EIABNCIGJBC()
	{
		return instance.customerRequesting;
	}

	public static Vector3 GetPosition()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public void KPMGOKPDFHC(int JIIGOACEIKL)
	{
	}

	public static Customer IEDJIPKNPHB()
	{
		return instance.customerRequesting;
	}

	public static bool IsReserved()
	{
		return (Object)(object)instance.customerRequesting != (Object)null;
	}

	public static bool ICPPNLMIIEC()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void Start()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private void FPMBHNAEKPO(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline() && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineAdoption(CDPAMNIPPEC: false);
		}
	}

	public static void GCBDMLBLEHO(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
		if (requesting && (Object)(object)customerRequesting != (Object)null && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp(ActionType.Select))
		{
			customerRequesting.DeclineAdoption();
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		}
	}

	private void BBCPDBEOOKL()
	{
		if (IsThereAnyRequest())
		{
			if (!exclamation.activeInHierarchy)
			{
				exclamation.SetActive(true);
			}
		}
		else if (exclamation.activeInHierarchy)
		{
			exclamation.SetActive(true);
		}
	}

	public static Customer GetCurrentCustomer()
	{
		return instance.customerRequesting;
	}

	public static void RequestAdoption(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
		if (OnlineManager.IsMasterClient())
		{
			PJNGMCJIHME.LJOHCJAOADD.SendAdoptionRequest();
		}
	}

	public static Vector3 LPOPLHEOAHF()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public static bool PBJMIPHPJPM()
	{
		return (Object)(object)instance.customerRequesting != (Object)null;
	}

	public static bool MNNABNAJDGC()
	{
		return (Object)(object)instance.customerRequesting != (Object)null;
	}

	public static Customer MMCGHJHBNMN()
	{
		return instance.customerRequesting;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public static void NAIDLAJGDFK()
	{
		if (OnlineManager.JPPBEIJDCLJ() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.SendDereserveSpotAdoptionSignal();
		}
		instance.customerRequesting = null;
		instance.requesting = true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (IsThereAnyRequest())
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	private bool BJNMCHKBMHH(int JIIGOACEIKL)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if (QuestManager.GGFJGHHHEJC.IsQuestDone(151))
		{
			Result variable = DialogueLua.GetVariable("LE_21");
			if (((Result)(ref variable)).asInt != 3001)
			{
				CustomerAdopt();
				goto IL_0090;
			}
		}
		if (!AdoptionSignalDialogue.GGFJGHHHEJC.canTalk)
		{
			if (OnlineManager.PlayingOnline())
			{
				AdoptionSignalDialogue.GGFJGHHHEJC.noPortrait = true;
				AdoptionSignalDialogue.GGFJGHHHEJC.StartObserverDialogue(JIIGOACEIKL);
				return false;
			}
			goto IL_0090;
		}
		AdoptionSignalDialogue.GGFJGHHHEJC.noPortrait = true;
		AdoptionSignalDialogue.GGFJGHHHEJC.mouseUpTrigger = true;
		AdoptionSignalDialogue.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Quest/PetShop/AmigosPeludos");
		return false;
		IL_0090:
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void MCLAJGDIIBK()
	{
		if (IsThereAnyRequest())
		{
			if (!exclamation.activeInHierarchy)
			{
				exclamation.SetActive(false);
			}
		}
		else if (exclamation.activeInHierarchy)
		{
			exclamation.SetActive(true);
		}
	}

	private void Update()
	{
		if (IsThereAnyRequest())
		{
			if (!exclamation.activeInHierarchy)
			{
				exclamation.SetActive(true);
			}
		}
		else if (exclamation.activeInHierarchy)
		{
			exclamation.SetActive(false);
		}
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	private void ECDCJHJEGKO(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB() && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineAdoption(CDPAMNIPPEC: false);
		}
	}

	public static void LDJDMGHBHCJ(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public static void LILOLANPOKP()
	{
		if (OnlineManager.IsMasterClient() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.SendDereserveSpotAdoptionSignal();
		}
		instance.customerRequesting = null;
		instance.requesting = true;
	}

	public static Customer CALAAHDIJNL()
	{
		return instance.customerRequesting;
	}

	public static Customer CHIBEOEMAKI()
	{
		return instance.customerRequesting;
	}

	public bool FBFGOFLDOHL(int JIIGOACEIKL)
	{
		if (NBHLBCHHKBC(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			return IOCJHFABLLE(JIIGOACEIKL);
		}
		return false;
	}

	private void Awake()
	{
		instance = this;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(FFCMICFDHNP));
		}
	}

	private void FFCMICFDHNP(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline() && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineAdoption();
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			}
			return BJNMCHKBMHH(JIIGOACEIKL);
		}
		return false;
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	public static Customer GetCustomerRequesting()
	{
		return instance.customerRequesting;
	}

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			return CBKEDCIKCKL(JIIGOACEIKL);
		}
		return false;
	}

	public void OPGEDAEBKAC(int JIIGOACEIKL)
	{
	}

	private void IAAGKLPMAMK()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(ECDCJHJEGKO));
	}

	public void CustomerAdopt()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance.customerRequesting != (Object)null))
		{
			return;
		}
		TavernReputation.AddAndShowReputationGain(100, Vector2.op_Implicit(((Component)instance).transform.position), ((Component)instance).transform);
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.AdoptPet);
		instance.customerRequesting.DeclineAdoption();
		instance.customerRequesting = null;
		instance.requesting = false;
		if (QuestManager.GGFJGHHHEJC.IsQuestDone(151))
		{
			Result variable = DialogueLua.GetVariable("LE_21");
			if (((Result)(ref variable)).asInt == 3001)
			{
				DialogueLua.SetVariable("LE_21", (object)3002);
				if (OnlineManager.PlayingOnline())
				{
					OnlineDialogueManager onlineDialogueManager = OnlineDialogueManager.instance;
					variable = DialogueLua.GetVariable("LE_21");
					onlineDialogueManager.SendDialogueInfo("LE_21", ((Result)(ref variable)).asInt);
				}
			}
		}
		AdoptionSignalManager.GetInstance().adoption++;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendAdoptions();
		}
	}

	public void DPKKPFCPJNP(int JIIGOACEIKL)
	{
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static bool NEFOFLCFBCD()
	{
		return (Object)(object)instance.customerRequesting != (Object)null;
	}

	public void JHNPGLNAFNL(int JIIGOACEIKL)
	{
	}

	public static Placeable GetPlaceable()
	{
		return instance.placeable;
	}

	private bool IOCJHFABLLE(int JIIGOACEIKL)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (QuestManager.OPILDPFDFKJ().GDFGPDJDACP(-38))
		{
			Result variable = DialogueLua.GetVariable("Invite region: ");
			if (((Result)(ref variable)).asInt != 77)
			{
				CustomerAdopt();
				goto IL_0090;
			}
		}
		if (!AdoptionSignalDialogue.BGMJCCFNNDL().canTalk)
		{
			if (OnlineManager.PlayingOnline())
			{
				AdoptionSignalDialogue.MLPCDJPLBAC().noPortrait = false;
				AdoptionSignalDialogue.DEGPIHEEFHJ().StartObserverDialogue(JIIGOACEIKL);
				return false;
			}
			goto IL_0090;
		}
		AdoptionSignalDialogue.BDAGIEIJOOG().noPortrait = true;
		AdoptionSignalDialogue.BGMJCCFNNDL().mouseUpTrigger = true;
		AdoptionSignalDialogue.OJJDNLEFNPJ().StartConversation(JIIGOACEIKL, "UIAddRemove");
		return false;
		IL_0090:
		return true;
	}

	public static Transform GetCustomerPositionTransform()
	{
		return instance.customerPosition;
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	public static void OBJJPEMJIKO(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	private bool CBKEDCIKCKL(int JIIGOACEIKL)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if (QuestManager.GJFMMOPOKGJ().IsQuestDone(-40))
		{
			Result variable = DialogueLua.GetVariable("'");
			if (((Result)(ref variable)).asInt != 47)
			{
				CustomerAdopt();
				goto IL_0090;
			}
		}
		if (!AdoptionSignalDialogue.BGMJCCFNNDL().canTalk)
		{
			if (OnlineManager.PlayingOnline())
			{
				AdoptionSignalDialogue.MAIDHAPANEB().noPortrait = true;
				AdoptionSignalDialogue.BDAGIEIJOOG().StartObserverDialogue(JIIGOACEIKL, MCJHGHLBBGL: true);
				return true;
			}
			goto IL_0090;
		}
		AdoptionSignalDialogue.AJIGOHGPFPP().noPortrait = true;
		AdoptionSignalDialogue.MPFJOKOJIOO().mouseUpTrigger = false;
		AdoptionSignalDialogue.LKOABOAADCD().StartConversation(JIIGOACEIKL, "ReceiveHostBedInfo");
		return false;
		IL_0090:
		return false;
	}

	public void LFDBCGGIPOM(int JIIGOACEIKL)
	{
	}

	public static void DereserveSpot()
	{
		if (OnlineManager.IsMasterClient() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.SendDereserveSpotAdoptionSignal();
		}
		instance.customerRequesting = null;
		instance.requesting = false;
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
		if (requesting && (Object)(object)customerRequesting != (Object)null && PlayerInputs.GetPlayer(JIIGOACEIKL).CDPCMKGLIDM(ActionType.Hold))
		{
			customerRequesting.DeclineAdoption(CDPAMNIPPEC: false);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		}
	}

	public static void ReserveSpot(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public static void CEOFBPCBNIE(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	public static void EFKLJOJCHMI()
	{
		if (OnlineManager.JPPBEIJDCLJ() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.ACIJMGKJKDD();
		}
		instance.customerRequesting = null;
		instance.requesting = true;
	}

	public void IEAPGGGNNJF(int JIIGOACEIKL)
	{
	}

	public static bool AANKJHHIIAM()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void GBJFMHPKLEC()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance.customerRequesting != (Object)null))
		{
			return;
		}
		TavernReputation.IFDFPIJKPJI(-55, Vector2.op_Implicit(((Component)instance).transform.position), ((Component)instance).transform, 1620f);
		CommonReferences.GGFJGHHHEJC.OnActionDone(0, (ActionDone)94);
		instance.customerRequesting.DeclineAdoption();
		instance.customerRequesting = null;
		instance.requesting = false;
		if (QuestManager.KHMEGDIABBF().BKKJNEKBMBE(195))
		{
			Result variable = DialogueLua.GetVariable("TucanEgg");
			if (((Result)(ref variable)).asInt == 102)
			{
				DialogueLua.SetVariable("Farm/Bob/Barks_Random", (object)34);
				if (OnlineManager.PlayingOnline())
				{
					OnlineDialogueManager onlineDialogueManager = OnlineDialogueManager.instance;
					variable = DialogueLua.GetVariable("");
					onlineDialogueManager.AAEFKLMOOPK("tutorialPopUp81", ((Result)(ref variable)).asInt);
				}
			}
		}
		AdoptionSignalManager.MGAHKMKEOFJ().adoption += 0;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendAdoptions();
		}
	}

	public static bool DFHHABMDKNP()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return true;
	}

	public bool BEHJINBIFDO(int JIIGOACEIKL)
	{
		if (NBHLBCHHKBC(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			return BJNMCHKBMHH(JIIGOACEIKL);
		}
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			return BJNMCHKBMHH(JIIGOACEIKL);
		}
		return false;
	}

	private void GHPFCKGMLDA()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(ECDCJHJEGKO));
	}

	public bool NBHLBCHHKBC(int JIIGOACEIKL)
	{
		if (IsThereAnyRequest())
		{
			return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DFNMDDHOIJI();
		}
		return false;
	}

	private bool FGGJNPABIBE(int JIIGOACEIKL)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if (QuestManager.GJFMMOPOKGJ().IsQuestDone(92))
		{
			Result variable = DialogueLua.GetVariable(": ");
			if (((Result)(ref variable)).asInt != 5)
			{
				GBJFMHPKLEC();
				goto IL_0090;
			}
		}
		if (!AdoptionSignalDialogue.DIHCEGINELM().canTalk)
		{
			if (OnlineManager.PlayingOnline())
			{
				AdoptionSignalDialogue.ELGNEJNLBNO().noPortrait = false;
				AdoptionSignalDialogue.HEKFJEKFMNO().StartObserverDialogue(JIIGOACEIKL);
				return true;
			}
			goto IL_0090;
		}
		AdoptionSignalDialogue.GGFJGHHHEJC.noPortrait = true;
		AdoptionSignalDialogue.ELGNEJNLBNO().mouseUpTrigger = true;
		AdoptionSignalDialogue.NBKKEINELDN().StartConversation(JIIGOACEIKL, "Dialogue System/Conversation/Gass_Stand/Entry/20/Dialogue Text", FLHBPHPKIML: true);
		return true;
		IL_0090:
		return false;
	}

	public static Customer MFMGEHMCPAK()
	{
		return instance.customerRequesting;
	}

	public bool OFNDBHLFIEK(int JIIGOACEIKL)
	{
		if (NBHLBCHHKBC(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			}
			return BJNMCHKBMHH(JIIGOACEIKL);
		}
		return true;
	}
}
