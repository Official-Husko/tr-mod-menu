using UnityEngine;

public class BouncerAvoidingWork : BouncerBaseState
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		bouncer.avoidingWorkEmote.SetBool(StaffBaseState.p_Avoid, true);
		bouncer.bouncerState = BouncerState.AvoidingWork;
		bouncer.workerAvoidingWork?.LBMAPIJJMGL();
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		bouncer.workerAvoidingWork?.DNGEAILBLII();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		bouncer.workerAvoidingWork?.JDHKHKJOKFF();
	}
}
