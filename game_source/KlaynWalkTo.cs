using UnityEngine;

public class KlaynWalkTo : KlaynStateBase
{
	private WalkToState walkToState = new WalkToState();

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		walkToState.JDHKHKJOKFF();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		klaynNPC.klaynState = KlaynState.WalkTo;
		walkToState.LBMAPIJJMGL(klaynNPC);
	}
}
