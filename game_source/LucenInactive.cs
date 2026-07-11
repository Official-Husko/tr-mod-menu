using UnityEngine;

public class LucenInactive : LucenStateBase
{
	public override int GetStateEnumID()
	{
		return 0;
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		base.EnterState(GDHCBGCIIKG);
		((Component)lucenNPC).transform.position = new Vector3(-60f, 0f);
	}
}
