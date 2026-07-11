using UnityEngine;

public class KyrohWalkTo : KyrohStateBase
{
	private WalkToState walkToState = new WalkToState();

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		kyrohNPC.kyrohState = KyrohState.WalkTo;
		walkToState.LBMAPIJJMGL(kyrohNPC);
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		walkToState.JDHKHKJOKFF();
	}
}
