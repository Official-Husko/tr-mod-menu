using UnityEngine;

public class KlaynInactive : KlaynStateBase
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		klaynNPC.klaynState = KlaynState.Inactive;
		klaynNPC.trayHandler.RemoveAllDrinks();
		((Component)klaynNPC).transform.position = new Vector3(-60f, 0f);
	}
}
