using UnityEngine;

public class NinjaCustomerStateBase : StateMachineBehaviour
{
	protected HumanNPC npc;

	protected NinjaCustomer ninjaChallengeCustomer;

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		npc = ((Component)ONDMDLMHMHK).GetComponent<HumanNPC>();
		ninjaChallengeCustomer = ((Component)ONDMDLMHMHK).GetComponent<NinjaCustomer>();
		if (ninjaChallengeCustomer.npc.walkTo != null)
		{
			ninjaChallengeCustomer.npc.walkTo.isActive = false;
		}
	}
}
