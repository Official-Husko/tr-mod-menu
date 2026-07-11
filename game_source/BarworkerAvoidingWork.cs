using UnityEngine;

public class BarworkerAvoidingWork : BarworkerBaseState
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		barworker.avoidingWorkEmote.SetBool(StaffBaseState.p_Avoid, true);
		barworker.npc.requestInfo.avoidWalls = true;
		barworker.barworkerState = BarworkerState.AvoidingWork;
		barworker.workerAvoidingWork?.LBMAPIJJMGL();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		barworker.workerAvoidingWork?.JDHKHKJOKFF();
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		barworker.workerAvoidingWork?.DNGEAILBLII();
	}
}
