using UnityEngine;

public class AnimalSleepState : AnimalStateBase
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Sleep, EGFGNGJGBOP: true);
		if (OnlineManager.IsMasterClient())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Sleep, AODONKKHPBP: true);
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		animalNpc.FFHHEGALBKO.SetBool(AnimalStateBase.p_Sleep, EGFGNGJGBOP: false);
		if (OnlineManager.IsMasterClient())
		{
			animalNpc.onlineAnimal.SendSetBool(AnimalStateBase.p_Sleep, AODONKKHPBP: false);
		}
	}
}
