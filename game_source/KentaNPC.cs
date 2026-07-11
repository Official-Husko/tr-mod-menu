using System;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class KentaNPC : DialogueNPCBase
{
	private static KentaNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "KentaProgress";

	public static KentaNPC GGFJGHHHEJC => IADEMLIIDPC;

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void JOODIPBADJN(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.EJPGFOEDPBG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMOPLHDOPKK));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MJDFKJBFMPO));
			walkTo.EHDKLBLKBEO();
		}
	}

	public new void CheckExclamation()
	{
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void DPHJPAMFAHK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
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
	}

	private void MJDFKJBFMPO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		CKBHDNNKEBI(targetWalkTo, endWalkDirection);
	}

	public void APPNAMFJDOA(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NBFIDOGMLOK(emotion);
	}

	public void CKBHDNNKEBI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GINPKMBGOFN(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMOPLHDOPKK));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KJMDNKCJFEF));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void AFKGJCIANOF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DIKPOHPGNLG();
		}
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
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

	private void Start()
	{
		SelectDialogueUI();
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

	private void DIKPOHPGNLG()
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
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.OldMansDuel))
		{
			dialogue.conversation = "DueloDeViejos/KentaTalk";
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "TermasInterior/Kenta/Intro";
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt >= 0)
		{
			dialogue.conversation = "TermasInterior/Kenta/Stand";
		}
	}

	private void AHIPEAEMEAF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void KJMDNKCJFEF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		CJFIDPLGOMB(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void HMOPLHDOPKK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = false;
			GGFJGHHHEJC.StartConversation(1, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void GOLAJNDPNKP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.JJDCANFBFMK(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMOPLHDOPKK));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KJMDNKCJFEF));
			walkTo.PEHELKCIECB();
		}
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	public void CJFIDPLGOMB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.OGLJDLEGJAA(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMOPLHDOPKK));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MJDFKJBFMPO));
			walkTo.EHDKLBLKBEO();
		}
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void PIBMIDIMPHP()
	{
	}
}
