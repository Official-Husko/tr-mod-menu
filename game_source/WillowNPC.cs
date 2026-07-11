using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WillowNPC : DialogueNPCBase
{
	private static WillowNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public static WillowNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void HMEFIIDEMOL(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static WillowNPC DIHCEGINELM()
	{
		return IADEMLIIDPC;
	}

	public override bool MouseUp(int JIIGOACEIKL)
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
		}
		else if (!canTalk && !inUse)
		{
			noPortrait = true;
			StartObserverDialogue(JIIGOACEIKL);
		}
		return false;
	}

	[SpecialName]
	public static WillowNPC HEKFJEKFMNO()
	{
		return IADEMLIIDPC;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void FACKKGAODPO(string emotion)
	{
		PDECKLKPKCG().emotionsController.DCCNJLBLFGI(emotion);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private IEnumerator KACNGNMNFNK(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator KKKHEHHGDEO(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static WillowNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	public void EEBOKKANBEM(string emotion)
	{
		BDAGIEIJOOG().emotionsController.StartEmotion(emotion);
	}

	public override void InitDialogueStart()
	{
		if (mouseUpTrigger)
		{
			inInteractiveDialogue = true;
			main = true;
			DisableDialogue();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.OnDialogueStart(inInteractiveDialogue);
			}
			mouseUpTrigger = false;
		}
	}

	public void EICNDMGMPLE(string emotion)
	{
		DIHCEGINELM().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static WillowNPC PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		dialogue.conversation = "City/Carpenters/Willow/Stand";
	}

	public void IGNCCLNIIJM(string emotion)
	{
		PDECKLKPKCG().emotionsController.EMMBEAHMDHE(emotion);
	}
}
