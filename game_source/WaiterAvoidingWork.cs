using UnityEngine;

public class WaiterAvoidingWork : WaiterBaseState
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.avoidingWorkEmote.SetBool(StaffBaseState.p_Avoid, true);
		waiter.waiterState = WaiterState.AvoidingWork;
		waiter.workerAvoidingWork?.LBMAPIJJMGL();
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.workerAvoidingWork.DNGEAILBLII();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		waiter.workerAvoidingWork.JDHKHKJOKFF();
	}
}
