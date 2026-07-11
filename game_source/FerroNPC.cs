using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FerroNPC : DialogueNPCBase
{
	private static FerroNPC IADEMLIIDPC;

	public SimpleAnimationController simpleAnimation;

	public AnimationController animationController;

	public float timeBarks;

	public bool ferroEvent;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "FerroProgress";

	public static FerroNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void HFLCAILNOHC()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GNDGOIENBNA(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void OAGCLGKAMFM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GNDGOIENBNA(targetWalkTo, endWalkDirection);
	}

	public void GNDGOIENBNA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.JDHMPOJKOLF(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OAGCLGKAMFM));
		walkTo.NOFKEMGPFEO();
	}

	private void MNFCKONOLCB()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(LBPGLJOGDMK));
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	public void KPJEDOPKFCO()
	{
		FerroShopUI.Get(MLPCDJPLBAC().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void KIBIHBFJOJH(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NBFIDOGMLOK(emotion);
	}

	private void Start()
	{
		SelectDialogueUI();
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void EEBOKKANBEM(string emotion)
	{
		MLPCDJPLBAC().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void CCBBHBKBKGM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.OGLJDLEGJAA(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OAGCLGKAMFM));
		walkTo.NOFKEMGPFEO();
	}

	private void BGPGIOMKKAO()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void BPHNOMLFBCK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		int hKKKNMIKPCM = HKKKNMIKPCM;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			string hDFMHCKKJJG = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
		}
	}

	private void LBPGLJOGDMK()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LBPGLJOGDMK));
	}

	private void MOFILLPHDPH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	public void OnActionComplete()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(1, GGFJGHHHEJC.dialogueEvent);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void DIPFMNJEKBI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (MineManager.GGFJGHHHEJC.unlockedLevels >= 6)
		{
			DialogueLua.SetVariable("BombShopDisable", (object)true);
		}
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (ferroEvent)
		{
			dialogue.conversation = "HotBath/Ferro Talk";
			return;
		}
		if (CommonReferences.GGFJGHHHEJC.eventNum[5] == 1)
		{
			dialogue.conversation = "Miners/Mine/Ferro/Explosion";
			return;
		}
		if (!EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			dialogue.conversation = "Miners/Camp/Ferro/Talk";
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 1)
		{
			dialogue.conversation = "Miners/Mine/Ferro/Intro";
		}
		else
		{
			dialogue.conversation = "Miners/Mine/Ferro/Stand";
		}
	}

	public override void CheckExclamationSendOnline(bool sendOnline)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 1 && CommonReferences.GGFJGHHHEJC.eventNum[5] != 1 && !ferroEvent)
			{
				GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline);
				return;
			}
		}
		GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, sendOnline);
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.FNNPPBDFBCI(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.PEHELKCIECB();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	[SpecialName]
	public static FerroNPC MLPCDJPLBAC()
	{
		return IADEMLIIDPC;
	}

	public void EFMFKHABHDH()
	{
		FerroShopUI.PCEEOGGDBFB(MLPCDJPLBAC().EHHOHCPHAAO).OpenUI();
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void BPCEKAMDJBF()
	{
		FerroShopUI.FFBJPAJKOJH(MLPCDJPLBAC().EHHOHCPHAAO).OpenUI();
	}

	public void ResetBombVariable()
	{
		CommonReferences.GGFJGHHHEJC.eventNum[5] = 0;
		if (OnlineManager.PlayingOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendResetBombVariable();
		}
	}

	private void MCMKNBIBDFF()
	{
		SelectDialogueUI();
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(LBPGLJOGDMK));
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!playerCanInteract)
		{
			return false;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void OpenShopUI()
	{
		FerroShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	private void JBABHOJPFPG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DIPFMNJEKBI();
		}
	}

	private void DIKPOHPGNLG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void EBLEAJFOEJL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MLPCDJPLBAC().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = true;
			MLPCDJPLBAC().mouseUpTrigger = false;
			MLPCDJPLBAC().StartConversation(0, MLPCDJPLBAC().dialogueEvent, FLHBPHPKIML: true);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Left;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}
}
