using System;
using UnityEngine;

public class BarworkerLeaving : BarworkerBaseState
{
	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)barworker != (Object)null)
		{
			NPCWalkTo walkTo = barworker.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Remove(walkTo.OnActionComplete, new Action(barworker.DestroyEmployee));
			NPCWalkTo walkTo2 = barworker.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Remove(walkTo2.OnFailStart, new Action(barworker.DestroyEmployee));
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		barworker.barworkerState = BarworkerState.Leaving;
		barworker.npc.requestInfo.avoidWalls = true;
		barworker.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)NPCRoadManager.GetRandomSpawner()).transform.position));
		NPCWalkTo walkTo = barworker.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(barworker.DestroyEmployee));
		NPCWalkTo walkTo2 = barworker.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(barworker.DestroyEmployee));
		barworker.OEONGPFALKH.PEHELKCIECB();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		barworker.OEONGPFALKH.IIMEFNIECLI();
	}
}
