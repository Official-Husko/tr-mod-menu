using UnityEngine;

public class NinjaCustomerIdle : NinjaCustomerStateBase
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		ninjaChallengeCustomer.ninjaCustomerState = NinjaCustomerState.Idle;
		ninjaChallengeCustomer.npc.animationBase.SetBool("Eating", EGFGNGJGBOP: false);
		ninjaChallengeCustomer.npc.animationBase.SetBool("HandUp", EGFGNGJGBOP: false);
	}
}
