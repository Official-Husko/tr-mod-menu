using UnityEngine;

public class KlaynWaitEvent : KlaynStateBase
{
	public override void JDHKHKJOKFF()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		klaynNPC.klaynState = KlaynState.Wait;
	}
}
