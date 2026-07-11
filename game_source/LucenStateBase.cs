using UnityEngine;

public class LucenStateBase : GenericStateBase
{
	[SerializeField]
	protected LucenNPC lucenNPC;

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		lucenNPC.lucenState = (LucenState)GetStateEnumID();
	}

	public override void InitializeState(GenericStateMachine ELKILIBAAKF, bool GDHCBGCIIKG = false)
	{
		base.InitializeState(ELKILIBAAKF, GDHCBGCIIKG);
		if ((Object)(object)lucenNPC == (Object)null)
		{
			lucenNPC = ((Component)this).GetComponentInParent<LucenNPC>();
		}
		if (!((Object)(object)lucenNPC == (Object)null))
		{
			lucenNPC.lucenStateBase = this;
			lucenNPC.walkTo.isActive = false;
		}
	}
}
