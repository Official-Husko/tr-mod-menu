using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BuzzNPCVariant : DialogueNPCBase
{
	public NPCAnimation buzzAnimation;

	public Animator workTableAnimator;

	[HideInInspector]
	public MultiAudioSource rummageAudio;

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse && !inBark && canTalk && IsAvailableByProximity(JIIGOACEIKL))
		{
			StopConversation();
			base.EHHOHCPHAAO = JIIGOACEIKL;
			DialogueManager.Bark("Farm/Buzz/Bark_Build", ((Component)this).transform);
			return true;
		}
		return false;
	}

	public void KNPNNFKDNHO()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: false);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 0);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, true);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 1);
	}

	public void OOAPFIGEHIG()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: false, HALNIEBONKH: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 0);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, false);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 1);
	}

	protected override void NJJCCIBDAPM()
	{
		dialogue.conversation = "Farm/Buzz/Main";
	}

	public void CDNIKFAJBIL()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 1);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, true);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 1);
	}

	public void HAPCNFIJFGK()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: true, HALNIEBONKH: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 0);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, true);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 1);
	}

	public override DialogueNPCBase GetInstance()
	{
		return null;
	}

	public void GGAKLILMGJH()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: true, HALNIEBONKH: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 1);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, false);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 1);
	}

	public void NHMKCEGCAJG()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 0);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, true);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 0);
	}

	public void JOKECHPLNIL()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: false);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 1);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, false);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 0);
	}

	public void PJKEIONIILM()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: false, HALNIEBONKH: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 1);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, false);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 1);
	}

	public void Saw()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 0);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, true);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 0);
	}

	public void ACELPKBEKPE()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 0);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, false);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 1);
	}

	public void FJJHBMJIIBL()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 1);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, false);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 1);
	}

	public void HANFNIOKHLA()
	{
		buzzAnimation.SetBool(NPC.KKFOOFMPHDH, EGFGNGJGBOP: false, HALNIEBONKH: true);
		buzzAnimation.Play(NPC.KKFOOFMPHDH, 0);
		workTableAnimator.SetBool(NPC.KKFOOFMPHDH, false);
		workTableAnimator.Play(NPC.KKFOOFMPHDH, 0);
	}

	protected override void Awake()
	{
		base.Awake();
		NJJCCIBDAPM();
	}
}
