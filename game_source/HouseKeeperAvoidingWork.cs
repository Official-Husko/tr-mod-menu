using UnityEngine;

public class HouseKeeperAvoidingWork : HouseKeeperBaseState
{
	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		houseKeeper.workerAvoidingWork?.JDHKHKJOKFF();
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		houseKeeper.workerAvoidingWork?.DNGEAILBLII();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		houseKeeper.avoidingWorkEmote.SetBool(StaffBaseState.p_Avoid, true);
		houseKeeper.houseKeeperState = HouseKeeperState.AvoidingWork;
		houseKeeper.workerAvoidingWork?.LBMAPIJJMGL();
	}
}
