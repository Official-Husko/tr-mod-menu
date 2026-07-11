using UnityEngine;

public class CatStateSleep : CatStateBase
{
	private float wakeUpTime;

	public override void GFBLAEEOPAO()
	{
		if (Time.fixedTime > wakeUpTime)
		{
			catNpc.catAnimation.Sleep(NJHMBMGKCPL: false, CDPAMNIPPEC: true);
			catNpc.WalkAround();
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		wakeUpTime = Time.fixedTime + (float)Random.Range(10, 20);
		catNpc.catAnimation.Sleep(NJHMBMGKCPL: true, CDPAMNIPPEC: true);
		catNpc.lastFreePathNode = Vector2.op_Implicit(((Component)catNpc).transform.position);
		if ((Object)(object)catNpc.catBed != (Object)null)
		{
			catNpc.catBed.catNPC = catNpc;
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)catNpc.catBed != (Object)null)
		{
			if (catNpc.catBed.tower)
			{
				((Component)catNpc).transform.position = catNpc.catBed.sitLocation.transform.position + new Vector3(0f, -0.5f, 0f);
			}
			catNpc.catBed.catNPC = null;
		}
		catNpc.catAnimation.Sleep(NJHMBMGKCPL: false, CDPAMNIPPEC: true);
	}
}
