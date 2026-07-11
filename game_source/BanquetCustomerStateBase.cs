using UnityEngine;

public class BanquetCustomerStateBase : StateMachineBehaviour
{
	protected HumanNPC npc;

	protected BanquetCustomer banquetCustomer;

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		npc = ((Component)ONDMDLMHMHK).GetComponent<HumanNPC>();
		banquetCustomer = ((Component)ONDMDLMHMHK).GetComponent<BanquetCustomer>();
		if (banquetCustomer.npc.walkTo != null)
		{
			banquetCustomer.npc.walkTo.isActive = false;
		}
	}
}
