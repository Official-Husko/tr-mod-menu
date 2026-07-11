using UnityEngine;

public class KyrohInactive : KyrohStateBase
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		kyrohNPC.kyrohState = KyrohState.Inactive;
		kyrohNPC.trayHandler.RemoveAllDrinks();
		((Component)kyrohNPC).transform.position = new Vector3(-60f, 0f);
	}
}
