using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public abstract class DialogueNPCBase : NPC, IInteractable, IProximity, IHoverable
{
	[CompilerGenerated]
	private sealed class JJFDHFFGKCC
	{
		public int entryID;

		internal bool HNLIHGGCGPG(DialogueEntry entry)
		{
			return entry.id == entryID;
		}
	}

	[CompilerGenerated]
	private sealed class IKJJMCNIHKP
	{
		public int entryID;

		internal bool JEKNDJKHLIJ(DialogueEntry entry)
		{
			return entry.id == entryID;
		}
	}

	public Action<bool> ConversationStarted = delegate
	{
	};

	public Action<bool> ConversationEnded = delegate
	{
	};

	public Action WalkToCompleted = delegate
	{
	};

	public CharacterName characterName;

	public GameObject content;

	public DialogueSystemTrigger dialogue;

	public EmotionsController emotionsController;

	public Shop shop;

	public string actorName;

	public bool inEvent;

	public bool inSpecialEvent;

	public bool inTutorial;

	public bool blockActionBar;

	public Collider2D visualCollider;

	public GameObject barkText;

	public bool onlyBarks;

	public OverrideDisplaySettings overrideDialogueSettings;

	public GameObject dialogueUIOverride;

	public DialogueActor dialogueActor;

	public bool barkDialogue;

	public bool inShop;

	public bool canTalk = true;

	public bool playerCanInteract = true;

	private bool JNIOKIKPCGD;

	private Coroutine BEGCPKOAJCP;

	[SerializeField]
	private GameObject newActivityBubble;

	[HideInInspector]
	public OnlineDialogueNPC onlineDialogue;

	[HideInInspector]
	public OnlineBaseNPC onlineNPC;

	public Vector2 targetWalkTo;

	public Direction endWalkDirection = Direction.Diagonal;

	public string endTriggerAnimation;

	public bool disable;

	public string dialogueEvent;

	protected int EEFMOIEIFDH = 1;

	public bool inBark;

	public bool inInteractiveBark;

	public bool noPortrait;

	public bool inInteractiveDialogue;

	public int entryId;

	public int[] responsesId;

	public string conversationTitle;

	public bool inResponse;

	public bool shoUI;

	public bool main;

	public StandardDialogueUI dialogueUiInUse;

	public bool playerShopping;

	public OnlineTalkingEmote talkingEmote;

	public bool onlineBarkDialogue;

	public bool mouseUpTrigger;

	public bool blockExitObserver;

	[SerializeField]
	protected Animator behaviour;

	private bool CDPAMNIPPEC = true;

	private float JMAHFBBELON;

	public static Dictionary<CharacterName, DialogueNPCBase> allNPCs = new Dictionary<CharacterName, DialogueNPCBase>();

	public static readonly int p_Inactive = AnimatorParameterCache.p_Inactive;

	public static readonly int p_Leaving = AnimatorParameterCache.p_Leaving;

	public static readonly int p_WaitingToServe = AnimatorParameterCache.p_WaitingToServe;

	public static readonly int p_WalkTo = AnimatorParameterCache.p_WalkTo;

	public static readonly int p_WaitEvent = AnimatorParameterCache.p_WaitEvent;

	public static readonly int p_Waiting = AnimatorParameterCache.p_Waiting;

	public static readonly int p_TakingDrink = AnimatorParameterCache.p_TakingDrink;

	public static readonly int p_TakingFood = AnimatorParameterCache.p_TakingFood;

	public static readonly int p_PreparingFood = AnimatorParameterCache.p_PreparingFood;

	public static readonly int p_SwitchingFood = AnimatorParameterCache.p_SwitchingFood;

	public static readonly int p_ThrowingSpikes = AnimatorParameterCache.p_ThrowingSpikes;

	public static readonly int p_ServingTableOrder = AnimatorParameterCache.p_ServingTableOrder;

	public static readonly int p_ServingCustomer = AnimatorParameterCache.p_ServingCustomer;

	public static readonly int p_HittingPlayer = AnimatorParameterCache.p_HittingPlayer;

	public int EHHOHCPHAAO
	{
		get
		{
			return EEFMOIEIFDH;
		}
		set
		{
			EEFMOIEIFDH = value;
		}
	}

	private IEnumerator CLGNMLCFDIA()
	{
		while (ShopUI.Get(EHHOHCPHAAO).IsOpen() || AnimalShopUI.Get(EHHOHCPHAAO).IsOpen())
		{
			yield return null;
		}
		playerShopping = false;
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.OnDialogueEnd(PIHIAKCIJLM: false);
		}
	}

	protected virtual void OnConversationStart(Transform actor)
	{
		InitDialogueStart();
		inUse = true;
		CommonReferences.GGFJGHHHEJC.SetExecute(EHHOHCPHAAO, JGJCFHPMKGF: false);
		if (!onlyBarks && !barkDialogue)
		{
			if (!MainUI.IsAnyUIOpen(1))
			{
				SelectObject.GetPlayer(1).DeselectObjectAndPlaceable();
			}
			if (GameManager.LocalCoop() && !MainUI.IsAnyUIOpen(2) && (Object)(object)SelectObject.GetPlayer(2) != (Object)null)
			{
				SelectObject.GetPlayer(2).DeselectObjectAndPlaceable();
			}
			DisablePlayerInputs();
			if (!GameManager.LocalCoop())
			{
				GameplayUI.GGFJGHHHEJC.canvasGroup.interactable = false;
				GameplayUI.GGFJGHHHEJC.canvasGroup.blocksRaycasts = false;
			}
			PlayerInputs.GetPlayer(EHHOHCPHAAO).SwitchMapCategoryNextFrame("UI");
			EGIMIPCBBLL();
			if (!inSpecialEvent && !inTutorial && !DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).cameraInEvent)
			{
				DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).DialogueCamController(JCFILMOCAKK: true);
				DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).AOKFMJNDDPF = true;
			}
			CommonReferences.GGFJGHHHEJC.SetinDialogue(EHHOHCPHAAO, MCOIFGJGFGF: true);
			((MonoBehaviour)this).StartCoroutine(EIHLBMBDPNN());
			if (!GameManager.LocalCoop() && !OnlineManager.PlayingOnline())
			{
				WorldTime.BlockTickTime(KLMDEPBMACA: true);
			}
		}
		ButtonsContext.GetPlayer(EHHOHCPHAAO).ResetButtons();
		if (inInteractiveDialogue)
		{
			ConversationStarted(obj: true);
		}
	}

	protected virtual void OnConversationResponseMenu(Response[] responses)
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineDialogue != (Object)null)
		{
			responsesId = new int[responses.Length];
			for (int i = 0; i < responses.Length; i++)
			{
				responsesId[i] = responses[i].destinationEntry.id;
			}
			inResponse = true;
			onlineDialogue.OnConversationResponseMenuStart(responsesId);
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return false;
	}

	public void DisableDialogue(bool CKJIHLIFPMF = false)
	{
		canTalk = false;
		if (CKJIHLIFPMF && (Object)(object)talkingEmote != (Object)null)
		{
			talkingEmote.EnableEmote();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		EnableDialogue();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IHDMNEOKDOB));
		DialogueManager.SubtitleError = (Action)Delegate.Combine(DialogueManager.SubtitleError, new Action(NLNCOFGDPBP));
		if (characterName != 0 && !allNPCs.ContainsKey(characterName))
		{
			allNPCs.Add(characterName, this);
		}
	}

	private IEnumerator OMHLBLLPMCD()
	{
		yield return CommonReferences.wait03;
		EnableDialogue();
	}

	public virtual void InitDialogueStart()
	{
		if (!mouseUpTrigger)
		{
			return;
		}
		inInteractiveDialogue = true;
		main = true;
		DisableDialogue();
		if (OnlineManager.PlayingOnline())
		{
			if (Object.op_Implicit((Object)(object)onlineDialogue))
			{
				onlineDialogue.OnDialogueStart(inInteractiveDialogue);
			}
			if ((Object)(object)OnlineDialogueManager.instance != (Object)null && (Object)(object)dialogueActor != (Object)null)
			{
				OnlineDialogueManager.instance.SendCurrentActorsInDialogue(((Asset)DialogueManager.masterDatabase.GetActor(dialogueActor.actor)).id);
			}
		}
		mouseUpTrigger = false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	protected virtual void OnBarkEnd(Transform actor)
	{
		((MonoBehaviour)this).StartCoroutine(NDLLBPMOKFN());
	}

	public void BarkBuzzDoor(string GAGJHPKONIC, string PCFDMAMCBIL, int HPFABKHAKCN, Transform ONGMJBKLFFL, bool CDPAMNIPPEC = true)
	{
		DialogueLua.SetVariable(PCFDMAMCBIL, (object)HPFABKHAKCN);
		DialogueManager.Bark(GAGJHPKONIC, ONGMJBKLFFL);
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			onlineDialogue.SendBarkBuzzDoorInfo(GAGJHPKONIC, PCFDMAMCBIL, HPFABKHAKCN);
		}
	}

	private void IDFJKCICJFG()
	{
		entryId = 0;
		responsesId = null;
		conversationTitle = "";
		inResponse = false;
	}

	public Subtitle GetSubtitleFromDatabase(string NMMGHIJNPJG, int CDNIPNCNOMB)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		DialogueDatabase masterDatabase = DialogueManager.MasterDatabase;
		if ((Object)(object)masterDatabase == (Object)null)
		{
			Debug.LogError((object)"No se encontró la base de datos.");
			return null;
		}
		Conversation conversation = masterDatabase.GetConversation(NMMGHIJNPJG);
		if (conversation == null)
		{
			Debug.LogError((object)("No se encontró la conversación con el título '" + NMMGHIJNPJG + "'. " + (object)((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			return null;
		}
		DialogueEntry val = conversation.dialogueEntries.Find((DialogueEntry entry) => entry.id == CDNIPNCNOMB);
		if (val == null)
		{
			Debug.LogError((object)$"No se encontró una entrada con ID {CDNIPNCNOMB} en la conversación '{NMMGHIJNPJG}'.");
			return null;
		}
		Actor actor = masterDatabase.GetActor(val.ActorID);
		CharacterInfo val2 = new CharacterInfo(val.ActorID, ((Asset)actor).Name, ((Component)this).transform, (CharacterType)1, actor.GetPortraitSprite());
		Actor actor2 = masterDatabase.GetActor(val.ConversantID);
		CharacterInfo val3 = new CharacterInfo(val.ConversantID, ((Asset)actor2).Name, (Transform)null, (CharacterType)0, actor2.GetPortraitSprite());
		return new Subtitle(val2, val3, new FormattedText(InputUtils.LPGJFAOKMNE(1, string.IsNullOrEmpty(val.currentLocalizedDialogueText) ? "" : val.currentLocalizedDialogueText), (Emphasis[])null, false, -1, true, false, 0, 0, 0, (string)null, -1, false), val.Sequence, val.ResponseMenuSequence, val);
	}

	public void CheckIfNewActivity(bool OGECKNMAJMI, bool CDPAMNIPPEC, bool NNDJFLDGKDL = false)
	{
		if (Object.op_Implicit((Object)(object)newActivityBubble) && newActivityBubble.activeInHierarchy != OGECKNMAJMI)
		{
			Debug.Log((object)("CheckIfNewActivity " + ((Object)((Component)this).gameObject).name + " " + OGECKNMAJMI));
			if (OGECKNMAJMI && NNDJFLDGKDL)
			{
				((MonoBehaviour)this).StartCoroutine(FNBKBPHDPNA());
			}
			else
			{
				newActivityBubble.SetActive(OGECKNMAJMI);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				onlineDialogue.SendEnableNewActivityBubble(OGECKNMAJMI);
			}
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void CheckPossibleStates(int JIIGOACEIKL)
	{
		DialogueLua.SetVariable("IsInBeach", (object)(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Beach));
		DialogueLua.SetVariable("IsRaining", (object)Weather.IsWeatherActive(Weather.WeatherType.Rain));
		DialogueLua.SetVariable("IsSunny", (object)(Weather.IsWeatherActive(Weather.WeatherType.Sunny) || Weather.IsWeatherActive(Weather.WeatherType.SunnyClouds)));
	}

	public void Bark(string GAGJHPKONIC, string PCFDMAMCBIL, string HPFABKHAKCN, bool CDPAMNIPPEC = true)
	{
		DialogueLua.SetVariable(PCFDMAMCBIL, (object)HPFABKHAKCN);
		DialogueManager.Bark(GAGJHPKONIC, ((Component)this).transform);
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			onlineDialogue.SendBarkInfo(GAGJHPKONIC, PCFDMAMCBIL, HPFABKHAKCN);
		}
	}

	public void DisablePlayerInputs()
	{
		PlayerInputs.DisableKeyboardInputs(EHHOHCPHAAO, (MonoBehaviour)(object)this);
		PlayerController.AddMovementBlocker(EHHOHCPHAAO, (Object)(object)this, ANJCLPDCJHL: true);
	}

	public void DisableTalk(bool CAPPDENDLKP)
	{
		if (CAPPDENDLKP)
		{
			canTalk = false;
			JNIOKIKPCGD = true;
		}
		else
		{
			canTalk = true;
			JNIOKIKPCGD = false;
		}
	}

	public void StartDialogueById()
	{
		if (!(this is AmosNPC) && !(this is ChuckNPC) && !(this is WoodyNPC) && !(this is PetraNPC) && !(this is AgathaNPC) && !(this is LiaNPC) && !(this is RhiaNPC) && !(this is KujakuNPC) && !(this is HallmundNPC) && !(this is NessyNPC) && !(this is MarcusNPC))
		{
			DisableDialogue();
		}
		Debug.Log((object)("StartDialogueById " + conversationTitle + " " + entryId + " " + ((Object)((Component)this).gameObject).name));
		dialogue.conversation = conversationTitle;
		barkDialogue = true;
		KNEHCFHGDFC();
		SelectDialogueUI();
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	private IEnumerator NDLLBPMOKFN()
	{
		yield return CommonReferences.wait03;
		inBark = false;
		inInteractiveBark = false;
	}

	public virtual bool MouseUp(int JIIGOACEIKL)
	{
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inEvent && canTalk)
			{
				if (IsAvailableByProximity(JIIGOACEIKL))
				{
					if (BEGCPKOAJCP == null)
					{
						BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KACNGNMNFNK(JIIGOACEIKL));
					}
					return true;
				}
				Debug.LogError((object)"Interaction was initiated, but the object is not in range. Only possible in online.");
			}
			else if (OnlineManager.PlayingOnline() && !canTalk && !inUse && !inBark)
			{
				StartObserverDialogue(JIIGOACEIKL);
			}
		}
		return false;
	}

	public abstract DialogueNPCBase GetInstance();

	protected virtual void ObserverConversationStart()
	{
		inUse = true;
		CommonReferences.GGFJGHHHEJC.SetExecute(EHHOHCPHAAO, JGJCFHPMKGF: false);
		if (!onlyBarks && !barkDialogue)
		{
			if (!MainUI.IsAnyUIOpen(1))
			{
				SelectObject.GetPlayer(1).DeselectObjectAndPlaceable();
			}
			DisablePlayerInputs();
			if (!GameManager.LocalCoop())
			{
				GameplayUI.GGFJGHHHEJC.canvasGroup.interactable = false;
				GameplayUI.GGFJGHHHEJC.canvasGroup.blocksRaycasts = false;
			}
			EGIMIPCBBLL();
			if (!inSpecialEvent && !inTutorial && !DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).cameraInEvent)
			{
				DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).DialogueCamController(JCFILMOCAKK: true);
				DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).AOKFMJNDDPF = true;
			}
			CommonReferences.GGFJGHHHEJC.SetinDialogue(EHHOHCPHAAO, MCOIFGJGFGF: true);
			((MonoBehaviour)this).StartCoroutine(EIHLBMBDPNN());
		}
		ButtonsContext.GetPlayer(EHHOHCPHAAO).ResetButtons();
	}

	private void IHDMNEOKDOB()
	{
		try
		{
			DialogueManager.StopAllConversations();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in DialogueNPCBase.EndConversation: " + ex.Message));
		}
	}

	protected override void OnDestroy()
	{
		if (!Application.isPlaying || GameManager.CIOEICMHCCK)
		{
			return;
		}
		allNPCs.Remove(characterName);
		if (!GameManager.leavingTheGame)
		{
			base.OnDestroy();
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IHDMNEOKDOB));
			}
			DialogueManager.SubtitleError = (Action)Delegate.Remove(DialogueManager.SubtitleError, new Action(NLNCOFGDPBP));
		}
	}

	public void Bark(string GAGJHPKONIC, string PCFDMAMCBIL, int HPFABKHAKCN, bool CDPAMNIPPEC = true)
	{
		DialogueLua.SetVariable(PCFDMAMCBIL, (object)HPFABKHAKCN);
		DialogueManager.Bark(GAGJHPKONIC, ((Component)this).transform);
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			onlineDialogue.SendBarkInfo(GAGJHPKONIC, PCFDMAMCBIL, HPFABKHAKCN);
		}
	}

	protected virtual void Update()
	{
		if (OnlineManager.PlayingOnline() && CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && IsAvailableByProximity(1) && !main && inUse && !onlyBarks && !barkDialogue && !blockExitObserver && !Intro.InProgress() && Time.time >= JMAHFBBELON && ((PlayerInputs.IsGamepadActive(1) && PlayerInputs.GetPlayer(1).GetButtonUp("Cancel")) || PlayerInputs.GetPlayer(1).GetButtonUp("Pause")))
		{
			if (Object.op_Implicit((Object)(object)dialogueUiInUse))
			{
				((AbstractDialogueUI)dialogueUiInUse).Close();
			}
			ObserverConversationEnd();
		}
	}

	public virtual bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!playerShopping && !JNIOKIKPCGD)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inEvent && canTalk)
			{
				if (IsAvailableByProximity(JIIGOACEIKL))
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Talk"));
					return true;
				}
			}
			else if (!canTalk && !inUse && !main && IsAvailableByProximity(JIIGOACEIKL))
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Listen"));
				return true;
			}
		}
		ButtonsContext.GetPlayer(EHHOHCPHAAO).ResetButtons();
		return false;
	}

	public void EnableDialogue()
	{
		if (inUse && !onlyBarks && !barkDialogue && !main)
		{
			((AbstractDialogueUI)dialogueUiInUse).Close();
			ObserverConversationEnd();
			inResponse = false;
		}
		if (!JNIOKIKPCGD)
		{
			canTalk = true;
		}
		if ((Object)(object)talkingEmote != (Object)null)
		{
			talkingEmote.DisableEmote();
		}
	}

	protected virtual void OnConversationEnd(Transform actor)
	{
		if (!onlyBarks && !barkDialogue)
		{
			if (!DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).cameraInEvent)
			{
				DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).DialogueCamController(JCFILMOCAKK: false);
				DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).AOKFMJNDDPF = false;
			}
			GameplayUI.GGFJGHHHEJC.canvasGroup.interactable = true;
			GameplayUI.GGFJGHHHEJC.canvasGroup.blocksRaycasts = true;
			CommonReferences.GGFJGHHHEJC.SetinDialogue(EHHOHCPHAAO, MCOIFGJGFGF: false);
			WorldTime.BlockTickTime(KLMDEPBMACA: false);
		}
		inUse = false;
		inInteractiveDialogue = false;
		if (ShopUI.Get(EHHOHCPHAAO).IsOpen() || AnimalShopUI.Get(EHHOHCPHAAO).IsOpen())
		{
			EnablePlayerInputs();
			if (OnlineManager.PlayingOnline() && (Object)(object)onlineDialogue != (Object)null)
			{
				playerShopping = true;
				onlineDialogue.OnDialogueEnd(PIHIAKCIJLM: true);
				((MonoBehaviour)this).StartCoroutine(CLGNMLCFDIA());
			}
		}
		else if (OnlineManager.PlayingOnline() && (Object)(object)onlineDialogue != (Object)null)
		{
			playerShopping = false;
			if (CDPAMNIPPEC)
			{
				onlineDialogue.OnDialogueEnd(PIHIAKCIJLM: false);
			}
			CDPAMNIPPEC = true;
		}
		if (!onlyBarks && !barkDialogue)
		{
			if (MainUI.IsAnyUIOpen(EHHOHCPHAAO))
			{
				UISelectionManager.GetPlayer(EHHOHCPHAAO).Select(UISelectionManager.GetPlayer(EHHOHCPHAAO).lastSelection);
			}
			if (!MainUI.IsAnyUIOpen(EHHOHCPHAAO))
			{
				FEOAGMIHEND();
				PlayerInputs.GetPlayer(EHHOHCPHAAO).SwitchMapCategoryNextFrame("Game");
			}
			EnablePlayerInputs(OBGFLMGABKG: true);
			OnlineDialogueManager.instance.SendCurrentActorsInDialogue(0);
			((MonoBehaviour)this).StartCoroutine(OMHLBLLPMCD());
			main = false;
		}
		else
		{
			EnableDialogue();
		}
		noPortrait = false;
		main = false;
		ConversationEnded(obj: true);
		blockExitObserver = false;
		dialogue.startConversationEntryID = -1;
		IDFJKCICJFG();
	}

	private IEnumerator FNBKBPHDPNA()
	{
		yield return CommonReferences.wait2;
		newActivityBubble.SetActive(true);
	}

	public void StartConversation(int JIIGOACEIKL, string GJPFJPDIBDP, bool FLHBPHPKIML = false)
	{
		if (!FLHBPHPKIML)
		{
			StopConversation();
			mouseUpTrigger = true;
			EHHOHCPHAAO = JIIGOACEIKL;
			SelectDialogueUI(JIIGOACEIKL);
			dialogue.conversation = GJPFJPDIBDP;
			dialogue.OnUse();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KFKAPPJICEN(JIIGOACEIKL, GJPFJPDIBDP));
		}
	}

	private IEnumerator EIHLBMBDPNN()
	{
		yield return CommonReferences.wait03;
		if (MainUI.IsAnyUIOpen(EHHOHCPHAAO))
		{
			UISelectionManager.GetPlayer(EHHOHCPHAAO).Deselect();
			ItemTooltip.Get(EHHOHCPHAAO).SetVisible(MDIKPGGBNLI: false);
		}
	}

	private IEnumerator KACNGNMNFNK(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDialogue))
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		NJJCCIBDAPM();
		if (!onlyBarks)
		{
			SelectDialogueUI(JIIGOACEIKL);
		}
		CheckPossibleStates(JIIGOACEIKL);
		EHHOHCPHAAO = JIIGOACEIKL;
		mouseUpTrigger = true;
		yield return null;
		if ((Object)(object)dialogue != (Object)null)
		{
			dialogue.OnUse();
		}
		else
		{
			Debug.LogError((object)("Dialogue Trigger is null in " + ((Object)((Component)this).gameObject).name));
		}
		BEGCPKOAJCP = null;
	}

	public IEnumerator StartObserverDialogueWhenItIsPossible(int JIIGOACEIKL)
	{
		while (canTalk)
		{
			yield return null;
		}
		yield return null;
		yield return null;
		Debug.Log((object)("StartObserverDialogueWhenItIsPossible " + ((Object)((Component)this).gameObject).name));
		StartObserverDialogue(JIIGOACEIKL, MCJHGHLBBGL: true);
	}

	public void EnablePlayerInputs(bool OBGFLMGABKG = false)
	{
		PlayerInputs.EnableKeyboardInputs(EHHOHCPHAAO, (MonoBehaviour)(object)this, OBGFLMGABKG);
		PlayerController.RemoveMovementBlocker(EHHOHCPHAAO, (Object)(object)this);
	}

	public virtual void CheckExclamationSendOnline(bool sendOnline)
	{
	}

	protected virtual void ObserverConversationEnd()
	{
		Debug.Log((object)("ObserverConversationEnd " + ((Object)((Component)this).gameObject).name));
		if (!onlyBarks && !barkDialogue)
		{
			if (!DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).cameraInEvent)
			{
				DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).DialogueCamController(JCFILMOCAKK: false);
				DialogueCameraTarget.GetPlayer(EHHOHCPHAAO).AOKFMJNDDPF = false;
			}
			GameplayUI.GGFJGHHHEJC.canvasGroup.interactable = true;
			GameplayUI.GGFJGHHHEJC.canvasGroup.blocksRaycasts = true;
			CommonReferences.GGFJGHHHEJC.SetinDialogue(EHHOHCPHAAO, MCOIFGJGFGF: false);
			WorldTime.BlockTickTime(KLMDEPBMACA: false);
		}
		inUse = false;
		inInteractiveDialogue = false;
		if (!onlyBarks && !barkDialogue)
		{
			if (MainUI.IsAnyUIOpen(EHHOHCPHAAO))
			{
				UISelectionManager.GetPlayer(EHHOHCPHAAO).Select(UISelectionManager.GetPlayer(EHHOHCPHAAO).lastSelection);
			}
			if (!MainUI.IsAnyUIOpen(EHHOHCPHAAO))
			{
				FEOAGMIHEND();
				PlayerInputs.GetPlayer(EHHOHCPHAAO).SwitchMapCategoryNextFrame("Game");
			}
			EnablePlayerInputs(OBGFLMGABKG: true);
			OnlineDialogueManager.instance.SendCurrentActorsInDialogue(0);
		}
		noPortrait = false;
		main = false;
		blockExitObserver = false;
		ConversationEnded(obj: true);
		dialogue.startConversationEntryID = -1;
		IDFJKCICJFG();
	}

	public void Bark(string GAGJHPKONIC, bool CDPAMNIPPEC = true, bool IPIKKGONHEB = false)
	{
		DialogueManager.Bark(GAGJHPKONIC, ((Component)this).transform);
		if (OnlineManager.PlayingOnline() && ((OnlineManager.IsMasterClient() && CDPAMNIPPEC) || IPIKKGONHEB))
		{
			onlineDialogue.SendBarkInfo(GAGJHPKONIC);
		}
	}

	protected void FEOAGMIHEND()
	{
		if (!blockActionBar)
		{
			GameActionBarUI.Get(EHHOHCPHAAO).OpenUI();
		}
	}

	protected virtual void KNEHCFHGDFC()
	{
	}

	public void TriggerAnimation(string animationName)
	{
		if (OnlineManager.MasterOrOffline())
		{
			GetInstance().animationBase.SetTrigger(animationName);
		}
		else if ((Object)(object)onlineDialogue != (Object)null)
		{
			onlineDialogue.SendTriggerAnimation(animationName);
		}
	}

	private IEnumerator OKGKLNLNFJD(string KJJCCBADCJM, int JIIGOACEIKL, bool DHELBHAICMM)
	{
		StopConversation();
		yield return null;
		mouseUpTrigger = true;
		EHHOHCPHAAO = JIIGOACEIKL;
		barkDialogue = DHELBHAICMM;
		dialogue.conversation = KJJCCBADCJM;
		SelectDialogueUI(JIIGOACEIKL);
		dialogue.OnUse();
	}

	protected virtual void OnBarkStart(Transform actor)
	{
		inBark = true;
	}

	private IEnumerator KFKAPPJICEN(int JIIGOACEIKL, string GJPFJPDIBDP)
	{
		StopConversation();
		yield return CommonReferences.wait03;
		mouseUpTrigger = true;
		EHHOHCPHAAO = JIIGOACEIKL;
		SelectDialogueUI(JIIGOACEIKL);
		Debug.Log((object)("DelayStartConversation " + inSpecialEvent + " " + ((Object)((Component)this).gameObject).name));
		dialogue.conversation = GJPFJPDIBDP;
		dialogue.OnUse();
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	protected virtual void NJJCCIBDAPM()
	{
	}

	protected void EGIMIPCBBLL()
	{
		GameActionBarUI.Get(EHHOHCPHAAO).CloseUI();
	}

	public void ChangeState(int NJHMBMGKCPL)
	{
		if ((Object)(object)behaviour != (Object)null)
		{
			behaviour.SetTrigger(NJHMBMGKCPL);
		}
	}

	protected virtual void OnConversationLine(Subtitle subtitle)
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineDialogue != (Object)null && (!canTalk || onlineBarkDialogue) && main)
		{
			Debug.Log((object)("OnConversationLine BarkDialogue " + ((Object)((Component)this).gameObject).name + " " + subtitle.dialogueEntry.id), (Object)(object)((Component)this).gameObject);
			entryId = subtitle.dialogueEntry.id;
			inResponse = false;
			onlineDialogue.OnConversationLineStart(DialogueManager.MasterDatabase.GetConversation(subtitle.dialogueEntry.conversationID).Title, entryId, onlineBarkDialogue);
		}
	}

	public void StartTutorialDialogue(string KJJCCBADCJM, int JIIGOACEIKL = 1, bool DHELBHAICMM = false, bool CGKNJONAKGD = true)
	{
		if (CGKNJONAKGD)
		{
			MaiNPC.GGFJGHHHEJC.PlayerLookAtMai();
		}
		((MonoBehaviour)this).StartCoroutine(OKGKLNLNFJD(KJJCCBADCJM, JIIGOACEIKL, DHELBHAICMM));
	}

	public void CheckExclamation()
	{
		CheckExclamationSendOnline(sendOnline: true);
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public DialogueEntry GetDialogueEntryFromDatabase(string NMMGHIJNPJG, int CDNIPNCNOMB)
	{
		DialogueDatabase masterDatabase = DialogueManager.MasterDatabase;
		if ((Object)(object)masterDatabase == (Object)null)
		{
			Debug.LogError((object)"No se encontró la base de datos maestra.");
			return null;
		}
		Conversation conversation = masterDatabase.GetConversation(NMMGHIJNPJG);
		if (conversation == null)
		{
			Debug.LogError((object)("No se encontró la conversación con el título '" + NMMGHIJNPJG + "'."));
			return null;
		}
		DialogueEntry val = conversation.dialogueEntries.Find((DialogueEntry entry) => entry.id == CDNIPNCNOMB);
		if (val == null)
		{
			Debug.LogError((object)$"No se encontró una entrada con ID {CDNIPNCNOMB} en la conversación '{NMMGHIJNPJG}'.");
			return null;
		}
		return val;
	}

	public void SelectDialogueUI(int JIIGOACEIKL = 0)
	{
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		if (!barkDialogue)
		{
			if (GameManager.LocalCoop())
			{
				if (JIIGOACEIKL != 0)
				{
					EHHOHCPHAAO = JIIGOACEIKL;
				}
				int num = ((!LocalCooperativeManager.instance.cameraFocusedOnOnePlayer) ? EHHOHCPHAAO : 0);
				if (noPortrait)
				{
					SceneReferences.GetSceneReferences().dialogueController.DialogueUI = (IDialogueUI)(object)SceneReferences.GetSceneReferences().dialogueUINoPortrait[num];
				}
				else
				{
					SceneReferences.GetSceneReferences().dialogueController.DialogueUI = (IDialogueUI)(object)SceneReferences.GetSceneReferences().dialogueUI[num];
				}
			}
			else if (!noPortrait)
			{
				SceneReferences.GetSceneReferences().dialogueController.DialogueUI = (IDialogueUI)(object)SceneReferences.GetSceneReferences().dialogueUI[0];
				dialogueUiInUse = SceneReferences.GetSceneReferences().dialogueUI[0];
			}
			else
			{
				SceneReferences.GetSceneReferences().dialogueController.DialogueUI = (IDialogueUI)(object)SceneReferences.GetSceneReferences().dialogueUINoPortrait[0];
				dialogueUiInUse = SceneReferences.GetSceneReferences().dialogueUINoPortrait[0];
			}
			if ((Object)(object)overrideDialogueSettings != (Object)null)
			{
				if ((Object)(object)dialogueActor != (Object)null)
				{
					dialogueActor.standardDialogueUISettings.subtitlePanelNumber = (SubtitlePanelNumber)0;
				}
				overrideDialogueSettings.displaySettings.dialogueUI = null;
				((Behaviour)overrideDialogueSettings).enabled = false;
			}
			SceneReferences.GetSceneReferences().dialogueController.displaySettings.subtitleSettings.minSubtitleSeconds = 999f;
			SceneReferences.GetSceneReferences().dialogueController.displaySettings.inputSettings.alwaysForceResponseMenu = true;
			SceneReferences.GetSceneReferences().dialogueController.displaySettings.inputSettings.responseTimeout = 0f;
		}
		else if ((Object)(object)overrideDialogueSettings != (Object)null)
		{
			if ((Object)(object)dialogueActor != (Object)null)
			{
				dialogueActor.standardDialogueUISettings.subtitlePanelNumber = (SubtitlePanelNumber)2;
			}
			dialogueUiInUse = null;
			((Behaviour)overrideDialogueSettings).enabled = true;
			overrideDialogueSettings.displaySettings.dialogueUI = dialogueUIOverride;
			SceneReferences.GetSceneReferences().dialogueController.displaySettings.subtitleSettings.minSubtitleSeconds = 5f;
		}
		else
		{
			Debug.LogError((object)"Override Dialogue Settings NULL!!");
		}
	}

	public Response GetResponseFromDatabase(int JCLMJGDIFCI)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		DialogueEntry dialogueEntryFromDatabase = GetDialogueEntryFromDatabase(conversationTitle, JCLMJGDIFCI);
		return new Response(new FormattedText((string)null, (Emphasis[])null, false, -1, true, false, 0, 0, 0, (string)null, -1, false)
		{
			text = InputUtils.LPGJFAOKMNE(1, (dialogueEntryFromDatabase != null) ? dialogueEntryFromDatabase.currentLocalizedDialogueText : "")
		}, dialogueEntryFromDatabase, true);
	}

	public void StopConversation(bool BGKCHMNJBLJ = true)
	{
		if (DialogueManager.instance.activeConversations.Count <= 0)
		{
			return;
		}
		for (int num = DialogueManager.instance.activeConversations.Count - 1; num >= 0; num--)
		{
			if (DialogueManager.instance.activeConversations[num] != null && (Object)(object)DialogueManager.instance.activeConversations[num].actor != (Object)null && ((Object)DialogueManager.instance.activeConversations[num].actor).name == ((Object)((Component)this).gameObject).name)
			{
				Debug.Log((object)("Stopping conversation with " + ((Object)((Component)this).gameObject).name));
				CDPAMNIPPEC = BGKCHMNJBLJ;
				DialogueManager.instance.activeConversations[num].conversationController.Close();
			}
		}
		IDFJKCICJFG();
	}

	public void StartObserverDialogue(int JIIGOACEIKL, bool MCJHGHLBBGL = false)
	{
		Debug.Log((object)("StartObserverDialogue " + ((Object)((Component)this).gameObject).name + " " + conversationTitle + " " + entryId));
		if (GetSubtitleFromDatabase(conversationTitle, entryId) == null)
		{
			return;
		}
		blockExitObserver = MCJHGHLBBGL;
		JMAHFBBELON = Time.time + 2f;
		barkDialogue = false;
		SelectDialogueUI(JIIGOACEIKL);
		main = false;
		((AbstractDialogueUI)dialogueUiInUse).Open();
		((AbstractDialogueUI)dialogueUiInUse).HideSubtitle(GetSubtitleFromDatabase(conversationTitle, entryId));
		((AbstractDialogueUI)dialogueUiInUse).ShowSubtitle(GetSubtitleFromDatabase(conversationTitle, entryId));
		if (inResponse)
		{
			Response[] array = (Response[])(object)new Response[responsesId.Length];
			for (int i = 0; i < responsesId.Length; i++)
			{
				array[i] = GetResponseFromDatabase(responsesId[i]);
			}
			((AbstractDialogueUI)dialogueUiInUse).HideResponses();
			((AbstractDialogueUI)dialogueUiInUse).ShowResponses(GetSubtitleFromDatabase(conversationTitle, entryId), array, 0f);
		}
		ObserverConversationStart();
		if ((Object)(object)OnlineDialogueManager.instance != (Object)null)
		{
			OnlineDialogueManager.instance.SendCurrentActorsInDialogue(((Asset)DialogueManager.masterDatabase.GetActor(dialogueActor.actor)).id);
		}
	}

	public virtual bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void MIHIENPCLFM(string JMAIDGLIONC)
	{
		emotionsController.StartEmotion(JMAIDGLIONC);
	}

	protected void NLNCOFGDPBP()
	{
		if (!barkDialogue && inUse)
		{
			Debug.LogError((object)"Player was stuck due to dialogue system error, freeing player.");
			((MonoBehaviour)this).StopAllCoroutines();
			StopConversation();
			EnablePlayerInputs();
			FEOAGMIHEND();
		}
	}
}
