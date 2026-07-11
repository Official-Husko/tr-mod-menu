using UnityEngine;

public class KyrohSwitchingFood : KyrohStateBase
{
	private float timeToSwitch;

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		kyrohNPC.kyrohState = KyrohState.SwitchingFood;
		kyrohNPC.animationBase.SetTrigger("SwitchFood");
		timeToSwitch = Time.time + 1.75f;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (Time.time >= timeToSwitch)
		{
			NinjaFoodTablesManager.instance.SwitchFoodAtTables();
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		}
	}
}
