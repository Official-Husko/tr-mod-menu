using UnityEngine;

public class BanquetCustomerStateOrderInTable : BanquetCustomerStateBase
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		banquetCustomer.banquetCustomerState = BanquetCustomerState.OrderInTable;
		BanquetOrdersManager.instance.RequestTableOrder(banquetCustomer);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		banquetCustomer.RemoveTableOrder();
		BanquetOrdersManager.instance.RemoveTableOrder(banquetCustomer);
	}
}
