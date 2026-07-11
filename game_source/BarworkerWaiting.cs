using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BarworkerWaiting : BarworkerBaseState
{
	[CompilerGenerated]
	private sealed class JMMCCFDNGFI
	{
		public BarworkerWaiting _003C_003E4__this;

		public Animator animator;

		internal void CCMNDPOJOEB()
		{
			_003C_003E4__this.staff.npc.requestInfo.avoidWalls = false;
			_003C_003E4__this.barworker.characterAnimation.LookDirection(Direction.Down);
			CommonReferences.GGFJGHHHEJC.OnBarworkerGoingToWork(1);
		}

		internal void MCGGOAKFPLO()
		{
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (!barworker.StartTask())
		{
			barworker.OEONGPFALKH.IIMEFNIECLI();
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		if (barworker.OEONGPFALKH == null || (Object)(object)Bar.instance == (Object)null || (Object)(object)Bar.instance.DIOPEKDLCIH == (Object)null)
		{
			return;
		}
		barworker.avoidingWorkEmote.SetBool(StaffBaseState.p_Avoid, false);
		barworker.barworkerState = BarworkerState.Waiting;
		if (!barworker.StartTask())
		{
			barworker.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(Bar.instance.DIOPEKDLCIH.position));
			NPCWalkTo walkTo = barworker.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				staff.npc.requestInfo.avoidWalls = false;
				barworker.characterAnimation.LookDirection(Direction.Down);
				CommonReferences.GGFJGHHHEJC.OnBarworkerGoingToWork(1);
			});
			NPCWalkTo walkTo2 = barworker.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			});
			barworker.OEONGPFALKH.PEHELKCIECB();
		}
	}
}
