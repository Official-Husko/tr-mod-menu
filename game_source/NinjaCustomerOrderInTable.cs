using UnityEngine;

public class NinjaCustomerOrderInTable : NinjaCustomerStateBase
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		ninjaChallengeCustomer.ninjaCustomerState = NinjaCustomerState.OrderInTable;
		NinjaOrdersManager.instance.RequestTableOrder(ninjaChallengeCustomer);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		ninjaChallengeCustomer.RemoveOrder();
	}
}
